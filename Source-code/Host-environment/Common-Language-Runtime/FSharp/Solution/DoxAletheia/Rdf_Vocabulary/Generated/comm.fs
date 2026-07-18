namespace http.vocab.resc.info.communication.hash

open DoxAletheia.Rdf_Vocabulary

module comm =
    let _namespace_name = "http://vocab.resc.info/communication#"
    /// <summary>
    ///   <see href="http://vocab.resc.info/communication#bart"></see>
    /// </summary>
    let bart = Namespaced_IRI.parse _namespace_name "bart" |> NamespacedName

    /// <summary>
    /// The classification of the incident
    /// <see href="http://vocab.resc.info/communication#Classification"></see></summary>
    let Classification =
        Namespaced_IRI.parse _namespace_name "Classification" |> NamespacedName

    /// <summary>
    /// Resources of this class describe messages sent by a dispatch to individual units
    /// <see href="http://vocab.resc.info/communication#DispatchMessage"></see></summary>
    let DispatchMessage =
        Namespaced_IRI.parse _namespace_name "DispatchMessage" |> NamespacedName

    /// <summary>
    /// A Unit which can be send to a incident
    /// <see href="http://vocab.resc.info/communication#Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName

    /// <summary>
    /// The type of classification
    /// <see href="http://vocab.resc.info/communication#classificationType"></see></summary>
    let classificationType =
        Namespaced_IRI.parse _namespace_name "classificationType" |> NamespacedName

    /// <summary>
    /// the adress on the P2000 pager network where the message was sent to
    /// <see href="http://vocab.resc.info/communication#dispatchedTo"></see></summary>
    let dispatchedTo =
        Namespaced_IRI.parse _namespace_name "dispatchedTo" |> NamespacedName

    /// <summary>
    /// The address where the incident was reported
    /// <see href="http://vocab.resc.info/communication#incidentAddress"></see></summary>
    let incidentAddress =
        Namespaced_IRI.parse _namespace_name "incidentAddress" |> NamespacedName

    /// <summary>
    /// The location in geo format where incident is reported
    /// <see href="http://vocab.resc.info/communication#incidentLocation"></see></summary>
    let incidentLocation =
        Namespaced_IRI.parse _namespace_name "incidentLocation" |> NamespacedName

    /// <summary>
    /// This property contains the full message as send through pager networks
    /// <see href="http://vocab.resc.info/communication#pagerMessage"></see></summary>
    let pagerMessage =
        Namespaced_IRI.parse _namespace_name "pagerMessage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.resc.info/communication#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.resc.info/communication#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
    /// <summary>
    /// Unit sent to the incident
    /// <see href="http://vocab.resc.info/communication#unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName
