namespace http.purl.org.dcx.lrmi_vocabs.learningResourceType.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lrmilearningResourceType =
    let _namespace_iri = Namespace_Iri lrmilearningResourceType |> NamespaceIRI
    /// <summary>
    ///   <para>lrmilearningResourceType:</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/">http://purl.org/dcx/lrmi-vocabs/learningResourceType/</seealso>
    let _prefix_iri = Prefixed_Name(lrmilearningResourceType, "") |> PrefixedName

    /// <summary>
    ///   <para>lrmilearningResourceType:activityPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/activityPlan">http://purl.org/dcx/lrmi-vocabs/learningResourceType/activityPlan</seealso>
    let activityPlan =
        Prefixed_Name(lrmilearningResourceType, "activityPlan") |> PrefixedName

    /// <summary>
    ///   <para>lrmilearningResourceType:assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/assessment">http://purl.org/dcx/lrmi-vocabs/learningResourceType/assessment</seealso>
    let assessment =
        Prefixed_Name(lrmilearningResourceType, "assessment") |> PrefixedName

    /// <summary>
    ///   <para>lrmilearningResourceType:assessmentItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/assessmentItem">http://purl.org/dcx/lrmi-vocabs/learningResourceType/assessmentItem</seealso>
    let assessmentItem =
        Prefixed_Name(lrmilearningResourceType, "assessmentItem") |> PrefixedName

    /// <summary>
    ///   <para>lrmilearningResourceType:educatorCurriculumGuide</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/educatorCurriculumGuide">http://purl.org/dcx/lrmi-vocabs/learningResourceType/educatorCurriculumGuide</seealso>
    let educatorCurriculumGuide =
        Prefixed_Name(lrmilearningResourceType, "educatorCurriculumGuide") |> PrefixedName

    /// <summary>
    ///   <para>lrmilearningResourceType:lessonPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/lessonPlan">http://purl.org/dcx/lrmi-vocabs/learningResourceType/lessonPlan</seealso>
    let lessonPlan =
        Prefixed_Name(lrmilearningResourceType, "lessonPlan") |> PrefixedName

    /// <summary>
    ///   <para>lrmilearningResourceType:physicalLearningResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/physicalLearningResource">http://purl.org/dcx/lrmi-vocabs/learningResourceType/physicalLearningResource</seealso>
    let physicalLearningResource =
        Prefixed_Name(lrmilearningResourceType, "physicalLearningResource") |> PrefixedName

    /// <summary>
    ///   <para>lrmilearningResourceType:recordedLesson</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/recordedLesson">http://purl.org/dcx/lrmi-vocabs/learningResourceType/recordedLesson</seealso>
    let recordedLesson =
        Prefixed_Name(lrmilearningResourceType, "recordedLesson") |> PrefixedName

    /// <summary>
    ///   <para>lrmilearningResourceType:supportingDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/supportingDocument">http://purl.org/dcx/lrmi-vocabs/learningResourceType/supportingDocument</seealso>
    let supportingDocument =
        Prefixed_Name(lrmilearningResourceType, "supportingDocument") |> PrefixedName

    /// <summary>
    ///   <para>lrmilearningResourceType:textbook</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/textbook">http://purl.org/dcx/lrmi-vocabs/learningResourceType/textbook</seealso>
    let textbook = Prefixed_Name(lrmilearningResourceType, "textbook") |> PrefixedName
    /// <summary>
    ///   <para>lrmilearningResourceType:unitPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/unitPlan">http://purl.org/dcx/lrmi-vocabs/learningResourceType/unitPlan</seealso>
    let unitPlan = Prefixed_Name(lrmilearningResourceType, "unitPlan") |> PrefixedName
