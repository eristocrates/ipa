namespace http.www.semanticdesktop.org.ontologies._2007._03._22.nco.hash

open DoxAletheia.Rdf_Vocabulary

module nco =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/03/22/nco#"

    /// <summary>
    /// Aggregates three properties defined in RFC2426. Originally all three were attached directly to a person. One person could have only one title and one role within one organization. This class is intended to lift this limitation.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Affiliation"></see></summary>
    let Affiliation =
        Namespaced_IRI.parse _namespace_name "Affiliation" |> NamespacedName

    /// <summary>
    /// A role played by a contact. Contacts that denote people, can have many roles (e.g. see the hasAffiliation property and Affiliation class). Contacts that denote Organizations or other Agents usually have one role.  Each role can introduce additional contact media.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of nco:imCapabilityAudio.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#AudioIMAccount"></see></summary>
    let AudioIMAccount =
        Namespaced_IRI.parse _namespace_name "AudioIMAccount" |> NamespacedName

    /// <summary>
    /// An account in an Instant Messaging system.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMAccount"></see></summary>
    let IMAccount = Namespaced_IRI.parse _namespace_name "IMAccount" |> NamespacedName
    /// <summary>
    /// A Bulletin Board System (BBS) phone number. Inspired by the (TYPE=bbsl) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#BbsNumber"></see></summary>
    let BbsNumber = Namespaced_IRI.parse _namespace_name "BbsNumber" |> NamespacedName

    /// <summary>
    /// A modem phone number. Inspired by the (TYPE=modem) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ModemNumber"></see></summary>
    let ModemNumber =
        Namespaced_IRI.parse _namespace_name "ModemNumber" |> NamespacedName

    /// <summary>
    /// A class representing a person contact's birth date information. Possesses various attributes.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#BirthDate"></see></summary>
    let BirthDate = Namespaced_IRI.parse _namespace_name "BirthDate" |> NamespacedName

    /// <summary>
    /// A car phone number. Inspired by the (TYPE=car) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#CarPhoneNumber"></see></summary>
    let CarPhoneNumber =
        Namespaced_IRI.parse _namespace_name "CarPhoneNumber" |> NamespacedName

    /// <summary>
    /// A telephone number with voice communication capabilities. Class inspired by the TYPE=voice parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VoicePhoneNumber"></see></summary>
    let VoicePhoneNumber =
        Namespaced_IRI.parse _namespace_name "VoicePhoneNumber" |> NamespacedName

    /// <summary>
    /// A cellular phone number. Inspired by the (TYPE=cell) parameter of the TEL property as defined in RFC 2426 sec  3.3.1. Usually a cellular phone can accept voice calls as well as textual messages (SMS), therefore this class has two superclasses.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#CellPhoneNumber"></see></summary>
    let CellPhoneNumber =
        Namespaced_IRI.parse _namespace_name "CellPhoneNumber" |> NamespacedName

    /// <summary>
    /// A number that can accept textual messages.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#MessagingNumber"></see></summary>
    let MessagingNumber =
        Namespaced_IRI.parse _namespace_name "MessagingNumber" |> NamespacedName

    /// <summary>
    /// A Contact. A piece of data that can provide means to identify or communicate with an entity.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Contact"></see></summary>
    let Contact = Namespaced_IRI.parse _namespace_name "Contact" |> NamespacedName

    /// <summary>
    /// A group of Contacts. Could be used to express a group in an addressbook or on a contact list of an IM application. One contact can belong to many groups.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactGroup"></see></summary>
    let ContactGroup =
        Namespaced_IRI.parse _namespace_name "ContactGroup" |> NamespacedName

    /// <summary>
    /// A contact list, this class represents an addressbook or a contact list of an IM application. Contacts inside a contact list can belong to contact groups.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactList"></see></summary>
    let ContactList =
        Namespaced_IRI.parse _namespace_name "ContactList" |> NamespacedName

    /// <summary>
    /// An entity occuring on a contact list (usually interpreted as an nco:Contact)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactListDataObject"></see></summary>
    let ContactListDataObject =
        Namespaced_IRI.parse _namespace_name "ContactListDataObject" |> NamespacedName

    /// <summary>
    /// A superclass for all contact media - ways to contact an entity represented by a Contact instance. Some of the subclasses of this class (the various kinds of telephone numbers and postal addresses) have been inspired by the values of the TYPE parameter of ADR and TEL properties defined in RFC 2426 sec. 3.2.1. and 3.3.1 respectively. Each value is represented by an appropriate subclass with two major exceptions TYPE=home and TYPE=work. They are to be expressed by the roles these contact media are attached to i.e. contact media with TYPE=home parameter are to be attached to the default role (nco:Contact or nco:PersonContact), whereas media with TYPE=work parameter should be attached to nco:Affiliation or nco:OrganizationContact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactMedium"></see></summary>
    let ContactMedium =
        Namespaced_IRI.parse _namespace_name "ContactMedium" |> NamespacedName

    /// <summary>
    /// Domestic Delivery Addresse. Class inspired by TYPE=dom parameter of the ADR property defined in RFC 2426 sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#DomesticDeliveryAddress"></see></summary>
    let DomesticDeliveryAddress =
        Namespaced_IRI.parse _namespace_name "DomesticDeliveryAddress" |> NamespacedName

    /// <summary>
    /// A postal address. A class aggregating the various parts of a value for the 'ADR' property as defined in RFC 2426 Sec. 3.2.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PostalAddress"></see></summary>
    let PostalAddress =
        Namespaced_IRI.parse _namespace_name "PostalAddress" |> NamespacedName

    /// <summary>
    /// An email address. The recommended best practice is to use mailto: uris for instances of this class.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#EmailAddress"></see></summary>
    let EmailAddress =
        Namespaced_IRI.parse _namespace_name "EmailAddress" |> NamespacedName

    /// <summary>
    /// A fax number. Inspired by the (TYPE=fax) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#FaxNumber"></see></summary>
    let FaxNumber = Namespaced_IRI.parse _namespace_name "FaxNumber" |> NamespacedName

    /// <summary>
    /// A telephone number.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PhoneNumber"></see></summary>
    let PhoneNumber =
        Namespaced_IRI.parse _namespace_name "PhoneNumber" |> NamespacedName

    /// <summary>
    /// Gender. Instances of this class may include male and female.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Gender"></see></summary>
    let Gender = Namespaced_IRI.parse _namespace_name "Gender" |> NamespacedName
    /// <summary>
    /// Instances of this class represent personal hobbies and interests.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Hobby"></see></summary>
    let Hobby = Namespaced_IRI.parse _namespace_name "Hobby" |> NamespacedName

    /// <summary>
    /// Capabilities of a cetain IMAccount.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMCapability"></see></summary>
    let IMCapability =
        Namespaced_IRI.parse _namespace_name "IMCapability" |> NamespacedName

    /// <summary>
    /// The status type of an IMAccount. Based on the Connection_Presence_Type enumeration of the Telepathy project: http://telepathy.freedesktop.org/spec/Connection_Interface_Simple_Presence.html#Enum:Connection_Presence_Type
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusType"></see></summary>
    let IMStatusType =
        Namespaced_IRI.parse _namespace_name "IMStatusType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeAvailable"></see>
    /// </summary>
    let IMStatusTypeAvailable =
        Namespaced_IRI.parse _namespace_name "IMStatusTypeAvailable" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeAway"></see>
    /// </summary>
    let IMStatusTypeAway =
        Namespaced_IRI.parse _namespace_name "IMStatusTypeAway" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeBusy"></see>
    /// </summary>
    let IMStatusTypeBusy =
        Namespaced_IRI.parse _namespace_name "IMStatusTypeBusy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeExtendedAway"></see>
    /// </summary>
    let IMStatusTypeExtendedAway =
        Namespaced_IRI.parse _namespace_name "IMStatusTypeExtendedAway" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeHidden"></see>
    /// </summary>
    let IMStatusTypeHidden =
        Namespaced_IRI.parse _namespace_name "IMStatusTypeHidden" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeOffline"></see>
    /// </summary>
    let IMStatusTypeOffline =
        Namespaced_IRI.parse _namespace_name "IMStatusTypeOffline" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeUnknown"></see>
    /// </summary>
    let IMStatusTypeUnknown =
        Namespaced_IRI.parse _namespace_name "IMStatusTypeUnknown" |> NamespacedName

    /// <summary>
    /// International Delivery Addresse. Class inspired by TYPE=intl parameter of the ADR property defined in RFC 2426 sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#InternationalDeliveryAddress"></see></summary>
    let InternationalDeliveryAddress =
        Namespaced_IRI.parse _namespace_name "InternationalDeliveryAddress" |> NamespacedName

    /// <summary>
    /// An ISDN phone number. Inspired by the (TYPE=isdn) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IsdnNumber"></see></summary>
    let IsdnNumber = Namespaced_IRI.parse _namespace_name "IsdnNumber" |> NamespacedName
    /// <summary>
    /// A class representing a contact's name. Possesses various attributes.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName

    /// <summary>
    /// A Contact that denotes on Organization.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#OrganizationContact"></see></summary>
    let OrganizationContact =
        Namespaced_IRI.parse _namespace_name "OrganizationContact" |> NamespacedName

    /// <summary>
    /// A pager phone number. Inspired by the (TYPE=pager) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PagerNumber"></see></summary>
    let PagerNumber =
        Namespaced_IRI.parse _namespace_name "PagerNumber" |> NamespacedName

    /// <summary>
    /// Parcel Delivery Addresse. Class inspired by TYPE=parcel parameter of the ADR property defined in RFC 2426 sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ParcelDeliveryAddress"></see></summary>
    let ParcelDeliveryAddress =
        Namespaced_IRI.parse _namespace_name "ParcelDeliveryAddress" |> NamespacedName

    /// <summary>
    /// Personal Communication Services Number. A class inspired by the TYPE=pcs parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PcsNumber"></see></summary>
    let PcsNumber = Namespaced_IRI.parse _namespace_name "PcsNumber" |> NamespacedName

    /// <summary>
    /// A Contact that denotes a Person. A person can have multiple Affiliations.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PersonContact"></see></summary>
    let PersonContact =
        Namespaced_IRI.parse _namespace_name "PersonContact" |> NamespacedName

    /// <summary>
    /// A class representing a person contact's name. Possesses various attributes.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PersonName"></see></summary>
    let PersonName = Namespaced_IRI.parse _namespace_name "PersonName" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of nco:imCapabilityVideo.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VideoIMAccount"></see></summary>
    let VideoIMAccount =
        Namespaced_IRI.parse _namespace_name "VideoIMAccount" |> NamespacedName

    /// <summary>
    /// A Video telephone number. A class inspired by the TYPE=video parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VideoTelephoneNumber"></see></summary>
    let VideoTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "VideoTelephoneNumber" |> NamespacedName

    /// <summary>
    /// The geographical location of a postal address.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#addressLocation"></see></summary>
    let addressLocation =
        Namespaced_IRI.parse _namespace_name "addressLocation" |> NamespacedName

    /// <summary>
    /// Indicates the age of a person contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#age"></see></summary>
    let age = Namespaced_IRI.parse _namespace_name "age" |> NamespacedName

    /// <summary>
    /// Links a Contact with a ContactGroup it belongs to.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#belongsToGroup"></see></summary>
    let belongsToGroup =
        Namespaced_IRI.parse _namespace_name "belongsToGroup" |> NamespacedName

    /// <summary>
    /// Birth date of the object represented by this Contact. An equivalent of the 'BDAY' property as defined in RFC 2426 Sec. 3.1.5.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#birthDate"></see></summary>
    let birthDate = Namespaced_IRI.parse _namespace_name "birthDate" |> NamespacedName
    /// <summary>
    /// A Blog url.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#blogUrl"></see></summary>
    let blogUrl = Namespaced_IRI.parse _namespace_name "blogUrl" |> NamespacedName
    /// <summary>
    /// A uniform resource locator associated with the given role of a Contact. Inspired by the 'URL' property defined in RFC 2426 Sec. 3.6.8.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName

    /// <summary>
    /// The name of the contact group. This property was NOT defined
    ///     in the VCARD standard. See documentation of the 'ContactGroup' class for
    ///     details
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactGroupName"></see></summary>
    let contactGroupName =
        Namespaced_IRI.parse _namespace_name "contactGroupName" |> NamespacedName

    /// <summary>
    /// A comment about the contact medium. (Deprecated in favor of nie:comment or nao:description - based on the context)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactMediumComment"></see></summary>
    let contactMediumComment =
        Namespaced_IRI.parse _namespace_name "contactMediumComment" |> NamespacedName

    /// <summary>
    /// A value that represents a globally unique  identifier corresponding to the individual or resource associated with the Contact. An equivalent of the 'UID' property defined in RFC 2426 Sec. 3.6.7
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactUID"></see></summary>
    let contactUID = Namespaced_IRI.parse _namespace_name "contactUID" |> NamespacedName

    /// <summary>
    /// A property used to group contacts into contact groups. This
    ///     property was NOT defined in the VCARD standard. See documentation for the
    ///     'ContactList' class for details
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#containsContact"></see></summary>
    let containsContact =
        Namespaced_IRI.parse _namespace_name "containsContact" |> NamespacedName

    /// <summary>
    /// An entity responsible for making contributions to the content of the InformationElement.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contributor"></see></summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    /// A part of an address specyfing the country. Inspired by the seventh part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName
    /// <summary>
    /// Creator of an information element, an entity primarily responsible for the creation of the content of the data object.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName
    /// <summary>
    /// Department. The organizational unit within the organization.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#department"></see></summary>
    let department = Namespaced_IRI.parse _namespace_name "department" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#emailAddress"></see>
    /// </summary>
    let emailAddress =
        Namespaced_IRI.parse _namespace_name "emailAddress" |> NamespacedName

    /// <summary>
    /// End datetime for the role, such as: the datetime of leaving a project or organization, datetime of ending employment, datetime of divorce. If absent or set to a date in the future, the role is currently active.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#end"></see></summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName

    /// <summary>
    /// An extended part of an address. This field might be used to express parts of an address that aren't include in the name of the Contact but also aren't part of the actual location. Usually the streed address and following fields are enough for a postal letter to arrive. Examples may include ('University of California Campus building 45', 'Sears Tower 34th floor' etc.) Inspired by the second part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#extendedAddress"></see></summary>
    let extendedAddress =
        Namespaced_IRI.parse _namespace_name "extendedAddress" |> NamespacedName

    /// <summary>
    /// A Female
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#female"></see></summary>
    let female = Namespaced_IRI.parse _namespace_name "female" |> NamespacedName
    /// <summary>
    /// The URL of the FOAF file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#foafUrl"></see></summary>
    let foafUrl = Namespaced_IRI.parse _namespace_name "foafUrl" |> NamespacedName
    /// <summary>
    /// To specify the formatted text corresponding to the name of the object the Contact represents. An equivalent of the FN property as defined in RFC 2426 Sec. 3.1.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#fullname"></see></summary>
    let fullname = Namespaced_IRI.parse _namespace_name "fullname" |> NamespacedName
    /// <summary>
    /// Gender of the given contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#gender"></see></summary>
    let gender = Namespaced_IRI.parse _namespace_name "gender" |> NamespacedName

    /// <summary>
    /// Links a PersonContact with an Affiliation.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasAffiliation"></see></summary>
    let hasAffiliation =
        Namespaced_IRI.parse _namespace_name "hasAffiliation" |> NamespacedName

    /// <summary>
    /// Attaches birth date information to a person contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasBirthDate"></see></summary>
    let hasBirthDate =
        Namespaced_IRI.parse _namespace_name "hasBirthDate" |> NamespacedName

    /// <summary>
    /// A superProperty for all properties linking a Contact to an instance of a contact medium.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasContactMedium"></see></summary>
    let hasContactMedium =
        Namespaced_IRI.parse _namespace_name "hasContactMedium" |> NamespacedName

    /// <summary>
    /// A generic contact attribute introduced in order to enable customisation of contact details. Thus, systems using the NCO to model contact and person information, can introduce customised attributes by creating them as a subproperty of this one.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasCustomAttribute"></see></summary>
    let hasCustomAttribute =
        Namespaced_IRI.parse _namespace_name "hasCustomAttribute" |> NamespacedName

    /// <summary>
    /// An address for electronic mail communication with the object specified by this contact. An equivalent of the 'EMAIL' property as defined in RFC 2426 Sec. 3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasEmailAddress"></see></summary>
    let hasEmailAddress =
        Namespaced_IRI.parse _namespace_name "hasEmailAddress" |> NamespacedName

    /// <summary>
    /// Indicates that an Instant Messaging account owned by an entity represented by this contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasIMAccount"></see></summary>
    let hasIMAccount =
        Namespaced_IRI.parse _namespace_name "hasIMAccount" |> NamespacedName

    /// <summary>
    /// Indicates that an IMAccount has a certain capability.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasIMCapability"></see></summary>
    let hasIMCapability =
        Namespaced_IRI.parse _namespace_name "hasIMCapability" |> NamespacedName

    /// <summary>
    /// Geographical location of the contact. Inspired by the 'GEO' property specified in RFC 2426 Sec. 3.4.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// Attaches name information to a contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasName"></see></summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    /// Attaches name information to a person contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPersonName"></see></summary>
    let hasPersonName =
        Namespaced_IRI.parse _namespace_name "hasPersonName" |> NamespacedName

    /// <summary>
    /// A number for telephony communication with the object represented by this Contact. An equivalent of the 'TEL' property defined in RFC 2426 Sec. 3.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPhoneNumber"></see></summary>
    let hasPhoneNumber =
        Namespaced_IRI.parse _namespace_name "hasPhoneNumber" |> NamespacedName

    /// <summary>
    /// The default Address for a Contact. An equivalent of the 'ADR' property as defined in RFC 2426 Sec. 3.2.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPostalAddress"></see></summary>
    let hasPostalAddress =
        Namespaced_IRI.parse _namespace_name "hasPostalAddress" |> NamespacedName

    /// <summary>
    /// A hobby associated with a PersonContact. This property can be used to express hobbies and interests.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hobby"></see></summary>
    let hobby = Namespaced_IRI.parse _namespace_name "hobby" |> NamespacedName

    /// <summary>
    /// Type of the IM account. This may be the name of the service that provides the IM functionality. Examples might include Jabber, ICQ, MSN etc
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imAccountType"></see></summary>
    let imAccountType =
        Namespaced_IRI.parse _namespace_name "imAccountType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityAudio"></see>
    /// </summary>
    let imCapabilityAudio =
        Namespaced_IRI.parse _namespace_name "imCapabilityAudio" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityText"></see>
    /// </summary>
    let imCapabilityText =
        Namespaced_IRI.parse _namespace_name "imCapabilityText" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityVideo"></see>
    /// </summary>
    let imCapabilityVideo =
        Namespaced_IRI.parse _namespace_name "imCapabilityVideo" |> NamespacedName

    /// <summary>
    /// Identifier of the IM account. Examples of such identifier might include ICQ UINs, Jabber IDs, Skype names etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imID"></see></summary>
    let imID = Namespaced_IRI.parse _namespace_name "imID" |> NamespacedName
    /// <summary>
    /// A nickname attached to a particular IM Account.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imNickname"></see></summary>
    let imNickname = Namespaced_IRI.parse _namespace_name "imNickname" |> NamespacedName
    /// <summary>
    /// Current status of the given IM account. When this property is set, the nco:imStatusType should also always be set. Applications should attempt to parse this property to determine the presence, only falling back to the nco:imStatusType property in the case that this property's value is unrecognised. Values for this property may include 'available', 'offline', 'busy' etc. The exact choice of them is unspecified, although it is recommended to follow the guidance of the Telepathy project when choosing a string identifier http://telepathy.freedesktop.org/spec/Connection_Interface_Simple_Presence.html#description
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatus"></see></summary>
    let imStatus = Namespaced_IRI.parse _namespace_name "imStatus" |> NamespacedName

    /// <summary>
    /// A feature common in most IM systems. A message left by the user for all his/her contacts to see.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatusMessage"></see></summary>
    let imStatusMessage =
        Namespaced_IRI.parse _namespace_name "imStatusMessage" |> NamespacedName

    /// <summary>
    /// Current status type of the given IM account. When this property is set, the nco:imStatus property should also always be set. Applications should attempt to parse the nco:imStatus property to determine the presence, only falling back to this property in the case that the nco:imStatus property's value is unrecognised.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatusType"></see></summary>
    let imStatusType =
        Namespaced_IRI.parse _namespace_name "imStatusType" |> NamespacedName

    /// <summary>
    /// Indicates the local IMAccount by which this IMAccount is accessed. This does not imply membership of a contact list.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#isAccessedBy"></see></summary>
    let isAccessedBy =
        Namespaced_IRI.parse _namespace_name "isAccessedBy" |> NamespacedName

    /// <summary>
    /// Indicates that this IMAccount has been blocked.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#isBlocked"></see></summary>
    let isBlocked = Namespaced_IRI.parse _namespace_name "isBlocked" |> NamespacedName
    /// <summary>
    /// An encryption key attached to a contact. Inspired by the KEY property defined in RFC 2426 sec. 3.7.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#key"></see></summary>
    let key = Namespaced_IRI.parse _namespace_name "key" |> NamespacedName
    /// <summary>
    /// Locality or City. Inspired by the fourth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#locality"></see></summary>
    let locality = Namespaced_IRI.parse _namespace_name "locality" |> NamespacedName
    /// <summary>
    /// Logo of a company. Inspired by the LOGO property defined in RFC 2426 sec. 3.5.3
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#logo"></see></summary>
    let logo = Namespaced_IRI.parse _namespace_name "logo" |> NamespacedName
    /// <summary>
    /// A Male
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#male"></see></summary>
    let male = Namespaced_IRI.parse _namespace_name "male" |> NamespacedName

    /// <summary>
    /// Additional given name of an object represented by this contact. See documentation for 'nameFamily' property for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameAdditional"></see></summary>
    let nameAdditional =
        Namespaced_IRI.parse _namespace_name "nameAdditional" |> NamespacedName

    /// <summary>
    /// The family name of an Object represented by this Contact. These applies to people that have more than one given name. The 'first' one is considered 'the' given name (see nameGiven) property. All additional ones are considered 'additional' names. The name inherited from parents is the 'family name'. e.g. For Dr. John Phil Paul Stevenson Jr. M.D. A.C.P. we have contact with: honorificPrefix: 'Dr.', nameGiven: 'John', nameAdditional: 'Phil', nameAdditional: 'Paul', nameFamily: 'Stevenson', honorificSuffix: 'Jr.', honorificSuffix: 'M.D.', honorificSuffix: 'A.C.P.'. These properties form an equivalent of the compound 'N' property as defined in RFC 2426 Sec. 3.1.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameFamily"></see></summary>
    let nameFamily = Namespaced_IRI.parse _namespace_name "nameFamily" |> NamespacedName
    /// <summary>
    /// The given name for the object represented by this Contact. See documentation for 'nameFamily' property for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameGiven"></see></summary>
    let nameGiven = Namespaced_IRI.parse _namespace_name "nameGiven" |> NamespacedName

    /// <summary>
    /// A prefix for the name of the object represented by this Contact. See documentation for the 'nameFamily' property for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameHonorificPrefix"></see></summary>
    let nameHonorificPrefix =
        Namespaced_IRI.parse _namespace_name "nameHonorificPrefix" |> NamespacedName

    /// <summary>
    /// A suffix for the name of the Object represented by the given object. See documentation for the 'nameFamily' for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameHonorificSuffix"></see></summary>
    let nameHonorificSuffix =
        Namespaced_IRI.parse _namespace_name "nameHonorificSuffix" |> NamespacedName

    /// <summary>
    /// A nickname of the Object represented by this Contact. This is an equivalent of the 'NICKNAME' property as defined in RFC 2426 Sec. 3.1.3.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nickname"></see></summary>
    let nickname = Namespaced_IRI.parse _namespace_name "nickname" |> NamespacedName
    /// <summary>
    /// A note about the object represented by this Contact. An equivalent for the 'NOTE' property defined in RFC 2426 Sec. 3.6.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#note"></see></summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    /// Name of an organization or a unit within an organization the object represented by a Contact is associated with. An equivalent of the 'ORG' property defined in RFC 2426 Sec. 3.5.5
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#org"></see></summary>
    let org = Namespaced_IRI.parse _namespace_name "org" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#phoneNumber"></see>
    /// </summary>
    let phoneNumber =
        Namespaced_IRI.parse _namespace_name "phoneNumber" |> NamespacedName

    /// <summary>
    /// Photograph attached to a Contact. The DataObject referred to by this property is usually interpreted as an nfo:Image. Inspired by the PHOTO property defined in RFC 2426 sec. 3.1.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#photo"></see></summary>
    let photo = Namespaced_IRI.parse _namespace_name "photo" |> NamespacedName
    /// <summary>
    /// Post office box. This is the first part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#pobox"></see></summary>
    let pobox = Namespaced_IRI.parse _namespace_name "pobox" |> NamespacedName
    /// <summary>
    /// Postal Code. Inspired by the sixth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#postalcode"></see></summary>
    let postalcode = Namespaced_IRI.parse _namespace_name "postalcode" |> NamespacedName
    /// <summary>
    /// An entity responsible for making the InformationElement available.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    /// Indicates that this IMAccount publishes its presence information to the other IMAccount.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#publishesPresenceTo"></see></summary>
    let publishesPresenceTo =
        Namespaced_IRI.parse _namespace_name "publishesPresenceTo" |> NamespacedName

    /// <summary>
    /// Region. Inspired by the fifth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName

    /// <summary>
    /// An object that represent an object represented by this Contact. Usually this property is used to link a Contact to an organization, to a contact to the representative of this organization the user directly interacts with. An equivalent for the 'AGENT' property defined in RFC 2426 Sec. 3.5.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#representative"></see></summary>
    let representative =
        Namespaced_IRI.parse _namespace_name "representative" |> NamespacedName

    /// <summary>
    /// Indicates that this IMAccount has requested a subscription to the presence information of the other IMAccount.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#requestedPresenceSubscriptionTo"></see></summary>
    let requestedPresenceSubscriptionTo =
        Namespaced_IRI.parse _namespace_name "requestedPresenceSubscriptionTo" |> NamespacedName

    /// <summary>
    /// Role an object represented by this contact represents in the organization. This might include 'Programmer', 'Manager', 'Sales Representative'. Be careful to avoid confusion with the title property. An equivalent of the 'ROLE' property as defined in RFC 2426. Sec. 3.5.2. Note the difference between nco:Role class and nco:role property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    /// Sound clip attached to a Contact. The DataObject referred to by this property is usually interpreted as an nfo:Audio. Inspired by the SOUND property defined in RFC 2425 sec. 3.6.6.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#sound"></see></summary>
    let sound = Namespaced_IRI.parse _namespace_name "sound" |> NamespacedName
    /// <summary>
    /// Start datetime for the role, such as: the datetime of joining a project or organization, datetime of starting employment, datetime of marriage
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#start"></see></summary>
    let start = Namespaced_IRI.parse _namespace_name "start" |> NamespacedName

    /// <summary>
    /// The streed address. Inspired by the third part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#streetAddress"></see></summary>
    let streetAddress =
        Namespaced_IRI.parse _namespace_name "streetAddress" |> NamespacedName

    /// <summary>
    /// The official title  the object represented by this contact in an organization. E.g. 'CEO', 'Director, Research and Development', 'Junior Software Developer/Analyst' etc. An equivalent of the 'TITLE' property defined in RFC 2426 Sec. 3.5.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// Indicates if the given number accepts voice mail. (e.g. there is an answering machine). Inspired by TYPE=msg parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#voiceMail"></see></summary>
    let voiceMail = Namespaced_IRI.parse _namespace_name "voiceMail" |> NamespacedName
    /// <summary>
    /// A url of a website.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#websiteUrl"></see></summary>
    let websiteUrl = Namespaced_IRI.parse _namespace_name "websiteUrl" |> NamespacedName
