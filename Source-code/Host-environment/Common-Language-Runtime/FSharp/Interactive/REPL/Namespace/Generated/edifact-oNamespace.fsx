#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``edifact-o`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://purl.org/edifact/ontology#" "edifact-o"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : BrokerSalesOfficeRole</para>
    ///   <para>rdfs:comment : The role of a party acting in the name of the seller as broker or as sales office.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#BrokerSalesOfficeRole">edifact-o:BrokerSalesOfficeRole</a>
    /// </summary>
    let BrokerSalesOfficeRole = _prefixId.prefix "BrokerSalesOfficeRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : BuyerRole</para>
    ///   <para>rdfs:comment : The role of the party to which articles are sold^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#BuyerRole">edifact-o:BuyerRole</a>
    /// </summary>
    let BuyerRole = _prefixId.prefix "BuyerRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : CalculateDeliverToRole</para>
    ///   <para>rdfs:comment : The role of the party receiving goods and relevant invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#CalculateDeliverToRole">edifact-o:CalculateDeliverToRole</a>
    /// </summary>
    let CalculateDeliverToRole = _prefixId.prefix "CalculateDeliverToRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : CentralRegulatorRole</para>
    ///   <para>rdfs:comment : The role of the party which is the central regulator^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#CentralRegulatorRole">edifact-o:CentralRegulatorRole</a>
    /// </summary>
    let CentralRegulatorRole = _prefixId.prefix "CentralRegulatorRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : DeliveryPartyRole</para>
    ///   <para>rdfs:comment : The role of the party to which goods should be delivered, if not identical with consignee.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#DeliveryPartyRole">edifact-o:DeliveryPartyRole</a>
    /// </summary>
    let DeliveryPartyRole = _prefixId.prefix "DeliveryPartyRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : DespatchPartyRole</para>
    ///   <para>rdfs:comment : The role of the party where goods are collected or taken over by the carrier (i.e. if other than consignor)^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#DespatchPartyRole">edifact-o:DespatchPartyRole</a>
    /// </summary>
    let DespatchPartyRole = _prefixId.prefix "DespatchPartyRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : EDIFACT E-Invoicerdfs:label : E-Invoice</para>
    ///   <para>rdfs:comment : The root class of each invoice. Contains all the linked classes with information about the invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#E-Invoice">edifact-o:E-Invoice</a>
    /// </summary>
    let E_Invoice = _prefixId.prefix "E-Invoice"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : EDIFACT-Structurerdfs:label : EDIFACT-Structure^^xsd:string</para>
    ///   <para>rdfs:comment : Contains all the information which are necessary for the invoice to be a valid EDIFACT Invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#EDIFACT-Structure">edifact-o:EDIFACT-Structure</a>
    /// </summary>
    let EDIFACT_Structure = _prefixId.prefix "EDIFACT-Structure"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : FinalConsigneeRole</para>
    ///   <para>rdfs:comment : The role of the party who has been designated on the invoice or packing list as the final recipient of the stated merchandise.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#FinalConsigneeRole">edifact-o:FinalConsigneeRole</a>
    /// </summary>
    let FinalConsigneeRole = _prefixId.prefix "FinalConsigneeRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : FormalOrganization^^xsd:string</para>
    ///   <para>rdfs:comment : The class containing information about the perfomed role of the involved organizations^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#FormalOrganization">edifact-o:FormalOrganization</a>
    /// </summary>
    let FormalOrganization = _prefixId.prefix "FormalOrganization"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Invoice Contentrdfs:label : InvoiceContent</para>
    ///   <para>rdfs:comment : Defined as the union of the classes Item and InvoiceDetailsrdfs:comment : Defined as the union of the classes Item and InvoiceDetails^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#InvoiceContent">edifact-o:InvoiceContent</a>
    /// </summary>
    let InvoiceContent = _prefixId.prefix "InvoiceContent"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : InvoiceDetails</para>
    ///   <para>rdfs:comment : Contains all the general information about an invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#InvoiceDetails">edifact-o:InvoiceDetails</a>
    /// </summary>
    let InvoiceDetails = _prefixId.prefix "InvoiceDetails"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : InvoiceeRole</para>
    ///   <para>rdfs:comment : The role of the party to whom an invoice is issued^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#InvoiceeRole">edifact-o:InvoiceeRole</a>
    /// </summary>
    let InvoiceeRole = _prefixId.prefix "InvoiceeRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : InvoicingPartyRole</para>
    ///   <para>rdfs:comment : The role of the party issuing an invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#InvoicingPartyRole">edifact-o:InvoicingPartyRole</a>
    /// </summary>
    let InvoicingPartyRole = _prefixId.prefix "InvoicingPartyRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : EDIFACT Item</para>
    ///   <para>rdfs:comment : Contains all the information about a item^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#Item">edifact-o:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : PayeeRole</para>
    ///   <para>rdfs:comment : The role of the party initiating payment^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#PayeeRole">edifact-o:PayeeRole</a>
    /// </summary>
    let PayeeRole = _prefixId.prefix "PayeeRole"

    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : RecipientOfInvoiceRegulationRole</para>
    ///   <para>rdfs:comment : The role of the party to whom payment for a commercial invoice or bill should be remitted.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#RecipientOfInvoiceRegulationRole">edifact-o:RecipientOfInvoiceRegulationRole</a>
    /// </summary>
    let RecipientOfInvoiceRegulationRole =
        _prefixId.prefix "RecipientOfInvoiceRegulationRole"

    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : RecipientRole</para>
    ///   <para>rdfs:comment : The role of the party to which goods are consigned.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#RecipientRole">edifact-o:RecipientRole</a>
    /// </summary>
    let RecipientRole = _prefixId.prefix "RecipientRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : RegulatorRole</para>
    ///   <para>rdfs:comment : The role of the party which is the regulator of the invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#RegulatorRole">edifact-o:RegulatorRole</a>
    /// </summary>
    let RegulatorRole = _prefixId.prefix "RegulatorRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : RepresentativeOfSupplierRole</para>
    ///   <para>rdfs:comment : The role of the party representing the seller for the purpose of the trade transaction.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#RepresentativeOfSupplierRole">edifact-o:RepresentativeOfSupplierRole</a>
    /// </summary>
    let RepresentativeOfSupplierRole = _prefixId.prefix "RepresentativeOfSupplierRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SalesAgentRole</para>
    ///   <para>rdfs:comment : The role of the third party who arranged the purchase of merchandise on behalf of the actual buyer^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#SalesAgentRole">edifact-o:SalesAgentRole</a>
    /// </summary>
    let SalesAgentRole = _prefixId.prefix "SalesAgentRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SellerRole</para>
    ///   <para>rdfs:comment : The role of the party selling merchandise to a buyer.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#SellerRole">edifact-o:SellerRole</a>
    /// </summary>
    let SellerRole = _prefixId.prefix "SellerRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SendToRole</para>
    ///   <para>rdfs:comment : The role of the party to where goods will be or have been shipped^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#SendToRole">edifact-o:SendToRole</a>
    /// </summary>
    let SendToRole = _prefixId.prefix "SendToRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SupplierRole</para>
    ///   <para>rdfs:comment : The role of the party which manufactures or otherwise has possession of goods, and consigns or makes them available in trade.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#SupplierRole">edifact-o:SupplierRole</a>
    /// </summary>
    let SupplierRole = _prefixId.prefix "SupplierRole"

    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SuppliersCompanyHeadquarterRole</para>
    ///   <para>rdfs:comment : The role of the party's headquarters which manufactures or otherwise has possession of goods, and consigns or makes them available in trade.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#SuppliersCompanyHeadquarterRole">edifact-o:SuppliersCompanyHeadquarterRole</a>
    /// </summary>
    let SuppliersCompanyHeadquarterRole =
        _prefixId.prefix "SuppliersCompanyHeadquarterRole"

    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : WarehouseNumberRole</para>
    ///   <para>rdfs:comment : The role of the party that runs the Warehouse^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#WarehouseNumberRole">edifact-o:WarehouseNumberRole</a>
    /// </summary>
    let WarehouseNumberRole = _prefixId.prefix "WarehouseNumberRole"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : WholesalerRole</para>
    ///   <para>rdfs:comment : The role of the party that is the wholesaler^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#WholesalerRole">edifact-o:WholesalerRole</a>
    /// </summary>
    let WholesalerRole = _prefixId.prefix "WholesalerRole"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nummer_des_Forderungskontos^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : accountsReceivableNumber</para>
    ///   <para>rdfs:comment : Reference number assigned by accounts receivable department to the account of a specific debtor.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#accountsReceivableNumber">edifact-o:accountsReceivableNumber</a>
    /// </summary>
    let accountsReceivableNumber = _prefixId.prefix "accountsReceivableNumber"

    /// <summary>
    ///   <para>edifact-o:seeXML : Zusaetzliche_Partneridentifikation_EAN_Code^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : additionalPartnerIdentificationEANCode</para>
    ///   <para>rdfs:comment : Additional Partneridentification (GLN-Code)^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#additionalPartnerIdentificationEANCode">edifact-o:additionalPartnerIdentificationEANCode</a>
    /// </summary>
    let additionalPartnerIdentificationEANCode =
        _prefixId.prefix "additionalPartnerIdentificationEANCode"

    /// <summary>
    ///   <para>edifact-o:seeXML : Zuschlag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : allowanceReason</para>
    ///   <para>rdfs:comment : Reason for the allowance</para>
    ///   <a href="https://purl.org/edifact/ontology#allowanceReason">edifact-o:allowanceReason</a>
    /// </summary>
    let allowanceReason = _prefixId.prefix "allowanceReason"
    /// <summary>
    ///   <para>edifact-o:seeXML : ProcessIdentification^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : belongsToProcess</para>
    ///   <para>rdfs:comment : Indicates to which business process the invoice belongs^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#belongsToProcess">edifact-o:belongsToProcess</a>
    /// </summary>
    let belongsToProcess = _prefixId.prefix "belongsToProcess"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenz_des_Beguenstigten^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : beneficiaryReference</para>
    ///   <para>rdfs:comment : Reference of the beneficiary^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#beneficiaryReference">edifact-o:beneficiaryReference</a>
    /// </summary>
    let beneficiaryReference = _prefixId.prefix "beneficiaryReference"
    /// <summary>
    ///   <para>edifact-o:seeXML : Bilateral_vereinbart^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : bilateralAgreed</para>
    ///   <para>rdfs:comment : Note contains information mutually defined by trading partners^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#bilateralAgreed">edifact-o:bilateralAgreed</a>
    /// </summary>
    let bilateralAgreed = _prefixId.prefix "bilateralAgreed"
    /// <summary>
    ///   <para>edifact-o:seeXML : Abechnungszeitraum^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : calculationPeriod</para>
    ///   <para>rdfs:comment : Period for which an invoice is issued.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#calculationPeriod">edifact-o:calculationPeriod</a>
    /// </summary>
    let calculationPeriod = _prefixId.prefix "calculationPeriod"
    /// <summary>
    ///   <para>edifact-o:seeXML : Aenderungsinformationen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : changeInformation</para>
    ///   <para>rdfs:comment : Note contains change information^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#changeInformation">edifact-o:changeInformation</a>
    /// </summary>
    let changeInformation = _prefixId.prefix "changeInformation"

    /// <summary>
    ///   <para>edifact-o:seeXML : Unternehmes_oder_Ort_Regisstriernummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : companyOrPlaceRegistristrationNumber</para>
    ///   <para>rdfs:comment : Company registration and place as legally required.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#companyOrPlaceRegistristrationNumber">edifact-o:companyOrPlaceRegistristrationNumber</a>
    /// </summary>
    let companyOrPlaceRegistristrationNumber =
        _prefixId.prefix "companyOrPlaceRegistristrationNumber"

    /// <summary>
    ///   <para>edifact-o:seeXML : Anzahl_der_Verbrauchereinheiten_in_einer_Handelseinheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : consumerUnitsInTradingUnitQuantity</para>
    ///   <para>rdfs:comment : Numbers of consumer units in the traded unit^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#consumerUnitsInTradingUnitQuantity">edifact-o:consumerUnitsInTradingUnitQuantity</a>
    /// </summary>
    let consumerUnitsInTradingUnitQuantity =
        _prefixId.prefix "consumerUnitsInTradingUnitQuantity"

    /// <summary>
    ///   <para>edifact-o:seeXML : Anzahl_der_Verbrauchereinheiten_in_einer_Handelseinheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : consumerUnitsInTradingUnitQuantityWithUnit</para>
    ///   <para>rdfs:comment : Numbers of consumer units in the traded unit^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#consumerUnitsInTradingUnitQuantityWithUnit">edifact-o:consumerUnitsInTradingUnitQuantityWithUnit</a>
    /// </summary>
    let consumerUnitsInTradingUnitQuantityWithUnit =
        _prefixId.prefix "consumerUnitsInTradingUnitQuantityWithUnit"

    /// <summary>
    ///   <para>edifact-o:seeXML : D_3412^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contactDepartmentPerson</para>
    ///   <para>rdfs:comment : The department or person within an organizational entity.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactDepartmentPerson">edifact-o:contactDepartmentPerson</a>
    /// </summary>
    let contactDepartmentPerson = _prefixId.prefix "contactDepartmentPerson"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contactPerson</para>
    ///   <para>rdfs:comment : Contact Persons^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersom">edifact-o:contactPersom</a>
    /// </summary>
    let contactPersom = _prefixId.prefix "contactPersom"
    /// <summary>
    ///   <para>rdfs:label : contactPersonAccounting</para>
    ///   <para>edifact-o:seeEDIFACT : CTA+AD^^xsd:string</para>
    ///   <para>edifact-o:seeXML : Ansprechpartner_Buchhaltung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Department/person responsible for the accounts payable function within a corporation.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonAccounting">edifact-o:contactPersonAccounting</a>
    /// </summary>
    let contactPersonAccounting = _prefixId.prefix "contactPersonAccounting"

    /// <summary>
    ///   <para>rdfs:comment : Department/person responsible for the accounts payable function within a corporation^^xsd:string</para>
    ///   <para>rdfs:label : contactPersonCreditorAccounting</para>
    ///   <para>edifact-o:seeXML : Ansprechpartner_Kreditorenbuchhaltung^^xsd:string</para>
    ///   <para>edifact-o:seeEDIFACT : CTA+AP^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonCreditorAccounting">edifact-o:contactPersonCreditorAccounting</a>
    /// </summary>
    let contactPersonCreditorAccounting =
        _prefixId.prefix "contactPersonCreditorAccounting"

    /// <summary>
    ///   <para>rdfs:label : contactPersonEmailAddress</para>
    ///   <para>edifact-o:seeEDIFACT : COM+:EM^^xsd:string</para>
    ///   <para>edifact-o:seeXML : Ansprechpartner_EmailAdresse^^xsd:string</para>
    ///   <para>rdfs:comment : Creating/sending/receiving of unstructured free text messages or documents using computer network, a mini- computer or an attached modem and regular telephone line or other electronic transmission media.^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonEmailAddress">edifact-o:contactPersonEmailAddress</a>
    /// </summary>
    let contactPersonEmailAddress = _prefixId.prefix "contactPersonEmailAddress"
    /// <summary>
    ///   <para>edifact-o:seeEDIFACT : COM+:FX^^xsd:string</para>
    ///   <para>rdfs:label : contactPersonFaxNumber</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Device used for transmitting and reproducing fixed graphic material (as printing) by means of signals over telephone lines or other electronic transmission media.^^xsd:string</para>
    ///   <para>edifact-o:seeXML : Ansprechpartner_TelefaxNummer^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonFaxNumber">edifact-o:contactPersonFaxNumber</a>
    /// </summary>
    let contactPersonFaxNumber = _prefixId.prefix "contactPersonFaxNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Ansprechpartner_Wareneingang^^xsd:string</para>
    ///   <para>rdfs:label : contactPersonIncomingGoods</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>edifact-o:seeEDIFACT : CTA+GR^^xsd:string</para>
    ///   <para>rdfs:comment : Department/person responsible for receiving the goods at the place of delivery.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonIncomingGoods">edifact-o:contactPersonIncomingGoods</a>
    /// </summary>
    let contactPersonIncomingGoods = _prefixId.prefix "contactPersonIncomingGoods"
    /// <summary>
    ///   <para>edifact-o:seeEDIFACT : COM+IC^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Department/person to contact for questions regarding transactions^^xsd:string</para>
    ///   <para>edifact-o:seeXML : Ansprechpartner_Information^^xsd:string</para>
    ///   <para>rdfs:label : contactPersonInformation</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonInformation">edifact-o:contactPersonInformation</a>
    /// </summary>
    let contactPersonInformation = _prefixId.prefix "contactPersonInformation"

    /// <summary>
    ///   <para>edifact-o:seeXML : Ansprechpartner_Einkaufabteilung^^xsd:string</para>
    ///   <para>edifact-o:seeEDIFACT : CTA+PD^^xsd:string</para>
    ///   <para>rdfs:label : contactPersonPurchasingDepartment</para>
    ///   <para>rdfs:comment : Department/person responsible for issuing this purchase order.^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonPurchasingDepartment">edifact-o:contactPersonPurchasingDepartment</a>
    /// </summary>
    let contactPersonPurchasingDepartment =
        _prefixId.prefix "contactPersonPurchasingDepartment"

    /// <summary>
    ///   <para>edifact-o:seeXML : Ansprechpartner_Debitorenbuchaltung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contactPersonReceivableAccounting</para>
    ///   <para>edifact-o:seeEDIFACT : CTA+AR^^xsd:string</para>
    ///   <para>rdfs:comment : Department/person responsible for the accounts receivable within a corporation^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonReceivableAccounting">edifact-o:contactPersonReceivableAccounting</a>
    /// </summary>
    let contactPersonReceivableAccounting =
        _prefixId.prefix "contactPersonReceivableAccounting"

    /// <summary>
    ///   <para>edifact-o:seeEDIFACT : CTA+SR^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The sales representative or department contact within an organization.^^xsd:string</para>
    ///   <para>rdfs:label : contactPersonSalesDepartment</para>
    ///   <para>edifact-o:seeXML : Ansprechpartner_Verkaufsabteilung^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonSalesDepartment">edifact-o:contactPersonSalesDepartment</a>
    /// </summary>
    let contactPersonSalesDepartment = _prefixId.prefix "contactPersonSalesDepartment"
    /// <summary>
    ///   <para>rdfs:label : contactPersonTelefonNumber</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>edifact-o:seeEDIFACT : COM+:TE^^xsd:string</para>
    ///   <para>edifact-o:seeXML : Ansprechpartner_TelefonNummer^^xsd:string</para>
    ///   <para>rdfs:comment : Voice/data transmission by telephone^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonTelefonNumber">edifact-o:contactPersonTelefonNumber</a>
    /// </summary>
    let contactPersonTelefonNumber = _prefixId.prefix "contactPersonTelefonNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Ansprechpartner_TelexNummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contactPersonTelexNumber</para>
    ///   <para>rdfs:comment : Transmission of text/data via telex.^^xsd:string</para>
    ///   <para>edifact-o:seeEDIFACT : COM+:TL^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonTelexNumber">edifact-o:contactPersonTelexNumber</a>
    /// </summary>
    let contactPersonTelexNumber = _prefixId.prefix "contactPersonTelexNumber"
    /// <summary>
    ///   <para>rdfs:comment : CCITT Message handling system^^xsd:string</para>
    ///   <para>rdfs:label : contactPersonX400Number</para>
    ///   <para>edifact-o:seeEDIFACT : COM+:XF^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>edifact-o:seeXML : Ansprechpartner_X400Nummer^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contactPersonX400Number">edifact-o:contactPersonX400Number</a>
    /// </summary>
    let contactPersonX400Number = _prefixId.prefix "contactPersonX400Number"
    /// <summary>
    ///   <para>edifact-o:seeXML : Vertragsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contractNumber</para>
    ///   <para>rdfs:comment : Reference number of a contract concluded between parties.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contractNumber">edifact-o:contractNumber</a>
    /// </summary>
    let contractNumber = _prefixId.prefix "contractNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Vertragsnummer_des_Kaeufers^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contractNumberBuyer</para>
    ///   <para>rdfs:comment : Reference number assigned by buyer to a contract.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#contractNumberBuyer">edifact-o:contractNumberBuyer</a>
    /// </summary>
    let contractNumberBuyer = _prefixId.prefix "contractNumberBuyer"

    /// <summary>
    ///   <para>edifact-o:seeXML : D_0081^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : controlSegmentBetweenItemAndTotalPart</para>
    ///   <para>rdfs:comment : Detail/summary section separation^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#controlSegmentBetweenItemAndTotalPart">edifact-o:controlSegmentBetweenItemAndTotalPart</a>
    /// </summary>
    let controlSegmentBetweenItemAndTotalPart =
        _prefixId.prefix "controlSegmentBetweenItemAndTotalPart"

    /// <summary>
    ///   <para>edifact-o:seeXML : D_0017^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : creationDate</para>
    ///   <para>rdfs:comment : Date when the message was created^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#creationDate">edifact-o:creationDate</a>
    /// </summary>
    let creationDate = _prefixId.prefix "creationDate"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_0019^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : creationTime</para>
    ///   <para>rdfs:comment : Time of the creation of the EDIFACT message^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#creationTime">edifact-o:creationTime</a>
    /// </summary>
    let creationTime = _prefixId.prefix "creationTime"
    /// <summary>
    ///   <para>edifact-o:seeXML : Gutschriftsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : creditNoteNumber</para>
    ///   <para>rdfs:comment : Reference number assigned to a credit note.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#creditNoteNumber">edifact-o:creditNoteNumber</a>
    /// </summary>
    let creditNoteNumber = _prefixId.prefix "creditNoteNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Zolltarifnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : customsTariffNumber</para>
    ///   <para>rdfs:comment : Code number of the goods in accordance with the tariff nomenclature system of classification in use where the Customs declaration is made.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#customsTariffNumber">edifact-o:customsTariffNumber</a>
    /// </summary>
    let customsTariffNumber = _prefixId.prefix "customsTariffNumber"
    /// <summary>
    ///   <para>rdfs:label : dataExchangeCounter</para>
    ///   <para>edifact-o:seeEDIFACT : 36^^xsd:integer</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>edifact-o:seeXML : D_0036^^xsd:string</para>
    ///   <para>rdfs:comment : the counter of the exchanged data^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dataExchangeCounter">edifact-o:dataExchangeCounter</a>
    /// </summary>
    let dataExchangeCounter = _prefixId.prefix "dataExchangeCounter"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_0020^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dataExchangeReference</para>
    ///   <para>rdfs:comment : the reference of the exchanged data^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dataExchangeReference">edifact-o:dataExchangeReference</a>
    /// </summary>
    let dataExchangeReference = _prefixId.prefix "dataExchangeReference"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Nummer_des_Forderungskontos^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateAccountsReceivableNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by accounts receivable department to the account of a specific debtor.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateAccountsReceivableNumber">edifact-o:dateAccountsReceivableNumber</a>
    /// </summary>
    let dateAccountsReceivableNumber = _prefixId.prefix "dateAccountsReceivableNumber"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Zusaetzliche_Partneridentifikation_EAN_Code^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateAdditionalPartnerIdentificationEANCode</para>
    ///   <para>rdfs:comment : Date of Additional Partneridentification (GLN-Code)^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateAdditionalPartnerIdentificationEANCode">edifact-o:dateAdditionalPartnerIdentificationEANCode</a>
    /// </summary>
    let dateAdditionalPartnerIdentificationEANCode =
        _prefixId.prefix "dateAdditionalPartnerIdentificationEANCode"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Referenz_des_Beguenstigten^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateBeneficiaryReference</para>
    ///   <para>rdfs:comment : Date of the reference of the beneficiary^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateBeneficiaryReference">edifact-o:dateBeneficiaryReference</a>
    /// </summary>
    let dateBeneficiaryReference = _prefixId.prefix "dateBeneficiaryReference"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Unternehmes_oder_Ort_Regisstriernummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateCompanyOrPlaceRegistristrationNumber</para>
    ///   <para>rdfs:comment : Date of company registration and place as legally required.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateCompanyOrPlaceRegistristrationNumber">edifact-o:dateCompanyOrPlaceRegistristrationNumber</a>
    /// </summary>
    let dateCompanyOrPlaceRegistristrationNumber =
        _prefixId.prefix "dateCompanyOrPlaceRegistristrationNumber"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Vertragsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateContractNumber</para>
    ///   <para>rdfs:comment : Date of the reference number of a contract concluded between parties.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateContractNumber">edifact-o:dateContractNumber</a>
    /// </summary>
    let dateContractNumber = _prefixId.prefix "dateContractNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Vertragsnummer_des_Kaeufers^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateContractNumberBuyer</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by buyer to a contract.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateContractNumberBuyer">edifact-o:dateContractNumberBuyer</a>
    /// </summary>
    let dateContractNumberBuyer = _prefixId.prefix "dateContractNumberBuyer"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Gutschriftsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateCreditNoteNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned to a credit note.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateCreditNoteNumber">edifact-o:dateCreditNoteNumber</a>
    /// </summary>
    let dateCreditNoteNumber = _prefixId.prefix "dateCreditNoteNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Zolltarifnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateCustomsTariffNumber</para>
    ///   <para>rdfs:comment : Date of the code number of the goods in accordance with the tariff nomenclature system of classification in use where the Customs declaration is made.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateCustomsTariffNumber">edifact-o:dateCustomsTariffNumber</a>
    /// </summary>
    let dateCustomsTariffNumber = _prefixId.prefix "dateCustomsTariffNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Nummer_der_Belastungsanzeige^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateDebitNoteNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by issuer to a debit note^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateDebitNoteNumber">edifact-o:dateDebitNoteNumber</a>
    /// </summary>
    let dateDebitNoteNumber = _prefixId.prefix "dateDebitNoteNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Lieferscheinnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateDeliveryNoteNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by the issuer to a delivery note.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateDeliveryNoteNumber">edifact-o:dateDeliveryNoteNumber</a>
    /// </summary>
    let dateDeliveryNoteNumber = _prefixId.prefix "dateDeliveryNoteNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Nummer_Lieferschein^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateDespatchAdviceNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by issuing party to a despatch advice.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateDespatchAdviceNumber">edifact-o:dateDespatchAdviceNumber</a>
    /// </summary>
    let dateDespatchAdviceNumber = _prefixId.prefix "dateDespatchAdviceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Exportreferenznummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateExportReferenceNumber</para>
    ///   <para>rdfs:comment : Date of the reference number given to an export shipment.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateExportReferenceNumber">edifact-o:dateExportReferenceNumber</a>
    /// </summary>
    let dateExportReferenceNumber = _prefixId.prefix "dateExportReferenceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Bezeichner_Dateizeilen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateFileLineIdentifier</para>
    ///   <para>rdfs:comment : Date of number assigned by the file issuer or sender to identify a specific line.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateFileLineIdentifier">edifact-o:dateFileLineIdentifier</a>
    /// </summary>
    let dateFileLineIdentifier = _prefixId.prefix "dateFileLineIdentifier"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Kontonummer_des_Zahlungsempfaenger^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateFinancialAccountNumberPayee</para>
    ///   <para>rdfs:comment : Date of the receiving company account number (ACH transfer), check, draft or wire^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateFinancialAccountNumberPayee">edifact-o:dateFinancialAccountNumberPayee</a>
    /// </summary>
    let dateFinancialAccountNumberPayee =
        _prefixId.prefix "dateFinancialAccountNumberPayee"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Steuernummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateFiscalNumber</para>
    ///   <para>rdfs:comment : Date of Tax payer's number.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateFiscalNumber">edifact-o:dateFiscalNumber</a>
    /// </summary>
    let dateFiscalNumber = _prefixId.prefix "dateFiscalNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Referenznummer_Regierung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateGovernmentReferenceNumber</para>
    ///   <para>rdfs:comment : Date of the refernce number given by the goverment^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateGovernmentReferenceNumber">edifact-o:dateGovernmentReferenceNumber</a>
    /// </summary>
    let dateGovernmentReferenceNumber = _prefixId.prefix "dateGovernmentReferenceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Nummer_harmonisiertes_System^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateHarmonisedSystemNumber</para>
    ///   <para>rdfs:comment : Date of the number specifying the goods classification under the Harmonised Commodity Description and Coding System of the Customs Co-operation Council (CCC).^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateHarmonisedSystemNumber">edifact-o:dateHarmonisedSystemNumber</a>
    /// </summary>
    let dateHarmonisedSystemNumber = _prefixId.prefix "dateHarmonisedSystemNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Import_Lizenznummer</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateImportLicenseNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by the issuing authority to an Import Licence.</para>
    ///   <a href="https://purl.org/edifact/ontology#dateImportLicenseNumber">edifact-o:dateImportLicenseNumber</a>
    /// </summary>
    let dateImportLicenseNumber = _prefixId.prefix "dateImportLicenseNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Interne_Kundennummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateInternalCustomerNumber</para>
    ///   <para>rdfs:comment : Date of the number assigned by a seller, supplier etc. to identify a customer within his enterprise.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateInternalCustomerNumber">edifact-o:dateInternalCustomerNumber</a>
    /// </summary>
    let dateInternalCustomerNumber = _prefixId.prefix "dateInternalCustomerNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Interne_Lieferantennummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateInternalVendorNumber</para>
    ///   <para>rdfs:comment : Date of the number identifying the company-internal vending department/unit.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateInternalVendorNumber">edifact-o:dateInternalVendorNumber</a>
    /// </summary>
    let dateInternalVendorNumber = _prefixId.prefix "dateInternalVendorNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Rechnungsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateInvoiceNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by the seller to a Commercial Invoice.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateInvoiceNumber">edifact-o:dateInvoiceNumber</a>
    /// </summary>
    let dateInvoiceNumber = _prefixId.prefix "dateInvoiceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Referenznummer_der_Position^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateLineItemReferenceNumber</para>
    ///   <para>rdfs:comment : Date of the reference number identifying a particular line in a document.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateLineItemReferenceNumber">edifact-o:dateLineItemReferenceNumber</a>
    /// </summary>
    let dateLineItemReferenceNumber = _prefixId.prefix "dateLineItemReferenceNumber"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Nummer_einr_konsolidierten_Rechnung_EAN_Code^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateNumberConsolidatedInvoiceEANCode</para>
    ///   <para>rdfs:comment : Date of the consolidated invoice number with EAN code^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateNumberConsolidatedInvoiceEANCode">edifact-o:dateNumberConsolidatedInvoiceEANCode</a>
    /// </summary>
    let dateNumberConsolidatedInvoiceEANCode =
        _prefixId.prefix "dateNumberConsolidatedInvoiceEANCode"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Nummer_eines_Buendels_von_Nachrichten^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateNumberOfBundleMessages</para>
    ///   <para>rdfs:comment : Date of batch number identifying a batch of messages.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateNumberOfBundleMessages">edifact-o:dateNumberOfBundleMessages</a>
    /// </summary>
    let dateNumberOfBundleMessages = _prefixId.prefix "dateNumberOfBundleMessages"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Angebotsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateOfferNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by issuing party to an offer.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateOfferNumber">edifact-o:dateOfferNumber</a>
    /// </summary>
    let dateOfferNumber = _prefixId.prefix "dateOfferNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Auftragsnummer_Kaeufer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateOrderNumberBuyer</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by the buyer to an order.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateOrderNumberBuyer">edifact-o:dateOrderNumberBuyer</a>
    /// </summary>
    let dateOrderNumberBuyer = _prefixId.prefix "dateOrderNumberBuyer"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Nummer_Lieferauftrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateOrderNumberDelivery</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by issuer to a delivery order.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateOrderNumberDelivery">edifact-o:dateOrderNumberDelivery</a>
    /// </summary>
    let dateOrderNumberDelivery = _prefixId.prefix "dateOrderNumberDelivery"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Auftragsnummer_Lieferant^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateOrderNumberSupplier</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by supplier to a buyer's purchase order.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateOrderNumberSupplier">edifact-o:dateOrderNumberSupplier</a>
    /// </summary>
    let dateOrderNumberSupplier = _prefixId.prefix "dateOrderNumberSupplier"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Referenz_des_Absenders^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateOriginatorReference</para>
    ///   <para>rdfs:comment : Date of the reference of the originator^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateOriginatorReference">edifact-o:dateOriginatorReference</a>
    /// </summary>
    let dateOriginatorReference = _prefixId.prefix "dateOriginatorReference"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Zahlungsreferenz^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : datePaymentReference</para>
    ///   <para>rdfs:comment : Date of the reference number assigned to a payment.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#datePaymentReference">edifact-o:datePaymentReference</a>
    /// </summary>
    let datePaymentReference = _prefixId.prefix "datePaymentReference"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Nummer_der_Preisliste^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : datePriceListNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned to a price list.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#datePriceListNumber">edifact-o:datePriceListNumber</a>
    /// </summary>
    let datePriceListNumber = _prefixId.prefix "datePriceListNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Proforma_Rechnungsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateProformaInvoiceNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by the seller to a Proforma Invoice.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateProformaInvoiceNumber">edifact-o:dateProformaInvoiceNumber</a>
    /// </summary>
    let dateProformaInvoiceNumber = _prefixId.prefix "dateProformaInvoiceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Wareneingangsmeldung_Nummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateReceivingAdviceNumber</para>
    ///   <para>rdfs:comment : Date of a reference number to a receiving advice.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateReceivingAdviceNumber">edifact-o:dateReceivingAdviceNumber</a>
    /// </summary>
    let dateReceivingAdviceNumber = _prefixId.prefix "dateReceivingAdviceNumber"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Referenznummer_zu_einem_Geschaeftskontauszug_EAN_Code^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateReferenceNumberBusinessContactExtractEANCode</para>
    ///   <para>rdfs:comment : Date of the reference number for a business account statement as EAN code^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateReferenceNumberBusinessContactExtractEANCode">edifact-o:dateReferenceNumberBusinessContactExtractEANCode</a>
    /// </summary>
    let dateReferenceNumberBusinessContactExtractEANCode =
        _prefixId.prefix "dateReferenceNumberBusinessContactExtractEANCode"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Referenzsnummer_des_Kunden^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateReferenceNumberCustomer</para>
    ///   <para>rdfs:comment : Date of the reference number assigned by the customer to a transaction.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateReferenceNumberCustomer">edifact-o:dateReferenceNumberCustomer</a>
    /// </summary>
    let dateReferenceNumberCustomer = _prefixId.prefix "dateReferenceNumberCustomer"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_zugehoerige_Dokumentennummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateRelatedDocumentNumber</para>
    ///   <para>rdfs:comment : Date of the realted document number^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateRelatedDocumentNumber">edifact-o:dateRelatedDocumentNumber</a>
    /// </summary>
    let dateRelatedDocumentNumber = _prefixId.prefix "dateRelatedDocumentNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Referenznummer_des_Verkaeufers^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateSellersReferenceNumber</para>
    ///   <para>rdfs:comment : Date of the reference number assigned to a transaction by the seller^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateSellersReferenceNumber">edifact-o:dateSellersReferenceNumber</a>
    /// </summary>
    let dateSellersReferenceNumber = _prefixId.prefix "dateSellersReferenceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum_Spezifikationsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateSpecificationNumber</para>
    ///   <para>rdfs:comment : Date of the number assigned by the issuer to his specification.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#dateSpecificationNumber">edifact-o:dateSpecificationNumber</a>
    /// </summary>
    let dateSpecificationNumber = _prefixId.prefix "dateSpecificationNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nummer_der_Belastungsanzeige^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : debitNoteNumber</para>
    ///   <para>rdfs:comment : Reference number assigned by issuer to a debit note^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#debitNoteNumber">edifact-o:debitNoteNumber</a>
    /// </summary>
    let debitNoteNumber = _prefixId.prefix "debitNoteNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Menge_Geliefert^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : deliveredQuantity</para>
    ///   <para>rdfs:comment : Number of pieces actually received at the final destination.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#deliveredQuantity">edifact-o:deliveredQuantity</a>
    /// </summary>
    let deliveredQuantity = _prefixId.prefix "deliveredQuantity"
    /// <summary>
    ///   <para>edifact-o:seeXML : Lieferbedingung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : deliveryCondition</para>
    ///   <para>rdfs:comment : Specifies the conditions under which the goods must be delivered to the consignee^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#deliveryCondition">edifact-o:deliveryCondition</a>
    /// </summary>
    let deliveryCondition = _prefixId.prefix "deliveryCondition"
    /// <summary>
    ///   <para>edifact-o:seeXML : Lieferscheinnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : deliveryNoteNumber</para>
    ///   <para>rdfs:comment : Reference number assigned by the issuer to a delivery note.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#deliveryNoteNumber">edifact-o:deliveryNoteNumber</a>
    /// </summary>
    let deliveryNoteNumber = _prefixId.prefix "deliveryNoteNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Warenbeschreibung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : descriptionOfGoods</para>
    ///   <para>rdfs:comment : Plain language description of the nature of the goods sufficient to identify them at the level required for banking, Customs, statistical or transport purposes, avoiding unnecessary detail (Generic term).^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#descriptionOfGoods">edifact-o:descriptionOfGoods</a>
    /// </summary>
    let descriptionOfGoods = _prefixId.prefix "descriptionOfGoods"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nummer_Lieferschein^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : despatchAdviceNumber</para>
    ///   <para>rdfs:comment : Reference number assigned by issuing party to a despatch advice.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#despatchAdviceNumber">edifact-o:despatchAdviceNumber</a>
    /// </summary>
    let despatchAdviceNumber = _prefixId.prefix "despatchAdviceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Menge_Sendungen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : despatchQuantity</para>
    ///   <para>rdfs:comment : Quantity despatched by the seller.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#despatchQuantity">edifact-o:despatchQuantity</a>
    /// </summary>
    let despatchQuantity = _prefixId.prefix "despatchQuantity"
    /// <summary>
    ///   <para>edifact-o:seeXML : Datum_Rabattbeendigung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : discountTerminationDate</para>
    ///   <para>rdfs:comment : Date/time when the deduction from an amount comes to an end.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#discountTerminationDate">edifact-o:discountTerminationDate</a>
    /// </summary>
    let discountTerminationDate = _prefixId.prefix "discountTerminationDate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Menge_Diskret^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : discreteQuantity</para>
    ///   <para>rdfs:comment : The discrete quantity^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#discreteQuantity">edifact-o:discreteQuantity</a>
    /// </summary>
    let discreteQuantity = _prefixId.prefix "discreteQuantity"
    /// <summary>
    ///   <para>edifact-o:seeXML : Dokumenten_oder_Nachrichten_Datum^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : documentDate</para>
    ///   <para>rdfs:comment : Date/time when a document/message is issued. This may include authentication.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#documentDate">edifact-o:documentDate</a>
    /// </summary>
    let documentDate = _prefixId.prefix "documentDate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Gueltigkeitsdatum^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : effectiveDate</para>
    ///   <para>rdfs:comment : Date and/or time at which specified event or document becomes effective.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#effectiveDate">edifact-o:effectiveDate</a>
    /// </summary>
    let effectiveDate = _prefixId.prefix "effectiveDate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Wechselkursdatum^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : exchangeRateDate</para>
    ///   <para>rdfs:comment : Date/time on which the exchange rate was fixed.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#exchangeRateDate">edifact-o:exchangeRateDate</a>
    /// </summary>
    let exchangeRateDate = _prefixId.prefix "exchangeRateDate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Exportreferenznummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : exportReferenceNumber</para>
    ///   <para>rdfs:comment : Reference number given to an export shipment.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#exportReferenceNumber">edifact-o:exportReferenceNumber</a>
    /// </summary>
    let exportReferenceNumber = _prefixId.prefix "exportReferenceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Bezeichner_Dateizeilen</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : fileLineIdentifier</para>
    ///   <para>rdfs:comment : Number assigned by the file issuer or sender to identify a specific line.</para>
    ///   <a href="https://purl.org/edifact/ontology#fileLineIdentifier">edifact-o:fileLineIdentifier</a>
    /// </summary>
    let fileLineIdentifier = _prefixId.prefix "fileLineIdentifier"
    /// <summary>
    ///   <para>edifact-o:seeXML : Kontonummer_des_Zahlungsempfaenger^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : financialAccountNumberPayee</para>
    ///   <para>rdfs:comment : Receiving company account number (ACH transfer), check, draft or wire^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#financialAccountNumberPayee">edifact-o:financialAccountNumberPayee</a>
    /// </summary>
    let financialAccountNumberPayee = _prefixId.prefix "financialAccountNumberPayee"
    /// <summary>
    ///   <para>edifact-o:seeXML : Steuernummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : fiscalNumber</para>
    ///   <para>rdfs:comment : Tax payer's number. Number assigned to individual persons as well as to corporates by a public institution; this number is different from the VAT registration number.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#fiscalNumber">edifact-o:fiscalNumber</a>
    /// </summary>
    let fiscalNumber = _prefixId.prefix "fiscalNumber"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : followsStandard</para>
    ///   <para>rdfs:comment : shows the file standard resources the invoice has^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#followsStandard">edifact-o:followsStandard</a>
    /// </summary>
    let followsStandard = _prefixId.prefix "followsStandard"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenznummer_Regierung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : governmentReferenceNumber</para>
    ///   <para>rdfs:comment : Refernce number given by the goverment^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#governmentReferenceNumber">edifact-o:governmentReferenceNumber</a>
    /// </summary>
    let governmentReferenceNumber = _prefixId.prefix "governmentReferenceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Harmonisiertes_System^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : harmonisedSystem</para>
    ///   <para>rdfs:comment : Contains the number of the harmonised system^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#harmonisedSystem">edifact-o:harmonisedSystem</a>
    /// </summary>
    let harmonisedSystem = _prefixId.prefix "harmonisedSystem"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nummer_harmonisiertes_System^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : harmonisedSystemNumber</para>
    ///   <para>rdfs:comment : Date of the number specifying the goods classification under the Harmonised Commodity Description and Coding System of the Customs Co-operation Council (CCC).^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#harmonisedSystemNumber">edifact-o:harmonisedSystemNumber</a>
    /// </summary>
    let harmonisedSystemNumber = _prefixId.prefix "harmonisedSystemNumber"

    /// <summary>
    ///   <para>edifact-o:seeXML : Zusaetzliche_Produktidentifikation^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAdditionalProductIdentification</para>
    ///   <para>rdfs:comment : Information which specifies and qualifies product identifications.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasAdditionalProductIdentification">edifact-o:hasAdditionalProductIdentification</a>
    /// </summary>
    let hasAdditionalProductIdentification =
        _prefixId.prefix "hasAdditionalProductIdentification"

    /// <summary>
    ///   <para>edifact-o:seeXML : Abschlagsbetrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAllowanceAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of the allowance^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasAllowanceAmount">edifact-o:hasAllowanceAmount</a>
    /// </summary>
    let hasAllowanceAmount = _prefixId.prefix "hasAllowanceAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : AbschlagProzentsatz^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAllowancePercentage</para>
    ///   <para>rdfs:comment : Allowance expressed as a percentage.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasAllowancePercentage">edifact-o:hasAllowancePercentage</a>
    /// </summary>
    let hasAllowancePercentage = _prefixId.prefix "hasAllowancePercentage"

    /// <summary>
    ///   <para>edifact-o:seeXML : AbschlagProzentsatzZahlungsbedingungen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAllowancePercentagePaymentConditions</para>
    ///   <para>rdfs:comment : Allowance expressed as a percentage with payment condition^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasAllowancePercentagePaymentConditions">edifact-o:hasAllowancePercentagePaymentConditions</a>
    /// </summary>
    let hasAllowancePercentagePaymentConditions =
        _prefixId.prefix "hasAllowancePercentagePaymentConditions"

    /// <summary>
    ///   <para>edifact-o:seeXML : Abschlag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAllowanceReason</para>
    ///   <para>rdfs:comment : The reason for the allowance^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasAllowanceReason">edifact-o:hasAllowanceReason</a>
    /// </summary>
    let hasAllowanceReason = _prefixId.prefix "hasAllowanceReason"
    /// <summary>
    ///   <para>edifact-o:seeXML : Faelliger_Betrag_oder_zahlbarerBetrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAmountDueOrPayable^^xsd:string</para>
    ///   <para>rdfs:comment : Amount to be paid</para>
    ///   <a href="https://purl.org/edifact/ontology#hasAmountDueOrPayable">edifact-o:hasAmountDueOrPayable</a>
    /// </summary>
    let hasAmountDueOrPayable = _prefixId.prefix "hasAmountDueOrPayable"
    /// <summary>
    ///   <para>edifact-o:seeXML : Betrag_unterliegt_einer_Preisberichtigung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasAmountUnderPriceAdjustment</para>
    ///   <para>rdfs:comment : Amount which is used as the basis for price adjustment calculation.</para>
    ///   <a href="https://purl.org/edifact/ontology#hasAmountUnderPriceAdjustment">edifact-o:hasAmountUnderPriceAdjustment</a>
    /// </summary>
    let hasAmountUnderPriceAdjustment = _prefixId.prefix "hasAmountUnderPriceAdjustment"
    /// <summary>
    ///   <para>edifact-o:seeXML : Steuergrundbetrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasBasicTaxAmount^^xsd:string</para>
    ///   <para>rdfs:comment : The amount specified is the basis for duty/tax or fee.</para>
    ///   <a href="https://purl.org/edifact/ontology#hasBasicTaxAmount">edifact-o:hasBasicTaxAmount</a>
    /// </summary>
    let hasBasicTaxAmount = _prefixId.prefix "hasBasicTaxAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : Barzahlungsrabatt^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasCashDiscount^^xsd:string</para>
    ///   <para>rdfs:comment : Cash discount given by the seller to the buyer where payment is made in advance of receipt of goods.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasCashDiscount">edifact-o:hasCashDiscount</a>
    /// </summary>
    let hasCashDiscount = _prefixId.prefix "hasCashDiscount"
    /// <summary>
    ///   <para>edifact-o:seeXML : Zu_Abschlagsbasis^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasChargeAllowanceBasis</para>
    ///   <para>rdfs:comment : The amount specified is the basis for calculation of charges/allowance.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasChargeAllowanceBasis">edifact-o:hasChargeAllowanceBasis</a>
    /// </summary>
    let hasChargeAllowanceBasis = _prefixId.prefix "hasChargeAllowanceBasis"
    /// <summary>
    ///   <para>edifact-o:seeXML : Zuschlagsbetrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasChargeAmount</para>
    ///   <para>rdfs:comment : The amont of the charge</para>
    ///   <a href="https://purl.org/edifact/ontology#hasChargeAmount">edifact-o:hasChargeAmount</a>
    /// </summary>
    let hasChargeAmount = _prefixId.prefix "hasChargeAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : ZuschlagProzentsatz^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasChargePercentage</para>
    ///   <para>rdfs:comment : Charge expressed as a percentage.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasChargePercentage">edifact-o:hasChargePercentage</a>
    /// </summary>
    let hasChargePercentage = _prefixId.prefix "hasChargePercentage"

    /// <summary>
    ///   <para>edifact-o:seeXML : ZuschlagProzentsatzZahlungsbedingungen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasChargePercentagePaymentConditions</para>
    ///   <para>rdfs:comment : Charge expressed as a percentage with the payment conditions^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasChargePercentagePaymentConditions">edifact-o:hasChargePercentagePaymentConditions</a>
    /// </summary>
    let hasChargePercentagePaymentConditions =
        _prefixId.prefix "hasChargePercentagePaymentConditions"

    /// <summary>
    ///   <para>edifact-o:seeXML : Zuschlag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasChargeReason</para>
    ///   <para>rdfs:comment : The reason for the charge^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasChargeReason">edifact-o:hasChargeReason</a>
    /// </summary>
    let hasChargeReason = _prefixId.prefix "hasChargeReason"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_3164^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasCity</para>
    ///   <para>rdfs:comment : Cotains the city name of a party involved in the invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasCity">edifact-o:hasCity</a>
    /// </summary>
    let hasCity = _prefixId.prefix "hasCity"
    /// <summary>
    ///   <para>edifact-o:seeXML : Abzug_Rabatt^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDiscountAmount^^xsd:string</para>
    ///   <para>rdfs:comment : The amount specified is the discount amount^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasDiscountAmount">edifact-o:hasDiscountAmount</a>
    /// </summary>
    let hasDiscountAmount = _prefixId.prefix "hasDiscountAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : AbzugProzentsatz^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDiscountPercentage</para>
    ///   <para>rdfs:comment : Discount expressed as a percentage.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasDiscountPercentage">edifact-o:hasDiscountPercentage</a>
    /// </summary>
    let hasDiscountPercentage = _prefixId.prefix "hasDiscountPercentage"

    /// <summary>
    ///   <para>edifact-o:seeXML : AbzugProzentsatzZahlungsbedingungen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDiscountPercentagePaymentConditions</para>
    ///   <para>rdfs:comment : Discount expressed as a percentage with payment condition^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasDiscountPercentagePaymentConditions">edifact-o:hasDiscountPercentagePaymentConditions</a>
    /// </summary>
    let hasDiscountPercentagePaymentConditions =
        _prefixId.prefix "hasDiscountPercentagePaymentConditions"

    /// <summary>
    ///   <para>edifact-o:seeXML : Diskrete_Menge_Einheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDiscreteQuantityWithUnit</para>
    ///   <para>rdfs:comment : The discrete quantity with unit^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasDiscreteQuantityWithUnit">edifact-o:hasDiscreteQuantityWithUnit</a>
    /// </summary>
    let hasDiscreteQuantityWithUnit = _prefixId.prefix "hasDiscreteQuantityWithUnit"
    /// <summary>
    ///   <para>edifact-o:seeXML : Dokumentenfunktion^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDocumentFunction</para>
    ///   <para>rdfs:comment : Indicates the function of the message^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasDocumentFunction">edifact-o:hasDocumentFunction</a>
    /// </summary>
    let hasDocumentFunction = _prefixId.prefix "hasDocumentFunction"
    /// <summary>
    ///   <para>edifact-o:seeXML : Dokumentennummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDocumentNumber</para>
    ///   <para>rdfs:comment : Document/message number^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasDocumentNumber">edifact-o:hasDocumentNumber</a>
    /// </summary>
    let hasDocumentNumber = _prefixId.prefix "hasDocumentNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Dokumentenname^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDocumentType</para>
    ///   <para>rdfs:comment : Document/message identifier expressed^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasDocumentType">edifact-o:hasDocumentType</a>
    /// </summary>
    let hasDocumentType = _prefixId.prefix "hasDocumentType"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDueDate</para>
    ///   <para>rdfs:comment : Due date^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasDueDate">edifact-o:hasDueDate</a>
    /// </summary>
    let hasDueDate = _prefixId.prefix "hasDueDate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Faelliger_Abzugsbetrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDueDeductionAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of the discount due^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasDueDeductionAmount">edifact-o:hasDueDeductionAmount</a>
    /// </summary>
    let hasDueDeductionAmount = _prefixId.prefix "hasDueDeductionAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : Frachtgebuehr^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasFreightCharge^^xsd:string</para>
    ///   <para>rdfs:comment : Amount to be paid for moving goods, by whatever means, from one place to another, inclusive discounts, allowances, rebates, adjustment factors and additional cost relating to freight costs (UN/ECE Recommendation no 23).^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasFreightCharge">edifact-o:hasFreightCharge</a>
    /// </summary>
    let hasFreightCharge = _prefixId.prefix "hasFreightCharge"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_PaFu^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasFunctionInInvoice</para>
    ///   <para>rdfs:comment : Describes the role of a party involved in the invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasFunctionInInvoice">edifact-o:hasFunctionInInvoice</a>
    /// </summary>
    let hasFunctionInInvoice = _prefixId.prefix "hasFunctionInInvoice"
    /// <summary>
    ///   <para>edifact-o:seeXML : Waren_Dienstleistungssteuer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasGSTrate</para>
    ///   <para>rdfs:comment : Tax levied on the final consumption of goods and services throughout the production and distribution chain.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasGSTrate">edifact-o:hasGSTrate</a>
    /// </summary>
    let hasGSTrate = _prefixId.prefix "hasGSTrate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Generelle_Informationen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasGeneralInformation</para>
    ///   <para>rdfs:comment : Contains general information about the Invoice or a Item^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasGeneralInformation">edifact-o:hasGeneralInformation</a>
    /// </summary>
    let hasGeneralInformation = _prefixId.prefix "hasGeneralInformation"
    /// <summary>
    ///   <para>edifact-o:seeXML : Bruttokalkulation^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasGrosspriceOfItem^^xsd:string</para>
    ///   <para>rdfs:comment : The price stated is the gross price per item to which allowances/ charges must be applied.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasGrosspriceOfItem">edifact-o:hasGrosspriceOfItem</a>
    /// </summary>
    let hasGrosspriceOfItem = _prefixId.prefix "hasGrosspriceOfItem"
    /// <summary>
    ///   <para>edifact-o:seeXML : Bruttopreis_pro_Einheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasGrosspricePerUnit^^xsd:string</para>
    ///   <para>rdfs:comment : The price stated is the gross price per unit to which allowances/ charges must be applied.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasGrosspricePerUnit">edifact-o:hasGrosspricePerUnit</a>
    /// </summary>
    let hasGrosspricePerUnit = _prefixId.prefix "hasGrosspricePerUnit"
    /// <summary>
    ///   <para>edifact-o:seeXML : Hoehenmass^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasHeightDimension</para>
    ///   <para>rdfs:comment : Numeric value of height^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasHeightDimension">edifact-o:hasHeightDimension</a>
    /// </summary>
    let hasHeightDimension = _prefixId.prefix "hasHeightDimension"
    /// <summary>
    ///   <para>edifact-o:seeXML : Rechnungsbetrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasInvoiceAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Total sum charged in respect of a single Invoice in accordance with the terms of delivery.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasInvoiceAmount">edifact-o:hasInvoiceAmount</a>
    /// </summary>
    let hasInvoiceAmount = _prefixId.prefix "hasInvoiceAmount"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasInvoiceDetails</para>
    ///   <para>rdfs:comment : Contains the Invoice Details of an Invoice</para>
    ///   <a href="https://purl.org/edifact/ontology#hasInvoiceDetails">edifact-o:hasInvoiceDetails</a>
    /// </summary>
    let hasInvoiceDetails = _prefixId.prefix "hasInvoiceDetails"
    /// <summary>
    ///   <para>edifact-o:seeXML : RechnungsProzentsatz^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasInvoicePercentage</para>
    ///   <para>rdfs:comment : Percentage used in the whole invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasInvoicePercentage">edifact-o:hasInvoicePercentage</a>
    /// </summary>
    let hasInvoicePercentage = _prefixId.prefix "hasInvoicePercentage"

    /// <summary>
    ///   <para>edifact-o:seeXML : RechnungsProzentsatzZahlungsbedingungen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasInvoicePercentagePaymentConditions</para>
    ///   <para>rdfs:comment : Percentage used in the whole invoice with payment conditions^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasInvoicePercentagePaymentConditions">edifact-o:hasInvoicePercentagePaymentConditions</a>
    /// </summary>
    let hasInvoicePercentagePaymentConditions =
        _prefixId.prefix "hasInvoicePercentagePaymentConditions"

    /// <summary>
    ///   <para>edifact-o:seeXML : Rechnungspreis^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasInvoiceprice^^xsd:string</para>
    ///   <para>rdfs:comment : Referenced price taken from an invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasInvoiceprice">edifact-o:hasInvoiceprice</a>
    /// </summary>
    let hasInvoiceprice = _prefixId.prefix "hasInvoiceprice"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasItem</para>
    ///   <para>rdfs:comment : shows which items are included in an invoice</para>
    ///   <a href="https://purl.org/edifact/ontology#hasItem">edifact-o:hasItem</a>
    /// </summary>
    let hasItem = _prefixId.prefix "hasItem"
    /// <summary>
    ///   <para>edifact-o:seeXML : Laengenmassangaben^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasLengthMeasurements</para>
    ///   <para>rdfs:comment : Length of pieces or packages stated for transport purposes^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasLengthMeasurements">edifact-o:hasLengthMeasurements</a>
    /// </summary>
    let hasLengthMeasurements = _prefixId.prefix "hasLengthMeasurements"
    /// <summary>
    ///   <para>edifact-o:seeXML : Positionsbetrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasLineItemAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Goods item total minus allowances plus charges for line item.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasLineItemAmount">edifact-o:hasLineItemAmount</a>
    /// </summary>
    let hasLineItemAmount = _prefixId.prefix "hasLineItemAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nettokalkulation^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasNetPriceOfItem^^xsd:string</para>
    ///   <para>rdfs:comment : The price stated is the net price per item including allowances/ charges. Allowances/charges may be stated for information only.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasNetPriceOfItem">edifact-o:hasNetPriceOfItem</a>
    /// </summary>
    let hasNetPriceOfItem = _prefixId.prefix "hasNetPriceOfItem"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nettonettogewicht^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasNetWeight</para>
    ///   <para>rdfs:comment : Weight (mass) of the goods themselves without any packing^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasNetWeight">edifact-o:hasNetWeight</a>
    /// </summary>
    let hasNetWeight = _prefixId.prefix "hasNetWeight"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nettogewicht_pro_Einheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasNetWeightPerUnit</para>
    ///   <para>rdfs:comment : Weight (mass) of goods including any packing normally going with them to a buyer in a retail sale^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasNetWeightPerUnit">edifact-o:hasNetWeightPerUnit</a>
    /// </summary>
    let hasNetWeightPerUnit = _prefixId.prefix "hasNetWeightPerUnit"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nettopreis_pro_Einheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasNetpricePerUnit^^xsd:string</para>
    ///   <para>rdfs:comment : The price stated is the net price per unit including allowances/ charges. Allowances/charges may be stated for information only.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasNetpricePerUnit">edifact-o:hasNetpricePerUnit</a>
    /// </summary>
    let hasNetpricePerUnit = _prefixId.prefix "hasNetpricePerUnit"
    /// <summary>
    ///   <para>edifact-o:seeXML : Zahlungskuerzung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPaymentDiscountAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of the payment discount^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasPaymentDiscountAmount">edifact-o:hasPaymentDiscountAmount</a>
    /// </summary>
    let hasPaymentDiscountAmount = _prefixId.prefix "hasPaymentDiscountAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : Strafbetrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPenaltyAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of the penalty^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasPenaltyAmount">edifact-o:hasPenaltyAmount</a>
    /// </summary>
    let hasPenaltyAmount = _prefixId.prefix "hasPenaltyAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : StrafProzentsatz^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPenaltyPercentage</para>
    ///   <para>rdfs:comment : Penalty expressed as a percentage.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasPenaltyPercentage">edifact-o:hasPenaltyPercentage</a>
    /// </summary>
    let hasPenaltyPercentage = _prefixId.prefix "hasPenaltyPercentage"

    /// <summary>
    ///   <para>edifact-o:seeXML : StrafProzentsatzZahlungsbedingungen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPenaltyPercentagePaymentConditions</para>
    ///   <para>rdfs:comment : Penalty expressed as a percentage with payment conditions^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasPenaltyPercentagePaymentConditions">edifact-o:hasPenaltyPercentagePaymentConditions</a>
    /// </summary>
    let hasPenaltyPercentagePaymentConditions =
        _prefixId.prefix "hasPenaltyPercentagePaymentConditions"

    /// <summary>
    ///   <para>edifact-o:seeXML : Physische_Abmessung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPhysicalDimension</para>
    ///   <para>rdfs:comment : Specified measurement dimensions refer to physical dimensions of a product, material or package^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasPhysicalDimension">edifact-o:hasPhysicalDimension</a>
    /// </summary>
    let hasPhysicalDimension = _prefixId.prefix "hasPhysicalDimension"
    /// <summary>
    ///   <para>edifact-o:seeXML : Vorausbezahlter_Betrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPrepaidAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Amount which has been prepaid in advance^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasPrepaidAmount">edifact-o:hasPrepaidAmount</a>
    /// </summary>
    let hasPrepaidAmount = _prefixId.prefix "hasPrepaidAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : PreisQuelle^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPriceSource</para>
    ///   <para>rdfs:comment : Identification of the type of price of an item^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasPriceSource">edifact-o:hasPriceSource</a>
    /// </summary>
    let hasPriceSource = _prefixId.prefix "hasPriceSource"
    /// <summary>
    ///   <para>edifact-o:seeXML : PreisArt^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPriceType</para>
    ///   <para>rdfs:comment : Identification pricing specification^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasPriceType">edifact-o:hasPriceType</a>
    /// </summary>
    let hasPriceType = _prefixId.prefix "hasPriceType"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_PRIMaEinheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPriceUnit</para>
    ///   <para>rdfs:comment : Contains measure unit qualifier of a price^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasPriceUnit">edifact-o:hasPriceUnit</a>
    /// </summary>
    let hasPriceUnit = _prefixId.prefix "hasPriceUnit"
    /// <summary>
    ///   <para>edifact-o:seeXML : Produktidentifikation^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasProductIdentification</para>
    ///   <para>rdfs:comment : Identification of the product^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasProductIdentification">edifact-o:hasProductIdentification</a>
    /// </summary>
    let hasProductIdentification = _prefixId.prefix "hasProductIdentification"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_QTYMaEinheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasQuantityUnit</para>
    ///   <para>rdfs:comment : Contains measure unit qualifier of a quantity^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasQuantityUnit">edifact-o:hasQuantityUnit</a>
    /// </summary>
    let hasQuantityUnit = _prefixId.prefix "hasQuantityUnit"
    /// <summary>
    ///   <para>edifact-o:seeXML : Uebermittelter_Betrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasRemittedtAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Amount which was remitted</para>
    ///   <a href="https://purl.org/edifact/ontology#hasRemittedtAmount">edifact-o:hasRemittedtAmount</a>
    /// </summary>
    let hasRemittedtAmount = _prefixId.prefix "hasRemittedtAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : geforderter_Liefertermin^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasRequiredDeliveryDate</para>
    ///   <para>rdfs:comment : Date on which buyer requests goods to be delivered.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasRequiredDeliveryDate">edifact-o:hasRequiredDeliveryDate</a>
    /// </summary>
    let hasRequiredDeliveryDate = _prefixId.prefix "hasRequiredDeliveryDate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Lagerbeschraenkung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasStockRestriction</para>
    ///   <para>rdfs:comment : A measurement indicating limitation in relation to storage.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasStockRestriction">edifact-o:hasStockRestriction</a>
    /// </summary>
    let hasStockRestriction = _prefixId.prefix "hasStockRestriction"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTAXrate</para>
    ///   <para>rdfs:comment : Contains the TAX rate^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTAXrate">edifact-o:hasTAXrate</a>
    /// </summary>
    let hasTAXrate = _prefixId.prefix "hasTAXrate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Steuerbetrag</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTaxAmount</para>
    ///   <para>rdfs:comment : Tax imposed by government or other official authority related to the weight/volume charge or valuation charge</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTaxAmount">edifact-o:hasTaxAmount</a>
    /// </summary>
    let hasTaxAmount = _prefixId.prefix "hasTaxAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : Steuerpflichtiger_Betrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTaxableAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Amount for tax calculation^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTaxableAmount">edifact-o:hasTaxableAmount</a>
    /// </summary>
    let hasTaxableAmount = _prefixId.prefix "hasTaxableAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : Faelligkeitsdatum_bei_Skontoabzug^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTermsDiscountDueDate</para>
    ///   <para>rdfs:comment : Date by which payment should be made if discount terms are to apply.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTermsDiscountDueDate">edifact-o:hasTermsDiscountDueDate</a>
    /// </summary>
    let hasTermsDiscountDueDate = _prefixId.prefix "hasTermsDiscountDueDate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Faelligkeitsdatum_bei_Zahlung_ohne_Abzug^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTermsNetDueDate</para>
    ///   <para>rdfs:comment : Date by which payment must be made^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTermsNetDueDate">edifact-o:hasTermsNetDueDate</a>
    /// </summary>
    let hasTermsNetDueDate = _prefixId.prefix "hasTermsNetDueDate"

    /// <summary>
    ///   <para>edifact-o:seeXML : GesamtZu_Abschlaege^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTotalAdditionsAndDeductions^^xsd:string</para>
    ///   <para>rdfs:comment : The amount specified is the total of all charges/allowances.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTotalAdditionsAndDeductions">edifact-o:hasTotalAdditionsAndDeductions</a>
    /// </summary>
    let hasTotalAdditionsAndDeductions =
        _prefixId.prefix "hasTotalAdditionsAndDeductions"

    /// <summary>
    ///   <para>edifact-o:seeXML : Gesamtbetrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTotalAmount^^xsd:string</para>
    ///   <para>rdfs:comment : The amount specified is the total amount^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTotalAmount">edifact-o:hasTotalAmount</a>
    /// </summary>
    let hasTotalAmount = _prefixId.prefix "hasTotalAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : Gesamtbetrag_Nachricht^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTotalAmountMessage^^xsd:string</para>
    ///   <para>rdfs:comment : The total Amount of the Message^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTotalAmountMessage">edifact-o:hasTotalAmountMessage</a>
    /// </summary>
    let hasTotalAmountMessage = _prefixId.prefix "hasTotalAmountMessage"

    /// <summary>
    ///   <para>edifact-o:seeXML : Gesamtbetrag_unterliegt_Zahlungskuerzung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTotalAmountUnderPaymentReduction</para>
    ///   <para>rdfs:comment : Part of the invoice amount which is subject to payment discount.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTotalAmountUnderPaymentReduction">edifact-o:hasTotalAmountUnderPaymentReduction</a>
    /// </summary>
    let hasTotalAmountUnderPaymentReduction =
        _prefixId.prefix "hasTotalAmountUnderPaymentReduction"

    /// <summary>
    ///   <para>edifact-o:seeXML : Gesamter_Zoll_Steuer_Gebuehrenbetrag_der_Nachricht^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTotalDutyTasFeeAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Total of all duty/tax/fee amounts.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTotalDutyTaxFeeAmount">edifact-o:hasTotalDutyTaxFeeAmount</a>
    /// </summary>
    let hasTotalDutyTaxFeeAmount = _prefixId.prefix "hasTotalDutyTaxFeeAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : WarenpositionInsgesamt^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTotalGoodsPosition^^xsd:string</para>
    ///   <para>rdfs:comment : Net price x quantity for the line item^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTotalGoodsPosition">edifact-o:hasTotalGoodsPosition</a>
    /// </summary>
    let hasTotalGoodsPosition = _prefixId.prefix "hasTotalGoodsPosition"
    /// <summary>
    ///   <para>edifact-o:seeXML : Gesamtpositionsbetrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTotalLineItemAmount^^xsd:string</para>
    ///   <para>rdfs:comment : The sum of all the line item amounts.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTotalLineItemAmount">edifact-o:hasTotalLineItemAmount</a>
    /// </summary>
    let hasTotalLineItemAmount = _prefixId.prefix "hasTotalLineItemAmount"
    /// <summary>
    ///   <para>edifact-o:seeXML : Beschraekung_Transportmittels^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTransportRestriction</para>
    ///   <para>rdfs:comment : A measurement indicating limitations in relation to transportation equipment.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasTransportRestriction">edifact-o:hasTransportRestriction</a>
    /// </summary>
    let hasTransportRestriction = _prefixId.prefix "hasTransportRestriction"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_MaEinheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasUnit</para>
    ///   <para>rdfs:comment : Contains measure unit qualifier^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasUnit">edifact-o:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>edifact-o:seeXML : Preis_pro_Einheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasUnitPrice^^xsd:string</para>
    ///   <para>rdfs:comment : Reporting monetary amount is a 'per unit' amount^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasUnitPrice">edifact-o:hasUnitPrice</a>
    /// </summary>
    let hasUnitPrice = _prefixId.prefix "hasUnitPrice"
    /// <summary>
    ///   <para>edifact-o:seeXML : Umsatzsteuernummer_Kaeufer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasVATIdentifierBuyer</para>
    ///   <para>rdfs:comment : Unique number assigned by the relevant tax authority to identify the buyer for use in relation to Value Added Tax (VAT).^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasVATIdentifierBuyer">edifact-o:hasVATIdentifierBuyer</a>
    /// </summary>
    let hasVATIdentifierBuyer = _prefixId.prefix "hasVATIdentifierBuyer"
    /// <summary>
    ///   <para>edifact-o:seeXML : Umsatzsteuernummer_Lieferanschrift^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasVATIdentifierDeliveryParty</para>
    ///   <para>rdfs:comment : Unique number assigned by the relevant tax authority to identify the delivery party for use in relation to Value Added Tax (VAT).^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasVATIdentifierDeliveryParty">edifact-o:hasVATIdentifierDeliveryParty</a>
    /// </summary>
    let hasVATIdentifierDeliveryParty = _prefixId.prefix "hasVATIdentifierDeliveryParty"
    /// <summary>
    ///   <para>edifact-o:seeXML : Umsatzsteuernummer_Rechnungsempfaenger^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasVATIdentifierInvoicee</para>
    ///   <para>rdfs:comment : Unique number assigned by the relevant tax authority to identify the invoicee for use in relation to Value Added Tax (VAT).^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasVATIdentifierInvoicee">edifact-o:hasVATIdentifierInvoicee</a>
    /// </summary>
    let hasVATIdentifierInvoicee = _prefixId.prefix "hasVATIdentifierInvoicee"
    /// <summary>
    ///   <para>edifact-o:seeXML : Umsatzsteuernummer_Bezahler^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasVATIdentifierPayer</para>
    ///   <para>rdfs:comment : Unique number assigned by the relevant tax authority to identify the payer for use in relation to Value Added Tax (VAT).^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasVATIdentifierPayer">edifact-o:hasVATIdentifierPayer</a>
    /// </summary>
    let hasVATIdentifierPayer = _prefixId.prefix "hasVATIdentifierPayer"
    /// <summary>
    ///   <para>edifact-o:seeXML : Umsatzsteuernummer_Lieferant^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasVATIdentifierSupplier</para>
    ///   <para>rdfs:comment : Unique number assigned by the relevant tax authority to identify the supplier for use in relation to Value Added Tax (VAT).^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasVATIdentifierSupplier">edifact-o:hasVATIdentifierSupplier</a>
    /// </summary>
    let hasVATIdentifierSupplier = _prefixId.prefix "hasVATIdentifierSupplier"
    /// <summary>
    ///   <para>edifact-o:seeXML : Mehrwertsteuer_Betrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasVATamount^^xsd:string</para>
    ///   <para>rdfs:comment : Amount in national currency resulting from the application, at the appropriate rate, of value added tax (or similar tax) to the invoice amount subject to such tax^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasVATamount">edifact-o:hasVATamount</a>
    /// </summary>
    let hasVATamount = _prefixId.prefix "hasVATamount"
    /// <summary>
    ///   <para>edifact-o:seeXML : Umsatzsteuer_erster_Wert^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasVATfirstValue^^xsd:string</para>
    ///   <para>rdfs:comment : First VAT value if, for the same rate of VAT, there are 1 to 3 different ways to set this value^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasVATfirstValue">edifact-o:hasVATfirstValue</a>
    /// </summary>
    let hasVATfirstValue = _prefixId.prefix "hasVATfirstValue"
    /// <summary>
    ///   <para>edifact-o:seeXML : Mehrwertsteuer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasVATrate</para>
    ///   <para>rdfs:comment : A tax on domestic or imported goods applied to the value added at each stage in the production/distribution cycle.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#hasVATrate">edifact-o:hasVATrate</a>
    /// </summary>
    let hasVATrate = _prefixId.prefix "hasVATrate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Import_Lizenznummer</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : importLicenseNumber</para>
    ///   <para>rdfs:comment : Reference number assigned by the issuing authority to an Import Licence.</para>
    ///   <a href="https://purl.org/edifact/ontology#importLicenseNumber">edifact-o:importLicenseNumber</a>
    /// </summary>
    let importLicenseNumber = _prefixId.prefix "importLicenseNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Informatioen_zur_Zollerklaerung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : informationCustomsDeclaration</para>
    ///   <para>rdfs:comment : Note contains customs declaration information.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#informationCustomsDeclaration">edifact-o:informationCustomsDeclaration</a>
    /// </summary>
    let informationCustomsDeclaration = _prefixId.prefix "informationCustomsDeclaration"
    /// <summary>
    ///   <para>edifact-o:seeXML : Anweisung_fur_Rechnungssteller^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : instructionForInvoicingParty</para>
    ///   <para>rdfs:comment : Note contains invoice instructions^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#instructionForInvoicingParty">edifact-o:instructionForInvoicingParty</a>
    /// </summary>
    let instructionForInvoicingParty = _prefixId.prefix "instructionForInvoicingParty"
    /// <summary>
    ///   <para>edifact-o:seeXML : Interne_Kundennummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : internalCustomerNumber</para>
    ///   <para>rdfs:comment : Number assigned by a seller, supplier etc. to identify a customer within his enterprise.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#internalCustomerNumber">edifact-o:internalCustomerNumber</a>
    /// </summary>
    let internalCustomerNumber = _prefixId.prefix "internalCustomerNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Interne_Verkaufsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : internalVendorNumber</para>
    ///   <para>rdfs:comment : Number identifying the company-internal vending department/unit.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#internalVendorNumber">edifact-o:internalVendorNumber</a>
    /// </summary>
    let internalVendorNumber = _prefixId.prefix "internalVendorNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : International_Article_Number^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : internationalArticleNumber</para>
    ///   <para>rdfs:comment : Number assigned to a manufacturer's product according to the International Article Numbering Association.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#internationalArticleNumber">edifact-o:internationalArticleNumber</a>
    /// </summary>
    let internationalArticleNumber = _prefixId.prefix "internationalArticleNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : WaehrungRechnung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : invoiceCurrency</para>
    ///   <para>rdfs:comment : The name or symbol of the monetary unit used for calculation in an invoice.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#invoiceCurrency">edifact-o:invoiceCurrency</a>
    /// </summary>
    let invoiceCurrency = _prefixId.prefix "invoiceCurrency"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isInvoiceDetailsOf</para>
    ///   <para>rdfs:comment : shows to which Invoice the Invoice Details belong</para>
    ///   <a href="https://purl.org/edifact/ontology#isInvoiceDetailsOf">edifact-o:isInvoiceDetailsOf</a>
    /// </summary>
    let isInvoiceDetailsOf = _prefixId.prefix "isInvoiceDetailsOf"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isItemOf</para>
    ///   <para>rdfs:comment : shows to which Invoice the item belongsrdfs:comment : zeigt an zu welcher Rechnung der Artikel gehört</para>
    ///   <a href="https://purl.org/edifact/ontology#isItemOf">edifact-o:isItemOf</a>
    /// </summary>
    let isItemOf = _prefixId.prefix "isItemOf"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isStandardOf</para>
    ///   <para>rdfs:comment : shows of which invoice the EDIFACT Structure is</para>
    ///   <a href="https://purl.org/edifact/ontology#isStandardOf">edifact-o:isStandardOf</a>
    /// </summary>
    let isStandardOf = _prefixId.prefix "isStandardOf"
    /// <summary>
    ///   <para>edifact-o:seeXML : Artikelnummer_des_Kaeufer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : itemNumberBuyer</para>
    ///   <para>rdfs:comment : Item number assigned by the buyer to identify an article.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#itemNumberBuyer">edifact-o:itemNumberBuyer</a>
    /// </summary>
    let itemNumberBuyer = _prefixId.prefix "itemNumberBuyer"
    /// <summary>
    ///   <para>edifact-o:seeXML : Artikelnummer_des_Herstellers^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : itemNumberManufacturer</para>
    ///   <para>rdfs:comment : The number given to an article by its manufacturer.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#itemNumberManufacturer">edifact-o:itemNumberManufacturer</a>
    /// </summary>
    let itemNumberManufacturer = _prefixId.prefix "itemNumberManufacturer"
    /// <summary>
    ///   <para>edifact-o:seeXML : Artikelnummer_des_Lieferanten^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : itemNumberSupplier</para>
    ///   <para>rdfs:comment : Number assigned to an article by the supplier of that article.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#itemNumberSupplier">edifact-o:itemNumberSupplier</a>
    /// </summary>
    let itemNumberSupplier = _prefixId.prefix "itemNumberSupplier"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenznummer_der_Position^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : lineItemReferenceNumber</para>
    ///   <para>rdfs:comment : Reference number identifying a particular line in a document.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#lineItemReferenceNumber">edifact-o:lineItemReferenceNumber</a>
    /// </summary>
    let lineItemReferenceNumber = _prefixId.prefix "lineItemReferenceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Belastungsperiode^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : loadPeriod</para>
    ///   <para>rdfs:comment : Period a specified charge is valid for.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#loadPeriod">edifact-o:loadPeriod</a>
    /// </summary>
    let loadPeriod = _prefixId.prefix "loadPeriod"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_0051^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>edifact-o:seeEDIFACT : D_0051^^xsd:string</para>
    ///   <para>rdfs:comment : Identification of the managing organization^^xsd:string</para>
    ///   <para>rdfs:label : managingOrganisations</para>
    ///   <a href="https://purl.org/edifact/ontology#managingOrganisations">edifact-o:managingOrganisations</a>
    /// </summary>
    let managingOrganisations = _prefixId.prefix "managingOrganisations"
    /// <summary>
    ///   <para>edifact-o:seeEDIFACT : D_0062^^xsd:string</para>
    ///   <para>rdfs:label : messageReferenceNumber</para>
    ///   <para>rdfs:comment : The reference number of the message^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>edifact-o:seeXML : D_0062^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#messageReferenceNumber">edifact-o:messageReferenceNumber</a>
    /// </summary>
    let messageReferenceNumber = _prefixId.prefix "messageReferenceNumber"
    /// <summary>
    ///   <para>rdfs:comment : The identifier of the message type^^xsd:string</para>
    ///   <para>edifact-o:seeXML : D_0065^^xsd:string</para>
    ///   <para>edifact-o:seeEDIFACT : D_0065^^xsd:string</para>
    ///   <para>rdfs:label : messageTypeIdentifier</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#messageTypeIdentifier">edifact-o:messageTypeIdentifier</a>
    /// </summary>
    let messageTypeIdentifier = _prefixId.prefix "messageTypeIdentifier"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nationaler_Produktgruppencode^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : nationalProductGroupCode</para>
    ///   <para>rdfs:comment : National product group code. Administered by a national agency.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#nationalProductGroupCode">edifact-o:nationalProductGroupCode</a>
    /// </summary>
    let nationalProductGroupCode = _prefixId.prefix "nationalProductGroupCode"
    /// <summary>
    ///   <para>edifact-o:seeXML : Kein_Abschlag_Zuschlag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : noDiscountAllowance</para>
    ///   <para>rdfs:comment : No increases or reduction in price (list or stated) are included.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#noDiscountAllowance">edifact-o:noDiscountAllowance</a>
    /// </summary>
    let noDiscountAllowance = _prefixId.prefix "noDiscountAllowance"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : noteNumber</para>
    ///   <para>rdfs:comment : identifier which is a number^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#noteNumber">edifact-o:noteNumber</a>
    /// </summary>
    let noteNumber = _prefixId.prefix "noteNumber"

    /// <summary>
    ///   <para>edifact-o:seeXML : Nummer_einr_konsolidierten_Rechnung_EAN_Code^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : numberConsolidatedInvoiceEANCode</para>
    ///   <para>rdfs:comment : Consolidated invoice number with EAN code^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#numberConsolidatedInvoiceEANCode">edifact-o:numberConsolidatedInvoiceEANCode</a>
    /// </summary>
    let numberConsolidatedInvoiceEANCode =
        _prefixId.prefix "numberConsolidatedInvoiceEANCode"

    /// <summary>
    ///   <para>edifact-o:seeXML : Nummer_eines_Buendels_von_Nachrichten^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : numberOfBundleMessages</para>
    ///   <para>rdfs:comment : A batch number identifying a batch of messages.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#numberOfBundleMessages">edifact-o:numberOfBundleMessages</a>
    /// </summary>
    let numberOfBundleMessages = _prefixId.prefix "numberOfBundleMessages"
    /// <summary>
    ///   <para>edifact-o:seeXML : Angebotsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : offerNumber</para>
    ///   <para>rdfs:comment : Reference number assigned by issuing party to an offer.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#offerNumber">edifact-o:offerNumber</a>
    /// </summary>
    let offerNumber = _prefixId.prefix "offerNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : WaehrungBestellung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : orderCurrency</para>
    ///   <para>rdfs:comment : The name or symbol of the monetary unit used in an order.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#orderCurrency">edifact-o:orderCurrency</a>
    /// </summary>
    let orderCurrency = _prefixId.prefix "orderCurrency"
    /// <summary>
    ///   <para>edifact-o:seeXML : Bestelldatum^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : orderDate</para>
    ///   <para>rdfs:comment : Date when an order is issued.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#orderDate">edifact-o:orderDate</a>
    /// </summary>
    let orderDate = _prefixId.prefix "orderDate"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : orderNumber</para>
    ///   <para>rdfs:comment : Reference number of an order.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#orderNumber">edifact-o:orderNumber</a>
    /// </summary>
    let orderNumber = _prefixId.prefix "orderNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Auftragsnummer_Kaeufer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : orderNumberBuyer</para>
    ///   <para>rdfs:comment : Reference number assigned by the buyer to an order.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#orderNumberBuyer">edifact-o:orderNumberBuyer</a>
    /// </summary>
    let orderNumberBuyer = _prefixId.prefix "orderNumberBuyer"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nummer_Lieferauftrag^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : orderNumberDelivery</para>
    ///   <para>rdfs:comment : Reference number assigned by issuer to a delivery order.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#orderNumberDelivery">edifact-o:orderNumberDelivery</a>
    /// </summary>
    let orderNumberDelivery = _prefixId.prefix "orderNumberDelivery"
    /// <summary>
    ///   <para>edifact-o:seeXML : Auftragsnummer_Lieferant^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : orderNumberSupplier</para>
    ///   <para>rdfs:comment : Reference number assigned by supplier to a buyer's purchase order.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#orderNumberSupplier">edifact-o:orderNumberSupplier</a>
    /// </summary>
    let orderNumberSupplier = _prefixId.prefix "orderNumberSupplier"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenz_des_Absenders^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : originatorReference</para>
    ///   <para>rdfs:comment : Reference of the originator^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#originatorReference">edifact-o:originatorReference</a>
    /// </summary>
    let originatorReference = _prefixId.prefix "originatorReference"
    /// <summary>
    ///   <para>edifact-o:seeXML : Andere_Serviceinformationen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : otherServiceInformation</para>
    ///   <para>rdfs:comment : General information created by the sender of general or specific value.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#otherServiceInformation">edifact-o:otherServiceInformation</a>
    /// </summary>
    let otherServiceInformation = _prefixId.prefix "otherServiceInformation"
    /// <summary>
    ///   <para>edifact-o:seeXML : Teilnummer_des_Kaeufers^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : partNumberBuyer</para>
    ///   <para>rdfs:comment : Reference number assigned by the buyer to identify an article.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#partNumberBuyer">edifact-o:partNumberBuyer</a>
    /// </summary>
    let partNumberBuyer = _prefixId.prefix "partNumberBuyer"
    /// <summary>
    ///   <para>edifact-o:seeXML : ZahlungsbedingungsArt^^xsd:string</para>
    ///   <para>edifact-o:seeEDIFACT : 4279^^xsd:integer</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : paymentCondition</para>
    ///   <para>rdfs:comment : Type of the payment terms^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#paymentCondition">edifact-o:paymentCondition</a>
    /// </summary>
    let paymentCondition = _prefixId.prefix "paymentCondition"
    /// <summary>
    ///   <para>edifact-o:seeXML : WaehrungZahlung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : paymentCurrency</para>
    ///   <para>rdfs:comment : The name or symbol of the monetary unit used for payment.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#paymentCurrency">edifact-o:paymentCurrency</a>
    /// </summary>
    let paymentCurrency = _prefixId.prefix "paymentCurrency"
    /// <summary>
    ///   <para>edifact-o:seeXML : Zahlungsreferenz^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : paymentReference</para>
    ///   <para>rdfs:comment : Reference number assigned to a payment.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#paymentReference">edifact-o:paymentReference</a>
    /// </summary>
    let paymentReference = _prefixId.prefix "paymentReference"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : percentage</para>
    ///   <para>rdfs:comment : Contains percentage^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#percentage">edifact-o:percentage</a>
    /// </summary>
    let percentage = _prefixId.prefix "percentage"
    /// <summary>
    ///   <para>edifact-o:seeXML : Positionszeilennummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : positionLineNumber</para>
    ///   <para>rdfs:comment : Number of the Position of the Line in the whole message^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#positionLineNumber">edifact-o:positionLineNumber</a>
    /// </summary>
    let positionLineNumber = _prefixId.prefix "positionLineNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : PreisUndAuslieferungsbedingung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : priceAndDeliveryCondition</para>
    ///   <para>rdfs:comment : Price and Delivery Conditions of the article displayed in the invoice^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#priceAndDeliveryCondition">edifact-o:priceAndDeliveryCondition</a>
    /// </summary>
    let priceAndDeliveryCondition = _prefixId.prefix "priceAndDeliveryCondition"
    /// <summary>
    ///   <para>edifact-o:seeXML : Preis_Bedingungen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : priceCondition</para>
    ///   <para>rdfs:comment : Condition of the Price^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#priceCondition">edifact-o:priceCondition</a>
    /// </summary>
    let priceCondition = _prefixId.prefix "priceCondition"
    /// <summary>
    ///   <para>edifact-o:seeXML : WaehrungPreisangabe^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : priceCurrency</para>
    ///   <para>rdfs:comment : The name or symbol of the monetary unit used for pricing purposes^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#priceCurrency">edifact-o:priceCurrency</a>
    /// </summary>
    let priceCurrency = _prefixId.prefix "priceCurrency"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nummer_der_Preisliste^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : priceListNumber</para>
    ///   <para>rdfs:comment : Reference number assigned to a price list.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#priceListNumber">edifact-o:priceListNumber</a>
    /// </summary>
    let priceListNumber = _prefixId.prefix "priceListNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Proforma_Rechnungsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : proformaInvoiceNumber</para>
    ///   <para>rdfs:comment : Reference number assigned by the seller to a Proforma Invoice.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#proformaInvoiceNumber">edifact-o:proformaInvoiceNumber</a>
    /// </summary>
    let proformaInvoiceNumber = _prefixId.prefix "proformaInvoiceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Nummer_der_Aktionsvariante^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : promotionalVariantNumber</para>
    ///   <para>rdfs:comment : Number of the promotional variant number^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#promotionalVariantNumber">edifact-o:promotionalVariantNumber</a>
    /// </summary>
    let promotionalVariantNumber = _prefixId.prefix "promotionalVariantNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Beschaffungsinformation^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : purchasingInformation</para>
    ///   <para>rdfs:comment : Note contains purchasing information.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#purchasingInformation">edifact-o:purchasingInformation</a>
    /// </summary>
    let purchasingInformation = _prefixId.prefix "purchasingInformation"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : quantity</para>
    ///   <para>rdfs:comment : display a quantity^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#quantity">edifact-o:quantity</a>
    /// </summary>
    let quantity = _prefixId.prefix "quantity"
    /// <summary>
    ///   <para>edifact-o:seeXML : Wareneingangsdatum^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : receiptGoodsDate</para>
    ///   <para>rdfs:comment : Date/time upon which the goods were received by a given party.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#receiptGoodsDate">edifact-o:receiptGoodsDate</a>
    /// </summary>
    let receiptGoodsDate = _prefixId.prefix "receiptGoodsDate"
    /// <summary>
    ///   <para>edifact-o:seeXML : Wareneingangsmeldung_Nummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : receivingAdviceNumber</para>
    ///   <para>rdfs:comment : A reference number to a receiving advice.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#receivingAdviceNumber">edifact-o:receivingAdviceNumber</a>
    /// </summary>
    let receivingAdviceNumber = _prefixId.prefix "receivingAdviceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_0010^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : recipientIndicator</para>
    ///   <para>rdfs:comment : Indiactor whos the recipient of the message^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#recipientIndicator">edifact-o:recipientIndicator</a>
    /// </summary>
    let recipientIndicator = _prefixId.prefix "recipientIndicator"
    /// <summary>
    ///   <para>edifact-o:seeXML : Menge_Erhalten_und_akzeptiert^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : recivedAndAcceptedQuantity</para>
    ///   <para>rdfs:comment : Quantity which has been received and accepted at a given location.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#recivedAndAcceptedQuantity">edifact-o:recivedAndAcceptedQuantity</a>
    /// </summary>
    let recivedAndAcceptedQuantity = _prefixId.prefix "recivedAndAcceptedQuantity"

    /// <summary>
    ///   <para>edifact-o:seeXML : Erhalten_und_akzeptiert_Einheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : recivedAndAcceptedQuantityWithUnit</para>
    ///   <para>rdfs:comment : Quantity which has been received and accepted at a given location with the unit^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#recivedAndAcceptedQuantityWithUnit">edifact-o:recivedAndAcceptedQuantityWithUnit</a>
    /// </summary>
    let recivedAndAcceptedQuantityWithUnit =
        _prefixId.prefix "recivedAndAcceptedQuantityWithUnit"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzdatum^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : referenceDate</para>
    ///   <para>rdfs:comment : Reference Date^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#referenceDate">edifact-o:referenceDate</a>
    /// </summary>
    let referenceDate = _prefixId.prefix "referenceDate"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenznummer_zu_einem_Geschaeftskontauszug_EAN_Code^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : referenceNumberBusinessContactExtractEANCode</para>
    ///   <para>rdfs:comment : Reference number for a business account statement as EAN code^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#referenceNumberBusinessContactExtractEANCode">edifact-o:referenceNumberBusinessContactExtractEANCode</a>
    /// </summary>
    let referenceNumberBusinessContactExtractEANCode =
        _prefixId.prefix "referenceNumberBusinessContactExtractEANCode"

    /// <summary>
    ///   <para>edifact-o:seeXML : Referenzsnummer_des_Kunden^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : referenceNumberCustomer</para>
    ///   <para>rdfs:comment : Reference number assigned by the customer to a transaction.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#referenceNumberCustomer">edifact-o:referenceNumberCustomer</a>
    /// </summary>
    let referenceNumberCustomer = _prefixId.prefix "referenceNumberCustomer"
    /// <summary>
    ///   <para>edifact-o:seeXML : zugehoerige_Dokumentennummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : relatedDocumentNumber</para>
    ///   <para>rdfs:comment : Related document number^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#relatedDocumentNumber">edifact-o:relatedDocumentNumber</a>
    /// </summary>
    let relatedDocumentNumber = _prefixId.prefix "relatedDocumentNumber"
    /// <summary>
    ///   <para>rdfs:label : releaseNumberMessageType</para>
    ///   <para>rdfs:comment : Release number within the current message version number.^^xsd:string</para>
    ///   <para>edifact-o:seeEDIFACT : D_0054^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>edifact-o:seeXML : D_0054^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#releaseNumberMessageType">edifact-o:releaseNumberMessageType</a>
    /// </summary>
    let releaseNumberMessageType = _prefixId.prefix "releaseNumberMessageType"
    /// <summary>
    ///   <para>edifact-o:seeXML : Meldeinformationen^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : reportingInformation</para>
    ///   <para>rdfs:comment : The free text contains information for regulatory authority.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#reportingInformation">edifact-o:reportingInformation</a>
    /// </summary>
    let reportingInformation = _prefixId.prefix "reportingInformation"
    /// <summary>
    ///   <para>edifact-o:seeXML : Menge_Retour^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : returnQuantity</para>
    ///   <para>rdfs:comment : The return quantity^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#returnQuantity">edifact-o:returnQuantity</a>
    /// </summary>
    let returnQuantity = _prefixId.prefix "returnQuantity"
    /// <summary>
    ///   <para>edifact-o:seeXML : Retourmenge_Einheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : returnQuantityWithUnit</para>
    ///   <para>rdfs:comment : The return quantity with unit^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#returnQuantityWithUnit">edifact-o:returnQuantityWithUnit</a>
    /// </summary>
    let returnQuantityWithUnit = _prefixId.prefix "returnQuantityWithUnit"
    /// <summary>
    ///   <para>rdfs:label : seeEDIFACT</para>
    ///   <a href="https://purl.org/edifact/ontology#seeEDIFACT">edifact-o:seeEDIFACT</a>
    /// </summary>
    let seeEDIFACT = _prefixId.prefix "seeEDIFACT"
    /// <summary>
    ///   <para>rdfs:label : seeXML</para>
    ///   <a href="https://purl.org/edifact/ontology#seeXML">edifact-o:seeXML</a>
    /// </summary>
    let seeXML = _prefixId.prefix "seeXML"
    /// <summary>
    ///   <para>edifact-o:seeXML : Referenznummer_des_Verkaeufers^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : sellersReferenceNumber</para>
    ///   <para>rdfs:comment : Reference number assigned to a transaction by the seller^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#sellersReferenceNumber">edifact-o:sellersReferenceNumber</a>
    /// </summary>
    let sellersReferenceNumber = _prefixId.prefix "sellersReferenceNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_0004^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : senderIndicator</para>
    ///   <para>rdfs:comment : Indicator who the sender is^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#senderIndicator">edifact-o:senderIndicator</a>
    /// </summary>
    let senderIndicator = _prefixId.prefix "senderIndicator"
    /// <summary>
    ///   <para>edifact-o:seeXML : Spezifikationsnummer^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : specificationNumber</para>
    ///   <para>rdfs:comment : Number assigned by the issuer to his specification.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#specificationNumber">edifact-o:specificationNumber</a>
    /// </summary>
    let specificationNumber = _prefixId.prefix "specificationNumber"
    /// <summary>
    ///   <para>edifact-o:seeXML : Lieferantenhinweis^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : supplierNote</para>
    ///   <para>rdfs:comment : Remarks from or for a supplier of goods or services.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#supplierNote">edifact-o:supplierNote</a>
    /// </summary>
    let supplierNote = _prefixId.prefix "supplierNote"
    /// <summary>
    ///   <para>edifact-o:seeXML : SynatxKennung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : synatxIdentifier</para>
    ///   <para>rdfs:comment : Identification of the used synatx^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#synatxIdentifier">edifact-o:synatxIdentifier</a>
    /// </summary>
    let synatxIdentifier = _prefixId.prefix "synatxIdentifier"
    /// <summary>
    ///   <para>edifact-o:seeXML : SyntaxVersion^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : synatxVersion</para>
    ///   <para>rdfs:comment : Version of the used syntax^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#synatxVersion">edifact-o:synatxVersion</a>
    /// </summary>
    let synatxVersion = _prefixId.prefix "synatxVersion"
    /// <summary>
    ///   <para>edifact-o:seeXML : Steuerperiode^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : taxPeriod</para>
    ///   <para>rdfs:comment : Period a tax rate/tax amount etc. is applicable.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#taxPeriod">edifact-o:taxPeriod</a>
    /// </summary>
    let taxPeriod = _prefixId.prefix "taxPeriod"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : timePeriod</para>
    ///   <para>rdfs:comment : Contains a time Period^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#timePeriod">edifact-o:timePeriod</a>
    /// </summary>
    let timePeriod = _prefixId.prefix "timePeriod"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_0074^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : totalNumberOfSegments</para>
    ///   <para>rdfs:comment : The total number of the segments^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#totalNumberOfSegments">edifact-o:totalNumberOfSegments</a>
    /// </summary>
    let totalNumberOfSegments = _prefixId.prefix "totalNumberOfSegments"
    /// <summary>
    ///   <para>edifact-o:seeXML : D_5284^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : unitPriceBasis</para>
    ///   <para>rdfs:comment : The Unit price basis^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#unitPriceBasis">edifact-o:unitPriceBasis</a>
    /// </summary>
    let unitPriceBasis = _prefixId.prefix "unitPriceBasis"
    /// <summary>
    ///   <para>edifact-o:seeXML : Universal_Prodcut_Code^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : universalProductCode</para>
    ///   <para>rdfs:comment : Number assigned to a manufacturer's product by the Product Code Council.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#universalProductCode">edifact-o:universalProductCode</a>
    /// </summary>
    let universalProductCode = _prefixId.prefix "universalProductCode"
    /// <summary>
    ///   <para>edifact-o:seeXML : ValutaDatum^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : valutaDate</para>
    ///   <para>rdfs:comment : Document date in the future from which the agreed payment period begins^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#valutaDate">edifact-o:valutaDate</a>
    /// </summary>
    let valutaDate = _prefixId.prefix "valutaDate"
    /// <summary>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Version number of a message type^^xsd:string</para>
    ///   <para>edifact-o:seeXML : D_0052^^xsd:string</para>
    ///   <para>edifact-o:seeEDIFACT : D_0052^^xsd:string</para>
    ///   <para>rdfs:label : versionNumberMessageType</para>
    ///   <a href="https://purl.org/edifact/ontology#versionNumberMessageType">edifact-o:versionNumberMessageType</a>
    /// </summary>
    let versionNumberMessageType = _prefixId.prefix "versionNumberMessageType"
    /// <summary>
    ///   <para>edifact-o:seeXML : Breitenabmessung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : widthDimension</para>
    ///   <para>rdfs:comment : Numeric value of width^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#widthDimension">edifact-o:widthDimension</a>
    /// </summary>
    let widthDimension = _prefixId.prefix "widthDimension"
    /// <summary>
    ///   <para>edifact-o:seeXML : Menge_ohne_Berechnung^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : withoutCalculationQuantity</para>
    ///   <para>rdfs:comment : Quantity of goods which are free of charge.^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#withoutCalculationQuantity">edifact-o:withoutCalculationQuantity</a>
    /// </summary>
    let withoutCalculationQuantity = _prefixId.prefix "withoutCalculationQuantity"

    /// <summary>
    ///   <para>edifact-o:seeXML : Menge_ohne_Berechnung_Einheit^^xsd:string</para>
    ///   <para>http://www.w3.og/2003/06/sw-vocab-status/ns#term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : withoutCalculationQuantityWithUnit</para>
    ///   <para>rdfs:comment : Quantity of goods which are free of charge with unit^^xsd:string</para>
    ///   <a href="https://purl.org/edifact/ontology#withoutCalculationQuantityWithUnit">edifact-o:withoutCalculationQuantityWithUnit</a>
    /// </summary>
    let withoutCalculationQuantityWithUnit =
        _prefixId.prefix "withoutCalculationQuantityWithUnit"
