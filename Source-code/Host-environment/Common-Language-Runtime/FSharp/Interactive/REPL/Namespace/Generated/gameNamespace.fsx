#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module game =
    let _prefixId = PrefixId.fromNamespaceLabel "http://data.totl.net/game/" "game"
    /// <summary>
    ///   <para>rdfs:comment : A Game type, such as go or chess.^^xsd:string</para>
    ///   <para>rdfs:label : Game^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/Game">game:Game</a>
    /// </summary>
    let Game = _prefixId.prefix "Game"
    /// <summary>
    ///   <para>rdfs:comment : A location in a game, such as a square or the players hand.^^xsd:string</para>
    ///   <para>rdfs:label : Game Location^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/Location">game:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:comment : The state of a location on a specific game state.^^xsd:string</para>
    ///   <para>rdfs:label : Location State^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/LocationState">game:LocationState</a>
    /// </summary>
    let LocationState = _prefixId.prefix "LocationState"
    /// <summary>
    ///   <para>rdfs:comment : An action which creates a new game state.^^xsd:string</para>
    ///   <para>rdfs:label : Move^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/Move">game:Move</a>
    /// </summary>
    let Move = _prefixId.prefix "Move"
    let Nothing = _prefixId.prefix "Nothing"
    /// <summary>
    ///   <para>rdfs:comment : A number of pieces of the same type. In games where money (fake or real) is used, then it should be treated as one piece per dollar (or the currency it works in). One piece per cent if subdivisions are possible.^^xsd:string</para>
    ///   <para>rdfs:label : Pieces count^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/PieceCount">game:PieceCount</a>
    /// </summary>
    let PieceCount = _prefixId.prefix "PieceCount"
    /// <summary>
    ///   <para>rdfs:comment : A distinct type of piece. Interchangable with any other piece of the same type.^^xsd:string</para>
    ///   <para>rdfs:label : Type of Piece^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/PieceType">game:PieceType</a>
    /// </summary>
    let PieceType = _prefixId.prefix "PieceType"
    /// <summary>
    ///   <para>rdfs:comment : Don't use piecetype and piececount interchangeably. If a location MAY contain multiple pieces of the same type, it should always use piececount.^^xsd:string</para>
    ///   <para>rdfs:label : Pieces^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/Pieces">game:Pieces</a>
    /// </summary>
    let Pieces = _prefixId.prefix "Pieces"
    /// <summary>
    ///   <para>rdfs:comment : A player in a game. Only indicates an abstract side for the type of game, not a specific player in a single game.^^xsd:string</para>
    ///   <para>rdfs:label : Player^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/Player">game:Player</a>
    /// </summary>
    let Player = _prefixId.prefix "Player"
    /// <summary>
    ///   <para>rdfs:comment : The state of a game.^^xsd:string</para>
    ///   <para>rdfs:label : Game State^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/State">game:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:comment : A status of a game.^^xsd:string</para>
    ///   <para>rdfs:label : Game Status^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/Status">game:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:comment : A symbol in ASCII to represent this type of piece.^^xsd:string</para>
    ///   <para>rdfs:label : ASCII Symbol^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/asciiSymbol">game:asciiSymbol</a>
    /// </summary>
    let asciiSymbol = _prefixId.prefix "asciiSymbol"
    /// <summary>
    ///   <para>rdfs:comment : The player this type of piece belongs to.^^xsd:string</para>
    ///   <para>rdfs:label : piece belongs to^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/belongsTo">game:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>rdfs:comment : The pieces captured in a move.^^xsd:string</para>
    ///   <para>rdfs:label : pieces captured^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/captures">game:captures</a>
    /// </summary>
    let captures = _prefixId.prefix "captures"
    /// <summary>
    ///   <para>rdfs:comment : A location which is captured by the player making the move. For example in reversi all pieces which change to their colour.^^xsd:string</para>
    ///   <para>rdfs:label : move captures location^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/capturesLocation">game:capturesLocation</a>
    /// </summary>
    let capturesLocation = _prefixId.prefix "capturesLocation"
    /// <summary>
    ///   <para>rdfs:comment : The piece(s) in a location of a location state, or nothing.^^xsd:string</para>
    ///   <para>rdfs:label : contains^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/contains">game:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:comment : The pieces converted to the players own side, in a move.^^xsd:string</para>
    ///   <para>rdfs:label : pieces converted^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/converts">game:converts</a>
    /// </summary>
    let converts = _prefixId.prefix "converts"
    /// <summary>
    ///   <para>rdfs:comment : The number of pieces, of the given type, in a piece count.^^xsd:string</para>
    ///   <para>rdfs:label : piece count^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/count">game:count</a>
    /// </summary>
    let count = _prefixId.prefix "count"
    let drawn = _prefixId.prefix "drawn"
    /// <summary>
    ///   <para>rdfs:comment : The initial state of the game^^xsd:string</para>
    ///   <para>rdfs:label : initial state^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/initialState">game:initialState</a>
    /// </summary>
    let initialState = _prefixId.prefix "initialState"
    /// <summary>
    ///   <para>rdfs:comment : A possible move given the current game state.^^xsd:string</para>
    ///   <para>rdfs:label : legal move^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/legalMove">game:legalMove</a>
    /// </summary>
    let legalMove = _prefixId.prefix "legalMove"
    /// <summary>
    ///   <para>rdfs:comment : The player making a move.^^xsd:string</para>
    ///   <para>rdfs:label : made by^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/madeBy">game:madeBy</a>
    /// </summary>
    let madeBy = _prefixId.prefix "madeBy"
    /// <summary>
    ///   <para>rdfs:comment : A location involved in the end of the move.^^xsd:string</para>
    ///   <para>rdfs:label : move end location^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/moveEndLocation">game:moveEndLocation</a>
    /// </summary>
    let moveEndLocation = _prefixId.prefix "moveEndLocation"
    /// <summary>
    ///   <para>rdfs:comment : A location involved in the move.^^xsd:string</para>
    ///   <para>rdfs:label : move location^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/moveLocation">game:moveLocation</a>
    /// </summary>
    let moveLocation = _prefixId.prefix "moveLocation"
    /// <summary>
    ///   <para>rdfs:comment : A location involved in the start of the move.^^xsd:string</para>
    ///   <para>rdfs:label : move start location^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/moveStartLocation">game:moveStartLocation</a>
    /// </summary>
    let moveStartLocation = _prefixId.prefix "moveStartLocation"
    /// <summary>
    ///   <para>rdfs:comment : The new state created by a move.^^xsd:string</para>
    ///   <para>rdfs:label : produces new state^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/newState">game:newState</a>
    /// </summary>
    let newState = _prefixId.prefix "newState"
    let nothing = _prefixId.prefix "nothing"
    /// <summary>
    ///   <para>rdfs:comment : The type of game of which this is a single state.^^xsd:string</para>
    ///   <para>rdfs:label : of game^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/ofGame">game:ofGame</a>
    /// </summary>
    let ofGame = _prefixId.prefix "ofGame"
    /// <summary>
    ///   <para>rdfs:comment : The location of something such as a move or a location state.^^xsd:string</para>
    ///   <para>rdfs:label : of location^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/ofLocation">game:ofLocation</a>
    /// </summary>
    let ofLocation = _prefixId.prefix "ofLocation"
    let ongoing = _prefixId.prefix "ongoing"
    /// <summary>
    ///   <para>rdfs:comment : The pieces removed completel from play in a move.^^xsd:string</para>
    ///   <para>rdfs:label : pieces removed^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/removes">game:removes</a>
    /// </summary>
    let removes = _prefixId.prefix "removes"
    /// <summary>
    ///   <para>rdfs:comment : The status of a given game state, win, ongoing or draw. Games may introduce additional statuses.^^xsd:string</para>
    ///   <para>rdfs:label : game status^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/status">game:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:comment : The pieces taken in a move and removed from play.^^xsd:string</para>
    ///   <para>rdfs:label : pieces taken^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/takes">game:takes</a>
    /// </summary>
    let takes = _prefixId.prefix "takes"
    /// <summary>
    ///   <para>rdfs:comment : The player who's turn it is in a given state.^^xsd:string</para>
    ///   <para>rdfs:label : player turn^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/turn">game:turn</a>
    /// </summary>
    let turn = _prefixId.prefix "turn"
    /// <summary>
    ///   <para>rdfs:comment : The type of piece in a piece count.^^xsd:string</para>
    ///   <para>rdfs:label : piece type^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/type">game:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:comment : A symbol in Unicode to represent this type of piece.^^xsd:string</para>
    ///   <para>rdfs:label : Unicode Symbol^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/unicodeSymbol">game:unicodeSymbol</a>
    /// </summary>
    let unicodeSymbol = _prefixId.prefix "unicodeSymbol"
    /// <summary>
    ///   <para>rdfs:comment : The player who has won.^^xsd:string</para>
    ///   <para>rdfs:label : game won by^^xsd:string</para>
    ///   <a href="http://data.totl.net/game/winner">game:winner</a>
    /// </summary>
    let winner = _prefixId.prefix "winner"
    let won = _prefixId.prefix "won"
