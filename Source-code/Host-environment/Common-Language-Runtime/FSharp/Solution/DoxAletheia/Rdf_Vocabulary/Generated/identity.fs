namespace http.www.identity.org.ontologies.identity.owl.hash

open DoxAletheia.Rdf_Vocabulary

module identity =
    let _namespace_name = "http://www.identity.org/ontologies/identity.owl#"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#DateYmd"></see>
    /// </summary>
    let DateYmd = Namespaced_IRI.parse _namespace_name "DateYmd" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ymdDay"></see>
    /// </summary>
    let ymdDay = Namespaced_IRI.parse _namespace_name "ymdDay" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#FaceRecognition"></see>
    /// </summary>
    let FaceRecognition =
        Namespaced_IRI.parse _namespace_name "FaceRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#FingerprintRecognition"></see>
    /// </summary>
    let FingerprintRecognition =
        Namespaced_IRI.parse _namespace_name "FingerprintRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#IrisRecognition"></see>
    /// </summary>
    let IrisRecognition =
        Namespaced_IRI.parse _namespace_name "IrisRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#KeystokeDynamicRecognition"></see>
    /// </summary>
    let KeystokeDynamicRecognition =
        Namespaced_IRI.parse _namespace_name "KeystokeDynamicRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#VoiceRecognition"></see>
    /// </summary>
    let VoiceRecognition =
        Namespaced_IRI.parse _namespace_name "VoiceRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ymdMonth"></see>
    /// </summary>
    let ymdMonth = Namespaced_IRI.parse _namespace_name "ymdMonth" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#DateHms"></see>
    /// </summary>
    let DateHms = Namespaced_IRI.parse _namespace_name "DateHms" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hmsSecond"></see>
    /// </summary>
    let hmsSecond = Namespaced_IRI.parse _namespace_name "hmsSecond" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ymdMonthYear"></see>
    /// </summary>
    let ymdMonthYear =
        Namespaced_IRI.parse _namespace_name "ymdMonthYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ymdYearMonth"></see>
    /// </summary>
    let ymdYearMonth =
        Namespaced_IRI.parse _namespace_name "ymdYearMonth" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hmsHour"></see>
    /// </summary>
    let hmsHour = Namespaced_IRI.parse _namespace_name "hmsHour" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hmsMinute"></see>
    /// </summary>
    let hmsMinute = Namespaced_IRI.parse _namespace_name "hmsMinute" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ymdYear"></see>
    /// </summary>
    let ymdYear = Namespaced_IRI.parse _namespace_name "ymdYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#AlarmClockProvider"></see>
    /// </summary>
    let AlarmClockProvider =
        Namespaced_IRI.parse _namespace_name "AlarmClockProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#BrowserProvider"></see>
    /// </summary>
    let BrowserProvider =
        Namespaced_IRI.parse _namespace_name "BrowserProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#CallLogProvider"></see>
    /// </summary>
    let CallLogProvider =
        Namespaced_IRI.parse _namespace_name "CallLogProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ContactsContractProvider"></see>
    /// </summary>
    let ContactsContractProvider =
        Namespaced_IRI.parse _namespace_name "ContactsContractProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#LiveFoldersProvider"></see>
    /// </summary>
    let LiveFoldersProvider =
        Namespaced_IRI.parse _namespace_name "LiveFoldersProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#MediaStoreProvider"></see>
    /// </summary>
    let MediaStoreProvider =
        Namespaced_IRI.parse _namespace_name "MediaStoreProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#SearchRecentSuggestionsProvider"></see>
    /// </summary>
    let SearchRecentSuggestionsProvider =
        Namespaced_IRI.parse _namespace_name "SearchRecentSuggestionsProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#SettingsProvider"></see>
    /// </summary>
    let SettingsProvider =
        Namespaced_IRI.parse _namespace_name "SettingsProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#SyncStateContractProvider"></see>
    /// </summary>
    let SyncStateContractProvider =
        Namespaced_IRI.parse _namespace_name "SyncStateContractProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#UserDictionaryProvider"></see>
    /// </summary>
    let UserDictionaryProvider =
        Namespaced_IRI.parse _namespace_name "UserDictionaryProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Agent"></see>
    /// </summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// Identity information of a legal or natural entity.
    /// <see href="http://www.identity.org/ontologies/identity.owl#IdentityInformation"></see></summary>
    let IdentityInformation =
        Namespaced_IRI.parse _namespace_name "IdentityInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasIdentity"></see>
    /// </summary>
    let hasIdentity =
        Namespaced_IRI.parse _namespace_name "hasIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Data"></see>
    /// </summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasData"></see>
    /// </summary>
    let hasData = Namespaced_IRI.parse _namespace_name "hasData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ContentProvider"></see>
    /// </summary>
    let ContentProvider =
        Namespaced_IRI.parse _namespace_name "ContentProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#BiometricData"></see>
    /// </summary>
    let BiometricData =
        Namespaced_IRI.parse _namespace_name "BiometricData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#bimetricFile"></see>
    /// </summary>
    let bimetricFile =
        Namespaced_IRI.parse _namespace_name "bimetricFile" |> NamespacedName

    /// <summary>
    /// A business is a legal entity which is permitted to enter into a contract with another entity.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Business"></see></summary>
    let Business = Namespaced_IRI.parse _namespace_name "Business" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#BusinessInformation"></see>
    /// </summary>
    let BusinessInformation =
        Namespaced_IRI.parse _namespace_name "BusinessInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#businessName"></see>
    /// </summary>
    let businessName =
        Namespaced_IRI.parse _namespace_name "businessName" |> NamespacedName

    /// <summary>
    /// Required information to contact an agent.
    /// <see href="http://www.identity.org/ontologies/identity.owl#ContactInformation"></see></summary>
    let ContactInformation =
        Namespaced_IRI.parse _namespace_name "ContactInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasContactInfo"></see>
    /// </summary>
    let hasContactInfo =
        Namespaced_IRI.parse _namespace_name "hasContactInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#logo"></see>
    /// </summary>
    let logo = Namespaced_IRI.parse _namespace_name "logo" |> NamespacedName

    /// <summary>
    /// Department or Division of Organization and eventually where user is employed.
    /// <see href="http://www.identity.org/ontologies/identity.owl#businessUnit"></see></summary>
    let businessUnit =
        Namespaced_IRI.parse _namespace_name "businessUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#CellPhoneData"></see>
    /// </summary>
    let CellPhoneData =
        Namespaced_IRI.parse _namespace_name "CellPhoneData" |> NamespacedName

    /// <summary>
    /// International Mobile Equipment Identity.
    /// <see href="http://www.identity.org/ontologies/identity.owl#imei"></see></summary>
    let imei = Namespaced_IRI.parse _namespace_name "imei" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#cellID"></see>
    /// </summary>
    let cellID = Namespaced_IRI.parse _namespace_name "cellID" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#languageCode"></see>
    /// </summary>
    let languageCode =
        Namespaced_IRI.parse _namespace_name "languageCode" |> NamespacedName

    /// <summary>
    /// This structure is used to specify identity certificates.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Certificate"></see></summary>
    let Certificate =
        Namespaced_IRI.parse _namespace_name "Certificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#key"></see>
    /// </summary>
    let key = Namespaced_IRI.parse _namespace_name "key" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#format"></see>
    /// </summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName
    /// <summary>
    /// The date structure specifies a date. Date information can be used in different ways, depending on the context.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Date"></see></summary>
    let Date = Namespaced_IRI.parse _namespace_name "Date" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasExpirationDate"></see>
    /// </summary>
    let hasExpirationDate =
        Namespaced_IRI.parse _namespace_name "hasExpirationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ChatAccount"></see>
    /// </summary>
    let ChatAccount =
        Namespaced_IRI.parse _namespace_name "ChatAccount" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#OnlineAccount"></see>
    /// </summary>
    let OnlineAccount =
        Namespaced_IRI.parse _namespace_name "OnlineAccount" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Condition"></see>
    /// </summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Context"></see>
    /// </summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#timeZone"></see>
    /// </summary>
    let timeZone = Namespaced_IRI.parse _namespace_name "timeZone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#fractionSecond"></see>
    /// </summary>
    let fractionSecond =
        Namespaced_IRI.parse _namespace_name "fractionSecond" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hmsDate"></see>
    /// </summary>
    let hmsDate = Namespaced_IRI.parse _namespace_name "hmsDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#dateYmd"></see>
    /// </summary>
    let dateYmd = Namespaced_IRI.parse _namespace_name "dateYmd" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#EcommerceAccount"></see>
    /// </summary>
    let EcommerceAccount =
        Namespaced_IRI.parse _namespace_name "EcommerceAccount" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#EncryptAlgo"></see>
    /// </summary>
    let EncryptAlgo =
        Namespaced_IRI.parse _namespace_name "EncryptAlgo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#algo"></see>
    /// </summary>
    let algo = Namespaced_IRI.parse _namespace_name "algo" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Fax"></see>
    /// </summary>
    let Fax = Namespaced_IRI.parse _namespace_name "Fax" |> NamespacedName

    /// <summary>
    /// Telecommunication information about an agnet.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Telecommunication"></see></summary>
    let Telecommunication =
        Namespaced_IRI.parse _namespace_name "Telecommunication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ForbiddenAction"></see>
    /// </summary>
    let ForbiddenAction =
        Namespaced_IRI.parse _namespace_name "ForbiddenAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#GamingAccount"></see>
    /// </summary>
    let GamingAccount =
        Namespaced_IRI.parse _namespace_name "GamingAccount" |> NamespacedName

    /// <summary>
    /// A group of persons that figure in the contact list of an individual.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// A person is an individual who has a social identity and a technical one.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasMember"></see>
    /// </summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// Indivuals or natural entities.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Individual"></see></summary>
    let Individual = Namespaced_IRI.parse _namespace_name "Individual" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#History"></see>
    /// </summary>
    let History = Namespaced_IRI.parse _namespace_name "History" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasCertificate"></see>
    /// </summary>
    let hasCertificate =
        Namespaced_IRI.parse _namespace_name "hasCertificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#IndividualInformation"></see>
    /// </summary>
    let IndividualInformation =
        Namespaced_IRI.parse _namespace_name "IndividualInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#jobTitle"></see>
    /// </summary>
    let jobTitle = Namespaced_IRI.parse _namespace_name "jobTitle" |> NamespacedName
    /// <summary>
    /// The person name specifies information about the naming of a person.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#gender"></see>
    /// </summary>
    let gender = Namespaced_IRI.parse _namespace_name "gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasHomeInfo"></see>
    /// </summary>
    let hasHomeInfo =
        Namespaced_IRI.parse _namespace_name "hasHomeInfo" |> NamespacedName

    /// <summary>
    /// IDs ans Passwords for web services which require authentification.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Login"></see></summary>
    let Login = Namespaced_IRI.parse _namespace_name "Login" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasLogin"></see>
    /// </summary>
    let hasLogin = Namespaced_IRI.parse _namespace_name "hasLogin" |> NamespacedName

    /// <summary>
    /// User's Birthday
    /// <see href="http://www.identity.org/ontologies/identity.owl#hasBirthDate"></see></summary>
    let hasBirthDate =
        Namespaced_IRI.parse _namespace_name "hasBirthDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#employer"></see>
    /// </summary>
    let employer = Namespaced_IRI.parse _namespace_name "employer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#InvalidCertificate"></see>
    /// </summary>
    let InvalidCertificate =
        Namespaced_IRI.parse _namespace_name "InvalidCertificate" |> NamespacedName

    /// <summary>
    /// This legal entity is the issuer of an individual digital identity.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Issuer"></see></summary>
    let Issuer = Namespaced_IRI.parse _namespace_name "Issuer" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#isIssuerOf"></see>
    /// </summary>
    let isIssuerOf = Namespaced_IRI.parse _namespace_name "isIssuerOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#LocationData"></see>
    /// </summary>
    let LocationData =
        Namespaced_IRI.parse _namespace_name "LocationData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#wifi"></see>
    /// </summary>
    let wifi = Namespaced_IRI.parse _namespace_name "wifi" |> NamespacedName
    /// <summary>
    /// Global Positioning System
    /// <see href="http://www.identity.org/ontologies/identity.owl#gps"></see></summary>
    let gps = Namespaced_IRI.parse _namespace_name "gps" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ip"></see>
    /// </summary>
    let ip = Namespaced_IRI.parse _namespace_name "ip" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#latitude"></see>
    /// </summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#longitude"></see>
    /// </summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#LogData"></see>
    /// </summary>
    let LogData = Namespaced_IRI.parse _namespace_name "LogData" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#timestamp"></see>
    /// </summary>
    let timestamp = Namespaced_IRI.parse _namespace_name "timestamp" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#uri"></see>
    /// </summary>
    let uri = Namespaced_IRI.parse _namespace_name "uri" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#callLog"></see>
    /// </summary>
    let callLog = Namespaced_IRI.parse _namespace_name "callLog" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#password"></see>
    /// </summary>
    let password = Namespaced_IRI.parse _namespace_name "password" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#MiscData"></see>
    /// </summary>
    let MiscData = Namespaced_IRI.parse _namespace_name "MiscData" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#cookie"></see>
    /// </summary>
    let cookie = Namespaced_IRI.parse _namespace_name "cookie" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#photo"></see>
    /// </summary>
    let photo = Namespaced_IRI.parse _namespace_name "photo" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#video"></see>
    /// </summary>
    let video = Namespaced_IRI.parse _namespace_name "video" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#document"></see>
    /// </summary>
    let document = Namespaced_IRI.parse _namespace_name "document" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Mobile"></see>
    /// </summary>
    let Mobile = Namespaced_IRI.parse _namespace_name "Mobile" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Mode"></see>
    /// </summary>
    let Mode = Namespaced_IRI.parse _namespace_name "Mode" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#nickName"></see>
    /// </summary>
    let nickName = Namespaced_IRI.parse _namespace_name "nickName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#familyName"></see>
    /// </summary>
    let familyName = Namespaced_IRI.parse _namespace_name "familyName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#givenName"></see>
    /// </summary>
    let givenName = Namespaced_IRI.parse _namespace_name "givenName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#middleName"></see>
    /// </summary>
    let middleName = Namespaced_IRI.parse _namespace_name "middleName" |> NamespacedName
    /// <summary>
    /// Online information about an agent.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Online"></see></summary>
    let Online = Namespaced_IRI.parse _namespace_name "Online" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#email"></see>
    /// </summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Pager"></see>
    /// </summary>
    let Pager = Namespaced_IRI.parse _namespace_name "Pager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#PermittedAction"></see>
    /// </summary>
    let PermittedAction =
        Namespaced_IRI.parse _namespace_name "PermittedAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#knows"></see>
    /// </summary>
    let knows = Namespaced_IRI.parse _namespace_name "knows" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Policy"></see>
    /// </summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName
    /// <summary>
    /// Postal mailing address.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Postal"></see></summary>
    let Postal = Namespaced_IRI.parse _namespace_name "Postal" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#number"></see>
    /// </summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#postalCode"></see>
    /// </summary>
    let postalCode = Namespaced_IRI.parse _namespace_name "postalCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#city"></see>
    /// </summary>
    let city = Namespaced_IRI.parse _namespace_name "city" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#country"></see>
    /// </summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#region"></see>
    /// </summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#departmentName"></see>
    /// </summary>
    let departmentName =
        Namespaced_IRI.parse _namespace_name "departmentName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#street"></see>
    /// </summary>
    let street = Namespaced_IRI.parse _namespace_name "street" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#departmentCode"></see>
    /// </summary>
    let departmentCode =
        Namespaced_IRI.parse _namespace_name "departmentCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#SecretData"></see>
    /// </summary>
    let SecretData = Namespaced_IRI.parse _namespace_name "SecretData" |> NamespacedName
    /// <summary>
    /// A secret code to identify the identity holder.
    /// <see href="http://www.identity.org/ontologies/identity.owl#pin"></see></summary>
    let pin = Namespaced_IRI.parse _namespace_name "pin" |> NamespacedName

    /// <summary>
    /// Provider of mobile phone services.
    /// <see href="http://www.identity.org/ontologies/identity.owl#ServiceProvider"></see></summary>
    let ServiceProvider =
        Namespaced_IRI.parse _namespace_name "ServiceProvider" |> NamespacedName

    /// <summary>
    /// The characteristics of a telephone number.
    /// <see href="http://www.identity.org/ontologies/identity.owl#TelephoneNumber"></see></summary>
    let TelephoneNumber =
        Namespaced_IRI.parse _namespace_name "TelephoneNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasTelephoneNumber"></see>
    /// </summary>
    let hasTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "hasTelephoneNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Telephone"></see>
    /// </summary>
    let Telephone = Namespaced_IRI.parse _namespace_name "Telephone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#phoneNumber"></see>
    /// </summary>
    let phoneNumber =
        Namespaced_IRI.parse _namespace_name "phoneNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#phoneExtension"></see>
    /// </summary>
    let phoneExtension =
        Namespaced_IRI.parse _namespace_name "phoneExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#localCode"></see>
    /// </summary>
    let localCode = Namespaced_IRI.parse _namespace_name "localCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#intCode"></see>
    /// </summary>
    let intCode = Namespaced_IRI.parse _namespace_name "intCode" |> NamespacedName
    /// <summary>
    /// L'identifiant unique d'une entité qui possède une identité (agent).
    /// <see href="http://www.identity.org/ontologies/identity.owl#UID"></see></summary>
    let UID = Namespaced_IRI.parse _namespace_name "UID" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#uid"></see>
    /// </summary>
    let uid = Namespaced_IRI.parse _namespace_name "uid" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ValidCertificate"></see>
    /// </summary>
    let ValidCertificate =
        Namespaced_IRI.parse _namespace_name "ValidCertificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#age"></see>
    /// </summary>
    let age = Namespaced_IRI.parse _namespace_name "age" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#data"></see>
    /// </summary>
    let data = Namespaced_IRI.parse _namespace_name "data" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#postalAddress"></see>
    /// </summary>
    let postalAddress =
        Namespaced_IRI.parse _namespace_name "postalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#conservative"></see>
    /// </summary>
    let conservative =
        Namespaced_IRI.parse _namespace_name "conservative" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#controls"></see>
    /// </summary>
    let controls = Namespaced_IRI.parse _namespace_name "controls" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#createdOn"></see>
    /// </summary>
    let createdOn = Namespaced_IRI.parse _namespace_name "createdOn" |> NamespacedName
    /// <summary>
    /// Time date information is described in the time standard ISO8601.
    /// <see href="http://www.identity.org/ontologies/identity.owl#timeDate"></see></summary>
    let timeDate = Namespaced_IRI.parse _namespace_name "timeDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#extendedAddress"></see>
    /// </summary>
    let extendedAddress =
        Namespaced_IRI.parse _namespace_name "extendedAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#indivName"></see>
    /// </summary>
    let indivName = Namespaced_IRI.parse _namespace_name "indivName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#forbids"></see>
    /// </summary>
    let forbids = Namespaced_IRI.parse _namespace_name "forbids" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasAction"></see>
    /// </summary>
    let hasAction = Namespaced_IRI.parse _namespace_name "hasAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasActionDate"></see>
    /// </summary>
    let hasActionDate =
        Namespaced_IRI.parse _namespace_name "hasActionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasActor"></see>
    /// </summary>
    let hasActor = Namespaced_IRI.parse _namespace_name "hasActor" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasDate"></see>
    /// </summary>
    let hasDate = Namespaced_IRI.parse _namespace_name "hasDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasContext"></see>
    /// </summary>
    let hasContext = Namespaced_IRI.parse _namespace_name "hasContext" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasCreator"></see>
    /// </summary>
    let hasCreator = Namespaced_IRI.parse _namespace_name "hasCreator" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasDefaultPolicyMode"></see>
    /// </summary>
    let hasDefaultPolicyMode =
        Namespaced_IRI.parse _namespace_name "hasDefaultPolicyMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasHistoricTarget"></see>
    /// </summary>
    let hasHistoricTarget =
        Namespaced_IRI.parse _namespace_name "hasHistoricTarget" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasLocation"></see>
    /// </summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasTarget"></see>
    /// </summary>
    let hasTarget = Namespaced_IRI.parse _namespace_name "hasTarget" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasWorkInfo"></see>
    /// </summary>
    let hasWorkInfo =
        Namespaced_IRI.parse _namespace_name "hasWorkInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#telephoneNum"></see>
    /// </summary>
    let telephoneNum =
        Namespaced_IRI.parse _namespace_name "telephoneNum" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#liberal"></see>
    /// </summary>
    let liberal = Namespaced_IRI.parse _namespace_name "liberal" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#metaPolicy"></see>
    /// </summary>
    let metaPolicy = Namespaced_IRI.parse _namespace_name "metaPolicy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#permits"></see>
    /// </summary>
    let permits = Namespaced_IRI.parse _namespace_name "permits" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#postOfficeBox"></see>
    /// </summary>
    let postOfficeBox =
        Namespaced_IRI.parse _namespace_name "postOfficeBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#requires"></see>
    /// </summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName
