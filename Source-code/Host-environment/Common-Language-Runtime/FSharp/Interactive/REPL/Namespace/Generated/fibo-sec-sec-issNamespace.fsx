#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-iss`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/" "fibo-sec-sec-iss"

    let _namespaceIri = _prefixId.prefix ""
    let BearerAndRegisteredForm = _prefixId.prefix "BearerAndRegisteredForm"
    let BearerForm = _prefixId.prefix "BearerForm"
    /// <summary>
    ///   <para>rdfs:label : best efforts offering^^xsd:string</para>
    ///   <para>skos:definition : securities offering whereby investment bankers commit to doing their best to sell the securities offered, but do not assume the full risk of an underwriter^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In a best efforts offering, the agreement is strictly an agency arrangement, with no obligation on the part of the agent to purchase the securities. They act as a broker, in other words.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BestEffortsOffering">fibo-sec-sec-iss:BestEffortsOffering</a>
    /// </summary>
    let BestEffortsOffering = _prefixId.prefix "BestEffortsOffering"
    let BookEntryForm = _prefixId.prefix "BookEntryForm"
    /// <summary>
    ///   <para>rdfs:label : conversion terms^^xsd:string</para>
    ///   <para>skos:definition : contract terms specifying when and how a security may be converted to another security (usually of the same issuer)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ConversionTerms">fibo-sec-sec-iss:ConversionTerms</a>
    /// </summary>
    let ConversionTerms = _prefixId.prefix "ConversionTerms"
    /// <summary>
    ///   <para>rdfs:label : convertible security^^xsd:string</para>
    ///   <para>skos:definition : security that can be converted into another security^^xsd:string</para>
    ///   <para>skos:example : Convertible securities may be convertible bonds or preferred stocks that pay regular interest and can be converted into shares of common stock (sometimes conditioned on the stock price appreciating to a predetermined level).^^xsd:stringskos:example : Warrants are equity convertible securities. They give the owner the option to buy newly issued shares at a determined exercise price and date.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ConvertibleSecurity">fibo-sec-sec-iss:ConvertibleSecurity</a>
    /// </summary>
    let ConvertibleSecurity = _prefixId.prefix "ConvertibleSecurity"
    /// <summary>
    ///   <para>rdfs:label : exempt issuer^^xsd:string</para>
    ///   <para>skos:definition : issuer that issues securities that are excused from certain regulatory reporting requirements^^xsd:string</para>
    ///   <para>skos:example : In general, these include governments and issuers of tax exempt securities such as municipalities, banks and depository institutions, and authorized insurance companies, railroads and public utilities, and certain non-profit organizations.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investopedia.com/exam-guide/series-66/regulation-of-securities/exempt-securities.asp^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptIssuer">fibo-sec-sec-iss:ExemptIssuer</a>
    /// </summary>
    let ExemptIssuer = _prefixId.prefix "ExemptIssuer"
    /// <summary>
    ///   <para>rdfs:label : exempt offering^^xsd:string</para>
    ///   <para>skos:definition : public offering involving securities that are excused from certain regulatory reporting requirements^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014.^^xsd:stringcmns-av:adaptedFrom : http://www.investopedia.com/exam-guide/series-66/regulation-of-securities/exempt-securities.asp^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Such an offering may be considered exempt either because the issuer is exempt or the transaction specific to the offering is exempt.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptOffering">fibo-sec-sec-iss:ExemptOffering</a>
    /// </summary>
    let ExemptOffering = _prefixId.prefix "ExemptOffering"
    /// <summary>
    ///   <para>rdfs:label : exempt transaction^^xsd:string</para>
    ///   <para>skos:definition : securities transaction for which there is no requirement to register the transaction with a regulatory agency^^xsd:string</para>
    ///   <para>skos:example : Examples include non-issuer transactions in outstanding securities, other isolated non-issuer transactions, certain unsolicited / de minimis transactions, fiduciary transactions, transactions with financial institutions, private placement transactions that meet certain conditions, and so forth.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investopedia.com/terms/e/exempttransaction.asp^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptTransaction">fibo-sec-sec-iss:ExemptTransaction</a>
    /// </summary>
    let ExemptTransaction = _prefixId.prefix "ExemptTransaction"
    /// <summary>
    ///   <para>rdfs:label : financial instrument short name^^xsd:string</para>
    ///   <para>skos:definition : abbreviated name for a financial instrument within a defined structure as specified in ISO 18774^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : FISN^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 18774:2015(E), Securities and related financial instruments - Financial Instrument Short Name (FISN)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/FinancialInstrumentShortName">fibo-sec-sec-iss:FinancialInstrumentShortName</a>
    /// </summary>
    let FinancialInstrumentShortName = _prefixId.prefix "FinancialInstrumentShortName"
    /// <summary>
    ///   <para>rdfs:label : firm commitment offering^^xsd:string</para>
    ///   <para>skos:definition : securities offering whereby the underwriter purchases the securities outright for their own account^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/FirmCommitmentOffering">fibo-sec-sec-iss:FirmCommitmentOffering</a>
    /// </summary>
    let FirmCommitmentOffering = _prefixId.prefix "FirmCommitmentOffering"
    let MiscellaneousForm = _prefixId.prefix "MiscellaneousForm"
    /// <summary>
    ///   <para>rdfs:label : offering document^^xsd:string</para>
    ///   <para>skos:definition : legal document that states the objectives, risks and terms of an investment^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : EDM Council^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : There are many variations, including offering memorandum, which is typically used in the context of a private placement, offering statement, which has slightly different meanings depending on the context (for securities, for bonds, etc.) and so forth. This concept is intended to act as a more abstract parent for these more nuanced concepts.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/OfferingDocument">fibo-sec-sec-iss:OfferingDocument</a>
    /// </summary>
    let OfferingDocument = _prefixId.prefix "OfferingDocument"
    /// <summary>
    ///   <para>rdfs:label : offering statement^^xsd:string</para>
    ///   <para>skos:definition : offering memorandum that conforms to Regulation A, Offering Statement, of the Securities Act of 1933^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : See https://www.sec.gov/about/forms/form1-a.pdf for the actual form detail^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/OfferingStatement">fibo-sec-sec-iss:OfferingStatement</a>
    /// </summary>
    let OfferingStatement = _prefixId.prefix "OfferingStatement"
    /// <summary>
    ///   <para>rdfs:label : private offering^^xsd:string</para>
    ///   <para>skos:definition : offering of securities made privately to a limited number of qualified potential investors^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : EDM Council / Quarule^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Unlike a public offering, a private placement does not have to be registered with a regulatory agency if the securities are purchased for investment rather than resale.^^xsd:string</para>
    ///   <para>cmns-av:synonym : private placement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PrivateOffering">fibo-sec-sec-iss:PrivateOffering</a>
    /// </summary>
    let PrivateOffering = _prefixId.prefix "PrivateOffering"
    /// <summary>
    ///   <para>rdfs:label : private placement memorandum^^xsd:string</para>
    ///   <para>skos:definition : legal document stating the objectives, risks and terms of investment involved with a private placement^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : PPM^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014.^^xsd:stringcmns-av:adaptedFrom : http://www.investopedia.com/terms/o/offeringmemorandum.asp^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An offering memorandum serves to provide buyers with information on the offering and to protect the sellers from the liability associated with selling unregistered securities. It includes information such as the financial statements, management biographies, a detailed description of the business, etc.^^xsd:string</para>
    ///   <para>cmns-av:synonym : offering memorandum^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PrivatePlacementMemorandum">fibo-sec-sec-iss:PrivatePlacementMemorandum</a>
    /// </summary>
    let PrivatePlacementMemorandum = _prefixId.prefix "PrivatePlacementMemorandum"
    /// <summary>
    ///   <para>rdfs:label : prospectus^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.investopedia.com/terms/p/prospectus.asp^^xsd:anyURI</para>
    ///   <para>skos:definition : formal, written offering document to sell securities that provides the facts an investor needs to make an informed investment decision^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014.^^xsd:stringcmns-av:adaptedFrom : The Securities Act of 1933, as amended 5 April 2012, see http://www.sec.gov/about/laws/sa33.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A prospectus may specify the facts about an offering of securities, mutual funds, or limited partnerships for investments in oil, gas, equipment leasing, or other kinds of limited partnerships.^^xsd:stringcmns-av:explanatoryNote : In the United States, a prospectus may be a formal legal document, required by and filed with the Securities and Exchange Commission, if it provides details about an investment offering for sale to the public.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/Prospectus">fibo-sec-sec-iss:Prospectus</a>
    /// </summary>
    let Prospectus = _prefixId.prefix "Prospectus"
    /// <summary>
    ///   <para>rdfs:label : public offering^^xsd:string</para>
    ///   <para>skos:definition : offering of securities for sale to the investment public, after compliance with registration requirements of the relevant regulatory authorities^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the US, public offerings generally require approval of the Securities Exchange Commission and/or relevant state regulators, unless the issuer is an exempt issuer, and are usually conducted by an investment banker or a syndicate made up of several investment bankers, at a price agreed upon between the issuer and the investment bankers.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PublicOffering">fibo-sec-sec-iss:PublicOffering</a>
    /// </summary>
    let PublicOffering = _prefixId.prefix "PublicOffering"
    let RegisteredForm = _prefixId.prefix "RegisteredForm"
    /// <summary>
    ///   <para>rdfs:label : securities offering^^xsd:string</para>
    ///   <para>skos:definition : offering of a security (or securities) for sale^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014.^^xsd:stringcmns-av:adaptedFrom : http://www.investopedia.com/^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : If the offering is public, then it can only be made after regulatory registration requirements have been met. The securities may be new or a secondary offering of a previously issued security, and may include stock, multiple classes of equity shares, municipal or other government bonds, and so forth. Offerings, especially to the investment public, are typically made by an investment banker, or syndicate of investment bankers.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecuritiesOffering">fibo-sec-sec-iss:SecuritiesOffering</a>
    /// </summary>
    let SecuritiesOffering = _prefixId.prefix "SecuritiesOffering"
    /// <summary>
    ///   <para>rdfs:label : security form^^xsd:string</para>
    ///   <para>skos:definition : nature of the proof of ownership of a security^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Securities are typically issued in one of two forms, registered or bearer. Most securities issued today are in registered form, which enables the issuing firm or registrar to keep records of a security's owner and mail them any dividend, coupon, or other payments. Registered securities may be issued in book entry (digital only) or certificate (physical) form, but most today are entirely digital.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityForm">fibo-sec-sec-iss:SecurityForm</a>
    /// </summary>
    let SecurityForm = _prefixId.prefix "SecurityForm"

    let SecurityOfferingDistributionType =
        _prefixId.prefix "SecurityOfferingDistributionType"

    /// <summary>
    ///   <para>rdfs:label : security underwriter^^xsd:string</para>
    ///   <para>skos:definition : party that has purchased from an issuer with a view to, or sells for an issuer in connection with, the distribution of any security, or participates or has a direct or indirect participation in any such undertaking, or participates or has a participation in the direct or indirect underwriting of any such undertaking^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Section 3a of the Investment Company Act of 1940 as amended in January, 2012, https://www.sec.gov/about/laws/ica40.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityUnderwriter">fibo-sec-sec-iss:SecurityUnderwriter</a>
    /// </summary>
    let SecurityUnderwriter = _prefixId.prefix "SecurityUnderwriter"

    /// <summary>
    ///   <para>rdfs:label : security underwriting arrangement^^xsd:string</para>
    ///   <para>skos:definition : underwriting agreement between an organization (typically an investment bank) and a securities issuer that commits the underwriter to assuming risk involved in buying a new issue of securities and reselling it to the public^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Business and Economics Terms, Fifth Edition, 2012^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Sales may be made either directly or through third-party dealers.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityUnderwritingArrangement">fibo-sec-sec-iss:SecurityUnderwritingArrangement</a>
    /// </summary>
    let SecurityUnderwritingArrangement =
        _prefixId.prefix "SecurityUnderwritingArrangement"

    /// <summary>
    ///   <para>rdfs:label : has actual closing date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which an offering or transaction officially closes, in contrast with an intended closing date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasActualClosingDate">fibo-sec-sec-iss:hasActualClosingDate</a>
    /// </summary>
    let hasActualClosingDate = _prefixId.prefix "hasActualClosingDate"
    /// <summary>
    ///   <para>rdfs:label : has announcement date^^xsd:string</para>
    ///   <para>skos:definition : indicates the first day the public will receive information regarding a new security issue^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An announcement date may also refer to the release of a corporate event or new financial news, such as interest rate changes or earnings reports.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasAnnouncementDate">fibo-sec-sec-iss:hasAnnouncementDate</a>
    /// </summary>
    let hasAnnouncementDate = _prefixId.prefix "hasAnnouncementDate"

    /// <summary>
    ///   <para>rdfs:label : has financial instrument short name^^xsd:string</para>
    ///   <para>skos:definition : relates a security to its ISO 18774-compliant short name, which includes an issuer short name, abbreviated instrument characteristics, and abbreviated instrument description per the ISO standard^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 18774:2015(E), Securities and related financial instruments - Financial Instrument Short Name (FISN)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFinancialInstrumentShortName">fibo-sec-sec-iss:hasFinancialInstrumentShortName</a>
    /// </summary>
    let hasFinancialInstrumentShortName =
        _prefixId.prefix "hasFinancialInstrumentShortName"

    /// <summary>
    ///   <para>rdfs:label : has first trade date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which a newly issued security starts trading^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFirstTradeDate">fibo-sec-sec-iss:hasFirstTradeDate</a>
    /// </summary>
    let hasFirstTradeDate = _prefixId.prefix "hasFirstTradeDate"
    /// <summary>
    ///   <para>rdfs:label : has first trade settlement date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which the first trade of a newly issued security is settled^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFirstTradeSettlementDate">fibo-sec-sec-iss:hasFirstTradeSettlementDate</a>
    /// </summary>
    let hasFirstTradeSettlementDate = _prefixId.prefix "hasFirstTradeSettlementDate"
    /// <summary>
    ///   <para>rdfs:label : has instrument description^^xsd:string</para>
    ///   <para>skos:definition : relates a financial instrument or FISN to an ISO 18774-compliant instrument description, that is, a collection of characteristics and attributes defining a financial instrument with a maximum length up to 19 alphanumeric characters^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 18774:2015(E), Securities and related financial instruments - Financial Instrument Short Name (FISN)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasInstrumentDescription">fibo-sec-sec-iss:hasInstrumentDescription</a>
    /// </summary>
    let hasInstrumentDescription = _prefixId.prefix "hasInstrumentDescription"
    /// <summary>
    ///   <para>rdfs:label : has issuer short name^^xsd:string</para>
    ///   <para>skos:definition : relates a security issuer or FISN to an ISO 18774-compliant issuer short name, that is, an abbreviation of the official issuer name, limited to a maximum of 15 alphanumeric characters^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 18774:2015(E), Securities and related financial instruments - Financial Instrument Short Name (FISN)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasIssuerShortName">fibo-sec-sec-iss:hasIssuerShortName</a>
    /// </summary>
    let hasIssuerShortName = _prefixId.prefix "hasIssuerShortName"
    /// <summary>
    ///   <para>rdfs:label : has series^^xsd:string</para>
    ///   <para>skos:definition : indicates the series identified by the issuer in the event that the instrument is issued in several series (also known as tranches)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSeries">fibo-sec-sec-iss:hasSeries</a>
    /// </summary>
    let hasSeries = _prefixId.prefix "hasSeries"
    /// <summary>
    ///   <para>rdfs:label : has subscription amount^^xsd:string</para>
    ///   <para>skos:definition : indicates a number of shares or units^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSubscriptionAmount">fibo-sec-sec-iss:hasSubscriptionAmount</a>
    /// </summary>
    let hasSubscriptionAmount = _prefixId.prefix "hasSubscriptionAmount"
    /// <summary>
    ///   <para>rdfs:label : has subscription period^^xsd:string</para>
    ///   <para>skos:definition : indicates a period of time in which investors can commit to purchase shares (or units) to be issued^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSubscriptionPeriod">fibo-sec-sec-iss:hasSubscriptionPeriod</a>
    /// </summary>
    let hasSubscriptionPeriod = _prefixId.prefix "hasSubscriptionPeriod"
    /// <summary>
    ///   <para>rdfs:label : is issued in form^^xsd:string</para>
    ///   <para>skos:definition : indicates the form in which the security is issued, typically in registered form^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isIssuedInForm">fibo-sec-sec-iss:isIssuedInForm</a>
    /// </summary>
    let isIssuedInForm = _prefixId.prefix "isIssuedInForm"
    /// <summary>
    ///   <para>rdfs:label : is over-allotted^^xsd:string</para>
    ///   <para>skos:definition : indicates whether or not the subscription is over-subscribed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isOverAllotted">fibo-sec-sec-iss:isOverAllotted</a>
    /// </summary>
    let isOverAllotted = _prefixId.prefix "isOverAllotted"
    /// <summary>
    ///   <para>rdfs:label : is registered^^xsd:string</para>
    ///   <para>skos:definition : indicates the registration authority for a given security, i.e., in the name of the owner on the books of the issuer, with the issuer's registrar, with a third-party transfer agent, with a broker-dealer, or other competent party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isRegisteredWith">fibo-sec-sec-iss:isRegisteredWith</a>
    /// </summary>
    let isRegisteredWith = _prefixId.prefix "isRegisteredWith"
    /// <summary>
    ///   <para>rdfs:label : is underwritten by^^xsd:string</para>
    ///   <para>skos:definition : relates an offering to an underwriter involved in raising capital for or distributing the instruments that are the subject of the offering^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isUnderwrittenBy">fibo-sec-sec-iss:isUnderwrittenBy</a>
    /// </summary>
    let isUnderwrittenBy = _prefixId.prefix "isUnderwrittenBy"
    /// <summary>
    ///   <para>rdfs:label : specifies conversion into^^xsd:string</para>
    ///   <para>skos:definition : specifies a security that will replace a convertible security under the terms of the agreement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/specifiesConversionInto">fibo-sec-sec-iss:specifiesConversionInto</a>
    /// </summary>
    let specifiesConversionInto = _prefixId.prefix "specifiesConversionInto"
    /// <summary>
    ///   <para>rdfs:label : underwrites^^xsd:string</para>
    ///   <para>skos:definition : identifies one or more underwriters involved in raising capital for or distributing the instruments that are the subject of the offering^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investopedia.com/terms/u/underwriting.asp^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Underwriting is the process by which investment bankers raise investment capital from investors on behalf of corporations and governments that are issuing either equity or debt securities.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/underwrites">fibo-sec-sec-iss:underwrites</a>
    /// </summary>
    let underwrites = _prefixId.prefix "underwrites"
