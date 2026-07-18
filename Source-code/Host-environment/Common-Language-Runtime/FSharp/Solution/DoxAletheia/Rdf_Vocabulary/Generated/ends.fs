namespace http.labs.mondeca.com.vocab.endpointStatus.hash

open DoxAletheia.Rdf_Vocabulary

module ends =
    let _namespace_name = "http://labs.mondeca.com/vocab/endpointStatus#"

    /// <summary>
    /// A Status of a void:Dataset endpoint at a particular time
    /// <see href="http://labs.mondeca.com/vocab/endpointStatus#EndpointStatus"></see></summary>
    let EndpointStatus =
        Namespaced_IRI.parse _namespace_name "EndpointStatus" |> NamespacedName

    /// <summary>
    /// Describes whether a void:Dataset endpoint is available or not
    /// <see href="http://labs.mondeca.com/vocab/endpointStatus#statusIsAvailable"></see></summary>
    let statusIsAvailable =
        Namespaced_IRI.parse _namespace_name "statusIsAvailable" |> NamespacedName

    /// <summary>
    /// If a void:Dataset endpoint is available, this property indicates in milliseconds the responseTime to a simple Select query
    /// <see href="http://labs.mondeca.com/vocab/endpointStatus#statusResponseTime"></see></summary>
    let statusResponseTime =
        Namespaced_IRI.parse _namespace_name "statusResponseTime" |> NamespacedName

    /// <summary>
    /// Relation between a void:Dataset and an ends:EndpointStatus
    /// <see href="http://labs.mondeca.com/vocab/endpointStatus#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
