namespace http.ns.inria.fr.ludo.v1.gamemodel.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ludo_gm =
    let _namespace_iri = Namespace_Iri ludo_gm |> NamespaceIRI
    /// <summary>
    ///   <para>ludo-gm:GameControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides game player the channel to control game objects</para>
    /// labels<para>Game Control</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameControl">http://ns.inria.fr/ludo/v1/gamemodel#GameControl</seealso>
    let GameControl = Prefixed_Name(ludo_gm, "GameControl") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:CompleteGameStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Complete Game Structure</para>
    /// labels<para>Complete Game Structure</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#CompleteGameStructure">http://ns.inria.fr/ludo/v1/gamemodel#CompleteGameStructure</seealso>
    let CompleteGameStructure =
        Prefixed_Name(ludo_gm, "CompleteGameStructure") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:Training-basedStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Training-based Structure</para>
    /// labels<para>Training-based Structure</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Training-basedStructure">http://ns.inria.fr/ludo/v1/gamemodel#Training-basedStructure</seealso>
    let Training_basedStructure =
        Prefixed_Name(ludo_gm, "Training-basedStructure") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:GamePlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The user of the game application who provides inputs to the game system as part of the gaming activity.</para>
    /// labels<para>Game Player</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GamePlayer">http://ns.inria.fr/ludo/v1/gamemodel#GamePlayer</seealso>
    let GamePlayer = Prefixed_Name(ludo_gm, "GamePlayer") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description of a situation which require game player to overcome a number of challenges in order to achieve the defined objectives. It is also commonly termed as game level in gaming jargon.</para>
    /// labels<para>Game Scenario</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameScenario">http://ns.inria.fr/ludo/v1/gamemodel#GameScenario</seealso>
    let GameScenario = Prefixed_Name(ludo_gm, "GameScenario") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has constraint</para>
    /// labels<para>Has constraint</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasConstraint">http://ns.inria.fr/ludo/v1/gamemodel#hasConstraint</seealso>
    let hasConstraint = Prefixed_Name(ludo_gm, "hasConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasDifficultyIndicatorValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Has difficulty indicator value</para>
    /// labels<para>Difficulty</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasDifficultyIndicatorValue">http://ns.inria.fr/ludo/v1/gamemodel#hasDifficultyIndicatorValue</seealso>
    let hasDifficultyIndicatorValue =
        Prefixed_Name(ludo_gm, "hasDifficultyIndicatorValue") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasEventTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property to relate a Game Structure or a Game Event with an Event Trigger</para>
    /// labels<para>Has event trigger</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTrigger">http://ns.inria.fr/ludo/v1/gamemodel#hasEventTrigger</seealso>
    let hasEventTrigger = Prefixed_Name(ludo_gm, "hasEventTrigger") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has force</para>
    /// labels<para>Has force</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasForce">http://ns.inria.fr/ludo/v1/gamemodel#hasForce</seealso>
    let hasForce = Prefixed_Name(ludo_gm, "hasForce") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasFrontEndDisplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has front end display</para>
    /// labels<para>Has front end display</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasFrontEndDisplay">http://ns.inria.fr/ludo/v1/gamemodel#hasFrontEndDisplay</seealso>
    let hasFrontEndDisplay =
        Prefixed_Name(ludo_gm, "hasFrontEndDisplay") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasGameAct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Act</para>
    /// labels<para>Has Game Act</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameAct">http://ns.inria.fr/ludo/v1/gamemodel#hasGameAct</seealso>
    let hasGameAct = Prefixed_Name(ludo_gm, "hasGameAct") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameActObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Act Object</para>
    /// labels<para>Has Game Act Object</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameActObject">http://ns.inria.fr/ludo/v1/gamemodel#hasGameActObject</seealso>
    let hasGameActObject = Prefixed_Name(ludo_gm, "hasGameActObject") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Attribute</para>
    /// labels<para>Has Game Attribute</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameAttribute">http://ns.inria.fr/ludo/v1/gamemodel#hasGameAttribute</seealso>
    let hasGameAttribute = Prefixed_Name(ludo_gm, "hasGameAttribute") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Context</para>
    /// labels<para>Has Game Context</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameContext">http://ns.inria.fr/ludo/v1/gamemodel#hasGameContext</seealso>
    let hasGameContext = Prefixed_Name(ludo_gm, "hasGameContext") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasGameControlInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Control Interface</para>
    /// labels<para>Has Game Control Interface</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameControlInterface">http://ns.inria.fr/ludo/v1/gamemodel#hasGameControlInterface</seealso>
    let hasGameControlInterface =
        Prefixed_Name(ludo_gm, "hasGameControlInterface") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasGameDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The game dimension refers to the virtual space of which the game simulation takes place. It can either be 2D or 3D.</para>
    /// labels<para>Has Game Dimension</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameDimension">http://ns.inria.fr/ludo/v1/gamemodel#hasGameDimension</seealso>
    let hasGameDimension = Prefixed_Name(ludo_gm, "hasGameDimension") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Event</para>
    /// labels<para>Has Game Event</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameEvent">http://ns.inria.fr/ludo/v1/gamemodel#hasGameEvent</seealso>
    let hasGameEvent = Prefixed_Name(ludo_gm, "hasGameEvent") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasGameKnowledgeBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Knowledge-Base</para>
    /// labels<para>Has Game Knowledge-Base</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameKnowledgeBase">http://ns.inria.fr/ludo/v1/gamemodel#hasGameKnowledgeBase</seealso>
    let hasGameKnowledgeBase =
        Prefixed_Name(ludo_gm, "hasGameKnowledgeBase") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasGameObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates with a Game Objective. Can be used for Game Scenario and Inventory objects.</para>
    /// labels<para>Has Game Objective</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameObjective">http://ns.inria.fr/ludo/v1/gamemodel#hasGameObjective</seealso>
    let hasGameObjective = Prefixed_Name(ludo_gm, "hasGameObjective") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGamePlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Player</para>
    /// labels<para>Has Game Player</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGamePlayer">http://ns.inria.fr/ludo/v1/gamemodel#hasGamePlayer</seealso>
    let hasGamePlayer = Prefixed_Name(ludo_gm, "hasGamePlayer") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Record</para>
    /// labels<para>Has Game Record</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameRecord">http://ns.inria.fr/ludo/v1/gamemodel#hasGameRecord</seealso>
    let hasGameRecord = Prefixed_Name(ludo_gm, "hasGameRecord") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a Game Simulation with a Game Rule</para>
    /// labels<para>Has Game Rule</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameRule">http://ns.inria.fr/ludo/v1/gamemodel#hasGameRule</seealso>
    let hasGameRule = Prefixed_Name(ludo_gm, "hasGameRule") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:Presentation-basedStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Presentation-based Structure</para>
    /// labels<para>Presentation-based Structure</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Presentation-basedStructure">http://ns.inria.fr/ludo/v1/gamemodel#Presentation-basedStructure</seealso>
    let Presentation_basedStructure =
        Prefixed_Name(ludo_gm, "Presentation-basedStructure") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:Navigate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Navigate</para>
    /// labels<para>Navigate</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Navigate">http://ns.inria.fr/ludo/v1/gamemodel#Navigate</seealso>
    let Navigate = Prefixed_Name(ludo_gm, "Navigate") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents virtual things that populate the game world and can be designed to have a combination of abilities such as decision making, moving, acting and responding to surroundings and game players input simulating their existence in the game world.</para>
    /// labels<para>Game Object</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameObject">http://ns.inria.fr/ludo/v1/gamemodel#GameObject</seealso>
    let GameObject = Prefixed_Name(ludo_gm, "GameObject") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GamePresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A virtual canvas that holds media components and GUI components to form a game menu, a game notification or a cut-scene to present information about the game and allow them to navigate through the game structure</para>
    /// labels<para>Game Presentation</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GamePresentation">http://ns.inria.fr/ludo/v1/gamemodel#GamePresentation</seealso>
    let GamePresentation = Prefixed_Name(ludo_gm, "GamePresentation") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the simulation of a game scenario and is governed by a set of rules that define the interactivity, physical and temporal properties of the virtual world. It has game rules, game dimension, game tempo and game physics.</para>
    /// labels<para>Game Simulation</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameSimulation">http://ns.inria.fr/ludo/v1/gamemodel#GameSimulation</seealso>
    let GameSimulation = Prefixed_Name(ludo_gm, "GameSimulation") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameTheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes most of the art requirements related the game through expressive written text.</para>
    /// labels<para>Game Theme</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameTheme">http://ns.inria.fr/ludo/v1/gamemodel#GameTheme</seealso>
    let GameTheme = Prefixed_Name(ludo_gm, "GameTheme") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The mass that affects the motion of the game object</para>
    /// labels<para>Mass</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Mass">http://ns.inria.fr/ludo/v1/gamemodel#Mass</seealso>
    let Mass = Prefixed_Name(ludo_gm, "Mass") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Animation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An animation defines the virtual performance of a game object without reference of the position of the game object as a whole.</para>
    /// labels<para>Animation</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Animation">http://ns.inria.fr/ludo/v1/gamemodel#Animation</seealso>
    let Animation = Prefixed_Name(ludo_gm, "Animation") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Structure</para>
    /// labels<para>Has Game Structure</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameStructure">http://ns.inria.fr/ludo/v1/gamemodel#hasGameStructure</seealso>
    let hasGameStructure = Prefixed_Name(ludo_gm, "hasGameStructure") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameTheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Theme</para>
    /// labels<para>Has Game Theme</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameTheme">http://ns.inria.fr/ludo/v1/gamemodel#hasGameTheme</seealso>
    let hasGameTheme = Prefixed_Name(ludo_gm, "hasGameTheme") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasGoalConditionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The description of the goal condition</para>
    /// labels<para>Goal Condition description</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGoalConditionDescription">http://ns.inria.fr/ludo/v1/gamemodel#hasGoalConditionDescription</seealso>
    let hasGoalConditionDescription =
        Prefixed_Name(ludo_gm, "hasGoalConditionDescription") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasInputEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Input Event</para>
    /// labels<para>Has Input Event</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasInputEvent">http://ns.inria.fr/ludo/v1/gamemodel#hasInputEvent</seealso>
    let hasInputEvent = Prefixed_Name(ludo_gm, "hasInputEvent") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasIntelligences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Intelligences</para>
    /// labels<para>Has Intelligences</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasIntelligences">http://ns.inria.fr/ludo/v1/gamemodel#hasIntelligences</seealso>
    let hasIntelligences = Prefixed_Name(ludo_gm, "hasIntelligences") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A game record is a log of game players achievements in the game</para>
    /// labels<para>Game Record</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameRecord">http://ns.inria.fr/ludo/v1/gamemodel#GameRecord</seealso>
    let GameRecord = Prefixed_Name(ludo_gm, "GameRecord") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameTempo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the realtion between the pace of the time in a game and the time in the real world.</para>
    /// labels<para>Game Tempo</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameTempo">http://ns.inria.fr/ludo/v1/gamemodel#GameTempo</seealso>
    let GameTempo = Prefixed_Name(ludo_gm, "GameTempo") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Sound</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Sound">http://ns.inria.fr/ludo/v1/gamemodel#Sound</seealso>
    let Sound = Prefixed_Name(ludo_gm, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Video</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Video">http://ns.inria.fr/ludo/v1/gamemodel#Video</seealso>
    let Video = Prefixed_Name(ludo_gm, "Video") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The action of a game object, it consists of motion, animation, sound and vital updates.</para>
    /// labels<para>Action</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Action">http://ns.inria.fr/ludo/v1/gamemodel#Action</seealso>
    let Action = Prefixed_Name(ludo_gm, "Action") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:DecidingCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Deciding Condition</para>
    /// labels<para>Deciding Condition</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#DecidingCondition">http://ns.inria.fr/ludo/v1/gamemodel#DecidingCondition</seealso>
    let DecidingCondition = Prefixed_Name(ludo_gm, "DecidingCondition") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the virtual space in which the game simulation takes place in 2D or 3D.</para>
    /// labels<para>Game Dimension</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameDimension">http://ns.inria.fr/ludo/v1/gamemodel#GameDimension</seealso>
    let GameDimension = Prefixed_Name(ludo_gm, "GameDimension") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:SoidityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The solidity state defines if a game object is solid, whereas the mass affects the motion of the game object.</para>
    /// labels<para>Solidity State</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#SoidityState">http://ns.inria.fr/ludo/v1/gamemodel#SoidityState</seealso>
    let SoidityState = Prefixed_Name(ludo_gm, "SoidityState") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The amount of matter of an object in Kilograms.</para>
    /// labels<para>Mass</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasMass">http://ns.inria.fr/ludo/v1/gamemodel#hasMass</seealso>
    let hasMass = Prefixed_Name(ludo_gm, "hasMass") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasMotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Motion</para>
    /// labels<para>Has Motion</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasMotion">http://ns.inria.fr/ludo/v1/gamemodel#hasMotion</seealso>
    let hasMotion = Prefixed_Name(ludo_gm, "hasMotion") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasObjectVitality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Vitality of an object such as life or interrelated attributes such as health, energy, strength, social and etc.</para>
    /// labels<para>Has Object Vitality</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasObjectVitality">http://ns.inria.fr/ludo/v1/gamemodel#hasObjectVitality</seealso>
    let hasObjectVitality = Prefixed_Name(ludo_gm, "hasObjectVitality") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasPedagogicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Associates each game section with one or more pedagogic events from the Gagne's nine events of instructions. These events ordered in sequence are (1) gaining attention, (2) informing learning objectives, (3) recalling prior learning, (4) presenting learning content, (5) providing learning guidance, (6) eliciting performance, (7) provide feedback, (8) assess performance and, (9) enhance retention and transfer.</para>
    /// labels<para>Pedagogic Event</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasPedagogicEvent">http://ns.inria.fr/ludo/v1/gamemodel#hasPedagogicEvent</seealso>
    let hasPedagogicEvent = Prefixed_Name(ludo_gm, "hasPedagogicEvent") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasPedagogicEventIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Has Pedagogic Event Indicator</para>
    /// labels<para>Has Pedagogic Event Indicator</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasPedagogicEventIndicator">http://ns.inria.fr/ludo/v1/gamemodel#hasPedagogicEventIndicator</seealso>
    let hasPedagogicEventIndicator =
        Prefixed_Name(ludo_gm, "hasPedagogicEventIndicator") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasSoringRuleOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The outcome of an Scoring Rule</para>
    /// labels<para>Scoring Rule Outcome</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasSoringRuleOutcome">http://ns.inria.fr/ludo/v1/gamemodel#hasSoringRuleOutcome</seealso>
    let hasSoringRuleOutcome =
        Prefixed_Name(ludo_gm, "hasSoringRuleOutcome") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:Learn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Learn</para>
    /// labels<para>Learn</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Learn">http://ns.inria.fr/ludo/v1/gamemodel#Learn</seealso>
    let Learn = Prefixed_Name(ludo_gm, "Learn") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GoalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The goal condition checks a track-able value against a constant value defined by the game designer to determine if the game objective has been met or not. The game objective is marked as achieve once the goal condition has been satisfied.</para>
    /// labels<para>Goal Condition</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GoalCondition">http://ns.inria.fr/ludo/v1/gamemodel#GoalCondition</seealso>
    let GoalCondition = Prefixed_Name(ludo_gm, "GoalCondition") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GamePhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines the physicality of the game world. It encompasses the collision world and environment forces.</para>
    /// labels<para>Game Physics</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GamePhysics">http://ns.inria.fr/ludo/v1/gamemodel#GamePhysics</seealso>
    let GamePhysics = Prefixed_Name(ludo_gm, "GamePhysics") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Graphic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Graphic">http://ns.inria.fr/ludo/v1/gamemodel#Graphic</seealso>
    let Graphic = Prefixed_Name(ludo_gm, "Graphic") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Appearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The visual appearance of a game object</para>
    /// labels<para>Appearance</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Appearance">http://ns.inria.fr/ludo/v1/gamemodel#Appearance</seealso>
    let Appearance = Prefixed_Name(ludo_gm, "Appearance") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Score</para>
    /// labels<para>Score</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Score">http://ns.inria.fr/ludo/v1/gamemodel#Score</seealso>
    let Score = Prefixed_Name(ludo_gm, "Score") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Vital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Game designers can choose to represent the game object using a single vital definition such as life or further elaborate the vitality of a game object into interrelated attributes such as health, energy, strength, social and etc. </para>
    /// labels<para>Vital</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Vital">http://ns.inria.fr/ludo/v1/gamemodel#Vital</seealso>
    let Vital = Prefixed_Name(ludo_gm, "Vital") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:SeriousGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Serious Game</para>
    /// labels<para>Serious Game</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#SeriousGame">http://ns.inria.fr/ludo/v1/gamemodel#SeriousGame</seealso>
    let SeriousGame = Prefixed_Name(ludo_gm, "SeriousGame") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Intelligence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides game object the ability to decide, navigate and even learn.</para>
    /// labels<para>Intelligence</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Intelligence">http://ns.inria.fr/ludo/v1/gamemodel#Intelligence</seealso>
    let Intelligence = Prefixed_Name(ludo_gm, "Intelligence") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Is the happening associated to a game scenario. A game event is composed of a set of game act and an event trigger which initiate the game event.</para>
    /// labels<para>Game Event</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameEvent">http://ns.inria.fr/ludo/v1/gamemodel#GameEvent</seealso>
    let GameEvent = Prefixed_Name(ludo_gm, "GameEvent") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the goal associated to a game scenario</para>
    /// labels<para>Game Objective</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameObjective">http://ns.inria.fr/ludo/v1/gamemodel#GameObjective</seealso>
    let GameObjective = Prefixed_Name(ludo_gm, "GameObjective") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasAnimation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has animation</para>
    /// labels<para>Has animation</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasAnimation">http://ns.inria.fr/ludo/v1/gamemodel#hasAnimation</seealso>
    let hasAnimation = Prefixed_Name(ludo_gm, "hasAnimation") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an Area with any component to be represented graphically on the game screen, sucha as GUI components and Media components</para>
    /// labels<para>Has area</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasArea">http://ns.inria.fr/ludo/v1/gamemodel#hasArea</seealso>
    let hasArea = Prefixed_Name(ludo_gm, "hasArea") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:VirtualCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Viewport to the game world</para>
    /// labels<para>Virtual Camera</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#VirtualCamera">http://ns.inria.fr/ludo/v1/gamemodel#VirtualCamera</seealso>
    let VirtualCamera = Prefixed_Name(ludo_gm, "VirtualCamera") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasActingCoordination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The coordination of a game object can involve appear (for generation and re- spawning of game object), animating an action, playing a sound, moving towards a checkpoint, interacting with another game object or a composition of these.</para>
    /// labels<para>Has Game Acting Coordination</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasActingCoordination">http://ns.inria.fr/ludo/v1/gamemodel#hasActingCoordination</seealso>
    let hasActingCoordination =
        Prefixed_Name(ludo_gm, "hasActingCoordination") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has action</para>
    /// labels<para>Has action</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasAction">http://ns.inria.fr/ludo/v1/gamemodel#hasAction</seealso>
    let hasAction = Prefixed_Name(ludo_gm, "hasAction") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>States the relationship between game objects and game world, and the effect of an interaction. It can either be a Game Scoring Rule or Game Interaction Rule.</para>
    /// labels<para>Game Rule</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameRule">http://ns.inria.fr/ludo/v1/gamemodel#GameRule</seealso>
    let GameRule = Prefixed_Name(ludo_gm, "GameRule") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the architecture and flow of the game. It segments game into game sections. A game section is composed of a game context, pedagogic event indicator and event trigger.</para>
    /// labels<para>Game Structure</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameStructure">http://ns.inria.fr/ludo/v1/gamemodel#GameStructure</seealso>
    let GameStructure = Prefixed_Name(ludo_gm, "GameStructure") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasAnimationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the animation type, either 2D or 3D</para>
    /// labels<para>Has Animation Type</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasAnimationType">http://ns.inria.fr/ludo/v1/gamemodel#hasAnimationType</seealso>
    let hasAnimationType = Prefixed_Name(ludo_gm, "hasAnimationType") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasAppearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has appearance</para>
    /// labels<para>Has appearance</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasAppearance">http://ns.inria.fr/ludo/v1/gamemodel#hasAppearance</seealso>
    let hasAppearance = Prefixed_Name(ludo_gm, "hasAppearance") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Area</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Area">http://ns.inria.fr/ludo/v1/gamemodel#Area</seealso>
    let Area = Prefixed_Name(ludo_gm, "Area") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasArtRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has art requirement</para>
    /// labels<para>Has art requirement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasArtRequirement">http://ns.inria.fr/ludo/v1/gamemodel#hasArtRequirement</seealso>
    let hasArtRequirement = Prefixed_Name(ludo_gm, "hasArtRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasDifficultyIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has difficulty indicator</para>
    /// labels<para>Has difficulty indicator</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasDifficultyIndicator">http://ns.inria.fr/ludo/v1/gamemodel#hasDifficultyIndicator</seealso>
    let hasDifficultyIndicator =
        Prefixed_Name(ludo_gm, "hasDifficultyIndicator") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasEventTriggerClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Event triggers are used to invoke the transition between game sections and activate the game events within a game scenario. They can be classified into four distinct classes, namely: Input trigger detects user input via hardware interface or graphical user interface (GUI); Time trigger is essentially a countdown timer with an interval value with frequency of once, to repeat infinitely or to repeat finitely; Proximity trigger like input trigger has a hotspot that detects the collision of a specified game object, a class of game object or a group of game objects from different classes; Game mechanics trigger is associated to a range of game application related of events such media event, game event and simulation event. Each event trigger is associated with a command that specify the transition between game sections or activation of a game event.</para>
    /// labels<para>Has Event Trigger Class</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTriggerClass">http://ns.inria.fr/ludo/v1/gamemodel#hasEventTriggerClass</seealso>
    let hasEventTriggerClass =
        Prefixed_Name(ludo_gm, "hasEventTriggerClass") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:InventoryState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The inventory is defined to hold a limited supply of consumable for a game object.</para>
    /// labels<para>Inventory State</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#InventoryState">http://ns.inria.fr/ludo/v1/gamemodel#InventoryState</seealso>
    let InventoryState = Prefixed_Name(ludo_gm, "InventoryState") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Motion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Motion refers to the actual translation of game object position in the game world. A motion is subject to a force and also constraints (external force).</para>
    /// labels<para>Motion</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Motion">http://ns.inria.fr/ludo/v1/gamemodel#Motion</seealso>
    let Motion = Prefixed_Name(ludo_gm, "Motion") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasGameEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Environment</para>
    /// labels<para>Has Game Environment</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameEnvironment">http://ns.inria.fr/ludo/v1/gamemodel#hasGameEnvironment</seealso>
    let hasGameEnvironment =
        Prefixed_Name(ludo_gm, "hasGameEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasGameObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property applies for a Game Environment, a Serious Game and an Inventory</para>
    /// labels<para>Has Game Object</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameObject">http://ns.inria.fr/ludo/v1/gamemodel#hasGameObject</seealso>
    let hasGameObject = Prefixed_Name(ludo_gm, "hasGameObject") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGamePhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Has Game Physics</para>
    /// labels<para>Has Game Physics</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGamePhysics">http://ns.inria.fr/ludo/v1/gamemodel#hasGamePhysics</seealso>
    let hasGamePhysics = Prefixed_Name(ludo_gm, "hasGamePhysics") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Result</para>
    /// labels<para>Has Game Result</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameResult">http://ns.inria.fr/ludo/v1/gamemodel#hasGameResult</seealso>
    let hasGameResult = Prefixed_Name(ludo_gm, "hasGameResult") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Scenario</para>
    /// labels<para>Has Game Scenario</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameScenario">http://ns.inria.fr/ludo/v1/gamemodel#hasGameScenario</seealso>
    let hasGameScenario = Prefixed_Name(ludo_gm, "hasGameScenario") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameTempo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Tempo</para>
    /// labels<para>Has Game Tempo</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameTempo">http://ns.inria.fr/ludo/v1/gamemodel#hasGameTempo</seealso>
    let hasGameTempo = Prefixed_Name(ludo_gm, "hasGameTempo") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGoalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Goal Condition</para>
    /// labels<para>Has Goal Condition</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGoalCondition">http://ns.inria.fr/ludo/v1/gamemodel#hasGoalCondition</seealso>
    let hasGoalCondition = Prefixed_Name(ludo_gm, "hasGoalCondition") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasHardwareInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Examples of hardware interface include keyboard, mouse, gamepad, joystick, motionsensor, camera and microphone.</para>
    /// labels<para>Has hardware Interface</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasHardwareInterface">http://ns.inria.fr/ludo/v1/gamemodel#hasHardwareInterface</seealso>
    let hasHardwareInterface =
        Prefixed_Name(ludo_gm, "hasHardwareInterface") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasInteractionCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>It refers to the state of actor or the state of the game world</para>
    /// labels<para>Interaction Condition</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionCondition">http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionCondition</seealso>
    let hasInteractionCondition =
        Prefixed_Name(ludo_gm, "hasInteractionCondition") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasInteractionRuleOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Interaction Rule Outcome</para>
    /// labels<para>Interaction Rule Outcome</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleOutcome">http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleOutcome</seealso>
    let hasInteractionRuleOutcome =
        Prefixed_Name(ludo_gm, "hasInteractionRuleOutcome") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasInteractionRuleOutcomeOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Rewarding the player with any game object can mean give (add) or take away (subtract) an item or increase (add) or decrease (subtract) in the value of an attribute to provide the game player the advantage to succeed in the game.</para>
    /// labels<para>Interaction Rule Outcome Operation</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleOutcomeOperation">http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleOutcomeOperation</seealso>
    let hasInteractionRuleOutcomeOperation =
        Prefixed_Name(ludo_gm, "hasInteractionRuleOutcomeOperation") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasInteractionRuleSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Interaction Rule Subject</para>
    /// labels<para>Interaction Rule Subject</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleSubject">http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleSubject</seealso>
    let hasInteractionRuleSubject =
        Prefixed_Name(ludo_gm, "hasInteractionRuleSubject") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasInventory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Inventory</para>
    /// labels<para>Has Inventory</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasInventory">http://ns.inria.fr/ludo/v1/gamemodel#hasInventory</seealso>
    let hasInventory = Prefixed_Name(ludo_gm, "hasInventory") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasEventTriggerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Has Event trigger command</para>
    /// labels<para>Has Event trigger command</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTriggerCommand">http://ns.inria.fr/ludo/v1/gamemodel#hasEventTriggerCommand</seealso>
    let hasEventTriggerCommand =
        Prefixed_Name(ludo_gm, "hasEventTriggerCommand") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasGameActingScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Game Acting Script</para>
    /// labels<para>Game Acting Script</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameActingScript">http://ns.inria.fr/ludo/v1/gamemodel#hasGameActingScript</seealso>
    let hasGameActingScript =
        Prefixed_Name(ludo_gm, "hasGameActingScript") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasGameControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Control</para>
    /// labels<para>Has Game Control</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameControl">http://ns.inria.fr/ludo/v1/gamemodel#hasGameControl</seealso>
    let hasGameControl = Prefixed_Name(ludo_gm, "hasGameControl") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasGameDimention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Game Dimention</para>
    /// labels<para>Has Game Dimention</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameDimention">http://ns.inria.fr/ludo/v1/gamemodel#hasGameDimention</seealso>
    let hasGameDimention = Prefixed_Name(ludo_gm, "hasGameDimention") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:VitalUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Revises the value of vitals for a game object as a measure that takes into account the cost of an action inflicted to the object or the cost of performing an action.</para>
    /// labels<para>Vital Update</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#VitalUpdate">http://ns.inria.fr/ludo/v1/gamemodel#VitalUpdate</seealso>
    let VitalUpdate = Prefixed_Name(ludo_gm, "VitalUpdate") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Given the increasing amount of structured data published on the Web, many possibilities are open for creating new types of games that use resources from the Web of Data. In particular, if we consider the subcategory of Serious Games in which the object of the game is to educate the user through the interactive discovery of real-life concepts (associated to Semantic Web resources), the inclusion of a semantic representation of the user profile and his contextual information becomes an important element to recommend the user more accurate concepts. Ludo is an ontology that allows the creation of Serious Games with those characteristics.</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#">http://ns.inria.fr/ludo/v1/gamemodel#</seealso>
    let _prefix_iri = Prefixed_Name(ludo_gm, "") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasInteractionRuleActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Interaction Rule Actor</para>
    /// labels<para>Interaction Rule Actor</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleActor">http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleActor</seealso>
    let hasInteractionRuleActor =
        Prefixed_Name(ludo_gm, "hasInteractionRuleActor") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasInventoryQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Has inventory quantity</para>
    /// labels<para>Has inventory quantity</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasInventoryQuantity">http://ns.inria.fr/ludo/v1/gamemodel#hasInventoryQuantity</seealso>
    let hasInventoryQuantity =
        Prefixed_Name(ludo_gm, "hasInventoryQuantity") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Each game rule is paired with an outcome which has a matter and an operation to add or subtract a value from the matter. Matter in the context of game refers to an item, an attribute or permission.</para>
    /// labels<para>Interaction Rule Outcome Matter</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasMatter">http://ns.inria.fr/ludo/v1/gamemodel#hasMatter</seealso>
    let hasMatter = Prefixed_Name(ludo_gm, "hasMatter") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasNormalForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The normal force</para>
    /// labels<para>Normal force</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasNormalForce">http://ns.inria.fr/ludo/v1/gamemodel#hasNormalForce</seealso>
    let hasNormalForce = Prefixed_Name(ludo_gm, "hasNormalForce") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasObjectVitalityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Object Vitality Value</para>
    /// labels<para>Object Vitality Value</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasObjectVitalityValue">http://ns.inria.fr/ludo/v1/gamemodel#hasObjectVitalityValue</seealso>
    let hasObjectVitalityValue =
        Prefixed_Name(ludo_gm, "hasObjectVitalityValue") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasScoringCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Every game scoring rule has a scoring condition which has no direct relation with interaction. It can be derived from the state of a game object (e.g. enemy is dead or fire is extinguished), the input statistics (e.g. accuracy is above 80%), the time (e.g. respond is less than 5 seconds or level completed in less than 5 minutes), or the game objective (e.g. objective 1, 2 and 5 are met).</para>
    /// labels<para>Scoring Condition</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasScoringCondition">http://ns.inria.fr/ludo/v1/gamemodel#hasScoringCondition</seealso>
    let hasScoringCondition =
        Prefixed_Name(ludo_gm, "hasScoringCondition") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasSound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Sound</para>
    /// labels<para>Has Sound</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasSound">http://ns.inria.fr/ludo/v1/gamemodel#hasSound</seealso>
    let hasSound = Prefixed_Name(ludo_gm, "hasSound") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Uniform Resource Identifier</para>
    /// labels<para>URI</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasURI">http://ns.inria.fr/ludo/v1/gamemodel#hasURI</seealso>
    let hasURI = Prefixed_Name(ludo_gm, "hasURI") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasVirtualCameraPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Position of the virtual camera in the game world</para>
    /// labels<para>Has Virtual Camera Position</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasVirtualCameraPosition">http://ns.inria.fr/ludo/v1/gamemodel#hasVirtualCameraPosition</seealso>
    let hasVirtualCameraPosition =
        Prefixed_Name(ludo_gm, "hasVirtualCameraPosition") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:isSolid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Solidity</para>
    /// labels<para>Solidity</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#isSolid">http://ns.inria.fr/ludo/v1/gamemodel#isSolid</seealso>
    let isSolid = Prefixed_Name(ludo_gm, "isSolid") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:ArtRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Art requirements related the game through expressive written text</para>
    /// labels<para>Art Requirement</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#ArtRequirement">http://ns.inria.fr/ludo/v1/gamemodel#ArtRequirement</seealso>
    let ArtRequirement = Prefixed_Name(ludo_gm, "ArtRequirement") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Button</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Button</para>
    /// labels<para>Button</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Button">http://ns.inria.fr/ludo/v1/gamemodel#Button</seealso>
    let Button = Prefixed_Name(ludo_gm, "Button") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Checkbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Checkbox</para>
    /// labels<para>Checkbox</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Checkbox">http://ns.inria.fr/ludo/v1/gamemodel#Checkbox</seealso>
    let Checkbox = Prefixed_Name(ludo_gm, "Checkbox") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasTempoScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The tempo scale at which the time is passing. This can be used for slow motion effects. When timeScale is 1.0 the time is passing as fast as realtime. When timeScale is 0.5 the time is passing 2x slower than realtime. When timeScale is set to zero the game is basically paused if all your functions are frame rate independent.y. Based on: http://docs.unity3d.com/ScriptReference/Time-timeScale.html</para>
    /// labels<para>Game tempo scale</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasTempoScale">http://ns.inria.fr/ludo/v1/gamemodel#hasTempoScale</seealso>
    let hasTempoScale = Prefixed_Name(ludo_gm, "hasTempoScale") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasVirtualCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has Virtual Camera</para>
    /// labels<para>Has Virtual Camera</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasVirtualCamera">http://ns.inria.fr/ludo/v1/gamemodel#hasVirtualCamera</seealso>
    let hasVirtualCamera = Prefixed_Name(ludo_gm, "hasVirtualCamera") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:hasVitalUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Has Vital Update</para>
    /// labels<para>Has Vital Update</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasVitalUpdate">http://ns.inria.fr/ludo/v1/gamemodel#hasVitalUpdate</seealso>
    let hasVitalUpdate = Prefixed_Name(ludo_gm, "hasVitalUpdate") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GUIComponent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GUIComponent">http://ns.inria.fr/ludo/v1/gamemodel#GUIComponent</seealso>
    let GUIComponent = Prefixed_Name(ludo_gm, "GUIComponent") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:ComputedResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Computed result</para>
    /// labels<para>Computed result</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#ComputedResult">http://ns.inria.fr/ludo/v1/gamemodel#ComputedResult</seealso>
    let ComputedResult = Prefixed_Name(ludo_gm, "ComputedResult") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:RawResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Raw result</para>
    /// labels<para>Raw result</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#RawResult">http://ns.inria.fr/ludo/v1/gamemodel#RawResult</seealso>
    let RawResult = Prefixed_Name(ludo_gm, "RawResult") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Game Result</para>
    /// labels<para>Game Result</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameResult">http://ns.inria.fr/ludo/v1/gamemodel#GameResult</seealso>
    let GameResult = Prefixed_Name(ludo_gm, "GameResult") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:DifficultyIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value associated to the difficulty of the game scenario</para>
    /// labels<para>Difficulty Indicator</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#DifficultyIndicator">http://ns.inria.fr/ludo/v1/gamemodel#DifficultyIndicator</seealso>
    let DifficultyIndicator =
        Prefixed_Name(ludo_gm, "DifficultyIndicator") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:Force</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A motion is subject to a force</para>
    /// labels<para>Force</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Force">http://ns.inria.fr/ludo/v1/gamemodel#Force</seealso>
    let Force = Prefixed_Name(ludo_gm, "Force") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameActingScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Is composed by one or more acting coordination that instruct how a specific game object act in a defined sequence.</para>
    /// labels<para>Game Acting Script</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameActingScript">http://ns.inria.fr/ludo/v1/gamemodel#GameActingScript</seealso>
    let GameActingScript = Prefixed_Name(ludo_gm, "GameActingScript") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:GameControlInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Game Control Interface</para>
    /// labels<para>Game Control Interface</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameControlInterface">http://ns.inria.fr/ludo/v1/gamemodel#GameControlInterface</seealso>
    let GameControlInterface =
        Prefixed_Name(ludo_gm, "GameControlInterface") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:GameEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the composition of the virtual world by populating the virtual space with game objects.</para>
    /// labels<para>Game Environment</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameEnvironment">http://ns.inria.fr/ludo/v1/gamemodel#GameEnvironment</seealso>
    let GameEnvironment = Prefixed_Name(ludo_gm, "GameEnvironment") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameKnowledgeBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Knowledge Base to be used by the game.</para>
    /// labels<para>Game Knowledge Base</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameKnowledgeBase">http://ns.inria.fr/ludo/v1/gamemodel#GameKnowledgeBase</seealso>
    let GameKnowledgeBase = Prefixed_Name(ludo_gm, "GameKnowledgeBase") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>External forces</para>
    /// labels<para>Constraint</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Constraint">http://ns.inria.fr/ludo/v1/gamemodel#Constraint</seealso>
    let Constraint = Prefixed_Name(ludo_gm, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:EventTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Event triggers are used to invoke the transition between game sections and activate the game events within a game scenario</para>
    /// labels<para>Event Trigger</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#EventTrigger">http://ns.inria.fr/ludo/v1/gamemodel#EventTrigger</seealso>
    let EventTrigger = Prefixed_Name(ludo_gm, "EventTrigger") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameAct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The performance of a game object in a game event. It consists of a game object and a game acting script that describe how the game object should move, animate, sound and interact with other game object in a game scenario.</para>
    /// labels<para>Game Act</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameAct">http://ns.inria.fr/ludo/v1/gamemodel#GameAct</seealso>
    let GameAct = Prefixed_Name(ludo_gm, "GameAct") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:GameContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the type of game content presented to game players in a game presentation or game simulation.</para>
    /// labels<para>Game Context</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameContext">http://ns.inria.fr/ludo/v1/gamemodel#GameContext</seealso>
    let GameContext = Prefixed_Name(ludo_gm, "GameContext") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:InputEvent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#InputEvent">http://ns.inria.fr/ludo/v1/gamemodel#InputEvent</seealso>
    let InputEvent = Prefixed_Name(ludo_gm, "InputEvent") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:GameInteractionRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It dictates the outcome of the interaction from two game objects.</para>
    /// labels<para>Game Interaction Rule</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameInteractionRule">http://ns.inria.fr/ludo/v1/gamemodel#GameInteractionRule</seealso>
    let GameInteractionRule =
        Prefixed_Name(ludo_gm, "GameInteractionRule") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:GameScoringRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only applies to game player and it defines what to be awarded to the game player when a scoring condition is met.</para>
    /// labels<para>Game Scoring Rule</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameScoringRule">http://ns.inria.fr/ludo/v1/gamemodel#GameScoringRule</seealso>
    let GameScoringRule = Prefixed_Name(ludo_gm, "GameScoringRule") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:GameInteractionRuleOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Outcome of an Interaction Rule</para>
    /// labels<para>Interaction Rule Outcome</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameInteractionRuleOutcome">http://ns.inria.fr/ludo/v1/gamemodel#GameInteractionRuleOutcome</seealso>
    let GameInteractionRuleOutcome =
        Prefixed_Name(ludo_gm, "GameInteractionRuleOutcome") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:GameAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data properties that represent a game objects vitality, physical being, cognitive state and ownership.</para>
    /// labels<para>Game Attribute</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#GameAttribute">http://ns.inria.fr/ludo/v1/gamemodel#GameAttribute</seealso>
    let GameAttribute = Prefixed_Name(ludo_gm, "GameAttribute") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:Scenario-basedStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scenario-based Structure</para>
    /// labels<para>Scenario-based Structure</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Scenario-basedStructure">http://ns.inria.fr/ludo/v1/gamemodel#Scenario-basedStructure</seealso>
    let Scenario_basedStructure =
        Prefixed_Name(ludo_gm, "Scenario-basedStructure") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:hasText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Has text</para>
    /// labels<para>Has text</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#hasText">http://ns.inria.fr/ludo/v1/gamemodel#hasText</seealso>
    let hasText = Prefixed_Name(ludo_gm, "hasText") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:Inventory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inventory presents the idea where player can own a number of game objects in the game as part of the game play. An inventory can be a collection of weapons in a shooter game or a collection of magic spell and potions in a role-playing game. In games such as Resident Evil 5 (www.residentevil.com), a game player can hold 9 items in the inventory at any one time.</para>
    /// labels<para>Inventory</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#Inventory">http://ns.inria.fr/ludo/v1/gamemodel#Inventory</seealso>
    let Inventory = Prefixed_Name(ludo_gm, "Inventory") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:ObjectAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data properties that represent a game objects vitality, physical being, cognitive state and ownership</para>
    /// labels<para>Object Atrribute</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectAttribute">http://ns.inria.fr/ludo/v1/gamemodel#ObjectAttribute</seealso>
    let ObjectAttribute = Prefixed_Name(ludo_gm, "ObjectAttribute") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:ObjectImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The object image is represented using one or more image components</para>
    /// labels<para>Object Image</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectImage">http://ns.inria.fr/ludo/v1/gamemodel#ObjectImage</seealso>
    let ObjectImage = Prefixed_Name(ludo_gm, "ObjectImage") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:ObjectVitality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Vitality of an object such as life or interrelated attributes such as health, energy, strength, social and etc.</para>
    /// labels<para>Object Vitality</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectVitality">http://ns.inria.fr/ludo/v1/gamemodel#ObjectVitality</seealso>
    let ObjectVitality = Prefixed_Name(ludo_gm, "ObjectVitality") |> PrefixedName
    /// <summary>
    ///   <para>ludo-gm:ObjectsAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Objects attribute</para>
    /// labels<para>Objects attribute</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectsAttribute">http://ns.inria.fr/ludo/v1/gamemodel#ObjectsAttribute</seealso>
    let ObjectsAttribute = Prefixed_Name(ludo_gm, "ObjectsAttribute") |> PrefixedName

    /// <summary>
    ///   <para>ludo-gm:PedagogicEventIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Each game section is associated with one or more pedagogic events from the Gagnes nine events of instructions</para>
    /// labels<para>Pedagogic Event Indicator</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel#PedagogicEventIndicator">http://ns.inria.fr/ludo/v1/gamemodel#PedagogicEventIndicator</seealso>
    let PedagogicEventIndicator =
        Prefixed_Name(ludo_gm, "PedagogicEventIndicator") |> PrefixedName
