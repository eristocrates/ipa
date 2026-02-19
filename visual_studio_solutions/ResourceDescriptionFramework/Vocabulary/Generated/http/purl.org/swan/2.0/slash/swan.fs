namespace Swan.Namespace
module swan =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/swan/2.0/" (Some "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/swan.owl") (Some "swan") None
    let agents = {_prefixID with _localName = "agents"}
    let ``discourse-elements`` = {_prefixID with _localName = "discourse-elements"}
    let ``discourse-relationships`` = {_prefixID with _localName = "discourse-relationships"}