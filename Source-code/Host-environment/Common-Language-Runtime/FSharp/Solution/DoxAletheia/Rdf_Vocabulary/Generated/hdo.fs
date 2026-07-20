namespace http.www.samos.gr.ontologies.helpdeskOnto.owl.hash

open DoxAletheia

module hdo =
    let _namespace_name = "http://www.samos.gr/ontologies/helpdeskOnto.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This individual is defined for demonstration purposes only and is linked to existing definitions in other LOGD sets
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#NARA"></see></summary>
    let NARA = _prefix "NARA"
    /// <summary>
    /// A department in the organization that is responsible for the Information Technology (IT) of the organization.
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItDepartment"></see></summary>
    let ItDepartment = _prefix "ItDepartment"
    /// <summary>
    /// A task is an action associated with tickets during an effort to solve an issue/problem in IT.
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItSupportTask"></see></summary>
    let ItSupportTask = _prefix "ItSupportTask"
    /// <summary>
    /// Helpdesk support ticket to record some issue with IT to be diagnosed and resolved.
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItSupportTicket"></see></summary>
    let ItSupportTicket = _prefix "ItSupportTicket"
    /// <summary>
    /// IT depertment at Samos regional unit of NARA
    /// This individual is defined for demonstration purposes only
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#Samos_IT_department_at_NARA"></see></summary>
    let Samos_IT_department_at_NARA = _prefix "Samos_IT_department_at_NARA"
    /// <summary>
    /// a task(ation) description
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskDescription"></see></summary>
    let taskDescription = _prefix "taskDescription"
    /// <summary>
    ///   <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskId"></see>
    /// </summary>
    let taskId = _prefix "taskId"
    /// <summary>
    /// id number to link task to ticket
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskTicketId"></see></summary>
    let taskTicketId = _prefix "taskTicketId"
    /// <summary>
    ///   <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketDescription"></see>
    /// </summary>
    let ticketDescription = _prefix "ticketDescription"
    /// <summary>
    ///   <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketId"></see>
    /// </summary>
    let ticketId = _prefix "ticketId"
    /// <summary>
    ///   <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketSolution"></see>
    /// </summary>
    let ticketSolution = _prefix "ticketSolution"
    /// <summary>
    ///   <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketTitle"></see>
    /// </summary>
    let ticketTitle = _prefix "ticketTitle"
