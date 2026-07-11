namespace Swan.collections.Namespace
module collections =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/swan/2.0/collections/" (Some "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/collections.owl") (Some "swan.collections") None
    let Bag = {_prefixID with _localName = "Bag"}
    let Collection = {_prefixID with _localName = "Collection"}
    let Item = {_prefixID with _localName = "Item"}
    let List = {_prefixID with _localName = "List"}
    let ListItem = {_prefixID with _localName = "ListItem"}
    let Set = {_prefixID with _localName = "Set"}
    let element = {_prefixID with _localName = "element"}
    let firstItem = {_prefixID with _localName = "firstItem"}
    let followedBy = {_prefixID with _localName = "followedBy"}
    let item = {_prefixID with _localName = "item"}
    let itemContent = {_prefixID with _localName = "itemContent"}
    let lastItem = {_prefixID with _localName = "lastItem"}
    let nextItem = {_prefixID with _localName = "nextItem"}
    let preceededBy = {_prefixID with _localName = "preceededBy"}
    let previousItem = {_prefixID with _localName = "previousItem"}
    let size = {_prefixID with _localName = "size"}