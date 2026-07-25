namespace http.semweb.mmlab.be.ns.stoptimes.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mmlab =
    let _namespace_iri = Namespace_Iri mmlab |> NamespaceIRI
    /// <summary>
    ///   <para>mmlab:Departure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A location and a departure time where a vehicle departs where people or things can be loaded</para>
    /// labels<para>Arrival</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/stoptimes#Departure">http://semweb.mmlab.be/ns/stoptimes#Departure</seealso>
    let Departure = Prefixed_Name(mmlab, "Departure") |> PrefixedName
    /// <summary>
    ///   <para>mmlab:StopTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A location and a time where a vehicle stops for the purpose of loading and/or unloading people or things</para>
    /// labels<para>Stop Time</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/stoptimes#StopTime">http://semweb.mmlab.be/ns/stoptimes#StopTime</seealso>
    let StopTime = Prefixed_Name(mmlab, "StopTime") |> PrefixedName
    /// <summary>
    ///   <para>mmlab:departureDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time in seconds in which the st:departureTime differs from the scheduled departure time</para>
    /// labels<para>Departure Delay</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/stoptimes#departureDelay">http://semweb.mmlab.be/ns/stoptimes#departureDelay</seealso>
    let departureDelay = Prefixed_Name(mmlab, "departureDelay") |> PrefixedName
    /// <summary>
    ///   <para>mmlab:arrivalDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time in seconds in which the st:arrivalTime differs from the scheduled arrival time</para>
    /// labels<para>Arrival Delay</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/stoptimes#arrivalDelay">http://semweb.mmlab.be/ns/stoptimes#arrivalDelay</seealso>
    let arrivalDelay = Prefixed_Name(mmlab, "arrivalDelay") |> PrefixedName
    /// <summary>
    ///   <para>mmlab:nextStopTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The next stop time on this vehicle's trajectory.</para>
    /// labels<para>Next Stop Time</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/stoptimes#nextStopTime">http://semweb.mmlab.be/ns/stoptimes#nextStopTime</seealso>
    let nextStopTime = Prefixed_Name(mmlab, "nextStopTime") |> PrefixedName
    /// <summary>
    ///   <para>mmlab:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This ontology provides the predicates necessary to describe an arrival of a transit vehicle and its departure at a certain Stop.</para>
    /// labels<para>The Stop Times ontology</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/stoptimes#Ontology">http://semweb.mmlab.be/ns/stoptimes#Ontology</seealso>
    let Ontology = Prefixed_Name(mmlab, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>mmlab:Arrival</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A location and a time where a vehicle stops for the purpose of unloading people or things</para>
    /// labels<para>Arrival</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/stoptimes#Arrival">http://semweb.mmlab.be/ns/stoptimes#Arrival</seealso>
    let Arrival = Prefixed_Name(mmlab, "Arrival") |> PrefixedName
    /// <summary>
    ///   <para>mmlab:avgStopTimes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The average st:StopTimes per day</para>
    /// labels<para>Average Stop Times</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/stoptimes#avgStopTimes">http://semweb.mmlab.be/ns/stoptimes#avgStopTimes</seealso>
    let avgStopTimes = Prefixed_Name(mmlab, "avgStopTimes") |> PrefixedName
