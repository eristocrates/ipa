namespace http.www.samos.gr.ontologies.helpdeskOnto.owl.hash

open DoxAletheia.Rdf_Vocabulary

module hdo =
    let _namespace_name = "http://www.samos.gr/ontologies/helpdeskOnto.owl#"
    /// <summary>
    /// This individual is defined for demonstration purposes only and is linked to existing definitions in other LOGD sets
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#NARA"></see></summary>
    let NARA = Namespaced_IRI.parse _namespace_name "NARA" |> NamespacedName

    /// <summary>
    /// A department in the organization that is responsible for the Information Technology (IT) of the organization.
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItDepartment"></see></summary>
    let ItDepartment =
        Namespaced_IRI.parse _namespace_name "ItDepartment" |> NamespacedName

    /// <summary>
    /// A task is an action associated with tickets during an effort to solve an issue/problem in IT.
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItSupportTask"></see></summary>
    let ItSupportTask =
        Namespaced_IRI.parse _namespace_name "ItSupportTask" |> NamespacedName

    /// <summary>
    /// Helpdesk support ticket to record some issue with IT to be diagnosed and resolved.
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItSupportTicket"></see></summary>
    let ItSupportTicket =
        Namespaced_IRI.parse _namespace_name "ItSupportTicket" |> NamespacedName

    /// <summary>
    /// IT depertment at Samos regional unit of NARA
    /// This individual is defined for demonstration purposes only
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#Samos_IT_department_at_NARA"></see></summary>
    let Samos_IT_department_at_NARA =
        Namespaced_IRI.parse _namespace_name "Samos_IT_department_at_NARA" |> NamespacedName

    /// <summary>
    /// a task(ation) description
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskDescription"></see></summary>
    let taskDescription =
        Namespaced_IRI.parse _namespace_name "taskDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskId"></see>
    /// </summary>
    let taskId = Namespaced_IRI.parse _namespace_name "taskId" |> NamespacedName

    /// <summary>
    /// id number to link task to ticket
    /// <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskTicketId"></see></summary>
    let taskTicketId =
        Namespaced_IRI.parse _namespace_name "taskTicketId" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketDescription"></see>
    /// </summary>
    let ticketDescription =
        Namespaced_IRI.parse _namespace_name "ticketDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketId"></see>
    /// </summary>
    let ticketId = Namespaced_IRI.parse _namespace_name "ticketId" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketSolution"></see>
    /// </summary>
    let ticketSolution =
        Namespaced_IRI.parse _namespace_name "ticketSolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketTitle"></see>
    /// </summary>
    let ticketTitle =
        Namespaced_IRI.parse _namespace_name "ticketTitle" |> NamespacedName
