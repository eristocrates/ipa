namespace http.linkedscience.org.teach.ns.hash

open DoxAletheia.Rdf_Vocabulary

module teach =
    let _namespace_name = "http://linkedscience.org/teach/ns#"
    /// <summary>
    /// Assignment of a course, for example an exercise.
    ///
    /// <see href="http://linkedscience.org/teach/ns#Assignment"></see></summary>
    let Assignment = Namespaced_IRI.parse _namespace_name "Assignment" |> NamespacedName
    /// <summary>
    /// Building where the course is taking place.
    ///
    /// <see href="http://linkedscience.org/teach/ns#Building"></see></summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName
    /// <summary>
    /// Course is where students are supposed to learn something.
    ///
    /// <see href="http://linkedscience.org/teach/ns#Course"></see></summary>
    let Course = Namespaced_IRI.parse _namespace_name "Course" |> NamespacedName
    /// <summary>
    /// Lecture of the course.
    ///
    /// <see href="http://linkedscience.org/teach/ns#Lecture"></see></summary>
    let Lecture = Namespaced_IRI.parse _namespace_name "Lecture" |> NamespacedName
    /// <summary>
    /// Material of the course.
    ///
    /// <see href="http://linkedscience.org/teach/ns#Material"></see></summary>
    let Material = Namespaced_IRI.parse _namespace_name "Material" |> NamespacedName
    /// <summary>
    /// Module (i.e. a set of courses) which the course belongs to.
    ///
    /// <see href="http://linkedscience.org/teach/ns#Module"></see></summary>
    let Module = Namespaced_IRI.parse _namespace_name "Module" |> NamespacedName
    /// <summary>
    /// Room where the course is taking place.
    ///
    /// <see href="http://linkedscience.org/teach/ns#Room"></see></summary>
    let Room = Namespaced_IRI.parse _namespace_name "Room" |> NamespacedName
    /// <summary>
    /// Student of the course.
    ///
    /// <see href="http://linkedscience.org/teach/ns#Student"></see></summary>
    let Student = Namespaced_IRI.parse _namespace_name "Student" |> NamespacedName

    /// <summary>
    /// StudentGroup of the course.
    ///
    /// <see href="http://linkedscience.org/teach/ns#StudentGroup"></see></summary>
    let StudentGroup =
        Namespaced_IRI.parse _namespace_name "StudentGroup" |> NamespacedName

    /// <summary>
    /// StudyProgram which the course is part of.
    ///
    /// <see href="http://linkedscience.org/teach/ns#StudyProgram"></see></summary>
    let StudyProgram =
        Namespaced_IRI.parse _namespace_name "StudyProgram" |> NamespacedName

    /// <summary>
    /// Teacher of the course.
    ///
    /// <see href="http://linkedscience.org/teach/ns#Teacher"></see></summary>
    let Teacher = Namespaced_IRI.parse _namespace_name "Teacher" |> NamespacedName

    /// <summary>
    /// academicTerm is an abstract property to express the academic term (e.g. Summer 2011) of the course/seminar.
    /// <see href="http://linkedscience.org/teach/ns#academicTerm"></see></summary>
    let academicTerm =
        Namespaced_IRI.parse _namespace_name "academicTerm" |> NamespacedName

    /// <summary>
    /// arrangedAt is an abstract property to explicate the date/time when the seminar is arranged at. It can be defined as in the following example:
    ///   http://www.w3.org/TR/rdfcal/#L21805
    /// <see href="http://linkedscience.org/teach/ns#arrangedAt"></see></summary>
    let arrangedAt = Namespaced_IRI.parse _namespace_name "arrangedAt" |> NamespacedName

    /// <summary>
    /// bookingNumber is an abstract property to uniquely identify the course. This identifier should be defined and provided by the operator of the course.
    /// <see href="http://linkedscience.org/teach/ns#bookingNumber"></see></summary>
    let bookingNumber =
        Namespaced_IRI.parse _namespace_name "bookingNumber" |> NamespacedName

    /// <summary>
    /// building is an abstract property to express the building where the course/seminar takes place.
    /// <see href="http://linkedscience.org/teach/ns#building"></see></summary>
    let building = Namespaced_IRI.parse _namespace_name "building" |> NamespacedName

    /// <summary>
    /// courseDescription is subproperty of dc:description to specify the course description
    /// <see href="http://linkedscience.org/teach/ns#courseDescription"></see></summary>
    let courseDescription =
        Namespaced_IRI.parse _namespace_name "courseDescription" |> NamespacedName

    /// <summary>
    /// courseTitle is subproperty of dc:title to specify the course title
    /// <see href="http://linkedscience.org/teach/ns#courseTitle"></see></summary>
    let courseTitle =
        Namespaced_IRI.parse _namespace_name "courseTitle" |> NamespacedName

    /// <summary>
    /// deadline is an abstract property explicate the deadline for a draft project report.
    /// <see href="http://linkedscience.org/teach/ns#deadline"></see></summary>
    let deadline = Namespaced_IRI.parse _namespace_name "deadline" |> NamespacedName

    /// <summary>
    /// deadlineDraftReport is an abstract property explicate the deadline for a draft project report.
    /// <see href="http://linkedscience.org/teach/ns#deadlineDraftReport"></see></summary>
    let deadlineDraftReport =
        Namespaced_IRI.parse _namespace_name "deadlineDraftReport" |> NamespacedName

    /// <summary>
    /// deadlineFinalReport is an abstract property to explicate the deadline for a final project report.
    /// <see href="http://linkedscience.org/teach/ns#deadlineFinalReport"></see></summary>
    let deadlineFinalReport =
        Namespaced_IRI.parse _namespace_name "deadlineFinalReport" |> NamespacedName

    /// <summary>
    /// deadlineReviewReport is an abstract property to explicate the deadline for review reports (opponent works).
    /// <see href="http://linkedscience.org/teach/ns#deadlineReviewReport"></see></summary>
    let deadlineReviewReport =
        Namespaced_IRI.parse _namespace_name "deadlineReviewReport" |> NamespacedName

    /// <summary>
    /// ects is an abstract property to express the ects (European Credit Transfer System) of the course/seminar.
    /// <see href="http://linkedscience.org/teach/ns#ects"></see></summary>
    let ects = Namespaced_IRI.parse _namespace_name "ects" |> NamespacedName
    /// <summary>
    /// grading is an abstract property to relate the course/seminar to the description about its grading.
    /// <see href="http://linkedscience.org/teach/ns#grading"></see></summary>
    let grading = Namespaced_IRI.parse _namespace_name "grading" |> NamespacedName

    /// <summary>
    /// hasDescription is subproperty of dc:description to specify needed descriptions of entities within the course, e.g. the description of course materials, assignments, etc.
    /// <see href="http://linkedscience.org/teach/ns#hasDescription"></see></summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    /// Describes the teaching method used in the course/seminar. property "hasTeachingMethod" inspired by an interview of Nobel Laureate Carl Wieman in "Transformation Is Possible
    /// If a University Really Cares", SCIENCE, Vol 340, April 19th, 2013: "Wieman came up with his simple, market-driven first step: Require universities to compile and release data on their teaching methods as a condition for receiving federal research funds. As students began using the data released by universities to help choose a college, he reasoned, universities would feel compelled to improve their teaching practices in order to attract the best applicants." The idea is that with the hasTeachingMethod-property universities can start publishing the teaching methods they use as Linked Open Data. Let us see which university implements the idea first.
    /// <see href="http://linkedscience.org/teach/ns#hasTeachingMethod"></see></summary>
    let hasTeachingMethod =
        Namespaced_IRI.parse _namespace_name "hasTeachingMethod" |> NamespacedName

    /// <summary>
    /// hasTitle is subproperty of dc:title  to specify needed titles of entities within the course, e.g. the title of course materials, assignments, etc.
    /// <see href="http://linkedscience.org/teach/ns#hasTitle"></see></summary>
    let hasTitle = Namespaced_IRI.parse _namespace_name "hasTitle" |> NamespacedName
    /// <summary>
    /// Describes the module of the study program with which the course/seminar is associated.
    /// <see href="http://linkedscience.org/teach/ns#module"></see></summary>
    let module_ = Namespaced_IRI.parse _namespace_name "module" |> NamespacedName

    /// <summary>
    /// nextReading is an abstract property for dynamically stating the reading required to be read by the next session of the course/seminar.
    /// <see href="http://linkedscience.org/teach/ns#nextReading"></see></summary>
    let nextReading =
        Namespaced_IRI.parse _namespace_name "nextReading" |> NamespacedName

    /// <summary>
    /// notArrangedAt is an abstract property to explicate the date/time when the seminar has an exception in its schedule and thus is not arranged at.
    /// <see href="http://linkedscience.org/teach/ns#notArrangedAt"></see></summary>
    let notArrangedAt =
        Namespaced_IRI.parse _namespace_name "notArrangedAt" |> NamespacedName

    /// <summary>
    /// opponentOf is an abstract property to state that a student is an opponent of another, i.e. that he/she makes review of the other student's seminar work.
    /// <see href="http://linkedscience.org/teach/ns#opponentOf"></see></summary>
    let opponentOf = Namespaced_IRI.parse _namespace_name "opponentOf" |> NamespacedName
    /// <summary>
    /// reading is an abstract property to relate required readings to the course/seminar.
    /// <see href="http://linkedscience.org/teach/ns#reading"></see></summary>
    let reading = Namespaced_IRI.parse _namespace_name "reading" |> NamespacedName

    /// <summary>
    /// reportTemplate is an abstract property to relate a report template to the course/seminar so that students may use it to write their reports.
    /// <see href="http://linkedscience.org/teach/ns#reportTemplate"></see></summary>
    let reportTemplate =
        Namespaced_IRI.parse _namespace_name "reportTemplate" |> NamespacedName

    /// <summary>
    /// reviewTemplate is an abstract property to relate a review template to the course/seminar so that students may use it to write their reviews of other student's reports.
    /// <see href="http://linkedscience.org/teach/ns#reviewTemplate"></see></summary>
    let reviewTemplate =
        Namespaced_IRI.parse _namespace_name "reviewTemplate" |> NamespacedName

    /// <summary>
    /// room is an abstract property to express the room where the course/seminar takes place.
    /// <see href="http://linkedscience.org/teach/ns#room"></see></summary>
    let room = Namespaced_IRI.parse _namespace_name "room" |> NamespacedName

    /// <summary>
    /// studentGroup is an abstract property to relate a student group to the course/seminar.
    /// <see href="http://linkedscience.org/teach/ns#studentGroup"></see></summary>
    let studentGroup =
        Namespaced_IRI.parse _namespace_name "studentGroup" |> NamespacedName

    /// <summary>
    /// Describes the study program which is associated with the course/seminar.
    /// <see href="http://linkedscience.org/teach/ns#studyProgram"></see></summary>
    let studyProgram =
        Namespaced_IRI.parse _namespace_name "studyProgram" |> NamespacedName

    /// <summary>
    /// teacher is an abstract property to relate a teacher to a course/seminar.
    /// <see href="http://linkedscience.org/teach/ns#teacher"></see></summary>
    let teacher = Namespaced_IRI.parse _namespace_name "teacher" |> NamespacedName
    /// <summary>
    /// teacherOf is an abstract property to relate a teacher to a course/seminar.
    /// <see href="http://linkedscience.org/teach/ns#teacherOf"></see></summary>
    let teacherOf = Namespaced_IRI.parse _namespace_name "teacherOf" |> NamespacedName

    /// <summary>
    /// weeklyHours is an abstract property to express the number of weekly hours for the teaching.
    /// <see href="http://linkedscience.org/teach/ns#weeklyHours"></see></summary>
    let weeklyHours =
        Namespaced_IRI.parse _namespace_name "weeklyHours" |> NamespacedName
