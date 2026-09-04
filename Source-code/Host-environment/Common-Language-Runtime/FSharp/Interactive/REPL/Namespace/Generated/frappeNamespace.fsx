#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module frappe =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://streamreasoning.org/ontologies/frappe#" "frappe"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Activity to create new Captured Frame^^xsd:string</para>
    ///   <para>rdfs:label : Capture^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#Capture">frappe:Capture</a>
    /// </summary>
    let Capture = _prefixId.prefix "Capture"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Original time varying representation of a Grid, mediated by the Capture activity^^xsd:string</para>
    ///   <para>rdfs:label : CapturedFrame^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#CapturedFrame">frappe:CapturedFrame</a>
    /// </summary>
    let CapturedFrame = _prefixId.prefix "CapturedFrame"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : A Cell represents the basic spatial unit of aggregation of information^^xsd:string</para>
    ///   <para>rdfs:label : Cell^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#Cell">frappe:Cell</a>
    /// </summary>
    let Cell = _prefixId.prefix "Cell"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : A Frame represents a time varying representation of a Grid^^xsd:string</para>
    ///   <para>rdfs:label : Frame^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#Frame">frappe:Frame</a>
    /// </summary>
    let Frame = _prefixId.prefix "Frame"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : The Grid represents a group of contiguous Cells^^xsd:string</para>
    ///   <para>rdfs:label : Grid^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#Grid">frappe:Grid</a>
    /// </summary>
    let Grid = _prefixId.prefix "Grid"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : A Pixel is a time varying representation of a Cell
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : Pixel^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#Pixel">frappe:Pixel</a>
    /// </summary>
    let Pixel = _prefixId.prefix "Pixel"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : A Place represents a point in space^^xsd:string</para>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#Place">frappe:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Synthetic time varying representation of a Grid, mediated by the Synthetize activity. A Synthetic Frame can be be created starting from Captured Frames or Synthetic Frames^^xsd:string</para>
    ///   <para>rdfs:label : SyntheticFrame^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#SyntheticFrame">frappe:SyntheticFrame</a>
    /// </summary>
    let SyntheticFrame = _prefixId.prefix "SyntheticFrame"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Activity to create new Synthetic Frame^^xsd:string</para>
    ///   <para>rdfs:label : Synthetize^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#Synthetize">frappe:Synthetize</a>
    /// </summary>
    let Synthetize = _prefixId.prefix "Synthetize"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a Frame with its Pixels^^xsd:string</para>
    ///   <para>rdfs:label : Contains^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#contains">frappe:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a Pixel with its Frame^^xsd:string</para>
    ///   <para>rdfs:label : isIn^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#isIn">frappe:isIn</a>
    /// </summary>
    let isIn = _prefixId.prefix "isIn"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a Place with its Events^^xsd:string</para>
    ///   <para>rdfs:label : isLocationOf^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#isLocationOf">frappe:isLocationOf</a>
    /// </summary>
    let isLocationOf = _prefixId.prefix "isLocationOf"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a Cell with its Pixels^^xsd:string</para>
    ///   <para>rdfs:label : isReferredBy^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#isReferredBy">frappe:isReferredBy</a>
    /// </summary>
    let isReferredBy = _prefixId.prefix "isReferredBy"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an Event with its Pixel^^xsd:string</para>
    ///   <para>rdfs:label : location^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#location">frappe:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Relates Pixel to its Cell^^xsd:string</para>
    ///   <para>rdfs:label : refers^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#refers">frappe:refers</a>
    /// </summary>
    let refers = _prefixId.prefix "refers"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a Frame with its creation Instant^^xsd:string</para>
    ///   <para>rdfs:label : samplingTs^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#samplingTime">frappe:samplingTime</a>
    /// </summary>
    let samplingTime = _prefixId.prefix "samplingTime"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Relate a Capture Frame to the time interval needed to capture a minimum quantity of data^^xsd:string</para>
    ///   <para>rdfs:label : timeExposure^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#timeExposure">frappe:timeExposure</a>
    /// </summary>
    let timeExposure = _prefixId.prefix "timeExposure"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a Frame to a Grid^^xsd:string</para>
    ///   <para>rdfs:label : wasCapturedFrom^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#wasCapturedFrom">frappe:wasCapturedFrom</a>
    /// </summary>
    let wasCapturedFrom = _prefixId.prefix "wasCapturedFrom"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : stable^^xsd:stringrdfs:isDefinedBy : http://streamreasoning.org/ontologies/frappe#^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a Synthetic Frame to the elements needed to the Synthetization^^xsd:string</para>
    ///   <para>rdfs:label : wasSynthetizedFrom^^xsd:string</para>
    ///   <a href="http://streamreasoning.org/ontologies/frappe#wasSynthetizedFrom">frappe:wasSynthetizedFrom</a>
    /// </summary>
    let wasSynthetizedFrom = _prefixId.prefix "wasSynthetizedFrom"
