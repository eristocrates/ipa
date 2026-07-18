namespace http.purl.org.dcx.lrmi_vocabs.learningResourceType.slash

open DoxAletheia.Rdf_Vocabulary

module lrmi_learningResourceType =
    let _namespace_name = "http://purl.org/dcx/lrmi-vocabs/learningResourceType/"

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/activityPlan"></see>
    /// </summary>
    let activityPlan =
        Namespaced_IRI.parse _namespace_name "activityPlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/assessment"></see>
    /// </summary>
    let assessment = Namespaced_IRI.parse _namespace_name "assessment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/assessmentItem"></see>
    /// </summary>
    let assessmentItem =
        Namespaced_IRI.parse _namespace_name "assessmentItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/educatorCurriculumGuide"></see>
    /// </summary>
    let educatorCurriculumGuide =
        Namespaced_IRI.parse _namespace_name "educatorCurriculumGuide" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/lessonPlan"></see>
    /// </summary>
    let lessonPlan = Namespaced_IRI.parse _namespace_name "lessonPlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/physicalLearningResource"></see>
    /// </summary>
    let physicalLearningResource =
        Namespaced_IRI.parse _namespace_name "physicalLearningResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/recordedLesson"></see>
    /// </summary>
    let recordedLesson =
        Namespaced_IRI.parse _namespace_name "recordedLesson" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/supportingDocument"></see>
    /// </summary>
    let supportingDocument =
        Namespaced_IRI.parse _namespace_name "supportingDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/textbook"></see>
    /// </summary>
    let textbook = Namespaced_IRI.parse _namespace_name "textbook" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/learningResourceType/unitPlan"></see>
    /// </summary>
    let unitPlan = Namespaced_IRI.parse _namespace_name "unitPlan" |> NamespacedName
