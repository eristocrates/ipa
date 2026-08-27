namespace http.purl.org.cwmo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cwmo =
    let _namespace_iri = Namespace_Iri cwmo |> NamespaceIRI
    /// <summary>
    ///   <para>cwmo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Creative Workshop Management Ontology"^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#">http://purl.org/cwmo/#</seealso>
    let _prefix_iri = Prefixed_Name(cwmo, "") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:ABTesting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:CreativeTechnique</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#ABTesting">http://purl.org/cwmo/#ABTesting</seealso>
    let ABTesting = Prefixed_Name(cwmo, "ABTesting") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:AM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:ContextType</para>
    ///
    /// labels<para>"Advertising/ Management"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#AM">http://purl.org/cwmo/#AM</seealso>
    let AM = Prefixed_Name(cwmo, "AM") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The activity class gather the different activities realised during a creative workshop"</para>
    /// labels<para>"Activity"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Activity">http://purl.org/cwmo/#Activity</seealso>
    let Activity = Prefixed_Name(cwmo, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Advice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The advice is provided by the expert to a creative team and can concern an idea or a technique."</para>
    /// labels<para>"Advice"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Advice">http://purl.org/cwmo/#Advice</seealso>
    let Advice = Prefixed_Name(cwmo, "Advice") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:AffinityDiagramming</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:CreativeTechnique</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#AffinityDiagramming">http://purl.org/cwmo/#AffinityDiagramming</seealso>
    let AffinityDiagramming = Prefixed_Name(cwmo, "AffinityDiagramming") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Anon3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#Anon3">http://purl.org/cwmo/#Anon3</seealso>
    let Anon3 = Prefixed_Name(cwmo, "Anon3") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:ApplicationMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The application mode class defined the different mode of application of a creative technique"</para>
    /// labels<para>"Application Mode"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#ApplicationMode">http://purl.org/cwmo/#ApplicationMode</seealso>
    let ApplicationMode = Prefixed_Name(cwmo, "ApplicationMode") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The artefact class is a visual or physical representation of an idea."</para>
    /// labels<para>"Artifact"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Artifact">http://purl.org/cwmo/#Artifact</seealso>
    let Artifact = Prefixed_Name(cwmo, "Artifact") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Attitudinal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#Attitudinal">http://purl.org/cwmo/#Attitudinal</seealso>
    let Attitudinal = Prefixed_Name(cwmo, "Attitudinal") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Behavioral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#Behavioral">http://purl.org/cwmo/#Behavioral</seealso>
    let Behavioral = Prefixed_Name(cwmo, "Behavioral") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:BendItShapeIt</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:CreativeTechnique</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bend It, Shape It"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#BendItShapeIt">http://purl.org/cwmo/#BendItShapeIt</seealso>
    let BendItShapeIt = Prefixed_Name(cwmo, "BendItShapeIt") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Bodystorming</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:CreativeTechnique</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Bodystorming">http://purl.org/cwmo/#Bodystorming</seealso>
    let Bodystorming = Prefixed_Name(cwmo, "Bodystorming") |> PrefixedName

    /// <summary>
    ///   <para>cwmo:BrainstormGraphicOrganizers</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#BrainstormGraphicOrganizers">http://purl.org/cwmo/#BrainstormGraphicOrganizers</seealso>
    let BrainstormGraphicOrganizers =
        Prefixed_Name(cwmo, "BrainstormGraphicOrganizers") |> PrefixedName

    /// <summary>
    ///   <para>cwmo:Coggle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#Coggle">http://purl.org/cwmo/#Coggle</seealso>
    let Coggle = Prefixed_Name(cwmo, "Coggle") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Collage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#Collage">http://purl.org/cwmo/#Collage</seealso>
    let Collage = Prefixed_Name(cwmo, "Collage") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:CollectiveMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:ApplicationMode</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#CollectiveMode">http://purl.org/cwmo/#CollectiveMode</seealso>
    let CollectiveMode = Prefixed_Name(cwmo, "CollectiveMode") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Completeness</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:EvaluationCriteria</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Completeness">http://purl.org/cwmo/#Completeness</seealso>
    let Completeness = Prefixed_Name(cwmo, "Completeness") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Complexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:EvaluationCriteria</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Complexity">http://purl.org/cwmo/#Complexity</seealso>
    let Complexity = Prefixed_Name(cwmo, "Complexity") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:ConceptGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:CreativePhase</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"the phase of concept generation and eraly prototyping is an itarative phase that involves participatory and generative design activities. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008)."</para>
    /// labels<para>"Concept generation and early prototyping"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#ConceptGeneration">http://purl.org/cwmo/#ConceptGeneration</seealso>
    let ConceptGeneration = Prefixed_Name(cwmo, "ConceptGeneration") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:ConceptMapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#ConceptMapping">http://purl.org/cwmo/#ConceptMapping</seealso>
    let ConceptMapping = Prefixed_Name(cwmo, "ConceptMapping") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The constraint class is the textual description of the element that limit the subject. It is related to the strategy of the company, the constraint associated with the activity domain of the organizations, …"</para>
    /// labels<para>"Constraint"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Constraint">http://purl.org/cwmo/#Constraint</seealso>
    let Constraint = Prefixed_Name(cwmo, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"organizational condition in wich the problem is defined (Stratégique, Nouveau produit, processus ou service, Améliorations produit, processus ou service, publicité/marketing, Ressources humaines)"</para>
    /// labels<para>"Context"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Context">http://purl.org/cwmo/#Context</seealso>
    let Context = Prefixed_Name(cwmo, "Context") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:ContextType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The context type class gather the typology of creative workshop context"</para>
    /// labels<para>"Context Type"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#ContextType">http://purl.org/cwmo/#ContextType</seealso>
    let ContextType = Prefixed_Name(cwmo, "ContextType") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:ContextualDesign</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#ContextualDesign">http://purl.org/cwmo/#ContextualDesign</seealso>
    let ContextualDesign = Prefixed_Name(cwmo, "ContextualDesign") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:CreativePhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The creative phase class is the decompastion of the creative process into steps/ phases which implies different nature of activities, goals and interaction."</para>
    /// labels<para>"Creative Phase"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#CreativePhase">http://purl.org/cwmo/#CreativePhase</seealso>
    let CreativePhase = Prefixed_Name(cwmo, "CreativePhase") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:CreativeStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The creative strategy is a selection of creative techniques defined by the a facilitator in order to respond to the subject"</para>
    /// labels<para>"Creative Strategy"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#CreativeStrategy">http://purl.org/cwmo/#CreativeStrategy</seealso>
    let CreativeStrategy = Prefixed_Name(cwmo, "CreativeStrategy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:CreativeTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The creative team class is a group of ideator who attempt to generated ideas to respond a problematic"</para>
    /// labels<para>"Creative Team"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#CreativeTeam">http://purl.org/cwmo/#CreativeTeam</seealso>
    let CreativeTeam = Prefixed_Name(cwmo, "CreativeTeam") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:CreativeTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The creativre technic class is the technic applied by the ideator to generated ideas"</para>
    /// labels<para>"Creative Technique"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#CreativeTechnique">http://purl.org/cwmo/#CreativeTechnique</seealso>
    let CreativeTechnique = Prefixed_Name(cwmo, "CreativeTechnique") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:CreativeWorkshop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The CreativeWorkshop class  represent an event organized by an organizer to solve a problem formulated into a subject and provided by a decision-maker, and solved by a creative team."</para>
    /// labels<para>"CreativeWorkshop"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#CreativeWorkshop">http://purl.org/cwmo/#CreativeWorkshop</seealso>
    let CreativeWorkshop = Prefixed_Name(cwmo, "CreativeWorkshop") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:DataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data type class define the form in which that content is typically collected and communicated."</para>
    /// labels<para>"Data Type"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#DataType">http://purl.org/cwmo/#DataType</seealso>
    let DataType = Prefixed_Name(cwmo, "DataType") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:DecisionMaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Decision Maker is one of the role assumed by a person during the creative workshop. He provides the problem to solve during the workshop and has the decision ability concerning the future of the idea generated."</para>
    /// labels<para>"Decision Maker"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#DecisionMaker">http://purl.org/cwmo/#DecisionMaker</seealso>
    let DecisionMaker = Prefixed_Name(cwmo, "DecisionMaker") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:CreativePhase</para>
    ///   <para>"The defintion class is a phase of the creative process where project parameters are explored and defined. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008)."</para>
    /// labels<para>"planning, scoping and definition"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Definition">http://purl.org/cwmo/#Definition</seealso>
    let Definition = Prefixed_Name(cwmo, "Definition") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:DesignProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:ParticipantRole</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#DesignProcess">http://purl.org/cwmo/#DesignProcess</seealso>
    let DesignProcess = Prefixed_Name(cwmo, "DesignProcess") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:DigitalTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The digital tools class gather the tools available for a digital application of creative techniques"</para>
    /// labels<para>"Digital Tools"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#DigitalTool">http://purl.org/cwmo/#DigitalTool</seealso>
    let DigitalTool = Prefixed_Name(cwmo, "DigitalTool") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Effectivness</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:EvaluationCriteria</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Effectivness">http://purl.org/cwmo/#Effectivness</seealso>
    let Effectivness = Prefixed_Name(cwmo, "Effectivness") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The material class represent the physical material/ equipment needed."</para>
    /// labels<para>"Equipment"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Equipment">http://purl.org/cwmo/#Equipment</seealso>
    let Equipment = Prefixed_Name(cwmo, "Equipment") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:EvalAndRafinement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:CreativePhase</para>
    ///   <para>"The evaluation and rafinement is an iterative phase of testing and feedback about a production. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008)."</para>
    /// labels<para>"Evaluation and Rafinement"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#EvalAndRafinement">http://purl.org/cwmo/#EvalAndRafinement</seealso>
    let EvalAndRafinement = Prefixed_Name(cwmo, "EvalAndRafinement") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:TechniqueFunction</para>
    ///   <para>"The evluation class is a creative technic which has the purpose to evaluate/sort/contextualise the ideas."</para>
    /// labels<para>"Evaluation"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Evaluation">http://purl.org/cwmo/#Evaluation</seealso>
    let Evaluation = Prefixed_Name(cwmo, "Evaluation") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:EvaluationCriteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Evaluation criteria class is the specific aspect to obsverve on idea. It is defined according to the constraints of the subject."</para>
    /// labels<para>"Evaluation Criteria"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#EvaluationCriteria">http://purl.org/cwmo/#EvaluationCriteria</seealso>
    let EvaluationCriteria = Prefixed_Name(cwmo, "EvaluationCriteria") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:EvaluationStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The evaluation strategy class gather the information concerning the evaluation technics, the criteria, and the evaluators affected to respond to the objectives of the creative workshop."</para>
    /// labels<para>"Evaluation Strategy"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#EvaluationStrategy">http://purl.org/cwmo/#EvaluationStrategy</seealso>
    let EvaluationStrategy = Prefixed_Name(cwmo, "EvaluationStrategy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:EvaluationTechnic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The evaluation technic class is the way the idea is evaluated. It can be qualitative (Review, sorting (top5),...) or quantitative (rating)."</para>
    /// labels<para>"Evaluation Technic"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#EvaluationTechnic">http://purl.org/cwmo/#EvaluationTechnic</seealso>
    let EvaluationTechnic = Prefixed_Name(cwmo, "EvaluationTechnic") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Evaluator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Evaluator is one of the role assumed by a person during the creative workshop. He evaluate the ideas based on the evaluation strategy according to the evaluation techniques and the criteria associated."</para>
    /// labels<para>"Evaluator"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Evaluator">http://purl.org/cwmo/#Evaluator</seealso>
    let Evaluator = Prefixed_Name(cwmo, "Evaluator") |> PrefixedName

    /// <summary>
    ///   <para>cwmo:ExperiencePrototyping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#ExperiencePrototyping">http://purl.org/cwmo/#ExperiencePrototyping</seealso>
    let ExperiencePrototyping =
        Prefixed_Name(cwmo, "ExperiencePrototyping") |> PrefixedName

    /// <summary>
    ///   <para>cwmo:Experiment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#Experiment">http://purl.org/cwmo/#Experiment</seealso>
    let Experiment = Prefixed_Name(cwmo, "Experiment") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Expert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Expert is one of the role assumed by a person during the creative workshop. He share his knowledge about the problem or the domain to helps the ideator or the evaluation."</para>
    /// labels<para>"Expert"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Expert">http://purl.org/cwmo/#Expert</seealso>
    let Expert = Prefixed_Name(cwmo, "Expert") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Exploration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:TechniqueFunction</para>
    ///   <para>"The exploration class is a creativ technic which has the porpose to explore the problem, to redefine the scope or the focus of the problem, or to collect further information"</para>
    /// labels<para>"Exploration"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Exploration">http://purl.org/cwmo/#Exploration</seealso>
    let Exploration = Prefixed_Name(cwmo, "Exploration") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:ExpressionMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Expression Mode"</para><para>"The expression mode class define the different mode of experssion exploited by a creative technique"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#ExpressionMode">http://purl.org/cwmo/#ExpressionMode</seealso>
    let ExpressionMode = Prefixed_Name(cwmo, "ExpressionMode") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Expressivness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:EvaluationCriteria</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Expressivness">http://purl.org/cwmo/#Expressivness</seealso>
    let Expressivness = Prefixed_Name(cwmo, "Expressivness") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Facilitator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Facilitator is one of the role assumed by a person during the creative workshop. He is the person who assist the group of ideator in the application of the activities (creative technique and evaluation technique)"</para>
    /// labels<para>"Facilitator"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Facilitator">http://purl.org/cwmo/#Facilitator</seealso>
    let Facilitator = Prefixed_Name(cwmo, "Facilitator") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Feasibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:EvaluationCriteria</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Feasibility">http://purl.org/cwmo/#Feasibility</seealso>
    let Feasibility = Prefixed_Name(cwmo, "Feasibility") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:FreeReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:EvaluationTechnic</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#FreeReview">http://purl.org/cwmo/#FreeReview</seealso>
    let FreeReview = Prefixed_Name(cwmo, "FreeReview") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Generation</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:TechniqueFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Generation class is a creative technic which has the purpose to generate ideas."</para>
    /// labels<para>"Generation"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Generation">http://purl.org/cwmo/#Generation</seealso>
    let Generation = Prefixed_Name(cwmo, "Generation") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:GuidedReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:EvaluationTechnic</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#GuidedReview">http://purl.org/cwmo/#GuidedReview</seealso>
    let GuidedReview = Prefixed_Name(cwmo, "GuidedReview") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Idea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The idea class is a beginning of response to the problem. An idea can be from a Creative technic"</para>
    /// labels<para>"Idea"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Idea">http://purl.org/cwmo/#Idea</seealso>
    let Idea = Prefixed_Name(cwmo, "Idea") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:IdeaEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:CreativePhase</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The idea evaluation class is a phase of the creative process where the idea are evluated, sorted or ranked."</para>
    /// labels<para>"IdeaEvaluation"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#IdeaEvaluation">http://purl.org/cwmo/#IdeaEvaluation</seealso>
    let IdeaEvaluation = Prefixed_Name(cwmo, "IdeaEvaluation") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Ideation</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:CreativePhase</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The ideation class is a phase of the creative process where ideas to respond to the problematic are generated."</para>
    /// labels<para>"Ideation"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Ideation">http://purl.org/cwmo/#Ideation</seealso>
    let Ideation = Prefixed_Name(cwmo, "Ideation") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Ideator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ideator is one of the role assumed by a person during the creative workshop. He is the person who solve the problem and produce ideas by applying creative techniques"</para>
    /// labels<para>"Ideator"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Ideator">http://purl.org/cwmo/#Ideator</seealso>
    let Ideator = Prefixed_Name(cwmo, "Ideator") |> PrefixedName

    /// <summary>
    ///   <para>cwmo:ImplementAndMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:CreativePhase</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Implementation and monitoring class is a phase of the creative process where the readiness of the idea  is tested. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008)."</para>
    /// labels<para>"Lunch and Monitoring"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#ImplementAndMonitoring">http://purl.org/cwmo/#ImplementAndMonitoring</seealso>
    let ImplementAndMonitoring =
        Prefixed_Name(cwmo, "ImplementAndMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>cwmo:Implementability</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:EvaluationCriteria</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Implementability">http://purl.org/cwmo/#Implementability</seealso>
    let Implementability = Prefixed_Name(cwmo, "Implementability") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:CreativePhase</para>
    ///   <para>"The implementation class is a phase of the creative process where the most interesting ideas are experimented in real condition."</para>
    /// labels<para>"Implementation"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Implementation">http://purl.org/cwmo/#Implementation</seealso>
    let Implementation = Prefixed_Name(cwmo, "Implementation") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:IndividualMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:ApplicationMode</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#IndividualMode">http://purl.org/cwmo/#IndividualMode</seealso>
    let IndividualMode = Prefixed_Name(cwmo, "IndividualMode") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:InputType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"type of centent most appropriatly targeted by the method"</para>
    /// labels<para>"Input Type"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#InputType">http://purl.org/cwmo/#InputType</seealso>
    let InputType = Prefixed_Name(cwmo, "InputType") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:KJTechnique</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#KJTechnique">http://purl.org/cwmo/#KJTechnique</seealso>
    let KJTechnique = Prefixed_Name(cwmo, "KJTechnique") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:KeyPerfIndicator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#KeyPerfIndicator">http://purl.org/cwmo/#KeyPerfIndicator</seealso>
    let KeyPerfIndicator = Prefixed_Name(cwmo, "KeyPerfIndicator") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:KnowledgeDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Knowledge domain class is the overall knowledge that a person posses or which is associated to an idea or a problem"</para>
    /// labels<para>"Knowledge Domain"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#KnowledgeDomain">http://purl.org/cwmo/#KnowledgeDomain</seealso>
    let KnowledgeDomain = Prefixed_Name(cwmo, "KnowledgeDomain") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:MindMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:CreativeTechnique</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#MindMapping">http://purl.org/cwmo/#MindMapping</seealso>
    let MindMapping = Prefixed_Name(cwmo, "MindMapping") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:NPD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:ContextType</para>
    ///
    /// labels<para>"New Products/ Process/ Services"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#NPD">http://purl.org/cwmo/#NPD</seealso>
    let NPD = Prefixed_Name(cwmo, "NPD") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Objective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The objective is a description of the result expected by the organizations concerning the creative workshop"</para>
    /// labels<para>"Objective"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Objective">http://purl.org/cwmo/#Objective</seealso>
    let Objective = Prefixed_Name(cwmo, "Objective") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organization such as a company, SME, institutions, NGO, corporation,  etc."</para>
    /// labels<para>"Organization"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Organization">http://purl.org/cwmo/#Organization</seealso>
    let Organization = Prefixed_Name(cwmo, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Organizer is one of the role assumed by a person during the creative workshop. He is the person who manage the entre workshop by providing the materials, the infrastructure and communicate with the others persons."</para>
    /// labels<para>"Organizer"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Organizer">http://purl.org/cwmo/#Organizer</seealso>
    let Organizer = Prefixed_Name(cwmo, "Organizer") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Originality</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:EvaluationCriteria</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Originality">http://purl.org/cwmo/#Originality</seealso>
    let Originality = Prefixed_Name(cwmo, "Originality") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:PSI</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:ContextType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Product/ Process / Services Improvement"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#PSI">http://purl.org/cwmo/#PSI</seealso>
    let PSI = Prefixed_Name(cwmo, "PSI") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:ParticipantRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The particpant role class define the role of the person involved in a creative technique. (Martin et al., 2013). It should be distinguished from the role involved in the entire creative workshop process."</para>
    /// labels<para>"Participant Role"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#ParticipantRole">http://purl.org/cwmo/#ParticipantRole</seealso>
    let ParticipantRole = Prefixed_Name(cwmo, "ParticipantRole") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Participatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:ParticipantRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Participatory">http://purl.org/cwmo/#Participatory</seealso>
    let Participatory = Prefixed_Name(cwmo, "Participatory") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Personas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:CreativeTechnique</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Personas">http://purl.org/cwmo/#Personas</seealso>
    let Personas = Prefixed_Name(cwmo, "Personas") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:PostIt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#PostIt">http://purl.org/cwmo/#PostIt</seealso>
    let PostIt = Prefixed_Name(cwmo, "PostIt") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Problem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The problem class is the description of the elements that leads the organization to initiate a creative workshop."</para>
    /// labels<para>"Problem"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Problem">http://purl.org/cwmo/#Problem</seealso>
    let Problem = Prefixed_Name(cwmo, "Problem") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:ProblemAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:CreativePhase</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The problem analysis class is a phase of the creative process where the problem is formalized and the information seeked and organized."</para>
    /// labels<para>"Problem Analysis"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#ProblemAnalysis">http://purl.org/cwmo/#ProblemAnalysis</seealso>
    let ProblemAnalysis = Prefixed_Name(cwmo, "ProblemAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:QualitativeData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:DataType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#QualitativeData">http://purl.org/cwmo/#QualitativeData</seealso>
    let QualitativeData = Prefixed_Name(cwmo, "QualitativeData") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:QuantitativeData</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:DataType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#QuantitativeData">http://purl.org/cwmo/#QuantitativeData</seealso>
    let QuantitativeData = Prefixed_Name(cwmo, "QuantitativeData") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Related</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:StimuliType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Related">http://purl.org/cwmo/#Related</seealso>
    let Related = Prefixed_Name(cwmo, "Related") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Relevance</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:EvaluationCriteria</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Relevance">http://purl.org/cwmo/#Relevance</seealso>
    let Relevance = Prefixed_Name(cwmo, "Relevance") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Roleplaying</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#Roleplaying">http://purl.org/cwmo/#Roleplaying</seealso>
    let Roleplaying = Prefixed_Name(cwmo, "Roleplaying") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Scenarios</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#Scenarios">http://purl.org/cwmo/#Scenarios</seealso>
    let Scenarios = Prefixed_Name(cwmo, "Scenarios") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:SimulationExercise</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#SimulationExercise">http://purl.org/cwmo/#SimulationExercise</seealso>
    let SimulationExercise = Prefixed_Name(cwmo, "SimulationExercise") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Stimuli</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Stimuli is used to initiate a creative technique"</para>
    /// labels<para>"Stimuli"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Stimuli">http://purl.org/cwmo/#Stimuli</seealso>
    let Stimuli = Prefixed_Name(cwmo, "Stimuli") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:StimuliType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Typology of stimuli"</para>
    /// labels<para>"Stimuli Type"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#StimuliType">http://purl.org/cwmo/#StimuliType</seealso>
    let StimuliType = Prefixed_Name(cwmo, "StimuliType") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Strategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:ContextType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Strategy">http://purl.org/cwmo/#Strategy</seealso>
    let Strategy = Prefixed_Name(cwmo, "Strategy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The subject class is the description of the problerm to solve by the creative group during the creative workshop. It is a transformation/reformulation of the problem."</para>
    /// labels<para>"Subject"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Subject">http://purl.org/cwmo/#Subject</seealso>
    let Subject = Prefixed_Name(cwmo, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Synthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:CreativePhase</para>
    ///   <para>"The synthesis class represent the phase of the creative process where further information a researched. Classification of the application of creative technic based on the Universal Method of Design (Martin et al., 2008)."</para>
    ///   <para>"Exploration, synthesis and design implications"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Synthesis">http://purl.org/cwmo/#Synthesis</seealso>
    let Synthesis = Prefixed_Name(cwmo, "Synthesis") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:TechniqueFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Technique Function class define the primary purpose of a creative technique."</para>
    /// labels<para>"Technique Function"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#TechniqueFunction">http://purl.org/cwmo/#TechniqueFunction</seealso>
    let TechniqueFunction = Prefixed_Name(cwmo, "TechniqueFunction") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The tool class is the software and interface used to ease the application of a creative technic and/or collect the data of the creative technic."</para>
    /// labels<para>"Tool"</para></remarks>
    /// <seealso href="http://purl.org/cwmo/#Tool">http://purl.org/cwmo/#Tool</seealso>
    let Tool = Prefixed_Name(cwmo, "Tool") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Unrelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:StimuliType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Unrelated">http://purl.org/cwmo/#Unrelated</seealso>
    let Unrelated = Prefixed_Name(cwmo, "Unrelated") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:UsabilityTesting</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#UsabilityTesting">http://purl.org/cwmo/#UsabilityTesting</seealso>
    let UsabilityTesting = Prefixed_Name(cwmo, "UsabilityTesting") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:UserJourneyMaps</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#UserJourneyMaps">http://purl.org/cwmo/#UserJourneyMaps</seealso>
    let UserJourneyMaps = Prefixed_Name(cwmo, "UserJourneyMaps") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Verbal</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwmo:ExpressionMode</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Verbal">http://purl.org/cwmo/#Verbal</seealso>
    let Verbal = Prefixed_Name(cwmo, "Verbal") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:WebAnalytics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cwmo/#WebAnalytics">http://purl.org/cwmo/#WebAnalytics</seealso>
    let WebAnalytics = Prefixed_Name(cwmo, "WebAnalytics") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Workability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:EvaluationCriteria</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Workability">http://purl.org/cwmo/#Workability</seealso>
    let Workability = Prefixed_Name(cwmo, "Workability") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:Written</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cwmo:ExpressionMode</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#Written">http://purl.org/cwmo/#Written</seealso>
    let Written = Prefixed_Name(cwmo, "Written") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:adviceAdressedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#adviceAdressedTo">http://purl.org/cwmo/#adviceAdressedTo</seealso>
    let adviceAdressedTo = Prefixed_Name(cwmo, "adviceAdressedTo") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:advicedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#advicedBy">http://purl.org/cwmo/#advicedBy</seealso>
    let advicedBy = Prefixed_Name(cwmo, "advicedBy") |> PrefixedName

    /// <summary>
    ///   <para>cwmo:appliedInContextType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#appliedInContextType">http://purl.org/cwmo/#appliedInContextType</seealso>
    let appliedInContextType =
        Prefixed_Name(cwmo, "appliedInContextType") |> PrefixedName

    /// <summary>
    ///   <para>cwmo:applyEvaluationThanks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Evaluation technic apply evaluation criteria to do the evaluation."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#applyEvaluationThanks">http://purl.org/cwmo/#applyEvaluationThanks</seealso>
    let applyEvaluationThanks =
        Prefixed_Name(cwmo, "applyEvaluationThanks") |> PrefixedName

    /// <summary>
    ///   <para>cwmo:coverDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#coverDomain">http://purl.org/cwmo/#coverDomain</seealso>
    let coverDomain = Prefixed_Name(cwmo, "coverDomain") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:criteriaIsDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Evaluation criteria is defined by the decision maker and/or the organizer."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#criteriaIsDefinedBy">http://purl.org/cwmo/#criteriaIsDefinedBy</seealso>
    let criteriaIsDefinedBy = Prefixed_Name(cwmo, "criteriaIsDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:difficulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"estimates how complicated is a technic to implement. Low, medium, high"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#difficulty">http://purl.org/cwmo/#difficulty</seealso>
    let difficulty = Prefixed_Name(cwmo, "difficulty") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"minimun amount of time required to apply a technic."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#duration">http://purl.org/cwmo/#duration</seealso>
    let duration = Prefixed_Name(cwmo, "duration") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"how much energy must be invested to complete the technic."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#energy">http://purl.org/cwmo/#energy</seealso>
    let energy = Prefixed_Name(cwmo, "energy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:equipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#equipe">http://purl.org/cwmo/#equipe</seealso>
    let equipe = Prefixed_Name(cwmo, "equipe") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:evalStratPlannedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#evalStratPlannedBy">http://purl.org/cwmo/#evalStratPlannedBy</seealso>
    let evalStratPlannedBy = Prefixed_Name(cwmo, "evalStratPlannedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:evalTechAppliedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Evaluation technic is applied by evaluator."</para>
    ///   <para>"restreindre la relation en fonction de la strategy: TechA evalTechappliedBy Anon for a given strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#evalTechAppliedBy">http://purl.org/cwmo/#evalTechAppliedBy</seealso>
    let evalTechAppliedBy = Prefixed_Name(cwmo, "evalTechAppliedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:evaluateResponseTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"An evaluation strategy evaluate the ideas associated to a subject. The strategy is dependant of the differnt element that define the subject (context, decision-maker, ...)"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#evaluateResponseTo">http://purl.org/cwmo/#evaluateResponseTo</seealso>
    let evaluateResponseTo = Prefixed_Name(cwmo, "evaluateResponseTo") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:funFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"estimated likelihood that a technic will provoke mirth and humor. Low, medium, high."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#funFactor">http://purl.org/cwmo/#funFactor</seealso>
    let funFactor = Prefixed_Name(cwmo, "funFactor") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"creative technqiue has different function: exploration of the subject/ domain of the problem, generation of idea, and evluation of idea"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#function">http://purl.org/cwmo/#function</seealso>
    let function_ = Prefixed_Name(cwmo, "function") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasApplicationMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasApplicationMode">http://purl.org/cwmo/#hasApplicationMode</seealso>
    let hasApplicationMode = Prefixed_Name(cwmo, "hasApplicationMode") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An idea is written by an ideator."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasAuthor">http://purl.org/cwmo/#hasAuthor</seealso>
    let hasAuthor = Prefixed_Name(cwmo, "hasAuthor") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasCTSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"An idea has been produced during the application of a creative technic."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasCTSource">http://purl.org/cwmo/#hasCTSource</seealso>
    let hasCTSource = Prefixed_Name(cwmo, "hasCTSource") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasCWSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"An idea has been produced during the a creative workshop."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasCWSource">http://purl.org/cwmo/#hasCWSource</seealso>
    let hasCWSource = Prefixed_Name(cwmo, "hasCWSource") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A problem is defined according to a context."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasContext">http://purl.org/cwmo/#hasContext</seealso>
    let hasContext = Prefixed_Name(cwmo, "hasContext") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasContextType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasContextType">http://purl.org/cwmo/#hasContextType</seealso>
    let hasContextType = Prefixed_Name(cwmo, "hasContextType") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasCreatTechnic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Creative Strategy is composed by one or several creative techniques"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasCreatTechnic">http://purl.org/cwmo/#hasCreatTechnic</seealso>
    let hasCreatTechnic = Prefixed_Name(cwmo, "hasCreatTechnic") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasCreativePhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasCreativePhase">http://purl.org/cwmo/#hasCreativePhase</seealso>
    let hasCreativePhase = Prefixed_Name(cwmo, "hasCreativePhase") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasEquivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasEquivalent">http://purl.org/cwmo/#hasEquivalent</seealso>
    let hasEquivalent = Prefixed_Name(cwmo, "hasEquivalent") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasEvalStrat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Evaluation technic is part of an evaluation strategy."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasEvalStrat">http://purl.org/cwmo/#hasEvalStrat</seealso>
    let hasEvalStrat = Prefixed_Name(cwmo, "hasEvalStrat") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasEvalTechnic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Evaluation strategy is composed by evaluation technic."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasEvalTechnic">http://purl.org/cwmo/#hasEvalTechnic</seealso>
    let hasEvalTechnic = Prefixed_Name(cwmo, "hasEvalTechnic") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasExpressionMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasExpressionMode">http://purl.org/cwmo/#hasExpressionMode</seealso>
    let hasExpressionMode = Prefixed_Name(cwmo, "hasExpressionMode") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A creative method produce different results which can be classified according to these typology: exploration, generation, and/or evaluation."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasFunction">http://purl.org/cwmo/#hasFunction</seealso>
    let hasFunction = Prefixed_Name(cwmo, "hasFunction") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasGeneralization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasGeneralization">http://purl.org/cwmo/#hasGeneralization</seealso>
    let hasGeneralization = Prefixed_Name(cwmo, "hasGeneralization") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasGenerated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasGenerated">http://purl.org/cwmo/#hasGenerated</seealso>
    let hasGenerated = Prefixed_Name(cwmo, "hasGenerated") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasGroupAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Idea is generated into and by a team."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasGroupAuthor">http://purl.org/cwmo/#hasGroupAuthor</seealso>
    let hasGroupAuthor = Prefixed_Name(cwmo, "hasGroupAuthor") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasHypernym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Concept whose semantic field is broader than that of a hyponym."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasHypernym">http://purl.org/cwmo/#hasHypernym</seealso>
    let hasHypernym = Prefixed_Name(cwmo, "hasHypernym") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasHyponym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Concept whose semantic field is more specific than its hypernym"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasHyponym">http://purl.org/cwmo/#hasHyponym</seealso>
    let hasHyponym = Prefixed_Name(cwmo, "hasHyponym") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasIdeator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"A creative Team is composed by several ideator"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasIdeator">http://purl.org/cwmo/#hasIdeator</seealso>
    let hasIdeator = Prefixed_Name(cwmo, "hasIdeator") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A creative method requires some parametrs to be applied properly. these inputs can be a problematic, aditional information, ..."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasInput">http://purl.org/cwmo/#hasInput</seealso>
    let hasInput = Prefixed_Name(cwmo, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasInputType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasInputType">http://purl.org/cwmo/#hasInputType</seealso>
    let hasInputType = Prefixed_Name(cwmo, "hasInputType") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasKnowledge">http://purl.org/cwmo/#hasKnowledge</seealso>
    let hasKnowledge = Prefixed_Name(cwmo, "hasKnowledge") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasNext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"The creative technic can be follewed by another creative technic."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasNext">http://purl.org/cwmo/#hasNext</seealso>
    let hasNext = Prefixed_Name(cwmo, "hasNext") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasOutput">http://purl.org/cwmo/#hasOutput</seealso>
    let hasOutput = Prefixed_Name(cwmo, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Creative workshop has participant with different role."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasParticipant">http://purl.org/cwmo/#hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(cwmo, "hasParticipant") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasPlanified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Facilitator define the creative strategy"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasPlanified">http://purl.org/cwmo/#hasPlanified</seealso>
    let hasPlanified = Prefixed_Name(cwmo, "hasPlanified") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasPrevious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"The creative technic can be preceed by another creative technic."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasPrevious">http://purl.org/cwmo/#hasPrevious</seealso>
    let hasPrevious = Prefixed_Name(cwmo, "hasPrevious") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasRole">http://purl.org/cwmo/#hasRole</seealso>
    let hasRole = Prefixed_Name(cwmo, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasSpecialization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasSpecialization">http://purl.org/cwmo/#hasSpecialization</seealso>
    let hasSpecialization = Prefixed_Name(cwmo, "hasSpecialization") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasStimuliInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasStimuliInput">http://purl.org/cwmo/#hasStimuliInput</seealso>
    let hasStimuliInput = Prefixed_Name(cwmo, "hasStimuliInput") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasStimuliType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasStimuliType">http://purl.org/cwmo/#hasStimuliType</seealso>
    let hasStimuliType = Prefixed_Name(cwmo, "hasStimuliType") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Concept that means exactly or nearly the same as another concept."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasSynonym">http://purl.org/cwmo/#hasSynonym</seealso>
    let hasSynonym = Prefixed_Name(cwmo, "hasSynonym") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:hasWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#hasWeight">http://purl.org/cwmo/#hasWeight</seealso>
    let hasWeight = Prefixed_Name(cwmo, "hasWeight") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:ideaQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"probability of a technic will result a relatively large quantity of ideas within the available time. Low, medium, high probability"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#ideaQuantity">http://purl.org/cwmo/#ideaQuantity</seealso>
    let ideaQuantity = Prefixed_Name(cwmo, "ideaQuantity") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#identifier">http://purl.org/cwmo/#identifier</seealso>
    let identifier = Prefixed_Name(cwmo, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:innovationRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#innovationRange">http://purl.org/cwmo/#innovationRange</seealso>
    let innovationRange = Prefixed_Name(cwmo, "innovationRange") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:innovationScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#innovationScope">http://purl.org/cwmo/#innovationScope</seealso>
    let innovationScope = Prefixed_Name(cwmo, "innovationScope") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isAppliedInContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A creative technic is applied in certain context."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isAppliedInContext">http://purl.org/cwmo/#isAppliedInContext</seealso>
    let isAppliedInContext = Prefixed_Name(cwmo, "isAppliedInContext") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isConstraintedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Properety indicating that a problem is constrainted by constraint of different nature ( the problem itself, the domain, the context, the actor of the domain…)"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isConstraintedBy">http://purl.org/cwmo/#isConstraintedBy</seealso>
    let isConstraintedBy = Prefixed_Name(cwmo, "isConstraintedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isCoveredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isCoveredBy">http://purl.org/cwmo/#isCoveredBy</seealso>
    let isCoveredBy = Prefixed_Name(cwmo, "isCoveredBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isCriterizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Evaluation criteria is defined by the decision maker and/or the organizer."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isCriterizedBy">http://purl.org/cwmo/#isCriterizedBy</seealso>
    let isCriterizedBy = Prefixed_Name(cwmo, "isCriterizedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isEvaluatedDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Evaluation criteria is applied during an evaluation technic."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isEvaluatedDuring">http://purl.org/cwmo/#isEvaluatedDuring</seealso>
    let isEvaluatedDuring = Prefixed_Name(cwmo, "isEvaluatedDuring") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isEvaluating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Evaluation technic evaluate idea."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isEvaluating">http://purl.org/cwmo/#isEvaluating</seealso>
    let isEvaluating = Prefixed_Name(cwmo, "isEvaluating") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isFollowedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"in theory, the creative technic can be follewed by another creative technic. it means the 2 creative technic are by default related by a temporal relation."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isFollowedBy">http://purl.org/cwmo/#isFollowedBy</seealso>
    let isFollowedBy = Prefixed_Name(cwmo, "isFollowedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isFormalizedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A subject is formalized from a problem."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isFormalizedFrom">http://purl.org/cwmo/#isFormalizedFrom</seealso>
    let isFormalizedFrom = Prefixed_Name(cwmo, "isFormalizedFrom") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isFormalizedInto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A problem is formalized into a subject in order to be adapted for a creative workshop."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isFormalizedInto">http://purl.org/cwmo/#isFormalizedInto</seealso>
    let isFormalizedInto = Prefixed_Name(cwmo, "isFormalizedInto") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isFormalizing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The decision maker define the problem that will be solved during the creative workshop."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isFormalizing">http://purl.org/cwmo/#isFormalizing</seealso>
    let isFormalizing = Prefixed_Name(cwmo, "isFormalizing") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isGeneralizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Properety indicating that an idea is generalized by a concept."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isGeneralizedBy">http://purl.org/cwmo/#isGeneralizedBy</seealso>
    let isGeneralizedBy = Prefixed_Name(cwmo, "isGeneralizedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isGeneralizing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property indicating that a concept generalize an idea. Althought ideas are different, several can represent the same concept."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isGeneralizing">http://purl.org/cwmo/#isGeneralizing</seealso>
    let isGeneralizing = Prefixed_Name(cwmo, "isGeneralizing") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isIncompatibleWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"All creative technic are not compatible with each other. A creative technic is not compatible with another."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isIncompatibleWith">http://purl.org/cwmo/#isIncompatibleWith</seealso>
    let isIncompatibleWith = Prefixed_Name(cwmo, "isIncompatibleWith") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isMaterializedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property indicating that an idea as been conctreatized into some physical or visual"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isMaterializedBy">http://purl.org/cwmo/#isMaterializedBy</seealso>
    let isMaterializedBy = Prefixed_Name(cwmo, "isMaterializedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isMaterializing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Property indicating that an artifact represent/ symbolize an idea."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isMaterializing">http://purl.org/cwmo/#isMaterializing</seealso>
    let isMaterializing = Prefixed_Name(cwmo, "isMaterializing") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isParticipatingTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"The person with a role is participating to the workshop"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isParticipatingTo">http://purl.org/cwmo/#isParticipatingTo</seealso>
    let isParticipatingTo = Prefixed_Name(cwmo, "isParticipatingTo") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isPlanifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"The creative strategy is defined by a facilitator"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isPlanifiedBy">http://purl.org/cwmo/#isPlanifiedBy</seealso>
    let isPlanifiedBy = Prefixed_Name(cwmo, "isPlanifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isProducingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A creative technic produce data (that leads to idea) which is qualitative, quantitative or both."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isProducingData">http://purl.org/cwmo/#isProducingData</seealso>
    let isProducingData = Prefixed_Name(cwmo, "isProducingData") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isRealisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"An artefact has been realised by one or several persons. In opposite to the ideas which is from the group, the realisation is individualised."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isRealisedBy">http://purl.org/cwmo/#isRealisedBy</seealso>
    let isRealisedBy = Prefixed_Name(cwmo, "isRealisedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A creative method is related to another creative method according to the method principle or mechanism involved."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isRelatedTo">http://purl.org/cwmo/#isRelatedTo</seealso>
    let isRelatedTo = Prefixed_Name(cwmo, "isRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isSolvedDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A subject is solved during a creative workshop ."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isSolvedDuring">http://purl.org/cwmo/#isSolvedDuring</seealso>
    let isSolvedDuring = Prefixed_Name(cwmo, "isSolvedDuring") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:isSupportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"A creative technic application is supported by tools."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#isSupportedBy">http://purl.org/cwmo/#isSupportedBy</seealso>
    let isSupportedBy = Prefixed_Name(cwmo, "isSupportedBy") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:novelty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"probability that ideas produced will possess statistical infrequency. Low, medium, high probability"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#novelty">http://purl.org/cwmo/#novelty</seealso>
    let novelty = Prefixed_Name(cwmo, "novelty") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:organize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"An organizer organize a creative workshop. He has the responsability of this workshop."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#organize">http://purl.org/cwmo/#organize</seealso>
    let organize = Prefixed_Name(cwmo, "organize") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:organizeResponseTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Creative Strategy is design to respond to a subject."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#organizeResponseTo">http://purl.org/cwmo/#organizeResponseTo</seealso>
    let organizeResponseTo = Prefixed_Name(cwmo, "organizeResponseTo") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:possessEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#possessEquipment">http://purl.org/cwmo/#possessEquipment</seealso>
    let possessEquipment = Prefixed_Name(cwmo, "possessEquipment") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:possessObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A subject is described by objective."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#possessObjective">http://purl.org/cwmo/#possessObjective</seealso>
    let possessObjective = Prefixed_Name(cwmo, "possessObjective") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:problematic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the subject is summerized into an open question that pose the problem."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#problematic">http://purl.org/cwmo/#problematic</seealso>
    let problematic = Prefixed_Name(cwmo, "problematic") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"procedure details how implement the creative technic ."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#procedure">http://purl.org/cwmo/#procedure</seealso>
    let procedure = Prefixed_Name(cwmo, "procedure") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:progress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#progress">http://purl.org/cwmo/#progress</seealso>
    let progress = Prefixed_Name(cwmo, "progress") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:provideAdvice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#provideAdvice">http://purl.org/cwmo/#provideAdvice</seealso>
    let provideAdvice = Prefixed_Name(cwmo, "provideAdvice") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:requireEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Creative technic require some equipement to be implemented."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#requireEquipment">http://purl.org/cwmo/#requireEquipment</seealso>
    let requireEquipment = Prefixed_Name(cwmo, "requireEquipment") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:requireStimuliType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#requireStimuliType">http://purl.org/cwmo/#requireStimuliType</seealso>
    let requireStimuliType = Prefixed_Name(cwmo, "requireStimuliType") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Scale on which the evaluation criteria should be evaluated"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#scale">http://purl.org/cwmo/#scale</seealso>
    let scale = Prefixed_Name(cwmo, "scale") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the idea has a score once it has been evaluated by the evaluator."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#score">http://purl.org/cwmo/#score</seealso>
    let score = Prefixed_Name(cwmo, "score") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:stimuli</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"creative technique require stimuli to permit ideator apply correctly the method. This stimuli can be related or unrelated to the subject."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#stimuli">http://purl.org/cwmo/#stimuli</seealso>
    let stimuli = Prefixed_Name(cwmo, "stimuli") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:support</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"A tool support the application of a creative technic."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#support">http://purl.org/cwmo/#support</seealso>
    let support = Prefixed_Name(cwmo, "support") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:usecase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Usecase is used to describe the idea in context of use."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#usecase">http://purl.org/cwmo/#usecase</seealso>
    let usecase = Prefixed_Name(cwmo, "usecase") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:website</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#website">http://purl.org/cwmo/#website</seealso>
    let website = Prefixed_Name(cwmo, "website") |> PrefixedName
    /// <summary>
    ///   <para>cwmo:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cwmo/#weight">http://purl.org/cwmo/#weight</seealso>
    let weight = Prefixed_Name(cwmo, "weight") |> PrefixedName
