#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hdo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.samos.gr/ontologies/helpdeskOnto.owl#" "hdo"

    /// <summary>
    ///   <para>rdfs:label : Information Technology (IT) department</para>
    ///   <para>rdfs:isDefinedBy : http://www.samos.gr/ontologies/helpdeskOnto.owl^^xsd:string</para>
    ///   <para>rdfs:comment : A department in the organization that is responsible for the Information Technology (IT) of the organization.</para>
    ///   <a href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItDepartment">hdo:ItDepartment</a>
    /// </summary>
    let ItDepartment = _prefixId.prefix "ItDepartment"
    /// <summary>
    ///   <para>rdfs:label : IT support task</para>
    ///   <para>rdfs:isDefinedBy : http://www.samos.gr/ontologies/helpdeskOnto.owl^^xsd:string</para>
    ///   <para>rdfs:comment : A task is an action associated with tickets during an effort to solve an issue/problem in IT.</para>
    ///   <a href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItSupportTask">hdo:ItSupportTask</a>
    /// </summary>
    let ItSupportTask = _prefixId.prefix "ItSupportTask"
    /// <summary>
    ///   <para>rdfs:label : IT support Ticket</para>
    ///   <para>rdfs:comment : Helpdesk support ticket to record some issue with IT to be diagnosed and resolved.</para>
    ///   <a href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItSupportTicket">hdo:ItSupportTicket</a>
    /// </summary>
    let ItSupportTicket = _prefixId.prefix "ItSupportTicket"
    let NARA = _prefixId.prefix "NARA"
    let Samos_IT_department_at_NARA = _prefixId.prefix "Samos_IT_department_at_NARA"
    /// <summary>
    ///   <para>rdfs:label : task description</para>
    ///   <para>rdfs:isDefinedBy : http://www.samos.gr/ontologies/helpdeskOnto.owl^^xsd:string</para>
    ///   <para>rdfs:comment : a task(ation) description</para>
    ///   <a href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskDescription">hdo:taskDescription</a>
    /// </summary>
    let taskDescription = _prefixId.prefix "taskDescription"
    /// <summary>
    ///   <para>rdfs:label : task identification id</para>
    ///   <para>rdfs:isDefinedBy : http://www.samos.gr/ontologies/helpdeskOnto.owl^^xsd:string</para>
    ///   <a href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskId">hdo:taskId</a>
    /// </summary>
    let taskId = _prefixId.prefix "taskId"
    /// <summary>
    ///   <para>rdfs:label : task ticket identification id</para>
    ///   <para>rdfs:isDefinedBy : http://www.samos.gr/ontologies/helpdeskOnto.owl^^xsd:string</para>
    ///   <para>rdfs:comment : id number to link task to ticket</para>
    ///   <a href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskTicketId">hdo:taskTicketId</a>
    /// </summary>
    let taskTicketId = _prefixId.prefix "taskTicketId"
    /// <summary>
    ///   <para>rdfs:label : ticket description</para>
    ///   <para>rdfs:isDefinedBy : http://www.samos.gr/ontologies/helpdeskOnto.owl^^xsd:string</para>
    ///   <a href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketDescription">hdo:ticketDescription</a>
    /// </summary>
    let ticketDescription = _prefixId.prefix "ticketDescription"
    /// <summary>
    ///   <para>rdfs:label : ticket id</para>
    ///   <para>rdfs:isDefinedBy : http://www.samos.gr/ontologies/helpdeskOnto.owl^^xsd:string</para>
    ///   <a href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketId">hdo:ticketId</a>
    /// </summary>
    let ticketId = _prefixId.prefix "ticketId"
    /// <summary>
    ///   <para>rdfs:label : ticket solution</para>
    ///   <para>rdfs:isDefinedBy : http://www.samos.gr/ontologies/helpdeskOnto.owl^^xsd:string</para>
    ///   <a href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketSolution">hdo:ticketSolution</a>
    /// </summary>
    let ticketSolution = _prefixId.prefix "ticketSolution"
    /// <summary>
    ///   <para>rdfs:label : ticket title</para>
    ///   <a href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketTitle">hdo:ticketTitle</a>
    /// </summary>
    let ticketTitle = _prefixId.prefix "ticketTitle"
