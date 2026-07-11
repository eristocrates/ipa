namespace Oasis.oslc.trs.patch.Namespace
module patch =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://open-services.net/ns/core/trspatch#" (Some "https://docs.oasis-open-projects.org/oslc-op/trs/v3.0/os/trs-vocab.ttl") (Some "oasis.oslc.trs.patch") None
    let afterETag = {_prefixID with _localName = "afterETag"}
    let beforeETag = {_prefixID with _localName = "beforeETag"}
    let createdFrom = {_prefixID with _localName = "createdFrom"}
    let rdfPatch = {_prefixID with _localName = "rdfPatch"}