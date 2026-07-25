namespace http.tracker.api.gnome.org.ontology.v3.nco.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tnco =
    let _namespace_iri = Namespace_Iri tnco |> NamespaceIRI
    /// <summary>
    ///   <para>tnco:Affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Aggregates three properties defined in RFC2426. Originally all three were attached directly to a person. One person could have only one title and one role within one organization. This class is intended to lift this limitation.</para>
    /// labels<para>Affiliation</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#Affiliation">http://tracker.api.gnome.org/ontology/v3/nco#Affiliation</seealso>
    let Affiliation = Prefixed_Name(tnco, "Affiliation") |> PrefixedName
    /// <summary>
    ///   <para>tnco:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A role played by a contact. Contacts that denote people, can have many roles (e.g. see the hasAffiliation property and Affiliation class). Contacts that denote Organizations or other Agents usually have one role.  Each role can introduce additional contact media.</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#Role">http://tracker.api.gnome.org/ontology/v3/nco#Role</seealso>
    let Role = Prefixed_Name(tnco, "Role") |> PrefixedName
    /// <summary>
    ///   <para>tnco:BbsNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Bulletin Board System (BBS) phone number. Inspired by the (TYPE=bbsl) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.</para>
    /// labels<para>BbsNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#BbsNumber">http://tracker.api.gnome.org/ontology/v3/nco#BbsNumber</seealso>
    let BbsNumber = Prefixed_Name(tnco, "BbsNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:CarPhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A car phone number. Inspired by the (TYPE=car) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.</para>
    /// labels<para>CarPhoneNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#CarPhoneNumber">http://tracker.api.gnome.org/ontology/v3/nco#CarPhoneNumber</seealso>
    let CarPhoneNumber = Prefixed_Name(tnco, "CarPhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:CellPhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A cellular phone number. Inspired by the (TYPE=cell) parameter of the TEL property as defined in RFC 2426 sec  3.3.1. Usually a cellular phone can accept voice calls as well as textual messages (SMS), therefore this class has two superclasses.</para>
    /// labels<para>CellPhoneNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#CellPhoneNumber">http://tracker.api.gnome.org/ontology/v3/nco#CellPhoneNumber</seealso>
    let CellPhoneNumber = Prefixed_Name(tnco, "CellPhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:Contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Contact. A piece of data that can provide means to identify or communicate with an entity.</para>
    /// labels<para>Contact</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#Contact">http://tracker.api.gnome.org/ontology/v3/nco#Contact</seealso>
    let Contact = Prefixed_Name(tnco, "Contact") |> PrefixedName
    /// <summary>
    ///   <para>tnco:ContactList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A contact list, this class represents an addressbook or a contact list of an IM application. Contacts inside a contact list can belong to contact groups.</para>
    /// labels<para>ContactList</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#ContactList">http://tracker.api.gnome.org/ontology/v3/nco#ContactList</seealso>
    let ContactList = Prefixed_Name(tnco, "ContactList") |> PrefixedName
    /// <summary>
    ///   <para>tnco:ContactMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A superclass for all contact media - ways to contact an entity represented by a Contact instance. Some of the subclasses of this class (the various kinds of telephone numbers and postal addresses) have been inspired by the values of the TYPE parameter of ADR and TEL properties defined in RFC 2426 sec. 3.2.1. and 3.3.1 respectively. Each value is represented by an appropriate subclass with two major exceptions TYPE=home and TYPE=work. They are to be expressed by the roles these contact media are attached to i.e. contact media with TYPE=home parameter are to be attached to the default role (nco:Contact or nco:PersonContact), whereas media with TYPE=work parameter should be attached to nco:Affiliation or nco:OrganizationContact.</para>
    /// labels<para>ContactMedium</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#ContactMedium">http://tracker.api.gnome.org/ontology/v3/nco#ContactMedium</seealso>
    let ContactMedium = Prefixed_Name(tnco, "ContactMedium") |> PrefixedName
    /// <summary>
    ///   <para>tnco:PostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A postal address. A class aggregating the various parts of a value for the 'ADR' property as defined in RFC 2426 Sec. 3.2.1.</para>
    /// labels<para>PostalAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#PostalAddress">http://tracker.api.gnome.org/ontology/v3/nco#PostalAddress</seealso>
    let PostalAddress = Prefixed_Name(tnco, "PostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>tnco:EmailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An email address. The recommended best practice is to use mailto: uris for instances of this class.</para>
    /// labels<para>EmailAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#EmailAddress">http://tracker.api.gnome.org/ontology/v3/nco#EmailAddress</seealso>
    let EmailAddress = Prefixed_Name(tnco, "EmailAddress") |> PrefixedName
    /// <summary>
    ///   <para>tnco:PhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A telephone number.</para>
    /// labels<para>PhoneNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#PhoneNumber">http://tracker.api.gnome.org/ontology/v3/nco#PhoneNumber</seealso>
    let PhoneNumber = Prefixed_Name(tnco, "PhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Gender. Instances of this class may include male and female.</para>
    /// labels<para>Gender</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#Gender">http://tracker.api.gnome.org/ontology/v3/nco#Gender</seealso>
    let Gender = Prefixed_Name(tnco, "Gender") |> PrefixedName
    /// <summary>
    ///   <para>tnco:IMAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instant messaging address such as xmpp:foo@bar.com.</para>
    /// labels<para>IM Address</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#IMAddress">http://tracker.api.gnome.org/ontology/v3/nco#IMAddress</seealso>
    let IMAddress = Prefixed_Name(tnco, "IMAddress") |> PrefixedName
    /// <summary>
    ///   <para>tnco:IMCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Features of a certain IM connection (depends on the IMAccount implementation used by the Contact)</para>
    /// labels<para>IM Capabilities</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#IMCapability">http://tracker.api.gnome.org/ontology/v3/nco#IMCapability</seealso>
    let IMCapability = Prefixed_Name(tnco, "IMCapability") |> PrefixedName
    /// <summary>
    ///   <para>tnco:OrganizationContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Contact that denotes on Organization.</para>
    /// labels<para>OrganizationContact</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#OrganizationContact">http://tracker.api.gnome.org/ontology/v3/nco#OrganizationContact</seealso>
    let OrganizationContact = Prefixed_Name(tnco, "OrganizationContact") |> PrefixedName
    /// <summary>
    ///   <para>tnco:PagerNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A pager phone number. Inspired by the (TYPE=pager) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.</para>
    /// labels<para>PagerNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#PagerNumber">http://tracker.api.gnome.org/ontology/v3/nco#PagerNumber</seealso>
    let PagerNumber = Prefixed_Name(tnco, "PagerNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:PcsNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Personal Communication Services Number. A class inspired by the TYPE=pcs parameter of the TEL property defined in RFC 2426 sec. 3.3.1</para>
    /// labels<para>PcsNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#PcsNumber">http://tracker.api.gnome.org/ontology/v3/nco#PcsNumber</seealso>
    let PcsNumber = Prefixed_Name(tnco, "PcsNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:PresenceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Predefined set of status level instances</para>
    /// labels<para>Presence statuses</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#PresenceStatus">http://tracker.api.gnome.org/ontology/v3/nco#PresenceStatus</seealso>
    let PresenceStatus = Prefixed_Name(tnco, "PresenceStatus") |> PrefixedName
    /// <summary>
    ///   <para>tnco:addressLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The geographical location of a postal address.</para>
    /// labels<para>addressLocation</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#addressLocation">http://tracker.api.gnome.org/ontology/v3/nco#addressLocation</seealso>
    let addressLocation = Prefixed_Name(tnco, "addressLocation") |> PrefixedName
    /// <summary>
    ///   <para>tnco:birthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Birth date of the object represented by this Contact. An equivalent of the 'BDAY' property as defined in RFC 2426 Sec. 3.1.5.</para>
    /// labels<para>birthDate</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#birthDate">http://tracker.api.gnome.org/ontology/v3/nco#birthDate</seealso>
    let birthDate = Prefixed_Name(tnco, "birthDate") |> PrefixedName
    /// <summary>
    ///   <para>tnco:contactGroupName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the contact group. This property was NOT defined in the VCARD standard. See documentation of the 'ContactGroup' class for details</para>
    /// labels<para>contactGroupName</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#contactGroupName">http://tracker.api.gnome.org/ontology/v3/nco#contactGroupName</seealso>
    let contactGroupName = Prefixed_Name(tnco, "contactGroupName") |> PrefixedName
    /// <summary>
    ///   <para>tnco:contactLocalUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Unique ID for the contact in the local storage</para>
    /// labels<para>local contact UID</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#contactLocalUID">http://tracker.api.gnome.org/ontology/v3/nco#contactLocalUID</seealso>
    let contactLocalUID = Prefixed_Name(tnco, "contactLocalUID") |> PrefixedName
    /// <summary>
    ///   <para>tnco:containsContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property used to group contacts into contact groups. This property was NOT defined in the VCARD standard. See documentation for the 'ContactList' class for details</para>
    /// labels<para>containsContact</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#containsContact">http://tracker.api.gnome.org/ontology/v3/nco#containsContact</seealso>
    let containsContact = Prefixed_Name(tnco, "containsContact") |> PrefixedName
    /// <summary>
    ///   <para>tnco:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity responsible for making contributions to the content of the InformationElement.</para>
    /// labels<para>contributor</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#contributor">http://tracker.api.gnome.org/ontology/v3/nco#contributor</seealso>
    let contributor = Prefixed_Name(tnco, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>tnco:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Creator of a data object, an entity primarily responsible for the creation of the content of the data object.</para>
    /// labels<para>creator</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#creator">http://tracker.api.gnome.org/ontology/v3/nco#creator</seealso>
    let creator = Prefixed_Name(tnco, "creator") |> PrefixedName
    /// <summary>
    ///   <para>tnco:default-contact-me</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:PersonContact</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#default-contact-me">http://tracker.api.gnome.org/ontology/v3/nco#default-contact-me</seealso>
    let default_contact_me = Prefixed_Name(tnco, "default-contact-me") |> PrefixedName
    /// <summary>
    ///   <para>tnco:department</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Department. The organizational unit within the organization.</para>
    /// labels<para>department</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#department">http://tracker.api.gnome.org/ontology/v3/nco#department</seealso>
    let department = Prefixed_Name(tnco, "department") |> PrefixedName
    /// <summary>
    ///   <para>tnco:foafUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The URL of the FOAF file.</para>
    /// labels<para>foafUrl</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#foafUrl">http://tracker.api.gnome.org/ontology/v3/nco#foafUrl</seealso>
    let foafUrl = Prefixed_Name(tnco, "foafUrl") |> PrefixedName
    /// <summary>
    ///   <para>tnco:fullname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the formatted text corresponding to the name of the object the Contact represents. An equivalent of the FN property as defined in RFC 2426 Sec. 3.1.1.</para>
    /// labels<para>fullname</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#fullname">http://tracker.api.gnome.org/ontology/v3/nco#fullname</seealso>
    let fullname = Prefixed_Name(tnco, "fullname") |> PrefixedName
    /// <summary>
    ///   <para>tnco:hasContactMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A superProperty for all properties linking a Contact to an instance of a contact medium.</para>
    /// labels<para>hasContactMedium</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#hasContactMedium">http://tracker.api.gnome.org/ontology/v3/nco#hasContactMedium</seealso>
    let hasContactMedium = Prefixed_Name(tnco, "hasContactMedium") |> PrefixedName
    /// <summary>
    ///   <para>tnco:hasEmailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An address for electronic mail communication with the object specified by this contact. An equivalent of the 'EMAIL' property as defined in RFC 2426 Sec. 3.3.1.</para>
    /// labels<para>hasEmailAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#hasEmailAddress">http://tracker.api.gnome.org/ontology/v3/nco#hasEmailAddress</seealso>
    let hasEmailAddress = Prefixed_Name(tnco, "hasEmailAddress") |> PrefixedName
    /// <summary>
    ///   <para>tnco:hasIMAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An address for communication using instant messages with the object specified by this contact.</para>
    /// labels<para>imAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#hasIMAddress">http://tracker.api.gnome.org/ontology/v3/nco#hasIMAddress</seealso>
    let hasIMAddress = Prefixed_Name(tnco, "hasIMAddress") |> PrefixedName
    /// <summary>
    ///   <para>tnco:hasIMContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that this Instant Messaging account has the specified Instant Messaging address in the contact list.</para>
    /// labels<para>hasIMAccount</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#hasIMContact">http://tracker.api.gnome.org/ontology/v3/nco#hasIMContact</seealso>
    let hasIMContact = Prefixed_Name(tnco, "hasIMContact") |> PrefixedName
    /// <summary>
    ///   <para>tnco:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Geographical location of the contact. Inspired by the 'GEO' property specified in RFC 2426 Sec. 3.4.2</para>
    /// labels<para>hasLocation</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#hasLocation">http://tracker.api.gnome.org/ontology/v3/nco#hasLocation</seealso>
    let hasLocation = Prefixed_Name(tnco, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>tnco:hasPhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number for telephony communication with the object represented by this Contact. An equivalent of the 'TEL' property defined in RFC 2426 Sec. 3.3.1</para>
    /// labels<para>hasPhoneNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#hasPhoneNumber">http://tracker.api.gnome.org/ontology/v3/nco#hasPhoneNumber</seealso>
    let hasPhoneNumber = Prefixed_Name(tnco, "hasPhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:hasPostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The default Address for a Contact. An equivalent of the 'ADR' property as defined in RFC 2426 Sec. 3.2.1.</para>
    /// labels<para>hasPostalAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#hasPostalAddress">http://tracker.api.gnome.org/ontology/v3/nco#hasPostalAddress</seealso>
    let hasPostalAddress = Prefixed_Name(tnco, "hasPostalAddress") |> PrefixedName

    /// <summary>
    ///   <para>tnco:im-capability-text-chat</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-text-chat">http://tracker.api.gnome.org/ontology/v3/nco#im-capability-text-chat</seealso>
    let im_capability_text_chat =
        Prefixed_Name(tnco, "im-capability-text-chat") |> PrefixedName

    /// <summary>
    ///   <para>tnco:im-capability-upgrading-calls</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-upgrading-calls">http://tracker.api.gnome.org/ontology/v3/nco#im-capability-upgrading-calls</seealso>
    let im_capability_upgrading_calls =
        Prefixed_Name(tnco, "im-capability-upgrading-calls") |> PrefixedName

    /// <summary>
    ///   <para>tnco:im-capability-video-calls</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-video-calls">http://tracker.api.gnome.org/ontology/v3/nco#im-capability-video-calls</seealso>
    let im_capability_video_calls =
        Prefixed_Name(tnco, "im-capability-video-calls") |> PrefixedName

    /// <summary>
    ///   <para>tnco:imAccountAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tnrl:InverseFunctionalProperty</para>
    ///   <para>Instant Messaging address of this IM account. The user 'me' can send and receive messages from this IM address.</para>
    /// labels<para>imAccountAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imAccountAddress">http://tracker.api.gnome.org/ontology/v3/nco#imAccountAddress</seealso>
    let imAccountAddress = Prefixed_Name(tnco, "imAccountAddress") |> PrefixedName
    /// <summary>
    ///   <para>tnco:imAccountType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type of the IM account. This may be the name of the service that provides the IM functionality. Examples might include Jabber, ICQ, MSN etc</para>
    /// labels<para>imAccountType</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imAccountType">http://tracker.api.gnome.org/ontology/v3/nco#imAccountType</seealso>
    let imAccountType = Prefixed_Name(tnco, "imAccountType") |> PrefixedName

    /// <summary>
    ///   <para>tnco:imAddressAuthStatusFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Has the other end authorize to receive information about his changes</para>
    /// labels<para>IM Address authorization status in the remote end</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imAddressAuthStatusFrom">http://tracker.api.gnome.org/ontology/v3/nco#imAddressAuthStatusFrom</seealso>
    let imAddressAuthStatusFrom =
        Prefixed_Name(tnco, "imAddressAuthStatusFrom") |> PrefixedName

    /// <summary>
    ///   <para>tnco:imAddressAuthStatusTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Do i authorize this im Account to receive my information</para>
    /// labels<para>IM Address authorization status in the local end</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imAddressAuthStatusTo">http://tracker.api.gnome.org/ontology/v3/nco#imAddressAuthStatusTo</seealso>
    let imAddressAuthStatusTo =
        Prefixed_Name(tnco, "imAddressAuthStatusTo") |> PrefixedName

    /// <summary>
    ///   <para>tnco:imAvatar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A picture attached to a particular IM address.</para>
    /// labels<para>imAvatar</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imAvatar">http://tracker.api.gnome.org/ontology/v3/nco#imAvatar</seealso>
    let imAvatar = Prefixed_Name(tnco, "imAvatar") |> PrefixedName
    /// <summary>
    ///   <para>tnco:imNickname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A nickname attached to a particular IM address.</para>
    /// labels<para>imNickname</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imNickname">http://tracker.api.gnome.org/ontology/v3/nco#imNickname</seealso>
    let imNickname = Prefixed_Name(tnco, "imNickname") |> PrefixedName
    /// <summary>
    ///   <para>tnco:imPresence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>imPresence</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imPresence">http://tracker.api.gnome.org/ontology/v3/nco#imPresence</seealso>
    let imPresence = Prefixed_Name(tnco, "imPresence") |> PrefixedName
    /// <summary>
    ///   <para>tnco:imProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Protocol of the account ('skype', 'gtalk', 'icq', ...)</para>
    /// labels<para>imProtocol</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imProtocol">http://tracker.api.gnome.org/ontology/v3/nco#imProtocol</seealso>
    let imProtocol = Prefixed_Name(tnco, "imProtocol") |> PrefixedName
    /// <summary>
    ///   <para>tnco:imStatusMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A feature common in most IM systems. A message left by the user for all his/her contacts to see.</para>
    /// labels<para>imStatusMessage</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imStatusMessage">http://tracker.api.gnome.org/ontology/v3/nco#imStatusMessage</seealso>
    let imStatusMessage = Prefixed_Name(tnco, "imStatusMessage") |> PrefixedName
    /// <summary>
    ///   <para>tnco:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An encryption key attached to a contact. Inspired by the KEY property defined in RFC 2426 sec. 3.7.2</para>
    /// labels<para>key</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#key">http://tracker.api.gnome.org/ontology/v3/nco#key</seealso>
    let key = Prefixed_Name(tnco, "key") |> PrefixedName
    /// <summary>
    ///   <para>tnco:locality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Locality or City. Inspired by the fourth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1</para>
    /// labels<para>locality</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#locality">http://tracker.api.gnome.org/ontology/v3/nco#locality</seealso>
    let locality = Prefixed_Name(tnco, "locality") |> PrefixedName
    /// <summary>
    ///   <para>tnco:nameGiven</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The given name for the object represented by this Contact. See documentation for 'nameFamily' property for details.</para>
    /// labels<para>nameGiven</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#nameGiven">http://tracker.api.gnome.org/ontology/v3/nco#nameGiven</seealso>
    let nameGiven = Prefixed_Name(tnco, "nameGiven") |> PrefixedName
    /// <summary>
    ///   <para>tnco:nameHonorificPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A prefix for the name of the object represented by this Contact. See documentation for the 'nameFamily' property for details.</para>
    /// labels<para>nameHonorificPrefix</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#nameHonorificPrefix">http://tracker.api.gnome.org/ontology/v3/nco#nameHonorificPrefix</seealso>
    let nameHonorificPrefix = Prefixed_Name(tnco, "nameHonorificPrefix") |> PrefixedName
    /// <summary>
    ///   <para>tnco:nameHonorificSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A suffix for the name of the Object represented by the given object. See documentation for the 'nameFamily' for details.</para>
    /// labels<para>nameHonorificSuffix</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#nameHonorificSuffix">http://tracker.api.gnome.org/ontology/v3/nco#nameHonorificSuffix</seealso>
    let nameHonorificSuffix = Prefixed_Name(tnco, "nameHonorificSuffix") |> PrefixedName
    /// <summary>
    ///   <para>tnco:nickname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A nickname of the Object represented by this Contact. This is an equivalen of the 'NICKNAME' property as defined in RFC 2426 Sec. 3.1.3.</para>
    /// labels<para>nickname</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#nickname">http://tracker.api.gnome.org/ontology/v3/nco#nickname</seealso>
    let nickname = Prefixed_Name(tnco, "nickname") |> PrefixedName
    /// <summary>
    ///   <para>tnco:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A note about the object represented by this Contact. An equivalent for the 'NOTE' property defined in RFC 2426 Sec. 3.6.2</para>
    /// labels<para>note</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#note">http://tracker.api.gnome.org/ontology/v3/nco#note</seealso>
    let note = Prefixed_Name(tnco, "note") |> PrefixedName

    /// <summary>
    ///   <para>tnco:predefined-auth-status-yes</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:AuthorizationStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#predefined-auth-status-yes">http://tracker.api.gnome.org/ontology/v3/nco#predefined-auth-status-yes</seealso>
    let predefined_auth_status_yes =
        Prefixed_Name(tnco, "predefined-auth-status-yes") |> PrefixedName

    /// <summary>
    ///   <para>tnco:presence-status-available</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:PresenceStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-available">http://tracker.api.gnome.org/ontology/v3/nco#presence-status-available</seealso>
    let presence_status_available =
        Prefixed_Name(tnco, "presence-status-available") |> PrefixedName

    /// <summary>
    ///   <para>tnco:presence-status-away</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:PresenceStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-away">http://tracker.api.gnome.org/ontology/v3/nco#presence-status-away</seealso>
    let presence_status_away =
        Prefixed_Name(tnco, "presence-status-away") |> PrefixedName

    /// <summary>
    ///   <para>tnco:presence-status-busy</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:PresenceStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-busy">http://tracker.api.gnome.org/ontology/v3/nco#presence-status-busy</seealso>
    let presence_status_busy =
        Prefixed_Name(tnco, "presence-status-busy") |> PrefixedName

    /// <summary>
    ///   <para>tnco:presence-status-error</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:PresenceStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-error">http://tracker.api.gnome.org/ontology/v3/nco#presence-status-error</seealso>
    let presence_status_error =
        Prefixed_Name(tnco, "presence-status-error") |> PrefixedName

    /// <summary>
    ///   <para>tnco:presence-status-extended-away</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:PresenceStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-extended-away">http://tracker.api.gnome.org/ontology/v3/nco#presence-status-extended-away</seealso>
    let presence_status_extended_away =
        Prefixed_Name(tnco, "presence-status-extended-away") |> PrefixedName

    /// <summary>
    ///   <para>tnco:presence-status-hidden</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:PresenceStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-hidden">http://tracker.api.gnome.org/ontology/v3/nco#presence-status-hidden</seealso>
    let presence_status_hidden =
        Prefixed_Name(tnco, "presence-status-hidden") |> PrefixedName

    /// <summary>
    ///   <para>tnco:presence-status-offline</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:PresenceStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-offline">http://tracker.api.gnome.org/ontology/v3/nco#presence-status-offline</seealso>
    let presence_status_offline =
        Prefixed_Name(tnco, "presence-status-offline") |> PrefixedName

    /// <summary>
    ///   <para>tnco:presence-status-unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:PresenceStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-unknown">http://tracker.api.gnome.org/ontology/v3/nco#presence-status-unknown</seealso>
    let presence_status_unknown =
        Prefixed_Name(tnco, "presence-status-unknown") |> PrefixedName

    /// <summary>
    ///   <para>tnco:presence-status-unset</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:PresenceStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#presence-status-unset">http://tracker.api.gnome.org/ontology/v3/nco#presence-status-unset</seealso>
    let presence_status_unset =
        Prefixed_Name(tnco, "presence-status-unset") |> PrefixedName

    /// <summary>
    ///   <para>tnco:presenceLastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Timestamp of the last change in the presence status</para>
    /// labels<para>Presence last modified</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#presenceLastModified">http://tracker.api.gnome.org/ontology/v3/nco#presenceLastModified</seealso>
    let presenceLastModified =
        Prefixed_Name(tnco, "presenceLastModified") |> PrefixedName

    /// <summary>
    ///   <para>tnco:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity responsible for making the InformationElement available.</para>
    /// labels<para>publisher</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#publisher">http://tracker.api.gnome.org/ontology/v3/nco#publisher</seealso>
    let publisher = Prefixed_Name(tnco, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>tnco:video</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Video avatar of a contact. Note that is an icon/avatar, not a generic 'present in video' property</para>
    /// labels<para>Contact video</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#video">http://tracker.api.gnome.org/ontology/v3/nco#video</seealso>
    let video = Prefixed_Name(tnco, "video") |> PrefixedName
    /// <summary>
    ///   <para>tnco:voiceMail</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates if the given number accepts voice mail. (e.g. there is an answering machine). Inspired by TYPE=msg parameter of the TEL property defined in RFC 2426 sec. 3.3.1</para>
    /// labels<para>voiceMail</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#voiceMail">http://tracker.api.gnome.org/ontology/v3/nco#voiceMail</seealso>
    let voiceMail = Prefixed_Name(tnco, "voiceMail") |> PrefixedName
    /// <summary>
    ///   <para>tnco:websiteUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A url of a website.</para>
    /// labels<para>websiteUrl</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#websiteUrl">http://tracker.api.gnome.org/ontology/v3/nco#websiteUrl</seealso>
    let websiteUrl = Prefixed_Name(tnco, "websiteUrl") |> PrefixedName
    /// <summary>
    ///   <para>tnco:</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:Namespace</para>
    ///   <para>tnrl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#">http://tracker.api.gnome.org/ontology/v3/nco#</seealso>
    let _prefix_iri = Prefixed_Name(tnco, "") |> PrefixedName
    /// <summary>
    ///   <para>tnco:AuthorizationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Predefined instances to indicate the auth status: yes, no, requested</para>
    /// labels<para>IM Address approval status</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#AuthorizationStatus">http://tracker.api.gnome.org/ontology/v3/nco#AuthorizationStatus</seealso>
    let AuthorizationStatus = Prefixed_Name(tnco, "AuthorizationStatus") |> PrefixedName
    /// <summary>
    ///   <para>tnco:ModemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A modem phone number. Inspired by the (TYPE=modem) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.</para>
    /// labels<para>ModemNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#ModemNumber">http://tracker.api.gnome.org/ontology/v3/nco#ModemNumber</seealso>
    let ModemNumber = Prefixed_Name(tnco, "ModemNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:VoicePhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A telephone number with voice communication capabilities. Class inspired by the TYPE=voice parameter of the TEL property defined in RFC 2426 sec. 3.3.1</para>
    /// labels<para>VoicePhoneNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#VoicePhoneNumber">http://tracker.api.gnome.org/ontology/v3/nco#VoicePhoneNumber</seealso>
    let VoicePhoneNumber = Prefixed_Name(tnco, "VoicePhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:MessagingNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A number that can accept textual messages.</para>
    /// labels<para>MessagingNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#MessagingNumber">http://tracker.api.gnome.org/ontology/v3/nco#MessagingNumber</seealso>
    let MessagingNumber = Prefixed_Name(tnco, "MessagingNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:ContactGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A group of Contacts. Could be used to express a group in an addressbook or on a contact list of an IM application. One contact can belong to many groups.</para>
    /// labels<para>ContactGroup</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#ContactGroup">http://tracker.api.gnome.org/ontology/v3/nco#ContactGroup</seealso>
    let ContactGroup = Prefixed_Name(tnco, "ContactGroup") |> PrefixedName

    /// <summary>
    ///   <para>tnco:ContactListDataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An entity occuring on a contact list (usually interpreted as an nco:Contact)</para>
    /// labels<para>ContactListDataObject</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#ContactListDataObject">http://tracker.api.gnome.org/ontology/v3/nco#ContactListDataObject</seealso>
    let ContactListDataObject =
        Prefixed_Name(tnco, "ContactListDataObject") |> PrefixedName

    /// <summary>
    ///   <para>tnco:DomesticDeliveryAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Domestic Delivery Addresse. Class inspired by TYPE=dom parameter of the ADR property defined in RFC 2426 sec. 3.2.1</para>
    /// labels<para>DomesticDeliveryAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#DomesticDeliveryAddress">http://tracker.api.gnome.org/ontology/v3/nco#DomesticDeliveryAddress</seealso>
    let DomesticDeliveryAddress =
        Prefixed_Name(tnco, "DomesticDeliveryAddress") |> PrefixedName

    /// <summary>
    ///   <para>tnco:FaxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A fax number. Inspired by the (TYPE=fax) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.</para>
    /// labels<para>FaxNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#FaxNumber">http://tracker.api.gnome.org/ontology/v3/nco#FaxNumber</seealso>
    let FaxNumber = Prefixed_Name(tnco, "FaxNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:IMAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An account in an Instant Messaging system. This refers to IM accounts of the user 'me'.</para>
    /// labels<para>IMAccount</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#IMAccount">http://tracker.api.gnome.org/ontology/v3/nco#IMAccount</seealso>
    let IMAccount = Prefixed_Name(tnco, "IMAccount") |> PrefixedName

    /// <summary>
    ///   <para>tnco:InternationalDeliveryAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>International Delivery Addresse. Class inspired by TYPE=intl parameter of the ADR property defined in RFC 2426 sec. 3.2.1</para>
    /// labels<para>InternationalDeliveryAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#InternationalDeliveryAddress">http://tracker.api.gnome.org/ontology/v3/nco#InternationalDeliveryAddress</seealso>
    let InternationalDeliveryAddress =
        Prefixed_Name(tnco, "InternationalDeliveryAddress") |> PrefixedName

    /// <summary>
    ///   <para>tnco:IsdnNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ISDN phone number. Inspired by the (TYPE=isdn) parameter of the TEL property as defined in RFC 2426 sec  3.3.1.</para>
    /// labels<para>IsdnNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#IsdnNumber">http://tracker.api.gnome.org/ontology/v3/nco#IsdnNumber</seealso>
    let IsdnNumber = Prefixed_Name(tnco, "IsdnNumber") |> PrefixedName

    /// <summary>
    ///   <para>tnco:ParcelDeliveryAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Parcel Delivery Addresse. Class inspired by TYPE=parcel parameter of the ADR property defined in RFC 2426 sec. 3.2.1</para>
    /// labels<para>ParcelDeliveryAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#ParcelDeliveryAddress">http://tracker.api.gnome.org/ontology/v3/nco#ParcelDeliveryAddress</seealso>
    let ParcelDeliveryAddress =
        Prefixed_Name(tnco, "ParcelDeliveryAddress") |> PrefixedName

    /// <summary>
    ///   <para>tnco:PersonContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Contact that denotes a Person. A person can have multiple Affiliations.</para>
    /// labels<para>PersonContact</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#PersonContact">http://tracker.api.gnome.org/ontology/v3/nco#PersonContact</seealso>
    let PersonContact = Prefixed_Name(tnco, "PersonContact") |> PrefixedName

    /// <summary>
    ///   <para>tnco:VideoTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Video telephone number. A class inspired by the TYPE=video parameter of the TEL property defined in RFC 2426 sec. 3.3.1</para>
    /// labels<para>VideoTelephoneNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#VideoTelephoneNumber">http://tracker.api.gnome.org/ontology/v3/nco#VideoTelephoneNumber</seealso>
    let VideoTelephoneNumber =
        Prefixed_Name(tnco, "VideoTelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>tnco:belongsToGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a Contact with a ContactGroup it belongs to.</para>
    /// labels<para>addressLocation</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#belongsToGroup">http://tracker.api.gnome.org/ontology/v3/nco#belongsToGroup</seealso>
    let belongsToGroup = Prefixed_Name(tnco, "belongsToGroup") |> PrefixedName
    /// <summary>
    ///   <para>tnco:blogUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Blog url.</para>
    /// labels<para>blogUrl</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#blogUrl">http://tracker.api.gnome.org/ontology/v3/nco#blogUrl</seealso>
    let blogUrl = Prefixed_Name(tnco, "blogUrl") |> PrefixedName
    /// <summary>
    ///   <para>tnco:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A uniform resource locator associated with the given role of a Contact. Inspired by the 'URL' property defined in RFC 2426 Sec. 3.6.8.</para>
    /// labels<para>url</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#url">http://tracker.api.gnome.org/ontology/v3/nco#url</seealso>
    let url = Prefixed_Name(tnco, "url") |> PrefixedName

    /// <summary>
    ///   <para>tnco:contactMediumComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A comment about the contact medium.</para>
    /// labels<para>contactMediumComment</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#contactMediumComment">http://tracker.api.gnome.org/ontology/v3/nco#contactMediumComment</seealso>
    let contactMediumComment =
        Prefixed_Name(tnco, "contactMediumComment") |> PrefixedName

    /// <summary>
    ///   <para>tnco:contactUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A value that represents a globally unique  identifier corresponding to the individual or resource associated with the Contact. An equivalent of the 'UID' property defined in RFC 2426 Sec. 3.6.7</para>
    /// labels<para>contactUID</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#contactUID">http://tracker.api.gnome.org/ontology/v3/nco#contactUID</seealso>
    let contactUID = Prefixed_Name(tnco, "contactUID") |> PrefixedName
    /// <summary>
    ///   <para>tnco:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A part of an address specifying the country. Inspired by the seventh part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1</para>
    /// labels<para>country</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#country">http://tracker.api.gnome.org/ontology/v3/nco#country</seealso>
    let country = Prefixed_Name(tnco, "country") |> PrefixedName
    /// <summary>
    ///   <para>tnco:county</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Regional division between state and city. Not in RFC 2426 sec 3.2.1. Added for API compatibility</para>
    /// labels<para>County</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#county">http://tracker.api.gnome.org/ontology/v3/nco#county</seealso>
    let county = Prefixed_Name(tnco, "county") |> PrefixedName
    /// <summary>
    ///   <para>tnco:district</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Local division inside a city. Not in RFC 2426 sec 3.2.1. Added for API compatibility</para>
    /// labels<para>District</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#district">http://tracker.api.gnome.org/ontology/v3/nco#district</seealso>
    let district = Prefixed_Name(tnco, "district") |> PrefixedName
    /// <summary>
    ///   <para>tnco:emailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Email address</para>
    /// labels<para>emailAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#emailAddress">http://tracker.api.gnome.org/ontology/v3/nco#emailAddress</seealso>
    let emailAddress = Prefixed_Name(tnco, "emailAddress") |> PrefixedName
    /// <summary>
    ///   <para>tnco:extendedAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An extended part of an address. This field might be used to express parts of an address that aren't include in the name of the Contact but also aren't part of the actual location. Usually the streed address and following fields are enough for a postal letter to arrive. Examples may include ('University of California Campus building 45', 'Sears Tower 34th floor' etc.) Inspired by the second part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1</para>
    /// labels<para>extendedAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#extendedAddress">http://tracker.api.gnome.org/ontology/v3/nco#extendedAddress</seealso>
    let extendedAddress = Prefixed_Name(tnco, "extendedAddress") |> PrefixedName
    /// <summary>
    ///   <para>tnco:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Gender of the given contact.</para>
    /// labels<para>gender</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#gender">http://tracker.api.gnome.org/ontology/v3/nco#gender</seealso>
    let gender = Prefixed_Name(tnco, "gender") |> PrefixedName
    /// <summary>
    ///   <para>tnco:gender-female</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:Gender</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#gender-female">http://tracker.api.gnome.org/ontology/v3/nco#gender-female</seealso>
    let gender_female = Prefixed_Name(tnco, "gender-female") |> PrefixedName
    /// <summary>
    ///   <para>tnco:gender-male</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:Gender</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#gender-male">http://tracker.api.gnome.org/ontology/v3/nco#gender-male</seealso>
    let gender_male = Prefixed_Name(tnco, "gender-male") |> PrefixedName
    /// <summary>
    ///   <para>tnco:gender-other</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:Gender</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#gender-other">http://tracker.api.gnome.org/ontology/v3/nco#gender-other</seealso>
    let gender_other = Prefixed_Name(tnco, "gender-other") |> PrefixedName
    /// <summary>
    ///   <para>tnco:hasAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a PersonContact with an Affiliation.</para>
    /// labels<para>hasAffiliation</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#hasAffiliation">http://tracker.api.gnome.org/ontology/v3/nco#hasAffiliation</seealso>
    let hasAffiliation = Prefixed_Name(tnco, "hasAffiliation") |> PrefixedName
    /// <summary>
    ///   <para>tnco:hobby</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A hobby associated with a PersonContact. This property can be used to express hobbies and interests.</para>
    /// labels<para>hobby</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#hobby">http://tracker.api.gnome.org/ontology/v3/nco#hobby</seealso>
    let hobby = Prefixed_Name(tnco, "hobby") |> PrefixedName

    /// <summary>
    ///   <para>tnco:im-capability-audio-calls</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-audio-calls">http://tracker.api.gnome.org/ontology/v3/nco#im-capability-audio-calls</seealso>
    let im_capability_audio_calls =
        Prefixed_Name(tnco, "im-capability-audio-calls") |> PrefixedName

    /// <summary>
    ///   <para>tnco:im-capability-dbus-tubes</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-dbus-tubes">http://tracker.api.gnome.org/ontology/v3/nco#im-capability-dbus-tubes</seealso>
    let im_capability_dbus_tubes =
        Prefixed_Name(tnco, "im-capability-dbus-tubes") |> PrefixedName

    /// <summary>
    ///   <para>tnco:im-capability-file-transfers</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-file-transfers">http://tracker.api.gnome.org/ontology/v3/nco#im-capability-file-transfers</seealso>
    let im_capability_file_transfers =
        Prefixed_Name(tnco, "im-capability-file-transfers") |> PrefixedName

    /// <summary>
    ///   <para>tnco:im-capability-media-calls</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-media-calls">http://tracker.api.gnome.org/ontology/v3/nco#im-capability-media-calls</seealso>
    let im_capability_media_calls =
        Prefixed_Name(tnco, "im-capability-media-calls") |> PrefixedName

    /// <summary>
    ///   <para>tnco:im-capability-stream-tubes</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:IMCapability</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#im-capability-stream-tubes">http://tracker.api.gnome.org/ontology/v3/nco#im-capability-stream-tubes</seealso>
    let im_capability_stream_tubes =
        Prefixed_Name(tnco, "im-capability-stream-tubes") |> PrefixedName

    /// <summary>
    ///   <para>tnco:imCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Capabilities of an IM Contact, what can we interact with him</para>
    /// labels<para>imContact Capability</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imCapability">http://tracker.api.gnome.org/ontology/v3/nco#imCapability</seealso>
    let imCapability = Prefixed_Name(tnco, "imCapability") |> PrefixedName
    /// <summary>
    ///   <para>tnco:imDisplayName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The user-visible name of this account. This SHOULD be chosen by the user at account creation time. The account creation user interface is responsible for setting a reasonable default value in the user's locale; something like	'Jabber (bob@example.com)' would be sensible.</para>
    /// labels<para>displayname</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imDisplayName">http://tracker.api.gnome.org/ontology/v3/nco#imDisplayName</seealso>
    let imDisplayName = Prefixed_Name(tnco, "imDisplayName") |> PrefixedName
    /// <summary>
    ///   <para>tnco:imEnabled</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para></para>
    /// labels<para>enabled</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imEnabled">http://tracker.api.gnome.org/ontology/v3/nco#imEnabled</seealso>
    let imEnabled = Prefixed_Name(tnco, "imEnabled") |> PrefixedName
    /// <summary>
    ///   <para>tnco:imID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifier of the IM account. Examples of such identifier might include ICQ UINs, Jabber IDs, Skype names etc.</para>
    /// labels<para>imID</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#imID">http://tracker.api.gnome.org/ontology/v3/nco#imID</seealso>
    let imID = Prefixed_Name(tnco, "imID") |> PrefixedName
    /// <summary>
    ///   <para>tnco:logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Logo of a company. Inspired by the LOGO property defined in RFC 2426 sec. 3.5.3</para>
    /// labels<para>logo</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#logo">http://tracker.api.gnome.org/ontology/v3/nco#logo</seealso>
    let logo = Prefixed_Name(tnco, "logo") |> PrefixedName
    /// <summary>
    ///   <para>tnco:nameAdditional</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Additional given name of an object represented by this contact. See documentation for 'nameFamily' property for details.</para>
    /// labels<para>nameAdditional</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#nameAdditional">http://tracker.api.gnome.org/ontology/v3/nco#nameAdditional</seealso>
    let nameAdditional = Prefixed_Name(tnco, "nameAdditional") |> PrefixedName
    /// <summary>
    ///   <para>tnco:nameFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The family name of an Object represented by this Contact. These applies to people that have more than one given name. The 'first' one is considered 'the' given name (see nameGiven) property. All additional ones are considered 'additional' names. The name inherited from parents is the 'family name'. e.g. For Dr. John Phil Paul Stevenson Jr. M.D. A.C.P. we have contact with: honorificPrefix: 'Dr.', nameGiven: 'John', nameAdditional: 'Phil', nameAdditional: 'Paul', nameFamily: 'Stevenson', honorificSuffix: 'Jr.', honorificSuffix: 'M.D.', honorificSuffix: 'A.C.P.'. These properties form an equivalent of the compound 'N' property as defined in RFC 2426 Sec. 3.1.2</para>
    /// labels<para>nameFamily</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#nameFamily">http://tracker.api.gnome.org/ontology/v3/nco#nameFamily</seealso>
    let nameFamily = Prefixed_Name(tnco, "nameFamily") |> PrefixedName
    /// <summary>
    ///   <para>tnco:org</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Name of an organization or a unit within an organization the object represented by a Contact is associated with. An equivalent of the 'ORG' property defined in RFC 2426 Sec. 3.5.5</para>
    /// labels<para>org</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#org">http://tracker.api.gnome.org/ontology/v3/nco#org</seealso>
    let org = Prefixed_Name(tnco, "org") |> PrefixedName
    /// <summary>
    ///   <para>tnco:phoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>phoneNumber</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#phoneNumber">http://tracker.api.gnome.org/ontology/v3/nco#phoneNumber</seealso>
    let phoneNumber = Prefixed_Name(tnco, "phoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>tnco:photo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Photograph attached to a Contact. The DataObject refered to by this property is usually interpreted as an nfo:Image. Inspired by the PHOTO property defined in RFC 2426 sec. 3.1.4</para>
    /// labels<para>photo</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#photo">http://tracker.api.gnome.org/ontology/v3/nco#photo</seealso>
    let photo = Prefixed_Name(tnco, "photo") |> PrefixedName
    /// <summary>
    ///   <para>tnco:pobox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Post office box. This is the first part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1</para>
    /// labels<para>pobox</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#pobox">http://tracker.api.gnome.org/ontology/v3/nco#pobox</seealso>
    let pobox = Prefixed_Name(tnco, "pobox") |> PrefixedName
    /// <summary>
    ///   <para>tnco:postalcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Postal Code. Inspired by the sixth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1</para>
    /// labels<para>postalcode</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#postalcode">http://tracker.api.gnome.org/ontology/v3/nco#postalcode</seealso>
    let postalcode = Prefixed_Name(tnco, "postalcode") |> PrefixedName

    /// <summary>
    ///   <para>tnco:predefined-auth-status-no</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:AuthorizationStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#predefined-auth-status-no">http://tracker.api.gnome.org/ontology/v3/nco#predefined-auth-status-no</seealso>
    let predefined_auth_status_no =
        Prefixed_Name(tnco, "predefined-auth-status-no") |> PrefixedName

    /// <summary>
    ///   <para>tnco:predefined-auth-status-requested</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnco:AuthorizationStatus</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#predefined-auth-status-requested">http://tracker.api.gnome.org/ontology/v3/nco#predefined-auth-status-requested</seealso>
    let predefined_auth_status_requested =
        Prefixed_Name(tnco, "predefined-auth-status-requested") |> PrefixedName

    /// <summary>
    ///   <para>tnco:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Region. Inspired by the fifth part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1</para>
    /// labels<para>region</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#region">http://tracker.api.gnome.org/ontology/v3/nco#region</seealso>
    let region = Prefixed_Name(tnco, "region") |> PrefixedName
    /// <summary>
    ///   <para>tnco:representative</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An object that represent an object represented by this Contact. Usually this property is used to link a Contact to an organization, to a contact to the representative of this organization the user directly interacts with. An equivalent for the 'AGENT' property defined in RFC 2426 Sec. 3.5.4</para>
    /// labels<para>representative</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#representative">http://tracker.api.gnome.org/ontology/v3/nco#representative</seealso>
    let representative = Prefixed_Name(tnco, "representative") |> PrefixedName
    /// <summary>
    ///   <para>tnco:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>role</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#role">http://tracker.api.gnome.org/ontology/v3/nco#role</seealso>
    let role = Prefixed_Name(tnco, "role") |> PrefixedName
    /// <summary>
    ///   <para>tnco:sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Sound clip attached to a Contact. The DataObject refered to by this property is usually interpreted as an nfo:Audio. Inspired by the SOUND property defined in RFC 2425 sec. 3.6.6.</para>
    /// labels<para>sound</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#sound">http://tracker.api.gnome.org/ontology/v3/nco#sound</seealso>
    let sound = Prefixed_Name(tnco, "sound") |> PrefixedName
    /// <summary>
    ///   <para>tnco:streetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The streed address. Inspired by the third part of the value of the 'ADR' property as defined in RFC 2426, sec. 3.2.1</para>
    /// labels<para>streetAddress</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#streetAddress">http://tracker.api.gnome.org/ontology/v3/nco#streetAddress</seealso>
    let streetAddress = Prefixed_Name(tnco, "streetAddress") |> PrefixedName
    /// <summary>
    ///   <para>tnco:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>title</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nco#title">http://tracker.api.gnome.org/ontology/v3/nco#title</seealso>
    let title = Prefixed_Name(tnco, "title") |> PrefixedName
