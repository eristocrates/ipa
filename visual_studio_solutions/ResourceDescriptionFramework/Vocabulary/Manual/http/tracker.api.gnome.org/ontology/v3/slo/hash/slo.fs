namespace Nepomuk.slo.v3.Namespace

module slo =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://tracker.api.gnome.org/ontology/v3/slo#"
            (Some "https://gitlab.gnome.org/GNOME/tinysparql/-/raw/main/src/ontologies/nepomuk/92-slo.ontology")
            (Some "nepomuk.slo.v3")
            None

    let LandmarkCategory = { _prefixID with _localName = "LandmarkCategory" }
    let isRemovable = { _prefixID with _localName = "isRemovable" }
    let categoryIconUrl = { _prefixID with _localName = "categoryIconUrl" }
    let Landmark = { _prefixID with _localName = "Landmark" }
    let belongsToCategory = { _prefixID with _localName = "belongsToCategory" }
    let hasContact = { _prefixID with _localName = "hasContact" }
    let iconUrl = { _prefixID with _localName = "iconUrl" }
    let GeoLocation = { _prefixID with _localName = "GeoLocation" }
    let latitude = { _prefixID with _localName = "latitude" }
    let longitude = { _prefixID with _localName = "longitude" }
    let verticalAccuracy = { _prefixID with _localName = "verticalAccuracy" }
    let horizontalAccuracy = { _prefixID with _localName = "horizontalAccuracy" }
    let altitude = { _prefixID with _localName = "altitude" }
    let boundingLatitudeMin = { _prefixID with _localName = "boundingLatitudeMin" }
    let boundingLatitudeMax = { _prefixID with _localName = "boundingLatitudeMax" }
    let boundingLongitudeMin = { _prefixID with _localName = "boundingLongitudeMin" }
    let boundingLongitudeMax = { _prefixID with _localName = "boundingLongitudeMax" }
    let radius = { _prefixID with _localName = "radius" }
    let timestamp = { _prefixID with _localName = "timestamp" }
    let postalAddress = { _prefixID with _localName = "postalAddress" }
    let location = { _prefixID with _localName = "location" }
    let Route = { _prefixID with _localName = "Route" }
    let startTime = { _prefixID with _localName = "startTime" }
    let endTime = { _prefixID with _localName = "endTime" }
    let routeDetails = { _prefixID with _localName = "routeDetails" }
