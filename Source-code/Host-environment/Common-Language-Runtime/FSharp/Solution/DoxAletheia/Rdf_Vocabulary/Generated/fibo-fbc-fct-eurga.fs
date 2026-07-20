namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.EuropeanEntities.EURegulatoryAgencies.slash

open DoxAletheia

module fibo_fbc_fct_eurga =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanCentralBank"></see>
    /// </summary>
    let EuropeanCentralBank = _prefix "EuropeanCentralBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/CreditInstitutionRegister"></see>
    /// </summary>
    let CreditInstitutionRegister = _prefix "CreditInstitutionRegister"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanBankingAuthorityRegulator"></see>
    /// </summary>
    let EuropeanBankingAuthorityRegulator = _prefix "EuropeanBankingAuthorityRegulator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/CreditInstitutionRegisterEntry"></see>
    /// </summary>
    let CreditInstitutionRegisterEntry = _prefix "CreditInstitutionRegisterEntry"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanBankingAuthority"></see>
    /// </summary>
    let EuropeanBankingAuthority = _prefix "EuropeanBankingAuthority"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanBankingRegulatoryAgencyAndCentralBank"></see>
    /// </summary>
    let EuropeanBankingRegulatoryAgencyAndCentralBank =
        _prefix "EuropeanBankingRegulatoryAgencyAndCentralBank"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanCentralBankHeadquartersAndLegalAddress"></see>
    /// </summary>
    let EuropeanCentralBankHeadquartersAndLegalAddress =
        _prefix "EuropeanCentralBankHeadquartersAndLegalAddress"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/EuropeanCentralBankLegalEntityIdentifierRegistryEntry"></see>
    /// </summary>
    let EuropeanCentralBankLegalEntityIdentifierRegistryEntry =
        _prefix "EuropeanCentralBankLegalEntityIdentifierRegistryEntry"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/FinancialConductAuthority"></see>
    /// </summary>
    let FinancialConductAuthority = _prefix "FinancialConductAuthority"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/FinancialConductAuthorityEntity"></see>
    /// </summary>
    let FinancialConductAuthorityEntity = _prefix "FinancialConductAuthorityEntity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/FinancialConductAuthorityHeadquartersAndLegalAddress"></see>
    /// </summary>
    let FinancialConductAuthorityHeadquartersAndLegalAddress =
        _prefix "FinancialConductAuthorityHeadquartersAndLegalAddress"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/PrudentialRegulatoryAuthority"></see>
    /// </summary>
    let PrudentialRegulatoryAuthority = _prefix "PrudentialRegulatoryAuthority"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/PrudentialRegulatoryAuthorityEntity"></see>
    /// </summary>
    let PrudentialRegulatoryAuthorityEntity =
        _prefix "PrudentialRegulatoryAuthorityEntity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/PrudentialRegulatoryAuthorityHeadquartersAndLegalAddress"></see>
    /// </summary>
    let PrudentialRegulatoryAuthorityHeadquartersAndLegalAddress =
        _prefix "PrudentialRegulatoryAuthorityHeadquartersAndLegalAddress"
