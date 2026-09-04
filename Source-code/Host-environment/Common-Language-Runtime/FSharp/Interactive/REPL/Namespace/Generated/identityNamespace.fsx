#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module identity =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.identity.org/ontologies/identity.owl#" "identity"

    /// <summary>
    ///   <para>rdfs:label : Action^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Action">identity:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Agent">identity:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    let AlarmClockProvider = _prefixId.prefix "AlarmClockProvider"
    /// <summary>
    ///   <para>rdfs:label : BiometricData^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#BiometricData">identity:BiometricData</a>
    /// </summary>
    let BiometricData = _prefixId.prefix "BiometricData"
    let BrowserProvider = _prefixId.prefix "BrowserProvider"
    /// <summary>
    ///   <para>rdfs:comment : Un business est une entité morale comme une organisation, une entreprise, une association ou une agence...rdfs:comment : A business is a legal entity which is permitted to enter into a contract with another entity.</para>
    ///   <para>rdfs:label : Business^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Business">identity:Business</a>
    /// </summary>
    let Business = _prefixId.prefix "Business"
    /// <summary>
    ///   <para>rdfs:comment : Identité associée uniquement à une personne morale.</para>
    ///   <para>rdfs:label : BusinessInformation^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#BusinessInformation">identity:BusinessInformation</a>
    /// </summary>
    let BusinessInformation = _prefixId.prefix "BusinessInformation"
    let CallLogProvider = _prefixId.prefix "CallLogProvider"
    /// <summary>
    ///   <para>rdfs:comment : Les données correspondant à l'appareil mobile.</para>
    ///   <para>rdfs:label : CellPhoneData^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#CellPhoneData">identity:CellPhoneData</a>
    /// </summary>
    let CellPhoneData = _prefixId.prefix "CellPhoneData"
    /// <summary>
    ///   <para>rdfs:comment : Il s'agit de l'élèment de l'identité qui permettera l'authentification de l'utilisateur, du fournisseur de service ainsi que l'émetteur de l'identité.rdfs:comment : This structure is used to specify identity certificates.</para>
    ///   <para>rdfs:label : User or Organization Identity Certificate^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Certificate">identity:Certificate</a>
    /// </summary>
    let Certificate = _prefixId.prefix "Certificate"
    /// <summary>
    ///   <para>rdfs:comment : Compte de discussion en ligne.</para>
    ///   <para>rdfs:label : ChatAccount^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ChatAccount">identity:ChatAccount</a>
    /// </summary>
    let ChatAccount = _prefixId.prefix "ChatAccount"
    /// <summary>
    ///   <para>rdfs:label : Condition^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Condition">identity:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>rdfs:comment : Les informations nécessaires pour contacter un agent.rdfs:comment : Required information to contact an agent.</para>
    ///   <para>rdfs:label : ContactInformation^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ContactInformation">identity:ContactInformation</a>
    /// </summary>
    let ContactInformation = _prefixId.prefix "ContactInformation"
    let ContactsContractProvider = _prefixId.prefix "ContactsContractProvider"
    let ContentProvider = _prefixId.prefix "ContentProvider"
    /// <summary>
    ///   <para>rdfs:label : Context^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Context">identity:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:label : Data^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Data">identity:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    /// <summary>
    ///   <para>rdfs:comment : The date structure specifies a date. Date information can be used in different ways, depending on the context.</para>
    ///   <para>rdfs:label : Date^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Date">identity:Date</a>
    /// </summary>
    let Date = _prefixId.prefix "Date"
    /// <summary>
    ///   <para>rdfs:label : Date: Hour/Minute/Second^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#DateHms">identity:DateHms</a>
    /// </summary>
    let DateHms = _prefixId.prefix "DateHms"
    /// <summary>
    ///   <para>rdfs:label : Date: Year/Month/Day^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#DateYmd">identity:DateYmd</a>
    /// </summary>
    let DateYmd = _prefixId.prefix "DateYmd"
    /// <summary>
    ///   <para>rdfs:comment : Compte d'achat en ligne. Il peut contenir des informations critiques comme les données bancaires.</para>
    ///   <para>rdfs:label : EcommerceAccount^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#EcommerceAccount">identity:EcommerceAccount</a>
    /// </summary>
    let EcommerceAccount = _prefixId.prefix "EcommerceAccount"
    /// <summary>
    ///   <para>rdfs:label : Algorithme de chiffrement.rdfs:label : EncryptAlgo^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#EncryptAlgo">identity:EncryptAlgo</a>
    /// </summary>
    let EncryptAlgo = _prefixId.prefix "EncryptAlgo"
    /// <summary>
    ///   <para>rdfs:label : FaceRecognition^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#FaceRecognition">identity:FaceRecognition</a>
    /// </summary>
    let FaceRecognition = _prefixId.prefix "FaceRecognition"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : Fax^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Fax">identity:Fax</a>
    /// </summary>
    let Fax = _prefixId.prefix "Fax"
    /// <summary>
    ///   <para>rdfs:label : FingerprintRecognition^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#FingerprintRecognition">identity:FingerprintRecognition</a>
    /// </summary>
    let FingerprintRecognition = _prefixId.prefix "FingerprintRecognition"
    /// <summary>
    ///   <para>rdfs:label : ForbiddenAction^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ForbiddenAction">identity:ForbiddenAction</a>
    /// </summary>
    let ForbiddenAction = _prefixId.prefix "ForbiddenAction"
    /// <summary>
    ///   <para>rdfs:comment : Compte pour des jeux en ligne (gratuit ou payant).</para>
    ///   <para>rdfs:label : GamingAccount^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#GamingAccount">identity:GamingAccount</a>
    /// </summary>
    let GamingAccount = _prefixId.prefix "GamingAccount"
    /// <summary>
    ///   <para>rdfs:comment : Un groupe des personnes qui constituent la liste des contacts d'un individu.rdfs:comment : A group of persons that figure in the contact list of an individual.</para>
    ///   <para>rdfs:label : Group^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Group">identity:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : History^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#History">identity:History</a>
    /// </summary>
    let History = _prefixId.prefix "History"
    /// <summary>
    ///   <para>rdfs:comment : Les informations relatives à une identité numérique d'une personne physique ou morale.rdfs:comment : Identity information of a legal or natural entity.</para>
    ///   <para>rdfs:label : IdentityInformation^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#IdentityInformation">identity:IdentityInformation</a>
    /// </summary>
    let IdentityInformation = _prefixId.prefix "IdentityInformation"
    /// <summary>
    ///   <para>rdfs:comment : L'ensemble des personnes physiques.rdfs:comment : Indivuals or natural entities.</para>
    ///   <para>rdfs:label : Individual^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Individual">identity:Individual</a>
    /// </summary>
    let Individual = _prefixId.prefix "Individual"
    /// <summary>
    ///   <para>rdfs:comment : Identité associée uniquement à une personne physique.</para>
    ///   <para>rdfs:label : IndividualInformation^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#IndividualInformation">identity:IndividualInformation</a>
    /// </summary>
    let IndividualInformation = _prefixId.prefix "IndividualInformation"
    /// <summary>
    ///   <para>rdfs:label : InvalidCertificate^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#InvalidCertificate">identity:InvalidCertificate</a>
    /// </summary>
    let InvalidCertificate = _prefixId.prefix "InvalidCertificate"
    /// <summary>
    ///   <para>rdfs:label : IrisRecognition^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#IrisRecognition">identity:IrisRecognition</a>
    /// </summary>
    let IrisRecognition = _prefixId.prefix "IrisRecognition"
    /// <summary>
    ///   <para>rdfs:comment : L'émetteur d'une identité numérique (opérateur téléphonique par exemple).rdfs:comment : This legal entity is the issuer of an individual digital identity.</para>
    ///   <para>rdfs:label : Issuer^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Issuer">identity:Issuer</a>
    /// </summary>
    let Issuer = _prefixId.prefix "Issuer"
    /// <summary>
    ///   <para>rdfs:label : KeystokeDynamicRecognition^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#KeystokeDynamicRecognition">identity:KeystokeDynamicRecognition</a>
    /// </summary>
    let KeystokeDynamicRecognition = _prefixId.prefix "KeystokeDynamicRecognition"
    let LiveFoldersProvider = _prefixId.prefix "LiveFoldersProvider"
    /// <summary>
    ///   <para>rdfs:comment : Les données de locations permettant de localiser le porteur de l'identité.</para>
    ///   <para>rdfs:label : LocationData^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#LocationData">identity:LocationData</a>
    /// </summary>
    let LocationData = _prefixId.prefix "LocationData"
    /// <summary>
    ///   <para>rdfs:label : LogInformation^^xsd:stringrdfs:label : LogInfo^^xsd:stringrdfs:label : LogData^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#LogData">identity:LogData</a>
    /// </summary>
    let LogData = _prefixId.prefix "LogData"
    /// <summary>
    ///   <para>dce:type : Unique Identifiers</para>
    ///   <para>rdfs:comment : IDs ans Passwords for web services which require authentification.</para>
    ///   <para>rdfs:label : User's Login Information^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Login">identity:Login</a>
    /// </summary>
    let Login = _prefixId.prefix "Login"
    let MediaStoreProvider = _prefixId.prefix "MediaStoreProvider"
    /// <summary>
    ///   <para>rdfs:comment : Photos, videos, sms, documents, notes, call logs, cookies...</para>
    ///   <para>rdfs:label : MiscData^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#MiscData">identity:MiscData</a>
    /// </summary>
    let MiscData = _prefixId.prefix "MiscData"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : Mobile^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Mobile">identity:Mobile</a>
    /// </summary>
    let Mobile = _prefixId.prefix "Mobile"
    /// <summary>
    ///   <para>rdfs:label : Mode^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Mode">identity:Mode</a>
    /// </summary>
    let Mode = _prefixId.prefix "Mode"
    /// <summary>
    ///   <para>rdfs:comment : The person name specifies information about the naming of a person.</para>
    ///   <para>rdfs:label : User's Name^^xsd:string</para>
    ///   <para>dce:type : Physical Contact Information, Demographic and Socieconomic Data</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Name">identity:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>rdfs:comment : Les adresses électroniques pour contacter un agent.rdfs:comment : Online information about an agent.</para>
    ///   <para>dce:type : Online Contact Information</para>
    ///   <para>rdfs:label : Online^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Online">identity:Online</a>
    /// </summary>
    let Online = _prefixId.prefix "Online"
    /// <summary>
    ///   <para>rdfs:comment : Les comptes en ligne de l'utilisateur.</para>
    ///   <para>rdfs:label : OnlineAccount^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#OnlineAccount">identity:OnlineAccount</a>
    /// </summary>
    let OnlineAccount = _prefixId.prefix "OnlineAccount"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : Pager^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Pager">identity:Pager</a>
    /// </summary>
    let Pager = _prefixId.prefix "Pager"
    /// <summary>
    ///   <para>rdfs:label : PermittedAction^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#PermittedAction">identity:PermittedAction</a>
    /// </summary>
    let PermittedAction = _prefixId.prefix "PermittedAction"
    /// <summary>
    ///   <para>rdfs:comment : Une personne est un individu qui possède une identité numérique et qui cherche à protéger sa vie privée.rdfs:comment : A person is an individual who has a social identity and a technical one.</para>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Person">identity:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Policy^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Policy">identity:Policy</a>
    /// </summary>
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information, Demographic and Socioeconomic Data</para>
    ///   <para>rdfs:label : Postal^^xsd:string</para>
    ///   <para>rdfs:comment : Postal mailing address.</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Postal">identity:Postal</a>
    /// </summary>
    let Postal = _prefixId.prefix "Postal"

    let SearchRecentSuggestionsProvider =
        _prefixId.prefix "SearchRecentSuggestionsProvider"

    /// <summary>
    ///   <para>rdfs:label : SecretData^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#SecretData">identity:SecretData</a>
    /// </summary>
    let SecretData = _prefixId.prefix "SecretData"
    /// <summary>
    ///   <para>rdfs:comment : Le fournisseur de services mobiles (application, jeu, site Web)rdfs:comment : Provider of mobile phone services.</para>
    ///   <para>rdfs:label : ServiceProvider^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ServiceProvider">identity:ServiceProvider</a>
    /// </summary>
    let ServiceProvider = _prefixId.prefix "ServiceProvider"
    let SettingsProvider = _prefixId.prefix "SettingsProvider"
    let SyncStateContractProvider = _prefixId.prefix "SyncStateContractProvider"
    /// <summary>
    ///   <para>rdfs:comment : Telecommunication information about an agnet.</para>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : Telecommunication^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Telecommunication">identity:Telecommunication</a>
    /// </summary>
    let Telecommunication = _prefixId.prefix "Telecommunication"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : Telephone^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#Telephone">identity:Telephone</a>
    /// </summary>
    let Telephone = _prefixId.prefix "Telephone"
    /// <summary>
    ///   <para>rdfs:comment : The characteristics of a telephone number.</para>
    ///   <para>rdfs:label : TelephoneNumber^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#TelephoneNumber">identity:TelephoneNumber</a>
    /// </summary>
    let TelephoneNumber = _prefixId.prefix "TelephoneNumber"
    /// <summary>
    ///   <para>rdfs:comment : L'identifiant unique d'une entité qui possède une identité (agent).^^xsd:string</para>
    ///   <para>rdfs:label : UID^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#UID">identity:UID</a>
    /// </summary>
    let UID = _prefixId.prefix "UID"
    let UserDictionaryProvider = _prefixId.prefix "UserDictionaryProvider"
    /// <summary>
    ///   <para>rdfs:label : ValidCertificate^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ValidCertificate">identity:ValidCertificate</a>
    /// </summary>
    let ValidCertificate = _prefixId.prefix "ValidCertificate"
    /// <summary>
    ///   <para>rdfs:label : VoiceRecognition^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#VoiceRecognition">identity:VoiceRecognition</a>
    /// </summary>
    let VoiceRecognition = _prefixId.prefix "VoiceRecognition"
    /// <summary>
    ///   <para>rdfs:label : age^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#age">identity:age</a>
    /// </summary>
    let age = _prefixId.prefix "age"
    /// <summary>
    ///   <para>rdfs:label : algo^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#algo">identity:algo</a>
    /// </summary>
    let algo = _prefixId.prefix "algo"
    /// <summary>
    ///   <para>rdfs:label : bimetricFile^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#bimetricFile">identity:bimetricFile</a>
    /// </summary>
    let bimetricFile = _prefixId.prefix "bimetricFile"
    /// <summary>
    ///   <para>rdfs:label : businessName^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#businessName">identity:businessName</a>
    /// </summary>
    let businessName = _prefixId.prefix "businessName"
    /// <summary>
    ///   <para>rdfs:comment : Department or Division of Organization and eventually where user is employed.</para>
    ///   <para>dce:type : Demographic and Socieconomic Data</para>
    ///   <para>rdfs:label : businessUnit^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#businessUnit">identity:businessUnit</a>
    /// </summary>
    let businessUnit = _prefixId.prefix "businessUnit"
    /// <summary>
    ///   <para>rdfs:label : callLog^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#callLog">identity:callLog</a>
    /// </summary>
    let callLog = _prefixId.prefix "callLog"
    /// <summary>
    ///   <para>rdfs:comment : L'identifiant de l'appareil.</para>
    ///   <para>rdfs:label : cellID^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#cellID">identity:cellID</a>
    /// </summary>
    let cellID = _prefixId.prefix "cellID"
    /// <summary>
    ///   <para>dce:type : Demographic and Socioeconomic Data</para>
    ///   <para>rdfs:label : city^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#city">identity:city</a>
    /// </summary>
    let city = _prefixId.prefix "city"
    let conservative = _prefixId.prefix "conservative"
    /// <summary>
    ///   <para>rdfs:label : controls^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#controls">identity:controls</a>
    /// </summary>
    let controls = _prefixId.prefix "controls"
    /// <summary>
    ///   <para>rdfs:label : cookie^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#cookie">identity:cookie</a>
    /// </summary>
    let cookie = _prefixId.prefix "cookie"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : The country field represents the information of the name of the country among the countries listed in ISO3166.</para>
    ///   <para>dce:type : Demographic and Socioeconomic Data</para>
    ///   <para>rdfs:label : country^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#country">identity:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : createdOn^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#createdOn">identity:createdOn</a>
    /// </summary>
    let createdOn = _prefixId.prefix "createdOn"
    /// <summary>
    ///   <para>rdfs:label : data^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#data">identity:data</a>
    /// </summary>
    let data = _prefixId.prefix "data"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : dateYmd^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#dateYmd">identity:dateYmd</a>
    /// </summary>
    let dateYmd = _prefixId.prefix "dateYmd"
    /// <summary>
    ///   <para>dce:type : Demographic and Socioeconomic Data</para>
    ///   <para>rdfs:label : departmentCode^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#departmentCode">identity:departmentCode</a>
    /// </summary>
    let departmentCode = _prefixId.prefix "departmentCode"
    /// <summary>
    ///   <para>dce:type : Demographic and Socioeconomic Data</para>
    ///   <para>rdfs:label : departmentName^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#departmentName">identity:departmentName</a>
    /// </summary>
    let departmentName = _prefixId.prefix "departmentName"
    /// <summary>
    ///   <para>rdfs:label : document^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#document">identity:document</a>
    /// </summary>
    let document = _prefixId.prefix "document"
    /// <summary>
    ///   <para>dce:type : Online Contact Information</para>
    ///   <para>rdfs:label : email^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#email">identity:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>dce:type : Demographic and Socieconomic Data</para>
    ///   <para>rdfs:label : employer^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#employer">identity:employer</a>
    /// </summary>
    let employer = _prefixId.prefix "employer"
    /// <summary>
    ///   <para>dce:type : Demographic and Socioeconomic Data</para>
    ///   <para>rdfs:label : extendedAddress^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#extendedAddress">identity:extendedAddress</a>
    /// </summary>
    let extendedAddress = _prefixId.prefix "extendedAddress"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : familyName^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#familyName">identity:familyName</a>
    /// </summary>
    let familyName = _prefixId.prefix "familyName"
    /// <summary>
    ///   <para>rdfs:label : forbids^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#forbids">identity:forbids</a>
    /// </summary>
    let forbids = _prefixId.prefix "forbids"
    /// <summary>
    ///   <para>dce:type : Unique Identifiers</para>
    ///   <para>rdfs:label : Certificate Format^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#format">identity:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>rdfs:label : fractionSecond^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#fractionSecond">identity:fractionSecond</a>
    /// </summary>
    let fractionSecond = _prefixId.prefix "fractionSecond"
    /// <summary>
    ///   <para>dce:type : Demographic and Socieconomic Data</para>
    ///   <para>rdfs:label : gender^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#gender">identity:gender</a>
    /// </summary>
    let gender = _prefixId.prefix "gender"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : givenName^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#givenName">identity:givenName</a>
    /// </summary>
    let givenName = _prefixId.prefix "givenName"
    /// <summary>
    ///   <para>rdfs:comment : Système de positionnement mondial.rdfs:comment : Global Positioning System</para>
    ///   <para>rdfs:label : gps^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#gps">identity:gps</a>
    /// </summary>
    let gps = _prefixId.prefix "gps"
    let hasAction = _prefixId.prefix "hasAction"
    let hasActionDate = _prefixId.prefix "hasActionDate"
    /// <summary>
    ///   <para>rdfs:label : hasActor^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasActor">identity:hasActor</a>
    /// </summary>
    let hasActor = _prefixId.prefix "hasActor"
    /// <summary>
    ///   <para>rdfs:comment : Demographic and Socieconomic Datardfs:comment : User's Birthday</para>
    ///   <para>rdfs:label : hasBirthDate^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasBirthDate">identity:hasBirthDate</a>
    /// </summary>
    let hasBirthDate = _prefixId.prefix "hasBirthDate"
    /// <summary>
    ///   <para>rdfs:label : hasCertificate^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasCertificate">identity:hasCertificate</a>
    /// </summary>
    let hasCertificate = _prefixId.prefix "hasCertificate"
    /// <summary>
    ///   <para>rdfs:comment : Cette propriété associe un objet à une adresse, une adresse e-mail et à un numéro de téléphone.</para>
    ///   <para>rdfs:label : hasContactInfo^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasContactInfo">identity:hasContactInfo</a>
    /// </summary>
    let hasContactInfo = _prefixId.prefix "hasContactInfo"
    /// <summary>
    ///   <para>rdfs:label : hasContext^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasContext">identity:hasContext</a>
    /// </summary>
    let hasContext = _prefixId.prefix "hasContext"
    /// <summary>
    ///   <para>rdfs:label : hasCreator^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasCreator">identity:hasCreator</a>
    /// </summary>
    let hasCreator = _prefixId.prefix "hasCreator"
    /// <summary>
    ///   <para>rdfs:label : hasData^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasData">identity:hasData</a>
    /// </summary>
    let hasData = _prefixId.prefix "hasData"
    /// <summary>
    ///   <para>rdfs:label : hasDate^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasDate">identity:hasDate</a>
    /// </summary>
    let hasDate = _prefixId.prefix "hasDate"
    /// <summary>
    ///   <para>rdfs:label : hasDefaultPolicyMode^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasDefaultPolicyMode">identity:hasDefaultPolicyMode</a>
    /// </summary>
    let hasDefaultPolicyMode = _prefixId.prefix "hasDefaultPolicyMode"
    /// <summary>
    ///   <para>rdfs:label : hasExpirationDate^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasExpirationDate">identity:hasExpirationDate</a>
    /// </summary>
    let hasExpirationDate = _prefixId.prefix "hasExpirationDate"
    /// <summary>
    ///   <para>rdfs:label : hasHistoricTarget^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasHistoricTarget">identity:hasHistoricTarget</a>
    /// </summary>
    let hasHistoricTarget = _prefixId.prefix "hasHistoricTarget"
    /// <summary>
    ///   <para>rdfs:label : hasHomeInfo^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasHomeInfo">identity:hasHomeInfo</a>
    /// </summary>
    let hasHomeInfo = _prefixId.prefix "hasHomeInfo"
    /// <summary>
    ///   <para>rdfs:label : hasIdentity^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasIdentity">identity:hasIdentity</a>
    /// </summary>
    let hasIdentity = _prefixId.prefix "hasIdentity"
    /// <summary>
    ///   <para>rdfs:label : hasLocation^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasLocation">identity:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : hasLogin^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasLogin">identity:hasLogin</a>
    /// </summary>
    let hasLogin = _prefixId.prefix "hasLogin"
    /// <summary>
    ///   <para>rdfs:label : hasMember^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasMember">identity:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : hasName^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasName">identity:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : hasTarget^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasTarget">identity:hasTarget</a>
    /// </summary>
    let hasTarget = _prefixId.prefix "hasTarget"
    /// <summary>
    ///   <para>rdfs:label : hasTelephoneNumber^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasTelephoneNumber">identity:hasTelephoneNumber</a>
    /// </summary>
    let hasTelephoneNumber = _prefixId.prefix "hasTelephoneNumber"
    /// <summary>
    ///   <para>rdfs:label : hasWorkInfo^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hasWorkInfo">identity:hasWorkInfo</a>
    /// </summary>
    let hasWorkInfo = _prefixId.prefix "hasWorkInfo"
    /// <summary>
    ///   <para>rdfs:label : hmsDate^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hmsDate">identity:hmsDate</a>
    /// </summary>
    let hmsDate = _prefixId.prefix "hmsDate"
    /// <summary>
    ///   <para>rdfs:label : hmsHour^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hmsHour">identity:hmsHour</a>
    /// </summary>
    let hmsHour = _prefixId.prefix "hmsHour"
    /// <summary>
    ///   <para>rdfs:label : hmsMinute^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hmsMinute">identity:hmsMinute</a>
    /// </summary>
    let hmsMinute = _prefixId.prefix "hmsMinute"
    /// <summary>
    ///   <para>rdfs:label : hmsSecond^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#hmsSecond">identity:hmsSecond</a>
    /// </summary>
    let hmsSecond = _prefixId.prefix "hmsSecond"
    /// <summary>
    ///   <para>dce:type : Unique Identifiers</para>
    ///   <para>rdfs:label : Login ID</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#id">identity:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:comment : L'identité internationale d'équipement mobile est un numéro qui permet d'identifier de manière unique chacun des terminaux de téléphonie mobile.rdfs:comment : International Mobile Equipment Identity.</para>
    ///   <para>rdfs:label : imei^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#imei">identity:imei</a>
    /// </summary>
    let imei = _prefixId.prefix "imei"
    /// <summary>
    ///   <para>rdfs:label : indivName^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#indivName">identity:indivName</a>
    /// </summary>
    let indivName = _prefixId.prefix "indivName"
    /// <summary>
    ///   <para>rdfs:comment : Code international, qui permet par exemple l'accès au service Roaming à l'étranger.</para>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : intCode^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#intCode">identity:intCode</a>
    /// </summary>
    let intCode = _prefixId.prefix "intCode"
    /// <summary>
    ///   <para>rdfs:comment : Adresse IP du mobile.</para>
    ///   <para>rdfs:label : ip^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ip">identity:ip</a>
    /// </summary>
    let ip = _prefixId.prefix "ip"
    /// <summary>
    ///   <para>rdfs:label : isIssuerOf^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#isIssuerOf">identity:isIssuerOf</a>
    /// </summary>
    let isIssuerOf = _prefixId.prefix "isIssuerOf"
    /// <summary>
    ///   <para>dce:type : Demographic and Socieconomic Data</para>
    ///   <para>rdfs:label : jobTitle^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#jobTitle">identity:jobTitle</a>
    /// </summary>
    let jobTitle = _prefixId.prefix "jobTitle"
    /// <summary>
    ///   <para>rdfs:comment : Les clés secrètes et publiques associées à un certificat.</para>
    ///   <para>dce:type : Unique Identifiers</para>
    ///   <para>rdfs:label : Certificate Key</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#key">identity:key</a>
    /// </summary>
    let key = _prefixId.prefix "key"
    /// <summary>
    ///   <para>rdfs:label : knows^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#knows">identity:knows</a>
    /// </summary>
    let knows = _prefixId.prefix "knows"
    /// <summary>
    ///   <para>rdfs:comment : Code du langage choisi par l'utilisateur.</para>
    ///   <para>rdfs:label : languageCode^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#languageCode">identity:languageCode</a>
    /// </summary>
    let languageCode = _prefixId.prefix "languageCode"
    /// <summary>
    ///   <para>rdfs:label : latitude^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#latitude">identity:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    let liberal = _prefixId.prefix "liberal"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : localCode^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#localCode">identity:localCode</a>
    /// </summary>
    let localCode = _prefixId.prefix "localCode"
    /// <summary>
    ///   <para>rdfs:label : logo^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#logo">identity:logo</a>
    /// </summary>
    let logo = _prefixId.prefix "logo"
    /// <summary>
    ///   <para>rdfs:label : longitude^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#longitude">identity:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    let metaPolicy = _prefixId.prefix "metaPolicy"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : middleName^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#middleName">identity:middleName</a>
    /// </summary>
    let middleName = _prefixId.prefix "middleName"
    /// <summary>
    ///   <para>dce:type : Demographic and Socioeconomic Data</para>
    ///   <para>rdfs:label : nickName^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#nickName">identity:nickName</a>
    /// </summary>
    let nickName = _prefixId.prefix "nickName"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : number^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#number">identity:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
    /// <summary>
    ///   <para>dce:type : Unique Identifiers</para>
    ///   <para>rdfs:label : Login password</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#password">identity:password</a>
    /// </summary>
    let password = _prefixId.prefix "password"
    /// <summary>
    ///   <para>rdfs:label : permits^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#permits">identity:permits</a>
    /// </summary>
    let permits = _prefixId.prefix "permits"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : phoneExtension^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#phoneExtension">identity:phoneExtension</a>
    /// </summary>
    let phoneExtension = _prefixId.prefix "phoneExtension"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : phoneNumber^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#phoneNumber">identity:phoneNumber</a>
    /// </summary>
    let phoneNumber = _prefixId.prefix "phoneNumber"
    /// <summary>
    ///   <para>rdfs:label : photo^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#photo">identity:photo</a>
    /// </summary>
    let photo = _prefixId.prefix "photo"
    /// <summary>
    ///   <para>rdfs:comment : Code secret pour authentifier le porteur de l'identité.rdfs:comment : A secret code to identify the identity holder.</para>
    ///   <para>rdfs:label : pin^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#pin">identity:pin</a>
    /// </summary>
    let pin = _prefixId.prefix "pin"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : postOfficeBox^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#postOfficeBox">identity:postOfficeBox</a>
    /// </summary>
    let postOfficeBox = _prefixId.prefix "postOfficeBox"
    /// <summary>
    ///   <para>rdfs:label : postalAddress^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#postalAddress">identity:postalAddress</a>
    /// </summary>
    let postalAddress = _prefixId.prefix "postalAddress"
    /// <summary>
    ///   <para>dce:type : Demographic and Socioeconomic Data</para>
    ///   <para>rdfs:label : postalCode^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#postalCode">identity:postalCode</a>
    /// </summary>
    let postalCode = _prefixId.prefix "postalCode"
    /// <summary>
    ///   <para>dce:type : Demographic and Socioeconomic Data</para>
    ///   <para>rdfs:label : region^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#region">identity:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    /// <summary>
    ///   <para>rdfs:label : requires^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#requires">identity:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    /// <summary>
    ///   <para>dce:type : Physical Contact Information</para>
    ///   <para>rdfs:label : street^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#street">identity:street</a>
    /// </summary>
    let street = _prefixId.prefix "street"
    /// <summary>
    ///   <para>rdfs:label : telephoneNum^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#telephoneNum">identity:telephoneNum</a>
    /// </summary>
    let telephoneNum = _prefixId.prefix "telephoneNum"
    /// <summary>
    ///   <para>rdfs:comment : Time date information is described in the time standard ISO8601.</para>
    ///   <para>rdfs:label : timeDate^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#timeDate">identity:timeDate</a>
    /// </summary>
    let timeDate = _prefixId.prefix "timeDate"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : timeZone^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#timeZone">identity:timeZone</a>
    /// </summary>
    let timeZone = _prefixId.prefix "timeZone"
    /// <summary>
    ///   <para>rdfs:label : timestamp^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#timestamp">identity:timestamp</a>
    /// </summary>
    let timestamp = _prefixId.prefix "timestamp"
    /// <summary>
    ///   <para>dce:type : Demographic and Socioeconomic Data</para>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#title">identity:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : uid^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#uid">identity:uid</a>
    /// </summary>
    let uid = _prefixId.prefix "uid"
    /// <summary>
    ///   <para>dce:type : Online Contact Information</para>
    ///   <para>rdfs:label : uri^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#uri">identity:uri</a>
    /// </summary>
    let uri = _prefixId.prefix "uri"
    /// <summary>
    ///   <para>rdfs:label : video^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#video">identity:video</a>
    /// </summary>
    let video = _prefixId.prefix "video"
    /// <summary>
    ///   <para>rdfs:comment : Les données de connexion Wifi.</para>
    ///   <para>rdfs:label : wifi^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#wifi">identity:wifi</a>
    /// </summary>
    let wifi = _prefixId.prefix "wifi"
    /// <summary>
    ///   <para>rdfs:label : ymdDay^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ymdDay">identity:ymdDay</a>
    /// </summary>
    let ymdDay = _prefixId.prefix "ymdDay"
    /// <summary>
    ///   <para>rdfs:label : ymdMonth^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ymdMonth">identity:ymdMonth</a>
    /// </summary>
    let ymdMonth = _prefixId.prefix "ymdMonth"
    /// <summary>
    ///   <para>rdfs:label : ymdMonthYear^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ymdMonthYear">identity:ymdMonthYear</a>
    /// </summary>
    let ymdMonthYear = _prefixId.prefix "ymdMonthYear"
    /// <summary>
    ///   <para>rdfs:label : ymdYear^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ymdYear">identity:ymdYear</a>
    /// </summary>
    let ymdYear = _prefixId.prefix "ymdYear"
    /// <summary>
    ///   <para>rdfs:label : ymdYearMonth^^xsd:string</para>
    ///   <a href="http://www.identity.org/ontologies/identity.owl#ymdYearMonth">identity:ymdYearMonth</a>
    /// </summary>
    let ymdYearMonth = _prefixId.prefix "ymdYearMonth"
