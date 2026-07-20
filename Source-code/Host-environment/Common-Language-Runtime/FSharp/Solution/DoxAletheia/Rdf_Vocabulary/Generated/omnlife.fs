namespace http.open_multinet.info.ontology.omn_lifecycle.hash

open DoxAletheia

module omnlife =
    let _namespace_name = "http://open-multinet.info/ontology/omn-lifecycle#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The related resource/service is actively performing an action
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Active"></see></summary>
    let Active = _prefix "Active"
    /// <summary>
    /// The current state of the resource, service or group
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// The related resources/services are reserved
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Allocated"></see></summary>
    let Allocated = _prefix "Allocated"
    /// <summary>
    /// The current state of a reservation
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#ReservationState"></see></summary>
    let ReservationState = _prefix "ReservationState"
    /// <summary>
    /// The related resource/service has been cleaned
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Cleaned"></see></summary>
    let Cleaned = _prefix "Cleaned"
    /// <summary>
    /// A collection (group) of resources/services/groups confirmed to be allocated for the user.
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Confirmation"></see></summary>
    let Confirmation = _prefix "Confirmation"
    /// <summary>
    /// The related resource/service is in an error state
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Error"></see></summary>
    let Error = _prefix "Error"
    /// <summary>
    /// The related resource/service has been initialized
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Initialized"></see></summary>
    let Initialized = _prefix "Initialized"
    /// <summary>
    /// The related resource/service has been installed
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Installed"></see></summary>
    let Installed = _prefix "Installed"
    /// <summary>
    /// A collection (group) of resources/services/groups allocated for the user.
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Manifest"></see></summary>
    let Manifest = _prefix "Manifest"
    /// <summary>
    /// The related resource/service are not yet active/ready
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#NotYetInitialized"></see></summary>
    let NotYetInitialized = _prefix "NotYetInitialized"
    /// <summary>
    /// A collection (group) of services and resources provided by an Infrastructure. The collection is the result of the application of Policies.
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Offering"></see></summary>
    let Offering = _prefix "Offering"
    /// <summary>
    /// The related resource/service is not yet provisioned
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Pending"></see></summary>
    let Pending = _prefix "Pending"
    /// <summary>
    /// The related resource/service is currently configuring
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Preinit"></see></summary>
    let Preinit = _prefix "Preinit"
    /// <summary>
    /// The related resources/services are provisioned
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Provisioned"></see></summary>
    let Provisioned = _prefix "Provisioned"
    /// <summary>
    /// The related resource/service is ready
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Ready"></see></summary>
    let Ready = _prefix "Ready"
    /// <summary>
    /// The related resource/service gets removed
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Removing"></see></summary>
    let Removing = _prefix "Removing"
    /// <summary>
    /// A collection (group) of resources/services/groups requested by the user
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Request"></see></summary>
    let Request = _prefix "Request"
    /// <summary>
    /// The related resource/service has been started
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Started"></see></summary>
    let Started = _prefix "Started"
    /// <summary>
    /// The related resource/service is stopped
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Stopped"></see></summary>
    let Stopped = _prefix "Stopped"
    /// <summary>
    /// The related resource/service is stopping
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Stopping"></see></summary>
    let Stopping = _prefix "Stopping"
    /// <summary>
    /// The related resources/services are not reserved
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Unallocated"></see></summary>
    let Unallocated = _prefix "Unallocated"
    /// <summary>
    /// The related resource/service is not complete
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Uncompleted"></see></summary>
    let Uncompleted = _prefix "Uncompleted"
    /// <summary>
    /// The related resource/service is getting updated
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#Updating"></see></summary>
    let Updating = _prefix "Updating"
    /// <summary>
    /// A specific authentification information for the management system
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#hasAuthenticationInformation"></see></summary>
    let hasAuthenticationInformation = _prefix "hasAuthenticationInformation"
    /// <summary>
    /// A unique identifier set by the management system
    /// <see href="http://open-multinet.info/ontology/omn-lifecycle#hasID"></see></summary>
    let hasID = _prefix "hasID"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#hasReservationState"></see>
    /// </summary>
    let hasReservationState = _prefix "hasReservationState"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#hasState"></see>
    /// </summary>
    let hasState = _prefix "hasState"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#implementedBy"></see>
    /// </summary>
    let implementedBy = _prefix "implementedBy"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#implements"></see>
    /// </summary>
    let implements = _prefix "implements"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#isReservationStateOf"></see>
    /// </summary>
    let isReservationStateOf = _prefix "isReservationStateOf"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#isStateOf"></see>
    /// </summary>
    let isStateOf = _prefix "isStateOf"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#parentOf"></see>
    /// </summary>
    let parentOf = _prefix "parentOf"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#parentTo"></see>
    /// </summary>
    let parentTo = _prefix "parentTo"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn-lifecycle#usesService"></see>
    /// </summary>
    let usesService = _prefix "usesService"
