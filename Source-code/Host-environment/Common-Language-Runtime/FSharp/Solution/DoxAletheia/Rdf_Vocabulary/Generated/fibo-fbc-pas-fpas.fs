namespace https.spec.edmcouncil.org.fibo.ontology.FBC.ProductsAndServices.FinancialProductsAndServices.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_pas_fpas =
    let _namespace_iri = Namespace_Iri fibo_fbc_pas_fpas |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Financial Products and Services Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_pas_fpas, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:AgencyAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"agency agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AgencyAgreement">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AgencyAgreement</seealso>
    let AgencyAgreement =
        Prefixed_Name(fibo_fbc_pas_fpas, "AgencyAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:AgentForServiceOfProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"agent for service of process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AgentForServiceOfProcess">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AgentForServiceOfProcess</seealso>
    let AgentForServiceOfProcess =
        Prefixed_Name(fibo_fbc_pas_fpas, "AgentForServiceOfProcess") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:AmendedTrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleStage</para>
    ///
    /// labels<para>"amended trade"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AmendedTrade">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AmendedTrade</seealso>
    let AmendedTrade = Prefixed_Name(fibo_fbc_pas_fpas, "AmendedTrade") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:BankAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BankAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BankAccount</seealso>
    let BankAccount = Prefixed_Name(fibo_fbc_pas_fpas, "BankAccount") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Basket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Basket">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Basket</seealso>
    let Basket = Prefixed_Name(fibo_fbc_pas_fpas, "Basket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:BasketConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket constituent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BasketConstituent">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BasketConstituent</seealso>
    let BasketConstituent =
        Prefixed_Name(fibo_fbc_pas_fpas, "BasketConstituent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Broker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"broker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Broker">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Broker</seealso>
    let Broker = Prefixed_Name(fibo_fbc_pas_fpas, "Broker") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:BrokerDealer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"broker-dealer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BrokerDealer">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BrokerDealer</seealso>
    let BrokerDealer = Prefixed_Name(fibo_fbc_pas_fpas, "BrokerDealer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"catalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Catalog">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Catalog</seealso>
    let Catalog = Prefixed_Name(fibo_fbc_pas_fpas, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ClearedTrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleStage</para>
    ///
    /// labels<para>"cleared trade"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ClearedTrade">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ClearedTrade</seealso>
    let ClearedTrade = Prefixed_Name(fibo_fbc_pas_fpas, "ClearedTrade") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ClosedTrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleStage</para>
    ///
    /// labels<para>"closed trade"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ClosedTrade">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ClosedTrade</seealso>
    let ClosedTrade = Prefixed_Name(fibo_fbc_pas_fpas, "ClosedTrade") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ContractLifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract lifecycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycle">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycle</seealso>
    let ContractLifecycle =
        Prefixed_Name(fibo_fbc_pas_fpas, "ContractLifecycle") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ContractLifecycleEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract lifecycle event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleEvent</seealso>
    let ContractLifecycleEvent =
        Prefixed_Name(fibo_fbc_pas_fpas, "ContractLifecycleEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ContractLifecycleEventOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract lifecycle event occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleEventOccurrence">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleEventOccurrence</seealso>
    let ContractLifecycleEventOccurrence =
        Prefixed_Name(fibo_fbc_pas_fpas, "ContractLifecycleEventOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ContractLifecycleOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract lifecycle occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleOccurrence">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleOccurrence</seealso>
    let ContractLifecycleOccurrence =
        Prefixed_Name(fibo_fbc_pas_fpas, "ContractLifecycleOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ContractLifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract lifecycle stage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleStage">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleStage</seealso>
    let ContractLifecycleStage =
        Prefixed_Name(fibo_fbc_pas_fpas, "ContractLifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ContractLifecycleStageOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract lifecycle stage occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleStageOccurrence">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleStageOccurrence</seealso>
    let ContractLifecycleStageOccurrence =
        Prefixed_Name(fibo_fbc_pas_fpas, "ContractLifecycleStageOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Dealer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dealer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Dealer">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Dealer</seealso>
    let Dealer = Prefixed_Name(fibo_fbc_pas_fpas, "Dealer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Exposure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exposure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Exposure">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Exposure</seealso>
    let Exposure = Prefixed_Name(fibo_fbc_pas_fpas, "Exposure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ExposureBearer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exposure bearer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ExposureBearer">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ExposureBearer</seealso>
    let ExposureBearer =
        Prefixed_Name(fibo_fbc_pas_fpas, "ExposureBearer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ExposureSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exposure situation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ExposureSituation">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ExposureSituation</seealso>
    let ExposureSituation =
        Prefixed_Name(fibo_fbc_pas_fpas, "ExposureSituation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:FinancialExposure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial exposure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialExposure">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialExposure</seealso>
    let FinancialExposure =
        Prefixed_Name(fibo_fbc_pas_fpas, "FinancialExposure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:FinancialIntermediationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial intermediation service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialIntermediationService">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialIntermediationService</seealso>
    let FinancialIntermediationService =
        Prefixed_Name(fibo_fbc_pas_fpas, "FinancialIntermediationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:FinancialProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialProduct">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialProduct</seealso>
    let FinancialProduct =
        Prefixed_Name(fibo_fbc_pas_fpas, "FinancialProduct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:FinancialProductCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial product catalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialProductCatalog">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialProductCatalog</seealso>
    let FinancialProductCatalog =
        Prefixed_Name(fibo_fbc_pas_fpas, "FinancialProductCatalog") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:FinancialService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialService">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialService</seealso>
    let FinancialService =
        Prefixed_Name(fibo_fbc_pas_fpas, "FinancialService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial service provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialServiceProvider">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialServiceProvider</seealso>
    let FinancialServiceProvider =
        Prefixed_Name(fibo_fbc_pas_fpas, "FinancialServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Holding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Holding">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Holding</seealso>
    let Holding = Prefixed_Name(fibo_fbc_pas_fpas, "Holding") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:LegalAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/LegalAgent">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/LegalAgent</seealso>
    let LegalAgent = Prefixed_Name(fibo_fbc_pas_fpas, "LegalAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:LicensedAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"licensed agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/LicensedAgent">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/LicensedAgent</seealso>
    let LicensedAgent =
        Prefixed_Name(fibo_fbc_pas_fpas, "LicensedAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:MaturedTrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleStage</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"matured trade"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/MaturedTrade">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/MaturedTrade</seealso>
    let MaturedTrade = Prefixed_Name(fibo_fbc_pas_fpas, "MaturedTrade") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Offeree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"offeree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offeree">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offeree</seealso>
    let Offeree = Prefixed_Name(fibo_fbc_pas_fpas, "Offeree") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Offering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"offering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offering">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offering</seealso>
    let Offering = Prefixed_Name(fibo_fbc_pas_fpas, "Offering") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Offeror</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"offeror"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offeror">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offeror</seealso>
    let Offeror = Prefixed_Name(fibo_fbc_pas_fpas, "Offeror") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:OpenTrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleStage</para>
    ///
    /// labels<para>"open trade"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/OpenTrade">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/OpenTrade</seealso>
    let OpenTrade = Prefixed_Name(fibo_fbc_pas_fpas, "OpenTrade") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:PaymentMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/PaymentMechanism">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/PaymentMechanism</seealso>
    let PaymentMechanism =
        Prefixed_Name(fibo_fbc_pas_fpas, "PaymentMechanism") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Position">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Position</seealso>
    let Position = Prefixed_Name(fibo_fbc_pas_fpas, "Position") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ProductLifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"product lifecycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycle">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycle</seealso>
    let ProductLifecycle =
        Prefixed_Name(fibo_fbc_pas_fpas, "ProductLifecycle") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ProductLifecycleEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"product lifecycle event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleEvent</seealso>
    let ProductLifecycleEvent =
        Prefixed_Name(fibo_fbc_pas_fpas, "ProductLifecycleEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ProductLifecycleEventOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"product lifecycle event occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleEventOccurrence">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleEventOccurrence</seealso>
    let ProductLifecycleEventOccurrence =
        Prefixed_Name(fibo_fbc_pas_fpas, "ProductLifecycleEventOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ProductLifecycleOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"product lifecycle occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleOccurrence">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleOccurrence</seealso>
    let ProductLifecycleOccurrence =
        Prefixed_Name(fibo_fbc_pas_fpas, "ProductLifecycleOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ProductLifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"product lifecycle stage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleStage">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleStage</seealso>
    let ProductLifecycleStage =
        Prefixed_Name(fibo_fbc_pas_fpas, "ProductLifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ProductLifecycleStageOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"product lifecycle stage occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleStageOccurrence">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleStageOccurrence</seealso>
    let ProductLifecycleStageOccurrence =
        Prefixed_Name(fibo_fbc_pas_fpas, "ProductLifecycleStageOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:RegisteredAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registered agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/RegisteredAgent">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/RegisteredAgent</seealso>
    let RegisteredAgent =
        Prefixed_Name(fibo_fbc_pas_fpas, "RegisteredAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:RegulatedCommodity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulated commodity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/RegulatedCommodity">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/RegulatedCommodity</seealso>
    let RegulatedCommodity =
        Prefixed_Name(fibo_fbc_pas_fpas, "RegulatedCommodity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:SettlementTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"settlement terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/SettlementTerms">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/SettlementTerms</seealso>
    let SettlementTerms =
        Prefixed_Name(fibo_fbc_pas_fpas, "SettlementTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:TerminatedTrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleStage</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"terminated trade"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TerminatedTrade">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TerminatedTrade</seealso>
    let TerminatedTrade =
        Prefixed_Name(fibo_fbc_pas_fpas, "TerminatedTrade") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:ThirdPartyAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"third-party agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ThirdPartyAgent">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ThirdPartyAgent</seealso>
    let ThirdPartyAgent =
        Prefixed_Name(fibo_fbc_pas_fpas, "ThirdPartyAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Trade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trade"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Trade">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Trade</seealso>
    let Trade = Prefixed_Name(fibo_fbc_pas_fpas, "Trade") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:TradeIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trade identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeIdentifier</seealso>
    let TradeIdentifier =
        Prefixed_Name(fibo_fbc_pas_fpas, "TradeIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trade lifecycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycle">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycle</seealso>
    let TradeLifecycle =
        Prefixed_Name(fibo_fbc_pas_fpas, "TradeLifecycle") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trade lifecycle event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleEvent</seealso>
    let TradeLifecycleEvent =
        Prefixed_Name(fibo_fbc_pas_fpas, "TradeLifecycleEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleEventOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trade lifecycle event occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleEventOccurrence">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleEventOccurrence</seealso>
    let TradeLifecycleEventOccurrence =
        Prefixed_Name(fibo_fbc_pas_fpas, "TradeLifecycleEventOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trade lifecycle occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleOccurrence">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleOccurrence</seealso>
    let TradeLifecycleOccurrence =
        Prefixed_Name(fibo_fbc_pas_fpas, "TradeLifecycleOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trade lifecycle stage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleStage">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleStage</seealso>
    let TradeLifecycleStage =
        Prefixed_Name(fibo_fbc_pas_fpas, "TradeLifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:TradeLifecycleStageOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trade lifecycle stage occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleStageOccurrence">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleStageOccurrence</seealso>
    let TradeLifecycleStageOccurrence =
        Prefixed_Name(fibo_fbc_pas_fpas, "TradeLifecycleStageOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:Trader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trader"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Trader">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Trader</seealso>
    let Trader = Prefixed_Name(fibo_fbc_pas_fpas, "Trader") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:TradingStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trading strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradingStrategy">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradingStrategy</seealso>
    let TradingStrategy =
        Prefixed_Name(fibo_fbc_pas_fpas, "TradingStrategy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:UniqueTransactionIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unique transaction identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/UniqueTransactionIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/UniqueTransactionIdentifier</seealso>
    let UniqueTransactionIdentifier =
        Prefixed_Name(fibo_fbc_pas_fpas, "UniqueTransactionIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:WeightedBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weighted basket"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/WeightedBasket">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/WeightedBasket</seealso>
    let WeightedBasket =
        Prefixed_Name(fibo_fbc_pas_fpas, "WeightedBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:WeightedBasketConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weighted basket constituent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/WeightedBasketConstituent">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/WeightedBasketConstituent</seealso>
    let WeightedBasketConstituent =
        Prefixed_Name(fibo_fbc_pas_fpas, "WeightedBasketConstituent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:exposesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"exposes in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/exposesIn">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/exposesIn</seealso>
    let exposesIn = Prefixed_Name(fibo_fbc_pas_fpas, "exposesIn") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:facilitates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"facilitates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/facilitates">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/facilitates</seealso>
    let facilitates = Prefixed_Name(fibo_fbc_pas_fpas, "facilitates") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasExposedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exposed party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasExposedParty">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasExposedParty</seealso>
    let hasExposedParty =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasExposedParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasExposureTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exposure to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasExposureTo">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasExposureTo</seealso>
    let hasExposureTo =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasExposureTo") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasGeneratingEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has generating entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasGeneratingEntity">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasGeneratingEntity</seealso>
    let hasGeneratingEntity =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasGeneratingEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasGeneratingEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has generating entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasGeneratingEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasGeneratingEntityIdentifier</seealso>
    let hasGeneratingEntityIdentifier =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasGeneratingEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasLegalAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has registered agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasLegalAgent">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasLegalAgent</seealso>
    let hasLegalAgent =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasLegalAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasNominalNumberOfUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has nominal number of units"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasNominalNumberOfUnits">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasNominalNumberOfUnits</seealso>
    let hasNominalNumberOfUnits =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasNominalNumberOfUnits") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasOffering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has offering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOffering">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOffering</seealso>
    let hasOffering = Prefixed_Name(fibo_fbc_pas_fpas, "hasOffering") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasOfferingAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has offering amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingAmount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingAmount</seealso>
    let hasOfferingAmount =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasOfferingAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasOfferingPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has offering price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingPrice</seealso>
    let hasOfferingPrice =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasOfferingPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasOfferingUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has offering units"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingUnits">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingUnits</seealso>
    let hasOfferingUnits =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasOfferingUnits") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasPaymentMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasPaymentMechanism">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasPaymentMechanism</seealso>
    let hasPaymentMechanism =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasPaymentMechanism") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasSelectingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has selecting party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSelectingParty">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSelectingParty</seealso>
    let hasSelectingParty =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasSelectingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasSelectionCriteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has selection criteria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSelectionCriteria">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSelectionCriteria</seealso>
    let hasSelectionCriteria =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasSelectionCriteria") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasSettlementDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has settlement date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSettlementDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSettlementDate</seealso>
    let hasSettlementDate =
        Prefixed_Name(fibo_fbc_pas_fpas, "hasSettlementDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:hasTradeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has trade date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasTradeDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasTradeDate</seealso>
    let hasTradeDate = Prefixed_Name(fibo_fbc_pas_fpas, "hasTradeDate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:isEmbodiedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is embodied in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isEmbodiedIn">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isEmbodiedIn</seealso>
    let isEmbodiedIn = Prefixed_Name(fibo_fbc_pas_fpas, "isEmbodiedIn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:isExposedPartyIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is exposed party in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isExposedPartyIn">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isExposedPartyIn</seealso>
    let isExposedPartyIn =
        Prefixed_Name(fibo_fbc_pas_fpas, "isExposedPartyIn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:isExposedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is exposed to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isExposedTo">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isExposedTo</seealso>
    let isExposedTo = Prefixed_Name(fibo_fbc_pas_fpas, "isExposedTo") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:isExposureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is exposure of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isExposureOf">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isExposureOf</seealso>
    let isExposureOf = Prefixed_Name(fibo_fbc_pas_fpas, "isExposureOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:isFacilitatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is facilitated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isFacilitatedBy">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isFacilitatedBy</seealso>
    let isFacilitatedBy =
        Prefixed_Name(fibo_fbc_pas_fpas, "isFacilitatedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:isOfferingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is offering of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isOfferingOf">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isOfferingOf</seealso>
    let isOfferingOf = Prefixed_Name(fibo_fbc_pas_fpas, "isOfferingOf") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-fpas:relatesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"relates to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/relatesTo">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/relatesTo</seealso>
    let relatesTo = Prefixed_Name(fibo_fbc_pas_fpas, "relatesTo") |> PrefixedName
