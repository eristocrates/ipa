#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module st =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://semweb.mmlab.be/ns/stoptimes#" "st"

    /// <summary>
    ///   <para>rdfs:label : Arrival</para>
    ///   <para>rdfs:comment : A location and a time where a vehicle stops for the purpose of unloading people or things</para>
    ///   <a href="http://semweb.mmlab.be/ns/stoptimes#Arrival">st:Arrival</a>
    /// </summary>
    let Arrival = _prefixId.prefix "Arrival"
    /// <summary>
    ///   <para>rdfs:label : Arrival</para>
    ///   <para>rdfs:comment : A location and a departure time where a vehicle departs where people or things can be loaded</para>
    ///   <a href="http://semweb.mmlab.be/ns/stoptimes#Departure">st:Departure</a>
    /// </summary>
    let Departure = _prefixId.prefix "Departure"
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:label : Stop Time</para>
    ///   <para>rdfs:comment : A location and a time where a vehicle stops for the purpose of loading and/or unloading people or things</para>
    ///   <a href="http://semweb.mmlab.be/ns/stoptimes#StopTime">st:StopTime</a>
    /// </summary>
    let StopTime = _prefixId.prefix "StopTime"
    /// <summary>
    ///   <para>rdfs:label : Arrival Delay</para>
    ///   <para>rdfs:comment : The time in seconds in which the st:arrivalTime differs from the scheduled arrival time</para>
    ///   <a href="http://semweb.mmlab.be/ns/stoptimes#arrivalDelay">st:arrivalDelay</a>
    /// </summary>
    let arrivalDelay = _prefixId.prefix "arrivalDelay"
    /// <summary>
    ///   <para>rdfs:label : Average Stop Times</para>
    ///   <para>rdfs:comment : The average st:StopTimes per day</para>
    ///   <a href="http://semweb.mmlab.be/ns/stoptimes#avgStopTimes">st:avgStopTimes</a>
    /// </summary>
    let avgStopTimes = _prefixId.prefix "avgStopTimes"
    /// <summary>
    ///   <para>rdfs:label : Departure Delay</para>
    ///   <para>rdfs:comment : The time in seconds in which the st:departureTime differs from the scheduled departure time</para>
    ///   <a href="http://semweb.mmlab.be/ns/stoptimes#departureDelay">st:departureDelay</a>
    /// </summary>
    let departureDelay = _prefixId.prefix "departureDelay"
    /// <summary>
    ///   <para>rdfs:label : Next Stop Time</para>
    ///   <para>rdfs:comment : The next stop time on this vehicle's trajectory.</para>
    ///   <a href="http://semweb.mmlab.be/ns/stoptimes#nextStopTime">st:nextStopTime</a>
    /// </summary>
    let nextStopTime = _prefixId.prefix "nextStopTime"
