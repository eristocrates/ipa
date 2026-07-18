namespace http.www.semanticdesktop.org.ontologies._2007._03._22.nmo.hash

open DoxAletheia.Rdf_Vocabulary

module nmo =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#"
    /// <summary>
    /// An email.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Email"></see></summary>
    let Email = Namespaced_IRI.parse _namespace_name "Email" |> NamespacedName
    /// <summary>
    /// A message. Could be an email, instant messanging message, SMS message etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Message"></see></summary>
    let Message = Namespaced_IRI.parse _namespace_name "Message" |> NamespacedName
    /// <summary>
    /// A message sent with Instant Messaging software.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#IMMessage"></see></summary>
    let IMMessage = Namespaced_IRI.parse _namespace_name "IMMessage" |> NamespacedName
    /// <summary>
    /// A mailbox - container for MailboxDataObjects.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Mailbox"></see></summary>
    let Mailbox = Namespaced_IRI.parse _namespace_name "Mailbox" |> NamespacedName

    /// <summary>
    /// An entity encountered in a mailbox. Most common interpretations for such an entity include Message or Folder
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MailboxDataObject"></see></summary>
    let MailboxDataObject =
        Namespaced_IRI.parse _namespace_name "MailboxDataObject" |> NamespacedName

    /// <summary>
    /// An arbitrary message header.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MessageHeader"></see></summary>
    let MessageHeader =
        Namespaced_IRI.parse _namespace_name "MessageHeader" |> NamespacedName

    /// <summary>
    /// A MIME entity, as defined in RFC2045, Section 2.4.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MimeEntity"></see></summary>
    let MimeEntity = Namespaced_IRI.parse _namespace_name "MimeEntity" |> NamespacedName
    /// <summary>
    /// deprecated in favor of nmo:emailBcc
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#bcc"></see></summary>
    let bcc = Namespaced_IRI.parse _namespace_name "bcc" |> NamespacedName

    /// <summary>
    /// deprecated in favor of nmo:secondaryMessageRecipient
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#secondaryRecipient"></see></summary>
    let secondaryRecipient =
        Namespaced_IRI.parse _namespace_name "secondaryRecipient" |> NamespacedName

    /// <summary>
    /// deprecated in favor of nmo:emailCc
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#cc"></see></summary>
    let cc = Namespaced_IRI.parse _namespace_name "cc" |> NamespacedName

    /// <summary>
    /// Key used to store the MIME type of the content of an object when it is different from the object's main MIME type. This value can be used, for example, to model an e-mail message whose mime type is"message/rfc822", but whose content has type "text/html". If not specified, the MIME type of the
    /// content defaults to the value specified by the 'mimeType' property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#contentMimeType"></see></summary>
    let contentMimeType =
        Namespaced_IRI.parse _namespace_name "contentMimeType" |> NamespacedName

    /// <summary>
    /// A Contact that is to receive a bcc of the email. A Bcc (blind carbon copy) is a copy of an email message sent to a recipient whose email address does not appear in the message.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailBcc"></see></summary>
    let emailBcc = Namespaced_IRI.parse _namespace_name "emailBcc" |> NamespacedName

    /// <summary>
    /// A superproperty for all "additional" recipients of a message.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#secondaryMessageRecipient"></see></summary>
    let secondaryMessageRecipient =
        Namespaced_IRI.parse _namespace_name "secondaryMessageRecipient" |> NamespacedName

    /// <summary>
    /// A Contact that is to receive a cc of the email. A cc (carbon copy) is a copy of an email message whose recipient appears on the recipient list, so that all other recipients are aware of it.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailCc"></see></summary>
    let emailCc = Namespaced_IRI.parse _namespace_name "emailCc" |> NamespacedName
    /// <summary>
    /// The primary intended recipient of an email.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailTo"></see></summary>
    let emailTo = Namespaced_IRI.parse _namespace_name "emailTo" |> NamespacedName

    /// <summary>
    /// The primary intended recipient of a message.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#primaryMessageRecipient"></see></summary>
    let primaryMessageRecipient =
        Namespaced_IRI.parse _namespace_name "primaryMessageRecipient" |> NamespacedName

    /// <summary>
    /// deprecated in favor of nmo:messageFrom
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#from"></see></summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName

    /// <summary>
    /// Links a message with files that were sent as attachments.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#hasAttachment"></see></summary>
    let hasAttachment =
        Namespaced_IRI.parse _namespace_name "hasAttachment" |> NamespacedName

    /// <summary>
    /// Name of the message header.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#headerName"></see></summary>
    let headerName = Namespaced_IRI.parse _namespace_name "headerName" |> NamespacedName

    /// <summary>
    /// Value of the message header.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#headerValue"></see></summary>
    let headerValue =
        Namespaced_IRI.parse _namespace_name "headerValue" |> NamespacedName

    /// <summary>
    /// HTML representation of the body of the message. For multipart messages, all parts are concatenated into the value of this property. Attachments, whose mimeTypes are different from text/plain or message/rfc822 are considered separate DataObjects and are therefore not included in the value of this property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#htmlMessageContent"></see></summary>
    let htmlMessageContent =
        Namespaced_IRI.parse _namespace_name "htmlMessageContent" |> NamespacedName

    /// <summary>
    /// Signifies that a message is a reply to another message. This feature is commonly used to link messages into conversations. Note that it is more specific than nmo:references. See RFC 2822 sec. 3.6.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#inReplyTo"></see></summary>
    let inReplyTo = Namespaced_IRI.parse _namespace_name "inReplyTo" |> NamespacedName
    /// <summary>
    /// Signifies that a message references another message. This property is a generic one. See RFC 2822 Sec. 3.6.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#references"></see></summary>
    let references = Namespaced_IRI.parse _namespace_name "references" |> NamespacedName
    /// <summary>
    /// A flag that states the fact that a MailboxDataObject has been read.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#isRead"></see></summary>
    let isRead = Namespaced_IRI.parse _namespace_name "isRead" |> NamespacedName

    /// <summary>
    /// The sender of the message
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageFrom"></see></summary>
    let messageFrom =
        Namespaced_IRI.parse _namespace_name "messageFrom" |> NamespacedName

    /// <summary>
    /// Links the message with an arbitrary message header.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageHeader"></see></summary>
    let messageHeader =
        Namespaced_IRI.parse _namespace_name "messageHeader" |> NamespacedName

    /// <summary>
    /// An identifier of a message. This property has been inspired by the message-id property defined in RFC 2822, Sec. 3.6.4. It should be used for all kinds of identifiers used by various messaging applications to connect multiple messages into conversations. For email messageids, values are according to RFC2822/sec 3.6.4 and the literal value in RDF must include the brackets.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageId"></see></summary>
    let messageId = Namespaced_IRI.parse _namespace_name "messageId" |> NamespacedName

    /// <summary>
    /// A common superproperty for all properties that link a message with its recipients. Please don't use this property directly.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageRecipient"></see></summary>
    let messageRecipient =
        Namespaced_IRI.parse _namespace_name "messageRecipient" |> NamespacedName

    /// <summary>
    /// An address where the reply should be sent.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageReplyTo"></see></summary>
    let messageReplyTo =
        Namespaced_IRI.parse _namespace_name "messageReplyTo" |> NamespacedName

    /// <summary>
    /// The person or agent submitting the message to the network, if other from the one given with the nmo:from property. Defined in RFC 822 sec. 4.4.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageSender"></see></summary>
    let messageSender =
        Namespaced_IRI.parse _namespace_name "messageSender" |> NamespacedName

    /// <summary>
    /// The subject of a message
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageSubject"></see></summary>
    let messageSubject =
        Namespaced_IRI.parse _namespace_name "messageSubject" |> NamespacedName

    /// <summary>
    /// Plain text representation of the body of the message. For multipart messages, all parts are concatenated into the value of this property. Attachments, whose mimeTypes are different from text/plain or message/rfc822 are considered separate DataObjects and are therefore not included in the value of this property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#plainTextMessageContent"></see></summary>
    let plainTextMessageContent =
        Namespaced_IRI.parse _namespace_name "plainTextMessageContent" |> NamespacedName

    /// <summary>
    /// deprecated in favor of primaryMessageRecipient
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#primaryRecipient"></see></summary>
    let primaryRecipient =
        Namespaced_IRI.parse _namespace_name "primaryRecipient" |> NamespacedName

    /// <summary>
    /// deprecated in favor of nmo:messageRecipient
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#recipient"></see></summary>
    let recipient = Namespaced_IRI.parse _namespace_name "recipient" |> NamespacedName

    /// <summary>
    /// Date when this message was received.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#receivedDate"></see></summary>
    let receivedDate =
        Namespaced_IRI.parse _namespace_name "receivedDate" |> NamespacedName

    /// <summary>
    /// deprecated in favor of nmo:messageReplyTo
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#replyTo"></see></summary>
    let replyTo = Namespaced_IRI.parse _namespace_name "replyTo" |> NamespacedName
    /// <summary>
    /// deprecated in favor of nmo:messageSender
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#sender"></see></summary>
    let sender = Namespaced_IRI.parse _namespace_name "sender" |> NamespacedName
    /// <summary>
    /// Date when this message was sent.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#sentDate"></see></summary>
    let sentDate = Namespaced_IRI.parse _namespace_name "sentDate" |> NamespacedName
    /// <summary>
    /// deprecated in favor of nmo:emailTo
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#to"></see></summary>
    let to_ = Namespaced_IRI.parse _namespace_name "to" |> NamespacedName
