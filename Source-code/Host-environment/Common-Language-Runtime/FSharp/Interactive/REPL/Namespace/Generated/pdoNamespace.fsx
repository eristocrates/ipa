#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pdo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ontologies.smile.deri.ie/pdo#" "pdo"

    /// <summary>
    ///   <para>rdfs:label : Absentee^^xsd:string</para>
    ///   <para>rdfs:comment : Models the absentee role of a person in a meeting context.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Absentee">pdo:Absentee</a>
    /// </summary>
    let Absentee = _prefixId.prefix "Absentee"
    /// <summary>
    ///   <para>rdfs:label : ActionItem^^xsd:string</para>
    ///   <para>rdfs:comment : Subclasses pdo:Artifact and models the structure of an action item/task^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#ActionItem">pdo:ActionItem</a>
    /// </summary>
    let ActionItem = _prefixId.prefix "ActionItem"
    /// <summary>
    ///   <para>rdfs:label : AgendaItem^^xsd:string</para>
    ///   <para>rdfs:comment : Subclasses pdo:Artifact and models the structure of an agenda item^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#AgendaItem">pdo:AgendaItem</a>
    /// </summary>
    let AgendaItem = _prefixId.prefix "AgendaItem"
    /// <summary>
    ///   <para>rdfs:label : Artefact^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract class for  any kind of information artifact which can be structured according to its sematics.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Artefact">pdo:Artefact</a>
    /// </summary>
    let Artefact = _prefixId.prefix "Artefact"
    /// <summary>
    ///   <para>rdfs:label : Attendee^^xsd:string</para>
    ///   <para>rdfs:comment : Models the attendee role of a person in a meeting context.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Attendee">pdo:Attendee</a>
    /// </summary>
    let Attendee = _prefixId.prefix "Attendee"
    /// <summary>
    ///   <para>rdfs:label : Chair^^xsd:string</para>
    ///   <para>rdfs:comment : Models the chair role of a person in a meeting context.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Chair">pdo:Chair</a>
    /// </summary>
    let Chair = _prefixId.prefix "Chair"
    /// <summary>
    ///   <para>rdfs:label : Comment^^xsd:string</para>
    ///   <para>rdfs:comment : Models a comment made by a person^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Comment">pdo:Comment</a>
    /// </summary>
    let Comment = _prefixId.prefix "Comment"
    /// <summary>
    ///   <para>rdfs:label : Document^^xsd:string</para>
    ///   <para>rdfs:comment : The base class for all kinds of electronic documents in a project-specific setting.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Document">pdo:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : LeaveReport^^xsd:string</para>
    ///   <para>rdfs:comment : Subclasses pdo:Artefact and models the structure of a leave report^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#LeaveReport">pdo:LeaveReport</a>
    /// </summary>
    let LeaveReport = _prefixId.prefix "LeaveReport"
    /// <summary>
    ///   <para>rdfs:label : Meeting^^xsd:string</para>
    ///   <para>rdfs:comment : The class modelling the actual meeting which is the subject of a particular minutes document.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Meeting">pdo:Meeting</a>
    /// </summary>
    let Meeting = _prefixId.prefix "Meeting"
    /// <summary>
    ///   <para>rdfs:label : Minutes^^xsd:string</para>
    ///   <para>rdfs:comment : The class modelling the structure and cotent of an electronic version of the minutes of a meetintg.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#MeetingMinutes">pdo:MeetingMinutes</a>
    /// </summary>
    let MeetingMinutes = _prefixId.prefix "MeetingMinutes"
    /// <summary>
    ///   <para>rdfs:label : PersonRole^^xsd:string</para>
    ///   <para>rdfs:comment : The abstract class modelling various roles taken by individuals during a particular context ( for example, the attendees, scribe etc in a meeting or the reporter in a status report.)^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#PersonRole">pdo:PersonRole</a>
    /// </summary>
    let PersonRole = _prefixId.prefix "PersonRole"
    /// <summary>
    ///   <para>rdfs:label : Poll^^xsd:string</para>
    ///   <para>rdfs:comment : Subclasses pdo:Artifact and models the structure of a poll^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Poll">pdo:Poll</a>
    /// </summary>
    let Poll = _prefixId.prefix "Poll"
    /// <summary>
    ///   <para>rdfs:label : PollOption^^xsd:string</para>
    ///   <para>rdfs:comment : Models an option in a poll. Each option is linked to a list of people who selected the option during the poll^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#PollOption">pdo:PollOption</a>
    /// </summary>
    let PollOption = _prefixId.prefix "PollOption"
    /// <summary>
    ///   <para>rdfs:label : Presenter^^xsd:string</para>
    ///   <para>rdfs:comment : Models the presenter role of a person in the context of an agenda item.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Presenter">pdo:Presenter</a>
    /// </summary>
    let Presenter = _prefixId.prefix "Presenter"
    /// <summary>
    ///   <para>rdfs:label : Publication^^xsd:string</para>
    ///   <para>rdfs:comment : Subclasses pdo:Artifact and uses bibliography ontology to model the structure of a publication^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Publication">pdo:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : TravelReport^^xsd:string</para>
    ///   <para>rdfs:comment : Subclasses pdo:Artefact and models the structure of a travel report^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Report">pdo:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>rdfs:label : Reporter^^xsd:string</para>
    ///   <para>rdfs:comment : Models the reporting role of a person in a status reporting context.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Reporter">pdo:Reporter</a>
    /// </summary>
    let Reporter = _prefixId.prefix "Reporter"
    /// <summary>
    ///   <para>rdfs:label : Scribe^^xsd:string</para>
    ///   <para>rdfs:comment : Models the scribe role of a person in a meeting context.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#Scribe">pdo:Scribe</a>
    /// </summary>
    let Scribe = _prefixId.prefix "Scribe"
    /// <summary>
    ///   <para>rdfs:label : Report^^xsd:string</para>
    ///   <para>rdfs:comment : The class modelling the structure and content of an electronic version of a status reports document^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#StatusReport">pdo:StatusReport</a>
    /// </summary>
    let StatusReport = _prefixId.prefix "StatusReport"
    /// <summary>
    ///   <para>rdfs:label : TravelReport^^xsd:string</para>
    ///   <para>rdfs:comment : Subclasses pdo:Artefact and models the structure of a travel report^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#TravelReport">pdo:TravelReport</a>
    /// </summary>
    let TravelReport = _prefixId.prefix "TravelReport"
    /// <summary>
    ///   <para>rdfs:label : contains^^xsd:string</para>
    ///   <para>rdfs:comment : The property which links an artefact (for example, an agenda item , an action item, a travle report, etc ) to the document in which it is mentioned.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#contains">pdo:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : hasAlias^^xsd:string</para>
    ///   <para>rdfs:comment : A way to store different alias names of objects (used internally by the application)^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#hasAlias">pdo:hasAlias</a>
    /// </summary>
    let hasAlias = _prefixId.prefix "hasAlias"
    /// <summary>
    ///   <para>rdfs:label : hasCreationTime^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#hasCreationTime">pdo:hasCreationTime</a>
    /// </summary>
    let hasCreationTime = _prefixId.prefix "hasCreationTime"
    /// <summary>
    ///   <para>rdfs:label : hasDescription^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#hasDescription">pdo:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:label : hadEndTime^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#hasEndTime">pdo:hasEndTime</a>
    /// </summary>
    let hasEndTime = _prefixId.prefix "hasEndTime"
    /// <summary>
    ///   <para>rdfs:label : hasStartTime^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#hasStartTime">pdo:hasStartTime</a>
    /// </summary>
    let hasStartTime = _prefixId.prefix "hasStartTime"
    /// <summary>
    ///   <para>rdfs:label : hasStatus^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#hasStatus">pdo:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>rdfs:label : isAssignedTo^^xsd:string</para>
    ///   <para>rdfs:comment : This property links a pdo:ActionItem object to a foaf:Person object who is reponsible for the action item^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#isAssignedTo">pdo:isAssignedTo</a>
    /// </summary>
    let isAssignedTo = _prefixId.prefix "isAssignedTo"
    /// <summary>
    ///   <para>rdfs:label : mentions^^xsd:string</para>
    ///   <para>rdfs:comment : The property which links an artefact (for example, an agenda item , an action item, a travle report, etc ) to the document in which it is mentioned.^^xsd:string</para>
    ///   <a href="http://ontologies.smile.deri.ie/pdo#mentions">pdo:mentions</a>
    /// </summary>
    let mentions = _prefixId.prefix "mentions"
