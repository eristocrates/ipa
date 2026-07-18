namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Ratings.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_arr_rt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/QualitativeRatingScore"></see>
    /// </summary>
    let QualitativeRatingScore =
        Namespaced_IRI.parse _namespace_name "QualitativeRatingScore" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScore"></see>
    /// </summary>
    let RatingScore =
        Namespaced_IRI.parse _namespace_name "RatingScore" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/QuantitativeRatingScore"></see>
    /// </summary>
    let QuantitativeRatingScore =
        Namespaced_IRI.parse _namespace_name "QuantitativeRatingScore" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasMeasureWithinScale"></see>
    /// </summary>
    let hasMeasureWithinScale =
        Namespaced_IRI.parse _namespace_name "hasMeasureWithinScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/Rating"></see>
    /// </summary>
    let Rating = Namespaced_IRI.parse _namespace_name "Rating" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/rates"></see>
    /// </summary>
    let rates = Namespaced_IRI.parse _namespace_name "rates" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingIssuer"></see>
    /// </summary>
    let RatingIssuer =
        Namespaced_IRI.parse _namespace_name "RatingIssuer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingParty"></see>
    /// </summary>
    let RatingParty =
        Namespaced_IRI.parse _namespace_name "RatingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasRatingScore"></see>
    /// </summary>
    let hasRatingScore =
        Namespaced_IRI.parse _namespace_name "hasRatingScore" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAgency"></see>
    /// </summary>
    let RatingAgency =
        Namespaced_IRI.parse _namespace_name "RatingAgency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScalePublisher"></see>
    /// </summary>
    let RatingScalePublisher =
        Namespaced_IRI.parse _namespace_name "RatingScalePublisher" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAssessmentActivity"></see>
    /// </summary>
    let RatingAssessmentActivity =
        Namespaced_IRI.parse _namespace_name "RatingAssessmentActivity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAssessmentEvent"></see>
    /// </summary>
    let RatingAssessmentEvent =
        Namespaced_IRI.parse _namespace_name "RatingAssessmentEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingReport"></see>
    /// </summary>
    let RatingReport =
        Namespaced_IRI.parse _namespace_name "RatingReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScale"></see>
    /// </summary>
    let RatingScale =
        Namespaced_IRI.parse _namespace_name "RatingScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasBestMeasure"></see>
    /// </summary>
    let hasBestMeasure =
        Namespaced_IRI.parse _namespace_name "hasBestMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasWorstMeasure"></see>
    /// </summary>
    let hasWorstMeasure =
        Namespaced_IRI.parse _namespace_name "hasWorstMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasRating"></see>
    /// </summary>
    let hasRating = Namespaced_IRI.parse _namespace_name "hasRating" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/producesRatingsFor"></see>
    /// </summary>
    let producesRatingsFor =
        Namespaced_IRI.parse _namespace_name "producesRatingsFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/usesRatingParty"></see>
    /// </summary>
    let usesRatingParty =
        Namespaced_IRI.parse _namespace_name "usesRatingParty" |> NamespacedName
