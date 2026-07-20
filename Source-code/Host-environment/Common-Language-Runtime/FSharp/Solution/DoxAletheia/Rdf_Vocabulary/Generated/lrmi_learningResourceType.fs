namespace http.purl.org.dcx.lrmi_vocabs.learningResourceType.slash

open DoxAletheia

module lrmi_learningResourceType =
    let _namespace_name = "http://purl.org/dcx/lrmi-vocabs/learningResourceType/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/activityPlan"></see>
    /// </summary>
    let activityPlan = _prefix "activityPlan"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/assessment"></see>
    /// </summary>
    let assessment = _prefix "assessment"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/assessmentItem"></see>
    /// </summary>
    let assessmentItem = _prefix "assessmentItem"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/educatorCurriculumGuide"></see>
    /// </summary>
    let educatorCurriculumGuide = _prefix "educatorCurriculumGuide"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/lessonPlan"></see>
    /// </summary>
    let lessonPlan = _prefix "lessonPlan"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/physicalLearningResource"></see>
    /// </summary>
    let physicalLearningResource = _prefix "physicalLearningResource"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/recordedLesson"></see>
    /// </summary>
    let recordedLesson = _prefix "recordedLesson"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/supportingDocument"></see>
    /// </summary>
    let supportingDocument = _prefix "supportingDocument"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/textbook"></see>
    /// </summary>
    let textbook = _prefix "textbook"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/unitPlan"></see>
    /// </summary>
    let unitPlan = _prefix "unitPlan"
