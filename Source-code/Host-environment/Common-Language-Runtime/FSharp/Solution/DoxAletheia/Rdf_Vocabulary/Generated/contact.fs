namespace http.www.w3.org._2000._10.swap.pim.contact.hash

open DoxAletheia.Rdf_Vocabulary

module contact =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/contact#"

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#_SubjectToChange"></see>
    /// </summary>
    let _SubjectToChange =
        Namespaced_IRI.parse _namespace_name "_SubjectToChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Address"></see>
    /// </summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName

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
    let ContactLocation =
        Namespaced_IRI.parse _namespace_name "ContactLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Fax"></see>
    /// </summary>
    let Fax = Namespaced_IRI.parse _namespace_name "Fax" |> NamespacedName
    /// <summary>
    ///
    ///     An end-point in the public swiitched telephone system.
    ///     Anything identified by a URI with tel: scheme is in this class.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#Phone"></see></summary>
    let Phone = Namespaced_IRI.parse _namespace_name "Phone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Female"></see>
    /// </summary>
    let Female = Namespaced_IRI.parse _namespace_name "Female" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#LanguageCode"></see>
    /// </summary>
    let LanguageCode =
        Namespaced_IRI.parse _namespace_name "LanguageCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Male"></see>
    /// </summary>
    let Male = Namespaced_IRI.parse _namespace_name "Male" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#MobilePhone"></see>
    /// </summary>
    let MobilePhone =
        Namespaced_IRI.parse _namespace_name "MobilePhone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Pager"></see>
    /// </summary>
    let Pager = Namespaced_IRI.parse _namespace_name "Pager" |> NamespacedName
    /// <summary>
    /// A person in the normal sense of the word.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// The sort of thing which can have a phone number.
    ///     Typically a person or an incorporated company, or unincorporated group.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#SocialEntity"></see></summary>
    let SocialEntity =
        Namespaced_IRI.parse _namespace_name "SocialEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#_addressProperty"></see>
    /// </summary>
    let _addressProperty =
        Namespaced_IRI.parse _namespace_name "_addressProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#address"></see>
    /// </summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName
    /// <summary>
    /// A person (or other agent) who is an assistant to the subject.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#assistant"></see></summary>
    let assistant = Namespaced_IRI.parse _namespace_name "assistant" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#birthday"></see>
    /// </summary>
    let birthday = Namespaced_IRI.parse _namespace_name "birthday" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Date"></see>
    /// </summary>
    let Date = Namespaced_IRI.parse _namespace_name "Date" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#child"></see>
    /// </summary>
    let child = Namespaced_IRI.parse _namespace_name "child" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#city"></see>
    /// </summary>
    let city = Namespaced_IRI.parse _namespace_name "city" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#country"></see>
    /// </summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#departmentName"></see>
    /// </summary>
    let departmentName =
        Namespaced_IRI.parse _namespace_name "departmentName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// emailAddress is a string.  Use of this is discouraged. Use :mailbox instead
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#emailAddress"></see></summary>
    let emailAddress =
        Namespaced_IRI.parse _namespace_name "emailAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#_EmailAddress"></see>
    /// </summary>
    let _EmailAddress =
        Namespaced_IRI.parse _namespace_name "_EmailAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#_example"></see>
    /// </summary>
    let _example = Namespaced_IRI.parse _namespace_name "_example" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#emergency"></see>
    /// </summary>
    let emergency = Namespaced_IRI.parse _namespace_name "emergency" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#familyName"></see>
    /// </summary>
    let familyName = Namespaced_IRI.parse _namespace_name "familyName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#fax"></see>
    /// </summary>
    let fax = Namespaced_IRI.parse _namespace_name "fax" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#firstName"></see>
    /// </summary>
    let firstName = Namespaced_IRI.parse _namespace_name "firstName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#fullName"></see>
    /// </summary>
    let fullName = Namespaced_IRI.parse _namespace_name "fullName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#givenName"></see>
    /// </summary>
    let givenName = Namespaced_IRI.parse _namespace_name "givenName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#home"></see>
    /// </summary>
    let home = Namespaced_IRI.parse _namespace_name "home" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#homePage"></see>
    /// </summary>
    let homePage = Namespaced_IRI.parse _namespace_name "homePage" |> NamespacedName
    /// <summary>
    /// A related web page
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#webPage"></see></summary>
    let webPage = Namespaced_IRI.parse _namespace_name "webPage" |> NamespacedName

    /// <summary>
    /// Use is discouraged
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#homePageAddress"></see></summary>
    let homePageAddress =
        Namespaced_IRI.parse _namespace_name "homePageAddress" |> NamespacedName

    /// <summary>
    /// A person may be known as various strings.
    /// 	For example, an email friendly name string.
    /// 	If you have an email from someone using a string as the human-readable phrase,
    /// 	then it is reasonable to assume that there are :knownAs that.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#knownAs"></see></summary>
    let knownAs = Namespaced_IRI.parse _namespace_name "knownAs" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#lastName"></see>
    /// </summary>
    let lastName = Namespaced_IRI.parse _namespace_name "lastName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#mailbox"></see>
    /// </summary>
    let mailbox = Namespaced_IRI.parse _namespace_name "mailbox" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#Mailbox"></see>
    /// </summary>
    let Mailbox = Namespaced_IRI.parse _namespace_name "Mailbox" |> NamespacedName
    /// <summary>
    /// mailboxURI is a string.  Use of this is discouraged. Use :mailbox instead
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#mailboxURI"></see></summary>
    let mailboxURI = Namespaced_IRI.parse _namespace_name "mailboxURI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#_URI"></see>
    /// </summary>
    let _URI = Namespaced_IRI.parse _namespace_name "_URI" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#middleInitial"></see>
    /// </summary>
    let middleInitial =
        Namespaced_IRI.parse _namespace_name "middleInitial" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#middleName"></see>
    /// </summary>
    let middleName = Namespaced_IRI.parse _namespace_name "middleName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#mobile"></see>
    /// </summary>
    let mobile = Namespaced_IRI.parse _namespace_name "mobile" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#motherTongue"></see>
    /// </summary>
    let motherTongue =
        Namespaced_IRI.parse _namespace_name "motherTongue" |> NamespacedName

    /// <summary>
    /// ?X nearestAirport ?Y locates ?X in an international
    ///    context; for example, for the purpose of organizing a face-to-face
    ///    meeting of a W3C working group. This property is intended to mitigate
    ///    privacy risks of giving out detailed contact info.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#nearestAirport"></see></summary>
    let nearestAirport =
        Namespaced_IRI.parse _namespace_name "nearestAirport" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#office"></see>
    /// </summary>
    let office = Namespaced_IRI.parse _namespace_name "office" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#organization"></see>
    /// </summary>
    let organization =
        Namespaced_IRI.parse _namespace_name "organization" |> NamespacedName

    /// <summary>
    /// A person (or other agent) who  particpates in an event, meeting, etc.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#participant"></see></summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#partner"></see>
    /// </summary>
    let partner = Namespaced_IRI.parse _namespace_name "partner" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#personalSuffix"></see>
    /// </summary>
    let personalSuffix =
        Namespaced_IRI.parse _namespace_name "personalSuffix" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#personalTitle"></see>
    /// </summary>
    let personalTitle =
        Namespaced_IRI.parse _namespace_name "personalTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#phone"></see>
    /// </summary>
    let phone = Namespaced_IRI.parse _namespace_name "phone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#postalCode"></see>
    /// </summary>
    let postalCode = Namespaced_IRI.parse _namespace_name "postalCode" |> NamespacedName

    /// <summary>
    /// A string which is the URI a person, organization, etc, prefers that people use for them.
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#preferredURI"></see></summary>
    let preferredURI =
        Namespaced_IRI.parse _namespace_name "preferredURI" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#publicHomePage"></see>
    /// </summary>
    let publicHomePage =
        Namespaced_IRI.parse _namespace_name "publicHomePage" |> NamespacedName

    /// <summary>
    /// The sub-national unit such as state (us),
    /// province (ca), county (uk), département (fr), and so on
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName
    /// <summary>
    /// re-arranged for lexicographic ordering; ala Doe, John
    /// <see href="http://www.w3.org/2000/10/swap/pim/contact#sortName"></see></summary>
    let sortName = Namespaced_IRI.parse _namespace_name "sortName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#stateOrProvince"></see>
    /// </summary>
    let stateOrProvince =
        Namespaced_IRI.parse _namespace_name "stateOrProvince" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#street"></see>
    /// </summary>
    let street = Namespaced_IRI.parse _namespace_name "street" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#street2"></see>
    /// </summary>
    let street2 = Namespaced_IRI.parse _namespace_name "street2" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#street3"></see>
    /// </summary>
    let street3 = Namespaced_IRI.parse _namespace_name "street3" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#vacationHome"></see>
    /// </summary>
    let vacationHome =
        Namespaced_IRI.parse _namespace_name "vacationHome" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/contact#zip"></see>
    /// </summary>
    let zip = Namespaced_IRI.parse _namespace_name "zip" |> NamespacedName
