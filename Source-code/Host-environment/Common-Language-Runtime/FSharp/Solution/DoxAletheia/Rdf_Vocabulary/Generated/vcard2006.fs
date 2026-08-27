namespace http.www.w3.org._2006.vcard.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vcard2006 =
    let _namespace_iri = Namespace_Iri vcard2006 |> NamespaceIRI
    /// <summary>
    ///   <para>vcard2006:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#">http://www.w3.org/2006/vcard/ns#</seealso>
    let _prefix_iri = Prefixed_Name(vcard2006, "") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Acquaintance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Acquaintance"</para><para>"Acquaintance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Acquaintance">http://www.w3.org/2006/vcard/ns#Acquaintance</seealso>
    let Acquaintance = Prefixed_Name(vcard2006, "Acquaintance") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify the components of the delivery address for the vCard object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"To specify the components of the delivery address for the  object"</para>
    /// labels<para>"Address"</para><para>"Address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Address">http://www.w3.org/2006/vcard/ns#Address</seealso>
    let Address = Prefixed_Name(vcard2006, "Address") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Addressing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These types are concerned with information related to the delivery addressing or label for the vCard object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Addressing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Addressing">http://www.w3.org/2006/vcard/ns#Addressing</seealso>
    let Addressing = Prefixed_Name(vcard2006, "Addressing") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Agent"</para><para>"Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Agent">http://www.w3.org/2006/vcard/ns#Agent</seealso>
    let Agent = Prefixed_Name(vcard2006, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:BBS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"BBS"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#BBS">http://www.w3.org/2006/vcard/ns#BBS</seealso>
    let BBS = Prefixed_Name(vcard2006, "BBS") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Calendar">http://www.w3.org/2006/vcard/ns#Calendar</seealso>
    let Calendar = Prefixed_Name(vcard2006, "Calendar") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:CalendarBusy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify the URI for the busy time associated with the object that the vCard represents.
    /// Was called FBURI in vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Calendar Busy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#CalendarBusy">http://www.w3.org/2006/vcard/ns#CalendarBusy</seealso>
    let CalendarBusy = Prefixed_Name(vcard2006, "CalendarBusy") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:CalendarLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify the URI for a calendar associated with the object represented by the vCard.
    /// Was called CALURI in vCard."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Calendar Link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#CalendarLink">http://www.w3.org/2006/vcard/ns#CalendarLink</seealso>
    let CalendarLink = Prefixed_Name(vcard2006, "CalendarLink") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:CalendarRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify the calendar user address [RFC5545] to which a scheduling request [RFC5546] should be sent for the object represented by the vCard.
    /// Was called CALADRURI in vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Calendar Request"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#CalendarRequest">http://www.w3.org/2006/vcard/ns#CalendarRequest</seealso>
    let CalendarRequest = Prefixed_Name(vcard2006, "CalendarRequest") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Car</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"Car"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Car">http://www.w3.org/2006/vcard/ns#Car</seealso>
    let Car = Prefixed_Name(vcard2006, "Car") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify application category information about the vCard, also known as tags. This was called CATEGORIES in vCard."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Category">http://www.w3.org/2006/vcard/ns#Category</seealso>
    let Category = Prefixed_Name(vcard2006, "Category") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also called mobile telephone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Also called mobile telephone"</para>
    /// labels<para>"Cell"</para><para>"Cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Cell">http://www.w3.org/2006/vcard/ns#Cell</seealso>
    let Cell = Prefixed_Name(vcard2006, "Cell") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Child</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Child"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Child"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Child">http://www.w3.org/2006/vcard/ns#Child</seealso>
    let Child = Prefixed_Name(vcard2006, "Child") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Contains all the Code related Classes that are used to indicate vCard Types"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Code">http://www.w3.org/2006/vcard/ns#Code</seealso>
    let Code = Prefixed_Name(vcard2006, "Code") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Colleague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Colleague"</para><para>"Colleague"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Colleague">http://www.w3.org/2006/vcard/ns#Colleague</seealso>
    let Colleague = Prefixed_Name(vcard2006, "Colleague") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Communication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These properties describe information about how to communicate with the object the vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Communication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Communication">http://www.w3.org/2006/vcard/ns#Communication</seealso>
    let Communication = Prefixed_Name(vcard2006, "Communication") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Contact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Contact"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Contact">http://www.w3.org/2006/vcard/ns#Contact</seealso>
    let Contact = Prefixed_Name(vcard2006, "Contact") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Coresident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Coresident"</para><para>"Coresident"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Coresident">http://www.w3.org/2006/vcard/ns#Coresident</seealso>
    let Coresident = Prefixed_Name(vcard2006, "Coresident") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Coworker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Coworker"</para><para>"Coworker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Coworker">http://www.w3.org/2006/vcard/ns#Coworker</seealso>
    let Coworker = Prefixed_Name(vcard2006, "Coworker") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Crush</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Crush"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Crush"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Crush">http://www.w3.org/2006/vcard/ns#Crush</seealso>
    let Crush = Prefixed_Name(vcard2006, "Crush") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Date"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Date">http://www.w3.org/2006/vcard/ns#Date</seealso>
    let Date = Prefixed_Name(vcard2006, "Date") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Dom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"Dom"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Dom">http://www.w3.org/2006/vcard/ns#Dom</seealso>
    let Dom = Prefixed_Name(vcard2006, "Dom") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify the electronic mail address for communication with the object the vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"To specify the electronic mail address for communication with the object the vCard represents. Use the hasEmail object property."</para>
    /// labels<para>"Email"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Email"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Email">http://www.w3.org/2006/vcard/ns#Email</seealso>
    let Email = Prefixed_Name(vcard2006, "Email") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Emergency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Emergency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Emergency"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Emergency">http://www.w3.org/2006/vcard/ns#Emergency</seealso>
    let Emergency = Prefixed_Name(vcard2006, "Emergency") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Explanatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These properties are concerned with additional explanations, such as that related to informational notes or revisions specific to the  vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Explanatory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Explanatory">http://www.w3.org/2006/vcard/ns#Explanatory</seealso>
    let Explanatory = Prefixed_Name(vcard2006, "Explanatory") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:FN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#FN">http://www.w3.org/2006/vcard/ns#FN</seealso>
    let FN = Prefixed_Name(vcard2006, "FN") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fax"</para><para>"Fax"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Fax">http://www.w3.org/2006/vcard/ns#Fax</seealso>
    let Fax = Prefixed_Name(vcard2006, "Fax") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Female</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Female"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Female"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Female">http://www.w3.org/2006/vcard/ns#Female</seealso>
    let Female = Prefixed_Name(vcard2006, "Female") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:FormattedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the formatted text corresponding to the name of the object the vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Formatted Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#FormattedName">http://www.w3.org/2006/vcard/ns#FormattedName</seealso>
    let FormattedName = Prefixed_Name(vcard2006, "FormattedName") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Friend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Friend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Friend"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Friend">http://www.w3.org/2006/vcard/ns#Friend</seealso>
    let Friend = Prefixed_Name(vcard2006, "Friend") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used for gender codes. The URI of the gender code must be used as the value for Gender."</para>
    /// labels<para>"Gender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Gender"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Gender">http://www.w3.org/2006/vcard/ns#Gender</seealso>
    let Gender = Prefixed_Name(vcard2006, "Gender") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Geo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used to indicate global positioning  information that is specific to an address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Geo">http://www.w3.org/2006/vcard/ns#Geo</seealso>
    let Geo = Prefixed_Name(vcard2006, "Geo") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Geographical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These properties are concerned with information associated with  geographical positions or regions associated with the object the vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geographical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Geographical">http://www.w3.org/2006/vcard/ns#Geographical</seealso>
    let Geographical = Prefixed_Name(vcard2006, "Geographical") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines all the properties required to be a Group of Individuals or  Organizations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Object representing a group of persons or entities.  A group object will usually contain hasMember properties to specify the members of the group."</para>
    /// labels<para>"Group"</para><para>"Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Group">http://www.w3.org/2006/vcard/ns#Group</seealso>
    let Group = Prefixed_Name(vcard2006, "Group") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Home</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This implies that the property is related to an individual's personal life"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This implies that the property is related to an individual's personal life"</para>
    /// labels<para>"Home"</para><para>"Home"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Home">http://www.w3.org/2006/vcard/ns#Home</seealso>
    let Home = Prefixed_Name(vcard2006, "Home") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:ISDN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"ISDN"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#ISDN">http://www.w3.org/2006/vcard/ns#ISDN</seealso>
    let ISDN = Prefixed_Name(vcard2006, "ISDN") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Identification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These types are used to capture information associated with the identification and naming of the entity associated with the vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Identification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Identification">http://www.w3.org/2006/vcard/ns#Identification</seealso>
    let Identification = Prefixed_Name(vcard2006, "Identification") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Individual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines all the properties required to be an Individual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An object representing a single person or entity"</para>
    /// labels<para>"Individual"</para><para>"Individual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Individual">http://www.w3.org/2006/vcard/ns#Individual</seealso>
    let Individual = Prefixed_Name(vcard2006, "Individual") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:InstantMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify the URI for instant messaging and presence protocol communications with the object the vCard represents.
    /// Was called IMPP in vCard."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Messaging"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#InstantMessage">http://www.w3.org/2006/vcard/ns#InstantMessage</seealso>
    let InstantMessage = Prefixed_Name(vcard2006, "InstantMessage") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Internet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"Internet"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Internet">http://www.w3.org/2006/vcard/ns#Internet</seealso>
    let Internet = Prefixed_Name(vcard2006, "Internet") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Intl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"Intl"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Intl">http://www.w3.org/2006/vcard/ns#Intl</seealso>
    let Intl = Prefixed_Name(vcard2006, "Intl") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Key">http://www.w3.org/2006/vcard/ns#Key</seealso>
    let Key = Prefixed_Name(vcard2006, "Key") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Kin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Kin"</para><para>"Kin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Kin">http://www.w3.org/2006/vcard/ns#Kin</seealso>
    let Kin = Prefixed_Name(vcard2006, "Kin") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The parent class for all objects"</para>
    ///   <para>"The parent class for all vCard Objects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""Kinds" to represent the types of objects to be represented by vCard:
    /// Individual - To represent people
    /// Organization - To represent organisations
    /// Group - To represent groups of vCard objects
    /// Location - To represent location objects"</para>
    /// labels<para>"Kind"</para><para>"VCard Kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Kind">http://www.w3.org/2006/vcard/ns#Kind</seealso>
    let Kind = Prefixed_Name(vcard2006, "Kind") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"Label"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Label">http://www.w3.org/2006/vcard/ns#Label</seealso>
    let Label = Prefixed_Name(vcard2006, "Label") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify the language(s) that may be used for contacting the entity associated with the vCard."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Language">http://www.w3.org/2006/vcard/ns#Language</seealso>
    let Language = Prefixed_Name(vcard2006, "Language") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object representing a named geographical place"</para>
    ///   <para>"Defines all the properties required to be a Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Un objeto que representa un sitio geográfico"</para>
    /// labels<para>"Location"</para><para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Lugar"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Location">http://www.w3.org/2006/vcard/ns#Location</seealso>
    let Location = Prefixed_Name(vcard2006, "Location") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify a graphic image of a logo associated with the  object the vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Logo">http://www.w3.org/2006/vcard/ns#Logo</seealso>
    let Logo = Prefixed_Name(vcard2006, "Logo") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Male</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Male"</para><para>"Male"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Male">http://www.w3.org/2006/vcard/ns#Male</seealso>
    let Male = Prefixed_Name(vcard2006, "Male") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Me</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Me"</para><para>"Me"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Me">http://www.w3.org/2006/vcard/ns#Me</seealso>
    let Me = Prefixed_Name(vcard2006, "Me") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Met</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Met"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Met"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Met">http://www.w3.org/2006/vcard/ns#Met</seealso>
    let Met = Prefixed_Name(vcard2006, "Met") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Modem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"Modem"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Modem">http://www.w3.org/2006/vcard/ns#Modem</seealso>
    let Modem = Prefixed_Name(vcard2006, "Modem") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Msg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"Msg"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Msg">http://www.w3.org/2006/vcard/ns#Msg</seealso>
    let Msg = Prefixed_Name(vcard2006, "Msg") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Muse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Muse"</para><para>"Muse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Muse">http://www.w3.org/2006/vcard/ns#Muse</seealso>
    let Muse = Prefixed_Name(vcard2006, "Muse") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:N</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#N">http://www.w3.org/2006/vcard/ns#N</seealso>
    let N = Prefixed_Name(vcard2006, "N") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify the components of the name of the object"</para>
    ///   <para>"Specifies the components of the name of the object the  vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Name"</para><para>"Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Name">http://www.w3.org/2006/vcard/ns#Name</seealso>
    let Name = Prefixed_Name(vcard2006, "Name") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Neighbor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Neighbor"</para><para>"Neighbor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Neighbor">http://www.w3.org/2006/vcard/ns#Neighbor</seealso>
    let Neighbor = Prefixed_Name(vcard2006, "Neighbor") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Nickname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the text corresponding to the nickname of the object the vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nickname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Nickname">http://www.w3.org/2006/vcard/ns#Nickname</seealso>
    let Nickname = Prefixed_Name(vcard2006, "Nickname") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:None</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"None"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#None">http://www.w3.org/2006/vcard/ns#None</seealso>
    let None = Prefixed_Name(vcard2006, "None") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify supplemental information or a comment that is associated with the vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Note">http://www.w3.org/2006/vcard/ns#Note</seealso>
    let Note = Prefixed_Name(vcard2006, "Note") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:ORG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#ORG">http://www.w3.org/2006/vcard/ns#ORG</seealso>
    let ORG = Prefixed_Name(vcard2006, "ORG") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object representing an organization.  An organization is a single entity, and might represent a business or government, a department or division within a business or government, a club, an association, or the like.
    /// "</para>
    ///   <para>"To specify the organizational name  associated with the vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Defines all the properties required to be an  Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organization"</para><para>"Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Organization">http://www.w3.org/2006/vcard/ns#Organization</seealso>
    let Organization = Prefixed_Name(vcard2006, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:OrganizationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organization Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#OrganizationName">http://www.w3.org/2006/vcard/ns#OrganizationName</seealso>
    let OrganizationName = Prefixed_Name(vcard2006, "OrganizationName") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:OrganizationUnitName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organizational Unit Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#OrganizationUnitName">http://www.w3.org/2006/vcard/ns#OrganizationUnitName</seealso>
    let OrganizationUnitName =
        Prefixed_Name(vcard2006, "OrganizationUnitName") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:Organizational</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These properties are concerned with information associated with characteristics of the organization or organizational units of the object that the vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organizational"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Organizational">http://www.w3.org/2006/vcard/ns#Organizational</seealso>
    let Organizational = Prefixed_Name(vcard2006, "Organizational") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Other"</para><para>"Other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Other">http://www.w3.org/2006/vcard/ns#Other</seealso>
    let Other = Prefixed_Name(vcard2006, "Other") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:PCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"PCS"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#PCS">http://www.w3.org/2006/vcard/ns#PCS</seealso>
    let PCS = Prefixed_Name(vcard2006, "PCS") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Pager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pager"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Pager"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Pager">http://www.w3.org/2006/vcard/ns#Pager</seealso>
    let Pager = Prefixed_Name(vcard2006, "Pager") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Parcel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"Parcel"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Parcel">http://www.w3.org/2006/vcard/ns#Parcel</seealso>
    let Parcel = Prefixed_Name(vcard2006, "Parcel") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Parent"</para><para>"Parent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Parent">http://www.w3.org/2006/vcard/ns#Parent</seealso>
    let Parent = Prefixed_Name(vcard2006, "Parent") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Photo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies an image or photograph information that annotates some aspect of the object the vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Photo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Photo">http://www.w3.org/2006/vcard/ns#Photo</seealso>
    let Photo = Prefixed_Name(vcard2006, "Photo") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Postal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"Postal"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Postal">http://www.w3.org/2006/vcard/ns#Postal</seealso>
    let Postal = Prefixed_Name(vcard2006, "Postal") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Pref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"Pref"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Pref">http://www.w3.org/2006/vcard/ns#Pref</seealso>
    let Pref = Prefixed_Name(vcard2006, "Pref") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Related</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify a relationship between another entity and the entity represented by this vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Related"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Related">http://www.w3.org/2006/vcard/ns#Related</seealso>
    let Related = Prefixed_Name(vcard2006, "Related") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:RelatedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used for relation type codes. The URI of the relation type code must be used as the value for the Relation Type."</para>
    /// labels<para>"Relation Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Relation Type"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#RelatedType">http://www.w3.org/2006/vcard/ns#RelatedType</seealso>
    let RelatedType = Prefixed_Name(vcard2006, "RelatedType") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Role</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Role">http://www.w3.org/2006/vcard/ns#Role</seealso>
    let Role = Prefixed_Name(vcard2006, "Role") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Security</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Contains all the Security related Classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Security">http://www.w3.org/2006/vcard/ns#Security</seealso>
    let Security = Prefixed_Name(vcard2006, "Security") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Sibling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sibling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Sibling"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Sibling">http://www.w3.org/2006/vcard/ns#Sibling</seealso>
    let Sibling = Prefixed_Name(vcard2006, "Sibling") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify a digital sound content information that annotates some aspect of the vCard.  This property is often used to specify the proper pronunciation of the name property value of the vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Sound">http://www.w3.org/2006/vcard/ns#Sound</seealso>
    let Sound = Prefixed_Name(vcard2006, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Spouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spouse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Spouse"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Spouse">http://www.w3.org/2006/vcard/ns#Spouse</seealso>
    let Spouse = Prefixed_Name(vcard2006, "Spouse") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Sweetheart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sweetheart"</para><para>"Sweetheart"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Sweetheart">http://www.w3.org/2006/vcard/ns#Sweetheart</seealso>
    let Sweetheart = Prefixed_Name(vcard2006, "Sweetheart") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Tel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated. Use the hasTelephone object property."</para>
    /// labels<para>"Tel"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Tel">http://www.w3.org/2006/vcard/ns#Tel</seealso>
    let Tel = Prefixed_Name(vcard2006, "Tel") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telephone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Telephone">http://www.w3.org/2006/vcard/ns#Telephone</seealso>
    let Telephone = Prefixed_Name(vcard2006, "Telephone") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:TelephoneType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used for telephone type codes. The URI of the telephone type code must be used as the value for the Telephone Type."</para>
    /// labels<para>"Telephone Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Phone"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#TelephoneType">http://www.w3.org/2006/vcard/ns#TelephoneType</seealso>
    let TelephoneType = Prefixed_Name(vcard2006, "TelephoneType") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also called sms telephone"</para>
    ///   <para>"Also called sms telephone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Text"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Text">http://www.w3.org/2006/vcard/ns#Text</seealso>
    let Text = Prefixed_Name(vcard2006, "Text") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:TextPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Text phone"</para><para>"Text Phone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#TextPhone">http://www.w3.org/2006/vcard/ns#TextPhone</seealso>
    let TextPhone = Prefixed_Name(vcard2006, "TextPhone") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:TimeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used to indicate time zone information that is specific to a location or address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time Zone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#TimeZone">http://www.w3.org/2006/vcard/ns#TimeZone</seealso>
    let TimeZone = Prefixed_Name(vcard2006, "TimeZone") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify the position or job of the object the vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Title">http://www.w3.org/2006/vcard/ns#Title</seealso>
    let Title = Prefixed_Name(vcard2006, "Title") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is called TYPE in vCard but renamed here to Context for less confusion (with types/class)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Used for type codes. The URI of the type code must be used as the value for Type."</para>
    /// labels<para>"Type"</para><para>"Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Type">http://www.w3.org/2006/vcard/ns#Type</seealso>
    let Type = Prefixed_Name(vcard2006, "Type") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:URL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To specify a uniform resource locator associated with the object to which the vCard refers.  Examples for individuals include personal web sites, blogs, and social networking site  identifiers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#URL">http://www.w3.org/2006/vcard/ns#URL</seealso>
    let URL = Prefixed_Name(vcard2006, "URL") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unknown"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Unknown"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Unknown">http://www.w3.org/2006/vcard/ns#Unknown</seealso>
    let Unknown = Prefixed_Name(vcard2006, "Unknown") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:VCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The vCard class is  equivalent to the new Kind class, which is the parent for the four explicit types of vCards (Individual, Organization, Location, Group)"</para>
    /// labels<para>"VCard"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#VCard">http://www.w3.org/2006/vcard/ns#VCard</seealso>
    let VCard = Prefixed_Name(vcard2006, "VCard") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Vcard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"parent for the four explicit types of vCards (Individual, Organization, Location, Group)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Vcard">http://www.w3.org/2006/vcard/ns#Vcard</seealso>
    let Vcard = Prefixed_Name(vcard2006, "Vcard") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Video</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Video"</para><para>"Video"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Video">http://www.w3.org/2006/vcard/ns#Video</seealso>
    let Video = Prefixed_Name(vcard2006, "Video") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Voice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Voice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Voice"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Voice">http://www.w3.org/2006/vcard/ns#Voice</seealso>
    let Voice = Prefixed_Name(vcard2006, "Voice") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This implies that the property is related to an individual's work place"</para>
    ///   <para>"This implies that the property is related to an individual's work place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Work"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#Work">http://www.w3.org/2006/vcard/ns#Work</seealso>
    let Work = Prefixed_Name(vcard2006, "Work") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:X400</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated"</para>
    /// labels<para>"X400"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#X400">http://www.w3.org/2006/vcard/ns#X400</seealso>
    let X400 = Prefixed_Name(vcard2006, "X400") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:additional-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The additional name associated with the object"</para>
    /// labels<para>"additional name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#additional-name">http://www.w3.org/2006/vcard/ns#additional-name</seealso>
    let additional_name = Prefixed_Name(vcard2006, "additional-name") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:additionalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"additional name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#additionalName">http://www.w3.org/2006/vcard/ns#additionalName</seealso>
    let additionalName = Prefixed_Name(vcard2006, "additionalName") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:adr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property has been mapped"</para>
    /// labels<para>"address"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#adr">http://www.w3.org/2006/vcard/ns#adr</seealso>
    let adr = Prefixed_Name(vcard2006, "adr") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property has been deprecated"</para>
    /// labels<para>"agent"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#agent">http://www.w3.org/2006/vcard/ns#agent</seealso>
    let agent = Prefixed_Name(vcard2006, "agent") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:anniversary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date of marriage, or equivalent, of the object the  vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The date of marriage, or equivalent, of the object"</para>
    /// labels<para>"anniversary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"anniversary"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#anniversary">http://www.w3.org/2006/vcard/ns#anniversary</seealso>
    let anniversary = Prefixed_Name(vcard2006, "anniversary") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:bday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"To specify the birth date of the object"</para>
    /// labels<para>"birth date"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#bday">http://www.w3.org/2006/vcard/ns#bday</seealso>
    let bday = Prefixed_Name(vcard2006, "bday") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:birthdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify the birth date of the object the vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"birthdate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#birthdate">http://www.w3.org/2006/vcard/ns#birthdate</seealso>
    let birthdate = Prefixed_Name(vcard2006, "birthdate") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:calendarBusy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"calendar busy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#calendarBusy">http://www.w3.org/2006/vcard/ns#calendarBusy</seealso>
    let calendarBusy = Prefixed_Name(vcard2006, "calendarBusy") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:calendarLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"calendar link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#calendarLink">http://www.w3.org/2006/vcard/ns#calendarLink</seealso>
    let calendarLink = Prefixed_Name(vcard2006, "calendarLink") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:calendarRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"calendar request"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#calendarRequest">http://www.w3.org/2006/vcard/ns#calendarRequest</seealso>
    let calendarRequest = Prefixed_Name(vcard2006, "calendarRequest") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The category information about the object, also known as tags"</para>
    /// labels<para>"category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"category"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#category">http://www.w3.org/2006/vcard/ns#category</seealso>
    let category = Prefixed_Name(vcard2006, "category") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This data property has been deprecated"</para>
    /// labels<para>"class"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#class">http://www.w3.org/2006/vcard/ns#class</seealso>
    let class_ = Prefixed_Name(vcard2006, "class") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#country">http://www.w3.org/2006/vcard/ns#country</seealso>
    let country = Prefixed_Name(vcard2006, "country") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:country-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The country name associated with the address of the object"</para>
    /// labels<para>"country name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#country-name">http://www.w3.org/2006/vcard/ns#country-name</seealso>
    let country_name = Prefixed_Name(vcard2006, "country-name") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This object property has been mapped"</para>
    ///   <para>"Email"</para>
    /// labels<para>"email"</para><para>"Email"</para><para>"email"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#email">http://www.w3.org/2006/vcard/ns#email</seealso>
    let email = Prefixed_Name(vcard2006, "email") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:extended-address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This data property has been deprecated"</para>
    /// labels<para>"extended address"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#extended-address">http://www.w3.org/2006/vcard/ns#extended-address</seealso>
    let extended_address = Prefixed_Name(vcard2006, "extended-address") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:family-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The family name associated with the object"</para>
    /// labels<para>"family name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#family-name">http://www.w3.org/2006/vcard/ns#family-name</seealso>
    let family_name = Prefixed_Name(vcard2006, "family-name") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:familyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Called Family Name in vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has last name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#familyName">http://www.w3.org/2006/vcard/ns#familyName</seealso>
    let familyName = Prefixed_Name(vcard2006, "familyName") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:fn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The formatted text corresponding to the name of the object"</para>
    ///   <para>"Nombre"</para>
    /// labels<para>"formatted name"</para><para>"Nombre"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#fn">http://www.w3.org/2006/vcard/ns#fn</seealso>
    let fn = Prefixed_Name(vcard2006, "fn") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:formattedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has formatted name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#formattedName">http://www.w3.org/2006/vcard/ns#formattedName</seealso>
    let formattedName = Prefixed_Name(vcard2006, "formattedName") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify the components of the sex and gender identity of the object the vCard represents.
    /// To enable other Gender/Sex codes to be used, this dataproperty has range URI. The vCard gender code classes are defined under Code/Gender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#gender">http://www.w3.org/2006/vcard/ns#gender</seealso>
    let gender = Prefixed_Name(vcard2006, "gender") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:geo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This object property has been mapped"</para>
    ///   <para>"Must use the geo URI scheme RFC5870"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geo"</para><para>"geo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#geo">http://www.w3.org/2006/vcard/ns#geo</seealso>
    let geo = Prefixed_Name(vcard2006, "geo") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:given-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The given name associated with the object"</para>
    /// labels<para>"given name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#given-name">http://www.w3.org/2006/vcard/ns#given-name</seealso>
    let given_name = Prefixed_Name(vcard2006, "given-name") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:givenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"called Given Name invCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"first name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#givenName">http://www.w3.org/2006/vcard/ns#givenName</seealso>
    let givenName = Prefixed_Name(vcard2006, "givenName") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasAdditionalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the additional name data property"</para>
    /// labels<para>"has additional name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasAdditionalName">http://www.w3.org/2006/vcard/ns#hasAdditionalName</seealso>
    let hasAdditionalName =
        Prefixed_Name(vcard2006, "hasAdditionalName") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify the components of the delivery address for the object"</para>
    ///   <para>"To specify the components of the delivery address for the vCard object."</para>
    /// labels<para>"has address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has address"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasAddress">http://www.w3.org/2006/vcard/ns#hasAddress</seealso>
    let hasAddress = Prefixed_Name(vcard2006, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasCalendarBusy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify the busy time associated with the object. (Was called FBURL in RFC6350)"</para>
    /// labels<para>"has calendar busy"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasCalendarBusy">http://www.w3.org/2006/vcard/ns#hasCalendarBusy</seealso>
    let hasCalendarBusy = Prefixed_Name(vcard2006, "hasCalendarBusy") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasCalendarLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify the calendar associated with the object. (Was called CALURI in RFC6350)"</para>
    /// labels<para>"has calendar link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has calendar link"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasCalendarLink">http://www.w3.org/2006/vcard/ns#hasCalendarLink</seealso>
    let hasCalendarLink = Prefixed_Name(vcard2006, "hasCalendarLink") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasCalendarRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify the calendar user address to which a scheduling request be sent for the object. (Was called CALADRURI in RFC6350)"</para>
    /// labels<para>"has calendar request"</para><para>"has calendar request"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasCalendarRequest">http://www.w3.org/2006/vcard/ns#hasCalendarRequest</seealso>
    let hasCalendarRequest =
        Prefixed_Name(vcard2006, "hasCalendarRequest") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasCalenderBusy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has calendar busy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasCalenderBusy">http://www.w3.org/2006/vcard/ns#hasCalenderBusy</seealso>
    let hasCalenderBusy = Prefixed_Name(vcard2006, "hasCalenderBusy") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the category data property"</para>
    /// labels<para>"has category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has category"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasCategory">http://www.w3.org/2006/vcard/ns#hasCategory</seealso>
    let hasCategory = Prefixed_Name(vcard2006, "hasCategory") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasCountryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the country name data property"</para>
    /// labels<para>"has country name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasCountryName">http://www.w3.org/2006/vcard/ns#hasCountryName</seealso>
    let hasCountryName = Prefixed_Name(vcard2006, "hasCountryName") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"To specify the electronic mail address for communication with the object"</para>
    ///   <para>"To specify the electronic mail address for communication with the object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has email"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has email"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasEmail">http://www.w3.org/2006/vcard/ns#hasEmail</seealso>
    let hasEmail = Prefixed_Name(vcard2006, "hasEmail") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasFN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the formatted name data property"</para>
    /// labels<para>"has formatted name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasFN">http://www.w3.org/2006/vcard/ns#hasFN</seealso>
    let hasFN = Prefixed_Name(vcard2006, "hasFN") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasFamilyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the family name data property"</para>
    /// labels<para>"has family name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasFamilyName">http://www.w3.org/2006/vcard/ns#hasFamilyName</seealso>
    let hasFamilyName = Prefixed_Name(vcard2006, "hasFamilyName") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasFormattedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has formatted name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasFormattedName">http://www.w3.org/2006/vcard/ns#hasFormattedName</seealso>
    let hasFormattedName = Prefixed_Name(vcard2006, "hasFormattedName") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify  the sex or gender identity of the object. URIs are recommended to enable interoperable sex and gender codes to be used."</para>
    /// labels<para>"has gender"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasGender">http://www.w3.org/2006/vcard/ns#hasGender</seealso>
    let hasGender = Prefixed_Name(vcard2006, "hasGender") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasGeo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify information related to the global positioning of the object. May also be used as a property parameter."</para>
    /// labels<para>"has geo"</para><para>"has geo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasGeo">http://www.w3.org/2006/vcard/ns#hasGeo</seealso>
    let hasGeo = Prefixed_Name(vcard2006, "hasGeo") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasGivenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the given name data property"</para>
    /// labels<para>"has given name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasGivenName">http://www.w3.org/2006/vcard/ns#hasGivenName</seealso>
    let hasGivenName = Prefixed_Name(vcard2006, "hasGivenName") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasHonorificPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the honorific prefix data property"</para>
    /// labels<para>"has honorific prefix"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasHonorificPrefix">http://www.w3.org/2006/vcard/ns#hasHonorificPrefix</seealso>
    let hasHonorificPrefix =
        Prefixed_Name(vcard2006, "hasHonorificPrefix") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasHonorificSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the honorific suffix data property"</para>
    /// labels<para>"has honorific suffix"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasHonorificSuffix">http://www.w3.org/2006/vcard/ns#hasHonorificSuffix</seealso>
    let hasHonorificSuffix =
        Prefixed_Name(vcard2006, "hasHonorificSuffix") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasInstantMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify the instant messaging and presence protocol communications with the object. (Was called IMPP in RFC6350)"</para>
    /// labels<para>"has messaging"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has messaging"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasInstantMessage">http://www.w3.org/2006/vcard/ns#hasInstantMessage</seealso>
    let hasInstantMessage =
        Prefixed_Name(vcard2006, "hasInstantMessage") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify a public key or authentication certificate associated with the object"</para>
    /// labels<para>"has key"</para><para>"has key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasKey">http://www.w3.org/2006/vcard/ns#hasKey</seealso>
    let hasKey = Prefixed_Name(vcard2006, "hasKey") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the language data property"</para>
    /// labels<para>"has language"</para><para>"has language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasLanguage">http://www.w3.org/2006/vcard/ns#hasLanguage</seealso>
    let hasLanguage = Prefixed_Name(vcard2006, "hasLanguage") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasLocality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the locality data property"</para>
    /// labels<para>"has locality"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasLocality">http://www.w3.org/2006/vcard/ns#hasLocality</seealso>
    let hasLocality = Prefixed_Name(vcard2006, "hasLocality") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasLogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify a graphic image of a logo associated with the object "</para>
    /// labels<para>"has logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has logo"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasLogo">http://www.w3.org/2006/vcard/ns#hasLogo</seealso>
    let hasLogo = Prefixed_Name(vcard2006, "hasLogo") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To include a member in the group this vCard represents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"To include a member in the group this object represents. (This property can only be used by Group individuals)"</para>
    /// labels<para>"member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has member"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasMember">http://www.w3.org/2006/vcard/ns#hasMember</seealso>
    let hasMember = Prefixed_Name(vcard2006, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify the components of the name of the object"</para>
    /// labels<para>"has name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasName">http://www.w3.org/2006/vcard/ns#hasName</seealso>
    let hasName = Prefixed_Name(vcard2006, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasNickname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the nickname data property"</para>
    /// labels<para>"has nickname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has nickname"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasNickname">http://www.w3.org/2006/vcard/ns#hasNickname</seealso>
    let hasNickname = Prefixed_Name(vcard2006, "hasNickname") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the note data property"</para>
    /// labels<para>"has note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has note"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasNote">http://www.w3.org/2006/vcard/ns#hasNote</seealso>
    let hasNote = Prefixed_Name(vcard2006, "hasNote") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasOrganizationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Used to support property parameters for the organization name data property"</para>
    /// labels<para>"has organization name"</para><para>"has organization name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasOrganizationName">http://www.w3.org/2006/vcard/ns#hasOrganizationName</seealso>
    let hasOrganizationName =
        Prefixed_Name(vcard2006, "hasOrganizationName") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasOrganizationUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the organization unit name data property"</para>
    /// labels<para>"has organization unit name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasOrganizationUnit">http://www.w3.org/2006/vcard/ns#hasOrganizationUnit</seealso>
    let hasOrganizationUnit =
        Prefixed_Name(vcard2006, "hasOrganizationUnit") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasOrganizationalUnitName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has organizational unit name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasOrganizationalUnitName">http://www.w3.org/2006/vcard/ns#hasOrganizationalUnitName</seealso>
    let hasOrganizationalUnitName =
        Prefixed_Name(vcard2006, "hasOrganizationalUnitName") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:hasPhoto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify an image or photograph information that annotates some aspect of the object"</para>
    /// labels<para>"has photo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has photo"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasPhoto">http://www.w3.org/2006/vcard/ns#hasPhoto</seealso>
    let hasPhoto = Prefixed_Name(vcard2006, "hasPhoto") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the postal code data property"</para>
    /// labels<para>"has postal code"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasPostalCode">http://www.w3.org/2006/vcard/ns#hasPostalCode</seealso>
    let hasPostalCode = Prefixed_Name(vcard2006, "hasPostalCode") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the region data property"</para>
    /// labels<para>"has region"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasRegion">http://www.w3.org/2006/vcard/ns#hasRegion</seealso>
    let hasRegion = Prefixed_Name(vcard2006, "hasRegion") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasRelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"To specify a relationship between another entity and the entity represented by this object"</para>
    /// labels<para>"has related"</para><para>"has related"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasRelated">http://www.w3.org/2006/vcard/ns#hasRelated</seealso>
    let hasRelated = Prefixed_Name(vcard2006, "hasRelated") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used to support property parameters for the role data property"</para>
    ///   <para>"To specify the function or part played in a particular situation by an individual."</para>
    /// labels<para>"has role"</para><para>"has role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasRole">http://www.w3.org/2006/vcard/ns#hasRole</seealso>
    let hasRole = Prefixed_Name(vcard2006, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasSound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify a digital sound content information that annotates some aspect of the object"</para>
    /// labels<para>"has sound"</para><para>"has sound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasSound">http://www.w3.org/2006/vcard/ns#hasSound</seealso>
    let hasSound = Prefixed_Name(vcard2006, "hasSound") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To identify the source of directory information of the object"</para>
    /// labels<para>"has source"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasSource">http://www.w3.org/2006/vcard/ns#hasSource</seealso>
    let hasSource = Prefixed_Name(vcard2006, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasStreetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the street address data property"</para>
    ///   <para>"Cotains the street address of a party involved in the invoice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has street address"</para><para>"hasStreetAddress"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasStreetAddress">http://www.w3.org/2006/vcard/ns#hasStreetAddress</seealso>
    let hasStreetAddress = Prefixed_Name(vcard2006, "hasStreetAddress") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasTelephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify the telephone number for telephony communication with the object"</para>
    ///   <para>"To specify the telephone number for telephony communication with the object."</para>
    /// labels<para>"has telephone"</para><para>"has telephone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasTelephone">http://www.w3.org/2006/vcard/ns#hasTelephone</seealso>
    let hasTelephone = Prefixed_Name(vcard2006, "hasTelephone") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasTimeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has time zone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasTimeZone">http://www.w3.org/2006/vcard/ns#hasTimeZone</seealso>
    let hasTimeZone = Prefixed_Name(vcard2006, "hasTimeZone") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to support property parameters for the title data property"</para>
    /// labels<para>"has title"</para><para>"has title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasTitle">http://www.w3.org/2006/vcard/ns#hasTitle</seealso>
    let hasTitle = Prefixed_Name(vcard2006, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"To specify a value that represents a globally unique identifier corresponding to the object"</para>
    /// labels<para>"has uid"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasUID">http://www.w3.org/2006/vcard/ns#hasUID</seealso>
    let hasUID = Prefixed_Name(vcard2006, "hasUID") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"To specify a uniform resource locator associated with the object"</para>
    /// labels<para>"has URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has url"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasURL">http://www.w3.org/2006/vcard/ns#hasURL</seealso>
    let hasURL = Prefixed_Name(vcard2006, "hasURL") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to indicate the resource value of an object property that requires property parameters"</para>
    /// labels<para>"has value"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#hasValue">http://www.w3.org/2006/vcard/ns#hasValue</seealso>
    let hasValue = Prefixed_Name(vcard2006, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:honorific-prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The honorific prefix of the name associated with the object"</para>
    /// labels<para>"honorific prefix"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#honorific-prefix">http://www.w3.org/2006/vcard/ns#honorific-prefix</seealso>
    let honorific_prefix = Prefixed_Name(vcard2006, "honorific-prefix") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:honorific-suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The honorific suffix of the name associated with the object"</para>
    /// labels<para>"honorific suffix"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#honorific-suffix">http://www.w3.org/2006/vcard/ns#honorific-suffix</seealso>
    let honorific_suffix = Prefixed_Name(vcard2006, "honorific-suffix") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:honorificPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Called Honorific Prefix in vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"honorific prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#honorificPrefix">http://www.w3.org/2006/vcard/ns#honorificPrefix</seealso>
    let honorificPrefix = Prefixed_Name(vcard2006, "honorificPrefix") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:honorificSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"honorific suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#honorificSuffix">http://www.w3.org/2006/vcard/ns#honorificSuffix</seealso>
    let honorificSuffix = Prefixed_Name(vcard2006, "honorificSuffix") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:instantMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"instant message"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#instantMessage">http://www.w3.org/2006/vcard/ns#instantMessage</seealso>
    let instantMessage = Prefixed_Name(vcard2006, "instantMessage") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This object property has been mapped"</para>
    /// labels<para>"key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"key"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#key">http://www.w3.org/2006/vcard/ns#key</seealso>
    let key = Prefixed_Name(vcard2006, "key") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This data property has been deprecated"</para>
    /// labels<para>"label"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#label">http://www.w3.org/2006/vcard/ns#label</seealso>
    let label = Prefixed_Name(vcard2006, "label") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify the language that may be used for contacting the object. May also be used as a property parameter."</para>
    ///   <para>"Use 2 char language code from RFC5646"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"language"</para><para>"has language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#language">http://www.w3.org/2006/vcard/ns#language</seealso>
    let language = Prefixed_Name(vcard2006, "language") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This data property has been deprecated. See hasGeo"</para>
    /// labels<para>"latitude"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#latitude">http://www.w3.org/2006/vcard/ns#latitude</seealso>
    let latitude = Prefixed_Name(vcard2006, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:locality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Localidad"</para>
    ///   <para>"The locality (e.g. city or town) associated with the address of the object"</para>
    /// labels<para>"Localidad"</para><para>"locality"</para><para>"locality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#locality">http://www.w3.org/2006/vcard/ns#locality</seealso>
    let locality = Prefixed_Name(vcard2006, "locality") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property has been mapped"</para>
    /// labels<para>"logo"</para><para>"logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#logo">http://www.w3.org/2006/vcard/ns#logo</seealso>
    let logo = Prefixed_Name(vcard2006, "logo") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:long</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#long">http://www.w3.org/2006/vcard/ns#long</seealso>
    let long = Prefixed_Name(vcard2006, "long") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This data property has been deprecated. See hasGeo"</para>
    /// labels<para>"longitude"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#longitude">http://www.w3.org/2006/vcard/ns#longitude</seealso>
    let longitude = Prefixed_Name(vcard2006, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:mailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This data property has been deprecated"</para>
    /// labels<para>"mailer"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#mailer">http://www.w3.org/2006/vcard/ns#mailer</seealso>
    let mailer = Prefixed_Name(vcard2006, "mailer") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:n</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property has been mapped"</para>
    /// labels<para>"name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#n">http://www.w3.org/2006/vcard/ns#n</seealso>
    let n = Prefixed_Name(vcard2006, "n") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:nickName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"nickname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#nickName">http://www.w3.org/2006/vcard/ns#nickName</seealso>
    let nickName = Prefixed_Name(vcard2006, "nickName") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:nickname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The nick name associated with the object"</para>
    /// labels<para>"nickname"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#nickname">http://www.w3.org/2006/vcard/ns#nickname</seealso>
    let nickname = Prefixed_Name(vcard2006, "nickname") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A note associated with the object"</para>
    /// labels<para>"note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"note"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#note">http://www.w3.org/2006/vcard/ns#note</seealso>
    let note = Prefixed_Name(vcard2006, "note") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:org</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Enlace con organización"</para>
    ///   <para>"This object property has been mapped. Use the organization-name data property."</para>
    /// labels<para>"organization"</para><para>"Organización"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#org">http://www.w3.org/2006/vcard/ns#org</seealso>
    let org = Prefixed_Name(vcard2006, "org") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:organization-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify the organizational name associated with the object"</para>
    /// labels<para>"organization name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#organization-name">http://www.w3.org/2006/vcard/ns#organization-name</seealso>
    let organization_name =
        Prefixed_Name(vcard2006, "organization-name") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:organization-unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify the organizational unit name associated with the object"</para>
    /// labels<para>"organizational unit name"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#organization-unit">http://www.w3.org/2006/vcard/ns#organization-unit</seealso>
    let organization_unit =
        Prefixed_Name(vcard2006, "organization-unit") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:organizationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"organization name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#organizationName">http://www.w3.org/2006/vcard/ns#organizationName</seealso>
    let organizationName = Prefixed_Name(vcard2006, "organizationName") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:organizationalUnitName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"organizational unit name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#organizationalUnitName">http://www.w3.org/2006/vcard/ns#organizationalUnitName</seealso>
    let organizationalUnitName =
        Prefixed_Name(vcard2006, "organizationalUnitName") |> PrefixedName

    /// <summary>
    ///   <para>vcard2006:photo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property has been mapped"</para>
    /// labels<para>"photo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"photo"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#photo">http://www.w3.org/2006/vcard/ns#photo</seealso>
    let photo = Prefixed_Name(vcard2006, "photo") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:post-office-box</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This data property has been deprecated"</para>
    /// labels<para>"post office box"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#post-office-box">http://www.w3.org/2006/vcard/ns#post-office-box</seealso>
    let post_office_box = Prefixed_Name(vcard2006, "post-office-box") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:postal-code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The postal code associated with the address of the object"</para>
    ///   <para>"Código postal"</para>
    /// labels<para>"Código postal"</para><para>"postal code"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#postal-code">http://www.w3.org/2006/vcard/ns#postal-code</seealso>
    let postal_code = Prefixed_Name(vcard2006, "postal-code") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:postalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Cotains the postal code of a party involved in the invoice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"postalCode"</para><para>"postal code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#postalCode">http://www.w3.org/2006/vcard/ns#postalCode</seealso>
    let postalCode = Prefixed_Name(vcard2006, "postalCode") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:prodid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify the identifier for the product that created the object"</para>
    /// labels<para>"product id"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#prodid">http://www.w3.org/2006/vcard/ns#prodid</seealso>
    let prodid = Prefixed_Name(vcard2006, "prodid") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:productId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"product ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#productId">http://www.w3.org/2006/vcard/ns#productId</seealso>
    let productId = Prefixed_Name(vcard2006, "productId") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The region (e.g. state or province) associated with the address of the object"</para>
    ///   <para>"Provincia"</para>
    /// labels<para>"Provincia"</para><para>"region"</para><para>"region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#region">http://www.w3.org/2006/vcard/ns#region</seealso>
    let region = Prefixed_Name(vcard2006, "region") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:related</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"related"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#related">http://www.w3.org/2006/vcard/ns#related</seealso>
    let related = Prefixed_Name(vcard2006, "related") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:rev</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify revision information about the object"</para>
    /// labels<para>"revision"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#rev">http://www.w3.org/2006/vcard/ns#rev</seealso>
    let rev = Prefixed_Name(vcard2006, "rev") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"revision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#revision">http://www.w3.org/2006/vcard/ns#revision</seealso>
    let revision = Prefixed_Name(vcard2006, "revision") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify the function or part played in a particular situation by the object"</para>
    /// labels<para>"role"</para><para>"role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#role">http://www.w3.org/2006/vcard/ns#role</seealso>
    let role = Prefixed_Name(vcard2006, "role") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:sort-string</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify the string to be used for national-language-specific sorting. Used as a property parameter only."</para>
    /// labels<para>"sort as"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#sort-string">http://www.w3.org/2006/vcard/ns#sort-string</seealso>
    let sort_string = Prefixed_Name(vcard2006, "sort-string") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:sortAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"sort as"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#sortAs">http://www.w3.org/2006/vcard/ns#sortAs</seealso>
    let sortAs = Prefixed_Name(vcard2006, "sortAs") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property has been mapped"</para>
    /// labels<para>"sound"</para><para>"sound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#sound">http://www.w3.org/2006/vcard/ns#sound</seealso>
    let sound = Prefixed_Name(vcard2006, "sound") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#source">http://www.w3.org/2006/vcard/ns#source</seealso>
    let source = Prefixed_Name(vcard2006, "source") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:street-address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The street address associated with the address of the object"</para>
    ///   <para>"Dirección"</para>
    /// labels<para>"Dirección"</para><para>"street address"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#street-address">http://www.w3.org/2006/vcard/ns#street-address</seealso>
    let street_address = Prefixed_Name(vcard2006, "street-address") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:streetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"street address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#streetAddress">http://www.w3.org/2006/vcard/ns#streetAddress</seealso>
    let streetAddress = Prefixed_Name(vcard2006, "streetAddress") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:tel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Teléfono"</para>
    ///   <para>"This object property has been mapped"</para>
    /// labels<para>"Teléfono"</para><para>"telephone"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#tel">http://www.w3.org/2006/vcard/ns#tel</seealso>
    let tel = Prefixed_Name(vcard2006, "tel") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Telephone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#telephone">http://www.w3.org/2006/vcard/ns#telephone</seealso>
    let telephone = Prefixed_Name(vcard2006, "telephone") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:timeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"timezone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#timeZone">http://www.w3.org/2006/vcard/ns#timeZone</seealso>
    let timeZone = Prefixed_Name(vcard2006, "timeZone") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify the position or job of the object"</para>
    /// labels<para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"title"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#title">http://www.w3.org/2006/vcard/ns#title</seealso>
    let title = Prefixed_Name(vcard2006, "title") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:tz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To indicate time zone information that is specific to the object. May also be used as a property parameter."</para>
    /// labels<para>"time zone"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#tz">http://www.w3.org/2006/vcard/ns#tz</seealso>
    let tz = Prefixed_Name(vcard2006, "tz") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:uid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify a value that represents a globally unique identifier corresponding to the entity associated with the vCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#uid">http://www.w3.org/2006/vcard/ns#uid</seealso>
    let uid = Prefixed_Name(vcard2006, "uid") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This object property has been mapped"</para>
    /// labels<para>"URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"url"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#url">http://www.w3.org/2006/vcard/ns#url</seealso>
    let url = Prefixed_Name(vcard2006, "url") |> PrefixedName
    /// <summary>
    ///   <para>vcard2006:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used to indicate the literal value of a data property that requires property parameters"</para>
    /// labels<para>"value"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/vcard/ns#value">http://www.w3.org/2006/vcard/ns#value</seealso>
    let value = Prefixed_Name(vcard2006, "value") |> PrefixedName
