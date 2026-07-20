namespace http.securitytoolbox.appspot.com.stac.hash

open DoxAletheia

module stac =
    let _namespace_name = "http://securitytoolbox.appspot.com/stac#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Permissions are associated with a set of rules expressed on measurable parameters and are granted to users who can prove compliance with these rules.
    /// <see href="http://securitytoolbox.appspot.com/stac#ABAC"></see></summary>
    let ABAC = _prefix "ABAC"
    /// <summary>
    /// Access Control is the mechanism that allows owners of resources to define, manage and enforce access conditions applicable to each resource.
    /// <see href="http://securitytoolbox.appspot.com/stac#AccessControlMethod"></see></summary>
    let AccessControlMethod = _prefix "AccessControlMethod"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SecurityPropertyMethod"></see>
    /// </summary>
    let SecurityPropertyMethod = _prefix "SecurityPropertyMethod"
    /// <summary>
    /// Active attacks involve actions performed by adversaries to gain the control of the network.
    /// <see href="http://securitytoolbox.appspot.com/stac#ActiveAttack"></see></summary>
    let ActiveAttack = _prefix "ActiveAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Attack"></see>
    /// </summary>
    let Attack = _prefix "Attack"
    /// <summary>
    /// Anonymity protects user identity, making it hard to track the whereabouts of a certain user.
    /// <see href="http://securitytoolbox.appspot.com/stac#AnonymityMethod"></see></summary>
    let AnonymityMethod = _prefix "AnonymityMethod"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#AntiSpam"></see>
    /// </summary>
    let AntiSpam = _prefix "AntiSpam"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebSecurityMechanism"></see>
    /// </summary>
    let WebSecurityMechanism = _prefix "WebSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#AntiSpyware"></see>
    /// </summary>
    let AntiSpyware = _prefix "AntiSpyware"
    /// <summary>
    /// Anti-viruses softwares applications will reduce viruses and malware on M2M equipment.
    /// <see href="http://securitytoolbox.appspot.com/stac#Antivirus"></see></summary>
    let Antivirus = _prefix "Antivirus"
    /// <summary>
    /// Data integrity guarantees that the transmitted messages are not modified by attackers, either due to malicious intent or by accident.
    /// <see href="http://securitytoolbox.appspot.com/stac#IntegrityMethod"></see></summary>
    let IntegrityMethod = _prefix "IntegrityMethod"

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NetworkManagementSecurityMechanism"></see>
    /// </summary>
    let NetworkManagementSecurityMechanism =
        _prefix "NetworkManagementSecurityMechanism"

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#M2MSecurityMechanism"></see>
    /// </summary>
    let M2MSecurityMechanism = _prefix "M2MSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Architecture"></see>
    /// </summary>
    let Architecture = _prefix "Architecture"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ArchitectureComponent"></see>
    /// </summary>
    let ArchitectureComponent = _prefix "ArchitectureComponent"
    /// <summary>
    /// The keys used for encryption and decryption are different, allowing for easier key distribution.
    /// <see href="http://securitytoolbox.appspot.com/stac#AsymmetricAlgorithm"></see></summary>
    let AsymmetricAlgorithm = _prefix "AsymmetricAlgorithm"
    /// <summary>
    /// The public key is used for verifying a digital signature and is used for encryption.
    /// <see href="http://securitytoolbox.appspot.com/stac#PublicKey"></see></summary>
    let PublicKey = _prefix "PublicKey"
    /// <summary>
    /// The private key is used for computing signatures and decryption.
    /// <see href="http://securitytoolbox.appspot.com/stac#PrivateKey"></see></summary>
    let PrivateKey = _prefix "PrivateKey"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ExchangeKeyEasy"></see>
    /// </summary>
    let ExchangeKeyEasy = _prefix "ExchangeKeyEasy"
    /// <summary>
    /// A SecurityMechanism has specific features (secured, depreceted, low energy consuming). For example, an asymmetric algorithm is high energy consuming.
    /// <see href="http://securitytoolbox.appspot.com/stac#hasFeature"></see></summary>
    let hasFeature = _prefix "hasFeature"
    /// <summary>
    /// Encryption algorithm ensures the confidentiality property.
    /// <see href="http://securitytoolbox.appspot.com/stac#EncryptionAlgorithm"></see></summary>
    let EncryptionAlgorithm = _prefix "EncryptionAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HighEnergyConsuming"></see>
    /// </summary>
    let HighEnergyConsuming = _prefix "HighEnergyConsuming"
    /// <summary>
    /// Authentication prevents unauthorized access to the network.
    /// <see href="http://securitytoolbox.appspot.com/stac#AuthenticationMethod"></see></summary>
    let AuthenticationMethod = _prefix "AuthenticationMethod"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#AsymmetricKey"></see>
    /// </summary>
    let AsymmetricKey = _prefix "AsymmetricKey"
    /// <summary>
    /// It identifies the supplicant, checks its credentials, and define privileges and restrictions, and allows or denies it access to the network and services.
    /// <see href="http://securitytoolbox.appspot.com/stac#AuthenticationServer"></see></summary>
    let AuthenticationServer = _prefix "AuthenticationServer"
    /// <summary>
    /// Data availability ensures that the network is alive and that data are accessible.
    /// <see href="http://securitytoolbox.appspot.com/stac#AvailabilityMethod"></see></summary>
    let AvailabilityMethod = _prefix "AvailabilityMethod"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Badge"></see>
    /// </summary>
    let Badge = _prefix "Badge"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PhysicalAuthentication"></see>
    /// </summary>
    let PhysicalAuthentication = _prefix "PhysicalAuthentication"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Bank"></see>
    /// </summary>
    let Bank = _prefix "Bank"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#DataProvenanceType"></see>
    /// </summary>
    let DataProvenanceType = _prefix "DataProvenanceType"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#BlockCipher"></see>
    /// </summary>
    let BlockCipher = _prefix "BlockCipher"
    /// <summary>
    /// The same secret key is used for encryption and decryption.
    /// <see href="http://securitytoolbox.appspot.com/stac#SymmetricAlgorithm"></see></summary>
    let SymmetricAlgorithm = _prefix "SymmetricAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#BluetoothAttack"></see>
    /// </summary>
    let BluetoothAttack = _prefix "BluetoothAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#BluetoothSecurityMechanism"></see>
    /// </summary>
    let BluetoothSecurityMechanism = _prefix "BluetoothSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#hasSecurityMechanism"></see>
    /// </summary>
    let hasSecurityMechanism = _prefix "hasSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#BluetoothSecurityAlgorithm"></see>
    /// </summary>
    let BluetoothSecurityAlgorithm = _prefix "BluetoothSecurityAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SecurityAlgorithm"></see>
    /// </summary>
    let SecurityAlgorithm = _prefix "SecurityAlgorithm"
    /// <summary>
    /// A protocol for short-range (up to 100 meters) wireless networks.
    /// <see href="http://securitytoolbox.appspot.com/stac#BluetoothTechnology"></see></summary>
    let BluetoothTechnology = _prefix "BluetoothTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#protects"></see>
    /// </summary>
    let protects = _prefix "protects"
    /// <summary>
    /// Security Mechanisms are processes that are used to detect, prevent and recover from security attacks.
    /// <see href="http://securitytoolbox.appspot.com/stac#SecurityMechanism"></see></summary>
    let SecurityMechanism = _prefix "SecurityMechanism"
    /// <summary>
    /// A technology can be vulnerable to some attacks.
    /// <see href="http://securitytoolbox.appspot.com/stac#hasVulnerability"></see></summary>
    let hasVulnerability = _prefix "hasVulnerability"
    /// <summary>
    /// Technologies can be wireless (Wi-Fi, Wimax), cellular (2G, 3G, 4G), sensor  networks, web application, etc.
    /// <see href="http://securitytoolbox.appspot.com/stac#Technology"></see></summary>
    let Technology = _prefix "Technology"
    /// <summary>
    /// E.g. herat attack is a critical event. Criticaly is a context aware permission.
    /// <see href="http://securitytoolbox.appspot.com/stac#CA-RBAC"></see></summary>
    let ``CA-RBAC`` = _prefix "CA-RBAC"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Captcha"></see>
    /// </summary>
    let Captcha = _prefix "Captcha"
    /// <summary>
    /// Challenge/Response is a mechanism where on entity in the network proves to another entity that it knows the password without revealing it.
    /// <see href="http://securitytoolbox.appspot.com/stac#ChallengeResponse"></see></summary>
    let ChallengeResponse = _prefix "ChallengeResponse"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ChecksumAlgorithm"></see>
    /// </summary>
    let ChecksumAlgorithm = _prefix "ChecksumAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#CloudAttack"></see>
    /// </summary>
    let CloudAttack = _prefix "CloudAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#CloudSecurityMechanism"></see>
    /// </summary>
    let CloudSecurityMechanism = _prefix "CloudSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebAttack"></see>
    /// </summary>
    let WebAttack = _prefix "WebAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#CloudTechnology"></see>
    /// </summary>
    let CloudTechnology = _prefix "CloudTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebTechnology"></see>
    /// </summary>
    let WebTechnology = _prefix "WebTechnology"
    /// <summary>
    /// Confidentiality means that only destined user must be able to read data.
    /// <see href="http://securitytoolbox.appspot.com/stac#ConfidentialityMethod"></see></summary>
    let ConfidentialityMethod = _prefix "ConfidentialityMethod"
    /// <summary>
    /// Since the counter value is incremented after each message, the same message is encrypted differently each time.
    /// <see href="http://securitytoolbox.appspot.com/stac#CounterValue"></see></summary>
    let CounterValue = _prefix "CounterValue"
    /// <summary>
    /// Data freshness suggests that the data is recent, and it ensures that no old messages have been replayed.
    /// <see href="http://securitytoolbox.appspot.com/stac#DataFreshnessMethod"></see></summary>
    let DataFreshnessMethod = _prefix "DataFreshnessMethod"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#CryptographicConcept"></see>
    /// </summary>
    let CryptographicConcept = _prefix "CryptographicConcept"
    /// <summary>
    /// Object owners can add access rights.
    /// <see href="http://securitytoolbox.appspot.com/stac#DAC"></see></summary>
    let DAC = _prefix "DAC"
    /// <summary>
    /// DataTypeSensitive (low, medium or high sensitive). The data to secure.
    /// <see href="http://securitytoolbox.appspot.com/stac#DataTypeSensitive"></see></summary>
    let DataTypeSensitive = _prefix "DataTypeSensitive"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#DatabaseAttack"></see>
    /// </summary>
    let DatabaseAttack = _prefix "DatabaseAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#DatabaseSecurityMechanism"></see>
    /// </summary>
    let DatabaseSecurityMechanism = _prefix "DatabaseSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#DatabaseTechnology"></see>
    /// </summary>
    let DatabaseTechnology = _prefix "DatabaseTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#DigitalCertificate"></see>
    /// </summary>
    let DigitalCertificate = _prefix "DigitalCertificate"
    /// <summary>
    /// The digital signature verifies that the contents of the electronic message have not been altered.
    /// <see href="http://securitytoolbox.appspot.com/stac#DigitalSignature"></see></summary>
    let DigitalSignature = _prefix "DigitalSignature"
    /// <summary>
    /// Non repudiation means that a sender is unable to deny having sent a message or infoomation.
    /// <see href="http://securitytoolbox.appspot.com/stac#NonRepudiationMethod"></see></summary>
    let NonRepudiationMethod = _prefix "NonRepudiationMethod"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ECommerceAttack"></see>
    /// </summary>
    let ECommerceAttack = _prefix "ECommerceAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ECommerceSecurityMechanism"></see>
    /// </summary>
    let ECommerceSecurityMechanism = _prefix "ECommerceSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ECommerceMechanism"></see>
    /// </summary>
    let ECommerceMechanism = _prefix "ECommerceMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ECommerceTechnology"></see>
    /// </summary>
    let ECommerceTechnology = _prefix "ECommerceTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#EDGEAttack"></see>
    /// </summary>
    let EDGEAttack = _prefix "EDGEAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#EDGESecurityMechanism"></see>
    /// </summary>
    let EDGESecurityMechanism = _prefix "EDGESecurityMechanism"
    /// <summary>
    /// Enhanced Data Rates for GSM Evolution (EDGE) or 2.75G
    /// <see href="http://securitytoolbox.appspot.com/stac#EDGETechnology"></see></summary>
    let EDGETechnology = _prefix "EDGETechnology"
    /// <summary>
    /// Universal Mobile Telecommunications System (UMTS). Third Generation (3G)
    /// <see href="http://securitytoolbox.appspot.com/stac#UMTSTechnology"></see></summary>
    let UMTSTechnology = _prefix "UMTSTechnology"
    /// <summary>
    /// When a SecurityMechanism is not secured anymore, it is replaced by a more secure SecurityMechanism. This is also the case for technologies: a technology can be replaced by another one more recent. (E.G., 2G has been replaced by 3G)
    /// <see href="http://securitytoolbox.appspot.com/stac#isReplacedBy"></see></summary>
    let isReplacedBy = _prefix "isReplacedBy"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#EthernetAttack"></see>
    /// </summary>
    let EthernetAttack = _prefix "EthernetAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#EthernetSecurityMechanism"></see>
    /// </summary>
    let EthernetSecurityMechanism = _prefix "EthernetSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#EthernetTechnology"></see>
    /// </summary>
    let EthernetTechnology = _prefix "EthernetTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HighCostDeployment"></see>
    /// </summary>
    let HighCostDeployment = _prefix "HighCostDeployment"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ExternalAttack"></see>
    /// </summary>
    let ExternalAttack = _prefix "ExternalAttack"
    /// <summary>
    /// Features of security mechanisms. For example a sensor technology is low energy consuming, and the symmetric algorithm (a SecurityMechanism) is low energy consumming.
    /// <see href="http://securitytoolbox.appspot.com/stac#Feature"></see></summary>
    let Feature = _prefix "Feature"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Firewall"></see>
    /// </summary>
    let Firewall = _prefix "Firewall"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSSecurityMechanism"></see>
    /// </summary>
    let UMTSSecurityMechanism = _prefix "UMTSSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ApplicationLayer"></see>
    /// </summary>
    let ApplicationLayer = _prefix "ApplicationLayer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#protectsInLayer"></see>
    /// </summary>
    let protectsInLayer = _prefix "protectsInLayer"
    /// <summary>
    /// Floodings attacks generally are used to drain the memry resources by sensing the control signals.
    /// <see href="http://securitytoolbox.appspot.com/stac#Flooding"></see></summary>
    let Flooding = _prefix "Flooding"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#TransportLayer"></see>
    /// </summary>
    let TransportLayer = _prefix "TransportLayer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#occursInLayer"></see>
    /// </summary>
    let occursInLayer = _prefix "occursInLayer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ClientPuzzle"></see>
    /// </summary>
    let ClientPuzzle = _prefix "ClientPuzzle"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SensorAttack"></see>
    /// </summary>
    let SensorAttack = _prefix "SensorAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#FrameworkAttack"></see>
    /// </summary>
    let FrameworkAttack = _prefix "FrameworkAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#FrameworkSecurityMechanism"></see>
    /// </summary>
    let FrameworkSecurityMechanism = _prefix "FrameworkSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#FrameworkTechnology"></see>
    /// </summary>
    let FrameworkTechnology = _prefix "FrameworkTechnology"
    /// <summary>
    /// The GPRS system are a much more expesed to intruders, because of its IP based backbone.
    /// <see href="http://securitytoolbox.appspot.com/stac#GPRSArchitecture"></see></summary>
    let GPRSArchitecture = _prefix "GPRSArchitecture"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GPRSArchitectureComponent"></see>
    /// </summary>
    let GPRSArchitectureComponent = _prefix "GPRSArchitectureComponent"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GPRSAttack"></see>
    /// </summary>
    let GPRSAttack = _prefix "GPRSAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GPRSSecurityMechanism"></see>
    /// </summary>
    let GPRSSecurityMechanism = _prefix "GPRSSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GPRSSecurityAlgorithm"></see>
    /// </summary>
    let GPRSSecurityAlgorithm = _prefix "GPRSSecurityAlgorithm"
    /// <summary>
    /// General Packet Radio Service (GPRS) or 2.5G
    /// <see href="http://securitytoolbox.appspot.com/stac#GPRSTechnology"></see></summary>
    let GPRSTechnology = _prefix "GPRSTechnology"
    /// <summary>
    /// A technology has a specific architecture.
    /// <see href="http://securitytoolbox.appspot.com/stac#hasArchitecture"></see></summary>
    let hasArchitecture = _prefix "hasArchitecture"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMArchitecture"></see>
    /// </summary>
    let GSMArchitecture = _prefix "GSMArchitecture"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMArchitectureComponent"></see>
    /// </summary>
    let GSMArchitectureComponent = _prefix "GSMArchitectureComponent"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMAttack"></see>
    /// </summary>
    let GSMAttack = _prefix "GSMAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMSecurityMechanism"></see>
    /// </summary>
    let GSMSecurityMechanism = _prefix "GSMSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMKeyManagement"></see>
    /// </summary>
    let GSMKeyManagement = _prefix "GSMKeyManagement"
    /// <summary>
    /// Key management protocols are fundamental requirements to develop a secure application. These protocols are used to set up and distribute various kinds of cryptographic keys to nodes in the network.
    /// <see href="http://securitytoolbox.appspot.com/stac#KeyManagement"></see></summary>
    let KeyManagement = _prefix "KeyManagement"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMSecurityAlgorithm"></see>
    /// </summary>
    let GSMSecurityAlgorithm = _prefix "GSMSecurityAlgorithm"
    /// <summary>
    /// Global System for Mobile Communication (GSM) or 2G
    /// <see href="http://securitytoolbox.appspot.com/stac#GSMTechnology"></see></summary>
    let GSMTechnology = _prefix "GSMTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMSecurityProtocol"></see>
    /// </summary>
    let GSMSecurityProtocol = _prefix "GSMSecurityProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Protocol"></see>
    /// </summary>
    let Protocol = _prefix "Protocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HSPDAAttack"></see>
    /// </summary>
    let HSPDAAttack = _prefix "HSPDAAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HSPDASecurityMechanism"></see>
    /// </summary>
    let HSPDASecurityMechanism = _prefix "HSPDASecurityMechanism"
    /// <summary>
    /// High-Speed Download Packet Access (HSPDA) or 3.5G
    /// <see href="http://securitytoolbox.appspot.com/stac#HSPDATechnology"></see></summary>
    let HSPDATechnology = _prefix "HSPDATechnology"
    /// <summary>
    /// Long Term Evolution (LTE) Technology or 4G
    /// <see href="http://securitytoolbox.appspot.com/stac#LTETechnology"></see></summary>
    let LTETechnology = _prefix "LTETechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HashFunction"></see>
    /// </summary>
    let HashFunction = _prefix "HashFunction"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HighSensitive"></see>
    /// </summary>
    let HighSensitive = _prefix "HighSensitive"
    /// <summary>
    /// Honeypots are hosts meant to be attacked either to distract the attackers or to research their techniques.
    /// <see href="http://securitytoolbox.appspot.com/stac#Honeypot"></see></summary>
    let Honeypot = _prefix "Honeypot"
    /// <summary>
    /// The purpose of this value is to enable the receiver to detect any malicious modifications of the message by an attacker.
    /// <see href="http://securitytoolbox.appspot.com/stac#ICV"></see></summary>
    let ICV = _prefix "ICV"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#IDS"></see>
    /// </summary>
    let IDS = _prefix "IDS"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#IPS"></see>
    /// </summary>
    let IPS = _prefix "IPS"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#InitialVector"></see>
    /// </summary>
    let InitialVector = _prefix "InitialVector"
    /// <summary>
    /// Semantic security ensures that an eavesdropper has no information about the message, even if it sees multiple encryptions of the same messages.
    /// <see href="http://securitytoolbox.appspot.com/stac#SemanticSecurityMethod"></see></summary>
    let SemanticSecurityMethod = _prefix "SemanticSecurityMethod"
    /// <summary>
    /// Internal attacks are launched from compromised nodes, are much more sophisticated than external attacks.
    /// <see href="http://securitytoolbox.appspot.com/stac#InternalAttack"></see></summary>
    let InternalAttack = _prefix "InternalAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#JavaSecurityApi"></see>
    /// </summary>
    let JavaSecurityApi = _prefix "JavaSecurityApi"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LTEArchitecture"></see>
    /// </summary>
    let LTEArchitecture = _prefix "LTEArchitecture"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LTEArchitectureComponent"></see>
    /// </summary>
    let LTEArchitectureComponent = _prefix "LTEArchitectureComponent"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LTEAttack"></see>
    /// </summary>
    let LTEAttack = _prefix "LTEAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LTESecurityMechanism"></see>
    /// </summary>
    let LTESecurityMechanism = _prefix "LTESecurityMechanism"
    /// <summary>
    /// The simple form of authentication is providing a user name and password which is mainly the case in internet based authentication (e.g. email, online shopping, etc)
    /// <see href="http://securitytoolbox.appspot.com/stac#LoginPassword"></see></summary>
    let LoginPassword = _prefix "LoginPassword"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LowSensitive"></see>
    /// </summary>
    let LowSensitive = _prefix "LowSensitive"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#M2MAttack"></see>
    /// </summary>
    let M2MAttack = _prefix "M2MAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#M2MTechnology"></see>
    /// </summary>
    let M2MTechnology = _prefix "M2MTechnology"
    /// <summary>
    /// MAC is a short piece of information used to authenticate a message and check the integrity.
    /// <see href="http://securitytoolbox.appspot.com/stac#MAC"></see></summary>
    let MAC = _prefix "MAC"
    /// <summary>
    /// Only an administrator is authorized to add a new access right to the system.
    /// <see href="http://securitytoolbox.appspot.com/stac#MandatoryAccessControl"></see></summary>
    let MandatoryAccessControl = _prefix "MandatoryAccessControl"
    /// <summary>
    /// Manet (Mobile ad hoc network) is a self-configuring network of mobile devices connected.
    /// <see href="http://securitytoolbox.appspot.com/stac#ManetAttack"></see></summary>
    let ManetAttack = _prefix "ManetAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ManetSecurityMechanism"></see>
    /// </summary>
    let ManetSecurityMechanism = _prefix "ManetSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ManetTechnology"></see>
    /// </summary>
    let ManetTechnology = _prefix "ManetTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MediumSensitive"></see>
    /// </summary>
    let MediumSensitive = _prefix "MediumSensitive"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshArchitecture"></see>
    /// </summary>
    let MeshArchitecture = _prefix "MeshArchitecture"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Flexible"></see>
    /// </summary>
    let Flexible = _prefix "Flexible"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Scalable"></see>
    /// </summary>
    let Scalable = _prefix "Scalable"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LowCostDeployment"></see>
    /// </summary>
    let LowCostDeployment = _prefix "LowCostDeployment"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshArchitectureComponent"></see>
    /// </summary>
    let MeshArchitectureComponent = _prefix "MeshArchitectureComponent"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshAttack"></see>
    /// </summary>
    let MeshAttack = _prefix "MeshAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshSecurityMechanism"></see>
    /// </summary>
    let MeshSecurityMechanism = _prefix "MeshSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshKeyManagement"></see>
    /// </summary>
    let MeshKeyManagement = _prefix "MeshKeyManagement"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshTechnology"></see>
    /// </summary>
    let MeshTechnology = _prefix "MeshTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshSecurityProtocol"></see>
    /// </summary>
    let MeshSecurityProtocol = _prefix "MeshSecurityProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MessageEncryptionTool"></see>
    /// </summary>
    let MessageEncryptionTool = _prefix "MessageEncryptionTool"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SecurityTool"></see>
    /// </summary>
    let SecurityTool = _prefix "SecurityTool"
    /// <summary>
    /// A mode of operation describes the process of encrypting each of block cipher.
    /// <see href="http://securitytoolbox.appspot.com/stac#ModeOperation"></see></summary>
    let ModeOperation = _prefix "ModeOperation"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MutualAuthentication"></see>
    /// </summary>
    let MutualAuthentication = _prefix "MutualAuthentication"
    /// <summary>
    /// Negative Feature of security mechanisms
    /// <see href="http://securitytoolbox.appspot.com/stac#NegativeFeature"></see></summary>
    let NegativeFeature = _prefix "NegativeFeature"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NetworkManagementAttack"></see>
    /// </summary>
    let NetworkManagementAttack = _prefix "NetworkManagementAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NetworkManagementTechnology"></see>
    /// </summary>
    let NetworkManagementTechnology = _prefix "NetworkManagementTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NetworkManagementSecurityTool"></see>
    /// </summary>
    let NetworkManagementSecurityTool = _prefix "NetworkManagementSecurityTool"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OSIModel"></see>
    /// </summary>
    let OSIModel = _prefix "OSIModel"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PhysicalLayer"></see>
    /// </summary>
    let PhysicalLayer = _prefix "PhysicalLayer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LinkLayer"></see>
    /// </summary>
    let LinkLayer = _prefix "LinkLayer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NetworkLayer"></see>
    /// </summary>
    let NetworkLayer = _prefix "NetworkLayer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SessionLayer"></see>
    /// </summary>
    let SessionLayer = _prefix "SessionLayer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PresentationLayer"></see>
    /// </summary>
    let PresentationLayer = _prefix "PresentationLayer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OSIModelLayer"></see>
    /// </summary>
    let OSIModelLayer = _prefix "OSIModelLayer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Obfuscation"></see>
    /// </summary>
    let Obfuscation = _prefix "Obfuscation"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OneWayAuthentication"></see>
    /// </summary>
    let OneWayAuthentication = _prefix "OneWayAuthentication"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OperatingSystemAttack"></see>
    /// </summary>
    let OperatingSystemAttack = _prefix "OperatingSystemAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OperatingSystemSecurityMechanism"></see>
    /// </summary>
    let OperatingSystemSecurityMechanism = _prefix "OperatingSystemSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OperatingSystemTechnology"></see>
    /// </summary>
    let OperatingSystemTechnology = _prefix "OperatingSystemTechnology"
    /// <summary>
    /// Malicious users violate the confidentiality  of the information exchanged over the network.
    /// <see href="http://securitytoolbox.appspot.com/stac#PassiveAttack"></see></summary>
    let PassiveAttack = _prefix "PassiveAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Personal"></see>
    /// </summary>
    let Personal = _prefix "Personal"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PhysicalKey"></see>
    /// </summary>
    let PhysicalKey = _prefix "PhysicalKey"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PolymorphicVirus"></see>
    /// </summary>
    let PolymorphicVirus = _prefix "PolymorphicVirus"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Virus"></see>
    /// </summary>
    let Virus = _prefix "Virus"
    /// <summary>
    /// Positive Feature of security mechanisms
    /// <see href="http://securitytoolbox.appspot.com/stac#PositiveFeature"></see></summary>
    let PositiveFeature = _prefix "PositiveFeature"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PreSharedKey"></see>
    /// </summary>
    let PreSharedKey = _prefix "PreSharedKey"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageAttack"></see>
    /// </summary>
    let ProgrammingLanguageAttack = _prefix "ProgrammingLanguageAttack"

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageSecurityMechanism"></see>
    /// </summary>
    let ProgrammingLanguageSecurityMechanism =
        _prefix "ProgrammingLanguageSecurityMechanism"

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageTechnology"></see>
    /// </summary>
    let ProgrammingLanguageTechnology = _prefix "ProgrammingLanguageTechnology"
    /// <summary>
    /// A proxy analyzes application commands, performs authentication and keeps logs.
    /// <see href="http://securitytoolbox.appspot.com/stac#Proxy"></see></summary>
    let Proxy = _prefix "Proxy"
    /// <summary>
    /// Mechanism for access control that organizes users (in the system) into specific groups called Roles. E.g., Doctor and nurses are different roles in a hospital.
    /// <see href="http://securitytoolbox.appspot.com/stac#RBAC"></see></summary>
    let RBAC = _prefix "RBAC"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NotFlexible"></see>
    /// </summary>
    let NotFlexible = _prefix "NotFlexible"
    /// <summary>
    /// Permissions are modeled as relations between users (subjects) and data (objects).
    /// <see href="http://securitytoolbox.appspot.com/stac#RelBAC"></see></summary>
    let RelBAC = _prefix "RelBAC"
    /// <summary>
    /// The application to secure has requirements (e.g., high sensitive data or specific technologies).
    /// <see href="http://securitytoolbox.appspot.com/stac#Requirement"></see></summary>
    let Requirement = _prefix "Requirement"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ReverseProxy"></see>
    /// </summary>
    let ReverseProxy = _prefix "ReverseProxy"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#RfidAttack"></see>
    /// </summary>
    let RfidAttack = _prefix "RfidAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#RfidSecurityMechanism"></see>
    /// </summary>
    let RfidSecurityMechanism = _prefix "RfidSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#RfidTechnology"></see>
    /// </summary>
    let RfidTechnology = _prefix "RfidTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SecurityMagazine"></see>
    /// </summary>
    let SecurityMagazine = _prefix "SecurityMagazine"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SecurityProperty"></see>
    /// </summary>
    let SecurityProperty = _prefix "SecurityProperty"
    /// <summary>
    /// Sensor nodes have very limited computationnal power, and traditional security and encryption techniques are not-well suitd to this domain.
    /// <see href="http://securitytoolbox.appspot.com/stac#SensorSecurityMechanism"></see></summary>
    let SensorSecurityMechanism = _prefix "SensorSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SensorKeyManagement"></see>
    /// </summary>
    let SensorKeyManagement = _prefix "SensorKeyManagement"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SensorTechnology"></see>
    /// </summary>
    let SensorTechnology = _prefix "SensorTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SensorSecurityProtocol"></see>
    /// </summary>
    let SensorSecurityProtocol = _prefix "SensorSecurityProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ServerAttack"></see>
    /// </summary>
    let ServerAttack = _prefix "ServerAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ServerSecurityMechanism"></see>
    /// </summary>
    let ServerSecurityMechanism = _prefix "ServerSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ServerTechnology"></see>
    /// </summary>
    let ServerTechnology = _prefix "ServerTechnology"
    /// <summary>
    /// A Sniffer tries to spy passwords for instance.
    /// <see href="http://securitytoolbox.appspot.com/stac#Sniffer"></see></summary>
    let Sniffer = _prefix "Sniffer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Spam"></see>
    /// </summary>
    let Spam = _prefix "Spam"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Spyware"></see>
    /// </summary>
    let Spyware = _prefix "Spyware"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#StreamCipher"></see>
    /// </summary>
    let StreamCipher = _prefix "StreamCipher"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LowEnergyConsuming"></see>
    /// </summary>
    let LowEnergyConsuming = _prefix "LowEnergyConsuming"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ExchangeKeyNotEasy"></see>
    /// </summary>
    let ExchangeKeyNotEasy = _prefix "ExchangeKeyNotEasy"
    /// <summary>
    /// Symmetric key: the same key is used for encryption and decryption.
    /// <see href="http://securitytoolbox.appspot.com/stac#SymmetricKey"></see></summary>
    let SymmetricKey = _prefix "SymmetricKey"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SymmetricSensorKey"></see>
    /// </summary>
    let SymmetricSensorKey = _prefix "SymmetricSensorKey"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SystemLogs"></see>
    /// </summary>
    let SystemLogs = _prefix "SystemLogs"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#TemporaryIdentity"></see>
    /// </summary>
    let TemporaryIdentity = _prefix "TemporaryIdentity"
    /// <summary>
    /// In order to ensure the freshness of packet, a timestamp can be attached to the packet. A receiving node can compare the timestamp in the packet with its own time clock and determine whether the packet is valid or not.
    /// <see href="http://securitytoolbox.appspot.com/stac#Timestamp"></see></summary>
    let Timestamp = _prefix "Timestamp"
    /// <summary>
    /// A Trojan horse is a malicious piece of software hidden in a program that performs normal tasks. Program that does something malicious (such as capturing passwords) when run by an unsuspecting user.
    /// <see href="http://securitytoolbox.appspot.com/stac#Troyan"></see></summary>
    let Troyan = _prefix "Troyan"
    /// <summary>
    /// Some attacks cannot be thwart in technologies. For example, the Denial of Service is difficult to thwart in different technologies.
    /// <see href="http://securitytoolbox.appspot.com/stac#isVulnerabilityOf"></see></summary>
    let isVulnerabilityOf = _prefix "isVulnerabilityOf"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSArchitecture"></see>
    /// </summary>
    let UMTSArchitecture = _prefix "UMTSArchitecture"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSArchitectureComponent"></see>
    /// </summary>
    let UMTSArchitectureComponent = _prefix "UMTSArchitectureComponent"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSAttack"></see>
    /// </summary>
    let UMTSAttack = _prefix "UMTSAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSKeyManagement"></see>
    /// </summary>
    let UMTSKeyManagement = _prefix "UMTSKeyManagement"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSSecurityAlgorithm"></see>
    /// </summary>
    let UMTSSecurityAlgorithm = _prefix "UMTSSecurityAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSSecurityProtocol"></see>
    /// </summary>
    let UMTSSecurityProtocol = _prefix "UMTSSecurityProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UwbAttack"></see>
    /// </summary>
    let UwbAttack = _prefix "UwbAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UwbSecurityMechanism"></see>
    /// </summary>
    let UwbSecurityMechanism = _prefix "UwbSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UwbTechnology"></see>
    /// </summary>
    let UwbTechnology = _prefix "UwbTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebSecurityProtocol"></see>
    /// </summary>
    let WebSecurityProtocol = _prefix "WebSecurityProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebService"></see>
    /// </summary>
    let WebService = _prefix "WebService"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebServiceAttack"></see>
    /// </summary>
    let WebServiceAttack = _prefix "WebServiceAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebServiceSecurityMechanism"></see>
    /// </summary>
    let WebServiceSecurityMechanism = _prefix "WebServiceSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebServiceMechanism"></see>
    /// </summary>
    let WebServiceMechanism = _prefix "WebServiceMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebServiceTechnology"></see>
    /// </summary>
    let WebServiceTechnology = _prefix "WebServiceTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiArchitecture"></see>
    /// </summary>
    let WifiArchitecture = _prefix "WifiArchitecture"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiArchitectureComponent"></see>
    /// </summary>
    let WifiArchitectureComponent = _prefix "WifiArchitectureComponent"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiAttack"></see>
    /// </summary>
    let WifiAttack = _prefix "WifiAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiSecurityMechanism"></see>
    /// </summary>
    let WifiSecurityMechanism = _prefix "WifiSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiAttackTool"></see>
    /// </summary>
    let WifiAttackTool = _prefix "WifiAttackTool"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiKeyManagement"></see>
    /// </summary>
    let WifiKeyManagement = _prefix "WifiKeyManagement"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiTechnology"></see>
    /// </summary>
    let WifiTechnology = _prefix "WifiTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiSecurityProtocol"></see>
    /// </summary>
    let WifiSecurityProtocol = _prefix "WifiSecurityProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxArchitecture"></see>
    /// </summary>
    let WimaxArchitecture = _prefix "WimaxArchitecture"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxArchitectureComponent"></see>
    /// </summary>
    let WimaxArchitectureComponent = _prefix "WimaxArchitectureComponent"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxAttack"></see>
    /// </summary>
    let WimaxAttack = _prefix "WimaxAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxSecurityMechanism"></see>
    /// </summary>
    let WimaxSecurityMechanism = _prefix "WimaxSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxKeyManagement"></see>
    /// </summary>
    let WimaxKeyManagement = _prefix "WimaxKeyManagement"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxTechnology"></see>
    /// </summary>
    let WimaxTechnology = _prefix "WimaxTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxSecurityProtocol"></see>
    /// </summary>
    let WimaxSecurityProtocol = _prefix "WimaxSecurityProtocol"
    /// <summary>
    /// Worms are self-propagating pieces of malicious software. They propagate from one computer/device to another via a network link.
    /// <see href="http://securitytoolbox.appspot.com/stac#Worm"></see></summary>
    let Worm = _prefix "Worm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ZigbeeAttack"></see>
    /// </summary>
    let ZigbeeAttack = _prefix "ZigbeeAttack"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ZigbeeSecurityMechanism"></see>
    /// </summary>
    let ZigbeeSecurityMechanism = _prefix "ZigbeeSecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ZigbeeTechnology"></see>
    /// </summary>
    let ZigbeeTechnology = _prefix "ZigbeeTechnology"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LowCost"></see>
    /// </summary>
    let LowCost = _prefix "LowCost"
    /// <summary>
    /// Features are related to security mechanisms. For example, an asymmetric algorithm is high energy consuming.
    /// <see href="http://securitytoolbox.appspot.com/stac#isFeatureOf"></see></summary>
    let isFeatureOf = _prefix "isFeatureOf"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#hasModeOperation"></see>
    /// </summary>
    let hasModeOperation = _prefix "hasModeOperation"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#isSecurityMechanismOf"></see>
    /// </summary>
    let isSecurityMechanismOf = _prefix "isSecurityMechanismOf"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#isProtectedBy"></see>
    /// </summary>
    let isProtectedBy = _prefix "isProtectedBy"
    /// <summary>
    /// A security mechanism (e.g., VPN) satisfies some security properties (e.g., authentication)
    /// <see href="http://securitytoolbox.appspot.com/stac#satisfies"></see></summary>
    let satisfies = _prefix "satisfies"
    /// <summary>
    /// An attack (e.g., eavesdropping) threatens some security properties (e.g., confidentiality)
    /// <see href="http://securitytoolbox.appspot.com/stac#threatens"></see></summary>
    let threatens = _prefix "threatens"
