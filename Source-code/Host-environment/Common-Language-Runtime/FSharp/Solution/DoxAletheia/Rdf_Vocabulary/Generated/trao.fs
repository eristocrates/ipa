namespace http.linkeddata.finki.ukim.mk.lod.ontology.tao.hash

open DoxAletheia

module trao =
    let _namespace_name = "http://linkeddata.finki.ukim.mk/lod/ontology/tao#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Class that describe emergency information on traffic accidents, fallen trees and other obstructions that affect accessibility. Includes information on location, impact, causes and possible traffic restrictions.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Accident_Service"></see></summary>
    let Accident_Service = _prefix "Accident_Service"
    /// <summary>
    /// Class describing the basic information about Situation Record instances. It contains  information about time when it occured and information status.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Situation_Record"></see></summary>
    let Situation_Record = _prefix "Situation_Record"
    /// <summary>
    /// Class that contains information about reports of deviations and cancellations of the SwedishTransport Administration ferry services. Contains information on ferry routes, estimated duration and possible restrictions.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Ferry_Service"></see></summary>
    let Ferry_Service = _prefix "Ferry_Service"
    /// <summary>
    /// Information about location where the Situation Record was generated. It contains several properties describing the Location. It contains geo:longitude and geo:latitude for creataing external links to othe datasets.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Place_Info"></see>
    /// </summary>
    let Place_Info = _prefix "Place_Info"
    /// <summary>
    /// Class that describe rest areas with information on location, level of equipment, service and information functions.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Rest_Area"></see></summary>
    let Rest_Area = _prefix "Rest_Area"
    /// <summary>
    /// Class that describe the conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Road_Condition"></see></summary>
    let Road_Condition = _prefix "Road_Condition"
    /// <summary>
    /// Class that describe information about ongoing, planned and completed roadworks. Includes information on location, type of road work, impact and restrictions like closures of lanes, width restrictions, rerouting and traffic and speed reductions.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Road_Work"></see></summary>
    let Road_Work = _prefix "Road_Work"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#areaPlaceName"></see>
    /// </summary>
    let areaPlaceName = _prefix "areaPlaceName"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#carriageway"></see>
    /// </summary>
    let carriageway = _prefix "carriageway"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#cityName"></see>
    /// </summary>
    let cityName = _prefix "cityName"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#contributor"></see>
    /// </summary>
    let contributor = _prefix "contributor"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#countyNumber"></see>
    /// </summary>
    let countyNumber = _prefix "countyNumber"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#distanceNearestCity"></see>
    /// </summary>
    let distanceNearestCity = _prefix "distanceNearestCity"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#ferryInfo"></see>
    /// </summary>
    let ferryInfo = _prefix "ferryInfo"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#has_Location"></see>
    /// </summary>
    let has_Location = _prefix "has_Location"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#information_Status"></see>
    /// </summary>
    let information_Status = _prefix "information_Status"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#issued"></see>
    /// </summary>
    let issued = _prefix "issued"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#lane"></see>
    /// </summary>
    let lane = _prefix "lane"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#lanesRestricted"></see>
    /// </summary>
    let lanesRestricted = _prefix "lanesRestricted"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#lengthAffected"></see>
    /// </summary>
    let lengthAffected = _prefix "lengthAffected"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#location_Of_Situation"></see>
    /// </summary>
    let location_Of_Situation = _prefix "location_Of_Situation"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#locaton_Descriptor"></see>
    /// </summary>
    let locaton_Descriptor = _prefix "locaton_Descriptor"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#offsetDistance"></see>
    /// </summary>
    let offsetDistance = _prefix "offsetDistance"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#preferredNamespacePrefix"></see>
    /// </summary>
    let preferredNamespacePrefix = _prefix "preferredNamespacePrefix"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#preferredNamespaceUri"></see>
    /// </summary>
    let preferredNamespaceUri = _prefix "preferredNamespaceUri"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#severity"></see>
    /// </summary>
    let severity = _prefix "severity"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#situationRecordTime"></see>
    /// </summary>
    let situationRecordTime = _prefix "situationRecordTime"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#speedLimit"></see>
    /// </summary>
    let speedLimit = _prefix "speedLimit"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#textDescription"></see>
    /// </summary>
    let textDescription = _prefix "textDescription"
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#title"></see>
    /// </summary>
    let title = _prefix "title"
