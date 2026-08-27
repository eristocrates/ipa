namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.NorthAmericanSecurities.USSecuritiesRestrictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_usrst =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_usrst |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-usrst:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"US Securities Restrictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_usrst, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-usrst:BlueSkyLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"blue sky law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/BlueSkyLaw">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/BlueSkyLaw</seealso>
    let BlueSkyLaw = Prefixed_Name(fibo_sec_sec_usrst, "BlueSkyLaw") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-usrst:RegulationD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-rst:SecuritiesRegulation</para>
    ///
    /// labels<para>"Regulation D"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/RegulationD">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/RegulationD</seealso>
    let RegulationD = Prefixed_Name(fibo_sec_sec_usrst, "RegulationD") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-usrst:RegulationS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-rst:SecuritiesRegulation</para>
    ///   <para>fibo-sec-sec-rst:InvestorsDomicileRestriction</para>
    ///   <para>fibo-sec-sec-rst:QualifiedInvestorRestriction</para>
    ///
    /// labels<para>"Regulation S"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/RegulationS">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/RegulationS</seealso>
    let RegulationS = Prefixed_Name(fibo_sec_sec_usrst, "RegulationS") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-usrst:Rule144A</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-rst:LegalHoldingRestriction</para>
    ///
    /// labels<para>"Rule 144A"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/Rule144A">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/Rule144A</seealso>
    let Rule144A = Prefixed_Name(fibo_sec_sec_usrst, "Rule144A") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-usrst:SECExemption3c7</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-rst:SecuritiesRegulation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEC Exemption 3(c)(7)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/SECExemption3c7">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/SECExemption3c7</seealso>
    let SECExemption3c7 =
        Prefixed_Name(fibo_sec_sec_usrst, "SECExemption3c7") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-usrst:SECRule15c3-3</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-rst:SecuritiesRegulation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEC Rule 15c3-3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/SECRule15c3-3">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/SECRule15c3-3</seealso>
    let SECRule15c3_3 =
        Prefixed_Name(fibo_sec_sec_usrst, "SECRule15c3-3") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-usrst:SECRule201</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-rst:SecuritiesRegulation</para>
    ///   <para>fibo-sec-sec-rst:TradingRestriction</para>
    ///
    /// labels<para>"SEC Rule 201"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/SECRule201">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/SECRule201</seealso>
    let SECRule201 = Prefixed_Name(fibo_sec_sec_usrst, "SECRule201") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-usrst:TEFRACRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-rst:SecuritiesRegulation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TEFRA C rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/TEFRACRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/TEFRACRule</seealso>
    let TEFRACRule = Prefixed_Name(fibo_sec_sec_usrst, "TEFRACRule") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-usrst:TEFRADRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-rst:SecuritiesRegulation</para>
    ///
    /// labels<para>"TEFRA D rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/TEFRADRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/TEFRADRule</seealso>
    let TEFRADRule = Prefixed_Name(fibo_sec_sec_usrst, "TEFRADRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-usrst:isEmployeeRetirementIncomeSecurityActConformant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is Employee Retirement Income Security Act conformant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/isEmployeeRetirementIncomeSecurityActConformant">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/isEmployeeRetirementIncomeSecurityActConformant</seealso>
    let isEmployeeRetirementIncomeSecurityActConformant =
        Prefixed_Name(fibo_sec_sec_usrst, "isEmployeeRetirementIncomeSecurityActConformant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-usrst:isFederalDepositInsuranceCorporationInsured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is Federal Deposit Insurance Corporation insured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/isFederalDepositInsuranceCorporationInsured">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/isFederalDepositInsuranceCorporationInsured</seealso>
    let isFederalDepositInsuranceCorporationInsured =
        Prefixed_Name(fibo_sec_sec_usrst, "isFederalDepositInsuranceCorporationInsured") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-usrst:isSubjectToFederalReserveBoardRegulationT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is subject to Federal Reserve Board Regulation T"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/isSubjectToFederalReserveBoardRegulationT">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/isSubjectToFederalReserveBoardRegulationT</seealso>
    let isSubjectToFederalReserveBoardRegulationT =
        Prefixed_Name(fibo_sec_sec_usrst, "isSubjectToFederalReserveBoardRegulationT") |> PrefixedName
