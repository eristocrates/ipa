namespace http.caressesrobot.org.ontology.hash

open DoxAletheia

module caresses =
    let _namespace_name = "http://caressesrobot.org/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#AmusementPlace"></see>
    /// </summary>
    let AmusementPlace = _prefix "AmusementPlace"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#EatingPlace"></see>
    /// </summary>
    let EatingPlace = _prefix "EatingPlace"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#LivingPlace"></see>
    /// </summary>
    let LivingPlace = _prefix "LivingPlace"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#ShoppingPlace"></see>
    /// </summary>
    let ShoppingPlace = _prefix "ShoppingPlace"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#SleepingPlace"></see>
    /// </summary>
    let SleepingPlace = _prefix "SleepingPlace"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Family"></see>
    /// </summary>
    let Family = _prefix "Family"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Friend"></see>
    /// </summary>
    let Friend = _prefix "Friend"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Relative"></see>
    /// </summary>
    let Relative = _prefix "Relative"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Appliance"></see>
    /// </summary>
    let Appliance = _prefix "Appliance"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Decoration"></see>
    /// </summary>
    let Decoration = _prefix "Decoration"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Furniture"></see>
    /// </summary>
    let Furniture = _prefix "Furniture"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Kitchenware"></see>
    /// </summary>
    let Kitchenware = _prefix "Kitchenware"
    /// <summary>
    /// Actions that may be executed by the robot. Actions are associate to parameters (Volume, Pitch, Speed, Language), to the username (Name), to the Suggestions (Topic).
    /// <see href="http://caressesrobot.org/ontology#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// Conversation topics that may be explored by the robot.
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
    /// Culture-specific instances of subclasses of Topic may be filled with Person-specific instances for the hasSpecific ObjectProperty
    /// <see href="http://caressesrobot.org/ontology#Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasSuggestion"></see>
    /// </summary>
    let hasSuggestion = _prefix "hasSuggestion"
    /// <summary>
    /// Voice speed for all actions involving verbal interaction
    /// <see href="http://caressesrobot.org/ontology#Speed"></see></summary>
    let Speed = _prefix "Speed"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasSpeed"></see>
    /// </summary>
    let hasSpeed = _prefix "hasSpeed"
    /// <summary>
    /// Configuration file for actions
    /// <see href="http://caressesrobot.org/ontology#hasConfFile2Name"></see></summary>
    let hasConfFile2Name = _prefix "hasConfFile2Name"
    /// <summary>
    /// Waiting Time parameter for the AcceptRequest Action
    /// <see href="http://caressesrobot.org/ontology#WaitingTime"></see></summary>
    let WaitingTime = _prefix "WaitingTime"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasWaitingTime"></see>
    /// </summary>
    let hasWaitingTime = _prefix "hasWaitingTime"
    /// <summary>
    /// Voice pitch for all actions involving verbal interaction
    /// <see href="http://caressesrobot.org/ontology#Pitch"></see></summary>
    let Pitch = _prefix "Pitch"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasPitch"></see>
    /// </summary>
    let hasPitch = _prefix "hasPitch"
    /// <summary>
    /// The individual filler of this property is used for building the configuration files for the related action
    /// <see href="http://caressesrobot.org/ontology#hasConfFile2"></see></summary>
    let hasConfFile2 = _prefix "hasConfFile2"
    /// <summary>
    /// The individual filler of this property is used for building the configuration files for the related action
    /// <see href="http://caressesrobot.org/ontology#hasConfFile1"></see></summary>
    let hasConfFile1 = _prefix "hasConfFile1"
    /// <summary>
    /// Configuration file for actions
    /// <see href="http://caressesrobot.org/ontology#hasConfFile1Name"></see></summary>
    let hasConfFile1Name = _prefix "hasConfFile1Name"
    /// <summary>
    /// Distance parameter for the ApproachUser action
    /// <see href="http://caressesrobot.org/ontology#Proxemics"></see></summary>
    let Proxemics = _prefix "Proxemics"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasDistance"></see>
    /// </summary>
    let hasDistance = _prefix "hasDistance"
    /// <summary>
    /// Parameter related to the language in which the sentences are written
    /// <see href="http://caressesrobot.org/ontology#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasLanguage"></see>
    /// </summary>
    let hasLanguage = _prefix "hasLanguage"
    /// <summary>
    /// Confirmation sentence before launching a goal
    /// <see href="http://caressesrobot.org/ontology#hasConfirmation"></see></summary>
    let hasConfirmation = _prefix "hasConfirmation"
    /// <summary>
    /// Possible ways to address the user. In the context of the verbal interaction between the robot and the user, this conversation topic will be probably selected among the firsts (this is implemented by the ObjectProperty hasTriggeringCondition). Examples of subclasses may be: FirstName, MrLastName, MrsLastName, Nickname, ...
    ///
    /// The DataProperty hasNameforPlanner describes how the robot should actually address the person, and its value is usually encoded in a User-Specific Individual (E.g. for the class FirstName, the DataProperty hasNameforPlanner will include the actual first name of the user)
    /// <see href="http://caressesrobot.org/ontology#Addressing"></see></summary>
    let Addressing = _prefix "Addressing"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasUserName"></see>
    /// </summary>
    let hasUserName = _prefix "hasUserName"
    /// <summary>
    /// Parameters associated to actions
    /// <see href="http://caressesrobot.org/ontology#Parameter"></see></summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    /// Cultural Parameters to be associated to Actions
    /// <see href="http://caressesrobot.org/ontology#hasCParameter"></see></summary>
    let hasCParameter = _prefix "hasCParameter"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Actor"></see>
    /// </summary>
    let Actor = _prefix "Actor"
    /// <summary>
    /// All things that may be expressed in terms of "preference" (e.g. what is your favourite ... ?)
    /// <see href="http://caressesrobot.org/ontology#TopicOneCanHavePreferenceAbout"></see></summary>
    let TopicOneCanHavePreferenceAbout = _prefix "TopicOneCanHavePreferenceAbout"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#PublicPerson"></see>
    /// </summary>
    let PublicPerson = _prefix "PublicPerson"
    /// <summary>
    /// String to be sent to the planner
    /// <see href="http://caressesrobot.org/ontology#hasNameforPlanner"></see></summary>
    let hasNameforPlanner = _prefix "hasNameforPlanner"
    /// <summary>
    /// A thing that has happened, or that takes place with regularity, independently from the user's activity
    /// <see href="http://caressesrobot.org/ontology#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasCondition"></see>
    /// </summary>
    let hasCondition = _prefix "hasCondition"
    /// <summary>
    /// A physical space or region, defined by geographical coordinates (absolute location) or expressed in relative terms (relative location).
    /// <see href="http://caressesrobot.org/ontology#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// ObjectProperty used for let the robot talk about places that are relevant for the user
    /// <see href="http://caressesrobot.org/ontology#hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// All tangible space regiones that support and influence the user's life
    /// <see href="http://caressesrobot.org/ontology#PhysicalEnvironment"></see></summary>
    let PhysicalEnvironment = _prefix "PhysicalEnvironment"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#HouseObject"></see>
    /// </summary>
    let HouseObject = _prefix "HouseObject"
    /// <summary>
    /// An abstract or physical object considered to fulfill a primarily independent aesthetic function.
    /// <see href="http://caressesrobot.org/ontology#ArtObject"></see></summary>
    let ArtObject = _prefix "ArtObject"
    /// <summary>
    /// Abstracts objects, with no physical referents and that does not exist at any particular time or place, and concrete objects
    /// <see href="http://caressesrobot.org/ontology#Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// Lack of belief in gods and religions
    /// <see href="http://caressesrobot.org/ontology#Atheism"></see></summary>
    let Atheism = _prefix "Atheism"
    /// <summary>
    /// Ideology or set of principles. It is mainly intended in the form of religion.
    ///
    /// Individuals of this class may be related to Individuals of the class ReligiousCulturalEvent; thus, known the user's religion, the robot would probably talk about related religious festivities.
    /// <see href="http://caressesrobot.org/ontology#BeliefSystem"></see></summary>
    let BeliefSystem = _prefix "BeliefSystem"
    /// <summary>
    /// ObjectProperty used for let the robot talk about events relevant for the user's life
    /// <see href="http://caressesrobot.org/ontology#hasEvent"></see></summary>
    let hasEvent = _prefix "hasEvent"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Birthday"></see>
    /// </summary>
    let Birthday = _prefix "Birthday"
    /// <summary>
    /// Any event that takes place regularly every year
    /// <see href="http://caressesrobot.org/ontology#YearlyEvent"></see></summary>
    let YearlyEvent = _prefix "YearlyEvent"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Book"></see>
    /// </summary>
    let Book = _prefix "Book"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Writer"></see>
    /// </summary>
    let Writer = _prefix "Writer"
    /// <summary>
    /// ObjectProperty used for let the robot talk about persons relevant for the user's life
    /// <see href="http://caressesrobot.org/ontology#hasPerson"></see></summary>
    let hasPerson = _prefix "hasPerson"
    /// <summary>
    /// Parameter for the VideoCall action (Audio or Video call)
    /// <see href="http://caressesrobot.org/ontology#CallMode"></see></summary>
    let CallMode = _prefix "CallMode"
    /// <summary>
    /// The habit of celebrating events (holidays, festivities, ... )
    /// <see href="http://caressesrobot.org/ontology#CelebratingEvents"></see></summary>
    let CelebratingEvents = _prefix "CelebratingEvents"
    /// <summary>
    /// Activities, routines or behaviors that are regularly repeated by the user.
    ///
    /// Individuals of this class may be filled with Individuals to the class Time for the ObjectProperty hasCondition (conversation topics may be triggered in some specific period of the day) or hasTime (the robot may investigate if habits take place in specific times of the day).
    /// <see href="http://caressesrobot.org/ontology#Habit"></see></summary>
    let Habit = _prefix "Habit"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Childhood"></see>
    /// </summary>
    let Childhood = _prefix "Childhood"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Pet"></see>
    /// </summary>
    let Pet = _prefix "Pet"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasPet"></see>
    /// </summary>
    let hasPet = _prefix "hasPet"
    /// <summary>
    /// ObjectProperty used for let the robot talk about user's regular / periodical activities
    /// <see href="http://caressesrobot.org/ontology#hasHabit"></see></summary>
    let hasHabit = _prefix "hasHabit"
    /// <summary>
    /// Relevant facts for the user's past and present life (chilldhood, education, heritage, work, ...)
    /// <see href="http://caressesrobot.org/ontology#TopicAboutOnesLife"></see></summary>
    let TopicAboutOnesLife = _prefix "TopicAboutOnesLife"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#CircleOfFriend"></see>
    /// </summary>
    let CircleOfFriend = _prefix "CircleOfFriend"
    /// <summary>
    /// Social relationships that influence the user's life (friends, family, ...)
    /// <see href="http://caressesrobot.org/ontology#SocialEnvironment"></see></summary>
    let SocialEnvironment = _prefix "SocialEnvironment"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Clothing"></see>
    /// </summary>
    let Clothing = _prefix "Clothing"
    /// <summary>
    /// A nation with its own government
    /// <see href="http://caressesrobot.org/ontology#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Town"></see>
    /// </summary>
    let Town = _prefix "Town"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasTown"></see>
    /// </summary>
    let hasTown = _prefix "hasTown"
    /// <summary>
    /// Action or sequence of actions that are daily executed by the user. Possible Subclasses are: DoingPhysicalExercises, GettingDressed, HavingMeal, TakingMedicine, TakingCareOfOneself, and many others
    /// <see href="http://caressesrobot.org/ontology#DailyRoutine"></see></summary>
    let DailyRoutine = _prefix "DailyRoutine"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#PeriodOfTheDay"></see>
    /// </summary>
    let PeriodOfTheDay = _prefix "PeriodOfTheDay"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasTime"></see>
    /// </summary>
    let hasTime = _prefix "hasTime"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Dance"></see>
    /// </summary>
    let Dance = _prefix "Dance"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#DayOfTheWeek"></see>
    /// </summary>
    let DayOfTheWeek = _prefix "DayOfTheWeek"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Time"></see>
    /// </summary>
    let Time = _prefix "Time"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#DeathOfAClosePerson"></see>
    /// </summary>
    let DeathOfAClosePerson = _prefix "DeathOfAClosePerson"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Drink"></see>
    /// </summary>
    let Drink = _prefix "Drink"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#FoodAndDrink"></see>
    /// </summary>
    let FoodAndDrink = _prefix "FoodAndDrink"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Education"></see>
    /// </summary>
    let Education = _prefix "Education"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasRelative"></see>
    /// </summary>
    let hasRelative = _prefix "hasRelative"
    /// <summary>
    /// The position of something expressed in relative terms (e.g. Close, Far, VeryFar, ... )
    /// <see href="http://caressesrobot.org/ontology#RelativeLocation"></see></summary>
    let RelativeLocation = _prefix "RelativeLocation"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasRelatLocation"></see>
    /// </summary>
    let hasRelatLocation = _prefix "hasRelatLocation"
    /// <summary>
    /// Possible Subclasses are FeelingAfraid, FeelingAngry, FeelingLonely, FeelingWorried, ...
    /// <see href="http://caressesrobot.org/ontology#FeelingBad"></see></summary>
    let FeelingBad = _prefix "FeelingBad"
    /// <summary>
    /// The condition or state of the body or mind
    /// <see href="http://caressesrobot.org/ontology#PhysicalAndMentalCondition"></see></summary>
    let PhysicalAndMentalCondition = _prefix "PhysicalAndMentalCondition"
    /// <summary>
    /// Possible Subclasses are FeelingExcited, FeelingHappy, FeelingRelaxed, FeelingStrong, ...
    /// <see href="http://caressesrobot.org/ontology#FeelingWell"></see></summary>
    let FeelingWell = _prefix "FeelingWell"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Food"></see>
    /// </summary>
    let Food = _prefix "Food"
    /// <summary>
    /// Dietary restrictions, that may be related to religious or ethical aspects. Possible Subclasses are EatingHalal, EatingKosher, EatingVegetarian, ...
    /// <see href="http://caressesrobot.org/ontology#FoodNorm"></see></summary>
    let FoodNorm = _prefix "FoodNorm"
    /// <summary>
    /// Guidelines about what is considered correct or incorrect speaking of social behavior in a particular group, social unit or cultural identities.
    /// <see href="http://caressesrobot.org/ontology#Norm"></see></summary>
    let Norm = _prefix "Norm"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Frequency"></see>
    /// </summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    /// Persons in the social, physical and cultural environemnt of the user
    /// <see href="http://caressesrobot.org/ontology#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// Coordinates of objects in the environment
    /// <see href="http://caressesrobot.org/ontology#hasCoordinates"></see></summary>
    let hasCoordinates = _prefix "hasCoordinates"
    /// <summary>
    /// Inclusion relationship between Objects and/or Location
    /// <see href="http://caressesrobot.org/ontology#hasIn"></see></summary>
    let hasIn = _prefix "hasIn"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Game"></see>
    /// </summary>
    let Game = _prefix "Game"
    /// <summary>
    /// The DataProperty hasPDDL encode the related string, in PDDL formalism, that should be sent to the planner when the goal is required
    /// <see href="http://caressesrobot.org/ontology#Goal"></see></summary>
    let Goal = _prefix "Goal"
    /// <summary>
    /// Confirmation to be shown on the robot's tablet
    /// <see href="http://caressesrobot.org/ontology#hasTablet-view"></see></summary>
    let ``hasTablet-view`` = _prefix "hasTablet-view"
    /// <summary>
    /// Question to be shown on the tablet
    /// <see href="http://caressesrobot.org/ontology#hasQuestion-t"></see></summary>
    let ``hasQuestion-t`` = _prefix "hasQuestion-t"
    /// <summary>
    /// Planning tasks (written in the PDDL formalism) that should be sent to the planner
    /// <see href="http://caressesrobot.org/ontology#hasPDDL"></see></summary>
    let hasPDDL = _prefix "hasPDDL"
    /// <summary>
    /// The condition of having health problems can be related to medicines taken by the user
    /// <see href="http://caressesrobot.org/ontology#HavingHealthProblems"></see></summary>
    let HavingHealthProblems = _prefix "HavingHealthProblems"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Medication"></see>
    /// </summary>
    let Medication = _prefix "Medication"
    /// <summary>
    /// ObjectProperty used for let the robot talk about medicines relevant for the user
    /// <see href="http://caressesrobot.org/ontology#hasMedicine"></see></summary>
    let hasMedicine = _prefix "hasMedicine"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Heritage"></see>
    /// </summary>
    let Heritage = _prefix "Heritage"
    /// <summary>
    /// Relevant facts in the areas of politics, military, science, music, sports, arts, entertainment, ...
    /// <see href="http://caressesrobot.org/ontology#HistoricFactOrPeriod"></see></summary>
    let HistoricFactOrPeriod = _prefix "HistoricFactOrPeriod"
    /// <summary>
    /// Activities done regularly in one's leisure time for pleasure. They may be chosen accordingly to the specific targets (i.e. older adults). Examples of SubClasses may be ReadingABook, WatchingAMovie, DoingSomeCooking, GoingToAClub, MakingHennaTattoos, ...
    /// <see href="http://caressesrobot.org/ontology#Hobby"></see></summary>
    let Hobby = _prefix "Hobby"
    /// <summary>
    /// Basic entities to perceive or measure: shapes, colors, sizes, sounds, smells,...
    /// <see href="http://caressesrobot.org/ontology#Quality"></see></summary>
    let Quality = _prefix "Quality"
    /// <summary>
    /// Filler of this ObjectProperty is an Event or Time or Quality that allows the robot to talk about a specific topic
    /// <see href="http://caressesrobot.org/ontology#hasNecessaryCondition"></see></summary>
    let hasNecessaryCondition = _prefix "hasNecessaryCondition"
    /// <summary>
    /// The building where one lives. Examples of SubClasses are Apartment, CareHome (for the specific case of older adults to which the CARESSES Ontology is addressed)
    /// <see href="http://caressesrobot.org/ontology#Home"></see></summary>
    let Home = _prefix "Home"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Room"></see>
    /// </summary>
    let Room = _prefix "Room"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Hour"></see>
    /// </summary>
    let Hour = _prefix "Hour"
    /// <summary>
    /// Field used for automatically building sentences
    /// <see href="http://caressesrobot.org/ontology#hasPrep-object"></see></summary>
    let ``hasPrep-object`` = _prefix "hasPrep-object"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasHome"></see>
    /// </summary>
    let hasHome = _prefix "hasHome"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasCountry"></see>
    /// </summary>
    let hasCountry = _prefix "hasCountry"
    /// <summary>
    /// Definitions of polite or acceptable social behaviours. They may be chosen accordingly to the specific targets (i.e. older adults) and cultural identities. Examples of SubClasses are GivingPresentsToRelativeOrFriend, StackingDishesAfterMeal, ...
    /// <see href="http://caressesrobot.org/ontology#Manner"></see></summary>
    let Manner = _prefix "Manner"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#MedicalStaff"></see>
    /// </summary>
    let MedicalStaff = _prefix "MedicalStaff"
    /// <summary>
    /// Messages encoded for the SendMsgAction
    /// <see href="http://caressesrobot.org/ontology#Message"></see></summary>
    let Message = _prefix "Message"
    /// <summary>
    /// Preloaded messages for the SendMessageAction
    /// <see href="http://caressesrobot.org/ontology#hasMessage"></see></summary>
    let hasMessage = _prefix "hasMessage"
    /// <summary>
    /// Compulsory recipient for related messages.
    /// <see href="http://caressesrobot.org/ontology#hasCompulsory-recipient"></see></summary>
    let ``hasCompulsory-recipient`` = _prefix "hasCompulsory-recipient"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Movie"></see>
    /// </summary>
    let Movie = _prefix "Movie"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasActor"></see>
    /// </summary>
    let hasActor = _prefix "hasActor"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Music"></see>
    /// </summary>
    let Music = _prefix "Music"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Song"></see>
    /// </summary>
    let Song = _prefix "Song"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasSong"></see>
    /// </summary>
    let hasSong = _prefix "hasSong"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Singer"></see>
    /// </summary>
    let Singer = _prefix "Singer"
    /// <summary>
    /// This class includes all Operators that should  be sent to the planner for the execution of actions. Operators achieve Goals by implementing Actions
    /// <see href="http://caressesrobot.org/ontology#Operator"></see></summary>
    let Operator = _prefix "Operator"
    /// <summary>
    /// UDDL file describing the operator
    /// <see href="http://caressesrobot.org/ontology#hasUDDL"></see></summary>
    let hasUDDL = _prefix "hasUDDL"
    /// <summary>
    /// ObjectProperty used for let the robot talk about possible activities
    /// <see href="http://caressesrobot.org/ontology#hasGoal"></see></summary>
    let hasGoal = _prefix "hasGoal"
    /// <summary>
    /// A relation that holds between Operators and Actions
    /// <see href="http://caressesrobot.org/ontology#hasAction"></see></summary>
    let hasAction = _prefix "hasAction"
    /// <summary>
    /// Phone number of user's contacts
    /// <see href="http://caressesrobot.org/ontology#hasPhone"></see></summary>
    let hasPhone = _prefix "hasPhone"
    /// <summary>
    /// Telegram account of user's contact accounts
    /// <see href="http://caressesrobot.org/ontology#hasTelegram"></see></summary>
    let hasTelegram = _prefix "hasTelegram"
    /// <summary>
    /// Skype account of user contacts
    /// <see href="http://caressesrobot.org/ontology#hasSkype"></see></summary>
    let hasSkype = _prefix "hasSkype"
    /// <summary>
    /// Line account of the user's contact
    /// <see href="http://caressesrobot.org/ontology#hasLine"></see></summary>
    let hasLine = _prefix "hasLine"
    /// <summary>
    /// E-mail address of contacts
    /// <see href="http://caressesrobot.org/ontology#hasEmail"></see></summary>
    let hasEmail = _prefix "hasEmail"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#PersonalCareObject"></see>
    /// </summary>
    let PersonalCareObject = _prefix "PersonalCareObject"
    /// <summary>
    /// Individuals of this class may be filled with Individuals of the class FoodNorm for the ObjectProperty hasNorm; thus, known the user's religion, the robot would probably investigate aspects related to possible alimentary restrictions
    ///
    /// Individuals of this class may be filled with Individuals of the class ReligiousCulturalEvent for the ObjectProperty hasEvent; thus, known the user's religion, the robot would probably talk about related religious festivities.
    /// <see href="http://caressesrobot.org/ontology#Religion"></see></summary>
    let Religion = _prefix "Religion"
    /// <summary>
    /// ObjectProperty used for let the robot talk about social norms
    /// <see href="http://caressesrobot.org/ontology#hasNorm"></see></summary>
    let hasNorm = _prefix "hasNorm"
    /// <summary>
    /// Any event related to religious celebrations
    /// <see href="http://caressesrobot.org/ontology#ReligiousCulturalEvent"></see></summary>
    let ReligiousCulturalEvent = _prefix "ReligiousCulturalEvent"
    /// <summary>
    /// The user's robot . An instance of the class Robot may be connected with instances of the class Goal, in order to encode all goals that may be achieved by the robot
    /// <see href="http://caressesrobot.org/ontology#Robot"></see></summary>
    let Robot = _prefix "Robot"
    /// <summary>
    /// Relationship of closeness between Objects and/or Locations
    /// <see href="http://caressesrobot.org/ontology#hasAdjacent"></see></summary>
    let hasAdjacent = _prefix "hasAdjacent"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Season"></see>
    /// </summary>
    let Season = _prefix "Season"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasRoom"></see>
    /// </summary>
    let hasRoom = _prefix "hasRoom"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#SmartDevice"></see>
    /// </summary>
    let SmartDevice = _prefix "SmartDevice"
    /// <summary>
    /// Operations that can be executed with smart devices
    /// <see href="http://caressesrobot.org/ontology#hasOperations"></see></summary>
    let hasOperations = _prefix "hasOperations"
    /// <summary>
    /// Type of the smart devices (device - sensor)
    /// <see href="http://caressesrobot.org/ontology#hasType"></see></summary>
    let hasType = _prefix "hasType"
    /// <summary>
    /// Possible status of the smart device
    /// <see href="http://caressesrobot.org/ontology#hasStatus"></see></summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    /// String for automatically composing sentences. It refers to Smart Devices
    /// <see href="http://caressesrobot.org/ontology#hasAs-sensor"></see></summary>
    let ``hasAs-sensor`` = _prefix "hasAs-sensor"
    /// <summary>
    /// Location of the smart device
    /// <see href="http://caressesrobot.org/ontology#hasLocations"></see></summary>
    let hasLocations = _prefix "hasLocations"
    /// <summary>
    /// Any occasion/event that involves social interaction.
    /// <see href="http://caressesrobot.org/ontology#SocialEvent"></see></summary>
    let SocialEvent = _prefix "SocialEvent"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Sport"></see>
    /// </summary>
    let Sport = _prefix "Sport"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#SportsPlayer"></see>
    /// </summary>
    let SportsPlayer = _prefix "SportsPlayer"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasSportsPlayer"></see>
    /// </summary>
    let hasSportsPlayer = _prefix "hasSportsPlayer"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#TVChannel"></see>
    /// </summary>
    let TVChannel = _prefix "TVChannel"
    /// <summary>
    /// Webpage for the readnews action
    /// <see href="http://caressesrobot.org/ontology#hasUrl-root"></see></summary>
    let ``hasUrl-root`` = _prefix "hasUrl-root"
    /// <summary>
    /// Webpage for the ReadNewsAction
    /// <see href="http://caressesrobot.org/ontology#hasUrl-article"></see></summary>
    let ``hasUrl-article`` = _prefix "hasUrl-article"
    /// <summary>
    /// 12 hr or 24hr
    /// <see href="http://caressesrobot.org/ontology#TimeFormat"></see></summary>
    let TimeFormat = _prefix "TimeFormat"
    /// <summary>
    /// Likeliness value for conversation topics. It corresponds to a reasonable estimate, to the best of available knowledge, of the a posteriori probability of the assertion.
    /// - In the Culture-Specific Layer, Likeliness values are used to specify how appropriate each instance is for the each culture, and guide the robot’s behaviour.
    /// - In the Person-Specific Layer, the likeliness corresponds to the evidence of the assertion collected through interaction with the user.
    /// <see href="http://caressesrobot.org/ontology#hasLikeliness"></see></summary>
    let hasLikeliness = _prefix "hasLikeliness"
    /// <summary>
    /// Triggering keyword for conversation topics
    /// <see href="http://caressesrobot.org/ontology#hasKeyword1"></see></summary>
    let hasKeyword1 = _prefix "hasKeyword1"
    /// <summary>
    /// Triggering keyword for conversation topics
    /// <see href="http://caressesrobot.org/ontology#hasKeyword2"></see></summary>
    let hasKeyword2 = _prefix "hasKeyword2"
    /// <summary>
    /// hasFull field for building configuration files of actions
    /// <see href="http://caressesrobot.org/ontology#hasFull"></see></summary>
    let hasFull = _prefix "hasFull"
    /// <summary>
    /// String value for handling triggering and necessary conditions
    /// <see href="http://caressesrobot.org/ontology#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// Field used to automatically generate sentences
    /// <see href="http://caressesrobot.org/ontology#hasName"></see></summary>
    let hasName = _prefix "hasName"
    /// <summary>
    /// Instances, belonging to the Person-Specific ABox layer, are fillers of the corresponding instances in the Culture-Specific ABox layer for the hasSpecific property,
    /// <see href="http://caressesrobot.org/ontology#hasSpecific"></see></summary>
    let hasSpecific = _prefix "hasSpecific"
    /// <summary>
    /// Person to which the user-specific information of the Ontology refers
    /// <see href="http://caressesrobot.org/ontology#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// ObjectProperty used for let the robot talk about games
    /// <see href="http://caressesrobot.org/ontology#hasGame"></see></summary>
    let hasGame = _prefix "hasGame"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasPhysicalEnvironment"></see>
    /// </summary>
    let hasPhysicalEnvironment = _prefix "hasPhysicalEnvironment"
    /// <summary>
    /// ObjectProperty used for let the robot talk about food
    /// <see href="http://caressesrobot.org/ontology#hasFood"></see></summary>
    let hasFood = _prefix "hasFood"
    /// <summary>
    /// ObjectProperty used for let the robot talk about possible ways to address the user
    /// <see href="http://caressesrobot.org/ontology#hasAddressing"></see></summary>
    let hasAddressing = _prefix "hasAddressing"
    /// <summary>
    /// Relationships between User and Objects
    /// <see href="http://caressesrobot.org/ontology#hasObject"></see></summary>
    let hasObject = _prefix "hasObject"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasFeeling"></see>
    /// </summary>
    let hasFeeling = _prefix "hasFeeling"
    /// <summary>
    /// ObjectProperty used for let the robot talk about user's religion
    /// <see href="http://caressesrobot.org/ontology#hasReligion"></see></summary>
    let hasReligion = _prefix "hasReligion"
    /// <summary>
    /// ObjectProperty used for let the robot talk about the physical and mental state of the user
    /// <see href="http://caressesrobot.org/ontology#hasPhysicalAndMentalState"></see></summary>
    let hasPhysicalAndMentalState = _prefix "hasPhysicalAndMentalState"
    /// <summary>
    /// ObjectProperty used for let the robot talk about good manners
    /// <see href="http://caressesrobot.org/ontology#hasManner"></see></summary>
    let hasManner = _prefix "hasManner"
    /// <summary>
    /// ObjectProperty used for let the robot talk about the user's clothes
    /// <see href="http://caressesrobot.org/ontology#hasCloth"></see></summary>
    let hasCloth = _prefix "hasCloth"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasMusic"></see>
    /// </summary>
    let hasMusic = _prefix "hasMusic"
    /// <summary>
    /// ObjectProperty used for let the robot talk about user's beliefs and values
    /// <see href="http://caressesrobot.org/ontology#hasBeliefAndValue"></see></summary>
    let hasBeliefAndValue = _prefix "hasBeliefAndValue"
    /// <summary>
    /// ObjectProperty used for let the robot talk about the user's life
    /// <see href="http://caressesrobot.org/ontology#hasLife"></see></summary>
    let hasLife = _prefix "hasLife"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasSocialEnvironment"></see>
    /// </summary>
    let hasSocialEnvironment = _prefix "hasSocialEnvironment"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasHealthProblem"></see>
    /// </summary>
    let hasHealthProblem = _prefix "hasHealthProblem"
    /// <summary>
    /// ObjectProperty used for let the robot talk about the user's health
    /// <see href="http://caressesrobot.org/ontology#hasHealth"></see></summary>
    let hasHealth = _prefix "hasHealth"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasRobot"></see>
    /// </summary>
    let hasRobot = _prefix "hasRobot"
    /// <summary>
    /// Voice volume for all actions involving verbal interaction
    /// <see href="http://caressesrobot.org/ontology#Volume"></see></summary>
    let Volume = _prefix "Volume"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Work"></see>
    /// </summary>
    let Work = _prefix "Work"
    /// <summary>
    /// All object properties that allow the robot to talk about conversation topics
    /// <see href="http://caressesrobot.org/ontology#hasTopic"></see></summary>
    let hasTopic = _prefix "hasTopic"
    /// <summary>
    /// Correlations between Individuals, even belonging to different Classes. An HCorrelation implies that, if a UserSpecific instances with an high DataProperty HasLikeliness value is added, the hasLiklelines of the other individuals should be increased. A VLCorrelation impliease that if a UserSpecific instances with an high DataProperty HasLikeliness value is added, the hasLiklelines of the other individuals should be decreased.
    /// <see href="http://caressesrobot.org/ontology#hasCorrelation"></see></summary>
    let hasCorrelation = _prefix "hasCorrelation"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasFamily"></see>
    /// </summary>
    let hasFamily = _prefix "hasFamily"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasFrequency"></see>
    /// </summary>
    let hasFrequency = _prefix "hasFrequency"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasHCorrelation"></see>
    /// </summary>
    let hasHCorrelation = _prefix "hasHCorrelation"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasMCorrelation"></see>
    /// </summary>
    let hasMCorrelation = _prefix "hasMCorrelation"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasQuality"></see>
    /// </summary>
    let hasQuality = _prefix "hasQuality"
    /// <summary>
    /// Sentences that the robot may pronounce during  the interaction with the user. Subproperties of hasSentence may be:
    ///
    ///  hasQuestion (encoded sentences used by the robot to ask the general user's feeback about the topic)
    /// - hasQuestionContextual (encoded sentences used by the robot to ask the user's feedback related to the specific context)
    /// - hasQuestionGoal (encoded sentences used by the robot to ask the user about activities to be performed)
    /// - has PositiveSentence (encoded sentences used by the robot when a positive feedback is received)
    /// - has PositiveAndWait (encoded sentences used by the robot when a positive feedback is received. With these sentences, the robot invites the user to freely talk about a conversation topic)
    /// - hasNegativeSentence (encoded sentences used by the robot when a negative feedback is received)
    /// <see href="http://caressesrobot.org/ontology#hasSentence"></see></summary>
    let hasSentence = _prefix "hasSentence"
    /// <summary>
    /// Filler of this ObjectProperty is an Event or Time or Quality that triggers a specific dialogue
    /// <see href="http://caressesrobot.org/ontology#hasTriggeringCondition"></see></summary>
    let hasTriggeringCondition = _prefix "hasTriggeringCondition"
    /// <summary>
    /// youtube URL of the video
    /// <see href="http://caressesrobot.org/ontology#hasURL"></see></summary>
    let hasURL = _prefix "hasURL"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasVHCorrelation"></see>
    /// </summary>
    let hasVHCorrelation = _prefix "hasVHCorrelation"
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasVLCorrelation"></see>
    /// </summary>
    let hasVLCorrelation = _prefix "hasVLCorrelation"
