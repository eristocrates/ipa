namespace http.open_multinet.info.ontology.omn_lifecycle.hash

open DoxAletheia.Rdf_Vocabulary

module omnlife =
    let _namespace_name = "http://open-multinet.info/ontology/omn-lifecycle#"
    /// <summary>
    /// The related resource/service is actively performing an action
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Active"></see></summary>
    let Active = Namespaced_IRI.parse _namespace_name "Active" |> NamespacedName
    /// <summary>
    /// The current state of the resource, service or group
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    /// The related resources/services are reserved
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Allocated"></see></summary>
    let Allocated = Namespaced_IRI.parse _namespace_name "Allocated" |> NamespacedName

    /// <summary>
    /// The current state of a reservation
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#ReservationState"></see></summary>
    let ReservationState =
        Namespaced_IRI.parse _namespace_name "ReservationState" |> NamespacedName

    /// <summary>
    /// The related resource/service has been cleaned
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Cleaned"></see></summary>
    let Cleaned = Namespaced_IRI.parse _namespace_name "Cleaned" |> NamespacedName

    /// <summary>
    /// A collection (group) of resources/services/groups confirmed to be allocated for the user.
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Confirmation"></see></summary>
    let Confirmation =
        Namespaced_IRI.parse _namespace_name "Confirmation" |> NamespacedName

    /// <summary>
    /// The related resource/service is in an error state
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Error"></see></summary>
    let Error = Namespaced_IRI.parse _namespace_name "Error" |> NamespacedName

    /// <summary>
    /// The related resource/service has been initialized
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Initialized"></see></summary>
    let Initialized =
        Namespaced_IRI.parse _namespace_name "Initialized" |> NamespacedName

    /// <summary>
    /// The related resource/service has been installed
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Installed"></see></summary>
    let Installed = Namespaced_IRI.parse _namespace_name "Installed" |> NamespacedName
    /// <summary>
    /// A collection (group) of resources/services/groups allocated for the user.
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Manifest"></see></summary>
    let Manifest = Namespaced_IRI.parse _namespace_name "Manifest" |> NamespacedName

    /// <summary>
    /// The related resource/service are not yet active/ready
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#NotYetInitialized"></see></summary>
    let NotYetInitialized =
        Namespaced_IRI.parse _namespace_name "NotYetInitialized" |> NamespacedName

    /// <summary>
    /// A collection (group) of services and resources provided by an Infrastructure. The collection is the result of the application of Policies.
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Offering"></see></summary>
    let Offering = Namespaced_IRI.parse _namespace_name "Offering" |> NamespacedName
    /// <summary>
    /// The related resource/service is not yet provisioned
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Pending"></see></summary>
    let Pending = Namespaced_IRI.parse _namespace_name "Pending" |> NamespacedName
    /// <summary>
    /// The related resource/service is currently configuring
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Preinit"></see></summary>
    let Preinit = Namespaced_IRI.parse _namespace_name "Preinit" |> NamespacedName

    /// <summary>
    /// The related resources/services are provisioned
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Provisioned"></see></summary>
    let Provisioned =
        Namespaced_IRI.parse _namespace_name "Provisioned" |> NamespacedName

    /// <summary>
    /// The related resource/service is ready
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Ready"></see></summary>
    let Ready = Namespaced_IRI.parse _namespace_name "Ready" |> NamespacedName
    /// <summary>
    /// The related resource/service gets removed
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Removing"></see></summary>
    let Removing = Namespaced_IRI.parse _namespace_name "Removing" |> NamespacedName
    /// <summary>
    /// A collection (group) of resources/services/groups requested by the user
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Request"></see></summary>
    let Request = Namespaced_IRI.parse _namespace_name "Request" |> NamespacedName
    /// <summary>
    /// The related resource/service has been started
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Started"></see></summary>
    let Started = Namespaced_IRI.parse _namespace_name "Started" |> NamespacedName
    /// <summary>
    /// The related resource/service is stopped
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Stopped"></see></summary>
    let Stopped = Namespaced_IRI.parse _namespace_name "Stopped" |> NamespacedName
    /// <summary>
    /// The related resource/service is stopping
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Stopping"></see></summary>
    let Stopping = Namespaced_IRI.parse _namespace_name "Stopping" |> NamespacedName

    /// <summary>
    /// The related resources/services are not reserved
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Unallocated"></see></summary>
    let Unallocated =
        Namespaced_IRI.parse _namespace_name "Unallocated" |> NamespacedName

    /// <summary>
    /// The related resource/service is not complete
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Uncompleted"></see></summary>
    let Uncompleted =
        Namespaced_IRI.parse _namespace_name "Uncompleted" |> NamespacedName

    /// <summary>
    /// The related resource/service is getting updated
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Updating"></see></summary>
    let Updating = Namespaced_IRI.parse _namespace_name "Updating" |> NamespacedName

    /// <summary>
    /// A specific authentification information for the management system
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#hasAuthenticationInformation"></see></summary>
    let hasAuthenticationInformation =
        Namespaced_IRI.parse _namespace_name "hasAuthenticationInformation" |> NamespacedName

    /// <summary>
    /// A unique identifier set by the management system
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#hasID"></see></summary>
    let hasID = Namespaced_IRI.parse _namespace_name "hasID" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#hasReservationState"></see>
    /// </summary>
    let hasReservationState =
        Namespaced_IRI.parse _namespace_name "hasReservationState" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#hasState"></see>
    /// </summary>
    let hasState = Namespaced_IRI.parse _namespace_name "hasState" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#implementedBy"></see>
    /// </summary>
    let implementedBy =
        Namespaced_IRI.parse _namespace_name "implementedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#implements"></see>
    /// </summary>
    let implements = Namespaced_IRI.parse _namespace_name "implements" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#isReservationStateOf"></see>
    /// </summary>
    let isReservationStateOf =
        Namespaced_IRI.parse _namespace_name "isReservationStateOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#isStateOf"></see>
    /// </summary>
    let isStateOf = Namespaced_IRI.parse _namespace_name "isStateOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#parentOf"></see>
    /// </summary>
    let parentOf = Namespaced_IRI.parse _namespace_name "parentOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#parentTo"></see>
    /// </summary>
    let parentTo = Namespaced_IRI.parse _namespace_name "parentTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#usesService"></see>
    /// </summary>
    let usesService =
        Namespaced_IRI.parse _namespace_name "usesService" |> NamespacedName
