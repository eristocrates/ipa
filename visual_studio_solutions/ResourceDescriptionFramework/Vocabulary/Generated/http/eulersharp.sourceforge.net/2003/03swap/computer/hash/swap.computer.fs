namespace Swap.computer.Namespace
module computer =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/computer#" (Some "http://eulersharp.sourceforge.net/2003/03swap/computer") (Some "swap.computer") None
    let Computer = {_prefixID with _localName = "Computer"}
    let Data = {_prefixID with _localName = "Data"}
    let Hardware = {_prefixID with _localName = "Hardware"}
    let SearchEngine = {_prefixID with _localName = "SearchEngine"}
    let Software = {_prefixID with _localName = "Software"}