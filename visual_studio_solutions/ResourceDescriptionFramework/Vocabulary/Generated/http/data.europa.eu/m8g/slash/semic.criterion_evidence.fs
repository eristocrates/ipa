namespace Semic.criterion_evidence.Namespace
module criterion_evidence =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://data.europa.eu/m8g/" (Some "https://github.com/SEMICeu/CCCEV/raw/refs/heads/master/releases/2.1.0/voc/cccev.ttl") (Some "semic.criterion_evidence") None
    let Constraint = {_prefixID with _localName = "Constraint"}
    let Criterion = {_prefixID with _localName = "Criterion"}
    let Evidence = {_prefixID with _localName = "Evidence"}
    let EvidenceType = {_prefixID with _localName = "EvidenceType"}
    let EvidenceTypeList = {_prefixID with _localName = "EvidenceTypeList"}
    let InformationConcept = {_prefixID with _localName = "InformationConcept"}
    let InformationRequirement = {_prefixID with _localName = "InformationRequirement"}
    let ReferenceFramework = {_prefixID with _localName = "ReferenceFramework"}
    let Requirement = {_prefixID with _localName = "Requirement"}
    let SupportedValue = {_prefixID with _localName = "SupportedValue"}
    let bias = {_prefixID with _localName = "bias"}
    let confidentialityLevelType = {_prefixID with _localName = "confidentialityLevelType"}
    let constrains = {_prefixID with _localName = "constrains"}
    let evidenceTypeClassification = {_prefixID with _localName = "evidenceTypeClassification"}
    let expressionOfExpectedValue = {_prefixID with _localName = "expressionOfExpectedValue"}
    let hasConcept = {_prefixID with _localName = "hasConcept"}
    let hasEvidenceTypeList = {_prefixID with _localName = "hasEvidenceTypeList"}
    let hasQualifiedRelation = {_prefixID with _localName = "hasQualifiedRelation"}
    let hasRequirement = {_prefixID with _localName = "hasRequirement"}
    let hasSupportingEvidence = {_prefixID with _localName = "hasSupportingEvidence"}
    let isDerivedFrom = {_prefixID with _localName = "isDerivedFrom"}
    let isRequirementOf = {_prefixID with _localName = "isRequirementOf"}
    let isSpecifiedIn = {_prefixID with _localName = "isSpecifiedIn"}
    let providesValueFor = {_prefixID with _localName = "providesValueFor"}
    let query = {_prefixID with _localName = "query"}
    let specifiesEvidenceType = {_prefixID with _localName = "specifiesEvidenceType"}
    let supportsConcept = {_prefixID with _localName = "supportsConcept"}
    let supportsRequirement = {_prefixID with _localName = "supportsRequirement"}
    let supportsValue = {_prefixID with _localName = "supportsValue"}
    let validityPeriod = {_prefixID with _localName = "validityPeriod"}
    let validityPeriodConstraint = {_prefixID with _localName = "validityPeriodConstraint"}
    let value = {_prefixID with _localName = "value"}
    let weight = {_prefixID with _localName = "weight"}
    let weightingConsiderationDescription = {_prefixID with _localName = "weightingConsiderationDescription"}
    let weightingType = {_prefixID with _localName = "weightingType"}