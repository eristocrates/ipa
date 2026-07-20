namespace http.courseware.rkbexplorer.com.ontologies.courseware.hash

open DoxAletheia

module courseware =
    let _namespace_name = "http://courseware.rkbexplorer.com/ontologies/courseware#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A method by which a student is assessed; instances of this class may include examination, coursework, etc.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#Assessment-Method"></see></summary>
    let ``Assessment-Method`` = _prefix "Assessment-Method"
    /// <summary>
    /// This class encapsulates a course that is taught to students
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#Course"></see></summary>
    let Course = _prefix "Course"
    /// <summary>
    /// This class encapsulates a body of previous knowledge required to undertake a course.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#Pre-requisite"></see></summary>
    let ``Pre-requisite`` = _prefix "Pre-requisite"
    /// <summary>
    /// A type of interaction in which a student engages whilst undertaking a course; instances of this class may include lectures, laboratory sessions, and group or individual projects.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#Student-Interaction-Type"></see></summary>
    let ``Student-Interaction-Type`` = _prefix "Student-Interaction-Type"
    /// <summary>
    /// The total duration of the course (in hours)
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#course-duration"></see></summary>
    let ``course-duration`` = _prefix "course-duration"
    /// <summary>
    /// The objectives of this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#course-objectives"></see></summary>
    let ``course-objectives`` = _prefix "course-objectives"
    /// <summary>
    /// A detailed description of the content conveyed within the course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#detailed-description"></see></summary>
    let ``detailed-description`` = _prefix "detailed-description"
    /// <summary>
    ///   <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-assessment-method"></see>
    /// </summary>
    let ``has-assessment-method`` = _prefix "has-assessment-method"
    /// <summary>
    /// A person which is involved with the creation of the course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-author"></see></summary>
    let ``has-author`` = _prefix "has-author"
    /// <summary>
    /// Courseware used by the Resist-Course (reference texts, personal hand-outs, slides, etc).
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-courseware"></see></summary>
    let ``has-courseware`` = _prefix "has-courseware"
    /// <summary>
    /// An infrastructure requirement that is needed to carry out the course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-infrastructure-requirement"></see></summary>
    let ``has-infrastructure-requirement`` = _prefix "has-infrastructure-requirement"
    /// <summary>
    /// A person delivering tuition as part of the course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-instructor"></see></summary>
    let ``has-instructor`` = _prefix "has-instructor"
    /// <summary>
    /// The language in which an item of abstract information is written, expressed or delivered.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-language"></see></summary>
    let ``has-language`` = _prefix "has-language"
    /// <summary>
    ///   <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-prerequisite"></see>
    /// </summary>
    let ``has-prerequisite`` = _prefix "has-prerequisite"
    /// <summary>
    /// This property describes the intellectual property rights and conditions of use for this learning object.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights"></see></summary>
    let ``has-rights`` = _prefix "has-rights"
    /// <summary>
    /// Whether copyright or other restrictions apply to the use of this learning resource.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-copyright"></see></summary>
    let ``has-rights-copyright`` = _prefix "has-rights-copyright"
    /// <summary>
    /// Whether use of this learning resource requires payment
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-cost"></see></summary>
    let ``has-rights-cost`` = _prefix "has-rights-cost"
    /// <summary>
    /// Comments on the conditions of use of this learning resource.
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-description"></see></summary>
    let ``has-rights-description`` = _prefix "has-rights-description"
    /// <summary>
    /// Identifies a course as having the prescribed interaction type
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-student-interaction-type"></see></summary>
    let ``has-student-interaction-type`` = _prefix "has-student-interaction-type"
    /// <summary>
    /// The title of this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#has-title"></see></summary>
    let ``has-title`` = _prefix "has-title"
    /// <summary>
    /// The total number of hours of laboratory sessions in this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-labs"></see></summary>
    let ``hours-of-labs`` = _prefix "hours-of-labs"
    /// <summary>
    /// The total number of hours of lectures delivered in this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-lectures"></see></summary>
    let ``hours-of-lectures`` = _prefix "hours-of-lectures"
    /// <summary>
    /// The total number of hours of personal study in this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-personal-study"></see></summary>
    let ``hours-of-personal-study`` = _prefix "hours-of-personal-study"
    /// <summary>
    /// The association of an organisation which is involved in delivering a course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#involves-organization"></see></summary>
    let ``involves-organization`` = _prefix "involves-organization"
    /// <summary>
    ///   <see href="http://courseware.rkbexplorer.com/ontologies/courseware#is-taught-present"></see>
    /// </summary>
    let ``is-taught-present`` = _prefix "is-taught-present"
    /// <summary>
    /// The number of EU BS/MS program credits
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#number-of-credits"></see></summary>
    let ``number-of-credits`` = _prefix "number-of-credits"
    /// <summary>
    /// The ReSIST Project member who has submitted and is the point of contact for this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#submitted-by"></see></summary>
    let ``submitted-by`` = _prefix "submitted-by"
    /// <summary>
    /// The organization at which this course is taught
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#taught-at"></see></summary>
    let ``taught-at`` = _prefix "taught-at"
    /// <summary>
    /// The total number of hours of engagement while undertaking this course
    /// <see href="http://courseware.rkbexplorer.com/ontologies/courseware#total-hours-engagement"></see></summary>
    let ``total-hours-engagement`` = _prefix "total-hours-engagement"
