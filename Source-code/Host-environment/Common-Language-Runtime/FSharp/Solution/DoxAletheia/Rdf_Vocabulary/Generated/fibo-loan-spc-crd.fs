namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.CardAccounts.slash

open DoxAletheia

module fibo_loan_spc_crd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/AmericanExpressNetwork"></see>
    /// </summary>
    let AmericanExpressNetwork = _prefix "AmericanExpressNetwork"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardNetwork"></see>
    /// </summary>
    let CreditCardNetwork = _prefix "CreditCardNetwork"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAccount"></see>
    /// </summary>
    let CardAccount = _prefix "CardAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/Cardholder"></see>
    /// </summary>
    let Cardholder = _prefix "Cardholder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardProduct"></see>
    /// </summary>
    let CardProduct = _prefix "CardProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PaymentCardAgreement"></see>
    /// </summary>
    let PaymentCardAgreement = _prefix "PaymentCardAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PaymentCard"></see>
    /// </summary>
    let PaymentCard = _prefix "PaymentCard"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PrimaryCardAccountNumber"></see>
    /// </summary>
    let PrimaryCardAccountNumber = _prefix "PrimaryCardAccountNumber"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAuthenticationValue"></see>
    /// </summary>
    let CardAuthenticationValue = _prefix "CardAuthenticationValue"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/MagneticStripeVerificationCodeValue"></see>
    /// </summary>
    let MagneticStripeVerificationCodeValue =
        _prefix "MagneticStripeVerificationCodeValue"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAuthenticationValue2"></see>
    /// </summary>
    let CardAuthenticationValue2 = _prefix "CardAuthenticationValue2"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/ThreeDigitVerificationCodeValue"></see>
    /// </summary>
    let ThreeDigitVerificationCodeValue = _prefix "ThreeDigitVerificationCodeValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardExpirationDate"></see>
    /// </summary>
    let CardExpirationDate = _prefix "CardExpirationDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardIdentificationNumber"></see>
    /// </summary>
    let CardIdentificationNumber = _prefix "CardIdentificationNumber"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasCreditCardNetwork"></see>
    /// </summary>
    let hasCreditCardNetwork = _prefix "hasCreditCardNetwork"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/usesCurrency"></see>
    /// </summary>
    let usesCurrency = _prefix "usesCurrency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardSecurityCode"></see>
    /// </summary>
    let CardSecurityCode = _prefix "CardSecurityCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardValidationCode"></see>
    /// </summary>
    let CardValidationCode = _prefix "CardValidationCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardValidationCode2"></see>
    /// </summary>
    let CardValidationCode2 = _prefix "CardValidationCode2"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationCodeValue"></see>
    /// </summary>
    let CardVerificationCodeValue = _prefix "CardVerificationCodeValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationValue"></see>
    /// </summary>
    let CardVerificationValue = _prefix "CardVerificationValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationValue2"></see>
    /// </summary>
    let CardVerificationValue2 = _prefix "CardVerificationValue2"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CommercialCreditCardAgreement"></see>
    /// </summary>
    let CommercialCreditCardAgreement = _prefix "CommercialCreditCardAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardAgreement"></see>
    /// </summary>
    let CreditCardAgreement = _prefix "CreditCardAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/ConsumerCreditCardAgreement"></see>
    /// </summary>
    let ConsumerCreditCardAgreement = _prefix "ConsumerCreditCardAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCard"></see>
    /// </summary>
    let CreditCard = _prefix "CreditCard"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardAccount"></see>
    /// </summary>
    let CreditCardAccount = _prefix "CreditCardAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardProduct"></see>
    /// </summary>
    let CreditCardProduct = _prefix "CreditCardProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/IssuingFinancialInstitution"></see>
    /// </summary>
    let IssuingFinancialInstitution = _prefix "IssuingFinancialInstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCard"></see>
    /// </summary>
    let DebitCard = _prefix "DebitCard"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCardAccount"></see>
    /// </summary>
    let DebitCardAccount = _prefix "DebitCardAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCardProduct"></see>
    /// </summary>
    let DebitCardProduct = _prefix "DebitCardProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DiscoverNetwork"></see>
    /// </summary>
    let DiscoverNetwork = _prefix "DiscoverNetwork"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/JCBNetwork"></see>
    /// </summary>
    let JCBNetwork = _prefix "JCBNetwork"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/MastercardNetwork"></see>
    /// </summary>
    let MastercardNetwork = _prefix "MastercardNetwork"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasCardVerificationCode"></see>
    /// </summary>
    let hasCardVerificationCode = _prefix "hasCardVerificationCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasPrimaryAccountNumber"></see>
    /// </summary>
    let hasPrimaryAccountNumber = _prefix "hasPrimaryAccountNumber"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/SmartCard"></see>
    /// </summary>
    let SmartCard = _prefix "SmartCard"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/VisaNetwork"></see>
    /// </summary>
    let VisaNetwork = _prefix "VisaNetwork"
