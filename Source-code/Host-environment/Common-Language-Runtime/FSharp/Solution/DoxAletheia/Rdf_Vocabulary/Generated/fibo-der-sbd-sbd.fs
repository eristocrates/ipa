namespace https.spec.edmcouncil.org.fibo.ontology.DER.SecurityBasedDerivatives.SecurityBasedDerivatives.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_sbd_sbd =
    let _namespace_iri = Namespace_Iri fibo_der_sbd_sbd |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-sbd-sbd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Security-Based Derivatives Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_sbd_sbd, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:BasketOfDebtInstruments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket of debt instruments"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/BasketOfDebtInstruments">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/BasketOfDebtInstruments</seealso>
    let BasketOfDebtInstruments =
        Prefixed_Name(fibo_der_sbd_sbd, "BasketOfDebtInstruments") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:CapitalizedLeaseObligationDebtBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"capitalized lease obligation debt basket"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/CapitalizedLeaseObligationDebtBasket">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/CapitalizedLeaseObligationDebtBasket</seealso>
    let CapitalizedLeaseObligationDebtBasket =
        Prefixed_Name(fibo_der_sbd_sbd, "CapitalizedLeaseObligationDebtBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:ContributionDebtBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contribution debt basket"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/ContributionDebtBasket">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/ContributionDebtBasket</seealso>
    let ContributionDebtBasket =
        Prefixed_Name(fibo_der_sbd_sbd, "ContributionDebtBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:CreditFacilityDebtBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit facility debt basket"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/CreditFacilityDebtBasket">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/CreditFacilityDebtBasket</seealso>
    let CreditFacilityDebtBasket =
        Prefixed_Name(fibo_der_sbd_sbd, "CreditFacilityDebtBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:DebtInstrumentDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debt instrument derivative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/DebtInstrumentDerivative">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/DebtInstrumentDerivative</seealso>
    let DebtInstrumentDerivative =
        Prefixed_Name(fibo_der_sbd_sbd, "DebtInstrumentDerivative") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:EquityDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity derivative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/EquityDerivative">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/EquityDerivative</seealso>
    let EquityDerivative =
        Prefixed_Name(fibo_der_sbd_sbd, "EquityDerivative") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:GeneralDebtBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"general debt basket"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/GeneralDebtBasket">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/GeneralDebtBasket</seealso>
    let GeneralDebtBasket =
        Prefixed_Name(fibo_der_sbd_sbd, "GeneralDebtBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:IncrementalFacilityDebtBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"incremental facility debt basket"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/IncrementalFacilityDebtBasket">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/IncrementalFacilityDebtBasket</seealso>
    let IncrementalFacilityDebtBasket =
        Prefixed_Name(fibo_der_sbd_sbd, "IncrementalFacilityDebtBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:LocalLinesOfCreditDebtBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"local lines of credit debt basket"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/LocalLinesOfCreditDebtBasket">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/LocalLinesOfCreditDebtBasket</seealso>
    let LocalLinesOfCreditDebtBasket =
        Prefixed_Name(fibo_der_sbd_sbd, "LocalLinesOfCreditDebtBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:Non-GuarantorDebtBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-guarantor debt basket"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/Non-GuarantorDebtBasket">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/Non-GuarantorDebtBasket</seealso>
    let Non_GuarantorDebtBasket =
        Prefixed_Name(fibo_der_sbd_sbd, "Non-GuarantorDebtBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:RatioDebtBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ratio debt basket"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/RatioDebtBasket">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/RatioDebtBasket</seealso>
    let RatioDebtBasket =
        Prefixed_Name(fibo_der_sbd_sbd, "RatioDebtBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-sbd:SecurityBasedDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security-based derivative"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/SecurityBasedDerivative">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/SecurityBasedDerivative</seealso>
    let SecurityBasedDerivative =
        Prefixed_Name(fibo_der_sbd_sbd, "SecurityBasedDerivative") |> PrefixedName
