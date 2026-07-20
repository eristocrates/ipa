namespace https.w3id.org.tribont.hash

open DoxAletheia

module tribont =
    let _namespace_name = "https://w3id.org/tribont#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Person performing an specific activity or operation.
    /// <see href="https://w3id.org/tribont#Operator"></see></summary>
    let Operator = _prefix "Operator"
    /// <summary>
    /// A series of activities to carry out an experimentation procedure and measure its outputs.
    /// <see href="https://w3id.org/tribont#Experiment"></see></summary>
    let Experiment = _prefix "Experiment"
    /// <summary>
    /// An activity intended to establish the techncial attributes or characteristics of something,
    /// <see href="https://w3id.org/tribont#Test"></see></summary>
    let Test = _prefix "Test"
    /// <summary>
    /// Each of the steps into which a given test can be subdivided
    /// <see href="https://w3id.org/tribont#TestStep"></see></summary>
    let TestStep = _prefix "TestStep"
    /// <summary>
    /// A document compiling the outputs of a given test.
    /// <see href="https://w3id.org/tribont#TestOutputDocument"></see></summary>
    let TestOutputDocument = _prefix "TestOutputDocument"
    /// <summary>
    /// A testing activity that reproduces certain operation conditions to assess one or more technical attributes or characteristics of a given sample or sample system.
    /// <see href="https://w3id.org/tribont#ExperimentalTest"></see></summary>
    let ExperimentalTest = _prefix "ExperimentalTest"
    /// <summary>
    /// Relationship between an activity and the equipment that executes it.
    /// <see href="https://w3id.org/tribont#isExecutedBy"></see></summary>
    let isExecutedBy = _prefix "isExecutedBy"
    /// <summary>
    /// A testing activity to measure  one or more  hardness attributes or characteristics of  a given sample.
    /// <see href="https://w3id.org/tribont#HardnessMeasurement"></see></summary>
    let HardnessMeasurement = _prefix "HardnessMeasurement"
    /// <summary>
    /// A testing activity that measures one or more attributes or characteristics of a given sample.
    /// <see href="https://w3id.org/tribont#MeasuringTest"></see></summary>
    let MeasuringTest = _prefix "MeasuringTest"
    /// <summary>
    /// Relationship between a testing activity and what it tests (i.e., sample,  sample system).
    /// <see href="https://w3id.org/tribont#tests"></see></summary>
    let tests = _prefix "tests"
    /// <summary>
    /// Relationship between an activity and the person who performs it.
    /// <see href="https://w3id.org/tribont#isPerformedBy"></see></summary>
    let isPerformedBy = _prefix "isPerformedBy"
    /// <summary>
    /// Identifies the dependency between two activities.
    /// <see href="https://w3id.org/tribont#hasDependency"></see></summary>
    let hasDependency = _prefix "hasDependency"
    /// <summary>
    /// Document including the output measures (i.e., technical properties) from a  test.
    /// <see href="https://w3id.org/tribont#TestOutputMeasurementFile"></see></summary>
    let TestOutputMeasurementFile = _prefix "TestOutputMeasurementFile"
    /// <summary>
    /// Document report ing the results of a test.  technical properties) from a  test.
    /// <see href="https://w3id.org/tribont#TestOutputReport"></see></summary>
    let TestOutputReport = _prefix "TestOutputReport"
    /// <summary>
    /// A document approved by a recognized bodythat provides common to by fullfiled by a test.
    /// <see href="https://w3id.org/tribont#TestStandard"></see></summary>
    let TestStandard = _prefix "TestStandard"
    /// <summary>
    /// A testing activity that reproduces certain operation conditions to assess one or more tribological attributes or characteristics of a given sample system.
    /// <see href="https://w3id.org/tribont#TribologicalTest"></see></summary>
    let TribologicalTest = _prefix "TribologicalTest"
    /// <summary>
    /// A testing activity to measure  one or more attributes or characteristics of the resulting scar in a given sample.
    /// <see href="https://w3id.org/tribont#WearScarMeasurement"></see></summary>
    let WearScarMeasurement = _prefix "WearScarMeasurement"
    /// <summary>
    /// A testing activity to measure the weight of a given sample.
    /// <see href="https://w3id.org/tribont#WeightMeasurement"></see></summary>
    let WeightMeasurement = _prefix "WeightMeasurement"
    /// <summary>
    /// Relationship between an equipment and the activity it carries out.
    /// <see href="https://w3id.org/tribont#executes"></see></summary>
    let executes = _prefix "executes"
    /// <summary>
    /// Relation between an activity and the one preceeding it.
    /// <see href="https://w3id.org/tribont#hasAfterEndDependency"></see></summary>
    let hasAfterEndDependency = _prefix "hasAfterEndDependency"
    /// <summary>
    /// Relationship between an activity and the one preceding it.
    /// <see href="https://w3id.org/tribont#isNext"></see></summary>
    let isNext = _prefix "isNext"
    /// <summary>
    /// Indicates that an activity has not a following dependency.
    /// <see href="https://w3id.org/tribont#hasNofollowDependency"></see></summary>
    let hasNofollowDependency = _prefix "hasNofollowDependency"
    /// <summary>
    /// Relationship between an activity and the one following it.
    /// <see href="https://w3id.org/tribont#isPrevious"></see></summary>
    let isPrevious = _prefix "isPrevious"
    /// <summary>
    /// Relationship between a person and the activity he/she performs.
    /// <see href="https://w3id.org/tribont#performs"></see></summary>
    let performs = _prefix "performs"
    /// <summary>
    /// Relationship between a sample body or sample system and the testing activity testing it.
    /// <see href="https://w3id.org/tribont#isTestedBy"></see></summary>
    let isTestedBy = _prefix "isTestedBy"
