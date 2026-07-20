namespace http.securitytoolbox.appspot.com.securityMain.hash

open DoxAletheia

module security =
    let _namespace_name = "http://securitytoolbox.appspot.com/securityMain#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    /// (Secondary Objective) Provides anonymity
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Anonymity"></see></summary>
    let Anonymity = _prefix "Anonymity"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SecurityObjective"></see>
    /// </summary>
    let SecurityObjective = _prefix "SecurityObjective"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#ApplicationMechanism"></see>
    /// </summary>
    let ApplicationMechanism = _prefix "ApplicationMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SecurityMechanism"></see>
    /// </summary>
    let SecurityMechanism = _prefix "SecurityMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#AuthenticationProtocol"></see>
    /// </summary>
    let AuthenticationProtocol = _prefix "AuthenticationProtocol"
    /// <summary>
    ///
    /// Provides assurance of the identity of a person or entity.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#UserAuthentication"></see></summary>
    let UserAuthentication = _prefix "UserAuthentication"
    /// <summary>
    ///
    /// Any SecurityConcept can support one or more of the Security Objectives defined
    /// in the SecurityObjective class
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#supportsSecurityObjectives"></see></summary>
    let supportsSecurityObjectives = _prefix "supportsSecurityObjectives"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SecurityProtocol"></see>
    /// </summary>
    let SecurityProtocol = _prefix "SecurityProtocol"
    /// <summary>
    ///
    /// Only authorized entities are allowed to access resources in an authorized
    /// manner.
    /// (Aka Access Control). If desired, user may create instance of AccessControl as
    /// well.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Authorization"></see></summary>
    let Authorization = _prefix "Authorization"
    /// <summary>
    ///
    /// Provides guarantee that resource is available to authorized users at any
    /// authorized time.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Availability"></see></summary>
    let Availability = _prefix "Availability"
    /// <summary>
    ///
    /// Bell La-Padula
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#BLP"></see></summary>
    let BLP = _prefix "BLP"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#MilitaryPolicy"></see>
    /// </summary>
    let MilitaryPolicy = _prefix "MilitaryPolicy"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#ChineseWall"></see>
    /// </summary>
    let ChineseWall = _prefix "ChineseWall"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#CommercialPolicy"></see>
    /// </summary>
    let CommercialPolicy = _prefix "CommercialPolicy"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#ClarkWilson"></see>
    /// </summary>
    let ClarkWilson = _prefix "ClarkWilson"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SecurityPolicy"></see>
    /// </summary>
    let SecurityPolicy = _prefix "SecurityPolicy"
    /// <summary>
    ///
    /// Protects against information being disclosed or revealed to unauthorized
    /// parties.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Confidentiality"></see></summary>
    let Confidentiality = _prefix "Confidentiality"
    /// <summary>
    ///
    /// (Secondary Objective) Prevent or limit the existance of covert channels
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#CovertChannelPrevention"></see></summary>
    let CovertChannelPrevention = _prefix "CovertChannelPrevention"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#EncryptionProtocol"></see>
    /// </summary>
    let EncryptionProtocol = _prefix "EncryptionProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#HostMechanism"></see>
    /// </summary>
    let HostMechanism = _prefix "HostMechanism"
    /// <summary>
    ///
    /// (Secondary Objective) How to trust host or platform. Is relevant to Common
    /// criteria, etc.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#HostTrust"></see></summary>
    let HostTrust = _prefix "HostTrust"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#IPSec"></see>
    /// </summary>
    let IPSec = _prefix "IPSec"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#Integrity"></see>
    /// </summary>
    let Integrity = _prefix "Integrity"
    /// <summary>
    ///
    /// Provides guarantee that message came from whoever claimed to have sent it.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#MessageAuthentication"></see></summary>
    let MessageAuthentication = _prefix "MessageAuthentication"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#NetworkSecurityProtocol"></see>
    /// </summary>
    let NetworkSecurityProtocol = _prefix "NetworkSecurityProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#Kerberos"></see>
    /// </summary>
    let Kerberos = _prefix "Kerberos"
    /// <summary>
    ///
    /// (SecondaryObjective) Securely manages keys for legitimate users.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#KeyManagement"></see></summary>
    let KeyManagement = _prefix "KeyManagement"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#KeyManagementProtocol"></see>
    /// </summary>
    let KeyManagementProtocol = _prefix "KeyManagementProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#LoginProtocol"></see>
    /// </summary>
    let LoginProtocol = _prefix "LoginProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#MLSPump"></see>
    /// </summary>
    let MLSPump = _prefix "MLSPump"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#NetworkMechanism"></see>
    /// </summary>
    let NetworkMechanism = _prefix "NetworkMechanism"
    /// <summary>
    ///
    /// Data integrity or Message integrity; data cannot be changed, deleted,
    /// modified, etc by unauthorized parties.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#MessageIntegrity"></see></summary>
    let MessageIntegrity = _prefix "MessageIntegrity"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#OnionRouter"></see>
    /// </summary>
    let OnionRouter = _prefix "OnionRouter"
    /// <summary>
    ///
    /// Role-based Access Control
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#RBAC"></see></summary>
    let RBAC = _prefix "RBAC"
    /// <summary>
    ///
    /// (Secondary Objective) Protect against replay attacks
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#ReplayPrevention"></see></summary>
    let ReplayPrevention = _prefix "ReplayPrevention"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SAML"></see>
    /// </summary>
    let SAML = _prefix "SAML"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SSH"></see>
    /// </summary>
    let SSH = _prefix "SSH"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SSL"></see>
    /// </summary>
    let SSL = _prefix "SSL"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#TLS"></see>
    /// </summary>
    let TLS = _prefix "TLS"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#Safehost"></see>
    /// </summary>
    let Safehost = _prefix "Safehost"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SecurityConcept"></see>
    /// </summary>
    let SecurityConcept = _prefix "SecurityConcept"
    /// <summary>
    ///
    /// (Secondary Objective)
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Separation"></see></summary>
    let Separation = _prefix "Separation"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#ServiceMechanism"></see>
    /// </summary>
    let ServiceMechanism = _prefix "ServiceMechanism"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SignatureProtocol"></see>
    /// </summary>
    let SignatureProtocol = _prefix "SignatureProtocol"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SoapFirewall"></see>
    /// </summary>
    let SoapFirewall = _prefix "SoapFirewall"
    /// <summary>
    ///
    /// (Secondary Objective) Pad traffic with bogus data to hide traffic patterns
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#TrafficHiding"></see></summary>
    let TrafficHiding = _prefix "TrafficHiding"
    /// <summary>
    ///
    /// (Secondary Objective) How to trust entity. Trust not only of identification,
    /// but statements, claims, etc.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Trust"></see></summary>
    let Trust = _prefix "Trust"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#VMM"></see>
    /// </summary>
    let VMM = _prefix "VMM"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#VPN"></see>
    /// </summary>
    let VPN = _prefix "VPN"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#XKMS"></see>
    /// </summary>
    let XKMS = _prefix "XKMS"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#XML-dsig"></see>
    /// </summary>
    let ``XML-dsig`` = _prefix "XML-dsig"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#XML-enc"></see>
    /// </summary>
    let ``XML-enc`` = _prefix "XML-enc"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#hasAlgorithm"></see>
    /// </summary>
    let hasAlgorithm = _prefix "hasAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#hasAssurance"></see>
    /// </summary>
    let hasAssurance = _prefix "hasAssurance"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#hasEncryptionAlgorithm"></see>
    /// </summary>
    let hasEncryptionAlgorithm = _prefix "hasEncryptionAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#hasSignatureAlgorithm"></see>
    /// </summary>
    let hasSignatureAlgorithm = _prefix "hasSignatureAlgorithm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#reqCredential"></see>
    /// </summary>
    let reqCredential = _prefix "reqCredential"
