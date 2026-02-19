namespace Spar.fr.Namespace
module fr =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/spar/fr/" (Some "http://purl.org/spar/fr.ttl") (Some "spar.fr") None
    let ConveningOrganization = {_prefixID with _localName = "ConveningOrganization"}
    let ReviewVersion = {_prefixID with _localName = "ReviewVersion"}
    let TrackingSystem = {_prefixID with _localName = "TrackingSystem"}
    let hasRating = {_prefixID with _localName = "hasRating"}
    let hasReviewerConfidence = {_prefixID with _localName = "hasReviewerConfidence"}
    let hasSubReviewer = {_prefixID with _localName = "hasSubReviewer"}
    let issuedAt = {_prefixID with _localName = "issuedAt"}
    let issuedFor = {_prefixID with _localName = "issuedFor"}
    let ratingValue = {_prefixID with _localName = "ratingValue"}
    let releasedBy = {_prefixID with _localName = "releasedBy"}