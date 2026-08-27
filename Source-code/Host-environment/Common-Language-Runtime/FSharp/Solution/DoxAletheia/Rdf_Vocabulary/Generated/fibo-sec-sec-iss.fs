namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesIssuance.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_iss =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_iss |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-iss:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Securities Issuance Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_iss, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:BearerAndRegisteredForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-iss:SecurityForm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Documents:Certificate</para>
    ///
    /// labels<para>"bearer and registered form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BearerAndRegisteredForm">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BearerAndRegisteredForm</seealso>
    let BearerAndRegisteredForm =
        Prefixed_Name(fibo_sec_sec_iss, "BearerAndRegisteredForm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:BearerForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-iss:SecurityForm</para>
    ///   <para>Documents:Certificate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"bearer form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BearerForm">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BearerForm</seealso>
    let BearerForm = Prefixed_Name(fibo_sec_sec_iss, "BearerForm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:BestEffortsOffering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"best efforts offering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BestEffortsOffering">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BestEffortsOffering</seealso>
    let BestEffortsOffering =
        Prefixed_Name(fibo_sec_sec_iss, "BestEffortsOffering") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:BookEntryForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-iss:SecurityForm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"book entry form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BookEntryForm">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BookEntryForm</seealso>
    let BookEntryForm = Prefixed_Name(fibo_sec_sec_iss, "BookEntryForm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:ConversionTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conversion terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ConversionTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ConversionTerms</seealso>
    let ConversionTerms =
        Prefixed_Name(fibo_sec_sec_iss, "ConversionTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:ConvertibleSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"convertible security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ConvertibleSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ConvertibleSecurity</seealso>
    let ConvertibleSecurity =
        Prefixed_Name(fibo_sec_sec_iss, "ConvertibleSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:ExemptIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exempt issuer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptIssuer">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptIssuer</seealso>
    let ExemptIssuer = Prefixed_Name(fibo_sec_sec_iss, "ExemptIssuer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:ExemptOffering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exempt offering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptOffering">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptOffering</seealso>
    let ExemptOffering =
        Prefixed_Name(fibo_sec_sec_iss, "ExemptOffering") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:ExemptTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exempt transaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptTransaction">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptTransaction</seealso>
    let ExemptTransaction =
        Prefixed_Name(fibo_sec_sec_iss, "ExemptTransaction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:FinancialInstrumentShortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial instrument short name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/FinancialInstrumentShortName">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/FinancialInstrumentShortName</seealso>
    let FinancialInstrumentShortName =
        Prefixed_Name(fibo_sec_sec_iss, "FinancialInstrumentShortName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:FirmCommitmentOffering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"firm commitment offering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/FirmCommitmentOffering">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/FirmCommitmentOffering</seealso>
    let FirmCommitmentOffering =
        Prefixed_Name(fibo_sec_sec_iss, "FirmCommitmentOffering") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:MiscellaneousForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-iss:SecurityForm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"miscellaneous form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/MiscellaneousForm">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/MiscellaneousForm</seealso>
    let MiscellaneousForm =
        Prefixed_Name(fibo_sec_sec_iss, "MiscellaneousForm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:OfferingDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"offering document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/OfferingDocument">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/OfferingDocument</seealso>
    let OfferingDocument =
        Prefixed_Name(fibo_sec_sec_iss, "OfferingDocument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:OfferingStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"offering statement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/OfferingStatement">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/OfferingStatement</seealso>
    let OfferingStatement =
        Prefixed_Name(fibo_sec_sec_iss, "OfferingStatement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:PrivateOffering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"private offering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PrivateOffering">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PrivateOffering</seealso>
    let PrivateOffering =
        Prefixed_Name(fibo_sec_sec_iss, "PrivateOffering") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:PrivatePlacementMemorandum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"private placement memorandum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PrivatePlacementMemorandum">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PrivatePlacementMemorandum</seealso>
    let PrivatePlacementMemorandum =
        Prefixed_Name(fibo_sec_sec_iss, "PrivatePlacementMemorandum") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:Prospectus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"prospectus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/Prospectus">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/Prospectus</seealso>
    let Prospectus = Prefixed_Name(fibo_sec_sec_iss, "Prospectus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:PublicOffering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"public offering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PublicOffering">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PublicOffering</seealso>
    let PublicOffering =
        Prefixed_Name(fibo_sec_sec_iss, "PublicOffering") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:RegisteredForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-iss:SecurityForm</para>
    ///
    /// labels<para>"registered form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/RegisteredForm">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/RegisteredForm</seealso>
    let RegisteredForm =
        Prefixed_Name(fibo_sec_sec_iss, "RegisteredForm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:SecuritiesOffering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"securities offering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecuritiesOffering">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecuritiesOffering</seealso>
    let SecuritiesOffering =
        Prefixed_Name(fibo_sec_sec_iss, "SecuritiesOffering") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:SecurityForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityForm">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityForm</seealso>
    let SecurityForm = Prefixed_Name(fibo_sec_sec_iss, "SecurityForm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:SecurityOfferingDistributionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"security offering distribution type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityOfferingDistributionType">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityOfferingDistributionType</seealso>
    let SecurityOfferingDistributionType =
        Prefixed_Name(fibo_sec_sec_iss, "SecurityOfferingDistributionType") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:SecurityUnderwriter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security underwriter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityUnderwriter">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityUnderwriter</seealso>
    let SecurityUnderwriter =
        Prefixed_Name(fibo_sec_sec_iss, "SecurityUnderwriter") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:SecurityUnderwritingArrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security underwriting arrangement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityUnderwritingArrangement">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityUnderwritingArrangement</seealso>
    let SecurityUnderwritingArrangement =
        Prefixed_Name(fibo_sec_sec_iss, "SecurityUnderwritingArrangement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:hasActualClosingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has actual closing date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasActualClosingDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasActualClosingDate</seealso>
    let hasActualClosingDate =
        Prefixed_Name(fibo_sec_sec_iss, "hasActualClosingDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:hasAnnouncementDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has announcement date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasAnnouncementDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasAnnouncementDate</seealso>
    let hasAnnouncementDate =
        Prefixed_Name(fibo_sec_sec_iss, "hasAnnouncementDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:hasFinancialInstrumentShortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has financial instrument short name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFinancialInstrumentShortName">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFinancialInstrumentShortName</seealso>
    let hasFinancialInstrumentShortName =
        Prefixed_Name(fibo_sec_sec_iss, "hasFinancialInstrumentShortName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:hasFirstTradeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first trade date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFirstTradeDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFirstTradeDate</seealso>
    let hasFirstTradeDate =
        Prefixed_Name(fibo_sec_sec_iss, "hasFirstTradeDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:hasFirstTradeSettlementDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first trade settlement date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFirstTradeSettlementDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFirstTradeSettlementDate</seealso>
    let hasFirstTradeSettlementDate =
        Prefixed_Name(fibo_sec_sec_iss, "hasFirstTradeSettlementDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:hasInstrumentDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has instrument description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasInstrumentDescription">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasInstrumentDescription</seealso>
    let hasInstrumentDescription =
        Prefixed_Name(fibo_sec_sec_iss, "hasInstrumentDescription") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:hasIssuerShortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has issuer short name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasIssuerShortName">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasIssuerShortName</seealso>
    let hasIssuerShortName =
        Prefixed_Name(fibo_sec_sec_iss, "hasIssuerShortName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:hasSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has series"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSeries">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSeries</seealso>
    let hasSeries = Prefixed_Name(fibo_sec_sec_iss, "hasSeries") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:hasSubscriptionAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has subscription amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSubscriptionAmount">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSubscriptionAmount</seealso>
    let hasSubscriptionAmount =
        Prefixed_Name(fibo_sec_sec_iss, "hasSubscriptionAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:hasSubscriptionPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has subscription period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSubscriptionPeriod">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSubscriptionPeriod</seealso>
    let hasSubscriptionPeriod =
        Prefixed_Name(fibo_sec_sec_iss, "hasSubscriptionPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:isIssuedInForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is issued in form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isIssuedInForm">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isIssuedInForm</seealso>
    let isIssuedInForm =
        Prefixed_Name(fibo_sec_sec_iss, "isIssuedInForm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:isOverAllotted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is over-allotted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isOverAllotted">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isOverAllotted</seealso>
    let isOverAllotted =
        Prefixed_Name(fibo_sec_sec_iss, "isOverAllotted") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:isRegisteredWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is registered"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isRegisteredWith">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isRegisteredWith</seealso>
    let isRegisteredWith =
        Prefixed_Name(fibo_sec_sec_iss, "isRegisteredWith") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:isUnderwrittenBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is underwritten by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isUnderwrittenBy">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isUnderwrittenBy</seealso>
    let isUnderwrittenBy =
        Prefixed_Name(fibo_sec_sec_iss, "isUnderwrittenBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:specifiesConversionInto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"specifies conversion into"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/specifiesConversionInto">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/specifiesConversionInto</seealso>
    let specifiesConversionInto =
        Prefixed_Name(fibo_sec_sec_iss, "specifiesConversionInto") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-iss:underwrites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"underwrites"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/underwrites">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/underwrites</seealso>
    let underwrites = Prefixed_Name(fibo_sec_sec_iss, "underwrites") |> PrefixedName
