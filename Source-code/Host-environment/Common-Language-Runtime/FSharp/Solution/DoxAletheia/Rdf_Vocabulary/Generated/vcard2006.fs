namespace http.www.w3.org._2006.vcard.ns.hash

open DoxAletheia.Rdf_Vocabulary

module vcard2006 =
    let _namespace_name = "http://www.w3.org/2006/vcard/ns#"

    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Acquaintance"></see>
    /// </summary>
    let Acquaintance =
        Namespaced_IRI.parse _namespace_name "Acquaintance" |> NamespacedName

    /// <summary>
    /// Used for relation type codes. The URI of the relation type code must be used as the value for the Relation Type.
    /// <see href="http://www.w3.org/2006/vcard/ns#RelatedType"></see></summary>
    let RelatedType =
        Namespaced_IRI.parse _namespace_name "RelatedType" |> NamespacedName

    /// <summary>
    /// To specify the components of the delivery address for the  object
    /// <see href="http://www.w3.org/2006/vcard/ns#Address"></see></summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName

    /// <summary>
    /// The country name associated with the address of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#country-name"></see></summary>
    let ``country-name`` =
        Namespaced_IRI.parse _namespace_name "country-name" |> NamespacedName

    /// <summary>
    /// The locality (e.g. city or town) associated with the address of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#locality"></see></summary>
    let locality = Namespaced_IRI.parse _namespace_name "locality" |> NamespacedName

    /// <summary>
    /// The postal code associated with the address of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#postal-code"></see></summary>
    let ``postal-code`` =
        Namespaced_IRI.parse _namespace_name "postal-code" |> NamespacedName

    /// <summary>
    /// The region (e.g. state or province) associated with the address of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName

    /// <summary>
    /// The street address associated with the address of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#street-address"></see></summary>
    let ``street-address`` =
        Namespaced_IRI.parse _namespace_name "street-address" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Agent"></see>
    /// </summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#BBS"></see></summary>
    let BBS = Namespaced_IRI.parse _namespace_name "BBS" |> NamespacedName

    /// <summary>
    /// Used for telephone type codes. The URI of the telephone type code must be used as the value for the Telephone Type.
    /// <see href="http://www.w3.org/2006/vcard/ns#TelephoneType"></see></summary>
    let TelephoneType =
        Namespaced_IRI.parse _namespace_name "TelephoneType" |> NamespacedName

    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Car"></see></summary>
    let Car = Namespaced_IRI.parse _namespace_name "Car" |> NamespacedName
    /// <summary>
    /// Also called mobile telephone
    /// <see href="http://www.w3.org/2006/vcard/ns#Cell"></see></summary>
    let Cell = Namespaced_IRI.parse _namespace_name "Cell" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Child"></see>
    /// </summary>
    let Child = Namespaced_IRI.parse _namespace_name "Child" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Colleague"></see>
    /// </summary>
    let Colleague = Namespaced_IRI.parse _namespace_name "Colleague" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Contact"></see>
    /// </summary>
    let Contact = Namespaced_IRI.parse _namespace_name "Contact" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Coresident"></see>
    /// </summary>
    let Coresident = Namespaced_IRI.parse _namespace_name "Coresident" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Coworker"></see>
    /// </summary>
    let Coworker = Namespaced_IRI.parse _namespace_name "Coworker" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Crush"></see>
    /// </summary>
    let Crush = Namespaced_IRI.parse _namespace_name "Crush" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Date"></see>
    /// </summary>
    let Date = Namespaced_IRI.parse _namespace_name "Date" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Dom"></see></summary>
    let Dom = Namespaced_IRI.parse _namespace_name "Dom" |> NamespacedName
    /// <summary>
    /// Used for type codes. The URI of the type code must be used as the value for Type.
    /// <see href="http://www.w3.org/2006/vcard/ns#Type"></see></summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName
    /// <summary>
    /// To specify the electronic mail address for communication with the object the vCard represents. Use the hasEmail object property.
    /// <see href="http://www.w3.org/2006/vcard/ns#Email"></see></summary>
    let Email = Namespaced_IRI.parse _namespace_name "Email" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Emergency"></see>
    /// </summary>
    let Emergency = Namespaced_IRI.parse _namespace_name "Emergency" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Fax"></see>
    /// </summary>
    let Fax = Namespaced_IRI.parse _namespace_name "Fax" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Female"></see>
    /// </summary>
    let Female = Namespaced_IRI.parse _namespace_name "Female" |> NamespacedName
    /// <summary>
    /// Used for gender codes. The URI of the gender code must be used as the value for Gender.
    /// <see href="http://www.w3.org/2006/vcard/ns#Gender"></see></summary>
    let Gender = Namespaced_IRI.parse _namespace_name "Gender" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Friend"></see>
    /// </summary>
    let Friend = Namespaced_IRI.parse _namespace_name "Friend" |> NamespacedName
    /// <summary>
    /// Object representing a group of persons or entities.  A group object will usually contain hasMember properties to specify the members of the group.
    /// <see href="http://www.w3.org/2006/vcard/ns#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// The parent class for all objects
    /// <see href="http://www.w3.org/2006/vcard/ns#Kind"></see></summary>
    let Kind = Namespaced_IRI.parse _namespace_name "Kind" |> NamespacedName

    /// <summary>
    /// An object representing an organization.  An organization is a single entity, and might represent a business or government, a department or division within a business or government, a club, an association, or the like.
    ///
    /// <see href="http://www.w3.org/2006/vcard/ns#Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// An object representing a named geographical place
    /// <see href="http://www.w3.org/2006/vcard/ns#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// An object representing a single person or entity
    /// <see href="http://www.w3.org/2006/vcard/ns#Individual"></see></summary>
    let Individual = Namespaced_IRI.parse _namespace_name "Individual" |> NamespacedName
    /// <summary>
    /// To include a member in the group this object represents. (This property can only be used by Group individuals)
    /// <see href="http://www.w3.org/2006/vcard/ns#hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// This implies that the property is related to an individual's personal life
    /// <see href="http://www.w3.org/2006/vcard/ns#Home"></see></summary>
    let Home = Namespaced_IRI.parse _namespace_name "Home" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#ISDN"></see></summary>
    let ISDN = Namespaced_IRI.parse _namespace_name "ISDN" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Internet"></see></summary>
    let Internet = Namespaced_IRI.parse _namespace_name "Internet" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Intl"></see></summary>
    let Intl = Namespaced_IRI.parse _namespace_name "Intl" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Kin"></see>
    /// </summary>
    let Kin = Namespaced_IRI.parse _namespace_name "Kin" |> NamespacedName
    /// <summary>
    /// The vCard class is  equivalent to the new Kind class, which is the parent for the four explicit types of vCards (Individual, Organization, Location, Group)
    /// <see href="http://www.w3.org/2006/vcard/ns#VCard"></see></summary>
    let VCard = Namespaced_IRI.parse _namespace_name "VCard" |> NamespacedName
    /// <summary>
    /// The formatted text corresponding to the name of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#fn"></see></summary>
    let fn = Namespaced_IRI.parse _namespace_name "fn" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Label"></see></summary>
    let Label = Namespaced_IRI.parse _namespace_name "Label" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Male"></see>
    /// </summary>
    let Male = Namespaced_IRI.parse _namespace_name "Male" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Me"></see>
    /// </summary>
    let Me = Namespaced_IRI.parse _namespace_name "Me" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Met"></see>
    /// </summary>
    let Met = Namespaced_IRI.parse _namespace_name "Met" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Modem"></see></summary>
    let Modem = Namespaced_IRI.parse _namespace_name "Modem" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Msg"></see></summary>
    let Msg = Namespaced_IRI.parse _namespace_name "Msg" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Muse"></see>
    /// </summary>
    let Muse = Namespaced_IRI.parse _namespace_name "Muse" |> NamespacedName
    /// <summary>
    /// To specify the components of the name of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName

    /// <summary>
    /// The additional name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#additional-name"></see></summary>
    let ``additional-name`` =
        Namespaced_IRI.parse _namespace_name "additional-name" |> NamespacedName

    /// <summary>
    /// The family name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#family-name"></see></summary>
    let ``family-name`` =
        Namespaced_IRI.parse _namespace_name "family-name" |> NamespacedName

    /// <summary>
    /// The given name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#given-name"></see></summary>
    let ``given-name`` =
        Namespaced_IRI.parse _namespace_name "given-name" |> NamespacedName

    /// <summary>
    /// The honorific prefix of the name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#honorific-prefix"></see></summary>
    let ``honorific-prefix`` =
        Namespaced_IRI.parse _namespace_name "honorific-prefix" |> NamespacedName

    /// <summary>
    /// The honorific suffix of the name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#honorific-suffix"></see></summary>
    let ``honorific-suffix`` =
        Namespaced_IRI.parse _namespace_name "honorific-suffix" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Neighbor"></see>
    /// </summary>
    let Neighbor = Namespaced_IRI.parse _namespace_name "Neighbor" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#None"></see>
    /// </summary>
    let None = Namespaced_IRI.parse _namespace_name "None" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Other"></see>
    /// </summary>
    let Other = Namespaced_IRI.parse _namespace_name "Other" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#PCS"></see></summary>
    let PCS = Namespaced_IRI.parse _namespace_name "PCS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Pager"></see>
    /// </summary>
    let Pager = Namespaced_IRI.parse _namespace_name "Pager" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Parcel"></see></summary>
    let Parcel = Namespaced_IRI.parse _namespace_name "Parcel" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Parent"></see>
    /// </summary>
    let Parent = Namespaced_IRI.parse _namespace_name "Parent" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Postal"></see></summary>
    let Postal = Namespaced_IRI.parse _namespace_name "Postal" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Pref"></see></summary>
    let Pref = Namespaced_IRI.parse _namespace_name "Pref" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Sibling"></see>
    /// </summary>
    let Sibling = Namespaced_IRI.parse _namespace_name "Sibling" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Spouse"></see>
    /// </summary>
    let Spouse = Namespaced_IRI.parse _namespace_name "Spouse" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Sweetheart"></see>
    /// </summary>
    let Sweetheart = Namespaced_IRI.parse _namespace_name "Sweetheart" |> NamespacedName
    /// <summary>
    /// This class is deprecated. Use the hasTelephone object property.
    /// <see href="http://www.w3.org/2006/vcard/ns#Tel"></see></summary>
    let Tel = Namespaced_IRI.parse _namespace_name "Tel" |> NamespacedName
    /// <summary>
    /// Also called sms telephone
    /// <see href="http://www.w3.org/2006/vcard/ns#Text"></see></summary>
    let Text = Namespaced_IRI.parse _namespace_name "Text" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#TextPhone"></see>
    /// </summary>
    let TextPhone = Namespaced_IRI.parse _namespace_name "TextPhone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Unknown"></see>
    /// </summary>
    let Unknown = Namespaced_IRI.parse _namespace_name "Unknown" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Video"></see>
    /// </summary>
    let Video = Namespaced_IRI.parse _namespace_name "Video" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Voice"></see>
    /// </summary>
    let Voice = Namespaced_IRI.parse _namespace_name "Voice" |> NamespacedName
    /// <summary>
    /// This implies that the property is related to an individual's work place
    /// <see href="http://www.w3.org/2006/vcard/ns#Work"></see></summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#X400"></see></summary>
    let X400 = Namespaced_IRI.parse _namespace_name "X400" |> NamespacedName
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#adr"></see></summary>
    let adr = Namespaced_IRI.parse _namespace_name "adr" |> NamespacedName
    /// <summary>
    /// To specify the components of the delivery address for the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasAddress"></see></summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName
    /// <summary>
    /// This object property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName

    /// <summary>
    /// The date of marriage, or equivalent, of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#anniversary"></see></summary>
    let anniversary =
        Namespaced_IRI.parse _namespace_name "anniversary" |> NamespacedName

    /// <summary>
    /// To specify the birth date of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#bday"></see></summary>
    let bday = Namespaced_IRI.parse _namespace_name "bday" |> NamespacedName
    /// <summary>
    /// The category information about the object, also known as tags
    /// <see href="http://www.w3.org/2006/vcard/ns#category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    /// This data property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#email"></see></summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName
    /// <summary>
    /// To specify the electronic mail address for communication with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasEmail"></see></summary>
    let hasEmail = Namespaced_IRI.parse _namespace_name "hasEmail" |> NamespacedName

    /// <summary>
    /// This data property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#extended-address"></see></summary>
    let ``extended-address`` =
        Namespaced_IRI.parse _namespace_name "extended-address" |> NamespacedName

    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#geo"></see></summary>
    let geo = Namespaced_IRI.parse _namespace_name "geo" |> NamespacedName
    /// <summary>
    /// To specify information related to the global positioning of the object. May also be used as a property parameter.
    /// <see href="http://www.w3.org/2006/vcard/ns#hasGeo"></see></summary>
    let hasGeo = Namespaced_IRI.parse _namespace_name "hasGeo" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the additional name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasAdditionalName"></see></summary>
    let hasAdditionalName =
        Namespaced_IRI.parse _namespace_name "hasAdditionalName" |> NamespacedName

    /// <summary>
    /// To specify the busy time associated with the object. (Was called FBURL in RFC6350)
    /// <see href="http://www.w3.org/2006/vcard/ns#hasCalendarBusy"></see></summary>
    let hasCalendarBusy =
        Namespaced_IRI.parse _namespace_name "hasCalendarBusy" |> NamespacedName

    /// <summary>
    /// To specify the calendar associated with the object. (Was called CALURI in RFC6350)
    /// <see href="http://www.w3.org/2006/vcard/ns#hasCalendarLink"></see></summary>
    let hasCalendarLink =
        Namespaced_IRI.parse _namespace_name "hasCalendarLink" |> NamespacedName

    /// <summary>
    /// To specify the calendar user address to which a scheduling request be sent for the object. (Was called CALADRURI in RFC6350)
    /// <see href="http://www.w3.org/2006/vcard/ns#hasCalendarRequest"></see></summary>
    let hasCalendarRequest =
        Namespaced_IRI.parse _namespace_name "hasCalendarRequest" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the category data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasCategory"></see></summary>
    let hasCategory =
        Namespaced_IRI.parse _namespace_name "hasCategory" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the country name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasCountryName"></see></summary>
    let hasCountryName =
        Namespaced_IRI.parse _namespace_name "hasCountryName" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the formatted name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasFN"></see></summary>
    let hasFN = Namespaced_IRI.parse _namespace_name "hasFN" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the family name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasFamilyName"></see></summary>
    let hasFamilyName =
        Namespaced_IRI.parse _namespace_name "hasFamilyName" |> NamespacedName

    /// <summary>
    /// To specify  the sex or gender identity of the object. URIs are recommended to enable interoperable sex and gender codes to be used.
    /// <see href="http://www.w3.org/2006/vcard/ns#hasGender"></see></summary>
    let hasGender = Namespaced_IRI.parse _namespace_name "hasGender" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the given name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasGivenName"></see></summary>
    let hasGivenName =
        Namespaced_IRI.parse _namespace_name "hasGivenName" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the honorific prefix data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasHonorificPrefix"></see></summary>
    let hasHonorificPrefix =
        Namespaced_IRI.parse _namespace_name "hasHonorificPrefix" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the honorific suffix data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasHonorificSuffix"></see></summary>
    let hasHonorificSuffix =
        Namespaced_IRI.parse _namespace_name "hasHonorificSuffix" |> NamespacedName

    /// <summary>
    /// To specify the instant messaging and presence protocol communications with the object. (Was called IMPP in RFC6350)
    /// <see href="http://www.w3.org/2006/vcard/ns#hasInstantMessage"></see></summary>
    let hasInstantMessage =
        Namespaced_IRI.parse _namespace_name "hasInstantMessage" |> NamespacedName

    /// <summary>
    /// To specify a public key or authentication certificate associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasKey"></see></summary>
    let hasKey = Namespaced_IRI.parse _namespace_name "hasKey" |> NamespacedName
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#key"></see></summary>
    let key = Namespaced_IRI.parse _namespace_name "key" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the language data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasLanguage"></see></summary>
    let hasLanguage =
        Namespaced_IRI.parse _namespace_name "hasLanguage" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the locality data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasLocality"></see></summary>
    let hasLocality =
        Namespaced_IRI.parse _namespace_name "hasLocality" |> NamespacedName

    /// <summary>
    /// To specify a graphic image of a logo associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasLogo"></see></summary>
    let hasLogo = Namespaced_IRI.parse _namespace_name "hasLogo" |> NamespacedName
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#logo"></see></summary>
    let logo = Namespaced_IRI.parse _namespace_name "logo" |> NamespacedName
    /// <summary>
    /// To specify the components of the name of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasName"></see></summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#n"></see></summary>
    let n = Namespaced_IRI.parse _namespace_name "n" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the nickname data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasNickname"></see></summary>
    let hasNickname =
        Namespaced_IRI.parse _namespace_name "hasNickname" |> NamespacedName

    /// <summary>
    /// The nick name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#nickname"></see></summary>
    let nickname = Namespaced_IRI.parse _namespace_name "nickname" |> NamespacedName
    /// <summary>
    /// Used to support property parameters for the note data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasNote"></see></summary>
    let hasNote = Namespaced_IRI.parse _namespace_name "hasNote" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the organization name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasOrganizationName"></see></summary>
    let hasOrganizationName =
        Namespaced_IRI.parse _namespace_name "hasOrganizationName" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the organization unit name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasOrganizationUnit"></see></summary>
    let hasOrganizationUnit =
        Namespaced_IRI.parse _namespace_name "hasOrganizationUnit" |> NamespacedName

    /// <summary>
    /// To specify an image or photograph information that annotates some aspect of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasPhoto"></see></summary>
    let hasPhoto = Namespaced_IRI.parse _namespace_name "hasPhoto" |> NamespacedName
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#photo"></see></summary>
    let photo = Namespaced_IRI.parse _namespace_name "photo" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the postal code data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasPostalCode"></see></summary>
    let hasPostalCode =
        Namespaced_IRI.parse _namespace_name "hasPostalCode" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the region data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasRegion"></see></summary>
    let hasRegion = Namespaced_IRI.parse _namespace_name "hasRegion" |> NamespacedName
    /// <summary>
    /// To specify a relationship between another entity and the entity represented by this object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasRelated"></see></summary>
    let hasRelated = Namespaced_IRI.parse _namespace_name "hasRelated" |> NamespacedName
    /// <summary>
    /// Used to support property parameters for the role data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasRole"></see></summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName
    /// <summary>
    /// To specify a digital sound content information that annotates some aspect of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasSound"></see></summary>
    let hasSound = Namespaced_IRI.parse _namespace_name "hasSound" |> NamespacedName
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#sound"></see></summary>
    let sound = Namespaced_IRI.parse _namespace_name "sound" |> NamespacedName
    /// <summary>
    /// To identify the source of directory information of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasSource"></see></summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName

    /// <summary>
    /// Used to support property parameters for the street address data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasStreetAddress"></see></summary>
    let hasStreetAddress =
        Namespaced_IRI.parse _namespace_name "hasStreetAddress" |> NamespacedName

    /// <summary>
    /// To specify the telephone number for telephony communication with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasTelephone"></see></summary>
    let hasTelephone =
        Namespaced_IRI.parse _namespace_name "hasTelephone" |> NamespacedName

    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#tel"></see></summary>
    let tel = Namespaced_IRI.parse _namespace_name "tel" |> NamespacedName
    /// <summary>
    /// Used to support property parameters for the title data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasTitle"></see></summary>
    let hasTitle = Namespaced_IRI.parse _namespace_name "hasTitle" |> NamespacedName
    /// <summary>
    /// To specify a value that represents a globally unique identifier corresponding to the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasUID"></see></summary>
    let hasUID = Namespaced_IRI.parse _namespace_name "hasUID" |> NamespacedName
    /// <summary>
    /// To specify a uniform resource locator associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasURL"></see></summary>
    let hasURL = Namespaced_IRI.parse _namespace_name "hasURL" |> NamespacedName
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    /// Used to indicate the resource value of an object property that requires property parameters
    /// <see href="http://www.w3.org/2006/vcard/ns#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName
    /// <summary>
    /// This data property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    /// To specify the language that may be used for contacting the object. May also be used as a property parameter.
    /// <see href="http://www.w3.org/2006/vcard/ns#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// This data property has been deprecated. See hasGeo
    /// <see href="http://www.w3.org/2006/vcard/ns#latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    /// This data property has been deprecated. See hasGeo
    /// <see href="http://www.w3.org/2006/vcard/ns#longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName
    /// <summary>
    /// This data property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#mailer"></see></summary>
    let mailer = Namespaced_IRI.parse _namespace_name "mailer" |> NamespacedName
    /// <summary>
    /// A note associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#note"></see></summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    /// This object property has been mapped. Use the organization-name data property.
    /// <see href="http://www.w3.org/2006/vcard/ns#org"></see></summary>
    let org = Namespaced_IRI.parse _namespace_name "org" |> NamespacedName

    /// <summary>
    /// To specify the organizational name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#organization-name"></see></summary>
    let ``organization-name`` =
        Namespaced_IRI.parse _namespace_name "organization-name" |> NamespacedName

    /// <summary>
    /// To specify the organizational unit name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#organization-unit"></see></summary>
    let ``organization-unit`` =
        Namespaced_IRI.parse _namespace_name "organization-unit" |> NamespacedName

    /// <summary>
    /// This data property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#post-office-box"></see></summary>
    let ``post-office-box`` =
        Namespaced_IRI.parse _namespace_name "post-office-box" |> NamespacedName

    /// <summary>
    /// To specify the identifier for the product that created the object
    /// <see href="http://www.w3.org/2006/vcard/ns#prodid"></see></summary>
    let prodid = Namespaced_IRI.parse _namespace_name "prodid" |> NamespacedName
    /// <summary>
    /// To specify revision information about the object
    /// <see href="http://www.w3.org/2006/vcard/ns#rev"></see></summary>
    let rev = Namespaced_IRI.parse _namespace_name "rev" |> NamespacedName
    /// <summary>
    /// To specify the function or part played in a particular situation by the object
    /// <see href="http://www.w3.org/2006/vcard/ns#role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName

    /// <summary>
    /// To specify the string to be used for national-language-specific sorting. Used as a property parameter only.
    /// <see href="http://www.w3.org/2006/vcard/ns#sort-string"></see></summary>
    let ``sort-string`` =
        Namespaced_IRI.parse _namespace_name "sort-string" |> NamespacedName

    /// <summary>
    /// To specify the position or job of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// To indicate time zone information that is specific to the object. May also be used as a property parameter.
    /// <see href="http://www.w3.org/2006/vcard/ns#tz"></see></summary>
    let tz = Namespaced_IRI.parse _namespace_name "tz" |> NamespacedName
    /// <summary>
    /// Used to indicate the literal value of a data property that requires property parameters
    /// <see href="http://www.w3.org/2006/vcard/ns#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
