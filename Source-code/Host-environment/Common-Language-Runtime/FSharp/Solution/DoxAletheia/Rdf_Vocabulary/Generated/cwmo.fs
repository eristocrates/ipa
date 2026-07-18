namespace http.purl.org.cwmo.hash

open DoxAletheia.Rdf_Vocabulary

module cwmo =
    let _namespace_name = "http://purl.org/cwmo/#"
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#ABTesting"></see>
    /// </summary>
    let ABTesting = Namespaced_IRI.parse _namespace_name "ABTesting" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasCreativePhase"></see>
    /// </summary>
    let hasCreativePhase =
        Namespaced_IRI.parse _namespace_name "hasCreativePhase" |> NamespacedName

    /// <summary>
    /// The Implementation and monitoring class is a phase of the creative process where the readiness of the idea  is tested. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008).
    /// <see href="http://purl.org/cwmo/#ImplementAndMonitoring"></see></summary>
    let ImplementAndMonitoring =
        Namespaced_IRI.parse _namespace_name "ImplementAndMonitoring" |> NamespacedName

    /// <summary>
    /// A creative method produce different results which can be classified according to these typology: exploration, generation, and/or evaluation.
    /// <see href="http://purl.org/cwmo/#hasFunction"></see></summary>
    let hasFunction =
        Namespaced_IRI.parse _namespace_name "hasFunction" |> NamespacedName

    /// <summary>
    /// The evluation class is a creative technic which has the purpose to evaluate/sort/contextualise the ideas.
    /// <see href="http://purl.org/cwmo/#Evaluation"></see></summary>
    let Evaluation = Namespaced_IRI.parse _namespace_name "Evaluation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasInputType"></see>
    /// </summary>
    let hasInputType =
        Namespaced_IRI.parse _namespace_name "hasInputType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Behavioral"></see>
    /// </summary>
    let Behavioral = Namespaced_IRI.parse _namespace_name "Behavioral" |> NamespacedName

    /// <summary>
    /// A creative technic produce data (that leads to idea) which is qualitative, quantitative or both.
    /// <see href="http://purl.org/cwmo/#isProducingData"></see></summary>
    let isProducingData =
        Namespaced_IRI.parse _namespace_name "isProducingData" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#QuantitativeData"></see>
    /// </summary>
    let QuantitativeData =
        Namespaced_IRI.parse _namespace_name "QuantitativeData" |> NamespacedName

    /// <summary>
    /// A creative method is related to another creative method according to the method principle or mechanism involved.
    /// <see href="http://purl.org/cwmo/#isRelatedTo"></see></summary>
    let isRelatedTo =
        Namespaced_IRI.parse _namespace_name "isRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Experiment"></see>
    /// </summary>
    let Experiment = Namespaced_IRI.parse _namespace_name "Experiment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#KeyPerfIndicator"></see>
    /// </summary>
    let KeyPerfIndicator =
        Namespaced_IRI.parse _namespace_name "KeyPerfIndicator" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#WebAnalytics"></see>
    /// </summary>
    let WebAnalytics =
        Namespaced_IRI.parse _namespace_name "WebAnalytics" |> NamespacedName

    /// <summary>
    /// The creativre technic class is the technic applied by the ideator to generated ideas
    /// <see href="http://purl.org/cwmo/#CreativeTechnique"></see></summary>
    let CreativeTechnique =
        Namespaced_IRI.parse _namespace_name "CreativeTechnique" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#AM"></see>
    /// </summary>
    let AM = Namespaced_IRI.parse _namespace_name "AM" |> NamespacedName

    /// <summary>
    /// The context type class gather the typology of creative workshop context
    /// <see href="http://purl.org/cwmo/#ContextType"></see></summary>
    let ContextType =
        Namespaced_IRI.parse _namespace_name "ContextType" |> NamespacedName

    /// <summary>
    /// The activity class gather the different activities realised during a creative workshop
    /// <see href="http://purl.org/cwmo/#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    /// The advice is provided by the expert to a creative team and can concern an idea or a technique.
    /// <see href="http://purl.org/cwmo/#Advice"></see></summary>
    let Advice = Namespaced_IRI.parse _namespace_name "Advice" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#AffinityDiagramming"></see>
    /// </summary>
    let AffinityDiagramming =
        Namespaced_IRI.parse _namespace_name "AffinityDiagramming" |> NamespacedName

    /// <summary>
    /// The evaluation and rafinement is an iterative phase of testing and feedback about a production. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008).
    /// <see href="http://purl.org/cwmo/#EvalAndRafinement"></see></summary>
    let EvalAndRafinement =
        Namespaced_IRI.parse _namespace_name "EvalAndRafinement" |> NamespacedName

    /// <summary>
    /// Exploration, synthesis and design implications
    /// The synthesis class represent the phase of the creative process where further information a researched. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008).
    /// <see href="http://purl.org/cwmo/#Synthesis"></see></summary>
    let Synthesis = Namespaced_IRI.parse _namespace_name "Synthesis" |> NamespacedName
    /// <summary>
    /// The ideation class is a phase of the creative process where ideas to respond to the problematic are generated.
    /// <see href="http://purl.org/cwmo/#Ideation"></see></summary>
    let Ideation = Namespaced_IRI.parse _namespace_name "Ideation" |> NamespacedName
    /// <summary>
    /// The Generation class is a creative technic which has the purpose to generate ideas.
    /// <see href="http://purl.org/cwmo/#Generation"></see></summary>
    let Generation = Namespaced_IRI.parse _namespace_name "Generation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Attitudinal"></see>
    /// </summary>
    let Attitudinal =
        Namespaced_IRI.parse _namespace_name "Attitudinal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#QualitativeData"></see>
    /// </summary>
    let QualitativeData =
        Namespaced_IRI.parse _namespace_name "QualitativeData" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#UsabilityTesting"></see>
    /// </summary>
    let UsabilityTesting =
        Namespaced_IRI.parse _namespace_name "UsabilityTesting" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#ContextualDesign"></see>
    /// </summary>
    let ContextualDesign =
        Namespaced_IRI.parse _namespace_name "ContextualDesign" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#KJTechnique"></see>
    /// </summary>
    let KJTechnique =
        Namespaced_IRI.parse _namespace_name "KJTechnique" |> NamespacedName

    /// <summary>
    /// Creative technic require some equipement to be implemented.
    /// <see href="http://purl.org/cwmo/#requireEquipment"></see></summary>
    let requireEquipment =
        Namespaced_IRI.parse _namespace_name "requireEquipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#PostIt"></see>
    /// </summary>
    let PostIt = Namespaced_IRI.parse _namespace_name "PostIt" |> NamespacedName

    /// <summary>
    /// The application mode class defined the different mode of application of a creative technique
    /// <see href="http://purl.org/cwmo/#ApplicationMode"></see></summary>
    let ApplicationMode =
        Namespaced_IRI.parse _namespace_name "ApplicationMode" |> NamespacedName

    /// <summary>
    /// The artefact class is a visual or physical representation of an idea.
    /// <see href="http://purl.org/cwmo/#Artifact"></see></summary>
    let Artifact = Namespaced_IRI.parse _namespace_name "Artifact" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#BendItShapeIt"></see>
    /// </summary>
    let BendItShapeIt =
        Namespaced_IRI.parse _namespace_name "BendItShapeIt" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#appliedInContextType"></see>
    /// </summary>
    let appliedInContextType =
        Namespaced_IRI.parse _namespace_name "appliedInContextType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#NPD"></see>
    /// </summary>
    let NPD = Namespaced_IRI.parse _namespace_name "NPD" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#PSI"></see>
    /// </summary>
    let PSI = Namespaced_IRI.parse _namespace_name "PSI" |> NamespacedName
    /// <summary>
    /// estimates how complicated is a technic to implement. Low, medium, high
    /// <see href="http://purl.org/cwmo/#difficulty"></see></summary>
    let difficulty = Namespaced_IRI.parse _namespace_name "difficulty" |> NamespacedName
    /// <summary>
    /// minimun amount of time required to apply a technic.
    /// <see href="http://purl.org/cwmo/#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// how much energy must be invested to complete the technic.
    /// <see href="http://purl.org/cwmo/#energy"></see></summary>
    let energy = Namespaced_IRI.parse _namespace_name "energy" |> NamespacedName
    /// <summary>
    /// estimated likelihood that a technic will provoke mirth and humor. Low, medium, high.
    /// <see href="http://purl.org/cwmo/#funFactor"></see></summary>
    let funFactor = Namespaced_IRI.parse _namespace_name "funFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasApplicationMode"></see>
    /// </summary>
    let hasApplicationMode =
        Namespaced_IRI.parse _namespace_name "hasApplicationMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#IndividualMode"></see>
    /// </summary>
    let IndividualMode =
        Namespaced_IRI.parse _namespace_name "IndividualMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#CollectiveMode"></see>
    /// </summary>
    let CollectiveMode =
        Namespaced_IRI.parse _namespace_name "CollectiveMode" |> NamespacedName

    /// <summary>
    /// probability of a technic will result a relatively large quantity of ideas within the available time. Low, medium, high probability
    /// <see href="http://purl.org/cwmo/#ideaQuantity"></see></summary>
    let ideaQuantity =
        Namespaced_IRI.parse _namespace_name "ideaQuantity" |> NamespacedName

    /// <summary>
    /// probability that ideas produced will possess statistical infrequency. Low, medium, high probability
    /// <see href="http://purl.org/cwmo/#novelty"></see></summary>
    let novelty = Namespaced_IRI.parse _namespace_name "novelty" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#requireStimuliType"></see>
    /// </summary>
    let requireStimuliType =
        Namespaced_IRI.parse _namespace_name "requireStimuliType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Related"></see>
    /// </summary>
    let Related = Namespaced_IRI.parse _namespace_name "Related" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Unrelated"></see>
    /// </summary>
    let Unrelated = Namespaced_IRI.parse _namespace_name "Unrelated" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Bodystorming"></see>
    /// </summary>
    let Bodystorming =
        Namespaced_IRI.parse _namespace_name "Bodystorming" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Roleplaying"></see>
    /// </summary>
    let Roleplaying =
        Namespaced_IRI.parse _namespace_name "Roleplaying" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#ExperiencePrototyping"></see>
    /// </summary>
    let ExperiencePrototyping =
        Namespaced_IRI.parse _namespace_name "ExperiencePrototyping" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#SimulationExercise"></see>
    /// </summary>
    let SimulationExercise =
        Namespaced_IRI.parse _namespace_name "SimulationExercise" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Completeness"></see>
    /// </summary>
    let Completeness =
        Namespaced_IRI.parse _namespace_name "Completeness" |> NamespacedName

    /// <summary>
    /// The Evaluation criteria class is the specific aspect to obsverve on idea. It is defined according to the constraints of the subject.
    /// <see href="http://purl.org/cwmo/#EvaluationCriteria"></see></summary>
    let EvaluationCriteria =
        Namespaced_IRI.parse _namespace_name "EvaluationCriteria" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Complexity"></see>
    /// </summary>
    let Complexity = Namespaced_IRI.parse _namespace_name "Complexity" |> NamespacedName

    /// <summary>
    /// the phase of concept generation and eraly prototyping is an itarative phase that involves participatory and generative design activities. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008).
    /// <see href="http://purl.org/cwmo/#ConceptGeneration"></see></summary>
    let ConceptGeneration =
        Namespaced_IRI.parse _namespace_name "ConceptGeneration" |> NamespacedName

    /// <summary>
    /// The creative phase class is the decompastion of the creative process into steps/ phases which implies different nature of activities, goals and interaction.
    /// <see href="http://purl.org/cwmo/#CreativePhase"></see></summary>
    let CreativePhase =
        Namespaced_IRI.parse _namespace_name "CreativePhase" |> NamespacedName

    /// <summary>
    /// The constraint class is the textual description of the element that limit the subject. It is related to the strategy of the company, the constraint associated with the activity domain of the organizations, …
    /// <see href="http://purl.org/cwmo/#Constraint"></see></summary>
    let Constraint = Namespaced_IRI.parse _namespace_name "Constraint" |> NamespacedName
    /// <summary>
    /// organizational condition in wich the problem is defined (Stratégique, Nouveau produit, processus ou service, Améliorations produit, processus ou service, publicité/marketing, Ressources humaines)
    /// <see href="http://purl.org/cwmo/#Context"></see></summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName

    /// <summary>
    /// The creative strategy is a selection of creative techniques defined by the a facilitator in order to respond to the subject
    /// <see href="http://purl.org/cwmo/#CreativeStrategy"></see></summary>
    let CreativeStrategy =
        Namespaced_IRI.parse _namespace_name "CreativeStrategy" |> NamespacedName

    /// <summary>
    /// The creative team class is a group of ideator who attempt to generated ideas to respond a problematic
    /// <see href="http://purl.org/cwmo/#CreativeTeam"></see></summary>
    let CreativeTeam =
        Namespaced_IRI.parse _namespace_name "CreativeTeam" |> NamespacedName

    /// <summary>
    /// The CreativeWorkshop class  represent an event organized by an organizer to solve a problem formulated into a subject and provided by a decision-maker, and solved by a creative team.
    /// <see href="http://purl.org/cwmo/#CreativeWorkshop"></see></summary>
    let CreativeWorkshop =
        Namespaced_IRI.parse _namespace_name "CreativeWorkshop" |> NamespacedName

    /// <summary>
    /// Data type class define the form in which that content is typically collected and communicated.
    /// <see href="http://purl.org/cwmo/#DataType"></see></summary>
    let DataType = Namespaced_IRI.parse _namespace_name "DataType" |> NamespacedName

    /// <summary>
    /// Decision Maker is one of the role assumed by a person during the creative workshop. He provides the problem to solve during the workshop and has the decision ability concerning the future of the idea generated.
    /// <see href="http://purl.org/cwmo/#DecisionMaker"></see></summary>
    let DecisionMaker =
        Namespaced_IRI.parse _namespace_name "DecisionMaker" |> NamespacedName

    /// <summary>
    /// The defintion class is a phase of the creative process where project parameters are explored and defined. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008).
    /// <see href="http://purl.org/cwmo/#Definition"></see></summary>
    let Definition = Namespaced_IRI.parse _namespace_name "Definition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#DesignProcess"></see>
    /// </summary>
    let DesignProcess =
        Namespaced_IRI.parse _namespace_name "DesignProcess" |> NamespacedName

    /// <summary>
    /// The particpant role class define the role of the person involved in a creative technique. (Martin et al., 2013). It should be distinguished from the role involved in the entire creative workshop process.
    /// <see href="http://purl.org/cwmo/#ParticipantRole"></see></summary>
    let ParticipantRole =
        Namespaced_IRI.parse _namespace_name "ParticipantRole" |> NamespacedName

    /// <summary>
    /// The digital tools class gather the tools available for a digital application of creative techniques
    /// <see href="http://purl.org/cwmo/#DigitalTool"></see></summary>
    let DigitalTool =
        Namespaced_IRI.parse _namespace_name "DigitalTool" |> NamespacedName

    /// <summary>
    /// The tool class is the software and interface used to ease the application of a creative technic and/or collect the data of the creative technic.
    /// <see href="http://purl.org/cwmo/#Tool"></see></summary>
    let Tool = Namespaced_IRI.parse _namespace_name "Tool" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Effectivness"></see>
    /// </summary>
    let Effectivness =
        Namespaced_IRI.parse _namespace_name "Effectivness" |> NamespacedName

    /// <summary>
    /// The material class represent the physical material/ equipment needed.
    /// <see href="http://purl.org/cwmo/#Equipment"></see></summary>
    let Equipment = Namespaced_IRI.parse _namespace_name "Equipment" |> NamespacedName

    /// <summary>
    /// The idea evaluation class is a phase of the creative process where the idea are evluated, sorted or ranked.
    /// <see href="http://purl.org/cwmo/#IdeaEvaluation"></see></summary>
    let IdeaEvaluation =
        Namespaced_IRI.parse _namespace_name "IdeaEvaluation" |> NamespacedName

    /// <summary>
    /// The implementation class is a phase of the creative process where the most interesting ideas are experimented in real condition.
    /// <see href="http://purl.org/cwmo/#Implementation"></see></summary>
    let Implementation =
        Namespaced_IRI.parse _namespace_name "Implementation" |> NamespacedName

    /// <summary>
    /// Technique Function class define the primary purpose of a creative technique.
    /// <see href="http://purl.org/cwmo/#TechniqueFunction"></see></summary>
    let TechniqueFunction =
        Namespaced_IRI.parse _namespace_name "TechniqueFunction" |> NamespacedName

    /// <summary>
    /// The exploration class is a creativ technic which has the porpose to explore the problem, to redefine the scope or the focus of the problem, or to collect further information
    /// <see href="http://purl.org/cwmo/#Exploration"></see></summary>
    let Exploration =
        Namespaced_IRI.parse _namespace_name "Exploration" |> NamespacedName

    /// <summary>
    /// The evaluation strategy class gather the information concerning the evaluation technics, the criteria, and the evaluators affected to respond to the objectives of the creative workshop.
    /// <see href="http://purl.org/cwmo/#EvaluationStrategy"></see></summary>
    let EvaluationStrategy =
        Namespaced_IRI.parse _namespace_name "EvaluationStrategy" |> NamespacedName

    /// <summary>
    /// The evaluation technic class is the way the idea is evaluated. It can be qualitative (Review, sorting (top5),...) or quantitative (rating).
    /// <see href="http://purl.org/cwmo/#EvaluationTechnic"></see></summary>
    let EvaluationTechnic =
        Namespaced_IRI.parse _namespace_name "EvaluationTechnic" |> NamespacedName

    /// <summary>
    /// Evaluator is one of the role assumed by a person during the creative workshop. He evaluate the ideas based on the evaluation strategy according to the evaluation techniques and the criteria associated.
    /// <see href="http://purl.org/cwmo/#Evaluator"></see></summary>
    let Evaluator = Namespaced_IRI.parse _namespace_name "Evaluator" |> NamespacedName
    /// <summary>
    /// Expert is one of the role assumed by a person during the creative workshop. He share his knowledge about the problem or the domain to helps the ideator or the evaluation.
    /// <see href="http://purl.org/cwmo/#Expert"></see></summary>
    let Expert = Namespaced_IRI.parse _namespace_name "Expert" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#ExpressionMode"></see>
    /// </summary>
    let ExpressionMode =
        Namespaced_IRI.parse _namespace_name "ExpressionMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Expressivness"></see>
    /// </summary>
    let Expressivness =
        Namespaced_IRI.parse _namespace_name "Expressivness" |> NamespacedName

    /// <summary>
    /// Facilitator is one of the role assumed by a person during the creative workshop. He is the person who assist the group of ideator in the application of the activities (creative technique and evaluation technique)
    /// <see href="http://purl.org/cwmo/#Facilitator"></see></summary>
    let Facilitator =
        Namespaced_IRI.parse _namespace_name "Facilitator" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Feasibility"></see>
    /// </summary>
    let Feasibility =
        Namespaced_IRI.parse _namespace_name "Feasibility" |> NamespacedName

    /// <summary>
    /// Evaluation criteria is defined by the decision maker and/or the organizer.
    /// <see href="http://purl.org/cwmo/#isCriterizedBy"></see></summary>
    let isCriterizedBy =
        Namespaced_IRI.parse _namespace_name "isCriterizedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Anon3"></see>
    /// </summary>
    let Anon3 = Namespaced_IRI.parse _namespace_name "Anon3" |> NamespacedName
    /// <summary>
    /// Scale on which the evaluation criteria should be evaluated
    /// <see href="http://purl.org/cwmo/#scale"></see></summary>
    let scale = Namespaced_IRI.parse _namespace_name "scale" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#weight"></see>
    /// </summary>
    let weight = Namespaced_IRI.parse _namespace_name "weight" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#FreeReview"></see>
    /// </summary>
    let FreeReview = Namespaced_IRI.parse _namespace_name "FreeReview" |> NamespacedName

    /// <summary>
    /// Evaluation technic apply evaluation criteria to do the evaluation.
    /// <see href="http://purl.org/cwmo/#applyEvaluationThanks"></see></summary>
    let applyEvaluationThanks =
        Namespaced_IRI.parse _namespace_name "applyEvaluationThanks" |> NamespacedName

    /// <summary>
    /// Evaluation technic is applied by evaluator.
    /// restreindre la relation en fonction de la strategy: TechA evalTechappliedBy Anon for a given strategy
    /// <see href="http://purl.org/cwmo/#evalTechAppliedBy"></see></summary>
    let evalTechAppliedBy =
        Namespaced_IRI.parse _namespace_name "evalTechAppliedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#GuidedReview"></see>
    /// </summary>
    let GuidedReview =
        Namespaced_IRI.parse _namespace_name "GuidedReview" |> NamespacedName

    /// <summary>
    /// The idea class is a beginning of response to the problem. An idea can be from a Creative technic
    /// <see href="http://purl.org/cwmo/#Idea"></see></summary>
    let Idea = Namespaced_IRI.parse _namespace_name "Idea" |> NamespacedName

    /// <summary>
    /// The problem analysis class is a phase of the creative process where the problem is formalized and the information seeked and organized.
    /// <see href="http://purl.org/cwmo/#ProblemAnalysis"></see></summary>
    let ProblemAnalysis =
        Namespaced_IRI.parse _namespace_name "ProblemAnalysis" |> NamespacedName

    /// <summary>
    /// Ideator is one of the role assumed by a person during the creative workshop. He is the person who solve the problem and produce ideas by applying creative techniques
    /// <see href="http://purl.org/cwmo/#Ideator"></see></summary>
    let Ideator = Namespaced_IRI.parse _namespace_name "Ideator" |> NamespacedName
    /// <summary>
    /// Organizer is one of the role assumed by a person during the creative workshop. He is the person who manage the entre workshop by providing the materials, the infrastructure and communicate with the others persons.
    /// <see href="http://purl.org/cwmo/#Organizer"></see></summary>
    let Organizer = Namespaced_IRI.parse _namespace_name "Organizer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Implementability"></see>
    /// </summary>
    let Implementability =
        Namespaced_IRI.parse _namespace_name "Implementability" |> NamespacedName

    /// <summary>
    /// type of centent most appropriatly targeted by the method
    /// <see href="http://purl.org/cwmo/#InputType"></see></summary>
    let InputType = Namespaced_IRI.parse _namespace_name "InputType" |> NamespacedName

    /// <summary>
    /// The Knowledge domain class is the overall knowledge that a person posses or which is associated to an idea or a problem
    /// <see href="http://purl.org/cwmo/#KnowledgeDomain"></see></summary>
    let KnowledgeDomain =
        Namespaced_IRI.parse _namespace_name "KnowledgeDomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#MindMapping"></see>
    /// </summary>
    let MindMapping =
        Namespaced_IRI.parse _namespace_name "MindMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#ConceptMapping"></see>
    /// </summary>
    let ConceptMapping =
        Namespaced_IRI.parse _namespace_name "ConceptMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#BrainstormGraphicOrganizers"></see>
    /// </summary>
    let BrainstormGraphicOrganizers =
        Namespaced_IRI.parse _namespace_name "BrainstormGraphicOrganizers" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Collage"></see>
    /// </summary>
    let Collage = Namespaced_IRI.parse _namespace_name "Collage" |> NamespacedName

    /// <summary>
    /// A creative technic application is supported by tools.
    /// <see href="http://purl.org/cwmo/#isSupportedBy"></see></summary>
    let isSupportedBy =
        Namespaced_IRI.parse _namespace_name "isSupportedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Coggle"></see>
    /// </summary>
    let Coggle = Namespaced_IRI.parse _namespace_name "Coggle" |> NamespacedName
    /// <summary>
    /// The objective is a description of the result expected by the organizations concerning the creative workshop
    /// <see href="http://purl.org/cwmo/#Objective"></see></summary>
    let Objective = Namespaced_IRI.parse _namespace_name "Objective" |> NamespacedName

    /// <summary>
    /// An organization such as a company, SME, institutions, NGO, corporation,  etc.
    /// <see href="http://purl.org/cwmo/#Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Originality"></see>
    /// </summary>
    let Originality =
        Namespaced_IRI.parse _namespace_name "Originality" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Participatory"></see>
    /// </summary>
    let Participatory =
        Namespaced_IRI.parse _namespace_name "Participatory" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Personas"></see>
    /// </summary>
    let Personas = Namespaced_IRI.parse _namespace_name "Personas" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#UserJourneyMaps"></see>
    /// </summary>
    let UserJourneyMaps =
        Namespaced_IRI.parse _namespace_name "UserJourneyMaps" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Scenarios"></see>
    /// </summary>
    let Scenarios = Namespaced_IRI.parse _namespace_name "Scenarios" |> NamespacedName
    /// <summary>
    /// The problem class is the description of the elements that leads the organization to initiate a creative workshop.
    /// <see href="http://purl.org/cwmo/#Problem"></see></summary>
    let Problem = Namespaced_IRI.parse _namespace_name "Problem" |> NamespacedName

    /// <summary>
    /// Typology of stimuli
    /// <see href="http://purl.org/cwmo/#StimuliType"></see></summary>
    let StimuliType =
        Namespaced_IRI.parse _namespace_name "StimuliType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Relevance"></see>
    /// </summary>
    let Relevance = Namespaced_IRI.parse _namespace_name "Relevance" |> NamespacedName
    /// <summary>
    /// Stimuli is used to initiate a creative technique
    /// <see href="http://purl.org/cwmo/#Stimuli"></see></summary>
    let Stimuli = Namespaced_IRI.parse _namespace_name "Stimuli" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Strategy"></see>
    /// </summary>
    let Strategy = Namespaced_IRI.parse _namespace_name "Strategy" |> NamespacedName
    /// <summary>
    /// The subject class is the description of the problerm to solve by the creative group during the creative workshop. It is a transformation/reformulation of the problem.
    /// <see href="http://purl.org/cwmo/#Subject"></see></summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Verbal"></see>
    /// </summary>
    let Verbal = Namespaced_IRI.parse _namespace_name "Verbal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Workability"></see>
    /// </summary>
    let Workability =
        Namespaced_IRI.parse _namespace_name "Workability" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#Written"></see>
    /// </summary>
    let Written = Namespaced_IRI.parse _namespace_name "Written" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#adviceAdressedTo"></see>
    /// </summary>
    let adviceAdressedTo =
        Namespaced_IRI.parse _namespace_name "adviceAdressedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#advicedBy"></see>
    /// </summary>
    let advicedBy = Namespaced_IRI.parse _namespace_name "advicedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#provideAdvice"></see>
    /// </summary>
    let provideAdvice =
        Namespaced_IRI.parse _namespace_name "provideAdvice" |> NamespacedName

    /// <summary>
    /// Evaluation criteria is applied during an evaluation technic.
    /// <see href="http://purl.org/cwmo/#isEvaluatedDuring"></see></summary>
    let isEvaluatedDuring =
        Namespaced_IRI.parse _namespace_name "isEvaluatedDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#coverDomain"></see>
    /// </summary>
    let coverDomain =
        Namespaced_IRI.parse _namespace_name "coverDomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#isCoveredBy"></see>
    /// </summary>
    let isCoveredBy =
        Namespaced_IRI.parse _namespace_name "isCoveredBy" |> NamespacedName

    /// <summary>
    /// Evaluation criteria is defined by the decision maker and/or the organizer.
    /// <see href="http://purl.org/cwmo/#criteriaIsDefinedBy"></see></summary>
    let criteriaIsDefinedBy =
        Namespaced_IRI.parse _namespace_name "criteriaIsDefinedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#equipe"></see>
    /// </summary>
    let equipe = Namespaced_IRI.parse _namespace_name "equipe" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#evalStratPlannedBy"></see>
    /// </summary>
    let evalStratPlannedBy =
        Namespaced_IRI.parse _namespace_name "evalStratPlannedBy" |> NamespacedName

    /// <summary>
    /// An evaluation strategy evaluate the ideas associated to a subject. The strategy is dependant of the differnt element that define the subject (context, decision-maker, ...)
    /// <see href="http://purl.org/cwmo/#evaluateResponseTo"></see></summary>
    let evaluateResponseTo =
        Namespaced_IRI.parse _namespace_name "evaluateResponseTo" |> NamespacedName

    /// <summary>
    /// creative technqiue has different function: exploration of the subject/ domain of the problem, generation of idea, and evluation of idea
    /// <see href="http://purl.org/cwmo/#function"></see></summary>
    let function_ = Namespaced_IRI.parse _namespace_name "function" |> NamespacedName
    /// <summary>
    /// An idea is written by an ideator.
    /// <see href="http://purl.org/cwmo/#hasAuthor"></see></summary>
    let hasAuthor = Namespaced_IRI.parse _namespace_name "hasAuthor" |> NamespacedName

    /// <summary>
    /// An idea has been produced during the application of a creative technic.
    /// <see href="http://purl.org/cwmo/#hasCTSource"></see></summary>
    let hasCTSource =
        Namespaced_IRI.parse _namespace_name "hasCTSource" |> NamespacedName

    /// <summary>
    /// An idea has been produced during the a creative workshop.
    /// <see href="http://purl.org/cwmo/#hasCWSource"></see></summary>
    let hasCWSource =
        Namespaced_IRI.parse _namespace_name "hasCWSource" |> NamespacedName

    /// <summary>
    /// A problem is defined according to a context.
    /// <see href="http://purl.org/cwmo/#hasContext"></see></summary>
    let hasContext = Namespaced_IRI.parse _namespace_name "hasContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasContextType"></see>
    /// </summary>
    let hasContextType =
        Namespaced_IRI.parse _namespace_name "hasContextType" |> NamespacedName

    /// <summary>
    /// Creative Strategy is composed by one or several creative techniques
    /// <see href="http://purl.org/cwmo/#hasCreatTechnic"></see></summary>
    let hasCreatTechnic =
        Namespaced_IRI.parse _namespace_name "hasCreatTechnic" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasEquivalent"></see>
    /// </summary>
    let hasEquivalent =
        Namespaced_IRI.parse _namespace_name "hasEquivalent" |> NamespacedName

    /// <summary>
    /// Evaluation technic is part of an evaluation strategy.
    /// <see href="http://purl.org/cwmo/#hasEvalStrat"></see></summary>
    let hasEvalStrat =
        Namespaced_IRI.parse _namespace_name "hasEvalStrat" |> NamespacedName

    /// <summary>
    /// Evaluation strategy is composed by evaluation technic.
    /// <see href="http://purl.org/cwmo/#hasEvalTechnic"></see></summary>
    let hasEvalTechnic =
        Namespaced_IRI.parse _namespace_name "hasEvalTechnic" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasExpressionMode"></see>
    /// </summary>
    let hasExpressionMode =
        Namespaced_IRI.parse _namespace_name "hasExpressionMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasGeneralization"></see>
    /// </summary>
    let hasGeneralization =
        Namespaced_IRI.parse _namespace_name "hasGeneralization" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasSpecialization"></see>
    /// </summary>
    let hasSpecialization =
        Namespaced_IRI.parse _namespace_name "hasSpecialization" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasGenerated"></see>
    /// </summary>
    let hasGenerated =
        Namespaced_IRI.parse _namespace_name "hasGenerated" |> NamespacedName

    /// <summary>
    /// Idea is generated into and by a team.
    /// <see href="http://purl.org/cwmo/#hasGroupAuthor"></see></summary>
    let hasGroupAuthor =
        Namespaced_IRI.parse _namespace_name "hasGroupAuthor" |> NamespacedName

    /// <summary>
    /// Concept whose semantic field is broader than that of a hyponym.
    /// <see href="http://purl.org/cwmo/#hasHypernym"></see></summary>
    let hasHypernym =
        Namespaced_IRI.parse _namespace_name "hasHypernym" |> NamespacedName

    /// <summary>
    /// Concept whose semantic field is more specific than its hypernym
    /// <see href="http://purl.org/cwmo/#hasHyponym"></see></summary>
    let hasHyponym = Namespaced_IRI.parse _namespace_name "hasHyponym" |> NamespacedName
    /// <summary>
    /// A creative Team is composed by several ideator
    /// <see href="http://purl.org/cwmo/#hasIdeator"></see></summary>
    let hasIdeator = Namespaced_IRI.parse _namespace_name "hasIdeator" |> NamespacedName
    /// <summary>
    /// A creative method requires some parametrs to be applied properly. these inputs can be a problematic, aditional information, ...
    /// <see href="http://purl.org/cwmo/#hasInput"></see></summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasKnowledge"></see>
    /// </summary>
    let hasKnowledge =
        Namespaced_IRI.parse _namespace_name "hasKnowledge" |> NamespacedName

    /// <summary>
    /// The creative technic can be follewed by another creative technic.
    /// <see href="http://purl.org/cwmo/#hasNext"></see></summary>
    let hasNext = Namespaced_IRI.parse _namespace_name "hasNext" |> NamespacedName

    /// <summary>
    /// The creative technic can be preceed by another creative technic.
    /// <see href="http://purl.org/cwmo/#hasPrevious"></see></summary>
    let hasPrevious =
        Namespaced_IRI.parse _namespace_name "hasPrevious" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasOutput"></see>
    /// </summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName

    /// <summary>
    /// Creative workshop has participant with different role.
    /// <see href="http://purl.org/cwmo/#hasParticipant"></see></summary>
    let hasParticipant =
        Namespaced_IRI.parse _namespace_name "hasParticipant" |> NamespacedName

    /// <summary>
    /// The person with a role is participating to the workshop
    /// <see href="http://purl.org/cwmo/#isParticipatingTo"></see></summary>
    let isParticipatingTo =
        Namespaced_IRI.parse _namespace_name "isParticipatingTo" |> NamespacedName

    /// <summary>
    /// Facilitator define the creative strategy
    /// <see href="http://purl.org/cwmo/#hasPlanified"></see></summary>
    let hasPlanified =
        Namespaced_IRI.parse _namespace_name "hasPlanified" |> NamespacedName

    /// <summary>
    /// The creative strategy is defined by a facilitator
    /// <see href="http://purl.org/cwmo/#isPlanifiedBy"></see></summary>
    let isPlanifiedBy =
        Namespaced_IRI.parse _namespace_name "isPlanifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasRole"></see>
    /// </summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasStimuliInput"></see>
    /// </summary>
    let hasStimuliInput =
        Namespaced_IRI.parse _namespace_name "hasStimuliInput" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasStimuliType"></see>
    /// </summary>
    let hasStimuliType =
        Namespaced_IRI.parse _namespace_name "hasStimuliType" |> NamespacedName

    /// <summary>
    /// Concept that means exactly or nearly the same as another concept.
    /// <see href="http://purl.org/cwmo/#hasSynonym"></see></summary>
    let hasSynonym = Namespaced_IRI.parse _namespace_name "hasSynonym" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#hasWeight"></see>
    /// </summary>
    let hasWeight = Namespaced_IRI.parse _namespace_name "hasWeight" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#identifier"></see>
    /// </summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#innovationRange"></see>
    /// </summary>
    let innovationRange =
        Namespaced_IRI.parse _namespace_name "innovationRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#innovationScope"></see>
    /// </summary>
    let innovationScope =
        Namespaced_IRI.parse _namespace_name "innovationScope" |> NamespacedName

    /// <summary>
    /// A creative technic is applied in certain context.
    /// <see href="http://purl.org/cwmo/#isAppliedInContext"></see></summary>
    let isAppliedInContext =
        Namespaced_IRI.parse _namespace_name "isAppliedInContext" |> NamespacedName

    /// <summary>
    /// Properety indicating that a problem is constrainted by constraint of different nature ( the problem itself, the domain, the context, the actor of the domain…)
    /// <see href="http://purl.org/cwmo/#isConstraintedBy"></see></summary>
    let isConstraintedBy =
        Namespaced_IRI.parse _namespace_name "isConstraintedBy" |> NamespacedName

    /// <summary>
    /// Evaluation technic evaluate idea.
    /// <see href="http://purl.org/cwmo/#isEvaluating"></see></summary>
    let isEvaluating =
        Namespaced_IRI.parse _namespace_name "isEvaluating" |> NamespacedName

    /// <summary>
    /// in theory, the creative technic can be follewed by another creative technic. it means the 2 creative technic are by default related by a temporal relation.
    /// <see href="http://purl.org/cwmo/#isFollowedBy"></see></summary>
    let isFollowedBy =
        Namespaced_IRI.parse _namespace_name "isFollowedBy" |> NamespacedName

    /// <summary>
    /// A subject is formalized from a problem.
    /// <see href="http://purl.org/cwmo/#isFormalizedFrom"></see></summary>
    let isFormalizedFrom =
        Namespaced_IRI.parse _namespace_name "isFormalizedFrom" |> NamespacedName

    /// <summary>
    /// A problem is formalized into a subject in order to be adapted for a creative workshop.
    /// <see href="http://purl.org/cwmo/#isFormalizedInto"></see></summary>
    let isFormalizedInto =
        Namespaced_IRI.parse _namespace_name "isFormalizedInto" |> NamespacedName

    /// <summary>
    /// The decision maker define the problem that will be solved during the creative workshop.
    /// <see href="http://purl.org/cwmo/#isFormalizing"></see></summary>
    let isFormalizing =
        Namespaced_IRI.parse _namespace_name "isFormalizing" |> NamespacedName

    /// <summary>
    /// Properety indicating that an idea is generalized by a concept.
    /// <see href="http://purl.org/cwmo/#isGeneralizedBy"></see></summary>
    let isGeneralizedBy =
        Namespaced_IRI.parse _namespace_name "isGeneralizedBy" |> NamespacedName

    /// <summary>
    /// Property indicating that a concept generalize an idea. Althought ideas are different, several can represent the same concept.
    /// <see href="http://purl.org/cwmo/#isGeneralizing"></see></summary>
    let isGeneralizing =
        Namespaced_IRI.parse _namespace_name "isGeneralizing" |> NamespacedName

    /// <summary>
    /// All creative technic are not compatible with each other. A creative technic is not compatible with another.
    /// <see href="http://purl.org/cwmo/#isIncompatibleWith"></see></summary>
    let isIncompatibleWith =
        Namespaced_IRI.parse _namespace_name "isIncompatibleWith" |> NamespacedName

    /// <summary>
    /// Property indicating that an idea as been conctreatized into some physical or visual
    /// <see href="http://purl.org/cwmo/#isMaterializedBy"></see></summary>
    let isMaterializedBy =
        Namespaced_IRI.parse _namespace_name "isMaterializedBy" |> NamespacedName

    /// <summary>
    /// Property indicating that an artifact represent/ symbolize an idea.
    /// <see href="http://purl.org/cwmo/#isMaterializing"></see></summary>
    let isMaterializing =
        Namespaced_IRI.parse _namespace_name "isMaterializing" |> NamespacedName

    /// <summary>
    /// An artefact has been realised by one or several persons. In opposite to the ideas which is from the group, the realisation is individualised.
    /// <see href="http://purl.org/cwmo/#isRealisedBy"></see></summary>
    let isRealisedBy =
        Namespaced_IRI.parse _namespace_name "isRealisedBy" |> NamespacedName

    /// <summary>
    /// A subject is solved during a creative workshop .
    /// <see href="http://purl.org/cwmo/#isSolvedDuring"></see></summary>
    let isSolvedDuring =
        Namespaced_IRI.parse _namespace_name "isSolvedDuring" |> NamespacedName

    /// <summary>
    /// A tool support the application of a creative technic.
    /// <see href="http://purl.org/cwmo/#support"></see></summary>
    let support = Namespaced_IRI.parse _namespace_name "support" |> NamespacedName
    /// <summary>
    /// An organizer organize a creative workshop. He has the responsability of this workshop.
    /// <see href="http://purl.org/cwmo/#organize"></see></summary>
    let organize = Namespaced_IRI.parse _namespace_name "organize" |> NamespacedName

    /// <summary>
    /// Creative Strategy is design to respond to a subject.
    /// <see href="http://purl.org/cwmo/#organizeResponseTo"></see></summary>
    let organizeResponseTo =
        Namespaced_IRI.parse _namespace_name "organizeResponseTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cwmo/#possessEquipment"></see>
    /// </summary>
    let possessEquipment =
        Namespaced_IRI.parse _namespace_name "possessEquipment" |> NamespacedName

    /// <summary>
    /// A subject is described by objective.
    /// <see href="http://purl.org/cwmo/#possessObjective"></see></summary>
    let possessObjective =
        Namespaced_IRI.parse _namespace_name "possessObjective" |> NamespacedName

    /// <summary>
    /// the subject is summerized into an open question that pose the problem.
    /// <see href="http://purl.org/cwmo/#problematic"></see></summary>
    let problematic =
        Namespaced_IRI.parse _namespace_name "problematic" |> NamespacedName

    /// <summary>
    /// procedure details how implement the creative technic .
    /// <see href="http://purl.org/cwmo/#procedure"></see></summary>
    let procedure = Namespaced_IRI.parse _namespace_name "procedure" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#progress"></see>
    /// </summary>
    let progress = Namespaced_IRI.parse _namespace_name "progress" |> NamespacedName
    /// <summary>
    /// the idea has a score once it has been evaluated by the evaluator.
    /// <see href="http://purl.org/cwmo/#score"></see></summary>
    let score = Namespaced_IRI.parse _namespace_name "score" |> NamespacedName
    /// <summary>
    /// creative technique require stimuli to permit ideator apply correctly the method. This stimuli can be related or unrelated to the subject.
    /// <see href="http://purl.org/cwmo/#stimuli"></see></summary>
    let stimuli = Namespaced_IRI.parse _namespace_name "stimuli" |> NamespacedName
    /// <summary>
    /// Usecase is used to describe the idea in context of use.
    /// <see href="http://purl.org/cwmo/#usecase"></see></summary>
    let usecase = Namespaced_IRI.parse _namespace_name "usecase" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/cwmo/#website"></see>
    /// </summary>
    let website = Namespaced_IRI.parse _namespace_name "website" |> NamespacedName
