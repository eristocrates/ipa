namespace Dcmi.lrmi.resourceType.Namespace
module resourceType =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/dcx/lrmi-vocabs/learningResourceType/" (Some @"https://www.dublincore.org/vocabs/learningResourceType.ttl") (Some @"dcmi.lrmi.resourceType") None
    let activityPlan = {_prefixID with _localName = "activityPlan"}
    let assessment = {_prefixID with _localName = "assessment"}
    let assessmentItem = {_prefixID with _localName = "assessmentItem"}
    let educatorCurriculumGuide = {_prefixID with _localName = "educatorCurriculumGuide"}
    let lessonPlan = {_prefixID with _localName = "lessonPlan"}
    let physicalLearningResource = {_prefixID with _localName = "physicalLearningResource"}
    let recordedLesson = {_prefixID with _localName = "recordedLesson"}
    let supportingDocument = {_prefixID with _localName = "supportingDocument"}
    let textbook = {_prefixID with _localName = "textbook"}
    let unitPlan = {_prefixID with _localName = "unitPlan"}