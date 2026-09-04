#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-sbd-sbd`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/" "fibo-der-sbd-sbd"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : basket of debt instruments</para>
    ///   <para>skos:definition : basket of securities whose constituents are debt instruments</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/BasketOfDebtInstruments">fibo-der-sbd-sbd:BasketOfDebtInstruments</a>
    /// </summary>
    let BasketOfDebtInstruments = _prefixId.prefix "BasketOfDebtInstruments"

    /// <summary>
    ///   <para>rdfs:label : capitalized lease obligation debt basket</para>
    ///   <para>skos:definition : basket of debt instruments whose constituents are contracts entitling a renter the temporary use of an asset and, in accounting terms, has asset ownership characteristics</para>
    ///   <para>cmns-av:explanatoryNote : A capitalized lease obligation basket is increasingly broadly drafted to include indebtedness incurred to finance the purchase, improvement, repair, renewal etc. of property (including the purchase of stock of a person owning such property).</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/CapitalizedLeaseObligationDebtBasket">fibo-der-sbd-sbd:CapitalizedLeaseObligationDebtBasket</a>
    /// </summary>
    let CapitalizedLeaseObligationDebtBasket =
        _prefixId.prefix "CapitalizedLeaseObligationDebtBasket"

    /// <summary>
    ///   <para>rdfs:label : contribution debt basket</para>
    ///   <para>skos:definition : basket of debt instruments that allows a company to incur an amount of indebtedness that is equal to (or in top tier sponsor transactions in the U.S., up to two times) the amount of equity contributed to the group</para>
    ///   <para>cmns-av:explanatoryNote : A non-guarantor debt basket is often also permitted to be secured by assets of a subsidiary other than the issuer/borrower or guarantors.cmns-av:explanatoryNote : In U.S. law, a non-guarantor debt basket is a shared basket in an amount not to exceed the greater of $150,000,000 and 20% of Consolidated EBITDA for the most recently ended Test Period at any time outstanding that may be used for (A) the incurrence of certain Indebtedness by Restricted Subsidiaries that are not Loan Parties under Sections 6.01(a)(xii), 6.01(a)(xix) and 6.01(a)(xx) and (B) Secured Cash Management Obligations of any Restricted Subsidiary that is not a Loan Party.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/ContributionDebtBasket">fibo-der-sbd-sbd:ContributionDebtBasket</a>
    /// </summary>
    let ContributionDebtBasket = _prefixId.prefix "ContributionDebtBasket"
    /// <summary>
    ///   <para>rdfs:label : credit facility debt basket</para>
    ///   <para>skos:definition : basket of securities whose constituents are credit agreements that allow the borrower to periodically take out money over an extended period of time rather than reapplying for a loan every time they need funds</para>
    ///   <para>cmns-av:explanatoryNote : The credit facility debt basket consists of a number of credit facilities including revolving loans/line of credit, committed facilities, letters of credit and most retail credit accounts. The first port of call for issuers is the credit facility debt basket. In addition to the fixed dollar (or euro) amounts, credit facility debt baskets in senior secured notes and indentures typically provide for a grower component that is the greater of the fixed dollar/euro amount and a percentage of total assets, total tangible assets or EBITDA.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/CreditFacilityDebtBasket">fibo-der-sbd-sbd:CreditFacilityDebtBasket</a>
    /// </summary>
    let CreditFacilityDebtBasket = _prefixId.prefix "CreditFacilityDebtBasket"
    /// <summary>
    ///   <para>rdfs:label : debt instrument derivative^^xsd:string</para>
    ///   <para>skos:definition : security-based derivative whose underlier is a debt observable^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/DebtInstrumentDerivative">fibo-der-sbd-sbd:DebtInstrumentDerivative</a>
    /// </summary>
    let DebtInstrumentDerivative = _prefixId.prefix "DebtInstrumentDerivative"
    /// <summary>
    ///   <para>rdfs:label : equity derivative^^xsd:string</para>
    ///   <para>skos:definition : security-based derivative whose underlier is based on equities (e.g. shares, basket of equities or index) or their cashflow(s)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/EquityDerivative">fibo-der-sbd-sbd:EquityDerivative</a>
    /// </summary>
    let EquityDerivative = _prefixId.prefix "EquityDerivative"
    /// <summary>
    ///   <para>rdfs:label : general debt basket</para>
    ///   <para>skos:definition : basket of debt instruments that provides additional capacity for potential funding and does not require the proceeds to be used for any particular purpose</para>
    ///   <para>cmns-av:explanatoryNote : The general debt basket has increasingly become a basket for additional secured debt. Lenders providing funding to companies need to carefully consider whether any previous debt incurred by the company using this basket has reduced the available capacity.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/GeneralDebtBasket">fibo-der-sbd-sbd:GeneralDebtBasket</a>
    /// </summary>
    let GeneralDebtBasket = _prefixId.prefix "GeneralDebtBasket"
    /// <summary>
    ///   <para>rdfs:label : incremental facility debt basket</para>
    ///   <para>skos:definition : basket of credit facilities whose constituents are extensible, allowing companies to borrow an additional term loan or revolving credit facility (or increase the commitments applicable thereto) under the same credit agreement subject to certain parameters</para>
    ///   <para>cmns-av:explanatoryNote : The incremental debt basket is available to borrowers and guarantors only; it cannot be used by non-guarantor entities to raise indebtedness. The size of the incremental debt basket varies depending on the size and creditworthiness of the credit group. The principle of a basket consists of allowing the borrower, up to a maximum determined amount, to make restricted payments, disposals or investments, or take on incremental debt. Commonly, a basket is expressed as subject to restrictions based on a fixed ('hard cap') amount (e.g., may not exceed EUR 5,000,000).</para>
    ///   <para>cmns-av:synonym : builder basket</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/IncrementalFacilityDebtBasket">fibo-der-sbd-sbd:IncrementalFacilityDebtBasket</a>
    /// </summary>
    let IncrementalFacilityDebtBasket = _prefixId.prefix "IncrementalFacilityDebtBasket"
    /// <summary>
    ///   <para>rdfs:label : local lines of credit debt basket</para>
    ///   <para>skos:definition : basket of debt instruments that may be relevant for companies with international operations, often permitting debt to be incurred by a non-guarantor restricted subsidiary</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/LocalLinesOfCreditDebtBasket">fibo-der-sbd-sbd:LocalLinesOfCreditDebtBasket</a>
    /// </summary>
    let LocalLinesOfCreditDebtBasket = _prefixId.prefix "LocalLinesOfCreditDebtBasket"
    /// <summary>
    ///   <para>rdfs:label : non-guarantor debt basket</para>
    ///   <para>skos:definition : basket of debt instruments that include a provision allowing certain subsidiaries within a corporate group, which are not part of the loan guarantee, to incur a specified amount of indebtedness</para>
    ///   <para>cmns-av:explanatoryNote : A non-guarantor debt basket is often also permitted to be secured by assets of a subsidiary other than the issuer/borrower or guarantors.cmns-av:explanatoryNote : In U.S. law, a non-guarantor debt basket is a shared basket in an amount not to exceed the greater of $150,000,000 and 20% of Consolidated EBITDA for the most recently ended Test Period at any time outstanding that may be used for (A) the incurrence of certain Indebtedness by Restricted Subsidiaries that are not Loan Parties under Sections 6.01(a)(xii), 6.01(a)(xix) and 6.01(a)(xx) and (B) Secured Cash Management Obligations of any Restricted Subsidiary that is not a Loan Party.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/Non-GuarantorDebtBasket">fibo-der-sbd-sbd:Non-GuarantorDebtBasket</a>
    /// </summary>
    let Non_GuarantorDebtBasket = _prefixId.prefix "Non-GuarantorDebtBasket"
    /// <summary>
    ///   <para>rdfs:label : ratio debt basket</para>
    ///   <para>skos:definition : basket of debt instruments whose constituents are specified based on a leverage ratio based on total debt rather than only secured debt</para>
    ///   <para>cmns-av:explanatoryNote : The ratio basket provides different ratio tests depending on the type of indebtedness being incurred (for example, first lien leverage ratio in respect of first lien indebtedness, senior secured leverage ratio in respect of indebtedness secured by a junior lien and a total net leverage ratio or interest coverage ratio in respect of unsecured indebtedness). A ratio basket would typically allow the borrower to incur debt secured on a senior secured basis subject to a maximum senior secured leverage ratio and unsecured debt subject to a maximum total leverage ratio.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/RatioDebtBasket">fibo-der-sbd-sbd:RatioDebtBasket</a>
    /// </summary>
    let RatioDebtBasket = _prefixId.prefix "RatioDebtBasket"
    /// <summary>
    ///   <para>rdfs:label : security-based derivative</para>
    ///   <para>skos:definition : derivative instrument whose underlier is based on a security, including collections of securities and indices based on securities^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/SecurityBasedDerivative">fibo-der-sbd-sbd:SecurityBasedDerivative</a>
    /// </summary>
    let SecurityBasedDerivative = _prefixId.prefix "SecurityBasedDerivative"
