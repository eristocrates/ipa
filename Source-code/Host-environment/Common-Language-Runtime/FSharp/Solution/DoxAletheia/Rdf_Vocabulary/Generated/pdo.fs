namespace http.ontologies.smile.deri.ie.pdo.hash

open DoxAletheia.Rdf_Vocabulary

module pdo =
    let _namespace_name = "http://ontologies.smile.deri.ie/pdo#"
    /// <summary>
    /// Models the absentee role of a person in a meeting context.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Absentee"></see></summary>
    let Absentee = Namespaced_IRI.parse _namespace_name "Absentee" |> NamespacedName
    /// <summary>
    /// The abstract class modelling various roles taken by individuals during a particular context ( for example, the attendees, scribe etc in a meeting or the reporter in a status report.)
    /// <see href="http://ontologies.smile.deri.ie/pdo#PersonRole"></see></summary>
    let PersonRole = Namespaced_IRI.parse _namespace_name "PersonRole" |> NamespacedName
    /// <summary>
    /// Subclasses pdo:Artifact and models the structure of an action item/task
    /// <see href="http://ontologies.smile.deri.ie/pdo#ActionItem"></see></summary>
    let ActionItem = Namespaced_IRI.parse _namespace_name "ActionItem" |> NamespacedName
    /// <summary>
    /// An abstract class for  any kind of information artifact which can be structured according to its sematics.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Artefact"></see></summary>
    let Artefact = Namespaced_IRI.parse _namespace_name "Artefact" |> NamespacedName
    /// <summary>
    /// Subclasses pdo:Artifact and models the structure of an agenda item
    /// <see href="http://ontologies.smile.deri.ie/pdo#AgendaItem"></see></summary>
    let AgendaItem = Namespaced_IRI.parse _namespace_name "AgendaItem" |> NamespacedName
    /// <summary>
    /// Models the attendee role of a person in a meeting context.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Attendee"></see></summary>
    let Attendee = Namespaced_IRI.parse _namespace_name "Attendee" |> NamespacedName
    /// <summary>
    /// Models the chair role of a person in a meeting context.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Chair"></see></summary>
    let Chair = Namespaced_IRI.parse _namespace_name "Chair" |> NamespacedName
    /// <summary>
    /// Models a comment made by a person
    /// <see href="http://ontologies.smile.deri.ie/pdo#Comment"></see></summary>
    let Comment = Namespaced_IRI.parse _namespace_name "Comment" |> NamespacedName
    /// <summary>
    /// The base class for all kinds of electronic documents in a project-specific setting.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName

    /// <summary>
    /// Subclasses pdo:Artefact and models the structure of a leave report
    /// <see href="http://ontologies.smile.deri.ie/pdo#LeaveReport"></see></summary>
    let LeaveReport =
        Namespaced_IRI.parse _namespace_name "LeaveReport" |> NamespacedName

    /// <summary>
    /// Subclasses pdo:Artefact and models the structure of a travel report
    /// <see href="http://ontologies.smile.deri.ie/pdo#Report"></see></summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName
    /// <summary>
    /// The class modelling the actual meeting which is the subject of a particular minutes document.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Meeting"></see></summary>
    let Meeting = Namespaced_IRI.parse _namespace_name "Meeting" |> NamespacedName

    /// <summary>
    /// The class modelling the structure and cotent of an electronic version of the minutes of a meetintg.
    /// <see href="http://ontologies.smile.deri.ie/pdo#MeetingMinutes"></see></summary>
    let MeetingMinutes =
        Namespaced_IRI.parse _namespace_name "MeetingMinutes" |> NamespacedName

    /// <summary>
    /// Subclasses pdo:Artifact and models the structure of a poll
    /// <see href="http://ontologies.smile.deri.ie/pdo#Poll"></see></summary>
    let Poll = Namespaced_IRI.parse _namespace_name "Poll" |> NamespacedName
    /// <summary>
    /// Models an option in a poll. Each option is linked to a list of people who selected the option during the poll
    /// <see href="http://ontologies.smile.deri.ie/pdo#PollOption"></see></summary>
    let PollOption = Namespaced_IRI.parse _namespace_name "PollOption" |> NamespacedName
    /// <summary>
    /// Models the presenter role of a person in the context of an agenda item.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Presenter"></see></summary>
    let Presenter = Namespaced_IRI.parse _namespace_name "Presenter" |> NamespacedName

    /// <summary>
    /// Subclasses pdo:Artifact and uses bibliography ontology to model the structure of a publication
    /// <see href="http://ontologies.smile.deri.ie/pdo#Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    /// Models the reporting role of a person in a status reporting context.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Reporter"></see></summary>
    let Reporter = Namespaced_IRI.parse _namespace_name "Reporter" |> NamespacedName
    /// <summary>
    /// Models the scribe role of a person in a meeting context.
    /// <see href="http://ontologies.smile.deri.ie/pdo#Scribe"></see></summary>
    let Scribe = Namespaced_IRI.parse _namespace_name "Scribe" |> NamespacedName

    /// <summary>
    /// The class modelling the structure and content of an electronic version of a status reports document
    /// <see href="http://ontologies.smile.deri.ie/pdo#StatusReport"></see></summary>
    let StatusReport =
        Namespaced_IRI.parse _namespace_name "StatusReport" |> NamespacedName

    /// <summary>
    /// Subclasses pdo:Artefact and models the structure of a travel report
    /// <see href="http://ontologies.smile.deri.ie/pdo#TravelReport"></see></summary>
    let TravelReport =
        Namespaced_IRI.parse _namespace_name "TravelReport" |> NamespacedName

    /// <summary>
    /// The property which links an artefact (for example, an agenda item , an action item, a travle report, etc ) to the document in which it is mentioned.
    /// <see href="http://ontologies.smile.deri.ie/pdo#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    /// A way to store different alias names of objects (used internally by the application)
    /// <see href="http://ontologies.smile.deri.ie/pdo#hasAlias"></see></summary>
    let hasAlias = Namespaced_IRI.parse _namespace_name "hasAlias" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologies.smile.deri.ie/pdo#hasCreationTime"></see>
    /// </summary>
    let hasCreationTime =
        Namespaced_IRI.parse _namespace_name "hasCreationTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologies.smile.deri.ie/pdo#hasDescription"></see>
    /// </summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologies.smile.deri.ie/pdo#hasEndTime"></see>
    /// </summary>
    let hasEndTime = Namespaced_IRI.parse _namespace_name "hasEndTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologies.smile.deri.ie/pdo#hasStartTime"></see>
    /// </summary>
    let hasStartTime =
        Namespaced_IRI.parse _namespace_name "hasStartTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologies.smile.deri.ie/pdo#hasStatus"></see>
    /// </summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName

    /// <summary>
    /// This property links a pdo:ActionItem object to a foaf:Person object who is reponsible for the action item
    /// <see href="http://ontologies.smile.deri.ie/pdo#isAssignedTo"></see></summary>
    let isAssignedTo =
        Namespaced_IRI.parse _namespace_name "isAssignedTo" |> NamespacedName

    /// <summary>
    /// The property which links an artefact (for example, an agenda item , an action item, a travle report, etc ) to the document in which it is mentioned.
    /// <see href="http://ontologies.smile.deri.ie/pdo#mentions"></see></summary>
    let mentions = Namespaced_IRI.parse _namespace_name "mentions" |> NamespacedName
