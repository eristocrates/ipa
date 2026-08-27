namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.CardAccounts.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_spc_crd =
    let _namespace_iri = Namespace_Iri fibo_loan_spc_crd |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-spc-crd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Card Accounts Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_spc_crd, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:AmericanExpressNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-loan-spc-crd:CreditCardNetwork</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"American Express network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/AmericanExpressNetwork">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/AmericanExpressNetwork</seealso>
    let AmericanExpressNetwork =
        Prefixed_Name(fibo_loan_spc_crd, "AmericanExpressNetwork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAccount">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAccount</seealso>
    let CardAccount = Prefixed_Name(fibo_loan_spc_crd, "CardAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardAuthenticationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card authentication value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAuthenticationValue">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAuthenticationValue</seealso>
    let CardAuthenticationValue =
        Prefixed_Name(fibo_loan_spc_crd, "CardAuthenticationValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardAuthenticationValue2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card authentication value 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAuthenticationValue2">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAuthenticationValue2</seealso>
    let CardAuthenticationValue2 =
        Prefixed_Name(fibo_loan_spc_crd, "CardAuthenticationValue2") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardExpirationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card expiration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardExpirationDate">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardExpirationDate</seealso>
    let CardExpirationDate =
        Prefixed_Name(fibo_loan_spc_crd, "CardExpirationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardIdentificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card identification number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardIdentificationNumber">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardIdentificationNumber</seealso>
    let CardIdentificationNumber =
        Prefixed_Name(fibo_loan_spc_crd, "CardIdentificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardProduct">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardProduct</seealso>
    let CardProduct = Prefixed_Name(fibo_loan_spc_crd, "CardProduct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardSecurityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card security code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardSecurityCode">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardSecurityCode</seealso>
    let CardSecurityCode =
        Prefixed_Name(fibo_loan_spc_crd, "CardSecurityCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardValidationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card validation code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardValidationCode">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardValidationCode</seealso>
    let CardValidationCode =
        Prefixed_Name(fibo_loan_spc_crd, "CardValidationCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardValidationCode2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card validation code 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardValidationCode2">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardValidationCode2</seealso>
    let CardValidationCode2 =
        Prefixed_Name(fibo_loan_spc_crd, "CardValidationCode2") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardVerificationCodeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card verification code or value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationCodeValue">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationCodeValue</seealso>
    let CardVerificationCodeValue =
        Prefixed_Name(fibo_loan_spc_crd, "CardVerificationCodeValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardVerificationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card verification value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationValue">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationValue</seealso>
    let CardVerificationValue =
        Prefixed_Name(fibo_loan_spc_crd, "CardVerificationValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CardVerificationValue2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"card verification value 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationValue2">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationValue2</seealso>
    let CardVerificationValue2 =
        Prefixed_Name(fibo_loan_spc_crd, "CardVerificationValue2") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:Cardholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cardholder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/Cardholder">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/Cardholder</seealso>
    let Cardholder = Prefixed_Name(fibo_loan_spc_crd, "Cardholder") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CommercialCreditCardAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commercial credit card agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CommercialCreditCardAgreement">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CommercialCreditCardAgreement</seealso>
    let CommercialCreditCardAgreement =
        Prefixed_Name(fibo_loan_spc_crd, "CommercialCreditCardAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:ConsumerCreditCardAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consumer credit card agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/ConsumerCreditCardAgreement">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/ConsumerCreditCardAgreement</seealso>
    let ConsumerCreditCardAgreement =
        Prefixed_Name(fibo_loan_spc_crd, "ConsumerCreditCardAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CreditCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit card"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCard">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCard</seealso>
    let CreditCard = Prefixed_Name(fibo_loan_spc_crd, "CreditCard") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CreditCardAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit card account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardAccount">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardAccount</seealso>
    let CreditCardAccount =
        Prefixed_Name(fibo_loan_spc_crd, "CreditCardAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CreditCardAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit card agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardAgreement">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardAgreement</seealso>
    let CreditCardAgreement =
        Prefixed_Name(fibo_loan_spc_crd, "CreditCardAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CreditCardNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit card network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardNetwork">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardNetwork</seealso>
    let CreditCardNetwork =
        Prefixed_Name(fibo_loan_spc_crd, "CreditCardNetwork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:CreditCardProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit card product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardProduct">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardProduct</seealso>
    let CreditCardProduct =
        Prefixed_Name(fibo_loan_spc_crd, "CreditCardProduct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:DebitCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debit card"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCard">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCard</seealso>
    let DebitCard = Prefixed_Name(fibo_loan_spc_crd, "DebitCard") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:DebitCardAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debit card account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCardAccount">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCardAccount</seealso>
    let DebitCardAccount =
        Prefixed_Name(fibo_loan_spc_crd, "DebitCardAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:DebitCardProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debit card product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCardProduct">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCardProduct</seealso>
    let DebitCardProduct =
        Prefixed_Name(fibo_loan_spc_crd, "DebitCardProduct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:DiscoverNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-loan-spc-crd:CreditCardNetwork</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Discover network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DiscoverNetwork">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DiscoverNetwork</seealso>
    let DiscoverNetwork =
        Prefixed_Name(fibo_loan_spc_crd, "DiscoverNetwork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:IssuingFinancialInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"issuing financial institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/IssuingFinancialInstitution">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/IssuingFinancialInstitution</seealso>
    let IssuingFinancialInstitution =
        Prefixed_Name(fibo_loan_spc_crd, "IssuingFinancialInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:JCBNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-loan-spc-crd:CreditCardNetwork</para>
    ///
    /// labels<para>"JCB network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/JCBNetwork">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/JCBNetwork</seealso>
    let JCBNetwork = Prefixed_Name(fibo_loan_spc_crd, "JCBNetwork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:MagneticStripeVerificationCodeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"magnetic stripe verification code or value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/MagneticStripeVerificationCodeValue">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/MagneticStripeVerificationCodeValue</seealso>
    let MagneticStripeVerificationCodeValue =
        Prefixed_Name(fibo_loan_spc_crd, "MagneticStripeVerificationCodeValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:MastercardNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-loan-spc-crd:CreditCardNetwork</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mastercard network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/MastercardNetwork">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/MastercardNetwork</seealso>
    let MastercardNetwork =
        Prefixed_Name(fibo_loan_spc_crd, "MastercardNetwork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:PaymentCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment card"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PaymentCard">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PaymentCard</seealso>
    let PaymentCard = Prefixed_Name(fibo_loan_spc_crd, "PaymentCard") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:PaymentCardAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment card agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PaymentCardAgreement">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PaymentCardAgreement</seealso>
    let PaymentCardAgreement =
        Prefixed_Name(fibo_loan_spc_crd, "PaymentCardAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:PrimaryCardAccountNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primary card account number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PrimaryCardAccountNumber">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PrimaryCardAccountNumber</seealso>
    let PrimaryCardAccountNumber =
        Prefixed_Name(fibo_loan_spc_crd, "PrimaryCardAccountNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:SmartCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"smart card"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/SmartCard">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/SmartCard</seealso>
    let SmartCard = Prefixed_Name(fibo_loan_spc_crd, "SmartCard") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:ThreeDigitVerificationCodeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"three-digit verification code or value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/ThreeDigitVerificationCodeValue">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/ThreeDigitVerificationCodeValue</seealso>
    let ThreeDigitVerificationCodeValue =
        Prefixed_Name(fibo_loan_spc_crd, "ThreeDigitVerificationCodeValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:VisaNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-loan-spc-crd:CreditCardNetwork</para>
    ///
    /// labels<para>"Visa network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/VisaNetwork">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/VisaNetwork</seealso>
    let VisaNetwork = Prefixed_Name(fibo_loan_spc_crd, "VisaNetwork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:hasCardVerificationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has card verification code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasCardVerificationCode">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasCardVerificationCode</seealso>
    let hasCardVerificationCode =
        Prefixed_Name(fibo_loan_spc_crd, "hasCardVerificationCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:hasCreditCardNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has credit card network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasCreditCardNetwork">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasCreditCardNetwork</seealso>
    let hasCreditCardNetwork =
        Prefixed_Name(fibo_loan_spc_crd, "hasCreditCardNetwork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:hasPrimaryAccountNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has primary account number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasPrimaryAccountNumber">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasPrimaryAccountNumber</seealso>
    let hasPrimaryAccountNumber =
        Prefixed_Name(fibo_loan_spc_crd, "hasPrimaryAccountNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-crd:usesCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/usesCurrency">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/usesCurrency</seealso>
    let usesCurrency = Prefixed_Name(fibo_loan_spc_crd, "usesCurrency") |> PrefixedName
