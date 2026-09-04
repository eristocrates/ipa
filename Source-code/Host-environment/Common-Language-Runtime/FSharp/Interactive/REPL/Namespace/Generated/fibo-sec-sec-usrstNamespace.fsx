#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-usrst`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/" "fibo-sec-sec-usrst"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : blue sky law^^xsd:string</para>
    ///   <para>skos:definition : state-level securities regulation, designed to protect investors against securities fraud that require issuers to be registered and to disclose details of their offerings^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This allows investors to base their judgments on trustworthy data.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Blue sky law is modeled as a class, rather than as a named individual, because there are numerous state-specific laws that qualify as blue sky laws that could be added to support state-specific definitions and other analyses.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/BlueSkyLaw">fibo-sec-sec-usrst:BlueSkyLaw</a>
    /// </summary>
    let BlueSkyLaw = _prefixId.prefix "BlueSkyLaw"
    let RegulationD = _prefixId.prefix "RegulationD"
    let RegulationS = _prefixId.prefix "RegulationS"
    let Rule144A = _prefixId.prefix "Rule144A"
    let SECExemption3c7 = _prefixId.prefix "SECExemption3c7"
    let SECRule15c3_3 = _prefixId.prefix "SECRule15c3-3"
    let SECRule201 = _prefixId.prefix "SECRule201"
    let TEFRACRule = _prefixId.prefix "TEFRACRule"
    let TEFRADRule = _prefixId.prefix "TEFRADRule"

    /// <summary>
    ///   <para>rdfs:label : is Employee Retirement Income Security Act conformant^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the security conforms to the Employee Retirement Income Security Act (ERISA) of 1974, a federal outline for regulating employee benefit plans, including healthcare plans sponsored and/or insured by an employer^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Code Title 29, Chapter 18, Subchapter I, Section 1002 provides definitions related to employee benefit plans. Specifically, this section outlines the terms used in ERISA, including definitions for various types of plans such as employee welfare benefit plans, employee pension benefit plans, and others. See https://www.law.cornell.edu/uscode/text/29/1002.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The Employee Retirement Income Security Act (ERISA) is a federal law that establishes standards for certain employer-sponsored retirement and health plans. It has undergone several changes since its initial enactment in 1974. ERISA aims to protect individuals participating in these plans by prohibiting fiduciaries from misusing funds and setting standards for participation, benefit accrual, vesting, and funding of retirement plans^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/isEmployeeRetirementIncomeSecurityActConformant">fibo-sec-sec-usrst:isEmployeeRetirementIncomeSecurityActConformant</a>
    /// </summary>
    let isEmployeeRetirementIncomeSecurityActConformant =
        _prefixId.prefix "isEmployeeRetirementIncomeSecurityActConformant"

    /// <summary>
    ///   <para>rdfs:label : is Federal Deposit Insurance Corporation insured^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the security is covered by Federal Deposit Insurance Corporation (FDIC) insurance^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : FDIC coverage extends to Certificates of Deposit (CDs) and Money Market Accounts (MMAs) held at FDIC-insured institutions up to $250,000 per account.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that this property applies to the account rather than to the associated instrument that, if it exists, exemplifies the account.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/isFederalDepositInsuranceCorporationInsured">fibo-sec-sec-usrst:isFederalDepositInsuranceCorporationInsured</a>
    /// </summary>
    let isFederalDepositInsuranceCorporationInsured =
        _prefixId.prefix "isFederalDepositInsuranceCorporationInsured"

    /// <summary>
    ///   <para>rdfs:label : is subject to Federal Reserve Board Regulation T^^xsd:string</para>
    ///   <para>skos:definition : indicates whether a given cash or margin account is subject to Federal Reserve Board (FRB) margin requirements^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Federal Reserve Board (FRB) Regulation T governs the extension of credit by securities brokers and dealers in the United States. Its best-known function is the control of margin requirements for stocks bought on margin. Regulation T gives an investor a maximum of four business days to pay for securities purchased in a cash or margin account. If payment due exceeds $1,000 and is not received by the end of this time period, the broker-dealer must either liquidate the position or apply for and receive an extensionfrom its designated examining authority, such as FINRA.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that this property applies to the account, which may be a ledger account.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/isSubjectToFederalReserveBoardRegulationT">fibo-sec-sec-usrst:isSubjectToFederalReserveBoardRegulationT</a>
    /// </summary>
    let isSubjectToFederalReserveBoardRegulationT =
        _prefixId.prefix "isSubjectToFederalReserveBoardRegulationT"
