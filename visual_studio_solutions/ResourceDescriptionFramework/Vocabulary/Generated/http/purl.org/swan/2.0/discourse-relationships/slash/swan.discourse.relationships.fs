namespace Swan.discourse.relationships.Namespace
module relationships =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/swan/2.0/discourse-relationships/" (Some "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/discourse-relationships.owl") (Some "swan.discourse.relationships") None
    let alternativeTo = {_prefixID with _localName = "alternativeTo"}
    let arisesFrom = {_prefixID with _localName = "arisesFrom"}
    let consistentWith = {_prefixID with _localName = "consistentWith"}
    let inconsistentWith = {_prefixID with _localName = "inconsistentWith"}
    let motivates = {_prefixID with _localName = "motivates"}
    let referencesAsInconsistentEvidence = {_prefixID with _localName = "referencesAsInconsistentEvidence"}
    let referencesAsRelevantEvidence = {_prefixID with _localName = "referencesAsRelevantEvidence"}
    let referencesAsSupportiveEvidence = {_prefixID with _localName = "referencesAsSupportiveEvidence"}
    let refersTo = {_prefixID with _localName = "refersTo"}
    let relatesTo = {_prefixID with _localName = "relatesTo"}
    let relevantTo = {_prefixID with _localName = "relevantTo"}
    let respondsNegativelyTo = {_prefixID with _localName = "respondsNegativelyTo"}
    let respondsNeutrallyTo = {_prefixID with _localName = "respondsNeutrallyTo"}
    let respondsPositivelyTo = {_prefixID with _localName = "respondsPositivelyTo"}
    let respondsTo = {_prefixID with _localName = "respondsTo"}