#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module crsw =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://courseware.rkbexplorer.com/ontologies/courseware#" "crsw"

    /// <summary>
    ///   <para>rdfs:label : Assessment Method^^xsd:string</para>
    ///   <para>rdfs:comment : A method by which a student is assessed; instances of this class may include examination, coursework, etc.^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#Assessment-Method">crsw:Assessment-Method</a>
    /// </summary>
    let Assessment_Method = _prefixId.prefix "Assessment-Method"
    /// <summary>
    ///   <para>rdfs:label : Course^^xsd:string</para>
    ///   <para>rdfs:comment : This class encapsulates a course that is taught to students^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#Course">crsw:Course</a>
    /// </summary>
    let Course = _prefixId.prefix "Course"
    /// <summary>
    ///   <para>rdfs:label : Pre-requisite^^xsd:string</para>
    ///   <para>rdfs:comment : This class encapsulates a body of previous knowledge required to undertake a course.^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#Pre-requisite">crsw:Pre-requisite</a>
    /// </summary>
    let Pre_requisite = _prefixId.prefix "Pre-requisite"
    /// <summary>
    ///   <para>rdfs:label : Student Interaction Type^^xsd:string</para>
    ///   <para>rdfs:comment : A type of interaction in which a student engages whilst undertaking a course; instances of this class may include lectures, laboratory sessions, and group or individual projects.^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#Student-Interaction-Type">crsw:Student-Interaction-Type</a>
    /// </summary>
    let Student_Interaction_Type = _prefixId.prefix "Student-Interaction-Type"
    /// <summary>
    ///   <para>rdfs:label : course duration^^xsd:string</para>
    ///   <para>rdfs:comment : The total duration of the course (in hours)^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#course-duration">crsw:course-duration</a>
    /// </summary>
    let course_duration = _prefixId.prefix "course-duration"
    /// <summary>
    ///   <para>rdfs:label : course objectives^^xsd:string</para>
    ///   <para>rdfs:comment : The objectives of this course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#course-objectives">crsw:course-objectives</a>
    /// </summary>
    let course_objectives = _prefixId.prefix "course-objectives"
    /// <summary>
    ///   <para>rdfs:label : detailed description^^xsd:string</para>
    ///   <para>rdfs:comment : A detailed description of the content conveyed within the course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#detailed-description">crsw:detailed-description</a>
    /// </summary>
    let detailed_description = _prefixId.prefix "detailed-description"
    /// <summary>
    ///   <para>rdfs:label : has assessment method^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-assessment-method">crsw:has-assessment-method</a>
    /// </summary>
    let has_assessment_method = _prefixId.prefix "has-assessment-method"
    /// <summary>
    ///   <para>rdfs:label : has author^^xsd:string</para>
    ///   <para>rdfs:comment : A person which is involved with the creation of the course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-author">crsw:has-author</a>
    /// </summary>
    let has_author = _prefixId.prefix "has-author"
    /// <summary>
    ///   <para>rdfs:label : has courseware^^xsd:string</para>
    ///   <para>rdfs:comment : Courseware used by the Resist-Course (reference texts, personal hand-outs, slides, etc).^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-courseware">crsw:has-courseware</a>
    /// </summary>
    let has_courseware = _prefixId.prefix "has-courseware"

    /// <summary>
    ///   <para>rdfs:label : has infrastructure requirement^^xsd:string</para>
    ///   <para>rdfs:comment : An infrastructure requirement that is needed to carry out the course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-infrastructure-requirement">crsw:has-infrastructure-requirement</a>
    /// </summary>
    let has_infrastructure_requirement =
        _prefixId.prefix "has-infrastructure-requirement"

    /// <summary>
    ///   <para>rdfs:label : has instructor^^xsd:string</para>
    ///   <para>rdfs:comment : A person delivering tuition as part of the course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-instructor">crsw:has-instructor</a>
    /// </summary>
    let has_instructor = _prefixId.prefix "has-instructor"
    /// <summary>
    ///   <para>rdfs:label : has language^^xsd:string</para>
    ///   <para>rdfs:comment : The language in which an item of abstract information is written, expressed or delivered.^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-language">crsw:has-language</a>
    /// </summary>
    let has_language = _prefixId.prefix "has-language"
    /// <summary>
    ///   <para>rdfs:label : has pre-requisite^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-prerequisite">crsw:has-prerequisite</a>
    /// </summary>
    let has_prerequisite = _prefixId.prefix "has-prerequisite"
    /// <summary>
    ///   <para>rdfs:comment : This property describes the intellectual property rights and conditions of use for this learning object. ^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights">crsw:has-rights</a>
    /// </summary>
    let has_rights = _prefixId.prefix "has-rights"
    /// <summary>
    ///   <para>rdfs:comment : Whether copyright or other restrictions apply to the use of this learning resource.^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-copyright">crsw:has-rights-copyright</a>
    /// </summary>
    let has_rights_copyright = _prefixId.prefix "has-rights-copyright"
    /// <summary>
    ///   <para>rdfs:comment : Whether use of this learning resource requires payment^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-cost">crsw:has-rights-cost</a>
    /// </summary>
    let has_rights_cost = _prefixId.prefix "has-rights-cost"
    /// <summary>
    ///   <para>rdfs:comment : Comments on the conditions of use of this learning resource.^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-rights-description">crsw:has-rights-description</a>
    /// </summary>
    let has_rights_description = _prefixId.prefix "has-rights-description"
    /// <summary>
    ///   <para>rdfs:label : has student interaction type^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies a course as having the prescribed interaction type^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-student-interaction-type">crsw:has-student-interaction-type</a>
    /// </summary>
    let has_student_interaction_type = _prefixId.prefix "has-student-interaction-type"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>rdfs:comment : The title of this course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#has-title">crsw:has-title</a>
    /// </summary>
    let has_title = _prefixId.prefix "has-title"
    /// <summary>
    ///   <para>rdfs:label : hours of labs^^xsd:string</para>
    ///   <para>rdfs:comment : The total number of hours of laboratory sessions in this course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-labs">crsw:hours-of-labs</a>
    /// </summary>
    let hours_of_labs = _prefixId.prefix "hours-of-labs"
    /// <summary>
    ///   <para>rdfs:label : hours of lectures^^xsd:string</para>
    ///   <para>rdfs:comment : The total number of hours of lectures delivered in this course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-lectures">crsw:hours-of-lectures</a>
    /// </summary>
    let hours_of_lectures = _prefixId.prefix "hours-of-lectures"
    /// <summary>
    ///   <para>rdfs:label : hours of personal study^^xsd:string</para>
    ///   <para>rdfs:comment : The total number of hours of personal study in this course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#hours-of-personal-study">crsw:hours-of-personal-study</a>
    /// </summary>
    let hours_of_personal_study = _prefixId.prefix "hours-of-personal-study"
    /// <summary>
    ///   <para>rdfs:label : involves organisation^^xsd:string</para>
    ///   <para>rdfs:comment : The association of an organisation which is involved in delivering a course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#involves-organization">crsw:involves-organization</a>
    /// </summary>
    let involves_organization = _prefixId.prefix "involves-organization"
    let is_taught_present = _prefixId.prefix "is-taught-present"
    /// <summary>
    ///   <para>rdfs:label : number of credits^^xsd:string</para>
    ///   <para>rdfs:comment : The number of EU BS/MS program credits^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#number-of-credits">crsw:number-of-credits</a>
    /// </summary>
    let number_of_credits = _prefixId.prefix "number-of-credits"
    /// <summary>
    ///   <para>rdfs:label : submitted by^^xsd:string</para>
    ///   <para>rdfs:comment : The ReSIST Project member who has submitted and is the point of contact for this course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#submitted-by">crsw:submitted-by</a>
    /// </summary>
    let submitted_by = _prefixId.prefix "submitted-by"
    /// <summary>
    ///   <para>rdfs:label : taught at^^xsd:string</para>
    ///   <para>rdfs:comment : The organization at which this course is taught^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#taught-at">crsw:taught-at</a>
    /// </summary>
    let taught_at = _prefixId.prefix "taught-at"
    /// <summary>
    ///   <para>rdfs:label : total hours of engagement^^xsd:string</para>
    ///   <para>rdfs:comment : The total number of hours of engagement while undertaking this course^^xsd:string</para>
    ///   <a href="http://courseware.rkbexplorer.com/ontologies/courseware#total-hours-engagement">crsw:total-hours-engagement</a>
    /// </summary>
    let total_hours_engagement = _prefixId.prefix "total-hours-engagement"
