namespace http.labs.mondeca.com.vocab.endpointStatus.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ends =
    let _namespace_iri = Namespace_Iri ends |> NamespaceIRI
    /// <summary>
    ///   <para>ends:EndpointStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Status of a void:Dataset endpoint at a particular time"</para>
    /// labels<para>"Endpoint status"</para></remarks>
    /// <seealso href="http://labs.mondeca.com/vocab/endpointStatus#EndpointStatus">http://labs.mondeca.com/vocab/endpointStatus#EndpointStatus</seealso>
    let EndpointStatus = Prefixed_Name(ends, "EndpointStatus") |> PrefixedName
    /// <summary>
    ///   <para>ends:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a void:Dataset and an ends:EndpointStatus"</para>
    /// labels<para>"has status"</para></remarks>
    /// <seealso href="http://labs.mondeca.com/vocab/endpointStatus#status">http://labs.mondeca.com/vocab/endpointStatus#status</seealso>
    let status = Prefixed_Name(ends, "status") |> PrefixedName
    /// <summary>
    ///   <para>ends:statusIsAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Describes whether a void:Dataset endpoint is available or not"</para>
    /// labels<para>"is endpoint available"</para></remarks>
    /// <seealso href="http://labs.mondeca.com/vocab/endpointStatus#statusIsAvailable">http://labs.mondeca.com/vocab/endpointStatus#statusIsAvailable</seealso>
    let statusIsAvailable = Prefixed_Name(ends, "statusIsAvailable") |> PrefixedName
    /// <summary>
    ///   <para>ends:statusResponseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"If a void:Dataset endpoint is available, this property indicates in milliseconds the responseTime to a simple Select query"</para>
    /// labels<para>"endpoint response time"</para></remarks>
    /// <seealso href="http://labs.mondeca.com/vocab/endpointStatus#statusResponseTime">http://labs.mondeca.com/vocab/endpointStatus#statusResponseTime</seealso>
    let statusResponseTime = Prefixed_Name(ends, "statusResponseTime") |> PrefixedName
