#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-loan-spc-crd`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/" "fibo-loan-spc-crd"

    let _namespaceIri = _prefixId.prefix ""
    let AmericanExpressNetwork = _prefixId.prefix "AmericanExpressNetwork"
    /// <summary>
    ///   <para>rdfs:label : card account^^xsd:string</para>
    ///   <para>skos:definition : account whose terms and conditions are defined in a card agreement that is represented by a payment card^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAccount">fibo-loan-spc-crd:CardAccount</a>
    /// </summary>
    let CardAccount = _prefixId.prefix "CardAccount"
    /// <summary>
    ///   <para>rdfs:label : card authentication value^^xsd:string</para>
    ///   <para>skos:definition : card verification value specifically for JCB payment cards^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CAV^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAuthenticationValue">fibo-loan-spc-crd:CardAuthenticationValue</a>
    /// </summary>
    let CardAuthenticationValue = _prefixId.prefix "CardAuthenticationValue"
    /// <summary>
    ///   <para>rdfs:label : card authentication value 2^^xsd:string</para>
    ///   <para>skos:definition : card verification value specifically for JCB payment cards^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : CAV2^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardAuthenticationValue2">fibo-loan-spc-crd:CardAuthenticationValue2</a>
    /// </summary>
    let CardAuthenticationValue2 = _prefixId.prefix "CardAuthenticationValue2"
    /// <summary>
    ///   <para>rdfs:label : card expiration date^^xsd:string</para>
    ///   <para>skos:definition : date on which a given payment card expires^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardExpirationDate">fibo-loan-spc-crd:CardExpirationDate</a>
    /// </summary>
    let CardExpirationDate = _prefixId.prefix "CardExpirationDate"
    /// <summary>
    ///   <para>rdfs:label : card identification number^^xsd:string</para>
    ///   <para>skos:definition : card verification value specifically for American Express and Discover payment cards^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CID^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardIdentificationNumber">fibo-loan-spc-crd:CardIdentificationNumber</a>
    /// </summary>
    let CardIdentificationNumber = _prefixId.prefix "CardIdentificationNumber"
    /// <summary>
    ///   <para>rdfs:label : card product^^xsd:string</para>
    ///   <para>skos:definition : financial product involving the issuance of credit, debit, or other payment cards^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardProduct">fibo-loan-spc-crd:CardProduct</a>
    /// </summary>
    let CardProduct = _prefixId.prefix "CardProduct"
    /// <summary>
    ///   <para>rdfs:label : card security code^^xsd:string</para>
    ///   <para>skos:definition : card verification value specifically for American Express payment cards^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CSC^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardSecurityCode">fibo-loan-spc-crd:CardSecurityCode</a>
    /// </summary>
    let CardSecurityCode = _prefixId.prefix "CardSecurityCode"
    /// <summary>
    ///   <para>rdfs:label : card validation code^^xsd:string</para>
    ///   <para>skos:definition : card verification code specifically for Mastercard payment cards^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : PAN CVC^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardValidationCode">fibo-loan-spc-crd:CardValidationCode</a>
    /// </summary>
    let CardValidationCode = _prefixId.prefix "CardValidationCode"
    /// <summary>
    ///   <para>rdfs:label : card validation code 2^^xsd:string</para>
    ///   <para>skos:definition : card verification value specifically for Mastercard payment cards^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : PAN CVC2^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardValidationCode2">fibo-loan-spc-crd:CardValidationCode2</a>
    /// </summary>
    let CardValidationCode2 = _prefixId.prefix "CardValidationCode2"
    /// <summary>
    ///   <para>rdfs:label : card verification code or value^^xsd:string</para>
    ///   <para>skos:definition : code that specifies either (1) magnetic-stripe data, or (2) printed security features that are used to protect data integrity and limit alteration, counterfeiting and fraud generally^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationCodeValue">fibo-loan-spc-crd:CardVerificationCodeValue</a>
    /// </summary>
    let CardVerificationCodeValue = _prefixId.prefix "CardVerificationCodeValue"
    /// <summary>
    ///   <para>rdfs:label : card verification value^^xsd:string</para>
    ///   <para>skos:definition : card verification value specifically for Visa and Discover payment cards^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CVV^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationValue">fibo-loan-spc-crd:CardVerificationValue</a>
    /// </summary>
    let CardVerificationValue = _prefixId.prefix "CardVerificationValue"
    /// <summary>
    ///   <para>rdfs:label : card verification value 2^^xsd:string</para>
    ///   <para>skos:definition : card verification value specifically for Visa payment cards^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : CVV2^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CardVerificationValue2">fibo-loan-spc-crd:CardVerificationValue2</a>
    /// </summary>
    let CardVerificationValue2 = _prefixId.prefix "CardVerificationValue2"
    /// <summary>
    ///   <para>rdfs:label : cardholder^^xsd:string</para>
    ///   <para>skos:definition : account holder to whom a payment card is issued^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/Cardholder">fibo-loan-spc-crd:Cardholder</a>
    /// </summary>
    let Cardholder = _prefixId.prefix "Cardholder"
    /// <summary>
    ///   <para>rdfs:label : commercial credit card agreement^^xsd:string</para>
    ///   <para>skos:definition : credit card agreement for a card issued to, or in conjunction with, a formal organization, such as a small business, middle market business, local, state, or national government, or large corporation^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.fdic.gov/regulations/examinations/credit_card/pdf_version/ch2.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Corporate card programs come in more than one form to serve different business needs. In general, they are contractual agreements between a sponsoring entity and a financial institution, in which the financial institution issues corporate cards to select employees of the sponsoring company.^^xsd:string</para>
    ///   <para>cmns-av:synonym : corporate credit card agreement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CommercialCreditCardAgreement">fibo-loan-spc-crd:CommercialCreditCardAgreement</a>
    /// </summary>
    let CommercialCreditCardAgreement = _prefixId.prefix "CommercialCreditCardAgreement"
    /// <summary>
    ///   <para>rdfs:label : consumer credit card agreement^^xsd:string</para>
    ///   <para>skos:definition : credit card agreement for a card issued for household, family, or other personal expenditures that is accessed by a borrower's use of a credit card^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.law.cornell.edu/cfr/text/12/228.12^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/ConsumerCreditCardAgreement">fibo-loan-spc-crd:ConsumerCreditCardAgreement</a>
    /// </summary>
    let ConsumerCreditCardAgreement = _prefixId.prefix "ConsumerCreditCardAgreement"
    /// <summary>
    ///   <para>rdfs:label : credit card^^xsd:string</para>
    ///   <para>skos:definition : card issued by a financial service provider that enables the cardholder to borrow funds^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.fdic.gov/regulations/examinations/credit_card/pdf_version/ch2.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : In its non-physical form, a credit card represents a payment mechanism which facilitates both consumer and commercial business transactions, including purchases and cash advances. A credit card generally operates as a substitute for cash or a check and most often provides an unsecured revolving line of credit. The borrower is required to pay at least part of the card's outstanding balance each billing cycle, depending on the terms as set forth in the cardholder agreement. As the debt reduces, the available credit increases for accounts in good standing. These complex financial arrangements have ever-shifting terms and prices. A charge card differs from a credit card in that the charge card must be paid in full each month.^^xsd:stringcmns-av:explanatoryNote : In physical form, a credit card traditionally is a thin, rectangular plastic card. The front of the card contains a series of numbers that are representative of various items such as the applicable network, bank, and account.^^xsd:stringcmns-av:explanatoryNote : Issuance of credit cards has the condition that the cardholder will pay back the original, borrowed amount plus any additional agreed-upon charges. The credit company provider may also grant a line of credit (LOC) to the cardholder which allows the holder to borrow money in the form of a cash advance. The issuer pre-sets borrowing limits which have a basis on the individual's credit rating.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCard">fibo-loan-spc-crd:CreditCard</a>
    /// </summary>
    let CreditCard = _prefixId.prefix "CreditCard"
    /// <summary>
    ///   <para>rdfs:label : credit card account^^xsd:string</para>
    ///   <para>skos:definition : card account whose terms and conditions are defined in a credit card agreement that is represented by a credit card^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardAccount">fibo-loan-spc-crd:CreditCardAccount</a>
    /// </summary>
    let CreditCardAccount = _prefixId.prefix "CreditCardAccount"
    /// <summary>
    ///   <para>rdfs:label : credit card agreement^^xsd:string</para>
    ///   <para>skos:definition : account-specific credit facility that specifies the terms and conditions under which the credit card is offered to the cardholder by the issuer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardAgreement">fibo-loan-spc-crd:CreditCardAgreement</a>
    /// </summary>
    let CreditCardAgreement = _prefixId.prefix "CreditCardAgreement"
    /// <summary>
    ///   <para>rdfs:label : credit card network^^xsd:string</para>
    ///   <para>skos:definition : classifier for the network that authorizes, processes, and sets the terms of credit card transactions, as well as transfers payments between shoppers, merchants, and their banks^^xsd:string</para>
    ///   <para>skos:example : Mastercard, Visa, American Express, Discover^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardNetwork">fibo-loan-spc-crd:CreditCardNetwork</a>
    /// </summary>
    let CreditCardNetwork = _prefixId.prefix "CreditCardNetwork"
    /// <summary>
    ///   <para>rdfs:label : credit card product^^xsd:string</para>
    ///   <para>skos:definition : card product allowing the holder to purchase goods or services on credit^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/CreditCardProduct">fibo-loan-spc-crd:CreditCardProduct</a>
    /// </summary>
    let CreditCardProduct = _prefixId.prefix "CreditCardProduct"
    /// <summary>
    ///   <para>rdfs:label : debit card^^xsd:string</para>
    ///   <para>skos:definition : payment card issued by a financial service provider that enables the cardholder to access funds in a demand deposit account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCard">fibo-loan-spc-crd:DebitCard</a>
    /// </summary>
    let DebitCard = _prefixId.prefix "DebitCard"
    /// <summary>
    ///   <para>rdfs:label : debit card account^^xsd:string</para>
    ///   <para>skos:definition : card account that is represented by a one or more debit cards^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCardAccount">fibo-loan-spc-crd:DebitCardAccount</a>
    /// </summary>
    let DebitCardAccount = _prefixId.prefix "DebitCardAccount"
    /// <summary>
    ///   <para>rdfs:label : debit card product^^xsd:string</para>
    ///   <para>skos:definition : card product card typically provided by a depository institution allowing the holder to transfer money electronically to another account when making a purchase^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/DebitCardProduct">fibo-loan-spc-crd:DebitCardProduct</a>
    /// </summary>
    let DebitCardProduct = _prefixId.prefix "DebitCardProduct"
    let DiscoverNetwork = _prefixId.prefix "DiscoverNetwork"
    /// <summary>
    ///   <para>rdfs:label : issuing financial institution^^xsd:string</para>
    ///   <para>skos:definition : issuer and financial services provider that issues payment cards or performs, facilitates, or supports issuing services including but not limited to issuing banks and issuing processors^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : issuing bank^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/IssuingFinancialInstitution">fibo-loan-spc-crd:IssuingFinancialInstitution</a>
    /// </summary>
    let IssuingFinancialInstitution = _prefixId.prefix "IssuingFinancialInstitution"
    let JCBNetwork = _prefixId.prefix "JCBNetwork"

    /// <summary>
    ///   <para>rdfs:label : magnetic stripe verification code or value^^xsd:string</para>
    ///   <para>skos:definition : card verification code on a card's magnetic stripe that uses secure cryptographic processes to protect data integrity on the stripe, and reveals any alteration or counterfeiting^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/MagneticStripeVerificationCodeValue">fibo-loan-spc-crd:MagneticStripeVerificationCodeValue</a>
    /// </summary>
    let MagneticStripeVerificationCodeValue =
        _prefixId.prefix "MagneticStripeVerificationCodeValue"

    let MastercardNetwork = _prefixId.prefix "MastercardNetwork"
    /// <summary>
    ///   <para>rdfs:label : payment card^^xsd:string</para>
    ///   <para>skos:definition : legal document issued by a financial services provider that enables the cardholder to access the funds in the customer's designated bank accounts, or through a credit account and make payments by electronic funds transfer and access automated teller machines (ATMs)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For purposes of Payment Card Industry Data Security Standard (PCI DSS), a payment card is any payment card/device that bears the logo of the founding members of PCI SSC, which are American Express, Discover Financial Services, JCB International, MasterCard, or Visa, Inc.^^xsd:stringcmns-av:explanatoryNote : The term payment card includes credit cards, debit cards, and stored-value cards, as well as payment through any distinctive marks of a payment card (such as a credit card number). A payment card is issued under an agreement that provides standards and mechanisms for settling the transactions between a merchant acquiring bank or similar entity and the providers who accept the cards as payment.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PaymentCard">fibo-loan-spc-crd:PaymentCard</a>
    /// </summary>
    let PaymentCard = _prefixId.prefix "PaymentCard"
    /// <summary>
    ///   <para>rdfs:label : payment card agreement^^xsd:string</para>
    ///   <para>skos:definition : account-specific credit agreement that specifies the terms and conditions under which the payment card is offered to the cardholder by the issuer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PaymentCardAgreement">fibo-loan-spc-crd:PaymentCardAgreement</a>
    /// </summary>
    let PaymentCardAgreement = _prefixId.prefix "PaymentCardAgreement"
    /// <summary>
    ///   <para>rdfs:label : primary card account number^^xsd:string</para>
    ///   <para>skos:definition : composite identifier of 14 or 16 digits embossed on a bank or payment card and encoded in the card's magnetic strip^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : PAN^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The PAN identifies the issuer of the card and the account including part of the account number, and contains a check digit that verifies the authenticity of the embossed account number.^^xsd:string</para>
    ///   <para>cmns-av:synonym : primary account number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/PrimaryCardAccountNumber">fibo-loan-spc-crd:PrimaryCardAccountNumber</a>
    /// </summary>
    let PrimaryCardAccountNumber = _prefixId.prefix "PrimaryCardAccountNumber"
    /// <summary>
    ///   <para>rdfs:label : smart card^^xsd:string</para>
    ///   <para>skos:definition : payment card that has integrated circuits embedded within it^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The circuits, also referred to as the 'chip,' contain payment card data including but not limited to data equivalent to the magnetic-stripe data.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/SmartCard">fibo-loan-spc-crd:SmartCard</a>
    /// </summary>
    let SmartCard = _prefixId.prefix "SmartCard"

    /// <summary>
    ///   <para>rdfs:label : three-digit verification code or value^^xsd:string</para>
    ///   <para>skos:definition : card verification code that is the rightmost three-digit value printed in the signature panel area on the back of the card^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.pcisecuritystandards.org/pci_security/glossary^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/ThreeDigitVerificationCodeValue">fibo-loan-spc-crd:ThreeDigitVerificationCodeValue</a>
    /// </summary>
    let ThreeDigitVerificationCodeValue =
        _prefixId.prefix "ThreeDigitVerificationCodeValue"

    let VisaNetwork = _prefixId.prefix "VisaNetwork"
    /// <summary>
    ///   <para>rdfs:label : has card verification code^^xsd:string</para>
    ///   <para>skos:definition : links a credit card to either: (1) magnetic-stripe data, or (2) printed security features that are used to protect data integrity and limit alteration, counterfeiting and fraud generally^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasCardVerificationCode">fibo-loan-spc-crd:hasCardVerificationCode</a>
    /// </summary>
    let hasCardVerificationCode = _prefixId.prefix "hasCardVerificationCode"
    /// <summary>
    ///   <para>rdfs:label : has credit card network^^xsd:string</para>
    ///   <para>skos:definition : indicates the underlying network for credit card product^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasCreditCardNetwork">fibo-loan-spc-crd:hasCreditCardNetwork</a>
    /// </summary>
    let hasCreditCardNetwork = _prefixId.prefix "hasCreditCardNetwork"
    /// <summary>
    ///   <para>rdfs:label : has primary account number^^xsd:string</para>
    ///   <para>skos:definition : specifies the account number displayed on the face of the card^^xsd:string</para>
    ///   <para>skos:editorialNote : modeled independently of 'identifies' in order to circumvent circular reasoning challenges^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/hasPrimaryAccountNumber">fibo-loan-spc-crd:hasPrimaryAccountNumber</a>
    /// </summary>
    let hasPrimaryAccountNumber = _prefixId.prefix "hasPrimaryAccountNumber"
    /// <summary>
    ///   <para>rdfs:label : uses currency^^xsd:string</para>
    ///   <para>skos:definition : indicates the currency defined for the credit card product^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/usesCurrency">fibo-loan-spc-crd:usesCurrency</a>
    /// </summary>
    let usesCurrency = _prefixId.prefix "usesCurrency"
