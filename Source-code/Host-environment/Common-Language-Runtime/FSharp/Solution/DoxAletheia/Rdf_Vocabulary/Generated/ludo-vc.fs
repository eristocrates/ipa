namespace http.ns.inria.fr.ludo.v1.virtualcontext.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ludo_vc =
    let _namespace_iri = Namespace_Iri ludo_vc |> NamespaceIRI
    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Given the increasing amount of structured data published on the Web, many possibilities are open for creating new types of games that use resources from the Web of Data. In particular, if we consider the subcategory of Serious Games in which the object of the game is to educate the user through the interactive discovery of real-life concepts (associated to Semantic Web resources), the inclusion of a semantic representation of the user profile and his contextual information becomes an important element to recommend the user more accurate concepts. Ludo is an ontology that allows the creation of Serious Games with those characteristics."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#">http://ns.inria.fr/ludo/v1/virtualcontext#</seealso>
    let _prefix_iri = Prefixed_Name(ludo_vc, "") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#GameLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the current (latest) game level in which the player is in the serious game"</para>
    /// labels<para>"Game level"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#GameLevel">http://ns.inria.fr/ludo/v1/virtualcontext#GameLevel</seealso>
    let GameLevel = Prefixed_Name(ludo_vc, "GameLevel") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#NearbyPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents the realation of proximity between two players"</para>
    /// labels<para>"Nearby Player"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#NearbyPlayer">http://ns.inria.fr/ludo/v1/virtualcontext#NearbyPlayer</seealso>
    let NearbyPlayer = Prefixed_Name(ludo_vc, "NearbyPlayer") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#POI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Point of interest"</para>
    /// labels<para>"POI"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#POI">http://ns.inria.fr/ludo/v1/virtualcontext#POI</seealso>
    let POI = Prefixed_Name(ludo_vc, "POI") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#VirtualActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the virtual activity that the player is performing inside the game. Such as learning, exploring."</para>
    /// labels<para>"Virtual activity"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#VirtualActivity">http://ns.inria.fr/ludo/v1/virtualcontext#VirtualActivity</seealso>
    let VirtualActivity = Prefixed_Name(ludo_vc, "VirtualActivity") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#VirtualLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the relation between a real life location and a location inside the game"</para>
    /// labels<para>"Virtual location"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#VirtualLocation">http://ns.inria.fr/ludo/v1/virtualcontext#VirtualLocation</seealso>
    let VirtualLocation = Prefixed_Name(ludo_vc, "VirtualLocation") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#hasCurrentGameLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The current level of the game in which the Gameplayer is"</para>
    /// labels<para>"Has current game level"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentGameLevel">http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentGameLevel</seealso>
    let hasCurrentGameLevel =
        Prefixed_Name(ludo_vc, "hasCurrentGameLevel") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#hasCurrentPOI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Given the current virtual location of a GamePlayer, it defines the corresponding POI in real life"</para>
    /// labels<para>"Has current POI"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentPOI">http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentPOI</seealso>
    let hasCurrentPOI = Prefixed_Name(ludo_vc, "hasCurrentPOI") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#hasCurrentVirtualActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The currrent VirtualAcitivity of a GamePlayer"</para>
    /// labels<para>"Has currrent VirtualAcitivity"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentVirtualActivity">http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentVirtualActivity</seealso>
    let hasCurrentVirtualActivity =
        Prefixed_Name(ludo_vc, "hasCurrentVirtualActivity") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#hasDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nearby player distance"</para>
    /// labels<para>"Has distance"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#hasDistance">http://ns.inria.fr/ludo/v1/virtualcontext#hasDistance</seealso>
    let hasDistance = Prefixed_Name(ludo_vc, "hasDistance") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#hasGameLevelLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The label of the game level"</para>
    /// labels<para>"Has game level label"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#hasGameLevelLabel">http://ns.inria.fr/ludo/v1/virtualcontext#hasGameLevelLabel</seealso>
    let hasGameLevelLabel = Prefixed_Name(ludo_vc, "hasGameLevelLabel") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#hasGameLevelNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The numeric label of the game level"</para>
    /// labels<para>"Has game level number"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#hasGameLevelNumber">http://ns.inria.fr/ludo/v1/virtualcontext#hasGameLevelNumber</seealso>
    let hasGameLevelNumber =
        Prefixed_Name(ludo_vc, "hasGameLevelNumber") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#hasPOICategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The category of the POI"</para>
    /// labels<para>"Has POI category"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#hasPOICategory">http://ns.inria.fr/ludo/v1/virtualcontext#hasPOICategory</seealso>
    let hasPOICategory = Prefixed_Name(ludo_vc, "hasPOICategory") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#hasPOILabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A label with the name of the POI"</para>
    /// labels<para>"Has POI label"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#hasPOILabel">http://ns.inria.fr/ludo/v1/virtualcontext#hasPOILabel</seealso>
    let hasPOILabel = Prefixed_Name(ludo_vc, "hasPOILabel") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#hasVirtualActivityLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Virtual Activity"</para>
    /// labels<para>"Virtual Activity"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#hasVirtualActivityLabel">http://ns.inria.fr/ludo/v1/virtualcontext#hasVirtualActivityLabel</seealso>
    let hasVirtualActivityLabel =
        Prefixed_Name(ludo_vc, "hasVirtualActivityLabel") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/virtualcontext#nearbyPlayerDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Nearby Player Distance in meters"</para>
    /// labels<para>"Nearby Player Distance"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext#nearbyPlayerDistance">http://ns.inria.fr/ludo/v1/virtualcontext#nearbyPlayerDistance</seealso>
    let nearbyPlayerDistance =
        Prefixed_Name(ludo_vc, "nearbyPlayerDistance") |> PrefixedName
