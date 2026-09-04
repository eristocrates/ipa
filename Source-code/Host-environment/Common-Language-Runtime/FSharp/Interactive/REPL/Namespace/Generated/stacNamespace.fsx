#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module stac =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://securitytoolbox.appspot.com/stac#" "stac"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Permissions are associated with a set of rules expressed on measurable parameters and are granted to users who can prove compliance with these rules.</para>
    ///   <para>rdfs:label : Attribute Based Access control (ABAC)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ABAC">stac:ABAC</a>
    /// </summary>
    let ABAC = _prefixId.prefix "ABAC"
    /// <summary>
    ///   <para>rdfs:comment : Access Control is the mechanism that allows owners of resources to define, manage and enforce access conditions applicable to each resource.</para>
    ///   <para>rdfs:label : Access Control Method</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#AccessControlMethod">stac:AccessControlMethod</a>
    /// </summary>
    let AccessControlMethod = _prefixId.prefix "AccessControlMethod"
    /// <summary>
    ///   <para>dce:description : See Paper: Malicious actions against the GPRS technology [Xenakis 2006]</para>
    ///   <para>rdfs:comment : Active attacks involve actions performed by adversaries to gain the control of the network.</para>
    ///   <para>rdfs:label : Active Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ActiveAttack">stac:ActiveAttack</a>
    /// </summary>
    let ActiveAttack = _prefixId.prefix "ActiveAttack"
    /// <summary>
    ///   <para>rdfs:comment : Anonymity protects user identity, making it hard to track the whereabouts of a certain user.</para>
    ///   <para>rdfs:label : Anonymity Method</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#AnonymityMethod">stac:AnonymityMethod</a>
    /// </summary>
    let AnonymityMethod = _prefixId.prefix "AnonymityMethod"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Anti Spam</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#AntiSpam">stac:AntiSpam</a>
    /// </summary>
    let AntiSpam = _prefixId.prefix "AntiSpam"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Anti Spyware</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#AntiSpyware">stac:AntiSpyware</a>
    /// </summary>
    let AntiSpyware = _prefixId.prefix "AntiSpyware"
    /// <summary>
    ///   <para>dce:description : See Paper: A study of information security for M2M and IoT [Jiang et al. 2010]</para>
    ///   <para>rdfs:comment : Anti-viruses softwares applications will reduce viruses and malware on M2M equipment.</para>
    ///   <para>rdfs:label : Antivirus</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Antivirus">stac:Antivirus</a>
    /// </summary>
    let Antivirus = _prefixId.prefix "Antivirus"
    let ApplicationLayer = _prefixId.prefix "ApplicationLayer"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Architecture</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Architecture">stac:Architecture</a>
    /// </summary>
    let Architecture = _prefixId.prefix "Architecture"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Architecture component</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ArchitectureComponent">stac:ArchitectureComponent</a>
    /// </summary>
    let ArchitectureComponent = _prefixId.prefix "ArchitectureComponent"
    /// <summary>
    ///   <para>rdfs:comment : The keys used for encryption and decryption are different, allowing for easier key distribution.</para>
    ///   <para>rdfs:label : Asymmetric algorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#AsymmetricAlgorithm">stac:AsymmetricAlgorithm</a>
    /// </summary>
    let AsymmetricAlgorithm = _prefixId.prefix "AsymmetricAlgorithm"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Asymmetric Key</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#AsymmetricKey">stac:AsymmetricKey</a>
    /// </summary>
    let AsymmetricKey = _prefixId.prefix "AsymmetricKey"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Attack">stac:Attack</a>
    /// </summary>
    let Attack = _prefixId.prefix "Attack"
    /// <summary>
    ///   <para>rdfs:comment : Authentication prevents unauthorized access to the network.</para>
    ///   <para>rdfs:label : Authentication Method</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#AuthenticationMethod">stac:AuthenticationMethod</a>
    /// </summary>
    let AuthenticationMethod = _prefixId.prefix "AuthenticationMethod"
    /// <summary>
    ///   <para>rdfs:comment : It identifies the supplicant, checks its credentials, and define privileges and restrictions, and allows or denies it access to the network and services.</para>
    ///   <para>rdfs:label : Authentication Server (AS)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#AuthenticationServer">stac:AuthenticationServer</a>
    /// </summary>
    let AuthenticationServer = _prefixId.prefix "AuthenticationServer"
    /// <summary>
    ///   <para>rdfs:comment : Data availability ensures that the network is alive and that data are accessible.</para>
    ///   <para>rdfs:label : Availability Method</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#AvailabilityMethod">stac:AvailabilityMethod</a>
    /// </summary>
    let AvailabilityMethod = _prefixId.prefix "AvailabilityMethod"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Badge</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Badge">stac:Badge</a>
    /// </summary>
    let Badge = _prefixId.prefix "Badge"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Bank</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Bank">stac:Bank</a>
    /// </summary>
    let Bank = _prefixId.prefix "Bank"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : BlockCipher</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#BlockCipher">stac:BlockCipher</a>
    /// </summary>
    let BlockCipher = _prefixId.prefix "BlockCipher"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Bluetooth Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#BluetoothAttack">stac:BluetoothAttack</a>
    /// </summary>
    let BluetoothAttack = _prefixId.prefix "BluetoothAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Bluetooth Security Algorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#BluetoothSecurityAlgorithm">stac:BluetoothSecurityAlgorithm</a>
    /// </summary>
    let BluetoothSecurityAlgorithm = _prefixId.prefix "BluetoothSecurityAlgorithm"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Bluetooth SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#BluetoothSecurityMechanism">stac:BluetoothSecurityMechanism</a>
    /// </summary>
    let BluetoothSecurityMechanism = _prefixId.prefix "BluetoothSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : A protocol for short-range (up to 100 meters) wireless networks.</para>
    ///   <para>rdfs:label : Bluetooth Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#BluetoothTechnology">stac:BluetoothTechnology</a>
    /// </summary>
    let BluetoothTechnology = _prefixId.prefix "BluetoothTechnology"
    /// <summary>
    ///   <para>rdfs:comment : E.g. herat attack is a critical event. Criticaly is a context aware permission.</para>
    ///   <para>rdfs:label : Context Aware Role Based Access Control (CA-RBAC)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#CA-RBAC">stac:CA-RBAC</a>
    /// </summary>
    let CA_RBAC = _prefixId.prefix "CA-RBAC"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Captcha</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Captcha">stac:Captcha</a>
    /// </summary>
    let Captcha = _prefixId.prefix "Captcha"
    /// <summary>
    ///   <para>rdfs:comment : Challenge/Response is a mechanism where on entity in the network proves to another entity that it knows the password without revealing it.</para>
    ///   <para>rdfs:label : Challenge Response</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ChallengeResponse">stac:ChallengeResponse</a>
    /// </summary>
    let ChallengeResponse = _prefixId.prefix "ChallengeResponse"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Checksum Algorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ChecksumAlgorithm">stac:ChecksumAlgorithm</a>
    /// </summary>
    let ChecksumAlgorithm = _prefixId.prefix "ChecksumAlgorithm"
    let ClientPuzzle = _prefixId.prefix "ClientPuzzle"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Cloud Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#CloudAttack">stac:CloudAttack</a>
    /// </summary>
    let CloudAttack = _prefixId.prefix "CloudAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Cloud Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#CloudSecurityMechanism">stac:CloudSecurityMechanism</a>
    /// </summary>
    let CloudSecurityMechanism = _prefixId.prefix "CloudSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Cloud Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#CloudTechnology">stac:CloudTechnology</a>
    /// </summary>
    let CloudTechnology = _prefixId.prefix "CloudTechnology"
    /// <summary>
    ///   <para>rdfs:comment : Confidentiality means that only destined user must be able to read data.</para>
    ///   <para>rdfs:label : Confidentiality Method</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ConfidentialityMethod">stac:ConfidentialityMethod</a>
    /// </summary>
    let ConfidentialityMethod = _prefixId.prefix "ConfidentialityMethod"
    /// <summary>
    ///   <para>rdfs:comment : Since the counter value is incremented after each message, the same message is encrypted differently each time.</para>
    ///   <para>rdfs:label : Counter Value</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#CounterValue">stac:CounterValue</a>
    /// </summary>
    let CounterValue = _prefixId.prefix "CounterValue"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : CryptographicConcept</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#CryptographicConcept">stac:CryptographicConcept</a>
    /// </summary>
    let CryptographicConcept = _prefixId.prefix "CryptographicConcept"
    /// <summary>
    ///   <para>rdfs:comment : Object owners can add access rights.</para>
    ///   <para>rdfs:label : Discretionary Access Control (DAC)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#DAC">stac:DAC</a>
    /// </summary>
    let DAC = _prefixId.prefix "DAC"
    /// <summary>
    ///   <para>rdfs:comment : Data freshness suggests that the data is recent, and it ensures that no old messages have been replayed.</para>
    ///   <para>rdfs:label : Data Freshness Method</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#DataFreshnessMethod">stac:DataFreshnessMethod</a>
    /// </summary>
    let DataFreshnessMethod = _prefixId.prefix "DataFreshnessMethod"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : DataProvenanceType</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#DataProvenanceType">stac:DataProvenanceType</a>
    /// </summary>
    let DataProvenanceType = _prefixId.prefix "DataProvenanceType"
    /// <summary>
    ///   <para>rdfs:comment : DataTypeSensitive (low, medium or high sensitive). The data to secure.</para>
    ///   <para>rdfs:label : DataTypeSensitive</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#DataTypeSensitive">stac:DataTypeSensitive</a>
    /// </summary>
    let DataTypeSensitive = _prefixId.prefix "DataTypeSensitive"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Database Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#DatabaseAttack">stac:DatabaseAttack</a>
    /// </summary>
    let DatabaseAttack = _prefixId.prefix "DatabaseAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Database Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#DatabaseSecurityMechanism">stac:DatabaseSecurityMechanism</a>
    /// </summary>
    let DatabaseSecurityMechanism = _prefixId.prefix "DatabaseSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Database Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#DatabaseTechnology">stac:DatabaseTechnology</a>
    /// </summary>
    let DatabaseTechnology = _prefixId.prefix "DatabaseTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Digital Certificate</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#DigitalCertificate">stac:DigitalCertificate</a>
    /// </summary>
    let DigitalCertificate = _prefixId.prefix "DigitalCertificate"
    /// <summary>
    ///   <para>rdfs:comment : The digital signature verifies that the contents of the electronic message have not been altered.</para>
    ///   <para>rdfs:label : Digital Signature</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#DigitalSignature">stac:DigitalSignature</a>
    /// </summary>
    let DigitalSignature = _prefixId.prefix "DigitalSignature"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : ECommerce Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ECommerceAttack">stac:ECommerceAttack</a>
    /// </summary>
    let ECommerceAttack = _prefixId.prefix "ECommerceAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : ECommerce Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ECommerceMechanism">stac:ECommerceMechanism</a>
    /// </summary>
    let ECommerceMechanism = _prefixId.prefix "ECommerceMechanism"
    let ECommerceSecurityMechanism = _prefixId.prefix "ECommerceSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : ECommerce Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ECommerceTechnology">stac:ECommerceTechnology</a>
    /// </summary>
    let ECommerceTechnology = _prefixId.prefix "ECommerceTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : EDGE Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#EDGEAttack">stac:EDGEAttack</a>
    /// </summary>
    let EDGEAttack = _prefixId.prefix "EDGEAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : EDGE SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#EDGESecurityMechanism">stac:EDGESecurityMechanism</a>
    /// </summary>
    let EDGESecurityMechanism = _prefixId.prefix "EDGESecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : Enhanced Data Rates for GSM Evolution (EDGE) or 2.75G</para>
    ///   <para>rdfs:label : Enhanced Data Rates for GSM Evolution (EDGE) or 2.75G</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#EDGETechnology">stac:EDGETechnology</a>
    /// </summary>
    let EDGETechnology = _prefixId.prefix "EDGETechnology"
    /// <summary>
    ///   <para>rdfs:comment : Encryption algorithm ensures the confidentiality property.</para>
    ///   <para>rdfs:label : Encryption Algorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#EncryptionAlgorithm">stac:EncryptionAlgorithm</a>
    /// </summary>
    let EncryptionAlgorithm = _prefixId.prefix "EncryptionAlgorithm"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Ethernet Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#EthernetAttack">stac:EthernetAttack</a>
    /// </summary>
    let EthernetAttack = _prefixId.prefix "EthernetAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Ethernet SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#EthernetSecurityMechanism">stac:EthernetSecurityMechanism</a>
    /// </summary>
    let EthernetSecurityMechanism = _prefixId.prefix "EthernetSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Ethernet</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#EthernetTechnology">stac:EthernetTechnology</a>
    /// </summary>
    let EthernetTechnology = _prefixId.prefix "EthernetTechnology"
    let ExchangeKeyEasy = _prefixId.prefix "ExchangeKeyEasy"
    let ExchangeKeyNotEasy = _prefixId.prefix "ExchangeKeyNotEasy"
    /// <summary>
    ///   <para>dce:description : See Paper: Malicious actions against the GPRS technology [Xenakis 2006]</para>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : External Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ExternalAttack">stac:ExternalAttack</a>
    /// </summary>
    let ExternalAttack = _prefixId.prefix "ExternalAttack"
    /// <summary>
    ///   <para>rdfs:comment : Features of security mechanisms. For example a sensor technology is low energy consuming, and the symmetric algorithm (a SecurityMechanism) is low energy consumming.</para>
    ///   <para>rdfs:label : Feature</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Feature">stac:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>dce:description : See Paper: Malicious actions against the GPRS technology [Xenakis 2006]</para>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Firewall</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Firewall">stac:Firewall</a>
    /// </summary>
    let Firewall = _prefixId.prefix "Firewall"
    let Flexible = _prefixId.prefix "Flexible"
    /// <summary>
    ///   <para>dce:description : See Paper: Survey of Security and Privacy Issues of Internet of Things [Borgohain et al. 2015]</para>
    ///   <para>rdfs:comment : Floodings attacks generally are used to drain the memry resources by sensing the control signals.</para>
    ///   <para>rdfs:label : Flooding</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Flooding">stac:Flooding</a>
    /// </summary>
    let Flooding = _prefixId.prefix "Flooding"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Framework Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#FrameworkAttack">stac:FrameworkAttack</a>
    /// </summary>
    let FrameworkAttack = _prefixId.prefix "FrameworkAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Framework Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#FrameworkSecurityMechanism">stac:FrameworkSecurityMechanism</a>
    /// </summary>
    let FrameworkSecurityMechanism = _prefixId.prefix "FrameworkSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Framework Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#FrameworkTechnology">stac:FrameworkTechnology</a>
    /// </summary>
    let FrameworkTechnology = _prefixId.prefix "FrameworkTechnology"
    /// <summary>
    ///   <para>rdfs:comment : The GPRS system are a much more expesed to intruders, because of its IP based backbone.</para>
    ///   <para>rdfs:label : GPRS Architecture</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GPRSArchitecture">stac:GPRSArchitecture</a>
    /// </summary>
    let GPRSArchitecture = _prefixId.prefix "GPRSArchitecture"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GPRS Architecture component</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GPRSArchitectureComponent">stac:GPRSArchitectureComponent</a>
    /// </summary>
    let GPRSArchitectureComponent = _prefixId.prefix "GPRSArchitectureComponent"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GPRS Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GPRSAttack">stac:GPRSAttack</a>
    /// </summary>
    let GPRSAttack = _prefixId.prefix "GPRSAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GPRS Security Algorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GPRSSecurityAlgorithm">stac:GPRSSecurityAlgorithm</a>
    /// </summary>
    let GPRSSecurityAlgorithm = _prefixId.prefix "GPRSSecurityAlgorithm"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GPRS SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GPRSSecurityMechanism">stac:GPRSSecurityMechanism</a>
    /// </summary>
    let GPRSSecurityMechanism = _prefixId.prefix "GPRSSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : General Packet Radio Service (GPRS) or 2.5G</para>
    ///   <para>rdfs:label : General Packet Radio Service (GPRS) or 2.5G</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GPRSTechnology">stac:GPRSTechnology</a>
    /// </summary>
    let GPRSTechnology = _prefixId.prefix "GPRSTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GSM Architecture</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GSMArchitecture">stac:GSMArchitecture</a>
    /// </summary>
    let GSMArchitecture = _prefixId.prefix "GSMArchitecture"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GSM Architecture component</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GSMArchitectureComponent">stac:GSMArchitectureComponent</a>
    /// </summary>
    let GSMArchitectureComponent = _prefixId.prefix "GSMArchitectureComponent"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GSM Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GSMAttack">stac:GSMAttack</a>
    /// </summary>
    let GSMAttack = _prefixId.prefix "GSMAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GSM Key Management</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GSMKeyManagement">stac:GSMKeyManagement</a>
    /// </summary>
    let GSMKeyManagement = _prefixId.prefix "GSMKeyManagement"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GSM Security Algorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GSMSecurityAlgorithm">stac:GSMSecurityAlgorithm</a>
    /// </summary>
    let GSMSecurityAlgorithm = _prefixId.prefix "GSMSecurityAlgorithm"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GSM SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GSMSecurityMechanism">stac:GSMSecurityMechanism</a>
    /// </summary>
    let GSMSecurityMechanism = _prefixId.prefix "GSMSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : GSM Security Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GSMSecurityProtocol">stac:GSMSecurityProtocol</a>
    /// </summary>
    let GSMSecurityProtocol = _prefixId.prefix "GSMSecurityProtocol"
    /// <summary>
    ///   <para>rdfs:comment : Global System for Mobile Communication (GSM) or 2G</para>
    ///   <para>rdfs:label : Global System for Mobile Communication (GSM) or 2G</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#GSMTechnology">stac:GSMTechnology</a>
    /// </summary>
    let GSMTechnology = _prefixId.prefix "GSMTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : HSPDA Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#HSPDAAttack">stac:HSPDAAttack</a>
    /// </summary>
    let HSPDAAttack = _prefixId.prefix "HSPDAAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : HSPDA SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#HSPDASecurityMechanism">stac:HSPDASecurityMechanism</a>
    /// </summary>
    let HSPDASecurityMechanism = _prefixId.prefix "HSPDASecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : High-Speed Download Packet Access (HSPDA) or 3.5G</para>
    ///   <para>rdfs:label : High-Speed Download Packet Access (HSPDA) or 3.5G</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#HSPDATechnology">stac:HSPDATechnology</a>
    /// </summary>
    let HSPDATechnology = _prefixId.prefix "HSPDATechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Hash Function</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#HashFunction">stac:HashFunction</a>
    /// </summary>
    let HashFunction = _prefixId.prefix "HashFunction"
    let HighCostDeployment = _prefixId.prefix "HighCostDeployment"
    let HighEnergyConsuming = _prefixId.prefix "HighEnergyConsuming"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : HighSensitive</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#HighSensitive">stac:HighSensitive</a>
    /// </summary>
    let HighSensitive = _prefixId.prefix "HighSensitive"
    /// <summary>
    ///   <para>rdfs:comment : Honeypots are hosts meant to be attacked either to distract the attackers or to research their techniques.</para>
    ///   <para>rdfs:label : Honeypot</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Honeypot">stac:Honeypot</a>
    /// </summary>
    let Honeypot = _prefixId.prefix "Honeypot"
    /// <summary>
    ///   <para>rdfs:comment : The purpose of this value is to enable the receiver to detect any malicious modifications of the message by an attacker.</para>
    ///   <para>rdfs:label : Integrity Check Value (ICV)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ICV">stac:ICV</a>
    /// </summary>
    let ICV = _prefixId.prefix "ICV"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Intrusion Detection System (IDS)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#IDS">stac:IDS</a>
    /// </summary>
    let IDS = _prefixId.prefix "IDS"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Intrusion Prevention System (IPS)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#IPS">stac:IPS</a>
    /// </summary>
    let IPS = _prefixId.prefix "IPS"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Initial Vector</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#InitialVector">stac:InitialVector</a>
    /// </summary>
    let InitialVector = _prefixId.prefix "InitialVector"
    /// <summary>
    ///   <para>rdfs:comment : Data integrity guarantees that the transmitted messages are not modified by attackers, either due to malicious intent or by accident.</para>
    ///   <para>rdfs:label : Integrity Method</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#IntegrityMethod">stac:IntegrityMethod</a>
    /// </summary>
    let IntegrityMethod = _prefixId.prefix "IntegrityMethod"
    /// <summary>
    ///   <para>dce:description : See Paper: Malicious actions against the GPRS technology [Xenakis 2006]</para>
    ///   <para>rdfs:comment : Internal attacks are launched from compromised nodes, are much more sophisticated than external attacks.</para>
    ///   <para>rdfs:label : Internal Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#InternalAttack">stac:InternalAttack</a>
    /// </summary>
    let InternalAttack = _prefixId.prefix "InternalAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Java Api</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#JavaSecurityApi">stac:JavaSecurityApi</a>
    /// </summary>
    let JavaSecurityApi = _prefixId.prefix "JavaSecurityApi"
    /// <summary>
    ///   <para>dce:description : Key management protocols are fundamental requirements to develop a secure application. These protocols are used to set up and distribute various kinds of cryptographic keys to nodes in the network.</para>
    ///   <para>rdfs:comment : Key management protocols are fundamental requirements to develop a secure application. These protocols are used to set up and distribute various kinds of cryptographic keys to nodes in the network.</para>
    ///   <para>rdfs:label : Key Management</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#KeyManagement">stac:KeyManagement</a>
    /// </summary>
    let KeyManagement = _prefixId.prefix "KeyManagement"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : LTE Architecture</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#LTEArchitecture">stac:LTEArchitecture</a>
    /// </summary>
    let LTEArchitecture = _prefixId.prefix "LTEArchitecture"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : LTE Architecture component</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#LTEArchitectureComponent">stac:LTEArchitectureComponent</a>
    /// </summary>
    let LTEArchitectureComponent = _prefixId.prefix "LTEArchitectureComponent"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : LTE Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#LTEAttack">stac:LTEAttack</a>
    /// </summary>
    let LTEAttack = _prefixId.prefix "LTEAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : LTE Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#LTESecurityMechanism">stac:LTESecurityMechanism</a>
    /// </summary>
    let LTESecurityMechanism = _prefixId.prefix "LTESecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : Long Term Evolution (LTE) Technology or 4G</para>
    ///   <para>rdfs:label : Long Term Evolution (LTE) Technology or 4G</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#LTETechnology">stac:LTETechnology</a>
    /// </summary>
    let LTETechnology = _prefixId.prefix "LTETechnology"
    let LinkLayer = _prefixId.prefix "LinkLayer"
    /// <summary>
    ///   <para>rdfs:comment : The simple form of authentication is providing a user name and password which is mainly the case in internet based authentication (e.g. email, online shopping, etc)</para>
    ///   <para>rdfs:label : Login/Password</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#LoginPassword">stac:LoginPassword</a>
    /// </summary>
    let LoginPassword = _prefixId.prefix "LoginPassword"
    let LowCost = _prefixId.prefix "LowCost"
    let LowCostDeployment = _prefixId.prefix "LowCostDeployment"
    let LowEnergyConsuming = _prefixId.prefix "LowEnergyConsuming"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : LowSensitive</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#LowSensitive">stac:LowSensitive</a>
    /// </summary>
    let LowSensitive = _prefixId.prefix "LowSensitive"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : M2M Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#M2MAttack">stac:M2MAttack</a>
    /// </summary>
    let M2MAttack = _prefixId.prefix "M2MAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : M2M SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#M2MSecurityMechanism">stac:M2MSecurityMechanism</a>
    /// </summary>
    let M2MSecurityMechanism = _prefixId.prefix "M2MSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Machine-to-Machine(M2M)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#M2MTechnology">stac:M2MTechnology</a>
    /// </summary>
    let M2MTechnology = _prefixId.prefix "M2MTechnology"
    /// <summary>
    ///   <para>rdfs:comment : MAC is a short piece of information used to authenticate a message and check the integrity.</para>
    ///   <para>rdfs:label : Message Authentication Code (MAC)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MAC">stac:MAC</a>
    /// </summary>
    let MAC = _prefixId.prefix "MAC"
    /// <summary>
    ///   <para>rdfs:comment : Only an administrator is authorized to add a new access right to the system.</para>
    ///   <para>rdfs:label : Mandatory Access Control (MAC)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MandatoryAccessControl">stac:MandatoryAccessControl</a>
    /// </summary>
    let MandatoryAccessControl = _prefixId.prefix "MandatoryAccessControl"
    /// <summary>
    ///   <para>rdfs:comment : Manet (Mobile ad hoc network) is a self-configuring network of mobile devices connected.</para>
    ///   <para>rdfs:label : Manet Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ManetAttack">stac:ManetAttack</a>
    /// </summary>
    let ManetAttack = _prefixId.prefix "ManetAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Manet SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ManetSecurityMechanism">stac:ManetSecurityMechanism</a>
    /// </summary>
    let ManetSecurityMechanism = _prefixId.prefix "ManetSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Manet Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ManetTechnology">stac:ManetTechnology</a>
    /// </summary>
    let ManetTechnology = _prefixId.prefix "ManetTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : MediumSensitive</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MediumSensitive">stac:MediumSensitive</a>
    /// </summary>
    let MediumSensitive = _prefixId.prefix "MediumSensitive"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Mesh Architecture</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MeshArchitecture">stac:MeshArchitecture</a>
    /// </summary>
    let MeshArchitecture = _prefixId.prefix "MeshArchitecture"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Mesh Architecture component</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MeshArchitectureComponent">stac:MeshArchitectureComponent</a>
    /// </summary>
    let MeshArchitectureComponent = _prefixId.prefix "MeshArchitectureComponent"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Mesh Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MeshAttack">stac:MeshAttack</a>
    /// </summary>
    let MeshAttack = _prefixId.prefix "MeshAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Mesh Key Management</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MeshKeyManagement">stac:MeshKeyManagement</a>
    /// </summary>
    let MeshKeyManagement = _prefixId.prefix "MeshKeyManagement"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Mesh Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MeshSecurityMechanism">stac:MeshSecurityMechanism</a>
    /// </summary>
    let MeshSecurityMechanism = _prefixId.prefix "MeshSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Mesh Security Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MeshSecurityProtocol">stac:MeshSecurityProtocol</a>
    /// </summary>
    let MeshSecurityProtocol = _prefixId.prefix "MeshSecurityProtocol"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Mesh Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MeshTechnology">stac:MeshTechnology</a>
    /// </summary>
    let MeshTechnology = _prefixId.prefix "MeshTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Message Encryption Tool</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MessageEncryptionTool">stac:MessageEncryptionTool</a>
    /// </summary>
    let MessageEncryptionTool = _prefixId.prefix "MessageEncryptionTool"
    /// <summary>
    ///   <para>rdfs:comment : A mode of operation describes the process of encrypting each of block cipher.</para>
    ///   <para>rdfs:label : Mode of operation</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ModeOperation">stac:ModeOperation</a>
    /// </summary>
    let ModeOperation = _prefixId.prefix "ModeOperation"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Mutual Authentication ot two-way authentication</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#MutualAuthentication">stac:MutualAuthentication</a>
    /// </summary>
    let MutualAuthentication = _prefixId.prefix "MutualAuthentication"
    /// <summary>
    ///   <para>rdfs:comment : Negative Feature of security mechanisms</para>
    ///   <para>rdfs:label : Negative Feature</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#NegativeFeature">stac:NegativeFeature</a>
    /// </summary>
    let NegativeFeature = _prefixId.prefix "NegativeFeature"
    let NetworkLayer = _prefixId.prefix "NetworkLayer"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Network Management Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#NetworkManagementAttack">stac:NetworkManagementAttack</a>
    /// </summary>
    let NetworkManagementAttack = _prefixId.prefix "NetworkManagementAttack"

    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Network Management Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#NetworkManagementSecurityMechanism">stac:NetworkManagementSecurityMechanism</a>
    /// </summary>
    let NetworkManagementSecurityMechanism =
        _prefixId.prefix "NetworkManagementSecurityMechanism"

    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Network Management Security Tool</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#NetworkManagementSecurityTool">stac:NetworkManagementSecurityTool</a>
    /// </summary>
    let NetworkManagementSecurityTool = _prefixId.prefix "NetworkManagementSecurityTool"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Network Management Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#NetworkManagementTechnology">stac:NetworkManagementTechnology</a>
    /// </summary>
    let NetworkManagementTechnology = _prefixId.prefix "NetworkManagementTechnology"
    /// <summary>
    ///   <para>rdfs:comment : Non repudiation means that a sender is unable to deny having sent a message or infoomation.</para>
    ///   <para>rdfs:label : Non Repudiation Method</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#NonRepudiationMethod">stac:NonRepudiationMethod</a>
    /// </summary>
    let NonRepudiationMethod = _prefixId.prefix "NonRepudiationMethod"
    let NotFlexible = _prefixId.prefix "NotFlexible"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : </para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#OSIModel">stac:OSIModel</a>
    /// </summary>
    let OSIModel = _prefixId.prefix "OSIModel"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : OSI Model Layer</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#OSIModelLayer">stac:OSIModelLayer</a>
    /// </summary>
    let OSIModelLayer = _prefixId.prefix "OSIModelLayer"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Obfuscation</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Obfuscation">stac:Obfuscation</a>
    /// </summary>
    let Obfuscation = _prefixId.prefix "Obfuscation"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : One Way Authentication</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#OneWayAuthentication">stac:OneWayAuthentication</a>
    /// </summary>
    let OneWayAuthentication = _prefixId.prefix "OneWayAuthentication"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Operating System Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#OperatingSystemAttack">stac:OperatingSystemAttack</a>
    /// </summary>
    let OperatingSystemAttack = _prefixId.prefix "OperatingSystemAttack"

    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Operating System Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#OperatingSystemSecurityMechanism">stac:OperatingSystemSecurityMechanism</a>
    /// </summary>
    let OperatingSystemSecurityMechanism =
        _prefixId.prefix "OperatingSystemSecurityMechanism"

    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Operating system Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#OperatingSystemTechnology">stac:OperatingSystemTechnology</a>
    /// </summary>
    let OperatingSystemTechnology = _prefixId.prefix "OperatingSystemTechnology"
    /// <summary>
    ///   <para>dce:description : See Paper: Malicious actions against the GPRS technology [Xenakis 2006]</para>
    ///   <para>rdfs:comment : Malicious users violate the confidentiality  of the information exchanged over the network.</para>
    ///   <para>rdfs:label : Passive Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#PassiveAttack">stac:PassiveAttack</a>
    /// </summary>
    let PassiveAttack = _prefixId.prefix "PassiveAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Personal</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Personal">stac:Personal</a>
    /// </summary>
    let Personal = _prefixId.prefix "Personal"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Physical Authentication</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#PhysicalAuthentication">stac:PhysicalAuthentication</a>
    /// </summary>
    let PhysicalAuthentication = _prefixId.prefix "PhysicalAuthentication"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Physical Key</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#PhysicalKey">stac:PhysicalKey</a>
    /// </summary>
    let PhysicalKey = _prefixId.prefix "PhysicalKey"
    let PhysicalLayer = _prefixId.prefix "PhysicalLayer"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Polymorphic Virus</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#PolymorphicVirus">stac:PolymorphicVirus</a>
    /// </summary>
    let PolymorphicVirus = _prefixId.prefix "PolymorphicVirus"
    /// <summary>
    ///   <para>rdfs:comment : Positive Feature of security mechanisms</para>
    ///   <para>rdfs:label : Positive Feature</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#PositiveFeature">stac:PositiveFeature</a>
    /// </summary>
    let PositiveFeature = _prefixId.prefix "PositiveFeature"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Pre Shared Key</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#PreSharedKey">stac:PreSharedKey</a>
    /// </summary>
    let PreSharedKey = _prefixId.prefix "PreSharedKey"
    let PresentationLayer = _prefixId.prefix "PresentationLayer"
    /// <summary>
    ///   <para>rdfs:comment : The private key is used for computing signatures and decryption.</para>
    ///   <para>rdfs:label : Private Key </para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#PrivateKey">stac:PrivateKey</a>
    /// </summary>
    let PrivateKey = _prefixId.prefix "PrivateKey"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Programming Language Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageAttack">stac:ProgrammingLanguageAttack</a>
    /// </summary>
    let ProgrammingLanguageAttack = _prefixId.prefix "ProgrammingLanguageAttack"

    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Programming Language Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageSecurityMechanism">stac:ProgrammingLanguageSecurityMechanism</a>
    /// </summary>
    let ProgrammingLanguageSecurityMechanism =
        _prefixId.prefix "ProgrammingLanguageSecurityMechanism"

    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Programming Language</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageTechnology">stac:ProgrammingLanguageTechnology</a>
    /// </summary>
    let ProgrammingLanguageTechnology = _prefixId.prefix "ProgrammingLanguageTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Protocol">stac:Protocol</a>
    /// </summary>
    let Protocol = _prefixId.prefix "Protocol"
    /// <summary>
    ///   <para>rdfs:comment : A proxy analyzes application commands, performs authentication and keeps logs.</para>
    ///   <para>rdfs:label : Proxy</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Proxy">stac:Proxy</a>
    /// </summary>
    let Proxy = _prefixId.prefix "Proxy"
    /// <summary>
    ///   <para>rdfs:comment : The public key is used for verifying a digital signature and is used for encryption.</para>
    ///   <para>rdfs:label : Public Key </para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#PublicKey">stac:PublicKey</a>
    /// </summary>
    let PublicKey = _prefixId.prefix "PublicKey"
    /// <summary>
    ///   <para>rdfs:comment : Mechanism for access control that organizes users (in the system) into specific groups called Roles. E.g., Doctor and nurses are different roles in a hospital.</para>
    ///   <para>rdfs:label : Role Based Access Control (RBAC)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#RBAC">stac:RBAC</a>
    /// </summary>
    let RBAC = _prefixId.prefix "RBAC"
    /// <summary>
    ///   <para>rdfs:comment : Permissions are modeled as relations between users (subjects) and data (objects).</para>
    ///   <para>rdfs:label : Relation Based Access Control (RelBAC)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#RelBAC">stac:RelBAC</a>
    /// </summary>
    let RelBAC = _prefixId.prefix "RelBAC"
    /// <summary>
    ///   <para>rdfs:comment : The application to secure has requirements (e.g., high sensitive data or specific technologies).</para>
    ///   <para>rdfs:label : Requirement</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Requirement">stac:Requirement</a>
    /// </summary>
    let Requirement = _prefixId.prefix "Requirement"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Reverse Proxy</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ReverseProxy">stac:ReverseProxy</a>
    /// </summary>
    let ReverseProxy = _prefixId.prefix "ReverseProxy"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : RFID Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#RfidAttack">stac:RfidAttack</a>
    /// </summary>
    let RfidAttack = _prefixId.prefix "RfidAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Rfid SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#RfidSecurityMechanism">stac:RfidSecurityMechanism</a>
    /// </summary>
    let RfidSecurityMechanism = _prefixId.prefix "RfidSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Rfid Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#RfidTechnology">stac:RfidTechnology</a>
    /// </summary>
    let RfidTechnology = _prefixId.prefix "RfidTechnology"
    let Scalable = _prefixId.prefix "Scalable"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Security Algorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SecurityAlgorithm">stac:SecurityAlgorithm</a>
    /// </summary>
    let SecurityAlgorithm = _prefixId.prefix "SecurityAlgorithm"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Security Magazine</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SecurityMagazine">stac:SecurityMagazine</a>
    /// </summary>
    let SecurityMagazine = _prefixId.prefix "SecurityMagazine"
    /// <summary>
    ///   <para>dce:description : Security Mechanisms are processes that are used to detect, prevent and recover from security attacks.</para>
    ///   <para>rdfs:comment : Security Mechanisms are processes that are used to detect, prevent and recover from security attacks.</para>
    ///   <para>rdfs:label : SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SecurityMechanism">stac:SecurityMechanism</a>
    /// </summary>
    let SecurityMechanism = _prefixId.prefix "SecurityMechanism"
    /// <summary>
    ///   <para>rdfs:label : SecurityProperty</para>
    ///   <para>rdfs:comment : </para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SecurityProperty">stac:SecurityProperty</a>
    /// </summary>
    let SecurityProperty = _prefixId.prefix "SecurityProperty"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Security Property Method</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SecurityPropertyMethod">stac:SecurityPropertyMethod</a>
    /// </summary>
    let SecurityPropertyMethod = _prefixId.prefix "SecurityPropertyMethod"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Security Tool</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SecurityTool">stac:SecurityTool</a>
    /// </summary>
    let SecurityTool = _prefixId.prefix "SecurityTool"
    /// <summary>
    ///   <para>rdfs:comment : Semantic security ensures that an eavesdropper has no information about the message, even if it sees multiple encryptions of the same messages.</para>
    ///   <para>rdfs:label : Semantic Security Method</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SemanticSecurityMethod">stac:SemanticSecurityMethod</a>
    /// </summary>
    let SemanticSecurityMethod = _prefixId.prefix "SemanticSecurityMethod"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Sensor Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SensorAttack">stac:SensorAttack</a>
    /// </summary>
    let SensorAttack = _prefixId.prefix "SensorAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Sensor Key Management</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SensorKeyManagement">stac:SensorKeyManagement</a>
    /// </summary>
    let SensorKeyManagement = _prefixId.prefix "SensorKeyManagement"
    /// <summary>
    ///   <para>dce:description : Sensor nodes have very limited computationnal power, and traditional security and encryption techniques are not-well suitd to this domain.</para>
    ///   <para>rdfs:comment : Sensor nodes have very limited computationnal power, and traditional security and encryption techniques are not-well suitd to this domain.</para>
    ///   <para>rdfs:label : Sensor Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SensorSecurityMechanism">stac:SensorSecurityMechanism</a>
    /// </summary>
    let SensorSecurityMechanism = _prefixId.prefix "SensorSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Sensor Security Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SensorSecurityProtocol">stac:SensorSecurityProtocol</a>
    /// </summary>
    let SensorSecurityProtocol = _prefixId.prefix "SensorSecurityProtocol"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Sensor Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SensorTechnology">stac:SensorTechnology</a>
    /// </summary>
    let SensorTechnology = _prefixId.prefix "SensorTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Server Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ServerAttack">stac:ServerAttack</a>
    /// </summary>
    let ServerAttack = _prefixId.prefix "ServerAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Server Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ServerSecurityMechanism">stac:ServerSecurityMechanism</a>
    /// </summary>
    let ServerSecurityMechanism = _prefixId.prefix "ServerSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Server Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ServerTechnology">stac:ServerTechnology</a>
    /// </summary>
    let ServerTechnology = _prefixId.prefix "ServerTechnology"
    let SessionLayer = _prefixId.prefix "SessionLayer"
    /// <summary>
    ///   <para>rdfs:comment : A Sniffer tries to spy passwords for instance.</para>
    ///   <para>rdfs:label : Sniffer</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Sniffer">stac:Sniffer</a>
    /// </summary>
    let Sniffer = _prefixId.prefix "Sniffer"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Spam</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Spam">stac:Spam</a>
    /// </summary>
    let Spam = _prefixId.prefix "Spam"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Spyware</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Spyware">stac:Spyware</a>
    /// </summary>
    let Spyware = _prefixId.prefix "Spyware"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : StreamCipher</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#StreamCipher">stac:StreamCipher</a>
    /// </summary>
    let StreamCipher = _prefixId.prefix "StreamCipher"
    /// <summary>
    ///   <para>rdfs:comment : The same secret key is used for encryption and decryption.</para>
    ///   <para>rdfs:label : Symmetric algorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SymmetricAlgorithm">stac:SymmetricAlgorithm</a>
    /// </summary>
    let SymmetricAlgorithm = _prefixId.prefix "SymmetricAlgorithm"
    /// <summary>
    ///   <para>rdfs:comment : Symmetric key: the same key is used for encryption and decryption.</para>
    ///   <para>rdfs:label : Symmetric Key</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SymmetricKey">stac:SymmetricKey</a>
    /// </summary>
    let SymmetricKey = _prefixId.prefix "SymmetricKey"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : SymmetricSensorKey</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SymmetricSensorKey">stac:SymmetricSensorKey</a>
    /// </summary>
    let SymmetricSensorKey = _prefixId.prefix "SymmetricSensorKey"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : System Logs</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#SystemLogs">stac:SystemLogs</a>
    /// </summary>
    let SystemLogs = _prefixId.prefix "SystemLogs"
    /// <summary>
    ///   <para>rdfs:comment : Technologies can be wireless (Wi-Fi, Wimax), cellular (2G, 3G, 4G), sensor  networks, web application, etc.</para>
    ///   <para>rdfs:label : Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Technology">stac:Technology</a>
    /// </summary>
    let Technology = _prefixId.prefix "Technology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Temporary Identity</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#TemporaryIdentity">stac:TemporaryIdentity</a>
    /// </summary>
    let TemporaryIdentity = _prefixId.prefix "TemporaryIdentity"
    /// <summary>
    ///   <para>rdfs:comment : In order to ensure the freshness of packet, a timestamp can be attached to the packet. A receiving node can compare the timestamp in the packet with its own time clock and determine whether the packet is valid or not.</para>
    ///   <para>rdfs:label : Timestamp</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Timestamp">stac:Timestamp</a>
    /// </summary>
    let Timestamp = _prefixId.prefix "Timestamp"
    let TransportLayer = _prefixId.prefix "TransportLayer"
    /// <summary>
    ///   <para>dce:description : See Paper: Malicious actions against the GPRS technology [Xenakis 2006]</para>
    ///   <para>rdfs:comment : A Trojan horse is a malicious piece of software hidden in a program that performs normal tasks. Program that does something malicious (such as capturing passwords) when run by an unsuspecting user.</para>
    ///   <para>rdfs:label : Troyan</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Troyan">stac:Troyan</a>
    /// </summary>
    let Troyan = _prefixId.prefix "Troyan"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : UMTS Architecture</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UMTSArchitecture">stac:UMTSArchitecture</a>
    /// </summary>
    let UMTSArchitecture = _prefixId.prefix "UMTSArchitecture"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : UMTS Architecture component</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UMTSArchitectureComponent">stac:UMTSArchitectureComponent</a>
    /// </summary>
    let UMTSArchitectureComponent = _prefixId.prefix "UMTSArchitectureComponent"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : UMTS Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UMTSAttack">stac:UMTSAttack</a>
    /// </summary>
    let UMTSAttack = _prefixId.prefix "UMTSAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : UMTS Key Management</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UMTSKeyManagement">stac:UMTSKeyManagement</a>
    /// </summary>
    let UMTSKeyManagement = _prefixId.prefix "UMTSKeyManagement"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : UMTS Security Algorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UMTSSecurityAlgorithm">stac:UMTSSecurityAlgorithm</a>
    /// </summary>
    let UMTSSecurityAlgorithm = _prefixId.prefix "UMTSSecurityAlgorithm"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : UMTS SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UMTSSecurityMechanism">stac:UMTSSecurityMechanism</a>
    /// </summary>
    let UMTSSecurityMechanism = _prefixId.prefix "UMTSSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : UMTS Security Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UMTSSecurityProtocol">stac:UMTSSecurityProtocol</a>
    /// </summary>
    let UMTSSecurityProtocol = _prefixId.prefix "UMTSSecurityProtocol"
    /// <summary>
    ///   <para>rdfs:comment : Universal Mobile Telecommunications System (UMTS). Third Generation (3G)</para>
    ///   <para>rdfs:label : 3G technology (UMTS:Universal Mobile Telecommunications System)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UMTSTechnology">stac:UMTSTechnology</a>
    /// </summary>
    let UMTSTechnology = _prefixId.prefix "UMTSTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Uwb Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UwbAttack">stac:UwbAttack</a>
    /// </summary>
    let UwbAttack = _prefixId.prefix "UwbAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Uwb SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UwbSecurityMechanism">stac:UwbSecurityMechanism</a>
    /// </summary>
    let UwbSecurityMechanism = _prefixId.prefix "UwbSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Ultra Wideband (UWB) Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#UwbTechnology">stac:UwbTechnology</a>
    /// </summary>
    let UwbTechnology = _prefixId.prefix "UwbTechnology"
    /// <summary>
    ///   <para>dce:description : See Paper: Malicious actions against the GPRS technology [Xenakis 2006], Paper: Survey of Security and Privacy Issues of Internet of Things [Borgohain et al. 2015]</para>
    ///   <para>rdfs:label : Virus</para>
    ///   <para>rdfs:comment : </para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Virus">stac:Virus</a>
    /// </summary>
    let Virus = _prefixId.prefix "Virus"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Web Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WebAttack">stac:WebAttack</a>
    /// </summary>
    let WebAttack = _prefixId.prefix "WebAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Web Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WebSecurityMechanism">stac:WebSecurityMechanism</a>
    /// </summary>
    let WebSecurityMechanism = _prefixId.prefix "WebSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Web Security Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WebSecurityProtocol">stac:WebSecurityProtocol</a>
    /// </summary>
    let WebSecurityProtocol = _prefixId.prefix "WebSecurityProtocol"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Web Service</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WebService">stac:WebService</a>
    /// </summary>
    let WebService = _prefixId.prefix "WebService"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Web Service Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WebServiceAttack">stac:WebServiceAttack</a>
    /// </summary>
    let WebServiceAttack = _prefixId.prefix "WebServiceAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Web Service Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WebServiceMechanism">stac:WebServiceMechanism</a>
    /// </summary>
    let WebServiceMechanism = _prefixId.prefix "WebServiceMechanism"
    let WebServiceSecurityMechanism = _prefixId.prefix "WebServiceSecurityMechanism"
    let WebServiceTechnology = _prefixId.prefix "WebServiceTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Web Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WebTechnology">stac:WebTechnology</a>
    /// </summary>
    let WebTechnology = _prefixId.prefix "WebTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wifi Architecture</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WifiArchitecture">stac:WifiArchitecture</a>
    /// </summary>
    let WifiArchitecture = _prefixId.prefix "WifiArchitecture"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wifi Architecture component</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WifiArchitectureComponent">stac:WifiArchitectureComponent</a>
    /// </summary>
    let WifiArchitectureComponent = _prefixId.prefix "WifiArchitectureComponent"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wifi Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WifiAttack">stac:WifiAttack</a>
    /// </summary>
    let WifiAttack = _prefixId.prefix "WifiAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wifi Attack Tool</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WifiAttackTool">stac:WifiAttackTool</a>
    /// </summary>
    let WifiAttackTool = _prefixId.prefix "WifiAttackTool"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wifi Key Management</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WifiKeyManagement">stac:WifiKeyManagement</a>
    /// </summary>
    let WifiKeyManagement = _prefixId.prefix "WifiKeyManagement"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wifi SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WifiSecurityMechanism">stac:WifiSecurityMechanism</a>
    /// </summary>
    let WifiSecurityMechanism = _prefixId.prefix "WifiSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wifi Security Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WifiSecurityProtocol">stac:WifiSecurityProtocol</a>
    /// </summary>
    let WifiSecurityProtocol = _prefixId.prefix "WifiSecurityProtocol"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label :  Wi-Fi technology (Wireless-Fidelity)</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WifiTechnology">stac:WifiTechnology</a>
    /// </summary>
    let WifiTechnology = _prefixId.prefix "WifiTechnology"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : WiMAX Architecture</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WimaxArchitecture">stac:WimaxArchitecture</a>
    /// </summary>
    let WimaxArchitecture = _prefixId.prefix "WimaxArchitecture"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wimax Architecture component</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WimaxArchitectureComponent">stac:WimaxArchitectureComponent</a>
    /// </summary>
    let WimaxArchitectureComponent = _prefixId.prefix "WimaxArchitectureComponent"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wimax Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WimaxAttack">stac:WimaxAttack</a>
    /// </summary>
    let WimaxAttack = _prefixId.prefix "WimaxAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wimax Key Management</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WimaxKeyManagement">stac:WimaxKeyManagement</a>
    /// </summary>
    let WimaxKeyManagement = _prefixId.prefix "WimaxKeyManagement"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wimax SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WimaxSecurityMechanism">stac:WimaxSecurityMechanism</a>
    /// </summary>
    let WimaxSecurityMechanism = _prefixId.prefix "WimaxSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wimax Security Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WimaxSecurityProtocol">stac:WimaxSecurityProtocol</a>
    /// </summary>
    let WimaxSecurityProtocol = _prefixId.prefix "WimaxSecurityProtocol"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Wimax Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#WimaxTechnology">stac:WimaxTechnology</a>
    /// </summary>
    let WimaxTechnology = _prefixId.prefix "WimaxTechnology"
    /// <summary>
    ///   <para>dce:description : See Paper: Malicious actions against the GPRS technology [Xenakis 2006]</para>
    ///   <para>rdfs:comment : Worms are self-propagating pieces of malicious software. They propagate from one computer/device to another via a network link.</para>
    ///   <para>rdfs:label : Worm</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#Worm">stac:Worm</a>
    /// </summary>
    let Worm = _prefixId.prefix "Worm"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Zigbee Attack</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ZigbeeAttack">stac:ZigbeeAttack</a>
    /// </summary>
    let ZigbeeAttack = _prefixId.prefix "ZigbeeAttack"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Zigbee SecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ZigbeeSecurityMechanism">stac:ZigbeeSecurityMechanism</a>
    /// </summary>
    let ZigbeeSecurityMechanism = _prefixId.prefix "ZigbeeSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : Zigbee Technology</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#ZigbeeTechnology">stac:ZigbeeTechnology</a>
    /// </summary>
    let ZigbeeTechnology = _prefixId.prefix "ZigbeeTechnology"
    /// <summary>
    ///   <para>rdfs:comment : A technology has a specific architecture.</para>
    ///   <para>rdfs:label : hasArchitecture</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#hasArchitecture">stac:hasArchitecture</a>
    /// </summary>
    let hasArchitecture = _prefixId.prefix "hasArchitecture"
    /// <summary>
    ///   <para>rdfs:comment : A SecurityMechanism has specific features (secured, depreceted, low energy consuming). For example, an asymmetric algorithm is high energy consuming.</para>
    ///   <para>rdfs:label : hasFeature</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#hasFeature">stac:hasFeature</a>
    /// </summary>
    let hasFeature = _prefixId.prefix "hasFeature"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : hasModeOperation</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#hasModeOperation">stac:hasModeOperation</a>
    /// </summary>
    let hasModeOperation = _prefixId.prefix "hasModeOperation"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : hasSecurityMechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#hasSecurityMechanism">stac:hasSecurityMechanism</a>
    /// </summary>
    let hasSecurityMechanism = _prefixId.prefix "hasSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:comment : A technology can be vulnerable to some attacks.</para>
    ///   <para>rdfs:label : has vulnerability</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#hasVulnerability">stac:hasVulnerability</a>
    /// </summary>
    let hasVulnerability = _prefixId.prefix "hasVulnerability"
    /// <summary>
    ///   <para>rdfs:comment : Features are related to security mechanisms. For example, an asymmetric algorithm is high energy consuming.</para>
    ///   <para>rdfs:label : isFeatureOf</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#isFeatureOf">stac:isFeatureOf</a>
    /// </summary>
    let isFeatureOf = _prefixId.prefix "isFeatureOf"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : isProtectedBy</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#isProtectedBy">stac:isProtectedBy</a>
    /// </summary>
    let isProtectedBy = _prefixId.prefix "isProtectedBy"
    /// <summary>
    ///   <para>rdfs:comment : When a SecurityMechanism is not secured anymore, it is replaced by a more secure SecurityMechanism. This is also the case for technologies: a technology can be replaced by another one more recent. (E.G., 2G has been replaced by 3G)</para>
    ///   <para>rdfs:label : isReplacedBy</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#isReplacedBy">stac:isReplacedBy</a>
    /// </summary>
    let isReplacedBy = _prefixId.prefix "isReplacedBy"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : isSecurityMechanismOf</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#isSecurityMechanismOf">stac:isSecurityMechanismOf</a>
    /// </summary>
    let isSecurityMechanismOf = _prefixId.prefix "isSecurityMechanismOf"
    /// <summary>
    ///   <para>rdfs:comment : Some attacks cannot be thwart in technologies. For example, the Denial of Service is difficult to thwart in different technologies.</para>
    ///   <para>rdfs:label : is Vulnerability Of</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#isVulnerabilityOf">stac:isVulnerabilityOf</a>
    /// </summary>
    let isVulnerabilityOf = _prefixId.prefix "isVulnerabilityOf"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : occursInLayer</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#occursInLayer">stac:occursInLayer</a>
    /// </summary>
    let occursInLayer = _prefixId.prefix "occursInLayer"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : protects</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#protects">stac:protects</a>
    /// </summary>
    let protects = _prefixId.prefix "protects"
    /// <summary>
    ///   <para>rdfs:comment : </para>
    ///   <para>rdfs:label : protectsInLayer</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#protectsInLayer">stac:protectsInLayer</a>
    /// </summary>
    let protectsInLayer = _prefixId.prefix "protectsInLayer"
    /// <summary>
    ///   <para>rdfs:comment : A security mechanism (e.g., VPN) satisfies some security properties (e.g., authentication)</para>
    ///   <para>rdfs:label : satisfies</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#satisfies">stac:satisfies</a>
    /// </summary>
    let satisfies = _prefixId.prefix "satisfies"
    /// <summary>
    ///   <para>rdfs:comment : An attack (e.g., eavesdropping) threatens some security properties (e.g., confidentiality)</para>
    ///   <para>rdfs:label : threatens</para>
    ///   <a href="http://securitytoolbox.appspot.com/stac#threatens">stac:threatens</a>
    /// </summary>
    let threatens = _prefixId.prefix "threatens"
