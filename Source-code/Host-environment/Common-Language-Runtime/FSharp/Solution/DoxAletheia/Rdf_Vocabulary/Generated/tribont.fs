namespace https.w3id.org.tribont.hash

open DoxAletheia.Rdf_Vocabulary

module tribont =
    let _namespace_name = "https://w3id.org/tribont#"
    /// <summary>
    /// Person performing an specific activity or operation.
    /// <see href="https://w3id.org/tribont#Operator"></see></summary>
    let Operator = Namespaced_IRI.parse _namespace_name "Operator" |> NamespacedName
    /// <summary>
    /// A series of activities to carry out an experimentation procedure and measure its outputs.
    /// <see href="https://w3id.org/tribont#Experiment"></see></summary>
    let Experiment = Namespaced_IRI.parse _namespace_name "Experiment" |> NamespacedName
    /// <summary>
    /// An activity intended to establish the techncial attributes or characteristics of something,
    /// <see href="https://w3id.org/tribont#Test"></see></summary>
    let Test = Namespaced_IRI.parse _namespace_name "Test" |> NamespacedName
    /// <summary>
    /// Each of the steps into which a given test can be subdivided
    /// <see href="https://w3id.org/tribont#TestStep"></see></summary>
    let TestStep = Namespaced_IRI.parse _namespace_name "TestStep" |> NamespacedName

    /// <summary>
    /// A document compiling the outputs of a given test.
    /// <see href="https://w3id.org/tribont#TestOutputDocument"></see></summary>
    let TestOutputDocument =
        Namespaced_IRI.parse _namespace_name "TestOutputDocument" |> NamespacedName

    /// <summary>
    /// A testing activity that reproduces certain operation conditions to assess one or more technical attributes or characteristics of a given sample or sample system.
    /// <see href="https://w3id.org/tribont#ExperimentalTest"></see></summary>
    let ExperimentalTest =
        Namespaced_IRI.parse _namespace_name "ExperimentalTest" |> NamespacedName

    /// <summary>
    /// Relationship between an activity and the equipment that executes it.
    /// <see href="https://w3id.org/tribont#isExecutedBy"></see></summary>
    let isExecutedBy =
        Namespaced_IRI.parse _namespace_name "isExecutedBy" |> NamespacedName

    /// <summary>
    /// A testing activity to measure  one or more  hardness attributes or characteristics of  a given sample.
    /// <see href="https://w3id.org/tribont#HardnessMeasurement"></see></summary>
    let HardnessMeasurement =
        Namespaced_IRI.parse _namespace_name "HardnessMeasurement" |> NamespacedName

    /// <summary>
    /// A testing activity that measures one or more attributes or characteristics of a given sample.
    /// <see href="https://w3id.org/tribont#MeasuringTest"></see></summary>
    let MeasuringTest =
        Namespaced_IRI.parse _namespace_name "MeasuringTest" |> NamespacedName

    /// <summary>
    /// Relationship between a testing activity and what it tests (i.e., sample,  sample system).
    /// <see href="https://w3id.org/tribont#tests"></see></summary>
    let tests = Namespaced_IRI.parse _namespace_name "tests" |> NamespacedName

    /// <summary>
    /// Relationship between an activity and the person who performs it.
    /// <see href="https://w3id.org/tribont#isPerformedBy"></see></summary>
    let isPerformedBy =
        Namespaced_IRI.parse _namespace_name "isPerformedBy" |> NamespacedName

    /// <summary>
    /// Identifies the dependency between two activities.
    /// <see href="https://w3id.org/tribont#hasDependency"></see></summary>
    let hasDependency =
        Namespaced_IRI.parse _namespace_name "hasDependency" |> NamespacedName

    /// <summary>
    /// Document including the output measures (i.e., technical properties) from a  test.
    /// <see href="https://w3id.org/tribont#TestOutputMeasurementFile"></see></summary>
    let TestOutputMeasurementFile =
        Namespaced_IRI.parse _namespace_name "TestOutputMeasurementFile" |> NamespacedName

    /// <summary>
    /// Document report ing the results of a test.  technical properties) from a  test.
    /// <see href="https://w3id.org/tribont#TestOutputReport"></see></summary>
    let TestOutputReport =
        Namespaced_IRI.parse _namespace_name "TestOutputReport" |> NamespacedName

    /// <summary>
    /// A document approved by a recognized bodythat provides common to by fullfiled by a test.
    /// <see href="https://w3id.org/tribont#TestStandard"></see></summary>
    let TestStandard =
        Namespaced_IRI.parse _namespace_name "TestStandard" |> NamespacedName

    /// <summary>
    /// A testing activity that reproduces certain operation conditions to assess one or more tribological attributes or characteristics of a given sample system.
    /// <see href="https://w3id.org/tribont#TribologicalTest"></see></summary>
    let TribologicalTest =
        Namespaced_IRI.parse _namespace_name "TribologicalTest" |> NamespacedName

    /// <summary>
    /// A testing activity to measure  one or more attributes or characteristics of the resulting scar in a given sample.
    /// <see href="https://w3id.org/tribont#WearScarMeasurement"></see></summary>
    let WearScarMeasurement =
        Namespaced_IRI.parse _namespace_name "WearScarMeasurement" |> NamespacedName

    /// <summary>
    /// A testing activity to measure the weight of a given sample.
    /// <see href="https://w3id.org/tribont#WeightMeasurement"></see></summary>
    let WeightMeasurement =
        Namespaced_IRI.parse _namespace_name "WeightMeasurement" |> NamespacedName

    /// <summary>
    /// Relationship between an equipment and the activity it carries out.
    /// <see href="https://w3id.org/tribont#executes"></see></summary>
    let executes = Namespaced_IRI.parse _namespace_name "executes" |> NamespacedName

    /// <summary>
    /// Relation between an activity and the one preceeding it.
    /// <see href="https://w3id.org/tribont#hasAfterEndDependency"></see></summary>
    let hasAfterEndDependency =
        Namespaced_IRI.parse _namespace_name "hasAfterEndDependency" |> NamespacedName

    /// <summary>
    /// Relationship between an activity and the one preceding it.
    /// <see href="https://w3id.org/tribont#isNext"></see></summary>
    let isNext = Namespaced_IRI.parse _namespace_name "isNext" |> NamespacedName

    /// <summary>
    /// Indicates that an activity has not a following dependency.
    /// <see href="https://w3id.org/tribont#hasNofollowDependency"></see></summary>
    let hasNofollowDependency =
        Namespaced_IRI.parse _namespace_name "hasNofollowDependency" |> NamespacedName

    /// <summary>
    /// Relationship between an activity and the one following it.
    /// <see href="https://w3id.org/tribont#isPrevious"></see></summary>
    let isPrevious = Namespaced_IRI.parse _namespace_name "isPrevious" |> NamespacedName
    /// <summary>
    /// Relationship between a person and the activity he/she performs.
    /// <see href="https://w3id.org/tribont#performs"></see></summary>
    let performs = Namespaced_IRI.parse _namespace_name "performs" |> NamespacedName
    /// <summary>
    /// Relationship between a sample body or sample system and the testing activity testing it.
    /// <see href="https://w3id.org/tribont#isTestedBy"></see></summary>
    let isTestedBy = Namespaced_IRI.parse _namespace_name "isTestedBy" |> NamespacedName
