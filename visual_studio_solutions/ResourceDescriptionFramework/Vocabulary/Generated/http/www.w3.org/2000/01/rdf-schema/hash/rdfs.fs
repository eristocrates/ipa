namespace Rdfs.Namespace
module rdfs =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/01/rdf-schema#" (Some "http://www.w3.org/2000/01/rdf-schema#") (Some "rdfs") None
    let Class = {_prefixID with _localName = "Class"}
    let Container = {_prefixID with _localName = "Container"}
    let ContainerMembershipProperty = {_prefixID with _localName = "ContainerMembershipProperty"}
    let Datatype = {_prefixID with _localName = "Datatype"}
    let Literal = {_prefixID with _localName = "Literal"}
    let Resource = {_prefixID with _localName = "Resource"}
    let comment = {_prefixID with _localName = "comment"}
    let domain = {_prefixID with _localName = "domain"}
    let isDefinedBy = {_prefixID with _localName = "isDefinedBy"}
    let label = {_prefixID with _localName = "label"}
    let ``member`` = {_prefixID with _localName = "member"}
    let range = {_prefixID with _localName = "range"}
    let seeAlso = {_prefixID with _localName = "seeAlso"}
    let subClassOf = {_prefixID with _localName = "subClassOf"}
    let subPropertyOf = {_prefixID with _localName = "subPropertyOf"}