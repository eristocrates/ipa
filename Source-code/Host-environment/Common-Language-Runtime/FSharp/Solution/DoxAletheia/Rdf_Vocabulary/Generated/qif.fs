namespace http.www.w3.org._2000._10.swap.pim.qif.hash

open DoxAletheia

module qif =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/qif#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Account"></see>
    /// </summary>
    let Account = _prefix "Account"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Bank"></see>
    /// </summary>
    let Bank = _prefix "Bank"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Cat"></see>
    /// </summary>
    let Cat = _prefix "Cat"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Classified"></see>
    /// </summary>
    let Classified = _prefix "Classified"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Transaction"></see>
    /// </summary>
    let Transaction = _prefix "Transaction"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#DocumentMetadataForm"></see>
    /// </summary>
    let DocumentMetadataForm = _prefix "DocumentMetadataForm"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Receipt"></see>
    /// </summary>
    let Receipt = _prefix "Receipt"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#SupportingDocument"></see>
    /// </summary>
    let SupportingDocument = _prefix "SupportingDocument"
    /// <summary>
    /// A transaction which has to be split into parts for classification.
    /// <see href="http://www.w3.org/2000/10/swap/pim/qif#SplitTransaction"></see></summary>
    let SplitTransaction = _prefix "SplitTransaction"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Unclassified"></see>
    /// </summary>
    let Unclassified = _prefix "Unclassified"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#UnclassifiedIncome"></see>
    /// </summary>
    let UnclassifiedIncome = _prefix "UnclassifiedIncome"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#UnclassifiedOutgoing"></see>
    /// </summary>
    let UnclassifiedOutgoing = _prefix "UnclassifiedOutgoing"
    /// <summary>
    /// The document which is the source of data for this transaction.
    /// <see href="http://www.w3.org/2000/10/swap/pim/qif#accordingTo"></see></summary>
    let accordingTo = _prefix "accordingTo"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#amount"></see>
    /// </summary>
    let amount = _prefix "amount"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#category"></see>
    /// </summary>
    let category = _prefix "category"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#payee"></see>
    /// </summary>
    let payee = _prefix "payee"
    /// <summary>
    /// A transaction representing a part of this transaction.
    ///     The sum of the amounts of the parts must equal the amount of this transaction.
    /// <see href="http://www.w3.org/2000/10/swap/pim/qif#splitPart"></see></summary>
    let splitPart = _prefix "splitPart"
    /// <summary>
    /// A reverse transaction, putting this transaction back in the Split account, for redistribution as parts.
    ///     The amount of the reverse transaction must be the negation of this transaction.
    /// <see href="http://www.w3.org/2000/10/swap/pim/qif#splitReverse"></see></summary>
    let splitReverse = _prefix "splitReverse"
    /// <summary>
    /// The account to which money flows when the amount is positive.
    /// <see href="http://www.w3.org/2000/10/swap/pim/qif#toAccount"></see></summary>
    let toAccount = _prefix "toAccount"
