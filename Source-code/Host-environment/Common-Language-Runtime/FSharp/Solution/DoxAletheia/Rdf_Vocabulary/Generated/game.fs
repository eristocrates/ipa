namespace http.data.totl.net.game.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module game =
    let _namespace_iri = Namespace_Iri game |> NamespaceIRI
    /// <summary>
    ///   <para>game:Game</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Game type, such as go or chess."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Game"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/Game">http://data.totl.net/game/Game</seealso>
    let Game = Prefixed_Name(game, "Game") |> PrefixedName
    /// <summary>
    ///   <para>game:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A location in a game, such as a square or the players hand."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Game Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/Location">http://data.totl.net/game/Location</seealso>
    let Location = Prefixed_Name(game, "Location") |> PrefixedName
    /// <summary>
    ///   <para>game:LocationState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The state of a location on a specific game state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/LocationState">http://data.totl.net/game/LocationState</seealso>
    let LocationState = Prefixed_Name(game, "LocationState") |> PrefixedName
    /// <summary>
    ///   <para>game:Move</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An action which creates a new game state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Move"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/Move">http://data.totl.net/game/Move</seealso>
    let Move = Prefixed_Name(game, "Move") |> PrefixedName
    /// <summary>
    ///   <para>game:Nothing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://data.totl.net/game/Nothing">http://data.totl.net/game/Nothing</seealso>
    let Nothing = Prefixed_Name(game, "Nothing") |> PrefixedName
    /// <summary>
    ///   <para>game:PieceCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A number of pieces of the same type. In games where money (fake or real) is used, then it should be treated as one piece per dollar (or the currency it works in). One piece per cent if subdivisions are possible."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pieces count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/PieceCount">http://data.totl.net/game/PieceCount</seealso>
    let PieceCount = Prefixed_Name(game, "PieceCount") |> PrefixedName
    /// <summary>
    ///   <para>game:PieceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A distinct type of piece. Interchangable with any other piece of the same type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Type of Piece"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/PieceType">http://data.totl.net/game/PieceType</seealso>
    let PieceType = Prefixed_Name(game, "PieceType") |> PrefixedName
    /// <summary>
    ///   <para>game:Pieces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Don't use piecetype and piececount interchangeably. If a location MAY contain multiple pieces of the same type, it should always use piececount."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pieces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/Pieces">http://data.totl.net/game/Pieces</seealso>
    let Pieces = Prefixed_Name(game, "Pieces") |> PrefixedName
    /// <summary>
    ///   <para>game:Player</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A player in a game. Only indicates an abstract side for the type of game, not a specific player in a single game."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/Player">http://data.totl.net/game/Player</seealso>
    let Player = Prefixed_Name(game, "Player") |> PrefixedName
    /// <summary>
    ///   <para>game:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The state of a game."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Game State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/State">http://data.totl.net/game/State</seealso>
    let State = Prefixed_Name(game, "State") |> PrefixedName
    /// <summary>
    ///   <para>game:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A status of a game."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Game Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/Status">http://data.totl.net/game/Status</seealso>
    let Status = Prefixed_Name(game, "Status") |> PrefixedName
    /// <summary>
    ///   <para>game:asciiSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A symbol in ASCII to represent this type of piece."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ASCII Symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/asciiSymbol">http://data.totl.net/game/asciiSymbol</seealso>
    let asciiSymbol = Prefixed_Name(game, "asciiSymbol") |> PrefixedName
    /// <summary>
    ///   <para>game:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The player this type of piece belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"piece belongs to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/belongsTo">http://data.totl.net/game/belongsTo</seealso>
    let belongsTo = Prefixed_Name(game, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>game:captures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The pieces captured in a move."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pieces captured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/captures">http://data.totl.net/game/captures</seealso>
    let captures = Prefixed_Name(game, "captures") |> PrefixedName
    /// <summary>
    ///   <para>game:capturesLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A location which is captured by the player making the move. For example in reversi all pieces which change to their colour."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"move captures location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/capturesLocation">http://data.totl.net/game/capturesLocation</seealso>
    let capturesLocation = Prefixed_Name(game, "capturesLocation") |> PrefixedName
    /// <summary>
    ///   <para>game:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The piece(s) in a location of a location state, or nothing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/contains">http://data.totl.net/game/contains</seealso>
    let contains = Prefixed_Name(game, "contains") |> PrefixedName
    /// <summary>
    ///   <para>game:converts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The pieces converted to the players own side, in a move."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pieces converted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/converts">http://data.totl.net/game/converts</seealso>
    let converts = Prefixed_Name(game, "converts") |> PrefixedName
    /// <summary>
    ///   <para>game:count</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The number of pieces, of the given type, in a piece count."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"piece count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/count">http://data.totl.net/game/count</seealso>
    let count = Prefixed_Name(game, "count") |> PrefixedName
    /// <summary>
    ///   <para>game:drawn</para>
    /// </summary>
    /// <remarks>
    ///   <para>game:Status</para>
    ///
    /// labels<para>"Drawn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/drawn">http://data.totl.net/game/drawn</seealso>
    let drawn = Prefixed_Name(game, "drawn") |> PrefixedName
    /// <summary>
    ///   <para>game:initialState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The initial state of the game"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"initial state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/initialState">http://data.totl.net/game/initialState</seealso>
    let initialState = Prefixed_Name(game, "initialState") |> PrefixedName
    /// <summary>
    ///   <para>game:legalMove</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A possible move given the current game state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"legal move"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/legalMove">http://data.totl.net/game/legalMove</seealso>
    let legalMove = Prefixed_Name(game, "legalMove") |> PrefixedName
    /// <summary>
    ///   <para>game:madeBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The player making a move."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"made by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/madeBy">http://data.totl.net/game/madeBy</seealso>
    let madeBy = Prefixed_Name(game, "madeBy") |> PrefixedName
    /// <summary>
    ///   <para>game:moveEndLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A location involved in the end of the move."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"move end location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/moveEndLocation">http://data.totl.net/game/moveEndLocation</seealso>
    let moveEndLocation = Prefixed_Name(game, "moveEndLocation") |> PrefixedName
    /// <summary>
    ///   <para>game:moveLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A location involved in the move."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"move location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/moveLocation">http://data.totl.net/game/moveLocation</seealso>
    let moveLocation = Prefixed_Name(game, "moveLocation") |> PrefixedName
    /// <summary>
    ///   <para>game:moveStartLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A location involved in the start of the move."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"move start location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/moveStartLocation">http://data.totl.net/game/moveStartLocation</seealso>
    let moveStartLocation = Prefixed_Name(game, "moveStartLocation") |> PrefixedName
    /// <summary>
    ///   <para>game:newState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The new state created by a move."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"produces new state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/newState">http://data.totl.net/game/newState</seealso>
    let newState = Prefixed_Name(game, "newState") |> PrefixedName
    /// <summary>
    ///   <para>game:nothing</para>
    /// </summary>
    /// <remarks>
    ///   <para>game:Nothing</para>
    ///   <para>"Indicates nothing is in a location."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nothing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/nothing">http://data.totl.net/game/nothing</seealso>
    let nothing = Prefixed_Name(game, "nothing") |> PrefixedName
    /// <summary>
    ///   <para>game:ofGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The type of game of which this is a single state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"of game"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/ofGame">http://data.totl.net/game/ofGame</seealso>
    let ofGame = Prefixed_Name(game, "ofGame") |> PrefixedName
    /// <summary>
    ///   <para>game:ofLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The location of something such as a move or a location state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"of location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/ofLocation">http://data.totl.net/game/ofLocation</seealso>
    let ofLocation = Prefixed_Name(game, "ofLocation") |> PrefixedName
    /// <summary>
    ///   <para>game:ongoing</para>
    /// </summary>
    /// <remarks>
    ///   <para>game:Status</para>
    ///
    /// labels<para>"Ongoing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/ongoing">http://data.totl.net/game/ongoing</seealso>
    let ongoing = Prefixed_Name(game, "ongoing") |> PrefixedName
    /// <summary>
    ///   <para>game:removes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The pieces removed completel from play in a move."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pieces removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/removes">http://data.totl.net/game/removes</seealso>
    let removes = Prefixed_Name(game, "removes") |> PrefixedName
    /// <summary>
    ///   <para>game:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The status of a given game state, win, ongoing or draw. Games may introduce additional statuses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"game status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/status">http://data.totl.net/game/status</seealso>
    let status = Prefixed_Name(game, "status") |> PrefixedName
    /// <summary>
    ///   <para>game:takes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The pieces taken in a move and removed from play."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pieces taken"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/takes">http://data.totl.net/game/takes</seealso>
    let takes = Prefixed_Name(game, "takes") |> PrefixedName
    /// <summary>
    ///   <para>game:turn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The player who's turn it is in a given state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"player turn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/turn">http://data.totl.net/game/turn</seealso>
    let turn = Prefixed_Name(game, "turn") |> PrefixedName
    /// <summary>
    ///   <para>game:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The type of piece in a piece count."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"piece type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/type">http://data.totl.net/game/type</seealso>
    let type_ = Prefixed_Name(game, "type") |> PrefixedName
    /// <summary>
    ///   <para>game:unicodeSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A symbol in Unicode to represent this type of piece."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unicode Symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/unicodeSymbol">http://data.totl.net/game/unicodeSymbol</seealso>
    let unicodeSymbol = Prefixed_Name(game, "unicodeSymbol") |> PrefixedName
    /// <summary>
    ///   <para>game:winner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The player who has won."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"game won by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/winner">http://data.totl.net/game/winner</seealso>
    let winner = Prefixed_Name(game, "winner") |> PrefixedName
    /// <summary>
    ///   <para>game:won</para>
    /// </summary>
    /// <remarks>
    ///   <para>game:Status</para>
    ///
    /// labels<para>"Won"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.totl.net/game/won">http://data.totl.net/game/won</seealso>
    let won = Prefixed_Name(game, "won") |> PrefixedName
