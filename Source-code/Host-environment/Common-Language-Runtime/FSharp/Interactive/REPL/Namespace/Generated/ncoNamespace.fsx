#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nco =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/03/22/nco#" "nco"

    /// <summary>
    ///   <para>rdfs:label : Affiliation^^xsd:string</para>
    ///   <para>rdfs:comment : Aggregates three properties defined in RFC2426. Originally all three were attached directly to a person. One person could have only one title and one role within one organization. This class is intended to lift this limitation.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Affiliation">nco:Affiliation</a>
    /// </summary>
    let Affiliation = _prefixId.prefix "Affiliation"
    /// <summary>
    ///   <para>rdfs:label : AudioIMAccount^^xsd:string</para>
    ///   <para>rdfs:comment : Deprecated in favour of nco:imCapabilityAudio.^^xsd:string</para>
    ///   <para>nao:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#AudioIMAccount">nco:AudioIMAccount</a>
    /// </summary>
    let AudioIMAccount = _prefixId.prefix "AudioIMAccount"
    /// <summary>
    ///   <para>rdfs:label : BbsNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A Bulletin Board System (BBS) phone number. Inspired by the (TYPE=bbsl) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#BbsNumber">nco:BbsNumber</a>
    /// </summary>
    let BbsNumber = _prefixId.prefix "BbsNumber"
    /// <summary>
    ///   <para>rdfs:label : BirthDate^^xsd:string</para>
    ///   <para>rdfs:comment : A class representing a person contact's birth date information. Possesses various attributes.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#BirthDate">nco:BirthDate</a>
    /// </summary>
    let BirthDate = _prefixId.prefix "BirthDate"
    /// <summary>
    ///   <para>rdfs:label : CarPhoneNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A car phone number. Inspired by the (TYPE=car) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#CarPhoneNumber">nco:CarPhoneNumber</a>
    /// </summary>
    let CarPhoneNumber = _prefixId.prefix "CarPhoneNumber"
    /// <summary>
    ///   <para>rdfs:label : CellPhoneNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A cellular phone number. Inspired by the (TYPE=cell) parameter of the TEL property as defined in RFC 2426 sec  3.3.1. Usually a cellular phone can accept voice calls as well as textual messages (SMS), therefore this class has two superclasses.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#CellPhoneNumber">nco:CellPhoneNumber</a>
    /// </summary>
    let CellPhoneNumber = _prefixId.prefix "CellPhoneNumber"
    /// <summary>
    ///   <para>rdfs:label : Contact^^xsd:string</para>
    ///   <para>rdfs:comment : A Contact. A piece of data that can provide means to identify or communicate with an entity.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Contact">nco:Contact</a>
    /// </summary>
    let Contact = _prefixId.prefix "Contact"
    /// <summary>
    ///   <para>rdfs:label : ContactGroup^^xsd:string</para>
    ///   <para>rdfs:comment : A group of Contacts. Could be used to express a group in an addressbook or on a contact list of an IM application. One contact can belong to many groups.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactGroup">nco:ContactGroup</a>
    /// </summary>
    let ContactGroup = _prefixId.prefix "ContactGroup"
    /// <summary>
    ///   <para>rdfs:label : ContactList^^xsd:string</para>
    ///   <para>rdfs:comment : A contact list, this class represents an addressbook or a contact list of an IM application. Contacts inside a contact list can belong to contact groups.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactList">nco:ContactList</a>
    /// </summary>
    let ContactList = _prefixId.prefix "ContactList"
    /// <summary>
    ///   <para>rdfs:label : ContactListDataObject^^xsd:string</para>
    ///   <para>rdfs:comment : An entity occuring on a contact list (usually interpreted as an nco:Contact)^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactListDataObject">nco:ContactListDataObject</a>
    /// </summary>
    let ContactListDataObject = _prefixId.prefix "ContactListDataObject"
    /// <summary>
    ///   <para>rdfs:label : ContactMedium^^xsd:string</para>
    ///   <para>rdfs:comment : A superclass for all contact media - ways to contact an entity represented by a Contact instance. Some of the subclasses of this class (the various kinds of telephone numbers and postal addresses) have been inspired by the values of the TYPE parameter of ADR and TEL properties defined in RFC 2426 sec. 3.2.1. and 3.3.1 respectively. Each value is represented by an appropriate subclass with two major exceptions TYPE=home and TYPE=work. They are to be expressed by the roles these contact media are attached to i.e. contact media with TYPE=home parameter are to be attached to the default role (nco:Contact or nco:PersonContact), whereas media with TYPE=work parameter should be attached to nco:Affiliation or nco:OrganizationContact.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactMedium">nco:ContactMedium</a>
    /// </summary>
    let ContactMedium = _prefixId.prefix "ContactMedium"
    /// <summary>
    ///   <para>rdfs:label : DomesticDeliveryAddress^^xsd:string</para>
    ///   <para>rdfs:comment : Domestic Delivery Addresse. Class inspired by TYPE=dom parameter of the ADR property defined in RFC 2426 sec. 3.2.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#DomesticDeliveryAddress">nco:DomesticDeliveryAddress</a>
    /// </summary>
    let DomesticDeliveryAddress = _prefixId.prefix "DomesticDeliveryAddress"
    /// <summary>
    ///   <para>rdfs:label : EmailAddress^^xsd:string</para>
    ///   <para>rdfs:comment : An email address. The recommended best practice is to use mailto: uris for instances of this class.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#EmailAddress">nco:EmailAddress</a>
    /// </summary>
    let EmailAddress = _prefixId.prefix "EmailAddress"
    /// <summary>
    ///   <para>rdfs:label : FaxNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A fax number. Inspired by the (TYPE=fax) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#FaxNumber">nco:FaxNumber</a>
    /// </summary>
    let FaxNumber = _prefixId.prefix "FaxNumber"
    /// <summary>
    ///   <para>rdfs:label : Gender^^xsd:string</para>
    ///   <para>rdfs:comment : Gender. Instances of this class may include male and female.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Gender">nco:Gender</a>
    /// </summary>
    let Gender = _prefixId.prefix "Gender"
    /// <summary>
    ///   <para>rdfs:label : Hobby^^xsd:string</para>
    ///   <para>rdfs:comment : Instances of this class represent personal hobbies and interests.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Hobby">nco:Hobby</a>
    /// </summary>
    let Hobby = _prefixId.prefix "Hobby"
    /// <summary>
    ///   <para>rdfs:label : IMAccount^^xsd:string</para>
    ///   <para>rdfs:comment : An account in an Instant Messaging system.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMAccount">nco:IMAccount</a>
    /// </summary>
    let IMAccount = _prefixId.prefix "IMAccount"
    /// <summary>
    ///   <para>rdfs:comment : Capabilities of a cetain IMAccount.^^xsd:string</para>
    ///   <para>rdfs:label : imCapability^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMCapability">nco:IMCapability</a>
    /// </summary>
    let IMCapability = _prefixId.prefix "IMCapability"
    /// <summary>
    ///   <para>rdfs:comment : The status type of an IMAccount. Based on the Connection_Presence_Type enumeration of the Telepathy project: http://telepathy.freedesktop.org/spec/Connection_Interface_Simple_Presence.html#Enum:Connection_Presence_Type^^xsd:string</para>
    ///   <para>rdfs:label : instant messaging status type^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusType">nco:IMStatusType</a>
    /// </summary>
    let IMStatusType = _prefixId.prefix "IMStatusType"
    let IMStatusTypeAvailable = _prefixId.prefix "IMStatusTypeAvailable"
    let IMStatusTypeAway = _prefixId.prefix "IMStatusTypeAway"
    let IMStatusTypeBusy = _prefixId.prefix "IMStatusTypeBusy"
    let IMStatusTypeExtendedAway = _prefixId.prefix "IMStatusTypeExtendedAway"
    let IMStatusTypeHidden = _prefixId.prefix "IMStatusTypeHidden"
    let IMStatusTypeOffline = _prefixId.prefix "IMStatusTypeOffline"
    let IMStatusTypeUnknown = _prefixId.prefix "IMStatusTypeUnknown"
    /// <summary>
    ///   <para>rdfs:label : InternationalDeliveryAddress^^xsd:string</para>
    ///   <para>rdfs:comment : International Delivery Addresse. Class inspired by TYPE=intl parameter of the ADR property defined in RFC 2426 sec. 3.2.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#InternationalDeliveryAddress">nco:InternationalDeliveryAddress</a>
    /// </summary>
    let InternationalDeliveryAddress = _prefixId.prefix "InternationalDeliveryAddress"
    /// <summary>
    ///   <para>rdfs:label : IsdnNumber^^xsd:string</para>
    ///   <para>rdfs:comment : An ISDN phone number. Inspired by the (TYPE=isdn) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IsdnNumber">nco:IsdnNumber</a>
    /// </summary>
    let IsdnNumber = _prefixId.prefix "IsdnNumber"
    /// <summary>
    ///   <para>rdfs:label : MessagingNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A number that can accept textual messages.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#MessagingNumber">nco:MessagingNumber</a>
    /// </summary>
    let MessagingNumber = _prefixId.prefix "MessagingNumber"
    /// <summary>
    ///   <para>rdfs:label : ModemNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A modem phone number. Inspired by the (TYPE=modem) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ModemNumber">nco:ModemNumber</a>
    /// </summary>
    let ModemNumber = _prefixId.prefix "ModemNumber"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <para>rdfs:comment : A class representing a contact's name. Possesses various attributes.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Name">nco:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>rdfs:label : OrganizationContact^^xsd:string</para>
    ///   <para>rdfs:comment : A Contact that denotes on Organization.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#OrganizationContact">nco:OrganizationContact</a>
    /// </summary>
    let OrganizationContact = _prefixId.prefix "OrganizationContact"
    /// <summary>
    ///   <para>rdfs:label : PagerNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A pager phone number. Inspired by the (TYPE=pager) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PagerNumber">nco:PagerNumber</a>
    /// </summary>
    let PagerNumber = _prefixId.prefix "PagerNumber"
    /// <summary>
    ///   <para>rdfs:label : ParcelDeliveryAddress^^xsd:string</para>
    ///   <para>rdfs:comment : Parcel Delivery Addresse. Class inspired by TYPE=parcel parameter of the ADR property defined in RFC 2426 sec. 3.2.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ParcelDeliveryAddress">nco:ParcelDeliveryAddress</a>
    /// </summary>
    let ParcelDeliveryAddress = _prefixId.prefix "ParcelDeliveryAddress"
    /// <summary>
    ///   <para>rdfs:label : PcsNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Personal Communication Services Number. A class inspired by the TYPE=pcs parameter of the TEL property defined in RFC 2426 sec. 3.3.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PcsNumber">nco:PcsNumber</a>
    /// </summary>
    let PcsNumber = _prefixId.prefix "PcsNumber"
    /// <summary>
    ///   <para>rdfs:label : PersonContact^^xsd:string</para>
    ///   <para>rdfs:comment : A Contact that denotes a Person. A person can have multiple Affiliations.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PersonContact">nco:PersonContact</a>
    /// </summary>
    let PersonContact = _prefixId.prefix "PersonContact"
    /// <summary>
    ///   <para>rdfs:label : PersonName^^xsd:string</para>
    ///   <para>rdfs:comment : A class representing a person contact's name. Possesses various attributes.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PersonName">nco:PersonName</a>
    /// </summary>
    let PersonName = _prefixId.prefix "PersonName"
    /// <summary>
    ///   <para>rdfs:label : PhoneNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A telephone number.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PhoneNumber">nco:PhoneNumber</a>
    /// </summary>
    let PhoneNumber = _prefixId.prefix "PhoneNumber"
    /// <summary>
    ///   <para>rdfs:label : PostalAddress^^xsd:string</para>
    ///   <para>rdfs:comment : A postal address. A class aggregating the various parts of a value for the 'ADR' property as defined in RFC 2426 Sec. 3.2.1.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PostalAddress">nco:PostalAddress</a>
    /// </summary>
    let PostalAddress = _prefixId.prefix "PostalAddress"
    /// <summary>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <para>rdfs:comment : A role played by a contact. Contacts that denote people, can have many roles (e.g. see the hasAffiliation property and Affiliation class). Contacts that denote Organizations or other Agents usually have one role.  Each role can introduce additional contact media.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Role">nco:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : VideoIMAccount^^xsd:string</para>
    ///   <para>rdfs:comment : Deprecated in favour of nco:imCapabilityVideo.^^xsd:string</para>
    ///   <para>nao:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VideoIMAccount">nco:VideoIMAccount</a>
    /// </summary>
    let VideoIMAccount = _prefixId.prefix "VideoIMAccount"
    /// <summary>
    ///   <para>rdfs:label : VideoTelephoneNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A Video telephone number. A class inspired by the TYPE=video parameter of the TEL property defined in RFC 2426 sec. 3.3.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VideoTelephoneNumber">nco:VideoTelephoneNumber</a>
    /// </summary>
    let VideoTelephoneNumber = _prefixId.prefix "VideoTelephoneNumber"
    /// <summary>
    ///   <para>rdfs:label : VoicePhoneNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A telephone number with voice communication capabilities. Class inspired by the TYPE=voice parameter of the TEL property defined in RFC 2426 sec. 3.3.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VoicePhoneNumber">nco:VoicePhoneNumber</a>
    /// </summary>
    let VoicePhoneNumber = _prefixId.prefix "VoicePhoneNumber"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : addressLocation^^xsd:string</para>
    ///   <para>rdfs:comment : The geographical location of a postal address.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#addressLocation">nco:addressLocation</a>
    /// </summary>
    let addressLocation = _prefixId.prefix "addressLocation"
    /// <summary>
    ///   <para>nrl:MaxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : age^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the age of a person contact.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#age">nco:age</a>
    /// </summary>
    let age = _prefixId.prefix "age"
    /// <summary>
    ///   <para>rdfs:label : addressLocation^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Contact with a ContactGroup it belongs to.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#belongsToGroup">nco:belongsToGroup</a>
    /// </summary>
    let belongsToGroup = _prefixId.prefix "belongsToGroup"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : birthDate^^xsd:string</para>
    ///   <para>rdfs:comment : Birth date of the object represented by this Contact. An equivalent of the 'BDAY' property as defined in RFC 2426 Sec. 3.1.5.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#birthDate">nco:birthDate</a>
    /// </summary>
    let birthDate = _prefixId.prefix "birthDate"
    /// <summary>
    ///   <para>rdfs:label : blogUrl^^xsd:string</para>
    ///   <para>rdfs:comment : A Blog url.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#blogUrl">nco:blogUrl</a>
    /// </summary>
    let blogUrl = _prefixId.prefix "blogUrl"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : contactGroupName^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the contact group. This property was NOT defined
    ///     in the VCARD standard. See documentation of the 'ContactGroup' class for
    ///     details^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactGroupName">nco:contactGroupName</a>
    /// </summary>
    let contactGroupName = _prefixId.prefix "contactGroupName"
    /// <summary>
    ///   <para>nao:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : contactMediumComment^^xsd:string</para>
    ///   <para>rdfs:comment : A comment about the contact medium. (Deprecated in favor of nie:comment or nao:description - based on the context)^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactMediumComment">nco:contactMediumComment</a>
    /// </summary>
    let contactMediumComment = _prefixId.prefix "contactMediumComment"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : contactUID^^xsd:string</para>
    ///   <para>rdfs:comment : A value that represents a globally unique  identifier corresponding to the individual or resource associated with the Contact. An equivalent of the 'UID' property defined in RFC 2426 Sec. 3.6.7^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactUID">nco:contactUID</a>
    /// </summary>
    let contactUID = _prefixId.prefix "contactUID"
    /// <summary>
    ///   <para>rdfs:label : containsContact^^xsd:string</para>
    ///   <para>rdfs:comment : A property used to group contacts into contact groups. This
    ///     property was NOT defined in the VCARD standard. See documentation for the
    ///     'ContactList' class for details^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#containsContact">nco:containsContact</a>
    /// </summary>
    let containsContact = _prefixId.prefix "containsContact"
    /// <summary>
    ///   <para>rdfs:label : contributor^^xsd:string</para>
    ///   <para>rdfs:comment : An entity responsible for making contributions to the content of the InformationElement.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contributor">nco:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : country^^xsd:string</para>
    ///   <para>rdfs:comment : A part of an address specyfing the country. Inspired by the seventh part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#country">nco:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : creator^^xsd:string</para>
    ///   <para>rdfs:comment : Creator of an information element, an entity primarily responsible for the creation of the content of the data object.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#creator">nco:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:label : department^^xsd:string</para>
    ///   <para>rdfs:comment : Department. The organizational unit within the organization.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#department">nco:department</a>
    /// </summary>
    let department = _prefixId.prefix "department"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : emailAddress^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#emailAddress">nco:emailAddress</a>
    /// </summary>
    let emailAddress = _prefixId.prefix "emailAddress"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : end^^xsd:string</para>
    ///   <para>rdfs:comment : End datetime for the role, such as: the datetime of leaving a project or organization, datetime of ending employment, datetime of divorce. If absent or set to a date in the future, the role is currently active.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#end">nco:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : extendedAddress^^xsd:string</para>
    ///   <para>rdfs:comment : An extended part of an address. This field might be used to express parts of an address that aren't include in the name of the Contact but also aren't part of the actual location. Usually the streed address and following fields are enough for a postal letter to arrive. Examples may include ('University of California Campus building 45', 'Sears Tower 34th floor' etc.) Inspired by the second part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#extendedAddress">nco:extendedAddress</a>
    /// </summary>
    let extendedAddress = _prefixId.prefix "extendedAddress"
    let female = _prefixId.prefix "female"
    /// <summary>
    ///   <para>rdfs:label : foafUrl^^xsd:string</para>
    ///   <para>rdfs:comment : The URL of the FOAF file.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#foafUrl">nco:foafUrl</a>
    /// </summary>
    let foafUrl = _prefixId.prefix "foafUrl"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : fullname^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the formatted text corresponding to the name of the object the Contact represents. An equivalent of the FN property as defined in RFC 2426 Sec. 3.1.1.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#fullname">nco:fullname</a>
    /// </summary>
    let fullname = _prefixId.prefix "fullname"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : gender^^xsd:string</para>
    ///   <para>rdfs:comment : Gender of the given contact.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#gender">nco:gender</a>
    /// </summary>
    let gender = _prefixId.prefix "gender"
    /// <summary>
    ///   <para>rdfs:label : hasAffiliation^^xsd:string</para>
    ///   <para>rdfs:comment : Links a PersonContact with an Affiliation.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasAffiliation">nco:hasAffiliation</a>
    /// </summary>
    let hasAffiliation = _prefixId.prefix "hasAffiliation"
    /// <summary>
    ///   <para>nrl:MaxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : hasBirthDate^^xsd:string</para>
    ///   <para>rdfs:comment : Attaches birth date information to a person contact.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasBirthDate">nco:hasBirthDate</a>
    /// </summary>
    let hasBirthDate = _prefixId.prefix "hasBirthDate"
    /// <summary>
    ///   <para>rdfs:label : hasContactMedium^^xsd:string</para>
    ///   <para>rdfs:comment : A superProperty for all properties linking a Contact to an instance of a contact medium.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasContactMedium">nco:hasContactMedium</a>
    /// </summary>
    let hasContactMedium = _prefixId.prefix "hasContactMedium"
    /// <summary>
    ///   <para>rdfs:label : hasCustomAttribute^^xsd:string</para>
    ///   <para>rdfs:comment : A generic contact attribute introduced in order to enable customisation of contact details. Thus, systems using the NCO to model contact and person information, can introduce customised attributes by creating them as a subproperty of this one.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasCustomAttribute">nco:hasCustomAttribute</a>
    /// </summary>
    let hasCustomAttribute = _prefixId.prefix "hasCustomAttribute"
    /// <summary>
    ///   <para>rdfs:label : hasEmailAddress^^xsd:string</para>
    ///   <para>rdfs:comment : An address for electronic mail communication with the object specified by this contact. An equivalent of the 'EMAIL' property as defined in RFC 2426 Sec. 3.3.1.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasEmailAddress">nco:hasEmailAddress</a>
    /// </summary>
    let hasEmailAddress = _prefixId.prefix "hasEmailAddress"
    /// <summary>
    ///   <para>rdfs:label : hasIMAccount^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that an Instant Messaging account owned by an entity represented by this contact.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasIMAccount">nco:hasIMAccount</a>
    /// </summary>
    let hasIMAccount = _prefixId.prefix "hasIMAccount"
    /// <summary>
    ///   <para>rdfs:label : hasIMCapability^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that an IMAccount has a certain capability.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasIMCapability">nco:hasIMCapability</a>
    /// </summary>
    let hasIMCapability = _prefixId.prefix "hasIMCapability"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : hasLocation^^xsd:string</para>
    ///   <para>rdfs:comment : Geographical location of the contact. Inspired by the 'GEO' property specified in RFC 2426 Sec. 3.4.2^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasLocation">nco:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>nrl:MaxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : hasName^^xsd:string</para>
    ///   <para>rdfs:comment : Attaches name information to a contact.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasName">nco:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>nrl:MaxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : hasPersonName^^xsd:string</para>
    ///   <para>rdfs:comment : Attaches name information to a person contact.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPersonName">nco:hasPersonName</a>
    /// </summary>
    let hasPersonName = _prefixId.prefix "hasPersonName"
    /// <summary>
    ///   <para>rdfs:label : hasPhoneNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A number for telephony communication with the object represented by this Contact. An equivalent of the 'TEL' property defined in RFC 2426 Sec. 3.3.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPhoneNumber">nco:hasPhoneNumber</a>
    /// </summary>
    let hasPhoneNumber = _prefixId.prefix "hasPhoneNumber"
    /// <summary>
    ///   <para>rdfs:label : hasPostalAddress^^xsd:string</para>
    ///   <para>rdfs:comment : The default Address for a Contact. An equivalent of the 'ADR' property as defined in RFC 2426 Sec. 3.2.1.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPostalAddress">nco:hasPostalAddress</a>
    /// </summary>
    let hasPostalAddress = _prefixId.prefix "hasPostalAddress"
    /// <summary>
    ///   <para>rdfs:label : hobby^^xsd:string</para>
    ///   <para>rdfs:comment : A hobby associated with a PersonContact. This property can be used to express hobbies and interests.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hobby">nco:hobby</a>
    /// </summary>
    let hobby = _prefixId.prefix "hobby"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : imAccountType^^xsd:string</para>
    ///   <para>rdfs:comment : Type of the IM account. This may be the name of the service that provides the IM functionality. Examples might include Jabber, ICQ, MSN etc^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imAccountType">nco:imAccountType</a>
    /// </summary>
    let imAccountType = _prefixId.prefix "imAccountType"
    let imCapabilityAudio = _prefixId.prefix "imCapabilityAudio"
    let imCapabilityText = _prefixId.prefix "imCapabilityText"
    let imCapabilityVideo = _prefixId.prefix "imCapabilityVideo"
    /// <summary>
    ///   <para>rdfs:label : imID^^xsd:string</para>
    ///   <para>rdfs:comment : Identifier of the IM account. Examples of such identifier might include ICQ UINs, Jabber IDs, Skype names etc.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imID">nco:imID</a>
    /// </summary>
    let imID = _prefixId.prefix "imID"
    /// <summary>
    ///   <para>rdfs:label : imNickname^^xsd:string</para>
    ///   <para>rdfs:comment : A nickname attached to a particular IM Account.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imNickname">nco:imNickname</a>
    /// </summary>
    let imNickname = _prefixId.prefix "imNickname"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : imStatus^^xsd:string</para>
    ///   <para>rdfs:comment : Current status of the given IM account. When this property is set, the nco:imStatusType should also always be set. Applications should attempt to parse this property to determine the presence, only falling back to the nco:imStatusType property in the case that this property's value is unrecognised. Values for this property may include 'available', 'offline', 'busy' etc. The exact choice of them is unspecified, although it is recommended to follow the guidance of the Telepathy project when choosing a string identifier http://telepathy.freedesktop.org/spec/Connection_Interface_Simple_Presence.html#description^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatus">nco:imStatus</a>
    /// </summary>
    let imStatus = _prefixId.prefix "imStatus"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : imStatusMessage^^xsd:string</para>
    ///   <para>rdfs:comment : A feature common in most IM systems. A message left by the user for all his/her contacts to see.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatusMessage">nco:imStatusMessage</a>
    /// </summary>
    let imStatusMessage = _prefixId.prefix "imStatusMessage"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : instant messaging status type^^xsd:string</para>
    ///   <para>rdfs:comment : Current status type of the given IM account. When this property is set, the nco:imStatus property should also always be set. Applications should attempt to parse the nco:imStatus property to determine the presence, only falling back to this property in the case that the nco:imStatus property's value is unrecognised.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatusType">nco:imStatusType</a>
    /// </summary>
    let imStatusType = _prefixId.prefix "imStatusType"
    /// <summary>
    ///   <para>rdfs:label : isKnownBy^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the local IMAccount by which this IMAccount is accessed. This does not imply membership of a contact list.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#isAccessedBy">nco:isAccessedBy</a>
    /// </summary>
    let isAccessedBy = _prefixId.prefix "isAccessedBy"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : isBlocked^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that this IMAccount has been blocked.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#isBlocked">nco:isBlocked</a>
    /// </summary>
    let isBlocked = _prefixId.prefix "isBlocked"
    /// <summary>
    ///   <para>rdfs:label : key^^xsd:string</para>
    ///   <para>rdfs:comment : An encryption key attached to a contact. Inspired by the KEY property defined in RFC 2426 sec. 3.7.2^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#key">nco:key</a>
    /// </summary>
    let key = _prefixId.prefix "key"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : locality^^xsd:string</para>
    ///   <para>rdfs:comment : Locality or City. Inspired by the fourth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#locality">nco:locality</a>
    /// </summary>
    let locality = _prefixId.prefix "locality"
    /// <summary>
    ///   <para>rdfs:label : logo^^xsd:string</para>
    ///   <para>rdfs:comment : Logo of a company. Inspired by the LOGO property defined in RFC 2426 sec. 3.5.3^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#logo">nco:logo</a>
    /// </summary>
    let logo = _prefixId.prefix "logo"
    let male = _prefixId.prefix "male"
    /// <summary>
    ///   <para>rdfs:label : nameAdditional^^xsd:string</para>
    ///   <para>rdfs:comment : Additional given name of an object represented by this contact. See documentation for 'nameFamily' property for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameAdditional">nco:nameAdditional</a>
    /// </summary>
    let nameAdditional = _prefixId.prefix "nameAdditional"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : nameFamily^^xsd:string</para>
    ///   <para>rdfs:comment : The family name of an Object represented by this Contact. These applies to people that have more than one given name. The 'first' one is considered 'the' given name (see nameGiven) property. All additional ones are considered 'additional' names. The name inherited from parents is the 'family name'. e.g. For Dr. John Phil Paul Stevenson Jr. M.D. A.C.P. we have contact with: honorificPrefix: 'Dr.', nameGiven: 'John', nameAdditional: 'Phil', nameAdditional: 'Paul', nameFamily: 'Stevenson', honorificSuffix: 'Jr.', honorificSuffix: 'M.D.', honorificSuffix: 'A.C.P.'. These properties form an equivalent of the compound 'N' property as defined in RFC 2426 Sec. 3.1.2^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameFamily">nco:nameFamily</a>
    /// </summary>
    let nameFamily = _prefixId.prefix "nameFamily"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : nameGiven^^xsd:string</para>
    ///   <para>rdfs:comment : The given name for the object represented by this Contact. See documentation for 'nameFamily' property for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameGiven">nco:nameGiven</a>
    /// </summary>
    let nameGiven = _prefixId.prefix "nameGiven"
    /// <summary>
    ///   <para>rdfs:label : nameHonorificPrefix^^xsd:string</para>
    ///   <para>rdfs:comment : A prefix for the name of the object represented by this Contact. See documentation for the 'nameFamily' property for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameHonorificPrefix">nco:nameHonorificPrefix</a>
    /// </summary>
    let nameHonorificPrefix = _prefixId.prefix "nameHonorificPrefix"
    /// <summary>
    ///   <para>rdfs:label : nameHonorificSuffix^^xsd:string</para>
    ///   <para>rdfs:comment : A suffix for the name of the Object represented by the given object. See documentation for the 'nameFamily' for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameHonorificSuffix">nco:nameHonorificSuffix</a>
    /// </summary>
    let nameHonorificSuffix = _prefixId.prefix "nameHonorificSuffix"
    /// <summary>
    ///   <para>rdfs:label : nickname^^xsd:string</para>
    ///   <para>rdfs:comment : A nickname of the Object represented by this Contact. This is an equivalent of the 'NICKNAME' property as defined in RFC 2426 Sec. 3.1.3.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nickname">nco:nickname</a>
    /// </summary>
    let nickname = _prefixId.prefix "nickname"
    /// <summary>
    ///   <para>rdfs:label : note^^xsd:string</para>
    ///   <para>rdfs:comment : A note about the object represented by this Contact. An equivalent for the 'NOTE' property defined in RFC 2426 Sec. 3.6.2^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#note">nco:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : org^^xsd:string</para>
    ///   <para>rdfs:comment : Name of an organization or a unit within an organization the object represented by a Contact is associated with. An equivalent of the 'ORG' property defined in RFC 2426 Sec. 3.5.5^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#org">nco:org</a>
    /// </summary>
    let org = _prefixId.prefix "org"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : phoneNumber^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#phoneNumber">nco:phoneNumber</a>
    /// </summary>
    let phoneNumber = _prefixId.prefix "phoneNumber"
    /// <summary>
    ///   <para>rdfs:label : photo^^xsd:string</para>
    ///   <para>rdfs:comment : Photograph attached to a Contact. The DataObject referred to by this property is usually interpreted as an nfo:Image. Inspired by the PHOTO property defined in RFC 2426 sec. 3.1.4^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#photo">nco:photo</a>
    /// </summary>
    let photo = _prefixId.prefix "photo"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : pobox^^xsd:string</para>
    ///   <para>rdfs:comment : Post office box. This is the first part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#pobox">nco:pobox</a>
    /// </summary>
    let pobox = _prefixId.prefix "pobox"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : postalcode^^xsd:string</para>
    ///   <para>rdfs:comment : Postal Code. Inspired by the sixth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#postalcode">nco:postalcode</a>
    /// </summary>
    let postalcode = _prefixId.prefix "postalcode"
    /// <summary>
    ///   <para>rdfs:label : publisher^^xsd:string</para>
    ///   <para>rdfs:comment : An entity responsible for making the InformationElement available.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#publisher">nco:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>rdfs:label : publishesPresenceTo^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that this IMAccount publishes its presence information to the other IMAccount.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#publishesPresenceTo">nco:publishesPresenceTo</a>
    /// </summary>
    let publishesPresenceTo = _prefixId.prefix "publishesPresenceTo"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : region^^xsd:string</para>
    ///   <para>rdfs:comment : Region. Inspired by the fifth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#region">nco:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    /// <summary>
    ///   <para>rdfs:label : representative^^xsd:string</para>
    ///   <para>rdfs:comment : An object that represent an object represented by this Contact. Usually this property is used to link a Contact to an organization, to a contact to the representative of this organization the user directly interacts with. An equivalent for the 'AGENT' property defined in RFC 2426 Sec. 3.5.4^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#representative">nco:representative</a>
    /// </summary>
    let representative = _prefixId.prefix "representative"

    /// <summary>
    ///   <para>rdfs:label : requestedPresenceSubscriptionTo^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that this IMAccount has requested a subscription to the presence information of the other IMAccount.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#requestedPresenceSubscriptionTo">nco:requestedPresenceSubscriptionTo</a>
    /// </summary>
    let requestedPresenceSubscriptionTo =
        _prefixId.prefix "requestedPresenceSubscriptionTo"

    /// <summary>
    ///   <para>rdfs:label : role^^xsd:string</para>
    ///   <para>rdfs:comment : Role an object represented by this contact represents in the organization. This might include 'Programmer', 'Manager', 'Sales Representative'. Be careful to avoid confusion with the title property. An equivalent of the 'ROLE' property as defined in RFC 2426. Sec. 3.5.2. Note the difference between nco:Role class and nco:role property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#role">nco:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>rdfs:label : sound^^xsd:string</para>
    ///   <para>rdfs:comment : Sound clip attached to a Contact. The DataObject referred to by this property is usually interpreted as an nfo:Audio. Inspired by the SOUND property defined in RFC 2425 sec. 3.6.6.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#sound">nco:sound</a>
    /// </summary>
    let sound = _prefixId.prefix "sound"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : start^^xsd:string</para>
    ///   <para>rdfs:comment : Start datetime for the role, such as: the datetime of joining a project or organization, datetime of starting employment, datetime of marriage^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#start">nco:start</a>
    /// </summary>
    let start = _prefixId.prefix "start"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : streetAddress^^xsd:string</para>
    ///   <para>rdfs:comment : The streed address. Inspired by the third part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#streetAddress">nco:streetAddress</a>
    /// </summary>
    let streetAddress = _prefixId.prefix "streetAddress"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>rdfs:comment : The official title  the object represented by this contact in an organization. E.g. 'CEO', 'Director, Research and Development', 'Junior Software Developer/Analyst' etc. An equivalent of the 'TITLE' property defined in RFC 2426 Sec. 3.5.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#title">nco:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : url^^xsd:string</para>
    ///   <para>rdfs:comment : A uniform resource locator associated with the given role of a Contact. Inspired by the 'URL' property defined in RFC 2426 Sec. 3.6.8.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#url">nco:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : voiceMail^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates if the given number accepts voice mail. (e.g. there is an answering machine). Inspired by TYPE=msg parameter of the TEL property defined in RFC 2426 sec. 3.3.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#voiceMail">nco:voiceMail</a>
    /// </summary>
    let voiceMail = _prefixId.prefix "voiceMail"
    /// <summary>
    ///   <para>rdfs:label : websiteUrl^^xsd:string</para>
    ///   <para>rdfs:comment : A url of a website.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#websiteUrl">nco:websiteUrl</a>
    /// </summary>
    let websiteUrl = _prefixId.prefix "websiteUrl"
