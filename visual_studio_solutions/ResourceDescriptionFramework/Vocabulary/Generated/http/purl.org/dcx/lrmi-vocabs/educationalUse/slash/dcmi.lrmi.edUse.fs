namespace Dcmi.lrmi.edUse.Namespace
module edUse =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/dcx/lrmi-vocabs/educationalUse/" (Some @"	http://dublincore.org/vocabs/educationalUse.ttl") (Some @"dcmi.lrmi.edUse") None
    let assessment = {_prefixID with _localName = "assessment"}
    let instruction = {_prefixID with _localName = "instruction"}
    let professionalSupport = {_prefixID with _localName = "professionalSupport"}