namespace http.softeng.polito.it.rsctx.hash

open DoxAletheia.Rdf_Vocabulary

module rsctx =
    let _namespace_name = "http://softeng.polito.it/rsctx#"
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Dominance"></see>
    /// </summary>
    let Dominance = Namespaced_IRI.parse _namespace_name "Dominance" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Pleasure"></see>
    /// </summary>
    let Pleasure = Namespaced_IRI.parse _namespace_name "Pleasure" |> NamespacedName
    /// <summary>
    /// This class indicates the day of the week (such as Monday, Tuesday, etc.).
    /// <see href="http://softeng.polito.it/rsctx#DayOfWeek"></see></summary>
    let DayOfWeek = Namespaced_IRI.parse _namespace_name "DayOfWeek" |> NamespacedName
    /// <summary>
    /// This class represents the time intervals in which a day can be divided in.
    /// <see href="http://softeng.polito.it/rsctx#PartOfDay"></see></summary>
    let PartOfDay = Namespaced_IRI.parse _namespace_name "PartOfDay" |> NamespacedName
    /// <summary>
    /// A season is a division of the year marked by changes in weather.
    /// <see href="http://softeng.polito.it/rsctx#Season"></see></summary>
    let Season = Namespaced_IRI.parse _namespace_name "Season" |> NamespacedName
    /// <summary>
    /// The user is with his boss. This may be a more formal situation that being with just the colleagues.
    /// <see href="http://softeng.polito.it/rsctx#Boss"></see></summary>
    let Boss = Namespaced_IRI.parse _namespace_name "Boss" |> NamespacedName

    /// <summary>
    /// The user is with a business partner, e.g. a business partner can be a customer or a member of another organizations with which the user is collaborating or a supplier.
    /// <see href="http://softeng.polito.it/rsctx#BusinessPartner"></see></summary>
    let BusinessPartner =
        Namespaced_IRI.parse _namespace_name "BusinessPartner" |> NamespacedName

    /// <summary>
    /// The user is with children, not necessarily his family: for example may be a teacher or a baby sitter.
    /// <see href="http://softeng.polito.it/rsctx#Child"></see></summary>
    let Child = Namespaced_IRI.parse _namespace_name "Child" |> NamespacedName
    /// <summary>
    /// The user is with one or more colleagues.
    /// <see href="http://softeng.polito.it/rsctx#Colleague"></see></summary>
    let Colleague = Namespaced_IRI.parse _namespace_name "Colleague" |> NamespacedName
    /// <summary>
    /// The user is with his family, not necessarely with children. For instance, this may includes being just with the sister or brother or the parents.
    /// <see href="http://softeng.polito.it/rsctx#Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    /// The user is with one or more friends.
    /// <see href="http://softeng.polito.it/rsctx#Friend"></see></summary>
    let Friend = Namespaced_IRI.parse _namespace_name "Friend" |> NamespacedName
    /// <summary>
    /// The user is alone.
    /// <see href="http://softeng.polito.it/rsctx#Nobody"></see></summary>
    let Nobody = Namespaced_IRI.parse _namespace_name "Nobody" |> NamespacedName
    /// <summary>
    /// The user is with her/his boyfriend/girlfriend or husband/wife.
    /// <see href="http://softeng.polito.it/rsctx#Partner"></see></summary>
    let Partner = Namespaced_IRI.parse _namespace_name "Partner" |> NamespacedName

    /// <summary>
    /// It is a key  location,  such  as  our  home  and  work  place,  that  we
    /// consider as "anchor" in our understanding of the geographic environment
    /// where we live. In general, an anchor-point is a frequently visited location or a location where one spends a lot of time.
    /// <see href="http://softeng.polito.it/rsctx#AnchorPoint"></see></summary>
    let AnchorPoint =
        Namespaced_IRI.parse _namespace_name "AnchorPoint" |> NamespacedName

    /// <summary>
    /// The home of a companion of the user, such as a freind's home or a colleague's home.
    ///
    /// WARNING This piece of information can be hard to obtained (unless explicitly asked to the user). It is a class and not an individual because the individual is the specific house (e.g. my friend Bob's house).
    /// <see href="http://softeng.polito.it/rsctx#CompanionHome"></see></summary>
    let CompanionHome =
        Namespaced_IRI.parse _namespace_name "CompanionHome" |> NamespacedName

    /// <summary>
    /// A public place such as a cinema or a theatre.
    ///
    /// WARNING It is a class and not an individual because the individual can be a specific cinema or theatre (e.g. La Scala theatre in Milan).
    /// <see href="http://softeng.polito.it/rsctx#PublicPlace"></see></summary>
    let PublicPlace =
        Namespaced_IRI.parse _namespace_name "PublicPlace" |> NamespacedName

    /// <summary>
    /// The state of a person's emotions (especially with regard to pleasure or dejection).
    ///
    /// WARNING The possible values are represented as individuals while in the GUMO ontology are classes.
    /// <see href="http://softeng.polito.it/rsctx#EmotionalState"></see></summary>
    let EmotionalState =
        Namespaced_IRI.parse _namespace_name "EmotionalState" |> NamespacedName

    /// <summary>
    /// It is a value partition which represents the health of the body, it can be seen as a summary of physiological state, since it is possible to map fitness values with physiological indicators ranges (e.g. ill if temperature greater than a certain threshold), although this is up to the designer which is using the ontology.
    /// <see href="http://softeng.polito.it/rsctx#Fitness"></see></summary>
    let Fitness = Namespaced_IRI.parse _namespace_name "Fitness" |> NamespacedName

    /// <summary>
    /// A mental condition in which the qualities of a state are relatively constant even though the state itself may be dynamic, such as depression, cognitive load, nervousness.
    ///
    /// WARNING The possible values are represented as individuals while in the GUMO ontology are classes.
    /// <see href="http://softeng.polito.it/rsctx#MentalState"></see></summary>
    let MentalState =
        Namespaced_IRI.parse _namespace_name "MentalState" |> NamespacedName

    /// <summary>
    /// The state of the body or bodily functions.
    ///
    /// WARNING The subclasses of PhysiologicalState in GUMO ontology  are represented as datatype properties.
    /// <see href="http://softeng.polito.it/rsctx#PhysiologicalState"></see></summary>
    let PhysiologicalState =
        Namespaced_IRI.parse _namespace_name "PhysiologicalState" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#00"></see>
    /// </summary>
    let _00 = Namespaced_IRI.parse _namespace_name "00" |> NamespacedName
    /// <summary>
    /// The hours of a day.
    /// <see href="http://softeng.polito.it/rsctx#Hour"></see></summary>
    let Hour = Namespaced_IRI.parse _namespace_name "Hour" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#01"></see>
    /// </summary>
    let _01 = Namespaced_IRI.parse _namespace_name "01" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#02"></see>
    /// </summary>
    let _02 = Namespaced_IRI.parse _namespace_name "02" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#03"></see>
    /// </summary>
    let _03 = Namespaced_IRI.parse _namespace_name "03" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#04"></see>
    /// </summary>
    let _04 = Namespaced_IRI.parse _namespace_name "04" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#05"></see>
    /// </summary>
    let _05 = Namespaced_IRI.parse _namespace_name "05" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#06"></see>
    /// </summary>
    let _06 = Namespaced_IRI.parse _namespace_name "06" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#07"></see>
    /// </summary>
    let _07 = Namespaced_IRI.parse _namespace_name "07" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#08"></see>
    /// </summary>
    let _08 = Namespaced_IRI.parse _namespace_name "08" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#09"></see>
    /// </summary>
    let _09 = Namespaced_IRI.parse _namespace_name "09" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#10"></see>
    /// </summary>
    let _10 = Namespaced_IRI.parse _namespace_name "10" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#11"></see>
    /// </summary>
    let _11 = Namespaced_IRI.parse _namespace_name "11" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#12"></see>
    /// </summary>
    let _12 = Namespaced_IRI.parse _namespace_name "12" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#13"></see>
    /// </summary>
    let _13 = Namespaced_IRI.parse _namespace_name "13" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#14"></see>
    /// </summary>
    let _14 = Namespaced_IRI.parse _namespace_name "14" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#15"></see>
    /// </summary>
    let _15 = Namespaced_IRI.parse _namespace_name "15" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#16"></see>
    /// </summary>
    let _16 = Namespaced_IRI.parse _namespace_name "16" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#17"></see>
    /// </summary>
    let _17 = Namespaced_IRI.parse _namespace_name "17" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#18"></see>
    /// </summary>
    let _18 = Namespaced_IRI.parse _namespace_name "18" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#19"></see>
    /// </summary>
    let _19 = Namespaced_IRI.parse _namespace_name "19" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#20"></see>
    /// </summary>
    let _20 = Namespaced_IRI.parse _namespace_name "20" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#21"></see>
    /// </summary>
    let _21 = Namespaced_IRI.parse _namespace_name "21" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#22"></see>
    /// </summary>
    let _22 = Namespaced_IRI.parse _namespace_name "22" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#23"></see>
    /// </summary>
    let _23 = Namespaced_IRI.parse _namespace_name "23" |> NamespacedName

    /// <summary>
    /// A  specific type of subnational entity in a number of countries, e.g. Belgium, Italy, France.
    /// <see href="http://softeng.polito.it/rsctx#AdministrativeRegion"></see></summary>
    let AdministrativeRegion =
        Namespaced_IRI.parse _namespace_name "AdministrativeRegion" |> NamespacedName

    /// <summary>
    /// A political or geographical region.
    ///
    /// WARNING dbpedia-owl represents regions too but it refer to broader sense of region which include any area which is possible to distinguish in geography. In this sense any other geographical unit defined in this ontology (such as country, province, etc.) is a region, while we intend only to represent geographical regions or specific administrative area named regions in some countries (e.g. Italy, France, Belgium).
    /// <see href="http://softeng.polito.it/rsctx#Region"></see></summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName
    /// <summary>
    /// The time of the day between noon and evening. The mapping with respect the hours is possible but not defined because it may vary with the location and the habits.
    /// <see href="http://softeng.polito.it/rsctx#Afternoon"></see></summary>
    let Afternoon = Namespaced_IRI.parse _namespace_name "Afternoon" |> NamespacedName

    /// <summary>
    /// In general, it represents an abstract ideas of where an object is (e.g. next to a mailbox). In the context of the ontology, it can be an anchor point (i.e. a frequently visited location) or a public place or the anchor point of another user.
    ///
    /// WARNING Other kind of symbolic location such as bankomat, mailbox, or a train approaching Dublin are not considered.
    /// <see href="http://softeng.polito.it/rsctx#SymbolicLocation"></see></summary>
    let SymbolicLocation =
        Namespaced_IRI.parse _namespace_name "SymbolicLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#WorkPlace"></see>
    /// </summary>
    let WorkPlace = Namespaced_IRI.parse _namespace_name "WorkPlace" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Home"></see>
    /// </summary>
    let Home = Namespaced_IRI.parse _namespace_name "Home" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Bike"></see>
    /// </summary>
    let Bike = Namespaced_IRI.parse _namespace_name "Bike" |> NamespacedName

    /// <summary>
    /// It represents the transportation mean the user is using or is going to use (e.g. to reach a restaurant or to visit a city), such as car, bike, public transport or none (he is going on foot).
    /// <see href="http://softeng.polito.it/rsctx#TransportationMean"></see></summary>
    let TransportationMean =
        Namespaced_IRI.parse _namespace_name "TransportationMean" |> NamespacedName

    /// <summary>
    /// Companion class indicates which kind of company the user as at the moment. For example, it may be with family, friends or colleagues.
    ///
    /// WARNING Its subclasses not as individual, because the individual could be a person (e.g. Bob or Alice), and it is an istance also of one of companion sublasses to indicate which in kind of companion the individual is for the user in the current context (e.g. is family or colleagues or friend).
    /// <see href="http://softeng.polito.it/rsctx#Companion"></see></summary>
    let Companion = Namespaced_IRI.parse _namespace_name "Companion" |> NamespacedName

    /// <summary>
    /// Season which is generally recognized in temperate and subpolar regions, include summer, spring, winter and fall (or autumn).
    ///
    /// WARNING This class has just the purpose to organize the seasons. It SHOULD NOT have instances.
    /// <see href="http://softeng.polito.it/rsctx#CalendarSeason"></see></summary>
    let CalendarSeason =
        Namespaced_IRI.parse _namespace_name "CalendarSeason" |> NamespacedName

    /// <summary>
    /// Season which occur in hot regions. It includes the rainy (or wet, or monsoon) season and the dry season, In some tropical areas, a cool or mild season is also present.
    ///
    /// WARNING This class has just the purpose to organize the seasons. It SHOULD NOT have instances.
    /// <see href="http://softeng.polito.it/rsctx#TropicalSeason"></see></summary>
    let TropicalSeason =
        Namespaced_IRI.parse _namespace_name "TropicalSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Spring"></see>
    /// </summary>
    let Spring = Namespaced_IRI.parse _namespace_name "Spring" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Fall"></see>
    /// </summary>
    let Fall = Namespaced_IRI.parse _namespace_name "Fall" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Summer"></see>
    /// </summary>
    let Summer = Namespaced_IRI.parse _namespace_name "Summer" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Winter"></see>
    /// </summary>
    let Winter = Namespaced_IRI.parse _namespace_name "Winter" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Calm"></see>
    /// </summary>
    let Calm = Namespaced_IRI.parse _namespace_name "Calm" |> NamespacedName

    /// <summary>
    /// This class represents the current traffic situation.
    /// <see href="http://softeng.polito.it/rsctx#TrafficLevel"></see></summary>
    let TrafficLevel =
        Namespaced_IRI.parse _namespace_name "TrafficLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Car"></see>
    /// </summary>
    let Car = Namespaced_IRI.parse _namespace_name "Car" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Chaotic"></see>
    /// </summary>
    let Chaotic = Namespaced_IRI.parse _namespace_name "Chaotic" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Cold"></see>
    /// </summary>
    let Cold = Namespaced_IRI.parse _namespace_name "Cold" |> NamespacedName

    /// <summary>
    /// It represents the exterior temperature by means of a symbolic value, such as warm or cool.
    ///
    /// TODO Map the individuals with temperature ranges?
    /// <see href="http://softeng.polito.it/rsctx#Temperature"></see></summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Cool"></see>
    /// </summary>
    let Cool = Namespaced_IRI.parse _namespace_name "Cool" |> NamespacedName

    /// <summary>
    /// A period of time between two instants.
    /// <see href="http://softeng.polito.it/rsctx#TimeInterval"></see></summary>
    let TimeInterval =
        Namespaced_IRI.parse _namespace_name "TimeInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#DrySeason"></see>
    /// </summary>
    let DrySeason = Namespaced_IRI.parse _namespace_name "DrySeason" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#hope"></see>
    /// </summary>
    let hope = Namespaced_IRI.parse _namespace_name "hope" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#confusion"></see>
    /// </summary>
    let confusion = Namespaced_IRI.parse _namespace_name "confusion" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#satisfaction"></see>
    /// </summary>
    let satisfaction =
        Namespaced_IRI.parse _namespace_name "satisfaction" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#pride"></see>
    /// </summary>
    let pride = Namespaced_IRI.parse _namespace_name "pride" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#anxiety"></see>
    /// </summary>
    let anxiety = Namespaced_IRI.parse _namespace_name "anxiety" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#relief"></see>
    /// </summary>
    let relief = Namespaced_IRI.parse _namespace_name "relief" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#joy"></see>
    /// </summary>
    let joy = Namespaced_IRI.parse _namespace_name "joy" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#excitement"></see>
    /// </summary>
    let excitement = Namespaced_IRI.parse _namespace_name "excitement" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#dread"></see>
    /// </summary>
    let dread = Namespaced_IRI.parse _namespace_name "dread" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#sadness"></see>
    /// </summary>
    let sadness = Namespaced_IRI.parse _namespace_name "sadness" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#anger"></see>
    /// </summary>
    let anger = Namespaced_IRI.parse _namespace_name "anger" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#disgust"></see>
    /// </summary>
    let disgust = Namespaced_IRI.parse _namespace_name "disgust" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#shame"></see>
    /// </summary>
    let shame = Namespaced_IRI.parse _namespace_name "shame" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#hate"></see>
    /// </summary>
    let hate = Namespaced_IRI.parse _namespace_name "hate" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#happiness"></see>
    /// </summary>
    let happiness = Namespaced_IRI.parse _namespace_name "happiness" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#fear"></see>
    /// </summary>
    let fear = Namespaced_IRI.parse _namespace_name "fear" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#boredom"></see>
    /// </summary>
    let boredom = Namespaced_IRI.parse _namespace_name "boredom" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#love"></see>
    /// </summary>
    let love = Namespaced_IRI.parse _namespace_name "love" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#worry"></see>
    /// </summary>
    let worry = Namespaced_IRI.parse _namespace_name "worry" |> NamespacedName
    /// <summary>
    /// The period of time near the end of the day, from the end of afternoon (usually from 6 PM) to nighttime. The mapping with respect the hours is possible but not defined becaus it may vary with the location and the habits.
    /// <see href="http://softeng.polito.it/rsctx#Evening"></see></summary>
    let Evening = Namespaced_IRI.parse _namespace_name "Evening" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#good"></see>
    /// </summary>
    let good = Namespaced_IRI.parse _namespace_name "good" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#great"></see>
    /// </summary>
    let great = Namespaced_IRI.parse _namespace_name "great" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#exahust"></see>
    /// </summary>
    let exahust = Namespaced_IRI.parse _namespace_name "exahust" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#ill"></see>
    /// </summary>
    let ill = Namespaced_IRI.parse _namespace_name "ill" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#sleepy"></see>
    /// </summary>
    let sleepy = Namespaced_IRI.parse _namespace_name "sleepy" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#weak"></see>
    /// </summary>
    let weak = Namespaced_IRI.parse _namespace_name "weak" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#inFit"></see>
    /// </summary>
    let inFit = Namespaced_IRI.parse _namespace_name "inFit" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#tired"></see>
    /// </summary>
    let tired = Namespaced_IRI.parse _namespace_name "tired" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#injured"></see>
    /// </summary>
    let injured = Namespaced_IRI.parse _namespace_name "injured" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Freezing"></see>
    /// </summary>
    let Freezing = Namespaced_IRI.parse _namespace_name "Freezing" |> NamespacedName

    /// <summary>
    /// A physical or historical region. Such as the Iberian peninsula or the Northwest European Atlantic Protestant Region (i.e. the European "source regions" in early American colonization efforts).
    /// <see href="http://softeng.polito.it/rsctx#GeographicalRegion"></see></summary>
    let GeographicalRegion =
        Namespaced_IRI.parse _namespace_name "GeographicalRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Hot"></see>
    /// </summary>
    let Hot = Namespaced_IRI.parse _namespace_name "Hot" |> NamespacedName
    /// <summary>
    /// This class represent the current level of light. It is intended some symbolic level such as dark, sunlight, etc.
    /// <see href="http://softeng.polito.it/rsctx#LightLevel"></see></summary>
    let LightLevel = Namespaced_IRI.parse _namespace_name "LightLevel" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#trauma"></see>
    /// </summary>
    let trauma = Namespaced_IRI.parse _namespace_name "trauma" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#timePressure"></see>
    /// </summary>
    let timePressure =
        Namespaced_IRI.parse _namespace_name "timePressure" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#hypnosis"></see>
    /// </summary>
    let hypnosis = Namespaced_IRI.parse _namespace_name "hypnosis" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#cognitiveLoad"></see>
    /// </summary>
    let cognitiveLoad =
        Namespaced_IRI.parse _namespace_name "cognitiveLoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#irritation"></see>
    /// </summary>
    let irritation = Namespaced_IRI.parse _namespace_name "irritation" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#nervousness"></see>
    /// </summary>
    let nervousness =
        Namespaced_IRI.parse _namespace_name "nervousness" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#trance"></see>
    /// </summary>
    let trance = Namespaced_IRI.parse _namespace_name "trance" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#psychopathy"></see>
    /// </summary>
    let psychopathy =
        Namespaced_IRI.parse _namespace_name "psychopathy" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#depression"></see>
    /// </summary>
    let depression = Namespaced_IRI.parse _namespace_name "depression" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Mild"></see>
    /// </summary>
    let Mild = Namespaced_IRI.parse _namespace_name "Mild" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#MildSeason"></see>
    /// </summary>
    let MildSeason = Namespaced_IRI.parse _namespace_name "MildSeason" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Moderate"></see>
    /// </summary>
    let Moderate = Namespaced_IRI.parse _namespace_name "Moderate" |> NamespacedName
    /// <summary>
    /// The period of time between midnight and noon or, more commonly, the interval between sunrise and noon.
    /// <see href="http://softeng.polito.it/rsctx#Morning"></see></summary>
    let Morning = Namespaced_IRI.parse _namespace_name "Morning" |> NamespacedName
    /// <summary>
    /// This class indicates if the user is moving and how, e.g. if he is walking or running.
    /// <see href="http://softeng.polito.it/rsctx#Motion"></see></summary>
    let Motion = Namespaced_IRI.parse _namespace_name "Motion" |> NamespacedName
    /// <summary>
    /// The period of time between the sunset and the sunrise when the Sun is below the horizon.The mapping with respect the hours is possible but not defined becaus it may vary with the location and the habits.
    /// <see href="http://softeng.polito.it/rsctx#Night"></see></summary>
    let Night = Namespaced_IRI.parse _namespace_name "Night" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#NoTrasportationMean"></see>
    /// </summary>
    let NoTrasportationMean =
        Namespaced_IRI.parse _namespace_name "NoTrasportationMean" |> NamespacedName

    /// <summary>
    /// This class represents the current level of noise. It is intended a symbolic level such as very noisy, silent, etc.
    /// <see href="http://softeng.polito.it/rsctx#NoiseLevel"></see></summary>
    let NoiseLevel = Namespaced_IRI.parse _namespace_name "NoiseLevel" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Pleasant"></see>
    /// </summary>
    let Pleasant = Namespaced_IRI.parse _namespace_name "Pleasant" |> NamespacedName

    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#PublicTransport"></see>
    /// </summary>
    let PublicTransport =
        Namespaced_IRI.parse _namespace_name "PublicTransport" |> NamespacedName

    /// <summary>
    /// Purpose
    /// The description of a situation that is desired by an Agent, and usually associated to a plan that describes how to actually achieve it. In the context of this ontology, it indicates the purpose of the item to be recommended. E.g. the user may be interested in receiving recommendation of movies for educating about a specific topic (for instance in the case of a teacher, which wants to show a movie in class) or for having fun (see a movie with some friends in the night).
    /// <see href="http://softeng.polito.it/rsctx#Purpose"></see></summary>
    let Purpose = Namespaced_IRI.parse _namespace_name "Purpose" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Taxi"></see>
    /// </summary>
    let Taxi = Namespaced_IRI.parse _namespace_name "Taxi" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#Warm"></see>
    /// </summary>
    let Warm = Namespaced_IRI.parse _namespace_name "Warm" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#VeryCold"></see>
    /// </summary>
    let VeryCold = Namespaced_IRI.parse _namespace_name "VeryCold" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#VeryWarm"></see>
    /// </summary>
    let VeryWarm = Namespaced_IRI.parse _namespace_name "VeryWarm" |> NamespacedName
    /// <summary>
    /// Time is an instant, i.e. a timestamp. Then it can be characterized by some TimeIntervals which it belongs to, such as winter, Monday and morning.
    /// <see href="http://softeng.polito.it/rsctx#Time"></see></summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    ///   <see href="http://softeng.polito.it/rsctx#WetSeason"></see>
    /// </summary>
    let WetSeason = Namespaced_IRI.parse _namespace_name "WetSeason" |> NamespacedName
    /// <summary>
    /// This class indicates the days which made up the weekend (typically not working).
    /// <see href="http://softeng.polito.it/rsctx#WeekEnd"></see></summary>
    let WeekEnd = Namespaced_IRI.parse _namespace_name "WeekEnd" |> NamespacedName
    /// <summary>
    /// This class includes the day of the week which are typically working (if is not holiday). Days from Monday to Friday are weekdays.
    /// <see href="http://softeng.polito.it/rsctx#Weekday"></see></summary>
    let Weekday = Namespaced_IRI.parse _namespace_name "Weekday" |> NamespacedName
    /// <summary>
    /// It indicates the ZIP code of a Location.
    /// <see href="http://softeng.polito.it/rsctx#ZIPCode"></see></summary>
    let ZIPCode = Namespaced_IRI.parse _namespace_name "ZIPCode" |> NamespacedName
    /// <summary>
    /// This property indicates the activity of a user.
    ///
    /// WARNING Useful only if need domain and ranges, otherwise it is enough to use ao:activity.
    /// <see href="http://softeng.polito.it/rsctx#activity"></see></summary>
    let activity = Namespaced_IRI.parse _namespace_name "activity" |> NamespacedName
    /// <summary>
    /// It indicates the address of a location
    /// <see href="http://softeng.polito.it/rsctx#address"></see></summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName

    /// <summary>
    /// It indicates how much time the user can spend (e.g. to visit a city or to go for lunch in lunch brek at work).
    /// <see href="http://softeng.polito.it/rsctx#availableTime"></see></summary>
    let availableTime =
        Namespaced_IRI.parse _namespace_name "availableTime" |> NamespacedName

    /// <summary>
    /// This property indicates the blood pressure (in mmHg) of a PhysiologicalState
    /// <see href="http://softeng.polito.it/rsctx#bloodPressure"></see></summary>
    let bloodPressure =
        Namespaced_IRI.parse _namespace_name "bloodPressure" |> NamespacedName

    /// <summary>
    /// This property indicates the temperature (in degree Celsius) of a PhysiologicalState.
    /// <see href="http://softeng.polito.it/rsctx#bodyTemperature"></see></summary>
    let bodyTemperature =
        Namespaced_IRI.parse _namespace_name "bodyTemperature" |> NamespacedName

    /// <summary>
    /// It indicates how much the user want or can spend (for example for a travel or a purchase or to go for a dinner in a restaurant).
    /// <see href="http://softeng.polito.it/rsctx#budget"></see></summary>
    let budget = Namespaced_IRI.parse _namespace_name "budget" |> NamespacedName
    /// <summary>
    /// It indicates the building associated to a location.
    /// <see href="http://softeng.polito.it/rsctx#bulding"></see></summary>
    let bulding = Namespaced_IRI.parse _namespace_name "bulding" |> NamespacedName
    /// <summary>
    /// It indicates the city of a Location.
    /// <see href="http://softeng.polito.it/rsctx#city"></see></summary>
    let city = Namespaced_IRI.parse _namespace_name "city" |> NamespacedName
    /// <summary>
    /// This property indicates who is the current companion of the user, e.g. a friend a family member or a colleague.
    /// <see href="http://softeng.polito.it/rsctx#companion"></see></summary>
    let companion = Namespaced_IRI.parse _namespace_name "companion" |> NamespacedName
    /// <summary>
    /// It indicates the country of a Location.
    /// <see href="http://softeng.polito.it/rsctx#country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName
    /// <summary>
    /// It indicates the county of a Location.
    /// <see href="http://softeng.polito.it/rsctx#county"></see></summary>
    let county = Namespaced_IRI.parse _namespace_name "county" |> NamespacedName
    /// <summary>
    /// This property indicates the day of week of a Time.
    /// <see href="http://softeng.polito.it/rsctx#dayOfWeek"></see></summary>
    let dayOfWeek = Namespaced_IRI.parse _namespace_name "dayOfWeek" |> NamespacedName
    /// <summary>
    /// It indicates the Desk of a Location.
    /// <see href="http://softeng.polito.it/rsctx#desk"></see></summary>
    let desk = Namespaced_IRI.parse _namespace_name "desk" |> NamespacedName
    /// <summary>
    /// The property associates a Device to a Context.
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:device should be used.
    /// <see href="http://softeng.polito.it/rsctx#device"></see></summary>
    let device = Namespaced_IRI.parse _namespace_name "device" |> NamespacedName
    /// <summary>
    /// It indicates the District of a Location.
    /// <see href="http://softeng.polito.it/rsctx#district"></see></summary>
    let district = Namespaced_IRI.parse _namespace_name "district" |> NamespacedName

    /// <summary>
    /// The property associates an Environment to a Context.
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:device should be used.
    /// <see href="http://softeng.polito.it/rsctx#environment"></see></summary>
    let environment =
        Namespaced_IRI.parse _namespace_name "environment" |> NamespacedName

    /// <summary>
    /// It indicates the exterior temperature in degree Celsius.
    /// <see href="http://softeng.polito.it/rsctx#exteriorTemperature"></see></summary>
    let exteriorTemperature =
        Namespaced_IRI.parse _namespace_name "exteriorTemperature" |> NamespacedName

    /// <summary>
    /// This property indicates the fatigue of a PhysiologicalState. It is represented as string because there are scales such as Samm-Perelli seven point scale and karolinska sleepiness scale with some numbers associated to a string.
    /// <see href="http://softeng.polito.it/rsctx#fatigue"></see></summary>
    let fatigue = Namespaced_IRI.parse _namespace_name "fatigue" |> NamespacedName

    /// <summary>
    /// It indicates the FederatedState of a Location.
    /// <see href="http://softeng.polito.it/rsctx#federatedState"></see></summary>
    let federatedState =
        Namespaced_IRI.parse _namespace_name "federatedState" |> NamespacedName

    /// <summary>
    /// It indicates the Fifth Level Administrative DIvision of a Location.
    /// <see href="http://softeng.polito.it/rsctx#fifthLevelAdministrativeDivision"></see></summary>
    let fifthLevelAdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "fifthLevelAdministrativeDivision" |> NamespacedName

    /// <summary>
    /// It indicates the first level administrative division of a Location.
    /// <see href="http://softeng.polito.it/rsctx#firstLevelAdministrativeDivision"></see></summary>
    let firstLevelAdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "firstLevelAdministrativeDivision" |> NamespacedName

    /// <summary>
    /// It indicates the Floor of a Location.
    /// <see href="http://softeng.polito.it/rsctx#floor"></see></summary>
    let floor = Namespaced_IRI.parse _namespace_name "floor" |> NamespacedName

    /// <summary>
    /// It indicates the FloorSection of a Location.
    /// <see href="http://softeng.polito.it/rsctx#floorSection"></see></summary>
    let floorSection =
        Namespaced_IRI.parse _namespace_name "floorSection" |> NamespacedName

    /// <summary>
    /// It indicates the fourth level administrative division of a Location.
    /// <see href="http://softeng.polito.it/rsctx#fourthLevelAdministrativeDivision"></see></summary>
    let fourthLevelAdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "fourthLevelAdministrativeDivision" |> NamespacedName

    /// <summary>
    /// This property indicates the emotional state of a user.
    /// <see href="http://softeng.polito.it/rsctx#hasEmotionalState"></see></summary>
    let hasEmotionalState =
        Namespaced_IRI.parse _namespace_name "hasEmotionalState" |> NamespacedName

    /// <summary>
    /// This property indicates the fitness of a user.
    /// <see href="http://softeng.polito.it/rsctx#hasFitness"></see></summary>
    let hasFitness = Namespaced_IRI.parse _namespace_name "hasFitness" |> NamespacedName

    /// <summary>
    /// This property indicates the mental state of a user.
    /// <see href="http://softeng.polito.it/rsctx#hasMentalState"></see></summary>
    let hasMentalState =
        Namespaced_IRI.parse _namespace_name "hasMentalState" |> NamespacedName

    /// <summary>
    /// This property indicates the motion of a user.
    ///
    /// WARNING Useful only if need domain and ranges, otherwise it is enough to use ao:activity.
    /// <see href="http://softeng.polito.it/rsctx#hasMotion"></see></summary>
    let hasMotion = Namespaced_IRI.parse _namespace_name "hasMotion" |> NamespacedName

    /// <summary>
    /// This property indicates the phsysiological state of a user.
    /// <see href="http://softeng.polito.it/rsctx#hasPhysiologicalState"></see></summary>
    let hasPhysiologicalState =
        Namespaced_IRI.parse _namespace_name "hasPhysiologicalState" |> NamespacedName

    /// <summary>
    /// This property indicates the purpose of a user.
    ///
    /// WARNING schema:purpose has different domain (three possible classes) and different ranges (2 possible classes). Although one range is Thing, which would enable to consider this porperty as subproperty of schema.org we should add a class in domain, while for the scopes of this ontology only Environment as domain is proper.
    /// <see href="http://softeng.polito.it/rsctx#hasPurpose"></see></summary>
    let hasPurpose = Namespaced_IRI.parse _namespace_name "hasPurpose" |> NamespacedName

    /// <summary>
    /// This property indicates a symbolic value for the temperature (such as warm, cold, etc.).
    ///
    /// WARNING Although there was already a temperature class and a temperature property (hw:hasExteriorTemperature) in the WeatherOntology, temperature class has been redefined with values more general and not referred to the house (such as below room temperature). Thus this property has the redefined temperature class as a range.
    /// <see href="http://softeng.polito.it/rsctx#hasTemperature"></see></summary>
    let hasTemperature =
        Namespaced_IRI.parse _namespace_name "hasTemperature" |> NamespacedName

    /// <summary>
    /// This property indicates the heartbeat of a PhysiologicalState
    /// <see href="http://softeng.polito.it/rsctx#heartbeat"></see></summary>
    let heartbeat = Namespaced_IRI.parse _namespace_name "heartbeat" |> NamespacedName
    /// <summary>
    /// This property indicates if a Time is holiday or a working day.
    /// <see href="http://softeng.polito.it/rsctx#holiday"></see></summary>
    let holiday = Namespaced_IRI.parse _namespace_name "holiday" |> NamespacedName
    /// <summary>
    /// This property indicates the hour which a Time is included.
    /// <see href="http://softeng.polito.it/rsctx#hour"></see></summary>
    let hour = Namespaced_IRI.parse _namespace_name "hour" |> NamespacedName
    /// <summary>
    /// This property indicates the injury of a PhysiologicalState
    /// <see href="http://softeng.polito.it/rsctx#injury"></see></summary>
    let injury = Namespaced_IRI.parse _namespace_name "injury" |> NamespacedName
    /// <summary>
    /// It indicates a LightLevel.
    /// <see href="http://softeng.polito.it/rsctx#lightLevel"></see></summary>
    let lightLevel = Namespaced_IRI.parse _namespace_name "lightLevel" |> NamespacedName
    /// <summary>
    /// It indicates the light level in lux.
    /// <see href="http://softeng.polito.it/rsctx#lighting"></see></summary>
    let lighting = Namespaced_IRI.parse _namespace_name "lighting" |> NamespacedName

    /// <summary>
    /// It indicates the Municipality of a Location.
    /// <see href="http://softeng.polito.it/rsctx#municipality"></see></summary>
    let municipality =
        Namespaced_IRI.parse _namespace_name "municipality" |> NamespacedName

    /// <summary>
    /// It indicates the Neighborhood of a Location.
    /// <see href="http://softeng.polito.it/rsctx#neighborhood"></see></summary>
    let neighborhood =
        Namespaced_IRI.parse _namespace_name "neighborhood" |> NamespacedName

    /// <summary>
    /// It indicates the noise in decibel.
    /// <see href="http://softeng.polito.it/rsctx#noise"></see></summary>
    let noise = Namespaced_IRI.parse _namespace_name "noise" |> NamespacedName
    /// <summary>
    /// It indicates a NoiseLevel
    /// <see href="http://softeng.polito.it/rsctx#noiseLevel"></see></summary>
    let noiseLevel = Namespaced_IRI.parse _namespace_name "noiseLevel" |> NamespacedName

    /// <summary>
    /// This property indicates the nourishment (in BMI) of a PhysiologicalState.
    /// <see href="http://softeng.polito.it/rsctx#nourishment"></see></summary>
    let nourishment =
        Namespaced_IRI.parse _namespace_name "nourishment" |> NamespacedName

    /// <summary>
    /// It indicates the Parish of a Location.
    /// parish
    /// <see href="http://softeng.polito.it/rsctx#parish"></see></summary>
    let parish = Namespaced_IRI.parse _namespace_name "parish" |> NamespacedName
    /// <summary>
    /// This property indicates part of the day in which a Time is included in.
    /// <see href="http://softeng.polito.it/rsctx#partOfDay"></see></summary>
    let partOfDay = Namespaced_IRI.parse _namespace_name "partOfDay" |> NamespacedName

    /// <summary>
    /// This property indicates the perspiration (in liters per hours) of a PhysiologicalState.
    /// <see href="http://softeng.polito.it/rsctx#perspiration"></see></summary>
    let perspiration =
        Namespaced_IRI.parse _namespace_name "perspiration" |> NamespacedName

    /// <summary>
    /// The property associates a POI to a prissma:Environment
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:poi should be used.
    /// <see href="http://softeng.polito.it/rsctx#poi"></see></summary>
    let poi = Namespaced_IRI.parse _namespace_name "poi" |> NamespacedName
    /// <summary>
    /// It indicates the Proince of a Location.
    /// province
    /// <see href="http://softeng.polito.it/rsctx#province"></see></summary>
    let province = Namespaced_IRI.parse _namespace_name "province" |> NamespacedName

    /// <summary>
    /// This property indicates the pupil dilation (in mm) of a PhysiologicalState.
    /// <see href="http://softeng.polito.it/rsctx#pupilsDilation"></see></summary>
    let pupilsDilation =
        Namespaced_IRI.parse _namespace_name "pupilsDilation" |> NamespacedName

    /// <summary>
    /// It indicates the Region of a Location.
    /// <see href="http://softeng.polito.it/rsctx#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName

    /// <summary>
    /// This property indicates the respiration of a PhysiologicalState (in breaths per minute).
    /// <see href="http://softeng.polito.it/rsctx#respiration"></see></summary>
    let respiration =
        Namespaced_IRI.parse _namespace_name "respiration" |> NamespacedName

    /// <summary>
    /// It indicates the Room of a Location.
    /// <see href="http://softeng.polito.it/rsctx#room"></see></summary>
    let room = Namespaced_IRI.parse _namespace_name "room" |> NamespacedName
    /// <summary>
    /// It indicates the season in which a Time is included in.
    /// <see href="http://softeng.polito.it/rsctx#season"></see></summary>
    let season = Namespaced_IRI.parse _namespace_name "season" |> NamespacedName

    /// <summary>
    /// It indicates the second level administrative division of a Location.
    /// <see href="http://softeng.polito.it/rsctx#secondLevelAdministrativeDivision"></see></summary>
    let secondLevelAdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "secondLevelAdministrativeDivision" |> NamespacedName

    /// <summary>
    /// It indicates the Site of a Location.
    /// <see href="http://softeng.polito.it/rsctx#site"></see></summary>
    let site = Namespaced_IRI.parse _namespace_name "site" |> NamespacedName
    /// <summary>
    /// It indicates the Street of a Location.
    /// <see href="http://softeng.polito.it/rsctx#street"></see></summary>
    let street = Namespaced_IRI.parse _namespace_name "street" |> NamespacedName

    /// <summary>
    /// It indicates to which symbolic location that POI corresponds to (if any), such as the home or the workplace of the user or a public place (e.g. a cinema).
    /// <see href="http://softeng.polito.it/rsctx#symbolicLocation"></see></summary>
    let symbolicLocation =
        Namespaced_IRI.parse _namespace_name "symbolicLocation" |> NamespacedName

    /// <summary>
    /// It indicates the third level administrative division of a Location.
    /// <see href="http://softeng.polito.it/rsctx#thirdLevelAdministrativeDivision"></see></summary>
    let thirdLevelAdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "thirdLevelAdministrativeDivision" |> NamespacedName

    /// <summary>
    /// It indicates the time associated to the Environment.
    /// <see href="http://softeng.polito.it/rsctx#time"></see></summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName

    /// <summary>
    /// It indicates a TrafficLevel
    /// <see href="http://softeng.polito.it/rsctx#trafficLevel"></see></summary>
    let trafficLevel =
        Namespaced_IRI.parse _namespace_name "trafficLevel" |> NamespacedName

    /// <summary>
    /// It indicates which TransportationMean the user is using or is going to use.
    /// <see href="http://softeng.polito.it/rsctx#transportationMean"></see></summary>
    let transportationMean =
        Namespaced_IRI.parse _namespace_name "transportationMean" |> NamespacedName

    /// <summary>
    /// The property associates a User to a Context.
    ///
    /// WARNING It is useful only if we need the property being functional, otherwise prissma:user should be used.
    /// <see href="http://softeng.polito.it/rsctx#user"></see></summary>
    let user = Namespaced_IRI.parse _namespace_name "user" |> NamespacedName
    /// <summary>
    /// It indicates the weather associated to the current context.
    /// <see href="http://softeng.polito.it/rsctx#weather"></see></summary>
    let weather = Namespaced_IRI.parse _namespace_name "weather" |> NamespacedName
