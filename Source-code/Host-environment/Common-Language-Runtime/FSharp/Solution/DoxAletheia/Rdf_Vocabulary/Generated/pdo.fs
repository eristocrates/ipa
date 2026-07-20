namespace http.ontologies.smile.deri.ie.pdo.hash

open DoxAletheia

module pdo =
    let _namespace_name = "http://ontologies.smile.deri.ie/pdo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Models the absentee role of a person in a meeting context.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Absentee"></see></summary>
    let Absentee = _prefix "Absentee"
    /// <summary>
    /// The abstract class modelling various roles taken by individuals during a particular context ( for example, the attendees, scribe etc in a meeting or the reporter in a status report.)
    /// <see href="http://ontologies.smile.deri.ie/pdo#PersonRole"></see></summary>
    let PersonRole = _prefix "PersonRole"
    /// <summary>
    /// Subclasses pdo:Artifact and models the structure of an action item/task
    /// <see href="http://ontologies.smile.deri.ie/pdo#ActionItem"></see></summary>
    let ActionItem = _prefix "ActionItem"
    /// <summary>
    /// An abstract class for  any kind of information artifact which can be structured according to its sematics.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Artefact"></see></summary>
    let Artefact = _prefix "Artefact"
    /// <summary>
    /// Subclasses pdo:Artifact and models the structure of an agenda item
    /// <see href="http://ontologies.smile.deri.ie/pdo#AgendaItem"></see></summary>
    let AgendaItem = _prefix "AgendaItem"
    /// <summary>
    /// Models the attendee role of a person in a meeting context.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Attendee"></see></summary>
    let Attendee = _prefix "Attendee"
    /// <summary>
    /// Models the chair role of a person in a meeting context.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Chair"></see></summary>
    let Chair = _prefix "Chair"
    /// <summary>
    /// Models a comment made by a person
    /// <see href="http://ontologies.smile.deri.ie/pdo#Comment"></see></summary>
    let Comment = _prefix "Comment"
    /// <summary>
    /// The base class for all kinds of electronic documents in a project-specific setting.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// Subclasses pdo:Artefact and models the structure of a leave report
    /// <see href="http://ontologies.smile.deri.ie/pdo#LeaveReport"></see></summary>
    let LeaveReport = _prefix "LeaveReport"
    /// <summary>
    /// Subclasses pdo:Artefact and models the structure of a travel report
    /// <see href="http://ontologies.smile.deri.ie/pdo#Report"></see></summary>
    let Report = _prefix "Report"
    /// <summary>
    /// The class modelling the actual meeting which is the subject of a particular minutes document.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Meeting"></see></summary>
    let Meeting = _prefix "Meeting"
    /// <summary>
    /// The class modelling the structure and cotent of an electronic version of the minutes of a meetintg.
    /// <see href="http://ontologies.smile.deri.ie/pdo#MeetingMinutes"></see></summary>
    let MeetingMinutes = _prefix "MeetingMinutes"
    /// <summary>
    /// Subclasses pdo:Artifact and models the structure of a poll
    /// <see href="http://ontologies.smile.deri.ie/pdo#Poll"></see></summary>
    let Poll = _prefix "Poll"
    /// <summary>
    /// Models an option in a poll. Each option is linked to a list of people who selected the option during the poll
    /// <see href="http://ontologies.smile.deri.ie/pdo#PollOption"></see></summary>
    let PollOption = _prefix "PollOption"
    /// <summary>
    /// Models the presenter role of a person in the context of an agenda item.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Presenter"></see></summary>
    let Presenter = _prefix "Presenter"
    /// <summary>
    /// Subclasses pdo:Artifact and uses bibliography ontology to model the structure of a publication
    /// <see href="http://ontologies.smile.deri.ie/pdo#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// Models the reporting role of a person in a status reporting context.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Reporter"></see></summary>
    let Reporter = _prefix "Reporter"
    /// <summary>
    /// Models the scribe role of a person in a meeting context.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Scribe"></see></summary>
    let Scribe = _prefix "Scribe"
    /// <summary>
    /// The class modelling the structure and content of an electronic version of a status reports document
    /// <see href="http://ontologies.smile.deri.ie/pdo#StatusReport"></see></summary>
    let StatusReport = _prefix "StatusReport"
    /// <summary>
    /// Subclasses pdo:Artefact and models the structure of a travel report
    /// <see href="http://ontologies.smile.deri.ie/pdo#TravelReport"></see></summary>
    let TravelReport = _prefix "TravelReport"
    /// <summary>
    /// The property which links an artefact (for example, an agenda item , an action item, a travle report, etc ) to the document in which it is mentioned.
    /// <see href="http://ontologies.smile.deri.ie/pdo#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// A way to store different alias names of objects (used internally by the application)
    /// <see href="http://ontologies.smile.deri.ie/pdo#hasAlias"></see></summary>
    let hasAlias = _prefix "hasAlias"
    /// <summary>
    ///   <see href="http://ontologies.smile.deri.ie/pdo#hasCreationTime"></see>
    /// </summary>
    let hasCreationTime = _prefix "hasCreationTime"
    /// <summary>
    ///   <see href="http://ontologies.smile.deri.ie/pdo#hasDescription"></see>
    /// </summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    ///   <see href="http://ontologies.smile.deri.ie/pdo#hasEndTime"></see>
    /// </summary>
    let hasEndTime = _prefix "hasEndTime"
    /// <summary>
    ///   <see href="http://ontologies.smile.deri.ie/pdo#hasStartTime"></see>
    /// </summary>
    let hasStartTime = _prefix "hasStartTime"
    /// <summary>
    ///   <see href="http://ontologies.smile.deri.ie/pdo#hasStatus"></see>
    /// </summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    /// This property links a pdo:ActionItem object to a foaf:Person object who is reponsible for the action item
    /// <see href="http://ontologies.smile.deri.ie/pdo#isAssignedTo"></see></summary>
    let isAssignedTo = _prefix "isAssignedTo"
    /// <summary>
    /// The property which links an artefact (for example, an agenda item , an action item, a travle report, etc ) to the document in which it is mentioned.
    /// <see href="http://ontologies.smile.deri.ie/pdo#mentions"></see></summary>
    let mentions = _prefix "mentions"
