namespace http.www.w3.org._2006._03.test_description.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module test_description =
    let _namespace_iri = Namespace_Iri test_description |> NamespaceIRI
    /// <summary>
    ///   <para>test-description:ReviewStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular stage in a review process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status in a review process"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#ReviewStatus">http://www.w3.org/2006/03/test-description#ReviewStatus</seealso>
    let ReviewStatus = Prefixed_Name(test_description, "ReviewStatus") |> PrefixedName

    /// <summary>
    ///   <para>test-description:SimpleReviewStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A status for a simple review process containing 6 possible stages"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#SimpleReviewStatus">http://www.w3.org/2006/03/test-description#SimpleReviewStatus</seealso>
    let SimpleReviewStatus =
        Prefixed_Name(test_description, "SimpleReviewStatus") |> PrefixedName

    /// <summary>
    ///   <para>test-description:SpecificationTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A test case which relates to a requirement set in a specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"A Test Case based on a specification"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#SpecificationTestCase">http://www.w3.org/2006/03/test-description#SpecificationTestCase</seealso>
    let SpecificationTestCase =
        Prefixed_Name(test_description, "SpecificationTestCase") |> PrefixedName

    /// <summary>
    ///   <para>test-description:TestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of test inputs, execution conditions, and expected results developed for a particular objective, such as to exercise a particular program path or to verify compliance with a specific requirement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"A Test Case"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#TestCase">http://www.w3.org/2006/03/test-description#TestCase</seealso>
    let TestCase = Prefixed_Name(test_description, "TestCase") |> PrefixedName
    /// <summary>
    ///   <para>test-description:accepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>test-description:ReviewStatus</para>
    ///   <para>"the item has gone through a first review, which shows it as valid for further processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"accepted"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#accepted">http://www.w3.org/2006/03/test-description#accepted</seealso>
    let accepted = Prefixed_Name(test_description, "accepted") |> PrefixedName
    /// <summary>
    ///   <para>test-description:approved</para>
    /// </summary>
    /// <remarks>
    ///   <para>test-description:ReviewStatus</para>
    ///   <para>"the item has gone through the review process and was approved"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"approved"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#approved">http://www.w3.org/2006/03/test-description#approved</seealso>
    let approved = Prefixed_Name(test_description, "approved") |> PrefixedName
    /// <summary>
    ///   <para>test-description:assigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>test-description:ReviewStatus</para>
    ///   <para>"a more specific review of the item has been assigned to someone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"assigned"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#assigned">http://www.w3.org/2006/03/test-description#assigned</seealso>
    let assigned = Prefixed_Name(test_description, "assigned") |> PrefixedName

    /// <summary>
    ///   <para>test-description:expectedResults</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The results that a conformant implementation is expected to produce when this test is executed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"expected results"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#expectedResults">http://www.w3.org/2006/03/test-description#expectedResults</seealso>
    let expectedResults =
        Prefixed_Name(test_description, "expectedResults") |> PrefixedName

    /// <summary>
    ///   <para>test-description:informationResourceInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information Resource (e.g. a file) used as input for the test case"</para>
    ///   <para>"Information Resource (e.g. a file) used as input for the test case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"information resource as input"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#informationResourceInput">http://www.w3.org/2006/03/test-description#informationResourceInput</seealso>
    let informationResourceInput =
        Prefixed_Name(test_description, "informationResourceInput") |> PrefixedName

    /// <summary>
    ///   <para>test-description:informationResourceResults</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information Resource (e.g. a file) that contains the expected results for the test case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"information resource as expected results"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#informationResourceResults">http://www.w3.org/2006/03/test-description#informationResourceResults</seealso>
    let informationResourceResults =
        Prefixed_Name(test_description, "informationResourceResults") |> PrefixedName

    /// <summary>
    ///   <para>test-description:input</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Parameters or data that are needed for the test execution."</para>
    /// labels<para>"input"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#input">http://www.w3.org/2006/03/test-description#input</seealso>
    let input = Prefixed_Name(test_description, "input") |> PrefixedName
    /// <summary>
    ///   <para>test-description:onhold</para>
    /// </summary>
    /// <remarks>
    ///   <para>test-description:ReviewStatus</para>
    ///   <para>"the item had already gone through the review process, but the results of the review need to be re-assessed due to new input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"on hold"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#onhold">http://www.w3.org/2006/03/test-description#onhold</seealso>
    let onhold = Prefixed_Name(test_description, "onhold") |> PrefixedName
    /// <summary>
    ///   <para>test-description:preCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"a condition that must be met before the test is executed"</para>
    /// labels<para>"precondition"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#preCondition">http://www.w3.org/2006/03/test-description#preCondition</seealso>
    let preCondition = Prefixed_Name(test_description, "preCondition") |> PrefixedName
    /// <summary>
    ///   <para>test-description:purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"purpose"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#purpose">http://www.w3.org/2006/03/test-description#purpose</seealso>
    let purpose = Prefixed_Name(test_description, "purpose") |> PrefixedName
    /// <summary>
    ///   <para>test-description:rejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>test-description:ReviewStatus</para>
    ///   <para>"the item has gone through the review process and was rejected"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rejected"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#rejected">http://www.w3.org/2006/03/test-description#rejected</seealso>
    let rejected = Prefixed_Name(test_description, "rejected") |> PrefixedName
    /// <summary>
    ///   <para>test-description:reviewStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"status of review"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#reviewStatus">http://www.w3.org/2006/03/test-description#reviewStatus</seealso>
    let reviewStatus = Prefixed_Name(test_description, "reviewStatus") |> PrefixedName

    /// <summary>
    ///   <para>test-description:specificationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"a description or a link of what part of which specification lead to the creation of this test case"</para>
    /// labels<para>"reference in specification"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#specificationReference">http://www.w3.org/2006/03/test-description#specificationReference</seealso>
    let specificationReference =
        Prefixed_Name(test_description, "specificationReference") |> PrefixedName

    /// <summary>
    ///   <para>test-description:unreviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>test-description:ReviewStatus</para>
    ///   <para>"the item has been proposed, but hasn't been reviewed (e.g. for completeness) yet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unreviewed"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/03/test-description#unreviewed">http://www.w3.org/2006/03/test-description#unreviewed</seealso>
    let unreviewed = Prefixed_Name(test_description, "unreviewed") |> PrefixedName
