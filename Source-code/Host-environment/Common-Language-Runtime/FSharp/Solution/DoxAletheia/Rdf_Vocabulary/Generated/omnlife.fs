namespace http.open_multinet.info.ontology.omn_lifecycle.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module omnlife =
    let _namespace_iri = Namespace_Iri omnlife |> NamespaceIRI
    /// <summary>
    ///   <para>omnlife:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#">http://open-multinet.info/ontology/omn-lifecycle#</seealso>
    let _prefix_iri = Prefixed_Name(omnlife, "") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Active</para>
    /// </summary>
    /// <remarks>
    ///   <para>omnlife:State</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The related resource/service is actively performing an action"</para>
    /// labels<para>"Active"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Active">http://open-multinet.info/ontology/omn-lifecycle#Active</seealso>
    let Active = Prefixed_Name(omnlife, "Active") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Allocated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>omnlife:ReservationState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The related resources/services are reserved"</para>
    /// labels<para>"Allocated"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Allocated">http://open-multinet.info/ontology/omn-lifecycle#Allocated</seealso>
    let Allocated = Prefixed_Name(omnlife, "Allocated") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Cleaned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>omnlife:State</para>
    ///   <para>"The related resource/service has been cleaned"</para>
    /// labels<para>"Cleaned"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Cleaned">http://open-multinet.info/ontology/omn-lifecycle#Cleaned</seealso>
    let Cleaned = Prefixed_Name(omnlife, "Cleaned") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Confirmation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection (group) of resources/services/groups confirmed to be allocated for the user."</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Confirmation">http://open-multinet.info/ontology/omn-lifecycle#Confirmation</seealso>
    let Confirmation = Prefixed_Name(omnlife, "Confirmation") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Error</para>
    /// </summary>
    /// <remarks>
    ///   <para>omnlife:State</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The related resource/service is in an error state"</para>
    /// labels<para>"Error"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Error">http://open-multinet.info/ontology/omn-lifecycle#Error</seealso>
    let Error = Prefixed_Name(omnlife, "Error") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Initialized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>omnlife:State</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The related resource/service has been initialized"</para>
    /// labels<para>"Initialized"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Initialized">http://open-multinet.info/ontology/omn-lifecycle#Initialized</seealso>
    let Initialized = Prefixed_Name(omnlife, "Initialized") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Installed</para>
    /// </summary>
    /// <remarks>
    ///   <para>omnlife:State</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The related resource/service has been installed"</para>
    /// labels<para>"Installed"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Installed">http://open-multinet.info/ontology/omn-lifecycle#Installed</seealso>
    let Installed = Prefixed_Name(omnlife, "Installed") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Manifest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection (group) of resources/services/groups allocated for the user."</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Manifest">http://open-multinet.info/ontology/omn-lifecycle#Manifest</seealso>
    let Manifest = Prefixed_Name(omnlife, "Manifest") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:NotYetInitialized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>omnlife:State</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The related resource/service are not yet active/ready"</para>
    /// labels<para>"NotYetInitialized"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#NotYetInitialized">http://open-multinet.info/ontology/omn-lifecycle#NotYetInitialized</seealso>
    let NotYetInitialized = Prefixed_Name(omnlife, "NotYetInitialized") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Offering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection (group) of services and resources provided by an Infrastructure. The collection is the result of the application of Policies."</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Offering">http://open-multinet.info/ontology/omn-lifecycle#Offering</seealso>
    let Offering = Prefixed_Name(omnlife, "Offering") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Pending</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>omnlife:State</para>
    ///   <para>"The related resource/service is not yet provisioned"</para>
    /// labels<para>"Pending"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Pending">http://open-multinet.info/ontology/omn-lifecycle#Pending</seealso>
    let Pending = Prefixed_Name(omnlife, "Pending") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Preinit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>omnlife:State</para>
    ///   <para>"The related resource/service is currently configuring"</para>
    /// labels<para>"Preinit"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Preinit">http://open-multinet.info/ontology/omn-lifecycle#Preinit</seealso>
    let Preinit = Prefixed_Name(omnlife, "Preinit") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Provisioned</para>
    /// </summary>
    /// <remarks>
    ///   <para>omnlife:ReservationState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The related resources/services are provisioned"</para>
    /// labels<para>"Provisioned"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Provisioned">http://open-multinet.info/ontology/omn-lifecycle#Provisioned</seealso>
    let Provisioned = Prefixed_Name(omnlife, "Provisioned") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Ready</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>omnlife:State</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The related resource/service is ready"</para>
    /// labels<para>"Ready"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Ready">http://open-multinet.info/ontology/omn-lifecycle#Ready</seealso>
    let Ready = Prefixed_Name(omnlife, "Ready") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Removing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>omnlife:State</para>
    ///   <para>owl:Class</para>
    ///   <para>"The related resource/service gets removed"</para>
    /// labels<para>"Removing"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Removing">http://open-multinet.info/ontology/omn-lifecycle#Removing</seealso>
    let Removing = Prefixed_Name(omnlife, "Removing") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection (group) of resources/services/groups requested by the user"</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Request">http://open-multinet.info/ontology/omn-lifecycle#Request</seealso>
    let Request = Prefixed_Name(omnlife, "Request") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:ReservationState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The current state of a reservation"</para>
    /// labels<para>"Reservation State"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#ReservationState">http://open-multinet.info/ontology/omn-lifecycle#ReservationState</seealso>
    let ReservationState = Prefixed_Name(omnlife, "ReservationState") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Started</para>
    /// </summary>
    /// <remarks>
    ///   <para>omnlife:State</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The related resource/service has been started"</para>
    /// labels<para>"Started"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Started">http://open-multinet.info/ontology/omn-lifecycle#Started</seealso>
    let Started = Prefixed_Name(omnlife, "Started") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The current state of the resource, service or group"</para>
    /// labels<para>"State"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#State">http://open-multinet.info/ontology/omn-lifecycle#State</seealso>
    let State = Prefixed_Name(omnlife, "State") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Stopped</para>
    /// </summary>
    /// <remarks>
    ///   <para>omnlife:State</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The related resource/service is stopped"</para>
    /// labels<para>"Stopped"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Stopped">http://open-multinet.info/ontology/omn-lifecycle#Stopped</seealso>
    let Stopped = Prefixed_Name(omnlife, "Stopped") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Stopping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>omnlife:State</para>
    ///   <para>"The related resource/service is stopping"</para>
    /// labels<para>"Stopping"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Stopping">http://open-multinet.info/ontology/omn-lifecycle#Stopping</seealso>
    let Stopping = Prefixed_Name(omnlife, "Stopping") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Unallocated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>omnlife:ReservationState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The related resources/services are not reserved"</para>
    /// labels<para>"Unallocated"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Unallocated">http://open-multinet.info/ontology/omn-lifecycle#Unallocated</seealso>
    let Unallocated = Prefixed_Name(omnlife, "Unallocated") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Uncompleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>omnlife:State</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The related resource/service is not complete"</para>
    /// labels<para>"Uncompleted"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Uncompleted">http://open-multinet.info/ontology/omn-lifecycle#Uncompleted</seealso>
    let Uncompleted = Prefixed_Name(omnlife, "Uncompleted") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:Updating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>omnlife:State</para>
    ///   <para>owl:Class</para>
    ///   <para>"The related resource/service is getting updated"</para>
    /// labels<para>"Updating"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#Updating">http://open-multinet.info/ontology/omn-lifecycle#Updating</seealso>
    let Updating = Prefixed_Name(omnlife, "Updating") |> PrefixedName

    /// <summary>
    ///   <para>omnlife:hasAuthenticationInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A specific authentification information for the management system"</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#hasAuthenticationInformation">http://open-multinet.info/ontology/omn-lifecycle#hasAuthenticationInformation</seealso>
    let hasAuthenticationInformation =
        Prefixed_Name(omnlife, "hasAuthenticationInformation") |> PrefixedName

    /// <summary>
    ///   <para>omnlife:hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A unique identifier set by the management system"</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#hasID">http://open-multinet.info/ontology/omn-lifecycle#hasID</seealso>
    let hasID = Prefixed_Name(omnlife, "hasID") |> PrefixedName

    /// <summary>
    ///   <para>omnlife:hasReservationState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#hasReservationState">http://open-multinet.info/ontology/omn-lifecycle#hasReservationState</seealso>
    let hasReservationState =
        Prefixed_Name(omnlife, "hasReservationState") |> PrefixedName

    /// <summary>
    ///   <para>omnlife:hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#hasState">http://open-multinet.info/ontology/omn-lifecycle#hasState</seealso>
    let hasState = Prefixed_Name(omnlife, "hasState") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:implementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#implementedBy">http://open-multinet.info/ontology/omn-lifecycle#implementedBy</seealso>
    let implementedBy = Prefixed_Name(omnlife, "implementedBy") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#implements">http://open-multinet.info/ontology/omn-lifecycle#implements</seealso>
    let implements = Prefixed_Name(omnlife, "implements") |> PrefixedName

    /// <summary>
    ///   <para>omnlife:isReservationStateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#isReservationStateOf">http://open-multinet.info/ontology/omn-lifecycle#isReservationStateOf</seealso>
    let isReservationStateOf =
        Prefixed_Name(omnlife, "isReservationStateOf") |> PrefixedName

    /// <summary>
    ///   <para>omnlife:isStateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#isStateOf">http://open-multinet.info/ontology/omn-lifecycle#isStateOf</seealso>
    let isStateOf = Prefixed_Name(omnlife, "isStateOf") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:parentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#parentOf">http://open-multinet.info/ontology/omn-lifecycle#parentOf</seealso>
    let parentOf = Prefixed_Name(omnlife, "parentOf") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:parentTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#parentTo">http://open-multinet.info/ontology/omn-lifecycle#parentTo</seealso>
    let parentTo = Prefixed_Name(omnlife, "parentTo") |> PrefixedName
    /// <summary>
    ///   <para>omnlife:usesService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn-lifecycle#usesService">http://open-multinet.info/ontology/omn-lifecycle#usesService</seealso>
    let usesService = Prefixed_Name(omnlife, "usesService") |> PrefixedName
