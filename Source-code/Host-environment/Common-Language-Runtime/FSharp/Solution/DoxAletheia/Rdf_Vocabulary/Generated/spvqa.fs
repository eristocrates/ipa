namespace https.bmake.th_brandenburg.de.spv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spvqa =
    let _namespace_iri = Namespace_Iri spvqa |> NamespaceIRI
    /// <summary>
    ///   <para>spvqa:ResearchActionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The activity aspect of an elecited research objective taken from the list of types of research &amp; development actions applied in Information Systems.</para>
    /// labels<para>Research Action Type</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResearchActionType">https://bmake.th-brandenburg.de/spv#ResearchActionType</seealso>
    let ResearchActionType = Prefixed_Name(spvqa, "ResearchActionType") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:Critique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unformalized list of critical issues observed in an analyzed scientific paper.</para>
    /// labels<para>Critique</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#Critique">https://bmake.th-brandenburg.de/spv#Critique</seealso>
    let Critique = Prefixed_Name(spvqa, "Critique") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:FutureWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unformalized list of future work announced in an analyzed scientific paper.</para>
    /// labels<para>Future Work</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#FutureWork">https://bmake.th-brandenburg.de/spv#FutureWork</seealso>
    let FutureWork = Prefixed_Name(spvqa, "FutureWork") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResActTypeAnalyze</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>examine something systematically and in detail</para>
    /// labels<para>analyze</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeAnalyze">https://bmake.th-brandenburg.de/spv#ResActTypeAnalyze</seealso>
    let ResActTypeAnalyze = Prefixed_Name(spvqa, "ResActTypeAnalyze") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResActTypeCollect</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>collect all parts or aspects of a complex object</para>
    /// labels<para>collect</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeCollect">https://bmake.th-brandenburg.de/spv#ResActTypeCollect</seealso>
    let ResActTypeCollect = Prefixed_Name(spvqa, "ResActTypeCollect") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResActTypeDesign</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>basically design an object, mostly according to appropriate design principles</para>
    /// labels<para>design</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeDesign">https://bmake.th-brandenburg.de/spv#ResActTypeDesign</seealso>
    let ResActTypeDesign = Prefixed_Name(spvqa, "ResActTypeDesign") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResActTypeEnhance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>improve an object in certain features or aspects</para>
    /// labels<para>enhance</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeEnhance">https://bmake.th-brandenburg.de/spv#ResActTypeEnhance</seealso>
    let ResActTypeEnhance = Prefixed_Name(spvqa, "ResActTypeEnhance") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResActTypeExtend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>extend an object by properties or in its scope of functions or services</para>
    /// labels<para>extend</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeExtend">https://bmake.th-brandenburg.de/spv#ResActTypeExtend</seealso>
    let ResActTypeExtend = Prefixed_Name(spvqa, "ResActTypeExtend") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResActTypeIntegrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>merge several objects into a single unit</para>
    /// labels<para>integrate</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeIntegrate">https://bmake.th-brandenburg.de/spv#ResActTypeIntegrate</seealso>
    let ResActTypeIntegrate =
        Prefixed_Name(spvqa, "ResActTypeIntegrate") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResActTypeStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>systematically organize parts, aspects or the like of a complex object</para>
    /// labels<para>structure</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeStructure">https://bmake.th-brandenburg.de/spv#ResActTypeStructure</seealso>
    let ResActTypeStructure =
        Prefixed_Name(spvqa, "ResActTypeStructure") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactBlueprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>model or technical design of an object</para>
    /// labels<para>Blueprint</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactBlueprint">https://bmake.th-brandenburg.de/spv#ResArtifactBlueprint</seealso>
    let ResArtifactBlueprint =
        Prefixed_Name(spvqa, "ResArtifactBlueprint") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactDevFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>complex (technical) environment for the development of applications and IT systems</para>
    /// labels<para>Development Framework</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactDevFramework">https://bmake.th-brandenburg.de/spv#ResArtifactDevFramework</seealso>
    let ResArtifactDevFramework =
        Prefixed_Name(spvqa, "ResArtifactDevFramework") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethArgumentDedAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>Pure-language logical-deductive inferencing (as, for example, in philosophy)</para>
    /// labels<para>Argumentative Deductive Analysis (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethArgumentDedAnalysis">https://bmake.th-brandenburg.de/spv#ResMethArgumentDedAnalysis</seealso>
    let ResMethArgumentDedAnalysis =
        Prefixed_Name(spvqa, "ResMethArgumentDedAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethEthnography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>Ethnography would like to generate insights through participatory observation. The difference to the case study lies in the very high extent in which the researcher is integrated into the investigated social environment. There is a very small objective distance.</para>
    /// labels<para>Ethnography (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethEthnography">https://bmake.th-brandenburg.de/spv#ResMethEthnography</seealso>
    let ResMethEthnography = Prefixed_Name(spvqa, "ResMethEthnography") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethFormalDedAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Logic-deductive inferencing using mathematical-formal models</para>
    /// labels<para>Formal Deductive Analysis (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethFormalDedAnalysis">https://bmake.th-brandenburg.de/spv#ResMethFormalDedAnalysis</seealso>
    let ResMethFormalDedAnalysis =
        Prefixed_Name(spvqa, "ResMethFormalDedAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethLabExperiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>The laboratory experiment investigates causal relationships in a controlled environment by manipulating an experimental variable in a repetitive manner and measuring the effect of manipulation. The object to be investigated is examined in an artificial environment (in the 'laboratory'), whereby the possibilities of environmental control are significantly influenced.</para>
    /// labels<para>Laboratory Experiment (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethLabExperiment">https://bmake.th-brandenburg.de/spv#ResMethLabExperiment</seealso>
    let ResMethLabExperiment =
        Prefixed_Name(spvqa, "ResMethLabExperiment") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResActTypeConstruct</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>create something according to certain design or architectural principles</para>
    /// labels<para>construct</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeConstruct">https://bmake.th-brandenburg.de/spv#ResActTypeConstruct</seealso>
    let ResActTypeConstruct =
        Prefixed_Name(spvqa, "ResActTypeConstruct") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResActTypeDevelop</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>create something new, mostly using specialist methods and tools</para>
    /// labels<para>develop</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeDevelop">https://bmake.th-brandenburg.de/spv#ResActTypeDevelop</seealso>
    let ResActTypeDevelop = Prefixed_Name(spvqa, "ResActTypeDevelop") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResActTypeElicit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>capture characteristics of objects under examination (eg by measurement)</para>
    /// labels<para>elicit</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeElicit">https://bmake.th-brandenburg.de/spv#ResActTypeElicit</seealso>
    let ResActTypeElicit = Prefixed_Name(spvqa, "ResActTypeElicit") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResActTypeExtract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>separate defined parts of a complex object and provide them in a suitable form</para>
    /// labels<para>extract</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeExtract">https://bmake.th-brandenburg.de/spv#ResActTypeExtract</seealso>
    let ResActTypeExtract = Prefixed_Name(spvqa, "ResActTypeExtract") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResActTypeConceptualize</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>define the essential terms (concepts) and relations of a domain</para>
    /// labels<para>conceptualize</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeConceptualize">https://bmake.th-brandenburg.de/spv#ResActTypeConceptualize</seealso>
    let ResActTypeConceptualize =
        Prefixed_Name(spvqa, "ResActTypeConceptualize") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResActTypeDefine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>unambiguously describe or explain a concept</para>
    /// labels<para>define</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeDefine">https://bmake.th-brandenburg.de/spv#ResActTypeDefine</seealso>
    let ResActTypeDefine = Prefixed_Name(spvqa, "ResActTypeDefine") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResActTypeEvaluate</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>assess a quantitative or qualitative property of an object</para>
    /// labels<para>evaluate</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeEvaluate">https://bmake.th-brandenburg.de/spv#ResActTypeEvaluate</seealso>
    let ResActTypeEvaluate = Prefixed_Name(spvqa, "ResActTypeEvaluate") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResActTypeImplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>implement a designed object technically</para>
    /// labels<para>implement</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeImplement">https://bmake.th-brandenburg.de/spv#ResActTypeImplement</seealso>
    let ResActTypeImplement =
        Prefixed_Name(spvqa, "ResActTypeImplement") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResActTypeProvide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>provide an object in a suitable manner for use</para>
    /// labels<para>provide</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeProvide">https://bmake.th-brandenburg.de/spv#ResActTypeProvide</seealso>
    let ResActTypeProvide = Prefixed_Name(spvqa, "ResActTypeProvide") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>software artifact with a certain range of functions</para>
    /// labels<para>Application</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactApplication">https://bmake.th-brandenburg.de/spv#ResArtifactApplication</seealso>
    let ResArtifactApplication =
        Prefixed_Name(spvqa, "ResArtifactApplication") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactBusinessProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>set of interacting and interdependent activities that converts input to output</para>
    /// labels<para>Business Process</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactBusinessProcess">https://bmake.th-brandenburg.de/spv#ResArtifactBusinessProcess</seealso>
    let ResArtifactBusinessProcess =
        Prefixed_Name(spvqa, "ResArtifactBusinessProcess") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>technical, formal or semi-formal description of an object and the circumstances of its development or function</para>
    /// labels<para>Documentation</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactDocumentation">https://bmake.th-brandenburg.de/spv#ResArtifactDocumentation</seealso>
    let ResArtifactDocumentation =
        Prefixed_Name(spvqa, "ResArtifactDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResActTypeProve</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchActionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>investigate how an object meets certain requirements; whether a statement (about an object) is true</para>
    /// labels<para>prove</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResActTypeProve">https://bmake.th-brandenburg.de/spv#ResActTypeProve</seealso>
    let ResActTypeProve = Prefixed_Name(spvqa, "ResActTypeProve") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResearchArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The artifact aspect of an elicited research objective taken from the list of all types of research &amp; development artifacts characteristic for Information Systems.</para>
    /// labels<para>Rresearch Artifact</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResearchArtifact">https://bmake.th-brandenburg.de/spv#ResearchArtifact</seealso>
    let ResearchArtifact = Prefixed_Name(spvqa, "ResearchArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>a combined set of hardware, software, networks, facilities, etc. (including all of the information technology), in order to develop, test, deliver, monitor, control or support IT services</para>
    /// labels<para>IT Infrastructure</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactInfrastructure">https://bmake.th-brandenburg.de/spv#ResArtifactInfrastructure</seealso>
    let ResArtifactInfrastructure =
        Prefixed_Name(spvqa, "ResArtifactInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactITSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>complex object of information technology whose parts interact and form a desing-related and functional whole</para>
    /// labels<para>IT System</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactITSystem">https://bmake.th-brandenburg.de/spv#ResArtifactITSystem</seealso>
    let ResArtifactITSystem =
        Prefixed_Name(spvqa, "ResArtifactITSystem") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactLinkedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>standard-based, structured data, mostly based on the Semantic Web stack</para>
    /// labels<para>Linked Data</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactLinkedData">https://bmake.th-brandenburg.de/spv#ResArtifactLinkedData</seealso>
    let ResArtifactLinkedData =
        Prefixed_Name(spvqa, "ResArtifactLinkedData") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactModelingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>collection of syntactic rules (grammar) and semantic specifications for representing objects of a particular domain</para>
    /// labels<para>Modeling Language</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactModelingLanguage">https://bmake.th-brandenburg.de/spv#ResArtifactModelingLanguage</seealso>
    let ResArtifactModelingLanguage =
        Prefixed_Name(spvqa, "ResArtifactModelingLanguage") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>prescription of procedures or activities which is aimed at a specific result under appropriate conditions</para>
    /// labels<para>Method</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactMethod">https://bmake.th-brandenburg.de/spv#ResArtifactMethod</seealso>
    let ResArtifactMethod = Prefixed_Name(spvqa, "ResArtifactMethod") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactNLPArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>result of a process of manipulation of natural language objects</para>
    /// labels<para>NLP Artifact</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactNLPArtifact">https://bmake.th-brandenburg.de/spv#ResArtifactNLPArtifact</seealso>
    let ResArtifactNLPArtifact =
        Prefixed_Name(spvqa, "ResArtifactNLPArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>basic precepts in a particular field of action</para>
    /// labels<para>Policy</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactPolicy">https://bmake.th-brandenburg.de/spv#ResArtifactPolicy</seealso>
    let ResArtifactPolicy = Prefixed_Name(spvqa, "ResArtifactPolicy") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>semantic network of different configuration stages; up to formally specified conceptualizations of a domain</para>
    /// labels<para>Ontology</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactOntology">https://bmake.th-brandenburg.de/spv#ResArtifactOntology</seealso>
    let ResArtifactOntology =
        Prefixed_Name(spvqa, "ResArtifactOntology") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>characteristics or features of an object required by potential users</para>
    /// labels<para>Requirements</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactRequirements">https://bmake.th-brandenburg.de/spv#ResArtifactRequirements</seealso>
    let ResArtifactRequirements =
        Prefixed_Name(spvqa, "ResArtifactRequirements") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>complex object whose parts interact and form a desing-related and functional whole</para>
    /// labels<para>System</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactSystem">https://bmake.th-brandenburg.de/spv#ResArtifactSystem</seealso>
    let ResArtifactSystem = Prefixed_Name(spvqa, "ResArtifactSystem") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResMethCaseStudy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>The case study usually examines complex, difficult-to-distinguish phenomena in their natural context. It represents a special form of the qualitative-empirical methodology, which is investigated intensively by a few feature-bearers. It is either the objective examination of theses (behavioral approach) or the interpretation of behavioral patterns as the phenotypes of the realities constructed by the subjects (construction-oriented access).</para>
    /// labels<para>Case Study (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethCaseStudy">https://bmake.th-brandenburg.de/spv#ResMethCaseStudy</seealso>
    let ResMethCaseStudy = Prefixed_Name(spvqa, "ResMethCaseStudy") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethDesignScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>Design Science is an outcome-based information technology research methodology, which offers specific guidelines for evaluation and iteration within research projects.</para>
    /// labels<para>Design Science (Hevner)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethDesignScience">https://bmake.th-brandenburg.de/spv#ResMethDesignScience</seealso>
    let ResMethDesignScience =
        Prefixed_Name(spvqa, "ResMethDesignScience") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethFieldExperiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>The field experiment investigates causal relationships in a controlled environment by manipulating an experimental variable in a repeatable manner and measuring the effect of manipulation. The object to be investigated is examined in its natural environment (in the 'field'), whereby the possibilities of environmental control are significantly influenced.</para>
    /// labels<para>Field Experiment (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethFieldExperiment">https://bmake.th-brandenburg.de/spv#ResMethFieldExperiment</seealso>
    let ResMethFieldExperiment =
        Prefixed_Name(spvqa, "ResMethFieldExperiment") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethGroundedTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Grounded Theory aims at the inductive acquisition of new theories by intensive observation of the object of investigation in the field. The various procedures for coding and evaluating the predominantly qualitative data are precisely specified.</para>
    /// labels<para>Grounded Theory (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethGroundedTheory">https://bmake.th-brandenburg.de/spv#ResMethGroundedTheory</seealso>
    let ResMethGroundedTheory =
        Prefixed_Name(spvqa, "ResMethGroundedTheory") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethLiteratureAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A literature review is a written document that presents a logically argued case founded on a comprehensive understanding of the current state of knowledge about a topic of study. This case establishes a convincing thesis to answer the study’s question.</para>
    /// labels<para>Literature Analysis (Machi/McEvoy)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethLiteratureAnalysis">https://bmake.th-brandenburg.de/spv#ResMethLiteratureAnalysis</seealso>
    let ResMethLiteratureAnalysis =
        Prefixed_Name(spvqa, "ResMethLiteratureAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethPrototyping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>A preliminary version of an application system is developed and evaluated. Both steps can generate new insights.</para>
    /// labels<para>Prototyping (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethPrototyping">https://bmake.th-brandenburg.de/spv#ResMethPrototyping</seealso>
    let ResMethPrototyping = Prefixed_Name(spvqa, "ResMethPrototyping") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethQualitativeResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This method integrates survey techniques such as questionnaires, interviews, Delphi method, content analyzes, etc. into an aggregate. It comprises a one-time survey over several individuals, which is subsequently coded and evaluated qualitatively. The result is a cross-section profile characteristic for the sample participants, which usually allows conclusions to be drawn on the total population.</para>
    /// labels<para>Qualitative Research (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethQualitativeResearch">https://bmake.th-brandenburg.de/spv#ResMethQualitativeResearch</seealso>
    let ResMethQualitativeResearch =
        Prefixed_Name(spvqa, "ResMethQualitativeResearch") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The simulation models the behavior of the system to be investigated formally and compares environmental conditions with certain assignments of the model parameters. Both the model construction and the observation of the endogenous model parameters allow to gain insights.</para>
    /// labels<para>Simulation (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethSimulation">https://bmake.th-brandenburg.de/spv#ResMethSimulation</seealso>
    let ResMethSimulation = Prefixed_Name(spvqa, "ResMethSimulation") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResearchMethods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>List of formalized research methods applied in an analyzed scientific paper.</para>
    /// labels<para>Research Methods</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResearchMethods">https://bmake.th-brandenburg.de/spv#ResearchMethods</seealso>
    let ResearchMethods = Prefixed_Name(spvqa, "ResearchMethods") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResearchObjectives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>List of formalized research objectives targeted in an analyzed scientific paper.</para>
    /// labels<para>Research Objectives</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResearchObjectives">https://bmake.th-brandenburg.de/spv#ResearchObjectives</seealso>
    let ResearchObjectives = Prefixed_Name(spvqa, "ResearchObjectives") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethQuantitativeResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This method integrates survey techniques such as questionnaires, interviews, Delphi method, content analyzes, etc. into an aggregate. It comprises a one-time survey over several individuals, which is subsequently coded and evaluated quantatively. The result is a cross-section profile characteristic for the sample participants, which usually allows conclusions to be drawn on the total population.</para>
    /// labels<para>Quantitative Research (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethQuantitativeResearch">https://bmake.th-brandenburg.de/spv#ResMethQuantitativeResearch</seealso>
    let ResMethQuantitativeResearch =
        Prefixed_Name(spvqa, "ResMethQuantitativeResearch") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethReferenceModeling</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The reference modeling produces inductively (out of observations) or deductively (eg from theories or models) mostly simplified and optimized projections (ideal concepts) of systems, in order to deepen existing knowledge and generate design templates from this.</para>
    /// labels<para>Reference Modeling (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethReferenceModeling">https://bmake.th-brandenburg.de/spv#ResMethReferenceModeling</seealso>
    let ResMethReferenceModeling =
        Prefixed_Name(spvqa, "ResMethReferenceModeling") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResearchFindings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unformalized list of research findings documented in an analyzed scientific paper.</para>
    /// labels<para>Research Findings</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResearchFindings">https://bmake.th-brandenburg.de/spv#ResearchFindings</seealso>
    let ResearchFindings = Prefixed_Name(spvqa, "ResearchFindings") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:ResearchObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class for modeling an elicited research objective comprising a specific research activity and a research artifact to which the activity is applied.</para>
    /// labels<para>Research Objective</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResearchObjective">https://bmake.th-brandenburg.de/spv#ResearchObjective</seealso>
    let ResearchObjective = Prefixed_Name(spvqa, "ResearchObjective") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:researchActionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Is used in combination with research action type to indicate a research objective of a scientific paper.</para>
    /// labels<para>research action type</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#researchActionType">https://bmake.th-brandenburg.de/spv#researchActionType</seealso>
    let researchActionType = Prefixed_Name(spvqa, "researchActionType") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:researchArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Is used in combination with research action type to indicate a research objective of a scientific paper.</para>
    /// labels<para>research artifact</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#researchArtifact">https://bmake.th-brandenburg.de/spv#researchArtifact</seealso>
    let researchArtifact = Prefixed_Name(spvqa, "researchArtifact") |> PrefixedName
    /// <summary>
    ///   <para>spvqa:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>This vocabulary is mainly defined under the reuse of schema.org classes, relations and attributes. It is aimed at the support of research groups in the field of Business Modeling and Knowledge Engineering (BMaKE) in their collaborative work for qualitatively analyzing scholarly papers as well as sharing the results of that analyses and judgements. The vocabulary is meant to be used at first as schema for OntoWiki. Since this system doesn't process blank nodes in the intended way, the abstract nodes for specifying qualitative aspects of scholarly papers shall be modeled explicitely.</para>
    /// labels<para>spv vocabulary (BMaKE)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#">https://bmake.th-brandenburg.de/spv#</seealso>
    let _prefix_iri = Prefixed_Name(spvqa, "") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>specific reference or prescription for actions in a particular field of action</para>
    /// labels<para>Standard, Guideline</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactStandard">https://bmake.th-brandenburg.de/spv#ResArtifactStandard</seealso>
    let ResArtifactStandard =
        Prefixed_Name(spvqa, "ResArtifactStandard") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactTermDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Unambiguously described or explained technical or business term</para>
    /// labels<para>Term Definition</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactTermDefinition">https://bmake.th-brandenburg.de/spv#ResArtifactTermDefinition</seealso>
    let ResArtifactTermDefinition =
        Prefixed_Name(spvqa, "ResArtifactTermDefinition") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResArtifactWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchArtifact</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>clearly specified sequence of activities to achieve a desired target state</para>
    /// labels<para>Workflow</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResArtifactWorkflow">https://bmake.th-brandenburg.de/spv#ResArtifactWorkflow</seealso>
    let ResArtifactWorkflow =
        Prefixed_Name(spvqa, "ResArtifactWorkflow") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethActionResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Solving a practice problem by a mixed group of scientists and practical experts. Several cycles of analysis, action and evaluation steps, each with a low level of structured instruments such as group discussions or planning games, are conducted.</para>
    /// labels<para>Action Research (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethActionResearch">https://bmake.th-brandenburg.de/spv#ResMethActionResearch</seealso>
    let ResMethActionResearch =
        Prefixed_Name(spvqa, "ResMethActionResearch") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResearchMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Research method applied in an analyzed scientific paper taken from a list of all relevant research methods used in Information Systems.</para>
    /// labels<para>Research Method</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResearchMethod">https://bmake.th-brandenburg.de/spv#ResearchMethod</seealso>
    let ResearchMethod = Prefixed_Name(spvqa, "ResearchMethod") |> PrefixedName

    /// <summary>
    ///   <para>spvqa:ResMethConceptualDedAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>spvqa:ResearchMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Logic-deductive inferencing using semiformal models</para>
    /// labels<para>Conceptual Deductive Analysis (Wilde/Hess)</para></remarks>
    /// <seealso href="https://bmake.th-brandenburg.de/spv#ResMethConceptualDedAnalysis">https://bmake.th-brandenburg.de/spv#ResMethConceptualDedAnalysis</seealso>
    let ResMethConceptualDedAnalysis =
        Prefixed_Name(spvqa, "ResMethConceptualDedAnalysis") |> PrefixedName
