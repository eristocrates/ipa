namespace http.purl.org.ontology.ssso.hash

open DoxAletheia

module ssso =
    let _namespace_name = "http://purl.org/ontology/ssso#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#ExecutedService"></see>
    /// </summary>
    let ExecutedService = _prefix "ExecutedService"
    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#ServiceEvent"></see>
    /// </summary>
    let ServiceEvent = _prefix "ServiceEvent"
    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#ReservedService"></see>
    /// </summary>
    let ReservedService = _prefix "ReservedService"
    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#RejectedService"></see>
    /// </summary>
    let RejectedService = _prefix "RejectedService"
    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#ProvidedService"></see>
    /// </summary>
    let ProvidedService = _prefix "ProvidedService"
    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#PreparedService"></see>
    /// </summary>
    let PreparedService = _prefix "PreparedService"
    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#ServiceFulfillment"></see>
    /// </summary>
    let ServiceFulfillment = _prefix "ServiceFulfillment"
    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#TimeTravel"></see>
    /// </summary>
    let TimeTravel = _prefix "TimeTravel"
    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#nextService"></see>
    /// </summary>
    let nextService = _prefix "nextService"
    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#previousService"></see>
    /// </summary>
    let previousService = _prefix "previousService"
