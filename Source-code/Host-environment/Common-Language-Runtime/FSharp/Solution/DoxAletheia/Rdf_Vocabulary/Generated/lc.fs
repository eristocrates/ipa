namespace http.semweb.mmlab.be.ns.linkedconnections.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lc =
    let _namespace_iri = Namespace_Iri lc |> NamespaceIRI

    /// <summary>
    ///   <para>lc:UnscheduledConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Describes a connection that will not happen anymore, and that should not appear in a route planning result as it was unscheduled.</para>
    /// labels<para>Unscheduled Connection</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#UnscheduledConnection">http://semweb.mmlab.be/ns/linkedconnections#UnscheduledConnection</seealso>
    let UnscheduledConnection =
        Prefixed_Name(lc, "UnscheduledConnection") |> PrefixedName

    /// <summary>
    ///   <para>lc:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This ontology provides the predicates necessary to describe a connection or hop from one transit stop to another.</para>
    /// labels<para>The Linked Connections ontology</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#Ontology">http://semweb.mmlab.be/ns/linkedconnections#Ontology</seealso>
    let Ontology = Prefixed_Name(lc, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>lc:Connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Describes a departure at a certain stop and an arrival at a different stop</para>
    /// labels<para>Connection</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#Connection">http://semweb.mmlab.be/ns/linkedconnections#Connection</seealso>
    let Connection = Prefixed_Name(lc, "Connection") |> PrefixedName
    /// <summary>
    ///   <para>lc:arrivalStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A vehicle will stop here on arrival</para>
    /// labels<para>Arrival Stop</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#arrivalStop">http://semweb.mmlab.be/ns/linkedconnections#arrivalStop</seealso>
    let arrivalStop = Prefixed_Name(lc, "arrivalStop") |> PrefixedName
    /// <summary>
    ///   <para>lc:departureTimeQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property representing a departureTime query</para>
    /// labels<para>DepartureTime query</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#departureTimeQuery">http://semweb.mmlab.be/ns/linkedconnections#departureTimeQuery</seealso>
    let departureTimeQuery = Prefixed_Name(lc, "departureTimeQuery") |> PrefixedName
    /// <summary>
    ///   <para>lc:arrivalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time of arrival at a certain stop (when e.g., a delay is announced, the lc:arrivalTime will show that actual time of arrival)</para>
    /// labels<para>Arrival Time</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#arrivalTime">http://semweb.mmlab.be/ns/linkedconnections#arrivalTime</seealso>
    let arrivalTime = Prefixed_Name(lc, "arrivalTime") |> PrefixedName
    /// <summary>
    ///   <para>lc:departureStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A vehicle departs here</para>
    /// labels<para>Departure Stop</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#departureStop">http://semweb.mmlab.be/ns/linkedconnections#departureStop</seealso>
    let departureStop = Prefixed_Name(lc, "departureStop") |> PrefixedName
    /// <summary>
    ///   <para>lc:departureDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time in which the lc:departureTime differs from the scheduled departure time</para>
    /// labels<para>Departure Delay</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#departureDelay">http://semweb.mmlab.be/ns/linkedconnections#departureDelay</seealso>
    let departureDelay = Prefixed_Name(lc, "departureDelay") |> PrefixedName
    /// <summary>
    ///   <para>lc:departureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time of departure at a certain stop (when e.g., a delay is announced, the lc:departureTime will show that actual time of departure)</para>
    /// labels<para>Departure Time</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#departureTime">http://semweb.mmlab.be/ns/linkedconnections#departureTime</seealso>
    let departureTime = Prefixed_Name(lc, "departureTime") |> PrefixedName
    /// <summary>
    ///   <para>lc:nextConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The next connection on this vehicle's trajectory</para>
    /// labels<para>Next Connection</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#nextConnection">http://semweb.mmlab.be/ns/linkedconnections#nextConnection</seealso>
    let nextConnection = Prefixed_Name(lc, "nextConnection") |> PrefixedName
    /// <summary>
    ///   <para>lc:CancelledConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Describes a connection that will not happen anymore, and that should appear as “cancelled” in a route planning result</para>
    /// labels<para>Cancelled Connection</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#CancelledConnection">http://semweb.mmlab.be/ns/linkedconnections#CancelledConnection</seealso>
    let CancelledConnection = Prefixed_Name(lc, "CancelledConnection") |> PrefixedName
    /// <summary>
    ///   <para>lc:arrivalDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time in which the lc:arrivalTime differs from the scheduled arrival time</para>
    /// labels<para>Arrival Delay</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/linkedconnections#arrivalDelay">http://semweb.mmlab.be/ns/linkedconnections#arrivalDelay</seealso>
    let arrivalDelay = Prefixed_Name(lc, "arrivalDelay") |> PrefixedName
