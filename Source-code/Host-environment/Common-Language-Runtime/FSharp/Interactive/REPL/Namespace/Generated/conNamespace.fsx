#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module con =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2000/10/swap/pim/contact#" "con"

    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>rdfs:label : contact point^^xsd:string</para>
    ///   <para>rdfs:comment : A place, or mobile situation, with address, phone number, fax, etc.
    ///     Related to a person by home, office, etc.
    ///     Note one person's workplace may be another person's home.
    ///     A person may have more than one home and more than one workplace.
    ///     (In practice it sometimes maybe useful with restriucted datasets to
    ///     assume that this is not the case, when extracting data from other ontologies
    ///     with no concept of ContactLocation).  Strongly related to a person:
    ///     in some ways a role that a person can be in.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#ContactLocation">con:ContactLocation</a>
    /// </summary>
    let ContactLocation = _prefixId.prefix "ContactLocation"
    let Date = _prefixId.prefix "Date"
    let Fax = _prefixId.prefix "Fax"
    let Female = _prefixId.prefix "Female"
    let LanguageCode = _prefixId.prefix "LanguageCode"
    let Mailbox = _prefixId.prefix "Mailbox"
    let Male = _prefixId.prefix "Male"
    let MobilePhone = _prefixId.prefix "MobilePhone"
    let Pager = _prefixId.prefix "Pager"
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : phonerdfs:label : tel.</para>
    ///   <para>rdfs:comment :
    ///     An end-point in the public swiitched telephone system.
    ///     Anything identified by a URI with tel: scheme is in this class.
    ///     ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#Phone">con:Phone</a>
    /// </summary>
    let Phone = _prefixId.prefix "Phone"
    /// <summary>
    ///   <para>rdfs:comment : The sort of thing which can have a phone number.
    ///     Typically a person or an incorporated company, or unincorporated group.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#SocialEntity">con:SocialEntity</a>
    /// </summary>
    let SocialEntity = _prefixId.prefix "SocialEntity"
    let _EmailAddress = _prefixId.prefix "_EmailAddress"
    let _SubjectToChange = _prefixId.prefix "_SubjectToChange"
    let _URI = _prefixId.prefix "_URI"
    let _addressProperty = _prefixId.prefix "_addressProperty"
    let _example = _prefixId.prefix "_example"
    /// <summary>
    ///   <para>rdfs:label : address</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#address">con:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>rdfs:label : assistant^^xsd:string</para>
    ///   <para>rdfs:comment : A person (or other agent) who is an assistant to the subject.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#assistant">con:assistant</a>
    /// </summary>
    let assistant = _prefixId.prefix "assistant"
    let birthday = _prefixId.prefix "birthday"
    let child = _prefixId.prefix "child"
    let city = _prefixId.prefix "city"
    let country = _prefixId.prefix "country"
    let departmentName = _prefixId.prefix "departmentName"
    let description = _prefixId.prefix "description"
    let emailAddress = _prefixId.prefix "emailAddress"
    /// <summary>
    ///   <para>rdfs:label : emergency only^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#emergency">con:emergency</a>
    /// </summary>
    let emergency = _prefixId.prefix "emergency"
    let familyName = _prefixId.prefix "familyName"
    let fax = _prefixId.prefix "fax"
    let firstName = _prefixId.prefix "firstName"
    /// <summary>
    ///   <para>rdfs:label : full name^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#fullName">con:fullName</a>
    /// </summary>
    let fullName = _prefixId.prefix "fullName"
    let givenName = _prefixId.prefix "givenName"
    /// <summary>
    ///   <para>rdfs:label : home^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#home">con:home</a>
    /// </summary>
    let home = _prefixId.prefix "home"
    let homePage = _prefixId.prefix "homePage"
    let homePageAddress = _prefixId.prefix "homePageAddress"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>rdfs:comment : A person may be known as various strings.
    /// 	For example, an email friendly name string.
    /// 	If you have an email from someone using a string as the human-readable phrase,
    /// 	then it is reasonable to assume that there are :knownAs that.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#knownAs">con:knownAs</a>
    /// </summary>
    let knownAs = _prefixId.prefix "knownAs"
    let lastName = _prefixId.prefix "lastName"
    let mailbox = _prefixId.prefix "mailbox"
    let mailboxURI = _prefixId.prefix "mailboxURI"
    let middleInitial = _prefixId.prefix "middleInitial"
    let middleName = _prefixId.prefix "middleName"
    /// <summary>
    ///   <para>rdfs:label : mobile^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#mobile">con:mobile</a>
    /// </summary>
    let mobile = _prefixId.prefix "mobile"
    let motherTongue = _prefixId.prefix "motherTongue"
    /// <summary>
    ///   <para>rdfs:label : nearest airport^^xsd:string</para>
    ///   <para>rdfs:comment : ?X nearestAirport ?Y locates ?X in an international
    ///    context; for example, for the purpose of organizing a face-to-face
    ///    meeting of a W3C working group. This property is intended to mitigate
    ///    privacy risks of giving out detailed contact info.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#nearestAirport">con:nearestAirport</a>
    /// </summary>
    let nearestAirport = _prefixId.prefix "nearestAirport"
    /// <summary>
    ///   <para>rdfs:label : work^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#office">con:office</a>
    /// </summary>
    let office = _prefixId.prefix "office"
    let organization = _prefixId.prefix "organization"
    /// <summary>
    ///   <para>rdfs:label : participant^^xsd:string</para>
    ///   <para>rdfs:comment : A person (or other agent) who  particpates in an event, meeting, etc.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#participant">con:participant</a>
    /// </summary>
    let participant = _prefixId.prefix "participant"
    let partner = _prefixId.prefix "partner"
    let personalSuffix = _prefixId.prefix "personalSuffix"
    let personalTitle = _prefixId.prefix "personalTitle"
    let phone = _prefixId.prefix "phone"
    let postalCode = _prefixId.prefix "postalCode"
    /// <summary>
    ///   <para>rdfs:label : preferred^^xsd:string</para>
    ///   <para>rdfs:comment : A string which is the URI a person, organization, etc, prefers that people use for them.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#preferredURI">con:preferredURI</a>
    /// </summary>
    let preferredURI = _prefixId.prefix "preferredURI"
    let publicHomePage = _prefixId.prefix "publicHomePage"
    /// <summary>
    ///   <para>rdfs:label : region^^xsd:string</para>
    ///   <para>rdfs:comment : The sub-national unit such as state (us),
    /// province (ca), county (uk), département (fr), and so on^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#region">con:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    /// <summary>
    ///   <para>rdfs:label : sort name^^xsd:string</para>
    ///   <para>rdfs:comment : re-arranged for lexicographic ordering; ala Doe, John^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#sortName">con:sortName</a>
    /// </summary>
    let sortName = _prefixId.prefix "sortName"
    let stateOrProvince = _prefixId.prefix "stateOrProvince"
    let street = _prefixId.prefix "street"
    let street2 = _prefixId.prefix "street2"
    let street3 = _prefixId.prefix "street3"
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : vacation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#vacationHome">con:vacationHome</a>
    /// </summary>
    let vacationHome = _prefixId.prefix "vacationHome"
    /// <summary>
    ///   <para>rdfs:label : web page^^xsd:string</para>
    ///   <para>rdfs:comment : A related web page^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/contact#webPage">con:webPage</a>
    /// </summary>
    let webPage = _prefixId.prefix "webPage"
    let zip = _prefixId.prefix "zip"
