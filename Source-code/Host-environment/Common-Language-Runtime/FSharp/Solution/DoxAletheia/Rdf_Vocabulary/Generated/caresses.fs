namespace http.caressesrobot.org.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module caresses =
    let _namespace_iri = Namespace_Iri caresses |> NamespaceIRI
    /// <summary>
    ///   <para>caresses:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actions that may be executed by the robot. Actions are associate to parameters (Volume, Pitch, Speed, Language), to the username (Name), to the Suggestions (Topic)."</para>
    /// labels<para>"Action"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Action">http://caressesrobot.org/ontology#Action</seealso>
    let Action = Prefixed_Name(caresses, "Action") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Actor"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Actor">http://caressesrobot.org/ontology#Actor</seealso>
    let Actor = Prefixed_Name(caresses, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Addressing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Possible ways to address the user. In the context of the verbal interaction between the robot and the user, this conversation topic will be probably selected among the firsts (this is implemented by the ObjectProperty hasTriggeringCondition). Examples of subclasses may be: FirstName, MrLastName, MrsLastName, Nickname, ...
    ///
    /// The DataProperty hasNameforPlanner describes how the robot should actually address the person, and its value is usually encoded in a User-Specific Individual (E.g. for the class FirstName, the DataProperty hasNameforPlanner will include the actual first name of the user)"</para>
    /// labels<para>"Addressing"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Addressing">http://caressesrobot.org/ontology#Addressing</seealso>
    let Addressing = Prefixed_Name(caresses, "Addressing") |> PrefixedName
    /// <summary>
    ///   <para>caresses:AmusementPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AmusementPlace"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#AmusementPlace">http://caressesrobot.org/ontology#AmusementPlace</seealso>
    let AmusementPlace = Prefixed_Name(caresses, "AmusementPlace") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Appliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Appliance"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Appliance">http://caressesrobot.org/ontology#Appliance</seealso>
    let Appliance = Prefixed_Name(caresses, "Appliance") |> PrefixedName
    /// <summary>
    ///   <para>caresses:ArtObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract or physical object considered to fulfill a primarily independent aesthetic function."</para>
    /// labels<para>"ArtObject"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#ArtObject">http://caressesrobot.org/ontology#ArtObject</seealso>
    let ArtObject = Prefixed_Name(caresses, "ArtObject") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Atheism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lack of belief in gods and religions"</para>
    /// labels<para>"Atheism"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Atheism">http://caressesrobot.org/ontology#Atheism</seealso>
    let Atheism = Prefixed_Name(caresses, "Atheism") |> PrefixedName
    /// <summary>
    ///   <para>caresses:BeliefSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ideology or set of principles. It is mainly intended in the form of religion.
    ///
    /// Individuals of this class may be related to Individuals of the class ReligiousCulturalEvent; thus, known the user's religion, the robot would probably talk about related religious festivities."</para>
    /// labels<para>"BeliefSystem"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#BeliefSystem">http://caressesrobot.org/ontology#BeliefSystem</seealso>
    let BeliefSystem = Prefixed_Name(caresses, "BeliefSystem") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Birthday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Birthday"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Birthday">http://caressesrobot.org/ontology#Birthday</seealso>
    let Birthday = Prefixed_Name(caresses, "Birthday") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Book"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Book">http://caressesrobot.org/ontology#Book</seealso>
    let Book = Prefixed_Name(caresses, "Book") |> PrefixedName
    /// <summary>
    ///   <para>caresses:CallMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parameter for the VideoCall action (Audio or Video call)"</para>
    /// labels<para>"CallMode"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#CallMode">http://caressesrobot.org/ontology#CallMode</seealso>
    let CallMode = Prefixed_Name(caresses, "CallMode") |> PrefixedName
    /// <summary>
    ///   <para>caresses:CelebratingEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The habit of celebrating events (holidays, festivities, ... )"</para>
    /// labels<para>"CelebratingEvents"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#CelebratingEvents">http://caressesrobot.org/ontology#CelebratingEvents</seealso>
    let CelebratingEvents = Prefixed_Name(caresses, "CelebratingEvents") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Childhood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Childhood"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Childhood">http://caressesrobot.org/ontology#Childhood</seealso>
    let Childhood = Prefixed_Name(caresses, "Childhood") |> PrefixedName
    /// <summary>
    ///   <para>caresses:CircleOfFriend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CircleOfFriend"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#CircleOfFriend">http://caressesrobot.org/ontology#CircleOfFriend</seealso>
    let CircleOfFriend = Prefixed_Name(caresses, "CircleOfFriend") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Clothing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Clothing"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Clothing">http://caressesrobot.org/ontology#Clothing</seealso>
    let Clothing = Prefixed_Name(caresses, "Clothing") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A nation with its own government"</para>
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Country">http://caressesrobot.org/ontology#Country</seealso>
    let Country = Prefixed_Name(caresses, "Country") |> PrefixedName
    /// <summary>
    ///   <para>caresses:DailyRoutine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Action or sequence of actions that are daily executed by the user. Possible Subclasses are: DoingPhysicalExercises, GettingDressed, HavingMeal, TakingMedicine, TakingCareOfOneself, and many others"</para>
    /// labels<para>"DailyRoutine"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#DailyRoutine">http://caressesrobot.org/ontology#DailyRoutine</seealso>
    let DailyRoutine = Prefixed_Name(caresses, "DailyRoutine") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Dance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dance"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Dance">http://caressesrobot.org/ontology#Dance</seealso>
    let Dance = Prefixed_Name(caresses, "Dance") |> PrefixedName
    /// <summary>
    ///   <para>caresses:DayOfTheWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DayOfTheWeek"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#DayOfTheWeek">http://caressesrobot.org/ontology#DayOfTheWeek</seealso>
    let DayOfTheWeek = Prefixed_Name(caresses, "DayOfTheWeek") |> PrefixedName

    /// <summary>
    ///   <para>caresses:DeathOfAClosePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeathOfAClosePerson"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#DeathOfAClosePerson">http://caressesrobot.org/ontology#DeathOfAClosePerson</seealso>
    let DeathOfAClosePerson =
        Prefixed_Name(caresses, "DeathOfAClosePerson") |> PrefixedName

    /// <summary>
    ///   <para>caresses:Decoration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Decoration"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Decoration">http://caressesrobot.org/ontology#Decoration</seealso>
    let Decoration = Prefixed_Name(caresses, "Decoration") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Drink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Drink"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Drink">http://caressesrobot.org/ontology#Drink</seealso>
    let Drink = Prefixed_Name(caresses, "Drink") |> PrefixedName
    /// <summary>
    ///   <para>caresses:EatingPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EatingPlace"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#EatingPlace">http://caressesrobot.org/ontology#EatingPlace</seealso>
    let EatingPlace = Prefixed_Name(caresses, "EatingPlace") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Education"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Education">http://caressesrobot.org/ontology#Education</seealso>
    let Education = Prefixed_Name(caresses, "Education") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Entity">http://caressesrobot.org/ontology#Entity</seealso>
    let Entity = Prefixed_Name(caresses, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thing that has happened, or that takes place with regularity, independently from the user's activity"</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Event">http://caressesrobot.org/ontology#Event</seealso>
    let Event = Prefixed_Name(caresses, "Event") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Family"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Family">http://caressesrobot.org/ontology#Family</seealso>
    let Family = Prefixed_Name(caresses, "Family") |> PrefixedName
    /// <summary>
    ///   <para>caresses:FeelingBad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Possible Subclasses are FeelingAfraid, FeelingAngry, FeelingLonely, FeelingWorried, ..."</para>
    /// labels<para>"FeelingBad"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#FeelingBad">http://caressesrobot.org/ontology#FeelingBad</seealso>
    let FeelingBad = Prefixed_Name(caresses, "FeelingBad") |> PrefixedName
    /// <summary>
    ///   <para>caresses:FeelingWell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Possible Subclasses are FeelingExcited, FeelingHappy, FeelingRelaxed, FeelingStrong, ..."</para>
    /// labels<para>"FeelingWell"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#FeelingWell">http://caressesrobot.org/ontology#FeelingWell</seealso>
    let FeelingWell = Prefixed_Name(caresses, "FeelingWell") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Food"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Food">http://caressesrobot.org/ontology#Food</seealso>
    let Food = Prefixed_Name(caresses, "Food") |> PrefixedName
    /// <summary>
    ///   <para>caresses:FoodAndDrink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FoodAndDrink"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#FoodAndDrink">http://caressesrobot.org/ontology#FoodAndDrink</seealso>
    let FoodAndDrink = Prefixed_Name(caresses, "FoodAndDrink") |> PrefixedName
    /// <summary>
    ///   <para>caresses:FoodNorm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Dietary restrictions, that may be related to religious or ethical aspects. Possible Subclasses are EatingHalal, EatingKosher, EatingVegetarian, ..."</para>
    /// labels<para>"FoodNorm"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#FoodNorm">http://caressesrobot.org/ontology#FoodNorm</seealso>
    let FoodNorm = Prefixed_Name(caresses, "FoodNorm") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Frequency"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Frequency">http://caressesrobot.org/ontology#Frequency</seealso>
    let Frequency = Prefixed_Name(caresses, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Friend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Friend"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Friend">http://caressesrobot.org/ontology#Friend</seealso>
    let Friend = Prefixed_Name(caresses, "Friend") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Furniture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Furniture"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Furniture">http://caressesrobot.org/ontology#Furniture</seealso>
    let Furniture = Prefixed_Name(caresses, "Furniture") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Game</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Game"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Game">http://caressesrobot.org/ontology#Game</seealso>
    let Game = Prefixed_Name(caresses, "Game") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The DataProperty hasPDDL encode the related string, in PDDL formalism, that should be sent to the planner when the goal is required"</para>
    /// labels<para>"Goal"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Goal">http://caressesrobot.org/ontology#Goal</seealso>
    let Goal = Prefixed_Name(caresses, "Goal") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Habit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Activities, routines or behaviors that are regularly repeated by the user.
    ///
    /// Individuals of this class may be filled with Individuals to the class Time for the ObjectProperty hasCondition (conversation topics may be triggered in some specific period of the day) or hasTime (the robot may investigate if habits take place in specific times of the day)."</para>
    /// labels<para>"Habit"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Habit">http://caressesrobot.org/ontology#Habit</seealso>
    let Habit = Prefixed_Name(caresses, "Habit") |> PrefixedName

    /// <summary>
    ///   <para>caresses:HavingHealthProblems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The condition of having health problems can be related to medicines taken by the user"</para>
    /// labels<para>"HavingHealthProblems"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#HavingHealthProblems">http://caressesrobot.org/ontology#HavingHealthProblems</seealso>
    let HavingHealthProblems =
        Prefixed_Name(caresses, "HavingHealthProblems") |> PrefixedName

    /// <summary>
    ///   <para>caresses:Heritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heritage"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Heritage">http://caressesrobot.org/ontology#Heritage</seealso>
    let Heritage = Prefixed_Name(caresses, "Heritage") |> PrefixedName

    /// <summary>
    ///   <para>caresses:HistoricFactOrPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Relevant facts in the areas of politics, military, science, music, sports, arts, entertainment, ..."</para>
    /// labels<para>"HistoricFactOrPeriod"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#HistoricFactOrPeriod">http://caressesrobot.org/ontology#HistoricFactOrPeriod</seealso>
    let HistoricFactOrPeriod =
        Prefixed_Name(caresses, "HistoricFactOrPeriod") |> PrefixedName

    /// <summary>
    ///   <para>caresses:Hobby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Activities done regularly in one's leisure time for pleasure. They may be chosen accordingly to the specific targets (i.e. older adults). Examples of SubClasses may be ReadingABook, WatchingAMovie, DoingSomeCooking, GoingToAClub, MakingHennaTattoos, ..."</para>
    /// labels<para>"Hobby"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Hobby">http://caressesrobot.org/ontology#Hobby</seealso>
    let Hobby = Prefixed_Name(caresses, "Hobby") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Home</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The building where one lives. Examples of SubClasses are Apartment, CareHome (for the specific case of older adults to which the CARESSES Ontology is addressed)"</para>
    /// labels<para>"Home"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Home">http://caressesrobot.org/ontology#Home</seealso>
    let Home = Prefixed_Name(caresses, "Home") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hour"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Hour">http://caressesrobot.org/ontology#Hour</seealso>
    let Hour = Prefixed_Name(caresses, "Hour") |> PrefixedName
    /// <summary>
    ///   <para>caresses:HouseObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HouseObject"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#HouseObject">http://caressesrobot.org/ontology#HouseObject</seealso>
    let HouseObject = Prefixed_Name(caresses, "HouseObject") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Kitchenware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Kitchenware"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Kitchenware">http://caressesrobot.org/ontology#Kitchenware</seealso>
    let Kitchenware = Prefixed_Name(caresses, "Kitchenware") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parameter related to the language in which the sentences are written"</para>
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Language">http://caressesrobot.org/ontology#Language</seealso>
    let Language = Prefixed_Name(caresses, "Language") |> PrefixedName
    /// <summary>
    ///   <para>caresses:LivingPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LivingPlace"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#LivingPlace">http://caressesrobot.org/ontology#LivingPlace</seealso>
    let LivingPlace = Prefixed_Name(caresses, "LivingPlace") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical space or region, defined by geographical coordinates (absolute location) or expressed in relative terms (relative location)."</para>
    /// labels<para>"Location"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Location">http://caressesrobot.org/ontology#Location</seealso>
    let Location = Prefixed_Name(caresses, "Location") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Manner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Definitions of polite or acceptable social behaviours. They may be chosen accordingly to the specific targets (i.e. older adults) and cultural identities. Examples of SubClasses are GivingPresentsToRelativeOrFriend, StackingDishesAfterMeal, ..."</para>
    /// labels<para>"Manner"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Manner">http://caressesrobot.org/ontology#Manner</seealso>
    let Manner = Prefixed_Name(caresses, "Manner") |> PrefixedName
    /// <summary>
    ///   <para>caresses:MedicalStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MedicalStaff"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#MedicalStaff">http://caressesrobot.org/ontology#MedicalStaff</seealso>
    let MedicalStaff = Prefixed_Name(caresses, "MedicalStaff") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Medication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Medication"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Medication">http://caressesrobot.org/ontology#Medication</seealso>
    let Medication = Prefixed_Name(caresses, "Medication") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Messages encoded for the SendMsgAction"</para>
    /// labels<para>"Message"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Message">http://caressesrobot.org/ontology#Message</seealso>
    let Message = Prefixed_Name(caresses, "Message") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Movie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Movie"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Movie">http://caressesrobot.org/ontology#Movie</seealso>
    let Movie = Prefixed_Name(caresses, "Movie") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Music</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Music"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Music">http://caressesrobot.org/ontology#Music</seealso>
    let Music = Prefixed_Name(caresses, "Music") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Norm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Guidelines about what is considered correct or incorrect speaking of social behavior in a particular group, social unit or cultural identities."</para>
    /// labels<para>"Norm"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Norm">http://caressesrobot.org/ontology#Norm</seealso>
    let Norm = Prefixed_Name(caresses, "Norm") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstracts objects, with no physical referents and that does not exist at any particular time or place, and concrete objects"</para>
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Object">http://caressesrobot.org/ontology#Object</seealso>
    let Object = Prefixed_Name(caresses, "Object") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class includes all Operators that should  be sent to the planner for the execution of actions. Operators achieve Goals by implementing Actions"</para>
    /// labels<para>"Operator"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Operator">http://caressesrobot.org/ontology#Operator</seealso>
    let Operator = Prefixed_Name(caresses, "Operator") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parameters associated to actions"</para>
    /// labels<para>"Parameter"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Parameter">http://caressesrobot.org/ontology#Parameter</seealso>
    let Parameter = Prefixed_Name(caresses, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>caresses:PeriodOfTheDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PeriodOfTheDay"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#PeriodOfTheDay">http://caressesrobot.org/ontology#PeriodOfTheDay</seealso>
    let PeriodOfTheDay = Prefixed_Name(caresses, "PeriodOfTheDay") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Persons in the social, physical and cultural environemnt of the user"</para>
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Person">http://caressesrobot.org/ontology#Person</seealso>
    let Person = Prefixed_Name(caresses, "Person") |> PrefixedName

    /// <summary>
    ///   <para>caresses:PersonalCareObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PersonalCareObject"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#PersonalCareObject">http://caressesrobot.org/ontology#PersonalCareObject</seealso>
    let PersonalCareObject =
        Prefixed_Name(caresses, "PersonalCareObject") |> PrefixedName

    /// <summary>
    ///   <para>caresses:Pet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pet"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Pet">http://caressesrobot.org/ontology#Pet</seealso>
    let Pet = Prefixed_Name(caresses, "Pet") |> PrefixedName

    /// <summary>
    ///   <para>caresses:PhysicalAndMentalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The condition or state of the body or mind"</para>
    /// labels<para>"PhysicalAndMentalCondition"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#PhysicalAndMentalCondition">http://caressesrobot.org/ontology#PhysicalAndMentalCondition</seealso>
    let PhysicalAndMentalCondition =
        Prefixed_Name(caresses, "PhysicalAndMentalCondition") |> PrefixedName

    /// <summary>
    ///   <para>caresses:PhysicalEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All tangible space regiones that support and influence the user's life"</para>
    /// labels<para>"PhysicalEnvironment"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#PhysicalEnvironment">http://caressesrobot.org/ontology#PhysicalEnvironment</seealso>
    let PhysicalEnvironment =
        Prefixed_Name(caresses, "PhysicalEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>caresses:Pitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Voice pitch for all actions involving verbal interaction"</para>
    /// labels<para>"Pitch"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Pitch">http://caressesrobot.org/ontology#Pitch</seealso>
    let Pitch = Prefixed_Name(caresses, "Pitch") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Proxemics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Distance parameter for the ApproachUser action"</para>
    /// labels<para>"Proxemics"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Proxemics">http://caressesrobot.org/ontology#Proxemics</seealso>
    let Proxemics = Prefixed_Name(caresses, "Proxemics") |> PrefixedName
    /// <summary>
    ///   <para>caresses:PublicPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PublicPerson"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#PublicPerson">http://caressesrobot.org/ontology#PublicPerson</seealso>
    let PublicPerson = Prefixed_Name(caresses, "PublicPerson") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Basic entities to perceive or measure: shapes, colors, sizes, sounds, smells,..."</para>
    /// labels<para>"Quality"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Quality">http://caressesrobot.org/ontology#Quality</seealso>
    let Quality = Prefixed_Name(caresses, "Quality") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Relative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Relative"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Relative">http://caressesrobot.org/ontology#Relative</seealso>
    let Relative = Prefixed_Name(caresses, "Relative") |> PrefixedName
    /// <summary>
    ///   <para>caresses:RelativeLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The position of something expressed in relative terms (e.g. Close, Far, VeryFar, ... )"</para>
    /// labels<para>"RelativeLocation"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#RelativeLocation">http://caressesrobot.org/ontology#RelativeLocation</seealso>
    let RelativeLocation = Prefixed_Name(caresses, "RelativeLocation") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Religion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Individuals of this class may be filled with Individuals of the class FoodNorm for the ObjectProperty hasNorm; thus, known the user's religion, the robot would probably investigate aspects related to possible alimentary restrictions
    ///
    /// Individuals of this class may be filled with Individuals of the class ReligiousCulturalEvent for the ObjectProperty hasEvent; thus, known the user's religion, the robot would probably talk about related religious festivities."</para>
    /// labels<para>"Religion"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Religion">http://caressesrobot.org/ontology#Religion</seealso>
    let Religion = Prefixed_Name(caresses, "Religion") |> PrefixedName

    /// <summary>
    ///   <para>caresses:ReligiousCulturalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any event related to religious celebrations"</para>
    /// labels<para>"ReligiousCulturalEvent"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#ReligiousCulturalEvent">http://caressesrobot.org/ontology#ReligiousCulturalEvent</seealso>
    let ReligiousCulturalEvent =
        Prefixed_Name(caresses, "ReligiousCulturalEvent") |> PrefixedName

    /// <summary>
    ///   <para>caresses:Robot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The user's robot . An instance of the class Robot may be connected with instances of the class Goal, in order to encode all goals that may be achieved by the robot"</para>
    /// labels<para>"Robot"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Robot">http://caressesrobot.org/ontology#Robot</seealso>
    let Robot = Prefixed_Name(caresses, "Robot") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Room"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Room">http://caressesrobot.org/ontology#Room</seealso>
    let Room = Prefixed_Name(caresses, "Room") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Season</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Season"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Season">http://caressesrobot.org/ontology#Season</seealso>
    let Season = Prefixed_Name(caresses, "Season") |> PrefixedName
    /// <summary>
    ///   <para>caresses:ShoppingPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ShoppingPlace"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#ShoppingPlace">http://caressesrobot.org/ontology#ShoppingPlace</seealso>
    let ShoppingPlace = Prefixed_Name(caresses, "ShoppingPlace") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Singer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Singer"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Singer">http://caressesrobot.org/ontology#Singer</seealso>
    let Singer = Prefixed_Name(caresses, "Singer") |> PrefixedName
    /// <summary>
    ///   <para>caresses:SleepingPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SleepingPlace"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#SleepingPlace">http://caressesrobot.org/ontology#SleepingPlace</seealso>
    let SleepingPlace = Prefixed_Name(caresses, "SleepingPlace") |> PrefixedName
    /// <summary>
    ///   <para>caresses:SmartDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SmartDevice"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#SmartDevice">http://caressesrobot.org/ontology#SmartDevice</seealso>
    let SmartDevice = Prefixed_Name(caresses, "SmartDevice") |> PrefixedName
    /// <summary>
    ///   <para>caresses:SocialEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Social relationships that influence the user's life (friends, family, ...)"</para>
    /// labels<para>"SocialEnvironment"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#SocialEnvironment">http://caressesrobot.org/ontology#SocialEnvironment</seealso>
    let SocialEnvironment = Prefixed_Name(caresses, "SocialEnvironment") |> PrefixedName
    /// <summary>
    ///   <para>caresses:SocialEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any occasion/event that involves social interaction."</para>
    /// labels<para>"SocialEvent"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#SocialEvent">http://caressesrobot.org/ontology#SocialEvent</seealso>
    let SocialEvent = Prefixed_Name(caresses, "SocialEvent") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Song</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Song"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Song">http://caressesrobot.org/ontology#Song</seealso>
    let Song = Prefixed_Name(caresses, "Song") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Voice speed for all actions involving verbal interaction"</para>
    /// labels<para>"Speed"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Speed">http://caressesrobot.org/ontology#Speed</seealso>
    let Speed = Prefixed_Name(caresses, "Speed") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Sport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sport"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Sport">http://caressesrobot.org/ontology#Sport</seealso>
    let Sport = Prefixed_Name(caresses, "Sport") |> PrefixedName
    /// <summary>
    ///   <para>caresses:SportsPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SportsPlayer"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#SportsPlayer">http://caressesrobot.org/ontology#SportsPlayer</seealso>
    let SportsPlayer = Prefixed_Name(caresses, "SportsPlayer") |> PrefixedName
    /// <summary>
    ///   <para>caresses:TVChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TVChannel"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#TVChannel">http://caressesrobot.org/ontology#TVChannel</seealso>
    let TVChannel = Prefixed_Name(caresses, "TVChannel") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Time"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Time">http://caressesrobot.org/ontology#Time</seealso>
    let Time = Prefixed_Name(caresses, "Time") |> PrefixedName
    /// <summary>
    ///   <para>caresses:TimeFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"12 hr or 24hr"</para>
    /// labels<para>"TimeFormat"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#TimeFormat">http://caressesrobot.org/ontology#TimeFormat</seealso>
    let TimeFormat = Prefixed_Name(caresses, "TimeFormat") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Conversation topics that may be explored by the robot.
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
    /// Culture-specific instances of subclasses of Topic may be filled with Person-specific instances for the hasSpecific ObjectProperty"</para>
    /// labels<para>"Topic"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Topic">http://caressesrobot.org/ontology#Topic</seealso>
    let Topic = Prefixed_Name(caresses, "Topic") |> PrefixedName

    /// <summary>
    ///   <para>caresses:TopicAboutOnesLife</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Relevant facts for the user's past and present life (chilldhood, education, heritage, work, ...)"</para>
    /// labels<para>"TopicAboutOnesLife"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#TopicAboutOnesLife">http://caressesrobot.org/ontology#TopicAboutOnesLife</seealso>
    let TopicAboutOnesLife =
        Prefixed_Name(caresses, "TopicAboutOnesLife") |> PrefixedName

    /// <summary>
    ///   <para>caresses:TopicOneCanHavePreferenceAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All things that may be expressed in terms of "preference" (e.g. what is your favourite ... ?)"</para>
    /// labels<para>"TopicOneCanHavePreferenceAbout"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#TopicOneCanHavePreferenceAbout">http://caressesrobot.org/ontology#TopicOneCanHavePreferenceAbout</seealso>
    let TopicOneCanHavePreferenceAbout =
        Prefixed_Name(caresses, "TopicOneCanHavePreferenceAbout") |> PrefixedName

    /// <summary>
    ///   <para>caresses:Town</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Town"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Town">http://caressesrobot.org/ontology#Town</seealso>
    let Town = Prefixed_Name(caresses, "Town") |> PrefixedName
    /// <summary>
    ///   <para>caresses:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Person to which the user-specific information of the Ontology refers"</para>
    /// labels<para>"User"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#User">http://caressesrobot.org/ontology#User</seealso>
    let User = Prefixed_Name(caresses, "User") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Voice volume for all actions involving verbal interaction"</para>
    /// labels<para>"Volume"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Volume">http://caressesrobot.org/ontology#Volume</seealso>
    let Volume = Prefixed_Name(caresses, "Volume") |> PrefixedName
    /// <summary>
    ///   <para>caresses:WaitingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Waiting Time parameter for the AcceptRequest Action"</para>
    /// labels<para>"WaitingTime"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#WaitingTime">http://caressesrobot.org/ontology#WaitingTime</seealso>
    let WaitingTime = Prefixed_Name(caresses, "WaitingTime") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Work"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Work">http://caressesrobot.org/ontology#Work</seealso>
    let Work = Prefixed_Name(caresses, "Work") |> PrefixedName
    /// <summary>
    ///   <para>caresses:Writer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Writer"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#Writer">http://caressesrobot.org/ontology#Writer</seealso>
    let Writer = Prefixed_Name(caresses, "Writer") |> PrefixedName
    /// <summary>
    ///   <para>caresses:YearlyEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any event that takes place regularly every year"</para>
    /// labels<para>"YearlyEvent"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#YearlyEvent">http://caressesrobot.org/ontology#YearlyEvent</seealso>
    let YearlyEvent = Prefixed_Name(caresses, "YearlyEvent") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation that holds between Operators and Actions"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasAction"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasAction">http://caressesrobot.org/ontology#hasAction</seealso>
    let hasAction = Prefixed_Name(caresses, "hasAction") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasActor"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasActor">http://caressesrobot.org/ontology#hasActor</seealso>
    let hasActor = Prefixed_Name(caresses, "hasActor") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasAddressing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about possible ways to address the user"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasAddressing"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasAddressing">http://caressesrobot.org/ontology#hasAddressing</seealso>
    let hasAddressing = Prefixed_Name(caresses, "hasAddressing") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasAdjacent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship of closeness between Objects and/or Locations"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasAdjacent"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasAdjacent">http://caressesrobot.org/ontology#hasAdjacent</seealso>
    let hasAdjacent = Prefixed_Name(caresses, "hasAdjacent") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasAs-sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"String for automatically composing sentences. It refers to Smart Devices"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasAs-sensor"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasAs-sensor">http://caressesrobot.org/ontology#hasAs-sensor</seealso>
    let hasAs_sensor = Prefixed_Name(caresses, "hasAs-sensor") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasBeliefAndValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about user's beliefs and values"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasBeliefAndValue"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasBeliefAndValue">http://caressesrobot.org/ontology#hasBeliefAndValue</seealso>
    let hasBeliefAndValue = Prefixed_Name(caresses, "hasBeliefAndValue") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasCParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Cultural Parameters to be associated to Actions"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasCParameter"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasCParameter">http://caressesrobot.org/ontology#hasCParameter</seealso>
    let hasCParameter = Prefixed_Name(caresses, "hasCParameter") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasCloth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about the user's clothes"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasCloth"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasCloth">http://caressesrobot.org/ontology#hasCloth</seealso>
    let hasCloth = Prefixed_Name(caresses, "hasCloth") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasCompulsory-recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Compulsory recipient for related messages."^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasCompulsory-recipient"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasCompulsory-recipient">http://caressesrobot.org/ontology#hasCompulsory-recipient</seealso>
    let hasCompulsory_recipient =
        Prefixed_Name(caresses, "hasCompulsory-recipient") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasCondition"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasCondition">http://caressesrobot.org/ontology#hasCondition</seealso>
    let hasCondition = Prefixed_Name(caresses, "hasCondition") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasConfFile1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual filler of this property is used for building the configuration files for the related action"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasConfFile1"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasConfFile1">http://caressesrobot.org/ontology#hasConfFile1</seealso>
    let hasConfFile1 = Prefixed_Name(caresses, "hasConfFile1") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasConfFile1Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Configuration file for actions"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasConfFile1Name"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasConfFile1Name">http://caressesrobot.org/ontology#hasConfFile1Name</seealso>
    let hasConfFile1Name = Prefixed_Name(caresses, "hasConfFile1Name") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasConfFile2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual filler of this property is used for building the configuration files for the related action"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasConfFile2"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasConfFile2">http://caressesrobot.org/ontology#hasConfFile2</seealso>
    let hasConfFile2 = Prefixed_Name(caresses, "hasConfFile2") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasConfFile2Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Configuration file for actions"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasConfFile2Name"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasConfFile2Name">http://caressesrobot.org/ontology#hasConfFile2Name</seealso>
    let hasConfFile2Name = Prefixed_Name(caresses, "hasConfFile2Name") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasConfirmation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Confirmation sentence before launching a goal"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasConfirmation"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasConfirmation">http://caressesrobot.org/ontology#hasConfirmation</seealso>
    let hasConfirmation = Prefixed_Name(caresses, "hasConfirmation") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Coordinates of objects in the environment"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasCoordinates"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasCoordinates">http://caressesrobot.org/ontology#hasCoordinates</seealso>
    let hasCoordinates = Prefixed_Name(caresses, "hasCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasCorrelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Correlations between Individuals, even belonging to different Classes. An HCorrelation implies that, if a UserSpecific instances with an high DataProperty HasLikeliness value is added, the hasLiklelines of the other individuals should be increased. A VLCorrelation impliease that if a UserSpecific instances with an high DataProperty HasLikeliness value is added, the hasLiklelines of the other individuals should be decreased."^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasCorrelation"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasCorrelation">http://caressesrobot.org/ontology#hasCorrelation</seealso>
    let hasCorrelation = Prefixed_Name(caresses, "hasCorrelation") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasCountry"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasCountry">http://caressesrobot.org/ontology#hasCountry</seealso>
    let hasCountry = Prefixed_Name(caresses, "hasCountry") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasDistance"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasDistance">http://caressesrobot.org/ontology#hasDistance</seealso>
    let hasDistance = Prefixed_Name(caresses, "hasDistance") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"E-mail address of contacts"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasEmail"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasEmail">http://caressesrobot.org/ontology#hasEmail</seealso>
    let hasEmail = Prefixed_Name(caresses, "hasEmail") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about events relevant for the user's life"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasEvent"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasEvent">http://caressesrobot.org/ontology#hasEvent</seealso>
    let hasEvent = Prefixed_Name(caresses, "hasEvent") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasFamily"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasFamily">http://caressesrobot.org/ontology#hasFamily</seealso>
    let hasFamily = Prefixed_Name(caresses, "hasFamily") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasFeeling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasFeeling"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasFeeling">http://caressesrobot.org/ontology#hasFeeling</seealso>
    let hasFeeling = Prefixed_Name(caresses, "hasFeeling") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasFood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about food"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasFood"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasFood">http://caressesrobot.org/ontology#hasFood</seealso>
    let hasFood = Prefixed_Name(caresses, "hasFood") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasFrequency"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasFrequency">http://caressesrobot.org/ontology#hasFrequency</seealso>
    let hasFrequency = Prefixed_Name(caresses, "hasFrequency") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasFull</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"hasFull field for building configuration files of actions"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasFull"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasFull">http://caressesrobot.org/ontology#hasFull</seealso>
    let hasFull = Prefixed_Name(caresses, "hasFull") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about games"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasGame"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasGame">http://caressesrobot.org/ontology#hasGame</seealso>
    let hasGame = Prefixed_Name(caresses, "hasGame") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasGoal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about possible activities"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasGoal"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasGoal">http://caressesrobot.org/ontology#hasGoal</seealso>
    let hasGoal = Prefixed_Name(caresses, "hasGoal") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasHCorrelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasHCorrelation">http://caressesrobot.org/ontology#hasHCorrelation</seealso>
    let hasHCorrelation = Prefixed_Name(caresses, "hasHCorrelation") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasHabit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about user's regular / periodical activities"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasHabit"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasHabit">http://caressesrobot.org/ontology#hasHabit</seealso>
    let hasHabit = Prefixed_Name(caresses, "hasHabit") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasHealth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about the user's health"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasHealth"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasHealth">http://caressesrobot.org/ontology#hasHealth</seealso>
    let hasHealth = Prefixed_Name(caresses, "hasHealth") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasHealthProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasHealthProblem"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasHealthProblem">http://caressesrobot.org/ontology#hasHealthProblem</seealso>
    let hasHealthProblem = Prefixed_Name(caresses, "hasHealthProblem") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasHome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasHome"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasHome">http://caressesrobot.org/ontology#hasHome</seealso>
    let hasHome = Prefixed_Name(caresses, "hasHome") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inclusion relationship between Objects and/or Location"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasIn"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasIn">http://caressesrobot.org/ontology#hasIn</seealso>
    let hasIn = Prefixed_Name(caresses, "hasIn") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasKeyword1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Triggering keyword for conversation topics"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasKeyword1"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasKeyword1">http://caressesrobot.org/ontology#hasKeyword1</seealso>
    let hasKeyword1 = Prefixed_Name(caresses, "hasKeyword1") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasKeyword2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Triggering keyword for conversation topics"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasKeyword2"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasKeyword2">http://caressesrobot.org/ontology#hasKeyword2</seealso>
    let hasKeyword2 = Prefixed_Name(caresses, "hasKeyword2") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasLanguage"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasLanguage">http://caressesrobot.org/ontology#hasLanguage</seealso>
    let hasLanguage = Prefixed_Name(caresses, "hasLanguage") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasLife</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about the user's life"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasLife"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasLife">http://caressesrobot.org/ontology#hasLife</seealso>
    let hasLife = Prefixed_Name(caresses, "hasLife") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasLikeliness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Likeliness value for conversation topics. It corresponds to a reasonable estimate, to the best of available knowledge, of the a posteriori probability of the assertion.
    /// - In the Culture-Specific Layer, Likeliness values are used to specify how appropriate each instance is for the each culture, and guide the robot’s behaviour.
    /// - In the Person-Specific Layer, the likeliness corresponds to the evidence of the assertion collected through interaction with the user."^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasLikeliness"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasLikeliness">http://caressesrobot.org/ontology#hasLikeliness</seealso>
    let hasLikeliness = Prefixed_Name(caresses, "hasLikeliness") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Line account of the user's contact"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasLine"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasLine">http://caressesrobot.org/ontology#hasLine</seealso>
    let hasLine = Prefixed_Name(caresses, "hasLine") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about places that are relevant for the user"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasLocation"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasLocation">http://caressesrobot.org/ontology#hasLocation</seealso>
    let hasLocation = Prefixed_Name(caresses, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasLocations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Location of the smart device"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasLocations"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasLocations">http://caressesrobot.org/ontology#hasLocations</seealso>
    let hasLocations = Prefixed_Name(caresses, "hasLocations") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasMCorrelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasMCorrelation">http://caressesrobot.org/ontology#hasMCorrelation</seealso>
    let hasMCorrelation = Prefixed_Name(caresses, "hasMCorrelation") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasManner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about good manners"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasManner"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasManner">http://caressesrobot.org/ontology#hasManner</seealso>
    let hasManner = Prefixed_Name(caresses, "hasManner") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasMedicine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about medicines relevant for the user"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasMedicine"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasMedicine">http://caressesrobot.org/ontology#hasMedicine</seealso>
    let hasMedicine = Prefixed_Name(caresses, "hasMedicine") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Preloaded messages for the SendMessageAction"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasMessage"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasMessage">http://caressesrobot.org/ontology#hasMessage</seealso>
    let hasMessage = Prefixed_Name(caresses, "hasMessage") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasMusic"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasMusic">http://caressesrobot.org/ontology#hasMusic</seealso>
    let hasMusic = Prefixed_Name(caresses, "hasMusic") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Field used to automatically generate sentences"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasName"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasName">http://caressesrobot.org/ontology#hasName</seealso>
    let hasName = Prefixed_Name(caresses, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasNameforPlanner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"String to be sent to the planner"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasNameforPlanner"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasNameforPlanner">http://caressesrobot.org/ontology#hasNameforPlanner</seealso>
    let hasNameforPlanner = Prefixed_Name(caresses, "hasNameforPlanner") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasNecessaryCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Filler of this ObjectProperty is an Event or Time or Quality that allows the robot to talk about a specific topic"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasNecessaryCondition"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasNecessaryCondition">http://caressesrobot.org/ontology#hasNecessaryCondition</seealso>
    let hasNecessaryCondition =
        Prefixed_Name(caresses, "hasNecessaryCondition") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasNorm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about social norms"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasNorm"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasNorm">http://caressesrobot.org/ontology#hasNorm</seealso>
    let hasNorm = Prefixed_Name(caresses, "hasNorm") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationships between User and Objects"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasObject"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasObject">http://caressesrobot.org/ontology#hasObject</seealso>
    let hasObject = Prefixed_Name(caresses, "hasObject") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasOperations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Operations that can be executed with smart devices"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasOperations"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasOperations">http://caressesrobot.org/ontology#hasOperations</seealso>
    let hasOperations = Prefixed_Name(caresses, "hasOperations") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasPDDL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Planning tasks (written in the PDDL formalism) that should be sent to the planner"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasPDDL"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasPDDL">http://caressesrobot.org/ontology#hasPDDL</seealso>
    let hasPDDL = Prefixed_Name(caresses, "hasPDDL") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about persons relevant for the user's life"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasPerson"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasPerson">http://caressesrobot.org/ontology#hasPerson</seealso>
    let hasPerson = Prefixed_Name(caresses, "hasPerson") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasPet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasPet"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasPet">http://caressesrobot.org/ontology#hasPet</seealso>
    let hasPet = Prefixed_Name(caresses, "hasPet") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Phone number of user's contacts"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasPhone"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasPhone">http://caressesrobot.org/ontology#hasPhone</seealso>
    let hasPhone = Prefixed_Name(caresses, "hasPhone") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasPhysicalAndMentalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about the physical and mental state of the user"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasPhysicalAndMentalState"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasPhysicalAndMentalState">http://caressesrobot.org/ontology#hasPhysicalAndMentalState</seealso>
    let hasPhysicalAndMentalState =
        Prefixed_Name(caresses, "hasPhysicalAndMentalState") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasPhysicalEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasPhysicalEnvironment"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasPhysicalEnvironment">http://caressesrobot.org/ontology#hasPhysicalEnvironment</seealso>
    let hasPhysicalEnvironment =
        Prefixed_Name(caresses, "hasPhysicalEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasPitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasPitch"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasPitch">http://caressesrobot.org/ontology#hasPitch</seealso>
    let hasPitch = Prefixed_Name(caresses, "hasPitch") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasPrep-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Field used for automatically building sentences"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasPrep-object"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasPrep-object">http://caressesrobot.org/ontology#hasPrep-object</seealso>
    let hasPrep_object = Prefixed_Name(caresses, "hasPrep-object") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasQuality"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasQuality">http://caressesrobot.org/ontology#hasQuality</seealso>
    let hasQuality = Prefixed_Name(caresses, "hasQuality") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasQuestion-t</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Question to be shown on the tablet"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasQuestion-t"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasQuestion-t">http://caressesrobot.org/ontology#hasQuestion-t</seealso>
    let hasQuestion_t = Prefixed_Name(caresses, "hasQuestion-t") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasRelatLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasRelatLocation"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasRelatLocation">http://caressesrobot.org/ontology#hasRelatLocation</seealso>
    let hasRelatLocation = Prefixed_Name(caresses, "hasRelatLocation") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasRelative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasRelative"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasRelative">http://caressesrobot.org/ontology#hasRelative</seealso>
    let hasRelative = Prefixed_Name(caresses, "hasRelative") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasReligion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ObjectProperty used for let the robot talk about user's religion"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasReligion"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasReligion">http://caressesrobot.org/ontology#hasReligion</seealso>
    let hasReligion = Prefixed_Name(caresses, "hasReligion") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasRobot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasRobot"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasRobot">http://caressesrobot.org/ontology#hasRobot</seealso>
    let hasRobot = Prefixed_Name(caresses, "hasRobot") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasRoom"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasRoom">http://caressesrobot.org/ontology#hasRoom</seealso>
    let hasRoom = Prefixed_Name(caresses, "hasRoom") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasSentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sentences that the robot may pronounce during  the interaction with the user. Subproperties of hasSentence may be:
    ///
    ///  hasQuestion (encoded sentences used by the robot to ask the general user's feeback about the topic)
    /// - hasQuestionContextual (encoded sentences used by the robot to ask the user's feedback related to the specific context)
    /// - hasQuestionGoal (encoded sentences used by the robot to ask the user about activities to be performed)
    /// - has PositiveSentence (encoded sentences used by the robot when a positive feedback is received)
    /// - has PositiveAndWait (encoded sentences used by the robot when a positive feedback is received. With these sentences, the robot invites the user to freely talk about a conversation topic)
    /// - hasNegativeSentence (encoded sentences used by the robot when a negative feedback is received)"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasSentence"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasSentence">http://caressesrobot.org/ontology#hasSentence</seealso>
    let hasSentence = Prefixed_Name(caresses, "hasSentence") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasSkype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Skype account of user contacts"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasSkype"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasSkype">http://caressesrobot.org/ontology#hasSkype</seealso>
    let hasSkype = Prefixed_Name(caresses, "hasSkype") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasSocialEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSocialEnvironment"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasSocialEnvironment">http://caressesrobot.org/ontology#hasSocialEnvironment</seealso>
    let hasSocialEnvironment =
        Prefixed_Name(caresses, "hasSocialEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasSong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSong"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasSong">http://caressesrobot.org/ontology#hasSong</seealso>
    let hasSong = Prefixed_Name(caresses, "hasSong") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasSpecific</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Instances, belonging to the Person-Specific ABox layer, are fillers of the corresponding instances in the Culture-Specific ABox layer for the hasSpecific property,"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasSpecific"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasSpecific">http://caressesrobot.org/ontology#hasSpecific</seealso>
    let hasSpecific = Prefixed_Name(caresses, "hasSpecific") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSpeed"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasSpeed">http://caressesrobot.org/ontology#hasSpeed</seealso>
    let hasSpeed = Prefixed_Name(caresses, "hasSpeed") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasSportsPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSportsPlayer"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasSportsPlayer">http://caressesrobot.org/ontology#hasSportsPlayer</seealso>
    let hasSportsPlayer = Prefixed_Name(caresses, "hasSportsPlayer") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Possible status of the smart device"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasStatus"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasStatus">http://caressesrobot.org/ontology#hasStatus</seealso>
    let hasStatus = Prefixed_Name(caresses, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasSuggestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSuggestion"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasSuggestion">http://caressesrobot.org/ontology#hasSuggestion</seealso>
    let hasSuggestion = Prefixed_Name(caresses, "hasSuggestion") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasTablet-view</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Confirmation to be shown on the robot's tablet"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasTablet-view"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasTablet-view">http://caressesrobot.org/ontology#hasTablet-view</seealso>
    let hasTablet_view = Prefixed_Name(caresses, "hasTablet-view") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasTelegram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Telegram account of user's contact accounts"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasTelegram"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasTelegram">http://caressesrobot.org/ontology#hasTelegram</seealso>
    let hasTelegram = Prefixed_Name(caresses, "hasTelegram") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTime"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasTime">http://caressesrobot.org/ontology#hasTime</seealso>
    let hasTime = Prefixed_Name(caresses, "hasTime") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"All object properties that allow the robot to talk about conversation topics"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasTopic"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasTopic">http://caressesrobot.org/ontology#hasTopic</seealso>
    let hasTopic = Prefixed_Name(caresses, "hasTopic") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasTown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTown"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasTown">http://caressesrobot.org/ontology#hasTown</seealso>
    let hasTown = Prefixed_Name(caresses, "hasTown") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasTriggeringCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Filler of this ObjectProperty is an Event or Time or Quality that triggers a specific dialogue"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasTriggeringCondition"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasTriggeringCondition">http://caressesrobot.org/ontology#hasTriggeringCondition</seealso>
    let hasTriggeringCondition =
        Prefixed_Name(caresses, "hasTriggeringCondition") |> PrefixedName

    /// <summary>
    ///   <para>caresses:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of the smart devices (device - sensor)"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasType"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasType">http://caressesrobot.org/ontology#hasType</seealso>
    let hasType = Prefixed_Name(caresses, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasUDDL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"UDDL file describing the operator"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasUDDL"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasUDDL">http://caressesrobot.org/ontology#hasUDDL</seealso>
    let hasUDDL = Prefixed_Name(caresses, "hasUDDL") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"youtube URL of the video"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasURL"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasURL">http://caressesrobot.org/ontology#hasURL</seealso>
    let hasURL = Prefixed_Name(caresses, "hasURL") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasUrl-article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Webpage for the ReadNewsAction"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasUrl-article"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasUrl-article">http://caressesrobot.org/ontology#hasUrl-article</seealso>
    let hasUrl_article = Prefixed_Name(caresses, "hasUrl-article") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasUrl-root</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Webpage for the readnews action"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasUrl-root"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasUrl-root">http://caressesrobot.org/ontology#hasUrl-root</seealso>
    let hasUrl_root = Prefixed_Name(caresses, "hasUrl-root") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasUserName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasUserName"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasUserName">http://caressesrobot.org/ontology#hasUserName</seealso>
    let hasUserName = Prefixed_Name(caresses, "hasUserName") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasVHCorrelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasVHCorrelation">http://caressesrobot.org/ontology#hasVHCorrelation</seealso>
    let hasVHCorrelation = Prefixed_Name(caresses, "hasVHCorrelation") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasVLCorrelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasVLCorrelation">http://caressesrobot.org/ontology#hasVLCorrelation</seealso>
    let hasVLCorrelation = Prefixed_Name(caresses, "hasVLCorrelation") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"String value for handling triggering and necessary conditions"^^&lt;http://w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral&gt;</para>
    /// labels<para>"hasValue"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasValue">http://caressesrobot.org/ontology#hasValue</seealso>
    let hasValue = Prefixed_Name(caresses, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>caresses:hasWaitingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasWaitingTime"</para></remarks>
    /// <seealso href="http://caressesrobot.org/ontology#hasWaitingTime">http://caressesrobot.org/ontology#hasWaitingTime</seealso>
    let hasWaitingTime = Prefixed_Name(caresses, "hasWaitingTime") |> PrefixedName
