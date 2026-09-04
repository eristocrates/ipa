#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tisc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://observedchange.com/tisc/ns#" "tisc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Object is (some)thing located in space and time.
    /// </para>
    ///   <para>rdfs:label : Object</para>
    ///   <a href="http://observedchange.com/tisc/ns#Object">tisc:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:comment : PartialOverlap is a class which allows instantiating characteristics of a partial overlap.
    ///   </para>
    ///   <para>rdfs:label : PartialOverlap</para>
    ///   <a href="http://observedchange.com/tisc/ns#PartialOverlap">tisc:PartialOverlap</a>
    /// </summary>
    let PartialOverlap = _prefixId.prefix "PartialOverlap"
    /// <summary>
    ///   <para>rdfs:comment : address is an abstract property to express that an object has some address.</para>
    ///   <para>rdfs:label : address</para>
    ///   <a href="http://observedchange.com/tisc/ns#address">tisc:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>rdfs:comment : along is an abstract property to express that an object is along another, for example "a group of houses along by the river".</para>
    ///   <para>rdfs:label : along</para>
    ///   <a href="http://observedchange.com/tisc/ns#along">tisc:along</a>
    /// </summary>
    let along = _prefixId.prefix "along"
    /// <summary>
    ///   <para>rdfs:comment : areasize is an abstract property to express the size of the area of an object.</para>
    ///   <para>rdfs:label : areasize</para>
    ///   <a href="http://observedchange.com/tisc/ns#areasize">tisc:areasize</a>
    /// </summary>
    let areasize = _prefixId.prefix "areasize"
    /// <summary>
    ///   <para>rdfs:comment : atFrontOf is an abstract property to express that an object is at front of another.</para>
    ///   <para>rdfs:label : atFrontOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#atFrontOf">tisc:atFrontOf</a>
    /// </summary>
    let atFrontOf = _prefixId.prefix "atFrontOf"
    /// <summary>
    ///   <para>rdfs:comment : behind is an abstract property to express that an object is behind another.</para>
    ///   <para>rdfs:label : behind</para>
    ///   <a href="http://observedchange.com/tisc/ns#behind">tisc:behind</a>
    /// </summary>
    let behind = _prefixId.prefix "behind"
    /// <summary>
    ///   <para>rdfs:comment : disconnected is an abstract property to express that an object is disconnected from another.</para>
    ///   <para>rdfs:label : disconnected</para>
    ///   <a href="http://observedchange.com/tisc/ns#disconnected">tisc:disconnected</a>
    /// </summary>
    let disconnected = _prefixId.prefix "disconnected"
    /// <summary>
    ///   <para>rdfs:comment : eastOf is an abstract property to express that an object is East of another.</para>
    ///   <para>rdfs:label : eastOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#eastOf">tisc:eastOf</a>
    /// </summary>
    let eastOf = _prefixId.prefix "eastOf"
    /// <summary>
    ///   <para>rdfs:comment : equal is an abstract property to express that an object is equal with another.</para>
    ///   <para>rdfs:label : equal</para>
    ///   <a href="http://observedchange.com/tisc/ns#equal">tisc:equal</a>
    /// </summary>
    let equal = _prefixId.prefix "equal"
    /// <summary>
    ///   <para>rdfs:comment : existenceBeginsAt is an abstract property to express that the existence of an object begins at a given time instant.</para>
    ///   <para>rdfs:label : existenceBeginsAt</para>
    ///   <a href="http://observedchange.com/tisc/ns#existenceBeginsAt">tisc:existenceBeginsAt</a>
    /// </summary>
    let existenceBeginsAt = _prefixId.prefix "existenceBeginsAt"
    /// <summary>
    ///   <para>rdfs:comment : existenceEndsAt is an abstract property to express that the existence of an object ends at a given time instant.</para>
    ///   <para>rdfs:label : existenceEndsAt</para>
    ///   <a href="http://observedchange.com/tisc/ns#existenceEndsAt">tisc:existenceEndsAt</a>
    /// </summary>
    let existenceEndsAt = _prefixId.prefix "existenceEndsAt"
    /// <summary>
    ///   <para>rdfs:comment : externallyConnected is an abstract property to express that an object is externally connected with another.</para>
    ///   <para>rdfs:label : externallyConnected</para>
    ///   <a href="http://observedchange.com/tisc/ns#externallyConnected">tisc:externallyConnected</a>
    /// </summary>
    let externallyConnected = _prefixId.prefix "externallyConnected"
    /// <summary>
    ///   <para>rdfs:comment : far is an abstract property to express that an object is far from another.</para>
    ///   <para>rdfs:label : far</para>
    ///   <a href="http://observedchange.com/tisc/ns#far">tisc:far</a>
    /// </summary>
    let far = _prefixId.prefix "far"
    /// <summary>
    ///   <para>rdfs:comment : forecastMadeAt is an abstract property to express that an object is forecast made at certain time.</para>
    ///   <para>rdfs:label : forecastMadeAt</para>
    ///   <a href="http://observedchange.com/tisc/ns#forecastMadeAt">tisc:forecastMadeAt</a>
    /// </summary>
    let forecastMadeAt = _prefixId.prefix "forecastMadeAt"
    /// <summary>
    ///   <para>rdfs:comment : geometry is an abstract property to express that an object has certain geometry.</para>
    ///   <para>rdfs:label : geometry</para>
    ///   <a href="http://observedchange.com/tisc/ns#geometry">tisc:geometry</a>
    /// </summary>
    let geometry = _prefixId.prefix "geometry"
    /// <summary>
    ///   <para>rdfs:comment : happensAt is a predicate to state when something happens (for example an event such as a concert).</para>
    ///   <para>rdfs:label : happensAt</para>
    ///   <a href="http://observedchange.com/tisc/ns#happensAt">tisc:happensAt</a>
    /// </summary>
    let happensAt = _prefixId.prefix "happensAt"
    /// <summary>
    ///   <para>rdfs:comment : hasCentroid is an abstract property to express the location of the centroid of an area feature.
    ///   </para>
    ///   <para>rdfs:label : hasCentroid</para>
    ///   <a href="http://observedchange.com/tisc/ns#hasCentroid">tisc:hasCentroid</a>
    /// </summary>
    let hasCentroid = _prefixId.prefix "hasCentroid"
    /// <summary>
    ///   <para>rdfs:comment : hasHeight is an abstract property to express that an object has certain height.</para>
    ///   <para>rdfs:label : hasHeight</para>
    ///   <a href="http://observedchange.com/tisc/ns#hasHeight">tisc:hasHeight</a>
    /// </summary>
    let hasHeight = _prefixId.prefix "hasHeight"
    /// <summary>
    ///   <para>rdfs:comment : hasLength is an abstract property to express that an object has certain length.</para>
    ///   <para>rdfs:label : hasLength</para>
    ///   <a href="http://observedchange.com/tisc/ns#hasLength">tisc:hasLength</a>
    /// </summary>
    let hasLength = _prefixId.prefix "hasLength"
    /// <summary>
    ///   <para>rdfs:comment : hasUnionOf is an abstract property to express which union an object (or region) belongs to.</para>
    ///   <para>rdfs:label : hasUnionOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#hasUnionOf">tisc:hasUnionOf</a>
    /// </summary>
    let hasUnionOf = _prefixId.prefix "hasUnionOf"
    /// <summary>
    ///   <para>rdfs:comment : hasWidth is an abstract property to express that an object has certain width.</para>
    ///   <para>rdfs:label : hasWidth</para>
    ///   <a href="http://observedchange.com/tisc/ns#hasWidth">tisc:hasWidth</a>
    /// </summary>
    let hasWidth = _prefixId.prefix "hasWidth"
    /// <summary>
    ///   <para>rdfs:comment : here is an abstract property to express that an object is at the same place as another.</para>
    ///   <para>rdfs:label : here</para>
    ///   <a href="http://observedchange.com/tisc/ns#here">tisc:here</a>
    /// </summary>
    let here = _prefixId.prefix "here"
    /// <summary>
    ///   <para>rdfs:comment : inFutureOf is an abstract property to express that an object is in future of another.</para>
    ///   <para>rdfs:label : inFutureOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#inFutureOf">tisc:inFutureOf</a>
    /// </summary>
    let inFutureOf = _prefixId.prefix "inFutureOf"
    /// <summary>
    ///   <para>rdfs:comment : inPastOf is an abstract property to express that an object is in past of another.</para>
    ///   <para>rdfs:label : inPastOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#inPastOf">tisc:inPastOf</a>
    /// </summary>
    let inPastOf = _prefixId.prefix "inPastOf"
    /// <summary>
    ///   <para>rdfs:comment : insideOf is an abstract property to express that an object is inside of another.</para>
    ///   <para>rdfs:label : insideOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#insideOf">tisc:insideOf</a>
    /// </summary>
    let insideOf = _prefixId.prefix "insideOf"
    /// <summary>
    ///   <para>rdfs:comment : isForecastFor is an abstract property to express that an object is a forecast for a certain time.</para>
    ///   <para>rdfs:label : isForecastFor</para>
    ///   <a href="http://observedchange.com/tisc/ns#isForecastFor">tisc:isForecastFor</a>
    /// </summary>
    let isForecastFor = _prefixId.prefix "isForecastFor"
    /// <summary>
    ///   <para>rdfs:comment : leftOf is an abstract property to express that an object is to the left from another.</para>
    ///   <para>rdfs:label : leftOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#leftOf">tisc:leftOf</a>
    /// </summary>
    let leftOf = _prefixId.prefix "leftOf"
    /// <summary>
    ///   <para>rdfs:comment : locatedAt is an abstract property to express that an object is located at somewhere.</para>
    ///   <para>rdfs:label : locatedAt</para>
    ///   <a href="http://observedchange.com/tisc/ns#locatedAt">tisc:locatedAt</a>
    /// </summary>
    let locatedAt = _prefixId.prefix "locatedAt"
    /// <summary>
    ///   <para>rdfs:comment : near is an abstract property to express that an object is near to another.</para>
    ///   <para>rdfs:label : near</para>
    ///   <a href="http://observedchange.com/tisc/ns#near">tisc:near</a>
    /// </summary>
    let near = _prefixId.prefix "near"
    /// <summary>
    ///   <para>rdfs:comment : nearest is an abstract property to express that an object is nearest to another.</para>
    ///   <para>rdfs:label : nearest</para>
    ///   <a href="http://observedchange.com/tisc/ns#nearest">tisc:nearest</a>
    /// </summary>
    let nearest = _prefixId.prefix "nearest"
    /// <summary>
    ///   <para>rdfs:comment : next is an abstract property to express that an object is a next object in the order, for example to state the
    /// logical ordering of metro stations or bus stops, i.e. like in "next metro station from Victoria is Sloane Square". However, as such next is ambiguous as also "next metro station from Victoria is St James's Park" would be valid. This can be solved by e.g. having two instances of Victoria station for each direction, or using some similar type of mechanism. Note also that next is different from nextTo. </para>
    ///   <para>rdfs:label : next</para>
    ///   <a href="http://observedchange.com/tisc/ns#next">tisc:next</a>
    /// </summary>
    let next = _prefixId.prefix "next"
    /// <summary>
    ///   <para>rdfs:comment : nextTo is an abstract property to express that an object is next to another.</para>
    ///   <para>rdfs:label : nextTo</para>
    ///   <a href="http://observedchange.com/tisc/ns#nextTo">tisc:nextTo</a>
    /// </summary>
    let nextTo = _prefixId.prefix "nextTo"
    /// <summary>
    ///   <para>rdfs:comment : nonTangentialProperPart is an abstract property to express that an object is non tangential proper part of another.</para>
    ///   <para>rdfs:label : nonTangentialProperPart</para>
    ///   <a href="http://observedchange.com/tisc/ns#nonTangentialProperPart">tisc:nonTangentialProperPart</a>
    /// </summary>
    let nonTangentialProperPart = _prefixId.prefix "nonTangentialProperPart"
    /// <summary>
    ///   <para>rdfs:comment : northEastOf is an abstract property to express that an object is Northeast of another.</para>
    ///   <para>rdfs:label : northEastOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#northEastOf">tisc:northEastOf</a>
    /// </summary>
    let northEastOf = _prefixId.prefix "northEastOf"
    /// <summary>
    ///   <para>rdfs:comment : northOf is an abstract property to express that an object is North of another.</para>
    ///   <para>rdfs:label : northOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#northOf">tisc:northOf</a>
    /// </summary>
    let northOf = _prefixId.prefix "northOf"
    /// <summary>
    ///   <para>rdfs:comment : northWestOf is an abstract property to express that an object is Northwest of another.</para>
    ///   <para>rdfs:label : northWestOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#northWestOf">tisc:northWestOf</a>
    /// </summary>
    let northWestOf = _prefixId.prefix "northWestOf"
    /// <summary>
    ///   <para>rdfs:comment : outsideOf is an abstract property to express that an object is outside of another.</para>
    ///   <para>rdfs:label : outsideOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#outsideOf">tisc:outsideOf</a>
    /// </summary>
    let outsideOf = _prefixId.prefix "outsideOf"
    /// <summary>
    ///   <para>rdfs:comment : partialOverlapArea is an abstract property to express the overlaping area of two things in a PartialOverlap. The area units can be stated with partialOverlapUnit.
    ///   </para>
    ///   <para>rdfs:label : partialOverlapArea</para>
    ///   <a href="http://observedchange.com/tisc/ns#partialOverlapArea">tisc:partialOverlapArea</a>
    /// </summary>
    let partialOverlapArea = _prefixId.prefix "partialOverlapArea"
    /// <summary>
    ///   <para>rdfs:comment : partialOverlapFrom is an abstract property to express the first object that takes part in a PartialOverlap.
    ///   </para>
    ///   <para>rdfs:label : partialOverlapFrom</para>
    ///   <a href="http://observedchange.com/tisc/ns#partialOverlapFrom">tisc:partialOverlapFrom</a>
    /// </summary>
    let partialOverlapFrom = _prefixId.prefix "partialOverlapFrom"
    /// <summary>
    ///   <para>rdfs:comment : partialOverlapRatio is an abstract property to express the ratio of dividing the partialOverlapArea by the area of the object pointed by partialOverlapFrom.
    ///   </para>
    ///   <para>rdfs:label : partialOverlapRatio</para>
    ///   <a href="http://observedchange.com/tisc/ns#partialOverlapRatio">tisc:partialOverlapRatio</a>
    /// </summary>
    let partialOverlapRatio = _prefixId.prefix "partialOverlapRatio"
    /// <summary>
    ///   <para>rdfs:comment : partialOverlapTo is an abstract property to express the second object that takes part in a PartialOverlap.
    ///   </para>
    ///   <para>rdfs:label : partialOverlapTo</para>
    ///   <a href="http://observedchange.com/tisc/ns#partialOverlapTo">tisc:partialOverlapTo</a>
    /// </summary>
    let partialOverlapTo = _prefixId.prefix "partialOverlapTo"
    /// <summary>
    ///   <para>rdfs:comment : partialOverlapUnit is an abstract property to express the units of partialOverlapArea of two things in a PartialOverlap.
    ///   </para>
    ///   <para>rdfs:label : partialOverlapUnit</para>
    ///   <a href="http://observedchange.com/tisc/ns#partialOverlapUnit">tisc:partialOverlapUnit</a>
    /// </summary>
    let partialOverlapUnit = _prefixId.prefix "partialOverlapUnit"
    /// <summary>
    ///   <para>rdfs:comment : partiallyOverlapping is an abstract property to express that an object is partially overlapping with another.</para>
    ///   <para>rdfs:label : partiallyOverlapping</para>
    ///   <a href="http://observedchange.com/tisc/ns#partiallyOverlapping">tisc:partiallyOverlapping</a>
    /// </summary>
    let partiallyOverlapping = _prefixId.prefix "partiallyOverlapping"
    /// <summary>
    ///   <para>rdfs:comment : rightOf is an abstract property to express that an object is to the right from another.</para>
    ///   <para>rdfs:label : rightOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#rightOf">tisc:rightOf</a>
    /// </summary>
    let rightOf = _prefixId.prefix "rightOf"
    /// <summary>
    ///   <para>rdfs:comment : sharesPathWith is an abstract property to express that an object shares a path with another.</para>
    ///   <para>rdfs:label : sharesPathWith</para>
    ///   <a href="http://observedchange.com/tisc/ns#sharesPathWith">tisc:sharesPathWith</a>
    /// </summary>
    let sharesPathWith = _prefixId.prefix "sharesPathWith"
    /// <summary>
    ///   <para>rdfs:comment : sizeOfLandArea is an abstract property to express the size of the land area of a region.</para>
    ///   <para>rdfs:label : sizeOfLandArea</para>
    ///   <a href="http://observedchange.com/tisc/ns#sizeOfLandArea">tisc:sizeOfLandArea</a>
    /// </summary>
    let sizeOfLandArea = _prefixId.prefix "sizeOfLandArea"
    /// <summary>
    ///   <para>rdfs:comment : southEastOf is an abstract property to express that an object is Southeast of another.</para>
    ///   <para>rdfs:label : southEastOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#southEastOf">tisc:southEastOf</a>
    /// </summary>
    let southEastOf = _prefixId.prefix "southEastOf"
    /// <summary>
    ///   <para>rdfs:comment : southOf is an abstract property to express that an object is South of another.</para>
    ///   <para>rdfs:label : southOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#southOf">tisc:southOf</a>
    /// </summary>
    let southOf = _prefixId.prefix "southOf"
    /// <summary>
    ///   <para>rdfs:comment : southWestOf is an abstract property to express that an object is Southwest of another.</para>
    ///   <para>rdfs:label : southWestOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#southWestOf">tisc:southWestOf</a>
    /// </summary>
    let southWestOf = _prefixId.prefix "southWestOf"
    /// <summary>
    ///   <para>rdfs:comment : tangentialProperPart is an abstract property to express that an object is tangential proper part of another.</para>
    ///   <para>rdfs:label : tangentialProperPart</para>
    ///   <a href="http://observedchange.com/tisc/ns#tangentialProperPart">tisc:tangentialProperPart</a>
    /// </summary>
    let tangentialProperPart = _prefixId.prefix "tangentialProperPart"
    /// <summary>
    ///   <para>rdfs:comment : touches is an abstract property to express that a region touches another region.</para>
    ///   <para>rdfs:label : touches</para>
    ///   <a href="http://observedchange.com/tisc/ns#touches">tisc:touches</a>
    /// </summary>
    let touches = _prefixId.prefix "touches"
    /// <summary>
    ///   <para>rdfs:comment : unionOf is an abstract property to express which union a spatiotemporal region forms.</para>
    ///   <para>rdfs:label : unionOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#unionOf">tisc:unionOf</a>
    /// </summary>
    let unionOf = _prefixId.prefix "unionOf"
    /// <summary>
    ///   <para>rdfs:comment : westOf is an abstract property to express that an object is West of another.</para>
    ///   <para>rdfs:label : westOf</para>
    ///   <a href="http://observedchange.com/tisc/ns#westOf">tisc:westOf</a>
    /// </summary>
    let westOf = _prefixId.prefix "westOf"
