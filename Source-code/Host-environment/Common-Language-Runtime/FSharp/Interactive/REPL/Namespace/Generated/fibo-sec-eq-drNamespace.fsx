#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-eq-dr`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/" "fibo-sec-eq-dr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : American depositary receipt</para>
    ///   <para>skos:definition : depositary receipt that represents securities of a foreign company and allows that company's securities to trade in the U.S. financial markets</para>
    ///   <para>skos:example : For example, Accton Technology is traded on the Taiwanese exchange. In order for Accton Technology to be traded in the United States, Citibank, acting as a domestic custodian bank, purchases shares of Accton Technology and creates a security, ISIN US00437R1032, which can be traded on a U.S. exchange, in this case PORTAL. Note that the depositary shares do not have to equal the number of original shares. In the case of Accton Technology, one depositary share is equivalent to two original shares.</para>
    ///   <para>cmns-av:abbreviation : ADR</para>
    ///   <para>cmns-av:explanatoryNote : Most ADRs are issued by a domestic custodian bank when the underlying securities are deposited in a foreign depositary bank, usually by a broker who has purchased the securities in the open market local to the foreign company. An ADR can represent a fraction of a share, a single share, or multiple shares of a foreign security. The holder of an ADR has the right to obtain the underlying foreign security that the ADR represents, but investors usually find it more convenient to own the ADR. The price of an ADR generally tracks the price of the foreign security in its home market, adjusted for the ratio of ADRs to foreign company shares. In the case of companies domiciled in the United Kingdom, creation of ADRs attracts a 1.5 percent creation fee; this creation fee is different than stamp duty reserve tax charge by the UK government. Depositary banks have various responsibilities to ADR holders and to the issuing foreign company the ADR represents.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceipt">fibo-sec-eq-dr:AmericanDepositaryReceipt</a>
    /// </summary>
    let AmericanDepositaryReceipt = _prefixId.prefix "AmericanDepositaryReceipt"

    /// <summary>
    ///   <para>rdfs:label : American depositary receipt level</para>
    ///   <para>skos:definition : classifier for American depositary receipts that categorizes ADRs into levels based on the extent to which the foreign company has access to the U.S. market</para>
    ///   <para>cmns-av:abbreviation : ADR level</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceiptLevel">fibo-sec-eq-dr:AmericanDepositaryReceiptLevel</a>
    /// </summary>
    let AmericanDepositaryReceiptLevel =
        _prefixId.prefix "AmericanDepositaryReceiptLevel"

    /// <summary>
    ///   <para>rdfs:label : American depositary receipt level scheme</para>
    ///   <para>skos:definition : classifier for American depositary receipts that categorizes ADRs into levels based on the extent to which the foreign company has access to the U.S. market</para>
    ///   <para>cmns-av:abbreviation : ADR level</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/AmericanDepositaryReceiptLevelScheme">fibo-sec-eq-dr:AmericanDepositaryReceiptLevelScheme</a>
    /// </summary>
    let AmericanDepositaryReceiptLevelScheme =
        _prefixId.prefix "AmericanDepositaryReceiptLevelScheme"

    /// <summary>
    ///   <para>rdfs:label : Chinese depositary receipt</para>
    ///   <para>skos:definition : global depositary receipt that represents ownership in the securities of a non-Chinese company that trades on a public exchange in China</para>
    ///   <para>cmns-av:abbreviation : CDR</para>
    ///   <para>cmns-av:explanatoryNote : It refers to shares in non-Chinese companies that trade in China the same way that American depositary receipts (ADRs) allow non-U.S. company shares to trade on American exchanges.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/ChineseDepositaryReceipt">fibo-sec-eq-dr:ChineseDepositaryReceipt</a>
    /// </summary>
    let ChineseDepositaryReceipt = _prefixId.prefix "ChineseDepositaryReceipt"
    /// <summary>
    ///   <para>rdfs:label : depositary receipt</para>
    ///   <para>skos:definition : negotiable financial instrument issued by a trust company, security depositary, or bank that is evidence of the deposit of publicly traded securities and that facilitates the ownership of securities traded in other jurisdictions</para>
    ///   <para>cmns-av:abbreviation : DR</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : Depositary receipts are widely used in order to allow the trading of securities in jurisdictions other than
    /// the one where the original securities were issued, such as in a local market. Depositary receipts facilitate buying securities in foreign companies, because the securities do not have to leave the home country. They enable domestic investors to buy securities of foreign companies without the accompanying risks or inconveniences of cross-border and cross-currency transactions.</para>
    ///   <para>cmns-av:synonym : depositary receipt</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/DepositaryReceipt">fibo-sec-eq-dr:DepositaryReceipt</a>
    /// </summary>
    let DepositaryReceipt = _prefixId.prefix "DepositaryReceipt"
    /// <summary>
    ///   <para>rdfs:label : European depositary receipt</para>
    ///   <para>skos:definition : global depositary receipt that represents ownership in the securities of a non-European company that trades in European financial markets</para>
    ///   <para>cmns-av:abbreviation : EDR</para>
    ///   <para>cmns-av:explanatoryNote : A European depositary receipt is a European equivalent of the original American depositary receipt (ADR). The EDR is issued by a bank in Europe representing securities traded on an exchange outside of the bank's home country.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/EuropeanDepositaryReceipt">fibo-sec-eq-dr:EuropeanDepositaryReceipt</a>
    /// </summary>
    let EuropeanDepositaryReceipt = _prefixId.prefix "EuropeanDepositaryReceipt"
    /// <summary>
    ///   <para>rdfs:label : global depositary receipt</para>
    ///   <para>skos:definition : depositary receipt where a certificate issued by a depositary bank, which purchases securities of foreign companies, creates a security on a local exchange backed by those securities</para>
    ///   <para>cmns-av:abbreviation : GDR</para>
    ///   <para>cmns-av:explanatoryNote : Global depositary receipts are the global equivalent of the original American depositary receipts (ADR) on which they are based. GDRs represent ownership of an underlying number of securities of a foreign company and are commonly used to invest in companies from developing or emerging markets by investors in developed markets.</para>
    ///   <para>cmns-av:synonym : international depositary receipt</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/GlobalDepositaryReceipt">fibo-sec-eq-dr:GlobalDepositaryReceipt</a>
    /// </summary>
    let GlobalDepositaryReceipt = _prefixId.prefix "GlobalDepositaryReceipt"
    /// <summary>
    ///   <para>rdfs:label : Hong Kong depositary receipt</para>
    ///   <para>skos:definition : global depositary receipt that represents the purchase, or ownership, of foreign assets which are deposited in a depositary bank in Hong Kong</para>
    ///   <para>cmns-av:abbreviation : HKDR</para>
    ///   <para>cmns-av:explanatoryNote : A Hong Kong Depositary Receipt (HDR) is a negotiable instrument issued by a depositary bank that evidences ownership of securities in a corporation organized outside Hong Kong. HDRs trade on the Hong Kong Stock Exchange (HKEx), thus enabling foreign issuers to tap the Hong Kong market and local investors to efficiently invest in quality international companies.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/HongKongDepositaryReceipt">fibo-sec-eq-dr:HongKongDepositaryReceipt</a>
    /// </summary>
    let HongKongDepositaryReceipt = _prefixId.prefix "HongKongDepositaryReceipt"
    /// <summary>
    ///   <para>rdfs:label : Indian depositary receipt</para>
    ///   <para>skos:definition : global depositary receipt that represents the purchase, or ownership, of foreign assets which are deposited in a Indian account managed by the Domestic Depository in India</para>
    ///   <para>cmns-av:abbreviation : IDR</para>
    ///   <para>cmns-av:explanatoryNote : An Indian Depository Receipt (IDR) is an instrument denominated in Indian Rupees in the form of a depositary receipt created by a Domestic Depository (custodian of securities registered with the Securities and Exchange Board of India) against the underlying securities of issuing company to enable foreign companies to raise funds from the Indian securities Markets.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/IndianDepositoryReceipt">fibo-sec-eq-dr:IndianDepositoryReceipt</a>
    /// </summary>
    let IndianDepositoryReceipt = _prefixId.prefix "IndianDepositoryReceipt"
    /// <summary>
    ///   <para>rdfs:label : Japanese depositary receipt</para>
    ///   <para>skos:definition : global depositary receipt that represents the purchase, or ownership, of foreign assets which are deposited in a trust bank in Japan</para>
    ///   <para>cmns-av:abbreviation : JDR</para>
    ///   <para>cmns-av:explanatoryNote : A Japanese Depositary Receipt (JDR) is an instrument issued by a trust bank in Japan that evidences ownership of securities in a corporation organized outside Japan. JDRs trade on the Tokyo Stock Exchange (TSE) in yen, and in accordance with Japanese market conventions, enabling foreign issuers to tap the Japanese capital market and local investors to efficiently invest in quality international companies.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/JapaneseDepositaryReceipt">fibo-sec-eq-dr:JapaneseDepositaryReceipt</a>
    /// </summary>
    let JapaneseDepositaryReceipt = _prefixId.prefix "JapaneseDepositaryReceipt"

    let LevelIAmericanDepositaryReceipt =
        _prefixId.prefix "LevelIAmericanDepositaryReceipt"

    let LevelIIAmericanDepositaryReceipt =
        _prefixId.prefix "LevelIIAmericanDepositaryReceipt"

    let LevelIIIAmericanDepositaryReceipt =
        _prefixId.prefix "LevelIIIAmericanDepositaryReceipt"

    /// <summary>
    ///   <para>rdfs:label : Luxembourg depositary receipt</para>
    ///   <para>skos:definition : global depositary receipt that represents the purchase, or ownership, of foreign assets which are deposited in a Luxembourg-based account</para>
    ///   <para>cmns-av:abbreviation : LDR</para>
    ///   <para>cmns-av:explanatoryNote : A Luxembourg Depositary Receipt (LDR) is a certificate which represents the purchase, or ownership, of foreign assets which are deposited in a Luxembourg-based account. An LDR functions in much the same way as a global depositary receipt (GDR). LDRs may represent ownership of either an underlying number of shares or a notional amount of bonds.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/LuxembourgDepositaryReceipt">fibo-sec-eq-dr:LuxembourgDepositaryReceipt</a>
    /// </summary>
    let LuxembourgDepositaryReceipt = _prefixId.prefix "LuxembourgDepositaryReceipt"
    /// <summary>
    ///   <para>rdfs:label : offshore depositary receipt</para>
    ///   <para>skos:definition : depositary receipt issued under SEC Regulation S</para>
    ///   <para>cmns-av:explanatoryNote : This regulation means that the securities are not, and will not be registered with any U.S. securities regulation authority. Regulation S shares cannot be held or traded by any 'U.S. person' as defined by SEC Regulation S rules. The shares are registered and issued to offshore, non-U.S. residents.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/OffshoreDepositaryReceipt">fibo-sec-eq-dr:OffshoreDepositaryReceipt</a>
    /// </summary>
    let OffshoreDepositaryReceipt = _prefixId.prefix "OffshoreDepositaryReceipt"
    /// <summary>
    ///   <para>rdfs:label : participatory note</para>
    ///   <para>skos:definition : tradable debt instrument that facilitates the ownership of securities traded in other jurisdictions</para>
    ///   <para>skos:example : Participation notes are required by investors or hedge funds to invest in Indian securities without having to register with the Securities and Exchange Board of India (SEBI). P-Notes are among the group of investments considered to be Offshore Derivative Investments (ODIs) in Indian markets.</para>
    ///   <para>cmns-av:abbreviation : P-Notecmns-av:abbreviation : PN</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : Depository receipts are widely used in order to allow the trading of debt instruments in
    /// jurisdictions other than the one where the original debt instruments were issuedcmns-av:explanatoryNote : Typically P-Notes are SPVs that are created to allow participation from outside that market. The SPV purchases a security on shore and issues a note that represents that security to offshore investors. They are similar to an ADR but always a debt security.</para>
    ///   <para>cmns-av:synonym : participation note</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/ParticipatoryNote">fibo-sec-eq-dr:ParticipatoryNote</a>
    /// </summary>
    let ParticipatoryNote = _prefixId.prefix "ParticipatoryNote"

    /// <summary>
    ///   <para>rdfs:label : privately placed depositary receipt</para>
    ///   <para>skos:definition : depositary receipt that represents shares in a private placement under the SEC Rule 144-A</para>
    ///   <para>cmns-av:explanatoryNote : Some foreign companies will set up an ADR program under SEC Rule 144-A. This provision makes the issuance of shares a private placement. Shares of companies registered under Rule 144-A are restricted stock and may only be issued to or traded by qualified institutional buyers (QIBs). U.S. public shareholders are generally not permitted to invest in these ADR programs, and most are held exclusively through the Depository Trust &amp; Clearing Corporation, so there is often very little information on these companies.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/PrivatelyPlacedDepositaryReceipt">fibo-sec-eq-dr:PrivatelyPlacedDepositaryReceipt</a>
    /// </summary>
    let PrivatelyPlacedDepositaryReceipt =
        _prefixId.prefix "PrivatelyPlacedDepositaryReceipt"

    /// <summary>
    ///   <para>rdfs:label : sponsored depositary receipt</para>
    ///   <para>skos:definition : depositary receipt that is issued in collaboration with the foreign company enabling them to tap into international capital markets directly</para>
    ///   <para>cmns-av:explanatoryNote : Although a sponsored ADR would be listed in the United States, the issuing company still has its revenue and profit denominated in its home currency.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/SponsoredDepositaryReceipt">fibo-sec-eq-dr:SponsoredDepositaryReceipt</a>
    /// </summary>
    let SponsoredDepositaryReceipt = _prefixId.prefix "SponsoredDepositaryReceipt"
    /// <summary>
    ///   <para>rdfs:label : unsponsored depositary receipt</para>
    ///   <para>skos:definition : depositary receipt that is established without the company's cooperation</para>
    ///   <para>cmns-av:explanatoryNote : For an unsponsored ADR, a depositary entity can issue certificates when there's heavy demand from investors for ownership in a specific company from abroad. The issuing entity is normally a broker-dealer that owns common stock in the company. Because they're issued without the consent or cooperation of the foreign company, unsponsored ADRs generally trade over-the-counter (OTC)—rather than on a stock exchange. Also, shareholder benefits and voting rights may not be extended to the holders of these particular securities. Many large global corporations use unsponsored ADRs to attract American capital. For example, American investors can invest in Royal Mail PLC, a postal and delivery service company from the United Kingdom that was founded by Henry VIII. The company's unsponsored ADR trades OTC under the ticker symbol ROYMY.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/UnsponsoredDepositaryReceipt">fibo-sec-eq-dr:UnsponsoredDepositaryReceipt</a>
    /// </summary>
    let UnsponsoredDepositaryReceipt = _prefixId.prefix "UnsponsoredDepositaryReceipt"
    /// <summary>
    ///   <para>rdfs:label : has multiplier</para>
    ///   <para>skos:definition : indicates the number of underlying shares (whether multiple or fractional) represented by a single depositary receipt</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasMultiplier">fibo-sec-eq-dr:hasMultiplier</a>
    /// </summary>
    let hasMultiplier = _prefixId.prefix "hasMultiplier"

    /// <summary>
    ///   <para>rdfs:label : has number of depositary receipts issued</para>
    ///   <para>skos:definition : indicates the number of receipts issued to the general public</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasNumberOfDepositaryReceiptsIssued">fibo-sec-eq-dr:hasNumberOfDepositaryReceiptsIssued</a>
    /// </summary>
    let hasNumberOfDepositaryReceiptsIssued =
        _prefixId.prefix "hasNumberOfDepositaryReceiptsIssued"

    /// <summary>
    ///   <para>rdfs:label : has traded security</para>
    ///   <para>skos:definition : links a depositary receipt to the instrument that it represents</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasTradedSecurity">fibo-sec-eq-dr:hasTradedSecurity</a>
    /// </summary>
    let hasTradedSecurity = _prefixId.prefix "hasTradedSecurity"
    /// <summary>
    ///   <para>rdfs:label : has traded share</para>
    ///   <para>skos:definition : links a depositary receipt to the instrument (equity or exchange-traded fund) that it represents</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/hasTradedShare">fibo-sec-eq-dr:hasTradedShare</a>
    /// </summary>
    let hasTradedShare = _prefixId.prefix "hasTradedShare"
