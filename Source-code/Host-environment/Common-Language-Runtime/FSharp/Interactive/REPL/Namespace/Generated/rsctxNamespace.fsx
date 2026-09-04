#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rsctx =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://softeng.polito.it/rsctx#" "rsctx"

    let _00 = _prefixId.prefix "00"
    let _01 = _prefixId.prefix "01"
    let _02 = _prefixId.prefix "02"
    let _03 = _prefixId.prefix "03"
    let _04 = _prefixId.prefix "04"
    let _05 = _prefixId.prefix "05"
    let _06 = _prefixId.prefix "06"
    let _07 = _prefixId.prefix "07"
    let _08 = _prefixId.prefix "08"
    let _09 = _prefixId.prefix "09"
    let _10 = _prefixId.prefix "10"
    let _11 = _prefixId.prefix "11"
    let _12 = _prefixId.prefix "12"
    let _13 = _prefixId.prefix "13"
    let _14 = _prefixId.prefix "14"
    let _15 = _prefixId.prefix "15"
    let _16 = _prefixId.prefix "16"
    let _17 = _prefixId.prefix "17"
    let _18 = _prefixId.prefix "18"
    let _19 = _prefixId.prefix "19"
    let _20 = _prefixId.prefix "20"
    let _21 = _prefixId.prefix "21"
    let _22 = _prefixId.prefix "22"
    let _23 = _prefixId.prefix "23"
    /// <summary>
    ///   <para>rdfs:label : Administrative Region</para>
    ///   <para>rdfs:comment : A  specific type of subnational entity in a number of countries, e.g. Belgium, Italy, France.</para>
    ///   <a href="http://softeng.polito.it/rsctx#AdministrativeRegion">rsctx:AdministrativeRegion</a>
    /// </summary>
    let AdministrativeRegion = _prefixId.prefix "AdministrativeRegion"
    let Afternoon = _prefixId.prefix "Afternoon"
    /// <summary>
    ///   <para>rdfs:label : Anchor Point</para>
    ///   <para>rdfs:comment : It is a key  location,  such  as  our  home  and  work  place,  that  we
    /// consider as "anchor" in our understanding of the geographic environment
    /// where we live. In general, an anchor-point is a frequently visited location or a location where one spends a lot of time.</para>
    ///   <a href="http://softeng.polito.it/rsctx#AnchorPoint">rsctx:AnchorPoint</a>
    /// </summary>
    let AnchorPoint = _prefixId.prefix "AnchorPoint"
    let Bike = _prefixId.prefix "Bike"
    /// <summary>
    ///   <para>rdfs:label : Bossrdfs:label : Chiefrdfs:label : Managerrdfs:label : Superiorrdfs:label : Supervisor</para>
    ///   <para>rdfs:comment : The user is with his boss. This may be a more formal situation that being with just the colleagues.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Boss">rsctx:Boss</a>
    /// </summary>
    let Boss = _prefixId.prefix "Boss"
    /// <summary>
    ///   <para>rdfs:label : Business Partner</para>
    ///   <para>rdfs:comment : The user is with a business partner, e.g. a business partner can be a customer or a member of another organizations with which the user is collaborating or a supplier.</para>
    ///   <a href="http://softeng.polito.it/rsctx#BusinessPartner">rsctx:BusinessPartner</a>
    /// </summary>
    let BusinessPartner = _prefixId.prefix "BusinessPartner"
    /// <summary>
    ///   <para>rdfs:label : Calendar Season</para>
    ///   <para>rdfs:comment : Season which is generally recognized in temperate and subpolar regions, include summer, spring, winter and fall (or autumn).
    ///
    /// WARNING This class has just the purpose to organize the seasons. It SHOULD NOT have instances.</para>
    ///   <a href="http://softeng.polito.it/rsctx#CalendarSeason">rsctx:CalendarSeason</a>
    /// </summary>
    let CalendarSeason = _prefixId.prefix "CalendarSeason"
    let Calm = _prefixId.prefix "Calm"
    let Car = _prefixId.prefix "Car"
    let Chaotic = _prefixId.prefix "Chaotic"
    /// <summary>
    ///   <para>rdfs:label : Childrdfs:label : Kid</para>
    ///   <para>rdfs:comment : The user is with children, not necessarily his family: for example may be a teacher or a baby sitter.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Child">rsctx:Child</a>
    /// </summary>
    let Child = _prefixId.prefix "Child"
    let Cold = _prefixId.prefix "Cold"
    /// <summary>
    ///   <para>rdfs:label : Colleague</para>
    ///   <para>rdfs:comment : The user is with one or more colleagues.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Colleague">rsctx:Colleague</a>
    /// </summary>
    let Colleague = _prefixId.prefix "Colleague"
    /// <summary>
    ///   <para>rdfs:label : Companion</para>
    ///   <para>rdfs:comment : Companion class indicates which kind of company the user as at the moment. For example, it may be with family, friends or colleagues.
    ///
    /// WARNING Its subclasses not as individual, because the individual could be a person (e.g. Bob or Alice), and it is an istance also of one of companion sublasses to indicate which in kind of companion the individual is for the user in the current context (e.g. is family or colleagues or friend).</para>
    ///   <a href="http://softeng.polito.it/rsctx#Companion">rsctx:Companion</a>
    /// </summary>
    let Companion = _prefixId.prefix "Companion"
    /// <summary>
    ///   <para>rdfs:label : Comapanion's Home</para>
    ///   <para>rdfs:comment : The home of a companion of the user, such as a freind's home or a colleague's home.
    ///
    /// WARNING This piece of information can be hard to obtained (unless explicitly asked to the user). It is a class and not an individual because the individual is the specific house (e.g. my friend Bob's house).</para>
    ///   <a href="http://softeng.polito.it/rsctx#CompanionHome">rsctx:CompanionHome</a>
    /// </summary>
    let CompanionHome = _prefixId.prefix "CompanionHome"
    let Cool = _prefixId.prefix "Cool"
    /// <summary>
    ///   <para>rdfs:label : Day Of Week</para>
    ///   <para>rdfs:comment : This class indicates the day of the week (such as Monday, Tuesday, etc.).</para>
    ///   <a href="http://softeng.polito.it/rsctx#DayOfWeek">rsctx:DayOfWeek</a>
    /// </summary>
    let DayOfWeek = _prefixId.prefix "DayOfWeek"
    let Dominance = _prefixId.prefix "Dominance"
    let DrySeason = _prefixId.prefix "DrySeason"
    /// <summary>
    ///   <para>rdfs:label : Emotional State</para>
    ///   <para>rdfs:comment : The state of a person's emotions (especially with regard to pleasure or dejection).
    ///
    /// WARNING The possible values are represented as individuals while in the GUMO ontology are classes.</para>
    ///   <a href="http://softeng.polito.it/rsctx#EmotionalState">rsctx:EmotionalState</a>
    /// </summary>
    let EmotionalState = _prefixId.prefix "EmotionalState"
    let Evening = _prefixId.prefix "Evening"
    let Fall = _prefixId.prefix "Fall"
    /// <summary>
    ///   <para>rdfs:label : Family</para>
    ///   <para>rdfs:comment : The user is with his family, not necessarely with children. For instance, this may includes being just with the sister or brother or the parents.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Family">rsctx:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>rdfs:label : Fitness</para>
    ///   <para>rdfs:comment : It is a value partition which represents the health of the body, it can be seen as a summary of physiological state, since it is possible to map fitness values with physiological indicators ranges (e.g. ill if temperature greater than a certain threshold), although this is up to the designer which is using the ontology.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Fitness">rsctx:Fitness</a>
    /// </summary>
    let Fitness = _prefixId.prefix "Fitness"
    let Freezing = _prefixId.prefix "Freezing"
    /// <summary>
    ///   <para>rdfs:label : Friend</para>
    ///   <para>rdfs:comment : The user is with one or more friends.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Friend">rsctx:Friend</a>
    /// </summary>
    let Friend = _prefixId.prefix "Friend"
    /// <summary>
    ///   <para>rdfs:label : Geographical Region</para>
    ///   <para>rdfs:comment : A physical or historical region. Such as the Iberian peninsula or the Northwest European Atlantic Protestant Region (i.e. the European "source regions" in early American colonization efforts).</para>
    ///   <a href="http://softeng.polito.it/rsctx#GeographicalRegion">rsctx:GeographicalRegion</a>
    /// </summary>
    let GeographicalRegion = _prefixId.prefix "GeographicalRegion"
    let Home = _prefixId.prefix "Home"
    let Hot = _prefixId.prefix "Hot"
    /// <summary>
    ///   <para>rdfs:label : Hour</para>
    ///   <para>rdfs:comment : The hours of a day.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Hour">rsctx:Hour</a>
    /// </summary>
    let Hour = _prefixId.prefix "Hour"
    /// <summary>
    ///   <para>rdfs:label : Light Level</para>
    ///   <para>rdfs:comment : This class represent the current level of light. It is intended some symbolic level such as dark, sunlight, etc.</para>
    ///   <a href="http://softeng.polito.it/rsctx#LightLevel">rsctx:LightLevel</a>
    /// </summary>
    let LightLevel = _prefixId.prefix "LightLevel"
    /// <summary>
    ///   <para>rdfs:label : Mental State</para>
    ///   <para>rdfs:comment : A mental condition in which the qualities of a state are relatively constant even though the state itself may be dynamic, such as depression, cognitive load, nervousness.
    ///
    /// WARNING The possible values are represented as individuals while in the GUMO ontology are classes.</para>
    ///   <a href="http://softeng.polito.it/rsctx#MentalState">rsctx:MentalState</a>
    /// </summary>
    let MentalState = _prefixId.prefix "MentalState"
    let Mild = _prefixId.prefix "Mild"
    let MildSeason = _prefixId.prefix "MildSeason"
    let Moderate = _prefixId.prefix "Moderate"
    let Morning = _prefixId.prefix "Morning"
    /// <summary>
    ///   <para>rdfs:label : Motion^^xsd:string</para>
    ///   <para>rdfs:comment : This class indicates if the user is moving and how, e.g. if he is walking or running.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Motion">rsctx:Motion</a>
    /// </summary>
    let Motion = _prefixId.prefix "Motion"
    let Night = _prefixId.prefix "Night"
    let NoTrasportationMean = _prefixId.prefix "NoTrasportationMean"
    /// <summary>
    ///   <para>rdfs:label : Nobody</para>
    ///   <para>rdfs:comment : The user is alone.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Nobody">rsctx:Nobody</a>
    /// </summary>
    let Nobody = _prefixId.prefix "Nobody"
    /// <summary>
    ///   <para>rdfs:label : Noise Level</para>
    ///   <para>rdfs:comment : This class represents the current level of noise. It is intended a symbolic level such as very noisy, silent, etc.</para>
    ///   <a href="http://softeng.polito.it/rsctx#NoiseLevel">rsctx:NoiseLevel</a>
    /// </summary>
    let NoiseLevel = _prefixId.prefix "NoiseLevel"
    /// <summary>
    ///   <para>rdfs:label : Part of Day</para>
    ///   <para>rdfs:comment : This class represents the time intervals in which a day can be divided in.</para>
    ///   <a href="http://softeng.polito.it/rsctx#PartOfDay">rsctx:PartOfDay</a>
    /// </summary>
    let PartOfDay = _prefixId.prefix "PartOfDay"
    /// <summary>
    ///   <para>rdfs:label : Partner</para>
    ///   <para>rdfs:comment : The user is with her/his boyfriend/girlfriend or husband/wife.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Partner">rsctx:Partner</a>
    /// </summary>
    let Partner = _prefixId.prefix "Partner"
    /// <summary>
    ///   <para>rdfs:label : Physiological State</para>
    ///   <para>rdfs:comment : The state of the body or bodily functions.
    ///
    /// WARNING The subclasses of PhysiologicalState in GUMO ontology  are represented as datatype properties.</para>
    ///   <a href="http://softeng.polito.it/rsctx#PhysiologicalState">rsctx:PhysiologicalState</a>
    /// </summary>
    let PhysiologicalState = _prefixId.prefix "PhysiologicalState"
    let Pleasant = _prefixId.prefix "Pleasant"
    let Pleasure = _prefixId.prefix "Pleasure"
    /// <summary>
    ///   <para>rdfs:label : Public Place</para>
    ///   <para>rdfs:comment : A public place such as a cinema or a theatre.
    ///
    /// WARNING It is a class and not an individual because the individual can be a specific cinema or theatre (e.g. La Scala theatre in Milan).</para>
    ///   <a href="http://softeng.polito.it/rsctx#PublicPlace">rsctx:PublicPlace</a>
    /// </summary>
    let PublicPlace = _prefixId.prefix "PublicPlace"
    let PublicTransport = _prefixId.prefix "PublicTransport"
    /// <summary>
    ///   <para>rdfs:comment : Purposerdfs:comment : The description of a situation that is desired by an Agent, and usually associated to a plan that describes how to actually achieve it. In the context of this ontology, it indicates the purpose of the item to be recommended. E.g. the user may be interested in receiving recommendation of movies for educating about a specific topic (for instance in the case of a teacher, which wants to show a movie in class) or for having fun (see a movie with some friends in the night).</para>
    ///   <a href="http://softeng.polito.it/rsctx#Purpose">rsctx:Purpose</a>
    /// </summary>
    let Purpose = _prefixId.prefix "Purpose"
    /// <summary>
    ///   <para>rdfs:label : Region</para>
    ///   <para>rdfs:comment : A political or geographical region.
    ///
    /// WARNING dbpedia-owl represents regions too but it refer to broader sense of region which include any area which is possible to distinguish in geography. In this sense any other geographical unit defined in this ontology (such as country, province, etc.) is a region, while we intend only to represent geographical regions or specific administrative area named regions in some countries (e.g. Italy, France, Belgium).</para>
    ///   <a href="http://softeng.polito.it/rsctx#Region">rsctx:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://en.wikipedia.org/wiki/Season^^xsd:string</para>
    ///   <para>rdfs:comment : A season is a division of the year marked by changes in weather.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Season">rsctx:Season</a>
    /// </summary>
    let Season = _prefixId.prefix "Season"
    let Spring = _prefixId.prefix "Spring"
    let Summer = _prefixId.prefix "Summer"
    /// <summary>
    ///   <para>rdfs:label : Symbolic Location</para>
    ///   <para>rdfs:comment : In general, it represents an abstract ideas of where an object is (e.g. next to a mailbox). In the context of the ontology, it can be an anchor point (i.e. a frequently visited location) or a public place or the anchor point of another user.
    ///
    /// WARNING Other kind of symbolic location such as bankomat, mailbox, or a train approaching Dublin are not considered.</para>
    ///   <a href="http://softeng.polito.it/rsctx#SymbolicLocation">rsctx:SymbolicLocation</a>
    /// </summary>
    let SymbolicLocation = _prefixId.prefix "SymbolicLocation"
    let Taxi = _prefixId.prefix "Taxi"
    /// <summary>
    ///   <para>rdfs:label : Temperature</para>
    ///   <para>rdfs:comment : It represents the exterior temperature by means of a symbolic value, such as warm or cool.
    ///
    /// TODO Map the individuals with temperature ranges?</para>
    ///   <a href="http://softeng.polito.it/rsctx#Temperature">rsctx:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>rdfs:label : Time</para>
    ///   <para>rdfs:comment : Time is an instant, i.e. a timestamp. Then it can be characterized by some TimeIntervals which it belongs to, such as winter, Monday and morning.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Time">rsctx:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>rdfs:label : Time Interval</para>
    ///   <para>rdfs:comment : A period of time between two instants.</para>
    ///   <a href="http://softeng.polito.it/rsctx#TimeInterval">rsctx:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    /// <summary>
    ///   <para>rdfs:label : Traffic Level</para>
    ///   <para>rdfs:comment : This class represents the current traffic situation.</para>
    ///   <a href="http://softeng.polito.it/rsctx#TrafficLevel">rsctx:TrafficLevel</a>
    /// </summary>
    let TrafficLevel = _prefixId.prefix "TrafficLevel"
    /// <summary>
    ///   <para>rdfs:label : Transportation Mean</para>
    ///   <para>rdfs:comment : It represents the transportation mean the user is using or is going to use (e.g. to reach a restaurant or to visit a city), such as car, bike, public transport or none (he is going on foot).</para>
    ///   <a href="http://softeng.polito.it/rsctx#TransportationMean">rsctx:TransportationMean</a>
    /// </summary>
    let TransportationMean = _prefixId.prefix "TransportationMean"
    /// <summary>
    ///   <para>rdfs:label : Tropical season</para>
    ///   <para>rdfs:comment : Season which occur in hot regions. It includes the rainy (or wet, or monsoon) season and the dry season, In some tropical areas, a cool or mild season is also present.
    ///
    /// WARNING This class has just the purpose to organize the seasons. It SHOULD NOT have instances.</para>
    ///   <a href="http://softeng.polito.it/rsctx#TropicalSeason">rsctx:TropicalSeason</a>
    /// </summary>
    let TropicalSeason = _prefixId.prefix "TropicalSeason"
    let VeryCold = _prefixId.prefix "VeryCold"
    let VeryWarm = _prefixId.prefix "VeryWarm"
    let Warm = _prefixId.prefix "Warm"
    /// <summary>
    ///   <para>rdfs:label : Weekend</para>
    ///   <para>rdfs:comment : This class indicates the days which made up the weekend (typically not working).</para>
    ///   <a href="http://softeng.polito.it/rsctx#WeekEnd">rsctx:WeekEnd</a>
    /// </summary>
    let WeekEnd = _prefixId.prefix "WeekEnd"
    /// <summary>
    ///   <para>rdfs:label : Weekday</para>
    ///   <para>rdfs:comment : This class includes the day of the week which are typically working (if is not holiday). Days from Monday to Friday are weekdays.</para>
    ///   <a href="http://softeng.polito.it/rsctx#Weekday">rsctx:Weekday</a>
    /// </summary>
    let Weekday = _prefixId.prefix "Weekday"
    let WetSeason = _prefixId.prefix "WetSeason"
    let Winter = _prefixId.prefix "Winter"
    let WorkPlace = _prefixId.prefix "WorkPlace"
    /// <summary>
    ///   <para>rdfs:label : ZIP coderdfs:label : postal code</para>
    ///   <para>rdfs:comment : It indicates the ZIP code of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#ZIPCode">rsctx:ZIPCode</a>
    /// </summary>
    let ZIPCode = _prefixId.prefix "ZIPCode"
    /// <summary>
    ///   <para>rdfs:label : activity</para>
    ///   <para>rdfs:comment : This property indicates the activity of a user.
    ///
    /// WARNING Useful only if need domain and ranges, otherwise it is enough to use ao:activity.</para>
    ///   <a href="http://softeng.polito.it/rsctx#activity">rsctx:activity</a>
    /// </summary>
    let activity = _prefixId.prefix "activity"
    /// <summary>
    ///   <para>rdfs:label : address</para>
    ///   <para>rdfs:comment : It indicates the address of a location</para>
    ///   <a href="http://softeng.polito.it/rsctx#address">rsctx:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    let anger = _prefixId.prefix "anger"
    let anxiety = _prefixId.prefix "anxiety"
    /// <summary>
    ///   <para>rdfs:label : available time</para>
    ///   <para>rdfs:comment : It indicates how much time the user can spend (e.g. to visit a city or to go for lunch in lunch brek at work).</para>
    ///   <a href="http://softeng.polito.it/rsctx#availableTime">rsctx:availableTime</a>
    /// </summary>
    let availableTime = _prefixId.prefix "availableTime"
    /// <summary>
    ///   <para>rdfs:label : blood preassure</para>
    ///   <para>rdfs:comment : This property indicates the blood pressure (in mmHg) of a PhysiologicalState</para>
    ///   <a href="http://softeng.polito.it/rsctx#bloodPressure">rsctx:bloodPressure</a>
    /// </summary>
    let bloodPressure = _prefixId.prefix "bloodPressure"
    /// <summary>
    ///   <para>rdfs:label : body temperature</para>
    ///   <para>rdfs:comment : This property indicates the temperature (in degree Celsius) of a PhysiologicalState.</para>
    ///   <a href="http://softeng.polito.it/rsctx#bodyTemperature">rsctx:bodyTemperature</a>
    /// </summary>
    let bodyTemperature = _prefixId.prefix "bodyTemperature"
    let boredom = _prefixId.prefix "boredom"
    /// <summary>
    ///   <para>rdfs:label : budget</para>
    ///   <para>rdfs:comment : It indicates how much the user want or can spend (for example for a travel or a purchase or to go for a dinner in a restaurant).</para>
    ///   <a href="http://softeng.polito.it/rsctx#budget">rsctx:budget</a>
    /// </summary>
    let budget = _prefixId.prefix "budget"
    /// <summary>
    ///   <para>rdfs:label : building</para>
    ///   <para>rdfs:comment : It indicates the building associated to a location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#bulding">rsctx:bulding</a>
    /// </summary>
    let bulding = _prefixId.prefix "bulding"
    /// <summary>
    ///   <para>rdfs:label : city</para>
    ///   <para>rdfs:comment : It indicates the city of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#city">rsctx:city</a>
    /// </summary>
    let city = _prefixId.prefix "city"
    let cognitiveLoad = _prefixId.prefix "cognitiveLoad"
    /// <summary>
    ///   <para>rdfs:label : companion</para>
    ///   <para>rdfs:comment : This property indicates who is the current companion of the user, e.g. a friend a family member or a colleague.</para>
    ///   <a href="http://softeng.polito.it/rsctx#companion">rsctx:companion</a>
    /// </summary>
    let companion = _prefixId.prefix "companion"
    let confusion = _prefixId.prefix "confusion"
    /// <summary>
    ///   <para>rdfs:label : country</para>
    ///   <para>rdfs:comment : It indicates the country of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#country">rsctx:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : county</para>
    ///   <para>rdfs:comment : It indicates the county of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#county">rsctx:county</a>
    /// </summary>
    let county = _prefixId.prefix "county"
    /// <summary>
    ///   <para>rdfs:label : day of week</para>
    ///   <para>rdfs:comment : This property indicates the day of week of a Time.</para>
    ///   <a href="http://softeng.polito.it/rsctx#dayOfWeek">rsctx:dayOfWeek</a>
    /// </summary>
    let dayOfWeek = _prefixId.prefix "dayOfWeek"
    let depression = _prefixId.prefix "depression"
    /// <summary>
    ///   <para>rdfs:label : desk</para>
    ///   <para>rdfs:comment : It indicates the Desk of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#desk">rsctx:desk</a>
    /// </summary>
    let desk = _prefixId.prefix "desk"
    /// <summary>
    ///   <para>rdfs:label : device</para>
    ///   <para>rdfs:comment : The property associates a Device to a Context.
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:device should be used.</para>
    ///   <a href="http://softeng.polito.it/rsctx#device">rsctx:device</a>
    /// </summary>
    let device = _prefixId.prefix "device"
    let disgust = _prefixId.prefix "disgust"
    /// <summary>
    ///   <para>rdfs:label : district</para>
    ///   <para>rdfs:comment : It indicates the District of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#district">rsctx:district</a>
    /// </summary>
    let district = _prefixId.prefix "district"
    let dread = _prefixId.prefix "dread"
    /// <summary>
    ///   <para>rdfs:label : environment</para>
    ///   <para>rdfs:comment : The property associates an Environment to a Context.
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:device should be used.</para>
    ///   <a href="http://softeng.polito.it/rsctx#environment">rsctx:environment</a>
    /// </summary>
    let environment = _prefixId.prefix "environment"
    let exahust = _prefixId.prefix "exahust"
    let excitement = _prefixId.prefix "excitement"
    /// <summary>
    ///   <para>rdfs:label : exterior temperature</para>
    ///   <para>rdfs:comment : It indicates the exterior temperature in degree Celsius.</para>
    ///   <a href="http://softeng.polito.it/rsctx#exteriorTemperature">rsctx:exteriorTemperature</a>
    /// </summary>
    let exteriorTemperature = _prefixId.prefix "exteriorTemperature"
    /// <summary>
    ///   <para>rdfs:label : fatigue</para>
    ///   <para>rdfs:comment : This property indicates the fatigue of a PhysiologicalState. It is represented as string because there are scales such as Samm-Perelli seven point scale and karolinska sleepiness scale with some numbers associated to a string. </para>
    ///   <a href="http://softeng.polito.it/rsctx#fatigue">rsctx:fatigue</a>
    /// </summary>
    let fatigue = _prefixId.prefix "fatigue"
    let fear = _prefixId.prefix "fear"
    /// <summary>
    ///   <para>rdfs:label : federated state</para>
    ///   <para>rdfs:comment : It indicates the FederatedState of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#federatedState">rsctx:federatedState</a>
    /// </summary>
    let federatedState = _prefixId.prefix "federatedState"

    /// <summary>
    ///   <para>rdfs:label : fifth level administrative division</para>
    ///   <para>rdfs:comment : It indicates the Fifth Level Administrative DIvision of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#fifthLevelAdministrativeDivision">rsctx:fifthLevelAdministrativeDivision</a>
    /// </summary>
    let fifthLevelAdministrativeDivision =
        _prefixId.prefix "fifthLevelAdministrativeDivision"

    /// <summary>
    ///   <para>rdfs:label : first level administrative division</para>
    ///   <para>rdfs:comment : It indicates the first level administrative division of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#firstLevelAdministrativeDivision">rsctx:firstLevelAdministrativeDivision</a>
    /// </summary>
    let firstLevelAdministrativeDivision =
        _prefixId.prefix "firstLevelAdministrativeDivision"

    /// <summary>
    ///   <para>rdfs:label : floor</para>
    ///   <para>rdfs:comment : It indicates the Floor of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#floor">rsctx:floor</a>
    /// </summary>
    let floor = _prefixId.prefix "floor"
    /// <summary>
    ///   <para>rdfs:label : floor section</para>
    ///   <para>rdfs:comment : It indicates the FloorSection of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#floorSection">rsctx:floorSection</a>
    /// </summary>
    let floorSection = _prefixId.prefix "floorSection"

    /// <summary>
    ///   <para>rdfs:label : fourth level administrative division</para>
    ///   <para>rdfs:comment : It indicates the fourth level administrative division of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#fourthLevelAdministrativeDivision">rsctx:fourthLevelAdministrativeDivision</a>
    /// </summary>
    let fourthLevelAdministrativeDivision =
        _prefixId.prefix "fourthLevelAdministrativeDivision"

    let good = _prefixId.prefix "good"
    let great = _prefixId.prefix "great"
    let happiness = _prefixId.prefix "happiness"
    /// <summary>
    ///   <para>rdfs:label : has emotional state</para>
    ///   <para>rdfs:comment : This property indicates the emotional state of a user.</para>
    ///   <a href="http://softeng.polito.it/rsctx#hasEmotionalState">rsctx:hasEmotionalState</a>
    /// </summary>
    let hasEmotionalState = _prefixId.prefix "hasEmotionalState"
    /// <summary>
    ///   <para>rdfs:label : has fitness</para>
    ///   <para>rdfs:comment : This property indicates the fitness of a user.</para>
    ///   <a href="http://softeng.polito.it/rsctx#hasFitness">rsctx:hasFitness</a>
    /// </summary>
    let hasFitness = _prefixId.prefix "hasFitness"
    /// <summary>
    ///   <para>rdfs:label : has mental state</para>
    ///   <para>rdfs:comment : This property indicates the mental state of a user.</para>
    ///   <a href="http://softeng.polito.it/rsctx#hasMentalState">rsctx:hasMentalState</a>
    /// </summary>
    let hasMentalState = _prefixId.prefix "hasMentalState"
    /// <summary>
    ///   <para>rdfs:label : has motion</para>
    ///   <para>rdfs:comment : This property indicates the motion of a user.
    ///
    /// WARNING Useful only if need domain and ranges, otherwise it is enough to use ao:activity.</para>
    ///   <a href="http://softeng.polito.it/rsctx#hasMotion">rsctx:hasMotion</a>
    /// </summary>
    let hasMotion = _prefixId.prefix "hasMotion"
    /// <summary>
    ///   <para>rdfs:label : has physiological state</para>
    ///   <para>rdfs:comment : This property indicates the phsysiological state of a user.</para>
    ///   <a href="http://softeng.polito.it/rsctx#hasPhysiologicalState">rsctx:hasPhysiologicalState</a>
    /// </summary>
    let hasPhysiologicalState = _prefixId.prefix "hasPhysiologicalState"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://dbpedia.org/ontology/purpose^^xsd:stringrdfs:seeAlso : https://schema.org/purpose^^xsd:string</para>
    ///   <para>rdfs:label : has purpose</para>
    ///   <para>rdfs:comment : This property indicates the purpose of a user.
    ///
    /// WARNING schema:purpose has different domain (three possible classes) and different ranges (2 possible classes). Although one range is Thing, which would enable to consider this porperty as subproperty of schema.org we should add a class in domain, while for the scopes of this ontology only Environment as domain is proper. </para>
    ///   <a href="http://softeng.polito.it/rsctx#hasPurpose">rsctx:hasPurpose</a>
    /// </summary>
    let hasPurpose = _prefixId.prefix "hasPurpose"
    /// <summary>
    ///   <para>rdfs:label : has temperature</para>
    ///   <para>rdfs:comment : This property indicates a symbolic value for the temperature (such as warm, cold, etc.).
    ///
    /// WARNING Although there was already a temperature class and a temperature property (hw:hasExteriorTemperature) in the WeatherOntology, temperature class has been redefined with values more general and not referred to the house (such as below room temperature). Thus this property has the redefined temperature class as a range.</para>
    ///   <a href="http://softeng.polito.it/rsctx#hasTemperature">rsctx:hasTemperature</a>
    /// </summary>
    let hasTemperature = _prefixId.prefix "hasTemperature"
    let hate = _prefixId.prefix "hate"
    /// <summary>
    ///   <para>rdfs:label : heartbeat</para>
    ///   <para>rdfs:comment : This property indicates the heartbeat of a PhysiologicalState</para>
    ///   <a href="http://softeng.polito.it/rsctx#heartbeat">rsctx:heartbeat</a>
    /// </summary>
    let heartbeat = _prefixId.prefix "heartbeat"
    /// <summary>
    ///   <para>rdfs:label : is holiday</para>
    ///   <para>rdfs:comment : This property indicates if a Time is holiday or a working day.</para>
    ///   <a href="http://softeng.polito.it/rsctx#holiday">rsctx:holiday</a>
    /// </summary>
    let holiday = _prefixId.prefix "holiday"
    let hope = _prefixId.prefix "hope"
    /// <summary>
    ///   <para>rdfs:label : hour</para>
    ///   <para>rdfs:comment : This property indicates the hour which a Time is included.</para>
    ///   <a href="http://softeng.polito.it/rsctx#hour">rsctx:hour</a>
    /// </summary>
    let hour = _prefixId.prefix "hour"
    let hypnosis = _prefixId.prefix "hypnosis"
    let ill = _prefixId.prefix "ill"
    let inFit = _prefixId.prefix "inFit"
    let injured = _prefixId.prefix "injured"
    /// <summary>
    ///   <para>rdfs:label : injury</para>
    ///   <para>rdfs:comment : This property indicates the injury of a PhysiologicalState</para>
    ///   <a href="http://softeng.polito.it/rsctx#injury">rsctx:injury</a>
    /// </summary>
    let injury = _prefixId.prefix "injury"
    let irritation = _prefixId.prefix "irritation"
    let joy = _prefixId.prefix "joy"
    /// <summary>
    ///   <para>rdfs:label : light level</para>
    ///   <para>rdfs:comment : It indicates a LightLevel.</para>
    ///   <a href="http://softeng.polito.it/rsctx#lightLevel">rsctx:lightLevel</a>
    /// </summary>
    let lightLevel = _prefixId.prefix "lightLevel"
    /// <summary>
    ///   <para>rdfs:label : lighting</para>
    ///   <para>rdfs:comment : It indicates the light level in lux.</para>
    ///   <a href="http://softeng.polito.it/rsctx#lighting">rsctx:lighting</a>
    /// </summary>
    let lighting = _prefixId.prefix "lighting"
    let love = _prefixId.prefix "love"
    /// <summary>
    ///   <para>rdfs:label : municipality</para>
    ///   <para>rdfs:comment : It indicates the Municipality of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#municipality">rsctx:municipality</a>
    /// </summary>
    let municipality = _prefixId.prefix "municipality"
    /// <summary>
    ///   <para>rdfs:label : neighborhood</para>
    ///   <para>rdfs:comment : It indicates the Neighborhood of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#neighborhood">rsctx:neighborhood</a>
    /// </summary>
    let neighborhood = _prefixId.prefix "neighborhood"
    let nervousness = _prefixId.prefix "nervousness"
    /// <summary>
    ///   <para>rdfs:label : noise</para>
    ///   <para>rdfs:comment : It indicates the noise in decibel.</para>
    ///   <a href="http://softeng.polito.it/rsctx#noise">rsctx:noise</a>
    /// </summary>
    let noise = _prefixId.prefix "noise"
    /// <summary>
    ///   <para>rdfs:label : noise level</para>
    ///   <para>rdfs:comment : It indicates a NoiseLevel</para>
    ///   <a href="http://softeng.polito.it/rsctx#noiseLevel">rsctx:noiseLevel</a>
    /// </summary>
    let noiseLevel = _prefixId.prefix "noiseLevel"
    /// <summary>
    ///   <para>rdfs:label : nourishment</para>
    ///   <para>rdfs:comment : This property indicates the nourishment (in BMI) of a PhysiologicalState.</para>
    ///   <a href="http://softeng.polito.it/rsctx#nourishment">rsctx:nourishment</a>
    /// </summary>
    let nourishment = _prefixId.prefix "nourishment"
    /// <summary>
    ///   <para>rdfs:comment : It indicates the Parish of a Location.rdfs:comment : parish</para>
    ///   <a href="http://softeng.polito.it/rsctx#parish">rsctx:parish</a>
    /// </summary>
    let parish = _prefixId.prefix "parish"
    /// <summary>
    ///   <para>rdfs:label : part of day</para>
    ///   <para>rdfs:comment : This property indicates part of the day in which a Time is included in.</para>
    ///   <a href="http://softeng.polito.it/rsctx#partOfDay">rsctx:partOfDay</a>
    /// </summary>
    let partOfDay = _prefixId.prefix "partOfDay"
    /// <summary>
    ///   <para>rdfs:label : perspiration</para>
    ///   <para>rdfs:comment : This property indicates the perspiration (in liters per hours) of a PhysiologicalState.</para>
    ///   <a href="http://softeng.polito.it/rsctx#perspiration">rsctx:perspiration</a>
    /// </summary>
    let perspiration = _prefixId.prefix "perspiration"
    /// <summary>
    ///   <para>rdfs:label : poi^^xsd:string</para>
    ///   <para>rdfs:comment : The property associates a POI to a prissma:Environment
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:poi should be used.</para>
    ///   <a href="http://softeng.polito.it/rsctx#poi">rsctx:poi</a>
    /// </summary>
    let poi = _prefixId.prefix "poi"
    let pride = _prefixId.prefix "pride"
    /// <summary>
    ///   <para>rdfs:comment : It indicates the Proince of a Location.rdfs:comment : province</para>
    ///   <a href="http://softeng.polito.it/rsctx#province">rsctx:province</a>
    /// </summary>
    let province = _prefixId.prefix "province"
    let psychopathy = _prefixId.prefix "psychopathy"
    /// <summary>
    ///   <para>rdfs:label : pupil dilation</para>
    ///   <para>rdfs:comment : This property indicates the pupil dilation (in mm) of a PhysiologicalState.</para>
    ///   <a href="http://softeng.polito.it/rsctx#pupilsDilation">rsctx:pupilsDilation</a>
    /// </summary>
    let pupilsDilation = _prefixId.prefix "pupilsDilation"
    /// <summary>
    ///   <para>rdfs:label : region</para>
    ///   <para>rdfs:comment : It indicates the Region of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#region">rsctx:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    let relief = _prefixId.prefix "relief"
    /// <summary>
    ///   <para>rdfs:label : respiration</para>
    ///   <para>rdfs:comment : This property indicates the respiration of a PhysiologicalState (in breaths per minute).</para>
    ///   <a href="http://softeng.polito.it/rsctx#respiration">rsctx:respiration</a>
    /// </summary>
    let respiration = _prefixId.prefix "respiration"
    /// <summary>
    ///   <para>rdfs:label : room</para>
    ///   <para>rdfs:comment : It indicates the Room of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#room">rsctx:room</a>
    /// </summary>
    let room = _prefixId.prefix "room"
    let sadness = _prefixId.prefix "sadness"
    let satisfaction = _prefixId.prefix "satisfaction"
    /// <summary>
    ///   <para>rdfs:label : season</para>
    ///   <para>rdfs:comment : It indicates the season in which a Time is included in.</para>
    ///   <a href="http://softeng.polito.it/rsctx#season">rsctx:season</a>
    /// </summary>
    let season = _prefixId.prefix "season"

    /// <summary>
    ///   <para>rdfs:label : second level administrative division</para>
    ///   <para>rdfs:comment : It indicates the second level administrative division of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#secondLevelAdministrativeDivision">rsctx:secondLevelAdministrativeDivision</a>
    /// </summary>
    let secondLevelAdministrativeDivision =
        _prefixId.prefix "secondLevelAdministrativeDivision"

    let shame = _prefixId.prefix "shame"
    /// <summary>
    ///   <para>rdfs:label : site</para>
    ///   <para>rdfs:comment : It indicates the Site of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#site">rsctx:site</a>
    /// </summary>
    let site = _prefixId.prefix "site"
    let sleepy = _prefixId.prefix "sleepy"
    /// <summary>
    ///   <para>rdfs:label : street</para>
    ///   <para>rdfs:comment : It indicates the Street of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#street">rsctx:street</a>
    /// </summary>
    let street = _prefixId.prefix "street"
    /// <summary>
    ///   <para>rdfs:label : symbolic location</para>
    ///   <para>rdfs:comment : It indicates to which symbolic location that POI corresponds to (if any), such as the home or the workplace of the user or a public place (e.g. a cinema).</para>
    ///   <a href="http://softeng.polito.it/rsctx#symbolicLocation">rsctx:symbolicLocation</a>
    /// </summary>
    let symbolicLocation = _prefixId.prefix "symbolicLocation"

    /// <summary>
    ///   <para>rdfs:label : third level administrative division</para>
    ///   <para>rdfs:comment : It indicates the third level administrative division of a Location.</para>
    ///   <a href="http://softeng.polito.it/rsctx#thirdLevelAdministrativeDivision">rsctx:thirdLevelAdministrativeDivision</a>
    /// </summary>
    let thirdLevelAdministrativeDivision =
        _prefixId.prefix "thirdLevelAdministrativeDivision"

    /// <summary>
    ///   <para>rdfs:label : time</para>
    ///   <para>rdfs:comment : It indicates the time associated to the Environment.</para>
    ///   <a href="http://softeng.polito.it/rsctx#time">rsctx:time</a>
    /// </summary>
    let time = _prefixId.prefix "time"
    let timePressure = _prefixId.prefix "timePressure"
    let tired = _prefixId.prefix "tired"
    /// <summary>
    ///   <para>rdfs:label : traffic level</para>
    ///   <para>rdfs:comment : It indicates a TrafficLevel</para>
    ///   <a href="http://softeng.polito.it/rsctx#trafficLevel">rsctx:trafficLevel</a>
    /// </summary>
    let trafficLevel = _prefixId.prefix "trafficLevel"
    let trance = _prefixId.prefix "trance"
    /// <summary>
    ///   <para>rdfs:label : transportation mean</para>
    ///   <para>rdfs:comment : It indicates which TransportationMean the user is using or is going to use.</para>
    ///   <a href="http://softeng.polito.it/rsctx#transportationMean">rsctx:transportationMean</a>
    /// </summary>
    let transportationMean = _prefixId.prefix "transportationMean"
    let trauma = _prefixId.prefix "trauma"
    /// <summary>
    ///   <para>rdfs:label : user</para>
    ///   <para>rdfs:comment : The property associates a User to a Context.
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:user should be used.</para>
    ///   <a href="http://softeng.polito.it/rsctx#user">rsctx:user</a>
    /// </summary>
    let user = _prefixId.prefix "user"
    let weak = _prefixId.prefix "weak"
    /// <summary>
    ///   <para>rdfs:label : weather</para>
    ///   <para>rdfs:comment : It indicates the weather associated to the current context.</para>
    ///   <a href="http://softeng.polito.it/rsctx#weather">rsctx:weather</a>
    /// </summary>
    let weather = _prefixId.prefix "weather"
    let worry = _prefixId.prefix "worry"
