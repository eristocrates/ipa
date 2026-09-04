#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module omnlc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://open-multinet.info/ontology/omn-lifecycle#" "omnlc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI geni_ready_busy operational state</para>
    ///   <para>rdfs:label : Active</para>
    ///   <para>rdfs:comment : The related resource/service is actively performing an action</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Active">omnlc:Active</a>
    /// </summary>
    let Active = _prefixId.prefix "Active"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI geni_allocated allocation state</para>
    ///   <para>rdfs:label : Allocated</para>
    ///   <para>rdfs:comment : The related resources/services are reserved</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Allocated">omnlc:Allocated</a>
    /// </summary>
    let Allocated = _prefixId.prefix "Allocated"
    /// <summary>
    ///   <para>rdfs:label : Cleaned</para>
    ///   <para>rdfs:comment : The related resource/service has been cleaned</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Cleaned">omnlc:Cleaned</a>
    /// </summary>
    let Cleaned = _prefixId.prefix "Cleaned"
    /// <summary>
    ///   <para>rdfs:comment : A collection (group) of resources/services/groups confirmed to be allocated for the user.</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Confirmation">omnlc:Confirmation</a>
    /// </summary>
    let Confirmation = _prefixId.prefix "Confirmation"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI geni_failed operational state</para>
    ///   <para>rdfs:label : Error</para>
    ///   <para>rdfs:comment : The related resource/service is in an error state</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Error">omnlc:Error</a>
    /// </summary>
    let Error = _prefixId.prefix "Error"
    /// <summary>
    ///   <para>rdfs:label : Initialized</para>
    ///   <para>rdfs:comment : The related resource/service has been initialized</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Initialized">omnlc:Initialized</a>
    /// </summary>
    let Initialized = _prefixId.prefix "Initialized"
    /// <summary>
    ///   <para>rdfs:label : Installed</para>
    ///   <para>rdfs:comment : The related resource/service has been installed</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Installed">omnlc:Installed</a>
    /// </summary>
    let Installed = _prefixId.prefix "Installed"
    /// <summary>
    ///   <para>rdfs:comment : A collection (group) of resources/services/groups allocated for the user.</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Manifest">omnlc:Manifest</a>
    /// </summary>
    let Manifest = _prefixId.prefix "Manifest"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI geni_instantiating operational state</para>
    ///   <para>rdfs:label : NotYetInitialized</para>
    ///   <para>rdfs:comment : The related resource/service are not yet active/ready</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#NotYetInitialized">omnlc:NotYetInitialized</a>
    /// </summary>
    let NotYetInitialized = _prefixId.prefix "NotYetInitialized"
    /// <summary>
    ///   <para>rdfs:comment : A collection (group) of services and resources provided by an Infrastructure. The collection is the result of the application of Policies.</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Offering">omnlc:Offering</a>
    /// </summary>
    let Offering = _prefixId.prefix "Offering"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI geni_pending_allocation operational state</para>
    ///   <para>rdfs:label : Pending</para>
    ///   <para>rdfs:comment : The related resource/service is not yet provisioned</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Pending">omnlc:Pending</a>
    /// </summary>
    let Pending = _prefixId.prefix "Pending"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI geni_configuring operational state</para>
    ///   <para>rdfs:label : Preinit</para>
    ///   <para>rdfs:comment : The related resource/service is currently configuring</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Preinit">omnlc:Preinit</a>
    /// </summary>
    let Preinit = _prefixId.prefix "Preinit"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI geni_provisioned allocation state</para>
    ///   <para>rdfs:label : Provisioned</para>
    ///   <para>rdfs:comment : The related resources/services are provisioned</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Provisioned">omnlc:Provisioned</a>
    /// </summary>
    let Provisioned = _prefixId.prefix "Provisioned"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI geni_ready operational state</para>
    ///   <para>rdfs:label : Ready</para>
    ///   <para>rdfs:comment : The related resource/service is ready</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Ready">omnlc:Ready</a>
    /// </summary>
    let Ready = _prefixId.prefix "Ready"
    /// <summary>
    ///   <para>rdfs:label : Removing</para>
    ///   <para>rdfs:comment : The related resource/service gets removed</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Removing">omnlc:Removing</a>
    /// </summary>
    let Removing = _prefixId.prefix "Removing"
    /// <summary>
    ///   <para>rdfs:comment : A collection (group) of resources/services/groups requested by the user</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Request">omnlc:Request</a>
    /// </summary>
    let Request = _prefixId.prefix "Request"
    /// <summary>
    ///   <para>rdfs:label : Reservation State</para>
    ///   <para>rdfs:comment : The current state of a reservation</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#ReservationState">omnlc:ReservationState</a>
    /// </summary>
    let ReservationState = _prefixId.prefix "ReservationState"
    /// <summary>
    ///   <para>rdfs:label : Started</para>
    ///   <para>rdfs:comment : The related resource/service has been started</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Started">omnlc:Started</a>
    /// </summary>
    let Started = _prefixId.prefix "Started"
    /// <summary>
    ///   <para>rdfs:label : State</para>
    ///   <para>rdfs:comment : The current state of the resource, service or group</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#State">omnlc:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : Stopped</para>
    ///   <para>rdfs:comment : The related resource/service is stopped</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Stopped">omnlc:Stopped</a>
    /// </summary>
    let Stopped = _prefixId.prefix "Stopped"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI geni_stopping operational state</para>
    ///   <para>rdfs:label : Stopping</para>
    ///   <para>rdfs:comment : The related resource/service is stopping</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Stopping">omnlc:Stopping</a>
    /// </summary>
    let Stopping = _prefixId.prefix "Stopping"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI geni_unallocated allocation state</para>
    ///   <para>rdfs:label : Unallocated</para>
    ///   <para>rdfs:comment : The related resources/services are not reserved</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Unallocated">omnlc:Unallocated</a>
    /// </summary>
    let Unallocated = _prefixId.prefix "Unallocated"
    /// <summary>
    ///   <para>rdfs:label : Uncompleted</para>
    ///   <para>rdfs:comment : The related resource/service is not complete</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Uncompleted">omnlc:Uncompleted</a>
    /// </summary>
    let Uncompleted = _prefixId.prefix "Uncompleted"
    /// <summary>
    ///   <para>rdfs:label : Updating</para>
    ///   <para>rdfs:comment : The related resource/service is getting updated</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#Updating">omnlc:Updating</a>
    /// </summary>
    let Updating = _prefixId.prefix "Updating"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI Slice X.509 certificates</para>
    ///   <para>rdfs:comment : A specific authentification information for the management system</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#hasAuthenticationInformation">omnlc:hasAuthenticationInformation</a>
    /// </summary>
    let hasAuthenticationInformation = _prefixId.prefix "hasAuthenticationInformation"
    /// <summary>
    ///   <para>rdfs:seeAlso : GENI Manifest RSpec v3: component_id</para>
    ///   <para>rdfs:comment : A unique identifier set by the management system</para>
    ///   <a href="http://open-multinet.info/ontology/omn-lifecycle#hasID">omnlc:hasID</a>
    /// </summary>
    let hasID = _prefixId.prefix "hasID"
    let hasReservationState = _prefixId.prefix "hasReservationState"
    let hasState = _prefixId.prefix "hasState"
    let implementedBy = _prefixId.prefix "implementedBy"
    let implements = _prefixId.prefix "implements"
    let isReservationStateOf = _prefixId.prefix "isReservationStateOf"
    let isStateOf = _prefixId.prefix "isStateOf"
    let parentOf = _prefixId.prefix "parentOf"
    let parentTo = _prefixId.prefix "parentTo"
    let usesService = _prefixId.prefix "usesService"
