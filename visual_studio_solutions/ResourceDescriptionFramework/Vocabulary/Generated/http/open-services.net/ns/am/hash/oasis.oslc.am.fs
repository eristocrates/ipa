namespace Oasis.oslc.am.Namespace
module am =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://open-services.net/ns/am#" (Some "https://docs.oasis-open-projects.org/oslc-op/am/v3.0/os/architecture-management-vocab.ttl") (Some "oasis.oslc.am") None
    let LinkType = {_prefixID with _localName = "LinkType"}
    let Resource = {_prefixID with _localName = "Resource"}