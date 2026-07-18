namespace http.vocab.resc.info.incident.hash

open DoxAletheia.Rdf_Vocabulary

module incident =
    let _namespace_name = "http://vocab.resc.info/incident#"
    /// <summary>
    ///   <see href="http://vocab.resc.info/incident#bart"></see>
    /// </summary>
    let bart = Namespaced_IRI.parse _namespace_name "bart" |> NamespacedName

    /// <summary>
    /// Holds characteristics of a Incident
    /// <see href="http://vocab.resc.info/incident#Characteristic"></see></summary>
    let Characteristic =
        Namespaced_IRI.parse _namespace_name "Characteristic" |> NamespacedName

    /// <summary>
    /// The actual sending of a responding unit to a Incident.
    /// <see href="http://vocab.resc.info/incident#Deployment"></see></summary>
    let Deployment = Namespaced_IRI.parse _namespace_name "Deployment" |> NamespacedName

    /// <summary>
    /// A class to record the response to a incident by emergency response services.
    /// <see href="http://vocab.resc.info/incident#IncidentRecord"></see></summary>
    let IncidentRecord =
        Namespaced_IRI.parse _namespace_name "IncidentRecord" |> NamespacedName

    /// <summary>
    /// A text note for the incident, in general the CAD system log book. Should contain dcterms:modified instead of semtimestamp
    /// <see href="http://vocab.resc.info/incident#Note"></see></summary>
    let Note = Namespaced_IRI.parse _namespace_name "Note" |> NamespacedName

    /// <summary>
    /// The time the unit arrived at the incident location, this might not be automatically generated
    /// <see href="http://vocab.resc.info/incident#arrivalTimestamp"></see></summary>
    let arrivalTimestamp =
        Namespaced_IRI.parse _namespace_name "arrivalTimestamp" |> NamespacedName

    /// <summary>
    /// The type of the recorded characteristic, preferably points to a SKOS concept
    /// <see href="http://vocab.resc.info/incident#characteristicType"></see></summary>
    let characteristicType =
        Namespaced_IRI.parse _namespace_name "characteristicType" |> NamespacedName

    /// <summary>
    /// The unit deployed to a incident
    /// <see href="http://vocab.resc.info/incident#deployedUnit"></see></summary>
    let deployedUnit =
        Namespaced_IRI.parse _namespace_name "deployedUnit" |> NamespacedName

    /// <summary>
    /// The time the unit was no longer needed at the incident.
    /// <see href="http://vocab.resc.info/incident#deploymentEndTimestamp"></see></summary>
    let deploymentEndTimestamp =
        Namespaced_IRI.parse _namespace_name "deploymentEndTimestamp" |> NamespacedName

    /// <summary>
    /// The time that a unit is send out to a incident
    /// <see href="http://vocab.resc.info/incident#deploymentStartTimestamp"></see></summary>
    let deploymentStartTimestamp =
        Namespaced_IRI.parse _namespace_name "deploymentStartTimestamp" |> NamespacedName

    /// <summary>
    /// Relation between characteristics and incidents
    /// <see href="http://vocab.resc.info/incident#hasCharacteristic"></see></summary>
    let hasCharacteristic =
        Namespaced_IRI.parse _namespace_name "hasCharacteristic" |> NamespacedName

    /// <summary>
    /// a deployment of a unit to a incident
    /// <see href="http://vocab.resc.info/incident#hasDeployment"></see></summary>
    let hasDeployment =
        Namespaced_IRI.parse _namespace_name "hasDeployment" |> NamespacedName

    /// <summary>
    /// The relation between a incident and the text notes
    /// <see href="http://vocab.resc.info/incident#hasNote"></see></summary>
    let hasNote = Namespaced_IRI.parse _namespace_name "hasNote" |> NamespacedName

    /// <summary>
    /// the time the emergency response services are no longer involved in the incident.
    /// <see href="http://vocab.resc.info/incident#incidentRecordEndTimestamp"></see></summary>
    let incidentRecordEndTimestamp =
        Namespaced_IRI.parse _namespace_name "incidentRecordEndTimestamp" |> NamespacedName

    /// <summary>
    /// The time the recordinf of the incident response begins
    /// <see href="http://vocab.resc.info/incident#incidentRecordStartTimestamp"></see></summary>
    let incidentRecordStartTimestamp =
        Namespaced_IRI.parse _namespace_name "incidentRecordStartTimestamp" |> NamespacedName

    /// <summary>
    /// This is a deployment to a specific incident
    /// <see href="http://vocab.resc.info/incident#isDeploymentOf"></see></summary>
    let isDeploymentOf =
        Namespaced_IRI.parse _namespace_name "isDeploymentOf" |> NamespacedName

    /// <summary>
    /// The location of the incident
    /// <see href="http://vocab.resc.info/incident#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    /// The time the unit is mobilized, when it starts heading to the incident
    /// <see href="http://vocab.resc.info/incident#mobilizationTimestamp"></see></summary>
    let mobilizationTimestamp =
        Namespaced_IRI.parse _namespace_name "mobilizationTimestamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.resc.info/incident#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.resc.info/incident#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
