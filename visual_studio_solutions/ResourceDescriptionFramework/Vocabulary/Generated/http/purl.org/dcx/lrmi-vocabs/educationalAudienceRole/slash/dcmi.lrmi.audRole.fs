namespace Dcmi.lrmi.audRole.Namespace
module audRole =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/" (Some @"http://dublincore.org/vocabs/educationalAudienceRole.ttl") (Some @"dcmi.lrmi.audRole") None
    let administrator = {_prefixID with _localName = "administrator"}
    let generalPublic = {_prefixID with _localName = "generalPublic"}
    let mentor = {_prefixID with _localName = "mentor"}
    let parent = {_prefixID with _localName = "parent"}
    let peerTutor = {_prefixID with _localName = "peerTutor"}
    let professional = {_prefixID with _localName = "professional"}
    let student = {_prefixID with _localName = "student"}
    let teacher = {_prefixID with _localName = "teacher"}