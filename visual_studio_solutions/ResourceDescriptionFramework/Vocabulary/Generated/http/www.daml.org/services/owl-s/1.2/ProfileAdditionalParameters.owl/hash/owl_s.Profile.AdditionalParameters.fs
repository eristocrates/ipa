namespace Owl_s.Profile.AdditionalParameters.Namespace
module AdditionalParameters =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#" (Some "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl") (Some "owl_s.Profile.AdditionalParameters") None
    let AverageResponseTime = {_prefixID with _localName = "AverageResponseTime"}
    let Duration = {_prefixID with _localName = "Duration"}
    let GeographicRadius = {_prefixID with _localName = "GeographicRadius"}
    let MaxResponseTime = {_prefixID with _localName = "MaxResponseTime"}
    let NAICS = {_prefixID with _localName = "NAICS"}
    let UNSPSC = {_prefixID with _localName = "UNSPSC"}