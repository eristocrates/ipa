namespace http.linkeddata.finki.ukim.mk.lod.ontology.tao.hash

open DoxAletheia.Rdf_Vocabulary

module trao =
    let _namespace_name = "http://linkeddata.finki.ukim.mk/lod/ontology/tao#"

    /// <summary>
    /// Class that describe emergency information on traffic accidents, fallen trees and other obstructions that affect accessibility. Includes information on location, impact, causes and possible traffic restrictions.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Accident_Service"></see></summary>
    let Accident_Service =
        Namespaced_IRI.parse _namespace_name "Accident_Service" |> NamespacedName

    /// <summary>
    /// Class describing the basic information about Situation Record instances. It contains  information about time when it occured and information status.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Situation_Record"></see></summary>
    let Situation_Record =
        Namespaced_IRI.parse _namespace_name "Situation_Record" |> NamespacedName

    /// <summary>
    /// Class that contains information about reports of deviations and cancellations of the SwedishTransport Administration ferry services. Contains information on ferry routes, estimated duration and possible restrictions.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Ferry_Service"></see></summary>
    let Ferry_Service =
        Namespaced_IRI.parse _namespace_name "Ferry_Service" |> NamespacedName

    /// <summary>
    /// Information about location where the Situation Record was generated. It contains several properties describing the Location. It contains geo:longitude and geo:latitude for creataing external links to othe datasets.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Place_Info"></see>
    /// </summary>
    let Place_Info = Namespaced_IRI.parse _namespace_name "Place_Info" |> NamespacedName
    /// <summary>
    /// Class that describe rest areas with information on location, level of equipment, service and information functions.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Rest_Area"></see></summary>
    let Rest_Area = Namespaced_IRI.parse _namespace_name "Rest_Area" |> NamespacedName

    /// <summary>
    /// Class that describe the conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Road_Condition"></see></summary>
    let Road_Condition =
        Namespaced_IRI.parse _namespace_name "Road_Condition" |> NamespacedName

    /// <summary>
    /// Class that describe information about ongoing, planned and completed roadworks. Includes information on location, type of road work, impact and restrictions like closures of lanes, width restrictions, rerouting and traffic and speed reductions.
    /// <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Road_Work"></see></summary>
    let Road_Work = Namespaced_IRI.parse _namespace_name "Road_Work" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#areaPlaceName"></see>
    /// </summary>
    let areaPlaceName =
        Namespaced_IRI.parse _namespace_name "areaPlaceName" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#carriageway"></see>
    /// </summary>
    let carriageway =
        Namespaced_IRI.parse _namespace_name "carriageway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#cityName"></see>
    /// </summary>
    let cityName = Namespaced_IRI.parse _namespace_name "cityName" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#contributor"></see>
    /// </summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#countyNumber"></see>
    /// </summary>
    let countyNumber =
        Namespaced_IRI.parse _namespace_name "countyNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#distanceNearestCity"></see>
    /// </summary>
    let distanceNearestCity =
        Namespaced_IRI.parse _namespace_name "distanceNearestCity" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#ferryInfo"></see>
    /// </summary>
    let ferryInfo = Namespaced_IRI.parse _namespace_name "ferryInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#has_Location"></see>
    /// </summary>
    let has_Location =
        Namespaced_IRI.parse _namespace_name "has_Location" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#information_Status"></see>
    /// </summary>
    let information_Status =
        Namespaced_IRI.parse _namespace_name "information_Status" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#issued"></see>
    /// </summary>
    let issued = Namespaced_IRI.parse _namespace_name "issued" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#lane"></see>
    /// </summary>
    let lane = Namespaced_IRI.parse _namespace_name "lane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#lanesRestricted"></see>
    /// </summary>
    let lanesRestricted =
        Namespaced_IRI.parse _namespace_name "lanesRestricted" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#lengthAffected"></see>
    /// </summary>
    let lengthAffected =
        Namespaced_IRI.parse _namespace_name "lengthAffected" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#location_Of_Situation"></see>
    /// </summary>
    let location_Of_Situation =
        Namespaced_IRI.parse _namespace_name "location_Of_Situation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#locaton_Descriptor"></see>
    /// </summary>
    let locaton_Descriptor =
        Namespaced_IRI.parse _namespace_name "locaton_Descriptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#offsetDistance"></see>
    /// </summary>
    let offsetDistance =
        Namespaced_IRI.parse _namespace_name "offsetDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#preferredNamespacePrefix"></see>
    /// </summary>
    let preferredNamespacePrefix =
        Namespaced_IRI.parse _namespace_name "preferredNamespacePrefix" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#preferredNamespaceUri"></see>
    /// </summary>
    let preferredNamespaceUri =
        Namespaced_IRI.parse _namespace_name "preferredNamespaceUri" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#severity"></see>
    /// </summary>
    let severity = Namespaced_IRI.parse _namespace_name "severity" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#situationRecordTime"></see>
    /// </summary>
    let situationRecordTime =
        Namespaced_IRI.parse _namespace_name "situationRecordTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#speedLimit"></see>
    /// </summary>
    let speedLimit = Namespaced_IRI.parse _namespace_name "speedLimit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#textDescription"></see>
    /// </summary>
    let textDescription =
        Namespaced_IRI.parse _namespace_name "textDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
