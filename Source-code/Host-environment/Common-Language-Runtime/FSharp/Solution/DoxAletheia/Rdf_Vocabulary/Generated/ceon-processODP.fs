namespace http.w3id.org.CEON.ontology.processODP.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_processODP =
    let _namespace_iri = Namespace_Iri ceon_processODP |> NamespaceIRI
    /// <summary>
    ///   <para>ceon-processODP:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>A core ODP of the CEON ontology network, defining aspects of the process concept.</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/">http://w3id.org/CEON/ontology/processODP/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_processODP, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:0.5/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/0.5/">http://w3id.org/CEON/ontology/processODP/0.5/</seealso>
    let ``_0.5/`` = Prefixed_Name(ceon_processODP, "0.5/") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something that happens within a given context or (short) timeframe.</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/Event">http://w3id.org/CEON/ontology/processODP/Event</seealso>
    let Event = Prefixed_Name(ceon_processODP, "Event") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The inputs to a process or event.</para>
    /// labels<para>has input</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/hasInput">http://w3id.org/CEON/ontology/processODP/hasInput</seealso>
    let hasInput = Prefixed_Name(ceon_processODP, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The output of a process or event.</para>
    /// labels<para>has output</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/hasOutput">http://w3id.org/CEON/ontology/processODP/hasOutput</seealso>
    let hasOutput = Prefixed_Name(ceon_processODP, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A process or event can consist of several parts, which are sub-processes (e.g. steps) or events.</para>
    /// labels<para>has part</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/hasPart">http://w3id.org/CEON/ontology/processODP/hasPart</seealso>
    let hasPart = Prefixed_Name(ceon_processODP, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something that takes place over a (longer) period of time and changes some state of affairs.</para>
    /// labels<para>Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/Process">http://w3id.org/CEON/ontology/processODP/Process</seealso>
    let Process = Prefixed_Name(ceon_processODP, "Process") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A situation that may involve some resources and actors, i.e. a state of affairs at a certain point in time.</para>
    /// labels<para>Situation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/Situation">http://w3id.org/CEON/ontology/processODP/Situation</seealso>
    let Situation = Prefixed_Name(ceon_processODP, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:isSettingFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The thing(s) that this situation is the setting for, e.g. a resource that is in a certain state.</para>
    /// labels<para>is the setting for</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/isSettingFor">http://w3id.org/CEON/ontology/processODP/isSettingFor</seealso>
    let isSettingFor = Prefixed_Name(ceon_processODP, "isSettingFor") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal entity has a starting time and an ending time.</para>
    /// labels<para>Time Interval</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/TimeInterval">http://w3id.org/CEON/ontology/processODP/TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(ceon_processODP, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:duringTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time interval during which something, e.g. a process or event, takes place.</para>
    /// labels<para>during time</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/duringTime">http://w3id.org/CEON/ontology/processODP/duringTime</seealso>
    let duringTime = Prefixed_Name(ceon_processODP, "duringTime") |> PrefixedName
    /// <summary>
    ///   <para>ceon-processODP:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Represents the end time of a time interval.</para>
    /// labels<para>end time</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/endTime">http://w3id.org/CEON/ontology/processODP/endTime</seealso>
    let endTime = Prefixed_Name(ceon_processODP, "endTime") |> PrefixedName

    /// <summary>
    ///   <para>ceon-processODP:occursAtLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location in which something (e.g. an event or process) takes place, e.g. the factory location where something is manufactured.</para>
    /// labels<para>occurs at location</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/occursAtLocation">http://w3id.org/CEON/ontology/processODP/occursAtLocation</seealso>
    let occursAtLocation =
        Prefixed_Name(ceon_processODP, "occursAtLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-processODP:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Represents the start time of a time interval.</para>
    /// labels<para>start time</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/startTime">http://w3id.org/CEON/ontology/processODP/startTime</seealso>
    let startTime = Prefixed_Name(ceon_processODP, "startTime") |> PrefixedName
