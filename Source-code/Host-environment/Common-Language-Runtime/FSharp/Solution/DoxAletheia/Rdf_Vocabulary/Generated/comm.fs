namespace http.vocab.resc.info.communication.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module comm =
    let _namespace_iri = Namespace_Iri comm |> NamespaceIRI
    /// <summary>
    ///   <para>comm:Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The classification of the incident"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.resc.info/communication#Classification">http://vocab.resc.info/communication#Classification</seealso>
    let Classification = Prefixed_Name(comm, "Classification") |> PrefixedName
    /// <summary>
    ///   <para>comm:DispatchMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Resources of this class describe messages sent by a dispatch to individual units"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DispatchMessage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.resc.info/communication#DispatchMessage">http://vocab.resc.info/communication#DispatchMessage</seealso>
    let DispatchMessage = Prefixed_Name(comm, "DispatchMessage") |> PrefixedName
    /// <summary>
    ///   <para>comm:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A Unit which can be send to a incident"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.resc.info/communication#Unit">http://vocab.resc.info/communication#Unit</seealso>
    let Unit = Prefixed_Name(comm, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>comm:bart</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.resc.info/communication#bart">http://vocab.resc.info/communication#bart</seealso>
    let bart = Prefixed_Name(comm, "bart") |> PrefixedName
    /// <summary>
    ///   <para>comm:classificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The type of classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.resc.info/communication#classificationType">http://vocab.resc.info/communication#classificationType</seealso>
    let classificationType = Prefixed_Name(comm, "classificationType") |> PrefixedName
    /// <summary>
    ///   <para>comm:dispatchedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"the adress on the P2000 pager network where the message was sent to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dispatched to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.resc.info/communication#dispatchedTo">http://vocab.resc.info/communication#dispatchedTo</seealso>
    let dispatchedTo = Prefixed_Name(comm, "dispatchedTo") |> PrefixedName
    /// <summary>
    ///   <para>comm:incidentAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The address where the incident was reported"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Incident address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.resc.info/communication#incidentAddress">http://vocab.resc.info/communication#incidentAddress</seealso>
    let incidentAddress = Prefixed_Name(comm, "incidentAddress") |> PrefixedName
    /// <summary>
    ///   <para>comm:incidentLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The location in geo format where incident is reported"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.resc.info/communication#incidentLocation">http://vocab.resc.info/communication#incidentLocation</seealso>
    let incidentLocation = Prefixed_Name(comm, "incidentLocation") |> PrefixedName
    /// <summary>
    ///   <para>comm:pagerMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property contains the full message as send through pager networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The message send to pagers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.resc.info/communication#pagerMessage">http://vocab.resc.info/communication#pagerMessage</seealso>
    let pagerMessage = Prefixed_Name(comm, "pagerMessage") |> PrefixedName
    /// <summary>
    ///   <para>comm:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:AssetDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.resc.info/communication#rdf">http://vocab.resc.info/communication#rdf</seealso>
    let rdf = Prefixed_Name(comm, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>comm:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:AssetDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.resc.info/communication#ttl">http://vocab.resc.info/communication#ttl</seealso>
    let ttl = Prefixed_Name(comm, "ttl") |> PrefixedName
    /// <summary>
    ///   <para>comm:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Unit sent to the incident"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.resc.info/communication#unit">http://vocab.resc.info/communication#unit</seealso>
    let unit = Prefixed_Name(comm, "unit") |> PrefixedName
