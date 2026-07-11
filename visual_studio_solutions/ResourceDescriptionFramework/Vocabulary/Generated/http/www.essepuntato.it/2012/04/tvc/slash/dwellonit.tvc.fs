namespace Dwellonit.tvc.Namespace
module tvc =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.essepuntato.it/2012/04/tvc/" (Some "https://sourceforge.net/p/dwellonit/code/HEAD/tree/TimeIndexedValueInContext/tvc.owl?format=raw") (Some "dwellonit.tvc") None
    let ValueInTime = {_prefixID with _localName = "ValueInTime"}
    let atTime = {_prefixID with _localName = "atTime"}
    let hasValue = {_prefixID with _localName = "hasValue"}
    let withValue = {_prefixID with _localName = "withValue"}
    let withinContext = {_prefixID with _localName = "withinContext"}