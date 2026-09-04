#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-fse`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/" "fibo-fbc-fct-fse"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : bank^^xsd:string</para>
    ///   <para>skos:definition : depository institution, usually a corporation, that accepts deposits, makes loans, pays checks, and performs related services, for individual members of the public, businesses or other organizations^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Banking Terms, Sixth Edition, 2012^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/Bank">fibo-fbc-fct-fse:Bank</a>
    /// </summary>
    let Bank = _prefixId.prefix "Bank"
    /// <summary>
    ///   <para>rdfs:label : bank holding company^^xsd:string</para>
    ///   <para>skos:definition : any company that owns and/or has direct or indirect control of one or more banks; BHCs may also own nonbanking subsidiaries such as broker-dealers and asset managers^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Office of Financial Research (OFR) Annual Report, 2012, Glossary^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A bank holding company may also own another bank holding company, which in turn owns or controls a bank; the company at the top of the ownership chain is called the top holder.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankHoldingCompany">fibo-fbc-fct-fse:BankHoldingCompany</a>
    /// </summary>
    let BankHoldingCompany = _prefixId.prefix "BankHoldingCompany"
    /// <summary>
    ///   <para>rdfs:label : banking product^^xsd:string</para>
    ///   <para>skos:definition : product provided to consumers and businesses by a depository institution^^xsd:string</para>
    ///   <para>skos:example : Examples include checking account, savings account, certificate of deposit, debit or pre-paid card, or credit card.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankingProduct">fibo-fbc-fct-fse:BankingProduct</a>
    /// </summary>
    let BankingProduct = _prefixId.prefix "BankingProduct"
    /// <summary>
    ///   <para>rdfs:label : banking service^^xsd:string</para>
    ///   <para>skos:definition : financial service offered by a depository institution^^xsd:string</para>
    ///   <para>skos:example : Examples include cash management service, foreign exchange service, lending or credit service, investment service, insurance service, merchant service, payroll service, and the like.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankingService">fibo-fbc-fct-fse:BankingService</a>
    /// </summary>
    let BankingService = _prefixId.prefix "BankingService"
    /// <summary>
    ///   <para>rdfs:label : brokerage firm^^xsd:string</para>
    ///   <para>skos:definition : firm in the business of buying and selling securities, operating as both a broker and a dealer, depending on the transaction^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : Office of Financial Research (OFR) Annual Report, 2012, Glossary^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.worldbank.org/en/publication/gfdr/gfdr-2016/background/nonbank-financial-institution^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The term broker-dealer is used in U.S. securities regulation parlance to describe stock brokerages, because most of them act as both agents and principals. A brokerage acts as a broker (or agent) when it executes orders on behalf of clients, whereas it acts as a dealer (or principal) when it trades for its own account.^^xsd:string</para>
    ///   <para>cmns-av:synonym : market maker^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BrokerageFirm">fibo-fbc-fct-fse:BrokerageFirm</a>
    /// </summary>
    let BrokerageFirm = _prefixId.prefix "BrokerageFirm"
    /// <summary>
    ///   <para>rdfs:label : business identifier code^^xsd:string</para>
    ///   <para>skos:definition : international identifier for financial and non-financial institutions used to facilitate automated processing of information for financial services^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : BIC^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 9362:2014 Banking -- Banking telecommunication messages -- Business identifier code (BIC)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The BIC is used for addressing messages, routing business transactions and identifying business parties. Note that the use of OrganizationSubUnitIdentifier in FIBO corresponds to the Branch Code in the SWIFT scheme.^^xsd:string</para>
    ///   <para>cmns-av:synonym : SWIFT ID^^xsd:stringcmns-av:synonym : SWIFT code^^xsd:stringcmns-av:synonym : SWIFT-BIC^^xsd:stringcmns-av:synonym : bank identifier code^^xsd:stringcmns-av:synonym : business entity identifier^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessIdentifierCode">fibo-fbc-fct-fse:BusinessIdentifierCode</a>
    /// </summary>
    let BusinessIdentifierCode = _prefixId.prefix "BusinessIdentifierCode"
    /// <summary>
    ///   <para>rdfs:label : business identifier code scheme^^xsd:string</para>
    ///   <para>skos:definition : scheme that specifies the elements of a unique business identifier code (BIC) scheme to identify financial and non-financial institutions used to facilitate automated processing of information for financial services^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 9362:2014 Banking -- Banking telecommunication messages -- Business identifier code (BIC)^^xsd:stringcmns-av:adaptedFrom : https://www.iso.org/standard/60390.html^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessIdentifierCodeScheme">fibo-fbc-fct-fse:BusinessIdentifierCodeScheme</a>
    /// </summary>
    let BusinessIdentifierCodeScheme = _prefixId.prefix "BusinessIdentifierCodeScheme"
    /// <summary>
    ///   <para>rdfs:label : business party prefix^^xsd:string</para>
    ///   <para>skos:definition : four-character (4 alphanumeric) code associated with an organization for the purposes of banking telecommunications^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 9362:2014 Banking -- Banking telecommunication messages -- Business identifier code (BIC)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For new BIC registration by an organization already identified with a BIC or an affiliated organization [after the transition period ending November 2018], SWIFT will still reserve the usage of an existing party prefix to these organizations. This legacy rule will be reserved to existing BIC owners. If they wish to preserve this value, no other organization will be allowed to use the same code^^xsd:stringcmns-av:explanatoryNote : For new BIC registration from an organization not yet identified by a BIC, the party prefix will be allocated at the discretion of the RA. The code will not have a mnemonic or acronym value anymore.^^xsd:string</para>
    ///   <para>cmns-av:synonym : bank code^^xsd:stringcmns-av:synonym : institution code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessPartyPrefix">fibo-fbc-fct-fse:BusinessPartyPrefix</a>
    /// </summary>
    let BusinessPartyPrefix = _prefixId.prefix "BusinessPartyPrefix"
    /// <summary>
    ///   <para>rdfs:label : business party suffix^^xsd:string</para>
    ///   <para>skos:definition : two-character (2 alphanumeric) code associated with the organization for the purposes of banking telecommunications^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 9362:2014 Banking -- Banking telecommunication messages -- Business identifier code (BIC)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the prior version of the standard, position 7 of the BIC determined the location of the BIC in a particular country. In a country spanning over multiple time zones, each character may have been used to define a different time zone. If an organization moved location to a different time zone within the same country, the existing BIC would normally have been deleted and replaced by a new BIC with the appropriate location code.^^xsd:stringcmns-av:explanatoryNote : With the revision of the standard [and transition period ending November 2018], the location code has been re-defined as a 'party suffix' without any specific meaning. A new reference data attribute has been introduced in the SWIFTRef directories to indicate where the institution is located and to which time zone it refers.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessPartySuffix">fibo-fbc-fct-fse:BusinessPartySuffix</a>
    /// </summary>
    let BusinessPartySuffix = _prefixId.prefix "BusinessPartySuffix"
    /// <summary>
    ///   <para>rdfs:label : central bank^^xsd:string</para>
    ///   <para>skos:definition : financial institution that is the monetary authority and major regulatory bank for a country (or group of countries)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Its functions include issuing and managing the country's currency, controlling monetary policy and supervising money market operations, managing exchange and gold reserves, acting as lender of last resort to commercial banks, and providing banking services to the government. Central banks are state-controlled but are increasingly being given an independent status to insulate them from partisan politics.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralBank">fibo-fbc-fct-fse:CentralBank</a>
    /// </summary>
    let CentralBank = _prefixId.prefix "CentralBank"

    /// <summary>
    ///   <para>rdfs:label : central counterparty clearing house^^xsd:string</para>
    ///   <para>skos:definition : clearing house that helps facilitate trading in derivatives and equities markets^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CCP^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : These clearing houses are often operated by the major banks in the country. The house's prime responsibility is to provide efficiency and stability to the financial markets that they operate in.
    ///
    /// There are two main processes that are carried out by CCPs: clearing and settlement of market transactions. Clearing relates to identifying the obligations of both parties on either side of a transaction. Settlement occurs when the final transfer of securities and funds occur.
    ///
    /// CCPs benefit both parties in a transaction because they bear most of the credit risk. If two individuals deal with one another, the buyer bears the credit risk of the seller, and vice versa. When a CCP is used the credit risk that is held against both buyer and seller is coming from the CCP, which in all likelihood is much less than in the previous situation.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralCounterpartyClearingHouse">fibo-fbc-fct-fse:CentralCounterpartyClearingHouse</a>
    /// </summary>
    let CentralCounterpartyClearingHouse =
        _prefixId.prefix "CentralCounterpartyClearingHouse"

    /// <summary>
    ///   <para>rdfs:label : central securities depository^^xsd:string</para>
    ///   <para>skos:definition : functional entity that provides a central point for depositing financial instruments ('securities'), for example, bonds and shares^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CSD^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://ecsda.eu/facts/faq^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : CSDs' clients are typically financial institutions themselves (such as custodian banks and brokers) rather than individual investors.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralSecuritiesDepository">fibo-fbc-fct-fse:CentralSecuritiesDepository</a>
    /// </summary>
    let CentralSecuritiesDepository = _prefixId.prefix "CentralSecuritiesDepository"
    /// <summary>
    ///   <para>rdfs:label : clearing bank^^xsd:string</para>
    ///   <para>skos:definition : commercial bank that facilitates payment and settlement of financial transactions, such as check clearing or facilitating trades between the sellers and buyers of securities or other financial instruments or contracts^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : Office of Financial Research (OFR) Annual Report, 2012, Glossary^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingBank">fibo-fbc-fct-fse:ClearingBank</a>
    /// </summary>
    let ClearingBank = _prefixId.prefix "ClearingBank"
    /// <summary>
    ///   <para>rdfs:label : clearing corporation^^xsd:string</para>
    ///   <para>skos:definition : clearing house that is organized as a corporation^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingCorporation">fibo-fbc-fct-fse:ClearingCorporation</a>
    /// </summary>
    let ClearingCorporation = _prefixId.prefix "ClearingCorporation"
    /// <summary>
    ///   <para>rdfs:label : clearing house^^xsd:string</para>
    ///   <para>skos:definition : financial service provider that is exchange affiliated and provides clearing services, including the validation, delivery, and settlement of financial transactions, for financial intermediaries^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingHouse">fibo-fbc-fct-fse:ClearingHouse</a>
    /// </summary>
    let ClearingHouse = _prefixId.prefix "ClearingHouse"
    /// <summary>
    ///   <para>rdfs:label : clearing service^^xsd:string</para>
    ///   <para>skos:definition : service provided on behalf of an institutional market participant by a clearing services provider following a trade that finalizes the transfer of security ownership^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : EDM Council / Quarule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingService">fibo-fbc-fct-fse:ClearingService</a>
    /// </summary>
    let ClearingService = _prefixId.prefix "ClearingService"
    /// <summary>
    ///   <para>rdfs:label : commercial bank^^xsd:string</para>
    ///   <para>skos:definition : depository institution that engages in various financial services, such as accepting deposits and making loans^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A commercial bank is a financial institution that is owned by stockholders, operates for a profit, and engages in various lending activities. Commercial banks provide services, such as accepting deposits, giving business loans and auto loans, mortgage lending, and basic investment products like savings accounts and certificates of deposit.^^xsd:stringcmns-av:explanatoryNote : The traditional commercial bank is a brick and mortar institution with tellers, safe deposit boxes, vaults and ATMs. However, some commercial banks do not have any physical branches and require consumers to complete all transactions by phone or Internet. In exchange, they generally pay higher interest rates on investments and deposits, and charge lower fees.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommercialBank">fibo-fbc-fct-fse:CommercialBank</a>
    /// </summary>
    let CommercialBank = _prefixId.prefix "CommercialBank"
    /// <summary>
    ///   <para>rdfs:label : commercial finance company^^xsd:string</para>
    ///   <para>skos:definition : finance company that makes loans to manufacturers and wholesalers, secured by accounts receivable, inventories, and equipment^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <para>cmns-av:synonym : commercial credit company^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommercialFinanceCompany">fibo-fbc-fct-fse:CommercialFinanceCompany</a>
    /// </summary>
    let CommercialFinanceCompany = _prefixId.prefix "CommercialFinanceCompany"
    /// <summary>
    ///   <para>rdfs:label : commodity trading advisor^^xsd:string</para>
    ///   <para>skos:definition : party that directly or indirectly advises others as to the value or advisability of buying or selling futures contracts or options^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CTA^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Indirect advice includes exercising trading authority over a customer's account. In the U.S., registered CTAs are registered with the Commodities Futures Trading Commission (CFTC) and are generally required to be members of the National Futures Association (NFA).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommodityTradingAdvisor">fibo-fbc-fct-fse:CommodityTradingAdvisor</a>
    /// </summary>
    let CommodityTradingAdvisor = _prefixId.prefix "CommodityTradingAdvisor"
    /// <summary>
    ///   <para>rdfs:label : consumer finance company^^xsd:string</para>
    ///   <para>skos:definition : finance company that lends to individuals under the small loans laws of the jurisdiction in which they operate^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <para>cmns-av:synonym : direct loan company^^xsd:stringcmns-av:synonym : small loan company^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ConsumerFinanceCompany">fibo-fbc-fct-fse:ConsumerFinanceCompany</a>
    /// </summary>
    let ConsumerFinanceCompany = _prefixId.prefix "ConsumerFinanceCompany"
    /// <summary>
    ///   <para>rdfs:label : contractual savings institution^^xsd:string</para>
    ///   <para>skos:definition : financial institution that provides the opportunity for individuals to invest in collective investment vehicles in a fiduciary rather than a principle role^^xsd:string</para>
    ///   <para>skos:example : Example institutional investors include banks, insurance companies, mutual funds, pension funds, and other similar large funds.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.worldbank.org/en/publication/gfdr/gfdr-2016/background/nonbank-financial-institution^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Collective investment vehicles invest the pooled resources of the individuals and firms into numerous equity, debt, and derivatives promises. The individual, however, holds equity in the CIV itself rather what the CIV invests in specifically. The two most popular examples of contractual savings institutions are mutual funds and private pension plans.^^xsd:stringcmns-av:explanatoryNote : Typically more than 70 percent of the daily trading on the New York Stock Exchange is conducted on behalf of institutional investors.^^xsd:string</para>
    ///   <para>cmns-av:synonym : institutional investment firmcmns-av:synonym : institutional investorcmns-av:synonym : investisseur institutionnel</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ContractualSavingsInstitution">fibo-fbc-fct-fse:ContractualSavingsInstitution</a>
    /// </summary>
    let ContractualSavingsInstitution = _prefixId.prefix "ContractualSavingsInstitution"
    /// <summary>
    ///   <para>rdfs:label : credit union^^xsd:string</para>
    ///   <para>skos:definition : not-for-profit depository institution that makes personal loans and offers other consumer banking services, organized for the purpose of promoting thrift among its members and creating a source of credit for provident or productive purposes^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CreditUnion">fibo-fbc-fct-fse:CreditUnion</a>
    /// </summary>
    let CreditUnion = _prefixId.prefix "CreditUnion"
    /// <summary>
    ///   <para>rdfs:label : data processing service^^xsd:string</para>
    ///   <para>skos:definition : financial service offered by an entity primarily engaged in providing infrastructure for hosting or data processing services^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DataProcessingService">fibo-fbc-fct-fse:DataProcessingService</a>
    /// </summary>
    let DataProcessingService = _prefixId.prefix "DataProcessingService"
    /// <summary>
    ///   <para>rdfs:label : data processing servicer^^xsd:string</para>
    ///   <para>skos:definition : finance services provider primarily engaged in providing infrastructure for hosting or data processing services^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : These establishments may provide specialized hosting activities, such as web hosting, streaming services or application hosting, provide application service provisioning, or may provide general time-share mainframe facilities to clients. Data processing establishments provide complete processing and specialized reports from data supplied by clients or provide automated data processing and data entry services.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DataProcessingServicer">fibo-fbc-fct-fse:DataProcessingServicer</a>
    /// </summary>
    let DataProcessingServicer = _prefixId.prefix "DataProcessingServicer"
    /// <summary>
    ///   <para>rdfs:label : depository institution^^xsd:string</para>
    ///   <para>skos:definition : any financial institution engaged in the business of receiving demand deposits from the public or other institutions^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : 12 U.S. Code Section 1813 - Definitions, see, for example, http://www.law.cornell.edu/uscode/text/12/1813^^xsd:stringcmns-av:adaptedFrom : https://www.fdic.gov/regulations/laws/rules/1000-400.html#fdic1000sec.3a^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DepositoryInstitution">fibo-fbc-fct-fse:DepositoryInstitution</a>
    /// </summary>
    let DepositoryInstitution = _prefixId.prefix "DepositoryInstitution"
    /// <summary>
    ///   <para>rdfs:label : development bank^^xsd:string</para>
    ///   <para>skos:definition : national or regional financial institution designed to provide medium- and long-term capital for productive investment, often accompanied by technical assistance, in poor countries^^xsd:string</para>
    ///   <para>cmns-av:synonym : development finance company (DFC)^^xsd:stringcmns-av:synonym : development financial institution (DFI)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DevelopmentBank">fibo-fbc-fct-fse:DevelopmentBank</a>
    /// </summary>
    let DevelopmentBank = _prefixId.prefix "DevelopmentBank"

    /// <summary>
    ///   <para>rdfs:label : electronic funds transfer service^^xsd:string</para>
    ///   <para>skos:definition : service involving any transfer of funds other than a transaction involving a paper instrument, that is initiated through an electronic terminal, telephone, or computer and that orders or authorizes a financial institution to debit or credit an account^^xsd:string</para>
    ///   <para>skos:example : EFT services include transfers through automated teller machines, point-of-sale terminals, automated clearinghouse systems, telephone bill-payment plans in which periodic or recurring transfers are contemplated, and remote banking programs.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : EFT^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <para>cmns-av:synonym : wire transfer service^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ElectronicFundsTransferService">fibo-fbc-fct-fse:ElectronicFundsTransferService</a>
    /// </summary>
    let ElectronicFundsTransferService =
        _prefixId.prefix "ElectronicFundsTransferService"

    /// <summary>
    ///   <para>rdfs:label : face amount certificate company^^xsd:string</para>
    ///   <para>skos:definition : investment company which is engaged or proposes to engage in the business of issuing face-amount certificates of the installment type, or which has been engaged in such business and has any such certificate outstanding^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : Section 4, definition of investment companies, Investment Company Act of 1940 as amended and approved as of 3 January 2012, see https://www.sec.gov/about/laws/ica40.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An investor may enter into a contract with an issuer of a face amount certificate to contract to receive a stated or fixed amount of money (the face amount) at a stated date in the future. In exchange for this future sum, the investor must deposit an agreed lump sum or make scheduled installment payments over time. Face amount certificates are rarely issued these days, as most of the tax advantages that the investment once offered have been lost through changes in the tax laws.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FaceAmountCertificateCompany">fibo-fbc-fct-fse:FaceAmountCertificateCompany</a>
    /// </summary>
    let FaceAmountCertificateCompany = _prefixId.prefix "FaceAmountCertificateCompany"
    /// <summary>
    ///   <para>rdfs:label : finance company^^xsd:string</para>
    ///   <para>skos:definition : financial intermediary in the business of making loans that obtains its financing from banks, institutions, and other money market sources rather than from deposits^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinanceCompany">fibo-fbc-fct-fse:FinanceCompany</a>
    /// </summary>
    let FinanceCompany = _prefixId.prefix "FinanceCompany"
    /// <summary>
    ///   <para>rdfs:label : financial institution^^xsd:string</para>
    ///   <para>skos:definition : financial service provider identified as either a government agency or privately owned entity that collects funds from the public and from other institutions, and invests those funds in financial assets, such as loans, securities, bank deposits, and income-generating property^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Banking Terms, Sixth Edition, 2012^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Financial institutions are differentiated by the way they obtain and invest funds. Depository institutions accept public deposits, which are insured by the government against loss, and channel those deposits into lending activities. Non-depository institutions, such as brokerage firms, life insurance companies, pension funds, and investment companies, fund their investment activities directly from financial markets by selling securities to the public or by selling insurance policies, in the case of insurance companies.^^xsd:string</para>
    ///   <para>cmns-av:synonym : financial intermediary^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialInstitution">fibo-fbc-fct-fse:FinancialInstitution</a>
    /// </summary>
    let FinancialInstitution = _prefixId.prefix "FinancialInstitution"

    /// <summary>
    ///   <para>rdfs:label : financial service provider identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier that is officially allocated to a financial service provider based on a function that they provide, typically in a jurisdiction over which a regulatory agency has some jurisdiction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialServiceProviderIdentifier">fibo-fbc-fct-fse:FinancialServiceProviderIdentifier</a>
    /// </summary>
    let FinancialServiceProviderIdentifier =
        _prefixId.prefix "FinancialServiceProviderIdentifier"

    /// <summary>
    ///   <para>rdfs:label : financial service provider identifier scheme^^xsd:string</para>
    ///   <para>skos:definition : scheme that defines the financial service provider identifier per the issuing registration authority or regulatory agency^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialServiceProviderIdentifierScheme">fibo-fbc-fct-fse:FinancialServiceProviderIdentifierScheme</a>
    /// </summary>
    let FinancialServiceProviderIdentifierScheme =
        _prefixId.prefix "FinancialServiceProviderIdentifierScheme"

    /// <summary>
    ///   <para>rdfs:label : futures commission merchant^^xsd:string</para>
    ///   <para>skos:definition : party that does both of the following: (1) solicits or accepts orders to buy or sell futures contracts, options on futures, retail off-exchange forex contracts, or swaps and (2) accepts money or other assets from customers to support such orders^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : FCM^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : National Futures Association^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FuturesCommissionMerchant">fibo-fbc-fct-fse:FuturesCommissionMerchant</a>
    /// </summary>
    let FuturesCommissionMerchant = _prefixId.prefix "FuturesCommissionMerchant"
    /// <summary>
    ///   <para>rdfs:label : holding company^^xsd:string</para>
    ///   <para>skos:definition : business entity established to own stock in another company, typically to own enough voting shares to have some level of control over that company's policies and management^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Holding companies protect their owners from losses to some degree, protecting assets, for example, in case of bankruptcy. They can also be set up to own property such as real estate, patents, trademarks, stocks and other assets to limit financial and legal liability^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/HoldingCompany">fibo-fbc-fct-fse:HoldingCompany</a>
    /// </summary>
    let HoldingCompany = _prefixId.prefix "HoldingCompany"
    /// <summary>
    ///   <para>rdfs:label : insurance company^^xsd:string</para>
    ///   <para>skos:definition : non-depository institution whose primary and predominant business activity is the writing of insurance or the reinsuring of risks underwritten by insurance companies, and that provides compensation based on the happening of at least one contingency^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.ffiec.gov/nicpubweb/Content/HELP/Institution%20Type%20Description.htm^^xsd:anyURIcmns-av:adaptedFrom : https://www.sec.gov/about/laws/ica40.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : In the US, insurance companies are subject to supervision by the insurance commissioner or a similar official or agency of a State; or any receiver or similar official or any liquidating agent for such a company, in his capacity as such. Common forms of insurance include life, property and casualty, and health insurance. In addition to insuring against hazards, many insurance companies also sell investments or investment-like products. The most prevalent investment products offered by insurers are annuities and life insurance policies that also feature investment elements.
    ///
    /// A number of insurance companies operate brokerage arms that trade securities on behalf of clients.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InsuranceCompany">fibo-fbc-fct-fse:InsuranceCompany</a>
    /// </summary>
    let InsuranceCompany = _prefixId.prefix "InsuranceCompany"
    /// <summary>
    ///   <para>rdfs:label : insurance service^^xsd:string</para>
    ///   <para>skos:definition : financial service in which the insurer promises to provide compensation for specific potential future losses in exchange for a periodic payment^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Insurance providers invest the compensation they receive in order to make a profit. In general, insurance transfers risk from individuals or organizations to a larger pool of individuals or organizations that are better able to mitigate that risk.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InsuranceService">fibo-fbc-fct-fse:InsuranceService</a>
    /// </summary>
    let InsuranceService = _prefixId.prefix "InsuranceService"
    /// <summary>
    ///   <para>rdfs:label : investment bank^^xsd:string</para>
    ///   <para>skos:definition : financial service provider that acts as an underwriter or agent that serves as intermediary between the issuer of securities and the investing public^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Major investment banks include Barclays, BofA Merrill Lynch, Warburgs, Goldman Sachs, Deutsche Bank, JP Morgan, Morgan Stanley, Salomon Brothers, UBS, Credit Suisse, Citibank and Lazard. Some investment banks specialize in particular industry sectors. Many investment banks also have retail operations that serve small, individual customers.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentBank">fibo-fbc-fct-fse:InvestmentBank</a>
    /// </summary>
    let InvestmentBank = _prefixId.prefix "InvestmentBank"
    /// <summary>
    ///   <para>rdfs:label : investment company^^xsd:string</para>
    ///   <para>skos:definition : any issuer which: (a) is or holds itself out as being engaged primarily, or proposes to engage primarily, in the business of investing, reinvesting, or trading in securities; (b) is engaged or proposes to engage in the business of issuing face-amount certificates of the installment type, or has been engaged in such business and has any such certificate outstanding; or (c) is engaged or proposes to engage in the business of investing, reinvesting, owning, holding, or trading in securities, and owns or proposes to acquire investment securities having a value exceeding 40 per centum of the value of such issuer&amp;apos;s total assets (exclusive of Government securities and cash items) on an unconsolidated basis^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : Section 3a of the Investment Company Act of 1940 as amended in January, 2012, https://www.sec.gov/about/laws/ica40.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An investment company is organized as either a corporation or as a trust. Individual investors' money is then pooled together in a single account and used to purchase securities that will have the greatest chance of helping the investment company reach its objectives. All investors jointly own the portfolio that is created through these pooled funds, and each investor has an undivided interest in the securities.^^xsd:stringcmns-av:explanatoryNote : In the US, all investment company offerings are subject to the Securities Act of 1933, which requires the investment company to register with the Securities Exchange Commission (SEC) and to give all purchasers a prospectus. Investment companies are also subject to the Investment Company Act of 1940, which sets forth guidelines on how investment companies must operate.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentCompany">fibo-fbc-fct-fse:InvestmentCompany</a>
    /// </summary>
    let InvestmentCompany = _prefixId.prefix "InvestmentCompany"
    /// <summary>
    ///   <para>rdfs:label : investment service^^xsd:string</para>
    ///   <para>skos:definition : financial service designed to assist investors in using capital to create more money, either through income-producing vehicles or through more risk-oriented ventures to result in capital gains, including but not limited to providing investment advice, asset and portfolio management, and brokerage services^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentService">fibo-fbc-fct-fse:InvestmentService</a>
    /// </summary>
    let InvestmentService = _prefixId.prefix "InvestmentService"
    /// <summary>
    ///   <para>rdfs:label : management company^^xsd:string</para>
    ///   <para>skos:definition : investment company that sells and manages a portfolio of securities other than a face-amount certificate company or unit investment fund^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : Section 4, definition of investment companies, Investment Company Act of 1940 as amended and approved as of 3 January 2012, see https://www.sec.gov/about/laws/ica40.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Management companies allow investors to pool their capital with that of other investors in order to purchase professionally-managed groups of diversified securities.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ManagementCompany">fibo-fbc-fct-fse:ManagementCompany</a>
    /// </summary>
    let ManagementCompany = _prefixId.prefix "ManagementCompany"
    /// <summary>
    ///   <para>rdfs:label : merchant service^^xsd:string</para>
    ///   <para>skos:definition : financial service provided by a financial institution to a merchant or other business, including but not limited to managing financial transactions via a secure channel^^xsd:string</para>
    ///   <para>skos:example : Example merchant services include credit and debit card processing, check guarantee and conversion services, point of sale (PoS) systems, gift card and loyalty programs, online transaction processing, etc.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MerchantService">fibo-fbc-fct-fse:MerchantService</a>
    /// </summary>
    let MerchantService = _prefixId.prefix "MerchantService"
    /// <summary>
    ///   <para>rdfs:label : monetary authority^^xsd:string</para>
    ///   <para>skos:definition : regulatory agency that controls the monetary policy, regulation and supply of money in some country or group of countries^^xsd:string</para>
    ///   <para>skos:example : a central bank, the executive branch of a government, a central bank for several nations, a currency board^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investordictionary.com/definition/monetary-authority^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MonetaryAuthority">fibo-fbc-fct-fse:MonetaryAuthority</a>
    /// </summary>
    let MonetaryAuthority = _prefixId.prefix "MonetaryAuthority"
    /// <summary>
    ///   <para>rdfs:label : money services business^^xsd:string</para>
    ///   <para>skos:definition : any person doing business, whether or not on a regular basis or as an organized business concern, in one of the following capacities: (1) currency dealer or exchanger, (2) check casher, (3) issuer of traveler's checks, money orders, or stored value, (4) seller or redeemer of traveler's checks, money orders, or stored value, (5) money transmitter, or (6) postal service^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : MSB^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This definition excludes banks and persons registered with or examined by the Securities and Exchange Commission or the Commodities Futures Trading Commission.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MoneyServicesBusiness">fibo-fbc-fct-fse:MoneyServicesBusiness</a>
    /// </summary>
    let MoneyServicesBusiness = _prefixId.prefix "MoneyServicesBusiness"
    /// <summary>
    ///   <para>rdfs:label : mortgage company^^xsd:string</para>
    ///   <para>skos:definition : financial service provider that originates and/or funds mortgages for residential or commercial property^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MortgageCompany">fibo-fbc-fct-fse:MortgageCompany</a>
    /// </summary>
    let MortgageCompany = _prefixId.prefix "MortgageCompany"
    /// <summary>
    ///   <para>rdfs:label : non-depository institution^^xsd:string</para>
    ///   <para>skos:definition : financial institution that does not have a full banking license and typically is not supervised by a national or international banking regulatory agency^^xsd:string</para>
    ///   <para>skos:historyNote : The term 'non-bank' may have been derived from 'non-deposit taking banking institution'. To be clearer, in the United States, non-depository institutions are explicitly disjoint with depository institutions (financial institutions that take deposits of some sort, potentially including securities) in FIBO. Banks are defined as financial institutions that take demand deposits from the public and that also provide commercial lending services. Many 'non-bank' institutions take deposits or provide commercial lending services, but they may not do both.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Banking Terms, Sixth Edition, 2012^^xsd:stringcmns-av:adaptedFrom : https://www.worldbank.org/en/publication/gfdr/gfdr-2016/background/nonbank-financial-institution^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A non-depository financial institution acts as a middleman between two parties in a financial transaction, and does not provide traditional depository services, such as brokerage firms, insurance companies, and investment companies. These kinds of institutions facilitate alternative financial services, such as investment (both collective and individual), risk pooling, financial consulting, brokering, money transmission, and check cashing. NBFIs are a source of consumer credit (along with licensed banks). Examples of nonbank financial institutions include insurance firms, venture capitalists, currency exchanges, some microloan organizations, and pawn shops. These non-bank financial institutions provide services that are not necessarily suited to banks, serve as competition to banks, and specialize in sectors or groups. Note, however, that there are exceptions in Europe, for example, where the same firm may have banking, insurance, and brokerage functions.^^xsd:string</para>
    ///   <para>cmns-av:synonym : non-bank financial company (NBFC)^^xsd:stringcmns-av:synonym : non-bank financial institution (NBFI)^^xsd:stringcmns-av:synonym : non-banking financial institution (NBFI)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/NonDepositoryInstitution">fibo-fbc-fct-fse:NonDepositoryInstitution</a>
    /// </summary>
    let NonDepositoryInstitution = _prefixId.prefix "NonDepositoryInstitution"
    /// <summary>
    ///   <para>rdfs:label : payment service^^xsd:string</para>
    ///   <para>skos:definition : financial service that involves acceptance of electronic payments by a variety of payment methods including credit card, bank-based payments such as direct debit, bank transfer, and real-time bank transfer based on online banking^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PaymentService">fibo-fbc-fct-fse:PaymentService</a>
    /// </summary>
    let PaymentService = _prefixId.prefix "PaymentService"
    /// <summary>
    ///   <para>rdfs:label : payroll service^^xsd:string</para>
    ///   <para>skos:definition : financial service, typically provided to small businesses that are not large enough to have an internal finance organization, that involves managing payment of wages to employees^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Payroll services typically include printing of employee pay checks, direct deposit of wages to employee bank accounts, calculation and withholding of employee taxes, calculation and payment of corporate payroll taxes and fees with appropriate government authorities (such as Social Security in the US), filing government quarterly and annual reports, and so forth. They may also include management of retirement and savings plans, health benefits, timekeeping, automated integration with the business' accounting system, etc.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PayrollService">fibo-fbc-fct-fse:PayrollService</a>
    /// </summary>
    let PayrollService = _prefixId.prefix "PayrollService"
    /// <summary>
    ///   <para>rdfs:label : principal underwriter^^xsd:string</para>
    ///   <para>skos:definition : underwriter who, as principal, purchases from an investment company, or pursuant to some contract has the right to purchase from such company, any security for distribution, or who as agent for such company sells or has the right to sell any security to a dealer or to the public, excluding any dealer who purchases from such company through sn underwriter acting as an agent for such company^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Section 3a of the Investment Company Act of 1940 as amended in January, 2012, https://www.sec.gov/about/laws/ica40.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Principal underwriter of or for a closed-end company or any issuer which is not an investment company, or of any security issued by such a company or issuer, means any underwriter who, in connection with a primary distribution of securities, (a) is in privity of contract with the issuer or an affiliated person of the issuer; (b) acting alone or in concert with one or more other persons, initiates or directs the formation of an underwriting syndicate; or (c) is allowed a rate of gross commission, spread, or other profit greater than the rate allowed another underwriter participating in the distribution.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PrincipalUnderwriter">fibo-fbc-fct-fse:PrincipalUnderwriter</a>
    /// </summary>
    let PrincipalUnderwriter = _prefixId.prefix "PrincipalUnderwriter"
    /// <summary>
    ///   <para>rdfs:label : registered investment advisor^^xsd:string</para>
    ///   <para>skos:definition : registered agent and financial service provider that advises high net worth individuals on investments and manages their portfolios^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : RIA^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/RegisteredInvestmentAdvisor">fibo-fbc-fct-fse:RegisteredInvestmentAdvisor</a>
    /// </summary>
    let RegisteredInvestmentAdvisor = _prefixId.prefix "RegisteredInvestmentAdvisor"
    /// <summary>
    ///   <para>rdfs:label : risk pooling institution^^xsd:string</para>
    ///   <para>skos:definition : financial institution that provides some financial service while spreading the financial risk inherent in that service to lower the probability of a catastrophic financial event by aggregating customers across diverse dimensions as a risk management practice^^xsd:string</para>
    ///   <para>skos:example : Insurance companies are the most common form of risk pooling institution.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.worldbank.org/en/publication/gfdr/gfdr-2016/background/nonbank-financial-institution^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/RiskPoolingInstitution">fibo-fbc-fct-fse:RiskPoolingInstitution</a>
    /// </summary>
    let RiskPoolingInstitution = _prefixId.prefix "RiskPoolingInstitution"
    /// <summary>
    ///   <para>rdfs:label : sales finance company^^xsd:string</para>
    ///   <para>skos:definition : finance company that purchases retail and wholesale paper from automobile and other consumer and commercial goods dealers^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <para>cmns-av:synonym : acceptance company^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SalesFinanceCompany">fibo-fbc-fct-fse:SalesFinanceCompany</a>
    /// </summary>
    let SalesFinanceCompany = _prefixId.prefix "SalesFinanceCompany"
    /// <summary>
    ///   <para>rdfs:label : savings association^^xsd:string</para>
    ///   <para>skos:definition : depository institution that is (a) any federal savings bank or association chartered under section 1464 of the Federal Deposit Insurance Act; (b) any state chartered building and loan association, savings and loan association, or homestead association; or (c) any cooperative bank (other than a cooperative bank which is a state bank as defined in subsection (a)(2)) of the Federal Deposit Insurance Act, which is organized and operating according to the laws of the State (as defined in subsection (a)(3)) in which it is chartered or organized; and (c) any corporation (other than a bank) that the board of directors and the comptroller of the currency jointly determine to be operating in substantially the same manner as such a depository institution^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.fdic.gov/regulations/laws/rules/1000-400.html#fdic1000sec.3a^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SavingsAssociation">fibo-fbc-fct-fse:SavingsAssociation</a>
    /// </summary>
    let SavingsAssociation = _prefixId.prefix "SavingsAssociation"
    /// <summary>
    ///   <para>rdfs:label : self-regulating organization^^xsd:string</para>
    ///   <para>skos:definition : non-governmental organization that has the power to create and exercise some degree of regulatory authority over an industry or profession in some country or group of countries^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : SRO^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SelfRegulatingOrganization">fibo-fbc-fct-fse:SelfRegulatingOrganization</a>
    /// </summary>
    let SelfRegulatingOrganization = _prefixId.prefix "SelfRegulatingOrganization"
    /// <summary>
    ///   <para>rdfs:label : trust company^^xsd:string</para>
    ///   <para>skos:definition : financial institution that acts as a fiduciary, trustee or agent of trusts and agencies^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A professional trust company may be independently owned or owned by, for example, a bank or a law firm, and which specializes in being a trustee of various kinds of trusts. The trust company oversees the management of assets covered by the trust agreement. Such companies often are used when a grantor feels the trust company can do an equal or better job managing the assets than an individual person, or if the grantor does not know of anyone else who can act as trustee. Trust companies sometimes act as fiscal agents for corporations by attending to the registration and transfer of their stocks and bonds, serving as a trustee for their bond and mortgage creditors, and transacting general banking and loan business.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/TrustCompany">fibo-fbc-fct-fse:TrustCompany</a>
    /// </summary>
    let TrustCompany = _prefixId.prefix "TrustCompany"
    /// <summary>
    ///   <para>rdfs:label : underwriter^^xsd:string</para>
    ///   <para>skos:definition : financial service provider that evaluates and assumes another party's risk for a fee, such as a commission, premium, spread or interest^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/Underwriter">fibo-fbc-fct-fse:Underwriter</a>
    /// </summary>
    let Underwriter = _prefixId.prefix "Underwriter"
    /// <summary>
    ///   <para>rdfs:label : underwriting arrangement^^xsd:string</para>
    ///   <para>skos:definition : written contract between parties that commits the underwriter to assuming risk^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/UnderwritingArrangement">fibo-fbc-fct-fse:UnderwritingArrangement</a>
    /// </summary>
    let UnderwritingArrangement = _prefixId.prefix "UnderwritingArrangement"
    /// <summary>
    ///   <para>rdfs:label : unit investment trust^^xsd:string</para>
    ///   <para>skos:definition : investment company which (a) is organized under a trust indenture, contract of custodianship or agency, or similar instrument, (b) does not have a board of directors, and (c) issues only redeemable securities, each of which represents an undivided interest in a unit of specified securities; but does not include a voting trust^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : Section 4, definition of investment companies, Investment Company Act of 1940 as amended and approved as of 3 January 2012, see https://www.sec.gov/about/laws/ica40.pdf^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : UIT^^xsd:string</para>
    ///   <para>cmns-av:synonym : unit investment company^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/UnitInvestmentTrust">fibo-fbc-fct-fse:UnitInvestmentTrust</a>
    /// </summary>
    let UnitInvestmentTrust = _prefixId.prefix "UnitInvestmentTrust"
    /// <summary>
    ///   <para>rdfs:label : wealth management service^^xsd:string</para>
    ///   <para>skos:definition : financial service that combines financial and investment advice, accounting and tax services, retirement planning and legal or estate planning for one set fee^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/WealthManagementService">fibo-fbc-fct-fse:WealthManagementService</a>
    /// </summary>
    let WealthManagementService = _prefixId.prefix "WealthManagementService"
    /// <summary>
    ///   <para>rdfs:label : has date established^^xsd:string</para>
    ///   <para>skos:definition : the date that the financial service provider was formally established^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/nicpubweb/Content/DataDownload/NPW%20Data%20Dictionary.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : This may be the date on its papers of incorporation or formation document, or the date on which it was granted a license.^^xsd:string</para>
    ///   <para>cmns-av:synonym : date of commencement of existence^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateEstablished">fibo-fbc-fct-fse:hasDateEstablished</a>
    /// </summary>
    let hasDateEstablished = _prefixId.prefix "hasDateEstablished"

    /// <summary>
    ///   <para>rdfs:label : has date establishment terminated^^xsd:string</para>
    ///   <para>skos:definition : last full day that the entity existed^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/nicpubweb/Content/DataDownload/NPW%20Data%20Dictionary.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateEstablishmentTerminated">fibo-fbc-fct-fse:hasDateEstablishmentTerminated</a>
    /// </summary>
    let hasDateEstablishmentTerminated =
        _prefixId.prefix "hasDateEstablishmentTerminated"

    /// <summary>
    ///   <para>rdfs:label : has date insured^^xsd:string</para>
    ///   <para>skos:definition : date on which insurance became effective^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/nicpubweb/Content/DataDownload/NPW%20Data%20Dictionary.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateInsured">fibo-fbc-fct-fse:hasDateInsured</a>
    /// </summary>
    let hasDateInsured = _prefixId.prefix "hasDateInsured"
    /// <summary>
    ///   <para>rdfs:label : has portfolio company^^xsd:string</para>
    ///   <para>skos:definition : indicates a party in which a venture capital firm, a buyout firm, or a holding company has invested^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasPortfolioCompany">fibo-fbc-fct-fse:hasPortfolioCompany</a>
    /// </summary>
    let hasPortfolioCompany = _prefixId.prefix "hasPortfolioCompany"
    /// <summary>
    ///   <para>rdfs:label : is portfolio company of^^xsd:string</para>
    ///   <para>skos:definition : indicates a venture capital firm, a buyout firm, or a holding company that is a financial sponsor (i.e. investor in) of the party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/isPortfolioCompanyOf">fibo-fbc-fct-fse:isPortfolioCompanyOf</a>
    /// </summary>
    let isPortfolioCompanyOf = _prefixId.prefix "isPortfolioCompanyOf"
    /// <summary>
    ///   <para>rdfs:label : regulates supply of^^xsd:string</para>
    ///   <para>skos:definition : relates a regulatory agency to something it controls or supervises the availability of in some market by means of rules and regulations^^xsd:string</para>
    ///   <para>skos:example : The Federal Reserve System, whose banks together comprise the central bank of the United States, supervises banking system and regulates the money supply in the US.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/regulatesSupplyOf">fibo-fbc-fct-fse:regulatesSupplyOf</a>
    /// </summary>
    let regulatesSupplyOf = _prefixId.prefix "regulatesSupplyOf"
