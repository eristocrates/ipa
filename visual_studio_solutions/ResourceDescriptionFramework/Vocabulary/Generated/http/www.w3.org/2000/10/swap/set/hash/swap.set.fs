namespace Swap.set.Namespace
module set =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/set#" (Some "http://www.w3.org/2000/10/swap/set") (Some "swap.set") None
    let difference = {_prefixID with _localName = "difference"}
    let ``in`` = {_prefixID with _localName = "in"}
    let intersection = {_prefixID with _localName = "intersection"}
    let ``member`` = {_prefixID with _localName = "member"}
    let symmetricDifference = {_prefixID with _localName = "symmetricDifference"}
    let union = {_prefixID with _localName = "union"}