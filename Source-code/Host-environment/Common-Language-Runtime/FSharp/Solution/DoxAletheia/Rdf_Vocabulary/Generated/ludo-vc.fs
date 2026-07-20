namespace http.ns.inria.fr.ludo.v1.virtualcontext.hash

open DoxAletheia

module ludo_vc =
    let _namespace_name = "http://ns.inria.fr/ludo/v1/virtualcontext#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents the current (latest) game level in which the player is in the serious game
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#GameLevel"></see></summary>
    let GameLevel = _prefix "GameLevel"
    /// <summary>
    /// It represents the realation of proximity between two players
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#NearbyPlayer"></see></summary>
    let NearbyPlayer = _prefix "NearbyPlayer"
    /// <summary>
    /// Point of interest
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#POI"></see></summary>
    let POI = _prefix "POI"
    /// <summary>
    /// Represents the virtual activity that the player is performing inside the game. Such as learning, exploring.
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#VirtualActivity"></see></summary>
    let VirtualActivity = _prefix "VirtualActivity"
    /// <summary>
    /// Represents the relation between a real life location and a location inside the game
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#VirtualLocation"></see></summary>
    let VirtualLocation = _prefix "VirtualLocation"
    /// <summary>
    /// The current level of the game in which the Gameplayer is
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentGameLevel"></see></summary>
    let hasCurrentGameLevel = _prefix "hasCurrentGameLevel"
    /// <summary>
    /// Given the current virtual location of a GamePlayer, it defines the corresponding POI in real life
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentPOI"></see></summary>
    let hasCurrentPOI = _prefix "hasCurrentPOI"
    /// <summary>
    /// The currrent VirtualAcitivity of a GamePlayer
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentVirtualActivity"></see></summary>
    let hasCurrentVirtualActivity = _prefix "hasCurrentVirtualActivity"
    /// <summary>
    /// Nearby player distance
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasDistance"></see></summary>
    let hasDistance = _prefix "hasDistance"
    /// <summary>
    /// The label of the game level
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasGameLevelLabel"></see></summary>
    let hasGameLevelLabel = _prefix "hasGameLevelLabel"
    /// <summary>
    /// The numeric label of the game level
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasGameLevelNumber"></see></summary>
    let hasGameLevelNumber = _prefix "hasGameLevelNumber"
    /// <summary>
    /// The category of the POI
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasPOICategory"></see></summary>
    let hasPOICategory = _prefix "hasPOICategory"
    /// <summary>
    /// A label with the name of the POI
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasPOILabel"></see></summary>
    let hasPOILabel = _prefix "hasPOILabel"
    /// <summary>
    /// Virtual Activity
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasVirtualActivityLabel"></see></summary>
    let hasVirtualActivityLabel = _prefix "hasVirtualActivityLabel"
    /// <summary>
    /// Nearby Player Distance in meters
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#nearbyPlayerDistance"></see></summary>
    let nearbyPlayerDistance = _prefix "nearbyPlayerDistance"
