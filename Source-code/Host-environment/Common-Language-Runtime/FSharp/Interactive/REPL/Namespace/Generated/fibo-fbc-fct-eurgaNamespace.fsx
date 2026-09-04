#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-eurga`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/" "fibo-fbc-fct-eurga"

    let _namespaceIri = _prefixId.prefix ""
    let CreditInstitutionRegister = _prefixId.prefix "CreditInstitutionRegister"

    /// <summary>
    ///   <para>rdfs:label : Credit Institution Register entry^^xsd:string</para>
    ///   <para>skos:definition : entry in the Credit Institution Register, a repository of credit institutions collected by the European Banking Authority (EBA) as provided by the various national banking authorities for those institutions that qualify^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.eba.europa.eu/risk-analysis-and-data/credit-institutions-register^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/CreditInstitutionRegisterEntry">fibo-fbc-fct-eurga:CreditInstitutionRegisterEntry</a>
    /// </summary>
    let CreditInstitutionRegisterEntry =
        _prefixId.prefix "CreditInstitutionRegisterEntry"

    let EuropeanBankingAuthority = _prefixId.prefix "EuropeanBankingAuthority"

    let EuropeanBankingAuthorityRegulator =
        _prefixId.prefix "EuropeanBankingAuthorityRegulator"

    let EuropeanBankingRegulatoryAgencyAndCentralBank =
        _prefixId.prefix "EuropeanBankingRegulatoryAgencyAndCentralBank"

    let EuropeanCentralBank = _prefixId.prefix "EuropeanCentralBank"

    let EuropeanCentralBankHeadquartersAndLegalAddress =
        _prefixId.prefix "EuropeanCentralBankHeadquartersAndLegalAddress"

    let FinancialConductAuthority = _prefixId.prefix "FinancialConductAuthority"

    let FinancialConductAuthorityEntity =
        _prefixId.prefix "FinancialConductAuthorityEntity"

    let FinancialConductAuthorityHeadquartersAndLegalAddress =
        _prefixId.prefix "FinancialConductAuthorityHeadquartersAndLegalAddress"

    let PrudentialRegulatoryAuthority = _prefixId.prefix "PrudentialRegulatoryAuthority"

    let PrudentialRegulatoryAuthorityEntity =
        _prefixId.prefix "PrudentialRegulatoryAuthorityEntity"

    let PrudentialRegulatoryAuthorityHeadquartersAndLegalAddress =
        _prefixId.prefix "PrudentialRegulatoryAuthorityHeadquartersAndLegalAddress"
