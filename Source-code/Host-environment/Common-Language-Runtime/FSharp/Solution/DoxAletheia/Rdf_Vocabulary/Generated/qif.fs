namespace http.www.w3.org._2000._10.swap.pim.qif.hash

open DoxAletheia.Rdf_Vocabulary

module qif =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/qif#"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Account"></see>
    /// </summary>
    let Account = Namespaced_IRI.parse _namespace_name "Account" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Bank"></see>
    /// </summary>
    let Bank = Namespaced_IRI.parse _namespace_name "Bank" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Cat"></see>
    /// </summary>
    let Cat = Namespaced_IRI.parse _namespace_name "Cat" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Classified"></see>
    /// </summary>
    let Classified = Namespaced_IRI.parse _namespace_name "Classified" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Transaction"></see>
    /// </summary>
    let Transaction =
        Namespaced_IRI.parse _namespace_name "Transaction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#DocumentMetadataForm"></see>
    /// </summary>
    let DocumentMetadataForm =
        Namespaced_IRI.parse _namespace_name "DocumentMetadataForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Receipt"></see>
    /// </summary>
    let Receipt = Namespaced_IRI.parse _namespace_name "Receipt" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#SupportingDocument"></see>
    /// </summary>
    let SupportingDocument =
        Namespaced_IRI.parse _namespace_name "SupportingDocument" |> NamespacedName

    /// <summary>
    /// A transaction which has to be split into parts for classification.
    /// <see href="http://www.w3.org/2000/10/swap/pim/qif#SplitTransaction"></see></summary>
    let SplitTransaction =
        Namespaced_IRI.parse _namespace_name "SplitTransaction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#Unclassified"></see>
    /// </summary>
    let Unclassified =
        Namespaced_IRI.parse _namespace_name "Unclassified" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#UnclassifiedIncome"></see>
    /// </summary>
    let UnclassifiedIncome =
        Namespaced_IRI.parse _namespace_name "UnclassifiedIncome" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#UnclassifiedOutgoing"></see>
    /// </summary>
    let UnclassifiedOutgoing =
        Namespaced_IRI.parse _namespace_name "UnclassifiedOutgoing" |> NamespacedName

    /// <summary>
    /// The document which is the source of data for this transaction.
    /// <see href="http://www.w3.org/2000/10/swap/pim/qif#accordingTo"></see></summary>
    let accordingTo =
        Namespaced_IRI.parse _namespace_name "accordingTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#amount"></see>
    /// </summary>
    let amount = Namespaced_IRI.parse _namespace_name "amount" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#category"></see>
    /// </summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/qif#payee"></see>
    /// </summary>
    let payee = Namespaced_IRI.parse _namespace_name "payee" |> NamespacedName
    /// <summary>
    /// A transaction representing a part of this transaction.
    ///     The sum of the amounts of the parts must equal the amount of this transaction.
    /// <see href="http://www.w3.org/2000/10/swap/pim/qif#splitPart"></see></summary>
    let splitPart = Namespaced_IRI.parse _namespace_name "splitPart" |> NamespacedName

    /// <summary>
    /// A reverse transaction, putting this transaction back in the Split account, for redistribution as parts.
    ///     The amount of the reverse transaction must be the negation of this transaction.
    /// <see href="http://www.w3.org/2000/10/swap/pim/qif#splitReverse"></see></summary>
    let splitReverse =
        Namespaced_IRI.parse _namespace_name "splitReverse" |> NamespacedName

    /// <summary>
    /// The account to which money flows when the amount is positive.
    /// <see href="http://www.w3.org/2000/10/swap/pim/qif#toAccount"></see></summary>
    let toAccount = Namespaced_IRI.parse _namespace_name "toAccount" |> NamespacedName
