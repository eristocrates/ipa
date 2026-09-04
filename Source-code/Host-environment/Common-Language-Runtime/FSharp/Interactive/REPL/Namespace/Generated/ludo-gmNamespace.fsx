#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ludo-gm`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ns.inria.fr/ludo/v1/gamemodel#" "ludo-gm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Action</para>
    ///   <para>rdfs:comment : The action of a game object, it consists of motion, animation, sound and vital updates.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Action">ludo-gm:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Animation</para>
    ///   <para>rdfs:comment : An animation defines the virtual performance of a game object without reference of the position of the game object as a whole.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Animation">ludo-gm:Animation</a>
    /// </summary>
    let Animation = _prefixId.prefix "Animation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Appearance</para>
    ///   <para>rdfs:comment : The visual appearance of a game object</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Appearance">ludo-gm:Appearance</a>
    /// </summary>
    let Appearance = _prefixId.prefix "Appearance"
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Art Requirement</para>
    ///   <para>rdfs:comment : Art requirements related the game through expressive written text</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#ArtRequirement">ludo-gm:ArtRequirement</a>
    /// </summary>
    let ArtRequirement = _prefixId.prefix "ArtRequirement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Button</para>
    ///   <para>rdfs:comment : Button</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Button">ludo-gm:Button</a>
    /// </summary>
    let Button = _prefixId.prefix "Button"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Checkbox</para>
    ///   <para>rdfs:comment : Checkbox</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Checkbox">ludo-gm:Checkbox</a>
    /// </summary>
    let Checkbox = _prefixId.prefix "Checkbox"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Complete Game Structure</para>
    ///   <para>rdfs:comment : Complete Game Structure</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#CompleteGameStructure">ludo-gm:CompleteGameStructure</a>
    /// </summary>
    let CompleteGameStructure = _prefixId.prefix "CompleteGameStructure"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Computed result</para>
    ///   <para>rdfs:comment : Computed result</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#ComputedResult">ludo-gm:ComputedResult</a>
    /// </summary>
    let ComputedResult = _prefixId.prefix "ComputedResult"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Constraint</para>
    ///   <para>rdfs:comment : External forces</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Constraint">ludo-gm:Constraint</a>
    /// </summary>
    let Constraint = _prefixId.prefix "Constraint"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Deciding Condition</para>
    ///   <para>rdfs:comment : Deciding Condition</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#DecidingCondition">ludo-gm:DecidingCondition</a>
    /// </summary>
    let DecidingCondition = _prefixId.prefix "DecidingCondition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Difficulty Indicator</para>
    ///   <para>rdfs:comment : A value associated to the difficulty of the game scenario</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#DifficultyIndicator">ludo-gm:DifficultyIndicator</a>
    /// </summary>
    let DifficultyIndicator = _prefixId.prefix "DifficultyIndicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Event Trigger</para>
    ///   <para>rdfs:comment : Event triggers are used to invoke the transition between game sections and activate the game events within a game scenario</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#EventTrigger">ludo-gm:EventTrigger</a>
    /// </summary>
    let EventTrigger = _prefixId.prefix "EventTrigger"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Force</para>
    ///   <para>rdfs:comment : A motion is subject to a force</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Force">ludo-gm:Force</a>
    /// </summary>
    let Force = _prefixId.prefix "Force"
    let GUIComponent = _prefixId.prefix "GUIComponent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Act</para>
    ///   <para>rdfs:comment : The performance of a game object in a game event. It consists of a game object and a game acting script that describe how the game object should move, animate, sound and interact with other game object in a game scenario.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameAct">ludo-gm:GameAct</a>
    /// </summary>
    let GameAct = _prefixId.prefix "GameAct"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Acting Script</para>
    ///   <para>rdfs:comment : Is composed by one or more acting coordination that instruct how a specific game object act in a defined sequence.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameActingScript">ludo-gm:GameActingScript</a>
    /// </summary>
    let GameActingScript = _prefixId.prefix "GameActingScript"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Attribute</para>
    ///   <para>rdfs:comment : Data properties that represent a game objects vitality, physical being, cognitive state and ownership.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameAttribute">ludo-gm:GameAttribute</a>
    /// </summary>
    let GameAttribute = _prefixId.prefix "GameAttribute"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Context</para>
    ///   <para>rdfs:comment : Describes the type of game content presented to game players in a game presentation or game simulation.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameContext">ludo-gm:GameContext</a>
    /// </summary>
    let GameContext = _prefixId.prefix "GameContext"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Control</para>
    ///   <para>rdfs:comment : Provides game player the channel to control game objects</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameControl">ludo-gm:GameControl</a>
    /// </summary>
    let GameControl = _prefixId.prefix "GameControl"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Control Interface</para>
    ///   <para>rdfs:comment : Game Control Interface</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameControlInterface">ludo-gm:GameControlInterface</a>
    /// </summary>
    let GameControlInterface = _prefixId.prefix "GameControlInterface"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Dimension</para>
    ///   <para>rdfs:comment : Represents the virtual space in which the game simulation takes place in 2D or 3D.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameDimension">ludo-gm:GameDimension</a>
    /// </summary>
    let GameDimension = _prefixId.prefix "GameDimension"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Environment</para>
    ///   <para>rdfs:comment : Represents the composition of the virtual world by populating the virtual space with game objects.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameEnvironment">ludo-gm:GameEnvironment</a>
    /// </summary>
    let GameEnvironment = _prefixId.prefix "GameEnvironment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Event</para>
    ///   <para>rdfs:comment : Is the happening associated to a game scenario. A game event is composed of a set of game act and an event trigger which initiate the game event.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameEvent">ludo-gm:GameEvent</a>
    /// </summary>
    let GameEvent = _prefixId.prefix "GameEvent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Interaction Rule</para>
    ///   <para>rdfs:comment : It dictates the outcome of the interaction from two game objects.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameInteractionRule">ludo-gm:GameInteractionRule</a>
    /// </summary>
    let GameInteractionRule = _prefixId.prefix "GameInteractionRule"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Interaction Rule Outcome</para>
    ///   <para>rdfs:comment : Outcome of an Interaction Rule</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameInteractionRuleOutcome">ludo-gm:GameInteractionRuleOutcome</a>
    /// </summary>
    let GameInteractionRuleOutcome = _prefixId.prefix "GameInteractionRuleOutcome"
    /// <summary>
    ///   <para>rdfs:label : Game Knowledge Base</para>
    ///   <para>rdfs:comment : A Knowledge Base to be used by the game.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameKnowledgeBase">ludo-gm:GameKnowledgeBase</a>
    /// </summary>
    let GameKnowledgeBase = _prefixId.prefix "GameKnowledgeBase"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Object</para>
    ///   <para>rdfs:comment : Represents virtual things that populate the game world and can be designed to have a combination of abilities such as decision making, moving, acting and responding to surroundings and game players input simulating their existence in the game world.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameObject">ludo-gm:GameObject</a>
    /// </summary>
    let GameObject = _prefixId.prefix "GameObject"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Objective</para>
    ///   <para>rdfs:comment : Represents the goal associated to a game scenario</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameObjective">ludo-gm:GameObjective</a>
    /// </summary>
    let GameObjective = _prefixId.prefix "GameObjective"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Physics</para>
    ///   <para>rdfs:comment : Defines the physicality of the game world. It encompasses the collision world and environment forces.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GamePhysics">ludo-gm:GamePhysics</a>
    /// </summary>
    let GamePhysics = _prefixId.prefix "GamePhysics"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Player</para>
    ///   <para>rdfs:comment : The user of the game application who provides inputs to the game system as part of the gaming activity.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GamePlayer">ludo-gm:GamePlayer</a>
    /// </summary>
    let GamePlayer = _prefixId.prefix "GamePlayer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Presentation</para>
    ///   <para>rdfs:comment : A virtual canvas that holds media components and GUI components to form a game menu, a game notification or a cut-scene to present information about the game and allow them to navigate through the game structure</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GamePresentation">ludo-gm:GamePresentation</a>
    /// </summary>
    let GamePresentation = _prefixId.prefix "GamePresentation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Record</para>
    ///   <para>rdfs:comment : A game record is a log of game players achievements in the game</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameRecord">ludo-gm:GameRecord</a>
    /// </summary>
    let GameRecord = _prefixId.prefix "GameRecord"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Result</para>
    ///   <para>rdfs:comment : Game Result</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameResult">ludo-gm:GameResult</a>
    /// </summary>
    let GameResult = _prefixId.prefix "GameResult"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Rule</para>
    ///   <para>rdfs:comment : States the relationship between game objects and game world, and the effect of an interaction. It can either be a Game Scoring Rule or Game Interaction Rule.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameRule">ludo-gm:GameRule</a>
    /// </summary>
    let GameRule = _prefixId.prefix "GameRule"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Scenario</para>
    ///   <para>rdfs:comment : A description of a situation which require game player to overcome a number of challenges in order to achieve the defined objectives. It is also commonly termed as game level in gaming jargon.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameScenario">ludo-gm:GameScenario</a>
    /// </summary>
    let GameScenario = _prefixId.prefix "GameScenario"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Scoring Rule</para>
    ///   <para>rdfs:comment : Only applies to game player and it defines what to be awarded to the game player when a scoring condition is met.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameScoringRule">ludo-gm:GameScoringRule</a>
    /// </summary>
    let GameScoringRule = _prefixId.prefix "GameScoringRule"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Simulation</para>
    ///   <para>rdfs:comment : Represents the simulation of a game scenario and is governed by a set of rules that define the interactivity, physical and temporal properties of the virtual world. It has game rules, game dimension, game tempo and game physics.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameSimulation">ludo-gm:GameSimulation</a>
    /// </summary>
    let GameSimulation = _prefixId.prefix "GameSimulation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Structure</para>
    ///   <para>rdfs:comment : Describes the architecture and flow of the game. It segments game into game sections. A game section is composed of a game context, pedagogic event indicator and event trigger.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameStructure">ludo-gm:GameStructure</a>
    /// </summary>
    let GameStructure = _prefixId.prefix "GameStructure"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Tempo</para>
    ///   <para>rdfs:comment : Represents the realtion between the pace of the time in a game and the time in the real world.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameTempo">ludo-gm:GameTempo</a>
    /// </summary>
    let GameTempo = _prefixId.prefix "GameTempo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Theme</para>
    ///   <para>rdfs:comment : Describes most of the art requirements related the game through expressive written text.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GameTheme">ludo-gm:GameTheme</a>
    /// </summary>
    let GameTheme = _prefixId.prefix "GameTheme"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Goal Condition</para>
    ///   <para>rdfs:comment : The goal condition checks a track-able value against a constant value defined by the game designer to determine if the game objective has been met or not. The game objective is marked as achieve once the goal condition has been satisfied.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#GoalCondition">ludo-gm:GoalCondition</a>
    /// </summary>
    let GoalCondition = _prefixId.prefix "GoalCondition"
    let Graphic = _prefixId.prefix "Graphic"
    let InputEvent = _prefixId.prefix "InputEvent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Intelligence</para>
    ///   <para>rdfs:comment : Provides game object the ability to decide, navigate and even learn.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Intelligence">ludo-gm:Intelligence</a>
    /// </summary>
    let Intelligence = _prefixId.prefix "Intelligence"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Inventory</para>
    ///   <para>rdfs:comment : Inventory presents the idea where player can own a number of game objects in the game as part of the game play. An inventory can be a collection of weapons in a shooter game or a collection of magic spell and potions in a role-playing game. In games such as Resident Evil 5 (www.residentevil.com), a game player can hold 9 items in the inventory at any one time.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Inventory">ludo-gm:Inventory</a>
    /// </summary>
    let Inventory = _prefixId.prefix "Inventory"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Inventory State</para>
    ///   <para>rdfs:comment : The inventory is defined to hold a limited supply of consumable for a game object.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#InventoryState">ludo-gm:InventoryState</a>
    /// </summary>
    let InventoryState = _prefixId.prefix "InventoryState"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Learn</para>
    ///   <para>rdfs:comment : Learn</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Learn">ludo-gm:Learn</a>
    /// </summary>
    let Learn = _prefixId.prefix "Learn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Mass</para>
    ///   <para>rdfs:comment : The mass that affects the motion of the game object</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Mass">ludo-gm:Mass</a>
    /// </summary>
    let Mass = _prefixId.prefix "Mass"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Motion</para>
    ///   <para>rdfs:comment : Motion refers to the actual translation of game object position in the game world. A motion is subject to a force and also constraints (external force).</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Motion">ludo-gm:Motion</a>
    /// </summary>
    let Motion = _prefixId.prefix "Motion"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Navigate</para>
    ///   <para>rdfs:comment : Navigate</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Navigate">ludo-gm:Navigate</a>
    /// </summary>
    let Navigate = _prefixId.prefix "Navigate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Object Atrribute</para>
    ///   <para>rdfs:comment : Data properties that represent a game objects vitality, physical being, cognitive state and ownership</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectAttribute">ludo-gm:ObjectAttribute</a>
    /// </summary>
    let ObjectAttribute = _prefixId.prefix "ObjectAttribute"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Object Image</para>
    ///   <para>rdfs:comment : The object image is represented using one or more image components</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectImage">ludo-gm:ObjectImage</a>
    /// </summary>
    let ObjectImage = _prefixId.prefix "ObjectImage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Object Vitality</para>
    ///   <para>rdfs:comment : Vitality of an object such as life or interrelated attributes such as health, energy, strength, social and etc.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectVitality">ludo-gm:ObjectVitality</a>
    /// </summary>
    let ObjectVitality = _prefixId.prefix "ObjectVitality"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Objects attribute</para>
    ///   <para>rdfs:comment : Objects attribute</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#ObjectsAttribute">ludo-gm:ObjectsAttribute</a>
    /// </summary>
    let ObjectsAttribute = _prefixId.prefix "ObjectsAttribute"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Pedagogic Event Indicator</para>
    ///   <para>rdfs:comment : Each game section is associated with one or more pedagogic events from the Gagnes nine events of instructions</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#PedagogicEventIndicator">ludo-gm:PedagogicEventIndicator</a>
    /// </summary>
    let PedagogicEventIndicator = _prefixId.prefix "PedagogicEventIndicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Presentation-based Structure</para>
    ///   <para>rdfs:comment : Presentation-based Structure</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Presentation-basedStructure">ludo-gm:Presentation-basedStructure</a>
    /// </summary>
    let Presentation_basedStructure = _prefixId.prefix "Presentation-basedStructure"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Raw result</para>
    ///   <para>rdfs:comment : Raw result</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#RawResult">ludo-gm:RawResult</a>
    /// </summary>
    let RawResult = _prefixId.prefix "RawResult"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Scenario-based Structure</para>
    ///   <para>rdfs:comment : Scenario-based Structure</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Scenario-basedStructure">ludo-gm:Scenario-basedStructure</a>
    /// </summary>
    let Scenario_basedStructure = _prefixId.prefix "Scenario-basedStructure"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Score</para>
    ///   <para>rdfs:comment : Score</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Score">ludo-gm:Score</a>
    /// </summary>
    let Score = _prefixId.prefix "Score"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Serious Game</para>
    ///   <para>rdfs:comment : Serious Game</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#SeriousGame">ludo-gm:SeriousGame</a>
    /// </summary>
    let SeriousGame = _prefixId.prefix "SeriousGame"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Solidity State</para>
    ///   <para>rdfs:comment : The solidity state defines if a game object is solid, whereas the mass affects the motion of the game object.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#SoidityState">ludo-gm:SoidityState</a>
    /// </summary>
    let SoidityState = _prefixId.prefix "SoidityState"
    let Sound = _prefixId.prefix "Sound"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Training-based Structure</para>
    ///   <para>rdfs:comment : Training-based Structure</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Training-basedStructure">ludo-gm:Training-basedStructure</a>
    /// </summary>
    let Training_basedStructure = _prefixId.prefix "Training-basedStructure"
    let Video = _prefixId.prefix "Video"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Virtual Camera</para>
    ///   <para>rdfs:comment : Viewport to the game world</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#VirtualCamera">ludo-gm:VirtualCamera</a>
    /// </summary>
    let VirtualCamera = _prefixId.prefix "VirtualCamera"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Vital</para>
    ///   <para>rdfs:comment : Game designers can choose to represent the game object using a single vital definition such as life or further elaborate the vitality of a game object into interrelated attributes such as health, energy, strength, social and etc. </para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#Vital">ludo-gm:Vital</a>
    /// </summary>
    let Vital = _prefixId.prefix "Vital"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Vital Update</para>
    ///   <para>rdfs:comment : Revises the value of vitals for a game object as a measure that takes into account the cost of an action inflicted to the object or the cost of performing an action.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#VitalUpdate">ludo-gm:VitalUpdate</a>
    /// </summary>
    let VitalUpdate = _prefixId.prefix "VitalUpdate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Acting Coordination</para>
    ///   <para>rdfs:comment : The coordination of a game object can involve appear (for generation and re- spawning of game object), animating an action, playing a sound, moving towards a checkpoint, interacting with another game object or a composition of these.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasActingCoordination">ludo-gm:hasActingCoordination</a>
    /// </summary>
    let hasActingCoordination = _prefixId.prefix "hasActingCoordination"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has action</para>
    ///   <para>rdfs:comment : Has action</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasAction">ludo-gm:hasAction</a>
    /// </summary>
    let hasAction = _prefixId.prefix "hasAction"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has animation</para>
    ///   <para>rdfs:comment : Has animation</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasAnimation">ludo-gm:hasAnimation</a>
    /// </summary>
    let hasAnimation = _prefixId.prefix "hasAnimation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Animation Type</para>
    ///   <para>rdfs:comment : Defines the animation type, either 2D or 3D</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasAnimationType">ludo-gm:hasAnimationType</a>
    /// </summary>
    let hasAnimationType = _prefixId.prefix "hasAnimationType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has appearance</para>
    ///   <para>rdfs:comment : Has appearance</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasAppearance">ludo-gm:hasAppearance</a>
    /// </summary>
    let hasAppearance = _prefixId.prefix "hasAppearance"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has area</para>
    ///   <para>rdfs:comment : Relates an Area with any component to be represented graphically on the game screen, sucha as GUI components and Media components</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasArea">ludo-gm:hasArea</a>
    /// </summary>
    let hasArea = _prefixId.prefix "hasArea"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has art requirement</para>
    ///   <para>rdfs:comment : Has art requirement</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasArtRequirement">ludo-gm:hasArtRequirement</a>
    /// </summary>
    let hasArtRequirement = _prefixId.prefix "hasArtRequirement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has constraint</para>
    ///   <para>rdfs:comment : Has constraint</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasConstraint">ludo-gm:hasConstraint</a>
    /// </summary>
    let hasConstraint = _prefixId.prefix "hasConstraint"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has difficulty indicator</para>
    ///   <para>rdfs:comment : Has difficulty indicator</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasDifficultyIndicator">ludo-gm:hasDifficultyIndicator</a>
    /// </summary>
    let hasDifficultyIndicator = _prefixId.prefix "hasDifficultyIndicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Difficulty</para>
    ///   <para>rdfs:comment : Has difficulty indicator value</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasDifficultyIndicatorValue">ludo-gm:hasDifficultyIndicatorValue</a>
    /// </summary>
    let hasDifficultyIndicatorValue = _prefixId.prefix "hasDifficultyIndicatorValue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has event trigger</para>
    ///   <para>rdfs:comment : The property to relate a Game Structure or a Game Event with an Event Trigger</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTrigger">ludo-gm:hasEventTrigger</a>
    /// </summary>
    let hasEventTrigger = _prefixId.prefix "hasEventTrigger"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Event Trigger Class</para>
    ///   <para>rdfs:comment : Event triggers are used to invoke the transition between game sections and activate the game events within a game scenario. They can be classified into four distinct classes, namely: Input trigger detects user input via hardware interface or graphical user interface (GUI); Time trigger is essentially a countdown timer with an interval value with frequency of once, to repeat infinitely or to repeat finitely; Proximity trigger like input trigger has a hotspot that detects the collision of a specified game object, a class of game object or a group of game objects from different classes; Game mechanics trigger is associated to a range of game application related of events such media event, game event and simulation event. Each event trigger is associated with a command that specify the transition between game sections or activation of a game event.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTriggerClass">ludo-gm:hasEventTriggerClass</a>
    /// </summary>
    let hasEventTriggerClass = _prefixId.prefix "hasEventTriggerClass"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Event trigger command</para>
    ///   <para>rdfs:comment : Has Event trigger command</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasEventTriggerCommand">ludo-gm:hasEventTriggerCommand</a>
    /// </summary>
    let hasEventTriggerCommand = _prefixId.prefix "hasEventTriggerCommand"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has force</para>
    ///   <para>rdfs:comment : Has force</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasForce">ludo-gm:hasForce</a>
    /// </summary>
    let hasForce = _prefixId.prefix "hasForce"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has front end display</para>
    ///   <para>rdfs:comment : Has front end display</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasFrontEndDisplay">ludo-gm:hasFrontEndDisplay</a>
    /// </summary>
    let hasFrontEndDisplay = _prefixId.prefix "hasFrontEndDisplay"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Act</para>
    ///   <para>rdfs:comment : Has Game Act</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameAct">ludo-gm:hasGameAct</a>
    /// </summary>
    let hasGameAct = _prefixId.prefix "hasGameAct"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Act Object</para>
    ///   <para>rdfs:comment : Has Game Act Object</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameActObject">ludo-gm:hasGameActObject</a>
    /// </summary>
    let hasGameActObject = _prefixId.prefix "hasGameActObject"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game Acting Script</para>
    ///   <para>rdfs:comment : Game Acting Script</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameActingScript">ludo-gm:hasGameActingScript</a>
    /// </summary>
    let hasGameActingScript = _prefixId.prefix "hasGameActingScript"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Attribute</para>
    ///   <para>rdfs:comment : Has Game Attribute</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameAttribute">ludo-gm:hasGameAttribute</a>
    /// </summary>
    let hasGameAttribute = _prefixId.prefix "hasGameAttribute"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Context</para>
    ///   <para>rdfs:comment : Has Game Context</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameContext">ludo-gm:hasGameContext</a>
    /// </summary>
    let hasGameContext = _prefixId.prefix "hasGameContext"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Control</para>
    ///   <para>rdfs:comment : Has Game Control</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameControl">ludo-gm:hasGameControl</a>
    /// </summary>
    let hasGameControl = _prefixId.prefix "hasGameControl"
    /// <summary>
    ///   <para>rdfs:label : Has Game Control Interface</para>
    ///   <para>rdfs:comment : Has Game Control Interface</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameControlInterface">ludo-gm:hasGameControlInterface</a>
    /// </summary>
    let hasGameControlInterface = _prefixId.prefix "hasGameControlInterface"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Dimension</para>
    ///   <para>rdfs:comment : The game dimension refers to the virtual space of which the game simulation takes place. It can either be 2D or 3D.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameDimension">ludo-gm:hasGameDimension</a>
    /// </summary>
    let hasGameDimension = _prefixId.prefix "hasGameDimension"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Dimention</para>
    ///   <para>rdfs:comment : Has Game Dimention</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameDimention">ludo-gm:hasGameDimention</a>
    /// </summary>
    let hasGameDimention = _prefixId.prefix "hasGameDimention"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Environment</para>
    ///   <para>rdfs:comment : Has Game Environment</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameEnvironment">ludo-gm:hasGameEnvironment</a>
    /// </summary>
    let hasGameEnvironment = _prefixId.prefix "hasGameEnvironment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Event</para>
    ///   <para>rdfs:comment : Has Game Event</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameEvent">ludo-gm:hasGameEvent</a>
    /// </summary>
    let hasGameEvent = _prefixId.prefix "hasGameEvent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Knowledge-Base</para>
    ///   <para>rdfs:comment : Has Game Knowledge-Base</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameKnowledgeBase">ludo-gm:hasGameKnowledgeBase</a>
    /// </summary>
    let hasGameKnowledgeBase = _prefixId.prefix "hasGameKnowledgeBase"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Object</para>
    ///   <para>rdfs:comment : This property applies for a Game Environment, a Serious Game and an Inventory</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameObject">ludo-gm:hasGameObject</a>
    /// </summary>
    let hasGameObject = _prefixId.prefix "hasGameObject"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Objective</para>
    ///   <para>rdfs:comment : This property relates with a Game Objective. Can be used for Game Scenario and Inventory objects.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameObjective">ludo-gm:hasGameObjective</a>
    /// </summary>
    let hasGameObjective = _prefixId.prefix "hasGameObjective"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Physics</para>
    ///   <para>rdfs:comment : Has Game Physics</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGamePhysics">ludo-gm:hasGamePhysics</a>
    /// </summary>
    let hasGamePhysics = _prefixId.prefix "hasGamePhysics"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Player</para>
    ///   <para>rdfs:comment : Has Game Player</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGamePlayer">ludo-gm:hasGamePlayer</a>
    /// </summary>
    let hasGamePlayer = _prefixId.prefix "hasGamePlayer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Record</para>
    ///   <para>rdfs:comment : Has Game Record</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameRecord">ludo-gm:hasGameRecord</a>
    /// </summary>
    let hasGameRecord = _prefixId.prefix "hasGameRecord"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Result</para>
    ///   <para>rdfs:comment : Has Game Result</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameResult">ludo-gm:hasGameResult</a>
    /// </summary>
    let hasGameResult = _prefixId.prefix "hasGameResult"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Rule</para>
    ///   <para>rdfs:comment : This property relates a Game Simulation with a Game Rule</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameRule">ludo-gm:hasGameRule</a>
    /// </summary>
    let hasGameRule = _prefixId.prefix "hasGameRule"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Scenario</para>
    ///   <para>rdfs:comment : Has Game Scenario</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameScenario">ludo-gm:hasGameScenario</a>
    /// </summary>
    let hasGameScenario = _prefixId.prefix "hasGameScenario"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Structure</para>
    ///   <para>rdfs:comment : Has Game Structure</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameStructure">ludo-gm:hasGameStructure</a>
    /// </summary>
    let hasGameStructure = _prefixId.prefix "hasGameStructure"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Tempo</para>
    ///   <para>rdfs:comment : Has Game Tempo</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameTempo">ludo-gm:hasGameTempo</a>
    /// </summary>
    let hasGameTempo = _prefixId.prefix "hasGameTempo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Game Theme</para>
    ///   <para>rdfs:comment : Has Game Theme</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGameTheme">ludo-gm:hasGameTheme</a>
    /// </summary>
    let hasGameTheme = _prefixId.prefix "hasGameTheme"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Goal Condition</para>
    ///   <para>rdfs:comment : Has Goal Condition</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGoalCondition">ludo-gm:hasGoalCondition</a>
    /// </summary>
    let hasGoalCondition = _prefixId.prefix "hasGoalCondition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Goal Condition description</para>
    ///   <para>rdfs:comment : The description of the goal condition</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasGoalConditionDescription">ludo-gm:hasGoalConditionDescription</a>
    /// </summary>
    let hasGoalConditionDescription = _prefixId.prefix "hasGoalConditionDescription"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has hardware Interface</para>
    ///   <para>rdfs:comment : Examples of hardware interface include keyboard, mouse, gamepad, joystick, motionsensor, camera and microphone.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasHardwareInterface">ludo-gm:hasHardwareInterface</a>
    /// </summary>
    let hasHardwareInterface = _prefixId.prefix "hasHardwareInterface"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Input Event</para>
    ///   <para>rdfs:comment : Has Input Event</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasInputEvent">ludo-gm:hasInputEvent</a>
    /// </summary>
    let hasInputEvent = _prefixId.prefix "hasInputEvent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Intelligences</para>
    ///   <para>rdfs:comment : Has Intelligences</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasIntelligences">ludo-gm:hasIntelligences</a>
    /// </summary>
    let hasIntelligences = _prefixId.prefix "hasIntelligences"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Interaction Condition</para>
    ///   <para>rdfs:comment : It refers to the state of actor or the state of the game world</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionCondition">ludo-gm:hasInteractionCondition</a>
    /// </summary>
    let hasInteractionCondition = _prefixId.prefix "hasInteractionCondition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Interaction Rule Actor</para>
    ///   <para>rdfs:comment : Interaction Rule Actor</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleActor">ludo-gm:hasInteractionRuleActor</a>
    /// </summary>
    let hasInteractionRuleActor = _prefixId.prefix "hasInteractionRuleActor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Interaction Rule Outcome</para>
    ///   <para>rdfs:comment : Interaction Rule Outcome</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleOutcome">ludo-gm:hasInteractionRuleOutcome</a>
    /// </summary>
    let hasInteractionRuleOutcome = _prefixId.prefix "hasInteractionRuleOutcome"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Interaction Rule Outcome Operation</para>
    ///   <para>rdfs:comment : Rewarding the player with any game object can mean give (add) or take away (subtract) an item or increase (add) or decrease (subtract) in the value of an attribute to provide the game player the advantage to succeed in the game.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleOutcomeOperation">ludo-gm:hasInteractionRuleOutcomeOperation</a>
    /// </summary>
    let hasInteractionRuleOutcomeOperation =
        _prefixId.prefix "hasInteractionRuleOutcomeOperation"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Interaction Rule Subject</para>
    ///   <para>rdfs:comment : Interaction Rule Subject</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasInteractionRuleSubject">ludo-gm:hasInteractionRuleSubject</a>
    /// </summary>
    let hasInteractionRuleSubject = _prefixId.prefix "hasInteractionRuleSubject"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Inventory</para>
    ///   <para>rdfs:comment : Has Inventory</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasInventory">ludo-gm:hasInventory</a>
    /// </summary>
    let hasInventory = _prefixId.prefix "hasInventory"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has inventory quantity</para>
    ///   <para>rdfs:comment : Has inventory quantity</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasInventoryQuantity">ludo-gm:hasInventoryQuantity</a>
    /// </summary>
    let hasInventoryQuantity = _prefixId.prefix "hasInventoryQuantity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Mass</para>
    ///   <para>rdfs:comment : The amount of matter of an object in Kilograms.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasMass">ludo-gm:hasMass</a>
    /// </summary>
    let hasMass = _prefixId.prefix "hasMass"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Interaction Rule Outcome Matter</para>
    ///   <para>rdfs:comment : Each game rule is paired with an outcome which has a matter and an operation to add or subtract a value from the matter. Matter in the context of game refers to an item, an attribute or permission.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasMatter">ludo-gm:hasMatter</a>
    /// </summary>
    let hasMatter = _prefixId.prefix "hasMatter"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Motion</para>
    ///   <para>rdfs:comment : Has Motion</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasMotion">ludo-gm:hasMotion</a>
    /// </summary>
    let hasMotion = _prefixId.prefix "hasMotion"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Normal force</para>
    ///   <para>rdfs:comment : The normal force</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasNormalForce">ludo-gm:hasNormalForce</a>
    /// </summary>
    let hasNormalForce = _prefixId.prefix "hasNormalForce"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Object Vitality</para>
    ///   <para>rdfs:comment : Vitality of an object such as life or interrelated attributes such as health, energy, strength, social and etc.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasObjectVitality">ludo-gm:hasObjectVitality</a>
    /// </summary>
    let hasObjectVitality = _prefixId.prefix "hasObjectVitality"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Object Vitality Value</para>
    ///   <para>rdfs:comment : Object Vitality Value</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasObjectVitalityValue">ludo-gm:hasObjectVitalityValue</a>
    /// </summary>
    let hasObjectVitalityValue = _prefixId.prefix "hasObjectVitalityValue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Pedagogic Event</para>
    ///   <para>rdfs:comment : Associates each game section with one or more pedagogic events from the Gagne's nine events of instructions. These events ordered in sequence are (1) gaining attention, (2) informing learning objectives, (3) recalling prior learning, (4) presenting learning content, (5) providing learning guidance, (6) eliciting performance, (7) provide feedback, (8) assess performance and, (9) enhance retention and transfer.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasPedagogicEvent">ludo-gm:hasPedagogicEvent</a>
    /// </summary>
    let hasPedagogicEvent = _prefixId.prefix "hasPedagogicEvent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Pedagogic Event Indicator</para>
    ///   <para>rdfs:comment : Has Pedagogic Event Indicator</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasPedagogicEventIndicator">ludo-gm:hasPedagogicEventIndicator</a>
    /// </summary>
    let hasPedagogicEventIndicator = _prefixId.prefix "hasPedagogicEventIndicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Scoring Condition</para>
    ///   <para>rdfs:comment : Every game scoring rule has a scoring condition which has no direct relation with interaction. It can be derived from the state of a game object (e.g. enemy is dead or fire is extinguished), the input statistics (e.g. accuracy is above 80%), the time (e.g. respond is less than 5 seconds or level completed in less than 5 minutes), or the game objective (e.g. objective 1, 2 and 5 are met).</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasScoringCondition">ludo-gm:hasScoringCondition</a>
    /// </summary>
    let hasScoringCondition = _prefixId.prefix "hasScoringCondition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Scoring Rule Outcome</para>
    ///   <para>rdfs:comment : The outcome of an Scoring Rule</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasSoringRuleOutcome">ludo-gm:hasSoringRuleOutcome</a>
    /// </summary>
    let hasSoringRuleOutcome = _prefixId.prefix "hasSoringRuleOutcome"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Sound</para>
    ///   <para>rdfs:comment : Has Sound</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasSound">ludo-gm:hasSound</a>
    /// </summary>
    let hasSound = _prefixId.prefix "hasSound"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game tempo scale</para>
    ///   <para>rdfs:comment : The tempo scale at which the time is passing. This can be used for slow motion effects. When timeScale is 1.0 the time is passing as fast as realtime. When timeScale is 0.5 the time is passing 2x slower than realtime. When timeScale is set to zero the game is basically paused if all your functions are frame rate independent.y. Based on: http://docs.unity3d.com/ScriptReference/Time-timeScale.html</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasTempoScale">ludo-gm:hasTempoScale</a>
    /// </summary>
    let hasTempoScale = _prefixId.prefix "hasTempoScale"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has text</para>
    ///   <para>rdfs:comment : Has text</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasText">ludo-gm:hasText</a>
    /// </summary>
    let hasText = _prefixId.prefix "hasText"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : URI</para>
    ///   <para>rdfs:comment : Uniform Resource Identifier</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasURI">ludo-gm:hasURI</a>
    /// </summary>
    let hasURI = _prefixId.prefix "hasURI"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Virtual Camera</para>
    ///   <para>rdfs:comment : Has Virtual Camera</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasVirtualCamera">ludo-gm:hasVirtualCamera</a>
    /// </summary>
    let hasVirtualCamera = _prefixId.prefix "hasVirtualCamera"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Virtual Camera Position</para>
    ///   <para>rdfs:comment : Position of the virtual camera in the game world</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasVirtualCameraPosition">ludo-gm:hasVirtualCameraPosition</a>
    /// </summary>
    let hasVirtualCameraPosition = _prefixId.prefix "hasVirtualCameraPosition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has Vital Update</para>
    ///   <para>rdfs:comment : Has Vital Update</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#hasVitalUpdate">ludo-gm:hasVitalUpdate</a>
    /// </summary>
    let hasVitalUpdate = _prefixId.prefix "hasVitalUpdate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Solidity</para>
    ///   <para>rdfs:comment : Solidity</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/gamemodel#isSolid">ludo-gm:isSolid</a>
    /// </summary>
    let isSolid = _prefixId.prefix "isSolid"
