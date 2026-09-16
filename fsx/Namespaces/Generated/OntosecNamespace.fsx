#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ontosec =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#" "ontosec"

    let _2'_period_'5G = _prefixId.prefix "2.5G"
    let _2G = _prefixId.prefix "2G"
    let _3DES = _prefixId.prefix "3DES"
    let _3G = _prefixId.prefix "3G"
    let _3GPP = _prefixId.prefix "3GPP"
    let AES = _prefixId.prefix "AES"
    let AES_FIPS197 = _prefixId.prefix "AES_FIPS197"
    let AccessControl = _prefixId.prefix "AccessControl"
    /// <summary>
    ///   <para>rdfs:comment : List of permissions attached to an object.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControlList">ontosec:AccessControlList</a>
    /// </summary>
    let AccessControlList = _prefixId.prefix "AccessControlList"
    let AccessControlMethods = _prefixId.prefix "AccessControlMethods"
    let ActiveThreat = _prefixId.prefix "ActiveThreat"
    /// <summary>
    ///   <para>rdfs:comment : Actors participating in the realisation and implementation of security services^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Actor">ontosec:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    let Add_OnMemory = _prefixId.prefix "Add-OnMemory"
    /// <summary>
    ///   <para>rdfs:comment : New tools that should be used for the projection or the application.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AdditionalTools">ontosec:AdditionalTools</a>
    /// </summary>
    let AdditionalTools = _prefixId.prefix "AdditionalTools"
    /// <summary>
    ///   <para>rdfs:comment : Tasks to be performed and which are out of the scope of the technical field.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AdministrativeProcedure">ontosec:AdministrativeProcedure</a>
    /// </summary>
    let AdministrativeProcedure = _prefixId.prefix "AdministrativeProcedure"
    let Algorithm = _prefixId.prefix "Algorithm"
    let AnalysisPhase = _prefixId.prefix "AnalysisPhase"
    let Android = _prefixId.prefix "Android"
    let Application = _prefixId.prefix "Application"
    let ApplicationData = _prefixId.prefix "ApplicationData"
    let ApplicationLifeCyclePhase = _prefixId.prefix "ApplicationLifeCyclePhase"
    /// <summary>
    ///   <para>rdfs:comment : The application server side may be a web server or a data base back end that the device connects to.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationServerSide">ontosec:ApplicationServerSide</a>
    /// </summary>
    let ApplicationServerSide = _prefixId.prefix "ApplicationServerSide"
    let AppliedTo = _prefixId.prefix "AppliedTo"
    /// <summary>
    ///   <para>rdfs:comment : The set of assets that should be protected^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Asset">ontosec:Asset</a>
    /// </summary>
    let Asset = _prefixId.prefix "Asset"
    let AssociatedOriented = _prefixId.prefix "AssociatedOriented"
    let AsymmetricAlgorithm = _prefixId.prefix "AsymmetricAlgorithm"
    /// <summary>
    ///   <para>rdfs:comment : Type of encryption in which an encryption key (the public key) is used to encrypt a message, and another encryption key (the private key) is used to decrypt the message.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AsymmetricEncryption">ontosec:AsymmetricEncryption</a>
    /// </summary>
    let AsymmetricEncryption = _prefixId.prefix "AsymmetricEncryption"
    let Authentication = _prefixId.prefix "Authentication"
    let AuthenticationLevel = _prefixId.prefix "AuthenticationLevel"
    let AuthenticationProtocol = _prefixId.prefix "AuthenticationProtocol"
    let AuthenticationProtocolType = _prefixId.prefix "AuthenticationProtocolType"
    let AuthenticationToken = _prefixId.prefix "AuthenticationToken"
    let AuthenticationWay = _prefixId.prefix "AuthenticationWay"
    let AutoInvocationFunctionGroup = _prefixId.prefix "AutoInvocationFunctionGroup"
    let Availability = _prefixId.prefix "Availability"
    let Backup = _prefixId.prefix "Backup"
    let BatteryMonitor = _prefixId.prefix "BatteryMonitor"
    let BestPractises = _prefixId.prefix "BestPractises"
    /// <summary>
    ///   <para>rdfs:comment : Biometric identifier is one of the most secure and more reliable ways to authenticate a person’s identity is to verify that person’s innate biological characteristics, which are referred to as biometrics. Each person’s fingerprints, DNA, iris and retinal cell patterns, facial geometry, and heat signature are near unique to that person. These biometric measures, if properly recorded, validated, and embedded in identity credentials that are logically bound to a single person’s identity, can provide the highest degree of identity authentication (From NIST information security Report)^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BiometricIdentifier">ontosec:BiometricIdentifier</a>
    /// </summary>
    let BiometricIdentifier = _prefixId.prefix "BiometricIdentifier"
    let BlockCipherAlgorithm = _prefixId.prefix "BlockCipherAlgorithm"
    let Blowfish = _prefixId.prefix "Blowfish"
    /// <summary>
    ///   <para>rdfs:comment : Bluetooth is a Personal Area Network (PAN) standard that enables wireless connections between electronic devices in the 2.4 GHz range over short distances, as an alternative to cables. Designed to be power efficient, Bluetooth has become a common feature in cell phones. Since wireless communications are inherently insecure, a number of basic security provisions have been defined for this standard to mitigate the risks involved. NIST^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Bluetooth">ontosec:Bluetooth</a>
    /// </summary>
    let Bluetooth = _prefixId.prefix "Bluetooth"
    let Break = _prefixId.prefix "Break"
    let ByPassingTrialCounter = _prefixId.prefix "ByPassingTrialCounter"
    let CBC = _prefixId.prefix "CBC"
    /// <summary>
    ///   <para>rdfs:comment : The simplest way to make a key-dependent one-way hash function is to encrypt a message with a block algorithm in CBC or CFB modes . The hash is the last encrypted block, encrypted once more in CBC or CFB modes.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CBC-MAC">ontosec:CBC-MAC</a>
    /// </summary>
    let CBC_MAC = _prefixId.prefix "CBC-MAC"
    let CFB = _prefixId.prefix "CFB"
    let COMSET = _prefixId.prefix "COMSET"
    let CardMemory = _prefixId.prefix "CardMemory"
    let CardType = _prefixId.prefix "CardType"
    /// <summary>
    ///   <para>dc11:format : A digital certificate is a text document that contains general information about its holder with the associated public key and general informations about the validity of the certificate. The digital certificate is signed by the certification authority that has issued it and can be verified a digital signature.
    /// The digital certificates, together with the identity data and public key, are stored on a USB-compatible token or a conventional smart card for use as part of strong authentication. When users try to log on to the corporate network, they connect their token with the USB slot or their smart card with the card reader.The digital certificate and public key are sent to the authentication authority via internet. To ensure that the public key sent actually belongs to the person attempting to log on to the corporate networks, the independent certification authority confirms that the public key matches the secret key it has stored^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Certificate">ontosec:Certificate</a>
    /// </summary>
    let Certificate = _prefixId.prefix "Certificate"
    let CertificateFormat = _prefixId.prefix "CertificateFormat"
    let CertificateInstallation = _prefixId.prefix "CertificateInstallation"

    let CertificateInstallationApplication = _prefixId.prefix "CertificateInstallationApplication"

    /// <summary>
    ///   <para>rdfs:comment : The certification authority provides certificates to bind a set of informations (name, serial number, ...) to a public key.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificationAuthority">ontosec:CertificationAuthority</a>
    /// </summary>
    let CertificationAuthority = _prefixId.prefix "CertificationAuthority"
    let ChainingMode = _prefixId.prefix "ChainingMode"
    let ChallengeReplyPassword = _prefixId.prefix "ChallengeReplyPassword"
    let Checksum = _prefixId.prefix "Checksum"
    /// <summary>
    ///   <para>rdfs:comment : Locate and isolate critical code from from general code.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CodeSeparation">ontosec:CodeSeparation</a>
    /// </summary>
    let CodeSeparation = _prefixId.prefix "CodeSeparation"
    /// <summary>
    ///   <para>rdfs:comment : Deploy development regimes such as coding standards and documentation methodologies to lead to best practises^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CodingStandards">ontosec:CodingStandards</a>
    /// </summary>
    let CodingStandards = _prefixId.prefix "CodingStandards"
    let CombinedDelivery_DRM = _prefixId.prefix "CombinedDelivery-DRM"
    let CommChannel = _prefixId.prefix "CommChannel"
    let CompactFlash = _prefixId.prefix "CompactFlash"
    /// <summary>
    ///   <para>rdfs:comment : The confidentiality service</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Confidentiality">ontosec:Confidentiality</a>
    /// </summary>
    let Confidentiality = _prefixId.prefix "Confidentiality"
    let ConfidentialityLevel = _prefixId.prefix "ConfidentialityLevel"
    /// <summary>
    ///   <para>rdfs:comment : Several configuration data are stored in the device or sent by the mobile operator.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ConfigurationData">ontosec:ConfigurationData</a>
    /// </summary>
    let ConfigurationData = _prefixId.prefix "ConfigurationData"
    /// <summary>
    ///   <para>rdfs:comment : Technical, quality constraints and others^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Constraints">ontosec:Constraints</a>
    /// </summary>
    let Constraints = _prefixId.prefix "Constraints"
    /// <summary>
    ///   <para>rdfs:comment : The entity who is responsable of providing content like ringing tones or multimedia files or any other software.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ContentProvider">ontosec:ContentProvider</a>
    /// </summary>
    let ContentProvider = _prefixId.prefix "ContentProvider"
    let CoreCounterMeasure = _prefixId.prefix "CoreCounterMeasure"
    let Correction = _prefixId.prefix "Correction"
    /// <summary>
    ///   <para>rdfs:comment : Time, skills, additional equipments are considered as cost constraints^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Cost">ontosec:Cost</a>
    /// </summary>
    let Cost = _prefixId.prefix "Cost"
    let Critical = _prefixId.prefix "Critical"
    let CryptographicHashFunction = _prefixId.prefix "CryptographicHashFunction"
    /// <summary>
    ///   <para>rdfs:comment : Distributed denial of service.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DDos">ontosec:DDos</a>
    /// </summary>
    let DDos = _prefixId.prefix "DDos"
    let DES = _prefixId.prefix "DES"
    let DES_FIPS46_1_2 = _prefixId.prefix "DES_FIPS46-1-2"
    let DIFFIE_HELLMAN = _prefixId.prefix "DIFFIE-HELLMAN"
    /// <summary>
    ///   <para>rdfs:comment : Digital Signature Algorithm specified by FIPS 186-2^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DSA">ontosec:DSA</a>
    /// </summary>
    let DSA = _prefixId.prefix "DSA"
    let Data = _prefixId.prefix "Data"
    /// <summary>
    ///   <para>rdfs:comment : Some applications use records files to store data.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DataRecords">ontosec:DataRecords</a>
    /// </summary>
    let DataRecords = _prefixId.prefix "DataRecords"
    let DeploymentPhase = _prefixId.prefix "DeploymentPhase"
    let DesignPhase = _prefixId.prefix "DesignPhase"
    let Detection = _prefixId.prefix "Detection"
    /// <summary>
    ///   <para>rdfs:comment : Addiotional development time required for the application or the project.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DevelopmentTime">ontosec:DevelopmentTime</a>
    /// </summary>
    let DevelopmentTime = _prefixId.prefix "DevelopmentTime"
    /// <summary>
    ///   <para>rdfs:comment : Mobile terminal equiped with processing capabilities offering  connection to wireless networks.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Device">ontosec:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    let DeviceCapabilities = _prefixId.prefix "DeviceCapabilities"
    let DeviceCloning = _prefixId.prefix "DeviceCloning"
    /// <summary>
    ///   <para>rdfs:comment : One problem in this area is that drivers are typically written by third parties and drivers are upgraded at different times to the main OS. This causes problems when implementing any validation scheme, or even isolated checking of specific software updates^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceDriverUpgrade">ontosec:DeviceDriverUpgrade</a>
    /// </summary>
    let DeviceDriverUpgrade = _prefixId.prefix "DeviceDriverUpgrade"
    let DeviceLock = _prefixId.prefix "DeviceLock"
    /// <summary>
    ///   <para>rdfs:comment : A general framework for downloading Rights to Devices and sharing Rights in a domain. DRM is invented by the Open Mobile Alliance whose members are mobile phone manufacturers, mobile system manufacturers, operators , and sofware editors.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalRightsManagement">ontosec:DigitalRightsManagement</a>
    /// </summary>
    let DigitalRightsManagement = _prefixId.prefix "DigitalRightsManagement"
    /// <summary>
    ///   <para>rdfs:comment : A digital signature is represented in a computer as a string of binary
    /// digits. A digital signature is computed using a set of rules and a set of parameters such that the identity of the signatory and integrity of the data can be verified. An algorithm provides the capability to generate and verify signatures. Signature generation makes use of a private key to generate a digital signature. Signature verification makes use of a public key which corresponds to, but is not the same as, the private key. (http://csrc.nist.gov/publications/fips/fips186-2/fips186-2-change1.pdf)^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalSignature">ontosec:DigitalSignature</a>
    /// </summary>
    let DigitalSignature = _prefixId.prefix "DigitalSignature"
    let DigitalSignatureAlgorithm = _prefixId.prefix "DigitalSignatureAlgorithm"
    let DisplayScreen = _prefixId.prefix "DisplayScreen"
    let DomainEntities = _prefixId.prefix "DomainEntities"
    let DotNet = _prefixId.prefix "DotNet"
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>rdfs:comment : Electronic code book^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ECB">ontosec:ECB</a>
    /// </summary>
    let ECB = _prefixId.prefix "ECB"
    /// <summary>
    ///   <para>rdfs:comment : Elliptic Curve Digital Signature Algorithm (ECDSA) (ANSI X9-62)^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ECDSA">ontosec:ECDSA</a>
    /// </summary>
    let ECDSA = _prefixId.prefix "ECDSA"
    /// <summary>
    ///   <para>rdfs:comment : Enhanced Data rates for GSM Evolution^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EDGE">ontosec:EDGE</a>
    /// </summary>
    let EDGE = _prefixId.prefix "EDGE"
    /// <summary>
    ///   <para>rdfs:comment : Enhanced Messaging Service - An improved message system for GSM mobile phones allowing picture, sound, animation and text elements to be conveyed through one or more concatenated SMS messages. NIST^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EMS">ontosec:EMS</a>
    /// </summary>
    let EMS = _prefixId.prefix "EMS"
    /// <summary>
    ///   <para>rdfs:comment : Best use of the available resources.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Efficiency">ontosec:Efficiency</a>
    /// </summary>
    let Efficiency = _prefixId.prefix "Efficiency"
    let ElGammelAlgorithm = _prefixId.prefix "ElGammelAlgorithm"
    let Email = _prefixId.prefix "Email"
    /// <summary>
    ///   <para>rdfs:comment : Discipline which embodies principles, means, and methods for the transformation of data in order to hide its information content, prevent its undetected modification and/or prevent its unauthorised use. (CCITT)^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Encryption">ontosec:Encryption</a>
    /// </summary>
    let Encryption = _prefixId.prefix "Encryption"
    /// <summary>
    ///   <para>rdfs:comment : The encryption keys are digital bitstrings that are stored in non-volatile memory, and verification of the identity proceeds by a challenge-response protocol.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EncryptionKeys">ontosec:EncryptionKeys</a>
    /// </summary>
    let EncryptionKeys = _prefixId.prefix "EncryptionKeys"
    let EndToEnd = _prefixId.prefix "EndToEnd"
    let Excellent = _prefixId.prefix "Excellent"
    let FTP = _prefixId.prefix "FTP"
    let FixedMemory = _prefixId.prefix "FixedMemory"
    let ForwardLock_DRM = _prefixId.prefix "ForwardLock-DRM"
    let FullIntegrity = _prefixId.prefix "FullIntegrity"
    /// <summary>
    ///   <para>rdfs:comment : A set of sensitive functions under a named group that can get authorization.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FunctionGroups">ontosec:FunctionGroups</a>
    /// </summary>
    let FunctionGroups = _prefixId.prefix "FunctionGroups"
    /// <summary>
    ///   <para>rdfs:comment : General Packet Radio Service^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPRS">ontosec:GPRS</a>
    /// </summary>
    let GPRS = _prefixId.prefix "GPRS"
    /// <summary>
    ///   <para>rdfs:comment : A system for determining position by comparing radio signals from several satellites. NIST^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPSNetwork">ontosec:GPSNetwork</a>
    /// </summary>
    let GPSNetwork = _prefixId.prefix "GPSNetwork"
    /// <summary>
    ///   <para>rdfs:comment : Global positioning system coordinates used by some applications.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPSvalues">ontosec:GPSvalues</a>
    /// </summary>
    let GPSvalues = _prefixId.prefix "GPSvalues"
    /// <summary>
    ///   <para>rdfs:comment : Global System for Mobile communications^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSM">ontosec:GSM</a>
    /// </summary>
    let GSM = _prefixId.prefix "GSM"
    let GSMA = _prefixId.prefix "GSMA"
    let GSMWorld = _prefixId.prefix "GSMWorld"
    let GuessingAttack = _prefixId.prefix "GuessingAttack"
    let HMAC = _prefixId.prefix "HMAC"
    let HTTP = _prefixId.prefix "HTTP"
    let HTTPS = _prefixId.prefix "HTTPS"
    /// <summary>
    ///   <para>rdfs:comment : Mainly the physical device with the embedded memory and processing units.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Hardware">ontosec:Hardware</a>
    /// </summary>
    let Hardware = _prefixId.prefix "Hardware"
    let HardwareLocking = _prefixId.prefix "HardwareLocking"
    let HasBandwidth = _prefixId.prefix "HasBandwidth"
    let HasBlockSize = _prefixId.prefix "HasBlockSize"
    let HasIterationNumber = _prefixId.prefix "HasIterationNumber"
    let HasKeySize = _prefixId.prefix "HasKeySize"
    let HasOutputLength = _prefixId.prefix "HasOutputLength"
    /// <summary>
    ///   <para>rdfs:comment : A server side list of hashed tokens is stored and each consumed token is removed from the list.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HashBasedOTP">ontosec:HashBasedOTP</a>
    /// </summary>
    let HashBasedOTP = _prefixId.prefix "HashBasedOTP"
    let Help = _prefixId.prefix "Help"
    let Hurt = _prefixId.prefix "Hurt"
    let IEEE = _prefixId.prefix "IEEE"
    let IETF = _prefixId.prefix "IETF"
    let IM = _prefixId.prefix "IM"
    let IPSec = _prefixId.prefix "IPSec"
    let ITU = _prefixId.prefix "ITU"
    /// <summary>
    ///   <para>rdfs:comment : All supported image files for mobile devices.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Images">ontosec:Images</a>
    /// </summary>
    let Images = _prefixId.prefix "Images"
    let ImplementAPI = _prefixId.prefix "ImplementAPI"
    let ImplementMechanism = _prefixId.prefix "ImplementMechanism"
    let ImplementationPhase = _prefixId.prefix "ImplementationPhase"
    let IndustrialProtocol = _prefixId.prefix "IndustrialProtocol"
    /// <summary>
    ///   <para>rdfs:comment : Keypad or any input tool^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Input">ontosec:Input</a>
    /// </summary>
    let Input = _prefixId.prefix "Input"
    let Integrity = _prefixId.prefix "Integrity"
    let IntegrityType = _prefixId.prefix "IntegrityType"
    let IntensifyCriticalCodeReview = _prefixId.prefix "IntensifyCriticalCodeReview"
    /// <summary>
    ///   <para>rdfs:comment : User interaction to confirm the execution of some senstive actions like sending a sms or opening a network connection/^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#InteractionModes">ontosec:InteractionModes</a>
    /// </summary>
    let InteractionModes = _prefixId.prefix "InteractionModes"
    let Internet = _prefixId.prefix "Internet"
    /// <summary>
    ///   <para>rdfs:comment : A standard for line-of-sight infrared communication between devices over short distances. NIST^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IrDA">ontosec:IrDA</a>
    /// </summary>
    let IrDA = _prefixId.prefix "IrDA"
    let Issue = _prefixId.prefix "Issue"
    let J2ME = _prefixId.prefix "J2ME"
    let JME = _prefixId.prefix "JME"
    let JMEPermissionDomains = _prefixId.prefix "JMEPermissionDomains"
    let JavaCard = _prefixId.prefix "JavaCard"
    let JavaVerifiedSigningProcess = _prefixId.prefix "JavaVerifiedSigningProcess"
    let Journaling = _prefixId.prefix "Journaling"
    /// <summary>
    ///   <para>rdfs:comment : Kerberos is an authentication process that proceeds as follows: A client sends a request to the authentication server (AS) requesting "credentials" for a given server.  The AS responds with these credentials,  encrypted in the client's key.  The credentials consist of 1) a "ticket" for the server and 2) a temporary encryption key ( a "session key").  The client transmits the ticket (which contains the client's identity and a copy of the session key, all encrypted in the server's key) to the server.  The session key (now shared by the client and server) is used to authenticate the client, and may optionally be used to authenticate the server.  It may also be used to encrypt further communication between the two parties or to exchange a separate sub-session key to be used to encrypt further communication. RFC 1510^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Kerberos">ontosec:Kerberos</a>
    /// </summary>
    let Kerberos = _prefixId.prefix "Kerberos"
    let KeyExchange = _prefixId.prefix "KeyExchange"
    let KeyExchangeProtocol = _prefixId.prefix "KeyExchangeProtocol"
    let KeyGeneration = _prefixId.prefix "KeyGeneration"
    /// <summary>
    ///   <para>rdfs:comment : The process and procedure for safely storing and distributing accurate cryptographic keys; the overall process of generating and distributing cryptographic key to authorized recipients in a secure manner.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyManagement">ontosec:KeyManagement</a>
    /// </summary>
    let KeyManagement = _prefixId.prefix "KeyManagement"
    let KeyPad = _prefixId.prefix "KeyPad"
    let KeyStore = _prefixId.prefix "KeyStore"
    let Keys = _prefixId.prefix "Keys"
    let LANetwork = _prefixId.prefix "LANetwork"
    /// <summary>
    ///   <para>rdfs:comment : Easy to learn how to use the application.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Learnability">ontosec:Learnability</a>
    /// </summary>
    let Learnability = _prefixId.prefix "Learnability"
    /// <summary>
    ///   <para>rdfs:comment : Special database management systems for embedded applications.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalDataBase">ontosec:LocalDataBase</a>
    /// </summary>
    let LocalDataBase = _prefixId.prefix "LocalDataBase"
    let LocalDeviceLock = _prefixId.prefix "LocalDeviceLock"
    let LocalFiles = _prefixId.prefix "LocalFiles"
    let LocalisationData = _prefixId.prefix "LocalisationData"
    let LockingMechanism = _prefixId.prefix "LockingMechanism"
    /// <summary>
    ///   <para>rdfs:comment : In some situations it is useful to lock the screen display until a task is terminated. This is technique is used to avoid the screen modification until a answer is received.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LockingScreen">ontosec:LockingScreen</a>
    /// </summary>
    let LockingScreen = _prefixId.prefix "LockingScreen"
    let LogInSystem = _prefixId.prefix "LogInSystem"
    /// <summary>
    ///   <para>rdfs:comment : Message authentication code that include a key for authentication^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MACAlgorithm">ontosec:MACAlgorithm</a>
    /// </summary>
    let MACAlgorithm = _prefixId.prefix "MACAlgorithm"
    let MD2 = _prefixId.prefix "MD2"
    let MD4 = _prefixId.prefix "MD4"
    let MD5 = _prefixId.prefix "MD5"
    let MMC = _prefixId.prefix "MMC"
    let MMS = _prefixId.prefix "MMS"
    let MULTOS = _prefixId.prefix "MULTOS"
    let Mail = _prefixId.prefix "Mail"
    let MaintenancePhase = _prefixId.prefix "MaintenancePhase"
    let Make = _prefixId.prefix "Make"
    let Manual = _prefixId.prefix "Manual"
    /// <summary>
    ///   <para>rdfs:comment : Mobile device manufacturer which may implement some security features in the device^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Manufacturer">ontosec:Manufacturer</a>
    /// </summary>
    let Manufacturer = _prefixId.prefix "Manufacturer"
    /// <summary>
    ///   <para>dc11:format : A certificate which is issued by the device manufacturer like Nokia or Samsung for example.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ManufacturerCertificate">ontosec:ManufacturerCertificate</a>
    /// </summary>
    let ManufacturerCertificate = _prefixId.prefix "ManufacturerCertificate"
    /// <summary>
    ///   <para>rdfs:comment : Security mechanisms used for security services^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mechanism">ontosec:Mechanism</a>
    /// </summary>
    let Mechanism = _prefixId.prefix "Mechanism"
    let MechanismType = _prefixId.prefix "MechanismType"
    /// <summary>
    ///   <para>rdfs:comment : A limited period of time during which the use of the application will be memorised.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Memorability">ontosec:Memorability</a>
    /// </summary>
    let Memorability = _prefixId.prefix "Memorability"
    let Memory = _prefixId.prefix "Memory"
    /// <summary>
    ///   <para>rdfs:comment : Memory card can be protected with a password each time someone tries to access the card</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MemoryCardLock">ontosec:MemoryCardLock</a>
    /// </summary>
    let MemoryCardLock = _prefixId.prefix "MemoryCardLock"
    /// <summary>
    ///   <para>rdfs:comment : A function that takes a string (or message) of any length as input and produces a fixed-length string as output,it is used for authentication and message integrity.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MessageDigest">ontosec:MessageDigest</a>
    /// </summary>
    let MessageDigest = _prefixId.prefix "MessageDigest"
    let Messaging = _prefixId.prefix "Messaging"
    let MessagingFunctionsGroup = _prefixId.prefix "MessagingFunctionsGroup"
    let MisUseAttack = _prefixId.prefix "MisUseAttack"
    let MobeyForum = _prefixId.prefix "MobeyForum"
    let Mobile2Market = _prefixId.prefix "Mobile2Market"
    /// <summary>
    ///   <para>rdfs:comment : Mobile network Cell ID to which the device is attached.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobileNetworkProvidervalues">ontosec:MobileNetworkProvidervalues</a>
    /// </summary>
    let MobileNetworkProvidervalues = _prefixId.prefix "MobileNetworkProvidervalues"
    let MobileVPN = _prefixId.prefix "MobileVPN"
    let MotorollaMobileVPN = _prefixId.prefix "MotorollaMobileVPN"
    let Mutual = _prefixId.prefix "Mutual"
    let MutualReliableChannel = _prefixId.prefix "MutualReliableChannel"
    /// <summary>
    ///   <para>rdfs:comment : A short-range point-to-point wireless communication technology. The technology is a simple extension of the ISO/IEC 14443 proximity-card standard (contactless card, RFID) that combines the interface of a smartcard and a reader into a single device. An NFC device can communicate with both existing ISO/IEC 14443 smartcards and readers, as well as with other NFC devices, and is thereby compatible with existing contactless infrastructure already in use for public transportation and payment.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NFC">ontosec:NFC</a>
    /// </summary>
    let NFC = _prefixId.prefix "NFC"
    /// <summary>
    ///   <para>rdfs:comment : The device may be or not equiped with Near Field Communication Ship (NFC).^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NFCEnabled">ontosec:NFCEnabled</a>
    /// </summary>
    let NFCEnabled = _prefixId.prefix "NFCEnabled"
    let NIST = _prefixId.prefix "NIST"
    let NeedhamShroeder = _prefixId.prefix "NeedhamShroeder"
    let NetAccessFunctionGroup = _prefixId.prefix "NetAccessFunctionGroup"
    let Network = _prefixId.prefix "Network"
    let NetworkLayer = _prefixId.prefix "NetworkLayer"
    let NoAuthentication = _prefixId.prefix "NoAuthentication"

    let NoSensitiveInfoOnExternalMemory = _prefixId.prefix "NoSensitiveInfoOnExternalMemory"

    let Nokia_Mobile_VPN = _prefixId.prefix "Nokia_Mobile_VPN"
    let NonRepudiation = _prefixId.prefix "NonRepudiation"
    let NonRepudiationType = _prefixId.prefix "NonRepudiationType"
    let NonVolatile = _prefixId.prefix "NonVolatile"
    /// <summary>
    ///   <para>rdfs:comment : Password used for once and generated from time, counter and/or key. May be a displayed from a hardware device.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#O.T.P">ontosec:O.T.P</a>
    /// </summary>
    let O'_period_'T'_period_'P = _prefixId.prefix "O.T.P"
    let Offline = _prefixId.prefix "Offline"
    let OneSideVerification = _prefixId.prefix "OneSideVerification"
    let OperationMode = _prefixId.prefix "OperationMode"
    /// <summary>
    ///   <para>rdfs:comment : Telecom Network Operator knowing as MNO^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Operator">ontosec:Operator</a>
    /// </summary>
    let Operator = _prefixId.prefix "Operator"
    /// <summary>
    ///   <para>dc11:format : A certificate which is issued by the mobile network operator.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OperatorCertificate">ontosec:OperatorCertificate</a>
    /// </summary>
    let OperatorCertificate = _prefixId.prefix "OperatorCertificate"
    /// <summary>
    ///   <para>rdfs:comment : Organizations and associations providing standards in the mobile field arena.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OrganizationsAndStandards">ontosec:OrganizationsAndStandards</a>
    /// </summary>
    let OrganizationsAndStandards = _prefixId.prefix "OrganizationsAndStandards"
    let Output = _prefixId.prefix "Output"
    let PANetwork = _prefixId.prefix "PANetwork"
    let PGPCertificate = _prefixId.prefix "PGPCertificate"
    let PIN = _prefixId.prefix "PIN"
    /// <summary>
    ///   <para>rdfs:comment : Public-key infrastructure (PKI) consists of protocols, services, and standards supporting applications of public-key cryptography. PKI sometimes refers simply to a trust hierarchy based on public-key certificates, and in other contexts embraces encryption and digital signature services provided to end-user applications as well. RSA (http://www.rsa.com/rsalabs/node.asp?id=2268)^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PKI">ontosec:PKI</a>
    /// </summary>
    let PKI = _prefixId.prefix "PKI"
    /// <summary>
    ///   <para>rdfs:comment : Pseudo Random Number Generation^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PRNG">ontosec:PRNG</a>
    /// </summary>
    let PRNG = _prefixId.prefix "PRNG"
    /// <summary>
    ///   <para>rdfs:comment : Pseudo Random Number Generation algorithm^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PRNGAlgorithm">ontosec:PRNGAlgorithm</a>
    /// </summary>
    let PRNGAlgorithm = _prefixId.prefix "PRNGAlgorithm"
    let PUK = _prefixId.prefix "PUK"
    let Parallel = _prefixId.prefix "Parallel"
    let PassiveThreat = _prefixId.prefix "PassiveThreat"
    let Password = _prefixId.prefix "Password"
    let Performance = _prefixId.prefix "Performance"
    let Phishing = _prefixId.prefix "Phishing"
    let PhysicalLayer = _prefixId.prefix "PhysicalLayer"
    /// <summary>
    ///   <para>rdfs:comment : The software device platform layer^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Platform">ontosec:Platform</a>
    /// </summary>
    let Platform = _prefixId.prefix "Platform"
    let Poor = _prefixId.prefix "Poor"
    /// <summary>
    ///   <para>rdfs:comment : ability of Application running on several devices or/and platforms.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Portability">ontosec:Portability</a>
    /// </summary>
    let Portability = _prefixId.prefix "Portability"
    let PreemptDisplay = _prefixId.prefix "PreemptDisplay"
    let Prevention = _prefixId.prefix "Prevention"
    let PrivateKey = _prefixId.prefix "PrivateKey"
    let PrivateKeyPoP = _prefixId.prefix "PrivateKeyPoP"
    let Processing = _prefixId.prefix "Processing"
    let Provide = _prefixId.prefix "Provide"
    let Public = _prefixId.prefix "Public"
    let PublicKey = _prefixId.prefix "PublicKey"
    let Quality = _prefixId.prefix "Quality"
    let QualitySatisfaction = _prefixId.prefix "QualitySatisfaction"
    let RAM = _prefixId.prefix "RAM"
    /// <summary>
    ///   <para>rdfs:comment : A free algorithm provided by  RSA security, implemented since 1970.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RC4">ontosec:RC4</a>
    /// </summary>
    let RC4 = _prefixId.prefix "RC4"
    let RF = _prefixId.prefix "RF"
    let RIPE_MAC = _prefixId.prefix "RIPE-MAC"
    let RIPE_MD = _prefixId.prefix "RIPE-MD"
    let RMS = _prefixId.prefix "RMS"
    let RNGEfficiency = _prefixId.prefix "RNGEfficiency"
    let ROM = _prefixId.prefix "ROM"
    /// <summary>
    ///   <para>rdfs:comment : RSA signature algorithm (American National Standard ANSI X9-31)^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RSA">ontosec:RSA</a>
    /// </summary>
    let RSA = _prefixId.prefix "RSA"
    let RSAAlgorithm = _prefixId.prefix "RSAAlgorithm"
    let ReadUserDataFunctionGroup = _prefixId.prefix "ReadUserDataFunctionGroup"
    let Recovery = _prefixId.prefix "Recovery"
    let ReduceCodeSize = _prefixId.prefix "ReduceCodeSize"
    /// <summary>
    ///   <para>rdfs:comment : Registration authority is an administrative entity which is responsable of verifying the identity of the claimer of a certificate^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RegistrationAuthority">ontosec:RegistrationAuthority</a>
    /// </summary>
    let RegistrationAuthority = _prefixId.prefix "RegistrationAuthority"
    let Relationship = _prefixId.prefix "Relationship"
    let Reliability = _prefixId.prefix "Reliability"
    /// <summary>
    ///   <para>rdfs:comment : Sending a Short message to lock the device</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RemoteDeviceLock">ontosec:RemoteDeviceLock</a>
    /// </summary>
    let RemoteDeviceLock = _prefixId.prefix "RemoteDeviceLock"
    let Resource = _prefixId.prefix "Resource"
    let ResourceMonitoring = _prefixId.prefix "ResourceMonitoring"
    /// <summary>
    ///   <para>rdfs:comment : Audio files used as rings in mobile devices.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RingTones">ontosec:RingTones</a>
    /// </summary>
    let RingTones = _prefixId.prefix "RingTones"
    let SANS_Institute = _prefixId.prefix "SANS_Institute"
    let SD = _prefixId.prefix "SD"
    /// <summary>
    ///   <para>rdfs:comment : Secure Electronic Transaction^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SET">ontosec:SET</a>
    /// </summary>
    let SET = _prefixId.prefix "SET"
    let SHA1 = _prefixId.prefix "SHA1"
    let SHAMIR3Pass = _prefixId.prefix "SHAMIR3Pass"
    /// <summary>
    ///   <para>rdfs:comment : Subscriber Identity Module; A smart card for GSM networks access.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SIM">ontosec:SIM</a>
    /// </summary>
    let SIM = _prefixId.prefix "SIM"
    let SKID = _prefixId.prefix "SKID"
    let SMS = _prefixId.prefix "SMS"
    let SNOW = _prefixId.prefix "SNOW"
    let SSL = _prefixId.prefix "SSL"
    let STRANDOM = _prefixId.prefix "STRANDOM"
    let Satisfice = _prefixId.prefix "Satisfice"
    let Secret = _prefixId.prefix "Secret"
    let SecretKey = _prefixId.prefix "SecretKey"
    let SecureNetworkCommunication = _prefixId.prefix "SecureNetworkCommunication"
    let SecurityInfrastructure = _prefixId.prefix "SecurityInfrastructure"
    let SecurityLayer = _prefixId.prefix "SecurityLayer"
    let SecurityTools = _prefixId.prefix "SecurityTools"
    let SemanticIntegrity = _prefixId.prefix "SemanticIntegrity"
    let SeparateDelivery_DRM = _prefixId.prefix "SeparateDelivery-DRM"
    let Session = _prefixId.prefix "Session"
    /// <summary>
    ///   <para>rdfs:comment : Additional skills that should be acquired to achieve some tasks or goals.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Skills">ontosec:Skills</a>
    /// </summary>
    let Skills = _prefixId.prefix "Skills"
    /// <summary>
    ///   <para>rdfs:comment : A smart card is any limited-sized card with embedded integrated circuits. The smart card may integrate or not processing capabilities.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCard">ontosec:SmartCard</a>
    /// </summary>
    let SmartCard = _prefixId.prefix "SmartCard"
    let SmartCardCloning = _prefixId.prefix "SmartCardCloning"
    let SmartCardLock = _prefixId.prefix "SmartCardLock"
    /// <summary>
    ///   <para>rdfs:comment : Memory available on smart card like SIM, USIM or others;^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardMemory">ontosec:SmartCardMemory</a>
    /// </summary>
    let SmartCardMemory = _prefixId.prefix "SmartCardMemory"
    let Socket = _prefixId.prefix "Socket"
    /// <summary>
    ///   <para>rdfs:comment : All the applications and data provided with or installed on the device.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Software">ontosec:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    let SoftwareLayer = _prefixId.prefix "SoftwareLayer"
    let SourceCodeVerification = _prefixId.prefix "SourceCodeVerification"
    let Speaker = _prefixId.prefix "Speaker"
    let StandardFiles = _prefixId.prefix "StandardFiles"
    let Standards = _prefixId.prefix "Standards"
    /// <summary>
    ///   <para>rdfs:comment : The standard couple of login and password authentication^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Static_password">ontosec:Static_password</a>
    /// </summary>
    let Static_password = _prefixId.prefix "Static_password"
    /// <summary>
    ///   <para>rdfs:comment : Steganography is the art and science of writing hidden messages in such a way that no-one, apart from the sender and intended recipient, suspects the existence of the message, a form of security through obscurity. Wikipedia^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Steganography">ontosec:Steganography</a>
    /// </summary>
    let Steganography = _prefixId.prefix "Steganography"
    let SteganographyAlgorithm = _prefixId.prefix "SteganographyAlgorithm"
    let Store = _prefixId.prefix "Store"
    /// <summary>
    ///   <para>rdfs:comment : Data stored either in the device or on the memory card.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StoredData">ontosec:StoredData</a>
    /// </summary>
    let StoredData = _prefixId.prefix "StoredData"
    let StreamCipherAlgorithm = _prefixId.prefix "StreamCipherAlgorithm"
    let SymbianSigned = _prefixId.prefix "SymbianSigned"
    let SymmetricAlgorithm = _prefixId.prefix "SymmetricAlgorithm"
    /// <summary>
    ///   <para>rdfs:comment : Also known as conventional, secret-key, and single-key algorithms; the encryption and decryption key are either the same or can be calculated from one another. Block ciphers and stream ciphers are both used for symmetric encryption.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricEncryption">ontosec:SymmetricEncryption</a>
    /// </summary>
    let SymmetricEncryption = _prefixId.prefix "SymmetricEncryption"
    let SymmetricKeyPoP = _prefixId.prefix "SymmetricKeyPoP"
    /// <summary>
    ///   <para>rdfs:comment : Transport Layer Security is an IETF standard that is intended to replace the SSL protocol. (IETF Working Group)^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TLS">ontosec:TLS</a>
    /// </summary>
    let TLS = _prefixId.prefix "TLS"
    /// <summary>
    ///   <para>rdfs:comment : True Random Number Generation : extract randomness from physical phenomena and introduce it into computing device.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TRNG">ontosec:TRNG</a>
    /// </summary>
    let TRNG = _prefixId.prefix "TRNG"
    /// <summary>
    ///   <para>rdfs:comment : All limitations related to technologies like the network bandwidth or processor capabilities.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Technical">ontosec:Technical</a>
    /// </summary>
    let Technical = _prefixId.prefix "Technical"
    let Techniques = _prefixId.prefix "Techniques"
    let TestOnRealDevices = _prefixId.prefix "TestOnRealDevices"
    let TestPhase = _prefixId.prefix "TestPhase"
    let ThreatType = _prefixId.prefix "ThreatType"
    let Time = _prefixId.prefix "Time"
    let TimeAnalysis = _prefixId.prefix "TimeAnalysis"
    /// <summary>
    ///   <para>rdfs:comment : A client and server time synchronization is required for the authentication token verification.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeBasedOTP">ontosec:TimeBasedOTP</a>
    /// </summary>
    let TimeBasedOTP = _prefixId.prefix "TimeBasedOTP"
    /// <summary>
    ///   <para>rdfs:comment : A digital signature that makes possible the verification of the sending time of a message.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeStampToken">ontosec:TimeStampToken</a>
    /// </summary>
    let TimeStampToken = _prefixId.prefix "TimeStampToken"
    let Timeliness = _prefixId.prefix "Timeliness"
    let TopSecret = _prefixId.prefix "TopSecret"
    let TouchScreen = _prefixId.prefix "TouchScreen"
    /// <summary>
    ///   <para>rdfs:comment : Requirement for additional training to use some tools or to do some technalical or management tasks.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Training">ontosec:Training</a>
    /// </summary>
    let Training = _prefixId.prefix "Training"
    let Transaction = _prefixId.prefix "Transaction"
    /// <summary>
    ///   <para>rdfs:comment : Messaging data or data transferred through Internet connection^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TransmittedData">ontosec:TransmittedData</a>
    /// </summary>
    let TransmittedData = _prefixId.prefix "TransmittedData"
    let TrustedAPIAttack = _prefixId.prefix "TrustedAPIAttack"
    /// <summary>
    ///   <para>rdfs:comment : security authority or its agent, trusted by other entities with respect to security-related activities. In the context of ISO/IEC 9798, a trusted third party is trusted by a claimant and/or a verifier for the purposes of authentication.  ISO/IEC 9798^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedThirdParty">ontosec:TrustedThirdParty</a>
    /// </summary>
    let TrustedThirdParty = _prefixId.prefix "TrustedThirdParty"
    /// <summary>
    ///   <para>dc11:format : A certificate which is issued by a trusted third party.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedThirdPartyCertificate">ontosec:TrustedThirdPartyCertificate</a>
    /// </summary>
    let TrustedThirdPartyCertificate = _prefixId.prefix "TrustedThirdPartyCertificate"
    let TunneledPassword = _prefixId.prefix "TunneledPassword"
    let TypeSafe_Unsafe = _prefixId.prefix "TypeSafe-Unsafe"
    let TypeSafeAPIUse = _prefixId.prefix "TypeSafeAPIUse"
    /// <summary>
    ///   <para>rdfs:comment : The UICC is a generic platform for smart card applications. It has been standardised by ETSI EP SCP (ETSI Project Smart Card Platform) with the aim of defining a physical and logical platform for all smart card applications and to develop advanced security methods for financial transactions, to take an example. Mobey forum^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UICC">ontosec:UICC</a>
    /// </summary>
    let UICC = _prefixId.prefix "UICC"
    let UMTS = _prefixId.prefix "UMTS"
    /// <summary>
    ///   <para>rdfs:comment : A (U)SIM is a special type of smart card that typically contains a processor and between 16 to 128 KB of persistent Electronically Erasable, Programmable ROM (EEPROM). It also includes RAM for program execution and ROM for the operating system, user authentication and data encryption algorithms, and other applications.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#USIM">ontosec:USIM</a>
    /// </summary>
    let USIM = _prefixId.prefix "USIM"
    let UnTrustedAPIAttack = _prefixId.prefix "UnTrustedAPIAttack"

    let UnifiedTestingInitiativeRootCertificate = _prefixId.prefix "UnifiedTestingInitiativeRootCertificate"

    let UnsafeDataTypeAttack = _prefixId.prefix "UnsafeDataTypeAttack"
    /// <summary>
    ///   <para>rdfs:comment : A good response time of the application.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Usability">ontosec:Usability</a>
    /// </summary>
    let Usability = _prefixId.prefix "Usability"
    let Use = _prefixId.prefix "Use"
    let UsePhase = _prefixId.prefix "UsePhase"
    /// <summary>
    ///   <para>rdfs:comment : Virtula private network. FIPS 140-2^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VPN">ontosec:VPN</a>
    /// </summary>
    let VPN = _prefixId.prefix "VPN"
    /// <summary>
    ///   <para>rdfs:comment : Additional and required types for the ontology^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ValueTypes">ontosec:ValueTypes</a>
    /// </summary>
    let ValueTypes = _prefixId.prefix "ValueTypes"

    let VeriSignTesting_BasedACSRootSymbian = _prefixId.prefix "VeriSignTesting-BasedACSRootSymbian"

    let Verisign = _prefixId.prefix "Verisign"
    let VibrationKit = _prefixId.prefix "VibrationKit"
    let VideoInput = _prefixId.prefix "VideoInput"
    let Videos = _prefixId.prefix "Videos"
    let Voice = _prefixId.prefix "Voice"
    let WANetwork = _prefixId.prefix "WANetwork"
    /// <summary>
    ///   <para>rdfs:comment : Wireless Public Key Infrastructure.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WPKI">ontosec:WPKI</a>
    /// </summary>
    let WPKI = _prefixId.prefix "WPKI"
    let WiFi = _prefixId.prefix "WiFi"
    let WithoutVerification = _prefixId.prefix "WithoutVerification"
    let X509Certificate = _prefixId.prefix "X509Certificate"
    let Yahalom = _prefixId.prefix "Yahalom"
    let Yarrow = _prefixId.prefix "Yarrow"
    let ZeroKnowledgePassword = _prefixId.prefix "ZeroKnowledgePassword"
    let hasAuthenticationProtocolType = _prefixId.prefix "hasAuthenticationProtocolType"
    let hasCardType = _prefixId.prefix "hasCardType"
    let hasChainingMode = _prefixId.prefix "hasChainingMode"
    let hasDataStructure = _prefixId.prefix "hasDataStructure"
    let hasDigitalSignatureData = _prefixId.prefix "hasDigitalSignatureData"
    let hasDuration = _prefixId.prefix "hasDuration"
    let hasFormat = _prefixId.prefix "hasFormat"
    let hasIMEI = _prefixId.prefix "hasIMEI"
    let hasIMSI = _prefixId.prefix "hasIMSI"
    let hasInitialisationVector = _prefixId.prefix "hasInitialisationVector"
    let hasInput = _prefixId.prefix "hasInput"
    let hasIssuer = _prefixId.prefix "hasIssuer"
    let hasKey = _prefixId.prefix "hasKey"
    let hasKeyLifeTime = _prefixId.prefix "hasKeyLifeTime"
    let hasLevel = _prefixId.prefix "hasLevel"
    let hasMemory = _prefixId.prefix "hasMemory"
    let hasNetwork = _prefixId.prefix "hasNetwork"
    let hasNetworkBandwidth = _prefixId.prefix "hasNetworkBandwidth"
    let hasNetworkLatency = _prefixId.prefix "hasNetworkLatency"
    let hasOutput = _prefixId.prefix "hasOutput"
    let hasPadding = _prefixId.prefix "hasPadding"
    let hasProcessing = _prefixId.prefix "hasProcessing"
    let hasRNGDeterminism = _prefixId.prefix "hasRNGDeterminism"
    let hasRNGEfficiency = _prefixId.prefix "hasRNGEfficiency"
    let hasScreenSize = _prefixId.prefix "hasScreenSize"
    let hasSignatureAlgorithm = _prefixId.prefix "hasSignatureAlgorithm"
    let hasSubjectName = _prefixId.prefix "hasSubjectName"
    /// <summary>
    ///   <para>rdfs:comment : A Threat type may be a passive or an active threat.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasThreatType">ontosec:hasThreatType</a>
    /// </summary>
    let hasThreatType = _prefixId.prefix "hasThreatType"
    let hasTrustIn = _prefixId.prefix "hasTrustIn"
    let hasType = _prefixId.prefix "hasType"
    let hasValidity = _prefixId.prefix "hasValidity"
    let isUsedAt = _prefixId.prefix "isUsedAt"
    let storedOn = _prefixId.prefix "storedOn"
    /// <summary>
    ///   <para>rdfs:comment : vCard is a virtual electronic business card format.^^xsd:string</para>
    ///   <a href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#vCard">ontosec:vCard</a>
    /// </summary>
    let vCard = _prefixId.prefix "vCard"
