namespace http.ns.inria.fr.ludo.v1.gamemodel.hash

open DoxAletheia.Rdf_Vocabulary

module ludo_gm =
    let _namespace_name = "http://ns.inria.fr/ludo/v1/gamemodel#"

    /// <summary>
    /// Data properties that represent a game objects vitality, physical being, cognitive state and ownership.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameAttribute"></see></summary>
    let GameAttribute =
        Namespaced_IRI.parse _namespace_name "GameAttribute" |> NamespacedName

    /// <summary>
    /// Provides game player the channel to control game objects
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameControl"></see></summary>
    let GameControl =
        Namespaced_IRI.parse _namespace_name "GameControl" |> NamespacedName

    /// <summary>
    /// A game record is a log of game players achievements in the game
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameRecord"></see></summary>
    let GameRecord = Namespaced_IRI.parse _namespace_name "GameRecord" |> NamespacedName

    /// <summary>
    /// Complete Game Structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#CompleteGameStructure"></see></summary>
    let CompleteGameStructure =
        Namespaced_IRI.parse _namespace_name "CompleteGameStructure" |> NamespacedName

    /// <summary>
    /// Presentation-based Structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Presentation-basedStructure"></see></summary>
    let ``Presentation-basedStructure`` =
        Namespaced_IRI.parse _namespace_name "Presentation-basedStructure" |> NamespacedName

    /// <summary>
    /// Scenario-based Structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Scenario-basedStructure"></see></summary>
    let ``Scenario-basedStructure`` =
        Namespaced_IRI.parse _namespace_name "Scenario-basedStructure" |> NamespacedName

    /// <summary>
    /// Training-based Structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Training-basedStructure"></see></summary>
    let ``Training-basedStructure`` =
        Namespaced_IRI.parse _namespace_name "Training-basedStructure" |> NamespacedName

    /// <summary>
    /// Deciding Condition
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#DecidingCondition"></see></summary>
    let DecidingCondition =
        Namespaced_IRI.parse _namespace_name "DecidingCondition" |> NamespacedName

    /// <summary>
    /// Learn
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Learn"></see></summary>
    let Learn = Namespaced_IRI.parse _namespace_name "Learn" |> NamespacedName
    /// <summary>
    /// Navigate
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Navigate"></see></summary>
    let Navigate = Namespaced_IRI.parse _namespace_name "Navigate" |> NamespacedName

    /// <summary>
    /// Represents the virtual space in which the game simulation takes place in 2D or 3D.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameDimension"></see></summary>
    let GameDimension =
        Namespaced_IRI.parse _namespace_name "GameDimension" |> NamespacedName

    /// <summary>
    /// Defines the physicality of the game world. It encompasses the collision world and environment forces.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GamePhysics"></see></summary>
    let GamePhysics =
        Namespaced_IRI.parse _namespace_name "GamePhysics" |> NamespacedName

    /// <summary>
    /// Represents the realtion between the pace of the time in a game and the time in the real world.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameTempo"></see></summary>
    let GameTempo = Namespaced_IRI.parse _namespace_name "GameTempo" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#Graphic"></see>
    /// </summary>
    let Graphic = Namespaced_IRI.parse _namespace_name "Graphic" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#Sound"></see>
    /// </summary>
    let Sound = Namespaced_IRI.parse _namespace_name "Sound" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#Video"></see>
    /// </summary>
    let Video = Namespaced_IRI.parse _namespace_name "Video" |> NamespacedName
    /// <summary>
    /// Has text
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasText"></see></summary>
    let hasText = Namespaced_IRI.parse _namespace_name "hasText" |> NamespacedName
    /// <summary>
    /// The action of a game object, it consists of motion, animation, sound and vital updates.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// The visual appearance of a game object
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Appearance"></see></summary>
    let Appearance = Namespaced_IRI.parse _namespace_name "Appearance" |> NamespacedName

    /// <summary>
    /// Provides game object the ability to decide, navigate and even learn.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Intelligence"></see></summary>
    let Intelligence =
        Namespaced_IRI.parse _namespace_name "Intelligence" |> NamespacedName

    /// <summary>
    /// Is the happening associated to a game scenario. A game event is composed of a set of game act and an event trigger which initiate the game event.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameEvent"></see></summary>
    let GameEvent = Namespaced_IRI.parse _namespace_name "GameEvent" |> NamespacedName
    /// <summary>
    /// Represents virtual things that populate the game world and can be designed to have a combination of abilities such as decision making, moving, acting and responding to surroundings and game players input simulating their existence in the game world.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameObject"></see></summary>
    let GameObject = Namespaced_IRI.parse _namespace_name "GameObject" |> NamespacedName

    /// <summary>
    /// Represents the goal associated to a game scenario
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameObjective"></see></summary>
    let GameObjective =
        Namespaced_IRI.parse _namespace_name "GameObjective" |> NamespacedName

    /// <summary>
    /// The user of the game application who provides inputs to the game system as part of the gaming activity.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GamePlayer"></see></summary>
    let GamePlayer = Namespaced_IRI.parse _namespace_name "GamePlayer" |> NamespacedName

    /// <summary>
    /// A virtual canvas that holds media components and GUI components to form a game menu, a game notification or a cut-scene to present information about the game and allow them to navigate through the game structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GamePresentation"></see></summary>
    let GamePresentation =
        Namespaced_IRI.parse _namespace_name "GamePresentation" |> NamespacedName

    /// <summary>
    /// States the relationship between game objects and game world, and the effect of an interaction. It can either be a Game Scoring Rule or Game Interaction Rule.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameRule"></see></summary>
    let GameRule = Namespaced_IRI.parse _namespace_name "GameRule" |> NamespacedName

    /// <summary>
    /// A description of a situation which require game player to overcome a number of challenges in order to achieve the defined objectives. It is also commonly termed as game level in gaming jargon.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameScenario"></see></summary>
    let GameScenario =
        Namespaced_IRI.parse _namespace_name "GameScenario" |> NamespacedName

    /// <summary>
    /// Represents the simulation of a game scenario and is governed by a set of rules that define the interactivity, physical and temporal properties of the virtual world. It has game rules, game dimension, game tempo and game physics.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameSimulation"></see></summary>
    let GameSimulation =
        Namespaced_IRI.parse _namespace_name "GameSimulation" |> NamespacedName

    /// <summary>
    /// Describes the architecture and flow of the game. It segments game into game sections. A game section is composed of a game context, pedagogic event indicator and event trigger.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameStructure"></see></summary>
    let GameStructure =
        Namespaced_IRI.parse _namespace_name "GameStructure" |> NamespacedName

    /// <summary>
    /// Describes most of the art requirements related the game through expressive written text.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameTheme"></see></summary>
    let GameTheme = Namespaced_IRI.parse _namespace_name "GameTheme" |> NamespacedName

    /// <summary>
    /// The inventory is defined to hold a limited supply of consumable for a game object.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#InventoryState"></see></summary>
    let InventoryState =
        Namespaced_IRI.parse _namespace_name "InventoryState" |> NamespacedName

    /// <summary>
    /// The mass that affects the motion of the game object
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Mass"></see></summary>
    let Mass = Namespaced_IRI.parse _namespace_name "Mass" |> NamespacedName

    /// <summary>
    /// The solidity state defines if a game object is solid, whereas the mass affects the motion of the game object.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#SoidityState"></see></summary>
    let SoidityState =
        Namespaced_IRI.parse _namespace_name "SoidityState" |> NamespacedName

    /// <summary>
    /// An animation defines the virtual performance of a game object without reference of the position of the game object as a whole.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Animation"></see></summary>
    let Animation = Namespaced_IRI.parse _namespace_name "Animation" |> NamespacedName
    /// <summary>
    /// Motion refers to the actual translation of game object position in the game world. A motion is subject to a force and also constraints (external force).
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Motion"></see></summary>
    let Motion = Namespaced_IRI.parse _namespace_name "Motion" |> NamespacedName

    /// <summary>
    /// Revises the value of vitals for a game object as a measure that takes into account the cost of an action inflicted to the object or the cost of performing an action.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#VitalUpdate"></see></summary>
    let VitalUpdate =
        Namespaced_IRI.parse _namespace_name "VitalUpdate" |> NamespacedName

    /// <summary>
    /// Art requirements related the game through expressive written text
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ArtRequirement"></see></summary>
    let ArtRequirement =
        Namespaced_IRI.parse _namespace_name "ArtRequirement" |> NamespacedName

    /// <summary>
    /// Button
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Button"></see></summary>
    let Button = Namespaced_IRI.parse _namespace_name "Button" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#GUIComponent"></see>
    /// </summary>
    let GUIComponent =
        Namespaced_IRI.parse _namespace_name "GUIComponent" |> NamespacedName

    /// <summary>
    /// Checkbox
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Checkbox"></see></summary>
    let Checkbox = Namespaced_IRI.parse _namespace_name "Checkbox" |> NamespacedName

    /// <summary>
    /// Computed result
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ComputedResult"></see></summary>
    let ComputedResult =
        Namespaced_IRI.parse _namespace_name "ComputedResult" |> NamespacedName

    /// <summary>
    /// Game Result
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameResult"></see></summary>
    let GameResult = Namespaced_IRI.parse _namespace_name "GameResult" |> NamespacedName
    /// <summary>
    /// Raw result
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#RawResult"></see></summary>
    let RawResult = Namespaced_IRI.parse _namespace_name "RawResult" |> NamespacedName
    /// <summary>
    /// External forces
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Constraint"></see></summary>
    let Constraint = Namespaced_IRI.parse _namespace_name "Constraint" |> NamespacedName

    /// <summary>
    /// A value associated to the difficulty of the game scenario
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#DifficultyIndicator"></see></summary>
    let DifficultyIndicator =
        Namespaced_IRI.parse _namespace_name "DifficultyIndicator" |> NamespacedName

    /// <summary>
    /// Event triggers are used to invoke the transition between game sections and activate the game events within a game scenario
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#EventTrigger"></see></summary>
    let EventTrigger =
        Namespaced_IRI.parse _namespace_name "EventTrigger" |> NamespacedName

    /// <summary>
    /// A motion is subject to a force
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Force"></see></summary>
    let Force = Namespaced_IRI.parse _namespace_name "Force" |> NamespacedName
    /// <summary>
    /// The performance of a game object in a game event. It consists of a game object and a game acting script that describe how the game object should move, animate, sound and interact with other game object in a game scenario.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameAct"></see></summary>
    let GameAct = Namespaced_IRI.parse _namespace_name "GameAct" |> NamespacedName

    /// <summary>
    /// Is composed by one or more acting coordination that instruct how a specific game object act in a defined sequence.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameActingScript"></see></summary>
    let GameActingScript =
        Namespaced_IRI.parse _namespace_name "GameActingScript" |> NamespacedName

    /// <summary>
    /// Describes the type of game content presented to game players in a game presentation or game simulation.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameContext"></see></summary>
    let GameContext =
        Namespaced_IRI.parse _namespace_name "GameContext" |> NamespacedName

    /// <summary>
    /// Game Control Interface
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameControlInterface"></see></summary>
    let GameControlInterface =
        Namespaced_IRI.parse _namespace_name "GameControlInterface" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#InputEvent"></see>
    /// </summary>
    let InputEvent = Namespaced_IRI.parse _namespace_name "InputEvent" |> NamespacedName

    /// <summary>
    /// Represents the composition of the virtual world by populating the virtual space with game objects.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameEnvironment"></see></summary>
    let GameEnvironment =
        Namespaced_IRI.parse _namespace_name "GameEnvironment" |> NamespacedName

    /// <summary>
    /// It dictates the outcome of the interaction from two game objects.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameInteractionRule"></see></summary>
    let GameInteractionRule =
        Namespaced_IRI.parse _namespace_name "GameInteractionRule" |> NamespacedName

    /// <summary>
    /// Only applies to game player and it defines what to be awarded to the game player when a scoring condition is met.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameScoringRule"></see></summary>
    let GameScoringRule =
        Namespaced_IRI.parse _namespace_name "GameScoringRule" |> NamespacedName

    /// <summary>
    /// Outcome of an Interaction Rule
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameInteractionRuleOutcome"></see></summary>
    let GameInteractionRuleOutcome =
        Namespaced_IRI.parse _namespace_name "GameInteractionRuleOutcome" |> NamespacedName

    /// <summary>
    /// A Knowledge Base to be used by the game.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GameKnowledgeBase"></see></summary>
    let GameKnowledgeBase =
        Namespaced_IRI.parse _namespace_name "GameKnowledgeBase" |> NamespacedName

    /// <summary>
    /// The goal condition checks a track-able value against a constant value defined by the game designer to determine if the game objective has been met or not. The game objective is marked as achieve once the goal condition has been satisfied.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#GoalCondition"></see></summary>
    let GoalCondition =
        Namespaced_IRI.parse _namespace_name "GoalCondition" |> NamespacedName

    /// <summary>
    /// Inventory presents the idea where player can own a number of game objects in the game as part of the game play. An inventory can be a collection of weapons in a shooter game or a collection of magic spell and potions in a role-playing game. In games such as Resident Evil 5 (www.residentevil.com), a game player can hold 9 items in the inventory at any one time.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Inventory"></see></summary>
    let Inventory = Namespaced_IRI.parse _namespace_name "Inventory" |> NamespacedName

    /// <summary>
    /// Data properties that represent a game objects vitality, physical being, cognitive state and ownership
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectAttribute"></see></summary>
    let ObjectAttribute =
        Namespaced_IRI.parse _namespace_name "ObjectAttribute" |> NamespacedName

    /// <summary>
    /// The object image is represented using one or more image components
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectImage"></see></summary>
    let ObjectImage =
        Namespaced_IRI.parse _namespace_name "ObjectImage" |> NamespacedName

    /// <summary>
    /// Vitality of an object such as life or interrelated attributes such as health, energy, strength, social and etc.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectVitality"></see></summary>
    let ObjectVitality =
        Namespaced_IRI.parse _namespace_name "ObjectVitality" |> NamespacedName

    /// <summary>
    /// Objects attribute
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectsAttribute"></see></summary>
    let ObjectsAttribute =
        Namespaced_IRI.parse _namespace_name "ObjectsAttribute" |> NamespacedName

    /// <summary>
    /// Each game section is associated with one or more pedagogic events from the Gagnes nine events of instructions
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#PedagogicEventIndicator"></see></summary>
    let PedagogicEventIndicator =
        Namespaced_IRI.parse _namespace_name "PedagogicEventIndicator" |> NamespacedName

    /// <summary>
    /// Score
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Score"></see></summary>
    let Score = Namespaced_IRI.parse _namespace_name "Score" |> NamespacedName
    /// <summary>
    /// Game designers can choose to represent the game object using a single vital definition such as life or further elaborate the vitality of a game object into interrelated attributes such as health, energy, strength, social and etc.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#Vital"></see></summary>
    let Vital = Namespaced_IRI.parse _namespace_name "Vital" |> NamespacedName

    /// <summary>
    /// Serious Game
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#SeriousGame"></see></summary>
    let SeriousGame =
        Namespaced_IRI.parse _namespace_name "SeriousGame" |> NamespacedName

    /// <summary>
    /// Viewport to the game world
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#VirtualCamera"></see></summary>
    let VirtualCamera =
        Namespaced_IRI.parse _namespace_name "VirtualCamera" |> NamespacedName

    /// <summary>
    /// The coordination of a game object can involve appear (for generation and re- spawning of game object), animating an action, playing a sound, moving towards a checkpoint, interacting with another game object or a composition of these.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasActingCoordination"></see></summary>
    let hasActingCoordination =
        Namespaced_IRI.parse _namespace_name "hasActingCoordination" |> NamespacedName

    /// <summary>
    /// Has action
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasAction"></see></summary>
    let hasAction = Namespaced_IRI.parse _namespace_name "hasAction" |> NamespacedName

    /// <summary>
    /// Has animation
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasAnimation"></see></summary>
    let hasAnimation =
        Namespaced_IRI.parse _namespace_name "hasAnimation" |> NamespacedName

    /// <summary>
    /// Defines the animation type, either 2D or 3D
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasAnimationType"></see></summary>
    let hasAnimationType =
        Namespaced_IRI.parse _namespace_name "hasAnimationType" |> NamespacedName

    /// <summary>
    /// Has appearance
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasAppearance"></see></summary>
    let hasAppearance =
        Namespaced_IRI.parse _namespace_name "hasAppearance" |> NamespacedName

    /// <summary>
    /// Relates an Area with any component to be represented graphically on the game screen, sucha as GUI components and Media components
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasArea"></see></summary>
    let hasArea = Namespaced_IRI.parse _namespace_name "hasArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel#Area"></see>
    /// </summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName

    /// <summary>
    /// Has art requirement
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasArtRequirement"></see></summary>
    let hasArtRequirement =
        Namespaced_IRI.parse _namespace_name "hasArtRequirement" |> NamespacedName

    /// <summary>
    /// Has constraint
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasConstraint"></see></summary>
    let hasConstraint =
        Namespaced_IRI.parse _namespace_name "hasConstraint" |> NamespacedName

    /// <summary>
    /// Has difficulty indicator
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasDifficultyIndicator"></see></summary>
    let hasDifficultyIndicator =
        Namespaced_IRI.parse _namespace_name "hasDifficultyIndicator" |> NamespacedName

    /// <summary>
    /// Has difficulty indicator value
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasDifficultyIndicatorValue"></see></summary>
    let hasDifficultyIndicatorValue =
        Namespaced_IRI.parse _namespace_name "hasDifficultyIndicatorValue" |> NamespacedName

    /// <summary>
    /// The property to relate a Game Structure or a Game Event with an Event Trigger
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTrigger"></see></summary>
    let hasEventTrigger =
        Namespaced_IRI.parse _namespace_name "hasEventTrigger" |> NamespacedName

    /// <summary>
    /// Event triggers are used to invoke the transition between game sections and activate the game events within a game scenario. They can be classified into four distinct classes, namely: Input trigger detects user input via hardware interface or graphical user interface (GUI); Time trigger is essentially a countdown timer with an interval value with frequency of once, to repeat infinitely or to repeat finitely; Proximity trigger like input trigger has a hotspot that detects the collision of a specified game object, a class of game object or a group of game objects from different classes; Game mechanics trigger is associated to a range of game application related of events such media event, game event and simulation event. Each event trigger is associated with a command that specify the transition between game sections or activation of a game event.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTriggerClass"></see></summary>
    let hasEventTriggerClass =
        Namespaced_IRI.parse _namespace_name "hasEventTriggerClass" |> NamespacedName

    /// <summary>
    /// Has Event trigger command
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTriggerCommand"></see></summary>
    let hasEventTriggerCommand =
        Namespaced_IRI.parse _namespace_name "hasEventTriggerCommand" |> NamespacedName

    /// <summary>
    /// Has force
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasForce"></see></summary>
    let hasForce = Namespaced_IRI.parse _namespace_name "hasForce" |> NamespacedName

    /// <summary>
    /// Has front end display
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasFrontEndDisplay"></see></summary>
    let hasFrontEndDisplay =
        Namespaced_IRI.parse _namespace_name "hasFrontEndDisplay" |> NamespacedName

    /// <summary>
    /// Has Game Act
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameAct"></see></summary>
    let hasGameAct = Namespaced_IRI.parse _namespace_name "hasGameAct" |> NamespacedName

    /// <summary>
    /// Has Game Act Object
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameActObject"></see></summary>
    let hasGameActObject =
        Namespaced_IRI.parse _namespace_name "hasGameActObject" |> NamespacedName

    /// <summary>
    /// Game Acting Script
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameActingScript"></see></summary>
    let hasGameActingScript =
        Namespaced_IRI.parse _namespace_name "hasGameActingScript" |> NamespacedName

    /// <summary>
    /// Has Game Attribute
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameAttribute"></see></summary>
    let hasGameAttribute =
        Namespaced_IRI.parse _namespace_name "hasGameAttribute" |> NamespacedName

    /// <summary>
    /// Has Game Context
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameContext"></see></summary>
    let hasGameContext =
        Namespaced_IRI.parse _namespace_name "hasGameContext" |> NamespacedName

    /// <summary>
    /// Has Game Control
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameControl"></see></summary>
    let hasGameControl =
        Namespaced_IRI.parse _namespace_name "hasGameControl" |> NamespacedName

    /// <summary>
    /// Has Game Control Interface
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameControlInterface"></see></summary>
    let hasGameControlInterface =
        Namespaced_IRI.parse _namespace_name "hasGameControlInterface" |> NamespacedName

    /// <summary>
    /// The game dimension refers to the virtual space of which the game simulation takes place. It can either be 2D or 3D.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameDimension"></see></summary>
    let hasGameDimension =
        Namespaced_IRI.parse _namespace_name "hasGameDimension" |> NamespacedName

    /// <summary>
    /// Has Game Dimention
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameDimention"></see></summary>
    let hasGameDimention =
        Namespaced_IRI.parse _namespace_name "hasGameDimention" |> NamespacedName

    /// <summary>
    /// Has Game Environment
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameEnvironment"></see></summary>
    let hasGameEnvironment =
        Namespaced_IRI.parse _namespace_name "hasGameEnvironment" |> NamespacedName

    /// <summary>
    /// Has Game Event
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameEvent"></see></summary>
    let hasGameEvent =
        Namespaced_IRI.parse _namespace_name "hasGameEvent" |> NamespacedName

    /// <summary>
    /// Has Game Knowledge-Base
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameKnowledgeBase"></see></summary>
    let hasGameKnowledgeBase =
        Namespaced_IRI.parse _namespace_name "hasGameKnowledgeBase" |> NamespacedName

    /// <summary>
    /// This property applies for a Game Environment, a Serious Game and an Inventory
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameObject"></see></summary>
    let hasGameObject =
        Namespaced_IRI.parse _namespace_name "hasGameObject" |> NamespacedName

    /// <summary>
    /// This property relates with a Game Objective. Can be used for Game Scenario and Inventory objects.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameObjective"></see></summary>
    let hasGameObjective =
        Namespaced_IRI.parse _namespace_name "hasGameObjective" |> NamespacedName

    /// <summary>
    /// Has Game Physics
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGamePhysics"></see></summary>
    let hasGamePhysics =
        Namespaced_IRI.parse _namespace_name "hasGamePhysics" |> NamespacedName

    /// <summary>
    /// Has Game Player
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGamePlayer"></see></summary>
    let hasGamePlayer =
        Namespaced_IRI.parse _namespace_name "hasGamePlayer" |> NamespacedName

    /// <summary>
    /// Has Game Record
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameRecord"></see></summary>
    let hasGameRecord =
        Namespaced_IRI.parse _namespace_name "hasGameRecord" |> NamespacedName

    /// <summary>
    /// Has Game Result
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameResult"></see></summary>
    let hasGameResult =
        Namespaced_IRI.parse _namespace_name "hasGameResult" |> NamespacedName

    /// <summary>
    /// This property relates a Game Simulation with a Game Rule
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameRule"></see></summary>
    let hasGameRule =
        Namespaced_IRI.parse _namespace_name "hasGameRule" |> NamespacedName

    /// <summary>
    /// Has Game Scenario
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameScenario"></see></summary>
    let hasGameScenario =
        Namespaced_IRI.parse _namespace_name "hasGameScenario" |> NamespacedName

    /// <summary>
    /// Has Game Structure
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameStructure"></see></summary>
    let hasGameStructure =
        Namespaced_IRI.parse _namespace_name "hasGameStructure" |> NamespacedName

    /// <summary>
    /// Has Game Tempo
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameTempo"></see></summary>
    let hasGameTempo =
        Namespaced_IRI.parse _namespace_name "hasGameTempo" |> NamespacedName

    /// <summary>
    /// Has Game Theme
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameTheme"></see></summary>
    let hasGameTheme =
        Namespaced_IRI.parse _namespace_name "hasGameTheme" |> NamespacedName

    /// <summary>
    /// Has Goal Condition
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGoalCondition"></see></summary>
    let hasGoalCondition =
        Namespaced_IRI.parse _namespace_name "hasGoalCondition" |> NamespacedName

    /// <summary>
    /// The description of the goal condition
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasGoalConditionDescription"></see></summary>
    let hasGoalConditionDescription =
        Namespaced_IRI.parse _namespace_name "hasGoalConditionDescription" |> NamespacedName

    /// <summary>
    /// Examples of hardware interface include keyboard, mouse, gamepad, joystick, motionsensor, camera and microphone.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasHardwareInterface"></see></summary>
    let hasHardwareInterface =
        Namespaced_IRI.parse _namespace_name "hasHardwareInterface" |> NamespacedName

    /// <summary>
    /// Has Input Event
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInputEvent"></see></summary>
    let hasInputEvent =
        Namespaced_IRI.parse _namespace_name "hasInputEvent" |> NamespacedName

    /// <summary>
    /// Has Intelligences
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasIntelligences"></see></summary>
    let hasIntelligences =
        Namespaced_IRI.parse _namespace_name "hasIntelligences" |> NamespacedName

    /// <summary>
    /// It refers to the state of actor or the state of the game world
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionCondition"></see></summary>
    let hasInteractionCondition =
        Namespaced_IRI.parse _namespace_name "hasInteractionCondition" |> NamespacedName

    /// <summary>
    /// Interaction Rule Actor
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleActor"></see></summary>
    let hasInteractionRuleActor =
        Namespaced_IRI.parse _namespace_name "hasInteractionRuleActor" |> NamespacedName

    /// <summary>
    /// Interaction Rule Outcome
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleOutcome"></see></summary>
    let hasInteractionRuleOutcome =
        Namespaced_IRI.parse _namespace_name "hasInteractionRuleOutcome" |> NamespacedName

    /// <summary>
    /// Rewarding the player with any game object can mean give (add) or take away (subtract) an item or increase (add) or decrease (subtract) in the value of an attribute to provide the game player the advantage to succeed in the game.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleOutcomeOperation"></see></summary>
    let hasInteractionRuleOutcomeOperation =
        Namespaced_IRI.parse _namespace_name "hasInteractionRuleOutcomeOperation" |> NamespacedName

    /// <summary>
    /// Interaction Rule Subject
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleSubject"></see></summary>
    let hasInteractionRuleSubject =
        Namespaced_IRI.parse _namespace_name "hasInteractionRuleSubject" |> NamespacedName

    /// <summary>
    /// Has Inventory
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInventory"></see></summary>
    let hasInventory =
        Namespaced_IRI.parse _namespace_name "hasInventory" |> NamespacedName

    /// <summary>
    /// Has inventory quantity
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasInventoryQuantity"></see></summary>
    let hasInventoryQuantity =
        Namespaced_IRI.parse _namespace_name "hasInventoryQuantity" |> NamespacedName

    /// <summary>
    /// The amount of matter of an object in Kilograms.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasMass"></see></summary>
    let hasMass = Namespaced_IRI.parse _namespace_name "hasMass" |> NamespacedName
    /// <summary>
    /// Each game rule is paired with an outcome which has a matter and an operation to add or subtract a value from the matter. Matter in the context of game refers to an item, an attribute or permission.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasMatter"></see></summary>
    let hasMatter = Namespaced_IRI.parse _namespace_name "hasMatter" |> NamespacedName
    /// <summary>
    /// Has Motion
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasMotion"></see></summary>
    let hasMotion = Namespaced_IRI.parse _namespace_name "hasMotion" |> NamespacedName

    /// <summary>
    /// The normal force
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasNormalForce"></see></summary>
    let hasNormalForce =
        Namespaced_IRI.parse _namespace_name "hasNormalForce" |> NamespacedName

    /// <summary>
    /// Vitality of an object such as life or interrelated attributes such as health, energy, strength, social and etc.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasObjectVitality"></see></summary>
    let hasObjectVitality =
        Namespaced_IRI.parse _namespace_name "hasObjectVitality" |> NamespacedName

    /// <summary>
    /// Object Vitality Value
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasObjectVitalityValue"></see></summary>
    let hasObjectVitalityValue =
        Namespaced_IRI.parse _namespace_name "hasObjectVitalityValue" |> NamespacedName

    /// <summary>
    /// Associates each game section with one or more pedagogic events from the Gagne's nine events of instructions. These events ordered in sequence are (1) gaining attention, (2) informing learning objectives, (3) recalling prior learning, (4) presenting learning content, (5) providing learning guidance, (6) eliciting performance, (7) provide feedback, (8) assess performance and, (9) enhance retention and transfer.
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasPedagogicEvent"></see></summary>
    let hasPedagogicEvent =
        Namespaced_IRI.parse _namespace_name "hasPedagogicEvent" |> NamespacedName

    /// <summary>
    /// Has Pedagogic Event Indicator
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasPedagogicEventIndicator"></see></summary>
    let hasPedagogicEventIndicator =
        Namespaced_IRI.parse _namespace_name "hasPedagogicEventIndicator" |> NamespacedName

    /// <summary>
    /// Every game scoring rule has a scoring condition which has no direct relation with interaction. It can be derived from the state of a game object (e.g. enemy is dead or fire is extinguished), the input statistics (e.g. accuracy is above 80%), the time (e.g. respond is less than 5 seconds or level completed in less than 5 minutes), or the game objective (e.g. objective 1, 2 and 5 are met).
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasScoringCondition"></see></summary>
    let hasScoringCondition =
        Namespaced_IRI.parse _namespace_name "hasScoringCondition" |> NamespacedName

    /// <summary>
    /// The outcome of an Scoring Rule
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasSoringRuleOutcome"></see></summary>
    let hasSoringRuleOutcome =
        Namespaced_IRI.parse _namespace_name "hasSoringRuleOutcome" |> NamespacedName

    /// <summary>
    /// Has Sound
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasSound"></see></summary>
    let hasSound = Namespaced_IRI.parse _namespace_name "hasSound" |> NamespacedName

    /// <summary>
    /// The tempo scale at which the time is passing. This can be used for slow motion effects. When timeScale is 1.0 the time is passing as fast as realtime. When timeScale is 0.5 the time is passing 2x slower than realtime. When timeScale is set to zero the game is basically paused if all your functions are frame rate independent.y. Based on: http://docs.unity3d.com/ScriptReference/Time-timeScale.html
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasTempoScale"></see></summary>
    let hasTempoScale =
        Namespaced_IRI.parse _namespace_name "hasTempoScale" |> NamespacedName

    /// <summary>
    /// Uniform Resource Identifier
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasURI"></see></summary>
    let hasURI = Namespaced_IRI.parse _namespace_name "hasURI" |> NamespacedName

    /// <summary>
    /// Has Virtual Camera
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasVirtualCamera"></see></summary>
    let hasVirtualCamera =
        Namespaced_IRI.parse _namespace_name "hasVirtualCamera" |> NamespacedName

    /// <summary>
    /// Position of the virtual camera in the game world
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasVirtualCameraPosition"></see></summary>
    let hasVirtualCameraPosition =
        Namespaced_IRI.parse _namespace_name "hasVirtualCameraPosition" |> NamespacedName

    /// <summary>
    /// Has Vital Update
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#hasVitalUpdate"></see></summary>
    let hasVitalUpdate =
        Namespaced_IRI.parse _namespace_name "hasVitalUpdate" |> NamespacedName

    /// <summary>
    /// Solidity
    /// <see href="http://ns.inria.fr/ludo/v1/gamemodel#isSolid"></see></summary>
    let isSolid = Namespaced_IRI.parse _namespace_name "isSolid" |> NamespacedName
