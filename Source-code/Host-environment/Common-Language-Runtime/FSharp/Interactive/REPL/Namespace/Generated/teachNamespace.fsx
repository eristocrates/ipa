#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module teach =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://linkedscience.org/teach/ns#" "teach"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Assignment of a course, for example an exercise.
    /// </para>
    ///   <para>rdfs:label : Assignment</para>
    ///   <a href="http://linkedscience.org/teach/ns#Assignment">teach:Assignment</a>
    /// </summary>
    let Assignment = _prefixId.prefix "Assignment"
    /// <summary>
    ///   <para>rdfs:comment : Building where the course is taking place.
    /// </para>
    ///   <para>rdfs:label : Building</para>
    ///   <a href="http://linkedscience.org/teach/ns#Building">teach:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>rdfs:comment : Course is where students are supposed to learn something.
    /// </para>
    ///   <para>rdfs:label : Course</para>
    ///   <a href="http://linkedscience.org/teach/ns#Course">teach:Course</a>
    /// </summary>
    let Course = _prefixId.prefix "Course"
    /// <summary>
    ///   <para>rdfs:comment : Lecture of the course.
    /// </para>
    ///   <para>rdfs:label : Lecture</para>
    ///   <a href="http://linkedscience.org/teach/ns#Lecture">teach:Lecture</a>
    /// </summary>
    let Lecture = _prefixId.prefix "Lecture"
    /// <summary>
    ///   <para>rdfs:comment : Material of the course.
    /// </para>
    ///   <para>rdfs:label : Material</para>
    ///   <a href="http://linkedscience.org/teach/ns#Material">teach:Material</a>
    /// </summary>
    let Material = _prefixId.prefix "Material"
    /// <summary>
    ///   <para>rdfs:comment : Module (i.e. a set of courses) which the course belongs to.
    /// </para>
    ///   <para>rdfs:label : Module</para>
    ///   <a href="http://linkedscience.org/teach/ns#Module">teach:Module</a>
    /// </summary>
    let Module = _prefixId.prefix "Module"
    /// <summary>
    ///   <para>rdfs:comment : Room where the course is taking place.
    /// </para>
    ///   <para>rdfs:label : Room</para>
    ///   <a href="http://linkedscience.org/teach/ns#Room">teach:Room</a>
    /// </summary>
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>rdfs:comment : Student of the course.
    /// </para>
    ///   <para>rdfs:label : Student</para>
    ///   <a href="http://linkedscience.org/teach/ns#Student">teach:Student</a>
    /// </summary>
    let Student = _prefixId.prefix "Student"
    /// <summary>
    ///   <para>rdfs:comment : StudentGroup of the course.
    /// </para>
    ///   <para>rdfs:label : StudentGroup</para>
    ///   <a href="http://linkedscience.org/teach/ns#StudentGroup">teach:StudentGroup</a>
    /// </summary>
    let StudentGroup = _prefixId.prefix "StudentGroup"
    /// <summary>
    ///   <para>rdfs:comment : StudyProgram which the course is part of.
    /// </para>
    ///   <para>rdfs:label : StudyProgram</para>
    ///   <a href="http://linkedscience.org/teach/ns#StudyProgram">teach:StudyProgram</a>
    /// </summary>
    let StudyProgram = _prefixId.prefix "StudyProgram"
    /// <summary>
    ///   <para>rdfs:comment : Teacher of the course.
    /// </para>
    ///   <para>rdfs:label : Teacher</para>
    ///   <a href="http://linkedscience.org/teach/ns#Teacher">teach:Teacher</a>
    /// </summary>
    let Teacher = _prefixId.prefix "Teacher"
    /// <summary>
    ///   <para>rdfs:comment : academicTerm is an abstract property to express the academic term (e.g. Summer 2011) of the course/seminar.</para>
    ///   <para>rdfs:label : academicTerm</para>
    ///   <a href="http://linkedscience.org/teach/ns#academicTerm">teach:academicTerm</a>
    /// </summary>
    let academicTerm = _prefixId.prefix "academicTerm"
    /// <summary>
    ///   <para>rdfs:comment : arrangedAt is an abstract property to explicate the date/time when the seminar is arranged at. It can be defined as in the following example:
    ///   http://www.w3.org/TR/rdfcal/#L21805</para>
    ///   <para>rdfs:label : arrangedAt</para>
    ///   <a href="http://linkedscience.org/teach/ns#arrangedAt">teach:arrangedAt</a>
    /// </summary>
    let arrangedAt = _prefixId.prefix "arrangedAt"
    /// <summary>
    ///   <para>rdfs:comment : bookingNumber is an abstract property to uniquely identify the course. This identifier should be defined and provided by the operator of the course.</para>
    ///   <para>rdfs:label : bookingNumber</para>
    ///   <a href="http://linkedscience.org/teach/ns#bookingNumber">teach:bookingNumber</a>
    /// </summary>
    let bookingNumber = _prefixId.prefix "bookingNumber"
    /// <summary>
    ///   <para>rdfs:comment : building is an abstract property to express the building where the course/seminar takes place.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/teach/ns#building">teach:building</a>
    /// </summary>
    let building = _prefixId.prefix "building"
    /// <summary>
    ///   <para>rdfs:comment : courseDescription is subproperty of dc:description to specify the course description</para>
    ///   <para>rdfs:label : courseDescription</para>
    ///   <a href="http://linkedscience.org/teach/ns#courseDescription">teach:courseDescription</a>
    /// </summary>
    let courseDescription = _prefixId.prefix "courseDescription"
    /// <summary>
    ///   <para>rdfs:comment : courseTitle is subproperty of dc:title to specify the course title</para>
    ///   <para>rdfs:label : courseTitle</para>
    ///   <a href="http://linkedscience.org/teach/ns#courseTitle">teach:courseTitle</a>
    /// </summary>
    let courseTitle = _prefixId.prefix "courseTitle"
    /// <summary>
    ///   <para>rdfs:comment : deadline is an abstract property explicate the deadline for a draft project report.</para>
    ///   <para>rdfs:label : deadline</para>
    ///   <a href="http://linkedscience.org/teach/ns#deadline">teach:deadline</a>
    /// </summary>
    let deadline = _prefixId.prefix "deadline"
    /// <summary>
    ///   <para>rdfs:comment : deadlineDraftReport is an abstract property explicate the deadline for a draft project report.</para>
    ///   <para>rdfs:label : deadlineDraftReport</para>
    ///   <a href="http://linkedscience.org/teach/ns#deadlineDraftReport">teach:deadlineDraftReport</a>
    /// </summary>
    let deadlineDraftReport = _prefixId.prefix "deadlineDraftReport"
    /// <summary>
    ///   <para>rdfs:comment : deadlineFinalReport is an abstract property to explicate the deadline for a final project report.</para>
    ///   <para>rdfs:label : deadlineFinalReport</para>
    ///   <a href="http://linkedscience.org/teach/ns#deadlineFinalReport">teach:deadlineFinalReport</a>
    /// </summary>
    let deadlineFinalReport = _prefixId.prefix "deadlineFinalReport"
    /// <summary>
    ///   <para>rdfs:comment : deadlineReviewReport is an abstract property to explicate the deadline for review reports (opponent works).</para>
    ///   <para>rdfs:label : deadlineReviewReport</para>
    ///   <a href="http://linkedscience.org/teach/ns#deadlineReviewReport">teach:deadlineReviewReport</a>
    /// </summary>
    let deadlineReviewReport = _prefixId.prefix "deadlineReviewReport"
    /// <summary>
    ///   <para>rdfs:comment : ects is an abstract property to express the ects (European Credit Transfer System) of the course/seminar.</para>
    ///   <para>rdfs:label : ects</para>
    ///   <a href="http://linkedscience.org/teach/ns#ects">teach:ects</a>
    /// </summary>
    let ects = _prefixId.prefix "ects"
    /// <summary>
    ///   <para>rdfs:comment : grading is an abstract property to relate the course/seminar to the description about its grading.</para>
    ///   <para>rdfs:label : grading</para>
    ///   <a href="http://linkedscience.org/teach/ns#grading">teach:grading</a>
    /// </summary>
    let grading = _prefixId.prefix "grading"
    /// <summary>
    ///   <para>rdfs:comment : hasDescription is subproperty of dc:description to specify needed descriptions of entities within the course, e.g. the description of course materials, assignments, etc.</para>
    ///   <para>rdfs:label : hasDescription</para>
    ///   <a href="http://linkedscience.org/teach/ns#hasDescription">teach:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:comment : Describes the teaching method used in the course/seminar. property "hasTeachingMethod" inspired by an interview of Nobel Laureate Carl Wieman in "Transformation Is Possible
    /// If a University Really Cares", SCIENCE, Vol 340, April 19th, 2013: "Wieman came up with his simple, market-driven first step: Require universities to compile and release data on their teaching methods as a condition for receiving federal research funds. As students began using the data released by universities to help choose a college, he reasoned, universities would feel compelled to improve their teaching practices in order to attract the best applicants." The idea is that with the hasTeachingMethod-property universities can start publishing the teaching methods they use as Linked Open Data. Let us see which university implements the idea first.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/teach/ns#hasTeachingMethod">teach:hasTeachingMethod</a>
    /// </summary>
    let hasTeachingMethod = _prefixId.prefix "hasTeachingMethod"
    /// <summary>
    ///   <para>rdfs:comment : hasTitle is subproperty of dc:title  to specify needed titles of entities within the course, e.g. the title of course materials, assignments, etc.</para>
    ///   <para>rdfs:label : hasTitle</para>
    ///   <a href="http://linkedscience.org/teach/ns#hasTitle">teach:hasTitle</a>
    /// </summary>
    let hasTitle = _prefixId.prefix "hasTitle"
    /// <summary>
    ///   <para>rdfs:comment : Describes the module of the study program with which the course/seminar is associated.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/teach/ns#module">teach:module</a>
    /// </summary>
    let module_ = _prefixId.prefix "module"
    /// <summary>
    ///   <para>rdfs:comment : nextReading is an abstract property for dynamically stating the reading required to be read by the next session of the course/seminar.</para>
    ///   <para>rdfs:label : nextReading</para>
    ///   <a href="http://linkedscience.org/teach/ns#nextReading">teach:nextReading</a>
    /// </summary>
    let nextReading = _prefixId.prefix "nextReading"
    /// <summary>
    ///   <para>rdfs:comment : notArrangedAt is an abstract property to explicate the date/time when the seminar has an exception in its schedule and thus is not arranged at.</para>
    ///   <para>rdfs:label : notArrangedAt</para>
    ///   <a href="http://linkedscience.org/teach/ns#notArrangedAt">teach:notArrangedAt</a>
    /// </summary>
    let notArrangedAt = _prefixId.prefix "notArrangedAt"
    /// <summary>
    ///   <para>rdfs:comment : opponentOf is an abstract property to state that a student is an opponent of another, i.e. that he/she makes review of the other student's seminar work.</para>
    ///   <para>rdfs:label : opponentOf</para>
    ///   <a href="http://linkedscience.org/teach/ns#opponentOf">teach:opponentOf</a>
    /// </summary>
    let opponentOf = _prefixId.prefix "opponentOf"
    /// <summary>
    ///   <para>rdfs:comment : reading is an abstract property to relate required readings to the course/seminar.</para>
    ///   <para>rdfs:label : reading</para>
    ///   <a href="http://linkedscience.org/teach/ns#reading">teach:reading</a>
    /// </summary>
    let reading = _prefixId.prefix "reading"
    /// <summary>
    ///   <para>rdfs:comment : reportTemplate is an abstract property to relate a report template to the course/seminar so that students may use it to write their reports.</para>
    ///   <para>rdfs:label : reportTemplate</para>
    ///   <a href="http://linkedscience.org/teach/ns#reportTemplate">teach:reportTemplate</a>
    /// </summary>
    let reportTemplate = _prefixId.prefix "reportTemplate"
    /// <summary>
    ///   <para>rdfs:comment : reviewTemplate is an abstract property to relate a review template to the course/seminar so that students may use it to write their reviews of other student's reports.</para>
    ///   <para>rdfs:label : reviewTemplate</para>
    ///   <a href="http://linkedscience.org/teach/ns#reviewTemplate">teach:reviewTemplate</a>
    /// </summary>
    let reviewTemplate = _prefixId.prefix "reviewTemplate"
    /// <summary>
    ///   <para>rdfs:comment : room is an abstract property to express the room where the course/seminar takes place.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/teach/ns#room">teach:room</a>
    /// </summary>
    let room = _prefixId.prefix "room"
    /// <summary>
    ///   <para>rdfs:comment : studentGroup is an abstract property to relate a student group to the course/seminar.</para>
    ///   <para>rdfs:label : studentGroup</para>
    ///   <a href="http://linkedscience.org/teach/ns#studentGroup">teach:studentGroup</a>
    /// </summary>
    let studentGroup = _prefixId.prefix "studentGroup"
    /// <summary>
    ///   <para>rdfs:comment : Describes the study program which is associated with the course/seminar.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/teach/ns#studyProgram">teach:studyProgram</a>
    /// </summary>
    let studyProgram = _prefixId.prefix "studyProgram"
    /// <summary>
    ///   <para>rdfs:comment : teacher is an abstract property to relate a teacher to a course/seminar.</para>
    ///   <para>rdfs:label : teacher</para>
    ///   <a href="http://linkedscience.org/teach/ns#teacher">teach:teacher</a>
    /// </summary>
    let teacher = _prefixId.prefix "teacher"
    /// <summary>
    ///   <para>rdfs:comment : teacherOf is an abstract property to relate a teacher to a course/seminar.</para>
    ///   <para>rdfs:label : teacherOf</para>
    ///   <a href="http://linkedscience.org/teach/ns#teacherOf">teach:teacherOf</a>
    /// </summary>
    let teacherOf = _prefixId.prefix "teacherOf"
    /// <summary>
    ///   <para>rdfs:comment : weeklyHours is an abstract property to express the number of weekly hours for the teaching.</para>
    ///   <para>rdfs:label : weeklyHours</para>
    ///   <a href="http://linkedscience.org/teach/ns#weeklyHours">teach:weeklyHours</a>
    /// </summary>
    let weeklyHours = _prefixId.prefix "weeklyHours"
