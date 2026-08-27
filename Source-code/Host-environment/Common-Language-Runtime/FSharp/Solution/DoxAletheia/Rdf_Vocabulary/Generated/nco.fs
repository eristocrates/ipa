namespace http.www.semanticdesktop.org.ontologies._2007._03._22.nco.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nco =
    let _namespace_iri = Namespace_Iri nco |> NamespaceIRI
    /// <summary>
    ///   <para>nco:Affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Aggregates three properties defined in RFC2426. Originally all three were attached directly to a person. One person could have only one title and one role within one organization. This class is intended to lift this limitation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Affiliation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Affiliation">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Affiliation</seealso>
    let Affiliation = Prefixed_Name(nco, "Affiliation") |> PrefixedName
    /// <summary>
    ///   <para>nco:AudioIMAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Deprecated in favour of nco:imCapabilityAudio."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AudioIMAccount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#AudioIMAccount">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#AudioIMAccount</seealso>
    let AudioIMAccount = Prefixed_Name(nco, "AudioIMAccount") |> PrefixedName
    /// <summary>
    ///   <para>nco:BbsNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Bulletin Board System (BBS) phone number. Inspired by the (TYPE=bbsl) parameter of the TEL property as defined in RFC 2426 sec  3.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BbsNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#BbsNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#BbsNumber</seealso>
    let BbsNumber = Prefixed_Name(nco, "BbsNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:BirthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A class representing a person contact's birth date information. Possesses various attributes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BirthDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#BirthDate">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#BirthDate</seealso>
    let BirthDate = Prefixed_Name(nco, "BirthDate") |> PrefixedName
    /// <summary>
    ///   <para>nco:CarPhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A car phone number. Inspired by the (TYPE=car) parameter of the TEL property as defined in RFC 2426 sec  3.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CarPhoneNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#CarPhoneNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#CarPhoneNumber</seealso>
    let CarPhoneNumber = Prefixed_Name(nco, "CarPhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:CellPhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A cellular phone number. Inspired by the (TYPE=cell) parameter of the TEL property as defined in RFC 2426 sec  3.3.1. Usually a cellular phone can accept voice calls as well as textual messages (SMS), therefore this class has two superclasses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CellPhoneNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#CellPhoneNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#CellPhoneNumber</seealso>
    let CellPhoneNumber = Prefixed_Name(nco, "CellPhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:Contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Contact. A piece of data that can provide means to identify or communicate with an entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Contact">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Contact</seealso>
    let Contact = Prefixed_Name(nco, "Contact") |> PrefixedName
    /// <summary>
    ///   <para>nco:ContactGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A group of Contacts. Could be used to express a group in an addressbook or on a contact list of an IM application. One contact can belong to many groups."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContactGroup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactGroup">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactGroup</seealso>
    let ContactGroup = Prefixed_Name(nco, "ContactGroup") |> PrefixedName
    /// <summary>
    ///   <para>nco:ContactList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A contact list, this class represents an addressbook or a contact list of an IM application. Contacts inside a contact list can belong to contact groups."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContactList"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactList">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactList</seealso>
    let ContactList = Prefixed_Name(nco, "ContactList") |> PrefixedName

    /// <summary>
    ///   <para>nco:ContactListDataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An entity occuring on a contact list (usually interpreted as an nco:Contact)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContactListDataObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactListDataObject">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactListDataObject</seealso>
    let ContactListDataObject =
        Prefixed_Name(nco, "ContactListDataObject") |> PrefixedName

    /// <summary>
    ///   <para>nco:ContactMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A superclass for all contact media - ways to contact an entity represented by a Contact instance. Some of the subclasses of this class (the various kinds of telephone numbers and postal addresses) have been inspired by the values of the TYPE parameter of ADR and TEL properties defined in RFC 2426 sec. 3.2.1. and 3.3.1 respectively. Each value is represented by an appropriate subclass with two major exceptions TYPE=home and TYPE=work. They are to be expressed by the roles these contact media are attached to i.e. contact media with TYPE=home parameter are to be attached to the default role (nco:Contact or nco:PersonContact), whereas media with TYPE=work parameter should be attached to nco:Affiliation or nco:OrganizationContact."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContactMedium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactMedium">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ContactMedium</seealso>
    let ContactMedium = Prefixed_Name(nco, "ContactMedium") |> PrefixedName

    /// <summary>
    ///   <para>nco:DomesticDeliveryAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Domestic Delivery Addresse. Class inspired by TYPE=dom parameter of the ADR property defined in RFC 2426 sec. 3.2.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DomesticDeliveryAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#DomesticDeliveryAddress">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#DomesticDeliveryAddress</seealso>
    let DomesticDeliveryAddress =
        Prefixed_Name(nco, "DomesticDeliveryAddress") |> PrefixedName

    /// <summary>
    ///   <para>nco:EmailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An email address. The recommended best practice is to use mailto: uris for instances of this class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EmailAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#EmailAddress">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#EmailAddress</seealso>
    let EmailAddress = Prefixed_Name(nco, "EmailAddress") |> PrefixedName
    /// <summary>
    ///   <para>nco:FaxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A fax number. Inspired by the (TYPE=fax) parameter of the TEL property as defined in RFC 2426 sec  3.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FaxNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#FaxNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#FaxNumber</seealso>
    let FaxNumber = Prefixed_Name(nco, "FaxNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Gender. Instances of this class may include male and female."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Gender">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Gender</seealso>
    let Gender = Prefixed_Name(nco, "Gender") |> PrefixedName
    /// <summary>
    ///   <para>nco:Hobby</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Instances of this class represent personal hobbies and interests."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hobby"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Hobby">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Hobby</seealso>
    let Hobby = Prefixed_Name(nco, "Hobby") |> PrefixedName
    /// <summary>
    ///   <para>nco:IMAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An account in an Instant Messaging system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IMAccount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMAccount">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMAccount</seealso>
    let IMAccount = Prefixed_Name(nco, "IMAccount") |> PrefixedName
    /// <summary>
    ///   <para>nco:IMCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Capabilities of a cetain IMAccount."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"imCapability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMCapability">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMCapability</seealso>
    let IMCapability = Prefixed_Name(nco, "IMCapability") |> PrefixedName
    /// <summary>
    ///   <para>nco:IMStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The status type of an IMAccount. Based on the Connection_Presence_Type enumeration of the Telepathy project: http://telepathy.freedesktop.org/spec/Connection_Interface_Simple_Presence.html#Enum:Connection_Presence_Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"instant messaging status type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusType">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusType</seealso>
    let IMStatusType = Prefixed_Name(nco, "IMStatusType") |> PrefixedName

    /// <summary>
    ///   <para>nco:IMStatusTypeAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:IMStatusType</para>
    ///
    /// labels<para>"available"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeAvailable">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeAvailable</seealso>
    let IMStatusTypeAvailable =
        Prefixed_Name(nco, "IMStatusTypeAvailable") |> PrefixedName

    /// <summary>
    ///   <para>nco:IMStatusTypeAway</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:IMStatusType</para>
    ///
    /// labels<para>"away"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeAway">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeAway</seealso>
    let IMStatusTypeAway = Prefixed_Name(nco, "IMStatusTypeAway") |> PrefixedName
    /// <summary>
    ///   <para>nco:IMStatusTypeBusy</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:IMStatusType</para>
    ///
    /// labels<para>"busy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeBusy">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeBusy</seealso>
    let IMStatusTypeBusy = Prefixed_Name(nco, "IMStatusTypeBusy") |> PrefixedName

    /// <summary>
    ///   <para>nco:IMStatusTypeExtendedAway</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:IMStatusType</para>
    ///
    /// labels<para>"extended away"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeExtendedAway">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeExtendedAway</seealso>
    let IMStatusTypeExtendedAway =
        Prefixed_Name(nco, "IMStatusTypeExtendedAway") |> PrefixedName

    /// <summary>
    ///   <para>nco:IMStatusTypeHidden</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:IMStatusType</para>
    ///
    /// labels<para>"hidden"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeHidden">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeHidden</seealso>
    let IMStatusTypeHidden = Prefixed_Name(nco, "IMStatusTypeHidden") |> PrefixedName
    /// <summary>
    ///   <para>nco:IMStatusTypeOffline</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:IMStatusType</para>
    ///
    /// labels<para>"offline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeOffline">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeOffline</seealso>
    let IMStatusTypeOffline = Prefixed_Name(nco, "IMStatusTypeOffline") |> PrefixedName
    /// <summary>
    ///   <para>nco:IMStatusTypeUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:IMStatusType</para>
    ///
    /// labels<para>"unknown"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeUnknown">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IMStatusTypeUnknown</seealso>
    let IMStatusTypeUnknown = Prefixed_Name(nco, "IMStatusTypeUnknown") |> PrefixedName

    /// <summary>
    ///   <para>nco:InternationalDeliveryAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"International Delivery Addresse. Class inspired by TYPE=intl parameter of the ADR property defined in RFC 2426 sec. 3.2.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InternationalDeliveryAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#InternationalDeliveryAddress">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#InternationalDeliveryAddress</seealso>
    let InternationalDeliveryAddress =
        Prefixed_Name(nco, "InternationalDeliveryAddress") |> PrefixedName

    /// <summary>
    ///   <para>nco:IsdnNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An ISDN phone number. Inspired by the (TYPE=isdn) parameter of the TEL property as defined in RFC 2426 sec  3.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IsdnNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IsdnNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#IsdnNumber</seealso>
    let IsdnNumber = Prefixed_Name(nco, "IsdnNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:MessagingNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A number that can accept textual messages."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MessagingNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#MessagingNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#MessagingNumber</seealso>
    let MessagingNumber = Prefixed_Name(nco, "MessagingNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:ModemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A modem phone number. Inspired by the (TYPE=modem) parameter of the TEL property as defined in RFC 2426 sec  3.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ModemNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ModemNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ModemNumber</seealso>
    let ModemNumber = Prefixed_Name(nco, "ModemNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A class representing a contact's name. Possesses various attributes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Name">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Name</seealso>
    let Name = Prefixed_Name(nco, "Name") |> PrefixedName
    /// <summary>
    ///   <para>nco:OrganizationContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Contact that denotes on Organization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OrganizationContact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#OrganizationContact">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#OrganizationContact</seealso>
    let OrganizationContact = Prefixed_Name(nco, "OrganizationContact") |> PrefixedName
    /// <summary>
    ///   <para>nco:PagerNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A pager phone number. Inspired by the (TYPE=pager) parameter of the TEL property as defined in RFC 2426 sec  3.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PagerNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PagerNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PagerNumber</seealso>
    let PagerNumber = Prefixed_Name(nco, "PagerNumber") |> PrefixedName

    /// <summary>
    ///   <para>nco:ParcelDeliveryAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Parcel Delivery Addresse. Class inspired by TYPE=parcel parameter of the ADR property defined in RFC 2426 sec. 3.2.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ParcelDeliveryAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ParcelDeliveryAddress">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#ParcelDeliveryAddress</seealso>
    let ParcelDeliveryAddress =
        Prefixed_Name(nco, "ParcelDeliveryAddress") |> PrefixedName

    /// <summary>
    ///   <para>nco:PcsNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Personal Communication Services Number. A class inspired by the TYPE=pcs parameter of the TEL property defined in RFC 2426 sec. 3.3.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PcsNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PcsNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PcsNumber</seealso>
    let PcsNumber = Prefixed_Name(nco, "PcsNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:PersonContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Contact that denotes a Person. A person can have multiple Affiliations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PersonContact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PersonContact">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PersonContact</seealso>
    let PersonContact = Prefixed_Name(nco, "PersonContact") |> PrefixedName
    /// <summary>
    ///   <para>nco:PersonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A class representing a person contact's name. Possesses various attributes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PersonName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PersonName">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PersonName</seealso>
    let PersonName = Prefixed_Name(nco, "PersonName") |> PrefixedName
    /// <summary>
    ///   <para>nco:PhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A telephone number."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PhoneNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PhoneNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PhoneNumber</seealso>
    let PhoneNumber = Prefixed_Name(nco, "PhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:PostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A postal address. A class aggregating the various parts of a value for the 'ADR' property as defined in RFC 2426 Sec. 3.2.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PostalAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PostalAddress">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#PostalAddress</seealso>
    let PostalAddress = Prefixed_Name(nco, "PostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>nco:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A role played by a contact. Contacts that denote people, can have many roles (e.g. see the hasAffiliation property and Affiliation class). Contacts that denote Organizations or other Agents usually have one role.  Each role can introduce additional contact media."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Role">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#Role</seealso>
    let Role = Prefixed_Name(nco, "Role") |> PrefixedName
    /// <summary>
    ///   <para>nco:VideoIMAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Deprecated in favour of nco:imCapabilityVideo."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"VideoIMAccount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VideoIMAccount">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VideoIMAccount</seealso>
    let VideoIMAccount = Prefixed_Name(nco, "VideoIMAccount") |> PrefixedName

    /// <summary>
    ///   <para>nco:VideoTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Video telephone number. A class inspired by the TYPE=video parameter of the TEL property defined in RFC 2426 sec. 3.3.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"VideoTelephoneNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VideoTelephoneNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VideoTelephoneNumber</seealso>
    let VideoTelephoneNumber =
        Prefixed_Name(nco, "VideoTelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>nco:VoicePhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A telephone number with voice communication capabilities. Class inspired by the TYPE=voice parameter of the TEL property defined in RFC 2426 sec. 3.3.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"VoicePhoneNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VoicePhoneNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#VoicePhoneNumber</seealso>
    let VoicePhoneNumber = Prefixed_Name(nco, "VoicePhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:addressLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The geographical location of a postal address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"addressLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#addressLocation">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#addressLocation</seealso>
    let addressLocation = Prefixed_Name(nco, "addressLocation") |> PrefixedName
    /// <summary>
    ///   <para>nco:age</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the age of a person contact."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"age"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#age">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#age</seealso>
    let age = Prefixed_Name(nco, "age") |> PrefixedName
    /// <summary>
    ///   <para>nco:belongsToGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a Contact with a ContactGroup it belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"addressLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#belongsToGroup">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#belongsToGroup</seealso>
    let belongsToGroup = Prefixed_Name(nco, "belongsToGroup") |> PrefixedName
    /// <summary>
    ///   <para>nco:birthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Birth date of the object represented by this Contact. An equivalent of the 'BDAY' property as defined in RFC 2426 Sec. 3.1.5."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"birthDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#birthDate">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#birthDate</seealso>
    let birthDate = Prefixed_Name(nco, "birthDate") |> PrefixedName
    /// <summary>
    ///   <para>nco:blogUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A Blog url."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"blogUrl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#blogUrl">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#blogUrl</seealso>
    let blogUrl = Prefixed_Name(nco, "blogUrl") |> PrefixedName
    /// <summary>
    ///   <para>nco:contactGroupName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name of the contact group. This property was NOT defined
    ///     in the VCARD standard. See documentation of the 'ContactGroup' class for
    ///     details"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contactGroupName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactGroupName">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactGroupName</seealso>
    let contactGroupName = Prefixed_Name(nco, "contactGroupName") |> PrefixedName

    /// <summary>
    ///   <para>nco:contactMediumComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A comment about the contact medium. (Deprecated in favor of nie:comment or nao:description - based on the context)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contactMediumComment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactMediumComment">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactMediumComment</seealso>
    let contactMediumComment =
        Prefixed_Name(nco, "contactMediumComment") |> PrefixedName

    /// <summary>
    ///   <para>nco:contactUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A value that represents a globally unique  identifier corresponding to the individual or resource associated with the Contact. An equivalent of the 'UID' property defined in RFC 2426 Sec. 3.6.7"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contactUID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactUID">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contactUID</seealso>
    let contactUID = Prefixed_Name(nco, "contactUID") |> PrefixedName
    /// <summary>
    ///   <para>nco:containsContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A property used to group contacts into contact groups. This
    ///     property was NOT defined in the VCARD standard. See documentation for the
    ///     'ContactList' class for details"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"containsContact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#containsContact">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#containsContact</seealso>
    let containsContact = Prefixed_Name(nco, "containsContact") |> PrefixedName
    /// <summary>
    ///   <para>nco:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An entity responsible for making contributions to the content of the InformationElement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contributor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contributor">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#contributor</seealso>
    let contributor = Prefixed_Name(nco, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>nco:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A part of an address specyfing the country. Inspired by the seventh part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#country">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#country</seealso>
    let country = Prefixed_Name(nco, "country") |> PrefixedName
    /// <summary>
    ///   <para>nco:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Creator of an information element, an entity primarily responsible for the creation of the content of the data object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#creator">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#creator</seealso>
    let creator = Prefixed_Name(nco, "creator") |> PrefixedName
    /// <summary>
    ///   <para>nco:department</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Department. The organizational unit within the organization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"department"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#department">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#department</seealso>
    let department = Prefixed_Name(nco, "department") |> PrefixedName
    /// <summary>
    ///   <para>nco:emailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"emailAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#emailAddress">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#emailAddress</seealso>
    let emailAddress = Prefixed_Name(nco, "emailAddress") |> PrefixedName
    /// <summary>
    ///   <para>nco:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"End datetime for the role, such as: the datetime of leaving a project or organization, datetime of ending employment, datetime of divorce. If absent or set to a date in the future, the role is currently active."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"end"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#end">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#end</seealso>
    let end_ = Prefixed_Name(nco, "end") |> PrefixedName
    /// <summary>
    ///   <para>nco:extendedAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An extended part of an address. This field might be used to express parts of an address that aren't include in the name of the Contact but also aren't part of the actual location. Usually the streed address and following fields are enough for a postal letter to arrive. Examples may include ('University of California Campus building 45', 'Sears Tower 34th floor' etc.) Inspired by the second part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"extendedAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#extendedAddress">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#extendedAddress</seealso>
    let extendedAddress = Prefixed_Name(nco, "extendedAddress") |> PrefixedName
    /// <summary>
    ///   <para>nco:female</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:Gender</para>
    ///   <para>"A Female"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"female"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#female">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#female</seealso>
    let female = Prefixed_Name(nco, "female") |> PrefixedName
    /// <summary>
    ///   <para>nco:foafUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The URL of the FOAF file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"foafUrl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#foafUrl">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#foafUrl</seealso>
    let foafUrl = Prefixed_Name(nco, "foafUrl") |> PrefixedName
    /// <summary>
    ///   <para>nco:fullname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To specify the formatted text corresponding to the name of the object the Contact represents. An equivalent of the FN property as defined in RFC 2426 Sec. 3.1.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fullname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#fullname">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#fullname</seealso>
    let fullname = Prefixed_Name(nco, "fullname") |> PrefixedName
    /// <summary>
    ///   <para>nco:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Gender of the given contact."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#gender">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#gender</seealso>
    let gender = Prefixed_Name(nco, "gender") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a PersonContact with an Affiliation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasAffiliation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasAffiliation">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasAffiliation</seealso>
    let hasAffiliation = Prefixed_Name(nco, "hasAffiliation") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasBirthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Attaches birth date information to a person contact."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasBirthDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasBirthDate">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasBirthDate</seealso>
    let hasBirthDate = Prefixed_Name(nco, "hasBirthDate") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasContactMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A superProperty for all properties linking a Contact to an instance of a contact medium."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasContactMedium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasContactMedium">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasContactMedium</seealso>
    let hasContactMedium = Prefixed_Name(nco, "hasContactMedium") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasCustomAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A generic contact attribute introduced in order to enable customisation of contact details. Thus, systems using the NCO to model contact and person information, can introduce customised attributes by creating them as a subproperty of this one."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasCustomAttribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasCustomAttribute">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasCustomAttribute</seealso>
    let hasCustomAttribute = Prefixed_Name(nco, "hasCustomAttribute") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasEmailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An address for electronic mail communication with the object specified by this contact. An equivalent of the 'EMAIL' property as defined in RFC 2426 Sec. 3.3.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasEmailAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasEmailAddress">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasEmailAddress</seealso>
    let hasEmailAddress = Prefixed_Name(nco, "hasEmailAddress") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasIMAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that an Instant Messaging account owned by an entity represented by this contact."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasIMAccount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasIMAccount">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasIMAccount</seealso>
    let hasIMAccount = Prefixed_Name(nco, "hasIMAccount") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasIMCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that an IMAccount has a certain capability."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasIMCapability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasIMCapability">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasIMCapability</seealso>
    let hasIMCapability = Prefixed_Name(nco, "hasIMCapability") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Geographical location of the contact. Inspired by the 'GEO' property specified in RFC 2426 Sec. 3.4.2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasLocation">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasLocation</seealso>
    let hasLocation = Prefixed_Name(nco, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Attaches name information to a contact."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasName">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasName</seealso>
    let hasName = Prefixed_Name(nco, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasPersonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Attaches name information to a person contact."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPersonName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPersonName">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPersonName</seealso>
    let hasPersonName = Prefixed_Name(nco, "hasPersonName") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasPhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A number for telephony communication with the object represented by this Contact. An equivalent of the 'TEL' property defined in RFC 2426 Sec. 3.3.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPhoneNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPhoneNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPhoneNumber</seealso>
    let hasPhoneNumber = Prefixed_Name(nco, "hasPhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:hasPostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The default Address for a Contact. An equivalent of the 'ADR' property as defined in RFC 2426 Sec. 3.2.1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPostalAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPostalAddress">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hasPostalAddress</seealso>
    let hasPostalAddress = Prefixed_Name(nco, "hasPostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>nco:hobby</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A hobby associated with a PersonContact. This property can be used to express hobbies and interests."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hobby"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hobby">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#hobby</seealso>
    let hobby = Prefixed_Name(nco, "hobby") |> PrefixedName
    /// <summary>
    ///   <para>nco:imAccountType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Type of the IM account. This may be the name of the service that provides the IM functionality. Examples might include Jabber, ICQ, MSN etc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"imAccountType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imAccountType">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imAccountType</seealso>
    let imAccountType = Prefixed_Name(nco, "imAccountType") |> PrefixedName
    /// <summary>
    ///   <para>nco:imCapabilityAudio</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityAudio">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityAudio</seealso>
    let imCapabilityAudio = Prefixed_Name(nco, "imCapabilityAudio") |> PrefixedName
    /// <summary>
    ///   <para>nco:imCapabilityText</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityText">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityText</seealso>
    let imCapabilityText = Prefixed_Name(nco, "imCapabilityText") |> PrefixedName
    /// <summary>
    ///   <para>nco:imCapabilityVideo</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityVideo">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imCapabilityVideo</seealso>
    let imCapabilityVideo = Prefixed_Name(nco, "imCapabilityVideo") |> PrefixedName
    /// <summary>
    ///   <para>nco:imID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifier of the IM account. Examples of such identifier might include ICQ UINs, Jabber IDs, Skype names etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"imID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imID">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imID</seealso>
    let imID = Prefixed_Name(nco, "imID") |> PrefixedName
    /// <summary>
    ///   <para>nco:imNickname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A nickname attached to a particular IM Account."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"imNickname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imNickname">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imNickname</seealso>
    let imNickname = Prefixed_Name(nco, "imNickname") |> PrefixedName
    /// <summary>
    ///   <para>nco:imStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Current status of the given IM account. When this property is set, the nco:imStatusType should also always be set. Applications should attempt to parse this property to determine the presence, only falling back to the nco:imStatusType property in the case that this property's value is unrecognised. Values for this property may include 'available', 'offline', 'busy' etc. The exact choice of them is unspecified, although it is recommended to follow the guidance of the Telepathy project when choosing a string identifier http://telepathy.freedesktop.org/spec/Connection_Interface_Simple_Presence.html#description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"imStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatus">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatus</seealso>
    let imStatus = Prefixed_Name(nco, "imStatus") |> PrefixedName
    /// <summary>
    ///   <para>nco:imStatusMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A feature common in most IM systems. A message left by the user for all his/her contacts to see."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"imStatusMessage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatusMessage">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatusMessage</seealso>
    let imStatusMessage = Prefixed_Name(nco, "imStatusMessage") |> PrefixedName
    /// <summary>
    ///   <para>nco:imStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Current status type of the given IM account. When this property is set, the nco:imStatus property should also always be set. Applications should attempt to parse the nco:imStatus property to determine the presence, only falling back to this property in the case that the nco:imStatus property's value is unrecognised."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"instant messaging status type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatusType">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#imStatusType</seealso>
    let imStatusType = Prefixed_Name(nco, "imStatusType") |> PrefixedName
    /// <summary>
    ///   <para>nco:isAccessedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the local IMAccount by which this IMAccount is accessed. This does not imply membership of a contact list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isKnownBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#isAccessedBy">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#isAccessedBy</seealso>
    let isAccessedBy = Prefixed_Name(nco, "isAccessedBy") |> PrefixedName
    /// <summary>
    ///   <para>nco:isBlocked</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that this IMAccount has been blocked."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isBlocked"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#isBlocked">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#isBlocked</seealso>
    let isBlocked = Prefixed_Name(nco, "isBlocked") |> PrefixedName
    /// <summary>
    ///   <para>nco:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An encryption key attached to a contact. Inspired by the KEY property defined in RFC 2426 sec. 3.7.2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#key">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#key</seealso>
    let key = Prefixed_Name(nco, "key") |> PrefixedName
    /// <summary>
    ///   <para>nco:locality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Locality or City. Inspired by the fourth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"locality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#locality">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#locality</seealso>
    let locality = Prefixed_Name(nco, "locality") |> PrefixedName
    /// <summary>
    ///   <para>nco:logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Logo of a company. Inspired by the LOGO property defined in RFC 2426 sec. 3.5.3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#logo">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#logo</seealso>
    let logo = Prefixed_Name(nco, "logo") |> PrefixedName
    /// <summary>
    ///   <para>nco:male</para>
    /// </summary>
    /// <remarks>
    ///   <para>nco:Gender</para>
    ///   <para>"A Male"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"male"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#male">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#male</seealso>
    let male = Prefixed_Name(nco, "male") |> PrefixedName
    /// <summary>
    ///   <para>nco:nameAdditional</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Additional given name of an object represented by this contact. See documentation for 'nameFamily' property for details."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nameAdditional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameAdditional">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameAdditional</seealso>
    let nameAdditional = Prefixed_Name(nco, "nameAdditional") |> PrefixedName
    /// <summary>
    ///   <para>nco:nameFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The family name of an Object represented by this Contact. These applies to people that have more than one given name. The 'first' one is considered 'the' given name (see nameGiven) property. All additional ones are considered 'additional' names. The name inherited from parents is the 'family name'. e.g. For Dr. John Phil Paul Stevenson Jr. M.D. A.C.P. we have contact with: honorificPrefix: 'Dr.', nameGiven: 'John', nameAdditional: 'Phil', nameAdditional: 'Paul', nameFamily: 'Stevenson', honorificSuffix: 'Jr.', honorificSuffix: 'M.D.', honorificSuffix: 'A.C.P.'. These properties form an equivalent of the compound 'N' property as defined in RFC 2426 Sec. 3.1.2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nameFamily"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameFamily">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameFamily</seealso>
    let nameFamily = Prefixed_Name(nco, "nameFamily") |> PrefixedName
    /// <summary>
    ///   <para>nco:nameGiven</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The given name for the object represented by this Contact. See documentation for 'nameFamily' property for details."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nameGiven"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameGiven">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameGiven</seealso>
    let nameGiven = Prefixed_Name(nco, "nameGiven") |> PrefixedName
    /// <summary>
    ///   <para>nco:nameHonorificPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A prefix for the name of the object represented by this Contact. See documentation for the 'nameFamily' property for details."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nameHonorificPrefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameHonorificPrefix">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameHonorificPrefix</seealso>
    let nameHonorificPrefix = Prefixed_Name(nco, "nameHonorificPrefix") |> PrefixedName
    /// <summary>
    ///   <para>nco:nameHonorificSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A suffix for the name of the Object represented by the given object. See documentation for the 'nameFamily' for details."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nameHonorificSuffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameHonorificSuffix">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nameHonorificSuffix</seealso>
    let nameHonorificSuffix = Prefixed_Name(nco, "nameHonorificSuffix") |> PrefixedName
    /// <summary>
    ///   <para>nco:nickname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A nickname of the Object represented by this Contact. This is an equivalent of the 'NICKNAME' property as defined in RFC 2426 Sec. 3.1.3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nickname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nickname">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#nickname</seealso>
    let nickname = Prefixed_Name(nco, "nickname") |> PrefixedName
    /// <summary>
    ///   <para>nco:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A note about the object represented by this Contact. An equivalent for the 'NOTE' property defined in RFC 2426 Sec. 3.6.2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#note">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#note</seealso>
    let note = Prefixed_Name(nco, "note") |> PrefixedName
    /// <summary>
    ///   <para>nco:org</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of an organization or a unit within an organization the object represented by a Contact is associated with. An equivalent of the 'ORG' property defined in RFC 2426 Sec. 3.5.5"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"org"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#org">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#org</seealso>
    let org = Prefixed_Name(nco, "org") |> PrefixedName
    /// <summary>
    ///   <para>nco:phoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"phoneNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#phoneNumber">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#phoneNumber</seealso>
    let phoneNumber = Prefixed_Name(nco, "phoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>nco:photo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Photograph attached to a Contact. The DataObject referred to by this property is usually interpreted as an nfo:Image. Inspired by the PHOTO property defined in RFC 2426 sec. 3.1.4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"photo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#photo">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#photo</seealso>
    let photo = Prefixed_Name(nco, "photo") |> PrefixedName
    /// <summary>
    ///   <para>nco:pobox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Post office box. This is the first part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pobox"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#pobox">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#pobox</seealso>
    let pobox = Prefixed_Name(nco, "pobox") |> PrefixedName
    /// <summary>
    ///   <para>nco:postalcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Postal Code. Inspired by the sixth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"postalcode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#postalcode">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#postalcode</seealso>
    let postalcode = Prefixed_Name(nco, "postalcode") |> PrefixedName
    /// <summary>
    ///   <para>nco:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An entity responsible for making the InformationElement available."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#publisher">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#publisher</seealso>
    let publisher = Prefixed_Name(nco, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>nco:publishesPresenceTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that this IMAccount publishes its presence information to the other IMAccount."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"publishesPresenceTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#publishesPresenceTo">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#publishesPresenceTo</seealso>
    let publishesPresenceTo = Prefixed_Name(nco, "publishesPresenceTo") |> PrefixedName
    /// <summary>
    ///   <para>nco:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Region. Inspired by the fifth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#region">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#region</seealso>
    let region = Prefixed_Name(nco, "region") |> PrefixedName
    /// <summary>
    ///   <para>nco:representative</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An object that represent an object represented by this Contact. Usually this property is used to link a Contact to an organization, to a contact to the representative of this organization the user directly interacts with. An equivalent for the 'AGENT' property defined in RFC 2426 Sec. 3.5.4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"representative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#representative">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#representative</seealso>
    let representative = Prefixed_Name(nco, "representative") |> PrefixedName

    /// <summary>
    ///   <para>nco:requestedPresenceSubscriptionTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that this IMAccount has requested a subscription to the presence information of the other IMAccount."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"requestedPresenceSubscriptionTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#requestedPresenceSubscriptionTo">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#requestedPresenceSubscriptionTo</seealso>
    let requestedPresenceSubscriptionTo =
        Prefixed_Name(nco, "requestedPresenceSubscriptionTo") |> PrefixedName

    /// <summary>
    ///   <para>nco:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Role an object represented by this contact represents in the organization. This might include 'Programmer', 'Manager', 'Sales Representative'. Be careful to avoid confusion with the title property. An equivalent of the 'ROLE' property as defined in RFC 2426. Sec. 3.5.2. Note the difference between nco:Role class and nco:role property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#role">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#role</seealso>
    let role = Prefixed_Name(nco, "role") |> PrefixedName
    /// <summary>
    ///   <para>nco:sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Sound clip attached to a Contact. The DataObject referred to by this property is usually interpreted as an nfo:Audio. Inspired by the SOUND property defined in RFC 2425 sec. 3.6.6."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#sound">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#sound</seealso>
    let sound = Prefixed_Name(nco, "sound") |> PrefixedName
    /// <summary>
    ///   <para>nco:start</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Start datetime for the role, such as: the datetime of joining a project or organization, datetime of starting employment, datetime of marriage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"start"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#start">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#start</seealso>
    let start = Prefixed_Name(nco, "start") |> PrefixedName
    /// <summary>
    ///   <para>nco:streetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The streed address. Inspired by the third part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"streetAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#streetAddress">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#streetAddress</seealso>
    let streetAddress = Prefixed_Name(nco, "streetAddress") |> PrefixedName
    /// <summary>
    ///   <para>nco:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The official title  the object represented by this contact in an organization. E.g. 'CEO', 'Director, Research and Development', 'Junior Software Developer/Analyst' etc. An equivalent of the 'TITLE' property defined in RFC 2426 Sec. 3.5.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#title">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#title</seealso>
    let title = Prefixed_Name(nco, "title") |> PrefixedName
    /// <summary>
    ///   <para>nco:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A uniform resource locator associated with the given role of a Contact. Inspired by the 'URL' property defined in RFC 2426 Sec. 3.6.8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#url">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#url</seealso>
    let url = Prefixed_Name(nco, "url") |> PrefixedName
    /// <summary>
    ///   <para>nco:voiceMail</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates if the given number accepts voice mail. (e.g. there is an answering machine). Inspired by TYPE=msg parameter of the TEL property defined in RFC 2426 sec. 3.3.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"voiceMail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#voiceMail">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#voiceMail</seealso>
    let voiceMail = Prefixed_Name(nco, "voiceMail") |> PrefixedName
    /// <summary>
    ///   <para>nco:websiteUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A url of a website."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"websiteUrl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/03/22/nco#websiteUrl">http://www.semanticdesktop.org/ontologies/2007/03/22/nco#websiteUrl</seealso>
    let websiteUrl = Prefixed_Name(nco, "websiteUrl") |> PrefixedName
