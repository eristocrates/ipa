namespace Spar.fivestars.Namespace
module fivestars =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/spar/fivestars/" (Some "http://purl.org/spar/fivestars.ttl") (Some "spar.fivestars") None
    let ``2012-01-16`` = {_prefixID with _localName = "2012-01-16"}
    let availableDatasetsRatingComment = {_prefixID with _localName = "availableDatasetsRatingComment"}
    let enhancedContentRatingComment = {_prefixID with _localName = "enhancedContentRatingComment"}
    let hasAvailableDatasetsRating = {_prefixID with _localName = "hasAvailableDatasetsRating"}
    let hasEnhancedContentRating = {_prefixID with _localName = "hasEnhancedContentRating"}
    let ``hasMachine-readableMetadataRating`` = {_prefixID with _localName = "hasMachine-readableMetadataRating"}
    let hasOpenAccessRating = {_prefixID with _localName = "hasOpenAccessRating"}
    let hasOverallFiveStarsRating = {_prefixID with _localName = "hasOverallFiveStarsRating"}
    let hasPeerReviewRating = {_prefixID with _localName = "hasPeerReviewRating"}
    let ``machine-readableMetadataRatingComment`` = {_prefixID with _localName = "machine-readableMetadataRatingComment"}
    let openAccessRatingComment = {_prefixID with _localName = "openAccessRatingComment"}
    let overallFiveStarsRatingComment = {_prefixID with _localName = "overallFiveStarsRatingComment"}
    let peerReviewRatingComment = {_prefixID with _localName = "peerReviewRatingComment"}