#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module security =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://securitytoolbox.appspot.com/securityMain#" "security"

    let _namespaceIri = _prefixId.prefix ""
    let Anonymity = _prefixId.prefix "Anonymity"
    /// <summary>
    ///   <para>rdfs:label : Application Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#ApplicationMechanism">security:ApplicationMechanism</a>
    /// </summary>
    let ApplicationMechanism = _prefixId.prefix "ApplicationMechanism"
    /// <summary>
    ///   <para>rdfs:label : Authentication Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#AuthenticationProtocol">security:AuthenticationProtocol</a>
    /// </summary>
    let AuthenticationProtocol = _prefixId.prefix "AuthenticationProtocol"
    let Authorization = _prefixId.prefix "Authorization"
    let Availability = _prefixId.prefix "Availability"
    let BLP = _prefixId.prefix "BLP"
    let ChineseWall = _prefixId.prefix "ChineseWall"
    let ClarkWilson = _prefixId.prefix "ClarkWilson"
    /// <summary>
    ///   <para>rdfs:label : Commercial Policy</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#CommercialPolicy">security:CommercialPolicy</a>
    /// </summary>
    let CommercialPolicy = _prefixId.prefix "CommercialPolicy"
    let Confidentiality = _prefixId.prefix "Confidentiality"
    let CovertChannelPrevention = _prefixId.prefix "CovertChannelPrevention"
    /// <summary>
    ///   <para>rdfs:label : Encryption Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#EncryptionProtocol">security:EncryptionProtocol</a>
    /// </summary>
    let EncryptionProtocol = _prefixId.prefix "EncryptionProtocol"
    /// <summary>
    ///   <para>rdfs:label : Host Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#HostMechanism">security:HostMechanism</a>
    /// </summary>
    let HostMechanism = _prefixId.prefix "HostMechanism"
    let HostTrust = _prefixId.prefix "HostTrust"
    let IPSec = _prefixId.prefix "IPSec"
    let Integrity = _prefixId.prefix "Integrity"
    let Kerberos = _prefixId.prefix "Kerberos"
    let KeyManagement = _prefixId.prefix "KeyManagement"
    /// <summary>
    ///   <para>rdfs:label : Key Management Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#KeyManagementProtocol">security:KeyManagementProtocol</a>
    /// </summary>
    let KeyManagementProtocol = _prefixId.prefix "KeyManagementProtocol"
    let LoginProtocol = _prefixId.prefix "LoginProtocol"
    let MLSPump = _prefixId.prefix "MLSPump"
    let MessageAuthentication = _prefixId.prefix "MessageAuthentication"
    let MessageIntegrity = _prefixId.prefix "MessageIntegrity"
    /// <summary>
    ///   <para>rdfs:label : Military Policy</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#MilitaryPolicy">security:MilitaryPolicy</a>
    /// </summary>
    let MilitaryPolicy = _prefixId.prefix "MilitaryPolicy"
    /// <summary>
    ///   <para>rdfs:label : Network Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#NetworkMechanism">security:NetworkMechanism</a>
    /// </summary>
    let NetworkMechanism = _prefixId.prefix "NetworkMechanism"
    /// <summary>
    ///   <para>rdfs:label : Network Security Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#NetworkSecurityProtocol">security:NetworkSecurityProtocol</a>
    /// </summary>
    let NetworkSecurityProtocol = _prefixId.prefix "NetworkSecurityProtocol"
    let OnionRouter = _prefixId.prefix "OnionRouter"
    let RBAC = _prefixId.prefix "RBAC"
    let ReplayPrevention = _prefixId.prefix "ReplayPrevention"
    let SAML = _prefixId.prefix "SAML"
    let SSH = _prefixId.prefix "SSH"
    let SSL = _prefixId.prefix "SSL"
    let Safehost = _prefixId.prefix "Safehost"
    /// <summary>
    ///   <para>rdfs:label : Security Concept</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#SecurityConcept">security:SecurityConcept</a>
    /// </summary>
    let SecurityConcept = _prefixId.prefix "SecurityConcept"
    /// <summary>
    ///   <para>rdfs:label : Security Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#SecurityMechanism">security:SecurityMechanism</a>
    /// </summary>
    let SecurityMechanism = _prefixId.prefix "SecurityMechanism"
    /// <summary>
    ///   <para>rdfs:label : Security Objective</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#SecurityObjective">security:SecurityObjective</a>
    /// </summary>
    let SecurityObjective = _prefixId.prefix "SecurityObjective"
    /// <summary>
    ///   <para>rdfs:label : Security Policy</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#SecurityPolicy">security:SecurityPolicy</a>
    /// </summary>
    let SecurityPolicy = _prefixId.prefix "SecurityPolicy"
    /// <summary>
    ///   <para>rdfs:label : Security Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#SecurityProtocol">security:SecurityProtocol</a>
    /// </summary>
    let SecurityProtocol = _prefixId.prefix "SecurityProtocol"
    let Separation = _prefixId.prefix "Separation"
    /// <summary>
    ///   <para>rdfs:label : Service Mechanism</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#ServiceMechanism">security:ServiceMechanism</a>
    /// </summary>
    let ServiceMechanism = _prefixId.prefix "ServiceMechanism"
    /// <summary>
    ///   <para>rdfs:label : Signature Protocol</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#SignatureProtocol">security:SignatureProtocol</a>
    /// </summary>
    let SignatureProtocol = _prefixId.prefix "SignatureProtocol"
    let SoapFirewall = _prefixId.prefix "SoapFirewall"
    let TLS = _prefixId.prefix "TLS"
    let TrafficHiding = _prefixId.prefix "TrafficHiding"
    let Trust = _prefixId.prefix "Trust"
    let UserAuthentication = _prefixId.prefix "UserAuthentication"
    let VMM = _prefixId.prefix "VMM"
    let VPN = _prefixId.prefix "VPN"
    let XKMS = _prefixId.prefix "XKMS"
    let XML_dsig = _prefixId.prefix "XML-dsig"
    let XML_enc = _prefixId.prefix "XML-enc"
    /// <summary>
    ///   <para>rdfs:label : hasAlgorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#hasAlgorithm">security:hasAlgorithm</a>
    /// </summary>
    let hasAlgorithm = _prefixId.prefix "hasAlgorithm"
    /// <summary>
    ///   <para>rdfs:label : hasAssurance</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#hasAssurance">security:hasAssurance</a>
    /// </summary>
    let hasAssurance = _prefixId.prefix "hasAssurance"
    /// <summary>
    ///   <para>rdfs:label : hasEncryptionAlgorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#hasEncryptionAlgorithm">security:hasEncryptionAlgorithm</a>
    /// </summary>
    let hasEncryptionAlgorithm = _prefixId.prefix "hasEncryptionAlgorithm"
    /// <summary>
    ///   <para>rdfs:label : hasSignatureAlgorithm</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#hasSignatureAlgorithm">security:hasSignatureAlgorithm</a>
    /// </summary>
    let hasSignatureAlgorithm = _prefixId.prefix "hasSignatureAlgorithm"
    /// <summary>
    ///   <para>rdfs:label : reqCredential</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#reqCredential">security:reqCredential</a>
    /// </summary>
    let reqCredential = _prefixId.prefix "reqCredential"
    /// <summary>
    ///   <para>rdfs:comment :
    /// Any SecurityConcept can support one or more of the Security Objectives defined
    /// in the SecurityObjective class
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : supports Security Objectives</para>
    ///   <a href="http://securitytoolbox.appspot.com/securityMain#supportsSecurityObjectives">security:supportsSecurityObjectives</a>
    /// </summary>
    let supportsSecurityObjectives = _prefixId.prefix "supportsSecurityObjectives"
