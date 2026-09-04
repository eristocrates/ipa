#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module caresses =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://caressesrobot.org/ontology#" "caresses"

    /// <summary>
    ///   <para>rdfs:comment : Actions that may be executed by the robot. Actions are associate to parameters (Volume, Pitch, Speed, Language), to the username (Name), to the Suggestions (Topic).</para>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Action</para>
    ///   <a href="http://caressesrobot.org/ontology#Action">caresses:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Actor</para>
    ///   <a href="http://caressesrobot.org/ontology#Actor">caresses:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Addressing</para>
    ///   <para>rdfs:comment : Possible ways to address the user. In the context of the verbal interaction between the robot and the user, this conversation topic will be probably selected among the firsts (this is implemented by the ObjectProperty hasTriggeringCondition). Examples of subclasses may be: FirstName, MrLastName, MrsLastName, Nickname, ...
    ///
    /// The DataProperty hasNameforPlanner describes how the robot should actually address the person, and its value is usually encoded in a User-Specific Individual (E.g. for the class FirstName, the DataProperty hasNameforPlanner will include the actual first name of the user)</para>
    ///   <a href="http://caressesrobot.org/ontology#Addressing">caresses:Addressing</a>
    /// </summary>
    let Addressing = _prefixId.prefix "Addressing"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : AmusementPlace</para>
    ///   <a href="http://caressesrobot.org/ontology#AmusementPlace">caresses:AmusementPlace</a>
    /// </summary>
    let AmusementPlace = _prefixId.prefix "AmusementPlace"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Appliance</para>
    ///   <a href="http://caressesrobot.org/ontology#Appliance">caresses:Appliance</a>
    /// </summary>
    let Appliance = _prefixId.prefix "Appliance"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : ArtObject</para>
    ///   <para>rdfs:comment : An abstract or physical object considered to fulfill a primarily independent aesthetic function.</para>
    ///   <a href="http://caressesrobot.org/ontology#ArtObject">caresses:ArtObject</a>
    /// </summary>
    let ArtObject = _prefixId.prefix "ArtObject"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Atheism</para>
    ///   <para>rdfs:comment : Lack of belief in gods and religions</para>
    ///   <a href="http://caressesrobot.org/ontology#Atheism">caresses:Atheism</a>
    /// </summary>
    let Atheism = _prefixId.prefix "Atheism"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : BeliefSystem</para>
    ///   <para>rdfs:comment : Ideology or set of principles. It is mainly intended in the form of religion.
    ///
    /// Individuals of this class may be related to Individuals of the class ReligiousCulturalEvent; thus, known the user's religion, the robot would probably talk about related religious festivities.</para>
    ///   <a href="http://caressesrobot.org/ontology#BeliefSystem">caresses:BeliefSystem</a>
    /// </summary>
    let BeliefSystem = _prefixId.prefix "BeliefSystem"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Birthday</para>
    ///   <a href="http://caressesrobot.org/ontology#Birthday">caresses:Birthday</a>
    /// </summary>
    let Birthday = _prefixId.prefix "Birthday"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Book</para>
    ///   <a href="http://caressesrobot.org/ontology#Book">caresses:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : CallMode</para>
    ///   <para>rdfs:comment : Parameter for the VideoCall action (Audio or Video call)</para>
    ///   <a href="http://caressesrobot.org/ontology#CallMode">caresses:CallMode</a>
    /// </summary>
    let CallMode = _prefixId.prefix "CallMode"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : CelebratingEvents</para>
    ///   <para>rdfs:comment : The habit of celebrating events (holidays, festivities, ... )</para>
    ///   <a href="http://caressesrobot.org/ontology#CelebratingEvents">caresses:CelebratingEvents</a>
    /// </summary>
    let CelebratingEvents = _prefixId.prefix "CelebratingEvents"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Childhood</para>
    ///   <a href="http://caressesrobot.org/ontology#Childhood">caresses:Childhood</a>
    /// </summary>
    let Childhood = _prefixId.prefix "Childhood"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : CircleOfFriend</para>
    ///   <a href="http://caressesrobot.org/ontology#CircleOfFriend">caresses:CircleOfFriend</a>
    /// </summary>
    let CircleOfFriend = _prefixId.prefix "CircleOfFriend"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Clothing</para>
    ///   <a href="http://caressesrobot.org/ontology#Clothing">caresses:Clothing</a>
    /// </summary>
    let Clothing = _prefixId.prefix "Clothing"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Country</para>
    ///   <para>rdfs:comment : A nation with its own government</para>
    ///   <a href="http://caressesrobot.org/ontology#Country">caresses:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : DailyRoutine</para>
    ///   <para>rdfs:comment : Action or sequence of actions that are daily executed by the user. Possible Subclasses are: DoingPhysicalExercises, GettingDressed, HavingMeal, TakingMedicine, TakingCareOfOneself, and many others</para>
    ///   <a href="http://caressesrobot.org/ontology#DailyRoutine">caresses:DailyRoutine</a>
    /// </summary>
    let DailyRoutine = _prefixId.prefix "DailyRoutine"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Dance</para>
    ///   <a href="http://caressesrobot.org/ontology#Dance">caresses:Dance</a>
    /// </summary>
    let Dance = _prefixId.prefix "Dance"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : DayOfTheWeek</para>
    ///   <a href="http://caressesrobot.org/ontology#DayOfTheWeek">caresses:DayOfTheWeek</a>
    /// </summary>
    let DayOfTheWeek = _prefixId.prefix "DayOfTheWeek"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : DeathOfAClosePerson</para>
    ///   <a href="http://caressesrobot.org/ontology#DeathOfAClosePerson">caresses:DeathOfAClosePerson</a>
    /// </summary>
    let DeathOfAClosePerson = _prefixId.prefix "DeathOfAClosePerson"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Decoration</para>
    ///   <a href="http://caressesrobot.org/ontology#Decoration">caresses:Decoration</a>
    /// </summary>
    let Decoration = _prefixId.prefix "Decoration"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Drink</para>
    ///   <a href="http://caressesrobot.org/ontology#Drink">caresses:Drink</a>
    /// </summary>
    let Drink = _prefixId.prefix "Drink"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : EatingPlace</para>
    ///   <a href="http://caressesrobot.org/ontology#EatingPlace">caresses:EatingPlace</a>
    /// </summary>
    let EatingPlace = _prefixId.prefix "EatingPlace"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Education</para>
    ///   <a href="http://caressesrobot.org/ontology#Education">caresses:Education</a>
    /// </summary>
    let Education = _prefixId.prefix "Education"
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : A thing that has happened, or that takes place with regularity, independently from the user's activity</para>
    ///   <a href="http://caressesrobot.org/ontology#Event">caresses:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Family</para>
    ///   <a href="http://caressesrobot.org/ontology#Family">caresses:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : FeelingBad</para>
    ///   <para>rdfs:comment : Possible Subclasses are FeelingAfraid, FeelingAngry, FeelingLonely, FeelingWorried, ...</para>
    ///   <a href="http://caressesrobot.org/ontology#FeelingBad">caresses:FeelingBad</a>
    /// </summary>
    let FeelingBad = _prefixId.prefix "FeelingBad"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : FeelingWell</para>
    ///   <para>rdfs:comment : Possible Subclasses are FeelingExcited, FeelingHappy, FeelingRelaxed, FeelingStrong, ...</para>
    ///   <a href="http://caressesrobot.org/ontology#FeelingWell">caresses:FeelingWell</a>
    /// </summary>
    let FeelingWell = _prefixId.prefix "FeelingWell"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Food</para>
    ///   <a href="http://caressesrobot.org/ontology#Food">caresses:Food</a>
    /// </summary>
    let Food = _prefixId.prefix "Food"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : FoodAndDrink</para>
    ///   <a href="http://caressesrobot.org/ontology#FoodAndDrink">caresses:FoodAndDrink</a>
    /// </summary>
    let FoodAndDrink = _prefixId.prefix "FoodAndDrink"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : FoodNorm</para>
    ///   <para>rdfs:comment : Dietary restrictions, that may be related to religious or ethical aspects. Possible Subclasses are EatingHalal, EatingKosher, EatingVegetarian, ...</para>
    ///   <a href="http://caressesrobot.org/ontology#FoodNorm">caresses:FoodNorm</a>
    /// </summary>
    let FoodNorm = _prefixId.prefix "FoodNorm"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Frequency</para>
    ///   <a href="http://caressesrobot.org/ontology#Frequency">caresses:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Friend</para>
    ///   <a href="http://caressesrobot.org/ontology#Friend">caresses:Friend</a>
    /// </summary>
    let Friend = _prefixId.prefix "Friend"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Furniture</para>
    ///   <a href="http://caressesrobot.org/ontology#Furniture">caresses:Furniture</a>
    /// </summary>
    let Furniture = _prefixId.prefix "Furniture"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Game</para>
    ///   <a href="http://caressesrobot.org/ontology#Game">caresses:Game</a>
    /// </summary>
    let Game = _prefixId.prefix "Game"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Goal</para>
    ///   <para>rdfs:comment : The DataProperty hasPDDL encode the related string, in PDDL formalism, that should be sent to the planner when the goal is required</para>
    ///   <a href="http://caressesrobot.org/ontology#Goal">caresses:Goal</a>
    /// </summary>
    let Goal = _prefixId.prefix "Goal"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Habit</para>
    ///   <para>rdfs:comment : Activities, routines or behaviors that are regularly repeated by the user.
    ///
    /// Individuals of this class may be filled with Individuals to the class Time for the ObjectProperty hasCondition (conversation topics may be triggered in some specific period of the day) or hasTime (the robot may investigate if habits take place in specific times of the day).</para>
    ///   <a href="http://caressesrobot.org/ontology#Habit">caresses:Habit</a>
    /// </summary>
    let Habit = _prefixId.prefix "Habit"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : HavingHealthProblems</para>
    ///   <para>rdfs:comment : The condition of having health problems can be related to medicines taken by the user</para>
    ///   <a href="http://caressesrobot.org/ontology#HavingHealthProblems">caresses:HavingHealthProblems</a>
    /// </summary>
    let HavingHealthProblems = _prefixId.prefix "HavingHealthProblems"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Heritage</para>
    ///   <a href="http://caressesrobot.org/ontology#Heritage">caresses:Heritage</a>
    /// </summary>
    let Heritage = _prefixId.prefix "Heritage"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : HistoricFactOrPeriod</para>
    ///   <para>rdfs:comment : Relevant facts in the areas of politics, military, science, music, sports, arts, entertainment, ...</para>
    ///   <a href="http://caressesrobot.org/ontology#HistoricFactOrPeriod">caresses:HistoricFactOrPeriod</a>
    /// </summary>
    let HistoricFactOrPeriod = _prefixId.prefix "HistoricFactOrPeriod"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Hobby</para>
    ///   <para>rdfs:comment : Activities done regularly in one's leisure time for pleasure. They may be chosen accordingly to the specific targets (i.e. older adults). Examples of SubClasses may be ReadingABook, WatchingAMovie, DoingSomeCooking, GoingToAClub, MakingHennaTattoos, ...</para>
    ///   <a href="http://caressesrobot.org/ontology#Hobby">caresses:Hobby</a>
    /// </summary>
    let Hobby = _prefixId.prefix "Hobby"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Home</para>
    ///   <para>rdfs:comment : The building where one lives. Examples of SubClasses are Apartment, CareHome (for the specific case of older adults to which the CARESSES Ontology is addressed)</para>
    ///   <a href="http://caressesrobot.org/ontology#Home">caresses:Home</a>
    /// </summary>
    let Home = _prefixId.prefix "Home"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Hour</para>
    ///   <a href="http://caressesrobot.org/ontology#Hour">caresses:Hour</a>
    /// </summary>
    let Hour = _prefixId.prefix "Hour"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : HouseObject</para>
    ///   <a href="http://caressesrobot.org/ontology#HouseObject">caresses:HouseObject</a>
    /// </summary>
    let HouseObject = _prefixId.prefix "HouseObject"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Kitchenware</para>
    ///   <a href="http://caressesrobot.org/ontology#Kitchenware">caresses:Kitchenware</a>
    /// </summary>
    let Kitchenware = _prefixId.prefix "Kitchenware"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Language</para>
    ///   <para>rdfs:comment : Parameter related to the language in which the sentences are written</para>
    ///   <a href="http://caressesrobot.org/ontology#Language">caresses:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : LivingPlace</para>
    ///   <a href="http://caressesrobot.org/ontology#LivingPlace">caresses:LivingPlace</a>
    /// </summary>
    let LivingPlace = _prefixId.prefix "LivingPlace"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : A physical space or region, defined by geographical coordinates (absolute location) or expressed in relative terms (relative location).</para>
    ///   <a href="http://caressesrobot.org/ontology#Location">caresses:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Manner</para>
    ///   <para>rdfs:comment : Definitions of polite or acceptable social behaviours. They may be chosen accordingly to the specific targets (i.e. older adults) and cultural identities. Examples of SubClasses are GivingPresentsToRelativeOrFriend, StackingDishesAfterMeal, ...</para>
    ///   <a href="http://caressesrobot.org/ontology#Manner">caresses:Manner</a>
    /// </summary>
    let Manner = _prefixId.prefix "Manner"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : MedicalStaff</para>
    ///   <a href="http://caressesrobot.org/ontology#MedicalStaff">caresses:MedicalStaff</a>
    /// </summary>
    let MedicalStaff = _prefixId.prefix "MedicalStaff"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Medication</para>
    ///   <a href="http://caressesrobot.org/ontology#Medication">caresses:Medication</a>
    /// </summary>
    let Medication = _prefixId.prefix "Medication"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Message</para>
    ///   <para>rdfs:comment : Messages encoded for the SendMsgAction</para>
    ///   <a href="http://caressesrobot.org/ontology#Message">caresses:Message</a>
    /// </summary>
    let Message = _prefixId.prefix "Message"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Movie</para>
    ///   <a href="http://caressesrobot.org/ontology#Movie">caresses:Movie</a>
    /// </summary>
    let Movie = _prefixId.prefix "Movie"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Music</para>
    ///   <a href="http://caressesrobot.org/ontology#Music">caresses:Music</a>
    /// </summary>
    let Music = _prefixId.prefix "Music"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Norm</para>
    ///   <para>rdfs:comment : Guidelines about what is considered correct or incorrect speaking of social behavior in a particular group, social unit or cultural identities.</para>
    ///   <a href="http://caressesrobot.org/ontology#Norm">caresses:Norm</a>
    /// </summary>
    let Norm = _prefixId.prefix "Norm"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Object</para>
    ///   <para>rdfs:comment : Abstracts objects, with no physical referents and that does not exist at any particular time or place, and concrete objects</para>
    ///   <a href="http://caressesrobot.org/ontology#Object">caresses:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Operator</para>
    ///   <para>rdfs:comment : This class includes all Operators that should  be sent to the planner for the execution of actions. Operators achieve Goals by implementing Actions</para>
    ///   <a href="http://caressesrobot.org/ontology#Operator">caresses:Operator</a>
    /// </summary>
    let Operator = _prefixId.prefix "Operator"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Parameter</para>
    ///   <para>rdfs:comment : Parameters associated to actions</para>
    ///   <a href="http://caressesrobot.org/ontology#Parameter">caresses:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : PeriodOfTheDay</para>
    ///   <a href="http://caressesrobot.org/ontology#PeriodOfTheDay">caresses:PeriodOfTheDay</a>
    /// </summary>
    let PeriodOfTheDay = _prefixId.prefix "PeriodOfTheDay"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : Persons in the social, physical and cultural environemnt of the user</para>
    ///   <a href="http://caressesrobot.org/ontology#Person">caresses:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : PersonalCareObject</para>
    ///   <a href="http://caressesrobot.org/ontology#PersonalCareObject">caresses:PersonalCareObject</a>
    /// </summary>
    let PersonalCareObject = _prefixId.prefix "PersonalCareObject"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Pet</para>
    ///   <a href="http://caressesrobot.org/ontology#Pet">caresses:Pet</a>
    /// </summary>
    let Pet = _prefixId.prefix "Pet"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : PhysicalAndMentalCondition</para>
    ///   <para>rdfs:comment : The condition or state of the body or mind</para>
    ///   <a href="http://caressesrobot.org/ontology#PhysicalAndMentalCondition">caresses:PhysicalAndMentalCondition</a>
    /// </summary>
    let PhysicalAndMentalCondition = _prefixId.prefix "PhysicalAndMentalCondition"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : PhysicalEnvironment</para>
    ///   <para>rdfs:comment : All tangible space regiones that support and influence the user's life</para>
    ///   <a href="http://caressesrobot.org/ontology#PhysicalEnvironment">caresses:PhysicalEnvironment</a>
    /// </summary>
    let PhysicalEnvironment = _prefixId.prefix "PhysicalEnvironment"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Pitch</para>
    ///   <para>rdfs:comment : Voice pitch for all actions involving verbal interaction</para>
    ///   <a href="http://caressesrobot.org/ontology#Pitch">caresses:Pitch</a>
    /// </summary>
    let Pitch = _prefixId.prefix "Pitch"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Proxemics</para>
    ///   <para>rdfs:comment : Distance parameter for the ApproachUser action</para>
    ///   <a href="http://caressesrobot.org/ontology#Proxemics">caresses:Proxemics</a>
    /// </summary>
    let Proxemics = _prefixId.prefix "Proxemics"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : PublicPerson</para>
    ///   <a href="http://caressesrobot.org/ontology#PublicPerson">caresses:PublicPerson</a>
    /// </summary>
    let PublicPerson = _prefixId.prefix "PublicPerson"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Quality</para>
    ///   <para>rdfs:comment : Basic entities to perceive or measure: shapes, colors, sizes, sounds, smells,...</para>
    ///   <a href="http://caressesrobot.org/ontology#Quality">caresses:Quality</a>
    /// </summary>
    let Quality = _prefixId.prefix "Quality"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Relative</para>
    ///   <a href="http://caressesrobot.org/ontology#Relative">caresses:Relative</a>
    /// </summary>
    let Relative = _prefixId.prefix "Relative"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : RelativeLocation</para>
    ///   <para>rdfs:comment : The position of something expressed in relative terms (e.g. Close, Far, VeryFar, ... )</para>
    ///   <a href="http://caressesrobot.org/ontology#RelativeLocation">caresses:RelativeLocation</a>
    /// </summary>
    let RelativeLocation = _prefixId.prefix "RelativeLocation"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Religion</para>
    ///   <para>rdfs:comment : Individuals of this class may be filled with Individuals of the class FoodNorm for the ObjectProperty hasNorm; thus, known the user's religion, the robot would probably investigate aspects related to possible alimentary restrictions
    ///
    /// Individuals of this class may be filled with Individuals of the class ReligiousCulturalEvent for the ObjectProperty hasEvent; thus, known the user's religion, the robot would probably talk about related religious festivities.</para>
    ///   <a href="http://caressesrobot.org/ontology#Religion">caresses:Religion</a>
    /// </summary>
    let Religion = _prefixId.prefix "Religion"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : ReligiousCulturalEvent</para>
    ///   <para>rdfs:comment : Any event related to religious celebrations</para>
    ///   <a href="http://caressesrobot.org/ontology#ReligiousCulturalEvent">caresses:ReligiousCulturalEvent</a>
    /// </summary>
    let ReligiousCulturalEvent = _prefixId.prefix "ReligiousCulturalEvent"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Robot</para>
    ///   <para>rdfs:comment : The user's robot . An instance of the class Robot may be connected with instances of the class Goal, in order to encode all goals that may be achieved by the robot</para>
    ///   <a href="http://caressesrobot.org/ontology#Robot">caresses:Robot</a>
    /// </summary>
    let Robot = _prefixId.prefix "Robot"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Room</para>
    ///   <a href="http://caressesrobot.org/ontology#Room">caresses:Room</a>
    /// </summary>
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Season</para>
    ///   <a href="http://caressesrobot.org/ontology#Season">caresses:Season</a>
    /// </summary>
    let Season = _prefixId.prefix "Season"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : ShoppingPlace</para>
    ///   <a href="http://caressesrobot.org/ontology#ShoppingPlace">caresses:ShoppingPlace</a>
    /// </summary>
    let ShoppingPlace = _prefixId.prefix "ShoppingPlace"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Singer</para>
    ///   <a href="http://caressesrobot.org/ontology#Singer">caresses:Singer</a>
    /// </summary>
    let Singer = _prefixId.prefix "Singer"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : SleepingPlace</para>
    ///   <a href="http://caressesrobot.org/ontology#SleepingPlace">caresses:SleepingPlace</a>
    /// </summary>
    let SleepingPlace = _prefixId.prefix "SleepingPlace"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : SmartDevice</para>
    ///   <a href="http://caressesrobot.org/ontology#SmartDevice">caresses:SmartDevice</a>
    /// </summary>
    let SmartDevice = _prefixId.prefix "SmartDevice"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : SocialEnvironment</para>
    ///   <para>rdfs:comment : Social relationships that influence the user's life (friends, family, ...)</para>
    ///   <a href="http://caressesrobot.org/ontology#SocialEnvironment">caresses:SocialEnvironment</a>
    /// </summary>
    let SocialEnvironment = _prefixId.prefix "SocialEnvironment"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : SocialEvent</para>
    ///   <para>rdfs:comment : Any occasion/event that involves social interaction.</para>
    ///   <a href="http://caressesrobot.org/ontology#SocialEvent">caresses:SocialEvent</a>
    /// </summary>
    let SocialEvent = _prefixId.prefix "SocialEvent"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Song</para>
    ///   <a href="http://caressesrobot.org/ontology#Song">caresses:Song</a>
    /// </summary>
    let Song = _prefixId.prefix "Song"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Speed</para>
    ///   <para>rdfs:comment : Voice speed for all actions involving verbal interaction</para>
    ///   <a href="http://caressesrobot.org/ontology#Speed">caresses:Speed</a>
    /// </summary>
    let Speed = _prefixId.prefix "Speed"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Sport</para>
    ///   <a href="http://caressesrobot.org/ontology#Sport">caresses:Sport</a>
    /// </summary>
    let Sport = _prefixId.prefix "Sport"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : SportsPlayer</para>
    ///   <a href="http://caressesrobot.org/ontology#SportsPlayer">caresses:SportsPlayer</a>
    /// </summary>
    let SportsPlayer = _prefixId.prefix "SportsPlayer"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : TVChannel</para>
    ///   <a href="http://caressesrobot.org/ontology#TVChannel">caresses:TVChannel</a>
    /// </summary>
    let TVChannel = _prefixId.prefix "TVChannel"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Time</para>
    ///   <a href="http://caressesrobot.org/ontology#Time">caresses:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : TimeFormat</para>
    ///   <para>rdfs:comment : 12 hr or 24hr</para>
    ///   <a href="http://caressesrobot.org/ontology#TimeFormat">caresses:TimeFormat</a>
    /// </summary>
    let TimeFormat = _prefixId.prefix "TimeFormat"
    /// <summary>
    ///   <para>rdfs:comment : Conversation topics that may be explored by the robot.
    ///
    /// Conversation topics are defined by a set of DataProperties:
    /// - hasLikeliness (it reflects the probability that the user will have a positive attitude towards that topic, given his cultural identity (if the instance belong to the Culture-Specific ABox), or given the evidence collected through the interaction with the user (if the instance belong to the Person-Specific ABox).
    /// - hasQuestion (encoded sentences used by the robot to ask the general user's feeback about the topic)
    /// - hasQuestionContextual (encoded sentences used by the robot to ask the user's feedback related to the specific context)
    /// - hasQuestionGoal (encoded sentences used by the robot to ask the user about activities to be performed)
    /// - has PositiveSentence (encoded sentences used by the robot when a positive feedback is received)
    /// - has PositiveAndWait (encoded sentences used by the robot when a positive feedback is received. With these sentences, the robot invites the user to freely talk about a conversation topic)
    /// - hasNegativeSentence (encoded sentences used by the robot when a negative feedback is received)
    /// - hasKeyword1 &amp; hasKeyword2 (keywords that may trigger a conversation topic)
    ///
    /// Culture-specific instances of subclasses of Topic may be filled with Person-specific instances for the hasSpecific ObjectProperty</para>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Topic</para>
    ///   <a href="http://caressesrobot.org/ontology#Topic">caresses:Topic</a>
    /// </summary>
    let Topic = _prefixId.prefix "Topic"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : TopicAboutOnesLife</para>
    ///   <para>rdfs:comment : Relevant facts for the user's past and present life (chilldhood, education, heritage, work, ...)</para>
    ///   <a href="http://caressesrobot.org/ontology#TopicAboutOnesLife">caresses:TopicAboutOnesLife</a>
    /// </summary>
    let TopicAboutOnesLife = _prefixId.prefix "TopicAboutOnesLife"

    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : TopicOneCanHavePreferenceAbout</para>
    ///   <para>rdfs:comment : All things that may be expressed in terms of "preference" (e.g. what is your favourite ... ?)</para>
    ///   <a href="http://caressesrobot.org/ontology#TopicOneCanHavePreferenceAbout">caresses:TopicOneCanHavePreferenceAbout</a>
    /// </summary>
    let TopicOneCanHavePreferenceAbout =
        _prefixId.prefix "TopicOneCanHavePreferenceAbout"

    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Town</para>
    ///   <a href="http://caressesrobot.org/ontology#Town">caresses:Town</a>
    /// </summary>
    let Town = _prefixId.prefix "Town"
    /// <summary>
    ///   <para>rdfs:comment : Person to which the user-specific information of the Ontology refers</para>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : User</para>
    ///   <a href="http://caressesrobot.org/ontology#User">caresses:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Volume</para>
    ///   <para>rdfs:comment : Voice volume for all actions involving verbal interaction</para>
    ///   <a href="http://caressesrobot.org/ontology#Volume">caresses:Volume</a>
    /// </summary>
    let Volume = _prefixId.prefix "Volume"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : WaitingTime</para>
    ///   <para>rdfs:comment : Waiting Time parameter for the AcceptRequest Action</para>
    ///   <a href="http://caressesrobot.org/ontology#WaitingTime">caresses:WaitingTime</a>
    /// </summary>
    let WaitingTime = _prefixId.prefix "WaitingTime"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Work</para>
    ///   <a href="http://caressesrobot.org/ontology#Work">caresses:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Writer</para>
    ///   <a href="http://caressesrobot.org/ontology#Writer">caresses:Writer</a>
    /// </summary>
    let Writer = _prefixId.prefix "Writer"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : YearlyEvent</para>
    ///   <para>rdfs:comment : Any event that takes place regularly every year</para>
    ///   <a href="http://caressesrobot.org/ontology#YearlyEvent">caresses:YearlyEvent</a>
    /// </summary>
    let YearlyEvent = _prefixId.prefix "YearlyEvent"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasAction</para>
    ///   <para>rdfs:comment : A relation that holds between Operators and Actions</para>
    ///   <a href="http://caressesrobot.org/ontology#hasAction">caresses:hasAction</a>
    /// </summary>
    let hasAction = _prefixId.prefix "hasAction"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasActor</para>
    ///   <a href="http://caressesrobot.org/ontology#hasActor">caresses:hasActor</a>
    /// </summary>
    let hasActor = _prefixId.prefix "hasActor"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasAddressing</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about possible ways to address the user</para>
    ///   <a href="http://caressesrobot.org/ontology#hasAddressing">caresses:hasAddressing</a>
    /// </summary>
    let hasAddressing = _prefixId.prefix "hasAddressing"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasAdjacent</para>
    ///   <para>rdfs:comment : Relationship of closeness between Objects and/or Locations</para>
    ///   <a href="http://caressesrobot.org/ontology#hasAdjacent">caresses:hasAdjacent</a>
    /// </summary>
    let hasAdjacent = _prefixId.prefix "hasAdjacent"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasAs-sensor</para>
    ///   <para>rdfs:comment : String for automatically composing sentences. It refers to Smart Devices</para>
    ///   <a href="http://caressesrobot.org/ontology#hasAs-sensor">caresses:hasAs-sensor</a>
    /// </summary>
    let hasAs_sensor = _prefixId.prefix "hasAs-sensor"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasBeliefAndValue</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about user's beliefs and values</para>
    ///   <a href="http://caressesrobot.org/ontology#hasBeliefAndValue">caresses:hasBeliefAndValue</a>
    /// </summary>
    let hasBeliefAndValue = _prefixId.prefix "hasBeliefAndValue"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasCParameter</para>
    ///   <para>rdfs:comment : Cultural Parameters to be associated to Actions</para>
    ///   <a href="http://caressesrobot.org/ontology#hasCParameter">caresses:hasCParameter</a>
    /// </summary>
    let hasCParameter = _prefixId.prefix "hasCParameter"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasCloth</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about the user's clothes</para>
    ///   <a href="http://caressesrobot.org/ontology#hasCloth">caresses:hasCloth</a>
    /// </summary>
    let hasCloth = _prefixId.prefix "hasCloth"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasCompulsory-recipient</para>
    ///   <para>rdfs:comment : Compulsory recipient for related messages.</para>
    ///   <a href="http://caressesrobot.org/ontology#hasCompulsory-recipient">caresses:hasCompulsory-recipient</a>
    /// </summary>
    let hasCompulsory_recipient = _prefixId.prefix "hasCompulsory-recipient"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasCondition</para>
    ///   <a href="http://caressesrobot.org/ontology#hasCondition">caresses:hasCondition</a>
    /// </summary>
    let hasCondition = _prefixId.prefix "hasCondition"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasConfFile1</para>
    ///   <para>rdfs:comment : The individual filler of this property is used for building the configuration files for the related action</para>
    ///   <a href="http://caressesrobot.org/ontology#hasConfFile1">caresses:hasConfFile1</a>
    /// </summary>
    let hasConfFile1 = _prefixId.prefix "hasConfFile1"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasConfFile1Name</para>
    ///   <para>rdfs:comment : Configuration file for actions</para>
    ///   <a href="http://caressesrobot.org/ontology#hasConfFile1Name">caresses:hasConfFile1Name</a>
    /// </summary>
    let hasConfFile1Name = _prefixId.prefix "hasConfFile1Name"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasConfFile2</para>
    ///   <para>rdfs:comment : The individual filler of this property is used for building the configuration files for the related action</para>
    ///   <a href="http://caressesrobot.org/ontology#hasConfFile2">caresses:hasConfFile2</a>
    /// </summary>
    let hasConfFile2 = _prefixId.prefix "hasConfFile2"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasConfFile2Name</para>
    ///   <para>rdfs:comment : Configuration file for actions</para>
    ///   <a href="http://caressesrobot.org/ontology#hasConfFile2Name">caresses:hasConfFile2Name</a>
    /// </summary>
    let hasConfFile2Name = _prefixId.prefix "hasConfFile2Name"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasConfirmation</para>
    ///   <para>rdfs:comment : Confirmation sentence before launching a goal</para>
    ///   <a href="http://caressesrobot.org/ontology#hasConfirmation">caresses:hasConfirmation</a>
    /// </summary>
    let hasConfirmation = _prefixId.prefix "hasConfirmation"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasCoordinates</para>
    ///   <para>rdfs:comment : Coordinates of objects in the environment</para>
    ///   <a href="http://caressesrobot.org/ontology#hasCoordinates">caresses:hasCoordinates</a>
    /// </summary>
    let hasCoordinates = _prefixId.prefix "hasCoordinates"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasCorrelation</para>
    ///   <para>rdfs:comment : Correlations between Individuals, even belonging to different Classes. An HCorrelation implies that, if a UserSpecific instances with an high DataProperty HasLikeliness value is added, the hasLiklelines of the other individuals should be increased. A VLCorrelation impliease that if a UserSpecific instances with an high DataProperty HasLikeliness value is added, the hasLiklelines of the other individuals should be decreased.</para>
    ///   <a href="http://caressesrobot.org/ontology#hasCorrelation">caresses:hasCorrelation</a>
    /// </summary>
    let hasCorrelation = _prefixId.prefix "hasCorrelation"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasCountry</para>
    ///   <a href="http://caressesrobot.org/ontology#hasCountry">caresses:hasCountry</a>
    /// </summary>
    let hasCountry = _prefixId.prefix "hasCountry"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasDistance</para>
    ///   <a href="http://caressesrobot.org/ontology#hasDistance">caresses:hasDistance</a>
    /// </summary>
    let hasDistance = _prefixId.prefix "hasDistance"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasEmail</para>
    ///   <para>rdfs:comment : E-mail address of contacts</para>
    ///   <a href="http://caressesrobot.org/ontology#hasEmail">caresses:hasEmail</a>
    /// </summary>
    let hasEmail = _prefixId.prefix "hasEmail"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasEvent</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about events relevant for the user's life</para>
    ///   <a href="http://caressesrobot.org/ontology#hasEvent">caresses:hasEvent</a>
    /// </summary>
    let hasEvent = _prefixId.prefix "hasEvent"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasFamily</para>
    ///   <a href="http://caressesrobot.org/ontology#hasFamily">caresses:hasFamily</a>
    /// </summary>
    let hasFamily = _prefixId.prefix "hasFamily"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasFeeling</para>
    ///   <a href="http://caressesrobot.org/ontology#hasFeeling">caresses:hasFeeling</a>
    /// </summary>
    let hasFeeling = _prefixId.prefix "hasFeeling"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasFood</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about food</para>
    ///   <a href="http://caressesrobot.org/ontology#hasFood">caresses:hasFood</a>
    /// </summary>
    let hasFood = _prefixId.prefix "hasFood"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasFrequency</para>
    ///   <a href="http://caressesrobot.org/ontology#hasFrequency">caresses:hasFrequency</a>
    /// </summary>
    let hasFrequency = _prefixId.prefix "hasFrequency"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasFull</para>
    ///   <para>rdfs:comment : hasFull field for building configuration files of actions</para>
    ///   <a href="http://caressesrobot.org/ontology#hasFull">caresses:hasFull</a>
    /// </summary>
    let hasFull = _prefixId.prefix "hasFull"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasGame</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about games</para>
    ///   <a href="http://caressesrobot.org/ontology#hasGame">caresses:hasGame</a>
    /// </summary>
    let hasGame = _prefixId.prefix "hasGame"
    /// <summary>
    ///   <para>rdfs:label : hasGoal</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about possible activities</para>
    ///   <a href="http://caressesrobot.org/ontology#hasGoal">caresses:hasGoal</a>
    /// </summary>
    let hasGoal = _prefixId.prefix "hasGoal"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <a href="http://caressesrobot.org/ontology#hasHCorrelation">caresses:hasHCorrelation</a>
    /// </summary>
    let hasHCorrelation = _prefixId.prefix "hasHCorrelation"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasHabit</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about user's regular / periodical activities</para>
    ///   <a href="http://caressesrobot.org/ontology#hasHabit">caresses:hasHabit</a>
    /// </summary>
    let hasHabit = _prefixId.prefix "hasHabit"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasHealth</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about the user's health</para>
    ///   <a href="http://caressesrobot.org/ontology#hasHealth">caresses:hasHealth</a>
    /// </summary>
    let hasHealth = _prefixId.prefix "hasHealth"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasHealthProblem</para>
    ///   <a href="http://caressesrobot.org/ontology#hasHealthProblem">caresses:hasHealthProblem</a>
    /// </summary>
    let hasHealthProblem = _prefixId.prefix "hasHealthProblem"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasHome</para>
    ///   <a href="http://caressesrobot.org/ontology#hasHome">caresses:hasHome</a>
    /// </summary>
    let hasHome = _prefixId.prefix "hasHome"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasIn</para>
    ///   <para>rdfs:comment : Inclusion relationship between Objects and/or Location</para>
    ///   <a href="http://caressesrobot.org/ontology#hasIn">caresses:hasIn</a>
    /// </summary>
    let hasIn = _prefixId.prefix "hasIn"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasKeyword1</para>
    ///   <para>rdfs:comment : Triggering keyword for conversation topics</para>
    ///   <a href="http://caressesrobot.org/ontology#hasKeyword1">caresses:hasKeyword1</a>
    /// </summary>
    let hasKeyword1 = _prefixId.prefix "hasKeyword1"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasKeyword2</para>
    ///   <para>rdfs:comment : Triggering keyword for conversation topics</para>
    ///   <a href="http://caressesrobot.org/ontology#hasKeyword2">caresses:hasKeyword2</a>
    /// </summary>
    let hasKeyword2 = _prefixId.prefix "hasKeyword2"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasLanguage</para>
    ///   <a href="http://caressesrobot.org/ontology#hasLanguage">caresses:hasLanguage</a>
    /// </summary>
    let hasLanguage = _prefixId.prefix "hasLanguage"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasLife</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about the user's life</para>
    ///   <a href="http://caressesrobot.org/ontology#hasLife">caresses:hasLife</a>
    /// </summary>
    let hasLife = _prefixId.prefix "hasLife"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasLikeliness</para>
    ///   <para>rdfs:comment : Likeliness value for conversation topics. It corresponds to a reasonable estimate, to the best of available knowledge, of the a posteriori probability of the assertion.
    /// - In the Culture-Specific Layer, Likeliness values are used to specify how appropriate each instance is for the each culture, and guide the robot’s behaviour.
    /// - In the Person-Specific Layer, the likeliness corresponds to the evidence of the assertion collected through interaction with the user.</para>
    ///   <a href="http://caressesrobot.org/ontology#hasLikeliness">caresses:hasLikeliness</a>
    /// </summary>
    let hasLikeliness = _prefixId.prefix "hasLikeliness"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasLine</para>
    ///   <para>rdfs:comment : Line account of the user's contact</para>
    ///   <a href="http://caressesrobot.org/ontology#hasLine">caresses:hasLine</a>
    /// </summary>
    let hasLine = _prefixId.prefix "hasLine"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasLocation</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about places that are relevant for the user</para>
    ///   <a href="http://caressesrobot.org/ontology#hasLocation">caresses:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasLocations</para>
    ///   <para>rdfs:comment : Location of the smart device</para>
    ///   <a href="http://caressesrobot.org/ontology#hasLocations">caresses:hasLocations</a>
    /// </summary>
    let hasLocations = _prefixId.prefix "hasLocations"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <a href="http://caressesrobot.org/ontology#hasMCorrelation">caresses:hasMCorrelation</a>
    /// </summary>
    let hasMCorrelation = _prefixId.prefix "hasMCorrelation"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasManner</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about good manners</para>
    ///   <a href="http://caressesrobot.org/ontology#hasManner">caresses:hasManner</a>
    /// </summary>
    let hasManner = _prefixId.prefix "hasManner"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasMedicine</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about medicines relevant for the user</para>
    ///   <a href="http://caressesrobot.org/ontology#hasMedicine">caresses:hasMedicine</a>
    /// </summary>
    let hasMedicine = _prefixId.prefix "hasMedicine"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasMessage</para>
    ///   <para>rdfs:comment : Preloaded messages for the SendMessageAction</para>
    ///   <a href="http://caressesrobot.org/ontology#hasMessage">caresses:hasMessage</a>
    /// </summary>
    let hasMessage = _prefixId.prefix "hasMessage"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasMusic</para>
    ///   <a href="http://caressesrobot.org/ontology#hasMusic">caresses:hasMusic</a>
    /// </summary>
    let hasMusic = _prefixId.prefix "hasMusic"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasName</para>
    ///   <para>rdfs:comment : Field used to automatically generate sentences</para>
    ///   <a href="http://caressesrobot.org/ontology#hasName">caresses:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasNameforPlanner</para>
    ///   <para>rdfs:comment : String to be sent to the planner</para>
    ///   <a href="http://caressesrobot.org/ontology#hasNameforPlanner">caresses:hasNameforPlanner</a>
    /// </summary>
    let hasNameforPlanner = _prefixId.prefix "hasNameforPlanner"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasNecessaryCondition</para>
    ///   <para>rdfs:comment : Filler of this ObjectProperty is an Event or Time or Quality that allows the robot to talk about a specific topic</para>
    ///   <a href="http://caressesrobot.org/ontology#hasNecessaryCondition">caresses:hasNecessaryCondition</a>
    /// </summary>
    let hasNecessaryCondition = _prefixId.prefix "hasNecessaryCondition"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasNorm</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about social norms</para>
    ///   <a href="http://caressesrobot.org/ontology#hasNorm">caresses:hasNorm</a>
    /// </summary>
    let hasNorm = _prefixId.prefix "hasNorm"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasObject</para>
    ///   <para>rdfs:comment : Relationships between User and Objects</para>
    ///   <a href="http://caressesrobot.org/ontology#hasObject">caresses:hasObject</a>
    /// </summary>
    let hasObject = _prefixId.prefix "hasObject"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasOperations</para>
    ///   <para>rdfs:comment : Operations that can be executed with smart devices</para>
    ///   <a href="http://caressesrobot.org/ontology#hasOperations">caresses:hasOperations</a>
    /// </summary>
    let hasOperations = _prefixId.prefix "hasOperations"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasPDDL</para>
    ///   <para>rdfs:comment : Planning tasks (written in the PDDL formalism) that should be sent to the planner</para>
    ///   <a href="http://caressesrobot.org/ontology#hasPDDL">caresses:hasPDDL</a>
    /// </summary>
    let hasPDDL = _prefixId.prefix "hasPDDL"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasPerson</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about persons relevant for the user's life</para>
    ///   <a href="http://caressesrobot.org/ontology#hasPerson">caresses:hasPerson</a>
    /// </summary>
    let hasPerson = _prefixId.prefix "hasPerson"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasPet</para>
    ///   <a href="http://caressesrobot.org/ontology#hasPet">caresses:hasPet</a>
    /// </summary>
    let hasPet = _prefixId.prefix "hasPet"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasPhone</para>
    ///   <para>rdfs:comment : Phone number of user's contacts</para>
    ///   <a href="http://caressesrobot.org/ontology#hasPhone">caresses:hasPhone</a>
    /// </summary>
    let hasPhone = _prefixId.prefix "hasPhone"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasPhysicalAndMentalState</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about the physical and mental state of the user</para>
    ///   <a href="http://caressesrobot.org/ontology#hasPhysicalAndMentalState">caresses:hasPhysicalAndMentalState</a>
    /// </summary>
    let hasPhysicalAndMentalState = _prefixId.prefix "hasPhysicalAndMentalState"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasPhysicalEnvironment</para>
    ///   <a href="http://caressesrobot.org/ontology#hasPhysicalEnvironment">caresses:hasPhysicalEnvironment</a>
    /// </summary>
    let hasPhysicalEnvironment = _prefixId.prefix "hasPhysicalEnvironment"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasPitch</para>
    ///   <a href="http://caressesrobot.org/ontology#hasPitch">caresses:hasPitch</a>
    /// </summary>
    let hasPitch = _prefixId.prefix "hasPitch"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasPrep-object</para>
    ///   <para>rdfs:comment : Field used for automatically building sentences</para>
    ///   <a href="http://caressesrobot.org/ontology#hasPrep-object">caresses:hasPrep-object</a>
    /// </summary>
    let hasPrep_object = _prefixId.prefix "hasPrep-object"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasQuality</para>
    ///   <a href="http://caressesrobot.org/ontology#hasQuality">caresses:hasQuality</a>
    /// </summary>
    let hasQuality = _prefixId.prefix "hasQuality"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasQuestion-t</para>
    ///   <para>rdfs:comment : Question to be shown on the tablet</para>
    ///   <a href="http://caressesrobot.org/ontology#hasQuestion-t">caresses:hasQuestion-t</a>
    /// </summary>
    let hasQuestion_t = _prefixId.prefix "hasQuestion-t"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasRelatLocation</para>
    ///   <a href="http://caressesrobot.org/ontology#hasRelatLocation">caresses:hasRelatLocation</a>
    /// </summary>
    let hasRelatLocation = _prefixId.prefix "hasRelatLocation"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasRelative</para>
    ///   <a href="http://caressesrobot.org/ontology#hasRelative">caresses:hasRelative</a>
    /// </summary>
    let hasRelative = _prefixId.prefix "hasRelative"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasReligion</para>
    ///   <para>rdfs:comment : ObjectProperty used for let the robot talk about user's religion</para>
    ///   <a href="http://caressesrobot.org/ontology#hasReligion">caresses:hasReligion</a>
    /// </summary>
    let hasReligion = _prefixId.prefix "hasReligion"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasRobot</para>
    ///   <a href="http://caressesrobot.org/ontology#hasRobot">caresses:hasRobot</a>
    /// </summary>
    let hasRobot = _prefixId.prefix "hasRobot"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasRoom</para>
    ///   <a href="http://caressesrobot.org/ontology#hasRoom">caresses:hasRoom</a>
    /// </summary>
    let hasRoom = _prefixId.prefix "hasRoom"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasSentence</para>
    ///   <para>rdfs:comment : Sentences that the robot may pronounce during  the interaction with the user. Subproperties of hasSentence may be:
    ///
    ///  hasQuestion (encoded sentences used by the robot to ask the general user's feeback about the topic)
    /// - hasQuestionContextual (encoded sentences used by the robot to ask the user's feedback related to the specific context)
    /// - hasQuestionGoal (encoded sentences used by the robot to ask the user about activities to be performed)
    /// - has PositiveSentence (encoded sentences used by the robot when a positive feedback is received)
    /// - has PositiveAndWait (encoded sentences used by the robot when a positive feedback is received. With these sentences, the robot invites the user to freely talk about a conversation topic)
    /// - hasNegativeSentence (encoded sentences used by the robot when a negative feedback is received)</para>
    ///   <a href="http://caressesrobot.org/ontology#hasSentence">caresses:hasSentence</a>
    /// </summary>
    let hasSentence = _prefixId.prefix "hasSentence"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasSkype</para>
    ///   <para>rdfs:comment : Skype account of user contacts</para>
    ///   <a href="http://caressesrobot.org/ontology#hasSkype">caresses:hasSkype</a>
    /// </summary>
    let hasSkype = _prefixId.prefix "hasSkype"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasSocialEnvironment</para>
    ///   <a href="http://caressesrobot.org/ontology#hasSocialEnvironment">caresses:hasSocialEnvironment</a>
    /// </summary>
    let hasSocialEnvironment = _prefixId.prefix "hasSocialEnvironment"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasSong</para>
    ///   <a href="http://caressesrobot.org/ontology#hasSong">caresses:hasSong</a>
    /// </summary>
    let hasSong = _prefixId.prefix "hasSong"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasSpecific</para>
    ///   <para>rdfs:comment : Instances, belonging to the Person-Specific ABox layer, are fillers of the corresponding instances in the Culture-Specific ABox layer for the hasSpecific property,</para>
    ///   <a href="http://caressesrobot.org/ontology#hasSpecific">caresses:hasSpecific</a>
    /// </summary>
    let hasSpecific = _prefixId.prefix "hasSpecific"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasSpeed</para>
    ///   <a href="http://caressesrobot.org/ontology#hasSpeed">caresses:hasSpeed</a>
    /// </summary>
    let hasSpeed = _prefixId.prefix "hasSpeed"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasSportsPlayer</para>
    ///   <a href="http://caressesrobot.org/ontology#hasSportsPlayer">caresses:hasSportsPlayer</a>
    /// </summary>
    let hasSportsPlayer = _prefixId.prefix "hasSportsPlayer"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasStatus</para>
    ///   <para>rdfs:comment : Possible status of the smart device</para>
    ///   <a href="http://caressesrobot.org/ontology#hasStatus">caresses:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasSuggestion</para>
    ///   <a href="http://caressesrobot.org/ontology#hasSuggestion">caresses:hasSuggestion</a>
    /// </summary>
    let hasSuggestion = _prefixId.prefix "hasSuggestion"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasTablet-view</para>
    ///   <para>rdfs:comment : Confirmation to be shown on the robot's tablet</para>
    ///   <a href="http://caressesrobot.org/ontology#hasTablet-view">caresses:hasTablet-view</a>
    /// </summary>
    let hasTablet_view = _prefixId.prefix "hasTablet-view"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasTelegram</para>
    ///   <para>rdfs:comment : Telegram account of user's contact accounts</para>
    ///   <a href="http://caressesrobot.org/ontology#hasTelegram">caresses:hasTelegram</a>
    /// </summary>
    let hasTelegram = _prefixId.prefix "hasTelegram"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasTime</para>
    ///   <a href="http://caressesrobot.org/ontology#hasTime">caresses:hasTime</a>
    /// </summary>
    let hasTime = _prefixId.prefix "hasTime"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasTopic</para>
    ///   <para>rdfs:comment : All object properties that allow the robot to talk about conversation topics</para>
    ///   <a href="http://caressesrobot.org/ontology#hasTopic">caresses:hasTopic</a>
    /// </summary>
    let hasTopic = _prefixId.prefix "hasTopic"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasTown</para>
    ///   <a href="http://caressesrobot.org/ontology#hasTown">caresses:hasTown</a>
    /// </summary>
    let hasTown = _prefixId.prefix "hasTown"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasTriggeringCondition</para>
    ///   <para>rdfs:comment : Filler of this ObjectProperty is an Event or Time or Quality that triggers a specific dialogue</para>
    ///   <a href="http://caressesrobot.org/ontology#hasTriggeringCondition">caresses:hasTriggeringCondition</a>
    /// </summary>
    let hasTriggeringCondition = _prefixId.prefix "hasTriggeringCondition"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasType</para>
    ///   <para>rdfs:comment : Type of the smart devices (device - sensor)</para>
    ///   <a href="http://caressesrobot.org/ontology#hasType">caresses:hasType</a>
    /// </summary>
    let hasType = _prefixId.prefix "hasType"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasUDDL</para>
    ///   <para>rdfs:comment : UDDL file describing the operator</para>
    ///   <a href="http://caressesrobot.org/ontology#hasUDDL">caresses:hasUDDL</a>
    /// </summary>
    let hasUDDL = _prefixId.prefix "hasUDDL"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasURL</para>
    ///   <para>rdfs:comment : youtube URL of the video</para>
    ///   <a href="http://caressesrobot.org/ontology#hasURL">caresses:hasURL</a>
    /// </summary>
    let hasURL = _prefixId.prefix "hasURL"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasUrl-article</para>
    ///   <para>rdfs:comment : Webpage for the ReadNewsAction</para>
    ///   <a href="http://caressesrobot.org/ontology#hasUrl-article">caresses:hasUrl-article</a>
    /// </summary>
    let hasUrl_article = _prefixId.prefix "hasUrl-article"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasUrl-root</para>
    ///   <para>rdfs:comment : Webpage for the readnews action</para>
    ///   <a href="http://caressesrobot.org/ontology#hasUrl-root">caresses:hasUrl-root</a>
    /// </summary>
    let hasUrl_root = _prefixId.prefix "hasUrl-root"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasUserName</para>
    ///   <a href="http://caressesrobot.org/ontology#hasUserName">caresses:hasUserName</a>
    /// </summary>
    let hasUserName = _prefixId.prefix "hasUserName"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <a href="http://caressesrobot.org/ontology#hasVHCorrelation">caresses:hasVHCorrelation</a>
    /// </summary>
    let hasVHCorrelation = _prefixId.prefix "hasVHCorrelation"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <a href="http://caressesrobot.org/ontology#hasVLCorrelation">caresses:hasVLCorrelation</a>
    /// </summary>
    let hasVLCorrelation = _prefixId.prefix "hasVLCorrelation"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasValue</para>
    ///   <para>rdfs:comment : String value for handling triggering and necessary conditions</para>
    ///   <a href="http://caressesrobot.org/ontology#hasValue">caresses:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : hasWaitingTime</para>
    ///   <a href="http://caressesrobot.org/ontology#hasWaitingTime">caresses:hasWaitingTime</a>
    /// </summary>
    let hasWaitingTime = _prefixId.prefix "hasWaitingTime"
