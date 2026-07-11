namespace Swap.pim.usps.Namespace
module usps =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/pim/usps#" (Some "http://www.w3.org/2000/10/swap/pim/usps") (Some "swap.pim.usps") None
    let City = {_prefixID with _localName = "City"}
    let MailPiece = {_prefixID with _localName = "MailPiece"}
    let MailingLocation = {_prefixID with _localName = "MailingLocation"}
    let PostOffice = {_prefixID with _localName = "PostOffice"}
    let PostmarkProperty = {_prefixID with _localName = "PostmarkProperty"}
    let State = {_prefixID with _localName = "State"}
    let at = {_prefixID with _localName = "at"}
    let cityName = {_prefixID with _localName = "cityName"}
    let deliveryAddress = {_prefixID with _localName = "deliveryAddress"}
    let from = {_prefixID with _localName = "from"}
    let postmark = {_prefixID with _localName = "postmark"}
    let returnAt = {_prefixID with _localName = "returnAt"}
    let returnTo = {_prefixID with _localName = "returnTo"}
    let stateAbbr = {_prefixID with _localName = "stateAbbr"}
    let ``to`` = {_prefixID with _localName = "to"}
    let zipCode = {_prefixID with _localName = "zipCode"}