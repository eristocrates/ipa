#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module test =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2006/03/test-description#" "test"

    /// <summary>
    ///   <para>rdfs:label : Status in a review process</para>
    ///   <para>rdfs:comment : A particular stage in a review process^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#ReviewStatus">test:ReviewStatus</a>
    /// </summary>
    let ReviewStatus = _prefixId.prefix "ReviewStatus"
    /// <summary>
    ///   <para>rdfs:label : A status for a simple review process containing 6 possible stages</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#SimpleReviewStatus">test:SimpleReviewStatus</a>
    /// </summary>
    let SimpleReviewStatus = _prefixId.prefix "SimpleReviewStatus"
    /// <summary>
    ///   <para>rdfs:label : A Test Case based on a specification</para>
    ///   <para>rdfs:comment : A test case which relates to a requirement set in a specification^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#SpecificationTestCase">test:SpecificationTestCase</a>
    /// </summary>
    let SpecificationTestCase = _prefixId.prefix "SpecificationTestCase"
    /// <summary>
    ///   <para>rdfs:label : A Test Case</para>
    ///   <para>rdfs:comment : A set of test inputs, execution conditions, and expected results developed for a particular objective, such as to exercise a particular program path or to verify compliance with a specific requirement^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#TestCase">test:TestCase</a>
    /// </summary>
    let TestCase = _prefixId.prefix "TestCase"
    let accepted = _prefixId.prefix "accepted"
    let approved = _prefixId.prefix "approved"
    let assigned = _prefixId.prefix "assigned"
    /// <summary>
    ///   <para>rdfs:label : expected results</para>
    ///   <para>rdfs:comment : The results that a conformant implementation is expected to produce when this test is executed^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#expectedResults">test:expectedResults</a>
    /// </summary>
    let expectedResults = _prefixId.prefix "expectedResults"
    /// <summary>
    ///   <para>rdfs:label : information resource as input</para>
    ///   <para>rdfs:comment : Information Resource (e.g. a file) used as input for the test case</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#informationResourceInput">test:informationResourceInput</a>
    /// </summary>
    let informationResourceInput = _prefixId.prefix "informationResourceInput"
    /// <summary>
    ///   <para>rdfs:label : information resource as expected results</para>
    ///   <para>rdfs:comment : Information Resource (e.g. a file) that contains the expected results for the test case^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#informationResourceResults">test:informationResourceResults</a>
    /// </summary>
    let informationResourceResults = _prefixId.prefix "informationResourceResults"
    /// <summary>
    ///   <para>rdfs:label : input</para>
    ///   <para>rdfs:comment : Parameters or data that are needed for the test execution.</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#input">test:input</a>
    /// </summary>
    let input = _prefixId.prefix "input"
    let onhold = _prefixId.prefix "onhold"
    /// <summary>
    ///   <para>rdfs:label : precondition</para>
    ///   <para>rdfs:comment : a condition that must be met before the test is executed</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#preCondition">test:preCondition</a>
    /// </summary>
    let preCondition = _prefixId.prefix "preCondition"
    /// <summary>
    ///   <para>rdfs:label : purpose</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#purpose">test:purpose</a>
    /// </summary>
    let purpose = _prefixId.prefix "purpose"
    let rejected = _prefixId.prefix "rejected"
    /// <summary>
    ///   <para>rdfs:label : status of review</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#reviewStatus">test:reviewStatus</a>
    /// </summary>
    let reviewStatus = _prefixId.prefix "reviewStatus"
    /// <summary>
    ///   <para>rdfs:label : reference in specification</para>
    ///   <para>rdfs:comment : a description or a link of what part of which specification lead to the creation of this test case</para>
    ///   <a href="http://www.w3.org/2006/03/test-description#specificationReference">test:specificationReference</a>
    /// </summary>
    let specificationReference = _prefixId.prefix "specificationReference"
    let unreviewed = _prefixId.prefix "unreviewed"
