#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ludo-vc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ns.inria.fr/ludo/v1/virtualcontext#" "ludo-vc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Game level</para>
    ///   <para>rdfs:comment : Represents the current (latest) game level in which the player is in the serious game</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#GameLevel">ludo-vc:GameLevel</a>
    /// </summary>
    let GameLevel = _prefixId.prefix "GameLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Nearby Player</para>
    ///   <para>rdfs:comment : It represents the realation of proximity between two players</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#NearbyPlayer">ludo-vc:NearbyPlayer</a>
    /// </summary>
    let NearbyPlayer = _prefixId.prefix "NearbyPlayer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : POI</para>
    ///   <para>rdfs:comment : Point of interest</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#POI">ludo-vc:POI</a>
    /// </summary>
    let POI = _prefixId.prefix "POI"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Virtual activity</para>
    ///   <para>rdfs:comment : Represents the virtual activity that the player is performing inside the game. Such as learning, exploring.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#VirtualActivity">ludo-vc:VirtualActivity</a>
    /// </summary>
    let VirtualActivity = _prefixId.prefix "VirtualActivity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Virtual location</para>
    ///   <para>rdfs:comment : Represents the relation between a real life location and a location inside the game</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#VirtualLocation">ludo-vc:VirtualLocation</a>
    /// </summary>
    let VirtualLocation = _prefixId.prefix "VirtualLocation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has current game level</para>
    ///   <para>rdfs:comment : The current level of the game in which the Gameplayer is</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentGameLevel">ludo-vc:hasCurrentGameLevel</a>
    /// </summary>
    let hasCurrentGameLevel = _prefixId.prefix "hasCurrentGameLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has current POI</para>
    ///   <para>rdfs:comment : Given the current virtual location of a GamePlayer, it defines the corresponding POI in real life</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentPOI">ludo-vc:hasCurrentPOI</a>
    /// </summary>
    let hasCurrentPOI = _prefixId.prefix "hasCurrentPOI"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has currrent VirtualAcitivity</para>
    ///   <para>rdfs:comment : The currrent VirtualAcitivity of a GamePlayer</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#hasCurrentVirtualActivity">ludo-vc:hasCurrentVirtualActivity</a>
    /// </summary>
    let hasCurrentVirtualActivity = _prefixId.prefix "hasCurrentVirtualActivity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has distance</para>
    ///   <para>rdfs:comment : Nearby player distance</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#hasDistance">ludo-vc:hasDistance</a>
    /// </summary>
    let hasDistance = _prefixId.prefix "hasDistance"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has game level label</para>
    ///   <para>rdfs:comment : The label of the game level</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#hasGameLevelLabel">ludo-vc:hasGameLevelLabel</a>
    /// </summary>
    let hasGameLevelLabel = _prefixId.prefix "hasGameLevelLabel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has game level number</para>
    ///   <para>rdfs:comment : The numeric label of the game level</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#hasGameLevelNumber">ludo-vc:hasGameLevelNumber</a>
    /// </summary>
    let hasGameLevelNumber = _prefixId.prefix "hasGameLevelNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has POI category</para>
    ///   <para>rdfs:comment : The category of the POI</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#hasPOICategory">ludo-vc:hasPOICategory</a>
    /// </summary>
    let hasPOICategory = _prefixId.prefix "hasPOICategory"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has POI label</para>
    ///   <para>rdfs:comment : A label with the name of the POI</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#hasPOILabel">ludo-vc:hasPOILabel</a>
    /// </summary>
    let hasPOILabel = _prefixId.prefix "hasPOILabel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Virtual Activity</para>
    ///   <para>rdfs:comment : Virtual Activity</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#hasVirtualActivityLabel">ludo-vc:hasVirtualActivityLabel</a>
    /// </summary>
    let hasVirtualActivityLabel = _prefixId.prefix "hasVirtualActivityLabel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Nearby Player Distance</para>
    ///   <para>rdfs:comment : Nearby Player Distance in meters</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/virtualcontext#nearbyPlayerDistance">ludo-vc:nearbyPlayerDistance</a>
    /// </summary>
    let nearbyPlayerDistance = _prefixId.prefix "nearbyPlayerDistance"
