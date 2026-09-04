#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vgo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/net/VideoGameOntology#" "vgo"

    /// <summary>
    ///   <para>rdfs:label : Achievement</para>
    ///   <para>rdfs:comment : The vgo:Achievement is a reward gained in a game due to some event accomplished in the game. Achievements are commonly used in game industry to reward players for having accomplished tasks in the game.
    /// This ontology defines various subclasses of vgo:Achievement, which are all based on the classification presented by Markus Montola et al. [Markus Montola, Timo Nummenmaa, Andrés Lucero, Marion Boberg, and Hannu Korhonen, 2009, “Applying game achievement systems to enhance user experience in a photo sharing service”, In Proceedings of the 13th International MindTrek Conference: Everyday Life in the Ubiquitous Era (MindTrek '09)] http://dl.acm.org/citation.cfm?id=1621859</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Achievement">vgo:Achievement</a>
    /// </summary>
    let Achievement = _prefixId.prefix "Achievement"
    /// <summary>
    ///   <para>rdfs:label : Character</para>
    ///   <para>rdfs:comment : A vgo:Character is any actor that can exists in a game. A character  can be a human-like creature as seen traditionally in video games. However, a character could also be a car, a paddle in game of Pong or spaceship of a space shooter game. This is often contextually related to the gameplay of a certain game. A character can be either controller by a player or by a computer.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Character">vgo:Character</a>
    /// </summary>
    let Character = _prefixId.prefix "Character"
    /// <summary>
    ///   <para>rdfs:label : Collection</para>
    ///   <para>rdfs:comment : The vgo:Collection type of achievement is typically rewarded from collecting an amount of certain items in a game. An example of vgo:Collection would be obtaining a full set of christmas clothes for a character to wear or collecting every possible flower in the game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Collection">vgo:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:label : Completion</para>
    ///   <para>rdfs:comment : The vgo:Completion type of achievement is usually rewarded from successfully completing a certain goal or subgoal in a game. An example of vgo:Completion would be to save a princess from a burning tower or completing all side-quests in a game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Completion">vgo:Completion</a>
    /// </summary>
    let Completion = _prefixId.prefix "Completion"
    /// <summary>
    ///   <para>rdfs:label : Curiosity</para>
    ///   <para>rdfs:comment : The vgo:Curiosity describes funny random things that can happen or be found in the game. An example could be jumping from the Eiffel tower without dying or following a comupter controlled character’s activities for one hour.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Curiosity">vgo:Curiosity</a>
    /// </summary>
    let Curiosity = _prefixId.prefix "Curiosity"
    /// <summary>
    ///   <para>rdfs:label : Fandom</para>
    ///   <para>rdfs:comment : The vgo:Fandom achievement is related to doing some true fan activities. An example of vgo:Fandom could be purchasing a collectors edition of the game or attending a fan gathering.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Fandom">vgo:Fandom</a>
    /// </summary>
    let Fandom = _prefixId.prefix "Fandom"
    /// <summary>
    ///   <para>rdfs:label : Feature</para>
    ///   <para>rdfs:comment : vgo:Feature describes an ability or characteristic. For example, a sword could have “damage dealing” ability and a bottle of water could be “potable”.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Feature">vgo:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>rdfs:label : gain event</para>
    ///   <para>rdfs:comment : The vgo:GainEvent describes an event that is related to character/player gaining something in a game. This is a subclass of vgo:GameEvent as gaining something is related to a specific game. For example, a player can gain a new character, achievement or item.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#GainEvent">vgo:GainEvent</a>
    /// </summary>
    let GainEvent = _prefixId.prefix "GainEvent"
    /// <summary>
    ///   <para>rdfs:label : Game</para>
    ///   <para>rdfs:comment : The vgo:Game class describes a game product that can be played by a player.
    /// Examples of games are Pong, Grand Theft Auto, Pokemon and Need for Speed.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Game">vgo:Game</a>
    /// </summary>
    let Game = _prefixId.prefix "Game"
    /// <summary>
    ///   <para>rdfs:label : game event</para>
    ///   <para>rdfs:comment : The vgo:GameEvent describes an event that takes place in a game without straight player interaction. GameEvents are often very specific for each game. Examples of vgo:GameEvent could be an enemy dying, connecting to a multiplayer server, loading a new level or playing an animation.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#GameEvent">vgo:GameEvent</a>
    /// </summary>
    let GameEvent = _prefixId.prefix "GameEvent"
    /// <summary>
    ///   <para>rdfs:label : game product</para>
    ///   <para>rdfs:comment : A vgo:GameProduct is anything that is for sale inside a game. These can be either normal game items purchased with in-game currency or with real world money. An example of vgo:GameProduct could be a consumable health potion bought with real money, a better weapon or some visual improvement (e.g. Hats in Steam). Basically a game product can be anything, a character, an item or an achievement.
    /// GameProduct is a subclass of Good Relations: ProductOrService &amp; schema:Product. Since vgo:GameProduct is a type of buyable product, it reuses the properties available in the schema and Good Relations, such as currency price, validity of the offer and so on.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#GameProduct">vgo:GameProduct</a>
    /// </summary>
    let GameProduct = _prefixId.prefix "GameProduct"
    /// <summary>
    ///   <para>rdfs:label : Genre</para>
    ///   <para>rdfs:comment : The vgo:Genre class describes the genre a game belongs to. All of the games have at least one genre. Examples of this are RPG, Simulator and Adventure</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Genre">vgo:Genre</a>
    /// </summary>
    let Genre = _prefixId.prefix "Genre"
    /// <summary>
    ///   <para>rdfs:label : hard mode</para>
    ///   <para>rdfs:comment : The vgo:HardMode achievement describes succeeding in a game on a high difficulty level. An example could be completing the “Doom” game on Nightmare difficulty level.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#HardMode">vgo:HardMode</a>
    /// </summary>
    let HardMode = _prefixId.prefix "HardMode"
    /// <summary>
    ///   <para>rdfs:label : in-app purchase event</para>
    ///   <para>rdfs:comment : The vgo:InAppPurchaseEvent describes an event that is related to making a purchase with real money inside a game. This is a subclass of InstantaneousEvent because it happens at certain moment in time. An example of vgo:InAppPurchaseEvent would be unlocking secret levels with real money or purchasing better equipment with real money.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#InAppPurchaseEvent">vgo:InAppPurchaseEvent</a>
    /// </summary>
    let InAppPurchaseEvent = _prefixId.prefix "InAppPurchaseEvent"
    /// <summary>
    ///   <para>rdfs:label : instantaneous event</para>
    ///   <para>rdfs:comment : The vgo:InstantaneousEvent class describes an event that happens during the gameplay at a certain moment in time. This can be a player gaining an achievement, killing an enemy or making an in-app purchase.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#InstantaneousEvent">vgo:InstantaneousEvent</a>
    /// </summary>
    let InstantaneousEvent = _prefixId.prefix "InstantaneousEvent"
    /// <summary>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : A vgo:Item portrays any item that exists in a game. The item can either be just visual part of the game or a concrete usable item. As an example an item could be a drinkable potion, a magical sword or just a flower pot.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Item">vgo:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : Leaderboard</para>
    ///   <para>rdfs:comment : The vgo:Leaderboard class describes a ranking system of the players. There can be multiple rankings in a game, for example, the kill-count ranking of Modern Warfare or the best time listing of Formula 1 game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Leaderboard">vgo:Leaderboard</a>
    /// </summary>
    let Leaderboard = _prefixId.prefix "Leaderboard"
    /// <summary>
    ///   <para>rdfs:label : lose event</para>
    ///   <para>rdfs:comment : vgo:LoseEvent describes an event that is related to character/player losing something in a game. This is a subclass of GameEvent as gaining something is related to a specific game. For example, a player can lose a character due to trade with another player. Another example would be a character losing item due to consuming it.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#LoseEvent">vgo:LoseEvent</a>
    /// </summary>
    let LoseEvent = _prefixId.prefix "LoseEvent"
    /// <summary>
    ///   <para>rdfs:label : Loyalty</para>
    ///   <para>rdfs:comment : The vgo:Loyalty achievement is used to give recognition to loyal players. For example, this could be an achievement received after subscribing to the game for a year.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Loyalty">vgo:Loyalty</a>
    /// </summary>
    let Loyalty = _prefixId.prefix "Loyalty"
    /// <summary>
    ///   <para>rdfs:label : Luck</para>
    ///   <para>rdfs:comment : The vgo:Lucky describes an achievement that is awarded to the player in a lucky situation. An example of vgo:Lucky achievement would be winning in a lottery or throwing “Yahtzee” without re-rolling the dice.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Luck">vgo:Luck</a>
    /// </summary>
    let Luck = _prefixId.prefix "Luck"
    /// <summary>
    ///   <para>rdfs:label : menu event</para>
    ///   <para>rdfs:comment : The vgo:MenuEvent describes an event that is related to interacting with the ingame menu. An example of menu event is muting sounds, changing graphic settings, changing gameplay difficulty or remapping game controls.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#MenuEvent">vgo:MenuEvent</a>
    /// </summary>
    let MenuEvent = _prefixId.prefix "MenuEvent"
    /// <summary>
    ///   <para>rdfs:label : Minigame</para>
    ///   <para>rdfs:comment : The vgo:Minigame achievement describes success in mini-games that have been included in a certain game but are not vital for completing the game. An example could be to complete all the Pizza deliveries in GTA minigame or gaining over 100 dollars while playing poker in Red Dead Redemption.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Minigame">vgo:Minigame</a>
    /// </summary>
    let Minigame = _prefixId.prefix "Minigame"
    /// <summary>
    ///   <para>rdfs:label : Multiplayer</para>
    ///   <para>rdfs:comment : The vgo:Multiplayer achievement describes anything that can be awarded to one or multiple players due to their gameplay in multiplayer. For example, this could be winning 10 Team Fortress matches in a row with the same team or getting killed ten times in a row in Counter-Strike.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Multiplayer">vgo:Multiplayer</a>
    /// </summary>
    let Multiplayer = _prefixId.prefix "Multiplayer"
    /// <summary>
    ///   <para>rdfs:label : Paragon</para>
    ///   <para>rdfs:comment : The vgo:Paragon is a rare achievement that is given only to limited number of players. An example of vgo:Paragon achievement could be the first player to finish a game under 10 hours or the first ten players to complete the game 100% through.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Paragon">vgo:Paragon</a>
    /// </summary>
    let Paragon = _prefixId.prefix "Paragon"
    /// <summary>
    ///   <para>rdfs:label : Player</para>
    ///   <para>rdfs:comment : The vgo:Player describes the entity playing the game. This can be either a human or a computer. vgo:Player class is used to keep a profile of a certain playing entity and to connect all the games, achievements and characters he/she has. The vgo:Player is a subclass of foaf:Person as it contains all relative information of a certain person.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Player">vgo:Player</a>
    /// </summary>
    let Player = _prefixId.prefix "Player"
    /// <summary>
    ///   <para>rdfs:label : player event</para>
    ///   <para>rdfs:comment : The vgo:PlayerEvent describes a vgo:InstantaneousEvent that is caused by the player. For example jumping in the game, throwing an item or pressing a joystick button.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#PlayerEvent">vgo:PlayerEvent</a>
    /// </summary>
    let PlayerEvent = _prefixId.prefix "PlayerEvent"
    /// <summary>
    ///   <para>rdfs:label : playing area</para>
    ///   <para>rdfs:comment : The vgo:PlayingArea is the description of a place where the gameplay takes place. All of the games have some kind of area where they are played in. An example of playing areas could be football field in soccer game, a race track from a racing game or a star system of EVE Online.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#PlayingArea">vgo:PlayingArea</a>
    /// </summary>
    let PlayingArea = _prefixId.prefix "PlayingArea"
    /// <summary>
    ///   <para>rdfs:label : Session</para>
    ///   <para>rdfs:comment : The vgo:Session class describes a session of gameplay. A session can be a single round of chess, a round of Counter-Strike, one half-time of soccer or one race of Formula 1. vgo:Session class can be used to store gameplay information, especially for analytical reasons.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Session">vgo:Session</a>
    /// </summary>
    let Session = _prefixId.prefix "Session"
    /// <summary>
    ///   <para>rdfs:label : special play style</para>
    ///   <para>rdfs:comment : The vgo:SpecialPlayStyle achievement is awarded to players after playing a game in special fashion. Often this is something harder than the regular play and requires more player experience to excel in it. An example of vgo:SpecialPlayStyle could be to complete a game without any violence or against a timer.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#SpecialPlayStyle">vgo:SpecialPlayStyle</a>
    /// </summary>
    let SpecialPlayStyle = _prefixId.prefix "SpecialPlayStyle"
    /// <summary>
    ///   <para>rdfs:label : Tutorial</para>
    ///   <para>rdfs:comment : The vgo:Tutorial achievement is  awarded to a player for trying out various features of the game. This is often related to learning how to play the game, how the controls work and how the game logic works. An example of vgo:Tutorial could be testing out newly gained special equipment or just playing through the in-game tutorial in the beginning.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Tutorial">vgo:Tutorial</a>
    /// </summary>
    let Tutorial = _prefixId.prefix "Tutorial"
    /// <summary>
    ///   <para>rdfs:label : Veteran</para>
    ///   <para>rdfs:comment : The vgo:Veteran achievement is an award that is given for accumulating a lot of play hours or game actions. For example, vgo:Veteran could be playing thousand hours of World of Tanks or making 100 goals in ice hockey game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Veteran">vgo:Veteran</a>
    /// </summary>
    let Veteran = _prefixId.prefix "Veteran"
    /// <summary>
    ///   <para>rdfs:label : Virtuosity</para>
    ///   <para>rdfs:comment : The vgo:Virtuosity describes an achievement that is awarded for playing masterfully in the game. Examples of virtuous play could be finishing the game without saving at all, dying zero times or preventing an opposing team from scoring any goals in a soccer game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#Virtuosity">vgo:Virtuosity</a>
    /// </summary>
    let Virtuosity = _prefixId.prefix "Virtuosity"
    /// <summary>
    ///   <para>rdfs:label : end time</para>
    ///   <para>rdfs:comment : endTime describes the ending moment in time of a single Session. endTime connects the session to a DateTime value which holds the moment when the session ended.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#endTime">vgo:endTime</a>
    /// </summary>
    let endTime = _prefixId.prefix "endTime"
    /// <summary>
    ///   <para>rdfs:label : event name</para>
    ///   <para>rdfs:comment : name connects InstantaneousEvent a text string. This allows the event to have a name to recognize it for.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#eventName">vgo:eventName</a>
    /// </summary>
    let eventName = _prefixId.prefix "eventName"
    /// <summary>
    ///   <para>rdfs:label : event time</para>
    ///   <para>rdfs:comment : time describes the connection of InstantaneousEvent happening at a certain moment of time. time Conncets the event to a DateTime value that describes the moment when the event happened.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#eventTime">vgo:eventTime</a>
    /// </summary>
    let eventTime = _prefixId.prefix "eventTime"
    /// <summary>
    ///   <para>rdfs:label : has achievement</para>
    ///   <para>rdfs:comment : The vgo:hasAchievement property specifies that a game has a specific achievement. A game often contains more than one achievement that can be awarded to the players.rdfs:comment : optional</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#hasAchievement">vgo:hasAchievement</a>
    /// </summary>
    let hasAchievement = _prefixId.prefix "hasAchievement"
    /// <summary>
    ///   <para>rdfs:label : has character</para>
    ///   <para>rdfs:comment : The vgo:hasCharacter property specifies that a game has a specific character. A game can have more than one characters involved.rdfs:comment : optional</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#hasCharacter">vgo:hasCharacter</a>
    /// </summary>
    let hasCharacter = _prefixId.prefix "hasCharacter"
    /// <summary>
    ///   <para>rdfs:label : has feature</para>
    ///   <para>rdfs:comment : The vgo:hasFeature property indicates what is a vgo:Feature (or ability) of a particular vgo:Item. For example, a fire sword, a healing staff or boots of flight connects item to a feature it can have. An item with connection to potable feature would make the item potable.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#hasFeature">vgo:hasFeature</a>
    /// </summary>
    let hasFeature = _prefixId.prefix "hasFeature"
    /// <summary>
    ///   <para>rdfs:label : has game genre</para>
    ///   <para>rdfs:comment : The vgo:hasGameGenre property specifies that a game belongs to a certain game genre. For example, Pong would be an arcade game and Mario a platformer.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#hasGameGenre">vgo:hasGameGenre</a>
    /// </summary>
    let hasGameGenre = _prefixId.prefix "hasGameGenre"
    /// <summary>
    ///   <para>rdfs:label : has item</para>
    ///   <para>rdfs:comment : The vgo:hasItem property specifies that a game has a specific item. A game often contains more than one items.rdfs:comment : optional</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#hasItem">vgo:hasItem</a>
    /// </summary>
    let hasItem = _prefixId.prefix "hasItem"
    /// <summary>
    ///   <para>rdfs:label : has leaderboard</para>
    ///   <para>rdfs:comment : The vgo:hasLeaderboard specifies that a leaderboard belongs to a particular game. A game can have one or more leaderboards that keep track of ranking of the players. For example a leaderboard could be ranking of who has the most soccer game victories or who has the fastest lap in a Formula 1 game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#hasLeaderboard">vgo:hasLeaderboard</a>
    /// </summary>
    let hasLeaderboard = _prefixId.prefix "hasLeaderboard"
    /// <summary>
    ///   <para>rdfs:label : has playing area</para>
    ///   <para>rdfs:comment : The vgo:hasPlayingArea property asserts a gaming area to a specific game. In every game, the gameplay takes place in some playing area.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#hasPlayingArea">vgo:hasPlayingArea</a>
    /// </summary>
    let hasPlayingArea = _prefixId.prefix "hasPlayingArea"
    /// <summary>
    ///   <para>rdfs:label : involves achievement</para>
    ///   <para>rdfs:comment : The vgo:involvesPlayer property specifies that a session involves a specific player. A session may involve more than one player.rdfs:comment : optional</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#involvesAchievement">vgo:involvesAchievement</a>
    /// </summary>
    let involvesAchievement = _prefixId.prefix "involvesAchievement"
    /// <summary>
    ///   <para>rdfs:label : involves character</para>
    ///   <para>rdfs:comment : The vgo:involvesCharacter property specifies that a session involves a specific character.rdfs:comment : optional</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#involvesCharacter">vgo:involvesCharacter</a>
    /// </summary>
    let involvesCharacter = _prefixId.prefix "involvesCharacter"
    /// <summary>
    ///   <para>rdfs:label : involves player</para>
    ///   <para>rdfs:comment : The vgo:involvesPlayer property specifies that a session involves a specific player. A session may involve more than one player.rdfs:comment : optional</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#involvesPlayer">vgo:involvesPlayer</a>
    /// </summary>
    let involvesPlayer = _prefixId.prefix "involvesPlayer"
    /// <summary>
    ///   <para>rdfs:label : is achieved in session</para>
    ///   <para>rdfs:comment : The property vgo:isAchievedInSession asserts the receiving of an achievement to a certain gameplay session. This enables to keep track of what achievements a player has gained during one gameplay session.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isAchievedInSession">vgo:isAchievedInSession</a>
    /// </summary>
    let isAchievedInSession = _prefixId.prefix "isAchievedInSession"
    /// <summary>
    ///   <para>rdfs:label : is achievement in game</para>
    ///   <para>rdfs:comment : The property vgo:isAchievementInGame asserts that a specific vgo:Achievement can be earned in a particular vgo:Game. An achievement must belong to a certain game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isAchievementInGame">vgo:isAchievementInGame</a>
    /// </summary>
    let isAchievementInGame = _prefixId.prefix "isAchievementInGame"
    /// <summary>
    ///   <para>rdfs:label : is character in game</para>
    ///   <para>rdfs:comment : vgo:isCharacterInGame property describes the relation between a vgo:Character and a vgo:Game. a vgo:Character always belongs to a certain game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isCharacterInGame">vgo:isCharacterInGame</a>
    /// </summary>
    let isCharacterInGame = _prefixId.prefix "isCharacterInGame"
    /// <summary>
    ///   <para>rdfs:label : is character in session</para>
    ///   <para>rdfs:comment : The vgo:isCharacterInSession property connects the vgo:Character to a vgo:Session. A character participates in a game session (e.g., a football match or a counter strike round) during a period of time. As players can have multiple characters, a character needs to be connected to the session, in order to know which of those characters participated in the certain session.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isCharacterInSession">vgo:isCharacterInSession</a>
    /// </summary>
    let isCharacterInSession = _prefixId.prefix "isCharacterInSession"
    /// <summary>
    ///   <para>rdfs:label : is event associated to player</para>
    ///   <para>rdfs:comment : The vgo:isEventAssociatedToPlayer property asserts an event to a specific vgo:Player. A player may have caused an event to happen through the actions of his/her character and this property is used to connect the real person to the event.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isEventAssociatedToPlayer">vgo:isEventAssociatedToPlayer</a>
    /// </summary>
    let isEventAssociatedToPlayer = _prefixId.prefix "isEventAssociatedToPlayer"
    /// <summary>
    ///   <para>rdfs:label : is event in game</para>
    ///   <para>rdfs:comment : The vgo:isEventInGame property asserts an event to a specific game. An event always happens inside a specific a game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isEventInGame">vgo:isEventInGame</a>
    /// </summary>
    let isEventInGame = _prefixId.prefix "isEventInGame"
    /// <summary>
    ///   <para>rdfs:label : is event in session</para>
    ///   <para>rdfs:comment : The vgo:isEventInSession property links an event to a specific gameplay session. An event always happens during a certain session and this property enables to link the events to that session. For example, an event of moving the queen in game of chess should be connected to a session of chess.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isEventInSession">vgo:isEventInSession</a>
    /// </summary>
    let isEventInSession = _prefixId.prefix "isEventInSession"
    /// <summary>
    ///   <para>rdfs:label : is event related to item</para>
    ///   <para>rdfs:comment : The vgo:isEventRelatedToItem property asserts an event to a specific item. This property is used to describe an event that includes an item in one way or another. For example, an event where character gains a new sword can be described with this relation.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isEventRelatedToItem">vgo:isEventRelatedToItem</a>
    /// </summary>
    let isEventRelatedToItem = _prefixId.prefix "isEventRelatedToItem"
    /// <summary>
    ///   <para>rdfs:label : is event triggered by character</para>
    ///   <para>rdfs:comment : The vgo:isEventTriggeredByCharacter connects the vgo:InstantaneousEvent to specific vgo:Character. This describes that an event is often caused by a character. The character in question can be either a character controlled by a player or a computer. For example, both player and non-player characters can trigger a character death event.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isEventTriggeredByCharacter">vgo:isEventTriggeredByCharacter</a>
    /// </summary>
    let isEventTriggeredByCharacter = _prefixId.prefix "isEventTriggeredByCharacter"
    /// <summary>
    ///   <para>rdfs:label : is friend with player</para>
    ///   <para>rdfs:comment : The vgo:isFriendWithPlayer describes a connection between players. The property is used to model the friends a player has and with whom he might be playing games with. The friends of a player are not bound necessarily to particular game, but can be describe the friendly playing relationship in overall.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isFriendWithPlayer">vgo:isFriendWithPlayer</a>
    /// </summary>
    let isFriendWithPlayer = _prefixId.prefix "isFriendWithPlayer"
    /// <summary>
    ///   <para>rdfs:label : is item in game</para>
    ///   <para>rdfs:comment : The vgo:isItemInGame is used to specify which item belongs to a particular game. An item cannot exist alone and thus should always be associated to a certain game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isItemInGame">vgo:isItemInGame</a>
    /// </summary>
    let isItemInGame = _prefixId.prefix "isItemInGame"
    /// <summary>
    ///   <para>rdfs:label : is leaderboard in game</para>
    ///   <para>rdfs:comment : The vgo:isLeaderboardInGame property specifies that a leaderboard is from a specific game.rdfs:comment : optional</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isLeaderboardInGame">vgo:isLeaderboardInGame</a>
    /// </summary>
    let isLeaderboardInGame = _prefixId.prefix "isLeaderboardInGame"
    /// <summary>
    ///   <para>rdfs:label : is player in session</para>
    ///   <para>rdfs:comment : The vgo:isPlayerInSession property connects vgo:Player to a specific vgo:Session. This property is used to keep track of the gameplay sessions the player has played and what has happened in those sessions. For example vgo:Player may have participated in a this can be a one round of Counter-Strike or played one hour session of mario.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isPlayerInSession">vgo:isPlayerInSession</a>
    /// </summary>
    let isPlayerInSession = _prefixId.prefix "isPlayerInSession"
    /// <summary>
    ///   <para>rdfs:label : is session in game</para>
    ///   <para>rdfs:comment : The vgo:isSessionInGame property links a vgo:Session to a certain vgo:Game. Each gameplay session must belong to a certain game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#isSessionInGame">vgo:isSessionInGame</a>
    /// </summary>
    let isSessionInGame = _prefixId.prefix "isSessionInGame"
    /// <summary>
    ///   <para>rdfs:label : lives in</para>
    ///   <para>rdfs:comment : The vgo:livesIn describes the connection between a player and his place of existence in the real-world. A vgo:Player is connected to wgs84:SpatialThing as that has descriptions for places where people live and contains more detailed information of them, such as continents and regions.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#livesIn">vgo:livesIn</a>
    /// </summary>
    let livesIn = _prefixId.prefix "livesIn"
    /// <summary>
    ///   <para>rdfs:label : owns achievement</para>
    ///   <para>rdfs:comment : The vgo:ownsAchievement links the vgo:Player to the particular vgo:Achievement earned in a game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#ownsAchievement">vgo:ownsAchievement</a>
    /// </summary>
    let ownsAchievement = _prefixId.prefix "ownsAchievement"
    /// <summary>
    ///   <para>rdfs:label : owns character</para>
    ///   <para>rdfs:comment : The vgo:ownsCharacter property asserts which characters are owned by a specific player. A player can have multiple characters in one game and this connection is used to define all the different characters a player could be playing. Even though a player deletes, trades or loses his/her character in any way, the connection can be kept to contain the player’s history of owned characters.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#ownsCharacter">vgo:ownsCharacter</a>
    /// </summary>
    let ownsCharacter = _prefixId.prefix "ownsCharacter"
    /// <summary>
    ///   <para>rdfs:label : owns item</para>
    ///   <para>rdfs:comment : The vgo:ownsItem describes ownership of an item. A vgo:Item is always owned by a certain vgo:Character. A vgo:Character can own multiple vgo:Items and this relationship is used to keep track of the character’s owned items. Even though players may lose items, the vgo:ownsItem connection is still held with the item. This approach allows to keep track of character’s history of owned items.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#ownsItem">vgo:ownsItem</a>
    /// </summary>
    let ownsItem = _prefixId.prefix "ownsItem"
    /// <summary>
    ///   <para>rdfs:label : plays game</para>
    ///   <para>rdfs:comment : the vgo:playsGame property asserts which games has the vgo:Player played at any point of time.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#playsGame">vgo:playsGame</a>
    /// </summary>
    let playsGame = _prefixId.prefix "playsGame"
    /// <summary>
    ///   <para>rdfs:label : purchases game offering</para>
    ///   <para>rdfs:comment : The vgo:purchasesGameOffering property aseerts a vgo:InAppPurchaseEvent to a specific vgo:GameProduct. This property describes what is purchased by the in-app purchase event that the player has done.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#purchasesGameOffering">vgo:purchasesGameOffering</a>
    /// </summary>
    let purchasesGameOffering = _prefixId.prefix "purchasesGameOffering"
    /// <summary>
    ///   <para>rdfs:label : release date</para>
    ///   <para>rdfs:comment : releaseDate connects a game to a time which describes the release date of the game.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#releaseDate">vgo:releaseDate</a>
    /// </summary>
    let releaseDate = _prefixId.prefix "releaseDate"
    /// <summary>
    ///   <para>rdfs:label : start time</para>
    ///   <para>rdfs:comment : startTime describes the starting moment in time of a single Session. startTime connects the session to a DateTime value which holds the moment when the session started.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#startTime">vgo:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
    /// <summary>
    ///   <para>rdfs:label : unlocks achievement</para>
    ///   <para>rdfs:comment : The vgo:unlocksAchievement property asserts an event to a certain achievement. An achievement is always unlocked as a consequence of some event. For example, eating the 100th piece of cake unlocks the “Cake Eater” achievement.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#unlocksAchievement">vgo:unlocksAchievement</a>
    /// </summary>
    let unlocksAchievement = _prefixId.prefix "unlocksAchievement"
    /// <summary>
    ///   <para>rdfs:label : username</para>
    ///   <para>rdfs:comment : The username connects player to a text string which describes the username a player has.</para>
    ///   <a href="http://purl.org/net/VideoGameOntology#username">vgo:username</a>
    /// </summary>
    let username = _prefixId.prefix "username"
