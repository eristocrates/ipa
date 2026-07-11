namespace Swap.pim.travelTerms.Namespace
module travelTerms =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/pim/travelTerms#" (Some "http://www.w3.org/2000/10/swap/pim/travelTerms") (Some "swap.pim.travelTerms") None
    let ``0_work`` = {_prefixID with _localName = "0_work"}
    let Flight = {_prefixID with _localName = "Flight"}
    let TimeString = {_prefixID with _localName = "TimeString"}
    let _g0 = {_prefixID with _localName = "_g0"}
    let arrivalTime = {_prefixID with _localName = "arrivalTime"}
    let carrier = {_prefixID with _localName = "carrier"}
    let departureTime = {_prefixID with _localName = "departureTime"}
    let flightNumber = {_prefixID with _localName = "flightNumber"}