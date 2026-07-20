namespace http.www.semanticdesktop.org.ontologies._2007._03._22.nco.hash

open DoxAletheia

module nco =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/03/22/nco#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Aggregates three properties defined in RFC2426. Originally all three were attached directly to a person. One person could have only one title and one role within one organization. This class is intended to lift this limitation.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Affiliation"></see></summary>
    let Affiliation = _prefix "Affiliation"
    /// <summary>
    /// A role played by a contact. Contacts that denote people, can have many roles (e.g. see the hasAffiliation property and Affiliation class). Contacts that denote Organizations or other Agents usually have one role.  Each role can introduce additional contact media.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// Deprecated in favour of nco:imCapabilityAudio.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#AudioIMAccount"></see></summary>
    let AudioIMAccount = _prefix "AudioIMAccount"
    /// <summary>
    /// An account in an Instant Messaging system.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMAccount"></see></summary>
    let IMAccount = _prefix "IMAccount"
    /// <summary>
    /// A Bulletin Board System (BBS) phone number. Inspired by the (TYPE=bbsl) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#BbsNumber"></see></summary>
    let BbsNumber = _prefix "BbsNumber"
    /// <summary>
    /// A modem phone number. Inspired by the (TYPE=modem) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ModemNumber"></see></summary>
    let ModemNumber = _prefix "ModemNumber"
    /// <summary>
    /// A class representing a person contact's birth date information. Possesses various attributes.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#BirthDate"></see></summary>
    let BirthDate = _prefix "BirthDate"
    /// <summary>
    /// A car phone number. Inspired by the (TYPE=car) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#CarPhoneNumber"></see></summary>
    let CarPhoneNumber = _prefix "CarPhoneNumber"
    /// <summary>
    /// A telephone number with voice communication capabilities. Class inspired by the TYPE=voice parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VoicePhoneNumber"></see></summary>
    let VoicePhoneNumber = _prefix "VoicePhoneNumber"
    /// <summary>
    /// A cellular phone number. Inspired by the (TYPE=cell) parameter of the TEL property as defined in RFC 2426 sec  3.3.1. Usually a cellular phone can accept voice calls as well as textual messages (SMS), therefore this class has two superclasses.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#CellPhoneNumber"></see></summary>
    let CellPhoneNumber = _prefix "CellPhoneNumber"
    /// <summary>
    /// A number that can accept textual messages.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#MessagingNumber"></see></summary>
    let MessagingNumber = _prefix "MessagingNumber"
    /// <summary>
    /// A Contact. A piece of data that can provide means to identify or communicate with an entity.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Contact"></see></summary>
    let Contact = _prefix "Contact"
    /// <summary>
    /// A group of Contacts. Could be used to express a group in an addressbook or on a contact list of an IM application. One contact can belong to many groups.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactGroup"></see></summary>
    let ContactGroup = _prefix "ContactGroup"
    /// <summary>
    /// A contact list, this class represents an addressbook or a contact list of an IM application. Contacts inside a contact list can belong to contact groups.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactList"></see></summary>
    let ContactList = _prefix "ContactList"
    /// <summary>
    /// An entity occuring on a contact list (usually interpreted as an nco:Contact)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactListDataObject"></see></summary>
    let ContactListDataObject = _prefix "ContactListDataObject"
    /// <summary>
    /// A superclass for all contact media - ways to contact an entity represented by a Contact instance. Some of the subclasses of this class (the various kinds of telephone numbers and postal addresses) have been inspired by the values of the TYPE parameter of ADR and TEL properties defined in RFC 2426 sec. 3.2.1. and 3.3.1 respectively. Each value is represented by an appropriate subclass with two major exceptions TYPE=home and TYPE=work. They are to be expressed by the roles these contact media are attached to i.e. contact media with TYPE=home parameter are to be attached to the default role (nco:Contact or nco:PersonContact), whereas media with TYPE=work parameter should be attached to nco:Affiliation or nco:OrganizationContact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactMedium"></see></summary>
    let ContactMedium = _prefix "ContactMedium"
    /// <summary>
    /// Domestic Delivery Addresse. Class inspired by TYPE=dom parameter of the ADR property defined in RFC 2426 sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#DomesticDeliveryAddress"></see></summary>
    let DomesticDeliveryAddress = _prefix "DomesticDeliveryAddress"
    /// <summary>
    /// A postal address. A class aggregating the various parts of a value for the 'ADR' property as defined in RFC 2426 Sec. 3.2.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PostalAddress"></see></summary>
    let PostalAddress = _prefix "PostalAddress"
    /// <summary>
    /// An email address. The recommended best practice is to use mailto: uris for instances of this class.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#EmailAddress"></see></summary>
    let EmailAddress = _prefix "EmailAddress"
    /// <summary>
    /// A fax number. Inspired by the (TYPE=fax) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#FaxNumber"></see></summary>
    let FaxNumber = _prefix "FaxNumber"
    /// <summary>
    /// A telephone number.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PhoneNumber"></see></summary>
    let PhoneNumber = _prefix "PhoneNumber"
    /// <summary>
    /// Gender. Instances of this class may include male and female.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Gender"></see></summary>
    let Gender = _prefix "Gender"
    /// <summary>
    /// Instances of this class represent personal hobbies and interests.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Hobby"></see></summary>
    let Hobby = _prefix "Hobby"
    /// <summary>
    /// Capabilities of a cetain IMAccount.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMCapability"></see></summary>
    let IMCapability = _prefix "IMCapability"
    /// <summary>
    /// The status type of an IMAccount. Based on the Connection_Presence_Type enumeration of the Telepathy project: http://telepathy.freedesktop.org/spec/Connection_Interface_Simple_Presence.html#Enum:Connection_Presence_Type
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusType"></see></summary>
    let IMStatusType = _prefix "IMStatusType"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeAvailable"></see>
    /// </summary>
    let IMStatusTypeAvailable = _prefix "IMStatusTypeAvailable"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeAway"></see>
    /// </summary>
    let IMStatusTypeAway = _prefix "IMStatusTypeAway"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeBusy"></see>
    /// </summary>
    let IMStatusTypeBusy = _prefix "IMStatusTypeBusy"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeExtendedAway"></see>
    /// </summary>
    let IMStatusTypeExtendedAway = _prefix "IMStatusTypeExtendedAway"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeHidden"></see>
    /// </summary>
    let IMStatusTypeHidden = _prefix "IMStatusTypeHidden"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeOffline"></see>
    /// </summary>
    let IMStatusTypeOffline = _prefix "IMStatusTypeOffline"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeUnknown"></see>
    /// </summary>
    let IMStatusTypeUnknown = _prefix "IMStatusTypeUnknown"
    /// <summary>
    /// International Delivery Addresse. Class inspired by TYPE=intl parameter of the ADR property defined in RFC 2426 sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#InternationalDeliveryAddress"></see></summary>
    let InternationalDeliveryAddress = _prefix "InternationalDeliveryAddress"
    /// <summary>
    /// An ISDN phone number. Inspired by the (TYPE=isdn) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IsdnNumber"></see></summary>
    let IsdnNumber = _prefix "IsdnNumber"
    /// <summary>
    /// A class representing a contact's name. Possesses various attributes.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    /// A Contact that denotes on Organization.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#OrganizationContact"></see></summary>
    let OrganizationContact = _prefix "OrganizationContact"
    /// <summary>
    /// A pager phone number. Inspired by the (TYPE=pager) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PagerNumber"></see></summary>
    let PagerNumber = _prefix "PagerNumber"
    /// <summary>
    /// Parcel Delivery Addresse. Class inspired by TYPE=parcel parameter of the ADR property defined in RFC 2426 sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ParcelDeliveryAddress"></see></summary>
    let ParcelDeliveryAddress = _prefix "ParcelDeliveryAddress"
    /// <summary>
    /// Personal Communication Services Number. A class inspired by the TYPE=pcs parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PcsNumber"></see></summary>
    let PcsNumber = _prefix "PcsNumber"
    /// <summary>
    /// A Contact that denotes a Person. A person can have multiple Affiliations.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PersonContact"></see></summary>
    let PersonContact = _prefix "PersonContact"
    /// <summary>
    /// A class representing a person contact's name. Possesses various attributes.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PersonName"></see></summary>
    let PersonName = _prefix "PersonName"
    /// <summary>
    /// Deprecated in favour of nco:imCapabilityVideo.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VideoIMAccount"></see></summary>
    let VideoIMAccount = _prefix "VideoIMAccount"
    /// <summary>
    /// A Video telephone number. A class inspired by the TYPE=video parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VideoTelephoneNumber"></see></summary>
    let VideoTelephoneNumber = _prefix "VideoTelephoneNumber"
    /// <summary>
    /// The geographical location of a postal address.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#addressLocation"></see></summary>
    let addressLocation = _prefix "addressLocation"
    /// <summary>
    /// Indicates the age of a person contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#age"></see></summary>
    let age = _prefix "age"
    /// <summary>
    /// Links a Contact with a ContactGroup it belongs to.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#belongsToGroup"></see></summary>
    let belongsToGroup = _prefix "belongsToGroup"
    /// <summary>
    /// Birth date of the object represented by this Contact. An equivalent of the 'BDAY' property as defined in RFC 2426 Sec. 3.1.5.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#birthDate"></see></summary>
    let birthDate = _prefix "birthDate"
    /// <summary>
    /// A Blog url.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#blogUrl"></see></summary>
    let blogUrl = _prefix "blogUrl"
    /// <summary>
    /// A uniform resource locator associated with the given role of a Contact. Inspired by the 'URL' property defined in RFC 2426 Sec. 3.6.8.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// The name of the contact group. This property was NOT defined
    ///     in the VCARD standard. See documentation of the 'ContactGroup' class for
    ///     details
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactGroupName"></see></summary>
    let contactGroupName = _prefix "contactGroupName"
    /// <summary>
    /// A comment about the contact medium. (Deprecated in favor of nie:comment or nao:description - based on the context)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactMediumComment"></see></summary>
    let contactMediumComment = _prefix "contactMediumComment"
    /// <summary>
    /// A value that represents a globally unique  identifier corresponding to the individual or resource associated with the Contact. An equivalent of the 'UID' property defined in RFC 2426 Sec. 3.6.7
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactUID"></see></summary>
    let contactUID = _prefix "contactUID"
    /// <summary>
    /// A property used to group contacts into contact groups. This
    ///     property was NOT defined in the VCARD standard. See documentation for the
    ///     'ContactList' class for details
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#containsContact"></see></summary>
    let containsContact = _prefix "containsContact"
    /// <summary>
    /// An entity responsible for making contributions to the content of the InformationElement.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contributor"></see></summary>
    let contributor = _prefix "contributor"
    /// <summary>
    /// A part of an address specyfing the country. Inspired by the seventh part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    /// Creator of an information element, an entity primarily responsible for the creation of the content of the data object.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// Department. The organizational unit within the organization.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#department"></see></summary>
    let department = _prefix "department"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#emailAddress"></see>
    /// </summary>
    let emailAddress = _prefix "emailAddress"
    /// <summary>
    /// End datetime for the role, such as: the datetime of leaving a project or organization, datetime of ending employment, datetime of divorce. If absent or set to a date in the future, the role is currently active.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#end"></see></summary>
    let end_ = _prefix "end"
    /// <summary>
    /// An extended part of an address. This field might be used to express parts of an address that aren't include in the name of the Contact but also aren't part of the actual location. Usually the streed address and following fields are enough for a postal letter to arrive. Examples may include ('University of California Campus building 45', 'Sears Tower 34th floor' etc.) Inspired by the second part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#extendedAddress"></see></summary>
    let extendedAddress = _prefix "extendedAddress"
    /// <summary>
    /// A Female
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#female"></see></summary>
    let female = _prefix "female"
    /// <summary>
    /// The URL of the FOAF file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#foafUrl"></see></summary>
    let foafUrl = _prefix "foafUrl"
    /// <summary>
    /// To specify the formatted text corresponding to the name of the object the Contact represents. An equivalent of the FN property as defined in RFC 2426 Sec. 3.1.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#fullname"></see></summary>
    let fullname = _prefix "fullname"
    /// <summary>
    /// Gender of the given contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#gender"></see></summary>
    let gender = _prefix "gender"
    /// <summary>
    /// Links a PersonContact with an Affiliation.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasAffiliation"></see></summary>
    let hasAffiliation = _prefix "hasAffiliation"
    /// <summary>
    /// Attaches birth date information to a person contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasBirthDate"></see></summary>
    let hasBirthDate = _prefix "hasBirthDate"
    /// <summary>
    /// A superProperty for all properties linking a Contact to an instance of a contact medium.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasContactMedium"></see></summary>
    let hasContactMedium = _prefix "hasContactMedium"
    /// <summary>
    /// A generic contact attribute introduced in order to enable customisation of contact details. Thus, systems using the NCO to model contact and person information, can introduce customised attributes by creating them as a subproperty of this one.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasCustomAttribute"></see></summary>
    let hasCustomAttribute = _prefix "hasCustomAttribute"
    /// <summary>
    /// An address for electronic mail communication with the object specified by this contact. An equivalent of the 'EMAIL' property as defined in RFC 2426 Sec. 3.3.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasEmailAddress"></see></summary>
    let hasEmailAddress = _prefix "hasEmailAddress"
    /// <summary>
    /// Indicates that an Instant Messaging account owned by an entity represented by this contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasIMAccount"></see></summary>
    let hasIMAccount = _prefix "hasIMAccount"
    /// <summary>
    /// Indicates that an IMAccount has a certain capability.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasIMCapability"></see></summary>
    let hasIMCapability = _prefix "hasIMCapability"
    /// <summary>
    /// Geographical location of the contact. Inspired by the 'GEO' property specified in RFC 2426 Sec. 3.4.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// Attaches name information to a contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasName"></see></summary>
    let hasName = _prefix "hasName"
    /// <summary>
    /// Attaches name information to a person contact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPersonName"></see></summary>
    let hasPersonName = _prefix "hasPersonName"
    /// <summary>
    /// A number for telephony communication with the object represented by this Contact. An equivalent of the 'TEL' property defined in RFC 2426 Sec. 3.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPhoneNumber"></see></summary>
    let hasPhoneNumber = _prefix "hasPhoneNumber"
    /// <summary>
    /// The default Address for a Contact. An equivalent of the 'ADR' property as defined in RFC 2426 Sec. 3.2.1.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPostalAddress"></see></summary>
    let hasPostalAddress = _prefix "hasPostalAddress"
    /// <summary>
    /// A hobby associated with a PersonContact. This property can be used to express hobbies and interests.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hobby"></see></summary>
    let hobby = _prefix "hobby"
    /// <summary>
    /// Type of the IM account. This may be the name of the service that provides the IM functionality. Examples might include Jabber, ICQ, MSN etc
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imAccountType"></see></summary>
    let imAccountType = _prefix "imAccountType"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityAudio"></see>
    /// </summary>
    let imCapabilityAudio = _prefix "imCapabilityAudio"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityText"></see>
    /// </summary>
    let imCapabilityText = _prefix "imCapabilityText"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityVideo"></see>
    /// </summary>
    let imCapabilityVideo = _prefix "imCapabilityVideo"
    /// <summary>
    /// Identifier of the IM account. Examples of such identifier might include ICQ UINs, Jabber IDs, Skype names etc.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imID"></see></summary>
    let imID = _prefix "imID"
    /// <summary>
    /// A nickname attached to a particular IM Account.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imNickname"></see></summary>
    let imNickname = _prefix "imNickname"
    /// <summary>
    /// Current status of the given IM account. When this property is set, the nco:imStatusType should also always be set. Applications should attempt to parse this property to determine the presence, only falling back to the nco:imStatusType property in the case that this property's value is unrecognised. Values for this property may include 'available', 'offline', 'busy' etc. The exact choice of them is unspecified, although it is recommended to follow the guidance of the Telepathy project when choosing a string identifier http://telepathy.freedesktop.org/spec/Connection_Interface_Simple_Presence.html#description
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatus"></see></summary>
    let imStatus = _prefix "imStatus"
    /// <summary>
    /// A feature common in most IM systems. A message left by the user for all his/her contacts to see.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatusMessage"></see></summary>
    let imStatusMessage = _prefix "imStatusMessage"
    /// <summary>
    /// Current status type of the given IM account. When this property is set, the nco:imStatus property should also always be set. Applications should attempt to parse the nco:imStatus property to determine the presence, only falling back to this property in the case that the nco:imStatus property's value is unrecognised.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatusType"></see></summary>
    let imStatusType = _prefix "imStatusType"
    /// <summary>
    /// Indicates the local IMAccount by which this IMAccount is accessed. This does not imply membership of a contact list.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#isAccessedBy"></see></summary>
    let isAccessedBy = _prefix "isAccessedBy"
    /// <summary>
    /// Indicates that this IMAccount has been blocked.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#isBlocked"></see></summary>
    let isBlocked = _prefix "isBlocked"
    /// <summary>
    /// An encryption key attached to a contact. Inspired by the KEY property defined in RFC 2426 sec. 3.7.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#key"></see></summary>
    let key = _prefix "key"
    /// <summary>
    /// Locality or City. Inspired by the fourth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#locality"></see></summary>
    let locality = _prefix "locality"
    /// <summary>
    /// Logo of a company. Inspired by the LOGO property defined in RFC 2426 sec. 3.5.3
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#logo"></see></summary>
    let logo = _prefix "logo"
    /// <summary>
    /// A Male
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#male"></see></summary>
    let male = _prefix "male"
    /// <summary>
    /// Additional given name of an object represented by this contact. See documentation for 'nameFamily' property for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameAdditional"></see></summary>
    let nameAdditional = _prefix "nameAdditional"
    /// <summary>
    /// The family name of an Object represented by this Contact. These applies to people that have more than one given name. The 'first' one is considered 'the' given name (see nameGiven) property. All additional ones are considered 'additional' names. The name inherited from parents is the 'family name'. e.g. For Dr. John Phil Paul Stevenson Jr. M.D. A.C.P. we have contact with: honorificPrefix: 'Dr.', nameGiven: 'John', nameAdditional: 'Phil', nameAdditional: 'Paul', nameFamily: 'Stevenson', honorificSuffix: 'Jr.', honorificSuffix: 'M.D.', honorificSuffix: 'A.C.P.'. These properties form an equivalent of the compound 'N' property as defined in RFC 2426 Sec. 3.1.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameFamily"></see></summary>
    let nameFamily = _prefix "nameFamily"
    /// <summary>
    /// The given name for the object represented by this Contact. See documentation for 'nameFamily' property for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameGiven"></see></summary>
    let nameGiven = _prefix "nameGiven"
    /// <summary>
    /// A prefix for the name of the object represented by this Contact. See documentation for the 'nameFamily' property for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameHonorificPrefix"></see></summary>
    let nameHonorificPrefix = _prefix "nameHonorificPrefix"
    /// <summary>
    /// A suffix for the name of the Object represented by the given object. See documentation for the 'nameFamily' for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameHonorificSuffix"></see></summary>
    let nameHonorificSuffix = _prefix "nameHonorificSuffix"
    /// <summary>
    /// A nickname of the Object represented by this Contact. This is an equivalent of the 'NICKNAME' property as defined in RFC 2426 Sec. 3.1.3.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nickname"></see></summary>
    let nickname = _prefix "nickname"
    /// <summary>
    /// A note about the object represented by this Contact. An equivalent for the 'NOTE' property defined in RFC 2426 Sec. 3.6.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#note"></see></summary>
    let note = _prefix "note"
    /// <summary>
    /// Name of an organization or a unit within an organization the object represented by a Contact is associated with. An equivalent of the 'ORG' property defined in RFC 2426 Sec. 3.5.5
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#org"></see></summary>
    let org = _prefix "org"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#phoneNumber"></see>
    /// </summary>
    let phoneNumber = _prefix "phoneNumber"
    /// <summary>
    /// Photograph attached to a Contact. The DataObject referred to by this property is usually interpreted as an nfo:Image. Inspired by the PHOTO property defined in RFC 2426 sec. 3.1.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#photo"></see></summary>
    let photo = _prefix "photo"
    /// <summary>
    /// Post office box. This is the first part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#pobox"></see></summary>
    let pobox = _prefix "pobox"
    /// <summary>
    /// Postal Code. Inspired by the sixth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#postalcode"></see></summary>
    let postalcode = _prefix "postalcode"
    /// <summary>
    /// An entity responsible for making the InformationElement available.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// Indicates that this IMAccount publishes its presence information to the other IMAccount.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#publishesPresenceTo"></see></summary>
    let publishesPresenceTo = _prefix "publishesPresenceTo"
    /// <summary>
    /// Region. Inspired by the fifth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#region"></see></summary>
    let region = _prefix "region"
    /// <summary>
    /// An object that represent an object represented by this Contact. Usually this property is used to link a Contact to an organization, to a contact to the representative of this organization the user directly interacts with. An equivalent for the 'AGENT' property defined in RFC 2426 Sec. 3.5.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#representative"></see></summary>
    let representative = _prefix "representative"
    /// <summary>
    /// Indicates that this IMAccount has requested a subscription to the presence information of the other IMAccount.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#requestedPresenceSubscriptionTo"></see></summary>
    let requestedPresenceSubscriptionTo = _prefix "requestedPresenceSubscriptionTo"
    /// <summary>
    /// Role an object represented by this contact represents in the organization. This might include 'Programmer', 'Manager', 'Sales Representative'. Be careful to avoid confusion with the title property. An equivalent of the 'ROLE' property as defined in RFC 2426. Sec. 3.5.2. Note the difference between nco:Role class and nco:role property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// Sound clip attached to a Contact. The DataObject referred to by this property is usually interpreted as an nfo:Audio. Inspired by the SOUND property defined in RFC 2425 sec. 3.6.6.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#sound"></see></summary>
    let sound = _prefix "sound"
    /// <summary>
    /// Start datetime for the role, such as: the datetime of joining a project or organization, datetime of starting employment, datetime of marriage
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#start"></see></summary>
    let start = _prefix "start"
    /// <summary>
    /// The streed address. Inspired by the third part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#streetAddress"></see></summary>
    let streetAddress = _prefix "streetAddress"
    /// <summary>
    /// The official title  the object represented by this contact in an organization. E.g. 'CEO', 'Director, Research and Development', 'Junior Software Developer/Analyst' etc. An equivalent of the 'TITLE' property defined in RFC 2426 Sec. 3.5.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Indicates if the given number accepts voice mail. (e.g. there is an answering machine). Inspired by TYPE=msg parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#voiceMail"></see></summary>
    let voiceMail = _prefix "voiceMail"
    /// <summary>
    /// A url of a website.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#websiteUrl"></see></summary>
    let websiteUrl = _prefix "websiteUrl"
