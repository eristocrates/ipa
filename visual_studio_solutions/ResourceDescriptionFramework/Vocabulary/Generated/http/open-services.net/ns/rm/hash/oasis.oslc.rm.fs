namespace Oasis.oslc.rm.Namespace
module rm =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://open-services.net/ns/rm#" (Some "https://docs.oasis-open-projects.org/oslc-op/rm/v2.1/os/requirements-management-vocab.ttl") (Some "oasis.oslc.rm") None
    let Requirement = {_prefixID with _localName = "Requirement"}
    let RequirementCollection = {_prefixID with _localName = "RequirementCollection"}
    let affectedBy = {_prefixID with _localName = "affectedBy"}
    let constrainedBy = {_prefixID with _localName = "constrainedBy"}
    let constrains = {_prefixID with _localName = "constrains"}
    let decomposedBy = {_prefixID with _localName = "decomposedBy"}
    let decomposes = {_prefixID with _localName = "decomposes"}
    let elaboratedBy = {_prefixID with _localName = "elaboratedBy"}
    let elaborates = {_prefixID with _localName = "elaborates"}
    let implementedBy = {_prefixID with _localName = "implementedBy"}
    let satisfiedBy = {_prefixID with _localName = "satisfiedBy"}
    let satisfies = {_prefixID with _localName = "satisfies"}
    let specifiedBy = {_prefixID with _localName = "specifiedBy"}
    let specifies = {_prefixID with _localName = "specifies"}
    let trackedBy = {_prefixID with _localName = "trackedBy"}
    let uses = {_prefixID with _localName = "uses"}
    let validatedBy = {_prefixID with _localName = "validatedBy"}