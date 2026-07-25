namespace http.www.w3.org._2000._10.swap.pim.contact.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module contact =
    let _namespace_iri = Namespace_Iri contact |> NamespaceIRI
    /// <summary>
    ///   <para>contact:Fax</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>fax</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#Fax">http://www.w3.org/2000/10/swap/pim/contact#Fax</seealso>
    let Fax = Prefixed_Name(contact, "Fax") |> PrefixedName
    /// <summary>
    ///   <para>contact:Pager</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#Pager">http://www.w3.org/2000/10/swap/pim/contact#Pager</seealso>
    let Pager = Prefixed_Name(contact, "Pager") |> PrefixedName
    /// <summary>
    ///   <para>contact:_addressProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#_addressProperty">http://www.w3.org/2000/10/swap/pim/contact#_addressProperty</seealso>
    let _addressProperty = Prefixed_Name(contact, "_addressProperty") |> PrefixedName
    /// <summary>
    ///   <para>contact:birthday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#birthday">http://www.w3.org/2000/10/swap/pim/contact#birthday</seealso>
    let birthday = Prefixed_Name(contact, "birthday") |> PrefixedName
    /// <summary>
    ///   <para>contact:city</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#city">http://www.w3.org/2000/10/swap/pim/contact#city</seealso>
    let city = Prefixed_Name(contact, "city") |> PrefixedName
    /// <summary>
    ///   <para>contact:country</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#country">http://www.w3.org/2000/10/swap/pim/contact#country</seealso>
    let country = Prefixed_Name(contact, "country") |> PrefixedName
    /// <summary>
    ///   <para>contact:_example</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#_example">http://www.w3.org/2000/10/swap/pim/contact#_example</seealso>
    let _example = Prefixed_Name(contact, "_example") |> PrefixedName
    /// <summary>
    ///   <para>contact:emergency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>emergency only</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#emergency">http://www.w3.org/2000/10/swap/pim/contact#emergency</seealso>
    let emergency = Prefixed_Name(contact, "emergency") |> PrefixedName
    /// <summary>
    ///   <para>contact:fullName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>full name</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#fullName">http://www.w3.org/2000/10/swap/pim/contact#fullName</seealso>
    let fullName = Prefixed_Name(contact, "fullName") |> PrefixedName
    /// <summary>
    ///   <para>contact:givenName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#givenName">http://www.w3.org/2000/10/swap/pim/contact#givenName</seealso>
    let givenName = Prefixed_Name(contact, "givenName") |> PrefixedName
    /// <summary>
    ///   <para>contact:home</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>home</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#home">http://www.w3.org/2000/10/swap/pim/contact#home</seealso>
    let home = Prefixed_Name(contact, "home") |> PrefixedName
    /// <summary>
    ///   <para>contact:lastName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#lastName">http://www.w3.org/2000/10/swap/pim/contact#lastName</seealso>
    let lastName = Prefixed_Name(contact, "lastName") |> PrefixedName
    /// <summary>
    ///   <para>contact:mailbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#mailbox">http://www.w3.org/2000/10/swap/pim/contact#mailbox</seealso>
    let mailbox = Prefixed_Name(contact, "mailbox") |> PrefixedName
    /// <summary>
    ///   <para>contact:_URI</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#_URI">http://www.w3.org/2000/10/swap/pim/contact#_URI</seealso>
    let _URI = Prefixed_Name(contact, "_URI") |> PrefixedName
    /// <summary>
    ///   <para>contact:ContactLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A place, or mobile situation, with address, phone number, fax, etc.
    ///     Related to a person by home, office, etc.
    ///     Note one person's workplace may be another person's home.
    ///     A person may have more than one home and more than one workplace.
    ///     (In practice it sometimes maybe useful with restriucted datasets to
    ///     assume that this is not the case, when extracting data from other ontologies
    ///     with no concept of ContactLocation).  Strongly related to a person:
    ///     in some ways a role that a person can be in.</para>
    /// labels<para>contact point</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#ContactLocation">http://www.w3.org/2000/10/swap/pim/contact#ContactLocation</seealso>
    let ContactLocation = Prefixed_Name(contact, "ContactLocation") |> PrefixedName
    /// <summary>
    ///   <para>contact:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#Address">http://www.w3.org/2000/10/swap/pim/contact#Address</seealso>
    let Address = Prefixed_Name(contact, "Address") |> PrefixedName
    /// <summary>
    ///   <para>contact:LanguageCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#LanguageCode">http://www.w3.org/2000/10/swap/pim/contact#LanguageCode</seealso>
    let LanguageCode = Prefixed_Name(contact, "LanguageCode") |> PrefixedName
    /// <summary>
    ///   <para>contact:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>A person in the normal sense of the word.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#Person">http://www.w3.org/2000/10/swap/pim/contact#Person</seealso>
    let Person = Prefixed_Name(contact, "Person") |> PrefixedName
    /// <summary>
    ///   <para>contact:assistant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person (or other agent) who is an assistant to the subject.</para>
    /// labels<para>assistant</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#assistant">http://www.w3.org/2000/10/swap/pim/contact#assistant</seealso>
    let assistant = Prefixed_Name(contact, "assistant") |> PrefixedName
    /// <summary>
    ///   <para>contact:Date</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#Date">http://www.w3.org/2000/10/swap/pim/contact#Date</seealso>
    let Date = Prefixed_Name(contact, "Date") |> PrefixedName
    /// <summary>
    ///   <para>contact:departmentName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#departmentName">http://www.w3.org/2000/10/swap/pim/contact#departmentName</seealso>
    let departmentName = Prefixed_Name(contact, "departmentName") |> PrefixedName
    /// <summary>
    ///   <para>contact:_EmailAddress</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#_EmailAddress">http://www.w3.org/2000/10/swap/pim/contact#_EmailAddress</seealso>
    let _EmailAddress = Prefixed_Name(contact, "_EmailAddress") |> PrefixedName
    /// <summary>
    ///   <para>contact:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>address</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#address">http://www.w3.org/2000/10/swap/pim/contact#address</seealso>
    let address = Prefixed_Name(contact, "address") |> PrefixedName
    /// <summary>
    ///   <para>contact:child</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#child">http://www.w3.org/2000/10/swap/pim/contact#child</seealso>
    let child = Prefixed_Name(contact, "child") |> PrefixedName
    /// <summary>
    ///   <para>contact:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#description">http://www.w3.org/2000/10/swap/pim/contact#description</seealso>
    let description = Prefixed_Name(contact, "description") |> PrefixedName
    /// <summary>
    ///   <para>contact:familyName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#familyName">http://www.w3.org/2000/10/swap/pim/contact#familyName</seealso>
    let familyName = Prefixed_Name(contact, "familyName") |> PrefixedName
    /// <summary>
    ///   <para>contact:firstName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#firstName">http://www.w3.org/2000/10/swap/pim/contact#firstName</seealso>
    let firstName = Prefixed_Name(contact, "firstName") |> PrefixedName
    /// <summary>
    ///   <para>contact:homePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#homePage">http://www.w3.org/2000/10/swap/pim/contact#homePage</seealso>
    let homePage = Prefixed_Name(contact, "homePage") |> PrefixedName
    /// <summary>
    ///   <para>contact:homePageAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Use is discouraged</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#homePageAddress">http://www.w3.org/2000/10/swap/pim/contact#homePageAddress</seealso>
    let homePageAddress = Prefixed_Name(contact, "homePageAddress") |> PrefixedName
    /// <summary>
    ///   <para>contact:emailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>emailAddress is a string.  Use of this is discouraged. Use :mailbox instead </para>
    /// labels<para>email</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#emailAddress">http://www.w3.org/2000/10/swap/pim/contact#emailAddress</seealso>
    let emailAddress = Prefixed_Name(contact, "emailAddress") |> PrefixedName
    /// <summary>
    ///   <para>contact:fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#fax">http://www.w3.org/2000/10/swap/pim/contact#fax</seealso>
    let fax = Prefixed_Name(contact, "fax") |> PrefixedName
    /// <summary>
    ///   <para>contact:webPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related web page</para>
    /// labels<para>web page</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#webPage">http://www.w3.org/2000/10/swap/pim/contact#webPage</seealso>
    let webPage = Prefixed_Name(contact, "webPage") |> PrefixedName
    /// <summary>
    ///   <para>contact:Mailbox</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#Mailbox">http://www.w3.org/2000/10/swap/pim/contact#Mailbox</seealso>
    let Mailbox = Prefixed_Name(contact, "Mailbox") |> PrefixedName
    /// <summary>
    ///   <para>contact:middleInitial</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#middleInitial">http://www.w3.org/2000/10/swap/pim/contact#middleInitial</seealso>
    let middleInitial = Prefixed_Name(contact, "middleInitial") |> PrefixedName
    /// <summary>
    ///   <para>contact:nearestAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>?X nearestAirport ?Y locates ?X in an international
    ///    context; for example, for the purpose of organizing a face-to-face
    ///    meeting of a W3C working group. This property is intended to mitigate
    ///    privacy risks of giving out detailed contact info.</para>
    /// labels<para>nearest airport</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#nearestAirport">http://www.w3.org/2000/10/swap/pim/contact#nearestAirport</seealso>
    let nearestAirport = Prefixed_Name(contact, "nearestAirport") |> PrefixedName
    /// <summary>
    ///   <para>contact:knownAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person may be known as various strings.
    /// 	For example, an email friendly name string.
    /// 	If you have an email from someone using a string as the human-readable phrase,
    /// 	then it is reasonable to assume that there are :knownAs that.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#knownAs">http://www.w3.org/2000/10/swap/pim/contact#knownAs</seealso>
    let knownAs = Prefixed_Name(contact, "knownAs") |> PrefixedName
    /// <summary>
    ///   <para>contact:mailboxURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>mailboxURI is a string.  Use of this is discouraged. Use :mailbox instead </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#mailboxURI">http://www.w3.org/2000/10/swap/pim/contact#mailboxURI</seealso>
    let mailboxURI = Prefixed_Name(contact, "mailboxURI") |> PrefixedName
    /// <summary>
    ///   <para>contact:middleName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#middleName">http://www.w3.org/2000/10/swap/pim/contact#middleName</seealso>
    let middleName = Prefixed_Name(contact, "middleName") |> PrefixedName
    /// <summary>
    ///   <para>contact:mobile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>mobile</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#mobile">http://www.w3.org/2000/10/swap/pim/contact#mobile</seealso>
    let mobile = Prefixed_Name(contact, "mobile") |> PrefixedName
    /// <summary>
    ///   <para>contact:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person (or other agent) who  particpates in an event, meeting, etc.</para>
    /// labels<para>participant</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#participant">http://www.w3.org/2000/10/swap/pim/contact#participant</seealso>
    let participant = Prefixed_Name(contact, "participant") |> PrefixedName
    /// <summary>
    ///   <para>contact:personalTitle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#personalTitle">http://www.w3.org/2000/10/swap/pim/contact#personalTitle</seealso>
    let personalTitle = Prefixed_Name(contact, "personalTitle") |> PrefixedName
    /// <summary>
    ///   <para>contact:postalCode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#postalCode">http://www.w3.org/2000/10/swap/pim/contact#postalCode</seealso>
    let postalCode = Prefixed_Name(contact, "postalCode") |> PrefixedName
    /// <summary>
    ///   <para>contact:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The sub-national unit such as state (us),
    /// province (ca), county (uk), département (fr), and so on</para>
    /// labels<para>region</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#region">http://www.w3.org/2000/10/swap/pim/contact#region</seealso>
    let region = Prefixed_Name(contact, "region") |> PrefixedName
    /// <summary>
    ///   <para>contact:street3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#street3">http://www.w3.org/2000/10/swap/pim/contact#street3</seealso>
    let street3 = Prefixed_Name(contact, "street3") |> PrefixedName
    /// <summary>
    ///   <para>contact:motherTongue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#motherTongue">http://www.w3.org/2000/10/swap/pim/contact#motherTongue</seealso>
    let motherTongue = Prefixed_Name(contact, "motherTongue") |> PrefixedName
    /// <summary>
    ///   <para>contact:organization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#organization">http://www.w3.org/2000/10/swap/pim/contact#organization</seealso>
    let organization = Prefixed_Name(contact, "organization") |> PrefixedName
    /// <summary>
    ///   <para>contact:office</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>work</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#office">http://www.w3.org/2000/10/swap/pim/contact#office</seealso>
    let office = Prefixed_Name(contact, "office") |> PrefixedName
    /// <summary>
    ///   <para>contact:personalSuffix</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#personalSuffix">http://www.w3.org/2000/10/swap/pim/contact#personalSuffix</seealso>
    let personalSuffix = Prefixed_Name(contact, "personalSuffix") |> PrefixedName
    /// <summary>
    ///   <para>contact:publicHomePage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#publicHomePage">http://www.w3.org/2000/10/swap/pim/contact#publicHomePage</seealso>
    let publicHomePage = Prefixed_Name(contact, "publicHomePage") |> PrefixedName
    /// <summary>
    ///   <para>contact:street</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#street">http://www.w3.org/2000/10/swap/pim/contact#street</seealso>
    let street = Prefixed_Name(contact, "street") |> PrefixedName
    /// <summary>
    ///   <para>contact:street2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#street2">http://www.w3.org/2000/10/swap/pim/contact#street2</seealso>
    let street2 = Prefixed_Name(contact, "street2") |> PrefixedName
    /// <summary>
    ///   <para>contact:zip</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#zip">http://www.w3.org/2000/10/swap/pim/contact#zip</seealso>
    let zip = Prefixed_Name(contact, "zip") |> PrefixedName
    /// <summary>
    ///   <para>contact:partner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#partner">http://www.w3.org/2000/10/swap/pim/contact#partner</seealso>
    let partner = Prefixed_Name(contact, "partner") |> PrefixedName
    /// <summary>
    ///   <para>contact:preferredURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A string which is the URI a person, organization, etc, prefers that people use for them.</para>
    /// labels<para>preferred</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#preferredURI">http://www.w3.org/2000/10/swap/pim/contact#preferredURI</seealso>
    let preferredURI = Prefixed_Name(contact, "preferredURI") |> PrefixedName
    /// <summary>
    ///   <para>contact:stateOrProvince</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#stateOrProvince">http://www.w3.org/2000/10/swap/pim/contact#stateOrProvince</seealso>
    let stateOrProvince = Prefixed_Name(contact, "stateOrProvince") |> PrefixedName
    /// <summary>
    ///   <para>contact:title</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#title">http://www.w3.org/2000/10/swap/pim/contact#title</seealso>
    let title = Prefixed_Name(contact, "title") |> PrefixedName
    /// <summary>
    ///   <para>contact:phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#phone">http://www.w3.org/2000/10/swap/pim/contact#phone</seealso>
    let phone = Prefixed_Name(contact, "phone") |> PrefixedName
    /// <summary>
    ///   <para>contact:sortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>re-arranged for lexicographic ordering; ala Doe, John</para>
    /// labels<para>sort name</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#sortName">http://www.w3.org/2000/10/swap/pim/contact#sortName</seealso>
    let sortName = Prefixed_Name(contact, "sortName") |> PrefixedName
    /// <summary>
    ///   <para>contact:vacationHome</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>vacation</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#vacationHome">http://www.w3.org/2000/10/swap/pim/contact#vacationHome</seealso>
    let vacationHome = Prefixed_Name(contact, "vacationHome") |> PrefixedName
    /// <summary>
    ///   <para>contact:_SubjectToChange</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>subject to change</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#_SubjectToChange">http://www.w3.org/2000/10/swap/pim/contact#_SubjectToChange</seealso>
    let _SubjectToChange = Prefixed_Name(contact, "_SubjectToChange") |> PrefixedName
    /// <summary>
    ///   <para>contact:Phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>
    ///     An end-point in the public swiitched telephone system.
    ///     Anything identified by a URI with tel: scheme is in this class.
    ///     </para>
    /// labels<para>phone</para><para>tel.</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#Phone">http://www.w3.org/2000/10/swap/pim/contact#Phone</seealso>
    let Phone = Prefixed_Name(contact, "Phone") |> PrefixedName
    /// <summary>
    ///   <para>contact:Female</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#Female">http://www.w3.org/2000/10/swap/pim/contact#Female</seealso>
    let Female = Prefixed_Name(contact, "Female") |> PrefixedName
    /// <summary>
    ///   <para>contact:Male</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#Male">http://www.w3.org/2000/10/swap/pim/contact#Male</seealso>
    let Male = Prefixed_Name(contact, "Male") |> PrefixedName
    /// <summary>
    ///   <para>contact:MobilePhone</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>mobile</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#MobilePhone">http://www.w3.org/2000/10/swap/pim/contact#MobilePhone</seealso>
    let MobilePhone = Prefixed_Name(contact, "MobilePhone") |> PrefixedName
    /// <summary>
    ///   <para>contact:SocialEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The sort of thing which can have a phone number.
    ///     Typically a person or an incorporated company, or unincorporated group.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/contact#SocialEntity">http://www.w3.org/2000/10/swap/pim/contact#SocialEntity</seealso>
    let SocialEntity = Prefixed_Name(contact, "SocialEntity") |> PrefixedName
