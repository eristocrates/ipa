namespace https.bmake.th_brandenburg.de.spv.hash

open DoxAletheia.Rdf_Vocabulary

module spvqa =
    let _namespace_name = "https://bmake.th-brandenburg.de/spv#"
    /// <summary>
    /// Unformalized list of critical issues observed in an analyzed scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#Critique"></see></summary>
    let Critique = Namespaced_IRI.parse _namespace_name "Critique" |> NamespacedName
    /// <summary>
    /// Unformalized list of future work announced in an analyzed scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#FutureWork"></see></summary>
    let FutureWork = Namespaced_IRI.parse _namespace_name "FutureWork" |> NamespacedName

    /// <summary>
    /// examine something systematically and in detail
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeAnalyze"></see></summary>
    let ResActTypeAnalyze =
        Namespaced_IRI.parse _namespace_name "ResActTypeAnalyze" |> NamespacedName

    /// <summary>
    /// The activity aspect of an elecited research objective taken from the list of types of research &amp; development actions applied in Information Systems.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchActionType"></see></summary>
    let ResearchActionType =
        Namespaced_IRI.parse _namespace_name "ResearchActionType" |> NamespacedName

    /// <summary>
    /// collect all parts or aspects of a complex object
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeCollect"></see></summary>
    let ResActTypeCollect =
        Namespaced_IRI.parse _namespace_name "ResActTypeCollect" |> NamespacedName

    /// <summary>
    /// define the essential terms (concepts) and relations of a domain
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeConceptualize"></see></summary>
    let ResActTypeConceptualize =
        Namespaced_IRI.parse _namespace_name "ResActTypeConceptualize" |> NamespacedName

    /// <summary>
    /// create something according to certain design or architectural principles
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeConstruct"></see></summary>
    let ResActTypeConstruct =
        Namespaced_IRI.parse _namespace_name "ResActTypeConstruct" |> NamespacedName

    /// <summary>
    /// unambiguously describe or explain a concept
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeDefine"></see></summary>
    let ResActTypeDefine =
        Namespaced_IRI.parse _namespace_name "ResActTypeDefine" |> NamespacedName

    /// <summary>
    /// basically design an object, mostly according to appropriate design principles
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeDesign"></see></summary>
    let ResActTypeDesign =
        Namespaced_IRI.parse _namespace_name "ResActTypeDesign" |> NamespacedName

    /// <summary>
    /// create something new, mostly using specialist methods and tools
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeDevelop"></see></summary>
    let ResActTypeDevelop =
        Namespaced_IRI.parse _namespace_name "ResActTypeDevelop" |> NamespacedName

    /// <summary>
    /// capture characteristics of objects under examination (eg by measurement)
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeElicit"></see></summary>
    let ResActTypeElicit =
        Namespaced_IRI.parse _namespace_name "ResActTypeElicit" |> NamespacedName

    /// <summary>
    /// improve an object in certain features or aspects
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeEnhance"></see></summary>
    let ResActTypeEnhance =
        Namespaced_IRI.parse _namespace_name "ResActTypeEnhance" |> NamespacedName

    /// <summary>
    /// assess a quantitative or qualitative property of an object
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeEvaluate"></see></summary>
    let ResActTypeEvaluate =
        Namespaced_IRI.parse _namespace_name "ResActTypeEvaluate" |> NamespacedName

    /// <summary>
    /// extend an object by properties or in its scope of functions or services
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeExtend"></see></summary>
    let ResActTypeExtend =
        Namespaced_IRI.parse _namespace_name "ResActTypeExtend" |> NamespacedName

    /// <summary>
    /// separate defined parts of a complex object and provide them in a suitable form
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeExtract"></see></summary>
    let ResActTypeExtract =
        Namespaced_IRI.parse _namespace_name "ResActTypeExtract" |> NamespacedName

    /// <summary>
    /// implement a designed object technically
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeImplement"></see></summary>
    let ResActTypeImplement =
        Namespaced_IRI.parse _namespace_name "ResActTypeImplement" |> NamespacedName

    /// <summary>
    /// merge several objects into a single unit
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeIntegrate"></see></summary>
    let ResActTypeIntegrate =
        Namespaced_IRI.parse _namespace_name "ResActTypeIntegrate" |> NamespacedName

    /// <summary>
    /// investigate how an object meets certain requirements; whether a statement (about an object) is true
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeProve"></see></summary>
    let ResActTypeProve =
        Namespaced_IRI.parse _namespace_name "ResActTypeProve" |> NamespacedName

    /// <summary>
    /// provide an object in a suitable manner for use
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeProvide"></see></summary>
    let ResActTypeProvide =
        Namespaced_IRI.parse _namespace_name "ResActTypeProvide" |> NamespacedName

    /// <summary>
    /// systematically organize parts, aspects or the like of a complex object
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeStructure"></see></summary>
    let ResActTypeStructure =
        Namespaced_IRI.parse _namespace_name "ResActTypeStructure" |> NamespacedName

    /// <summary>
    /// software artifact with a certain range of functions
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactApplication"></see></summary>
    let ResArtifactApplication =
        Namespaced_IRI.parse _namespace_name "ResArtifactApplication" |> NamespacedName

    /// <summary>
    /// The artifact aspect of an elicited research objective taken from the list of all types of research &amp; development artifacts characteristic for Information Systems.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchArtifact"></see></summary>
    let ResearchArtifact =
        Namespaced_IRI.parse _namespace_name "ResearchArtifact" |> NamespacedName

    /// <summary>
    /// model or technical design of an object
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactBlueprint"></see></summary>
    let ResArtifactBlueprint =
        Namespaced_IRI.parse _namespace_name "ResArtifactBlueprint" |> NamespacedName

    /// <summary>
    /// set of interacting and interdependent activities that converts input to output
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactBusinessProcess"></see></summary>
    let ResArtifactBusinessProcess =
        Namespaced_IRI.parse _namespace_name "ResArtifactBusinessProcess" |> NamespacedName

    /// <summary>
    /// complex (technical) environment for the development of applications and IT systems
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactDevFramework"></see></summary>
    let ResArtifactDevFramework =
        Namespaced_IRI.parse _namespace_name "ResArtifactDevFramework" |> NamespacedName

    /// <summary>
    /// technical, formal or semi-formal description of an object and the circumstances of its development or function
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactDocumentation"></see></summary>
    let ResArtifactDocumentation =
        Namespaced_IRI.parse _namespace_name "ResArtifactDocumentation" |> NamespacedName

    /// <summary>
    /// complex object of information technology whose parts interact and form a desing-related and functional whole
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactITSystem"></see></summary>
    let ResArtifactITSystem =
        Namespaced_IRI.parse _namespace_name "ResArtifactITSystem" |> NamespacedName

    /// <summary>
    /// a combined set of hardware, software, networks, facilities, etc. (including all of the information technology), in order to develop, test, deliver, monitor, control or support IT services
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactInfrastructure"></see></summary>
    let ResArtifactInfrastructure =
        Namespaced_IRI.parse _namespace_name "ResArtifactInfrastructure" |> NamespacedName

    /// <summary>
    /// standard-based, structured data, mostly based on the Semantic Web stack
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactLinkedData"></see></summary>
    let ResArtifactLinkedData =
        Namespaced_IRI.parse _namespace_name "ResArtifactLinkedData" |> NamespacedName

    /// <summary>
    /// prescription of procedures or activities which is aimed at a specific result under appropriate conditions
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactMethod"></see></summary>
    let ResArtifactMethod =
        Namespaced_IRI.parse _namespace_name "ResArtifactMethod" |> NamespacedName

    /// <summary>
    /// collection of syntactic rules (grammar) and semantic specifications for representing objects of a particular domain
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactModelingLanguage"></see></summary>
    let ResArtifactModelingLanguage =
        Namespaced_IRI.parse _namespace_name "ResArtifactModelingLanguage" |> NamespacedName

    /// <summary>
    /// result of a process of manipulation of natural language objects
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactNLPArtifact"></see></summary>
    let ResArtifactNLPArtifact =
        Namespaced_IRI.parse _namespace_name "ResArtifactNLPArtifact" |> NamespacedName

    /// <summary>
    /// semantic network of different configuration stages; up to formally specified conceptualizations of a domain
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactOntology"></see></summary>
    let ResArtifactOntology =
        Namespaced_IRI.parse _namespace_name "ResArtifactOntology" |> NamespacedName

    /// <summary>
    /// basic precepts in a particular field of action
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactPolicy"></see></summary>
    let ResArtifactPolicy =
        Namespaced_IRI.parse _namespace_name "ResArtifactPolicy" |> NamespacedName

    /// <summary>
    /// characteristics or features of an object required by potential users
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactRequirements"></see></summary>
    let ResArtifactRequirements =
        Namespaced_IRI.parse _namespace_name "ResArtifactRequirements" |> NamespacedName

    /// <summary>
    /// specific reference or prescription for actions in a particular field of action
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactStandard"></see></summary>
    let ResArtifactStandard =
        Namespaced_IRI.parse _namespace_name "ResArtifactStandard" |> NamespacedName

    /// <summary>
    /// complex object whose parts interact and form a desing-related and functional whole
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactSystem"></see></summary>
    let ResArtifactSystem =
        Namespaced_IRI.parse _namespace_name "ResArtifactSystem" |> NamespacedName

    /// <summary>
    /// Unambiguously described or explained technical or business term
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactTermDefinition"></see></summary>
    let ResArtifactTermDefinition =
        Namespaced_IRI.parse _namespace_name "ResArtifactTermDefinition" |> NamespacedName

    /// <summary>
    /// clearly specified sequence of activities to achieve a desired target state
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactWorkflow"></see></summary>
    let ResArtifactWorkflow =
        Namespaced_IRI.parse _namespace_name "ResArtifactWorkflow" |> NamespacedName

    /// <summary>
    /// Solving a practice problem by a mixed group of scientists and practical experts. Several cycles of analysis, action and evaluation steps, each with a low level of structured instruments such as group discussions or planning games, are conducted.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethActionResearch"></see></summary>
    let ResMethActionResearch =
        Namespaced_IRI.parse _namespace_name "ResMethActionResearch" |> NamespacedName

    /// <summary>
    /// Research method applied in an analyzed scientific paper taken from a list of all relevant research methods used in Information Systems.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchMethod"></see></summary>
    let ResearchMethod =
        Namespaced_IRI.parse _namespace_name "ResearchMethod" |> NamespacedName

    /// <summary>
    /// Pure-language logical-deductive inferencing (as, for example, in philosophy)
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethArgumentDedAnalysis"></see></summary>
    let ResMethArgumentDedAnalysis =
        Namespaced_IRI.parse _namespace_name "ResMethArgumentDedAnalysis" |> NamespacedName

    /// <summary>
    /// The case study usually examines complex, difficult-to-distinguish phenomena in their natural context. It represents a special form of the qualitative-empirical methodology, which is investigated intensively by a few feature-bearers. It is either the objective examination of theses (behavioral approach) or the interpretation of behavioral patterns as the phenotypes of the realities constructed by the subjects (construction-oriented access).
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethCaseStudy"></see></summary>
    let ResMethCaseStudy =
        Namespaced_IRI.parse _namespace_name "ResMethCaseStudy" |> NamespacedName

    /// <summary>
    /// Logic-deductive inferencing using semiformal models
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethConceptualDedAnalysis"></see></summary>
    let ResMethConceptualDedAnalysis =
        Namespaced_IRI.parse _namespace_name "ResMethConceptualDedAnalysis" |> NamespacedName

    /// <summary>
    /// Design Science is an outcome-based information technology research methodology, which offers specific guidelines for evaluation and iteration within research projects.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethDesignScience"></see></summary>
    let ResMethDesignScience =
        Namespaced_IRI.parse _namespace_name "ResMethDesignScience" |> NamespacedName

    /// <summary>
    /// Ethnography would like to generate insights through participatory observation. The difference to the case study lies in the very high extent in which the researcher is integrated into the investigated social environment. There is a very small objective distance.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethEthnography"></see></summary>
    let ResMethEthnography =
        Namespaced_IRI.parse _namespace_name "ResMethEthnography" |> NamespacedName

    /// <summary>
    /// The field experiment investigates causal relationships in a controlled environment by manipulating an experimental variable in a repeatable manner and measuring the effect of manipulation. The object to be investigated is examined in its natural environment (in the 'field'), whereby the possibilities of environmental control are significantly influenced.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethFieldExperiment"></see></summary>
    let ResMethFieldExperiment =
        Namespaced_IRI.parse _namespace_name "ResMethFieldExperiment" |> NamespacedName

    /// <summary>
    /// Logic-deductive inferencing using mathematical-formal models
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethFormalDedAnalysis"></see></summary>
    let ResMethFormalDedAnalysis =
        Namespaced_IRI.parse _namespace_name "ResMethFormalDedAnalysis" |> NamespacedName

    /// <summary>
    /// The Grounded Theory aims at the inductive acquisition of new theories by intensive observation of the object of investigation in the field. The various procedures for coding and evaluating the predominantly qualitative data are precisely specified.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethGroundedTheory"></see></summary>
    let ResMethGroundedTheory =
        Namespaced_IRI.parse _namespace_name "ResMethGroundedTheory" |> NamespacedName

    /// <summary>
    /// The laboratory experiment investigates causal relationships in a controlled environment by manipulating an experimental variable in a repetitive manner and measuring the effect of manipulation. The object to be investigated is examined in an artificial environment (in the 'laboratory'), whereby the possibilities of environmental control are significantly influenced.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethLabExperiment"></see></summary>
    let ResMethLabExperiment =
        Namespaced_IRI.parse _namespace_name "ResMethLabExperiment" |> NamespacedName

    /// <summary>
    /// A literature review is a written document that presents a logically argued case founded on a comprehensive understanding of the current state of knowledge about a topic of study. This case establishes a convincing thesis to answer the study’s question.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethLiteratureAnalysis"></see></summary>
    let ResMethLiteratureAnalysis =
        Namespaced_IRI.parse _namespace_name "ResMethLiteratureAnalysis" |> NamespacedName

    /// <summary>
    /// A preliminary version of an application system is developed and evaluated. Both steps can generate new insights.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethPrototyping"></see></summary>
    let ResMethPrototyping =
        Namespaced_IRI.parse _namespace_name "ResMethPrototyping" |> NamespacedName

    /// <summary>
    /// This method integrates survey techniques such as questionnaires, interviews, Delphi method, content analyzes, etc. into an aggregate. It comprises a one-time survey over several individuals, which is subsequently coded and evaluated qualitatively. The result is a cross-section profile characteristic for the sample participants, which usually allows conclusions to be drawn on the total population.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethQualitativeResearch"></see></summary>
    let ResMethQualitativeResearch =
        Namespaced_IRI.parse _namespace_name "ResMethQualitativeResearch" |> NamespacedName

    /// <summary>
    /// This method integrates survey techniques such as questionnaires, interviews, Delphi method, content analyzes, etc. into an aggregate. It comprises a one-time survey over several individuals, which is subsequently coded and evaluated quantatively. The result is a cross-section profile characteristic for the sample participants, which usually allows conclusions to be drawn on the total population.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethQuantitativeResearch"></see></summary>
    let ResMethQuantitativeResearch =
        Namespaced_IRI.parse _namespace_name "ResMethQuantitativeResearch" |> NamespacedName

    /// <summary>
    /// The reference modeling produces inductively (out of observations) or deductively (eg from theories or models) mostly simplified and optimized projections (ideal concepts) of systems, in order to deepen existing knowledge and generate design templates from this.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethReferenceModeling"></see></summary>
    let ResMethReferenceModeling =
        Namespaced_IRI.parse _namespace_name "ResMethReferenceModeling" |> NamespacedName

    /// <summary>
    /// The simulation models the behavior of the system to be investigated formally and compares environmental conditions with certain assignments of the model parameters. Both the model construction and the observation of the endogenous model parameters allow to gain insights.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethSimulation"></see></summary>
    let ResMethSimulation =
        Namespaced_IRI.parse _namespace_name "ResMethSimulation" |> NamespacedName

    /// <summary>
    /// Unformalized list of research findings documented in an analyzed scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchFindings"></see></summary>
    let ResearchFindings =
        Namespaced_IRI.parse _namespace_name "ResearchFindings" |> NamespacedName

    /// <summary>
    /// List of formalized research methods applied in an analyzed scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchMethods"></see></summary>
    let ResearchMethods =
        Namespaced_IRI.parse _namespace_name "ResearchMethods" |> NamespacedName

    /// <summary>
    /// Abstract class for modeling an elicited research objective comprising a specific research activity and a research artifact to which the activity is applied.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchObjective"></see></summary>
    let ResearchObjective =
        Namespaced_IRI.parse _namespace_name "ResearchObjective" |> NamespacedName

    /// <summary>
    /// List of formalized research objectives targeted in an analyzed scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchObjectives"></see></summary>
    let ResearchObjectives =
        Namespaced_IRI.parse _namespace_name "ResearchObjectives" |> NamespacedName

    /// <summary>
    /// Is used in combination with research action type to indicate a research objective of a scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#researchActionType"></see></summary>
    let researchActionType =
        Namespaced_IRI.parse _namespace_name "researchActionType" |> NamespacedName

    /// <summary>
    /// Is used in combination with research action type to indicate a research objective of a scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#researchArtifact"></see></summary>
    let researchArtifact =
        Namespaced_IRI.parse _namespace_name "researchArtifact" |> NamespacedName
