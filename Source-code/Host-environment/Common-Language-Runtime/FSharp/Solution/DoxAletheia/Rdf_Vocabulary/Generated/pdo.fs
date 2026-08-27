namespace http.ontologies.smile.deri.ie.pdo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pdo =
    let _namespace_iri = Namespace_Iri pdo |> NamespaceIRI
    /// <summary>
    ///   <para>pdo:Absentee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Models the absentee role of a person in a meeting context."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Absentee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Absentee">http://ontologies.smile.deri.ie/pdo#Absentee</seealso>
    let Absentee = Prefixed_Name(pdo, "Absentee") |> PrefixedName
    /// <summary>
    ///   <para>pdo:ActionItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Subclasses pdo:Artifact and models the structure of an action item/task"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ActionItem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#ActionItem">http://ontologies.smile.deri.ie/pdo#ActionItem</seealso>
    let ActionItem = Prefixed_Name(pdo, "ActionItem") |> PrefixedName
    /// <summary>
    ///   <para>pdo:AgendaItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Subclasses pdo:Artifact and models the structure of an agenda item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AgendaItem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#AgendaItem">http://ontologies.smile.deri.ie/pdo#AgendaItem</seealso>
    let AgendaItem = Prefixed_Name(pdo, "AgendaItem") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Artefact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract class for  any kind of information artifact which can be structured according to its sematics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Artefact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Artefact">http://ontologies.smile.deri.ie/pdo#Artefact</seealso>
    let Artefact = Prefixed_Name(pdo, "Artefact") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Attendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Models the attendee role of a person in a meeting context."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Attendee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Attendee">http://ontologies.smile.deri.ie/pdo#Attendee</seealso>
    let Attendee = Prefixed_Name(pdo, "Attendee") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Chair</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Models the chair role of a person in a meeting context."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Chair">http://ontologies.smile.deri.ie/pdo#Chair</seealso>
    let Chair = Prefixed_Name(pdo, "Chair") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Models a comment made by a person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Comment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Comment">http://ontologies.smile.deri.ie/pdo#Comment</seealso>
    let Comment = Prefixed_Name(pdo, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The base class for all kinds of electronic documents in a project-specific setting."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Document">http://ontologies.smile.deri.ie/pdo#Document</seealso>
    let Document = Prefixed_Name(pdo, "Document") |> PrefixedName
    /// <summary>
    ///   <para>pdo:LeaveReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Subclasses pdo:Artefact and models the structure of a leave report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LeaveReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#LeaveReport">http://ontologies.smile.deri.ie/pdo#LeaveReport</seealso>
    let LeaveReport = Prefixed_Name(pdo, "LeaveReport") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Meeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class modelling the actual meeting which is the subject of a particular minutes document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Meeting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Meeting">http://ontologies.smile.deri.ie/pdo#Meeting</seealso>
    let Meeting = Prefixed_Name(pdo, "Meeting") |> PrefixedName
    /// <summary>
    ///   <para>pdo:MeetingMinutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class modelling the structure and cotent of an electronic version of the minutes of a meetintg."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Minutes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#MeetingMinutes">http://ontologies.smile.deri.ie/pdo#MeetingMinutes</seealso>
    let MeetingMinutes = Prefixed_Name(pdo, "MeetingMinutes") |> PrefixedName
    /// <summary>
    ///   <para>pdo:PersonRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The abstract class modelling various roles taken by individuals during a particular context ( for example, the attendees, scribe etc in a meeting or the reporter in a status report.)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PersonRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#PersonRole">http://ontologies.smile.deri.ie/pdo#PersonRole</seealso>
    let PersonRole = Prefixed_Name(pdo, "PersonRole") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Poll</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Subclasses pdo:Artifact and models the structure of a poll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Poll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Poll">http://ontologies.smile.deri.ie/pdo#Poll</seealso>
    let Poll = Prefixed_Name(pdo, "Poll") |> PrefixedName
    /// <summary>
    ///   <para>pdo:PollOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Models an option in a poll. Each option is linked to a list of people who selected the option during the poll"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PollOption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#PollOption">http://ontologies.smile.deri.ie/pdo#PollOption</seealso>
    let PollOption = Prefixed_Name(pdo, "PollOption") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Presenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Models the presenter role of a person in the context of an agenda item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Presenter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Presenter">http://ontologies.smile.deri.ie/pdo#Presenter</seealso>
    let Presenter = Prefixed_Name(pdo, "Presenter") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Subclasses pdo:Artifact and uses bibliography ontology to model the structure of a publication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Publication">http://ontologies.smile.deri.ie/pdo#Publication</seealso>
    let Publication = Prefixed_Name(pdo, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Subclasses pdo:Artefact and models the structure of a travel report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TravelReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Report">http://ontologies.smile.deri.ie/pdo#Report</seealso>
    let Report = Prefixed_Name(pdo, "Report") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Reporter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Models the reporting role of a person in a status reporting context."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reporter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Reporter">http://ontologies.smile.deri.ie/pdo#Reporter</seealso>
    let Reporter = Prefixed_Name(pdo, "Reporter") |> PrefixedName
    /// <summary>
    ///   <para>pdo:Scribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Models the scribe role of a person in a meeting context."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scribe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#Scribe">http://ontologies.smile.deri.ie/pdo#Scribe</seealso>
    let Scribe = Prefixed_Name(pdo, "Scribe") |> PrefixedName
    /// <summary>
    ///   <para>pdo:StatusReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class modelling the structure and content of an electronic version of a status reports document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#StatusReport">http://ontologies.smile.deri.ie/pdo#StatusReport</seealso>
    let StatusReport = Prefixed_Name(pdo, "StatusReport") |> PrefixedName
    /// <summary>
    ///   <para>pdo:TravelReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Subclasses pdo:Artefact and models the structure of a travel report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TravelReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#TravelReport">http://ontologies.smile.deri.ie/pdo#TravelReport</seealso>
    let TravelReport = Prefixed_Name(pdo, "TravelReport") |> PrefixedName
    /// <summary>
    ///   <para>pdo:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property which links an artefact (for example, an agenda item , an action item, a travle report, etc ) to the document in which it is mentioned."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#contains">http://ontologies.smile.deri.ie/pdo#contains</seealso>
    let contains = Prefixed_Name(pdo, "contains") |> PrefixedName
    /// <summary>
    ///   <para>pdo:hasAlias</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A way to store different alias names of objects (used internally by the application)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasAlias"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#hasAlias">http://ontologies.smile.deri.ie/pdo#hasAlias</seealso>
    let hasAlias = Prefixed_Name(pdo, "hasAlias") |> PrefixedName
    /// <summary>
    ///   <para>pdo:hasCreationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasCreationTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#hasCreationTime">http://ontologies.smile.deri.ie/pdo#hasCreationTime</seealso>
    let hasCreationTime = Prefixed_Name(pdo, "hasCreationTime") |> PrefixedName
    /// <summary>
    ///   <para>pdo:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasDescription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#hasDescription">http://ontologies.smile.deri.ie/pdo#hasDescription</seealso>
    let hasDescription = Prefixed_Name(pdo, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>pdo:hasEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hadEndTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#hasEndTime">http://ontologies.smile.deri.ie/pdo#hasEndTime</seealso>
    let hasEndTime = Prefixed_Name(pdo, "hasEndTime") |> PrefixedName
    /// <summary>
    ///   <para>pdo:hasStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasStartTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#hasStartTime">http://ontologies.smile.deri.ie/pdo#hasStartTime</seealso>
    let hasStartTime = Prefixed_Name(pdo, "hasStartTime") |> PrefixedName
    /// <summary>
    ///   <para>pdo:hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#hasStatus">http://ontologies.smile.deri.ie/pdo#hasStatus</seealso>
    let hasStatus = Prefixed_Name(pdo, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>pdo:isAssignedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property links a pdo:ActionItem object to a foaf:Person object who is reponsible for the action item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isAssignedTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#isAssignedTo">http://ontologies.smile.deri.ie/pdo#isAssignedTo</seealso>
    let isAssignedTo = Prefixed_Name(pdo, "isAssignedTo") |> PrefixedName
    /// <summary>
    ///   <para>pdo:mentions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property which links an artefact (for example, an agenda item , an action item, a travle report, etc ) to the document in which it is mentioned."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mentions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontologies.smile.deri.ie/pdo#mentions">http://ontologies.smile.deri.ie/pdo#mentions</seealso>
    let mentions = Prefixed_Name(pdo, "mentions") |> PrefixedName
