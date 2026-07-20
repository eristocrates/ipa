namespace http.w3id.org.rsp.vocals.hash

open DoxAletheia

module vocals =
    let _namespace_name = "http://w3id.org/rsp/vocals#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A stream composed of RDF data elements, i.e. RDF graphs and/or triples.
    /// <see href="http://w3id.org/rsp/vocals#RDFStream"></see></summary>
    let RDFStream = _prefix "RDFStream"
    /// <summary>
    /// A potentially infinite sequence of data elements. A stream may be findable and accesible on the Web.
    /// <see href="http://w3id.org/rsp/vocals#Stream"></see></summary>
    let Stream = _prefix "Stream"
    /// <summary>
    /// Represents a specific available form of a stream. Each stream might be available in different forms, these forms might represent different access points of the stream. Examples of distributions include a WebSocket endpoint, an HTTP endpoint, a Server-Sent Events endpoint, MQTT, etc.
    /// <see href="http://w3id.org/rsp/vocals#StreamDistribution"></see></summary>
    let StreamDistribution = _prefix "StreamDistribution"
    /// <summary>
    /// A Stream Descriptor is a Web document that contains the description of a Stream.
    /// <see href="http://w3id.org/rsp/vocals#StreamDescriptor"></see></summary>
    let StreamDescriptor = _prefix "StreamDescriptor"
    /// <summary>
    /// Represents a specific available form of a stream. Each stream might be available in different forms, these forms might represent different access points of the stream. Examples of endpoints include a WebSocket endpoint, an HTTP endpoint, a Server-Sent Events endpoint, MQTT, etc.
    /// <see href="http://w3id.org/rsp/vocals#StreamEndpoint"></see></summary>
    let StreamEndpoint = _prefix "StreamEndpoint"
    /// <summary>
    /// A finite subset of the stream that are made available to be accessed and consumed by standard Linked Data services.
    /// <see href="http://w3id.org/rsp/vocals#StreamPartition"></see></summary>
    let StreamPartition = _prefix "StreamPartition"
    /// <summary>
    /// Relationship between a stream partition and the previous partition in the stream. it connects stream partitions in order
    /// <see href="http://w3id.org/rsp/vocals#previous"></see></summary>
    let previous = _prefix "previous"
    /// <summary>
    /// A relationship between a Stream and a StreamEndpoint. A stream may have several endpoints through which its contents can be accessible.
    /// <see href="http://w3id.org/rsp/vocals#hasEndpoint"></see></summary>
    let hasEndpoint = _prefix "hasEndpoint"
    /// <summary>
    /// A relationship between a Stream and a partition, or portion of elements streamed
    /// <see href="http://w3id.org/rsp/vocals#hasPartition"></see></summary>
    let hasPartition = _prefix "hasPartition"
