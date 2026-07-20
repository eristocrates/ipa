namespace http.softeng.polito.it.rsctx.hash

open DoxAletheia

module rsctx =
    let _namespace_name = "http://softeng.polito.it/rsctx#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Dominance"></see>
    /// </summary>
    let Dominance = _prefix "Dominance"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Pleasure"></see>
    /// </summary>
    let Pleasure = _prefix "Pleasure"
    /// <summary>
    /// This class indicates the day of the week (such as Monday, Tuesday, etc.).
    /// <see href="http://softeng.polito.it/rsctx#DayOfWeek"></see></summary>
    let DayOfWeek = _prefix "DayOfWeek"
    /// <summary>
    /// This class represents the time intervals in which a day can be divided in.
    /// <see href="http://softeng.polito.it/rsctx#PartOfDay"></see></summary>
    let PartOfDay = _prefix "PartOfDay"
    /// <summary>
    /// A season is a division of the year marked by changes in weather.
    /// <see href="http://softeng.polito.it/rsctx#Season"></see></summary>
    let Season = _prefix "Season"
    /// <summary>
    /// The user is with his boss. This may be a more formal situation that being with just the colleagues.
    /// <see href="http://softeng.polito.it/rsctx#Boss"></see></summary>
    let Boss = _prefix "Boss"
    /// <summary>
    /// The user is with a business partner, e.g. a business partner can be a customer or a member of another organizations with which the user is collaborating or a supplier.
    /// <see href="http://softeng.polito.it/rsctx#BusinessPartner"></see></summary>
    let BusinessPartner = _prefix "BusinessPartner"
    /// <summary>
    /// The user is with children, not necessarily his family: for example may be a teacher or a baby sitter.
    /// <see href="http://softeng.polito.it/rsctx#Child"></see></summary>
    let Child = _prefix "Child"
    /// <summary>
    /// The user is with one or more colleagues.
    /// <see href="http://softeng.polito.it/rsctx#Colleague"></see></summary>
    let Colleague = _prefix "Colleague"
    /// <summary>
    /// The user is with his family, not necessarely with children. For instance, this may includes being just with the sister or brother or the parents.
    /// <see href="http://softeng.polito.it/rsctx#Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    /// The user is with one or more friends.
    /// <see href="http://softeng.polito.it/rsctx#Friend"></see></summary>
    let Friend = _prefix "Friend"
    /// <summary>
    /// The user is alone.
    /// <see href="http://softeng.polito.it/rsctx#Nobody"></see></summary>
    let Nobody = _prefix "Nobody"
    /// <summary>
    /// The user is with her/his boyfriend/girlfriend or husband/wife.
    /// <see href="http://softeng.polito.it/rsctx#Partner"></see></summary>
    let Partner = _prefix "Partner"
    /// <summary>
    /// It is a key  location,  such  as  our  home  and  work  place,  that  we
    /// consider as "anchor" in our understanding of the geographic environment
    /// where we live. In general, an anchor-point is a frequently visited location or a location where one spends a lot of time.
    /// <see href="http://softeng.polito.it/rsctx#AnchorPoint"></see></summary>
    let AnchorPoint = _prefix "AnchorPoint"
    /// <summary>
    /// The home of a companion of the user, such as a freind's home or a colleague's home.
    ///
    /// WARNING This piece of information can be hard to obtained (unless explicitly asked to the user). It is a class and not an individual because the individual is the specific house (e.g. my friend Bob's house).
    /// <see href="http://softeng.polito.it/rsctx#CompanionHome"></see></summary>
    let CompanionHome = _prefix "CompanionHome"
    /// <summary>
    /// A public place such as a cinema or a theatre.
    ///
    /// WARNING It is a class and not an individual because the individual can be a specific cinema or theatre (e.g. La Scala theatre in Milan).
    /// <see href="http://softeng.polito.it/rsctx#PublicPlace"></see></summary>
    let PublicPlace = _prefix "PublicPlace"
    /// <summary>
    /// The state of a person's emotions (especially with regard to pleasure or dejection).
    ///
    /// WARNING The possible values are represented as individuals while in the GUMO ontology are classes.
    /// <see href="http://softeng.polito.it/rsctx#EmotionalState"></see></summary>
    let EmotionalState = _prefix "EmotionalState"
    /// <summary>
    /// It is a value partition which represents the health of the body, it can be seen as a summary of physiological state, since it is possible to map fitness values with physiological indicators ranges (e.g. ill if temperature greater than a certain threshold), although this is up to the designer which is using the ontology.
    /// <see href="http://softeng.polito.it/rsctx#Fitness"></see></summary>
    let Fitness = _prefix "Fitness"
    /// <summary>
    /// A mental condition in which the qualities of a state are relatively constant even though the state itself may be dynamic, such as depression, cognitive load, nervousness.
    ///
    /// WARNING The possible values are represented as individuals while in the GUMO ontology are classes.
    /// <see href="http://softeng.polito.it/rsctx#MentalState"></see></summary>
    let MentalState = _prefix "MentalState"
    /// <summary>
    /// The state of the body or bodily functions.
    ///
    /// WARNING The subclasses of PhysiologicalState in GUMO ontology  are represented as datatype properties.
    /// <see href="http://softeng.polito.it/rsctx#PhysiologicalState"></see></summary>
    let PhysiologicalState = _prefix "PhysiologicalState"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#00"></see>
    /// </summary>
    let _00 = _prefix "00"
    /// <summary>
    /// The hours of a day.
    /// <see href="http://softeng.polito.it/rsctx#Hour"></see></summary>
    let Hour = _prefix "Hour"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#01"></see>
    /// </summary>
    let _01 = _prefix "01"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#02"></see>
    /// </summary>
    let _02 = _prefix "02"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#03"></see>
    /// </summary>
    let _03 = _prefix "03"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#04"></see>
    /// </summary>
    let _04 = _prefix "04"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#05"></see>
    /// </summary>
    let _05 = _prefix "05"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#06"></see>
    /// </summary>
    let _06 = _prefix "06"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#07"></see>
    /// </summary>
    let _07 = _prefix "07"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#08"></see>
    /// </summary>
    let _08 = _prefix "08"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#09"></see>
    /// </summary>
    let _09 = _prefix "09"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#10"></see>
    /// </summary>
    let _10 = _prefix "10"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#11"></see>
    /// </summary>
    let _11 = _prefix "11"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#12"></see>
    /// </summary>
    let _12 = _prefix "12"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#13"></see>
    /// </summary>
    let _13 = _prefix "13"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#14"></see>
    /// </summary>
    let _14 = _prefix "14"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#15"></see>
    /// </summary>
    let _15 = _prefix "15"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#16"></see>
    /// </summary>
    let _16 = _prefix "16"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#17"></see>
    /// </summary>
    let _17 = _prefix "17"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#18"></see>
    /// </summary>
    let _18 = _prefix "18"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#19"></see>
    /// </summary>
    let _19 = _prefix "19"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#20"></see>
    /// </summary>
    let _20 = _prefix "20"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#21"></see>
    /// </summary>
    let _21 = _prefix "21"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#22"></see>
    /// </summary>
    let _22 = _prefix "22"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#23"></see>
    /// </summary>
    let _23 = _prefix "23"
    /// <summary>
    /// A  specific type of subnational entity in a number of countries, e.g. Belgium, Italy, France.
    /// <see href="http://softeng.polito.it/rsctx#AdministrativeRegion"></see></summary>
    let AdministrativeRegion = _prefix "AdministrativeRegion"
    /// <summary>
    /// A political or geographical region.
    ///
    /// WARNING dbpedia-owl represents regions too but it refer to broader sense of region which include any area which is possible to distinguish in geography. In this sense any other geographical unit defined in this ontology (such as country, province, etc.) is a region, while we intend only to represent geographical regions or specific administrative area named regions in some countries (e.g. Italy, France, Belgium).
    /// <see href="http://softeng.polito.it/rsctx#Region"></see></summary>
    let Region = _prefix "Region"
    /// <summary>
    /// The time of the day between noon and evening. The mapping with respect the hours is possible but not defined because it may vary with the location and the habits.
    /// <see href="http://softeng.polito.it/rsctx#Afternoon"></see></summary>
    let Afternoon = _prefix "Afternoon"
    /// <summary>
    /// In general, it represents an abstract ideas of where an object is (e.g. next to a mailbox). In the context of the ontology, it can be an anchor point (i.e. a frequently visited location) or a public place or the anchor point of another user.
    ///
    /// WARNING Other kind of symbolic location such as bankomat, mailbox, or a train approaching Dublin are not considered.
    /// <see href="http://softeng.polito.it/rsctx#SymbolicLocation"></see></summary>
    let SymbolicLocation = _prefix "SymbolicLocation"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#WorkPlace"></see>
    /// </summary>
    let WorkPlace = _prefix "WorkPlace"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Home"></see>
    /// </summary>
    let Home = _prefix "Home"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Bike"></see>
    /// </summary>
    let Bike = _prefix "Bike"
    /// <summary>
    /// It represents the transportation mean the user is using or is going to use (e.g. to reach a restaurant or to visit a city), such as car, bike, public transport or none (he is going on foot).
    /// <see href="http://softeng.polito.it/rsctx#TransportationMean"></see></summary>
    let TransportationMean = _prefix "TransportationMean"
    /// <summary>
    /// Companion class indicates which kind of company the user as at the moment. For example, it may be with family, friends or colleagues.
    ///
    /// WARNING Its subclasses not as individual, because the individual could be a person (e.g. Bob or Alice), and it is an istance also of one of companion sublasses to indicate which in kind of companion the individual is for the user in the current context (e.g. is family or colleagues or friend).
    /// <see href="http://softeng.polito.it/rsctx#Companion"></see></summary>
    let Companion = _prefix "Companion"
    /// <summary>
    /// Season which is generally recognized in temperate and subpolar regions, include summer, spring, winter and fall (or autumn).
    ///
    /// WARNING This class has just the purpose to organize the seasons. It SHOULD NOT have instances.
    /// <see href="http://softeng.polito.it/rsctx#CalendarSeason"></see></summary>
    let CalendarSeason = _prefix "CalendarSeason"
    /// <summary>
    /// Season which occur in hot regions. It includes the rainy (or wet, or monsoon) season and the dry season, In some tropical areas, a cool or mild season is also present.
    ///
    /// WARNING This class has just the purpose to organize the seasons. It SHOULD NOT have instances.
    /// <see href="http://softeng.polito.it/rsctx#TropicalSeason"></see></summary>
    let TropicalSeason = _prefix "TropicalSeason"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Spring"></see>
    /// </summary>
    let Spring = _prefix "Spring"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Fall"></see>
    /// </summary>
    let Fall = _prefix "Fall"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Summer"></see>
    /// </summary>
    let Summer = _prefix "Summer"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Winter"></see>
    /// </summary>
    let Winter = _prefix "Winter"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Calm"></see>
    /// </summary>
    let Calm = _prefix "Calm"
    /// <summary>
    /// This class represents the current traffic situation.
    /// <see href="http://softeng.polito.it/rsctx#TrafficLevel"></see></summary>
    let TrafficLevel = _prefix "TrafficLevel"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Car"></see>
    /// </summary>
    let Car = _prefix "Car"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Chaotic"></see>
    /// </summary>
    let Chaotic = _prefix "Chaotic"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Cold"></see>
    /// </summary>
    let Cold = _prefix "Cold"
    /// <summary>
    /// It represents the exterior temperature by means of a symbolic value, such as warm or cool.
    ///
    /// TODO Map the individuals with temperature ranges?
    /// <see href="http://softeng.polito.it/rsctx#Temperature"></see></summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Cool"></see>
    /// </summary>
    let Cool = _prefix "Cool"
    /// <summary>
    /// A period of time between two instants.
    /// <see href="http://softeng.polito.it/rsctx#TimeInterval"></see></summary>
    let TimeInterval = _prefix "TimeInterval"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#DrySeason"></see>
    /// </summary>
    let DrySeason = _prefix "DrySeason"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#hope"></see>
    /// </summary>
    let hope = _prefix "hope"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#confusion"></see>
    /// </summary>
    let confusion = _prefix "confusion"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#satisfaction"></see>
    /// </summary>
    let satisfaction = _prefix "satisfaction"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#pride"></see>
    /// </summary>
    let pride = _prefix "pride"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#anxiety"></see>
    /// </summary>
    let anxiety = _prefix "anxiety"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#relief"></see>
    /// </summary>
    let relief = _prefix "relief"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#joy"></see>
    /// </summary>
    let joy = _prefix "joy"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#excitement"></see>
    /// </summary>
    let excitement = _prefix "excitement"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#dread"></see>
    /// </summary>
    let dread = _prefix "dread"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#sadness"></see>
    /// </summary>
    let sadness = _prefix "sadness"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#anger"></see>
    /// </summary>
    let anger = _prefix "anger"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#disgust"></see>
    /// </summary>
    let disgust = _prefix "disgust"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#shame"></see>
    /// </summary>
    let shame = _prefix "shame"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#hate"></see>
    /// </summary>
    let hate = _prefix "hate"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#happiness"></see>
    /// </summary>
    let happiness = _prefix "happiness"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#fear"></see>
    /// </summary>
    let fear = _prefix "fear"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#boredom"></see>
    /// </summary>
    let boredom = _prefix "boredom"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#love"></see>
    /// </summary>
    let love = _prefix "love"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#worry"></see>
    /// </summary>
    let worry = _prefix "worry"
    /// <summary>
    /// The period of time near the end of the day, from the end of afternoon (usually from 6 PM) to nighttime. The mapping with respect the hours is possible but not defined becaus it may vary with the location and the habits.
    /// <see href="http://softeng.polito.it/rsctx#Evening"></see></summary>
    let Evening = _prefix "Evening"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#good"></see>
    /// </summary>
    let good = _prefix "good"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#great"></see>
    /// </summary>
    let great = _prefix "great"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#exahust"></see>
    /// </summary>
    let exahust = _prefix "exahust"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#ill"></see>
    /// </summary>
    let ill = _prefix "ill"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#sleepy"></see>
    /// </summary>
    let sleepy = _prefix "sleepy"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#weak"></see>
    /// </summary>
    let weak = _prefix "weak"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#inFit"></see>
    /// </summary>
    let inFit = _prefix "inFit"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#tired"></see>
    /// </summary>
    let tired = _prefix "tired"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#injured"></see>
    /// </summary>
    let injured = _prefix "injured"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Freezing"></see>
    /// </summary>
    let Freezing = _prefix "Freezing"
    /// <summary>
    /// A physical or historical region. Such as the Iberian peninsula or the Northwest European Atlantic Protestant Region (i.e. the European "source regions" in early American colonization efforts).
    /// <see href="http://softeng.polito.it/rsctx#GeographicalRegion"></see></summary>
    let GeographicalRegion = _prefix "GeographicalRegion"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Hot"></see>
    /// </summary>
    let Hot = _prefix "Hot"
    /// <summary>
    /// This class represent the current level of light. It is intended some symbolic level such as dark, sunlight, etc.
    /// <see href="http://softeng.polito.it/rsctx#LightLevel"></see></summary>
    let LightLevel = _prefix "LightLevel"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#trauma"></see>
    /// </summary>
    let trauma = _prefix "trauma"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#timePressure"></see>
    /// </summary>
    let timePressure = _prefix "timePressure"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#hypnosis"></see>
    /// </summary>
    let hypnosis = _prefix "hypnosis"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#cognitiveLoad"></see>
    /// </summary>
    let cognitiveLoad = _prefix "cognitiveLoad"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#irritation"></see>
    /// </summary>
    let irritation = _prefix "irritation"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#nervousness"></see>
    /// </summary>
    let nervousness = _prefix "nervousness"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#trance"></see>
    /// </summary>
    let trance = _prefix "trance"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#psychopathy"></see>
    /// </summary>
    let psychopathy = _prefix "psychopathy"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#depression"></see>
    /// </summary>
    let depression = _prefix "depression"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Mild"></see>
    /// </summary>
    let Mild = _prefix "Mild"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#MildSeason"></see>
    /// </summary>
    let MildSeason = _prefix "MildSeason"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Moderate"></see>
    /// </summary>
    let Moderate = _prefix "Moderate"
    /// <summary>
    /// The period of time between midnight and noon or, more commonly, the interval between sunrise and noon.
    /// <see href="http://softeng.polito.it/rsctx#Morning"></see></summary>
    let Morning = _prefix "Morning"
    /// <summary>
    /// This class indicates if the user is moving and how, e.g. if he is walking or running.
    /// <see href="http://softeng.polito.it/rsctx#Motion"></see></summary>
    let Motion = _prefix "Motion"
    /// <summary>
    /// The period of time between the sunset and the sunrise when the Sun is below the horizon.The mapping with respect the hours is possible but not defined becaus it may vary with the location and the habits.
    /// <see href="http://softeng.polito.it/rsctx#Night"></see></summary>
    let Night = _prefix "Night"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#NoTrasportationMean"></see>
    /// </summary>
    let NoTrasportationMean = _prefix "NoTrasportationMean"
    /// <summary>
    /// This class represents the current level of noise. It is intended a symbolic level such as very noisy, silent, etc.
    /// <see href="http://softeng.polito.it/rsctx#NoiseLevel"></see></summary>
    let NoiseLevel = _prefix "NoiseLevel"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Pleasant"></see>
    /// </summary>
    let Pleasant = _prefix "Pleasant"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#PublicTransport"></see>
    /// </summary>
    let PublicTransport = _prefix "PublicTransport"
    /// <summary>
    /// Purpose
    /// The description of a situation that is desired by an Agent, and usually associated to a plan that describes how to actually achieve it. In the context of this ontology, it indicates the purpose of the item to be recommended. E.g. the user may be interested in receiving recommendation of movies for educating about a specific topic (for instance in the case of a teacher, which wants to show a movie in class) or for having fun (see a movie with some friends in the night).
    /// <see href="http://softeng.polito.it/rsctx#Purpose"></see></summary>
    let Purpose = _prefix "Purpose"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Taxi"></see>
    /// </summary>
    let Taxi = _prefix "Taxi"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Warm"></see>
    /// </summary>
    let Warm = _prefix "Warm"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#VeryCold"></see>
    /// </summary>
    let VeryCold = _prefix "VeryCold"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#VeryWarm"></see>
    /// </summary>
    let VeryWarm = _prefix "VeryWarm"
    /// <summary>
    /// Time is an instant, i.e. a timestamp. Then it can be characterized by some TimeIntervals which it belongs to, such as winter, Monday and morning.
    /// <see href="http://softeng.polito.it/rsctx#Time"></see></summary>
    let Time = _prefix "Time"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#WetSeason"></see>
    /// </summary>
    let WetSeason = _prefix "WetSeason"
    /// <summary>
    /// This class indicates the days which made up the weekend (typically not working).
    /// <see href="http://softeng.polito.it/rsctx#WeekEnd"></see></summary>
    let WeekEnd = _prefix "WeekEnd"
    /// <summary>
    /// This class includes the day of the week which are typically working (if is not holiday). Days from Monday to Friday are weekdays.
    /// <see href="http://softeng.polito.it/rsctx#Weekday"></see></summary>
    let Weekday = _prefix "Weekday"
    /// <summary>
    /// It indicates the ZIP code of a Location.
    /// <see href="http://softeng.polito.it/rsctx#ZIPCode"></see></summary>
    let ZIPCode = _prefix "ZIPCode"
    /// <summary>
    /// This property indicates the activity of a user.
    ///
    /// WARNING Useful only if need domain and ranges, otherwise it is enough to use ao:activity.
    /// <see href="http://softeng.polito.it/rsctx#activity"></see></summary>
    let activity = _prefix "activity"
    /// <summary>
    /// It indicates the address of a location
    /// <see href="http://softeng.polito.it/rsctx#address"></see></summary>
    let address = _prefix "address"
    /// <summary>
    /// It indicates how much time the user can spend (e.g. to visit a city or to go for lunch in lunch brek at work).
    /// <see href="http://softeng.polito.it/rsctx#availableTime"></see></summary>
    let availableTime = _prefix "availableTime"
    /// <summary>
    /// This property indicates the blood pressure (in mmHg) of a PhysiologicalState
    /// <see href="http://softeng.polito.it/rsctx#bloodPressure"></see></summary>
    let bloodPressure = _prefix "bloodPressure"
    /// <summary>
    /// This property indicates the temperature (in degree Celsius) of a PhysiologicalState.
    /// <see href="http://softeng.polito.it/rsctx#bodyTemperature"></see></summary>
    let bodyTemperature = _prefix "bodyTemperature"
    /// <summary>
    /// It indicates how much the user want or can spend (for example for a travel or a purchase or to go for a dinner in a restaurant).
    /// <see href="http://softeng.polito.it/rsctx#budget"></see></summary>
    let budget = _prefix "budget"
    /// <summary>
    /// It indicates the building associated to a location.
    /// <see href="http://softeng.polito.it/rsctx#bulding"></see></summary>
    let bulding = _prefix "bulding"
    /// <summary>
    /// It indicates the city of a Location.
    /// <see href="http://softeng.polito.it/rsctx#city"></see></summary>
    let city = _prefix "city"
    /// <summary>
    /// This property indicates who is the current companion of the user, e.g. a friend a family member or a colleague.
    /// <see href="http://softeng.polito.it/rsctx#companion"></see></summary>
    let companion = _prefix "companion"
    /// <summary>
    /// It indicates the country of a Location.
    /// <see href="http://softeng.polito.it/rsctx#country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    /// It indicates the county of a Location.
    /// <see href="http://softeng.polito.it/rsctx#county"></see></summary>
    let county = _prefix "county"
    /// <summary>
    /// This property indicates the day of week of a Time.
    /// <see href="http://softeng.polito.it/rsctx#dayOfWeek"></see></summary>
    let dayOfWeek = _prefix "dayOfWeek"
    /// <summary>
    /// It indicates the Desk of a Location.
    /// <see href="http://softeng.polito.it/rsctx#desk"></see></summary>
    let desk = _prefix "desk"
    /// <summary>
    /// The property associates a Device to a Context.
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:device should be used.
    /// <see href="http://softeng.polito.it/rsctx#device"></see></summary>
    let device = _prefix "device"
    /// <summary>
    /// It indicates the District of a Location.
    /// <see href="http://softeng.polito.it/rsctx#district"></see></summary>
    let district = _prefix "district"
    /// <summary>
    /// The property associates an Environment to a Context.
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:device should be used.
    /// <see href="http://softeng.polito.it/rsctx#environment"></see></summary>
    let environment = _prefix "environment"
    /// <summary>
    /// It indicates the exterior temperature in degree Celsius.
    /// <see href="http://softeng.polito.it/rsctx#exteriorTemperature"></see></summary>
    let exteriorTemperature = _prefix "exteriorTemperature"
    /// <summary>
    /// This property indicates the fatigue of a PhysiologicalState. It is represented as string because there are scales such as Samm-Perelli seven point scale and karolinska sleepiness scale with some numbers associated to a string.
    /// <see href="http://softeng.polito.it/rsctx#fatigue"></see></summary>
    let fatigue = _prefix "fatigue"
    /// <summary>
    /// It indicates the FederatedState of a Location.
    /// <see href="http://softeng.polito.it/rsctx#federatedState"></see></summary>
    let federatedState = _prefix "federatedState"
    /// <summary>
    /// It indicates the Fifth Level Administrative DIvision of a Location.
    /// <see href="http://softeng.polito.it/rsctx#fifthLevelAdministrativeDivision"></see></summary>
    let fifthLevelAdministrativeDivision = _prefix "fifthLevelAdministrativeDivision"
    /// <summary>
    /// It indicates the first level administrative division of a Location.
    /// <see href="http://softeng.polito.it/rsctx#firstLevelAdministrativeDivision"></see></summary>
    let firstLevelAdministrativeDivision = _prefix "firstLevelAdministrativeDivision"
    /// <summary>
    /// It indicates the Floor of a Location.
    /// <see href="http://softeng.polito.it/rsctx#floor"></see></summary>
    let floor = _prefix "floor"
    /// <summary>
    /// It indicates the FloorSection of a Location.
    /// <see href="http://softeng.polito.it/rsctx#floorSection"></see></summary>
    let floorSection = _prefix "floorSection"
    /// <summary>
    /// It indicates the fourth level administrative division of a Location.
    /// <see href="http://softeng.polito.it/rsctx#fourthLevelAdministrativeDivision"></see></summary>
    let fourthLevelAdministrativeDivision = _prefix "fourthLevelAdministrativeDivision"
    /// <summary>
    /// This property indicates the emotional state of a user.
    /// <see href="http://softeng.polito.it/rsctx#hasEmotionalState"></see></summary>
    let hasEmotionalState = _prefix "hasEmotionalState"
    /// <summary>
    /// This property indicates the fitness of a user.
    /// <see href="http://softeng.polito.it/rsctx#hasFitness"></see></summary>
    let hasFitness = _prefix "hasFitness"
    /// <summary>
    /// This property indicates the mental state of a user.
    /// <see href="http://softeng.polito.it/rsctx#hasMentalState"></see></summary>
    let hasMentalState = _prefix "hasMentalState"
    /// <summary>
    /// This property indicates the motion of a user.
    ///
    /// WARNING Useful only if need domain and ranges, otherwise it is enough to use ao:activity.
    /// <see href="http://softeng.polito.it/rsctx#hasMotion"></see></summary>
    let hasMotion = _prefix "hasMotion"
    /// <summary>
    /// This property indicates the phsysiological state of a user.
    /// <see href="http://softeng.polito.it/rsctx#hasPhysiologicalState"></see></summary>
    let hasPhysiologicalState = _prefix "hasPhysiologicalState"
    /// <summary>
    /// This property indicates the purpose of a user.
    ///
    /// WARNING schema:purpose has different domain (three possible classes) and different ranges (2 possible classes). Although one range is Thing, which would enable to consider this porperty as subproperty of schema.org we should add a class in domain, while for the scopes of this ontology only Environment as domain is proper.
    /// <see href="http://softeng.polito.it/rsctx#hasPurpose"></see></summary>
    let hasPurpose = _prefix "hasPurpose"
    /// <summary>
    /// This property indicates a symbolic value for the temperature (such as warm, cold, etc.).
    ///
    /// WARNING Although there was already a temperature class and a temperature property (hw:hasExteriorTemperature) in the WeatherOntology, temperature class has been redefined with values more general and not referred to the house (such as below room temperature). Thus this property has the redefined temperature class as a range.
    /// <see href="http://softeng.polito.it/rsctx#hasTemperature"></see></summary>
    let hasTemperature = _prefix "hasTemperature"
    /// <summary>
    /// This property indicates the heartbeat of a PhysiologicalState
    /// <see href="http://softeng.polito.it/rsctx#heartbeat"></see></summary>
    let heartbeat = _prefix "heartbeat"
    /// <summary>
    /// This property indicates if a Time is holiday or a working day.
    /// <see href="http://softeng.polito.it/rsctx#holiday"></see></summary>
    let holiday = _prefix "holiday"
    /// <summary>
    /// This property indicates the hour which a Time is included.
    /// <see href="http://softeng.polito.it/rsctx#hour"></see></summary>
    let hour = _prefix "hour"
    /// <summary>
    /// This property indicates the injury of a PhysiologicalState
    /// <see href="http://softeng.polito.it/rsctx#injury"></see></summary>
    let injury = _prefix "injury"
    /// <summary>
    /// It indicates a LightLevel.
    /// <see href="http://softeng.polito.it/rsctx#lightLevel"></see></summary>
    let lightLevel = _prefix "lightLevel"
    /// <summary>
    /// It indicates the light level in lux.
    /// <see href="http://softeng.polito.it/rsctx#lighting"></see></summary>
    let lighting = _prefix "lighting"
    /// <summary>
    /// It indicates the Municipality of a Location.
    /// <see href="http://softeng.polito.it/rsctx#municipality"></see></summary>
    let municipality = _prefix "municipality"
    /// <summary>
    /// It indicates the Neighborhood of a Location.
    /// <see href="http://softeng.polito.it/rsctx#neighborhood"></see></summary>
    let neighborhood = _prefix "neighborhood"
    /// <summary>
    /// It indicates the noise in decibel.
    /// <see href="http://softeng.polito.it/rsctx#noise"></see></summary>
    let noise = _prefix "noise"
    /// <summary>
    /// It indicates a NoiseLevel
    /// <see href="http://softeng.polito.it/rsctx#noiseLevel"></see></summary>
    let noiseLevel = _prefix "noiseLevel"
    /// <summary>
    /// This property indicates the nourishment (in BMI) of a PhysiologicalState.
    /// <see href="http://softeng.polito.it/rsctx#nourishment"></see></summary>
    let nourishment = _prefix "nourishment"
    /// <summary>
    /// It indicates the Parish of a Location.
    /// parish
    /// <see href="http://softeng.polito.it/rsctx#parish"></see></summary>
    let parish = _prefix "parish"
    /// <summary>
    /// This property indicates part of the day in which a Time is included in.
    /// <see href="http://softeng.polito.it/rsctx#partOfDay"></see></summary>
    let partOfDay = _prefix "partOfDay"
    /// <summary>
    /// This property indicates the perspiration (in liters per hours) of a PhysiologicalState.
    /// <see href="http://softeng.polito.it/rsctx#perspiration"></see></summary>
    let perspiration = _prefix "perspiration"
    /// <summary>
    /// The property associates a POI to a prissma:Environment
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:poi should be used.
    /// <see href="http://softeng.polito.it/rsctx#poi"></see></summary>
    let poi = _prefix "poi"
    /// <summary>
    /// It indicates the Proince of a Location.
    /// province
    /// <see href="http://softeng.polito.it/rsctx#province"></see></summary>
    let province = _prefix "province"
    /// <summary>
    /// This property indicates the pupil dilation (in mm) of a PhysiologicalState.
    /// <see href="http://softeng.polito.it/rsctx#pupilsDilation"></see></summary>
    let pupilsDilation = _prefix "pupilsDilation"
    /// <summary>
    /// It indicates the Region of a Location.
    /// <see href="http://softeng.polito.it/rsctx#region"></see></summary>
    let region = _prefix "region"
    /// <summary>
    /// This property indicates the respiration of a PhysiologicalState (in breaths per minute).
    /// <see href="http://softeng.polito.it/rsctx#respiration"></see></summary>
    let respiration = _prefix "respiration"
    /// <summary>
    /// It indicates the Room of a Location.
    /// <see href="http://softeng.polito.it/rsctx#room"></see></summary>
    let room = _prefix "room"
    /// <summary>
    /// It indicates the season in which a Time is included in.
    /// <see href="http://softeng.polito.it/rsctx#season"></see></summary>
    let season = _prefix "season"
    /// <summary>
    /// It indicates the second level administrative division of a Location.
    /// <see href="http://softeng.polito.it/rsctx#secondLevelAdministrativeDivision"></see></summary>
    let secondLevelAdministrativeDivision = _prefix "secondLevelAdministrativeDivision"
    /// <summary>
    /// It indicates the Site of a Location.
    /// <see href="http://softeng.polito.it/rsctx#site"></see></summary>
    let site = _prefix "site"
    /// <summary>
    /// It indicates the Street of a Location.
    /// <see href="http://softeng.polito.it/rsctx#street"></see></summary>
    let street = _prefix "street"
    /// <summary>
    /// It indicates to which symbolic location that POI corresponds to (if any), such as the home or the workplace of the user or a public place (e.g. a cinema).
    /// <see href="http://softeng.polito.it/rsctx#symbolicLocation"></see></summary>
    let symbolicLocation = _prefix "symbolicLocation"
    /// <summary>
    /// It indicates the third level administrative division of a Location.
    /// <see href="http://softeng.polito.it/rsctx#thirdLevelAdministrativeDivision"></see></summary>
    let thirdLevelAdministrativeDivision = _prefix "thirdLevelAdministrativeDivision"
    /// <summary>
    /// It indicates the time associated to the Environment.
    /// <see href="http://softeng.polito.it/rsctx#time"></see></summary>
    let time = _prefix "time"
    /// <summary>
    /// It indicates a TrafficLevel
    /// <see href="http://softeng.polito.it/rsctx#trafficLevel"></see></summary>
    let trafficLevel = _prefix "trafficLevel"
    /// <summary>
    /// It indicates which TransportationMean the user is using or is going to use.
    /// <see href="http://softeng.polito.it/rsctx#transportationMean"></see></summary>
    let transportationMean = _prefix "transportationMean"
    /// <summary>
    /// The property associates a User to a Context.
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:user should be used.
    /// <see href="http://softeng.polito.it/rsctx#user"></see></summary>
    let user = _prefix "user"
    /// <summary>
    /// It indicates the weather associated to the current context.
    /// <see href="http://softeng.polito.it/rsctx#weather"></see></summary>
    let weather = _prefix "weather"
