namespace http.www.w3.org._2000._10.swap.pim.email.hash

open DoxAletheia.Rdf_Vocabulary

module email =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/email#"
    /// <summary>
    /// "AGENT (person,  system  or  process)" -- RFC822 4.4.2
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#Mailbox"></see>
    /// </summary>
    let Mailbox = Namespaced_IRI.parse _namespace_name "Mailbox" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#Message"></see>
    /// </summary>
    let Message = Namespaced_IRI.parse _namespace_name "Message" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#cc"></see>
    /// </summary>
    let cc = Namespaced_IRI.parse _namespace_name "cc" |> NamespacedName
    /// <summary>
    /// unmodified date header field value
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    /// date header field converted to YYYY-MM-DDTHH:MM:SSZ form
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#date_iso"></see></summary>
    let date_iso = Namespaced_IRI.parse _namespace_name "date_iso" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#from"></see>
    /// </summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#mbox"></see>
    /// </summary>
    let mbox = Namespaced_IRI.parse _namespace_name "mbox" |> NamespacedName
    /// <summary>
    /// note handling of non-ascii chars
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#phrase"></see></summary>
    let phrase = Namespaced_IRI.parse _namespace_name "phrase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#received_iso"></see>
    /// </summary>
    let received_iso =
        Namespaced_IRI.parse _namespace_name "received_iso" |> NamespacedName

    /// <summary>
    /// @@not in RFC822. artificial. explain/motivate?
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#recipients"></see></summary>
    let recipients = Namespaced_IRI.parse _namespace_name "recipients" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#references"></see>
    /// </summary>
    let references = Namespaced_IRI.parse _namespace_name "references" |> NamespacedName
    /// <summary>
    /// @@not in RFC822. artificial. explain/motivate?
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#senders"></see></summary>
    let senders = Namespaced_IRI.parse _namespace_name "senders" |> NamespacedName
    /// <summary>
    /// domain message. note handling of non-ascii chars
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#to"></see>
    /// </summary>
    let to_ = Namespaced_IRI.parse _namespace_name "to" |> NamespacedName
