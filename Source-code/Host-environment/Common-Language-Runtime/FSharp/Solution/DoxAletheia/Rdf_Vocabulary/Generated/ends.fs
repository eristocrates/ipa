namespace http.labs.mondeca.com.vocab.endpointStatus.hash

open DoxAletheia

module ends =
    let _namespace_name = "http://labs.mondeca.com/vocab/endpointStatus#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Status of a void:Dataset endpoint at a particular time
    /// <see href="http://labs.mondeca.com/vocab/endpointStatus#EndpointStatus"></see></summary>
    let EndpointStatus = _prefix "EndpointStatus"
    /// <summary>
    /// Describes whether a void:Dataset endpoint is available or not
    /// <see href="http://labs.mondeca.com/vocab/endpointStatus#statusIsAvailable"></see></summary>
    let statusIsAvailable = _prefix "statusIsAvailable"
    /// <summary>
    /// If a void:Dataset endpoint is available, this property indicates in milliseconds the responseTime to a simple Select query
    /// <see href="http://labs.mondeca.com/vocab/endpointStatus#statusResponseTime"></see></summary>
    let statusResponseTime = _prefix "statusResponseTime"
    /// <summary>
    /// Relation between a void:Dataset and an ends:EndpointStatus
    /// <see href="http://labs.mondeca.com/vocab/endpointStatus#status"></see></summary>
    let status = _prefix "status"
