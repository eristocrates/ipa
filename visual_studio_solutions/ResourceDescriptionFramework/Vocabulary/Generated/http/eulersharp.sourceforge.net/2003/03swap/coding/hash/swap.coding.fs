namespace Swap.coding.Namespace
module coding =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/coding#" (Some "http://eulersharp.sourceforge.net/2003/03swap/coding") (Some "swap.coding") None
    let Code = {_prefixID with _localName = "Code"}
    let codes = {_prefixID with _localName = "codes"}
    let hasBroadCode = {_prefixID with _localName = "hasBroadCode"}
    let hasCode = {_prefixID with _localName = "hasCode"}
    let hasCodeAuthority = {_prefixID with _localName = "hasCodeAuthority"}
    let hasCodeExpirationDate = {_prefixID with _localName = "hasCodeExpirationDate"}
    let hasCodeValue = {_prefixID with _localName = "hasCodeValue"}
    let hasExactCode = {_prefixID with _localName = "hasExactCode"}
    let hasMappingCode = {_prefixID with _localName = "hasMappingCode"}
    let hasNarrowCode = {_prefixID with _localName = "hasNarrowCode"}