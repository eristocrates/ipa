namespace http.www.w3.org._2006._03.test_description.hash

open DoxAletheia.Rdf_Vocabulary

module test =
    let _namespace_name = "http://www.w3.org/2006/03/test-description#"

    /// <summary>
    /// A particular stage in a review process
    /// <see href="http://www.w3.org/2006/03/test-description#ReviewStatus"></see></summary>
    let ReviewStatus =
        Namespaced_IRI.parse _namespace_name "ReviewStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/test-description#SimpleReviewStatus"></see>
    /// </summary>
    let SimpleReviewStatus =
        Namespaced_IRI.parse _namespace_name "SimpleReviewStatus" |> NamespacedName

    /// <summary>
    /// the item has been proposed, but hasn't been reviewed (e.g. for completeness) yet
    /// <see href="http://www.w3.org/2006/03/test-description#unreviewed"></see></summary>
    let unreviewed = Namespaced_IRI.parse _namespace_name "unreviewed" |> NamespacedName
    /// <summary>
    /// the item has gone through a first review, which shows it as valid for further processing
    /// <see href="http://www.w3.org/2006/03/test-description#accepted"></see></summary>
    let accepted = Namespaced_IRI.parse _namespace_name "accepted" |> NamespacedName
    /// <summary>
    /// a more specific review of the item has been assigned to someone
    /// <see href="http://www.w3.org/2006/03/test-description#assigned"></see></summary>
    let assigned = Namespaced_IRI.parse _namespace_name "assigned" |> NamespacedName
    /// <summary>
    /// the item has gone through the review process and was approved
    /// <see href="http://www.w3.org/2006/03/test-description#approved"></see></summary>
    let approved = Namespaced_IRI.parse _namespace_name "approved" |> NamespacedName
    /// <summary>
    /// the item has gone through the review process and was rejected
    /// <see href="http://www.w3.org/2006/03/test-description#rejected"></see></summary>
    let rejected = Namespaced_IRI.parse _namespace_name "rejected" |> NamespacedName
    /// <summary>
    /// the item had already gone through the review process, but the results of the review need to be re-assessed due to new input
    /// <see href="http://www.w3.org/2006/03/test-description#onhold"></see></summary>
    let onhold = Namespaced_IRI.parse _namespace_name "onhold" |> NamespacedName

    /// <summary>
    /// A test case which relates to a requirement set in a specification
    /// <see href="http://www.w3.org/2006/03/test-description#SpecificationTestCase"></see></summary>
    let SpecificationTestCase =
        Namespaced_IRI.parse _namespace_name "SpecificationTestCase" |> NamespacedName

    /// <summary>
    /// a description or a link of what part of which specification lead to the creation of this test case
    /// <see href="http://www.w3.org/2006/03/test-description#specificationReference"></see></summary>
    let specificationReference =
        Namespaced_IRI.parse _namespace_name "specificationReference" |> NamespacedName

    /// <summary>
    /// A set of test inputs, execution conditions, and expected results developed for a particular objective, such as to exercise a particular program path or to verify compliance with a specific requirement
    /// <see href="http://www.w3.org/2006/03/test-description#TestCase"></see></summary>
    let TestCase = Namespaced_IRI.parse _namespace_name "TestCase" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/test-description#purpose"></see>
    /// </summary>
    let purpose = Namespaced_IRI.parse _namespace_name "purpose" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/test-description#reviewStatus"></see>
    /// </summary>
    let reviewStatus =
        Namespaced_IRI.parse _namespace_name "reviewStatus" |> NamespacedName

    /// <summary>
    /// The results that a conformant implementation is expected to produce when this test is executed
    /// <see href="http://www.w3.org/2006/03/test-description#expectedResults"></see></summary>
    let expectedResults =
        Namespaced_IRI.parse _namespace_name "expectedResults" |> NamespacedName

    /// <summary>
    /// Information Resource (e.g. a file) used as input for the test case
    /// <see href="http://www.w3.org/2006/03/test-description#informationResourceInput"></see></summary>
    let informationResourceInput =
        Namespaced_IRI.parse _namespace_name "informationResourceInput" |> NamespacedName

    /// <summary>
    /// Parameters or data that are needed for the test execution.
    /// <see href="http://www.w3.org/2006/03/test-description#input"></see></summary>
    let input = Namespaced_IRI.parse _namespace_name "input" |> NamespacedName

    /// <summary>
    /// Information Resource (e.g. a file) that contains the expected results for the test case
    /// <see href="http://www.w3.org/2006/03/test-description#informationResourceResults"></see></summary>
    let informationResourceResults =
        Namespaced_IRI.parse _namespace_name "informationResourceResults" |> NamespacedName

    /// <summary>
    /// a condition that must be met before the test is executed
    /// <see href="http://www.w3.org/2006/03/test-description#preCondition"></see></summary>
    let preCondition =
        Namespaced_IRI.parse _namespace_name "preCondition" |> NamespacedName
