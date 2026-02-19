namespace Swap.organization.Namespace
module organization =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/organization#" (Some "http://eulersharp.sourceforge.net/2003/03swap/organization") (Some "swap.organization") None
    let Company = {_prefixID with _localName = "Company"}
    let Department = {_prefixID with _localName = "Department"}
    let Enterprise = {_prefixID with _localName = "Enterprise"}
    let LegalPerson = {_prefixID with _localName = "LegalPerson"}
    let University = {_prefixID with _localName = "University"}
    let hasSeat = {_prefixID with _localName = "hasSeat"}