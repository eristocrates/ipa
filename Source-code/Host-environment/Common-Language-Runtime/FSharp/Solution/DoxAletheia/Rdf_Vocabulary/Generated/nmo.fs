namespace http.www.semanticdesktop.org.ontologies._2007._03._22.nmo.hash

open DoxAletheia

module nmo =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An email.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Email"></see></summary>
    let Email = _prefix "Email"
    /// <summary>
    /// A message. Could be an email, instant messanging message, SMS message etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Message"></see></summary>
    let Message = _prefix "Message"
    /// <summary>
    /// A message sent with Instant Messaging software.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#IMMessage"></see></summary>
    let IMMessage = _prefix "IMMessage"
    /// <summary>
    /// A mailbox - container for MailboxDataObjects.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#Mailbox"></see></summary>
    let Mailbox = _prefix "Mailbox"
    /// <summary>
    /// An entity encountered in a mailbox. Most common interpretations for such an entity include Message or Folder
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MailboxDataObject"></see></summary>
    let MailboxDataObject = _prefix "MailboxDataObject"
    /// <summary>
    /// An arbitrary message header.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MessageHeader"></see></summary>
    let MessageHeader = _prefix "MessageHeader"
    /// <summary>
    /// A MIME entity, as defined in RFC2045, Section 2.4.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#MimeEntity"></see></summary>
    let MimeEntity = _prefix "MimeEntity"
    /// <summary>
    /// deprecated in favor of nmo:emailBcc
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#bcc"></see></summary>
    let bcc = _prefix "bcc"
    /// <summary>
    /// deprecated in favor of nmo:secondaryMessageRecipient
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#secondaryRecipient"></see></summary>
    let secondaryRecipient = _prefix "secondaryRecipient"
    /// <summary>
    /// deprecated in favor of nmo:emailCc
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#cc"></see></summary>
    let cc = _prefix "cc"
    /// <summary>
    /// Key used to store the MIME type of the content of an object when it is different from the object's main MIME type. This value can be used, for example, to model an e-mail message whose mime type is"message/rfc822", but whose content has type "text/html". If not specified, the MIME type of the
    /// content defaults to the value specified by the 'mimeType' property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#contentMimeType"></see></summary>
    let contentMimeType = _prefix "contentMimeType"
    /// <summary>
    /// A Contact that is to receive a bcc of the email. A Bcc (blind carbon copy) is a copy of an email message sent to a recipient whose email address does not appear in the message.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailBcc"></see></summary>
    let emailBcc = _prefix "emailBcc"
    /// <summary>
    /// A superproperty for all "additional" recipients of a message.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#secondaryMessageRecipient"></see></summary>
    let secondaryMessageRecipient = _prefix "secondaryMessageRecipient"
    /// <summary>
    /// A Contact that is to receive a cc of the email. A cc (carbon copy) is a copy of an email message whose recipient appears on the recipient list, so that all other recipients are aware of it.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailCc"></see></summary>
    let emailCc = _prefix "emailCc"
    /// <summary>
    /// The primary intended recipient of an email.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#emailTo"></see></summary>
    let emailTo = _prefix "emailTo"
    /// <summary>
    /// The primary intended recipient of a message.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#primaryMessageRecipient"></see></summary>
    let primaryMessageRecipient = _prefix "primaryMessageRecipient"
    /// <summary>
    /// deprecated in favor of nmo:messageFrom
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#from"></see></summary>
    let from = _prefix "from"
    /// <summary>
    /// Links a message with files that were sent as attachments.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#hasAttachment"></see></summary>
    let hasAttachment = _prefix "hasAttachment"
    /// <summary>
    /// Name of the message header.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#headerName"></see></summary>
    let headerName = _prefix "headerName"
    /// <summary>
    /// Value of the message header.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#headerValue"></see></summary>
    let headerValue = _prefix "headerValue"
    /// <summary>
    /// HTML representation of the body of the message. For multipart messages, all parts are concatenated into the value of this property. Attachments, whose mimeTypes are different from text/plain or message/rfc822 are considered separate DataObjects and are therefore not included in the value of this property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#htmlMessageContent"></see></summary>
    let htmlMessageContent = _prefix "htmlMessageContent"
    /// <summary>
    /// Signifies that a message is a reply to another message. This feature is commonly used to link messages into conversations. Note that it is more specific than nmo:references. See RFC 2822 sec. 3.6.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#inReplyTo"></see></summary>
    let inReplyTo = _prefix "inReplyTo"
    /// <summary>
    /// Signifies that a message references another message. This property is a generic one. See RFC 2822 Sec. 3.6.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#references"></see></summary>
    let references = _prefix "references"
    /// <summary>
    /// A flag that states the fact that a MailboxDataObject has been read.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#isRead"></see></summary>
    let isRead = _prefix "isRead"
    /// <summary>
    /// The sender of the message
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageFrom"></see></summary>
    let messageFrom = _prefix "messageFrom"
    /// <summary>
    /// Links the message with an arbitrary message header.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageHeader"></see></summary>
    let messageHeader = _prefix "messageHeader"
    /// <summary>
    /// An identifier of a message. This property has been inspired by the message-id property defined in RFC 2822, Sec. 3.6.4. It should be used for all kinds of identifiers used by various messaging applications to connect multiple messages into conversations. For email messageids, values are according to RFC2822/sec 3.6.4 and the literal value in RDF must include the brackets.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageId"></see></summary>
    let messageId = _prefix "messageId"
    /// <summary>
    /// A common superproperty for all properties that link a message with its recipients. Please don't use this property directly.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageRecipient"></see></summary>
    let messageRecipient = _prefix "messageRecipient"
    /// <summary>
    /// An address where the reply should be sent.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageReplyTo"></see></summary>
    let messageReplyTo = _prefix "messageReplyTo"
    /// <summary>
    /// The person or agent submitting the message to the network, if other from the one given with the nmo:from property. Defined in RFC 822 sec. 4.4.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageSender"></see></summary>
    let messageSender = _prefix "messageSender"
    /// <summary>
    /// The subject of a message
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#messageSubject"></see></summary>
    let messageSubject = _prefix "messageSubject"
    /// <summary>
    /// Plain text representation of the body of the message. For multipart messages, all parts are concatenated into the value of this property. Attachments, whose mimeTypes are different from text/plain or message/rfc822 are considered separate DataObjects and are therefore not included in the value of this property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#plainTextMessageContent"></see></summary>
    let plainTextMessageContent = _prefix "plainTextMessageContent"
    /// <summary>
    /// deprecated in favor of primaryMessageRecipient
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#primaryRecipient"></see></summary>
    let primaryRecipient = _prefix "primaryRecipient"
    /// <summary>
    /// deprecated in favor of nmo:messageRecipient
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#recipient"></see></summary>
    let recipient = _prefix "recipient"
    /// <summary>
    /// Date when this message was received.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#receivedDate"></see></summary>
    let receivedDate = _prefix "receivedDate"
    /// <summary>
    /// deprecated in favor of nmo:messageReplyTo
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#replyTo"></see></summary>
    let replyTo = _prefix "replyTo"
    /// <summary>
    /// deprecated in favor of nmo:messageSender
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#sender"></see></summary>
    let sender = _prefix "sender"
    /// <summary>
    /// Date when this message was sent.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#sentDate"></see></summary>
    let sentDate = _prefix "sentDate"
    /// <summary>
    /// deprecated in favor of nmo:emailTo
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#to"></see></summary>
    let to_ = _prefix "to"
