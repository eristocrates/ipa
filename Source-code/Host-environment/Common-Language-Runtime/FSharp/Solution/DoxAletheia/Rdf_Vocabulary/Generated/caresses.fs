namespace http.caressesrobot.org.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module caresses =
    let _namespace_name = "http://caressesrobot.org/ontology#"

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#AmusementPlace"></see>
    /// </summary>
    let AmusementPlace =
        Namespaced_IRI.parse _namespace_name "AmusementPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#EatingPlace"></see>
    /// </summary>
    let EatingPlace =
        Namespaced_IRI.parse _namespace_name "EatingPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#LivingPlace"></see>
    /// </summary>
    let LivingPlace =
        Namespaced_IRI.parse _namespace_name "LivingPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#ShoppingPlace"></see>
    /// </summary>
    let ShoppingPlace =
        Namespaced_IRI.parse _namespace_name "ShoppingPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#SleepingPlace"></see>
    /// </summary>
    let SleepingPlace =
        Namespaced_IRI.parse _namespace_name "SleepingPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Family"></see>
    /// </summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Friend"></see>
    /// </summary>
    let Friend = Namespaced_IRI.parse _namespace_name "Friend" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Relative"></see>
    /// </summary>
    let Relative = Namespaced_IRI.parse _namespace_name "Relative" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Appliance"></see>
    /// </summary>
    let Appliance = Namespaced_IRI.parse _namespace_name "Appliance" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Decoration"></see>
    /// </summary>
    let Decoration = Namespaced_IRI.parse _namespace_name "Decoration" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Furniture"></see>
    /// </summary>
    let Furniture = Namespaced_IRI.parse _namespace_name "Furniture" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Kitchenware"></see>
    /// </summary>
    let Kitchenware =
        Namespaced_IRI.parse _namespace_name "Kitchenware" |> NamespacedName

    /// <summary>
    /// Actions that may be executed by the robot. Actions are associate to parameters (Volume, Pitch, Speed, Language), to the username (Name), to the Suggestions (Topic).
    /// <see href="http://caressesrobot.org/ontology#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
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
    let Topic = Namespaced_IRI.parse _namespace_name "Topic" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasSuggestion"></see>
    /// </summary>
    let hasSuggestion =
        Namespaced_IRI.parse _namespace_name "hasSuggestion" |> NamespacedName

    /// <summary>
    /// Voice speed for all actions involving verbal interaction
    /// <see href="http://caressesrobot.org/ontology#Speed"></see></summary>
    let Speed = Namespaced_IRI.parse _namespace_name "Speed" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasSpeed"></see>
    /// </summary>
    let hasSpeed = Namespaced_IRI.parse _namespace_name "hasSpeed" |> NamespacedName

    /// <summary>
    /// Configuration file for actions
    /// <see href="http://caressesrobot.org/ontology#hasConfFile2Name"></see></summary>
    let hasConfFile2Name =
        Namespaced_IRI.parse _namespace_name "hasConfFile2Name" |> NamespacedName

    /// <summary>
    /// Waiting Time parameter for the AcceptRequest Action
    /// <see href="http://caressesrobot.org/ontology#WaitingTime"></see></summary>
    let WaitingTime =
        Namespaced_IRI.parse _namespace_name "WaitingTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasWaitingTime"></see>
    /// </summary>
    let hasWaitingTime =
        Namespaced_IRI.parse _namespace_name "hasWaitingTime" |> NamespacedName

    /// <summary>
    /// Voice pitch for all actions involving verbal interaction
    /// <see href="http://caressesrobot.org/ontology#Pitch"></see></summary>
    let Pitch = Namespaced_IRI.parse _namespace_name "Pitch" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasPitch"></see>
    /// </summary>
    let hasPitch = Namespaced_IRI.parse _namespace_name "hasPitch" |> NamespacedName

    /// <summary>
    /// The individual filler of this property is used for building the configuration files for the related action
    /// <see href="http://caressesrobot.org/ontology#hasConfFile2"></see></summary>
    let hasConfFile2 =
        Namespaced_IRI.parse _namespace_name "hasConfFile2" |> NamespacedName

    /// <summary>
    /// The individual filler of this property is used for building the configuration files for the related action
    /// <see href="http://caressesrobot.org/ontology#hasConfFile1"></see></summary>
    let hasConfFile1 =
        Namespaced_IRI.parse _namespace_name "hasConfFile1" |> NamespacedName

    /// <summary>
    /// Configuration file for actions
    /// <see href="http://caressesrobot.org/ontology#hasConfFile1Name"></see></summary>
    let hasConfFile1Name =
        Namespaced_IRI.parse _namespace_name "hasConfFile1Name" |> NamespacedName

    /// <summary>
    /// Distance parameter for the ApproachUser action
    /// <see href="http://caressesrobot.org/ontology#Proxemics"></see></summary>
    let Proxemics = Namespaced_IRI.parse _namespace_name "Proxemics" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasDistance"></see>
    /// </summary>
    let hasDistance =
        Namespaced_IRI.parse _namespace_name "hasDistance" |> NamespacedName

    /// <summary>
    /// Parameter related to the language in which the sentences are written
    /// <see href="http://caressesrobot.org/ontology#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasLanguage"></see>
    /// </summary>
    let hasLanguage =
        Namespaced_IRI.parse _namespace_name "hasLanguage" |> NamespacedName

    /// <summary>
    /// Confirmation sentence before launching a goal
    /// <see href="http://caressesrobot.org/ontology#hasConfirmation"></see></summary>
    let hasConfirmation =
        Namespaced_IRI.parse _namespace_name "hasConfirmation" |> NamespacedName

    /// <summary>
    /// Possible ways to address the user. In the context of the verbal interaction between the robot and the user, this conversation topic will be probably selected among the firsts (this is implemented by the ObjectProperty hasTriggeringCondition). Examples of subclasses may be: FirstName, MrLastName, MrsLastName, Nickname, ...
    ///
    /// The DataProperty hasNameforPlanner describes how the robot should actually address the person, and its value is usually encoded in a User-Specific Individual (E.g. for the class FirstName, the DataProperty hasNameforPlanner will include the actual first name of the user)
    /// <see href="http://caressesrobot.org/ontology#Addressing"></see></summary>
    let Addressing = Namespaced_IRI.parse _namespace_name "Addressing" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasUserName"></see>
    /// </summary>
    let hasUserName =
        Namespaced_IRI.parse _namespace_name "hasUserName" |> NamespacedName

    /// <summary>
    /// Parameters associated to actions
    /// <see href="http://caressesrobot.org/ontology#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName

    /// <summary>
    /// Cultural Parameters to be associated to Actions
    /// <see href="http://caressesrobot.org/ontology#hasCParameter"></see></summary>
    let hasCParameter =
        Namespaced_IRI.parse _namespace_name "hasCParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Actor"></see>
    /// </summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName

    /// <summary>
    /// All things that may be expressed in terms of "preference" (e.g. what is your favourite ... ?)
    /// <see href="http://caressesrobot.org/ontology#TopicOneCanHavePreferenceAbout"></see></summary>
    let TopicOneCanHavePreferenceAbout =
        Namespaced_IRI.parse _namespace_name "TopicOneCanHavePreferenceAbout" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#PublicPerson"></see>
    /// </summary>
    let PublicPerson =
        Namespaced_IRI.parse _namespace_name "PublicPerson" |> NamespacedName

    /// <summary>
    /// String to be sent to the planner
    /// <see href="http://caressesrobot.org/ontology#hasNameforPlanner"></see></summary>
    let hasNameforPlanner =
        Namespaced_IRI.parse _namespace_name "hasNameforPlanner" |> NamespacedName

    /// <summary>
    /// A thing that has happened, or that takes place with regularity, independently from the user's activity
    /// <see href="http://caressesrobot.org/ontology#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasCondition"></see>
    /// </summary>
    let hasCondition =
        Namespaced_IRI.parse _namespace_name "hasCondition" |> NamespacedName

    /// <summary>
    /// A physical space or region, defined by geographical coordinates (absolute location) or expressed in relative terms (relative location).
    /// <see href="http://caressesrobot.org/ontology#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about places that are relevant for the user
    /// <see href="http://caressesrobot.org/ontology#hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// All tangible space regiones that support and influence the user's life
    /// <see href="http://caressesrobot.org/ontology#PhysicalEnvironment"></see></summary>
    let PhysicalEnvironment =
        Namespaced_IRI.parse _namespace_name "PhysicalEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#HouseObject"></see>
    /// </summary>
    let HouseObject =
        Namespaced_IRI.parse _namespace_name "HouseObject" |> NamespacedName

    /// <summary>
    /// An abstract or physical object considered to fulfill a primarily independent aesthetic function.
    /// <see href="http://caressesrobot.org/ontology#ArtObject"></see></summary>
    let ArtObject = Namespaced_IRI.parse _namespace_name "ArtObject" |> NamespacedName
    /// <summary>
    /// Abstracts objects, with no physical referents and that does not exist at any particular time or place, and concrete objects
    /// <see href="http://caressesrobot.org/ontology#Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    /// Lack of belief in gods and religions
    /// <see href="http://caressesrobot.org/ontology#Atheism"></see></summary>
    let Atheism = Namespaced_IRI.parse _namespace_name "Atheism" |> NamespacedName

    /// <summary>
    /// Ideology or set of principles. It is mainly intended in the form of religion.
    ///
    /// Individuals of this class may be related to Individuals of the class ReligiousCulturalEvent; thus, known the user's religion, the robot would probably talk about related religious festivities.
    /// <see href="http://caressesrobot.org/ontology#BeliefSystem"></see></summary>
    let BeliefSystem =
        Namespaced_IRI.parse _namespace_name "BeliefSystem" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about events relevant for the user's life
    /// <see href="http://caressesrobot.org/ontology#hasEvent"></see></summary>
    let hasEvent = Namespaced_IRI.parse _namespace_name "hasEvent" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Birthday"></see>
    /// </summary>
    let Birthday = Namespaced_IRI.parse _namespace_name "Birthday" |> NamespacedName

    /// <summary>
    /// Any event that takes place regularly every year
    /// <see href="http://caressesrobot.org/ontology#YearlyEvent"></see></summary>
    let YearlyEvent =
        Namespaced_IRI.parse _namespace_name "YearlyEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Book"></see>
    /// </summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Writer"></see>
    /// </summary>
    let Writer = Namespaced_IRI.parse _namespace_name "Writer" |> NamespacedName
    /// <summary>
    /// ObjectProperty used for let the robot talk about persons relevant for the user's life
    /// <see href="http://caressesrobot.org/ontology#hasPerson"></see></summary>
    let hasPerson = Namespaced_IRI.parse _namespace_name "hasPerson" |> NamespacedName
    /// <summary>
    /// Parameter for the VideoCall action (Audio or Video call)
    /// <see href="http://caressesrobot.org/ontology#CallMode"></see></summary>
    let CallMode = Namespaced_IRI.parse _namespace_name "CallMode" |> NamespacedName

    /// <summary>
    /// The habit of celebrating events (holidays, festivities, ... )
    /// <see href="http://caressesrobot.org/ontology#CelebratingEvents"></see></summary>
    let CelebratingEvents =
        Namespaced_IRI.parse _namespace_name "CelebratingEvents" |> NamespacedName

    /// <summary>
    /// Activities, routines or behaviors that are regularly repeated by the user.
    ///
    /// Individuals of this class may be filled with Individuals to the class Time for the ObjectProperty hasCondition (conversation topics may be triggered in some specific period of the day) or hasTime (the robot may investigate if habits take place in specific times of the day).
    /// <see href="http://caressesrobot.org/ontology#Habit"></see></summary>
    let Habit = Namespaced_IRI.parse _namespace_name "Habit" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Childhood"></see>
    /// </summary>
    let Childhood = Namespaced_IRI.parse _namespace_name "Childhood" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Pet"></see>
    /// </summary>
    let Pet = Namespaced_IRI.parse _namespace_name "Pet" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasPet"></see>
    /// </summary>
    let hasPet = Namespaced_IRI.parse _namespace_name "hasPet" |> NamespacedName
    /// <summary>
    /// ObjectProperty used for let the robot talk about user's regular / periodical activities
    /// <see href="http://caressesrobot.org/ontology#hasHabit"></see></summary>
    let hasHabit = Namespaced_IRI.parse _namespace_name "hasHabit" |> NamespacedName

    /// <summary>
    /// Relevant facts for the user's past and present life (chilldhood, education, heritage, work, ...)
    /// <see href="http://caressesrobot.org/ontology#TopicAboutOnesLife"></see></summary>
    let TopicAboutOnesLife =
        Namespaced_IRI.parse _namespace_name "TopicAboutOnesLife" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#CircleOfFriend"></see>
    /// </summary>
    let CircleOfFriend =
        Namespaced_IRI.parse _namespace_name "CircleOfFriend" |> NamespacedName

    /// <summary>
    /// Social relationships that influence the user's life (friends, family, ...)
    /// <see href="http://caressesrobot.org/ontology#SocialEnvironment"></see></summary>
    let SocialEnvironment =
        Namespaced_IRI.parse _namespace_name "SocialEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Clothing"></see>
    /// </summary>
    let Clothing = Namespaced_IRI.parse _namespace_name "Clothing" |> NamespacedName
    /// <summary>
    /// A nation with its own government
    /// <see href="http://caressesrobot.org/ontology#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Town"></see>
    /// </summary>
    let Town = Namespaced_IRI.parse _namespace_name "Town" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasTown"></see>
    /// </summary>
    let hasTown = Namespaced_IRI.parse _namespace_name "hasTown" |> NamespacedName

    /// <summary>
    /// Action or sequence of actions that are daily executed by the user. Possible Subclasses are: DoingPhysicalExercises, GettingDressed, HavingMeal, TakingMedicine, TakingCareOfOneself, and many others
    /// <see href="http://caressesrobot.org/ontology#DailyRoutine"></see></summary>
    let DailyRoutine =
        Namespaced_IRI.parse _namespace_name "DailyRoutine" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#PeriodOfTheDay"></see>
    /// </summary>
    let PeriodOfTheDay =
        Namespaced_IRI.parse _namespace_name "PeriodOfTheDay" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasTime"></see>
    /// </summary>
    let hasTime = Namespaced_IRI.parse _namespace_name "hasTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Dance"></see>
    /// </summary>
    let Dance = Namespaced_IRI.parse _namespace_name "Dance" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#DayOfTheWeek"></see>
    /// </summary>
    let DayOfTheWeek =
        Namespaced_IRI.parse _namespace_name "DayOfTheWeek" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Time"></see>
    /// </summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#DeathOfAClosePerson"></see>
    /// </summary>
    let DeathOfAClosePerson =
        Namespaced_IRI.parse _namespace_name "DeathOfAClosePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Drink"></see>
    /// </summary>
    let Drink = Namespaced_IRI.parse _namespace_name "Drink" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#FoodAndDrink"></see>
    /// </summary>
    let FoodAndDrink =
        Namespaced_IRI.parse _namespace_name "FoodAndDrink" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Education"></see>
    /// </summary>
    let Education = Namespaced_IRI.parse _namespace_name "Education" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Entity"></see>
    /// </summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasRelative"></see>
    /// </summary>
    let hasRelative =
        Namespaced_IRI.parse _namespace_name "hasRelative" |> NamespacedName

    /// <summary>
    /// The position of something expressed in relative terms (e.g. Close, Far, VeryFar, ... )
    /// <see href="http://caressesrobot.org/ontology#RelativeLocation"></see></summary>
    let RelativeLocation =
        Namespaced_IRI.parse _namespace_name "RelativeLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasRelatLocation"></see>
    /// </summary>
    let hasRelatLocation =
        Namespaced_IRI.parse _namespace_name "hasRelatLocation" |> NamespacedName

    /// <summary>
    /// Possible Subclasses are FeelingAfraid, FeelingAngry, FeelingLonely, FeelingWorried, ...
    /// <see href="http://caressesrobot.org/ontology#FeelingBad"></see></summary>
    let FeelingBad = Namespaced_IRI.parse _namespace_name "FeelingBad" |> NamespacedName

    /// <summary>
    /// The condition or state of the body or mind
    /// <see href="http://caressesrobot.org/ontology#PhysicalAndMentalCondition"></see></summary>
    let PhysicalAndMentalCondition =
        Namespaced_IRI.parse _namespace_name "PhysicalAndMentalCondition" |> NamespacedName

    /// <summary>
    /// Possible Subclasses are FeelingExcited, FeelingHappy, FeelingRelaxed, FeelingStrong, ...
    /// <see href="http://caressesrobot.org/ontology#FeelingWell"></see></summary>
    let FeelingWell =
        Namespaced_IRI.parse _namespace_name "FeelingWell" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Food"></see>
    /// </summary>
    let Food = Namespaced_IRI.parse _namespace_name "Food" |> NamespacedName
    /// <summary>
    /// Dietary restrictions, that may be related to religious or ethical aspects. Possible Subclasses are EatingHalal, EatingKosher, EatingVegetarian, ...
    /// <see href="http://caressesrobot.org/ontology#FoodNorm"></see></summary>
    let FoodNorm = Namespaced_IRI.parse _namespace_name "FoodNorm" |> NamespacedName
    /// <summary>
    /// Guidelines about what is considered correct or incorrect speaking of social behavior in a particular group, social unit or cultural identities.
    /// <see href="http://caressesrobot.org/ontology#Norm"></see></summary>
    let Norm = Namespaced_IRI.parse _namespace_name "Norm" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Frequency"></see>
    /// </summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName
    /// <summary>
    /// Persons in the social, physical and cultural environemnt of the user
    /// <see href="http://caressesrobot.org/ontology#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// Coordinates of objects in the environment
    /// <see href="http://caressesrobot.org/ontology#hasCoordinates"></see></summary>
    let hasCoordinates =
        Namespaced_IRI.parse _namespace_name "hasCoordinates" |> NamespacedName

    /// <summary>
    /// Inclusion relationship between Objects and/or Location
    /// <see href="http://caressesrobot.org/ontology#hasIn"></see></summary>
    let hasIn = Namespaced_IRI.parse _namespace_name "hasIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Game"></see>
    /// </summary>
    let Game = Namespaced_IRI.parse _namespace_name "Game" |> NamespacedName
    /// <summary>
    /// The DataProperty hasPDDL encode the related string, in PDDL formalism, that should be sent to the planner when the goal is required
    /// <see href="http://caressesrobot.org/ontology#Goal"></see></summary>
    let Goal = Namespaced_IRI.parse _namespace_name "Goal" |> NamespacedName

    /// <summary>
    /// Confirmation to be shown on the robot's tablet
    /// <see href="http://caressesrobot.org/ontology#hasTablet-view"></see></summary>
    let ``hasTablet-view`` =
        Namespaced_IRI.parse _namespace_name "hasTablet-view" |> NamespacedName

    /// <summary>
    /// Question to be shown on the tablet
    /// <see href="http://caressesrobot.org/ontology#hasQuestion-t"></see></summary>
    let ``hasQuestion-t`` =
        Namespaced_IRI.parse _namespace_name "hasQuestion-t" |> NamespacedName

    /// <summary>
    /// Planning tasks (written in the PDDL formalism) that should be sent to the planner
    /// <see href="http://caressesrobot.org/ontology#hasPDDL"></see></summary>
    let hasPDDL = Namespaced_IRI.parse _namespace_name "hasPDDL" |> NamespacedName

    /// <summary>
    /// The condition of having health problems can be related to medicines taken by the user
    /// <see href="http://caressesrobot.org/ontology#HavingHealthProblems"></see></summary>
    let HavingHealthProblems =
        Namespaced_IRI.parse _namespace_name "HavingHealthProblems" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Medication"></see>
    /// </summary>
    let Medication = Namespaced_IRI.parse _namespace_name "Medication" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about medicines relevant for the user
    /// <see href="http://caressesrobot.org/ontology#hasMedicine"></see></summary>
    let hasMedicine =
        Namespaced_IRI.parse _namespace_name "hasMedicine" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Heritage"></see>
    /// </summary>
    let Heritage = Namespaced_IRI.parse _namespace_name "Heritage" |> NamespacedName

    /// <summary>
    /// Relevant facts in the areas of politics, military, science, music, sports, arts, entertainment, ...
    /// <see href="http://caressesrobot.org/ontology#HistoricFactOrPeriod"></see></summary>
    let HistoricFactOrPeriod =
        Namespaced_IRI.parse _namespace_name "HistoricFactOrPeriod" |> NamespacedName

    /// <summary>
    /// Activities done regularly in one's leisure time for pleasure. They may be chosen accordingly to the specific targets (i.e. older adults). Examples of SubClasses may be ReadingABook, WatchingAMovie, DoingSomeCooking, GoingToAClub, MakingHennaTattoos, ...
    /// <see href="http://caressesrobot.org/ontology#Hobby"></see></summary>
    let Hobby = Namespaced_IRI.parse _namespace_name "Hobby" |> NamespacedName
    /// <summary>
    /// Basic entities to perceive or measure: shapes, colors, sizes, sounds, smells,...
    /// <see href="http://caressesrobot.org/ontology#Quality"></see></summary>
    let Quality = Namespaced_IRI.parse _namespace_name "Quality" |> NamespacedName

    /// <summary>
    /// Filler of this ObjectProperty is an Event or Time or Quality that allows the robot to talk about a specific topic
    /// <see href="http://caressesrobot.org/ontology#hasNecessaryCondition"></see></summary>
    let hasNecessaryCondition =
        Namespaced_IRI.parse _namespace_name "hasNecessaryCondition" |> NamespacedName

    /// <summary>
    /// The building where one lives. Examples of SubClasses are Apartment, CareHome (for the specific case of older adults to which the CARESSES Ontology is addressed)
    /// <see href="http://caressesrobot.org/ontology#Home"></see></summary>
    let Home = Namespaced_IRI.parse _namespace_name "Home" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Room"></see>
    /// </summary>
    let Room = Namespaced_IRI.parse _namespace_name "Room" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Hour"></see>
    /// </summary>
    let Hour = Namespaced_IRI.parse _namespace_name "Hour" |> NamespacedName

    /// <summary>
    /// Field used for automatically building sentences
    /// <see href="http://caressesrobot.org/ontology#hasPrep-object"></see></summary>
    let ``hasPrep-object`` =
        Namespaced_IRI.parse _namespace_name "hasPrep-object" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasHome"></see>
    /// </summary>
    let hasHome = Namespaced_IRI.parse _namespace_name "hasHome" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasCountry"></see>
    /// </summary>
    let hasCountry = Namespaced_IRI.parse _namespace_name "hasCountry" |> NamespacedName
    /// <summary>
    /// Definitions of polite or acceptable social behaviours. They may be chosen accordingly to the specific targets (i.e. older adults) and cultural identities. Examples of SubClasses are GivingPresentsToRelativeOrFriend, StackingDishesAfterMeal, ...
    /// <see href="http://caressesrobot.org/ontology#Manner"></see></summary>
    let Manner = Namespaced_IRI.parse _namespace_name "Manner" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#MedicalStaff"></see>
    /// </summary>
    let MedicalStaff =
        Namespaced_IRI.parse _namespace_name "MedicalStaff" |> NamespacedName

    /// <summary>
    /// Messages encoded for the SendMsgAction
    /// <see href="http://caressesrobot.org/ontology#Message"></see></summary>
    let Message = Namespaced_IRI.parse _namespace_name "Message" |> NamespacedName
    /// <summary>
    /// Preloaded messages for the SendMessageAction
    /// <see href="http://caressesrobot.org/ontology#hasMessage"></see></summary>
    let hasMessage = Namespaced_IRI.parse _namespace_name "hasMessage" |> NamespacedName

    /// <summary>
    /// Compulsory recipient for related messages.
    /// <see href="http://caressesrobot.org/ontology#hasCompulsory-recipient"></see></summary>
    let ``hasCompulsory-recipient`` =
        Namespaced_IRI.parse _namespace_name "hasCompulsory-recipient" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Movie"></see>
    /// </summary>
    let Movie = Namespaced_IRI.parse _namespace_name "Movie" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasActor"></see>
    /// </summary>
    let hasActor = Namespaced_IRI.parse _namespace_name "hasActor" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Music"></see>
    /// </summary>
    let Music = Namespaced_IRI.parse _namespace_name "Music" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Song"></see>
    /// </summary>
    let Song = Namespaced_IRI.parse _namespace_name "Song" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasSong"></see>
    /// </summary>
    let hasSong = Namespaced_IRI.parse _namespace_name "hasSong" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Singer"></see>
    /// </summary>
    let Singer = Namespaced_IRI.parse _namespace_name "Singer" |> NamespacedName
    /// <summary>
    /// This class includes all Operators that should  be sent to the planner for the execution of actions. Operators achieve Goals by implementing Actions
    /// <see href="http://caressesrobot.org/ontology#Operator"></see></summary>
    let Operator = Namespaced_IRI.parse _namespace_name "Operator" |> NamespacedName
    /// <summary>
    /// UDDL file describing the operator
    /// <see href="http://caressesrobot.org/ontology#hasUDDL"></see></summary>
    let hasUDDL = Namespaced_IRI.parse _namespace_name "hasUDDL" |> NamespacedName
    /// <summary>
    /// ObjectProperty used for let the robot talk about possible activities
    /// <see href="http://caressesrobot.org/ontology#hasGoal"></see></summary>
    let hasGoal = Namespaced_IRI.parse _namespace_name "hasGoal" |> NamespacedName
    /// <summary>
    /// A relation that holds between Operators and Actions
    /// <see href="http://caressesrobot.org/ontology#hasAction"></see></summary>
    let hasAction = Namespaced_IRI.parse _namespace_name "hasAction" |> NamespacedName
    /// <summary>
    /// Phone number of user's contacts
    /// <see href="http://caressesrobot.org/ontology#hasPhone"></see></summary>
    let hasPhone = Namespaced_IRI.parse _namespace_name "hasPhone" |> NamespacedName

    /// <summary>
    /// Telegram account of user's contact accounts
    /// <see href="http://caressesrobot.org/ontology#hasTelegram"></see></summary>
    let hasTelegram =
        Namespaced_IRI.parse _namespace_name "hasTelegram" |> NamespacedName

    /// <summary>
    /// Skype account of user contacts
    /// <see href="http://caressesrobot.org/ontology#hasSkype"></see></summary>
    let hasSkype = Namespaced_IRI.parse _namespace_name "hasSkype" |> NamespacedName
    /// <summary>
    /// Line account of the user's contact
    /// <see href="http://caressesrobot.org/ontology#hasLine"></see></summary>
    let hasLine = Namespaced_IRI.parse _namespace_name "hasLine" |> NamespacedName
    /// <summary>
    /// E-mail address of contacts
    /// <see href="http://caressesrobot.org/ontology#hasEmail"></see></summary>
    let hasEmail = Namespaced_IRI.parse _namespace_name "hasEmail" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#PersonalCareObject"></see>
    /// </summary>
    let PersonalCareObject =
        Namespaced_IRI.parse _namespace_name "PersonalCareObject" |> NamespacedName

    /// <summary>
    /// Individuals of this class may be filled with Individuals of the class FoodNorm for the ObjectProperty hasNorm; thus, known the user's religion, the robot would probably investigate aspects related to possible alimentary restrictions
    ///
    /// Individuals of this class may be filled with Individuals of the class ReligiousCulturalEvent for the ObjectProperty hasEvent; thus, known the user's religion, the robot would probably talk about related religious festivities.
    /// <see href="http://caressesrobot.org/ontology#Religion"></see></summary>
    let Religion = Namespaced_IRI.parse _namespace_name "Religion" |> NamespacedName
    /// <summary>
    /// ObjectProperty used for let the robot talk about social norms
    /// <see href="http://caressesrobot.org/ontology#hasNorm"></see></summary>
    let hasNorm = Namespaced_IRI.parse _namespace_name "hasNorm" |> NamespacedName

    /// <summary>
    /// Any event related to religious celebrations
    /// <see href="http://caressesrobot.org/ontology#ReligiousCulturalEvent"></see></summary>
    let ReligiousCulturalEvent =
        Namespaced_IRI.parse _namespace_name "ReligiousCulturalEvent" |> NamespacedName

    /// <summary>
    /// The user's robot . An instance of the class Robot may be connected with instances of the class Goal, in order to encode all goals that may be achieved by the robot
    /// <see href="http://caressesrobot.org/ontology#Robot"></see></summary>
    let Robot = Namespaced_IRI.parse _namespace_name "Robot" |> NamespacedName

    /// <summary>
    /// Relationship of closeness between Objects and/or Locations
    /// <see href="http://caressesrobot.org/ontology#hasAdjacent"></see></summary>
    let hasAdjacent =
        Namespaced_IRI.parse _namespace_name "hasAdjacent" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Season"></see>
    /// </summary>
    let Season = Namespaced_IRI.parse _namespace_name "Season" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasRoom"></see>
    /// </summary>
    let hasRoom = Namespaced_IRI.parse _namespace_name "hasRoom" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#SmartDevice"></see>
    /// </summary>
    let SmartDevice =
        Namespaced_IRI.parse _namespace_name "SmartDevice" |> NamespacedName

    /// <summary>
    /// Operations that can be executed with smart devices
    /// <see href="http://caressesrobot.org/ontology#hasOperations"></see></summary>
    let hasOperations =
        Namespaced_IRI.parse _namespace_name "hasOperations" |> NamespacedName

    /// <summary>
    /// Type of the smart devices (device - sensor)
    /// <see href="http://caressesrobot.org/ontology#hasType"></see></summary>
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName
    /// <summary>
    /// Possible status of the smart device
    /// <see href="http://caressesrobot.org/ontology#hasStatus"></see></summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName

    /// <summary>
    /// String for automatically composing sentences. It refers to Smart Devices
    /// <see href="http://caressesrobot.org/ontology#hasAs-sensor"></see></summary>
    let ``hasAs-sensor`` =
        Namespaced_IRI.parse _namespace_name "hasAs-sensor" |> NamespacedName

    /// <summary>
    /// Location of the smart device
    /// <see href="http://caressesrobot.org/ontology#hasLocations"></see></summary>
    let hasLocations =
        Namespaced_IRI.parse _namespace_name "hasLocations" |> NamespacedName

    /// <summary>
    /// Any occasion/event that involves social interaction.
    /// <see href="http://caressesrobot.org/ontology#SocialEvent"></see></summary>
    let SocialEvent =
        Namespaced_IRI.parse _namespace_name "SocialEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Sport"></see>
    /// </summary>
    let Sport = Namespaced_IRI.parse _namespace_name "Sport" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#SportsPlayer"></see>
    /// </summary>
    let SportsPlayer =
        Namespaced_IRI.parse _namespace_name "SportsPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasSportsPlayer"></see>
    /// </summary>
    let hasSportsPlayer =
        Namespaced_IRI.parse _namespace_name "hasSportsPlayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#TVChannel"></see>
    /// </summary>
    let TVChannel = Namespaced_IRI.parse _namespace_name "TVChannel" |> NamespacedName

    /// <summary>
    /// Webpage for the readnews action
    /// <see href="http://caressesrobot.org/ontology#hasUrl-root"></see></summary>
    let ``hasUrl-root`` =
        Namespaced_IRI.parse _namespace_name "hasUrl-root" |> NamespacedName

    /// <summary>
    /// Webpage for the ReadNewsAction
    /// <see href="http://caressesrobot.org/ontology#hasUrl-article"></see></summary>
    let ``hasUrl-article`` =
        Namespaced_IRI.parse _namespace_name "hasUrl-article" |> NamespacedName

    /// <summary>
    /// 12 hr or 24hr
    /// <see href="http://caressesrobot.org/ontology#TimeFormat"></see></summary>
    let TimeFormat = Namespaced_IRI.parse _namespace_name "TimeFormat" |> NamespacedName

    /// <summary>
    /// Likeliness value for conversation topics. It corresponds to a reasonable estimate, to the best of available knowledge, of the a posteriori probability of the assertion.
    /// - In the Culture-Specific Layer, Likeliness values are used to specify how appropriate each instance is for the each culture, and guide the robot’s behaviour.
    /// - In the Person-Specific Layer, the likeliness corresponds to the evidence of the assertion collected through interaction with the user.
    /// <see href="http://caressesrobot.org/ontology#hasLikeliness"></see></summary>
    let hasLikeliness =
        Namespaced_IRI.parse _namespace_name "hasLikeliness" |> NamespacedName

    /// <summary>
    /// Triggering keyword for conversation topics
    /// <see href="http://caressesrobot.org/ontology#hasKeyword1"></see></summary>
    let hasKeyword1 =
        Namespaced_IRI.parse _namespace_name "hasKeyword1" |> NamespacedName

    /// <summary>
    /// Triggering keyword for conversation topics
    /// <see href="http://caressesrobot.org/ontology#hasKeyword2"></see></summary>
    let hasKeyword2 =
        Namespaced_IRI.parse _namespace_name "hasKeyword2" |> NamespacedName

    /// <summary>
    /// hasFull field for building configuration files of actions
    /// <see href="http://caressesrobot.org/ontology#hasFull"></see></summary>
    let hasFull = Namespaced_IRI.parse _namespace_name "hasFull" |> NamespacedName
    /// <summary>
    /// String value for handling triggering and necessary conditions
    /// <see href="http://caressesrobot.org/ontology#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName
    /// <summary>
    /// Field used to automatically generate sentences
    /// <see href="http://caressesrobot.org/ontology#hasName"></see></summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    /// Instances, belonging to the Person-Specific ABox layer, are fillers of the corresponding instances in the Culture-Specific ABox layer for the hasSpecific property,
    /// <see href="http://caressesrobot.org/ontology#hasSpecific"></see></summary>
    let hasSpecific =
        Namespaced_IRI.parse _namespace_name "hasSpecific" |> NamespacedName

    /// <summary>
    /// Person to which the user-specific information of the Ontology refers
    /// <see href="http://caressesrobot.org/ontology#User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName
    /// <summary>
    /// ObjectProperty used for let the robot talk about games
    /// <see href="http://caressesrobot.org/ontology#hasGame"></see></summary>
    let hasGame = Namespaced_IRI.parse _namespace_name "hasGame" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasPhysicalEnvironment"></see>
    /// </summary>
    let hasPhysicalEnvironment =
        Namespaced_IRI.parse _namespace_name "hasPhysicalEnvironment" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about food
    /// <see href="http://caressesrobot.org/ontology#hasFood"></see></summary>
    let hasFood = Namespaced_IRI.parse _namespace_name "hasFood" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about possible ways to address the user
    /// <see href="http://caressesrobot.org/ontology#hasAddressing"></see></summary>
    let hasAddressing =
        Namespaced_IRI.parse _namespace_name "hasAddressing" |> NamespacedName

    /// <summary>
    /// Relationships between User and Objects
    /// <see href="http://caressesrobot.org/ontology#hasObject"></see></summary>
    let hasObject = Namespaced_IRI.parse _namespace_name "hasObject" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasFeeling"></see>
    /// </summary>
    let hasFeeling = Namespaced_IRI.parse _namespace_name "hasFeeling" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about user's religion
    /// <see href="http://caressesrobot.org/ontology#hasReligion"></see></summary>
    let hasReligion =
        Namespaced_IRI.parse _namespace_name "hasReligion" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about the physical and mental state of the user
    /// <see href="http://caressesrobot.org/ontology#hasPhysicalAndMentalState"></see></summary>
    let hasPhysicalAndMentalState =
        Namespaced_IRI.parse _namespace_name "hasPhysicalAndMentalState" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about good manners
    /// <see href="http://caressesrobot.org/ontology#hasManner"></see></summary>
    let hasManner = Namespaced_IRI.parse _namespace_name "hasManner" |> NamespacedName
    /// <summary>
    /// ObjectProperty used for let the robot talk about the user's clothes
    /// <see href="http://caressesrobot.org/ontology#hasCloth"></see></summary>
    let hasCloth = Namespaced_IRI.parse _namespace_name "hasCloth" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasMusic"></see>
    /// </summary>
    let hasMusic = Namespaced_IRI.parse _namespace_name "hasMusic" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about user's beliefs and values
    /// <see href="http://caressesrobot.org/ontology#hasBeliefAndValue"></see></summary>
    let hasBeliefAndValue =
        Namespaced_IRI.parse _namespace_name "hasBeliefAndValue" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about the user's life
    /// <see href="http://caressesrobot.org/ontology#hasLife"></see></summary>
    let hasLife = Namespaced_IRI.parse _namespace_name "hasLife" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasSocialEnvironment"></see>
    /// </summary>
    let hasSocialEnvironment =
        Namespaced_IRI.parse _namespace_name "hasSocialEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasHealthProblem"></see>
    /// </summary>
    let hasHealthProblem =
        Namespaced_IRI.parse _namespace_name "hasHealthProblem" |> NamespacedName

    /// <summary>
    /// ObjectProperty used for let the robot talk about the user's health
    /// <see href="http://caressesrobot.org/ontology#hasHealth"></see></summary>
    let hasHealth = Namespaced_IRI.parse _namespace_name "hasHealth" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasRobot"></see>
    /// </summary>
    let hasRobot = Namespaced_IRI.parse _namespace_name "hasRobot" |> NamespacedName
    /// <summary>
    /// Voice volume for all actions involving verbal interaction
    /// <see href="http://caressesrobot.org/ontology#Volume"></see></summary>
    let Volume = Namespaced_IRI.parse _namespace_name "Volume" |> NamespacedName
    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#Work"></see>
    /// </summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName
    /// <summary>
    /// All object properties that allow the robot to talk about conversation topics
    /// <see href="http://caressesrobot.org/ontology#hasTopic"></see></summary>
    let hasTopic = Namespaced_IRI.parse _namespace_name "hasTopic" |> NamespacedName

    /// <summary>
    /// Correlations between Individuals, even belonging to different Classes. An HCorrelation implies that, if a UserSpecific instances with an high DataProperty HasLikeliness value is added, the hasLiklelines of the other individuals should be increased. A VLCorrelation impliease that if a UserSpecific instances with an high DataProperty HasLikeliness value is added, the hasLiklelines of the other individuals should be decreased.
    /// <see href="http://caressesrobot.org/ontology#hasCorrelation"></see></summary>
    let hasCorrelation =
        Namespaced_IRI.parse _namespace_name "hasCorrelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasFamily"></see>
    /// </summary>
    let hasFamily = Namespaced_IRI.parse _namespace_name "hasFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasFrequency"></see>
    /// </summary>
    let hasFrequency =
        Namespaced_IRI.parse _namespace_name "hasFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasHCorrelation"></see>
    /// </summary>
    let hasHCorrelation =
        Namespaced_IRI.parse _namespace_name "hasHCorrelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasMCorrelation"></see>
    /// </summary>
    let hasMCorrelation =
        Namespaced_IRI.parse _namespace_name "hasMCorrelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasQuality"></see>
    /// </summary>
    let hasQuality = Namespaced_IRI.parse _namespace_name "hasQuality" |> NamespacedName

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
    let hasSentence =
        Namespaced_IRI.parse _namespace_name "hasSentence" |> NamespacedName

    /// <summary>
    /// Filler of this ObjectProperty is an Event or Time or Quality that triggers a specific dialogue
    /// <see href="http://caressesrobot.org/ontology#hasTriggeringCondition"></see></summary>
    let hasTriggeringCondition =
        Namespaced_IRI.parse _namespace_name "hasTriggeringCondition" |> NamespacedName

    /// <summary>
    /// youtube URL of the video
    /// <see href="http://caressesrobot.org/ontology#hasURL"></see></summary>
    let hasURL = Namespaced_IRI.parse _namespace_name "hasURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasVHCorrelation"></see>
    /// </summary>
    let hasVHCorrelation =
        Namespaced_IRI.parse _namespace_name "hasVHCorrelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://caressesrobot.org/ontology#hasVLCorrelation"></see>
    /// </summary>
    let hasVLCorrelation =
        Namespaced_IRI.parse _namespace_name "hasVLCorrelation" |> NamespacedName
