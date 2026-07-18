namespace http.www.w3.org.ns.earl.hash

open DoxAletheia.Rdf_Vocabulary

module earl =
    let _namespace_name = "http://www.w3.org/ns/earl#"
    /// <summary>
    /// a statement that embodies the results of a test
    /// <see href="http://www.w3.org/ns/earl#Assertion"></see></summary>
    let Assertion = Namespaced_IRI.parse _namespace_name "Assertion" |> NamespacedName
    /// <summary>
    /// an entity such as a person, a software tool, an organization, or any other grouping that carries out a test collectively
    /// <see href="http://www.w3.org/ns/earl#Assertor"></see></summary>
    let Assertor = Namespaced_IRI.parse _namespace_name "Assertor" |> NamespacedName
    /// <summary>
    /// the class of outcomes to denote an undetermined outcome
    /// <see href="http://www.w3.org/ns/earl#CannotTell"></see></summary>
    let CannotTell = Namespaced_IRI.parse _namespace_name "CannotTell" |> NamespacedName

    /// <summary>
    /// a discrete value that describes a resulting condition from carrying out the test
    /// <see href="http://www.w3.org/ns/earl#OutcomeValue"></see></summary>
    let OutcomeValue =
        Namespaced_IRI.parse _namespace_name "OutcomeValue" |> NamespacedName

    /// <summary>
    /// the class of outcomes to denote failing a test
    /// <see href="http://www.w3.org/ns/earl#Fail"></see></summary>
    let Fail = Namespaced_IRI.parse _namespace_name "Fail" |> NamespacedName

    /// <summary>
    /// the class of outcomes to denote the test is not applicable
    /// <see href="http://www.w3.org/ns/earl#NotApplicable"></see></summary>
    let NotApplicable =
        Namespaced_IRI.parse _namespace_name "NotApplicable" |> NamespacedName

    /// <summary>
    /// the class of outcomes to denote the test has not been carried out
    /// <see href="http://www.w3.org/ns/earl#NotTested"></see></summary>
    let NotTested = Namespaced_IRI.parse _namespace_name "NotTested" |> NamespacedName
    /// <summary>
    /// the class of outcomes to denote passing a test
    /// <see href="http://www.w3.org/ns/earl#Pass"></see></summary>
    let Pass = Namespaced_IRI.parse _namespace_name "Pass" |> NamespacedName
    /// <summary>
    /// any piece of software such as an authoring tool, browser, or evaluation tool
    /// <see href="http://www.w3.org/ns/earl#Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName
    /// <summary>
    /// an atomic test, usually one that is a partial test for a requirement
    /// <see href="http://www.w3.org/ns/earl#TestCase"></see></summary>
    let TestCase = Namespaced_IRI.parse _namespace_name "TestCase" |> NamespacedName

    /// <summary>
    /// a testable statement, usually one that can be passed or failed
    /// <see href="http://www.w3.org/ns/earl#TestCriterion"></see></summary>
    let TestCriterion =
        Namespaced_IRI.parse _namespace_name "TestCriterion" |> NamespacedName

    /// <summary>
    /// describes how a test was carried out
    /// <see href="http://www.w3.org/ns/earl#TestMode"></see></summary>
    let TestMode = Namespaced_IRI.parse _namespace_name "TestMode" |> NamespacedName

    /// <summary>
    /// a higher-level requirement that is tested by executing one or more sub-tests
    /// <see href="http://www.w3.org/ns/earl#TestRequirement"></see></summary>
    let TestRequirement =
        Namespaced_IRI.parse _namespace_name "TestRequirement" |> NamespacedName

    /// <summary>
    /// the actual result of performing the test
    /// <see href="http://www.w3.org/ns/earl#TestResult"></see></summary>
    let TestResult = Namespaced_IRI.parse _namespace_name "TestResult" |> NamespacedName

    /// <summary>
    /// the class of things that have been tested against some test criterion
    /// <see href="http://www.w3.org/ns/earl#TestSubject"></see></summary>
    let TestSubject =
        Namespaced_IRI.parse _namespace_name "TestSubject" |> NamespacedName

    /// <summary>
    /// assertor of an assertion
    /// <see href="http://www.w3.org/ns/earl#assertedBy"></see></summary>
    let assertedBy = Namespaced_IRI.parse _namespace_name "assertedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#automatic"></see>
    /// </summary>
    let automatic = Namespaced_IRI.parse _namespace_name "automatic" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#cantTell"></see>
    /// </summary>
    let cantTell = Namespaced_IRI.parse _namespace_name "cantTell" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#failed"></see>
    /// </summary>
    let failed = Namespaced_IRI.parse _namespace_name "failed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#inapplicable"></see>
    /// </summary>
    let inapplicable =
        Namespaced_IRI.parse _namespace_name "inapplicable" |> NamespacedName

    /// <summary>
    /// additional warnings or error messages in a human-readable form
    /// <see href="http://www.w3.org/ns/earl#info"></see></summary>
    let info = Namespaced_IRI.parse _namespace_name "info" |> NamespacedName

    /// <summary>
    /// assertor that is primarily responsible for performing the test
    /// <see href="http://www.w3.org/ns/earl#mainAssertor"></see></summary>
    let mainAssertor =
        Namespaced_IRI.parse _namespace_name "mainAssertor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#manual"></see>
    /// </summary>
    let manual = Namespaced_IRI.parse _namespace_name "manual" |> NamespacedName
    /// <summary>
    /// mode in which the test was performed
    /// <see href="http://www.w3.org/ns/earl#mode"></see></summary>
    let mode = Namespaced_IRI.parse _namespace_name "mode" |> NamespacedName
    /// <summary>
    /// outcome of performing the test
    /// <see href="http://www.w3.org/ns/earl#outcome"></see></summary>
    let outcome = Namespaced_IRI.parse _namespace_name "outcome" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#passed"></see>
    /// </summary>
    let passed = Namespaced_IRI.parse _namespace_name "passed" |> NamespacedName
    /// <summary>
    /// location within a test subject that are most relevant to a test result
    /// <see href="http://www.w3.org/ns/earl#pointer"></see></summary>
    let pointer = Namespaced_IRI.parse _namespace_name "pointer" |> NamespacedName
    /// <summary>
    /// result of an assertion
    /// <see href="http://www.w3.org/ns/earl#result"></see></summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#semiAuto"></see>
    /// </summary>
    let semiAuto = Namespaced_IRI.parse _namespace_name "semiAuto" |> NamespacedName
    /// <summary>
    /// test subject of an assertion
    /// <see href="http://www.w3.org/ns/earl#subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// test criterion of an assertion
    /// <see href="http://www.w3.org/ns/earl#test"></see></summary>
    let test = Namespaced_IRI.parse _namespace_name "test" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#undisclosed"></see>
    /// </summary>
    let undisclosed =
        Namespaced_IRI.parse _namespace_name "undisclosed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#unknownMode"></see>
    /// </summary>
    let unknownMode =
        Namespaced_IRI.parse _namespace_name "unknownMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#untested"></see>
    /// </summary>
    let untested = Namespaced_IRI.parse _namespace_name "untested" |> NamespacedName
