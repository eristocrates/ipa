namespace Dcmi.lrmi.alignment.Namespace
module alignment =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/dcx/lrmi-vocabs/alignmentType/" (Some @"http://dublincore.org/vocabs/alignmentType.ttl") (Some @"dcmi.lrmi.alignment") None
    let assesses = {_prefixID with _localName = "assesses"}
    let complexityLevel = {_prefixID with _localName = "complexityLevel"}
    let educationalLevel = {_prefixID with _localName = "educationalLevel"}
    let educationalSubject = {_prefixID with _localName = "educationalSubject"}
    let prerequisite = {_prefixID with _localName = "prerequisite"}
    let readingLevel = {_prefixID with _localName = "readingLevel"}
    let teaches = {_prefixID with _localName = "teaches"}