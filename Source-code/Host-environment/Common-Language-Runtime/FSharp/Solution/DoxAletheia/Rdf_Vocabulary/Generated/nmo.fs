namespace http.www.semanticdesktop.org.ontologies._2007._03._22.nmo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nmo =
    let _namespace_iri = Namespace_Iri nmo |> NamespaceIRI
    /// <summary>
    ///   <para>nmo:Email</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An email."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Email"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Email">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Email</seealso>
    let Email = Prefixed_Name(nmo, "Email") |> PrefixedName
    /// <summary>
    ///   <para>nmo:IMMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A message sent with Instant Messaging software."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IMMessage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#IMMessage">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#IMMessage</seealso>
    let IMMessage = Prefixed_Name(nmo, "IMMessage") |> PrefixedName
    /// <summary>
    ///   <para>nmo:Mailbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A mailbox - container for MailboxDataObjects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mailbox"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Mailbox">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Mailbox</seealso>
    let Mailbox = Prefixed_Name(nmo, "Mailbox") |> PrefixedName
    /// <summary>
    ///   <para>nmo:MailboxDataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An entity encountered in a mailbox. Most common interpretations for such an entity include Message or Folder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MailboxDataObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MailboxDataObject">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MailboxDataObject</seealso>
    let MailboxDataObject = Prefixed_Name(nmo, "MailboxDataObject") |> PrefixedName
    /// <summary>
    ///   <para>nmo:Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A message. Could be an email, instant messanging message, SMS message etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Message"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Message">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Message</seealso>
    let Message = Prefixed_Name(nmo, "Message") |> PrefixedName
    /// <summary>
    ///   <para>nmo:MessageHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An arbitrary message header."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MessageHeader"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MessageHeader">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MessageHeader</seealso>
    let MessageHeader = Prefixed_Name(nmo, "MessageHeader") |> PrefixedName
    /// <summary>
    ///   <para>nmo:MimeEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A MIME entity, as defined in RFC2045, Section 2.4."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MimeEntity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MimeEntity">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MimeEntity</seealso>
    let MimeEntity = Prefixed_Name(nmo, "MimeEntity") |> PrefixedName
    /// <summary>
    ///   <para>nmo:bcc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"deprecated in favor of nmo:emailBcc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bcc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#bcc">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#bcc</seealso>
    let bcc = Prefixed_Name(nmo, "bcc") |> PrefixedName
    /// <summary>
    ///   <para>nmo:cc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"deprecated in favor of nmo:emailCc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#cc">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#cc</seealso>
    let cc = Prefixed_Name(nmo, "cc") |> PrefixedName
    /// <summary>
    ///   <para>nmo:contentMimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Key used to store the MIME type of the content of an object when it is different from the object's main MIME type. This value can be used, for example, to model an e-mail message whose mime type is"message/rfc822", but whose content has type "text/html". If not specified, the MIME type of the
    /// content defaults to the value specified by the 'mimeType' property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contentMimeType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#contentMimeType">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#contentMimeType</seealso>
    let contentMimeType = Prefixed_Name(nmo, "contentMimeType") |> PrefixedName
    /// <summary>
    ///   <para>nmo:emailBcc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A Contact that is to receive a bcc of the email. A Bcc (blind carbon copy) is a copy of an email message sent to a recipient whose email address does not appear in the message."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bcc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailBcc">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailBcc</seealso>
    let emailBcc = Prefixed_Name(nmo, "emailBcc") |> PrefixedName
    /// <summary>
    ///   <para>nmo:emailCc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A Contact that is to receive a cc of the email. A cc (carbon copy) is a copy of an email message whose recipient appears on the recipient list, so that all other recipients are aware of it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailCc">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailCc</seealso>
    let emailCc = Prefixed_Name(nmo, "emailCc") |> PrefixedName
    /// <summary>
    ///   <para>nmo:emailTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The primary intended recipient of an email."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailTo">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailTo</seealso>
    let emailTo = Prefixed_Name(nmo, "emailTo") |> PrefixedName
    /// <summary>
    ///   <para>nmo:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"deprecated in favor of nmo:messageFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#from">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#from</seealso>
    let from = Prefixed_Name(nmo, "from") |> PrefixedName
    /// <summary>
    ///   <para>nmo:hasAttachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a message with files that were sent as attachments."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasAttachment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#hasAttachment">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#hasAttachment</seealso>
    let hasAttachment = Prefixed_Name(nmo, "hasAttachment") |> PrefixedName
    /// <summary>
    ///   <para>nmo:headerName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of the message header."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"headerName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#headerName">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#headerName</seealso>
    let headerName = Prefixed_Name(nmo, "headerName") |> PrefixedName
    /// <summary>
    ///   <para>nmo:headerValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Value of the message header."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"headerValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#headerValue">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#headerValue</seealso>
    let headerValue = Prefixed_Name(nmo, "headerValue") |> PrefixedName
    /// <summary>
    ///   <para>nmo:htmlMessageContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"HTML representation of the body of the message. For multipart messages, all parts are concatenated into the value of this property. Attachments, whose mimeTypes are different from text/plain or message/rfc822 are considered separate DataObjects and are therefore not included in the value of this property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"htmlMessageContent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#htmlMessageContent">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#htmlMessageContent</seealso>
    let htmlMessageContent = Prefixed_Name(nmo, "htmlMessageContent") |> PrefixedName
    /// <summary>
    ///   <para>nmo:inReplyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Signifies that a message is a reply to another message. This feature is commonly used to link messages into conversations. Note that it is more specific than nmo:references. See RFC 2822 sec. 3.6.4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inReplyTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#inReplyTo">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#inReplyTo</seealso>
    let inReplyTo = Prefixed_Name(nmo, "inReplyTo") |> PrefixedName
    /// <summary>
    ///   <para>nmo:isRead</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A flag that states the fact that a MailboxDataObject has been read."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isRead"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#isRead">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#isRead</seealso>
    let isRead = Prefixed_Name(nmo, "isRead") |> PrefixedName
    /// <summary>
    ///   <para>nmo:messageFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The sender of the message"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageFrom">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageFrom</seealso>
    let messageFrom = Prefixed_Name(nmo, "messageFrom") |> PrefixedName
    /// <summary>
    ///   <para>nmo:messageHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links the message with an arbitrary message header."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"messageHeader"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageHeader">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageHeader</seealso>
    let messageHeader = Prefixed_Name(nmo, "messageHeader") |> PrefixedName
    /// <summary>
    ///   <para>nmo:messageId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An identifier of a message. This property has been inspired by the message-id property defined in RFC 2822, Sec. 3.6.4. It should be used for all kinds of identifiers used by various messaging applications to connect multiple messages into conversations. For email messageids, values are according to RFC2822/sec 3.6.4 and the literal value in RDF must include the brackets."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"messageId"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageId">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageId</seealso>
    let messageId = Prefixed_Name(nmo, "messageId") |> PrefixedName
    /// <summary>
    ///   <para>nmo:messageRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A common superproperty for all properties that link a message with its recipients. Please don't use this property directly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"recipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageRecipient">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageRecipient</seealso>
    let messageRecipient = Prefixed_Name(nmo, "messageRecipient") |> PrefixedName
    /// <summary>
    ///   <para>nmo:messageReplyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An address where the reply should be sent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"replyTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageReplyTo">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageReplyTo</seealso>
    let messageReplyTo = Prefixed_Name(nmo, "messageReplyTo") |> PrefixedName
    /// <summary>
    ///   <para>nmo:messageSender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The person or agent submitting the message to the network, if other from the one given with the nmo:from property. Defined in RFC 822 sec. 4.4.2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageSender">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageSender</seealso>
    let messageSender = Prefixed_Name(nmo, "messageSender") |> PrefixedName
    /// <summary>
    ///   <para>nmo:messageSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject of a message"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"messageSubject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageSubject">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageSubject</seealso>
    let messageSubject = Prefixed_Name(nmo, "messageSubject") |> PrefixedName

    /// <summary>
    ///   <para>nmo:plainTextMessageContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Plain text representation of the body of the message. For multipart messages, all parts are concatenated into the value of this property. Attachments, whose mimeTypes are different from text/plain or message/rfc822 are considered separate DataObjects and are therefore not included in the value of this property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"plainTextMessageContent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#plainTextMessageContent">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#plainTextMessageContent</seealso>
    let plainTextMessageContent =
        Prefixed_Name(nmo, "plainTextMessageContent") |> PrefixedName

    /// <summary>
    ///   <para>nmo:primaryMessageRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The primary intended recipient of a message."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"primaryRecipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#primaryMessageRecipient">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#primaryMessageRecipient</seealso>
    let primaryMessageRecipient =
        Prefixed_Name(nmo, "primaryMessageRecipient") |> PrefixedName

    /// <summary>
    ///   <para>nmo:primaryRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"deprecated in favor of primaryMessageRecipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"primaryRecipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#primaryRecipient">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#primaryRecipient</seealso>
    let primaryRecipient = Prefixed_Name(nmo, "primaryRecipient") |> PrefixedName
    /// <summary>
    ///   <para>nmo:receivedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Date when this message was received."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"receivedDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#receivedDate">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#receivedDate</seealso>
    let receivedDate = Prefixed_Name(nmo, "receivedDate") |> PrefixedName
    /// <summary>
    ///   <para>nmo:recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"deprecated in favor of nmo:messageRecipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"recipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#recipient">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#recipient</seealso>
    let recipient = Prefixed_Name(nmo, "recipient") |> PrefixedName
    /// <summary>
    ///   <para>nmo:references</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Signifies that a message references another message. This property is a generic one. See RFC 2822 Sec. 3.6.4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"references"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#references">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#references</seealso>
    let references = Prefixed_Name(nmo, "references") |> PrefixedName
    /// <summary>
    ///   <para>nmo:replyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"deprecated in favor of nmo:messageReplyTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"replyTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#replyTo">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#replyTo</seealso>
    let replyTo = Prefixed_Name(nmo, "replyTo") |> PrefixedName

    /// <summary>
    ///   <para>nmo:secondaryMessageRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A superproperty for all "additional" recipients of a message."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"secondaryRecipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#secondaryMessageRecipient">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#secondaryMessageRecipient</seealso>
    let secondaryMessageRecipient =
        Prefixed_Name(nmo, "secondaryMessageRecipient") |> PrefixedName

    /// <summary>
    ///   <para>nmo:secondaryRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"deprecated in favor of nmo:secondaryMessageRecipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"secondaryRecipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#secondaryRecipient">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#secondaryRecipient</seealso>
    let secondaryRecipient = Prefixed_Name(nmo, "secondaryRecipient") |> PrefixedName
    /// <summary>
    ///   <para>nmo:sender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"deprecated in favor of nmo:messageSender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#sender">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#sender</seealso>
    let sender = Prefixed_Name(nmo, "sender") |> PrefixedName
    /// <summary>
    ///   <para>nmo:sentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Date when this message was sent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sentDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#sentDate">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#sentDate</seealso>
    let sentDate = Prefixed_Name(nmo, "sentDate") |> PrefixedName
    /// <summary>
    ///   <para>nmo:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"deprecated in favor of nmo:emailTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#to">http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#to</seealso>
    let to_ = Prefixed_Name(nmo, "to") |> PrefixedName
