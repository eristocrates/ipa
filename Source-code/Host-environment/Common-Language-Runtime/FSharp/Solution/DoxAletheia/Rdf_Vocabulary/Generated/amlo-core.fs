namespace http.w3id.org.amlo.core.hash

open DoxAletheia

module amlo_core =
    let _namespace_name = "http://w3id.org/amlo/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Accountable"></see>
    /// </summary>
    let Accountable = _prefix "Accountable"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Analyst"></see>
    /// </summary>
    let Analyst = _prefix "Analyst"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Book"></see>
    /// </summary>
    let Book = _prefix "Book"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Cash"></see>
    /// </summary>
    let Cash = _prefix "Cash"
    /// <summary>
    /// A person Gender
    /// <see href="http://w3id.org/amlo/core#Gender"></see></summary>
    let Gender = _prefix "Gender"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#IntangibleAsset"></see>
    /// </summary>
    let IntangibleAsset = _prefix "IntangibleAsset"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#OriginatorBook"></see>
    /// </summary>
    let OriginatorBook = _prefix "OriginatorBook"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#OriginatorParty"></see>
    /// </summary>
    let OriginatorParty = _prefix "OriginatorParty"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Reasoner"></see>
    /// </summary>
    let Reasoner = _prefix "Reasoner"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RecipientBook"></see>
    /// </summary>
    let RecipientBook = _prefix "RecipientBook"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RecipientParty"></see>
    /// </summary>
    let RecipientParty = _prefix "RecipientParty"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RiskEstimator"></see>
    /// </summary>
    let RiskEstimator = _prefix "RiskEstimator"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RiskEvaluation"></see>
    /// </summary>
    let RiskEvaluation = _prefix "RiskEvaluation"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#assessedOn"></see>
    /// </summary>
    let assessedOn = _prefix "assessedOn"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#onRiskFactor"></see>
    /// </summary>
    let onRiskFactor = _prefix "onRiskFactor"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RiskRating"></see>
    /// </summary>
    let RiskRating = _prefix "RiskRating"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#hasRiskEstimator"></see>
    /// </summary>
    let hasRiskEstimator = _prefix "hasRiskEstimator"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#RiskSizing"></see>
    /// </summary>
    let RiskSizing = _prefix "RiskSizing"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#SuspectRating"></see>
    /// </summary>
    let SuspectRating = _prefix "SuspectRating"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#hasSuspectRatingScore"></see>
    /// </summary>
    let hasSuspectRatingScore = _prefix "hasSuspectRatingScore"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#SuspectRatingScore"></see>
    /// </summary>
    let SuspectRatingScore = _prefix "SuspectRatingScore"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#Transfer"></see>
    /// </summary>
    let Transfer = _prefix "Transfer"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#transfers"></see>
    /// </summary>
    let transfers = _prefix "transfers"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#UnexpectedActivity"></see>
    /// </summary>
    let UnexpectedActivity = _prefix "UnexpectedActivity"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#UnexpectedActivityReport"></see>
    /// </summary>
    let UnexpectedActivityReport = _prefix "UnexpectedActivityReport"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#hasEvaluation"></see>
    /// </summary>
    let hasEvaluation = _prefix "hasEvaluation"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#detects"></see>
    /// </summary>
    let detects = _prefix "detects"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#isDetectedBy"></see>
    /// </summary>
    let isDetectedBy = _prefix "isDetectedBy"
    /// <summary>
    /// a female person
    /// <see href="http://w3id.org/amlo/core#female"></see></summary>
    let female = _prefix "female"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#hasGender"></see>
    /// </summary>
    let hasGender = _prefix "hasGender"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#hasSizeEstimator"></see>
    /// </summary>
    let hasSizeEstimator = _prefix "hasSizeEstimator"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#isRecordedIn"></see>
    /// </summary>
    let isRecordedIn = _prefix "isRecordedIn"
    /// <summary>
    /// a male person
    /// <see href="http://w3id.org/amlo/core#male"></see></summary>
    let male = _prefix "male"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#not-enough-data"></see>
    /// </summary>
    let ``not-enough-data`` = _prefix "not-enough-data"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#not-suspicious"></see>
    /// </summary>
    let ``not-suspicious`` = _prefix "not-suspicious"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#suspect-codes"></see>
    /// </summary>
    let ``suspect-codes`` = _prefix "suspect-codes"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#suspect-rating-scale"></see>
    /// </summary>
    let ``suspect-rating-scale`` = _prefix "suspect-rating-scale"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#suspicious"></see>
    /// </summary>
    let suspicious = _prefix "suspicious"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#to-be-ignored"></see>
    /// </summary>
    let ``to-be-ignored`` = _prefix "to-be-ignored"
    /// <summary>
    ///   <see href="http://w3id.org/amlo/core#unexpected"></see>
    /// </summary>
    let unexpected = _prefix "unexpected"
