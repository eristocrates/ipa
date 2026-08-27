namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.EuropeanEntities.EUFinancialServicesEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_eufse =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_eufse |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-eufse:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"European Financial Services Entities Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_eufse, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufse:CRDCreditInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CRD credit institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CRDCreditInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CRDCreditInstitution</seealso>
    let CRDCreditInstitution =
        Prefixed_Name(fibo_fbc_fct_eufse, "CRDCreditInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufse:CreditInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CreditInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CreditInstitution</seealso>
    let CreditInstitution =
        Prefixed_Name(fibo_fbc_fct_eufse, "CreditInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufse:CreditInstitutionInvestmentFirm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit institution / investment firm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CreditInstitutionInvestmentFirm">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CreditInstitutionInvestmentFirm</seealso>
    let CreditInstitutionInvestmentFirm =
        Prefixed_Name(fibo_fbc_fct_eufse, "CreditInstitutionInvestmentFirm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufse:EuropeanEconomicAreaBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"European Economic Area branch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/EuropeanEconomicAreaBranch">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/EuropeanEconomicAreaBranch</seealso>
    let EuropeanEconomicAreaBranch =
        Prefixed_Name(fibo_fbc_fct_eufse, "EuropeanEconomicAreaBranch") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufse:InvestmentFirm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investment firm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/InvestmentFirm">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/InvestmentFirm</seealso>
    let InvestmentFirm =
        Prefixed_Name(fibo_fbc_fct_eufse, "InvestmentFirm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufse:LocalFirm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"local firm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/LocalFirm">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/LocalFirm</seealso>
    let LocalFirm = Prefixed_Name(fibo_fbc_fct_eufse, "LocalFirm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufse:NonEuropeanEconomicAreaBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non European Economic Area branch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/NonEuropeanEconomicAreaBranch">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/NonEuropeanEconomicAreaBranch</seealso>
    let NonEuropeanEconomicAreaBranch =
        Prefixed_Name(fibo_fbc_fct_eufse, "NonEuropeanEconomicAreaBranch") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufse:PaymentInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/PaymentInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/PaymentInstitution</seealso>
    let PaymentInstitution =
        Prefixed_Name(fibo_fbc_fct_eufse, "PaymentInstitution") |> PrefixedName
