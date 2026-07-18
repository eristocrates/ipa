namespace http.data.totl.net.game.slash

open DoxAletheia.Rdf_Vocabulary

module game =
    let _namespace_name = "http://data.totl.net/game/"
    /// <summary>
    /// A Game type, such as go or chess.
    /// <see href="http://data.totl.net/game/Game"></see></summary>
    let Game = Namespaced_IRI.parse _namespace_name "Game" |> NamespacedName
    /// <summary>
    /// A location in a game, such as a square or the players hand.
    /// <see href="http://data.totl.net/game/Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    /// The state of a location on a specific game state.
    /// <see href="http://data.totl.net/game/LocationState"></see></summary>
    let LocationState =
        Namespaced_IRI.parse _namespace_name "LocationState" |> NamespacedName

    /// <summary>
    /// An action which creates a new game state.
    /// <see href="http://data.totl.net/game/Move"></see></summary>
    let Move = Namespaced_IRI.parse _namespace_name "Move" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.totl.net/game/Nothing"></see>
    /// </summary>
    let Nothing = Namespaced_IRI.parse _namespace_name "Nothing" |> NamespacedName
    /// <summary>
    /// A number of pieces of the same type. In games where money (fake or real) is used, then it should be treated as one piece per dollar (or the currency it works in). One piece per cent if subdivisions are possible.
    /// <see href="http://data.totl.net/game/PieceCount"></see></summary>
    let PieceCount = Namespaced_IRI.parse _namespace_name "PieceCount" |> NamespacedName
    /// <summary>
    /// A distinct type of piece. Interchangable with any other piece of the same type.
    /// <see href="http://data.totl.net/game/PieceType"></see></summary>
    let PieceType = Namespaced_IRI.parse _namespace_name "PieceType" |> NamespacedName
    /// <summary>
    /// Don't use piecetype and piececount interchangeably. If a location MAY contain multiple pieces of the same type, it should always use piececount.
    /// <see href="http://data.totl.net/game/Pieces"></see></summary>
    let Pieces = Namespaced_IRI.parse _namespace_name "Pieces" |> NamespacedName
    /// <summary>
    /// A player in a game. Only indicates an abstract side for the type of game, not a specific player in a single game.
    /// <see href="http://data.totl.net/game/Player"></see></summary>
    let Player = Namespaced_IRI.parse _namespace_name "Player" |> NamespacedName
    /// <summary>
    /// The state of a game.
    /// <see href="http://data.totl.net/game/State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    /// A status of a game.
    /// <see href="http://data.totl.net/game/Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// A symbol in ASCII to represent this type of piece.
    /// <see href="http://data.totl.net/game/asciiSymbol"></see></summary>
    let asciiSymbol =
        Namespaced_IRI.parse _namespace_name "asciiSymbol" |> NamespacedName

    /// <summary>
    /// The player this type of piece belongs to.
    /// <see href="http://data.totl.net/game/belongsTo"></see></summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName
    /// <summary>
    /// The pieces captured in a move.
    /// <see href="http://data.totl.net/game/captures"></see></summary>
    let captures = Namespaced_IRI.parse _namespace_name "captures" |> NamespacedName

    /// <summary>
    /// A location which is captured by the player making the move. For example in reversi all pieces which change to their colour.
    /// <see href="http://data.totl.net/game/capturesLocation"></see></summary>
    let capturesLocation =
        Namespaced_IRI.parse _namespace_name "capturesLocation" |> NamespacedName

    /// <summary>
    /// A location involved in the move.
    /// <see href="http://data.totl.net/game/moveLocation"></see></summary>
    let moveLocation =
        Namespaced_IRI.parse _namespace_name "moveLocation" |> NamespacedName

    /// <summary>
    /// The piece(s) in a location of a location state, or nothing.
    /// <see href="http://data.totl.net/game/contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    /// The pieces converted to the players own side, in a move.
    /// <see href="http://data.totl.net/game/converts"></see></summary>
    let converts = Namespaced_IRI.parse _namespace_name "converts" |> NamespacedName
    /// <summary>
    /// The number of pieces, of the given type, in a piece count.
    /// <see href="http://data.totl.net/game/count"></see></summary>
    let count = Namespaced_IRI.parse _namespace_name "count" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.totl.net/game/drawn"></see>
    /// </summary>
    let drawn = Namespaced_IRI.parse _namespace_name "drawn" |> NamespacedName

    /// <summary>
    /// The initial state of the game
    /// <see href="http://data.totl.net/game/initialState"></see></summary>
    let initialState =
        Namespaced_IRI.parse _namespace_name "initialState" |> NamespacedName

    /// <summary>
    /// A possible move given the current game state.
    /// <see href="http://data.totl.net/game/legalMove"></see></summary>
    let legalMove = Namespaced_IRI.parse _namespace_name "legalMove" |> NamespacedName
    /// <summary>
    /// The player making a move.
    /// <see href="http://data.totl.net/game/madeBy"></see></summary>
    let madeBy = Namespaced_IRI.parse _namespace_name "madeBy" |> NamespacedName

    /// <summary>
    /// A location involved in the end of the move.
    /// <see href="http://data.totl.net/game/moveEndLocation"></see></summary>
    let moveEndLocation =
        Namespaced_IRI.parse _namespace_name "moveEndLocation" |> NamespacedName

    /// <summary>
    /// A location involved in the start of the move.
    /// <see href="http://data.totl.net/game/moveStartLocation"></see></summary>
    let moveStartLocation =
        Namespaced_IRI.parse _namespace_name "moveStartLocation" |> NamespacedName

    /// <summary>
    /// The new state created by a move.
    /// <see href="http://data.totl.net/game/newState"></see></summary>
    let newState = Namespaced_IRI.parse _namespace_name "newState" |> NamespacedName
    /// <summary>
    /// Indicates nothing is in a location.
    /// <see href="http://data.totl.net/game/nothing"></see></summary>
    let nothing = Namespaced_IRI.parse _namespace_name "nothing" |> NamespacedName
    /// <summary>
    /// The type of game of which this is a single state.
    /// <see href="http://data.totl.net/game/ofGame"></see></summary>
    let ofGame = Namespaced_IRI.parse _namespace_name "ofGame" |> NamespacedName
    /// <summary>
    /// The location of something such as a move or a location state.
    /// <see href="http://data.totl.net/game/ofLocation"></see></summary>
    let ofLocation = Namespaced_IRI.parse _namespace_name "ofLocation" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.totl.net/game/ongoing"></see>
    /// </summary>
    let ongoing = Namespaced_IRI.parse _namespace_name "ongoing" |> NamespacedName
    /// <summary>
    /// The pieces removed completel from play in a move.
    /// <see href="http://data.totl.net/game/removes"></see></summary>
    let removes = Namespaced_IRI.parse _namespace_name "removes" |> NamespacedName
    /// <summary>
    /// The status of a given game state, win, ongoing or draw. Games may introduce additional statuses.
    /// <see href="http://data.totl.net/game/status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    /// The pieces taken in a move and removed from play.
    /// <see href="http://data.totl.net/game/takes"></see></summary>
    let takes = Namespaced_IRI.parse _namespace_name "takes" |> NamespacedName
    /// <summary>
    /// The player who's turn it is in a given state.
    /// <see href="http://data.totl.net/game/turn"></see></summary>
    let turn = Namespaced_IRI.parse _namespace_name "turn" |> NamespacedName
    /// <summary>
    /// The type of piece in a piece count.
    /// <see href="http://data.totl.net/game/type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

    /// <summary>
    /// A symbol in Unicode to represent this type of piece.
    /// <see href="http://data.totl.net/game/unicodeSymbol"></see></summary>
    let unicodeSymbol =
        Namespaced_IRI.parse _namespace_name "unicodeSymbol" |> NamespacedName

    /// <summary>
    /// The player who has won.
    /// <see href="http://data.totl.net/game/winner"></see></summary>
    let winner = Namespaced_IRI.parse _namespace_name "winner" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.totl.net/game/won"></see>
    /// </summary>
    let won = Namespaced_IRI.parse _namespace_name "won" |> NamespacedName
