namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.Bonds.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_dbt_bnd =
    let _namespace_iri = Namespace_Iri fibo_sec_dbt_bnd |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Bonds Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_dbt_bnd, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:AmortizingBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amortizing bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/AmortizingBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/AmortizingBond</seealso>
    let AmortizingBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "AmortizingBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:Bond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/Bond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/Bond</seealso>
    let Bond = Prefixed_Name(fibo_sec_dbt_bnd, "Bond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BondAmortizationPaymentTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond amortization payment terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondAmortizationPaymentTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondAmortizationPaymentTerms</seealso>
    let BondAmortizationPaymentTerms =
        Prefixed_Name(fibo_sec_dbt_bnd, "BondAmortizationPaymentTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BondConversionTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond conversion terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondConversionTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondConversionTerms</seealso>
    let BondConversionTerms =
        Prefixed_Name(fibo_sec_dbt_bnd, "BondConversionTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BondCoupon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond coupon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondCoupon">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondCoupon</seealso>
    let BondCoupon = Prefixed_Name(fibo_sec_dbt_bnd, "BondCoupon") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BondInsurance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond insurance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondInsurance">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondInsurance</seealso>
    let BondInsurance = Prefixed_Name(fibo_sec_dbt_bnd, "BondInsurance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BondPrincipalRepaymentTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond principal repayment terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondPrincipalRepaymentTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondPrincipalRepaymentTerms</seealso>
    let BondPrincipalRepaymentTerms =
        Prefixed_Name(fibo_sec_dbt_bnd, "BondPrincipalRepaymentTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BondRegistrar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond registrar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondRegistrar">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondRegistrar</seealso>
    let BondRegistrar = Prefixed_Name(fibo_sec_dbt_bnd, "BondRegistrar") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BondVariableCoupon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond variable coupon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondVariableCoupon">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondVariableCoupon</seealso>
    let BondVariableCoupon =
        Prefixed_Name(fibo_sec_dbt_bnd, "BondVariableCoupon") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BondWithPartialCall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond with partial call"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithPartialCall">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithPartialCall</seealso>
    let BondWithPartialCall =
        Prefixed_Name(fibo_sec_dbt_bnd, "BondWithPartialCall") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BondWithPublishedSinkingFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond with published sinking fund"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithPublishedSinkingFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithPublishedSinkingFund</seealso>
    let BondWithPublishedSinkingFund =
        Prefixed_Name(fibo_sec_dbt_bnd, "BondWithPublishedSinkingFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BondWithWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond with warrant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithWarrant">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithWarrant</seealso>
    let BondWithWarrant =
        Prefixed_Name(fibo_sec_dbt_bnd, "BondWithWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BuildAmericaBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Build America Bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BuildAmericaBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BuildAmericaBond</seealso>
    let BuildAmericaBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "BuildAmericaBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BulletBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bullet bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BulletBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BulletBond</seealso>
    let BulletBond = Prefixed_Name(fibo_sec_dbt_bnd, "BulletBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:BulletPrincipalRepaymentTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond bullet principal repayment terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BulletPrincipalRepaymentTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BulletPrincipalRepaymentTerms</seealso>
    let BulletPrincipalRepaymentTerms =
        Prefixed_Name(fibo_sec_dbt_bnd, "BulletPrincipalRepaymentTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:CallableBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"callable bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CallableBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CallableBond</seealso>
    let CallableBond = Prefixed_Name(fibo_sec_dbt_bnd, "CallableBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:CallableConvertibleBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"callable convertible bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CallableConvertibleBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CallableConvertibleBond</seealso>
    let CallableConvertibleBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "CallableConvertibleBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:CertificateOfObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"certificate of obligation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CertificateOfObligation">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CertificateOfObligation</seealso>
    let CertificateOfObligation =
        Prefixed_Name(fibo_sec_dbt_bnd, "CertificateOfObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:CertificateOfParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"certificate of participation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CertificateOfParticipation">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CertificateOfParticipation</seealso>
    let CertificateOfParticipation =
        Prefixed_Name(fibo_sec_dbt_bnd, "CertificateOfParticipation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:ConventionalGilt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"conventional gilt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ConventionalGilt">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ConventionalGilt</seealso>
    let ConventionalGilt =
        Prefixed_Name(fibo_sec_dbt_bnd, "ConventionalGilt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:ConvertibleBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"convertible bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ConvertibleBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ConvertibleBond</seealso>
    let ConvertibleBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "ConvertibleBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:CorporateBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"corporate bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CorporateBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CorporateBond</seealso>
    let CorporateBond = Prefixed_Name(fibo_sec_dbt_bnd, "CorporateBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:CouponPaymentTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"coupon payment terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CouponPaymentTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CouponPaymentTerms</seealso>
    let CouponPaymentTerms =
        Prefixed_Name(fibo_sec_dbt_bnd, "CouponPaymentTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:EquityLinkedBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity linked bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/EquityLinkedBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/EquityLinkedBond</seealso>
    let EquityLinkedBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "EquityLinkedBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:ExtraordinaryRedemptionProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"extraordinary redemption provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ExtraordinaryRedemptionProvision">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ExtraordinaryRedemptionProvision</seealso>
    let ExtraordinaryRedemptionProvision =
        Prefixed_Name(fibo_sec_dbt_bnd, "ExtraordinaryRedemptionProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:FirstRegularCouponDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"first regular coupon date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FirstRegularCouponDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FirstRegularCouponDate</seealso>
    let FirstRegularCouponDate =
        Prefixed_Name(fibo_sec_dbt_bnd, "FirstRegularCouponDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:FixedCouponBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed coupon bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FixedCouponBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FixedCouponBond</seealso>
    let FixedCouponBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "FixedCouponBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:FixedCouponTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed coupon terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FixedCouponTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FixedCouponTerms</seealso>
    let FixedCouponTerms =
        Prefixed_Name(fibo_sec_dbt_bnd, "FixedCouponTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:FloatingRateNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"floating rate note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FloatingRateNote">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FloatingRateNote</seealso>
    let FloatingRateNote =
        Prefixed_Name(fibo_sec_dbt_bnd, "FloatingRateNote") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:FullFaithCreditBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"full faith credit bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FullFaithCreditBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FullFaithCreditBond</seealso>
    let FullFaithCreditBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "FullFaithCreditBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:GeneralObligationMunicipalBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"general obligation municipal bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GeneralObligationMunicipalBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GeneralObligationMunicipalBond</seealso>
    let GeneralObligationMunicipalBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "GeneralObligationMunicipalBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:GovernmentBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GovernmentBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GovernmentBond</seealso>
    let GovernmentBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "GovernmentBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:GovernmentIssuedDebtSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government issued debt security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GovernmentIssuedDebtSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GovernmentIssuedDebtSecurity</seealso>
    let GovernmentIssuedDebtSecurity =
        Prefixed_Name(fibo_sec_dbt_bnd, "GovernmentIssuedDebtSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:GreenBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"green bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GreenBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GreenBond</seealso>
    let GreenBond = Prefixed_Name(fibo_sec_dbt_bnd, "GreenBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:ImplicitFullFaithCreditBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"implicit full faith credit bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ImplicitFullFaithCreditBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ImplicitFullFaithCreditBond</seealso>
    let ImplicitFullFaithCreditBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "ImplicitFullFaithCreditBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:IndexLinkedBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"index-linked bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/IndexLinkedBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/IndexLinkedBond</seealso>
    let IndexLinkedBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "IndexLinkedBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:InflationLinkedBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inflation-linked bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/InflationLinkedBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/InflationLinkedBond</seealso>
    let InflationLinkedBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "InflationLinkedBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:LastRegularCouponDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"last regular coupon date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/LastRegularCouponDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/LastRegularCouponDate</seealso>
    let LastRegularCouponDate =
        Prefixed_Name(fibo_sec_dbt_bnd, "LastRegularCouponDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:ListedBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"listed bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ListedBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ListedBond</seealso>
    let ListedBond = Prefixed_Name(fibo_sec_dbt_bnd, "ListedBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:LotteryConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-dbt-bnd:PartialRedemptionAllocationConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"lottery convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/LotteryConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/LotteryConvention</seealso>
    let LotteryConvention =
        Prefixed_Name(fibo_sec_dbt_bnd, "LotteryConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:MakeWholeCall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"make whole call"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MakeWholeCall">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MakeWholeCall</seealso>
    let MakeWholeCall = Prefixed_Name(fibo_sec_dbt_bnd, "MakeWholeCall") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:MandatoryConvertibleBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mandatory convertible bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MandatoryConvertibleBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MandatoryConvertibleBond</seealso>
    let MandatoryConvertibleBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "MandatoryConvertibleBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:MediumTermNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"medium term note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MediumTermNote">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MediumTermNote</seealso>
    let MediumTermNote =
        Prefixed_Name(fibo_sec_dbt_bnd, "MediumTermNote") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:MunicipalBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"municipal bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalBond</seealso>
    let MunicipalBond = Prefixed_Name(fibo_sec_dbt_bnd, "MunicipalBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:MunicipalDebtFundsUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"municipal debt funds usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtFundsUsage">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtFundsUsage</seealso>
    let MunicipalDebtFundsUsage =
        Prefixed_Name(fibo_sec_dbt_bnd, "MunicipalDebtFundsUsage") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:MunicipalDebtRemarketingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"municipal debt remarketing agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtRemarketingAgent">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtRemarketingAgent</seealso>
    let MunicipalDebtRemarketingAgent =
        Prefixed_Name(fibo_sec_dbt_bnd, "MunicipalDebtRemarketingAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:MunicipalDebtSourceOfFunds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"municipal debt source of funds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtSourceOfFunds">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtSourceOfFunds</seealso>
    let MunicipalDebtSourceOfFunds =
        Prefixed_Name(fibo_sec_dbt_bnd, "MunicipalDebtSourceOfFunds") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:MunicipalNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"municipal note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalNote">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalNote</seealso>
    let MunicipalNote = Prefixed_Name(fibo_sec_dbt_bnd, "MunicipalNote") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:MunicipalSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"municipal security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalSecurity</seealso>
    let MunicipalSecurity =
        Prefixed_Name(fibo_sec_dbt_bnd, "MunicipalSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:MunicipalTrustee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"municipal trustee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalTrustee">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalTrustee</seealso>
    let MunicipalTrustee =
        Prefixed_Name(fibo_sec_dbt_bnd, "MunicipalTrustee") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:OriginalIssueDiscountBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"original issue discount bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/OriginalIssueDiscountBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/OriginalIssueDiscountBond</seealso>
    let OriginalIssueDiscountBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "OriginalIssueDiscountBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:PartialCall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partial call"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialCall">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialCall</seealso>
    let PartialCall = Prefixed_Name(fibo_sec_dbt_bnd, "PartialCall") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:PartialCallFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partial call feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialCallFeature">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialCallFeature</seealso>
    let PartialCallFeature =
        Prefixed_Name(fibo_sec_dbt_bnd, "PartialCallFeature") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:PartialRedemptionAllocationConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partial redemption allocation convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialRedemptionAllocationConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialRedemptionAllocationConvention</seealso>
    let PartialRedemptionAllocationConvention =
        Prefixed_Name(fibo_sec_dbt_bnd, "PartialRedemptionAllocationConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:PercentageCumulativeAverageValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-dbt-bnd:RateBasisConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"percentage cumulative average value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PercentageCumulativeAverageValue">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PercentageCumulativeAverageValue</seealso>
    let PercentageCumulativeAverageValue =
        Prefixed_Name(fibo_sec_dbt_bnd, "PercentageCumulativeAverageValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:PercentageParValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-dbt-bnd:RateBasisConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"percentage par value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PercentageParValue">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PercentageParValue</seealso>
    let PercentageParValue =
        Prefixed_Name(fibo_sec_dbt_bnd, "PercentageParValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:PerpetualBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"perpetual bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PerpetualBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PerpetualBond</seealso>
    let PerpetualBond = Prefixed_Name(fibo_sec_dbt_bnd, "PerpetualBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:ProRataConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-dbt-bnd:PartialRedemptionAllocationConvention</para>
    ///
    /// labels<para>"pro rata convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ProRataConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ProRataConvention</seealso>
    let ProRataConvention =
        Prefixed_Name(fibo_sec_dbt_bnd, "ProRataConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:RateBasisConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rate basis convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RateBasisConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RateBasisConvention</seealso>
    let RateBasisConvention =
        Prefixed_Name(fibo_sec_dbt_bnd, "RateBasisConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:RedemptionPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"redemption payment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RedemptionPayment">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RedemptionPayment</seealso>
    let RedemptionPayment =
        Prefixed_Name(fibo_sec_dbt_bnd, "RedemptionPayment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:RedemptionSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"redemption schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RedemptionSchedule">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RedemptionSchedule</seealso>
    let RedemptionSchedule =
        Prefixed_Name(fibo_sec_dbt_bnd, "RedemptionSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:RegulatoryCall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulatory call"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RegulatoryCall">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RegulatoryCall</seealso>
    let RegulatoryCall =
        Prefixed_Name(fibo_sec_dbt_bnd, "RegulatoryCall") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:RemarketableBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"remarketable bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RemarketableBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RemarketableBond</seealso>
    let RemarketableBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "RemarketableBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:RevenueBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"revenue bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RevenueBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RevenueBond</seealso>
    let RevenueBond = Prefixed_Name(fibo_sec_dbt_bnd, "RevenueBond") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:SecuredBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secured bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SecuredBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SecuredBond</seealso>
    let SecuredBond = Prefixed_Name(fibo_sec_dbt_bnd, "SecuredBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:SinkingFundAmortizationTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sinking fund amortization terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SinkingFundAmortizationTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SinkingFundAmortizationTerms</seealso>
    let SinkingFundAmortizationTerms =
        Prefixed_Name(fibo_sec_dbt_bnd, "SinkingFundAmortizationTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:SovereignBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sovereign bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SovereignBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SovereignBond</seealso>
    let SovereignBond = Prefixed_Name(fibo_sec_dbt_bnd, "SovereignBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:SovereignDebtInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sovereign debt instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SovereignDebtInstrument">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SovereignDebtInstrument</seealso>
    let SovereignDebtInstrument =
        Prefixed_Name(fibo_sec_dbt_bnd, "SovereignDebtInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:SpecialAssessmentBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"special assessment bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialAssessmentBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialAssessmentBond</seealso>
    let SpecialAssessmentBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "SpecialAssessmentBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:SpecialObligationBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"special obligation bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialObligationBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialObligationBond</seealso>
    let SpecialObligationBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "SpecialObligationBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:SpecialTaxBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"special tax bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialTaxBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialTaxBond</seealso>
    let SpecialTaxBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "SpecialTaxBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:StepUpBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"step up bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/StepUpBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/StepUpBond</seealso>
    let StepUpBond = Prefixed_Name(fibo_sec_dbt_bnd, "StepUpBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:SteppedCouponTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"stepped coupon terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SteppedCouponTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SteppedCouponTerms</seealso>
    let SteppedCouponTerms =
        Prefixed_Name(fibo_sec_dbt_bnd, "SteppedCouponTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:StripBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strip bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/StripBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/StripBond</seealso>
    let StripBond = Prefixed_Name(fibo_sec_dbt_bnd, "StripBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:TaxAllocationBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tax allocation bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TaxAllocationBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TaxAllocationBond</seealso>
    let TaxAllocationBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "TaxAllocationBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:TreasuryBill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"treasury bill"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryBill">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryBill</seealso>
    let TreasuryBill = Prefixed_Name(fibo_sec_dbt_bnd, "TreasuryBill") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:TreasuryBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"treasury bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryBond</seealso>
    let TreasuryBond = Prefixed_Name(fibo_sec_dbt_bnd, "TreasuryBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:TreasuryInflationProtectedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"treasury inflation-protected security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryInflationProtectedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryInflationProtectedSecurity</seealso>
    let TreasuryInflationProtectedSecurity =
        Prefixed_Name(fibo_sec_dbt_bnd, "TreasuryInflationProtectedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:TreasuryNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"treasury note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryNote">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryNote</seealso>
    let TreasuryNote = Prefixed_Name(fibo_sec_dbt_bnd, "TreasuryNote") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:UKGovernmentSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"U.K. Government security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UKGovernmentSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UKGovernmentSecurity</seealso>
    let UKGovernmentSecurity =
        Prefixed_Name(fibo_sec_dbt_bnd, "UKGovernmentSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:USTreasurySecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"U.S. Treasury security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/USTreasurySecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/USTreasurySecurity</seealso>
    let USTreasurySecurity =
        Prefixed_Name(fibo_sec_dbt_bnd, "USTreasurySecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:UnlistedBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unlisted bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UnlistedBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UnlistedBond</seealso>
    let UnlistedBond = Prefixed_Name(fibo_sec_dbt_bnd, "UnlistedBond") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:UnsecuredBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unsecured bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UnsecuredBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UnsecuredBond</seealso>
    let UnsecuredBond = Prefixed_Name(fibo_sec_dbt_bnd, "UnsecuredBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:VariableCouponBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable coupon bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableCouponBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableCouponBond</seealso>
    let VariableCouponBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "VariableCouponBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:VariableCouponTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable coupon terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableCouponTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableCouponTerms</seealso>
    let VariableCouponTerms =
        Prefixed_Name(fibo_sec_dbt_bnd, "VariableCouponTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:VariableDebtPrincipal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable debt principal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableDebtPrincipal">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableDebtPrincipal</seealso>
    let VariableDebtPrincipal =
        Prefixed_Name(fibo_sec_dbt_bnd, "VariableDebtPrincipal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:VariableIncomeBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable income bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableIncomeBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableIncomeBond</seealso>
    let VariableIncomeBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "VariableIncomeBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:VariableInterestCalculationFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable interest calculation formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableInterestCalculationFormula">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableInterestCalculationFormula</seealso>
    let VariableInterestCalculationFormula =
        Prefixed_Name(fibo_sec_dbt_bnd, "VariableInterestCalculationFormula") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:VariableInterestExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable interest expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableInterestExpression">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableInterestExpression</seealso>
    let VariableInterestExpression =
        Prefixed_Name(fibo_sec_dbt_bnd, "VariableInterestExpression") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:VariablePrincipalBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable principal bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariablePrincipalBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariablePrincipalBond</seealso>
    let VariablePrincipalBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "VariablePrincipalBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:ZeroCouponBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"zero coupon bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroCouponBond">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroCouponBond</seealso>
    let ZeroCouponBond =
        Prefixed_Name(fibo_sec_dbt_bnd, "ZeroCouponBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:ZeroCouponTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"zero coupon terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroCouponTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroCouponTerms</seealso>
    let ZeroCouponTerms =
        Prefixed_Name(fibo_sec_dbt_bnd, "ZeroCouponTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:ZeroInterestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-dae-dbt:FixedInterestRate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"zero interest rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroInterestRate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroInterestRate</seealso>
    let ZeroInterestRate =
        Prefixed_Name(fibo_sec_dbt_bnd, "ZeroInterestRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasAwardDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has award date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasAwardDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasAwardDate</seealso>
    let hasAwardDate = Prefixed_Name(fibo_sec_dbt_bnd, "hasAwardDate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasCallPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has call price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCallPrice">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCallPrice</seealso>
    let hasCallPrice = Prefixed_Name(fibo_sec_dbt_bnd, "hasCallPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasCallRateBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has call rate basis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCallRateBasis">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCallRateBasis</seealso>
    let hasCallRateBasis =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasCallRateBasis") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasCeiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has ceiling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCeiling">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCeiling</seealso>
    let hasCeiling = Prefixed_Name(fibo_sec_dbt_bnd, "hasCeiling") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasConvertibleDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has convertible date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasConvertibleDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasConvertibleDate</seealso>
    let hasConvertibleDate =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasConvertibleDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasExtraordinaryRedemptionProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has extraordinary redemption provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasExtraordinaryRedemptionProvision">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasExtraordinaryRedemptionProvision</seealso>
    let hasExtraordinaryRedemptionProvision =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasExtraordinaryRedemptionProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFinalMaturityDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has final maturity date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFinalMaturityDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFinalMaturityDate</seealso>
    let hasFinalMaturityDate =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasFinalMaturityDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFirstCallPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first call price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstCallPrice">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstCallPrice</seealso>
    let hasFirstCallPrice =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasFirstCallPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFirstCouponPaymentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first coupon payment date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstCouponPaymentDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstCouponPaymentDate</seealso>
    let hasFirstCouponPaymentDate =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasFirstCouponPaymentDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFirstParCallDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first par call date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstParCallDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstParCallDate</seealso>
    let hasFirstParCallDate =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasFirstParCallDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFirstParCallPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first par call price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstParCallPrice">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstParCallPrice</seealso>
    let hasFirstParCallPrice =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasFirstParCallPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFirstPremiumCallDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first premium call date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPremiumCallDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPremiumCallDate</seealso>
    let hasFirstPremiumCallDate =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasFirstPremiumCallDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFirstPremiumCallPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first premium call price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPremiumCallPrice">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPremiumCallPrice</seealso>
    let hasFirstPremiumCallPrice =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasFirstPremiumCallPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFirstPutDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first put date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPutDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPutDate</seealso>
    let hasFirstPutDate =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasFirstPutDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFirstPutPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first put price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPutPrice">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPutPrice</seealso>
    let hasFirstPutPrice =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasFirstPutPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has floor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFloor">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFloor</seealso>
    let hasFloor = Prefixed_Name(fibo_sec_dbt_bnd, "hasFloor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasFundingSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has funding source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFundingSource">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFundingSource</seealso>
    let hasFundingSource =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasFundingSource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasLastCouponPaymentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has last coupon payment date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasLastCouponPaymentDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasLastCouponPaymentDate</seealso>
    let hasLastCouponPaymentDate =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasLastCouponPaymentDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasLockoutPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has lockout period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasLockoutPeriod">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasLockoutPeriod</seealso>
    let hasLockoutPeriod =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasLockoutPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasMunicipalTrustee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has municipal trustee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasMunicipalTrustee">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasMunicipalTrustee</seealso>
    let hasMunicipalTrustee =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasMunicipalTrustee") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasOriginalIssueDiscountAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has original issue discount amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasOriginalIssueDiscountAmount">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasOriginalIssueDiscountAmount</seealso>
    let hasOriginalIssueDiscountAmount =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasOriginalIssueDiscountAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasPartialRedemptionAllocationConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has partial redemption allocation convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPartialRedemptionAllocationConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPartialRedemptionAllocationConvention</seealso>
    let hasPartialRedemptionAllocationConvention =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasPartialRedemptionAllocationConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasPenultimateCouponPaymentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has penultimate coupon payment date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPenultimateCouponPaymentDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPenultimateCouponPaymentDate</seealso>
    let hasPenultimateCouponPaymentDate =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasPenultimateCouponPaymentDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasPremiumAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has premium amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPremiumAmount">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPremiumAmount</seealso>
    let hasPremiumAmount =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasPremiumAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasPutDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has put date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPutDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPutDate</seealso>
    let hasPutDate = Prefixed_Name(fibo_sec_dbt_bnd, "hasPutDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasPutFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has put frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPutFrequency">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPutFrequency</seealso>
    let hasPutFrequency =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasPutFrequency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasRedemptionAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has redemption amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasRedemptionAmount">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasRedemptionAmount</seealso>
    let hasRedemptionAmount =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasRedemptionAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasRemarketingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has remarketing agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasRemarketingAgent">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasRemarketingAgent</seealso>
    let hasRemarketingAgent =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasRemarketingAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:hasResetDateOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has reset date offset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasResetDateOffset">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasResetDateOffset</seealso>
    let hasResetDateOffset =
        Prefixed_Name(fibo_sec_dbt_bnd, "hasResetDateOffset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:isBankQualified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is bank qualified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isBankQualified">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isBankQualified</seealso>
    let isBankQualified =
        Prefixed_Name(fibo_sec_dbt_bnd, "isBankQualified") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:isLegalOpinionAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is legal opinion available"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isLegalOpinionAvailable">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isLegalOpinionAvailable</seealso>
    let isLegalOpinionAvailable =
        Prefixed_Name(fibo_sec_dbt_bnd, "isLegalOpinionAvailable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:isLinkedToFallback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is linked to fallback"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isLinkedToFallback">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isLinkedToFallback</seealso>
    let isLinkedToFallback =
        Prefixed_Name(fibo_sec_dbt_bnd, "isLinkedToFallback") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:isMandatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is mandatory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isMandatory">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isMandatory</seealso>
    let isMandatory = Prefixed_Name(fibo_sec_dbt_bnd, "isMandatory") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:isProRated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is pro-rated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isProRated">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isProRated</seealso>
    let isProRated = Prefixed_Name(fibo_sec_dbt_bnd, "isProRated") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-bnd:isSuperSinker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"super sinker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isSuperSinker">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isSuperSinker</seealso>
    let isSuperSinker = Prefixed_Name(fibo_sec_dbt_bnd, "isSuperSinker") |> PrefixedName
