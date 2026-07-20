namespace http.open_services.net.ns.qm.hash

open DoxAletheia

module qm =
    let _namespace_name = "http://open-services.net/ns/qm#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The QM Test Case resource.
    /// <see href="http://open-services.net/ns/qm#TestCase"></see></summary>
    let TestCase = _prefix "TestCase"
    /// <summary>
    /// The QM Test Execution Record resource.
    /// <see href="http://open-services.net/ns/qm#TestExecutionRecord"></see></summary>
    let TestExecutionRecord = _prefix "TestExecutionRecord"
    /// <summary>
    /// The QM Test Plan resource.
    /// <see href="http://open-services.net/ns/qm#TestPlan"></see></summary>
    let TestPlan = _prefix "TestPlan"
    /// <summary>
    /// The QM Test Result resource.
    /// <see href="http://open-services.net/ns/qm#TestResult"></see></summary>
    let TestResult = _prefix "TestResult"
    /// <summary>
    /// The QM Test Script resource.
    /// <see href="http://open-services.net/ns/qm#TestScript"></see></summary>
    let TestScript = _prefix "TestScript"
    /// <summary>
    /// Change request that affects the Test Result. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#affectedByChangeRequest"></see></summary>
    let affectedByChangeRequest = _prefix "affectedByChangeRequest"
    /// <summary>
    /// Change Request that prevents execution of the Test Execution Record. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#blockedByChangeRequest"></see></summary>
    let blockedByChangeRequest = _prefix "blockedByChangeRequest"
    /// <summary>
    /// Test Script executed to produce the Test Result. It is likely that the target resource will be an oslc_qm:TestScript but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#executesTestScript"></see></summary>
    let executesTestScript = _prefix "executesTestScript"
    /// <summary>
    /// Instructions for executing the test script. Note that the value of Occurs is undefined. The resource shape document provided by the QM service provider may be consulted for its value.
    /// <see href="http://open-services.net/ns/qm#executionInstructions"></see></summary>
    let executionInstructions = _prefix "executionInstructions"
    /// <summary>
    /// Test Execution Record that the Test Result was produced by. It is likely that the target resource will be an oslc_qm:TestExecutionRecord but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#producedByTestExecutionRecord"></see></summary>
    let producedByTestExecutionRecord = _prefix "producedByTestExecutionRecord"
    /// <summary>
    /// A related change request. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#relatedChangeRequest"></see></summary>
    let relatedChangeRequest = _prefix "relatedChangeRequest"
    /// <summary>
    /// Test Case that the Test Result reports on. It is likely that the target resource will be an oslc_qm:TestCase but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#reportsOnTestCase"></see></summary>
    let reportsOnTestCase = _prefix "reportsOnTestCase"
    /// <summary>
    /// Test Plan that a test or execution record reports on. It is likely that the target resource will be an oslc_qm:TestPlan but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#reportsOnTestPlan"></see></summary>
    let reportsOnTestPlan = _prefix "reportsOnTestPlan"
    /// <summary>
    /// Indicates the environment details of the test case for this execution record.
    /// <see href="http://open-services.net/ns/qm#runsOnTestEnvironment"></see></summary>
    let runsOnTestEnvironment = _prefix "runsOnTestEnvironment"
    /// <summary>
    /// Test Case run by the Test Execution Record. It is likely that the target resource will be an oslc_qm:TestCase but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#runsTestCase"></see></summary>
    let runsTestCase = _prefix "runsTestCase"
    /// <summary>
    /// Used to indicate the state of the Test Result based on values defined by the service provider.
    /// <see href="http://open-services.net/ns/qm#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// Change Request tested by the Test Case. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#testsChangeRequest"></see></summary>
    let testsChangeRequest = _prefix "testsChangeRequest"
    /// <summary>
    /// Test Case used by the Test Plan. It is likely that the target resource will be an oslc_qm:TestCase but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#usesTestCase"></see></summary>
    let usesTestCase = _prefix "usesTestCase"
    /// <summary>
    /// Test Script used by the Test Case. It is likely that the target resource will be an oslc_qm:TestScript but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#usesTestScript"></see></summary>
    let usesTestScript = _prefix "usesTestScript"
    /// <summary>
    /// Requirement that is validated by the Test Case. It is likely that the target resource will be an oslc_rm:Requirement but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#validatesRequirement"></see></summary>
    let validatesRequirement = _prefix "validatesRequirement"
    /// <summary>
    /// Requirement Collection that is validated by the Test Plan. It is likely that the target resource will be an oslc_rm:RequirementCollection but that is not necessarily the case.
    /// <see href="http://open-services.net/ns/qm#validatesRequirementCollection"></see></summary>
    let validatesRequirementCollection = _prefix "validatesRequirementCollection"
