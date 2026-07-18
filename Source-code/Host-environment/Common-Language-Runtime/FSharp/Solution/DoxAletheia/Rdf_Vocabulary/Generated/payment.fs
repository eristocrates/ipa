namespace http.reference.data.gov.uk.def.payment.hash

open DoxAletheia.Rdf_Vocabulary

module payment =
    let _namespace_name = "http://reference.data.gov.uk/def/payment#"

    /// <summary>
    /// The set of expenditure categories in the expenditure-category scheme for capital/revenue.
    /// <see href="http://reference.data.gov.uk/def/payment#ExpenditureCategory"></see></summary>
    let ExpenditureCategory =
        Namespaced_IRI.parse _namespace_name "ExpenditureCategory" |> NamespacedName

    /// <summary>
    /// An item of expenditure that can be classified or assigned to a cost centre
    /// <see href="http://reference.data.gov.uk/def/payment#ExpenditureLine"></see></summary>
    let ExpenditureLine =
        Namespaced_IRI.parse _namespace_name "ExpenditureLine" |> NamespacedName

    /// <summary>
    /// A payment to a supplier for some goods or services, may correspond to one or more expenditure lines
    /// <see href="http://reference.data.gov.uk/def/payment#Payment"></see></summary>
    let Payment = Namespaced_IRI.parse _namespace_name "Payment" |> NamespacedName
    /// <summary>
    /// The entity which made the payment.
    /// <see href="http://reference.data.gov.uk/def/payment#payer"></see></summary>
    let payer = Namespaced_IRI.parse _namespace_name "payer" |> NamespacedName
    /// <summary>
    /// The date the payment is deemed to have occurred.
    /// <see href="http://reference.data.gov.uk/def/payment#date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    /// The entity to which the payment was made.
    /// <see href="http://reference.data.gov.uk/def/payment#payee"></see></summary>
    let payee = Namespaced_IRI.parse _namespace_name "payee" |> NamespacedName

    /// <summary>
    /// A set of payments or expenditures, laid out as a cube of data
    /// <see href="http://reference.data.gov.uk/def/payment#PaymentDataset"></see></summary>
    let PaymentDataset =
        Namespaced_IRI.parse _namespace_name "PaymentDataset" |> NamespacedName

    /// <summary>
    /// The overall goods or service for which the payment was made
    /// <see href="http://reference.data.gov.uk/def/payment#Purchase"></see></summary>
    let Purchase = Namespaced_IRI.parse _namespace_name "Purchase" |> NamespacedName
    /// <summary>
    /// An instance of Redaction can be used in place of the actual value
    /// in a dataset to indicate that this is a replacement for the true data value which has
    /// been redacted. Typically the Redaction resource will be a blank note. It is recommended
    /// that it have an appropriate rdfs:label (e.g. REDACTED). If further information on the
    /// reaction is available then dcterms properties should be used to carry those, in partcular
    /// dct:description can be used to convey a description of the redaction and reasons
    /// <see href="http://reference.data.gov.uk/def/payment#Redaction"></see></summary>
    let Redaction = Namespaced_IRI.parse _namespace_name "Redaction" |> NamespacedName
    /// <summary>
    /// Indicates a capital expenditure.
    /// <see href="http://reference.data.gov.uk/def/payment#capital"></see></summary>
    let capital = Namespaced_IRI.parse _namespace_name "capital" |> NamespacedName

    /// <summary>
    /// A code scheme for classifying expenditures as capital/revenue.
    /// <see href="http://reference.data.gov.uk/def/payment#expenditure-category"></see></summary>
    let ``expenditure-category`` =
        Namespaced_IRI.parse _namespace_name "expenditure-category" |> NamespacedName

    /// <summary>
    /// Indicates a contract associated with this payment (optional).
    /// <see href="http://reference.data.gov.uk/def/payment#contract"></see></summary>
    let contract = Namespaced_IRI.parse _namespace_name "contract" |> NamespacedName
    /// <summary>
    /// Currency in which a payment was made, typically attached to the dataset for single currency datasets.
    /// <see href="http://reference.data.gov.uk/def/payment#currency"></see></summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName
    /// <summary>
    /// Indicates a revenue expenditure.
    /// <see href="http://reference.data.gov.uk/def/payment#revenue"></see></summary>
    let revenue = Namespaced_IRI.parse _namespace_name "revenue" |> NamespacedName

    /// <summary>
    /// The category of expenditure in some appropriate categorization scheme (such as the Best Value Account Code of Practice categories). If the scheme is hierarchical then this should at least designate the narrowest (most fine grain) applicable code and can additionally designate the broader codes. Multiple code schemes can be used within the same dataset and consuming applications can use the skos:inScheme (and the rdf:type) of the code to determine the scheme.
    /// <see href="http://reference.data.gov.uk/def/payment#expenditureCategory"></see></summary>
    let expenditureCategory =
        Namespaced_IRI.parse _namespace_name "expenditureCategory" |> NamespacedName

    /// <summary>
    /// An (optional) internal code for the expenditure category. Such codes may not be useful across organizations but retaining them in a dataset may aid comparability of datasets within an organization and help with tracing back requests for further information. The internal code may actually be an amalgam of multiple different categories (e.g. may denote both the subjective and objective classifications of an expenditure).
    /// <see href="http://reference.data.gov.uk/def/payment#expenditureCode"></see></summary>
    let expenditureCode =
        Namespaced_IRI.parse _namespace_name "expenditureCode" |> NamespacedName

    /// <summary>
    /// Links a payment to the individual expenditure lines associated with it.
    /// <see href="http://reference.data.gov.uk/def/payment#expenditureLine"></see></summary>
    let expenditureLine =
        Namespaced_IRI.parse _namespace_name "expenditureLine" |> NamespacedName

    /// <summary>
    /// The amount paid, inclusive of any tax (whether reclaimable or not)
    /// <see href="http://reference.data.gov.uk/def/payment#grossAmount"></see></summary>
    let grossAmount =
        Namespaced_IRI.parse _namespace_name "grossAmount" |> NamespacedName

    /// <summary>
    /// Indicates an invoice associated with this payment (optional).
    /// <see href="http://reference.data.gov.uk/def/payment#invoice"></see></summary>
    let invoice = Namespaced_IRI.parse _namespace_name "invoice" |> NamespacedName
    /// <summary>
    /// A narrative description of the goods or services that were supplied.
    /// <see href="http://reference.data.gov.uk/def/payment#narrative"></see></summary>
    let narrative = Namespaced_IRI.parse _namespace_name "narrative" |> NamespacedName
    /// <summary>
    /// The net amount of the payment. This is the effective cost to the payer after any reclaimable tax has been deducted.
    /// <see href="http://reference.data.gov.uk/def/payment#netAmount"></see></summary>
    let netAmount = Namespaced_IRI.parse _namespace_name "netAmount" |> NamespacedName
    /// <summary>
    /// Indicates an order associated with this payment (optional).
    /// <see href="http://reference.data.gov.uk/def/payment#order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName
    /// <summary>
    /// Indicates the payment of which this expenditure line is a part.
    /// <see href="http://reference.data.gov.uk/def/payment#payment"></see></summary>
    let payment = Namespaced_IRI.parse _namespace_name "payment" |> NamespacedName

    /// <summary>
    /// The definition of a slice through an expenditure cube that corresponds to all the expenditures in a single payment.
    /// <see href="http://reference.data.gov.uk/def/payment#payment-slice"></see></summary>
    let ``payment-slice`` =
        Namespaced_IRI.parse _namespace_name "payment-slice" |> NamespacedName

    /// <summary>
    /// The structure of a cube containing expenditure level information along with payments.
    /// <see href="http://reference.data.gov.uk/def/payment#payments-with-expenditure-structure"></see></summary>
    let ``payments-with-expenditure-structure`` =
        Namespaced_IRI.parse _namespace_name "payments-with-expenditure-structure" |> NamespacedName

    /// <summary>
    /// A classification for the goods or services for which the payment was made.
    /// <see href="http://reference.data.gov.uk/def/payment#procurementCategory"></see></summary>
    let procurementCategory =
        Namespaced_IRI.parse _namespace_name "procurementCategory" |> NamespacedName

    /// <summary>
    /// Indicates the overall goods or service for which the payment was made.
    /// <see href="http://reference.data.gov.uk/def/payment#purchase"></see></summary>
    let purchase = Namespaced_IRI.parse _namespace_name "purchase" |> NamespacedName
    /// <summary>
    /// A reference number, code or label which identifies the payment. Not unique across different suppliers.
    /// <see href="http://reference.data.gov.uk/def/payment#reference"></see></summary>
    let reference = Namespaced_IRI.parse _namespace_name "reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/payment#totalGrossAmount"></see>
    /// </summary>
    let totalGrossAmount =
        Namespaced_IRI.parse _namespace_name "totalGrossAmount" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/payment#totalNetAmount"></see>
    /// </summary>
    let totalNetAmount =
        Namespaced_IRI.parse _namespace_name "totalNetAmount" |> NamespacedName

    /// <summary>
    /// Optionally indicates a particular organizational
    /// unit (Department, Directorate etc) of the payer organization associated with the payment.
    /// Use org:classification to link the unit to a categorization of types of units to
    /// support cross-comparison. For example, in the UK Local Authority spend application
    /// then the ESDToolkit-maintained list of Department Types may be a suitable code list.
    /// <see href="http://reference.data.gov.uk/def/payment#unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName
