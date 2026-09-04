#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module trao =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://linkeddata.finki.ukim.mk/lod/ontology/tao#" "trao"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Accident_Service^^xsd:string</para>
    ///   <para>rdfs:comment : Class that describe emergency information on traffic accidents, fallen trees and other obstructions that affect accessibility. Includes information on location, impact, causes and possible traffic restrictions.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Accident_Service">trao:Accident_Service</a>
    /// </summary>
    let Accident_Service = _prefixId.prefix "Accident_Service"
    /// <summary>
    ///   <para>rdfs:label : Ferry_Service^^xsd:string</para>
    ///   <para>rdfs:comment : Class that contains information about reports of deviations and cancellations of the SwedishTransport Administration ferry services. Contains information on ferry routes, estimated duration and possible restrictions.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Ferry_Service">trao:Ferry_Service</a>
    /// </summary>
    let Ferry_Service = _prefixId.prefix "Ferry_Service"
    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <para>rdfs:comment : Information about location where the Situation Record was generated. It contains several properties describing the Location. It contains geo:longitude and geo:latitude for creataing external links to othe datasets.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Location">trao:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    let Place_Info = _prefixId.prefix "Place_Info"
    /// <summary>
    ///   <para>rdfs:label : Rest_Area^^xsd:string</para>
    ///   <para>rdfs:comment : Class that describe rest areas with information on location, level of equipment, service and information functions.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Rest_Area">trao:Rest_Area</a>
    /// </summary>
    let Rest_Area = _prefixId.prefix "Rest_Area"
    /// <summary>
    ///   <para>rdfs:label : Road_Condition^^xsd:string</para>
    ///   <para>rdfs:comment : Class that describe the conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Road_Condition">trao:Road_Condition</a>
    /// </summary>
    let Road_Condition = _prefixId.prefix "Road_Condition"
    /// <summary>
    ///   <para>rdfs:label : Road_Work^^xsd:string</para>
    ///   <para>rdfs:comment : Class that describe information about ongoing, planned and completed roadworks. Includes information on location, type of road work, impact and restrictions like closures of lanes, width restrictions, rerouting and traffic and speed reductions.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Road_Work">trao:Road_Work</a>
    /// </summary>
    let Road_Work = _prefixId.prefix "Road_Work"
    /// <summary>
    ///   <para>rdfs:label : Situation_Record^^xsd:string</para>
    ///   <para>rdfs:comment : Class describing the basic information about Situation Record instances. It contains  information about time when it occured and information status.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Situation_Record">trao:Situation_Record</a>
    /// </summary>
    let Situation_Record = _prefixId.prefix "Situation_Record"
    let areaPlaceName = _prefixId.prefix "areaPlaceName"
    let carriageway = _prefixId.prefix "carriageway"
    let cityName = _prefixId.prefix "cityName"
    let contributor = _prefixId.prefix "contributor"
    let countyNumber = _prefixId.prefix "countyNumber"
    let distanceNearestCity = _prefixId.prefix "distanceNearestCity"
    let ferryInfo = _prefixId.prefix "ferryInfo"
    let has_Location = _prefixId.prefix "has_Location"
    let information_Status = _prefixId.prefix "information_Status"
    let issued = _prefixId.prefix "issued"
    let lane = _prefixId.prefix "lane"
    let lanesRestricted = _prefixId.prefix "lanesRestricted"
    let lengthAffected = _prefixId.prefix "lengthAffected"
    let location_Of_Situation = _prefixId.prefix "location_Of_Situation"
    let locaton_Descriptor = _prefixId.prefix "locaton_Descriptor"
    let offsetDistance = _prefixId.prefix "offsetDistance"
    let preferredNamespacePrefix = _prefixId.prefix "preferredNamespacePrefix"
    let preferredNamespaceUri = _prefixId.prefix "preferredNamespaceUri"
    let severity = _prefixId.prefix "severity"
    let situationRecordTime = _prefixId.prefix "situationRecordTime"
    let speedLimit = _prefixId.prefix "speedLimit"
    let textDescription = _prefixId.prefix "textDescription"
    let title = _prefixId.prefix "title"
