namespace http.purl.org.ontology.co.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module co =
    let _namespace_iri = Namespace_Iri co |> NamespaceIRI
    /// <summary>
    ///   <para>co:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/co/core#">http://purl.org/ontology/co/core#</seealso>
    let _prefix_iri = Prefixed_Name(co, "") |> PrefixedName
    /// <summary>
    ///   <para>co:Counter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Counter of a given object/ given objects, which are related to that counter."</para>
    /// labels<para>"Counter"</para></remarks>
    /// <seealso href="http://purl.org/ontology/co/core#Counter">http://purl.org/ontology/co/core#Counter</seealso>
    let Counter = Prefixed_Name(co, "Counter") |> PrefixedName
    /// <summary>
    ///   <para>co:ScrobbleEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An event corresponding to a scrobbling (counting an activity, which includes at least a specific factor and
    /// a specific agent), e.g. a track being played by someone, a video watched by someone, a book read by
    /// someone, a sporting activity by someone, ..."</para>
    /// labels<para>"Scrobble Event"</para></remarks>
    /// <seealso href="http://purl.org/ontology/co/core#ScrobbleEvent">http://purl.org/ontology/co/core#ScrobbleEvent</seealso>
    let ScrobbleEvent = Prefixed_Name(co, "ScrobbleEvent") |> PrefixedName
    /// <summary>
    ///   <para>co:count</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Links a counter resource to the actual count"</para>
    /// labels<para>"has count"</para></remarks>
    /// <seealso href="http://purl.org/ontology/co/core#count">http://purl.org/ontology/co/core#count</seealso>
    let count = Prefixed_Name(co, "count") |> PrefixedName
    /// <summary>
    ///   <para>co:counter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an object to a counter resource. Please feel free to create further sub properties with more restricted domains."</para>
    /// labels<para>"has counter"</para></remarks>
    /// <seealso href="http://purl.org/ontology/co/core#counter">http://purl.org/ontology/co/core#counter</seealso>
    let counter = Prefixed_Name(co, "counter") |> PrefixedName
    /// <summary>
    ///   <para>co:event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Links counter resources to related events."</para>
    /// labels<para>"has event"</para></remarks>
    /// <seealso href="http://purl.org/ontology/co/core#event">http://purl.org/ontology/co/core#event</seealso>
    let event_ = Prefixed_Name(co, "event") |> PrefixedName
    /// <summary>
    ///   <para>co:event_counter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Links events to a counter resource, where they where counted in."</para>
    /// labels<para>"has event counter"</para></remarks>
    /// <seealso href="http://purl.org/ontology/co/core#event_counter">http://purl.org/ontology/co/core#event_counter</seealso>
    let event_counter = Prefixed_Name(co, "event_counter") |> PrefixedName
    /// <summary>
    ///   <para>co:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a counter resource to an object. Please feel free to create further sub properties with more restricted ranges."</para>
    /// labels<para>"has object"</para></remarks>
    /// <seealso href="http://purl.org/ontology/co/core#object">http://purl.org/ontology/co/core#object</seealso>
    let object = Prefixed_Name(co, "object") |> PrefixedName
    /// <summary>
    ///   <para>co:scrobble_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A scrobble object of a scrobble event, e.g. a music track, a video or a described activity. That means a specific thing that is involved in this scrobbling action."</para>
    /// labels<para>"has scrobble object"</para></remarks>
    /// <seealso href="http://purl.org/ontology/co/core#scrobble_object">http://purl.org/ontology/co/core#scrobble_object</seealso>
    let scrobble_object = Prefixed_Name(co, "scrobble_object") |> PrefixedName
