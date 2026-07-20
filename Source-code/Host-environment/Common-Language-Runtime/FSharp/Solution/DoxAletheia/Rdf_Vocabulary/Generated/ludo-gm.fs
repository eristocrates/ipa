namespace http.ns.inria.fr.ludo.v1.gamemodel.hash

open DoxAletheia

module ludo_gm =
    let _namespace_name = "http://ns.inria.fr/ludo/v1/gamemodel#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Data properties that represent a game objects vitality, physical being, cognitive state and ownership.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameAttribute"></see></summary>
    let GameAttribute = _prefix "GameAttribute"
    /// <summary>
    /// Provides game player the channel to control game objects
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameControl"></see></summary>
    let GameControl = _prefix "GameControl"
    /// <summary>
    /// A game record is a log of game players achievements in the game
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameRecord"></see></summary>
    let GameRecord = _prefix "GameRecord"
    /// <summary>
    /// Complete Game Structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#CompleteGameStructure"></see></summary>
    let CompleteGameStructure = _prefix "CompleteGameStructure"
    /// <summary>
    /// Presentation-based Structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Presentation-basedStructure"></see></summary>
    let ``Presentation-basedStructure`` = _prefix "Presentation-basedStructure"
    /// <summary>
    /// Scenario-based Structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Scenario-basedStructure"></see></summary>
    let ``Scenario-basedStructure`` = _prefix "Scenario-basedStructure"
    /// <summary>
    /// Training-based Structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Training-basedStructure"></see></summary>
    let ``Training-basedStructure`` = _prefix "Training-basedStructure"
    /// <summary>
    /// Deciding Condition
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#DecidingCondition"></see></summary>
    let DecidingCondition = _prefix "DecidingCondition"
    /// <summary>
    /// Learn
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Learn"></see></summary>
    let Learn = _prefix "Learn"
    /// <summary>
    /// Navigate
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Navigate"></see></summary>
    let Navigate = _prefix "Navigate"
    /// <summary>
    /// Represents the virtual space in which the game simulation takes place in 2D or 3D.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameDimension"></see></summary>
    let GameDimension = _prefix "GameDimension"
    /// <summary>
    /// Defines the physicality of the game world. It encompasses the collision world and environment forces.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GamePhysics"></see></summary>
    let GamePhysics = _prefix "GamePhysics"
    /// <summary>
    /// Represents the realtion between the pace of the time in a game and the time in the real world.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameTempo"></see></summary>
    let GameTempo = _prefix "GameTempo"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#Graphic"></see>
    /// </summary>
    let Graphic = _prefix "Graphic"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#Sound"></see>
    /// </summary>
    let Sound = _prefix "Sound"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#Video"></see>
    /// </summary>
    let Video = _prefix "Video"
    /// <summary>
    /// Has text
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasText"></see></summary>
    let hasText = _prefix "hasText"
    /// <summary>
    /// The action of a game object, it consists of motion, animation, sound and vital updates.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// The visual appearance of a game object
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Appearance"></see></summary>
    let Appearance = _prefix "Appearance"
    /// <summary>
    /// Provides game object the ability to decide, navigate and even learn.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Intelligence"></see></summary>
    let Intelligence = _prefix "Intelligence"
    /// <summary>
    /// Is the happening associated to a game scenario. A game event is composed of a set of game act and an event trigger which initiate the game event.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameEvent"></see></summary>
    let GameEvent = _prefix "GameEvent"
    /// <summary>
    /// Represents virtual things that populate the game world and can be designed to have a combination of abilities such as decision making, moving, acting and responding to surroundings and game players input simulating their existence in the game world.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameObject"></see></summary>
    let GameObject = _prefix "GameObject"
    /// <summary>
    /// Represents the goal associated to a game scenario
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameObjective"></see></summary>
    let GameObjective = _prefix "GameObjective"
    /// <summary>
    /// The user of the game application who provides inputs to the game system as part of the gaming activity.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GamePlayer"></see></summary>
    let GamePlayer = _prefix "GamePlayer"
    /// <summary>
    /// A virtual canvas that holds media components and GUI components to form a game menu, a game notification or a cut-scene to present information about the game and allow them to navigate through the game structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GamePresentation"></see></summary>
    let GamePresentation = _prefix "GamePresentation"
    /// <summary>
    /// States the relationship between game objects and game world, and the effect of an interaction. It can either be a Game Scoring Rule or Game Interaction Rule.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameRule"></see></summary>
    let GameRule = _prefix "GameRule"
    /// <summary>
    /// A description of a situation which require game player to overcome a number of challenges in order to achieve the defined objectives. It is also commonly termed as game level in gaming jargon.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameScenario"></see></summary>
    let GameScenario = _prefix "GameScenario"
    /// <summary>
    /// Represents the simulation of a game scenario and is governed by a set of rules that define the interactivity, physical and temporal properties of the virtual world. It has game rules, game dimension, game tempo and game physics.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameSimulation"></see></summary>
    let GameSimulation = _prefix "GameSimulation"
    /// <summary>
    /// Describes the architecture and flow of the game. It segments game into game sections. A game section is composed of a game context, pedagogic event indicator and event trigger.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameStructure"></see></summary>
    let GameStructure = _prefix "GameStructure"
    /// <summary>
    /// Describes most of the art requirements related the game through expressive written text.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameTheme"></see></summary>
    let GameTheme = _prefix "GameTheme"
    /// <summary>
    /// The inventory is defined to hold a limited supply of consumable for a game object.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#InventoryState"></see></summary>
    let InventoryState = _prefix "InventoryState"
    /// <summary>
    /// The mass that affects the motion of the game object
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Mass"></see></summary>
    let Mass = _prefix "Mass"
    /// <summary>
    /// The solidity state defines if a game object is solid, whereas the mass affects the motion of the game object.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#SoidityState"></see></summary>
    let SoidityState = _prefix "SoidityState"
    /// <summary>
    /// An animation defines the virtual performance of a game object without reference of the position of the game object as a whole.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Animation"></see></summary>
    let Animation = _prefix "Animation"
    /// <summary>
    /// Motion refers to the actual translation of game object position in the game world. A motion is subject to a force and also constraints (external force).
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Motion"></see></summary>
    let Motion = _prefix "Motion"
    /// <summary>
    /// Revises the value of vitals for a game object as a measure that takes into account the cost of an action inflicted to the object or the cost of performing an action.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#VitalUpdate"></see></summary>
    let VitalUpdate = _prefix "VitalUpdate"
    /// <summary>
    /// Art requirements related the game through expressive written text
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ArtRequirement"></see></summary>
    let ArtRequirement = _prefix "ArtRequirement"
    /// <summary>
    /// Button
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Button"></see></summary>
    let Button = _prefix "Button"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#GUIComponent"></see>
    /// </summary>
    let GUIComponent = _prefix "GUIComponent"
    /// <summary>
    /// Checkbox
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Checkbox"></see></summary>
    let Checkbox = _prefix "Checkbox"
    /// <summary>
    /// Computed result
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ComputedResult"></see></summary>
    let ComputedResult = _prefix "ComputedResult"
    /// <summary>
    /// Game Result
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameResult"></see></summary>
    let GameResult = _prefix "GameResult"
    /// <summary>
    /// Raw result
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#RawResult"></see></summary>
    let RawResult = _prefix "RawResult"
    /// <summary>
    /// External forces
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Constraint"></see></summary>
    let Constraint = _prefix "Constraint"
    /// <summary>
    /// A value associated to the difficulty of the game scenario
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#DifficultyIndicator"></see></summary>
    let DifficultyIndicator = _prefix "DifficultyIndicator"
    /// <summary>
    /// Event triggers are used to invoke the transition between game sections and activate the game events within a game scenario
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#EventTrigger"></see></summary>
    let EventTrigger = _prefix "EventTrigger"
    /// <summary>
    /// A motion is subject to a force
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Force"></see></summary>
    let Force = _prefix "Force"
    /// <summary>
    /// The performance of a game object in a game event. It consists of a game object and a game acting script that describe how the game object should move, animate, sound and interact with other game object in a game scenario.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameAct"></see></summary>
    let GameAct = _prefix "GameAct"
    /// <summary>
    /// Is composed by one or more acting coordination that instruct how a specific game object act in a defined sequence.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameActingScript"></see></summary>
    let GameActingScript = _prefix "GameActingScript"
    /// <summary>
    /// Describes the type of game content presented to game players in a game presentation or game simulation.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameContext"></see></summary>
    let GameContext = _prefix "GameContext"
    /// <summary>
    /// Game Control Interface
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameControlInterface"></see></summary>
    let GameControlInterface = _prefix "GameControlInterface"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#InputEvent"></see>
    /// </summary>
    let InputEvent = _prefix "InputEvent"
    /// <summary>
    /// Represents the composition of the virtual world by populating the virtual space with game objects.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameEnvironment"></see></summary>
    let GameEnvironment = _prefix "GameEnvironment"
    /// <summary>
    /// It dictates the outcome of the interaction from two game objects.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameInteractionRule"></see></summary>
    let GameInteractionRule = _prefix "GameInteractionRule"
    /// <summary>
    /// Only applies to game player and it defines what to be awarded to the game player when a scoring condition is met.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameScoringRule"></see></summary>
    let GameScoringRule = _prefix "GameScoringRule"
    /// <summary>
    /// Outcome of an Interaction Rule
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameInteractionRuleOutcome"></see></summary>
    let GameInteractionRuleOutcome = _prefix "GameInteractionRuleOutcome"
    /// <summary>
    /// A Knowledge Base to be used by the game.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameKnowledgeBase"></see></summary>
    let GameKnowledgeBase = _prefix "GameKnowledgeBase"
    /// <summary>
    /// The goal condition checks a track-able value against a constant value defined by the game designer to determine if the game objective has been met or not. The game objective is marked as achieve once the goal condition has been satisfied.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GoalCondition"></see></summary>
    let GoalCondition = _prefix "GoalCondition"
    /// <summary>
    /// Inventory presents the idea where player can own a number of game objects in the game as part of the game play. An inventory can be a collection of weapons in a shooter game or a collection of magic spell and potions in a role-playing game. In games such as Resident Evil 5 (www.residentevil.com), a game player can hold 9 items in the inventory at any one time.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Inventory"></see></summary>
    let Inventory = _prefix "Inventory"
    /// <summary>
    /// Data properties that represent a game objects vitality, physical being, cognitive state and ownership
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectAttribute"></see></summary>
    let ObjectAttribute = _prefix "ObjectAttribute"
    /// <summary>
    /// The object image is represented using one or more image components
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectImage"></see></summary>
    let ObjectImage = _prefix "ObjectImage"
    /// <summary>
    /// Vitality of an object such as life or interrelated attributes such as health, energy, strength, social and etc.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectVitality"></see></summary>
    let ObjectVitality = _prefix "ObjectVitality"
    /// <summary>
    /// Objects attribute
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectsAttribute"></see></summary>
    let ObjectsAttribute = _prefix "ObjectsAttribute"
    /// <summary>
    /// Each game section is associated with one or more pedagogic events from the Gagnes nine events of instructions
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#PedagogicEventIndicator"></see></summary>
    let PedagogicEventIndicator = _prefix "PedagogicEventIndicator"
    /// <summary>
    /// Score
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Score"></see></summary>
    let Score = _prefix "Score"
    /// <summary>
    /// Game designers can choose to represent the game object using a single vital definition such as life or further elaborate the vitality of a game object into interrelated attributes such as health, energy, strength, social and etc.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Vital"></see></summary>
    let Vital = _prefix "Vital"
    /// <summary>
    /// Serious Game
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#SeriousGame"></see></summary>
    let SeriousGame = _prefix "SeriousGame"
    /// <summary>
    /// Viewport to the game world
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#VirtualCamera"></see></summary>
    let VirtualCamera = _prefix "VirtualCamera"
    /// <summary>
    /// The coordination of a game object can involve appear (for generation and re- spawning of game object), animating an action, playing a sound, moving towards a checkpoint, interacting with another game object or a composition of these.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasActingCoordination"></see></summary>
    let hasActingCoordination = _prefix "hasActingCoordination"
    /// <summary>
    /// Has action
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasAction"></see></summary>
    let hasAction = _prefix "hasAction"
    /// <summary>
    /// Has animation
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasAnimation"></see></summary>
    let hasAnimation = _prefix "hasAnimation"
    /// <summary>
    /// Defines the animation type, either 2D or 3D
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasAnimationType"></see></summary>
    let hasAnimationType = _prefix "hasAnimationType"
    /// <summary>
    /// Has appearance
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasAppearance"></see></summary>
    let hasAppearance = _prefix "hasAppearance"
    /// <summary>
    /// Relates an Area with any component to be represented graphically on the game screen, sucha as GUI components and Media components
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasArea"></see></summary>
    let hasArea = _prefix "hasArea"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#Area"></see>
    /// </summary>
    let Area = _prefix "Area"
    /// <summary>
    /// Has art requirement
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasArtRequirement"></see></summary>
    let hasArtRequirement = _prefix "hasArtRequirement"
    /// <summary>
    /// Has constraint
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasConstraint"></see></summary>
    let hasConstraint = _prefix "hasConstraint"
    /// <summary>
    /// Has difficulty indicator
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasDifficultyIndicator"></see></summary>
    let hasDifficultyIndicator = _prefix "hasDifficultyIndicator"
    /// <summary>
    /// Has difficulty indicator value
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasDifficultyIndicatorValue"></see></summary>
    let hasDifficultyIndicatorValue = _prefix "hasDifficultyIndicatorValue"
    /// <summary>
    /// The property to relate a Game Structure or a Game Event with an Event Trigger
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTrigger"></see></summary>
    let hasEventTrigger = _prefix "hasEventTrigger"
    /// <summary>
    /// Event triggers are used to invoke the transition between game sections and activate the game events within a game scenario. They can be classified into four distinct classes, namely: Input trigger detects user input via hardware interface or graphical user interface (GUI); Time trigger is essentially a countdown timer with an interval value with frequency of once, to repeat infinitely or to repeat finitely; Proximity trigger like input trigger has a hotspot that detects the collision of a specified game object, a class of game object or a group of game objects from different classes; Game mechanics trigger is associated to a range of game application related of events such media event, game event and simulation event. Each event trigger is associated with a command that specify the transition between game sections or activation of a game event.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTriggerClass"></see></summary>
    let hasEventTriggerClass = _prefix "hasEventTriggerClass"
    /// <summary>
    /// Has Event trigger command
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTriggerCommand"></see></summary>
    let hasEventTriggerCommand = _prefix "hasEventTriggerCommand"
    /// <summary>
    /// Has force
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasForce"></see></summary>
    let hasForce = _prefix "hasForce"
    /// <summary>
    /// Has front end display
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasFrontEndDisplay"></see></summary>
    let hasFrontEndDisplay = _prefix "hasFrontEndDisplay"
    /// <summary>
    /// Has Game Act
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameAct"></see></summary>
    let hasGameAct = _prefix "hasGameAct"
    /// <summary>
    /// Has Game Act Object
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameActObject"></see></summary>
    let hasGameActObject = _prefix "hasGameActObject"
    /// <summary>
    /// Game Acting Script
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameActingScript"></see></summary>
    let hasGameActingScript = _prefix "hasGameActingScript"
    /// <summary>
    /// Has Game Attribute
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameAttribute"></see></summary>
    let hasGameAttribute = _prefix "hasGameAttribute"
    /// <summary>
    /// Has Game Context
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameContext"></see></summary>
    let hasGameContext = _prefix "hasGameContext"
    /// <summary>
    /// Has Game Control
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameControl"></see></summary>
    let hasGameControl = _prefix "hasGameControl"
    /// <summary>
    /// Has Game Control Interface
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameControlInterface"></see></summary>
    let hasGameControlInterface = _prefix "hasGameControlInterface"
    /// <summary>
    /// The game dimension refers to the virtual space of which the game simulation takes place. It can either be 2D or 3D.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameDimension"></see></summary>
    let hasGameDimension = _prefix "hasGameDimension"
    /// <summary>
    /// Has Game Dimention
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameDimention"></see></summary>
    let hasGameDimention = _prefix "hasGameDimention"
    /// <summary>
    /// Has Game Environment
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameEnvironment"></see></summary>
    let hasGameEnvironment = _prefix "hasGameEnvironment"
    /// <summary>
    /// Has Game Event
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameEvent"></see></summary>
    let hasGameEvent = _prefix "hasGameEvent"
    /// <summary>
    /// Has Game Knowledge-Base
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameKnowledgeBase"></see></summary>
    let hasGameKnowledgeBase = _prefix "hasGameKnowledgeBase"
    /// <summary>
    /// This property applies for a Game Environment, a Serious Game and an Inventory
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameObject"></see></summary>
    let hasGameObject = _prefix "hasGameObject"
    /// <summary>
    /// This property relates with a Game Objective. Can be used for Game Scenario and Inventory objects.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameObjective"></see></summary>
    let hasGameObjective = _prefix "hasGameObjective"
    /// <summary>
    /// Has Game Physics
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGamePhysics"></see></summary>
    let hasGamePhysics = _prefix "hasGamePhysics"
    /// <summary>
    /// Has Game Player
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGamePlayer"></see></summary>
    let hasGamePlayer = _prefix "hasGamePlayer"
    /// <summary>
    /// Has Game Record
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameRecord"></see></summary>
    let hasGameRecord = _prefix "hasGameRecord"
    /// <summary>
    /// Has Game Result
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameResult"></see></summary>
    let hasGameResult = _prefix "hasGameResult"
    /// <summary>
    /// This property relates a Game Simulation with a Game Rule
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameRule"></see></summary>
    let hasGameRule = _prefix "hasGameRule"
    /// <summary>
    /// Has Game Scenario
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameScenario"></see></summary>
    let hasGameScenario = _prefix "hasGameScenario"
    /// <summary>
    /// Has Game Structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameStructure"></see></summary>
    let hasGameStructure = _prefix "hasGameStructure"
    /// <summary>
    /// Has Game Tempo
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameTempo"></see></summary>
    let hasGameTempo = _prefix "hasGameTempo"
    /// <summary>
    /// Has Game Theme
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameTheme"></see></summary>
    let hasGameTheme = _prefix "hasGameTheme"
    /// <summary>
    /// Has Goal Condition
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGoalCondition"></see></summary>
    let hasGoalCondition = _prefix "hasGoalCondition"
    /// <summary>
    /// The description of the goal condition
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGoalConditionDescription"></see></summary>
    let hasGoalConditionDescription = _prefix "hasGoalConditionDescription"
    /// <summary>
    /// Examples of hardware interface include keyboard, mouse, gamepad, joystick, motionsensor, camera and microphone.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasHardwareInterface"></see></summary>
    let hasHardwareInterface = _prefix "hasHardwareInterface"
    /// <summary>
    /// Has Input Event
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInputEvent"></see></summary>
    let hasInputEvent = _prefix "hasInputEvent"
    /// <summary>
    /// Has Intelligences
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasIntelligences"></see></summary>
    let hasIntelligences = _prefix "hasIntelligences"
    /// <summary>
    /// It refers to the state of actor or the state of the game world
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionCondition"></see></summary>
    let hasInteractionCondition = _prefix "hasInteractionCondition"
    /// <summary>
    /// Interaction Rule Actor
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleActor"></see></summary>
    let hasInteractionRuleActor = _prefix "hasInteractionRuleActor"
    /// <summary>
    /// Interaction Rule Outcome
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleOutcome"></see></summary>
    let hasInteractionRuleOutcome = _prefix "hasInteractionRuleOutcome"

    /// <summary>
    /// Rewarding the player with any game object can mean give (add) or take away (subtract) an item or increase (add) or decrease (subtract) in the value of an attribute to provide the game player the advantage to succeed in the game.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleOutcomeOperation"></see></summary>
    let hasInteractionRuleOutcomeOperation =
        _prefix "hasInteractionRuleOutcomeOperation"

    /// <summary>
    /// Interaction Rule Subject
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleSubject"></see></summary>
    let hasInteractionRuleSubject = _prefix "hasInteractionRuleSubject"
    /// <summary>
    /// Has Inventory
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInventory"></see></summary>
    let hasInventory = _prefix "hasInventory"
    /// <summary>
    /// Has inventory quantity
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInventoryQuantity"></see></summary>
    let hasInventoryQuantity = _prefix "hasInventoryQuantity"
    /// <summary>
    /// The amount of matter of an object in Kilograms.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasMass"></see></summary>
    let hasMass = _prefix "hasMass"
    /// <summary>
    /// Each game rule is paired with an outcome which has a matter and an operation to add or subtract a value from the matter. Matter in the context of game refers to an item, an attribute or permission.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasMatter"></see></summary>
    let hasMatter = _prefix "hasMatter"
    /// <summary>
    /// Has Motion
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasMotion"></see></summary>
    let hasMotion = _prefix "hasMotion"
    /// <summary>
    /// The normal force
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasNormalForce"></see></summary>
    let hasNormalForce = _prefix "hasNormalForce"
    /// <summary>
    /// Vitality of an object such as life or interrelated attributes such as health, energy, strength, social and etc.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasObjectVitality"></see></summary>
    let hasObjectVitality = _prefix "hasObjectVitality"
    /// <summary>
    /// Object Vitality Value
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasObjectVitalityValue"></see></summary>
    let hasObjectVitalityValue = _prefix "hasObjectVitalityValue"
    /// <summary>
    /// Associates each game section with one or more pedagogic events from the Gagne's nine events of instructions. These events ordered in sequence are (1) gaining attention, (2) informing learning objectives, (3) recalling prior learning, (4) presenting learning content, (5) providing learning guidance, (6) eliciting performance, (7) provide feedback, (8) assess performance and, (9) enhance retention and transfer.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasPedagogicEvent"></see></summary>
    let hasPedagogicEvent = _prefix "hasPedagogicEvent"
    /// <summary>
    /// Has Pedagogic Event Indicator
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasPedagogicEventIndicator"></see></summary>
    let hasPedagogicEventIndicator = _prefix "hasPedagogicEventIndicator"
    /// <summary>
    /// Every game scoring rule has a scoring condition which has no direct relation with interaction. It can be derived from the state of a game object (e.g. enemy is dead or fire is extinguished), the input statistics (e.g. accuracy is above 80%), the time (e.g. respond is less than 5 seconds or level completed in less than 5 minutes), or the game objective (e.g. objective 1, 2 and 5 are met).
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasScoringCondition"></see></summary>
    let hasScoringCondition = _prefix "hasScoringCondition"
    /// <summary>
    /// The outcome of an Scoring Rule
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasSoringRuleOutcome"></see></summary>
    let hasSoringRuleOutcome = _prefix "hasSoringRuleOutcome"
    /// <summary>
    /// Has Sound
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasSound"></see></summary>
    let hasSound = _prefix "hasSound"
    /// <summary>
    /// The tempo scale at which the time is passing. This can be used for slow motion effects. When timeScale is 1.0 the time is passing as fast as realtime. When timeScale is 0.5 the time is passing 2x slower than realtime. When timeScale is set to zero the game is basically paused if all your functions are frame rate independent.y. Based on: http://docs.unity3d.com/ScriptReference/Time-timeScale.html
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasTempoScale"></see></summary>
    let hasTempoScale = _prefix "hasTempoScale"
    /// <summary>
    /// Uniform Resource Identifier
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasURI"></see></summary>
    let hasURI = _prefix "hasURI"
    /// <summary>
    /// Has Virtual Camera
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasVirtualCamera"></see></summary>
    let hasVirtualCamera = _prefix "hasVirtualCamera"
    /// <summary>
    /// Position of the virtual camera in the game world
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasVirtualCameraPosition"></see></summary>
    let hasVirtualCameraPosition = _prefix "hasVirtualCameraPosition"
    /// <summary>
    /// Has Vital Update
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasVitalUpdate"></see></summary>
    let hasVitalUpdate = _prefix "hasVitalUpdate"
    /// <summary>
    /// Solidity
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#isSolid"></see></summary>
    let isSolid = _prefix "isSolid"
