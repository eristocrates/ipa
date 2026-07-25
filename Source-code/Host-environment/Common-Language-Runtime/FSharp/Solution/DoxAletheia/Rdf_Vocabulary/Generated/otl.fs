namespace https.w3id.org.opentrafficlights.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module otl =
    let _namespace_iri = Namespace_Iri otl |> NamespaceIRI
    /// <summary>
    ///   <para>otl:Lane</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Describes a part of the road where a passenger departs or arrives from.</para>
    /// labels<para>Lane</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#Lane">https://w3id.org/opentrafficlights#Lane</seealso>
    let Lane = Prefixed_Name(otl, "Lane") |> PrefixedName
    /// <summary>
    ///   <para>otl:SignalGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Describes a group of traffic lights that have the same Signal state.</para>
    /// labels<para>Signal group</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#SignalGroup">https://w3id.org/opentrafficlights#SignalGroup</seealso>
    let SignalGroup = Prefixed_Name(otl, "SignalGroup") |> PrefixedName
    /// <summary>
    ///   <para>otl:Connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Describes a departure at a certain lane and an arrival at a different lane</para>
    /// labels<para>Connection</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#Connection">https://w3id.org/opentrafficlights#Connection</seealso>
    let Connection = Prefixed_Name(otl, "Connection") |> PrefixedName
    /// <summary>
    ///   <para>otl:SignalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Describes the state of a Signal group.</para>
    /// labels<para>Signal state</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#SignalState">https://w3id.org/opentrafficlights#SignalState</seealso>
    let SignalState = Prefixed_Name(otl, "SignalState") |> PrefixedName
    /// <summary>
    ///   <para>otl:signalPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents green, red etc. Adviced to use concept scheme https://w3id.org/opentrafficlights/thesauri/signalphase</para>
    /// labels<para>Phase of a Signal state</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#signalPhase">https://w3id.org/opentrafficlights#signalPhase</seealso>
    let signalPhase = Prefixed_Name(otl, "signalPhase") |> PrefixedName
    /// <summary>
    ///   <para>otl:arrivalLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A road user will arrive here</para>
    /// labels<para>Arrival lane</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#arrivalLane">https://w3id.org/opentrafficlights#arrivalLane</seealso>
    let arrivalLane = Prefixed_Name(otl, "arrivalLane") |> PrefixedName
    /// <summary>
    ///   <para>otl:minEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The earliest time possible at which the event state could change, except when unpredictable events relating to a pre-emption or priority call disrupt a currently active timing plan.</para>
    /// labels<para>Minimum end time</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#minEndTime">https://w3id.org/opentrafficlights#minEndTime</seealso>
    let minEndTime = Prefixed_Name(otl, "minEndTime") |> PrefixedName
    /// <summary>
    ///   <para>otl:signalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Signal state of a signal group.</para>
    /// labels<para>Signal state</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#signalState">https://w3id.org/opentrafficlights#signalState</seealso>
    let signalState = Prefixed_Name(otl, "signalState") |> PrefixedName
    /// <summary>
    ///   <para>otl:departureLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A road user will depart from here</para>
    /// labels<para>Departure lane</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#departureLane">https://w3id.org/opentrafficlights#departureLane</seealso>
    let departureLane = Prefixed_Name(otl, "departureLane") |> PrefixedName
    /// <summary>
    ///   <para>otl:maxEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The latest time possible at which the event state could change, except when unpredictable events relating to a pre-emption or priority call disrupt a currently active timing plan.</para>
    /// labels<para>Maximum end time</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#maxEndTime">https://w3id.org/opentrafficlights#maxEndTime</seealso>
    let maxEndTime = Prefixed_Name(otl, "maxEndTime") |> PrefixedName
    /// <summary>
    ///   <para>otl:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The width of a lane expressed in centimeters.</para>
    /// labels<para>Width</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#width">https://w3id.org/opentrafficlights#width</seealso>
    let width = Prefixed_Name(otl, "width") |> PrefixedName
    /// <summary>
    ///   <para>otl:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This ontology provides the terms necessary to describe the status of traffic lights.</para>
    /// labels<para>The Open Traffic Lights ontology</para></remarks>
    /// <seealso href="https://w3id.org/opentrafficlights#Ontology">https://w3id.org/opentrafficlights#Ontology</seealso>
    let Ontology = Prefixed_Name(otl, "Ontology") |> PrefixedName
