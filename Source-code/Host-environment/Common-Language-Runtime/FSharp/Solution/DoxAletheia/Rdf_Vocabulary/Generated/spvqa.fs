namespace https.bmake.th_brandenburg.de.spv.hash

open DoxAletheia

module spvqa =
    let _namespace_name = "https://bmake.th-brandenburg.de/spv#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Unformalized list of critical issues observed in an analyzed scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#Critique"></see></summary>
    let Critique = _prefix "Critique"
    /// <summary>
    /// Unformalized list of future work announced in an analyzed scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#FutureWork"></see></summary>
    let FutureWork = _prefix "FutureWork"
    /// <summary>
    /// examine something systematically and in detail
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeAnalyze"></see></summary>
    let ResActTypeAnalyze = _prefix "ResActTypeAnalyze"
    /// <summary>
    /// The activity aspect of an elecited research objective taken from the list of types of research &amp; development actions applied in Information Systems.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchActionType"></see></summary>
    let ResearchActionType = _prefix "ResearchActionType"
    /// <summary>
    /// collect all parts or aspects of a complex object
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeCollect"></see></summary>
    let ResActTypeCollect = _prefix "ResActTypeCollect"
    /// <summary>
    /// define the essential terms (concepts) and relations of a domain
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeConceptualize"></see></summary>
    let ResActTypeConceptualize = _prefix "ResActTypeConceptualize"
    /// <summary>
    /// create something according to certain design or architectural principles
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeConstruct"></see></summary>
    let ResActTypeConstruct = _prefix "ResActTypeConstruct"
    /// <summary>
    /// unambiguously describe or explain a concept
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeDefine"></see></summary>
    let ResActTypeDefine = _prefix "ResActTypeDefine"
    /// <summary>
    /// basically design an object, mostly according to appropriate design principles
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeDesign"></see></summary>
    let ResActTypeDesign = _prefix "ResActTypeDesign"
    /// <summary>
    /// create something new, mostly using specialist methods and tools
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeDevelop"></see></summary>
    let ResActTypeDevelop = _prefix "ResActTypeDevelop"
    /// <summary>
    /// capture characteristics of objects under examination (eg by measurement)
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeElicit"></see></summary>
    let ResActTypeElicit = _prefix "ResActTypeElicit"
    /// <summary>
    /// improve an object in certain features or aspects
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeEnhance"></see></summary>
    let ResActTypeEnhance = _prefix "ResActTypeEnhance"
    /// <summary>
    /// assess a quantitative or qualitative property of an object
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeEvaluate"></see></summary>
    let ResActTypeEvaluate = _prefix "ResActTypeEvaluate"
    /// <summary>
    /// extend an object by properties or in its scope of functions or services
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeExtend"></see></summary>
    let ResActTypeExtend = _prefix "ResActTypeExtend"
    /// <summary>
    /// separate defined parts of a complex object and provide them in a suitable form
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeExtract"></see></summary>
    let ResActTypeExtract = _prefix "ResActTypeExtract"
    /// <summary>
    /// implement a designed object technically
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeImplement"></see></summary>
    let ResActTypeImplement = _prefix "ResActTypeImplement"
    /// <summary>
    /// merge several objects into a single unit
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeIntegrate"></see></summary>
    let ResActTypeIntegrate = _prefix "ResActTypeIntegrate"
    /// <summary>
    /// investigate how an object meets certain requirements; whether a statement (about an object) is true
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeProve"></see></summary>
    let ResActTypeProve = _prefix "ResActTypeProve"
    /// <summary>
    /// provide an object in a suitable manner for use
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeProvide"></see></summary>
    let ResActTypeProvide = _prefix "ResActTypeProvide"
    /// <summary>
    /// systematically organize parts, aspects or the like of a complex object
    /// <see href="https://bmake.th-brandenburg.de/spv#ResActTypeStructure"></see></summary>
    let ResActTypeStructure = _prefix "ResActTypeStructure"
    /// <summary>
    /// software artifact with a certain range of functions
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactApplication"></see></summary>
    let ResArtifactApplication = _prefix "ResArtifactApplication"
    /// <summary>
    /// The artifact aspect of an elicited research objective taken from the list of all types of research &amp; development artifacts characteristic for Information Systems.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchArtifact"></see></summary>
    let ResearchArtifact = _prefix "ResearchArtifact"
    /// <summary>
    /// model or technical design of an object
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactBlueprint"></see></summary>
    let ResArtifactBlueprint = _prefix "ResArtifactBlueprint"
    /// <summary>
    /// set of interacting and interdependent activities that converts input to output
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactBusinessProcess"></see></summary>
    let ResArtifactBusinessProcess = _prefix "ResArtifactBusinessProcess"
    /// <summary>
    /// complex (technical) environment for the development of applications and IT systems
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactDevFramework"></see></summary>
    let ResArtifactDevFramework = _prefix "ResArtifactDevFramework"
    /// <summary>
    /// technical, formal or semi-formal description of an object and the circumstances of its development or function
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactDocumentation"></see></summary>
    let ResArtifactDocumentation = _prefix "ResArtifactDocumentation"
    /// <summary>
    /// complex object of information technology whose parts interact and form a desing-related and functional whole
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactITSystem"></see></summary>
    let ResArtifactITSystem = _prefix "ResArtifactITSystem"
    /// <summary>
    /// a combined set of hardware, software, networks, facilities, etc. (including all of the information technology), in order to develop, test, deliver, monitor, control or support IT services
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactInfrastructure"></see></summary>
    let ResArtifactInfrastructure = _prefix "ResArtifactInfrastructure"
    /// <summary>
    /// standard-based, structured data, mostly based on the Semantic Web stack
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactLinkedData"></see></summary>
    let ResArtifactLinkedData = _prefix "ResArtifactLinkedData"
    /// <summary>
    /// prescription of procedures or activities which is aimed at a specific result under appropriate conditions
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactMethod"></see></summary>
    let ResArtifactMethod = _prefix "ResArtifactMethod"
    /// <summary>
    /// collection of syntactic rules (grammar) and semantic specifications for representing objects of a particular domain
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactModelingLanguage"></see></summary>
    let ResArtifactModelingLanguage = _prefix "ResArtifactModelingLanguage"
    /// <summary>
    /// result of a process of manipulation of natural language objects
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactNLPArtifact"></see></summary>
    let ResArtifactNLPArtifact = _prefix "ResArtifactNLPArtifact"
    /// <summary>
    /// semantic network of different configuration stages; up to formally specified conceptualizations of a domain
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactOntology"></see></summary>
    let ResArtifactOntology = _prefix "ResArtifactOntology"
    /// <summary>
    /// basic precepts in a particular field of action
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactPolicy"></see></summary>
    let ResArtifactPolicy = _prefix "ResArtifactPolicy"
    /// <summary>
    /// characteristics or features of an object required by potential users
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactRequirements"></see></summary>
    let ResArtifactRequirements = _prefix "ResArtifactRequirements"
    /// <summary>
    /// specific reference or prescription for actions in a particular field of action
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactStandard"></see></summary>
    let ResArtifactStandard = _prefix "ResArtifactStandard"
    /// <summary>
    /// complex object whose parts interact and form a desing-related and functional whole
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactSystem"></see></summary>
    let ResArtifactSystem = _prefix "ResArtifactSystem"
    /// <summary>
    /// Unambiguously described or explained technical or business term
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactTermDefinition"></see></summary>
    let ResArtifactTermDefinition = _prefix "ResArtifactTermDefinition"
    /// <summary>
    /// clearly specified sequence of activities to achieve a desired target state
    /// <see href="https://bmake.th-brandenburg.de/spv#ResArtifactWorkflow"></see></summary>
    let ResArtifactWorkflow = _prefix "ResArtifactWorkflow"
    /// <summary>
    /// Solving a practice problem by a mixed group of scientists and practical experts. Several cycles of analysis, action and evaluation steps, each with a low level of structured instruments such as group discussions or planning games, are conducted.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethActionResearch"></see></summary>
    let ResMethActionResearch = _prefix "ResMethActionResearch"
    /// <summary>
    /// Research method applied in an analyzed scientific paper taken from a list of all relevant research methods used in Information Systems.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchMethod"></see></summary>
    let ResearchMethod = _prefix "ResearchMethod"
    /// <summary>
    /// Pure-language logical-deductive inferencing (as, for example, in philosophy)
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethArgumentDedAnalysis"></see></summary>
    let ResMethArgumentDedAnalysis = _prefix "ResMethArgumentDedAnalysis"
    /// <summary>
    /// The case study usually examines complex, difficult-to-distinguish phenomena in their natural context. It represents a special form of the qualitative-empirical methodology, which is investigated intensively by a few feature-bearers. It is either the objective examination of theses (behavioral approach) or the interpretation of behavioral patterns as the phenotypes of the realities constructed by the subjects (construction-oriented access).
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethCaseStudy"></see></summary>
    let ResMethCaseStudy = _prefix "ResMethCaseStudy"
    /// <summary>
    /// Logic-deductive inferencing using semiformal models
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethConceptualDedAnalysis"></see></summary>
    let ResMethConceptualDedAnalysis = _prefix "ResMethConceptualDedAnalysis"
    /// <summary>
    /// Design Science is an outcome-based information technology research methodology, which offers specific guidelines for evaluation and iteration within research projects.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethDesignScience"></see></summary>
    let ResMethDesignScience = _prefix "ResMethDesignScience"
    /// <summary>
    /// Ethnography would like to generate insights through participatory observation. The difference to the case study lies in the very high extent in which the researcher is integrated into the investigated social environment. There is a very small objective distance.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethEthnography"></see></summary>
    let ResMethEthnography = _prefix "ResMethEthnography"
    /// <summary>
    /// The field experiment investigates causal relationships in a controlled environment by manipulating an experimental variable in a repeatable manner and measuring the effect of manipulation. The object to be investigated is examined in its natural environment (in the 'field'), whereby the possibilities of environmental control are significantly influenced.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethFieldExperiment"></see></summary>
    let ResMethFieldExperiment = _prefix "ResMethFieldExperiment"
    /// <summary>
    /// Logic-deductive inferencing using mathematical-formal models
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethFormalDedAnalysis"></see></summary>
    let ResMethFormalDedAnalysis = _prefix "ResMethFormalDedAnalysis"
    /// <summary>
    /// The Grounded Theory aims at the inductive acquisition of new theories by intensive observation of the object of investigation in the field. The various procedures for coding and evaluating the predominantly qualitative data are precisely specified.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethGroundedTheory"></see></summary>
    let ResMethGroundedTheory = _prefix "ResMethGroundedTheory"
    /// <summary>
    /// The laboratory experiment investigates causal relationships in a controlled environment by manipulating an experimental variable in a repetitive manner and measuring the effect of manipulation. The object to be investigated is examined in an artificial environment (in the 'laboratory'), whereby the possibilities of environmental control are significantly influenced.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethLabExperiment"></see></summary>
    let ResMethLabExperiment = _prefix "ResMethLabExperiment"
    /// <summary>
    /// A literature review is a written document that presents a logically argued case founded on a comprehensive understanding of the current state of knowledge about a topic of study. This case establishes a convincing thesis to answer the study’s question.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethLiteratureAnalysis"></see></summary>
    let ResMethLiteratureAnalysis = _prefix "ResMethLiteratureAnalysis"
    /// <summary>
    /// A preliminary version of an application system is developed and evaluated. Both steps can generate new insights.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethPrototyping"></see></summary>
    let ResMethPrototyping = _prefix "ResMethPrototyping"
    /// <summary>
    /// This method integrates survey techniques such as questionnaires, interviews, Delphi method, content analyzes, etc. into an aggregate. It comprises a one-time survey over several individuals, which is subsequently coded and evaluated qualitatively. The result is a cross-section profile characteristic for the sample participants, which usually allows conclusions to be drawn on the total population.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethQualitativeResearch"></see></summary>
    let ResMethQualitativeResearch = _prefix "ResMethQualitativeResearch"
    /// <summary>
    /// This method integrates survey techniques such as questionnaires, interviews, Delphi method, content analyzes, etc. into an aggregate. It comprises a one-time survey over several individuals, which is subsequently coded and evaluated quantatively. The result is a cross-section profile characteristic for the sample participants, which usually allows conclusions to be drawn on the total population.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethQuantitativeResearch"></see></summary>
    let ResMethQuantitativeResearch = _prefix "ResMethQuantitativeResearch"
    /// <summary>
    /// The reference modeling produces inductively (out of observations) or deductively (eg from theories or models) mostly simplified and optimized projections (ideal concepts) of systems, in order to deepen existing knowledge and generate design templates from this.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethReferenceModeling"></see></summary>
    let ResMethReferenceModeling = _prefix "ResMethReferenceModeling"
    /// <summary>
    /// The simulation models the behavior of the system to be investigated formally and compares environmental conditions with certain assignments of the model parameters. Both the model construction and the observation of the endogenous model parameters allow to gain insights.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResMethSimulation"></see></summary>
    let ResMethSimulation = _prefix "ResMethSimulation"
    /// <summary>
    /// Unformalized list of research findings documented in an analyzed scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchFindings"></see></summary>
    let ResearchFindings = _prefix "ResearchFindings"
    /// <summary>
    /// List of formalized research methods applied in an analyzed scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchMethods"></see></summary>
    let ResearchMethods = _prefix "ResearchMethods"
    /// <summary>
    /// Abstract class for modeling an elicited research objective comprising a specific research activity and a research artifact to which the activity is applied.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchObjective"></see></summary>
    let ResearchObjective = _prefix "ResearchObjective"
    /// <summary>
    /// List of formalized research objectives targeted in an analyzed scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#ResearchObjectives"></see></summary>
    let ResearchObjectives = _prefix "ResearchObjectives"
    /// <summary>
    /// Is used in combination with research action type to indicate a research objective of a scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#researchActionType"></see></summary>
    let researchActionType = _prefix "researchActionType"
    /// <summary>
    /// Is used in combination with research action type to indicate a research objective of a scientific paper.
    /// <see href="https://bmake.th-brandenburg.de/spv#researchArtifact"></see></summary>
    let researchArtifact = _prefix "researchArtifact"
