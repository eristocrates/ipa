namespace http.purl.org.net.VideoGameOntology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vgo =
    let _namespace_iri = Namespace_Iri vgo |> NamespaceIRI
    /// <summary>
    ///   <para>vgo:Achievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Achievement is a reward gained in a game due to some event accomplished in the game. Achievements are commonly used in game industry to reward players for having accomplished tasks in the game.
    /// This ontology defines various subclasses of vgo:Achievement, which are all based on the classification presented by Markus Montola et al. [Markus Montola, Timo Nummenmaa, Andrés Lucero, Marion Boberg, and Hannu Korhonen, 2009, “Applying game achievement systems to enhance user experience in a photo sharing service”, In Proceedings of the 13th International MindTrek Conference: Everyday Life in the Ubiquitous Era (MindTrek '09)] http://dl.acm.org/citation.cfm?id=1621859"</para>
    /// labels<para>"Achievement"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Achievement">http://purl.org/net/VideoGameOntology#Achievement</seealso>
    let Achievement = Prefixed_Name(vgo, "Achievement") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vgo:Character is any actor that can exists in a game. A character  can be a human-like creature as seen traditionally in video games. However, a character could also be a car, a paddle in game of Pong or spaceship of a space shooter game. This is often contextually related to the gameplay of a certain game. A character can be either controller by a player or by a computer."</para>
    /// labels<para>"Character"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Character">http://purl.org/net/VideoGameOntology#Character</seealso>
    let Character = Prefixed_Name(vgo, "Character") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Collection type of achievement is typically rewarded from collecting an amount of certain items in a game. An example of vgo:Collection would be obtaining a full set of christmas clothes for a character to wear or collecting every possible flower in the game."</para>
    /// labels<para>"Collection"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Collection">http://purl.org/net/VideoGameOntology#Collection</seealso>
    let Collection = Prefixed_Name(vgo, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Completion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Completion type of achievement is usually rewarded from successfully completing a certain goal or subgoal in a game. An example of vgo:Completion would be to save a princess from a burning tower or completing all side-quests in a game."</para>
    /// labels<para>"Completion"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Completion">http://purl.org/net/VideoGameOntology#Completion</seealso>
    let Completion = Prefixed_Name(vgo, "Completion") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Curiosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Curiosity describes funny random things that can happen or be found in the game. An example could be jumping from the Eiffel tower without dying or following a comupter controlled character’s activities for one hour."</para>
    /// labels<para>"Curiosity"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Curiosity">http://purl.org/net/VideoGameOntology#Curiosity</seealso>
    let Curiosity = Prefixed_Name(vgo, "Curiosity") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Fandom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Fandom achievement is related to doing some true fan activities. An example of vgo:Fandom could be purchasing a collectors edition of the game or attending a fan gathering."</para>
    /// labels<para>"Fandom"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Fandom">http://purl.org/net/VideoGameOntology#Fandom</seealso>
    let Fandom = Prefixed_Name(vgo, "Fandom") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"vgo:Feature describes an ability or characteristic. For example, a sword could have “damage dealing” ability and a bottle of water could be “potable”."</para>
    /// labels<para>"Feature"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Feature">http://purl.org/net/VideoGameOntology#Feature</seealso>
    let Feature = Prefixed_Name(vgo, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>vgo:GainEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:GainEvent describes an event that is related to character/player gaining something in a game. This is a subclass of vgo:GameEvent as gaining something is related to a specific game. For example, a player can gain a new character, achievement or item."</para>
    /// labels<para>"gain event"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#GainEvent">http://purl.org/net/VideoGameOntology#GainEvent</seealso>
    let GainEvent = Prefixed_Name(vgo, "GainEvent") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Game</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Game class describes a game product that can be played by a player.
    /// Examples of games are Pong, Grand Theft Auto, Pokemon and Need for Speed."</para>
    /// labels<para>"Game"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Game">http://purl.org/net/VideoGameOntology#Game</seealso>
    let Game = Prefixed_Name(vgo, "Game") |> PrefixedName
    /// <summary>
    ///   <para>vgo:GameEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:GameEvent describes an event that takes place in a game without straight player interaction. GameEvents are often very specific for each game. Examples of vgo:GameEvent could be an enemy dying, connecting to a multiplayer server, loading a new level or playing an animation."</para>
    /// labels<para>"game event"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#GameEvent">http://purl.org/net/VideoGameOntology#GameEvent</seealso>
    let GameEvent = Prefixed_Name(vgo, "GameEvent") |> PrefixedName
    /// <summary>
    ///   <para>vgo:GameProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vgo:GameProduct is anything that is for sale inside a game. These can be either normal game items purchased with in-game currency or with real world money. An example of vgo:GameProduct could be a consumable health potion bought with real money, a better weapon or some visual improvement (e.g. Hats in Steam). Basically a game product can be anything, a character, an item or an achievement.
    /// GameProduct is a subclass of Good Relations: ProductOrService &amp; schema:Product. Since vgo:GameProduct is a type of buyable product, it reuses the properties available in the schema and Good Relations, such as currency price, validity of the offer and so on."</para>
    /// labels<para>"game product"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#GameProduct">http://purl.org/net/VideoGameOntology#GameProduct</seealso>
    let GameProduct = Prefixed_Name(vgo, "GameProduct") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Genre class describes the genre a game belongs to. All of the games have at least one genre. Examples of this are RPG, Simulator and Adventure"</para>
    /// labels<para>"Genre"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Genre">http://purl.org/net/VideoGameOntology#Genre</seealso>
    let Genre = Prefixed_Name(vgo, "Genre") |> PrefixedName
    /// <summary>
    ///   <para>vgo:HardMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:HardMode achievement describes succeeding in a game on a high difficulty level. An example could be completing the “Doom” game on Nightmare difficulty level."</para>
    /// labels<para>"hard mode"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#HardMode">http://purl.org/net/VideoGameOntology#HardMode</seealso>
    let HardMode = Prefixed_Name(vgo, "HardMode") |> PrefixedName
    /// <summary>
    ///   <para>vgo:InAppPurchaseEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:InAppPurchaseEvent describes an event that is related to making a purchase with real money inside a game. This is a subclass of InstantaneousEvent because it happens at certain moment in time. An example of vgo:InAppPurchaseEvent would be unlocking secret levels with real money or purchasing better equipment with real money."</para>
    /// labels<para>"in-app purchase event"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#InAppPurchaseEvent">http://purl.org/net/VideoGameOntology#InAppPurchaseEvent</seealso>
    let InAppPurchaseEvent = Prefixed_Name(vgo, "InAppPurchaseEvent") |> PrefixedName
    /// <summary>
    ///   <para>vgo:InstantaneousEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:InstantaneousEvent class describes an event that happens during the gameplay at a certain moment in time. This can be a player gaining an achievement, killing an enemy or making an in-app purchase."</para>
    /// labels<para>"instantaneous event"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#InstantaneousEvent">http://purl.org/net/VideoGameOntology#InstantaneousEvent</seealso>
    let InstantaneousEvent = Prefixed_Name(vgo, "InstantaneousEvent") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vgo:Item portrays any item that exists in a game. The item can either be just visual part of the game or a concrete usable item. As an example an item could be a drinkable potion, a magical sword or just a flower pot."</para>
    /// labels<para>"Item"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Item">http://purl.org/net/VideoGameOntology#Item</seealso>
    let Item = Prefixed_Name(vgo, "Item") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Leaderboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Leaderboard class describes a ranking system of the players. There can be multiple rankings in a game, for example, the kill-count ranking of Modern Warfare or the best time listing of Formula 1 game."</para>
    /// labels<para>"Leaderboard"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Leaderboard">http://purl.org/net/VideoGameOntology#Leaderboard</seealso>
    let Leaderboard = Prefixed_Name(vgo, "Leaderboard") |> PrefixedName
    /// <summary>
    ///   <para>vgo:LoseEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"vgo:LoseEvent describes an event that is related to character/player losing something in a game. This is a subclass of GameEvent as gaining something is related to a specific game. For example, a player can lose a character due to trade with another player. Another example would be a character losing item due to consuming it."</para>
    /// labels<para>"lose event"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#LoseEvent">http://purl.org/net/VideoGameOntology#LoseEvent</seealso>
    let LoseEvent = Prefixed_Name(vgo, "LoseEvent") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Loyalty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Loyalty achievement is used to give recognition to loyal players. For example, this could be an achievement received after subscribing to the game for a year."</para>
    /// labels<para>"Loyalty"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Loyalty">http://purl.org/net/VideoGameOntology#Loyalty</seealso>
    let Loyalty = Prefixed_Name(vgo, "Loyalty") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Luck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Lucky describes an achievement that is awarded to the player in a lucky situation. An example of vgo:Lucky achievement would be winning in a lottery or throwing “Yahtzee” without re-rolling the dice."</para>
    /// labels<para>"Luck"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Luck">http://purl.org/net/VideoGameOntology#Luck</seealso>
    let Luck = Prefixed_Name(vgo, "Luck") |> PrefixedName
    /// <summary>
    ///   <para>vgo:MenuEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:MenuEvent describes an event that is related to interacting with the ingame menu. An example of menu event is muting sounds, changing graphic settings, changing gameplay difficulty or remapping game controls."</para>
    /// labels<para>"menu event"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#MenuEvent">http://purl.org/net/VideoGameOntology#MenuEvent</seealso>
    let MenuEvent = Prefixed_Name(vgo, "MenuEvent") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Minigame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Minigame achievement describes success in mini-games that have been included in a certain game but are not vital for completing the game. An example could be to complete all the Pizza deliveries in GTA minigame or gaining over 100 dollars while playing poker in Red Dead Redemption."</para>
    /// labels<para>"Minigame"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Minigame">http://purl.org/net/VideoGameOntology#Minigame</seealso>
    let Minigame = Prefixed_Name(vgo, "Minigame") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Multiplayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Multiplayer achievement describes anything that can be awarded to one or multiple players due to their gameplay in multiplayer. For example, this could be winning 10 Team Fortress matches in a row with the same team or getting killed ten times in a row in Counter-Strike."</para>
    /// labels<para>"Multiplayer"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Multiplayer">http://purl.org/net/VideoGameOntology#Multiplayer</seealso>
    let Multiplayer = Prefixed_Name(vgo, "Multiplayer") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Paragon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Paragon is a rare achievement that is given only to limited number of players. An example of vgo:Paragon achievement could be the first player to finish a game under 10 hours or the first ten players to complete the game 100% through."</para>
    /// labels<para>"Paragon"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Paragon">http://purl.org/net/VideoGameOntology#Paragon</seealso>
    let Paragon = Prefixed_Name(vgo, "Paragon") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Player</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Player describes the entity playing the game. This can be either a human or a computer. vgo:Player class is used to keep a profile of a certain playing entity and to connect all the games, achievements and characters he/she has. The vgo:Player is a subclass of foaf:Person as it contains all relative information of a certain person."</para>
    /// labels<para>"Player"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Player">http://purl.org/net/VideoGameOntology#Player</seealso>
    let Player = Prefixed_Name(vgo, "Player") |> PrefixedName
    /// <summary>
    ///   <para>vgo:PlayerEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:PlayerEvent describes a vgo:InstantaneousEvent that is caused by the player. For example jumping in the game, throwing an item or pressing a joystick button."</para>
    /// labels<para>"player event"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#PlayerEvent">http://purl.org/net/VideoGameOntology#PlayerEvent</seealso>
    let PlayerEvent = Prefixed_Name(vgo, "PlayerEvent") |> PrefixedName
    /// <summary>
    ///   <para>vgo:PlayingArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:PlayingArea is the description of a place where the gameplay takes place. All of the games have some kind of area where they are played in. An example of playing areas could be football field in soccer game, a race track from a racing game or a star system of EVE Online."</para>
    /// labels<para>"playing area"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#PlayingArea">http://purl.org/net/VideoGameOntology#PlayingArea</seealso>
    let PlayingArea = Prefixed_Name(vgo, "PlayingArea") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Session</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Session class describes a session of gameplay. A session can be a single round of chess, a round of Counter-Strike, one half-time of soccer or one race of Formula 1. vgo:Session class can be used to store gameplay information, especially for analytical reasons."</para>
    /// labels<para>"Session"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Session">http://purl.org/net/VideoGameOntology#Session</seealso>
    let Session = Prefixed_Name(vgo, "Session") |> PrefixedName
    /// <summary>
    ///   <para>vgo:SpecialPlayStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:SpecialPlayStyle achievement is awarded to players after playing a game in special fashion. Often this is something harder than the regular play and requires more player experience to excel in it. An example of vgo:SpecialPlayStyle could be to complete a game without any violence or against a timer."</para>
    /// labels<para>"special play style"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#SpecialPlayStyle">http://purl.org/net/VideoGameOntology#SpecialPlayStyle</seealso>
    let SpecialPlayStyle = Prefixed_Name(vgo, "SpecialPlayStyle") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Tutorial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Tutorial achievement is  awarded to a player for trying out various features of the game. This is often related to learning how to play the game, how the controls work and how the game logic works. An example of vgo:Tutorial could be testing out newly gained special equipment or just playing through the in-game tutorial in the beginning."</para>
    /// labels<para>"Tutorial"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Tutorial">http://purl.org/net/VideoGameOntology#Tutorial</seealso>
    let Tutorial = Prefixed_Name(vgo, "Tutorial") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Veteran</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Veteran achievement is an award that is given for accumulating a lot of play hours or game actions. For example, vgo:Veteran could be playing thousand hours of World of Tanks or making 100 goals in ice hockey game."</para>
    /// labels<para>"Veteran"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Veteran">http://purl.org/net/VideoGameOntology#Veteran</seealso>
    let Veteran = Prefixed_Name(vgo, "Veteran") |> PrefixedName
    /// <summary>
    ///   <para>vgo:Virtuosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vgo:Virtuosity describes an achievement that is awarded for playing masterfully in the game. Examples of virtuous play could be finishing the game without saving at all, dying zero times or preventing an opposing team from scoring any goals in a soccer game."</para>
    /// labels<para>"Virtuosity"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#Virtuosity">http://purl.org/net/VideoGameOntology#Virtuosity</seealso>
    let Virtuosity = Prefixed_Name(vgo, "Virtuosity") |> PrefixedName
    /// <summary>
    ///   <para>vgo:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"endTime describes the ending moment in time of a single Session. endTime connects the session to a DateTime value which holds the moment when the session ended."</para>
    /// labels<para>"end time"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#endTime">http://purl.org/net/VideoGameOntology#endTime</seealso>
    let endTime = Prefixed_Name(vgo, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>vgo:eventName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"name connects InstantaneousEvent a text string. This allows the event to have a name to recognize it for."</para>
    /// labels<para>"event name"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#eventName">http://purl.org/net/VideoGameOntology#eventName</seealso>
    let eventName = Prefixed_Name(vgo, "eventName") |> PrefixedName
    /// <summary>
    ///   <para>vgo:eventTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"time describes the connection of InstantaneousEvent happening at a certain moment of time. time Conncets the event to a DateTime value that describes the moment when the event happened."</para>
    /// labels<para>"event time"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#eventTime">http://purl.org/net/VideoGameOntology#eventTime</seealso>
    let eventTime = Prefixed_Name(vgo, "eventTime") |> PrefixedName
    /// <summary>
    ///   <para>vgo:hasAchievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:hasAchievement property specifies that a game has a specific achievement. A game often contains more than one achievement that can be awarded to the players."</para>
    ///   <para>"optional"</para>
    /// labels<para>"has achievement"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#hasAchievement">http://purl.org/net/VideoGameOntology#hasAchievement</seealso>
    let hasAchievement = Prefixed_Name(vgo, "hasAchievement") |> PrefixedName
    /// <summary>
    ///   <para>vgo:hasCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"optional"</para>
    ///   <para>"The vgo:hasCharacter property specifies that a game has a specific character. A game can have more than one characters involved."</para>
    /// labels<para>"has character"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#hasCharacter">http://purl.org/net/VideoGameOntology#hasCharacter</seealso>
    let hasCharacter = Prefixed_Name(vgo, "hasCharacter") |> PrefixedName
    /// <summary>
    ///   <para>vgo:hasFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:hasFeature property indicates what is a vgo:Feature (or ability) of a particular vgo:Item. For example, a fire sword, a healing staff or boots of flight connects item to a feature it can have. An item with connection to potable feature would make the item potable."</para>
    /// labels<para>"has feature"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#hasFeature">http://purl.org/net/VideoGameOntology#hasFeature</seealso>
    let hasFeature = Prefixed_Name(vgo, "hasFeature") |> PrefixedName
    /// <summary>
    ///   <para>vgo:hasGameGenre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:hasGameGenre property specifies that a game belongs to a certain game genre. For example, Pong would be an arcade game and Mario a platformer."</para>
    /// labels<para>"has game genre"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#hasGameGenre">http://purl.org/net/VideoGameOntology#hasGameGenre</seealso>
    let hasGameGenre = Prefixed_Name(vgo, "hasGameGenre") |> PrefixedName
    /// <summary>
    ///   <para>vgo:hasItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"optional"</para>
    ///   <para>"The vgo:hasItem property specifies that a game has a specific item. A game often contains more than one items."</para>
    /// labels<para>"has item"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#hasItem">http://purl.org/net/VideoGameOntology#hasItem</seealso>
    let hasItem = Prefixed_Name(vgo, "hasItem") |> PrefixedName
    /// <summary>
    ///   <para>vgo:hasLeaderboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:hasLeaderboard specifies that a leaderboard belongs to a particular game. A game can have one or more leaderboards that keep track of ranking of the players. For example a leaderboard could be ranking of who has the most soccer game victories or who has the fastest lap in a Formula 1 game."</para>
    /// labels<para>"has leaderboard"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#hasLeaderboard">http://purl.org/net/VideoGameOntology#hasLeaderboard</seealso>
    let hasLeaderboard = Prefixed_Name(vgo, "hasLeaderboard") |> PrefixedName
    /// <summary>
    ///   <para>vgo:hasPlayingArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:hasPlayingArea property asserts a gaming area to a specific game. In every game, the gameplay takes place in some playing area."</para>
    /// labels<para>"has playing area"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#hasPlayingArea">http://purl.org/net/VideoGameOntology#hasPlayingArea</seealso>
    let hasPlayingArea = Prefixed_Name(vgo, "hasPlayingArea") |> PrefixedName
    /// <summary>
    ///   <para>vgo:involvesAchievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:involvesPlayer property specifies that a session involves a specific player. A session may involve more than one player."</para>
    ///   <para>"optional"</para>
    /// labels<para>"involves achievement"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#involvesAchievement">http://purl.org/net/VideoGameOntology#involvesAchievement</seealso>
    let involvesAchievement = Prefixed_Name(vgo, "involvesAchievement") |> PrefixedName
    /// <summary>
    ///   <para>vgo:involvesCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"optional"</para>
    ///   <para>"The vgo:involvesCharacter property specifies that a session involves a specific character."</para>
    /// labels<para>"involves character"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#involvesCharacter">http://purl.org/net/VideoGameOntology#involvesCharacter</seealso>
    let involvesCharacter = Prefixed_Name(vgo, "involvesCharacter") |> PrefixedName
    /// <summary>
    ///   <para>vgo:involvesPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"optional"</para>
    ///   <para>"The vgo:involvesPlayer property specifies that a session involves a specific player. A session may involve more than one player."</para>
    /// labels<para>"involves player"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#involvesPlayer">http://purl.org/net/VideoGameOntology#involvesPlayer</seealso>
    let involvesPlayer = Prefixed_Name(vgo, "involvesPlayer") |> PrefixedName
    /// <summary>
    ///   <para>vgo:isAchievedInSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property vgo:isAchievedInSession asserts the receiving of an achievement to a certain gameplay session. This enables to keep track of what achievements a player has gained during one gameplay session."</para>
    /// labels<para>"is achieved in session"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isAchievedInSession">http://purl.org/net/VideoGameOntology#isAchievedInSession</seealso>
    let isAchievedInSession = Prefixed_Name(vgo, "isAchievedInSession") |> PrefixedName
    /// <summary>
    ///   <para>vgo:isAchievementInGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property vgo:isAchievementInGame asserts that a specific vgo:Achievement can be earned in a particular vgo:Game. An achievement must belong to a certain game."</para>
    /// labels<para>"is achievement in game"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isAchievementInGame">http://purl.org/net/VideoGameOntology#isAchievementInGame</seealso>
    let isAchievementInGame = Prefixed_Name(vgo, "isAchievementInGame") |> PrefixedName
    /// <summary>
    ///   <para>vgo:isCharacterInGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"vgo:isCharacterInGame property describes the relation between a vgo:Character and a vgo:Game. a vgo:Character always belongs to a certain game."</para>
    /// labels<para>"is character in game"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isCharacterInGame">http://purl.org/net/VideoGameOntology#isCharacterInGame</seealso>
    let isCharacterInGame = Prefixed_Name(vgo, "isCharacterInGame") |> PrefixedName

    /// <summary>
    ///   <para>vgo:isCharacterInSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:isCharacterInSession property connects the vgo:Character to a vgo:Session. A character participates in a game session (e.g., a football match or a counter strike round) during a period of time. As players can have multiple characters, a character needs to be connected to the session, in order to know which of those characters participated in the certain session."</para>
    /// labels<para>"is character in session"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isCharacterInSession">http://purl.org/net/VideoGameOntology#isCharacterInSession</seealso>
    let isCharacterInSession =
        Prefixed_Name(vgo, "isCharacterInSession") |> PrefixedName

    /// <summary>
    ///   <para>vgo:isEventAssociatedToPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:isEventAssociatedToPlayer property asserts an event to a specific vgo:Player. A player may have caused an event to happen through the actions of his/her character and this property is used to connect the real person to the event."</para>
    /// labels<para>"is event associated to player"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isEventAssociatedToPlayer">http://purl.org/net/VideoGameOntology#isEventAssociatedToPlayer</seealso>
    let isEventAssociatedToPlayer =
        Prefixed_Name(vgo, "isEventAssociatedToPlayer") |> PrefixedName

    /// <summary>
    ///   <para>vgo:isEventInGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:isEventInGame property asserts an event to a specific game. An event always happens inside a specific a game."</para>
    /// labels<para>"is event in game"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isEventInGame">http://purl.org/net/VideoGameOntology#isEventInGame</seealso>
    let isEventInGame = Prefixed_Name(vgo, "isEventInGame") |> PrefixedName
    /// <summary>
    ///   <para>vgo:isEventInSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:isEventInSession property links an event to a specific gameplay session. An event always happens during a certain session and this property enables to link the events to that session. For example, an event of moving the queen in game of chess should be connected to a session of chess."</para>
    /// labels<para>"is event in session"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isEventInSession">http://purl.org/net/VideoGameOntology#isEventInSession</seealso>
    let isEventInSession = Prefixed_Name(vgo, "isEventInSession") |> PrefixedName

    /// <summary>
    ///   <para>vgo:isEventRelatedToItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:isEventRelatedToItem property asserts an event to a specific item. This property is used to describe an event that includes an item in one way or another. For example, an event where character gains a new sword can be described with this relation."</para>
    /// labels<para>"is event related to item"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isEventRelatedToItem">http://purl.org/net/VideoGameOntology#isEventRelatedToItem</seealso>
    let isEventRelatedToItem =
        Prefixed_Name(vgo, "isEventRelatedToItem") |> PrefixedName

    /// <summary>
    ///   <para>vgo:isEventTriggeredByCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:isEventTriggeredByCharacter connects the vgo:InstantaneousEvent to specific vgo:Character. This describes that an event is often caused by a character. The character in question can be either a character controlled by a player or a computer. For example, both player and non-player characters can trigger a character death event."</para>
    /// labels<para>"is event triggered by character"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isEventTriggeredByCharacter">http://purl.org/net/VideoGameOntology#isEventTriggeredByCharacter</seealso>
    let isEventTriggeredByCharacter =
        Prefixed_Name(vgo, "isEventTriggeredByCharacter") |> PrefixedName

    /// <summary>
    ///   <para>vgo:isFriendWithPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"The vgo:isFriendWithPlayer describes a connection between players. The property is used to model the friends a player has and with whom he might be playing games with. The friends of a player are not bound necessarily to particular game, but can be describe the friendly playing relationship in overall."</para>
    /// labels<para>"is friend with player"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isFriendWithPlayer">http://purl.org/net/VideoGameOntology#isFriendWithPlayer</seealso>
    let isFriendWithPlayer = Prefixed_Name(vgo, "isFriendWithPlayer") |> PrefixedName
    /// <summary>
    ///   <para>vgo:isItemInGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:isItemInGame is used to specify which item belongs to a particular game. An item cannot exist alone and thus should always be associated to a certain game."</para>
    /// labels<para>"is item in game"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isItemInGame">http://purl.org/net/VideoGameOntology#isItemInGame</seealso>
    let isItemInGame = Prefixed_Name(vgo, "isItemInGame") |> PrefixedName
    /// <summary>
    ///   <para>vgo:isLeaderboardInGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"optional"</para>
    ///   <para>"The vgo:isLeaderboardInGame property specifies that a leaderboard is from a specific game."</para>
    /// labels<para>"is leaderboard in game"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isLeaderboardInGame">http://purl.org/net/VideoGameOntology#isLeaderboardInGame</seealso>
    let isLeaderboardInGame = Prefixed_Name(vgo, "isLeaderboardInGame") |> PrefixedName
    /// <summary>
    ///   <para>vgo:isPlayerInSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:isPlayerInSession property connects vgo:Player to a specific vgo:Session. This property is used to keep track of the gameplay sessions the player has played and what has happened in those sessions. For example vgo:Player may have participated in a this can be a one round of Counter-Strike or played one hour session of mario."</para>
    /// labels<para>"is player in session"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isPlayerInSession">http://purl.org/net/VideoGameOntology#isPlayerInSession</seealso>
    let isPlayerInSession = Prefixed_Name(vgo, "isPlayerInSession") |> PrefixedName
    /// <summary>
    ///   <para>vgo:isSessionInGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:isSessionInGame property links a vgo:Session to a certain vgo:Game. Each gameplay session must belong to a certain game."</para>
    /// labels<para>"is session in game"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#isSessionInGame">http://purl.org/net/VideoGameOntology#isSessionInGame</seealso>
    let isSessionInGame = Prefixed_Name(vgo, "isSessionInGame") |> PrefixedName
    /// <summary>
    ///   <para>vgo:livesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:livesIn describes the connection between a player and his place of existence in the real-world. A vgo:Player is connected to wgs84:SpatialThing as that has descriptions for places where people live and contains more detailed information of them, such as continents and regions."</para>
    /// labels<para>"lives in"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#livesIn">http://purl.org/net/VideoGameOntology#livesIn</seealso>
    let livesIn = Prefixed_Name(vgo, "livesIn") |> PrefixedName
    /// <summary>
    ///   <para>vgo:ownsAchievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:ownsAchievement links the vgo:Player to the particular vgo:Achievement earned in a game."</para>
    /// labels<para>"owns achievement"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#ownsAchievement">http://purl.org/net/VideoGameOntology#ownsAchievement</seealso>
    let ownsAchievement = Prefixed_Name(vgo, "ownsAchievement") |> PrefixedName
    /// <summary>
    ///   <para>vgo:ownsCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:ownsCharacter property asserts which characters are owned by a specific player. A player can have multiple characters in one game and this connection is used to define all the different characters a player could be playing. Even though a player deletes, trades or loses his/her character in any way, the connection can be kept to contain the player’s history of owned characters."</para>
    /// labels<para>"owns character"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#ownsCharacter">http://purl.org/net/VideoGameOntology#ownsCharacter</seealso>
    let ownsCharacter = Prefixed_Name(vgo, "ownsCharacter") |> PrefixedName
    /// <summary>
    ///   <para>vgo:ownsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:ownsItem describes ownership of an item. A vgo:Item is always owned by a certain vgo:Character. A vgo:Character can own multiple vgo:Items and this relationship is used to keep track of the character’s owned items. Even though players may lose items, the vgo:ownsItem connection is still held with the item. This approach allows to keep track of character’s history of owned items."</para>
    /// labels<para>"owns item"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#ownsItem">http://purl.org/net/VideoGameOntology#ownsItem</seealso>
    let ownsItem = Prefixed_Name(vgo, "ownsItem") |> PrefixedName
    /// <summary>
    ///   <para>vgo:playsGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the vgo:playsGame property asserts which games has the vgo:Player played at any point of time."</para>
    /// labels<para>"plays game"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#playsGame">http://purl.org/net/VideoGameOntology#playsGame</seealso>
    let playsGame = Prefixed_Name(vgo, "playsGame") |> PrefixedName

    /// <summary>
    ///   <para>vgo:purchasesGameOffering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:purchasesGameOffering property aseerts a vgo:InAppPurchaseEvent to a specific vgo:GameProduct. This property describes what is purchased by the in-app purchase event that the player has done."</para>
    /// labels<para>"purchases game offering"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#purchasesGameOffering">http://purl.org/net/VideoGameOntology#purchasesGameOffering</seealso>
    let purchasesGameOffering =
        Prefixed_Name(vgo, "purchasesGameOffering") |> PrefixedName

    /// <summary>
    ///   <para>vgo:releaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"releaseDate connects a game to a time which describes the release date of the game."</para>
    /// labels<para>"release date"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#releaseDate">http://purl.org/net/VideoGameOntology#releaseDate</seealso>
    let releaseDate = Prefixed_Name(vgo, "releaseDate") |> PrefixedName
    /// <summary>
    ///   <para>vgo:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"startTime describes the starting moment in time of a single Session. startTime connects the session to a DateTime value which holds the moment when the session started."</para>
    /// labels<para>"start time"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#startTime">http://purl.org/net/VideoGameOntology#startTime</seealso>
    let startTime = Prefixed_Name(vgo, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>vgo:unlocksAchievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vgo:unlocksAchievement property asserts an event to a certain achievement. An achievement is always unlocked as a consequence of some event. For example, eating the 100th piece of cake unlocks the “Cake Eater” achievement."</para>
    /// labels<para>"unlocks achievement"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#unlocksAchievement">http://purl.org/net/VideoGameOntology#unlocksAchievement</seealso>
    let unlocksAchievement = Prefixed_Name(vgo, "unlocksAchievement") |> PrefixedName
    /// <summary>
    ///   <para>vgo:username</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The username connects player to a text string which describes the username a player has."</para>
    /// labels<para>"username"</para></remarks>
    /// <seealso href="http://purl.org/net/VideoGameOntology#username">http://purl.org/net/VideoGameOntology#username</seealso>
    let username = Prefixed_Name(vgo, "username") |> PrefixedName
