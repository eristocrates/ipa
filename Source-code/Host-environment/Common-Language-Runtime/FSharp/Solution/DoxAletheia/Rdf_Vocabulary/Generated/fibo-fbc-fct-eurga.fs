namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.EuropeanEntities.EURegulatoryAgencies.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_eurga =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_eurga |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"European Regulatory Agencies Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_eurga, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:CreditInstitutionRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///
    /// labels<para>"Credit Institution Register"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/CreditInstitutionRegister">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/CreditInstitutionRegister</seealso>
    let CreditInstitutionRegister =
        Prefixed_Name(fibo_fbc_fct_eurga, "CreditInstitutionRegister") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:CreditInstitutionRegisterEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Credit Institution Register entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/CreditInstitutionRegisterEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/CreditInstitutionRegisterEntry</seealso>
    let CreditInstitutionRegisterEntry =
        Prefixed_Name(fibo_fbc_fct_eurga, "CreditInstitutionRegisterEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:EuropeanBankingAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///
    /// labels<para>"European Banking Authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanBankingAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanBankingAuthority</seealso>
    let EuropeanBankingAuthority =
        Prefixed_Name(fibo_fbc_fct_eurga, "EuropeanBankingAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:EuropeanBankingAuthorityRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///
    /// labels<para>"European Banking Authority (EBA) Regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanBankingAuthorityRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanBankingAuthorityRegulator</seealso>
    let EuropeanBankingAuthorityRegulator =
        Prefixed_Name(fibo_fbc_fct_eurga, "EuropeanBankingAuthorityRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:EuropeanBankingRegulatoryAgencyAndCentralBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:CentralBank</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>fibo-ind-ir-ir:InterestRateAuthority</para>
    ///
    /// labels<para>"European banking regulatory agency and central bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanBankingRegulatoryAgencyAndCentralBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanBankingRegulatoryAgencyAndCentralBank</seealso>
    let EuropeanBankingRegulatoryAgencyAndCentralBank =
        Prefixed_Name(fibo_fbc_fct_eurga, "EuropeanBankingRegulatoryAgencyAndCentralBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:EuropeanCentralBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:Instrumentality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"European Central Bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanCentralBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanCentralBank</seealso>
    let EuropeanCentralBank =
        Prefixed_Name(fibo_fbc_fct_eurga, "EuropeanCentralBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:EuropeanCentralBankHeadquartersAndLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"European Central Bank headquarters and legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanCentralBankHeadquartersAndLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanCentralBankHeadquartersAndLegalAddress</seealso>
    let EuropeanCentralBankHeadquartersAndLegalAddress =
        Prefixed_Name(fibo_fbc_fct_eurga, "EuropeanCentralBankHeadquartersAndLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:FinancialConductAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Financial Conduct Authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/FinancialConductAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/FinancialConductAuthority</seealso>
    let FinancialConductAuthority =
        Prefixed_Name(fibo_fbc_fct_eurga, "FinancialConductAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:FinancialConductAuthorityEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Financial Conduct Authority entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/FinancialConductAuthorityEntity">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/FinancialConductAuthorityEntity</seealso>
    let FinancialConductAuthorityEntity =
        Prefixed_Name(fibo_fbc_fct_eurga, "FinancialConductAuthorityEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:FinancialConductAuthorityHeadquartersAndLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Financial Conduct Authority headquarters and legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/FinancialConductAuthorityHeadquartersAndLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/FinancialConductAuthorityHeadquartersAndLegalAddress</seealso>
    let FinancialConductAuthorityHeadquartersAndLegalAddress =
        Prefixed_Name(fibo_fbc_fct_eurga, "FinancialConductAuthorityHeadquartersAndLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:PrudentialRegulatoryAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///
    /// labels<para>"Prudential Regulatory Authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/PrudentialRegulatoryAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/PrudentialRegulatoryAuthority</seealso>
    let PrudentialRegulatoryAuthority =
        Prefixed_Name(fibo_fbc_fct_eurga, "PrudentialRegulatoryAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:PrudentialRegulatoryAuthorityEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Prudential Regulatory Authority entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/PrudentialRegulatoryAuthorityEntity">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/PrudentialRegulatoryAuthorityEntity</seealso>
    let PrudentialRegulatoryAuthorityEntity =
        Prefixed_Name(fibo_fbc_fct_eurga, "PrudentialRegulatoryAuthorityEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eurga:PrudentialRegulatoryAuthorityHeadquartersAndLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Prudential Regulatory Authority headquarters and legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/PrudentialRegulatoryAuthorityHeadquartersAndLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/PrudentialRegulatoryAuthorityHeadquartersAndLegalAddress</seealso>
    let PrudentialRegulatoryAuthorityHeadquartersAndLegalAddress =
        Prefixed_Name(fibo_fbc_fct_eurga, "PrudentialRegulatoryAuthorityHeadquartersAndLegalAddress") |> PrefixedName
