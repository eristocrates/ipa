#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module spvqa =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://bmake.th-brandenburg.de/spv#" "spvqa"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Critique</para>
    ///   <para>rdfs:comment : Unformalized list of critical issues observed in an analyzed scientific paper.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#Critique">spvqa:Critique</a>
    /// </summary>
    let Critique = _prefixId.prefix "Critique"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Future Work</para>
    ///   <para>rdfs:comment : Unformalized list of future work announced in an analyzed scientific paper.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#FutureWork">spvqa:FutureWork</a>
    /// </summary>
    let FutureWork = _prefixId.prefix "FutureWork"
    let ResActTypeAnalyze = _prefixId.prefix "ResActTypeAnalyze"
    let ResActTypeCollect = _prefixId.prefix "ResActTypeCollect"
    let ResActTypeConceptualize = _prefixId.prefix "ResActTypeConceptualize"
    let ResActTypeConstruct = _prefixId.prefix "ResActTypeConstruct"
    let ResActTypeDefine = _prefixId.prefix "ResActTypeDefine"
    let ResActTypeDesign = _prefixId.prefix "ResActTypeDesign"
    let ResActTypeDevelop = _prefixId.prefix "ResActTypeDevelop"
    let ResActTypeElicit = _prefixId.prefix "ResActTypeElicit"
    let ResActTypeEnhance = _prefixId.prefix "ResActTypeEnhance"
    let ResActTypeEvaluate = _prefixId.prefix "ResActTypeEvaluate"
    let ResActTypeExtend = _prefixId.prefix "ResActTypeExtend"
    let ResActTypeExtract = _prefixId.prefix "ResActTypeExtract"
    let ResActTypeImplement = _prefixId.prefix "ResActTypeImplement"
    let ResActTypeIntegrate = _prefixId.prefix "ResActTypeIntegrate"
    let ResActTypeProve = _prefixId.prefix "ResActTypeProve"
    let ResActTypeProvide = _prefixId.prefix "ResActTypeProvide"
    let ResActTypeStructure = _prefixId.prefix "ResActTypeStructure"
    let ResArtifactApplication = _prefixId.prefix "ResArtifactApplication"
    let ResArtifactBlueprint = _prefixId.prefix "ResArtifactBlueprint"
    let ResArtifactBusinessProcess = _prefixId.prefix "ResArtifactBusinessProcess"
    let ResArtifactDevFramework = _prefixId.prefix "ResArtifactDevFramework"
    let ResArtifactDocumentation = _prefixId.prefix "ResArtifactDocumentation"
    let ResArtifactITSystem = _prefixId.prefix "ResArtifactITSystem"
    let ResArtifactInfrastructure = _prefixId.prefix "ResArtifactInfrastructure"
    let ResArtifactLinkedData = _prefixId.prefix "ResArtifactLinkedData"
    let ResArtifactMethod = _prefixId.prefix "ResArtifactMethod"
    let ResArtifactModelingLanguage = _prefixId.prefix "ResArtifactModelingLanguage"
    let ResArtifactNLPArtifact = _prefixId.prefix "ResArtifactNLPArtifact"
    let ResArtifactOntology = _prefixId.prefix "ResArtifactOntology"
    let ResArtifactPolicy = _prefixId.prefix "ResArtifactPolicy"
    let ResArtifactRequirements = _prefixId.prefix "ResArtifactRequirements"
    let ResArtifactStandard = _prefixId.prefix "ResArtifactStandard"
    let ResArtifactSystem = _prefixId.prefix "ResArtifactSystem"
    let ResArtifactTermDefinition = _prefixId.prefix "ResArtifactTermDefinition"
    let ResArtifactWorkflow = _prefixId.prefix "ResArtifactWorkflow"
    let ResMethActionResearch = _prefixId.prefix "ResMethActionResearch"
    let ResMethArgumentDedAnalysis = _prefixId.prefix "ResMethArgumentDedAnalysis"
    let ResMethCaseStudy = _prefixId.prefix "ResMethCaseStudy"
    let ResMethConceptualDedAnalysis = _prefixId.prefix "ResMethConceptualDedAnalysis"
    let ResMethDesignScience = _prefixId.prefix "ResMethDesignScience"
    let ResMethEthnography = _prefixId.prefix "ResMethEthnography"
    let ResMethFieldExperiment = _prefixId.prefix "ResMethFieldExperiment"
    let ResMethFormalDedAnalysis = _prefixId.prefix "ResMethFormalDedAnalysis"
    let ResMethGroundedTheory = _prefixId.prefix "ResMethGroundedTheory"
    let ResMethLabExperiment = _prefixId.prefix "ResMethLabExperiment"
    let ResMethLiteratureAnalysis = _prefixId.prefix "ResMethLiteratureAnalysis"
    let ResMethPrototyping = _prefixId.prefix "ResMethPrototyping"
    let ResMethQualitativeResearch = _prefixId.prefix "ResMethQualitativeResearch"
    let ResMethQuantitativeResearch = _prefixId.prefix "ResMethQuantitativeResearch"
    let ResMethReferenceModeling = _prefixId.prefix "ResMethReferenceModeling"
    let ResMethSimulation = _prefixId.prefix "ResMethSimulation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Research Action Type</para>
    ///   <para>rdfs:comment : The activity aspect of an elecited research objective taken from the list of types of research &amp; development actions applied in Information Systems.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#ResearchActionType">spvqa:ResearchActionType</a>
    /// </summary>
    let ResearchActionType = _prefixId.prefix "ResearchActionType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Rresearch Artifact</para>
    ///   <para>rdfs:comment : The artifact aspect of an elicited research objective taken from the list of all types of research &amp; development artifacts characteristic for Information Systems.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#ResearchArtifact">spvqa:ResearchArtifact</a>
    /// </summary>
    let ResearchArtifact = _prefixId.prefix "ResearchArtifact"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Research Findings</para>
    ///   <para>rdfs:comment : Unformalized list of research findings documented in an analyzed scientific paper.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#ResearchFindings">spvqa:ResearchFindings</a>
    /// </summary>
    let ResearchFindings = _prefixId.prefix "ResearchFindings"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Research Method</para>
    ///   <para>rdfs:comment : Research method applied in an analyzed scientific paper taken from a list of all relevant research methods used in Information Systems.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#ResearchMethod">spvqa:ResearchMethod</a>
    /// </summary>
    let ResearchMethod = _prefixId.prefix "ResearchMethod"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Research Methods</para>
    ///   <para>rdfs:comment : List of formalized research methods applied in an analyzed scientific paper.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#ResearchMethods">spvqa:ResearchMethods</a>
    /// </summary>
    let ResearchMethods = _prefixId.prefix "ResearchMethods"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Research Objective</para>
    ///   <para>rdfs:comment : Abstract class for modeling an elicited research objective comprising a specific research activity and a research artifact to which the activity is applied.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#ResearchObjective">spvqa:ResearchObjective</a>
    /// </summary>
    let ResearchObjective = _prefixId.prefix "ResearchObjective"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Research Objectives</para>
    ///   <para>rdfs:comment : List of formalized research objectives targeted in an analyzed scientific paper.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#ResearchObjectives">spvqa:ResearchObjectives</a>
    /// </summary>
    let ResearchObjectives = _prefixId.prefix "ResearchObjectives"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : research action type</para>
    ///   <para>rdfs:comment : Is used in combination with research action type to indicate a research objective of a scientific paper.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#researchActionType">spvqa:researchActionType</a>
    /// </summary>
    let researchActionType = _prefixId.prefix "researchActionType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : research artifact</para>
    ///   <para>rdfs:comment : Is used in combination with research action type to indicate a research objective of a scientific paper.</para>
    ///   <a href="https://bmake.th-brandenburg.de/spv#researchArtifact">spvqa:researchArtifact</a>
    /// </summary>
    let researchArtifact = _prefixId.prefix "researchArtifact"
