namespace Swap.weekScheme.Namespace
module weekScheme =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/weekScheme#" (Some "http://eulersharp.sourceforge.net/2003/03swap/weekScheme") (Some "swap.weekScheme") None
    let Day = {_prefixID with _localName = "Day"}
    let Duty = {_prefixID with _localName = "Duty"}
    let hasDayEnd = {_prefixID with _localName = "hasDayEnd"}
    let hasDayStart = {_prefixID with _localName = "hasDayStart"}
    let hasDutyEnd = {_prefixID with _localName = "hasDutyEnd"}
    let hasDutyStart = {_prefixID with _localName = "hasDutyStart"}