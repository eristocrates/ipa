#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://semweb.mmlab.be/ns/linkedconnections#" "lc"

    /// <summary>
    ///   <para>rdfs:comment : Describes a connection that will not happen anymore, and that should appear as “cancelled” in a route planning result</para>
    ///   <para>rdfs:label : Cancelled Connection</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#CancelledConnection">lc:CancelledConnection</a>
    /// </summary>
    let CancelledConnection = _prefixId.prefix "CancelledConnection"
    /// <summary>
    ///   <para>rdfs:comment : Describes a departure at a certain stop and an arrival at a different stop</para>
    ///   <para>rdfs:label : Connection</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#Connection">lc:Connection</a>
    /// </summary>
    let Connection = _prefixId.prefix "Connection"
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:comment : Describes a connection that will not happen anymore, and that should not appear in a route planning result as it was unscheduled.</para>
    ///   <para>rdfs:label : Unscheduled Connection</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#UnscheduledConnection">lc:UnscheduledConnection</a>
    /// </summary>
    let UnscheduledConnection = _prefixId.prefix "UnscheduledConnection"
    /// <summary>
    ///   <para>rdfs:comment : The time in which the lc:arrivalTime differs from the scheduled arrival time</para>
    ///   <para>rdfs:label : Arrival Delay</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#arrivalDelay">lc:arrivalDelay</a>
    /// </summary>
    let arrivalDelay = _prefixId.prefix "arrivalDelay"
    /// <summary>
    ///   <para>rdfs:comment : A vehicle will stop here on arrival</para>
    ///   <para>rdfs:label : Arrival Stop</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#arrivalStop">lc:arrivalStop</a>
    /// </summary>
    let arrivalStop = _prefixId.prefix "arrivalStop"
    /// <summary>
    ///   <para>rdfs:comment : The time of arrival at a certain stop (when e.g., a delay is announced, the lc:arrivalTime will show that actual time of arrival)</para>
    ///   <para>rdfs:label : Arrival Time</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#arrivalTime">lc:arrivalTime</a>
    /// </summary>
    let arrivalTime = _prefixId.prefix "arrivalTime"
    /// <summary>
    ///   <para>rdfs:comment : The time in which the lc:departureTime differs from the scheduled departure time</para>
    ///   <para>rdfs:label : Departure Delay</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#departureDelay">lc:departureDelay</a>
    /// </summary>
    let departureDelay = _prefixId.prefix "departureDelay"
    /// <summary>
    ///   <para>rdfs:comment : A vehicle departs here</para>
    ///   <para>rdfs:label : Departure Stop</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#departureStop">lc:departureStop</a>
    /// </summary>
    let departureStop = _prefixId.prefix "departureStop"
    /// <summary>
    ///   <para>rdfs:comment : The time of departure at a certain stop (when e.g., a delay is announced, the lc:departureTime will show that actual time of departure)</para>
    ///   <para>rdfs:label : Departure Time</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#departureTime">lc:departureTime</a>
    /// </summary>
    let departureTime = _prefixId.prefix "departureTime"
    /// <summary>
    ///   <para>rdfs:comment : A property representing a departureTime query</para>
    ///   <para>rdfs:label : DepartureTime query</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#departureTimeQuery">lc:departureTimeQuery</a>
    /// </summary>
    let departureTimeQuery = _prefixId.prefix "departureTimeQuery"
    /// <summary>
    ///   <para>rdfs:comment : The next connection on this vehicle's trajectory</para>
    ///   <para>rdfs:label : Next Connection</para>
    ///   <a href="http://semweb.mmlab.be/ns/linkedconnections#nextConnection">lc:nextConnection</a>
    /// </summary>
    let nextConnection = _prefixId.prefix "nextConnection"
