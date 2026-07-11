namespace Olo.Namespace
module olo =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/ontology/olo/core#" (Some "https://github.com/smiy/orderedlistonto/raw/refs/heads/master/rdf/orderedlistontology.n3") (Some "olo") None
    let OrderedList = {_prefixID with _localName = "OrderedList"}
    let Slot = {_prefixID with _localName = "Slot"}
    let index = {_prefixID with _localName = "index"}
    let item = {_prefixID with _localName = "item"}
    let length = {_prefixID with _localName = "length"}
    let next = {_prefixID with _localName = "next"}
    let ordered_list = {_prefixID with _localName = "ordered_list"}
    let previous = {_prefixID with _localName = "previous"}
    let slot = {_prefixID with _localName = "slot"}