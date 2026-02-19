namespace Dcmi.dcam.Namespace
module dcam =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/dc/dcam/" (Some @"http://purl.org/dc/dcam/") (Some @"dcmi.dcam") None
    let VocabularyEncodingScheme = {_prefixID with _localName = "VocabularyEncodingScheme"}
    let domainIncludes = {_prefixID with _localName = "domainIncludes"}
    let memberOf = {_prefixID with _localName = "memberOf"}
    let rangeIncludes = {_prefixID with _localName = "rangeIncludes"}