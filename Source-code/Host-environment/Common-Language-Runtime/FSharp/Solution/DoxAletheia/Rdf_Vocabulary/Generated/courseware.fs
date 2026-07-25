namespace http.courseware.rkbexplorer.com.ontologies.courseware.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module courseware =
    let _namespace_iri = Namespace_Iri courseware |> NamespaceIRI
    /// <summary>
    ///   <para>courseware:Pre-requisite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class encapsulates a body of previous knowledge required to undertake a course.</para>
    /// labels<para>Pre-requisite</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#Pre-requisite">http://courseware.rkbexplorer.com/ontologies/courseware#Pre-requisite</seealso>
    let Pre_requisite = Prefixed_Name(courseware, "Pre-requisite") |> PrefixedName

    /// <summary>
    ///   <para>courseware:Student-Interaction-Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of interaction in which a student engages whilst undertaking a course; instances of this class may include lectures, laboratory sessions, and group or individual projects.</para>
    /// labels<para>Student Interaction Type</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#Student-Interaction-Type">http://courseware.rkbexplorer.com/ontologies/courseware#Student-Interaction-Type</seealso>
    let Student_Interaction_Type =
        Prefixed_Name(courseware, "Student-Interaction-Type") |> PrefixedName

    /// <summary>
    ///   <para>courseware:hours-of-lectures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of hours of lectures delivered in this course</para>
    /// labels<para>hours of lectures</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-lectures">http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-lectures</seealso>
    let hours_of_lectures =
        Prefixed_Name(courseware, "hours-of-lectures") |> PrefixedName

    /// <summary>
    ///   <para>courseware:Assessment-Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A method by which a student is assessed; instances of this class may include examination, coursework, etc.</para>
    /// labels<para>Assessment Method</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#Assessment-Method">http://courseware.rkbexplorer.com/ontologies/courseware#Assessment-Method</seealso>
    let Assessment_Method =
        Prefixed_Name(courseware, "Assessment-Method") |> PrefixedName

    /// <summary>
    ///   <para>courseware:has-author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person which is involved with the creation of the course</para>
    /// labels<para>has author</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-author">http://courseware.rkbexplorer.com/ontologies/courseware#has-author</seealso>
    let has_author = Prefixed_Name(courseware, "has-author") |> PrefixedName
    /// <summary>
    ///   <para>courseware:has-courseware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Courseware used by the Resist-Course (reference texts, personal hand-outs, slides, etc).</para>
    /// labels<para>has courseware</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-courseware">http://courseware.rkbexplorer.com/ontologies/courseware#has-courseware</seealso>
    let has_courseware = Prefixed_Name(courseware, "has-courseware") |> PrefixedName

    /// <summary>
    ///   <para>courseware:has-infrastructure-requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An infrastructure requirement that is needed to carry out the course</para>
    /// labels<para>has infrastructure requirement</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-infrastructure-requirement">http://courseware.rkbexplorer.com/ontologies/courseware#has-infrastructure-requirement</seealso>
    let has_infrastructure_requirement =
        Prefixed_Name(courseware, "has-infrastructure-requirement") |> PrefixedName

    /// <summary>
    ///   <para>courseware:has-instructor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person delivering tuition as part of the course</para>
    /// labels<para>has instructor</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-instructor">http://courseware.rkbexplorer.com/ontologies/courseware#has-instructor</seealso>
    let has_instructor = Prefixed_Name(courseware, "has-instructor") |> PrefixedName
    /// <summary>
    ///   <para>courseware:has-language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The language in which an item of abstract information is written, expressed or delivered.</para>
    /// labels<para>has language</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-language">http://courseware.rkbexplorer.com/ontologies/courseware#has-language</seealso>
    let has_language = Prefixed_Name(courseware, "has-language") |> PrefixedName
    /// <summary>
    ///   <para>courseware:has-prerequisite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has pre-requisite</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-prerequisite">http://courseware.rkbexplorer.com/ontologies/courseware#has-prerequisite</seealso>
    let has_prerequisite = Prefixed_Name(courseware, "has-prerequisite") |> PrefixedName
    /// <summary>
    ///   <para>courseware:has-rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property describes the intellectual property rights and conditions of use for this learning object. </para>
    /// </remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights">http://courseware.rkbexplorer.com/ontologies/courseware#has-rights</seealso>
    let has_rights = Prefixed_Name(courseware, "has-rights") |> PrefixedName
    /// <summary>
    ///   <para>courseware:has-rights-cost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether use of this learning resource requires payment</para>
    /// </remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-cost">http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-cost</seealso>
    let has_rights_cost = Prefixed_Name(courseware, "has-rights-cost") |> PrefixedName

    /// <summary>
    ///   <para>courseware:has-rights-description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Comments on the conditions of use of this learning resource.</para>
    /// </remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-description">http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-description</seealso>
    let has_rights_description =
        Prefixed_Name(courseware, "has-rights-description") |> PrefixedName

    /// <summary>
    ///   <para>courseware:has-student-interaction-type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies a course as having the prescribed interaction type</para>
    /// labels<para>has student interaction type</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-student-interaction-type">http://courseware.rkbexplorer.com/ontologies/courseware#has-student-interaction-type</seealso>
    let has_student_interaction_type =
        Prefixed_Name(courseware, "has-student-interaction-type") |> PrefixedName

    /// <summary>
    ///   <para>courseware:hours-of-labs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of hours of laboratory sessions in this course</para>
    /// labels<para>hours of labs</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-labs">http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-labs</seealso>
    let hours_of_labs = Prefixed_Name(courseware, "hours-of-labs") |> PrefixedName

    /// <summary>
    ///   <para>courseware:is-taught-present</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#is-taught-present">http://courseware.rkbexplorer.com/ontologies/courseware#is-taught-present</seealso>
    let is_taught_present =
        Prefixed_Name(courseware, "is-taught-present") |> PrefixedName

    /// <summary>
    ///   <para>courseware:submitted-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ReSIST Project member who has submitted and is the point of contact for this course</para>
    /// labels<para>submitted by</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#submitted-by">http://courseware.rkbexplorer.com/ontologies/courseware#submitted-by</seealso>
    let submitted_by = Prefixed_Name(courseware, "submitted-by") |> PrefixedName

    /// <summary>
    ///   <para>courseware:total-hours-engagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of hours of engagement while undertaking this course</para>
    /// labels<para>total hours of engagement</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#total-hours-engagement">http://courseware.rkbexplorer.com/ontologies/courseware#total-hours-engagement</seealso>
    let total_hours_engagement =
        Prefixed_Name(courseware, "total-hours-engagement") |> PrefixedName

    /// <summary>
    ///   <para>courseware:course-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total duration of the course (in hours)</para>
    /// labels<para>course duration</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#course-duration">http://courseware.rkbexplorer.com/ontologies/courseware#course-duration</seealso>
    let course_duration = Prefixed_Name(courseware, "course-duration") |> PrefixedName

    /// <summary>
    ///   <para>courseware:detailed-description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A detailed description of the content conveyed within the course</para>
    /// labels<para>detailed description</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#detailed-description">http://courseware.rkbexplorer.com/ontologies/courseware#detailed-description</seealso>
    let detailed_description =
        Prefixed_Name(courseware, "detailed-description") |> PrefixedName

    /// <summary>
    ///   <para>courseware:course-objectives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The objectives of this course</para>
    /// labels<para>course objectives</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#course-objectives">http://courseware.rkbexplorer.com/ontologies/courseware#course-objectives</seealso>
    let course_objectives =
        Prefixed_Name(courseware, "course-objectives") |> PrefixedName

    /// <summary>
    ///   <para>courseware:has-assessment-method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has assessment method</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-assessment-method">http://courseware.rkbexplorer.com/ontologies/courseware#has-assessment-method</seealso>
    let has_assessment_method =
        Prefixed_Name(courseware, "has-assessment-method") |> PrefixedName

    /// <summary>
    ///   <para>courseware:has-rights-copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether copyright or other restrictions apply to the use of this learning resource.</para>
    /// </remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-copyright">http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-copyright</seealso>
    let has_rights_copyright =
        Prefixed_Name(courseware, "has-rights-copyright") |> PrefixedName

    /// <summary>
    ///   <para>courseware:has-title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The title of this course</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#has-title">http://courseware.rkbexplorer.com/ontologies/courseware#has-title</seealso>
    let has_title = Prefixed_Name(courseware, "has-title") |> PrefixedName

    /// <summary>
    ///   <para>courseware:hours-of-personal-study</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of hours of personal study in this course</para>
    /// labels<para>hours of personal study</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-personal-study">http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-personal-study</seealso>
    let hours_of_personal_study =
        Prefixed_Name(courseware, "hours-of-personal-study") |> PrefixedName

    /// <summary>
    ///   <para>courseware:number-of-credits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of EU BS/MS program credits</para>
    /// labels<para>number of credits</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#number-of-credits">http://courseware.rkbexplorer.com/ontologies/courseware#number-of-credits</seealso>
    let number_of_credits =
        Prefixed_Name(courseware, "number-of-credits") |> PrefixedName

    /// <summary>
    ///   <para>courseware:taught-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The organization at which this course is taught</para>
    /// labels<para>taught at</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#taught-at">http://courseware.rkbexplorer.com/ontologies/courseware#taught-at</seealso>
    let taught_at = Prefixed_Name(courseware, "taught-at") |> PrefixedName

    /// <summary>
    ///   <para>courseware:involves-organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The association of an organisation which is involved in delivering a course</para>
    /// labels<para>involves organisation</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#involves-organization">http://courseware.rkbexplorer.com/ontologies/courseware#involves-organization</seealso>
    let involves_organization =
        Prefixed_Name(courseware, "involves-organization") |> PrefixedName

    /// <summary>
    ///   <para>courseware:Course</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class encapsulates a course that is taught to students</para>
    /// labels<para>Course</para></remarks>
    /// <seealso href="http://courseware.rkbexplorer.com/ontologies/courseware#Course">http://courseware.rkbexplorer.com/ontologies/courseware#Course</seealso>
    let Course = Prefixed_Name(courseware, "Course") |> PrefixedName
