namespace http.www.semanticweb.org.ontologies._2008._11.OntologySecurity.owl.hash

open DoxAletheia.Rdf_Vocabulary

module ontosec =
    let _namespace_name =
        "http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#"

    /// <summary>
    /// A set of sensitive functions under a named group that can get authorization.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FunctionGroups"></see></summary>
    let FunctionGroups =
        Namespaced_IRI.parse _namespace_name "FunctionGroups" |> NamespacedName

    /// <summary>
    /// Contains permissions related to network data connections.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NetAccessFunctionGroup"></see></summary>
    let NetAccessFunctionGroup =
        Namespaced_IRI.parse _namespace_name "NetAccessFunctionGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Offline"></see>
    /// </summary>
    let Offline = Namespaced_IRI.parse _namespace_name "Offline" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Parallel"></see>
    /// </summary>
    let Parallel = Namespaced_IRI.parse _namespace_name "Parallel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateInstallation"></see>
    /// </summary>
    let CertificateInstallation =
        Namespaced_IRI.parse _namespace_name "CertificateInstallation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateInstallationApplication"></see>
    /// </summary>
    let CertificateInstallationApplication =
        Namespaced_IRI.parse _namespace_name "CertificateInstallationApplication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CardMemory"></see>
    /// </summary>
    let CardMemory = Namespaced_IRI.parse _namespace_name "CardMemory" |> NamespacedName
    /// <summary>
    /// Multi Media Card
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SD"></see></summary>
    let SD = Namespaced_IRI.parse _namespace_name "SD" |> NamespacedName
    /// <summary>
    /// The software device platform layer
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Platform"></see></summary>
    let Platform = Namespaced_IRI.parse _namespace_name "Platform" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#2.5G"></see>
    /// </summary>
    let ``_2.5G`` = Namespaced_IRI.parse _namespace_name "2.5G" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WANetwork"></see>
    /// </summary>
    let WANetwork = Namespaced_IRI.parse _namespace_name "WANetwork" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#2G"></see>
    /// </summary>
    let _2G = Namespaced_IRI.parse _namespace_name "2G" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3DES"></see>
    /// </summary>
    let _3DES = Namespaced_IRI.parse _namespace_name "3DES" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BlockCipherAlgorithm"></see>
    /// </summary>
    let BlockCipherAlgorithm =
        Namespaced_IRI.parse _namespace_name "BlockCipherAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3G"></see>
    /// </summary>
    let _3G = Namespaced_IRI.parse _namespace_name "3G" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3GPP"></see>
    /// </summary>
    let _3GPP = Namespaced_IRI.parse _namespace_name "3GPP" |> NamespacedName

    /// <summary>
    /// Organizations and associations providing standards in the mobile field arena.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OrganizationsAndStandards"></see></summary>
    let OrganizationsAndStandards =
        Namespaced_IRI.parse _namespace_name "OrganizationsAndStandards" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AES"></see>
    /// </summary>
    let AES = Namespaced_IRI.parse _namespace_name "AES" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AES_FIPS197"></see>
    /// </summary>
    let AES_FIPS197 =
        Namespaced_IRI.parse _namespace_name "AES_FIPS197" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControl"></see>
    /// </summary>
    let AccessControl =
        Namespaced_IRI.parse _namespace_name "AccessControl" |> NamespacedName

    /// <summary>
    /// List of permissions attached to an object.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControlList"></see></summary>
    let AccessControlList =
        Namespaced_IRI.parse _namespace_name "AccessControlList" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControlMethods"></see>
    /// </summary>
    let AccessControlMethods =
        Namespaced_IRI.parse _namespace_name "AccessControlMethods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Satisfice"></see>
    /// </summary>
    let Satisfice = Namespaced_IRI.parse _namespace_name "Satisfice" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Integrity"></see>
    /// </summary>
    let Integrity = Namespaced_IRI.parse _namespace_name "Integrity" |> NamespacedName

    /// <summary>
    /// The confidentiality service
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Confidentiality"></see></summary>
    let Confidentiality =
        Namespaced_IRI.parse _namespace_name "Confidentiality" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CoreCounterMeasure"></see>
    /// </summary>
    let CoreCounterMeasure =
        Namespaced_IRI.parse _namespace_name "CoreCounterMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ActiveThreat"></see>
    /// </summary>
    let ActiveThreat =
        Namespaced_IRI.parse _namespace_name "ActiveThreat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ThreatType"></see>
    /// </summary>
    let ThreatType = Namespaced_IRI.parse _namespace_name "ThreatType" |> NamespacedName
    /// <summary>
    /// Actors participating in the realisation and implementation of security services
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Add-OnMemory"></see>
    /// </summary>
    let ``Add-OnMemory`` =
        Namespaced_IRI.parse _namespace_name "Add-OnMemory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Memory"></see>
    /// </summary>
    let Memory = Namespaced_IRI.parse _namespace_name "Memory" |> NamespacedName

    /// <summary>
    /// New tools that should be used for the projection or the application.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AdditionalTools"></see></summary>
    let AdditionalTools =
        Namespaced_IRI.parse _namespace_name "AdditionalTools" |> NamespacedName

    /// <summary>
    /// Time, skills, additional equipments are considered as cost constraints
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Cost"></see></summary>
    let Cost = Namespaced_IRI.parse _namespace_name "Cost" |> NamespacedName

    /// <summary>
    /// Tasks to be performed and which are out of the scope of the technical field.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AdministrativeProcedure"></see></summary>
    let AdministrativeProcedure =
        Namespaced_IRI.parse _namespace_name "AdministrativeProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Algorithm"></see>
    /// </summary>
    let Algorithm = Namespaced_IRI.parse _namespace_name "Algorithm" |> NamespacedName
    /// <summary>
    /// Security mechanisms used for security services
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mechanism"></see></summary>
    let Mechanism = Namespaced_IRI.parse _namespace_name "Mechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AnalysisPhase"></see>
    /// </summary>
    let AnalysisPhase =
        Namespaced_IRI.parse _namespace_name "AnalysisPhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationLifeCyclePhase"></see>
    /// </summary>
    let ApplicationLifeCyclePhase =
        Namespaced_IRI.parse _namespace_name "ApplicationLifeCyclePhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Android"></see>
    /// </summary>
    let Android = Namespaced_IRI.parse _namespace_name "Android" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Application"></see>
    /// </summary>
    let Application =
        Namespaced_IRI.parse _namespace_name "Application" |> NamespacedName

    /// <summary>
    /// All the applications and data provided with or installed on the device.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationData"></see>
    /// </summary>
    let ApplicationData =
        Namespaced_IRI.parse _namespace_name "ApplicationData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Data"></see>
    /// </summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName
    /// <summary>
    /// Additional and required types for the ontology
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ValueTypes"></see></summary>
    let ValueTypes = Namespaced_IRI.parse _namespace_name "ValueTypes" |> NamespacedName

    /// <summary>
    /// The application server side may be a web server or a data base back end that the device connects to.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationServerSide"></see></summary>
    let ApplicationServerSide =
        Namespaced_IRI.parse _namespace_name "ApplicationServerSide" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Backup"></see>
    /// </summary>
    let Backup = Namespaced_IRI.parse _namespace_name "Backup" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementMechanism"></see>
    /// </summary>
    let ImplementMechanism =
        Namespaced_IRI.parse _namespace_name "ImplementMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Journaling"></see>
    /// </summary>
    let Journaling = Namespaced_IRI.parse _namespace_name "Journaling" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AppliedTo"></see>
    /// </summary>
    let AppliedTo = Namespaced_IRI.parse _namespace_name "AppliedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Relationship"></see>
    /// </summary>
    let Relationship =
        Namespaced_IRI.parse _namespace_name "Relationship" |> NamespacedName

    /// <summary>
    /// The set of assets that should be protected
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Asset"></see></summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AssociatedOriented"></see>
    /// </summary>
    let AssociatedOriented =
        Namespaced_IRI.parse _namespace_name "AssociatedOriented" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonRepudiationType"></see>
    /// </summary>
    let NonRepudiationType =
        Namespaced_IRI.parse _namespace_name "NonRepudiationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AsymmetricAlgorithm"></see>
    /// </summary>
    let AsymmetricAlgorithm =
        Namespaced_IRI.parse _namespace_name "AsymmetricAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PrivateKey"></see>
    /// </summary>
    let PrivateKey = Namespaced_IRI.parse _namespace_name "PrivateKey" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PublicKey"></see>
    /// </summary>
    let PublicKey = Namespaced_IRI.parse _namespace_name "PublicKey" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Use"></see>
    /// </summary>
    let Use = Namespaced_IRI.parse _namespace_name "Use" |> NamespacedName
    /// <summary>
    /// Best use of the available resources.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Efficiency"></see></summary>
    let Efficiency = Namespaced_IRI.parse _namespace_name "Efficiency" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Hurt"></see>
    /// </summary>
    let Hurt = Namespaced_IRI.parse _namespace_name "Hurt" |> NamespacedName

    /// <summary>
    /// Type of encryption in which an encryption key (the public key) is used to encrypt a message, and another encryption key (the private key) is used to decrypt the message.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AsymmetricEncryption"></see></summary>
    let AsymmetricEncryption =
        Namespaced_IRI.parse _namespace_name "AsymmetricEncryption" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyExchangeProtocol"></see>
    /// </summary>
    let KeyExchangeProtocol =
        Namespaced_IRI.parse _namespace_name "KeyExchangeProtocol" |> NamespacedName

    /// <summary>
    /// Discipline which embodies principles, means, and methods for the transformation of data in order to hide its information content, prevent its undetected modification and/or prevent its unauthorised use. (CCITT)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Encryption"></see></summary>
    let Encryption = Namespaced_IRI.parse _namespace_name "Encryption" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Authentication"></see>
    /// </summary>
    let Authentication =
        Namespaced_IRI.parse _namespace_name "Authentication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DomainEntities"></see>
    /// </summary>
    let DomainEntities =
        Namespaced_IRI.parse _namespace_name "DomainEntities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationLevel"></see>
    /// </summary>
    let AuthenticationLevel =
        Namespaced_IRI.parse _namespace_name "AuthenticationLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasLevel"></see>
    /// </summary>
    let hasLevel = Namespaced_IRI.parse _namespace_name "hasLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationProtocol"></see>
    /// </summary>
    let AuthenticationProtocol =
        Namespaced_IRI.parse _namespace_name "AuthenticationProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationProtocolType"></see>
    /// </summary>
    let AuthenticationProtocolType =
        Namespaced_IRI.parse _namespace_name "AuthenticationProtocolType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasAuthenticationProtocolType"></see>
    /// </summary>
    let hasAuthenticationProtocolType =
        Namespaced_IRI.parse _namespace_name "hasAuthenticationProtocolType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IndustrialProtocol"></see>
    /// </summary>
    let IndustrialProtocol =
        Namespaced_IRI.parse _namespace_name "IndustrialProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationToken"></see>
    /// </summary>
    let AuthenticationToken =
        Namespaced_IRI.parse _namespace_name "AuthenticationToken" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationWay"></see>
    /// </summary>
    let AuthenticationWay =
        Namespaced_IRI.parse _namespace_name "AuthenticationWay" |> NamespacedName

    /// <summary>
    /// Permissions related to automatically starting a MIDlet, for example by Push Registration.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AutoInvocationFunctionGroup"></see></summary>
    let AutoInvocationFunctionGroup =
        Namespaced_IRI.parse _namespace_name "AutoInvocationFunctionGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Availability"></see>
    /// </summary>
    let Availability =
        Namespaced_IRI.parse _namespace_name "Availability" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Duration"></see>
    /// </summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDuration"></see>
    /// </summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Techniques"></see>
    /// </summary>
    let Techniques = Namespaced_IRI.parse _namespace_name "Techniques" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BatteryMonitor"></see>
    /// </summary>
    let BatteryMonitor =
        Namespaced_IRI.parse _namespace_name "BatteryMonitor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ResourceMonitoring"></see>
    /// </summary>
    let ResourceMonitoring =
        Namespaced_IRI.parse _namespace_name "ResourceMonitoring" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BestPractises"></see>
    /// </summary>
    let BestPractises =
        Namespaced_IRI.parse _namespace_name "BestPractises" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Standards"></see>
    /// </summary>
    let Standards = Namespaced_IRI.parse _namespace_name "Standards" |> NamespacedName

    /// <summary>
    /// Biometric identifier is one of the most secure and more reliable ways to authenticate a person’s identity is to verify that person’s innate biological characteristics, which are referred to as biometrics. Each person’s fingerprints, DNA, iris and retinal cell patterns, facial geometry, and heat signature are near unique to that person. These biometric measures, if properly recorded, validated, and embedded in identity credentials that are logically bound to a single person’s identity, can provide the highest degree of identity authentication (From NIST information security Report)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BiometricIdentifier"></see></summary>
    let BiometricIdentifier =
        Namespaced_IRI.parse _namespace_name "BiometricIdentifier" |> NamespacedName

    /// <summary>
    /// ability of Application running on several devices or/and platforms.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Portability"></see></summary>
    let Portability =
        Namespaced_IRI.parse _namespace_name "Portability" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Resource"></see>
    /// </summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasPadding"></see>
    /// </summary>
    let hasPadding = Namespaced_IRI.parse _namespace_name "hasPadding" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ChainingMode"></see>
    /// </summary>
    let ChainingMode =
        Namespaced_IRI.parse _namespace_name "ChainingMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasChainingMode"></see>
    /// </summary>
    let hasChainingMode =
        Namespaced_IRI.parse _namespace_name "hasChainingMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasInitialisationVector"></see>
    /// </summary>
    let hasInitialisationVector =
        Namespaced_IRI.parse _namespace_name "hasInitialisationVector" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasBlockSize"></see>
    /// </summary>
    let HasBlockSize =
        Namespaced_IRI.parse _namespace_name "HasBlockSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricAlgorithm"></see>
    /// </summary>
    let SymmetricAlgorithm =
        Namespaced_IRI.parse _namespace_name "SymmetricAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Blowfish"></see>
    /// </summary>
    let Blowfish = Namespaced_IRI.parse _namespace_name "Blowfish" |> NamespacedName
    /// <summary>
    /// Bluetooth is a Personal Area Network (PAN) standard that enables wireless connections between electronic devices in the 2.4 GHz range over short distances, as an alternative to cables. Designed to be power efficient, Bluetooth has become a common feature in cell phones. Since wireless communications are inherently insecure, a number of basic security provisions have been defined for this standard to mitigate the risks involved. NIST
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Bluetooth"></see></summary>
    let Bluetooth = Namespaced_IRI.parse _namespace_name "Bluetooth" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PANetwork"></see>
    /// </summary>
    let PANetwork = Namespaced_IRI.parse _namespace_name "PANetwork" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Break"></see>
    /// </summary>
    let Break = Namespaced_IRI.parse _namespace_name "Break" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#QualitySatisfaction"></see>
    /// </summary>
    let QualitySatisfaction =
        Namespaced_IRI.parse _namespace_name "QualitySatisfaction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ByPassingTrialCounter"></see>
    /// </summary>
    let ByPassingTrialCounter =
        Namespaced_IRI.parse _namespace_name "ByPassingTrialCounter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CBC"></see>
    /// </summary>
    let CBC = Namespaced_IRI.parse _namespace_name "CBC" |> NamespacedName
    /// <summary>
    /// The simplest way to make a key-dependent one-way hash function is to encrypt a message with a block algorithm in CBC or CFB modes . The hash is the last encrypted block, encrypted once more in CBC or CFB modes.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CBC-MAC"></see></summary>
    let ``CBC-MAC`` = Namespaced_IRI.parse _namespace_name "CBC-MAC" |> NamespacedName

    /// <summary>
    /// Message authentication code that include a key for authentication
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MACAlgorithm"></see></summary>
    let MACAlgorithm =
        Namespaced_IRI.parse _namespace_name "MACAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CFB"></see>
    /// </summary>
    let CFB = Namespaced_IRI.parse _namespace_name "CFB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#COMSET"></see>
    /// </summary>
    let COMSET = Namespaced_IRI.parse _namespace_name "COMSET" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CardType"></see>
    /// </summary>
    let CardType = Namespaced_IRI.parse _namespace_name "CardType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Certificate"></see>
    /// </summary>
    let Certificate =
        Namespaced_IRI.parse _namespace_name "Certificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasValidity"></see>
    /// </summary>
    let hasValidity =
        Namespaced_IRI.parse _namespace_name "hasValidity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalSignatureAlgorithm"></see>
    /// </summary>
    let DigitalSignatureAlgorithm =
        Namespaced_IRI.parse _namespace_name "DigitalSignatureAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasSignatureAlgorithm"></see>
    /// </summary>
    let hasSignatureAlgorithm =
        Namespaced_IRI.parse _namespace_name "hasSignatureAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasSubjectName"></see>
    /// </summary>
    let hasSubjectName =
        Namespaced_IRI.parse _namespace_name "hasSubjectName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDigitalSignatureData"></see>
    /// </summary>
    let hasDigitalSignatureData =
        Namespaced_IRI.parse _namespace_name "hasDigitalSignatureData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateFormat"></see>
    /// </summary>
    let CertificateFormat =
        Namespaced_IRI.parse _namespace_name "CertificateFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasFormat"></see>
    /// </summary>
    let hasFormat = Namespaced_IRI.parse _namespace_name "hasFormat" |> NamespacedName

    /// <summary>
    /// The certification authority provides certificates to bind a set of informations (name, serial number, ...) to a public key.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificationAuthority"></see></summary>
    let CertificationAuthority =
        Namespaced_IRI.parse _namespace_name "CertificationAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIssuer"></see>
    /// </summary>
    let hasIssuer = Namespaced_IRI.parse _namespace_name "hasIssuer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceCapabilities"></see>
    /// </summary>
    let DeviceCapabilities =
        Namespaced_IRI.parse _namespace_name "DeviceCapabilities" |> NamespacedName

    /// <summary>
    /// security authority or its agent, trusted by other entities with respect to security-related activities. In the context of ISO/IEC 9798, a trusted third party is trusted by a claimant and/or a verifier for the purposes of authentication.  ISO/IEC 9798
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedThirdParty"></see></summary>
    let TrustedThirdParty =
        Namespaced_IRI.parse _namespace_name "TrustedThirdParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ChallengeReplyPassword"></see>
    /// </summary>
    let ChallengeReplyPassword =
        Namespaced_IRI.parse _namespace_name "ChallengeReplyPassword" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Checksum"></see>
    /// </summary>
    let Checksum = Namespaced_IRI.parse _namespace_name "Checksum" |> NamespacedName

    /// <summary>
    /// Locate and isolate critical code from from general code.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CodeSeparation"></see></summary>
    let CodeSeparation =
        Namespaced_IRI.parse _namespace_name "CodeSeparation" |> NamespacedName

    /// <summary>
    /// Deploy development regimes such as coding standards and documentation methodologies to lead to best practises
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CodingStandards"></see></summary>
    let CodingStandards =
        Namespaced_IRI.parse _namespace_name "CodingStandards" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CombinedDelivery-DRM"></see>
    /// </summary>
    let ``CombinedDelivery-DRM`` =
        Namespaced_IRI.parse _namespace_name "CombinedDelivery-DRM" |> NamespacedName

    /// <summary>
    /// A general framework for downloading Rights to Devices and sharing Rights in a domain. DRM is invented by the Open Mobile Alliance whose members are mobile phone manufacturers, mobile system manufacturers, operators , and sofware editors.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalRightsManagement"></see></summary>
    let DigitalRightsManagement =
        Namespaced_IRI.parse _namespace_name "DigitalRightsManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CommChannel"></see>
    /// </summary>
    let CommChannel =
        Namespaced_IRI.parse _namespace_name "CommChannel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CompactFlash"></see>
    /// </summary>
    let CompactFlash =
        Namespaced_IRI.parse _namespace_name "CompactFlash" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ConfidentialityLevel"></see>
    /// </summary>
    let ConfidentialityLevel =
        Namespaced_IRI.parse _namespace_name "ConfidentialityLevel" |> NamespacedName

    /// <summary>
    /// Several configuration data are stored in the device or sent by the mobile operator.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ConfigurationData"></see></summary>
    let ConfigurationData =
        Namespaced_IRI.parse _namespace_name "ConfigurationData" |> NamespacedName

    /// <summary>
    /// Technical, quality constraints and others
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Constraints"></see></summary>
    let Constraints =
        Namespaced_IRI.parse _namespace_name "Constraints" |> NamespacedName

    /// <summary>
    /// The entity who is responsable of providing content like ringing tones or multimedia files or any other software.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ContentProvider"></see></summary>
    let ContentProvider =
        Namespaced_IRI.parse _namespace_name "ContentProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Provide"></see>
    /// </summary>
    let Provide = Namespaced_IRI.parse _namespace_name "Provide" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Correction"></see>
    /// </summary>
    let Correction = Namespaced_IRI.parse _namespace_name "Correction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MechanismType"></see>
    /// </summary>
    let MechanismType =
        Namespaced_IRI.parse _namespace_name "MechanismType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Critical"></see>
    /// </summary>
    let Critical = Namespaced_IRI.parse _namespace_name "Critical" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CryptographicHashFunction"></see>
    /// </summary>
    let CryptographicHashFunction =
        Namespaced_IRI.parse _namespace_name "CryptographicHashFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasOutputLength"></see>
    /// </summary>
    let HasOutputLength =
        Namespaced_IRI.parse _namespace_name "HasOutputLength" |> NamespacedName

    /// <summary>
    /// A function that takes a string (or message) of any length as input and produces a fixed-length string as output,it is used for authentication and message integrity.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MessageDigest"></see></summary>
    let MessageDigest =
        Namespaced_IRI.parse _namespace_name "MessageDigest" |> NamespacedName

    /// <summary>
    /// Distributed denial of service.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DDos"></see></summary>
    let DDos = Namespaced_IRI.parse _namespace_name "DDos" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DES"></see>
    /// </summary>
    let DES = Namespaced_IRI.parse _namespace_name "DES" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DES_FIPS46-1-2"></see>
    /// </summary>
    let ``DES_FIPS46-1-2`` =
        Namespaced_IRI.parse _namespace_name "DES_FIPS46-1-2" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DIFFIE-HELLMAN"></see>
    /// </summary>
    let ``DIFFIE-HELLMAN`` =
        Namespaced_IRI.parse _namespace_name "DIFFIE-HELLMAN" |> NamespacedName

    /// <summary>
    /// Digital Signature Algorithm specified by FIPS 186-2
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DSA"></see></summary>
    let DSA = Namespaced_IRI.parse _namespace_name "DSA" |> NamespacedName

    /// <summary>
    /// Some applications use records files to store data.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DataRecords"></see></summary>
    let DataRecords =
        Namespaced_IRI.parse _namespace_name "DataRecords" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalFiles"></see>
    /// </summary>
    let LocalFiles = Namespaced_IRI.parse _namespace_name "LocalFiles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeploymentPhase"></see>
    /// </summary>
    let DeploymentPhase =
        Namespaced_IRI.parse _namespace_name "DeploymentPhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DesignPhase"></see>
    /// </summary>
    let DesignPhase =
        Namespaced_IRI.parse _namespace_name "DesignPhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Detection"></see>
    /// </summary>
    let Detection = Namespaced_IRI.parse _namespace_name "Detection" |> NamespacedName

    /// <summary>
    /// Addiotional development time required for the application or the project.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DevelopmentTime"></see></summary>
    let DevelopmentTime =
        Namespaced_IRI.parse _namespace_name "DevelopmentTime" |> NamespacedName

    /// <summary>
    /// Mobile terminal equiped with processing capabilities offering  connection to wireless networks.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasMemory"></see>
    /// </summary>
    let hasMemory = Namespaced_IRI.parse _namespace_name "hasMemory" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Network"></see>
    /// </summary>
    let Network = Namespaced_IRI.parse _namespace_name "Network" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetwork"></see>
    /// </summary>
    let hasNetwork = Namespaced_IRI.parse _namespace_name "hasNetwork" |> NamespacedName
    /// <summary>
    /// Keypad or any input tool
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Input"></see></summary>
    let Input = Namespaced_IRI.parse _namespace_name "Input" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasInput"></see>
    /// </summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceLock"></see>
    /// </summary>
    let DeviceLock = Namespaced_IRI.parse _namespace_name "DeviceLock" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LogInSystem"></see>
    /// </summary>
    let LogInSystem =
        Namespaced_IRI.parse _namespace_name "LogInSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIMEI"></see>
    /// </summary>
    let hasIMEI = Namespaced_IRI.parse _namespace_name "hasIMEI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Processing"></see>
    /// </summary>
    let Processing = Namespaced_IRI.parse _namespace_name "Processing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasProcessing"></see>
    /// </summary>
    let hasProcessing =
        Namespaced_IRI.parse _namespace_name "hasProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Output"></see>
    /// </summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasOutput"></see>
    /// </summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceCloning"></see>
    /// </summary>
    let DeviceCloning =
        Namespaced_IRI.parse _namespace_name "DeviceCloning" |> NamespacedName

    /// <summary>
    /// One problem in this area is that drivers are typically written by third parties and drivers are upgraded at different times to the main OS. This causes problems when implementing any validation scheme, or even isolated checking of specific software updates
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceDriverUpgrade"></see></summary>
    let DeviceDriverUpgrade =
        Namespaced_IRI.parse _namespace_name "DeviceDriverUpgrade" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LockingMechanism"></see>
    /// </summary>
    let LockingMechanism =
        Namespaced_IRI.parse _namespace_name "LockingMechanism" |> NamespacedName

    /// <summary>
    /// A digital signature is represented in a computer as a string of binary
    /// digits. A digital signature is computed using a set of rules and a set of parameters such that the identity of the signatory and integrity of the data can be verified. An algorithm provides the capability to generate and verify signatures. Signature generation makes use of a private key to generate a digital signature. Signature verification makes use of a public key which corresponds to, but is not the same as, the private key. (http://csrc.nist.gov/publications/fips/fips186-2/fips186-2-change1.pdf)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalSignature"></see></summary>
    let DigitalSignature =
        Namespaced_IRI.parse _namespace_name "DigitalSignature" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonRepudiation"></see>
    /// </summary>
    let NonRepudiation =
        Namespaced_IRI.parse _namespace_name "NonRepudiation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DisplayScreen"></see>
    /// </summary>
    let DisplayScreen =
        Namespaced_IRI.parse _namespace_name "DisplayScreen" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasScreenSize"></see>
    /// </summary>
    let hasScreenSize =
        Namespaced_IRI.parse _namespace_name "hasScreenSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DotNet"></see>
    /// </summary>
    let DotNet = Namespaced_IRI.parse _namespace_name "DotNet" |> NamespacedName
    /// <summary>
    /// Electronic code book
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ECB"></see></summary>
    let ECB = Namespaced_IRI.parse _namespace_name "ECB" |> NamespacedName
    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm (ECDSA) (ANSI X9-62)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ECDSA"></see></summary>
    let ECDSA = Namespaced_IRI.parse _namespace_name "ECDSA" |> NamespacedName
    /// <summary>
    /// Enhanced Data rates for GSM Evolution
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EDGE"></see></summary>
    let EDGE = Namespaced_IRI.parse _namespace_name "EDGE" |> NamespacedName
    /// <summary>
    /// Enhanced Messaging Service - An improved message system for GSM mobile phones allowing picture, sound, animation and text elements to be conveyed through one or more concatenated SMS messages. NIST
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EMS"></see></summary>
    let EMS = Namespaced_IRI.parse _namespace_name "EMS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Messaging"></see>
    /// </summary>
    let Messaging = Namespaced_IRI.parse _namespace_name "Messaging" |> NamespacedName
    /// <summary>
    /// A good response time of the application.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Usability"></see></summary>
    let Usability = Namespaced_IRI.parse _namespace_name "Usability" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ElGammelAlgorithm"></see>
    /// </summary>
    let ElGammelAlgorithm =
        Namespaced_IRI.parse _namespace_name "ElGammelAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Email"></see>
    /// </summary>
    let Email = Namespaced_IRI.parse _namespace_name "Email" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Internet"></see>
    /// </summary>
    let Internet = Namespaced_IRI.parse _namespace_name "Internet" |> NamespacedName

    /// <summary>
    /// Pseudo Random Number Generation algorithm
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PRNGAlgorithm"></see></summary>
    let PRNGAlgorithm =
        Namespaced_IRI.parse _namespace_name "PRNGAlgorithm" |> NamespacedName

    /// <summary>
    /// The encryption keys are digital bitstrings that are stored in non-volatile memory, and verification of the identity proceeds by a challenge-response protocol.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EncryptionKeys"></see></summary>
    let EncryptionKeys =
        Namespaced_IRI.parse _namespace_name "EncryptionKeys" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Keys"></see>
    /// </summary>
    let Keys = Namespaced_IRI.parse _namespace_name "Keys" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EndToEnd"></see>
    /// </summary>
    let EndToEnd = Namespaced_IRI.parse _namespace_name "EndToEnd" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Excellent"></see>
    /// </summary>
    let Excellent = Namespaced_IRI.parse _namespace_name "Excellent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RNGEfficiency"></see>
    /// </summary>
    let RNGEfficiency =
        Namespaced_IRI.parse _namespace_name "RNGEfficiency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FTP"></see>
    /// </summary>
    let FTP = Namespaced_IRI.parse _namespace_name "FTP" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FixedMemory"></see>
    /// </summary>
    let FixedMemory =
        Namespaced_IRI.parse _namespace_name "FixedMemory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ForwardLock-DRM"></see>
    /// </summary>
    let ``ForwardLock-DRM`` =
        Namespaced_IRI.parse _namespace_name "ForwardLock-DRM" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FullIntegrity"></see>
    /// </summary>
    let FullIntegrity =
        Namespaced_IRI.parse _namespace_name "FullIntegrity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IntegrityType"></see>
    /// </summary>
    let IntegrityType =
        Namespaced_IRI.parse _namespace_name "IntegrityType" |> NamespacedName

    /// <summary>
    /// General Packet Radio Service
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPRS"></see></summary>
    let GPRS = Namespaced_IRI.parse _namespace_name "GPRS" |> NamespacedName
    /// <summary>
    /// A system for determining position by comparing radio signals from several satellites. NIST
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPSNetwork"></see></summary>
    let GPSNetwork = Namespaced_IRI.parse _namespace_name "GPSNetwork" |> NamespacedName
    /// <summary>
    /// Global positioning system coordinates used by some applications.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPSvalues"></see></summary>
    let GPSvalues = Namespaced_IRI.parse _namespace_name "GPSvalues" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalisationData"></see>
    /// </summary>
    let LocalisationData =
        Namespaced_IRI.parse _namespace_name "LocalisationData" |> NamespacedName

    /// <summary>
    /// Global System for Mobile communications
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSM"></see></summary>
    let GSM = Namespaced_IRI.parse _namespace_name "GSM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSMA"></see>
    /// </summary>
    let GSMA = Namespaced_IRI.parse _namespace_name "GSMA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSMWorld"></see>
    /// </summary>
    let GSMWorld = Namespaced_IRI.parse _namespace_name "GSMWorld" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GuessingAttack"></see>
    /// </summary>
    let GuessingAttack =
        Namespaced_IRI.parse _namespace_name "GuessingAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HMAC"></see>
    /// </summary>
    let HMAC = Namespaced_IRI.parse _namespace_name "HMAC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HTTP"></see>
    /// </summary>
    let HTTP = Namespaced_IRI.parse _namespace_name "HTTP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HTTPS"></see>
    /// </summary>
    let HTTPS = Namespaced_IRI.parse _namespace_name "HTTPS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecureNetworkCommunication"></see>
    /// </summary>
    let SecureNetworkCommunication =
        Namespaced_IRI.parse _namespace_name "SecureNetworkCommunication" |> NamespacedName

    /// <summary>
    /// Mainly the physical device with the embedded memory and processing units.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Hardware"></see></summary>
    let Hardware = Namespaced_IRI.parse _namespace_name "Hardware" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HardwareLocking"></see>
    /// </summary>
    let HardwareLocking =
        Namespaced_IRI.parse _namespace_name "HardwareLocking" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasBandwidth"></see>
    /// </summary>
    let HasBandwidth =
        Namespaced_IRI.parse _namespace_name "HasBandwidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasIterationNumber"></see>
    /// </summary>
    let HasIterationNumber =
        Namespaced_IRI.parse _namespace_name "HasIterationNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasKeySize"></see>
    /// </summary>
    let HasKeySize = Namespaced_IRI.parse _namespace_name "HasKeySize" |> NamespacedName

    /// <summary>
    /// A server side list of hashed tokens is stored and each consumed token is removed from the list.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HashBasedOTP"></see></summary>
    let HashBasedOTP =
        Namespaced_IRI.parse _namespace_name "HashBasedOTP" |> NamespacedName

    /// <summary>
    /// Password used for once and generated from time, counter and/or key. May be a displayed from a hardware device.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#O.T.P"></see></summary>
    let ``O.T.P`` = Namespaced_IRI.parse _namespace_name "O.T.P" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Help"></see>
    /// </summary>
    let Help = Namespaced_IRI.parse _namespace_name "Help" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IEEE"></see>
    /// </summary>
    let IEEE = Namespaced_IRI.parse _namespace_name "IEEE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IETF"></see>
    /// </summary>
    let IETF = Namespaced_IRI.parse _namespace_name "IETF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IM"></see>
    /// </summary>
    let IM = Namespaced_IRI.parse _namespace_name "IM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IPSec"></see>
    /// </summary>
    let IPSec = Namespaced_IRI.parse _namespace_name "IPSec" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ITU"></see>
    /// </summary>
    let ITU = Namespaced_IRI.parse _namespace_name "ITU" |> NamespacedName
    /// <summary>
    /// All supported image files for mobile devices.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Images"></see></summary>
    let Images = Namespaced_IRI.parse _namespace_name "Images" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementAPI"></see>
    /// </summary>
    let ImplementAPI =
        Namespaced_IRI.parse _namespace_name "ImplementAPI" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementationPhase"></see>
    /// </summary>
    let ImplementationPhase =
        Namespaced_IRI.parse _namespace_name "ImplementationPhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IntensifyCriticalCodeReview"></see>
    /// </summary>
    let IntensifyCriticalCodeReview =
        Namespaced_IRI.parse _namespace_name "IntensifyCriticalCodeReview" |> NamespacedName

    /// <summary>
    /// User interaction to confirm the execution of some senstive actions like sending a sms or opening a network connection/
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#InteractionModes"></see></summary>
    let InteractionModes =
        Namespaced_IRI.parse _namespace_name "InteractionModes" |> NamespacedName

    /// <summary>
    /// A standard for line-of-sight infrared communication between devices over short distances. NIST
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IrDA"></see></summary>
    let IrDA = Namespaced_IRI.parse _namespace_name "IrDA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Issue"></see>
    /// </summary>
    let Issue = Namespaced_IRI.parse _namespace_name "Issue" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#J2ME"></see>
    /// </summary>
    let J2ME = Namespaced_IRI.parse _namespace_name "J2ME" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JME"></see>
    /// </summary>
    let JME = Namespaced_IRI.parse _namespace_name "JME" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JMEPermissionDomains"></see>
    /// </summary>
    let JMEPermissionDomains =
        Namespaced_IRI.parse _namespace_name "JMEPermissionDomains" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JavaCard"></see>
    /// </summary>
    let JavaCard = Namespaced_IRI.parse _namespace_name "JavaCard" |> NamespacedName
    /// <summary>
    /// Subscriber Identity Module; A smart card for GSM networks access.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SIM"></see></summary>
    let SIM = Namespaced_IRI.parse _namespace_name "SIM" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JavaVerifiedSigningProcess"></see>
    /// </summary>
    let JavaVerifiedSigningProcess =
        Namespaced_IRI.parse _namespace_name "JavaVerifiedSigningProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SourceCodeVerification"></see>
    /// </summary>
    let SourceCodeVerification =
        Namespaced_IRI.parse _namespace_name "SourceCodeVerification" |> NamespacedName

    /// <summary>
    /// Kerberos is an authentication process that proceeds as follows: A client sends a request to the authentication server (AS) requesting "credentials" for a given server.  The AS responds with these credentials,  encrypted in the client's key.  The credentials consist of 1) a "ticket" for the server and 2) a temporary encryption key ( a "session key").  The client transmits the ticket (which contains the client's identity and a copy of the session key, all encrypted in the server's key) to the server.  The session key (now shared by the client and server) is used to authenticate the client, and may optionally be used to authenticate the server.  It may also be used to encrypt further communication between the two parties or to exchange a separate sub-session key to be used to encrypt further communication. RFC 1510
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Kerberos"></see></summary>
    let Kerberos = Namespaced_IRI.parse _namespace_name "Kerberos" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyExchange"></see>
    /// </summary>
    let KeyExchange =
        Namespaced_IRI.parse _namespace_name "KeyExchange" |> NamespacedName

    /// <summary>
    /// The process and procedure for safely storing and distributing accurate cryptographic keys; the overall process of generating and distributing cryptographic key to authorized recipients in a secure manner.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyManagement"></see></summary>
    let KeyManagement =
        Namespaced_IRI.parse _namespace_name "KeyManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyGeneration"></see>
    /// </summary>
    let KeyGeneration =
        Namespaced_IRI.parse _namespace_name "KeyGeneration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasRNGEfficiency"></see>
    /// </summary>
    let hasRNGEfficiency =
        Namespaced_IRI.parse _namespace_name "hasRNGEfficiency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasRNGDeterminism"></see>
    /// </summary>
    let hasRNGDeterminism =
        Namespaced_IRI.parse _namespace_name "hasRNGDeterminism" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyPad"></see>
    /// </summary>
    let KeyPad = Namespaced_IRI.parse _namespace_name "KeyPad" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyStore"></see>
    /// </summary>
    let KeyStore = Namespaced_IRI.parse _namespace_name "KeyStore" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Store"></see>
    /// </summary>
    let Store = Namespaced_IRI.parse _namespace_name "Store" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasKeyLifeTime"></see>
    /// </summary>
    let hasKeyLifeTime =
        Namespaced_IRI.parse _namespace_name "hasKeyLifeTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LANetwork"></see>
    /// </summary>
    let LANetwork = Namespaced_IRI.parse _namespace_name "LANetwork" |> NamespacedName

    /// <summary>
    /// Easy to learn how to use the application.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Learnability"></see></summary>
    let Learnability =
        Namespaced_IRI.parse _namespace_name "Learnability" |> NamespacedName

    /// <summary>
    /// Special database management systems for embedded applications.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalDataBase"></see></summary>
    let LocalDataBase =
        Namespaced_IRI.parse _namespace_name "LocalDataBase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalDeviceLock"></see>
    /// </summary>
    let LocalDeviceLock =
        Namespaced_IRI.parse _namespace_name "LocalDeviceLock" |> NamespacedName

    /// <summary>
    /// In some situations it is useful to lock the screen display until a task is terminated. This is technique is used to avoid the screen modification until a answer is received.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LockingScreen"></see></summary>
    let LockingScreen =
        Namespaced_IRI.parse _namespace_name "LockingScreen" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecretKey"></see>
    /// </summary>
    let SecretKey = Namespaced_IRI.parse _namespace_name "SecretKey" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD2"></see>
    /// </summary>
    let MD2 = Namespaced_IRI.parse _namespace_name "MD2" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD4"></see>
    /// </summary>
    let MD4 = Namespaced_IRI.parse _namespace_name "MD4" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD5"></see>
    /// </summary>
    let MD5 = Namespaced_IRI.parse _namespace_name "MD5" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MMC"></see>
    /// </summary>
    let MMC = Namespaced_IRI.parse _namespace_name "MMC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MMS"></see>
    /// </summary>
    let MMS = Namespaced_IRI.parse _namespace_name "MMS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MULTOS"></see>
    /// </summary>
    let MULTOS = Namespaced_IRI.parse _namespace_name "MULTOS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mail"></see>
    /// </summary>
    let Mail = Namespaced_IRI.parse _namespace_name "Mail" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Manual"></see>
    /// </summary>
    let Manual = Namespaced_IRI.parse _namespace_name "Manual" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MaintenancePhase"></see>
    /// </summary>
    let MaintenancePhase =
        Namespaced_IRI.parse _namespace_name "MaintenancePhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Make"></see>
    /// </summary>
    let Make = Namespaced_IRI.parse _namespace_name "Make" |> NamespacedName

    /// <summary>
    /// Mobile device manufacturer which may implement some security features in the device
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Manufacturer"></see></summary>
    let Manufacturer =
        Namespaced_IRI.parse _namespace_name "Manufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasTrustIn"></see>
    /// </summary>
    let hasTrustIn = Namespaced_IRI.parse _namespace_name "hasTrustIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ManufacturerCertificate"></see>
    /// </summary>
    let ManufacturerCertificate =
        Namespaced_IRI.parse _namespace_name "ManufacturerCertificate" |> NamespacedName

    /// <summary>
    /// A limited period of time during which the use of the application will be memorised.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Memorability"></see></summary>
    let Memorability =
        Namespaced_IRI.parse _namespace_name "Memorability" |> NamespacedName

    /// <summary>
    /// Memory card can be protected with a password each time someone tries to access the card
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MemoryCardLock"></see></summary>
    let MemoryCardLock =
        Namespaced_IRI.parse _namespace_name "MemoryCardLock" |> NamespacedName

    /// <summary>
    /// Set of permissions related to sending or receiving messages like SMS
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MessagingFunctionsGroup"></see></summary>
    let MessagingFunctionsGroup =
        Namespaced_IRI.parse _namespace_name "MessagingFunctionsGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MisUseAttack"></see>
    /// </summary>
    let MisUseAttack =
        Namespaced_IRI.parse _namespace_name "MisUseAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnTrustedAPIAttack"></see>
    /// </summary>
    let UnTrustedAPIAttack =
        Namespaced_IRI.parse _namespace_name "UnTrustedAPIAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobeyForum"></see>
    /// </summary>
    let MobeyForum = Namespaced_IRI.parse _namespace_name "MobeyForum" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mobile2Market"></see>
    /// </summary>
    let Mobile2Market =
        Namespaced_IRI.parse _namespace_name "Mobile2Market" |> NamespacedName

    /// <summary>
    /// Mobile network Cell ID to which the device is attached.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobileNetworkProvidervalues"></see></summary>
    let MobileNetworkProvidervalues =
        Namespaced_IRI.parse _namespace_name "MobileNetworkProvidervalues" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobileVPN"></see>
    /// </summary>
    let MobileVPN = Namespaced_IRI.parse _namespace_name "MobileVPN" |> NamespacedName
    /// <summary>
    /// Virtula private network. FIPS 140-2
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VPN"></see></summary>
    let VPN = Namespaced_IRI.parse _namespace_name "VPN" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MotorollaMobileVPN"></see>
    /// </summary>
    let MotorollaMobileVPN =
        Namespaced_IRI.parse _namespace_name "MotorollaMobileVPN" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mutual"></see>
    /// </summary>
    let Mutual = Namespaced_IRI.parse _namespace_name "Mutual" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MutualReliableChannel"></see>
    /// </summary>
    let MutualReliableChannel =
        Namespaced_IRI.parse _namespace_name "MutualReliableChannel" |> NamespacedName

    /// <summary>
    /// A short-range point-to-point wireless communication technology. The technology is a simple extension of the ISO/IEC 14443 proximity-card standard (contactless card, RFID) that combines the interface of a smartcard and a reader into a single device. An NFC device can communicate with both existing ISO/IEC 14443 smartcards and readers, as well as with other NFC devices, and is thereby compatible with existing contactless infrastructure already in use for public transportation and payment.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NFC"></see></summary>
    let NFC = Namespaced_IRI.parse _namespace_name "NFC" |> NamespacedName
    /// <summary>
    /// The device may be or not equiped with Near Field Communication Ship (NFC).
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NFCEnabled"></see></summary>
    let NFCEnabled = Namespaced_IRI.parse _namespace_name "NFCEnabled" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NIST"></see>
    /// </summary>
    let NIST = Namespaced_IRI.parse _namespace_name "NIST" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NeedhamShroeder"></see>
    /// </summary>
    let NeedhamShroeder =
        Namespaced_IRI.parse _namespace_name "NeedhamShroeder" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetworkLatency"></see>
    /// </summary>
    let hasNetworkLatency =
        Namespaced_IRI.parse _namespace_name "hasNetworkLatency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NetworkLayer"></see>
    /// </summary>
    let NetworkLayer =
        Namespaced_IRI.parse _namespace_name "NetworkLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityLayer"></see>
    /// </summary>
    let SecurityLayer =
        Namespaced_IRI.parse _namespace_name "SecurityLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NoAuthentication"></see>
    /// </summary>
    let NoAuthentication =
        Namespaced_IRI.parse _namespace_name "NoAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NoSensitiveInfoOnExternalMemory"></see>
    /// </summary>
    let NoSensitiveInfoOnExternalMemory =
        Namespaced_IRI.parse _namespace_name "NoSensitiveInfoOnExternalMemory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Nokia_Mobile_VPN"></see>
    /// </summary>
    let Nokia_Mobile_VPN =
        Namespaced_IRI.parse _namespace_name "Nokia_Mobile_VPN" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasType"></see>
    /// </summary>
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonVolatile"></see>
    /// </summary>
    let NonVolatile =
        Namespaced_IRI.parse _namespace_name "NonVolatile" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Password"></see>
    /// </summary>
    let Password = Namespaced_IRI.parse _namespace_name "Password" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OperationMode"></see>
    /// </summary>
    let OperationMode =
        Namespaced_IRI.parse _namespace_name "OperationMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OneSideVerification"></see>
    /// </summary>
    let OneSideVerification =
        Namespaced_IRI.parse _namespace_name "OneSideVerification" |> NamespacedName

    /// <summary>
    /// Telecom Network Operator knowing as MNO
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Operator"></see></summary>
    let Operator = Namespaced_IRI.parse _namespace_name "Operator" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OperatorCertificate"></see>
    /// </summary>
    let OperatorCertificate =
        Namespaced_IRI.parse _namespace_name "OperatorCertificate" |> NamespacedName

    /// <summary>
    /// A smart card is any limited-sized card with embedded integrated circuits. The smart card may integrate or not processing capabilities.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCard"></see></summary>
    let SmartCard = Namespaced_IRI.parse _namespace_name "SmartCard" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#storedOn"></see>
    /// </summary>
    let storedOn = Namespaced_IRI.parse _namespace_name "storedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PGPCertificate"></see>
    /// </summary>
    let PGPCertificate =
        Namespaced_IRI.parse _namespace_name "PGPCertificate" |> NamespacedName

    /// <summary>
    /// Personal Identification Number
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PIN"></see></summary>
    let PIN = Namespaced_IRI.parse _namespace_name "PIN" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardLock"></see>
    /// </summary>
    let SmartCardLock =
        Namespaced_IRI.parse _namespace_name "SmartCardLock" |> NamespacedName

    /// <summary>
    /// Public-key infrastructure (PKI) consists of protocols, services, and standards supporting applications of public-key cryptography. PKI sometimes refers simply to a trust hierarchy based on public-key certificates, and in other contexts embraces encryption and digital signature services provided to end-user applications as well. RSA (http://www.rsa.com/rsalabs/node.asp?id=2268)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PKI"></see></summary>
    let PKI = Namespaced_IRI.parse _namespace_name "PKI" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityInfrastructure"></see>
    /// </summary>
    let SecurityInfrastructure =
        Namespaced_IRI.parse _namespace_name "SecurityInfrastructure" |> NamespacedName

    /// <summary>
    /// Pseudo Random Number Generation
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PRNG"></see></summary>
    let PRNG = Namespaced_IRI.parse _namespace_name "PRNG" |> NamespacedName
    /// <summary>
    /// Personal Unblocking Keys
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PUK"></see></summary>
    let PUK = Namespaced_IRI.parse _namespace_name "PUK" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PassiveThreat"></see>
    /// </summary>
    let PassiveThreat =
        Namespaced_IRI.parse _namespace_name "PassiveThreat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Performance"></see>
    /// </summary>
    let Performance =
        Namespaced_IRI.parse _namespace_name "Performance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Phishing"></see>
    /// </summary>
    let Phishing = Namespaced_IRI.parse _namespace_name "Phishing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PhysicalLayer"></see>
    /// </summary>
    let PhysicalLayer =
        Namespaced_IRI.parse _namespace_name "PhysicalLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Poor"></see>
    /// </summary>
    let Poor = Namespaced_IRI.parse _namespace_name "Poor" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Quality"></see>
    /// </summary>
    let Quality = Namespaced_IRI.parse _namespace_name "Quality" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PreemptDisplay"></see>
    /// </summary>
    let PreemptDisplay =
        Namespaced_IRI.parse _namespace_name "PreemptDisplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Prevention"></see>
    /// </summary>
    let Prevention = Namespaced_IRI.parse _namespace_name "Prevention" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PrivateKeyPoP"></see>
    /// </summary>
    let PrivateKeyPoP =
        Namespaced_IRI.parse _namespace_name "PrivateKeyPoP" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Public"></see>
    /// </summary>
    let Public = Namespaced_IRI.parse _namespace_name "Public" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RAM"></see>
    /// </summary>
    let RAM = Namespaced_IRI.parse _namespace_name "RAM" |> NamespacedName
    /// <summary>
    /// A free algorithm provided by  RSA security, implemented since 1970.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RC4"></see></summary>
    let RC4 = Namespaced_IRI.parse _namespace_name "RC4" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StreamCipherAlgorithm"></see>
    /// </summary>
    let StreamCipherAlgorithm =
        Namespaced_IRI.parse _namespace_name "StreamCipherAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RF"></see>
    /// </summary>
    let RF = Namespaced_IRI.parse _namespace_name "RF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RIPE-MAC"></see>
    /// </summary>
    let ``RIPE-MAC`` = Namespaced_IRI.parse _namespace_name "RIPE-MAC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RIPE-MD"></see>
    /// </summary>
    let ``RIPE-MD`` = Namespaced_IRI.parse _namespace_name "RIPE-MD" |> NamespacedName
    /// <summary>
    /// Record Management Store are data structure used to store JME data
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RMS"></see></summary>
    let RMS = Namespaced_IRI.parse _namespace_name "RMS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ROM"></see>
    /// </summary>
    let ROM = Namespaced_IRI.parse _namespace_name "ROM" |> NamespacedName
    /// <summary>
    /// RSA signature algorithm (American National Standard ANSI X9-31)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RSA"></see></summary>
    let RSA = Namespaced_IRI.parse _namespace_name "RSA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RSAAlgorithm"></see>
    /// </summary>
    let RSAAlgorithm =
        Namespaced_IRI.parse _namespace_name "RSAAlgorithm" |> NamespacedName

    /// <summary>
    /// Read User Data: Set of permissions to read user’s data like phone book or calendar entries
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ReadUserDataFunctionGroup"></see></summary>
    let ReadUserDataFunctionGroup =
        Namespaced_IRI.parse _namespace_name "ReadUserDataFunctionGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Recovery"></see>
    /// </summary>
    let Recovery = Namespaced_IRI.parse _namespace_name "Recovery" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ReduceCodeSize"></see>
    /// </summary>
    let ReduceCodeSize =
        Namespaced_IRI.parse _namespace_name "ReduceCodeSize" |> NamespacedName

    /// <summary>
    /// Registration authority is an administrative entity which is responsable of verifying the identity of the claimer of a certificate
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RegistrationAuthority"></see></summary>
    let RegistrationAuthority =
        Namespaced_IRI.parse _namespace_name "RegistrationAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Reliability"></see>
    /// </summary>
    let Reliability =
        Namespaced_IRI.parse _namespace_name "Reliability" |> NamespacedName

    /// <summary>
    /// Sending a Short message to lock the device
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RemoteDeviceLock"></see></summary>
    let RemoteDeviceLock =
        Namespaced_IRI.parse _namespace_name "RemoteDeviceLock" |> NamespacedName

    /// <summary>
    /// Audio files used as rings in mobile devices.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RingTones"></see></summary>
    let RingTones = Namespaced_IRI.parse _namespace_name "RingTones" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StandardFiles"></see>
    /// </summary>
    let StandardFiles =
        Namespaced_IRI.parse _namespace_name "StandardFiles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SANS_Institute"></see>
    /// </summary>
    let SANS_Institute =
        Namespaced_IRI.parse _namespace_name "SANS_Institute" |> NamespacedName

    /// <summary>
    /// Secure Electronic Transaction
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SET"></see></summary>
    let SET = Namespaced_IRI.parse _namespace_name "SET" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SHA1"></see>
    /// </summary>
    let SHA1 = Namespaced_IRI.parse _namespace_name "SHA1" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SHAMIR3Pass"></see>
    /// </summary>
    let SHAMIR3Pass =
        Namespaced_IRI.parse _namespace_name "SHAMIR3Pass" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SKID"></see>
    /// </summary>
    let SKID = Namespaced_IRI.parse _namespace_name "SKID" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SMS"></see>
    /// </summary>
    let SMS = Namespaced_IRI.parse _namespace_name "SMS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SNOW"></see>
    /// </summary>
    let SNOW = Namespaced_IRI.parse _namespace_name "SNOW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SSL"></see>
    /// </summary>
    let SSL = Namespaced_IRI.parse _namespace_name "SSL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#STRANDOM"></see>
    /// </summary>
    let STRANDOM = Namespaced_IRI.parse _namespace_name "STRANDOM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Secret"></see>
    /// </summary>
    let Secret = Namespaced_IRI.parse _namespace_name "Secret" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityTools"></see>
    /// </summary>
    let SecurityTools =
        Namespaced_IRI.parse _namespace_name "SecurityTools" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SemanticIntegrity"></see>
    /// </summary>
    let SemanticIntegrity =
        Namespaced_IRI.parse _namespace_name "SemanticIntegrity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SeparateDelivery-DRM"></see>
    /// </summary>
    let ``SeparateDelivery-DRM`` =
        Namespaced_IRI.parse _namespace_name "SeparateDelivery-DRM" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Session"></see>
    /// </summary>
    let Session = Namespaced_IRI.parse _namespace_name "Session" |> NamespacedName
    /// <summary>
    /// Additional skills that should be acquired to achieve some tasks or goals.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Skills"></see></summary>
    let Skills = Namespaced_IRI.parse _namespace_name "Skills" |> NamespacedName

    /// <summary>
    /// Also known as conventional, secret-key, and single-key algorithms; the encryption and decryption key are either the same or can be calculated from one another. Block ciphers and stream ciphers are both used for symmetric encryption.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricEncryption"></see></summary>
    let SymmetricEncryption =
        Namespaced_IRI.parse _namespace_name "SymmetricEncryption" |> NamespacedName

    /// <summary>
    /// Memory available on smart card like SIM, USIM or others;
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardMemory"></see></summary>
    let SmartCardMemory =
        Namespaced_IRI.parse _namespace_name "SmartCardMemory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIMSI"></see>
    /// </summary>
    let hasIMSI = Namespaced_IRI.parse _namespace_name "hasIMSI" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardCloning"></see>
    /// </summary>
    let SmartCardCloning =
        Namespaced_IRI.parse _namespace_name "SmartCardCloning" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Socket"></see>
    /// </summary>
    let Socket = Namespaced_IRI.parse _namespace_name "Socket" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SoftwareLayer"></see>
    /// </summary>
    let SoftwareLayer =
        Namespaced_IRI.parse _namespace_name "SoftwareLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Speaker"></see>
    /// </summary>
    let Speaker = Namespaced_IRI.parse _namespace_name "Speaker" |> NamespacedName

    /// <summary>
    /// The standard couple of login and password authentication
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Static_password"></see></summary>
    let Static_password =
        Namespaced_IRI.parse _namespace_name "Static_password" |> NamespacedName

    /// <summary>
    /// Steganography is the art and science of writing hidden messages in such a way that no-one, apart from the sender and intended recipient, suspects the existence of the message, a form of security through obscurity. Wikipedia
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Steganography"></see></summary>
    let Steganography =
        Namespaced_IRI.parse _namespace_name "Steganography" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SteganographyAlgorithm"></see>
    /// </summary>
    let SteganographyAlgorithm =
        Namespaced_IRI.parse _namespace_name "SteganographyAlgorithm" |> NamespacedName

    /// <summary>
    /// Data stored either in the device or on the memory card.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StoredData"></see></summary>
    let StoredData = Namespaced_IRI.parse _namespace_name "StoredData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDataStructure"></see>
    /// </summary>
    let hasDataStructure =
        Namespaced_IRI.parse _namespace_name "hasDataStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymbianSigned"></see>
    /// </summary>
    let SymbianSigned =
        Namespaced_IRI.parse _namespace_name "SymbianSigned" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasKey"></see>
    /// </summary>
    let hasKey = Namespaced_IRI.parse _namespace_name "hasKey" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricKeyPoP"></see>
    /// </summary>
    let SymmetricKeyPoP =
        Namespaced_IRI.parse _namespace_name "SymmetricKeyPoP" |> NamespacedName

    /// <summary>
    /// Transport Layer Security is an IETF standard that is intended to replace the SSL protocol. (IETF Working Group)
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TLS"></see></summary>
    let TLS = Namespaced_IRI.parse _namespace_name "TLS" |> NamespacedName
    /// <summary>
    /// True Random Number Generation : extract randomness from physical phenomena and introduce it into computing device.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TRNG"></see></summary>
    let TRNG = Namespaced_IRI.parse _namespace_name "TRNG" |> NamespacedName
    /// <summary>
    /// All limitations related to technologies like the network bandwidth or processor capabilities.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Technical"></see></summary>
    let Technical = Namespaced_IRI.parse _namespace_name "Technical" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TestOnRealDevices"></see>
    /// </summary>
    let TestOnRealDevices =
        Namespaced_IRI.parse _namespace_name "TestOnRealDevices" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TestPhase"></see>
    /// </summary>
    let TestPhase = Namespaced_IRI.parse _namespace_name "TestPhase" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Time"></see>
    /// </summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeAnalysis"></see>
    /// </summary>
    let TimeAnalysis =
        Namespaced_IRI.parse _namespace_name "TimeAnalysis" |> NamespacedName

    /// <summary>
    /// A client and server time synchronization is required for the authentication token verification.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeBasedOTP"></see></summary>
    let TimeBasedOTP =
        Namespaced_IRI.parse _namespace_name "TimeBasedOTP" |> NamespacedName

    /// <summary>
    /// A digital signature that makes possible the verification of the sending time of a message.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeStampToken"></see></summary>
    let TimeStampToken =
        Namespaced_IRI.parse _namespace_name "TimeStampToken" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Timeliness"></see>
    /// </summary>
    let Timeliness = Namespaced_IRI.parse _namespace_name "Timeliness" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TopSecret"></see>
    /// </summary>
    let TopSecret = Namespaced_IRI.parse _namespace_name "TopSecret" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TouchScreen"></see>
    /// </summary>
    let TouchScreen =
        Namespaced_IRI.parse _namespace_name "TouchScreen" |> NamespacedName

    /// <summary>
    /// Requirement for additional training to use some tools or to do some technalical or management tasks.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Training"></see></summary>
    let Training = Namespaced_IRI.parse _namespace_name "Training" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Transaction"></see>
    /// </summary>
    let Transaction =
        Namespaced_IRI.parse _namespace_name "Transaction" |> NamespacedName

    /// <summary>
    /// Messaging data or data transferred through Internet connection
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TransmittedData"></see></summary>
    let TransmittedData =
        Namespaced_IRI.parse _namespace_name "TransmittedData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedAPIAttack"></see>
    /// </summary>
    let TrustedAPIAttack =
        Namespaced_IRI.parse _namespace_name "TrustedAPIAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedThirdPartyCertificate"></see>
    /// </summary>
    let TrustedThirdPartyCertificate =
        Namespaced_IRI.parse _namespace_name "TrustedThirdPartyCertificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TunneledPassword"></see>
    /// </summary>
    let TunneledPassword =
        Namespaced_IRI.parse _namespace_name "TunneledPassword" |> NamespacedName

    /// <summary>
    /// Don't mix type safe and type-unsafe API
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TypeSafe-Unsafe"></see></summary>
    let ``TypeSafe-Unsafe`` =
        Namespaced_IRI.parse _namespace_name "TypeSafe-Unsafe" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TypeSafeAPIUse"></see>
    /// </summary>
    let TypeSafeAPIUse =
        Namespaced_IRI.parse _namespace_name "TypeSafeAPIUse" |> NamespacedName

    /// <summary>
    /// The UICC is a generic platform for smart card applications. It has been standardised by ETSI EP SCP (ETSI Project Smart Card Platform) with the aim of defining a physical and logical platform for all smart card applications and to develop advanced security methods for financial transactions, to take an example. Mobey forum
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UICC"></see></summary>
    let UICC = Namespaced_IRI.parse _namespace_name "UICC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UMTS"></see>
    /// </summary>
    let UMTS = Namespaced_IRI.parse _namespace_name "UMTS" |> NamespacedName
    /// <summary>
    /// A (U)SIM is a special type of smart card that typically contains a processor and between 16 to 128 KB of persistent Electronically Erasable, Programmable ROM (EEPROM). It also includes RAM for program execution and ROM for the operating system, user authentication and data encryption algorithms, and other applications.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#USIM"></see></summary>
    let USIM = Namespaced_IRI.parse _namespace_name "USIM" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnifiedTestingInitiativeRootCertificate"></see>
    /// </summary>
    let UnifiedTestingInitiativeRootCertificate =
        Namespaced_IRI.parse _namespace_name "UnifiedTestingInitiativeRootCertificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnsafeDataTypeAttack"></see>
    /// </summary>
    let UnsafeDataTypeAttack =
        Namespaced_IRI.parse _namespace_name "UnsafeDataTypeAttack" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UsePhase"></see>
    /// </summary>
    let UsePhase = Namespaced_IRI.parse _namespace_name "UsePhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VeriSignTesting-BasedACSRootSymbian"></see>
    /// </summary>
    let ``VeriSignTesting-BasedACSRootSymbian`` =
        Namespaced_IRI.parse _namespace_name "VeriSignTesting-BasedACSRootSymbian" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#X509Certificate"></see>
    /// </summary>
    let X509Certificate =
        Namespaced_IRI.parse _namespace_name "X509Certificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Verisign"></see>
    /// </summary>
    let Verisign = Namespaced_IRI.parse _namespace_name "Verisign" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VibrationKit"></see>
    /// </summary>
    let VibrationKit =
        Namespaced_IRI.parse _namespace_name "VibrationKit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VideoInput"></see>
    /// </summary>
    let VideoInput = Namespaced_IRI.parse _namespace_name "VideoInput" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Videos"></see>
    /// </summary>
    let Videos = Namespaced_IRI.parse _namespace_name "Videos" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Voice"></see>
    /// </summary>
    let Voice = Namespaced_IRI.parse _namespace_name "Voice" |> NamespacedName
    /// <summary>
    /// Wireless Public Key Infrastructure.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WPKI"></see></summary>
    let WPKI = Namespaced_IRI.parse _namespace_name "WPKI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WiFi"></see>
    /// </summary>
    let WiFi = Namespaced_IRI.parse _namespace_name "WiFi" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WithoutVerification"></see>
    /// </summary>
    let WithoutVerification =
        Namespaced_IRI.parse _namespace_name "WithoutVerification" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Yahalom"></see>
    /// </summary>
    let Yahalom = Namespaced_IRI.parse _namespace_name "Yahalom" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Yarrow"></see>
    /// </summary>
    let Yarrow = Namespaced_IRI.parse _namespace_name "Yarrow" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ZeroKnowledgePassword"></see>
    /// </summary>
    let ZeroKnowledgePassword =
        Namespaced_IRI.parse _namespace_name "ZeroKnowledgePassword" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasCardType"></see>
    /// </summary>
    let hasCardType =
        Namespaced_IRI.parse _namespace_name "hasCardType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetworkBandwidth"></see>
    /// </summary>
    let hasNetworkBandwidth =
        Namespaced_IRI.parse _namespace_name "hasNetworkBandwidth" |> NamespacedName

    /// <summary>
    /// A Threat type may be a passive or an active threat.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasThreatType"></see></summary>
    let hasThreatType =
        Namespaced_IRI.parse _namespace_name "hasThreatType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#isUsedAt"></see>
    /// </summary>
    let isUsedAt = Namespaced_IRI.parse _namespace_name "isUsedAt" |> NamespacedName
    /// <summary>
    /// vCard is a virtual electronic business card format.
    /// <see href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#vCard"></see></summary>
    let vCard = Namespaced_IRI.parse _namespace_name "vCard" |> NamespacedName
