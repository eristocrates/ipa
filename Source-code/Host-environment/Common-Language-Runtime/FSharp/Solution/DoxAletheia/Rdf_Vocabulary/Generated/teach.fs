namespace http.linkedscience.org.teach.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module teach =
    let _namespace_iri = Namespace_Iri teach |> NamespaceIRI
    /// <summary>
    ///   <para>teach:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>hartigprov:DataItem</para>
    ///   <para>hartigprov:DataCreation</para>
    /// </remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#">http://linkedscience.org/teach/ns#</seealso>
    let _prefix_iri = Prefixed_Name(teach, "") |> PrefixedName
    /// <summary>
    ///   <para>teach:Assignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Assignment of a course, for example an exercise.
    /// "</para>
    /// labels<para>"Assignment"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#Assignment">http://linkedscience.org/teach/ns#Assignment</seealso>
    let Assignment = Prefixed_Name(teach, "Assignment") |> PrefixedName
    /// <summary>
    ///   <para>teach:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Building where the course is taking place.
    /// "</para>
    /// labels<para>"Building"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#Building">http://linkedscience.org/teach/ns#Building</seealso>
    let Building = Prefixed_Name(teach, "Building") |> PrefixedName
    /// <summary>
    ///   <para>teach:Course</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Course is where students are supposed to learn something.
    /// "</para>
    /// labels<para>"Course"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#Course">http://linkedscience.org/teach/ns#Course</seealso>
    let Course = Prefixed_Name(teach, "Course") |> PrefixedName
    /// <summary>
    ///   <para>teach:Lecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lecture of the course.
    /// "</para>
    /// labels<para>"Lecture"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#Lecture">http://linkedscience.org/teach/ns#Lecture</seealso>
    let Lecture = Prefixed_Name(teach, "Lecture") |> PrefixedName
    /// <summary>
    ///   <para>teach:Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Material of the course.
    /// "</para>
    /// labels<para>"Material"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#Material">http://linkedscience.org/teach/ns#Material</seealso>
    let Material = Prefixed_Name(teach, "Material") |> PrefixedName
    /// <summary>
    ///   <para>teach:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A method used in a scientific research."</para>
    /// labels<para>"Method"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#Method">http://linkedscience.org/teach/ns#Method</seealso>
    let Method = Prefixed_Name(teach, "Method") |> PrefixedName
    /// <summary>
    ///   <para>teach:Module</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Module (i.e. a set of courses) which the course belongs to.
    /// "</para>
    /// labels<para>"Module"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#Module">http://linkedscience.org/teach/ns#Module</seealso>
    let Module = Prefixed_Name(teach, "Module") |> PrefixedName
    /// <summary>
    ///   <para>teach:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Room where the course is taking place.
    /// "</para>
    /// labels<para>"Room"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#Room">http://linkedscience.org/teach/ns#Room</seealso>
    let Room = Prefixed_Name(teach, "Room") |> PrefixedName
    /// <summary>
    ///   <para>teach:Student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Student of the course.
    /// "</para>
    /// labels<para>"Student"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#Student">http://linkedscience.org/teach/ns#Student</seealso>
    let Student = Prefixed_Name(teach, "Student") |> PrefixedName
    /// <summary>
    ///   <para>teach:StudentGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"StudentGroup of the course.
    /// "</para>
    /// labels<para>"StudentGroup"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#StudentGroup">http://linkedscience.org/teach/ns#StudentGroup</seealso>
    let StudentGroup = Prefixed_Name(teach, "StudentGroup") |> PrefixedName
    /// <summary>
    ///   <para>teach:StudyProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"StudyProgram which the course is part of.
    /// "</para>
    /// labels<para>"StudyProgram"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#StudyProgram">http://linkedscience.org/teach/ns#StudyProgram</seealso>
    let StudyProgram = Prefixed_Name(teach, "StudyProgram") |> PrefixedName
    /// <summary>
    ///   <para>teach:Teacher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Teacher of the course.
    /// "</para>
    /// labels<para>"Teacher"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#Teacher">http://linkedscience.org/teach/ns#Teacher</seealso>
    let Teacher = Prefixed_Name(teach, "Teacher") |> PrefixedName
    /// <summary>
    ///   <para>teach:academicTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"academicTerm is an abstract property to express the academic term (e.g. Summer 2011) of the course/seminar."</para>
    /// labels<para>"academicTerm"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#academicTerm">http://linkedscience.org/teach/ns#academicTerm</seealso>
    let academicTerm = Prefixed_Name(teach, "academicTerm") |> PrefixedName
    /// <summary>
    ///   <para>teach:arrangedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"arrangedAt is an abstract property to explicate the date/time when the seminar is arranged at. It can be defined as in the following example:
    ///   http://www.w3.org/TR/rdfcal/#L21805"</para>
    /// labels<para>"arrangedAt"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#arrangedAt">http://linkedscience.org/teach/ns#arrangedAt</seealso>
    let arrangedAt = Prefixed_Name(teach, "arrangedAt") |> PrefixedName
    /// <summary>
    ///   <para>teach:bookingNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"bookingNumber is an abstract property to uniquely identify the course. This identifier should be defined and provided by the operator of the course."</para>
    /// labels<para>"bookingNumber"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#bookingNumber">http://linkedscience.org/teach/ns#bookingNumber</seealso>
    let bookingNumber = Prefixed_Name(teach, "bookingNumber") |> PrefixedName
    /// <summary>
    ///   <para>teach:building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"building is an abstract property to express the building where the course/seminar takes place."</para>
    /// labels<para>"room"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#building">http://linkedscience.org/teach/ns#building</seealso>
    let building = Prefixed_Name(teach, "building") |> PrefixedName
    /// <summary>
    ///   <para>teach:courseDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"courseDescription is subproperty of dc:description to specify the course description"</para>
    /// labels<para>"courseDescription"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#courseDescription">http://linkedscience.org/teach/ns#courseDescription</seealso>
    let courseDescription = Prefixed_Name(teach, "courseDescription") |> PrefixedName
    /// <summary>
    ///   <para>teach:courseTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"courseTitle is subproperty of dc:title to specify the course title"</para>
    /// labels<para>"courseTitle"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#courseTitle">http://linkedscience.org/teach/ns#courseTitle</seealso>
    let courseTitle = Prefixed_Name(teach, "courseTitle") |> PrefixedName
    /// <summary>
    ///   <para>teach:deadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"deadline is an abstract property explicate the deadline for a draft project report."</para>
    /// labels<para>"deadline"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#deadline">http://linkedscience.org/teach/ns#deadline</seealso>
    let deadline = Prefixed_Name(teach, "deadline") |> PrefixedName

    /// <summary>
    ///   <para>teach:deadlineDraftReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"deadlineDraftReport is an abstract property explicate the deadline for a draft project report."</para>
    /// labels<para>"deadlineDraftReport"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#deadlineDraftReport">http://linkedscience.org/teach/ns#deadlineDraftReport</seealso>
    let deadlineDraftReport =
        Prefixed_Name(teach, "deadlineDraftReport") |> PrefixedName

    /// <summary>
    ///   <para>teach:deadlineFinalReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"deadlineFinalReport is an abstract property to explicate the deadline for a final project report."</para>
    /// labels<para>"deadlineFinalReport"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#deadlineFinalReport">http://linkedscience.org/teach/ns#deadlineFinalReport</seealso>
    let deadlineFinalReport =
        Prefixed_Name(teach, "deadlineFinalReport") |> PrefixedName

    /// <summary>
    ///   <para>teach:deadlineReviewReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"deadlineReviewReport is an abstract property to explicate the deadline for review reports (opponent works)."</para>
    /// labels<para>"deadlineReviewReport"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#deadlineReviewReport">http://linkedscience.org/teach/ns#deadlineReviewReport</seealso>
    let deadlineReviewReport =
        Prefixed_Name(teach, "deadlineReviewReport") |> PrefixedName

    /// <summary>
    ///   <para>teach:ects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ects is an abstract property to express the ects (European Credit Transfer System) of the course/seminar."</para>
    /// labels<para>"ects"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#ects">http://linkedscience.org/teach/ns#ects</seealso>
    let ects = Prefixed_Name(teach, "ects") |> PrefixedName
    /// <summary>
    ///   <para>teach:grading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"grading is an abstract property to relate the course/seminar to the description about its grading."</para>
    /// labels<para>"grading"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#grading">http://linkedscience.org/teach/ns#grading</seealso>
    let grading = Prefixed_Name(teach, "grading") |> PrefixedName
    /// <summary>
    ///   <para>teach:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasDescription is subproperty of dc:description to specify needed descriptions of entities within the course, e.g. the description of course materials, assignments, etc."</para>
    /// labels<para>"hasDescription"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#hasDescription">http://linkedscience.org/teach/ns#hasDescription</seealso>
    let hasDescription = Prefixed_Name(teach, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>teach:hasTeachingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the teaching method used in the course/seminar. property "hasTeachingMethod" inspired by an interview of Nobel Laureate Carl Wieman in "Transformation Is Possible
    /// If a University Really Cares", SCIENCE, Vol 340, April 19th, 2013: "Wieman came up with his simple, market-driven first step: Require universities to compile and release data on their teaching methods as a condition for receiving federal research funds. As students began using the data released by universities to help choose a college, he reasoned, universities would feel compelled to improve their teaching practices in order to attract the best applicants." The idea is that with the hasTeachingMethod-property universities can start publishing the teaching methods they use as Linked Open Data. Let us see which university implements the idea first."</para>
    /// labels<para>"room"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#hasTeachingMethod">http://linkedscience.org/teach/ns#hasTeachingMethod</seealso>
    let hasTeachingMethod = Prefixed_Name(teach, "hasTeachingMethod") |> PrefixedName
    /// <summary>
    ///   <para>teach:hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasTitle is subproperty of dc:title  to specify needed titles of entities within the course, e.g. the title of course materials, assignments, etc."</para>
    /// labels<para>"hasTitle"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#hasTitle">http://linkedscience.org/teach/ns#hasTitle</seealso>
    let hasTitle = Prefixed_Name(teach, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>teach:module</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the module of the study program with which the course/seminar is associated."</para>
    /// labels<para>"room"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#module">http://linkedscience.org/teach/ns#module</seealso>
    let module_ = Prefixed_Name(teach, "module") |> PrefixedName
    /// <summary>
    ///   <para>teach:nextReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"nextReading is an abstract property for dynamically stating the reading required to be read by the next session of the course/seminar."</para>
    /// labels<para>"nextReading"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#nextReading">http://linkedscience.org/teach/ns#nextReading</seealso>
    let nextReading = Prefixed_Name(teach, "nextReading") |> PrefixedName
    /// <summary>
    ///   <para>teach:notArrangedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"notArrangedAt is an abstract property to explicate the date/time when the seminar has an exception in its schedule and thus is not arranged at."</para>
    /// labels<para>"notArrangedAt"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#notArrangedAt">http://linkedscience.org/teach/ns#notArrangedAt</seealso>
    let notArrangedAt = Prefixed_Name(teach, "notArrangedAt") |> PrefixedName
    /// <summary>
    ///   <para>teach:opponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"opponentOf is an abstract property to state that a student is an opponent of another, i.e. that he/she makes review of the other student's seminar work."</para>
    /// labels<para>"opponentOf"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#opponentOf">http://linkedscience.org/teach/ns#opponentOf</seealso>
    let opponentOf = Prefixed_Name(teach, "opponentOf") |> PrefixedName
    /// <summary>
    ///   <para>teach:reading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"reading is an abstract property to relate required readings to the course/seminar."</para>
    /// labels<para>"reading"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#reading">http://linkedscience.org/teach/ns#reading</seealso>
    let reading = Prefixed_Name(teach, "reading") |> PrefixedName
    /// <summary>
    ///   <para>teach:reportTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"reportTemplate is an abstract property to relate a report template to the course/seminar so that students may use it to write their reports."</para>
    /// labels<para>"reportTemplate"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#reportTemplate">http://linkedscience.org/teach/ns#reportTemplate</seealso>
    let reportTemplate = Prefixed_Name(teach, "reportTemplate") |> PrefixedName
    /// <summary>
    ///   <para>teach:reviewTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"reviewTemplate is an abstract property to relate a review template to the course/seminar so that students may use it to write their reviews of other student's reports."</para>
    /// labels<para>"reviewTemplate"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#reviewTemplate">http://linkedscience.org/teach/ns#reviewTemplate</seealso>
    let reviewTemplate = Prefixed_Name(teach, "reviewTemplate") |> PrefixedName
    /// <summary>
    ///   <para>teach:room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"room is an abstract property to express the room where the course/seminar takes place."</para>
    /// labels<para>"room"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#room">http://linkedscience.org/teach/ns#room</seealso>
    let room = Prefixed_Name(teach, "room") |> PrefixedName
    /// <summary>
    ///   <para>teach:studentGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"studentGroup is an abstract property to relate a student group to the course/seminar."</para>
    /// labels<para>"studentGroup"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#studentGroup">http://linkedscience.org/teach/ns#studentGroup</seealso>
    let studentGroup = Prefixed_Name(teach, "studentGroup") |> PrefixedName
    /// <summary>
    ///   <para>teach:studyProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the study program which is associated with the course/seminar."</para>
    /// labels<para>"room"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#studyProgram">http://linkedscience.org/teach/ns#studyProgram</seealso>
    let studyProgram = Prefixed_Name(teach, "studyProgram") |> PrefixedName
    /// <summary>
    ///   <para>teach:teacher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"teacher is an abstract property to relate a teacher to a course/seminar."</para>
    /// labels<para>"teacher"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#teacher">http://linkedscience.org/teach/ns#teacher</seealso>
    let teacher = Prefixed_Name(teach, "teacher") |> PrefixedName
    /// <summary>
    ///   <para>teach:teacherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"teacherOf is an abstract property to relate a teacher to a course/seminar."</para>
    /// labels<para>"teacherOf"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#teacherOf">http://linkedscience.org/teach/ns#teacherOf</seealso>
    let teacherOf = Prefixed_Name(teach, "teacherOf") |> PrefixedName
    /// <summary>
    ///   <para>teach:weeklyHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"weeklyHours is an abstract property to express the number of weekly hours for the teaching."</para>
    /// labels<para>"weeklyHours"</para></remarks>
    /// <seealso href="http://linkedscience.org/teach/ns#weeklyHours">http://linkedscience.org/teach/ns#weeklyHours</seealso>
    let weeklyHours = Prefixed_Name(teach, "weeklyHours") |> PrefixedName
