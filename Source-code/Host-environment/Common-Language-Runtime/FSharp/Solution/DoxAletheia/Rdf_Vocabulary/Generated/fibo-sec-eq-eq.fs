namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Equities.EquityInstruments.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_eq_eq =
    let _namespace_iri = Namespace_Iri fibo_sec_eq_eq |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-eq-eq:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Equity Instruments Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_eq_eq, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:AdjustableRateDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"adjustable rate dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/AdjustableRateDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/AdjustableRateDividend</seealso>
    let AdjustableRateDividend =
        Prefixed_Name(fibo_sec_eq_eq, "AdjustableRateDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:AuctionRateDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"auction rate dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/AuctionRateDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/AuctionRateDividend</seealso>
    let AuctionRateDividend =
        Prefixed_Name(fibo_sec_eq_eq, "AuctionRateDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:CommonShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"common share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/CommonShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/CommonShare</seealso>
    let CommonShare = Prefixed_Name(fibo_sec_eq_eq, "CommonShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:ConvertibleCommonShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"convertible common share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ConvertibleCommonShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ConvertibleCommonShare</seealso>
    let ConvertibleCommonShare =
        Prefixed_Name(fibo_sec_eq_eq, "ConvertibleCommonShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:ConvertiblePreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"convertible preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ConvertiblePreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ConvertiblePreferredShare</seealso>
    let ConvertiblePreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "ConvertiblePreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:CumulativePreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cumulative preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/CumulativePreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/CumulativePreferredShare</seealso>
    let CumulativePreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "CumulativePreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:Custodian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"custodian"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Custodian">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Custodian</seealso>
    let Custodian = Prefixed_Name(fibo_sec_eq_eq, "Custodian") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:DistributionByCashPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-eq-eq:DividendDistributionMethod</para>
    ///
    /// labels<para>"distribution by payment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DistributionByCashPayment">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DistributionByCashPayment</seealso>
    let DistributionByCashPayment =
        Prefixed_Name(fibo_sec_eq_eq, "DistributionByCashPayment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:DistributionByReinvestment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-eq-eq:DividendDistributionMethod</para>
    ///
    /// labels<para>"distribution by reinvestment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DistributionByReinvestment">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DistributionByReinvestment</seealso>
    let DistributionByReinvestment =
        Prefixed_Name(fibo_sec_eq_eq, "DistributionByReinvestment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:Dividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Dividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Dividend</seealso>
    let Dividend = Prefixed_Name(fibo_sec_eq_eq, "Dividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:DividendDistributionMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dividend distribution method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DividendDistributionMethod">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DividendDistributionMethod</seealso>
    let DividendDistributionMethod =
        Prefixed_Name(fibo_sec_eq_eq, "DividendDistributionMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:DividendSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dividend schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DividendSchedule">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DividendSchedule</seealso>
    let DividendSchedule =
        Prefixed_Name(fibo_sec_eq_eq, "DividendSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:EnhancedVotingShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"enhanced voting share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EnhancedVotingShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EnhancedVotingShare</seealso>
    let EnhancedVotingShare =
        Prefixed_Name(fibo_sec_eq_eq, "EnhancedVotingShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:EquityConversionTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity conversion terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityConversionTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityConversionTerms</seealso>
    let EquityConversionTerms =
        Prefixed_Name(fibo_sec_eq_eq, "EquityConversionTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:EquityPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity position"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityPosition">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityPosition</seealso>
    let EquityPosition = Prefixed_Name(fibo_sec_eq_eq, "EquityPosition") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:EquityRedemptionProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity redemption provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityRedemptionProvision">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityRedemptionProvision</seealso>
    let EquityRedemptionProvision =
        Prefixed_Name(fibo_sec_eq_eq, "EquityRedemptionProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:EquityRedemptionProvisionWithExtendableRedemptionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity redemption provision with extendable redemption date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityRedemptionProvisionWithExtendableRedemptionDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityRedemptionProvisionWithExtendableRedemptionDate</seealso>
    let EquityRedemptionProvisionWithExtendableRedemptionDate =
        Prefixed_Name(fibo_sec_eq_eq, "EquityRedemptionProvisionWithExtendableRedemptionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:ExchangeablePreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exchangeable preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ExchangeablePreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ExchangeablePreferredShare</seealso>
    let ExchangeablePreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "ExchangeablePreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:ExtendablePreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"extendable preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ExtendablePreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ExtendablePreferredShare</seealso>
    let ExtendablePreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "ExtendablePreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:FixedRateDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed rate dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FixedRateDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FixedRateDividend</seealso>
    let FixedRateDividend =
        Prefixed_Name(fibo_sec_eq_eq, "FixedRateDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:FullyPaidShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fully paid share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FullyPaidShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FullyPaidShare</seealso>
    let FullyPaidShare = Prefixed_Name(fibo_sec_eq_eq, "FullyPaidShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:FullyPaidShareStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-eq-eq:SharePaymentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"fully paid share status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FullyPaidShareStatus">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FullyPaidShareStatus</seealso>
    let FullyPaidShareStatus =
        Prefixed_Name(fibo_sec_eq_eq, "FullyPaidShareStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:HardRetractablePreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hard retractable preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/HardRetractablePreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/HardRetractablePreferredShare</seealso>
    let HardRetractablePreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "HardRetractablePreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:LimitedPartnershipUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"limited partnership unit"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/LimitedPartnershipUnit">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/LimitedPartnershipUnit</seealso>
    let LimitedPartnershipUnit =
        Prefixed_Name(fibo_sec_eq_eq, "LimitedPartnershipUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:ListedShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"listed share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ListedShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ListedShare</seealso>
    let ListedShare = Prefixed_Name(fibo_sec_eq_eq, "ListedShare") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-eq-eq:NilPaidShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nil paid share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NilPaidShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NilPaidShare</seealso>
    let NilPaidShare = Prefixed_Name(fibo_sec_eq_eq, "NilPaidShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:NilPaidShareStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-eq-eq:SharePaymentStatus</para>
    ///
    /// labels<para>"nil paid share status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NilPaidShareStatus">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NilPaidShareStatus</seealso>
    let NilPaidShareStatus =
        Prefixed_Name(fibo_sec_eq_eq, "NilPaidShareStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:NonCumulativePreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-cumulative preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonCumulativePreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonCumulativePreferredShare</seealso>
    let NonCumulativePreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "NonCumulativePreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:NonParticipatingPreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-participating preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonParticipatingPreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonParticipatingPreferredShare</seealso>
    let NonParticipatingPreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "NonParticipatingPreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:NonVotingShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-voting share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonVotingShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonVotingShare</seealso>
    let NonVotingShare = Prefixed_Name(fibo_sec_eq_eq, "NonVotingShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:OrdinaryDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ordinary dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/OrdinaryDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/OrdinaryDividend</seealso>
    let OrdinaryDividend =
        Prefixed_Name(fibo_sec_eq_eq, "OrdinaryDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PartiallyPaidShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partially paid share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PartiallyPaidShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PartiallyPaidShare</seealso>
    let PartiallyPaidShare =
        Prefixed_Name(fibo_sec_eq_eq, "PartiallyPaidShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PartiallyPaidShareStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-eq-eq:SharePaymentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"partially paid share status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PartiallyPaidShareStatus">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PartiallyPaidShareStatus</seealso>
    let PartiallyPaidShareStatus =
        Prefixed_Name(fibo_sec_eq_eq, "PartiallyPaidShareStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:ParticipatingPreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"participating preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ParticipatingPreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ParticipatingPreferredShare</seealso>
    let ParticipatingPreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "ParticipatingPreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PerpetualPreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"perpetual preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PerpetualPreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PerpetualPreferredShare</seealso>
    let PerpetualPreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "PerpetualPreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PrecedenceRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"precedence right"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PrecedenceRight">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PrecedenceRight</seealso>
    let PrecedenceRight =
        Prefixed_Name(fibo_sec_eq_eq, "PrecedenceRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PreferredDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredDividend</seealso>
    let PreferredDividend =
        Prefixed_Name(fibo_sec_eq_eq, "PreferredDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShare</seealso>
    let PreferredShare = Prefixed_Name(fibo_sec_eq_eq, "PreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PreferredShareWithAdjustableRateDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred share with adjustable rate dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithAdjustableRateDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithAdjustableRateDividend</seealso>
    let PreferredShareWithAdjustableRateDividend =
        Prefixed_Name(fibo_sec_eq_eq, "PreferredShareWithAdjustableRateDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PreferredShareWithAuctionRateDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred share with auction rate dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithAuctionRateDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithAuctionRateDividend</seealso>
    let PreferredShareWithAuctionRateDividend =
        Prefixed_Name(fibo_sec_eq_eq, "PreferredShareWithAuctionRateDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PreferredShareWithFixedMaturityDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred share with fixed maturity date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithFixedMaturityDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithFixedMaturityDate</seealso>
    let PreferredShareWithFixedMaturityDate =
        Prefixed_Name(fibo_sec_eq_eq, "PreferredShareWithFixedMaturityDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PreferredShareWithFixedRateDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preferred share with fixed rate dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithFixedRateDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithFixedRateDividend</seealso>
    let PreferredShareWithFixedRateDividend =
        Prefixed_Name(fibo_sec_eq_eq, "PreferredShareWithFixedRateDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PricePerShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"price per share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PricePerShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PricePerShare</seealso>
    let PricePerShare = Prefixed_Name(fibo_sec_eq_eq, "PricePerShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:PrivatelyHeldShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"privately held share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PrivatelyHeldShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PrivatelyHeldShare</seealso>
    let PrivatelyHeldShare =
        Prefixed_Name(fibo_sec_eq_eq, "PrivatelyHeldShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:QualifiedDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"qualified dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/QualifiedDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/QualifiedDividend</seealso>
    let QualifiedDividend =
        Prefixed_Name(fibo_sec_eq_eq, "QualifiedDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:RedeemablePreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"redeemable preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShare</seealso>
    let RedeemablePreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "RedeemablePreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:RedeemablePreferredShareWithExtendableMaturityDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"redeemable preferred share with extendable maturity date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShareWithExtendableMaturityDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShareWithExtendableMaturityDate</seealso>
    let RedeemablePreferredShareWithExtendableMaturityDate =
        Prefixed_Name(fibo_sec_eq_eq, "RedeemablePreferredShareWithExtendableMaturityDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:RedeemablePreferredShareWithExtendableRedemptionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"redeemable preferred share with extendable redemption date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShareWithExtendableRedemptionDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShareWithExtendableRedemptionDate</seealso>
    let RedeemablePreferredShareWithExtendableRedemptionDate =
        Prefixed_Name(fibo_sec_eq_eq, "RedeemablePreferredShareWithExtendableRedemptionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:RestrictedShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"restricted share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RestrictedShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RestrictedShare</seealso>
    let RestrictedShare =
        Prefixed_Name(fibo_sec_eq_eq, "RestrictedShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:RestrictedVotingShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"restricted voting share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RestrictedVotingShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RestrictedVotingShare</seealso>
    let RestrictedVotingShare =
        Prefixed_Name(fibo_sec_eq_eq, "RestrictedVotingShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:RetractablePreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"retractable preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShare</seealso>
    let RetractablePreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "RetractablePreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:RetractablePreferredShareWithExtendableMaturityDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"retractable preferred share with extendable maturity date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShareWithExtendableMaturityDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShareWithExtendableMaturityDate</seealso>
    let RetractablePreferredShareWithExtendableMaturityDate =
        Prefixed_Name(fibo_sec_eq_eq, "RetractablePreferredShareWithExtendableMaturityDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:RetractablePreferredShareWithExtendableRedemptionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"retractable preferred share with extendable redemption date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShareWithExtendableRedemptionDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShareWithExtendableRedemptionDate</seealso>
    let RetractablePreferredShareWithExtendableRedemptionDate =
        Prefixed_Name(fibo_sec_eq_eq, "RetractablePreferredShareWithExtendableRedemptionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:Share</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Share">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Share</seealso>
    let Share = Prefixed_Name(fibo_sec_eq_eq, "Share") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-eq-eq:ShareIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"share issuer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ShareIssuer">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ShareIssuer</seealso>
    let ShareIssuer = Prefixed_Name(fibo_sec_eq_eq, "ShareIssuer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:SharePaymentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"share payment status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SharePaymentStatus">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SharePaymentStatus</seealso>
    let SharePaymentStatus =
        Prefixed_Name(fibo_sec_eq_eq, "SharePaymentStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:ShareYield</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"share yield"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ShareYield">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ShareYield</seealso>
    let ShareYield = Prefixed_Name(fibo_sec_eq_eq, "ShareYield") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:SingleVotingShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"single voting share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SingleVotingShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SingleVotingShare</seealso>
    let SingleVotingShare =
        Prefixed_Name(fibo_sec_eq_eq, "SingleVotingShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:SoftRetractablePreferredShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"soft retractable preferred share"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SoftRetractablePreferredShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SoftRetractablePreferredShare</seealso>
    let SoftRetractablePreferredShare =
        Prefixed_Name(fibo_sec_eq_eq, "SoftRetractablePreferredShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:SpecialDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"special dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SpecialDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SpecialDividend</seealso>
    let SpecialDividend =
        Prefixed_Name(fibo_sec_eq_eq, "SpecialDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:UnrestrictedShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unrestricted share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/UnrestrictedShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/UnrestrictedShare</seealso>
    let UnrestrictedShare =
        Prefixed_Name(fibo_sec_eq_eq, "UnrestrictedShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:VariableInterestEntityShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable interest entity share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/VariableInterestEntityShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/VariableInterestEntityShare</seealso>
    let VariableInterestEntityShare =
        Prefixed_Name(fibo_sec_eq_eq, "VariableInterestEntityShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:VotingRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"voting right"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/VotingRight">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/VotingRight</seealso>
    let VotingRight = Prefixed_Name(fibo_sec_eq_eq, "VotingRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:confersNumberOfVotesPerShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"number of votes per share"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/confersNumberOfVotesPerShare">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/confersNumberOfVotesPerShare</seealso>
    let confersNumberOfVotesPerShare =
        Prefixed_Name(fibo_sec_eq_eq, "confersNumberOfVotesPerShare") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:confersOwnershipOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"confers ownership of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/confersOwnershipOf">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/confersOwnershipOf</seealso>
    let confersOwnershipOf =
        Prefixed_Name(fibo_sec_eq_eq, "confersOwnershipOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasAdjustableDividendRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has adjustable dividend rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasAdjustableDividendRate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasAdjustableDividendRate</seealso>
    let hasAdjustableDividendRate =
        Prefixed_Name(fibo_sec_eq_eq, "hasAdjustableDividendRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasAvailableShares</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has available shares"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasAvailableShares">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasAvailableShares</seealso>
    let hasAvailableShares =
        Prefixed_Name(fibo_sec_eq_eq, "hasAvailableShares") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasDistributionMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has distribution method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDistributionMethod">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDistributionMethod</seealso>
    let hasDistributionMethod =
        Prefixed_Name(fibo_sec_eq_eq, "hasDistributionMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasDividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividend">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividend</seealso>
    let hasDividend = Prefixed_Name(fibo_sec_eq_eq, "hasDividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasDividendDeclarationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has declaration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividendDeclarationDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividendDeclarationDate</seealso>
    let hasDividendDeclarationDate =
        Prefixed_Name(fibo_sec_eq_eq, "hasDividendDeclarationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasDividendGracePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has dividend grace period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividendGracePeriod">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividendGracePeriod</seealso>
    let hasDividendGracePeriod =
        Prefixed_Name(fibo_sec_eq_eq, "hasDividendGracePeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasEarliestRedemptionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has earliest redemption date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasEarliestRedemptionDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasEarliestRedemptionDate</seealso>
    let hasEarliestRedemptionDate =
        Prefixed_Name(fibo_sec_eq_eq, "hasEarliestRedemptionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasExDividendDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has ex-dividend date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExDividendDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExDividendDate</seealso>
    let hasExDividendDate =
        Prefixed_Name(fibo_sec_eq_eq, "hasExDividendDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasExtendableMaturityDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has extendable maturity date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExtendableMaturityDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExtendableMaturityDate</seealso>
    let hasExtendableMaturityDate =
        Prefixed_Name(fibo_sec_eq_eq, "hasExtendableMaturityDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasExtendableRedemptionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has extendable redemption date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExtendableRedemptionDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExtendableRedemptionDate</seealso>
    let hasExtendableRedemptionDate =
        Prefixed_Name(fibo_sec_eq_eq, "hasExtendableRedemptionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasFixedDividendRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has fixed dividend rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasFixedDividendRate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasFixedDividendRate</seealso>
    let hasFixedDividendRate =
        Prefixed_Name(fibo_sec_eq_eq, "hasFixedDividendRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasFloatingStock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has floating stock"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasFloatingStock">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasFloatingStock</seealso>
    let hasFloatingStock =
        Prefixed_Name(fibo_sec_eq_eq, "hasFloatingStock") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasMinimumRedemptionPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has minimum redemption price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasMinimumRedemptionPrice">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasMinimumRedemptionPrice</seealso>
    let hasMinimumRedemptionPrice =
        Prefixed_Name(fibo_sec_eq_eq, "hasMinimumRedemptionPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasRecordDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has record date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasRecordDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasRecordDate</seealso>
    let hasRecordDate = Prefixed_Name(fibo_sec_eq_eq, "hasRecordDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasRedemptionPremium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has redemption premium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasRedemptionPremium">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasRedemptionPremium</seealso>
    let hasRedemptionPremium =
        Prefixed_Name(fibo_sec_eq_eq, "hasRedemptionPremium") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasShareClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has share class"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasShareClass">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasShareClass</seealso>
    let hasShareClass = Prefixed_Name(fibo_sec_eq_eq, "hasShareClass") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasSharePaymentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has share payment status"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharePaymentStatus">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharePaymentStatus</seealso>
    let hasSharePaymentStatus =
        Prefixed_Name(fibo_sec_eq_eq, "hasSharePaymentStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasSharesIssued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has shares issued"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharesIssued">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharesIssued</seealso>
    let hasSharesIssued =
        Prefixed_Name(fibo_sec_eq_eq, "hasSharesIssued") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasSharesOutstanding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has shares outstanding"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharesOutstanding">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharesOutstanding</seealso>
    let hasSharesOutstanding =
        Prefixed_Name(fibo_sec_eq_eq, "hasSharesOutstanding") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasTreasuryShares</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has treasury shares"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasTreasuryShares">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasTreasuryShares</seealso>
    let hasTreasuryShares =
        Prefixed_Name(fibo_sec_eq_eq, "hasTreasuryShares") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:hasVotingRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has voting restriction"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasVotingRestriction">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasVotingRestriction</seealso>
    let hasVotingRestriction =
        Prefixed_Name(fibo_sec_eq_eq, "hasVotingRestriction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:isRedeemableAtIssuerOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is redeemable at issuer option"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isRedeemableAtIssuerOption">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isRedeemableAtIssuerOption</seealso>
    let isRedeemableAtIssuerOption =
        Prefixed_Name(fibo_sec_eq_eq, "isRedeemableAtIssuerOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:isRedeemableAtShareholderOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is redeemable at shareholder option"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isRedeemableAtShareholderOption">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isRedeemableAtShareholderOption</seealso>
    let isRedeemableAtShareholderOption =
        Prefixed_Name(fibo_sec_eq_eq, "isRedeemableAtShareholderOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:isSeniorTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is senior to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isSeniorTo">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isSeniorTo</seealso>
    let isSeniorTo = Prefixed_Name(fibo_sec_eq_eq, "isSeniorTo") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-eq:specifiesConversionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"specifies conversion date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/specifiesConversionDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/specifiesConversionDate</seealso>
    let specifiesConversionDate =
        Prefixed_Name(fibo_sec_eq_eq, "specifiesConversionDate") |> PrefixedName
