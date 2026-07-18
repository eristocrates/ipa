namespace http.ns.inria.fr.ludo.v1.virtualcontext.hash

open DoxAletheia.Rdf_Vocabulary

module ludo_vc =
    let _namespace_name = "http://ns.inria.fr/ludo/v1/virtualcontext#"
    /// <summary>
    /// Represents the current (latest) game level in which the player is in the serious game
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#GameLevel"></see></summary>
    let GameLevel = Namespaced_IRI.parse _namespace_name "GameLevel" |> NamespacedName

    /// <summary>
    /// It represents the realation of proximity between two players
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#NearbyPlayer"></see></summary>
    let NearbyPlayer =
        Namespaced_IRI.parse _namespace_name "NearbyPlayer" |> NamespacedName

    /// <summary>
    /// Point of interest
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#POI"></see></summary>
    let POI = Namespaced_IRI.parse _namespace_name "POI" |> NamespacedName

    /// <summary>
    /// Represents the virtual activity that the player is performing inside the game. Such as learning, exploring.
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#VirtualActivity"></see></summary>
    let VirtualActivity =
        Namespaced_IRI.parse _namespace_name "VirtualActivity" |> NamespacedName

    /// <summary>
    /// Represents the relation between a real life location and a location inside the game
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#VirtualLocation"></see></summary>
    let VirtualLocation =
        Namespaced_IRI.parse _namespace_name "VirtualLocation" |> NamespacedName

    /// <summary>
    /// The current level of the game in which the Gameplayer is
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentGameLevel"></see></summary>
    let hasCurrentGameLevel =
        Namespaced_IRI.parse _namespace_name "hasCurrentGameLevel" |> NamespacedName

    /// <summary>
    /// Given the current virtual location of a GamePlayer, it defines the corresponding POI in real life
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentPOI"></see></summary>
    let hasCurrentPOI =
        Namespaced_IRI.parse _namespace_name "hasCurrentPOI" |> NamespacedName

    /// <summary>
    /// The currrent VirtualAcitivity of a GamePlayer
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentVirtualActivity"></see></summary>
    let hasCurrentVirtualActivity =
        Namespaced_IRI.parse _namespace_name "hasCurrentVirtualActivity" |> NamespacedName

    /// <summary>
    /// Nearby player distance
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasDistance"></see></summary>
    let hasDistance =
        Namespaced_IRI.parse _namespace_name "hasDistance" |> NamespacedName

    /// <summary>
    /// The label of the game level
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasGameLevelLabel"></see></summary>
    let hasGameLevelLabel =
        Namespaced_IRI.parse _namespace_name "hasGameLevelLabel" |> NamespacedName

    /// <summary>
    /// The numeric label of the game level
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasGameLevelNumber"></see></summary>
    let hasGameLevelNumber =
        Namespaced_IRI.parse _namespace_name "hasGameLevelNumber" |> NamespacedName

    /// <summary>
    /// The category of the POI
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasPOICategory"></see></summary>
    let hasPOICategory =
        Namespaced_IRI.parse _namespace_name "hasPOICategory" |> NamespacedName

    /// <summary>
    /// A label with the name of the POI
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasPOILabel"></see></summary>
    let hasPOILabel =
        Namespaced_IRI.parse _namespace_name "hasPOILabel" |> NamespacedName

    /// <summary>
    /// Virtual Activity
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#hasVirtualActivityLabel"></see></summary>
    let hasVirtualActivityLabel =
        Namespaced_IRI.parse _namespace_name "hasVirtualActivityLabel" |> NamespacedName

    /// <summary>
    /// Nearby Player Distance in meters
    /// <see href="http://ns.inria.fr/ludo/v1/virtualcontext#nearbyPlayerDistance"></see></summary>
    let nearbyPlayerDistance =
        Namespaced_IRI.parse _namespace_name "nearbyPlayerDistance" |> NamespacedName
