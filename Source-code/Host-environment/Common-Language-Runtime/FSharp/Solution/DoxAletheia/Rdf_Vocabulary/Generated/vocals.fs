namespace http.w3id.org.rsp.vocals.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vocals =
    let _namespace_iri = Namespace_Iri vocals |> NamespaceIRI
    /// <summary>
    ///   <para>vocals:StreamDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Stream Descriptor is a Web document that contains the description of a Stream.</para>
    /// labels<para>StreamDescriptor</para></remarks>
    /// <seealso href="http://w3id.org/rsp/vocals#StreamDescriptor">http://w3id.org/rsp/vocals#StreamDescriptor</seealso>
    let StreamDescriptor = Prefixed_Name(vocals, "StreamDescriptor") |> PrefixedName
    /// <summary>
    ///   <para>vocals:RDFStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A stream composed of RDF data elements, i.e. RDF graphs and/or triples.</para>
    /// labels<para>RDFStream</para></remarks>
    /// <seealso href="http://w3id.org/rsp/vocals#RDFStream">http://w3id.org/rsp/vocals#RDFStream</seealso>
    let RDFStream = Prefixed_Name(vocals, "RDFStream") |> PrefixedName
    /// <summary>
    ///   <para>vocals:Stream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A potentially infinite sequence of data elements. A stream may be findable and accesible on the Web.</para>
    /// labels<para>Stream</para></remarks>
    /// <seealso href="http://w3id.org/rsp/vocals#Stream">http://w3id.org/rsp/vocals#Stream</seealso>
    let Stream = Prefixed_Name(vocals, "Stream") |> PrefixedName
    /// <summary>
    ///   <para>vocals:StreamDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a specific available form of a stream. Each stream might be available in different forms, these forms might represent different access points of the stream. Examples of distributions include a WebSocket endpoint, an HTTP endpoint, a Server-Sent Events endpoint, MQTT, etc.</para>
    /// labels<para>StreamDistribution</para></remarks>
    /// <seealso href="http://w3id.org/rsp/vocals#StreamDistribution">http://w3id.org/rsp/vocals#StreamDistribution</seealso>
    let StreamDistribution = Prefixed_Name(vocals, "StreamDistribution") |> PrefixedName
    /// <summary>
    ///   <para>vocals:StreamEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a specific available form of a stream. Each stream might be available in different forms, these forms might represent different access points of the stream. Examples of endpoints include a WebSocket endpoint, an HTTP endpoint, a Server-Sent Events endpoint, MQTT, etc.</para>
    /// labels<para>StreamEndpoint</para></remarks>
    /// <seealso href="http://w3id.org/rsp/vocals#StreamEndpoint">http://w3id.org/rsp/vocals#StreamEndpoint</seealso>
    let StreamEndpoint = Prefixed_Name(vocals, "StreamEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>vocals:hasEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a Stream and a StreamEndpoint. A stream may have several endpoints through which its contents can be accessible.</para>
    /// labels<para>hasEndpoint</para></remarks>
    /// <seealso href="http://w3id.org/rsp/vocals#hasEndpoint">http://w3id.org/rsp/vocals#hasEndpoint</seealso>
    let hasEndpoint = Prefixed_Name(vocals, "hasEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>vocals:StreamPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A finite subset of the stream that are made available to be accessed and consumed by standard Linked Data services.</para>
    /// labels<para>StreamPartition</para></remarks>
    /// <seealso href="http://w3id.org/rsp/vocals#StreamPartition">http://w3id.org/rsp/vocals#StreamPartition</seealso>
    let StreamPartition = Prefixed_Name(vocals, "StreamPartition") |> PrefixedName
    /// <summary>
    ///   <para>vocals:previous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a stream partition and the previous partition in the stream. it connects stream partitions in order</para>
    /// labels<para>previous</para></remarks>
    /// <seealso href="http://w3id.org/rsp/vocals#previous">http://w3id.org/rsp/vocals#previous</seealso>
    let previous = Prefixed_Name(vocals, "previous") |> PrefixedName
    /// <summary>
    ///   <para>vocals:hasPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a Stream and a partition, or portion of elements streamed</para>
    /// labels<para>hasPartition</para></remarks>
    /// <seealso href="http://w3id.org/rsp/vocals#hasPartition">http://w3id.org/rsp/vocals#hasPartition</seealso>
    let hasPartition = Prefixed_Name(vocals, "hasPartition") |> PrefixedName
    /// <summary>
    ///   <para>vocals:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>Cette ontologie a été conçue pour representer des données et meta-données de streams RDF, ainsi que leurs points d'accès.</para>
    ///   <para>This ontology aims to model RDF streams, their metadata, and access endpoints for publishing and consuming these streams</para>
    ///   <para>Esta ontología has sido diseñada para representar Streams de datos en RDF, así como los endpoints a través de los cuales se puede acceder a los datos de estos streams;  y los meta datos correspondientes.</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/rsp/vocals#">http://w3id.org/rsp/vocals#</seealso>
    let _prefix_iri = Prefixed_Name(vocals, "") |> PrefixedName
