#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vocals =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/rsp/vocals#" "vocals"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : RDFStream</para>
    ///   <para>rdfs:comment : A stream composed of RDF data elements, i.e. RDF graphs and/or triples.</para>
    ///   <a href="http://w3id.org/rsp/vocals#RDFStream">vocals:RDFStream</a>
    /// </summary>
    let RDFStream = _prefixId.prefix "RDFStream"
    /// <summary>
    ///   <para>rdfs:label : Stream</para>
    ///   <para>rdfs:comment : A potentially infinite sequence of data elements. A stream may be findable and accesible on the Web.</para>
    ///   <a href="http://w3id.org/rsp/vocals#Stream">vocals:Stream</a>
    /// </summary>
    let Stream = _prefixId.prefix "Stream"
    /// <summary>
    ///   <para>rdfs:label : StreamDescriptor</para>
    ///   <para>rdfs:comment : A Stream Descriptor is a Web document that contains the description of a Stream.</para>
    ///   <a href="http://w3id.org/rsp/vocals#StreamDescriptor">vocals:StreamDescriptor</a>
    /// </summary>
    let StreamDescriptor = _prefixId.prefix "StreamDescriptor"
    /// <summary>
    ///   <para>rdfs:label : StreamDistribution</para>
    ///   <para>rdfs:comment : Represents a specific available form of a stream. Each stream might be available in different forms, these forms might represent different access points of the stream. Examples of distributions include a WebSocket endpoint, an HTTP endpoint, a Server-Sent Events endpoint, MQTT, etc.</para>
    ///   <a href="http://w3id.org/rsp/vocals#StreamDistribution">vocals:StreamDistribution</a>
    /// </summary>
    let StreamDistribution = _prefixId.prefix "StreamDistribution"
    /// <summary>
    ///   <para>rdfs:label : StreamEndpoint</para>
    ///   <para>rdfs:comment : Represents a specific available form of a stream. Each stream might be available in different forms, these forms might represent different access points of the stream. Examples of endpoints include a WebSocket endpoint, an HTTP endpoint, a Server-Sent Events endpoint, MQTT, etc.</para>
    ///   <a href="http://w3id.org/rsp/vocals#StreamEndpoint">vocals:StreamEndpoint</a>
    /// </summary>
    let StreamEndpoint = _prefixId.prefix "StreamEndpoint"
    /// <summary>
    ///   <para>rdfs:label : StreamPartition</para>
    ///   <para>rdfs:comment : A finite subset of the stream that are made available to be accessed and consumed by standard Linked Data services.</para>
    ///   <a href="http://w3id.org/rsp/vocals#StreamPartition">vocals:StreamPartition</a>
    /// </summary>
    let StreamPartition = _prefixId.prefix "StreamPartition"
    /// <summary>
    ///   <para>rdfs:label : hasEndpoint</para>
    ///   <para>rdfs:comment : A relationship between a Stream and a StreamEndpoint. A stream may have several endpoints through which its contents can be accessible.</para>
    ///   <a href="http://w3id.org/rsp/vocals#hasEndpoint">vocals:hasEndpoint</a>
    /// </summary>
    let hasEndpoint = _prefixId.prefix "hasEndpoint"
    /// <summary>
    ///   <para>rdfs:label : hasPartition</para>
    ///   <para>rdfs:comment : A relationship between a Stream and a partition, or portion of elements streamed</para>
    ///   <a href="http://w3id.org/rsp/vocals#hasPartition">vocals:hasPartition</a>
    /// </summary>
    let hasPartition = _prefixId.prefix "hasPartition"
    /// <summary>
    ///   <para>rdfs:label : previous</para>
    ///   <para>rdfs:comment : Relationship between a stream partition and the previous partition in the stream. it connects stream partitions in order</para>
    ///   <a href="http://w3id.org/rsp/vocals#previous">vocals:previous</a>
    /// </summary>
    let previous = _prefixId.prefix "previous"
