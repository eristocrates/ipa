namespace https.purl.org.edifact.ontology.hash

open DoxAletheia

module edifact_o =
    let _namespace_name = "https://purl.org/edifact/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The class containing information about the perfomed role of the involved organizations
    /// <see href="https://purl.org/edifact/ontology#FormalOrganization"></see></summary>
    let FormalOrganization = _prefix "FormalOrganization"
    /// <summary>
    ///   <see href="https://purl.org/edifact/ontology#seeXML"></see>
    /// </summary>
    let seeXML = _prefix "seeXML"
    /// <summary>
    /// Defined as the union of the classes Item and InvoiceDetails
    /// <see href="https://purl.org/edifact/ontology#InvoiceContent"></see></summary>
    let InvoiceContent = _prefix "InvoiceContent"
    /// <summary>
    /// The root class of each invoice. Contains all the linked classes with information about the invoice
    /// <see href="https://purl.org/edifact/ontology#E-Invoice"></see></summary>
    let ``E-Invoice`` = _prefix "E-Invoice"
    /// <summary>
    /// Contains all the information about a item
    /// <see href="https://purl.org/edifact/ontology#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// The role of a party acting in the name of the seller as broker or as sales office.
    /// <see href="https://purl.org/edifact/ontology#BrokerSalesOfficeRole"></see></summary>
    let BrokerSalesOfficeRole = _prefix "BrokerSalesOfficeRole"
    /// <summary>
    /// The role of the party to which articles are sold
    /// <see href="https://purl.org/edifact/ontology#BuyerRole"></see></summary>
    let BuyerRole = _prefix "BuyerRole"
    /// <summary>
    /// The role of the party receiving goods and relevant invoice
    /// <see href="https://purl.org/edifact/ontology#CalculateDeliverToRole"></see></summary>
    let CalculateDeliverToRole = _prefix "CalculateDeliverToRole"
    /// <summary>
    /// The role of the party which is the central regulator
    /// <see href="https://purl.org/edifact/ontology#CentralRegulatorRole"></see></summary>
    let CentralRegulatorRole = _prefix "CentralRegulatorRole"
    /// <summary>
    /// The role of the party to which goods should be delivered, if not identical with consignee.
    /// <see href="https://purl.org/edifact/ontology#DeliveryPartyRole"></see></summary>
    let DeliveryPartyRole = _prefix "DeliveryPartyRole"
    /// <summary>
    /// The role of the party where goods are collected or taken over by the carrier (i.e. if other than consignor)
    /// <see href="https://purl.org/edifact/ontology#DespatchPartyRole"></see></summary>
    let DespatchPartyRole = _prefix "DespatchPartyRole"
    /// <summary>
    /// Contains all the information which are necessary for the invoice to be a valid EDIFACT Invoice
    /// <see href="https://purl.org/edifact/ontology#EDIFACT-Structure"></see></summary>
    let ``EDIFACT-Structure`` = _prefix "EDIFACT-Structure"
    /// <summary>
    /// The role of the party who has been designated on the invoice or packing list as the final recipient of the stated merchandise.
    /// <see href="https://purl.org/edifact/ontology#FinalConsigneeRole"></see></summary>
    let FinalConsigneeRole = _prefix "FinalConsigneeRole"
    /// <summary>
    /// Contains all the general information about an invoice
    /// <see href="https://purl.org/edifact/ontology#InvoiceDetails"></see></summary>
    let InvoiceDetails = _prefix "InvoiceDetails"
    /// <summary>
    /// The role of the party to whom an invoice is issued
    /// <see href="https://purl.org/edifact/ontology#InvoiceeRole"></see></summary>
    let InvoiceeRole = _prefix "InvoiceeRole"
    /// <summary>
    /// The role of the party issuing an invoice
    /// <see href="https://purl.org/edifact/ontology#InvoicingPartyRole"></see></summary>
    let InvoicingPartyRole = _prefix "InvoicingPartyRole"
    /// <summary>
    /// The role of the party initiating payment
    /// <see href="https://purl.org/edifact/ontology#PayeeRole"></see></summary>
    let PayeeRole = _prefix "PayeeRole"
    /// <summary>
    /// The role of the party to whom payment for a commercial invoice or bill should be remitted.
    /// <see href="https://purl.org/edifact/ontology#RecipientOfInvoiceRegulationRole"></see></summary>
    let RecipientOfInvoiceRegulationRole = _prefix "RecipientOfInvoiceRegulationRole"
    /// <summary>
    /// The role of the party to which goods are consigned.
    /// <see href="https://purl.org/edifact/ontology#RecipientRole"></see></summary>
    let RecipientRole = _prefix "RecipientRole"
    /// <summary>
    /// The role of the party which is the regulator of the invoice
    /// <see href="https://purl.org/edifact/ontology#RegulatorRole"></see></summary>
    let RegulatorRole = _prefix "RegulatorRole"
    /// <summary>
    /// The role of the party representing the seller for the purpose of the trade transaction.
    /// <see href="https://purl.org/edifact/ontology#RepresentativeOfSupplierRole"></see></summary>
    let RepresentativeOfSupplierRole = _prefix "RepresentativeOfSupplierRole"
    /// <summary>
    /// The role of the third party who arranged the purchase of merchandise on behalf of the actual buyer
    /// <see href="https://purl.org/edifact/ontology#SalesAgentRole"></see></summary>
    let SalesAgentRole = _prefix "SalesAgentRole"
    /// <summary>
    /// The role of the party selling merchandise to a buyer.
    /// <see href="https://purl.org/edifact/ontology#SellerRole"></see></summary>
    let SellerRole = _prefix "SellerRole"
    /// <summary>
    /// The role of the party to where goods will be or have been shipped
    /// <see href="https://purl.org/edifact/ontology#SendToRole"></see></summary>
    let SendToRole = _prefix "SendToRole"
    /// <summary>
    /// The role of the party which manufactures or otherwise has possession of goods, and consigns or makes them available in trade.
    /// <see href="https://purl.org/edifact/ontology#SupplierRole"></see></summary>
    let SupplierRole = _prefix "SupplierRole"
    /// <summary>
    /// The role of the party's headquarters which manufactures or otherwise has possession of goods, and consigns or makes them available in trade.
    /// <see href="https://purl.org/edifact/ontology#SuppliersCompanyHeadquarterRole"></see></summary>
    let SuppliersCompanyHeadquarterRole = _prefix "SuppliersCompanyHeadquarterRole"
    /// <summary>
    /// The role of the party that runs the Warehouse
    /// <see href="https://purl.org/edifact/ontology#WarehouseNumberRole"></see></summary>
    let WarehouseNumberRole = _prefix "WarehouseNumberRole"
    /// <summary>
    /// The role of the party that is the wholesaler
    /// <see href="https://purl.org/edifact/ontology#WholesalerRole"></see></summary>
    let WholesalerRole = _prefix "WholesalerRole"
    /// <summary>
    /// Reference number assigned by accounts receivable department to the account of a specific debtor.
    /// <see href="https://purl.org/edifact/ontology#accountsReceivableNumber"></see></summary>
    let accountsReceivableNumber = _prefix "accountsReceivableNumber"
    /// <summary>
    /// identifier which is a number
    /// <see href="https://purl.org/edifact/ontology#noteNumber"></see></summary>
    let noteNumber = _prefix "noteNumber"

    /// <summary>
    /// Additional Partneridentification (GLN-Code)
    /// <see href="https://purl.org/edifact/ontology#additionalPartnerIdentificationEANCode"></see></summary>
    let additionalPartnerIdentificationEANCode =
        _prefix "additionalPartnerIdentificationEANCode"

    /// <summary>
    /// Reason for the allowance
    /// <see href="https://purl.org/edifact/ontology#allowanceReason"></see></summary>
    let allowanceReason = _prefix "allowanceReason"
    /// <summary>
    /// Indicates to which business process the invoice belongs
    /// <see href="https://purl.org/edifact/ontology#belongsToProcess"></see></summary>
    let belongsToProcess = _prefix "belongsToProcess"
    /// <summary>
    /// Reference of the beneficiary
    /// <see href="https://purl.org/edifact/ontology#beneficiaryReference"></see></summary>
    let beneficiaryReference = _prefix "beneficiaryReference"
    /// <summary>
    /// Note contains information mutually defined by trading partners
    /// <see href="https://purl.org/edifact/ontology#bilateralAgreed"></see></summary>
    let bilateralAgreed = _prefix "bilateralAgreed"
    /// <summary>
    /// Period for which an invoice is issued.
    /// <see href="https://purl.org/edifact/ontology#calculationPeriod"></see></summary>
    let calculationPeriod = _prefix "calculationPeriod"
    /// <summary>
    /// Contains a time Period
    /// <see href="https://purl.org/edifact/ontology#timePeriod"></see></summary>
    let timePeriod = _prefix "timePeriod"
    /// <summary>
    /// Note contains change information
    /// <see href="https://purl.org/edifact/ontology#changeInformation"></see></summary>
    let changeInformation = _prefix "changeInformation"

    /// <summary>
    /// Company registration and place as legally required.
    /// <see href="https://purl.org/edifact/ontology#companyOrPlaceRegistristrationNumber"></see></summary>
    let companyOrPlaceRegistristrationNumber =
        _prefix "companyOrPlaceRegistristrationNumber"

    /// <summary>
    /// Numbers of consumer units in the traded unit
    /// <see href="https://purl.org/edifact/ontology#consumerUnitsInTradingUnitQuantity"></see></summary>
    let consumerUnitsInTradingUnitQuantity =
        _prefix "consumerUnitsInTradingUnitQuantity"

    /// <summary>
    /// display a quantity
    /// <see href="https://purl.org/edifact/ontology#quantity"></see></summary>
    let quantity = _prefix "quantity"

    /// <summary>
    /// Numbers of consumer units in the traded unit
    /// <see href="https://purl.org/edifact/ontology#consumerUnitsInTradingUnitQuantityWithUnit"></see></summary>
    let consumerUnitsInTradingUnitQuantityWithUnit =
        _prefix "consumerUnitsInTradingUnitQuantityWithUnit"

    /// <summary>
    /// The department or person within an organizational entity.
    /// <see href="https://purl.org/edifact/ontology#contactDepartmentPerson"></see></summary>
    let contactDepartmentPerson = _prefix "contactDepartmentPerson"
    /// <summary>
    /// Contact Persons
    /// <see href="https://purl.org/edifact/ontology#contactPersom"></see></summary>
    let contactPersom = _prefix "contactPersom"
    /// <summary>
    /// Department/person responsible for the accounts payable function within a corporation.
    /// <see href="https://purl.org/edifact/ontology#contactPersonAccounting"></see></summary>
    let contactPersonAccounting = _prefix "contactPersonAccounting"
    /// <summary>
    ///   <see href="https://purl.org/edifact/ontology#seeEDIFACT"></see>
    /// </summary>
    let seeEDIFACT = _prefix "seeEDIFACT"
    /// <summary>
    /// Department/person responsible for the accounts payable function within a corporation
    /// <see href="https://purl.org/edifact/ontology#contactPersonCreditorAccounting"></see></summary>
    let contactPersonCreditorAccounting = _prefix "contactPersonCreditorAccounting"
    /// <summary>
    /// Creating/sending/receiving of unstructured free text messages or documents using computer network, a mini- computer or an attached modem and regular telephone line or other electronic transmission media.
    /// <see href="https://purl.org/edifact/ontology#contactPersonEmailAddress"></see></summary>
    let contactPersonEmailAddress = _prefix "contactPersonEmailAddress"
    /// <summary>
    /// Device used for transmitting and reproducing fixed graphic material (as printing) by means of signals over telephone lines or other electronic transmission media.
    /// <see href="https://purl.org/edifact/ontology#contactPersonFaxNumber"></see></summary>
    let contactPersonFaxNumber = _prefix "contactPersonFaxNumber"
    /// <summary>
    /// Department/person responsible for receiving the goods at the place of delivery.
    /// <see href="https://purl.org/edifact/ontology#contactPersonIncomingGoods"></see></summary>
    let contactPersonIncomingGoods = _prefix "contactPersonIncomingGoods"
    /// <summary>
    /// Department/person to contact for questions regarding transactions
    /// <see href="https://purl.org/edifact/ontology#contactPersonInformation"></see></summary>
    let contactPersonInformation = _prefix "contactPersonInformation"
    /// <summary>
    /// Department/person responsible for issuing this purchase order.
    /// <see href="https://purl.org/edifact/ontology#contactPersonPurchasingDepartment"></see></summary>
    let contactPersonPurchasingDepartment = _prefix "contactPersonPurchasingDepartment"
    /// <summary>
    /// Department/person responsible for the accounts receivable within a corporation
    /// <see href="https://purl.org/edifact/ontology#contactPersonReceivableAccounting"></see></summary>
    let contactPersonReceivableAccounting = _prefix "contactPersonReceivableAccounting"
    /// <summary>
    /// The sales representative or department contact within an organization.
    /// <see href="https://purl.org/edifact/ontology#contactPersonSalesDepartment"></see></summary>
    let contactPersonSalesDepartment = _prefix "contactPersonSalesDepartment"
    /// <summary>
    /// Voice/data transmission by telephone
    /// <see href="https://purl.org/edifact/ontology#contactPersonTelefonNumber"></see></summary>
    let contactPersonTelefonNumber = _prefix "contactPersonTelefonNumber"
    /// <summary>
    /// Transmission of text/data via telex.
    /// <see href="https://purl.org/edifact/ontology#contactPersonTelexNumber"></see></summary>
    let contactPersonTelexNumber = _prefix "contactPersonTelexNumber"
    /// <summary>
    /// CCITT Message handling system
    /// <see href="https://purl.org/edifact/ontology#contactPersonX400Number"></see></summary>
    let contactPersonX400Number = _prefix "contactPersonX400Number"
    /// <summary>
    /// Reference number of a contract concluded between parties.
    /// <see href="https://purl.org/edifact/ontology#contractNumber"></see></summary>
    let contractNumber = _prefix "contractNumber"
    /// <summary>
    /// Reference number assigned by buyer to a contract.
    /// <see href="https://purl.org/edifact/ontology#contractNumberBuyer"></see></summary>
    let contractNumberBuyer = _prefix "contractNumberBuyer"

    /// <summary>
    /// Detail/summary section separation
    /// <see href="https://purl.org/edifact/ontology#controlSegmentBetweenItemAndTotalPart"></see></summary>
    let controlSegmentBetweenItemAndTotalPart =
        _prefix "controlSegmentBetweenItemAndTotalPart"

    /// <summary>
    /// Date when the message was created
    /// <see href="https://purl.org/edifact/ontology#creationDate"></see></summary>
    let creationDate = _prefix "creationDate"
    /// <summary>
    /// Time of the creation of the EDIFACT message
    /// <see href="https://purl.org/edifact/ontology#creationTime"></see></summary>
    let creationTime = _prefix "creationTime"
    /// <summary>
    /// Reference number assigned to a credit note.
    /// <see href="https://purl.org/edifact/ontology#creditNoteNumber"></see></summary>
    let creditNoteNumber = _prefix "creditNoteNumber"
    /// <summary>
    /// Code number of the goods in accordance with the tariff nomenclature system of classification in use where the Customs declaration is made.
    /// <see href="https://purl.org/edifact/ontology#customsTariffNumber"></see></summary>
    let customsTariffNumber = _prefix "customsTariffNumber"
    /// <summary>
    /// the counter of the exchanged data
    /// <see href="https://purl.org/edifact/ontology#dataExchangeCounter"></see></summary>
    let dataExchangeCounter = _prefix "dataExchangeCounter"
    /// <summary>
    /// the reference of the exchanged data
    /// <see href="https://purl.org/edifact/ontology#dataExchangeReference"></see></summary>
    let dataExchangeReference = _prefix "dataExchangeReference"
    /// <summary>
    /// Date of the reference number assigned by accounts receivable department to the account of a specific debtor.
    /// <see href="https://purl.org/edifact/ontology#dateAccountsReceivableNumber"></see></summary>
    let dateAccountsReceivableNumber = _prefix "dateAccountsReceivableNumber"
    /// <summary>
    /// Reference Date
    /// <see href="https://purl.org/edifact/ontology#referenceDate"></see></summary>
    let referenceDate = _prefix "referenceDate"

    /// <summary>
    /// Date of Additional Partneridentification (GLN-Code)
    /// <see href="https://purl.org/edifact/ontology#dateAdditionalPartnerIdentificationEANCode"></see></summary>
    let dateAdditionalPartnerIdentificationEANCode =
        _prefix "dateAdditionalPartnerIdentificationEANCode"

    /// <summary>
    /// Date of the reference of the beneficiary
    /// <see href="https://purl.org/edifact/ontology#dateBeneficiaryReference"></see></summary>
    let dateBeneficiaryReference = _prefix "dateBeneficiaryReference"

    /// <summary>
    /// Date of company registration and place as legally required.
    /// <see href="https://purl.org/edifact/ontology#dateCompanyOrPlaceRegistristrationNumber"></see></summary>
    let dateCompanyOrPlaceRegistristrationNumber =
        _prefix "dateCompanyOrPlaceRegistristrationNumber"

    /// <summary>
    /// Date of the reference number of a contract concluded between parties.
    /// <see href="https://purl.org/edifact/ontology#dateContractNumber"></see></summary>
    let dateContractNumber = _prefix "dateContractNumber"
    /// <summary>
    /// Date of the reference number assigned by buyer to a contract.
    /// <see href="https://purl.org/edifact/ontology#dateContractNumberBuyer"></see></summary>
    let dateContractNumberBuyer = _prefix "dateContractNumberBuyer"
    /// <summary>
    /// Date of the reference number assigned to a credit note.
    /// <see href="https://purl.org/edifact/ontology#dateCreditNoteNumber"></see></summary>
    let dateCreditNoteNumber = _prefix "dateCreditNoteNumber"
    /// <summary>
    /// Date of the code number of the goods in accordance with the tariff nomenclature system of classification in use where the Customs declaration is made.
    /// <see href="https://purl.org/edifact/ontology#dateCustomsTariffNumber"></see></summary>
    let dateCustomsTariffNumber = _prefix "dateCustomsTariffNumber"
    /// <summary>
    /// Date of the reference number assigned by issuer to a debit note
    /// <see href="https://purl.org/edifact/ontology#dateDebitNoteNumber"></see></summary>
    let dateDebitNoteNumber = _prefix "dateDebitNoteNumber"
    /// <summary>
    /// Date of the reference number assigned by the issuer to a delivery note.
    /// <see href="https://purl.org/edifact/ontology#dateDeliveryNoteNumber"></see></summary>
    let dateDeliveryNoteNumber = _prefix "dateDeliveryNoteNumber"
    /// <summary>
    /// Date of the reference number assigned by issuing party to a despatch advice.
    /// <see href="https://purl.org/edifact/ontology#dateDespatchAdviceNumber"></see></summary>
    let dateDespatchAdviceNumber = _prefix "dateDespatchAdviceNumber"
    /// <summary>
    /// Date of the reference number given to an export shipment.
    /// <see href="https://purl.org/edifact/ontology#dateExportReferenceNumber"></see></summary>
    let dateExportReferenceNumber = _prefix "dateExportReferenceNumber"
    /// <summary>
    /// Date of number assigned by the file issuer or sender to identify a specific line.
    /// <see href="https://purl.org/edifact/ontology#dateFileLineIdentifier"></see></summary>
    let dateFileLineIdentifier = _prefix "dateFileLineIdentifier"
    /// <summary>
    /// Date of the receiving company account number (ACH transfer), check, draft or wire
    /// <see href="https://purl.org/edifact/ontology#dateFinancialAccountNumberPayee"></see></summary>
    let dateFinancialAccountNumberPayee = _prefix "dateFinancialAccountNumberPayee"
    /// <summary>
    /// Date of Tax payer's number.
    /// <see href="https://purl.org/edifact/ontology#dateFiscalNumber"></see></summary>
    let dateFiscalNumber = _prefix "dateFiscalNumber"
    /// <summary>
    /// Date of the refernce number given by the goverment
    /// <see href="https://purl.org/edifact/ontology#dateGovernmentReferenceNumber"></see></summary>
    let dateGovernmentReferenceNumber = _prefix "dateGovernmentReferenceNumber"
    /// <summary>
    /// Date of the number specifying the goods classification under the Harmonised Commodity Description and Coding System of the Customs Co-operation Council (CCC).
    /// <see href="https://purl.org/edifact/ontology#dateHarmonisedSystemNumber"></see></summary>
    let dateHarmonisedSystemNumber = _prefix "dateHarmonisedSystemNumber"
    /// <summary>
    /// Date of the reference number assigned by the issuing authority to an Import Licence.
    /// <see href="https://purl.org/edifact/ontology#dateImportLicenseNumber"></see></summary>
    let dateImportLicenseNumber = _prefix "dateImportLicenseNumber"
    /// <summary>
    /// Date of the number assigned by a seller, supplier etc. to identify a customer within his enterprise.
    /// <see href="https://purl.org/edifact/ontology#dateInternalCustomerNumber"></see></summary>
    let dateInternalCustomerNumber = _prefix "dateInternalCustomerNumber"
    /// <summary>
    /// Date of the number identifying the company-internal vending department/unit.
    /// <see href="https://purl.org/edifact/ontology#dateInternalVendorNumber"></see></summary>
    let dateInternalVendorNumber = _prefix "dateInternalVendorNumber"
    /// <summary>
    /// Date of the reference number assigned by the seller to a Commercial Invoice.
    /// <see href="https://purl.org/edifact/ontology#dateInvoiceNumber"></see></summary>
    let dateInvoiceNumber = _prefix "dateInvoiceNumber"
    /// <summary>
    /// Date of the reference number identifying a particular line in a document.
    /// <see href="https://purl.org/edifact/ontology#dateLineItemReferenceNumber"></see></summary>
    let dateLineItemReferenceNumber = _prefix "dateLineItemReferenceNumber"

    /// <summary>
    /// Date of the consolidated invoice number with EAN code
    /// <see href="https://purl.org/edifact/ontology#dateNumberConsolidatedInvoiceEANCode"></see></summary>
    let dateNumberConsolidatedInvoiceEANCode =
        _prefix "dateNumberConsolidatedInvoiceEANCode"

    /// <summary>
    /// Date of batch number identifying a batch of messages.
    /// <see href="https://purl.org/edifact/ontology#dateNumberOfBundleMessages"></see></summary>
    let dateNumberOfBundleMessages = _prefix "dateNumberOfBundleMessages"
    /// <summary>
    /// Date of the reference number assigned by issuing party to an offer.
    /// <see href="https://purl.org/edifact/ontology#dateOfferNumber"></see></summary>
    let dateOfferNumber = _prefix "dateOfferNumber"
    /// <summary>
    /// Date of the reference number assigned by the buyer to an order.
    /// <see href="https://purl.org/edifact/ontology#dateOrderNumberBuyer"></see></summary>
    let dateOrderNumberBuyer = _prefix "dateOrderNumberBuyer"
    /// <summary>
    /// Date of the reference number assigned by issuer to a delivery order.
    /// <see href="https://purl.org/edifact/ontology#dateOrderNumberDelivery"></see></summary>
    let dateOrderNumberDelivery = _prefix "dateOrderNumberDelivery"
    /// <summary>
    /// Date of the reference number assigned by supplier to a buyer's purchase order.
    /// <see href="https://purl.org/edifact/ontology#dateOrderNumberSupplier"></see></summary>
    let dateOrderNumberSupplier = _prefix "dateOrderNumberSupplier"
    /// <summary>
    /// Date of the reference of the originator
    /// <see href="https://purl.org/edifact/ontology#dateOriginatorReference"></see></summary>
    let dateOriginatorReference = _prefix "dateOriginatorReference"
    /// <summary>
    /// Date of the reference number assigned to a payment.
    /// <see href="https://purl.org/edifact/ontology#datePaymentReference"></see></summary>
    let datePaymentReference = _prefix "datePaymentReference"
    /// <summary>
    /// Date of the reference number assigned to a price list.
    /// <see href="https://purl.org/edifact/ontology#datePriceListNumber"></see></summary>
    let datePriceListNumber = _prefix "datePriceListNumber"
    /// <summary>
    /// Date of the reference number assigned by the seller to a Proforma Invoice.
    /// <see href="https://purl.org/edifact/ontology#dateProformaInvoiceNumber"></see></summary>
    let dateProformaInvoiceNumber = _prefix "dateProformaInvoiceNumber"
    /// <summary>
    /// Date of a reference number to a receiving advice.
    /// <see href="https://purl.org/edifact/ontology#dateReceivingAdviceNumber"></see></summary>
    let dateReceivingAdviceNumber = _prefix "dateReceivingAdviceNumber"

    /// <summary>
    /// Date of the reference number for a business account statement as EAN code
    /// <see href="https://purl.org/edifact/ontology#dateReferenceNumberBusinessContactExtractEANCode"></see></summary>
    let dateReferenceNumberBusinessContactExtractEANCode =
        _prefix "dateReferenceNumberBusinessContactExtractEANCode"

    /// <summary>
    /// Date of the reference number assigned by the customer to a transaction.
    /// <see href="https://purl.org/edifact/ontology#dateReferenceNumberCustomer"></see></summary>
    let dateReferenceNumberCustomer = _prefix "dateReferenceNumberCustomer"
    /// <summary>
    /// Date of the realted document number
    /// <see href="https://purl.org/edifact/ontology#dateRelatedDocumentNumber"></see></summary>
    let dateRelatedDocumentNumber = _prefix "dateRelatedDocumentNumber"
    /// <summary>
    /// Date of the reference number assigned to a transaction by the seller
    /// <see href="https://purl.org/edifact/ontology#dateSellersReferenceNumber"></see></summary>
    let dateSellersReferenceNumber = _prefix "dateSellersReferenceNumber"
    /// <summary>
    /// Date of the number assigned by the issuer to his specification.
    /// <see href="https://purl.org/edifact/ontology#dateSpecificationNumber"></see></summary>
    let dateSpecificationNumber = _prefix "dateSpecificationNumber"
    /// <summary>
    /// Reference number assigned by issuer to a debit note
    /// <see href="https://purl.org/edifact/ontology#debitNoteNumber"></see></summary>
    let debitNoteNumber = _prefix "debitNoteNumber"
    /// <summary>
    /// Number of pieces actually received at the final destination.
    /// <see href="https://purl.org/edifact/ontology#deliveredQuantity"></see></summary>
    let deliveredQuantity = _prefix "deliveredQuantity"
    /// <summary>
    /// Specifies the conditions under which the goods must be delivered to the consignee
    /// <see href="https://purl.org/edifact/ontology#deliveryCondition"></see></summary>
    let deliveryCondition = _prefix "deliveryCondition"
    /// <summary>
    /// Reference number assigned by the issuer to a delivery note.
    /// <see href="https://purl.org/edifact/ontology#deliveryNoteNumber"></see></summary>
    let deliveryNoteNumber = _prefix "deliveryNoteNumber"
    /// <summary>
    /// Plain language description of the nature of the goods sufficient to identify them at the level required for banking, Customs, statistical or transport purposes, avoiding unnecessary detail (Generic term).
    /// <see href="https://purl.org/edifact/ontology#descriptionOfGoods"></see></summary>
    let descriptionOfGoods = _prefix "descriptionOfGoods"
    /// <summary>
    /// Reference number assigned by issuing party to a despatch advice.
    /// <see href="https://purl.org/edifact/ontology#despatchAdviceNumber"></see></summary>
    let despatchAdviceNumber = _prefix "despatchAdviceNumber"
    /// <summary>
    /// Quantity despatched by the seller.
    /// <see href="https://purl.org/edifact/ontology#despatchQuantity"></see></summary>
    let despatchQuantity = _prefix "despatchQuantity"
    /// <summary>
    /// Date/time when the deduction from an amount comes to an end.
    /// <see href="https://purl.org/edifact/ontology#discountTerminationDate"></see></summary>
    let discountTerminationDate = _prefix "discountTerminationDate"
    /// <summary>
    /// The discrete quantity
    /// <see href="https://purl.org/edifact/ontology#discreteQuantity"></see></summary>
    let discreteQuantity = _prefix "discreteQuantity"
    /// <summary>
    /// Date/time when a document/message is issued. This may include authentication.
    /// <see href="https://purl.org/edifact/ontology#documentDate"></see></summary>
    let documentDate = _prefix "documentDate"
    /// <summary>
    /// Date and/or time at which specified event or document becomes effective.
    /// <see href="https://purl.org/edifact/ontology#effectiveDate"></see></summary>
    let effectiveDate = _prefix "effectiveDate"
    /// <summary>
    /// Date/time on which the exchange rate was fixed.
    /// <see href="https://purl.org/edifact/ontology#exchangeRateDate"></see></summary>
    let exchangeRateDate = _prefix "exchangeRateDate"
    /// <summary>
    /// Reference number given to an export shipment.
    /// <see href="https://purl.org/edifact/ontology#exportReferenceNumber"></see></summary>
    let exportReferenceNumber = _prefix "exportReferenceNumber"
    /// <summary>
    /// Number assigned by the file issuer or sender to identify a specific line.
    /// <see href="https://purl.org/edifact/ontology#fileLineIdentifier"></see></summary>
    let fileLineIdentifier = _prefix "fileLineIdentifier"
    /// <summary>
    /// Receiving company account number (ACH transfer), check, draft or wire
    /// <see href="https://purl.org/edifact/ontology#financialAccountNumberPayee"></see></summary>
    let financialAccountNumberPayee = _prefix "financialAccountNumberPayee"
    /// <summary>
    /// Tax payer's number. Number assigned to individual persons as well as to corporates by a public institution; this number is different from the VAT registration number.
    /// <see href="https://purl.org/edifact/ontology#fiscalNumber"></see></summary>
    let fiscalNumber = _prefix "fiscalNumber"
    /// <summary>
    /// shows the file standard resources the invoice has
    /// <see href="https://purl.org/edifact/ontology#followsStandard"></see></summary>
    let followsStandard = _prefix "followsStandard"
    /// <summary>
    /// shows of which invoice the EDIFACT Structure is
    /// <see href="https://purl.org/edifact/ontology#isStandardOf"></see></summary>
    let isStandardOf = _prefix "isStandardOf"
    /// <summary>
    /// Refernce number given by the goverment
    /// <see href="https://purl.org/edifact/ontology#governmentReferenceNumber"></see></summary>
    let governmentReferenceNumber = _prefix "governmentReferenceNumber"
    /// <summary>
    /// Contains the number of the harmonised system
    /// <see href="https://purl.org/edifact/ontology#harmonisedSystem"></see></summary>
    let harmonisedSystem = _prefix "harmonisedSystem"
    /// <summary>
    /// Date of the number specifying the goods classification under the Harmonised Commodity Description and Coding System of the Customs Co-operation Council (CCC).
    /// <see href="https://purl.org/edifact/ontology#harmonisedSystemNumber"></see></summary>
    let harmonisedSystemNumber = _prefix "harmonisedSystemNumber"

    /// <summary>
    /// Information which specifies and qualifies product identifications.
    /// <see href="https://purl.org/edifact/ontology#hasAdditionalProductIdentification"></see></summary>
    let hasAdditionalProductIdentification =
        _prefix "hasAdditionalProductIdentification"

    /// <summary>
    /// Amount of the allowance
    /// <see href="https://purl.org/edifact/ontology#hasAllowanceAmount"></see></summary>
    let hasAllowanceAmount = _prefix "hasAllowanceAmount"
    /// <summary>
    /// Allowance expressed as a percentage.
    /// <see href="https://purl.org/edifact/ontology#hasAllowancePercentage"></see></summary>
    let hasAllowancePercentage = _prefix "hasAllowancePercentage"
    /// <summary>
    /// Contains percentage
    /// <see href="https://purl.org/edifact/ontology#percentage"></see></summary>
    let percentage = _prefix "percentage"

    /// <summary>
    /// Allowance expressed as a percentage with payment condition
    /// <see href="https://purl.org/edifact/ontology#hasAllowancePercentagePaymentConditions"></see></summary>
    let hasAllowancePercentagePaymentConditions =
        _prefix "hasAllowancePercentagePaymentConditions"

    /// <summary>
    /// The reason for the allowance
    /// <see href="https://purl.org/edifact/ontology#hasAllowanceReason"></see></summary>
    let hasAllowanceReason = _prefix "hasAllowanceReason"
    /// <summary>
    /// Amount to be paid
    /// <see href="https://purl.org/edifact/ontology#hasAmountDueOrPayable"></see></summary>
    let hasAmountDueOrPayable = _prefix "hasAmountDueOrPayable"
    /// <summary>
    /// Amount which is used as the basis for price adjustment calculation.
    /// <see href="https://purl.org/edifact/ontology#hasAmountUnderPriceAdjustment"></see></summary>
    let hasAmountUnderPriceAdjustment = _prefix "hasAmountUnderPriceAdjustment"
    /// <summary>
    /// The amount specified is the basis for duty/tax or fee.
    /// <see href="https://purl.org/edifact/ontology#hasBasicTaxAmount"></see></summary>
    let hasBasicTaxAmount = _prefix "hasBasicTaxAmount"
    /// <summary>
    /// Cash discount given by the seller to the buyer where payment is made in advance of receipt of goods.
    /// <see href="https://purl.org/edifact/ontology#hasCashDiscount"></see></summary>
    let hasCashDiscount = _prefix "hasCashDiscount"
    /// <summary>
    /// The amount specified is the basis for calculation of charges/allowance.
    /// <see href="https://purl.org/edifact/ontology#hasChargeAllowanceBasis"></see></summary>
    let hasChargeAllowanceBasis = _prefix "hasChargeAllowanceBasis"
    /// <summary>
    /// The amont of the charge
    /// <see href="https://purl.org/edifact/ontology#hasChargeAmount"></see></summary>
    let hasChargeAmount = _prefix "hasChargeAmount"
    /// <summary>
    /// Charge expressed as a percentage.
    /// <see href="https://purl.org/edifact/ontology#hasChargePercentage"></see></summary>
    let hasChargePercentage = _prefix "hasChargePercentage"

    /// <summary>
    /// Charge expressed as a percentage with the payment conditions
    /// <see href="https://purl.org/edifact/ontology#hasChargePercentagePaymentConditions"></see></summary>
    let hasChargePercentagePaymentConditions =
        _prefix "hasChargePercentagePaymentConditions"

    /// <summary>
    /// The reason for the charge
    /// <see href="https://purl.org/edifact/ontology#hasChargeReason"></see></summary>
    let hasChargeReason = _prefix "hasChargeReason"
    /// <summary>
    /// Cotains the city name of a party involved in the invoice
    /// <see href="https://purl.org/edifact/ontology#hasCity"></see></summary>
    let hasCity = _prefix "hasCity"
    /// <summary>
    /// The amount specified is the discount amount
    /// <see href="https://purl.org/edifact/ontology#hasDiscountAmount"></see></summary>
    let hasDiscountAmount = _prefix "hasDiscountAmount"
    /// <summary>
    /// Discount expressed as a percentage.
    /// <see href="https://purl.org/edifact/ontology#hasDiscountPercentage"></see></summary>
    let hasDiscountPercentage = _prefix "hasDiscountPercentage"

    /// <summary>
    /// Discount expressed as a percentage with payment condition
    /// <see href="https://purl.org/edifact/ontology#hasDiscountPercentagePaymentConditions"></see></summary>
    let hasDiscountPercentagePaymentConditions =
        _prefix "hasDiscountPercentagePaymentConditions"

    /// <summary>
    /// The discrete quantity with unit
    /// <see href="https://purl.org/edifact/ontology#hasDiscreteQuantityWithUnit"></see></summary>
    let hasDiscreteQuantityWithUnit = _prefix "hasDiscreteQuantityWithUnit"
    /// <summary>
    /// Indicates the function of the message
    /// <see href="https://purl.org/edifact/ontology#hasDocumentFunction"></see></summary>
    let hasDocumentFunction = _prefix "hasDocumentFunction"
    /// <summary>
    /// Document/message number
    /// <see href="https://purl.org/edifact/ontology#hasDocumentNumber"></see></summary>
    let hasDocumentNumber = _prefix "hasDocumentNumber"
    /// <summary>
    /// Document/message identifier expressed
    /// <see href="https://purl.org/edifact/ontology#hasDocumentType"></see></summary>
    let hasDocumentType = _prefix "hasDocumentType"
    /// <summary>
    /// Due date
    /// <see href="https://purl.org/edifact/ontology#hasDueDate"></see></summary>
    let hasDueDate = _prefix "hasDueDate"
    /// <summary>
    /// Amount of the discount due
    /// <see href="https://purl.org/edifact/ontology#hasDueDeductionAmount"></see></summary>
    let hasDueDeductionAmount = _prefix "hasDueDeductionAmount"
    /// <summary>
    /// Amount to be paid for moving goods, by whatever means, from one place to another, inclusive discounts, allowances, rebates, adjustment factors and additional cost relating to freight costs (UN/ECE Recommendation no 23).
    /// <see href="https://purl.org/edifact/ontology#hasFreightCharge"></see></summary>
    let hasFreightCharge = _prefix "hasFreightCharge"
    /// <summary>
    /// Describes the role of a party involved in the invoice
    /// <see href="https://purl.org/edifact/ontology#hasFunctionInInvoice"></see></summary>
    let hasFunctionInInvoice = _prefix "hasFunctionInInvoice"
    /// <summary>
    /// Tax levied on the final consumption of goods and services throughout the production and distribution chain.
    /// <see href="https://purl.org/edifact/ontology#hasGSTrate"></see></summary>
    let hasGSTrate = _prefix "hasGSTrate"
    /// <summary>
    /// Contains the TAX rate
    /// <see href="https://purl.org/edifact/ontology#hasTAXrate"></see></summary>
    let hasTAXrate = _prefix "hasTAXrate"
    /// <summary>
    /// Contains general information about the Invoice or a Item
    /// <see href="https://purl.org/edifact/ontology#hasGeneralInformation"></see></summary>
    let hasGeneralInformation = _prefix "hasGeneralInformation"
    /// <summary>
    /// The price stated is the gross price per item to which allowances/ charges must be applied.
    /// <see href="https://purl.org/edifact/ontology#hasGrosspriceOfItem"></see></summary>
    let hasGrosspriceOfItem = _prefix "hasGrosspriceOfItem"
    /// <summary>
    /// The price stated is the gross price per unit to which allowances/ charges must be applied.
    /// <see href="https://purl.org/edifact/ontology#hasGrosspricePerUnit"></see></summary>
    let hasGrosspricePerUnit = _prefix "hasGrosspricePerUnit"
    /// <summary>
    /// Numeric value of height
    /// <see href="https://purl.org/edifact/ontology#hasHeightDimension"></see></summary>
    let hasHeightDimension = _prefix "hasHeightDimension"
    /// <summary>
    /// Total sum charged in respect of a single Invoice in accordance with the terms of delivery.
    /// <see href="https://purl.org/edifact/ontology#hasInvoiceAmount"></see></summary>
    let hasInvoiceAmount = _prefix "hasInvoiceAmount"
    /// <summary>
    /// Contains the Invoice Details of an Invoice
    /// <see href="https://purl.org/edifact/ontology#hasInvoiceDetails"></see></summary>
    let hasInvoiceDetails = _prefix "hasInvoiceDetails"
    /// <summary>
    /// shows to which Invoice the Invoice Details belong
    /// <see href="https://purl.org/edifact/ontology#isInvoiceDetailsOf"></see></summary>
    let isInvoiceDetailsOf = _prefix "isInvoiceDetailsOf"
    /// <summary>
    /// Percentage used in the whole invoice
    /// <see href="https://purl.org/edifact/ontology#hasInvoicePercentage"></see></summary>
    let hasInvoicePercentage = _prefix "hasInvoicePercentage"

    /// <summary>
    /// Percentage used in the whole invoice with payment conditions
    /// <see href="https://purl.org/edifact/ontology#hasInvoicePercentagePaymentConditions"></see></summary>
    let hasInvoicePercentagePaymentConditions =
        _prefix "hasInvoicePercentagePaymentConditions"

    /// <summary>
    /// Referenced price taken from an invoice
    /// <see href="https://purl.org/edifact/ontology#hasInvoiceprice"></see></summary>
    let hasInvoiceprice = _prefix "hasInvoiceprice"
    /// <summary>
    /// shows which items are included in an invoice
    /// <see href="https://purl.org/edifact/ontology#hasItem"></see></summary>
    let hasItem = _prefix "hasItem"
    /// <summary>
    /// shows to which Invoice the item belongs
    /// <see href="https://purl.org/edifact/ontology#isItemOf"></see></summary>
    let isItemOf = _prefix "isItemOf"
    /// <summary>
    /// Length of pieces or packages stated for transport purposes
    /// <see href="https://purl.org/edifact/ontology#hasLengthMeasurements"></see></summary>
    let hasLengthMeasurements = _prefix "hasLengthMeasurements"
    /// <summary>
    /// Goods item total minus allowances plus charges for line item.
    /// <see href="https://purl.org/edifact/ontology#hasLineItemAmount"></see></summary>
    let hasLineItemAmount = _prefix "hasLineItemAmount"
    /// <summary>
    /// The price stated is the net price per item including allowances/ charges. Allowances/charges may be stated for information only.
    /// <see href="https://purl.org/edifact/ontology#hasNetPriceOfItem"></see></summary>
    let hasNetPriceOfItem = _prefix "hasNetPriceOfItem"
    /// <summary>
    /// Weight (mass) of the goods themselves without any packing
    /// <see href="https://purl.org/edifact/ontology#hasNetWeight"></see></summary>
    let hasNetWeight = _prefix "hasNetWeight"
    /// <summary>
    /// Weight (mass) of goods including any packing normally going with them to a buyer in a retail sale
    /// <see href="https://purl.org/edifact/ontology#hasNetWeightPerUnit"></see></summary>
    let hasNetWeightPerUnit = _prefix "hasNetWeightPerUnit"
    /// <summary>
    /// The price stated is the net price per unit including allowances/ charges. Allowances/charges may be stated for information only.
    /// <see href="https://purl.org/edifact/ontology#hasNetpricePerUnit"></see></summary>
    let hasNetpricePerUnit = _prefix "hasNetpricePerUnit"
    /// <summary>
    /// Amount of the payment discount
    /// <see href="https://purl.org/edifact/ontology#hasPaymentDiscountAmount"></see></summary>
    let hasPaymentDiscountAmount = _prefix "hasPaymentDiscountAmount"
    /// <summary>
    /// Amount of the penalty
    /// <see href="https://purl.org/edifact/ontology#hasPenaltyAmount"></see></summary>
    let hasPenaltyAmount = _prefix "hasPenaltyAmount"
    /// <summary>
    /// Penalty expressed as a percentage.
    /// <see href="https://purl.org/edifact/ontology#hasPenaltyPercentage"></see></summary>
    let hasPenaltyPercentage = _prefix "hasPenaltyPercentage"

    /// <summary>
    /// Penalty expressed as a percentage with payment conditions
    /// <see href="https://purl.org/edifact/ontology#hasPenaltyPercentagePaymentConditions"></see></summary>
    let hasPenaltyPercentagePaymentConditions =
        _prefix "hasPenaltyPercentagePaymentConditions"

    /// <summary>
    /// Specified measurement dimensions refer to physical dimensions of a product, material or package
    /// <see href="https://purl.org/edifact/ontology#hasPhysicalDimension"></see></summary>
    let hasPhysicalDimension = _prefix "hasPhysicalDimension"
    /// <summary>
    /// Amount which has been prepaid in advance
    /// <see href="https://purl.org/edifact/ontology#hasPrepaidAmount"></see></summary>
    let hasPrepaidAmount = _prefix "hasPrepaidAmount"
    /// <summary>
    /// Identification of the type of price of an item
    /// <see href="https://purl.org/edifact/ontology#hasPriceSource"></see></summary>
    let hasPriceSource = _prefix "hasPriceSource"
    /// <summary>
    /// Identification pricing specification
    /// <see href="https://purl.org/edifact/ontology#hasPriceType"></see></summary>
    let hasPriceType = _prefix "hasPriceType"
    /// <summary>
    /// Contains measure unit qualifier of a price
    /// <see href="https://purl.org/edifact/ontology#hasPriceUnit"></see></summary>
    let hasPriceUnit = _prefix "hasPriceUnit"
    /// <summary>
    /// Contains measure unit qualifier
    /// <see href="https://purl.org/edifact/ontology#hasUnit"></see></summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    /// Identification of the product
    /// <see href="https://purl.org/edifact/ontology#hasProductIdentification"></see></summary>
    let hasProductIdentification = _prefix "hasProductIdentification"
    /// <summary>
    /// Contains measure unit qualifier of a quantity
    /// <see href="https://purl.org/edifact/ontology#hasQuantityUnit"></see></summary>
    let hasQuantityUnit = _prefix "hasQuantityUnit"
    /// <summary>
    /// Amount which was remitted
    /// <see href="https://purl.org/edifact/ontology#hasRemittedtAmount"></see></summary>
    let hasRemittedtAmount = _prefix "hasRemittedtAmount"
    /// <summary>
    /// Date on which buyer requests goods to be delivered.
    /// <see href="https://purl.org/edifact/ontology#hasRequiredDeliveryDate"></see></summary>
    let hasRequiredDeliveryDate = _prefix "hasRequiredDeliveryDate"
    /// <summary>
    /// A measurement indicating limitation in relation to storage.
    /// <see href="https://purl.org/edifact/ontology#hasStockRestriction"></see></summary>
    let hasStockRestriction = _prefix "hasStockRestriction"
    /// <summary>
    /// Tax imposed by government or other official authority related to the weight/volume charge or valuation charge
    /// <see href="https://purl.org/edifact/ontology#hasTaxAmount"></see></summary>
    let hasTaxAmount = _prefix "hasTaxAmount"
    /// <summary>
    /// Amount for tax calculation
    /// <see href="https://purl.org/edifact/ontology#hasTaxableAmount"></see></summary>
    let hasTaxableAmount = _prefix "hasTaxableAmount"
    /// <summary>
    /// Date by which payment should be made if discount terms are to apply.
    /// <see href="https://purl.org/edifact/ontology#hasTermsDiscountDueDate"></see></summary>
    let hasTermsDiscountDueDate = _prefix "hasTermsDiscountDueDate"
    /// <summary>
    /// Date by which payment must be made
    /// <see href="https://purl.org/edifact/ontology#hasTermsNetDueDate"></see></summary>
    let hasTermsNetDueDate = _prefix "hasTermsNetDueDate"
    /// <summary>
    /// The amount specified is the total of all charges/allowances.
    /// <see href="https://purl.org/edifact/ontology#hasTotalAdditionsAndDeductions"></see></summary>
    let hasTotalAdditionsAndDeductions = _prefix "hasTotalAdditionsAndDeductions"
    /// <summary>
    /// The amount specified is the total amount
    /// <see href="https://purl.org/edifact/ontology#hasTotalAmount"></see></summary>
    let hasTotalAmount = _prefix "hasTotalAmount"
    /// <summary>
    /// The total Amount of the Message
    /// <see href="https://purl.org/edifact/ontology#hasTotalAmountMessage"></see></summary>
    let hasTotalAmountMessage = _prefix "hasTotalAmountMessage"

    /// <summary>
    /// Part of the invoice amount which is subject to payment discount.
    /// <see href="https://purl.org/edifact/ontology#hasTotalAmountUnderPaymentReduction"></see></summary>
    let hasTotalAmountUnderPaymentReduction =
        _prefix "hasTotalAmountUnderPaymentReduction"

    /// <summary>
    /// Total of all duty/tax/fee amounts.
    /// <see href="https://purl.org/edifact/ontology#hasTotalDutyTaxFeeAmount"></see></summary>
    let hasTotalDutyTaxFeeAmount = _prefix "hasTotalDutyTaxFeeAmount"
    /// <summary>
    /// Net price x quantity for the line item
    /// <see href="https://purl.org/edifact/ontology#hasTotalGoodsPosition"></see></summary>
    let hasTotalGoodsPosition = _prefix "hasTotalGoodsPosition"
    /// <summary>
    /// The sum of all the line item amounts.
    /// <see href="https://purl.org/edifact/ontology#hasTotalLineItemAmount"></see></summary>
    let hasTotalLineItemAmount = _prefix "hasTotalLineItemAmount"
    /// <summary>
    /// A measurement indicating limitations in relation to transportation equipment.
    /// <see href="https://purl.org/edifact/ontology#hasTransportRestriction"></see></summary>
    let hasTransportRestriction = _prefix "hasTransportRestriction"
    /// <summary>
    /// Reporting monetary amount is a 'per unit' amount
    /// <see href="https://purl.org/edifact/ontology#hasUnitPrice"></see></summary>
    let hasUnitPrice = _prefix "hasUnitPrice"
    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify the buyer for use in relation to Value Added Tax (VAT).
    /// <see href="https://purl.org/edifact/ontology#hasVATIdentifierBuyer"></see></summary>
    let hasVATIdentifierBuyer = _prefix "hasVATIdentifierBuyer"
    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify the delivery party for use in relation to Value Added Tax (VAT).
    /// <see href="https://purl.org/edifact/ontology#hasVATIdentifierDeliveryParty"></see></summary>
    let hasVATIdentifierDeliveryParty = _prefix "hasVATIdentifierDeliveryParty"
    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify the invoicee for use in relation to Value Added Tax (VAT).
    /// <see href="https://purl.org/edifact/ontology#hasVATIdentifierInvoicee"></see></summary>
    let hasVATIdentifierInvoicee = _prefix "hasVATIdentifierInvoicee"
    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify the payer for use in relation to Value Added Tax (VAT).
    /// <see href="https://purl.org/edifact/ontology#hasVATIdentifierPayer"></see></summary>
    let hasVATIdentifierPayer = _prefix "hasVATIdentifierPayer"
    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify the supplier for use in relation to Value Added Tax (VAT).
    /// <see href="https://purl.org/edifact/ontology#hasVATIdentifierSupplier"></see></summary>
    let hasVATIdentifierSupplier = _prefix "hasVATIdentifierSupplier"
    /// <summary>
    /// Amount in national currency resulting from the application, at the appropriate rate, of value added tax (or similar tax) to the invoice amount subject to such tax
    /// <see href="https://purl.org/edifact/ontology#hasVATamount"></see></summary>
    let hasVATamount = _prefix "hasVATamount"
    /// <summary>
    /// First VAT value if, for the same rate of VAT, there are 1 to 3 different ways to set this value
    /// <see href="https://purl.org/edifact/ontology#hasVATfirstValue"></see></summary>
    let hasVATfirstValue = _prefix "hasVATfirstValue"
    /// <summary>
    /// A tax on domestic or imported goods applied to the value added at each stage in the production/distribution cycle.
    /// <see href="https://purl.org/edifact/ontology#hasVATrate"></see></summary>
    let hasVATrate = _prefix "hasVATrate"
    /// <summary>
    /// Reference number assigned by the issuing authority to an Import Licence.
    /// <see href="https://purl.org/edifact/ontology#importLicenseNumber"></see></summary>
    let importLicenseNumber = _prefix "importLicenseNumber"
    /// <summary>
    /// Note contains customs declaration information.
    /// <see href="https://purl.org/edifact/ontology#informationCustomsDeclaration"></see></summary>
    let informationCustomsDeclaration = _prefix "informationCustomsDeclaration"
    /// <summary>
    /// Note contains invoice instructions
    /// <see href="https://purl.org/edifact/ontology#instructionForInvoicingParty"></see></summary>
    let instructionForInvoicingParty = _prefix "instructionForInvoicingParty"
    /// <summary>
    /// Number assigned by a seller, supplier etc. to identify a customer within his enterprise.
    /// <see href="https://purl.org/edifact/ontology#internalCustomerNumber"></see></summary>
    let internalCustomerNumber = _prefix "internalCustomerNumber"
    /// <summary>
    /// Number identifying the company-internal vending department/unit.
    /// <see href="https://purl.org/edifact/ontology#internalVendorNumber"></see></summary>
    let internalVendorNumber = _prefix "internalVendorNumber"
    /// <summary>
    /// Number assigned to a manufacturer's product according to the International Article Numbering Association.
    /// <see href="https://purl.org/edifact/ontology#internationalArticleNumber"></see></summary>
    let internationalArticleNumber = _prefix "internationalArticleNumber"
    /// <summary>
    /// The name or symbol of the monetary unit used for calculation in an invoice.
    /// <see href="https://purl.org/edifact/ontology#invoiceCurrency"></see></summary>
    let invoiceCurrency = _prefix "invoiceCurrency"
    /// <summary>
    /// Item number assigned by the buyer to identify an article.
    /// <see href="https://purl.org/edifact/ontology#itemNumberBuyer"></see></summary>
    let itemNumberBuyer = _prefix "itemNumberBuyer"
    /// <summary>
    /// The number given to an article by its manufacturer.
    /// <see href="https://purl.org/edifact/ontology#itemNumberManufacturer"></see></summary>
    let itemNumberManufacturer = _prefix "itemNumberManufacturer"
    /// <summary>
    /// Number assigned to an article by the supplier of that article.
    /// <see href="https://purl.org/edifact/ontology#itemNumberSupplier"></see></summary>
    let itemNumberSupplier = _prefix "itemNumberSupplier"
    /// <summary>
    /// Reference number identifying a particular line in a document.
    /// <see href="https://purl.org/edifact/ontology#lineItemReferenceNumber"></see></summary>
    let lineItemReferenceNumber = _prefix "lineItemReferenceNumber"
    /// <summary>
    /// Period a specified charge is valid for.
    /// <see href="https://purl.org/edifact/ontology#loadPeriod"></see></summary>
    let loadPeriod = _prefix "loadPeriod"
    /// <summary>
    /// Identification of the managing organization
    /// <see href="https://purl.org/edifact/ontology#managingOrganisations"></see></summary>
    let managingOrganisations = _prefix "managingOrganisations"
    /// <summary>
    /// The reference number of the message
    /// <see href="https://purl.org/edifact/ontology#messageReferenceNumber"></see></summary>
    let messageReferenceNumber = _prefix "messageReferenceNumber"
    /// <summary>
    /// The identifier of the message type
    /// <see href="https://purl.org/edifact/ontology#messageTypeIdentifier"></see></summary>
    let messageTypeIdentifier = _prefix "messageTypeIdentifier"
    /// <summary>
    /// National product group code. Administered by a national agency.
    /// <see href="https://purl.org/edifact/ontology#nationalProductGroupCode"></see></summary>
    let nationalProductGroupCode = _prefix "nationalProductGroupCode"
    /// <summary>
    /// No increases or reduction in price (list or stated) are included.
    /// <see href="https://purl.org/edifact/ontology#noDiscountAllowance"></see></summary>
    let noDiscountAllowance = _prefix "noDiscountAllowance"
    /// <summary>
    /// Consolidated invoice number with EAN code
    /// <see href="https://purl.org/edifact/ontology#numberConsolidatedInvoiceEANCode"></see></summary>
    let numberConsolidatedInvoiceEANCode = _prefix "numberConsolidatedInvoiceEANCode"
    /// <summary>
    /// A batch number identifying a batch of messages.
    /// <see href="https://purl.org/edifact/ontology#numberOfBundleMessages"></see></summary>
    let numberOfBundleMessages = _prefix "numberOfBundleMessages"
    /// <summary>
    /// Reference number assigned by issuing party to an offer.
    /// <see href="https://purl.org/edifact/ontology#offerNumber"></see></summary>
    let offerNumber = _prefix "offerNumber"
    /// <summary>
    /// The name or symbol of the monetary unit used in an order.
    /// <see href="https://purl.org/edifact/ontology#orderCurrency"></see></summary>
    let orderCurrency = _prefix "orderCurrency"
    /// <summary>
    /// Date when an order is issued.
    /// <see href="https://purl.org/edifact/ontology#orderDate"></see></summary>
    let orderDate = _prefix "orderDate"
    /// <summary>
    /// Reference number of an order.
    /// <see href="https://purl.org/edifact/ontology#orderNumber"></see></summary>
    let orderNumber = _prefix "orderNumber"
    /// <summary>
    /// Reference number assigned by the buyer to an order.
    /// <see href="https://purl.org/edifact/ontology#orderNumberBuyer"></see></summary>
    let orderNumberBuyer = _prefix "orderNumberBuyer"
    /// <summary>
    /// Reference number assigned by issuer to a delivery order.
    /// <see href="https://purl.org/edifact/ontology#orderNumberDelivery"></see></summary>
    let orderNumberDelivery = _prefix "orderNumberDelivery"
    /// <summary>
    /// Reference number assigned by supplier to a buyer's purchase order.
    /// <see href="https://purl.org/edifact/ontology#orderNumberSupplier"></see></summary>
    let orderNumberSupplier = _prefix "orderNumberSupplier"
    /// <summary>
    /// Reference of the originator
    /// <see href="https://purl.org/edifact/ontology#originatorReference"></see></summary>
    let originatorReference = _prefix "originatorReference"
    /// <summary>
    /// General information created by the sender of general or specific value.
    /// <see href="https://purl.org/edifact/ontology#otherServiceInformation"></see></summary>
    let otherServiceInformation = _prefix "otherServiceInformation"
    /// <summary>
    /// Reference number assigned by the buyer to identify an article.
    /// <see href="https://purl.org/edifact/ontology#partNumberBuyer"></see></summary>
    let partNumberBuyer = _prefix "partNumberBuyer"
    /// <summary>
    /// Type of the payment terms
    /// <see href="https://purl.org/edifact/ontology#paymentCondition"></see></summary>
    let paymentCondition = _prefix "paymentCondition"
    /// <summary>
    /// The name or symbol of the monetary unit used for payment.
    /// <see href="https://purl.org/edifact/ontology#paymentCurrency"></see></summary>
    let paymentCurrency = _prefix "paymentCurrency"
    /// <summary>
    /// Reference number assigned to a payment.
    /// <see href="https://purl.org/edifact/ontology#paymentReference"></see></summary>
    let paymentReference = _prefix "paymentReference"
    /// <summary>
    /// Number of the Position of the Line in the whole message
    /// <see href="https://purl.org/edifact/ontology#positionLineNumber"></see></summary>
    let positionLineNumber = _prefix "positionLineNumber"
    /// <summary>
    /// Price and Delivery Conditions of the article displayed in the invoice
    /// <see href="https://purl.org/edifact/ontology#priceAndDeliveryCondition"></see></summary>
    let priceAndDeliveryCondition = _prefix "priceAndDeliveryCondition"
    /// <summary>
    /// Condition of the Price
    /// <see href="https://purl.org/edifact/ontology#priceCondition"></see></summary>
    let priceCondition = _prefix "priceCondition"
    /// <summary>
    /// The name or symbol of the monetary unit used for pricing purposes
    /// <see href="https://purl.org/edifact/ontology#priceCurrency"></see></summary>
    let priceCurrency = _prefix "priceCurrency"
    /// <summary>
    /// Reference number assigned to a price list.
    /// <see href="https://purl.org/edifact/ontology#priceListNumber"></see></summary>
    let priceListNumber = _prefix "priceListNumber"
    /// <summary>
    /// Reference number assigned by the seller to a Proforma Invoice.
    /// <see href="https://purl.org/edifact/ontology#proformaInvoiceNumber"></see></summary>
    let proformaInvoiceNumber = _prefix "proformaInvoiceNumber"
    /// <summary>
    /// Number of the promotional variant number
    /// <see href="https://purl.org/edifact/ontology#promotionalVariantNumber"></see></summary>
    let promotionalVariantNumber = _prefix "promotionalVariantNumber"
    /// <summary>
    /// Note contains purchasing information.
    /// <see href="https://purl.org/edifact/ontology#purchasingInformation"></see></summary>
    let purchasingInformation = _prefix "purchasingInformation"
    /// <summary>
    /// Date/time upon which the goods were received by a given party.
    /// <see href="https://purl.org/edifact/ontology#receiptGoodsDate"></see></summary>
    let receiptGoodsDate = _prefix "receiptGoodsDate"
    /// <summary>
    /// A reference number to a receiving advice.
    /// <see href="https://purl.org/edifact/ontology#receivingAdviceNumber"></see></summary>
    let receivingAdviceNumber = _prefix "receivingAdviceNumber"
    /// <summary>
    /// Indiactor whos the recipient of the message
    /// <see href="https://purl.org/edifact/ontology#recipientIndicator"></see></summary>
    let recipientIndicator = _prefix "recipientIndicator"
    /// <summary>
    /// Quantity which has been received and accepted at a given location.
    /// <see href="https://purl.org/edifact/ontology#recivedAndAcceptedQuantity"></see></summary>
    let recivedAndAcceptedQuantity = _prefix "recivedAndAcceptedQuantity"

    /// <summary>
    /// Quantity which has been received and accepted at a given location with the unit
    /// <see href="https://purl.org/edifact/ontology#recivedAndAcceptedQuantityWithUnit"></see></summary>
    let recivedAndAcceptedQuantityWithUnit =
        _prefix "recivedAndAcceptedQuantityWithUnit"

    /// <summary>
    /// Reference number for a business account statement as EAN code
    /// <see href="https://purl.org/edifact/ontology#referenceNumberBusinessContactExtractEANCode"></see></summary>
    let referenceNumberBusinessContactExtractEANCode =
        _prefix "referenceNumberBusinessContactExtractEANCode"

    /// <summary>
    /// Reference number assigned by the customer to a transaction.
    /// <see href="https://purl.org/edifact/ontology#referenceNumberCustomer"></see></summary>
    let referenceNumberCustomer = _prefix "referenceNumberCustomer"
    /// <summary>
    /// Related document number
    /// <see href="https://purl.org/edifact/ontology#relatedDocumentNumber"></see></summary>
    let relatedDocumentNumber = _prefix "relatedDocumentNumber"
    /// <summary>
    /// Release number within the current message version number.
    /// <see href="https://purl.org/edifact/ontology#releaseNumberMessageType"></see></summary>
    let releaseNumberMessageType = _prefix "releaseNumberMessageType"
    /// <summary>
    /// The free text contains information for regulatory authority.
    /// <see href="https://purl.org/edifact/ontology#reportingInformation"></see></summary>
    let reportingInformation = _prefix "reportingInformation"
    /// <summary>
    /// The return quantity
    /// <see href="https://purl.org/edifact/ontology#returnQuantity"></see></summary>
    let returnQuantity = _prefix "returnQuantity"
    /// <summary>
    /// The return quantity with unit
    /// <see href="https://purl.org/edifact/ontology#returnQuantityWithUnit"></see></summary>
    let returnQuantityWithUnit = _prefix "returnQuantityWithUnit"
    /// <summary>
    /// Reference number assigned to a transaction by the seller
    /// <see href="https://purl.org/edifact/ontology#sellersReferenceNumber"></see></summary>
    let sellersReferenceNumber = _prefix "sellersReferenceNumber"
    /// <summary>
    /// Indicator who the sender is
    /// <see href="https://purl.org/edifact/ontology#senderIndicator"></see></summary>
    let senderIndicator = _prefix "senderIndicator"
    /// <summary>
    /// Number assigned by the issuer to his specification.
    /// <see href="https://purl.org/edifact/ontology#specificationNumber"></see></summary>
    let specificationNumber = _prefix "specificationNumber"
    /// <summary>
    /// Remarks from or for a supplier of goods or services.
    /// <see href="https://purl.org/edifact/ontology#supplierNote"></see></summary>
    let supplierNote = _prefix "supplierNote"
    /// <summary>
    /// Identification of the used synatx
    /// <see href="https://purl.org/edifact/ontology#synatxIdentifier"></see></summary>
    let synatxIdentifier = _prefix "synatxIdentifier"
    /// <summary>
    /// Version of the used syntax
    /// <see href="https://purl.org/edifact/ontology#synatxVersion"></see></summary>
    let synatxVersion = _prefix "synatxVersion"
    /// <summary>
    /// Period a tax rate/tax amount etc. is applicable.
    /// <see href="https://purl.org/edifact/ontology#taxPeriod"></see></summary>
    let taxPeriod = _prefix "taxPeriod"
    /// <summary>
    /// The total number of the segments
    /// <see href="https://purl.org/edifact/ontology#totalNumberOfSegments"></see></summary>
    let totalNumberOfSegments = _prefix "totalNumberOfSegments"
    /// <summary>
    /// The Unit price basis
    /// <see href="https://purl.org/edifact/ontology#unitPriceBasis"></see></summary>
    let unitPriceBasis = _prefix "unitPriceBasis"
    /// <summary>
    /// Number assigned to a manufacturer's product by the Product Code Council.
    /// <see href="https://purl.org/edifact/ontology#universalProductCode"></see></summary>
    let universalProductCode = _prefix "universalProductCode"
    /// <summary>
    /// Document date in the future from which the agreed payment period begins
    /// <see href="https://purl.org/edifact/ontology#valutaDate"></see></summary>
    let valutaDate = _prefix "valutaDate"
    /// <summary>
    /// Version number of a message type
    /// <see href="https://purl.org/edifact/ontology#versionNumberMessageType"></see></summary>
    let versionNumberMessageType = _prefix "versionNumberMessageType"
    /// <summary>
    /// Numeric value of width
    /// <see href="https://purl.org/edifact/ontology#widthDimension"></see></summary>
    let widthDimension = _prefix "widthDimension"
    /// <summary>
    /// Quantity of goods which are free of charge.
    /// <see href="https://purl.org/edifact/ontology#withoutCalculationQuantity"></see></summary>
    let withoutCalculationQuantity = _prefix "withoutCalculationQuantity"

    /// <summary>
    /// Quantity of goods which are free of charge with unit
    /// <see href="https://purl.org/edifact/ontology#withoutCalculationQuantityWithUnit"></see></summary>
    let withoutCalculationQuantityWithUnit =
        _prefix "withoutCalculationQuantityWithUnit"
