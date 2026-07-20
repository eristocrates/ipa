namespace http.www.w3.org.ns.earl.hash

open DoxAletheia

module earl =
    let _namespace_name = "http://www.w3.org/ns/earl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// a statement that embodies the results of a test
    /// <see href="http://www.w3.org/ns/earl#Assertion"></see></summary>
    let Assertion = _prefix "Assertion"
    /// <summary>
    /// an entity such as a person, a software tool, an organization, or any other grouping that carries out a test collectively
    /// <see href="http://www.w3.org/ns/earl#Assertor"></see></summary>
    let Assertor = _prefix "Assertor"
    /// <summary>
    /// the class of outcomes to denote an undetermined outcome
    /// <see href="http://www.w3.org/ns/earl#CannotTell"></see></summary>
    let CannotTell = _prefix "CannotTell"
    /// <summary>
    /// a discrete value that describes a resulting condition from carrying out the test
    /// <see href="http://www.w3.org/ns/earl#OutcomeValue"></see></summary>
    let OutcomeValue = _prefix "OutcomeValue"
    /// <summary>
    /// the class of outcomes to denote failing a test
    /// <see href="http://www.w3.org/ns/earl#Fail"></see></summary>
    let Fail = _prefix "Fail"
    /// <summary>
    /// the class of outcomes to denote the test is not applicable
    /// <see href="http://www.w3.org/ns/earl#NotApplicable"></see></summary>
    let NotApplicable = _prefix "NotApplicable"
    /// <summary>
    /// the class of outcomes to denote the test has not been carried out
    /// <see href="http://www.w3.org/ns/earl#NotTested"></see></summary>
    let NotTested = _prefix "NotTested"
    /// <summary>
    /// the class of outcomes to denote passing a test
    /// <see href="http://www.w3.org/ns/earl#Pass"></see></summary>
    let Pass = _prefix "Pass"
    /// <summary>
    /// any piece of software such as an authoring tool, browser, or evaluation tool
    /// <see href="http://www.w3.org/ns/earl#Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    /// an atomic test, usually one that is a partial test for a requirement
    /// <see href="http://www.w3.org/ns/earl#TestCase"></see></summary>
    let TestCase = _prefix "TestCase"
    /// <summary>
    /// a testable statement, usually one that can be passed or failed
    /// <see href="http://www.w3.org/ns/earl#TestCriterion"></see></summary>
    let TestCriterion = _prefix "TestCriterion"
    /// <summary>
    /// describes how a test was carried out
    /// <see href="http://www.w3.org/ns/earl#TestMode"></see></summary>
    let TestMode = _prefix "TestMode"
    /// <summary>
    /// a higher-level requirement that is tested by executing one or more sub-tests
    /// <see href="http://www.w3.org/ns/earl#TestRequirement"></see></summary>
    let TestRequirement = _prefix "TestRequirement"
    /// <summary>
    /// the actual result of performing the test
    /// <see href="http://www.w3.org/ns/earl#TestResult"></see></summary>
    let TestResult = _prefix "TestResult"
    /// <summary>
    /// the class of things that have been tested against some test criterion
    /// <see href="http://www.w3.org/ns/earl#TestSubject"></see></summary>
    let TestSubject = _prefix "TestSubject"
    /// <summary>
    /// assertor of an assertion
    /// <see href="http://www.w3.org/ns/earl#assertedBy"></see></summary>
    let assertedBy = _prefix "assertedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#automatic"></see>
    /// </summary>
    let automatic = _prefix "automatic"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#cantTell"></see>
    /// </summary>
    let cantTell = _prefix "cantTell"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#failed"></see>
    /// </summary>
    let failed = _prefix "failed"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#inapplicable"></see>
    /// </summary>
    let inapplicable = _prefix "inapplicable"
    /// <summary>
    /// additional warnings or error messages in a human-readable form
    /// <see href="http://www.w3.org/ns/earl#info"></see></summary>
    let info = _prefix "info"
    /// <summary>
    /// assertor that is primarily responsible for performing the test
    /// <see href="http://www.w3.org/ns/earl#mainAssertor"></see></summary>
    let mainAssertor = _prefix "mainAssertor"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#manual"></see>
    /// </summary>
    let manual = _prefix "manual"
    /// <summary>
    /// mode in which the test was performed
    /// <see href="http://www.w3.org/ns/earl#mode"></see></summary>
    let mode = _prefix "mode"
    /// <summary>
    /// outcome of performing the test
    /// <see href="http://www.w3.org/ns/earl#outcome"></see></summary>
    let outcome = _prefix "outcome"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#passed"></see>
    /// </summary>
    let passed = _prefix "passed"
    /// <summary>
    /// location within a test subject that are most relevant to a test result
    /// <see href="http://www.w3.org/ns/earl#pointer"></see></summary>
    let pointer = _prefix "pointer"
    /// <summary>
    /// result of an assertion
    /// <see href="http://www.w3.org/ns/earl#result"></see></summary>
    let result = _prefix "result"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#semiAuto"></see>
    /// </summary>
    let semiAuto = _prefix "semiAuto"
    /// <summary>
    /// test subject of an assertion
    /// <see href="http://www.w3.org/ns/earl#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// test criterion of an assertion
    /// <see href="http://www.w3.org/ns/earl#test"></see></summary>
    let test = _prefix "test"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#undisclosed"></see>
    /// </summary>
    let undisclosed = _prefix "undisclosed"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#unknownMode"></see>
    /// </summary>
    let unknownMode = _prefix "unknownMode"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/earl#untested"></see>
    /// </summary>
    let untested = _prefix "untested"
