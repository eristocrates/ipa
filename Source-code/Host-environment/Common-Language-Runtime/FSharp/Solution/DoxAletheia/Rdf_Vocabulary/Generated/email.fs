namespace http.www.w3.org._2000._10.swap.pim.email.hash

open DoxAletheia

module email =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/email#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// "AGENT (person,  system  or  process)" -- RFC822 4.4.2
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#Mailbox"></see>
    /// </summary>
    let Mailbox = _prefix "Mailbox"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#Message"></see>
    /// </summary>
    let Message = _prefix "Message"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#cc"></see>
    /// </summary>
    let cc = _prefix "cc"
    /// <summary>
    /// unmodified date header field value
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// date header field converted to YYYY-MM-DDTHH:MM:SSZ form
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#date_iso"></see></summary>
    let date_iso = _prefix "date_iso"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#from"></see>
    /// </summary>
    let from = _prefix "from"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#mbox"></see>
    /// </summary>
    let mbox = _prefix "mbox"
    /// <summary>
    /// note handling of non-ascii chars
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#phrase"></see></summary>
    let phrase = _prefix "phrase"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#received_iso"></see>
    /// </summary>
    let received_iso = _prefix "received_iso"
    /// <summary>
    /// @@not in RFC822. artificial. explain/motivate?
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#recipients"></see></summary>
    let recipients = _prefix "recipients"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#references"></see>
    /// </summary>
    let references = _prefix "references"
    /// <summary>
    /// @@not in RFC822. artificial. explain/motivate?
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#senders"></see></summary>
    let senders = _prefix "senders"
    /// <summary>
    /// domain message. note handling of non-ascii chars
    /// <see href="http://www.w3.org/2000/10/swap/pim/email#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/email#to"></see>
    /// </summary>
    let to_ = _prefix "to"
