namespace Fibo.FND.Arrangements.Ratings.Namespace
module Ratings =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Arrangements/Ratings.rdf") (Some @"fibo.FND.Arrangements.Ratings") None
    let QualitativeRatingScore = {_prefixID with _localName = "QualitativeRatingScore"}
    let QuantitativeRatingScore = {_prefixID with _localName = "QuantitativeRatingScore"}
    let Rating = {_prefixID with _localName = "Rating"}
    let RatingAgency = {_prefixID with _localName = "RatingAgency"}
    let RatingAssessmentActivity = {_prefixID with _localName = "RatingAssessmentActivity"}
    let RatingAssessmentEvent = {_prefixID with _localName = "RatingAssessmentEvent"}
    let RatingIssuer = {_prefixID with _localName = "RatingIssuer"}
    let RatingParty = {_prefixID with _localName = "RatingParty"}
    let RatingReport = {_prefixID with _localName = "RatingReport"}
    let RatingScale = {_prefixID with _localName = "RatingScale"}
    let RatingScalePublisher = {_prefixID with _localName = "RatingScalePublisher"}
    let RatingScore = {_prefixID with _localName = "RatingScore"}
    let hasBestMeasure = {_prefixID with _localName = "hasBestMeasure"}
    let hasMeasureWithinScale = {_prefixID with _localName = "hasMeasureWithinScale"}
    let hasRating = {_prefixID with _localName = "hasRating"}
    let hasRatingScore = {_prefixID with _localName = "hasRatingScore"}
    let hasWorstMeasure = {_prefixID with _localName = "hasWorstMeasure"}
    let producesRatingsFor = {_prefixID with _localName = "producesRatingsFor"}
    let rates = {_prefixID with _localName = "rates"}
    let usesRatingParty = {_prefixID with _localName = "usesRatingParty"}