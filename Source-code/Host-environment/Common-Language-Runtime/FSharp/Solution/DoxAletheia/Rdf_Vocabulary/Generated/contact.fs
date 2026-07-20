namespace http.www.w3.org._2000._10.swap.pim.contact.hash

open DoxAletheia

module contact =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/contact#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#_SubjectToChange"></see>
    /// </summary>
    let _SubjectToChange = _prefix "_SubjectToChange"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Address"></see>
    /// </summary>
    let Address = _prefix "Address"
    /// <summary>
    /// A place, or mobile situation, with address, phone number, fax, etc.
    ///     Related to a person by home, office, etc.
    ///     Note one person's workplace may be another person's home.
    ///     A person may have more than one home and more than one workplace.
    ///     (In practice it sometimes maybe useful with restriucted datasets to
    ///     assume that this is not the case, when extracting data from other ontologies
    ///     with no concept of ContactLocation).  Strongly related to a person:
    ///     in some ways a role that a person can be in.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#ContactLocation"></see></summary>
    let ContactLocation = _prefix "ContactLocation"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Fax"></see>
    /// </summary>
    let Fax = _prefix "Fax"
    /// <summary>
    ///
    ///     An end-point in the public swiitched telephone system.
    ///     Anything identified by a URI with tel: scheme is in this class.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#Phone"></see></summary>
    let Phone = _prefix "Phone"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Female"></see>
    /// </summary>
    let Female = _prefix "Female"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#LanguageCode"></see>
    /// </summary>
    let LanguageCode = _prefix "LanguageCode"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Male"></see>
    /// </summary>
    let Male = _prefix "Male"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#MobilePhone"></see>
    /// </summary>
    let MobilePhone = _prefix "MobilePhone"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Pager"></see>
    /// </summary>
    let Pager = _prefix "Pager"
    /// <summary>
    /// A person in the normal sense of the word.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// The sort of thing which can have a phone number.
    ///     Typically a person or an incorporated company, or unincorporated group.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#SocialEntity"></see></summary>
    let SocialEntity = _prefix "SocialEntity"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#_addressProperty"></see>
    /// </summary>
    let _addressProperty = _prefix "_addressProperty"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#address"></see>
    /// </summary>
    let address = _prefix "address"
    /// <summary>
    /// A person (or other agent) who is an assistant to the subject.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#assistant"></see></summary>
    let assistant = _prefix "assistant"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#birthday"></see>
    /// </summary>
    let birthday = _prefix "birthday"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Date"></see>
    /// </summary>
    let Date = _prefix "Date"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#child"></see>
    /// </summary>
    let child = _prefix "child"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#city"></see>
    /// </summary>
    let city = _prefix "city"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#country"></see>
    /// </summary>
    let country = _prefix "country"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#departmentName"></see>
    /// </summary>
    let departmentName = _prefix "departmentName"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    /// emailAddress is a string.  Use of this is discouraged. Use :mailbox instead
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#emailAddress"></see></summary>
    let emailAddress = _prefix "emailAddress"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#_EmailAddress"></see>
    /// </summary>
    let _EmailAddress = _prefix "_EmailAddress"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#_example"></see>
    /// </summary>
    let _example = _prefix "_example"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#emergency"></see>
    /// </summary>
    let emergency = _prefix "emergency"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#familyName"></see>
    /// </summary>
    let familyName = _prefix "familyName"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#fax"></see>
    /// </summary>
    let fax = _prefix "fax"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#firstName"></see>
    /// </summary>
    let firstName = _prefix "firstName"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#fullName"></see>
    /// </summary>
    let fullName = _prefix "fullName"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#givenName"></see>
    /// </summary>
    let givenName = _prefix "givenName"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#home"></see>
    /// </summary>
    let home = _prefix "home"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#homePage"></see>
    /// </summary>
    let homePage = _prefix "homePage"
    /// <summary>
    /// A related web page
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#webPage"></see></summary>
    let webPage = _prefix "webPage"
    /// <summary>
    /// Use is discouraged
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#homePageAddress"></see></summary>
    let homePageAddress = _prefix "homePageAddress"
    /// <summary>
    /// A person may be known as various strings.
    /// 	For example, an email friendly name string.
    /// 	If you have an email from someone using a string as the human-readable phrase,
    /// 	then it is reasonable to assume that there are :knownAs that.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#knownAs"></see></summary>
    let knownAs = _prefix "knownAs"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#lastName"></see>
    /// </summary>
    let lastName = _prefix "lastName"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#mailbox"></see>
    /// </summary>
    let mailbox = _prefix "mailbox"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Mailbox"></see>
    /// </summary>
    let Mailbox = _prefix "Mailbox"
    /// <summary>
    /// mailboxURI is a string.  Use of this is discouraged. Use :mailbox instead
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#mailboxURI"></see></summary>
    let mailboxURI = _prefix "mailboxURI"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#_URI"></see>
    /// </summary>
    let _URI = _prefix "_URI"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#middleInitial"></see>
    /// </summary>
    let middleInitial = _prefix "middleInitial"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#middleName"></see>
    /// </summary>
    let middleName = _prefix "middleName"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#mobile"></see>
    /// </summary>
    let mobile = _prefix "mobile"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#motherTongue"></see>
    /// </summary>
    let motherTongue = _prefix "motherTongue"
    /// <summary>
    /// ?X nearestAirport ?Y locates ?X in an international
    ///    context; for example, for the purpose of organizing a face-to-face
    ///    meeting of a W3C working group. This property is intended to mitigate
    ///    privacy risks of giving out detailed contact info.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#nearestAirport"></see></summary>
    let nearestAirport = _prefix "nearestAirport"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#office"></see>
    /// </summary>
    let office = _prefix "office"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#organization"></see>
    /// </summary>
    let organization = _prefix "organization"
    /// <summary>
    /// A person (or other agent) who  particpates in an event, meeting, etc.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#participant"></see></summary>
    let participant = _prefix "participant"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#partner"></see>
    /// </summary>
    let partner = _prefix "partner"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#personalSuffix"></see>
    /// </summary>
    let personalSuffix = _prefix "personalSuffix"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#personalTitle"></see>
    /// </summary>
    let personalTitle = _prefix "personalTitle"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#phone"></see>
    /// </summary>
    let phone = _prefix "phone"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#postalCode"></see>
    /// </summary>
    let postalCode = _prefix "postalCode"
    /// <summary>
    /// A string which is the URI a person, organization, etc, prefers that people use for them.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#preferredURI"></see></summary>
    let preferredURI = _prefix "preferredURI"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#publicHomePage"></see>
    /// </summary>
    let publicHomePage = _prefix "publicHomePage"
    /// <summary>
    /// The sub-national unit such as state (us),
    /// province (ca), county (uk), département (fr), and so on
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#region"></see></summary>
    let region = _prefix "region"
    /// <summary>
    /// re-arranged for lexicographic ordering; ala Doe, John
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#sortName"></see></summary>
    let sortName = _prefix "sortName"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#stateOrProvince"></see>
    /// </summary>
    let stateOrProvince = _prefix "stateOrProvince"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#street"></see>
    /// </summary>
    let street = _prefix "street"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#street2"></see>
    /// </summary>
    let street2 = _prefix "street2"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#street3"></see>
    /// </summary>
    let street3 = _prefix "street3"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#vacationHome"></see>
    /// </summary>
    let vacationHome = _prefix "vacationHome"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#zip"></see>
    /// </summary>
    let zip = _prefix "zip"
