namespace http.www.w3.org._2006._03.test_description.hash

open DoxAletheia

module test =
    let _namespace_name = "http://www.w3.org/2006/03/test-description#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A particular stage in a review process
    /// <see href="http://www.w3.org/2006/03/test-description#ReviewStatus"></see></summary>
    let ReviewStatus = _prefix "ReviewStatus"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/test-description#SimpleReviewStatus"></see>
    /// </summary>
    let SimpleReviewStatus = _prefix "SimpleReviewStatus"
    /// <summary>
    /// the item has been proposed, but hasn't been reviewed (e.g. for completeness) yet
    /// <see href="http://www.w3.org/2006/03/test-description#unreviewed"></see></summary>
    let unreviewed = _prefix "unreviewed"
    /// <summary>
    /// the item has gone through a first review, which shows it as valid for further processing
    /// <see href="http://www.w3.org/2006/03/test-description#accepted"></see></summary>
    let accepted = _prefix "accepted"
    /// <summary>
    /// a more specific review of the item has been assigned to someone
    /// <see href="http://www.w3.org/2006/03/test-description#assigned"></see></summary>
    let assigned = _prefix "assigned"
    /// <summary>
    /// the item has gone through the review process and was approved
    /// <see href="http://www.w3.org/2006/03/test-description#approved"></see></summary>
    let approved = _prefix "approved"
    /// <summary>
    /// the item has gone through the review process and was rejected
    /// <see href="http://www.w3.org/2006/03/test-description#rejected"></see></summary>
    let rejected = _prefix "rejected"
    /// <summary>
    /// the item had already gone through the review process, but the results of the review need to be re-assessed due to new input
    /// <see href="http://www.w3.org/2006/03/test-description#onhold"></see></summary>
    let onhold = _prefix "onhold"
    /// <summary>
    /// A test case which relates to a requirement set in a specification
    /// <see href="http://www.w3.org/2006/03/test-description#SpecificationTestCase"></see></summary>
    let SpecificationTestCase = _prefix "SpecificationTestCase"
    /// <summary>
    /// a description or a link of what part of which specification lead to the creation of this test case
    /// <see href="http://www.w3.org/2006/03/test-description#specificationReference"></see></summary>
    let specificationReference = _prefix "specificationReference"
    /// <summary>
    /// A set of test inputs, execution conditions, and expected results developed for a particular objective, such as to exercise a particular program path or to verify compliance with a specific requirement
    /// <see href="http://www.w3.org/2006/03/test-description#TestCase"></see></summary>
    let TestCase = _prefix "TestCase"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/test-description#purpose"></see>
    /// </summary>
    let purpose = _prefix "purpose"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/test-description#reviewStatus"></see>
    /// </summary>
    let reviewStatus = _prefix "reviewStatus"
    /// <summary>
    /// The results that a conformant implementation is expected to produce when this test is executed
    /// <see href="http://www.w3.org/2006/03/test-description#expectedResults"></see></summary>
    let expectedResults = _prefix "expectedResults"
    /// <summary>
    /// Information Resource (e.g. a file) used as input for the test case
    /// <see href="http://www.w3.org/2006/03/test-description#informationResourceInput"></see></summary>
    let informationResourceInput = _prefix "informationResourceInput"
    /// <summary>
    /// Parameters or data that are needed for the test execution.
    /// <see href="http://www.w3.org/2006/03/test-description#input"></see></summary>
    let input = _prefix "input"
    /// <summary>
    /// Information Resource (e.g. a file) that contains the expected results for the test case
    /// <see href="http://www.w3.org/2006/03/test-description#informationResourceResults"></see></summary>
    let informationResourceResults = _prefix "informationResourceResults"
    /// <summary>
    /// a condition that must be met before the test is executed
    /// <see href="http://www.w3.org/2006/03/test-description#preCondition"></see></summary>
    let preCondition = _prefix "preCondition"
