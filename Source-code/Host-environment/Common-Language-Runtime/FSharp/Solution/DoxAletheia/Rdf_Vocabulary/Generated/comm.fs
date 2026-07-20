namespace http.vocab.resc.info.communication.hash

open DoxAletheia

module comm =
    let _namespace_name = "http://vocab.resc.info/communication#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.resc.info/communication#bart"></see>
    /// </summary>
    let bart = _prefix "bart"
    /// <summary>
    /// The classification of the incident
    /// <see href="http://vocab.resc.info/communication#Classification"></see></summary>
    let Classification = _prefix "Classification"
    /// <summary>
    /// Resources of this class describe messages sent by a dispatch to individual units
    /// <see href="http://vocab.resc.info/communication#DispatchMessage"></see></summary>
    let DispatchMessage = _prefix "DispatchMessage"
    /// <summary>
    /// A Unit which can be send to a incident
    /// <see href="http://vocab.resc.info/communication#Unit"></see></summary>
    let Unit = _prefix "Unit"
    /// <summary>
    /// The type of classification
    /// <see href="http://vocab.resc.info/communication#classificationType"></see></summary>
    let classificationType = _prefix "classificationType"
    /// <summary>
    /// the adress on the P2000 pager network where the message was sent to
    /// <see href="http://vocab.resc.info/communication#dispatchedTo"></see></summary>
    let dispatchedTo = _prefix "dispatchedTo"
    /// <summary>
    /// The address where the incident was reported
    /// <see href="http://vocab.resc.info/communication#incidentAddress"></see></summary>
    let incidentAddress = _prefix "incidentAddress"
    /// <summary>
    /// The location in geo format where incident is reported
    /// <see href="http://vocab.resc.info/communication#incidentLocation"></see></summary>
    let incidentLocation = _prefix "incidentLocation"
    /// <summary>
    /// This property contains the full message as send through pager networks
    /// <see href="http://vocab.resc.info/communication#pagerMessage"></see></summary>
    let pagerMessage = _prefix "pagerMessage"
    /// <summary>
    ///   <see href="http://vocab.resc.info/communication#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    ///   <see href="http://vocab.resc.info/communication#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
    /// <summary>
    /// Unit sent to the incident
    /// <see href="http://vocab.resc.info/communication#unit"></see></summary>
    let unit = _prefix "unit"
