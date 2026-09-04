#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module earl =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/earl#" "earl"
    /// <summary>
    ///   <para>rdfs:label : Assertion</para>
    ///   <para>rdfs:comment : a statement that embodies the results of a test</para>
    ///   <a href="http://www.w3.org/ns/earl#Assertion">earl:Assertion</a>
    /// </summary>
    let Assertion = _prefixId.prefix "Assertion"
    /// <summary>
    ///   <para>rdfs:label : Assertor</para>
    ///   <para>rdfs:comment : an entity such as a person, a software tool, an organization, or any other grouping that carries out a test collectively</para>
    ///   <a href="http://www.w3.org/ns/earl#Assertor">earl:Assertor</a>
    /// </summary>
    let Assertor = _prefixId.prefix "Assertor"
    /// <summary>
    ///   <para>rdfs:label : Undetermined</para>
    ///   <para>rdfs:comment : the class of outcomes to denote an undetermined outcome</para>
    ///   <a href="http://www.w3.org/ns/earl#CannotTell">earl:CannotTell</a>
    /// </summary>
    let CannotTell = _prefixId.prefix "CannotTell"
    /// <summary>
    ///   <para>rdfs:label : Fail</para>
    ///   <para>rdfs:comment : the class of outcomes to denote failing a test</para>
    ///   <a href="http://www.w3.org/ns/earl#Fail">earl:Fail</a>
    /// </summary>
    let Fail = _prefixId.prefix "Fail"
    /// <summary>
    ///   <para>rdfs:label : Not applicable</para>
    ///   <para>rdfs:comment : the class of outcomes to denote the test is not applicable</para>
    ///   <a href="http://www.w3.org/ns/earl#NotApplicable">earl:NotApplicable</a>
    /// </summary>
    let NotApplicable = _prefixId.prefix "NotApplicable"
    /// <summary>
    ///   <para>rdfs:label : Not tested</para>
    ///   <para>rdfs:comment : the class of outcomes to denote the test has not been carried out</para>
    ///   <a href="http://www.w3.org/ns/earl#NotTested">earl:NotTested</a>
    /// </summary>
    let NotTested = _prefixId.prefix "NotTested"
    /// <summary>
    ///   <para>rdfs:label : Outcome Value</para>
    ///   <para>rdfs:comment : a discrete value that describes a resulting condition from carrying out the test</para>
    ///   <a href="http://www.w3.org/ns/earl#OutcomeValue">earl:OutcomeValue</a>
    /// </summary>
    let OutcomeValue = _prefixId.prefix "OutcomeValue"
    /// <summary>
    ///   <para>rdfs:label : Pass</para>
    ///   <para>rdfs:comment : the class of outcomes to denote passing a test</para>
    ///   <a href="http://www.w3.org/ns/earl#Pass">earl:Pass</a>
    /// </summary>
    let Pass = _prefixId.prefix "Pass"
    /// <summary>
    ///   <para>rdfs:label : Software</para>
    ///   <para>rdfs:comment : any piece of software such as an authoring tool, browser, or evaluation tool</para>
    ///   <a href="http://www.w3.org/ns/earl#Software">earl:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    /// <summary>
    ///   <para>rdfs:label : Test Case</para>
    ///   <para>rdfs:comment : an atomic test, usually one that is a partial test for a requirement</para>
    ///   <a href="http://www.w3.org/ns/earl#TestCase">earl:TestCase</a>
    /// </summary>
    let TestCase = _prefixId.prefix "TestCase"
    /// <summary>
    ///   <para>rdfs:label : Test Criterion</para>
    ///   <para>rdfs:comment : a testable statement, usually one that can be passed or failed</para>
    ///   <a href="http://www.w3.org/ns/earl#TestCriterion">earl:TestCriterion</a>
    /// </summary>
    let TestCriterion = _prefixId.prefix "TestCriterion"
    /// <summary>
    ///   <para>rdfs:label : Test Mode</para>
    ///   <para>rdfs:comment : describes how a test was carried out</para>
    ///   <a href="http://www.w3.org/ns/earl#TestMode">earl:TestMode</a>
    /// </summary>
    let TestMode = _prefixId.prefix "TestMode"
    /// <summary>
    ///   <para>rdfs:label : Test Requirement</para>
    ///   <para>rdfs:comment : a higher-level requirement that is tested by executing one or more sub-tests</para>
    ///   <a href="http://www.w3.org/ns/earl#TestRequirement">earl:TestRequirement</a>
    /// </summary>
    let TestRequirement = _prefixId.prefix "TestRequirement"
    /// <summary>
    ///   <para>rdfs:label : Test Result</para>
    ///   <para>rdfs:comment : the actual result of performing the test</para>
    ///   <a href="http://www.w3.org/ns/earl#TestResult">earl:TestResult</a>
    /// </summary>
    let TestResult = _prefixId.prefix "TestResult"
    /// <summary>
    ///   <para>rdfs:label : Test Subject</para>
    ///   <para>rdfs:comment : the class of things that have been tested against some test criterion</para>
    ///   <a href="http://www.w3.org/ns/earl#TestSubject">earl:TestSubject</a>
    /// </summary>
    let TestSubject = _prefixId.prefix "TestSubject"
    /// <summary>
    ///   <para>rdfs:label : Asserted By</para>
    ///   <para>rdfs:comment : assertor of an assertion</para>
    ///   <a href="http://www.w3.org/ns/earl#assertedBy">earl:assertedBy</a>
    /// </summary>
    let assertedBy = _prefixId.prefix "assertedBy"
    let automatic = _prefixId.prefix "automatic"
    let cantTell = _prefixId.prefix "cantTell"
    let failed = _prefixId.prefix "failed"
    let inapplicable = _prefixId.prefix "inapplicable"
    /// <summary>
    ///   <para>rdfs:label : Info</para>
    ///   <para>rdfs:comment : additional warnings or error messages in a human-readable form</para>
    ///   <a href="http://www.w3.org/ns/earl#info">earl:info</a>
    /// </summary>
    let info = _prefixId.prefix "info"
    /// <summary>
    ///   <para>rdfs:label : Main Assertor</para>
    ///   <para>rdfs:comment : assertor that is primarily responsible for performing the test</para>
    ///   <a href="http://www.w3.org/ns/earl#mainAssertor">earl:mainAssertor</a>
    /// </summary>
    let mainAssertor = _prefixId.prefix "mainAssertor"
    let manual = _prefixId.prefix "manual"
    /// <summary>
    ///   <para>rdfs:label : Mode</para>
    ///   <para>rdfs:comment : mode in which the test was performed</para>
    ///   <a href="http://www.w3.org/ns/earl#mode">earl:mode</a>
    /// </summary>
    let mode = _prefixId.prefix "mode"
    /// <summary>
    ///   <para>rdfs:label : Outcome</para>
    ///   <para>rdfs:comment : outcome of performing the test</para>
    ///   <a href="http://www.w3.org/ns/earl#outcome">earl:outcome</a>
    /// </summary>
    let outcome = _prefixId.prefix "outcome"
    let passed = _prefixId.prefix "passed"
    /// <summary>
    ///   <para>rdfs:label : Pointer</para>
    ///   <para>rdfs:comment : location within a test subject that are most relevant to a test result</para>
    ///   <a href="http://www.w3.org/ns/earl#pointer">earl:pointer</a>
    /// </summary>
    let pointer = _prefixId.prefix "pointer"
    /// <summary>
    ///   <para>rdfs:label : Result</para>
    ///   <para>rdfs:comment : result of an assertion</para>
    ///   <a href="http://www.w3.org/ns/earl#result">earl:result</a>
    /// </summary>
    let result = _prefixId.prefix "result"
    let semiAuto = _prefixId.prefix "semiAuto"
    /// <summary>
    ///   <para>rdfs:label : Subject</para>
    ///   <para>rdfs:comment : test subject of an assertion</para>
    ///   <a href="http://www.w3.org/ns/earl#subject">earl:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:label : Test</para>
    ///   <para>rdfs:comment : test criterion of an assertion</para>
    ///   <a href="http://www.w3.org/ns/earl#test">earl:test</a>
    /// </summary>
    let test = _prefixId.prefix "test"
    let undisclosed = _prefixId.prefix "undisclosed"
    let unknownMode = _prefixId.prefix "unknownMode"
    let untested = _prefixId.prefix "untested"
