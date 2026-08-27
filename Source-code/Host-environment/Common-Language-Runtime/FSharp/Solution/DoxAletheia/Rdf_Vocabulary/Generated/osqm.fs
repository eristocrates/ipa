namespace http.open_services.net.ns.qm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module osqm =
    let _namespace_iri = Namespace_Iri osqm |> NamespaceIRI
    /// <summary>
    ///   <para>osqm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"OSLC Quality Management (QM) Vocabulary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#">http://open-services.net/ns/qm#</seealso>
    let _prefix_iri = Prefixed_Name(osqm, "") |> PrefixedName
    /// <summary>
    ///   <para>osqm:TestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The QM Test Case resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TestCase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#TestCase">http://open-services.net/ns/qm#TestCase</seealso>
    let TestCase = Prefixed_Name(osqm, "TestCase") |> PrefixedName
    /// <summary>
    ///   <para>osqm:TestExecutionRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The QM Test Execution Record resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TestExecutionRecord"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#TestExecutionRecord">http://open-services.net/ns/qm#TestExecutionRecord</seealso>
    let TestExecutionRecord = Prefixed_Name(osqm, "TestExecutionRecord") |> PrefixedName
    /// <summary>
    ///   <para>osqm:TestPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The QM Test Plan resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TestPlan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#TestPlan">http://open-services.net/ns/qm#TestPlan</seealso>
    let TestPlan = Prefixed_Name(osqm, "TestPlan") |> PrefixedName
    /// <summary>
    ///   <para>osqm:TestResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The QM Test Result resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TestResult"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#TestResult">http://open-services.net/ns/qm#TestResult</seealso>
    let TestResult = Prefixed_Name(osqm, "TestResult") |> PrefixedName
    /// <summary>
    ///   <para>osqm:TestScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The QM Test Script resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TestScript"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#TestScript">http://open-services.net/ns/qm#TestScript</seealso>
    let TestScript = Prefixed_Name(osqm, "TestScript") |> PrefixedName

    /// <summary>
    ///   <para>osqm:affectedByChangeRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Change request that affects the Test Result. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"affectedByChangeRequest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#affectedByChangeRequest">http://open-services.net/ns/qm#affectedByChangeRequest</seealso>
    let affectedByChangeRequest =
        Prefixed_Name(osqm, "affectedByChangeRequest") |> PrefixedName

    /// <summary>
    ///   <para>osqm:blockedByChangeRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Change Request that prevents execution of the Test Execution Record. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"blockedByChangeRequest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#blockedByChangeRequest">http://open-services.net/ns/qm#blockedByChangeRequest</seealso>
    let blockedByChangeRequest =
        Prefixed_Name(osqm, "blockedByChangeRequest") |> PrefixedName

    /// <summary>
    ///   <para>osqm:executesTestScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Test Script executed to produce the Test Result. It is likely that the target resource will be an oslc_qm:TestScript but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"executesTestScript"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#executesTestScript">http://open-services.net/ns/qm#executesTestScript</seealso>
    let executesTestScript = Prefixed_Name(osqm, "executesTestScript") |> PrefixedName

    /// <summary>
    ///   <para>osqm:executionInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Instructions for executing the test script. Note that the value of Occurs is undefined. The resource shape document provided by the QM service provider may be consulted for its value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"executionInstructions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#executionInstructions">http://open-services.net/ns/qm#executionInstructions</seealso>
    let executionInstructions =
        Prefixed_Name(osqm, "executionInstructions") |> PrefixedName

    /// <summary>
    ///   <para>osqm:producedByTestExecutionRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Test Execution Record that the Test Result was produced by. It is likely that the target resource will be an oslc_qm:TestExecutionRecord but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"producedByTestExecutionRecord"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#producedByTestExecutionRecord">http://open-services.net/ns/qm#producedByTestExecutionRecord</seealso>
    let producedByTestExecutionRecord =
        Prefixed_Name(osqm, "producedByTestExecutionRecord") |> PrefixedName

    /// <summary>
    ///   <para>osqm:relatedChangeRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A related change request. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relatedChangeRequest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#relatedChangeRequest">http://open-services.net/ns/qm#relatedChangeRequest</seealso>
    let relatedChangeRequest =
        Prefixed_Name(osqm, "relatedChangeRequest") |> PrefixedName

    /// <summary>
    ///   <para>osqm:reportsOnTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Test Case that the Test Result reports on. It is likely that the target resource will be an oslc_qm:TestCase but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reportsOnTestCase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#reportsOnTestCase">http://open-services.net/ns/qm#reportsOnTestCase</seealso>
    let reportsOnTestCase = Prefixed_Name(osqm, "reportsOnTestCase") |> PrefixedName
    /// <summary>
    ///   <para>osqm:reportsOnTestPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Test Plan that a test or execution record reports on. It is likely that the target resource will be an oslc_qm:TestPlan but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reportsOnTestPlan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#reportsOnTestPlan">http://open-services.net/ns/qm#reportsOnTestPlan</seealso>
    let reportsOnTestPlan = Prefixed_Name(osqm, "reportsOnTestPlan") |> PrefixedName

    /// <summary>
    ///   <para>osqm:runsOnTestEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the environment details of the test case for this execution record."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"runsOnTestEnvironment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#runsOnTestEnvironment">http://open-services.net/ns/qm#runsOnTestEnvironment</seealso>
    let runsOnTestEnvironment =
        Prefixed_Name(osqm, "runsOnTestEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>osqm:runsTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Test Case run by the Test Execution Record. It is likely that the target resource will be an oslc_qm:TestCase but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"runsTestCase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#runsTestCase">http://open-services.net/ns/qm#runsTestCase</seealso>
    let runsTestCase = Prefixed_Name(osqm, "runsTestCase") |> PrefixedName
    /// <summary>
    ///   <para>osqm:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Used to indicate the state of the Test Result based on values defined by the service provider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#status">http://open-services.net/ns/qm#status</seealso>
    let status = Prefixed_Name(osqm, "status") |> PrefixedName
    /// <summary>
    ///   <para>osqm:testsChangeRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Change Request tested by the Test Case. It is likely that the target resource will be an oslc_cm:ChangeRequest but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"testsChangeRequest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#testsChangeRequest">http://open-services.net/ns/qm#testsChangeRequest</seealso>
    let testsChangeRequest = Prefixed_Name(osqm, "testsChangeRequest") |> PrefixedName
    /// <summary>
    ///   <para>osqm:usesTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Test Case used by the Test Plan. It is likely that the target resource will be an oslc_qm:TestCase but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"usesTestCase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#usesTestCase">http://open-services.net/ns/qm#usesTestCase</seealso>
    let usesTestCase = Prefixed_Name(osqm, "usesTestCase") |> PrefixedName
    /// <summary>
    ///   <para>osqm:usesTestScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Test Script used by the Test Case. It is likely that the target resource will be an oslc_qm:TestScript but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"usesTestScript"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#usesTestScript">http://open-services.net/ns/qm#usesTestScript</seealso>
    let usesTestScript = Prefixed_Name(osqm, "usesTestScript") |> PrefixedName

    /// <summary>
    ///   <para>osqm:validatesRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Requirement that is validated by the Test Case. It is likely that the target resource will be an oslc_rm:Requirement but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"validatesRequirement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#validatesRequirement">http://open-services.net/ns/qm#validatesRequirement</seealso>
    let validatesRequirement =
        Prefixed_Name(osqm, "validatesRequirement") |> PrefixedName

    /// <summary>
    ///   <para>osqm:validatesRequirementCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Requirement Collection that is validated by the Test Plan. It is likely that the target resource will be an oslc_rm:RequirementCollection but that is not necessarily the case."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"validatesRequirementCollection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/qm#validatesRequirementCollection">http://open-services.net/ns/qm#validatesRequirementCollection</seealso>
    let validatesRequirementCollection =
        Prefixed_Name(osqm, "validatesRequirementCollection") |> PrefixedName
