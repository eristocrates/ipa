namespace http.vocab.resc.info.incident.hash

open DoxAletheia

module incident =
    let _namespace_name = "http://vocab.resc.info/incident#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.resc.info/incident#bart"></see>
    /// </summary>
    let bart = _prefix "bart"
    /// <summary>
    /// Holds characteristics of a Incident
    /// <see href="http://vocab.resc.info/incident#Characteristic"></see></summary>
    let Characteristic = _prefix "Characteristic"
    /// <summary>
    /// The actual sending of a responding unit to a Incident.
    /// <see href="http://vocab.resc.info/incident#Deployment"></see></summary>
    let Deployment = _prefix "Deployment"
    /// <summary>
    /// A class to record the response to a incident by emergency response services.
    /// <see href="http://vocab.resc.info/incident#IncidentRecord"></see></summary>
    let IncidentRecord = _prefix "IncidentRecord"
    /// <summary>
    /// A text note for the incident, in general the CAD system log book. Should contain dcterms:modified instead of semtimestamp
    /// <see href="http://vocab.resc.info/incident#Note"></see></summary>
    let Note = _prefix "Note"
    /// <summary>
    /// The time the unit arrived at the incident location, this might not be automatically generated
    /// <see href="http://vocab.resc.info/incident#arrivalTimestamp"></see></summary>
    let arrivalTimestamp = _prefix "arrivalTimestamp"
    /// <summary>
    /// The type of the recorded characteristic, preferably points to a SKOS concept
    /// <see href="http://vocab.resc.info/incident#characteristicType"></see></summary>
    let characteristicType = _prefix "characteristicType"
    /// <summary>
    /// The unit deployed to a incident
    /// <see href="http://vocab.resc.info/incident#deployedUnit"></see></summary>
    let deployedUnit = _prefix "deployedUnit"
    /// <summary>
    /// The time the unit was no longer needed at the incident.
    /// <see href="http://vocab.resc.info/incident#deploymentEndTimestamp"></see></summary>
    let deploymentEndTimestamp = _prefix "deploymentEndTimestamp"
    /// <summary>
    /// The time that a unit is send out to a incident
    /// <see href="http://vocab.resc.info/incident#deploymentStartTimestamp"></see></summary>
    let deploymentStartTimestamp = _prefix "deploymentStartTimestamp"
    /// <summary>
    /// Relation between characteristics and incidents
    /// <see href="http://vocab.resc.info/incident#hasCharacteristic"></see></summary>
    let hasCharacteristic = _prefix "hasCharacteristic"
    /// <summary>
    /// a deployment of a unit to a incident
    /// <see href="http://vocab.resc.info/incident#hasDeployment"></see></summary>
    let hasDeployment = _prefix "hasDeployment"
    /// <summary>
    /// The relation between a incident and the text notes
    /// <see href="http://vocab.resc.info/incident#hasNote"></see></summary>
    let hasNote = _prefix "hasNote"
    /// <summary>
    /// the time the emergency response services are no longer involved in the incident.
    /// <see href="http://vocab.resc.info/incident#incidentRecordEndTimestamp"></see></summary>
    let incidentRecordEndTimestamp = _prefix "incidentRecordEndTimestamp"
    /// <summary>
    /// The time the recordinf of the incident response begins
    /// <see href="http://vocab.resc.info/incident#incidentRecordStartTimestamp"></see></summary>
    let incidentRecordStartTimestamp = _prefix "incidentRecordStartTimestamp"
    /// <summary>
    /// This is a deployment to a specific incident
    /// <see href="http://vocab.resc.info/incident#isDeploymentOf"></see></summary>
    let isDeploymentOf = _prefix "isDeploymentOf"
    /// <summary>
    /// The location of the incident
    /// <see href="http://vocab.resc.info/incident#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// The time the unit is mobilized, when it starts heading to the incident
    /// <see href="http://vocab.resc.info/incident#mobilizationTimestamp"></see></summary>
    let mobilizationTimestamp = _prefix "mobilizationTimestamp"
    /// <summary>
    ///   <see href="http://vocab.resc.info/incident#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    ///   <see href="http://vocab.resc.info/incident#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
