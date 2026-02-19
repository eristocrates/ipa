namespace Swap.os.Namespace
module os =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/os#" (Some "http://www.w3.org/2000/10/swap/os") (Some "swap.os") None
    let argv = {_prefixID with _localName = "argv"}
    let baseAbsolute = {_prefixID with _localName = "baseAbsolute"}
    let baseRelative = {_prefixID with _localName = "baseRelative"}
    let environ = {_prefixID with _localName = "environ"}