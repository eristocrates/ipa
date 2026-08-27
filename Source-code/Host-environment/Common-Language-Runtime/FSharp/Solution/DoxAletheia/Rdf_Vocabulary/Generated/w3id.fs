namespace https.w3id.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3id =
    let _namespace_iri = Namespace_Iri w3id |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO/1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO/1.0.0">https://w3id.org/earthsemantics/OSO/1.0.0</seealso>
    let ``earthsemantics/OSO/1.0.0`` =
        Prefixed_Name(w3id, "earthsemantics/OSO/1.0.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO/1.0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO/1.0.1">https://w3id.org/earthsemantics/OSO/1.0.1</seealso>
    let ``earthsemantics/OSO/1.0.1`` =
        Prefixed_Name(w3id, "earthsemantics/OSO/1.0.1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO/1.0.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO/1.0.2">https://w3id.org/earthsemantics/OSO/1.0.2</seealso>
    let ``earthsemantics/OSO/1.0.2`` =
        Prefixed_Name(w3id, "earthsemantics/OSO/1.0.2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO/1.0.3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO/1.0.3">https://w3id.org/earthsemantics/OSO/1.0.3</seealso>
    let ``earthsemantics/OSO/1.0.3`` =
        Prefixed_Name(w3id, "earthsemantics/OSO/1.0.3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO/dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>void:Dataset</para>
    ///   <para>vcard2006:Kind</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcat:Dataset</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO/dataset">https://w3id.org/earthsemantics/OSO/dataset</seealso>
    let ``earthsemantics/OSO/dataset`` =
        Prefixed_Name(w3id, "earthsemantics/OSO/dataset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO/dcat</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO/dcat">https://w3id.org/earthsemantics/OSO/dcat</seealso>
    let ``earthsemantics/OSO/dcat`` =
        Prefixed_Name(w3id, "earthsemantics/OSO/dcat") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO_DCAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO_DCAT">https://w3id.org/earthsemantics/OSO_DCAT</seealso>
    let ``earthsemantics/OSO_DCAT`` =
        Prefixed_Name(w3id, "earthsemantics/OSO_DCAT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ecfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"1.0.0 release of the Emission Conversion Factor Ontology"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ecfo">https://w3id.org/ecfo</seealso>
    let ecfo = Prefixed_Name(w3id, "ecfo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ecfo/0.0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ecfo/0.0.2">https://w3id.org/ecfo/0.0.2</seealso>
    let ``ecfo/0.0.2`` = Prefixed_Name(w3id, "ecfo/0.0.2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ecfo/1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ecfo/1.0.0">https://w3id.org/ecfo/1.0.0</seealso>
    let ``ecfo/1.0.0`` = Prefixed_Name(w3id, "ecfo/1.0.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:eeo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/eeo">https://w3id.org/eeo</seealso>
    let eeo = Prefixed_Name(w3id, "eeo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:eeo/0.1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0">https://w3id.org/eeo/0.1.0</seealso>
    let ``eeo/0.1.0`` = Prefixed_Name(w3id, "eeo/0.1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/ComputationalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A property that is assignable to the computational unit on which the experimental run is performed. The computational properties are potentially impacting on the ExperimentalResult and the EvaluationResult."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ComputationalProperty"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/ComputationalProperty">https://w3id.org/eeo/0.1.0/ComputationalProperty</seealso>
    let ``eeo/0.1.0/ComputationalProperty`` =
        Prefixed_Name(w3id, "eeo/0.1.0/ComputationalProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A minimal interpretation of a stimulus."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Data">https://w3id.org/eeo/0.1.0/Data</seealso>
    let ``eeo/0.1.0/Data`` = Prefixed_Name(w3id, "eeo/0.1.0/Data") |> PrefixedName
    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Effect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of properties that result from an ExperimentalRun. Synonyms: Response variable, observational unit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Effect"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Effect">https://w3id.org/eeo/0.1.0/Effect</seealso>
    let ``eeo/0.1.0/Effect`` = Prefixed_Name(w3id, "eeo/0.1.0/Effect") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Evaluand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Entity that is the subject of an Evaluation. Synonym: Evaluand, EvaluationUnit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evaluand"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Evaluand">https://w3id.org/eeo/0.1.0/Evaluand</seealso>
    let ``eeo/0.1.0/Evaluand`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Evaluand") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Process of assigning a quantity or quality value to a property of one or more Evaluands by means of an EvaluationMethod. Each Evaluation has an EvaluationContext, an EvaluationResult and may consist of one or more Evaluations. Polysemy sibling with the result of an Evaluation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evaluation"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Evaluation">https://w3id.org/eeo/0.1.0/Evaluation</seealso>
    let ``eeo/0.1.0/Evaluation`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Evaluation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/EvaluationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A spatiotemporal region that includes a description of all Entities that impact on the Evaluation without being part of the Evaluation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EvaluationContext"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/EvaluationContext">https://w3id.org/eeo/0.1.0/EvaluationContext</seealso>
    let ``eeo/0.1.0/EvaluationContext`` =
        Prefixed_Name(w3id, "eeo/0.1.0/EvaluationContext") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/EvaluationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Method aiming at the quantification of a Quality of an Evaluand making use of one or more EvaluationCriteria and EvaluationValueScales."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EvaluationMethod"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/EvaluationMethod">https://w3id.org/eeo/0.1.0/EvaluationMethod</seealso>
    let ``eeo/0.1.0/EvaluationMethod`` =
        Prefixed_Name(w3id, "eeo/0.1.0/EvaluationMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/EvaluationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Output of an Evaluation. A Quantity that is assigned to the Evaluand referring to an EvaluationCriterion and an EvaluationValueScale."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EvaluationResult"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/EvaluationResult">https://w3id.org/eeo/0.1.0/EvaluationResult</seealso>
    let ``eeo/0.1.0/EvaluationResult`` =
        Prefixed_Name(w3id, "eeo/0.1.0/EvaluationResult") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/EvaluationSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The cartesian product of the sets of the EvaluationCriteria realised by their respective EvaluationMetrics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EvaluationSpace"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/EvaluationSpace">https://w3id.org/eeo/0.1.0/EvaluationSpace</seealso>
    let ``eeo/0.1.0/EvaluationSpace`` =
        Prefixed_Name(w3id, "eeo/0.1.0/EvaluationSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/EvaluationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Implementation that performs an Evaluation."</para>
    /// labels<para>"EvaluationSystem"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/EvaluationSystem">https://w3id.org/eeo/0.1.0/EvaluationSystem</seealso>
    let ``eeo/0.1.0/EvaluationSystem`` =
        Prefixed_Name(w3id, "eeo/0.1.0/EvaluationSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/EvaluationValueScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of quality or quantity values of a quality or quantity that describes the relation between two or more values according to the properties of the set, e.g. set for distinguishing values, ordered set for ranking values, a metric that applies to all members of the set, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EvaluationValueScale"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/EvaluationValueScale">https://w3id.org/eeo/0.1.0/EvaluationValueScale</seealso>
    let ``eeo/0.1.0/EvaluationValueScale`` =
        Prefixed_Name(w3id, "eeo/0.1.0/EvaluationValueScale") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Experiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Process that includes two or more ExperimentalRuns between which the Input to an ExperimentalUnit is varied according to an ExperimentalPlan in a controlled way and the Effects are observed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Experiment"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Experiment">https://w3id.org/eeo/0.1.0/Experiment</seealso>
    let ``eeo/0.1.0/Experiment`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Experiment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/ExperimentalPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A randomly ordered set of two or more Treatments."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExperimentalPlan"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/ExperimentalPlan">https://w3id.org/eeo/0.1.0/ExperimentalPlan</seealso>
    let ``eeo/0.1.0/ExperimentalPlan`` =
        Prefixed_Name(w3id, "eeo/0.1.0/ExperimentalPlan") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/ExperimentalRun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Process in which the ExperimentalUnit transforms an Input into an ExperimentalResult."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExperimentalRun"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/ExperimentalRun">https://w3id.org/eeo/0.1.0/ExperimentalRun</seealso>
    let ``eeo/0.1.0/ExperimentalRun`` =
        Prefixed_Name(w3id, "eeo/0.1.0/ExperimentalRun") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/ExperimentalRunContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A spatiotemporal region that is composed of ParameterSetting and ComputationalProperties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExperimentalRunContext"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/ExperimentalRunContext">https://w3id.org/eeo/0.1.0/ExperimentalRunContext</seealso>
    let ``eeo/0.1.0/ExperimentalRunContext`` =
        Prefixed_Name(w3id, "eeo/0.1.0/ExperimentalRunContext") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/ExperimentalSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The cartesian product of the sets of the FactorLevels of each Factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExperimentalSpace"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/ExperimentalSpace">https://w3id.org/eeo/0.1.0/ExperimentalSpace</seealso>
    let ``eeo/0.1.0/ExperimentalSpace`` =
        Prefixed_Name(w3id, "eeo/0.1.0/ExperimentalSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/ExperimentalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Entity that has a function which transforms a Treatment into an ExperimentalResult during the ExperimentalRun and whose properties remain unchanged over the period of the experiment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Corresponds to Phenomenon in VIM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExperimentalUnit"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/ExperimentalUnit">https://w3id.org/eeo/0.1.0/ExperimentalUnit</seealso>
    let ``eeo/0.1.0/ExperimentalUnit`` =
        Prefixed_Name(w3id, "eeo/0.1.0/ExperimentalUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Entity that is an Input of the ExperimentalUnit within an Experiment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Factor"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Factor">https://w3id.org/eeo/0.1.0/Factor</seealso>
    let ``eeo/0.1.0/Factor`` = Prefixed_Name(w3id, "eeo/0.1.0/Factor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/FactorLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value that is or may be assigned to a factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FactorLevel"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/FactorLevel">https://w3id.org/eeo/0.1.0/FactorLevel</seealso>
    let ``eeo/0.1.0/FactorLevel`` =
        Prefixed_Name(w3id, "eeo/0.1.0/FactorLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Hypothesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A model of the Evaluand to be accepted or rejected."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hypothesis"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Hypothesis">https://w3id.org/eeo/0.1.0/Hypothesis</seealso>
    let ``eeo/0.1.0/Hypothesis`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Hypothesis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entity that interprets a Specification and may create a process when being execute. An Implementation may be an ExperimentalUnit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Implementation"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Implementation">https://w3id.org/eeo/0.1.0/Implementation</seealso>
    let ``eeo/0.1.0/Implementation`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Implementation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/IntervalInterpretedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Value interpreted according to multiple ordered categories that are subject to a distance measure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IntervalInterpretedValue"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/IntervalInterpretedValue">https://w3id.org/eeo/0.1.0/IntervalInterpretedValue</seealso>
    let ``eeo/0.1.0/IntervalInterpretedValue`` =
        Prefixed_Name(w3id, "eeo/0.1.0/IntervalInterpretedValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Process of assigning one or more quantity values to a measurand."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Measurement">https://w3id.org/eeo/0.1.0/Measurement</seealso>
    let ``eeo/0.1.0/Measurement`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Measurement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A description of a Process to acquire Data, Information or Knowledge."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Method"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Method">https://w3id.org/eeo/0.1.0/Method</seealso>
    let ``eeo/0.1.0/Method`` = Prefixed_Name(w3id, "eeo/0.1.0/Method") |> PrefixedName
    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An incomplete and simplified representation of an entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Model"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Model">https://w3id.org/eeo/0.1.0/Model</seealso>
    let ``eeo/0.1.0/Model`` = Prefixed_Name(w3id, "eeo/0.1.0/Model") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/NominalInterpretedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Value interpreted according to multiple categories."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NominalInterpretedValue"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/NominalInterpretedValue">https://w3id.org/eeo/0.1.0/NominalInterpretedValue</seealso>
    let ``eeo/0.1.0/NominalInterpretedValue`` =
        Prefixed_Name(w3id, "eeo/0.1.0/NominalInterpretedValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/OrdinalInterpretedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Value interpreted according to multiple ordered categories."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OrdinalInterpretedValue"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/OrdinalInterpretedValue">https://w3id.org/eeo/0.1.0/OrdinalInterpretedValue</seealso>
    let ``eeo/0.1.0/OrdinalInterpretedValue`` =
        Prefixed_Name(w3id, "eeo/0.1.0/OrdinalInterpretedValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/ParameterSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of parameter values that are not changed during an Experiment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ParameterSetting"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/ParameterSetting">https://w3id.org/eeo/0.1.0/ParameterSetting</seealso>
    let ``eeo/0.1.0/ParameterSetting`` =
        Prefixed_Name(w3id, "eeo/0.1.0/ParameterSetting") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Phenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Phenomenon">https://w3id.org/eeo/0.1.0/Phenomenon</seealso>
    let ``eeo/0.1.0/Phenomenon`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Phenomenon") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A quality that allows to distinguish or match two or more Entities or Processes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Predicate"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Predicate">https://w3id.org/eeo/0.1.0/Predicate</seealso>
    let ``eeo/0.1.0/Predicate`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Predicate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/QualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of a property of an entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"QualityValue"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/QualityValue">https://w3id.org/eeo/0.1.0/QualityValue</seealso>
    let ``eeo/0.1.0/QualityValue`` =
        Prefixed_Name(w3id, "eeo/0.1.0/QualityValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A property of an entity to which a value can be assigned that has a meaningful quantitative interpretation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quantity"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Quantity">https://w3id.org/eeo/0.1.0/Quantity</seealso>
    let ``eeo/0.1.0/Quantity`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Quantity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/QuantityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A numerical value of a property of an entity that has a magnitude."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"QuantityValue"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/QuantityValue">https://w3id.org/eeo/0.1.0/QuantityValue</seealso>
    let ``eeo/0.1.0/QuantityValue`` =
        Prefixed_Name(w3id, "eeo/0.1.0/QuantityValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/RatioInterpretedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A QuantityValue interpreted according to multiple ordered categories that are subject to a distance measure and that make reference to a zero element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RatioInterpretedValue"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/RatioInterpretedValue">https://w3id.org/eeo/0.1.0/RatioInterpretedValue</seealso>
    let ``eeo/0.1.0/RatioInterpretedValue`` =
        Prefixed_Name(w3id, "eeo/0.1.0/RatioInterpretedValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Entity that describes necessary properties of an Implementation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specification"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Specification">https://w3id.org/eeo/0.1.0/Specification</seealso>
    let ``eeo/0.1.0/Specification`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Specification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Process to be completed in order to fulfill a predefined goal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Task"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Task">https://w3id.org/eeo/0.1.0/Task</seealso>
    let ``eeo/0.1.0/Task`` = Prefixed_Name(w3id, "eeo/0.1.0/Task") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Treatment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of FactorLevels that specifies the input to the ExperimentalUnit in a domain independent way. Each ExperimentalRun/Test has exactly one treatment. In one Treatment for each factor exactly one factor level is specified."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Treatment"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Treatment">https://w3id.org/eeo/0.1.0/Treatment</seealso>
    let ``eeo/0.1.0/Treatment`` =
        Prefixed_Name(w3id, "eeo/0.1.0/Treatment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A quality which specifies a Predicate."</para>
    /// labels<para>"Value"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/Value">https://w3id.org/eeo/0.1.0/Value</seealso>
    let ``eeo/0.1.0/Value`` = Prefixed_Name(w3id, "eeo/0.1.0/Value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:eeo/0.1.0/applies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"makes use of"</para>
    /// labels<para>"applies"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/applies">https://w3id.org/eeo/0.1.0/applies</seealso>
    let ``eeo/0.1.0/applies`` = Prefixed_Name(w3id, "eeo/0.1.0/applies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/formalises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"provides a formal description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"formalises"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/formalises">https://w3id.org/eeo/0.1.0/formalises</seealso>
    let ``eeo/0.1.0/formalises`` =
        Prefixed_Name(w3id, "eeo/0.1.0/formalises") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/hasFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is described by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasFactor"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/hasFactor">https://w3id.org/eeo/0.1.0/hasFactor</seealso>
    let ``eeo/0.1.0/hasFactor`` =
        Prefixed_Name(w3id, "eeo/0.1.0/hasFactor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/hasFactorLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is described by and may take one of multiple values of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasFactorLevel"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/hasFactorLevel">https://w3id.org/eeo/0.1.0/hasFactorLevel</seealso>
    let ``eeo/0.1.0/hasFactorLevel`` =
        Prefixed_Name(w3id, "eeo/0.1.0/hasFactorLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"consists of, contains"</para>
    /// labels<para>"hasPart"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/hasPart">https://w3id.org/eeo/0.1.0/hasPart</seealso>
    let ``eeo/0.1.0/hasPart`` = Prefixed_Name(w3id, "eeo/0.1.0/hasPart") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isAppliedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is used by an entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isAppliedBy
    /// "</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isAppliedBy">https://w3id.org/eeo/0.1.0/isAppliedBy</seealso>
    let ``eeo/0.1.0/isAppliedBy`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isAppliedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isAppliedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is used to interpret an entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isAppliedTo"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isAppliedTo">https://w3id.org/eeo/0.1.0/isAppliedTo</seealso>
    let ``eeo/0.1.0/isAppliedTo`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isAppliedTo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isEvaluationResultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is the output of an evaluation"</para>
    /// labels<para>"isEvaluationResultOf"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isEvaluationResultOf">https://w3id.org/eeo/0.1.0/isEvaluationResultOf</seealso>
    let ``eeo/0.1.0/isEvaluationResultOf`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isEvaluationResultOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isExecutionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is performing action at runtime according to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isExecutionOf"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isExecutionOf">https://w3id.org/eeo/0.1.0/isExecutionOf</seealso>
    let ``eeo/0.1.0/isExecutionOf`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isExecutionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isExperimentalUnitOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is characterised by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isExperimentalUnitOf"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isExperimentalUnitOf">https://w3id.org/eeo/0.1.0/isExperimentalUnitOf</seealso>
    let ``eeo/0.1.0/isExperimentalUnitOf`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isExperimentalUnitOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isImplementing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is interpreting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isImplementing"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isImplementing">https://w3id.org/eeo/0.1.0/isImplementing</seealso>
    let ``eeo/0.1.0/isImplementing`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isImplementing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isInputOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is included in the domain of a function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isInputOf"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isInputOf">https://w3id.org/eeo/0.1.0/isInputOf</seealso>
    let ``eeo/0.1.0/isInputOf`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isInputOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isOutputOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value that is assigned"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isOutputOf"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isOutputOf">https://w3id.org/eeo/0.1.0/isOutputOf</seealso>
    let ``eeo/0.1.0/isOutputOf`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isOutputOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isPartOf">https://w3id.org/eeo/0.1.0/isPartOf</seealso>
    let ``eeo/0.1.0/isPartOf`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isPartOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isRunningIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"depends on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isRunningIn"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isRunningIn">https://w3id.org/eeo/0.1.0/isRunningIn</seealso>
    let ``eeo/0.1.0/isRunningIn`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isRunningIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isSpecifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is described in detail by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isSpecifiedBy"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isSpecifiedBy">https://w3id.org/eeo/0.1.0/isSpecifiedBy</seealso>
    let ``eeo/0.1.0/isSpecifiedBy`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isSpecifiedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/isValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is specifying"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isValueOf"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/isValueOf">https://w3id.org/eeo/0.1.0/isValueOf</seealso>
    let ``eeo/0.1.0/isValueOf`` =
        Prefixed_Name(w3id, "eeo/0.1.0/isValueOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/projectsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"assigns one or more elements from a given set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"projectsOn"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/projectsOn">https://w3id.org/eeo/0.1.0/projectsOn</seealso>
    let ``eeo/0.1.0/projectsOn`` =
        Prefixed_Name(w3id, "eeo/0.1.0/projectsOn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:eeo/0.1.0/pursues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"aims to fulfill"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pursues"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/pursues">https://w3id.org/eeo/0.1.0/pursues</seealso>
    let ``eeo/0.1.0/pursues`` = Prefixed_Name(w3id, "eeo/0.1.0/pursues") |> PrefixedName
    /// <summary>
    ///   <para>w3id:eeo/0.1.0/spans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"turns a set into a space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"spans"</para></remarks>
    /// <seealso href="https://w3id.org/eeo/0.1.0/spans">https://w3id.org/eeo/0.1.0/spans</seealso>
    let ``eeo/0.1.0/spans`` = Prefixed_Name(w3id, "eeo/0.1.0/spans") |> PrefixedName
    /// <summary>
    ///   <para>w3id:eep</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/eep">https://w3id.org/eep</seealso>
    let eep = Prefixed_Name(w3id, "eep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The EMMO should be reasoned in order to visualize all inferences and class hierarchy in Protege (ctrl+R hotkey).  It is tested with both the HermiT (preferred) and HermiT reasoners."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/emmo">https://w3id.org/emmo</seealso>
    let emmo = Prefixed_Name(w3id, "emmo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta5/multiperspective/symbolic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta5/multiperspective/symbolic">https://w3id.org/emmo/1.0.0-beta5/multiperspective/symbolic</seealso>
    let ``emmo/1.0.0_beta5/multiperspective/symbolic`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta5/multiperspective/symbolic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/disciplines/computerscience</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/disciplines/computerscience">https://w3id.org/emmo/1.0.0-beta7/disciplines/computerscience</seealso>
    let ``emmo/1.0.0_beta7/disciplines/computerscience`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/disciplines/computerscience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/disciplines/isq</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/disciplines/isq">https://w3id.org/emmo/1.0.0-beta7/disciplines/isq</seealso>
    let ``emmo/1.0.0_beta7/disciplines/isq`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/disciplines/isq") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/disciplines/manufacturing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/disciplines/manufacturing">https://w3id.org/emmo/1.0.0-beta7/disciplines/manufacturing</seealso>
    let ``emmo/1.0.0_beta7/disciplines/manufacturing`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/disciplines/manufacturing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/disciplines/math</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/disciplines/math">https://w3id.org/emmo/1.0.0-beta7/disciplines/math</seealso>
    let ``emmo/1.0.0_beta7/disciplines/math`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/disciplines/math") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/disciplines/metrology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/disciplines/metrology">https://w3id.org/emmo/1.0.0-beta7/disciplines/metrology</seealso>
    let ``emmo/1.0.0_beta7/disciplines/metrology`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/disciplines/metrology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/disciplines/models</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/disciplines/models">https://w3id.org/emmo/1.0.0-beta7/disciplines/models</seealso>
    let ``emmo/1.0.0_beta7/disciplines/models`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/disciplines/models") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/mereocausality</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/mereocausality">https://w3id.org/emmo/1.0.0-beta7/mereocausality</seealso>
    let ``emmo/1.0.0_beta7/mereocausality`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/mereocausality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/multiperspective/persholistic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/multiperspective/persholistic">https://w3id.org/emmo/1.0.0-beta7/multiperspective/persholistic</seealso>
    let ``emmo/1.0.0_beta7/multiperspective/persholistic`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/multiperspective/persholistic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/multiperspective/workflow</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/multiperspective/workflow">https://w3id.org/emmo/1.0.0-beta7/multiperspective/workflow</seealso>
    let ``emmo/1.0.0_beta7/multiperspective/workflow`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/multiperspective/workflow") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/perspectives/data</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/perspectives/data">https://w3id.org/emmo/1.0.0-beta7/perspectives/data</seealso>
    let ``emmo/1.0.0_beta7/perspectives/data`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/perspectives/data") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/perspectives/holistic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/perspectives/holistic">https://w3id.org/emmo/1.0.0-beta7/perspectives/holistic</seealso>
    let ``emmo/1.0.0_beta7/perspectives/holistic`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/perspectives/holistic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/perspectives/persistence</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/perspectives/persistence">https://w3id.org/emmo/1.0.0-beta7/perspectives/persistence</seealso>
    let ``emmo/1.0.0_beta7/perspectives/persistence`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/perspectives/persistence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-beta7/perspectives/semiotics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-beta7/perspectives/semiotics">https://w3id.org/emmo/1.0.0-beta7/perspectives/semiotics</seealso>
    let ``emmo/1.0.0_beta7/perspectives/semiotics`` =
        Prefixed_Name(w3id, "emmo/1.0.0-beta7/perspectives/semiotics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/1.0.0-rc1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/1.0.0-rc1">https://w3id.org/emmo/1.0.0-rc1</seealso>
    let ``emmo/1.0.0_rc1`` = Prefixed_Name(w3id, "emmo/1.0.0-rc1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/contributors#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/contributors#">https://w3id.org/emmo/contributors#</seealso>
    let ``emmo/contributors#`` =
        Prefixed_Name(w3id, "emmo/contributors#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/chemistry#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/chemistry#">https://w3id.org/emmo/disciplines/chemistry#</seealso>
    let ``emmo/disciplines/chemistry#`` =
        Prefixed_Name(w3id, "emmo/disciplines/chemistry#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/computerscience#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/computerscience#">https://w3id.org/emmo/disciplines/computerscience#</seealso>
    let ``emmo/disciplines/computerscience#`` =
        Prefixed_Name(w3id, "emmo/disciplines/computerscience#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/geometrical#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/geometrical#">https://w3id.org/emmo/disciplines/geometrical#</seealso>
    let ``emmo/disciplines/geometrical#`` =
        Prefixed_Name(w3id, "emmo/disciplines/geometrical#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/isq#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/isq#">https://w3id.org/emmo/disciplines/isq#</seealso>
    let ``emmo/disciplines/isq#`` =
        Prefixed_Name(w3id, "emmo/disciplines/isq#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/manufacturing#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/manufacturing#">https://w3id.org/emmo/disciplines/manufacturing#</seealso>
    let ``emmo/disciplines/manufacturing#`` =
        Prefixed_Name(w3id, "emmo/disciplines/manufacturing#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/materials#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/materials#">https://w3id.org/emmo/disciplines/materials#</seealso>
    let ``emmo/disciplines/materials#`` =
        Prefixed_Name(w3id, "emmo/disciplines/materials#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/math#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/math#">https://w3id.org/emmo/disciplines/math#</seealso>
    let ``emmo/disciplines/math#`` =
        Prefixed_Name(w3id, "emmo/disciplines/math#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/metrology#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/metrology#">https://w3id.org/emmo/disciplines/metrology#</seealso>
    let ``emmo/disciplines/metrology#`` =
        Prefixed_Name(w3id, "emmo/disciplines/metrology#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/models#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/models#">https://w3id.org/emmo/disciplines/models#</seealso>
    let ``emmo/disciplines/models#`` =
        Prefixed_Name(w3id, "emmo/disciplines/models#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/perceptual#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/perceptual#">https://w3id.org/emmo/disciplines/perceptual#</seealso>
    let ``emmo/disciplines/perceptual#`` =
        Prefixed_Name(w3id, "emmo/disciplines/perceptual#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/periodictable#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/periodictable#">https://w3id.org/emmo/disciplines/periodictable#</seealso>
    let ``emmo/disciplines/periodictable#`` =
        Prefixed_Name(w3id, "emmo/disciplines/periodictable#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/units/coherentsiunits#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/units/coherentsiunits#">https://w3id.org/emmo/disciplines/units/coherentsiunits#</seealso>
    let ``emmo/disciplines/units/coherentsiunits#`` =
        Prefixed_Name(w3id, "emmo/disciplines/units/coherentsiunits#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/units/noncoherentsiunits#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/units/noncoherentsiunits#">https://w3id.org/emmo/disciplines/units/noncoherentsiunits#</seealso>
    let ``emmo/disciplines/units/noncoherentsiunits#`` =
        Prefixed_Name(w3id, "emmo/disciplines/units/noncoherentsiunits#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/units/prefixedsiunits#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/units/prefixedsiunits#">https://w3id.org/emmo/disciplines/units/prefixedsiunits#</seealso>
    let ``emmo/disciplines/units/prefixedsiunits#`` =
        Prefixed_Name(w3id, "emmo/disciplines/units/prefixedsiunits#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/units/siacceptedunits#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/units/siacceptedunits#">https://w3id.org/emmo/disciplines/units/siacceptedunits#</seealso>
    let ``emmo/disciplines/units/siacceptedunits#`` =
        Prefixed_Name(w3id, "emmo/disciplines/units/siacceptedunits#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/units/sidimensionalunits#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/units/sidimensionalunits#">https://w3id.org/emmo/disciplines/units/sidimensionalunits#</seealso>
    let ``emmo/disciplines/units/sidimensionalunits#`` =
        Prefixed_Name(w3id, "emmo/disciplines/units/sidimensionalunits#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/disciplines/units/siunits#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/disciplines/units/siunits#">https://w3id.org/emmo/disciplines/units/siunits#</seealso>
    let ``emmo/disciplines/units/siunits#`` =
        Prefixed_Name(w3id, "emmo/disciplines/units/siunits#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/battery/battery</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/battery/battery">https://w3id.org/emmo/domain/battery/battery</seealso>
    let ``emmo/domain/battery/battery`` =
        Prefixed_Name(w3id, "emmo/domain/battery/battery") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/battery/batteryquantities</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/battery/batteryquantities">https://w3id.org/emmo/domain/battery/batteryquantities</seealso>
    let ``emmo/domain/battery/batteryquantities`` =
        Prefixed_Name(w3id, "emmo/domain/battery/batteryquantities") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Contacts:
    /// 													Gerhard Goldbeck
    /// 													Goldbeck Consulting Ltd (UK)
    /// 													email: gerhard@goldbeck-consulting.com"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo">https://w3id.org/emmo/domain/characterisation-methodology/chameo</seealso>
    let ``emmo/domain/characterisation_methodology/chameo`` =
        Prefixed_Name(w3id, "emmo/domain/characterisation-methodology/chameo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo/hasDateOfCalibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasDateOfCalibration"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo/hasDateOfCalibration">https://w3id.org/emmo/domain/characterisation-methodology/chameo/hasDateOfCalibration</seealso>
    let ``emmo/domain/characterisation_methodology/chameo/hasDateOfCalibration`` =
        Prefixed_Name(w3id, "emmo/domain/characterisation-methodology/chameo/hasDateOfCalibration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/electrochemistry/electrochemicalquantities</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/electrochemistry/electrochemicalquantities">https://w3id.org/emmo/domain/electrochemistry/electrochemicalquantities</seealso>
    let ``emmo/domain/electrochemistry/electrochemicalquantities`` =
        Prefixed_Name(w3id, "emmo/domain/electrochemistry/electrochemicalquantities") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/electrochemistry/electrochemistry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/electrochemistry/electrochemistry">https://w3id.org/emmo/domain/electrochemistry/electrochemistry</seealso>
    let ``emmo/domain/electrochemistry/electrochemistry`` =
        Prefixed_Name(w3id, "emmo/domain/electrochemistry/electrochemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/electrochemistry/electrochemistry#Anode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/electrochemistry/electrochemistry#Anode">https://w3id.org/emmo/domain/electrochemistry/electrochemistry#Anode</seealso>
    let ``emmo/domain/electrochemistry/electrochemistry#Anode`` =
        Prefixed_Name(w3id, "emmo/domain/electrochemistry/electrochemistry#Anode") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/electrochemistry/electrochemistry#Cathode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/electrochemistry/electrochemistry#Cathode">https://w3id.org/emmo/domain/electrochemistry/electrochemistry#Cathode</seealso>
    let ``emmo/domain/electrochemistry/electrochemistry#Cathode`` =
        Prefixed_Name(w3id, "emmo/domain/electrochemistry/electrochemistry#Cathode") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/electrochemistry/electrochemistry#FormFactor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/electrochemistry/electrochemistry#FormFactor">https://w3id.org/emmo/domain/electrochemistry/electrochemistry#FormFactor</seealso>
    let ``emmo/domain/electrochemistry/electrochemistry#FormFactor`` =
        Prefixed_Name(w3id, "emmo/domain/electrochemistry/electrochemistry#FormFactor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/electrochemistry/electrochemistry#OutputCable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/electrochemistry/electrochemistry#OutputCable">https://w3id.org/emmo/domain/electrochemistry/electrochemistry#OutputCable</seealso>
    let ``emmo/domain/electrochemistry/electrochemistry#OutputCable`` =
        Prefixed_Name(w3id, "emmo/domain/electrochemistry/electrochemistry#OutputCable") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/electrochemistry/electrochemistry#electrochemistry_1586ef26_6d30_49e3_ae32_b4c9fc181941</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/electrochemistry/electrochemistry#electrochemistry_1586ef26_6d30_49e3_ae32_b4c9fc181941">https://w3id.org/emmo/domain/electrochemistry/electrochemistry#electrochemistry_1586ef26_6d30_49e3_ae32_b4c9fc181941</seealso>
    let ``emmo/domain/electrochemistry/electrochemistry#electrochemistry_1586ef26_6d30_49e3_ae32_b4c9fc181941`` =
        Prefixed_Name(w3id, "emmo/domain/electrochemistry/electrochemistry#electrochemistry_1586ef26_6d30_49e3_ae32_b4c9fc181941") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/electrochemistry/electrochemistry#electrochemistry_35c650ab_3b23_4938_b312_1b0dede2e6d5</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/electrochemistry/electrochemistry#electrochemistry_35c650ab_3b23_4938_b312_1b0dede2e6d5">https://w3id.org/emmo/domain/electrochemistry/electrochemistry#electrochemistry_35c650ab_3b23_4938_b312_1b0dede2e6d5</seealso>
    let ``emmo/domain/electrochemistry/electrochemistry#electrochemistry_35c650ab_3b23_4938_b312_1b0dede2e6d5`` =
        Prefixed_Name(w3id, "emmo/domain/electrochemistry/electrochemistry#electrochemistry_35c650ab_3b23_4938_b312_1b0dede2e6d5") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/electrochemistry/electrochemistry#electrochemistry_76df6e7b_fc3b_4a1f_98b1_0ca9c0539e4c</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/electrochemistry/electrochemistry#electrochemistry_76df6e7b_fc3b_4a1f_98b1_0ca9c0539e4c">https://w3id.org/emmo/domain/electrochemistry/electrochemistry#electrochemistry_76df6e7b_fc3b_4a1f_98b1_0ca9c0539e4c</seealso>
    let ``emmo/domain/electrochemistry/electrochemistry#electrochemistry_76df6e7b_fc3b_4a1f_98b1_0ca9c0539e4c`` =
        Prefixed_Name(w3id, "emmo/domain/electrochemistry/electrochemistry#electrochemistry_76df6e7b_fc3b_4a1f_98b1_0ca9c0539e4c") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/electrochemistry/electrochemistry#electrochemistry_b6319c74_d2ce_48c0_a75a_63156776b302</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/electrochemistry/electrochemistry#electrochemistry_b6319c74_d2ce_48c0_a75a_63156776b302">https://w3id.org/emmo/domain/electrochemistry/electrochemistry#electrochemistry_b6319c74_d2ce_48c0_a75a_63156776b302</seealso>
    let ``emmo/domain/electrochemistry/electrochemistry#electrochemistry_b6319c74_d2ce_48c0_a75a_63156776b302`` =
        Prefixed_Name(w3id, "emmo/domain/electrochemistry/electrochemistry#electrochemistry_b6319c74_d2ce_48c0_a75a_63156776b302") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/mereocausality#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/mereocausality#">https://w3id.org/emmo/mereocausality#</seealso>
    let ``emmo/mereocausality#`` =
        Prefixed_Name(w3id, "emmo/mereocausality#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/multiperspective/dataset#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/multiperspective/dataset#">https://w3id.org/emmo/multiperspective/dataset#</seealso>
    let ``emmo/multiperspective/dataset#`` =
        Prefixed_Name(w3id, "emmo/multiperspective/dataset#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/multiperspective/information#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/multiperspective/information#">https://w3id.org/emmo/multiperspective/information#</seealso>
    let ``emmo/multiperspective/information#`` =
        Prefixed_Name(w3id, "emmo/multiperspective/information#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/multiperspective/persholistic#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/multiperspective/persholistic#">https://w3id.org/emmo/multiperspective/persholistic#</seealso>
    let ``emmo/multiperspective/persholistic#`` =
        Prefixed_Name(w3id, "emmo/multiperspective/persholistic#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/multiperspective/properties#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/multiperspective/properties#">https://w3id.org/emmo/multiperspective/properties#</seealso>
    let ``emmo/multiperspective/properties#`` =
        Prefixed_Name(w3id, "emmo/multiperspective/properties#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/multiperspective/symbolic#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/multiperspective/symbolic#">https://w3id.org/emmo/multiperspective/symbolic#</seealso>
    let ``emmo/multiperspective/symbolic#`` =
        Prefixed_Name(w3id, "emmo/multiperspective/symbolic#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/multiperspective/workflow#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/multiperspective/workflow#">https://w3id.org/emmo/multiperspective/workflow#</seealso>
    let ``emmo/multiperspective/workflow#`` =
        Prefixed_Name(w3id, "emmo/multiperspective/workflow#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/perspectives/data#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/perspectives/data#">https://w3id.org/emmo/perspectives/data#</seealso>
    let ``emmo/perspectives/data#`` =
        Prefixed_Name(w3id, "emmo/perspectives/data#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/perspectives/holistic#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/perspectives/holistic#">https://w3id.org/emmo/perspectives/holistic#</seealso>
    let ``emmo/perspectives/holistic#`` =
        Prefixed_Name(w3id, "emmo/perspectives/holistic#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/perspectives/persistence#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/perspectives/persistence#">https://w3id.org/emmo/perspectives/persistence#</seealso>
    let ``emmo/perspectives/persistence#`` =
        Prefixed_Name(w3id, "emmo/perspectives/persistence#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/perspectives/physicalistic#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/perspectives/physicalistic#">https://w3id.org/emmo/perspectives/physicalistic#</seealso>
    let ``emmo/perspectives/physicalistic#`` =
        Prefixed_Name(w3id, "emmo/perspectives/physicalistic#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/perspectives/reductionistic#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/perspectives/reductionistic#">https://w3id.org/emmo/perspectives/reductionistic#</seealso>
    let ``emmo/perspectives/reductionistic#`` =
        Prefixed_Name(w3id, "emmo/perspectives/reductionistic#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/perspectives/semiotics#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/perspectives/semiotics#">https://w3id.org/emmo/perspectives/semiotics#</seealso>
    let ``emmo/perspectives/semiotics#`` =
        Prefixed_Name(w3id, "emmo/perspectives/semiotics#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/perspectives/standardmodel#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/perspectives/standardmodel#">https://w3id.org/emmo/perspectives/standardmodel#</seealso>
    let ``emmo/perspectives/standardmodel#`` =
        Prefixed_Name(w3id, "emmo/perspectives/standardmodel#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"A simple ontology which implements the Parameter Usage Vocabulary semantic model, as described at https://github.com/nvs-vocabs/P01"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parameter Usage Vocabulary ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv">https://w3id.org/env/puv</seealso>
    let ``env/puv`` = Prefixed_Name(w3id, "env/puv") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ep-plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"PROV extension for linking Plans and parts of plans to their respective executions. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ep-plan">https://w3id.org/ep-plan</seealso>
    let ep_plan = Prefixed_Name(w3id, "ep-plan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:express</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/express">https://w3id.org/express</seealso>
    let express = Prefixed_Name(w3id, "express") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>"- Version 0.0.2:
    /// * updated definitions of certain properties
    /// * adjusted typos
    /// * added datatype properties for: Rhino, Revit, IFC, STEP APs, IGES
    /// * added object properties for: 3DMO, ifcOWL, geojson-ld
    /// * completed ontology metadata
    /// - Version 0.0.1: initial version"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fog">https://w3id.org/fog</seealso>
    let fog = Prefixed_Name(w3id, "fog") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology">https://w3id.org/foodwaste/ontology</seealso>
    let ``foodwaste/ontology`` =
        Prefixed_Name(w3id, "foodwaste/ontology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:foodwaste/ontology/v1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/foodwaste/ontology/v1">https://w3id.org/foodwaste/ontology/v1</seealso>
    let ``foodwaste/ontology/v1`` =
        Prefixed_Name(w3id, "foodwaste/ontology/v1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:fossr/bdi/ontology/0.4/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/fossr/bdi/ontology/0.4/">https://w3id.org/fossr/bdi/ontology/0.4/</seealso>
    let ``fossr/bdi/ontology/0.4/`` =
        Prefixed_Name(w3id, "fossr/bdi/ontology/0.4/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/img/fno_favicon.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/img/fno_favicon.png">https://w3id.org/function/img/fno_favicon.png</seealso>
    let ``function/img/fno_favicon.png`` =
        Prefixed_Name(w3id, "function/img/fno_favicon.png") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"The Function Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology">https://w3id.org/function/ontology</seealso>
    let ``function/ontology`` = Prefixed_Name(w3id, "function/ontology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/ontology/0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/ontology/0.1">https://w3id.org/function/ontology/0.1</seealso>
    let ``function/ontology/0.1`` =
        Prefixed_Name(w3id, "function/ontology/0.1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/ontology/0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/ontology/0.2">https://w3id.org/function/ontology/0.2</seealso>
    let ``function/ontology/0.2`` =
        Prefixed_Name(w3id, "function/ontology/0.2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/ontology/0.3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/ontology/0.3">https://w3id.org/function/ontology/0.3</seealso>
    let ``function/ontology/0.3`` =
        Prefixed_Name(w3id, "function/ontology/0.3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/ontology/0.4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/ontology/0.4">https://w3id.org/function/ontology/0.4</seealso>
    let ``function/ontology/0.4`` =
        Prefixed_Name(w3id, "function/ontology/0.4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/ontology/0.4.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/ontology/0.4.1">https://w3id.org/function/ontology/0.4.1</seealso>
    let ``function/ontology/0.4.1`` =
        Prefixed_Name(w3id, "function/ontology/0.4.1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/ontology/0.5.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/ontology/0.5.0">https://w3id.org/function/ontology/0.5.0</seealso>
    let ``function/ontology/0.5.0`` =
        Prefixed_Name(w3id, "function/ontology/0.5.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/ontology/0.5.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/ontology/0.5.1">https://w3id.org/function/ontology/0.5.1</seealso>
    let ``function/ontology/0.5.1`` =
        Prefixed_Name(w3id, "function/ontology/0.5.1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/ontology/0.6.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/ontology/0.6.0">https://w3id.org/function/ontology/0.6.0</seealso>
    let ``function/ontology/0.6.0`` =
        Prefixed_Name(w3id, "function/ontology/0.6.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/ontology/1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/ontology/1.0.0">https://w3id.org/function/ontology/1.0.0</seealso>
    let ``function/ontology/1.0.0`` =
        Prefixed_Name(w3id, "function/ontology/1.0.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec">https://w3id.org/function/spec</seealso>
    let ``function/spec`` = Prefixed_Name(w3id, "function/spec") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fn-algorithm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fn-algorithm">https://w3id.org/function/spec/#fn-algorithm</seealso>
    let ``function/spec/#fn_algorithm`` =
        Prefixed_Name(w3id, "function/spec/#fn-algorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fn-execution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fn-execution">https://w3id.org/function/spec/#fn-execution</seealso>
    let ``function/spec/#fn_execution`` =
        Prefixed_Name(w3id, "function/spec/#fn-execution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fn-function</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fn-function">https://w3id.org/function/spec/#fn-function</seealso>
    let ``function/spec/#fn_function`` =
        Prefixed_Name(w3id, "function/spec/#fn-function") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fn-output</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fn-output">https://w3id.org/function/spec/#fn-output</seealso>
    let ``function/spec/#fn_output`` =
        Prefixed_Name(w3id, "function/spec/#fn-output") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fn-parameter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fn-parameter">https://w3id.org/function/spec/#fn-parameter</seealso>
    let ``function/spec/#fn_parameter`` =
        Prefixed_Name(w3id, "function/spec/#fn-parameter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fn-problem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fn-problem">https://w3id.org/function/spec/#fn-problem</seealso>
    let ``function/spec/#fn_problem`` =
        Prefixed_Name(w3id, "function/spec/#fn-problem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fno-Mapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fno-Mapping">https://w3id.org/function/spec/#fno-Mapping</seealso>
    let ``function/spec/#fno_Mapping`` =
        Prefixed_Name(w3id, "function/spec/#fno-Mapping") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fno-MethodMapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fno-MethodMapping">https://w3id.org/function/spec/#fno-MethodMapping</seealso>
    let ``function/spec/#fno_MethodMapping`` =
        Prefixed_Name(w3id, "function/spec/#fno-MethodMapping") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fno-ParameterMapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fno-ParameterMapping">https://w3id.org/function/spec/#fno-ParameterMapping</seealso>
    let ``function/spec/#fno_ParameterMapping`` =
        Prefixed_Name(w3id, "function/spec/#fno-ParameterMapping") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fno-ReturnMapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fno-ReturnMapping">https://w3id.org/function/spec/#fno-ReturnMapping</seealso>
    let ``function/spec/#fno_ReturnMapping`` =
        Prefixed_Name(w3id, "function/spec/#fno-ReturnMapping") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fno-implementation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fno-implementation">https://w3id.org/function/spec/#fno-implementation</seealso>
    let ``function/spec/#fno_implementation`` =
        Prefixed_Name(w3id, "function/spec/#fno-implementation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/#fno-uses</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/#fno-uses">https://w3id.org/function/spec/#fno-uses</seealso>
    let ``function/spec/#fno_uses`` =
        Prefixed_Name(w3id, "function/spec/#fno-uses") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/spec/resources/images/fno-full.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/spec/resources/images/fno-full.png">https://w3id.org/function/spec/resources/images/fno-full.png</seealso>
    let ``function/spec/resources/images/fno_full.png`` =
        Prefixed_Name(w3id, "function/spec/resources/images/fno-full.png") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/vocabulary/composition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition">https://w3id.org/function/vocabulary/composition</seealso>
    let ``function/vocabulary/composition`` =
        Prefixed_Name(w3id, "function/vocabulary/composition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/vocabulary/composition/0.1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition/0.1.0">https://w3id.org/function/vocabulary/composition/0.1.0</seealso>
    let ``function/vocabulary/composition/0.1.0`` =
        Prefixed_Name(w3id, "function/vocabulary/composition/0.1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/vocabulary/implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>"- Version 0.1.1: updated metadata
    /// - Version 0.1.0: creation."</para>
    /// labels<para>"The Function Ontology - Implementation vocabulary"</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation">https://w3id.org/function/vocabulary/implementation</seealso>
    let ``function/vocabulary/implementation`` =
        Prefixed_Name(w3id, "function/vocabulary/implementation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/vocabulary/implementation/0.1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation/0.1.0">https://w3id.org/function/vocabulary/implementation/0.1.0</seealso>
    let ``function/vocabulary/implementation/0.1.0`` =
        Prefixed_Name(w3id, "function/vocabulary/implementation/0.1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/vocabulary/implementation/0.1.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/implementation/0.1.1">https://w3id.org/function/vocabulary/implementation/0.1.1</seealso>
    let ``function/vocabulary/implementation/0.1.1`` =
        Prefixed_Name(w3id, "function/vocabulary/implementation/0.1.1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/vocabulary/mapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping">https://w3id.org/function/vocabulary/mapping</seealso>
    let ``function/vocabulary/mapping`` =
        Prefixed_Name(w3id, "function/vocabulary/mapping") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/vocabulary/mapping/0.2.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping/0.2.0">https://w3id.org/function/vocabulary/mapping/0.2.0</seealso>
    let ``function/vocabulary/mapping/0.2.0`` =
        Prefixed_Name(w3id, "function/vocabulary/mapping/0.2.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:function/vocabulary/mapping/0.2.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/mapping/0.2.1">https://w3id.org/function/vocabulary/mapping/0.2.1</seealso>
    let ``function/vocabulary/mapping/0.2.1`` =
        Prefixed_Name(w3id, "function/vocabulary/mapping/0.2.1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:gom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>"- Version 0.0.1: initial version"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/gom">https://w3id.org/gom</seealso>
    let gom = Prefixed_Name(w3id, "gom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:hpont</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/hpont">https://w3id.org/hpont</seealso>
    let hpont = Prefixed_Name(w3id, "hpont") |> PrefixedName

    /// <summary>
    ///   <para>w3id:https//w3id.org/iddo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/https//w3id.org/iddo">https://w3id.org/https//w3id.org/iddo</seealso>
    let ``https//w3id.org/iddo`` =
        Prefixed_Name(w3id, "https//w3id.org/iddo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:iadopt/ont</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"I-ADOPT Framework ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont">https://w3id.org/iadopt/ont</seealso>
    let ``iadopt/ont`` = Prefixed_Name(w3id, "iadopt/ont") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ibp/CTRLont</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>"CTRLont specifies concepts and relationships of control actors on a high level."</para>
    /// labels<para>"CTRLont"</para></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont">https://w3id.org/ibp/CTRLont</seealso>
    let ``ibp/CTRLont`` = Prefixed_Name(w3id, "ibp/CTRLont") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ibp/CTRLont-0.0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont-0.0.1">https://w3id.org/ibp/CTRLont-0.0.1</seealso>
    let ``ibp/CTRLont_0.0.1`` = Prefixed_Name(w3id, "ibp/CTRLont-0.0.1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ibp/CTRLont-0.2.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ibp/CTRLont-0.2.0">https://w3id.org/ibp/CTRLont-0.2.0</seealso>
    let ``ibp/CTRLont_0.2.0`` = Prefixed_Name(w3id, "ibp/CTRLont-0.2.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:iddo</para>
    /// </summary>
    /// <remarks>
    ///   <para>schemas:Organization</para>
    ///   <para>schemas:Person</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"The interconnected data dictionary ontology maps the data model of the ISO 23386 for the describing, creating, and maintenance of properties in interconnected data dictionaries.
    ///
    /// The namespace for IDDO terms is [https://w3id.org/iddo](https://w3id.org/iddo)
    ///
    /// The preferred prefix for the IDDO namespace is `iddo`.
    ///
    /// ## Ontology Overview
    /// ![IDDO Ontology](Ontology_Overview.png "Ontology")
    ///
    /// ## Assigning an IDDO Property to a Feature of Interest
    /// ![Property_Assignment](Property_Assignment.png "Property_Assignment")
    ///
    /// ## Relation between DCAT vocabulary and the IDDO ontology
    /// ![DataCatalog_Overview](DataCatalog_Overview.png "DataCatalog_Overview")
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The Interconnected Data Dictionary Ontology (IDDO)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/iddo">https://w3id.org/iddo</seealso>
    let iddo = Prefixed_Name(w3id, "iddo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This ontology defines classes and properties for describing participants, infrastructure, data and services of the International Data Spaces (formerly known as Industrial Data Space)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IDS Information Model"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core">https://w3id.org/idsa/core</seealso>
    let ``idsa/core`` = Prefixed_Name(w3id, "idsa/core") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of contraints concerning the right operand of a relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Constraint"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/Constraint">https://w3id.org/idsa/metamodel/Constraint</seealso>
    let ``idsa/metamodel/Constraint`` =
        Prefixed_Name(w3id, "idsa/metamodel/Constraint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/ModelView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Tailored view defined upon and generated from an ontology for a particular purpose."</para>
    /// labels<para>"Model view"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/ModelView">https://w3id.org/idsa/metamodel/ModelView</seealso>
    let ``idsa/metamodel/ModelView`` =
        Prefixed_Name(w3id, "idsa/metamodel/ModelView") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/NotEmpty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/NotEmpty">https://w3id.org/idsa/metamodel/NotEmpty</seealso>
    let ``idsa/metamodel/NotEmpty`` =
        Prefixed_Name(w3id, "idsa/metamodel/NotEmpty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/NotNull</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/NotNull">https://w3id.org/idsa/metamodel/NotNull</seealso>
    let ``idsa/metamodel/NotNull`` =
        Prefixed_Name(w3id, "idsa/metamodel/NotNull") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/OneToMany</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/OneToMany">https://w3id.org/idsa/metamodel/OneToMany</seealso>
    let ``idsa/metamodel/OneToMany`` =
        Prefixed_Name(w3id, "idsa/metamodel/OneToMany") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/Package</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract grouping of concepts relevant for a particular model view."</para>
    /// labels<para>"Package"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/Package">https://w3id.org/idsa/metamodel/Package</seealso>
    let ``idsa/metamodel/Package`` =
        Prefixed_Name(w3id, "idsa/metamodel/Package") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/PropertyValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of all property validations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PropertyValidation"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/PropertyValidation">https://w3id.org/idsa/metamodel/PropertyValidation</seealso>
    let ``idsa/metamodel/PropertyValidation`` =
        Prefixed_Name(w3id, "idsa/metamodel/PropertyValidation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/RelationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of relation types, i.e., cardinality definitions of left and right operands of a relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RelationType"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/RelationType">https://w3id.org/idsa/metamodel/RelationType</seealso>
    let ``idsa/metamodel/RelationType`` =
        Prefixed_Name(w3id, "idsa/metamodel/RelationType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Abstract concept marker, its instantiation is delegated to extending constructs (sub-classes or sub-properties)."</para>
    /// labels<para>"abstract"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/abstract">https://w3id.org/idsa/metamodel/abstract</seealso>
    let ``idsa/metamodel/abstract`` =
        Prefixed_Name(w3id, "idsa/metamodel/abstract") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/competencyQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Single 'competency question' the modeling construct is intended to address."</para>
    /// labels<para>"competency question"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/competencyQuestion">https://w3id.org/idsa/metamodel/competencyQuestion</seealso>
    let ``idsa/metamodel/competencyQuestion`` =
        Prefixed_Name(w3id, "idsa/metamodel/competencyQuestion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the kind of constraint for a PropertyValidation."</para>
    /// labels<para>"constraint"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/constraint">https://w3id.org/idsa/metamodel/constraint</seealso>
    let ``idsa/metamodel/constraint`` =
        Prefixed_Name(w3id, "idsa/metamodel/constraint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Literal in-line example of instantiating given modeling construct."</para>
    /// labels<para>"example"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/example">https://w3id.org/idsa/metamodel/example</seealso>
    let ``idsa/metamodel/example`` =
        Prefixed_Name(w3id, "idsa/metamodel/example") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/focusClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates a class as a "central" class that should be visualized in a particular way."</para>
    /// labels<para>"focusClass"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/focusClass">https://w3id.org/idsa/metamodel/focusClass</seealso>
    let ``idsa/metamodel/focusClass`` =
        Prefixed_Name(w3id, "idsa/metamodel/focusClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/forProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/forProperty">https://w3id.org/idsa/metamodel/forProperty</seealso>
    let ``idsa/metamodel/forProperty`` =
        Prefixed_Name(w3id, "idsa/metamodel/forProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Explicit statement of pending issue related to the resource."</para>
    /// labels<para>"issue"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/issue">https://w3id.org/idsa/metamodel/issue</seealso>
    let ``idsa/metamodel/issue`` =
        Prefixed_Name(w3id, "idsa/metamodel/issue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/package</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Assigns membership of a resource to a package."</para>
    /// labels<para>"package"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/package">https://w3id.org/idsa/metamodel/package</seealso>
    let ``idsa/metamodel/package`` =
        Prefixed_Name(w3id, "idsa/metamodel/package") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/rationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Literal description of motivations, requirements and design decisions underlying the modeling of a construct."</para>
    /// labels<para>"rationale"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/rationale">https://w3id.org/idsa/metamodel/rationale</seealso>
    let ``idsa/metamodel/rationale`` =
        Prefixed_Name(w3id, "idsa/metamodel/rationale") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/referenceByUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"States that a reference to a class should not be implemented by a local in-memory reference but as a URL addressing the remote instance."</para>
    /// labels<para>"Reference by URL"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/referenceByUri">https://w3id.org/idsa/metamodel/referenceByUri</seealso>
    let ``idsa/metamodel/referenceByUri`` =
        Prefixed_Name(w3id, "idsa/metamodel/referenceByUri") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/relationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the relation type for a PropertyValidation."</para>
    /// labels<para>"relationType"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/relationType">https://w3id.org/idsa/metamodel/relationType</seealso>
    let ``idsa/metamodel/relationType`` =
        Prefixed_Name(w3id, "idsa/metamodel/relationType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Literal in-line note recommending a particular usage of given modeling construct."</para>
    /// labels<para>"usage"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/usage">https://w3id.org/idsa/metamodel/usage</seealso>
    let ``idsa/metamodel/usage`` =
        Prefixed_Name(w3id, "idsa/metamodel/usage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Annotates a class with a validation concerning a specific property."</para>
    /// labels<para>"validation"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/validation">https://w3id.org/idsa/metamodel/validation</seealso>
    let ``idsa/metamodel/validation`` =
        Prefixed_Name(w3id, "idsa/metamodel/validation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/view</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Model view associated with given resource."</para>
    /// labels<para>"view"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/view">https://w3id.org/idsa/metamodel/view</seealso>
    let ``idsa/metamodel/view`` =
        Prefixed_Name(w3id, "idsa/metamodel/view") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/metamodel/viewOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Resource associated with given model view."</para>
    /// labels<para>"view"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/metamodel/viewOf">https://w3id.org/idsa/metamodel/viewOf</seealso>
    let ``idsa/metamodel/viewOf`` =
        Prefixed_Name(w3id, "idsa/metamodel/viewOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ifc/IFC4_ADD1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Ontology automatically generated from the EXPRESS schema 'IFC4_ADD1' using the 'IFC-to-RDF' converter developed by Pieter Pauwels (pipauwel.pauwels@ugent.be), based on the earlier versions from Jyrki Oraskari (jyrki.oraskari@aalto.fi) and Davy Van Deursen (davy.vandeursen@ugent.be)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ifc/IFC4_ADD1">https://w3id.org/ifc/IFC4_ADD1</seealso>
    let ``ifc/IFC4_ADD1`` = Prefixed_Name(w3id, "ifc/IFC4_ADD1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy">https://w3id.org/isCharacterisedBy</seealso>
    let isCharacterisedBy = Prefixed_Name(w3id, "isCharacterisedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The Ishikawa ontology aims to provide a data and view model to manage data encoded in Ishikawa diagrams which are also known as fishbone or cause and effect diagram (CED).
    /// Ishikawa diagrams result from (iterative) workshops. Thus, the ontology includes the basic modelling of workshops to create Ishikawa diagrams."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology">https://w3id.org/ishikawa-diagram-ontology</seealso>
    let ishikawa_diagram_ontology =
        Prefixed_Name(w3id, "ishikawa-diagram-ontology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ishikawa-diagram-ontology/0.1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ishikawa-diagram-ontology/0.1.0">https://w3id.org/ishikawa-diagram-ontology/0.1.0</seealso>
    let ``ishikawa_diagram_ontology/0.1.0`` =
        Prefixed_Name(w3id, "ishikawa-diagram-ontology/0.1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:isoprops</para>
    /// </summary>
    /// <remarks>
    ///   <para>schemas:Person</para>
    ///   <para>schemas:Organization</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"The ISO Property (ISOProps) ontology maps the data model of the ISO 23386 for the describing, creating, and maintenance of properties in interconnected data dictionaries.
    ///
    /// The namespace for ISOProps terms is [https://w3id.org/isoprops](https://w3id.org/isoprops)
    ///
    /// The preferred prefix for the ISOProps namespace is `isoprops`.
    ///
    /// ## Ontology Overview
    /// ![IDDO Ontology](Ontology_Overview.png "Ontology")
    ///
    /// ## Assigning an ISOProps Property to a Feature of Interest
    /// ![Property_Assignment](Property_Assignment.png "Property_Assignment")
    ///
    /// ## Relation between DCAT vocabulary and the ISOProps ontology
    /// ![DataCatalog_Overview](DataCatalog_Overview.png "DataCatalog_Overview")
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ISO 23386 Property Ontology (ISOProps)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isoprops">https://w3id.org/isoprops</seealso>
    let isoprops = Prefixed_Name(w3id, "isoprops") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/controlled-vocabulary/licences/A31_CCBYSA40</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/italia/controlled-vocabulary/licences/A31_CCBYSA40">https://w3id.org/italia/controlled-vocabulary/licences/A31_CCBYSA40</seealso>
    let ``italia/controlled_vocabulary/licences/A31_CCBYSA40`` =
        Prefixed_Name(w3id, "italia/controlled-vocabulary/licences/A31_CCBYSA40") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/data/organization/support-unit/cnr-Z6HZEH/stlab</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/italia/data/organization/support-unit/cnr-Z6HZEH/stlab">https://w3id.org/italia/data/organization/support-unit/cnr-Z6HZEH/stlab</seealso>
    let ``italia/data/organization/support_unit/cnr_Z6HZEH/stlab`` =
        Prefixed_Name(w3id, "italia/data/organization/support-unit/cnr-Z6HZEH/stlab") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/Address">https://w3id.org/italia/onto/CLV/Address</seealso>
    let ``italia/onto/CLV/Address`` =
        Prefixed_Name(w3id, "italia/onto/CLV/Address") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/AdministrativeUnitComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/AdministrativeUnitComponent">https://w3id.org/italia/onto/CLV/AdministrativeUnitComponent</seealso>
    let ``italia/onto/CLV/AdministrativeUnitComponent`` =
        Prefixed_Name(w3id, "italia/onto/CLV/AdministrativeUnitComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/City">https://w3id.org/italia/onto/CLV/City</seealso>
    let ``italia/onto/CLV/City`` =
        Prefixed_Name(w3id, "italia/onto/CLV/City") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/District</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/District">https://w3id.org/italia/onto/CLV/District</seealso>
    let ``italia/onto/CLV/District`` =
        Prefixed_Name(w3id, "italia/onto/CLV/District") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/Feature">https://w3id.org/italia/onto/CLV/Feature</seealso>
    let ``italia/onto/CLV/Feature`` =
        Prefixed_Name(w3id, "italia/onto/CLV/Feature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/Geometry">https://w3id.org/italia/onto/CLV/Geometry</seealso>
    let ``italia/onto/CLV/Geometry`` =
        Prefixed_Name(w3id, "italia/onto/CLV/Geometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/SpatialObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/SpatialObject">https://w3id.org/italia/onto/CLV/SpatialObject</seealso>
    let ``italia/onto/CLV/SpatialObject`` =
        Prefixed_Name(w3id, "italia/onto/CLV/SpatialObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/hasAddress">https://w3id.org/italia/onto/CLV/hasAddress</seealso>
    let ``italia/onto/CLV/hasAddress`` =
        Prefixed_Name(w3id, "italia/onto/CLV/hasAddress") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/hasAddressComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/hasAddressComponent">https://w3id.org/italia/onto/CLV/hasAddressComponent</seealso>
    let ``italia/onto/CLV/hasAddressComponent`` =
        Prefixed_Name(w3id, "italia/onto/CLV/hasAddressComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/hasGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/hasGeometry">https://w3id.org/italia/onto/CLV/hasGeometry</seealso>
    let ``italia/onto/CLV/hasGeometry`` =
        Prefixed_Name(w3id, "italia/onto/CLV/hasGeometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/CLV/isAddressComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/CLV/isAddressComponentOf">https://w3id.org/italia/onto/CLV/isAddressComponentOf</seealso>
    let ``italia/onto/CLV/isAddressComponentOf`` =
        Prefixed_Name(w3id, "italia/onto/CLV/isAddressComponentOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/MU/MeasurementUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/MU/MeasurementUnit">https://w3id.org/italia/onto/MU/MeasurementUnit</seealso>
    let ``italia/onto/MU/MeasurementUnit`` =
        Prefixed_Name(w3id, "italia/onto/MU/MeasurementUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/MU/Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/MU/Value">https://w3id.org/italia/onto/MU/Value</seealso>
    let ``italia/onto/MU/Value`` =
        Prefixed_Name(w3id, "italia/onto/MU/Value") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/RO/Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/RO/Role">https://w3id.org/italia/onto/RO/Role</seealso>
    let ``italia/onto/RO/Role`` =
        Prefixed_Name(w3id, "italia/onto/RO/Role") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/RO/TimeIndexedRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/RO/TimeIndexedRole">https://w3id.org/italia/onto/RO/TimeIndexedRole</seealso>
    let ``italia/onto/RO/TimeIndexedRole`` =
        Prefixed_Name(w3id, "italia/onto/RO/TimeIndexedRole") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/RO/hasRiT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/RO/hasRiT">https://w3id.org/italia/onto/RO/hasRiT</seealso>
    let ``italia/onto/RO/hasRiT`` =
        Prefixed_Name(w3id, "italia/onto/RO/hasRiT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/RO/isRoleInTimeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/RO/isRoleInTimeOf">https://w3id.org/italia/onto/RO/isRoleInTimeOf</seealso>
    let ``italia/onto/RO/isRoleInTimeOf`` =
        Prefixed_Name(w3id, "italia/onto/RO/isRoleInTimeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/SM/URL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/SM/URL">https://w3id.org/italia/onto/SM/URL</seealso>
    let ``italia/onto/SM/URL`` =
        Prefixed_Name(w3id, "italia/onto/SM/URL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/TI/TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/TI/TimeInterval">https://w3id.org/italia/onto/TI/TimeInterval</seealso>
    let ``italia/onto/TI/TimeInterval`` =
        Prefixed_Name(w3id, "italia/onto/TI/TimeInterval") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/TI/atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/TI/atTime">https://w3id.org/italia/onto/TI/atTime</seealso>
    let ``italia/onto/TI/atTime`` =
        Prefixed_Name(w3id, "italia/onto/TI/atTime") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/TI/date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/TI/date">https://w3id.org/italia/onto/TI/date</seealso>
    let ``italia/onto/TI/date`` =
        Prefixed_Name(w3id, "italia/onto/TI/date") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/TI/time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/TI/time">https://w3id.org/italia/onto/TI/time</seealso>
    let ``italia/onto/TI/time`` =
        Prefixed_Name(w3id, "italia/onto/TI/time") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/Activity">https://w3id.org/italia/onto/l0/Activity</seealso>
    let ``italia/onto/l0/Activity`` =
        Prefixed_Name(w3id, "italia/onto/l0/Activity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/Agent">https://w3id.org/italia/onto/l0/Agent</seealso>
    let ``italia/onto/l0/Agent`` =
        Prefixed_Name(w3id, "italia/onto/l0/Agent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/Characteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/Characteristic">https://w3id.org/italia/onto/l0/Characteristic</seealso>
    let ``italia/onto/l0/Characteristic`` =
        Prefixed_Name(w3id, "italia/onto/l0/Characteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/Collection">https://w3id.org/italia/onto/l0/Collection</seealso>
    let ``italia/onto/l0/Collection`` =
        Prefixed_Name(w3id, "italia/onto/l0/Collection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/Concept">https://w3id.org/italia/onto/l0/Concept</seealso>
    let ``italia/onto/l0/Concept`` =
        Prefixed_Name(w3id, "italia/onto/l0/Concept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/Description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/Description">https://w3id.org/italia/onto/l0/Description</seealso>
    let ``italia/onto/l0/Description`` =
        Prefixed_Name(w3id, "italia/onto/l0/Description") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/Entity">https://w3id.org/italia/onto/l0/Entity</seealso>
    let ``italia/onto/l0/Entity`` =
        Prefixed_Name(w3id, "italia/onto/l0/Entity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/EventOrSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/EventOrSituation">https://w3id.org/italia/onto/l0/EventOrSituation</seealso>
    let ``italia/onto/l0/EventOrSituation`` =
        Prefixed_Name(w3id, "italia/onto/l0/EventOrSituation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/Location">https://w3id.org/italia/onto/l0/Location</seealso>
    let ``italia/onto/l0/Location`` =
        Prefixed_Name(w3id, "italia/onto/l0/Location") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/Object">https://w3id.org/italia/onto/l0/Object</seealso>
    let ``italia/onto/l0/Object`` =
        Prefixed_Name(w3id, "italia/onto/l0/Object") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/System">https://w3id.org/italia/onto/l0/System</seealso>
    let ``italia/onto/l0/System`` =
        Prefixed_Name(w3id, "italia/onto/l0/System") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/Topic">https://w3id.org/italia/onto/l0/Topic</seealso>
    let ``italia/onto/l0/Topic`` =
        Prefixed_Name(w3id, "italia/onto/l0/Topic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/follows">https://w3id.org/italia/onto/l0/follows</seealso>
    let ``italia/onto/l0/follows`` =
        Prefixed_Name(w3id, "italia/onto/l0/follows") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/hasDescription">https://w3id.org/italia/onto/l0/hasDescription</seealso>
    let ``italia/onto/l0/hasDescription`` =
        Prefixed_Name(w3id, "italia/onto/l0/hasDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/hasMember">https://w3id.org/italia/onto/l0/hasMember</seealso>
    let ``italia/onto/l0/hasMember`` =
        Prefixed_Name(w3id, "italia/onto/l0/hasMember") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/hasTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/hasTopic">https://w3id.org/italia/onto/l0/hasTopic</seealso>
    let ``italia/onto/l0/hasTopic`` =
        Prefixed_Name(w3id, "italia/onto/l0/hasTopic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/identifier">https://w3id.org/italia/onto/l0/identifier</seealso>
    let ``italia/onto/l0/identifier`` =
        Prefixed_Name(w3id, "italia/onto/l0/identifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/isDescriptionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/isDescriptionOf">https://w3id.org/italia/onto/l0/isDescriptionOf</seealso>
    let ``italia/onto/l0/isDescriptionOf`` =
        Prefixed_Name(w3id, "italia/onto/l0/isDescriptionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/isMemberOf">https://w3id.org/italia/onto/l0/isMemberOf</seealso>
    let ``italia/onto/l0/isMemberOf`` =
        Prefixed_Name(w3id, "italia/onto/l0/isMemberOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/isTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/isTopicOf">https://w3id.org/italia/onto/l0/isTopicOf</seealso>
    let ``italia/onto/l0/isTopicOf`` =
        Prefixed_Name(w3id, "italia/onto/l0/isTopicOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/name">https://w3id.org/italia/onto/l0/name</seealso>
    let ``italia/onto/l0/name`` =
        Prefixed_Name(w3id, "italia/onto/l0/name") |> PrefixedName

    /// <summary>
    ///   <para>w3id:italia/onto/l0/precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/italia/onto/l0/precedes">https://w3id.org/italia/onto/l0/precedes</seealso>
    let ``italia/onto/l0/precedes`` =
        Prefixed_Name(w3id, "italia/onto/l0/precedes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/itsmo">https://w3id.org/itsmo</seealso>
    let itsmo = Prefixed_Name(w3id, "itsmo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ObjectRepository</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"
    /// ITSMO encapsulates a typical ITIL service management model: Services and Software are tracked as configuration items, they have defined relationships to providers and customers,
    /// and they go through building and deployment processes that rely on underlying infrastructure (as a service). The structure highlights both accountability
    /// (who is responsible and who is the customer/provider) and the dependencies among CIs in a CMDB-like environment.
    ///
    /// ITSMO works best with the [PROV](https://www.w3.org/TR/prov-o) and https://schema.org/ontologies.
    ///
    /// This vocabulary is the second edition of ITSMO  that replaces  the deprecated http://ontology.it/itsmo/v1 version
    /// 									 "</para>
    /// labels<para>"ITSMO"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#">https://w3id.org/itsmo#</seealso>
    let ``itsmo#`` = Prefixed_Name(w3id, "itsmo#") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An autonomous entity capable of performing actions in a system."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Agent">https://w3id.org/itsmo#Agent</seealso>
    let ``itsmo#Agent`` = Prefixed_Name(w3id, "itsmo#Agent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Agreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document that describes a formal understanding between two or more parties. An agreement is not legally binding, unless it forms part of a contract."</para>
    /// labels<para>"Agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Agreement">https://w3id.org/itsmo#Agreement</seealso>
    let ``itsmo#Agreement`` = Prefixed_Name(w3id, "itsmo#Agreement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tangible output from a process, such as a document, container, or a library."</para>
    /// labels<para>"Artifact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Artifact">https://w3id.org/itsmo#Artifact</seealso>
    let ``itsmo#Artifact`` = Prefixed_Name(w3id, "itsmo#Artifact") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ArtifactRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A repository where software artifacts such as code, configurations, and dependencies are stored, managed, and versioned."</para>
    /// labels<para>"ArtifactRegistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ArtifactRegistry">https://w3id.org/itsmo#ArtifactRegistry</seealso>
    let ``itsmo#ArtifactRegistry`` =
        Prefixed_Name(w3id, "itsmo#ArtifactRegistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#BinaryDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a software package distributed in compiled form"</para>
    /// labels<para>"BinaryDistribution"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#BinaryDistribution">https://w3id.org/itsmo#BinaryDistribution</seealso>
    let ``itsmo#BinaryDistribution`` =
        Prefixed_Name(w3id, "itsmo#BinaryDistribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#BuildProcessDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    ///   <para>"An entity that defines the process  for constructing or assembling something."</para>
    /// labels<para>"BuildProcessDescription"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#BuildProcessDescription">https://w3id.org/itsmo#BuildProcessDescription</seealso>
    let ``itsmo#BuildProcessDescription`` =
        Prefixed_Name(w3id, "itsmo#BuildProcessDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#BuildingConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Documentation of Any human-made structure used or intended for supporting or sheltering any use or continuous occupancy."</para>
    /// labels<para>"BuildingConfiguration"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#BuildingConfiguration">https://w3id.org/itsmo#BuildingConfiguration</seealso>
    let ``itsmo#BuildingConfiguration`` =
        Prefixed_Name(w3id, "itsmo#BuildingConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#BusinessService</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ServiceScope</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An IT service that is visible to the customer. These are normally services that support the customer’s business processes and facilitate one or more outcomes desired by the customer. All live customer-facing services, including those available for deployment, are recorded in the service catalogue along with customer-visible information about deliverables, prices, contact points, ordering and request processes. Other information such as relationships to supporting services and other CIs will also be recorded for internal use by the IT service provider. ITIL 2011 calls this "customer-facing service" while use Business Service as a more general term ( ITIL Business Service could be also a non IT )."</para>
    /// labels<para>"BusinessService"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#BusinessService">https://w3id.org/itsmo#BusinessService</seealso>
    let ``itsmo#BusinessService`` =
        Prefixed_Name(w3id, "itsmo#BusinessService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Catalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A complete list of items, typically one in alphabetical or other systematic order."</para>
    /// labels<para>"Catalogue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Catalogue">https://w3id.org/itsmo#Catalogue</seealso>
    let ``itsmo#Catalogue`` = Prefixed_Name(w3id, "itsmo#Catalogue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#ComponentInterface">https://w3id.org/itsmo#ComponentInterface</seealso>
    let ``itsmo#ComponentInterface`` =
        Prefixed_Name(w3id, "itsmo#ComponentInterface") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ComponentInterfaceScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#ComponentInterfaceScheme">https://w3id.org/itsmo#ComponentInterfaceScheme</seealso>
    let ``itsmo#ComponentInterfaceScheme`` =
        Prefixed_Name(w3id, "itsmo#ComponentInterfaceScheme") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ConfigurationBaseline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Configuration Item and  a  schema:CreativeWork that represents a portion of a snapshot of an ObjectRepository."</para>
    /// labels<para>"ConfigurationBaseline"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ConfigurationBaseline">https://w3id.org/itsmo#ConfigurationBaseline</seealso>
    let ``itsmo#ConfigurationBaseline`` =
        Prefixed_Name(w3id, "itsmo#ConfigurationBaseline") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ConfigurationItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any component or other service asset whose state  needs to be managed in order to deliver an IT service. Information about each configuration item is recorded in a record within the configuration management system and is maintained throughout its lifecycle by service asset and configuration management. Configuration items are under the control of change management. They typically include IT services, hardware, software, buildings, and formal documentation such as process documentation and service level agreements."</para>
    /// labels<para>"ConfigurationItem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ConfigurationItem">https://w3id.org/itsmo#ConfigurationItem</seealso>
    let ``itsmo#ConfigurationItem`` =
        Prefixed_Name(w3id, "itsmo#ConfigurationItem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structure or system designed to hold or encapsulate elements."</para>
    /// labels<para>"Container"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Container">https://w3id.org/itsmo#Container</seealso>
    let ``itsmo#Container`` = Prefixed_Name(w3id, "itsmo#Container") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Criticality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A process criticality."</para>
    /// labels<para>"Criticality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Criticality">https://w3id.org/itsmo#Criticality</seealso>
    let ``itsmo#Criticality`` = Prefixed_Name(w3id, "itsmo#Criticality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#CustomerAgreementPortfolio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A database or structured document used to manage service contracts or agreements between an IT service provider and its customers. Each IT service delivered to a customer should have a contract or other agreement that is listed in the customer agreement portfolio."</para>
    /// labels<para>"CustomerAgreementPortfolio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#CustomerAgreementPortfolio">https://w3id.org/itsmo#CustomerAgreementPortfolio</seealso>
    let ``itsmo#CustomerAgreementPortfolio`` =
        Prefixed_Name(w3id, "itsmo#CustomerAgreementPortfolio") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#CustomerPortfolio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A database or structured document used to record all customers of the IT service provider. The customer portfolio is the business relationship manager’s view of the customers who receive services from the IT service provider."</para>
    /// labels<para>"CustomerPortfolio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#CustomerPortfolio">https://w3id.org/itsmo#CustomerPortfolio</seealso>
    let ``itsmo#CustomerPortfolio`` =
        Prefixed_Name(w3id, "itsmo#CustomerPortfolio") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structured collection of data, typically used for analysis or reference."</para>
    /// labels<para>"Dataset"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Dataset">https://w3id.org/itsmo#Dataset</seealso>
    let ``itsmo#Dataset`` = Prefixed_Name(w3id, "itsmo#Dataset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#DeployProcessDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An entity responsible for deploying and managing a system or application."</para>
    /// labels<para>"DeployProcessDescription"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#DeployProcessDescription">https://w3id.org/itsmo#DeployProcessDescription</seealso>
    let ``itsmo#DeployProcessDescription`` =
        Prefixed_Name(w3id, "itsmo#DeployProcessDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Deployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a document that describes how to crate an instance of a service or change its status."</para>
    /// labels<para>"Deployment"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Deployment">https://w3id.org/itsmo#Deployment</seealso>
    let ``itsmo#Deployment`` = Prefixed_Name(w3id, "itsmo#Deployment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ServiceLifeCycleStage</para>
    ///   <para>"A plan or specification for constructing an object, system, or service."</para>
    /// labels<para>"Design"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Design">https://w3id.org/itsmo#Design</seealso>
    let ``itsmo#Design`` = Prefixed_Name(w3id, "itsmo#Design") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information in readable form. A document may be paper or electronic – for example, a policy statement, service level agreement, incident record or diagram of a computer room layout. Dublin Core vocabulary applies to objects of this class."</para>
    ///   <para>"Information in readable form. A document may be paper or electronic – for example, a policy statement, service level agreement, incident record or diagram of a computer room layout.
    ///
    /// Dublin Core vocabulary appy to objetc of thes class."</para>
    /// labels<para>"Documentation"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Documentation">https://w3id.org/itsmo#Documentation</seealso>
    let ``itsmo#Documentation`` =
        Prefixed_Name(w3id, "itsmo#Documentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#FeatureSheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document summarizing the key features and functionalities of a service, system, or product for stakeholders or users."</para>
    /// labels<para>"FeatureSheet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#FeatureSheet">https://w3id.org/itsmo#FeatureSheet</seealso>
    let ``itsmo#FeatureSheet`` =
        Prefixed_Name(w3id, "itsmo#FeatureSheet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#GitHubProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A project hosted on GitHub, typically containing source code and version control."</para>
    /// labels<para>"GitHubProject"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#GitHubProject">https://w3id.org/itsmo#GitHubProject</seealso>
    let ``itsmo#GitHubProject`` =
        Prefixed_Name(w3id, "itsmo#GitHubProject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#GitLabProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A project hosted on GitLab, typically containing code and version control."</para>
    /// labels<para>"GitLabProject"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#GitLabProject">https://w3id.org/itsmo#GitLabProject</seealso>
    let ``itsmo#GitLabProject`` =
        Prefixed_Name(w3id, "itsmo#GitLabProject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Hardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The documentation of the physical part of a computer."</para>
    /// labels<para>"Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Hardware">https://w3id.org/itsmo#Hardware</seealso>
    let ``itsmo#Hardware`` = Prefixed_Name(w3id, "itsmo#Hardware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#HighCriticality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#Criticality</para>
    ///   <para>"an high criticality value"</para>
    /// labels<para>"HighCriticality"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#HighCriticality">https://w3id.org/itsmo#HighCriticality</seealso>
    let ``itsmo#HighCriticality`` =
        Prefixed_Name(w3id, "itsmo#HighCriticality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#HighPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#Priority</para>
    ///   <para>"an high priority"</para>
    /// labels<para>"HighPriority"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#HighPriority">https://w3id.org/itsmo#HighPriority</seealso>
    let ``itsmo#HighPriority`` =
        Prefixed_Name(w3id, "itsmo#HighPriority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ITService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An IT service is made up of a combination of information technology. It is deployed from a deployment baseline."</para>
    /// labels<para>"ITService"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ITService">https://w3id.org/itsmo#ITService</seealso>
    let ``itsmo#ITService`` = Prefixed_Name(w3id, "itsmo#ITService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#InfrastructureService</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ServiceScope</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An IT service that is not directly used by the business, but is required by the IT service provider to deliver IT Business Services (for example, a directory service or a backup service).
    /// Supporting services may also include IT services only used by the IT service provider.
    /// All live supporting services, including those available for deployment, are recorded in the service catalogue along with information about their relationships to Business Services  and other CIs.
    /// ITIL 2011 call ths also "Supporting Service""</para>
    /// labels<para>"InfrastructureService"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#InfrastructureService">https://w3id.org/itsmo#InfrastructureService</seealso>
    let ``itsmo#InfrastructureService`` =
        Prefixed_Name(w3id, "itsmo#InfrastructureService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structured collection of documents, assets, or components that support knowledge sharing, versioning, and reuse within the ITIL framework."</para>
    /// labels<para>"Library"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Library">https://w3id.org/itsmo#Library</seealso>
    let ``itsmo#Library`` = Prefixed_Name(w3id, "itsmo#Library") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#LowCriticality</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#Criticality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"a low criticality value"</para>
    /// labels<para>"LowCriticality"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#LowCriticality">https://w3id.org/itsmo#LowCriticality</seealso>
    let ``itsmo#LowCriticality`` =
        Prefixed_Name(w3id, "itsmo#LowCriticality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#LowPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#Priority</para>
    ///   <para>"a low priority"</para>
    /// labels<para>"LowPriority"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#LowPriority">https://w3id.org/itsmo#LowPriority</seealso>
    let ``itsmo#LowPriority`` = Prefixed_Name(w3id, "itsmo#LowPriority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ManagementProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is a process of planning and controlling one or more of activities. Here
    ///     are some examples:
    ///
    /// - **Configuration Management**: the process responsible for ensuring that the assets required to deliver services are properly controlled, and that accurate and reliable information about those assets is available when and where it is needed. This information includes details of how the assets have been configured and the relationships betweens [ITIL glossary].
    ///
    /// - **Project Management**: the discipline of planning, organizing, securing, and managing resources to achieve specific goals. A project is a temporary endeavor with a defined beginning and end (usually time-constrained, and often constrained by funding or deliverables), undertaken to meet unique goals and objectives, typically to bring about beneficial change or added value [Wikipedia].
    ///
    /// - **Change Management**: the process responsible for controlling the lifecycle of all changes, enabling beneficial changes to be made with minimum disruption to IT services. [ITIL glossary]"</para>
    /// labels<para>"ManagementProcess"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ManagementProcess">https://w3id.org/itsmo#ManagementProcess</seealso>
    let ``itsmo#ManagementProcess`` =
        Prefixed_Name(w3id, "itsmo#ManagementProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#MediumCriticality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#Criticality</para>
    ///   <para>"A medium criticality value."</para>
    /// labels<para>"MediumCriticality"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#MediumCriticality">https://w3id.org/itsmo#MediumCriticality</seealso>
    let ``itsmo#MediumCriticality`` =
        Prefixed_Name(w3id, "itsmo#MediumCriticality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#MediumPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#Priority</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A medium priority."</para>
    /// labels<para>"MediumPriority"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#MediumPriority">https://w3id.org/itsmo#MediumPriority</seealso>
    let ``itsmo#MediumPriority`` =
        Prefixed_Name(w3id, "itsmo#MediumPriority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ObjectRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"an service management entity with a state that can be versioned and managed in a repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ObjectRepository"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ObjectRepository">https://w3id.org/itsmo#ObjectRepository</seealso>
    let ``itsmo#ObjectRepository`` =
        Prefixed_Name(w3id, "itsmo#ObjectRepository") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ServiceLifeCycleStage</para>
    ///   <para>"A specific action or series of actions performed as part of a process."</para>
    /// labels<para>"Operation"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Operation">https://w3id.org/itsmo#Operation</seealso>
    let ``itsmo#Operation`` = Prefixed_Name(w3id, "itsmo#Operation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#OperationLevelAgreement</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"OperationLevelAgreement"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#OperationLevelAgreement">https://w3id.org/itsmo#OperationLevelAgreement</seealso>
    let ``itsmo#OperationLevelAgreement`` =
        Prefixed_Name(w3id, "itsmo#OperationLevelAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#OperationLevelAgrement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schemas:WarranyScope</para>
    ///   <para>"An agreement outlining operational expectations and responsibilities."</para>
    /// labels<para>"OperationLevelAgreement"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#OperationLevelAgrement">https://w3id.org/itsmo#OperationLevelAgrement</seealso>
    let ``itsmo#OperationLevelAgrement`` =
        Prefixed_Name(w3id, "itsmo#OperationLevelAgrement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An entity or individual possessing rights or control over an object or resource."</para>
    /// labels<para>"Owner"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Owner">https://w3id.org/itsmo#Owner</seealso>
    let ``itsmo#Owner`` = Prefixed_Name(w3id, "itsmo#Owner") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Packaging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document that describes how to create an artifact."</para>
    /// labels<para>"Packaging"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Packaging">https://w3id.org/itsmo#Packaging</seealso>
    let ``itsmo#Packaging`` = Prefixed_Name(w3id, "itsmo#Packaging") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structured document or set of instructions outlining objectives, strategies, and actions for achieving specific IT or business goals."</para>
    /// labels<para>"Plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Plan">https://w3id.org/itsmo#Plan</seealso>
    let ``itsmo#Plan`` = Prefixed_Name(w3id, "itsmo#Plan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Formally documented management expectations and intentions. Policies are used to direct decisions, and to ensure consistent and appropriate development and implementation of processes, standards, roles, activities, IT infrastructure etc."</para>
    /// labels<para>"Policy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Policy">https://w3id.org/itsmo#Policy</seealso>
    let ``itsmo#Policy`` = Prefixed_Name(w3id, "itsmo#Policy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A process priority"</para>
    /// labels<para>"Priority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Priority">https://w3id.org/itsmo#Priority</seealso>
    let ``itsmo#Priority`` = Prefixed_Name(w3id, "itsmo#Priority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ProcessDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A documenthat describes a structured set of activities designed to accomplish a specific objective.
    /// A process takes one or more defined inputs and turns them into defined outputs. It may include any of the roles, responsibilities, tools and management controls required to reliably deliver the outputs. A process may define policies, standards, guidelines, activities and work instructions if they are needed."</para>
    /// labels<para>"ProcessDescription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ProcessDescription">https://w3id.org/itsmo#ProcessDescription</seealso>
    let ``itsmo#ProcessDescription`` =
        Prefixed_Name(w3id, "itsmo#ProcessDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ProductSheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document that provides an overview of a product, including its features, capabilities, and benefits, aimed at potential users or stakeholders."</para>
    /// labels<para>"ProductSheet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ProductSheet">https://w3id.org/itsmo#ProductSheet</seealso>
    let ``itsmo#ProductSheet`` =
        Prefixed_Name(w3id, "itsmo#ProductSheet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Responsible</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An entity or individual accountable for a particular task or decision."</para>
    /// labels<para>"Responsible"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Responsible">https://w3id.org/itsmo#Responsible</seealso>
    let ``itsmo#Responsible`` = Prefixed_Name(w3id, "itsmo#Responsible") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Retire</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ServiceLifeCycleStage</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Permanent removal of a configuration item, from the live environment. Being retired is a stage in the lifecycle of many configuration items."</para>
    /// labels<para>"Retire"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Retire">https://w3id.org/itsmo#Retire</seealso>
    let ``itsmo#Retire`` = Prefixed_Name(w3id, "itsmo#Retire") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A means of delivering value to customers by facilitating outcomes customers want to achieve without the ownership of specific costs and risks."</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Service">https://w3id.org/itsmo#Service</seealso>
    let ``itsmo#Service`` = Prefixed_Name(w3id, "itsmo#Service") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ServiceCatalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A database or structured document with information about all live IT services, including those available for deployment. The service catalogue is part of the service portfolio and contains information about two types of IT service: customer-facing services that are visible to the business; and supporting services required by the service provider to deliver customer-facing services."</para>
    /// labels<para>"ServiceCatalogue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ServiceCatalogue">https://w3id.org/itsmo#ServiceCatalogue</seealso>
    let ``itsmo#ServiceCatalogue`` =
        Prefixed_Name(w3id, "itsmo#ServiceCatalogue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ServiceLevelAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schemas:WarranyScope</para>
    ///   <para>"A formal agreement defining the expected service performance and commitments."</para>
    /// labels<para>"ServiceLevelAgreement"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ServiceLevelAgreement">https://w3id.org/itsmo#ServiceLevelAgreement</seealso>
    let ``itsmo#ServiceLevelAgreement`` =
        Prefixed_Name(w3id, "itsmo#ServiceLevelAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ServiceLifeCycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A stage in the life of a configuration item. The lifecycle defines the categories for status and the status transitions that are permitted. For   example:
    ///
    /// - The lifecycle of an application includes requirements, design, build, deploy, operate, optimize.
    /// - The expanded incident lifecycle includes detection, diagnosis, repair, recovery, and restoration.
    /// - The lifecycle of a server may include: ordered, received, in test, live, disposed, etc."</para>
    /// labels<para>"ServiceLifeCycleStage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ServiceLifeCycleStage">https://w3id.org/itsmo#ServiceLifeCycleStage</seealso>
    let ``itsmo#ServiceLifeCycleStage`` =
        Prefixed_Name(w3id, "itsmo#ServiceLifeCycleStage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ServiceOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A choice of utility and warranty offered to customers by a core service or service package."</para>
    /// labels<para>"ServiceOption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ServiceOption">https://w3id.org/itsmo#ServiceOption</seealso>
    let ``itsmo#ServiceOption`` =
        Prefixed_Name(w3id, "itsmo#ServiceOption") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ServicePortfolio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The complete set of services that is managed by a service provider. The service portfolio is used to manage the entire lifecycle of all services, and includes three categories: service pipeline (proposed or in development), service catalogue (live or available for deployment), and retired services."</para>
    /// labels<para>"ServicePortfolio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ServicePortfolio">https://w3id.org/itsmo#ServicePortfolio</seealso>
    let ``itsmo#ServicePortfolio`` =
        Prefixed_Name(w3id, "itsmo#ServicePortfolio") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#ServiceScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The service scope (business or infrastructure)."</para>
    /// labels<para>"ServiceScope"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#ServiceScope">https://w3id.org/itsmo#ServiceScope</seealso>
    let ``itsmo#ServiceScope`` =
        Prefixed_Name(w3id, "itsmo#ServiceScope") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Software code"</para>
    /// labels<para>"Software"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Software">https://w3id.org/itsmo#Software</seealso>
    let ``itsmo#Software`` = Prefixed_Name(w3id, "itsmo#Software") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#SoftwarePackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artifact that  realizes a software release or a software feature set.
    /// For example: "VirtueMart 1.1.x", "Linux LTS 10.04" , "Windows 7 service pack 2", "Apache 2" . Sometime referenced only with "software"."</para>
    /// labels<para>"SoftwarePackage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#SoftwarePackage">https://w3id.org/itsmo#SoftwarePackage</seealso>
    let ``itsmo#SoftwarePackage`` =
        Prefixed_Name(w3id, "itsmo#SoftwarePackage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#SourceDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software package distributed with source code"</para>
    /// labels<para>"SourceDistribution"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#SourceDistribution">https://w3id.org/itsmo#SourceDistribution</seealso>
    let ``itsmo#SourceDistribution`` =
        Prefixed_Name(w3id, "itsmo#SourceDistribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Strategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ServiceLifeCycleStage</para>
    ///   <para>"A high-level plan or approach designed to achieve specific long-term objectives, often related to business or IT goals."</para>
    /// labels<para>"Strategy"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Strategy">https://w3id.org/itsmo#Strategy</seealso>
    let ``itsmo#Strategy`` = Prefixed_Name(w3id, "itsmo#Strategy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#SupportService</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ServiceScope</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A service that provides assistance or maintenance."</para>
    /// labels<para>"SupportService"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#SupportService">https://w3id.org/itsmo#SupportService</seealso>
    let ``itsmo#SupportService`` =
        Prefixed_Name(w3id, "itsmo#SupportService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#SystemComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fundamental building block or element of an IT system, such as hardware, software, or a network component."</para>
    /// labels<para>"SystemComponent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#SystemComponent">https://w3id.org/itsmo#SystemComponent</seealso>
    let ``itsmo#SystemComponent`` =
        Prefixed_Name(w3id, "itsmo#SystemComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#Template</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A skeleton document or a document to be used as reference for editing another document."</para>
    /// labels<para>"Template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Template">https://w3id.org/itsmo#Template</seealso>
    let ``itsmo#Template`` = Prefixed_Name(w3id, "itsmo#Template") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Transition</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ServiceLifeCycleStage</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The phase or process in ITIL that focuses on ensuring that changes, updates, or new services are transitioned smoothly from development to production."</para>
    /// labels<para>"Transition"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Transition">https://w3id.org/itsmo#Transition</seealso>
    let ``itsmo#Transition`` = Prefixed_Name(w3id, "itsmo#Transition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Utility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The functionality offered by a product or service to meet a particular need. Utility can be summarized as ‘what the service does’, and can be used to determine whether a service is able to meet its required outcomes, or is ‘fit for purpose’. The business value of an IT service is created by the combination of utility and warranty."</para>
    /// labels<para>"Utility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Utility">https://w3id.org/itsmo#Utility</seealso>
    let ``itsmo#Utility`` = Prefixed_Name(w3id, "itsmo#Utility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#Warranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Assurance that a product or service will meet agreed requirements. This may be a formal agreement such as a service level agreement or contract, or it may be a marketing message or brand image. Warranty refers to the ability of a service to be available when needed, to provide the required capacity, and to provide the required reliability in terms of continuity and security. Warranty can be summarized as ‘how the service is delivered’, and can be used to determine whether a service is ‘fit for use’. The business value of an IT service is created by the combination of utility and warranty."</para>
    /// labels<para>"Warranty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#Warranty">https://w3id.org/itsmo#Warranty</seealso>
    let ``itsmo#Warranty`` = Prefixed_Name(w3id, "itsmo#Warranty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#WebService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A service that communicates over a network using web-based protocols."</para>
    /// labels<para>"WebService"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#WebService">https://w3id.org/itsmo#WebService</seealso>
    let ``itsmo#WebService`` = Prefixed_Name(w3id, "itsmo#WebService") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#builtFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A software baseline that contributes to the construction of an artifact."</para>
    /// labels<para>"builtFrom"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#builtFrom">https://w3id.org/itsmo#builtFrom</seealso>
    let ``itsmo#builtFrom`` = Prefixed_Name(w3id, "itsmo#builtFrom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#created">https://w3id.org/itsmo#created</seealso>
    let ``itsmo#created`` = Prefixed_Name(w3id, "itsmo#created") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#dependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a directed dependency between entities."</para>
    /// labels<para>"dependsOn"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#dependsOn">https://w3id.org/itsmo#dependsOn</seealso>
    let ``itsmo#dependsOn`` = Prefixed_Name(w3id, "itsmo#dependsOn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#deployedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"States baseline that contains the instructions to deploy a specific version of a service in a specific environment."</para>
    /// labels<para>"deployedFrom"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#deployedFrom">https://w3id.org/itsmo#deployedFrom</seealso>
    let ``itsmo#deployedFrom`` =
        Prefixed_Name(w3id, "itsmo#deployedFrom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#hasCriticality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Represents the relative criticality of an entity."</para>
    /// labels<para>"hasCriticality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#hasCriticality">https://w3id.org/itsmo#hasCriticality</seealso>
    let ``itsmo#hasCriticality`` =
        Prefixed_Name(w3id, "itsmo#hasCriticality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#hasEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"an URL where the service responds, it is an inverse functional property"</para>
    /// labels<para>"hasEndpoint"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#hasEndpoint">https://w3id.org/itsmo#hasEndpoint</seealso>
    let ``itsmo#hasEndpoint`` = Prefixed_Name(w3id, "itsmo#hasEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#hasOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the legal owner of an asset"</para>
    /// labels<para>"hasOwner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#hasOwner">https://w3id.org/itsmo#hasOwner</seealso>
    let ``itsmo#hasOwner`` = Prefixed_Name(w3id, "itsmo#hasOwner") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#hasPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A priority qualitative value."</para>
    /// labels<para>"hasPriority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#hasPriority">https://w3id.org/itsmo#hasPriority</seealso>
    let ``itsmo#hasPriority`` = Prefixed_Name(w3id, "itsmo#hasPriority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#hasResponsible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Those who do the work to achieve a Process. There is typically one role with a participation type of Responsible, although others can be delegated to assist in the work required."</para>
    /// labels<para>"hasResponsible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#hasResponsible">https://w3id.org/itsmo#hasResponsible</seealso>
    let ``itsmo#hasResponsible`` =
        Prefixed_Name(w3id, "itsmo#hasResponsible") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#hasScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This attribute states the service scope"</para>
    /// labels<para>"hasScope"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#hasScope">https://w3id.org/itsmo#hasScope</seealso>
    let ``itsmo#hasScope`` = Prefixed_Name(w3id, "itsmo#hasScope") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#implementsInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#implementsInterface">https://w3id.org/itsmo#implementsInterface</seealso>
    let ``itsmo#implementsInterface`` =
        Prefixed_Name(w3id, "itsmo#implementsInterface") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#informedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a source or entity providing relevant information."</para>
    /// labels<para>"informedBy"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#informedBy">https://w3id.org/itsmo#informedBy</seealso>
    let ``itsmo#informedBy`` = Prefixed_Name(w3id, "itsmo#informedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_API</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_API">https://w3id.org/itsmo#interface_API</seealso>
    let ``itsmo#interface_API`` =
        Prefixed_Name(w3id, "itsmo#interface_API") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_EI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_EI">https://w3id.org/itsmo#interface_EI</seealso>
    let ``itsmo#interface_EI`` =
        Prefixed_Name(w3id, "itsmo#interface_EI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_ENV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_ENV">https://w3id.org/itsmo#interface_ENV</seealso>
    let ``itsmo#interface_ENV`` =
        Prefixed_Name(w3id, "itsmo#interface_ENV") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_FS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_FS">https://w3id.org/itsmo#interface_FS</seealso>
    let ``itsmo#interface_FS`` =
        Prefixed_Name(w3id, "itsmo#interface_FS") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_LDR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_LDR">https://w3id.org/itsmo#interface_LDR</seealso>
    let ``itsmo#interface_LDR`` =
        Prefixed_Name(w3id, "itsmo#interface_LDR") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_LI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_LI">https://w3id.org/itsmo#interface_LI</seealso>
    let ``itsmo#interface_LI`` =
        Prefixed_Name(w3id, "itsmo#interface_LI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_LOG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_LOG">https://w3id.org/itsmo#interface_LOG</seealso>
    let ``itsmo#interface_LOG`` =
        Prefixed_Name(w3id, "itsmo#interface_LOG") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_MDB</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_MDB">https://w3id.org/itsmo#interface_MDB</seealso>
    let ``itsmo#interface_MDB`` =
        Prefixed_Name(w3id, "itsmo#interface_MDB") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_MOC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_MOC">https://w3id.org/itsmo#interface_MOC</seealso>
    let ``itsmo#interface_MOC`` =
        Prefixed_Name(w3id, "itsmo#interface_MOC") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_MQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_MQ">https://w3id.org/itsmo#interface_MQ</seealso>
    let ``itsmo#interface_MQ`` =
        Prefixed_Name(w3id, "itsmo#interface_MQ") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_OC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_OC">https://w3id.org/itsmo#interface_OC</seealso>
    let ``itsmo#interface_OC`` =
        Prefixed_Name(w3id, "itsmo#interface_OC") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_PI</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_PI">https://w3id.org/itsmo#interface_PI</seealso>
    let ``itsmo#interface_PI`` =
        Prefixed_Name(w3id, "itsmo#interface_PI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_S3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_S3">https://w3id.org/itsmo#interface_S3</seealso>
    let ``itsmo#interface_S3`` =
        Prefixed_Name(w3id, "itsmo#interface_S3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_SQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_SQ">https://w3id.org/itsmo#interface_SQ</seealso>
    let ``itsmo#interface_SQ`` =
        Prefixed_Name(w3id, "itsmo#interface_SQ") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_SU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_SU">https://w3id.org/itsmo#interface_SU</seealso>
    let ``itsmo#interface_SU`` =
        Prefixed_Name(w3id, "itsmo#interface_SU") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_SWB</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_SWB">https://w3id.org/itsmo#interface_SWB</seealso>
    let ``itsmo#interface_SWB`` =
        Prefixed_Name(w3id, "itsmo#interface_SWB") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_WAPP</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_WAPP">https://w3id.org/itsmo#interface_WAPP</seealso>
    let ``itsmo#interface_WAPP`` =
        Prefixed_Name(w3id, "itsmo#interface_WAPP") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_WR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:itsmo#ComponentInterface</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_WR">https://w3id.org/itsmo#interface_WR</seealso>
    let ``itsmo#interface_WR`` =
        Prefixed_Name(w3id, "itsmo#interface_WR") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#interface_implementationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/itsmo#interface_implementationStatus">https://w3id.org/itsmo#interface_implementationStatus</seealso>
    let ``itsmo#interface_implementationStatus`` =
        Prefixed_Name(w3id, "itsmo#interface_implementationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#links</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a connection or relationship between two entities, such as systems, services, or processes."</para>
    /// labels<para>"links"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#links">https://w3id.org/itsmo#links</seealso>
    let ``itsmo#links`` = Prefixed_Name(w3id, "itsmo#links") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a direct hierarchical dependency"</para>
    /// labels<para>"partOf"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#partOf">https://w3id.org/itsmo#partOf</seealso>
    let ``itsmo#partOf`` = Prefixed_Name(w3id, "itsmo#partOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#path</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"an optional  reference inside the repository structure."</para>
    /// labels<para>"path"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#path">https://w3id.org/itsmo#path</seealso>
    let ``itsmo#path`` = Prefixed_Name(w3id, "itsmo#path") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#promises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents a formal commitment or assurance provided by a service provider to meet certain standards or deliver specific outcomes."</para>
    /// labels<para>"promises"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#promises">https://w3id.org/itsmo#promises</seealso>
    let ``itsmo#promises`` = Prefixed_Name(w3id, "itsmo#promises") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#serviceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the referenced resource is a stage in the life cycle of the described resource."</para>
    /// labels<para>"serviceStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#serviceStatus">https://w3id.org/itsmo#serviceStatus</seealso>
    let ``itsmo#serviceStatus`` =
        Prefixed_Name(w3id, "itsmo#serviceStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:itsmo#versionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"the referring ConfigurationItem is a total or partial snapshot of a resource state"</para>
    /// labels<para>"versionOf"</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#versionOf">https://w3id.org/itsmo#versionOf</seealso>
    let ``itsmo#versionOf`` = Prefixed_Name(w3id, "itsmo#versionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:itsmo#versionTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A label or identifier assigned to a specific reference version of a component, application, or document for tracking and management."</para>
    /// labels<para>"versionTag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/itsmo#versionTag">https://w3id.org/itsmo#versionTag</seealso>
    let ``itsmo#versionTag`` = Prefixed_Name(w3id, "itsmo#versionTag") |> PrefixedName
    /// <summary>
    ///   <para>w3id:legalhtml/ov</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov">https://w3id.org/legalhtml/ov</seealso>
    let ``legalhtml/ov`` = Prefixed_Name(w3id, "legalhtml/ov") |> PrefixedName

    /// <summary>
    ///   <para>w3id:legalhtml/ov-1.0.0-rc.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov-1.0.0-rc.1">https://w3id.org/legalhtml/ov-1.0.0-rc.1</seealso>
    let ``legalhtml/ov_1.0.0_rc.1`` =
        Prefixed_Name(w3id, "legalhtml/ov-1.0.0-rc.1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lio/v1PictorialElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/lio/v1PictorialElement">https://w3id.org/lio/v1PictorialElement</seealso>
    let ``lio/v1PictorialElement`` =
        Prefixed_Name(w3id, "lio/v1PictorialElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:list#EmptyList</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/list#EmptyList">https://w3id.org/list#EmptyList</seealso>
    let ``list#EmptyList`` = Prefixed_Name(w3id, "list#EmptyList") |> PrefixedName
    /// <summary>
    ///   <para>w3id:list#OWLList</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/list#OWLList">https://w3id.org/list#OWLList</seealso>
    let ``list#OWLList`` = Prefixed_Name(w3id, "list#OWLList") |> PrefixedName
    /// <summary>
    ///   <para>w3id:list#hasContents</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/list#hasContents">https://w3id.org/list#hasContents</seealso>
    let ``list#hasContents`` = Prefixed_Name(w3id, "list#hasContents") |> PrefixedName
    /// <summary>
    ///   <para>w3id:list#hasNext</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/list#hasNext">https://w3id.org/list#hasNext</seealso>
    let ``list#hasNext`` = Prefixed_Name(w3id, "list#hasNext") |> PrefixedName
    /// <summary>
    ///   <para>w3id:list#isFollowedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/list#isFollowedBy">https://w3id.org/list#isFollowedBy</seealso>
    let ``list#isFollowedBy`` = Prefixed_Name(w3id, "list#isFollowedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:loin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>schemas:Person</para>
    ///   <para>schemas:Organization</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/loin">https://w3id.org/loin</seealso>
    let loin = Prefixed_Name(w3id, "loin") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/icdd#isRelatedToContainerDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property is an extension with ICDD. It relates the information delivery milestone defined by BS EN 17412-1(2020) with container description"</para>
    /// labels<para>"is related to container description"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/icdd#isRelatedToContainerDescription">https://w3id.org/loin/v2/icdd#isRelatedToContainerDescription</seealso>
    let ``loin/v2/icdd#isRelatedToContainerDescription`` =
        Prefixed_Name(w3id, "loin/v2/icdd#isRelatedToContainerDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/icdd#isRelatedToContainerDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property is an extension with ICDD. It relates documents defined by BS EN 17412-1(2020) with container documents"</para>
    /// labels<para>"is related to container document"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/icdd#isRelatedToContainerDocument">https://w3id.org/loin/v2/icdd#isRelatedToContainerDocument</seealso>
    let ``loin/v2/icdd#isRelatedToContainerDocument`` =
        Prefixed_Name(w3id, "loin/v2/icdd#isRelatedToContainerDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/icdd#isRelatedToContainerLinkset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property is an extension with ICDD. It relates ontological document defined by BS EN 17412-1(2020) with container linkset or data set"</para>
    /// labels<para>"is related to container linkset"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/icdd#isRelatedToContainerLinkset">https://w3id.org/loin/v2/icdd#isRelatedToContainerLinkset</seealso>
    let ``loin/v2/icdd#isRelatedToContainerLinkset`` =
        Prefixed_Name(w3id, "loin/v2/icdd#isRelatedToContainerLinkset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/icdd#isRelatedToContainerParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property is an extension with ICDD. It relates the actors defined by BS EN 17412-1(2020) with container party"</para>
    /// labels<para>"is related to container party"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/icdd#isRelatedToContainerParty">https://w3id.org/loin/v2/icdd#isRelatedToContainerParty</seealso>
    let ``loin/v2/icdd#isRelatedToContainerParty`` =
        Prefixed_Name(w3id, "loin/v2/icdd#isRelatedToContainerParty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/icdd#isRelatedToLinksetIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property is an extension with ICDD. It relates the identifier type defined by BS EN 17412-1(2020) with linkset identifier"</para>
    /// labels<para>"is related to linkset identifier"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/icdd#isRelatedToLinksetIdentifier">https://w3id.org/loin/v2/icdd#isRelatedToLinksetIdentifier</seealso>
    let ``loin/v2/icdd#isRelatedToLinksetIdentifier`` =
        Prefixed_Name(w3id, "loin/v2/icdd#isRelatedToLinksetIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#Attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Attribute is a facet of Information Delivery Specification (IDS), a standard developed by buildingSMART International"</para>
    /// labels<para>"Attribute of IDS"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#Attribute">https://w3id.org/loin/v2/ids#Attribute</seealso>
    let ``loin/v2/ids#Attribute`` =
        Prefixed_Name(w3id, "loin/v2/ids#Attribute") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#AttributeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Attribute name must be a valid attribute name from the IFC schema according to the definition of IDS developed by buildingSMART International. Example AttributeName = "Description""</para>
    /// labels<para>"Attribute name"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#AttributeName">https://w3id.org/loin/v2/ids#AttributeName</seealso>
    let ``loin/v2/ids#AttributeName`` =
        Prefixed_Name(w3id, "loin/v2/ids#AttributeName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Classification is is a facet of Information Delivery Specification (IDS), a standard developed by buildingSMART International. In this ontology, it is defined as an equivalent class of Indentification according to BS EN 17412-1"</para>
    /// labels<para>"Classification of IDS"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#Classification">https://w3id.org/loin/v2/ids#Classification</seealso>
    let ``loin/v2/ids#Classification`` =
        Prefixed_Name(w3id, "loin/v2/ids#Classification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#DataDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IDS data definition is used to specify the alphanumerical information according to Information Delivery Specification (IDS) developed by buildingSMART International"</para>
    /// labels<para>"IDS data definition"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#DataDefinition">https://w3id.org/loin/v2/ids#DataDefinition</seealso>
    let ``loin/v2/ids#DataDefinition`` =
        Prefixed_Name(w3id, "loin/v2/ids#DataDefinition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Entity is a facet of Information Delivery Specification (IDS), a standard developed by buildingSMART International"</para>
    /// labels<para>"Entity"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#Entity">https://w3id.org/loin/v2/ids#Entity</seealso>
    let ``loin/v2/ids#Entity`` =
        Prefixed_Name(w3id, "loin/v2/ids#Entity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#EntityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Entity name must be a valid IFC class from the IFC schema according to IDS developed by buildingSMART International. Example EntityName = "IFCWALL""</para>
    /// labels<para>"Entity name"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#EntityName">https://w3id.org/loin/v2/ids#EntityName</seealso>
    let ``loin/v2/ids#EntityName`` =
        Prefixed_Name(w3id, "loin/v2/ids#EntityName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#FacetDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IDS facet definition is used to define a facet to apply the requirement or to require the information according to IDS standard developed by buildingSMART International"</para>
    /// labels<para>"IDS facet definition"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#FacetDefinition">https://w3id.org/loin/v2/ids#FacetDefinition</seealso>
    let ``loin/v2/ids#FacetDefinition`` =
        Prefixed_Name(w3id, "loin/v2/ids#FacetDefinition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#FacetParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IDS facet parameter is used to specify a facet definition according to IDS standard developed by buildingSMART International"</para>
    /// labels<para>"IDS facet parameter"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#FacetParameter">https://w3id.org/loin/v2/ids#FacetParameter</seealso>
    let ``loin/v2/ids#FacetParameter`` =
        Prefixed_Name(w3id, "loin/v2/ids#FacetParameter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#IFCDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IFC data type must be a valid predefined type from the IFC schema according to IDS standard developed by buildingSMART International"</para>
    /// labels<para>"IFC data type"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#IFCDataType">https://w3id.org/loin/v2/ids#IFCDataType</seealso>
    let ``loin/v2/ids#IFCDataType`` =
        Prefixed_Name(w3id, "loin/v2/ids#IFCDataType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Material is a facet of Information Delivery Specification(IDS), a standard developed by buildingSMART International"</para>
    /// labels<para>"Material"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#Material">https://w3id.org/loin/v2/ids#Material</seealso>
    let ``loin/v2/ids#Material`` =
        Prefixed_Name(w3id, "loin/v2/ids#Material") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#PredefinedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Predefined type must be a valid predefined type from the IFC schema, or any custom text value according to IDS standard developed by buildingSMART International"</para>
    /// labels<para>"Predefined type"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#PredefinedType">https://w3id.org/loin/v2/ids#PredefinedType</seealso>
    let ``loin/v2/ids#PredefinedType`` =
        Prefixed_Name(w3id, "loin/v2/ids#PredefinedType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Property is a facet of Information Delivery Specification(IDS), a standard developed by buildingSMART International"</para>
    /// labels<para>"Property"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#Property">https://w3id.org/loin/v2/ids#Property</seealso>
    let ``loin/v2/ids#Property`` =
        Prefixed_Name(w3id, "loin/v2/ids#Property") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#PropertyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Property name must be a valid name from the IFC schema, or any custom text value according to IDS stan developed by buildingSMART International"</para>
    /// labels<para>"Property name"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#PropertyName">https://w3id.org/loin/v2/ids#PropertyName</seealso>
    let ``loin/v2/ids#PropertyName`` =
        Prefixed_Name(w3id, "loin/v2/ids#PropertyName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#PsetName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Property set name must be a valid name from the IFC schema, or any custom text value according to IDS standard developed by buildingSMART International"</para>
    /// labels<para>"Property set name"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#PsetName">https://w3id.org/loin/v2/ids#PsetName</seealso>
    let ``loin/v2/ids#PsetName`` =
        Prefixed_Name(w3id, "loin/v2/ids#PsetName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#RequirementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IDS requirement type is used to specify a requirement, if it is optional or mandatory according to IDS standard developed by buildingSMART International"</para>
    /// labels<para>"IDS requirement type"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#RequirementType">https://w3id.org/loin/v2/ids#RequirementType</seealso>
    let ``loin/v2/ids#RequirementType`` =
        Prefixed_Name(w3id, "loin/v2/ids#RequirementType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#RestrictionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Restriction type is used to specify the value of IDS facet parameter, that is defined in restriction formulation. The restriction types are based on IDS standard developed by buildingSMART International"</para>
    /// labels<para>"Restriction type"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#RestrictionType">https://w3id.org/loin/v2/ids#RestrictionType</seealso>
    let ``loin/v2/ids#RestrictionType`` =
        Prefixed_Name(w3id, "loin/v2/ids#RestrictionType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Value can be any custom value according to IDS standard developed by buildingSMART International"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#Value">https://w3id.org/loin/v2/ids#Value</seealso>
    let ``loin/v2/ids#Value`` = Prefixed_Name(w3id, "loin/v2/ids#Value") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#belongsToPset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specification is used for facet property of IDS data definition."</para>
    /// labels<para>"A property belongs to Property set"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#belongsToPset">https://w3id.org/loin/v2/ids#belongsToPset</seealso>
    let ``loin/v2/ids#belongsToPset`` =
        Prefixed_Name(w3id, "loin/v2/ids#belongsToPset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#hasApplicability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property describes the applicability of a facet for the specification according to IDS definition"</para>
    /// labels<para>"has applicability"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#hasApplicability">https://w3id.org/loin/v2/ids#hasApplicability</seealso>
    let ``loin/v2/ids#hasApplicability`` =
        Prefixed_Name(w3id, "loin/v2/ids#hasApplicability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#hasAttributeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the attribute name with the facet attribute according to IDS definition"</para>
    /// labels<para>"has attribute name"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#hasAttributeName">https://w3id.org/loin/v2/ids#hasAttributeName</seealso>
    let ``loin/v2/ids#hasAttributeName`` =
        Prefixed_Name(w3id, "loin/v2/ids#hasAttributeName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#hasEntityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the entity name with the facet entity according to IDS definition"</para>
    /// labels<para>"has entity name"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#hasEntityName">https://w3id.org/loin/v2/ids#hasEntityName</seealso>
    let ``loin/v2/ids#hasEntityName`` =
        Prefixed_Name(w3id, "loin/v2/ids#hasEntityName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#hasIFCDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the IFC data type with the facet property according to IDS definition"</para>
    /// labels<para>"has IFC data type"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#hasIFCDataType">https://w3id.org/loin/v2/ids#hasIFCDataType</seealso>
    let ``loin/v2/ids#hasIFCDataType`` =
        Prefixed_Name(w3id, "loin/v2/ids#hasIFCDataType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#hasPredefinedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates a predefined type with the facet entity according to IDS definition"</para>
    /// labels<para>"has predefined type"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#hasPredefinedType">https://w3id.org/loin/v2/ids#hasPredefinedType</seealso>
    let ``loin/v2/ids#hasPredefinedType`` =
        Prefixed_Name(w3id, "loin/v2/ids#hasPredefinedType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#hasPropertyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates a property name type with the facet property according to IDS definition"</para>
    /// labels<para>"has property name"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#hasPropertyName">https://w3id.org/loin/v2/ids#hasPropertyName</seealso>
    let ``loin/v2/ids#hasPropertyName`` =
        Prefixed_Name(w3id, "loin/v2/ids#hasPropertyName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#hasRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property relates the requirements with the IDS data definition"</para>
    /// labels<para>"has requirement"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#hasRequirement">https://w3id.org/loin/v2/ids#hasRequirement</seealso>
    let ``loin/v2/ids#hasRequirement`` =
        Prefixed_Name(w3id, "loin/v2/ids#hasRequirement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#hasRestrictionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relates the restriction type with the facet parameter in IDS data definition"</para>
    /// labels<para>"has restriction type"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#hasRestrictionType">https://w3id.org/loin/v2/ids#hasRestrictionType</seealso>
    let ``loin/v2/ids#hasRestrictionType`` =
        Prefixed_Name(w3id, "loin/v2/ids#hasRestrictionType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relates the value with a facet in IDS data definition"</para>
    /// labels<para>"has value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#hasValue">https://w3id.org/loin/v2/ids#hasValue</seealso>
    let ``loin/v2/ids#hasValue`` =
        Prefixed_Name(w3id, "loin/v2/ids#hasValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:loin/v2/ids#restrictionFormulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Restriction formulation is for formulating facet parameter value, that is used by IDS definition."</para>
    /// labels<para>"Constraint text formulated for facet parameters"</para></remarks>
    /// <seealso href="https://w3id.org/loin/v2/ids#restrictionFormulation">https://w3id.org/loin/v2/ids#restrictionFormulation</seealso>
    let ``loin/v2/ids#restrictionFormulation`` =
        Prefixed_Name(w3id, "loin/v2/ids#restrictionFormulation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lrmoo:F2_Expression</para>
    ///   <para>"Changes from version beta201901 to version beta202001: Some classes and relations could be resolved into types of intertextual relations; this concerned in particular the class INT5 Characteristic and adherent object relations.
    /// 			- Deleted class INT5 Characteristic, accordingly: deleted relations R1, R2, R14-16; changes on relations: R21, R23, R24 - Deleted relations R5, R6, R7
    /// 			- Added class INT17 Functional Relation as a subclass of INT11 Type of Intertextual Relation. (2020-01) "</para>
    /// labels<para>"INTRO beta202001"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202001">https://w3id.org/lso/intro/beta202001</seealso>
    let ``lso/intro/beta202001`` =
        Prefixed_Name(w3id, "lso/intro/beta202001") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202210</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lrmoo:F2_Expression</para>
    ///   <para>"Changes from version beta202001 to version beta202210:
    /// 			- A necessary modification was made on INT16: It was renamed "Segment" and its description was altered: The now more flexible INT16 can incorporate portions of e.g. F22 Self-contained Expressions of any size, meaning not only whole texts, but also INT1 Text Passages.
    /// 			- The INT16 is now also a direct subclass of E90 Symbolic Object.
    /// 			- Properties indicating position inside a document, that before related to INT1 Text Passage now also relate to INT16 Segment - since a Text Passage as taken from a F22 Self-contained Expression does not yet have the form of a published work and because of that can not be identified via e.g. page numbers (but only by indication of verse, act, chapter etc.). A INT16 as a part of a published text can.
    /// 			- After close examination it became clear that "r10 has text passage" (as well as the inversion) cannot be meaningfully related to "F1 Work", since "Work" cannot have text passages. As a result, "Work" was deleted from the domain of "r10 has text passage".
    /// 			- "r10" is now also no longer related to "F2 Expression", but to the parent class "E73 Information Object". This allows the modeling of text passages assigned to entities outside the narrow definition of the class "Expression" - since " Expression" by no means covers all written documents.
    /// 			- In domains/ranges throughout the model, "F2 Expression" was replaced with "E73 Information Object".
    /// 			- Erlangen-CRM and the related serialization of FRBRoo were replaced.
    /// 			- "INT0" in labels was replaced with "INT".
    /// 			- owl:import was deleted.
    /// 			- All named individuals were deleted. (2022-10) "</para>
    /// labels<para>"INTRO beta202210"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202210">https://w3id.org/lso/intro/beta202210</seealso>
    let ``lso/intro/beta202210`` =
        Prefixed_Name(w3id, "lso/intro/beta202210") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202304</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lrmoo:F2_Expression</para>
    ///   <para>"Changes from version beta202210 to version beta202304:
    /// 			- A new property R16_incorporates and its inverse have been added to link the INT16_Segment - an E90_Symbolic_Object - to an E73_Information_Object it incorporates; a similar property already exists in CIDOC - P165_incorporates - but is limited to E73_Information_Object as a domain. A INT16_Segment can't be clearly classified as an E73_Information_Object. (2023-01)
    /// 			- A new subclass of INT9 Semantic Feature has been created: INT18 Reference.
    /// 			- "INT_Event" and "INT_State" are no longer subclasses of "INT_Plot" but sibling classes (and subclasses of "INT9_SemanticFeature") - since they are actually not a kind of plot, but rather an element in a plot. (2022-11) "</para>
    /// labels<para>"INTRO beta202304"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202304">https://w3id.org/lso/intro/beta202304</seealso>
    let ``lso/intro/beta202304`` =
        Prefixed_Name(w3id, "lso/intro/beta202304") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408</para>
    /// </summary>
    /// <remarks>
    ///   <para>lrmoo:F2_Expression</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"INTRO on GitHub: https://github.com/BOberreither/INTRO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Changes from version beta202304 to version beta202408:
    /// 			Expanded to an Intertextual, Interpictorial, and Intermedial Relations Ontology
    /// 			- Changed class INT3 Intertextual Relationship to INT3 Interrelation with subclasses intertextual, intermedial, and interpictorial relation (INT31-33).
    /// 			- Renamed class INT4 ReceptionalEntity to INT4 Feature.
    /// 			- Added INT23 Visual Feature and INT24 Textual Feature as subclasses of INT4 Feature.
    /// 			- Drastically decluttered INT10 Formal Feature.
    /// 			- Added subclass INT Textual Genre Specifics and INT Visual Genre Specifics to INT Genre Specifics; previous direct subclasses INT Dramatic Entity, INT Lyrical Entity, and INT Narratological Entity are now subclasses of INT Textual Genre Specifics.
    /// 			- Decluttered INT Pragmatic Feature, added subclass INT18 Reference.
    /// 			- Added INT Identification and INT Situation as subclasses of INT9 Semantic Feature.
    /// 			- Renamed INT6 Architextual Entity to INT6 Architext. Reduced subclasses.
    /// 			- Renamed INT11 Type of Intertextual Relationship to INT11 Type of Interrelation.
    /// 			- Renamed subclasses of INT11 Type of Interrelation, added subclasses INT34 Intermediality in Intermediality Theories and INT35 Interpictoriality in Interpictoriality Theories.
    /// 			- Renamed INT1 Text Passage to INT1 Passage; changed superclass from F2 Expression to E90 Symbolic Object.
    /// 			- Added INT21 Text Passage and INT22 Image Area as subclasses of INT1 Passage. Changed object property R10 has Text Passage to R10 has Passage, added subproperties R30 has text passage and R31 has image area.
    /// 			- Changed property domains/ranges accordingly.
    ///
    /// 			- Renamed INT Interpretament to INT Interpretation.
    /// 			- Changed R9 has preceding interpretament and inverse to R9 hasPrecedingActualization and R9 hasSubsequentActualization, changed domain/range to INT2 Actualization of Feature.
    ///
    /// 			Web Annotation Ontology Alignment:
    /// 			- Added skos:broadMatch to Properties R24 has related entity and R41 has location.
    /// 			- Added skos:broadMatch to Classes INT1 Passage, INT3 Interrelation, INT16 Segment, INT21 TextPassage, and INT22 Image Area.
    ///
    /// 			LRMoo Alignment:
    /// 			- Changed former FRBRoo classes F1 Work, F2 Expression, F22 Self-Contained Expression and F24 Publication Expression to LRMoo F1 Work, F2 Expression, and F3 Manifestation (according to mapping in LRMoo's documentation under https://cidoc-crm.org/lrmoo/sites/default/files/LRMoo_V1.0.pdf).
    /// 		"</para>
    ///   <para>"Special Thanks to: Ingo Börner, Laura Untner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"INTRO is an ontology for the fields of literary studies, art studies and intermediality studies for the representation of intertextual, interpictorial, and intermedial relations. It enables the presentation and categorization of diverse features of both textual and pictorial origin and their linking. Its subject area includes the scholarly discourse on these texts/images, interrelations, and features, insofar as research results are also understood as texts with features and relations. (For more information, see "Description")."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"INTRO beta202408"</para><para>"INTRO"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408">https://w3id.org/lso/intro/beta202408</seealso>
    let ``lso/intro/beta202408`` =
        Prefixed_Name(w3id, "lso/intro/beta202408") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mod">https://w3id.org/mod</seealso>
    let mod_ = Prefixed_Name(w3id, "mod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mod/2.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/mod/2.0">https://w3id.org/mod/2.0</seealso>
    let ``mod/2.0`` = Prefixed_Name(w3id, "mod/2.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:multidimensional-interface/ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"An RDF vocabulary to describe and facilitate the usage of a Multidimensional Interface."</para>
    /// labels<para>"RDF vocabulary to describe a Multidimensional Interface."</para></remarks>
    /// <seealso href="https://w3id.org/multidimensional-interface/ontology">https://w3id.org/multidimensional-interface/ontology</seealso>
    let ``multidimensional_interface/ontology`` =
        Prefixed_Name(w3id, "multidimensional-interface/ontology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nfdi4ing/metadata4ing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/nfdi4ing/metadata4ing">https://w3id.org/nfdi4ing/metadata4ing</seealso>
    let ``nfdi4ing/metadata4ing`` =
        Prefixed_Name(w3id, "nfdi4ing/metadata4ing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nfdi4ing/metadata4ing/first-steps-guide.md</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/nfdi4ing/metadata4ing/first-steps-guide.md">https://w3id.org/nfdi4ing/metadata4ing/first-steps-guide.md</seealso>
    let ``nfdi4ing/metadata4ing/first_steps_guide.md`` =
        Prefixed_Name(w3id, "nfdi4ing/metadata4ing/first-steps-guide.md") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nfdi4ing/metadata4ing/m4i_logo.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/nfdi4ing/metadata4ing/m4i_logo.png">https://w3id.org/nfdi4ing/metadata4ing/m4i_logo.png</seealso>
    let ``nfdi4ing/metadata4ing/m4i_logo.png`` =
        Prefixed_Name(w3id, "nfdi4ing/metadata4ing/m4i_logo.png") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nfdi4ing/metadata4ing/ontology.jsonld</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcat:Distribution</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nfdi4ing/metadata4ing/ontology.jsonld">https://w3id.org/nfdi4ing/metadata4ing/ontology.jsonld</seealso>
    let ``nfdi4ing/metadata4ing/ontology.jsonld`` =
        Prefixed_Name(w3id, "nfdi4ing/metadata4ing/ontology.jsonld") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nfdi4ing/metadata4ing/ontology.nt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcat:Distribution</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nfdi4ing/metadata4ing/ontology.nt">https://w3id.org/nfdi4ing/metadata4ing/ontology.nt</seealso>
    let ``nfdi4ing/metadata4ing/ontology.nt`` =
        Prefixed_Name(w3id, "nfdi4ing/metadata4ing/ontology.nt") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nfdi4ing/metadata4ing/ontology.ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcat:Distribution</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nfdi4ing/metadata4ing/ontology.ttl">https://w3id.org/nfdi4ing/metadata4ing/ontology.ttl</seealso>
    let ``nfdi4ing/metadata4ing/ontology.ttl`` =
        Prefixed_Name(w3id, "nfdi4ing/metadata4ing/ontology.ttl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nfdi4ing/metadata4ing/ontology.xml</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcat:Distribution</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nfdi4ing/metadata4ing/ontology.xml">https://w3id.org/nfdi4ing/metadata4ing/ontology.xml</seealso>
    let ``nfdi4ing/metadata4ing/ontology.xml`` =
        Prefixed_Name(w3id, "nfdi4ing/metadata4ing/ontology.xml") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This is the FAIRnets Ontology. Designed by the AIFB (http://www.aifb.kit.edu).
    /// It enables to formalize Artificial Neural Networks in RDF, making it possible to represent existing Neural Networks according the FAIR principles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The FAIRnets Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology">https://w3id.org/nno/ontology</seealso>
    let ``nno/ontology`` = Prefixed_Name(w3id, "nno/ontology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/Notification/Severity/PerceivedSeverity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/Notification/Severity/PerceivedSeverity">https://w3id.org/noria/Notification/Severity/PerceivedSeverity</seealso>
    let ``noria/Notification/Severity/PerceivedSeverity`` =
        Prefixed_Name(w3id, "noria/Notification/Severity/PerceivedSeverity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/doc/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/doc/">https://w3id.org/noria/doc/</seealso>
    let ``noria/doc/`` = Prefixed_Name(w3id, "noria/doc/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/ChangeRequest/category</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/ChangeRequest/category">https://w3id.org/noria/kos/ChangeRequest/category</seealso>
    let ``noria/kos/ChangeRequest/category`` =
        Prefixed_Name(w3id, "noria/kos/ChangeRequest/category") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/ChangeRequest/cause</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/ChangeRequest/cause">https://w3id.org/noria/kos/ChangeRequest/cause</seealso>
    let ``noria/kos/ChangeRequest/cause`` =
        Prefixed_Name(w3id, "noria/kos/ChangeRequest/cause") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/ChangeRequest/specification</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/ChangeRequest/specification">https://w3id.org/noria/kos/ChangeRequest/specification</seealso>
    let ``noria/kos/ChangeRequest/specification`` =
        Prefixed_Name(w3id, "noria/kos/ChangeRequest/specification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/ChangeRequest/status</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/ChangeRequest/status">https://w3id.org/noria/kos/ChangeRequest/status</seealso>
    let ``noria/kos/ChangeRequest/status`` =
        Prefixed_Name(w3id, "noria/kos/ChangeRequest/status") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/ChangeRequest/type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/ChangeRequest/type">https://w3id.org/noria/kos/ChangeRequest/type</seealso>
    let ``noria/kos/ChangeRequest/type`` =
        Prefixed_Name(w3id, "noria/kos/ChangeRequest/type") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/Resource/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/Resource/">https://w3id.org/noria/kos/Resource/</seealso>
    let ``noria/kos/Resource/`` =
        Prefixed_Name(w3id, "noria/kos/Resource/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/Resource/AdministrativeState</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/Resource/AdministrativeState">https://w3id.org/noria/kos/Resource/AdministrativeState</seealso>
    let ``noria/kos/Resource/AdministrativeState`` =
        Prefixed_Name(w3id, "noria/kos/Resource/AdministrativeState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/Resource/LifecycleState</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/Resource/LifecycleState">https://w3id.org/noria/kos/Resource/LifecycleState</seealso>
    let ``noria/kos/Resource/LifecycleState`` =
        Prefixed_Name(w3id, "noria/kos/Resource/LifecycleState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/Resource/OperationalState</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/Resource/OperationalState">https://w3id.org/noria/kos/Resource/OperationalState</seealso>
    let ``noria/kos/Resource/OperationalState`` =
        Prefixed_Name(w3id, "noria/kos/Resource/OperationalState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/Resource/type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/Resource/type">https://w3id.org/noria/kos/Resource/type</seealso>
    let ``noria/kos/Resource/type`` =
        Prefixed_Name(w3id, "noria/kos/Resource/type") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/category</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/category">https://w3id.org/noria/kos/TroubleTicket/category</seealso>
    let ``noria/kos/TroubleTicket/category`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/category") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/commentType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/commentType">https://w3id.org/noria/kos/TroubleTicket/commentType</seealso>
    let ``noria/kos/TroubleTicket/commentType`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/commentType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/operationType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/operationType">https://w3id.org/noria/kos/TroubleTicket/operationType</seealso>
    let ``noria/kos/TroubleTicket/operationType`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/operationType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/origin</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/origin">https://w3id.org/noria/kos/TroubleTicket/origin</seealso>
    let ``noria/kos/TroubleTicket/origin`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/origin") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/priority</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/priority">https://w3id.org/noria/kos/TroubleTicket/priority</seealso>
    let ``noria/kos/TroubleTicket/priority`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/priority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/problemResponsibility</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/problemResponsibility">https://w3id.org/noria/kos/TroubleTicket/problemResponsibility</seealso>
    let ``noria/kos/TroubleTicket/problemResponsibility`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/problemResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/severity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/severity">https://w3id.org/noria/kos/TroubleTicket/severity</seealso>
    let ``noria/kos/TroubleTicket/severity`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/severity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/status</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/status">https://w3id.org/noria/kos/TroubleTicket/status</seealso>
    let ``noria/kos/TroubleTicket/status`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/status") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/trouble-category</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/trouble-category">https://w3id.org/noria/kos/TroubleTicket/trouble-category</seealso>
    let ``noria/kos/TroubleTicket/trouble_category`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/trouble-category") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/type">https://w3id.org/noria/kos/TroubleTicket/type</seealso>
    let ``noria/kos/TroubleTicket/type`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/type") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/TroubleTicket/urgency</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/TroubleTicket/urgency">https://w3id.org/noria/kos/TroubleTicket/urgency</seealso>
    let ``noria/kos/TroubleTicket/urgency`` =
        Prefixed_Name(w3id, "noria/kos/TroubleTicket/urgency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/application/business-importance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/application/business-importance">https://w3id.org/noria/kos/application/business-importance</seealso>
    let ``noria/kos/application/business_importance`` =
        Prefixed_Name(w3id, "noria/kos/application/business-importance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/application/sla-level</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/application/sla-level">https://w3id.org/noria/kos/application/sla-level</seealso>
    let ``noria/kos/application/sla_level`` =
        Prefixed_Name(w3id, "noria/kos/application/sla-level") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/application/status</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/application/status">https://w3id.org/noria/kos/application/status</seealso>
    let ``noria/kos/application/status`` =
        Prefixed_Name(w3id, "noria/kos/application/status") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/application/type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/application/type">https://w3id.org/noria/kos/application/type</seealso>
    let ``noria/kos/application/type`` =
        Prefixed_Name(w3id, "noria/kos/application/type") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/org/agent-contact-method</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/org/agent-contact-method">https://w3id.org/noria/kos/org/agent-contact-method</seealso>
    let ``noria/kos/org/agent_contact_method`` =
        Prefixed_Name(w3id, "noria/kos/org/agent-contact-method") |> PrefixedName

    /// <summary>
    ///   <para>w3id:noria/kos/service/type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/noria/kos/service/type">https://w3id.org/noria/kos/service/type</seealso>
    let ``noria/kos/service/type`` =
        Prefixed_Name(w3id, "noria/kos/service/type") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RA2LEhdLOYY_c9YgGIwu9TrzHVFPQcpE2vMnAbPghQY60</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RA2LEhdLOYY_c9YgGIwu9TrzHVFPQcpE2vMnAbPghQY60">https://w3id.org/np/RA2LEhdLOYY_c9YgGIwu9TrzHVFPQcpE2vMnAbPghQY60</seealso>
    let ``np/RA2LEhdLOYY_c9YgGIwu9TrzHVFPQcpE2vMnAbPghQY60`` =
        Prefixed_Name(w3id, "np/RA2LEhdLOYY_c9YgGIwu9TrzHVFPQcpE2vMnAbPghQY60") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RA6E9BH7J5qMYnuL7Kgys4Vsz25AKIAHtSQ78tcXFIlTc</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RA6E9BH7J5qMYnuL7Kgys4Vsz25AKIAHtSQ78tcXFIlTc">https://w3id.org/np/RA6E9BH7J5qMYnuL7Kgys4Vsz25AKIAHtSQ78tcXFIlTc</seealso>
    let ``np/RA6E9BH7J5qMYnuL7Kgys4Vsz25AKIAHtSQ78tcXFIlTc`` =
        Prefixed_Name(w3id, "np/RA6E9BH7J5qMYnuL7Kgys4Vsz25AKIAHtSQ78tcXFIlTc") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RA9jYlusATe999AN0jb6fn4eR_H4Q23xhnwU4xSwuUxQw</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RA9jYlusATe999AN0jb6fn4eR_H4Q23xhnwU4xSwuUxQw">https://w3id.org/np/RA9jYlusATe999AN0jb6fn4eR_H4Q23xhnwU4xSwuUxQw</seealso>
    let ``np/RA9jYlusATe999AN0jb6fn4eR_H4Q23xhnwU4xSwuUxQw`` =
        Prefixed_Name(w3id, "np/RA9jYlusATe999AN0jb6fn4eR_H4Q23xhnwU4xSwuUxQw") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RAD3_KmaQcSOOQTOKOsrwahi56Ib8pKMRlKfhylozW-UQ</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RAD3_KmaQcSOOQTOKOsrwahi56Ib8pKMRlKfhylozW-UQ">https://w3id.org/np/RAD3_KmaQcSOOQTOKOsrwahi56Ib8pKMRlKfhylozW-UQ</seealso>
    let ``np/RAD3_KmaQcSOOQTOKOsrwahi56Ib8pKMRlKfhylozW_UQ`` =
        Prefixed_Name(w3id, "np/RAD3_KmaQcSOOQTOKOsrwahi56Ib8pKMRlKfhylozW-UQ") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RAU7pbHsOVgltc5Az1pOuNSV4cjI-DDWqoRJyAVhKvUus</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RAU7pbHsOVgltc5Az1pOuNSV4cjI-DDWqoRJyAVhKvUus">https://w3id.org/np/RAU7pbHsOVgltc5Az1pOuNSV4cjI-DDWqoRJyAVhKvUus</seealso>
    let ``np/RAU7pbHsOVgltc5Az1pOuNSV4cjI_DDWqoRJyAVhKvUus`` =
        Prefixed_Name(w3id, "np/RAU7pbHsOVgltc5Az1pOuNSV4cjI-DDWqoRJyAVhKvUus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RAZIs-6LyJuxrn-osVbEdxEoXmGsC1g-8m3n8LYAZ6sUI</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RAZIs-6LyJuxrn-osVbEdxEoXmGsC1g-8m3n8LYAZ6sUI">https://w3id.org/np/RAZIs-6LyJuxrn-osVbEdxEoXmGsC1g-8m3n8LYAZ6sUI</seealso>
    let ``np/RAZIs_6LyJuxrn_osVbEdxEoXmGsC1g_8m3n8LYAZ6sUI`` =
        Prefixed_Name(w3id, "np/RAZIs-6LyJuxrn-osVbEdxEoXmGsC1g-8m3n8LYAZ6sUI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RAcku4ZQ6KWKFF2uLthK3mqCCNfWbrEeN643SVXwjXseE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RAcku4ZQ6KWKFF2uLthK3mqCCNfWbrEeN643SVXwjXseE">https://w3id.org/np/RAcku4ZQ6KWKFF2uLthK3mqCCNfWbrEeN643SVXwjXseE</seealso>
    let ``np/RAcku4ZQ6KWKFF2uLthK3mqCCNfWbrEeN643SVXwjXseE`` =
        Prefixed_Name(w3id, "np/RAcku4ZQ6KWKFF2uLthK3mqCCNfWbrEeN643SVXwjXseE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RAelRRiQeq2oSXNR-qqrB5dQ6g7Lait55srza_sfz6Jzs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RAelRRiQeq2oSXNR-qqrB5dQ6g7Lait55srza_sfz6Jzs">https://w3id.org/np/RAelRRiQeq2oSXNR-qqrB5dQ6g7Lait55srza_sfz6Jzs</seealso>
    let ``np/RAelRRiQeq2oSXNR_qqrB5dQ6g7Lait55srza_sfz6Jzs`` =
        Prefixed_Name(w3id, "np/RAelRRiQeq2oSXNR-qqrB5dQ6g7Lait55srza_sfz6Jzs") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RAq7ctp_pHq3u76I54CU9S4WA4L9wQFCnmj3DJyrfrL58</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RAq7ctp_pHq3u76I54CU9S4WA4L9wQFCnmj3DJyrfrL58">https://w3id.org/np/RAq7ctp_pHq3u76I54CU9S4WA4L9wQFCnmj3DJyrfrL58</seealso>
    let ``np/RAq7ctp_pHq3u76I54CU9S4WA4L9wQFCnmj3DJyrfrL58`` =
        Prefixed_Name(w3id, "np/RAq7ctp_pHq3u76I54CU9S4WA4L9wQFCnmj3DJyrfrL58") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RAqbZ03A1F0UPJmpa6d_r_uRUp46nmcwN8Yep2Rgiy8b4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RAqbZ03A1F0UPJmpa6d_r_uRUp46nmcwN8Yep2Rgiy8b4">https://w3id.org/np/RAqbZ03A1F0UPJmpa6d_r_uRUp46nmcwN8Yep2Rgiy8b4</seealso>
    let ``np/RAqbZ03A1F0UPJmpa6d_r_uRUp46nmcwN8Yep2Rgiy8b4`` =
        Prefixed_Name(w3id, "np/RAqbZ03A1F0UPJmpa6d_r_uRUp46nmcwN8Yep2Rgiy8b4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RAsiMOcZpJwtQVyiIBvn5-K1AvCcXmU8axm9VY4A7AY-k</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RAsiMOcZpJwtQVyiIBvn5-K1AvCcXmU8axm9VY4A7AY-k">https://w3id.org/np/RAsiMOcZpJwtQVyiIBvn5-K1AvCcXmU8axm9VY4A7AY-k</seealso>
    let ``np/RAsiMOcZpJwtQVyiIBvn5_K1AvCcXmU8axm9VY4A7AY_k`` =
        Prefixed_Name(w3id, "np/RAsiMOcZpJwtQVyiIBvn5-K1AvCcXmU8axm9VY4A7AY-k") |> PrefixedName

    /// <summary>
    ///   <para>w3id:np/RAxK3wEoSabXMV2_s24gd27O8rzsUFceYeMKn5s04cnkk</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/np/RAxK3wEoSabXMV2_s24gd27O8rzsUFceYeMKn5s04cnkk">https://w3id.org/np/RAxK3wEoSabXMV2_s24gd27O8rzsUFceYeMKn5s04cnkk</seealso>
    let ``np/RAxK3wEoSabXMV2_s24gd27O8rzsUFceYeMKn5s04cnkk`` =
        Prefixed_Name(w3id, "np/RAxK3wEoSabXMV2_s24gd27O8rzsUFceYeMKn5s04cnkk") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"An ontology for describing software and their links to inputs, outputs and variables. The ontology extends schema.org and codemeta vocabularies"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sd">https://w3id.org/okn/o/sd</seealso>
    let ``okn/o/sd`` = Prefixed_Name(w3id, "okn/o/sd") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd/1.8.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd/1.8.0">https://w3id.org/okn/o/sd/1.8.0</seealso>
    let ``okn/o/sd/1.8.0`` = Prefixed_Name(w3id, "okn/o/sd/1.8.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd/1.9.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd/1.9.0">https://w3id.org/okn/o/sd/1.9.0</seealso>
    let ``okn/o/sd/1.9.0`` = Prefixed_Name(w3id, "okn/o/sd/1.9.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sdm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm">https://w3id.org/okn/o/sdm</seealso>
    let ``okn/o/sdm`` = Prefixed_Name(w3id, "okn/o/sdm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sdm/1.7.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm/1.7.0">https://w3id.org/okn/o/sdm/1.7.0</seealso>
    let ``okn/o/sdm/1.7.0`` = Prefixed_Name(w3id, "okn/o/sdm/1.7.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:omg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/omg">https://w3id.org/omg</seealso>
    let omg = Prefixed_Name(w3id, "omg") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Standard</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ontouml">https://w3id.org/ontouml</seealso>
    let ontouml = Prefixed_Name(w3id, "ontouml") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>dcterms:Standard</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary">https://w3id.org/ontouml-models/vocabulary</seealso>
    let ``ontouml_models/vocabulary`` =
        Prefixed_Name(w3id, "ontouml-models/vocabulary") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary/docs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary/docs">https://w3id.org/ontouml-models/vocabulary/docs</seealso>
    let ``ontouml_models/vocabulary/docs`` =
        Prefixed_Name(w3id, "ontouml-models/vocabulary/docs") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary/git</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary/git">https://w3id.org/ontouml-models/vocabulary/git</seealso>
    let ``ontouml_models/vocabulary/git`` =
        Prefixed_Name(w3id, "ontouml-models/vocabulary/git") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary/v1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary/v1.0.0">https://w3id.org/ontouml-models/vocabulary/v1.0.0</seealso>
    let ``ontouml_models/vocabulary/v1.0.0`` =
        Prefixed_Name(w3id, "ontouml-models/vocabulary/v1.0.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary/v1.1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary/v1.1.0">https://w3id.org/ontouml-models/vocabulary/v1.1.0</seealso>
    let ``ontouml_models/vocabulary/v1.1.0`` =
        Prefixed_Name(w3id, "ontouml-models/vocabulary/v1.1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml/metamodel/v1.1.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ontouml/metamodel/v1.1.1">https://w3id.org/ontouml/metamodel/v1.1.1</seealso>
    let ``ontouml/metamodel/v1.1.1`` =
        Prefixed_Name(w3id, "ontouml/metamodel/v1.1.1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml/vocabulary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ontouml/vocabulary">https://w3id.org/ontouml/vocabulary</seealso>
    let ``ontouml/vocabulary`` =
        Prefixed_Name(w3id, "ontouml/vocabulary") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml/vocabulary/docs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ontouml/vocabulary/docs">https://w3id.org/ontouml/vocabulary/docs</seealso>
    let ``ontouml/vocabulary/docs`` =
        Prefixed_Name(w3id, "ontouml/vocabulary/docs") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml/vocabulary/v1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ontouml/vocabulary/v1.0.0">https://w3id.org/ontouml/vocabulary/v1.0.0</seealso>
    let ``ontouml/vocabulary/v1.0.0`` =
        Prefixed_Name(w3id, "ontouml/vocabulary/v1.0.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml/vocabulary/v1.1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/ontouml/vocabulary/v1.1.0">https://w3id.org/ontouml/vocabulary/v1.1.0</seealso>
    let ``ontouml/vocabulary/v1.1.0`` =
        Prefixed_Name(w3id, "ontouml/vocabulary/v1.1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:opentrafficlights</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Document</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/opentrafficlights">https://w3id.org/opentrafficlights</seealso>
    let opentrafficlights = Prefixed_Name(w3id, "opentrafficlights") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/optimar">https://w3id.org/optimar</seealso>
    let optimar = Prefixed_Name(w3id, "optimar") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar/0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/optimar/0.2">https://w3id.org/optimar/0.2</seealso>
    let ``optimar/0.2`` = Prefixed_Name(w3id, "optimar/0.2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar/1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/optimar/1.0">https://w3id.org/optimar/1.0</seealso>
    let ``optimar/1.0`` = Prefixed_Name(w3id, "optimar/1.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/1.1.0/okh</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/1.1.0/okh">https://w3id.org/oseg/ont/1.1.0/okh</seealso>
    let ``oseg/ont/1.1.0/okh`` =
        Prefixed_Name(w3id, "oseg/ont/1.1.0/okh") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh">https://w3id.org/oseg/ont/okh</seealso>
    let ``oseg/ont/okh`` = Prefixed_Name(w3id, "oseg/ont/okh") |> PrefixedName
    /// <summary>
    ///   <para>w3id:peco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/peco">https://w3id.org/peco</seealso>
    let peco = Prefixed_Name(w3id, "peco") |> PrefixedName
    /// <summary>
    ///   <para>w3id:peco/0.0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/peco/0.0.1">https://w3id.org/peco/0.0.1</seealso>
    let ``peco/0.0.1`` = Prefixed_Name(w3id, "peco/0.0.1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:peco/1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/peco/1.0.0">https://w3id.org/peco/1.0.0</seealso>
    let ``peco/1.0.0`` = Prefixed_Name(w3id, "peco/1.0.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:people/brechtvdv/#me</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/people/brechtvdv/#me">https://w3id.org/people/brechtvdv/#me</seealso>
    let ``people/brechtvdv/#me`` =
        Prefixed_Name(w3id, "people/brechtvdv/#me") |> PrefixedName

    /// <summary>
    ///   <para>w3id:people/franckmichel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/people/franckmichel">https://w3id.org/people/franckmichel</seealso>
    let ``people/franckmichel`` =
        Prefixed_Name(w3id, "people/franckmichel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:people/gatemezing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/people/gatemezing">https://w3id.org/people/gatemezing</seealso>
    let ``people/gatemezing`` = Prefixed_Name(w3id, "people/gatemezing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:people/idafensp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/people/idafensp">https://w3id.org/people/idafensp</seealso>
    let ``people/idafensp`` = Prefixed_Name(w3id, "people/idafensp") |> PrefixedName
    /// <summary>
    ///   <para>w3id:people/mpoveda</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/people/mpoveda">https://w3id.org/people/mpoveda</seealso>
    let ``people/mpoveda`` = Prefixed_Name(w3id, "people/mpoveda") |> PrefixedName
    /// <summary>
    ///   <para>w3id:people/mpoveda/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/people/mpoveda/">https://w3id.org/people/mpoveda/</seealso>
    let ``people/mpoveda/`` = Prefixed_Name(w3id, "people/mpoveda/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:people/ralbertoni/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/people/ralbertoni/">https://w3id.org/people/ralbertoni/</seealso>
    let ``people/ralbertoni/`` =
        Prefixed_Name(w3id, "people/ralbertoni/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pghdprovo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Patient Generated Health Data Provenance Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/pghdprovo">https://w3id.org/pghdprovo</seealso>
    let pghdprovo = Prefixed_Name(w3id, "pghdprovo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pghdprovo/1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/pghdprovo/1.0">https://w3id.org/pghdprovo/1.0</seealso>
    let ``pghdprovo/1.0`` = Prefixed_Name(w3id, "pghdprovo/1.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Procedural Knowledge Ontology (PKO)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko">https://w3id.org/pko</seealso>
    let pko = Prefixed_Name(w3id, "pko") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko/0.1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/pko/0.1.0">https://w3id.org/pko/0.1.0</seealso>
    let ``pko/0.1.0`` = Prefixed_Name(w3id, "pko/0.1.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko/1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/pko/1.0.0">https://w3id.org/pko/1.0.0</seealso>
    let ``pko/1.0.0`` = Prefixed_Name(w3id, "pko/1.0.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"-Version 2.0.1: minor edits and additions to the ontology metadata to reflect LOV requirements.
    /// 									-Version 2.0: added classes and relationships to model the Implementation stage of an AI system
    /// 									-Version 1.1: creation, models the Design stage of an AI system"</para>
    ///   <para>"To contact the RAInS team, please send an email to therainsproject [at] gmail [dot] com"</para>
    /// labels<para>"The RAInS Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/rains">https://w3id.org/rains</seealso>
    let rains = Prefixed_Name(w3id, "rains") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rdf-connect/ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>foaf:Person</para>
    ///   <para>"An ontology for describing programming language-specific runners, processors and pipelines in RDF-based data processing frameworks."</para>
    /// labels<para>"RDF Connect Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect/ontology">https://w3id.org/rdf-connect/ontology</seealso>
    let ``rdf_connect/ontology`` =
        Prefixed_Name(w3id, "rdf-connect/ontology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:react</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/react">https://w3id.org/react</seealso>
    let react = Prefixed_Name(w3id, "react") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation">https://w3id.org/riverbench/schema/documentation</seealso>
    let ``riverbench/schema/documentation`` =
        Prefixed_Name(w3id, "riverbench/schema/documentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/documentation/dev</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation/dev">https://w3id.org/riverbench/schema/documentation/dev</seealso>
    let ``riverbench/schema/documentation/dev`` =
        Prefixed_Name(w3id, "riverbench/schema/documentation/dev") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata">https://w3id.org/riverbench/schema/metadata</seealso>
    let ``riverbench/schema/metadata`` =
        Prefixed_Name(w3id, "riverbench/schema/metadata") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata/dev</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata/dev">https://w3id.org/riverbench/schema/metadata/dev</seealso>
    let ``riverbench/schema/metadata/dev`` =
        Prefixed_Name(w3id, "riverbench/schema/metadata/dev") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/conformsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/conformsTo">https://w3id.org/roh/mirror/dc/terms/conformsTo</seealso>
    let ``roh/mirror/dc/terms/conformsTo`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/conformsTo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/created">https://w3id.org/roh/mirror/dc/terms/created</seealso>
    let ``roh/mirror/dc/terms/created`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/created") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/creator">https://w3id.org/roh/mirror/dc/terms/creator</seealso>
    let ``roh/mirror/dc/terms/creator`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/creator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/description">https://w3id.org/roh/mirror/dc/terms/description</seealso>
    let ``roh/mirror/dc/terms/description`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/description") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/identifier">https://w3id.org/roh/mirror/dc/terms/identifier</seealso>
    let ``roh/mirror/dc/terms/identifier`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/identifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/issued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/issued">https://w3id.org/roh/mirror/dc/terms/issued</seealso>
    let ``roh/mirror/dc/terms/issued`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/issued") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/language">https://w3id.org/roh/mirror/dc/terms/language</seealso>
    let ``roh/mirror/dc/terms/language`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/language") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/license</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/license">https://w3id.org/roh/mirror/dc/terms/license</seealso>
    let ``roh/mirror/dc/terms/license`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/license") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/publisher">https://w3id.org/roh/mirror/dc/terms/publisher</seealso>
    let ``roh/mirror/dc/terms/publisher`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/publisher") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/rights">https://w3id.org/roh/mirror/dc/terms/rights</seealso>
    let ``roh/mirror/dc/terms/rights`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/rights") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/rightsHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/rightsHolder">https://w3id.org/roh/mirror/dc/terms/rightsHolder</seealso>
    let ``roh/mirror/dc/terms/rightsHolder`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/rightsHolder") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/source">https://w3id.org/roh/mirror/dc/terms/source</seealso>
    let ``roh/mirror/dc/terms/source`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/source") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/title">https://w3id.org/roh/mirror/dc/terms/title</seealso>
    let ``roh/mirror/dc/terms/title`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/title") |> PrefixedName

    /// <summary>
    ///   <para>w3id:roh/mirror/dc/terms/type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/roh/mirror/dc/terms/type">https://w3id.org/roh/mirror/dc/terms/type</seealso>
    let ``roh/mirror/dc/terms/type`` =
        Prefixed_Name(w3id, "roh/mirror/dc/terms/type") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sao</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"To contact the RAInS team, please send an email to therainsproject [at] gmail [dot] com"</para>
    ///   <para>"-Version 1.0.1: minor edits and additions to the ontology metadata to reflect LOV requirements
    /// 									-Version 1: creation"</para>
    /// labels<para>"The System Accountability Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sao">https://w3id.org/sao</seealso>
    let sao = Prefixed_Name(w3id, "sao") |> PrefixedName
    /// <summary>
    ///   <para>w3id:saref#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/saref#">https://w3id.org/saref#</seealso>
    let ``saref#`` = Prefixed_Name(w3id, "saref#") |> PrefixedName
    /// <summary>
    ///   <para>w3id:saref#Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device responsible for moving or controlling a mechanism or system by performing an actuating function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Actuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/saref#Actuator">https://w3id.org/saref#Actuator</seealso>
    let ``saref#Actuator`` = Prefixed_Name(w3id, "saref#Actuator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:saref#Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A directive that a device must support to perform a certain function. A command may act upon a state, but does not necessarily act upon a state. For example, the ON command acts upon the ON/OFF state, but the GET command does not act upon any state, it simply gives a directive to retrieve a certain value. We propose here a list of commands that are relevant for the purpose of SAREF, but this list can be extended."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Command"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/saref#Command">https://w3id.org/saref#Command</seealso>
    let ``saref#Command`` = Prefixed_Name(w3id, "saref#Command") |> PrefixedName
    /// <summary>
    ///   <para>w3id:saref#Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tangible object designed to accomplish a particular task in households, common public buildings or offices. In order to accomplish this task, the device performs one or more functions. For example, a washing machine is designed to wash (task) and to accomplish this task it performs a start and stop function. Devices can be structured in categories (subclasses) that reflect the different domain in which a device is used, e.g., smart appliances domain (subclass FunctionRelated) vs. building domain (subclass BuildingRelated) vs. smart grid domain (subclass EnergyRelated). New categories can be defined,if needed, to reflect other differences, for example different points of view, such as the point of view of the device's user vs. the point of view of the device's manufacturer. We propose a list of devices that are relevant for the purpose of SAREF, but this list can be extended."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A tangible object designed to accomplish a particular task in households, common public buildings or offices. In order to accomplish this task, the device performs one or more functions. For example, a washing machine is designed to wash (task) and to accomplish this task it performs the start and stop function."</para>
    /// labels<para>"Device"</para><para>"Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/saref#Device">https://w3id.org/saref#Device</seealso>
    let ``saref#Device`` = Prefixed_Name(w3id, "saref#Device") |> PrefixedName
    /// <summary>
    ///   <para>w3id:saref#Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The functionality necessary to accomplish the task for which a Device is designed. A device can be designed to perform more than one function. Functions can be structured in categories (subclasses) that reflect different points of view, for example, considering the specific application area for which a function can be used (e.g., light, temperature, motion, heat, power, etc.), or the capability that a function can support (e.g., receive, reply, notify, etc.), and so forth. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Function"</para></remarks>
    /// <seealso href="https://w3id.org/saref#Function">https://w3id.org/saref#Function</seealso>
    let ``saref#Function`` = Prefixed_Name(w3id, "saref#Function") |> PrefixedName
    /// <summary>
    ///   <para>w3id:saref#HVAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Heating, Ventilation and Air Conditioning (HVAC) device that provides indoor environmental comfort. A saref:HVAC is typically used to accomplish saref:Comfort."</para>
    /// labels<para>"HVAC"</para></remarks>
    /// <seealso href="https://w3id.org/saref#HVAC">https://w3id.org/saref#HVAC</seealso>
    let ``saref#HVAC`` = Prefixed_Name(w3id, "saref#HVAC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:saref#Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An aspect of an entity that can be observable by a sensor."</para>
    /// labels<para>"Property"</para></remarks>
    /// <seealso href="https://w3id.org/saref#Property">https://w3id.org/saref#Property</seealso>
    let ``saref#Property`` = Prefixed_Name(w3id, "saref#Property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:saref#Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device that detects and responds to events or changes in the physical environment such as light, motion, or temperature changes. Further, a device of category saref:Sensor that performs a saref:SensingFunction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/saref#Sensor">https://w3id.org/saref#Sensor</seealso>
    let ``saref#Sensor`` = Prefixed_Name(w3id, "saref#Sensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:saref#UnitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The unit of measure is a standard for measurement of a quantity, such as a Property. For example, Power is a property and Watt is a unit of power that represents a definite predetermined power: when we say 10 Watt, we actually mean 10 times the definite predetermined power called "watt". Our definition is based on the definition of unit of measure in the Ontology of units of Measure (OM). We propose here a list of some units of measure that are relevant for the purpose of the Smart Appliances ontology, but this list can be extended."</para>
    /// labels<para>"Unit of measure"</para></remarks>
    /// <seealso href="https://w3id.org/saref#UnitOfMeasure">https://w3id.org/saref#UnitOfMeasure</seealso>
    let ``saref#UnitOfMeasure`` =
        Prefixed_Name(w3id, "saref#UnitOfMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:saref#hasCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between an entity (such as a function) and a command"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has command"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/saref#hasCommand">https://w3id.org/saref#hasCommand</seealso>
    let ``saref#hasCommand`` = Prefixed_Name(w3id, "saref#hasCommand") |> PrefixedName
    /// <summary>
    ///   <para>w3id:saref#hasFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship identifying the type of function of a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/saref#hasFunction">https://w3id.org/saref#hasFunction</seealso>
    let ``saref#hasFunction`` = Prefixed_Name(w3id, "saref#hasFunction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:saref#isCommandOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a command and a function."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is command of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/saref#isCommandOf">https://w3id.org/saref#isCommandOf</seealso>
    let ``saref#isCommandOf`` = Prefixed_Name(w3id, "saref#isCommandOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/sbeo">https://w3id.org/sbeo</seealso>
    let sbeo = Prefixed_Name(w3id, "sbeo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:scholarlydata/ontology/conference-ontology.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/scholarlydata/ontology/conference-ontology.owl">https://w3id.org/scholarlydata/ontology/conference-ontology.owl</seealso>
    let ``scholarlydata/ontology/conference_ontology.owl`` =
        Prefixed_Name(w3id, "scholarlydata/ontology/conference-ontology.owl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"AI Risk Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO">https://w3id.org/AIRO</seealso>
    let AIRO = Prefixed_Name(w3id, "AIRO") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AIApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the application and usage of the AI system."</para>
    /// labels<para>"AI Application"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AIApplication">https://w3id.org/AIRO#AIApplication</seealso>
    let ``AIRO#AIApplication`` =
        Prefixed_Name(w3id, "AIRO#AIApplication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AIComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A functional element that constructs an AI system. [Source: ISO 22989]"</para>
    /// labels<para>"AI Component"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AIComponent">https://w3id.org/AIRO#AIComponent</seealso>
    let ``AIRO#AIComponent`` = Prefixed_Name(w3id, "AIRO#AIComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#AIDeveloper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A natural or legal person, public authority, agency or other body that develops an AI system or that has an AI system developed with a view to placing it on the market or putting it into service under its own name or trademark, whether for payment or free of charge. [Source: AI Act]"</para>
    /// labels<para>"AI Developer"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AIDeveloper">https://w3id.org/AIRO#AIDeveloper</seealso>
    let ``AIRO#AIDeveloper`` = Prefixed_Name(w3id, "AIRO#AIDeveloper") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#AIHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Hardware on which the AI system run."</para>
    /// labels<para>"AI Hardware"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AIHardware">https://w3id.org/AIRO#AIHardware</seealso>
    let ``AIRO#AIHardware`` = Prefixed_Name(w3id, "AIRO#AIHardware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AILifecyclePhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Phase of AI lifecycle which indicates evolution of the system from conception through retirement."</para>
    /// labels<para>"AI Lifecycle Phase"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AILifecyclePhase">https://w3id.org/AIRO#AILifecyclePhase</seealso>
    let ``AIRO#AILifecyclePhase`` =
        Prefixed_Name(w3id, "AIRO#AILifecyclePhase") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AISubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An AI subject is an organization or entity that is impacted by an AI system, service or product."</para>
    /// labels<para>"AI Subject"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AISubject">https://w3id.org/AIRO#AISubject</seealso>
    let ``AIRO#AISubject`` = Prefixed_Name(w3id, "AIRO#AISubject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#AISystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a software that is developed with one or more of the AI Approaches and can, for a given set of human-defined objectives, generate outputs such as content, predictions, recommendations, or decisions influencing the environments they interact with. [Source: AI Act, Art 3(1)]"</para>
    /// labels<para>"AI System"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AISystem">https://w3id.org/AIRO#AISystem</seealso>
    let ``AIRO#AISystem`` = Prefixed_Name(w3id, "AIRO#AISystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AISystemAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the degree to which a product or system provides the correct results with the needed degree of precision. [ISO 22989, 3.4.4]"</para>
    /// labels<para>"AI System Accuracy"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AISystemAccuracy">https://w3id.org/AIRO#AISystemAccuracy</seealso>
    let ``AIRO#AISystemAccuracy`` =
        Prefixed_Name(w3id, "AIRO#AISystemAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AISystemForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"refers to the forms in which AI system is placed on the market or put into service."</para>
    /// labels<para>"AI System Form"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AISystemForm">https://w3id.org/AIRO#AISystemForm</seealso>
    let ``AIRO#AISystemForm`` = Prefixed_Name(w3id, "AIRO#AISystemForm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AISystemIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents indicators for expressing properties of AI systems."</para>
    /// labels<para>"AI System Indicator"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AISystemIndicator">https://w3id.org/AIRO#AISystemIndicator</seealso>
    let ``AIRO#AISystemIndicator`` =
        Prefixed_Name(w3id, "AIRO#AISystemIndicator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AITechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the main approaches and techniques used for development of AI systems."</para>
    /// labels<para>"AI Technique"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AITechnique">https://w3id.org/AIRO#AITechnique</seealso>
    let ``AIRO#AITechnique`` = Prefixed_Name(w3id, "AIRO#AITechnique") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#AIUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any natural or legal person, public authority, agency or other body using an AI system under its authority. [Source: AI Act]"</para>
    /// labels<para>"AI User"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AIUser">https://w3id.org/AIRO#AIUser</seealso>
    let ``AIRO#AIUser`` = Prefixed_Name(w3id, "AIRO#AIUser") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Accuracy"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Accuracy">https://w3id.org/AIRO#Accuracy</seealso>
    let ``AIRO#Accuracy`` = Prefixed_Name(w3id, "AIRO#Accuracy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AdmissionTestAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the assessment of participants in tests  required for admission to educational institutions."</para>
    /// labels<para>"Admission Test Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AdmissionTestAssessment">https://w3id.org/AIRO#AdmissionTestAssessment</seealso>
    let ``AIRO#AdmissionTestAssessment`` =
        Prefixed_Name(w3id, "AIRO#AdmissionTestAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AdversarialAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"inputs designed to cause the model to make a mistake"</para>
    /// labels<para>"Adversarial Attack"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AdversarialAttack">https://w3id.org/AIRO#AdversarialAttack</seealso>
    let ``AIRO#AdversarialAttack`` =
        Prefixed_Name(w3id, "AIRO#AdversarialAttack") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AdvertisingVacancies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Advertising Vacancies"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AdvertisingVacancies">https://w3id.org/AIRO#AdvertisingVacancies</seealso>
    let ``AIRO#AdvertisingVacancies`` =
        Prefixed_Name(w3id, "AIRO#AdvertisingVacancies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Alogorithm-RelatedRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Algorithm-Related Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Alogorithm-RelatedRiskSource">https://w3id.org/AIRO#Alogorithm-RelatedRiskSource</seealso>
    let ``AIRO#Alogorithm_RelatedRiskSource`` =
        Prefixed_Name(w3id, "AIRO#Alogorithm-RelatedRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Applicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who has made an application."</para>
    /// labels<para>"Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Applicant">https://w3id.org/AIRO#Applicant</seealso>
    let ``AIRO#Applicant`` = Prefixed_Name(w3id, "AIRO#Applicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ApplicationExamination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Application Examination"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ApplicationExamination">https://w3id.org/AIRO#ApplicationExamination</seealso>
    let ``AIRO#ApplicationExamination`` =
        Prefixed_Name(w3id, "AIRO#ApplicationExamination") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ApplicationFiltering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Filtering applications for recruitment or selection of natural persons."</para>
    /// labels<para>"Application Filtering"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ApplicationFiltering">https://w3id.org/AIRO#ApplicationFiltering</seealso>
    let ``AIRO#ApplicationFiltering`` =
        Prefixed_Name(w3id, "AIRO#ApplicationFiltering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ApplicationScreening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Application Screening"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ApplicationScreening">https://w3id.org/AIRO#ApplicationScreening</seealso>
    let ``AIRO#ApplicationScreening`` =
        Prefixed_Name(w3id, "AIRO#ApplicationScreening") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ApplyingLawToFacts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the application of the law to a concrete set of facts."</para>
    /// labels<para>"Applying The Law to Facts"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ApplyingLawToFacts">https://w3id.org/AIRO#ApplyingLawToFacts</seealso>
    let ``AIRO#ApplyingLawToFacts`` =
        Prefixed_Name(w3id, "AIRO#ApplyingLawToFacts") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Approval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents approval or refusual of a request, excutation of process, etc. to prevent or mitigate a risk."</para>
    /// labels<para>"Approval"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Approval">https://w3id.org/AIRO#Approval</seealso>
    let ``AIRO#Approval`` = Prefixed_Name(w3id, "AIRO#Approval") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#AreaOfImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents areas that AI might have impact on."</para>
    /// labels<para>"Area Of Impact"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AreaOfImpact">https://w3id.org/AIRO#AreaOfImpact</seealso>
    let ``AIRO#AreaOfImpact`` = Prefixed_Name(w3id, "AIRO#AreaOfImpact") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessingHealthRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assessing Health Risk"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessingHealthRisk">https://w3id.org/AIRO#AssessingHealthRisk</seealso>
    let ``AIRO#AssessingHealthRisk`` =
        Prefixed_Name(w3id, "AIRO#AssessingHealthRisk") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessingPastCriminalBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assessing Past Criminal Behaviour"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessingPastCriminalBehaviour">https://w3id.org/AIRO#AssessingPastCriminalBehaviour</seealso>
    let ``AIRO#AssessingPastCriminalBehaviour`` =
        Prefixed_Name(w3id, "AIRO#AssessingPastCriminalBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessingRiskForPotentialVictimsOfCriminalOffences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assessing Risk For Potential Victims Of Criminal Offences"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessingRiskForPotentialVictimsOfCriminalOffences">https://w3id.org/AIRO#AssessingRiskForPotentialVictimsOfCriminalOffences</seealso>
    let ``AIRO#AssessingRiskForPotentialVictimsOfCriminalOffences`` =
        Prefixed_Name(w3id, "AIRO#AssessingRiskForPotentialVictimsOfCriminalOffences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessingRiskOfIrregularImmigration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assessing Risk Of Irregular Immigration"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessingRiskOfIrregularImmigration">https://w3id.org/AIRO#AssessingRiskOfIrregularImmigration</seealso>
    let ``AIRO#AssessingRiskOfIrregularImmigration`` =
        Prefixed_Name(w3id, "AIRO#AssessingRiskOfIrregularImmigration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessingRiskOfOffending</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assessing Risk Of Offending"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessingRiskOfOffending">https://w3id.org/AIRO#AssessingRiskOfOffending</seealso>
    let ``AIRO#AssessingRiskOfOffending`` =
        Prefixed_Name(w3id, "AIRO#AssessingRiskOfOffending") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessingRiskOfReoffending</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assessing Risk Of Reoffending"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessingRiskOfReoffending">https://w3id.org/AIRO#AssessingRiskOfReoffending</seealso>
    let ``AIRO#AssessingRiskOfReoffending`` =
        Prefixed_Name(w3id, "AIRO#AssessingRiskOfReoffending") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessingSecurityRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assessing Security Risk"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessingSecurityRisk">https://w3id.org/AIRO#AssessingSecurityRisk</seealso>
    let ``AIRO#AssessingSecurityRisk`` =
        Prefixed_Name(w3id, "AIRO#AssessingSecurityRisk") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessingTestsRequiredForAdmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assessing Tests Required For Admission"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessingTestsRequiredForAdmission">https://w3id.org/AIRO#AssessingTestsRequiredForAdmission</seealso>
    let ``AIRO#AssessingTestsRequiredForAdmission`` =
        Prefixed_Name(w3id, "AIRO#AssessingTestsRequiredForAdmission") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the use of AI systems for assessmen and evaluation."</para>
    /// labels<para>"Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Assessment">https://w3id.org/AIRO#Assessment</seealso>
    let ``AIRO#Assessment`` = Prefixed_Name(w3id, "AIRO#Assessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessmentForEducation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to assessment for education and vocational training purposes."</para>
    /// labels<para>"Assessment For Education"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessmentForEducation">https://w3id.org/AIRO#AssessmentForEducation</seealso>
    let ``AIRO#AssessmentForEducation`` =
        Prefixed_Name(w3id, "AIRO#AssessmentForEducation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessmentForRecuitment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to assessment related to employment, workers management and access to self-employment."</para>
    /// labels<para>"Assessment For Recruitment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessmentForRecuitment">https://w3id.org/AIRO#AssessmentForRecuitment</seealso>
    let ``AIRO#AssessmentForRecuitment`` =
        Prefixed_Name(w3id, "AIRO#AssessmentForRecuitment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssessmentOfEmployee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assessment Of Employee"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssessmentOfEmployee">https://w3id.org/AIRO#AssessmentOfEmployee</seealso>
    let ``AIRO#AssessmentOfEmployee`` =
        Prefixed_Name(w3id, "AIRO#AssessmentOfEmployee") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AssigningPeopleToEducationalInstitutions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assigning People To Educational Institutions"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AssigningPeopleToEducationalInstitutions">https://w3id.org/AIRO#AssigningPeopleToEducationalInstitutions</seealso>
    let ``AIRO#AssigningPeopleToEducationalInstitutions`` =
        Prefixed_Name(w3id, "AIRO#AssigningPeopleToEducationalInstitutions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AsylumApplicationExamination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Asylum Application Examination"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AsylumApplicationExamination">https://w3id.org/AIRO#AsylumApplicationExamination</seealso>
    let ``AIRO#AsylumApplicationExamination`` =
        Prefixed_Name(w3id, "AIRO#AsylumApplicationExamination") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AsylumSeeker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who has applied for asylum."</para>
    /// labels<para>"Asylum Seeker"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AsylumSeeker">https://w3id.org/AIRO#AsylumSeeker</seealso>
    let ``AIRO#AsylumSeeker`` = Prefixed_Name(w3id, "AIRO#AsylumSeeker") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Attack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Attack"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Attack">https://w3id.org/AIRO#Attack</seealso>
    let ``AIRO#Attack`` = Prefixed_Name(w3id, "AIRO#Attack") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#AutomatedControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents controls that do not involve human intervention."</para>
    /// labels<para>"Automated Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#AutomatedControl">https://w3id.org/AIRO#AutomatedControl</seealso>
    let ``AIRO#AutomatedControl`` =
        Prefixed_Name(w3id, "AIRO#AutomatedControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#BayesianEstimation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bayesian Estimation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#BayesianEstimation">https://w3id.org/AIRO#BayesianEstimation</seealso>
    let ``AIRO#BayesianEstimation`` =
        Prefixed_Name(w3id, "AIRO#BayesianEstimation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Bias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Systematic difference in treatment of certain objects, people, or groups in comparison to others [ISO 22989]"</para>
    /// labels<para>"Bias"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Bias">https://w3id.org/AIRO#Bias</seealso>
    let ``AIRO#Bias`` = Prefixed_Name(w3id, "AIRO#Bias") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#BiasConsequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents consequences related to bias."</para>
    /// labels<para>"Bias Consequence"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#BiasConsequence">https://w3id.org/AIRO#BiasConsequence</seealso>
    let ``AIRO#BiasConsequence`` =
        Prefixed_Name(w3id, "AIRO#BiasConsequence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#BiasDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represens controls that are applied to detect bias in datasets, models, algorithms, ect."</para>
    /// labels<para>"Bias Detection"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#BiasDetection">https://w3id.org/AIRO#BiasDetection</seealso>
    let ``AIRO#BiasDetection`` =
        Prefixed_Name(w3id, "AIRO#BiasDetection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#BiasedTestingDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biased Testing Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#BiasedTestingDataSet">https://w3id.org/AIRO#BiasedTestingDataSet</seealso>
    let ``AIRO#BiasedTestingDataSet`` =
        Prefixed_Name(w3id, "AIRO#BiasedTestingDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#BiasedTrainingDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biased Training Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#BiasedTrainingDataSet">https://w3id.org/AIRO#BiasedTrainingDataSet</seealso>
    let ``AIRO#BiasedTrainingDataSet`` =
        Prefixed_Name(w3id, "AIRO#BiasedTrainingDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#BiasedValidationDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biased Validation Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#BiasedValidationDataSet">https://w3id.org/AIRO#BiasedValidationDataSet</seealso>
    let ``AIRO#BiasedValidationDataSet`` =
        Prefixed_Name(w3id, "AIRO#BiasedValidationDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#BiomerticCategorisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biometric Categorisation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#BiomerticCategorisation">https://w3id.org/AIRO#BiomerticCategorisation</seealso>
    let ``AIRO#BiomerticCategorisation`` =
        Prefixed_Name(w3id, "AIRO#BiomerticCategorisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#BiometricIdnetification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Identifaction of natural persons using biometric data."</para>
    /// labels<para>"Biometric Identification"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#BiometricIdnetification">https://w3id.org/AIRO#BiometricIdnetification</seealso>
    let ``AIRO#BiometricIdnetification`` =
        Prefixed_Name(w3id, "AIRO#BiometricIdnetification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Blueprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Blueprint"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Blueprint">https://w3id.org/AIRO#Blueprint</seealso>
    let ``AIRO#Blueprint`` = Prefixed_Name(w3id, "AIRO#Blueprint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Child</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An individual human being who is below the age of 18 (according to the UN Convention on the Rights of the Child)"</para>
    /// labels<para>"Child"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Child">https://w3id.org/AIRO#Child</seealso>
    let ``AIRO#Child`` = Prefixed_Name(w3id, "AIRO#Child") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#CompetentPublicAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Competent Public Authority"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#CompetentPublicAuthority">https://w3id.org/AIRO#CompetentPublicAuthority</seealso>
    let ``AIRO#CompetentPublicAuthority`` =
        Prefixed_Name(w3id, "AIRO#CompetentPublicAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Consequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Outcome of an event affecting objectives. [Source: ISO 31000, 3.6]"</para>
    /// labels<para>"Consequence"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Consequence">https://w3id.org/AIRO#Consequence</seealso>
    let ``AIRO#Consequence`` = Prefixed_Name(w3id, "AIRO#Consequence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content generated using an AI system."</para>
    /// labels<para>"Content"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Content">https://w3id.org/AIRO#Content</seealso>
    let ``AIRO#Content`` = Prefixed_Name(w3id, "AIRO#Content") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Control</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the measure that maintains and/or modifies risk. [Source: ISO 31000, 3.8]"</para>
    /// labels<para>"Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Control">https://w3id.org/AIRO#Control</seealso>
    let ``AIRO#Control`` = Prefixed_Name(w3id, "AIRO#Control") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#CreditworthinessAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the evaluation the creditworthiness of natural persons or establishing their credit score."</para>
    /// labels<para>"Creditworthiness Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#CreditworthinessAssessment">https://w3id.org/AIRO#CreditworthinessAssessment</seealso>
    let ``AIRO#CreditworthinessAssessment`` =
        Prefixed_Name(w3id, "AIRO#CreditworthinessAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#CrimeAnalytics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to crime analytics regarding natural persons, allowing law enforcement authorities to search complex related and unrelated large data sets available in different data sources or in different data formats in order to identify unknown patterns or discover hidden relationships in the data."</para>
    /// labels<para>"Crime Analytics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#CrimeAnalytics">https://w3id.org/AIRO#CrimeAnalytics</seealso>
    let ``AIRO#CrimeAnalytics`` =
        Prefixed_Name(w3id, "AIRO#CrimeAnalytics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semsys/ns/swemls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/semsys/ns/swemls">https://w3id.org/semsys/ns/swemls</seealso>
    let ``semsys/ns/swemls`` = Prefixed_Name(w3id, "semsys/ns/swemls") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Cyberattack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cyberattack"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Cyberattack">https://w3id.org/AIRO#Cyberattack</seealso>
    let ``AIRO#Cyberattack`` = Prefixed_Name(w3id, "AIRO#Cyberattack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reinterpretable representation of information in a formalized manner suitable for communication, interpretation, or processing [Source: ISO/IEC 2382:2015, 2121272]"</para>
    /// labels<para>"Data"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Data">https://w3id.org/AIRO#Data</seealso>
    let ``AIRO#Data`` = Prefixed_Name(w3id, "AIRO#Data") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#DataAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the degree to which data has attributes that correctly represent the true value of the intended attribute of a concept or event in a specific context of use. [ISO 22989, 3.4.3]"</para>
    /// labels<para>"Data Accuracy"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DataAccuracy">https://w3id.org/AIRO#DataAccuracy</seealso>
    let ``AIRO#DataAccuracy`` = Prefixed_Name(w3id, "AIRO#DataAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DataPoisoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Attack trying to manipulate the training dataset"</para>
    /// labels<para>"Data Poisoning"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DataPoisoning">https://w3id.org/AIRO#DataPoisoning</seealso>
    let ``AIRO#DataPoisoning`` =
        Prefixed_Name(w3id, "AIRO#DataPoisoning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DataSet-RelatedRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DataSet-Related Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DataSet-RelatedRiskSource">https://w3id.org/AIRO#DataSet-RelatedRiskSource</seealso>
    let ``AIRO#DataSet_RelatedRiskSource`` =
        Prefixed_Name(w3id, "AIRO#DataSet-RelatedRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Datasheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Datasheet"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Datasheet">https://w3id.org/AIRO#Datasheet</seealso>
    let ``AIRO#Datasheet`` = Prefixed_Name(w3id, "AIRO#Datasheet") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Death</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents death of a person caused by AI."</para>
    /// labels<para>"Death"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Death">https://w3id.org/AIRO#Death</seealso>
    let ``AIRO#Death`` = Prefixed_Name(w3id, "AIRO#Death") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Decision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Decision generated by an AI system."</para>
    /// labels<para>"Decision"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Decision">https://w3id.org/AIRO#Decision</seealso>
    let ``AIRO#Decision`` = Prefixed_Name(w3id, "AIRO#Decision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DecreasedRobustness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates decreased level of system's robustness resulted from materialisation of a risk."</para>
    /// labels<para>"Decreased Robustness"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DecreasedRobustness">https://w3id.org/AIRO#DecreasedRobustness</seealso>
    let ``AIRO#DecreasedRobustness`` =
        Prefixed_Name(w3id, "AIRO#DecreasedRobustness") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DecreasedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates decreased level of security of the AI system resulted from materialisation of a risk."</para>
    /// labels<para>"Decreased Security"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DecreasedSecurity">https://w3id.org/AIRO#DecreasedSecurity</seealso>
    let ``AIRO#DecreasedSecurity`` =
        Prefixed_Name(w3id, "AIRO#DecreasedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DeepFakeDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Dectection of content that is generated using deep fake."</para>
    /// labels<para>"Deep Fake Detection"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DeepFakeDetection">https://w3id.org/AIRO#DeepFakeDetection</seealso>
    let ``AIRO#DeepFakeDetection`` =
        Prefixed_Name(w3id, "AIRO#DeepFakeDetection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Defendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who is being accused of criminal offences."</para>
    /// labels<para>"Defendant"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Defendant">https://w3id.org/AIRO#Defendant</seealso>
    let ``AIRO#Defendant`` = Prefixed_Name(w3id, "AIRO#Defendant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DegradedAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates decreased level of system's accuracy resulted from materialisation of a risk."</para>
    /// labels<para>"Degraded Accuracy"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DegradedAccuracy">https://w3id.org/AIRO#DegradedAccuracy</seealso>
    let ``AIRO#DegradedAccuracy`` =
        Prefixed_Name(w3id, "AIRO#DegradedAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DesignSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Design Specification"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DesignSpecification">https://w3id.org/AIRO#DesignSpecification</seealso>
    let ``AIRO#DesignSpecification`` =
        Prefixed_Name(w3id, "AIRO#DesignSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DetectingNon-AuthenticDocuments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Detecting Non-Authentic Documents"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DetectingNon-AuthenticDocuments">https://w3id.org/AIRO#DetectingNon-AuthenticDocuments</seealso>
    let ``AIRO#DetectingNon_AuthenticDocuments`` =
        Prefixed_Name(w3id, "AIRO#DetectingNon-AuthenticDocuments") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Detection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the use of AI systems to detect an entity, pattern, etc."</para>
    /// labels<para>"Detection"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Detection">https://w3id.org/AIRO#Detection</seealso>
    let ``AIRO#Detection`` = Prefixed_Name(w3id, "AIRO#Detection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DetectionControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents controls that are applied to detect an event."</para>
    /// labels<para>"Detection Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DetectionControl">https://w3id.org/AIRO#DetectionControl</seealso>
    let ``AIRO#DetectionControl`` =
        Prefixed_Name(w3id, "AIRO#DetectionControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DetermineCreditScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Determine Credit Score"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DetermineCreditScore">https://w3id.org/AIRO#DetermineCreditScore</seealso>
    let ``AIRO#DetermineCreditScore`` =
        Prefixed_Name(w3id, "AIRO#DetermineCreditScore") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DeterminingAccessToEducation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the purpose of determining access or assigning natural persons to educational and vocational training institutions."</para>
    /// labels<para>"Determining Access To Education"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DeterminingAccessToEducation">https://w3id.org/AIRO#DeterminingAccessToEducation</seealso>
    let ``AIRO#DeterminingAccessToEducation`` =
        Prefixed_Name(w3id, "AIRO#DeterminingAccessToEducation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DiscoveringHiddenRelationshipsRelatedToCrime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Discovering Hidden Relationships Related To Crime"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DiscoveringHiddenRelationshipsRelatedToCrime">https://w3id.org/AIRO#DiscoveringHiddenRelationshipsRelatedToCrime</seealso>
    let ``AIRO#DiscoveringHiddenRelationshipsRelatedToCrime`` =
        Prefixed_Name(w3id, "AIRO#DiscoveringHiddenRelationshipsRelatedToCrime") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DispatchingEmergencyService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Dispatching of emergency first response services, including by firefighters and medical aid."</para>
    /// labels<para>"Dispacthing Emergency Service"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DispatchingEmergencyService">https://w3id.org/AIRO#DispatchingEmergencyService</seealso>
    let ``AIRO#DispatchingEmergencyService`` =
        Prefixed_Name(w3id, "AIRO#DispatchingEmergencyService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DisruptionOfOperationOfCriticalInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents disruption of management and operation of critical infrastructure."</para>
    /// labels<para>"Disruption Of Operation Of Critical Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DisruptionOfOperationOfCriticalInfrastructure">https://w3id.org/AIRO#DisruptionOfOperationOfCriticalInfrastructure</seealso>
    let ``AIRO#DisruptionOfOperationOfCriticalInfrastructure`` =
        Prefixed_Name(w3id, "AIRO#DisruptionOfOperationOfCriticalInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#DistortionInHumanBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents adverse impacts of AI on human behaviour."</para>
    /// labels<para>"Distortion In Human Behaviour"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#DistortionInHumanBehaviour">https://w3id.org/AIRO#DistortionInHumanBehaviour</seealso>
    let ``AIRO#DistortionInHumanBehaviour`` =
        Prefixed_Name(w3id, "AIRO#DistortionInHumanBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Document"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Document">https://w3id.org/AIRO#Document</seealso>
    let ``AIRO#Document`` = Prefixed_Name(w3id, "AIRO#Document") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the sector/domain the AI system is intended to be used in."</para>
    /// labels<para>"Domain"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Domain">https://w3id.org/AIRO#Domain</seealso>
    let ``AIRO#Domain`` = Prefixed_Name(w3id, "AIRO#Domain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EUDeclarationOfConformity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EU Declaration Of Conformity"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EUDeclarationOfConformity">https://w3id.org/AIRO#EUDeclarationOfConformity</seealso>
    let ``AIRO#EUDeclarationOfConformity`` =
        Prefixed_Name(w3id, "AIRO#EUDeclarationOfConformity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EliminationControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents controls that applied to prevent an event from happening."</para>
    /// labels<para>"Elimination Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EliminationControl">https://w3id.org/AIRO#EliminationControl</seealso>
    let ``AIRO#EliminationControl`` =
        Prefixed_Name(w3id, "AIRO#EliminationControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EmotionRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the detection of the emotional state of a natural person."</para>
    /// labels<para>"Emotion Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EmotionRecognition">https://w3id.org/AIRO#EmotionRecognition</seealso>
    let ``AIRO#EmotionRecognition`` =
        Prefixed_Name(w3id, "AIRO#EmotionRecognition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Persons in work-related contractual relationships."</para>
    /// labels<para>"Employee"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Employee">https://w3id.org/AIRO#Employee</seealso>
    let ``AIRO#Employee`` = Prefixed_Name(w3id, "AIRO#Employee") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EmployeeBehaviourMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Employee Behaviour Monitoring"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EmployeeBehaviourMonitoring">https://w3id.org/AIRO#EmployeeBehaviourMonitoring</seealso>
    let ``AIRO#EmployeeBehaviourMonitoring`` =
        Prefixed_Name(w3id, "AIRO#EmployeeBehaviourMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EmployeeEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Employee Evaluation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EmployeeEvaluation">https://w3id.org/AIRO#EmployeeEvaluation</seealso>
    let ``AIRO#EmployeeEvaluation`` =
        Prefixed_Name(w3id, "AIRO#EmployeeEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EmployeeMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents purpose of monitoring and evaluating performance and behavior of employees in workplace."</para>
    /// labels<para>"Employee Monitoring"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EmployeeMonitoring">https://w3id.org/AIRO#EmployeeMonitoring</seealso>
    let ``AIRO#EmployeeMonitoring`` =
        Prefixed_Name(w3id, "AIRO#EmployeeMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EmployeePerformanceMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Employee Performance Monitoring"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EmployeePerformanceMonitoring">https://w3id.org/AIRO#EmployeePerformanceMonitoring</seealso>
    let ``AIRO#EmployeePerformanceMonitoring`` =
        Prefixed_Name(w3id, "AIRO#EmployeePerformanceMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EnvironmentOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Environment Of Use"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EnvironmentOfUse">https://w3id.org/AIRO#EnvironmentOfUse</seealso>
    let ``AIRO#EnvironmentOfUse`` =
        Prefixed_Name(w3id, "AIRO#EnvironmentOfUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EnvironmentalDamage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the deterioration of the environment caused by AI."</para>
    /// labels<para>"Environmental Damage"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EnvironmentalDamage">https://w3id.org/AIRO#EnvironmentalDamage</seealso>
    let ``AIRO#EnvironmentalDamage`` =
        Prefixed_Name(w3id, "AIRO#EnvironmentalDamage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EnvironmentalImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represent impact on the enviroment."</para>
    /// labels<para>"Environmental Impact"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EnvironmentalImpact">https://w3id.org/AIRO#EnvironmentalImpact</seealso>
    let ``AIRO#EnvironmentalImpact`` =
        Prefixed_Name(w3id, "AIRO#EnvironmentalImpact") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ErrorInDataCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Error In Data Collection"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ErrorInDataCollection">https://w3id.org/AIRO#ErrorInDataCollection</seealso>
    let ``AIRO#ErrorInDataCollection`` =
        Prefixed_Name(w3id, "AIRO#ErrorInDataCollection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ErrorInDataPrepration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Error In Data Prepration"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ErrorInDataPrepration">https://w3id.org/AIRO#ErrorInDataPrepration</seealso>
    let ``AIRO#ErrorInDataPrepration`` =
        Prefixed_Name(w3id, "AIRO#ErrorInDataPrepration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ErrorInInputData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Error In Input Data"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ErrorInInputData">https://w3id.org/AIRO#ErrorInInputData</seealso>
    let ``AIRO#ErrorInInputData`` =
        Prefixed_Name(w3id, "AIRO#ErrorInInputData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ErrorInTestingDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Error In Testing Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ErrorInTestingDataSet">https://w3id.org/AIRO#ErrorInTestingDataSet</seealso>
    let ``AIRO#ErrorInTestingDataSet`` =
        Prefixed_Name(w3id, "AIRO#ErrorInTestingDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ErrorInTrainingDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Error In Training Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ErrorInTrainingDataSet">https://w3id.org/AIRO#ErrorInTrainingDataSet</seealso>
    let ``AIRO#ErrorInTrainingDataSet`` =
        Prefixed_Name(w3id, "AIRO#ErrorInTrainingDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ErrorInValidationDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Error In Validation Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ErrorInValidationDataSet">https://w3id.org/AIRO#ErrorInValidationDataSet</seealso>
    let ``AIRO#ErrorInValidationDataSet`` =
        Prefixed_Name(w3id, "AIRO#ErrorInValidationDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EvaluatingBehaviourOfEmployee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Evaluating Behaviour Of Employee"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EvaluatingBehaviourOfEmployee">https://w3id.org/AIRO#EvaluatingBehaviourOfEmployee</seealso>
    let ``AIRO#EvaluatingBehaviourOfEmployee`` =
        Prefixed_Name(w3id, "AIRO#EvaluatingBehaviourOfEmployee") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EvaluatingPerformanceOfEmployee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Evaluating Performance Of Employee"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EvaluatingPerformanceOfEmployee">https://w3id.org/AIRO#EvaluatingPerformanceOfEmployee</seealso>
    let ``AIRO#EvaluatingPerformanceOfEmployee`` =
        Prefixed_Name(w3id, "AIRO#EvaluatingPerformanceOfEmployee") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#EvaluatingReliabilityOfEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the evaluation of the reliability of evidence in the course of investigation or prosecution of criminal offences."</para>
    /// labels<para>"Evaluating Reliability Of Evidence"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#EvaluatingReliabilityOfEvidence">https://w3id.org/AIRO#EvaluatingReliabilityOfEvidence</seealso>
    let ``AIRO#EvaluatingReliabilityOfEvidence`` =
        Prefixed_Name(w3id, "AIRO#EvaluatingReliabilityOfEvidence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents occurrence or change of a particular set of circumstances. [Source ISO 31000, 3.5]"</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Event">https://w3id.org/AIRO#Event</seealso>
    let ``AIRO#Event`` = Prefixed_Name(w3id, "AIRO#Event") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ExecutionEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Hardware on which the AI system run"</para>
    /// labels<para>"Execution Environment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ExecutionEnvironment">https://w3id.org/AIRO#ExecutionEnvironment</seealso>
    let ``AIRO#ExecutionEnvironment`` =
        Prefixed_Name(w3id, "AIRO#ExecutionEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ExpectedLifetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the expected lifetime of a system."</para>
    /// labels<para>"Expected Lifetime"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ExpectedLifetime">https://w3id.org/AIRO#ExpectedLifetime</seealso>
    let ``AIRO#ExpectedLifetime`` =
        Prefixed_Name(w3id, "AIRO#ExpectedLifetime") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ExtentOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the extent to which an AI system has been used or is likely to be used."</para>
    /// labels<para>"Extent Of Use"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ExtentOfUse">https://w3id.org/AIRO#ExtentOfUse</seealso>
    let ``AIRO#ExtentOfUse`` = Prefixed_Name(w3id, "AIRO#ExtentOfUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#FacialRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Automatic pattern recognition comparing stored images of human faces with the image of an actual face, indicating any matching, if it exists, and any data, if they exist, identifying the person to whom the face belongs [Source: ISO 5127:2017, 3.1.12.09]."</para>
    /// labels<para>"Facial Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#FacialRecognition">https://w3id.org/AIRO#FacialRecognition</seealso>
    let ``AIRO#FacialRecognition`` =
        Prefixed_Name(w3id, "AIRO#FacialRecognition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Firefighter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who works as a firefighter."</para>
    /// labels<para>"Firefighter"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Firefighter">https://w3id.org/AIRO#Firefighter</seealso>
    let ``AIRO#Firefighter`` = Prefixed_Name(w3id, "AIRO#Firefighter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#FundamentalRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a right, freedom, or principle set out in the EU Charter of Fundamental Rights."</para>
    /// labels<para>"Fundamental Right"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#FundamentalRight">https://w3id.org/AIRO#FundamentalRight</seealso>
    let ``AIRO#FundamentalRight`` =
        Prefixed_Name(w3id, "AIRO#FundamentalRight") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#GeneratingAudioContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to manipulating or generating audio content."</para>
    /// labels<para>"Generating Audio Content"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#GeneratingAudioContent">https://w3id.org/AIRO#GeneratingAudioContent</seealso>
    let ``AIRO#GeneratingAudioContent`` =
        Prefixed_Name(w3id, "AIRO#GeneratingAudioContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#GeneratingContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents purpose of generating or manipulating content."</para>
    /// labels<para>"Generating Content"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#GeneratingContent">https://w3id.org/AIRO#GeneratingContent</seealso>
    let ``AIRO#GeneratingContent`` =
        Prefixed_Name(w3id, "AIRO#GeneratingContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#GeneratingImageContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to manipulating or generating image content."</para>
    /// labels<para>"Generating Image Content"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#GeneratingImageContent">https://w3id.org/AIRO#GeneratingImageContent</seealso>
    let ``AIRO#GeneratingImageContent`` =
        Prefixed_Name(w3id, "AIRO#GeneratingImageContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#GeneratingVideoContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to manipulating or generating video content."</para>
    /// labels<para>"Generating Video Content"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#GeneratingVideoContent">https://w3id.org/AIRO#GeneratingVideoContent</seealso>
    let ``AIRO#GeneratingVideoContent`` =
        Prefixed_Name(w3id, "AIRO#GeneratingVideoContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#GrantingPublicAssistanceServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Granting Public Assistance Services"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#GrantingPublicAssistanceServices">https://w3id.org/AIRO#GrantingPublicAssistanceServices</seealso>
    let ``AIRO#GrantingPublicAssistanceServices`` =
        Prefixed_Name(w3id, "AIRO#GrantingPublicAssistanceServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of persons such as citizens, marginsalised groups, etc."</para>
    /// labels<para>"Group"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Group">https://w3id.org/AIRO#Group</seealso>
    let ``AIRO#Group`` = Prefixed_Name(w3id, "AIRO#Group") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#HarmonisedStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a European standard as defined in Article 2(1)(c) of Regulation (EU) No 1025/2012"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Harmonised Standard"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#HarmonisedStandard">https://w3id.org/AIRO#HarmonisedStandard</seealso>
    let ``AIRO#HarmonisedStandard`` =
        Prefixed_Name(w3id, "AIRO#HarmonisedStandard") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Health</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents health of a person."</para>
    /// labels<para>"Health"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Health">https://w3id.org/AIRO#Health</seealso>
    let ``AIRO#Health`` = Prefixed_Name(w3id, "AIRO#Health") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#HealthAndSafety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents area of health and safety."</para>
    /// labels<para>"Health And Safety"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#HealthAndSafety">https://w3id.org/AIRO#HealthAndSafety</seealso>
    let ``AIRO#HealthAndSafety`` =
        Prefixed_Name(w3id, "AIRO#HealthAndSafety") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#HumanBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the way a person acts."</para>
    /// labels<para>"Human Behaviour"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#HumanBehaviour">https://w3id.org/AIRO#HumanBehaviour</seealso>
    let ``AIRO#HumanBehaviour`` =
        Prefixed_Name(w3id, "AIRO#HumanBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#HumanOversightMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents measures for overseening the system by natural persons to detect, prevent or minimise risk."</para>
    /// labels<para>"Human Oversight Measure"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#HumanOversightMeasure">https://w3id.org/AIRO#HumanOversightMeasure</seealso>
    let ``AIRO#HumanOversightMeasure`` =
        Prefixed_Name(w3id, "AIRO#HumanOversightMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#IdentifyingUnkownPatternsOfCrime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Identifying Unkown Patterns Of Crime"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#IdentifyingUnkownPatternsOfCrime">https://w3id.org/AIRO#IdentifyingUnkownPatternsOfCrime</seealso>
    let ``AIRO#IdentifyingUnkownPatternsOfCrime`` =
        Prefixed_Name(w3id, "AIRO#IdentifyingUnkownPatternsOfCrime") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ImmigrationEligibilityAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Examination of applications for asylum, visa and residence permits and associated complaints"</para>
    /// labels<para>"Immigration Eligibility Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ImmigrationEligibilityAssessment">https://w3id.org/AIRO#ImmigrationEligibilityAssessment</seealso>
    let ``AIRO#ImmigrationEligibilityAssessment`` =
        Prefixed_Name(w3id, "AIRO#ImmigrationEligibilityAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Impact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents outcomes of a consequence on persons, groups, facilities, environment, etc."</para>
    /// labels<para>"Impact"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Impact">https://w3id.org/AIRO#Impact</seealso>
    let ``AIRO#Impact`` = Prefixed_Name(w3id, "AIRO#Impact") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ImpactOnFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents impact of AI on facilities and property."</para>
    /// labels<para>"Impact On Facility"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ImpactOnFacility">https://w3id.org/AIRO#ImpactOnFacility</seealso>
    let ``AIRO#ImpactOnFacility`` =
        Prefixed_Name(w3id, "AIRO#ImpactOnFacility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#IncompetenceOfHumanOversightActors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to incompentece of individuals to whom human oversight is assigned."</para>
    /// labels<para>"Incompetence Of Human Oversight Actors"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#IncompetenceOfHumanOversightActors">https://w3id.org/AIRO#IncompetenceOfHumanOversightActors</seealso>
    let ``AIRO#IncompetenceOfHumanOversightActors`` =
        Prefixed_Name(w3id, "AIRO#IncompetenceOfHumanOversightActors") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#IncompletenessOfTestingDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Incompleteness Of Testing Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#IncompletenessOfTestingDataSet">https://w3id.org/AIRO#IncompletenessOfTestingDataSet</seealso>
    let ``AIRO#IncompletenessOfTestingDataSet`` =
        Prefixed_Name(w3id, "AIRO#IncompletenessOfTestingDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#IncompletenessOfTrainingDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Incompleteness Of Training Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#IncompletenessOfTrainingDataSet">https://w3id.org/AIRO#IncompletenessOfTrainingDataSet</seealso>
    let ``AIRO#IncompletenessOfTrainingDataSet`` =
        Prefixed_Name(w3id, "AIRO#IncompletenessOfTrainingDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#IncompletenessOfValidationDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Incompleteness Of Validation Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#IncompletenessOfValidationDataSet">https://w3id.org/AIRO#IncompletenessOfValidationDataSet</seealso>
    let ``AIRO#IncompletenessOfValidationDataSet`` =
        Prefixed_Name(w3id, "AIRO#IncompletenessOfValidationDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Indicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Indicator"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Indicator">https://w3id.org/AIRO#Indicator</seealso>
    let ``AIRO#Indicator`` = Prefixed_Name(w3id, "AIRO#Indicator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#IndividualRiskAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to use of AI systems for making individual risk assessments of natural persons in order to assess the risk of a natural person for offending or reoffending or the risk for potential victims of criminal offences."</para>
    /// labels<para>"Individual Risk Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#IndividualRiskAssessment">https://w3id.org/AIRO#IndividualRiskAssessment</seealso>
    let ``AIRO#IndividualRiskAssessment`` =
        Prefixed_Name(w3id, "AIRO#IndividualRiskAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#InductiveProgramming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Inductive Programming"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#InductiveProgramming">https://w3id.org/AIRO#InductiveProgramming</seealso>
    let ``AIRO#InductiveProgramming`` =
        Prefixed_Name(w3id, "AIRO#InductiveProgramming") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Injury</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents physical injuries caused by AI."</para>
    /// labels<para>"Physical Injury"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Injury">https://w3id.org/AIRO#Injury</seealso>
    let ``AIRO#Injury`` = Prefixed_Name(w3id, "AIRO#Injury") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#InputData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data for which an AI system calculates a predicted output or inference [Source: ISO/IEC FDIS 22989, 3.2.9]."</para>
    /// labels<para>"Input Data"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#InputData">https://w3id.org/AIRO#InputData</seealso>
    let ``AIRO#InputData`` = Prefixed_Name(w3id, "AIRO#InputData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#InputDataRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Input Data Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#InputDataRiskSource">https://w3id.org/AIRO#InputDataRiskSource</seealso>
    let ``AIRO#InputDataRiskSource`` =
        Prefixed_Name(w3id, "AIRO#InputDataRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#InstallationInstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Installation Instruction"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#InstallationInstruction">https://w3id.org/AIRO#InstallationInstruction</seealso>
    let ``AIRO#InstallationInstruction`` =
        Prefixed_Name(w3id, "AIRO#InstallationInstruction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#InstructionOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Instruction Of Use"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#InstructionOfUse">https://w3id.org/AIRO#InstructionOfUse</seealso>
    let ``AIRO#InstructionOfUse`` =
        Prefixed_Name(w3id, "AIRO#InstructionOfUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Interruption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represent a contol used to interrupt the system's operation."</para>
    /// labels<para>"Interruption"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Interruption">https://w3id.org/AIRO#Interruption</seealso>
    let ``AIRO#Interruption`` = Prefixed_Name(w3id, "AIRO#Interruption") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Intervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Intervention of  a system's operation"</para>
    /// labels<para>"Intervation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Intervention">https://w3id.org/AIRO#Intervention</seealso>
    let ``AIRO#Intervention`` = Prefixed_Name(w3id, "AIRO#Intervention") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#InterviewEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Interview Evaluation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#InterviewEvaluation">https://w3id.org/AIRO#InterviewEvaluation</seealso>
    let ``AIRO#InterviewEvaluation`` =
        Prefixed_Name(w3id, "AIRO#InterviewEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#IrrelevantTestingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Irrelevant Testing Data"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#IrrelevantTestingData">https://w3id.org/AIRO#IrrelevantTestingData</seealso>
    let ``AIRO#IrrelevantTestingData`` =
        Prefixed_Name(w3id, "AIRO#IrrelevantTestingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#IrrelevantTrainingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Irrelevant Training Data"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#IrrelevantTrainingData">https://w3id.org/AIRO#IrrelevantTrainingData</seealso>
    let ``AIRO#IrrelevantTrainingData`` =
        Prefixed_Name(w3id, "AIRO#IrrelevantTrainingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#IrrelevantValidationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Irrelevant Validation Data"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#IrrelevantValidationData">https://w3id.org/AIRO#IrrelevantValidationData</seealso>
    let ``AIRO#IrrelevantValidationData`` =
        Prefixed_Name(w3id, "AIRO#IrrelevantValidationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#JobApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A person who has made an application for employment."</para><para>"Job Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#JobApplicant">https://w3id.org/AIRO#JobApplicant</seealso>
    let ``AIRO#JobApplicant`` = Prefixed_Name(w3id, "AIRO#JobApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#JudicialAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Judicial Authority"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#JudicialAuthority">https://w3id.org/AIRO#JudicialAuthority</seealso>
    let ``AIRO#JudicialAuthority`` =
        Prefixed_Name(w3id, "AIRO#JudicialAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#KnowledgeBasedApproach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents  knowledge-based approaches, including knowledge representation, , knowledge bases and expert systems."</para>
    /// labels<para>"Knowledge Based Approach"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#KnowledgeBasedApproach">https://w3id.org/AIRO#KnowledgeBasedApproach</seealso>
    let ``AIRO#KnowledgeBasedApproach`` =
        Prefixed_Name(w3id, "AIRO#KnowledgeBasedApproach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#KnowledgeReasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents purpose of capturing knowledge and acquiring new knowledge."</para>
    /// labels<para>"Knowledge Reasoning"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#KnowledgeReasoning">https://w3id.org/AIRO#KnowledgeReasoning</seealso>
    let ``AIRO#KnowledgeReasoning`` =
        Prefixed_Name(w3id, "AIRO#KnowledgeReasoning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#KnowledgeRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Knowledge Representation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#KnowledgeRepresentation">https://w3id.org/AIRO#KnowledgeRepresentation</seealso>
    let ``AIRO#KnowledgeRepresentation`` =
        Prefixed_Name(w3id, "AIRO#KnowledgeRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#LackOfAppropriateInstructionForUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lack Of Appropriate Instruction For Use"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#LackOfAppropriateInstructionForUse">https://w3id.org/AIRO#LackOfAppropriateInstructionForUse</seealso>
    let ``AIRO#LackOfAppropriateInstructionForUse`` =
        Prefixed_Name(w3id, "AIRO#LackOfAppropriateInstructionForUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#LackOfAppropriateSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lack Of Appropriate Level Of Security"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#LackOfAppropriateSecurity">https://w3id.org/AIRO#LackOfAppropriateSecurity</seealso>
    let ``AIRO#LackOfAppropriateSecurity`` =
        Prefixed_Name(w3id, "AIRO#LackOfAppropriateSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#LackOfHumanOversightMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lack Of Human Oversight Measure"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#LackOfHumanOversightMeasure">https://w3id.org/AIRO#LackOfHumanOversightMeasure</seealso>
    let ``AIRO#LackOfHumanOversightMeasure`` =
        Prefixed_Name(w3id, "AIRO#LackOfHumanOversightMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#LackOfTransparency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lack Of Transparency"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#LackOfTransparency">https://w3id.org/AIRO#LackOfTransparency</seealso>
    let ``AIRO#LackOfTransparency`` =
        Prefixed_Name(w3id, "AIRO#LackOfTransparency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#LawEnforcementAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Law Enforcement Authority"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#LawEnforcementAuthority">https://w3id.org/AIRO#LawEnforcementAuthority</seealso>
    let ``AIRO#LawEnforcementAuthority`` =
        Prefixed_Name(w3id, "AIRO#LawEnforcementAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#LegalInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents purpose of researching and interpreting facts and the law."</para>
    /// labels<para>"Legal Interpretation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#LegalInterpretation">https://w3id.org/AIRO#LegalInterpretation</seealso>
    let ``AIRO#LegalInterpretation`` =
        Prefixed_Name(w3id, "AIRO#LegalInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Likelihood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Chance of an event happening. [Source: ISO 31000, 3.7]"</para>
    /// labels<para>"Likelihood"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Likelihood">https://w3id.org/AIRO#Likelihood</seealso>
    let ``AIRO#Likelihood`` = Prefixed_Name(w3id, "AIRO#Likelihood") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#LogicBasedApproach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents Logic-based approaches, including inductive (logic) programming."</para>
    /// labels<para>"Logic Based Approach"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#LogicBasedApproach">https://w3id.org/AIRO#LogicBasedApproach</seealso>
    let ``AIRO#LogicBasedApproach`` =
        Prefixed_Name(w3id, "AIRO#LogicBasedApproach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#LowLevelOfAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to inacurracy of the predictions, recommondations, or decisions produced by the system."</para>
    /// labels<para>"Low Level Of Accuracy"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#LowLevelOfAccuracy">https://w3id.org/AIRO#LowLevelOfAccuracy</seealso>
    let ``AIRO#LowLevelOfAccuracy`` =
        Prefixed_Name(w3id, "AIRO#LowLevelOfAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#LowLevelOfRobustness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Low Level Of Robustness"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#LowLevelOfRobustness">https://w3id.org/AIRO#LowLevelOfRobustness</seealso>
    let ``AIRO#LowLevelOfRobustness`` =
        Prefixed_Name(w3id, "AIRO#LowLevelOfRobustness") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#MachineLearningApproach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represenets machine learning approaches, including supervised, unsupervised and reinforcement learning, using a wide variety of methods including deep learning. [Source: AI Act, Annex I]"</para>
    /// labels<para>"Machine Learning Approach"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#MachineLearningApproach">https://w3id.org/AIRO#MachineLearningApproach</seealso>
    let ``AIRO#MachineLearningApproach`` =
        Prefixed_Name(w3id, "AIRO#MachineLearningApproach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#MakingDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents purpose of generating decisions."</para>
    /// labels<para>"Making Decision"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#MakingDecision">https://w3id.org/AIRO#MakingDecision</seealso>
    let ``AIRO#MakingDecision`` =
        Prefixed_Name(w3id, "AIRO#MakingDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#MakingPrediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents purpose of predicting something based on the existing information."</para>
    /// labels<para>"Making Prediction"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#MakingPrediction">https://w3id.org/AIRO#MakingPrediction</seealso>
    let ``AIRO#MakingPrediction`` =
        Prefixed_Name(w3id, "AIRO#MakingPrediction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#MakingPromotionDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to making decisions on promotion."</para>
    /// labels<para>"Making Promotion Decision"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#MakingPromotionDecision">https://w3id.org/AIRO#MakingPromotionDecision</seealso>
    let ``AIRO#MakingPromotionDecision`` =
        Prefixed_Name(w3id, "AIRO#MakingPromotionDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#MakingTerminationDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to termination of work-related contractual relationships."</para>
    /// labels<para>"Making Termination Decision"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#MakingTerminationDecision">https://w3id.org/AIRO#MakingTerminationDecision</seealso>
    let ``AIRO#MakingTerminationDecision`` =
        Prefixed_Name(w3id, "AIRO#MakingTerminationDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ManualControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents controls performed by humans without any use of technologies."</para>
    /// labels<para>"Manual Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ManualControl">https://w3id.org/AIRO#ManualControl</seealso>
    let ``AIRO#ManualControl`` =
        Prefixed_Name(w3id, "AIRO#ManualControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#MedicalAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who works as a medical aid."</para>
    /// labels<para>"Medical Aid"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#MedicalAid">https://w3id.org/AIRO#MedicalAid</seealso>
    let ``AIRO#MedicalAid`` = Prefixed_Name(w3id, "AIRO#MedicalAid") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Metric"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Metric">https://w3id.org/AIRO#Metric</seealso>
    let ``AIRO#Metric`` = Prefixed_Name(w3id, "AIRO#Metric") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#MigrationRelatedComplaintsExamination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Migration Related Complaints Examination"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#MigrationRelatedComplaintsExamination">https://w3id.org/AIRO#MigrationRelatedComplaintsExamination</seealso>
    let ``AIRO#MigrationRelatedComplaintsExamination`` =
        Prefixed_Name(w3id, "AIRO#MigrationRelatedComplaintsExamination") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Misuse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The use of an AI system in a way that is not in accordance with its intended purpose."</para>
    /// labels<para>"Misuse"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Misuse">https://w3id.org/AIRO#Misuse</seealso>
    let ``AIRO#Misuse`` = Prefixed_Name(w3id, "AIRO#Misuse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Physical, mathematical, or otherwise logical representation of a system, entity, phenomenon, process or data [Source: ISO/IEC FDIS 22989, 3.1.23]"</para>
    /// labels<para>"Model"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Model">https://w3id.org/AIRO#Model</seealso>
    let ``AIRO#Model`` = Prefixed_Name(w3id, "AIRO#Model") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#ModelEvasion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Model Evasion"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ModelEvasion">https://w3id.org/AIRO#ModelEvasion</seealso>
    let ``AIRO#ModelEvasion`` = Prefixed_Name(w3id, "AIRO#ModelEvasion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ModelInversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Model Inversion"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ModelInversion">https://w3id.org/AIRO#ModelInversion</seealso>
    let ``AIRO#ModelInversion`` =
        Prefixed_Name(w3id, "AIRO#ModelInversion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Monitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents purpose of observing and keeping track of something."</para>
    /// labels<para>"Monitoring"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Monitoring">https://w3id.org/AIRO#Monitoring</seealso>
    let ``AIRO#Monitoring`` = Prefixed_Name(w3id, "AIRO#Monitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#OperationMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Operation Mode"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#OperationMode">https://w3id.org/AIRO#OperationMode</seealso>
    let ``AIRO#OperationMode`` =
        Prefixed_Name(w3id, "AIRO#OperationMode") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#OperationalControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Operational Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#OperationalControl">https://w3id.org/AIRO#OperationalControl</seealso>
    let ``AIRO#OperationalControl`` =
        Prefixed_Name(w3id, "AIRO#OperationalControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#OptimisationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Optimisation Method"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#OptimisationMethod">https://w3id.org/AIRO#OptimisationMethod</seealso>
    let ``AIRO#OptimisationMethod`` =
        Prefixed_Name(w3id, "AIRO#OptimisationMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#OrganisationalControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organisational Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#OrganisationalControl">https://w3id.org/AIRO#OrganisationalControl</seealso>
    let ``AIRO#OrganisationalControl`` =
        Prefixed_Name(w3id, "AIRO#OrganisationalControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#OrganisationalRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organisational Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#OrganisationalRiskSource">https://w3id.org/AIRO#OrganisationalRiskSource</seealso>
    let ``AIRO#OrganisationalRiskSource`` =
        Prefixed_Name(w3id, "AIRO#OrganisationalRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates output of an AI system."</para>
    /// labels<para>"Output"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Output">https://w3id.org/AIRO#Output</seealso>
    let ``AIRO#Output`` = Prefixed_Name(w3id, "AIRO#Output") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#OverReliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents tendency of automatically relying or over-relying on the output produced by an AI system"</para>
    /// labels<para>"Over Reliance"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#OverReliance">https://w3id.org/AIRO#OverReliance</seealso>
    let ``AIRO#OverReliance`` = Prefixed_Name(w3id, "AIRO#OverReliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#OverridingTheOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents overriding outcome of a system."</para>
    /// labels<para>"Overriding The Outcome"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#OverridingTheOutcome">https://w3id.org/AIRO#OverridingTheOutcome</seealso>
    let ``AIRO#OverridingTheOutcome`` =
        Prefixed_Name(w3id, "AIRO#OverridingTheOutcome") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PartialControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Partial Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PartialControl">https://w3id.org/AIRO#PartialControl</seealso>
    let ``AIRO#PartialControl`` =
        Prefixed_Name(w3id, "AIRO#PartialControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PatternRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to identification of unknown patterns in data."</para>
    /// labels<para>"Pattern Recognition"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PatternRecognition">https://w3id.org/AIRO#PatternRecognition</seealso>
    let ``AIRO#PatternRecognition`` =
        Prefixed_Name(w3id, "AIRO#PatternRecognition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the ability of an AI system to achieve its intended purpose [Source: AI Act, Article 3(18)]"</para>
    /// labels<para>"Performance"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Performance">https://w3id.org/AIRO#Performance</seealso>
    let ``AIRO#Performance`` = Prefixed_Name(w3id, "AIRO#Performance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PerformanceConsequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents consequences related to the performance of the AI System."</para>
    /// labels<para>"Performance Consequence"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PerformanceConsequence">https://w3id.org/AIRO#PerformanceConsequence</seealso>
    let ``AIRO#PerformanceConsequence`` =
        Prefixed_Name(w3id, "AIRO#PerformanceConsequence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PerformanceRelatedRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Perfomance Related Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PerformanceRelatedRiskSource">https://w3id.org/AIRO#PerformanceRelatedRiskSource</seealso>
    let ``AIRO#PerformanceRelatedRiskSource`` =
        Prefixed_Name(w3id, "AIRO#PerformanceRelatedRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An individual human being."</para>
    /// labels<para>"Natural Person"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Person">https://w3id.org/AIRO#Person</seealso>
    let ``AIRO#Person`` = Prefixed_Name(w3id, "AIRO#Person") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PersonWhoHasEnteredATerritory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who has entered a territory."</para>
    /// labels<para>"Person Who Has Entered A Territory"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PersonWhoHasEnteredATerritory">https://w3id.org/AIRO#PersonWhoHasEnteredATerritory</seealso>
    let ``AIRO#PersonWhoHasEnteredATerritory`` =
        Prefixed_Name(w3id, "AIRO#PersonWhoHasEnteredATerritory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PersonWhoIntendsToEnterATerritory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who intends to enter a territory."</para>
    /// labels<para>"Person Who Intends To Enter Territory"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PersonWhoIntendsToEnterATerritory">https://w3id.org/AIRO#PersonWhoIntendsToEnterATerritory</seealso>
    let ``AIRO#PersonWhoIntendsToEnterATerritory`` =
        Prefixed_Name(w3id, "AIRO#PersonWhoIntendsToEnterATerritory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PersonalityTraitsAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Personality Traits Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PersonalityTraitsAssessment">https://w3id.org/AIRO#PersonalityTraitsAssessment</seealso>
    let ``AIRO#PersonalityTraitsAssessment`` =
        Prefixed_Name(w3id, "AIRO#PersonalityTraitsAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PhysicalHealth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents physical health."</para>
    /// labels<para>"Physical Health"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PhysicalHealth">https://w3id.org/AIRO#PhysicalHealth</seealso>
    let ``AIRO#PhysicalHealth`` =
        Prefixed_Name(w3id, "AIRO#PhysicalHealth") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Planning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents use of AI systems for planning and scheduling."</para>
    /// labels<para>"Planning"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Planning">https://w3id.org/AIRO#Planning</seealso>
    let ``AIRO#Planning`` = Prefixed_Name(w3id, "AIRO#Planning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Post-marketMonitoringSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Post-market Monitoring System"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Post-marketMonitoringSystem">https://w3id.org/AIRO#Post-marketMonitoringSystem</seealso>
    let ``AIRO#Post_marketMonitoringSystem`` =
        Prefixed_Name(w3id, "AIRO#Post-marketMonitoringSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PostmarketMonitoringPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Post-market monitoring plan"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PostmarketMonitoringPlan">https://w3id.org/AIRO#PostmarketMonitoringPlan</seealso>
    let ``AIRO#PostmarketMonitoringPlan`` =
        Prefixed_Name(w3id, "AIRO#PostmarketMonitoringPlan") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PostmarketMonitoringSystemDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Post-market Monitoring System Description"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PostmarketMonitoringSystemDescription">https://w3id.org/AIRO#PostmarketMonitoringSystemDescription</seealso>
    let ``AIRO#PostmarketMonitoringSystemDescription`` =
        Prefixed_Name(w3id, "AIRO#PostmarketMonitoringSystemDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Pre-trainedModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pre-trianed Model"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Pre-trainedModel">https://w3id.org/AIRO#Pre-trainedModel</seealso>
    let ``AIRO#Pre_trainedModel`` =
        Prefixed_Name(w3id, "AIRO#Pre-trainedModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PredictingRecidivism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Referes to predicting the occurrence or reoccurrence of an actual or potential criminal offence based on profiling of natural persons or assessing personality traits and characteristics or past criminal behaviour of natural persons or groups."</para>
    /// labels<para>"Predicting Recidivism"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PredictingRecidivism">https://w3id.org/AIRO#PredictingRecidivism</seealso>
    let ``AIRO#PredictingRecidivism`` =
        Prefixed_Name(w3id, "AIRO#PredictingRecidivism") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Prediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Primary output of an AI system when provided with input data or information. [Source: ISO/IEC FDIS 22989, 3.1.27]"</para>
    /// labels<para>"Prediction"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Prediction">https://w3id.org/AIRO#Prediction</seealso>
    let ``AIRO#Prediction`` = Prefixed_Name(w3id, "AIRO#Prediction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PreventionControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Control applied to reduce likelihood or severity of the risk, consequence or impact."</para>
    /// labels<para>"Mitigation Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PreventionControl">https://w3id.org/AIRO#PreventionControl</seealso>
    let ``AIRO#PreventionControl`` =
        Prefixed_Name(w3id, "AIRO#PreventionControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PrioritisationOfEmergencyService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Establishing priority in the dispatching of emergency first response services, including by firefighters and medical aid."</para>
    /// labels<para>"Prioritisation Of Emergency Service"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PrioritisationOfEmergencyService">https://w3id.org/AIRO#PrioritisationOfEmergencyService</seealso>
    let ``AIRO#PrioritisationOfEmergencyService`` =
        Prefixed_Name(w3id, "AIRO#PrioritisationOfEmergencyService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ProducingRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents purpose of producing meaningful recommendations to users of the system."</para>
    /// labels<para>"Producing Recommendation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ProducingRecommendation">https://w3id.org/AIRO#ProducingRecommendation</seealso>
    let ``AIRO#ProducingRecommendation`` =
        Prefixed_Name(w3id, "AIRO#ProducingRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Profiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to profiling of natural persons in the course of detection, investigation or prosecution of criminal offences."</para>
    /// labels<para>"Profiling"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Profiling">https://w3id.org/AIRO#Profiling</seealso>
    let ``AIRO#Profiling`` = Prefixed_Name(w3id, "AIRO#Profiling") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PropertyDamage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents damage of properties caused by AI."</para>
    /// labels<para>"Property Damage"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PropertyDamage">https://w3id.org/AIRO#PropertyDamage</seealso>
    let ``AIRO#PropertyDamage`` =
        Prefixed_Name(w3id, "AIRO#PropertyDamage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ProvidingInstructionOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents providing information to inform the user of in particular an AI system’s intended purpose and proper use, inclusive of the specific geographical, behavioural or functional setting within which the  AI system is intended to be used."</para>
    /// labels<para>"Providing Instruction Of Use"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ProvidingInstructionOfUse">https://w3id.org/AIRO#ProvidingInstructionOfUse</seealso>
    let ``AIRO#ProvidingInstructionOfUse`` =
        Prefixed_Name(w3id, "AIRO#ProvidingInstructionOfUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PsychologicalHarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents psychological injuries caused by AI."</para>
    /// labels<para>"Psychological Harm"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PsychologicalHarm">https://w3id.org/AIRO#PsychologicalHarm</seealso>
    let ``AIRO#PsychologicalHarm`` =
        Prefixed_Name(w3id, "AIRO#PsychologicalHarm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PsychologicalHealth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents psychological health."</para>
    /// labels<para>"Psychological Health"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PsychologicalHealth">https://w3id.org/AIRO#PsychologicalHealth</seealso>
    let ``AIRO#PsychologicalHealth`` =
        Prefixed_Name(w3id, "AIRO#PsychologicalHealth") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PublicAssistanceEligibilityAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Evaluation of the eligibility of natural persons for public assistance benefits and services."</para>
    /// labels<para>"Public Assistance Eligibility Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PublicAssistanceEligibilityAssessment">https://w3id.org/AIRO#PublicAssistanceEligibilityAssessment</seealso>
    let ``AIRO#PublicAssistanceEligibilityAssessment`` =
        Prefixed_Name(w3id, "AIRO#PublicAssistanceEligibilityAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#PublicAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Public Authority"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#PublicAuthority">https://w3id.org/AIRO#PublicAuthority</seealso>
    let ``AIRO#PublicAuthority`` =
        Prefixed_Name(w3id, "AIRO#PublicAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the use for which an AI system is intended by the provider, including the specific context and conditions of use, as specified in the information supplied by the provider in the instructions for use, promotional or sales materials and statements, as well as in the technical documentation. [Source: AI Act, Art 3(12)]"</para>
    /// labels<para>"Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Purpose">https://w3id.org/AIRO#Purpose</seealso>
    let ``AIRO#Purpose`` = Prefixed_Name(w3id, "AIRO#Purpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ReasonablyForseeableMisue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Use of an AI system in a way that is not in accordance with its intended purpose, but which may result from reasonably foreseeable human behaviour or interaction with other systems [Source: AI Act, Article 3(13)]"</para>
    /// labels<para>"Reasonably Forseeable Misuse"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ReasonablyForseeableMisue">https://w3id.org/AIRO#ReasonablyForseeableMisue</seealso>
    let ``AIRO#ReasonablyForseeableMisue`` =
        Prefixed_Name(w3id, "AIRO#ReasonablyForseeableMisue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ReclaimingPublicAssisstanceServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reclaiming Public Assisstance Services"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ReclaimingPublicAssisstanceServices">https://w3id.org/AIRO#ReclaimingPublicAssisstanceServices</seealso>
    let ``AIRO#ReclaimingPublicAssisstanceServices`` =
        Prefixed_Name(w3id, "AIRO#ReclaimingPublicAssisstanceServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#RecuritmentTestEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Recuritment Test Evaluation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#RecuritmentTestEvaluation">https://w3id.org/AIRO#RecuritmentTestEvaluation</seealso>
    let ``AIRO#RecuritmentTestEvaluation`` =
        Prefixed_Name(w3id, "AIRO#RecuritmentTestEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ReducingPublicAssisstanceServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reducing Public Assisstance Services"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ReducingPublicAssisstanceServices">https://w3id.org/AIRO#ReducingPublicAssisstanceServices</seealso>
    let ``AIRO#ReducingPublicAssisstanceServices`` =
        Prefixed_Name(w3id, "AIRO#ReducingPublicAssisstanceServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ReinforcementLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reinforcement Learning"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ReinforcementLearning">https://w3id.org/AIRO#ReinforcementLearning</seealso>
    let ``AIRO#ReinforcementLearning`` =
        Prefixed_Name(w3id, "AIRO#ReinforcementLearning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#RemoteBiometricIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Identifying natural persons at a distance through the comparison of a person’s biometric data with the biometric data contained in a reference database."</para>
    /// labels<para>"Remote Biometric Identification"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#RemoteBiometricIdentification">https://w3id.org/AIRO#RemoteBiometricIdentification</seealso>
    let ``AIRO#RemoteBiometricIdentification`` =
        Prefixed_Name(w3id, "AIRO#RemoteBiometricIdentification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#RepresentativeOfPublicAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entity who act on behalf of a public authority."</para>
    /// labels<para>"Representative Of Public Authority"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#RepresentativeOfPublicAuthority">https://w3id.org/AIRO#RepresentativeOfPublicAuthority</seealso>
    let ``AIRO#RepresentativeOfPublicAuthority`` =
        Prefixed_Name(w3id, "AIRO#RepresentativeOfPublicAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ResidencePermitApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who has applied for a residence permit."</para>
    /// labels<para>"Residence Permit Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ResidencePermitApplicant">https://w3id.org/AIRO#ResidencePermitApplicant</seealso>
    let ``AIRO#ResidencePermitApplicant`` =
        Prefixed_Name(w3id, "AIRO#ResidencePermitApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ResidencePermitsApplicationExamination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Residence Permits Application Examination"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ResidencePermitsApplicationExamination">https://w3id.org/AIRO#ResidencePermitsApplicationExamination</seealso>
    let ``AIRO#ResidencePermitsApplicationExamination`` =
        Prefixed_Name(w3id, "AIRO#ResidencePermitsApplicationExamination") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Reversiblity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the extent to which the outcome produced with an AI system is easily reversible."</para>
    /// labels<para>"Reversibility"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Reversiblity">https://w3id.org/AIRO#Reversiblity</seealso>
    let ``AIRO#Reversiblity`` = Prefixed_Name(w3id, "AIRO#Reversiblity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ReversingTheOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents reversing the outcome of a system."</para>
    /// labels<para>"Reversing The Outcome"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ReversingTheOutcome">https://w3id.org/AIRO#ReversingTheOutcome</seealso>
    let ``AIRO#ReversingTheOutcome`` =
        Prefixed_Name(w3id, "AIRO#ReversingTheOutcome") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#RevokingPublicAssisstanceServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Revoking Public Assisstance Services"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#RevokingPublicAssisstanceServices">https://w3id.org/AIRO#RevokingPublicAssisstanceServices</seealso>
    let ``AIRO#RevokingPublicAssisstanceServices`` =
        Prefixed_Name(w3id, "AIRO#RevokingPublicAssisstanceServices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Risk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates a risk (of harm) associated with an AI system."</para>
    /// labels<para>"Risk"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Risk">https://w3id.org/AIRO#Risk</seealso>
    let ``AIRO#Risk`` = Prefixed_Name(w3id, "AIRO#Risk") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#RiskIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents indicators for expressing risk."</para>
    /// labels<para>"Risk Indicator"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#RiskIndicator">https://w3id.org/AIRO#RiskIndicator</seealso>
    let ``AIRO#RiskIndicator`` =
        Prefixed_Name(w3id, "AIRO#RiskIndicator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#RiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates an element that has the potential give rise to a risk."</para>
    /// labels<para>"Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#RiskSource">https://w3id.org/AIRO#RiskSource</seealso>
    let ``AIRO#RiskSource`` = Prefixed_Name(w3id, "AIRO#RiskSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Robustness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ability of a system to maintain its level of performance under any circumstances. [Source: ISO 22989]"</para>
    /// labels<para>"Robustness"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Robustness">https://w3id.org/AIRO#Robustness</seealso>
    let ``AIRO#Robustness`` = Prefixed_Name(w3id, "AIRO#Robustness") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Safety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the state of being safe."</para>
    /// labels<para>"Safety"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Safety">https://w3id.org/AIRO#Safety</seealso>
    let ``AIRO#Safety`` = Prefixed_Name(w3id, "AIRO#Safety") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#SearchMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Search Method"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#SearchMethod">https://w3id.org/AIRO#SearchMethod</seealso>
    let ``AIRO#SearchMethod`` = Prefixed_Name(w3id, "AIRO#SearchMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Security</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Security"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Security">https://w3id.org/AIRO#Security</seealso>
    let ``AIRO#Security`` = Prefixed_Name(w3id, "AIRO#Security") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#SemiAutomatedControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represnets controls that comprise a combination of automated and manual controls."</para>
    /// labels<para>"Semi Automated Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#SemiAutomatedControl">https://w3id.org/AIRO#SemiAutomatedControl</seealso>
    let ``AIRO#SemiAutomatedControl`` =
        Prefixed_Name(w3id, "AIRO#SemiAutomatedControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#SeriousIncident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any incident that directly or indirectly leads, might have led or might lead to : (a) the death of a person or serious damage to a person’s health, to property or the environment, (b) a serious and irreversible disruption of the management and operation of critical infrastructure [Source: AI Act, Articl3 3(44)]"</para>
    /// labels<para>"Serious Incident"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#SeriousIncident">https://w3id.org/AIRO#SeriousIncident</seealso>
    let ``AIRO#SeriousIncident`` =
        Prefixed_Name(w3id, "AIRO#SeriousIncident") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Severity"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Severity">https://w3id.org/AIRO#Severity</seealso>
    let ``AIRO#Severity`` = Prefixed_Name(w3id, "AIRO#Severity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#StaffTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents training of staff, users, etc."</para>
    /// labels<para>"Staff Training"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#StaffTraining">https://w3id.org/AIRO#StaffTraining</seealso>
    let ``AIRO#StaffTraining`` =
        Prefixed_Name(w3id, "AIRO#StaffTraining") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Stakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents any individual, group or organization that can affect, be affected by or perceive itself to be affected by a decision or activity [Source: ISO/IEC TR 24028, 3.37]"</para>
    /// labels<para>"Stakeholder"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Stakeholder">https://w3id.org/AIRO#Stakeholder</seealso>
    let ``AIRO#Stakeholder`` = Prefixed_Name(w3id, "AIRO#Stakeholder") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Standard"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Standard">https://w3id.org/AIRO#Standard</seealso>
    let ``AIRO#Standard`` = Prefixed_Name(w3id, "AIRO#Standard") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#StatisticalApproach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represenets statistical approaches, Bayesian estimation, search and optimization methods. [Source: AI Act, Annex I]"</para>
    /// labels<para>"Statistical Approach"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#StatisticalApproach">https://w3id.org/AIRO#StatisticalApproach</seealso>
    let ``AIRO#StatisticalApproach`` =
        Prefixed_Name(w3id, "AIRO#StatisticalApproach") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who is studying at a school or a university."</para>
    /// labels<para>"Student"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Student">https://w3id.org/AIRO#Student</seealso>
    let ``AIRO#Student`` = Prefixed_Name(w3id, "AIRO#Student") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#StudentAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the purpose of assessing students in educational and vocational training institutions and for assessing participants in tests commonly required for admission to educational institutions."</para>
    /// labels<para>"Student Assessment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#StudentAssessment">https://w3id.org/AIRO#StudentAssessment</seealso>
    let ``AIRO#StudentAssessment`` =
        Prefixed_Name(w3id, "AIRO#StudentAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#StudentAssessmentInEducationalInstitutions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Student Assessment In Educational Institutions"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#StudentAssessmentInEducationalInstitutions">https://w3id.org/AIRO#StudentAssessmentInEducationalInstitutions</seealso>
    let ``AIRO#StudentAssessmentInEducationalInstitutions`` =
        Prefixed_Name(w3id, "AIRO#StudentAssessmentInEducationalInstitutions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#SubliminalTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"use of subliminal techniques beyond a person’s consciousness in order to materially distort a person’s behaviour in a manner that causes or is likely to cause that person or another person physical or psychological harm"</para>
    /// labels<para>"Subliminal Technique"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#SubliminalTechnique">https://w3id.org/AIRO#SubliminalTechnique</seealso>
    let ``AIRO#SubliminalTechnique`` =
        Prefixed_Name(w3id, "AIRO#SubliminalTechnique") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#SupervisedLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Supervised Learning"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#SupervisedLearning">https://w3id.org/AIRO#SupervisedLearning</seealso>
    let ``AIRO#SupervisedLearning`` =
        Prefixed_Name(w3id, "AIRO#SupervisedLearning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#SymbolicReasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Symbolic Reasoning"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#SymbolicReasoning">https://w3id.org/AIRO#SymbolicReasoning</seealso>
    let ``AIRO#SymbolicReasoning`` =
        Prefixed_Name(w3id, "AIRO#SymbolicReasoning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"System"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#System">https://w3id.org/AIRO#System</seealso>
    let ``AIRO#System`` = Prefixed_Name(w3id, "AIRO#System") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#SystemArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"System Architecture"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#SystemArchitecture">https://w3id.org/AIRO#SystemArchitecture</seealso>
    let ``AIRO#SystemArchitecture`` =
        Prefixed_Name(w3id, "AIRO#SystemArchitecture") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#SystemRelatedSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"System Related Source"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#SystemRelatedSource">https://w3id.org/AIRO#SystemRelatedSource</seealso>
    let ``AIRO#SystemRelatedSource`` =
        Prefixed_Name(w3id, "AIRO#SystemRelatedSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#TaskAllocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the Assignment of tasks to persons."</para>
    /// labels<para>"Task Allocation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#TaskAllocation">https://w3id.org/AIRO#TaskAllocation</seealso>
    let ``AIRO#TaskAllocation`` =
        Prefixed_Name(w3id, "AIRO#TaskAllocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#TechnicalControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents controls that are implemented using a technology."</para>
    /// labels<para>"Technical Control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#TechnicalControl">https://w3id.org/AIRO#TechnicalControl</seealso>
    let ``AIRO#TechnicalControl`` =
        Prefixed_Name(w3id, "AIRO#TechnicalControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#TechnicalSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Technical Specification"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#TechnicalSpecification">https://w3id.org/AIRO#TechnicalSpecification</seealso>
    let ``AIRO#TechnicalSpecification`` =
        Prefixed_Name(w3id, "AIRO#TechnicalSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#TestLog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Test log"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#TestLog">https://w3id.org/AIRO#TestLog</seealso>
    let ``AIRO#TestLog`` = Prefixed_Name(w3id, "AIRO#TestLog") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#TestParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who is participating in a test."</para>
    /// labels<para>"Test Participant"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#TestParticipant">https://w3id.org/AIRO#TestParticipant</seealso>
    let ``AIRO#TestParticipant`` =
        Prefixed_Name(w3id, "AIRO#TestParticipant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#TestReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Test Report"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#TestReport">https://w3id.org/AIRO#TestReport</seealso>
    let ``AIRO#TestReport`` = Prefixed_Name(w3id, "AIRO#TestReport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#TestingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Testing Data"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#TestingData">https://w3id.org/AIRO#TestingData</seealso>
    let ``AIRO#TestingData`` = Prefixed_Name(w3id, "AIRO#TestingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#TestingDataRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Testing Data Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#TestingDataRiskSource">https://w3id.org/AIRO#TestingDataRiskSource</seealso>
    let ``AIRO#TestingDataRiskSource`` =
        Prefixed_Name(w3id, "AIRO#TestingDataRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tool that has been used in development of an AI system."</para>
    /// labels<para>"Tool"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Tool">https://w3id.org/AIRO#Tool</seealso>
    let ``AIRO#Tool`` = Prefixed_Name(w3id, "AIRO#Tool") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#TrainingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data used to train a machine learning model [ISO/IEC FDIS 22989, 3.3.16]"</para>
    /// labels<para>"Training Data"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#TrainingData">https://w3id.org/AIRO#TrainingData</seealso>
    let ``AIRO#TrainingData`` = Prefixed_Name(w3id, "AIRO#TrainingData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#TrainingDataRiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Training Data Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#TrainingDataRiskSource">https://w3id.org/AIRO#TrainingDataRiskSource</seealso>
    let ``AIRO#TrainingDataRiskSource`` =
        Prefixed_Name(w3id, "AIRO#TrainingDataRiskSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#UnavailabilityOfDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unavailability Of Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#UnavailabilityOfDataSet">https://w3id.org/AIRO#UnavailabilityOfDataSet</seealso>
    let ``AIRO#UnavailabilityOfDataSet`` =
        Prefixed_Name(w3id, "AIRO#UnavailabilityOfDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#UnrepresentativeTestingDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unrepresentative Testing Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#UnrepresentativeTestingDataSet">https://w3id.org/AIRO#UnrepresentativeTestingDataSet</seealso>
    let ``AIRO#UnrepresentativeTestingDataSet`` =
        Prefixed_Name(w3id, "AIRO#UnrepresentativeTestingDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#UnrepresentativeTrainingDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unrepresentative Training Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#UnrepresentativeTrainingDataSet">https://w3id.org/AIRO#UnrepresentativeTrainingDataSet</seealso>
    let ``AIRO#UnrepresentativeTrainingDataSet`` =
        Prefixed_Name(w3id, "AIRO#UnrepresentativeTrainingDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#UnrepresentativeValidationDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unrepresentative Validation Data Set"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#UnrepresentativeValidationDataSet">https://w3id.org/AIRO#UnrepresentativeValidationDataSet</seealso>
    let ``AIRO#UnrepresentativeValidationDataSet`` =
        Prefixed_Name(w3id, "AIRO#UnrepresentativeValidationDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology/101#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/semts/ontology/101#">https://w3id.org/semts/ontology/101#</seealso>
    let ``semts/ontology/101#`` =
        Prefixed_Name(w3id, "semts/ontology/101#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#UnsupervisedLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unsupevised Learning"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#UnsupervisedLearning">https://w3id.org/AIRO#UnsupervisedLearning</seealso>
    let ``AIRO#UnsupervisedLearning`` =
        Prefixed_Name(w3id, "AIRO#UnsupervisedLearning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology/110#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/semts/ontology/110#">https://w3id.org/semts/ontology/110#</seealso>
    let ``semts/ontology/110#`` =
        Prefixed_Name(w3id, "semts/ontology/110#") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#UserIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents indicators for expressing attributes of users of AI systems."</para>
    /// labels<para>"User Indicator"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#UserIndicator">https://w3id.org/AIRO#UserIndicator</seealso>
    let ``AIRO#UserIndicator`` =
        Prefixed_Name(w3id, "AIRO#UserIndicator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ValidationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data used to compare the performance of different candidate models [Source: ISO/IEC FDIS 22989, 3.2.5]."</para>
    /// labels<para>"Validation Data"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ValidationData">https://w3id.org/AIRO#ValidationData</seealso>
    let ``AIRO#ValidationData`` =
        Prefixed_Name(w3id, "AIRO#ValidationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#ValidationDataRelatedSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Validation Data Risk Source"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#ValidationDataRelatedSource">https://w3id.org/AIRO#ValidationDataRelatedSource</seealso>
    let ``AIRO#ValidationDataRelatedSource`` =
        Prefixed_Name(w3id, "AIRO#ValidationDataRelatedSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#VerifyingAuthenticity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the verification of the authenticity of documents."</para>
    /// labels<para>"Verifying Authenticity"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#VerifyingAuthenticity">https://w3id.org/AIRO#VerifyingAuthenticity</seealso>
    let ``AIRO#VerifyingAuthenticity`` =
        Prefixed_Name(w3id, "AIRO#VerifyingAuthenticity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#VerifyingAuthenticityOfSupportingDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Verifying Authenticity Of Supporting Document"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#VerifyingAuthenticityOfSupportingDocument">https://w3id.org/AIRO#VerifyingAuthenticityOfSupportingDocument</seealso>
    let ``AIRO#VerifyingAuthenticityOfSupportingDocument`` =
        Prefixed_Name(w3id, "AIRO#VerifyingAuthenticityOfSupportingDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#VerifyingAuthenticityOfTravelDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the verification of the authenticity of travel documents and supporting documentation of natural persons and detection of non-authentic documents by checking their security features."</para>
    /// labels<para>"Verifying Authenticity Of Travel Document"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#VerifyingAuthenticityOfTravelDocument">https://w3id.org/AIRO#VerifyingAuthenticityOfTravelDocument</seealso>
    let ``AIRO#VerifyingAuthenticityOfTravelDocument`` =
        Prefixed_Name(w3id, "AIRO#VerifyingAuthenticityOfTravelDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Version"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#Version">https://w3id.org/AIRO#Version</seealso>
    let ``AIRO#Version`` = Prefixed_Name(w3id, "AIRO#Version") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#VisaApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who has applied for a visa."</para>
    /// labels<para>"Visa Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#VisaApplicant">https://w3id.org/AIRO#VisaApplicant</seealso>
    let ``AIRO#VisaApplicant`` =
        Prefixed_Name(w3id, "AIRO#VisaApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#VisaApplicationExamination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Visa Application Examination"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#VisaApplicationExamination">https://w3id.org/AIRO#VisaApplicationExamination</seealso>
    let ``AIRO#VisaApplicationExamination`` =
        Prefixed_Name(w3id, "AIRO#VisaApplicationExamination") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#VulnerablePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents whether potentially harmed or adversely impacted persons are in a vulnerable position due to an imbalance of power, knowledge, economic or social circumstances, or age. [Source: AI Act]"</para>
    /// labels<para>"Vulnerable Position"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#VulnerablePosition">https://w3id.org/AIRO#VulnerablePosition</seealso>
    let ``AIRO#VulnerablePosition`` =
        Prefixed_Name(w3id, "AIRO#VulnerablePosition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#WellbeingImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents impact of AI on persons' health and wellbeing."</para>
    /// labels<para>"Wellbeing Impact"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#WellbeingImpact">https://w3id.org/AIRO#WellbeingImpact</seealso>
    let ``AIRO#WellbeingImpact`` =
        Prefixed_Name(w3id, "AIRO#WellbeingImpact") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#WrongDataSetDesignChoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wrong Data Set Design Choice"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#WrongDataSetDesignChoice">https://w3id.org/AIRO#WrongDataSetDesignChoice</seealso>
    let ``AIRO#WrongDataSetDesignChoice`` =
        Prefixed_Name(w3id, "AIRO#WrongDataSetDesignChoice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#administration_of_democratic_processes</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#administration_of_democratic_processes">https://w3id.org/AIRO#administration_of_democratic_processes</seealso>
    let ``AIRO#administration_of_democratic_processes`` =
        Prefixed_Name(w3id, "AIRO#administration_of_democratic_processes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#administration_of_justice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#administration_of_justice">https://w3id.org/AIRO#administration_of_justice</seealso>
    let ``AIRO#administration_of_justice`` =
        Prefixed_Name(w3id, "AIRO#administration_of_justice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#affects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"affects"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#affects">https://w3id.org/AIRO#affects</seealso>
    let ``AIRO#affects`` = Prefixed_Name(w3id, "AIRO#affects") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#asylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#asylum">https://w3id.org/AIRO#asylum</seealso>
    let ``AIRO#asylum`` = Prefixed_Name(w3id, "AIRO#asylum") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#border_control_management</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#border_control_management">https://w3id.org/AIRO#border_control_management</seealso>
    let ``AIRO#border_control_management`` =
        Prefixed_Name(w3id, "AIRO#border_control_management") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#citizenshipApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who has applied for citizenship."</para>
    /// labels<para>"Citizenship Applicant"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#citizenshipApplicant">https://w3id.org/AIRO#citizenshipApplicant</seealso>
    let ``AIRO#citizenshipApplicant`` =
        Prefixed_Name(w3id, "AIRO#citizenshipApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#dectection_of_criminal_offences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#ExecutionEnvironment</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#dectection_of_criminal_offences">https://w3id.org/AIRO#dectection_of_criminal_offences</seealso>
    let ``AIRO#dectection_of_criminal_offences`` =
        Prefixed_Name(w3id, "AIRO#dectection_of_criminal_offences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#detectsEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"detects event"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#detectsEvent">https://w3id.org/AIRO#detectsEvent</seealso>
    let ``AIRO#detectsEvent`` = Prefixed_Name(w3id, "AIRO#detectsEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#development</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#AILifecyclePhase</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#development">https://w3id.org/AIRO#development</seealso>
    let ``AIRO#development`` = Prefixed_Name(w3id, "AIRO#development") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#education</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#education">https://w3id.org/AIRO#education</seealso>
    let ``AIRO#education`` = Prefixed_Name(w3id, "AIRO#education") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#eliminatesEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"eliminates event"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#eliminatesEvent">https://w3id.org/AIRO#eliminatesEvent</seealso>
    let ``AIRO#eliminatesEvent`` =
        Prefixed_Name(w3id, "AIRO#eliminatesEvent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#employment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#employment">https://w3id.org/AIRO#employment</seealso>
    let ``AIRO#employment`` = Prefixed_Name(w3id, "AIRO#employment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#essential_private_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#essential_private_service">https://w3id.org/AIRO#essential_private_service</seealso>
    let ``AIRO#essential_private_service`` =
        Prefixed_Name(w3id, "AIRO#essential_private_service") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasAIIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has AI indicator"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasAIIndicator">https://w3id.org/AIRO#hasAIIndicator</seealso>
    let ``AIRO#hasAIIndicator`` =
        Prefixed_Name(w3id, "AIRO#hasAIIndicator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasApplication">https://w3id.org/AIRO#hasApplication</seealso>
    let ``AIRO#hasApplication`` =
        Prefixed_Name(w3id, "AIRO#hasApplication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates components of an AI system."</para>
    /// labels<para>"has component"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasComponent">https://w3id.org/AIRO#hasComponent</seealso>
    let ``AIRO#hasComponent`` = Prefixed_Name(w3id, "AIRO#hasComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasConsequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has consequence"</para><para>"has consequence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasConsequence">https://w3id.org/AIRO#hasConsequence</seealso>
    let ``AIRO#hasConsequence`` =
        Prefixed_Name(w3id, "AIRO#hasConsequence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has documentation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasDocumentation">https://w3id.org/AIRO#hasDocumentation</seealso>
    let ``AIRO#hasDocumentation`` =
        Prefixed_Name(w3id, "AIRO#hasDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasExecutionEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has execution environment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasExecutionEnvironment">https://w3id.org/AIRO#hasExecutionEnvironment</seealso>
    let ``AIRO#hasExecutionEnvironment`` =
        Prefixed_Name(w3id, "AIRO#hasExecutionEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasExpectedAccuray</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has expected accuracy"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasExpectedAccuray">https://w3id.org/AIRO#hasExpectedAccuray</seealso>
    let ``AIRO#hasExpectedAccuray`` =
        Prefixed_Name(w3id, "AIRO#hasExpectedAccuray") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has impact"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasImpact">https://w3id.org/AIRO#hasImpact</seealso>
    let ``AIRO#hasImpact`` = Prefixed_Name(w3id, "AIRO#hasImpact") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasImpactOnAISubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has impact on AI subject"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasImpactOnAISubject">https://w3id.org/AIRO#hasImpactOnAISubject</seealso>
    let ``AIRO#hasImpactOnAISubject`` =
        Prefixed_Name(w3id, "AIRO#hasImpactOnAISubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasImpactOnArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has impact on area"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasImpactOnArea">https://w3id.org/AIRO#hasImpactOnArea</seealso>
    let ``AIRO#hasImpactOnArea`` =
        Prefixed_Name(w3id, "AIRO#hasImpactOnArea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasLifecyclePhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has lifecycle phase"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasLifecyclePhase">https://w3id.org/AIRO#hasLifecyclePhase</seealso>
    let ``AIRO#hasLifecyclePhase`` =
        Prefixed_Name(w3id, "AIRO#hasLifecyclePhase") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasLikelihood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the probability of occurrence of an event."</para>
    /// labels<para>"has likelihood"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasLikelihood">https://w3id.org/AIRO#hasLikelihood</seealso>
    let ``AIRO#hasLikelihood`` =
        Prefixed_Name(w3id, "AIRO#hasLikelihood") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasModeOfOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has mode of operation"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasModeOfOperation">https://w3id.org/AIRO#hasModeOfOperation</seealso>
    let ``AIRO#hasModeOfOperation`` =
        Prefixed_Name(w3id, "AIRO#hasModeOfOperation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasPostmarketMonitoringSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has post-market monitoring system"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasPostmarketMonitoringSystem">https://w3id.org/AIRO#hasPostmarketMonitoringSystem</seealso>
    let ``AIRO#hasPostmarketMonitoringSystem`` =
        Prefixed_Name(w3id, "AIRO#hasPostmarketMonitoringSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Indicates the intended purpose of an AI system."</para><para>"has purpose"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasPurpose">https://w3id.org/AIRO#hasPurpose</seealso>
    let ``AIRO#hasPurpose`` = Prefixed_Name(w3id, "AIRO#hasPurpose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#hasRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has risk"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasRisk">https://w3id.org/AIRO#hasRisk</seealso>
    let ``AIRO#hasRisk`` = Prefixed_Name(w3id, "AIRO#hasRisk") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#hasSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has severity"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasSeverity">https://w3id.org/AIRO#hasSeverity</seealso>
    let ``AIRO#hasSeverity`` = Prefixed_Name(w3id, "AIRO#hasSeverity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasStakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates stakeholders of an AI system"</para>
    /// labels<para>"has stakeholder"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasStakeholder">https://w3id.org/AIRO#hasStakeholder</seealso>
    let ``AIRO#hasStakeholder`` =
        Prefixed_Name(w3id, "AIRO#hasStakeholder") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has version"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasVersion">https://w3id.org/AIRO#hasVersion</seealso>
    let ``AIRO#hasVersion`` = Prefixed_Name(w3id, "AIRO#hasVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#hasVulnerability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates vulnerabilities of an AI system."</para>
    /// labels<para>"has vulnerability"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#hasVulnerability">https://w3id.org/AIRO#hasVulnerability</seealso>
    let ``AIRO#hasVulnerability`` =
        Prefixed_Name(w3id, "AIRO#hasVulnerability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#inception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#AILifecyclePhase</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#inception">https://w3id.org/AIRO#inception</seealso>
    let ``AIRO#inception`` = Prefixed_Name(w3id, "AIRO#inception") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#investigation_of_criminal_offences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#ExecutionEnvironment</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#investigation_of_criminal_offences">https://w3id.org/AIRO#investigation_of_criminal_offences</seealso>
    let ``AIRO#investigation_of_criminal_offences`` =
        Prefixed_Name(w3id, "AIRO#investigation_of_criminal_offences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isAppliedWithinDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the domain (context) the AI system is intended to be used in."</para>
    /// labels<para>"is applied within domain"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isAppliedWithinDomain">https://w3id.org/AIRO#isAppliedWithinDomain</seealso>
    let ``AIRO#isAppliedWithinDomain`` =
        Prefixed_Name(w3id, "AIRO#isAppliedWithinDomain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isDevelopedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is developed by"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isDevelopedBy">https://w3id.org/AIRO#isDevelopedBy</seealso>
    let ``AIRO#isDevelopedBy`` =
        Prefixed_Name(w3id, "AIRO#isDevelopedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isExpectedAccurayOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is expected accuracy of"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isExpectedAccurayOf">https://w3id.org/AIRO#isExpectedAccurayOf</seealso>
    let ``AIRO#isExpectedAccurayOf`` =
        Prefixed_Name(w3id, "AIRO#isExpectedAccurayOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isExtentOfUseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is extent of use of"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isExtentOfUseOf">https://w3id.org/AIRO#isExtentOfUseOf</seealso>
    let ``AIRO#isExtentOfUseOf`` =
        Prefixed_Name(w3id, "AIRO#isExtentOfUseOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isFollowedByControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is followed by control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isFollowedByControl">https://w3id.org/AIRO#isFollowedByControl</seealso>
    let ``AIRO#isFollowedByControl`` =
        Prefixed_Name(w3id, "AIRO#isFollowedByControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isInVulnerablePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is in vulnerable position"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isInVulnerablePosition">https://w3id.org/AIRO#isInVulnerablePosition</seealso>
    let ``AIRO#isInVulnerablePosition`` =
        Prefixed_Name(w3id, "AIRO#isInVulnerablePosition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isPartOfControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is part of control"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isPartOfControl">https://w3id.org/AIRO#isPartOfControl</seealso>
    let ``AIRO#isPartOfControl`` =
        Prefixed_Name(w3id, "AIRO#isPartOfControl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isPerformanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is performance of"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isPerformanceOf">https://w3id.org/AIRO#isPerformanceOf</seealso>
    let ``AIRO#isPerformanceOf`` =
        Prefixed_Name(w3id, "AIRO#isPerformanceOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isRiskSourceFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is risk source for"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isRiskSourceFor">https://w3id.org/AIRO#isRiskSourceFor</seealso>
    let ``AIRO#isRiskSourceFor`` =
        Prefixed_Name(w3id, "AIRO#isRiskSourceFor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isTechnicalSpecAppliedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is technical spec applied in"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isTechnicalSpecAppliedIn">https://w3id.org/AIRO#isTechnicalSpecAppliedIn</seealso>
    let ``AIRO#isTechnicalSpecAppliedIn`` =
        Prefixed_Name(w3id, "AIRO#isTechnicalSpecAppliedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isUsedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is used by"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isUsedBy">https://w3id.org/AIRO#isUsedBy</seealso>
    let ``AIRO#isUsedBy`` = Prefixed_Name(w3id, "AIRO#isUsedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isUsedForTesting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is used for testing"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isUsedForTesting">https://w3id.org/AIRO#isUsedForTesting</seealso>
    let ``AIRO#isUsedForTesting`` =
        Prefixed_Name(w3id, "AIRO#isUsedForTesting") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isUsedForTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is used for training"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isUsedForTraining">https://w3id.org/AIRO#isUsedForTraining</seealso>
    let ``AIRO#isUsedForTraining`` =
        Prefixed_Name(w3id, "AIRO#isUsedForTraining") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isUsedForValidating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is used for validating"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isUsedForValidating">https://w3id.org/AIRO#isUsedForValidating</seealso>
    let ``AIRO#isUsedForValidating`` =
        Prefixed_Name(w3id, "AIRO#isUsedForValidating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isUsedInEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is used in environment"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isUsedInEnvironment">https://w3id.org/AIRO#isUsedInEnvironment</seealso>
    let ``AIRO#isUsedInEnvironment`` =
        Prefixed_Name(w3id, "AIRO#isUsedInEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isUsedInFormOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is used in form of"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isUsedInFormOf">https://w3id.org/AIRO#isUsedInFormOf</seealso>
    let ``AIRO#isUsedInFormOf`` =
        Prefixed_Name(w3id, "AIRO#isUsedInFormOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#isUsedToMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is used to measure"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#isUsedToMeasure">https://w3id.org/AIRO#isUsedToMeasure</seealso>
    let ``AIRO#isUsedToMeasure`` =
        Prefixed_Name(w3id, "AIRO#isUsedToMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#law_enforcement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#law_enforcement">https://w3id.org/AIRO#law_enforcement</seealso>
    let ``AIRO#law_enforcement`` =
        Prefixed_Name(w3id, "AIRO#law_enforcement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#management_of_road_traffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#management_of_road_traffic">https://w3id.org/AIRO#management_of_road_traffic</seealso>
    let ``AIRO#management_of_road_traffic`` =
        Prefixed_Name(w3id, "AIRO#management_of_road_traffic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#management_of_supply_of_heating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#management_of_supply_of_heating">https://w3id.org/AIRO#management_of_supply_of_heating</seealso>
    let ``AIRO#management_of_supply_of_heating`` =
        Prefixed_Name(w3id, "AIRO#management_of_supply_of_heating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#management_of_the_supply_of_electricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#management_of_the_supply_of_electricity">https://w3id.org/AIRO#management_of_the_supply_of_electricity</seealso>
    let ``AIRO#management_of_the_supply_of_electricity`` =
        Prefixed_Name(w3id, "AIRO#management_of_the_supply_of_electricity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#management_of_the_supply_of_gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#management_of_the_supply_of_gas">https://w3id.org/AIRO#management_of_the_supply_of_gas</seealso>
    let ``AIRO#management_of_the_supply_of_gas`` =
        Prefixed_Name(w3id, "AIRO#management_of_the_supply_of_gas") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#management_of_the_supply_of_water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#management_of_the_supply_of_water">https://w3id.org/AIRO#management_of_the_supply_of_water</seealso>
    let ``AIRO#management_of_the_supply_of_water`` =
        Prefixed_Name(w3id, "AIRO#management_of_the_supply_of_water") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#migration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#migration">https://w3id.org/AIRO#migration</seealso>
    let ``AIRO#migration`` = Prefixed_Name(w3id, "AIRO#migration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#mitigatesEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"mitigates event"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#mitigatesEvent">https://w3id.org/AIRO#mitigatesEvent</seealso>
    let ``AIRO#mitigatesEvent`` =
        Prefixed_Name(w3id, "AIRO#mitigatesEvent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#modifiesEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"modifies event"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#modifiesEvent">https://w3id.org/AIRO#modifiesEvent</seealso>
    let ``AIRO#modifiesEvent`` =
        Prefixed_Name(w3id, "AIRO#modifiesEvent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#operation_of_road_traffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#operation_of_road_traffic">https://w3id.org/AIRO#operation_of_road_traffic</seealso>
    let ``AIRO#operation_of_road_traffic`` =
        Prefixed_Name(w3id, "AIRO#operation_of_road_traffic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#operation_of_the_supply_of_electricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#operation_of_the_supply_of_electricity">https://w3id.org/AIRO#operation_of_the_supply_of_electricity</seealso>
    let ``AIRO#operation_of_the_supply_of_electricity`` =
        Prefixed_Name(w3id, "AIRO#operation_of_the_supply_of_electricity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#operation_of_the_supply_of_gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#operation_of_the_supply_of_gas">https://w3id.org/AIRO#operation_of_the_supply_of_gas</seealso>
    let ``AIRO#operation_of_the_supply_of_gas`` =
        Prefixed_Name(w3id, "AIRO#operation_of_the_supply_of_gas") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#operation_of_the_supply_of_heating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#operation_of_the_supply_of_heating">https://w3id.org/AIRO#operation_of_the_supply_of_heating</seealso>
    let ``AIRO#operation_of_the_supply_of_heating`` =
        Prefixed_Name(w3id, "AIRO#operation_of_the_supply_of_heating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#operation_of_the_supply_of_water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#operation_of_the_supply_of_water">https://w3id.org/AIRO#operation_of_the_supply_of_water</seealso>
    let ``AIRO#operation_of_the_supply_of_water`` =
        Prefixed_Name(w3id, "AIRO#operation_of_the_supply_of_water") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#post</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#OperationMode</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#post">https://w3id.org/AIRO#post</seealso>
    let ``AIRO#post`` = Prefixed_Name(w3id, "AIRO#post") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#post-market</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#AILifecyclePhase</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#post-market">https://w3id.org/AIRO#post-market</seealso>
    let ``AIRO#post_market`` = Prefixed_Name(w3id, "AIRO#post-market") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#producesOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"produces output"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#producesOutput">https://w3id.org/AIRO#producesOutput</seealso>
    let ``AIRO#producesOutput`` =
        Prefixed_Name(w3id, "AIRO#producesOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#AISystemForm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#product">https://w3id.org/AIRO#product</seealso>
    let ``AIRO#product`` = Prefixed_Name(w3id, "AIRO#product") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#prosecution_of_criminal_offences</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#ExecutionEnvironment</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#prosecution_of_criminal_offences">https://w3id.org/AIRO#prosecution_of_criminal_offences</seealso>
    let ``AIRO#prosecution_of_criminal_offences`` =
        Prefixed_Name(w3id, "AIRO#prosecution_of_criminal_offences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#public_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#public_service">https://w3id.org/AIRO#public_service</seealso>
    let ``AIRO#public_service`` =
        Prefixed_Name(w3id, "AIRO#public_service") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#publicly_accessible_space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#ExecutionEnvironment</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#publicly_accessible_space">https://w3id.org/AIRO#publicly_accessible_space</seealso>
    let ``AIRO#publicly_accessible_space`` =
        Prefixed_Name(w3id, "AIRO#publicly_accessible_space") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#real-time</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#OperationMode</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#real-time">https://w3id.org/AIRO#real-time</seealso>
    let ``AIRO#real_time`` = Prefixed_Name(w3id, "AIRO#real-time") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#saftey_component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#AISystemForm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#saftey_component">https://w3id.org/AIRO#saftey_component</seealso>
    let ``AIRO#saftey_component`` =
        Prefixed_Name(w3id, "AIRO#saftey_component") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#self_employment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#self_employment">https://w3id.org/AIRO#self_employment</seealso>
    let ``AIRO#self_employment`` =
        Prefixed_Name(w3id, "AIRO#self_employment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#AISystemForm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#service">https://w3id.org/AIRO#service</seealso>
    let ``AIRO#service`` = Prefixed_Name(w3id, "AIRO#service") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#AISystemForm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#software">https://w3id.org/AIRO#software</seealso>
    let ``AIRO#software`` = Prefixed_Name(w3id, "AIRO#software") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#testing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#AILifecyclePhase</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#testing">https://w3id.org/AIRO#testing</seealso>
    let ``AIRO#testing`` = Prefixed_Name(w3id, "AIRO#testing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#training</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#AILifecyclePhase</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#training">https://w3id.org/AIRO#training</seealso>
    let ``AIRO#training`` = Prefixed_Name(w3id, "AIRO#training") |> PrefixedName
    /// <summary>
    ///   <para>w3id:AIRO#usesStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses standard"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#usesStandard">https://w3id.org/AIRO#usesStandard</seealso>
    let ``AIRO#usesStandard`` = Prefixed_Name(w3id, "AIRO#usesStandard") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#usesTechnicalSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses technical specification"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#usesTechnicalSpecification">https://w3id.org/AIRO#usesTechnicalSpecification</seealso>
    let ``AIRO#usesTechnicalSpecification`` =
        Prefixed_Name(w3id, "AIRO#usesTechnicalSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#usesTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the AI techniques used in an AI system."</para>
    /// labels<para>"uses technique"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#usesTechnique">https://w3id.org/AIRO#usesTechnique</seealso>
    let ``AIRO#usesTechnique`` =
        Prefixed_Name(w3id, "AIRO#usesTechnique") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#AILifecyclePhase</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#validation">https://w3id.org/AIRO#validation</seealso>
    let ``AIRO#validation`` = Prefixed_Name(w3id, "AIRO#validation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#vocational_training</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:AIRO#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#vocational_training">https://w3id.org/AIRO#vocational_training</seealso>
    let ``AIRO#vocational_training`` =
        Prefixed_Name(w3id, "AIRO#vocational_training") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#vulnerability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Weakness of a system can be exploited by one or more threats. [Source: ISO/IEC TR 24028, 3.48 with modifications]"</para>
    /// labels<para>"Vulnerability"</para></remarks>
    /// <seealso href="https://w3id.org/AIRO#vulnerability">https://w3id.org/AIRO#vulnerability</seealso>
    let ``AIRO#vulnerability`` =
        Prefixed_Name(w3id, "AIRO#vulnerability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:AIRO#workers_management</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:AIRO#Domain</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/AIRO#workers_management">https://w3id.org/AIRO#workers_management</seealso>
    let ``AIRO#workers_management`` =
        Prefixed_Name(w3id, "AIRO#workers_management") |> PrefixedName

    /// <summary>
    ///   <para>w3id:BCI-ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"&lt;p&gt;This ontology describes the framework of core concepts to capture the specialized metadata vocabulary set for multimodal "&lt;strong&gt;&lt;a title="Brain&amp;ndash;computer interface (BCI)" href="https://en.wikipedia.org/wiki/Brain%E2%80%93computer_interface" target="_blank"&gt;Brain Computing Interface&lt;/a&gt;&lt;/strong&gt;" (BCI) data capture activities.&lt;/p&gt;
    ///
    /// &lt;p&gt;This ontology is developed by the "Pervasive Embedded Technologies" Laboratory (PET Lab) at the Computer Science Department of the National Chiao Tung University (NCTU), Taiwan (Republic of China, R.O.C). The concepts and structure of the ontology depict a foundational metadata model for BCI data capture activities, that BCI applications can extend and use in their implementations.&lt;/p&gt;
    ///
    /// &lt;p&gt;Any feedback is welcome. Please mail it to &lt;u&gt;srodriguez@pet.cs.nctu.edu.tw&lt;/u&gt;&lt;/p&gt;"^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology">https://w3id.org/BCI-ontology</seealso>
    let BCI_ontology = Prefixed_Name(w3id, "BCI-ontology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sepses/ns/log#Event</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/sepses/ns/log#Event">https://w3id.org/sepses/ns/log#Event</seealso>
    let ``sepses/ns/log#Event`` =
        Prefixed_Name(w3id, "sepses/ns/log#Event") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sepses/ns/log#Host</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/sepses/ns/log#Host">https://w3id.org/sepses/ns/log#Host</seealso>
    let ``sepses/ns/log#Host`` =
        Prefixed_Name(w3id, "sepses/ns/log#Host") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sepses/ns/log#hasSourceHost</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/sepses/ns/log#hasSourceHost">https://w3id.org/sepses/ns/log#hasSourceHost</seealso>
    let ``sepses/ns/log#hasSourceHost`` =
        Prefixed_Name(w3id, "sepses/ns/log#hasSourceHost") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sepses/ns/log#host</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/sepses/ns/log#host">https://w3id.org/sepses/ns/log#host</seealso>
    let ``sepses/ns/log#host`` =
        Prefixed_Name(w3id, "sepses/ns/log#host") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sepses/ns/log#msg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/sepses/ns/log#msg">https://w3id.org/sepses/ns/log#msg</seealso>
    let ``sepses/ns/log#msg`` = Prefixed_Name(w3id, "sepses/ns/log#msg") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sepses/ns/log#time</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/sepses/ns/log#time">https://w3id.org/sepses/ns/log#time</seealso>
    let ``sepses/ns/log#time`` =
        Prefixed_Name(w3id, "sepses/ns/log#time") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sepses/vocab/ref/attack/2.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/sepses/vocab/ref/attack/2.0.0">https://w3id.org/sepses/vocab/ref/attack/2.0.0</seealso>
    let ``sepses/vocab/ref/attack/2.0.0`` =
        Prefixed_Name(w3id, "sepses/vocab/ref/attack/2.0.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:BLIND</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BLIND">https://w3id.org/BLIND</seealso>
    let BLIND = Prefixed_Name(w3id, "BLIND") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CEMontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"-Version 1.1: Insertion of ontology descriptors to be inserted in Linked Open Vocabulary-Version 1: creation"</para>
    ///   <para>"The Crime Event Model is an ontology for the representation of crime events extracted from local newspapers. It could be employed for Crime Analysis purposes: extracting crime information from newspapers and enriching them with proper machine-readable semantics is a critical task to help law enforcement agencies at preventing crime, supporting criminal investigations and evaluating the action of law enforcement agencies themselves. The model is based on the fundamental 5W1H journalistic questions, that are Who?, What?, When?, Where?, Why? and How?. Another important requirement was the attempt to exploit existing knowledge graphs and ontologies such as the Simple Event Model (SEM) Ontology and the Schema.org data model for interoperability and interconnection."</para>
    /// labels<para>"Crime Event Model (CEM)"</para></remarks>
    /// <seealso href="https://w3id.org/CEMontology">https://w3id.org/CEMontology</seealso>
    let CEMontology = Prefixed_Name(w3id, "CEMontology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"1.0.1 release of the CPSWatch Ontology"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/CPSWatch">https://w3id.org/CPSWatch</seealso>
    let CPSWatch = Prefixed_Name(w3id, "CPSWatch") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch/1.0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/CPSWatch/1.0.1">https://w3id.org/CPSWatch/1.0.1</seealso>
    let ``CPSWatch/1.0.1`` = Prefixed_Name(w3id, "CPSWatch/1.0.1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:EUTaxO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"EUTaxO - EUdaphobase Taxonomy Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO">https://w3id.org/EUTaxO</seealso>
    let EUTaxO = Prefixed_Name(w3id, "EUTaxO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GConsent">https://w3id.org/GConsent</seealso>
    let GConsent = Prefixed_Name(w3id, "GConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GConsent/versions/v0.5</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GConsent/versions/v0.5">https://w3id.org/GConsent/versions/v0.5</seealso>
    let ``GConsent/versions/v0.5`` =
        Prefixed_Name(w3id, "GConsent/versions/v0.5") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"GDPRov is an ontology for expressing provenance metadata in the context of the General Data Protection Regulation (GDPR) and its compliance. It extends PROV-O and P-Plan. PROV-O is the ontology based on the PROV model, a W3C recommendation, while P-Plan is an extension of PROV-O. PROV is used to define terms or 'instances' of what has happened in the past, while P-Plan is used to define the abstract model or 'Plan' of things to happen. GDPRov uses P-Plan to create a template/model/plan as an abstract or model representation of a system which is then recorded using PROV-O instances to show something has happened. The aim of the ontology is to enable representation of consent and personal data lifecycles using terms relevant to GDPR and to facilitate expression of this information towards documentation related to compliance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GDPRov">https://w3id.org/GDPRov</seealso>
    let GDPRov = Prefixed_Name(w3id, "GDPRov") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci/1.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci/1.1">https://w3id.org/skgo/modsci/1.1</seealso>
    let ``skgo/modsci/1.1`` = Prefixed_Name(w3id, "skgo/modsci/1.1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRtEXT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This is an ontology to represent GDPR text as a set of RDF resources"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GDPR text EXTensions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT">https://w3id.org/GDPRtEXT</seealso>
    let GDPRtEXT = Prefixed_Name(w3id, "GDPRtEXT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Smart Readiness Indicator Vocabulary"</para></remarks>
    /// <seealso href="https://w3id.org/sri">https://w3id.org/sri</seealso>
    let sri = Prefixed_Name(w3id, "sri") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri/1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/sri/1.0">https://w3id.org/sri/1.0</seealso>
    let ``sri/1.0`` = Prefixed_Name(w3id, "sri/1.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:stax/dev</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/stax/dev">https://w3id.org/stax/dev</seealso>
    let ``stax/dev`` = Prefixed_Name(w3id, "stax/dev") |> PrefixedName

    /// <summary>
    ///   <para>w3id:stax/dev/assets/logo_color.svg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/stax/dev/assets/logo_color.svg">https://w3id.org/stax/dev/assets/logo_color.svg</seealso>
    let ``stax/dev/assets/logo_color.svg`` =
        Prefixed_Name(w3id, "stax/dev/assets/logo_color.svg") |> PrefixedName

    /// <summary>
    ///   <para>w3id:stax/dev/ontology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/stax/dev/ontology">https://w3id.org/stax/dev/ontology</seealso>
    let ``stax/dev/ontology`` = Prefixed_Name(w3id, "stax/dev/ontology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:stax/dev/use-it/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/stax/dev/use-it/">https://w3id.org/stax/dev/use-it/</seealso>
    let ``stax/dev/use_it/`` = Prefixed_Name(w3id, "stax/dev/use-it/") |> PrefixedName
    /// <summary>
    ///   <para>w3id:stax/ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology">https://w3id.org/stax/ontology</seealso>
    let ``stax/ontology`` = Prefixed_Name(w3id, "stax/ontology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/sulo/">https://w3id.org/sulo/</seealso>
    let ``sulo/`` = Prefixed_Name(w3id, "sulo/") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/Capability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A capability is a feature that describes what an entity is able to do, under some set of circumstances."</para>
    /// labels<para>"capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Capability">https://w3id.org/sulo/Capability</seealso>
    let ``sulo/Capability`` = Prefixed_Name(w3id, "sulo/Capability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"Duration is a temporal quantity that represents the extent or (non-negative) amount of time that elapses between two temporal points, typically the start and end of a time interval."</para>
    /// labels<para>"duration"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Duration">https://w3id.org/sulo/Duration</seealso>
    let ``sulo/Duration`` = Prefixed_Name(w3id, "sulo/Duration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/EndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"an end time is a time instant at the end of a process/time interval."</para>
    /// labels<para>"end time"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/EndTime">https://w3id.org/sulo/EndTime</seealso>
    let ``sulo/EndTime`` = Prefixed_Name(w3id, "sulo/EndTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A feature is any characteristic that stems from the intrisinc structure and/or context"</para>
    /// labels<para>"feature"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Feature">https://w3id.org/sulo/Feature</seealso>
    let ``sulo/Feature`` = Prefixed_Name(w3id, "sulo/Feature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/InformationObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"an information object is a feature that represents, is about, or encodes some information."</para>
    /// labels<para>"information object"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/InformationObject">https://w3id.org/sulo/InformationObject</seealso>
    let ``sulo/InformationObject`` =
        Prefixed_Name(w3id, "sulo/InformationObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object is an entity that maintains its identity through time, and does not have processes as its parts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"object"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Object">https://w3id.org/sulo/Object</seealso>
    let ``sulo/Object`` = Prefixed_Name(w3id, "sulo/Object") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a process is a entity that unfolds in time, has temporal parts, and has objects that participate in the process."</para>
    /// labels<para>"process"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Process">https://w3id.org/sulo/Process</seealso>
    let ``sulo/Process`` = Prefixed_Name(w3id, "sulo/Process") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the color of an apple, the smoothness of skin, the brightness of a star, the speed of an event"</para>
    ///   <para>"A quality is a feature that is intrinsically associated with its bearer (or its parts)."</para>
    /// labels<para>"quality"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Quality">https://w3id.org/sulo/Quality</seealso>
    let ``sulo/Quality`` = Prefixed_Name(w3id, "sulo/Quality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A quantity is an informational object that contains the magnitude (and unit) of an attribute."</para>
    /// labels<para>"quantity"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Quantity">https://w3id.org/sulo/Quantity</seealso>
    let ``sulo/Quantity`` = Prefixed_Name(w3id, "sulo/Quantity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A role is a feature that describes a context-dependent behaviour."</para>
    /// labels<para>"role"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Role">https://w3id.org/sulo/Role</seealso>
    let ``sulo/Role`` = Prefixed_Name(w3id, "sulo/Role") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/Set</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set is an information object for which there may be zero or more items."</para>
    /// labels<para>"set"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Set">https://w3id.org/sulo/Set</seealso>
    let ``sulo/Set`` = Prefixed_Name(w3id, "sulo/Set") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/SpatialObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A spatial object is an object that occupies space"</para>
    /// labels<para>"spatial object"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/SpatialObject">https://w3id.org/sulo/SpatialObject</seealso>
    let ``sulo/SpatialObject`` =
        Prefixed_Name(w3id, "sulo/SpatialObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/StartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a start time is a time instant at the beginning of a process/time interval."</para>
    /// labels<para>"start time"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/StartTime">https://w3id.org/sulo/StartTime</seealso>
    let ``sulo/StartTime`` = Prefixed_Name(w3id, "sulo/StartTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"time is a quantity pertaining to the duration of some interval of time or a particular instant of time (against some frame of reference)."</para>
    /// labels<para>"time"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Time">https://w3id.org/sulo/Time</seealso>
    let ``sulo/Time`` = Prefixed_Name(w3id, "sulo/Time") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/TimeInstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"time instant is a quantity of time a particular moment in time."</para>
    /// labels<para>"time instant"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/TimeInstant">https://w3id.org/sulo/TimeInstant</seealso>
    let ``sulo/TimeInstant`` = Prefixed_Name(w3id, "sulo/TimeInstant") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A time interval is a quantity for a continuous and bounded extent of time, characterized by a start time and an end time."</para>
    /// labels<para>"time interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sulo/TimeInterval">https://w3id.org/sulo/TimeInterval</seealso>
    let ``sulo/TimeInterval`` = Prefixed_Name(w3id, "sulo/TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a unit is a standardized quantity that is used as a reference for a particular quantity."</para>
    /// labels<para>"unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sulo/Unit">https://w3id.org/sulo/Unit</seealso>
    let ``sulo/Unit`` = Prefixed_Name(w3id, "sulo/Unit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a relation between any thing and the time in which it occurs at."</para>
    /// labels<para>"at time"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/atTime">https://w3id.org/sulo/atTime</seealso>
    let ``sulo/atTime`` = Prefixed_Name(w3id, "sulo/atTime") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/hasDirectPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"has direct part is a non-transitive parthood relation that can be used to specify cardinality constraints between a whole and its parts."</para>
    /// labels<para>"has direct part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sulo/hasDirectPart">https://w3id.org/sulo/hasDirectPart</seealso>
    let ``sulo/hasDirectPart`` =
        Prefixed_Name(w3id, "sulo/hasDirectPart") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr">https://w3id.org/GDPRtEXT/gdpr</seealso>
    let ``GDPRtEXT/gdpr`` = Prefixed_Name(w3id, "GDPRtEXT/gdpr") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/hasFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"has feature is a relation between a thing and an internal, contextual, or externally attributed characteristic."</para>
    /// labels<para>"has feature"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/hasFeature">https://w3id.org/sulo/hasFeature</seealso>
    let ``sulo/hasFeature`` = Prefixed_Name(w3id, "sulo/hasFeature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article10</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article10">https://w3id.org/GDPRtEXT/gdpr#article10</seealso>
    let ``GDPRtEXT/gdpr#article10`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article10") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"has item is a relation between a collection and an item contained therein."</para>
    /// labels<para>"has item"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/hasMember">https://w3id.org/sulo/hasMember</seealso>
    let ``sulo/hasMember`` = Prefixed_Name(w3id, "sulo/hasMember") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article12</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article12">https://w3id.org/GDPRtEXT/gdpr#article12</seealso>
    let ``GDPRtEXT/gdpr#article12`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article12") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>"has part is a transitive, reflexive and antisymmetric relation between a whole and itself or a whole and its part."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has part"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/hasPart">https://w3id.org/sulo/hasPart</seealso>
    let ``sulo/hasPart`` = Prefixed_Name(w3id, "sulo/hasPart") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article12-2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article12-2">https://w3id.org/GDPRtEXT/gdpr#article12-2</seealso>
    let ``GDPRtEXT/gdpr#article12_2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article12-2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"has participant is a relation that describes the participation of a (non-process) thing in a process."</para>
    /// labels<para>"has participant"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/hasParticipant">https://w3id.org/sulo/hasParticipant</seealso>
    let ``sulo/hasParticipant`` =
        Prefixed_Name(w3id, "sulo/hasParticipant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article12-5</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article12-5">https://w3id.org/GDPRtEXT/gdpr#article12-5</seealso>
    let ``GDPRtEXT/gdpr#article12_5`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article12-5") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"has value is the (only) data type attribute to store the values of information objects."</para>
    /// labels<para>"has value"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/hasValue">https://w3id.org/sulo/hasValue</seealso>
    let ``sulo/hasValue`` = Prefixed_Name(w3id, "sulo/hasValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article13</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article13">https://w3id.org/GDPRtEXT/gdpr#article13</seealso>
    let ``GDPRtEXT/gdpr#article13`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article13") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/isDirectPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is direct part is a non-transitive parthood relation that can be used to specify cardinality constraints between a part and its whole."</para>
    /// labels<para>"is direct part of"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/isDirectPartOf">https://w3id.org/sulo/isDirectPartOf</seealso>
    let ``sulo/isDirectPartOf`` =
        Prefixed_Name(w3id, "sulo/isDirectPartOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article14</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article14">https://w3id.org/GDPRtEXT/gdpr#article14</seealso>
    let ``GDPRtEXT/gdpr#article14`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article14") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/isFeatureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"is feature of is a relation between an internal, contextual, or externally attributed characteristic and some Thing."</para>
    /// labels<para>"is feature of"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/isFeatureOf">https://w3id.org/sulo/isFeatureOf</seealso>
    let ``sulo/isFeatureOf`` = Prefixed_Name(w3id, "sulo/isFeatureOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article15</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article15">https://w3id.org/GDPRtEXT/gdpr#article15</seealso>
    let ``GDPRtEXT/gdpr#article15`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article15") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/isItemIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"has item is a relation between an item and the collection in which it contained."</para>
    /// labels<para>"is item in"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/isItemIn">https://w3id.org/sulo/isItemIn</seealso>
    let ``sulo/isItemIn`` = Prefixed_Name(w3id, "sulo/isItemIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article15-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article15-3">https://w3id.org/GDPRtEXT/gdpr#article15-3</seealso>
    let ``GDPRtEXT/gdpr#article15_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article15-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/isLocatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A is located in B iff the spatialtemporal region occupied by B is the spatialtemporal region occupied by A."</para>
    /// labels<para>"is located in"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/isLocatedIn">https://w3id.org/sulo/isLocatedIn</seealso>
    let ``sulo/isLocatedIn`` = Prefixed_Name(w3id, "sulo/isLocatedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article15-4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article15-4">https://w3id.org/GDPRtEXT/gdpr#article15-4</seealso>
    let ``GDPRtEXT/gdpr#article15_4`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article15-4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/isLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A is location of B iff the spatialtemporal region occupied by A is the spatialtemporal region occupied by B."</para>
    /// labels<para>"is location of"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/isLocationOf">https://w3id.org/sulo/isLocationOf</seealso>
    let ``sulo/isLocationOf`` = Prefixed_Name(w3id, "sulo/isLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article16</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article16">https://w3id.org/GDPRtEXT/gdpr#article16</seealso>
    let ``GDPRtEXT/gdpr#article16`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article16") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is part of is a transitive, reflexive and antisymmetric relation between a part and itself or a part and a whole."</para>
    /// labels<para>"is part of"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/isPartOf">https://w3id.org/sulo/isPartOf</seealso>
    let ``sulo/isPartOf`` = Prefixed_Name(w3id, "sulo/isPartOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article17</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article17">https://w3id.org/GDPRtEXT/gdpr#article17</seealso>
    let ``GDPRtEXT/gdpr#article17`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article17") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/isParticipantIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is participant in is a relation to relate an object and the process in which it participates."</para>
    /// labels<para>"is participant in"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/isParticipantIn">https://w3id.org/sulo/isParticipantIn</seealso>
    let ``sulo/isParticipantIn`` =
        Prefixed_Name(w3id, "sulo/isParticipantIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/isPrecededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation in which one process occurs after to another process."</para>
    /// labels<para>"is preceded by"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/isPrecededBy">https://w3id.org/sulo/isPrecededBy</seealso>
    let ``sulo/isPrecededBy`` = Prefixed_Name(w3id, "sulo/isPrecededBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article18</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article18">https://w3id.org/GDPRtEXT/gdpr#article18</seealso>
    let ``GDPRtEXT/gdpr#article18`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article18") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/isReferredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"is referred in is relation between an object that is the subject of an information object."</para>
    /// labels<para>"is referred in"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/isReferredIn">https://w3id.org/sulo/isReferredIn</seealso>
    let ``sulo/isReferredIn`` = Prefixed_Name(w3id, "sulo/isReferredIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sulo/isTimeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a relation between a time and an object that occurs within it."</para>
    /// labels<para>"is time of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sulo/isTimeOf">https://w3id.org/sulo/isTimeOf</seealso>
    let ``sulo/isTimeOf`` = Prefixed_Name(w3id, "sulo/isTimeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article2-2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article2-2">https://w3id.org/GDPRtEXT/gdpr#article2-2</seealso>
    let ``GDPRtEXT/gdpr#article2_2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article2-2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation in which one process occurs prior to another process."</para>
    /// labels<para>"precedes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/sulo/precedes">https://w3id.org/sulo/precedes</seealso>
    let ``sulo/precedes`` = Prefixed_Name(w3id, "sulo/precedes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article2-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article2-3">https://w3id.org/GDPRtEXT/gdpr#article2-3</seealso>
    let ``GDPRtEXT/gdpr#article2_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article2-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"refers to is a binary relation between an information object and any other object that it mentions, describes, represents, encodes, or otherwise provides information about."</para>
    /// labels<para>"refers to"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/refersTo">https://w3id.org/sulo/refersTo</seealso>
    let ``sulo/refersTo`` = Prefixed_Name(w3id, "sulo/refersTo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/sulo-0.2.0.ttl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/sulo/sulo-0.2.0.ttl">https://w3id.org/sulo/sulo-0.2.0.ttl</seealso>
    let ``sulo/sulo_0.2.0.ttl`` =
        Prefixed_Name(w3id, "sulo/sulo-0.2.0.ttl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article20</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article20">https://w3id.org/GDPRtEXT/gdpr#article20</seealso>
    let ``GDPRtEXT/gdpr#article20`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article20") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article21</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article21">https://w3id.org/GDPRtEXT/gdpr#article21</seealso>
    let ``GDPRtEXT/gdpr#article21`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article21") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sulo/sulo.ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The Simplified Upper Level Ontology (SULO) is ontology with a minimal set of classes and relations to guide the development of a personal health knowledge graph."</para>
    /// labels<para>"Simplified Upper Level Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/sulo/sulo.ttl">https://w3id.org/sulo/sulo.ttl</seealso>
    let ``sulo/sulo.ttl`` = Prefixed_Name(w3id, "sulo/sulo.ttl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article21-2-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article21-2-3">https://w3id.org/GDPRtEXT/gdpr#article21-2-3</seealso>
    let ``GDPRtEXT/gdpr#article21_2_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article21-2-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/survey-ontology">https://w3id.org/survey-ontology</seealso>
    let survey_ontology = Prefixed_Name(w3id, "survey-ontology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article21-6</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article21-6">https://w3id.org/GDPRtEXT/gdpr#article21-6</seealso>
    let ``GDPRtEXT/gdpr#article21_6`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article21-6") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article22</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article22">https://w3id.org/GDPRtEXT/gdpr#article22</seealso>
    let ``GDPRtEXT/gdpr#article22`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article22") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article24</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article24">https://w3id.org/GDPRtEXT/gdpr#article24</seealso>
    let ``GDPRtEXT/gdpr#article24`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article24") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article24-1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article24-1">https://w3id.org/GDPRtEXT/gdpr#article24-1</seealso>
    let ``GDPRtEXT/gdpr#article24_1`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article24-1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article25</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article25">https://w3id.org/GDPRtEXT/gdpr#article25</seealso>
    let ``GDPRtEXT/gdpr#article25`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article25") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article25-1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article25-1">https://w3id.org/GDPRtEXT/gdpr#article25-1</seealso>
    let ``GDPRtEXT/gdpr#article25_1`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article25-1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article25-2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article25-2">https://w3id.org/GDPRtEXT/gdpr#article25-2</seealso>
    let ``GDPRtEXT/gdpr#article25_2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article25-2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article26</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article26">https://w3id.org/GDPRtEXT/gdpr#article26</seealso>
    let ``GDPRtEXT/gdpr#article26`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article26") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article26-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article26-3">https://w3id.org/GDPRtEXT/gdpr#article26-3</seealso>
    let ``GDPRtEXT/gdpr#article26_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article26-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article27</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article27">https://w3id.org/GDPRtEXT/gdpr#article27</seealso>
    let ``GDPRtEXT/gdpr#article27`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article27") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article28</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article28">https://w3id.org/GDPRtEXT/gdpr#article28</seealso>
    let ``GDPRtEXT/gdpr#article28`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article28") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article28-1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article28-1">https://w3id.org/GDPRtEXT/gdpr#article28-1</seealso>
    let ``GDPRtEXT/gdpr#article28_1`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article28-1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article28-10</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article28-10">https://w3id.org/GDPRtEXT/gdpr#article28-10</seealso>
    let ``GDPRtEXT/gdpr#article28_10`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article28-10") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article28-2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article28-2">https://w3id.org/GDPRtEXT/gdpr#article28-2</seealso>
    let ``GDPRtEXT/gdpr#article28_2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article28-2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article28-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article28-3">https://w3id.org/GDPRtEXT/gdpr#article28-3</seealso>
    let ``GDPRtEXT/gdpr#article28_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article28-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article28-3-4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article28-3-4">https://w3id.org/GDPRtEXT/gdpr#article28-3-4</seealso>
    let ``GDPRtEXT/gdpr#article28_3_4`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article28-3-4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article28-3-b</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article28-3-b">https://w3id.org/GDPRtEXT/gdpr#article28-3-b</seealso>
    let ``GDPRtEXT/gdpr#article28_3_b`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article28-3-b") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article28-3-e</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article28-3-e">https://w3id.org/GDPRtEXT/gdpr#article28-3-e</seealso>
    let ``GDPRtEXT/gdpr#article28_3_e`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article28-3-e") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article28-4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article28-4">https://w3id.org/GDPRtEXT/gdpr#article28-4</seealso>
    let ``GDPRtEXT/gdpr#article28_4`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article28-4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article29">https://w3id.org/GDPRtEXT/gdpr#article29</seealso>
    let ``GDPRtEXT/gdpr#article29`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article29") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article30</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article30">https://w3id.org/GDPRtEXT/gdpr#article30</seealso>
    let ``GDPRtEXT/gdpr#article30`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article30") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article30-2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article30-2">https://w3id.org/GDPRtEXT/gdpr#article30-2</seealso>
    let ``GDPRtEXT/gdpr#article30_2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article30-2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article31</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article31">https://w3id.org/GDPRtEXT/gdpr#article31</seealso>
    let ``GDPRtEXT/gdpr#article31`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article31") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article32</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article32">https://w3id.org/GDPRtEXT/gdpr#article32</seealso>
    let ``GDPRtEXT/gdpr#article32`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article32") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article33</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article33">https://w3id.org/GDPRtEXT/gdpr#article33</seealso>
    let ``GDPRtEXT/gdpr#article33`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article33") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article33-2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article33-2">https://w3id.org/GDPRtEXT/gdpr#article33-2</seealso>
    let ``GDPRtEXT/gdpr#article33_2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article33-2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article34</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article34">https://w3id.org/GDPRtEXT/gdpr#article34</seealso>
    let ``GDPRtEXT/gdpr#article34`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article34") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article35</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article35">https://w3id.org/GDPRtEXT/gdpr#article35</seealso>
    let ``GDPRtEXT/gdpr#article35`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article35") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article38-6</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article38-6">https://w3id.org/GDPRtEXT/gdpr#article38-6</seealso>
    let ``GDPRtEXT/gdpr#article38_6`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article38-6") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article39</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article39">https://w3id.org/GDPRtEXT/gdpr#article39</seealso>
    let ``GDPRtEXT/gdpr#article39`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article39") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article4-1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article4-1">https://w3id.org/GDPRtEXT/gdpr#article4-1</seealso>
    let ``GDPRtEXT/gdpr#article4_1`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article4-1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article4-11</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article4-11">https://w3id.org/GDPRtEXT/gdpr#article4-11</seealso>
    let ``GDPRtEXT/gdpr#article4_11`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article4-11") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article4-12</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article4-12">https://w3id.org/GDPRtEXT/gdpr#article4-12</seealso>
    let ``GDPRtEXT/gdpr#article4_12`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article4-12") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article4-15</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article4-15">https://w3id.org/GDPRtEXT/gdpr#article4-15</seealso>
    let ``GDPRtEXT/gdpr#article4_15`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article4-15") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article4-17</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article4-17">https://w3id.org/GDPRtEXT/gdpr#article4-17</seealso>
    let ``GDPRtEXT/gdpr#article4_17`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article4-17") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article4-2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article4-2">https://w3id.org/GDPRtEXT/gdpr#article4-2</seealso>
    let ``GDPRtEXT/gdpr#article4_2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article4-2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article4-5</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article4-5">https://w3id.org/GDPRtEXT/gdpr#article4-5</seealso>
    let ``GDPRtEXT/gdpr#article4_5`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article4-5") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article4-7</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article4-7">https://w3id.org/GDPRtEXT/gdpr#article4-7</seealso>
    let ``GDPRtEXT/gdpr#article4_7`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article4-7") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article4-8</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article4-8">https://w3id.org/GDPRtEXT/gdpr#article4-8</seealso>
    let ``GDPRtEXT/gdpr#article4_8`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article4-8") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article40-2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article40-2">https://w3id.org/GDPRtEXT/gdpr#article40-2</seealso>
    let ``GDPRtEXT/gdpr#article40_2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article40-2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article40-2-d</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article40-2-d">https://w3id.org/GDPRtEXT/gdpr#article40-2-d</seealso>
    let ``GDPRtEXT/gdpr#article40_2_d`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article40-2-d") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article42</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article42">https://w3id.org/GDPRtEXT/gdpr#article42</seealso>
    let ``GDPRtEXT/gdpr#article42`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article42") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article42-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article42-3">https://w3id.org/GDPRtEXT/gdpr#article42-3</seealso>
    let ``GDPRtEXT/gdpr#article42_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article42-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article42-4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article42-4">https://w3id.org/GDPRtEXT/gdpr#article42-4</seealso>
    let ``GDPRtEXT/gdpr#article42_4`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article42-4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article42-6</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article42-6">https://w3id.org/GDPRtEXT/gdpr#article42-6</seealso>
    let ``GDPRtEXT/gdpr#article42_6`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article42-6") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article42-7</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article42-7">https://w3id.org/GDPRtEXT/gdpr#article42-7</seealso>
    let ``GDPRtEXT/gdpr#article42_7`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article42-7") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article43</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article43">https://w3id.org/GDPRtEXT/gdpr#article43</seealso>
    let ``GDPRtEXT/gdpr#article43`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article43") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article44</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article44">https://w3id.org/GDPRtEXT/gdpr#article44</seealso>
    let ``GDPRtEXT/gdpr#article44`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article44") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tido</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/tido">https://w3id.org/tido</seealso>
    let tido = Prefixed_Name(w3id, "tido") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article5-1-a</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article5-1-a">https://w3id.org/GDPRtEXT/gdpr#article5-1-a</seealso>
    let ``GDPRtEXT/gdpr#article5_1_a`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article5-1-a") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article5-1-b</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article5-1-b">https://w3id.org/GDPRtEXT/gdpr#article5-1-b</seealso>
    let ``GDPRtEXT/gdpr#article5_1_b`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article5-1-b") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article5-1-c</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article5-1-c">https://w3id.org/GDPRtEXT/gdpr#article5-1-c</seealso>
    let ``GDPRtEXT/gdpr#article5_1_c`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article5-1-c") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article5-1-d</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article5-1-d">https://w3id.org/GDPRtEXT/gdpr#article5-1-d</seealso>
    let ``GDPRtEXT/gdpr#article5_1_d`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article5-1-d") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article5-1-e</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article5-1-e">https://w3id.org/GDPRtEXT/gdpr#article5-1-e</seealso>
    let ``GDPRtEXT/gdpr#article5_1_e`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article5-1-e") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article5-1-f</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article5-1-f">https://w3id.org/GDPRtEXT/gdpr#article5-1-f</seealso>
    let ``GDPRtEXT/gdpr#article5_1_f`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article5-1-f") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article5-2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article5-2">https://w3id.org/GDPRtEXT/gdpr#article5-2</seealso>
    let ``GDPRtEXT/gdpr#article5_2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article5-2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-1">https://w3id.org/GDPRtEXT/gdpr#article6-1</seealso>
    let ``GDPRtEXT/gdpr#article6_1`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-1-a</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-1-a">https://w3id.org/GDPRtEXT/gdpr#article6-1-a</seealso>
    let ``GDPRtEXT/gdpr#article6_1_a`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-1-a") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-1-b</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-1-b">https://w3id.org/GDPRtEXT/gdpr#article6-1-b</seealso>
    let ``GDPRtEXT/gdpr#article6_1_b`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-1-b") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-1-c</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-1-c">https://w3id.org/GDPRtEXT/gdpr#article6-1-c</seealso>
    let ``GDPRtEXT/gdpr#article6_1_c`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-1-c") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-1-d</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-1-d">https://w3id.org/GDPRtEXT/gdpr#article6-1-d</seealso>
    let ``GDPRtEXT/gdpr#article6_1_d`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-1-d") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-1-e</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-1-e">https://w3id.org/GDPRtEXT/gdpr#article6-1-e</seealso>
    let ``GDPRtEXT/gdpr#article6_1_e`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-1-e") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-1-f</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-1-f">https://w3id.org/GDPRtEXT/gdpr#article6-1-f</seealso>
    let ``GDPRtEXT/gdpr#article6_1_f`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-1-f") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-3">https://w3id.org/GDPRtEXT/gdpr#article6-3</seealso>
    let ``GDPRtEXT/gdpr#article6_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-4">https://w3id.org/GDPRtEXT/gdpr#article6-4</seealso>
    let ``GDPRtEXT/gdpr#article6_4`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-4-e</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-4-e">https://w3id.org/GDPRtEXT/gdpr#article6-4-e</seealso>
    let ``GDPRtEXT/gdpr#article6_4_e`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-4-e") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article6-5</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article6-5">https://w3id.org/GDPRtEXT/gdpr#article6-5</seealso>
    let ``GDPRtEXT/gdpr#article6_5`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article6-5") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article7</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article7">https://w3id.org/GDPRtEXT/gdpr#article7</seealso>
    let ``GDPRtEXT/gdpr#article7`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article7") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article7-1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article7-1">https://w3id.org/GDPRtEXT/gdpr#article7-1</seealso>
    let ``GDPRtEXT/gdpr#article7_1`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article7-1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article7-2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article7-2">https://w3id.org/GDPRtEXT/gdpr#article7-2</seealso>
    let ``GDPRtEXT/gdpr#article7_2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article7-2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article7-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article7-3">https://w3id.org/GDPRtEXT/gdpr#article7-3</seealso>
    let ``GDPRtEXT/gdpr#article7_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article7-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article7-4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article7-4">https://w3id.org/GDPRtEXT/gdpr#article7-4</seealso>
    let ``GDPRtEXT/gdpr#article7_4`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article7-4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article82-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article82-3">https://w3id.org/GDPRtEXT/gdpr#article82-3</seealso>
    let ``GDPRtEXT/gdpr#article82_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article82-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article82-5</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article82-5">https://w3id.org/GDPRtEXT/gdpr#article82-5</seealso>
    let ``GDPRtEXT/gdpr#article82_5`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article82-5") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tido/1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/tido/1.0.0">https://w3id.org/tido/1.0.0</seealso>
    let ``tido/1.0.0`` = Prefixed_Name(w3id, "tido/1.0.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article83-1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article83-1">https://w3id.org/GDPRtEXT/gdpr#article83-1</seealso>
    let ``GDPRtEXT/gdpr#article83_1`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article83-1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"An ontology to describe poeple and requests for timebanks. This includes the poeple's skills, limitations, and environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/timebank">https://w3id.org/timebank</seealso>
    let timebank = Prefixed_Name(w3id, "timebank") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article89-1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article89-1">https://w3id.org/GDPRtEXT/gdpr#article89-1</seealso>
    let ``GDPRtEXT/gdpr#article89_1`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article89-1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-1">https://w3id.org/GDPRtEXT/gdpr#article9-1</seealso>
    let ``GDPRtEXT/gdpr#article9_1`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-2-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-2-3">https://w3id.org/GDPRtEXT/gdpr#article9-2-3</seealso>
    let ``GDPRtEXT/gdpr#article9_2_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-2-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-2-a</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-2-a">https://w3id.org/GDPRtEXT/gdpr#article9-2-a</seealso>
    let ``GDPRtEXT/gdpr#article9_2_a`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-2-a") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-2-b</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-2-b">https://w3id.org/GDPRtEXT/gdpr#article9-2-b</seealso>
    let ``GDPRtEXT/gdpr#article9_2_b`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-2-b") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-2-c</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-2-c">https://w3id.org/GDPRtEXT/gdpr#article9-2-c</seealso>
    let ``GDPRtEXT/gdpr#article9_2_c`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-2-c") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-2-d</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-2-d">https://w3id.org/GDPRtEXT/gdpr#article9-2-d</seealso>
    let ``GDPRtEXT/gdpr#article9_2_d`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-2-d") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-2-e</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-2-e">https://w3id.org/GDPRtEXT/gdpr#article9-2-e</seealso>
    let ``GDPRtEXT/gdpr#article9_2_e`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-2-e") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-2-f</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-2-f">https://w3id.org/GDPRtEXT/gdpr#article9-2-f</seealso>
    let ``GDPRtEXT/gdpr#article9_2_f`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-2-f") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-2-g</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-2-g">https://w3id.org/GDPRtEXT/gdpr#article9-2-g</seealso>
    let ``GDPRtEXT/gdpr#article9_2_g`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-2-g") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-2-i</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-2-i">https://w3id.org/GDPRtEXT/gdpr#article9-2-i</seealso>
    let ``GDPRtEXT/gdpr#article9_2_i`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-2-i") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-2-j</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-2-j">https://w3id.org/GDPRtEXT/gdpr#article9-2-j</seealso>
    let ``GDPRtEXT/gdpr#article9_2_j`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-2-j") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-3">https://w3id.org/GDPRtEXT/gdpr#article9-3</seealso>
    let ``GDPRtEXT/gdpr#article9_3`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-3") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#article9-4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#article9-4">https://w3id.org/GDPRtEXT/gdpr#article9-4</seealso>
    let ``GDPRtEXT/gdpr#article9_4`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#article9-4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#chapter2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#chapter2">https://w3id.org/GDPRtEXT/gdpr#chapter2</seealso>
    let ``GDPRtEXT/gdpr#chapter2`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#chapter2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital10</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital10">https://w3id.org/GDPRtEXT/gdpr#recital10</seealso>
    let ``GDPRtEXT/gdpr#recital10`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital10") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital146</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital146">https://w3id.org/GDPRtEXT/gdpr#recital146</seealso>
    let ``GDPRtEXT/gdpr#recital146`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital146") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital156</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital156">https://w3id.org/GDPRtEXT/gdpr#recital156</seealso>
    let ``GDPRtEXT/gdpr#recital156`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital156") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital16</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital16">https://w3id.org/GDPRtEXT/gdpr#recital16</seealso>
    let ``GDPRtEXT/gdpr#recital16`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital16") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital17</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital17">https://w3id.org/GDPRtEXT/gdpr#recital17</seealso>
    let ``GDPRtEXT/gdpr#recital17`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital17") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital18</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital18">https://w3id.org/GDPRtEXT/gdpr#recital18</seealso>
    let ``GDPRtEXT/gdpr#recital18`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital18") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital19</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital19">https://w3id.org/GDPRtEXT/gdpr#recital19</seealso>
    let ``GDPRtEXT/gdpr#recital19`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital19") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital26</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital26">https://w3id.org/GDPRtEXT/gdpr#recital26</seealso>
    let ``GDPRtEXT/gdpr#recital26`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital26") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital28</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital28">https://w3id.org/GDPRtEXT/gdpr#recital28</seealso>
    let ``GDPRtEXT/gdpr#recital28`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital28") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital29">https://w3id.org/GDPRtEXT/gdpr#recital29</seealso>
    let ``GDPRtEXT/gdpr#recital29`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital29") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital32</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital32">https://w3id.org/GDPRtEXT/gdpr#recital32</seealso>
    let ``GDPRtEXT/gdpr#recital32`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital32") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital32-1-a</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital32-1-a">https://w3id.org/GDPRtEXT/gdpr#recital32-1-a</seealso>
    let ``GDPRtEXT/gdpr#recital32_1_a`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital32-1-a") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital34</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital34">https://w3id.org/GDPRtEXT/gdpr#recital34</seealso>
    let ``GDPRtEXT/gdpr#recital34`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital34") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital35</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital35">https://w3id.org/GDPRtEXT/gdpr#recital35</seealso>
    let ``GDPRtEXT/gdpr#recital35`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital35") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital39</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital39">https://w3id.org/GDPRtEXT/gdpr#recital39</seealso>
    let ``GDPRtEXT/gdpr#recital39`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital39") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital40</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital40">https://w3id.org/GDPRtEXT/gdpr#recital40</seealso>
    let ``GDPRtEXT/gdpr#recital40`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital40") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital41</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital41">https://w3id.org/GDPRtEXT/gdpr#recital41</seealso>
    let ``GDPRtEXT/gdpr#recital41`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital41") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital42</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital42">https://w3id.org/GDPRtEXT/gdpr#recital42</seealso>
    let ``GDPRtEXT/gdpr#recital42`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital42") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital43</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital43">https://w3id.org/GDPRtEXT/gdpr#recital43</seealso>
    let ``GDPRtEXT/gdpr#recital43`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital43") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital44</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital44">https://w3id.org/GDPRtEXT/gdpr#recital44</seealso>
    let ``GDPRtEXT/gdpr#recital44`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital44") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital45</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital45">https://w3id.org/GDPRtEXT/gdpr#recital45</seealso>
    let ``GDPRtEXT/gdpr#recital45`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital45") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital46</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital46">https://w3id.org/GDPRtEXT/gdpr#recital46</seealso>
    let ``GDPRtEXT/gdpr#recital46`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital46") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital47</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital47">https://w3id.org/GDPRtEXT/gdpr#recital47</seealso>
    let ``GDPRtEXT/gdpr#recital47`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital47") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital48</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital48">https://w3id.org/GDPRtEXT/gdpr#recital48</seealso>
    let ``GDPRtEXT/gdpr#recital48`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital48") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital50</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital50">https://w3id.org/GDPRtEXT/gdpr#recital50</seealso>
    let ``GDPRtEXT/gdpr#recital50`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital50") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital51</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital51">https://w3id.org/GDPRtEXT/gdpr#recital51</seealso>
    let ``GDPRtEXT/gdpr#recital51`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital51") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital53</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital53">https://w3id.org/GDPRtEXT/gdpr#recital53</seealso>
    let ``GDPRtEXT/gdpr#recital53`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital53") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital54</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital54">https://w3id.org/GDPRtEXT/gdpr#recital54</seealso>
    let ``GDPRtEXT/gdpr#recital54`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital54") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital58</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital58">https://w3id.org/GDPRtEXT/gdpr#recital58</seealso>
    let ``GDPRtEXT/gdpr#recital58`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital58") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital59</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital59">https://w3id.org/GDPRtEXT/gdpr#recital59</seealso>
    let ``GDPRtEXT/gdpr#recital59`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital59") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital60</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital60">https://w3id.org/GDPRtEXT/gdpr#recital60</seealso>
    let ``GDPRtEXT/gdpr#recital60`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital60") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital63</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital63">https://w3id.org/GDPRtEXT/gdpr#recital63</seealso>
    let ``GDPRtEXT/gdpr#recital63`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital63") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital65</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital65">https://w3id.org/GDPRtEXT/gdpr#recital65</seealso>
    let ``GDPRtEXT/gdpr#recital65`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital65") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital66</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital66">https://w3id.org/GDPRtEXT/gdpr#recital66</seealso>
    let ``GDPRtEXT/gdpr#recital66`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital66") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital67</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital67">https://w3id.org/GDPRtEXT/gdpr#recital67</seealso>
    let ``GDPRtEXT/gdpr#recital67`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital67") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital68</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital68">https://w3id.org/GDPRtEXT/gdpr#recital68</seealso>
    let ``GDPRtEXT/gdpr#recital68`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital68") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital69</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital69">https://w3id.org/GDPRtEXT/gdpr#recital69</seealso>
    let ``GDPRtEXT/gdpr#recital69`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital69") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital70</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital70">https://w3id.org/GDPRtEXT/gdpr#recital70</seealso>
    let ``GDPRtEXT/gdpr#recital70`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital70") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital71</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital71">https://w3id.org/GDPRtEXT/gdpr#recital71</seealso>
    let ``GDPRtEXT/gdpr#recital71`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital71") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital73</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital73">https://w3id.org/GDPRtEXT/gdpr#recital73</seealso>
    let ``GDPRtEXT/gdpr#recital73`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital73") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital74</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital74">https://w3id.org/GDPRtEXT/gdpr#recital74</seealso>
    let ``GDPRtEXT/gdpr#recital74`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital74") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital75</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital75">https://w3id.org/GDPRtEXT/gdpr#recital75</seealso>
    let ``GDPRtEXT/gdpr#recital75`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital75") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital77</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital77">https://w3id.org/GDPRtEXT/gdpr#recital77</seealso>
    let ``GDPRtEXT/gdpr#recital77`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital77") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital78</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital78">https://w3id.org/GDPRtEXT/gdpr#recital78</seealso>
    let ``GDPRtEXT/gdpr#recital78`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital78") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital79</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital79">https://w3id.org/GDPRtEXT/gdpr#recital79</seealso>
    let ``GDPRtEXT/gdpr#recital79`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital79") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital80</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital80">https://w3id.org/GDPRtEXT/gdpr#recital80</seealso>
    let ``GDPRtEXT/gdpr#recital80`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital80") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital81</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital81">https://w3id.org/GDPRtEXT/gdpr#recital81</seealso>
    let ``GDPRtEXT/gdpr#recital81`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital81") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital82</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital82">https://w3id.org/GDPRtEXT/gdpr#recital82</seealso>
    let ``GDPRtEXT/gdpr#recital82`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital82") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital83</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital83">https://w3id.org/GDPRtEXT/gdpr#recital83</seealso>
    let ``GDPRtEXT/gdpr#recital83`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital83") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital84</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital84">https://w3id.org/GDPRtEXT/gdpr#recital84</seealso>
    let ``GDPRtEXT/gdpr#recital84`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital84") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital85</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital85">https://w3id.org/GDPRtEXT/gdpr#recital85</seealso>
    let ``GDPRtEXT/gdpr#recital85`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital85") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital86</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital86">https://w3id.org/GDPRtEXT/gdpr#recital86</seealso>
    let ``GDPRtEXT/gdpr#recital86`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital86") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital87</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital87">https://w3id.org/GDPRtEXT/gdpr#recital87</seealso>
    let ``GDPRtEXT/gdpr#recital87`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital87") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital88</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital88">https://w3id.org/GDPRtEXT/gdpr#recital88</seealso>
    let ``GDPRtEXT/gdpr#recital88`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital88") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital89</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital89">https://w3id.org/GDPRtEXT/gdpr#recital89</seealso>
    let ``GDPRtEXT/gdpr#recital89`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital89") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital90</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital90">https://w3id.org/GDPRtEXT/gdpr#recital90</seealso>
    let ``GDPRtEXT/gdpr#recital90`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital90") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital91</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital91">https://w3id.org/GDPRtEXT/gdpr#recital91</seealso>
    let ``GDPRtEXT/gdpr#recital91`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital91") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital92</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital92">https://w3id.org/GDPRtEXT/gdpr#recital92</seealso>
    let ``GDPRtEXT/gdpr#recital92`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital92") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital93</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital93">https://w3id.org/GDPRtEXT/gdpr#recital93</seealso>
    let ``GDPRtEXT/gdpr#recital93`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital93") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital94</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital94">https://w3id.org/GDPRtEXT/gdpr#recital94</seealso>
    let ``GDPRtEXT/gdpr#recital94`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital94") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital97</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital97">https://w3id.org/GDPRtEXT/gdpr#recital97</seealso>
    let ``GDPRtEXT/gdpr#recital97`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital97") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital98</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital98">https://w3id.org/GDPRtEXT/gdpr#recital98</seealso>
    let ``GDPRtEXT/gdpr#recital98`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital98") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRtEXT/gdpr#recital99</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/GDPRtEXT/gdpr#recital99">https://w3id.org/GDPRtEXT/gdpr#recital99</seealso>
    let ``GDPRtEXT/gdpr#recital99`` =
        Prefixed_Name(w3id, "GDPRtEXT/gdpr#recital99") |> PrefixedName

    /// <summary>
    ///   <para>w3id:HHT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The notion of territory plays a major role in human and social sciences. In an historical context, most approaches are irrelevant as they rely on geometric data, which is not available. In order to represent historical territories,we conceived the HHT ontology (Hierarchical Historical Territory) to represent hierarchical historical territorial divisions, without having to know their geometry. This approach relies on a notion of building blocks to replace polygonal geometry."</para>
    /// labels<para>"Historical Hierarchical Territories"</para></remarks>
    /// <seealso href="https://w3id.org/HHT">https://w3id.org/HHT</seealso>
    let HHT = Prefixed_Name(w3id, "HHT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT/1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/HHT/1.0">https://w3id.org/HHT/1.0</seealso>
    let ``HHT/1.0`` = Prefixed_Name(w3id, "HHT/1.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT/1.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/HHT/1.1">https://w3id.org/HHT/1.1</seealso>
    let ``HHT/1.1`` = Prefixed_Name(w3id, "HHT/1.1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:Lift</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/Lift">https://w3id.org/Lift</seealso>
    let Lift = Prefixed_Name(w3id, "Lift") |> PrefixedName
    /// <summary>
    ///   <para>w3id:OntoGSN/ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology">https://w3id.org/OntoGSN/ontology</seealso>
    let ``OntoGSN/ontology`` = Prefixed_Name(w3id, "OntoGSN/ontology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank/0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/timebank/0.2">https://w3id.org/timebank/0.2</seealso>
    let ``timebank/0.2`` = Prefixed_Name(w3id, "timebank/0.2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/todo">https://w3id.org/todo</seealso>
    let todo = Prefixed_Name(w3id, "todo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/todo/tododfa">https://w3id.org/todo/tododfa</seealso>
    let ``todo/tododfa`` = Prefixed_Name(w3id, "todo/tododfa") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/todo/tododial">https://w3id.org/todo/tododial</seealso>
    let ``todo/tododial`` = Prefixed_Name(w3id, "todo/tododial") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/todo/tododm">https://w3id.org/todo/tododm</seealso>
    let ``todo/tododm`` = Prefixed_Name(w3id, "todo/tododm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/TRO">https://w3id.org/TRO</seealso>
    let TRO = Prefixed_Name(w3id, "TRO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/todo/tododom">https://w3id.org/todo/tododom</seealso>
    let ``todo/tododom`` = Prefixed_Name(w3id, "todo/tododom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/building">https://w3id.org/aerOS/building</seealso>
    let ``aerOS/building`` = Prefixed_Name(w3id, "aerOS/building") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/todo/tododt">https://w3id.org/todo/tododt</seealso>
    let ``todo/tododt`` = Prefixed_Name(w3id, "todo/tododt") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/todo/tododw">https://w3id.org/todo/tododw</seealso>
    let ``todo/tododw`` = Prefixed_Name(w3id, "todo/tododw") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum">https://w3id.org/aerOS/continuum</seealso>
    let ``aerOS/continuum`` = Prefixed_Name(w3id, "aerOS/continuum") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/tribont">https://w3id.org/tribont</seealso>
    let tribont = Prefixed_Name(w3id, "tribont") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/tribont/core">https://w3id.org/tribont/core</seealso>
    let ``tribont/core`` = Prefixed_Name(w3id, "tribont/core") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/data-catalog</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/aerOS/data-catalog">https://w3id.org/aerOS/data-catalog</seealso>
    let ``aerOS/data_catalog`` =
        Prefixed_Name(w3id, "aerOS/data-catalog") |> PrefixedName

    /// <summary>
    ///   <para>w3id:affectedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/affectedBy">https://w3id.org/affectedBy</seealso>
    let affectedBy = Prefixed_Name(w3id, "affectedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv">https://w3id.org/amv</seealso>
    let amv = Prefixed_Name(w3id, "amv") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/arco/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/arco/arco/">https://w3id.org/arco/arco/</seealso>
    let ``arco/arco/`` = Prefixed_Name(w3id, "arco/arco/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/contex-description/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/arco/contex-description/">https://w3id.org/arco/contex-description/</seealso>
    let ``arco/contex_description/`` =
        Prefixed_Name(w3id, "arco/contex-description/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/denotative-description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/arco/denotative-description">https://w3id.org/arco/denotative-description</seealso>
    let ``arco/denotative_description`` =
        Prefixed_Name(w3id, "arco/denotative-description") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/arco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Questo è il modulo centrale della rete di ontologie di ArCo - Architettura della Conoscenza. Qui si modellano informazioni, relative al dominio dei beni culturali, considerate top-level. Vengono importati tutti gli altri moduli della rete.
    /// In questo modulo sono riusati come template i seguenti Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/classification.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/collectionentity.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/componency.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/partof.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/situation.owl"</para>
    ///   <para>"The ArCo module is the root of the network ArCo - Architecture of Knowledge. It imports all the other modules and models top-level distinctions from the cultural heritage domain.
    /// In this module are used as template the following Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/classification.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/collectionentity.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/componency.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/partof.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/situation.owl"</para>
    /// labels<para>"Ontologia ArCo (ArCo network)"</para><para>"ArCo Ontology (ArCo network)"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco">https://w3id.org/arco/ontology/arco</seealso>
    let ``arco/ontology/arco`` =
        Prefixed_Name(w3id, "arco/ontology/arco") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/tribont/equipment">https://w3id.org/tribont/equipment</seealso>
    let ``tribont/equipment`` = Prefixed_Name(w3id, "tribont/equipment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/tribont/material">https://w3id.org/tribont/material</seealso>
    let ``tribont/material`` = Prefixed_Name(w3id, "tribont/material") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/catalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The Catalogue module allows the description of concepts related to the Italian General Catalogue of Cultural Heritage (ICCD-MiBAC), and in particular catalogue records, that is XML files recording all data gathered by a cataloguer on a particular cultural property.
    /// In this module are used as template the following Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/classification.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/sequence.owl"</para>
    ///   <para>"Questo modulo modella le informazioni relative al Catalogo Generale dei Beni Culturali (ICCD-MiBAC) e alle schede di catalogo che descrivono un bene culturale.
    /// In questo modulo sono riusati come template i seguenti Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/classification.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/sequence.owl"</para>
    /// labels<para>"Ontologia del Catalogo (ArCo network)"</para><para>"Catalogue Ontology (ArCo network)"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/catalogue">https://w3id.org/arco/ontology/catalogue</seealso>
    let ``arco/ontology/catalogue`` =
        Prefixed_Name(w3id, "arco/ontology/catalogue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/tribont/sample">https://w3id.org/tribont/sample</seealso>
    let ``tribont/sample`` = Prefixed_Name(w3id, "tribont/sample") |> PrefixedName
    /// <summary>
    ///   <para>w3id:usability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability">https://w3id.org/usability</seealso>
    let usability = Prefixed_Name(w3id, "usability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The Context Description module includes models for the context of a cultural property, in a broad sense: agents (e.g.: author, collector, copyright holder), objects (e.g.: inventories, bibliography, protective measures, other cultural properties, collections etc.), activities (e.g.: surveys, conservation interventions), situations (e.g.: commission, coin issuance, estimate, legal situation) related, involved or involving the cultural property. Thus it represents attributes that do not result from a measurement of features in a cultural property, but are associated with it.
    /// In this module are used as template the following Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/collectionentity.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/countingas.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/agentrole.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/classification.owl
    /// - http://mklab.iti.gr/pericles/BornDigitalArchives_ODP.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/place.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/situation.owl"</para>
    ///   <para>"Questo modulo, detto della descrizione di contesto, include le informazioni che riguardano il contesto (inteso in senso ampio) in cui il bene culturale viene a trovarsi nel corso della sua storia. Fanno per esempio parte delle informazioni di contesto: autore, committente, collezione, ambito culturale, eventi coinvolti, contenitore giuridico, utente, circostanza, modalità di fruizione, bibliografia, documentazione collegata, collocazione in un determinato inventario, etc. Dunque, rappresenta attributi che non sono il risultato di una misurazione condotta sul bene culturale, ma che sono associati al bene culturale.
    /// In questo modulo sono riusati come template i seguenti Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/collectionentity.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/countingas.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/agentrole.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/classification.owl
    /// - http://mklab.iti.gr/pericles/BornDigitalArchives_ODP.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/place.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/situation.owl"</para>
    /// labels<para>"Context Description Ontology (ArCo network)"</para><para>"Ontologia della Descrizione di Contesto (ArCo network)"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description">https://w3id.org/arco/ontology/context-description</seealso>
    let ``arco/ontology/context_description`` =
        Prefixed_Name(w3id, "arco/ontology/context-description") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Vocabulary of AI Risks"</para></remarks>
    /// <seealso href="https://w3id.org/vair">https://w3id.org/vair</seealso>
    let vair = Prefixed_Name(w3id, "vair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vair/1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vair/1.0">https://w3id.org/vair/1.0</seealso>
    let ``vair/1.0`` = Prefixed_Name(w3id, "vair/1.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/lingvoj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>"人や組織による言語の使用、ドキュメント内やイベント期間中におけるその使用に加え、その地理的範囲と状況を記述するための語彙"</para>
    ///   <para>"Un vocabulaire pour décrire l'utilisation des langues par les personnes et les organisations, leur répartition géographique et leur statut, ainsi que leur usage dans les documents ou lors des événements"</para>
    ///   <para>"Een vokabular voor de beschrijving en het gebruik van talen door personen en organisaties, de geografische extensie en status en het gebruik ervan in documenten en tijdens evenmenten"</para>
    ///   <para>"A vocabulary for describing the use of languages by people and organizations, their geographical scope and status as well as their usage in documents or during events"</para>
    ///   <para>"Un vocabulario para describir la utilización de lenguas por parte de personas y organizaciones, su ambito geográfico y su estatus, así como su utilización en documentos o durante eventos"</para>
    ///   <para>"Um vocabulário para descrever a utilização de idiomas por parte de pessoas ou organizações, o seu âmbito geográfico e seu estatuto, assim como a sua utilização em documentos ou durante eventos"</para>
    /// labels<para>"Ontologie des langues"</para><para>"言語オントロジー"</para><para>"Taal Ontologie"</para><para>"Ontología de lenguajes"</para><para>"Ontologia de idiomas"</para><para>"The Lingvoj Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj">https://w3id.org/vocab/lingvoj</seealso>
    let ``vocab/lingvoj`` = Prefixed_Name(w3id, "vocab/lingvoj") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Questo modulo rappresenta concetti trasversali a tutta la network, che sono quindi importati da tutti gli altri moduli ontologici (es.: relazione parte-tutto, classificazione)."</para>
    ///   <para>"The Core module represents general-purpose concepts orthogonal to the whole network, which are imported by all other ontology modules (e.g. part-whole relation, classification)."</para>
    /// labels<para>"Core Ontology (ArCo network)"</para><para>"Ontologia Core (ArCo network)"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core">https://w3id.org/arco/ontology/core</seealso>
    let ``arco/ontology/core`` =
        Prefixed_Name(w3id, "arco/ontology/core") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vocab/lingvoj_v1.3.rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj_v1.3.rdf">https://w3id.org/vocab/lingvoj_v1.3.rdf</seealso>
    let ``vocab/lingvoj_v1.3.rdf`` =
        Prefixed_Name(w3id, "vocab/lingvoj_v1.3.rdf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vocab/lingvoj_v2.33.ttl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj_v2.33.ttl">https://w3id.org/vocab/lingvoj_v2.33.ttl</seealso>
    let ``vocab/lingvoj_v2.33.ttl`` =
        Prefixed_Name(w3id, "vocab/lingvoj_v2.33.ttl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vocab/lingvoj_v3.0.ttl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj_v3.0.ttl">https://w3id.org/vocab/lingvoj_v3.0.ttl</seealso>
    let ``vocab/lingvoj_v3.0.ttl`` =
        Prefixed_Name(w3id, "vocab/lingvoj_v3.0.ttl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vocab/olca</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"A vocabulary defining annotations enabling loose coupling between classes and properties in ontologies. Those annotations define with some accuracy the expected use of properties, in particular across vocabularies, without the formal constraints entailed by the use of OWL or RDFS constructions"</para>
    /// labels<para>"Ontology Loose Coupling Annotation"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/olca">https://w3id.org/vocab/olca</seealso>
    let ``vocab/olca`` = Prefixed_Name(w3id, "vocab/olca") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vocab/olca_v2.0.ttl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/olca_v2.0.ttl">https://w3id.org/vocab/olca_v2.0.ttl</seealso>
    let ``vocab/olca_v2.0.ttl`` =
        Prefixed_Name(w3id, "vocab/olca_v2.0.ttl") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vocab/sdm</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"A vocabulary to represent SPARQL endpoint metadata."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vocab/sdm">https://w3id.org/vocab/sdm</seealso>
    let ``vocab/sdm`` = Prefixed_Name(w3id, "vocab/sdm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/xbrll</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///
    /// labels<para>"El vocabulario para informe financiero"</para><para>"A leightweight XBRL vocabulary"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/xbrll">https://w3id.org/vocab/xbrll</seealso>
    let ``vocab/xbrll`` = Prefixed_Name(w3id, "vocab/xbrll") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Agent</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Person</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"ERA ontology for verified permissions, as applied in vehicle(type) authorisations, registrations and approvals"</para>
    /// labels<para>"The Verified Permissions (VP) ontology"</para></remarks>
    /// <seealso href="https://w3id.org/vpa">https://w3id.org/vpa</seealso>
    let vpa = Prefixed_Name(w3id, "vpa") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/cultural-event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The Cultural Event module models cultural events, i.e. events involving cultural properties.
    /// In this module are used as template the following Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/collectionentity.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/sequence.owl"</para>
    ///   <para>"Questo modulo modella gli eventi culturali, cioè eventi che coinvolgono un bene culturale.
    /// In questo modulo sono riusati come template i seguenti Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/collectionentity.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/sequence.owl"</para>
    /// labels<para>"Cultural Event Ontology (ArCo network)"</para><para>"Ontologia degli Eventi Culturali (ArCo network)"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event">https://w3id.org/arco/ontology/cultural-event</seealso>
    let ``arco/ontology/cultural_event`` =
        Prefixed_Name(w3id, "arco/ontology/cultural-event") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The Denotative Description module encodes the characteristics of a cultural property, as detectable and/or detected during the cataloguing process and measurable according to a reference system. Examples include measurements e.g. length, constituting materials e.g. clay, employed techniques e.g. melting, conservation status e.g. good, decent, bad.
    /// In this module are used as template the following Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/collectionentity.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/classification.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/descriptionandsituation.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/situation.owl"</para>
    ///   <para>"Questo modulo, detto della descrizione denotativa (denotazione è inteso come l'atto di indicare una cosa attraverso segni esteriori), modella le caratteristiche di un bene culturale, individuabili e/o individuate durante il processo di catalogazione e misurabili in accordo con un sistema di riferimento. Esempi includono misure es. lunghezza, materia es. argilla, tecniche es. fusione, stato di conservazione es. buono, discreto, cattivo.
    /// In questo modulo si riusano come template i seguenti Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/collectionentity.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/classification.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/descriptionandsituation.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/situation.owl"</para>
    /// labels<para>"Denotative Description Ontology (ArCo network)"</para><para>"Ontologia della Descrizione Denotativa (ArCo network)"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description">https://w3id.org/arco/ontology/denotative-description</seealso>
    let ``arco/ontology/denotative_description`` =
        Prefixed_Name(w3id, "arco/ontology/denotative-description") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/wfont">https://w3id.org/wfont</seealso>
    let wfont = Prefixed_Name(w3id, "wfont") |> PrefixedName

    /// <summary>
    ///   <para>w3id:widoco/vocab#introduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/widoco/vocab#introduction">https://w3id.org/widoco/vocab#introduction</seealso>
    let ``widoco/vocab#introduction`` =
        Prefixed_Name(w3id, "widoco/vocab#introduction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/yang/server">https://w3id.org/yang/server</seealso>
    let ``yang/server`` = Prefixed_Name(w3id, "yang/server") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/w3id.org/rml/io/spec</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/yang/w3id.org/rml/io/spec">https://w3id.org/yang/w3id.org/rml/io/spec</seealso>
    let ``yang/w3id.org/rml/io/spec`` =
        Prefixed_Name(w3id, "yang/w3id.org/rml/io/spec") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The module Location models information related to the localization and georeferencing of a cultural property.
    /// In this module the following Ontology Design Patterns have been used:
    /// - http://www.ontologydesignpatterns.org/cp/owl/collectionentity.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/classification.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/place.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/situation.owl"</para>
    ///   <para>"Questo modulo modella le informazioni relative alle localizzazioni e alla georeferenziazione di un bene culturale.
    /// In questo modulo si riusano come template i seguenti Ontology Design Patterns:
    /// - http://www.ontologydesignpatterns.org/cp/owl/collectionentity.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/classification.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/place.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl
    /// - http://www.ontologydesignpatterns.org/cp/owl/situation.owl"</para>
    /// labels<para>"Ontologia della Localizzazione (ArCo network)"</para><para>"Location Ontology (ArCo network)"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/location">https://w3id.org/arco/ontology/location</seealso>
    let ``arco/ontology/location`` =
        Prefixed_Name(w3id, "arco/ontology/location") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/pattern/catalogue-record-sequence/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/arco/pattern/catalogue-record-sequence/">https://w3id.org/arco/pattern/catalogue-record-sequence/</seealso>
    let ``arco/pattern/catalogue_record_sequence/`` =
        Prefixed_Name(w3id, "arco/pattern/catalogue-record-sequence/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/pattern/object-collection/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/arco/pattern/object-collection/">https://w3id.org/arco/pattern/object-collection/</seealso>
    let ``arco/pattern/object_collection/`` =
        Prefixed_Name(w3id, "arco/pattern/object-collection/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/pattern/technical-characteristic/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/arco/pattern/technical-characteristic/">https://w3id.org/arco/pattern/technical-characteristic/</seealso>
    let ``arco/pattern/technical_characteristic/`` =
        Prefixed_Name(w3id, "arco/pattern/technical-characteristic/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"-Version 0.3: with additional metadata -Version 0.2: added/changed relations between classes -Version 0.1: initial version of ontology"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/bcom">https://w3id.org/bcom</seealso>
    let bcom = Prefixed_Name(w3id, "bcom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bot-0.3.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/bot-0.3.1">https://w3id.org/bot-0.3.1</seealso>
    let ``bot_0.3.1`` = Prefixed_Name(w3id, "bot-0.3.1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bot-0.3.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/bot-0.3.2">https://w3id.org/bot-0.3.2</seealso>
    let ``bot_0.3.2`` = Prefixed_Name(w3id, "bot-0.3.2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cdc</para>
    /// </summary>
    /// <remarks>
    ///   <para>vcard2006:Organization</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>vcard2006:Individual</para>
    ///   <para>"- Version 0.0.1: initial version"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cdc">https://w3id.org/cdc</seealso>
    let cdc = Prefixed_Name(w3id, "cdc") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cerif/vocab/Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cerif/vocab/Organisation">https://w3id.org/cerif/vocab/Organisation</seealso>
    let ``cerif/vocab/Organisation`` =
        Prefixed_Name(w3id, "cerif/vocab/Organisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Cloud Computing Services Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0">https://w3id.org/cocoon/v1.0</seealso>
    let ``cocoon/v1.0`` = Prefixed_Name(w3id, "cocoon/v1.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:con-tax</para>
    /// </summary>
    /// <remarks>
    ///   <para>vcard2006:Organization</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>vcard2006:Individual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"- Version 0.0.1: initial version"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax">https://w3id.org/con-tax</seealso>
    let con_tax = Prefixed_Name(w3id, "con-tax") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/aat-materials</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/aat-materials">https://w3id.org/con-tax/aat-materials</seealso>
    let ``con_tax/aat_materials`` =
        Prefixed_Name(w3id, "con-tax/aat-materials") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/components/aat-arch</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/components/aat-arch">https://w3id.org/con-tax/components/aat-arch</seealso>
    let ``con_tax/components/aat_arch`` =
        Prefixed_Name(w3id, "con-tax/components/aat-arch") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/components/aat-furn</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/components/aat-furn">https://w3id.org/con-tax/components/aat-furn</seealso>
    let ``con_tax/components/aat_furn`` =
        Prefixed_Name(w3id, "con-tax/components/aat-furn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/components/aat-mep</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/components/aat-mep">https://w3id.org/con-tax/components/aat-mep</seealso>
    let ``con_tax/components/aat_mep`` =
        Prefixed_Name(w3id, "con-tax/components/aat-mep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/damages/mwv</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/damages/mwv">https://w3id.org/con-tax/damages/mwv</seealso>
    let ``con_tax/damages/mwv`` =
        Prefixed_Name(w3id, "con-tax/damages/mwv") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/properties/bhp</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/properties/bhp">https://w3id.org/con-tax/properties/bhp</seealso>
    let ``con_tax/properties/bhp`` =
        Prefixed_Name(w3id, "con-tax/properties/bhp") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/properties/cp</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/properties/cp">https://w3id.org/con-tax/properties/cp</seealso>
    let ``con_tax/properties/cp`` =
        Prefixed_Name(w3id, "con-tax/properties/cp") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/tasks/mwv</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/tasks/mwv">https://w3id.org/con-tax/tasks/mwv</seealso>
    let ``con_tax/tasks/mwv`` = Prefixed_Name(w3id, "con-tax/tasks/mwv") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/zones/aat-buildingSites</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/zones/aat-buildingSites">https://w3id.org/con-tax/zones/aat-buildingSites</seealso>
    let ``con_tax/zones/aat_buildingSites`` =
        Prefixed_Name(w3id, "con-tax/zones/aat-buildingSites") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/zones/aat-buildings</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/zones/aat-buildings">https://w3id.org/con-tax/zones/aat-buildings</seealso>
    let ``con_tax/zones/aat_buildings`` =
        Prefixed_Name(w3id, "con-tax/zones/aat-buildings") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/zones/aat-spaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/zones/aat-spaces">https://w3id.org/con-tax/zones/aat-spaces</seealso>
    let ``con_tax/zones/aat_spaces`` =
        Prefixed_Name(w3id, "con-tax/zones/aat-spaces") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/zones/aat-storeys</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/zones/aat-storeys">https://w3id.org/con-tax/zones/aat-storeys</seealso>
    let ``con_tax/zones/aat_storeys`` =
        Prefixed_Name(w3id, "con-tax/zones/aat-storeys") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax/zones/et-buildings</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/con-tax/zones/et-buildings">https://w3id.org/con-tax/zones/et-buildings</seealso>
    let ``con_tax/zones/et_buildings`` =
        Prefixed_Name(w3id, "con-tax/zones/et-buildings") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cto</para>
    /// </summary>
    /// <remarks>
    ///   <para>vcard2006:Organization</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>vcard2006:Individual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"- Version 0.0.1: initial version"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cto">https://w3id.org/cto</seealso>
    let cto = Prefixed_Name(w3id, "cto") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dco">https://w3id.org/dco</seealso>
    let dco = Prefixed_Name(w3id, "dco") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/InformaticsResearchArtifactsOntology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/def/InformaticsResearchArtifactsOntology">https://w3id.org/def/InformaticsResearchArtifactsOntology</seealso>
    let ``def/InformaticsResearchArtifactsOntology`` =
        Prefixed_Name(w3id, "def/InformaticsResearchArtifactsOntology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/NyOn#a</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/NyOn#a">https://w3id.org/def/NyOn#a</seealso>
    let ``def/NyOn#a`` = Prefixed_Name(w3id, "def/NyOn#a") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/NyOn#c</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/NyOn#c">https://w3id.org/def/NyOn#c</seealso>
    let ``def/NyOn#c`` = Prefixed_Name(w3id, "def/NyOn#c") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/NyOn#cj</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/NyOn#cj">https://w3id.org/def/NyOn#cj</seealso>
    let ``def/NyOn#cj`` = Prefixed_Name(w3id, "def/NyOn#cj") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/NyOn#d</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/NyOn#d">https://w3id.org/def/NyOn#d</seealso>
    let ``def/NyOn#d`` = Prefixed_Name(w3id, "def/NyOn#d") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/NyOn#j</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/NyOn#j">https://w3id.org/def/NyOn#j</seealso>
    let ``def/NyOn#j`` = Prefixed_Name(w3id, "def/NyOn#j") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/NyOn#m</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/NyOn#m">https://w3id.org/def/NyOn#m</seealso>
    let ``def/NyOn#m`` = Prefixed_Name(w3id, "def/NyOn#m") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/NyOn#p</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/NyOn#p">https://w3id.org/def/NyOn#p</seealso>
    let ``def/NyOn#p`` = Prefixed_Name(w3id, "def/NyOn#p") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/NyOn#r</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/NyOn#r">https://w3id.org/def/NyOn#r</seealso>
    let ``def/NyOn#r`` = Prefixed_Name(w3id, "def/NyOn#r") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/NyOn#x</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/NyOn#x">https://w3id.org/def/NyOn#x</seealso>
    let ``def/NyOn#x`` = Prefixed_Name(w3id, "def/NyOn#x") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/NyOn#y</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/NyOn#y">https://w3id.org/def/NyOn#y</seealso>
    let ``def/NyOn#y`` = Prefixed_Name(w3id, "def/NyOn#y") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/saref4building#BuildingObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object in the building that can be controlled by devices, such as a door or a window that can be automatically opened or closed by an actuator. (Definition taken from SAREF 1.0)"</para>
    /// labels<para>"Building object"</para></remarks>
    /// <seealso href="https://w3id.org/def/saref4building#BuildingObject">https://w3id.org/def/saref4building#BuildingObject</seealso>
    let ``def/saref4building#BuildingObject`` =
        Prefixed_Name(w3id, "def/saref4building#BuildingObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/saref4building#PhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Object that has a proper space region. (Definition extracted from DUL ontology)"</para>
    /// labels<para>"Physical object"</para></remarks>
    /// <seealso href="https://w3id.org/def/saref4building#PhysicalObject">https://w3id.org/def/saref4building#PhysicalObject</seealso>
    let ``def/saref4building#PhysicalObject`` =
        Prefixed_Name(w3id, "def/saref4building#PhysicalObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/saref4building#ShadingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Shading devices are purpose built devices to protect from the sunlight, from natural light, or screening them from view. Shading devices can form part of the facade or can be mounted inside the building, they can be fixed or operable. (Definition taken from S4BLDG ontology)"</para>
    /// labels<para>"Shading device"</para></remarks>
    /// <seealso href="https://w3id.org/def/saref4building#ShadingDevice">https://w3id.org/def/saref4building#ShadingDevice</seealso>
    let ``def/saref4building#ShadingDevice`` =
        Prefixed_Name(w3id, "def/saref4building#ShadingDevice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/saref4building#UnitaryControlElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unitary control element provides a housing for an aggregation of control or electrical distribution elements that, in combination, perform a singular (unitary) purpose. Each item in the aggregation may have its own geometric representation and location. (Definition taken from S4BLDG ontology)"</para>
    /// labels<para>"Unitary control element"</para></remarks>
    /// <seealso href="https://w3id.org/def/saref4building#UnitaryControlElement">https://w3id.org/def/saref4building#UnitaryControlElement</seealso>
    let ``def/saref4building#UnitaryControlElement`` =
        Prefixed_Name(w3id, "def/saref4building#UnitaryControlElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/saref4building#contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a physical space and the objects located in such space."</para>
    /// labels<para>"contains"</para></remarks>
    /// <seealso href="https://w3id.org/def/saref4building#contains">https://w3id.org/def/saref4building#contains</seealso>
    let ``def/saref4building#contains`` =
        Prefixed_Name(w3id, "def/saref4building#contains") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/saref4building#hasSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a building or a building space and the spaces it can be divided into."</para>
    /// labels<para>"has space"</para></remarks>
    /// <seealso href="https://w3id.org/def/saref4building#hasSpace">https://w3id.org/def/saref4building#hasSpace</seealso>
    let ``def/saref4building#hasSpace`` =
        Prefixed_Name(w3id, "def/saref4building#hasSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dot/0.8</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dot/0.8">https://w3id.org/dot/0.8</seealso>
    let ``dot/0.8`` = Prefixed_Name(w3id, "dot/0.8") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:Ontology</para>
    ///   <para>dcterms:Agent</para>
    ///   <para>foaf:Organization</para>
    ///   <para>prof:Profile</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv">https://w3id.org/dpv</seealso>
    let dpv = Prefixed_Name(w3id, "dpv") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv/2.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/2.2">https://w3id.org/dpv/2.2</seealso>
    let ``dpv/2.2`` = Prefixed_Name(w3id, "dpv/2.2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv/dpv-pd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd">https://w3id.org/dpv/dpv-pd</seealso>
    let ``dpv/dpv_pd`` = Prefixed_Name(w3id, "dpv/dpv-pd") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#">https://w3id.org/dpv/dpv-pd#</seealso>
    let ``dpv/dpv_pd#`` = Prefixed_Name(w3id, "dpv/dpv-pd#") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Accent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Accent">https://w3id.org/dpv/dpv-pd#Accent</seealso>
    let ``dpv/dpv_pd#Accent`` = Prefixed_Name(w3id, "dpv/dpv-pd#Accent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#AccountIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#AccountIdentifier">https://w3id.org/dpv/dpv-pd#AccountIdentifier</seealso>
    let ``dpv/dpv_pd#AccountIdentifier`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#AccountIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Acquantaince</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Acquantaince">https://w3id.org/dpv/dpv-pd#Acquantaince</seealso>
    let ``dpv/dpv_pd#Acquantaince`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Acquantaince") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Age</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Age">https://w3id.org/dpv/dpv-pd#Age</seealso>
    let ``dpv/dpv_pd#Age`` = Prefixed_Name(w3id, "dpv/dpv-pd#Age") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#AgeExact</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#AgeExact">https://w3id.org/dpv/dpv-pd#AgeExact</seealso>
    let ``dpv/dpv_pd#AgeExact`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#AgeExact") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#AgeRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#AgeRange">https://w3id.org/dpv/dpv-pd#AgeRange</seealso>
    let ``dpv/dpv_pd#AgeRange`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#AgeRange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#ApartmentOwned</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#ApartmentOwned">https://w3id.org/dpv/dpv-pd#ApartmentOwned</seealso>
    let ``dpv/dpv_pd#ApartmentOwned`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#ApartmentOwned") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Association">https://w3id.org/dpv/dpv-pd#Association</seealso>
    let ``dpv/dpv_pd#Association`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Association") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Attitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Attitude">https://w3id.org/dpv/dpv-pd#Attitude</seealso>
    let ``dpv/dpv_pd#Attitude`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Attitude") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Authenticating</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Authenticating">https://w3id.org/dpv/dpv-pd#Authenticating</seealso>
    let ``dpv/dpv_pd#Authenticating`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Authenticating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#AuthenticationHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#AuthenticationHistory">https://w3id.org/dpv/dpv-pd#AuthenticationHistory</seealso>
    let ``dpv/dpv_pd#AuthenticationHistory`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#AuthenticationHistory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#BankAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#BankAccount">https://w3id.org/dpv/dpv-pd#BankAccount</seealso>
    let ``dpv/dpv_pd#BankAccount`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#BankAccount") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Behavioral</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Behavioral">https://w3id.org/dpv/dpv-pd#Behavioral</seealso>
    let ``dpv/dpv_pd#Behavioral`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Behavioral") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Biometric</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Biometric">https://w3id.org/dpv/dpv-pd#Biometric</seealso>
    let ``dpv/dpv_pd#Biometric`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Biometric") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#BirthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#BirthDate">https://w3id.org/dpv/dpv-pd#BirthDate</seealso>
    let ``dpv/dpv_pd#BirthDate`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#BirthDate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#BirthPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#BirthPlace">https://w3id.org/dpv/dpv-pd#BirthPlace</seealso>
    let ``dpv/dpv_pd#BirthPlace`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#BirthPlace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#BloodType</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#BloodType">https://w3id.org/dpv/dpv-pd#BloodType</seealso>
    let ``dpv/dpv_pd#BloodType`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#BloodType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#BrowserFingerprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#BrowserFingerprint">https://w3id.org/dpv/dpv-pd#BrowserFingerprint</seealso>
    let ``dpv/dpv_pd#BrowserFingerprint`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#BrowserFingerprint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#BrowserHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#BrowserHistory">https://w3id.org/dpv/dpv-pd#BrowserHistory</seealso>
    let ``dpv/dpv_pd#BrowserHistory`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#BrowserHistory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#BrowsingBehavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#BrowsingBehavior">https://w3id.org/dpv/dpv-pd#BrowsingBehavior</seealso>
    let ``dpv/dpv_pd#BrowsingBehavior`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#BrowsingBehavior") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#BrowsingReferral</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#BrowsingReferral">https://w3id.org/dpv/dpv-pd#BrowsingReferral</seealso>
    let ``dpv/dpv_pd#BrowsingReferral`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#BrowsingReferral") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CallLog</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CallLog">https://w3id.org/dpv/dpv-pd#CallLog</seealso>
    let ``dpv/dpv_pd#CallLog`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CallLog") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CarOwned</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CarOwned">https://w3id.org/dpv/dpv-pd#CarOwned</seealso>
    let ``dpv/dpv_pd#CarOwned`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CarOwned") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Character">https://w3id.org/dpv/dpv-pd#Character</seealso>
    let ``dpv/dpv_pd#Character`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Character") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Communication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Communication">https://w3id.org/dpv/dpv-pd#Communication</seealso>
    let ``dpv/dpv_pd#Communication`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Communication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CommunicationsMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CommunicationsMetadata">https://w3id.org/dpv/dpv-pd#CommunicationsMetadata</seealso>
    let ``dpv/dpv_pd#CommunicationsMetadata`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CommunicationsMetadata") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Connection">https://w3id.org/dpv/dpv-pd#Connection</seealso>
    let ``dpv/dpv_pd#Connection`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Connection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Contact">https://w3id.org/dpv/dpv-pd#Contact</seealso>
    let ``dpv/dpv_pd#Contact`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Contact") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Country">https://w3id.org/dpv/dpv-pd#Country</seealso>
    let ``dpv/dpv_pd#Country`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Country") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Credit</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Credit">https://w3id.org/dpv/dpv-pd#Credit</seealso>
    let ``dpv/dpv_pd#Credit`` = Prefixed_Name(w3id, "dpv/dpv-pd#Credit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CreditCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CreditCapacity">https://w3id.org/dpv/dpv-pd#CreditCapacity</seealso>
    let ``dpv/dpv_pd#CreditCapacity`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CreditCapacity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CreditCardNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CreditCardNumber">https://w3id.org/dpv/dpv-pd#CreditCardNumber</seealso>
    let ``dpv/dpv_pd#CreditCardNumber`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CreditCardNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CreditRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CreditRecord">https://w3id.org/dpv/dpv-pd#CreditRecord</seealso>
    let ``dpv/dpv_pd#CreditRecord`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CreditRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CreditScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CreditScore">https://w3id.org/dpv/dpv-pd#CreditScore</seealso>
    let ``dpv/dpv_pd#CreditScore`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CreditScore") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CreditStanding</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CreditStanding">https://w3id.org/dpv/dpv-pd#CreditStanding</seealso>
    let ``dpv/dpv_pd#CreditStanding`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CreditStanding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CreditWorthiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CreditWorthiness">https://w3id.org/dpv/dpv-pd#CreditWorthiness</seealso>
    let ``dpv/dpv_pd#CreditWorthiness`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CreditWorthiness") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Criminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Criminal">https://w3id.org/dpv/dpv-pd#Criminal</seealso>
    let ``dpv/dpv_pd#Criminal`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Criminal") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CriminalCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CriminalCharge">https://w3id.org/dpv/dpv-pd#CriminalCharge</seealso>
    let ``dpv/dpv_pd#CriminalCharge`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CriminalCharge") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CriminalConviction</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CriminalConviction">https://w3id.org/dpv/dpv-pd#CriminalConviction</seealso>
    let ``dpv/dpv_pd#CriminalConviction`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CriminalConviction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CriminalOffense</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CriminalOffense">https://w3id.org/dpv/dpv-pd#CriminalOffense</seealso>
    let ``dpv/dpv_pd#CriminalOffense`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CriminalOffense") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CriminalPardon</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CriminalPardon">https://w3id.org/dpv/dpv-pd#CriminalPardon</seealso>
    let ``dpv/dpv_pd#CriminalPardon`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CriminalPardon") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#CurrentEmployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#CurrentEmployment">https://w3id.org/dpv/dpv-pd#CurrentEmployment</seealso>
    let ``dpv/dpv_pd#CurrentEmployment`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#CurrentEmployment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#DNACode</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#DNACode">https://w3id.org/dpv/dpv-pd#DNACode</seealso>
    let ``dpv/dpv_pd#DNACode`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#DNACode") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Demeanor</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Demeanor">https://w3id.org/dpv/dpv-pd#Demeanor</seealso>
    let ``dpv/dpv_pd#Demeanor`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Demeanor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Demographic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Demographic">https://w3id.org/dpv/dpv-pd#Demographic</seealso>
    let ``dpv/dpv_pd#Demographic`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Demographic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#DeviceApplications</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#DeviceApplications">https://w3id.org/dpv/dpv-pd#DeviceApplications</seealso>
    let ``dpv/dpv_pd#DeviceApplications`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#DeviceApplications") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#DeviceBased</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#DeviceBased">https://w3id.org/dpv/dpv-pd#DeviceBased</seealso>
    let ``dpv/dpv_pd#DeviceBased`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#DeviceBased") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#DeviceOperatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#DeviceOperatingSystem">https://w3id.org/dpv/dpv-pd#DeviceOperatingSystem</seealso>
    let ``dpv/dpv_pd#DeviceOperatingSystem`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#DeviceOperatingSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#DeviceSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#DeviceSoftware">https://w3id.org/dpv/dpv-pd#DeviceSoftware</seealso>
    let ``dpv/dpv_pd#DeviceSoftware`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#DeviceSoftware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Dialect</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Dialect">https://w3id.org/dpv/dpv-pd#Dialect</seealso>
    let ``dpv/dpv_pd#Dialect`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Dialect") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#DigitalFingerprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#DigitalFingerprint">https://w3id.org/dpv/dpv-pd#DigitalFingerprint</seealso>
    let ``dpv/dpv_pd#DigitalFingerprint`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#DigitalFingerprint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Disability</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Disability">https://w3id.org/dpv/dpv-pd#Disability</seealso>
    let ``dpv/dpv_pd#Disability`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Disability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#DisciplinaryAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#DisciplinaryAction">https://w3id.org/dpv/dpv-pd#DisciplinaryAction</seealso>
    let ``dpv/dpv_pd#DisciplinaryAction`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#DisciplinaryAction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Dislike</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Dislike">https://w3id.org/dpv/dpv-pd#Dislike</seealso>
    let ``dpv/dpv_pd#Dislike`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Dislike") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Divorce</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Divorce">https://w3id.org/dpv/dpv-pd#Divorce</seealso>
    let ``dpv/dpv_pd#Divorce`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Divorce") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#DrugTestResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#DrugTestResult">https://w3id.org/dpv/dpv-pd#DrugTestResult</seealso>
    let ``dpv/dpv_pd#DrugTestResult`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#DrugTestResult") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Education</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Education">https://w3id.org/dpv/dpv-pd#Education</seealso>
    let ``dpv/dpv_pd#Education`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Education") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#EducationExperience</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#EducationExperience">https://w3id.org/dpv/dpv-pd#EducationExperience</seealso>
    let ``dpv/dpv_pd#EducationExperience`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#EducationExperience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#EducationQualification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#EducationQualification">https://w3id.org/dpv/dpv-pd#EducationQualification</seealso>
    let ``dpv/dpv_pd#EducationQualification`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#EducationQualification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#EmailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#EmailAddress">https://w3id.org/dpv/dpv-pd#EmailAddress</seealso>
    let ``dpv/dpv_pd#EmailAddress`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#EmailAddress") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#EmailAddressPersonal</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#EmailAddressPersonal">https://w3id.org/dpv/dpv-pd#EmailAddressPersonal</seealso>
    let ``dpv/dpv_pd#EmailAddressPersonal`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#EmailAddressPersonal") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#EmailAddressWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#EmailAddressWork">https://w3id.org/dpv/dpv-pd#EmailAddressWork</seealso>
    let ``dpv/dpv_pd#EmailAddressWork`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#EmailAddressWork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#EmailContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#EmailContent">https://w3id.org/dpv/dpv-pd#EmailContent</seealso>
    let ``dpv/dpv_pd#EmailContent`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#EmailContent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#EmploymentHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#EmploymentHistory">https://w3id.org/dpv/dpv-pd#EmploymentHistory</seealso>
    let ``dpv/dpv_pd#EmploymentHistory`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#EmploymentHistory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#EthnicOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#EthnicOrigin">https://w3id.org/dpv/dpv-pd#EthnicOrigin</seealso>
    let ``dpv/dpv_pd#EthnicOrigin`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#EthnicOrigin") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Ethnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Ethnicity">https://w3id.org/dpv/dpv-pd#Ethnicity</seealso>
    let ``dpv/dpv_pd#Ethnicity`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Ethnicity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#External</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#External">https://w3id.org/dpv/dpv-pd#External</seealso>
    let ``dpv/dpv_pd#External`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#External") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#FacialPrint</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#FacialPrint">https://w3id.org/dpv/dpv-pd#FacialPrint</seealso>
    let ``dpv/dpv_pd#FacialPrint`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#FacialPrint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Family">https://w3id.org/dpv/dpv-pd#Family</seealso>
    let ``dpv/dpv_pd#Family`` = Prefixed_Name(w3id, "dpv/dpv-pd#Family") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#FamilyHealthHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#FamilyHealthHistory">https://w3id.org/dpv/dpv-pd#FamilyHealthHistory</seealso>
    let ``dpv/dpv_pd#FamilyHealthHistory`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#FamilyHealthHistory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#FamilyStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#FamilyStructure">https://w3id.org/dpv/dpv-pd#FamilyStructure</seealso>
    let ``dpv/dpv_pd#FamilyStructure`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#FamilyStructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Favorite</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Favorite">https://w3id.org/dpv/dpv-pd#Favorite</seealso>
    let ``dpv/dpv_pd#Favorite`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Favorite") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#FavoriteColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#FavoriteColor">https://w3id.org/dpv/dpv-pd#FavoriteColor</seealso>
    let ``dpv/dpv_pd#FavoriteColor`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#FavoriteColor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#FavoriteFood</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#FavoriteFood">https://w3id.org/dpv/dpv-pd#FavoriteFood</seealso>
    let ``dpv/dpv_pd#FavoriteFood`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#FavoriteFood") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#FavoriteMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#FavoriteMusic">https://w3id.org/dpv/dpv-pd#FavoriteMusic</seealso>
    let ``dpv/dpv_pd#FavoriteMusic`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#FavoriteMusic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Fetish</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Fetish">https://w3id.org/dpv/dpv-pd#Fetish</seealso>
    let ``dpv/dpv_pd#Fetish`` = Prefixed_Name(w3id, "dpv/dpv-pd#Fetish") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Financial</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Financial">https://w3id.org/dpv/dpv-pd#Financial</seealso>
    let ``dpv/dpv_pd#Financial`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Financial") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#FinancialAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#FinancialAccount">https://w3id.org/dpv/dpv-pd#FinancialAccount</seealso>
    let ``dpv/dpv_pd#FinancialAccount`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#FinancialAccount") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#FinancialAccountNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#FinancialAccountNumber">https://w3id.org/dpv/dpv-pd#FinancialAccountNumber</seealso>
    let ``dpv/dpv_pd#FinancialAccountNumber`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#FinancialAccountNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#FinancialStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#FinancialStatus">https://w3id.org/dpv/dpv-pd#FinancialStatus</seealso>
    let ``dpv/dpv_pd#FinancialStatus`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#FinancialStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Fingerprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Fingerprint">https://w3id.org/dpv/dpv-pd#Fingerprint</seealso>
    let ``dpv/dpv_pd#Fingerprint`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Fingerprint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Friend</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Friend">https://w3id.org/dpv/dpv-pd#Friend</seealso>
    let ``dpv/dpv_pd#Friend`` = Prefixed_Name(w3id, "dpv/dpv-pd#Friend") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#GPSCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#GPSCoordinate">https://w3id.org/dpv/dpv-pd#GPSCoordinate</seealso>
    let ``dpv/dpv_pd#GPSCoordinate`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#GPSCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Gender">https://w3id.org/dpv/dpv-pd#Gender</seealso>
    let ``dpv/dpv_pd#Gender`` = Prefixed_Name(w3id, "dpv/dpv-pd#Gender") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#GeneralReputation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#GeneralReputation">https://w3id.org/dpv/dpv-pd#GeneralReputation</seealso>
    let ``dpv/dpv_pd#GeneralReputation`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#GeneralReputation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Genetic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Genetic">https://w3id.org/dpv/dpv-pd#Genetic</seealso>
    let ``dpv/dpv_pd#Genetic`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Genetic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Geographic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Geographic">https://w3id.org/dpv/dpv-pd#Geographic</seealso>
    let ``dpv/dpv_pd#Geographic`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Geographic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#GroupMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#GroupMembership">https://w3id.org/dpv/dpv-pd#GroupMembership</seealso>
    let ``dpv/dpv_pd#GroupMembership`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#GroupMembership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#HairColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#HairColor">https://w3id.org/dpv/dpv-pd#HairColor</seealso>
    let ``dpv/dpv_pd#HairColor`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#HairColor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Health</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Health">https://w3id.org/dpv/dpv-pd#Health</seealso>
    let ``dpv/dpv_pd#Health`` = Prefixed_Name(w3id, "dpv/dpv-pd#Health") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#HealthHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#HealthHistory">https://w3id.org/dpv/dpv-pd#HealthHistory</seealso>
    let ``dpv/dpv_pd#HealthHistory`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#HealthHistory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#HealthRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#HealthRecord">https://w3id.org/dpv/dpv-pd#HealthRecord</seealso>
    let ``dpv/dpv_pd#HealthRecord`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#HealthRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Height</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Height">https://w3id.org/dpv/dpv-pd#Height</seealso>
    let ``dpv/dpv_pd#Height`` = Prefixed_Name(w3id, "dpv/dpv-pd#Height") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Historical</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Historical">https://w3id.org/dpv/dpv-pd#Historical</seealso>
    let ``dpv/dpv_pd#Historical`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Historical") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#HouseOwned</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#HouseOwned">https://w3id.org/dpv/dpv-pd#HouseOwned</seealso>
    let ``dpv/dpv_pd#HouseOwned`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#HouseOwned") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Household</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Household">https://w3id.org/dpv/dpv-pd#Household</seealso>
    let ``dpv/dpv_pd#Household`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Household") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#IPAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#IPAddress">https://w3id.org/dpv/dpv-pd#IPAddress</seealso>
    let ``dpv/dpv_pd#IPAddress`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#IPAddress") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Identifier">https://w3id.org/dpv/dpv-pd#Identifier</seealso>
    let ``dpv/dpv_pd#Identifier`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Identifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Identifying</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Identifying">https://w3id.org/dpv/dpv-pd#Identifying</seealso>
    let ``dpv/dpv_pd#Identifying`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Identifying") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Income</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Income">https://w3id.org/dpv/dpv-pd#Income</seealso>
    let ``dpv/dpv_pd#Income`` = Prefixed_Name(w3id, "dpv/dpv-pd#Income") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#IncomeBracket</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#IncomeBracket">https://w3id.org/dpv/dpv-pd#IncomeBracket</seealso>
    let ``dpv/dpv_pd#IncomeBracket`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#IncomeBracket") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#IndividualHealthHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#IndividualHealthHistory">https://w3id.org/dpv/dpv-pd#IndividualHealthHistory</seealso>
    let ``dpv/dpv_pd#IndividualHealthHistory`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#IndividualHealthHistory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Insurance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Insurance">https://w3id.org/dpv/dpv-pd#Insurance</seealso>
    let ``dpv/dpv_pd#Insurance`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Insurance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Intention</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Intention">https://w3id.org/dpv/dpv-pd#Intention</seealso>
    let ``dpv/dpv_pd#Intention`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Intention") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Interaction">https://w3id.org/dpv/dpv-pd#Interaction</seealso>
    let ``dpv/dpv_pd#Interaction`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Interaction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Interest">https://w3id.org/dpv/dpv-pd#Interest</seealso>
    let ``dpv/dpv_pd#Interest`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Interest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Internal</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Internal">https://w3id.org/dpv/dpv-pd#Internal</seealso>
    let ``dpv/dpv_pd#Internal`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Internal") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Job</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Job">https://w3id.org/dpv/dpv-pd#Job</seealso>
    let ``dpv/dpv_pd#Job`` = Prefixed_Name(w3id, "dpv/dpv-pd#Job") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#KnowledgeBelief</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#KnowledgeBelief">https://w3id.org/dpv/dpv-pd#KnowledgeBelief</seealso>
    let ``dpv/dpv_pd#KnowledgeBelief`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#KnowledgeBelief") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Language">https://w3id.org/dpv/dpv-pd#Language</seealso>
    let ``dpv/dpv_pd#Language`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Language") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#LifeHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#LifeHistory">https://w3id.org/dpv/dpv-pd#LifeHistory</seealso>
    let ``dpv/dpv_pd#LifeHistory`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#LifeHistory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Like</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Like">https://w3id.org/dpv/dpv-pd#Like</seealso>
    let ``dpv/dpv_pd#Like`` = Prefixed_Name(w3id, "dpv/dpv-pd#Like") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#LinkClicked</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#LinkClicked">https://w3id.org/dpv/dpv-pd#LinkClicked</seealso>
    let ``dpv/dpv_pd#LinkClicked`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#LinkClicked") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#LoanRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#LoanRecord">https://w3id.org/dpv/dpv-pd#LoanRecord</seealso>
    let ``dpv/dpv_pd#LoanRecord`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#LoanRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Location">https://w3id.org/dpv/dpv-pd#Location</seealso>
    let ``dpv/dpv_pd#Location`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Location") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#MACAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#MACAddress">https://w3id.org/dpv/dpv-pd#MACAddress</seealso>
    let ``dpv/dpv_pd#MACAddress`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#MACAddress") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#MaritalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#MaritalStatus">https://w3id.org/dpv/dpv-pd#MaritalStatus</seealso>
    let ``dpv/dpv_pd#MaritalStatus`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#MaritalStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Marriage</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Marriage">https://w3id.org/dpv/dpv-pd#Marriage</seealso>
    let ``dpv/dpv_pd#Marriage`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Marriage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#MedicalHealth</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#MedicalHealth">https://w3id.org/dpv/dpv-pd#MedicalHealth</seealso>
    let ``dpv/dpv_pd#MedicalHealth`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#MedicalHealth") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#MentalHealth</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#MentalHealth">https://w3id.org/dpv/dpv-pd#MentalHealth</seealso>
    let ``dpv/dpv_pd#MentalHealth`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#MentalHealth") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Name">https://w3id.org/dpv/dpv-pd#Name</seealso>
    let ``dpv/dpv_pd#Name`` = Prefixed_Name(w3id, "dpv/dpv-pd#Name") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Nationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Nationality">https://w3id.org/dpv/dpv-pd#Nationality</seealso>
    let ``dpv/dpv_pd#Nationality`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Nationality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#OfficialID</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#OfficialID">https://w3id.org/dpv/dpv-pd#OfficialID</seealso>
    let ``dpv/dpv_pd#OfficialID`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#OfficialID") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Offspring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Offspring">https://w3id.org/dpv/dpv-pd#Offspring</seealso>
    let ``dpv/dpv_pd#Offspring`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Offspring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Opinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Opinion">https://w3id.org/dpv/dpv-pd#Opinion</seealso>
    let ``dpv/dpv_pd#Opinion`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Opinion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Ownership</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Ownership">https://w3id.org/dpv/dpv-pd#Ownership</seealso>
    let ``dpv/dpv_pd#Ownership`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Ownership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PINCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PINCode">https://w3id.org/dpv/dpv-pd#PINCode</seealso>
    let ``dpv/dpv_pd#PINCode`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PINCode") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Parent">https://w3id.org/dpv/dpv-pd#Parent</seealso>
    let ``dpv/dpv_pd#Parent`` = Prefixed_Name(w3id, "dpv/dpv-pd#Parent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Passport</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Passport">https://w3id.org/dpv/dpv-pd#Passport</seealso>
    let ``dpv/dpv_pd#Passport`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Passport") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Password</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Password">https://w3id.org/dpv/dpv-pd#Password</seealso>
    let ``dpv/dpv_pd#Password`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Password") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PastEmployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PastEmployment">https://w3id.org/dpv/dpv-pd#PastEmployment</seealso>
    let ``dpv/dpv_pd#PastEmployment`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PastEmployment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PaymentCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PaymentCard">https://w3id.org/dpv/dpv-pd#PaymentCard</seealso>
    let ``dpv/dpv_pd#PaymentCard`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PaymentCard") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PaymentCardExpiry</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PaymentCardExpiry">https://w3id.org/dpv/dpv-pd#PaymentCardExpiry</seealso>
    let ``dpv/dpv_pd#PaymentCardExpiry`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PaymentCardExpiry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PaymentCardNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PaymentCardNumber">https://w3id.org/dpv/dpv-pd#PaymentCardNumber</seealso>
    let ``dpv/dpv_pd#PaymentCardNumber`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PaymentCardNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PerformanceAtWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PerformanceAtWork">https://w3id.org/dpv/dpv-pd#PerformanceAtWork</seealso>
    let ``dpv/dpv_pd#PerformanceAtWork`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PerformanceAtWork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PersonalDataConcepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Collection</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PersonalDataConcepts">https://w3id.org/dpv/dpv-pd#PersonalDataConcepts</seealso>
    let ``dpv/dpv_pd#PersonalDataConcepts`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PersonalDataConcepts") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PersonalDocuments</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PersonalDocuments">https://w3id.org/dpv/dpv-pd#PersonalDocuments</seealso>
    let ``dpv/dpv_pd#PersonalDocuments`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PersonalDocuments") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PersonalPossession</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PersonalPossession">https://w3id.org/dpv/dpv-pd#PersonalPossession</seealso>
    let ``dpv/dpv_pd#PersonalPossession`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PersonalPossession") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Personality</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Personality">https://w3id.org/dpv/dpv-pd#Personality</seealso>
    let ``dpv/dpv_pd#Personality`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Personality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PhilosophicalBelief</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PhilosophicalBelief">https://w3id.org/dpv/dpv-pd#PhilosophicalBelief</seealso>
    let ``dpv/dpv_pd#PhilosophicalBelief`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PhilosophicalBelief") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PhysicalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PhysicalAddress">https://w3id.org/dpv/dpv-pd#PhysicalAddress</seealso>
    let ``dpv/dpv_pd#PhysicalAddress`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PhysicalAddress") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PhysicalCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PhysicalCharacteristic">https://w3id.org/dpv/dpv-pd#PhysicalCharacteristic</seealso>
    let ``dpv/dpv_pd#PhysicalCharacteristic`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PhysicalCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PhysicalHealth</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PhysicalHealth">https://w3id.org/dpv/dpv-pd#PhysicalHealth</seealso>
    let ``dpv/dpv_pd#PhysicalHealth`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PhysicalHealth") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PhysicalTrait</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PhysicalTrait">https://w3id.org/dpv/dpv-pd#PhysicalTrait</seealso>
    let ``dpv/dpv_pd#PhysicalTrait`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PhysicalTrait") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Picture</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Picture">https://w3id.org/dpv/dpv-pd#Picture</seealso>
    let ``dpv/dpv_pd#Picture`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Picture") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Piercing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Piercing">https://w3id.org/dpv/dpv-pd#Piercing</seealso>
    let ``dpv/dpv_pd#Piercing`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Piercing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PoliticalAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PoliticalAffiliation">https://w3id.org/dpv/dpv-pd#PoliticalAffiliation</seealso>
    let ``dpv/dpv_pd#PoliticalAffiliation`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PoliticalAffiliation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PoliticalOpinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PoliticalOpinion">https://w3id.org/dpv/dpv-pd#PoliticalOpinion</seealso>
    let ``dpv/dpv_pd#PoliticalOpinion`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PoliticalOpinion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Preference</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Preference">https://w3id.org/dpv/dpv-pd#Preference</seealso>
    let ``dpv/dpv_pd#Preference`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Preference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Prescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Prescription">https://w3id.org/dpv/dpv-pd#Prescription</seealso>
    let ``dpv/dpv_pd#Prescription`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Prescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PrivacyPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PrivacyPreference">https://w3id.org/dpv/dpv-pd#PrivacyPreference</seealso>
    let ``dpv/dpv_pd#PrivacyPreference`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PrivacyPreference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Proclivitie</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Proclivitie">https://w3id.org/dpv/dpv-pd#Proclivitie</seealso>
    let ``dpv/dpv_pd#Proclivitie`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Proclivitie") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Professional</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Professional">https://w3id.org/dpv/dpv-pd#Professional</seealso>
    let ``dpv/dpv_pd#Professional`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Professional") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#ProfessionalCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#ProfessionalCertification">https://w3id.org/dpv/dpv-pd#ProfessionalCertification</seealso>
    let ``dpv/dpv_pd#ProfessionalCertification`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#ProfessionalCertification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#ProfessionalEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#ProfessionalEvaluation">https://w3id.org/dpv/dpv-pd#ProfessionalEvaluation</seealso>
    let ``dpv/dpv_pd#ProfessionalEvaluation`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#ProfessionalEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#ProfessionalInterview</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#ProfessionalInterview">https://w3id.org/dpv/dpv-pd#ProfessionalInterview</seealso>
    let ``dpv/dpv_pd#ProfessionalInterview`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#ProfessionalInterview") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Profile">https://w3id.org/dpv/dpv-pd#Profile</seealso>
    let ``dpv/dpv_pd#Profile`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Profile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PublicLife</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PublicLife">https://w3id.org/dpv/dpv-pd#PublicLife</seealso>
    let ``dpv/dpv_pd#PublicLife`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PublicLife") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PubliclyAvailableSocialMedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PubliclyAvailableSocialMedia">https://w3id.org/dpv/dpv-pd#PubliclyAvailableSocialMedia</seealso>
    let ``dpv/dpv_pd#PubliclyAvailableSocialMedia`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PubliclyAvailableSocialMedia") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Purchase</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Purchase">https://w3id.org/dpv/dpv-pd#Purchase</seealso>
    let ``dpv/dpv_pd#Purchase`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Purchase") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#PurchasesAndSpendingHabit</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#PurchasesAndSpendingHabit">https://w3id.org/dpv/dpv-pd#PurchasesAndSpendingHabit</seealso>
    let ``dpv/dpv_pd#PurchasesAndSpendingHabit`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#PurchasesAndSpendingHabit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Race</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Race">https://w3id.org/dpv/dpv-pd#Race</seealso>
    let ``dpv/dpv_pd#Race`` = Prefixed_Name(w3id, "dpv/dpv-pd#Race") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Reference">https://w3id.org/dpv/dpv-pd#Reference</seealso>
    let ``dpv/dpv_pd#Reference`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Reference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Relationship">https://w3id.org/dpv/dpv-pd#Relationship</seealso>
    let ``dpv/dpv_pd#Relationship`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Relationship") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Reliability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Reliability">https://w3id.org/dpv/dpv-pd#Reliability</seealso>
    let ``dpv/dpv_pd#Reliability`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Reliability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Religion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Religion">https://w3id.org/dpv/dpv-pd#Religion</seealso>
    let ``dpv/dpv_pd#Religion`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Religion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#ReligiousBelief</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#ReligiousBelief">https://w3id.org/dpv/dpv-pd#ReligiousBelief</seealso>
    let ``dpv/dpv_pd#ReligiousBelief`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#ReligiousBelief") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Retina</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Retina">https://w3id.org/dpv/dpv-pd#Retina</seealso>
    let ``dpv/dpv_pd#Retina`` = Prefixed_Name(w3id, "dpv/dpv-pd#Retina") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#RoomNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#RoomNumber">https://w3id.org/dpv/dpv-pd#RoomNumber</seealso>
    let ``dpv/dpv_pd#RoomNumber`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#RoomNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Salary</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Salary">https://w3id.org/dpv/dpv-pd#Salary</seealso>
    let ``dpv/dpv_pd#Salary`` = Prefixed_Name(w3id, "dpv/dpv-pd#Salary") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Sale</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Sale">https://w3id.org/dpv/dpv-pd#Sale</seealso>
    let ``dpv/dpv_pd#Sale`` = Prefixed_Name(w3id, "dpv/dpv-pd#Sale") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#School</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#School">https://w3id.org/dpv/dpv-pd#School</seealso>
    let ``dpv/dpv_pd#School`` = Prefixed_Name(w3id, "dpv/dpv-pd#School") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#SecretText</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#SecretText">https://w3id.org/dpv/dpv-pd#SecretText</seealso>
    let ``dpv/dpv_pd#SecretText`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#SecretText") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#ServiceConsumptionBehavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#ServiceConsumptionBehavior">https://w3id.org/dpv/dpv-pd#ServiceConsumptionBehavior</seealso>
    let ``dpv/dpv_pd#ServiceConsumptionBehavior`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#ServiceConsumptionBehavior") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Sexual</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Sexual">https://w3id.org/dpv/dpv-pd#Sexual</seealso>
    let ``dpv/dpv_pd#Sexual`` = Prefixed_Name(w3id, "dpv/dpv-pd#Sexual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#SexualHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#SexualHistory">https://w3id.org/dpv/dpv-pd#SexualHistory</seealso>
    let ``dpv/dpv_pd#SexualHistory`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#SexualHistory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#SexualPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#SexualPreference">https://w3id.org/dpv/dpv-pd#SexualPreference</seealso>
    let ``dpv/dpv_pd#SexualPreference`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#SexualPreference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Sibling</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Sibling">https://w3id.org/dpv/dpv-pd#Sibling</seealso>
    let ``dpv/dpv_pd#Sibling`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Sibling") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#SkinTone</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#SkinTone">https://w3id.org/dpv/dpv-pd#SkinTone</seealso>
    let ``dpv/dpv_pd#SkinTone`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#SkinTone") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Social</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Social">https://w3id.org/dpv/dpv-pd#Social</seealso>
    let ``dpv/dpv_pd#Social`` = Prefixed_Name(w3id, "dpv/dpv-pd#Social") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#SocialMedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#SocialMedia">https://w3id.org/dpv/dpv-pd#SocialMedia</seealso>
    let ``dpv/dpv_pd#SocialMedia`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#SocialMedia") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#SocialMediaCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#SocialMediaCommunication">https://w3id.org/dpv/dpv-pd#SocialMediaCommunication</seealso>
    let ``dpv/dpv_pd#SocialMediaCommunication`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#SocialMediaCommunication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#SocialNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#SocialNetwork">https://w3id.org/dpv/dpv-pd#SocialNetwork</seealso>
    let ``dpv/dpv_pd#SocialNetwork`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#SocialNetwork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#SocialStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#SocialStatus">https://w3id.org/dpv/dpv-pd#SocialStatus</seealso>
    let ``dpv/dpv_pd#SocialStatus`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#SocialStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#TVViewingBehavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#TVViewingBehavior">https://w3id.org/dpv/dpv-pd#TVViewingBehavior</seealso>
    let ``dpv/dpv_pd#TVViewingBehavior`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#TVViewingBehavior") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Tattoo</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Tattoo">https://w3id.org/dpv/dpv-pd#Tattoo</seealso>
    let ``dpv/dpv_pd#Tattoo`` = Prefixed_Name(w3id, "dpv/dpv-pd#Tattoo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Tax</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Tax">https://w3id.org/dpv/dpv-pd#Tax</seealso>
    let ``dpv/dpv_pd#Tax`` = Prefixed_Name(w3id, "dpv/dpv-pd#Tax") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#TelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#TelephoneNumber">https://w3id.org/dpv/dpv-pd#TelephoneNumber</seealso>
    let ``dpv/dpv_pd#TelephoneNumber`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#TelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Thought</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Thought">https://w3id.org/dpv/dpv-pd#Thought</seealso>
    let ``dpv/dpv_pd#Thought`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Thought") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Tracking</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Tracking">https://w3id.org/dpv/dpv-pd#Tracking</seealso>
    let ``dpv/dpv_pd#Tracking`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Tracking") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#TradeUnionMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#TradeUnionMembership">https://w3id.org/dpv/dpv-pd#TradeUnionMembership</seealso>
    let ``dpv/dpv_pd#TradeUnionMembership`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#TradeUnionMembership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Transaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Transaction">https://w3id.org/dpv/dpv-pd#Transaction</seealso>
    let ``dpv/dpv_pd#Transaction`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Transaction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Transactional</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Transactional">https://w3id.org/dpv/dpv-pd#Transactional</seealso>
    let ``dpv/dpv_pd#Transactional`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Transactional") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#TravelHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#TravelHistory">https://w3id.org/dpv/dpv-pd#TravelHistory</seealso>
    let ``dpv/dpv_pd#TravelHistory`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#TravelHistory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#UID</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#UID">https://w3id.org/dpv/dpv-pd#UID</seealso>
    let ``dpv/dpv_pd#UID`` = Prefixed_Name(w3id, "dpv/dpv-pd#UID") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#UserAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#UserAgent">https://w3id.org/dpv/dpv-pd#UserAgent</seealso>
    let ``dpv/dpv_pd#UserAgent`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#UserAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Username</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Username">https://w3id.org/dpv/dpv-pd#Username</seealso>
    let ``dpv/dpv_pd#Username`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Username") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#VehicalLicenseNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#VehicalLicenseNumber">https://w3id.org/dpv/dpv-pd#VehicalLicenseNumber</seealso>
    let ``dpv/dpv_pd#VehicalLicenseNumber`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#VehicalLicenseNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#VehicalLicenseRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#VehicalLicenseRegistration">https://w3id.org/dpv/dpv-pd#VehicalLicenseRegistration</seealso>
    let ``dpv/dpv_pd#VehicalLicenseRegistration`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#VehicalLicenseRegistration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Vehicle">https://w3id.org/dpv/dpv-pd#Vehicle</seealso>
    let ``dpv/dpv_pd#Vehicle`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#Vehicle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#VehicleLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#VehicleLicense">https://w3id.org/dpv/dpv-pd#VehicleLicense</seealso>
    let ``dpv/dpv_pd#VehicleLicense`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#VehicleLicense") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#VehicleUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#VehicleUsage">https://w3id.org/dpv/dpv-pd#VehicleUsage</seealso>
    let ``dpv/dpv_pd#VehicleUsage`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#VehicleUsage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#VoiceCommunicationRecording</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#VoiceCommunicationRecording">https://w3id.org/dpv/dpv-pd#VoiceCommunicationRecording</seealso>
    let ``dpv/dpv_pd#VoiceCommunicationRecording`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#VoiceCommunicationRecording") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#VoiceMail</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#VoiceMail">https://w3id.org/dpv/dpv-pd#VoiceMail</seealso>
    let ``dpv/dpv_pd#VoiceMail`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#VoiceMail") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#Weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#Weight">https://w3id.org/dpv/dpv-pd#Weight</seealso>
    let ``dpv/dpv_pd#Weight`` = Prefixed_Name(w3id, "dpv/dpv-pd#Weight") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#WorkEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#WorkEnvironment">https://w3id.org/dpv/dpv-pd#WorkEnvironment</seealso>
    let ``dpv/dpv_pd#WorkEnvironment`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#WorkEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv-pd#WorkHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/dpv-pd#WorkHistory">https://w3id.org/dpv/dpv-pd#WorkHistory</seealso>
    let ``dpv/dpv_pd#WorkHistory`` =
        Prefixed_Name(w3id, "dpv/dpv-pd#WorkHistory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/dpv.html">https://w3id.org/dpv/dpv.html</seealso>
    let ``dpv/dpv.html`` = Prefixed_Name(w3id, "dpv/dpv.html") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv/dpv.jsonld</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/dpv/dpv.jsonld">https://w3id.org/dpv/dpv/dpv.jsonld</seealso>
    let ``dpv/dpv/dpv.jsonld`` =
        Prefixed_Name(w3id, "dpv/dpv/dpv.jsonld") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/dpv/dpv.n3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/dpv/dpv.n3">https://w3id.org/dpv/dpv/dpv.n3</seealso>
    let ``dpv/dpv/dpv.n3`` = Prefixed_Name(w3id, "dpv/dpv/dpv.n3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv/dpv/dpv.rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/dpv/dpv.rdf">https://w3id.org/dpv/dpv/dpv.rdf</seealso>
    let ``dpv/dpv/dpv.rdf`` = Prefixed_Name(w3id, "dpv/dpv/dpv.rdf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv/dpv/dpv.ttl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/dpv/dpv.ttl">https://w3id.org/dpv/dpv/dpv.ttl</seealso>
    let ``dpv/dpv/dpv.ttl`` = Prefixed_Name(w3id, "dpv/dpv/dpv.ttl") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dpv/examples</para>
    /// </summary>
    /// <remarks>
    ///   <para>prof:ResourceDescriptor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/examples">https://w3id.org/dpv/examples</seealso>
    let ``dpv/examples`` = Prefixed_Name(w3id, "dpv/examples") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0003</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0003">https://w3id.org/dpv/examples#E0003</seealso>
    let ``dpv/examples#E0003`` =
        Prefixed_Name(w3id, "dpv/examples#E0003") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0004</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0004">https://w3id.org/dpv/examples#E0004</seealso>
    let ``dpv/examples#E0004`` =
        Prefixed_Name(w3id, "dpv/examples#E0004") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0005</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0005">https://w3id.org/dpv/examples#E0005</seealso>
    let ``dpv/examples#E0005`` =
        Prefixed_Name(w3id, "dpv/examples#E0005") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0006</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0006">https://w3id.org/dpv/examples#E0006</seealso>
    let ``dpv/examples#E0006`` =
        Prefixed_Name(w3id, "dpv/examples#E0006") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0007</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0007">https://w3id.org/dpv/examples#E0007</seealso>
    let ``dpv/examples#E0007`` =
        Prefixed_Name(w3id, "dpv/examples#E0007") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0008</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0008">https://w3id.org/dpv/examples#E0008</seealso>
    let ``dpv/examples#E0008`` =
        Prefixed_Name(w3id, "dpv/examples#E0008") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0009</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0009">https://w3id.org/dpv/examples#E0009</seealso>
    let ``dpv/examples#E0009`` =
        Prefixed_Name(w3id, "dpv/examples#E0009") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0010</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0010">https://w3id.org/dpv/examples#E0010</seealso>
    let ``dpv/examples#E0010`` =
        Prefixed_Name(w3id, "dpv/examples#E0010") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0011</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0011">https://w3id.org/dpv/examples#E0011</seealso>
    let ``dpv/examples#E0011`` =
        Prefixed_Name(w3id, "dpv/examples#E0011") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0012</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0012">https://w3id.org/dpv/examples#E0012</seealso>
    let ``dpv/examples#E0012`` =
        Prefixed_Name(w3id, "dpv/examples#E0012") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0013</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0013">https://w3id.org/dpv/examples#E0013</seealso>
    let ``dpv/examples#E0013`` =
        Prefixed_Name(w3id, "dpv/examples#E0013") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0014</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0014">https://w3id.org/dpv/examples#E0014</seealso>
    let ``dpv/examples#E0014`` =
        Prefixed_Name(w3id, "dpv/examples#E0014") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0015</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0015">https://w3id.org/dpv/examples#E0015</seealso>
    let ``dpv/examples#E0015`` =
        Prefixed_Name(w3id, "dpv/examples#E0015") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0016</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0016">https://w3id.org/dpv/examples#E0016</seealso>
    let ``dpv/examples#E0016`` =
        Prefixed_Name(w3id, "dpv/examples#E0016") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0017</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0017">https://w3id.org/dpv/examples#E0017</seealso>
    let ``dpv/examples#E0017`` =
        Prefixed_Name(w3id, "dpv/examples#E0017") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0018</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0018">https://w3id.org/dpv/examples#E0018</seealso>
    let ``dpv/examples#E0018`` =
        Prefixed_Name(w3id, "dpv/examples#E0018") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0019</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0019">https://w3id.org/dpv/examples#E0019</seealso>
    let ``dpv/examples#E0019`` =
        Prefixed_Name(w3id, "dpv/examples#E0019") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0020</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0020">https://w3id.org/dpv/examples#E0020</seealso>
    let ``dpv/examples#E0020`` =
        Prefixed_Name(w3id, "dpv/examples#E0020") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0021</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0021">https://w3id.org/dpv/examples#E0021</seealso>
    let ``dpv/examples#E0021`` =
        Prefixed_Name(w3id, "dpv/examples#E0021") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0022</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0022">https://w3id.org/dpv/examples#E0022</seealso>
    let ``dpv/examples#E0022`` =
        Prefixed_Name(w3id, "dpv/examples#E0022") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0023</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0023">https://w3id.org/dpv/examples#E0023</seealso>
    let ``dpv/examples#E0023`` =
        Prefixed_Name(w3id, "dpv/examples#E0023") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0024</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0024">https://w3id.org/dpv/examples#E0024</seealso>
    let ``dpv/examples#E0024`` =
        Prefixed_Name(w3id, "dpv/examples#E0024") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0026</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0026">https://w3id.org/dpv/examples#E0026</seealso>
    let ``dpv/examples#E0026`` =
        Prefixed_Name(w3id, "dpv/examples#E0026") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0027</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0027">https://w3id.org/dpv/examples#E0027</seealso>
    let ``dpv/examples#E0027`` =
        Prefixed_Name(w3id, "dpv/examples#E0027") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0028</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0028">https://w3id.org/dpv/examples#E0028</seealso>
    let ``dpv/examples#E0028`` =
        Prefixed_Name(w3id, "dpv/examples#E0028") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0029</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0029">https://w3id.org/dpv/examples#E0029</seealso>
    let ``dpv/examples#E0029`` =
        Prefixed_Name(w3id, "dpv/examples#E0029") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0030</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0030">https://w3id.org/dpv/examples#E0030</seealso>
    let ``dpv/examples#E0030`` =
        Prefixed_Name(w3id, "dpv/examples#E0030") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0031</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0031">https://w3id.org/dpv/examples#E0031</seealso>
    let ``dpv/examples#E0031`` =
        Prefixed_Name(w3id, "dpv/examples#E0031") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0032</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0032">https://w3id.org/dpv/examples#E0032</seealso>
    let ``dpv/examples#E0032`` =
        Prefixed_Name(w3id, "dpv/examples#E0032") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0033</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0033">https://w3id.org/dpv/examples#E0033</seealso>
    let ``dpv/examples#E0033`` =
        Prefixed_Name(w3id, "dpv/examples#E0033") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0035</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0035">https://w3id.org/dpv/examples#E0035</seealso>
    let ``dpv/examples#E0035`` =
        Prefixed_Name(w3id, "dpv/examples#E0035") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0036</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0036">https://w3id.org/dpv/examples#E0036</seealso>
    let ``dpv/examples#E0036`` =
        Prefixed_Name(w3id, "dpv/examples#E0036") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0037</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0037">https://w3id.org/dpv/examples#E0037</seealso>
    let ``dpv/examples#E0037`` =
        Prefixed_Name(w3id, "dpv/examples#E0037") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0038</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0038">https://w3id.org/dpv/examples#E0038</seealso>
    let ``dpv/examples#E0038`` =
        Prefixed_Name(w3id, "dpv/examples#E0038") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0039</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0039">https://w3id.org/dpv/examples#E0039</seealso>
    let ``dpv/examples#E0039`` =
        Prefixed_Name(w3id, "dpv/examples#E0039") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0040</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0040">https://w3id.org/dpv/examples#E0040</seealso>
    let ``dpv/examples#E0040`` =
        Prefixed_Name(w3id, "dpv/examples#E0040") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0041</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0041">https://w3id.org/dpv/examples#E0041</seealso>
    let ``dpv/examples#E0041`` =
        Prefixed_Name(w3id, "dpv/examples#E0041") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0042</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0042">https://w3id.org/dpv/examples#E0042</seealso>
    let ``dpv/examples#E0042`` =
        Prefixed_Name(w3id, "dpv/examples#E0042") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0043</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0043">https://w3id.org/dpv/examples#E0043</seealso>
    let ``dpv/examples#E0043`` =
        Prefixed_Name(w3id, "dpv/examples#E0043") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0044</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0044">https://w3id.org/dpv/examples#E0044</seealso>
    let ``dpv/examples#E0044`` =
        Prefixed_Name(w3id, "dpv/examples#E0044") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0045</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0045">https://w3id.org/dpv/examples#E0045</seealso>
    let ``dpv/examples#E0045`` =
        Prefixed_Name(w3id, "dpv/examples#E0045") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0046</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0046">https://w3id.org/dpv/examples#E0046</seealso>
    let ``dpv/examples#E0046`` =
        Prefixed_Name(w3id, "dpv/examples#E0046") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0047</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0047">https://w3id.org/dpv/examples#E0047</seealso>
    let ``dpv/examples#E0047`` =
        Prefixed_Name(w3id, "dpv/examples#E0047") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0048</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0048">https://w3id.org/dpv/examples#E0048</seealso>
    let ``dpv/examples#E0048`` =
        Prefixed_Name(w3id, "dpv/examples#E0048") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0049</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0049">https://w3id.org/dpv/examples#E0049</seealso>
    let ``dpv/examples#E0049`` =
        Prefixed_Name(w3id, "dpv/examples#E0049") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0050</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0050">https://w3id.org/dpv/examples#E0050</seealso>
    let ``dpv/examples#E0050`` =
        Prefixed_Name(w3id, "dpv/examples#E0050") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0051</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0051">https://w3id.org/dpv/examples#E0051</seealso>
    let ``dpv/examples#E0051`` =
        Prefixed_Name(w3id, "dpv/examples#E0051") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0052</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0052">https://w3id.org/dpv/examples#E0052</seealso>
    let ``dpv/examples#E0052`` =
        Prefixed_Name(w3id, "dpv/examples#E0052") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0053</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0053">https://w3id.org/dpv/examples#E0053</seealso>
    let ``dpv/examples#E0053`` =
        Prefixed_Name(w3id, "dpv/examples#E0053") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0054</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0054">https://w3id.org/dpv/examples#E0054</seealso>
    let ``dpv/examples#E0054`` =
        Prefixed_Name(w3id, "dpv/examples#E0054") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0055</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0055">https://w3id.org/dpv/examples#E0055</seealso>
    let ``dpv/examples#E0055`` =
        Prefixed_Name(w3id, "dpv/examples#E0055") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0056</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0056">https://w3id.org/dpv/examples#E0056</seealso>
    let ``dpv/examples#E0056`` =
        Prefixed_Name(w3id, "dpv/examples#E0056") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0057</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0057">https://w3id.org/dpv/examples#E0057</seealso>
    let ``dpv/examples#E0057`` =
        Prefixed_Name(w3id, "dpv/examples#E0057") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0058</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0058">https://w3id.org/dpv/examples#E0058</seealso>
    let ``dpv/examples#E0058`` =
        Prefixed_Name(w3id, "dpv/examples#E0058") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0059</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0059">https://w3id.org/dpv/examples#E0059</seealso>
    let ``dpv/examples#E0059`` =
        Prefixed_Name(w3id, "dpv/examples#E0059") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0060</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0060">https://w3id.org/dpv/examples#E0060</seealso>
    let ``dpv/examples#E0060`` =
        Prefixed_Name(w3id, "dpv/examples#E0060") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0061</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0061">https://w3id.org/dpv/examples#E0061</seealso>
    let ``dpv/examples#E0061`` =
        Prefixed_Name(w3id, "dpv/examples#E0061") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0062</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0062">https://w3id.org/dpv/examples#E0062</seealso>
    let ``dpv/examples#E0062`` =
        Prefixed_Name(w3id, "dpv/examples#E0062") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0063</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0063">https://w3id.org/dpv/examples#E0063</seealso>
    let ``dpv/examples#E0063`` =
        Prefixed_Name(w3id, "dpv/examples#E0063") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0064</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0064">https://w3id.org/dpv/examples#E0064</seealso>
    let ``dpv/examples#E0064`` =
        Prefixed_Name(w3id, "dpv/examples#E0064") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0065</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0065">https://w3id.org/dpv/examples#E0065</seealso>
    let ``dpv/examples#E0065`` =
        Prefixed_Name(w3id, "dpv/examples#E0065") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0066</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0066">https://w3id.org/dpv/examples#E0066</seealso>
    let ``dpv/examples#E0066`` =
        Prefixed_Name(w3id, "dpv/examples#E0066") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0067</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0067">https://w3id.org/dpv/examples#E0067</seealso>
    let ``dpv/examples#E0067`` =
        Prefixed_Name(w3id, "dpv/examples#E0067") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0068</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0068">https://w3id.org/dpv/examples#E0068</seealso>
    let ``dpv/examples#E0068`` =
        Prefixed_Name(w3id, "dpv/examples#E0068") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0069</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0069">https://w3id.org/dpv/examples#E0069</seealso>
    let ``dpv/examples#E0069`` =
        Prefixed_Name(w3id, "dpv/examples#E0069") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0070</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0070">https://w3id.org/dpv/examples#E0070</seealso>
    let ``dpv/examples#E0070`` =
        Prefixed_Name(w3id, "dpv/examples#E0070") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0071</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0071">https://w3id.org/dpv/examples#E0071</seealso>
    let ``dpv/examples#E0071`` =
        Prefixed_Name(w3id, "dpv/examples#E0071") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0072</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0072">https://w3id.org/dpv/examples#E0072</seealso>
    let ``dpv/examples#E0072`` =
        Prefixed_Name(w3id, "dpv/examples#E0072") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0073</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0073">https://w3id.org/dpv/examples#E0073</seealso>
    let ``dpv/examples#E0073`` =
        Prefixed_Name(w3id, "dpv/examples#E0073") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0074</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0074">https://w3id.org/dpv/examples#E0074</seealso>
    let ``dpv/examples#E0074`` =
        Prefixed_Name(w3id, "dpv/examples#E0074") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0075</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0075">https://w3id.org/dpv/examples#E0075</seealso>
    let ``dpv/examples#E0075`` =
        Prefixed_Name(w3id, "dpv/examples#E0075") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0076</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0076">https://w3id.org/dpv/examples#E0076</seealso>
    let ``dpv/examples#E0076`` =
        Prefixed_Name(w3id, "dpv/examples#E0076") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0077</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0077">https://w3id.org/dpv/examples#E0077</seealso>
    let ``dpv/examples#E0077`` =
        Prefixed_Name(w3id, "dpv/examples#E0077") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0078</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0078">https://w3id.org/dpv/examples#E0078</seealso>
    let ``dpv/examples#E0078`` =
        Prefixed_Name(w3id, "dpv/examples#E0078") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0079</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0079">https://w3id.org/dpv/examples#E0079</seealso>
    let ``dpv/examples#E0079`` =
        Prefixed_Name(w3id, "dpv/examples#E0079") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0080</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0080">https://w3id.org/dpv/examples#E0080</seealso>
    let ``dpv/examples#E0080`` =
        Prefixed_Name(w3id, "dpv/examples#E0080") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0081</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0081">https://w3id.org/dpv/examples#E0081</seealso>
    let ``dpv/examples#E0081`` =
        Prefixed_Name(w3id, "dpv/examples#E0081") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0082</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0082">https://w3id.org/dpv/examples#E0082</seealso>
    let ``dpv/examples#E0082`` =
        Prefixed_Name(w3id, "dpv/examples#E0082") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0083</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0083">https://w3id.org/dpv/examples#E0083</seealso>
    let ``dpv/examples#E0083`` =
        Prefixed_Name(w3id, "dpv/examples#E0083") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0084</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0084">https://w3id.org/dpv/examples#E0084</seealso>
    let ``dpv/examples#E0084`` =
        Prefixed_Name(w3id, "dpv/examples#E0084") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0085</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0085">https://w3id.org/dpv/examples#E0085</seealso>
    let ``dpv/examples#E0085`` =
        Prefixed_Name(w3id, "dpv/examples#E0085") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/examples#E0088</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/examples#E0088">https://w3id.org/dpv/examples#E0088</seealso>
    let ``dpv/examples#E0088`` =
        Prefixed_Name(w3id, "dpv/examples#E0088") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/guides</para>
    /// </summary>
    /// <remarks>
    ///   <para>prof:ResourceDescriptor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/guides">https://w3id.org/dpv/guides</seealso>
    let ``dpv/guides`` = Prefixed_Name(w3id, "dpv/guides") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/media/logo.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv/media/logo.png">https://w3id.org/dpv/media/logo.png</seealso>
    let ``dpv/media/logo.png`` =
        Prefixed_Name(w3id, "dpv/media/logo.png") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dpv/primer</para>
    /// </summary>
    /// <remarks>
    ///   <para>prof:ResourceDescriptor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv/primer">https://w3id.org/dpv/primer</seealso>
    let ``dpv/primer`` = Prefixed_Name(w3id, "dpv/primer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsd</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:Ontology</para>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dsd">https://w3id.org/dsd</seealso>
    let dsd = Prefixed_Name(w3id, "dsd") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsd/4.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dsd/4.0.0">https://w3id.org/dsd/4.0.0</seealso>
    let ``dsd/4.0.0`` = Prefixed_Name(w3id, "dsd/4.0.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsd/LICENSE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dsd/LICENSE">https://w3id.org/dsd/LICENSE</seealso>
    let ``dsd/LICENSE`` = Prefixed_Name(w3id, "dsd/LICENSE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dsd/logo.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dsd/logo.png">https://w3id.org/dsd/logo.png</seealso>
    let ``dsd/logo.png`` = Prefixed_Name(w3id, "dsd/logo.png") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dt">https://w3id.org/dt</seealso>
    let dt = Prefixed_Name(w3id, "dt") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO">https://w3id.org/earthsemantics/OSO</seealso>
    let ``earthsemantics/OSO`` =
        Prefixed_Name(w3id, "earthsemantics/OSO") |> PrefixedName
