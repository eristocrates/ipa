namespace http.purl.org.ontology.ssso.hash

open DoxAletheia.Rdf_Vocabulary

module ssso =
    let _namespace_name = "http://purl.org/ontology/ssso#"

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#ExecutedService"></see>
    /// </summary>
    let ExecutedService =
        Namespaced_IRI.parse _namespace_name "ExecutedService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#ServiceEvent"></see>
    /// </summary>
    let ServiceEvent =
        Namespaced_IRI.parse _namespace_name "ServiceEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#ReservedService"></see>
    /// </summary>
    let ReservedService =
        Namespaced_IRI.parse _namespace_name "ReservedService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#RejectedService"></see>
    /// </summary>
    let RejectedService =
        Namespaced_IRI.parse _namespace_name "RejectedService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#ProvidedService"></see>
    /// </summary>
    let ProvidedService =
        Namespaced_IRI.parse _namespace_name "ProvidedService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#PreparedService"></see>
    /// </summary>
    let PreparedService =
        Namespaced_IRI.parse _namespace_name "PreparedService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#ServiceFulfillment"></see>
    /// </summary>
    let ServiceFulfillment =
        Namespaced_IRI.parse _namespace_name "ServiceFulfillment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#TimeTravel"></see>
    /// </summary>
    let TimeTravel = Namespaced_IRI.parse _namespace_name "TimeTravel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#nextService"></see>
    /// </summary>
    let nextService =
        Namespaced_IRI.parse _namespace_name "nextService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/ssso#previousService"></see>
    /// </summary>
    let previousService =
        Namespaced_IRI.parse _namespace_name "previousService" |> NamespacedName
