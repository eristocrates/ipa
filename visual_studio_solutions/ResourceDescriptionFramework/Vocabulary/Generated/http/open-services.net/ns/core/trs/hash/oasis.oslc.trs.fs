namespace Oasis.oslc.trs.Namespace
module trs =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://open-services.net/ns/core/trs#" (Some "https://docs.oasis-open-projects.org/oslc-op/trs/v3.0/os/trs-vocab.ttl") (Some "oasis.oslc.trs") None
    let Base = {_prefixID with _localName = "Base"}
    let ChangeLog = {_prefixID with _localName = "ChangeLog"}
    let Creation = {_prefixID with _localName = "Creation"}
    let Deletion = {_prefixID with _localName = "Deletion"}
    let Modification = {_prefixID with _localName = "Modification"}
    let TrackedResourceSet = {_prefixID with _localName = "TrackedResourceSet"}
    let ``base`` = {_prefixID with _localName = "base"}
    let change = {_prefixID with _localName = "change"}
    let changeLog = {_prefixID with _localName = "changeLog"}
    let changed = {_prefixID with _localName = "changed"}
    let cutoffEvent = {_prefixID with _localName = "cutoffEvent"}
    let order = {_prefixID with _localName = "order"}
    let previous = {_prefixID with _localName = "previous"}
    let trackedResourceSet = {_prefixID with _localName = "trackedResourceSet"}