namespace http.linkeddata.finki.ukim.mk.lod.ontology.tao.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module trao =
    let _namespace_iri = Namespace_Iri trao |> NamespaceIRI
    /// <summary>
    ///   <para>trao:Accident_Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that describe emergency information on traffic accidents, fallen trees and other obstructions that affect accessibility. Includes information on location, impact, causes and possible traffic restrictions.</para>
    /// labels<para>Accident_Service</para></remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Accident_Service">http://linkeddata.finki.ukim.mk/lod/ontology/tao#Accident_Service</seealso>
    let Accident_Service = Prefixed_Name(trao, "Accident_Service") |> PrefixedName
    /// <summary>
    ///   <para>trao:Place_Info</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Place_Info">http://linkeddata.finki.ukim.mk/lod/ontology/tao#Place_Info</seealso>
    let Place_Info = Prefixed_Name(trao, "Place_Info") |> PrefixedName
    /// <summary>
    ///   <para>trao:Rest_Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that describe rest areas with information on location, level of equipment, service and information functions.</para>
    /// labels<para>Rest_Area</para></remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Rest_Area">http://linkeddata.finki.ukim.mk/lod/ontology/tao#Rest_Area</seealso>
    let Rest_Area = Prefixed_Name(trao, "Rest_Area") |> PrefixedName
    /// <summary>
    ///   <para>trao:areaPlaceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#areaPlaceName">http://linkeddata.finki.ukim.mk/lod/ontology/tao#areaPlaceName</seealso>
    let areaPlaceName = Prefixed_Name(trao, "areaPlaceName") |> PrefixedName
    /// <summary>
    ///   <para>trao:countyNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#countyNumber">http://linkeddata.finki.ukim.mk/lod/ontology/tao#countyNumber</seealso>
    let countyNumber = Prefixed_Name(trao, "countyNumber") |> PrefixedName
    /// <summary>
    ///   <para>trao:information_Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#information_Status">http://linkeddata.finki.ukim.mk/lod/ontology/tao#information_Status</seealso>
    let information_Status = Prefixed_Name(trao, "information_Status") |> PrefixedName
    /// <summary>
    ///   <para>trao:issued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#issued">http://linkeddata.finki.ukim.mk/lod/ontology/tao#issued</seealso>
    let issued = Prefixed_Name(trao, "issued") |> PrefixedName
    /// <summary>
    ///   <para>trao:lane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#lane">http://linkeddata.finki.ukim.mk/lod/ontology/tao#lane</seealso>
    let lane = Prefixed_Name(trao, "lane") |> PrefixedName
    /// <summary>
    ///   <para>trao:lanesRestricted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#lanesRestricted">http://linkeddata.finki.ukim.mk/lod/ontology/tao#lanesRestricted</seealso>
    let lanesRestricted = Prefixed_Name(trao, "lanesRestricted") |> PrefixedName
    /// <summary>
    ///   <para>trao:situationRecordTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#situationRecordTime">http://linkeddata.finki.ukim.mk/lod/ontology/tao#situationRecordTime</seealso>
    let situationRecordTime = Prefixed_Name(trao, "situationRecordTime") |> PrefixedName
    /// <summary>
    ///   <para>trao:speedLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#speedLimit">http://linkeddata.finki.ukim.mk/lod/ontology/tao#speedLimit</seealso>
    let speedLimit = Prefixed_Name(trao, "speedLimit") |> PrefixedName
    /// <summary>
    ///   <para>trao:textDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#textDescription">http://linkeddata.finki.ukim.mk/lod/ontology/tao#textDescription</seealso>
    let textDescription = Prefixed_Name(trao, "textDescription") |> PrefixedName
    /// <summary>
    ///   <para>trao:Ferry_Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that contains information about reports of deviations and cancellations of the SwedishTransport Administration ferry services. Contains information on ferry routes, estimated duration and possible restrictions.</para>
    /// labels<para>Ferry_Service</para></remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Ferry_Service">http://linkeddata.finki.ukim.mk/lod/ontology/tao#Ferry_Service</seealso>
    let Ferry_Service = Prefixed_Name(trao, "Ferry_Service") |> PrefixedName
    /// <summary>
    ///   <para>trao:Road_Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that describe the conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)</para>
    /// labels<para>Road_Condition</para></remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Road_Condition">http://linkeddata.finki.ukim.mk/lod/ontology/tao#Road_Condition</seealso>
    let Road_Condition = Prefixed_Name(trao, "Road_Condition") |> PrefixedName
    /// <summary>
    ///   <para>trao:cityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#cityName">http://linkeddata.finki.ukim.mk/lod/ontology/tao#cityName</seealso>
    let cityName = Prefixed_Name(trao, "cityName") |> PrefixedName
    /// <summary>
    ///   <para>trao:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#contributor">http://linkeddata.finki.ukim.mk/lod/ontology/tao#contributor</seealso>
    let contributor = Prefixed_Name(trao, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>trao:has_Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#has_Location">http://linkeddata.finki.ukim.mk/lod/ontology/tao#has_Location</seealso>
    let has_Location = Prefixed_Name(trao, "has_Location") |> PrefixedName
    /// <summary>
    ///   <para>trao:lengthAffected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#lengthAffected">http://linkeddata.finki.ukim.mk/lod/ontology/tao#lengthAffected</seealso>
    let lengthAffected = Prefixed_Name(trao, "lengthAffected") |> PrefixedName

    /// <summary>
    ///   <para>trao:location_Of_Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#location_Of_Situation">http://linkeddata.finki.ukim.mk/lod/ontology/tao#location_Of_Situation</seealso>
    let location_Of_Situation =
        Prefixed_Name(trao, "location_Of_Situation") |> PrefixedName

    /// <summary>
    ///   <para>trao:preferredNamespaceUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#preferredNamespaceUri">http://linkeddata.finki.ukim.mk/lod/ontology/tao#preferredNamespaceUri</seealso>
    let preferredNamespaceUri =
        Prefixed_Name(trao, "preferredNamespaceUri") |> PrefixedName

    /// <summary>
    ///   <para>trao:severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#severity">http://linkeddata.finki.ukim.mk/lod/ontology/tao#severity</seealso>
    let severity = Prefixed_Name(trao, "severity") |> PrefixedName
    /// <summary>
    ///   <para>trao:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Transport Administration Ontology (TAO) for describing data from Swedish Transport Administration Web site.</para>
    /// labels<para>Transport Administration Ontology</para></remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#">http://linkeddata.finki.ukim.mk/lod/ontology/tao#</seealso>
    let _prefix_iri = Prefixed_Name(trao, "") |> PrefixedName
    /// <summary>
    ///   <para>trao:Situation_Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class describing the basic information about Situation Record instances. It contains  information about time when it occured and information status.</para>
    /// labels<para>Situation_Record</para></remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Situation_Record">http://linkeddata.finki.ukim.mk/lod/ontology/tao#Situation_Record</seealso>
    let Situation_Record = Prefixed_Name(trao, "Situation_Record") |> PrefixedName
    /// <summary>
    ///   <para>trao:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about location where the Situation Record was generated. It contains several properties describing the Location. It contains geo:longitude and geo:latitude for creataing external links to othe datasets.</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Location">http://linkeddata.finki.ukim.mk/lod/ontology/tao#Location</seealso>
    let Location = Prefixed_Name(trao, "Location") |> PrefixedName
    /// <summary>
    ///   <para>trao:Road_Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that describe information about ongoing, planned and completed roadworks. Includes information on location, type of road work, impact and restrictions like closures of lanes, width restrictions, rerouting and traffic and speed reductions.</para>
    /// labels<para>Road_Work</para></remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#Road_Work">http://linkeddata.finki.ukim.mk/lod/ontology/tao#Road_Work</seealso>
    let Road_Work = Prefixed_Name(trao, "Road_Work") |> PrefixedName
    /// <summary>
    ///   <para>trao:carriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#carriageway">http://linkeddata.finki.ukim.mk/lod/ontology/tao#carriageway</seealso>
    let carriageway = Prefixed_Name(trao, "carriageway") |> PrefixedName
    /// <summary>
    ///   <para>trao:distanceNearestCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#distanceNearestCity">http://linkeddata.finki.ukim.mk/lod/ontology/tao#distanceNearestCity</seealso>
    let distanceNearestCity = Prefixed_Name(trao, "distanceNearestCity") |> PrefixedName
    /// <summary>
    ///   <para>trao:ferryInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#ferryInfo">http://linkeddata.finki.ukim.mk/lod/ontology/tao#ferryInfo</seealso>
    let ferryInfo = Prefixed_Name(trao, "ferryInfo") |> PrefixedName
    /// <summary>
    ///   <para>trao:locaton_Descriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#locaton_Descriptor">http://linkeddata.finki.ukim.mk/lod/ontology/tao#locaton_Descriptor</seealso>
    let locaton_Descriptor = Prefixed_Name(trao, "locaton_Descriptor") |> PrefixedName
    /// <summary>
    ///   <para>trao:offsetDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#offsetDistance">http://linkeddata.finki.ukim.mk/lod/ontology/tao#offsetDistance</seealso>
    let offsetDistance = Prefixed_Name(trao, "offsetDistance") |> PrefixedName

    /// <summary>
    ///   <para>trao:preferredNamespacePrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#preferredNamespacePrefix">http://linkeddata.finki.ukim.mk/lod/ontology/tao#preferredNamespacePrefix</seealso>
    let preferredNamespacePrefix =
        Prefixed_Name(trao, "preferredNamespacePrefix") |> PrefixedName

    /// <summary>
    ///   <para>trao:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/tao#title">http://linkeddata.finki.ukim.mk/lod/ontology/tao#title</seealso>
    let title = Prefixed_Name(trao, "title") |> PrefixedName
