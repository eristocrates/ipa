namespace http.vocab.resc.info.incident.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module incident =
    let _namespace_iri = Namespace_Iri incident |> NamespaceIRI
    /// <summary>
    ///   <para>incident:Characteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Holds characteristics of a Incident</para>
    /// labels<para>Characteristic</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#Characteristic">http://vocab.resc.info/incident#Characteristic</seealso>
    let Characteristic = Prefixed_Name(incident, "Characteristic") |> PrefixedName
    /// <summary>
    ///   <para>incident:IncidentRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A class to record the response to a incident by emergency response services.</para>
    /// labels<para>Incident Record</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#IncidentRecord">http://vocab.resc.info/incident#IncidentRecord</seealso>
    let IncidentRecord = Prefixed_Name(incident, "IncidentRecord") |> PrefixedName
    /// <summary>
    ///   <para>incident:Deployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The actual sending of a responding unit to a Incident.</para>
    /// labels<para>Deployment</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#Deployment">http://vocab.resc.info/incident#Deployment</seealso>
    let Deployment = Prefixed_Name(incident, "Deployment") |> PrefixedName
    /// <summary>
    ///   <para>incident:Note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A text note for the incident, in general the CAD system log book. Should contain dcterms:modified instead of semtimestamp</para>
    /// labels<para>Note</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#Note">http://vocab.resc.info/incident#Note</seealso>
    let Note = Prefixed_Name(incident, "Note") |> PrefixedName
    /// <summary>
    ///   <para>incident:deployedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The unit deployed to a incident</para>
    /// labels<para>Unit deployed</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#deployedUnit">http://vocab.resc.info/incident#deployedUnit</seealso>
    let deployedUnit = Prefixed_Name(incident, "deployedUnit") |> PrefixedName
    /// <summary>
    ///   <para>incident:arrivalTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time the unit arrived at the incident location, this might not be automatically generated</para>
    /// labels<para>Arrival timestamp</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#arrivalTimestamp">http://vocab.resc.info/incident#arrivalTimestamp</seealso>
    let arrivalTimestamp = Prefixed_Name(incident, "arrivalTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>incident:deploymentEndTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time the unit was no longer needed at the incident.</para>
    /// labels<para>End of the deployment</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#deploymentEndTimestamp">http://vocab.resc.info/incident#deploymentEndTimestamp</seealso>
    let deploymentEndTimestamp =
        Prefixed_Name(incident, "deploymentEndTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>incident:characteristicType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of the recorded characteristic, preferably points to a SKOS concept</para>
    /// labels<para>Characteristic Type</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#characteristicType">http://vocab.resc.info/incident#characteristicType</seealso>
    let characteristicType =
        Prefixed_Name(incident, "characteristicType") |> PrefixedName

    /// <summary>
    ///   <para>incident:hasNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relation between a incident and the text notes</para>
    /// labels<para>hasNote</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#hasNote">http://vocab.resc.info/incident#hasNote</seealso>
    let hasNote = Prefixed_Name(incident, "hasNote") |> PrefixedName

    /// <summary>
    ///   <para>incident:deploymentStartTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The time that a unit is send out to a incident</para>
    /// labels<para>Deployment Start</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#deploymentStartTimestamp">http://vocab.resc.info/incident#deploymentStartTimestamp</seealso>
    let deploymentStartTimestamp =
        Prefixed_Name(incident, "deploymentStartTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>incident:hasDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>a deployment of a unit to a incident</para>
    /// labels<para>Has Deployment</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#hasDeployment">http://vocab.resc.info/incident#hasDeployment</seealso>
    let hasDeployment = Prefixed_Name(incident, "hasDeployment") |> PrefixedName

    /// <summary>
    ///   <para>incident:incidentRecordEndTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>the time the emergency response services are no longer involved in the incident.</para>
    /// labels<para>Incident Record end timestamp</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#incidentRecordEndTimestamp">http://vocab.resc.info/incident#incidentRecordEndTimestamp</seealso>
    let incidentRecordEndTimestamp =
        Prefixed_Name(incident, "incidentRecordEndTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>incident:isDeploymentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This is a deployment to a specific incident</para>
    /// labels<para>is Deployment of</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#isDeploymentOf">http://vocab.resc.info/incident#isDeploymentOf</seealso>
    let isDeploymentOf = Prefixed_Name(incident, "isDeploymentOf") |> PrefixedName
    /// <summary>
    ///   <para>incident:hasCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relation between characteristics and incidents</para>
    /// labels<para>has Characteristic</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#hasCharacteristic">http://vocab.resc.info/incident#hasCharacteristic</seealso>
    let hasCharacteristic = Prefixed_Name(incident, "hasCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>incident:incidentRecordStartTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The time the recordinf of the incident response begins</para>
    /// labels<para>Incident Record timestamp</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#incidentRecordStartTimestamp">http://vocab.resc.info/incident#incidentRecordStartTimestamp</seealso>
    let incidentRecordStartTimestamp =
        Prefixed_Name(incident, "incidentRecordStartTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>incident:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The location of the incident</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#location">http://vocab.resc.info/incident#location</seealso>
    let location = Prefixed_Name(incident, "location") |> PrefixedName
    /// <summary>
    ///   <para>incident:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:AssetDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.resc.info/incident#ttl">http://vocab.resc.info/incident#ttl</seealso>
    let ttl = Prefixed_Name(incident, "ttl") |> PrefixedName

    /// <summary>
    ///   <para>incident:mobilizationTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time the unit is mobilized, when it starts heading to the incident</para>
    /// labels<para>Mobilization timestamp</para></remarks>
    /// <seealso href="http://vocab.resc.info/incident#mobilizationTimestamp">http://vocab.resc.info/incident#mobilizationTimestamp</seealso>
    let mobilizationTimestamp =
        Prefixed_Name(incident, "mobilizationTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>incident:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:AssetDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.resc.info/incident#rdf">http://vocab.resc.info/incident#rdf</seealso>
    let rdf = Prefixed_Name(incident, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>incident:bart</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.resc.info/incident#bart">http://vocab.resc.info/incident#bart</seealso>
    let bart = Prefixed_Name(incident, "bart") |> PrefixedName
