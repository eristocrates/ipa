namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.InterestRates.slash

open DoxAletheia

module fibo_ind_ir_ir =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ReferenceInterestRate"></see>
    /// </summary>
    let ReferenceInterestRate = _prefix "ReferenceInterestRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/BaseRate"></see>
    /// </summary>
    let BaseRate = _prefix "BaseRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/EighteenMonths"></see>
    /// </summary>
    let EighteenMonths = _prefix "EighteenMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FifteenYears"></see>
    /// </summary>
    let FifteenYears = _prefix "FifteenYears"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FiveYears"></see>
    /// </summary>
    let FiveYears = _prefix "FiveYears"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FortyEightMonths"></see>
    /// </summary>
    let FortyEightMonths = _prefix "FortyEightMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FourYears"></see>
    /// </summary>
    let FourYears = _prefix "FourYears"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankBidRate"></see>
    /// </summary>
    let InterbankBidRate = _prefix "InterbankBidRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankRate"></see>
    /// </summary>
    let InterbankRate = _prefix "InterbankRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankMidRate"></see>
    /// </summary>
    let InterbankMidRate = _prefix "InterbankMidRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankOfferedRate"></see>
    /// </summary>
    let InterbankOfferedRate = _prefix "InterbankOfferedRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateAuthority"></see>
    /// </summary>
    let InterestRateAuthority = _prefix "InterestRateAuthority"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateBenchmark"></see>
    /// </summary>
    let InterestRateBenchmark = _prefix "InterestRateBenchmark"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasRateResetTimeOfDay"></see>
    /// </summary>
    let hasRateResetTimeOfDay = _prefix "hasRateResetTimeOfDay"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasTenor"></see>
    /// </summary>
    let hasTenor = _prefix "hasTenor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasReferenceCurrency"></see>
    /// </summary>
    let hasReferenceCurrency = _prefix "hasReferenceCurrency"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateBenchmarkClassificationScheme"></see>
    /// </summary>
    let InterestRateBenchmarkClassificationScheme =
        _prefix "InterestRateBenchmarkClassificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/NineMonths"></see>
    /// </summary>
    let NineMonths = _prefix "NineMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneDay"></see>
    /// </summary>
    let OneDay = _prefix "OneDay"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneHundredEightyMonths"></see>
    /// </summary>
    let OneHundredEightyMonths = _prefix "OneHundredEightyMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneMonth"></see>
    /// </summary>
    let OneMonth = _prefix "OneMonth"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneWeek"></see>
    /// </summary>
    let OneWeek = _prefix "OneWeek"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneYear"></see>
    /// </summary>
    let OneYear = _prefix "OneYear"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OvernightRate"></see>
    /// </summary>
    let OvernightRate = _prefix "OvernightRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SixMonths"></see>
    /// </summary>
    let SixMonths = _prefix "SixMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SixtyMonths"></see>
    /// </summary>
    let SixtyMonths = _prefix "SixtyMonths"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SpecificProviderInterestRateBenchmark"></see>
    /// </summary>
    let SpecificProviderInterestRateBenchmark =
        _prefix "SpecificProviderInterestRateBenchmark"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TenYears"></see>
    /// </summary>
    let TenYears = _prefix "TenYears"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThirtySixMonths"></see>
    /// </summary>
    let ThirtySixMonths = _prefix "ThirtySixMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThirtyYears"></see>
    /// </summary>
    let ThirtyYears = _prefix "ThirtyYears"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeHundredSixtyMonths"></see>
    /// </summary>
    let ThreeHundredSixtyMonths = _prefix "ThreeHundredSixtyMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeMonths"></see>
    /// </summary>
    let ThreeMonths = _prefix "ThreeMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeYears"></see>
    /// </summary>
    let ThreeYears = _prefix "ThreeYears"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwelveMonths"></see>
    /// </summary>
    let TwelveMonths = _prefix "TwelveMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwentyFourMonths"></see>
    /// </summary>
    let TwentyFourMonths = _prefix "TwentyFourMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwentyYears"></see>
    /// </summary>
    let TwentyYears = _prefix "TwentyYears"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwoMonths"></see>
    /// </summary>
    let TwoMonths = _prefix "TwoMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwoYears"></see>
    /// </summary>
    let TwoYears = _prefix "TwoYears"
