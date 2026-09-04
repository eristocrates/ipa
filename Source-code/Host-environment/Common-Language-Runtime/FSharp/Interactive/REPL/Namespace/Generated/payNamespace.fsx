#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pay =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://reference.data.gov.uk/def/payment#" "pay"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Expenditure categories</para>
    ///   <para>rdfs:comment : The set of expenditure categories in the expenditure-category scheme for capital/revenue.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#ExpenditureCategory">pay:ExpenditureCategory</a>
    /// </summary>
    let ExpenditureCategory = _prefixId.prefix "ExpenditureCategory"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Expenditure Line</para>
    ///   <para>rdfs:comment : An item of expenditure that can be classified or assigned to a cost centre</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#ExpenditureLine">pay:ExpenditureLine</a>
    /// </summary>
    let ExpenditureLine = _prefixId.prefix "ExpenditureLine"
    /// <summary>
    ///   <para>rdfs:comment : A payment to a supplier for some goods or services, may correspond to one or more expenditure lines</para>
    ///   <para>rdfs:label : Payment</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#Payment">pay:Payment</a>
    /// </summary>
    let Payment = _prefixId.prefix "Payment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Payment data set</para>
    ///   <para>rdfs:comment : A set of payments or expenditures, laid out as a cube of data</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#PaymentDataset">pay:PaymentDataset</a>
    /// </summary>
    let PaymentDataset = _prefixId.prefix "PaymentDataset"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Purchase</para>
    ///   <para>rdfs:comment : The overall goods or service for which the payment was made</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#Purchase">pay:Purchase</a>
    /// </summary>
    let Purchase = _prefixId.prefix "Purchase"
    /// <summary>
    ///   <para>vs:term_status : proposed^^xsd:string</para>
    ///   <para>rdfs:label : Redaction</para>
    ///   <para>rdfs:comment : An instance of Redaction can be used in place of the actual value
    /// in a dataset to indicate that this is a replacement for the true data value which has
    /// been redacted. Typically the Redaction resource will be a blank note. It is recommended
    /// that it have an appropriate rdfs:label (e.g. REDACTED). If further information on the
    /// reaction is available then dcterms properties should be used to carry those, in partcular
    /// dct:description can be used to convey a description of the redaction and reasons</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#Redaction">pay:Redaction</a>
    /// </summary>
    let Redaction = _prefixId.prefix "Redaction"
    let capital = _prefixId.prefix "capital"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contract</para>
    ///   <para>rdfs:comment : Indicates a contract associated with this payment (optional).</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#contract">pay:contract</a>
    /// </summary>
    let contract = _prefixId.prefix "contract"
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : date</para>
    ///   <para>rdfs:comment : The date the payment is deemed to have occurred.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#date">pay:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    let expenditure_category = _prefixId.prefix "expenditure-category"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : expenditure category</para>
    ///   <para>rdfs:comment : The category of expenditure in some appropriate categorization scheme (such as the Best Value Account Code of Practice categories). If the scheme is hierarchical then this should at least designate the narrowest (most fine grain) applicable code and can additionally designate the broader codes. Multiple code schemes can be used within the same dataset and consuming applications can use the skos:inScheme (and the rdf:type) of the code to determine the scheme.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#expenditureCategory">pay:expenditureCategory</a>
    /// </summary>
    let expenditureCategory = _prefixId.prefix "expenditureCategory"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : expenditure code</para>
    ///   <para>rdfs:comment : An (optional) internal code for the expenditure category. Such codes may not be useful across organizations but retaining them in a dataset may aid comparability of datasets within an organization and help with tracing back requests for further information. The internal code may actually be an amalgam of multiple different categories (e.g. may denote both the subjective and objective classifications of an expenditure).</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#expenditureCode">pay:expenditureCode</a>
    /// </summary>
    let expenditureCode = _prefixId.prefix "expenditureCode"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : expenditure line</para>
    ///   <para>rdfs:comment : Links a payment to the individual expenditure lines associated with it.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#expenditureLine">pay:expenditureLine</a>
    /// </summary>
    let expenditureLine = _prefixId.prefix "expenditureLine"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : gross amount</para>
    ///   <para>rdfs:comment : The amount paid, inclusive of any tax (whether reclaimable or not)</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#grossAmount">pay:grossAmount</a>
    /// </summary>
    let grossAmount = _prefixId.prefix "grossAmount"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : invoice</para>
    ///   <para>rdfs:comment : Indicates an invoice associated with this payment (optional).</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#invoice">pay:invoice</a>
    /// </summary>
    let invoice = _prefixId.prefix "invoice"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : narrative</para>
    ///   <para>rdfs:comment : A narrative description of the goods or services that were supplied.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#narrative">pay:narrative</a>
    /// </summary>
    let narrative = _prefixId.prefix "narrative"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : net amount</para>
    ///   <para>rdfs:comment : The net amount of the payment. This is the effective cost to the payer after any reclaimable tax has been deducted.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#netAmount">pay:netAmount</a>
    /// </summary>
    let netAmount = _prefixId.prefix "netAmount"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : order</para>
    ///   <para>rdfs:comment : Indicates an order associated with this payment (optional).</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#order">pay:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : payee</para>
    ///   <para>rdfs:comment : The entity to which the payment was made.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#payee">pay:payee</a>
    /// </summary>
    let payee = _prefixId.prefix "payee"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : payer</para>
    ///   <para>rdfs:comment : The entity which made the payment.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#payer">pay:payer</a>
    /// </summary>
    let payer = _prefixId.prefix "payer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : payment</para>
    ///   <para>rdfs:comment : Indicates the payment of which this expenditure line is a part.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#payment">pay:payment</a>
    /// </summary>
    let payment = _prefixId.prefix "payment"
    let payment_slice = _prefixId.prefix "payment-slice"

    let payments_with_expenditure_structure =
        _prefixId.prefix "payments-with-expenditure-structure"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : procurement category</para>
    ///   <para>rdfs:comment : A classification for the goods or services for which the payment was made.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#procurementCategory">pay:procurementCategory</a>
    /// </summary>
    let procurementCategory = _prefixId.prefix "procurementCategory"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : purchase</para>
    ///   <para>rdfs:comment : Indicates the overall goods or service for which the payment was made.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#purchase">pay:purchase</a>
    /// </summary>
    let purchase = _prefixId.prefix "purchase"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : reference</para>
    ///   <para>rdfs:comment : A reference number, code or label which identifies the payment. Not unique across different suppliers.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#reference">pay:reference</a>
    /// </summary>
    let reference = _prefixId.prefix "reference"
    let revenue = _prefixId.prefix "revenue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : total gross amount</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#totalGrossAmount">pay:totalGrossAmount</a>
    /// </summary>
    let totalGrossAmount = _prefixId.prefix "totalGrossAmount"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : total net amount</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#totalNetAmount">pay:totalNetAmount</a>
    /// </summary>
    let totalNetAmount = _prefixId.prefix "totalNetAmount"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : unit</para>
    ///   <para>rdfs:comment : Optionally indicates a particular organizational
    /// unit (Department, Directorate etc) of the payer organization associated with the payment.
    /// Use org:classification to link the unit to a categorization of types of units to
    /// support cross-comparison. For example, in the UK Local Authority spend application
    /// then the ESDToolkit-maintained list of Department Types may be a suitable code list.</para>
    ///   <a href="http://reference.data.gov.uk/def/payment#unit">pay:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
