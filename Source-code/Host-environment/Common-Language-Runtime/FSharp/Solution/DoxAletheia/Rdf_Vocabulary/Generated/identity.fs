namespace http.www.identity.org.ontologies.identity.owl.hash

open DoxAletheia

module identity =
    let _namespace_name = "http://www.identity.org/ontologies/identity.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#DateYmd"></see>
    /// </summary>
    let DateYmd = _prefix "DateYmd"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ymdDay"></see>
    /// </summary>
    let ymdDay = _prefix "ymdDay"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#FaceRecognition"></see>
    /// </summary>
    let FaceRecognition = _prefix "FaceRecognition"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#FingerprintRecognition"></see>
    /// </summary>
    let FingerprintRecognition = _prefix "FingerprintRecognition"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#IrisRecognition"></see>
    /// </summary>
    let IrisRecognition = _prefix "IrisRecognition"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#KeystokeDynamicRecognition"></see>
    /// </summary>
    let KeystokeDynamicRecognition = _prefix "KeystokeDynamicRecognition"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#VoiceRecognition"></see>
    /// </summary>
    let VoiceRecognition = _prefix "VoiceRecognition"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ymdMonth"></see>
    /// </summary>
    let ymdMonth = _prefix "ymdMonth"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#DateHms"></see>
    /// </summary>
    let DateHms = _prefix "DateHms"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hmsSecond"></see>
    /// </summary>
    let hmsSecond = _prefix "hmsSecond"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ymdMonthYear"></see>
    /// </summary>
    let ymdMonthYear = _prefix "ymdMonthYear"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ymdYearMonth"></see>
    /// </summary>
    let ymdYearMonth = _prefix "ymdYearMonth"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hmsHour"></see>
    /// </summary>
    let hmsHour = _prefix "hmsHour"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hmsMinute"></see>
    /// </summary>
    let hmsMinute = _prefix "hmsMinute"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ymdYear"></see>
    /// </summary>
    let ymdYear = _prefix "ymdYear"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#AlarmClockProvider"></see>
    /// </summary>
    let AlarmClockProvider = _prefix "AlarmClockProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#BrowserProvider"></see>
    /// </summary>
    let BrowserProvider = _prefix "BrowserProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#CallLogProvider"></see>
    /// </summary>
    let CallLogProvider = _prefix "CallLogProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ContactsContractProvider"></see>
    /// </summary>
    let ContactsContractProvider = _prefix "ContactsContractProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#LiveFoldersProvider"></see>
    /// </summary>
    let LiveFoldersProvider = _prefix "LiveFoldersProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#MediaStoreProvider"></see>
    /// </summary>
    let MediaStoreProvider = _prefix "MediaStoreProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#SearchRecentSuggestionsProvider"></see>
    /// </summary>
    let SearchRecentSuggestionsProvider = _prefix "SearchRecentSuggestionsProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#SettingsProvider"></see>
    /// </summary>
    let SettingsProvider = _prefix "SettingsProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#SyncStateContractProvider"></see>
    /// </summary>
    let SyncStateContractProvider = _prefix "SyncStateContractProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#UserDictionaryProvider"></see>
    /// </summary>
    let UserDictionaryProvider = _prefix "UserDictionaryProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Agent"></see>
    /// </summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Identity information of a legal or natural entity.
    /// <see href="http://www.identity.org/ontologies/identity.owl#IdentityInformation"></see></summary>
    let IdentityInformation = _prefix "IdentityInformation"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasIdentity"></see>
    /// </summary>
    let hasIdentity = _prefix "hasIdentity"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Data"></see>
    /// </summary>
    let Data = _prefix "Data"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasData"></see>
    /// </summary>
    let hasData = _prefix "hasData"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ContentProvider"></see>
    /// </summary>
    let ContentProvider = _prefix "ContentProvider"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#BiometricData"></see>
    /// </summary>
    let BiometricData = _prefix "BiometricData"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#bimetricFile"></see>
    /// </summary>
    let bimetricFile = _prefix "bimetricFile"
    /// <summary>
    /// A business is a legal entity which is permitted to enter into a contract with another entity.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Business"></see></summary>
    let Business = _prefix "Business"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#BusinessInformation"></see>
    /// </summary>
    let BusinessInformation = _prefix "BusinessInformation"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#businessName"></see>
    /// </summary>
    let businessName = _prefix "businessName"
    /// <summary>
    /// Required information to contact an agent.
    /// <see href="http://www.identity.org/ontologies/identity.owl#ContactInformation"></see></summary>
    let ContactInformation = _prefix "ContactInformation"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasContactInfo"></see>
    /// </summary>
    let hasContactInfo = _prefix "hasContactInfo"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#logo"></see>
    /// </summary>
    let logo = _prefix "logo"
    /// <summary>
    /// Department or Division of Organization and eventually where user is employed.
    /// <see href="http://www.identity.org/ontologies/identity.owl#businessUnit"></see></summary>
    let businessUnit = _prefix "businessUnit"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#CellPhoneData"></see>
    /// </summary>
    let CellPhoneData = _prefix "CellPhoneData"
    /// <summary>
    /// International Mobile Equipment Identity.
    /// <see href="http://www.identity.org/ontologies/identity.owl#imei"></see></summary>
    let imei = _prefix "imei"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#cellID"></see>
    /// </summary>
    let cellID = _prefix "cellID"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#languageCode"></see>
    /// </summary>
    let languageCode = _prefix "languageCode"
    /// <summary>
    /// This structure is used to specify identity certificates.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Certificate"></see></summary>
    let Certificate = _prefix "Certificate"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#key"></see>
    /// </summary>
    let key = _prefix "key"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#format"></see>
    /// </summary>
    let format = _prefix "format"
    /// <summary>
    /// The date structure specifies a date. Date information can be used in different ways, depending on the context.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Date"></see></summary>
    let Date = _prefix "Date"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasExpirationDate"></see>
    /// </summary>
    let hasExpirationDate = _prefix "hasExpirationDate"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ChatAccount"></see>
    /// </summary>
    let ChatAccount = _prefix "ChatAccount"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#OnlineAccount"></see>
    /// </summary>
    let OnlineAccount = _prefix "OnlineAccount"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Condition"></see>
    /// </summary>
    let Condition = _prefix "Condition"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Context"></see>
    /// </summary>
    let Context = _prefix "Context"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#timeZone"></see>
    /// </summary>
    let timeZone = _prefix "timeZone"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#fractionSecond"></see>
    /// </summary>
    let fractionSecond = _prefix "fractionSecond"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hmsDate"></see>
    /// </summary>
    let hmsDate = _prefix "hmsDate"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#dateYmd"></see>
    /// </summary>
    let dateYmd = _prefix "dateYmd"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#EcommerceAccount"></see>
    /// </summary>
    let EcommerceAccount = _prefix "EcommerceAccount"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#EncryptAlgo"></see>
    /// </summary>
    let EncryptAlgo = _prefix "EncryptAlgo"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#algo"></see>
    /// </summary>
    let algo = _prefix "algo"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Fax"></see>
    /// </summary>
    let Fax = _prefix "Fax"
    /// <summary>
    /// Telecommunication information about an agnet.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Telecommunication"></see></summary>
    let Telecommunication = _prefix "Telecommunication"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ForbiddenAction"></see>
    /// </summary>
    let ForbiddenAction = _prefix "ForbiddenAction"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#GamingAccount"></see>
    /// </summary>
    let GamingAccount = _prefix "GamingAccount"
    /// <summary>
    /// A group of persons that figure in the contact list of an individual.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// A person is an individual who has a social identity and a technical one.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasMember"></see>
    /// </summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// Indivuals or natural entities.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Individual"></see></summary>
    let Individual = _prefix "Individual"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#History"></see>
    /// </summary>
    let History = _prefix "History"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasCertificate"></see>
    /// </summary>
    let hasCertificate = _prefix "hasCertificate"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#IndividualInformation"></see>
    /// </summary>
    let IndividualInformation = _prefix "IndividualInformation"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#jobTitle"></see>
    /// </summary>
    let jobTitle = _prefix "jobTitle"
    /// <summary>
    /// The person name specifies information about the naming of a person.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#gender"></see>
    /// </summary>
    let gender = _prefix "gender"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasHomeInfo"></see>
    /// </summary>
    let hasHomeInfo = _prefix "hasHomeInfo"
    /// <summary>
    /// IDs ans Passwords for web services which require authentification.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Login"></see></summary>
    let Login = _prefix "Login"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasLogin"></see>
    /// </summary>
    let hasLogin = _prefix "hasLogin"
    /// <summary>
    /// User's Birthday
    /// <see href="http://www.identity.org/ontologies/identity.owl#hasBirthDate"></see></summary>
    let hasBirthDate = _prefix "hasBirthDate"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#employer"></see>
    /// </summary>
    let employer = _prefix "employer"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#InvalidCertificate"></see>
    /// </summary>
    let InvalidCertificate = _prefix "InvalidCertificate"
    /// <summary>
    /// This legal entity is the issuer of an individual digital identity.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Issuer"></see></summary>
    let Issuer = _prefix "Issuer"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#isIssuerOf"></see>
    /// </summary>
    let isIssuerOf = _prefix "isIssuerOf"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#LocationData"></see>
    /// </summary>
    let LocationData = _prefix "LocationData"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#wifi"></see>
    /// </summary>
    let wifi = _prefix "wifi"
    /// <summary>
    /// Global Positioning System
    /// <see href="http://www.identity.org/ontologies/identity.owl#gps"></see></summary>
    let gps = _prefix "gps"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ip"></see>
    /// </summary>
    let ip = _prefix "ip"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#latitude"></see>
    /// </summary>
    let latitude = _prefix "latitude"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#longitude"></see>
    /// </summary>
    let longitude = _prefix "longitude"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#LogData"></see>
    /// </summary>
    let LogData = _prefix "LogData"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#timestamp"></see>
    /// </summary>
    let timestamp = _prefix "timestamp"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#uri"></see>
    /// </summary>
    let uri = _prefix "uri"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#callLog"></see>
    /// </summary>
    let callLog = _prefix "callLog"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#password"></see>
    /// </summary>
    let password = _prefix "password"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#MiscData"></see>
    /// </summary>
    let MiscData = _prefix "MiscData"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#cookie"></see>
    /// </summary>
    let cookie = _prefix "cookie"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#photo"></see>
    /// </summary>
    let photo = _prefix "photo"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#video"></see>
    /// </summary>
    let video = _prefix "video"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#document"></see>
    /// </summary>
    let document = _prefix "document"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Mobile"></see>
    /// </summary>
    let Mobile = _prefix "Mobile"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Mode"></see>
    /// </summary>
    let Mode = _prefix "Mode"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#nickName"></see>
    /// </summary>
    let nickName = _prefix "nickName"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#familyName"></see>
    /// </summary>
    let familyName = _prefix "familyName"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#givenName"></see>
    /// </summary>
    let givenName = _prefix "givenName"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#middleName"></see>
    /// </summary>
    let middleName = _prefix "middleName"
    /// <summary>
    /// Online information about an agent.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Online"></see></summary>
    let Online = _prefix "Online"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#email"></see>
    /// </summary>
    let email = _prefix "email"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Pager"></see>
    /// </summary>
    let Pager = _prefix "Pager"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#PermittedAction"></see>
    /// </summary>
    let PermittedAction = _prefix "PermittedAction"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#knows"></see>
    /// </summary>
    let knows = _prefix "knows"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Policy"></see>
    /// </summary>
    let Policy = _prefix "Policy"
    /// <summary>
    /// Postal mailing address.
    /// <see href="http://www.identity.org/ontologies/identity.owl#Postal"></see></summary>
    let Postal = _prefix "Postal"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#number"></see>
    /// </summary>
    let number = _prefix "number"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#postalCode"></see>
    /// </summary>
    let postalCode = _prefix "postalCode"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#city"></see>
    /// </summary>
    let city = _prefix "city"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#country"></see>
    /// </summary>
    let country = _prefix "country"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#region"></see>
    /// </summary>
    let region = _prefix "region"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#departmentName"></see>
    /// </summary>
    let departmentName = _prefix "departmentName"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#street"></see>
    /// </summary>
    let street = _prefix "street"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#departmentCode"></see>
    /// </summary>
    let departmentCode = _prefix "departmentCode"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#SecretData"></see>
    /// </summary>
    let SecretData = _prefix "SecretData"
    /// <summary>
    /// A secret code to identify the identity holder.
    /// <see href="http://www.identity.org/ontologies/identity.owl#pin"></see></summary>
    let pin = _prefix "pin"
    /// <summary>
    /// Provider of mobile phone services.
    /// <see href="http://www.identity.org/ontologies/identity.owl#ServiceProvider"></see></summary>
    let ServiceProvider = _prefix "ServiceProvider"
    /// <summary>
    /// The characteristics of a telephone number.
    /// <see href="http://www.identity.org/ontologies/identity.owl#TelephoneNumber"></see></summary>
    let TelephoneNumber = _prefix "TelephoneNumber"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasTelephoneNumber"></see>
    /// </summary>
    let hasTelephoneNumber = _prefix "hasTelephoneNumber"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#Telephone"></see>
    /// </summary>
    let Telephone = _prefix "Telephone"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#phoneNumber"></see>
    /// </summary>
    let phoneNumber = _prefix "phoneNumber"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#phoneExtension"></see>
    /// </summary>
    let phoneExtension = _prefix "phoneExtension"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#localCode"></see>
    /// </summary>
    let localCode = _prefix "localCode"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#intCode"></see>
    /// </summary>
    let intCode = _prefix "intCode"
    /// <summary>
    /// L'identifiant unique d'une entité qui possède une identité (agent).
    /// <see href="http://www.identity.org/ontologies/identity.owl#UID"></see></summary>
    let UID = _prefix "UID"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#uid"></see>
    /// </summary>
    let uid = _prefix "uid"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#ValidCertificate"></see>
    /// </summary>
    let ValidCertificate = _prefix "ValidCertificate"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#age"></see>
    /// </summary>
    let age = _prefix "age"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#data"></see>
    /// </summary>
    let data = _prefix "data"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#postalAddress"></see>
    /// </summary>
    let postalAddress = _prefix "postalAddress"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#conservative"></see>
    /// </summary>
    let conservative = _prefix "conservative"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#controls"></see>
    /// </summary>
    let controls = _prefix "controls"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#createdOn"></see>
    /// </summary>
    let createdOn = _prefix "createdOn"
    /// <summary>
    /// Time date information is described in the time standard ISO8601.
    /// <see href="http://www.identity.org/ontologies/identity.owl#timeDate"></see></summary>
    let timeDate = _prefix "timeDate"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#extendedAddress"></see>
    /// </summary>
    let extendedAddress = _prefix "extendedAddress"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#indivName"></see>
    /// </summary>
    let indivName = _prefix "indivName"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#forbids"></see>
    /// </summary>
    let forbids = _prefix "forbids"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasAction"></see>
    /// </summary>
    let hasAction = _prefix "hasAction"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasActionDate"></see>
    /// </summary>
    let hasActionDate = _prefix "hasActionDate"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasActor"></see>
    /// </summary>
    let hasActor = _prefix "hasActor"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasDate"></see>
    /// </summary>
    let hasDate = _prefix "hasDate"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasContext"></see>
    /// </summary>
    let hasContext = _prefix "hasContext"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasCreator"></see>
    /// </summary>
    let hasCreator = _prefix "hasCreator"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasDefaultPolicyMode"></see>
    /// </summary>
    let hasDefaultPolicyMode = _prefix "hasDefaultPolicyMode"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasHistoricTarget"></see>
    /// </summary>
    let hasHistoricTarget = _prefix "hasHistoricTarget"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasLocation"></see>
    /// </summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasTarget"></see>
    /// </summary>
    let hasTarget = _prefix "hasTarget"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#hasWorkInfo"></see>
    /// </summary>
    let hasWorkInfo = _prefix "hasWorkInfo"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#telephoneNum"></see>
    /// </summary>
    let telephoneNum = _prefix "telephoneNum"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#liberal"></see>
    /// </summary>
    let liberal = _prefix "liberal"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#metaPolicy"></see>
    /// </summary>
    let metaPolicy = _prefix "metaPolicy"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#permits"></see>
    /// </summary>
    let permits = _prefix "permits"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#postOfficeBox"></see>
    /// </summary>
    let postOfficeBox = _prefix "postOfficeBox"
    /// <summary>
    ///   <see href="http://www.identity.org/ontologies/identity.owl#requires"></see>
    /// </summary>
    let requires = _prefix "requires"
