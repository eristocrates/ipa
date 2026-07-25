namespace http.www.w3.org.ns.earl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module earl =
    let _namespace_iri = Namespace_Iri earl |> NamespaceIRI
    /// <summary>
    ///   <para>earl:Assertor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>an entity such as a person, a software tool, an organization, or any other grouping that carries out a test collectively</para>
    /// labels<para>Assertor</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#Assertor">http://www.w3.org/ns/earl#Assertor</seealso>
    let Assertor = Prefixed_Name(earl, "Assertor") |> PrefixedName
    /// <summary>
    ///   <para>earl:failed</para>
    /// </summary>
    /// <remarks>
    ///   <para>earl:Fail</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/earl#failed">http://www.w3.org/ns/earl#failed</seealso>
    let failed = Prefixed_Name(earl, "failed") |> PrefixedName
    /// <summary>
    ///   <para>earl:NotApplicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>the class of outcomes to denote the test is not applicable</para>
    /// labels<para>Not applicable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#NotApplicable">http://www.w3.org/ns/earl#NotApplicable</seealso>
    let NotApplicable = Prefixed_Name(earl, "NotApplicable") |> PrefixedName
    /// <summary>
    ///   <para>earl:NotTested</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>the class of outcomes to denote the test has not been carried out</para>
    /// labels<para>Not tested</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#NotTested">http://www.w3.org/ns/earl#NotTested</seealso>
    let NotTested = Prefixed_Name(earl, "NotTested") |> PrefixedName
    /// <summary>
    ///   <para>earl:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>any piece of software such as an authoring tool, browser, or evaluation tool</para>
    /// labels<para>Software</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#Software">http://www.w3.org/ns/earl#Software</seealso>
    let Software = Prefixed_Name(earl, "Software") |> PrefixedName
    /// <summary>
    ///   <para>earl:TestMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>describes how a test was carried out</para>
    /// labels<para>Test Mode</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#TestMode">http://www.w3.org/ns/earl#TestMode</seealso>
    let TestMode = Prefixed_Name(earl, "TestMode") |> PrefixedName
    /// <summary>
    ///   <para>earl:Pass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>the class of outcomes to denote passing a test</para>
    /// labels<para>Pass</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#Pass">http://www.w3.org/ns/earl#Pass</seealso>
    let Pass = Prefixed_Name(earl, "Pass") |> PrefixedName
    /// <summary>
    ///   <para>earl:TestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>an atomic test, usually one that is a partial test for a requirement</para>
    /// labels<para>Test Case</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#TestCase">http://www.w3.org/ns/earl#TestCase</seealso>
    let TestCase = Prefixed_Name(earl, "TestCase") |> PrefixedName
    /// <summary>
    ///   <para>earl:TestResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>the actual result of performing the test</para>
    /// labels<para>Test Result</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#TestResult">http://www.w3.org/ns/earl#TestResult</seealso>
    let TestResult = Prefixed_Name(earl, "TestResult") |> PrefixedName
    /// <summary>
    ///   <para>earl:automatic</para>
    /// </summary>
    /// <remarks>
    ///   <para>earl:TestMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/earl#automatic">http://www.w3.org/ns/earl#automatic</seealso>
    let automatic = Prefixed_Name(earl, "automatic") |> PrefixedName
    /// <summary>
    ///   <para>earl:inapplicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>earl:NotApplicable</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/earl#inapplicable">http://www.w3.org/ns/earl#inapplicable</seealso>
    let inapplicable = Prefixed_Name(earl, "inapplicable") |> PrefixedName
    /// <summary>
    ///   <para>earl:TestCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>a testable statement, usually one that can be passed or failed</para>
    /// labels<para>Test Criterion</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#TestCriterion">http://www.w3.org/ns/earl#TestCriterion</seealso>
    let TestCriterion = Prefixed_Name(earl, "TestCriterion") |> PrefixedName
    /// <summary>
    ///   <para>earl:TestRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>a higher-level requirement that is tested by executing one or more sub-tests</para>
    /// labels<para>Test Requirement</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#TestRequirement">http://www.w3.org/ns/earl#TestRequirement</seealso>
    let TestRequirement = Prefixed_Name(earl, "TestRequirement") |> PrefixedName
    /// <summary>
    ///   <para>earl:TestSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>the class of things that have been tested against some test criterion</para>
    /// labels<para>Test Subject</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#TestSubject">http://www.w3.org/ns/earl#TestSubject</seealso>
    let TestSubject = Prefixed_Name(earl, "TestSubject") |> PrefixedName
    /// <summary>
    ///   <para>earl:cantTell</para>
    /// </summary>
    /// <remarks>
    ///   <para>earl:CannotTell</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/earl#cantTell">http://www.w3.org/ns/earl#cantTell</seealso>
    let cantTell = Prefixed_Name(earl, "cantTell") |> PrefixedName
    /// <summary>
    ///   <para>earl:manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>earl:TestMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/earl#manual">http://www.w3.org/ns/earl#manual</seealso>
    let manual = Prefixed_Name(earl, "manual") |> PrefixedName
    /// <summary>
    ///   <para>earl:passed</para>
    /// </summary>
    /// <remarks>
    ///   <para>earl:Pass</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/earl#passed">http://www.w3.org/ns/earl#passed</seealso>
    let passed = Prefixed_Name(earl, "passed") |> PrefixedName
    /// <summary>
    ///   <para>earl:semiAuto</para>
    /// </summary>
    /// <remarks>
    ///   <para>earl:TestMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/earl#semiAuto">http://www.w3.org/ns/earl#semiAuto</seealso>
    let semiAuto = Prefixed_Name(earl, "semiAuto") |> PrefixedName
    /// <summary>
    ///   <para>earl:assertedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>assertor of an assertion</para>
    /// labels<para>Asserted By</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#assertedBy">http://www.w3.org/ns/earl#assertedBy</seealso>
    let assertedBy = Prefixed_Name(earl, "assertedBy") |> PrefixedName
    /// <summary>
    ///   <para>earl:info</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>additional warnings or error messages in a human-readable form</para>
    /// labels<para>Info</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#info">http://www.w3.org/ns/earl#info</seealso>
    let info = Prefixed_Name(earl, "info") |> PrefixedName
    /// <summary>
    ///   <para>earl:mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>mode in which the test was performed</para>
    /// labels<para>Mode</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#mode">http://www.w3.org/ns/earl#mode</seealso>
    let mode = Prefixed_Name(earl, "mode") |> PrefixedName
    /// <summary>
    ///   <para>earl:mainAssertor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>assertor that is primarily responsible for performing the test</para>
    /// labels<para>Main Assertor</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#mainAssertor">http://www.w3.org/ns/earl#mainAssertor</seealso>
    let mainAssertor = Prefixed_Name(earl, "mainAssertor") |> PrefixedName
    /// <summary>
    ///   <para>earl:outcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>outcome of performing the test</para>
    /// labels<para>Outcome</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#outcome">http://www.w3.org/ns/earl#outcome</seealso>
    let outcome = Prefixed_Name(earl, "outcome") |> PrefixedName
    /// <summary>
    ///   <para>earl:pointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>location within a test subject that are most relevant to a test result</para>
    /// labels<para>Pointer</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#pointer">http://www.w3.org/ns/earl#pointer</seealso>
    let pointer = Prefixed_Name(earl, "pointer") |> PrefixedName
    /// <summary>
    ///   <para>earl:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>result of an assertion</para>
    /// labels<para>Result</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#result">http://www.w3.org/ns/earl#result</seealso>
    let result = Prefixed_Name(earl, "result") |> PrefixedName
    /// <summary>
    ///   <para>earl:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>test subject of an assertion</para>
    /// labels<para>Subject</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#subject">http://www.w3.org/ns/earl#subject</seealso>
    let subject = Prefixed_Name(earl, "subject") |> PrefixedName
    /// <summary>
    ///   <para>earl:undisclosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>earl:TestMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/earl#undisclosed">http://www.w3.org/ns/earl#undisclosed</seealso>
    let undisclosed = Prefixed_Name(earl, "undisclosed") |> PrefixedName
    /// <summary>
    ///   <para>earl:test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>test criterion of an assertion</para>
    /// labels<para>Test</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#test">http://www.w3.org/ns/earl#test</seealso>
    let test = Prefixed_Name(earl, "test") |> PrefixedName
    /// <summary>
    ///   <para>earl:unknownMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>earl:TestMode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/earl#unknownMode">http://www.w3.org/ns/earl#unknownMode</seealso>
    let unknownMode = Prefixed_Name(earl, "unknownMode") |> PrefixedName
    /// <summary>
    ///   <para>earl:untested</para>
    /// </summary>
    /// <remarks>
    ///   <para>earl:NotTested</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/earl#untested">http://www.w3.org/ns/earl#untested</seealso>
    let untested = Prefixed_Name(earl, "untested") |> PrefixedName
    /// <summary>
    ///   <para>earl:Assertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>a statement that embodies the results of a test</para>
    /// labels<para>Assertion</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#Assertion">http://www.w3.org/ns/earl#Assertion</seealso>
    let Assertion = Prefixed_Name(earl, "Assertion") |> PrefixedName
    /// <summary>
    ///   <para>earl:CannotTell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>the class of outcomes to denote an undetermined outcome</para>
    /// labels<para>Undetermined</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#CannotTell">http://www.w3.org/ns/earl#CannotTell</seealso>
    let CannotTell = Prefixed_Name(earl, "CannotTell") |> PrefixedName
    /// <summary>
    ///   <para>earl:OutcomeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>a discrete value that describes a resulting condition from carrying out the test</para>
    /// labels<para>Outcome Value</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#OutcomeValue">http://www.w3.org/ns/earl#OutcomeValue</seealso>
    let OutcomeValue = Prefixed_Name(earl, "OutcomeValue") |> PrefixedName
    /// <summary>
    ///   <para>earl:Fail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>the class of outcomes to denote failing a test</para>
    /// labels<para>Fail</para></remarks>
    /// <seealso href="http://www.w3.org/ns/earl#Fail">http://www.w3.org/ns/earl#Fail</seealso>
    let Fail = Prefixed_Name(earl, "Fail") |> PrefixedName
