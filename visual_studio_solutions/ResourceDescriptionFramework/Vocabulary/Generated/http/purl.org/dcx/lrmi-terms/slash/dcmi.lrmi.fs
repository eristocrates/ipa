namespace Dcmi.lrmi.Namespace
module lrmi =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/dcx/lrmi-terms/" (Some @"http://dublincore.org/specifications/lrmi/lrmi_terms/2022-06-14/lrmi-terms.ttl") (Some @"dcmi.lrmi") None
    let ``1.1`` = {_prefixID with _localName = "1.1"}
    let AlignmentObject = {_prefixID with _localName = "AlignmentObject"}
    let EducationalAudience = {_prefixID with _localName = "EducationalAudience"}
    let LearningResource = {_prefixID with _localName = "LearningResource"}
    let alignmentType = {_prefixID with _localName = "alignmentType"}
    let assesses = {_prefixID with _localName = "assesses"}
    let educationalAlignment = {_prefixID with _localName = "educationalAlignment"}
    let educationalFramework = {_prefixID with _localName = "educationalFramework"}
    let educationalLevel = {_prefixID with _localName = "educationalLevel"}
    let educationalRole = {_prefixID with _localName = "educationalRole"}
    let educationalUse = {_prefixID with _localName = "educationalUse"}
    let interactivityType = {_prefixID with _localName = "interactivityType"}
    let isBasedOnUrl = {_prefixID with _localName = "isBasedOnUrl"}
    let learningResourceType = {_prefixID with _localName = "learningResourceType"}
    let targetDescription = {_prefixID with _localName = "targetDescription"}
    let targetName = {_prefixID with _localName = "targetName"}
    let targetUrl = {_prefixID with _localName = "targetUrl"}
    let teaches = {_prefixID with _localName = "teaches"}
    let timeRequired = {_prefixID with _localName = "timeRequired"}
    let typicalAgeRange = {_prefixID with _localName = "typicalAgeRange"}
    let useRightsUrl = {_prefixID with _localName = "useRightsUrl"}