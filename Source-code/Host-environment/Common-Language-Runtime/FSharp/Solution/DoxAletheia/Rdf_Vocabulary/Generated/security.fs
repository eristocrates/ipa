namespace http.securitytoolbox.appspot.com.securityMain.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module security =
    let _namespace_iri = Namespace_Iri security |> NamespaceIRI
    /// <summary>
    ///   <para>security:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>"A security ontology to annotate resources with security-related information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#">http://securitytoolbox.appspot.com/securityMain#</seealso>
    let _prefix_iri = Prefixed_Name(security, "") |> PrefixedName
    /// <summary>
    ///   <para>security:Anonymity</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// (Secondary Objective) Provides anonymity
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#Anonymity">http://securitytoolbox.appspot.com/securityMain#Anonymity</seealso>
    let Anonymity = Prefixed_Name(security, "Anonymity") |> PrefixedName

    /// <summary>
    ///   <para>security:ApplicationMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Application Mechanism"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#ApplicationMechanism">http://securitytoolbox.appspot.com/securityMain#ApplicationMechanism</seealso>
    let ApplicationMechanism =
        Prefixed_Name(security, "ApplicationMechanism") |> PrefixedName

    /// <summary>
    ///   <para>security:AuthenticationProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Authentication Protocol"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#AuthenticationProtocol">http://securitytoolbox.appspot.com/securityMain#AuthenticationProtocol</seealso>
    let AuthenticationProtocol =
        Prefixed_Name(security, "AuthenticationProtocol") |> PrefixedName

    /// <summary>
    ///   <para>security:Authorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// Only authorized entities are allowed to access resources in an authorized
    /// manner.
    /// (Aka Access Control). If desired, user may create instance of AccessControl as
    /// well.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#Authorization">http://securitytoolbox.appspot.com/securityMain#Authorization</seealso>
    let Authorization = Prefixed_Name(security, "Authorization") |> PrefixedName
    /// <summary>
    ///   <para>security:Availability</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// Provides guarantee that resource is available to authorized users at any
    /// authorized time.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#Availability">http://securitytoolbox.appspot.com/securityMain#Availability</seealso>
    let Availability = Prefixed_Name(security, "Availability") |> PrefixedName
    /// <summary>
    ///   <para>security:BLP</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:MilitaryPolicy</para>
    ///   <para>"
    /// Bell La-Padula
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#BLP">http://securitytoolbox.appspot.com/securityMain#BLP</seealso>
    let BLP = Prefixed_Name(security, "BLP") |> PrefixedName
    /// <summary>
    ///   <para>security:ChineseWall</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:CommercialPolicy</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#ChineseWall">http://securitytoolbox.appspot.com/securityMain#ChineseWall</seealso>
    let ChineseWall = Prefixed_Name(security, "ChineseWall") |> PrefixedName
    /// <summary>
    ///   <para>security:ClarkWilson</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:CommercialPolicy</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#ClarkWilson">http://securitytoolbox.appspot.com/securityMain#ClarkWilson</seealso>
    let ClarkWilson = Prefixed_Name(security, "ClarkWilson") |> PrefixedName
    /// <summary>
    ///   <para>security:CommercialPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Commercial Policy"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#CommercialPolicy">http://securitytoolbox.appspot.com/securityMain#CommercialPolicy</seealso>
    let CommercialPolicy = Prefixed_Name(security, "CommercialPolicy") |> PrefixedName
    /// <summary>
    ///   <para>security:Confidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// Protects against information being disclosed or revealed to unauthorized
    /// parties.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#Confidentiality">http://securitytoolbox.appspot.com/securityMain#Confidentiality</seealso>
    let Confidentiality = Prefixed_Name(security, "Confidentiality") |> PrefixedName

    /// <summary>
    ///   <para>security:CovertChannelPrevention</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// (Secondary Objective) Prevent or limit the existance of covert channels
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#CovertChannelPrevention">http://securitytoolbox.appspot.com/securityMain#CovertChannelPrevention</seealso>
    let CovertChannelPrevention =
        Prefixed_Name(security, "CovertChannelPrevention") |> PrefixedName

    /// <summary>
    ///   <para>security:EncryptionProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Encryption Protocol"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#EncryptionProtocol">http://securitytoolbox.appspot.com/securityMain#EncryptionProtocol</seealso>
    let EncryptionProtocol =
        Prefixed_Name(security, "EncryptionProtocol") |> PrefixedName

    /// <summary>
    ///   <para>security:HostMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Host Mechanism"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#HostMechanism">http://securitytoolbox.appspot.com/securityMain#HostMechanism</seealso>
    let HostMechanism = Prefixed_Name(security, "HostMechanism") |> PrefixedName
    /// <summary>
    ///   <para>security:HostTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// (Secondary Objective) How to trust host or platform. Is relevant to Common
    /// criteria, etc.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#HostTrust">http://securitytoolbox.appspot.com/securityMain#HostTrust</seealso>
    let HostTrust = Prefixed_Name(security, "HostTrust") |> PrefixedName
    /// <summary>
    ///   <para>security:IPSec</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:NetworkSecurityProtocol</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#IPSec">http://securitytoolbox.appspot.com/securityMain#IPSec</seealso>
    let IPSec = Prefixed_Name(security, "IPSec") |> PrefixedName
    /// <summary>
    ///   <para>security:Integrity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#Integrity">http://securitytoolbox.appspot.com/securityMain#Integrity</seealso>
    let Integrity = Prefixed_Name(security, "Integrity") |> PrefixedName
    /// <summary>
    ///   <para>security:Kerberos</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:AuthenticationProtocol</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#Kerberos">http://securitytoolbox.appspot.com/securityMain#Kerberos</seealso>
    let Kerberos = Prefixed_Name(security, "Kerberos") |> PrefixedName
    /// <summary>
    ///   <para>security:KeyManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// (SecondaryObjective) Securely manages keys for legitimate users.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#KeyManagement">http://securitytoolbox.appspot.com/securityMain#KeyManagement</seealso>
    let KeyManagement = Prefixed_Name(security, "KeyManagement") |> PrefixedName

    /// <summary>
    ///   <para>security:KeyManagementProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Key Management Protocol"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#KeyManagementProtocol">http://securitytoolbox.appspot.com/securityMain#KeyManagementProtocol</seealso>
    let KeyManagementProtocol =
        Prefixed_Name(security, "KeyManagementProtocol") |> PrefixedName

    /// <summary>
    ///   <para>security:LoginProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:AuthenticationProtocol</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#LoginProtocol">http://securitytoolbox.appspot.com/securityMain#LoginProtocol</seealso>
    let LoginProtocol = Prefixed_Name(security, "LoginProtocol") |> PrefixedName
    /// <summary>
    ///   <para>security:MLSPump</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:NetworkMechanism</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#MLSPump">http://securitytoolbox.appspot.com/securityMain#MLSPump</seealso>
    let MLSPump = Prefixed_Name(security, "MLSPump") |> PrefixedName

    /// <summary>
    ///   <para>security:MessageAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// Provides guarantee that message came from whoever claimed to have sent it.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#MessageAuthentication">http://securitytoolbox.appspot.com/securityMain#MessageAuthentication</seealso>
    let MessageAuthentication =
        Prefixed_Name(security, "MessageAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>security:MessageIntegrity</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// Data integrity or Message integrity; data cannot be changed, deleted,
    /// modified, etc by unauthorized parties.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#MessageIntegrity">http://securitytoolbox.appspot.com/securityMain#MessageIntegrity</seealso>
    let MessageIntegrity = Prefixed_Name(security, "MessageIntegrity") |> PrefixedName
    /// <summary>
    ///   <para>security:MilitaryPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Military Policy"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#MilitaryPolicy">http://securitytoolbox.appspot.com/securityMain#MilitaryPolicy</seealso>
    let MilitaryPolicy = Prefixed_Name(security, "MilitaryPolicy") |> PrefixedName
    /// <summary>
    ///   <para>security:NetworkMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Network Mechanism"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#NetworkMechanism">http://securitytoolbox.appspot.com/securityMain#NetworkMechanism</seealso>
    let NetworkMechanism = Prefixed_Name(security, "NetworkMechanism") |> PrefixedName

    /// <summary>
    ///   <para>security:NetworkSecurityProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Network Security Protocol"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#NetworkSecurityProtocol">http://securitytoolbox.appspot.com/securityMain#NetworkSecurityProtocol</seealso>
    let NetworkSecurityProtocol =
        Prefixed_Name(security, "NetworkSecurityProtocol") |> PrefixedName

    /// <summary>
    ///   <para>security:OnionRouter</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:NetworkMechanism</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#OnionRouter">http://securitytoolbox.appspot.com/securityMain#OnionRouter</seealso>
    let OnionRouter = Prefixed_Name(security, "OnionRouter") |> PrefixedName
    /// <summary>
    ///   <para>security:RBAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityPolicy</para>
    ///   <para>"
    /// Role-based Access Control
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#RBAC">http://securitytoolbox.appspot.com/securityMain#RBAC</seealso>
    let RBAC = Prefixed_Name(security, "RBAC") |> PrefixedName
    /// <summary>
    ///   <para>security:ReplayPrevention</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// (Secondary Objective) Protect against replay attacks
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#ReplayPrevention">http://securitytoolbox.appspot.com/securityMain#ReplayPrevention</seealso>
    let ReplayPrevention = Prefixed_Name(security, "ReplayPrevention") |> PrefixedName
    /// <summary>
    ///   <para>security:SAML</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:AuthenticationProtocol</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#SAML">http://securitytoolbox.appspot.com/securityMain#SAML</seealso>
    let SAML = Prefixed_Name(security, "SAML") |> PrefixedName
    /// <summary>
    ///   <para>security:SSH</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:NetworkSecurityProtocol</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#SSH">http://securitytoolbox.appspot.com/securityMain#SSH</seealso>
    let SSH = Prefixed_Name(security, "SSH") |> PrefixedName
    /// <summary>
    ///   <para>security:SSL</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:NetworkSecurityProtocol</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#SSL">http://securitytoolbox.appspot.com/securityMain#SSL</seealso>
    let SSL = Prefixed_Name(security, "SSL") |> PrefixedName
    /// <summary>
    ///   <para>security:Safehost</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:HostMechanism</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#Safehost">http://securitytoolbox.appspot.com/securityMain#Safehost</seealso>
    let Safehost = Prefixed_Name(security, "Safehost") |> PrefixedName
    /// <summary>
    ///   <para>security:SecurityConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Security Concept"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#SecurityConcept">http://securitytoolbox.appspot.com/securityMain#SecurityConcept</seealso>
    let SecurityConcept = Prefixed_Name(security, "SecurityConcept") |> PrefixedName
    /// <summary>
    ///   <para>security:SecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Security Mechanism"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#SecurityMechanism">http://securitytoolbox.appspot.com/securityMain#SecurityMechanism</seealso>
    let SecurityMechanism = Prefixed_Name(security, "SecurityMechanism") |> PrefixedName
    /// <summary>
    ///   <para>security:SecurityObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Security Objective"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#SecurityObjective">http://securitytoolbox.appspot.com/securityMain#SecurityObjective</seealso>
    let SecurityObjective = Prefixed_Name(security, "SecurityObjective") |> PrefixedName
    /// <summary>
    ///   <para>security:SecurityPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Security Policy"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#SecurityPolicy">http://securitytoolbox.appspot.com/securityMain#SecurityPolicy</seealso>
    let SecurityPolicy = Prefixed_Name(security, "SecurityPolicy") |> PrefixedName
    /// <summary>
    ///   <para>security:SecurityProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Security Protocol"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#SecurityProtocol">http://securitytoolbox.appspot.com/securityMain#SecurityProtocol</seealso>
    let SecurityProtocol = Prefixed_Name(security, "SecurityProtocol") |> PrefixedName
    /// <summary>
    ///   <para>security:Separation</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// (Secondary Objective)
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#Separation">http://securitytoolbox.appspot.com/securityMain#Separation</seealso>
    let Separation = Prefixed_Name(security, "Separation") |> PrefixedName
    /// <summary>
    ///   <para>security:ServiceMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Service Mechanism"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#ServiceMechanism">http://securitytoolbox.appspot.com/securityMain#ServiceMechanism</seealso>
    let ServiceMechanism = Prefixed_Name(security, "ServiceMechanism") |> PrefixedName
    /// <summary>
    ///   <para>security:SignatureProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Signature Protocol"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#SignatureProtocol">http://securitytoolbox.appspot.com/securityMain#SignatureProtocol</seealso>
    let SignatureProtocol = Prefixed_Name(security, "SignatureProtocol") |> PrefixedName
    /// <summary>
    ///   <para>security:SoapFirewall</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:ServiceMechanism</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#SoapFirewall">http://securitytoolbox.appspot.com/securityMain#SoapFirewall</seealso>
    let SoapFirewall = Prefixed_Name(security, "SoapFirewall") |> PrefixedName
    /// <summary>
    ///   <para>security:TLS</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:NetworkSecurityProtocol</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#TLS">http://securitytoolbox.appspot.com/securityMain#TLS</seealso>
    let TLS = Prefixed_Name(security, "TLS") |> PrefixedName
    /// <summary>
    ///   <para>security:TrafficHiding</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// (Secondary Objective) Pad traffic with bogus data to hide traffic patterns
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#TrafficHiding">http://securitytoolbox.appspot.com/securityMain#TrafficHiding</seealso>
    let TrafficHiding = Prefixed_Name(security, "TrafficHiding") |> PrefixedName
    /// <summary>
    ///   <para>security:Trust</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// (Secondary Objective) How to trust entity. Trust not only of identification,
    /// but statements, claims, etc.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#Trust">http://securitytoolbox.appspot.com/securityMain#Trust</seealso>
    let Trust = Prefixed_Name(security, "Trust") |> PrefixedName

    /// <summary>
    ///   <para>security:UserAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SecurityObjective</para>
    ///   <para>"
    /// Provides assurance of the identity of a person or entity.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#UserAuthentication">http://securitytoolbox.appspot.com/securityMain#UserAuthentication</seealso>
    let UserAuthentication =
        Prefixed_Name(security, "UserAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>security:VMM</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:HostMechanism</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#VMM">http://securitytoolbox.appspot.com/securityMain#VMM</seealso>
    let VMM = Prefixed_Name(security, "VMM") |> PrefixedName
    /// <summary>
    ///   <para>security:VPN</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:NetworkMechanism</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#VPN">http://securitytoolbox.appspot.com/securityMain#VPN</seealso>
    let VPN = Prefixed_Name(security, "VPN") |> PrefixedName
    /// <summary>
    ///   <para>security:XKMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:KeyManagementProtocol</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#XKMS">http://securitytoolbox.appspot.com/securityMain#XKMS</seealso>
    let XKMS = Prefixed_Name(security, "XKMS") |> PrefixedName
    /// <summary>
    ///   <para>security:XML-dsig</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:SignatureProtocol</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#XML-dsig">http://securitytoolbox.appspot.com/securityMain#XML-dsig</seealso>
    let XML_dsig = Prefixed_Name(security, "XML-dsig") |> PrefixedName
    /// <summary>
    ///   <para>security:XML-enc</para>
    /// </summary>
    /// <remarks>
    ///   <para>security:EncryptionProtocol</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#XML-enc">http://securitytoolbox.appspot.com/securityMain#XML-enc</seealso>
    let XML_enc = Prefixed_Name(security, "XML-enc") |> PrefixedName
    /// <summary>
    ///   <para>security:hasAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAlgorithm"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#hasAlgorithm">http://securitytoolbox.appspot.com/securityMain#hasAlgorithm</seealso>
    let hasAlgorithm = Prefixed_Name(security, "hasAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>security:hasAssurance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hasAssurance"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#hasAssurance">http://securitytoolbox.appspot.com/securityMain#hasAssurance</seealso>
    let hasAssurance = Prefixed_Name(security, "hasAssurance") |> PrefixedName

    /// <summary>
    ///   <para>security:hasEncryptionAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasEncryptionAlgorithm"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#hasEncryptionAlgorithm">http://securitytoolbox.appspot.com/securityMain#hasEncryptionAlgorithm</seealso>
    let hasEncryptionAlgorithm =
        Prefixed_Name(security, "hasEncryptionAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>security:hasSignatureAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSignatureAlgorithm"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#hasSignatureAlgorithm">http://securitytoolbox.appspot.com/securityMain#hasSignatureAlgorithm</seealso>
    let hasSignatureAlgorithm =
        Prefixed_Name(security, "hasSignatureAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>security:reqCredential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"reqCredential"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#reqCredential">http://securitytoolbox.appspot.com/securityMain#reqCredential</seealso>
    let reqCredential = Prefixed_Name(security, "reqCredential") |> PrefixedName

    /// <summary>
    ///   <para>security:supportsSecurityObjectives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    /// Any SecurityConcept can support one or more of the Security Objectives defined
    /// in the SecurityObjective class
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"supports Security Objectives"</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/securityMain#supportsSecurityObjectives">http://securitytoolbox.appspot.com/securityMain#supportsSecurityObjectives</seealso>
    let supportsSecurityObjectives =
        Prefixed_Name(security, "supportsSecurityObjectives") |> PrefixedName
