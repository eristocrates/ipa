namespace http.courseware.rkbexplorer.com.ontologies.courseware.hash

open DoxAletheia.Rdf_Vocabulary

module courseware =
    let _namespace_name = "http://courseware.rkbexplorer.com/ontologies/courseware#"

    /// <summary>
    /// A method by which a student is assessed; instances of this class may include examination, coursework, etc.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#Assessment-Method"></see></summary>
    let ``Assessment-Method`` =
        Namespaced_IRI.parse _namespace_name "Assessment-Method" |> NamespacedName

    /// <summary>
    /// This class encapsulates a course that is taught to students
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#Course"></see></summary>
    let Course = Namespaced_IRI.parse _namespace_name "Course" |> NamespacedName

    /// <summary>
    /// This class encapsulates a body of previous knowledge required to undertake a course.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#Pre-requisite"></see></summary>
    let ``Pre-requisite`` =
        Namespaced_IRI.parse _namespace_name "Pre-requisite" |> NamespacedName

    /// <summary>
    /// A type of interaction in which a student engages whilst undertaking a course; instances of this class may include lectures, laboratory sessions, and group or individual projects.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#Student-Interaction-Type"></see></summary>
    let ``Student-Interaction-Type`` =
        Namespaced_IRI.parse _namespace_name "Student-Interaction-Type" |> NamespacedName

    /// <summary>
    /// The total duration of the course (in hours)
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#course-duration"></see></summary>
    let ``course-duration`` =
        Namespaced_IRI.parse _namespace_name "course-duration" |> NamespacedName

    /// <summary>
    /// The objectives of this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#course-objectives"></see></summary>
    let ``course-objectives`` =
        Namespaced_IRI.parse _namespace_name "course-objectives" |> NamespacedName

    /// <summary>
    /// A detailed description of the content conveyed within the course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#detailed-description"></see></summary>
    let ``detailed-description`` =
        Namespaced_IRI.parse _namespace_name "detailed-description" |> NamespacedName

    /// <summary>
    ///   <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-assessment-method"></see>
    /// </summary>
    let ``has-assessment-method`` =
        Namespaced_IRI.parse _namespace_name "has-assessment-method" |> NamespacedName

    /// <summary>
    /// A person which is involved with the creation of the course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-author"></see></summary>
    let ``has-author`` =
        Namespaced_IRI.parse _namespace_name "has-author" |> NamespacedName

    /// <summary>
    /// Courseware used by the Resist-Course (reference texts, personal hand-outs, slides, etc).
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-courseware"></see></summary>
    let ``has-courseware`` =
        Namespaced_IRI.parse _namespace_name "has-courseware" |> NamespacedName

    /// <summary>
    /// An infrastructure requirement that is needed to carry out the course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-infrastructure-requirement"></see></summary>
    let ``has-infrastructure-requirement`` =
        Namespaced_IRI.parse _namespace_name "has-infrastructure-requirement" |> NamespacedName

    /// <summary>
    /// A person delivering tuition as part of the course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-instructor"></see></summary>
    let ``has-instructor`` =
        Namespaced_IRI.parse _namespace_name "has-instructor" |> NamespacedName

    /// <summary>
    /// The language in which an item of abstract information is written, expressed or delivered.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-language"></see></summary>
    let ``has-language`` =
        Namespaced_IRI.parse _namespace_name "has-language" |> NamespacedName

    /// <summary>
    ///   <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-prerequisite"></see>
    /// </summary>
    let ``has-prerequisite`` =
        Namespaced_IRI.parse _namespace_name "has-prerequisite" |> NamespacedName

    /// <summary>
    /// This property describes the intellectual property rights and conditions of use for this learning object.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights"></see></summary>
    let ``has-rights`` =
        Namespaced_IRI.parse _namespace_name "has-rights" |> NamespacedName

    /// <summary>
    /// Whether copyright or other restrictions apply to the use of this learning resource.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-copyright"></see></summary>
    let ``has-rights-copyright`` =
        Namespaced_IRI.parse _namespace_name "has-rights-copyright" |> NamespacedName

    /// <summary>
    /// Whether use of this learning resource requires payment
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-cost"></see></summary>
    let ``has-rights-cost`` =
        Namespaced_IRI.parse _namespace_name "has-rights-cost" |> NamespacedName

    /// <summary>
    /// Comments on the conditions of use of this learning resource.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-description"></see></summary>
    let ``has-rights-description`` =
        Namespaced_IRI.parse _namespace_name "has-rights-description" |> NamespacedName

    /// <summary>
    /// Identifies a course as having the prescribed interaction type
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-student-interaction-type"></see></summary>
    let ``has-student-interaction-type`` =
        Namespaced_IRI.parse _namespace_name "has-student-interaction-type" |> NamespacedName

    /// <summary>
    /// The title of this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-title"></see></summary>
    let ``has-title`` =
        Namespaced_IRI.parse _namespace_name "has-title" |> NamespacedName

    /// <summary>
    /// The total number of hours of laboratory sessions in this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-labs"></see></summary>
    let ``hours-of-labs`` =
        Namespaced_IRI.parse _namespace_name "hours-of-labs" |> NamespacedName

    /// <summary>
    /// The total number of hours of lectures delivered in this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-lectures"></see></summary>
    let ``hours-of-lectures`` =
        Namespaced_IRI.parse _namespace_name "hours-of-lectures" |> NamespacedName

    /// <summary>
    /// The total number of hours of personal study in this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-personal-study"></see></summary>
    let ``hours-of-personal-study`` =
        Namespaced_IRI.parse _namespace_name "hours-of-personal-study" |> NamespacedName

    /// <summary>
    /// The association of an organisation which is involved in delivering a course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#involves-organization"></see></summary>
    let ``involves-organization`` =
        Namespaced_IRI.parse _namespace_name "involves-organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://courseware.rkbexplorer.com/ontologies/courseware#is-taught-present"></see>
    /// </summary>
    let ``is-taught-present`` =
        Namespaced_IRI.parse _namespace_name "is-taught-present" |> NamespacedName

    /// <summary>
    /// The number of EU BS/MS program credits
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#number-of-credits"></see></summary>
    let ``number-of-credits`` =
        Namespaced_IRI.parse _namespace_name "number-of-credits" |> NamespacedName

    /// <summary>
    /// The ReSIST Project member who has submitted and is the point of contact for this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#submitted-by"></see></summary>
    let ``submitted-by`` =
        Namespaced_IRI.parse _namespace_name "submitted-by" |> NamespacedName

    /// <summary>
    /// The organization at which this course is taught
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#taught-at"></see></summary>
    let ``taught-at`` =
        Namespaced_IRI.parse _namespace_name "taught-at" |> NamespacedName

    /// <summary>
    /// The total number of hours of engagement while undertaking this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#total-hours-engagement"></see></summary>
    let ``total-hours-engagement`` =
        Namespaced_IRI.parse _namespace_name "total-hours-engagement" |> NamespacedName
