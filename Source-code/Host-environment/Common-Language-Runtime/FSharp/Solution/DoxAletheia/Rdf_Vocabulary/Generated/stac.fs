namespace http.securitytoolbox.appspot.com.stac.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module stac =
    let _namespace_iri = Namespace_Iri stac |> NamespaceIRI
    /// <summary>
    ///   <para>stac:DataProvenanceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>DataProvenanceType</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#DataProvenanceType">http://securitytoolbox.appspot.com/stac#DataProvenanceType</seealso>
    let DataProvenanceType = Prefixed_Name(stac, "DataProvenanceType") |> PrefixedName
    /// <summary>
    ///   <para>stac:BluetoothAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Bluetooth Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#BluetoothAttack">http://securitytoolbox.appspot.com/stac#BluetoothAttack</seealso>
    let BluetoothAttack = Prefixed_Name(stac, "BluetoothAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:BluetoothSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Bluetooth SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#BluetoothSecurityMechanism">http://securitytoolbox.appspot.com/stac#BluetoothSecurityMechanism</seealso>
    let BluetoothSecurityMechanism =
        Prefixed_Name(stac, "BluetoothSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:hasSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>hasSecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#hasSecurityMechanism">http://securitytoolbox.appspot.com/stac#hasSecurityMechanism</seealso>
    let hasSecurityMechanism =
        Prefixed_Name(stac, "hasSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:BluetoothTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A protocol for short-range (up to 100 meters) wireless networks.</para>
    /// labels<para>Bluetooth Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#BluetoothTechnology">http://securitytoolbox.appspot.com/stac#BluetoothTechnology</seealso>
    let BluetoothTechnology = Prefixed_Name(stac, "BluetoothTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:protects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>protects</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#protects">http://securitytoolbox.appspot.com/stac#protects</seealso>
    let protects = Prefixed_Name(stac, "protects") |> PrefixedName
    /// <summary>
    ///   <para>stac:Technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Technologies can be wireless (Wi-Fi, Wimax), cellular (2G, 3G, 4G), sensor  networks, web application, etc.</para>
    /// labels<para>Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Technology">http://securitytoolbox.appspot.com/stac#Technology</seealso>
    let Technology = Prefixed_Name(stac, "Technology") |> PrefixedName
    /// <summary>
    ///   <para>stac:CA-RBAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>E.g. herat attack is a critical event. Criticaly is a context aware permission.</para>
    /// labels<para>Context Aware Role Based Access Control (CA-RBAC)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#CA-RBAC">http://securitytoolbox.appspot.com/stac#CA-RBAC</seealso>
    let CA_RBAC = Prefixed_Name(stac, "CA-RBAC") |> PrefixedName
    /// <summary>
    ///   <para>stac:ChecksumAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Checksum Algorithm</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ChecksumAlgorithm">http://securitytoolbox.appspot.com/stac#ChecksumAlgorithm</seealso>
    let ChecksumAlgorithm = Prefixed_Name(stac, "ChecksumAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>stac:CloudAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Cloud Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#CloudAttack">http://securitytoolbox.appspot.com/stac#CloudAttack</seealso>
    let CloudAttack = Prefixed_Name(stac, "CloudAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:SensorSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor nodes have very limited computationnal power, and traditional security and encryption techniques are not-well suitd to this domain.</para>
    /// labels<para>Sensor Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SensorSecurityMechanism">http://securitytoolbox.appspot.com/stac#SensorSecurityMechanism</seealso>
    let SensorSecurityMechanism =
        Prefixed_Name(stac, "SensorSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:SensorKeyManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sensor Key Management</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SensorKeyManagement">http://securitytoolbox.appspot.com/stac#SensorKeyManagement</seealso>
    let SensorKeyManagement = Prefixed_Name(stac, "SensorKeyManagement") |> PrefixedName

    /// <summary>
    ///   <para>stac:ServerSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Server Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ServerSecurityMechanism">http://securitytoolbox.appspot.com/stac#ServerSecurityMechanism</seealso>
    let ServerSecurityMechanism =
        Prefixed_Name(stac, "ServerSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:Attack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Attack">http://securitytoolbox.appspot.com/stac#Attack</seealso>
    let Attack = Prefixed_Name(stac, "Attack") |> PrefixedName
    /// <summary>
    ///   <para>stac:ExternalAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>External Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ExternalAttack">http://securitytoolbox.appspot.com/stac#ExternalAttack</seealso>
    let ExternalAttack = Prefixed_Name(stac, "ExternalAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:Firewall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>stac:UMTSSecurityMechanism</para>
    ///   <para>stac:NetworkManagementSecurityMechanism</para>
    ///   <para></para>
    /// labels<para>Firewall</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Firewall">http://securitytoolbox.appspot.com/stac#Firewall</seealso>
    let Firewall = Prefixed_Name(stac, "Firewall") |> PrefixedName

    /// <summary>
    ///   <para>stac:UMTSSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>UMTS SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UMTSSecurityMechanism">http://securitytoolbox.appspot.com/stac#UMTSSecurityMechanism</seealso>
    let UMTSSecurityMechanism =
        Prefixed_Name(stac, "UMTSSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:ClientPuzzle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ClientPuzzle">http://securitytoolbox.appspot.com/stac#ClientPuzzle</seealso>
    let ClientPuzzle = Prefixed_Name(stac, "ClientPuzzle") |> PrefixedName
    /// <summary>
    ///   <para>stac:FrameworkTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Framework Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#FrameworkTechnology">http://securitytoolbox.appspot.com/stac#FrameworkTechnology</seealso>
    let FrameworkTechnology = Prefixed_Name(stac, "FrameworkTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:GPRSArchitectureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GPRS Architecture component</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GPRSArchitectureComponent">http://securitytoolbox.appspot.com/stac#GPRSArchitectureComponent</seealso>
    let GPRSArchitectureComponent =
        Prefixed_Name(stac, "GPRSArchitectureComponent") |> PrefixedName

    /// <summary>
    ///   <para>stac:GPRSAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GPRS Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GPRSAttack">http://securitytoolbox.appspot.com/stac#GPRSAttack</seealso>
    let GPRSAttack = Prefixed_Name(stac, "GPRSAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:GPRSSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GPRS SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GPRSSecurityMechanism">http://securitytoolbox.appspot.com/stac#GPRSSecurityMechanism</seealso>
    let GPRSSecurityMechanism =
        Prefixed_Name(stac, "GPRSSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:GPRSSecurityAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GPRS Security Algorithm</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GPRSSecurityAlgorithm">http://securitytoolbox.appspot.com/stac#GPRSSecurityAlgorithm</seealso>
    let GPRSSecurityAlgorithm =
        Prefixed_Name(stac, "GPRSSecurityAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>stac:hasArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A technology has a specific architecture.</para>
    /// labels<para>hasArchitecture</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#hasArchitecture">http://securitytoolbox.appspot.com/stac#hasArchitecture</seealso>
    let hasArchitecture = Prefixed_Name(stac, "hasArchitecture") |> PrefixedName

    /// <summary>
    ///   <para>stac:GSMArchitectureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GSM Architecture component</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GSMArchitectureComponent">http://securitytoolbox.appspot.com/stac#GSMArchitectureComponent</seealso>
    let GSMArchitectureComponent =
        Prefixed_Name(stac, "GSMArchitectureComponent") |> PrefixedName

    /// <summary>
    ///   <para>stac:GSMAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GSM Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GSMAttack">http://securitytoolbox.appspot.com/stac#GSMAttack</seealso>
    let GSMAttack = Prefixed_Name(stac, "GSMAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:KeyManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Key management protocols are fundamental requirements to develop a secure application. These protocols are used to set up and distribute various kinds of cryptographic keys to nodes in the network.</para>
    /// labels<para>Key Management</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#KeyManagement">http://securitytoolbox.appspot.com/stac#KeyManagement</seealso>
    let KeyManagement = Prefixed_Name(stac, "KeyManagement") |> PrefixedName

    /// <summary>
    ///   <para>stac:GSMSecurityAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GSM Security Algorithm</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GSMSecurityAlgorithm">http://securitytoolbox.appspot.com/stac#GSMSecurityAlgorithm</seealso>
    let GSMSecurityAlgorithm =
        Prefixed_Name(stac, "GSMSecurityAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>stac:HSPDASecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>HSPDA SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#HSPDASecurityMechanism">http://securitytoolbox.appspot.com/stac#HSPDASecurityMechanism</seealso>
    let HSPDASecurityMechanism =
        Prefixed_Name(stac, "HSPDASecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:LTETechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Long Term Evolution (LTE) Technology or 4G</para>
    /// labels<para>Long Term Evolution (LTE) Technology or 4G</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LTETechnology">http://securitytoolbox.appspot.com/stac#LTETechnology</seealso>
    let LTETechnology = Prefixed_Name(stac, "LTETechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:HashFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Hash Function</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#HashFunction">http://securitytoolbox.appspot.com/stac#HashFunction</seealso>
    let HashFunction = Prefixed_Name(stac, "HashFunction") |> PrefixedName
    /// <summary>
    ///   <para>stac:Honeypot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Honeypots are hosts meant to be attacked either to distract the attackers or to research their techniques.</para>
    /// labels<para>Honeypot</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Honeypot">http://securitytoolbox.appspot.com/stac#Honeypot</seealso>
    let Honeypot = Prefixed_Name(stac, "Honeypot") |> PrefixedName
    /// <summary>
    ///   <para>stac:ICV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The purpose of this value is to enable the receiver to detect any malicious modifications of the message by an attacker.</para>
    /// labels<para>Integrity Check Value (ICV)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ICV">http://securitytoolbox.appspot.com/stac#ICV</seealso>
    let ICV = Prefixed_Name(stac, "ICV") |> PrefixedName
    /// <summary>
    ///   <para>stac:IDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Intrusion Detection System (IDS)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#IDS">http://securitytoolbox.appspot.com/stac#IDS</seealso>
    let IDS = Prefixed_Name(stac, "IDS") |> PrefixedName
    /// <summary>
    ///   <para>stac:InitialVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Initial Vector</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#InitialVector">http://securitytoolbox.appspot.com/stac#InitialVector</seealso>
    let InitialVector = Prefixed_Name(stac, "InitialVector") |> PrefixedName

    /// <summary>
    ///   <para>stac:SemanticSecurityMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Semantic security ensures that an eavesdropper has no information about the message, even if it sees multiple encryptions of the same messages.</para>
    /// labels<para>Semantic Security Method</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SemanticSecurityMethod">http://securitytoolbox.appspot.com/stac#SemanticSecurityMethod</seealso>
    let SemanticSecurityMethod =
        Prefixed_Name(stac, "SemanticSecurityMethod") |> PrefixedName

    /// <summary>
    ///   <para>stac:InternalAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Internal attacks are launched from compromised nodes, are much more sophisticated than external attacks.</para>
    /// labels<para>Internal Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#InternalAttack">http://securitytoolbox.appspot.com/stac#InternalAttack</seealso>
    let InternalAttack = Prefixed_Name(stac, "InternalAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:LTEArchitectureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>LTE Architecture component</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LTEArchitectureComponent">http://securitytoolbox.appspot.com/stac#LTEArchitectureComponent</seealso>
    let LTEArchitectureComponent =
        Prefixed_Name(stac, "LTEArchitectureComponent") |> PrefixedName

    /// <summary>
    ///   <para>stac:LTEAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>LTE Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LTEAttack">http://securitytoolbox.appspot.com/stac#LTEAttack</seealso>
    let LTEAttack = Prefixed_Name(stac, "LTEAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:LTESecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>LTE Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LTESecurityMechanism">http://securitytoolbox.appspot.com/stac#LTESecurityMechanism</seealso>
    let LTESecurityMechanism =
        Prefixed_Name(stac, "LTESecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:LoginPassword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The simple form of authentication is providing a user name and password which is mainly the case in internet based authentication (e.g. email, online shopping, etc)</para>
    /// labels<para>Login/Password</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LoginPassword">http://securitytoolbox.appspot.com/stac#LoginPassword</seealso>
    let LoginPassword = Prefixed_Name(stac, "LoginPassword") |> PrefixedName
    /// <summary>
    ///   <para>stac:LowSensitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>LowSensitive</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LowSensitive">http://securitytoolbox.appspot.com/stac#LowSensitive</seealso>
    let LowSensitive = Prefixed_Name(stac, "LowSensitive") |> PrefixedName
    /// <summary>
    ///   <para>stac:M2MAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>M2M Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#M2MAttack">http://securitytoolbox.appspot.com/stac#M2MAttack</seealso>
    let M2MAttack = Prefixed_Name(stac, "M2MAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:MAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>MAC is a short piece of information used to authenticate a message and check the integrity.</para>
    /// labels<para>Message Authentication Code (MAC)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MAC">http://securitytoolbox.appspot.com/stac#MAC</seealso>
    let MAC = Prefixed_Name(stac, "MAC") |> PrefixedName

    /// <summary>
    ///   <para>stac:MandatoryAccessControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only an administrator is authorized to add a new access right to the system.</para>
    /// labels<para>Mandatory Access Control (MAC)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MandatoryAccessControl">http://securitytoolbox.appspot.com/stac#MandatoryAccessControl</seealso>
    let MandatoryAccessControl =
        Prefixed_Name(stac, "MandatoryAccessControl") |> PrefixedName

    /// <summary>
    ///   <para>stac:ManetAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Manet (Mobile ad hoc network) is a self-configuring network of mobile devices connected.</para>
    /// labels<para>Manet Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ManetAttack">http://securitytoolbox.appspot.com/stac#ManetAttack</seealso>
    let ManetAttack = Prefixed_Name(stac, "ManetAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:ManetTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manet Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ManetTechnology">http://securitytoolbox.appspot.com/stac#ManetTechnology</seealso>
    let ManetTechnology = Prefixed_Name(stac, "ManetTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:MediumSensitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>MediumSensitive</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MediumSensitive">http://securitytoolbox.appspot.com/stac#MediumSensitive</seealso>
    let MediumSensitive = Prefixed_Name(stac, "MediumSensitive") |> PrefixedName
    /// <summary>
    ///   <para>stac:MeshArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mesh Architecture</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MeshArchitecture">http://securitytoolbox.appspot.com/stac#MeshArchitecture</seealso>
    let MeshArchitecture = Prefixed_Name(stac, "MeshArchitecture") |> PrefixedName
    /// <summary>
    ///   <para>stac:Flexible</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Flexible">http://securitytoolbox.appspot.com/stac#Flexible</seealso>
    let Flexible = Prefixed_Name(stac, "Flexible") |> PrefixedName
    /// <summary>
    ///   <para>stac:Scalable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Scalable">http://securitytoolbox.appspot.com/stac#Scalable</seealso>
    let Scalable = Prefixed_Name(stac, "Scalable") |> PrefixedName
    /// <summary>
    ///   <para>stac:LowCostDeployment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LowCostDeployment">http://securitytoolbox.appspot.com/stac#LowCostDeployment</seealso>
    let LowCostDeployment = Prefixed_Name(stac, "LowCostDeployment") |> PrefixedName

    /// <summary>
    ///   <para>stac:MeshArchitectureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mesh Architecture component</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MeshArchitectureComponent">http://securitytoolbox.appspot.com/stac#MeshArchitectureComponent</seealso>
    let MeshArchitectureComponent =
        Prefixed_Name(stac, "MeshArchitectureComponent") |> PrefixedName

    /// <summary>
    ///   <para>stac:MeshSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mesh Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MeshSecurityMechanism">http://securitytoolbox.appspot.com/stac#MeshSecurityMechanism</seealso>
    let MeshSecurityMechanism =
        Prefixed_Name(stac, "MeshSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:MeshKeyManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mesh Key Management</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MeshKeyManagement">http://securitytoolbox.appspot.com/stac#MeshKeyManagement</seealso>
    let MeshKeyManagement = Prefixed_Name(stac, "MeshKeyManagement") |> PrefixedName
    /// <summary>
    ///   <para>stac:MeshTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mesh Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MeshTechnology">http://securitytoolbox.appspot.com/stac#MeshTechnology</seealso>
    let MeshTechnology = Prefixed_Name(stac, "MeshTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:MeshSecurityProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mesh Security Protocol</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MeshSecurityProtocol">http://securitytoolbox.appspot.com/stac#MeshSecurityProtocol</seealso>
    let MeshSecurityProtocol =
        Prefixed_Name(stac, "MeshSecurityProtocol") |> PrefixedName

    /// <summary>
    ///   <para>stac:SecurityTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Security Tool</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SecurityTool">http://securitytoolbox.appspot.com/stac#SecurityTool</seealso>
    let SecurityTool = Prefixed_Name(stac, "SecurityTool") |> PrefixedName
    /// <summary>
    ///   <para>stac:ModeOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mode of operation describes the process of encrypting each of block cipher.</para>
    /// labels<para>Mode of operation</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ModeOperation">http://securitytoolbox.appspot.com/stac#ModeOperation</seealso>
    let ModeOperation = Prefixed_Name(stac, "ModeOperation") |> PrefixedName

    /// <summary>
    ///   <para>stac:MutualAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mutual Authentication ot two-way authentication</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MutualAuthentication">http://securitytoolbox.appspot.com/stac#MutualAuthentication</seealso>
    let MutualAuthentication =
        Prefixed_Name(stac, "MutualAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>stac:NegativeFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Negative Feature of security mechanisms</para>
    /// labels<para>Negative Feature</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#NegativeFeature">http://securitytoolbox.appspot.com/stac#NegativeFeature</seealso>
    let NegativeFeature = Prefixed_Name(stac, "NegativeFeature") |> PrefixedName

    /// <summary>
    ///   <para>stac:NetworkManagementAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Network Management Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#NetworkManagementAttack">http://securitytoolbox.appspot.com/stac#NetworkManagementAttack</seealso>
    let NetworkManagementAttack =
        Prefixed_Name(stac, "NetworkManagementAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:NetworkManagementTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Network Management Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#NetworkManagementTechnology">http://securitytoolbox.appspot.com/stac#NetworkManagementTechnology</seealso>
    let NetworkManagementTechnology =
        Prefixed_Name(stac, "NetworkManagementTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:ABAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Permissions are associated with a set of rules expressed on measurable parameters and are granted to users who can prove compliance with these rules.</para>
    /// labels<para>Attribute Based Access control (ABAC)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ABAC">http://securitytoolbox.appspot.com/stac#ABAC</seealso>
    let ABAC = Prefixed_Name(stac, "ABAC") |> PrefixedName

    /// <summary>
    ///   <para>stac:SecurityPropertyMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Security Property Method</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SecurityPropertyMethod">http://securitytoolbox.appspot.com/stac#SecurityPropertyMethod</seealso>
    let SecurityPropertyMethod =
        Prefixed_Name(stac, "SecurityPropertyMethod") |> PrefixedName

    /// <summary>
    ///   <para>stac:AntiSpam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Anti Spam</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#AntiSpam">http://securitytoolbox.appspot.com/stac#AntiSpam</seealso>
    let AntiSpam = Prefixed_Name(stac, "AntiSpam") |> PrefixedName
    /// <summary>
    ///   <para>stac:AntiSpyware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Anti Spyware</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#AntiSpyware">http://securitytoolbox.appspot.com/stac#AntiSpyware</seealso>
    let AntiSpyware = Prefixed_Name(stac, "AntiSpyware") |> PrefixedName
    /// <summary>
    ///   <para>stac:IntegrityMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data integrity guarantees that the transmitted messages are not modified by attackers, either due to malicious intent or by accident.</para>
    /// labels<para>Integrity Method</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#IntegrityMethod">http://securitytoolbox.appspot.com/stac#IntegrityMethod</seealso>
    let IntegrityMethod = Prefixed_Name(stac, "IntegrityMethod") |> PrefixedName
    /// <summary>
    ///   <para>stac:AsymmetricAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The keys used for encryption and decryption are different, allowing for easier key distribution.</para>
    /// labels<para>Asymmetric algorithm</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#AsymmetricAlgorithm">http://securitytoolbox.appspot.com/stac#AsymmetricAlgorithm</seealso>
    let AsymmetricAlgorithm = Prefixed_Name(stac, "AsymmetricAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>stac:EncryptionAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Encryption algorithm ensures the confidentiality property.</para>
    /// labels<para>Encryption Algorithm</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#EncryptionAlgorithm">http://securitytoolbox.appspot.com/stac#EncryptionAlgorithm</seealso>
    let EncryptionAlgorithm = Prefixed_Name(stac, "EncryptionAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>stac:AvailabilityMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data availability ensures that the network is alive and that data are accessible.</para>
    /// labels<para>Availability Method</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#AvailabilityMethod">http://securitytoolbox.appspot.com/stac#AvailabilityMethod</seealso>
    let AvailabilityMethod = Prefixed_Name(stac, "AvailabilityMethod") |> PrefixedName
    /// <summary>
    ///   <para>stac:Badge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Badge</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Badge">http://securitytoolbox.appspot.com/stac#Badge</seealso>
    let Badge = Prefixed_Name(stac, "Badge") |> PrefixedName
    /// <summary>
    ///   <para>stac:BlockCipher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>BlockCipher</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#BlockCipher">http://securitytoolbox.appspot.com/stac#BlockCipher</seealso>
    let BlockCipher = Prefixed_Name(stac, "BlockCipher") |> PrefixedName
    /// <summary>
    ///   <para>stac:SecurityAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Security Algorithm</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SecurityAlgorithm">http://securitytoolbox.appspot.com/stac#SecurityAlgorithm</seealso>
    let SecurityAlgorithm = Prefixed_Name(stac, "SecurityAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>stac:PresentationLayer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#PresentationLayer">http://securitytoolbox.appspot.com/stac#PresentationLayer</seealso>
    let PresentationLayer = Prefixed_Name(stac, "PresentationLayer") |> PrefixedName

    /// <summary>
    ///   <para>stac:OneWayAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>One Way Authentication</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#OneWayAuthentication">http://securitytoolbox.appspot.com/stac#OneWayAuthentication</seealso>
    let OneWayAuthentication =
        Prefixed_Name(stac, "OneWayAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>stac:OperatingSystemAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Operating System Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#OperatingSystemAttack">http://securitytoolbox.appspot.com/stac#OperatingSystemAttack</seealso>
    let OperatingSystemAttack =
        Prefixed_Name(stac, "OperatingSystemAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:ActiveAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Active attacks involve actions performed by adversaries to gain the control of the network.</para>
    /// labels<para>Active Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ActiveAttack">http://securitytoolbox.appspot.com/stac#ActiveAttack</seealso>
    let ActiveAttack = Prefixed_Name(stac, "ActiveAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:WebSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Web Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WebSecurityMechanism">http://securitytoolbox.appspot.com/stac#WebSecurityMechanism</seealso>
    let WebSecurityMechanism =
        Prefixed_Name(stac, "WebSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:M2MSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>M2M SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#M2MSecurityMechanism">http://securitytoolbox.appspot.com/stac#M2MSecurityMechanism</seealso>
    let M2MSecurityMechanism =
        Prefixed_Name(stac, "M2MSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:PrivateKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The private key is used for computing signatures and decryption.</para>
    /// labels<para>Private Key </para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#PrivateKey">http://securitytoolbox.appspot.com/stac#PrivateKey</seealso>
    let PrivateKey = Prefixed_Name(stac, "PrivateKey") |> PrefixedName

    /// <summary>
    ///   <para>stac:AuthenticationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Authentication prevents unauthorized access to the network.</para>
    /// labels<para>Authentication Method</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#AuthenticationMethod">http://securitytoolbox.appspot.com/stac#AuthenticationMethod</seealso>
    let AuthenticationMethod =
        Prefixed_Name(stac, "AuthenticationMethod") |> PrefixedName

    /// <summary>
    ///   <para>stac:GSMArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GSM Architecture</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GSMArchitecture">http://securitytoolbox.appspot.com/stac#GSMArchitecture</seealso>
    let GSMArchitecture = Prefixed_Name(stac, "GSMArchitecture") |> PrefixedName

    /// <summary>
    ///   <para>stac:GSMSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GSM SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GSMSecurityMechanism">http://securitytoolbox.appspot.com/stac#GSMSecurityMechanism</seealso>
    let GSMSecurityMechanism =
        Prefixed_Name(stac, "GSMSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:GSMKeyManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GSM Key Management</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GSMKeyManagement">http://securitytoolbox.appspot.com/stac#GSMKeyManagement</seealso>
    let GSMKeyManagement = Prefixed_Name(stac, "GSMKeyManagement") |> PrefixedName
    /// <summary>
    ///   <para>stac:GSMTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Global System for Mobile Communication (GSM) or 2G</para>
    /// labels<para>Global System for Mobile Communication (GSM) or 2G</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GSMTechnology">http://securitytoolbox.appspot.com/stac#GSMTechnology</seealso>
    let GSMTechnology = Prefixed_Name(stac, "GSMTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:Protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Protocol</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Protocol">http://securitytoolbox.appspot.com/stac#Protocol</seealso>
    let Protocol = Prefixed_Name(stac, "Protocol") |> PrefixedName
    /// <summary>
    ///   <para>stac:AccessControlMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Access Control is the mechanism that allows owners of resources to define, manage and enforce access conditions applicable to each resource.</para>
    /// labels<para>Access Control Method</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#AccessControlMethod">http://securitytoolbox.appspot.com/stac#AccessControlMethod</seealso>
    let AccessControlMethod = Prefixed_Name(stac, "AccessControlMethod") |> PrefixedName
    /// <summary>
    ///   <para>stac:Antivirus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Anti-viruses softwares applications will reduce viruses and malware on M2M equipment.</para>
    /// labels<para>Antivirus</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Antivirus">http://securitytoolbox.appspot.com/stac#Antivirus</seealso>
    let Antivirus = Prefixed_Name(stac, "Antivirus") |> PrefixedName

    /// <summary>
    ///   <para>stac:NetworkManagementSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Network Management Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#NetworkManagementSecurityMechanism">http://securitytoolbox.appspot.com/stac#NetworkManagementSecurityMechanism</seealso>
    let NetworkManagementSecurityMechanism =
        Prefixed_Name(stac, "NetworkManagementSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:ArchitectureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Architecture component</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ArchitectureComponent">http://securitytoolbox.appspot.com/stac#ArchitectureComponent</seealso>
    let ArchitectureComponent =
        Prefixed_Name(stac, "ArchitectureComponent") |> PrefixedName

    /// <summary>
    ///   <para>stac:PublicKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The public key is used for verifying a digital signature and is used for encryption.</para>
    /// labels<para>Public Key </para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#PublicKey">http://securitytoolbox.appspot.com/stac#PublicKey</seealso>
    let PublicKey = Prefixed_Name(stac, "PublicKey") |> PrefixedName
    /// <summary>
    ///   <para>stac:ExchangeKeyEasy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ExchangeKeyEasy">http://securitytoolbox.appspot.com/stac#ExchangeKeyEasy</seealso>
    let ExchangeKeyEasy = Prefixed_Name(stac, "ExchangeKeyEasy") |> PrefixedName
    /// <summary>
    ///   <para>stac:AsymmetricKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Asymmetric Key</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#AsymmetricKey">http://securitytoolbox.appspot.com/stac#AsymmetricKey</seealso>
    let AsymmetricKey = Prefixed_Name(stac, "AsymmetricKey") |> PrefixedName
    /// <summary>
    ///   <para>stac:GSMSecurityProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>GSM Security Protocol</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GSMSecurityProtocol">http://securitytoolbox.appspot.com/stac#GSMSecurityProtocol</seealso>
    let GSMSecurityProtocol = Prefixed_Name(stac, "GSMSecurityProtocol") |> PrefixedName
    /// <summary>
    ///   <para>stac:HSPDAAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>HSPDA Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#HSPDAAttack">http://securitytoolbox.appspot.com/stac#HSPDAAttack</seealso>
    let HSPDAAttack = Prefixed_Name(stac, "HSPDAAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:HSPDATechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>High-Speed Download Packet Access (HSPDA) or 3.5G</para>
    /// labels<para>High-Speed Download Packet Access (HSPDA) or 3.5G</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#HSPDATechnology">http://securitytoolbox.appspot.com/stac#HSPDATechnology</seealso>
    let HSPDATechnology = Prefixed_Name(stac, "HSPDATechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:HighSensitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>HighSensitive</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#HighSensitive">http://securitytoolbox.appspot.com/stac#HighSensitive</seealso>
    let HighSensitive = Prefixed_Name(stac, "HighSensitive") |> PrefixedName
    /// <summary>
    ///   <para>stac:IPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Intrusion Prevention System (IPS)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#IPS">http://securitytoolbox.appspot.com/stac#IPS</seealso>
    let IPS = Prefixed_Name(stac, "IPS") |> PrefixedName
    /// <summary>
    ///   <para>stac:LTEArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>LTE Architecture</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LTEArchitecture">http://securitytoolbox.appspot.com/stac#LTEArchitecture</seealso>
    let LTEArchitecture = Prefixed_Name(stac, "LTEArchitecture") |> PrefixedName
    /// <summary>
    ///   <para>stac:M2MTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Machine-to-Machine(M2M)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#M2MTechnology">http://securitytoolbox.appspot.com/stac#M2MTechnology</seealso>
    let M2MTechnology = Prefixed_Name(stac, "M2MTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:ManetSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manet SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ManetSecurityMechanism">http://securitytoolbox.appspot.com/stac#ManetSecurityMechanism</seealso>
    let ManetSecurityMechanism =
        Prefixed_Name(stac, "ManetSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:AnonymityMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Anonymity protects user identity, making it hard to track the whereabouts of a certain user.</para>
    /// labels<para>Anonymity Method</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#AnonymityMethod">http://securitytoolbox.appspot.com/stac#AnonymityMethod</seealso>
    let AnonymityMethod = Prefixed_Name(stac, "AnonymityMethod") |> PrefixedName
    /// <summary>
    ///   <para>stac:ECommerceTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>ECommerce Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ECommerceTechnology">http://securitytoolbox.appspot.com/stac#ECommerceTechnology</seealso>
    let ECommerceTechnology = Prefixed_Name(stac, "ECommerceTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:EDGESecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>EDGE SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#EDGESecurityMechanism">http://securitytoolbox.appspot.com/stac#EDGESecurityMechanism</seealso>
    let EDGESecurityMechanism =
        Prefixed_Name(stac, "EDGESecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:EDGETechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enhanced Data Rates for GSM Evolution (EDGE) or 2.75G</para>
    /// labels<para>Enhanced Data Rates for GSM Evolution (EDGE) or 2.75G</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#EDGETechnology">http://securitytoolbox.appspot.com/stac#EDGETechnology</seealso>
    let EDGETechnology = Prefixed_Name(stac, "EDGETechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:UMTSTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Universal Mobile Telecommunications System (UMTS). Third Generation (3G)</para>
    /// labels<para>3G technology (UMTS:Universal Mobile Telecommunications System)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UMTSTechnology">http://securitytoolbox.appspot.com/stac#UMTSTechnology</seealso>
    let UMTSTechnology = Prefixed_Name(stac, "UMTSTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:Architecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Architecture</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Architecture">http://securitytoolbox.appspot.com/stac#Architecture</seealso>
    let Architecture = Prefixed_Name(stac, "Architecture") |> PrefixedName
    /// <summary>
    ///   <para>stac:protectsInLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>protectsInLayer</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#protectsInLayer">http://securitytoolbox.appspot.com/stac#protectsInLayer</seealso>
    let protectsInLayer = Prefixed_Name(stac, "protectsInLayer") |> PrefixedName
    /// <summary>
    ///   <para>stac:occursInLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>occursInLayer</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#occursInLayer">http://securitytoolbox.appspot.com/stac#occursInLayer</seealso>
    let occursInLayer = Prefixed_Name(stac, "occursInLayer") |> PrefixedName

    /// <summary>
    ///   <para>stac:FrameworkSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Framework Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#FrameworkSecurityMechanism">http://securitytoolbox.appspot.com/stac#FrameworkSecurityMechanism</seealso>
    let FrameworkSecurityMechanism =
        Prefixed_Name(stac, "FrameworkSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:GPRSArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The GPRS system are a much more expesed to intruders, because of its IP based backbone.</para>
    /// labels<para>GPRS Architecture</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GPRSArchitecture">http://securitytoolbox.appspot.com/stac#GPRSArchitecture</seealso>
    let GPRSArchitecture = Prefixed_Name(stac, "GPRSArchitecture") |> PrefixedName
    /// <summary>
    ///   <para>stac:GPRSTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>General Packet Radio Service (GPRS) or 2.5G</para>
    /// labels<para>General Packet Radio Service (GPRS) or 2.5G</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#GPRSTechnology">http://securitytoolbox.appspot.com/stac#GPRSTechnology</seealso>
    let GPRSTechnology = Prefixed_Name(stac, "GPRSTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:HighEnergyConsuming</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#HighEnergyConsuming">http://securitytoolbox.appspot.com/stac#HighEnergyConsuming</seealso>
    let HighEnergyConsuming = Prefixed_Name(stac, "HighEnergyConsuming") |> PrefixedName
    /// <summary>
    ///   <para>stac:JavaSecurityApi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Java Api</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#JavaSecurityApi">http://securitytoolbox.appspot.com/stac#JavaSecurityApi</seealso>
    let JavaSecurityApi = Prefixed_Name(stac, "JavaSecurityApi") |> PrefixedName
    /// <summary>
    ///   <para>stac:hasFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A SecurityMechanism has specific features (secured, depreceted, low energy consuming). For example, an asymmetric algorithm is high energy consuming.</para>
    /// labels<para>hasFeature</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#hasFeature">http://securitytoolbox.appspot.com/stac#hasFeature</seealso>
    let hasFeature = Prefixed_Name(stac, "hasFeature") |> PrefixedName

    /// <summary>
    ///   <para>stac:AuthenticationServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It identifies the supplicant, checks its credentials, and define privileges and restrictions, and allows or denies it access to the network and services.</para>
    /// labels<para>Authentication Server (AS)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#AuthenticationServer">http://securitytoolbox.appspot.com/stac#AuthenticationServer</seealso>
    let AuthenticationServer =
        Prefixed_Name(stac, "AuthenticationServer") |> PrefixedName

    /// <summary>
    ///   <para>stac:Bank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Bank</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Bank">http://securitytoolbox.appspot.com/stac#Bank</seealso>
    let Bank = Prefixed_Name(stac, "Bank") |> PrefixedName

    /// <summary>
    ///   <para>stac:MessageEncryptionTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Message Encryption Tool</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MessageEncryptionTool">http://securitytoolbox.appspot.com/stac#MessageEncryptionTool</seealso>
    let MessageEncryptionTool =
        Prefixed_Name(stac, "MessageEncryptionTool") |> PrefixedName

    /// <summary>
    ///   <para>stac:NetworkManagementSecurityTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Network Management Security Tool</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#NetworkManagementSecurityTool">http://securitytoolbox.appspot.com/stac#NetworkManagementSecurityTool</seealso>
    let NetworkManagementSecurityTool =
        Prefixed_Name(stac, "NetworkManagementSecurityTool") |> PrefixedName

    /// <summary>
    ///   <para>stac:OSIModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para></para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#OSIModel">http://securitytoolbox.appspot.com/stac#OSIModel</seealso>
    let OSIModel = Prefixed_Name(stac, "OSIModel") |> PrefixedName
    /// <summary>
    ///   <para>stac:PhysicalLayer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#PhysicalLayer">http://securitytoolbox.appspot.com/stac#PhysicalLayer</seealso>
    let PhysicalLayer = Prefixed_Name(stac, "PhysicalLayer") |> PrefixedName
    /// <summary>
    ///   <para>stac:LinkLayer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LinkLayer">http://securitytoolbox.appspot.com/stac#LinkLayer</seealso>
    let LinkLayer = Prefixed_Name(stac, "LinkLayer") |> PrefixedName
    /// <summary>
    ///   <para>stac:SessionLayer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SessionLayer">http://securitytoolbox.appspot.com/stac#SessionLayer</seealso>
    let SessionLayer = Prefixed_Name(stac, "SessionLayer") |> PrefixedName
    /// <summary>
    ///   <para>stac:Obfuscation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Obfuscation</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Obfuscation">http://securitytoolbox.appspot.com/stac#Obfuscation</seealso>
    let Obfuscation = Prefixed_Name(stac, "Obfuscation") |> PrefixedName

    /// <summary>
    ///   <para>stac:OperatingSystemSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Operating System Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#OperatingSystemSecurityMechanism">http://securitytoolbox.appspot.com/stac#OperatingSystemSecurityMechanism</seealso>
    let OperatingSystemSecurityMechanism =
        Prefixed_Name(stac, "OperatingSystemSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:OperatingSystemTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Operating system Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#OperatingSystemTechnology">http://securitytoolbox.appspot.com/stac#OperatingSystemTechnology</seealso>
    let OperatingSystemTechnology =
        Prefixed_Name(stac, "OperatingSystemTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:PassiveAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Malicious users violate the confidentiality  of the information exchanged over the network.</para>
    /// labels<para>Passive Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#PassiveAttack">http://securitytoolbox.appspot.com/stac#PassiveAttack</seealso>
    let PassiveAttack = Prefixed_Name(stac, "PassiveAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:PhysicalKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Physical Key</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#PhysicalKey">http://securitytoolbox.appspot.com/stac#PhysicalKey</seealso>
    let PhysicalKey = Prefixed_Name(stac, "PhysicalKey") |> PrefixedName
    /// <summary>
    ///   <para>stac:Virus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Virus</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Virus">http://securitytoolbox.appspot.com/stac#Virus</seealso>
    let Virus = Prefixed_Name(stac, "Virus") |> PrefixedName
    /// <summary>
    ///   <para>stac:PositiveFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Positive Feature of security mechanisms</para>
    /// labels<para>Positive Feature</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#PositiveFeature">http://securitytoolbox.appspot.com/stac#PositiveFeature</seealso>
    let PositiveFeature = Prefixed_Name(stac, "PositiveFeature") |> PrefixedName

    /// <summary>
    ///   <para>stac:ProgrammingLanguageSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Programming Language Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageSecurityMechanism">http://securitytoolbox.appspot.com/stac#ProgrammingLanguageSecurityMechanism</seealso>
    let ProgrammingLanguageSecurityMechanism =
        Prefixed_Name(stac, "ProgrammingLanguageSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:ProgrammingLanguageTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Programming Language</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageTechnology">http://securitytoolbox.appspot.com/stac#ProgrammingLanguageTechnology</seealso>
    let ProgrammingLanguageTechnology =
        Prefixed_Name(stac, "ProgrammingLanguageTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:RBAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mechanism for access control that organizes users (in the system) into specific groups called Roles. E.g., Doctor and nurses are different roles in a hospital.</para>
    /// labels<para>Role Based Access Control (RBAC)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#RBAC">http://securitytoolbox.appspot.com/stac#RBAC</seealso>
    let RBAC = Prefixed_Name(stac, "RBAC") |> PrefixedName
    /// <summary>
    ///   <para>stac:Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The application to secure has requirements (e.g., high sensitive data or specific technologies).</para>
    /// labels<para>Requirement</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Requirement">http://securitytoolbox.appspot.com/stac#Requirement</seealso>
    let Requirement = Prefixed_Name(stac, "Requirement") |> PrefixedName
    /// <summary>
    ///   <para>stac:RfidAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>RFID Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#RfidAttack">http://securitytoolbox.appspot.com/stac#RfidAttack</seealso>
    let RfidAttack = Prefixed_Name(stac, "RfidAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:RfidSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rfid SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#RfidSecurityMechanism">http://securitytoolbox.appspot.com/stac#RfidSecurityMechanism</seealso>
    let RfidSecurityMechanism =
        Prefixed_Name(stac, "RfidSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:RfidTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rfid Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#RfidTechnology">http://securitytoolbox.appspot.com/stac#RfidTechnology</seealso>
    let RfidTechnology = Prefixed_Name(stac, "RfidTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:SecurityProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>SecurityProperty</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SecurityProperty">http://securitytoolbox.appspot.com/stac#SecurityProperty</seealso>
    let SecurityProperty = Prefixed_Name(stac, "SecurityProperty") |> PrefixedName
    /// <summary>
    ///   <para>stac:SensorTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sensor Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SensorTechnology">http://securitytoolbox.appspot.com/stac#SensorTechnology</seealso>
    let SensorTechnology = Prefixed_Name(stac, "SensorTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:SensorSecurityProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sensor Security Protocol</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SensorSecurityProtocol">http://securitytoolbox.appspot.com/stac#SensorSecurityProtocol</seealso>
    let SensorSecurityProtocol =
        Prefixed_Name(stac, "SensorSecurityProtocol") |> PrefixedName

    /// <summary>
    ///   <para>stac:ServerAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Server Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ServerAttack">http://securitytoolbox.appspot.com/stac#ServerAttack</seealso>
    let ServerAttack = Prefixed_Name(stac, "ServerAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:ServerTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Server Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ServerTechnology">http://securitytoolbox.appspot.com/stac#ServerTechnology</seealso>
    let ServerTechnology = Prefixed_Name(stac, "ServerTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:Sniffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Sniffer tries to spy passwords for instance.</para>
    /// labels<para>Sniffer</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Sniffer">http://securitytoolbox.appspot.com/stac#Sniffer</seealso>
    let Sniffer = Prefixed_Name(stac, "Sniffer") |> PrefixedName
    /// <summary>
    ///   <para>stac:Spam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Spam</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Spam">http://securitytoolbox.appspot.com/stac#Spam</seealso>
    let Spam = Prefixed_Name(stac, "Spam") |> PrefixedName
    /// <summary>
    ///   <para>stac:LowEnergyConsuming</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LowEnergyConsuming">http://securitytoolbox.appspot.com/stac#LowEnergyConsuming</seealso>
    let LowEnergyConsuming = Prefixed_Name(stac, "LowEnergyConsuming") |> PrefixedName
    /// <summary>
    ///   <para>stac:ExchangeKeyNotEasy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ExchangeKeyNotEasy">http://securitytoolbox.appspot.com/stac#ExchangeKeyNotEasy</seealso>
    let ExchangeKeyNotEasy = Prefixed_Name(stac, "ExchangeKeyNotEasy") |> PrefixedName
    /// <summary>
    ///   <para>stac:SymmetricKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Symmetric key: the same key is used for encryption and decryption.</para>
    /// labels<para>Symmetric Key</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SymmetricKey">http://securitytoolbox.appspot.com/stac#SymmetricKey</seealso>
    let SymmetricKey = Prefixed_Name(stac, "SymmetricKey") |> PrefixedName
    /// <summary>
    ///   <para>stac:TemporaryIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Temporary Identity</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#TemporaryIdentity">http://securitytoolbox.appspot.com/stac#TemporaryIdentity</seealso>
    let TemporaryIdentity = Prefixed_Name(stac, "TemporaryIdentity") |> PrefixedName
    /// <summary>
    ///   <para>stac:Timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In order to ensure the freshness of packet, a timestamp can be attached to the packet. A receiving node can compare the timestamp in the packet with its own time clock and determine whether the packet is valid or not.</para>
    /// labels<para>Timestamp</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Timestamp">http://securitytoolbox.appspot.com/stac#Timestamp</seealso>
    let Timestamp = Prefixed_Name(stac, "Timestamp") |> PrefixedName
    /// <summary>
    ///   <para>stac:isVulnerabilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Some attacks cannot be thwart in technologies. For example, the Denial of Service is difficult to thwart in different technologies.</para>
    /// labels<para>is Vulnerability Of</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#isVulnerabilityOf">http://securitytoolbox.appspot.com/stac#isVulnerabilityOf</seealso>
    let isVulnerabilityOf = Prefixed_Name(stac, "isVulnerabilityOf") |> PrefixedName
    /// <summary>
    ///   <para>stac:UMTSArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>UMTS Architecture</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UMTSArchitecture">http://securitytoolbox.appspot.com/stac#UMTSArchitecture</seealso>
    let UMTSArchitecture = Prefixed_Name(stac, "UMTSArchitecture") |> PrefixedName

    /// <summary>
    ///   <para>stac:UMTSArchitectureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>UMTS Architecture component</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UMTSArchitectureComponent">http://securitytoolbox.appspot.com/stac#UMTSArchitectureComponent</seealso>
    let UMTSArchitectureComponent =
        Prefixed_Name(stac, "UMTSArchitectureComponent") |> PrefixedName

    /// <summary>
    ///   <para>stac:UMTSAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>UMTS Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UMTSAttack">http://securitytoolbox.appspot.com/stac#UMTSAttack</seealso>
    let UMTSAttack = Prefixed_Name(stac, "UMTSAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:UMTSKeyManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>UMTS Key Management</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UMTSKeyManagement">http://securitytoolbox.appspot.com/stac#UMTSKeyManagement</seealso>
    let UMTSKeyManagement = Prefixed_Name(stac, "UMTSKeyManagement") |> PrefixedName

    /// <summary>
    ///   <para>stac:UMTSSecurityAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>UMTS Security Algorithm</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UMTSSecurityAlgorithm">http://securitytoolbox.appspot.com/stac#UMTSSecurityAlgorithm</seealso>
    let UMTSSecurityAlgorithm =
        Prefixed_Name(stac, "UMTSSecurityAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>stac:UwbAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Uwb Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UwbAttack">http://securitytoolbox.appspot.com/stac#UwbAttack</seealso>
    let UwbAttack = Prefixed_Name(stac, "UwbAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:UwbSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Uwb SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UwbSecurityMechanism">http://securitytoolbox.appspot.com/stac#UwbSecurityMechanism</seealso>
    let UwbSecurityMechanism =
        Prefixed_Name(stac, "UwbSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:UwbTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ultra Wideband (UWB) Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UwbTechnology">http://securitytoolbox.appspot.com/stac#UwbTechnology</seealso>
    let UwbTechnology = Prefixed_Name(stac, "UwbTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:WebSecurityProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Web Security Protocol</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WebSecurityProtocol">http://securitytoolbox.appspot.com/stac#WebSecurityProtocol</seealso>
    let WebSecurityProtocol = Prefixed_Name(stac, "WebSecurityProtocol") |> PrefixedName
    /// <summary>
    ///   <para>stac:WebService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Web Service</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WebService">http://securitytoolbox.appspot.com/stac#WebService</seealso>
    let WebService = Prefixed_Name(stac, "WebService") |> PrefixedName
    /// <summary>
    ///   <para>stac:WebServiceAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Web Service Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WebServiceAttack">http://securitytoolbox.appspot.com/stac#WebServiceAttack</seealso>
    let WebServiceAttack = Prefixed_Name(stac, "WebServiceAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:WebServiceSecurityMechanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WebServiceSecurityMechanism">http://securitytoolbox.appspot.com/stac#WebServiceSecurityMechanism</seealso>
    let WebServiceSecurityMechanism =
        Prefixed_Name(stac, "WebServiceSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:WebServiceTechnology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WebServiceTechnology">http://securitytoolbox.appspot.com/stac#WebServiceTechnology</seealso>
    let WebServiceTechnology =
        Prefixed_Name(stac, "WebServiceTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:WifiArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wifi Architecture</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WifiArchitecture">http://securitytoolbox.appspot.com/stac#WifiArchitecture</seealso>
    let WifiArchitecture = Prefixed_Name(stac, "WifiArchitecture") |> PrefixedName

    /// <summary>
    ///   <para>stac:WifiArchitectureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wifi Architecture component</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WifiArchitectureComponent">http://securitytoolbox.appspot.com/stac#WifiArchitectureComponent</seealso>
    let WifiArchitectureComponent =
        Prefixed_Name(stac, "WifiArchitectureComponent") |> PrefixedName

    /// <summary>
    ///   <para>stac:WifiAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wifi Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WifiAttack">http://securitytoolbox.appspot.com/stac#WifiAttack</seealso>
    let WifiAttack = Prefixed_Name(stac, "WifiAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:WifiSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wifi SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WifiSecurityMechanism">http://securitytoolbox.appspot.com/stac#WifiSecurityMechanism</seealso>
    let WifiSecurityMechanism =
        Prefixed_Name(stac, "WifiSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:WifiAttackTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wifi Attack Tool</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WifiAttackTool">http://securitytoolbox.appspot.com/stac#WifiAttackTool</seealso>
    let WifiAttackTool = Prefixed_Name(stac, "WifiAttackTool") |> PrefixedName
    /// <summary>
    ///   <para>stac:WifiKeyManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wifi Key Management</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WifiKeyManagement">http://securitytoolbox.appspot.com/stac#WifiKeyManagement</seealso>
    let WifiKeyManagement = Prefixed_Name(stac, "WifiKeyManagement") |> PrefixedName
    /// <summary>
    ///   <para>stac:MeshAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mesh Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#MeshAttack">http://securitytoolbox.appspot.com/stac#MeshAttack</seealso>
    let MeshAttack = Prefixed_Name(stac, "MeshAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:PhysicalAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Physical Authentication</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#PhysicalAuthentication">http://securitytoolbox.appspot.com/stac#PhysicalAuthentication</seealso>
    let PhysicalAuthentication =
        Prefixed_Name(stac, "PhysicalAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>stac:SymmetricAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The same secret key is used for encryption and decryption.</para>
    /// labels<para>Symmetric algorithm</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SymmetricAlgorithm">http://securitytoolbox.appspot.com/stac#SymmetricAlgorithm</seealso>
    let SymmetricAlgorithm = Prefixed_Name(stac, "SymmetricAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>stac:NetworkLayer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#NetworkLayer">http://securitytoolbox.appspot.com/stac#NetworkLayer</seealso>
    let NetworkLayer = Prefixed_Name(stac, "NetworkLayer") |> PrefixedName
    /// <summary>
    ///   <para>stac:OSIModelLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>OSI Model Layer</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#OSIModelLayer">http://securitytoolbox.appspot.com/stac#OSIModelLayer</seealso>
    let OSIModelLayer = Prefixed_Name(stac, "OSIModelLayer") |> PrefixedName

    /// <summary>
    ///   <para>stac:BluetoothSecurityAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Bluetooth Security Algorithm</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#BluetoothSecurityAlgorithm">http://securitytoolbox.appspot.com/stac#BluetoothSecurityAlgorithm</seealso>
    let BluetoothSecurityAlgorithm =
        Prefixed_Name(stac, "BluetoothSecurityAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>stac:hasVulnerability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A technology can be vulnerable to some attacks.</para>
    /// labels<para>has vulnerability</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#hasVulnerability">http://securitytoolbox.appspot.com/stac#hasVulnerability</seealso>
    let hasVulnerability = Prefixed_Name(stac, "hasVulnerability") |> PrefixedName
    /// <summary>
    ///   <para>stac:Captcha</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Captcha</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Captcha">http://securitytoolbox.appspot.com/stac#Captcha</seealso>
    let Captcha = Prefixed_Name(stac, "Captcha") |> PrefixedName

    /// <summary>
    ///   <para>stac:CloudSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Cloud Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#CloudSecurityMechanism">http://securitytoolbox.appspot.com/stac#CloudSecurityMechanism</seealso>
    let CloudSecurityMechanism =
        Prefixed_Name(stac, "CloudSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:CloudTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Cloud Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#CloudTechnology">http://securitytoolbox.appspot.com/stac#CloudTechnology</seealso>
    let CloudTechnology = Prefixed_Name(stac, "CloudTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:ConfidentialityMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Confidentiality means that only destined user must be able to read data.</para>
    /// labels<para>Confidentiality Method</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ConfidentialityMethod">http://securitytoolbox.appspot.com/stac#ConfidentialityMethod</seealso>
    let ConfidentialityMethod =
        Prefixed_Name(stac, "ConfidentialityMethod") |> PrefixedName

    /// <summary>
    ///   <para>stac:DataFreshnessMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data freshness suggests that the data is recent, and it ensures that no old messages have been replayed.</para>
    /// labels<para>Data Freshness Method</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#DataFreshnessMethod">http://securitytoolbox.appspot.com/stac#DataFreshnessMethod</seealso>
    let DataFreshnessMethod = Prefixed_Name(stac, "DataFreshnessMethod") |> PrefixedName

    /// <summary>
    ///   <para>stac:CryptographicConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>CryptographicConcept</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#CryptographicConcept">http://securitytoolbox.appspot.com/stac#CryptographicConcept</seealso>
    let CryptographicConcept =
        Prefixed_Name(stac, "CryptographicConcept") |> PrefixedName

    /// <summary>
    ///   <para>stac:Troyan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Trojan horse is a malicious piece of software hidden in a program that performs normal tasks. Program that does something malicious (such as capturing passwords) when run by an unsuspecting user.</para>
    /// labels<para>Troyan</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Troyan">http://securitytoolbox.appspot.com/stac#Troyan</seealso>
    let Troyan = Prefixed_Name(stac, "Troyan") |> PrefixedName
    /// <summary>
    ///   <para>stac:SecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Security Mechanisms are processes that are used to detect, prevent and recover from security attacks.</para>
    /// labels<para>SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SecurityMechanism">http://securitytoolbox.appspot.com/stac#SecurityMechanism</seealso>
    let SecurityMechanism = Prefixed_Name(stac, "SecurityMechanism") |> PrefixedName
    /// <summary>
    ///   <para>stac:ChallengeResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Challenge/Response is a mechanism where on entity in the network proves to another entity that it knows the password without revealing it.</para>
    /// labels<para>Challenge Response</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ChallengeResponse">http://securitytoolbox.appspot.com/stac#ChallengeResponse</seealso>
    let ChallengeResponse = Prefixed_Name(stac, "ChallengeResponse") |> PrefixedName
    /// <summary>
    ///   <para>stac:SecurityMagazine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Security Magazine</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SecurityMagazine">http://securitytoolbox.appspot.com/stac#SecurityMagazine</seealso>
    let SecurityMagazine = Prefixed_Name(stac, "SecurityMagazine") |> PrefixedName
    /// <summary>
    ///   <para>stac:Personal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Personal</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Personal">http://securitytoolbox.appspot.com/stac#Personal</seealso>
    let Personal = Prefixed_Name(stac, "Personal") |> PrefixedName
    /// <summary>
    ///   <para>stac:PolymorphicVirus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Polymorphic Virus</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#PolymorphicVirus">http://securitytoolbox.appspot.com/stac#PolymorphicVirus</seealso>
    let PolymorphicVirus = Prefixed_Name(stac, "PolymorphicVirus") |> PrefixedName
    /// <summary>
    ///   <para>stac:PreSharedKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pre Shared Key</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#PreSharedKey">http://securitytoolbox.appspot.com/stac#PreSharedKey</seealso>
    let PreSharedKey = Prefixed_Name(stac, "PreSharedKey") |> PrefixedName

    /// <summary>
    ///   <para>stac:ProgrammingLanguageAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Programming Language Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ProgrammingLanguageAttack">http://securitytoolbox.appspot.com/stac#ProgrammingLanguageAttack</seealso>
    let ProgrammingLanguageAttack =
        Prefixed_Name(stac, "ProgrammingLanguageAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:Proxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A proxy analyzes application commands, performs authentication and keeps logs.</para>
    /// labels<para>Proxy</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Proxy">http://securitytoolbox.appspot.com/stac#Proxy</seealso>
    let Proxy = Prefixed_Name(stac, "Proxy") |> PrefixedName
    /// <summary>
    ///   <para>stac:NotFlexible</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#NotFlexible">http://securitytoolbox.appspot.com/stac#NotFlexible</seealso>
    let NotFlexible = Prefixed_Name(stac, "NotFlexible") |> PrefixedName
    /// <summary>
    ///   <para>stac:RelBAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Permissions are modeled as relations between users (subjects) and data (objects).</para>
    /// labels<para>Relation Based Access Control (RelBAC)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#RelBAC">http://securitytoolbox.appspot.com/stac#RelBAC</seealso>
    let RelBAC = Prefixed_Name(stac, "RelBAC") |> PrefixedName
    /// <summary>
    ///   <para>stac:ReverseProxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Reverse Proxy</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ReverseProxy">http://securitytoolbox.appspot.com/stac#ReverseProxy</seealso>
    let ReverseProxy = Prefixed_Name(stac, "ReverseProxy") |> PrefixedName
    /// <summary>
    ///   <para>stac:WebAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Web Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WebAttack">http://securitytoolbox.appspot.com/stac#WebAttack</seealso>
    let WebAttack = Prefixed_Name(stac, "WebAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:WebTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Web Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WebTechnology">http://securitytoolbox.appspot.com/stac#WebTechnology</seealso>
    let WebTechnology = Prefixed_Name(stac, "WebTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:CounterValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Since the counter value is incremented after each message, the same message is encrypted differently each time.</para>
    /// labels<para>Counter Value</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#CounterValue">http://securitytoolbox.appspot.com/stac#CounterValue</seealso>
    let CounterValue = Prefixed_Name(stac, "CounterValue") |> PrefixedName
    /// <summary>
    ///   <para>stac:DataTypeSensitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DataTypeSensitive (low, medium or high sensitive). The data to secure.</para>
    /// labels<para>DataTypeSensitive</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#DataTypeSensitive">http://securitytoolbox.appspot.com/stac#DataTypeSensitive</seealso>
    let DataTypeSensitive = Prefixed_Name(stac, "DataTypeSensitive") |> PrefixedName
    /// <summary>
    ///   <para>stac:DatabaseAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Database Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#DatabaseAttack">http://securitytoolbox.appspot.com/stac#DatabaseAttack</seealso>
    let DatabaseAttack = Prefixed_Name(stac, "DatabaseAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:UMTSSecurityProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>UMTS Security Protocol</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#UMTSSecurityProtocol">http://securitytoolbox.appspot.com/stac#UMTSSecurityProtocol</seealso>
    let UMTSSecurityProtocol =
        Prefixed_Name(stac, "UMTSSecurityProtocol") |> PrefixedName

    /// <summary>
    ///   <para>stac:DAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Object owners can add access rights.</para>
    /// labels<para>Discretionary Access Control (DAC)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#DAC">http://securitytoolbox.appspot.com/stac#DAC</seealso>
    let DAC = Prefixed_Name(stac, "DAC") |> PrefixedName

    /// <summary>
    ///   <para>stac:DatabaseSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Database Security Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#DatabaseSecurityMechanism">http://securitytoolbox.appspot.com/stac#DatabaseSecurityMechanism</seealso>
    let DatabaseSecurityMechanism =
        Prefixed_Name(stac, "DatabaseSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:Spyware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Spyware</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Spyware">http://securitytoolbox.appspot.com/stac#Spyware</seealso>
    let Spyware = Prefixed_Name(stac, "Spyware") |> PrefixedName
    /// <summary>
    ///   <para>stac:StreamCipher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>StreamCipher</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#StreamCipher">http://securitytoolbox.appspot.com/stac#StreamCipher</seealso>
    let StreamCipher = Prefixed_Name(stac, "StreamCipher") |> PrefixedName
    /// <summary>
    ///   <para>stac:SymmetricSensorKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>SymmetricSensorKey</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SymmetricSensorKey">http://securitytoolbox.appspot.com/stac#SymmetricSensorKey</seealso>
    let SymmetricSensorKey = Prefixed_Name(stac, "SymmetricSensorKey") |> PrefixedName
    /// <summary>
    ///   <para>stac:SystemLogs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>System Logs</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SystemLogs">http://securitytoolbox.appspot.com/stac#SystemLogs</seealso>
    let SystemLogs = Prefixed_Name(stac, "SystemLogs") |> PrefixedName
    /// <summary>
    ///   <para>stac:DatabaseTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Database Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#DatabaseTechnology">http://securitytoolbox.appspot.com/stac#DatabaseTechnology</seealso>
    let DatabaseTechnology = Prefixed_Name(stac, "DatabaseTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:DigitalSignature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The digital signature verifies that the contents of the electronic message have not been altered.</para>
    /// labels<para>Digital Signature</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#DigitalSignature">http://securitytoolbox.appspot.com/stac#DigitalSignature</seealso>
    let DigitalSignature = Prefixed_Name(stac, "DigitalSignature") |> PrefixedName

    /// <summary>
    ///   <para>stac:NonRepudiationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Non repudiation means that a sender is unable to deny having sent a message or infoomation.</para>
    /// labels<para>Non Repudiation Method</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#NonRepudiationMethod">http://securitytoolbox.appspot.com/stac#NonRepudiationMethod</seealso>
    let NonRepudiationMethod =
        Prefixed_Name(stac, "NonRepudiationMethod") |> PrefixedName

    /// <summary>
    ///   <para>stac:ECommerceSecurityMechanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ECommerceSecurityMechanism">http://securitytoolbox.appspot.com/stac#ECommerceSecurityMechanism</seealso>
    let ECommerceSecurityMechanism =
        Prefixed_Name(stac, "ECommerceSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:DigitalCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Digital Certificate</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#DigitalCertificate">http://securitytoolbox.appspot.com/stac#DigitalCertificate</seealso>
    let DigitalCertificate = Prefixed_Name(stac, "DigitalCertificate") |> PrefixedName
    /// <summary>
    ///   <para>stac:ECommerceAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>ECommerce Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ECommerceAttack">http://securitytoolbox.appspot.com/stac#ECommerceAttack</seealso>
    let ECommerceAttack = Prefixed_Name(stac, "ECommerceAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:ECommerceMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>ECommerce Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ECommerceMechanism">http://securitytoolbox.appspot.com/stac#ECommerceMechanism</seealso>
    let ECommerceMechanism = Prefixed_Name(stac, "ECommerceMechanism") |> PrefixedName
    /// <summary>
    ///   <para>stac:WimaxArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>WiMAX Architecture</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WimaxArchitecture">http://securitytoolbox.appspot.com/stac#WimaxArchitecture</seealso>
    let WimaxArchitecture = Prefixed_Name(stac, "WimaxArchitecture") |> PrefixedName
    /// <summary>
    ///   <para>stac:WimaxAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wimax Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WimaxAttack">http://securitytoolbox.appspot.com/stac#WimaxAttack</seealso>
    let WimaxAttack = Prefixed_Name(stac, "WimaxAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:WimaxKeyManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wimax Key Management</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WimaxKeyManagement">http://securitytoolbox.appspot.com/stac#WimaxKeyManagement</seealso>
    let WimaxKeyManagement = Prefixed_Name(stac, "WimaxKeyManagement") |> PrefixedName
    /// <summary>
    ///   <para>stac:WimaxTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wimax Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WimaxTechnology">http://securitytoolbox.appspot.com/stac#WimaxTechnology</seealso>
    let WimaxTechnology = Prefixed_Name(stac, "WimaxTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:WimaxSecurityProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wimax Security Protocol</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WimaxSecurityProtocol">http://securitytoolbox.appspot.com/stac#WimaxSecurityProtocol</seealso>
    let WimaxSecurityProtocol =
        Prefixed_Name(stac, "WimaxSecurityProtocol") |> PrefixedName

    /// <summary>
    ///   <para>stac:Worm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Worms are self-propagating pieces of malicious software. They propagate from one computer/device to another via a network link.</para>
    /// labels<para>Worm</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Worm">http://securitytoolbox.appspot.com/stac#Worm</seealso>
    let Worm = Prefixed_Name(stac, "Worm") |> PrefixedName
    /// <summary>
    ///   <para>stac:ZigbeeAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Zigbee Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ZigbeeAttack">http://securitytoolbox.appspot.com/stac#ZigbeeAttack</seealso>
    let ZigbeeAttack = Prefixed_Name(stac, "ZigbeeAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:ZigbeeTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Zigbee Technology</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ZigbeeTechnology">http://securitytoolbox.appspot.com/stac#ZigbeeTechnology</seealso>
    let ZigbeeTechnology = Prefixed_Name(stac, "ZigbeeTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:hasModeOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>hasModeOperation</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#hasModeOperation">http://securitytoolbox.appspot.com/stac#hasModeOperation</seealso>
    let hasModeOperation = Prefixed_Name(stac, "hasModeOperation") |> PrefixedName

    /// <summary>
    ///   <para>stac:isSecurityMechanismOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>isSecurityMechanismOf</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#isSecurityMechanismOf">http://securitytoolbox.appspot.com/stac#isSecurityMechanismOf</seealso>
    let isSecurityMechanismOf =
        Prefixed_Name(stac, "isSecurityMechanismOf") |> PrefixedName

    /// <summary>
    ///   <para>stac:threatens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An attack (e.g., eavesdropping) threatens some security properties (e.g., confidentiality)</para>
    /// labels<para>threatens</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#threatens">http://securitytoolbox.appspot.com/stac#threatens</seealso>
    let threatens = Prefixed_Name(stac, "threatens") |> PrefixedName
    /// <summary>
    ///   <para>stac:WebServiceMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Web Service Mechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WebServiceMechanism">http://securitytoolbox.appspot.com/stac#WebServiceMechanism</seealso>
    let WebServiceMechanism = Prefixed_Name(stac, "WebServiceMechanism") |> PrefixedName
    /// <summary>
    ///   <para>stac:WifiTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para> Wi-Fi technology (Wireless-Fidelity)</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WifiTechnology">http://securitytoolbox.appspot.com/stac#WifiTechnology</seealso>
    let WifiTechnology = Prefixed_Name(stac, "WifiTechnology") |> PrefixedName

    /// <summary>
    ///   <para>stac:WifiSecurityProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wifi Security Protocol</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WifiSecurityProtocol">http://securitytoolbox.appspot.com/stac#WifiSecurityProtocol</seealso>
    let WifiSecurityProtocol =
        Prefixed_Name(stac, "WifiSecurityProtocol") |> PrefixedName

    /// <summary>
    ///   <para>stac:WimaxArchitectureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wimax Architecture component</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WimaxArchitectureComponent">http://securitytoolbox.appspot.com/stac#WimaxArchitectureComponent</seealso>
    let WimaxArchitectureComponent =
        Prefixed_Name(stac, "WimaxArchitectureComponent") |> PrefixedName

    /// <summary>
    ///   <para>stac:WimaxSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wimax SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#WimaxSecurityMechanism">http://securitytoolbox.appspot.com/stac#WimaxSecurityMechanism</seealso>
    let WimaxSecurityMechanism =
        Prefixed_Name(stac, "WimaxSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:ZigbeeSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Zigbee SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ZigbeeSecurityMechanism">http://securitytoolbox.appspot.com/stac#ZigbeeSecurityMechanism</seealso>
    let ZigbeeSecurityMechanism =
        Prefixed_Name(stac, "ZigbeeSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:EDGEAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>EDGE Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#EDGEAttack">http://securitytoolbox.appspot.com/stac#EDGEAttack</seealso>
    let EDGEAttack = Prefixed_Name(stac, "EDGEAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:isProtectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>isProtectedBy</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#isProtectedBy">http://securitytoolbox.appspot.com/stac#isProtectedBy</seealso>
    let isProtectedBy = Prefixed_Name(stac, "isProtectedBy") |> PrefixedName
    /// <summary>
    ///   <para>stac:satisfies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A security mechanism (e.g., VPN) satisfies some security properties (e.g., authentication)</para>
    /// labels<para>satisfies</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#satisfies">http://securitytoolbox.appspot.com/stac#satisfies</seealso>
    let satisfies = Prefixed_Name(stac, "satisfies") |> PrefixedName
    /// <summary>
    ///   <para>stac:isReplacedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>When a SecurityMechanism is not secured anymore, it is replaced by a more secure SecurityMechanism. This is also the case for technologies: a technology can be replaced by another one more recent. (E.G., 2G has been replaced by 3G)</para>
    /// labels<para>isReplacedBy</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#isReplacedBy">http://securitytoolbox.appspot.com/stac#isReplacedBy</seealso>
    let isReplacedBy = Prefixed_Name(stac, "isReplacedBy") |> PrefixedName
    /// <summary>
    ///   <para>stac:EthernetAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ethernet Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#EthernetAttack">http://securitytoolbox.appspot.com/stac#EthernetAttack</seealso>
    let EthernetAttack = Prefixed_Name(stac, "EthernetAttack") |> PrefixedName

    /// <summary>
    ///   <para>stac:EthernetSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ethernet SecurityMechanism</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#EthernetSecurityMechanism">http://securitytoolbox.appspot.com/stac#EthernetSecurityMechanism</seealso>
    let EthernetSecurityMechanism =
        Prefixed_Name(stac, "EthernetSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>stac:EthernetTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ethernet</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#EthernetTechnology">http://securitytoolbox.appspot.com/stac#EthernetTechnology</seealso>
    let EthernetTechnology = Prefixed_Name(stac, "EthernetTechnology") |> PrefixedName
    /// <summary>
    ///   <para>stac:LowCost</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#LowCost">http://securitytoolbox.appspot.com/stac#LowCost</seealso>
    let LowCost = Prefixed_Name(stac, "LowCost") |> PrefixedName
    /// <summary>
    ///   <para>stac:isFeatureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Features are related to security mechanisms. For example, an asymmetric algorithm is high energy consuming.</para>
    /// labels<para>isFeatureOf</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#isFeatureOf">http://securitytoolbox.appspot.com/stac#isFeatureOf</seealso>
    let isFeatureOf = Prefixed_Name(stac, "isFeatureOf") |> PrefixedName
    /// <summary>
    ///   <para>stac:HighCostDeployment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#HighCostDeployment">http://securitytoolbox.appspot.com/stac#HighCostDeployment</seealso>
    let HighCostDeployment = Prefixed_Name(stac, "HighCostDeployment") |> PrefixedName
    /// <summary>
    ///   <para>stac:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Features of security mechanisms. For example a sensor technology is low energy consuming, and the symmetric algorithm (a SecurityMechanism) is low energy consumming.</para>
    /// labels<para>Feature</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Feature">http://securitytoolbox.appspot.com/stac#Feature</seealso>
    let Feature = Prefixed_Name(stac, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>stac:ApplicationLayer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#ApplicationLayer">http://securitytoolbox.appspot.com/stac#ApplicationLayer</seealso>
    let ApplicationLayer = Prefixed_Name(stac, "ApplicationLayer") |> PrefixedName
    /// <summary>
    ///   <para>stac:Flooding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Floodings attacks generally are used to drain the memry resources by sensing the control signals.</para>
    /// labels<para>Flooding</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#Flooding">http://securitytoolbox.appspot.com/stac#Flooding</seealso>
    let Flooding = Prefixed_Name(stac, "Flooding") |> PrefixedName
    /// <summary>
    ///   <para>stac:TransportLayer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#TransportLayer">http://securitytoolbox.appspot.com/stac#TransportLayer</seealso>
    let TransportLayer = Prefixed_Name(stac, "TransportLayer") |> PrefixedName
    /// <summary>
    ///   <para>stac:SensorAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sensor Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#SensorAttack">http://securitytoolbox.appspot.com/stac#SensorAttack</seealso>
    let SensorAttack = Prefixed_Name(stac, "SensorAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:FrameworkAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Framework Attack</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#FrameworkAttack">http://securitytoolbox.appspot.com/stac#FrameworkAttack</seealso>
    let FrameworkAttack = Prefixed_Name(stac, "FrameworkAttack") |> PrefixedName
    /// <summary>
    ///   <para>stac:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para></para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/stac#">http://securitytoolbox.appspot.com/stac#</seealso>
    let _prefix_iri = Prefixed_Name(stac, "") |> PrefixedName
