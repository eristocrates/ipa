namespace https.w3id.org.vocab.sdm.hash

open DoxAletheia

module sdm =
    let _namespace_name = "https://w3id.org/vocab/sdm#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Principal class extending the sd:Feature for providing more metadata on an endpoint service.
    /// <see href="https://w3id.org/vocab/sdm#EndPointFeatureExtension"></see></summary>
    let EndPointFeatureExtension = _prefix "EndPointFeatureExtension"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/sdm#SPARQLRequest"></see>
    /// </summary>
    let SPARQLRequest = _prefix "SPARQLRequest"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/sdm#TripleStore"></see>
    /// </summary>
    let TripleStore = _prefix "TripleStore"
    /// <summary>
    /// Developer of the triple store
    /// <see href="https://w3id.org/vocab/sdm#developer"></see></summary>
    let developer = _prefix "developer"
    /// <summary>
    /// Links to the message of an http connection, and helps to connect with http:httpVersion which is a rdfs:Literal
    /// <see href="https://w3id.org/vocab/sdm#httpMessage"></see></summary>
    let httpMessage = _prefix "httpMessage"
    /// <summary>
    /// The limit of the maximum results for the endpoint service
    /// <see href="https://w3id.org/vocab/sdm#maxResultPerRequest"></see></summary>
    let maxResultPerRequest = _prefix "maxResultPerRequest"
    /// <summary>
    /// URI of a mirror of the endpoint service
    /// <see href="https://w3id.org/vocab/sdm#mirror"></see></summary>
    let mirror = _prefix "mirror"
    /// <summary>
    /// The timeout of a query in milliseconds
    /// <see href="https://w3id.org/vocab/sdm#queryTimeOut"></see></summary>
    let queryTimeOut = _prefix "queryTimeOut"
    /// <summary>
    /// The remaining results for a given request
    /// <see href="https://w3id.org/vocab/sdm#remainingPerRequest"></see></summary>
    let remainingPerRequest = _prefix "remainingPerRequest"
    /// <summary>
    /// Links to a SPARQL request
    /// <see href="https://w3id.org/vocab/sdm#request"></see></summary>
    let request = _prefix "request"
    /// <summary>
    /// Links to an interval period time
    /// <see href="https://w3id.org/vocab/sdm#scheduledDowntime"></see></summary>
    let scheduledDowntime = _prefix "scheduledDowntime"
    /// <summary>
    /// Links to a given software acting as a triple store
    /// <see href="https://w3id.org/vocab/sdm#tripleStore"></see></summary>
    let tripleStore = _prefix "tripleStore"
