namespace Swap.string.Namespace
module string =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/string#" (Some "http://www.w3.org/2000/10/swap/string") (Some "swap.string") None
    let String = {_prefixID with _localName = "String"}
    let concat = {_prefixID with _localName = "concat"}
    let concatenation = {_prefixID with _localName = "concatenation"}
    let contains = {_prefixID with _localName = "contains"}
    let containsIgnoringCase = {_prefixID with _localName = "containsIgnoringCase"}
    let endsWith = {_prefixID with _localName = "endsWith"}
    let equalIgnoringCase = {_prefixID with _localName = "equalIgnoringCase"}
    let format = {_prefixID with _localName = "format"}
    let greaterThan = {_prefixID with _localName = "greaterThan"}
    let lessThan = {_prefixID with _localName = "lessThan"}
    let matches = {_prefixID with _localName = "matches"}
    let notEqualIgnoringCase = {_prefixID with _localName = "notEqualIgnoringCase"}
    let notGreaterThan = {_prefixID with _localName = "notGreaterThan"}
    let notLessThan = {_prefixID with _localName = "notLessThan"}
    let notMatches = {_prefixID with _localName = "notMatches"}
    let replace = {_prefixID with _localName = "replace"}
    let scrape = {_prefixID with _localName = "scrape"}
    let startsWith = {_prefixID with _localName = "startsWith"}