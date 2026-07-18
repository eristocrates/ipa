namespace http.w3id.org.amlo.core.hash

open DoxAletheia.Rdf_Vocabulary

module amlo_core =
    let _namespace_name = "http://w3id.org/amlo/core#"

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Accountable"></see>
    /// </summary>
    let Accountable =
        Namespaced_IRI.parse _namespace_name "Accountable" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Analyst"></see>
    /// </summary>
    let Analyst = Namespaced_IRI.parse _namespace_name "Analyst" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Book"></see>
    /// </summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Cash"></see>
    /// </summary>
    let Cash = Namespaced_IRI.parse _namespace_name "Cash" |> NamespacedName
    /// <summary>
    /// A person Gender
    /// <see href="http://w3id.org/amlo/core#Gender"></see></summary>
    let Gender = Namespaced_IRI.parse _namespace_name "Gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#IntangibleAsset"></see>
    /// </summary>
    let IntangibleAsset =
        Namespaced_IRI.parse _namespace_name "IntangibleAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#OriginatorBook"></see>
    /// </summary>
    let OriginatorBook =
        Namespaced_IRI.parse _namespace_name "OriginatorBook" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#OriginatorParty"></see>
    /// </summary>
    let OriginatorParty =
        Namespaced_IRI.parse _namespace_name "OriginatorParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Reasoner"></see>
    /// </summary>
    let Reasoner = Namespaced_IRI.parse _namespace_name "Reasoner" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RecipientBook"></see>
    /// </summary>
    let RecipientBook =
        Namespaced_IRI.parse _namespace_name "RecipientBook" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RecipientParty"></see>
    /// </summary>
    let RecipientParty =
        Namespaced_IRI.parse _namespace_name "RecipientParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RiskEstimator"></see>
    /// </summary>
    let RiskEstimator =
        Namespaced_IRI.parse _namespace_name "RiskEstimator" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RiskEvaluation"></see>
    /// </summary>
    let RiskEvaluation =
        Namespaced_IRI.parse _namespace_name "RiskEvaluation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#assessedOn"></see>
    /// </summary>
    let assessedOn = Namespaced_IRI.parse _namespace_name "assessedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#onRiskFactor"></see>
    /// </summary>
    let onRiskFactor =
        Namespaced_IRI.parse _namespace_name "onRiskFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RiskRating"></see>
    /// </summary>
    let RiskRating = Namespaced_IRI.parse _namespace_name "RiskRating" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#hasRiskEstimator"></see>
    /// </summary>
    let hasRiskEstimator =
        Namespaced_IRI.parse _namespace_name "hasRiskEstimator" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RiskSizing"></see>
    /// </summary>
    let RiskSizing = Namespaced_IRI.parse _namespace_name "RiskSizing" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#SuspectRating"></see>
    /// </summary>
    let SuspectRating =
        Namespaced_IRI.parse _namespace_name "SuspectRating" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#hasSuspectRatingScore"></see>
    /// </summary>
    let hasSuspectRatingScore =
        Namespaced_IRI.parse _namespace_name "hasSuspectRatingScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#SuspectRatingScore"></see>
    /// </summary>
    let SuspectRatingScore =
        Namespaced_IRI.parse _namespace_name "SuspectRatingScore" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Transfer"></see>
    /// </summary>
    let Transfer = Namespaced_IRI.parse _namespace_name "Transfer" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#transfers"></see>
    /// </summary>
    let transfers = Namespaced_IRI.parse _namespace_name "transfers" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#UnexpectedActivity"></see>
    /// </summary>
    let UnexpectedActivity =
        Namespaced_IRI.parse _namespace_name "UnexpectedActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#UnexpectedActivityReport"></see>
    /// </summary>
    let UnexpectedActivityReport =
        Namespaced_IRI.parse _namespace_name "UnexpectedActivityReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#hasEvaluation"></see>
    /// </summary>
    let hasEvaluation =
        Namespaced_IRI.parse _namespace_name "hasEvaluation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#detects"></see>
    /// </summary>
    let detects = Namespaced_IRI.parse _namespace_name "detects" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#isDetectedBy"></see>
    /// </summary>
    let isDetectedBy =
        Namespaced_IRI.parse _namespace_name "isDetectedBy" |> NamespacedName

    /// <summary>
    /// a female person
    /// <see href="http://w3id.org/amlo/core#female"></see></summary>
    let female = Namespaced_IRI.parse _namespace_name "female" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#hasGender"></see>
    /// </summary>
    let hasGender = Namespaced_IRI.parse _namespace_name "hasGender" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#hasSizeEstimator"></see>
    /// </summary>
    let hasSizeEstimator =
        Namespaced_IRI.parse _namespace_name "hasSizeEstimator" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#isRecordedIn"></see>
    /// </summary>
    let isRecordedIn =
        Namespaced_IRI.parse _namespace_name "isRecordedIn" |> NamespacedName

    /// <summary>
    /// a male person
    /// <see href="http://w3id.org/amlo/core#male"></see></summary>
    let male = Namespaced_IRI.parse _namespace_name "male" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#not-enough-data"></see>
    /// </summary>
    let ``not-enough-data`` =
        Namespaced_IRI.parse _namespace_name "not-enough-data" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#not-suspicious"></see>
    /// </summary>
    let ``not-suspicious`` =
        Namespaced_IRI.parse _namespace_name "not-suspicious" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#suspect-codes"></see>
    /// </summary>
    let ``suspect-codes`` =
        Namespaced_IRI.parse _namespace_name "suspect-codes" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#suspect-rating-scale"></see>
    /// </summary>
    let ``suspect-rating-scale`` =
        Namespaced_IRI.parse _namespace_name "suspect-rating-scale" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#suspicious"></see>
    /// </summary>
    let suspicious = Namespaced_IRI.parse _namespace_name "suspicious" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#to-be-ignored"></see>
    /// </summary>
    let ``to-be-ignored`` =
        Namespaced_IRI.parse _namespace_name "to-be-ignored" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#unexpected"></see>
    /// </summary>
    let unexpected = Namespaced_IRI.parse _namespace_name "unexpected" |> NamespacedName
