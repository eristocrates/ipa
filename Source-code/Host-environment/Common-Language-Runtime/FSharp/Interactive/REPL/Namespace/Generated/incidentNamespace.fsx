#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module incident =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://vocab.resc.info/incident#" "incident"

    /// <summary>
    ///   <para>rdfs:label : Characteristic^^xsd:string</para>
    ///   <para>rdfs:comment : Holds characteristics of a Incident^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#Characteristic">incident:Characteristic</a>
    /// </summary>
    let Characteristic = _prefixId.prefix "Characteristic"
    /// <summary>
    ///   <para>rdfs:label : Deployment^^xsd:string</para>
    ///   <para>rdfs:comment : The actual sending of a responding unit to a Incident.^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#Deployment">incident:Deployment</a>
    /// </summary>
    let Deployment = _prefixId.prefix "Deployment"
    /// <summary>
    ///   <para>rdfs:label : Incident Record^^xsd:string</para>
    ///   <para>rdfs:comment : A class to record the response to a incident by emergency response services.^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#IncidentRecord">incident:IncidentRecord</a>
    /// </summary>
    let IncidentRecord = _prefixId.prefix "IncidentRecord"
    /// <summary>
    ///   <para>rdfs:label : Note^^xsd:string</para>
    ///   <para>rdfs:comment : A text note for the incident, in general the CAD system log book. Should contain dcterms:modified instead of semtimestamp^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#Note">incident:Note</a>
    /// </summary>
    let Note = _prefixId.prefix "Note"
    /// <summary>
    ///   <para>rdfs:label : Arrival timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : The time the unit arrived at the incident location, this might not be automatically generated^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#arrivalTimestamp">incident:arrivalTimestamp</a>
    /// </summary>
    let arrivalTimestamp = _prefixId.prefix "arrivalTimestamp"
    let bart = _prefixId.prefix "bart"
    /// <summary>
    ///   <para>rdfs:label : Characteristic Type^^xsd:string</para>
    ///   <para>rdfs:comment : The type of the recorded characteristic, preferably points to a SKOS concept^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#characteristicType">incident:characteristicType</a>
    /// </summary>
    let characteristicType = _prefixId.prefix "characteristicType"
    /// <summary>
    ///   <para>rdfs:label : Unit deployed^^xsd:string</para>
    ///   <para>rdfs:comment : The unit deployed to a incident^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#deployedUnit">incident:deployedUnit</a>
    /// </summary>
    let deployedUnit = _prefixId.prefix "deployedUnit"
    /// <summary>
    ///   <para>rdfs:label : End of the deployment^^xsd:string</para>
    ///   <para>rdfs:comment : The time the unit was no longer needed at the incident.^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#deploymentEndTimestamp">incident:deploymentEndTimestamp</a>
    /// </summary>
    let deploymentEndTimestamp = _prefixId.prefix "deploymentEndTimestamp"
    /// <summary>
    ///   <para>rdfs:label : Deployment Start^^xsd:string</para>
    ///   <para>rdfs:comment : The time that a unit is send out to a incident^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#deploymentStartTimestamp">incident:deploymentStartTimestamp</a>
    /// </summary>
    let deploymentStartTimestamp = _prefixId.prefix "deploymentStartTimestamp"
    /// <summary>
    ///   <para>rdfs:label : has Characteristic^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between characteristics and incidents^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#hasCharacteristic">incident:hasCharacteristic</a>
    /// </summary>
    let hasCharacteristic = _prefixId.prefix "hasCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : Has Deployment^^xsd:string</para>
    ///   <para>rdfs:comment : a deployment of a unit to a incident^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#hasDeployment">incident:hasDeployment</a>
    /// </summary>
    let hasDeployment = _prefixId.prefix "hasDeployment"
    /// <summary>
    ///   <para>rdfs:label : hasNote^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a incident and the text notes^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#hasNote">incident:hasNote</a>
    /// </summary>
    let hasNote = _prefixId.prefix "hasNote"
    /// <summary>
    ///   <para>rdfs:label : Incident Record end timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : the time the emergency response services are no longer involved in the incident.^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#incidentRecordEndTimestamp">incident:incidentRecordEndTimestamp</a>
    /// </summary>
    let incidentRecordEndTimestamp = _prefixId.prefix "incidentRecordEndTimestamp"
    /// <summary>
    ///   <para>rdfs:label : Incident Record timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : The time the recordinf of the incident response begins^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#incidentRecordStartTimestamp">incident:incidentRecordStartTimestamp</a>
    /// </summary>
    let incidentRecordStartTimestamp = _prefixId.prefix "incidentRecordStartTimestamp"
    /// <summary>
    ///   <para>rdfs:label : is Deployment of^^xsd:string</para>
    ///   <para>rdfs:comment : This is a deployment to a specific incident^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#isDeploymentOf">incident:isDeploymentOf</a>
    /// </summary>
    let isDeploymentOf = _prefixId.prefix "isDeploymentOf"
    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <para>rdfs:comment : The location of the incident^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#location">incident:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : Mobilization timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : The time the unit is mobilized, when it starts heading to the incident^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/incident#mobilizationTimestamp">incident:mobilizationTimestamp</a>
    /// </summary>
    let mobilizationTimestamp = _prefixId.prefix "mobilizationTimestamp"
    let rdf = _prefixId.prefix "rdf"
    let ttl = _prefixId.prefix "ttl"
