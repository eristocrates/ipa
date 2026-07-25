namespace http.www.semanticweb.org.ontologies._2008._11.OntologySecurity.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ontosec =
    let _namespace_iri = Namespace_Iri ontosec |> NamespaceIRI
    /// <summary>
    ///   <para>ontosec:FunctionGroups</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of sensitive functions under a named group that can get authorization.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FunctionGroups">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FunctionGroups</seealso>
    let FunctionGroups = Prefixed_Name(ontosec, "FunctionGroups") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Parallel</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OperationMode</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Parallel">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Parallel</seealso>
    let Parallel = Prefixed_Name(ontosec, "Parallel") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:CardMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CardMemory">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CardMemory</seealso>
    let CardMemory = Prefixed_Name(ontosec, "CardMemory") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AuthenticationToken</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationToken">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationToken</seealso>
    let AuthenticationToken =
        Prefixed_Name(ontosec, "AuthenticationToken") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AutoInvocationFunctionGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:FunctionGroups</para>
    ///   <para>Permissions related to automatically starting a MIDlet, for example by Push Registration.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AutoInvocationFunctionGroup">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AutoInvocationFunctionGroup</seealso>
    let AutoInvocationFunctionGroup =
        Prefixed_Name(ontosec, "AutoInvocationFunctionGroup") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Duration">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Duration</seealso>
    let Duration = Prefixed_Name(ontosec, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Training</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Requirement for additional training to use some tools or to do some technalical or management tasks.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Training">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Training</seealso>
    let Training = Prefixed_Name(ontosec, "Training") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Offline</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OperationMode</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Offline">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Offline</seealso>
    let Offline = Prefixed_Name(ontosec, "Offline") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SD</para>
    /// </summary>
    /// <remarks>
    ///   <para>Multi Media Card</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SD">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SD</seealso>
    let SD = Prefixed_Name(ontosec, "SD") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:AnalysisPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AnalysisPhase">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AnalysisPhase</seealso>
    let AnalysisPhase = Prefixed_Name(ontosec, "AnalysisPhase") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Data">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Data</seealso>
    let Data = Prefixed_Name(ontosec, "Data") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ValueTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Additional and required types for the ontology</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ValueTypes">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ValueTypes</seealso>
    let ValueTypes = Prefixed_Name(ontosec, "ValueTypes") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:AppliedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AppliedTo">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AppliedTo</seealso>
    let AppliedTo = Prefixed_Name(ontosec, "AppliedTo") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AsymmetricAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AsymmetricAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AsymmetricAlgorithm</seealso>
    let AsymmetricAlgorithm =
        Prefixed_Name(ontosec, "AsymmetricAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Quality">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Quality</seealso>
    let Quality = Prefixed_Name(ontosec, "Quality") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:PreemptDisplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:LockingScreen</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PreemptDisplay">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PreemptDisplay</seealso>
    let PreemptDisplay = Prefixed_Name(ontosec, "PreemptDisplay") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:RC4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A free algorithm provided by  RSA security, implemented since 1970.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RC4">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RC4</seealso>
    let RC4 = Prefixed_Name(ontosec, "RC4") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:StreamCipherAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StreamCipherAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StreamCipherAlgorithm</seealso>
    let StreamCipherAlgorithm =
        Prefixed_Name(ontosec, "StreamCipherAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:RF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RF">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RF</seealso>
    let RF = Prefixed_Name(ontosec, "RF") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ROM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ROM">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ROM</seealso>
    let ROM = Prefixed_Name(ontosec, "ROM") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:RSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>RSA signature algorithm (American National Standard ANSI X9-31)</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RSA">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RSA</seealso>
    let RSA = Prefixed_Name(ontosec, "RSA") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ReduceCodeSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ReduceCodeSize">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ReduceCodeSize</seealso>
    let ReduceCodeSize = Prefixed_Name(ontosec, "ReduceCodeSize") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:RegistrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Registration authority is an administrative entity which is responsable of verifying the identity of the claimer of a certificate</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RegistrationAuthority">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RegistrationAuthority</seealso>
    let RegistrationAuthority =
        Prefixed_Name(ontosec, "RegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Reliability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Reliability">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Reliability</seealso>
    let Reliability = Prefixed_Name(ontosec, "Reliability") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SHA1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SHA1">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SHA1</seealso>
    let SHA1 = Prefixed_Name(ontosec, "SHA1") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SHAMIR3Pass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SHAMIR3Pass">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SHAMIR3Pass</seealso>
    let SHAMIR3Pass = Prefixed_Name(ontosec, "SHAMIR3Pass") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SKID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SKID">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SKID</seealso>
    let SKID = Prefixed_Name(ontosec, "SKID") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SMS">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SMS</seealso>
    let SMS = Prefixed_Name(ontosec, "SMS") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SNOW</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SNOW">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SNOW</seealso>
    let SNOW = Prefixed_Name(ontosec, "SNOW") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SSL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SSL">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SSL</seealso>
    let SSL = Prefixed_Name(ontosec, "SSL") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Secret</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:ConfidentialityLevel</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Secret">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Secret</seealso>
    let Secret = Prefixed_Name(ontosec, "Secret") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SecurityTools</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityTools">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityTools</seealso>
    let SecurityTools = Prefixed_Name(ontosec, "SecurityTools") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:SeparateDelivery-DRM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SeparateDelivery-DRM">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SeparateDelivery-DRM</seealso>
    let SeparateDelivery_DRM =
        Prefixed_Name(ontosec, "SeparateDelivery-DRM") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Session</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Session">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Session</seealso>
    let Session = Prefixed_Name(ontosec, "Session") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Skills</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Additional skills that should be acquired to achieve some tasks or goals.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Skills">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Skills</seealso>
    let Skills = Prefixed_Name(ontosec, "Skills") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SmartCardMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Memory available on smart card like SIM, USIM or others;</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardMemory">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardMemory</seealso>
    let SmartCardMemory = Prefixed_Name(ontosec, "SmartCardMemory") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasIMSI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIMSI">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIMSI</seealso>
    let hasIMSI = Prefixed_Name(ontosec, "hasIMSI") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SmartCardCloning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardCloning">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardCloning</seealso>
    let SmartCardCloning = Prefixed_Name(ontosec, "SmartCardCloning") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SoftwareLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SoftwareLayer">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SoftwareLayer</seealso>
    let SoftwareLayer = Prefixed_Name(ontosec, "SoftwareLayer") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Speaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Speaker">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Speaker</seealso>
    let Speaker = Prefixed_Name(ontosec, "Speaker") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Static_password</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The standard couple of login and password authentication</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Static_password">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Static_password</seealso>
    let Static_password = Prefixed_Name(ontosec, "Static_password") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Steganography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Steganography is the art and science of writing hidden messages in such a way that no-one, apart from the sender and intended recipient, suspects the existence of the message, a form of security through obscurity. Wikipedia</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Steganography">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Steganography</seealso>
    let Steganography = Prefixed_Name(ontosec, "Steganography") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:SteganographyAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SteganographyAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SteganographyAlgorithm</seealso>
    let SteganographyAlgorithm =
        Prefixed_Name(ontosec, "SteganographyAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:hasDataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDataStructure">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDataStructure</seealso>
    let hasDataStructure = Prefixed_Name(ontosec, "hasDataStructure") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SymbianSigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:CertificationAuthority</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymbianSigned">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymbianSigned</seealso>
    let SymbianSigned = Prefixed_Name(ontosec, "SymbianSigned") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasKey">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasKey</seealso>
    let hasKey = Prefixed_Name(ontosec, "hasKey") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Technical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>All limitations related to technologies like the network bandwidth or processor capabilities.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Technical">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Technical</seealso>
    let Technical = Prefixed_Name(ontosec, "Technical") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TestOnRealDevices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TestOnRealDevices">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TestOnRealDevices</seealso>
    let TestOnRealDevices = Prefixed_Name(ontosec, "TestOnRealDevices") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TestPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TestPhase">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TestPhase</seealso>
    let TestPhase = Prefixed_Name(ontosec, "TestPhase") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Time">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Time</seealso>
    let Time = Prefixed_Name(ontosec, "Time") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TimeAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeAnalysis">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeAnalysis</seealso>
    let TimeAnalysis = Prefixed_Name(ontosec, "TimeAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:CertificateInstallation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateInstallation">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateInstallation</seealso>
    let CertificateInstallation =
        Prefixed_Name(ontosec, "CertificateInstallation") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Add-OnMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Add-OnMemory">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Add-OnMemory</seealso>
    let Add_OnMemory = Prefixed_Name(ontosec, "Add-OnMemory") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Cost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Time, skills, additional equipments are considered as cost constraints</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Cost">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Cost</seealso>
    let Cost = Prefixed_Name(ontosec, "Cost") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Algorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Algorithm</seealso>
    let Algorithm = Prefixed_Name(ontosec, "Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Mechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Security mechanisms used for security services</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mechanism">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mechanism</seealso>
    let Mechanism = Prefixed_Name(ontosec, "Mechanism") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>All the applications and data provided with or installed on the device.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Software">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Software</seealso>
    let Software = Prefixed_Name(ontosec, "Software") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ApplicationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationData">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationData</seealso>
    let ApplicationData = Prefixed_Name(ontosec, "ApplicationData") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Backup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Backup">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Backup</seealso>
    let Backup = Prefixed_Name(ontosec, "Backup") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ImplementMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementMechanism">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementMechanism</seealso>
    let ImplementMechanism =
        Prefixed_Name(ontosec, "ImplementMechanism") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Confidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The confidentiality service</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Confidentiality">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Confidentiality</seealso>
    let Confidentiality = Prefixed_Name(ontosec, "Confidentiality") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ActiveThreat</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:ThreatType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ActiveThreat">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ActiveThreat</seealso>
    let ActiveThreat = Prefixed_Name(ontosec, "ActiveThreat") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Actors participating in the realisation and implementation of security services</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Actor">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Actor</seealso>
    let Actor = Prefixed_Name(ontosec, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Memory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Memory">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Memory</seealso>
    let Memory = Prefixed_Name(ontosec, "Memory") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AdministrativeProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tasks to be performed and which are out of the scope of the technical field.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AdministrativeProcedure">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AdministrativeProcedure</seealso>
    let AdministrativeProcedure =
        Prefixed_Name(ontosec, "AdministrativeProcedure") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The software device platform layer</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Platform">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Platform</seealso>
    let Platform = Prefixed_Name(ontosec, "Platform") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:WANetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WANetwork">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WANetwork</seealso>
    let WANetwork = Prefixed_Name(ontosec, "WANetwork") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:BlockCipherAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BlockCipherAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BlockCipherAlgorithm</seealso>
    let BlockCipherAlgorithm =
        Prefixed_Name(ontosec, "BlockCipherAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AES</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AES">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AES</seealso>
    let AES = Prefixed_Name(ontosec, "AES") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:AES_FIPS197</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:AES</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AES_FIPS197">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AES_FIPS197</seealso>
    let AES_FIPS197 = Prefixed_Name(ontosec, "AES_FIPS197") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Satisfice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Satisfice">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Satisfice</seealso>
    let Satisfice = Prefixed_Name(ontosec, "Satisfice") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MACAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message authentication code that include a key for authentication</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MACAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MACAlgorithm</seealso>
    let MACAlgorithm = Prefixed_Name(ontosec, "MACAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MD2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD2">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD2</seealso>
    let MD2 = Prefixed_Name(ontosec, "MD2") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MD4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD4">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD4</seealso>
    let MD4 = Prefixed_Name(ontosec, "MD4") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MD5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD5">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MD5</seealso>
    let MD5 = Prefixed_Name(ontosec, "MD5") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MULTOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:CardType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MULTOS">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MULTOS</seealso>
    let MULTOS = Prefixed_Name(ontosec, "MULTOS") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Mail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mail">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mail</seealso>
    let Mail = Prefixed_Name(ontosec, "Mail") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ManufacturerCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ManufacturerCertificate">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ManufacturerCertificate</seealso>
    let ManufacturerCertificate =
        Prefixed_Name(ontosec, "ManufacturerCertificate") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:PUK</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:SmartCardLock</para>
    ///   <para>Personal Unblocking Keys</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PUK">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PUK</seealso>
    let PUK = Prefixed_Name(ontosec, "PUK") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:PhysicalLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PhysicalLayer">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PhysicalLayer</seealso>
    let PhysicalLayer = Prefixed_Name(ontosec, "PhysicalLayer") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Poor</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:RNGEfficiency</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Poor">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Poor</seealso>
    let Poor = Prefixed_Name(ontosec, "Poor") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Prevention</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:MechanismType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Prevention">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Prevention</seealso>
    let Prevention = Prefixed_Name(ontosec, "Prevention") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:PrivateKeyPoP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PrivateKeyPoP">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PrivateKeyPoP</seealso>
    let PrivateKeyPoP = Prefixed_Name(ontosec, "PrivateKeyPoP") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Public</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:ConfidentialityLevel</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Public">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Public</seealso>
    let Public = Prefixed_Name(ontosec, "Public") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:RAM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RAM">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RAM</seealso>
    let RAM = Prefixed_Name(ontosec, "RAM") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:RIPE-MD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RIPE-MD">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RIPE-MD</seealso>
    let RIPE_MD = Prefixed_Name(ontosec, "RIPE-MD") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:RMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:DataRecords</para>
    ///   <para>Record Management Store are data structure used to store JME data</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RMS">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RMS</seealso>
    let RMS = Prefixed_Name(ontosec, "RMS") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:RSAAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RSAAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RSAAlgorithm</seealso>
    let RSAAlgorithm = Prefixed_Name(ontosec, "RSAAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ReadUserDataFunctionGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:FunctionGroups</para>
    ///   <para>Read User Data: Set of permissions to read user’s data like phone book or calendar entries</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ReadUserDataFunctionGroup">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ReadUserDataFunctionGroup</seealso>
    let ReadUserDataFunctionGroup =
        Prefixed_Name(ontosec, "ReadUserDataFunctionGroup") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:RingTones</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Audio files used as rings in mobile devices.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RingTones">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RingTones</seealso>
    let RingTones = Prefixed_Name(ontosec, "RingTones") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:StandardFiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StandardFiles">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StandardFiles</seealso>
    let StandardFiles = Prefixed_Name(ontosec, "StandardFiles") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SANS_Institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OrganizationsAndStandards</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SANS_Institute">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SANS_Institute</seealso>
    let SANS_Institute = Prefixed_Name(ontosec, "SANS_Institute") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:2G</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#2G">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#2G</seealso>
    let _2G = Prefixed_Name(ontosec, "2G") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:AccessControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControl">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControl</seealso>
    let AccessControl = Prefixed_Name(ontosec, "AccessControl") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AccessControlMethods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControlMethods">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControlMethods</seealso>
    let AccessControlMethods =
        Prefixed_Name(ontosec, "AccessControlMethods") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:CoreCounterMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CoreCounterMeasure">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CoreCounterMeasure</seealso>
    let CoreCounterMeasure =
        Prefixed_Name(ontosec, "CoreCounterMeasure") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Checksum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Checksum">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Checksum</seealso>
    let Checksum = Prefixed_Name(ontosec, "Checksum") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:CodeSeparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Locate and isolate critical code from from general code.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CodeSeparation">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CodeSeparation</seealso>
    let CodeSeparation = Prefixed_Name(ontosec, "CodeSeparation") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:CommChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CommChannel">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CommChannel</seealso>
    let CommChannel = Prefixed_Name(ontosec, "CommChannel") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:CompactFlash</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:CardMemory</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CompactFlash">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CompactFlash</seealso>
    let CompactFlash = Prefixed_Name(ontosec, "CompactFlash") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:3DES</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3DES">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3DES</seealso>
    let _3DES = Prefixed_Name(ontosec, "3DES") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasPadding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasPadding">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasPadding</seealso>
    let hasPadding = Prefixed_Name(ontosec, "hasPadding") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasChainingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasChainingMode">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasChainingMode</seealso>
    let hasChainingMode = Prefixed_Name(ontosec, "hasChainingMode") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:HasBlockSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasBlockSize">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasBlockSize</seealso>
    let HasBlockSize = Prefixed_Name(ontosec, "HasBlockSize") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:PANetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PANetwork">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PANetwork</seealso>
    let PANetwork = Prefixed_Name(ontosec, "PANetwork") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:CBC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CBC">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CBC</seealso>
    let CBC = Prefixed_Name(ontosec, "CBC") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:CBC-MAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The simplest way to make a key-dependent one-way hash function is to encrypt a message with a block algorithm in CBC or CFB modes . The hash is the last encrypted block, encrypted once more in CBC or CFB modes.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CBC-MAC">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CBC-MAC</seealso>
    let CBC_MAC = Prefixed_Name(ontosec, "CBC-MAC") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:CFB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CFB">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CFB</seealso>
    let CFB = Prefixed_Name(ontosec, "CFB") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:COMSET</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#COMSET">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#COMSET</seealso>
    let COMSET = Prefixed_Name(ontosec, "COMSET") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:DigitalSignatureAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalSignatureAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalSignatureAlgorithm</seealso>
    let DigitalSignatureAlgorithm =
        Prefixed_Name(ontosec, "DigitalSignatureAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:hasDigitalSignatureData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDigitalSignatureData">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDigitalSignatureData</seealso>
    let hasDigitalSignatureData =
        Prefixed_Name(ontosec, "hasDigitalSignatureData") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:MMC</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:CardMemory</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MMC">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MMC</seealso>
    let MMC = Prefixed_Name(ontosec, "MMC") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ontosec:CommChannel</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MMS">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MMS</seealso>
    let MMS = Prefixed_Name(ontosec, "MMS") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasTrustIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasTrustIn">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasTrustIn</seealso>
    let hasTrustIn = Prefixed_Name(ontosec, "hasTrustIn") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Memorability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A limited period of time during which the use of the application will be memorised.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Memorability">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Memorability</seealso>
    let Memorability = Prefixed_Name(ontosec, "Memorability") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MemoryCardLock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Memory card can be protected with a password each time someone tries to access the card</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MemoryCardLock">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MemoryCardLock</seealso>
    let MemoryCardLock = Prefixed_Name(ontosec, "MemoryCardLock") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:MessagingFunctionsGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:FunctionGroups</para>
    ///   <para>Set of permissions related to sending or receiving messages like SMS</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MessagingFunctionsGroup">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MessagingFunctionsGroup</seealso>
    let MessagingFunctionsGroup =
        Prefixed_Name(ontosec, "MessagingFunctionsGroup") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:MisUseAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MisUseAttack">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MisUseAttack</seealso>
    let MisUseAttack = Prefixed_Name(ontosec, "MisUseAttack") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:UnTrustedAPIAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnTrustedAPIAttack">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnTrustedAPIAttack</seealso>
    let UnTrustedAPIAttack =
        Prefixed_Name(ontosec, "UnTrustedAPIAttack") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:MobileVPN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobileVPN">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobileVPN</seealso>
    let MobileVPN = Prefixed_Name(ontosec, "MobileVPN") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:VPN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Virtula private network. FIPS 140-2</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VPN">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VPN</seealso>
    let VPN = Prefixed_Name(ontosec, "VPN") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:MotorollaMobileVPN</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:MobileVPN</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MotorollaMobileVPN">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MotorollaMobileVPN</seealso>
    let MotorollaMobileVPN =
        Prefixed_Name(ontosec, "MotorollaMobileVPN") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Mutual</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:AuthenticationWay</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mutual">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mutual</seealso>
    let Mutual = Prefixed_Name(ontosec, "Mutual") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:OrganizationsAndStandards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Organizations and associations providing standards in the mobile field arena.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OrganizationsAndStandards">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OrganizationsAndStandards</seealso>
    let OrganizationsAndStandards =
        Prefixed_Name(ontosec, "OrganizationsAndStandards") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:WPKI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Wireless Public Key Infrastructure.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WPKI">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WPKI</seealso>
    let WPKI = Prefixed_Name(ontosec, "WPKI") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:WiFi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WiFi">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WiFi</seealso>
    let WiFi = Prefixed_Name(ontosec, "WiFi") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Standards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Standards">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Standards</seealso>
    let Standards = Prefixed_Name(ontosec, "Standards") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Resource">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Resource</seealso>
    let Resource = Prefixed_Name(ontosec, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:LocalDeviceLock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalDeviceLock">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalDeviceLock</seealso>
    let LocalDeviceLock = Prefixed_Name(ontosec, "LocalDeviceLock") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:LockingScreen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In some situations it is useful to lock the screen display until a task is terminated. This is technique is used to avoid the screen modification until a answer is received.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LockingScreen">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LockingScreen</seealso>
    let LockingScreen = Prefixed_Name(ontosec, "LockingScreen") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SecretKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecretKey">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecretKey</seealso>
    let SecretKey = Prefixed_Name(ontosec, "SecretKey") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasThreatType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A Threat type may be a passive or an active threat.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasThreatType">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasThreatType</seealso>
    let hasThreatType = Prefixed_Name(ontosec, "hasThreatType") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ThreatType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ThreatType">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ThreatType</seealso>
    let ThreatType = Prefixed_Name(ontosec, "ThreatType") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Application">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Application</seealso>
    let Application = Prefixed_Name(ontosec, "Application") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Journaling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Journaling">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Journaling</seealso>
    let Journaling = Prefixed_Name(ontosec, "Journaling") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The set of assets that should be protected</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Asset">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Asset</seealso>
    let Asset = Prefixed_Name(ontosec, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:PrivateKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PrivateKey">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PrivateKey</seealso>
    let PrivateKey = Prefixed_Name(ontosec, "PrivateKey") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Efficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Best use of the available resources.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Efficiency">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Efficiency</seealso>
    let Efficiency = Prefixed_Name(ontosec, "Efficiency") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Messaging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Messaging">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Messaging</seealso>
    let Messaging = Prefixed_Name(ontosec, "Messaging") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Recovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:MechanismType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Recovery">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Recovery</seealso>
    let Recovery = Prefixed_Name(ontosec, "Recovery") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:RemoteDeviceLock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sending a Short message to lock the device</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RemoteDeviceLock">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RemoteDeviceLock</seealso>
    let RemoteDeviceLock = Prefixed_Name(ontosec, "RemoteDeviceLock") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SET</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Secure Electronic Transaction</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SET">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SET</seealso>
    let SET = Prefixed_Name(ontosec, "SET") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:DigitalRightsManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A general framework for downloading Rights to Devices and sharing Rights in a domain. DRM is invented by the Open Mobile Alliance whose members are mobile phone manufacturers, mobile system manufacturers, operators , and sofware editors.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalRightsManagement">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalRightsManagement</seealso>
    let DigitalRightsManagement =
        Prefixed_Name(ontosec, "DigitalRightsManagement") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ConfigurationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Several configuration data are stored in the device or sent by the mobile operator.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ConfigurationData">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ConfigurationData</seealso>
    let ConfigurationData = Prefixed_Name(ontosec, "ConfigurationData") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Provide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Provide">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Provide</seealso>
    let Provide = Prefixed_Name(ontosec, "Provide") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MobeyForum</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OrganizationsAndStandards</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobeyForum">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobeyForum</seealso>
    let MobeyForum = Prefixed_Name(ontosec, "MobeyForum") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Mobile2Market</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:CertificationAuthority</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mobile2Market">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Mobile2Market</seealso>
    let Mobile2Market = Prefixed_Name(ontosec, "Mobile2Market") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:MobileNetworkProvidervalues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mobile network Cell ID to which the device is attached.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobileNetworkProvidervalues">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MobileNetworkProvidervalues</seealso>
    let MobileNetworkProvidervalues =
        Prefixed_Name(ontosec, "MobileNetworkProvidervalues") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:NFC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A short-range point-to-point wireless communication technology. The technology is a simple extension of the ISO/IEC 14443 proximity-card standard (contactless card, RFID) that combines the interface of a smartcard and a reader into a single device. An NFC device can communicate with both existing ISO/IEC 14443 smartcards and readers, as well as with other NFC devices, and is thereby compatible with existing contactless infrastructure already in use for public transportation and payment.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NFC">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NFC</seealso>
    let NFC = Prefixed_Name(ontosec, "NFC") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:NIST</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OrganizationsAndStandards</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NIST">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NIST</seealso>
    let NIST = Prefixed_Name(ontosec, "NIST") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasNetworkLatency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetworkLatency">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetworkLatency</seealso>
    let hasNetworkLatency = Prefixed_Name(ontosec, "hasNetworkLatency") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SecurityLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityLayer">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityLayer</seealso>
    let SecurityLayer = Prefixed_Name(ontosec, "SecurityLayer") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:NoAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:AuthenticationLevel</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NoAuthentication">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NoAuthentication</seealso>
    let NoAuthentication = Prefixed_Name(ontosec, "NoAuthentication") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:NonVolatile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonVolatile">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonVolatile</seealso>
    let NonVolatile = Prefixed_Name(ontosec, "NonVolatile") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:OperatorCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OperatorCertificate">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OperatorCertificate</seealso>
    let OperatorCertificate =
        Prefixed_Name(ontosec, "OperatorCertificate") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AdditionalTools</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>New tools that should be used for the projection or the application.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AdditionalTools">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AdditionalTools</seealso>
    let AdditionalTools = Prefixed_Name(ontosec, "AdditionalTools") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Android</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:Platform</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Android">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Android</seealso>
    let Android = Prefixed_Name(ontosec, "Android") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DES</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DES">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DES</seealso>
    let DES = Prefixed_Name(ontosec, "DES") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Detection</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:MechanismType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Detection">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Detection</seealso>
    let Detection = Prefixed_Name(ontosec, "Detection") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Keypad or any input tool</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Input">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Input</seealso>
    let Input = Prefixed_Name(ontosec, "Input") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasType">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasType</seealso>
    let hasType = Prefixed_Name(ontosec, "hasType") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:OneSideVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:AuthenticationLevel</para>
    ///   <para>ontosec:AuthenticationWay</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OneSideVerification">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OneSideVerification</seealso>
    let OneSideVerification =
        Prefixed_Name(ontosec, "OneSideVerification") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Telecom Network Operator knowing as MNO</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Operator">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Operator</seealso>
    let Operator = Prefixed_Name(ontosec, "Operator") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SmartCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A smart card is any limited-sized card with embedded integrated circuits. The smart card may integrate or not processing capabilities.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCard">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCard</seealso>
    let SmartCard = Prefixed_Name(ontosec, "SmartCard") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ApplicationLifeCyclePhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationLifeCyclePhase">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationLifeCyclePhase</seealso>
    let ApplicationLifeCyclePhase =
        Prefixed_Name(ontosec, "ApplicationLifeCyclePhase") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:CryptographicHashFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CryptographicHashFunction">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CryptographicHashFunction</seealso>
    let CryptographicHashFunction =
        Prefixed_Name(ontosec, "CryptographicHashFunction") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:DES_FIPS46-1-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:DES</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DES_FIPS46-1-2">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DES_FIPS46-1-2</seealso>
    let DES_FIPS46_1_2 = Prefixed_Name(ontosec, "DES_FIPS46-1-2") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mobile terminal equiped with processing capabilities offering  connection to wireless networks.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Device">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Device</seealso>
    let Device = Prefixed_Name(ontosec, "Device") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Network</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Network">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Network</seealso>
    let Network = Prefixed_Name(ontosec, "Network") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:NetworkLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NetworkLayer">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NetworkLayer</seealso>
    let NetworkLayer = Prefixed_Name(ontosec, "NetworkLayer") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:NoSensitiveInfoOnExternalMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NoSensitiveInfoOnExternalMemory">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NoSensitiveInfoOnExternalMemory</seealso>
    let NoSensitiveInfoOnExternalMemory =
        Prefixed_Name(ontosec, "NoSensitiveInfoOnExternalMemory") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Nokia_Mobile_VPN</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:VPN</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Nokia_Mobile_VPN">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Nokia_Mobile_VPN</seealso>
    let Nokia_Mobile_VPN = Prefixed_Name(ontosec, "Nokia_Mobile_VPN") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Password</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Password">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Password</seealso>
    let Password = Prefixed_Name(ontosec, "Password") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:OperationMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OperationMode">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#OperationMode</seealso>
    let OperationMode = Prefixed_Name(ontosec, "OperationMode") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:MutualReliableChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:AuthenticationLevel</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MutualReliableChannel">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MutualReliableChannel</seealso>
    let MutualReliableChannel =
        Prefixed_Name(ontosec, "MutualReliableChannel") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:NFCEnabled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The device may be or not equiped with Near Field Communication Ship (NFC).</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NFCEnabled">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NFCEnabled</seealso>
    let NFCEnabled = Prefixed_Name(ontosec, "NFCEnabled") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:NeedhamShroeder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NeedhamShroeder">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NeedhamShroeder</seealso>
    let NeedhamShroeder = Prefixed_Name(ontosec, "NeedhamShroeder") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ApplicationServerSide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The application server side may be a web server or a data base back end that the device connects to.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationServerSide">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ApplicationServerSide</seealso>
    let ApplicationServerSide =
        Prefixed_Name(ontosec, "ApplicationServerSide") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:DevelopmentTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Addiotional development time required for the application or the project.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DevelopmentTime">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DevelopmentTime</seealso>
    let DevelopmentTime = Prefixed_Name(ontosec, "DevelopmentTime") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasMemory">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasMemory</seealso>
    let hasMemory = Prefixed_Name(ontosec, "hasMemory") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetwork">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetwork</seealso>
    let hasNetwork = Prefixed_Name(ontosec, "hasNetwork") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasInput">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasInput</seealso>
    let hasInput = Prefixed_Name(ontosec, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DeviceLock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceLock">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceLock</seealso>
    let DeviceLock = Prefixed_Name(ontosec, "DeviceLock") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Output">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Output</seealso>
    let Output = Prefixed_Name(ontosec, "Output") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasOutput">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasOutput</seealso>
    let hasOutput = Prefixed_Name(ontosec, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:PIN</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:SmartCardLock</para>
    ///   <para>Personal Identification Number</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PIN">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PIN</seealso>
    let PIN = Prefixed_Name(ontosec, "PIN") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SmartCardLock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardLock">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SmartCardLock</seealso>
    let SmartCardLock = Prefixed_Name(ontosec, "SmartCardLock") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:storedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#storedOn">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#storedOn</seealso>
    let storedOn = Prefixed_Name(ontosec, "storedOn") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:PGPCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PGPCertificate">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PGPCertificate</seealso>
    let PGPCertificate = Prefixed_Name(ontosec, "PGPCertificate") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:PKI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Public-key infrastructure (PKI) consists of protocols, services, and standards supporting applications of public-key cryptography. PKI sometimes refers simply to a trust hierarchy based on public-key certificates, and in other contexts embraces encryption and digital signature services provided to end-user applications as well. RSA (http://www.rsa.com/rsalabs/node.asp?id=2268)</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PKI">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PKI</seealso>
    let PKI = Prefixed_Name(ontosec, "PKI") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:SecurityInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityInfrastructure">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecurityInfrastructure</seealso>
    let SecurityInfrastructure =
        Prefixed_Name(ontosec, "SecurityInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:PRNG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Pseudo Random Number Generation</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PRNG">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PRNG</seealso>
    let PRNG = Prefixed_Name(ontosec, "PRNG") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:PassiveThreat</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:ThreatType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PassiveThreat">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PassiveThreat</seealso>
    let PassiveThreat = Prefixed_Name(ontosec, "PassiveThreat") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Performance">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Performance</seealso>
    let Performance = Prefixed_Name(ontosec, "Performance") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Phishing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Phishing">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Phishing</seealso>
    let Phishing = Prefixed_Name(ontosec, "Phishing") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Relationship">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Relationship</seealso>
    let Relationship = Prefixed_Name(ontosec, "Relationship") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AssociatedOriented</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:NonRepudiationType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AssociatedOriented">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AssociatedOriented</seealso>
    let AssociatedOriented =
        Prefixed_Name(ontosec, "AssociatedOriented") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:PublicKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PublicKey">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PublicKey</seealso>
    let PublicKey = Prefixed_Name(ontosec, "PublicKey") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Use</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Use">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Use</seealso>
    let Use = Prefixed_Name(ontosec, "Use") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:PRNGAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Pseudo Random Number Generation algorithm</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PRNGAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#PRNGAlgorithm</seealso>
    let PRNGAlgorithm = Prefixed_Name(ontosec, "PRNGAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DigitalSignature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A digital signature is represented in a computer as a string of binary
    /// digits. A digital signature is computed using a set of rules and a set of parameters such that the identity of the signatory and integrity of the data can be verified. An algorithm provides the capability to generate and verify signatures. Signature generation makes use of a private key to generate a digital signature. Signature verification makes use of a public key which corresponds to, but is not the same as, the private key. (http://csrc.nist.gov/publications/fips/fips186-2/fips186-2-change1.pdf)</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalSignature">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DigitalSignature</seealso>
    let DigitalSignature = Prefixed_Name(ontosec, "DigitalSignature") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DisplayScreen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DisplayScreen">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DisplayScreen</seealso>
    let DisplayScreen = Prefixed_Name(ontosec, "DisplayScreen") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasScreenSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasScreenSize">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasScreenSize</seealso>
    let hasScreenSize = Prefixed_Name(ontosec, "hasScreenSize") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ECB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electronic code book</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ECB">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ECB</seealso>
    let ECB = Prefixed_Name(ontosec, "ECB") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:EDGE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enhanced Data rates for GSM Evolution</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EDGE">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EDGE</seealso>
    let EDGE = Prefixed_Name(ontosec, "EDGE") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:EMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enhanced Messaging Service - An improved message system for GSM mobile phones allowing picture, sound, animation and text elements to be conveyed through one or more concatenated SMS messages. NIST</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EMS">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EMS</seealso>
    let EMS = Prefixed_Name(ontosec, "EMS") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Usability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A good response time of the application.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Usability">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Usability</seealso>
    let Usability = Prefixed_Name(ontosec, "Usability") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ElGammelAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ElGammelAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ElGammelAlgorithm</seealso>
    let ElGammelAlgorithm = Prefixed_Name(ontosec, "ElGammelAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Email">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Email</seealso>
    let Email = Prefixed_Name(ontosec, "Email") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Internet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Internet">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Internet</seealso>
    let Internet = Prefixed_Name(ontosec, "Internet") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:EncryptionKeys</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The encryption keys are digital bitstrings that are stored in non-volatile memory, and verification of the identity proceeds by a challenge-response protocol.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EncryptionKeys">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EncryptionKeys</seealso>
    let EncryptionKeys = Prefixed_Name(ontosec, "EncryptionKeys") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Keys</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Keys">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Keys</seealso>
    let Keys = Prefixed_Name(ontosec, "Keys") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:EndToEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:NonRepudiationType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EndToEnd">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#EndToEnd</seealso>
    let EndToEnd = Prefixed_Name(ontosec, "EndToEnd") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Excellent</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:RNGEfficiency</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Excellent">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Excellent</seealso>
    let Excellent = Prefixed_Name(ontosec, "Excellent") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:RNGEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RNGEfficiency">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RNGEfficiency</seealso>
    let RNGEfficiency = Prefixed_Name(ontosec, "RNGEfficiency") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:IntegrityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IntegrityType">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IntegrityType</seealso>
    let IntegrityType = Prefixed_Name(ontosec, "IntegrityType") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:GPRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>General Packet Radio Service</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPRS">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPRS</seealso>
    let GPRS = Prefixed_Name(ontosec, "GPRS") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:GSM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Global System for Mobile communications</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSM">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSM</seealso>
    let GSM = Prefixed_Name(ontosec, "GSM") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:GSMA</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OrganizationsAndStandards</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSMA">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSMA</seealso>
    let GSMA = Prefixed_Name(ontosec, "GSMA") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:GSMWorld</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OrganizationsAndStandards</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSMWorld">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GSMWorld</seealso>
    let GSMWorld = Prefixed_Name(ontosec, "GSMWorld") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Hardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mainly the physical device with the embedded memory and processing units.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Hardware">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Hardware</seealso>
    let Hardware = Prefixed_Name(ontosec, "Hardware") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:HardwareLocking</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:AccessControlMethods</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HardwareLocking">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HardwareLocking</seealso>
    let HardwareLocking = Prefixed_Name(ontosec, "HardwareLocking") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:HasBandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasBandwidth">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasBandwidth</seealso>
    let HasBandwidth = Prefixed_Name(ontosec, "HasBandwidth") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Help</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Help">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Help</seealso>
    let Help = Prefixed_Name(ontosec, "Help") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:IEEE</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OrganizationsAndStandards</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IEEE">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IEEE</seealso>
    let IEEE = Prefixed_Name(ontosec, "IEEE") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:IETF</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OrganizationsAndStandards</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IETF">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IETF</seealso>
    let IETF = Prefixed_Name(ontosec, "IETF") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:IM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IM">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IM</seealso>
    let IM = Prefixed_Name(ontosec, "IM") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:IPSec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IPSec">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IPSec</seealso>
    let IPSec = Prefixed_Name(ontosec, "IPSec") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ITU</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OrganizationsAndStandards</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ITU">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ITU</seealso>
    let ITU = Prefixed_Name(ontosec, "ITU") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Images</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>All supported image files for mobile devices.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Images">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Images</seealso>
    let Images = Prefixed_Name(ontosec, "Images") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:IrDA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A standard for line-of-sight infrared communication between devices over short distances. NIST</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IrDA">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IrDA</seealso>
    let IrDA = Prefixed_Name(ontosec, "IrDA") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Issue">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Issue</seealso>
    let Issue = Prefixed_Name(ontosec, "Issue") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:J2ME</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#J2ME">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#J2ME</seealso>
    let J2ME = Prefixed_Name(ontosec, "J2ME") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:JME</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:Platform</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JME">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JME</seealso>
    let JME = Prefixed_Name(ontosec, "JME") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:JMEPermissionDomains</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:AccessControlList</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JMEPermissionDomains">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JMEPermissionDomains</seealso>
    let JMEPermissionDomains =
        Prefixed_Name(ontosec, "JMEPermissionDomains") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:SymmetricKeyPoP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricKeyPoP">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricKeyPoP</seealso>
    let SymmetricKeyPoP = Prefixed_Name(ontosec, "SymmetricKeyPoP") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TLS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Transport Layer Security is an IETF standard that is intended to replace the SSL protocol. (IETF Working Group)</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TLS">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TLS</seealso>
    let TLS = Prefixed_Name(ontosec, "TLS") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TRNG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>True Random Number Generation : extract randomness from physical phenomena and introduce it into computing device.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TRNG">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TRNG</seealso>
    let TRNG = Prefixed_Name(ontosec, "TRNG") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TimeBasedOTP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A client and server time synchronization is required for the authentication token verification.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeBasedOTP">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeBasedOTP</seealso>
    let TimeBasedOTP = Prefixed_Name(ontosec, "TimeBasedOTP") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TimeStampToken</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A digital signature that makes possible the verification of the sending time of a message.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeStampToken">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TimeStampToken</seealso>
    let TimeStampToken = Prefixed_Name(ontosec, "TimeStampToken") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Timeliness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Timeliness">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Timeliness</seealso>
    let Timeliness = Prefixed_Name(ontosec, "Timeliness") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TopSecret</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:ConfidentialityLevel</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TopSecret">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TopSecret</seealso>
    let TopSecret = Prefixed_Name(ontosec, "TopSecret") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TouchScreen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TouchScreen">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TouchScreen</seealso>
    let TouchScreen = Prefixed_Name(ontosec, "TouchScreen") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Transaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Transaction">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Transaction</seealso>
    let Transaction = Prefixed_Name(ontosec, "Transaction") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TransmittedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Messaging data or data transferred through Internet connection</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TransmittedData">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TransmittedData</seealso>
    let TransmittedData = Prefixed_Name(ontosec, "TransmittedData") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TrustedAPIAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedAPIAttack">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedAPIAttack</seealso>
    let TrustedAPIAttack = Prefixed_Name(ontosec, "TrustedAPIAttack") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:TrustedThirdPartyCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedThirdPartyCertificate">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedThirdPartyCertificate</seealso>
    let TrustedThirdPartyCertificate =
        Prefixed_Name(ontosec, "TrustedThirdPartyCertificate") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:TunneledPassword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TunneledPassword">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TunneledPassword</seealso>
    let TunneledPassword = Prefixed_Name(ontosec, "TunneledPassword") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TypeSafe-Unsafe</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:CodingStandards</para>
    ///   <para>Don't mix type safe and type-unsafe API</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TypeSafe-Unsafe">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TypeSafe-Unsafe</seealso>
    let TypeSafe_Unsafe = Prefixed_Name(ontosec, "TypeSafe-Unsafe") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:TypeSafeAPIUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TypeSafeAPIUse">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TypeSafeAPIUse</seealso>
    let TypeSafeAPIUse = Prefixed_Name(ontosec, "TypeSafeAPIUse") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:UICC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The UICC is a generic platform for smart card applications. It has been standardised by ETSI EP SCP (ETSI Project Smart Card Platform) with the aim of defining a physical and logical platform for all smart card applications and to develop advanced security methods for financial transactions, to take an example. Mobey forum</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UICC">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UICC</seealso>
    let UICC = Prefixed_Name(ontosec, "UICC") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:UsePhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UsePhase">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UsePhase</seealso>
    let UsePhase = Prefixed_Name(ontosec, "UsePhase") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:NonRepudiationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonRepudiationType">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonRepudiationType</seealso>
    let NonRepudiationType =
        Prefixed_Name(ontosec, "NonRepudiationType") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Hurt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Hurt">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Hurt</seealso>
    let Hurt = Prefixed_Name(ontosec, "Hurt") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AsymmetricEncryption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of encryption in which an encryption key (the public key) is used to encrypt a message, and another encryption key (the private key) is used to decrypt the message.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AsymmetricEncryption">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AsymmetricEncryption</seealso>
    let AsymmetricEncryption =
        Prefixed_Name(ontosec, "AsymmetricEncryption") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:KeyExchangeProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyExchangeProtocol">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyExchangeProtocol</seealso>
    let KeyExchangeProtocol =
        Prefixed_Name(ontosec, "KeyExchangeProtocol") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Encryption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discipline which embodies principles, means, and methods for the transformation of data in order to hide its information content, prevent its undetected modification and/or prevent its unauthorised use. (CCITT)</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Encryption">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Encryption</seealso>
    let Encryption = Prefixed_Name(ontosec, "Encryption") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AuthenticationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationLevel">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationLevel</seealso>
    let AuthenticationLevel =
        Prefixed_Name(ontosec, "AuthenticationLevel") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:hasLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasLevel">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasLevel</seealso>
    let hasLevel = Prefixed_Name(ontosec, "hasLevel") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:hasAuthenticationProtocolType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasAuthenticationProtocolType">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasAuthenticationProtocolType</seealso>
    let hasAuthenticationProtocolType =
        Prefixed_Name(ontosec, "hasAuthenticationProtocolType") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:HTTP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HTTP">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HTTP</seealso>
    let HTTP = Prefixed_Name(ontosec, "HTTP") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:HTTPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HTTPS">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HTTPS</seealso>
    let HTTPS = Prefixed_Name(ontosec, "HTTPS") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:HasIterationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasIterationNumber">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasIterationNumber</seealso>
    let HasIterationNumber =
        Prefixed_Name(ontosec, "HasIterationNumber") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:HasKeySize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasKeySize">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasKeySize</seealso>
    let HasKeySize = Prefixed_Name(ontosec, "HasKeySize") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:HashBasedOTP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A server side list of hashed tokens is stored and each consumed token is removed from the list.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HashBasedOTP">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HashBasedOTP</seealso>
    let HashBasedOTP = Prefixed_Name(ontosec, "HashBasedOTP") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ImplementAPI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementAPI">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementAPI</seealso>
    let ImplementAPI = Prefixed_Name(ontosec, "ImplementAPI") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ImplementationPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementationPhase">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ImplementationPhase</seealso>
    let ImplementationPhase =
        Prefixed_Name(ontosec, "ImplementationPhase") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:IntensifyCriticalCodeReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IntensifyCriticalCodeReview">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IntensifyCriticalCodeReview</seealso>
    let IntensifyCriticalCodeReview =
        Prefixed_Name(ontosec, "IntensifyCriticalCodeReview") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:JavaVerifiedSigningProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:SourceCodeVerification</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JavaVerifiedSigningProcess">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JavaVerifiedSigningProcess</seealso>
    let JavaVerifiedSigningProcess =
        Prefixed_Name(ontosec, "JavaVerifiedSigningProcess") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:SourceCodeVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SourceCodeVerification">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SourceCodeVerification</seealso>
    let SourceCodeVerification =
        Prefixed_Name(ontosec, "SourceCodeVerification") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Kerberos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kerberos is an authentication process that proceeds as follows: A client sends a request to the authentication server (AS) requesting "credentials" for a given server.  The AS responds with these credentials,  encrypted in the client's key.  The credentials consist of 1) a "ticket" for the server and 2) a temporary encryption key ( a "session key").  The client transmits the ticket (which contains the client's identity and a copy of the session key, all encrypted in the server's key) to the server.  The session key (now shared by the client and server) is used to authenticate the client, and may optionally be used to authenticate the server.  It may also be used to encrypt further communication between the two parties or to exchange a separate sub-session key to be used to encrypt further communication. RFC 1510</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Kerberos">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Kerberos</seealso>
    let Kerberos = Prefixed_Name(ontosec, "Kerberos") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:KeyGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyGeneration">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyGeneration</seealso>
    let KeyGeneration = Prefixed_Name(ontosec, "KeyGeneration") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasRNGEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasRNGEfficiency">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasRNGEfficiency</seealso>
    let hasRNGEfficiency = Prefixed_Name(ontosec, "hasRNGEfficiency") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:KeyPad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyPad">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyPad</seealso>
    let KeyPad = Prefixed_Name(ontosec, "KeyPad") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Store</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Store">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Store</seealso>
    let Store = Prefixed_Name(ontosec, "Store") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:UnifiedTestingInitiativeRootCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnifiedTestingInitiativeRootCertificate">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnifiedTestingInitiativeRootCertificate</seealso>
    let UnifiedTestingInitiativeRootCertificate =
        Prefixed_Name(ontosec, "UnifiedTestingInitiativeRootCertificate") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:UnsafeDataTypeAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnsafeDataTypeAttack">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UnsafeDataTypeAttack</seealso>
    let UnsafeDataTypeAttack =
        Prefixed_Name(ontosec, "UnsafeDataTypeAttack") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:VeriSignTesting-BasedACSRootSymbian</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:X509Certificate</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VeriSignTesting-BasedACSRootSymbian">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VeriSignTesting-BasedACSRootSymbian</seealso>
    let VeriSignTesting_BasedACSRootSymbian =
        Prefixed_Name(ontosec, "VeriSignTesting-BasedACSRootSymbian") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:X509Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#X509Certificate">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#X509Certificate</seealso>
    let X509Certificate = Prefixed_Name(ontosec, "X509Certificate") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Verisign</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:CertificationAuthority</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Verisign">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Verisign</seealso>
    let Verisign = Prefixed_Name(ontosec, "Verisign") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:VibrationKit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VibrationKit">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VibrationKit</seealso>
    let VibrationKit = Prefixed_Name(ontosec, "VibrationKit") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:VideoInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VideoInput">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#VideoInput</seealso>
    let VideoInput = Prefixed_Name(ontosec, "VideoInput") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Videos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Videos">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Videos</seealso>
    let Videos = Prefixed_Name(ontosec, "Videos") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Voice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Voice">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Voice</seealso>
    let Voice = Prefixed_Name(ontosec, "Voice") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:WithoutVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:AuthenticationLevel</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WithoutVerification">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#WithoutVerification</seealso>
    let WithoutVerification =
        Prefixed_Name(ontosec, "WithoutVerification") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Yahalom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Yahalom">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Yahalom</seealso>
    let Yahalom = Prefixed_Name(ontosec, "Yahalom") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Yarrow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Yarrow">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Yarrow</seealso>
    let Yarrow = Prefixed_Name(ontosec, "Yarrow") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ZeroKnowledgePassword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ZeroKnowledgePassword">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ZeroKnowledgePassword</seealso>
    let ZeroKnowledgePassword =
        Prefixed_Name(ontosec, "ZeroKnowledgePassword") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:hasCardType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasCardType">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasCardType</seealso>
    let hasCardType = Prefixed_Name(ontosec, "hasCardType") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:hasNetworkBandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetworkBandwidth">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasNetworkBandwidth</seealso>
    let hasNetworkBandwidth =
        Prefixed_Name(ontosec, "hasNetworkBandwidth") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:isUsedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#isUsedAt">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#isUsedAt</seealso>
    let isUsedAt = Prefixed_Name(ontosec, "isUsedAt") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:vCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>vCard is a virtual electronic business card format.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#vCard">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#vCard</seealso>
    let vCard = Prefixed_Name(ontosec, "vCard") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:STRANDOM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#STRANDOM">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#STRANDOM</seealso>
    let STRANDOM = Prefixed_Name(ontosec, "STRANDOM") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DotNet</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:Platform</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DotNet">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DotNet</seealso>
    let DotNet = Prefixed_Name(ontosec, "DotNet") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ECDSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Elliptic Curve Digital Signature Algorithm (ECDSA) (ANSI X9-62)</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ECDSA">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ECDSA</seealso>
    let ECDSA = Prefixed_Name(ontosec, "ECDSA") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:RIPE-MAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RIPE-MAC">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#RIPE-MAC</seealso>
    let RIPE_MAC = Prefixed_Name(ontosec, "RIPE-MAC") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Authentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Authentication">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Authentication</seealso>
    let Authentication = Prefixed_Name(ontosec, "Authentication") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SemanticIntegrity</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:IntegrityType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SemanticIntegrity">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SemanticIntegrity</seealso>
    let SemanticIntegrity = Prefixed_Name(ontosec, "SemanticIntegrity") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:SymmetricEncryption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Also known as conventional, secret-key, and single-key algorithms; the encryption and decryption key are either the same or can be calculated from one another. Block ciphers and stream ciphers are both used for symmetric encryption.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricEncryption">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricEncryption</seealso>
    let SymmetricEncryption =
        Prefixed_Name(ontosec, "SymmetricEncryption") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AuthenticationProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationProtocol">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationProtocol</seealso>
    let AuthenticationProtocol =
        Prefixed_Name(ontosec, "AuthenticationProtocol") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:IndustrialProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IndustrialProtocol">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#IndustrialProtocol</seealso>
    let IndustrialProtocol =
        Prefixed_Name(ontosec, "IndustrialProtocol") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:InteractionModes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>User interaction to confirm the execution of some senstive actions like sending a sms or opening a network connection/</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#InteractionModes">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#InteractionModes</seealso>
    let InteractionModes = Prefixed_Name(ontosec, "InteractionModes") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:JavaCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:CardType</para>
    ///   <para>ontosec:SIM</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JavaCard">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#JavaCard</seealso>
    let JavaCard = Prefixed_Name(ontosec, "JavaCard") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:SIM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Subscriber Identity Module; A smart card for GSM networks access.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SIM">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SIM</seealso>
    let SIM = Prefixed_Name(ontosec, "SIM") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:KeyExchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyExchange">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyExchange</seealso>
    let KeyExchange = Prefixed_Name(ontosec, "KeyExchange") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:KeyManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The process and procedure for safely storing and distributing accurate cryptographic keys; the overall process of generating and distributing cryptographic key to authorized recipients in a secure manner.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyManagement">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyManagement</seealso>
    let KeyManagement = Prefixed_Name(ontosec, "KeyManagement") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasRNGDeterminism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasRNGDeterminism">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasRNGDeterminism</seealso>
    let hasRNGDeterminism = Prefixed_Name(ontosec, "hasRNGDeterminism") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:UMTS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UMTS">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#UMTS</seealso>
    let UMTS = Prefixed_Name(ontosec, "UMTS") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:USIM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A (U)SIM is a special type of smart card that typically contains a processor and between 16 to 128 KB of persistent Electronically Erasable, Programmable ROM (EEPROM). It also includes RAM for program execution and ROM for the operating system, user authentication and data encryption algorithms, and other applications.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#USIM">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#USIM</seealso>
    let USIM = Prefixed_Name(ontosec, "USIM") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DomainEntities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DomainEntities">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DomainEntities</seealso>
    let DomainEntities = Prefixed_Name(ontosec, "DomainEntities") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:FTP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FTP">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FTP</seealso>
    let FTP = Prefixed_Name(ontosec, "FTP") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:FixedMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FixedMemory">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FixedMemory</seealso>
    let FixedMemory = Prefixed_Name(ontosec, "FixedMemory") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:FullIntegrity</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:IntegrityType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FullIntegrity">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#FullIntegrity</seealso>
    let FullIntegrity = Prefixed_Name(ontosec, "FullIntegrity") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:GPSNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A system for determining position by comparing radio signals from several satellites. NIST</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPSNetwork">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPSNetwork</seealso>
    let GPSNetwork = Prefixed_Name(ontosec, "GPSNetwork") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:GPSvalues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Global positioning system coordinates used by some applications.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPSvalues">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GPSvalues</seealso>
    let GPSvalues = Prefixed_Name(ontosec, "GPSvalues") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:GuessingAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GuessingAttack">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#GuessingAttack</seealso>
    let GuessingAttack = Prefixed_Name(ontosec, "GuessingAttack") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:SecureNetworkCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecureNetworkCommunication">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SecureNetworkCommunication</seealso>
    let SecureNetworkCommunication =
        Prefixed_Name(ontosec, "SecureNetworkCommunication") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:O.T.P</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Password used for once and generated from time, counter and/or key. May be a displayed from a hardware device.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#O.T.P">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#O.T.P</seealso>
    let ``O.T.P`` = Prefixed_Name(ontosec, "O.T.P") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ForwardLock-DRM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ForwardLock-DRM">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ForwardLock-DRM</seealso>
    let ForwardLock_DRM = Prefixed_Name(ontosec, "ForwardLock-DRM") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:LocalisationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalisationData">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalisationData</seealso>
    let LocalisationData = Prefixed_Name(ontosec, "LocalisationData") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:HMAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HMAC">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HMAC</seealso>
    let HMAC = Prefixed_Name(ontosec, "HMAC") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:AuthenticationProtocolType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationProtocolType">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationProtocolType</seealso>
    let AuthenticationProtocolType =
        Prefixed_Name(ontosec, "AuthenticationProtocolType") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Socket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Socket">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Socket</seealso>
    let Socket = Prefixed_Name(ontosec, "Socket") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:StoredData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data stored either in the device or on the memory card.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StoredData">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#StoredData</seealso>
    let StoredData = Prefixed_Name(ontosec, "StoredData") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:AuthenticationWay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationWay">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AuthenticationWay</seealso>
    let AuthenticationWay = Prefixed_Name(ontosec, "AuthenticationWay") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Techniques</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Techniques">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Techniques</seealso>
    let Techniques = Prefixed_Name(ontosec, "Techniques") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ResourceMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ResourceMonitoring">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ResourceMonitoring</seealso>
    let ResourceMonitoring =
        Prefixed_Name(ontosec, "ResourceMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:BiometricIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Biometric identifier is one of the most secure and more reliable ways to authenticate a person’s identity is to verify that person’s innate biological characteristics, which are referred to as biometrics. Each person’s fingerprints, DNA, iris and retinal cell patterns, facial geometry, and heat signature are near unique to that person. These biometric measures, if properly recorded, validated, and embedded in identity credentials that are logically bound to a single person’s identity, can provide the highest degree of identity authentication (From NIST information security Report)</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BiometricIdentifier">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BiometricIdentifier</seealso>
    let BiometricIdentifier =
        Prefixed_Name(ontosec, "BiometricIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ChainingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ChainingMode">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ChainingMode</seealso>
    let ChainingMode = Prefixed_Name(ontosec, "ChainingMode") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:hasInitialisationVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasInitialisationVector">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasInitialisationVector</seealso>
    let hasInitialisationVector =
        Prefixed_Name(ontosec, "hasInitialisationVector") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:SymmetricAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#SymmetricAlgorithm</seealso>
    let SymmetricAlgorithm =
        Prefixed_Name(ontosec, "SymmetricAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Blowfish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Blowfish">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Blowfish</seealso>
    let Blowfish = Prefixed_Name(ontosec, "Blowfish") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Bluetooth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Bluetooth is a Personal Area Network (PAN) standard that enables wireless connections between electronic devices in the 2.4 GHz range over short distances, as an alternative to cables. Designed to be power efficient, Bluetooth has become a common feature in cell phones. Since wireless communications are inherently insecure, a number of basic security provisions have been defined for this standard to mitigate the risks involved. NIST</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Bluetooth">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Bluetooth</seealso>
    let Bluetooth = Prefixed_Name(ontosec, "Bluetooth") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Break</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Break">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Break</seealso>
    let Break = Prefixed_Name(ontosec, "Break") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:QualitySatisfaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#QualitySatisfaction">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#QualitySatisfaction</seealso>
    let QualitySatisfaction =
        Prefixed_Name(ontosec, "QualitySatisfaction") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ByPassingTrialCounter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ByPassingTrialCounter">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ByPassingTrialCounter</seealso>
    let ByPassingTrialCounter =
        Prefixed_Name(ontosec, "ByPassingTrialCounter") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:CardType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CardType">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CardType</seealso>
    let CardType = Prefixed_Name(ontosec, "CardType") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Certificate">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Certificate</seealso>
    let Certificate = Prefixed_Name(ontosec, "Certificate") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:hasSignatureAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasSignatureAlgorithm">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasSignatureAlgorithm</seealso>
    let hasSignatureAlgorithm =
        Prefixed_Name(ontosec, "hasSignatureAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:hasSubjectName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasSubjectName">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasSubjectName</seealso>
    let hasSubjectName = Prefixed_Name(ontosec, "hasSubjectName") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIssuer">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIssuer</seealso>
    let hasIssuer = Prefixed_Name(ontosec, "hasIssuer") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:DeviceCapabilities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceCapabilities">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceCapabilities</seealso>
    let DeviceCapabilities =
        Prefixed_Name(ontosec, "DeviceCapabilities") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:TrustedThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>security authority or its agent, trusted by other entities with respect to security-related activities. In the context of ISO/IEC 9798, a trusted third party is trusted by a claimant and/or a verifier for the purposes of authentication.  ISO/IEC 9798</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedThirdParty">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#TrustedThirdParty</seealso>
    let TrustedThirdParty = Prefixed_Name(ontosec, "TrustedThirdParty") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ChallengeReplyPassword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ChallengeReplyPassword">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ChallengeReplyPassword</seealso>
    let ChallengeReplyPassword =
        Prefixed_Name(ontosec, "ChallengeReplyPassword") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:CodingStandards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Deploy development regimes such as coding standards and documentation methodologies to lead to best practises</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CodingStandards">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CodingStandards</seealso>
    let CodingStandards = Prefixed_Name(ontosec, "CodingStandards") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:CombinedDelivery-DRM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CombinedDelivery-DRM">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CombinedDelivery-DRM</seealso>
    let CombinedDelivery_DRM =
        Prefixed_Name(ontosec, "CombinedDelivery-DRM") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:ConfidentialityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ConfidentialityLevel">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ConfidentialityLevel</seealso>
    let ConfidentialityLevel =
        Prefixed_Name(ontosec, "ConfidentialityLevel") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Constraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Technical, quality constraints and others</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Constraints">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Constraints</seealso>
    let Constraints = Prefixed_Name(ontosec, "Constraints") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:ContentProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The entity who is responsable of providing content like ringing tones or multimedia files or any other software.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ContentProvider">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#ContentProvider</seealso>
    let ContentProvider = Prefixed_Name(ontosec, "ContentProvider") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Correction</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:MechanismType</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Correction">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Correction</seealso>
    let Correction = Prefixed_Name(ontosec, "Correction") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MechanismType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MechanismType">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MechanismType</seealso>
    let MechanismType = Prefixed_Name(ontosec, "MechanismType") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Critical</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:ConfidentialityLevel</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Critical">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Critical</seealso>
    let Critical = Prefixed_Name(ontosec, "Critical") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:HasOutputLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasOutputLength">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#HasOutputLength</seealso>
    let HasOutputLength = Prefixed_Name(ontosec, "HasOutputLength") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MessageDigest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function that takes a string (or message) of any length as input and produces a fixed-length string as output,it is used for authentication and message integrity.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MessageDigest">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MessageDigest</seealso>
    let MessageDigest = Prefixed_Name(ontosec, "MessageDigest") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DDos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Distributed denial of service.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DDos">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DDos</seealso>
    let DDos = Prefixed_Name(ontosec, "DDos") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DIFFIE-HELLMAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DIFFIE-HELLMAN">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DIFFIE-HELLMAN</seealso>
    let DIFFIE_HELLMAN = Prefixed_Name(ontosec, "DIFFIE-HELLMAN") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Digital Signature Algorithm specified by FIPS 186-2</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DSA">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DSA</seealso>
    let DSA = Prefixed_Name(ontosec, "DSA") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DataRecords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Some applications use records files to store data.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DataRecords">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DataRecords</seealso>
    let DataRecords = Prefixed_Name(ontosec, "DataRecords") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:LocalFiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalFiles">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalFiles</seealso>
    let LocalFiles = Prefixed_Name(ontosec, "LocalFiles") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DeploymentPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeploymentPhase">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeploymentPhase</seealso>
    let DeploymentPhase = Prefixed_Name(ontosec, "DeploymentPhase") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DesignPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DesignPhase">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DesignPhase</seealso>
    let DesignPhase = Prefixed_Name(ontosec, "DesignPhase") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:LogInSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LogInSystem">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LogInSystem</seealso>
    let LogInSystem = Prefixed_Name(ontosec, "LogInSystem") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasIMEI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIMEI">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasIMEI</seealso>
    let hasIMEI = Prefixed_Name(ontosec, "hasIMEI") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Processing">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Processing</seealso>
    let Processing = Prefixed_Name(ontosec, "Processing") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasProcessing">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasProcessing</seealso>
    let hasProcessing = Prefixed_Name(ontosec, "hasProcessing") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:DeviceCloning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceCloning">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceCloning</seealso>
    let DeviceCloning = Prefixed_Name(ontosec, "DeviceCloning") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:DeviceDriverUpgrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One problem in this area is that drivers are typically written by third parties and drivers are upgraded at different times to the main OS. This causes problems when implementing any validation scheme, or even isolated checking of specific software updates</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceDriverUpgrade">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#DeviceDriverUpgrade</seealso>
    let DeviceDriverUpgrade =
        Prefixed_Name(ontosec, "DeviceDriverUpgrade") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:LockingMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LockingMechanism">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LockingMechanism</seealso>
    let LockingMechanism = Prefixed_Name(ontosec, "LockingMechanism") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:NonRepudiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonRepudiation">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NonRepudiation</seealso>
    let NonRepudiation = Prefixed_Name(ontosec, "NonRepudiation") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Availability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Availability">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Availability</seealso>
    let Availability = Prefixed_Name(ontosec, "Availability") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:KeyStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyStore">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#KeyStore</seealso>
    let KeyStore = Prefixed_Name(ontosec, "KeyStore") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasKeyLifeTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasKeyLifeTime">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasKeyLifeTime</seealso>
    let hasKeyLifeTime = Prefixed_Name(ontosec, "hasKeyLifeTime") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:LANetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LANetwork">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LANetwork</seealso>
    let LANetwork = Prefixed_Name(ontosec, "LANetwork") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Learnability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Easy to learn how to use the application.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Learnability">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Learnability</seealso>
    let Learnability = Prefixed_Name(ontosec, "Learnability") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:LocalDataBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Special database management systems for embedded applications.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalDataBase">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#LocalDataBase</seealso>
    let LocalDataBase = Prefixed_Name(ontosec, "LocalDataBase") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDuration">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasDuration</seealso>
    let hasDuration = Prefixed_Name(ontosec, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:BatteryMonitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BatteryMonitor">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BatteryMonitor</seealso>
    let BatteryMonitor = Prefixed_Name(ontosec, "BatteryMonitor") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:BestPractises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BestPractises">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#BestPractises</seealso>
    let BestPractises = Prefixed_Name(ontosec, "BestPractises") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Portability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ability of Application running on several devices or/and platforms.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Portability">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Portability</seealso>
    let Portability = Prefixed_Name(ontosec, "Portability") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:NetAccessFunctionGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>Contains permissions related to network data connections.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NetAccessFunctionGroup">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#NetAccessFunctionGroup</seealso>
    let NetAccessFunctionGroup =
        Prefixed_Name(ontosec, "NetAccessFunctionGroup") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:CertificateInstallationApplication</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateInstallationApplication">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateInstallationApplication</seealso>
    let CertificateInstallationApplication =
        Prefixed_Name(ontosec, "CertificateInstallationApplication") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:2.5G</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#2.5G">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#2.5G</seealso>
    let ``_2.5G`` = Prefixed_Name(ontosec, "2.5G") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:3G</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3G">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3G</seealso>
    let _3G = Prefixed_Name(ontosec, "3G") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:3GPP</para>
    /// </summary>
    /// <remarks>
    ///   <para>ontosec:OrganizationsAndStandards</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3GPP">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#3GPP</seealso>
    let _3GPP = Prefixed_Name(ontosec, "3GPP") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:AccessControlList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>List of permissions attached to an object.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControlList">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#AccessControlList</seealso>
    let AccessControlList = Prefixed_Name(ontosec, "AccessControlList") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Integrity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Integrity">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Integrity</seealso>
    let Integrity = Prefixed_Name(ontosec, "Integrity") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasValidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasValidity">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasValidity</seealso>
    let hasValidity = Prefixed_Name(ontosec, "hasValidity") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:CertificateFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateFormat">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificateFormat</seealso>
    let CertificateFormat = Prefixed_Name(ontosec, "CertificateFormat") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:hasFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasFormat">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#hasFormat</seealso>
    let hasFormat = Prefixed_Name(ontosec, "hasFormat") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:CertificationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The certification authority provides certificates to bind a set of informations (name, serial number, ...) to a public key.</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificationAuthority">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#CertificationAuthority</seealso>
    let CertificationAuthority =
        Prefixed_Name(ontosec, "CertificationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>ontosec:Manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Manual">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Manual</seealso>
    let Manual = Prefixed_Name(ontosec, "Manual") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:MaintenancePhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MaintenancePhase">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#MaintenancePhase</seealso>
    let MaintenancePhase = Prefixed_Name(ontosec, "MaintenancePhase") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Make</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Make">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Make</seealso>
    let Make = Prefixed_Name(ontosec, "Make") |> PrefixedName
    /// <summary>
    ///   <para>ontosec:Manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mobile device manufacturer which may implement some security features in the device</para>
    /// </remarks>
    /// <seealso href="http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Manufacturer">http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#Manufacturer</seealso>
    let Manufacturer = Prefixed_Name(ontosec, "Manufacturer") |> PrefixedName
