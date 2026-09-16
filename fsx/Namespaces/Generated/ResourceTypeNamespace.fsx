#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module resourceType =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-vocabs/learningResourceType/" "resourceType"

    let _namespaceIri = _prefixId.prefix ""
    let activityPlan = _prefixId.prefix "activityPlan"
    let assessment = _prefixId.prefix "assessment"
    let assessmentItem = _prefixId.prefix "assessmentItem"
    let educatorCurriculumGuide = _prefixId.prefix "educatorCurriculumGuide"
    let lessonPlan = _prefixId.prefix "lessonPlan"
    let physicalLearningResource = _prefixId.prefix "physicalLearningResource"
    let recordedLesson = _prefixId.prefix "recordedLesson"
    let supportingDocument = _prefixId.prefix "supportingDocument"
    let textbook = _prefixId.prefix "textbook"
    let unitPlan = _prefixId.prefix "unitPlan"
