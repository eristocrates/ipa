namespace https.w3id.org.vocab.sdm.hash

open DoxAletheia.Rdf_Vocabulary

module sdm =
    let _namespace_name = "https://w3id.org/vocab/sdm#"

    /// <summary>
    /// Principal class extending the sd:Feature for providing more metadata on an endpoint service.
    /// <see href="https://w3id.org/vocab/sdm#EndPointFeatureExtension"></see></summary>
    let EndPointFeatureExtension =
        Namespaced_IRI.parse _namespace_name "EndPointFeatureExtension" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/sdm#SPARQLRequest"></see>
    /// </summary>
    let SPARQLRequest =
        Namespaced_IRI.parse _namespace_name "SPARQLRequest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/sdm#TripleStore"></see>
    /// </summary>
    let TripleStore =
        Namespaced_IRI.parse _namespace_name "TripleStore" |> NamespacedName

    /// <summary>
    /// Developer of the triple store
    /// <see href="https://w3id.org/vocab/sdm#developer"></see></summary>
    let developer = Namespaced_IRI.parse _namespace_name "developer" |> NamespacedName

    /// <summary>
    /// Links to the message of an http connection, and helps to connect with http:httpVersion which is a rdfs:Literal
    /// <see href="https://w3id.org/vocab/sdm#httpMessage"></see></summary>
    let httpMessage =
        Namespaced_IRI.parse _namespace_name "httpMessage" |> NamespacedName

    /// <summary>
    /// The limit of the maximum results for the endpoint service
    /// <see href="https://w3id.org/vocab/sdm#maxResultPerRequest"></see></summary>
    let maxResultPerRequest =
        Namespaced_IRI.parse _namespace_name "maxResultPerRequest" |> NamespacedName

    /// <summary>
    /// URI of a mirror of the endpoint service
    /// <see href="https://w3id.org/vocab/sdm#mirror"></see></summary>
    let mirror = Namespaced_IRI.parse _namespace_name "mirror" |> NamespacedName

    /// <summary>
    /// The timeout of a query in milliseconds
    /// <see href="https://w3id.org/vocab/sdm#queryTimeOut"></see></summary>
    let queryTimeOut =
        Namespaced_IRI.parse _namespace_name "queryTimeOut" |> NamespacedName

    /// <summary>
    /// The remaining results for a given request
    /// <see href="https://w3id.org/vocab/sdm#remainingPerRequest"></see></summary>
    let remainingPerRequest =
        Namespaced_IRI.parse _namespace_name "remainingPerRequest" |> NamespacedName

    /// <summary>
    /// Links to a SPARQL request
    /// <see href="https://w3id.org/vocab/sdm#request"></see></summary>
    let request = Namespaced_IRI.parse _namespace_name "request" |> NamespacedName

    /// <summary>
    /// Links to an interval period time
    /// <see href="https://w3id.org/vocab/sdm#scheduledDowntime"></see></summary>
    let scheduledDowntime =
        Namespaced_IRI.parse _namespace_name "scheduledDowntime" |> NamespacedName

    /// <summary>
    /// Links to a given software acting as a triple store
    /// <see href="https://w3id.org/vocab/sdm#tripleStore"></see></summary>
    let tripleStore =
        Namespaced_IRI.parse _namespace_name "tripleStore" |> NamespacedName
