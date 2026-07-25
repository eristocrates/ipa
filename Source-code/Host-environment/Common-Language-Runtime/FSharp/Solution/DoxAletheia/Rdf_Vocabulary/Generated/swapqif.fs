namespace http.www.w3.org._2000._10.swap.pim.qif.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapqif =
    let _namespace_iri = Namespace_Iri swapqif |> NamespaceIRI
    /// <summary>
    ///   <para>swapqif:Classified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>classified</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#Classified">http://www.w3.org/2000/10/swap/pim/qif#Classified</seealso>
    let Classified = Prefixed_Name(swapqif, "Classified") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:Bank</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#Bank">http://www.w3.org/2000/10/swap/pim/qif#Bank</seealso>
    let Bank = Prefixed_Name(swapqif, "Bank") |> PrefixedName

    /// <summary>
    ///   <para>swapqif:DocumentMetadataForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>ui:Form</para>
    ///   <para>ui:Group</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#DocumentMetadataForm">http://www.w3.org/2000/10/swap/pim/qif#DocumentMetadataForm</seealso>
    let DocumentMetadataForm =
        Prefixed_Name(swapqif, "DocumentMetadataForm") |> PrefixedName

    /// <summary>
    ///   <para>swapqif:Receipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>receipt</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#Receipt">http://www.w3.org/2000/10/swap/pim/qif#Receipt</seealso>
    let Receipt = Prefixed_Name(swapqif, "Receipt") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:Cat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>category</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#Cat">http://www.w3.org/2000/10/swap/pim/qif#Cat</seealso>
    let Cat = Prefixed_Name(swapqif, "Cat") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:Transaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>transaction</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#Transaction">http://www.w3.org/2000/10/swap/pim/qif#Transaction</seealso>
    let Transaction = Prefixed_Name(swapqif, "Transaction") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:SplitTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A transaction which has to be split into parts for classification.</para>
    /// labels<para>split transaction</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#SplitTransaction">http://www.w3.org/2000/10/swap/pim/qif#SplitTransaction</seealso>
    let SplitTransaction = Prefixed_Name(swapqif, "SplitTransaction") |> PrefixedName

    /// <summary>
    ///   <para>swapqif:SupportingDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>supporting document</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#SupportingDocument">http://www.w3.org/2000/10/swap/pim/qif#SupportingDocument</seealso>
    let SupportingDocument =
        Prefixed_Name(swapqif, "SupportingDocument") |> PrefixedName

    /// <summary>
    ///   <para>swapqif:UnclassifiedOutgoing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>unclassified outgoing</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#UnclassifiedOutgoing">http://www.w3.org/2000/10/swap/pim/qif#UnclassifiedOutgoing</seealso>
    let UnclassifiedOutgoing =
        Prefixed_Name(swapqif, "UnclassifiedOutgoing") |> PrefixedName

    /// <summary>
    ///   <para>swapqif:amount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>amount</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#amount">http://www.w3.org/2000/10/swap/pim/qif#amount</seealso>
    let amount = Prefixed_Name(swapqif, "amount") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:splitReverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A reverse transaction, putting this transaction back in the Split account, for redistribution as parts.
    ///     The amount of the reverse transaction must be the negation of this transaction.</para>
    /// labels<para>part</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#splitReverse">http://www.w3.org/2000/10/swap/pim/qif#splitReverse</seealso>
    let splitReverse = Prefixed_Name(swapqif, "splitReverse") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:Unclassified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>unclassified</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#Unclassified">http://www.w3.org/2000/10/swap/pim/qif#Unclassified</seealso>
    let Unclassified = Prefixed_Name(swapqif, "Unclassified") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:payee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>payee</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#payee">http://www.w3.org/2000/10/swap/pim/qif#payee</seealso>
    let payee = Prefixed_Name(swapqif, "payee") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:splitPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A transaction representing a part of this transaction.
    ///     The sum of the amounts of the parts must equal the amount of this transaction.</para>
    /// labels<para>part</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#splitPart">http://www.w3.org/2000/10/swap/pim/qif#splitPart</seealso>
    let splitPart = Prefixed_Name(swapqif, "splitPart") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:toAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The account to which money flows when the amount is positive.</para>
    /// labels<para>account</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#toAccount">http://www.w3.org/2000/10/swap/pim/qif#toAccount</seealso>
    let toAccount = Prefixed_Name(swapqif, "toAccount") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>date</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#date">http://www.w3.org/2000/10/swap/pim/qif#date</seealso>
    let date = Prefixed_Name(swapqif, "date") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:accordingTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The document which is the source of data for this transaction.</para>
    /// labels<para>statement</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#accordingTo">http://www.w3.org/2000/10/swap/pim/qif#accordingTo</seealso>
    let accordingTo = Prefixed_Name(swapqif, "accordingTo") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>category</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#category">http://www.w3.org/2000/10/swap/pim/qif#category</seealso>
    let category = Prefixed_Name(swapqif, "category") |> PrefixedName
    /// <summary>
    ///   <para>swapqif:Account</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>account</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#Account">http://www.w3.org/2000/10/swap/pim/qif#Account</seealso>
    let Account = Prefixed_Name(swapqif, "Account") |> PrefixedName

    /// <summary>
    ///   <para>swapqif:UnclassifiedIncome</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>unclassified income</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/qif#UnclassifiedIncome">http://www.w3.org/2000/10/swap/pim/qif#UnclassifiedIncome</seealso>
    let UnclassifiedIncome =
        Prefixed_Name(swapqif, "UnclassifiedIncome") |> PrefixedName
