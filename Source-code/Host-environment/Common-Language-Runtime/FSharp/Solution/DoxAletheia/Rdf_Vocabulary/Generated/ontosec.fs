namespace http.www.semanticweb.org.ontologies._2008._11.OntologySecurity.owl.hash

open DoxAletheia

module ontosec =
    let _namespace_name =
        "http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A set of sensitive functions under a named group that can get authorization.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FunctionGroups"></see></summary>
    let FunctionGroups = _prefix "FunctionGroups"
    /// <summary>
    /// Contains permissions related to network data connections.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NetAccessFunctionGroup"></see></summary>
    let NetAccessFunctionGroup = _prefix "NetAccessFunctionGroup"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Offline"></see>
    /// </summary>
    let Offline = _prefix "Offline"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Parallel"></see>
    /// </summary>
    let Parallel = _prefix "Parallel"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateInstallation"></see>
    /// </summary>
    let CertificateInstallation = _prefix "CertificateInstallation"

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateInstallationApplication"></see>
    /// </summary>
    let CertificateInstallationApplication =
        _prefix "CertificateInstallationApplication"

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CardMemory"></see>
    /// </summary>
    let CardMemory = _prefix "CardMemory"
    /// <summary>
    /// Multi Media Card
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SD"></see></summary>
    let SD = _prefix "SD"
    /// <summary>
    /// The software device platform layer
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Platform"></see></summary>
    let Platform = _prefix "Platform"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#2.5G"></see>
    /// </summary>
    let ``_2.5G`` = _prefix "2.5G"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WANetwork"></see>
    /// </summary>
    let WANetwork = _prefix "WANetwork"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#2G"></see>
    /// </summary>
    let _2G = _prefix "2G"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3DES"></see>
    /// </summary>
    let _3DES = _prefix "3DES"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BlockCipherAlgorithm"></see>
    /// </summary>
    let BlockCipherAlgorithm = _prefix "BlockCipherAlgorithm"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3G"></see>
    /// </summary>
    let _3G = _prefix "3G"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3GPP"></see>
    /// </summary>
    let _3GPP = _prefix "3GPP"
    /// <summary>
    /// Organizations and associations providing standards in the mobile field arena.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OrganizationsAndStandards"></see></summary>
    let OrganizationsAndStandards = _prefix "OrganizationsAndStandards"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AES"></see>
    /// </summary>
    let AES = _prefix "AES"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AES_FIPS197"></see>
    /// </summary>
    let AES_FIPS197 = _prefix "AES_FIPS197"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControl"></see>
    /// </summary>
    let AccessControl = _prefix "AccessControl"
    /// <summary>
    /// List of permissions attached to an object.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControlList"></see></summary>
    let AccessControlList = _prefix "AccessControlList"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControlMethods"></see>
    /// </summary>
    let AccessControlMethods = _prefix "AccessControlMethods"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Satisfice"></see>
    /// </summary>
    let Satisfice = _prefix "Satisfice"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Integrity"></see>
    /// </summary>
    let Integrity = _prefix "Integrity"
    /// <summary>
    /// The confidentiality service
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Confidentiality"></see></summary>
    let Confidentiality = _prefix "Confidentiality"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CoreCounterMeasure"></see>
    /// </summary>
    let CoreCounterMeasure = _prefix "CoreCounterMeasure"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ActiveThreat"></see>
    /// </summary>
    let ActiveThreat = _prefix "ActiveThreat"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ThreatType"></see>
    /// </summary>
    let ThreatType = _prefix "ThreatType"
    /// <summary>
    /// Actors participating in the realisation and implementation of security services
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Actor"></see></summary>
    let Actor = _prefix "Actor"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Add-OnMemory"></see>
    /// </summary>
    let ``Add-OnMemory`` = _prefix "Add-OnMemory"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Memory"></see>
    /// </summary>
    let Memory = _prefix "Memory"
    /// <summary>
    /// New tools that should be used for the projection or the application.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AdditionalTools"></see></summary>
    let AdditionalTools = _prefix "AdditionalTools"
    /// <summary>
    /// Time, skills, additional equipments are considered as cost constraints
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Cost"></see></summary>
    let Cost = _prefix "Cost"
    /// <summary>
    /// Tasks to be performed and which are out of the scope of the technical field.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AdministrativeProcedure"></see></summary>
    let AdministrativeProcedure = _prefix "AdministrativeProcedure"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Algorithm"></see>
    /// </summary>
    let Algorithm = _prefix "Algorithm"
    /// <summary>
    /// Security mechanisms used for security services
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mechanism"></see></summary>
    let Mechanism = _prefix "Mechanism"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AnalysisPhase"></see>
    /// </summary>
    let AnalysisPhase = _prefix "AnalysisPhase"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationLifeCyclePhase"></see>
    /// </summary>
    let ApplicationLifeCyclePhase = _prefix "ApplicationLifeCyclePhase"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Android"></see>
    /// </summary>
    let Android = _prefix "Android"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Application"></see>
    /// </summary>
    let Application = _prefix "Application"
    /// <summary>
    /// All the applications and data provided with or installed on the device.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationData"></see>
    /// </summary>
    let ApplicationData = _prefix "ApplicationData"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Data"></see>
    /// </summary>
    let Data = _prefix "Data"
    /// <summary>
    /// Additional and required types for the ontology
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ValueTypes"></see></summary>
    let ValueTypes = _prefix "ValueTypes"
    /// <summary>
    /// The application server side may be a web server or a data base back end that the device connects to.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationServerSide"></see></summary>
    let ApplicationServerSide = _prefix "ApplicationServerSide"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Backup"></see>
    /// </summary>
    let Backup = _prefix "Backup"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementMechanism"></see>
    /// </summary>
    let ImplementMechanism = _prefix "ImplementMechanism"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Journaling"></see>
    /// </summary>
    let Journaling = _prefix "Journaling"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AppliedTo"></see>
    /// </summary>
    let AppliedTo = _prefix "AppliedTo"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Relationship"></see>
    /// </summary>
    let Relationship = _prefix "Relationship"
    /// <summary>
    /// The set of assets that should be protected
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Asset"></see></summary>
    let Asset = _prefix "Asset"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AssociatedOriented"></see>
    /// </summary>
    let AssociatedOriented = _prefix "AssociatedOriented"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonRepudiationType"></see>
    /// </summary>
    let NonRepudiationType = _prefix "NonRepudiationType"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AsymmetricAlgorithm"></see>
    /// </summary>
    let AsymmetricAlgorithm = _prefix "AsymmetricAlgorithm"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PrivateKey"></see>
    /// </summary>
    let PrivateKey = _prefix "PrivateKey"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PublicKey"></see>
    /// </summary>
    let PublicKey = _prefix "PublicKey"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Use"></see>
    /// </summary>
    let Use = _prefix "Use"
    /// <summary>
    /// Best use of the available resources.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Efficiency"></see></summary>
    let Efficiency = _prefix "Efficiency"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Hurt"></see>
    /// </summary>
    let Hurt = _prefix "Hurt"
    /// <summary>
    /// Type of encryption in which an encryption key (the public key) is used to encrypt a message, and another encryption key (the private key) is used to decrypt the message.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AsymmetricEncryption"></see></summary>
    let AsymmetricEncryption = _prefix "AsymmetricEncryption"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyExchangeProtocol"></see>
    /// </summary>
    let KeyExchangeProtocol = _prefix "KeyExchangeProtocol"
    /// <summary>
    /// Discipline which embodies principles, means, and methods for the transformation of data in order to hide its information content, prevent its undetected modification and/or prevent its unauthorised use. (CCITT)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Encryption"></see></summary>
    let Encryption = _prefix "Encryption"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Authentication"></see>
    /// </summary>
    let Authentication = _prefix "Authentication"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DomainEntities"></see>
    /// </summary>
    let DomainEntities = _prefix "DomainEntities"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationLevel"></see>
    /// </summary>
    let AuthenticationLevel = _prefix "AuthenticationLevel"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasLevel"></see>
    /// </summary>
    let hasLevel = _prefix "hasLevel"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationProtocol"></see>
    /// </summary>
    let AuthenticationProtocol = _prefix "AuthenticationProtocol"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationProtocolType"></see>
    /// </summary>
    let AuthenticationProtocolType = _prefix "AuthenticationProtocolType"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasAuthenticationProtocolType"></see>
    /// </summary>
    let hasAuthenticationProtocolType = _prefix "hasAuthenticationProtocolType"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IndustrialProtocol"></see>
    /// </summary>
    let IndustrialProtocol = _prefix "IndustrialProtocol"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationToken"></see>
    /// </summary>
    let AuthenticationToken = _prefix "AuthenticationToken"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationWay"></see>
    /// </summary>
    let AuthenticationWay = _prefix "AuthenticationWay"
    /// <summary>
    /// Permissions related to automatically starting a MIDlet, for example by Push Registration.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AutoInvocationFunctionGroup"></see></summary>
    let AutoInvocationFunctionGroup = _prefix "AutoInvocationFunctionGroup"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Availability"></see>
    /// </summary>
    let Availability = _prefix "Availability"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Duration"></see>
    /// </summary>
    let Duration = _prefix "Duration"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDuration"></see>
    /// </summary>
    let hasDuration = _prefix "hasDuration"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Techniques"></see>
    /// </summary>
    let Techniques = _prefix "Techniques"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BatteryMonitor"></see>
    /// </summary>
    let BatteryMonitor = _prefix "BatteryMonitor"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ResourceMonitoring"></see>
    /// </summary>
    let ResourceMonitoring = _prefix "ResourceMonitoring"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BestPractises"></see>
    /// </summary>
    let BestPractises = _prefix "BestPractises"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Standards"></see>
    /// </summary>
    let Standards = _prefix "Standards"
    /// <summary>
    /// Biometric identifier is one of the most secure and more reliable ways to authenticate a person’s identity is to verify that person’s innate biological characteristics, which are referred to as biometrics. Each person’s fingerprints, DNA, iris and retinal cell patterns, facial geometry, and heat signature are near unique to that person. These biometric measures, if properly recorded, validated, and embedded in identity credentials that are logically bound to a single person’s identity, can provide the highest degree of identity authentication (From NIST information security Report)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BiometricIdentifier"></see></summary>
    let BiometricIdentifier = _prefix "BiometricIdentifier"
    /// <summary>
    /// ability of Application running on several devices or/and platforms.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Portability"></see></summary>
    let Portability = _prefix "Portability"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Resource"></see>
    /// </summary>
    let Resource = _prefix "Resource"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasPadding"></see>
    /// </summary>
    let hasPadding = _prefix "hasPadding"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ChainingMode"></see>
    /// </summary>
    let ChainingMode = _prefix "ChainingMode"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasChainingMode"></see>
    /// </summary>
    let hasChainingMode = _prefix "hasChainingMode"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasInitialisationVector"></see>
    /// </summary>
    let hasInitialisationVector = _prefix "hasInitialisationVector"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasBlockSize"></see>
    /// </summary>
    let HasBlockSize = _prefix "HasBlockSize"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricAlgorithm"></see>
    /// </summary>
    let SymmetricAlgorithm = _prefix "SymmetricAlgorithm"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Blowfish"></see>
    /// </summary>
    let Blowfish = _prefix "Blowfish"
    /// <summary>
    /// Bluetooth is a Personal Area Network (PAN) standard that enables wireless connections between electronic devices in the 2.4 GHz range over short distances, as an alternative to cables. Designed to be power efficient, Bluetooth has become a common feature in cell phones. Since wireless communications are inherently insecure, a number of basic security provisions have been defined for this standard to mitigate the risks involved. NIST
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Bluetooth"></see></summary>
    let Bluetooth = _prefix "Bluetooth"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PANetwork"></see>
    /// </summary>
    let PANetwork = _prefix "PANetwork"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Break"></see>
    /// </summary>
    let Break = _prefix "Break"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#QualitySatisfaction"></see>
    /// </summary>
    let QualitySatisfaction = _prefix "QualitySatisfaction"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ByPassingTrialCounter"></see>
    /// </summary>
    let ByPassingTrialCounter = _prefix "ByPassingTrialCounter"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CBC"></see>
    /// </summary>
    let CBC = _prefix "CBC"
    /// <summary>
    /// The simplest way to make a key-dependent one-way hash function is to encrypt a message with a block algorithm in CBC or CFB modes . The hash is the last encrypted block, encrypted once more in CBC or CFB modes.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CBC-MAC"></see></summary>
    let ``CBC-MAC`` = _prefix "CBC-MAC"
    /// <summary>
    /// Message authentication code that include a key for authentication
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MACAlgorithm"></see></summary>
    let MACAlgorithm = _prefix "MACAlgorithm"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CFB"></see>
    /// </summary>
    let CFB = _prefix "CFB"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#COMSET"></see>
    /// </summary>
    let COMSET = _prefix "COMSET"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CardType"></see>
    /// </summary>
    let CardType = _prefix "CardType"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Certificate"></see>
    /// </summary>
    let Certificate = _prefix "Certificate"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasValidity"></see>
    /// </summary>
    let hasValidity = _prefix "hasValidity"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalSignatureAlgorithm"></see>
    /// </summary>
    let DigitalSignatureAlgorithm = _prefix "DigitalSignatureAlgorithm"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasSignatureAlgorithm"></see>
    /// </summary>
    let hasSignatureAlgorithm = _prefix "hasSignatureAlgorithm"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasSubjectName"></see>
    /// </summary>
    let hasSubjectName = _prefix "hasSubjectName"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDigitalSignatureData"></see>
    /// </summary>
    let hasDigitalSignatureData = _prefix "hasDigitalSignatureData"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateFormat"></see>
    /// </summary>
    let CertificateFormat = _prefix "CertificateFormat"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasFormat"></see>
    /// </summary>
    let hasFormat = _prefix "hasFormat"
    /// <summary>
    /// The certification authority provides certificates to bind a set of informations (name, serial number, ...) to a public key.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificationAuthority"></see></summary>
    let CertificationAuthority = _prefix "CertificationAuthority"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIssuer"></see>
    /// </summary>
    let hasIssuer = _prefix "hasIssuer"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceCapabilities"></see>
    /// </summary>
    let DeviceCapabilities = _prefix "DeviceCapabilities"
    /// <summary>
    /// security authority or its agent, trusted by other entities with respect to security-related activities. In the context of ISO/IEC 9798, a trusted third party is trusted by a claimant and/or a verifier for the purposes of authentication.  ISO/IEC 9798
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedThirdParty"></see></summary>
    let TrustedThirdParty = _prefix "TrustedThirdParty"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ChallengeReplyPassword"></see>
    /// </summary>
    let ChallengeReplyPassword = _prefix "ChallengeReplyPassword"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Checksum"></see>
    /// </summary>
    let Checksum = _prefix "Checksum"
    /// <summary>
    /// Locate and isolate critical code from from general code.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CodeSeparation"></see></summary>
    let CodeSeparation = _prefix "CodeSeparation"
    /// <summary>
    /// Deploy development regimes such as coding standards and documentation methodologies to lead to best practises
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CodingStandards"></see></summary>
    let CodingStandards = _prefix "CodingStandards"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CombinedDelivery-DRM"></see>
    /// </summary>
    let ``CombinedDelivery-DRM`` = _prefix "CombinedDelivery-DRM"
    /// <summary>
    /// A general framework for downloading Rights to Devices and sharing Rights in a domain. DRM is invented by the Open Mobile Alliance whose members are mobile phone manufacturers, mobile system manufacturers, operators , and sofware editors.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalRightsManagement"></see></summary>
    let DigitalRightsManagement = _prefix "DigitalRightsManagement"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CommChannel"></see>
    /// </summary>
    let CommChannel = _prefix "CommChannel"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CompactFlash"></see>
    /// </summary>
    let CompactFlash = _prefix "CompactFlash"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ConfidentialityLevel"></see>
    /// </summary>
    let ConfidentialityLevel = _prefix "ConfidentialityLevel"
    /// <summary>
    /// Several configuration data are stored in the device or sent by the mobile operator.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ConfigurationData"></see></summary>
    let ConfigurationData = _prefix "ConfigurationData"
    /// <summary>
    /// Technical, quality constraints and others
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Constraints"></see></summary>
    let Constraints = _prefix "Constraints"
    /// <summary>
    /// The entity who is responsable of providing content like ringing tones or multimedia files or any other software.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ContentProvider"></see></summary>
    let ContentProvider = _prefix "ContentProvider"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Provide"></see>
    /// </summary>
    let Provide = _prefix "Provide"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Correction"></see>
    /// </summary>
    let Correction = _prefix "Correction"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MechanismType"></see>
    /// </summary>
    let MechanismType = _prefix "MechanismType"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Critical"></see>
    /// </summary>
    let Critical = _prefix "Critical"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CryptographicHashFunction"></see>
    /// </summary>
    let CryptographicHashFunction = _prefix "CryptographicHashFunction"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasOutputLength"></see>
    /// </summary>
    let HasOutputLength = _prefix "HasOutputLength"
    /// <summary>
    /// A function that takes a string (or message) of any length as input and produces a fixed-length string as output,it is used for authentication and message integrity.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MessageDigest"></see></summary>
    let MessageDigest = _prefix "MessageDigest"
    /// <summary>
    /// Distributed denial of service.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DDos"></see></summary>
    let DDos = _prefix "DDos"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DES"></see>
    /// </summary>
    let DES = _prefix "DES"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DES_FIPS46-1-2"></see>
    /// </summary>
    let ``DES_FIPS46-1-2`` = _prefix "DES_FIPS46-1-2"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DIFFIE-HELLMAN"></see>
    /// </summary>
    let ``DIFFIE-HELLMAN`` = _prefix "DIFFIE-HELLMAN"
    /// <summary>
    /// Digital Signature Algorithm specified by FIPS 186-2
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DSA"></see></summary>
    let DSA = _prefix "DSA"
    /// <summary>
    /// Some applications use records files to store data.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DataRecords"></see></summary>
    let DataRecords = _prefix "DataRecords"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalFiles"></see>
    /// </summary>
    let LocalFiles = _prefix "LocalFiles"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeploymentPhase"></see>
    /// </summary>
    let DeploymentPhase = _prefix "DeploymentPhase"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DesignPhase"></see>
    /// </summary>
    let DesignPhase = _prefix "DesignPhase"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Detection"></see>
    /// </summary>
    let Detection = _prefix "Detection"
    /// <summary>
    /// Addiotional development time required for the application or the project.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DevelopmentTime"></see></summary>
    let DevelopmentTime = _prefix "DevelopmentTime"
    /// <summary>
    /// Mobile terminal equiped with processing capabilities offering  connection to wireless networks.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasMemory"></see>
    /// </summary>
    let hasMemory = _prefix "hasMemory"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Network"></see>
    /// </summary>
    let Network = _prefix "Network"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetwork"></see>
    /// </summary>
    let hasNetwork = _prefix "hasNetwork"
    /// <summary>
    /// Keypad or any input tool
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Input"></see></summary>
    let Input = _prefix "Input"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasInput"></see>
    /// </summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceLock"></see>
    /// </summary>
    let DeviceLock = _prefix "DeviceLock"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LogInSystem"></see>
    /// </summary>
    let LogInSystem = _prefix "LogInSystem"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIMEI"></see>
    /// </summary>
    let hasIMEI = _prefix "hasIMEI"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Processing"></see>
    /// </summary>
    let Processing = _prefix "Processing"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasProcessing"></see>
    /// </summary>
    let hasProcessing = _prefix "hasProcessing"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Output"></see>
    /// </summary>
    let Output = _prefix "Output"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasOutput"></see>
    /// </summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceCloning"></see>
    /// </summary>
    let DeviceCloning = _prefix "DeviceCloning"
    /// <summary>
    /// One problem in this area is that drivers are typically written by third parties and drivers are upgraded at different times to the main OS. This causes problems when implementing any validation scheme, or even isolated checking of specific software updates
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceDriverUpgrade"></see></summary>
    let DeviceDriverUpgrade = _prefix "DeviceDriverUpgrade"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LockingMechanism"></see>
    /// </summary>
    let LockingMechanism = _prefix "LockingMechanism"
    /// <summary>
    /// A digital signature is represented in a computer as a string of binary
    /// digits. A digital signature is computed using a set of rules and a set of parameters such that the identity of the signatory and integrity of the data can be verified. An algorithm provides the capability to generate and verify signatures. Signature generation makes use of a private key to generate a digital signature. Signature verification makes use of a public key which corresponds to, but is not the same as, the private key. (http://csrc.nist.gov/publications/fips/fips186-2/fips186-2-change1.pdf)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalSignature"></see></summary>
    let DigitalSignature = _prefix "DigitalSignature"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonRepudiation"></see>
    /// </summary>
    let NonRepudiation = _prefix "NonRepudiation"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DisplayScreen"></see>
    /// </summary>
    let DisplayScreen = _prefix "DisplayScreen"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasScreenSize"></see>
    /// </summary>
    let hasScreenSize = _prefix "hasScreenSize"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DotNet"></see>
    /// </summary>
    let DotNet = _prefix "DotNet"
    /// <summary>
    /// Electronic code book
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ECB"></see></summary>
    let ECB = _prefix "ECB"
    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm (ECDSA) (ANSI X9-62)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ECDSA"></see></summary>
    let ECDSA = _prefix "ECDSA"
    /// <summary>
    /// Enhanced Data rates for GSM Evolution
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EDGE"></see></summary>
    let EDGE = _prefix "EDGE"
    /// <summary>
    /// Enhanced Messaging Service - An improved message system for GSM mobile phones allowing picture, sound, animation and text elements to be conveyed through one or more concatenated SMS messages. NIST
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EMS"></see></summary>
    let EMS = _prefix "EMS"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Messaging"></see>
    /// </summary>
    let Messaging = _prefix "Messaging"
    /// <summary>
    /// A good response time of the application.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Usability"></see></summary>
    let Usability = _prefix "Usability"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ElGammelAlgorithm"></see>
    /// </summary>
    let ElGammelAlgorithm = _prefix "ElGammelAlgorithm"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Email"></see>
    /// </summary>
    let Email = _prefix "Email"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Internet"></see>
    /// </summary>
    let Internet = _prefix "Internet"
    /// <summary>
    /// Pseudo Random Number Generation algorithm
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PRNGAlgorithm"></see></summary>
    let PRNGAlgorithm = _prefix "PRNGAlgorithm"
    /// <summary>
    /// The encryption keys are digital bitstrings that are stored in non-volatile memory, and verification of the identity proceeds by a challenge-response protocol.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EncryptionKeys"></see></summary>
    let EncryptionKeys = _prefix "EncryptionKeys"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Keys"></see>
    /// </summary>
    let Keys = _prefix "Keys"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EndToEnd"></see>
    /// </summary>
    let EndToEnd = _prefix "EndToEnd"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Excellent"></see>
    /// </summary>
    let Excellent = _prefix "Excellent"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RNGEfficiency"></see>
    /// </summary>
    let RNGEfficiency = _prefix "RNGEfficiency"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FTP"></see>
    /// </summary>
    let FTP = _prefix "FTP"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FixedMemory"></see>
    /// </summary>
    let FixedMemory = _prefix "FixedMemory"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ForwardLock-DRM"></see>
    /// </summary>
    let ``ForwardLock-DRM`` = _prefix "ForwardLock-DRM"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FullIntegrity"></see>
    /// </summary>
    let FullIntegrity = _prefix "FullIntegrity"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IntegrityType"></see>
    /// </summary>
    let IntegrityType = _prefix "IntegrityType"
    /// <summary>
    /// General Packet Radio Service
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPRS"></see></summary>
    let GPRS = _prefix "GPRS"
    /// <summary>
    /// A system for determining position by comparing radio signals from several satellites. NIST
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPSNetwork"></see></summary>
    let GPSNetwork = _prefix "GPSNetwork"
    /// <summary>
    /// Global positioning system coordinates used by some applications.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPSvalues"></see></summary>
    let GPSvalues = _prefix "GPSvalues"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalisationData"></see>
    /// </summary>
    let LocalisationData = _prefix "LocalisationData"
    /// <summary>
    /// Global System for Mobile communications
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSM"></see></summary>
    let GSM = _prefix "GSM"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSMA"></see>
    /// </summary>
    let GSMA = _prefix "GSMA"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSMWorld"></see>
    /// </summary>
    let GSMWorld = _prefix "GSMWorld"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GuessingAttack"></see>
    /// </summary>
    let GuessingAttack = _prefix "GuessingAttack"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HMAC"></see>
    /// </summary>
    let HMAC = _prefix "HMAC"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HTTP"></see>
    /// </summary>
    let HTTP = _prefix "HTTP"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HTTPS"></see>
    /// </summary>
    let HTTPS = _prefix "HTTPS"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecureNetworkCommunication"></see>
    /// </summary>
    let SecureNetworkCommunication = _prefix "SecureNetworkCommunication"
    /// <summary>
    /// Mainly the physical device with the embedded memory and processing units.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Hardware"></see></summary>
    let Hardware = _prefix "Hardware"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HardwareLocking"></see>
    /// </summary>
    let HardwareLocking = _prefix "HardwareLocking"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasBandwidth"></see>
    /// </summary>
    let HasBandwidth = _prefix "HasBandwidth"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasIterationNumber"></see>
    /// </summary>
    let HasIterationNumber = _prefix "HasIterationNumber"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasKeySize"></see>
    /// </summary>
    let HasKeySize = _prefix "HasKeySize"
    /// <summary>
    /// A server side list of hashed tokens is stored and each consumed token is removed from the list.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HashBasedOTP"></see></summary>
    let HashBasedOTP = _prefix "HashBasedOTP"
    /// <summary>
    /// Password used for once and generated from time, counter and/or key. May be a displayed from a hardware device.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#O.T.P"></see></summary>
    let ``O.T.P`` = _prefix "O.T.P"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Help"></see>
    /// </summary>
    let Help = _prefix "Help"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IEEE"></see>
    /// </summary>
    let IEEE = _prefix "IEEE"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IETF"></see>
    /// </summary>
    let IETF = _prefix "IETF"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IM"></see>
    /// </summary>
    let IM = _prefix "IM"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IPSec"></see>
    /// </summary>
    let IPSec = _prefix "IPSec"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ITU"></see>
    /// </summary>
    let ITU = _prefix "ITU"
    /// <summary>
    /// All supported image files for mobile devices.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Images"></see></summary>
    let Images = _prefix "Images"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementAPI"></see>
    /// </summary>
    let ImplementAPI = _prefix "ImplementAPI"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementationPhase"></see>
    /// </summary>
    let ImplementationPhase = _prefix "ImplementationPhase"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IntensifyCriticalCodeReview"></see>
    /// </summary>
    let IntensifyCriticalCodeReview = _prefix "IntensifyCriticalCodeReview"
    /// <summary>
    /// User interaction to confirm the execution of some senstive actions like sending a sms or opening a network connection/
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#InteractionModes"></see></summary>
    let InteractionModes = _prefix "InteractionModes"
    /// <summary>
    /// A standard for line-of-sight infrared communication between devices over short distances. NIST
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IrDA"></see></summary>
    let IrDA = _prefix "IrDA"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Issue"></see>
    /// </summary>
    let Issue = _prefix "Issue"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#J2ME"></see>
    /// </summary>
    let J2ME = _prefix "J2ME"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JME"></see>
    /// </summary>
    let JME = _prefix "JME"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JMEPermissionDomains"></see>
    /// </summary>
    let JMEPermissionDomains = _prefix "JMEPermissionDomains"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JavaCard"></see>
    /// </summary>
    let JavaCard = _prefix "JavaCard"
    /// <summary>
    /// Subscriber Identity Module; A smart card for GSM networks access.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SIM"></see></summary>
    let SIM = _prefix "SIM"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JavaVerifiedSigningProcess"></see>
    /// </summary>
    let JavaVerifiedSigningProcess = _prefix "JavaVerifiedSigningProcess"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SourceCodeVerification"></see>
    /// </summary>
    let SourceCodeVerification = _prefix "SourceCodeVerification"
    /// <summary>
    /// Kerberos is an authentication process that proceeds as follows: A client sends a request to the authentication server (AS) requesting "credentials" for a given server.  The AS responds with these credentials,  encrypted in the client's key.  The credentials consist of 1) a "ticket" for the server and 2) a temporary encryption key ( a "session key").  The client transmits the ticket (which contains the client's identity and a copy of the session key, all encrypted in the server's key) to the server.  The session key (now shared by the client and server) is used to authenticate the client, and may optionally be used to authenticate the server.  It may also be used to encrypt further communication between the two parties or to exchange a separate sub-session key to be used to encrypt further communication. RFC 1510
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Kerberos"></see></summary>
    let Kerberos = _prefix "Kerberos"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyExchange"></see>
    /// </summary>
    let KeyExchange = _prefix "KeyExchange"
    /// <summary>
    /// The process and procedure for safely storing and distributing accurate cryptographic keys; the overall process of generating and distributing cryptographic key to authorized recipients in a secure manner.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyManagement"></see></summary>
    let KeyManagement = _prefix "KeyManagement"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyGeneration"></see>
    /// </summary>
    let KeyGeneration = _prefix "KeyGeneration"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasRNGEfficiency"></see>
    /// </summary>
    let hasRNGEfficiency = _prefix "hasRNGEfficiency"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasRNGDeterminism"></see>
    /// </summary>
    let hasRNGDeterminism = _prefix "hasRNGDeterminism"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyPad"></see>
    /// </summary>
    let KeyPad = _prefix "KeyPad"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyStore"></see>
    /// </summary>
    let KeyStore = _prefix "KeyStore"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Store"></see>
    /// </summary>
    let Store = _prefix "Store"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasKeyLifeTime"></see>
    /// </summary>
    let hasKeyLifeTime = _prefix "hasKeyLifeTime"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LANetwork"></see>
    /// </summary>
    let LANetwork = _prefix "LANetwork"
    /// <summary>
    /// Easy to learn how to use the application.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Learnability"></see></summary>
    let Learnability = _prefix "Learnability"
    /// <summary>
    /// Special database management systems for embedded applications.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalDataBase"></see></summary>
    let LocalDataBase = _prefix "LocalDataBase"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalDeviceLock"></see>
    /// </summary>
    let LocalDeviceLock = _prefix "LocalDeviceLock"
    /// <summary>
    /// In some situations it is useful to lock the screen display until a task is terminated. This is technique is used to avoid the screen modification until a answer is received.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LockingScreen"></see></summary>
    let LockingScreen = _prefix "LockingScreen"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecretKey"></see>
    /// </summary>
    let SecretKey = _prefix "SecretKey"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD2"></see>
    /// </summary>
    let MD2 = _prefix "MD2"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD4"></see>
    /// </summary>
    let MD4 = _prefix "MD4"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD5"></see>
    /// </summary>
    let MD5 = _prefix "MD5"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MMC"></see>
    /// </summary>
    let MMC = _prefix "MMC"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MMS"></see>
    /// </summary>
    let MMS = _prefix "MMS"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MULTOS"></see>
    /// </summary>
    let MULTOS = _prefix "MULTOS"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mail"></see>
    /// </summary>
    let Mail = _prefix "Mail"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Manual"></see>
    /// </summary>
    let Manual = _prefix "Manual"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MaintenancePhase"></see>
    /// </summary>
    let MaintenancePhase = _prefix "MaintenancePhase"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Make"></see>
    /// </summary>
    let Make = _prefix "Make"
    /// <summary>
    /// Mobile device manufacturer which may implement some security features in the device
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Manufacturer"></see></summary>
    let Manufacturer = _prefix "Manufacturer"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasTrustIn"></see>
    /// </summary>
    let hasTrustIn = _prefix "hasTrustIn"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ManufacturerCertificate"></see>
    /// </summary>
    let ManufacturerCertificate = _prefix "ManufacturerCertificate"
    /// <summary>
    /// A limited period of time during which the use of the application will be memorised.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Memorability"></see></summary>
    let Memorability = _prefix "Memorability"
    /// <summary>
    /// Memory card can be protected with a password each time someone tries to access the card
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MemoryCardLock"></see></summary>
    let MemoryCardLock = _prefix "MemoryCardLock"
    /// <summary>
    /// Set of permissions related to sending or receiving messages like SMS
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MessagingFunctionsGroup"></see></summary>
    let MessagingFunctionsGroup = _prefix "MessagingFunctionsGroup"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MisUseAttack"></see>
    /// </summary>
    let MisUseAttack = _prefix "MisUseAttack"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnTrustedAPIAttack"></see>
    /// </summary>
    let UnTrustedAPIAttack = _prefix "UnTrustedAPIAttack"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobeyForum"></see>
    /// </summary>
    let MobeyForum = _prefix "MobeyForum"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mobile2Market"></see>
    /// </summary>
    let Mobile2Market = _prefix "Mobile2Market"
    /// <summary>
    /// Mobile network Cell ID to which the device is attached.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobileNetworkProvidervalues"></see></summary>
    let MobileNetworkProvidervalues = _prefix "MobileNetworkProvidervalues"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobileVPN"></see>
    /// </summary>
    let MobileVPN = _prefix "MobileVPN"
    /// <summary>
    /// Virtula private network. FIPS 140-2
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VPN"></see></summary>
    let VPN = _prefix "VPN"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MotorollaMobileVPN"></see>
    /// </summary>
    let MotorollaMobileVPN = _prefix "MotorollaMobileVPN"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mutual"></see>
    /// </summary>
    let Mutual = _prefix "Mutual"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MutualReliableChannel"></see>
    /// </summary>
    let MutualReliableChannel = _prefix "MutualReliableChannel"
    /// <summary>
    /// A short-range point-to-point wireless communication technology. The technology is a simple extension of the ISO/IEC 14443 proximity-card standard (contactless card, RFID) that combines the interface of a smartcard and a reader into a single device. An NFC device can communicate with both existing ISO/IEC 14443 smartcards and readers, as well as with other NFC devices, and is thereby compatible with existing contactless infrastructure already in use for public transportation and payment.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NFC"></see></summary>
    let NFC = _prefix "NFC"
    /// <summary>
    /// The device may be or not equiped with Near Field Communication Ship (NFC).
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NFCEnabled"></see></summary>
    let NFCEnabled = _prefix "NFCEnabled"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NIST"></see>
    /// </summary>
    let NIST = _prefix "NIST"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NeedhamShroeder"></see>
    /// </summary>
    let NeedhamShroeder = _prefix "NeedhamShroeder"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetworkLatency"></see>
    /// </summary>
    let hasNetworkLatency = _prefix "hasNetworkLatency"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NetworkLayer"></see>
    /// </summary>
    let NetworkLayer = _prefix "NetworkLayer"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityLayer"></see>
    /// </summary>
    let SecurityLayer = _prefix "SecurityLayer"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NoAuthentication"></see>
    /// </summary>
    let NoAuthentication = _prefix "NoAuthentication"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NoSensitiveInfoOnExternalMemory"></see>
    /// </summary>
    let NoSensitiveInfoOnExternalMemory = _prefix "NoSensitiveInfoOnExternalMemory"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Nokia_Mobile_VPN"></see>
    /// </summary>
    let Nokia_Mobile_VPN = _prefix "Nokia_Mobile_VPN"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasType"></see>
    /// </summary>
    let hasType = _prefix "hasType"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonVolatile"></see>
    /// </summary>
    let NonVolatile = _prefix "NonVolatile"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Password"></see>
    /// </summary>
    let Password = _prefix "Password"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OperationMode"></see>
    /// </summary>
    let OperationMode = _prefix "OperationMode"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OneSideVerification"></see>
    /// </summary>
    let OneSideVerification = _prefix "OneSideVerification"
    /// <summary>
    /// Telecom Network Operator knowing as MNO
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Operator"></see></summary>
    let Operator = _prefix "Operator"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OperatorCertificate"></see>
    /// </summary>
    let OperatorCertificate = _prefix "OperatorCertificate"
    /// <summary>
    /// A smart card is any limited-sized card with embedded integrated circuits. The smart card may integrate or not processing capabilities.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCard"></see></summary>
    let SmartCard = _prefix "SmartCard"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#storedOn"></see>
    /// </summary>
    let storedOn = _prefix "storedOn"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PGPCertificate"></see>
    /// </summary>
    let PGPCertificate = _prefix "PGPCertificate"
    /// <summary>
    /// Personal Identification Number
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PIN"></see></summary>
    let PIN = _prefix "PIN"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardLock"></see>
    /// </summary>
    let SmartCardLock = _prefix "SmartCardLock"
    /// <summary>
    /// Public-key infrastructure (PKI) consists of protocols, services, and standards supporting applications of public-key cryptography. PKI sometimes refers simply to a trust hierarchy based on public-key certificates, and in other contexts embraces encryption and digital signature services provided to end-user applications as well. RSA (http://www.rsa.com/rsalabs/node.asp?id=2268)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PKI"></see></summary>
    let PKI = _prefix "PKI"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityInfrastructure"></see>
    /// </summary>
    let SecurityInfrastructure = _prefix "SecurityInfrastructure"
    /// <summary>
    /// Pseudo Random Number Generation
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PRNG"></see></summary>
    let PRNG = _prefix "PRNG"
    /// <summary>
    /// Personal Unblocking Keys
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PUK"></see></summary>
    let PUK = _prefix "PUK"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PassiveThreat"></see>
    /// </summary>
    let PassiveThreat = _prefix "PassiveThreat"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Performance"></see>
    /// </summary>
    let Performance = _prefix "Performance"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Phishing"></see>
    /// </summary>
    let Phishing = _prefix "Phishing"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PhysicalLayer"></see>
    /// </summary>
    let PhysicalLayer = _prefix "PhysicalLayer"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Poor"></see>
    /// </summary>
    let Poor = _prefix "Poor"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Quality"></see>
    /// </summary>
    let Quality = _prefix "Quality"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PreemptDisplay"></see>
    /// </summary>
    let PreemptDisplay = _prefix "PreemptDisplay"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Prevention"></see>
    /// </summary>
    let Prevention = _prefix "Prevention"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PrivateKeyPoP"></see>
    /// </summary>
    let PrivateKeyPoP = _prefix "PrivateKeyPoP"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Public"></see>
    /// </summary>
    let Public = _prefix "Public"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RAM"></see>
    /// </summary>
    let RAM = _prefix "RAM"
    /// <summary>
    /// A free algorithm provided by  RSA security, implemented since 1970.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RC4"></see></summary>
    let RC4 = _prefix "RC4"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StreamCipherAlgorithm"></see>
    /// </summary>
    let StreamCipherAlgorithm = _prefix "StreamCipherAlgorithm"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RF"></see>
    /// </summary>
    let RF = _prefix "RF"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RIPE-MAC"></see>
    /// </summary>
    let ``RIPE-MAC`` = _prefix "RIPE-MAC"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RIPE-MD"></see>
    /// </summary>
    let ``RIPE-MD`` = _prefix "RIPE-MD"
    /// <summary>
    /// Record Management Store are data structure used to store JME data
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RMS"></see></summary>
    let RMS = _prefix "RMS"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ROM"></see>
    /// </summary>
    let ROM = _prefix "ROM"
    /// <summary>
    /// RSA signature algorithm (American National Standard ANSI X9-31)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RSA"></see></summary>
    let RSA = _prefix "RSA"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RSAAlgorithm"></see>
    /// </summary>
    let RSAAlgorithm = _prefix "RSAAlgorithm"
    /// <summary>
    /// Read User Data: Set of permissions to read user’s data like phone book or calendar entries
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ReadUserDataFunctionGroup"></see></summary>
    let ReadUserDataFunctionGroup = _prefix "ReadUserDataFunctionGroup"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Recovery"></see>
    /// </summary>
    let Recovery = _prefix "Recovery"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ReduceCodeSize"></see>
    /// </summary>
    let ReduceCodeSize = _prefix "ReduceCodeSize"
    /// <summary>
    /// Registration authority is an administrative entity which is responsable of verifying the identity of the claimer of a certificate
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RegistrationAuthority"></see></summary>
    let RegistrationAuthority = _prefix "RegistrationAuthority"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Reliability"></see>
    /// </summary>
    let Reliability = _prefix "Reliability"
    /// <summary>
    /// Sending a Short message to lock the device
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RemoteDeviceLock"></see></summary>
    let RemoteDeviceLock = _prefix "RemoteDeviceLock"
    /// <summary>
    /// Audio files used as rings in mobile devices.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RingTones"></see></summary>
    let RingTones = _prefix "RingTones"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StandardFiles"></see>
    /// </summary>
    let StandardFiles = _prefix "StandardFiles"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SANS_Institute"></see>
    /// </summary>
    let SANS_Institute = _prefix "SANS_Institute"
    /// <summary>
    /// Secure Electronic Transaction
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SET"></see></summary>
    let SET = _prefix "SET"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SHA1"></see>
    /// </summary>
    let SHA1 = _prefix "SHA1"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SHAMIR3Pass"></see>
    /// </summary>
    let SHAMIR3Pass = _prefix "SHAMIR3Pass"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SKID"></see>
    /// </summary>
    let SKID = _prefix "SKID"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SMS"></see>
    /// </summary>
    let SMS = _prefix "SMS"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SNOW"></see>
    /// </summary>
    let SNOW = _prefix "SNOW"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SSL"></see>
    /// </summary>
    let SSL = _prefix "SSL"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#STRANDOM"></see>
    /// </summary>
    let STRANDOM = _prefix "STRANDOM"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Secret"></see>
    /// </summary>
    let Secret = _prefix "Secret"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityTools"></see>
    /// </summary>
    let SecurityTools = _prefix "SecurityTools"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SemanticIntegrity"></see>
    /// </summary>
    let SemanticIntegrity = _prefix "SemanticIntegrity"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SeparateDelivery-DRM"></see>
    /// </summary>
    let ``SeparateDelivery-DRM`` = _prefix "SeparateDelivery-DRM"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Session"></see>
    /// </summary>
    let Session = _prefix "Session"
    /// <summary>
    /// Additional skills that should be acquired to achieve some tasks or goals.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Skills"></see></summary>
    let Skills = _prefix "Skills"
    /// <summary>
    /// Also known as conventional, secret-key, and single-key algorithms; the encryption and decryption key are either the same or can be calculated from one another. Block ciphers and stream ciphers are both used for symmetric encryption.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricEncryption"></see></summary>
    let SymmetricEncryption = _prefix "SymmetricEncryption"
    /// <summary>
    /// Memory available on smart card like SIM, USIM or others;
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardMemory"></see></summary>
    let SmartCardMemory = _prefix "SmartCardMemory"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIMSI"></see>
    /// </summary>
    let hasIMSI = _prefix "hasIMSI"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardCloning"></see>
    /// </summary>
    let SmartCardCloning = _prefix "SmartCardCloning"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Socket"></see>
    /// </summary>
    let Socket = _prefix "Socket"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SoftwareLayer"></see>
    /// </summary>
    let SoftwareLayer = _prefix "SoftwareLayer"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Speaker"></see>
    /// </summary>
    let Speaker = _prefix "Speaker"
    /// <summary>
    /// The standard couple of login and password authentication
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Static_password"></see></summary>
    let Static_password = _prefix "Static_password"
    /// <summary>
    /// Steganography is the art and science of writing hidden messages in such a way that no-one, apart from the sender and intended recipient, suspects the existence of the message, a form of security through obscurity. Wikipedia
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Steganography"></see></summary>
    let Steganography = _prefix "Steganography"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SteganographyAlgorithm"></see>
    /// </summary>
    let SteganographyAlgorithm = _prefix "SteganographyAlgorithm"
    /// <summary>
    /// Data stored either in the device or on the memory card.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StoredData"></see></summary>
    let StoredData = _prefix "StoredData"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDataStructure"></see>
    /// </summary>
    let hasDataStructure = _prefix "hasDataStructure"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymbianSigned"></see>
    /// </summary>
    let SymbianSigned = _prefix "SymbianSigned"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasKey"></see>
    /// </summary>
    let hasKey = _prefix "hasKey"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricKeyPoP"></see>
    /// </summary>
    let SymmetricKeyPoP = _prefix "SymmetricKeyPoP"
    /// <summary>
    /// Transport Layer Security is an IETF standard that is intended to replace the SSL protocol. (IETF Working Group)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TLS"></see></summary>
    let TLS = _prefix "TLS"
    /// <summary>
    /// True Random Number Generation : extract randomness from physical phenomena and introduce it into computing device.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TRNG"></see></summary>
    let TRNG = _prefix "TRNG"
    /// <summary>
    /// All limitations related to technologies like the network bandwidth or processor capabilities.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Technical"></see></summary>
    let Technical = _prefix "Technical"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TestOnRealDevices"></see>
    /// </summary>
    let TestOnRealDevices = _prefix "TestOnRealDevices"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TestPhase"></see>
    /// </summary>
    let TestPhase = _prefix "TestPhase"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Time"></see>
    /// </summary>
    let Time = _prefix "Time"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeAnalysis"></see>
    /// </summary>
    let TimeAnalysis = _prefix "TimeAnalysis"
    /// <summary>
    /// A client and server time synchronization is required for the authentication token verification.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeBasedOTP"></see></summary>
    let TimeBasedOTP = _prefix "TimeBasedOTP"
    /// <summary>
    /// A digital signature that makes possible the verification of the sending time of a message.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeStampToken"></see></summary>
    let TimeStampToken = _prefix "TimeStampToken"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Timeliness"></see>
    /// </summary>
    let Timeliness = _prefix "Timeliness"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TopSecret"></see>
    /// </summary>
    let TopSecret = _prefix "TopSecret"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TouchScreen"></see>
    /// </summary>
    let TouchScreen = _prefix "TouchScreen"
    /// <summary>
    /// Requirement for additional training to use some tools or to do some technalical or management tasks.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Training"></see></summary>
    let Training = _prefix "Training"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Transaction"></see>
    /// </summary>
    let Transaction = _prefix "Transaction"
    /// <summary>
    /// Messaging data or data transferred through Internet connection
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TransmittedData"></see></summary>
    let TransmittedData = _prefix "TransmittedData"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedAPIAttack"></see>
    /// </summary>
    let TrustedAPIAttack = _prefix "TrustedAPIAttack"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedThirdPartyCertificate"></see>
    /// </summary>
    let TrustedThirdPartyCertificate = _prefix "TrustedThirdPartyCertificate"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TunneledPassword"></see>
    /// </summary>
    let TunneledPassword = _prefix "TunneledPassword"
    /// <summary>
    /// Don't mix type safe and type-unsafe API
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TypeSafe-Unsafe"></see></summary>
    let ``TypeSafe-Unsafe`` = _prefix "TypeSafe-Unsafe"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TypeSafeAPIUse"></see>
    /// </summary>
    let TypeSafeAPIUse = _prefix "TypeSafeAPIUse"
    /// <summary>
    /// The UICC is a generic platform for smart card applications. It has been standardised by ETSI EP SCP (ETSI Project Smart Card Platform) with the aim of defining a physical and logical platform for all smart card applications and to develop advanced security methods for financial transactions, to take an example. Mobey forum
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UICC"></see></summary>
    let UICC = _prefix "UICC"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UMTS"></see>
    /// </summary>
    let UMTS = _prefix "UMTS"
    /// <summary>
    /// A (U)SIM is a special type of smart card that typically contains a processor and between 16 to 128 KB of persistent Electronically Erasable, Programmable ROM (EEPROM). It also includes RAM for program execution and ROM for the operating system, user authentication and data encryption algorithms, and other applications.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#USIM"></see></summary>
    let USIM = _prefix "USIM"

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnifiedTestingInitiativeRootCertificate"></see>
    /// </summary>
    let UnifiedTestingInitiativeRootCertificate =
        _prefix "UnifiedTestingInitiativeRootCertificate"

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnsafeDataTypeAttack"></see>
    /// </summary>
    let UnsafeDataTypeAttack = _prefix "UnsafeDataTypeAttack"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UsePhase"></see>
    /// </summary>
    let UsePhase = _prefix "UsePhase"

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VeriSignTesting-BasedACSRootSymbian"></see>
    /// </summary>
    let ``VeriSignTesting-BasedACSRootSymbian`` =
        _prefix "VeriSignTesting-BasedACSRootSymbian"

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#X509Certificate"></see>
    /// </summary>
    let X509Certificate = _prefix "X509Certificate"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Verisign"></see>
    /// </summary>
    let Verisign = _prefix "Verisign"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VibrationKit"></see>
    /// </summary>
    let VibrationKit = _prefix "VibrationKit"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VideoInput"></see>
    /// </summary>
    let VideoInput = _prefix "VideoInput"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Videos"></see>
    /// </summary>
    let Videos = _prefix "Videos"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Voice"></see>
    /// </summary>
    let Voice = _prefix "Voice"
    /// <summary>
    /// Wireless Public Key Infrastructure.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WPKI"></see></summary>
    let WPKI = _prefix "WPKI"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WiFi"></see>
    /// </summary>
    let WiFi = _prefix "WiFi"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WithoutVerification"></see>
    /// </summary>
    let WithoutVerification = _prefix "WithoutVerification"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Yahalom"></see>
    /// </summary>
    let Yahalom = _prefix "Yahalom"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Yarrow"></see>
    /// </summary>
    let Yarrow = _prefix "Yarrow"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ZeroKnowledgePassword"></see>
    /// </summary>
    let ZeroKnowledgePassword = _prefix "ZeroKnowledgePassword"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasCardType"></see>
    /// </summary>
    let hasCardType = _prefix "hasCardType"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetworkBandwidth"></see>
    /// </summary>
    let hasNetworkBandwidth = _prefix "hasNetworkBandwidth"
    /// <summary>
    /// A Threat type may be a passive or an active threat.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasThreatType"></see></summary>
    let hasThreatType = _prefix "hasThreatType"
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#isUsedAt"></see>
    /// </summary>
    let isUsedAt = _prefix "isUsedAt"
    /// <summary>
    /// vCard is a virtual electronic business card format.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#vCard"></see></summary>
    let vCard = _prefix "vCard"
