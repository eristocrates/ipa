namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Ratings.slash

open DoxAletheia

module fibo_fnd_arr_rt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/QualitativeRatingScore"></see>
    /// </summary>
    let QualitativeRatingScore = _prefix "QualitativeRatingScore"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScore"></see>
    /// </summary>
    let RatingScore = _prefix "RatingScore"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/QuantitativeRatingScore"></see>
    /// </summary>
    let QuantitativeRatingScore = _prefix "QuantitativeRatingScore"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasMeasureWithinScale"></see>
    /// </summary>
    let hasMeasureWithinScale = _prefix "hasMeasureWithinScale"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/Rating"></see>
    /// </summary>
    let Rating = _prefix "Rating"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/rates"></see>
    /// </summary>
    let rates = _prefix "rates"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingIssuer"></see>
    /// </summary>
    let RatingIssuer = _prefix "RatingIssuer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingParty"></see>
    /// </summary>
    let RatingParty = _prefix "RatingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasRatingScore"></see>
    /// </summary>
    let hasRatingScore = _prefix "hasRatingScore"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAgency"></see>
    /// </summary>
    let RatingAgency = _prefix "RatingAgency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScalePublisher"></see>
    /// </summary>
    let RatingScalePublisher = _prefix "RatingScalePublisher"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAssessmentActivity"></see>
    /// </summary>
    let RatingAssessmentActivity = _prefix "RatingAssessmentActivity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAssessmentEvent"></see>
    /// </summary>
    let RatingAssessmentEvent = _prefix "RatingAssessmentEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingReport"></see>
    /// </summary>
    let RatingReport = _prefix "RatingReport"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScale"></see>
    /// </summary>
    let RatingScale = _prefix "RatingScale"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasBestMeasure"></see>
    /// </summary>
    let hasBestMeasure = _prefix "hasBestMeasure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasWorstMeasure"></see>
    /// </summary>
    let hasWorstMeasure = _prefix "hasWorstMeasure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasRating"></see>
    /// </summary>
    let hasRating = _prefix "hasRating"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/producesRatingsFor"></see>
    /// </summary>
    let producesRatingsFor = _prefix "producesRatingsFor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/usesRatingParty"></see>
    /// </summary>
    let usesRatingParty = _prefix "usesRatingParty"
