namespace Swap.care.Namespace
module care =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/care#" (Some "http://eulersharp.sourceforge.net/2003/03swap/care") (Some "swap.care") None
    let Caring = {_prefixID with _localName = "Caring"}
    let ElderlyHome = {_prefixID with _localName = "ElderlyHome"}
    let Environment = {_prefixID with _localName = "Environment"}
    let caresFor = {_prefixID with _localName = "caresFor"}