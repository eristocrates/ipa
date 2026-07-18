namespace http.open_services.net.ns.qm.hash

open DoxAletheia.Rdf_Vocabulary

module qm =
    let _namespace_name = "http://open-services.net/ns/qm#"
    /// <summary>
    /// The QM Test Case resource.
    /// <see href="http://open-services.net/ns/qm#TestCase"></see></summary>
    let TestCase = Namespaced_IRI.parse _namespace_name "TestCase" |> NamespacedName

    /// <summary>
    /// The QM Test Execution Record resource.
    /// <see href="http://open-services.net/ns/qm#TestExecutionRecord"></see></summary>
    let TestExecutionRecord =
        Namespaced_IRI.parse _namespace_name "TestExecutionRecord" |> NamespacedName

    /// <summary>
    /// The QM Test Plan resource.
    /// <see href="http://open-services.net/ns/qm#TestPlan"></see></summary>
    let TestPlan = Namespaced_IRI.parse _namespace_name "TestPlan" |> NamespacedName
    /// <summary>
    /// The QM Test Result resource.
    /// <see href="http://open-services.net/ns/qm#TestResult"></see></summary>
    let TestResult = Namespaced_IRI.parse _namespace_name "TestResult" |> NamespacedName
    /// <summary>
    /// The QM Test Script resource.
    /// <see href="http://open-services.net/ns/qm#TestScript"></see></summary>
    let TestScript = Namespaced_IRI.parse _namespace_name "TestScript" |> NamespacedName

    /// <summary>
    /// Change request that affects the Test Result. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#affectedByChangeRequest"></see></summary>
    let affectedByChangeRequest =
        Namespaced_IRI.parse _namespace_name "affectedByChangeRequest" |> NamespacedName

    /// <summary>
    /// Change Request that prevents execution of the Test Execution Record. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#blockedByChangeRequest"></see></summary>
    let blockedByChangeRequest =
        Namespaced_IRI.parse _namespace_name "blockedByChangeRequest" |> NamespacedName

    /// <summary>
    /// Test Script executed to produce the Test Result. It is likely that the target resource will be an oslc_qm:TestScript but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#executesTestScript"></see></summary>
    let executesTestScript =
        Namespaced_IRI.parse _namespace_name "executesTestScript" |> NamespacedName

    /// <summary>
    /// Instructions for executing the test script. Note that the value of Occurs is undefined. The resource shape document provided by the QM service provider may be consulted for its value.
    /// <see href="http://open-services.net/ns/qm#executionInstructions"></see></summary>
    let executionInstructions =
        Namespaced_IRI.parse _namespace_name "executionInstructions" |> NamespacedName

    /// <summary>
    /// Test Execution Record that the Test Result was produced by. It is likely that the target resource will be an oslc_qm:TestExecutionRecord but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#producedByTestExecutionRecord"></see></summary>
    let producedByTestExecutionRecord =
        Namespaced_IRI.parse _namespace_name "producedByTestExecutionRecord" |> NamespacedName

    /// <summary>
    /// A related change request. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#relatedChangeRequest"></see></summary>
    let relatedChangeRequest =
        Namespaced_IRI.parse _namespace_name "relatedChangeRequest" |> NamespacedName

    /// <summary>
    /// Test Case that the Test Result reports on. It is likely that the target resource will be an oslc_qm:TestCase but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#reportsOnTestCase"></see></summary>
    let reportsOnTestCase =
        Namespaced_IRI.parse _namespace_name "reportsOnTestCase" |> NamespacedName

    /// <summary>
    /// Test Plan that a test or execution record reports on. It is likely that the target resource will be an oslc_qm:TestPlan but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#reportsOnTestPlan"></see></summary>
    let reportsOnTestPlan =
        Namespaced_IRI.parse _namespace_name "reportsOnTestPlan" |> NamespacedName

    /// <summary>
    /// Indicates the environment details of the test case for this execution record.
    /// <see href="http://open-services.net/ns/qm#runsOnTestEnvironment"></see></summary>
    let runsOnTestEnvironment =
        Namespaced_IRI.parse _namespace_name "runsOnTestEnvironment" |> NamespacedName

    /// <summary>
    /// Test Case run by the Test Execution Record. It is likely that the target resource will be an oslc_qm:TestCase but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#runsTestCase"></see></summary>
    let runsTestCase =
        Namespaced_IRI.parse _namespace_name "runsTestCase" |> NamespacedName

    /// <summary>
    /// Used to indicate the state of the Test Result based on values defined by the service provider.
    /// <see href="http://open-services.net/ns/qm#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    /// Change Request tested by the Test Case. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#testsChangeRequest"></see></summary>
    let testsChangeRequest =
        Namespaced_IRI.parse _namespace_name "testsChangeRequest" |> NamespacedName

    /// <summary>
    /// Test Case used by the Test Plan. It is likely that the target resource will be an oslc_qm:TestCase but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#usesTestCase"></see></summary>
    let usesTestCase =
        Namespaced_IRI.parse _namespace_name "usesTestCase" |> NamespacedName

    /// <summary>
    /// Test Script used by the Test Case. It is likely that the target resource will be an oslc_qm:TestScript but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#usesTestScript"></see></summary>
    let usesTestScript =
        Namespaced_IRI.parse _namespace_name "usesTestScript" |> NamespacedName

    /// <summary>
    /// Requirement that is validated by the Test Case. It is likely that the target resource will be an oslc_rm:Requirement but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#validatesRequirement"></see></summary>
    let validatesRequirement =
        Namespaced_IRI.parse _namespace_name "validatesRequirement" |> NamespacedName

    /// <summary>
    /// Requirement Collection that is validated by the Test Plan. It is likely that the target resource will be an oslc_rm:RequirementCollection but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#validatesRequirementCollection"></see></summary>
    let validatesRequirementCollection =
        Namespaced_IRI.parse _namespace_name "validatesRequirementCollection" |> NamespacedName
