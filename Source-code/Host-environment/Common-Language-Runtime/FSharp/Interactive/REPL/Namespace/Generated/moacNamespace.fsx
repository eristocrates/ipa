#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module moac =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://observedchange.com/moac/ns#" "moac"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : AffectedPopulation is a group of disaster affecgted people in need of humanitarian support.</para>
    ///   <para>rdfs:label : AffectedPopulation</para>
    ///   <a href="http://observedchange.com/moac/ns#AffectedPopulation">moac:AffectedPopulation</a>
    /// </summary>
    let AffectedPopulation = _prefixId.prefix "AffectedPopulation"
    /// <summary>
    ///   <para>rdfs:comment : Agency is an organization that aims to manage a crisis.</para>
    ///   <para>rdfs:label : Agency</para>
    ///   <a href="http://observedchange.com/moac/ns#Agency">moac:Agency</a>
    /// </summary>
    let Agency = _prefixId.prefix "Agency"
    /// <summary>
    ///   <para>rdfs:comment : AidManipulation.</para>
    ///   <para>rdfs:label : AidManipulation</para>
    ///   <a href="http://observedchange.com/moac/ns#AidManipulation">moac:AidManipulation</a>
    /// </summary>
    let AidManipulation = _prefixId.prefix "AidManipulation"
    /// <summary>
    ///   <para>rdfs:comment : AnimalIllnessOrDeath refers to the illness or death of animals caused by a disaster highlighting the possibility of spread of disease because of direct or indirect contamination.</para>
    ///   <para>rdfs:label : AnimalIllnessOrDeath</para>
    ///   <a href="http://observedchange.com/moac/ns#AnimalIllnessOrDeath">moac:AnimalIllnessOrDeath</a>
    /// </summary>
    let AnimalIllnessOrDeath = _prefixId.prefix "AnimalIllnessOrDeath"
    /// <summary>
    ///   <para>rdfs:comment : AskingToFowardAMessage is the term used to forward certain community directed messages using third party sources.</para>
    ///   <para>rdfs:label : AskingToFowardAMessage</para>
    ///   <a href="http://observedchange.com/moac/ns#AskingToFowardAMessage">moac:AskingToFowardAMessage</a>
    /// </summary>
    let AskingToFowardAMessage = _prefixId.prefix "AskingToFowardAMessage"
    /// <summary>
    ///   <para>rdfs:comment : ChronicCareNeeds refers to the requirement of medical care which addresses preexisting or long term illness.</para>
    ///   <para>rdfs:label : ChronicCareNeeds</para>
    ///   <a href="http://observedchange.com/moac/ns#ChronicCareNeeds">moac:ChronicCareNeeds</a>
    /// </summary>
    let ChronicCareNeeds = _prefixId.prefix "ChronicCareNeeds"
    /// <summary>
    ///   <para>rdfs:comment : Inter Agency Standing Committee Emergency Shelter related agency specific activities. The Shelter Cluster is co-chaired by IFRC and UNHCR at the global level. IFRC is convener of the Emergency Shelter Cluster in disaster situations while UNHCR leads the Emergency Shelter Cluster in the area of conflict generated IDPs (Internally Displaced Persons). In addition to IFRC and UNHCR, participants in the Global Shelter Cluster include: ACTED, Archi-Urgent, Article 25, Care UK, CHF, CRS, DFID, Habitat for Humanity, IOM, Medair, NRC, OFDA, Oxfam GB, ProAct, ProVention, RedR, Relief International, RICS, Save The Children UK, Shelter Centre, SKAT, UN Habitat, UN OCHA, UNRWA and World Vision. (source: sheltercluster.org, accessed on 12 Feb 2012)</para>
    ///   <para>rdfs:label : Cluster1Shelter</para>
    ///   <a href="http://observedchange.com/moac/ns#Cluster1Shelter">moac:Cluster1Shelter</a>
    /// </summary>
    let Cluster1Shelter = _prefixId.prefix "Cluster1Shelter"
    /// <summary>
    ///   <para>rdfs:comment : Inter Agency Standing Committee Emergency Food related agency specific activities. World Food Programme (WFP) is the global cluster lead for Food.</para>
    ///   <para>rdfs:label : Cluster2Food</para>
    ///   <a href="http://observedchange.com/moac/ns#Cluster2Food">moac:Cluster2Food</a>
    /// </summary>
    let Cluster2Food = _prefixId.prefix "Cluster2Food"
    /// <summary>
    ///   <para>rdfs:comment : Inter Agency Standing Committee Emergency Water Sanitation and Hygine related agency specific activities. UNICEF is the global cluster lead for WASH.</para>
    ///   <para>rdfs:label : Cluster3WASH</para>
    ///   <a href="http://observedchange.com/moac/ns#Cluster3WASH">moac:Cluster3WASH</a>
    /// </summary>
    let Cluster3WASH = _prefixId.prefix "Cluster3WASH"
    /// <summary>
    ///   <para>rdfs:comment : A CollapsedStructure is a term that defines a totally damaged state of a structure resulting from human or natural phenomenon.</para>
    ///   <para>rdfs:label : CollapsedStructure</para>
    ///   <a href="http://observedchange.com/moac/ns#CollapsedStructure">moac:CollapsedStructure</a>
    /// </summary>
    let CollapsedStructure = _prefixId.prefix "CollapsedStructure"
    /// <summary>
    ///   <para>rdfs:comment : CommunicationLinesDown indicates that a mobile or a landline phone in ceratain area will not work because of the problem in the communication wired poles.</para>
    ///   <para>rdfs:label : CommunicationLinesDown</para>
    ///   <a href="http://observedchange.com/moac/ns#CommunicationLinesDown">moac:CommunicationLinesDown</a>
    /// </summary>
    let CommunicationLinesDown = _prefixId.prefix "CommunicationLinesDown"
    /// <summary>
    ///   <para>rdfs:comment : CompromisedBridge is a partially or completely damaged bridge that can no longer be used for transporting people or relief materials.</para>
    ///   <para>rdfs:label : CompromisedBridge</para>
    ///   <a href="http://observedchange.com/moac/ns#CompromisedBridge">moac:CompromisedBridge</a>
    /// </summary>
    let CompromisedBridge = _prefixId.prefix "CompromisedBridge"
    /// <summary>
    ///   <para>rdfs:comment : Undrinkable Water is water that is regarded unfit/unhealthy to drink for both humans and animals.</para>
    ///   <para>rdfs:label : ContaminatedWater</para>
    ///   <a href="http://observedchange.com/moac/ns#ContaminatedWater">moac:ContaminatedWater</a>
    /// </summary>
    let ContaminatedWater = _prefixId.prefix "ContaminatedWater"
    /// <summary>
    ///   <para>rdfs:comment : The source and delivery system provides water but polluted. It could result in outbreaks of diseases and other health realted issues.</para>
    ///   <para>rdfs:label : ContaminatedWaterSupply</para>
    ///   <a href="http://observedchange.com/moac/ns#ContaminatedWaterSupply">moac:ContaminatedWaterSupply</a>
    /// </summary>
    let ContaminatedWaterSupply = _prefixId.prefix "ContaminatedWaterSupply"
    /// <summary>
    ///   <para>rdfs:comment : Deaths are the termination of the biological functions that sustain a living organism.</para>
    ///   <para>rdfs:label : Deaths</para>
    ///   <a href="http://observedchange.com/moac/ns#Deaths">moac:Deaths</a>
    /// </summary>
    let Deaths = _prefixId.prefix "Deaths"
    /// <summary>
    ///   <para>rdfs:comment : An earthquake is the result of a sudden release of energy in the Earth's crust that creates seismic waves, and an aftershock is an earthquake that occurs after a previous earthquake, the mainshock.</para>
    ///   <para>rdfs:label : EarthquakeAndAftershock</para>
    ///   <a href="http://observedchange.com/moac/ns#EarthquakeAndAftershock">moac:EarthquakeAndAftershock</a>
    /// </summary>
    let EarthquakeAndAftershock = _prefixId.prefix "EarthquakeAndAftershock"
    /// <summary>
    ///   <para>rdfs:comment : Emergency is a situation that poses an immediate crisis to human, life, health, property or environment.</para>
    ///   <para>rdfs:label : Emergency</para>
    ///   <a href="http://observedchange.com/moac/ns#Emergency">moac:Emergency</a>
    /// </summary>
    let Emergency = _prefixId.prefix "Emergency"
    /// <summary>
    ///   <para>rdfs:comment : FeedingCentersAvailable is a term that defines a location of a facility which supports providing basic life saving foods to infants and lactating mothers.</para>
    ///   <para>rdfs:label : FeedingCentersAvailable</para>
    ///   <a href="http://observedchange.com/moac/ns#FeedingCentersAvailable">moac:FeedingCentersAvailable</a>
    /// </summary>
    let FeedingCentersAvailable = _prefixId.prefix "FeedingCentersAvailable"
    /// <summary>
    ///   <para>rdfs:comment : FinancialServicesAvailabe refers to services provided by the certain Non Government Organizations or finance industry as a part of recovery packages to the disaster affected communities.</para>
    ///   <para>rdfs:label : FinancialServicesAvailable</para>
    ///   <a href="http://observedchange.com/moac/ns#FinancialServicesAvailable">moac:FinancialServicesAvailable</a>
    /// </summary>
    let FinancialServicesAvailable = _prefixId.prefix "FinancialServicesAvailable"
    /// <summary>
    ///   <para>rdfs:comment : Fire is an uncontrolled burning that has the potential to cause physical damage on human life, health, property or ecology.</para>
    ///   <para>rdfs:label : Fire</para>
    ///   <a href="http://observedchange.com/moac/ns#Fire">moac:Fire</a>
    /// </summary>
    let Fire = _prefixId.prefix "Fire"
    /// <summary>
    ///   <para>rdfs:comment : A flood is an overflow of an expanse of water that submerges land.</para>
    ///   <para>rdfs:label : Floods</para>
    ///   <a href="http://observedchange.com/moac/ns#Floods">moac:Floods</a>
    /// </summary>
    let Floods = _prefixId.prefix "Floods"
    /// <summary>
    ///   <para>rdfs:comment : FoodDistributionPoint is a pre-identified location for distributing or transporting food or drink to the affected communities.</para>
    ///   <para>rdfs:label : FoodDistributionPoint</para>
    ///   <a href="http://observedchange.com/moac/ns#FoodDistributionPoint">moac:FoodDistributionPoint</a>
    /// </summary>
    let FoodDistributionPoint = _prefixId.prefix "FoodDistributionPoint"
    /// <summary>
    ///   <para>rdfs:comment : FoodShortage is a widespread scarcity of food that may apply to any faunal species.</para>
    ///   <para>rdfs:label : FoodShortage</para>
    ///   <a href="http://observedchange.com/moac/ns#FoodShortage">moac:FoodShortage</a>
    /// </summary>
    let FoodShortage = _prefixId.prefix "FoodShortage"
    /// <summary>
    ///   <para>rdfs:comment : FuelShortage is a lack of minimal cooking or other fuel that a person need on a daily basis.</para>
    ///   <para>rdfs:label : FuelShortage</para>
    ///   <a href="http://observedchange.com/moac/ns#FuelShortage">moac:FuelShortage</a>
    /// </summary>
    let FuelShortage = _prefixId.prefix "FuelShortage"
    /// <summary>
    ///   <para>rdfs:comment : GroupViolence is a term used to describe more than one individual engaging in some form of criminal activities.</para>
    ///   <para>rdfs:label : GroupViolence</para>
    ///   <a href="http://observedchange.com/moac/ns#GroupViolence">moac:GroupViolence</a>
    /// </summary>
    let GroupViolence = _prefixId.prefix "GroupViolence"
    /// <summary>
    ///   <para>rdfs:comment : HealthOfWomen is a term used to include all the health issues related to female gender.</para>
    ///   <para>rdfs:label : HealthOfWomen</para>
    ///   <a href="http://observedchange.com/moac/ns#HealthOfWomen">moac:HealthOfWomen</a>
    /// </summary>
    let HealthOfWomen = _prefixId.prefix "HealthOfWomen"
    /// <summary>
    ///   <para>rdfs:comment : High possibility of loss resulting from the occurrence of the phenomenon.</para>
    ///   <para>rdfs:label : MedicalEmergency</para>
    ///   <a href="http://observedchange.com/moac/ns#HighlyVulnerable">moac:HighlyVulnerable</a>
    /// </summary>
    let HighlyVulnerable = _prefixId.prefix "HighlyVulnerable"
    /// <summary>
    ///   <para>rdfs:comment : HospitalOperating describes still functioning hospital after a disaster.</para>
    ///   <para>rdfs:label : HospitalOperating</para>
    ///   <a href="http://observedchange.com/moac/ns#HospitalOperating">moac:HospitalOperating</a>
    /// </summary>
    let HospitalOperating = _prefixId.prefix "HospitalOperating"
    /// <summary>
    ///   <para>rdfs:comment : HumanRemainsManagement is an abstract term used to define morgues or other locations where dead bodies can be properlay managed.</para>
    ///   <para>rdfs:label : HumanRemainsManagement</para>
    ///   <a href="http://observedchange.com/moac/ns#HumanRemainsManagement">moac:HumanRemainsManagement</a>
    /// </summary>
    let HumanRemainsManagement = _prefixId.prefix "HumanRemainsManagement"
    /// <summary>
    ///   <para>rdfs:comment : Humanitarian sectors and categories of population for achieving more strategic responses and better prioritization of available resources by clarifying the division of labour among organizations, better defining the roles and responsibilities of humanitarian organizations within the sectors, and providing the Humanitarian Coordinator with both a first point of call and a provider of last resort in all the key sectors or areas of activity.</para>
    ///   <para>rdfs:label : IASCCluster</para>
    ///   <a href="http://observedchange.com/moac/ns#IASCCluster">moac:IASCCluster</a>
    /// </summary>
    let IASCCluster = _prefixId.prefix "IASCCluster"
    let IASCClusterSection = _prefixId.prefix "IASCClusterSection"
    /// <summary>
    ///   <para>rdfs:comment : IDPConcentration refers to the act of internally displaced people gathering in a certain location, which could eventually turn into an IDP camp.</para>
    ///   <para>rdfs:label : IDPConcentration</para>
    ///   <a href="http://observedchange.com/moac/ns#IDPConcentration">moac:IDPConcentration</a>
    /// </summary>
    let IDPConcentration = _prefixId.prefix "IDPConcentration"
    /// <summary>
    ///   <para>rdfs:comment : Incident is a distinct or definite event.</para>
    ///   <para>rdfs:label : Incident</para>
    ///   <a href="http://observedchange.com/moac/ns#Incident">moac:Incident</a>
    /// </summary>
    let Incident = _prefixId.prefix "Incident"
    /// <summary>
    ///   <para>rdfs:comment : InfectiousHumanDisease comprise of clinically evident illness resulting from the infection, presence and growth of pathogenic biological agents in an individual host organism that could also infect others.</para>
    ///   <para>rdfs:label : InfectiousHumanDisease</para>
    ///   <a href="http://observedchange.com/moac/ns#InfectiousHumanDisease">moac:InfectiousHumanDisease</a>
    /// </summary>
    let InfectiousHumanDisease = _prefixId.prefix "InfectiousHumanDisease"
    /// <summary>
    ///   <para>rdfs:comment : InfrastureDamage is about the damage of physically existing basic facilities, services, and installations needed for the functioning of a community or society.</para>
    ///   <para>rdfs:label : InfrastructureDamage</para>
    ///   <a href="http://observedchange.com/moac/ns#InfrastructureDamage">moac:InfrastructureDamage</a>
    /// </summary>
    let InfrastructureDamage = _prefixId.prefix "InfrastructureDamage"
    /// <summary>
    ///   <para>rdfs:comment : InternetAccess refers to certain place that can provide internet services.</para>
    ///   <para>rdfs:label : InternetAccess</para>
    ///   <a href="http://observedchange.com/moac/ns#InternetAccess">moac:InternetAccess</a>
    /// </summary>
    let InternetAccess = _prefixId.prefix "InternetAccess"
    /// <summary>
    ///   <para>rdfs:comment : A landslide is a geological phenomenon which includes a wide range of ground movement.</para>
    ///   <para>rdfs:label : Landslides</para>
    ///   <a href="http://observedchange.com/moac/ns#Landslides">moac:Landslides</a>
    /// </summary>
    let Landslides = _prefixId.prefix "Landslides"
    /// <summary>
    ///   <para>rdfs:comment : Looting is term that indicate a form of criminal activity when disaster affected people forcefully take away the relief distribution materials.</para>
    ///   <para>rdfs:label : Looting</para>
    ///   <a href="http://observedchange.com/moac/ns#Looting">moac:Looting</a>
    /// </summary>
    let Looting = _prefixId.prefix "Looting"
    /// <summary>
    ///   <para>rdfs:comment : A medical emergency is an injury that is acute and poses an immediate risk to a person's life or long term health.</para>
    ///   <para>rdfs:label : MedicalEmergency</para>
    ///   <a href="http://observedchange.com/moac/ns#MedicalEmergency">moac:MedicalEmergency</a>
    /// </summary>
    let MedicalEmergency = _prefixId.prefix "MedicalEmergency"

    /// <summary>
    ///   <para>rdfs:comment : MedicalEquipmentAndSupplyNeeds is a term describe the demand for Medical Equipment and Supplies.</para>
    ///   <para>rdfs:label : MedicalEquipmentAndSupplyNeeds</para>
    ///   <a href="http://observedchange.com/moac/ns#MedicalEquipmentAndSupplyNeeds">moac:MedicalEquipmentAndSupplyNeeds</a>
    /// </summary>
    let MedicalEquipmentAndSupplyNeeds =
        _prefixId.prefix "MedicalEquipmentAndSupplyNeeds"

    /// <summary>
    ///   <para>rdfs:comment : A Menace is a threat or danger that causes intimidation.</para>
    ///   <para>rdfs:label : Menaces</para>
    ///   <a href="http://observedchange.com/moac/ns#Menaces">moac:Menaces</a>
    /// </summary>
    let Menaces = _prefixId.prefix "Menaces"
    /// <summary>
    ///   <para>rdfs:comment : MissingPersons are persons whose whereabouts are unknown after sudden onset of disaster.</para>
    ///   <para>rdfs:label : MissingPersons</para>
    ///   <a href="http://observedchange.com/moac/ns#MissingPersons">moac:MissingPersons</a>
    /// </summary>
    let MissingPersons = _prefixId.prefix "MissingPersons"
    /// <summary>
    ///   <para>rdfs:comment : NFIItems also known as Non Food Items include, but are not limited to, jerry cans, kots, mats distributed or stocked by shelter response humanitarian agencies.</para>
    ///   <para>rdfs:label : NFIItems</para>
    ///   <a href="http://observedchange.com/moac/ns#NFIItems">moac:NFIItems</a>
    /// </summary>
    let NFIItems = _prefixId.prefix "NFIItems"
    let NFINeededAt = _prefixId.prefix "NFINeededAt"
    let NaturalHazard = _prefixId.prefix "NaturalHazard"
    /// <summary>
    ///   <para>rdfs:comment : NaturalHazards is a term represent a threat of a naturally occurring event that will have a negative effect on people or the environment .</para>
    ///   <para>rdfs:label : NaturalHazards</para>
    ///   <a href="http://observedchange.com/moac/ns#NaturalHazards">moac:NaturalHazards</a>
    /// </summary>
    let NaturalHazards = _prefixId.prefix "NaturalHazards"
    /// <summary>
    ///   <para>rdfs:comment : Cluster Specific humanitarian response information.</para>
    ///   <para>rdfs:label : Needs3W</para>
    ///   <a href="http://observedchange.com/moac/ns#Needs3W">moac:Needs3W</a>
    /// </summary>
    let Needs3W = _prefixId.prefix "Needs3W"
    /// <summary>
    ///   <para>rdfs:comment : Humanitarian needs and response related activities.</para>
    ///   <para>rdfs:label : NeedsResponse3W</para>
    ///   <a href="http://observedchange.com/moac/ns#NeedsResponse3W">moac:NeedsResponse3W</a>
    /// </summary>
    let NeedsResponse3W = _prefixId.prefix "NeedsResponse3W"
    /// <summary>
    ///   <para>rdfs:comment : NonfoodAidDistributionPoint is a location for distributing or transporting life saving Non Food Item other than food items, also known as NFIs in humaniatarian sphere.</para>
    ///   <para>rdfs:label : NonfoodAidDistributionPoint</para>
    ///   <a href="http://observedchange.com/moac/ns#NonfoodAidDistributionPoint">moac:NonfoodAidDistributionPoint</a>
    /// </summary>
    let NonfoodAidDistributionPoint = _prefixId.prefix "NonfoodAidDistributionPoint"
    /// <summary>
    ///   <para>rdfs:comment : Others is the class that is used when certain instance does not fit any of the classes. (Source:Ushahidi Haiti)</para>
    ///   <para>rdfs:label : Others</para>
    ///   <a href="http://observedchange.com/moac/ns#Others">moac:Others</a>
    /// </summary>
    let Others = _prefixId.prefix "Others"
    /// <summary>
    ///   <para>rdfs:comment : People found in dangerous stituation might not be able to escape from the place they are.</para>
    ///   <para>rdfs:label : PeopleTrapped</para>
    ///   <a href="http://observedchange.com/moac/ns#PeopleTrapped">moac:PeopleTrapped</a>
    /// </summary>
    let PeopleTrapped = _prefixId.prefix "PeopleTrapped"
    /// <summary>
    ///   <para>rdfs:comment : PersonNews is the information about a person's status, e.g. death, injured, alive etc.</para>
    ///   <para>rdfs:label : PersonsNews</para>
    ///   <a href="http://observedchange.com/moac/ns#PersonsNews">moac:PersonsNews</a>
    /// </summary>
    let PersonsNews = _prefixId.prefix "PersonsNews"
    /// <summary>
    ///   <para>rdfs:comment : PortOpen is the term that indicate a port opening of regular business for receiving humanitarian relief materials.</para>
    ///   <para>rdfs:label : PortOpen</para>
    ///   <a href="http://observedchange.com/moac/ns#PortOpen">moac:PortOpen</a>
    /// </summary>
    let PortOpen = _prefixId.prefix "PortOpen"
    /// <summary>
    ///   <para>rdfs:comment : A PowerOutage is a term which refers to electrical power failure, which means a short- or long-term loss of the electric power to an area.</para>
    ///   <para>rdfs:label : PowerOutage</para>
    ///   <a href="http://observedchange.com/moac/ns#PowerOutage">moac:PowerOutage</a>
    /// </summary>
    let PowerOutage = _prefixId.prefix "PowerOutage"
    /// <summary>
    ///   <para>rdfs:comment : PriceGouging is a pejorative term referring to a situation in which a seller prices goods or commodities much higher than is considered reasonable or fair.</para>
    ///   <para>rdfs:label : PriceGouging</para>
    ///   <a href="http://observedchange.com/moac/ns#PriceGouging">moac:PriceGouging</a>
    /// </summary>
    let PriceGouging = _prefixId.prefix "PriceGouging"
    /// <summary>
    ///   <para>rdfs:comment : PsychiatricNeed is a term indicate that people need medical care for mental disorders.</para>
    ///   <para>rdfs:label : PsychiatricNeed</para>
    ///   <a href="http://observedchange.com/moac/ns#PsychiatricNeed">moac:PsychiatricNeed</a>
    /// </summary>
    let PsychiatricNeed = _prefixId.prefix "PsychiatricNeed"
    /// <summary>
    ///   <para>rdfs:comment : PublicHealth is a term that deals with overall health related issues, conerns and initiatives for or in a community .</para>
    ///   <para>rdfs:label : PublicHealth</para>
    ///   <a href="http://observedchange.com/moac/ns#PublicHealth">moac:PublicHealth</a>
    /// </summary>
    let PublicHealth = _prefixId.prefix "PublicHealth"
    /// <summary>
    ///   <para>rdfs:comment : Cluster Specific humanitarian response information.</para>
    ///   <para>rdfs:label : Response3W</para>
    ///   <a href="http://observedchange.com/moac/ns#Response3W">moac:Response3W</a>
    /// </summary>
    let Response3W = _prefixId.prefix "Response3W"
    /// <summary>
    ///   <para>rdfs:comment : A riot is a form of civil disorder characterized often by disorganized groups lashing out in a sudden and intense rash of violence against authority, property or people.</para>
    ///   <para>rdfs:label : Riot</para>
    ///   <a href="http://observedchange.com/moac/ns#Riot">moac:Riot</a>
    /// </summary>
    let Riot = _prefixId.prefix "Riot"
    /// <summary>
    ///   <para>rdfs:comment : RoadBlocked indicate a road is blocked by a barricade caused by natural disaster or set up by human.</para>
    ///   <para>rdfs:label : RoadBlocked</para>
    ///   <a href="http://observedchange.com/moac/ns#RoadBlocked">moac:RoadBlocked</a>
    /// </summary>
    let RoadBlocked = _prefixId.prefix "RoadBlocked"
    /// <summary>
    ///   <para>rdfs:comment : RubbleRemoval is a term about the agreed upon and systamatic disopsal of of broken stone, of irregular size, shape and texture from a locaktion with totally damaged or partially damaged infrastructures.</para>
    ///   <para>rdfs:label : RubbleRemoval</para>
    ///   <a href="http://observedchange.com/moac/ns#RubbleRemoval">moac:RubbleRemoval</a>
    /// </summary>
    let RubbleRemoval = _prefixId.prefix "RubbleRemoval"
    /// <summary>
    ///   <para>rdfs:comment : SearchAndRescue is a part of humanitarian relief effort on the immediate on set of disaster where a team of experts try and locate missing persons.</para>
    ///   <para>rdfs:label : SearchAndRescue</para>
    ///   <a href="http://observedchange.com/moac/ns#SearchAndRescue">moac:SearchAndRescue</a>
    /// </summary>
    let SearchAndRescue = _prefixId.prefix "SearchAndRescue"
    /// <summary>
    ///   <para>rdfs:comment : SecurityConcern is a abstract term related to the worries of protection against danger, damage, loss, and criminal activity.</para>
    ///   <para>rdfs:label : SecurityConcern</para>
    ///   <a href="http://observedchange.com/moac/ns#SecurityConcern">moac:SecurityConcern</a>
    /// </summary>
    let SecurityConcern = _prefixId.prefix "SecurityConcern"
    /// <summary>
    ///   <para>rdfs:comment : ServiceAvailable is an abstract term that indicates availability of different life saving and sustaining services in a disaster struck location/place.</para>
    ///   <para>rdfs:label : ServiceAvailable</para>
    ///   <a href="http://observedchange.com/moac/ns#ServiceAvailable">moac:ServiceAvailable</a>
    /// </summary>
    let ServiceAvailable = _prefixId.prefix "ServiceAvailable"
    /// <summary>
    ///   <para>rdfs:comment : ShelterActivity is a term that describes Shelter Cluster related humanitarian response.</para>
    ///   <para>rdfs:label : ShelterActivity</para>
    ///   <a href="http://observedchange.com/moac/ns#ShelterActivity">moac:ShelterActivity</a>
    /// </summary>
    let ShelterActivity = _prefixId.prefix "ShelterActivity"
    /// <summary>
    ///   <para>rdfs:comment : ShelterAgency is a Shelter Cluster related humanitarian partner or a specific organization involved in shelter related humanitarian response.</para>
    ///   <para>rdfs:label : ShelterAgency</para>
    ///   <a href="http://observedchange.com/moac/ns#ShelterAgency">moac:ShelterAgency</a>
    /// </summary>
    let ShelterAgency = _prefixId.prefix "ShelterAgency"
    /// <summary>
    ///   <para>rdfs:comment : ShelterDistributionPoint is a specific location where humanitarian relief agencies provide shelter assistances as a part of relief distribution.</para>
    ///   <para>rdfs:label : ShelterDistributionPoint</para>
    ///   <a href="http://observedchange.com/moac/ns#ShelterDistributionPoint">moac:ShelterDistributionPoint</a>
    /// </summary>
    let ShelterDistributionPoint = _prefixId.prefix "ShelterDistributionPoint"
    /// <summary>
    ///   <para>rdfs:comment : ShelterItems include, but are not limited to, tents, tarpulins distributed or stocked by shelter response humanitarian agencies.</para>
    ///   <para>rdfs:label : ShelterItems</para>
    ///   <a href="http://observedchange.com/moac/ns#ShelterItems">moac:ShelterItems</a>
    /// </summary>
    let ShelterItems = _prefixId.prefix "ShelterItems"
    /// <summary>
    ///   <para>rdfs:comment : ShelterNFIItems define Shelter Cluster related humanitarian relief items (e.g. tents, tarpulins).</para>
    ///   <para>rdfs:label : ShelterNFIItems</para>
    ///   <a href="http://observedchange.com/moac/ns#ShelterNFIItems">moac:ShelterNFIItems</a>
    /// </summary>
    let ShelterNFIItems = _prefixId.prefix "ShelterNFIItems"
    /// <summary>
    ///   <para>rdfs:comment : ShelterNeeded is a term used to indicate number of emergency life saving basic structures like tents and tarpaulins.rdfs:comment : ShelterNeeded records information regarding additional shelter needs as a part of planned relief distribution processes.</para>
    ///   <para>rdfs:label : ShelterNeeded</para>
    ///   <a href="http://observedchange.com/moac/ns#ShelterNeeded">moac:ShelterNeeded</a>
    /// </summary>
    let ShelterNeeded = _prefixId.prefix "ShelterNeeded"
    /// <summary>
    ///   <para>rdfs:comment : ShelterOffered indicates a location where internally displace people have been offered termporary/transitional shelters.rdfs:comment : ShelterOffered relates shelter activities when a humanitarian relief agencies provide shelter (e.g. tents, tarps) materials as a part of a relief distribution.</para>
    ///   <para>rdfs:label : ShelterOffered</para>
    ///   <a href="http://observedchange.com/moac/ns#ShelterOffered">moac:ShelterOffered</a>
    /// </summary>
    let ShelterOffered = _prefixId.prefix "ShelterOffered"
    /// <summary>
    ///   <para>rdfs:comment : ShelterResponse is related to activities defining Shelter Clusters' humanitarian response in an emergency.</para>
    ///   <para>rdfs:label : ShelterResponse</para>
    ///   <a href="http://observedchange.com/moac/ns#ShelterResponse">moac:ShelterResponse</a>
    /// </summary>
    let ShelterResponse = _prefixId.prefix "ShelterResponse"
    /// <summary>
    ///   <para>rdfs:comment : TheftOfAid is a term that indicate a form of criminal activity when unknown person(s) steal the relief distribution materials either from gowdown or relief distribution points.</para>
    ///   <para>rdfs:label : TheftOfAid</para>
    ///   <a href="http://observedchange.com/moac/ns#TheftOfAid">moac:TheftOfAid</a>
    /// </summary>
    let TheftOfAid = _prefixId.prefix "TheftOfAid"
    /// <summary>
    ///   <para>rdfs:comment : UnstableStructure is a term that describe a partially damaged bulidings/structures which is still standing but uninhabitable.</para>
    ///   <para>rdfs:label : UnstableStructure</para>
    ///   <a href="http://observedchange.com/moac/ns#UnstableStructure">moac:UnstableStructure</a>
    /// </summary>
    let UnstableStructure = _prefixId.prefix "UnstableStructure"
    /// <summary>
    ///   <para>rdfs:comment : UshahidiReport is a report from Ushahidi, contains simultaneously temporal and geospatial archive of events, based on the local observers' reports.</para>
    ///   <para>rdfs:label : UshahidiReport</para>
    ///   <a href="http://observedchange.com/moac/ns#UshahidiReport">moac:UshahidiReport</a>
    /// </summary>
    let UshahidiReport = _prefixId.prefix "UshahidiReport"
    /// <summary>
    ///   <para>rdfs:comment : Vitallines is an abstract term that refer to particulars that could directly impact human lives.</para>
    ///   <para>rdfs:label : VitalLines</para>
    ///   <a href="http://observedchange.com/moac/ns#VitalLines">moac:VitalLines</a>
    /// </summary>
    let VitalLines = _prefixId.prefix "VitalLines"
    /// <summary>
    ///   <para>rdfs:comment : WaterDistributionPoint is a location for distributing or transporting daily water to the disaster affected communities.</para>
    ///   <para>rdfs:label : WaterDistributionPoint</para>
    ///   <a href="http://observedchange.com/moac/ns#WaterDistributionPoint">moac:WaterDistributionPoint</a>
    /// </summary>
    let WaterDistributionPoint = _prefixId.prefix "WaterDistributionPoint"

    /// <summary>
    ///   <para>rdfs:comment : WaterSanitationAndHygienePromotion is a term refers to a concept that improving access to safe water and sanitation facilities leads to healthier families and communities. (UNICEF)</para>
    ///   <para>rdfs:label : WaterSanitationAndHygienePromotion</para>
    ///   <a href="http://observedchange.com/moac/ns#WaterSanitationAndHygienePromotion">moac:WaterSanitationAndHygienePromotion</a>
    /// </summary>
    let WaterSanitationAndHygienePromotion =
        _prefixId.prefix "WaterSanitationAndHygienePromotion"

    /// <summary>
    ///   <para>rdfs:comment : Watershortage is a term used to refer to the situations that water resources can not meet human demand.</para>
    ///   <para>rdfs:label : WaterShortage</para>
    ///   <a href="http://observedchange.com/moac/ns#WaterShortage">moac:WaterShortage</a>
    /// </summary>
    let WaterShortage = _prefixId.prefix "WaterShortage"
    /// <summary>
    ///   <para>rdfs:comment : Specific activities in relation to humanitarian response.</para>
    ///   <para>rdfs:label : What3W</para>
    ///   <a href="http://observedchange.com/moac/ns#What3W">moac:What3W</a>
    /// </summary>
    let What3W = _prefixId.prefix "What3W"
    /// <summary>
    ///   <para>rdfs:comment : Specific time in relation to humanitarian response.</para>
    ///   <para>rdfs:label : When3W</para>
    ///   <a href="http://observedchange.com/moac/ns#When3W">moac:When3W</a>
    /// </summary>
    let When3W = _prefixId.prefix "When3W"
    /// <summary>
    ///   <para>rdfs:comment : Specific location(s) in relation to humanitarian response.</para>
    ///   <para>rdfs:label : Where3W</para>
    ///   <a href="http://observedchange.com/moac/ns#Where3W">moac:Where3W</a>
    /// </summary>
    let Where3W = _prefixId.prefix "Where3W"
    /// <summary>
    ///   <para>rdfs:comment : Specific agency or Organisation humanitarian response information.</para>
    ///   <para>rdfs:label : Who3W</para>
    ///   <a href="http://observedchange.com/moac/ns#Who3W">moac:Who3W</a>
    /// </summary>
    let Who3W = _prefixId.prefix "Who3W"
    /// <summary>
    ///   <para>rdfs:comment : Abstract term to describe the collection of which agency is doing what activities and where.</para>
    ///   <para>rdfs:label : WaterShortage</para>
    ///   <a href="http://observedchange.com/moac/ns#WhoWhatWhere3W">moac:WhoWhatWhere3W</a>
    /// </summary>
    let WhoWhatWhere3W = _prefixId.prefix "WhoWhatWhere3W"
    let WhoWhatWhereSection = _prefixId.prefix "WhoWhatWhereSection"
    let affectedby = _prefixId.prefix "affectedby"
    let approved = _prefixId.prefix "approved"
    let atGeoLocationLatitude = _prefixId.prefix "atGeoLocationLatitude"
    let atGeoLocationLongitude = _prefixId.prefix "atGeoLocationLongitude"
    let atLocation = _prefixId.prefix "atLocation"
    let belongsToCluster = _prefixId.prefix "belongsToCluster"
    let category = _prefixId.prefix "category"
    let clusterActivity = _prefixId.prefix "clusterActivity"
    let countInPipeline = _prefixId.prefix "countInPipeline"
    let countInStock = _prefixId.prefix "countInStock"
    let countOfAffectedPopulation = _prefixId.prefix "countOfAffectedPopulation"
    let countofAffectedHH = _prefixId.prefix "countofAffectedHH"
    let date = _prefixId.prefix "date"
    let dateOfDistbn = _prefixId.prefix "dateOfDistbn"
    let description = _prefixId.prefix "description"
    let distributingPartner = _prefixId.prefix "distributingPartner"
    let has3Wcomponent = _prefixId.prefix "has3Wcomponent"
    let hasNFIItems = _prefixId.prefix "hasNFIItems"
    let hasOrganisationID = _prefixId.prefix "hasOrganisationID"
    let hasShelterItems = _prefixId.prefix "hasShelterItems"
    let impact = _prefixId.prefix "impact"
    let involvedIn = _prefixId.prefix "involvedIn"
    let moacWho3W = _prefixId.prefix "moac:Who3W"
    let organizationName = _prefixId.prefix "organizationName"
    let shelterNeededAt = _prefixId.prefix "shelterNeededAt"
    let shelterOfferedAt = _prefixId.prefix "shelterOfferedAt"
    let supplyingAgency = _prefixId.prefix "supplyingAgency"
    let tentDistbn = _prefixId.prefix "tentDistbn"
    let title = _prefixId.prefix "title"
    let verified = _prefixId.prefix "verified"
