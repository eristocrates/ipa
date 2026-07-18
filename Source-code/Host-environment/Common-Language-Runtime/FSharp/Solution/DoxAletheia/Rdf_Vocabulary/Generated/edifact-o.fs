namespace https.purl.org.edifact.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module edifact_o =
    let _namespace_name = "https://purl.org/edifact/ontology#"

    /// <summary>
    /// The class containing information about the perfomed role of the involved organizations
    /// <see href="https://purl.org/edifact/ontology#FormalOrganization"></see></summary>
    let FormalOrganization =
        Namespaced_IRI.parse _namespace_name "FormalOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/edifact/ontology#seeXML"></see>
    /// </summary>
    let seeXML = Namespaced_IRI.parse _namespace_name "seeXML" |> NamespacedName

    /// <summary>
    /// Defined as the union of the classes Item and InvoiceDetails
    /// <see href="https://purl.org/edifact/ontology#InvoiceContent"></see></summary>
    let InvoiceContent =
        Namespaced_IRI.parse _namespace_name "InvoiceContent" |> NamespacedName

    /// <summary>
    /// The root class of each invoice. Contains all the linked classes with information about the invoice
    /// <see href="https://purl.org/edifact/ontology#E-Invoice"></see></summary>
    let ``E-Invoice`` =
        Namespaced_IRI.parse _namespace_name "E-Invoice" |> NamespacedName

    /// <summary>
    /// Contains all the information about a item
    /// <see href="https://purl.org/edifact/ontology#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName

    /// <summary>
    /// The role of a party acting in the name of the seller as broker or as sales office.
    /// <see href="https://purl.org/edifact/ontology#BrokerSalesOfficeRole"></see></summary>
    let BrokerSalesOfficeRole =
        Namespaced_IRI.parse _namespace_name "BrokerSalesOfficeRole" |> NamespacedName

    /// <summary>
    /// The role of the party to which articles are sold
    /// <see href="https://purl.org/edifact/ontology#BuyerRole"></see></summary>
    let BuyerRole = Namespaced_IRI.parse _namespace_name "BuyerRole" |> NamespacedName

    /// <summary>
    /// The role of the party receiving goods and relevant invoice
    /// <see href="https://purl.org/edifact/ontology#CalculateDeliverToRole"></see></summary>
    let CalculateDeliverToRole =
        Namespaced_IRI.parse _namespace_name "CalculateDeliverToRole" |> NamespacedName

    /// <summary>
    /// The role of the party which is the central regulator
    /// <see href="https://purl.org/edifact/ontology#CentralRegulatorRole"></see></summary>
    let CentralRegulatorRole =
        Namespaced_IRI.parse _namespace_name "CentralRegulatorRole" |> NamespacedName

    /// <summary>
    /// The role of the party to which goods should be delivered, if not identical with consignee.
    /// <see href="https://purl.org/edifact/ontology#DeliveryPartyRole"></see></summary>
    let DeliveryPartyRole =
        Namespaced_IRI.parse _namespace_name "DeliveryPartyRole" |> NamespacedName

    /// <summary>
    /// The role of the party where goods are collected or taken over by the carrier (i.e. if other than consignor)
    /// <see href="https://purl.org/edifact/ontology#DespatchPartyRole"></see></summary>
    let DespatchPartyRole =
        Namespaced_IRI.parse _namespace_name "DespatchPartyRole" |> NamespacedName

    /// <summary>
    /// Contains all the information which are necessary for the invoice to be a valid EDIFACT Invoice
    /// <see href="https://purl.org/edifact/ontology#EDIFACT-Structure"></see></summary>
    let ``EDIFACT-Structure`` =
        Namespaced_IRI.parse _namespace_name "EDIFACT-Structure" |> NamespacedName

    /// <summary>
    /// The role of the party who has been designated on the invoice or packing list as the final recipient of the stated merchandise.
    /// <see href="https://purl.org/edifact/ontology#FinalConsigneeRole"></see></summary>
    let FinalConsigneeRole =
        Namespaced_IRI.parse _namespace_name "FinalConsigneeRole" |> NamespacedName

    /// <summary>
    /// Contains all the general information about an invoice
    /// <see href="https://purl.org/edifact/ontology#InvoiceDetails"></see></summary>
    let InvoiceDetails =
        Namespaced_IRI.parse _namespace_name "InvoiceDetails" |> NamespacedName

    /// <summary>
    /// The role of the party to whom an invoice is issued
    /// <see href="https://purl.org/edifact/ontology#InvoiceeRole"></see></summary>
    let InvoiceeRole =
        Namespaced_IRI.parse _namespace_name "InvoiceeRole" |> NamespacedName

    /// <summary>
    /// The role of the party issuing an invoice
    /// <see href="https://purl.org/edifact/ontology#InvoicingPartyRole"></see></summary>
    let InvoicingPartyRole =
        Namespaced_IRI.parse _namespace_name "InvoicingPartyRole" |> NamespacedName

    /// <summary>
    /// The role of the party initiating payment
    /// <see href="https://purl.org/edifact/ontology#PayeeRole"></see></summary>
    let PayeeRole = Namespaced_IRI.parse _namespace_name "PayeeRole" |> NamespacedName

    /// <summary>
    /// The role of the party to whom payment for a commercial invoice or bill should be remitted.
    /// <see href="https://purl.org/edifact/ontology#RecipientOfInvoiceRegulationRole"></see></summary>
    let RecipientOfInvoiceRegulationRole =
        Namespaced_IRI.parse _namespace_name "RecipientOfInvoiceRegulationRole" |> NamespacedName

    /// <summary>
    /// The role of the party to which goods are consigned.
    /// <see href="https://purl.org/edifact/ontology#RecipientRole"></see></summary>
    let RecipientRole =
        Namespaced_IRI.parse _namespace_name "RecipientRole" |> NamespacedName

    /// <summary>
    /// The role of the party which is the regulator of the invoice
    /// <see href="https://purl.org/edifact/ontology#RegulatorRole"></see></summary>
    let RegulatorRole =
        Namespaced_IRI.parse _namespace_name "RegulatorRole" |> NamespacedName

    /// <summary>
    /// The role of the party representing the seller for the purpose of the trade transaction.
    /// <see href="https://purl.org/edifact/ontology#RepresentativeOfSupplierRole"></see></summary>
    let RepresentativeOfSupplierRole =
        Namespaced_IRI.parse _namespace_name "RepresentativeOfSupplierRole" |> NamespacedName

    /// <summary>
    /// The role of the third party who arranged the purchase of merchandise on behalf of the actual buyer
    /// <see href="https://purl.org/edifact/ontology#SalesAgentRole"></see></summary>
    let SalesAgentRole =
        Namespaced_IRI.parse _namespace_name "SalesAgentRole" |> NamespacedName

    /// <summary>
    /// The role of the party selling merchandise to a buyer.
    /// <see href="https://purl.org/edifact/ontology#SellerRole"></see></summary>
    let SellerRole = Namespaced_IRI.parse _namespace_name "SellerRole" |> NamespacedName
    /// <summary>
    /// The role of the party to where goods will be or have been shipped
    /// <see href="https://purl.org/edifact/ontology#SendToRole"></see></summary>
    let SendToRole = Namespaced_IRI.parse _namespace_name "SendToRole" |> NamespacedName

    /// <summary>
    /// The role of the party which manufactures or otherwise has possession of goods, and consigns or makes them available in trade.
    /// <see href="https://purl.org/edifact/ontology#SupplierRole"></see></summary>
    let SupplierRole =
        Namespaced_IRI.parse _namespace_name "SupplierRole" |> NamespacedName

    /// <summary>
    /// The role of the party's headquarters which manufactures or otherwise has possession of goods, and consigns or makes them available in trade.
    /// <see href="https://purl.org/edifact/ontology#SuppliersCompanyHeadquarterRole"></see></summary>
    let SuppliersCompanyHeadquarterRole =
        Namespaced_IRI.parse _namespace_name "SuppliersCompanyHeadquarterRole" |> NamespacedName

    /// <summary>
    /// The role of the party that runs the Warehouse
    /// <see href="https://purl.org/edifact/ontology#WarehouseNumberRole"></see></summary>
    let WarehouseNumberRole =
        Namespaced_IRI.parse _namespace_name "WarehouseNumberRole" |> NamespacedName

    /// <summary>
    /// The role of the party that is the wholesaler
    /// <see href="https://purl.org/edifact/ontology#WholesalerRole"></see></summary>
    let WholesalerRole =
        Namespaced_IRI.parse _namespace_name "WholesalerRole" |> NamespacedName

    /// <summary>
    /// Reference number assigned by accounts receivable department to the account of a specific debtor.
    /// <see href="https://purl.org/edifact/ontology#accountsReceivableNumber"></see></summary>
    let accountsReceivableNumber =
        Namespaced_IRI.parse _namespace_name "accountsReceivableNumber" |> NamespacedName

    /// <summary>
    /// identifier which is a number
    /// <see href="https://purl.org/edifact/ontology#noteNumber"></see></summary>
    let noteNumber = Namespaced_IRI.parse _namespace_name "noteNumber" |> NamespacedName

    /// <summary>
    /// Additional Partneridentification (GLN-Code)
    /// <see href="https://purl.org/edifact/ontology#additionalPartnerIdentificationEANCode"></see></summary>
    let additionalPartnerIdentificationEANCode =
        Namespaced_IRI.parse _namespace_name "additionalPartnerIdentificationEANCode" |> NamespacedName

    /// <summary>
    /// Reason for the allowance
    /// <see href="https://purl.org/edifact/ontology#allowanceReason"></see></summary>
    let allowanceReason =
        Namespaced_IRI.parse _namespace_name "allowanceReason" |> NamespacedName

    /// <summary>
    /// Indicates to which business process the invoice belongs
    /// <see href="https://purl.org/edifact/ontology#belongsToProcess"></see></summary>
    let belongsToProcess =
        Namespaced_IRI.parse _namespace_name "belongsToProcess" |> NamespacedName

    /// <summary>
    /// Reference of the beneficiary
    /// <see href="https://purl.org/edifact/ontology#beneficiaryReference"></see></summary>
    let beneficiaryReference =
        Namespaced_IRI.parse _namespace_name "beneficiaryReference" |> NamespacedName

    /// <summary>
    /// Note contains information mutually defined by trading partners
    /// <see href="https://purl.org/edifact/ontology#bilateralAgreed"></see></summary>
    let bilateralAgreed =
        Namespaced_IRI.parse _namespace_name "bilateralAgreed" |> NamespacedName

    /// <summary>
    /// Period for which an invoice is issued.
    /// <see href="https://purl.org/edifact/ontology#calculationPeriod"></see></summary>
    let calculationPeriod =
        Namespaced_IRI.parse _namespace_name "calculationPeriod" |> NamespacedName

    /// <summary>
    /// Contains a time Period
    /// <see href="https://purl.org/edifact/ontology#timePeriod"></see></summary>
    let timePeriod = Namespaced_IRI.parse _namespace_name "timePeriod" |> NamespacedName

    /// <summary>
    /// Note contains change information
    /// <see href="https://purl.org/edifact/ontology#changeInformation"></see></summary>
    let changeInformation =
        Namespaced_IRI.parse _namespace_name "changeInformation" |> NamespacedName

    /// <summary>
    /// Company registration and place as legally required.
    /// <see href="https://purl.org/edifact/ontology#companyOrPlaceRegistristrationNumber"></see></summary>
    let companyOrPlaceRegistristrationNumber =
        Namespaced_IRI.parse _namespace_name "companyOrPlaceRegistristrationNumber" |> NamespacedName

    /// <summary>
    /// Numbers of consumer units in the traded unit
    /// <see href="https://purl.org/edifact/ontology#consumerUnitsInTradingUnitQuantity"></see></summary>
    let consumerUnitsInTradingUnitQuantity =
        Namespaced_IRI.parse _namespace_name "consumerUnitsInTradingUnitQuantity" |> NamespacedName

    /// <summary>
    /// display a quantity
    /// <see href="https://purl.org/edifact/ontology#quantity"></see></summary>
    let quantity = Namespaced_IRI.parse _namespace_name "quantity" |> NamespacedName

    /// <summary>
    /// Numbers of consumer units in the traded unit
    /// <see href="https://purl.org/edifact/ontology#consumerUnitsInTradingUnitQuantityWithUnit"></see></summary>
    let consumerUnitsInTradingUnitQuantityWithUnit =
        Namespaced_IRI.parse _namespace_name "consumerUnitsInTradingUnitQuantityWithUnit" |> NamespacedName

    /// <summary>
    /// The department or person within an organizational entity.
    /// <see href="https://purl.org/edifact/ontology#contactDepartmentPerson"></see></summary>
    let contactDepartmentPerson =
        Namespaced_IRI.parse _namespace_name "contactDepartmentPerson" |> NamespacedName

    /// <summary>
    /// Contact Persons
    /// <see href="https://purl.org/edifact/ontology#contactPersom"></see></summary>
    let contactPersom =
        Namespaced_IRI.parse _namespace_name "contactPersom" |> NamespacedName

    /// <summary>
    /// Department/person responsible for the accounts payable function within a corporation.
    /// <see href="https://purl.org/edifact/ontology#contactPersonAccounting"></see></summary>
    let contactPersonAccounting =
        Namespaced_IRI.parse _namespace_name "contactPersonAccounting" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/edifact/ontology#seeEDIFACT"></see>
    /// </summary>
    let seeEDIFACT = Namespaced_IRI.parse _namespace_name "seeEDIFACT" |> NamespacedName

    /// <summary>
    /// Department/person responsible for the accounts payable function within a corporation
    /// <see href="https://purl.org/edifact/ontology#contactPersonCreditorAccounting"></see></summary>
    let contactPersonCreditorAccounting =
        Namespaced_IRI.parse _namespace_name "contactPersonCreditorAccounting" |> NamespacedName

    /// <summary>
    /// Creating/sending/receiving of unstructured free text messages or documents using computer network, a mini- computer or an attached modem and regular telephone line or other electronic transmission media.
    /// <see href="https://purl.org/edifact/ontology#contactPersonEmailAddress"></see></summary>
    let contactPersonEmailAddress =
        Namespaced_IRI.parse _namespace_name "contactPersonEmailAddress" |> NamespacedName

    /// <summary>
    /// Device used for transmitting and reproducing fixed graphic material (as printing) by means of signals over telephone lines or other electronic transmission media.
    /// <see href="https://purl.org/edifact/ontology#contactPersonFaxNumber"></see></summary>
    let contactPersonFaxNumber =
        Namespaced_IRI.parse _namespace_name "contactPersonFaxNumber" |> NamespacedName

    /// <summary>
    /// Department/person responsible for receiving the goods at the place of delivery.
    /// <see href="https://purl.org/edifact/ontology#contactPersonIncomingGoods"></see></summary>
    let contactPersonIncomingGoods =
        Namespaced_IRI.parse _namespace_name "contactPersonIncomingGoods" |> NamespacedName

    /// <summary>
    /// Department/person to contact for questions regarding transactions
    /// <see href="https://purl.org/edifact/ontology#contactPersonInformation"></see></summary>
    let contactPersonInformation =
        Namespaced_IRI.parse _namespace_name "contactPersonInformation" |> NamespacedName

    /// <summary>
    /// Department/person responsible for issuing this purchase order.
    /// <see href="https://purl.org/edifact/ontology#contactPersonPurchasingDepartment"></see></summary>
    let contactPersonPurchasingDepartment =
        Namespaced_IRI.parse _namespace_name "contactPersonPurchasingDepartment" |> NamespacedName

    /// <summary>
    /// Department/person responsible for the accounts receivable within a corporation
    /// <see href="https://purl.org/edifact/ontology#contactPersonReceivableAccounting"></see></summary>
    let contactPersonReceivableAccounting =
        Namespaced_IRI.parse _namespace_name "contactPersonReceivableAccounting" |> NamespacedName

    /// <summary>
    /// The sales representative or department contact within an organization.
    /// <see href="https://purl.org/edifact/ontology#contactPersonSalesDepartment"></see></summary>
    let contactPersonSalesDepartment =
        Namespaced_IRI.parse _namespace_name "contactPersonSalesDepartment" |> NamespacedName

    /// <summary>
    /// Voice/data transmission by telephone
    /// <see href="https://purl.org/edifact/ontology#contactPersonTelefonNumber"></see></summary>
    let contactPersonTelefonNumber =
        Namespaced_IRI.parse _namespace_name "contactPersonTelefonNumber" |> NamespacedName

    /// <summary>
    /// Transmission of text/data via telex.
    /// <see href="https://purl.org/edifact/ontology#contactPersonTelexNumber"></see></summary>
    let contactPersonTelexNumber =
        Namespaced_IRI.parse _namespace_name "contactPersonTelexNumber" |> NamespacedName

    /// <summary>
    /// CCITT Message handling system
    /// <see href="https://purl.org/edifact/ontology#contactPersonX400Number"></see></summary>
    let contactPersonX400Number =
        Namespaced_IRI.parse _namespace_name "contactPersonX400Number" |> NamespacedName

    /// <summary>
    /// Reference number of a contract concluded between parties.
    /// <see href="https://purl.org/edifact/ontology#contractNumber"></see></summary>
    let contractNumber =
        Namespaced_IRI.parse _namespace_name "contractNumber" |> NamespacedName

    /// <summary>
    /// Reference number assigned by buyer to a contract.
    /// <see href="https://purl.org/edifact/ontology#contractNumberBuyer"></see></summary>
    let contractNumberBuyer =
        Namespaced_IRI.parse _namespace_name "contractNumberBuyer" |> NamespacedName

    /// <summary>
    /// Detail/summary section separation
    /// <see href="https://purl.org/edifact/ontology#controlSegmentBetweenItemAndTotalPart"></see></summary>
    let controlSegmentBetweenItemAndTotalPart =
        Namespaced_IRI.parse _namespace_name "controlSegmentBetweenItemAndTotalPart" |> NamespacedName

    /// <summary>
    /// Date when the message was created
    /// <see href="https://purl.org/edifact/ontology#creationDate"></see></summary>
    let creationDate =
        Namespaced_IRI.parse _namespace_name "creationDate" |> NamespacedName

    /// <summary>
    /// Time of the creation of the EDIFACT message
    /// <see href="https://purl.org/edifact/ontology#creationTime"></see></summary>
    let creationTime =
        Namespaced_IRI.parse _namespace_name "creationTime" |> NamespacedName

    /// <summary>
    /// Reference number assigned to a credit note.
    /// <see href="https://purl.org/edifact/ontology#creditNoteNumber"></see></summary>
    let creditNoteNumber =
        Namespaced_IRI.parse _namespace_name "creditNoteNumber" |> NamespacedName

    /// <summary>
    /// Code number of the goods in accordance with the tariff nomenclature system of classification in use where the Customs declaration is made.
    /// <see href="https://purl.org/edifact/ontology#customsTariffNumber"></see></summary>
    let customsTariffNumber =
        Namespaced_IRI.parse _namespace_name "customsTariffNumber" |> NamespacedName

    /// <summary>
    /// the counter of the exchanged data
    /// <see href="https://purl.org/edifact/ontology#dataExchangeCounter"></see></summary>
    let dataExchangeCounter =
        Namespaced_IRI.parse _namespace_name "dataExchangeCounter" |> NamespacedName

    /// <summary>
    /// the reference of the exchanged data
    /// <see href="https://purl.org/edifact/ontology#dataExchangeReference"></see></summary>
    let dataExchangeReference =
        Namespaced_IRI.parse _namespace_name "dataExchangeReference" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by accounts receivable department to the account of a specific debtor.
    /// <see href="https://purl.org/edifact/ontology#dateAccountsReceivableNumber"></see></summary>
    let dateAccountsReceivableNumber =
        Namespaced_IRI.parse _namespace_name "dateAccountsReceivableNumber" |> NamespacedName

    /// <summary>
    /// Reference Date
    /// <see href="https://purl.org/edifact/ontology#referenceDate"></see></summary>
    let referenceDate =
        Namespaced_IRI.parse _namespace_name "referenceDate" |> NamespacedName

    /// <summary>
    /// Date of Additional Partneridentification (GLN-Code)
    /// <see href="https://purl.org/edifact/ontology#dateAdditionalPartnerIdentificationEANCode"></see></summary>
    let dateAdditionalPartnerIdentificationEANCode =
        Namespaced_IRI.parse _namespace_name "dateAdditionalPartnerIdentificationEANCode" |> NamespacedName

    /// <summary>
    /// Date of the reference of the beneficiary
    /// <see href="https://purl.org/edifact/ontology#dateBeneficiaryReference"></see></summary>
    let dateBeneficiaryReference =
        Namespaced_IRI.parse _namespace_name "dateBeneficiaryReference" |> NamespacedName

    /// <summary>
    /// Date of company registration and place as legally required.
    /// <see href="https://purl.org/edifact/ontology#dateCompanyOrPlaceRegistristrationNumber"></see></summary>
    let dateCompanyOrPlaceRegistristrationNumber =
        Namespaced_IRI.parse _namespace_name "dateCompanyOrPlaceRegistristrationNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number of a contract concluded between parties.
    /// <see href="https://purl.org/edifact/ontology#dateContractNumber"></see></summary>
    let dateContractNumber =
        Namespaced_IRI.parse _namespace_name "dateContractNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by buyer to a contract.
    /// <see href="https://purl.org/edifact/ontology#dateContractNumberBuyer"></see></summary>
    let dateContractNumberBuyer =
        Namespaced_IRI.parse _namespace_name "dateContractNumberBuyer" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned to a credit note.
    /// <see href="https://purl.org/edifact/ontology#dateCreditNoteNumber"></see></summary>
    let dateCreditNoteNumber =
        Namespaced_IRI.parse _namespace_name "dateCreditNoteNumber" |> NamespacedName

    /// <summary>
    /// Date of the code number of the goods in accordance with the tariff nomenclature system of classification in use where the Customs declaration is made.
    /// <see href="https://purl.org/edifact/ontology#dateCustomsTariffNumber"></see></summary>
    let dateCustomsTariffNumber =
        Namespaced_IRI.parse _namespace_name "dateCustomsTariffNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by issuer to a debit note
    /// <see href="https://purl.org/edifact/ontology#dateDebitNoteNumber"></see></summary>
    let dateDebitNoteNumber =
        Namespaced_IRI.parse _namespace_name "dateDebitNoteNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by the issuer to a delivery note.
    /// <see href="https://purl.org/edifact/ontology#dateDeliveryNoteNumber"></see></summary>
    let dateDeliveryNoteNumber =
        Namespaced_IRI.parse _namespace_name "dateDeliveryNoteNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by issuing party to a despatch advice.
    /// <see href="https://purl.org/edifact/ontology#dateDespatchAdviceNumber"></see></summary>
    let dateDespatchAdviceNumber =
        Namespaced_IRI.parse _namespace_name "dateDespatchAdviceNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number given to an export shipment.
    /// <see href="https://purl.org/edifact/ontology#dateExportReferenceNumber"></see></summary>
    let dateExportReferenceNumber =
        Namespaced_IRI.parse _namespace_name "dateExportReferenceNumber" |> NamespacedName

    /// <summary>
    /// Date of number assigned by the file issuer or sender to identify a specific line.
    /// <see href="https://purl.org/edifact/ontology#dateFileLineIdentifier"></see></summary>
    let dateFileLineIdentifier =
        Namespaced_IRI.parse _namespace_name "dateFileLineIdentifier" |> NamespacedName

    /// <summary>
    /// Date of the receiving company account number (ACH transfer), check, draft or wire
    /// <see href="https://purl.org/edifact/ontology#dateFinancialAccountNumberPayee"></see></summary>
    let dateFinancialAccountNumberPayee =
        Namespaced_IRI.parse _namespace_name "dateFinancialAccountNumberPayee" |> NamespacedName

    /// <summary>
    /// Date of Tax payer's number.
    /// <see href="https://purl.org/edifact/ontology#dateFiscalNumber"></see></summary>
    let dateFiscalNumber =
        Namespaced_IRI.parse _namespace_name "dateFiscalNumber" |> NamespacedName

    /// <summary>
    /// Date of the refernce number given by the goverment
    /// <see href="https://purl.org/edifact/ontology#dateGovernmentReferenceNumber"></see></summary>
    let dateGovernmentReferenceNumber =
        Namespaced_IRI.parse _namespace_name "dateGovernmentReferenceNumber" |> NamespacedName

    /// <summary>
    /// Date of the number specifying the goods classification under the Harmonised Commodity Description and Coding System of the Customs Co-operation Council (CCC).
    /// <see href="https://purl.org/edifact/ontology#dateHarmonisedSystemNumber"></see></summary>
    let dateHarmonisedSystemNumber =
        Namespaced_IRI.parse _namespace_name "dateHarmonisedSystemNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by the issuing authority to an Import Licence.
    /// <see href="https://purl.org/edifact/ontology#dateImportLicenseNumber"></see></summary>
    let dateImportLicenseNumber =
        Namespaced_IRI.parse _namespace_name "dateImportLicenseNumber" |> NamespacedName

    /// <summary>
    /// Date of the number assigned by a seller, supplier etc. to identify a customer within his enterprise.
    /// <see href="https://purl.org/edifact/ontology#dateInternalCustomerNumber"></see></summary>
    let dateInternalCustomerNumber =
        Namespaced_IRI.parse _namespace_name "dateInternalCustomerNumber" |> NamespacedName

    /// <summary>
    /// Date of the number identifying the company-internal vending department/unit.
    /// <see href="https://purl.org/edifact/ontology#dateInternalVendorNumber"></see></summary>
    let dateInternalVendorNumber =
        Namespaced_IRI.parse _namespace_name "dateInternalVendorNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by the seller to a Commercial Invoice.
    /// <see href="https://purl.org/edifact/ontology#dateInvoiceNumber"></see></summary>
    let dateInvoiceNumber =
        Namespaced_IRI.parse _namespace_name "dateInvoiceNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number identifying a particular line in a document.
    /// <see href="https://purl.org/edifact/ontology#dateLineItemReferenceNumber"></see></summary>
    let dateLineItemReferenceNumber =
        Namespaced_IRI.parse _namespace_name "dateLineItemReferenceNumber" |> NamespacedName

    /// <summary>
    /// Date of the consolidated invoice number with EAN code
    /// <see href="https://purl.org/edifact/ontology#dateNumberConsolidatedInvoiceEANCode"></see></summary>
    let dateNumberConsolidatedInvoiceEANCode =
        Namespaced_IRI.parse _namespace_name "dateNumberConsolidatedInvoiceEANCode" |> NamespacedName

    /// <summary>
    /// Date of batch number identifying a batch of messages.
    /// <see href="https://purl.org/edifact/ontology#dateNumberOfBundleMessages"></see></summary>
    let dateNumberOfBundleMessages =
        Namespaced_IRI.parse _namespace_name "dateNumberOfBundleMessages" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by issuing party to an offer.
    /// <see href="https://purl.org/edifact/ontology#dateOfferNumber"></see></summary>
    let dateOfferNumber =
        Namespaced_IRI.parse _namespace_name "dateOfferNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by the buyer to an order.
    /// <see href="https://purl.org/edifact/ontology#dateOrderNumberBuyer"></see></summary>
    let dateOrderNumberBuyer =
        Namespaced_IRI.parse _namespace_name "dateOrderNumberBuyer" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by issuer to a delivery order.
    /// <see href="https://purl.org/edifact/ontology#dateOrderNumberDelivery"></see></summary>
    let dateOrderNumberDelivery =
        Namespaced_IRI.parse _namespace_name "dateOrderNumberDelivery" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by supplier to a buyer's purchase order.
    /// <see href="https://purl.org/edifact/ontology#dateOrderNumberSupplier"></see></summary>
    let dateOrderNumberSupplier =
        Namespaced_IRI.parse _namespace_name "dateOrderNumberSupplier" |> NamespacedName

    /// <summary>
    /// Date of the reference of the originator
    /// <see href="https://purl.org/edifact/ontology#dateOriginatorReference"></see></summary>
    let dateOriginatorReference =
        Namespaced_IRI.parse _namespace_name "dateOriginatorReference" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned to a payment.
    /// <see href="https://purl.org/edifact/ontology#datePaymentReference"></see></summary>
    let datePaymentReference =
        Namespaced_IRI.parse _namespace_name "datePaymentReference" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned to a price list.
    /// <see href="https://purl.org/edifact/ontology#datePriceListNumber"></see></summary>
    let datePriceListNumber =
        Namespaced_IRI.parse _namespace_name "datePriceListNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by the seller to a Proforma Invoice.
    /// <see href="https://purl.org/edifact/ontology#dateProformaInvoiceNumber"></see></summary>
    let dateProformaInvoiceNumber =
        Namespaced_IRI.parse _namespace_name "dateProformaInvoiceNumber" |> NamespacedName

    /// <summary>
    /// Date of a reference number to a receiving advice.
    /// <see href="https://purl.org/edifact/ontology#dateReceivingAdviceNumber"></see></summary>
    let dateReceivingAdviceNumber =
        Namespaced_IRI.parse _namespace_name "dateReceivingAdviceNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number for a business account statement as EAN code
    /// <see href="https://purl.org/edifact/ontology#dateReferenceNumberBusinessContactExtractEANCode"></see></summary>
    let dateReferenceNumberBusinessContactExtractEANCode =
        Namespaced_IRI.parse _namespace_name "dateReferenceNumberBusinessContactExtractEANCode" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned by the customer to a transaction.
    /// <see href="https://purl.org/edifact/ontology#dateReferenceNumberCustomer"></see></summary>
    let dateReferenceNumberCustomer =
        Namespaced_IRI.parse _namespace_name "dateReferenceNumberCustomer" |> NamespacedName

    /// <summary>
    /// Date of the realted document number
    /// <see href="https://purl.org/edifact/ontology#dateRelatedDocumentNumber"></see></summary>
    let dateRelatedDocumentNumber =
        Namespaced_IRI.parse _namespace_name "dateRelatedDocumentNumber" |> NamespacedName

    /// <summary>
    /// Date of the reference number assigned to a transaction by the seller
    /// <see href="https://purl.org/edifact/ontology#dateSellersReferenceNumber"></see></summary>
    let dateSellersReferenceNumber =
        Namespaced_IRI.parse _namespace_name "dateSellersReferenceNumber" |> NamespacedName

    /// <summary>
    /// Date of the number assigned by the issuer to his specification.
    /// <see href="https://purl.org/edifact/ontology#dateSpecificationNumber"></see></summary>
    let dateSpecificationNumber =
        Namespaced_IRI.parse _namespace_name "dateSpecificationNumber" |> NamespacedName

    /// <summary>
    /// Reference number assigned by issuer to a debit note
    /// <see href="https://purl.org/edifact/ontology#debitNoteNumber"></see></summary>
    let debitNoteNumber =
        Namespaced_IRI.parse _namespace_name "debitNoteNumber" |> NamespacedName

    /// <summary>
    /// Number of pieces actually received at the final destination.
    /// <see href="https://purl.org/edifact/ontology#deliveredQuantity"></see></summary>
    let deliveredQuantity =
        Namespaced_IRI.parse _namespace_name "deliveredQuantity" |> NamespacedName

    /// <summary>
    /// Specifies the conditions under which the goods must be delivered to the consignee
    /// <see href="https://purl.org/edifact/ontology#deliveryCondition"></see></summary>
    let deliveryCondition =
        Namespaced_IRI.parse _namespace_name "deliveryCondition" |> NamespacedName

    /// <summary>
    /// Reference number assigned by the issuer to a delivery note.
    /// <see href="https://purl.org/edifact/ontology#deliveryNoteNumber"></see></summary>
    let deliveryNoteNumber =
        Namespaced_IRI.parse _namespace_name "deliveryNoteNumber" |> NamespacedName

    /// <summary>
    /// Plain language description of the nature of the goods sufficient to identify them at the level required for banking, Customs, statistical or transport purposes, avoiding unnecessary detail (Generic term).
    /// <see href="https://purl.org/edifact/ontology#descriptionOfGoods"></see></summary>
    let descriptionOfGoods =
        Namespaced_IRI.parse _namespace_name "descriptionOfGoods" |> NamespacedName

    /// <summary>
    /// Reference number assigned by issuing party to a despatch advice.
    /// <see href="https://purl.org/edifact/ontology#despatchAdviceNumber"></see></summary>
    let despatchAdviceNumber =
        Namespaced_IRI.parse _namespace_name "despatchAdviceNumber" |> NamespacedName

    /// <summary>
    /// Quantity despatched by the seller.
    /// <see href="https://purl.org/edifact/ontology#despatchQuantity"></see></summary>
    let despatchQuantity =
        Namespaced_IRI.parse _namespace_name "despatchQuantity" |> NamespacedName

    /// <summary>
    /// Date/time when the deduction from an amount comes to an end.
    /// <see href="https://purl.org/edifact/ontology#discountTerminationDate"></see></summary>
    let discountTerminationDate =
        Namespaced_IRI.parse _namespace_name "discountTerminationDate" |> NamespacedName

    /// <summary>
    /// The discrete quantity
    /// <see href="https://purl.org/edifact/ontology#discreteQuantity"></see></summary>
    let discreteQuantity =
        Namespaced_IRI.parse _namespace_name "discreteQuantity" |> NamespacedName

    /// <summary>
    /// Date/time when a document/message is issued. This may include authentication.
    /// <see href="https://purl.org/edifact/ontology#documentDate"></see></summary>
    let documentDate =
        Namespaced_IRI.parse _namespace_name "documentDate" |> NamespacedName

    /// <summary>
    /// Date and/or time at which specified event or document becomes effective.
    /// <see href="https://purl.org/edifact/ontology#effectiveDate"></see></summary>
    let effectiveDate =
        Namespaced_IRI.parse _namespace_name "effectiveDate" |> NamespacedName

    /// <summary>
    /// Date/time on which the exchange rate was fixed.
    /// <see href="https://purl.org/edifact/ontology#exchangeRateDate"></see></summary>
    let exchangeRateDate =
        Namespaced_IRI.parse _namespace_name "exchangeRateDate" |> NamespacedName

    /// <summary>
    /// Reference number given to an export shipment.
    /// <see href="https://purl.org/edifact/ontology#exportReferenceNumber"></see></summary>
    let exportReferenceNumber =
        Namespaced_IRI.parse _namespace_name "exportReferenceNumber" |> NamespacedName

    /// <summary>
    /// Number assigned by the file issuer or sender to identify a specific line.
    /// <see href="https://purl.org/edifact/ontology#fileLineIdentifier"></see></summary>
    let fileLineIdentifier =
        Namespaced_IRI.parse _namespace_name "fileLineIdentifier" |> NamespacedName

    /// <summary>
    /// Receiving company account number (ACH transfer), check, draft or wire
    /// <see href="https://purl.org/edifact/ontology#financialAccountNumberPayee"></see></summary>
    let financialAccountNumberPayee =
        Namespaced_IRI.parse _namespace_name "financialAccountNumberPayee" |> NamespacedName

    /// <summary>
    /// Tax payer's number. Number assigned to individual persons as well as to corporates by a public institution; this number is different from the VAT registration number.
    /// <see href="https://purl.org/edifact/ontology#fiscalNumber"></see></summary>
    let fiscalNumber =
        Namespaced_IRI.parse _namespace_name "fiscalNumber" |> NamespacedName

    /// <summary>
    /// shows the file standard resources the invoice has
    /// <see href="https://purl.org/edifact/ontology#followsStandard"></see></summary>
    let followsStandard =
        Namespaced_IRI.parse _namespace_name "followsStandard" |> NamespacedName

    /// <summary>
    /// shows of which invoice the EDIFACT Structure is
    /// <see href="https://purl.org/edifact/ontology#isStandardOf"></see></summary>
    let isStandardOf =
        Namespaced_IRI.parse _namespace_name "isStandardOf" |> NamespacedName

    /// <summary>
    /// Refernce number given by the goverment
    /// <see href="https://purl.org/edifact/ontology#governmentReferenceNumber"></see></summary>
    let governmentReferenceNumber =
        Namespaced_IRI.parse _namespace_name "governmentReferenceNumber" |> NamespacedName

    /// <summary>
    /// Contains the number of the harmonised system
    /// <see href="https://purl.org/edifact/ontology#harmonisedSystem"></see></summary>
    let harmonisedSystem =
        Namespaced_IRI.parse _namespace_name "harmonisedSystem" |> NamespacedName

    /// <summary>
    /// Date of the number specifying the goods classification under the Harmonised Commodity Description and Coding System of the Customs Co-operation Council (CCC).
    /// <see href="https://purl.org/edifact/ontology#harmonisedSystemNumber"></see></summary>
    let harmonisedSystemNumber =
        Namespaced_IRI.parse _namespace_name "harmonisedSystemNumber" |> NamespacedName

    /// <summary>
    /// Information which specifies and qualifies product identifications.
    /// <see href="https://purl.org/edifact/ontology#hasAdditionalProductIdentification"></see></summary>
    let hasAdditionalProductIdentification =
        Namespaced_IRI.parse _namespace_name "hasAdditionalProductIdentification" |> NamespacedName

    /// <summary>
    /// Amount of the allowance
    /// <see href="https://purl.org/edifact/ontology#hasAllowanceAmount"></see></summary>
    let hasAllowanceAmount =
        Namespaced_IRI.parse _namespace_name "hasAllowanceAmount" |> NamespacedName

    /// <summary>
    /// Allowance expressed as a percentage.
    /// <see href="https://purl.org/edifact/ontology#hasAllowancePercentage"></see></summary>
    let hasAllowancePercentage =
        Namespaced_IRI.parse _namespace_name "hasAllowancePercentage" |> NamespacedName

    /// <summary>
    /// Contains percentage
    /// <see href="https://purl.org/edifact/ontology#percentage"></see></summary>
    let percentage = Namespaced_IRI.parse _namespace_name "percentage" |> NamespacedName

    /// <summary>
    /// Allowance expressed as a percentage with payment condition
    /// <see href="https://purl.org/edifact/ontology#hasAllowancePercentagePaymentConditions"></see></summary>
    let hasAllowancePercentagePaymentConditions =
        Namespaced_IRI.parse _namespace_name "hasAllowancePercentagePaymentConditions" |> NamespacedName

    /// <summary>
    /// The reason for the allowance
    /// <see href="https://purl.org/edifact/ontology#hasAllowanceReason"></see></summary>
    let hasAllowanceReason =
        Namespaced_IRI.parse _namespace_name "hasAllowanceReason" |> NamespacedName

    /// <summary>
    /// Amount to be paid
    /// <see href="https://purl.org/edifact/ontology#hasAmountDueOrPayable"></see></summary>
    let hasAmountDueOrPayable =
        Namespaced_IRI.parse _namespace_name "hasAmountDueOrPayable" |> NamespacedName

    /// <summary>
    /// Amount which is used as the basis for price adjustment calculation.
    /// <see href="https://purl.org/edifact/ontology#hasAmountUnderPriceAdjustment"></see></summary>
    let hasAmountUnderPriceAdjustment =
        Namespaced_IRI.parse _namespace_name "hasAmountUnderPriceAdjustment" |> NamespacedName

    /// <summary>
    /// The amount specified is the basis for duty/tax or fee.
    /// <see href="https://purl.org/edifact/ontology#hasBasicTaxAmount"></see></summary>
    let hasBasicTaxAmount =
        Namespaced_IRI.parse _namespace_name "hasBasicTaxAmount" |> NamespacedName

    /// <summary>
    /// Cash discount given by the seller to the buyer where payment is made in advance of receipt of goods.
    /// <see href="https://purl.org/edifact/ontology#hasCashDiscount"></see></summary>
    let hasCashDiscount =
        Namespaced_IRI.parse _namespace_name "hasCashDiscount" |> NamespacedName

    /// <summary>
    /// The amount specified is the basis for calculation of charges/allowance.
    /// <see href="https://purl.org/edifact/ontology#hasChargeAllowanceBasis"></see></summary>
    let hasChargeAllowanceBasis =
        Namespaced_IRI.parse _namespace_name "hasChargeAllowanceBasis" |> NamespacedName

    /// <summary>
    /// The amont of the charge
    /// <see href="https://purl.org/edifact/ontology#hasChargeAmount"></see></summary>
    let hasChargeAmount =
        Namespaced_IRI.parse _namespace_name "hasChargeAmount" |> NamespacedName

    /// <summary>
    /// Charge expressed as a percentage.
    /// <see href="https://purl.org/edifact/ontology#hasChargePercentage"></see></summary>
    let hasChargePercentage =
        Namespaced_IRI.parse _namespace_name "hasChargePercentage" |> NamespacedName

    /// <summary>
    /// Charge expressed as a percentage with the payment conditions
    /// <see href="https://purl.org/edifact/ontology#hasChargePercentagePaymentConditions"></see></summary>
    let hasChargePercentagePaymentConditions =
        Namespaced_IRI.parse _namespace_name "hasChargePercentagePaymentConditions" |> NamespacedName

    /// <summary>
    /// The reason for the charge
    /// <see href="https://purl.org/edifact/ontology#hasChargeReason"></see></summary>
    let hasChargeReason =
        Namespaced_IRI.parse _namespace_name "hasChargeReason" |> NamespacedName

    /// <summary>
    /// Cotains the city name of a party involved in the invoice
    /// <see href="https://purl.org/edifact/ontology#hasCity"></see></summary>
    let hasCity = Namespaced_IRI.parse _namespace_name "hasCity" |> NamespacedName

    /// <summary>
    /// The amount specified is the discount amount
    /// <see href="https://purl.org/edifact/ontology#hasDiscountAmount"></see></summary>
    let hasDiscountAmount =
        Namespaced_IRI.parse _namespace_name "hasDiscountAmount" |> NamespacedName

    /// <summary>
    /// Discount expressed as a percentage.
    /// <see href="https://purl.org/edifact/ontology#hasDiscountPercentage"></see></summary>
    let hasDiscountPercentage =
        Namespaced_IRI.parse _namespace_name "hasDiscountPercentage" |> NamespacedName

    /// <summary>
    /// Discount expressed as a percentage with payment condition
    /// <see href="https://purl.org/edifact/ontology#hasDiscountPercentagePaymentConditions"></see></summary>
    let hasDiscountPercentagePaymentConditions =
        Namespaced_IRI.parse _namespace_name "hasDiscountPercentagePaymentConditions" |> NamespacedName

    /// <summary>
    /// The discrete quantity with unit
    /// <see href="https://purl.org/edifact/ontology#hasDiscreteQuantityWithUnit"></see></summary>
    let hasDiscreteQuantityWithUnit =
        Namespaced_IRI.parse _namespace_name "hasDiscreteQuantityWithUnit" |> NamespacedName

    /// <summary>
    /// Indicates the function of the message
    /// <see href="https://purl.org/edifact/ontology#hasDocumentFunction"></see></summary>
    let hasDocumentFunction =
        Namespaced_IRI.parse _namespace_name "hasDocumentFunction" |> NamespacedName

    /// <summary>
    /// Document/message number
    /// <see href="https://purl.org/edifact/ontology#hasDocumentNumber"></see></summary>
    let hasDocumentNumber =
        Namespaced_IRI.parse _namespace_name "hasDocumentNumber" |> NamespacedName

    /// <summary>
    /// Document/message identifier expressed
    /// <see href="https://purl.org/edifact/ontology#hasDocumentType"></see></summary>
    let hasDocumentType =
        Namespaced_IRI.parse _namespace_name "hasDocumentType" |> NamespacedName

    /// <summary>
    /// Due date
    /// <see href="https://purl.org/edifact/ontology#hasDueDate"></see></summary>
    let hasDueDate = Namespaced_IRI.parse _namespace_name "hasDueDate" |> NamespacedName

    /// <summary>
    /// Amount of the discount due
    /// <see href="https://purl.org/edifact/ontology#hasDueDeductionAmount"></see></summary>
    let hasDueDeductionAmount =
        Namespaced_IRI.parse _namespace_name "hasDueDeductionAmount" |> NamespacedName

    /// <summary>
    /// Amount to be paid for moving goods, by whatever means, from one place to another, inclusive discounts, allowances, rebates, adjustment factors and additional cost relating to freight costs (UN/ECE Recommendation no 23).
    /// <see href="https://purl.org/edifact/ontology#hasFreightCharge"></see></summary>
    let hasFreightCharge =
        Namespaced_IRI.parse _namespace_name "hasFreightCharge" |> NamespacedName

    /// <summary>
    /// Describes the role of a party involved in the invoice
    /// <see href="https://purl.org/edifact/ontology#hasFunctionInInvoice"></see></summary>
    let hasFunctionInInvoice =
        Namespaced_IRI.parse _namespace_name "hasFunctionInInvoice" |> NamespacedName

    /// <summary>
    /// Tax levied on the final consumption of goods and services throughout the production and distribution chain.
    /// <see href="https://purl.org/edifact/ontology#hasGSTrate"></see></summary>
    let hasGSTrate = Namespaced_IRI.parse _namespace_name "hasGSTrate" |> NamespacedName
    /// <summary>
    /// Contains the TAX rate
    /// <see href="https://purl.org/edifact/ontology#hasTAXrate"></see></summary>
    let hasTAXrate = Namespaced_IRI.parse _namespace_name "hasTAXrate" |> NamespacedName

    /// <summary>
    /// Contains general information about the Invoice or a Item
    /// <see href="https://purl.org/edifact/ontology#hasGeneralInformation"></see></summary>
    let hasGeneralInformation =
        Namespaced_IRI.parse _namespace_name "hasGeneralInformation" |> NamespacedName

    /// <summary>
    /// The price stated is the gross price per item to which allowances/ charges must be applied.
    /// <see href="https://purl.org/edifact/ontology#hasGrosspriceOfItem"></see></summary>
    let hasGrosspriceOfItem =
        Namespaced_IRI.parse _namespace_name "hasGrosspriceOfItem" |> NamespacedName

    /// <summary>
    /// The price stated is the gross price per unit to which allowances/ charges must be applied.
    /// <see href="https://purl.org/edifact/ontology#hasGrosspricePerUnit"></see></summary>
    let hasGrosspricePerUnit =
        Namespaced_IRI.parse _namespace_name "hasGrosspricePerUnit" |> NamespacedName

    /// <summary>
    /// Numeric value of height
    /// <see href="https://purl.org/edifact/ontology#hasHeightDimension"></see></summary>
    let hasHeightDimension =
        Namespaced_IRI.parse _namespace_name "hasHeightDimension" |> NamespacedName

    /// <summary>
    /// Total sum charged in respect of a single Invoice in accordance with the terms of delivery.
    /// <see href="https://purl.org/edifact/ontology#hasInvoiceAmount"></see></summary>
    let hasInvoiceAmount =
        Namespaced_IRI.parse _namespace_name "hasInvoiceAmount" |> NamespacedName

    /// <summary>
    /// Contains the Invoice Details of an Invoice
    /// <see href="https://purl.org/edifact/ontology#hasInvoiceDetails"></see></summary>
    let hasInvoiceDetails =
        Namespaced_IRI.parse _namespace_name "hasInvoiceDetails" |> NamespacedName

    /// <summary>
    /// shows to which Invoice the Invoice Details belong
    /// <see href="https://purl.org/edifact/ontology#isInvoiceDetailsOf"></see></summary>
    let isInvoiceDetailsOf =
        Namespaced_IRI.parse _namespace_name "isInvoiceDetailsOf" |> NamespacedName

    /// <summary>
    /// Percentage used in the whole invoice
    /// <see href="https://purl.org/edifact/ontology#hasInvoicePercentage"></see></summary>
    let hasInvoicePercentage =
        Namespaced_IRI.parse _namespace_name "hasInvoicePercentage" |> NamespacedName

    /// <summary>
    /// Percentage used in the whole invoice with payment conditions
    /// <see href="https://purl.org/edifact/ontology#hasInvoicePercentagePaymentConditions"></see></summary>
    let hasInvoicePercentagePaymentConditions =
        Namespaced_IRI.parse _namespace_name "hasInvoicePercentagePaymentConditions" |> NamespacedName

    /// <summary>
    /// Referenced price taken from an invoice
    /// <see href="https://purl.org/edifact/ontology#hasInvoiceprice"></see></summary>
    let hasInvoiceprice =
        Namespaced_IRI.parse _namespace_name "hasInvoiceprice" |> NamespacedName

    /// <summary>
    /// shows which items are included in an invoice
    /// <see href="https://purl.org/edifact/ontology#hasItem"></see></summary>
    let hasItem = Namespaced_IRI.parse _namespace_name "hasItem" |> NamespacedName
    /// <summary>
    /// shows to which Invoice the item belongs
    /// <see href="https://purl.org/edifact/ontology#isItemOf"></see></summary>
    let isItemOf = Namespaced_IRI.parse _namespace_name "isItemOf" |> NamespacedName

    /// <summary>
    /// Length of pieces or packages stated for transport purposes
    /// <see href="https://purl.org/edifact/ontology#hasLengthMeasurements"></see></summary>
    let hasLengthMeasurements =
        Namespaced_IRI.parse _namespace_name "hasLengthMeasurements" |> NamespacedName

    /// <summary>
    /// Goods item total minus allowances plus charges for line item.
    /// <see href="https://purl.org/edifact/ontology#hasLineItemAmount"></see></summary>
    let hasLineItemAmount =
        Namespaced_IRI.parse _namespace_name "hasLineItemAmount" |> NamespacedName

    /// <summary>
    /// The price stated is the net price per item including allowances/ charges. Allowances/charges may be stated for information only.
    /// <see href="https://purl.org/edifact/ontology#hasNetPriceOfItem"></see></summary>
    let hasNetPriceOfItem =
        Namespaced_IRI.parse _namespace_name "hasNetPriceOfItem" |> NamespacedName

    /// <summary>
    /// Weight (mass) of the goods themselves without any packing
    /// <see href="https://purl.org/edifact/ontology#hasNetWeight"></see></summary>
    let hasNetWeight =
        Namespaced_IRI.parse _namespace_name "hasNetWeight" |> NamespacedName

    /// <summary>
    /// Weight (mass) of goods including any packing normally going with them to a buyer in a retail sale
    /// <see href="https://purl.org/edifact/ontology#hasNetWeightPerUnit"></see></summary>
    let hasNetWeightPerUnit =
        Namespaced_IRI.parse _namespace_name "hasNetWeightPerUnit" |> NamespacedName

    /// <summary>
    /// The price stated is the net price per unit including allowances/ charges. Allowances/charges may be stated for information only.
    /// <see href="https://purl.org/edifact/ontology#hasNetpricePerUnit"></see></summary>
    let hasNetpricePerUnit =
        Namespaced_IRI.parse _namespace_name "hasNetpricePerUnit" |> NamespacedName

    /// <summary>
    /// Amount of the payment discount
    /// <see href="https://purl.org/edifact/ontology#hasPaymentDiscountAmount"></see></summary>
    let hasPaymentDiscountAmount =
        Namespaced_IRI.parse _namespace_name "hasPaymentDiscountAmount" |> NamespacedName

    /// <summary>
    /// Amount of the penalty
    /// <see href="https://purl.org/edifact/ontology#hasPenaltyAmount"></see></summary>
    let hasPenaltyAmount =
        Namespaced_IRI.parse _namespace_name "hasPenaltyAmount" |> NamespacedName

    /// <summary>
    /// Penalty expressed as a percentage.
    /// <see href="https://purl.org/edifact/ontology#hasPenaltyPercentage"></see></summary>
    let hasPenaltyPercentage =
        Namespaced_IRI.parse _namespace_name "hasPenaltyPercentage" |> NamespacedName

    /// <summary>
    /// Penalty expressed as a percentage with payment conditions
    /// <see href="https://purl.org/edifact/ontology#hasPenaltyPercentagePaymentConditions"></see></summary>
    let hasPenaltyPercentagePaymentConditions =
        Namespaced_IRI.parse _namespace_name "hasPenaltyPercentagePaymentConditions" |> NamespacedName

    /// <summary>
    /// Specified measurement dimensions refer to physical dimensions of a product, material or package
    /// <see href="https://purl.org/edifact/ontology#hasPhysicalDimension"></see></summary>
    let hasPhysicalDimension =
        Namespaced_IRI.parse _namespace_name "hasPhysicalDimension" |> NamespacedName

    /// <summary>
    /// Amount which has been prepaid in advance
    /// <see href="https://purl.org/edifact/ontology#hasPrepaidAmount"></see></summary>
    let hasPrepaidAmount =
        Namespaced_IRI.parse _namespace_name "hasPrepaidAmount" |> NamespacedName

    /// <summary>
    /// Identification of the type of price of an item
    /// <see href="https://purl.org/edifact/ontology#hasPriceSource"></see></summary>
    let hasPriceSource =
        Namespaced_IRI.parse _namespace_name "hasPriceSource" |> NamespacedName

    /// <summary>
    /// Identification pricing specification
    /// <see href="https://purl.org/edifact/ontology#hasPriceType"></see></summary>
    let hasPriceType =
        Namespaced_IRI.parse _namespace_name "hasPriceType" |> NamespacedName

    /// <summary>
    /// Contains measure unit qualifier of a price
    /// <see href="https://purl.org/edifact/ontology#hasPriceUnit"></see></summary>
    let hasPriceUnit =
        Namespaced_IRI.parse _namespace_name "hasPriceUnit" |> NamespacedName

    /// <summary>
    /// Contains measure unit qualifier
    /// <see href="https://purl.org/edifact/ontology#hasUnit"></see></summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName

    /// <summary>
    /// Identification of the product
    /// <see href="https://purl.org/edifact/ontology#hasProductIdentification"></see></summary>
    let hasProductIdentification =
        Namespaced_IRI.parse _namespace_name "hasProductIdentification" |> NamespacedName

    /// <summary>
    /// Contains measure unit qualifier of a quantity
    /// <see href="https://purl.org/edifact/ontology#hasQuantityUnit"></see></summary>
    let hasQuantityUnit =
        Namespaced_IRI.parse _namespace_name "hasQuantityUnit" |> NamespacedName

    /// <summary>
    /// Amount which was remitted
    /// <see href="https://purl.org/edifact/ontology#hasRemittedtAmount"></see></summary>
    let hasRemittedtAmount =
        Namespaced_IRI.parse _namespace_name "hasRemittedtAmount" |> NamespacedName

    /// <summary>
    /// Date on which buyer requests goods to be delivered.
    /// <see href="https://purl.org/edifact/ontology#hasRequiredDeliveryDate"></see></summary>
    let hasRequiredDeliveryDate =
        Namespaced_IRI.parse _namespace_name "hasRequiredDeliveryDate" |> NamespacedName

    /// <summary>
    /// A measurement indicating limitation in relation to storage.
    /// <see href="https://purl.org/edifact/ontology#hasStockRestriction"></see></summary>
    let hasStockRestriction =
        Namespaced_IRI.parse _namespace_name "hasStockRestriction" |> NamespacedName

    /// <summary>
    /// Tax imposed by government or other official authority related to the weight/volume charge or valuation charge
    /// <see href="https://purl.org/edifact/ontology#hasTaxAmount"></see></summary>
    let hasTaxAmount =
        Namespaced_IRI.parse _namespace_name "hasTaxAmount" |> NamespacedName

    /// <summary>
    /// Amount for tax calculation
    /// <see href="https://purl.org/edifact/ontology#hasTaxableAmount"></see></summary>
    let hasTaxableAmount =
        Namespaced_IRI.parse _namespace_name "hasTaxableAmount" |> NamespacedName

    /// <summary>
    /// Date by which payment should be made if discount terms are to apply.
    /// <see href="https://purl.org/edifact/ontology#hasTermsDiscountDueDate"></see></summary>
    let hasTermsDiscountDueDate =
        Namespaced_IRI.parse _namespace_name "hasTermsDiscountDueDate" |> NamespacedName

    /// <summary>
    /// Date by which payment must be made
    /// <see href="https://purl.org/edifact/ontology#hasTermsNetDueDate"></see></summary>
    let hasTermsNetDueDate =
        Namespaced_IRI.parse _namespace_name "hasTermsNetDueDate" |> NamespacedName

    /// <summary>
    /// The amount specified is the total of all charges/allowances.
    /// <see href="https://purl.org/edifact/ontology#hasTotalAdditionsAndDeductions"></see></summary>
    let hasTotalAdditionsAndDeductions =
        Namespaced_IRI.parse _namespace_name "hasTotalAdditionsAndDeductions" |> NamespacedName

    /// <summary>
    /// The amount specified is the total amount
    /// <see href="https://purl.org/edifact/ontology#hasTotalAmount"></see></summary>
    let hasTotalAmount =
        Namespaced_IRI.parse _namespace_name "hasTotalAmount" |> NamespacedName

    /// <summary>
    /// The total Amount of the Message
    /// <see href="https://purl.org/edifact/ontology#hasTotalAmountMessage"></see></summary>
    let hasTotalAmountMessage =
        Namespaced_IRI.parse _namespace_name "hasTotalAmountMessage" |> NamespacedName

    /// <summary>
    /// Part of the invoice amount which is subject to payment discount.
    /// <see href="https://purl.org/edifact/ontology#hasTotalAmountUnderPaymentReduction"></see></summary>
    let hasTotalAmountUnderPaymentReduction =
        Namespaced_IRI.parse _namespace_name "hasTotalAmountUnderPaymentReduction" |> NamespacedName

    /// <summary>
    /// Total of all duty/tax/fee amounts.
    /// <see href="https://purl.org/edifact/ontology#hasTotalDutyTaxFeeAmount"></see></summary>
    let hasTotalDutyTaxFeeAmount =
        Namespaced_IRI.parse _namespace_name "hasTotalDutyTaxFeeAmount" |> NamespacedName

    /// <summary>
    /// Net price x quantity for the line item
    /// <see href="https://purl.org/edifact/ontology#hasTotalGoodsPosition"></see></summary>
    let hasTotalGoodsPosition =
        Namespaced_IRI.parse _namespace_name "hasTotalGoodsPosition" |> NamespacedName

    /// <summary>
    /// The sum of all the line item amounts.
    /// <see href="https://purl.org/edifact/ontology#hasTotalLineItemAmount"></see></summary>
    let hasTotalLineItemAmount =
        Namespaced_IRI.parse _namespace_name "hasTotalLineItemAmount" |> NamespacedName

    /// <summary>
    /// A measurement indicating limitations in relation to transportation equipment.
    /// <see href="https://purl.org/edifact/ontology#hasTransportRestriction"></see></summary>
    let hasTransportRestriction =
        Namespaced_IRI.parse _namespace_name "hasTransportRestriction" |> NamespacedName

    /// <summary>
    /// Reporting monetary amount is a 'per unit' amount
    /// <see href="https://purl.org/edifact/ontology#hasUnitPrice"></see></summary>
    let hasUnitPrice =
        Namespaced_IRI.parse _namespace_name "hasUnitPrice" |> NamespacedName

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify the buyer for use in relation to Value Added Tax (VAT).
    /// <see href="https://purl.org/edifact/ontology#hasVATIdentifierBuyer"></see></summary>
    let hasVATIdentifierBuyer =
        Namespaced_IRI.parse _namespace_name "hasVATIdentifierBuyer" |> NamespacedName

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify the delivery party for use in relation to Value Added Tax (VAT).
    /// <see href="https://purl.org/edifact/ontology#hasVATIdentifierDeliveryParty"></see></summary>
    let hasVATIdentifierDeliveryParty =
        Namespaced_IRI.parse _namespace_name "hasVATIdentifierDeliveryParty" |> NamespacedName

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify the invoicee for use in relation to Value Added Tax (VAT).
    /// <see href="https://purl.org/edifact/ontology#hasVATIdentifierInvoicee"></see></summary>
    let hasVATIdentifierInvoicee =
        Namespaced_IRI.parse _namespace_name "hasVATIdentifierInvoicee" |> NamespacedName

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify the payer for use in relation to Value Added Tax (VAT).
    /// <see href="https://purl.org/edifact/ontology#hasVATIdentifierPayer"></see></summary>
    let hasVATIdentifierPayer =
        Namespaced_IRI.parse _namespace_name "hasVATIdentifierPayer" |> NamespacedName

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify the supplier for use in relation to Value Added Tax (VAT).
    /// <see href="https://purl.org/edifact/ontology#hasVATIdentifierSupplier"></see></summary>
    let hasVATIdentifierSupplier =
        Namespaced_IRI.parse _namespace_name "hasVATIdentifierSupplier" |> NamespacedName

    /// <summary>
    /// Amount in national currency resulting from the application, at the appropriate rate, of value added tax (or similar tax) to the invoice amount subject to such tax
    /// <see href="https://purl.org/edifact/ontology#hasVATamount"></see></summary>
    let hasVATamount =
        Namespaced_IRI.parse _namespace_name "hasVATamount" |> NamespacedName

    /// <summary>
    /// First VAT value if, for the same rate of VAT, there are 1 to 3 different ways to set this value
    /// <see href="https://purl.org/edifact/ontology#hasVATfirstValue"></see></summary>
    let hasVATfirstValue =
        Namespaced_IRI.parse _namespace_name "hasVATfirstValue" |> NamespacedName

    /// <summary>
    /// A tax on domestic or imported goods applied to the value added at each stage in the production/distribution cycle.
    /// <see href="https://purl.org/edifact/ontology#hasVATrate"></see></summary>
    let hasVATrate = Namespaced_IRI.parse _namespace_name "hasVATrate" |> NamespacedName

    /// <summary>
    /// Reference number assigned by the issuing authority to an Import Licence.
    /// <see href="https://purl.org/edifact/ontology#importLicenseNumber"></see></summary>
    let importLicenseNumber =
        Namespaced_IRI.parse _namespace_name "importLicenseNumber" |> NamespacedName

    /// <summary>
    /// Note contains customs declaration information.
    /// <see href="https://purl.org/edifact/ontology#informationCustomsDeclaration"></see></summary>
    let informationCustomsDeclaration =
        Namespaced_IRI.parse _namespace_name "informationCustomsDeclaration" |> NamespacedName

    /// <summary>
    /// Note contains invoice instructions
    /// <see href="https://purl.org/edifact/ontology#instructionForInvoicingParty"></see></summary>
    let instructionForInvoicingParty =
        Namespaced_IRI.parse _namespace_name "instructionForInvoicingParty" |> NamespacedName

    /// <summary>
    /// Number assigned by a seller, supplier etc. to identify a customer within his enterprise.
    /// <see href="https://purl.org/edifact/ontology#internalCustomerNumber"></see></summary>
    let internalCustomerNumber =
        Namespaced_IRI.parse _namespace_name "internalCustomerNumber" |> NamespacedName

    /// <summary>
    /// Number identifying the company-internal vending department/unit.
    /// <see href="https://purl.org/edifact/ontology#internalVendorNumber"></see></summary>
    let internalVendorNumber =
        Namespaced_IRI.parse _namespace_name "internalVendorNumber" |> NamespacedName

    /// <summary>
    /// Number assigned to a manufacturer's product according to the International Article Numbering Association.
    /// <see href="https://purl.org/edifact/ontology#internationalArticleNumber"></see></summary>
    let internationalArticleNumber =
        Namespaced_IRI.parse _namespace_name "internationalArticleNumber" |> NamespacedName

    /// <summary>
    /// The name or symbol of the monetary unit used for calculation in an invoice.
    /// <see href="https://purl.org/edifact/ontology#invoiceCurrency"></see></summary>
    let invoiceCurrency =
        Namespaced_IRI.parse _namespace_name "invoiceCurrency" |> NamespacedName

    /// <summary>
    /// Item number assigned by the buyer to identify an article.
    /// <see href="https://purl.org/edifact/ontology#itemNumberBuyer"></see></summary>
    let itemNumberBuyer =
        Namespaced_IRI.parse _namespace_name "itemNumberBuyer" |> NamespacedName

    /// <summary>
    /// The number given to an article by its manufacturer.
    /// <see href="https://purl.org/edifact/ontology#itemNumberManufacturer"></see></summary>
    let itemNumberManufacturer =
        Namespaced_IRI.parse _namespace_name "itemNumberManufacturer" |> NamespacedName

    /// <summary>
    /// Number assigned to an article by the supplier of that article.
    /// <see href="https://purl.org/edifact/ontology#itemNumberSupplier"></see></summary>
    let itemNumberSupplier =
        Namespaced_IRI.parse _namespace_name "itemNumberSupplier" |> NamespacedName

    /// <summary>
    /// Reference number identifying a particular line in a document.
    /// <see href="https://purl.org/edifact/ontology#lineItemReferenceNumber"></see></summary>
    let lineItemReferenceNumber =
        Namespaced_IRI.parse _namespace_name "lineItemReferenceNumber" |> NamespacedName

    /// <summary>
    /// Period a specified charge is valid for.
    /// <see href="https://purl.org/edifact/ontology#loadPeriod"></see></summary>
    let loadPeriod = Namespaced_IRI.parse _namespace_name "loadPeriod" |> NamespacedName

    /// <summary>
    /// Identification of the managing organization
    /// <see href="https://purl.org/edifact/ontology#managingOrganisations"></see></summary>
    let managingOrganisations =
        Namespaced_IRI.parse _namespace_name "managingOrganisations" |> NamespacedName

    /// <summary>
    /// The reference number of the message
    /// <see href="https://purl.org/edifact/ontology#messageReferenceNumber"></see></summary>
    let messageReferenceNumber =
        Namespaced_IRI.parse _namespace_name "messageReferenceNumber" |> NamespacedName

    /// <summary>
    /// The identifier of the message type
    /// <see href="https://purl.org/edifact/ontology#messageTypeIdentifier"></see></summary>
    let messageTypeIdentifier =
        Namespaced_IRI.parse _namespace_name "messageTypeIdentifier" |> NamespacedName

    /// <summary>
    /// National product group code. Administered by a national agency.
    /// <see href="https://purl.org/edifact/ontology#nationalProductGroupCode"></see></summary>
    let nationalProductGroupCode =
        Namespaced_IRI.parse _namespace_name "nationalProductGroupCode" |> NamespacedName

    /// <summary>
    /// No increases or reduction in price (list or stated) are included.
    /// <see href="https://purl.org/edifact/ontology#noDiscountAllowance"></see></summary>
    let noDiscountAllowance =
        Namespaced_IRI.parse _namespace_name "noDiscountAllowance" |> NamespacedName

    /// <summary>
    /// Consolidated invoice number with EAN code
    /// <see href="https://purl.org/edifact/ontology#numberConsolidatedInvoiceEANCode"></see></summary>
    let numberConsolidatedInvoiceEANCode =
        Namespaced_IRI.parse _namespace_name "numberConsolidatedInvoiceEANCode" |> NamespacedName

    /// <summary>
    /// A batch number identifying a batch of messages.
    /// <see href="https://purl.org/edifact/ontology#numberOfBundleMessages"></see></summary>
    let numberOfBundleMessages =
        Namespaced_IRI.parse _namespace_name "numberOfBundleMessages" |> NamespacedName

    /// <summary>
    /// Reference number assigned by issuing party to an offer.
    /// <see href="https://purl.org/edifact/ontology#offerNumber"></see></summary>
    let offerNumber =
        Namespaced_IRI.parse _namespace_name "offerNumber" |> NamespacedName

    /// <summary>
    /// The name or symbol of the monetary unit used in an order.
    /// <see href="https://purl.org/edifact/ontology#orderCurrency"></see></summary>
    let orderCurrency =
        Namespaced_IRI.parse _namespace_name "orderCurrency" |> NamespacedName

    /// <summary>
    /// Date when an order is issued.
    /// <see href="https://purl.org/edifact/ontology#orderDate"></see></summary>
    let orderDate = Namespaced_IRI.parse _namespace_name "orderDate" |> NamespacedName

    /// <summary>
    /// Reference number of an order.
    /// <see href="https://purl.org/edifact/ontology#orderNumber"></see></summary>
    let orderNumber =
        Namespaced_IRI.parse _namespace_name "orderNumber" |> NamespacedName

    /// <summary>
    /// Reference number assigned by the buyer to an order.
    /// <see href="https://purl.org/edifact/ontology#orderNumberBuyer"></see></summary>
    let orderNumberBuyer =
        Namespaced_IRI.parse _namespace_name "orderNumberBuyer" |> NamespacedName

    /// <summary>
    /// Reference number assigned by issuer to a delivery order.
    /// <see href="https://purl.org/edifact/ontology#orderNumberDelivery"></see></summary>
    let orderNumberDelivery =
        Namespaced_IRI.parse _namespace_name "orderNumberDelivery" |> NamespacedName

    /// <summary>
    /// Reference number assigned by supplier to a buyer's purchase order.
    /// <see href="https://purl.org/edifact/ontology#orderNumberSupplier"></see></summary>
    let orderNumberSupplier =
        Namespaced_IRI.parse _namespace_name "orderNumberSupplier" |> NamespacedName

    /// <summary>
    /// Reference of the originator
    /// <see href="https://purl.org/edifact/ontology#originatorReference"></see></summary>
    let originatorReference =
        Namespaced_IRI.parse _namespace_name "originatorReference" |> NamespacedName

    /// <summary>
    /// General information created by the sender of general or specific value.
    /// <see href="https://purl.org/edifact/ontology#otherServiceInformation"></see></summary>
    let otherServiceInformation =
        Namespaced_IRI.parse _namespace_name "otherServiceInformation" |> NamespacedName

    /// <summary>
    /// Reference number assigned by the buyer to identify an article.
    /// <see href="https://purl.org/edifact/ontology#partNumberBuyer"></see></summary>
    let partNumberBuyer =
        Namespaced_IRI.parse _namespace_name "partNumberBuyer" |> NamespacedName

    /// <summary>
    /// Type of the payment terms
    /// <see href="https://purl.org/edifact/ontology#paymentCondition"></see></summary>
    let paymentCondition =
        Namespaced_IRI.parse _namespace_name "paymentCondition" |> NamespacedName

    /// <summary>
    /// The name or symbol of the monetary unit used for payment.
    /// <see href="https://purl.org/edifact/ontology#paymentCurrency"></see></summary>
    let paymentCurrency =
        Namespaced_IRI.parse _namespace_name "paymentCurrency" |> NamespacedName

    /// <summary>
    /// Reference number assigned to a payment.
    /// <see href="https://purl.org/edifact/ontology#paymentReference"></see></summary>
    let paymentReference =
        Namespaced_IRI.parse _namespace_name "paymentReference" |> NamespacedName

    /// <summary>
    /// Number of the Position of the Line in the whole message
    /// <see href="https://purl.org/edifact/ontology#positionLineNumber"></see></summary>
    let positionLineNumber =
        Namespaced_IRI.parse _namespace_name "positionLineNumber" |> NamespacedName

    /// <summary>
    /// Price and Delivery Conditions of the article displayed in the invoice
    /// <see href="https://purl.org/edifact/ontology#priceAndDeliveryCondition"></see></summary>
    let priceAndDeliveryCondition =
        Namespaced_IRI.parse _namespace_name "priceAndDeliveryCondition" |> NamespacedName

    /// <summary>
    /// Condition of the Price
    /// <see href="https://purl.org/edifact/ontology#priceCondition"></see></summary>
    let priceCondition =
        Namespaced_IRI.parse _namespace_name "priceCondition" |> NamespacedName

    /// <summary>
    /// The name or symbol of the monetary unit used for pricing purposes
    /// <see href="https://purl.org/edifact/ontology#priceCurrency"></see></summary>
    let priceCurrency =
        Namespaced_IRI.parse _namespace_name "priceCurrency" |> NamespacedName

    /// <summary>
    /// Reference number assigned to a price list.
    /// <see href="https://purl.org/edifact/ontology#priceListNumber"></see></summary>
    let priceListNumber =
        Namespaced_IRI.parse _namespace_name "priceListNumber" |> NamespacedName

    /// <summary>
    /// Reference number assigned by the seller to a Proforma Invoice.
    /// <see href="https://purl.org/edifact/ontology#proformaInvoiceNumber"></see></summary>
    let proformaInvoiceNumber =
        Namespaced_IRI.parse _namespace_name "proformaInvoiceNumber" |> NamespacedName

    /// <summary>
    /// Number of the promotional variant number
    /// <see href="https://purl.org/edifact/ontology#promotionalVariantNumber"></see></summary>
    let promotionalVariantNumber =
        Namespaced_IRI.parse _namespace_name "promotionalVariantNumber" |> NamespacedName

    /// <summary>
    /// Note contains purchasing information.
    /// <see href="https://purl.org/edifact/ontology#purchasingInformation"></see></summary>
    let purchasingInformation =
        Namespaced_IRI.parse _namespace_name "purchasingInformation" |> NamespacedName

    /// <summary>
    /// Date/time upon which the goods were received by a given party.
    /// <see href="https://purl.org/edifact/ontology#receiptGoodsDate"></see></summary>
    let receiptGoodsDate =
        Namespaced_IRI.parse _namespace_name "receiptGoodsDate" |> NamespacedName

    /// <summary>
    /// A reference number to a receiving advice.
    /// <see href="https://purl.org/edifact/ontology#receivingAdviceNumber"></see></summary>
    let receivingAdviceNumber =
        Namespaced_IRI.parse _namespace_name "receivingAdviceNumber" |> NamespacedName

    /// <summary>
    /// Indiactor whos the recipient of the message
    /// <see href="https://purl.org/edifact/ontology#recipientIndicator"></see></summary>
    let recipientIndicator =
        Namespaced_IRI.parse _namespace_name "recipientIndicator" |> NamespacedName

    /// <summary>
    /// Quantity which has been received and accepted at a given location.
    /// <see href="https://purl.org/edifact/ontology#recivedAndAcceptedQuantity"></see></summary>
    let recivedAndAcceptedQuantity =
        Namespaced_IRI.parse _namespace_name "recivedAndAcceptedQuantity" |> NamespacedName

    /// <summary>
    /// Quantity which has been received and accepted at a given location with the unit
    /// <see href="https://purl.org/edifact/ontology#recivedAndAcceptedQuantityWithUnit"></see></summary>
    let recivedAndAcceptedQuantityWithUnit =
        Namespaced_IRI.parse _namespace_name "recivedAndAcceptedQuantityWithUnit" |> NamespacedName

    /// <summary>
    /// Reference number for a business account statement as EAN code
    /// <see href="https://purl.org/edifact/ontology#referenceNumberBusinessContactExtractEANCode"></see></summary>
    let referenceNumberBusinessContactExtractEANCode =
        Namespaced_IRI.parse _namespace_name "referenceNumberBusinessContactExtractEANCode" |> NamespacedName

    /// <summary>
    /// Reference number assigned by the customer to a transaction.
    /// <see href="https://purl.org/edifact/ontology#referenceNumberCustomer"></see></summary>
    let referenceNumberCustomer =
        Namespaced_IRI.parse _namespace_name "referenceNumberCustomer" |> NamespacedName

    /// <summary>
    /// Related document number
    /// <see href="https://purl.org/edifact/ontology#relatedDocumentNumber"></see></summary>
    let relatedDocumentNumber =
        Namespaced_IRI.parse _namespace_name "relatedDocumentNumber" |> NamespacedName

    /// <summary>
    /// Release number within the current message version number.
    /// <see href="https://purl.org/edifact/ontology#releaseNumberMessageType"></see></summary>
    let releaseNumberMessageType =
        Namespaced_IRI.parse _namespace_name "releaseNumberMessageType" |> NamespacedName

    /// <summary>
    /// The free text contains information for regulatory authority.
    /// <see href="https://purl.org/edifact/ontology#reportingInformation"></see></summary>
    let reportingInformation =
        Namespaced_IRI.parse _namespace_name "reportingInformation" |> NamespacedName

    /// <summary>
    /// The return quantity
    /// <see href="https://purl.org/edifact/ontology#returnQuantity"></see></summary>
    let returnQuantity =
        Namespaced_IRI.parse _namespace_name "returnQuantity" |> NamespacedName

    /// <summary>
    /// The return quantity with unit
    /// <see href="https://purl.org/edifact/ontology#returnQuantityWithUnit"></see></summary>
    let returnQuantityWithUnit =
        Namespaced_IRI.parse _namespace_name "returnQuantityWithUnit" |> NamespacedName

    /// <summary>
    /// Reference number assigned to a transaction by the seller
    /// <see href="https://purl.org/edifact/ontology#sellersReferenceNumber"></see></summary>
    let sellersReferenceNumber =
        Namespaced_IRI.parse _namespace_name "sellersReferenceNumber" |> NamespacedName

    /// <summary>
    /// Indicator who the sender is
    /// <see href="https://purl.org/edifact/ontology#senderIndicator"></see></summary>
    let senderIndicator =
        Namespaced_IRI.parse _namespace_name "senderIndicator" |> NamespacedName

    /// <summary>
    /// Number assigned by the issuer to his specification.
    /// <see href="https://purl.org/edifact/ontology#specificationNumber"></see></summary>
    let specificationNumber =
        Namespaced_IRI.parse _namespace_name "specificationNumber" |> NamespacedName

    /// <summary>
    /// Remarks from or for a supplier of goods or services.
    /// <see href="https://purl.org/edifact/ontology#supplierNote"></see></summary>
    let supplierNote =
        Namespaced_IRI.parse _namespace_name "supplierNote" |> NamespacedName

    /// <summary>
    /// Identification of the used synatx
    /// <see href="https://purl.org/edifact/ontology#synatxIdentifier"></see></summary>
    let synatxIdentifier =
        Namespaced_IRI.parse _namespace_name "synatxIdentifier" |> NamespacedName

    /// <summary>
    /// Version of the used syntax
    /// <see href="https://purl.org/edifact/ontology#synatxVersion"></see></summary>
    let synatxVersion =
        Namespaced_IRI.parse _namespace_name "synatxVersion" |> NamespacedName

    /// <summary>
    /// Period a tax rate/tax amount etc. is applicable.
    /// <see href="https://purl.org/edifact/ontology#taxPeriod"></see></summary>
    let taxPeriod = Namespaced_IRI.parse _namespace_name "taxPeriod" |> NamespacedName

    /// <summary>
    /// The total number of the segments
    /// <see href="https://purl.org/edifact/ontology#totalNumberOfSegments"></see></summary>
    let totalNumberOfSegments =
        Namespaced_IRI.parse _namespace_name "totalNumberOfSegments" |> NamespacedName

    /// <summary>
    /// The Unit price basis
    /// <see href="https://purl.org/edifact/ontology#unitPriceBasis"></see></summary>
    let unitPriceBasis =
        Namespaced_IRI.parse _namespace_name "unitPriceBasis" |> NamespacedName

    /// <summary>
    /// Number assigned to a manufacturer's product by the Product Code Council.
    /// <see href="https://purl.org/edifact/ontology#universalProductCode"></see></summary>
    let universalProductCode =
        Namespaced_IRI.parse _namespace_name "universalProductCode" |> NamespacedName

    /// <summary>
    /// Document date in the future from which the agreed payment period begins
    /// <see href="https://purl.org/edifact/ontology#valutaDate"></see></summary>
    let valutaDate = Namespaced_IRI.parse _namespace_name "valutaDate" |> NamespacedName

    /// <summary>
    /// Version number of a message type
    /// <see href="https://purl.org/edifact/ontology#versionNumberMessageType"></see></summary>
    let versionNumberMessageType =
        Namespaced_IRI.parse _namespace_name "versionNumberMessageType" |> NamespacedName

    /// <summary>
    /// Numeric value of width
    /// <see href="https://purl.org/edifact/ontology#widthDimension"></see></summary>
    let widthDimension =
        Namespaced_IRI.parse _namespace_name "widthDimension" |> NamespacedName

    /// <summary>
    /// Quantity of goods which are free of charge.
    /// <see href="https://purl.org/edifact/ontology#withoutCalculationQuantity"></see></summary>
    let withoutCalculationQuantity =
        Namespaced_IRI.parse _namespace_name "withoutCalculationQuantity" |> NamespacedName

    /// <summary>
    /// Quantity of goods which are free of charge with unit
    /// <see href="https://purl.org/edifact/ontology#withoutCalculationQuantityWithUnit"></see></summary>
    let withoutCalculationQuantityWithUnit =
        Namespaced_IRI.parse _namespace_name "withoutCalculationQuantityWithUnit" |> NamespacedName
