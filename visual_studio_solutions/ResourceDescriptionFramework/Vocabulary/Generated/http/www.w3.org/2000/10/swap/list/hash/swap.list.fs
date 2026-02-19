namespace Swap.list.Namespace
module list =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/list#" (Some "http://www.w3.org/2000/10/swap/list") (Some "swap.list") None
    let append = {_prefixID with _localName = "append"}
    let ``in`` = {_prefixID with _localName = "in"}
    let last = {_prefixID with _localName = "last"}
    let ``member`` = {_prefixID with _localName = "member"}