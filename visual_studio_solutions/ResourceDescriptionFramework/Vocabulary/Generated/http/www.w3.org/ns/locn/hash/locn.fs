namespace Locn.Namespace
module locn =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/locn#" (Some "http://www.w3.org/ns/locn#") (Some "locn") None
    let Address = {_prefixID with _localName = "Address"}
    let Geometry = {_prefixID with _localName = "Geometry"}
    let address = {_prefixID with _localName = "address"}
    let addressArea = {_prefixID with _localName = "addressArea"}
    let addressId = {_prefixID with _localName = "addressId"}
    let adminUnitL1 = {_prefixID with _localName = "adminUnitL1"}
    let adminUnitL2 = {_prefixID with _localName = "adminUnitL2"}
    let fullAddress = {_prefixID with _localName = "fullAddress"}
    let geographicName = {_prefixID with _localName = "geographicName"}
    let geometry = {_prefixID with _localName = "geometry"}
    let location = {_prefixID with _localName = "location"}
    let locatorDesignator = {_prefixID with _localName = "locatorDesignator"}
    let locatorName = {_prefixID with _localName = "locatorName"}
    let poBox = {_prefixID with _localName = "poBox"}
    let postCode = {_prefixID with _localName = "postCode"}
    let postName = {_prefixID with _localName = "postName"}
    let thoroughfare = {_prefixID with _localName = "thoroughfare"}