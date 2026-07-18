namespace http.securitytoolbox.appspot.com.stac.hash

open DoxAletheia.Rdf_Vocabulary

module stac =
    let _namespace_name = "http://securitytoolbox.appspot.com/stac#"
    /// <summary>
    /// Permissions are associated with a set of rules expressed on measurable parameters and are granted to users who can prove compliance with these rules.
    /// <see href="http://securitytoolbox.appspot.com/stac#ABAC"></see></summary>
    let ABAC = Namespaced_IRI.parse _namespace_name "ABAC" |> NamespacedName

    /// <summary>
    /// Access Control is the mechanism that allows owners of resources to define, manage and enforce access conditions applicable to each resource.
    /// <see href="http://securitytoolbox.appspot.com/stac#AccessControlMethod"></see></summary>
    let AccessControlMethod =
        Namespaced_IRI.parse _namespace_name "AccessControlMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SecurityPropertyMethod"></see>
    /// </summary>
    let SecurityPropertyMethod =
        Namespaced_IRI.parse _namespace_name "SecurityPropertyMethod" |> NamespacedName

    /// <summary>
    /// Active attacks involve actions performed by adversaries to gain the control of the network.
    /// <see href="http://securitytoolbox.appspot.com/stac#ActiveAttack"></see></summary>
    let ActiveAttack =
        Namespaced_IRI.parse _namespace_name "ActiveAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Attack"></see>
    /// </summary>
    let Attack = Namespaced_IRI.parse _namespace_name "Attack" |> NamespacedName

    /// <summary>
    /// Anonymity protects user identity, making it hard to track the whereabouts of a certain user.
    /// <see href="http://securitytoolbox.appspot.com/stac#AnonymityMethod"></see></summary>
    let AnonymityMethod =
        Namespaced_IRI.parse _namespace_name "AnonymityMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#AntiSpam"></see>
    /// </summary>
    let AntiSpam = Namespaced_IRI.parse _namespace_name "AntiSpam" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebSecurityMechanism"></see>
    /// </summary>
    let WebSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "WebSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#AntiSpyware"></see>
    /// </summary>
    let AntiSpyware =
        Namespaced_IRI.parse _namespace_name "AntiSpyware" |> NamespacedName

    /// <summary>
    /// Anti-viruses softwares applications will reduce viruses and malware on M2M equipment.
    /// <see href="http://securitytoolbox.appspot.com/stac#Antivirus"></see></summary>
    let Antivirus = Namespaced_IRI.parse _namespace_name "Antivirus" |> NamespacedName

    /// <summary>
    /// Data integrity guarantees that the transmitted messages are not modified by attackers, either due to malicious intent or by accident.
    /// <see href="http://securitytoolbox.appspot.com/stac#IntegrityMethod"></see></summary>
    let IntegrityMethod =
        Namespaced_IRI.parse _namespace_name "IntegrityMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NetworkManagementSecurityMechanism"></see>
    /// </summary>
    let NetworkManagementSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "NetworkManagementSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#M2MSecurityMechanism"></see>
    /// </summary>
    let M2MSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "M2MSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Architecture"></see>
    /// </summary>
    let Architecture =
        Namespaced_IRI.parse _namespace_name "Architecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ArchitectureComponent"></see>
    /// </summary>
    let ArchitectureComponent =
        Namespaced_IRI.parse _namespace_name "ArchitectureComponent" |> NamespacedName

    /// <summary>
    /// The keys used for encryption and decryption are different, allowing for easier key distribution.
    /// <see href="http://securitytoolbox.appspot.com/stac#AsymmetricAlgorithm"></see></summary>
    let AsymmetricAlgorithm =
        Namespaced_IRI.parse _namespace_name "AsymmetricAlgorithm" |> NamespacedName

    /// <summary>
    /// The public key is used for verifying a digital signature and is used for encryption.
    /// <see href="http://securitytoolbox.appspot.com/stac#PublicKey"></see></summary>
    let PublicKey = Namespaced_IRI.parse _namespace_name "PublicKey" |> NamespacedName
    /// <summary>
    /// The private key is used for computing signatures and decryption.
    /// <see href="http://securitytoolbox.appspot.com/stac#PrivateKey"></see></summary>
    let PrivateKey = Namespaced_IRI.parse _namespace_name "PrivateKey" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ExchangeKeyEasy"></see>
    /// </summary>
    let ExchangeKeyEasy =
        Namespaced_IRI.parse _namespace_name "ExchangeKeyEasy" |> NamespacedName

    /// <summary>
    /// A SecurityMechanism has specific features (secured, depreceted, low energy consuming). For example, an asymmetric algorithm is high energy consuming.
    /// <see href="http://securitytoolbox.appspot.com/stac#hasFeature"></see></summary>
    let hasFeature = Namespaced_IRI.parse _namespace_name "hasFeature" |> NamespacedName

    /// <summary>
    /// Encryption algorithm ensures the confidentiality property.
    /// <see href="http://securitytoolbox.appspot.com/stac#EncryptionAlgorithm"></see></summary>
    let EncryptionAlgorithm =
        Namespaced_IRI.parse _namespace_name "EncryptionAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HighEnergyConsuming"></see>
    /// </summary>
    let HighEnergyConsuming =
        Namespaced_IRI.parse _namespace_name "HighEnergyConsuming" |> NamespacedName

    /// <summary>
    /// Authentication prevents unauthorized access to the network.
    /// <see href="http://securitytoolbox.appspot.com/stac#AuthenticationMethod"></see></summary>
    let AuthenticationMethod =
        Namespaced_IRI.parse _namespace_name "AuthenticationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#AsymmetricKey"></see>
    /// </summary>
    let AsymmetricKey =
        Namespaced_IRI.parse _namespace_name "AsymmetricKey" |> NamespacedName

    /// <summary>
    /// It identifies the supplicant, checks its credentials, and define privileges and restrictions, and allows or denies it access to the network and services.
    /// <see href="http://securitytoolbox.appspot.com/stac#AuthenticationServer"></see></summary>
    let AuthenticationServer =
        Namespaced_IRI.parse _namespace_name "AuthenticationServer" |> NamespacedName

    /// <summary>
    /// Data availability ensures that the network is alive and that data are accessible.
    /// <see href="http://securitytoolbox.appspot.com/stac#AvailabilityMethod"></see></summary>
    let AvailabilityMethod =
        Namespaced_IRI.parse _namespace_name "AvailabilityMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Badge"></see>
    /// </summary>
    let Badge = Namespaced_IRI.parse _namespace_name "Badge" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PhysicalAuthentication"></see>
    /// </summary>
    let PhysicalAuthentication =
        Namespaced_IRI.parse _namespace_name "PhysicalAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Bank"></see>
    /// </summary>
    let Bank = Namespaced_IRI.parse _namespace_name "Bank" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#DataProvenanceType"></see>
    /// </summary>
    let DataProvenanceType =
        Namespaced_IRI.parse _namespace_name "DataProvenanceType" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#BlockCipher"></see>
    /// </summary>
    let BlockCipher =
        Namespaced_IRI.parse _namespace_name "BlockCipher" |> NamespacedName

    /// <summary>
    /// The same secret key is used for encryption and decryption.
    /// <see href="http://securitytoolbox.appspot.com/stac#SymmetricAlgorithm"></see></summary>
    let SymmetricAlgorithm =
        Namespaced_IRI.parse _namespace_name "SymmetricAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#BluetoothAttack"></see>
    /// </summary>
    let BluetoothAttack =
        Namespaced_IRI.parse _namespace_name "BluetoothAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#BluetoothSecurityMechanism"></see>
    /// </summary>
    let BluetoothSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "BluetoothSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#hasSecurityMechanism"></see>
    /// </summary>
    let hasSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "hasSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#BluetoothSecurityAlgorithm"></see>
    /// </summary>
    let BluetoothSecurityAlgorithm =
        Namespaced_IRI.parse _namespace_name "BluetoothSecurityAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SecurityAlgorithm"></see>
    /// </summary>
    let SecurityAlgorithm =
        Namespaced_IRI.parse _namespace_name "SecurityAlgorithm" |> NamespacedName

    /// <summary>
    /// A protocol for short-range (up to 100 meters) wireless networks.
    /// <see href="http://securitytoolbox.appspot.com/stac#BluetoothTechnology"></see></summary>
    let BluetoothTechnology =
        Namespaced_IRI.parse _namespace_name "BluetoothTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#protects"></see>
    /// </summary>
    let protects = Namespaced_IRI.parse _namespace_name "protects" |> NamespacedName

    /// <summary>
    /// Security Mechanisms are processes that are used to detect, prevent and recover from security attacks.
    /// <see href="http://securitytoolbox.appspot.com/stac#SecurityMechanism"></see></summary>
    let SecurityMechanism =
        Namespaced_IRI.parse _namespace_name "SecurityMechanism" |> NamespacedName

    /// <summary>
    /// A technology can be vulnerable to some attacks.
    /// <see href="http://securitytoolbox.appspot.com/stac#hasVulnerability"></see></summary>
    let hasVulnerability =
        Namespaced_IRI.parse _namespace_name "hasVulnerability" |> NamespacedName

    /// <summary>
    /// Technologies can be wireless (Wi-Fi, Wimax), cellular (2G, 3G, 4G), sensor  networks, web application, etc.
    /// <see href="http://securitytoolbox.appspot.com/stac#Technology"></see></summary>
    let Technology = Namespaced_IRI.parse _namespace_name "Technology" |> NamespacedName
    /// <summary>
    /// E.g. herat attack is a critical event. Criticaly is a context aware permission.
    /// <see href="http://securitytoolbox.appspot.com/stac#CA-RBAC"></see></summary>
    let ``CA-RBAC`` = Namespaced_IRI.parse _namespace_name "CA-RBAC" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Captcha"></see>
    /// </summary>
    let Captcha = Namespaced_IRI.parse _namespace_name "Captcha" |> NamespacedName

    /// <summary>
    /// Challenge/Response is a mechanism where on entity in the network proves to another entity that it knows the password without revealing it.
    /// <see href="http://securitytoolbox.appspot.com/stac#ChallengeResponse"></see></summary>
    let ChallengeResponse =
        Namespaced_IRI.parse _namespace_name "ChallengeResponse" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ChecksumAlgorithm"></see>
    /// </summary>
    let ChecksumAlgorithm =
        Namespaced_IRI.parse _namespace_name "ChecksumAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#CloudAttack"></see>
    /// </summary>
    let CloudAttack =
        Namespaced_IRI.parse _namespace_name "CloudAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#CloudSecurityMechanism"></see>
    /// </summary>
    let CloudSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "CloudSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebAttack"></see>
    /// </summary>
    let WebAttack = Namespaced_IRI.parse _namespace_name "WebAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#CloudTechnology"></see>
    /// </summary>
    let CloudTechnology =
        Namespaced_IRI.parse _namespace_name "CloudTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebTechnology"></see>
    /// </summary>
    let WebTechnology =
        Namespaced_IRI.parse _namespace_name "WebTechnology" |> NamespacedName

    /// <summary>
    /// Confidentiality means that only destined user must be able to read data.
    /// <see href="http://securitytoolbox.appspot.com/stac#ConfidentialityMethod"></see></summary>
    let ConfidentialityMethod =
        Namespaced_IRI.parse _namespace_name "ConfidentialityMethod" |> NamespacedName

    /// <summary>
    /// Since the counter value is incremented after each message, the same message is encrypted differently each time.
    /// <see href="http://securitytoolbox.appspot.com/stac#CounterValue"></see></summary>
    let CounterValue =
        Namespaced_IRI.parse _namespace_name "CounterValue" |> NamespacedName

    /// <summary>
    /// Data freshness suggests that the data is recent, and it ensures that no old messages have been replayed.
    /// <see href="http://securitytoolbox.appspot.com/stac#DataFreshnessMethod"></see></summary>
    let DataFreshnessMethod =
        Namespaced_IRI.parse _namespace_name "DataFreshnessMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#CryptographicConcept"></see>
    /// </summary>
    let CryptographicConcept =
        Namespaced_IRI.parse _namespace_name "CryptographicConcept" |> NamespacedName

    /// <summary>
    /// Object owners can add access rights.
    /// <see href="http://securitytoolbox.appspot.com/stac#DAC"></see></summary>
    let DAC = Namespaced_IRI.parse _namespace_name "DAC" |> NamespacedName

    /// <summary>
    /// DataTypeSensitive (low, medium or high sensitive). The data to secure.
    /// <see href="http://securitytoolbox.appspot.com/stac#DataTypeSensitive"></see></summary>
    let DataTypeSensitive =
        Namespaced_IRI.parse _namespace_name "DataTypeSensitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#DatabaseAttack"></see>
    /// </summary>
    let DatabaseAttack =
        Namespaced_IRI.parse _namespace_name "DatabaseAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#DatabaseSecurityMechanism"></see>
    /// </summary>
    let DatabaseSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "DatabaseSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#DatabaseTechnology"></see>
    /// </summary>
    let DatabaseTechnology =
        Namespaced_IRI.parse _namespace_name "DatabaseTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#DigitalCertificate"></see>
    /// </summary>
    let DigitalCertificate =
        Namespaced_IRI.parse _namespace_name "DigitalCertificate" |> NamespacedName

    /// <summary>
    /// The digital signature verifies that the contents of the electronic message have not been altered.
    /// <see href="http://securitytoolbox.appspot.com/stac#DigitalSignature"></see></summary>
    let DigitalSignature =
        Namespaced_IRI.parse _namespace_name "DigitalSignature" |> NamespacedName

    /// <summary>
    /// Non repudiation means that a sender is unable to deny having sent a message or infoomation.
    /// <see href="http://securitytoolbox.appspot.com/stac#NonRepudiationMethod"></see></summary>
    let NonRepudiationMethod =
        Namespaced_IRI.parse _namespace_name "NonRepudiationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ECommerceAttack"></see>
    /// </summary>
    let ECommerceAttack =
        Namespaced_IRI.parse _namespace_name "ECommerceAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ECommerceSecurityMechanism"></see>
    /// </summary>
    let ECommerceSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "ECommerceSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ECommerceMechanism"></see>
    /// </summary>
    let ECommerceMechanism =
        Namespaced_IRI.parse _namespace_name "ECommerceMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ECommerceTechnology"></see>
    /// </summary>
    let ECommerceTechnology =
        Namespaced_IRI.parse _namespace_name "ECommerceTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#EDGEAttack"></see>
    /// </summary>
    let EDGEAttack = Namespaced_IRI.parse _namespace_name "EDGEAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#EDGESecurityMechanism"></see>
    /// </summary>
    let EDGESecurityMechanism =
        Namespaced_IRI.parse _namespace_name "EDGESecurityMechanism" |> NamespacedName

    /// <summary>
    /// Enhanced Data Rates for GSM Evolution (EDGE) or 2.75G
    /// <see href="http://securitytoolbox.appspot.com/stac#EDGETechnology"></see></summary>
    let EDGETechnology =
        Namespaced_IRI.parse _namespace_name "EDGETechnology" |> NamespacedName

    /// <summary>
    /// Universal Mobile Telecommunications System (UMTS). Third Generation (3G)
    /// <see href="http://securitytoolbox.appspot.com/stac#UMTSTechnology"></see></summary>
    let UMTSTechnology =
        Namespaced_IRI.parse _namespace_name "UMTSTechnology" |> NamespacedName

    /// <summary>
    /// When a SecurityMechanism is not secured anymore, it is replaced by a more secure SecurityMechanism. This is also the case for technologies: a technology can be replaced by another one more recent. (E.G., 2G has been replaced by 3G)
    /// <see href="http://securitytoolbox.appspot.com/stac#isReplacedBy"></see></summary>
    let isReplacedBy =
        Namespaced_IRI.parse _namespace_name "isReplacedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#EthernetAttack"></see>
    /// </summary>
    let EthernetAttack =
        Namespaced_IRI.parse _namespace_name "EthernetAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#EthernetSecurityMechanism"></see>
    /// </summary>
    let EthernetSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "EthernetSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#EthernetTechnology"></see>
    /// </summary>
    let EthernetTechnology =
        Namespaced_IRI.parse _namespace_name "EthernetTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HighCostDeployment"></see>
    /// </summary>
    let HighCostDeployment =
        Namespaced_IRI.parse _namespace_name "HighCostDeployment" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ExternalAttack"></see>
    /// </summary>
    let ExternalAttack =
        Namespaced_IRI.parse _namespace_name "ExternalAttack" |> NamespacedName

    /// <summary>
    /// Features of security mechanisms. For example a sensor technology is low energy consuming, and the symmetric algorithm (a SecurityMechanism) is low energy consumming.
    /// <see href="http://securitytoolbox.appspot.com/stac#Feature"></see></summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Firewall"></see>
    /// </summary>
    let Firewall = Namespaced_IRI.parse _namespace_name "Firewall" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSSecurityMechanism"></see>
    /// </summary>
    let UMTSSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "UMTSSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ApplicationLayer"></see>
    /// </summary>
    let ApplicationLayer =
        Namespaced_IRI.parse _namespace_name "ApplicationLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#protectsInLayer"></see>
    /// </summary>
    let protectsInLayer =
        Namespaced_IRI.parse _namespace_name "protectsInLayer" |> NamespacedName

    /// <summary>
    /// Floodings attacks generally are used to drain the memry resources by sensing the control signals.
    /// <see href="http://securitytoolbox.appspot.com/stac#Flooding"></see></summary>
    let Flooding = Namespaced_IRI.parse _namespace_name "Flooding" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#TransportLayer"></see>
    /// </summary>
    let TransportLayer =
        Namespaced_IRI.parse _namespace_name "TransportLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#occursInLayer"></see>
    /// </summary>
    let occursInLayer =
        Namespaced_IRI.parse _namespace_name "occursInLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ClientPuzzle"></see>
    /// </summary>
    let ClientPuzzle =
        Namespaced_IRI.parse _namespace_name "ClientPuzzle" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SensorAttack"></see>
    /// </summary>
    let SensorAttack =
        Namespaced_IRI.parse _namespace_name "SensorAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#FrameworkAttack"></see>
    /// </summary>
    let FrameworkAttack =
        Namespaced_IRI.parse _namespace_name "FrameworkAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#FrameworkSecurityMechanism"></see>
    /// </summary>
    let FrameworkSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "FrameworkSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#FrameworkTechnology"></see>
    /// </summary>
    let FrameworkTechnology =
        Namespaced_IRI.parse _namespace_name "FrameworkTechnology" |> NamespacedName

    /// <summary>
    /// The GPRS system are a much more expesed to intruders, because of its IP based backbone.
    /// <see href="http://securitytoolbox.appspot.com/stac#GPRSArchitecture"></see></summary>
    let GPRSArchitecture =
        Namespaced_IRI.parse _namespace_name "GPRSArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GPRSArchitectureComponent"></see>
    /// </summary>
    let GPRSArchitectureComponent =
        Namespaced_IRI.parse _namespace_name "GPRSArchitectureComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GPRSAttack"></see>
    /// </summary>
    let GPRSAttack = Namespaced_IRI.parse _namespace_name "GPRSAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GPRSSecurityMechanism"></see>
    /// </summary>
    let GPRSSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "GPRSSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GPRSSecurityAlgorithm"></see>
    /// </summary>
    let GPRSSecurityAlgorithm =
        Namespaced_IRI.parse _namespace_name "GPRSSecurityAlgorithm" |> NamespacedName

    /// <summary>
    /// General Packet Radio Service (GPRS) or 2.5G
    /// <see href="http://securitytoolbox.appspot.com/stac#GPRSTechnology"></see></summary>
    let GPRSTechnology =
        Namespaced_IRI.parse _namespace_name "GPRSTechnology" |> NamespacedName

    /// <summary>
    /// A technology has a specific architecture.
    /// <see href="http://securitytoolbox.appspot.com/stac#hasArchitecture"></see></summary>
    let hasArchitecture =
        Namespaced_IRI.parse _namespace_name "hasArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMArchitecture"></see>
    /// </summary>
    let GSMArchitecture =
        Namespaced_IRI.parse _namespace_name "GSMArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMArchitectureComponent"></see>
    /// </summary>
    let GSMArchitectureComponent =
        Namespaced_IRI.parse _namespace_name "GSMArchitectureComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMAttack"></see>
    /// </summary>
    let GSMAttack = Namespaced_IRI.parse _namespace_name "GSMAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMSecurityMechanism"></see>
    /// </summary>
    let GSMSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "GSMSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMKeyManagement"></see>
    /// </summary>
    let GSMKeyManagement =
        Namespaced_IRI.parse _namespace_name "GSMKeyManagement" |> NamespacedName

    /// <summary>
    /// Key management protocols are fundamental requirements to develop a secure application. These protocols are used to set up and distribute various kinds of cryptographic keys to nodes in the network.
    /// <see href="http://securitytoolbox.appspot.com/stac#KeyManagement"></see></summary>
    let KeyManagement =
        Namespaced_IRI.parse _namespace_name "KeyManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMSecurityAlgorithm"></see>
    /// </summary>
    let GSMSecurityAlgorithm =
        Namespaced_IRI.parse _namespace_name "GSMSecurityAlgorithm" |> NamespacedName

    /// <summary>
    /// Global System for Mobile Communication (GSM) or 2G
    /// <see href="http://securitytoolbox.appspot.com/stac#GSMTechnology"></see></summary>
    let GSMTechnology =
        Namespaced_IRI.parse _namespace_name "GSMTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#GSMSecurityProtocol"></see>
    /// </summary>
    let GSMSecurityProtocol =
        Namespaced_IRI.parse _namespace_name "GSMSecurityProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Protocol"></see>
    /// </summary>
    let Protocol = Namespaced_IRI.parse _namespace_name "Protocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HSPDAAttack"></see>
    /// </summary>
    let HSPDAAttack =
        Namespaced_IRI.parse _namespace_name "HSPDAAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HSPDASecurityMechanism"></see>
    /// </summary>
    let HSPDASecurityMechanism =
        Namespaced_IRI.parse _namespace_name "HSPDASecurityMechanism" |> NamespacedName

    /// <summary>
    /// High-Speed Download Packet Access (HSPDA) or 3.5G
    /// <see href="http://securitytoolbox.appspot.com/stac#HSPDATechnology"></see></summary>
    let HSPDATechnology =
        Namespaced_IRI.parse _namespace_name "HSPDATechnology" |> NamespacedName

    /// <summary>
    /// Long Term Evolution (LTE) Technology or 4G
    /// <see href="http://securitytoolbox.appspot.com/stac#LTETechnology"></see></summary>
    let LTETechnology =
        Namespaced_IRI.parse _namespace_name "LTETechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HashFunction"></see>
    /// </summary>
    let HashFunction =
        Namespaced_IRI.parse _namespace_name "HashFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#HighSensitive"></see>
    /// </summary>
    let HighSensitive =
        Namespaced_IRI.parse _namespace_name "HighSensitive" |> NamespacedName

    /// <summary>
    /// Honeypots are hosts meant to be attacked either to distract the attackers or to research their techniques.
    /// <see href="http://securitytoolbox.appspot.com/stac#Honeypot"></see></summary>
    let Honeypot = Namespaced_IRI.parse _namespace_name "Honeypot" |> NamespacedName
    /// <summary>
    /// The purpose of this value is to enable the receiver to detect any malicious modifications of the message by an attacker.
    /// <see href="http://securitytoolbox.appspot.com/stac#ICV"></see></summary>
    let ICV = Namespaced_IRI.parse _namespace_name "ICV" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#IDS"></see>
    /// </summary>
    let IDS = Namespaced_IRI.parse _namespace_name "IDS" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#IPS"></see>
    /// </summary>
    let IPS = Namespaced_IRI.parse _namespace_name "IPS" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#InitialVector"></see>
    /// </summary>
    let InitialVector =
        Namespaced_IRI.parse _namespace_name "InitialVector" |> NamespacedName

    /// <summary>
    /// Semantic security ensures that an eavesdropper has no information about the message, even if it sees multiple encryptions of the same messages.
    /// <see href="http://securitytoolbox.appspot.com/stac#SemanticSecurityMethod"></see></summary>
    let SemanticSecurityMethod =
        Namespaced_IRI.parse _namespace_name "SemanticSecurityMethod" |> NamespacedName

    /// <summary>
    /// Internal attacks are launched from compromised nodes, are much more sophisticated than external attacks.
    /// <see href="http://securitytoolbox.appspot.com/stac#InternalAttack"></see></summary>
    let InternalAttack =
        Namespaced_IRI.parse _namespace_name "InternalAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#JavaSecurityApi"></see>
    /// </summary>
    let JavaSecurityApi =
        Namespaced_IRI.parse _namespace_name "JavaSecurityApi" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LTEArchitecture"></see>
    /// </summary>
    let LTEArchitecture =
        Namespaced_IRI.parse _namespace_name "LTEArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LTEArchitectureComponent"></see>
    /// </summary>
    let LTEArchitectureComponent =
        Namespaced_IRI.parse _namespace_name "LTEArchitectureComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LTEAttack"></see>
    /// </summary>
    let LTEAttack = Namespaced_IRI.parse _namespace_name "LTEAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LTESecurityMechanism"></see>
    /// </summary>
    let LTESecurityMechanism =
        Namespaced_IRI.parse _namespace_name "LTESecurityMechanism" |> NamespacedName

    /// <summary>
    /// The simple form of authentication is providing a user name and password which is mainly the case in internet based authentication (e.g. email, online shopping, etc)
    /// <see href="http://securitytoolbox.appspot.com/stac#LoginPassword"></see></summary>
    let LoginPassword =
        Namespaced_IRI.parse _namespace_name "LoginPassword" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LowSensitive"></see>
    /// </summary>
    let LowSensitive =
        Namespaced_IRI.parse _namespace_name "LowSensitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#M2MAttack"></see>
    /// </summary>
    let M2MAttack = Namespaced_IRI.parse _namespace_name "M2MAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#M2MTechnology"></see>
    /// </summary>
    let M2MTechnology =
        Namespaced_IRI.parse _namespace_name "M2MTechnology" |> NamespacedName

    /// <summary>
    /// MAC is a short piece of information used to authenticate a message and check the integrity.
    /// <see href="http://securitytoolbox.appspot.com/stac#MAC"></see></summary>
    let MAC = Namespaced_IRI.parse _namespace_name "MAC" |> NamespacedName

    /// <summary>
    /// Only an administrator is authorized to add a new access right to the system.
    /// <see href="http://securitytoolbox.appspot.com/stac#MandatoryAccessControl"></see></summary>
    let MandatoryAccessControl =
        Namespaced_IRI.parse _namespace_name "MandatoryAccessControl" |> NamespacedName

    /// <summary>
    /// Manet (Mobile ad hoc network) is a self-configuring network of mobile devices connected.
    /// <see href="http://securitytoolbox.appspot.com/stac#ManetAttack"></see></summary>
    let ManetAttack =
        Namespaced_IRI.parse _namespace_name "ManetAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ManetSecurityMechanism"></see>
    /// </summary>
    let ManetSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "ManetSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ManetTechnology"></see>
    /// </summary>
    let ManetTechnology =
        Namespaced_IRI.parse _namespace_name "ManetTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MediumSensitive"></see>
    /// </summary>
    let MediumSensitive =
        Namespaced_IRI.parse _namespace_name "MediumSensitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshArchitecture"></see>
    /// </summary>
    let MeshArchitecture =
        Namespaced_IRI.parse _namespace_name "MeshArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Flexible"></see>
    /// </summary>
    let Flexible = Namespaced_IRI.parse _namespace_name "Flexible" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Scalable"></see>
    /// </summary>
    let Scalable = Namespaced_IRI.parse _namespace_name "Scalable" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LowCostDeployment"></see>
    /// </summary>
    let LowCostDeployment =
        Namespaced_IRI.parse _namespace_name "LowCostDeployment" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshArchitectureComponent"></see>
    /// </summary>
    let MeshArchitectureComponent =
        Namespaced_IRI.parse _namespace_name "MeshArchitectureComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshAttack"></see>
    /// </summary>
    let MeshAttack = Namespaced_IRI.parse _namespace_name "MeshAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshSecurityMechanism"></see>
    /// </summary>
    let MeshSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "MeshSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshKeyManagement"></see>
    /// </summary>
    let MeshKeyManagement =
        Namespaced_IRI.parse _namespace_name "MeshKeyManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshTechnology"></see>
    /// </summary>
    let MeshTechnology =
        Namespaced_IRI.parse _namespace_name "MeshTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MeshSecurityProtocol"></see>
    /// </summary>
    let MeshSecurityProtocol =
        Namespaced_IRI.parse _namespace_name "MeshSecurityProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MessageEncryptionTool"></see>
    /// </summary>
    let MessageEncryptionTool =
        Namespaced_IRI.parse _namespace_name "MessageEncryptionTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SecurityTool"></see>
    /// </summary>
    let SecurityTool =
        Namespaced_IRI.parse _namespace_name "SecurityTool" |> NamespacedName

    /// <summary>
    /// A mode of operation describes the process of encrypting each of block cipher.
    /// <see href="http://securitytoolbox.appspot.com/stac#ModeOperation"></see></summary>
    let ModeOperation =
        Namespaced_IRI.parse _namespace_name "ModeOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#MutualAuthentication"></see>
    /// </summary>
    let MutualAuthentication =
        Namespaced_IRI.parse _namespace_name "MutualAuthentication" |> NamespacedName

    /// <summary>
    /// Negative Feature of security mechanisms
    /// <see href="http://securitytoolbox.appspot.com/stac#NegativeFeature"></see></summary>
    let NegativeFeature =
        Namespaced_IRI.parse _namespace_name "NegativeFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NetworkManagementAttack"></see>
    /// </summary>
    let NetworkManagementAttack =
        Namespaced_IRI.parse _namespace_name "NetworkManagementAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NetworkManagementTechnology"></see>
    /// </summary>
    let NetworkManagementTechnology =
        Namespaced_IRI.parse _namespace_name "NetworkManagementTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NetworkManagementSecurityTool"></see>
    /// </summary>
    let NetworkManagementSecurityTool =
        Namespaced_IRI.parse _namespace_name "NetworkManagementSecurityTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OSIModel"></see>
    /// </summary>
    let OSIModel = Namespaced_IRI.parse _namespace_name "OSIModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PhysicalLayer"></see>
    /// </summary>
    let PhysicalLayer =
        Namespaced_IRI.parse _namespace_name "PhysicalLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LinkLayer"></see>
    /// </summary>
    let LinkLayer = Namespaced_IRI.parse _namespace_name "LinkLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NetworkLayer"></see>
    /// </summary>
    let NetworkLayer =
        Namespaced_IRI.parse _namespace_name "NetworkLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SessionLayer"></see>
    /// </summary>
    let SessionLayer =
        Namespaced_IRI.parse _namespace_name "SessionLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PresentationLayer"></see>
    /// </summary>
    let PresentationLayer =
        Namespaced_IRI.parse _namespace_name "PresentationLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OSIModelLayer"></see>
    /// </summary>
    let OSIModelLayer =
        Namespaced_IRI.parse _namespace_name "OSIModelLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Obfuscation"></see>
    /// </summary>
    let Obfuscation =
        Namespaced_IRI.parse _namespace_name "Obfuscation" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OneWayAuthentication"></see>
    /// </summary>
    let OneWayAuthentication =
        Namespaced_IRI.parse _namespace_name "OneWayAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OperatingSystemAttack"></see>
    /// </summary>
    let OperatingSystemAttack =
        Namespaced_IRI.parse _namespace_name "OperatingSystemAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OperatingSystemSecurityMechanism"></see>
    /// </summary>
    let OperatingSystemSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "OperatingSystemSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#OperatingSystemTechnology"></see>
    /// </summary>
    let OperatingSystemTechnology =
        Namespaced_IRI.parse _namespace_name "OperatingSystemTechnology" |> NamespacedName

    /// <summary>
    /// Malicious users violate the confidentiality  of the information exchanged over the network.
    /// <see href="http://securitytoolbox.appspot.com/stac#PassiveAttack"></see></summary>
    let PassiveAttack =
        Namespaced_IRI.parse _namespace_name "PassiveAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Personal"></see>
    /// </summary>
    let Personal = Namespaced_IRI.parse _namespace_name "Personal" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PhysicalKey"></see>
    /// </summary>
    let PhysicalKey =
        Namespaced_IRI.parse _namespace_name "PhysicalKey" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PolymorphicVirus"></see>
    /// </summary>
    let PolymorphicVirus =
        Namespaced_IRI.parse _namespace_name "PolymorphicVirus" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Virus"></see>
    /// </summary>
    let Virus = Namespaced_IRI.parse _namespace_name "Virus" |> NamespacedName

    /// <summary>
    /// Positive Feature of security mechanisms
    /// <see href="http://securitytoolbox.appspot.com/stac#PositiveFeature"></see></summary>
    let PositiveFeature =
        Namespaced_IRI.parse _namespace_name "PositiveFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#PreSharedKey"></see>
    /// </summary>
    let PreSharedKey =
        Namespaced_IRI.parse _namespace_name "PreSharedKey" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageAttack"></see>
    /// </summary>
    let ProgrammingLanguageAttack =
        Namespaced_IRI.parse _namespace_name "ProgrammingLanguageAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageSecurityMechanism"></see>
    /// </summary>
    let ProgrammingLanguageSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "ProgrammingLanguageSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageTechnology"></see>
    /// </summary>
    let ProgrammingLanguageTechnology =
        Namespaced_IRI.parse _namespace_name "ProgrammingLanguageTechnology" |> NamespacedName

    /// <summary>
    /// A proxy analyzes application commands, performs authentication and keeps logs.
    /// <see href="http://securitytoolbox.appspot.com/stac#Proxy"></see></summary>
    let Proxy = Namespaced_IRI.parse _namespace_name "Proxy" |> NamespacedName
    /// <summary>
    /// Mechanism for access control that organizes users (in the system) into specific groups called Roles. E.g., Doctor and nurses are different roles in a hospital.
    /// <see href="http://securitytoolbox.appspot.com/stac#RBAC"></see></summary>
    let RBAC = Namespaced_IRI.parse _namespace_name "RBAC" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#NotFlexible"></see>
    /// </summary>
    let NotFlexible =
        Namespaced_IRI.parse _namespace_name "NotFlexible" |> NamespacedName

    /// <summary>
    /// Permissions are modeled as relations between users (subjects) and data (objects).
    /// <see href="http://securitytoolbox.appspot.com/stac#RelBAC"></see></summary>
    let RelBAC = Namespaced_IRI.parse _namespace_name "RelBAC" |> NamespacedName

    /// <summary>
    /// The application to secure has requirements (e.g., high sensitive data or specific technologies).
    /// <see href="http://securitytoolbox.appspot.com/stac#Requirement"></see></summary>
    let Requirement =
        Namespaced_IRI.parse _namespace_name "Requirement" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ReverseProxy"></see>
    /// </summary>
    let ReverseProxy =
        Namespaced_IRI.parse _namespace_name "ReverseProxy" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#RfidAttack"></see>
    /// </summary>
    let RfidAttack = Namespaced_IRI.parse _namespace_name "RfidAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#RfidSecurityMechanism"></see>
    /// </summary>
    let RfidSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "RfidSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#RfidTechnology"></see>
    /// </summary>
    let RfidTechnology =
        Namespaced_IRI.parse _namespace_name "RfidTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SecurityMagazine"></see>
    /// </summary>
    let SecurityMagazine =
        Namespaced_IRI.parse _namespace_name "SecurityMagazine" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SecurityProperty"></see>
    /// </summary>
    let SecurityProperty =
        Namespaced_IRI.parse _namespace_name "SecurityProperty" |> NamespacedName

    /// <summary>
    /// Sensor nodes have very limited computationnal power, and traditional security and encryption techniques are not-well suitd to this domain.
    /// <see href="http://securitytoolbox.appspot.com/stac#SensorSecurityMechanism"></see></summary>
    let SensorSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "SensorSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SensorKeyManagement"></see>
    /// </summary>
    let SensorKeyManagement =
        Namespaced_IRI.parse _namespace_name "SensorKeyManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SensorTechnology"></see>
    /// </summary>
    let SensorTechnology =
        Namespaced_IRI.parse _namespace_name "SensorTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SensorSecurityProtocol"></see>
    /// </summary>
    let SensorSecurityProtocol =
        Namespaced_IRI.parse _namespace_name "SensorSecurityProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ServerAttack"></see>
    /// </summary>
    let ServerAttack =
        Namespaced_IRI.parse _namespace_name "ServerAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ServerSecurityMechanism"></see>
    /// </summary>
    let ServerSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "ServerSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ServerTechnology"></see>
    /// </summary>
    let ServerTechnology =
        Namespaced_IRI.parse _namespace_name "ServerTechnology" |> NamespacedName

    /// <summary>
    /// A Sniffer tries to spy passwords for instance.
    /// <see href="http://securitytoolbox.appspot.com/stac#Sniffer"></see></summary>
    let Sniffer = Namespaced_IRI.parse _namespace_name "Sniffer" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Spam"></see>
    /// </summary>
    let Spam = Namespaced_IRI.parse _namespace_name "Spam" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#Spyware"></see>
    /// </summary>
    let Spyware = Namespaced_IRI.parse _namespace_name "Spyware" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#StreamCipher"></see>
    /// </summary>
    let StreamCipher =
        Namespaced_IRI.parse _namespace_name "StreamCipher" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LowEnergyConsuming"></see>
    /// </summary>
    let LowEnergyConsuming =
        Namespaced_IRI.parse _namespace_name "LowEnergyConsuming" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ExchangeKeyNotEasy"></see>
    /// </summary>
    let ExchangeKeyNotEasy =
        Namespaced_IRI.parse _namespace_name "ExchangeKeyNotEasy" |> NamespacedName

    /// <summary>
    /// Symmetric key: the same key is used for encryption and decryption.
    /// <see href="http://securitytoolbox.appspot.com/stac#SymmetricKey"></see></summary>
    let SymmetricKey =
        Namespaced_IRI.parse _namespace_name "SymmetricKey" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SymmetricSensorKey"></see>
    /// </summary>
    let SymmetricSensorKey =
        Namespaced_IRI.parse _namespace_name "SymmetricSensorKey" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#SystemLogs"></see>
    /// </summary>
    let SystemLogs = Namespaced_IRI.parse _namespace_name "SystemLogs" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#TemporaryIdentity"></see>
    /// </summary>
    let TemporaryIdentity =
        Namespaced_IRI.parse _namespace_name "TemporaryIdentity" |> NamespacedName

    /// <summary>
    /// In order to ensure the freshness of packet, a timestamp can be attached to the packet. A receiving node can compare the timestamp in the packet with its own time clock and determine whether the packet is valid or not.
    /// <see href="http://securitytoolbox.appspot.com/stac#Timestamp"></see></summary>
    let Timestamp = Namespaced_IRI.parse _namespace_name "Timestamp" |> NamespacedName
    /// <summary>
    /// A Trojan horse is a malicious piece of software hidden in a program that performs normal tasks. Program that does something malicious (such as capturing passwords) when run by an unsuspecting user.
    /// <see href="http://securitytoolbox.appspot.com/stac#Troyan"></see></summary>
    let Troyan = Namespaced_IRI.parse _namespace_name "Troyan" |> NamespacedName

    /// <summary>
    /// Some attacks cannot be thwart in technologies. For example, the Denial of Service is difficult to thwart in different technologies.
    /// <see href="http://securitytoolbox.appspot.com/stac#isVulnerabilityOf"></see></summary>
    let isVulnerabilityOf =
        Namespaced_IRI.parse _namespace_name "isVulnerabilityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSArchitecture"></see>
    /// </summary>
    let UMTSArchitecture =
        Namespaced_IRI.parse _namespace_name "UMTSArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSArchitectureComponent"></see>
    /// </summary>
    let UMTSArchitectureComponent =
        Namespaced_IRI.parse _namespace_name "UMTSArchitectureComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSAttack"></see>
    /// </summary>
    let UMTSAttack = Namespaced_IRI.parse _namespace_name "UMTSAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSKeyManagement"></see>
    /// </summary>
    let UMTSKeyManagement =
        Namespaced_IRI.parse _namespace_name "UMTSKeyManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSSecurityAlgorithm"></see>
    /// </summary>
    let UMTSSecurityAlgorithm =
        Namespaced_IRI.parse _namespace_name "UMTSSecurityAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UMTSSecurityProtocol"></see>
    /// </summary>
    let UMTSSecurityProtocol =
        Namespaced_IRI.parse _namespace_name "UMTSSecurityProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UwbAttack"></see>
    /// </summary>
    let UwbAttack = Namespaced_IRI.parse _namespace_name "UwbAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UwbSecurityMechanism"></see>
    /// </summary>
    let UwbSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "UwbSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#UwbTechnology"></see>
    /// </summary>
    let UwbTechnology =
        Namespaced_IRI.parse _namespace_name "UwbTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebSecurityProtocol"></see>
    /// </summary>
    let WebSecurityProtocol =
        Namespaced_IRI.parse _namespace_name "WebSecurityProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebService"></see>
    /// </summary>
    let WebService = Namespaced_IRI.parse _namespace_name "WebService" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebServiceAttack"></see>
    /// </summary>
    let WebServiceAttack =
        Namespaced_IRI.parse _namespace_name "WebServiceAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebServiceSecurityMechanism"></see>
    /// </summary>
    let WebServiceSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "WebServiceSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebServiceMechanism"></see>
    /// </summary>
    let WebServiceMechanism =
        Namespaced_IRI.parse _namespace_name "WebServiceMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WebServiceTechnology"></see>
    /// </summary>
    let WebServiceTechnology =
        Namespaced_IRI.parse _namespace_name "WebServiceTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiArchitecture"></see>
    /// </summary>
    let WifiArchitecture =
        Namespaced_IRI.parse _namespace_name "WifiArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiArchitectureComponent"></see>
    /// </summary>
    let WifiArchitectureComponent =
        Namespaced_IRI.parse _namespace_name "WifiArchitectureComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiAttack"></see>
    /// </summary>
    let WifiAttack = Namespaced_IRI.parse _namespace_name "WifiAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiSecurityMechanism"></see>
    /// </summary>
    let WifiSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "WifiSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiAttackTool"></see>
    /// </summary>
    let WifiAttackTool =
        Namespaced_IRI.parse _namespace_name "WifiAttackTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiKeyManagement"></see>
    /// </summary>
    let WifiKeyManagement =
        Namespaced_IRI.parse _namespace_name "WifiKeyManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiTechnology"></see>
    /// </summary>
    let WifiTechnology =
        Namespaced_IRI.parse _namespace_name "WifiTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WifiSecurityProtocol"></see>
    /// </summary>
    let WifiSecurityProtocol =
        Namespaced_IRI.parse _namespace_name "WifiSecurityProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxArchitecture"></see>
    /// </summary>
    let WimaxArchitecture =
        Namespaced_IRI.parse _namespace_name "WimaxArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxArchitectureComponent"></see>
    /// </summary>
    let WimaxArchitectureComponent =
        Namespaced_IRI.parse _namespace_name "WimaxArchitectureComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxAttack"></see>
    /// </summary>
    let WimaxAttack =
        Namespaced_IRI.parse _namespace_name "WimaxAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxSecurityMechanism"></see>
    /// </summary>
    let WimaxSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "WimaxSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxKeyManagement"></see>
    /// </summary>
    let WimaxKeyManagement =
        Namespaced_IRI.parse _namespace_name "WimaxKeyManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxTechnology"></see>
    /// </summary>
    let WimaxTechnology =
        Namespaced_IRI.parse _namespace_name "WimaxTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#WimaxSecurityProtocol"></see>
    /// </summary>
    let WimaxSecurityProtocol =
        Namespaced_IRI.parse _namespace_name "WimaxSecurityProtocol" |> NamespacedName

    /// <summary>
    /// Worms are self-propagating pieces of malicious software. They propagate from one computer/device to another via a network link.
    /// <see href="http://securitytoolbox.appspot.com/stac#Worm"></see></summary>
    let Worm = Namespaced_IRI.parse _namespace_name "Worm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ZigbeeAttack"></see>
    /// </summary>
    let ZigbeeAttack =
        Namespaced_IRI.parse _namespace_name "ZigbeeAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ZigbeeSecurityMechanism"></see>
    /// </summary>
    let ZigbeeSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "ZigbeeSecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#ZigbeeTechnology"></see>
    /// </summary>
    let ZigbeeTechnology =
        Namespaced_IRI.parse _namespace_name "ZigbeeTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#LowCost"></see>
    /// </summary>
    let LowCost = Namespaced_IRI.parse _namespace_name "LowCost" |> NamespacedName

    /// <summary>
    /// Features are related to security mechanisms. For example, an asymmetric algorithm is high energy consuming.
    /// <see href="http://securitytoolbox.appspot.com/stac#isFeatureOf"></see></summary>
    let isFeatureOf =
        Namespaced_IRI.parse _namespace_name "isFeatureOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#hasModeOperation"></see>
    /// </summary>
    let hasModeOperation =
        Namespaced_IRI.parse _namespace_name "hasModeOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#isSecurityMechanismOf"></see>
    /// </summary>
    let isSecurityMechanismOf =
        Namespaced_IRI.parse _namespace_name "isSecurityMechanismOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/stac#isProtectedBy"></see>
    /// </summary>
    let isProtectedBy =
        Namespaced_IRI.parse _namespace_name "isProtectedBy" |> NamespacedName

    /// <summary>
    /// A security mechanism (e.g., VPN) satisfies some security properties (e.g., authentication)
    /// <see href="http://securitytoolbox.appspot.com/stac#satisfies"></see></summary>
    let satisfies = Namespaced_IRI.parse _namespace_name "satisfies" |> NamespacedName
    /// <summary>
    /// An attack (e.g., eavesdropping) threatens some security properties (e.g., confidentiality)
    /// <see href="http://securitytoolbox.appspot.com/stac#threatens"></see></summary>
    let threatens = Namespaced_IRI.parse _namespace_name "threatens" |> NamespacedName
