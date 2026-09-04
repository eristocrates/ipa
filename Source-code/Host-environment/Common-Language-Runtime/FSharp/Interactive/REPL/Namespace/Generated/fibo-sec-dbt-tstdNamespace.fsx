#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-dbt-tstd`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/" "fibo-sec-dbt-tstd"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : bankers' acceptance</para>
    ///   <para>skos:definition : short-term debt instrument that is guaranteed and paid by a bank and used as a relatively safe form of payment for large transactions</para>
    ///   <para>cmns-av:explanatoryNote : Considered negotiable instruments with features of a time draft, bankers' acceptances are created by the drawer and provide the bearer with the right to the amount noted on the face of the acceptance on the specified date. Unlike traditional checks, bankers' acceptances function based on the creditworthiness of the banking institution instead of the individual or business acting as the drawer. Additionally, the drawer must provide the funds necessary to support the bankers' acceptance, eliminating the risk associated with insufficient funds on the part of the drawer.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/BankersAcceptance">fibo-sec-dbt-tstd:BankersAcceptance</a>
    /// </summary>
    let BankersAcceptance = _prefixId.prefix "BankersAcceptance"
    /// <summary>
    ///   <para>rdfs:label : bill of exchange</para>
    ///   <para>skos:definition : short-term negotiable financial instrument consisting of an order in writing addressed by one person (the seller of goods) to another (the buyer), requiring the latter to pay a fixed amount of money on demand (a sight draft) or on a predetermined date (a time draft)</para>
    ///   <para>cmns-av:explanatoryNote : A bill of exchange is a written agreement between two parties - the buyer and the seller - used primarily in international trade. The buyer or seller typically employs a bank to issue the bill of exchange due to the risks involved with international transactions. Bills of exchange can be transferred by endorsement, much like a check. They can also require the buyer to pay a third party - a bank - in the event that the buyer fails to make good on his agreement with the seller.</para>
    ///   <para>cmns-av:synonym : bank draftcmns-av:synonym : draft</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/BillOfExchange">fibo-sec-dbt-tstd:BillOfExchange</a>
    /// </summary>
    let BillOfExchange = _prefixId.prefix "BillOfExchange"
    /// <summary>
    ///   <para>rdfs:label : commercial paper</para>
    ///   <para>skos:definition : an unsecured short-term debt instrument typically issued by a bank, corporation, or foreign government to obtain funds to meet short-term debt obligations, such as accounts receivable, inventories, or payroll, backed only by an issuing bank or company promise to pay the face amount on the maturity date specified on the note</para>
    ///   <para>cmns-av:explanatoryNote : Commercial paper has a very-short to short maturity period (usually, 2 to 30 days, and rarely more than 270 days).</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/CommercialPaper">fibo-sec-dbt-tstd:CommercialPaper</a>
    /// </summary>
    let CommercialPaper = _prefixId.prefix "CommercialPaper"
    /// <summary>
    ///   <para>rdfs:label : drawee^^xsd:string</para>
    ///   <para>skos:definition : party that is required to pay the amount stated on the bill of exchange to the payee^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/Drawee">fibo-sec-dbt-tstd:Drawee</a>
    /// </summary>
    let Drawee = _prefixId.prefix "Drawee"
    /// <summary>
    ///   <para>rdfs:label : drawer^^xsd:string</para>
    ///   <para>skos:definition : party that requires a drawee to pay either a third party or themselves with respect to a bill of exchange^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/Drawer">fibo-sec-dbt-tstd:Drawer</a>
    /// </summary>
    let Drawer = _prefixId.prefix "Drawer"
    /// <summary>
    ///   <para>rdfs:label : eurodollar deposit</para>
    ///   <para>skos:definition : a certificate of deposit with a fixed interest rate issued in U.S. dollars outside the jurisdiction of the Federal Reserve, held at banks outside of the United States, including branches of U.S. banks located outside of the U.S.</para>
    ///   <para>cmns-av:explanatoryNote : A bank in Japan or Singapore may accept dollar deposits, but these are still called Eurodollar deposits. The market also includes other currencies, so there are Eurosterling, Euroyen, Euroswiss, etc. Eurocurrency is the general term for any currency deposited in bank branches outside countries where it is the national currency.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/EurodollarDeposit">fibo-sec-dbt-tstd:EurodollarDeposit</a>
    /// </summary>
    let EurodollarDeposit = _prefixId.prefix "EurodollarDeposit"
    /// <summary>
    ///   <para>rdfs:label : money market instrument</para>
    ///   <para>skos:definition : a short-term debt security that gives the owner the unconditional right to receive a stated, fixed sum of money on a specified date</para>
    ///   <para>cmns-av:adaptedFrom : https://stats.oecd.org/glossary/detail.asp?ID=6073^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : These instruments usually are traded at a discount in organized markets; the discount is dependent upon the interest rate and the time remaining to maturity. Included are such instruments as treasury bills, commercial and financial paper, bankers' acceptances, negotiable certificates of deposit (with original maturities of one year or less), and short-term notes issued under note issuance facilities.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/MoneyMarketInstrument">fibo-sec-dbt-tstd:MoneyMarketInstrument</a>
    /// </summary>
    let MoneyMarketInstrument = _prefixId.prefix "MoneyMarketInstrument"
    /// <summary>
    ///   <para>rdfs:label : repurchase agreement</para>
    ///   <para>skos:definition : agreement between two parties whereby one party lends the other a security at a specified price with a commitment to take the security back at a later date for another specified price</para>
    ///   <para>cmns-av:abbreviation : REPO</para>
    ///   <para>cmns-av:explanatoryNote : Most repos are overnight transactions, with the sale taking place one day and being reversed the next day. Long-term repos - called term repos - can extend for a month or more. Usually, repos are for a fixed period of time, but open-ended deals are also possible. Reverse repo is a term used to describe the opposite side of a repo transaction. The party who sells and later repurchases a security is said to perform a repo. The other party - who purchases and later resells the security - is said to perform a reverse repo. While a repo functions like the sale and subsequent repurchase of a security, but the legal reality and the economic effect is that of a secured loan. This is a loan as the original owner retains the rights to the cashflows of the underlying security. Economically, the party purchasing the security makes funds available to the seller and holds the security as collateral. If the repurchased security pays a dividend, coupon or partial redemptions during the repo, the funds are returned to the original owner. The difference between the sale and repurchase prices paid for the security represent interest on the loan. Indeed, repos are quoted as interest rates. A repo always pays interest at maturity, i.e. there are no periodic interest payments.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/RepurchaseAgreement">fibo-sec-dbt-tstd:RepurchaseAgreement</a>
    /// </summary>
    let RepurchaseAgreement = _prefixId.prefix "RepurchaseAgreement"
