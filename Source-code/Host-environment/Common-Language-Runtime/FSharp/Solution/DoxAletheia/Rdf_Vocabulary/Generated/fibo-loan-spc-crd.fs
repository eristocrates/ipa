namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.CardAccounts.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_spc_crd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/AmericanExpressNetwork"></see>
    /// </summary>
    let AmericanExpressNetwork =
        Namespaced_IRI.parse _namespace_name "AmericanExpressNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardNetwork"></see>
    /// </summary>
    let CreditCardNetwork =
        Namespaced_IRI.parse _namespace_name "CreditCardNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAccount"></see>
    /// </summary>
    let CardAccount =
        Namespaced_IRI.parse _namespace_name "CardAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/Cardholder"></see>
    /// </summary>
    let Cardholder = Namespaced_IRI.parse _namespace_name "Cardholder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardProduct"></see>
    /// </summary>
    let CardProduct =
        Namespaced_IRI.parse _namespace_name "CardProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PaymentCardAgreement"></see>
    /// </summary>
    let PaymentCardAgreement =
        Namespaced_IRI.parse _namespace_name "PaymentCardAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PaymentCard"></see>
    /// </summary>
    let PaymentCard =
        Namespaced_IRI.parse _namespace_name "PaymentCard" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PrimaryCardAccountNumber"></see>
    /// </summary>
    let PrimaryCardAccountNumber =
        Namespaced_IRI.parse _namespace_name "PrimaryCardAccountNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAuthenticationValue"></see>
    /// </summary>
    let CardAuthenticationValue =
        Namespaced_IRI.parse _namespace_name "CardAuthenticationValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/MagneticStripeVerificationCodeValue"></see>
    /// </summary>
    let MagneticStripeVerificationCodeValue =
        Namespaced_IRI.parse _namespace_name "MagneticStripeVerificationCodeValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAuthenticationValue2"></see>
    /// </summary>
    let CardAuthenticationValue2 =
        Namespaced_IRI.parse _namespace_name "CardAuthenticationValue2" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/ThreeDigitVerificationCodeValue"></see>
    /// </summary>
    let ThreeDigitVerificationCodeValue =
        Namespaced_IRI.parse _namespace_name "ThreeDigitVerificationCodeValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardExpirationDate"></see>
    /// </summary>
    let CardExpirationDate =
        Namespaced_IRI.parse _namespace_name "CardExpirationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardIdentificationNumber"></see>
    /// </summary>
    let CardIdentificationNumber =
        Namespaced_IRI.parse _namespace_name "CardIdentificationNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasCreditCardNetwork"></see>
    /// </summary>
    let hasCreditCardNetwork =
        Namespaced_IRI.parse _namespace_name "hasCreditCardNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/usesCurrency"></see>
    /// </summary>
    let usesCurrency =
        Namespaced_IRI.parse _namespace_name "usesCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardSecurityCode"></see>
    /// </summary>
    let CardSecurityCode =
        Namespaced_IRI.parse _namespace_name "CardSecurityCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardValidationCode"></see>
    /// </summary>
    let CardValidationCode =
        Namespaced_IRI.parse _namespace_name "CardValidationCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardValidationCode2"></see>
    /// </summary>
    let CardValidationCode2 =
        Namespaced_IRI.parse _namespace_name "CardValidationCode2" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationCodeValue"></see>
    /// </summary>
    let CardVerificationCodeValue =
        Namespaced_IRI.parse _namespace_name "CardVerificationCodeValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationValue"></see>
    /// </summary>
    let CardVerificationValue =
        Namespaced_IRI.parse _namespace_name "CardVerificationValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationValue2"></see>
    /// </summary>
    let CardVerificationValue2 =
        Namespaced_IRI.parse _namespace_name "CardVerificationValue2" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CommercialCreditCardAgreement"></see>
    /// </summary>
    let CommercialCreditCardAgreement =
        Namespaced_IRI.parse _namespace_name "CommercialCreditCardAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardAgreement"></see>
    /// </summary>
    let CreditCardAgreement =
        Namespaced_IRI.parse _namespace_name "CreditCardAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/ConsumerCreditCardAgreement"></see>
    /// </summary>
    let ConsumerCreditCardAgreement =
        Namespaced_IRI.parse _namespace_name "ConsumerCreditCardAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCard"></see>
    /// </summary>
    let CreditCard = Namespaced_IRI.parse _namespace_name "CreditCard" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardAccount"></see>
    /// </summary>
    let CreditCardAccount =
        Namespaced_IRI.parse _namespace_name "CreditCardAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardProduct"></see>
    /// </summary>
    let CreditCardProduct =
        Namespaced_IRI.parse _namespace_name "CreditCardProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/IssuingFinancialInstitution"></see>
    /// </summary>
    let IssuingFinancialInstitution =
        Namespaced_IRI.parse _namespace_name "IssuingFinancialInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCard"></see>
    /// </summary>
    let DebitCard = Namespaced_IRI.parse _namespace_name "DebitCard" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCardAccount"></see>
    /// </summary>
    let DebitCardAccount =
        Namespaced_IRI.parse _namespace_name "DebitCardAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCardProduct"></see>
    /// </summary>
    let DebitCardProduct =
        Namespaced_IRI.parse _namespace_name "DebitCardProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DiscoverNetwork"></see>
    /// </summary>
    let DiscoverNetwork =
        Namespaced_IRI.parse _namespace_name "DiscoverNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/JCBNetwork"></see>
    /// </summary>
    let JCBNetwork = Namespaced_IRI.parse _namespace_name "JCBNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/MastercardNetwork"></see>
    /// </summary>
    let MastercardNetwork =
        Namespaced_IRI.parse _namespace_name "MastercardNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasCardVerificationCode"></see>
    /// </summary>
    let hasCardVerificationCode =
        Namespaced_IRI.parse _namespace_name "hasCardVerificationCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasPrimaryAccountNumber"></see>
    /// </summary>
    let hasPrimaryAccountNumber =
        Namespaced_IRI.parse _namespace_name "hasPrimaryAccountNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/SmartCard"></see>
    /// </summary>
    let SmartCard = Namespaced_IRI.parse _namespace_name "SmartCard" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/VisaNetwork"></see>
    /// </summary>
    let VisaNetwork =
        Namespaced_IRI.parse _namespace_name "VisaNetwork" |> NamespacedName
