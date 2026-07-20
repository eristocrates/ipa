namespace http.reference.data.gov.uk.def.payment.hash

open DoxAletheia

module payment =
    let _namespace_name = "http://reference.data.gov.uk/def/payment#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The set of expenditure categories in the expenditure-category scheme for capital/revenue.
    /// <see href="http://reference.data.gov.uk/def/payment#ExpenditureCategory"></see></summary>
    let ExpenditureCategory = _prefix "ExpenditureCategory"
    /// <summary>
    /// An item of expenditure that can be classified or assigned to a cost centre
    /// <see href="http://reference.data.gov.uk/def/payment#ExpenditureLine"></see></summary>
    let ExpenditureLine = _prefix "ExpenditureLine"
    /// <summary>
    /// A payment to a supplier for some goods or services, may correspond to one or more expenditure lines
    /// <see href="http://reference.data.gov.uk/def/payment#Payment"></see></summary>
    let Payment = _prefix "Payment"
    /// <summary>
    /// The entity which made the payment.
    /// <see href="http://reference.data.gov.uk/def/payment#payer"></see></summary>
    let payer = _prefix "payer"
    /// <summary>
    /// The date the payment is deemed to have occurred.
    /// <see href="http://reference.data.gov.uk/def/payment#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// The entity to which the payment was made.
    /// <see href="http://reference.data.gov.uk/def/payment#payee"></see></summary>
    let payee = _prefix "payee"
    /// <summary>
    /// A set of payments or expenditures, laid out as a cube of data
    /// <see href="http://reference.data.gov.uk/def/payment#PaymentDataset"></see></summary>
    let PaymentDataset = _prefix "PaymentDataset"
    /// <summary>
    /// The overall goods or service for which the payment was made
    /// <see href="http://reference.data.gov.uk/def/payment#Purchase"></see></summary>
    let Purchase = _prefix "Purchase"
    /// <summary>
    /// An instance of Redaction can be used in place of the actual value
    /// in a dataset to indicate that this is a replacement for the true data value which has
    /// been redacted. Typically the Redaction resource will be a blank note. It is recommended
    /// that it have an appropriate rdfs:label (e.g. REDACTED). If further information on the
    /// reaction is available then dcterms properties should be used to carry those, in partcular
    /// dct:description can be used to convey a description of the redaction and reasons
    /// <see href="http://reference.data.gov.uk/def/payment#Redaction"></see></summary>
    let Redaction = _prefix "Redaction"
    /// <summary>
    /// Indicates a capital expenditure.
    /// <see href="http://reference.data.gov.uk/def/payment#capital"></see></summary>
    let capital = _prefix "capital"
    /// <summary>
    /// A code scheme for classifying expenditures as capital/revenue.
    /// <see href="http://reference.data.gov.uk/def/payment#expenditure-category"></see></summary>
    let ``expenditure-category`` = _prefix "expenditure-category"
    /// <summary>
    /// Indicates a contract associated with this payment (optional).
    /// <see href="http://reference.data.gov.uk/def/payment#contract"></see></summary>
    let contract = _prefix "contract"
    /// <summary>
    /// Currency in which a payment was made, typically attached to the dataset for single currency datasets.
    /// <see href="http://reference.data.gov.uk/def/payment#currency"></see></summary>
    let currency = _prefix "currency"
    /// <summary>
    /// Indicates a revenue expenditure.
    /// <see href="http://reference.data.gov.uk/def/payment#revenue"></see></summary>
    let revenue = _prefix "revenue"
    /// <summary>
    /// The category of expenditure in some appropriate categorization scheme (such as the Best Value Account Code of Practice categories). If the scheme is hierarchical then this should at least designate the narrowest (most fine grain) applicable code and can additionally designate the broader codes. Multiple code schemes can be used within the same dataset and consuming applications can use the skos:inScheme (and the rdf:type) of the code to determine the scheme.
    /// <see href="http://reference.data.gov.uk/def/payment#expenditureCategory"></see></summary>
    let expenditureCategory = _prefix "expenditureCategory"
    /// <summary>
    /// An (optional) internal code for the expenditure category. Such codes may not be useful across organizations but retaining them in a dataset may aid comparability of datasets within an organization and help with tracing back requests for further information. The internal code may actually be an amalgam of multiple different categories (e.g. may denote both the subjective and objective classifications of an expenditure).
    /// <see href="http://reference.data.gov.uk/def/payment#expenditureCode"></see></summary>
    let expenditureCode = _prefix "expenditureCode"
    /// <summary>
    /// Links a payment to the individual expenditure lines associated with it.
    /// <see href="http://reference.data.gov.uk/def/payment#expenditureLine"></see></summary>
    let expenditureLine = _prefix "expenditureLine"
    /// <summary>
    /// The amount paid, inclusive of any tax (whether reclaimable or not)
    /// <see href="http://reference.data.gov.uk/def/payment#grossAmount"></see></summary>
    let grossAmount = _prefix "grossAmount"
    /// <summary>
    /// Indicates an invoice associated with this payment (optional).
    /// <see href="http://reference.data.gov.uk/def/payment#invoice"></see></summary>
    let invoice = _prefix "invoice"
    /// <summary>
    /// A narrative description of the goods or services that were supplied.
    /// <see href="http://reference.data.gov.uk/def/payment#narrative"></see></summary>
    let narrative = _prefix "narrative"
    /// <summary>
    /// The net amount of the payment. This is the effective cost to the payer after any reclaimable tax has been deducted.
    /// <see href="http://reference.data.gov.uk/def/payment#netAmount"></see></summary>
    let netAmount = _prefix "netAmount"
    /// <summary>
    /// Indicates an order associated with this payment (optional).
    /// <see href="http://reference.data.gov.uk/def/payment#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// Indicates the payment of which this expenditure line is a part.
    /// <see href="http://reference.data.gov.uk/def/payment#payment"></see></summary>
    let payment = _prefix "payment"
    /// <summary>
    /// The definition of a slice through an expenditure cube that corresponds to all the expenditures in a single payment.
    /// <see href="http://reference.data.gov.uk/def/payment#payment-slice"></see></summary>
    let ``payment-slice`` = _prefix "payment-slice"

    /// <summary>
    /// The structure of a cube containing expenditure level information along with payments.
    /// <see href="http://reference.data.gov.uk/def/payment#payments-with-expenditure-structure"></see></summary>
    let ``payments-with-expenditure-structure`` =
        _prefix "payments-with-expenditure-structure"

    /// <summary>
    /// A classification for the goods or services for which the payment was made.
    /// <see href="http://reference.data.gov.uk/def/payment#procurementCategory"></see></summary>
    let procurementCategory = _prefix "procurementCategory"
    /// <summary>
    /// Indicates the overall goods or service for which the payment was made.
    /// <see href="http://reference.data.gov.uk/def/payment#purchase"></see></summary>
    let purchase = _prefix "purchase"
    /// <summary>
    /// A reference number, code or label which identifies the payment. Not unique across different suppliers.
    /// <see href="http://reference.data.gov.uk/def/payment#reference"></see></summary>
    let reference = _prefix "reference"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/payment#totalGrossAmount"></see>
    /// </summary>
    let totalGrossAmount = _prefix "totalGrossAmount"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/payment#totalNetAmount"></see>
    /// </summary>
    let totalNetAmount = _prefix "totalNetAmount"
    /// <summary>
    /// Optionally indicates a particular organizational
    /// unit (Department, Directorate etc) of the payer organization associated with the payment.
    /// Use org:classification to link the unit to a categorization of types of units to
    /// support cross-comparison. For example, in the UK Local Authority spend application
    /// then the ESDToolkit-maintained list of Department Types may be a suitable code list.
    /// <see href="http://reference.data.gov.uk/def/payment#unit"></see></summary>
    let unit = _prefix "unit"
