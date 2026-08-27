namespace https.w3id.org.tribont.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tribont =
    let _namespace_iri = Namespace_Iri tribont |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:tribont#Experiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A series of activities to carry out an experimentation procedure and measure its outputs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Experiment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#Experiment">https://w3id.org/tribont#Experiment</seealso>
    let Experiment = Prefixed_Name(tribont, "Experiment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#ExperimentalTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A testing activity that reproduces certain operation conditions to assess one or more technical attributes or characteristics of a given sample or sample system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExperimentalTest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#ExperimentalTest">https://w3id.org/tribont#ExperimentalTest</seealso>
    let ExperimentalTest = Prefixed_Name(tribont, "ExperimentalTest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#HardnessMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A testing activity to measure  one or more  hardness attributes or characteristics of  a given sample."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HardnessMeasurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#HardnessMeasurement">https://w3id.org/tribont#HardnessMeasurement</seealso>
    let HardnessMeasurement =
        Prefixed_Name(tribont, "HardnessMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#MeasuringTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A testing activity that measures one or more attributes or characteristics of a given sample."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasuringTest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#MeasuringTest">https://w3id.org/tribont#MeasuringTest</seealso>
    let MeasuringTest = Prefixed_Name(tribont, "MeasuringTest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Person performing an specific activity or operation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#Operator">https://w3id.org/tribont#Operator</seealso>
    let Operator = Prefixed_Name(tribont, "Operator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#Test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity intended to establish the techncial attributes or characteristics of something,"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Test"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#Test">https://w3id.org/tribont#Test</seealso>
    let Test = Prefixed_Name(tribont, "Test") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#TestOutputDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document compiling the outputs of a given test."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TestOutputDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TestOutputDocument">https://w3id.org/tribont#TestOutputDocument</seealso>
    let TestOutputDocument =
        Prefixed_Name(tribont, "TestOutputDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#TestOutputMeasurementFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Document including the output measures (i.e., technical properties) from a  test."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TestOutputMeasurementFile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TestOutputMeasurementFile">https://w3id.org/tribont#TestOutputMeasurementFile</seealso>
    let TestOutputMeasurementFile =
        Prefixed_Name(tribont, "TestOutputMeasurementFile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#TestOutputReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Document report ing the results of a test.  technical properties) from a  test."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TestOutputReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TestOutputReport">https://w3id.org/tribont#TestOutputReport</seealso>
    let TestOutputReport = Prefixed_Name(tribont, "TestOutputReport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#TestStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document approved by a recognized bodythat provides common to by fullfiled by a test."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TestStandard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TestStandard">https://w3id.org/tribont#TestStandard</seealso>
    let TestStandard = Prefixed_Name(tribont, "TestStandard") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#TestStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Each of the steps into which a given test can be subdivided"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TestStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TestStep">https://w3id.org/tribont#TestStep</seealso>
    let TestStep = Prefixed_Name(tribont, "TestStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#TribologicalTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A testing activity that reproduces certain operation conditions to assess one or more tribological attributes or characteristics of a given sample system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TribologicalTest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TribologicalTest">https://w3id.org/tribont#TribologicalTest</seealso>
    let TribologicalTest = Prefixed_Name(tribont, "TribologicalTest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#WearScarMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A testing activity to measure  one or more attributes or characteristics of the resulting scar in a given sample."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WearScarMeasurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#WearScarMeasurement">https://w3id.org/tribont#WearScarMeasurement</seealso>
    let WearScarMeasurement =
        Prefixed_Name(tribont, "WearScarMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#WeightMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A testing activity to measure the weight of a given sample."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WeightMeasurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#WeightMeasurement">https://w3id.org/tribont#WeightMeasurement</seealso>
    let WeightMeasurement = Prefixed_Name(tribont, "WeightMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#executes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an equipment and the activity it carries out."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"executes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#executes">https://w3id.org/tribont#executes</seealso>
    let executes = Prefixed_Name(tribont, "executes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#hasAfterEndDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between an activity and the one preceeding it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasAfterEndDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#hasAfterEndDependency">https://w3id.org/tribont#hasAfterEndDependency</seealso>
    let hasAfterEndDependency =
        Prefixed_Name(tribont, "hasAfterEndDependency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#hasDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the dependency between two activities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#hasDependency">https://w3id.org/tribont#hasDependency</seealso>
    let hasDependency = Prefixed_Name(tribont, "hasDependency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#hasNofollowDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an activity has not a following dependency."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasNofollowDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#hasNofollowDependency">https://w3id.org/tribont#hasNofollowDependency</seealso>
    let hasNofollowDependency =
        Prefixed_Name(tribont, "hasNofollowDependency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont#isExecutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an activity and the equipment that executes it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isExecutedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#isExecutedBy">https://w3id.org/tribont#isExecutedBy</seealso>
    let isExecutedBy = Prefixed_Name(tribont, "isExecutedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#isNext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an activity and the one preceding it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isNext"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#isNext">https://w3id.org/tribont#isNext</seealso>
    let isNext = Prefixed_Name(tribont, "isNext") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#isPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an activity and the person who performs it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isPerformedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#isPerformedBy">https://w3id.org/tribont#isPerformedBy</seealso>
    let isPerformedBy = Prefixed_Name(tribont, "isPerformedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#isPrevious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an activity and the one following it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isPrevious"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#isPrevious">https://w3id.org/tribont#isPrevious</seealso>
    let isPrevious = Prefixed_Name(tribont, "isPrevious") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#isTestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a sample body or sample system and the testing activity testing it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isTestedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#isTestedBy">https://w3id.org/tribont#isTestedBy</seealso>
    let isTestedBy = Prefixed_Name(tribont, "isTestedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#performs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a person and the activity he/she performs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"performs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#performs">https://w3id.org/tribont#performs</seealso>
    let performs = Prefixed_Name(tribont, "performs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont#tests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a testing activity and what it tests (i.e., sample,  sample system)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont#tests">https://w3id.org/tribont#tests</seealso>
    let tests = Prefixed_Name(tribont, "tests") |> PrefixedName
