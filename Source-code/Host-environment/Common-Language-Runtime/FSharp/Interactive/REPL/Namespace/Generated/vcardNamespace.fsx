#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vcard =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2006/vcard/ns#" "vcard"

    /// <summary>
    ///   <para>rdfs:label : Acquaintance</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Acquaintance">vcard:Acquaintance</a>
    /// </summary>
    let Acquaintance = _prefixId.prefix "Acquaintance"
    /// <summary>
    ///   <para>rdfs:comment : To specify the components of the delivery address for the  object</para>
    ///   <para>rdfs:label : Address</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Address">vcard:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Agent">vcard:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : BBS</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#BBS">vcard:BBS</a>
    /// </summary>
    let BBS = _prefixId.prefix "BBS"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : Car</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Car">vcard:Car</a>
    /// </summary>
    let Car = _prefixId.prefix "Car"
    /// <summary>
    ///   <para>rdfs:comment : Also called mobile telephone</para>
    ///   <para>rdfs:label : Cell</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Cell">vcard:Cell</a>
    /// </summary>
    let Cell = _prefixId.prefix "Cell"
    /// <summary>
    ///   <para>rdfs:label : Child</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Child">vcard:Child</a>
    /// </summary>
    let Child = _prefixId.prefix "Child"
    /// <summary>
    ///   <para>rdfs:label : Colleague</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Colleague">vcard:Colleague</a>
    /// </summary>
    let Colleague = _prefixId.prefix "Colleague"
    /// <summary>
    ///   <para>rdfs:label : Contact</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Contact">vcard:Contact</a>
    /// </summary>
    let Contact = _prefixId.prefix "Contact"
    /// <summary>
    ///   <para>rdfs:label : Coresident</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Coresident">vcard:Coresident</a>
    /// </summary>
    let Coresident = _prefixId.prefix "Coresident"
    /// <summary>
    ///   <para>rdfs:label : Coworker</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Coworker">vcard:Coworker</a>
    /// </summary>
    let Coworker = _prefixId.prefix "Coworker"
    /// <summary>
    ///   <para>rdfs:label : Crush</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Crush">vcard:Crush</a>
    /// </summary>
    let Crush = _prefixId.prefix "Crush"
    /// <summary>
    ///   <para>rdfs:label : Date</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Date">vcard:Date</a>
    /// </summary>
    let Date = _prefixId.prefix "Date"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : Dom</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Dom">vcard:Dom</a>
    /// </summary>
    let Dom = _prefixId.prefix "Dom"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : To specify the electronic mail address for communication with the object the vCard represents. Use the hasEmail object property.</para>
    ///   <para>rdfs:label : Email</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Email">vcard:Email</a>
    /// </summary>
    let Email = _prefixId.prefix "Email"
    /// <summary>
    ///   <para>rdfs:label : Emergency</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Emergency">vcard:Emergency</a>
    /// </summary>
    let Emergency = _prefixId.prefix "Emergency"
    /// <summary>
    ///   <para>rdfs:label : Fax</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Fax">vcard:Fax</a>
    /// </summary>
    let Fax = _prefixId.prefix "Fax"
    /// <summary>
    ///   <para>rdfs:label : Female</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Female">vcard:Female</a>
    /// </summary>
    let Female = _prefixId.prefix "Female"
    /// <summary>
    ///   <para>rdfs:label : Friend</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Friend">vcard:Friend</a>
    /// </summary>
    let Friend = _prefixId.prefix "Friend"
    /// <summary>
    ///   <para>rdfs:comment : Used for gender codes. The URI of the gender code must be used as the value for Gender.</para>
    ///   <para>rdfs:label : Gender</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Gender">vcard:Gender</a>
    /// </summary>
    let Gender = _prefixId.prefix "Gender"
    /// <summary>
    ///   <para>rdfs:comment : Object representing a group of persons or entities.  A group object will usually contain hasMember properties to specify the members of the group.</para>
    ///   <para>rdfs:label : Group</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Group">vcard:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:comment : This implies that the property is related to an individual's personal life</para>
    ///   <para>rdfs:label : Home</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Home">vcard:Home</a>
    /// </summary>
    let Home = _prefixId.prefix "Home"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : ISDN</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#ISDN">vcard:ISDN</a>
    /// </summary>
    let ISDN = _prefixId.prefix "ISDN"
    /// <summary>
    ///   <para>rdfs:comment : An object representing a single person or entity</para>
    ///   <para>rdfs:label : Individual</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Individual">vcard:Individual</a>
    /// </summary>
    let Individual = _prefixId.prefix "Individual"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : Internet</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Internet">vcard:Internet</a>
    /// </summary>
    let Internet = _prefixId.prefix "Internet"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : Intl</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Intl">vcard:Intl</a>
    /// </summary>
    let Intl = _prefixId.prefix "Intl"
    /// <summary>
    ///   <para>rdfs:label : Kin</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Kin">vcard:Kin</a>
    /// </summary>
    let Kin = _prefixId.prefix "Kin"
    /// <summary>
    ///   <para>rdfs:comment : The parent class for all objects</para>
    ///   <para>rdfs:label : Kind</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Kind">vcard:Kind</a>
    /// </summary>
    let Kind = _prefixId.prefix "Kind"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : Label</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Label">vcard:Label</a>
    /// </summary>
    let Label = _prefixId.prefix "Label"
    /// <summary>
    ///   <para>rdfs:comment : An object representing a named geographical place</para>
    ///   <para>rdfs:label : Location</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Location">vcard:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : Male</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Male">vcard:Male</a>
    /// </summary>
    let Male = _prefixId.prefix "Male"
    /// <summary>
    ///   <para>rdfs:label : Me</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Me">vcard:Me</a>
    /// </summary>
    let Me = _prefixId.prefix "Me"
    /// <summary>
    ///   <para>rdfs:label : Met</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Met">vcard:Met</a>
    /// </summary>
    let Met = _prefixId.prefix "Met"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : Modem</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Modem">vcard:Modem</a>
    /// </summary>
    let Modem = _prefixId.prefix "Modem"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : Msg</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Msg">vcard:Msg</a>
    /// </summary>
    let Msg = _prefixId.prefix "Msg"
    /// <summary>
    ///   <para>rdfs:label : Muse</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Muse">vcard:Muse</a>
    /// </summary>
    let Muse = _prefixId.prefix "Muse"
    /// <summary>
    ///   <para>rdfs:comment : To specify the components of the name of the object</para>
    ///   <para>rdfs:label : Name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Name">vcard:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>rdfs:label : Neighbor</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Neighbor">vcard:Neighbor</a>
    /// </summary>
    let Neighbor = _prefixId.prefix "Neighbor"
    /// <summary>
    ///   <para>rdfs:label : None</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#None">vcard:None</a>
    /// </summary>
    let None = _prefixId.prefix "None"
    /// <summary>
    ///   <para>rdfs:comment : An object representing an organization.  An organization is a single entity, and might represent a business or government, a department or division within a business or government, a club, an association, or the like.
    /// </para>
    ///   <para>rdfs:label : Organization</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Organization">vcard:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:label : Other</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Other">vcard:Other</a>
    /// </summary>
    let Other = _prefixId.prefix "Other"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : PCS</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#PCS">vcard:PCS</a>
    /// </summary>
    let PCS = _prefixId.prefix "PCS"
    /// <summary>
    ///   <para>rdfs:label : Pager</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Pager">vcard:Pager</a>
    /// </summary>
    let Pager = _prefixId.prefix "Pager"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : Parcel</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Parcel">vcard:Parcel</a>
    /// </summary>
    let Parcel = _prefixId.prefix "Parcel"
    /// <summary>
    ///   <para>rdfs:label : Parent</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Parent">vcard:Parent</a>
    /// </summary>
    let Parent = _prefixId.prefix "Parent"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : Postal</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Postal">vcard:Postal</a>
    /// </summary>
    let Postal = _prefixId.prefix "Postal"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : Pref</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Pref">vcard:Pref</a>
    /// </summary>
    let Pref = _prefixId.prefix "Pref"
    /// <summary>
    ///   <para>rdfs:comment : Used for relation type codes. The URI of the relation type code must be used as the value for the Relation Type.</para>
    ///   <para>rdfs:label : Relation Type</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#RelatedType">vcard:RelatedType</a>
    /// </summary>
    let RelatedType = _prefixId.prefix "RelatedType"
    /// <summary>
    ///   <para>rdfs:label : Sibling</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Sibling">vcard:Sibling</a>
    /// </summary>
    let Sibling = _prefixId.prefix "Sibling"
    /// <summary>
    ///   <para>rdfs:label : Spouse</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Spouse">vcard:Spouse</a>
    /// </summary>
    let Spouse = _prefixId.prefix "Spouse"
    /// <summary>
    ///   <para>rdfs:label : Sweetheart</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Sweetheart">vcard:Sweetheart</a>
    /// </summary>
    let Sweetheart = _prefixId.prefix "Sweetheart"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated. Use the hasTelephone object property.</para>
    ///   <para>rdfs:label : Tel</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Tel">vcard:Tel</a>
    /// </summary>
    let Tel = _prefixId.prefix "Tel"
    /// <summary>
    ///   <para>rdfs:comment : Used for telephone type codes. The URI of the telephone type code must be used as the value for the Telephone Type.</para>
    ///   <para>rdfs:label : Phone</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#TelephoneType">vcard:TelephoneType</a>
    /// </summary>
    let TelephoneType = _prefixId.prefix "TelephoneType"
    /// <summary>
    ///   <para>rdfs:comment : Also called sms telephone</para>
    ///   <para>rdfs:label : Text</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Text">vcard:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>rdfs:label : Text phone</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#TextPhone">vcard:TextPhone</a>
    /// </summary>
    let TextPhone = _prefixId.prefix "TextPhone"
    /// <summary>
    ///   <para>rdfs:comment : Used for type codes. The URI of the type code must be used as the value for Type.</para>
    ///   <para>rdfs:label : Type</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Type">vcard:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>rdfs:label : Unknown</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Unknown">vcard:Unknown</a>
    /// </summary>
    let Unknown = _prefixId.prefix "Unknown"
    /// <summary>
    ///   <para>rdfs:comment : The vCard class is  equivalent to the new Kind class, which is the parent for the four explicit types of vCards (Individual, Organization, Location, Group)</para>
    ///   <para>rdfs:label : VCard</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#VCard">vcard:VCard</a>
    /// </summary>
    let VCard = _prefixId.prefix "VCard"
    /// <summary>
    ///   <para>rdfs:label : Video</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Video">vcard:Video</a>
    /// </summary>
    let Video = _prefixId.prefix "Video"
    /// <summary>
    ///   <para>rdfs:label : Voice</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Voice">vcard:Voice</a>
    /// </summary>
    let Voice = _prefixId.prefix "Voice"
    /// <summary>
    ///   <para>rdfs:comment : This implies that the property is related to an individual's work place</para>
    ///   <para>rdfs:label : Work</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#Work">vcard:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This class is deprecated</para>
    ///   <para>rdfs:label : X400</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#X400">vcard:X400</a>
    /// </summary>
    let X400 = _prefixId.prefix "X400"
    /// <summary>
    ///   <para>rdfs:comment : The additional name associated with the object</para>
    ///   <para>rdfs:label : additional name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#additional-name">vcard:additional-name</a>
    /// </summary>
    let additional_name = _prefixId.prefix "additional-name"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped</para>
    ///   <para>rdfs:label : address</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#adr">vcard:adr</a>
    /// </summary>
    let adr = _prefixId.prefix "adr"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This object property has been deprecated</para>
    ///   <para>rdfs:label : agent</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#agent">vcard:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>rdfs:comment : The date of marriage, or equivalent, of the object</para>
    ///   <para>rdfs:label : anniversary</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#anniversary">vcard:anniversary</a>
    /// </summary>
    let anniversary = _prefixId.prefix "anniversary"
    /// <summary>
    ///   <para>rdfs:comment : To specify the birth date of the object</para>
    ///   <para>rdfs:label : birth date</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#bday">vcard:bday</a>
    /// </summary>
    let bday = _prefixId.prefix "bday"
    /// <summary>
    ///   <para>rdfs:comment : The category information about the object, also known as tags</para>
    ///   <para>rdfs:label : category</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#category">vcard:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This data property has been deprecated</para>
    ///   <para>rdfs:label : class</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#class">vcard:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:comment : The country name associated with the address of the object</para>
    ///   <para>rdfs:label : country name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#country-name">vcard:country-name</a>
    /// </summary>
    let country_name = _prefixId.prefix "country-name"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped</para>
    ///   <para>rdfs:label : email</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#email">vcard:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This data property has been deprecated</para>
    ///   <para>rdfs:label : extended address</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#extended-address">vcard:extended-address</a>
    /// </summary>
    let extended_address = _prefixId.prefix "extended-address"
    /// <summary>
    ///   <para>rdfs:comment : The family name associated with the object</para>
    ///   <para>rdfs:label : family name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#family-name">vcard:family-name</a>
    /// </summary>
    let family_name = _prefixId.prefix "family-name"
    /// <summary>
    ///   <para>rdfs:comment : The formatted text corresponding to the name of the object</para>
    ///   <para>rdfs:label : formatted name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#fn">vcard:fn</a>
    /// </summary>
    let fn = _prefixId.prefix "fn"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped</para>
    ///   <para>rdfs:label : geo</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#geo">vcard:geo</a>
    /// </summary>
    let geo = _prefixId.prefix "geo"
    /// <summary>
    ///   <para>rdfs:comment : The given name associated with the object</para>
    ///   <para>rdfs:label : given name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#given-name">vcard:given-name</a>
    /// </summary>
    let given_name = _prefixId.prefix "given-name"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the additional name data property</para>
    ///   <para>rdfs:label : has additional name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasAdditionalName">vcard:hasAdditionalName</a>
    /// </summary>
    let hasAdditionalName = _prefixId.prefix "hasAdditionalName"
    /// <summary>
    ///   <para>rdfs:comment : To specify the components of the delivery address for the object</para>
    ///   <para>rdfs:label : has address</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasAddress">vcard:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>rdfs:comment : To specify the busy time associated with the object. (Was called FBURL in RFC6350)</para>
    ///   <para>rdfs:label : has calendar busy</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasCalendarBusy">vcard:hasCalendarBusy</a>
    /// </summary>
    let hasCalendarBusy = _prefixId.prefix "hasCalendarBusy"
    /// <summary>
    ///   <para>rdfs:comment : To specify the calendar associated with the object. (Was called CALURI in RFC6350)</para>
    ///   <para>rdfs:label : has calendar link</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasCalendarLink">vcard:hasCalendarLink</a>
    /// </summary>
    let hasCalendarLink = _prefixId.prefix "hasCalendarLink"
    /// <summary>
    ///   <para>rdfs:comment : To specify the calendar user address to which a scheduling request be sent for the object. (Was called CALADRURI in RFC6350)</para>
    ///   <para>rdfs:label : has calendar request</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasCalendarRequest">vcard:hasCalendarRequest</a>
    /// </summary>
    let hasCalendarRequest = _prefixId.prefix "hasCalendarRequest"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the category data property</para>
    ///   <para>rdfs:label : has category</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasCategory">vcard:hasCategory</a>
    /// </summary>
    let hasCategory = _prefixId.prefix "hasCategory"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the country name data property</para>
    ///   <para>rdfs:label : has country name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasCountryName">vcard:hasCountryName</a>
    /// </summary>
    let hasCountryName = _prefixId.prefix "hasCountryName"
    /// <summary>
    ///   <para>rdfs:comment : To specify the electronic mail address for communication with the object</para>
    ///   <para>rdfs:label : has email</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasEmail">vcard:hasEmail</a>
    /// </summary>
    let hasEmail = _prefixId.prefix "hasEmail"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the formatted name data property</para>
    ///   <para>rdfs:label : has formatted name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasFN">vcard:hasFN</a>
    /// </summary>
    let hasFN = _prefixId.prefix "hasFN"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the family name data property</para>
    ///   <para>rdfs:label : has family name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasFamilyName">vcard:hasFamilyName</a>
    /// </summary>
    let hasFamilyName = _prefixId.prefix "hasFamilyName"
    /// <summary>
    ///   <para>rdfs:comment : To specify  the sex or gender identity of the object. URIs are recommended to enable interoperable sex and gender codes to be used.</para>
    ///   <para>rdfs:label : has gender</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasGender">vcard:hasGender</a>
    /// </summary>
    let hasGender = _prefixId.prefix "hasGender"
    /// <summary>
    ///   <para>rdfs:comment : To specify information related to the global positioning of the object. May also be used as a property parameter.</para>
    ///   <para>rdfs:label : has geo</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasGeo">vcard:hasGeo</a>
    /// </summary>
    let hasGeo = _prefixId.prefix "hasGeo"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the given name data property</para>
    ///   <para>rdfs:label : has given name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasGivenName">vcard:hasGivenName</a>
    /// </summary>
    let hasGivenName = _prefixId.prefix "hasGivenName"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the honorific prefix data property</para>
    ///   <para>rdfs:label : has honorific prefix</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasHonorificPrefix">vcard:hasHonorificPrefix</a>
    /// </summary>
    let hasHonorificPrefix = _prefixId.prefix "hasHonorificPrefix"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the honorific suffix data property</para>
    ///   <para>rdfs:label : has honorific suffix</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasHonorificSuffix">vcard:hasHonorificSuffix</a>
    /// </summary>
    let hasHonorificSuffix = _prefixId.prefix "hasHonorificSuffix"
    /// <summary>
    ///   <para>rdfs:comment : To specify the instant messaging and presence protocol communications with the object. (Was called IMPP in RFC6350)</para>
    ///   <para>rdfs:label : has messaging</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasInstantMessage">vcard:hasInstantMessage</a>
    /// </summary>
    let hasInstantMessage = _prefixId.prefix "hasInstantMessage"
    /// <summary>
    ///   <para>rdfs:comment : To specify a public key or authentication certificate associated with the object</para>
    ///   <para>rdfs:label : has key</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasKey">vcard:hasKey</a>
    /// </summary>
    let hasKey = _prefixId.prefix "hasKey"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the language data property</para>
    ///   <para>rdfs:label : has language</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasLanguage">vcard:hasLanguage</a>
    /// </summary>
    let hasLanguage = _prefixId.prefix "hasLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the locality data property</para>
    ///   <para>rdfs:label : has locality</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasLocality">vcard:hasLocality</a>
    /// </summary>
    let hasLocality = _prefixId.prefix "hasLocality"
    /// <summary>
    ///   <para>rdfs:comment : To specify a graphic image of a logo associated with the object </para>
    ///   <para>rdfs:label : has logo</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasLogo">vcard:hasLogo</a>
    /// </summary>
    let hasLogo = _prefixId.prefix "hasLogo"
    /// <summary>
    ///   <para>rdfs:comment : To include a member in the group this object represents. (This property can only be used by Group individuals)</para>
    ///   <para>rdfs:label : has member</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasMember">vcard:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:comment : To specify the components of the name of the object</para>
    ///   <para>rdfs:label : has name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasName">vcard:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the nickname data property</para>
    ///   <para>rdfs:label : has nickname</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasNickname">vcard:hasNickname</a>
    /// </summary>
    let hasNickname = _prefixId.prefix "hasNickname"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the note data property</para>
    ///   <para>rdfs:label : has note</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasNote">vcard:hasNote</a>
    /// </summary>
    let hasNote = _prefixId.prefix "hasNote"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the organization name data property</para>
    ///   <para>rdfs:label : has organization name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasOrganizationName">vcard:hasOrganizationName</a>
    /// </summary>
    let hasOrganizationName = _prefixId.prefix "hasOrganizationName"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the organization unit name data property</para>
    ///   <para>rdfs:label : has organization unit name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasOrganizationUnit">vcard:hasOrganizationUnit</a>
    /// </summary>
    let hasOrganizationUnit = _prefixId.prefix "hasOrganizationUnit"
    /// <summary>
    ///   <para>rdfs:comment : To specify an image or photograph information that annotates some aspect of the object</para>
    ///   <para>rdfs:label : has photo</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasPhoto">vcard:hasPhoto</a>
    /// </summary>
    let hasPhoto = _prefixId.prefix "hasPhoto"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the postal code data property</para>
    ///   <para>rdfs:label : has postal code</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasPostalCode">vcard:hasPostalCode</a>
    /// </summary>
    let hasPostalCode = _prefixId.prefix "hasPostalCode"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the region data property</para>
    ///   <para>rdfs:label : has region</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasRegion">vcard:hasRegion</a>
    /// </summary>
    let hasRegion = _prefixId.prefix "hasRegion"
    /// <summary>
    ///   <para>rdfs:comment : To specify a relationship between another entity and the entity represented by this object</para>
    ///   <para>rdfs:label : has related</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasRelated">vcard:hasRelated</a>
    /// </summary>
    let hasRelated = _prefixId.prefix "hasRelated"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the role data property</para>
    ///   <para>rdfs:label : has role</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasRole">vcard:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:comment : To specify a digital sound content information that annotates some aspect of the object</para>
    ///   <para>rdfs:label : has sound</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasSound">vcard:hasSound</a>
    /// </summary>
    let hasSound = _prefixId.prefix "hasSound"
    /// <summary>
    ///   <para>rdfs:comment : To identify the source of directory information of the object</para>
    ///   <para>rdfs:label : has source</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasSource">vcard:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the street address data property</para>
    ///   <para>rdfs:label : has street address</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasStreetAddress">vcard:hasStreetAddress</a>
    /// </summary>
    let hasStreetAddress = _prefixId.prefix "hasStreetAddress"
    /// <summary>
    ///   <para>rdfs:comment : To specify the telephone number for telephony communication with the object</para>
    ///   <para>rdfs:label : has telephone</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasTelephone">vcard:hasTelephone</a>
    /// </summary>
    let hasTelephone = _prefixId.prefix "hasTelephone"
    /// <summary>
    ///   <para>rdfs:comment : Used to support property parameters for the title data property</para>
    ///   <para>rdfs:label : has title</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasTitle">vcard:hasTitle</a>
    /// </summary>
    let hasTitle = _prefixId.prefix "hasTitle"
    /// <summary>
    ///   <para>rdfs:comment : To specify a value that represents a globally unique identifier corresponding to the object</para>
    ///   <para>rdfs:label : has uid</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasUID">vcard:hasUID</a>
    /// </summary>
    let hasUID = _prefixId.prefix "hasUID"
    /// <summary>
    ///   <para>rdfs:comment : To specify a uniform resource locator associated with the object</para>
    ///   <para>rdfs:label : has url</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasURL">vcard:hasURL</a>
    /// </summary>
    let hasURL = _prefixId.prefix "hasURL"
    /// <summary>
    ///   <para>rdfs:comment : Used to indicate the resource value of an object property that requires property parameters</para>
    ///   <para>rdfs:label : has value</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#hasValue">vcard:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:comment : The honorific prefix of the name associated with the object</para>
    ///   <para>rdfs:label : honorific prefix</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#honorific-prefix">vcard:honorific-prefix</a>
    /// </summary>
    let honorific_prefix = _prefixId.prefix "honorific-prefix"
    /// <summary>
    ///   <para>rdfs:comment : The honorific suffix of the name associated with the object</para>
    ///   <para>rdfs:label : honorific suffix</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#honorific-suffix">vcard:honorific-suffix</a>
    /// </summary>
    let honorific_suffix = _prefixId.prefix "honorific-suffix"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped</para>
    ///   <para>rdfs:label : key</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#key">vcard:key</a>
    /// </summary>
    let key = _prefixId.prefix "key"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This data property has been deprecated</para>
    ///   <para>rdfs:label : label</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#label">vcard:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:comment : To specify the language that may be used for contacting the object. May also be used as a property parameter.</para>
    ///   <para>rdfs:label : language</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#language">vcard:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This data property has been deprecated. See hasGeo</para>
    ///   <para>rdfs:label : latitude</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#latitude">vcard:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    /// <summary>
    ///   <para>rdfs:comment : The locality (e.g. city or town) associated with the address of the object</para>
    ///   <para>rdfs:label : locality</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#locality">vcard:locality</a>
    /// </summary>
    let locality = _prefixId.prefix "locality"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped</para>
    ///   <para>rdfs:label : logo</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#logo">vcard:logo</a>
    /// </summary>
    let logo = _prefixId.prefix "logo"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This data property has been deprecated. See hasGeo</para>
    ///   <para>rdfs:label : longitude</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#longitude">vcard:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This data property has been deprecated</para>
    ///   <para>rdfs:label : mailer</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#mailer">vcard:mailer</a>
    /// </summary>
    let mailer = _prefixId.prefix "mailer"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped</para>
    ///   <para>rdfs:label : name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#n">vcard:n</a>
    /// </summary>
    let n = _prefixId.prefix "n"
    /// <summary>
    ///   <para>rdfs:comment : The nick name associated with the object</para>
    ///   <para>rdfs:label : nickname</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#nickname">vcard:nickname</a>
    /// </summary>
    let nickname = _prefixId.prefix "nickname"
    /// <summary>
    ///   <para>rdfs:comment : A note associated with the object</para>
    ///   <para>rdfs:label : note</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#note">vcard:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped. Use the organization-name data property.</para>
    ///   <para>rdfs:label : organization</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#org">vcard:org</a>
    /// </summary>
    let org = _prefixId.prefix "org"
    /// <summary>
    ///   <para>rdfs:comment : To specify the organizational name associated with the object</para>
    ///   <para>rdfs:label : organization name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#organization-name">vcard:organization-name</a>
    /// </summary>
    let organization_name = _prefixId.prefix "organization-name"
    /// <summary>
    ///   <para>rdfs:comment : To specify the organizational unit name associated with the object</para>
    ///   <para>rdfs:label : organizational unit name</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#organization-unit">vcard:organization-unit</a>
    /// </summary>
    let organization_unit = _prefixId.prefix "organization-unit"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped</para>
    ///   <para>rdfs:label : photo</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#photo">vcard:photo</a>
    /// </summary>
    let photo = _prefixId.prefix "photo"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This data property has been deprecated</para>
    ///   <para>rdfs:label : post office box</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#post-office-box">vcard:post-office-box</a>
    /// </summary>
    let post_office_box = _prefixId.prefix "post-office-box"
    /// <summary>
    ///   <para>rdfs:comment : The postal code associated with the address of the object</para>
    ///   <para>rdfs:label : postal code</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#postal-code">vcard:postal-code</a>
    /// </summary>
    let postal_code = _prefixId.prefix "postal-code"
    /// <summary>
    ///   <para>rdfs:comment : To specify the identifier for the product that created the object</para>
    ///   <para>rdfs:label : product id</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#prodid">vcard:prodid</a>
    /// </summary>
    let prodid = _prefixId.prefix "prodid"
    /// <summary>
    ///   <para>rdfs:comment : The region (e.g. state or province) associated with the address of the object</para>
    ///   <para>rdfs:label : region</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#region">vcard:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    /// <summary>
    ///   <para>rdfs:comment : To specify revision information about the object</para>
    ///   <para>rdfs:label : revision</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#rev">vcard:rev</a>
    /// </summary>
    let rev = _prefixId.prefix "rev"
    /// <summary>
    ///   <para>rdfs:comment : To specify the function or part played in a particular situation by the object</para>
    ///   <para>rdfs:label : role</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#role">vcard:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>rdfs:comment : To specify the string to be used for national-language-specific sorting. Used as a property parameter only.</para>
    ///   <para>rdfs:label : sort as</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#sort-string">vcard:sort-string</a>
    /// </summary>
    let sort_string = _prefixId.prefix "sort-string"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped</para>
    ///   <para>rdfs:label : sound</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#sound">vcard:sound</a>
    /// </summary>
    let sound = _prefixId.prefix "sound"
    /// <summary>
    ///   <para>rdfs:comment : The street address associated with the address of the object</para>
    ///   <para>rdfs:label : street address</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#street-address">vcard:street-address</a>
    /// </summary>
    let street_address = _prefixId.prefix "street-address"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped</para>
    ///   <para>rdfs:label : telephone</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#tel">vcard:tel</a>
    /// </summary>
    let tel = _prefixId.prefix "tel"
    /// <summary>
    ///   <para>rdfs:comment : To specify the position or job of the object</para>
    ///   <para>rdfs:label : title</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#title">vcard:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : To indicate time zone information that is specific to the object. May also be used as a property parameter.</para>
    ///   <para>rdfs:label : time zone</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#tz">vcard:tz</a>
    /// </summary>
    let tz = _prefixId.prefix "tz"
    /// <summary>
    ///   <para>rdfs:comment : This object property has been mapped</para>
    ///   <para>rdfs:label : url</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#url">vcard:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:comment : Used to indicate the literal value of a data property that requires property parameters</para>
    ///   <para>rdfs:label : value</para>
    ///   <a href="http://www.w3.org/2006/vcard/ns#value">vcard:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
