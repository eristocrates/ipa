namespace http.w3id.org.CEON.ontology.processODP.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_processODP =
    let _namespace_iri = Namespace_Iri ceon_processODP |> NamespaceIRI
    /// <summary>
    ///   <para>ceon:ontology/processODP/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"A core ODP of the CEON ontology network, defining aspects of the process concept."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/">http://w3id.org/CEON/ontology/processODP/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_processODP, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/0.5/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/0.5/">http://w3id.org/CEON/ontology/processODP/0.5/</seealso>
    let ``_0.5/`` = Prefixed_Name(ceon_processODP, "0.5/") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Something that happens within a given context or (short) timeframe."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/Event">http://w3id.org/CEON/ontology/processODP/Event</seealso>
    let Event = Prefixed_Name(ceon_processODP, "Event") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Something that takes place over a (longer) period of time and changes some state of affairs."</para>
    /// labels<para>"Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/Process">http://w3id.org/CEON/ontology/processODP/Process</seealso>
    let Process = Prefixed_Name(ceon_processODP, "Process") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A situation that may involve some resources and actors, i.e. a state of affairs at a certain point in time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Situation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/Situation">http://w3id.org/CEON/ontology/processODP/Situation</seealso>
    let Situation = Prefixed_Name(ceon_processODP, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A temporal entity has a starting time and an ending time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time Interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/TimeInterval">http://w3id.org/CEON/ontology/processODP/TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(ceon_processODP, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/duringTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The time interval during which something, e.g. a process or event, takes place."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"during time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/duringTime">http://w3id.org/CEON/ontology/processODP/duringTime</seealso>
    let duringTime = Prefixed_Name(ceon_processODP, "duringTime") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the end time of a time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"end time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/endTime">http://w3id.org/CEON/ontology/processODP/endTime</seealso>
    let endTime = Prefixed_Name(ceon_processODP, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The inputs to a process or event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/hasInput">http://w3id.org/CEON/ontology/processODP/hasInput</seealso>
    let hasInput = Prefixed_Name(ceon_processODP, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The output of a process or event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/hasOutput">http://w3id.org/CEON/ontology/processODP/hasOutput</seealso>
    let hasOutput = Prefixed_Name(ceon_processODP, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A process or event can consist of several parts, which are sub-processes (e.g. steps) or events."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/hasPart">http://w3id.org/CEON/ontology/processODP/hasPart</seealso>
    let hasPart = Prefixed_Name(ceon_processODP, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/isSettingFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The thing(s) that this situation is the setting for, e.g. a resource that is in a certain state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is the setting for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/isSettingFor">http://w3id.org/CEON/ontology/processODP/isSettingFor</seealso>
    let isSettingFor = Prefixed_Name(ceon_processODP, "isSettingFor") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/processODP/occursAtLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The location in which something (e.g. an event or process) takes place, e.g. the factory location where something is manufactured."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"occurs at location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/occursAtLocation">http://w3id.org/CEON/ontology/processODP/occursAtLocation</seealso>
    let occursAtLocation =
        Prefixed_Name(ceon_processODP, "occursAtLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/processODP/occursAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/occursAtTime">http://w3id.org/CEON/ontology/processODP/occursAtTime</seealso>
    let occursAtTime = Prefixed_Name(ceon_processODP, "occursAtTime") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/processODP/startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the start time of a time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"start time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/processODP/startTime">http://w3id.org/CEON/ontology/processODP/startTime</seealso>
    let startTime = Prefixed_Name(ceon_processODP, "startTime") |> PrefixedName
