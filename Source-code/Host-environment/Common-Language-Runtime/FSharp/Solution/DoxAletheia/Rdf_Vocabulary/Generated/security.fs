namespace http.securitytoolbox.appspot.com.securityMain.hash

open DoxAletheia.Rdf_Vocabulary

module security =
    let _namespace_name = "http://securitytoolbox.appspot.com/securityMain#"
    /// <summary>
    ///
    /// (Secondary Objective) Provides anonymity
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Anonymity"></see></summary>
    let Anonymity = Namespaced_IRI.parse _namespace_name "Anonymity" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SecurityObjective"></see>
    /// </summary>
    let SecurityObjective =
        Namespaced_IRI.parse _namespace_name "SecurityObjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#ApplicationMechanism"></see>
    /// </summary>
    let ApplicationMechanism =
        Namespaced_IRI.parse _namespace_name "ApplicationMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SecurityMechanism"></see>
    /// </summary>
    let SecurityMechanism =
        Namespaced_IRI.parse _namespace_name "SecurityMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#AuthenticationProtocol"></see>
    /// </summary>
    let AuthenticationProtocol =
        Namespaced_IRI.parse _namespace_name "AuthenticationProtocol" |> NamespacedName

    /// <summary>
    ///
    /// Provides assurance of the identity of a person or entity.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#UserAuthentication"></see></summary>
    let UserAuthentication =
        Namespaced_IRI.parse _namespace_name "UserAuthentication" |> NamespacedName

    /// <summary>
    ///
    /// Any SecurityConcept can support one or more of the Security Objectives defined
    /// in the SecurityObjective class
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#supportsSecurityObjectives"></see></summary>
    let supportsSecurityObjectives =
        Namespaced_IRI.parse _namespace_name "supportsSecurityObjectives" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SecurityProtocol"></see>
    /// </summary>
    let SecurityProtocol =
        Namespaced_IRI.parse _namespace_name "SecurityProtocol" |> NamespacedName

    /// <summary>
    ///
    /// Only authorized entities are allowed to access resources in an authorized
    /// manner.
    /// (Aka Access Control). If desired, user may create instance of AccessControl as
    /// well.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Authorization"></see></summary>
    let Authorization =
        Namespaced_IRI.parse _namespace_name "Authorization" |> NamespacedName

    /// <summary>
    ///
    /// Provides guarantee that resource is available to authorized users at any
    /// authorized time.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Availability"></see></summary>
    let Availability =
        Namespaced_IRI.parse _namespace_name "Availability" |> NamespacedName

    /// <summary>
    ///
    /// Bell La-Padula
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#BLP"></see></summary>
    let BLP = Namespaced_IRI.parse _namespace_name "BLP" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#MilitaryPolicy"></see>
    /// </summary>
    let MilitaryPolicy =
        Namespaced_IRI.parse _namespace_name "MilitaryPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#ChineseWall"></see>
    /// </summary>
    let ChineseWall =
        Namespaced_IRI.parse _namespace_name "ChineseWall" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#CommercialPolicy"></see>
    /// </summary>
    let CommercialPolicy =
        Namespaced_IRI.parse _namespace_name "CommercialPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#ClarkWilson"></see>
    /// </summary>
    let ClarkWilson =
        Namespaced_IRI.parse _namespace_name "ClarkWilson" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SecurityPolicy"></see>
    /// </summary>
    let SecurityPolicy =
        Namespaced_IRI.parse _namespace_name "SecurityPolicy" |> NamespacedName

    /// <summary>
    ///
    /// Protects against information being disclosed or revealed to unauthorized
    /// parties.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Confidentiality"></see></summary>
    let Confidentiality =
        Namespaced_IRI.parse _namespace_name "Confidentiality" |> NamespacedName

    /// <summary>
    ///
    /// (Secondary Objective) Prevent or limit the existance of covert channels
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#CovertChannelPrevention"></see></summary>
    let CovertChannelPrevention =
        Namespaced_IRI.parse _namespace_name "CovertChannelPrevention" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#EncryptionProtocol"></see>
    /// </summary>
    let EncryptionProtocol =
        Namespaced_IRI.parse _namespace_name "EncryptionProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#HostMechanism"></see>
    /// </summary>
    let HostMechanism =
        Namespaced_IRI.parse _namespace_name "HostMechanism" |> NamespacedName

    /// <summary>
    ///
    /// (Secondary Objective) How to trust host or platform. Is relevant to Common
    /// criteria, etc.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#HostTrust"></see></summary>
    let HostTrust = Namespaced_IRI.parse _namespace_name "HostTrust" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#IPSec"></see>
    /// </summary>
    let IPSec = Namespaced_IRI.parse _namespace_name "IPSec" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#Integrity"></see>
    /// </summary>
    let Integrity = Namespaced_IRI.parse _namespace_name "Integrity" |> NamespacedName

    /// <summary>
    ///
    /// Provides guarantee that message came from whoever claimed to have sent it.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#MessageAuthentication"></see></summary>
    let MessageAuthentication =
        Namespaced_IRI.parse _namespace_name "MessageAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#NetworkSecurityProtocol"></see>
    /// </summary>
    let NetworkSecurityProtocol =
        Namespaced_IRI.parse _namespace_name "NetworkSecurityProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#Kerberos"></see>
    /// </summary>
    let Kerberos = Namespaced_IRI.parse _namespace_name "Kerberos" |> NamespacedName

    /// <summary>
    ///
    /// (SecondaryObjective) Securely manages keys for legitimate users.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#KeyManagement"></see></summary>
    let KeyManagement =
        Namespaced_IRI.parse _namespace_name "KeyManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#KeyManagementProtocol"></see>
    /// </summary>
    let KeyManagementProtocol =
        Namespaced_IRI.parse _namespace_name "KeyManagementProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#LoginProtocol"></see>
    /// </summary>
    let LoginProtocol =
        Namespaced_IRI.parse _namespace_name "LoginProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#MLSPump"></see>
    /// </summary>
    let MLSPump = Namespaced_IRI.parse _namespace_name "MLSPump" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#NetworkMechanism"></see>
    /// </summary>
    let NetworkMechanism =
        Namespaced_IRI.parse _namespace_name "NetworkMechanism" |> NamespacedName

    /// <summary>
    ///
    /// Data integrity or Message integrity; data cannot be changed, deleted,
    /// modified, etc by unauthorized parties.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#MessageIntegrity"></see></summary>
    let MessageIntegrity =
        Namespaced_IRI.parse _namespace_name "MessageIntegrity" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#OnionRouter"></see>
    /// </summary>
    let OnionRouter =
        Namespaced_IRI.parse _namespace_name "OnionRouter" |> NamespacedName

    /// <summary>
    ///
    /// Role-based Access Control
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#RBAC"></see></summary>
    let RBAC = Namespaced_IRI.parse _namespace_name "RBAC" |> NamespacedName

    /// <summary>
    ///
    /// (Secondary Objective) Protect against replay attacks
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#ReplayPrevention"></see></summary>
    let ReplayPrevention =
        Namespaced_IRI.parse _namespace_name "ReplayPrevention" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SAML"></see>
    /// </summary>
    let SAML = Namespaced_IRI.parse _namespace_name "SAML" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SSH"></see>
    /// </summary>
    let SSH = Namespaced_IRI.parse _namespace_name "SSH" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SSL"></see>
    /// </summary>
    let SSL = Namespaced_IRI.parse _namespace_name "SSL" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#TLS"></see>
    /// </summary>
    let TLS = Namespaced_IRI.parse _namespace_name "TLS" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#Safehost"></see>
    /// </summary>
    let Safehost = Namespaced_IRI.parse _namespace_name "Safehost" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SecurityConcept"></see>
    /// </summary>
    let SecurityConcept =
        Namespaced_IRI.parse _namespace_name "SecurityConcept" |> NamespacedName

    /// <summary>
    ///
    /// (Secondary Objective)
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Separation"></see></summary>
    let Separation = Namespaced_IRI.parse _namespace_name "Separation" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#ServiceMechanism"></see>
    /// </summary>
    let ServiceMechanism =
        Namespaced_IRI.parse _namespace_name "ServiceMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SignatureProtocol"></see>
    /// </summary>
    let SignatureProtocol =
        Namespaced_IRI.parse _namespace_name "SignatureProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#SoapFirewall"></see>
    /// </summary>
    let SoapFirewall =
        Namespaced_IRI.parse _namespace_name "SoapFirewall" |> NamespacedName

    /// <summary>
    ///
    /// (Secondary Objective) Pad traffic with bogus data to hide traffic patterns
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#TrafficHiding"></see></summary>
    let TrafficHiding =
        Namespaced_IRI.parse _namespace_name "TrafficHiding" |> NamespacedName

    /// <summary>
    ///
    /// (Secondary Objective) How to trust entity. Trust not only of identification,
    /// but statements, claims, etc.
    ///
    /// <see href="http://securitytoolbox.appspot.com/securityMain#Trust"></see></summary>
    let Trust = Namespaced_IRI.parse _namespace_name "Trust" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#VMM"></see>
    /// </summary>
    let VMM = Namespaced_IRI.parse _namespace_name "VMM" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#VPN"></see>
    /// </summary>
    let VPN = Namespaced_IRI.parse _namespace_name "VPN" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#XKMS"></see>
    /// </summary>
    let XKMS = Namespaced_IRI.parse _namespace_name "XKMS" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#XML-dsig"></see>
    /// </summary>
    let ``XML-dsig`` = Namespaced_IRI.parse _namespace_name "XML-dsig" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#XML-enc"></see>
    /// </summary>
    let ``XML-enc`` = Namespaced_IRI.parse _namespace_name "XML-enc" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#hasAlgorithm"></see>
    /// </summary>
    let hasAlgorithm =
        Namespaced_IRI.parse _namespace_name "hasAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#hasAssurance"></see>
    /// </summary>
    let hasAssurance =
        Namespaced_IRI.parse _namespace_name "hasAssurance" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#hasEncryptionAlgorithm"></see>
    /// </summary>
    let hasEncryptionAlgorithm =
        Namespaced_IRI.parse _namespace_name "hasEncryptionAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#hasSignatureAlgorithm"></see>
    /// </summary>
    let hasSignatureAlgorithm =
        Namespaced_IRI.parse _namespace_name "hasSignatureAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/securityMain#reqCredential"></see>
    /// </summary>
    let reqCredential =
        Namespaced_IRI.parse _namespace_name "reqCredential" |> NamespacedName
