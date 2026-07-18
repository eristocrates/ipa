namespace http.observedchange.com.tisc.ns.hash

open DoxAletheia.Rdf_Vocabulary

module tisc =
    let _namespace_name = "http://observedchange.com/tisc/ns#"
    /// <summary>
    /// Object is (some)thing located in space and time.
    ///
    /// <see href="http://observedchange.com/tisc/ns#Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName

    /// <summary>
    /// PartialOverlap is a class which allows instantiating characteristics of a partial overlap.
    ///
    /// <see href="http://observedchange.com/tisc/ns#PartialOverlap"></see></summary>
    let PartialOverlap =
        Namespaced_IRI.parse _namespace_name "PartialOverlap" |> NamespacedName

    /// <summary>
    /// address is an abstract property to express that an object has some address.
    /// <see href="http://observedchange.com/tisc/ns#address"></see></summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName
    /// <summary>
    /// along is an abstract property to express that an object is along another, for example "a group of houses along by the river".
    /// <see href="http://observedchange.com/tisc/ns#along"></see></summary>
    let along = Namespaced_IRI.parse _namespace_name "along" |> NamespacedName
    /// <summary>
    /// areasize is an abstract property to express the size of the area of an object.
    /// <see href="http://observedchange.com/tisc/ns#areasize"></see></summary>
    let areasize = Namespaced_IRI.parse _namespace_name "areasize" |> NamespacedName
    /// <summary>
    /// atFrontOf is an abstract property to express that an object is at front of another.
    /// <see href="http://observedchange.com/tisc/ns#atFrontOf"></see></summary>
    let atFrontOf = Namespaced_IRI.parse _namespace_name "atFrontOf" |> NamespacedName
    /// <summary>
    /// behind is an abstract property to express that an object is behind another.
    /// <see href="http://observedchange.com/tisc/ns#behind"></see></summary>
    let behind = Namespaced_IRI.parse _namespace_name "behind" |> NamespacedName

    /// <summary>
    /// disconnected is an abstract property to express that an object is disconnected from another.
    /// <see href="http://observedchange.com/tisc/ns#disconnected"></see></summary>
    let disconnected =
        Namespaced_IRI.parse _namespace_name "disconnected" |> NamespacedName

    /// <summary>
    /// eastOf is an abstract property to express that an object is East of another.
    /// <see href="http://observedchange.com/tisc/ns#eastOf"></see></summary>
    let eastOf = Namespaced_IRI.parse _namespace_name "eastOf" |> NamespacedName
    /// <summary>
    /// equal is an abstract property to express that an object is equal with another.
    /// <see href="http://observedchange.com/tisc/ns#equal"></see></summary>
    let equal = Namespaced_IRI.parse _namespace_name "equal" |> NamespacedName

    /// <summary>
    /// existenceBeginsAt is an abstract property to express that the existence of an object begins at a given time instant.
    /// <see href="http://observedchange.com/tisc/ns#existenceBeginsAt"></see></summary>
    let existenceBeginsAt =
        Namespaced_IRI.parse _namespace_name "existenceBeginsAt" |> NamespacedName

    /// <summary>
    /// existenceEndsAt is an abstract property to express that the existence of an object ends at a given time instant.
    /// <see href="http://observedchange.com/tisc/ns#existenceEndsAt"></see></summary>
    let existenceEndsAt =
        Namespaced_IRI.parse _namespace_name "existenceEndsAt" |> NamespacedName

    /// <summary>
    /// externallyConnected is an abstract property to express that an object is externally connected with another.
    /// <see href="http://observedchange.com/tisc/ns#externallyConnected"></see></summary>
    let externallyConnected =
        Namespaced_IRI.parse _namespace_name "externallyConnected" |> NamespacedName

    /// <summary>
    /// far is an abstract property to express that an object is far from another.
    /// <see href="http://observedchange.com/tisc/ns#far"></see></summary>
    let far = Namespaced_IRI.parse _namespace_name "far" |> NamespacedName

    /// <summary>
    /// forecastMadeAt is an abstract property to express that an object is forecast made at certain time.
    /// <see href="http://observedchange.com/tisc/ns#forecastMadeAt"></see></summary>
    let forecastMadeAt =
        Namespaced_IRI.parse _namespace_name "forecastMadeAt" |> NamespacedName

    /// <summary>
    /// geometry is an abstract property to express that an object has certain geometry.
    /// <see href="http://observedchange.com/tisc/ns#geometry"></see></summary>
    let geometry = Namespaced_IRI.parse _namespace_name "geometry" |> NamespacedName
    /// <summary>
    /// happensAt is a predicate to state when something happens (for example an event such as a concert).
    /// <see href="http://observedchange.com/tisc/ns#happensAt"></see></summary>
    let happensAt = Namespaced_IRI.parse _namespace_name "happensAt" |> NamespacedName

    /// <summary>
    /// hasCentroid is an abstract property to express the location of the centroid of an area feature.
    ///
    /// <see href="http://observedchange.com/tisc/ns#hasCentroid"></see></summary>
    let hasCentroid =
        Namespaced_IRI.parse _namespace_name "hasCentroid" |> NamespacedName

    /// <summary>
    /// hasHeight is an abstract property to express that an object has certain height.
    /// <see href="http://observedchange.com/tisc/ns#hasHeight"></see></summary>
    let hasHeight = Namespaced_IRI.parse _namespace_name "hasHeight" |> NamespacedName
    /// <summary>
    /// hasLength is an abstract property to express that an object has certain length.
    /// <see href="http://observedchange.com/tisc/ns#hasLength"></see></summary>
    let hasLength = Namespaced_IRI.parse _namespace_name "hasLength" |> NamespacedName
    /// <summary>
    /// hasUnionOf is an abstract property to express which union an object (or region) belongs to.
    /// <see href="http://observedchange.com/tisc/ns#hasUnionOf"></see></summary>
    let hasUnionOf = Namespaced_IRI.parse _namespace_name "hasUnionOf" |> NamespacedName
    /// <summary>
    /// hasWidth is an abstract property to express that an object has certain width.
    /// <see href="http://observedchange.com/tisc/ns#hasWidth"></see></summary>
    let hasWidth = Namespaced_IRI.parse _namespace_name "hasWidth" |> NamespacedName
    /// <summary>
    /// here is an abstract property to express that an object is at the same place as another.
    /// <see href="http://observedchange.com/tisc/ns#here"></see></summary>
    let here = Namespaced_IRI.parse _namespace_name "here" |> NamespacedName
    /// <summary>
    /// inFutureOf is an abstract property to express that an object is in future of another.
    /// <see href="http://observedchange.com/tisc/ns#inFutureOf"></see></summary>
    let inFutureOf = Namespaced_IRI.parse _namespace_name "inFutureOf" |> NamespacedName
    /// <summary>
    /// inPastOf is an abstract property to express that an object is in past of another.
    /// <see href="http://observedchange.com/tisc/ns#inPastOf"></see></summary>
    let inPastOf = Namespaced_IRI.parse _namespace_name "inPastOf" |> NamespacedName
    /// <summary>
    /// insideOf is an abstract property to express that an object is inside of another.
    /// <see href="http://observedchange.com/tisc/ns#insideOf"></see></summary>
    let insideOf = Namespaced_IRI.parse _namespace_name "insideOf" |> NamespacedName

    /// <summary>
    /// isForecastFor is an abstract property to express that an object is a forecast for a certain time.
    /// <see href="http://observedchange.com/tisc/ns#isForecastFor"></see></summary>
    let isForecastFor =
        Namespaced_IRI.parse _namespace_name "isForecastFor" |> NamespacedName

    /// <summary>
    /// leftOf is an abstract property to express that an object is to the left from another.
    /// <see href="http://observedchange.com/tisc/ns#leftOf"></see></summary>
    let leftOf = Namespaced_IRI.parse _namespace_name "leftOf" |> NamespacedName
    /// <summary>
    /// rightOf is an abstract property to express that an object is to the right from another.
    /// <see href="http://observedchange.com/tisc/ns#rightOf"></see></summary>
    let rightOf = Namespaced_IRI.parse _namespace_name "rightOf" |> NamespacedName
    /// <summary>
    /// locatedAt is an abstract property to express that an object is located at somewhere.
    /// <see href="http://observedchange.com/tisc/ns#locatedAt"></see></summary>
    let locatedAt = Namespaced_IRI.parse _namespace_name "locatedAt" |> NamespacedName
    /// <summary>
    /// near is an abstract property to express that an object is near to another.
    /// <see href="http://observedchange.com/tisc/ns#near"></see></summary>
    let near = Namespaced_IRI.parse _namespace_name "near" |> NamespacedName
    /// <summary>
    /// nearest is an abstract property to express that an object is nearest to another.
    /// <see href="http://observedchange.com/tisc/ns#nearest"></see></summary>
    let nearest = Namespaced_IRI.parse _namespace_name "nearest" |> NamespacedName
    /// <summary>
    /// next is an abstract property to express that an object is a next object in the order, for example to state the
    /// logical ordering of metro stations or bus stops, i.e. like in "next metro station from Victoria is Sloane Square". However, as such next is ambiguous as also "next metro station from Victoria is St James's Park" would be valid. This can be solved by e.g. having two instances of Victoria station for each direction, or using some similar type of mechanism. Note also that next is different from nextTo.
    /// <see href="http://observedchange.com/tisc/ns#next"></see></summary>
    let next = Namespaced_IRI.parse _namespace_name "next" |> NamespacedName
    /// <summary>
    /// nextTo is an abstract property to express that an object is next to another.
    /// <see href="http://observedchange.com/tisc/ns#nextTo"></see></summary>
    let nextTo = Namespaced_IRI.parse _namespace_name "nextTo" |> NamespacedName

    /// <summary>
    /// nonTangentialProperPart is an abstract property to express that an object is non tangential proper part of another.
    /// <see href="http://observedchange.com/tisc/ns#nonTangentialProperPart"></see></summary>
    let nonTangentialProperPart =
        Namespaced_IRI.parse _namespace_name "nonTangentialProperPart" |> NamespacedName

    /// <summary>
    /// northEastOf is an abstract property to express that an object is Northeast of another.
    /// <see href="http://observedchange.com/tisc/ns#northEastOf"></see></summary>
    let northEastOf =
        Namespaced_IRI.parse _namespace_name "northEastOf" |> NamespacedName

    /// <summary>
    /// northOf is an abstract property to express that an object is North of another.
    /// <see href="http://observedchange.com/tisc/ns#northOf"></see></summary>
    let northOf = Namespaced_IRI.parse _namespace_name "northOf" |> NamespacedName

    /// <summary>
    /// northWestOf is an abstract property to express that an object is Northwest of another.
    /// <see href="http://observedchange.com/tisc/ns#northWestOf"></see></summary>
    let northWestOf =
        Namespaced_IRI.parse _namespace_name "northWestOf" |> NamespacedName

    /// <summary>
    /// outsideOf is an abstract property to express that an object is outside of another.
    /// <see href="http://observedchange.com/tisc/ns#outsideOf"></see></summary>
    let outsideOf = Namespaced_IRI.parse _namespace_name "outsideOf" |> NamespacedName

    /// <summary>
    /// partialOverlapArea is an abstract property to express the overlaping area of two things in a PartialOverlap. The area units can be stated with partialOverlapUnit.
    ///
    /// <see href="http://observedchange.com/tisc/ns#partialOverlapArea"></see></summary>
    let partialOverlapArea =
        Namespaced_IRI.parse _namespace_name "partialOverlapArea" |> NamespacedName

    /// <summary>
    /// partialOverlapFrom is an abstract property to express the first object that takes part in a PartialOverlap.
    ///
    /// <see href="http://observedchange.com/tisc/ns#partialOverlapFrom"></see></summary>
    let partialOverlapFrom =
        Namespaced_IRI.parse _namespace_name "partialOverlapFrom" |> NamespacedName

    /// <summary>
    /// partialOverlapRatio is an abstract property to express the ratio of dividing the partialOverlapArea by the area of the object pointed by partialOverlapFrom.
    ///
    /// <see href="http://observedchange.com/tisc/ns#partialOverlapRatio"></see></summary>
    let partialOverlapRatio =
        Namespaced_IRI.parse _namespace_name "partialOverlapRatio" |> NamespacedName

    /// <summary>
    /// partialOverlapTo is an abstract property to express the second object that takes part in a PartialOverlap.
    ///
    /// <see href="http://observedchange.com/tisc/ns#partialOverlapTo"></see></summary>
    let partialOverlapTo =
        Namespaced_IRI.parse _namespace_name "partialOverlapTo" |> NamespacedName

    /// <summary>
    /// partialOverlapUnit is an abstract property to express the units of partialOverlapArea of two things in a PartialOverlap.
    ///
    /// <see href="http://observedchange.com/tisc/ns#partialOverlapUnit"></see></summary>
    let partialOverlapUnit =
        Namespaced_IRI.parse _namespace_name "partialOverlapUnit" |> NamespacedName

    /// <summary>
    /// partiallyOverlapping is an abstract property to express that an object is partially overlapping with another.
    /// <see href="http://observedchange.com/tisc/ns#partiallyOverlapping"></see></summary>
    let partiallyOverlapping =
        Namespaced_IRI.parse _namespace_name "partiallyOverlapping" |> NamespacedName

    /// <summary>
    /// sharesPathWith is an abstract property to express that an object shares a path with another.
    /// <see href="http://observedchange.com/tisc/ns#sharesPathWith"></see></summary>
    let sharesPathWith =
        Namespaced_IRI.parse _namespace_name "sharesPathWith" |> NamespacedName

    /// <summary>
    /// sizeOfLandArea is an abstract property to express the size of the land area of a region.
    /// <see href="http://observedchange.com/tisc/ns#sizeOfLandArea"></see></summary>
    let sizeOfLandArea =
        Namespaced_IRI.parse _namespace_name "sizeOfLandArea" |> NamespacedName

    /// <summary>
    /// southEastOf is an abstract property to express that an object is Southeast of another.
    /// <see href="http://observedchange.com/tisc/ns#southEastOf"></see></summary>
    let southEastOf =
        Namespaced_IRI.parse _namespace_name "southEastOf" |> NamespacedName

    /// <summary>
    /// southOf is an abstract property to express that an object is South of another.
    /// <see href="http://observedchange.com/tisc/ns#southOf"></see></summary>
    let southOf = Namespaced_IRI.parse _namespace_name "southOf" |> NamespacedName

    /// <summary>
    /// southWestOf is an abstract property to express that an object is Southwest of another.
    /// <see href="http://observedchange.com/tisc/ns#southWestOf"></see></summary>
    let southWestOf =
        Namespaced_IRI.parse _namespace_name "southWestOf" |> NamespacedName

    /// <summary>
    /// tangentialProperPart is an abstract property to express that an object is tangential proper part of another.
    /// <see href="http://observedchange.com/tisc/ns#tangentialProperPart"></see></summary>
    let tangentialProperPart =
        Namespaced_IRI.parse _namespace_name "tangentialProperPart" |> NamespacedName

    /// <summary>
    /// touches is an abstract property to express that a region touches another region.
    /// <see href="http://observedchange.com/tisc/ns#touches"></see></summary>
    let touches = Namespaced_IRI.parse _namespace_name "touches" |> NamespacedName
    /// <summary>
    /// unionOf is an abstract property to express which union a spatiotemporal region forms.
    /// <see href="http://observedchange.com/tisc/ns#unionOf"></see></summary>
    let unionOf = Namespaced_IRI.parse _namespace_name "unionOf" |> NamespacedName
    /// <summary>
    /// westOf is an abstract property to express that an object is West of another.
    /// <see href="http://observedchange.com/tisc/ns#westOf"></see></summary>
    let westOf = Namespaced_IRI.parse _namespace_name "westOf" |> NamespacedName
