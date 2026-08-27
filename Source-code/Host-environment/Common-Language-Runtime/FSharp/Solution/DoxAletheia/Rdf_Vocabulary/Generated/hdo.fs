namespace http.www.samos.gr.ontologies.helpdeskOnto.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hdo =
    let _namespace_iri = Namespace_Iri hdo |> NamespaceIRI
    /// <summary>
    ///   <para>hdo:ItDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A department in the organization that is responsible for the Information Technology (IT) of the organization."</para>
    /// labels<para>"Information Technology (IT) department"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItDepartment">http://www.samos.gr/ontologies/helpdeskOnto.owl#ItDepartment</seealso>
    let ItDepartment = Prefixed_Name(hdo, "ItDepartment") |> PrefixedName
    /// <summary>
    ///   <para>hdo:ItSupportTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A task is an action associated with tickets during an effort to solve an issue/problem in IT."</para>
    /// labels<para>"IT support task"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItSupportTask">http://www.samos.gr/ontologies/helpdeskOnto.owl#ItSupportTask</seealso>
    let ItSupportTask = Prefixed_Name(hdo, "ItSupportTask") |> PrefixedName
    /// <summary>
    ///   <para>hdo:ItSupportTicket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Helpdesk support ticket to record some issue with IT to be diagnosed and resolved."</para>
    /// labels<para>"IT support Ticket"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ItSupportTicket">http://www.samos.gr/ontologies/helpdeskOnto.owl#ItSupportTicket</seealso>
    let ItSupportTicket = Prefixed_Name(hdo, "ItSupportTicket") |> PrefixedName
    /// <summary>
    ///   <para>hdo:NARA</para>
    /// </summary>
    /// <remarks>
    ///   <para>org:FormalOrganization</para>
    ///   <para>regorg:RegisteredOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual is defined for demonstration purposes only and is linked to existing definitions in other LOGD sets "</para>
    /// labels<para>"ΠΕΡΙΦΕΡΕΙΑ ΒΟΡΕΙΟΥ ΑΙΓΑΙΟΥ"</para><para>"North Aegean Regional Administration (NARA)"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#NARA">http://www.samos.gr/ontologies/helpdeskOnto.owl#NARA</seealso>
    let NARA = Prefixed_Name(hdo, "NARA") |> PrefixedName

    /// <summary>
    ///   <para>hdo:Samos_IT_department_at_NARA</para>
    /// </summary>
    /// <remarks>
    ///   <para>hdo:ItDepartment</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual is defined for demonstration purposes only"</para>
    ///   <para>"IT depertment at Samos regional unit of NARA"</para>
    /// labels<para>"Samos IT department at NARA"</para><para>"Τμήμα Πληροφορικής Περιφερειακής Ενότητας Σάμου"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#Samos_IT_department_at_NARA">http://www.samos.gr/ontologies/helpdeskOnto.owl#Samos_IT_department_at_NARA</seealso>
    let Samos_IT_department_at_NARA =
        Prefixed_Name(hdo, "Samos_IT_department_at_NARA") |> PrefixedName

    /// <summary>
    ///   <para>hdo:taskDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"a task(ation) description"</para>
    /// labels<para>"task description"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskDescription">http://www.samos.gr/ontologies/helpdeskOnto.owl#taskDescription</seealso>
    let taskDescription = Prefixed_Name(hdo, "taskDescription") |> PrefixedName
    /// <summary>
    ///   <para>hdo:taskId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"task identification id"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskId">http://www.samos.gr/ontologies/helpdeskOnto.owl#taskId</seealso>
    let taskId = Prefixed_Name(hdo, "taskId") |> PrefixedName
    /// <summary>
    ///   <para>hdo:taskTicketId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"id number to link task to ticket"</para>
    /// labels<para>"task ticket identification id"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#taskTicketId">http://www.samos.gr/ontologies/helpdeskOnto.owl#taskTicketId</seealso>
    let taskTicketId = Prefixed_Name(hdo, "taskTicketId") |> PrefixedName
    /// <summary>
    ///   <para>hdo:ticketDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ticket description"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketDescription">http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketDescription</seealso>
    let ticketDescription = Prefixed_Name(hdo, "ticketDescription") |> PrefixedName
    /// <summary>
    ///   <para>hdo:ticketId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ticket id"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketId">http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketId</seealso>
    let ticketId = Prefixed_Name(hdo, "ticketId") |> PrefixedName
    /// <summary>
    ///   <para>hdo:ticketSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ticket solution"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketSolution">http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketSolution</seealso>
    let ticketSolution = Prefixed_Name(hdo, "ticketSolution") |> PrefixedName
    /// <summary>
    ///   <para>hdo:ticketTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"ticket title"</para></remarks>
    /// <seealso href="http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketTitle">http://www.samos.gr/ontologies/helpdeskOnto.owl#ticketTitle</seealso>
    let ticketTitle = Prefixed_Name(hdo, "ticketTitle") |> PrefixedName
