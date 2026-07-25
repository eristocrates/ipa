namespace http.reference.data.gov.uk.def.payment.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module payment =
    let _namespace_iri = Namespace_Iri payment |> NamespaceIRI
    /// <summary>
    ///   <para>payment:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Vocabulary for representing payments, such as government expenditures, using the data cube representation.</para>
    /// labels<para>Payments ontology</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#">http://reference.data.gov.uk/def/payment#</seealso>
    let _prefix_iri = Prefixed_Name(payment, "") |> PrefixedName
    /// <summary>
    ///   <para>payment:ExpenditureLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An item of expenditure that can be classified or assigned to a cost centre</para>
    /// labels<para>Expenditure Line</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#ExpenditureLine">http://reference.data.gov.uk/def/payment#ExpenditureLine</seealso>
    let ExpenditureLine = Prefixed_Name(payment, "ExpenditureLine") |> PrefixedName
    /// <summary>
    ///   <para>payment:Redaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of Redaction can be used in place of the actual value
    /// in a dataset to indicate that this is a replacement for the true data value which has
    /// been redacted. Typically the Redaction resource will be a blank note. It is recommended
    /// that it have an appropriate rdfs:label (e.g. REDACTED). If further information on the
    /// reaction is available then dcterms properties should be used to carry those, in partcular
    /// dct:description can be used to convey a description of the redaction and reasons</para>
    /// labels<para>Redaction</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#Redaction">http://reference.data.gov.uk/def/payment#Redaction</seealso>
    let Redaction = Prefixed_Name(payment, "Redaction") |> PrefixedName
    /// <summary>
    ///   <para>payment:contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a contract associated with this payment (optional).</para>
    /// labels<para>contract</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#contract">http://reference.data.gov.uk/def/payment#contract</seealso>
    let contract = Prefixed_Name(payment, "contract") |> PrefixedName
    /// <summary>
    ///   <para>payment:revenue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>payment:ExpenditureCategory</para>
    ///   <para>skos:Concept</para>
    ///   <para>Indicates a revenue expenditure.</para>
    /// labels<para>Revenue</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#revenue">http://reference.data.gov.uk/def/payment#revenue</seealso>
    let revenue = Prefixed_Name(payment, "revenue") |> PrefixedName

    /// <summary>
    ///   <para>payment:expenditureCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The category of expenditure in some appropriate categorization scheme (such as the Best Value Account Code of Practice categories). If the scheme is hierarchical then this should at least designate the narrowest (most fine grain) applicable code and can additionally designate the broader codes. Multiple code schemes can be used within the same dataset and consuming applications can use the skos:inScheme (and the rdf:type) of the code to determine the scheme.</para>
    /// labels<para>expenditure category</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#expenditureCategory">http://reference.data.gov.uk/def/payment#expenditureCategory</seealso>
    let expenditureCategory =
        Prefixed_Name(payment, "expenditureCategory") |> PrefixedName

    /// <summary>
    ///   <para>payment:expenditureLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links a payment to the individual expenditure lines associated with it.</para>
    /// labels<para>expenditure line</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#expenditureLine">http://reference.data.gov.uk/def/payment#expenditureLine</seealso>
    let expenditureLine = Prefixed_Name(payment, "expenditureLine") |> PrefixedName
    /// <summary>
    ///   <para>payment:totalNetAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>total net amount</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#totalNetAmount">http://reference.data.gov.uk/def/payment#totalNetAmount</seealso>
    let totalNetAmount = Prefixed_Name(payment, "totalNetAmount") |> PrefixedName
    /// <summary>
    ///   <para>payment:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Optionally indicates a particular organizational
    /// unit (Department, Directorate etc) of the payer organization associated with the payment.
    /// Use org:classification to link the unit to a categorization of types of units to
    /// support cross-comparison. For example, in the UK Local Authority spend application
    /// then the ESDToolkit-maintained list of Department Types may be a suitable code list.</para>
    /// labels<para>unit</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#unit">http://reference.data.gov.uk/def/payment#unit</seealso>
    let unit = Prefixed_Name(payment, "unit") |> PrefixedName
    /// <summary>
    ///   <para>payment:payer</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The entity which made the payment.</para>
    /// labels<para>payer</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#payer">http://reference.data.gov.uk/def/payment#payer</seealso>
    let payer = Prefixed_Name(payment, "payer") |> PrefixedName
    /// <summary>
    ///   <para>payment:Purchase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The overall goods or service for which the payment was made</para>
    /// labels<para>Purchase</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#Purchase">http://reference.data.gov.uk/def/payment#Purchase</seealso>
    let Purchase = Prefixed_Name(payment, "Purchase") |> PrefixedName
    /// <summary>
    ///   <para>payment:capital</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Resource</para>
    ///   <para>payment:ExpenditureCategory</para>
    ///   <para>Indicates a capital expenditure.</para>
    /// labels<para>Capital</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#capital">http://reference.data.gov.uk/def/payment#capital</seealso>
    let capital = Prefixed_Name(payment, "capital") |> PrefixedName
    /// <summary>
    ///   <para>payment:expenditureCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DataTypeProperty</para>
    ///   <para>An (optional) internal code for the expenditure category. Such codes may not be useful across organizations but retaining them in a dataset may aid comparability of datasets within an organization and help with tracing back requests for further information. The internal code may actually be an amalgam of multiple different categories (e.g. may denote both the subjective and objective classifications of an expenditure).</para>
    /// labels<para>expenditure code</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#expenditureCode">http://reference.data.gov.uk/def/payment#expenditureCode</seealso>
    let expenditureCode = Prefixed_Name(payment, "expenditureCode") |> PrefixedName
    /// <summary>
    ///   <para>payment:payment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>Indicates the payment of which this expenditure line is a part.</para>
    /// labels<para>payment</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#payment">http://reference.data.gov.uk/def/payment#payment</seealso>
    let payment_ = Prefixed_Name(payment, "payment") |> PrefixedName

    /// <summary>
    ///   <para>payment:payments-with-expenditure-structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>The structure of a cube containing expenditure level information along with payments.</para>
    /// labels<para>expenditure structure</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#payments-with-expenditure-structure">http://reference.data.gov.uk/def/payment#payments-with-expenditure-structure</seealso>
    let payments_with_expenditure_structure =
        Prefixed_Name(payment, "payments-with-expenditure-structure") |> PrefixedName

    /// <summary>
    ///   <para>payment:invoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates an invoice associated with this payment (optional).</para>
    /// labels<para>invoice</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#invoice">http://reference.data.gov.uk/def/payment#invoice</seealso>
    let invoice = Prefixed_Name(payment, "invoice") |> PrefixedName
    /// <summary>
    ///   <para>payment:netAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The net amount of the payment. This is the effective cost to the payer after any reclaimable tax has been deducted.</para>
    /// labels<para>net amount</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#netAmount">http://reference.data.gov.uk/def/payment#netAmount</seealso>
    let netAmount = Prefixed_Name(payment, "netAmount") |> PrefixedName
    /// <summary>
    ///   <para>payment:payment-slice</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:SliceKey</para>
    ///   <para>rdfs:Resource</para>
    ///   <para>The definition of a slice through an expenditure cube that corresponds to all the expenditures in a single payment.</para>
    /// labels<para>payment slice</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#payment-slice">http://reference.data.gov.uk/def/payment#payment-slice</seealso>
    let payment_slice = Prefixed_Name(payment, "payment-slice") |> PrefixedName
    /// <summary>
    ///   <para>payment:grossAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The amount paid, inclusive of any tax (whether reclaimable or not)</para>
    /// labels<para>gross amount</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#grossAmount">http://reference.data.gov.uk/def/payment#grossAmount</seealso>
    let grossAmount = Prefixed_Name(payment, "grossAmount") |> PrefixedName
    /// <summary>
    ///   <para>payment:narrative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A narrative description of the goods or services that were supplied.</para>
    /// labels<para>narrative</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#narrative">http://reference.data.gov.uk/def/payment#narrative</seealso>
    let narrative = Prefixed_Name(payment, "narrative") |> PrefixedName
    /// <summary>
    ///   <para>payment:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates an order associated with this payment (optional).</para>
    /// labels<para>order</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#order">http://reference.data.gov.uk/def/payment#order</seealso>
    let order = Prefixed_Name(payment, "order") |> PrefixedName
    /// <summary>
    ///   <para>payment:purchase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the overall goods or service for which the payment was made.</para>
    /// labels<para>purchase</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#purchase">http://reference.data.gov.uk/def/payment#purchase</seealso>
    let purchase = Prefixed_Name(payment, "purchase") |> PrefixedName

    /// <summary>
    ///   <para>payment:procurementCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A classification for the goods or services for which the payment was made.</para>
    /// labels<para>procurement category</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#procurementCategory">http://reference.data.gov.uk/def/payment#procurementCategory</seealso>
    let procurementCategory =
        Prefixed_Name(payment, "procurementCategory") |> PrefixedName

    /// <summary>
    ///   <para>payment:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A reference number, code or label which identifies the payment. Not unique across different suppliers.</para>
    /// labels<para>reference</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#reference">http://reference.data.gov.uk/def/payment#reference</seealso>
    let reference = Prefixed_Name(payment, "reference") |> PrefixedName
    /// <summary>
    ///   <para>payment:totalGrossAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>total gross amount</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#totalGrossAmount">http://reference.data.gov.uk/def/payment#totalGrossAmount</seealso>
    let totalGrossAmount = Prefixed_Name(payment, "totalGrossAmount") |> PrefixedName

    /// <summary>
    ///   <para>payment:ExpenditureCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The set of expenditure categories in the expenditure-category scheme for capital/revenue.</para>
    /// labels<para>Expenditure categories</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#ExpenditureCategory">http://reference.data.gov.uk/def/payment#ExpenditureCategory</seealso>
    let ExpenditureCategory =
        Prefixed_Name(payment, "ExpenditureCategory") |> PrefixedName

    /// <summary>
    ///   <para>payment:Payment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A payment to a supplier for some goods or services, may correspond to one or more expenditure lines</para>
    /// labels<para>Payment</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#Payment">http://reference.data.gov.uk/def/payment#Payment</seealso>
    let Payment = Prefixed_Name(payment, "Payment") |> PrefixedName
    /// <summary>
    ///   <para>payment:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The date the payment is deemed to have occurred.</para>
    /// labels<para>date</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#date">http://reference.data.gov.uk/def/payment#date</seealso>
    let date = Prefixed_Name(payment, "date") |> PrefixedName
    /// <summary>
    ///   <para>payment:payee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The entity to which the payment was made.</para>
    /// labels<para>payee</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#payee">http://reference.data.gov.uk/def/payment#payee</seealso>
    let payee = Prefixed_Name(payment, "payee") |> PrefixedName
    /// <summary>
    ///   <para>payment:PaymentDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A set of payments or expenditures, laid out as a cube of data</para>
    /// labels<para>Payment data set</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#PaymentDataset">http://reference.data.gov.uk/def/payment#PaymentDataset</seealso>
    let PaymentDataset = Prefixed_Name(payment, "PaymentDataset") |> PrefixedName

    /// <summary>
    ///   <para>payment:expenditure-category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>A code scheme for classifying expenditures as capital/revenue.</para>
    /// labels<para>Exenditure category scheme</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#expenditure-category">http://reference.data.gov.uk/def/payment#expenditure-category</seealso>
    let expenditure_category =
        Prefixed_Name(payment, "expenditure-category") |> PrefixedName

    /// <summary>
    ///   <para>payment:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:AttributeProperty</para>
    ///   <para>Currency in which a payment was made, typically attached to the dataset for single currency datasets.</para>
    /// labels<para>currency</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/payment#currency">http://reference.data.gov.uk/def/payment#currency</seealso>
    let currency = Prefixed_Name(payment, "currency") |> PrefixedName
