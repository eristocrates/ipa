namespace https.w3id.org.tribont.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tribont =
    let _namespace_iri = Namespace_Iri tribont |> NamespaceIRI

    /// <summary>
    ///   <para>tribont:TestOutputDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document compiling the outputs of a given test.</para>
    /// labels<para>TestOutputDocument</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TestOutputDocument">https://w3id.org/tribont#TestOutputDocument</seealso>
    let TestOutputDocument =
        Prefixed_Name(tribont, "TestOutputDocument") |> PrefixedName

    /// <summary>
    ///   <para>tribont:Experiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A series of activities to carry out an experimentation procedure and measure its outputs.</para>
    /// labels<para>Experiment</para></remarks>
    /// <seealso href="https://w3id.org/tribont#Experiment">https://w3id.org/tribont#Experiment</seealso>
    let Experiment = Prefixed_Name(tribont, "Experiment") |> PrefixedName
    /// <summary>
    ///   <para>tribont:TestStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Each of the steps into which a given test can be subdivided</para>
    /// labels<para>TestStep</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TestStep">https://w3id.org/tribont#TestStep</seealso>
    let TestStep = Prefixed_Name(tribont, "TestStep") |> PrefixedName

    /// <summary>
    ///   <para>tribont:hasNofollowDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an activity has not a following dependency.</para>
    /// labels<para>hasNofollowDependency</para></remarks>
    /// <seealso href="https://w3id.org/tribont#hasNofollowDependency">https://w3id.org/tribont#hasNofollowDependency</seealso>
    let hasNofollowDependency =
        Prefixed_Name(tribont, "hasNofollowDependency") |> PrefixedName

    /// <summary>
    ///   <para>tribont:isTestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a sample body or sample system and the testing activity testing it.</para>
    /// labels<para>isTestedBy</para></remarks>
    /// <seealso href="https://w3id.org/tribont#isTestedBy">https://w3id.org/tribont#isTestedBy</seealso>
    let isTestedBy = Prefixed_Name(tribont, "isTestedBy") |> PrefixedName
    /// <summary>
    ///   <para>tribont:Test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An activity intended to establish the techncial attributes or characteristics of something,</para>
    /// labels<para>Test</para></remarks>
    /// <seealso href="https://w3id.org/tribont#Test">https://w3id.org/tribont#Test</seealso>
    let Test = Prefixed_Name(tribont, "Test") |> PrefixedName
    /// <summary>
    ///   <para>tribont:executes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an equipment and the activity it carries out.</para>
    /// labels<para>executes</para></remarks>
    /// <seealso href="https://w3id.org/tribont#executes">https://w3id.org/tribont#executes</seealso>
    let executes = Prefixed_Name(tribont, "executes") |> PrefixedName

    /// <summary>
    ///   <para>tribont:hasAfterEndDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an activity and the one preceeding it.</para>
    /// labels<para>hasAfterEndDependency</para></remarks>
    /// <seealso href="https://w3id.org/tribont#hasAfterEndDependency">https://w3id.org/tribont#hasAfterEndDependency</seealso>
    let hasAfterEndDependency =
        Prefixed_Name(tribont, "hasAfterEndDependency") |> PrefixedName

    /// <summary>
    ///   <para>tribont:isNext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an activity and the one preceding it.</para>
    /// labels<para>isNext</para></remarks>
    /// <seealso href="https://w3id.org/tribont#isNext">https://w3id.org/tribont#isNext</seealso>
    let isNext = Prefixed_Name(tribont, "isNext") |> PrefixedName
    /// <summary>
    ///   <para>tribont:isPrevious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an activity and the one following it.</para>
    /// labels<para>isPrevious</para></remarks>
    /// <seealso href="https://w3id.org/tribont#isPrevious">https://w3id.org/tribont#isPrevious</seealso>
    let isPrevious = Prefixed_Name(tribont, "isPrevious") |> PrefixedName
    /// <summary>
    ///   <para>tribont:performs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a person and the activity he/she performs.</para>
    /// labels<para>performs</para></remarks>
    /// <seealso href="https://w3id.org/tribont#performs">https://w3id.org/tribont#performs</seealso>
    let performs = Prefixed_Name(tribont, "performs") |> PrefixedName
    /// <summary>
    ///   <para>tribont:ExperimentalTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A testing activity that reproduces certain operation conditions to assess one or more technical attributes or characteristics of a given sample or sample system.</para>
    /// labels<para>ExperimentalTest</para></remarks>
    /// <seealso href="https://w3id.org/tribont#ExperimentalTest">https://w3id.org/tribont#ExperimentalTest</seealso>
    let ExperimentalTest = Prefixed_Name(tribont, "ExperimentalTest") |> PrefixedName

    /// <summary>
    ///   <para>tribont:HardnessMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A testing activity to measure  one or more  hardness attributes or characteristics of  a given sample.</para>
    /// labels<para>HardnessMeasurement</para></remarks>
    /// <seealso href="https://w3id.org/tribont#HardnessMeasurement">https://w3id.org/tribont#HardnessMeasurement</seealso>
    let HardnessMeasurement =
        Prefixed_Name(tribont, "HardnessMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>tribont:MeasuringTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A testing activity that measures one or more attributes or characteristics of a given sample.</para>
    /// labels<para>MeasuringTest</para></remarks>
    /// <seealso href="https://w3id.org/tribont#MeasuringTest">https://w3id.org/tribont#MeasuringTest</seealso>
    let MeasuringTest = Prefixed_Name(tribont, "MeasuringTest") |> PrefixedName
    /// <summary>
    ///   <para>tribont:tests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a testing activity and what it tests (i.e., sample,  sample system).</para>
    /// labels<para>tests</para></remarks>
    /// <seealso href="https://w3id.org/tribont#tests">https://w3id.org/tribont#tests</seealso>
    let tests = Prefixed_Name(tribont, "tests") |> PrefixedName
    /// <summary>
    ///   <para>tribont:isExecutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an activity and the equipment that executes it.</para>
    /// labels<para>isExecutedBy</para></remarks>
    /// <seealso href="https://w3id.org/tribont#isExecutedBy">https://w3id.org/tribont#isExecutedBy</seealso>
    let isExecutedBy = Prefixed_Name(tribont, "isExecutedBy") |> PrefixedName
    /// <summary>
    ///   <para>tribont:isPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an activity and the person who performs it.</para>
    /// labels<para>isPerformedBy</para></remarks>
    /// <seealso href="https://w3id.org/tribont#isPerformedBy">https://w3id.org/tribont#isPerformedBy</seealso>
    let isPerformedBy = Prefixed_Name(tribont, "isPerformedBy") |> PrefixedName
    /// <summary>
    ///   <para>tribont:hasDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies the dependency between two activities.</para>
    /// labels<para>hasDependency</para></remarks>
    /// <seealso href="https://w3id.org/tribont#hasDependency">https://w3id.org/tribont#hasDependency</seealso>
    let hasDependency = Prefixed_Name(tribont, "hasDependency") |> PrefixedName

    /// <summary>
    ///   <para>tribont:TestOutputMeasurementFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Document including the output measures (i.e., technical properties) from a  test.</para>
    /// labels<para>TestOutputMeasurementFile</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TestOutputMeasurementFile">https://w3id.org/tribont#TestOutputMeasurementFile</seealso>
    let TestOutputMeasurementFile =
        Prefixed_Name(tribont, "TestOutputMeasurementFile") |> PrefixedName

    /// <summary>
    ///   <para>tribont:TestOutputReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Document report ing the results of a test.  technical properties) from a  test.</para>
    /// labels<para>TestOutputReport</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TestOutputReport">https://w3id.org/tribont#TestOutputReport</seealso>
    let TestOutputReport = Prefixed_Name(tribont, "TestOutputReport") |> PrefixedName
    /// <summary>
    ///   <para>tribont:TestStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document approved by a recognized bodythat provides common to by fullfiled by a test.</para>
    /// labels<para>TestStandard</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TestStandard">https://w3id.org/tribont#TestStandard</seealso>
    let TestStandard = Prefixed_Name(tribont, "TestStandard") |> PrefixedName
    /// <summary>
    ///   <para>tribont:TribologicalTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A testing activity that reproduces certain operation conditions to assess one or more tribological attributes or characteristics of a given sample system.</para>
    /// labels<para>TribologicalTest</para></remarks>
    /// <seealso href="https://w3id.org/tribont#TribologicalTest">https://w3id.org/tribont#TribologicalTest</seealso>
    let TribologicalTest = Prefixed_Name(tribont, "TribologicalTest") |> PrefixedName

    /// <summary>
    ///   <para>tribont:WearScarMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A testing activity to measure  one or more attributes or characteristics of the resulting scar in a given sample.</para>
    /// labels<para>WearScarMeasurement</para></remarks>
    /// <seealso href="https://w3id.org/tribont#WearScarMeasurement">https://w3id.org/tribont#WearScarMeasurement</seealso>
    let WearScarMeasurement =
        Prefixed_Name(tribont, "WearScarMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>tribont:WeightMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A testing activity to measure the weight of a given sample.</para>
    /// labels<para>WeightMeasurement</para></remarks>
    /// <seealso href="https://w3id.org/tribont#WeightMeasurement">https://w3id.org/tribont#WeightMeasurement</seealso>
    let WeightMeasurement = Prefixed_Name(tribont, "WeightMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>tribont:Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Person performing an specific activity or operation.</para>
    /// labels<para>Operator</para></remarks>
    /// <seealso href="https://w3id.org/tribont#Operator">https://w3id.org/tribont#Operator</seealso>
    let Operator = Prefixed_Name(tribont, "Operator") |> PrefixedName
