namespace http.observedchange.com.tisc.ns.hash

open DoxAletheia

module tisc =
    let _namespace_name = "http://observedchange.com/tisc/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Object is (some)thing located in space and time.
    ///
    /// <see href="http://observedchange.com/tisc/ns#Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// PartialOverlap is a class which allows instantiating characteristics of a partial overlap.
    ///
    /// <see href="http://observedchange.com/tisc/ns#PartialOverlap"></see></summary>
    let PartialOverlap = _prefix "PartialOverlap"
    /// <summary>
    /// address is an abstract property to express that an object has some address.
    /// <see href="http://observedchange.com/tisc/ns#address"></see></summary>
    let address = _prefix "address"
    /// <summary>
    /// along is an abstract property to express that an object is along another, for example "a group of houses along by the river".
    /// <see href="http://observedchange.com/tisc/ns#along"></see></summary>
    let along = _prefix "along"
    /// <summary>
    /// areasize is an abstract property to express the size of the area of an object.
    /// <see href="http://observedchange.com/tisc/ns#areasize"></see></summary>
    let areasize = _prefix "areasize"
    /// <summary>
    /// atFrontOf is an abstract property to express that an object is at front of another.
    /// <see href="http://observedchange.com/tisc/ns#atFrontOf"></see></summary>
    let atFrontOf = _prefix "atFrontOf"
    /// <summary>
    /// behind is an abstract property to express that an object is behind another.
    /// <see href="http://observedchange.com/tisc/ns#behind"></see></summary>
    let behind = _prefix "behind"
    /// <summary>
    /// disconnected is an abstract property to express that an object is disconnected from another.
    /// <see href="http://observedchange.com/tisc/ns#disconnected"></see></summary>
    let disconnected = _prefix "disconnected"
    /// <summary>
    /// eastOf is an abstract property to express that an object is East of another.
    /// <see href="http://observedchange.com/tisc/ns#eastOf"></see></summary>
    let eastOf = _prefix "eastOf"
    /// <summary>
    /// equal is an abstract property to express that an object is equal with another.
    /// <see href="http://observedchange.com/tisc/ns#equal"></see></summary>
    let equal = _prefix "equal"
    /// <summary>
    /// existenceBeginsAt is an abstract property to express that the existence of an object begins at a given time instant.
    /// <see href="http://observedchange.com/tisc/ns#existenceBeginsAt"></see></summary>
    let existenceBeginsAt = _prefix "existenceBeginsAt"
    /// <summary>
    /// existenceEndsAt is an abstract property to express that the existence of an object ends at a given time instant.
    /// <see href="http://observedchange.com/tisc/ns#existenceEndsAt"></see></summary>
    let existenceEndsAt = _prefix "existenceEndsAt"
    /// <summary>
    /// externallyConnected is an abstract property to express that an object is externally connected with another.
    /// <see href="http://observedchange.com/tisc/ns#externallyConnected"></see></summary>
    let externallyConnected = _prefix "externallyConnected"
    /// <summary>
    /// far is an abstract property to express that an object is far from another.
    /// <see href="http://observedchange.com/tisc/ns#far"></see></summary>
    let far = _prefix "far"
    /// <summary>
    /// forecastMadeAt is an abstract property to express that an object is forecast made at certain time.
    /// <see href="http://observedchange.com/tisc/ns#forecastMadeAt"></see></summary>
    let forecastMadeAt = _prefix "forecastMadeAt"
    /// <summary>
    /// geometry is an abstract property to express that an object has certain geometry.
    /// <see href="http://observedchange.com/tisc/ns#geometry"></see></summary>
    let geometry = _prefix "geometry"
    /// <summary>
    /// happensAt is a predicate to state when something happens (for example an event such as a concert).
    /// <see href="http://observedchange.com/tisc/ns#happensAt"></see></summary>
    let happensAt = _prefix "happensAt"
    /// <summary>
    /// hasCentroid is an abstract property to express the location of the centroid of an area feature.
    ///
    /// <see href="http://observedchange.com/tisc/ns#hasCentroid"></see></summary>
    let hasCentroid = _prefix "hasCentroid"
    /// <summary>
    /// hasHeight is an abstract property to express that an object has certain height.
    /// <see href="http://observedchange.com/tisc/ns#hasHeight"></see></summary>
    let hasHeight = _prefix "hasHeight"
    /// <summary>
    /// hasLength is an abstract property to express that an object has certain length.
    /// <see href="http://observedchange.com/tisc/ns#hasLength"></see></summary>
    let hasLength = _prefix "hasLength"
    /// <summary>
    /// hasUnionOf is an abstract property to express which union an object (or region) belongs to.
    /// <see href="http://observedchange.com/tisc/ns#hasUnionOf"></see></summary>
    let hasUnionOf = _prefix "hasUnionOf"
    /// <summary>
    /// hasWidth is an abstract property to express that an object has certain width.
    /// <see href="http://observedchange.com/tisc/ns#hasWidth"></see></summary>
    let hasWidth = _prefix "hasWidth"
    /// <summary>
    /// here is an abstract property to express that an object is at the same place as another.
    /// <see href="http://observedchange.com/tisc/ns#here"></see></summary>
    let here = _prefix "here"
    /// <summary>
    /// inFutureOf is an abstract property to express that an object is in future of another.
    /// <see href="http://observedchange.com/tisc/ns#inFutureOf"></see></summary>
    let inFutureOf = _prefix "inFutureOf"
    /// <summary>
    /// inPastOf is an abstract property to express that an object is in past of another.
    /// <see href="http://observedchange.com/tisc/ns#inPastOf"></see></summary>
    let inPastOf = _prefix "inPastOf"
    /// <summary>
    /// insideOf is an abstract property to express that an object is inside of another.
    /// <see href="http://observedchange.com/tisc/ns#insideOf"></see></summary>
    let insideOf = _prefix "insideOf"
    /// <summary>
    /// isForecastFor is an abstract property to express that an object is a forecast for a certain time.
    /// <see href="http://observedchange.com/tisc/ns#isForecastFor"></see></summary>
    let isForecastFor = _prefix "isForecastFor"
    /// <summary>
    /// leftOf is an abstract property to express that an object is to the left from another.
    /// <see href="http://observedchange.com/tisc/ns#leftOf"></see></summary>
    let leftOf = _prefix "leftOf"
    /// <summary>
    /// rightOf is an abstract property to express that an object is to the right from another.
    /// <see href="http://observedchange.com/tisc/ns#rightOf"></see></summary>
    let rightOf = _prefix "rightOf"
    /// <summary>
    /// locatedAt is an abstract property to express that an object is located at somewhere.
    /// <see href="http://observedchange.com/tisc/ns#locatedAt"></see></summary>
    let locatedAt = _prefix "locatedAt"
    /// <summary>
    /// near is an abstract property to express that an object is near to another.
    /// <see href="http://observedchange.com/tisc/ns#near"></see></summary>
    let near = _prefix "near"
    /// <summary>
    /// nearest is an abstract property to express that an object is nearest to another.
    /// <see href="http://observedchange.com/tisc/ns#nearest"></see></summary>
    let nearest = _prefix "nearest"
    /// <summary>
    /// next is an abstract property to express that an object is a next object in the order, for example to state the
    /// logical ordering of metro stations or bus stops, i.e. like in "next metro station from Victoria is Sloane Square". However, as such next is ambiguous as also "next metro station from Victoria is St James's Park" would be valid. This can be solved by e.g. having two instances of Victoria station for each direction, or using some similar type of mechanism. Note also that next is different from nextTo.
    /// <see href="http://observedchange.com/tisc/ns#next"></see></summary>
    let next = _prefix "next"
    /// <summary>
    /// nextTo is an abstract property to express that an object is next to another.
    /// <see href="http://observedchange.com/tisc/ns#nextTo"></see></summary>
    let nextTo = _prefix "nextTo"
    /// <summary>
    /// nonTangentialProperPart is an abstract property to express that an object is non tangential proper part of another.
    /// <see href="http://observedchange.com/tisc/ns#nonTangentialProperPart"></see></summary>
    let nonTangentialProperPart = _prefix "nonTangentialProperPart"
    /// <summary>
    /// northEastOf is an abstract property to express that an object is Northeast of another.
    /// <see href="http://observedchange.com/tisc/ns#northEastOf"></see></summary>
    let northEastOf = _prefix "northEastOf"
    /// <summary>
    /// northOf is an abstract property to express that an object is North of another.
    /// <see href="http://observedchange.com/tisc/ns#northOf"></see></summary>
    let northOf = _prefix "northOf"
    /// <summary>
    /// northWestOf is an abstract property to express that an object is Northwest of another.
    /// <see href="http://observedchange.com/tisc/ns#northWestOf"></see></summary>
    let northWestOf = _prefix "northWestOf"
    /// <summary>
    /// outsideOf is an abstract property to express that an object is outside of another.
    /// <see href="http://observedchange.com/tisc/ns#outsideOf"></see></summary>
    let outsideOf = _prefix "outsideOf"
    /// <summary>
    /// partialOverlapArea is an abstract property to express the overlaping area of two things in a PartialOverlap. The area units can be stated with partialOverlapUnit.
    ///
    /// <see href="http://observedchange.com/tisc/ns#partialOverlapArea"></see></summary>
    let partialOverlapArea = _prefix "partialOverlapArea"
    /// <summary>
    /// partialOverlapFrom is an abstract property to express the first object that takes part in a PartialOverlap.
    ///
    /// <see href="http://observedchange.com/tisc/ns#partialOverlapFrom"></see></summary>
    let partialOverlapFrom = _prefix "partialOverlapFrom"
    /// <summary>
    /// partialOverlapRatio is an abstract property to express the ratio of dividing the partialOverlapArea by the area of the object pointed by partialOverlapFrom.
    ///
    /// <see href="http://observedchange.com/tisc/ns#partialOverlapRatio"></see></summary>
    let partialOverlapRatio = _prefix "partialOverlapRatio"
    /// <summary>
    /// partialOverlapTo is an abstract property to express the second object that takes part in a PartialOverlap.
    ///
    /// <see href="http://observedchange.com/tisc/ns#partialOverlapTo"></see></summary>
    let partialOverlapTo = _prefix "partialOverlapTo"
    /// <summary>
    /// partialOverlapUnit is an abstract property to express the units of partialOverlapArea of two things in a PartialOverlap.
    ///
    /// <see href="http://observedchange.com/tisc/ns#partialOverlapUnit"></see></summary>
    let partialOverlapUnit = _prefix "partialOverlapUnit"
    /// <summary>
    /// partiallyOverlapping is an abstract property to express that an object is partially overlapping with another.
    /// <see href="http://observedchange.com/tisc/ns#partiallyOverlapping"></see></summary>
    let partiallyOverlapping = _prefix "partiallyOverlapping"
    /// <summary>
    /// sharesPathWith is an abstract property to express that an object shares a path with another.
    /// <see href="http://observedchange.com/tisc/ns#sharesPathWith"></see></summary>
    let sharesPathWith = _prefix "sharesPathWith"
    /// <summary>
    /// sizeOfLandArea is an abstract property to express the size of the land area of a region.
    /// <see href="http://observedchange.com/tisc/ns#sizeOfLandArea"></see></summary>
    let sizeOfLandArea = _prefix "sizeOfLandArea"
    /// <summary>
    /// southEastOf is an abstract property to express that an object is Southeast of another.
    /// <see href="http://observedchange.com/tisc/ns#southEastOf"></see></summary>
    let southEastOf = _prefix "southEastOf"
    /// <summary>
    /// southOf is an abstract property to express that an object is South of another.
    /// <see href="http://observedchange.com/tisc/ns#southOf"></see></summary>
    let southOf = _prefix "southOf"
    /// <summary>
    /// southWestOf is an abstract property to express that an object is Southwest of another.
    /// <see href="http://observedchange.com/tisc/ns#southWestOf"></see></summary>
    let southWestOf = _prefix "southWestOf"
    /// <summary>
    /// tangentialProperPart is an abstract property to express that an object is tangential proper part of another.
    /// <see href="http://observedchange.com/tisc/ns#tangentialProperPart"></see></summary>
    let tangentialProperPart = _prefix "tangentialProperPart"
    /// <summary>
    /// touches is an abstract property to express that a region touches another region.
    /// <see href="http://observedchange.com/tisc/ns#touches"></see></summary>
    let touches = _prefix "touches"
    /// <summary>
    /// unionOf is an abstract property to express which union a spatiotemporal region forms.
    /// <see href="http://observedchange.com/tisc/ns#unionOf"></see></summary>
    let unionOf = _prefix "unionOf"
    /// <summary>
    /// westOf is an abstract property to express that an object is West of another.
    /// <see href="http://observedchange.com/tisc/ns#westOf"></see></summary>
    let westOf = _prefix "westOf"
