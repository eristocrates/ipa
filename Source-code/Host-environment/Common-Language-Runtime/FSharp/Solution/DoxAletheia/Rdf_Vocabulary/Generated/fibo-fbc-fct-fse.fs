namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.FinancialServicesEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_fse =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_fse |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-fse:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Financial Services Entities Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_fse, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fct-fse:Bank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/Bank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/Bank</seealso>
    let Bank = Prefixed_Name(fibo_fbc_fct_fse, "Bank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:BankHoldingCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bank holding company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankHoldingCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankHoldingCompany</seealso>
    let BankHoldingCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "BankHoldingCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:BankingProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"banking product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankingProduct">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankingProduct</seealso>
    let BankingProduct =
        Prefixed_Name(fibo_fbc_fct_fse, "BankingProduct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:BankingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"banking service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankingService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankingService</seealso>
    let BankingService =
        Prefixed_Name(fibo_fbc_fct_fse, "BankingService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"brokerage firm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BrokerageFirm">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BrokerageFirm</seealso>
    let BrokerageFirm = Prefixed_Name(fibo_fbc_fct_fse, "BrokerageFirm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:BusinessIdentifierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business identifier code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessIdentifierCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessIdentifierCode</seealso>
    let BusinessIdentifierCode =
        Prefixed_Name(fibo_fbc_fct_fse, "BusinessIdentifierCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:BusinessIdentifierCodeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business identifier code scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessIdentifierCodeScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessIdentifierCodeScheme</seealso>
    let BusinessIdentifierCodeScheme =
        Prefixed_Name(fibo_fbc_fct_fse, "BusinessIdentifierCodeScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:BusinessPartyPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business party prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessPartyPrefix">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessPartyPrefix</seealso>
    let BusinessPartyPrefix =
        Prefixed_Name(fibo_fbc_fct_fse, "BusinessPartyPrefix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:BusinessPartySuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business party suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessPartySuffix">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessPartySuffix</seealso>
    let BusinessPartySuffix =
        Prefixed_Name(fibo_fbc_fct_fse, "BusinessPartySuffix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:CentralBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"central bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralBank</seealso>
    let CentralBank = Prefixed_Name(fibo_fbc_fct_fse, "CentralBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:CentralCounterpartyClearingHouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"central counterparty clearing house"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralCounterpartyClearingHouse">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralCounterpartyClearingHouse</seealso>
    let CentralCounterpartyClearingHouse =
        Prefixed_Name(fibo_fbc_fct_fse, "CentralCounterpartyClearingHouse") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:CentralSecuritiesDepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"central securities depository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralSecuritiesDepository">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralSecuritiesDepository</seealso>
    let CentralSecuritiesDepository =
        Prefixed_Name(fibo_fbc_fct_fse, "CentralSecuritiesDepository") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:ClearingBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"clearing bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingBank</seealso>
    let ClearingBank = Prefixed_Name(fibo_fbc_fct_fse, "ClearingBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:ClearingCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"clearing corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingCorporation">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingCorporation</seealso>
    let ClearingCorporation =
        Prefixed_Name(fibo_fbc_fct_fse, "ClearingCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:ClearingHouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"clearing house"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingHouse">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingHouse</seealso>
    let ClearingHouse = Prefixed_Name(fibo_fbc_fct_fse, "ClearingHouse") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:ClearingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"clearing service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingService</seealso>
    let ClearingService =
        Prefixed_Name(fibo_fbc_fct_fse, "ClearingService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:CommercialBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commercial bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommercialBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommercialBank</seealso>
    let CommercialBank =
        Prefixed_Name(fibo_fbc_fct_fse, "CommercialBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:CommercialFinanceCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commercial finance company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommercialFinanceCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommercialFinanceCompany</seealso>
    let CommercialFinanceCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "CommercialFinanceCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity trading advisor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommodityTradingAdvisor">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommodityTradingAdvisor</seealso>
    let CommodityTradingAdvisor =
        Prefixed_Name(fibo_fbc_fct_fse, "CommodityTradingAdvisor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:ConsumerFinanceCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consumer finance company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ConsumerFinanceCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ConsumerFinanceCompany</seealso>
    let ConsumerFinanceCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "ConsumerFinanceCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:ContractualSavingsInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual savings institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ContractualSavingsInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ContractualSavingsInstitution</seealso>
    let ContractualSavingsInstitution =
        Prefixed_Name(fibo_fbc_fct_fse, "ContractualSavingsInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:CreditUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit union"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CreditUnion">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CreditUnion</seealso>
    let CreditUnion = Prefixed_Name(fibo_fbc_fct_fse, "CreditUnion") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:DataProcessingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data processing service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DataProcessingService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DataProcessingService</seealso>
    let DataProcessingService =
        Prefixed_Name(fibo_fbc_fct_fse, "DataProcessingService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:DataProcessingServicer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data processing servicer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DataProcessingServicer">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DataProcessingServicer</seealso>
    let DataProcessingServicer =
        Prefixed_Name(fibo_fbc_fct_fse, "DataProcessingServicer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:DepositoryInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"depository institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DepositoryInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DepositoryInstitution</seealso>
    let DepositoryInstitution =
        Prefixed_Name(fibo_fbc_fct_fse, "DepositoryInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:DevelopmentBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"development bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DevelopmentBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DevelopmentBank</seealso>
    let DevelopmentBank =
        Prefixed_Name(fibo_fbc_fct_fse, "DevelopmentBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:ElectronicFundsTransferService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"electronic funds transfer service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ElectronicFundsTransferService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ElectronicFundsTransferService</seealso>
    let ElectronicFundsTransferService =
        Prefixed_Name(fibo_fbc_fct_fse, "ElectronicFundsTransferService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:FaceAmountCertificateCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"face amount certificate company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FaceAmountCertificateCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FaceAmountCertificateCompany</seealso>
    let FaceAmountCertificateCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "FaceAmountCertificateCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:FinanceCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"finance company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinanceCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinanceCompany</seealso>
    let FinanceCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "FinanceCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:FinancialInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialInstitution</seealso>
    let FinancialInstitution =
        Prefixed_Name(fibo_fbc_fct_fse, "FinancialInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:FinancialServiceProviderIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial service provider identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialServiceProviderIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialServiceProviderIdentifier</seealso>
    let FinancialServiceProviderIdentifier =
        Prefixed_Name(fibo_fbc_fct_fse, "FinancialServiceProviderIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:FinancialServiceProviderIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial service provider identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialServiceProviderIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialServiceProviderIdentifierScheme</seealso>
    let FinancialServiceProviderIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_fse, "FinancialServiceProviderIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:FuturesCommissionMerchant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"futures commission merchant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FuturesCommissionMerchant">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FuturesCommissionMerchant</seealso>
    let FuturesCommissionMerchant =
        Prefixed_Name(fibo_fbc_fct_fse, "FuturesCommissionMerchant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:HoldingCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"holding company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/HoldingCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/HoldingCompany</seealso>
    let HoldingCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "HoldingCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:InsuranceCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"insurance company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InsuranceCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InsuranceCompany</seealso>
    let InsuranceCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "InsuranceCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:InsuranceService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"insurance service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InsuranceService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InsuranceService</seealso>
    let InsuranceService =
        Prefixed_Name(fibo_fbc_fct_fse, "InsuranceService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:InvestmentBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investment bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentBank</seealso>
    let InvestmentBank =
        Prefixed_Name(fibo_fbc_fct_fse, "InvestmentBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:InvestmentCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investment company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentCompany</seealso>
    let InvestmentCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "InvestmentCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:InvestmentService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investment service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentService</seealso>
    let InvestmentService =
        Prefixed_Name(fibo_fbc_fct_fse, "InvestmentService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:ManagementCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"management company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ManagementCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ManagementCompany</seealso>
    let ManagementCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "ManagementCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:MerchantService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"merchant service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MerchantService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MerchantService</seealso>
    let MerchantService =
        Prefixed_Name(fibo_fbc_fct_fse, "MerchantService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:MonetaryAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"monetary authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MonetaryAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MonetaryAuthority</seealso>
    let MonetaryAuthority =
        Prefixed_Name(fibo_fbc_fct_fse, "MonetaryAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:MoneyServicesBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"money services business"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MoneyServicesBusiness">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MoneyServicesBusiness</seealso>
    let MoneyServicesBusiness =
        Prefixed_Name(fibo_fbc_fct_fse, "MoneyServicesBusiness") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:MortgageCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mortgage company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MortgageCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MortgageCompany</seealso>
    let MortgageCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "MortgageCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:NonDepositoryInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-depository institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/NonDepositoryInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/NonDepositoryInstitution</seealso>
    let NonDepositoryInstitution =
        Prefixed_Name(fibo_fbc_fct_fse, "NonDepositoryInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:PaymentService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PaymentService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PaymentService</seealso>
    let PaymentService =
        Prefixed_Name(fibo_fbc_fct_fse, "PaymentService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:PayrollService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payroll service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PayrollService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PayrollService</seealso>
    let PayrollService =
        Prefixed_Name(fibo_fbc_fct_fse, "PayrollService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:PrincipalUnderwriter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"principal underwriter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PrincipalUnderwriter">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PrincipalUnderwriter</seealso>
    let PrincipalUnderwriter =
        Prefixed_Name(fibo_fbc_fct_fse, "PrincipalUnderwriter") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:RegisteredInvestmentAdvisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registered investment advisor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/RegisteredInvestmentAdvisor">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/RegisteredInvestmentAdvisor</seealso>
    let RegisteredInvestmentAdvisor =
        Prefixed_Name(fibo_fbc_fct_fse, "RegisteredInvestmentAdvisor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:RiskPoolingInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"risk pooling institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/RiskPoolingInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/RiskPoolingInstitution</seealso>
    let RiskPoolingInstitution =
        Prefixed_Name(fibo_fbc_fct_fse, "RiskPoolingInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:SalesFinanceCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sales finance company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SalesFinanceCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SalesFinanceCompany</seealso>
    let SalesFinanceCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "SalesFinanceCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:SavingsAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"savings association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SavingsAssociation">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SavingsAssociation</seealso>
    let SavingsAssociation =
        Prefixed_Name(fibo_fbc_fct_fse, "SavingsAssociation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:SelfRegulatingOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"self-regulating organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SelfRegulatingOrganization">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SelfRegulatingOrganization</seealso>
    let SelfRegulatingOrganization =
        Prefixed_Name(fibo_fbc_fct_fse, "SelfRegulatingOrganization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:TrustCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trust company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/TrustCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/TrustCompany</seealso>
    let TrustCompany = Prefixed_Name(fibo_fbc_fct_fse, "TrustCompany") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fct-fse:Underwriter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"underwriter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/Underwriter">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/Underwriter</seealso>
    let Underwriter = Prefixed_Name(fibo_fbc_fct_fse, "Underwriter") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:UnderwritingArrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"underwriting arrangement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/UnderwritingArrangement">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/UnderwritingArrangement</seealso>
    let UnderwritingArrangement =
        Prefixed_Name(fibo_fbc_fct_fse, "UnderwritingArrangement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:UnitInvestmentTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unit investment trust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/UnitInvestmentTrust">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/UnitInvestmentTrust</seealso>
    let UnitInvestmentTrust =
        Prefixed_Name(fibo_fbc_fct_fse, "UnitInvestmentTrust") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:WealthManagementService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"wealth management service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/WealthManagementService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/WealthManagementService</seealso>
    let WealthManagementService =
        Prefixed_Name(fibo_fbc_fct_fse, "WealthManagementService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:hasDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateEstablished</seealso>
    let hasDateEstablished =
        Prefixed_Name(fibo_fbc_fct_fse, "hasDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:hasDateEstablishmentTerminated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has date establishment terminated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateEstablishmentTerminated">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateEstablishmentTerminated</seealso>
    let hasDateEstablishmentTerminated =
        Prefixed_Name(fibo_fbc_fct_fse, "hasDateEstablishmentTerminated") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:hasDateInsured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has date insured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateInsured">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateInsured</seealso>
    let hasDateInsured =
        Prefixed_Name(fibo_fbc_fct_fse, "hasDateInsured") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:hasPortfolioCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has portfolio company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasPortfolioCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasPortfolioCompany</seealso>
    let hasPortfolioCompany =
        Prefixed_Name(fibo_fbc_fct_fse, "hasPortfolioCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:isPortfolioCompanyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is portfolio company of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/isPortfolioCompanyOf">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/isPortfolioCompanyOf</seealso>
    let isPortfolioCompanyOf =
        Prefixed_Name(fibo_fbc_fct_fse, "isPortfolioCompanyOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-fse:regulatesSupplyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"regulates supply of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/regulatesSupplyOf">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/regulatesSupplyOf</seealso>
    let regulatesSupplyOf =
        Prefixed_Name(fibo_fbc_fct_fse, "regulatesSupplyOf") |> PrefixedName
