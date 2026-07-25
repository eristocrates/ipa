namespace http.www.w3.org._2000._10.swap.pim.email.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapemail =
    let _namespace_iri = Namespace_Iri swapemail |> NamespaceIRI
    /// <summary>
    ///   <para>swapemail:Mailbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mailbox</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#Mailbox">http://www.w3.org/2000/10/swap/pim/email#Mailbox</seealso>
    let Mailbox = Prefixed_Name(swapemail, "Mailbox") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Message</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#Message">http://www.w3.org/2000/10/swap/pim/email#Message</seealso>
    let Message = Prefixed_Name(swapemail, "Message") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:cc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>cc</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#cc">http://www.w3.org/2000/10/swap/pim/email#cc</seealso>
    let cc = Prefixed_Name(swapemail, "cc") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>unmodified date header field value</para>
    /// labels<para>date</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#date">http://www.w3.org/2000/10/swap/pim/email#date</seealso>
    let date = Prefixed_Name(swapemail, "date") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:mbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///
    /// labels<para>mbox</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#mbox">http://www.w3.org/2000/10/swap/pim/email#mbox</seealso>
    let mbox = Prefixed_Name(swapemail, "mbox") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:date_iso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>date header field converted to YYYY-MM-DDTHH:MM:SSZ form</para>
    /// labels<para>date_iso</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#date_iso">http://www.w3.org/2000/10/swap/pim/email#date_iso</seealso>
    let date_iso = Prefixed_Name(swapemail, "date_iso") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>from</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#from">http://www.w3.org/2000/10/swap/pim/email#from</seealso>
    let from = Prefixed_Name(swapemail, "from") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:received_iso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>received_iso</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#received_iso">http://www.w3.org/2000/10/swap/pim/email#received_iso</seealso>
    let received_iso = Prefixed_Name(swapemail, "received_iso") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:recipients</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>@@not in RFC822. artificial. explain/motivate?</para>
    /// labels<para>recipients</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#recipients">http://www.w3.org/2000/10/swap/pim/email#recipients</seealso>
    let recipients = Prefixed_Name(swapemail, "recipients") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:references</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>references</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#references">http://www.w3.org/2000/10/swap/pim/email#references</seealso>
    let references = Prefixed_Name(swapemail, "references") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:senders</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>@@not in RFC822. artificial. explain/motivate?</para>
    /// labels<para>senders</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#senders">http://www.w3.org/2000/10/swap/pim/email#senders</seealso>
    let senders = Prefixed_Name(swapemail, "senders") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#to">http://www.w3.org/2000/10/swap/pim/email#to</seealso>
    let to_ = Prefixed_Name(swapemail, "to") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>domain message. note handling of non-ascii chars</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#subject">http://www.w3.org/2000/10/swap/pim/email#subject</seealso>
    let subject = Prefixed_Name(swapemail, "subject") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AGENT (person,  system  or  process)" -- RFC822 4.4.2</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#Agent">http://www.w3.org/2000/10/swap/pim/email#Agent</seealso>
    let Agent = Prefixed_Name(swapemail, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>swapemail:phrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>note handling of non-ascii chars</para>
    /// labels<para>phrase</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/email#phrase">http://www.w3.org/2000/10/swap/pim/email#phrase</seealso>
    let phrase = Prefixed_Name(swapemail, "phrase") |> PrefixedName
