namespace http.www.w3.org._2006.vcard.ns.hash

open DoxAletheia

module vcard2006 =
    let _namespace_name = "http://www.w3.org/2006/vcard/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Acquaintance"></see>
    /// </summary>
    let Acquaintance = _prefix "Acquaintance"
    /// <summary>
    /// Used for relation type codes. The URI of the relation type code must be used as the value for the Relation Type.
    /// <see href="http://www.w3.org/2006/vcard/ns#RelatedType"></see></summary>
    let RelatedType = _prefix "RelatedType"
    /// <summary>
    /// To specify the components of the delivery address for the  object
    /// <see href="http://www.w3.org/2006/vcard/ns#Address"></see></summary>
    let Address = _prefix "Address"
    /// <summary>
    /// The country name associated with the address of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#country-name"></see></summary>
    let ``country-name`` = _prefix "country-name"
    /// <summary>
    /// The locality (e.g. city or town) associated with the address of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#locality"></see></summary>
    let locality = _prefix "locality"
    /// <summary>
    /// The postal code associated with the address of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#postal-code"></see></summary>
    let ``postal-code`` = _prefix "postal-code"
    /// <summary>
    /// The region (e.g. state or province) associated with the address of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#region"></see></summary>
    let region = _prefix "region"
    /// <summary>
    /// The street address associated with the address of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#street-address"></see></summary>
    let ``street-address`` = _prefix "street-address"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Agent"></see>
    /// </summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#BBS"></see></summary>
    let BBS = _prefix "BBS"
    /// <summary>
    /// Used for telephone type codes. The URI of the telephone type code must be used as the value for the Telephone Type.
    /// <see href="http://www.w3.org/2006/vcard/ns#TelephoneType"></see></summary>
    let TelephoneType = _prefix "TelephoneType"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Car"></see></summary>
    let Car = _prefix "Car"
    /// <summary>
    /// Also called mobile telephone
    /// <see href="http://www.w3.org/2006/vcard/ns#Cell"></see></summary>
    let Cell = _prefix "Cell"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Child"></see>
    /// </summary>
    let Child = _prefix "Child"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Colleague"></see>
    /// </summary>
    let Colleague = _prefix "Colleague"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Contact"></see>
    /// </summary>
    let Contact = _prefix "Contact"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Coresident"></see>
    /// </summary>
    let Coresident = _prefix "Coresident"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Coworker"></see>
    /// </summary>
    let Coworker = _prefix "Coworker"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Crush"></see>
    /// </summary>
    let Crush = _prefix "Crush"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Date"></see>
    /// </summary>
    let Date = _prefix "Date"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Dom"></see></summary>
    let Dom = _prefix "Dom"
    /// <summary>
    /// Used for type codes. The URI of the type code must be used as the value for Type.
    /// <see href="http://www.w3.org/2006/vcard/ns#Type"></see></summary>
    let Type = _prefix "Type"
    /// <summary>
    /// To specify the electronic mail address for communication with the object the vCard represents. Use the hasEmail object property.
    /// <see href="http://www.w3.org/2006/vcard/ns#Email"></see></summary>
    let Email = _prefix "Email"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Emergency"></see>
    /// </summary>
    let Emergency = _prefix "Emergency"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Fax"></see>
    /// </summary>
    let Fax = _prefix "Fax"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Female"></see>
    /// </summary>
    let Female = _prefix "Female"
    /// <summary>
    /// Used for gender codes. The URI of the gender code must be used as the value for Gender.
    /// <see href="http://www.w3.org/2006/vcard/ns#Gender"></see></summary>
    let Gender = _prefix "Gender"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Friend"></see>
    /// </summary>
    let Friend = _prefix "Friend"
    /// <summary>
    /// Object representing a group of persons or entities.  A group object will usually contain hasMember properties to specify the members of the group.
    /// <see href="http://www.w3.org/2006/vcard/ns#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// The parent class for all objects
    /// <see href="http://www.w3.org/2006/vcard/ns#Kind"></see></summary>
    let Kind = _prefix "Kind"
    /// <summary>
    /// An object representing an organization.  An organization is a single entity, and might represent a business or government, a department or division within a business or government, a club, an association, or the like.
    ///
    /// <see href="http://www.w3.org/2006/vcard/ns#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// An object representing a named geographical place
    /// <see href="http://www.w3.org/2006/vcard/ns#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// An object representing a single person or entity
    /// <see href="http://www.w3.org/2006/vcard/ns#Individual"></see></summary>
    let Individual = _prefix "Individual"
    /// <summary>
    /// To include a member in the group this object represents. (This property can only be used by Group individuals)
    /// <see href="http://www.w3.org/2006/vcard/ns#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// This implies that the property is related to an individual's personal life
    /// <see href="http://www.w3.org/2006/vcard/ns#Home"></see></summary>
    let Home = _prefix "Home"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#ISDN"></see></summary>
    let ISDN = _prefix "ISDN"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Internet"></see></summary>
    let Internet = _prefix "Internet"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Intl"></see></summary>
    let Intl = _prefix "Intl"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Kin"></see>
    /// </summary>
    let Kin = _prefix "Kin"
    /// <summary>
    /// The vCard class is  equivalent to the new Kind class, which is the parent for the four explicit types of vCards (Individual, Organization, Location, Group)
    /// <see href="http://www.w3.org/2006/vcard/ns#VCard"></see></summary>
    let VCard = _prefix "VCard"
    /// <summary>
    /// The formatted text corresponding to the name of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#fn"></see></summary>
    let fn = _prefix "fn"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Label"></see></summary>
    let Label = _prefix "Label"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Male"></see>
    /// </summary>
    let Male = _prefix "Male"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Me"></see>
    /// </summary>
    let Me = _prefix "Me"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Met"></see>
    /// </summary>
    let Met = _prefix "Met"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Modem"></see></summary>
    let Modem = _prefix "Modem"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Msg"></see></summary>
    let Msg = _prefix "Msg"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Muse"></see>
    /// </summary>
    let Muse = _prefix "Muse"
    /// <summary>
    /// To specify the components of the name of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    /// The additional name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#additional-name"></see></summary>
    let ``additional-name`` = _prefix "additional-name"
    /// <summary>
    /// The family name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#family-name"></see></summary>
    let ``family-name`` = _prefix "family-name"
    /// <summary>
    /// The given name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#given-name"></see></summary>
    let ``given-name`` = _prefix "given-name"
    /// <summary>
    /// The honorific prefix of the name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#honorific-prefix"></see></summary>
    let ``honorific-prefix`` = _prefix "honorific-prefix"
    /// <summary>
    /// The honorific suffix of the name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#honorific-suffix"></see></summary>
    let ``honorific-suffix`` = _prefix "honorific-suffix"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Neighbor"></see>
    /// </summary>
    let Neighbor = _prefix "Neighbor"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#None"></see>
    /// </summary>
    let None = _prefix "None"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Other"></see>
    /// </summary>
    let Other = _prefix "Other"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#PCS"></see></summary>
    let PCS = _prefix "PCS"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Pager"></see>
    /// </summary>
    let Pager = _prefix "Pager"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Parcel"></see></summary>
    let Parcel = _prefix "Parcel"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Parent"></see>
    /// </summary>
    let Parent = _prefix "Parent"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Postal"></see></summary>
    let Postal = _prefix "Postal"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#Pref"></see></summary>
    let Pref = _prefix "Pref"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Sibling"></see>
    /// </summary>
    let Sibling = _prefix "Sibling"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Spouse"></see>
    /// </summary>
    let Spouse = _prefix "Spouse"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Sweetheart"></see>
    /// </summary>
    let Sweetheart = _prefix "Sweetheart"
    /// <summary>
    /// This class is deprecated. Use the hasTelephone object property.
    /// <see href="http://www.w3.org/2006/vcard/ns#Tel"></see></summary>
    let Tel = _prefix "Tel"
    /// <summary>
    /// Also called sms telephone
    /// <see href="http://www.w3.org/2006/vcard/ns#Text"></see></summary>
    let Text = _prefix "Text"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#TextPhone"></see>
    /// </summary>
    let TextPhone = _prefix "TextPhone"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Unknown"></see>
    /// </summary>
    let Unknown = _prefix "Unknown"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Video"></see>
    /// </summary>
    let Video = _prefix "Video"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/vcard/ns#Voice"></see>
    /// </summary>
    let Voice = _prefix "Voice"
    /// <summary>
    /// This implies that the property is related to an individual's work place
    /// <see href="http://www.w3.org/2006/vcard/ns#Work"></see></summary>
    let Work = _prefix "Work"
    /// <summary>
    /// This class is deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#X400"></see></summary>
    let X400 = _prefix "X400"
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#adr"></see></summary>
    let adr = _prefix "adr"
    /// <summary>
    /// To specify the components of the delivery address for the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasAddress"></see></summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    /// This object property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#agent"></see></summary>
    let agent = _prefix "agent"
    /// <summary>
    /// The date of marriage, or equivalent, of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#anniversary"></see></summary>
    let anniversary = _prefix "anniversary"
    /// <summary>
    /// To specify the birth date of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#bday"></see></summary>
    let bday = _prefix "bday"
    /// <summary>
    /// The category information about the object, also known as tags
    /// <see href="http://www.w3.org/2006/vcard/ns#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// This data property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#email"></see></summary>
    let email = _prefix "email"
    /// <summary>
    /// To specify the electronic mail address for communication with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasEmail"></see></summary>
    let hasEmail = _prefix "hasEmail"
    /// <summary>
    /// This data property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#extended-address"></see></summary>
    let ``extended-address`` = _prefix "extended-address"
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#geo"></see></summary>
    let geo = _prefix "geo"
    /// <summary>
    /// To specify information related to the global positioning of the object. May also be used as a property parameter.
    /// <see href="http://www.w3.org/2006/vcard/ns#hasGeo"></see></summary>
    let hasGeo = _prefix "hasGeo"
    /// <summary>
    /// Used to support property parameters for the additional name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasAdditionalName"></see></summary>
    let hasAdditionalName = _prefix "hasAdditionalName"
    /// <summary>
    /// To specify the busy time associated with the object. (Was called FBURL in RFC6350)
    /// <see href="http://www.w3.org/2006/vcard/ns#hasCalendarBusy"></see></summary>
    let hasCalendarBusy = _prefix "hasCalendarBusy"
    /// <summary>
    /// To specify the calendar associated with the object. (Was called CALURI in RFC6350)
    /// <see href="http://www.w3.org/2006/vcard/ns#hasCalendarLink"></see></summary>
    let hasCalendarLink = _prefix "hasCalendarLink"
    /// <summary>
    /// To specify the calendar user address to which a scheduling request be sent for the object. (Was called CALADRURI in RFC6350)
    /// <see href="http://www.w3.org/2006/vcard/ns#hasCalendarRequest"></see></summary>
    let hasCalendarRequest = _prefix "hasCalendarRequest"
    /// <summary>
    /// Used to support property parameters for the category data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasCategory"></see></summary>
    let hasCategory = _prefix "hasCategory"
    /// <summary>
    /// Used to support property parameters for the country name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasCountryName"></see></summary>
    let hasCountryName = _prefix "hasCountryName"
    /// <summary>
    /// Used to support property parameters for the formatted name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasFN"></see></summary>
    let hasFN = _prefix "hasFN"
    /// <summary>
    /// Used to support property parameters for the family name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasFamilyName"></see></summary>
    let hasFamilyName = _prefix "hasFamilyName"
    /// <summary>
    /// To specify  the sex or gender identity of the object. URIs are recommended to enable interoperable sex and gender codes to be used.
    /// <see href="http://www.w3.org/2006/vcard/ns#hasGender"></see></summary>
    let hasGender = _prefix "hasGender"
    /// <summary>
    /// Used to support property parameters for the given name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasGivenName"></see></summary>
    let hasGivenName = _prefix "hasGivenName"
    /// <summary>
    /// Used to support property parameters for the honorific prefix data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasHonorificPrefix"></see></summary>
    let hasHonorificPrefix = _prefix "hasHonorificPrefix"
    /// <summary>
    /// Used to support property parameters for the honorific suffix data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasHonorificSuffix"></see></summary>
    let hasHonorificSuffix = _prefix "hasHonorificSuffix"
    /// <summary>
    /// To specify the instant messaging and presence protocol communications with the object. (Was called IMPP in RFC6350)
    /// <see href="http://www.w3.org/2006/vcard/ns#hasInstantMessage"></see></summary>
    let hasInstantMessage = _prefix "hasInstantMessage"
    /// <summary>
    /// To specify a public key or authentication certificate associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasKey"></see></summary>
    let hasKey = _prefix "hasKey"
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#key"></see></summary>
    let key = _prefix "key"
    /// <summary>
    /// Used to support property parameters for the language data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasLanguage"></see></summary>
    let hasLanguage = _prefix "hasLanguage"
    /// <summary>
    /// Used to support property parameters for the locality data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasLocality"></see></summary>
    let hasLocality = _prefix "hasLocality"
    /// <summary>
    /// To specify a graphic image of a logo associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasLogo"></see></summary>
    let hasLogo = _prefix "hasLogo"
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#logo"></see></summary>
    let logo = _prefix "logo"
    /// <summary>
    /// To specify the components of the name of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasName"></see></summary>
    let hasName = _prefix "hasName"
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#n"></see></summary>
    let n = _prefix "n"
    /// <summary>
    /// Used to support property parameters for the nickname data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasNickname"></see></summary>
    let hasNickname = _prefix "hasNickname"
    /// <summary>
    /// The nick name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#nickname"></see></summary>
    let nickname = _prefix "nickname"
    /// <summary>
    /// Used to support property parameters for the note data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasNote"></see></summary>
    let hasNote = _prefix "hasNote"
    /// <summary>
    /// Used to support property parameters for the organization name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasOrganizationName"></see></summary>
    let hasOrganizationName = _prefix "hasOrganizationName"
    /// <summary>
    /// Used to support property parameters for the organization unit name data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasOrganizationUnit"></see></summary>
    let hasOrganizationUnit = _prefix "hasOrganizationUnit"
    /// <summary>
    /// To specify an image or photograph information that annotates some aspect of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasPhoto"></see></summary>
    let hasPhoto = _prefix "hasPhoto"
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#photo"></see></summary>
    let photo = _prefix "photo"
    /// <summary>
    /// Used to support property parameters for the postal code data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasPostalCode"></see></summary>
    let hasPostalCode = _prefix "hasPostalCode"
    /// <summary>
    /// Used to support property parameters for the region data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasRegion"></see></summary>
    let hasRegion = _prefix "hasRegion"
    /// <summary>
    /// To specify a relationship between another entity and the entity represented by this object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasRelated"></see></summary>
    let hasRelated = _prefix "hasRelated"
    /// <summary>
    /// Used to support property parameters for the role data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasRole"></see></summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    /// To specify a digital sound content information that annotates some aspect of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasSound"></see></summary>
    let hasSound = _prefix "hasSound"
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#sound"></see></summary>
    let sound = _prefix "sound"
    /// <summary>
    /// To identify the source of directory information of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// Used to support property parameters for the street address data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasStreetAddress"></see></summary>
    let hasStreetAddress = _prefix "hasStreetAddress"
    /// <summary>
    /// To specify the telephone number for telephony communication with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasTelephone"></see></summary>
    let hasTelephone = _prefix "hasTelephone"
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#tel"></see></summary>
    let tel = _prefix "tel"
    /// <summary>
    /// Used to support property parameters for the title data property
    /// <see href="http://www.w3.org/2006/vcard/ns#hasTitle"></see></summary>
    let hasTitle = _prefix "hasTitle"
    /// <summary>
    /// To specify a value that represents a globally unique identifier corresponding to the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasUID"></see></summary>
    let hasUID = _prefix "hasUID"
    /// <summary>
    /// To specify a uniform resource locator associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#hasURL"></see></summary>
    let hasURL = _prefix "hasURL"
    /// <summary>
    /// This object property has been mapped
    /// <see href="http://www.w3.org/2006/vcard/ns#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// Used to indicate the resource value of an object property that requires property parameters
    /// <see href="http://www.w3.org/2006/vcard/ns#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// This data property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// To specify the language that may be used for contacting the object. May also be used as a property parameter.
    /// <see href="http://www.w3.org/2006/vcard/ns#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// This data property has been deprecated. See hasGeo
    /// <see href="http://www.w3.org/2006/vcard/ns#latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// This data property has been deprecated. See hasGeo
    /// <see href="http://www.w3.org/2006/vcard/ns#longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// This data property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#mailer"></see></summary>
    let mailer = _prefix "mailer"
    /// <summary>
    /// A note associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#note"></see></summary>
    let note = _prefix "note"
    /// <summary>
    /// This object property has been mapped. Use the organization-name data property.
    /// <see href="http://www.w3.org/2006/vcard/ns#org"></see></summary>
    let org = _prefix "org"
    /// <summary>
    /// To specify the organizational name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#organization-name"></see></summary>
    let ``organization-name`` = _prefix "organization-name"
    /// <summary>
    /// To specify the organizational unit name associated with the object
    /// <see href="http://www.w3.org/2006/vcard/ns#organization-unit"></see></summary>
    let ``organization-unit`` = _prefix "organization-unit"
    /// <summary>
    /// This data property has been deprecated
    /// <see href="http://www.w3.org/2006/vcard/ns#post-office-box"></see></summary>
    let ``post-office-box`` = _prefix "post-office-box"
    /// <summary>
    /// To specify the identifier for the product that created the object
    /// <see href="http://www.w3.org/2006/vcard/ns#prodid"></see></summary>
    let prodid = _prefix "prodid"
    /// <summary>
    /// To specify revision information about the object
    /// <see href="http://www.w3.org/2006/vcard/ns#rev"></see></summary>
    let rev = _prefix "rev"
    /// <summary>
    /// To specify the function or part played in a particular situation by the object
    /// <see href="http://www.w3.org/2006/vcard/ns#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// To specify the string to be used for national-language-specific sorting. Used as a property parameter only.
    /// <see href="http://www.w3.org/2006/vcard/ns#sort-string"></see></summary>
    let ``sort-string`` = _prefix "sort-string"
    /// <summary>
    /// To specify the position or job of the object
    /// <see href="http://www.w3.org/2006/vcard/ns#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// To indicate time zone information that is specific to the object. May also be used as a property parameter.
    /// <see href="http://www.w3.org/2006/vcard/ns#tz"></see></summary>
    let tz = _prefix "tz"
    /// <summary>
    /// Used to indicate the literal value of a data property that requires property parameters
    /// <see href="http://www.w3.org/2006/vcard/ns#value"></see></summary>
    let value = _prefix "value"
