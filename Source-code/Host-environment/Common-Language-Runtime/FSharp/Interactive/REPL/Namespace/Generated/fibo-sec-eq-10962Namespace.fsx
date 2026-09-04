#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-eq-10962`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/" "fibo-sec-eq-10962"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : common, enhanced voting, restricted, fully-paid, registered share</para>
    ///   <para>skos:definition : common share that confers multiple votes per share, is restricted from a sales / transfer perspective, is fully paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonEnhancedVotingRestrictedFullyPaidRegisteredShare">fibo-sec-eq-10962:CommonEnhancedVotingRestrictedFullyPaidRegisteredShare</a>
    /// </summary>
    let CommonEnhancedVotingRestrictedFullyPaidRegisteredShare =
        _prefixId.prefix "CommonEnhancedVotingRestrictedFullyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, enhanced voting, restricted, nil paid, registered share</para>
    ///   <para>skos:definition : common share that confers multiple votes per share, is restricted from a sales / transfer perspective, is nil paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonEnhancedVotingRestrictedNilPaidRegisteredShare">fibo-sec-eq-10962:CommonEnhancedVotingRestrictedNilPaidRegisteredShare</a>
    /// </summary>
    let CommonEnhancedVotingRestrictedNilPaidRegisteredShare =
        _prefixId.prefix "CommonEnhancedVotingRestrictedNilPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, enhanced voting, restricted, partly paid, registered share</para>
    ///   <para>skos:definition : common share that confers multiple votes per share, is restricted from a sales / transfer perspective, is partially paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonEnhancedVotingRestrictedPartlyPaidRegisteredShare">fibo-sec-eq-10962:CommonEnhancedVotingRestrictedPartlyPaidRegisteredShare</a>
    /// </summary>
    let CommonEnhancedVotingRestrictedPartlyPaidRegisteredShare =
        _prefixId.prefix "CommonEnhancedVotingRestrictedPartlyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, enhanced voting, unrestricted, fully-paid, registered share</para>
    ///   <para>skos:definition : common share that confers multiple votes per share, is not restricted from a sales / transfer perspective, is fully paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonEnhancedVotingUnrestrictedFullyPaidRegisteredShare">fibo-sec-eq-10962:CommonEnhancedVotingUnrestrictedFullyPaidRegisteredShare</a>
    /// </summary>
    let CommonEnhancedVotingUnrestrictedFullyPaidRegisteredShare =
        _prefixId.prefix "CommonEnhancedVotingUnrestrictedFullyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, enhanced voting, unrestricted, nil paid, registered share</para>
    ///   <para>skos:definition : common share that confers multiple votes per share, is not restricted from a sales / transfer perspective, is nil paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonEnhancedVotingUnrestrictedNilPaidRegisteredShare">fibo-sec-eq-10962:CommonEnhancedVotingUnrestrictedNilPaidRegisteredShare</a>
    /// </summary>
    let CommonEnhancedVotingUnrestrictedNilPaidRegisteredShare =
        _prefixId.prefix "CommonEnhancedVotingUnrestrictedNilPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, enhanced voting, unrestricted, partly paid, registered share</para>
    ///   <para>skos:definition : common share that confers multiple votes per share, is not restricted from a sales / transfer perspective, is partially paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonEnhancedVotingUnrestrictedPartlyPaidRegisteredShare">fibo-sec-eq-10962:CommonEnhancedVotingUnrestrictedPartlyPaidRegisteredShare</a>
    /// </summary>
    let CommonEnhancedVotingUnrestrictedPartlyPaidRegisteredShare =
        _prefixId.prefix "CommonEnhancedVotingUnrestrictedPartlyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, non-voting, restricted, fully-paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly 0 votes per share, is restricted from a sales / transfer perspective, is fully paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonNonVotingRestrictedFullyPaidRegisteredShare">fibo-sec-eq-10962:CommonNonVotingRestrictedFullyPaidRegisteredShare</a>
    /// </summary>
    let CommonNonVotingRestrictedFullyPaidRegisteredShare =
        _prefixId.prefix "CommonNonVotingRestrictedFullyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, non-voting, restricted, nil paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly 0 votes per share, is restricted from a sales / transfer perspective, is nil paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonNonVotingRestrictedNilPaidRegisteredShare">fibo-sec-eq-10962:CommonNonVotingRestrictedNilPaidRegisteredShare</a>
    /// </summary>
    let CommonNonVotingRestrictedNilPaidRegisteredShare =
        _prefixId.prefix "CommonNonVotingRestrictedNilPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, non-voting, restricted, partly paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly 0 votes per share, is restricted from a sales / transfer perspective, is partially paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonNonVotingRestrictedPartlyPaidRegisteredShare">fibo-sec-eq-10962:CommonNonVotingRestrictedPartlyPaidRegisteredShare</a>
    /// </summary>
    let CommonNonVotingRestrictedPartlyPaidRegisteredShare =
        _prefixId.prefix "CommonNonVotingRestrictedPartlyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, non-voting, unrestricted, fully-paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly 0 votes per share, is unrestricted from a sales perspective, is fully paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonNonVotingUnrestrictedFullyPaidRegisteredShare">fibo-sec-eq-10962:CommonNonVotingUnrestrictedFullyPaidRegisteredShare</a>
    /// </summary>
    let CommonNonVotingUnrestrictedFullyPaidRegisteredShare =
        _prefixId.prefix "CommonNonVotingUnrestrictedFullyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, non-voting, unrestricted, nil paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly 0 votes per share, is unrestricted from a sales perspective, is nil paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonNonVotingUnrestrictedNilPaidRegisteredShare">fibo-sec-eq-10962:CommonNonVotingUnrestrictedNilPaidRegisteredShare</a>
    /// </summary>
    let CommonNonVotingUnrestrictedNilPaidRegisteredShare =
        _prefixId.prefix "CommonNonVotingUnrestrictedNilPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, non-voting, unrestricted, partly paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly 0 votes per share, is unrestricted from a sales perspective, is partially paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonNonVotingUnrestrictedPartlyPaidRegisteredShare">fibo-sec-eq-10962:CommonNonVotingUnrestrictedPartlyPaidRegisteredShare</a>
    /// </summary>
    let CommonNonVotingUnrestrictedPartlyPaidRegisteredShare =
        _prefixId.prefix "CommonNonVotingUnrestrictedPartlyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, restricted voting, restricted, fully-paid, registered share</para>
    ///   <para>skos:definition : common share that confers less than one vote per share, is restricted from a sales / transfer perspective, is fully paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonRestrictedVotingRestrictedFullyPaidRegisteredShare">fibo-sec-eq-10962:CommonRestrictedVotingRestrictedFullyPaidRegisteredShare</a>
    /// </summary>
    let CommonRestrictedVotingRestrictedFullyPaidRegisteredShare =
        _prefixId.prefix "CommonRestrictedVotingRestrictedFullyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, restricted voting, restricted, nil paid, registered share</para>
    ///   <para>skos:definition : common share that confers less than one vote per share, is restricted from a sales / transfer perspective, is nil paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonRestrictedVotingRestrictedNilPaidRegisteredShare">fibo-sec-eq-10962:CommonRestrictedVotingRestrictedNilPaidRegisteredShare</a>
    /// </summary>
    let CommonRestrictedVotingRestrictedNilPaidRegisteredShare =
        _prefixId.prefix "CommonRestrictedVotingRestrictedNilPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, restricted voting, restricted, partly paid, registered share</para>
    ///   <para>skos:definition : common share that confers less than one vote per share, is restricted from a sales / transfer perspective, is partially paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonRestrictedVotingRestrictedPartlyPaidRegisteredShare">fibo-sec-eq-10962:CommonRestrictedVotingRestrictedPartlyPaidRegisteredShare</a>
    /// </summary>
    let CommonRestrictedVotingRestrictedPartlyPaidRegisteredShare =
        _prefixId.prefix "CommonRestrictedVotingRestrictedPartlyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, restricted voting, unrestricted, fully-paid, registered share</para>
    ///   <para>skos:definition : common share that confers less than one vote per share, is unrestricted from a sales / transfer perspective, is fully paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonRestrictedVotingUnrestrictedFullyPaidRegisteredShare">fibo-sec-eq-10962:CommonRestrictedVotingUnrestrictedFullyPaidRegisteredShare</a>
    /// </summary>
    let CommonRestrictedVotingUnrestrictedFullyPaidRegisteredShare =
        _prefixId.prefix "CommonRestrictedVotingUnrestrictedFullyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, restricted voting, unrestricted, nil paid, registered share</para>
    ///   <para>skos:definition : common share that confers less than one vote per share, is unrestricted from a sales / transfer perspective, is nil paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonRestrictedVotingUnrestrictedNilPaidRegisteredShare">fibo-sec-eq-10962:CommonRestrictedVotingUnrestrictedNilPaidRegisteredShare</a>
    /// </summary>
    let CommonRestrictedVotingUnrestrictedNilPaidRegisteredShare =
        _prefixId.prefix "CommonRestrictedVotingUnrestrictedNilPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, restricted voting, unrestricted, partly paid, registered share</para>
    ///   <para>skos:definition : common share that confers less than one vote per share, is unrestricted from a sales / transfer perspective, is partially paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonRestrictedVotingUnrestrictedPartlyPaidRegisteredShare">fibo-sec-eq-10962:CommonRestrictedVotingUnrestrictedPartlyPaidRegisteredShare</a>
    /// </summary>
    let CommonRestrictedVotingUnrestrictedPartlyPaidRegisteredShare =
        _prefixId.prefix "CommonRestrictedVotingUnrestrictedPartlyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, voting, restricted, fully-paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly one vote per share, is restricted from a sales / transfer perspective, is fully paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonVotingRestrictedFullyPaidRegisteredShare">fibo-sec-eq-10962:CommonVotingRestrictedFullyPaidRegisteredShare</a>
    /// </summary>
    let CommonVotingRestrictedFullyPaidRegisteredShare =
        _prefixId.prefix "CommonVotingRestrictedFullyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, voting, restricted, nil paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly one vote per share, is restricted from a sales / transfer perspective, is nil paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonVotingRestrictedNilPaidRegisteredShare">fibo-sec-eq-10962:CommonVotingRestrictedNilPaidRegisteredShare</a>
    /// </summary>
    let CommonVotingRestrictedNilPaidRegisteredShare =
        _prefixId.prefix "CommonVotingRestrictedNilPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, voting, restricted, partly paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly one vote per share, is restricted from a sales / transfer perspective, is partially paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonVotingRestrictedPartlyPaidRegisteredShare">fibo-sec-eq-10962:CommonVotingRestrictedPartlyPaidRegisteredShare</a>
    /// </summary>
    let CommonVotingRestrictedPartlyPaidRegisteredShare =
        _prefixId.prefix "CommonVotingRestrictedPartlyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, voting, unrestricted, fully-paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly one vote per share, is unrestricted from a sales perspective, is fully paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonVotingUnrestrictedFullyPaidRegisteredShare">fibo-sec-eq-10962:CommonVotingUnrestrictedFullyPaidRegisteredShare</a>
    /// </summary>
    let CommonVotingUnrestrictedFullyPaidRegisteredShare =
        _prefixId.prefix "CommonVotingUnrestrictedFullyPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, voting, unrestricted, nil paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly one vote per share, is unrestricted from a sales perspective, is nil paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonVotingUnrestrictedNilPaidRegisteredShare">fibo-sec-eq-10962:CommonVotingUnrestrictedNilPaidRegisteredShare</a>
    /// </summary>
    let CommonVotingUnrestrictedNilPaidRegisteredShare =
        _prefixId.prefix "CommonVotingUnrestrictedNilPaidRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : common, voting, unrestricted, partly paid, registered share</para>
    ///   <para>skos:definition : common share that confers exactly one vote per share, is unrestricted from a sales perspective, is partially paid and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/CommonVotingUnrestrictedPartlyPaidRegisteredShare">fibo-sec-eq-10962:CommonVotingUnrestrictedPartlyPaidRegisteredShare</a>
    /// </summary>
    let CommonVotingUnrestrictedPartlyPaidRegisteredShare =
        _prefixId.prefix "CommonVotingUnrestrictedPartlyPaidRegisteredShare"

    let ESETFR = _prefixId.prefix "ESETFR"
    let ESETOR = _prefixId.prefix "ESETOR"
    let ESETPR = _prefixId.prefix "ESETPR"
    let ESEUFR = _prefixId.prefix "ESEUFR"
    let ESEUOR = _prefixId.prefix "ESEUOR"
    let ESEUPR = _prefixId.prefix "ESEUPR"
    let ESNTFR = _prefixId.prefix "ESNTFR"
    let ESNTOR = _prefixId.prefix "ESNTOR"
    let ESNTPR = _prefixId.prefix "ESNTPR"
    let ESNUFR = _prefixId.prefix "ESNUFR"
    let ESNUOR = _prefixId.prefix "ESNUOR"
    let ESNUPR = _prefixId.prefix "ESNUPR"
    let ESRTFR = _prefixId.prefix "ESRTFR"
    let ESRTOR = _prefixId.prefix "ESRTOR"
    let ESRTPR = _prefixId.prefix "ESRTPR"
    let ESRUFR = _prefixId.prefix "ESRUFR"
    let ESRUOR = _prefixId.prefix "ESRUOR"
    let ESRUPR = _prefixId.prefix "ESRUPR"
    let ESVTFR = _prefixId.prefix "ESVTFR"
    let ESVTOR = _prefixId.prefix "ESVTOR"
    let ESVTPR = _prefixId.prefix "ESVTPR"
    let ESVUFR = _prefixId.prefix "ESVUFR"
    let ESVUOR = _prefixId.prefix "ESVUOR"
    let ESVUPR = _prefixId.prefix "ESVUPR"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, exchangeable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExchangeableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExchangeableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExchangeableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExchangeableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, exchangeable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExchangeableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExchangeableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExchangeableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExchangeableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, exchangeable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExchangeableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExchangeableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExchangeableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExchangeableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, exchangeable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExchangeableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExchangeableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExchangeableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExchangeableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, exchangeable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExchangeableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExchangeableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExchangeableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExchangeableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, exchangeable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExchangeableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExchangeableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExchangeableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExchangeableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, exchangeable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExchangeableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExchangeableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExchangeableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExchangeableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, perpetual, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, has no fixed maturity date, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingPerpetualAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingPerpetualAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingPerpetualAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingPerpetualAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, perpetual, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, has no fixed maturity date, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingPerpetualAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingPerpetualAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingPerpetualAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingPerpetualAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, perpetual, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, has no fixed maturity date, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingPerpetualCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingPerpetualCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingPerpetualCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingPerpetualCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, perpetual, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, has no fixed maturity date, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingPerpetualCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingPerpetualCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingPerpetualCumulativeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingPerpetualCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, perpetual, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, has no fixed maturity date, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingPerpetualFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingPerpetualFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingPerpetualFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingPerpetualFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, perpetual, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, has no fixed maturity date, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingPerpetualNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingPerpetualNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingPerpetualNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingPerpetualNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, perpetual, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, has no fixed maturity date, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingPerpetualParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingPerpetualParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingPerpetualParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingPerpetualParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable exchangeable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable exchangeable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable exchangeable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable exchangeable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable/exchangeable/extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable/exchangeable/extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable/exchangeable/extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable/exchangeable/extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable/exchangeable/extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable/exchangeable/extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable/exchangeable/extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable exchangeable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable exchangeable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable exchangeable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExchangeableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExchangeableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExchangeableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExchangeableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, enhanced voting, redeemable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers multiple votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredEnhancedVotingRedeemableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredEnhancedVotingRedeemableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredEnhancedVotingRedeemableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredEnhancedVotingRedeemableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, exchangeable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExchangeableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExchangeableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExchangeableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExchangeableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, exchangeable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExchangeableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExchangeableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExchangeableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExchangeableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, exchangeable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExchangeableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExchangeableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExchangeableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExchangeableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, exchangeable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExchangeableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExchangeableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExchangeableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExchangeableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, exchangeable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExchangeableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExchangeableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExchangeableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExchangeableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, exchangeable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExchangeableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExchangeableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExchangeableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExchangeableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, exchangeable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExchangeableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExchangeableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExchangeableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExchangeableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, perpetual, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, has no fixed maturity date, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingPerpetualAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingPerpetualAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingPerpetualAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingPerpetualAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, perpetual, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, has no fixed maturity date, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingPerpetualAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingPerpetualAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingPerpetualAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingPerpetualAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, perpetual, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, has no fixed maturity date, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingPerpetualCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingPerpetualCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingPerpetualCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingPerpetualCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, perpetual, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, has no fixed maturity date, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingPerpetualCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingPerpetualCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingPerpetualCumulativeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingPerpetualCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, perpetual, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, has no fixed maturity date, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingPerpetualFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingPerpetualFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingPerpetualFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingPerpetualFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, perpetual, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, has no fixed maturity date, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingPerpetualNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingPerpetualNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingPerpetualNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingPerpetualNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, perpetual, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, has no fixed maturity date, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingPerpetualParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingPerpetualParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingPerpetualParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingPerpetualParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable exchangeable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable exchangeable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable exchangeable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable exchangeable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable/exchangeable/extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable/exchangeable/extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable/exchangeable/extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable/exchangeable/extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable/exchangeable/extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable/exchangeable/extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable/exchangeable/extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable exchangeable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable exchangeable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable exchangeable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExchangeableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExchangeableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExchangeableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExchangeableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, non-voting, redeemable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers zero votes per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredNonVotingRedeemableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredNonVotingRedeemableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredNonVotingRedeemableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredNonVotingRedeemableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, exchangeable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExchangeableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExchangeableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExchangeableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExchangeableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, exchangeable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExchangeableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExchangeableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExchangeableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExchangeableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, exchangeable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExchangeableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExchangeableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExchangeableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExchangeableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, exchangeable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExchangeableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExchangeableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExchangeableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExchangeableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, exchangeable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExchangeableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExchangeableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExchangeableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExchangeableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, exchangeable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExchangeableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExchangeableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExchangeableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExchangeableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, exchangeable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExchangeableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExchangeableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExchangeableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExchangeableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, perpetual, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, has no fixed maturity date, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingPerpetualAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingPerpetualAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingPerpetualAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingPerpetualAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, perpetual, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, has no fixed maturity date, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingPerpetualAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingPerpetualAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingPerpetualAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingPerpetualAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, perpetual, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, has no fixed maturity date, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingPerpetualCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingPerpetualCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingPerpetualCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingPerpetualCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, perpetual, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, has no fixed maturity date, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingPerpetualCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingPerpetualCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingPerpetualCumulativeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingPerpetualCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, perpetual, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, has no fixed maturity date, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingPerpetualFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingPerpetualFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingPerpetualFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingPerpetualFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, perpetual, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, has no fixed maturity date, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingPerpetualNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingPerpetualNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingPerpetualNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingPerpetualNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, perpetual, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, has no fixed maturity date, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingPerpetualParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingPerpetualParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingPerpetualParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingPerpetualParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable exchangeable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable exchangeable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable exchangeable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable exchangeable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable/exchangeable/extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable/exchangeable/extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable/exchangeable/extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable/exchangeable/extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable/exchangeable/extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable/exchangeable/extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable/exchangeable/extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable exchangeable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable exchangeable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable exchangeable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExchangeableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExchangeableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExchangeableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExchangeableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, restricted voting, redeemable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers less than one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredRestrictedVotingRedeemableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredRestrictedVotingRedeemableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredRestrictedVotingRedeemableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredRestrictedVotingRedeemableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, exchangeable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExchangeableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingExchangeableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingExchangeableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingExchangeableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, exchangeable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExchangeableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingExchangeableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingExchangeableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingExchangeableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, exchangeable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExchangeableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingExchangeableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingExchangeableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingExchangeableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, exchangeable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExchangeableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredVotingExchangeableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredVotingExchangeableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredVotingExchangeableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, exchangeable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExchangeableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingExchangeableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingExchangeableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingExchangeableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, exchangeable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExchangeableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingExchangeableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingExchangeableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingExchangeableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, exchangeable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExchangeableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingExchangeableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingExchangeableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingExchangeableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredVotingExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredVotingExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredVotingExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption date, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, perpetual, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, has no fixed maturity date, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingPerpetualAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingPerpetualAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingPerpetualAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingPerpetualAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, perpetual, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, has no fixed maturity date, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingPerpetualAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingPerpetualAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingPerpetualAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingPerpetualAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, perpetual, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, has no fixed maturity date, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingPerpetualCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingPerpetualCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingPerpetualCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingPerpetualCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, perpetual, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, has no fixed maturity date, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingPerpetualCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredVotingPerpetualCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredVotingPerpetualCumulativeRegisteredShare =
        _prefixId.prefix "PreferredVotingPerpetualCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, perpetual, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, has no fixed maturity date, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingPerpetualFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingPerpetualFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingPerpetualFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingPerpetualFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, perpetual, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, has no fixed maturity date, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingPerpetualNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingPerpetualNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingPerpetualNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingPerpetualNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, perpetual, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, has no fixed maturity date, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingPerpetualParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingPerpetualParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingPerpetualParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingPerpetualParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable exchangeable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable exchangeable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable exchangeable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable exchangeable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable/exchangeable/extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable/exchangeable/extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable/exchangeable/extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable/exchangeable/extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable/exchangeable/extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable/exchangeable/extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable/exchangeable/extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable exchangeable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable exchangeable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable exchangeable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one per share, may be exchanged for securities of another issuer, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExchangeableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExchangeableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExchangeableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExchangeableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable extendable, adjustable income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is set periodically, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExtendableAdjustableIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExtendableAdjustableIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExtendableAdjustableIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExtendableAdjustableIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable extendable, auction rate income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic income whose dividend rate is adjusted through an auction, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExtendableAuctionRateIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExtendableAuctionRateIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExtendableAuctionRateIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExtendableAuctionRateIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable extendable, cumulative participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, dividends not paid in any year accumulate, and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExtendableCumulativeParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExtendableCumulativeParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExtendableCumulativeParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExtendableCumulativeParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable extendable, cumulative, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and dividends not paid in any year accumulate, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExtendableCumulativeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExtendableCumulativeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExtendableCumulativeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExtendableCumulativeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable extendable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExtendableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExtendableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExtendableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExtendableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable extendable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExtendableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExtendableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExtendableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExtendableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable extendable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, whose issuer and/or shareholders have the option to extend the maturity date, that provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableExtendableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableExtendableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableExtendableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableExtendableParticipatingRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable, fixed income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableFixedIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableFixedIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableFixedIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableFixedIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable, normal income, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides the same dividends as common/ordinary shareholders, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableNormalIncomeRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableNormalIncomeRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableNormalIncomeRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableNormalIncomeRegisteredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred, voting, redeemable, participating, registered share</para>
    ///   <para>skos:definition : preferred share that confers exactly one vote per share, may be redeemed at the option of the issuer and/or of the shareholder, provides a periodic stated income and participates with common shareholders in further dividend and capital distributions, and is registered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/PreferredVotingRedeemableParticipatingRegisteredShare">fibo-sec-eq-10962:PreferredVotingRedeemableParticipatingRegisteredShare</a>
    /// </summary>
    let PreferredVotingRedeemableParticipatingRegisteredShare =
        _prefixId.prefix "PreferredVotingRedeemableParticipatingRegisteredShare"
