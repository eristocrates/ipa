namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.InterestRates.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_ir_ir =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ReferenceInterestRate"></see>
    /// </summary>
    let ReferenceInterestRate =
        Namespaced_IRI.parse _namespace_name "ReferenceInterestRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/BaseRate"></see>
    /// </summary>
    let BaseRate = Namespaced_IRI.parse _namespace_name "BaseRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/EighteenMonths"></see>
    /// </summary>
    let EighteenMonths =
        Namespaced_IRI.parse _namespace_name "EighteenMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FifteenYears"></see>
    /// </summary>
    let FifteenYears =
        Namespaced_IRI.parse _namespace_name "FifteenYears" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FiveYears"></see>
    /// </summary>
    let FiveYears = Namespaced_IRI.parse _namespace_name "FiveYears" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FortyEightMonths"></see>
    /// </summary>
    let FortyEightMonths =
        Namespaced_IRI.parse _namespace_name "FortyEightMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FourYears"></see>
    /// </summary>
    let FourYears = Namespaced_IRI.parse _namespace_name "FourYears" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankBidRate"></see>
    /// </summary>
    let InterbankBidRate =
        Namespaced_IRI.parse _namespace_name "InterbankBidRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankRate"></see>
    /// </summary>
    let InterbankRate =
        Namespaced_IRI.parse _namespace_name "InterbankRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankMidRate"></see>
    /// </summary>
    let InterbankMidRate =
        Namespaced_IRI.parse _namespace_name "InterbankMidRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankOfferedRate"></see>
    /// </summary>
    let InterbankOfferedRate =
        Namespaced_IRI.parse _namespace_name "InterbankOfferedRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateAuthority"></see>
    /// </summary>
    let InterestRateAuthority =
        Namespaced_IRI.parse _namespace_name "InterestRateAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateBenchmark"></see>
    /// </summary>
    let InterestRateBenchmark =
        Namespaced_IRI.parse _namespace_name "InterestRateBenchmark" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasRateResetTimeOfDay"></see>
    /// </summary>
    let hasRateResetTimeOfDay =
        Namespaced_IRI.parse _namespace_name "hasRateResetTimeOfDay" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasTenor"></see>
    /// </summary>
    let hasTenor = Namespaced_IRI.parse _namespace_name "hasTenor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasReferenceCurrency"></see>
    /// </summary>
    let hasReferenceCurrency =
        Namespaced_IRI.parse _namespace_name "hasReferenceCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateBenchmarkClassificationScheme"></see>
    /// </summary>
    let InterestRateBenchmarkClassificationScheme =
        Namespaced_IRI.parse _namespace_name "InterestRateBenchmarkClassificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/NineMonths"></see>
    /// </summary>
    let NineMonths = Namespaced_IRI.parse _namespace_name "NineMonths" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneDay"></see>
    /// </summary>
    let OneDay = Namespaced_IRI.parse _namespace_name "OneDay" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneHundredEightyMonths"></see>
    /// </summary>
    let OneHundredEightyMonths =
        Namespaced_IRI.parse _namespace_name "OneHundredEightyMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneMonth"></see>
    /// </summary>
    let OneMonth = Namespaced_IRI.parse _namespace_name "OneMonth" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneWeek"></see>
    /// </summary>
    let OneWeek = Namespaced_IRI.parse _namespace_name "OneWeek" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneYear"></see>
    /// </summary>
    let OneYear = Namespaced_IRI.parse _namespace_name "OneYear" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OvernightRate"></see>
    /// </summary>
    let OvernightRate =
        Namespaced_IRI.parse _namespace_name "OvernightRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SixMonths"></see>
    /// </summary>
    let SixMonths = Namespaced_IRI.parse _namespace_name "SixMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SixtyMonths"></see>
    /// </summary>
    let SixtyMonths =
        Namespaced_IRI.parse _namespace_name "SixtyMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SpecificProviderInterestRateBenchmark"></see>
    /// </summary>
    let SpecificProviderInterestRateBenchmark =
        Namespaced_IRI.parse _namespace_name "SpecificProviderInterestRateBenchmark" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TenYears"></see>
    /// </summary>
    let TenYears = Namespaced_IRI.parse _namespace_name "TenYears" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThirtySixMonths"></see>
    /// </summary>
    let ThirtySixMonths =
        Namespaced_IRI.parse _namespace_name "ThirtySixMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThirtyYears"></see>
    /// </summary>
    let ThirtyYears =
        Namespaced_IRI.parse _namespace_name "ThirtyYears" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeHundredSixtyMonths"></see>
    /// </summary>
    let ThreeHundredSixtyMonths =
        Namespaced_IRI.parse _namespace_name "ThreeHundredSixtyMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeMonths"></see>
    /// </summary>
    let ThreeMonths =
        Namespaced_IRI.parse _namespace_name "ThreeMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeYears"></see>
    /// </summary>
    let ThreeYears = Namespaced_IRI.parse _namespace_name "ThreeYears" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwelveMonths"></see>
    /// </summary>
    let TwelveMonths =
        Namespaced_IRI.parse _namespace_name "TwelveMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwentyFourMonths"></see>
    /// </summary>
    let TwentyFourMonths =
        Namespaced_IRI.parse _namespace_name "TwentyFourMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwentyYears"></see>
    /// </summary>
    let TwentyYears =
        Namespaced_IRI.parse _namespace_name "TwentyYears" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwoMonths"></see>
    /// </summary>
    let TwoMonths = Namespaced_IRI.parse _namespace_name "TwoMonths" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwoYears"></see>
    /// </summary>
    let TwoYears = Namespaced_IRI.parse _namespace_name "TwoYears" |> NamespacedName
