namespace Acp.Namespace
module acp =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/solid/acp#" (Some "http://www.w3.org/ns/solid/acp#") (Some "acp") None
    let AccessControl = {_prefixID with _localName = "AccessControl"}
    let AccessControlResource = {_prefixID with _localName = "AccessControlResource"}
    let AccessGrant = {_prefixID with _localName = "AccessGrant"}
    let AccessMode = {_prefixID with _localName = "AccessMode"}
    let AlwaysSatisfiedRestriction = {_prefixID with _localName = "AlwaysSatisfiedRestriction"}
    let AuthenticatedAgent = {_prefixID with _localName = "AuthenticatedAgent"}
    let Context = {_prefixID with _localName = "Context"}
    let CreatorAgent = {_prefixID with _localName = "CreatorAgent"}
    let Matcher = {_prefixID with _localName = "Matcher"}
    let OwnerAgent = {_prefixID with _localName = "OwnerAgent"}
    let Policy = {_prefixID with _localName = "Policy"}
    let PublicAgent = {_prefixID with _localName = "PublicAgent"}
    let PublicClient = {_prefixID with _localName = "PublicClient"}
    let PublicIssuer = {_prefixID with _localName = "PublicIssuer"}
    let accessControl = {_prefixID with _localName = "accessControl"}
    let accessControlResource = {_prefixID with _localName = "accessControlResource"}
    let agent = {_prefixID with _localName = "agent"}
    let allOf = {_prefixID with _localName = "allOf"}
    let allow = {_prefixID with _localName = "allow"}
    let anyOf = {_prefixID with _localName = "anyOf"}
    let apply = {_prefixID with _localName = "apply"}
    let attribute = {_prefixID with _localName = "attribute"}
    let client = {_prefixID with _localName = "client"}
    let context = {_prefixID with _localName = "context"}
    let creator = {_prefixID with _localName = "creator"}
    let deny = {_prefixID with _localName = "deny"}
    let grant = {_prefixID with _localName = "grant"}
    let issuer = {_prefixID with _localName = "issuer"}
    let memberAccessControl = {_prefixID with _localName = "memberAccessControl"}
    let mode = {_prefixID with _localName = "mode"}
    let noneOf = {_prefixID with _localName = "noneOf"}
    let owner = {_prefixID with _localName = "owner"}
    let resource = {_prefixID with _localName = "resource"}
    let target = {_prefixID with _localName = "target"}
    let vc = {_prefixID with _localName = "vc"}