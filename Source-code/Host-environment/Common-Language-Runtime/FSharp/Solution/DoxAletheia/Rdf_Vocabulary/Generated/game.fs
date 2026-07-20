namespace http.data.totl.net.game.slash

open DoxAletheia

module game =
    let _namespace_name = "http://data.totl.net/game/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Game type, such as go or chess.
    /// <see href="http://data.totl.net/game/Game"></see></summary>
    let Game = _prefix "Game"
    /// <summary>
    /// A location in a game, such as a square or the players hand.
    /// <see href="http://data.totl.net/game/Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// The state of a location on a specific game state.
    /// <see href="http://data.totl.net/game/LocationState"></see></summary>
    let LocationState = _prefix "LocationState"
    /// <summary>
    /// An action which creates a new game state.
    /// <see href="http://data.totl.net/game/Move"></see></summary>
    let Move = _prefix "Move"
    /// <summary>
    ///   <see href="http://data.totl.net/game/Nothing"></see>
    /// </summary>
    let Nothing = _prefix "Nothing"
    /// <summary>
    /// A number of pieces of the same type. In games where money (fake or real) is used, then it should be treated as one piece per dollar (or the currency it works in). One piece per cent if subdivisions are possible.
    /// <see href="http://data.totl.net/game/PieceCount"></see></summary>
    let PieceCount = _prefix "PieceCount"
    /// <summary>
    /// A distinct type of piece. Interchangable with any other piece of the same type.
    /// <see href="http://data.totl.net/game/PieceType"></see></summary>
    let PieceType = _prefix "PieceType"
    /// <summary>
    /// Don't use piecetype and piececount interchangeably. If a location MAY contain multiple pieces of the same type, it should always use piececount.
    /// <see href="http://data.totl.net/game/Pieces"></see></summary>
    let Pieces = _prefix "Pieces"
    /// <summary>
    /// A player in a game. Only indicates an abstract side for the type of game, not a specific player in a single game.
    /// <see href="http://data.totl.net/game/Player"></see></summary>
    let Player = _prefix "Player"
    /// <summary>
    /// The state of a game.
    /// <see href="http://data.totl.net/game/State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// A status of a game.
    /// <see href="http://data.totl.net/game/Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// A symbol in ASCII to represent this type of piece.
    /// <see href="http://data.totl.net/game/asciiSymbol"></see></summary>
    let asciiSymbol = _prefix "asciiSymbol"
    /// <summary>
    /// The player this type of piece belongs to.
    /// <see href="http://data.totl.net/game/belongsTo"></see></summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    /// The pieces captured in a move.
    /// <see href="http://data.totl.net/game/captures"></see></summary>
    let captures = _prefix "captures"
    /// <summary>
    /// A location which is captured by the player making the move. For example in reversi all pieces which change to their colour.
    /// <see href="http://data.totl.net/game/capturesLocation"></see></summary>
    let capturesLocation = _prefix "capturesLocation"
    /// <summary>
    /// A location involved in the move.
    /// <see href="http://data.totl.net/game/moveLocation"></see></summary>
    let moveLocation = _prefix "moveLocation"
    /// <summary>
    /// The piece(s) in a location of a location state, or nothing.
    /// <see href="http://data.totl.net/game/contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// The pieces converted to the players own side, in a move.
    /// <see href="http://data.totl.net/game/converts"></see></summary>
    let converts = _prefix "converts"
    /// <summary>
    /// The number of pieces, of the given type, in a piece count.
    /// <see href="http://data.totl.net/game/count"></see></summary>
    let count = _prefix "count"
    /// <summary>
    ///   <see href="http://data.totl.net/game/drawn"></see>
    /// </summary>
    let drawn = _prefix "drawn"
    /// <summary>
    /// The initial state of the game
    /// <see href="http://data.totl.net/game/initialState"></see></summary>
    let initialState = _prefix "initialState"
    /// <summary>
    /// A possible move given the current game state.
    /// <see href="http://data.totl.net/game/legalMove"></see></summary>
    let legalMove = _prefix "legalMove"
    /// <summary>
    /// The player making a move.
    /// <see href="http://data.totl.net/game/madeBy"></see></summary>
    let madeBy = _prefix "madeBy"
    /// <summary>
    /// A location involved in the end of the move.
    /// <see href="http://data.totl.net/game/moveEndLocation"></see></summary>
    let moveEndLocation = _prefix "moveEndLocation"
    /// <summary>
    /// A location involved in the start of the move.
    /// <see href="http://data.totl.net/game/moveStartLocation"></see></summary>
    let moveStartLocation = _prefix "moveStartLocation"
    /// <summary>
    /// The new state created by a move.
    /// <see href="http://data.totl.net/game/newState"></see></summary>
    let newState = _prefix "newState"
    /// <summary>
    /// Indicates nothing is in a location.
    /// <see href="http://data.totl.net/game/nothing"></see></summary>
    let nothing = _prefix "nothing"
    /// <summary>
    /// The type of game of which this is a single state.
    /// <see href="http://data.totl.net/game/ofGame"></see></summary>
    let ofGame = _prefix "ofGame"
    /// <summary>
    /// The location of something such as a move or a location state.
    /// <see href="http://data.totl.net/game/ofLocation"></see></summary>
    let ofLocation = _prefix "ofLocation"
    /// <summary>
    ///   <see href="http://data.totl.net/game/ongoing"></see>
    /// </summary>
    let ongoing = _prefix "ongoing"
    /// <summary>
    /// The pieces removed completel from play in a move.
    /// <see href="http://data.totl.net/game/removes"></see></summary>
    let removes = _prefix "removes"
    /// <summary>
    /// The status of a given game state, win, ongoing or draw. Games may introduce additional statuses.
    /// <see href="http://data.totl.net/game/status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// The pieces taken in a move and removed from play.
    /// <see href="http://data.totl.net/game/takes"></see></summary>
    let takes = _prefix "takes"
    /// <summary>
    /// The player who's turn it is in a given state.
    /// <see href="http://data.totl.net/game/turn"></see></summary>
    let turn = _prefix "turn"
    /// <summary>
    /// The type of piece in a piece count.
    /// <see href="http://data.totl.net/game/type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// A symbol in Unicode to represent this type of piece.
    /// <see href="http://data.totl.net/game/unicodeSymbol"></see></summary>
    let unicodeSymbol = _prefix "unicodeSymbol"
    /// <summary>
    /// The player who has won.
    /// <see href="http://data.totl.net/game/winner"></see></summary>
    let winner = _prefix "winner"
    /// <summary>
    ///   <see href="http://data.totl.net/game/won"></see>
    /// </summary>
    let won = _prefix "won"
