namespace http.purl.org.net.VideoGameOntology.hash

open DoxAletheia.Rdf_Vocabulary

module vgo =
    let _namespace_name = "http://purl.org/net/VideoGameOntology#"
    /// <summary>
    /// The vgo:Game class describes a game product that can be played by a player.
    /// Examples of games are Pong, Grand Theft Auto, Pokemon and Need for Speed.
    /// <see href="http://purl.org/net/VideoGameOntology#Game"></see></summary>
    let Game = Namespaced_IRI.parse _namespace_name "Game" |> NamespacedName

    /// <summary>
    /// The vgo:Achievement is a reward gained in a game due to some event accomplished in the game. Achievements are commonly used in game industry to reward players for having accomplished tasks in the game.
    /// This ontology defines various subclasses of vgo:Achievement, which are all based on the classification presented by Markus Montola et al. [Markus Montola, Timo Nummenmaa, Andrés Lucero, Marion Boberg, and Hannu Korhonen, 2009, “Applying game achievement systems to enhance user experience in a photo sharing service”, In Proceedings of the 13th International MindTrek Conference: Everyday Life in the Ubiquitous Era (MindTrek '09)] http://dl.acm.org/citation.cfm?id=1621859
    /// <see href="http://purl.org/net/VideoGameOntology#Achievement"></see></summary>
    let Achievement =
        Namespaced_IRI.parse _namespace_name "Achievement" |> NamespacedName

    /// <summary>
    /// A vgo:Character is any actor that can exists in a game. A character  can be a human-like creature as seen traditionally in video games. However, a character could also be a car, a paddle in game of Pong or spaceship of a space shooter game. This is often contextually related to the gameplay of a certain game. A character can be either controller by a player or by a computer.
    /// <see href="http://purl.org/net/VideoGameOntology#Character"></see></summary>
    let Character = Namespaced_IRI.parse _namespace_name "Character" |> NamespacedName
    /// <summary>
    /// The vgo:Collection type of achievement is typically rewarded from collecting an amount of certain items in a game. An example of vgo:Collection would be obtaining a full set of christmas clothes for a character to wear or collecting every possible flower in the game.
    /// <see href="http://purl.org/net/VideoGameOntology#Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// The vgo:Completion type of achievement is usually rewarded from successfully completing a certain goal or subgoal in a game. An example of vgo:Completion would be to save a princess from a burning tower or completing all side-quests in a game.
    /// <see href="http://purl.org/net/VideoGameOntology#Completion"></see></summary>
    let Completion = Namespaced_IRI.parse _namespace_name "Completion" |> NamespacedName
    /// <summary>
    /// The vgo:Curiosity describes funny random things that can happen or be found in the game. An example could be jumping from the Eiffel tower without dying or following a comupter controlled character’s activities for one hour.
    /// <see href="http://purl.org/net/VideoGameOntology#Curiosity"></see></summary>
    let Curiosity = Namespaced_IRI.parse _namespace_name "Curiosity" |> NamespacedName
    /// <summary>
    /// The vgo:Fandom achievement is related to doing some true fan activities. An example of vgo:Fandom could be purchasing a collectors edition of the game or attending a fan gathering.
    /// <see href="http://purl.org/net/VideoGameOntology#Fandom"></see></summary>
    let Fandom = Namespaced_IRI.parse _namespace_name "Fandom" |> NamespacedName
    /// <summary>
    /// vgo:Feature describes an ability or characteristic. For example, a sword could have “damage dealing” ability and a bottle of water could be “potable”.
    /// <see href="http://purl.org/net/VideoGameOntology#Feature"></see></summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName
    /// <summary>
    /// The vgo:GainEvent describes an event that is related to character/player gaining something in a game. This is a subclass of vgo:GameEvent as gaining something is related to a specific game. For example, a player can gain a new character, achievement or item.
    /// <see href="http://purl.org/net/VideoGameOntology#GainEvent"></see></summary>
    let GainEvent = Namespaced_IRI.parse _namespace_name "GainEvent" |> NamespacedName
    /// <summary>
    /// The vgo:GameEvent describes an event that takes place in a game without straight player interaction. GameEvents are often very specific for each game. Examples of vgo:GameEvent could be an enemy dying, connecting to a multiplayer server, loading a new level or playing an animation.
    /// <see href="http://purl.org/net/VideoGameOntology#GameEvent"></see></summary>
    let GameEvent = Namespaced_IRI.parse _namespace_name "GameEvent" |> NamespacedName

    /// <summary>
    /// The vgo:InstantaneousEvent class describes an event that happens during the gameplay at a certain moment in time. This can be a player gaining an achievement, killing an enemy or making an in-app purchase.
    /// <see href="http://purl.org/net/VideoGameOntology#InstantaneousEvent"></see></summary>
    let InstantaneousEvent =
        Namespaced_IRI.parse _namespace_name "InstantaneousEvent" |> NamespacedName

    /// <summary>
    /// A vgo:GameProduct is anything that is for sale inside a game. These can be either normal game items purchased with in-game currency or with real world money. An example of vgo:GameProduct could be a consumable health potion bought with real money, a better weapon or some visual improvement (e.g. Hats in Steam). Basically a game product can be anything, a character, an item or an achievement.
    /// GameProduct is a subclass of Good Relations: ProductOrService &amp; schema:Product. Since vgo:GameProduct is a type of buyable product, it reuses the properties available in the schema and Good Relations, such as currency price, validity of the offer and so on.
    /// <see href="http://purl.org/net/VideoGameOntology#GameProduct"></see></summary>
    let GameProduct =
        Namespaced_IRI.parse _namespace_name "GameProduct" |> NamespacedName

    /// <summary>
    /// A vgo:Item portrays any item that exists in a game. The item can either be just visual part of the game or a concrete usable item. As an example an item could be a drinkable potion, a magical sword or just a flower pot.
    /// <see href="http://purl.org/net/VideoGameOntology#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName

    /// <summary>
    /// The vgo:PlayingArea is the description of a place where the gameplay takes place. All of the games have some kind of area where they are played in. An example of playing areas could be football field in soccer game, a race track from a racing game or a star system of EVE Online.
    /// <see href="http://purl.org/net/VideoGameOntology#PlayingArea"></see></summary>
    let PlayingArea =
        Namespaced_IRI.parse _namespace_name "PlayingArea" |> NamespacedName

    /// <summary>
    /// The vgo:Genre class describes the genre a game belongs to. All of the games have at least one genre. Examples of this are RPG, Simulator and Adventure
    /// <see href="http://purl.org/net/VideoGameOntology#Genre"></see></summary>
    let Genre = Namespaced_IRI.parse _namespace_name "Genre" |> NamespacedName
    /// <summary>
    /// The vgo:HardMode achievement describes succeeding in a game on a high difficulty level. An example could be completing the “Doom” game on Nightmare difficulty level.
    /// <see href="http://purl.org/net/VideoGameOntology#HardMode"></see></summary>
    let HardMode = Namespaced_IRI.parse _namespace_name "HardMode" |> NamespacedName

    /// <summary>
    /// The vgo:InAppPurchaseEvent describes an event that is related to making a purchase with real money inside a game. This is a subclass of InstantaneousEvent because it happens at certain moment in time. An example of vgo:InAppPurchaseEvent would be unlocking secret levels with real money or purchasing better equipment with real money.
    /// <see href="http://purl.org/net/VideoGameOntology#InAppPurchaseEvent"></see></summary>
    let InAppPurchaseEvent =
        Namespaced_IRI.parse _namespace_name "InAppPurchaseEvent" |> NamespacedName

    /// <summary>
    /// The vgo:Leaderboard class describes a ranking system of the players. There can be multiple rankings in a game, for example, the kill-count ranking of Modern Warfare or the best time listing of Formula 1 game.
    /// <see href="http://purl.org/net/VideoGameOntology#Leaderboard"></see></summary>
    let Leaderboard =
        Namespaced_IRI.parse _namespace_name "Leaderboard" |> NamespacedName

    /// <summary>
    /// vgo:LoseEvent describes an event that is related to character/player losing something in a game. This is a subclass of GameEvent as gaining something is related to a specific game. For example, a player can lose a character due to trade with another player. Another example would be a character losing item due to consuming it.
    /// <see href="http://purl.org/net/VideoGameOntology#LoseEvent"></see></summary>
    let LoseEvent = Namespaced_IRI.parse _namespace_name "LoseEvent" |> NamespacedName
    /// <summary>
    /// The vgo:Loyalty achievement is used to give recognition to loyal players. For example, this could be an achievement received after subscribing to the game for a year.
    /// <see href="http://purl.org/net/VideoGameOntology#Loyalty"></see></summary>
    let Loyalty = Namespaced_IRI.parse _namespace_name "Loyalty" |> NamespacedName
    /// <summary>
    /// The vgo:Lucky describes an achievement that is awarded to the player in a lucky situation. An example of vgo:Lucky achievement would be winning in a lottery or throwing “Yahtzee” without re-rolling the dice.
    /// <see href="http://purl.org/net/VideoGameOntology#Luck"></see></summary>
    let Luck = Namespaced_IRI.parse _namespace_name "Luck" |> NamespacedName
    /// <summary>
    /// The vgo:MenuEvent describes an event that is related to interacting with the ingame menu. An example of menu event is muting sounds, changing graphic settings, changing gameplay difficulty or remapping game controls.
    /// <see href="http://purl.org/net/VideoGameOntology#MenuEvent"></see></summary>
    let MenuEvent = Namespaced_IRI.parse _namespace_name "MenuEvent" |> NamespacedName
    /// <summary>
    /// The vgo:Minigame achievement describes success in mini-games that have been included in a certain game but are not vital for completing the game. An example could be to complete all the Pizza deliveries in GTA minigame or gaining over 100 dollars while playing poker in Red Dead Redemption.
    /// <see href="http://purl.org/net/VideoGameOntology#Minigame"></see></summary>
    let Minigame = Namespaced_IRI.parse _namespace_name "Minigame" |> NamespacedName

    /// <summary>
    /// The vgo:Multiplayer achievement describes anything that can be awarded to one or multiple players due to their gameplay in multiplayer. For example, this could be winning 10 Team Fortress matches in a row with the same team or getting killed ten times in a row in Counter-Strike.
    /// <see href="http://purl.org/net/VideoGameOntology#Multiplayer"></see></summary>
    let Multiplayer =
        Namespaced_IRI.parse _namespace_name "Multiplayer" |> NamespacedName

    /// <summary>
    /// The vgo:Paragon is a rare achievement that is given only to limited number of players. An example of vgo:Paragon achievement could be the first player to finish a game under 10 hours or the first ten players to complete the game 100% through.
    /// <see href="http://purl.org/net/VideoGameOntology#Paragon"></see></summary>
    let Paragon = Namespaced_IRI.parse _namespace_name "Paragon" |> NamespacedName
    /// <summary>
    /// The vgo:Player describes the entity playing the game. This can be either a human or a computer. vgo:Player class is used to keep a profile of a certain playing entity and to connect all the games, achievements and characters he/she has. The vgo:Player is a subclass of foaf:Person as it contains all relative information of a certain person.
    /// <see href="http://purl.org/net/VideoGameOntology#Player"></see></summary>
    let Player = Namespaced_IRI.parse _namespace_name "Player" |> NamespacedName

    /// <summary>
    /// The vgo:PlayerEvent describes a vgo:InstantaneousEvent that is caused by the player. For example jumping in the game, throwing an item or pressing a joystick button.
    /// <see href="http://purl.org/net/VideoGameOntology#PlayerEvent"></see></summary>
    let PlayerEvent =
        Namespaced_IRI.parse _namespace_name "PlayerEvent" |> NamespacedName

    /// <summary>
    /// The vgo:Session class describes a session of gameplay. A session can be a single round of chess, a round of Counter-Strike, one half-time of soccer or one race of Formula 1. vgo:Session class can be used to store gameplay information, especially for analytical reasons.
    /// <see href="http://purl.org/net/VideoGameOntology#Session"></see></summary>
    let Session = Namespaced_IRI.parse _namespace_name "Session" |> NamespacedName

    /// <summary>
    /// The vgo:SpecialPlayStyle achievement is awarded to players after playing a game in special fashion. Often this is something harder than the regular play and requires more player experience to excel in it. An example of vgo:SpecialPlayStyle could be to complete a game without any violence or against a timer.
    /// <see href="http://purl.org/net/VideoGameOntology#SpecialPlayStyle"></see></summary>
    let SpecialPlayStyle =
        Namespaced_IRI.parse _namespace_name "SpecialPlayStyle" |> NamespacedName

    /// <summary>
    /// The vgo:Tutorial achievement is  awarded to a player for trying out various features of the game. This is often related to learning how to play the game, how the controls work and how the game logic works. An example of vgo:Tutorial could be testing out newly gained special equipment or just playing through the in-game tutorial in the beginning.
    /// <see href="http://purl.org/net/VideoGameOntology#Tutorial"></see></summary>
    let Tutorial = Namespaced_IRI.parse _namespace_name "Tutorial" |> NamespacedName
    /// <summary>
    /// The vgo:Veteran achievement is an award that is given for accumulating a lot of play hours or game actions. For example, vgo:Veteran could be playing thousand hours of World of Tanks or making 100 goals in ice hockey game.
    /// <see href="http://purl.org/net/VideoGameOntology#Veteran"></see></summary>
    let Veteran = Namespaced_IRI.parse _namespace_name "Veteran" |> NamespacedName
    /// <summary>
    /// The vgo:Virtuosity describes an achievement that is awarded for playing masterfully in the game. Examples of virtuous play could be finishing the game without saving at all, dying zero times or preventing an opposing team from scoring any goals in a soccer game.
    /// <see href="http://purl.org/net/VideoGameOntology#Virtuosity"></see></summary>
    let Virtuosity = Namespaced_IRI.parse _namespace_name "Virtuosity" |> NamespacedName
    /// <summary>
    /// endTime describes the ending moment in time of a single Session. endTime connects the session to a DateTime value which holds the moment when the session ended.
    /// <see href="http://purl.org/net/VideoGameOntology#endTime"></see></summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName
    /// <summary>
    /// name connects InstantaneousEvent a text string. This allows the event to have a name to recognize it for.
    /// <see href="http://purl.org/net/VideoGameOntology#eventName"></see></summary>
    let eventName = Namespaced_IRI.parse _namespace_name "eventName" |> NamespacedName
    /// <summary>
    /// time describes the connection of InstantaneousEvent happening at a certain moment of time. time Conncets the event to a DateTime value that describes the moment when the event happened.
    /// <see href="http://purl.org/net/VideoGameOntology#eventTime"></see></summary>
    let eventTime = Namespaced_IRI.parse _namespace_name "eventTime" |> NamespacedName

    /// <summary>
    /// The vgo:hasAchievement property specifies that a game has a specific achievement. A game often contains more than one achievement that can be awarded to the players.
    /// optional
    /// <see href="http://purl.org/net/VideoGameOntology#hasAchievement"></see></summary>
    let hasAchievement =
        Namespaced_IRI.parse _namespace_name "hasAchievement" |> NamespacedName

    /// <summary>
    /// The vgo:hasCharacter property specifies that a game has a specific character. A game can have more than one characters involved.
    /// optional
    /// <see href="http://purl.org/net/VideoGameOntology#hasCharacter"></see></summary>
    let hasCharacter =
        Namespaced_IRI.parse _namespace_name "hasCharacter" |> NamespacedName

    /// <summary>
    /// The vgo:hasFeature property indicates what is a vgo:Feature (or ability) of a particular vgo:Item. For example, a fire sword, a healing staff or boots of flight connects item to a feature it can have. An item with connection to potable feature would make the item potable.
    /// <see href="http://purl.org/net/VideoGameOntology#hasFeature"></see></summary>
    let hasFeature = Namespaced_IRI.parse _namespace_name "hasFeature" |> NamespacedName

    /// <summary>
    /// The vgo:hasGameGenre property specifies that a game belongs to a certain game genre. For example, Pong would be an arcade game and Mario a platformer.
    /// <see href="http://purl.org/net/VideoGameOntology#hasGameGenre"></see></summary>
    let hasGameGenre =
        Namespaced_IRI.parse _namespace_name "hasGameGenre" |> NamespacedName

    /// <summary>
    /// The vgo:hasItem property specifies that a game has a specific item. A game often contains more than one items.
    /// optional
    /// <see href="http://purl.org/net/VideoGameOntology#hasItem"></see></summary>
    let hasItem = Namespaced_IRI.parse _namespace_name "hasItem" |> NamespacedName

    /// <summary>
    /// The vgo:hasLeaderboard specifies that a leaderboard belongs to a particular game. A game can have one or more leaderboards that keep track of ranking of the players. For example a leaderboard could be ranking of who has the most soccer game victories or who has the fastest lap in a Formula 1 game.
    /// <see href="http://purl.org/net/VideoGameOntology#hasLeaderboard"></see></summary>
    let hasLeaderboard =
        Namespaced_IRI.parse _namespace_name "hasLeaderboard" |> NamespacedName

    /// <summary>
    /// The vgo:isLeaderboardInGame property specifies that a leaderboard is from a specific game.
    /// optional
    /// <see href="http://purl.org/net/VideoGameOntology#isLeaderboardInGame"></see></summary>
    let isLeaderboardInGame =
        Namespaced_IRI.parse _namespace_name "isLeaderboardInGame" |> NamespacedName

    /// <summary>
    /// The vgo:hasPlayingArea property asserts a gaming area to a specific game. In every game, the gameplay takes place in some playing area.
    /// <see href="http://purl.org/net/VideoGameOntology#hasPlayingArea"></see></summary>
    let hasPlayingArea =
        Namespaced_IRI.parse _namespace_name "hasPlayingArea" |> NamespacedName

    /// <summary>
    /// The vgo:involvesPlayer property specifies that a session involves a specific player. A session may involve more than one player.
    /// optional
    /// <see href="http://purl.org/net/VideoGameOntology#involvesAchievement"></see></summary>
    let involvesAchievement =
        Namespaced_IRI.parse _namespace_name "involvesAchievement" |> NamespacedName

    /// <summary>
    /// The vgo:involvesCharacter property specifies that a session involves a specific character.
    /// optional
    /// <see href="http://purl.org/net/VideoGameOntology#involvesCharacter"></see></summary>
    let involvesCharacter =
        Namespaced_IRI.parse _namespace_name "involvesCharacter" |> NamespacedName

    /// <summary>
    /// The vgo:involvesPlayer property specifies that a session involves a specific player. A session may involve more than one player.
    /// optional
    /// <see href="http://purl.org/net/VideoGameOntology#involvesPlayer"></see></summary>
    let involvesPlayer =
        Namespaced_IRI.parse _namespace_name "involvesPlayer" |> NamespacedName

    /// <summary>
    /// The property vgo:isAchievedInSession asserts the receiving of an achievement to a certain gameplay session. This enables to keep track of what achievements a player has gained during one gameplay session.
    /// <see href="http://purl.org/net/VideoGameOntology#isAchievedInSession"></see></summary>
    let isAchievedInSession =
        Namespaced_IRI.parse _namespace_name "isAchievedInSession" |> NamespacedName

    /// <summary>
    /// The property vgo:isAchievementInGame asserts that a specific vgo:Achievement can be earned in a particular vgo:Game. An achievement must belong to a certain game.
    /// <see href="http://purl.org/net/VideoGameOntology#isAchievementInGame"></see></summary>
    let isAchievementInGame =
        Namespaced_IRI.parse _namespace_name "isAchievementInGame" |> NamespacedName

    /// <summary>
    /// vgo:isCharacterInGame property describes the relation between a vgo:Character and a vgo:Game. a vgo:Character always belongs to a certain game.
    /// <see href="http://purl.org/net/VideoGameOntology#isCharacterInGame"></see></summary>
    let isCharacterInGame =
        Namespaced_IRI.parse _namespace_name "isCharacterInGame" |> NamespacedName

    /// <summary>
    /// The vgo:isCharacterInSession property connects the vgo:Character to a vgo:Session. A character participates in a game session (e.g., a football match or a counter strike round) during a period of time. As players can have multiple characters, a character needs to be connected to the session, in order to know which of those characters participated in the certain session.
    /// <see href="http://purl.org/net/VideoGameOntology#isCharacterInSession"></see></summary>
    let isCharacterInSession =
        Namespaced_IRI.parse _namespace_name "isCharacterInSession" |> NamespacedName

    /// <summary>
    /// The vgo:isEventAssociatedToPlayer property asserts an event to a specific vgo:Player. A player may have caused an event to happen through the actions of his/her character and this property is used to connect the real person to the event.
    /// <see href="http://purl.org/net/VideoGameOntology#isEventAssociatedToPlayer"></see></summary>
    let isEventAssociatedToPlayer =
        Namespaced_IRI.parse _namespace_name "isEventAssociatedToPlayer" |> NamespacedName

    /// <summary>
    /// The vgo:isEventInGame property asserts an event to a specific game. An event always happens inside a specific a game.
    /// <see href="http://purl.org/net/VideoGameOntology#isEventInGame"></see></summary>
    let isEventInGame =
        Namespaced_IRI.parse _namespace_name "isEventInGame" |> NamespacedName

    /// <summary>
    /// The vgo:isEventInSession property links an event to a specific gameplay session. An event always happens during a certain session and this property enables to link the events to that session. For example, an event of moving the queen in game of chess should be connected to a session of chess.
    /// <see href="http://purl.org/net/VideoGameOntology#isEventInSession"></see></summary>
    let isEventInSession =
        Namespaced_IRI.parse _namespace_name "isEventInSession" |> NamespacedName

    /// <summary>
    /// The vgo:isEventRelatedToItem property asserts an event to a specific item. This property is used to describe an event that includes an item in one way or another. For example, an event where character gains a new sword can be described with this relation.
    /// <see href="http://purl.org/net/VideoGameOntology#isEventRelatedToItem"></see></summary>
    let isEventRelatedToItem =
        Namespaced_IRI.parse _namespace_name "isEventRelatedToItem" |> NamespacedName

    /// <summary>
    /// The vgo:isEventTriggeredByCharacter connects the vgo:InstantaneousEvent to specific vgo:Character. This describes that an event is often caused by a character. The character in question can be either a character controlled by a player or a computer. For example, both player and non-player characters can trigger a character death event.
    /// <see href="http://purl.org/net/VideoGameOntology#isEventTriggeredByCharacter"></see></summary>
    let isEventTriggeredByCharacter =
        Namespaced_IRI.parse _namespace_name "isEventTriggeredByCharacter" |> NamespacedName

    /// <summary>
    /// The vgo:isFriendWithPlayer describes a connection between players. The property is used to model the friends a player has and with whom he might be playing games with. The friends of a player are not bound necessarily to particular game, but can be describe the friendly playing relationship in overall.
    /// <see href="http://purl.org/net/VideoGameOntology#isFriendWithPlayer"></see></summary>
    let isFriendWithPlayer =
        Namespaced_IRI.parse _namespace_name "isFriendWithPlayer" |> NamespacedName

    /// <summary>
    /// The vgo:isItemInGame is used to specify which item belongs to a particular game. An item cannot exist alone and thus should always be associated to a certain game.
    /// <see href="http://purl.org/net/VideoGameOntology#isItemInGame"></see></summary>
    let isItemInGame =
        Namespaced_IRI.parse _namespace_name "isItemInGame" |> NamespacedName

    /// <summary>
    /// The vgo:isPlayerInSession property connects vgo:Player to a specific vgo:Session. This property is used to keep track of the gameplay sessions the player has played and what has happened in those sessions. For example vgo:Player may have participated in a this can be a one round of Counter-Strike or played one hour session of mario.
    /// <see href="http://purl.org/net/VideoGameOntology#isPlayerInSession"></see></summary>
    let isPlayerInSession =
        Namespaced_IRI.parse _namespace_name "isPlayerInSession" |> NamespacedName

    /// <summary>
    /// The vgo:isSessionInGame property links a vgo:Session to a certain vgo:Game. Each gameplay session must belong to a certain game.
    /// <see href="http://purl.org/net/VideoGameOntology#isSessionInGame"></see></summary>
    let isSessionInGame =
        Namespaced_IRI.parse _namespace_name "isSessionInGame" |> NamespacedName

    /// <summary>
    /// The vgo:livesIn describes the connection between a player and his place of existence in the real-world. A vgo:Player is connected to wgs84:SpatialThing as that has descriptions for places where people live and contains more detailed information of them, such as continents and regions.
    /// <see href="http://purl.org/net/VideoGameOntology#livesIn"></see></summary>
    let livesIn = Namespaced_IRI.parse _namespace_name "livesIn" |> NamespacedName

    /// <summary>
    /// The vgo:ownsAchievement links the vgo:Player to the particular vgo:Achievement earned in a game.
    /// <see href="http://purl.org/net/VideoGameOntology#ownsAchievement"></see></summary>
    let ownsAchievement =
        Namespaced_IRI.parse _namespace_name "ownsAchievement" |> NamespacedName

    /// <summary>
    /// The vgo:ownsCharacter property asserts which characters are owned by a specific player. A player can have multiple characters in one game and this connection is used to define all the different characters a player could be playing. Even though a player deletes, trades or loses his/her character in any way, the connection can be kept to contain the player’s history of owned characters.
    /// <see href="http://purl.org/net/VideoGameOntology#ownsCharacter"></see></summary>
    let ownsCharacter =
        Namespaced_IRI.parse _namespace_name "ownsCharacter" |> NamespacedName

    /// <summary>
    /// The vgo:ownsItem describes ownership of an item. A vgo:Item is always owned by a certain vgo:Character. A vgo:Character can own multiple vgo:Items and this relationship is used to keep track of the character’s owned items. Even though players may lose items, the vgo:ownsItem connection is still held with the item. This approach allows to keep track of character’s history of owned items.
    /// <see href="http://purl.org/net/VideoGameOntology#ownsItem"></see></summary>
    let ownsItem = Namespaced_IRI.parse _namespace_name "ownsItem" |> NamespacedName
    /// <summary>
    /// the vgo:playsGame property asserts which games has the vgo:Player played at any point of time.
    /// <see href="http://purl.org/net/VideoGameOntology#playsGame"></see></summary>
    let playsGame = Namespaced_IRI.parse _namespace_name "playsGame" |> NamespacedName

    /// <summary>
    /// The vgo:purchasesGameOffering property aseerts a vgo:InAppPurchaseEvent to a specific vgo:GameProduct. This property describes what is purchased by the in-app purchase event that the player has done.
    /// <see href="http://purl.org/net/VideoGameOntology#purchasesGameOffering"></see></summary>
    let purchasesGameOffering =
        Namespaced_IRI.parse _namespace_name "purchasesGameOffering" |> NamespacedName

    /// <summary>
    /// releaseDate connects a game to a time which describes the release date of the game.
    /// <see href="http://purl.org/net/VideoGameOntology#releaseDate"></see></summary>
    let releaseDate =
        Namespaced_IRI.parse _namespace_name "releaseDate" |> NamespacedName

    /// <summary>
    /// startTime describes the starting moment in time of a single Session. startTime connects the session to a DateTime value which holds the moment when the session started.
    /// <see href="http://purl.org/net/VideoGameOntology#startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName

    /// <summary>
    /// The vgo:unlocksAchievement property asserts an event to a certain achievement. An achievement is always unlocked as a consequence of some event. For example, eating the 100th piece of cake unlocks the “Cake Eater” achievement.
    /// <see href="http://purl.org/net/VideoGameOntology#unlocksAchievement"></see></summary>
    let unlocksAchievement =
        Namespaced_IRI.parse _namespace_name "unlocksAchievement" |> NamespacedName

    /// <summary>
    /// The username connects player to a text string which describes the username a player has.
    /// <see href="http://purl.org/net/VideoGameOntology#username"></see></summary>
    let username = Namespaced_IRI.parse _namespace_name "username" |> NamespacedName
