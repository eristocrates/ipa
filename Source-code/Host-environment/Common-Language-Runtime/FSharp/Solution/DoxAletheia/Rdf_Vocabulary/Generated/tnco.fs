namespace http.tracker.api.gnome.org.ontology.v3.nco.hash

open DoxAletheia.Rdf_Vocabulary

module tnco =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/nco#"

    /// <summary>
    /// Aggregates three properties defined in RFC2426. Originally all three were attached directly to a person. One person could have only one title and one role within one organization. This class is intended to lift this limitation.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#Affiliation"></see></summary>
    let Affiliation =
        Namespaced_IRI.parse _namespace_name "Affiliation" |> NamespacedName

    /// <summary>
    /// A role played by a contact. Contacts that denote people, can have many roles (e.g. see the hasAffiliation property and Affiliation class). Contacts that denote Organizations or other Agents usually have one role.  Each role can introduce additional contact media.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    /// Predefined instances to indicate the auth status: yes, no, requested
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#AuthorizationStatus"></see></summary>
    let AuthorizationStatus =
        Namespaced_IRI.parse _namespace_name "AuthorizationStatus" |> NamespacedName

    /// <summary>
    /// A Bulletin Board System (BBS) phone number. Inspired by the (TYPE=bbsl) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#BbsNumber"></see></summary>
    let BbsNumber = Namespaced_IRI.parse _namespace_name "BbsNumber" |> NamespacedName

    /// <summary>
    /// A modem phone number. Inspired by the (TYPE=modem) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#ModemNumber"></see></summary>
    let ModemNumber =
        Namespaced_IRI.parse _namespace_name "ModemNumber" |> NamespacedName

    /// <summary>
    /// A car phone number. Inspired by the (TYPE=car) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#CarPhoneNumber"></see></summary>
    let CarPhoneNumber =
        Namespaced_IRI.parse _namespace_name "CarPhoneNumber" |> NamespacedName

    /// <summary>
    /// A telephone number with voice communication capabilities. Class inspired by the TYPE=voice parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#VoicePhoneNumber"></see></summary>
    let VoicePhoneNumber =
        Namespaced_IRI.parse _namespace_name "VoicePhoneNumber" |> NamespacedName

    /// <summary>
    /// A cellular phone number. Inspired by the (TYPE=cell) parameter of the TEL property as defined in RFC 2426 sec  3.3.1. Usually a cellular phone can accept voice calls as well as textual messages (SMS), therefore this class has two superclasses.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#CellPhoneNumber"></see></summary>
    let CellPhoneNumber =
        Namespaced_IRI.parse _namespace_name "CellPhoneNumber" |> NamespacedName

    /// <summary>
    /// A number that can accept textual messages.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#MessagingNumber"></see></summary>
    let MessagingNumber =
        Namespaced_IRI.parse _namespace_name "MessagingNumber" |> NamespacedName

    /// <summary>
    /// A Contact. A piece of data that can provide means to identify or communicate with an entity.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#Contact"></see></summary>
    let Contact = Namespaced_IRI.parse _namespace_name "Contact" |> NamespacedName

    /// <summary>
    /// A group of Contacts. Could be used to express a group in an addressbook or on a contact list of an IM application. One contact can belong to many groups.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#ContactGroup"></see></summary>
    let ContactGroup =
        Namespaced_IRI.parse _namespace_name "ContactGroup" |> NamespacedName

    /// <summary>
    /// A contact list, this class represents an addressbook or a contact list of an IM application. Contacts inside a contact list can belong to contact groups.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#ContactList"></see></summary>
    let ContactList =
        Namespaced_IRI.parse _namespace_name "ContactList" |> NamespacedName

    /// <summary>
    /// An entity occuring on a contact list (usually interpreted as an nco:Contact)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#ContactListDataObject"></see></summary>
    let ContactListDataObject =
        Namespaced_IRI.parse _namespace_name "ContactListDataObject" |> NamespacedName

    /// <summary>
    /// A superclass for all contact media - ways to contact an entity represented by a Contact instance. Some of the subclasses of this class (the various kinds of telephone numbers and postal addresses) have been inspired by the values of the TYPE parameter of ADR and TEL properties defined in RFC 2426 sec. 3.2.1. and 3.3.1 respectively. Each value is represented by an appropriate subclass with two major exceptions TYPE=home and TYPE=work. They are to be expressed by the roles these contact media are attached to i.e. contact media with TYPE=home parameter are to be attached to the default role (nco:Contact or nco:PersonContact), whereas media with TYPE=work parameter should be attached to nco:Affiliation or nco:OrganizationContact.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#ContactMedium"></see></summary>
    let ContactMedium =
        Namespaced_IRI.parse _namespace_name "ContactMedium" |> NamespacedName

    /// <summary>
    /// Domestic Delivery Addresse. Class inspired by TYPE=dom parameter of the ADR property defined in RFC 2426 sec. 3.2.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#DomesticDeliveryAddress"></see></summary>
    let DomesticDeliveryAddress =
        Namespaced_IRI.parse _namespace_name "DomesticDeliveryAddress" |> NamespacedName

    /// <summary>
    /// A postal address. A class aggregating the various parts of a value for the 'ADR' property as defined in RFC 2426 Sec. 3.2.1.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#PostalAddress"></see></summary>
    let PostalAddress =
        Namespaced_IRI.parse _namespace_name "PostalAddress" |> NamespacedName

    /// <summary>
    /// An email address. The recommended best practice is to use mailto: uris for instances of this class.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#EmailAddress"></see></summary>
    let EmailAddress =
        Namespaced_IRI.parse _namespace_name "EmailAddress" |> NamespacedName

    /// <summary>
    /// A fax number. Inspired by the (TYPE=fax) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#FaxNumber"></see></summary>
    let FaxNumber = Namespaced_IRI.parse _namespace_name "FaxNumber" |> NamespacedName

    /// <summary>
    /// A telephone number.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#PhoneNumber"></see></summary>
    let PhoneNumber =
        Namespaced_IRI.parse _namespace_name "PhoneNumber" |> NamespacedName

    /// <summary>
    /// Gender. Instances of this class may include male and female.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#Gender"></see></summary>
    let Gender = Namespaced_IRI.parse _namespace_name "Gender" |> NamespacedName
    /// <summary>
    /// An account in an Instant Messaging system. This refers to IM accounts of the user 'me'.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#IMAccount"></see></summary>
    let IMAccount = Namespaced_IRI.parse _namespace_name "IMAccount" |> NamespacedName
    /// <summary>
    /// An instant messaging address such as xmpp:foo@bar.com.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#IMAddress"></see></summary>
    let IMAddress = Namespaced_IRI.parse _namespace_name "IMAddress" |> NamespacedName

    /// <summary>
    /// Features of a certain IM connection (depends on the IMAccount implementation used by the Contact)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#IMCapability"></see></summary>
    let IMCapability =
        Namespaced_IRI.parse _namespace_name "IMCapability" |> NamespacedName

    /// <summary>
    /// International Delivery Addresse. Class inspired by TYPE=intl parameter of the ADR property defined in RFC 2426 sec. 3.2.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#InternationalDeliveryAddress"></see></summary>
    let InternationalDeliveryAddress =
        Namespaced_IRI.parse _namespace_name "InternationalDeliveryAddress" |> NamespacedName

    /// <summary>
    /// An ISDN phone number. Inspired by the (TYPE=isdn) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#IsdnNumber"></see></summary>
    let IsdnNumber = Namespaced_IRI.parse _namespace_name "IsdnNumber" |> NamespacedName

    /// <summary>
    /// A Contact that denotes on Organization.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#OrganizationContact"></see></summary>
    let OrganizationContact =
        Namespaced_IRI.parse _namespace_name "OrganizationContact" |> NamespacedName

    /// <summary>
    /// A pager phone number. Inspired by the (TYPE=pager) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#PagerNumber"></see></summary>
    let PagerNumber =
        Namespaced_IRI.parse _namespace_name "PagerNumber" |> NamespacedName

    /// <summary>
    /// Parcel Delivery Addresse. Class inspired by TYPE=parcel parameter of the ADR property defined in RFC 2426 sec. 3.2.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#ParcelDeliveryAddress"></see></summary>
    let ParcelDeliveryAddress =
        Namespaced_IRI.parse _namespace_name "ParcelDeliveryAddress" |> NamespacedName

    /// <summary>
    /// Personal Communication Services Number. A class inspired by the TYPE=pcs parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#PcsNumber"></see></summary>
    let PcsNumber = Namespaced_IRI.parse _namespace_name "PcsNumber" |> NamespacedName

    /// <summary>
    /// A Contact that denotes a Person. A person can have multiple Affiliations.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#PersonContact"></see></summary>
    let PersonContact =
        Namespaced_IRI.parse _namespace_name "PersonContact" |> NamespacedName

    /// <summary>
    /// Predefined set of status level instances
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#PresenceStatus"></see></summary>
    let PresenceStatus =
        Namespaced_IRI.parse _namespace_name "PresenceStatus" |> NamespacedName

    /// <summary>
    /// A Video telephone number. A class inspired by the TYPE=video parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#VideoTelephoneNumber"></see></summary>
    let VideoTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "VideoTelephoneNumber" |> NamespacedName

    /// <summary>
    /// The geographical location of a postal address.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#addressLocation"></see></summary>
    let addressLocation =
        Namespaced_IRI.parse _namespace_name "addressLocation" |> NamespacedName

    /// <summary>
    /// Links a Contact with a ContactGroup it belongs to.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#belongsToGroup"></see></summary>
    let belongsToGroup =
        Namespaced_IRI.parse _namespace_name "belongsToGroup" |> NamespacedName

    /// <summary>
    /// Birth date of the object represented by this Contact. An equivalent of the 'BDAY' property as defined in RFC 2426 Sec. 3.1.5.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#birthDate"></see></summary>
    let birthDate = Namespaced_IRI.parse _namespace_name "birthDate" |> NamespacedName
    /// <summary>
    /// A Blog url.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#blogUrl"></see></summary>
    let blogUrl = Namespaced_IRI.parse _namespace_name "blogUrl" |> NamespacedName
    /// <summary>
    /// A uniform resource locator associated with the given role of a Contact. Inspired by the 'URL' property defined in RFC 2426 Sec. 3.6.8.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName

    /// <summary>
    /// The name of the contact group. This property was NOT defined in the VCARD standard. See documentation of the 'ContactGroup' class for details
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#contactGroupName"></see></summary>
    let contactGroupName =
        Namespaced_IRI.parse _namespace_name "contactGroupName" |> NamespacedName

    /// <summary>
    /// Unique ID for the contact in the local storage
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#contactLocalUID"></see></summary>
    let contactLocalUID =
        Namespaced_IRI.parse _namespace_name "contactLocalUID" |> NamespacedName

    /// <summary>
    /// A comment about the contact medium.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#contactMediumComment"></see></summary>
    let contactMediumComment =
        Namespaced_IRI.parse _namespace_name "contactMediumComment" |> NamespacedName

    /// <summary>
    /// A value that represents a globally unique  identifier corresponding to the individual or resource associated with the Contact. An equivalent of the 'UID' property defined in RFC 2426 Sec. 3.6.7
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#contactUID"></see></summary>
    let contactUID = Namespaced_IRI.parse _namespace_name "contactUID" |> NamespacedName

    /// <summary>
    /// A property used to group contacts into contact groups. This property was NOT defined in the VCARD standard. See documentation for the 'ContactList' class for details
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#containsContact"></see></summary>
    let containsContact =
        Namespaced_IRI.parse _namespace_name "containsContact" |> NamespacedName

    /// <summary>
    /// An entity responsible for making contributions to the content of the InformationElement.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#contributor"></see></summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    /// A part of an address specifying the country. Inspired by the seventh part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName
    /// <summary>
    /// Regional division between state and city. Not in RFC 2426 sec 3.2.1. Added for API compatibility
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#county"></see></summary>
    let county = Namespaced_IRI.parse _namespace_name "county" |> NamespacedName
    /// <summary>
    /// Creator of a data object, an entity primarily responsible for the creation of the content of the data object.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#default-contact-me"></see>
    /// </summary>
    let ``default-contact-me`` =
        Namespaced_IRI.parse _namespace_name "default-contact-me" |> NamespacedName

    /// <summary>
    /// Department. The organizational unit within the organization.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#department"></see></summary>
    let department = Namespaced_IRI.parse _namespace_name "department" |> NamespacedName
    /// <summary>
    /// Local division inside a city. Not in RFC 2426 sec 3.2.1. Added for API compatibility
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#district"></see></summary>
    let district = Namespaced_IRI.parse _namespace_name "district" |> NamespacedName

    /// <summary>
    /// Email address
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#emailAddress"></see></summary>
    let emailAddress =
        Namespaced_IRI.parse _namespace_name "emailAddress" |> NamespacedName

    /// <summary>
    /// An extended part of an address. This field might be used to express parts of an address that aren't include in the name of the Contact but also aren't part of the actual location. Usually the streed address and following fields are enough for a postal letter to arrive. Examples may include ('University of California Campus building 45', 'Sears Tower 34th floor' etc.) Inspired by the second part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#extendedAddress"></see></summary>
    let extendedAddress =
        Namespaced_IRI.parse _namespace_name "extendedAddress" |> NamespacedName

    /// <summary>
    /// The URL of the FOAF file.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#foafUrl"></see></summary>
    let foafUrl = Namespaced_IRI.parse _namespace_name "foafUrl" |> NamespacedName
    /// <summary>
    /// To specify the formatted text corresponding to the name of the object the Contact represents. An equivalent of the FN property as defined in RFC 2426 Sec. 3.1.1.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#fullname"></see></summary>
    let fullname = Namespaced_IRI.parse _namespace_name "fullname" |> NamespacedName
    /// <summary>
    /// Gender of the given contact.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#gender"></see></summary>
    let gender = Namespaced_IRI.parse _namespace_name "gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#gender-female"></see>
    /// </summary>
    let ``gender-female`` =
        Namespaced_IRI.parse _namespace_name "gender-female" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#gender-male"></see>
    /// </summary>
    let ``gender-male`` =
        Namespaced_IRI.parse _namespace_name "gender-male" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#gender-other"></see>
    /// </summary>
    let ``gender-other`` =
        Namespaced_IRI.parse _namespace_name "gender-other" |> NamespacedName

    /// <summary>
    /// Links a PersonContact with an Affiliation.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#hasAffiliation"></see></summary>
    let hasAffiliation =
        Namespaced_IRI.parse _namespace_name "hasAffiliation" |> NamespacedName

    /// <summary>
    /// A superProperty for all properties linking a Contact to an instance of a contact medium.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#hasContactMedium"></see></summary>
    let hasContactMedium =
        Namespaced_IRI.parse _namespace_name "hasContactMedium" |> NamespacedName

    /// <summary>
    /// An address for electronic mail communication with the object specified by this contact. An equivalent of the 'EMAIL' property as defined in RFC 2426 Sec. 3.3.1.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#hasEmailAddress"></see></summary>
    let hasEmailAddress =
        Namespaced_IRI.parse _namespace_name "hasEmailAddress" |> NamespacedName

    /// <summary>
    /// An address for communication using instant messages with the object specified by this contact.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#hasIMAddress"></see></summary>
    let hasIMAddress =
        Namespaced_IRI.parse _namespace_name "hasIMAddress" |> NamespacedName

    /// <summary>
    /// Indicates that this Instant Messaging account has the specified Instant Messaging address in the contact list.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#hasIMContact"></see></summary>
    let hasIMContact =
        Namespaced_IRI.parse _namespace_name "hasIMContact" |> NamespacedName

    /// <summary>
    /// Geographical location of the contact. Inspired by the 'GEO' property specified in RFC 2426 Sec. 3.4.2
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// A number for telephony communication with the object represented by this Contact. An equivalent of the 'TEL' property defined in RFC 2426 Sec. 3.3.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#hasPhoneNumber"></see></summary>
    let hasPhoneNumber =
        Namespaced_IRI.parse _namespace_name "hasPhoneNumber" |> NamespacedName

    /// <summary>
    /// The default Address for a Contact. An equivalent of the 'ADR' property as defined in RFC 2426 Sec. 3.2.1.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#hasPostalAddress"></see></summary>
    let hasPostalAddress =
        Namespaced_IRI.parse _namespace_name "hasPostalAddress" |> NamespacedName

    /// <summary>
    /// A hobby associated with a PersonContact. This property can be used to express hobbies and interests.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#hobby"></see></summary>
    let hobby = Namespaced_IRI.parse _namespace_name "hobby" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-audio-calls"></see>
    /// </summary>
    let ``im-capability-audio-calls`` =
        Namespaced_IRI.parse _namespace_name "im-capability-audio-calls" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-dbus-tubes"></see>
    /// </summary>
    let ``im-capability-dbus-tubes`` =
        Namespaced_IRI.parse _namespace_name "im-capability-dbus-tubes" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-file-transfers"></see>
    /// </summary>
    let ``im-capability-file-transfers`` =
        Namespaced_IRI.parse _namespace_name "im-capability-file-transfers" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-media-calls"></see>
    /// </summary>
    let ``im-capability-media-calls`` =
        Namespaced_IRI.parse _namespace_name "im-capability-media-calls" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-stream-tubes"></see>
    /// </summary>
    let ``im-capability-stream-tubes`` =
        Namespaced_IRI.parse _namespace_name "im-capability-stream-tubes" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-text-chat"></see>
    /// </summary>
    let ``im-capability-text-chat`` =
        Namespaced_IRI.parse _namespace_name "im-capability-text-chat" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-upgrading-calls"></see>
    /// </summary>
    let ``im-capability-upgrading-calls`` =
        Namespaced_IRI.parse _namespace_name "im-capability-upgrading-calls" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-video-calls"></see>
    /// </summary>
    let ``im-capability-video-calls`` =
        Namespaced_IRI.parse _namespace_name "im-capability-video-calls" |> NamespacedName

    /// <summary>
    /// Instant Messaging address of this IM account. The user 'me' can send and receive messages from this IM address.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imAccountAddress"></see></summary>
    let imAccountAddress =
        Namespaced_IRI.parse _namespace_name "imAccountAddress" |> NamespacedName

    /// <summary>
    /// Type of the IM account. This may be the name of the service that provides the IM functionality. Examples might include Jabber, ICQ, MSN etc
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imAccountType"></see></summary>
    let imAccountType =
        Namespaced_IRI.parse _namespace_name "imAccountType" |> NamespacedName

    /// <summary>
    /// Has the other end authorize to receive information about his changes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imAddressAuthStatusFrom"></see></summary>
    let imAddressAuthStatusFrom =
        Namespaced_IRI.parse _namespace_name "imAddressAuthStatusFrom" |> NamespacedName

    /// <summary>
    /// Do i authorize this im Account to receive my information
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imAddressAuthStatusTo"></see></summary>
    let imAddressAuthStatusTo =
        Namespaced_IRI.parse _namespace_name "imAddressAuthStatusTo" |> NamespacedName

    /// <summary>
    /// A picture attached to a particular IM address.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imAvatar"></see></summary>
    let imAvatar = Namespaced_IRI.parse _namespace_name "imAvatar" |> NamespacedName

    /// <summary>
    /// Capabilities of an IM Contact, what can we interact with him
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imCapability"></see></summary>
    let imCapability =
        Namespaced_IRI.parse _namespace_name "imCapability" |> NamespacedName

    /// <summary>
    /// The user-visible name of this account. This SHOULD be chosen by the user at account creation time. The account creation user interface is responsible for setting a reasonable default value in the user's locale; something like	'Jabber (bob@example.com)' would be sensible.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imDisplayName"></see></summary>
    let imDisplayName =
        Namespaced_IRI.parse _namespace_name "imDisplayName" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#imEnabled"></see>
    /// </summary>
    let imEnabled = Namespaced_IRI.parse _namespace_name "imEnabled" |> NamespacedName
    /// <summary>
    /// Identifier of the IM account. Examples of such identifier might include ICQ UINs, Jabber IDs, Skype names etc.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imID"></see></summary>
    let imID = Namespaced_IRI.parse _namespace_name "imID" |> NamespacedName
    /// <summary>
    /// A nickname attached to a particular IM address.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imNickname"></see></summary>
    let imNickname = Namespaced_IRI.parse _namespace_name "imNickname" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#imPresence"></see>
    /// </summary>
    let imPresence = Namespaced_IRI.parse _namespace_name "imPresence" |> NamespacedName
    /// <summary>
    /// Protocol of the account ('skype', 'gtalk', 'icq', ...)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imProtocol"></see></summary>
    let imProtocol = Namespaced_IRI.parse _namespace_name "imProtocol" |> NamespacedName

    /// <summary>
    /// A feature common in most IM systems. A message left by the user for all his/her contacts to see.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#imStatusMessage"></see></summary>
    let imStatusMessage =
        Namespaced_IRI.parse _namespace_name "imStatusMessage" |> NamespacedName

    /// <summary>
    /// An encryption key attached to a contact. Inspired by the KEY property defined in RFC 2426 sec. 3.7.2
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#key"></see></summary>
    let key = Namespaced_IRI.parse _namespace_name "key" |> NamespacedName
    /// <summary>
    /// Locality or City. Inspired by the fourth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#locality"></see></summary>
    let locality = Namespaced_IRI.parse _namespace_name "locality" |> NamespacedName
    /// <summary>
    /// Logo of a company. Inspired by the LOGO property defined in RFC 2426 sec. 3.5.3
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#logo"></see></summary>
    let logo = Namespaced_IRI.parse _namespace_name "logo" |> NamespacedName

    /// <summary>
    /// Additional given name of an object represented by this contact. See documentation for 'nameFamily' property for details.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#nameAdditional"></see></summary>
    let nameAdditional =
        Namespaced_IRI.parse _namespace_name "nameAdditional" |> NamespacedName

    /// <summary>
    /// The family name of an Object represented by this Contact. These applies to people that have more than one given name. The 'first' one is considered 'the' given name (see nameGiven) property. All additional ones are considered 'additional' names. The name inherited from parents is the 'family name'. e.g. For Dr. John Phil Paul Stevenson Jr. M.D. A.C.P. we have contact with: honorificPrefix: 'Dr.', nameGiven: 'John', nameAdditional: 'Phil', nameAdditional: 'Paul', nameFamily: 'Stevenson', honorificSuffix: 'Jr.', honorificSuffix: 'M.D.', honorificSuffix: 'A.C.P.'. These properties form an equivalent of the compound 'N' property as defined in RFC 2426 Sec. 3.1.2
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#nameFamily"></see></summary>
    let nameFamily = Namespaced_IRI.parse _namespace_name "nameFamily" |> NamespacedName
    /// <summary>
    /// The given name for the object represented by this Contact. See documentation for 'nameFamily' property for details.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#nameGiven"></see></summary>
    let nameGiven = Namespaced_IRI.parse _namespace_name "nameGiven" |> NamespacedName

    /// <summary>
    /// A prefix for the name of the object represented by this Contact. See documentation for the 'nameFamily' property for details.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#nameHonorificPrefix"></see></summary>
    let nameHonorificPrefix =
        Namespaced_IRI.parse _namespace_name "nameHonorificPrefix" |> NamespacedName

    /// <summary>
    /// A suffix for the name of the Object represented by the given object. See documentation for the 'nameFamily' for details.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#nameHonorificSuffix"></see></summary>
    let nameHonorificSuffix =
        Namespaced_IRI.parse _namespace_name "nameHonorificSuffix" |> NamespacedName

    /// <summary>
    /// A nickname of the Object represented by this Contact. This is an equivalen of the 'NICKNAME' property as defined in RFC 2426 Sec. 3.1.3.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#nickname"></see></summary>
    let nickname = Namespaced_IRI.parse _namespace_name "nickname" |> NamespacedName
    /// <summary>
    /// A note about the object represented by this Contact. An equivalent for the 'NOTE' property defined in RFC 2426 Sec. 3.6.2
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#note"></see></summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    /// Name of an organization or a unit within an organization the object represented by a Contact is associated with. An equivalent of the 'ORG' property defined in RFC 2426 Sec. 3.5.5
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#org"></see></summary>
    let org = Namespaced_IRI.parse _namespace_name "org" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#phoneNumber"></see>
    /// </summary>
    let phoneNumber =
        Namespaced_IRI.parse _namespace_name "phoneNumber" |> NamespacedName

    /// <summary>
    /// Photograph attached to a Contact. The DataObject refered to by this property is usually interpreted as an nfo:Image. Inspired by the PHOTO property defined in RFC 2426 sec. 3.1.4
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#photo"></see></summary>
    let photo = Namespaced_IRI.parse _namespace_name "photo" |> NamespacedName
    /// <summary>
    /// Post office box. This is the first part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#pobox"></see></summary>
    let pobox = Namespaced_IRI.parse _namespace_name "pobox" |> NamespacedName
    /// <summary>
    /// Postal Code. Inspired by the sixth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#postalcode"></see></summary>
    let postalcode = Namespaced_IRI.parse _namespace_name "postalcode" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#predefined-auth-status-no"></see>
    /// </summary>
    let ``predefined-auth-status-no`` =
        Namespaced_IRI.parse _namespace_name "predefined-auth-status-no" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#predefined-auth-status-requested"></see>
    /// </summary>
    let ``predefined-auth-status-requested`` =
        Namespaced_IRI.parse _namespace_name "predefined-auth-status-requested" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#predefined-auth-status-yes"></see>
    /// </summary>
    let ``predefined-auth-status-yes`` =
        Namespaced_IRI.parse _namespace_name "predefined-auth-status-yes" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-available"></see>
    /// </summary>
    let ``presence-status-available`` =
        Namespaced_IRI.parse _namespace_name "presence-status-available" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-away"></see>
    /// </summary>
    let ``presence-status-away`` =
        Namespaced_IRI.parse _namespace_name "presence-status-away" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-busy"></see>
    /// </summary>
    let ``presence-status-busy`` =
        Namespaced_IRI.parse _namespace_name "presence-status-busy" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-error"></see>
    /// </summary>
    let ``presence-status-error`` =
        Namespaced_IRI.parse _namespace_name "presence-status-error" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-extended-away"></see>
    /// </summary>
    let ``presence-status-extended-away`` =
        Namespaced_IRI.parse _namespace_name "presence-status-extended-away" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-hidden"></see>
    /// </summary>
    let ``presence-status-hidden`` =
        Namespaced_IRI.parse _namespace_name "presence-status-hidden" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-offline"></see>
    /// </summary>
    let ``presence-status-offline`` =
        Namespaced_IRI.parse _namespace_name "presence-status-offline" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-unknown"></see>
    /// </summary>
    let ``presence-status-unknown`` =
        Namespaced_IRI.parse _namespace_name "presence-status-unknown" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-unset"></see>
    /// </summary>
    let ``presence-status-unset`` =
        Namespaced_IRI.parse _namespace_name "presence-status-unset" |> NamespacedName

    /// <summary>
    /// Timestamp of the last change in the presence status
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#presenceLastModified"></see></summary>
    let presenceLastModified =
        Namespaced_IRI.parse _namespace_name "presenceLastModified" |> NamespacedName

    /// <summary>
    /// An entity responsible for making the InformationElement available.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName
    /// <summary>
    /// Region. Inspired by the fifth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName

    /// <summary>
    /// An object that represent an object represented by this Contact. Usually this property is used to link a Contact to an organization, to a contact to the representative of this organization the user directly interacts with. An equivalent for the 'AGENT' property defined in RFC 2426 Sec. 3.5.4
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#representative"></see></summary>
    let representative =
        Namespaced_IRI.parse _namespace_name "representative" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#role"></see>
    /// </summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    /// Sound clip attached to a Contact. The DataObject refered to by this property is usually interpreted as an nfo:Audio. Inspired by the SOUND property defined in RFC 2425 sec. 3.6.6.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#sound"></see></summary>
    let sound = Namespaced_IRI.parse _namespace_name "sound" |> NamespacedName

    /// <summary>
    /// The streed address. Inspired by the third part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#streetAddress"></see></summary>
    let streetAddress =
        Namespaced_IRI.parse _namespace_name "streetAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/nco#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// Video avatar of a contact. Note that is an icon/avatar, not a generic 'present in video' property
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#video"></see></summary>
    let video = Namespaced_IRI.parse _namespace_name "video" |> NamespacedName
    /// <summary>
    /// Indicates if the given number accepts voice mail. (e.g. there is an answering machine). Inspired by TYPE=msg parameter of the TEL property defined in RFC 2426 sec. 3.3.1
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#voiceMail"></see></summary>
    let voiceMail = Namespaced_IRI.parse _namespace_name "voiceMail" |> NamespacedName
    /// <summary>
    /// A url of a website.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nco#websiteUrl"></see></summary>
    let websiteUrl = Namespaced_IRI.parse _namespace_name "websiteUrl" |> NamespacedName
