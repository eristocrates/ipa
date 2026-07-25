namespace https.purl.org.edifact.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module edifact_o =
    let _namespace_iri = Namespace_Iri edifact_o |> NamespaceIRI
    /// <summary>
    ///   <para>edifact-o:seeXML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>seeXML</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#seeXML">https://purl.org/edifact/ontology#seeXML</seealso>
    let seeXML = Prefixed_Name(edifact_o, "seeXML") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contains all the information about a item</para>
    /// labels<para>EDIFACT Item</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#Item">https://purl.org/edifact/ontology#Item</seealso>
    let Item = Prefixed_Name(edifact_o, "Item") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTermsDiscountDueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date by which payment should be made if discount terms are to apply.</para>
    /// labels<para>hasTermsDiscountDueDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTermsDiscountDueDate">https://purl.org/edifact/ontology#hasTermsDiscountDueDate</seealso>
    let hasTermsDiscountDueDate =
        Prefixed_Name(edifact_o, "hasTermsDiscountDueDate") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTotalAdditionsAndDeductions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The amount specified is the total of all charges/allowances.</para>
    /// labels<para>hasTotalAdditionsAndDeductions</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTotalAdditionsAndDeductions">https://purl.org/edifact/ontology#hasTotalAdditionsAndDeductions</seealso>
    let hasTotalAdditionsAndDeductions =
        Prefixed_Name(edifact_o, "hasTotalAdditionsAndDeductions") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTotalAmountMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total Amount of the Message</para>
    /// labels<para>hasTotalAmountMessage</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTotalAmountMessage">https://purl.org/edifact/ontology#hasTotalAmountMessage</seealso>
    let hasTotalAmountMessage =
        Prefixed_Name(edifact_o, "hasTotalAmountMessage") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTotalDutyTaxFeeAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Total of all duty/tax/fee amounts.</para>
    /// labels<para>hasTotalDutyTasFeeAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTotalDutyTaxFeeAmount">https://purl.org/edifact/ontology#hasTotalDutyTaxFeeAmount</seealso>
    let hasTotalDutyTaxFeeAmount =
        Prefixed_Name(edifact_o, "hasTotalDutyTaxFeeAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTotalLineItemAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The sum of all the line item amounts.</para>
    /// labels<para>hasTotalLineItemAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTotalLineItemAmount">https://purl.org/edifact/ontology#hasTotalLineItemAmount</seealso>
    let hasTotalLineItemAmount =
        Prefixed_Name(edifact_o, "hasTotalLineItemAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:CentralRegulatorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party which is the central regulator</para>
    /// labels<para>CentralRegulatorRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#CentralRegulatorRole">https://purl.org/edifact/ontology#CentralRegulatorRole</seealso>
    let CentralRegulatorRole =
        Prefixed_Name(edifact_o, "CentralRegulatorRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:DeliveryPartyRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party to which goods should be delivered, if not identical with consignee.</para>
    /// labels<para>DeliveryPartyRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#DeliveryPartyRole">https://purl.org/edifact/ontology#DeliveryPartyRole</seealso>
    let DeliveryPartyRole =
        Prefixed_Name(edifact_o, "DeliveryPartyRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:EDIFACT-Structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>Contains all the information which are necessary for the invoice to be a valid EDIFACT Invoice</para>
    /// labels<para>EDIFACT-Structure</para><para>EDIFACT-Structure</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#EDIFACT-Structure">https://purl.org/edifact/ontology#EDIFACT-Structure</seealso>
    let EDIFACT_Structure =
        Prefixed_Name(edifact_o, "EDIFACT-Structure") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:InvoiceDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contains all the general information about an invoice</para>
    /// labels<para>InvoiceDetails</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#InvoiceDetails">https://purl.org/edifact/ontology#InvoiceDetails</seealso>
    let InvoiceDetails = Prefixed_Name(edifact_o, "InvoiceDetails") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:InvoiceeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party to whom an invoice is issued</para>
    /// labels<para>InvoiceeRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#InvoiceeRole">https://purl.org/edifact/ontology#InvoiceeRole</seealso>
    let InvoiceeRole = Prefixed_Name(edifact_o, "InvoiceeRole") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:PayeeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party initiating payment</para>
    /// labels<para>PayeeRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#PayeeRole">https://purl.org/edifact/ontology#PayeeRole</seealso>
    let PayeeRole = Prefixed_Name(edifact_o, "PayeeRole") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:RecipientRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party to which goods are consigned.</para>
    /// labels<para>RecipientRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#RecipientRole">https://purl.org/edifact/ontology#RecipientRole</seealso>
    let RecipientRole = Prefixed_Name(edifact_o, "RecipientRole") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:RegulatorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party which is the regulator of the invoice</para>
    /// labels<para>RegulatorRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#RegulatorRole">https://purl.org/edifact/ontology#RegulatorRole</seealso>
    let RegulatorRole = Prefixed_Name(edifact_o, "RegulatorRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:RepresentativeOfSupplierRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party representing the seller for the purpose of the trade transaction.</para>
    /// labels<para>RepresentativeOfSupplierRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#RepresentativeOfSupplierRole">https://purl.org/edifact/ontology#RepresentativeOfSupplierRole</seealso>
    let RepresentativeOfSupplierRole =
        Prefixed_Name(edifact_o, "RepresentativeOfSupplierRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:SellerRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party selling merchandise to a buyer.</para>
    /// labels<para>SellerRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#SellerRole">https://purl.org/edifact/ontology#SellerRole</seealso>
    let SellerRole = Prefixed_Name(edifact_o, "SellerRole") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:SupplierRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party which manufactures or otherwise has possession of goods, and consigns or makes them available in trade.</para>
    /// labels<para>SupplierRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#SupplierRole">https://purl.org/edifact/ontology#SupplierRole</seealso>
    let SupplierRole = Prefixed_Name(edifact_o, "SupplierRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:WarehouseNumberRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party that runs the Warehouse</para>
    /// labels<para>WarehouseNumberRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#WarehouseNumberRole">https://purl.org/edifact/ontology#WarehouseNumberRole</seealso>
    let WarehouseNumberRole =
        Prefixed_Name(edifact_o, "WarehouseNumberRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:accountsReceivableNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by accounts receivable department to the account of a specific debtor.</para>
    /// labels<para>accountsReceivableNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#accountsReceivableNumber">https://purl.org/edifact/ontology#accountsReceivableNumber</seealso>
    let accountsReceivableNumber =
        Prefixed_Name(edifact_o, "accountsReceivableNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:additionalPartnerIdentificationEANCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Additional Partneridentification (GLN-Code)</para>
    /// labels<para>additionalPartnerIdentificationEANCode</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#additionalPartnerIdentificationEANCode">https://purl.org/edifact/ontology#additionalPartnerIdentificationEANCode</seealso>
    let additionalPartnerIdentificationEANCode =
        Prefixed_Name(edifact_o, "additionalPartnerIdentificationEANCode") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:allowanceReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reason for the allowance</para>
    /// labels<para>allowanceReason</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#allowanceReason">https://purl.org/edifact/ontology#allowanceReason</seealso>
    let allowanceReason = Prefixed_Name(edifact_o, "allowanceReason") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:beneficiaryReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference of the beneficiary</para>
    /// labels<para>beneficiaryReference</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#beneficiaryReference">https://purl.org/edifact/ontology#beneficiaryReference</seealso>
    let beneficiaryReference =
        Prefixed_Name(edifact_o, "beneficiaryReference") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:bilateralAgreed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Note contains information mutually defined by trading partners</para>
    /// labels<para>bilateralAgreed</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#bilateralAgreed">https://purl.org/edifact/ontology#bilateralAgreed</seealso>
    let bilateralAgreed = Prefixed_Name(edifact_o, "bilateralAgreed") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:calculationPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Period for which an invoice is issued.</para>
    /// labels<para>calculationPeriod</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#calculationPeriod">https://purl.org/edifact/ontology#calculationPeriod</seealso>
    let calculationPeriod =
        Prefixed_Name(edifact_o, "calculationPeriod") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:timePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contains a time Period</para>
    /// labels<para>timePeriod</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#timePeriod">https://purl.org/edifact/ontology#timePeriod</seealso>
    let timePeriod = Prefixed_Name(edifact_o, "timePeriod") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:changeInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Note contains change information</para>
    /// labels<para>changeInformation</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#changeInformation">https://purl.org/edifact/ontology#changeInformation</seealso>
    let changeInformation =
        Prefixed_Name(edifact_o, "changeInformation") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:consumerUnitsInTradingUnitQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Numbers of consumer units in the traded unit</para>
    /// labels<para>consumerUnitsInTradingUnitQuantity</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#consumerUnitsInTradingUnitQuantity">https://purl.org/edifact/ontology#consumerUnitsInTradingUnitQuantity</seealso>
    let consumerUnitsInTradingUnitQuantity =
        Prefixed_Name(edifact_o, "consumerUnitsInTradingUnitQuantity") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>display a quantity</para>
    /// labels<para>quantity</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#quantity">https://purl.org/edifact/ontology#quantity</seealso>
    let quantity = Prefixed_Name(edifact_o, "quantity") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactDepartmentPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The department or person within an organizational entity.</para>
    /// labels<para>contactDepartmentPerson</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactDepartmentPerson">https://purl.org/edifact/ontology#contactDepartmentPerson</seealso>
    let contactDepartmentPerson =
        Prefixed_Name(edifact_o, "contactDepartmentPerson") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contact Persons</para>
    /// labels<para>contactPerson</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersom">https://purl.org/edifact/ontology#contactPersom</seealso>
    let contactPersom = Prefixed_Name(edifact_o, "contactPersom") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonAccounting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Department/person responsible for the accounts payable function within a corporation.</para>
    /// labels<para>contactPersonAccounting</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonAccounting">https://purl.org/edifact/ontology#contactPersonAccounting</seealso>
    let contactPersonAccounting =
        Prefixed_Name(edifact_o, "contactPersonAccounting") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonCreditorAccounting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Department/person responsible for the accounts payable function within a corporation</para>
    /// labels<para>contactPersonCreditorAccounting</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonCreditorAccounting">https://purl.org/edifact/ontology#contactPersonCreditorAccounting</seealso>
    let contactPersonCreditorAccounting =
        Prefixed_Name(edifact_o, "contactPersonCreditorAccounting") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonEmailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Creating/sending/receiving of unstructured free text messages or documents using computer network, a mini- computer or an attached modem and regular telephone line or other electronic transmission media.</para>
    /// labels<para>contactPersonEmailAddress</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonEmailAddress">https://purl.org/edifact/ontology#contactPersonEmailAddress</seealso>
    let contactPersonEmailAddress =
        Prefixed_Name(edifact_o, "contactPersonEmailAddress") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonFaxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Device used for transmitting and reproducing fixed graphic material (as printing) by means of signals over telephone lines or other electronic transmission media.</para>
    /// labels<para>contactPersonFaxNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonFaxNumber">https://purl.org/edifact/ontology#contactPersonFaxNumber</seealso>
    let contactPersonFaxNumber =
        Prefixed_Name(edifact_o, "contactPersonFaxNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Department/person to contact for questions regarding transactions</para>
    /// labels<para>contactPersonInformation</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonInformation">https://purl.org/edifact/ontology#contactPersonInformation</seealso>
    let contactPersonInformation =
        Prefixed_Name(edifact_o, "contactPersonInformation") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonReceivableAccounting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Department/person responsible for the accounts receivable within a corporation</para>
    /// labels<para>contactPersonReceivableAccounting</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonReceivableAccounting">https://purl.org/edifact/ontology#contactPersonReceivableAccounting</seealso>
    let contactPersonReceivableAccounting =
        Prefixed_Name(edifact_o, "contactPersonReceivableAccounting") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonSalesDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The sales representative or department contact within an organization.</para>
    /// labels<para>contactPersonSalesDepartment</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonSalesDepartment">https://purl.org/edifact/ontology#contactPersonSalesDepartment</seealso>
    let contactPersonSalesDepartment =
        Prefixed_Name(edifact_o, "contactPersonSalesDepartment") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonTelefonNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Voice/data transmission by telephone</para>
    /// labels<para>contactPersonTelefonNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonTelefonNumber">https://purl.org/edifact/ontology#contactPersonTelefonNumber</seealso>
    let contactPersonTelefonNumber =
        Prefixed_Name(edifact_o, "contactPersonTelefonNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonX400Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>CCITT Message handling system</para>
    /// labels<para>contactPersonX400Number</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonX400Number">https://purl.org/edifact/ontology#contactPersonX400Number</seealso>
    let contactPersonX400Number =
        Prefixed_Name(edifact_o, "contactPersonX400Number") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contractNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number of a contract concluded between parties.</para>
    /// labels<para>contractNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contractNumber">https://purl.org/edifact/ontology#contractNumber</seealso>
    let contractNumber = Prefixed_Name(edifact_o, "contractNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contractNumberBuyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by buyer to a contract.</para>
    /// labels<para>contractNumberBuyer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contractNumberBuyer">https://purl.org/edifact/ontology#contractNumberBuyer</seealso>
    let contractNumberBuyer =
        Prefixed_Name(edifact_o, "contractNumberBuyer") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:creationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when the message was created</para>
    /// labels<para>creationDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#creationDate">https://purl.org/edifact/ontology#creationDate</seealso>
    let creationDate = Prefixed_Name(edifact_o, "creationDate") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:creationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Time of the creation of the EDIFACT message</para>
    /// labels<para>creationTime</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#creationTime">https://purl.org/edifact/ontology#creationTime</seealso>
    let creationTime = Prefixed_Name(edifact_o, "creationTime") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:creditNoteNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned to a credit note.</para>
    /// labels<para>creditNoteNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#creditNoteNumber">https://purl.org/edifact/ontology#creditNoteNumber</seealso>
    let creditNoteNumber = Prefixed_Name(edifact_o, "creditNoteNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dataExchangeCounter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>the counter of the exchanged data</para>
    /// labels<para>dataExchangeCounter</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dataExchangeCounter">https://purl.org/edifact/ontology#dataExchangeCounter</seealso>
    let dataExchangeCounter =
        Prefixed_Name(edifact_o, "dataExchangeCounter") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dataExchangeReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>the reference of the exchanged data</para>
    /// labels<para>dataExchangeReference</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dataExchangeReference">https://purl.org/edifact/ontology#dataExchangeReference</seealso>
    let dataExchangeReference =
        Prefixed_Name(edifact_o, "dataExchangeReference") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateAccountsReceivableNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by accounts receivable department to the account of a specific debtor.</para>
    /// labels<para>dateAccountsReceivableNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateAccountsReceivableNumber">https://purl.org/edifact/ontology#dateAccountsReceivableNumber</seealso>
    let dateAccountsReceivableNumber =
        Prefixed_Name(edifact_o, "dateAccountsReceivableNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:referenceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference Date</para>
    /// labels<para>referenceDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#referenceDate">https://purl.org/edifact/ontology#referenceDate</seealso>
    let referenceDate = Prefixed_Name(edifact_o, "referenceDate") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateAdditionalPartnerIdentificationEANCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of Additional Partneridentification (GLN-Code)</para>
    /// labels<para>dateAdditionalPartnerIdentificationEANCode</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateAdditionalPartnerIdentificationEANCode">https://purl.org/edifact/ontology#dateAdditionalPartnerIdentificationEANCode</seealso>
    let dateAdditionalPartnerIdentificationEANCode =
        Prefixed_Name(edifact_o, "dateAdditionalPartnerIdentificationEANCode") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateBeneficiaryReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference of the beneficiary</para>
    /// labels<para>dateBeneficiaryReference</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateBeneficiaryReference">https://purl.org/edifact/ontology#dateBeneficiaryReference</seealso>
    let dateBeneficiaryReference =
        Prefixed_Name(edifact_o, "dateBeneficiaryReference") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateCompanyOrPlaceRegistristrationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of company registration and place as legally required.</para>
    /// labels<para>dateCompanyOrPlaceRegistristrationNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateCompanyOrPlaceRegistristrationNumber">https://purl.org/edifact/ontology#dateCompanyOrPlaceRegistristrationNumber</seealso>
    let dateCompanyOrPlaceRegistristrationNumber =
        Prefixed_Name(edifact_o, "dateCompanyOrPlaceRegistristrationNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateContractNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number of a contract concluded between parties.</para>
    /// labels<para>dateContractNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateContractNumber">https://purl.org/edifact/ontology#dateContractNumber</seealso>
    let dateContractNumber =
        Prefixed_Name(edifact_o, "dateContractNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateCreditNoteNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned to a credit note.</para>
    /// labels<para>dateCreditNoteNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateCreditNoteNumber">https://purl.org/edifact/ontology#dateCreditNoteNumber</seealso>
    let dateCreditNoteNumber =
        Prefixed_Name(edifact_o, "dateCreditNoteNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateCustomsTariffNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the code number of the goods in accordance with the tariff nomenclature system of classification in use where the Customs declaration is made.</para>
    /// labels<para>dateCustomsTariffNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateCustomsTariffNumber">https://purl.org/edifact/ontology#dateCustomsTariffNumber</seealso>
    let dateCustomsTariffNumber =
        Prefixed_Name(edifact_o, "dateCustomsTariffNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateDebitNoteNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by issuer to a debit note</para>
    /// labels<para>dateDebitNoteNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateDebitNoteNumber">https://purl.org/edifact/ontology#dateDebitNoteNumber</seealso>
    let dateDebitNoteNumber =
        Prefixed_Name(edifact_o, "dateDebitNoteNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateDeliveryNoteNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by the issuer to a delivery note.</para>
    /// labels<para>dateDeliveryNoteNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateDeliveryNoteNumber">https://purl.org/edifact/ontology#dateDeliveryNoteNumber</seealso>
    let dateDeliveryNoteNumber =
        Prefixed_Name(edifact_o, "dateDeliveryNoteNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:FormalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class containing information about the perfomed role of the involved organizations</para>
    /// labels<para>FormalOrganization</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#FormalOrganization">https://purl.org/edifact/ontology#FormalOrganization</seealso>
    let FormalOrganization =
        Prefixed_Name(edifact_o, "FormalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:numberOfBundleMessages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A batch number identifying a batch of messages.</para>
    /// labels<para>numberOfBundleMessages</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#numberOfBundleMessages">https://purl.org/edifact/ontology#numberOfBundleMessages</seealso>
    let numberOfBundleMessages =
        Prefixed_Name(edifact_o, "numberOfBundleMessages") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:InvoiceContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>Defined as the union of the classes Item and InvoiceDetails</para>
    ///   <para>Defined as the union of the classes Item and InvoiceDetails</para>
    /// labels<para>Invoice Content</para><para>InvoiceContent</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#InvoiceContent">https://purl.org/edifact/ontology#InvoiceContent</seealso>
    let InvoiceContent = Prefixed_Name(edifact_o, "InvoiceContent") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:belongsToProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates to which business process the invoice belongs</para>
    /// labels<para>belongsToProcess</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#belongsToProcess">https://purl.org/edifact/ontology#belongsToProcess</seealso>
    let belongsToProcess = Prefixed_Name(edifact_o, "belongsToProcess") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasAdditionalProductIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information which specifies and qualifies product identifications.</para>
    /// labels<para>hasAdditionalProductIdentification</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasAdditionalProductIdentification">https://purl.org/edifact/ontology#hasAdditionalProductIdentification</seealso>
    let hasAdditionalProductIdentification =
        Prefixed_Name(edifact_o, "hasAdditionalProductIdentification") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasAllowancePercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Allowance expressed as a percentage.</para>
    /// labels<para>hasAllowancePercentage</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasAllowancePercentage">https://purl.org/edifact/ontology#hasAllowancePercentage</seealso>
    let hasAllowancePercentage =
        Prefixed_Name(edifact_o, "hasAllowancePercentage") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasAllowanceReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The reason for the allowance</para>
    /// labels<para>hasAllowanceReason</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasAllowanceReason">https://purl.org/edifact/ontology#hasAllowanceReason</seealso>
    let hasAllowanceReason =
        Prefixed_Name(edifact_o, "hasAllowanceReason") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:valutaDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Document date in the future from which the agreed payment period begins</para>
    /// labels<para>valutaDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#valutaDate">https://purl.org/edifact/ontology#valutaDate</seealso>
    let valutaDate = Prefixed_Name(edifact_o, "valutaDate") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:seeEDIFACT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>seeEDIFACT</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#seeEDIFACT">https://purl.org/edifact/ontology#seeEDIFACT</seealso>
    let seeEDIFACT = Prefixed_Name(edifact_o, "seeEDIFACT") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:hasChargeReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The reason for the charge</para>
    /// labels<para>hasChargeReason</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasChargeReason">https://purl.org/edifact/ontology#hasChargeReason</seealso>
    let hasChargeReason = Prefixed_Name(edifact_o, "hasChargeReason") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasDiscountPercentagePaymentConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Discount expressed as a percentage with payment condition</para>
    /// labels<para>hasDiscountPercentagePaymentConditions</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasDiscountPercentagePaymentConditions">https://purl.org/edifact/ontology#hasDiscountPercentagePaymentConditions</seealso>
    let hasDiscountPercentagePaymentConditions =
        Prefixed_Name(edifact_o, "hasDiscountPercentagePaymentConditions") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasDocumentFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the function of the message</para>
    /// labels<para>hasDocumentFunction</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasDocumentFunction">https://purl.org/edifact/ontology#hasDocumentFunction</seealso>
    let hasDocumentFunction =
        Prefixed_Name(edifact_o, "hasDocumentFunction") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasDocumentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Document/message identifier expressed</para>
    /// labels<para>hasDocumentType</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasDocumentType">https://purl.org/edifact/ontology#hasDocumentType</seealso>
    let hasDocumentType = Prefixed_Name(edifact_o, "hasDocumentType") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasDueDeductionAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount of the discount due</para>
    /// labels<para>hasDueDeductionAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasDueDeductionAmount">https://purl.org/edifact/ontology#hasDueDeductionAmount</seealso>
    let hasDueDeductionAmount =
        Prefixed_Name(edifact_o, "hasDueDeductionAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasFunctionInInvoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes the role of a party involved in the invoice</para>
    /// labels<para>hasFunctionInInvoice</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasFunctionInInvoice">https://purl.org/edifact/ontology#hasFunctionInInvoice</seealso>
    let hasFunctionInInvoice =
        Prefixed_Name(edifact_o, "hasFunctionInInvoice") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTAXrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contains the TAX rate</para>
    /// labels<para>hasTAXrate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTAXrate">https://purl.org/edifact/ontology#hasTAXrate</seealso>
    let hasTAXrate = Prefixed_Name(edifact_o, "hasTAXrate") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasGeneralInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contains general information about the Invoice or a Item</para>
    /// labels<para>hasGeneralInformation</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasGeneralInformation">https://purl.org/edifact/ontology#hasGeneralInformation</seealso>
    let hasGeneralInformation =
        Prefixed_Name(edifact_o, "hasGeneralInformation") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasGrosspricePerUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The price stated is the gross price per unit to which allowances/ charges must be applied.</para>
    /// labels<para>hasGrosspricePerUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasGrosspricePerUnit">https://purl.org/edifact/ontology#hasGrosspricePerUnit</seealso>
    let hasGrosspricePerUnit =
        Prefixed_Name(edifact_o, "hasGrosspricePerUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:InvoicingPartyRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party issuing an invoice</para>
    /// labels<para>InvoicingPartyRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#InvoicingPartyRole">https://purl.org/edifact/ontology#InvoicingPartyRole</seealso>
    let InvoicingPartyRole =
        Prefixed_Name(edifact_o, "InvoicingPartyRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:RecipientOfInvoiceRegulationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party to whom payment for a commercial invoice or bill should be remitted.</para>
    /// labels<para>RecipientOfInvoiceRegulationRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#RecipientOfInvoiceRegulationRole">https://purl.org/edifact/ontology#RecipientOfInvoiceRegulationRole</seealso>
    let RecipientOfInvoiceRegulationRole =
        Prefixed_Name(edifact_o, "RecipientOfInvoiceRegulationRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:SalesAgentRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the third party who arranged the purchase of merchandise on behalf of the actual buyer</para>
    /// labels<para>SalesAgentRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#SalesAgentRole">https://purl.org/edifact/ontology#SalesAgentRole</seealso>
    let SalesAgentRole = Prefixed_Name(edifact_o, "SalesAgentRole") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:SendToRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party to where goods will be or have been shipped</para>
    /// labels<para>SendToRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#SendToRole">https://purl.org/edifact/ontology#SendToRole</seealso>
    let SendToRole = Prefixed_Name(edifact_o, "SendToRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:SuppliersCompanyHeadquarterRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party's headquarters which manufactures or otherwise has possession of goods, and consigns or makes them available in trade.</para>
    /// labels<para>SuppliersCompanyHeadquarterRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#SuppliersCompanyHeadquarterRole">https://purl.org/edifact/ontology#SuppliersCompanyHeadquarterRole</seealso>
    let SuppliersCompanyHeadquarterRole =
        Prefixed_Name(edifact_o, "SuppliersCompanyHeadquarterRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:WholesalerRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party that is the wholesaler</para>
    /// labels<para>WholesalerRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#WholesalerRole">https://purl.org/edifact/ontology#WholesalerRole</seealso>
    let WholesalerRole = Prefixed_Name(edifact_o, "WholesalerRole") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:noteNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>identifier which is a number</para>
    /// labels<para>noteNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#noteNumber">https://purl.org/edifact/ontology#noteNumber</seealso>
    let noteNumber = Prefixed_Name(edifact_o, "noteNumber") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:isStandardOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>shows of which invoice the EDIFACT Structure is</para>
    /// labels<para>isStandardOf</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#isStandardOf">https://purl.org/edifact/ontology#isStandardOf</seealso>
    let isStandardOf = Prefixed_Name(edifact_o, "isStandardOf") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:governmentReferenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Refernce number given by the goverment</para>
    /// labels<para>governmentReferenceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#governmentReferenceNumber">https://purl.org/edifact/ontology#governmentReferenceNumber</seealso>
    let governmentReferenceNumber =
        Prefixed_Name(edifact_o, "governmentReferenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:harmonisedSystemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the number specifying the goods classification under the Harmonised Commodity Description and Coding System of the Customs Co-operation Council (CCC).</para>
    /// labels<para>harmonisedSystemNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#harmonisedSystemNumber">https://purl.org/edifact/ontology#harmonisedSystemNumber</seealso>
    let harmonisedSystemNumber =
        Prefixed_Name(edifact_o, "harmonisedSystemNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:releaseNumberMessageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Release number within the current message version number.</para>
    /// labels<para>releaseNumberMessageType</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#releaseNumberMessageType">https://purl.org/edifact/ontology#releaseNumberMessageType</seealso>
    let releaseNumberMessageType =
        Prefixed_Name(edifact_o, "releaseNumberMessageType") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:reportingInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The free text contains information for regulatory authority.</para>
    /// labels<para>reportingInformation</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#reportingInformation">https://purl.org/edifact/ontology#reportingInformation</seealso>
    let reportingInformation =
        Prefixed_Name(edifact_o, "reportingInformation") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:returnQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The return quantity</para>
    /// labels<para>returnQuantity</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#returnQuantity">https://purl.org/edifact/ontology#returnQuantity</seealso>
    let returnQuantity = Prefixed_Name(edifact_o, "returnQuantity") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:senderIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicator who the sender is</para>
    /// labels<para>senderIndicator</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#senderIndicator">https://purl.org/edifact/ontology#senderIndicator</seealso>
    let senderIndicator = Prefixed_Name(edifact_o, "senderIndicator") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:supplierNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Remarks from or for a supplier of goods or services.</para>
    /// labels<para>supplierNote</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#supplierNote">https://purl.org/edifact/ontology#supplierNote</seealso>
    let supplierNote = Prefixed_Name(edifact_o, "supplierNote") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:synatxVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Version of the used syntax</para>
    /// labels<para>synatxVersion</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#synatxVersion">https://purl.org/edifact/ontology#synatxVersion</seealso>
    let synatxVersion = Prefixed_Name(edifact_o, "synatxVersion") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:totalNumberOfSegments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of the segments</para>
    /// labels<para>totalNumberOfSegments</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#totalNumberOfSegments">https://purl.org/edifact/ontology#totalNumberOfSegments</seealso>
    let totalNumberOfSegments =
        Prefixed_Name(edifact_o, "totalNumberOfSegments") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:unitPriceBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Unit price basis</para>
    /// labels<para>unitPriceBasis</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#unitPriceBasis">https://purl.org/edifact/ontology#unitPriceBasis</seealso>
    let unitPriceBasis = Prefixed_Name(edifact_o, "unitPriceBasis") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:universalProductCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number assigned to a manufacturer's product by the Product Code Council.</para>
    /// labels<para>universalProductCode</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#universalProductCode">https://purl.org/edifact/ontology#universalProductCode</seealso>
    let universalProductCode =
        Prefixed_Name(edifact_o, "universalProductCode") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:versionNumberMessageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Version number of a message type</para>
    /// labels<para>versionNumberMessageType</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#versionNumberMessageType">https://purl.org/edifact/ontology#versionNumberMessageType</seealso>
    let versionNumberMessageType =
        Prefixed_Name(edifact_o, "versionNumberMessageType") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:widthDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Numeric value of width</para>
    /// labels<para>widthDimension</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#widthDimension">https://purl.org/edifact/ontology#widthDimension</seealso>
    let widthDimension = Prefixed_Name(edifact_o, "widthDimension") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:returnQuantityWithUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The return quantity with unit</para>
    /// labels<para>returnQuantityWithUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#returnQuantityWithUnit">https://purl.org/edifact/ontology#returnQuantityWithUnit</seealso>
    let returnQuantityWithUnit =
        Prefixed_Name(edifact_o, "returnQuantityWithUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:sellersReferenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned to a transaction by the seller</para>
    /// labels<para>sellersReferenceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#sellersReferenceNumber">https://purl.org/edifact/ontology#sellersReferenceNumber</seealso>
    let sellersReferenceNumber =
        Prefixed_Name(edifact_o, "sellersReferenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:specificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number assigned by the issuer to his specification.</para>
    /// labels<para>specificationNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#specificationNumber">https://purl.org/edifact/ontology#specificationNumber</seealso>
    let specificationNumber =
        Prefixed_Name(edifact_o, "specificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:synatxIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identification of the used synatx</para>
    /// labels<para>synatxIdentifier</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#synatxIdentifier">https://purl.org/edifact/ontology#synatxIdentifier</seealso>
    let synatxIdentifier = Prefixed_Name(edifact_o, "synatxIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:taxPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Period a tax rate/tax amount etc. is applicable.</para>
    /// labels<para>taxPeriod</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#taxPeriod">https://purl.org/edifact/ontology#taxPeriod</seealso>
    let taxPeriod = Prefixed_Name(edifact_o, "taxPeriod") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:E-Invoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>The root class of each invoice. Contains all the linked classes with information about the invoice</para>
    /// labels<para>EDIFACT E-Invoice</para><para>E-Invoice</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#E-Invoice">https://purl.org/edifact/ontology#E-Invoice</seealso>
    let E_Invoice = Prefixed_Name(edifact_o, "E-Invoice") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:companyOrPlaceRegistristrationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Company registration and place as legally required.</para>
    /// labels<para>companyOrPlaceRegistristrationNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#companyOrPlaceRegistristrationNumber">https://purl.org/edifact/ontology#companyOrPlaceRegistristrationNumber</seealso>
    let companyOrPlaceRegistristrationNumber =
        Prefixed_Name(edifact_o, "companyOrPlaceRegistristrationNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:consumerUnitsInTradingUnitQuantityWithUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Numbers of consumer units in the traded unit</para>
    /// labels<para>consumerUnitsInTradingUnitQuantityWithUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#consumerUnitsInTradingUnitQuantityWithUnit">https://purl.org/edifact/ontology#consumerUnitsInTradingUnitQuantityWithUnit</seealso>
    let consumerUnitsInTradingUnitQuantityWithUnit =
        Prefixed_Name(edifact_o, "consumerUnitsInTradingUnitQuantityWithUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasBasicTaxAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The amount specified is the basis for duty/tax or fee.</para>
    /// labels<para>hasBasicTaxAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasBasicTaxAmount">https://purl.org/edifact/ontology#hasBasicTaxAmount</seealso>
    let hasBasicTaxAmount =
        Prefixed_Name(edifact_o, "hasBasicTaxAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasChargePercentagePaymentConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Charge expressed as a percentage with the payment conditions</para>
    /// labels<para>hasChargePercentagePaymentConditions</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasChargePercentagePaymentConditions">https://purl.org/edifact/ontology#hasChargePercentagePaymentConditions</seealso>
    let hasChargePercentagePaymentConditions =
        Prefixed_Name(edifact_o, "hasChargePercentagePaymentConditions") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Cotains the city name of a party involved in the invoice</para>
    /// labels<para>hasCity</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasCity">https://purl.org/edifact/ontology#hasCity</seealso>
    let hasCity = Prefixed_Name(edifact_o, "hasCity") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasDiscountAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The amount specified is the discount amount</para>
    /// labels<para>hasDiscountAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasDiscountAmount">https://purl.org/edifact/ontology#hasDiscountAmount</seealso>
    let hasDiscountAmount =
        Prefixed_Name(edifact_o, "hasDiscountAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasDiscountPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Discount expressed as a percentage.</para>
    /// labels<para>hasDiscountPercentage</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasDiscountPercentage">https://purl.org/edifact/ontology#hasDiscountPercentage</seealso>
    let hasDiscountPercentage =
        Prefixed_Name(edifact_o, "hasDiscountPercentage") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasDiscreteQuantityWithUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The discrete quantity with unit</para>
    /// labels<para>hasDiscreteQuantityWithUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasDiscreteQuantityWithUnit">https://purl.org/edifact/ontology#hasDiscreteQuantityWithUnit</seealso>
    let hasDiscreteQuantityWithUnit =
        Prefixed_Name(edifact_o, "hasDiscreteQuantityWithUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasDocumentNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Document/message number</para>
    /// labels<para>hasDocumentNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasDocumentNumber">https://purl.org/edifact/ontology#hasDocumentNumber</seealso>
    let hasDocumentNumber =
        Prefixed_Name(edifact_o, "hasDocumentNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasDueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Due date</para>
    /// labels<para>hasDueDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasDueDate">https://purl.org/edifact/ontology#hasDueDate</seealso>
    let hasDueDate = Prefixed_Name(edifact_o, "hasDueDate") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:hasFreightCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount to be paid for moving goods, by whatever means, from one place to another, inclusive discounts, allowances, rebates, adjustment factors and additional cost relating to freight costs (UN/ECE Recommendation no 23).</para>
    /// labels<para>hasFreightCharge</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasFreightCharge">https://purl.org/edifact/ontology#hasFreightCharge</seealso>
    let hasFreightCharge = Prefixed_Name(edifact_o, "hasFreightCharge") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:hasGSTrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Tax levied on the final consumption of goods and services throughout the production and distribution chain.</para>
    /// labels<para>hasGSTrate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasGSTrate">https://purl.org/edifact/ontology#hasGSTrate</seealso>
    let hasGSTrate = Prefixed_Name(edifact_o, "hasGSTrate") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasGrosspriceOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The price stated is the gross price per item to which allowances/ charges must be applied.</para>
    /// labels<para>hasGrosspriceOfItem</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasGrosspriceOfItem">https://purl.org/edifact/ontology#hasGrosspriceOfItem</seealso>
    let hasGrosspriceOfItem =
        Prefixed_Name(edifact_o, "hasGrosspriceOfItem") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasHeightDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Numeric value of height</para>
    /// labels<para>hasHeightDimension</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasHeightDimension">https://purl.org/edifact/ontology#hasHeightDimension</seealso>
    let hasHeightDimension =
        Prefixed_Name(edifact_o, "hasHeightDimension") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasInvoiceDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Contains the Invoice Details of an Invoice</para>
    /// labels<para>hasInvoiceDetails</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasInvoiceDetails">https://purl.org/edifact/ontology#hasInvoiceDetails</seealso>
    let hasInvoiceDetails =
        Prefixed_Name(edifact_o, "hasInvoiceDetails") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:isInvoiceDetailsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>shows to which Invoice the Invoice Details belong</para>
    /// labels<para>isInvoiceDetailsOf</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#isInvoiceDetailsOf">https://purl.org/edifact/ontology#isInvoiceDetailsOf</seealso>
    let isInvoiceDetailsOf =
        Prefixed_Name(edifact_o, "isInvoiceDetailsOf") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasInvoicePercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Percentage used in the whole invoice</para>
    /// labels<para>hasInvoicePercentage</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasInvoicePercentage">https://purl.org/edifact/ontology#hasInvoicePercentage</seealso>
    let hasInvoicePercentage =
        Prefixed_Name(edifact_o, "hasInvoicePercentage") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonIncomingGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Department/person responsible for receiving the goods at the place of delivery.</para>
    /// labels<para>contactPersonIncomingGoods</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonIncomingGoods">https://purl.org/edifact/ontology#contactPersonIncomingGoods</seealso>
    let contactPersonIncomingGoods =
        Prefixed_Name(edifact_o, "contactPersonIncomingGoods") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonPurchasingDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Department/person responsible for issuing this purchase order.</para>
    /// labels<para>contactPersonPurchasingDepartment</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonPurchasingDepartment">https://purl.org/edifact/ontology#contactPersonPurchasingDepartment</seealso>
    let contactPersonPurchasingDepartment =
        Prefixed_Name(edifact_o, "contactPersonPurchasingDepartment") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasInvoiceAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Total sum charged in respect of a single Invoice in accordance with the terms of delivery.</para>
    /// labels<para>hasInvoiceAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasInvoiceAmount">https://purl.org/edifact/ontology#hasInvoiceAmount</seealso>
    let hasInvoiceAmount = Prefixed_Name(edifact_o, "hasInvoiceAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasInvoicePercentagePaymentConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Percentage used in the whole invoice with payment conditions</para>
    /// labels<para>hasInvoicePercentagePaymentConditions</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasInvoicePercentagePaymentConditions">https://purl.org/edifact/ontology#hasInvoicePercentagePaymentConditions</seealso>
    let hasInvoicePercentagePaymentConditions =
        Prefixed_Name(edifact_o, "hasInvoicePercentagePaymentConditions") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>shows which items are included in an invoice</para>
    /// labels<para>hasItem</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasItem">https://purl.org/edifact/ontology#hasItem</seealso>
    let hasItem = Prefixed_Name(edifact_o, "hasItem") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasNetPriceOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The price stated is the net price per item including allowances/ charges. Allowances/charges may be stated for information only.</para>
    /// labels<para>hasNetPriceOfItem</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasNetPriceOfItem">https://purl.org/edifact/ontology#hasNetPriceOfItem</seealso>
    let hasNetPriceOfItem =
        Prefixed_Name(edifact_o, "hasNetPriceOfItem") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasNetpricePerUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The price stated is the net price per unit including allowances/ charges. Allowances/charges may be stated for information only.</para>
    /// labels<para>hasNetpricePerUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasNetpricePerUnit">https://purl.org/edifact/ontology#hasNetpricePerUnit</seealso>
    let hasNetpricePerUnit =
        Prefixed_Name(edifact_o, "hasNetpricePerUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasPaymentDiscountAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount of the payment discount</para>
    /// labels<para>hasPaymentDiscountAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasPaymentDiscountAmount">https://purl.org/edifact/ontology#hasPaymentDiscountAmount</seealso>
    let hasPaymentDiscountAmount =
        Prefixed_Name(edifact_o, "hasPaymentDiscountAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:customsTariffNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Code number of the goods in accordance with the tariff nomenclature system of classification in use where the Customs declaration is made.</para>
    /// labels<para>customsTariffNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#customsTariffNumber">https://purl.org/edifact/ontology#customsTariffNumber</seealso>
    let customsTariffNumber =
        Prefixed_Name(edifact_o, "customsTariffNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasPenaltyPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Penalty expressed as a percentage.</para>
    /// labels<para>hasPenaltyPercentage</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasPenaltyPercentage">https://purl.org/edifact/ontology#hasPenaltyPercentage</seealso>
    let hasPenaltyPercentage =
        Prefixed_Name(edifact_o, "hasPenaltyPercentage") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasPhysicalDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specified measurement dimensions refer to physical dimensions of a product, material or package</para>
    /// labels<para>hasPhysicalDimension</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasPhysicalDimension">https://purl.org/edifact/ontology#hasPhysicalDimension</seealso>
    let hasPhysicalDimension =
        Prefixed_Name(edifact_o, "hasPhysicalDimension") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasPriceSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identification of the type of price of an item</para>
    /// labels<para>hasPriceSource</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasPriceSource">https://purl.org/edifact/ontology#hasPriceSource</seealso>
    let hasPriceSource = Prefixed_Name(edifact_o, "hasPriceSource") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:hasPriceUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contains measure unit qualifier of a price</para>
    /// labels<para>hasPriceUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasPriceUnit">https://purl.org/edifact/ontology#hasPriceUnit</seealso>
    let hasPriceUnit = Prefixed_Name(edifact_o, "hasPriceUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasRemittedtAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount which was remitted</para>
    /// labels<para>hasRemittedtAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasRemittedtAmount">https://purl.org/edifact/ontology#hasRemittedtAmount</seealso>
    let hasRemittedtAmount =
        Prefixed_Name(edifact_o, "hasRemittedtAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTaxAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Tax imposed by government or other official authority related to the weight/volume charge or valuation charge</para>
    /// labels<para>hasTaxAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTaxAmount">https://purl.org/edifact/ontology#hasTaxAmount</seealso>
    let hasTaxAmount = Prefixed_Name(edifact_o, "hasTaxAmount") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:hasTaxableAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount for tax calculation</para>
    /// labels<para>hasTaxableAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTaxableAmount">https://purl.org/edifact/ontology#hasTaxableAmount</seealso>
    let hasTaxableAmount = Prefixed_Name(edifact_o, "hasTaxableAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTermsNetDueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date by which payment must be made</para>
    /// labels<para>hasTermsNetDueDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTermsNetDueDate">https://purl.org/edifact/ontology#hasTermsNetDueDate</seealso>
    let hasTermsNetDueDate =
        Prefixed_Name(edifact_o, "hasTermsNetDueDate") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTotalAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The amount specified is the total amount</para>
    /// labels<para>hasTotalAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTotalAmount">https://purl.org/edifact/ontology#hasTotalAmount</seealso>
    let hasTotalAmount = Prefixed_Name(edifact_o, "hasTotalAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTotalAmountUnderPaymentReduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Part of the invoice amount which is subject to payment discount.</para>
    /// labels<para>hasTotalAmountUnderPaymentReduction</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTotalAmountUnderPaymentReduction">https://purl.org/edifact/ontology#hasTotalAmountUnderPaymentReduction</seealso>
    let hasTotalAmountUnderPaymentReduction =
        Prefixed_Name(edifact_o, "hasTotalAmountUnderPaymentReduction") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTotalGoodsPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Net price x quantity for the line item</para>
    /// labels<para>hasTotalGoodsPosition</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTotalGoodsPosition">https://purl.org/edifact/ontology#hasTotalGoodsPosition</seealso>
    let hasTotalGoodsPosition =
        Prefixed_Name(edifact_o, "hasTotalGoodsPosition") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasTransportRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A measurement indicating limitations in relation to transportation equipment.</para>
    /// labels<para>hasTransportRestriction</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasTransportRestriction">https://purl.org/edifact/ontology#hasTransportRestriction</seealso>
    let hasTransportRestriction =
        Prefixed_Name(edifact_o, "hasTransportRestriction") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasUnitPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reporting monetary amount is a 'per unit' amount</para>
    /// labels<para>hasUnitPrice</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasUnitPrice">https://purl.org/edifact/ontology#hasUnitPrice</seealso>
    let hasUnitPrice = Prefixed_Name(edifact_o, "hasUnitPrice") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasVATIdentifierBuyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique number assigned by the relevant tax authority to identify the buyer for use in relation to Value Added Tax (VAT).</para>
    /// labels<para>hasVATIdentifierBuyer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasVATIdentifierBuyer">https://purl.org/edifact/ontology#hasVATIdentifierBuyer</seealso>
    let hasVATIdentifierBuyer =
        Prefixed_Name(edifact_o, "hasVATIdentifierBuyer") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasVATIdentifierDeliveryParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique number assigned by the relevant tax authority to identify the delivery party for use in relation to Value Added Tax (VAT).</para>
    /// labels<para>hasVATIdentifierDeliveryParty</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasVATIdentifierDeliveryParty">https://purl.org/edifact/ontology#hasVATIdentifierDeliveryParty</seealso>
    let hasVATIdentifierDeliveryParty =
        Prefixed_Name(edifact_o, "hasVATIdentifierDeliveryParty") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasVATIdentifierInvoicee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique number assigned by the relevant tax authority to identify the invoicee for use in relation to Value Added Tax (VAT).</para>
    /// labels<para>hasVATIdentifierInvoicee</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasVATIdentifierInvoicee">https://purl.org/edifact/ontology#hasVATIdentifierInvoicee</seealso>
    let hasVATIdentifierInvoicee =
        Prefixed_Name(edifact_o, "hasVATIdentifierInvoicee") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasVATIdentifierSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique number assigned by the relevant tax authority to identify the supplier for use in relation to Value Added Tax (VAT).</para>
    /// labels<para>hasVATIdentifierSupplier</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasVATIdentifierSupplier">https://purl.org/edifact/ontology#hasVATIdentifierSupplier</seealso>
    let hasVATIdentifierSupplier =
        Prefixed_Name(edifact_o, "hasVATIdentifierSupplier") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasVATamount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount in national currency resulting from the application, at the appropriate rate, of value added tax (or similar tax) to the invoice amount subject to such tax</para>
    /// labels<para>hasVATamount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasVATamount">https://purl.org/edifact/ontology#hasVATamount</seealso>
    let hasVATamount = Prefixed_Name(edifact_o, "hasVATamount") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:hasVATfirstValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>First VAT value if, for the same rate of VAT, there are 1 to 3 different ways to set this value</para>
    /// labels<para>hasVATfirstValue</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasVATfirstValue">https://purl.org/edifact/ontology#hasVATfirstValue</seealso>
    let hasVATfirstValue = Prefixed_Name(edifact_o, "hasVATfirstValue") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:hasVATrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A tax on domestic or imported goods applied to the value added at each stage in the production/distribution cycle.</para>
    /// labels<para>hasVATrate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasVATrate">https://purl.org/edifact/ontology#hasVATrate</seealso>
    let hasVATrate = Prefixed_Name(edifact_o, "hasVATrate") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:importLicenseNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by the issuing authority to an Import Licence.</para>
    /// labels<para>importLicenseNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#importLicenseNumber">https://purl.org/edifact/ontology#importLicenseNumber</seealso>
    let importLicenseNumber =
        Prefixed_Name(edifact_o, "importLicenseNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:informationCustomsDeclaration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Note contains customs declaration information.</para>
    /// labels<para>informationCustomsDeclaration</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#informationCustomsDeclaration">https://purl.org/edifact/ontology#informationCustomsDeclaration</seealso>
    let informationCustomsDeclaration =
        Prefixed_Name(edifact_o, "informationCustomsDeclaration") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:internalCustomerNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number assigned by a seller, supplier etc. to identify a customer within his enterprise.</para>
    /// labels<para>internalCustomerNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#internalCustomerNumber">https://purl.org/edifact/ontology#internalCustomerNumber</seealso>
    let internalCustomerNumber =
        Prefixed_Name(edifact_o, "internalCustomerNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:internalVendorNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number identifying the company-internal vending department/unit.</para>
    /// labels<para>internalVendorNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#internalVendorNumber">https://purl.org/edifact/ontology#internalVendorNumber</seealso>
    let internalVendorNumber =
        Prefixed_Name(edifact_o, "internalVendorNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:invoiceCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name or symbol of the monetary unit used for calculation in an invoice.</para>
    /// labels<para>invoiceCurrency</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#invoiceCurrency">https://purl.org/edifact/ontology#invoiceCurrency</seealso>
    let invoiceCurrency = Prefixed_Name(edifact_o, "invoiceCurrency") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:itemNumberBuyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Item number assigned by the buyer to identify an article.</para>
    /// labels<para>itemNumberBuyer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#itemNumberBuyer">https://purl.org/edifact/ontology#itemNumberBuyer</seealso>
    let itemNumberBuyer = Prefixed_Name(edifact_o, "itemNumberBuyer") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:itemNumberManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number given to an article by its manufacturer.</para>
    /// labels<para>itemNumberManufacturer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#itemNumberManufacturer">https://purl.org/edifact/ontology#itemNumberManufacturer</seealso>
    let itemNumberManufacturer =
        Prefixed_Name(edifact_o, "itemNumberManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:itemNumberSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number assigned to an article by the supplier of that article.</para>
    /// labels<para>itemNumberSupplier</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#itemNumberSupplier">https://purl.org/edifact/ontology#itemNumberSupplier</seealso>
    let itemNumberSupplier =
        Prefixed_Name(edifact_o, "itemNumberSupplier") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:loadPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Period a specified charge is valid for.</para>
    /// labels<para>loadPeriod</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#loadPeriod">https://purl.org/edifact/ontology#loadPeriod</seealso>
    let loadPeriod = Prefixed_Name(edifact_o, "loadPeriod") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:managingOrganisations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identification of the managing organization</para>
    /// labels<para>managingOrganisations</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#managingOrganisations">https://purl.org/edifact/ontology#managingOrganisations</seealso>
    let managingOrganisations =
        Prefixed_Name(edifact_o, "managingOrganisations") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:messageReferenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The reference number of the message</para>
    /// labels<para>messageReferenceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#messageReferenceNumber">https://purl.org/edifact/ontology#messageReferenceNumber</seealso>
    let messageReferenceNumber =
        Prefixed_Name(edifact_o, "messageReferenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:messageTypeIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The identifier of the message type</para>
    /// labels<para>messageTypeIdentifier</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#messageTypeIdentifier">https://purl.org/edifact/ontology#messageTypeIdentifier</seealso>
    let messageTypeIdentifier =
        Prefixed_Name(edifact_o, "messageTypeIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:nationalProductGroupCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>National product group code. Administered by a national agency.</para>
    /// labels<para>nationalProductGroupCode</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#nationalProductGroupCode">https://purl.org/edifact/ontology#nationalProductGroupCode</seealso>
    let nationalProductGroupCode =
        Prefixed_Name(edifact_o, "nationalProductGroupCode") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:noDiscountAllowance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>No increases or reduction in price (list or stated) are included.</para>
    /// labels<para>noDiscountAllowance</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#noDiscountAllowance">https://purl.org/edifact/ontology#noDiscountAllowance</seealso>
    let noDiscountAllowance =
        Prefixed_Name(edifact_o, "noDiscountAllowance") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:numberConsolidatedInvoiceEANCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Consolidated invoice number with EAN code</para>
    /// labels<para>numberConsolidatedInvoiceEANCode</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#numberConsolidatedInvoiceEANCode">https://purl.org/edifact/ontology#numberConsolidatedInvoiceEANCode</seealso>
    let numberConsolidatedInvoiceEANCode =
        Prefixed_Name(edifact_o, "numberConsolidatedInvoiceEANCode") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:offerNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by issuing party to an offer.</para>
    /// labels<para>offerNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#offerNumber">https://purl.org/edifact/ontology#offerNumber</seealso>
    let offerNumber = Prefixed_Name(edifact_o, "offerNumber") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:orderCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name or symbol of the monetary unit used in an order.</para>
    /// labels<para>orderCurrency</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#orderCurrency">https://purl.org/edifact/ontology#orderCurrency</seealso>
    let orderCurrency = Prefixed_Name(edifact_o, "orderCurrency") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:orderDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when an order is issued.</para>
    /// labels<para>orderDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#orderDate">https://purl.org/edifact/ontology#orderDate</seealso>
    let orderDate = Prefixed_Name(edifact_o, "orderDate") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:orderNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number of an order.</para>
    /// labels<para>orderNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#orderNumber">https://purl.org/edifact/ontology#orderNumber</seealso>
    let orderNumber = Prefixed_Name(edifact_o, "orderNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:orderNumberDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by issuer to a delivery order.</para>
    /// labels<para>orderNumberDelivery</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#orderNumberDelivery">https://purl.org/edifact/ontology#orderNumberDelivery</seealso>
    let orderNumberDelivery =
        Prefixed_Name(edifact_o, "orderNumberDelivery") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:orderNumberSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by supplier to a buyer's purchase order.</para>
    /// labels<para>orderNumberSupplier</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#orderNumberSupplier">https://purl.org/edifact/ontology#orderNumberSupplier</seealso>
    let orderNumberSupplier =
        Prefixed_Name(edifact_o, "orderNumberSupplier") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:originatorReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference of the originator</para>
    /// labels<para>originatorReference</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#originatorReference">https://purl.org/edifact/ontology#originatorReference</seealso>
    let originatorReference =
        Prefixed_Name(edifact_o, "originatorReference") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:otherServiceInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>General information created by the sender of general or specific value.</para>
    /// labels<para>otherServiceInformation</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#otherServiceInformation">https://purl.org/edifact/ontology#otherServiceInformation</seealso>
    let otherServiceInformation =
        Prefixed_Name(edifact_o, "otherServiceInformation") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:partNumberBuyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by the buyer to identify an article.</para>
    /// labels<para>partNumberBuyer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#partNumberBuyer">https://purl.org/edifact/ontology#partNumberBuyer</seealso>
    let partNumberBuyer = Prefixed_Name(edifact_o, "partNumberBuyer") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:paymentCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of the payment terms</para>
    /// labels<para>paymentCondition</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#paymentCondition">https://purl.org/edifact/ontology#paymentCondition</seealso>
    let paymentCondition = Prefixed_Name(edifact_o, "paymentCondition") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:paymentCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name or symbol of the monetary unit used for payment.</para>
    /// labels<para>paymentCurrency</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#paymentCurrency">https://purl.org/edifact/ontology#paymentCurrency</seealso>
    let paymentCurrency = Prefixed_Name(edifact_o, "paymentCurrency") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:paymentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned to a payment.</para>
    /// labels<para>paymentReference</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#paymentReference">https://purl.org/edifact/ontology#paymentReference</seealso>
    let paymentReference = Prefixed_Name(edifact_o, "paymentReference") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:positionLineNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of the Position of the Line in the whole message</para>
    /// labels<para>positionLineNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#positionLineNumber">https://purl.org/edifact/ontology#positionLineNumber</seealso>
    let positionLineNumber =
        Prefixed_Name(edifact_o, "positionLineNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:priceAndDeliveryCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Price and Delivery Conditions of the article displayed in the invoice</para>
    /// labels<para>priceAndDeliveryCondition</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#priceAndDeliveryCondition">https://purl.org/edifact/ontology#priceAndDeliveryCondition</seealso>
    let priceAndDeliveryCondition =
        Prefixed_Name(edifact_o, "priceAndDeliveryCondition") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:priceCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Condition of the Price</para>
    /// labels<para>priceCondition</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#priceCondition">https://purl.org/edifact/ontology#priceCondition</seealso>
    let priceCondition = Prefixed_Name(edifact_o, "priceCondition") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:priceCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name or symbol of the monetary unit used for pricing purposes</para>
    /// labels<para>priceCurrency</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#priceCurrency">https://purl.org/edifact/ontology#priceCurrency</seealso>
    let priceCurrency = Prefixed_Name(edifact_o, "priceCurrency") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:proformaInvoiceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by the seller to a Proforma Invoice.</para>
    /// labels<para>proformaInvoiceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#proformaInvoiceNumber">https://purl.org/edifact/ontology#proformaInvoiceNumber</seealso>
    let proformaInvoiceNumber =
        Prefixed_Name(edifact_o, "proformaInvoiceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:promotionalVariantNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of the promotional variant number</para>
    /// labels<para>promotionalVariantNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#promotionalVariantNumber">https://purl.org/edifact/ontology#promotionalVariantNumber</seealso>
    let promotionalVariantNumber =
        Prefixed_Name(edifact_o, "promotionalVariantNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:purchasingInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Note contains purchasing information.</para>
    /// labels<para>purchasingInformation</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#purchasingInformation">https://purl.org/edifact/ontology#purchasingInformation</seealso>
    let purchasingInformation =
        Prefixed_Name(edifact_o, "purchasingInformation") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:receivingAdviceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A reference number to a receiving advice.</para>
    /// labels<para>receivingAdviceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#receivingAdviceNumber">https://purl.org/edifact/ontology#receivingAdviceNumber</seealso>
    let receivingAdviceNumber =
        Prefixed_Name(edifact_o, "receivingAdviceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:recipientIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indiactor whos the recipient of the message</para>
    /// labels<para>recipientIndicator</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#recipientIndicator">https://purl.org/edifact/ontology#recipientIndicator</seealso>
    let recipientIndicator =
        Prefixed_Name(edifact_o, "recipientIndicator") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:recivedAndAcceptedQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Quantity which has been received and accepted at a given location.</para>
    /// labels<para>recivedAndAcceptedQuantity</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#recivedAndAcceptedQuantity">https://purl.org/edifact/ontology#recivedAndAcceptedQuantity</seealso>
    let recivedAndAcceptedQuantity =
        Prefixed_Name(edifact_o, "recivedAndAcceptedQuantity") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:recivedAndAcceptedQuantityWithUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Quantity which has been received and accepted at a given location with the unit</para>
    /// labels<para>recivedAndAcceptedQuantityWithUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#recivedAndAcceptedQuantityWithUnit">https://purl.org/edifact/ontology#recivedAndAcceptedQuantityWithUnit</seealso>
    let recivedAndAcceptedQuantityWithUnit =
        Prefixed_Name(edifact_o, "recivedAndAcceptedQuantityWithUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:referenceNumberBusinessContactExtractEANCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number for a business account statement as EAN code</para>
    /// labels<para>referenceNumberBusinessContactExtractEANCode</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#referenceNumberBusinessContactExtractEANCode">https://purl.org/edifact/ontology#referenceNumberBusinessContactExtractEANCode</seealso>
    let referenceNumberBusinessContactExtractEANCode =
        Prefixed_Name(edifact_o, "referenceNumberBusinessContactExtractEANCode") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:referenceNumberCustomer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by the customer to a transaction.</para>
    /// labels<para>referenceNumberCustomer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#referenceNumberCustomer">https://purl.org/edifact/ontology#referenceNumberCustomer</seealso>
    let referenceNumberCustomer =
        Prefixed_Name(edifact_o, "referenceNumberCustomer") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:relatedDocumentNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Related document number</para>
    /// labels<para>relatedDocumentNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#relatedDocumentNumber">https://purl.org/edifact/ontology#relatedDocumentNumber</seealso>
    let relatedDocumentNumber =
        Prefixed_Name(edifact_o, "relatedDocumentNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:contactPersonTelexNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Transmission of text/data via telex.</para>
    /// labels<para>contactPersonTelexNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#contactPersonTelexNumber">https://purl.org/edifact/ontology#contactPersonTelexNumber</seealso>
    let contactPersonTelexNumber =
        Prefixed_Name(edifact_o, "contactPersonTelexNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasInvoiceprice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Referenced price taken from an invoice</para>
    /// labels<para>hasInvoiceprice</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasInvoiceprice">https://purl.org/edifact/ontology#hasInvoiceprice</seealso>
    let hasInvoiceprice = Prefixed_Name(edifact_o, "hasInvoiceprice") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:isItemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>shows to which Invoice the item belongs</para>
    ///   <para>zeigt an zu welcher Rechnung der Artikel gehört</para>
    /// labels<para>isItemOf</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#isItemOf">https://purl.org/edifact/ontology#isItemOf</seealso>
    let isItemOf = Prefixed_Name(edifact_o, "isItemOf") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasLengthMeasurements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Length of pieces or packages stated for transport purposes</para>
    /// labels<para>hasLengthMeasurements</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasLengthMeasurements">https://purl.org/edifact/ontology#hasLengthMeasurements</seealso>
    let hasLengthMeasurements =
        Prefixed_Name(edifact_o, "hasLengthMeasurements") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasLineItemAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Goods item total minus allowances plus charges for line item.</para>
    /// labels<para>hasLineItemAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasLineItemAmount">https://purl.org/edifact/ontology#hasLineItemAmount</seealso>
    let hasLineItemAmount =
        Prefixed_Name(edifact_o, "hasLineItemAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasNetWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Weight (mass) of the goods themselves without any packing</para>
    /// labels<para>hasNetWeight</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasNetWeight">https://purl.org/edifact/ontology#hasNetWeight</seealso>
    let hasNetWeight = Prefixed_Name(edifact_o, "hasNetWeight") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:controlSegmentBetweenItemAndTotalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Detail/summary section separation</para>
    /// labels<para>controlSegmentBetweenItemAndTotalPart</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#controlSegmentBetweenItemAndTotalPart">https://purl.org/edifact/ontology#controlSegmentBetweenItemAndTotalPart</seealso>
    let controlSegmentBetweenItemAndTotalPart =
        Prefixed_Name(edifact_o, "controlSegmentBetweenItemAndTotalPart") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasNetWeightPerUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Weight (mass) of goods including any packing normally going with them to a buyer in a retail sale</para>
    /// labels<para>hasNetWeightPerUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasNetWeightPerUnit">https://purl.org/edifact/ontology#hasNetWeightPerUnit</seealso>
    let hasNetWeightPerUnit =
        Prefixed_Name(edifact_o, "hasNetWeightPerUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasPenaltyAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount of the penalty</para>
    /// labels<para>hasPenaltyAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasPenaltyAmount">https://purl.org/edifact/ontology#hasPenaltyAmount</seealso>
    let hasPenaltyAmount = Prefixed_Name(edifact_o, "hasPenaltyAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasPenaltyPercentagePaymentConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Penalty expressed as a percentage with payment conditions</para>
    /// labels<para>hasPenaltyPercentagePaymentConditions</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasPenaltyPercentagePaymentConditions">https://purl.org/edifact/ontology#hasPenaltyPercentagePaymentConditions</seealso>
    let hasPenaltyPercentagePaymentConditions =
        Prefixed_Name(edifact_o, "hasPenaltyPercentagePaymentConditions") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasPrepaidAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount which has been prepaid in advance</para>
    /// labels<para>hasPrepaidAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasPrepaidAmount">https://purl.org/edifact/ontology#hasPrepaidAmount</seealso>
    let hasPrepaidAmount = Prefixed_Name(edifact_o, "hasPrepaidAmount") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:hasPriceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identification pricing specification</para>
    /// labels<para>hasPriceType</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasPriceType">https://purl.org/edifact/ontology#hasPriceType</seealso>
    let hasPriceType = Prefixed_Name(edifact_o, "hasPriceType") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contains measure unit qualifier</para>
    /// labels<para>hasUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasUnit">https://purl.org/edifact/ontology#hasUnit</seealso>
    let hasUnit = Prefixed_Name(edifact_o, "hasUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasProductIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identification of the product</para>
    /// labels<para>hasProductIdentification</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasProductIdentification">https://purl.org/edifact/ontology#hasProductIdentification</seealso>
    let hasProductIdentification =
        Prefixed_Name(edifact_o, "hasProductIdentification") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasQuantityUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contains measure unit qualifier of a quantity</para>
    /// labels<para>hasQuantityUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasQuantityUnit">https://purl.org/edifact/ontology#hasQuantityUnit</seealso>
    let hasQuantityUnit = Prefixed_Name(edifact_o, "hasQuantityUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasRequiredDeliveryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date on which buyer requests goods to be delivered.</para>
    /// labels<para>hasRequiredDeliveryDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasRequiredDeliveryDate">https://purl.org/edifact/ontology#hasRequiredDeliveryDate</seealso>
    let hasRequiredDeliveryDate =
        Prefixed_Name(edifact_o, "hasRequiredDeliveryDate") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateDespatchAdviceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by issuing party to a despatch advice.</para>
    /// labels<para>dateDespatchAdviceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateDespatchAdviceNumber">https://purl.org/edifact/ontology#dateDespatchAdviceNumber</seealso>
    let dateDespatchAdviceNumber =
        Prefixed_Name(edifact_o, "dateDespatchAdviceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasStockRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A measurement indicating limitation in relation to storage.</para>
    /// labels<para>hasStockRestriction</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasStockRestriction">https://purl.org/edifact/ontology#hasStockRestriction</seealso>
    let hasStockRestriction =
        Prefixed_Name(edifact_o, "hasStockRestriction") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateContractNumberBuyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by buyer to a contract.</para>
    /// labels<para>dateContractNumberBuyer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateContractNumberBuyer">https://purl.org/edifact/ontology#dateContractNumberBuyer</seealso>
    let dateContractNumberBuyer =
        Prefixed_Name(edifact_o, "dateContractNumberBuyer") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasVATIdentifierPayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique number assigned by the relevant tax authority to identify the payer for use in relation to Value Added Tax (VAT).</para>
    /// labels<para>hasVATIdentifierPayer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasVATIdentifierPayer">https://purl.org/edifact/ontology#hasVATIdentifierPayer</seealso>
    let hasVATIdentifierPayer =
        Prefixed_Name(edifact_o, "hasVATIdentifierPayer") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateFiscalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of Tax payer's number.</para>
    /// labels<para>dateFiscalNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateFiscalNumber">https://purl.org/edifact/ontology#dateFiscalNumber</seealso>
    let dateFiscalNumber = Prefixed_Name(edifact_o, "dateFiscalNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateGovernmentReferenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the refernce number given by the goverment</para>
    /// labels<para>dateGovernmentReferenceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateGovernmentReferenceNumber">https://purl.org/edifact/ontology#dateGovernmentReferenceNumber</seealso>
    let dateGovernmentReferenceNumber =
        Prefixed_Name(edifact_o, "dateGovernmentReferenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:internationalArticleNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number assigned to a manufacturer's product according to the International Article Numbering Association.</para>
    /// labels<para>internationalArticleNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#internationalArticleNumber">https://purl.org/edifact/ontology#internationalArticleNumber</seealso>
    let internationalArticleNumber =
        Prefixed_Name(edifact_o, "internationalArticleNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateExportReferenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number given to an export shipment.</para>
    /// labels<para>dateExportReferenceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateExportReferenceNumber">https://purl.org/edifact/ontology#dateExportReferenceNumber</seealso>
    let dateExportReferenceNumber =
        Prefixed_Name(edifact_o, "dateExportReferenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateFinancialAccountNumberPayee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the receiving company account number (ACH transfer), check, draft or wire</para>
    /// labels<para>dateFinancialAccountNumberPayee</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateFinancialAccountNumberPayee">https://purl.org/edifact/ontology#dateFinancialAccountNumberPayee</seealso>
    let dateFinancialAccountNumberPayee =
        Prefixed_Name(edifact_o, "dateFinancialAccountNumberPayee") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateHarmonisedSystemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the number specifying the goods classification under the Harmonised Commodity Description and Coding System of the Customs Co-operation Council (CCC).</para>
    /// labels<para>dateHarmonisedSystemNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateHarmonisedSystemNumber">https://purl.org/edifact/ontology#dateHarmonisedSystemNumber</seealso>
    let dateHarmonisedSystemNumber =
        Prefixed_Name(edifact_o, "dateHarmonisedSystemNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateFileLineIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of number assigned by the file issuer or sender to identify a specific line.</para>
    /// labels<para>dateFileLineIdentifier</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateFileLineIdentifier">https://purl.org/edifact/ontology#dateFileLineIdentifier</seealso>
    let dateFileLineIdentifier =
        Prefixed_Name(edifact_o, "dateFileLineIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:instructionForInvoicingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Note contains invoice instructions</para>
    /// labels<para>instructionForInvoicingParty</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#instructionForInvoicingParty">https://purl.org/edifact/ontology#instructionForInvoicingParty</seealso>
    let instructionForInvoicingParty =
        Prefixed_Name(edifact_o, "instructionForInvoicingParty") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateImportLicenseNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by the issuing authority to an Import Licence.</para>
    /// labels<para>dateImportLicenseNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateImportLicenseNumber">https://purl.org/edifact/ontology#dateImportLicenseNumber</seealso>
    let dateImportLicenseNumber =
        Prefixed_Name(edifact_o, "dateImportLicenseNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateInternalCustomerNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the number assigned by a seller, supplier etc. to identify a customer within his enterprise.</para>
    /// labels<para>dateInternalCustomerNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateInternalCustomerNumber">https://purl.org/edifact/ontology#dateInternalCustomerNumber</seealso>
    let dateInternalCustomerNumber =
        Prefixed_Name(edifact_o, "dateInternalCustomerNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateInternalVendorNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the number identifying the company-internal vending department/unit.</para>
    /// labels<para>dateInternalVendorNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateInternalVendorNumber">https://purl.org/edifact/ontology#dateInternalVendorNumber</seealso>
    let dateInternalVendorNumber =
        Prefixed_Name(edifact_o, "dateInternalVendorNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateInvoiceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by the seller to a Commercial Invoice.</para>
    /// labels<para>dateInvoiceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateInvoiceNumber">https://purl.org/edifact/ontology#dateInvoiceNumber</seealso>
    let dateInvoiceNumber =
        Prefixed_Name(edifact_o, "dateInvoiceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateLineItemReferenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number identifying a particular line in a document.</para>
    /// labels<para>dateLineItemReferenceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateLineItemReferenceNumber">https://purl.org/edifact/ontology#dateLineItemReferenceNumber</seealso>
    let dateLineItemReferenceNumber =
        Prefixed_Name(edifact_o, "dateLineItemReferenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateOfferNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by issuing party to an offer.</para>
    /// labels<para>dateOfferNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateOfferNumber">https://purl.org/edifact/ontology#dateOfferNumber</seealso>
    let dateOfferNumber = Prefixed_Name(edifact_o, "dateOfferNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateOrderNumberBuyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by the buyer to an order.</para>
    /// labels<para>dateOrderNumberBuyer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateOrderNumberBuyer">https://purl.org/edifact/ontology#dateOrderNumberBuyer</seealso>
    let dateOrderNumberBuyer =
        Prefixed_Name(edifact_o, "dateOrderNumberBuyer") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:BrokerSalesOfficeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of a party acting in the name of the seller as broker or as sales office.</para>
    /// labels<para>BrokerSalesOfficeRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#BrokerSalesOfficeRole">https://purl.org/edifact/ontology#BrokerSalesOfficeRole</seealso>
    let BrokerSalesOfficeRole =
        Prefixed_Name(edifact_o, "BrokerSalesOfficeRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:CalculateDeliverToRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party receiving goods and relevant invoice</para>
    /// labels<para>CalculateDeliverToRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#CalculateDeliverToRole">https://purl.org/edifact/ontology#CalculateDeliverToRole</seealso>
    let CalculateDeliverToRole =
        Prefixed_Name(edifact_o, "CalculateDeliverToRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:DespatchPartyRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party where goods are collected or taken over by the carrier (i.e. if other than consignor)</para>
    /// labels<para>DespatchPartyRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#DespatchPartyRole">https://purl.org/edifact/ontology#DespatchPartyRole</seealso>
    let DespatchPartyRole =
        Prefixed_Name(edifact_o, "DespatchPartyRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:FinalConsigneeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party who has been designated on the invoice or packing list as the final recipient of the stated merchandise.</para>
    /// labels<para>FinalConsigneeRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#FinalConsigneeRole">https://purl.org/edifact/ontology#FinalConsigneeRole</seealso>
    let FinalConsigneeRole =
        Prefixed_Name(edifact_o, "FinalConsigneeRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:documentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date/time when a document/message is issued. This may include authentication.</para>
    /// labels<para>documentDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#documentDate">https://purl.org/edifact/ontology#documentDate</seealso>
    let documentDate = Prefixed_Name(edifact_o, "documentDate") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:exchangeRateDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date/time on which the exchange rate was fixed.</para>
    /// labels<para>exchangeRateDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#exchangeRateDate">https://purl.org/edifact/ontology#exchangeRateDate</seealso>
    let exchangeRateDate = Prefixed_Name(edifact_o, "exchangeRateDate") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:fileLineIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number assigned by the file issuer or sender to identify a specific line.</para>
    /// labels<para>fileLineIdentifier</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#fileLineIdentifier">https://purl.org/edifact/ontology#fileLineIdentifier</seealso>
    let fileLineIdentifier =
        Prefixed_Name(edifact_o, "fileLineIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:financialAccountNumberPayee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Receiving company account number (ACH transfer), check, draft or wire</para>
    /// labels<para>financialAccountNumberPayee</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#financialAccountNumberPayee">https://purl.org/edifact/ontology#financialAccountNumberPayee</seealso>
    let financialAccountNumberPayee =
        Prefixed_Name(edifact_o, "financialAccountNumberPayee") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:followsStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>shows the file standard resources the invoice has</para>
    /// labels<para>followsStandard</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#followsStandard">https://purl.org/edifact/ontology#followsStandard</seealso>
    let followsStandard = Prefixed_Name(edifact_o, "followsStandard") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:harmonisedSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contains the number of the harmonised system</para>
    /// labels<para>harmonisedSystem</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#harmonisedSystem">https://purl.org/edifact/ontology#harmonisedSystem</seealso>
    let harmonisedSystem = Prefixed_Name(edifact_o, "harmonisedSystem") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasAllowanceAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount of the allowance</para>
    /// labels<para>hasAllowanceAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasAllowanceAmount">https://purl.org/edifact/ontology#hasAllowanceAmount</seealso>
    let hasAllowanceAmount =
        Prefixed_Name(edifact_o, "hasAllowanceAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contains percentage</para>
    /// labels<para>percentage</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#percentage">https://purl.org/edifact/ontology#percentage</seealso>
    let percentage = Prefixed_Name(edifact_o, "percentage") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasAllowancePercentagePaymentConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Allowance expressed as a percentage with payment condition</para>
    /// labels<para>hasAllowancePercentagePaymentConditions</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasAllowancePercentagePaymentConditions">https://purl.org/edifact/ontology#hasAllowancePercentagePaymentConditions</seealso>
    let hasAllowancePercentagePaymentConditions =
        Prefixed_Name(edifact_o, "hasAllowancePercentagePaymentConditions") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasAmountDueOrPayable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount to be paid</para>
    /// labels<para>hasAmountDueOrPayable</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasAmountDueOrPayable">https://purl.org/edifact/ontology#hasAmountDueOrPayable</seealso>
    let hasAmountDueOrPayable =
        Prefixed_Name(edifact_o, "hasAmountDueOrPayable") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasAmountUnderPriceAdjustment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amount which is used as the basis for price adjustment calculation.</para>
    /// labels<para>hasAmountUnderPriceAdjustment</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasAmountUnderPriceAdjustment">https://purl.org/edifact/ontology#hasAmountUnderPriceAdjustment</seealso>
    let hasAmountUnderPriceAdjustment =
        Prefixed_Name(edifact_o, "hasAmountUnderPriceAdjustment") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasCashDiscount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Cash discount given by the seller to the buyer where payment is made in advance of receipt of goods.</para>
    /// labels<para>hasCashDiscount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasCashDiscount">https://purl.org/edifact/ontology#hasCashDiscount</seealso>
    let hasCashDiscount = Prefixed_Name(edifact_o, "hasCashDiscount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasChargeAllowanceBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The amount specified is the basis for calculation of charges/allowance.</para>
    /// labels<para>hasChargeAllowanceBasis</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasChargeAllowanceBasis">https://purl.org/edifact/ontology#hasChargeAllowanceBasis</seealso>
    let hasChargeAllowanceBasis =
        Prefixed_Name(edifact_o, "hasChargeAllowanceBasis") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasChargeAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The amont of the charge</para>
    /// labels<para>hasChargeAmount</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasChargeAmount">https://purl.org/edifact/ontology#hasChargeAmount</seealso>
    let hasChargeAmount = Prefixed_Name(edifact_o, "hasChargeAmount") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:hasChargePercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Charge expressed as a percentage.</para>
    /// labels<para>hasChargePercentage</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#hasChargePercentage">https://purl.org/edifact/ontology#hasChargePercentage</seealso>
    let hasChargePercentage =
        Prefixed_Name(edifact_o, "hasChargePercentage") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:withoutCalculationQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Quantity of goods which are free of charge.</para>
    /// labels<para>withoutCalculationQuantity</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#withoutCalculationQuantity">https://purl.org/edifact/ontology#withoutCalculationQuantity</seealso>
    let withoutCalculationQuantity =
        Prefixed_Name(edifact_o, "withoutCalculationQuantity") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:withoutCalculationQuantityWithUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Quantity of goods which are free of charge with unit</para>
    /// labels<para>withoutCalculationQuantityWithUnit</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#withoutCalculationQuantityWithUnit">https://purl.org/edifact/ontology#withoutCalculationQuantityWithUnit</seealso>
    let withoutCalculationQuantityWithUnit =
        Prefixed_Name(edifact_o, "withoutCalculationQuantityWithUnit") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateNumberConsolidatedInvoiceEANCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the consolidated invoice number with EAN code</para>
    /// labels<para>dateNumberConsolidatedInvoiceEANCode</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateNumberConsolidatedInvoiceEANCode">https://purl.org/edifact/ontology#dateNumberConsolidatedInvoiceEANCode</seealso>
    let dateNumberConsolidatedInvoiceEANCode =
        Prefixed_Name(edifact_o, "dateNumberConsolidatedInvoiceEANCode") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateNumberOfBundleMessages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of batch number identifying a batch of messages.</para>
    /// labels<para>dateNumberOfBundleMessages</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateNumberOfBundleMessages">https://purl.org/edifact/ontology#dateNumberOfBundleMessages</seealso>
    let dateNumberOfBundleMessages =
        Prefixed_Name(edifact_o, "dateNumberOfBundleMessages") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateOrderNumberDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by issuer to a delivery order.</para>
    /// labels<para>dateOrderNumberDelivery</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateOrderNumberDelivery">https://purl.org/edifact/ontology#dateOrderNumberDelivery</seealso>
    let dateOrderNumberDelivery =
        Prefixed_Name(edifact_o, "dateOrderNumberDelivery") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateOrderNumberSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by supplier to a buyer's purchase order.</para>
    /// labels<para>dateOrderNumberSupplier</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateOrderNumberSupplier">https://purl.org/edifact/ontology#dateOrderNumberSupplier</seealso>
    let dateOrderNumberSupplier =
        Prefixed_Name(edifact_o, "dateOrderNumberSupplier") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateOriginatorReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference of the originator</para>
    /// labels<para>dateOriginatorReference</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateOriginatorReference">https://purl.org/edifact/ontology#dateOriginatorReference</seealso>
    let dateOriginatorReference =
        Prefixed_Name(edifact_o, "dateOriginatorReference") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:datePaymentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned to a payment.</para>
    /// labels<para>datePaymentReference</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#datePaymentReference">https://purl.org/edifact/ontology#datePaymentReference</seealso>
    let datePaymentReference =
        Prefixed_Name(edifact_o, "datePaymentReference") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:datePriceListNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned to a price list.</para>
    /// labels<para>datePriceListNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#datePriceListNumber">https://purl.org/edifact/ontology#datePriceListNumber</seealso>
    let datePriceListNumber =
        Prefixed_Name(edifact_o, "datePriceListNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateProformaInvoiceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by the seller to a Proforma Invoice.</para>
    /// labels<para>dateProformaInvoiceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateProformaInvoiceNumber">https://purl.org/edifact/ontology#dateProformaInvoiceNumber</seealso>
    let dateProformaInvoiceNumber =
        Prefixed_Name(edifact_o, "dateProformaInvoiceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateReferenceNumberBusinessContactExtractEANCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number for a business account statement as EAN code</para>
    /// labels<para>dateReferenceNumberBusinessContactExtractEANCode</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateReferenceNumberBusinessContactExtractEANCode">https://purl.org/edifact/ontology#dateReferenceNumberBusinessContactExtractEANCode</seealso>
    let dateReferenceNumberBusinessContactExtractEANCode =
        Prefixed_Name(edifact_o, "dateReferenceNumberBusinessContactExtractEANCode") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:orderNumberBuyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by the buyer to an order.</para>
    /// labels<para>orderNumberBuyer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#orderNumberBuyer">https://purl.org/edifact/ontology#orderNumberBuyer</seealso>
    let orderNumberBuyer = Prefixed_Name(edifact_o, "orderNumberBuyer") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:lineItemReferenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number identifying a particular line in a document.</para>
    /// labels<para>lineItemReferenceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#lineItemReferenceNumber">https://purl.org/edifact/ontology#lineItemReferenceNumber</seealso>
    let lineItemReferenceNumber =
        Prefixed_Name(edifact_o, "lineItemReferenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateReceivingAdviceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of a reference number to a receiving advice.</para>
    /// labels<para>dateReceivingAdviceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateReceivingAdviceNumber">https://purl.org/edifact/ontology#dateReceivingAdviceNumber</seealso>
    let dateReceivingAdviceNumber =
        Prefixed_Name(edifact_o, "dateReceivingAdviceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateReferenceNumberCustomer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned by the customer to a transaction.</para>
    /// labels<para>dateReferenceNumberCustomer</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateReferenceNumberCustomer">https://purl.org/edifact/ontology#dateReferenceNumberCustomer</seealso>
    let dateReferenceNumberCustomer =
        Prefixed_Name(edifact_o, "dateReferenceNumberCustomer") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:deliveredQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of pieces actually received at the final destination.</para>
    /// labels<para>deliveredQuantity</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#deliveredQuantity">https://purl.org/edifact/ontology#deliveredQuantity</seealso>
    let deliveredQuantity =
        Prefixed_Name(edifact_o, "deliveredQuantity") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:deliveryNoteNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by the issuer to a delivery note.</para>
    /// labels<para>deliveryNoteNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#deliveryNoteNumber">https://purl.org/edifact/ontology#deliveryNoteNumber</seealso>
    let deliveryNoteNumber =
        Prefixed_Name(edifact_o, "deliveryNoteNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:descriptionOfGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Plain language description of the nature of the goods sufficient to identify them at the level required for banking, Customs, statistical or transport purposes, avoiding unnecessary detail (Generic term).</para>
    /// labels<para>descriptionOfGoods</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#descriptionOfGoods">https://purl.org/edifact/ontology#descriptionOfGoods</seealso>
    let descriptionOfGoods =
        Prefixed_Name(edifact_o, "descriptionOfGoods") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:despatchQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Quantity despatched by the seller.</para>
    /// labels<para>despatchQuantity</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#despatchQuantity">https://purl.org/edifact/ontology#despatchQuantity</seealso>
    let despatchQuantity = Prefixed_Name(edifact_o, "despatchQuantity") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:discountTerminationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date/time when the deduction from an amount comes to an end.</para>
    /// labels<para>discountTerminationDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#discountTerminationDate">https://purl.org/edifact/ontology#discountTerminationDate</seealso>
    let discountTerminationDate =
        Prefixed_Name(edifact_o, "discountTerminationDate") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#">https://purl.org/edifact/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(edifact_o, "") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateRelatedDocumentNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the realted document number</para>
    /// labels<para>dateRelatedDocumentNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateRelatedDocumentNumber">https://purl.org/edifact/ontology#dateRelatedDocumentNumber</seealso>
    let dateRelatedDocumentNumber =
        Prefixed_Name(edifact_o, "dateRelatedDocumentNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateSellersReferenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the reference number assigned to a transaction by the seller</para>
    /// labels<para>dateSellersReferenceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateSellersReferenceNumber">https://purl.org/edifact/ontology#dateSellersReferenceNumber</seealso>
    let dateSellersReferenceNumber =
        Prefixed_Name(edifact_o, "dateSellersReferenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:BuyerRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The role of the party to which articles are sold</para>
    /// labels<para>BuyerRole</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#BuyerRole">https://purl.org/edifact/ontology#BuyerRole</seealso>
    let BuyerRole = Prefixed_Name(edifact_o, "BuyerRole") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:deliveryCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the conditions under which the goods must be delivered to the consignee</para>
    /// labels<para>deliveryCondition</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#deliveryCondition">https://purl.org/edifact/ontology#deliveryCondition</seealso>
    let deliveryCondition =
        Prefixed_Name(edifact_o, "deliveryCondition") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:despatchAdviceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by issuing party to a despatch advice.</para>
    /// labels<para>despatchAdviceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#despatchAdviceNumber">https://purl.org/edifact/ontology#despatchAdviceNumber</seealso>
    let despatchAdviceNumber =
        Prefixed_Name(edifact_o, "despatchAdviceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:discreteQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The discrete quantity</para>
    /// labels<para>discreteQuantity</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#discreteQuantity">https://purl.org/edifact/ontology#discreteQuantity</seealso>
    let discreteQuantity = Prefixed_Name(edifact_o, "discreteQuantity") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:effectiveDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date and/or time at which specified event or document becomes effective.</para>
    /// labels<para>effectiveDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#effectiveDate">https://purl.org/edifact/ontology#effectiveDate</seealso>
    let effectiveDate = Prefixed_Name(edifact_o, "effectiveDate") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:priceListNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned to a price list.</para>
    /// labels<para>priceListNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#priceListNumber">https://purl.org/edifact/ontology#priceListNumber</seealso>
    let priceListNumber = Prefixed_Name(edifact_o, "priceListNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:dateSpecificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the number assigned by the issuer to his specification.</para>
    /// labels<para>dateSpecificationNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#dateSpecificationNumber">https://purl.org/edifact/ontology#dateSpecificationNumber</seealso>
    let dateSpecificationNumber =
        Prefixed_Name(edifact_o, "dateSpecificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:debitNoteNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number assigned by issuer to a debit note</para>
    /// labels<para>debitNoteNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#debitNoteNumber">https://purl.org/edifact/ontology#debitNoteNumber</seealso>
    let debitNoteNumber = Prefixed_Name(edifact_o, "debitNoteNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:exportReferenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference number given to an export shipment.</para>
    /// labels<para>exportReferenceNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#exportReferenceNumber">https://purl.org/edifact/ontology#exportReferenceNumber</seealso>
    let exportReferenceNumber =
        Prefixed_Name(edifact_o, "exportReferenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>edifact-o:fiscalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Tax payer's number. Number assigned to individual persons as well as to corporates by a public institution; this number is different from the VAT registration number.</para>
    /// labels<para>fiscalNumber</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#fiscalNumber">https://purl.org/edifact/ontology#fiscalNumber</seealso>
    let fiscalNumber = Prefixed_Name(edifact_o, "fiscalNumber") |> PrefixedName
    /// <summary>
    ///   <para>edifact-o:receiptGoodsDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date/time upon which the goods were received by a given party.</para>
    /// labels<para>receiptGoodsDate</para></remarks>
    /// <seealso href="https://purl.org/edifact/ontology#receiptGoodsDate">https://purl.org/edifact/ontology#receiptGoodsDate</seealso>
    let receiptGoodsDate = Prefixed_Name(edifact_o, "receiptGoodsDate") |> PrefixedName
