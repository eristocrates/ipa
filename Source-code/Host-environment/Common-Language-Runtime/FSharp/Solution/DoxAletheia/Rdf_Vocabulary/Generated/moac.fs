namespace http.observedchange.com.moac.ns.hash

open DoxAletheia

module moac =
    let _namespace_name = "http://observedchange.com/moac/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// AffectedPopulation is a group of disaster affecgted people in need of humanitarian support.
    /// <see href="http://observedchange.com/moac/ns#AffectedPopulation"></see></summary>
    let AffectedPopulation = _prefix "AffectedPopulation"
    /// <summary>
    /// Agency is an organization that aims to manage a crisis.
    /// <see href="http://observedchange.com/moac/ns#Agency"></see></summary>
    let Agency = _prefix "Agency"
    /// <summary>
    /// AidManipulation.
    /// <see href="http://observedchange.com/moac/ns#AidManipulation"></see></summary>
    let AidManipulation = _prefix "AidManipulation"
    /// <summary>
    /// AnimalIllnessOrDeath refers to the illness or death of animals caused by a disaster highlighting the possibility of spread of disease because of direct or indirect contamination.
    /// <see href="http://observedchange.com/moac/ns#AnimalIllnessOrDeath"></see></summary>
    let AnimalIllnessOrDeath = _prefix "AnimalIllnessOrDeath"
    /// <summary>
    /// AskingToFowardAMessage is the term used to forward certain community directed messages using third party sources.
    /// <see href="http://observedchange.com/moac/ns#AskingToFowardAMessage"></see></summary>
    let AskingToFowardAMessage = _prefix "AskingToFowardAMessage"
    /// <summary>
    /// ChronicCareNeeds refers to the requirement of medical care which addresses preexisting or long term illness.
    /// <see href="http://observedchange.com/moac/ns#ChronicCareNeeds"></see></summary>
    let ChronicCareNeeds = _prefix "ChronicCareNeeds"
    /// <summary>
    /// Inter Agency Standing Committee Emergency Shelter related agency specific activities. The Shelter Cluster is co-chaired by IFRC and UNHCR at the global level. IFRC is convener of the Emergency Shelter Cluster in disaster situations while UNHCR leads the Emergency Shelter Cluster in the area of conflict generated IDPs (Internally Displaced Persons). In addition to IFRC and UNHCR, participants in the Global Shelter Cluster include: ACTED, Archi-Urgent, Article 25, Care UK, CHF, CRS, DFID, Habitat for Humanity, IOM, Medair, NRC, OFDA, Oxfam GB, ProAct, ProVention, RedR, Relief International, RICS, Save The Children UK, Shelter Centre, SKAT, UN Habitat, UN OCHA, UNRWA and World Vision. (source: sheltercluster.org, accessed on 12 Feb 2012)
    /// <see href="http://observedchange.com/moac/ns#Cluster1Shelter"></see></summary>
    let Cluster1Shelter = _prefix "Cluster1Shelter"
    /// <summary>
    ///   <see href="http://observedchange.com/moac/ns#IASCClusterSection"></see>
    /// </summary>
    let IASCClusterSection = _prefix "IASCClusterSection"
    /// <summary>
    /// Inter Agency Standing Committee Emergency Food related agency specific activities. World Food Programme (WFP) is the global cluster lead for Food.
    /// <see href="http://observedchange.com/moac/ns#Cluster2Food"></see></summary>
    let Cluster2Food = _prefix "Cluster2Food"
    /// <summary>
    /// Inter Agency Standing Committee Emergency Water Sanitation and Hygine related agency specific activities. UNICEF is the global cluster lead for WASH.
    /// <see href="http://observedchange.com/moac/ns#Cluster3WASH"></see></summary>
    let Cluster3WASH = _prefix "Cluster3WASH"
    /// <summary>
    /// A CollapsedStructure is a term that defines a totally damaged state of a structure resulting from human or natural phenomenon.
    /// <see href="http://observedchange.com/moac/ns#CollapsedStructure"></see></summary>
    let CollapsedStructure = _prefix "CollapsedStructure"
    /// <summary>
    /// CommunicationLinesDown indicates that a mobile or a landline phone in ceratain area will not work because of the problem in the communication wired poles.
    /// <see href="http://observedchange.com/moac/ns#CommunicationLinesDown"></see></summary>
    let CommunicationLinesDown = _prefix "CommunicationLinesDown"
    /// <summary>
    /// CompromisedBridge is a partially or completely damaged bridge that can no longer be used for transporting people or relief materials.
    /// <see href="http://observedchange.com/moac/ns#CompromisedBridge"></see></summary>
    let CompromisedBridge = _prefix "CompromisedBridge"
    /// <summary>
    /// Undrinkable Water is water that is regarded unfit/unhealthy to drink for both humans and animals.
    /// <see href="http://observedchange.com/moac/ns#ContaminatedWater"></see></summary>
    let ContaminatedWater = _prefix "ContaminatedWater"
    /// <summary>
    /// The source and delivery system provides water but polluted. It could result in outbreaks of diseases and other health realted issues.
    /// <see href="http://observedchange.com/moac/ns#ContaminatedWaterSupply"></see></summary>
    let ContaminatedWaterSupply = _prefix "ContaminatedWaterSupply"
    /// <summary>
    /// Deaths are the termination of the biological functions that sustain a living organism.
    /// <see href="http://observedchange.com/moac/ns#Deaths"></see></summary>
    let Deaths = _prefix "Deaths"
    /// <summary>
    /// An earthquake is the result of a sudden release of energy in the Earth's crust that creates seismic waves, and an aftershock is an earthquake that occurs after a previous earthquake, the mainshock.
    /// <see href="http://observedchange.com/moac/ns#EarthquakeAndAftershock"></see></summary>
    let EarthquakeAndAftershock = _prefix "EarthquakeAndAftershock"
    /// <summary>
    /// Emergency is a situation that poses an immediate crisis to human, life, health, property or environment.
    /// <see href="http://observedchange.com/moac/ns#Emergency"></see></summary>
    let Emergency = _prefix "Emergency"
    /// <summary>
    /// FeedingCentersAvailable is a term that defines a location of a facility which supports providing basic life saving foods to infants and lactating mothers.
    /// <see href="http://observedchange.com/moac/ns#FeedingCentersAvailable"></see></summary>
    let FeedingCentersAvailable = _prefix "FeedingCentersAvailable"
    /// <summary>
    /// FinancialServicesAvailabe refers to services provided by the certain Non Government Organizations or finance industry as a part of recovery packages to the disaster affected communities.
    /// <see href="http://observedchange.com/moac/ns#FinancialServicesAvailable"></see></summary>
    let FinancialServicesAvailable = _prefix "FinancialServicesAvailable"
    /// <summary>
    /// Fire is an uncontrolled burning that has the potential to cause physical damage on human life, health, property or ecology.
    /// <see href="http://observedchange.com/moac/ns#Fire"></see></summary>
    let Fire = _prefix "Fire"
    /// <summary>
    /// A flood is an overflow of an expanse of water that submerges land.
    /// <see href="http://observedchange.com/moac/ns#Floods"></see></summary>
    let Floods = _prefix "Floods"
    /// <summary>
    /// FoodDistributionPoint is a pre-identified location for distributing or transporting food or drink to the affected communities.
    /// <see href="http://observedchange.com/moac/ns#FoodDistributionPoint"></see></summary>
    let FoodDistributionPoint = _prefix "FoodDistributionPoint"
    /// <summary>
    /// FoodShortage is a widespread scarcity of food that may apply to any faunal species.
    /// <see href="http://observedchange.com/moac/ns#FoodShortage"></see></summary>
    let FoodShortage = _prefix "FoodShortage"
    /// <summary>
    /// FuelShortage is a lack of minimal cooking or other fuel that a person need on a daily basis.
    /// <see href="http://observedchange.com/moac/ns#FuelShortage"></see></summary>
    let FuelShortage = _prefix "FuelShortage"
    /// <summary>
    /// GroupViolence is a term used to describe more than one individual engaging in some form of criminal activities.
    /// <see href="http://observedchange.com/moac/ns#GroupViolence"></see></summary>
    let GroupViolence = _prefix "GroupViolence"
    /// <summary>
    /// HealthOfWomen is a term used to include all the health issues related to female gender.
    /// <see href="http://observedchange.com/moac/ns#HealthOfWomen"></see></summary>
    let HealthOfWomen = _prefix "HealthOfWomen"
    /// <summary>
    /// High possibility of loss resulting from the occurrence of the phenomenon.
    /// <see href="http://observedchange.com/moac/ns#HighlyVulnerable"></see></summary>
    let HighlyVulnerable = _prefix "HighlyVulnerable"
    /// <summary>
    /// HospitalOperating describes still functioning hospital after a disaster.
    /// <see href="http://observedchange.com/moac/ns#HospitalOperating"></see></summary>
    let HospitalOperating = _prefix "HospitalOperating"
    /// <summary>
    /// HumanRemainsManagement is an abstract term used to define morgues or other locations where dead bodies can be properlay managed.
    /// <see href="http://observedchange.com/moac/ns#HumanRemainsManagement"></see></summary>
    let HumanRemainsManagement = _prefix "HumanRemainsManagement"
    /// <summary>
    /// Humanitarian sectors and categories of population for achieving more strategic responses and better prioritization of available resources by clarifying the division of labour among organizations, better defining the roles and responsibilities of humanitarian organizations within the sectors, and providing the Humanitarian Coordinator with both a first point of call and a provider of last resort in all the key sectors or areas of activity.
    /// <see href="http://observedchange.com/moac/ns#IASCCluster"></see></summary>
    let IASCCluster = _prefix "IASCCluster"
    /// <summary>
    /// IDPConcentration refers to the act of internally displaced people gathering in a certain location, which could eventually turn into an IDP camp.
    /// <see href="http://observedchange.com/moac/ns#IDPConcentration"></see></summary>
    let IDPConcentration = _prefix "IDPConcentration"
    /// <summary>
    /// Incident is a distinct or definite event.
    /// <see href="http://observedchange.com/moac/ns#Incident"></see></summary>
    let Incident = _prefix "Incident"
    /// <summary>
    /// InfectiousHumanDisease comprise of clinically evident illness resulting from the infection, presence and growth of pathogenic biological agents in an individual host organism that could also infect others.
    /// <see href="http://observedchange.com/moac/ns#InfectiousHumanDisease"></see></summary>
    let InfectiousHumanDisease = _prefix "InfectiousHumanDisease"
    /// <summary>
    /// InfrastureDamage is about the damage of physically existing basic facilities, services, and installations needed for the functioning of a community or society.
    /// <see href="http://observedchange.com/moac/ns#InfrastructureDamage"></see></summary>
    let InfrastructureDamage = _prefix "InfrastructureDamage"
    /// <summary>
    /// InternetAccess refers to certain place that can provide internet services.
    /// <see href="http://observedchange.com/moac/ns#InternetAccess"></see></summary>
    let InternetAccess = _prefix "InternetAccess"
    /// <summary>
    /// A landslide is a geological phenomenon which includes a wide range of ground movement.
    /// <see href="http://observedchange.com/moac/ns#Landslides"></see></summary>
    let Landslides = _prefix "Landslides"
    /// <summary>
    /// Looting is term that indicate a form of criminal activity when disaster affected people forcefully take away the relief distribution materials.
    /// <see href="http://observedchange.com/moac/ns#Looting"></see></summary>
    let Looting = _prefix "Looting"
    /// <summary>
    /// A medical emergency is an injury that is acute and poses an immediate risk to a person's life or long term health.
    /// <see href="http://observedchange.com/moac/ns#MedicalEmergency"></see></summary>
    let MedicalEmergency = _prefix "MedicalEmergency"
    /// <summary>
    /// MedicalEquipmentAndSupplyNeeds is a term describe the demand for Medical Equipment and Supplies.
    /// <see href="http://observedchange.com/moac/ns#MedicalEquipmentAndSupplyNeeds"></see></summary>
    let MedicalEquipmentAndSupplyNeeds = _prefix "MedicalEquipmentAndSupplyNeeds"
    /// <summary>
    /// A Menace is a threat or danger that causes intimidation.
    /// <see href="http://observedchange.com/moac/ns#Menaces"></see></summary>
    let Menaces = _prefix "Menaces"
    /// <summary>
    /// MissingPersons are persons whose whereabouts are unknown after sudden onset of disaster.
    /// <see href="http://observedchange.com/moac/ns#MissingPersons"></see></summary>
    let MissingPersons = _prefix "MissingPersons"
    /// <summary>
    /// NFIItems also known as Non Food Items include, but are not limited to, jerry cans, kots, mats distributed or stocked by shelter response humanitarian agencies.
    /// <see href="http://observedchange.com/moac/ns#NFIItems"></see></summary>
    let NFIItems = _prefix "NFIItems"
    /// <summary>
    /// NFINeededAt relates "where" Non Food Items response might be necessary.
    /// <see href="http://observedchange.com/moac/ns#NFINeededAt"></see></summary>
    let NFINeededAt = _prefix "NFINeededAt"
    /// <summary>
    /// Specific location(s) in relation to humanitarian response.
    /// <see href="http://observedchange.com/moac/ns#Where3W"></see></summary>
    let Where3W = _prefix "Where3W"
    /// <summary>
    /// NaturalHazards is a term represent a threat of a naturally occurring event that will have a negative effect on people or the environment .
    /// <see href="http://observedchange.com/moac/ns#NaturalHazards"></see></summary>
    let NaturalHazards = _prefix "NaturalHazards"
    /// <summary>
    /// Cluster Specific humanitarian response information.
    /// <see href="http://observedchange.com/moac/ns#Needs3W"></see></summary>
    let Needs3W = _prefix "Needs3W"
    /// <summary>
    ///   <see href="http://observedchange.com/moac/ns#WhoWhatWhereSection"></see>
    /// </summary>
    let WhoWhatWhereSection = _prefix "WhoWhatWhereSection"
    /// <summary>
    /// Humanitarian needs and response related activities.
    /// <see href="http://observedchange.com/moac/ns#NeedsResponse3W"></see></summary>
    let NeedsResponse3W = _prefix "NeedsResponse3W"
    /// <summary>
    /// NonfoodAidDistributionPoint is a location for distributing or transporting life saving Non Food Item other than food items, also known as NFIs in humaniatarian sphere.
    /// <see href="http://observedchange.com/moac/ns#NonfoodAidDistributionPoint"></see></summary>
    let NonfoodAidDistributionPoint = _prefix "NonfoodAidDistributionPoint"
    /// <summary>
    /// Others is the class that is used when certain instance does not fit any of the classes. (Source:Ushahidi Haiti)
    /// <see href="http://observedchange.com/moac/ns#Others"></see></summary>
    let Others = _prefix "Others"
    /// <summary>
    /// People found in dangerous stituation might not be able to escape from the place they are.
    /// <see href="http://observedchange.com/moac/ns#PeopleTrapped"></see></summary>
    let PeopleTrapped = _prefix "PeopleTrapped"
    /// <summary>
    /// PersonNews is the information about a person's status, e.g. death, injured, alive etc.
    /// <see href="http://observedchange.com/moac/ns#PersonsNews"></see></summary>
    let PersonsNews = _prefix "PersonsNews"
    /// <summary>
    /// PortOpen is the term that indicate a port opening of regular business for receiving humanitarian relief materials.
    /// <see href="http://observedchange.com/moac/ns#PortOpen"></see></summary>
    let PortOpen = _prefix "PortOpen"
    /// <summary>
    /// A PowerOutage is a term which refers to electrical power failure, which means a short- or long-term loss of the electric power to an area.
    /// <see href="http://observedchange.com/moac/ns#PowerOutage"></see></summary>
    let PowerOutage = _prefix "PowerOutage"
    /// <summary>
    /// PriceGouging is a pejorative term referring to a situation in which a seller prices goods or commodities much higher than is considered reasonable or fair.
    /// <see href="http://observedchange.com/moac/ns#PriceGouging"></see></summary>
    let PriceGouging = _prefix "PriceGouging"
    /// <summary>
    /// PsychiatricNeed is a term indicate that people need medical care for mental disorders.
    /// <see href="http://observedchange.com/moac/ns#PsychiatricNeed"></see></summary>
    let PsychiatricNeed = _prefix "PsychiatricNeed"
    /// <summary>
    /// PublicHealth is a term that deals with overall health related issues, conerns and initiatives for or in a community .
    /// <see href="http://observedchange.com/moac/ns#PublicHealth"></see></summary>
    let PublicHealth = _prefix "PublicHealth"
    /// <summary>
    /// Cluster Specific humanitarian response information.
    /// <see href="http://observedchange.com/moac/ns#Response3W"></see></summary>
    let Response3W = _prefix "Response3W"
    /// <summary>
    /// A riot is a form of civil disorder characterized often by disorganized groups lashing out in a sudden and intense rash of violence against authority, property or people.
    /// <see href="http://observedchange.com/moac/ns#Riot"></see></summary>
    let Riot = _prefix "Riot"
    /// <summary>
    /// RoadBlocked indicate a road is blocked by a barricade caused by natural disaster or set up by human.
    /// <see href="http://observedchange.com/moac/ns#RoadBlocked"></see></summary>
    let RoadBlocked = _prefix "RoadBlocked"
    /// <summary>
    /// RubbleRemoval is a term about the agreed upon and systamatic disopsal of of broken stone, of irregular size, shape and texture from a locaktion with totally damaged or partially damaged infrastructures.
    /// <see href="http://observedchange.com/moac/ns#RubbleRemoval"></see></summary>
    let RubbleRemoval = _prefix "RubbleRemoval"
    /// <summary>
    /// SearchAndRescue is a part of humanitarian relief effort on the immediate on set of disaster where a team of experts try and locate missing persons.
    /// <see href="http://observedchange.com/moac/ns#SearchAndRescue"></see></summary>
    let SearchAndRescue = _prefix "SearchAndRescue"
    /// <summary>
    /// SecurityConcern is a abstract term related to the worries of protection against danger, damage, loss, and criminal activity.
    /// <see href="http://observedchange.com/moac/ns#SecurityConcern"></see></summary>
    let SecurityConcern = _prefix "SecurityConcern"
    /// <summary>
    /// ServiceAvailable is an abstract term that indicates availability of different life saving and sustaining services in a disaster struck location/place.
    /// <see href="http://observedchange.com/moac/ns#ServiceAvailable"></see></summary>
    let ServiceAvailable = _prefix "ServiceAvailable"
    /// <summary>
    /// ShelterActivity is a term that describes Shelter Cluster related humanitarian response.
    /// <see href="http://observedchange.com/moac/ns#ShelterActivity"></see></summary>
    let ShelterActivity = _prefix "ShelterActivity"
    /// <summary>
    /// ShelterAgency is a Shelter Cluster related humanitarian partner or a specific organization involved in shelter related humanitarian response.
    /// <see href="http://observedchange.com/moac/ns#ShelterAgency"></see></summary>
    let ShelterAgency = _prefix "ShelterAgency"
    /// <summary>
    /// ShelterDistributionPoint is a specific location where humanitarian relief agencies provide shelter assistances as a part of relief distribution.
    /// <see href="http://observedchange.com/moac/ns#ShelterDistributionPoint"></see></summary>
    let ShelterDistributionPoint = _prefix "ShelterDistributionPoint"
    /// <summary>
    /// ShelterItems include, but are not limited to, tents, tarpulins distributed or stocked by shelter response humanitarian agencies.
    /// <see href="http://observedchange.com/moac/ns#ShelterItems"></see></summary>
    let ShelterItems = _prefix "ShelterItems"
    /// <summary>
    /// ShelterNFIItems define Shelter Cluster related humanitarian relief items (e.g. tents, tarpulins).
    /// <see href="http://observedchange.com/moac/ns#ShelterNFIItems"></see></summary>
    let ShelterNFIItems = _prefix "ShelterNFIItems"
    /// <summary>
    /// ShelterNeeded is a term used to indicate number of emergency life saving basic structures like tents and tarpaulins.
    /// ShelterNeeded records information regarding additional shelter needs as a part of planned relief distribution processes.
    /// <see href="http://observedchange.com/moac/ns#ShelterNeeded"></see></summary>
    let ShelterNeeded = _prefix "ShelterNeeded"
    /// <summary>
    /// ShelterOffered indicates a location where internally displace people have been offered termporary/transitional shelters.
    /// ShelterOffered relates shelter activities when a humanitarian relief agencies provide shelter (e.g. tents, tarps) materials as a part of a relief distribution.
    /// <see href="http://observedchange.com/moac/ns#ShelterOffered"></see></summary>
    let ShelterOffered = _prefix "ShelterOffered"
    /// <summary>
    /// ShelterResponse is related to activities defining Shelter Clusters' humanitarian response in an emergency.
    /// <see href="http://observedchange.com/moac/ns#ShelterResponse"></see></summary>
    let ShelterResponse = _prefix "ShelterResponse"
    /// <summary>
    /// TheftOfAid is a term that indicate a form of criminal activity when unknown person(s) steal the relief distribution materials either from gowdown or relief distribution points.
    /// <see href="http://observedchange.com/moac/ns#TheftOfAid"></see></summary>
    let TheftOfAid = _prefix "TheftOfAid"
    /// <summary>
    /// UnstableStructure is a term that describe a partially damaged bulidings/structures which is still standing but uninhabitable.
    /// <see href="http://observedchange.com/moac/ns#UnstableStructure"></see></summary>
    let UnstableStructure = _prefix "UnstableStructure"
    /// <summary>
    /// UshahidiReport is a report from Ushahidi, contains simultaneously temporal and geospatial archive of events, based on the local observers' reports.
    /// <see href="http://observedchange.com/moac/ns#UshahidiReport"></see></summary>
    let UshahidiReport = _prefix "UshahidiReport"
    /// <summary>
    /// Vitallines is an abstract term that refer to particulars that could directly impact human lives.
    /// <see href="http://observedchange.com/moac/ns#VitalLines"></see></summary>
    let VitalLines = _prefix "VitalLines"
    /// <summary>
    /// WaterDistributionPoint is a location for distributing or transporting daily water to the disaster affected communities.
    /// <see href="http://observedchange.com/moac/ns#WaterDistributionPoint"></see></summary>
    let WaterDistributionPoint = _prefix "WaterDistributionPoint"

    /// <summary>
    /// WaterSanitationAndHygienePromotion is a term refers to a concept that improving access to safe water and sanitation facilities leads to healthier families and communities. (UNICEF)
    /// <see href="http://observedchange.com/moac/ns#WaterSanitationAndHygienePromotion"></see></summary>
    let WaterSanitationAndHygienePromotion =
        _prefix "WaterSanitationAndHygienePromotion"

    /// <summary>
    /// Watershortage is a term used to refer to the situations that water resources can not meet human demand.
    /// <see href="http://observedchange.com/moac/ns#WaterShortage"></see></summary>
    let WaterShortage = _prefix "WaterShortage"
    /// <summary>
    /// Specific activities in relation to humanitarian response.
    /// <see href="http://observedchange.com/moac/ns#What3W"></see></summary>
    let What3W = _prefix "What3W"
    /// <summary>
    /// Specific time in relation to humanitarian response.
    /// <see href="http://observedchange.com/moac/ns#When3W"></see></summary>
    let When3W = _prefix "When3W"
    /// <summary>
    /// Specific agency or Organisation humanitarian response information.
    /// <see href="http://observedchange.com/moac/ns#Who3W"></see></summary>
    let Who3W = _prefix "Who3W"
    /// <summary>
    /// Abstract term to describe the collection of which agency is doing what activities and where.
    /// <see href="http://observedchange.com/moac/ns#WhoWhatWhere3W"></see></summary>
    let WhoWhatWhere3W = _prefix "WhoWhatWhere3W"
    /// <summary>
    /// affectedby indicates disaster which has influence on population.
    /// affectedby indicates the relation of people being affected by certain disaster.
    /// <see href="http://observedchange.com/moac/ns#affectedby"></see></summary>
    let affectedby = _prefix "affectedby"
    /// <summary>
    ///   <see href="http://observedchange.com/moac/ns#NaturalHazard"></see>
    /// </summary>
    let NaturalHazard = _prefix "NaturalHazard"
    /// <summary>
    /// approved is a data property to attest a event or incident or document is true or not.
    /// <see href="http://observedchange.com/moac/ns#approved"></see></summary>
    let approved = _prefix "approved"
    /// <summary>
    /// atGeoLocationLatitude is a data property used to link location or "Where" with specific latitude in the form of decimal degree.
    /// <see href="http://observedchange.com/moac/ns#atGeoLocationLatitude"></see></summary>
    let atGeoLocationLatitude = _prefix "atGeoLocationLatitude"
    /// <summary>
    /// GeoLocationLatitude is a data property used to link location or "Where" with specific longitude in the form of decimal degree.
    /// <see href="http://observedchange.com/moac/ns#atGeoLocationLongitude"></see></summary>
    let atGeoLocationLongitude = _prefix "atGeoLocationLongitude"
    /// <summary>
    /// atLocation is a data property to attest agency to a certain location.
    /// <see href="http://observedchange.com/moac/ns#atLocation"></see></summary>
    let atLocation = _prefix "atLocation"
    /// <summary>
    /// belongsToCluster indicates the organisation which belongs to a specific IASC cluster for example, emergency Shelter cluster or Food Cluster.
    /// <see href="http://observedchange.com/moac/ns#belongsToCluster"></see></summary>
    let belongsToCluster = _prefix "belongsToCluster"
    /// <summary>
    ///   <see href="http://observedchange.com/moac/ns#moac:Who3W"></see>
    /// </summary>
    let ``moac:Who3W`` = _prefix "moac:Who3W"
    /// <summary>
    /// category is about the sort of an incident.
    /// <see href="http://observedchange.com/moac/ns#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// clusterActivity is a property to relate humanitarian Clusters with ongoing humanitarian response to meet the needs of affected population.
    /// <see href="http://observedchange.com/moac/ns#clusterActivity"></see></summary>
    let clusterActivity = _prefix "clusterActivity"
    /// <summary>
    /// countInPipeline indicates the number of relief items that are "in the process" of arriving from a different location.
    /// <see href="http://observedchange.com/moac/ns#countInPipeline"></see></summary>
    let countInPipeline = _prefix "countInPipeline"
    /// <summary>
    /// countInStock indicates the number of items currently stockpiled either at a store or at a distribution location.
    /// <see href="http://observedchange.com/moac/ns#countInStock"></see></summary>
    let countInStock = _prefix "countInStock"
    /// <summary>
    /// countOfAffectedPopulation indicates the total number of people affected by a certain disaster.
    /// <see href="http://observedchange.com/moac/ns#countOfAffectedPopulation"></see></summary>
    let countOfAffectedPopulation = _prefix "countOfAffectedPopulation"
    /// <summary>
    /// countofAffectedHH indicates total number of House Holds affected by a certain disaster.
    /// <see href="http://observedchange.com/moac/ns#countofAffectedHH"></see></summary>
    let countofAffectedHH = _prefix "countofAffectedHH"
    /// <summary>
    /// date indicates a particular date.
    /// <see href="http://observedchange.com/moac/ns#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// dateOfDistbn indicates a particular date when shelter/NFI items are distributed.
    /// <see href="http://observedchange.com/moac/ns#dateOfDistbn"></see></summary>
    let dateOfDistbn = _prefix "dateOfDistbn"
    /// <summary>
    /// description is about the content of an incident.
    /// <see href="http://observedchange.com/moac/ns#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// distributingPartner indicates the name of an organisation that is responsible to distribute relief items in a disaster.
    /// <see href="http://observedchange.com/moac/ns#distributingPartner"></see></summary>
    let distributingPartner = _prefix "distributingPartner"
    /// <summary>
    /// has3Wcomponent indicates the four saparate components of 3W i.e Who What Where and When.
    /// <see href="http://observedchange.com/moac/ns#has3Wcomponent"></see></summary>
    let has3Wcomponent = _prefix "has3Wcomponent"
    /// <summary>
    /// hasNFIItems indicates the name or a type of Non Food Items.
    /// <see href="http://observedchange.com/moac/ns#hasNFIItems"></see></summary>
    let hasNFIItems = _prefix "hasNFIItems"
    /// <summary>
    /// hasOrganisationID is a unique identification number given to relief agency.
    /// <see href="http://observedchange.com/moac/ns#hasOrganisationID"></see></summary>
    let hasOrganisationID = _prefix "hasOrganisationID"
    /// <summary>
    /// hasShelterItems indicates the name or a type of shelter related items.
    /// <see href="http://observedchange.com/moac/ns#hasShelterItems"></see></summary>
    let hasShelterItems = _prefix "hasShelterItems"
    /// <summary>
    /// Impact is the effect or impression of disaster on population or infrastructure
    /// <see href="http://observedchange.com/moac/ns#impact"></see></summary>
    let impact = _prefix "impact"
    /// <summary>
    /// involvedIn indicates the agency that is involved with humanitarian activities/response in a disaster.
    /// <see href="http://observedchange.com/moac/ns#involvedIn"></see></summary>
    let involvedIn = _prefix "involvedIn"
    /// <summary>
    /// organizationName indicates the name of the organisation for a specific IASC cluster like emergency Shelter cluster or Food Cluster.
    /// <see href="http://observedchange.com/moac/ns#organizationName"></see></summary>
    let organizationName = _prefix "organizationName"
    /// <summary>
    /// shelterNeededAt relates "where" shelter response might be necessary.
    /// <see href="http://observedchange.com/moac/ns#shelterNeededAt"></see></summary>
    let shelterNeededAt = _prefix "shelterNeededAt"
    /// <summary>
    /// shelterOfferedAt relates "where" shelter relief agencies provided relief items.
    /// <see href="http://observedchange.com/moac/ns#shelterOfferedAt"></see></summary>
    let shelterOfferedAt = _prefix "shelterOfferedAt"
    /// <summary>
    /// supplyingAgency indicates the name of an organisation that is responsible to provide humanitarian relief items.
    /// <see href="http://observedchange.com/moac/ns#supplyingAgency"></see></summary>
    let supplyingAgency = _prefix "supplyingAgency"
    /// <summary>
    /// tentDistbn relates the amount (count) of shelter items being offered.
    /// <see href="http://observedchange.com/moac/ns#tentDistbn"></see></summary>
    let tentDistbn = _prefix "tentDistbn"
    /// <summary>
    /// Title is an identifying name given to an incident.
    /// <see href="http://observedchange.com/moac/ns#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// verified is a property used in describing if certain information/data has been checked with more than one sources.
    /// <see href="http://observedchange.com/moac/ns#verified"></see></summary>
    let verified = _prefix "verified"
