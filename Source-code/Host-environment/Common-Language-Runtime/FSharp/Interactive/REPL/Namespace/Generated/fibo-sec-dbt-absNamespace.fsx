#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-dbt-abs`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/" "fibo-sec-dbt-abs"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : auto asset-backed security</para>
    ///   <para>skos:definition : asset-backed security that is backed by an underlying pool of auto-related loans and/or leases</para>
    ///   <para>cmns-av:adaptedFrom : https://content.naic.org/sites/default/files/capital-markets-primer-auto-abs.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Auto asset-backed securities (auto ABS) are typically structured finance securities that are collateralized by auto loans or leases, such as those to prime (good credit standing) and subprime (poor credit standing) borrowers. Loans or leases are bundled into pools and transferred to a special-purpose entity (SPE), which, in turn, transfers the pool to a (bankruptcy remote) trust. Payments on the underlying auto loans and leases are pooled in the trust, and the funds are used to pay note investors their respective principal which, in turn, transfers the pool to a (bankruptcy remote) trust, i.e., one that protects the security from bankruptcy. Payments on the underlying auto loans and leases are pooled in the trust, and the funds are used to pay note investors their respective principal and interest when due. Any leftover funds - known as excess spread, or the net interest margin - are paid to the equity holder (usually the issuer, such as an auto finance company).cmns-av:explanatoryNote : If the credit risk of the pool has been decoupled from the institution via an SPV, then an auto asset-backed security is also a structured finance instrument.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/AutoAssetBackedSecurity">fibo-sec-dbt-abs:AutoAssetBackedSecurity</a>
    /// </summary>
    let AutoAssetBackedSecurity = _prefixId.prefix "AutoAssetBackedSecurity"
    /// <summary>
    ///   <para>rdfs:label : auto debt pool</para>
    ///   <para>skos:definition : debt pool of loans and/or leases that are motor vehicle-related</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/AutoDebtPool">fibo-sec-dbt-abs:AutoDebtPool</a>
    /// </summary>
    let AutoDebtPool = _prefixId.prefix "AutoDebtPool"
    /// <summary>
    ///   <para>rdfs:label : bond pool</para>
    ///   <para>skos:definition : debt pool of consisting of bonds</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/BondPool">fibo-sec-dbt-abs:BondPool</a>
    /// </summary>
    let BondPool = _prefixId.prefix "BondPool"
    /// <summary>
    ///   <para>rdfs:label : consumer asset-backed security</para>
    ///   <para>skos:definition : structured finance securities collateralized by pools of auto loans and leases (auto ABS), credit card receivables (credit card ABS) or student loans (student loan ABS)</para>
    ///   <para>cmns-av:adaptedFrom : https://content.naic.org/sites/default/files/capital-markets-primer-consumer-abs.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/ConsumerAssetBackedSecurity">fibo-sec-dbt-abs:ConsumerAssetBackedSecurity</a>
    /// </summary>
    let ConsumerAssetBackedSecurity = _prefixId.prefix "ConsumerAssetBackedSecurity"

    /// <summary>
    ///   <para>rdfs:label : controlled amortization asset-backed security^^xsd:string</para>
    ///   <para>skos:definition : asset-backed security based on a pool of bonds securitized using a controlled amortization structure^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investinginbonds.com/learnmore.asp?catid=11&amp;subcatid=57&amp;id=15^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Controlled-amortization ABS resemble corporate bonds with a sinking fund. After a predetermined 'revolving' period during which only interest payments are made, these securities attempt to return principal to investors in a series of defined periodic payments that usually occur over less than a year.^^xsd:stringcmns-av:explanatoryNote : Revolving debt (primarily credit card receivables, but also HELOCs, trade receivables, dealer floor-plan loans and some leases) may be securitized using a controlled amortization structure. This is a method of providing investors with a relatively predictable repayment schedule, even though the underlying assets are nonamortizing. A risk inherent in this kind of ABS is an early amortization event.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/ControlledAmortizationAssetBackedSecurity">fibo-sec-dbt-abs:ControlledAmortizationAssetBackedSecurity</a>
    /// </summary>
    let ControlledAmortizationAssetBackedSecurity =
        _prefixId.prefix "ControlledAmortizationAssetBackedSecurity"

    /// <summary>
    ///   <para>rdfs:label : credit card account pool</para>
    ///   <para>skos:definition : pool of credit card receivables associated with designated accounts</para>
    ///   <para>cmns-av:adaptedFrom : Federal Deposit Insurance Corporation (FDIC) Credit Card Securitization Manual, available at https://www.fdic.gov/regulations/examinations/credit_card_securitization/ch2.html</para>
    ///   <para>cmns-av:explanatoryNote : In a credit card securitization transaction only the receivables are sold, not the accounts that generate the receivables. The financial institution retains legal ownership of the credit card accounts and can continue to change the terms on the accounts. Accounts corresponding to securitized loans are typically referred to as the designated accounts (or sometimes trust accounts). The initial outstanding balances on the designated accounts are sold to the trust as are the rights to any new charges on the designated accounts. Subsequently, as cardholder purchase activity generates more receivables on the designated accounts, these new receivables are purchased by the trust from the originating institution/seller/transferor. The trust uses the monthly principal payments received from the cardholders to acquire these new charges or receivables. When the securitization is initially set up, the originating institution/seller adds sufficient receivables to support the principal balance of the certificates plus an additional amount (seller's interest) that serves to absorb fluctuations in the outstanding balance of the receivables. The originating institution/seller will make subsequent additions to the trust in order to keep the seller's interest at the required level.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/CreditCardAccountPool">fibo-sec-dbt-abs:CreditCardAccountPool</a>
    /// </summary>
    let CreditCardAccountPool = _prefixId.prefix "CreditCardAccountPool"
    /// <summary>
    ///   <para>rdfs:label : credit card asset-backed security</para>
    ///   <para>skos:definition : asset-backed security based on credit card receivables</para>
    ///   <para>cmns-av:adaptedFrom : Federal Deposit Insurance Corporation (FDIC) Credit Card Securitization Manual, available at https://www.fdic.gov/regulations/examinations/credit_card_securitization/ch2.html</para>
    ///   <para>cmns-av:explanatoryNote : Credit card securitizations currently represent the primary funding vehicle for unsecured revolving consumer credit. Similar to mortgage and other asset securitizations, the financial institution that originates the credit card receivables sells a group of these receivables to a trust. The trust then creates and sells certificates backed by the credit card receivables to investors, which are predominately institutional investors. Very few credit card ABS are marketed to retail customers, primarily due to the complex nature of the transactions and the need to continually monitor various performance indices on the underlying receivables. The underlying credit card receivables generate income to support the interest payments on the certificates.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/CreditCardAssetBackedSecurity">fibo-sec-dbt-abs:CreditCardAssetBackedSecurity</a>
    /// </summary>
    let CreditCardAssetBackedSecurity = _prefixId.prefix "CreditCardAssetBackedSecurity"

    /// <summary>
    ///   <para>rdfs:label : fully amortizing asset-backed security^^xsd:string</para>
    ///   <para>skos:definition : asset-backed security based on a pool of debt instruments that returns principal to investors over the life of the security^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investinginbonds.com/learnmore.asp?catid=11&amp;subcatid=57&amp;id=15^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Fully amortizing asset-backed securities are designed to closely reflect the full repayment of the underlying loans through scheduled interest and principal payments.^^xsd:stringcmns-av:explanatoryNote : These are typically backed by HELs, auto loans, manufactured-housing contracts and other fully amortizing assets. Prepayment risk is a key consideration with such ABS, although the rate of prepayment may vary considerably by the type of underlying asset.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/FullyAmortizingAssetBackedSecurity">fibo-sec-dbt-abs:FullyAmortizingAssetBackedSecurity</a>
    /// </summary>
    let FullyAmortizingAssetBackedSecurity =
        _prefixId.prefix "FullyAmortizingAssetBackedSecurity"

    /// <summary>
    ///   <para>rdfs:label : home equity line of credit pool</para>
    ///   <para>skos:definition : debt pool consisting of home equity loans</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/HomeEquityLineOfCreditPool">fibo-sec-dbt-abs:HomeEquityLineOfCreditPool</a>
    /// </summary>
    let HomeEquityLineOfCreditPool = _prefixId.prefix "HomeEquityLineOfCreditPool"

    /// <summary>
    ///   <para>rdfs:label : home equity loan asset-backed security</para>
    ///   <para>skos:definition : asset-backed security based on home equity loan receivables</para>
    ///   <para>cmns-av:explanatoryNote : If the credit risk of the pool has been decoupled from the institution via an SPV, then home equity asset-backed securities are also structured finance instruments.cmns-av:explanatoryNote : Similar to mortgages, home equity loans are often taken out by borrowers who have less-than-stellar credit scores or few assets - the reason why they didn’t qualify for a mortgage. These are amortizing loans - that is, payment goes toward satisfying a specific sum and consists of three categories: interest, principal, and prepayments.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/HomeEquityLoanAssetBackedSecurity">fibo-sec-dbt-abs:HomeEquityLoanAssetBackedSecurity</a>
    /// </summary>
    let HomeEquityLoanAssetBackedSecurity =
        _prefixId.prefix "HomeEquityLoanAssetBackedSecurity"

    /// <summary>
    ///   <para>rdfs:label : student loan asset-backed security</para>
    ///   <para>skos:definition : asset-backed security based on student loan receivables</para>
    ///   <para>cmns-av:explanatoryNote : If the credit risk of the pool has been decoupled from the institution via an SPV, then student loan asset-backed securities are also structured finance instruments.cmns-av:explanatoryNote : The main purpose behind Student Loan ABS is to diversify the risk for lenders across many investors. By pooling and then packaging the loans into securities and selling them to investors, agencies can spread around the default risk, which allows them to give out more loans and larger loans. This way, more students have access to loans, investors have a diversifying investment instrument, and lenders can generate consistent cash flow from their securitization and debt collection services.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/StudentLoanAssetBackedSecurity">fibo-sec-dbt-abs:StudentLoanAssetBackedSecurity</a>
    /// </summary>
    let StudentLoanAssetBackedSecurity =
        _prefixId.prefix "StudentLoanAssetBackedSecurity"

    /// <summary>
    ///   <para>rdfs:label : student loan pool</para>
    ///   <para>skos:definition : debt pool consisting of student loans</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/StudentLoanPool">fibo-sec-dbt-abs:StudentLoanPool</a>
    /// </summary>
    let StudentLoanPool = _prefixId.prefix "StudentLoanPool"
