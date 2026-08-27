namespace http.www.w3.org.ns.spec.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spec =
    let _namespace_iri = Namespace_Iri spec |> NamespaceIRI
    /// <summary>
    ///   <para>spec:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Spec Terms"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#">http://www.w3.org/ns/spec#</seealso>
    let _prefix_iri = Prefixed_Name(spec, "") |> PrefixedName
    /// <summary>
    ///   <para>spec:API</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#API">http://www.w3.org/ns/spec#API</seealso>
    let API = Prefixed_Name(spec, "API") |> PrefixedName

    /// <summary>
    ///   <para>spec:AccessibilityConsiderations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Accessibility Considerations"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#AccessibilityConsiderations">http://www.w3.org/ns/spec#AccessibilityConsiderations</seealso>
    let AccessibilityConsiderations =
        Prefixed_Name(spec, "AccessibilityConsiderations") |> PrefixedName

    /// <summary>
    ///   <para>spec:Advisement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Advisement"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Advisement">http://www.w3.org/ns/spec#Advisement</seealso>
    let Advisement = Prefixed_Name(spec, "Advisement") |> PrefixedName
    /// <summary>
    ///   <para>spec:AdvisementLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#AdvisementLevel">http://www.w3.org/ns/spec#AdvisementLevel</seealso>
    let AdvisementLevel = Prefixed_Name(spec, "AdvisementLevel") |> PrefixedName
    /// <summary>
    ///   <para>spec:Can</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Can">http://www.w3.org/ns/spec#Can</seealso>
    let Can = Prefixed_Name(spec, "Can") |> PrefixedName
    /// <summary>
    ///   <para>spec:Cannot</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Cannot">http://www.w3.org/ns/spec#Cannot</seealso>
    let Cannot = Prefixed_Name(spec, "Cannot") |> PrefixedName
    /// <summary>
    ///   <para>spec:Change</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Change"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Change">http://www.w3.org/ns/spec#Change</seealso>
    let Change = Prefixed_Name(spec, "Change") |> PrefixedName
    /// <summary>
    ///   <para>spec:Changelog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Changelog"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Changelog">http://www.w3.org/ns/spec#Changelog</seealso>
    let Changelog = Prefixed_Name(spec, "Changelog") |> PrefixedName
    /// <summary>
    ///   <para>spec:ClassesOfProducts</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#ClassesOfProducts">http://www.w3.org/ns/spec#ClassesOfProducts</seealso>
    let ClassesOfProducts = Prefixed_Name(spec, "ClassesOfProducts") |> PrefixedName
    /// <summary>
    ///   <para>spec:Client</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Client">http://www.w3.org/ns/spec#Client</seealso>
    let Client = Prefixed_Name(spec, "Client") |> PrefixedName
    /// <summary>
    ///   <para>spec:Conformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Conformance"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Conformance">http://www.w3.org/ns/spec#Conformance</seealso>
    let Conformance = Prefixed_Name(spec, "Conformance") |> PrefixedName

    /// <summary>
    ///   <para>spec:ConformanceFunctionalLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Functional levels — or in common usage simply levels — are used to group functionality into nested subsets, ranging from minimal or core functionality to full or complete functionally. Level 1 is the minimum or core of the technology. Level 2 includes all of level 1 plus additional functionality. This nesting continues until level n, which consists of the entire technology."</para>
    /// labels<para>"Functional level"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#ConformanceFunctionalLevel">http://www.w3.org/ns/spec#ConformanceFunctionalLevel</seealso>
    let ConformanceFunctionalLevel =
        Prefixed_Name(spec, "ConformanceFunctionalLevel") |> PrefixedName

    /// <summary>
    ///   <para>spec:ConformanceModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Modules are discrete divisions or functional groupings of the technology and do not necessarily fit in a simple hierarchical structure."</para>
    /// labels<para>"Module"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#ConformanceModule">http://www.w3.org/ns/spec#ConformanceModule</seealso>
    let ConformanceModule = Prefixed_Name(spec, "ConformanceModule") |> PrefixedName
    /// <summary>
    ///   <para>spec:ConformanceProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A profile is a subset of the technology that supports a particular functional objective or a subset of a set of technologies defining how they are required to operate together (e.g., XHTML plus MathML plus SVG)."</para>
    /// labels<para>"Profile"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#ConformanceProfile">http://www.w3.org/ns/spec#ConformanceProfile</seealso>
    let ConformanceProfile = Prefixed_Name(spec, "ConformanceProfile") |> PrefixedName
    /// <summary>
    ///   <para>spec:Considerations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Considerations"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Considerations">http://www.w3.org/ns/spec#Considerations</seealso>
    let Considerations = Prefixed_Name(spec, "Considerations") |> PrefixedName
    /// <summary>
    ///   <para>spec:Consumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Consumer">http://www.w3.org/ns/spec#Consumer</seealso>
    let Consumer = Prefixed_Name(spec, "Consumer") |> PrefixedName
    /// <summary>
    ///   <para>spec:Content</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Content">http://www.w3.org/ns/spec#Content</seealso>
    let Content = Prefixed_Name(spec, "Content") |> PrefixedName
    /// <summary>
    ///   <para>spec:ContentData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#ContentData">http://www.w3.org/ns/spec#ContentData</seealso>
    let ContentData = Prefixed_Name(spec, "ContentData") |> PrefixedName
    /// <summary>
    ///   <para>spec:Could</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Could">http://www.w3.org/ns/spec#Could</seealso>
    let Could = Prefixed_Name(spec, "Could") |> PrefixedName
    /// <summary>
    ///   <para>spec:CouldNot</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#CouldNot">http://www.w3.org/ns/spec#CouldNot</seealso>
    let CouldNot = Prefixed_Name(spec, "CouldNot") |> PrefixedName
    /// <summary>
    ///   <para>spec:Discouraged</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Discouraged">http://www.w3.org/ns/spec#Discouraged</seealso>
    let Discouraged = Prefixed_Name(spec, "Discouraged") |> PrefixedName
    /// <summary>
    ///   <para>spec:Encouraged</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Encouraged">http://www.w3.org/ns/spec#Encouraged</seealso>
    let Encouraged = Prefixed_Name(spec, "Encouraged") |> PrefixedName
    /// <summary>
    ///   <para>spec:Extensibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Extensibility"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Extensibility">http://www.w3.org/ns/spec#Extensibility</seealso>
    let Extensibility = Prefixed_Name(spec, "Extensibility") |> PrefixedName

    /// <summary>
    ///   <para>spec:FoundationOrAbstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#FoundationOrAbstract">http://www.w3.org/ns/spec#FoundationOrAbstract</seealso>
    let FoundationOrAbstract =
        Prefixed_Name(spec, "FoundationOrAbstract") |> PrefixedName

    /// <summary>
    ///   <para>spec:InternationalizationConsiderations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Internationalization Considerations"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#InternationalizationConsiderations">http://www.w3.org/ns/spec#InternationalizationConsiderations</seealso>
    let InternationalizationConsiderations =
        Prefixed_Name(spec, "InternationalizationConsiderations") |> PrefixedName

    /// <summary>
    ///   <para>spec:MAY</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#MAY">http://www.w3.org/ns/spec#MAY</seealso>
    let MAY = Prefixed_Name(spec, "MAY") |> PrefixedName
    /// <summary>
    ///   <para>spec:MUST</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#MUST">http://www.w3.org/ns/spec#MUST</seealso>
    let MUST = Prefixed_Name(spec, "MUST") |> PrefixedName
    /// <summary>
    ///   <para>spec:MUSTNOT</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#MUSTNOT">http://www.w3.org/ns/spec#MUSTNOT</seealso>
    let MUSTNOT = Prefixed_Name(spec, "MUSTNOT") |> PrefixedName
    /// <summary>
    ///   <para>spec:Might</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Might">http://www.w3.org/ns/spec#Might</seealso>
    let Might = Prefixed_Name(spec, "Might") |> PrefixedName
    /// <summary>
    ///   <para>spec:MightNot</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#MightNot">http://www.w3.org/ns/spec#MightNot</seealso>
    let MightNot = Prefixed_Name(spec, "MightNot") |> PrefixedName
    /// <summary>
    ///   <para>spec:Module</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Module">http://www.w3.org/ns/spec#Module</seealso>
    let Module = Prefixed_Name(spec, "Module") |> PrefixedName
    /// <summary>
    ///   <para>spec:NOTRECOMMENDED</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#NOTRECOMMENDED">http://www.w3.org/ns/spec#NOTRECOMMENDED</seealso>
    let NOTRECOMMENDED = Prefixed_Name(spec, "NOTRECOMMENDED") |> PrefixedName
    /// <summary>
    ///   <para>spec:NotationSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#NotationSyntax">http://www.w3.org/ns/spec#NotationSyntax</seealso>
    let NotationSyntax = Prefixed_Name(spec, "NotationSyntax") |> PrefixedName
    /// <summary>
    ///   <para>spec:OPTIONAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#OPTIONAL">http://www.w3.org/ns/spec#OPTIONAL</seealso>
    let OPTIONAL = Prefixed_Name(spec, "OPTIONAL") |> PrefixedName
    /// <summary>
    ///   <para>spec:Player</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Player">http://www.w3.org/ns/spec#Player</seealso>
    let Player = Prefixed_Name(spec, "Player") |> PrefixedName

    /// <summary>
    ///   <para>spec:PrivacyConsiderations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Privacy Considerations"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#PrivacyConsiderations">http://www.w3.org/ns/spec#PrivacyConsiderations</seealso>
    let PrivacyConsiderations =
        Prefixed_Name(spec, "PrivacyConsiderations") |> PrefixedName

    /// <summary>
    ///   <para>spec:Processor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Processor">http://www.w3.org/ns/spec#Processor</seealso>
    let Processor = Prefixed_Name(spec, "Processor") |> PrefixedName
    /// <summary>
    ///   <para>spec:ProcessorBehavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#ProcessorBehavior">http://www.w3.org/ns/spec#ProcessorBehavior</seealso>
    let ProcessorBehavior = Prefixed_Name(spec, "ProcessorBehavior") |> PrefixedName
    /// <summary>
    ///   <para>spec:ProducerOfContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#ProducerOfContent">http://www.w3.org/ns/spec#ProducerOfContent</seealso>
    let ProducerOfContent = Prefixed_Name(spec, "ProducerOfContent") |> PrefixedName

    /// <summary>
    ///   <para>spec:ProducerOfInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#ProducerOfInstructions">http://www.w3.org/ns/spec#ProducerOfInstructions</seealso>
    let ProducerOfInstructions =
        Prefixed_Name(spec, "ProducerOfInstructions") |> PrefixedName

    /// <summary>
    ///   <para>spec:Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Profile">http://www.w3.org/ns/spec#Profile</seealso>
    let Profile = Prefixed_Name(spec, "Profile") |> PrefixedName
    /// <summary>
    ///   <para>spec:Protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Protocol">http://www.w3.org/ns/spec#Protocol</seealso>
    let Protocol = Prefixed_Name(spec, "Protocol") |> PrefixedName
    /// <summary>
    ///   <para>spec:RECOMMENDED</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#RECOMMENDED">http://www.w3.org/ns/spec#RECOMMENDED</seealso>
    let RECOMMENDED = Prefixed_Name(spec, "RECOMMENDED") |> PrefixedName
    /// <summary>
    ///   <para>spec:REQUIRED</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#REQUIRED">http://www.w3.org/ns/spec#REQUIRED</seealso>
    let REQUIRED = Prefixed_Name(spec, "REQUIRED") |> PrefixedName

    /// <summary>
    ///   <para>spec:RegistrationConsiderations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Registration considerations for collection of values or data at standards organisations, e.g., IANA, W3C."</para>
    /// labels<para>"Registration Considerations"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#RegistrationConsiderations">http://www.w3.org/ns/spec#RegistrationConsiderations</seealso>
    let RegistrationConsiderations =
        Prefixed_Name(spec, "RegistrationConsiderations") |> PrefixedName

    /// <summary>
    ///   <para>spec:Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Requirement"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Requirement">http://www.w3.org/ns/spec#Requirement</seealso>
    let Requirement = Prefixed_Name(spec, "Requirement") |> PrefixedName
    /// <summary>
    ///   <para>spec:RequirementLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#RequirementLevel">http://www.w3.org/ns/spec#RequirementLevel</seealso>
    let RequirementLevel = Prefixed_Name(spec, "RequirementLevel") |> PrefixedName
    /// <summary>
    ///   <para>spec:RespondingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#RespondingAgent">http://www.w3.org/ns/spec#RespondingAgent</seealso>
    let RespondingAgent = Prefixed_Name(spec, "RespondingAgent") |> PrefixedName

    /// <summary>
    ///   <para>spec:RulesForDerivingProfiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#RulesForDerivingProfiles">http://www.w3.org/ns/spec#RulesForDerivingProfiles</seealso>
    let RulesForDerivingProfiles =
        Prefixed_Name(spec, "RulesForDerivingProfiles") |> PrefixedName

    /// <summary>
    ///   <para>spec:SHALL</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SHALL">http://www.w3.org/ns/spec#SHALL</seealso>
    let SHALL = Prefixed_Name(spec, "SHALL") |> PrefixedName
    /// <summary>
    ///   <para>spec:SHALLNOT</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SHALLNOT">http://www.w3.org/ns/spec#SHALLNOT</seealso>
    let SHALLNOT = Prefixed_Name(spec, "SHALLNOT") |> PrefixedName
    /// <summary>
    ///   <para>spec:SHOULD</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SHOULD">http://www.w3.org/ns/spec#SHOULD</seealso>
    let SHOULD = Prefixed_Name(spec, "SHOULD") |> PrefixedName
    /// <summary>
    ///   <para>spec:SHOULDNOT</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SHOULDNOT">http://www.w3.org/ns/spec#SHOULDNOT</seealso>
    let SHOULDNOT = Prefixed_Name(spec, "SHOULDNOT") |> PrefixedName

    /// <summary>
    ///   <para>spec:SecurityConsiderations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Security Considerations"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SecurityConsiderations">http://www.w3.org/ns/spec#SecurityConsiderations</seealso>
    let SecurityConsiderations =
        Prefixed_Name(spec, "SecurityConsiderations") |> PrefixedName

    /// <summary>
    ///   <para>spec:SelfReviewQuestionnaire</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Self-Review Questionnaire"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SelfReviewQuestionnaire">http://www.w3.org/ns/spec#SelfReviewQuestionnaire</seealso>
    let SelfReviewQuestionnaire =
        Prefixed_Name(spec, "SelfReviewQuestionnaire") |> PrefixedName

    /// <summary>
    ///   <para>spec:SelfReviewQuestionnaireSecurityPrivacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Self-Review Questionnaire: Security and Privacy"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SelfReviewQuestionnaireSecurityPrivacy">http://www.w3.org/ns/spec#SelfReviewQuestionnaireSecurityPrivacy</seealso>
    let SelfReviewQuestionnaireSecurityPrivacy =
        Prefixed_Name(spec, "SelfReviewQuestionnaireSecurityPrivacy") |> PrefixedName

    /// <summary>
    ///   <para>spec:Server</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Server">http://www.w3.org/ns/spec#Server</seealso>
    let Server = Prefixed_Name(spec, "Server") |> PrefixedName
    /// <summary>
    ///   <para>spec:SetOfEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SetOfEvents">http://www.w3.org/ns/spec#SetOfEvents</seealso>
    let SetOfEvents = Prefixed_Name(spec, "SetOfEvents") |> PrefixedName
    /// <summary>
    ///   <para>spec:SetOfGuidelines</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SetOfGuidelines">http://www.w3.org/ns/spec#SetOfGuidelines</seealso>
    let SetOfGuidelines = Prefixed_Name(spec, "SetOfGuidelines") |> PrefixedName
    /// <summary>
    ///   <para>spec:Specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Specification"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Specification">http://www.w3.org/ns/spec#Specification</seealso>
    let Specification = Prefixed_Name(spec, "Specification") |> PrefixedName

    /// <summary>
    ///   <para>spec:SpecificationCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SpecificationCategory">http://www.w3.org/ns/spec#SpecificationCategory</seealso>
    let SpecificationCategory =
        Prefixed_Name(spec, "SpecificationCategory") |> PrefixedName

    /// <summary>
    ///   <para>spec:SpecificationGuidelines</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#SpecificationGuidelines">http://www.w3.org/ns/spec#SpecificationGuidelines</seealso>
    let SpecificationGuidelines =
        Prefixed_Name(spec, "SpecificationGuidelines") |> PrefixedName

    /// <summary>
    ///   <para>spec:StronglyDiscouraged</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#StronglyDiscouraged">http://www.w3.org/ns/spec#StronglyDiscouraged</seealso>
    let StronglyDiscouraged = Prefixed_Name(spec, "StronglyDiscouraged") |> PrefixedName
    /// <summary>
    ///   <para>spec:StronglyEncouraged</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#StronglyEncouraged">http://www.w3.org/ns/spec#StronglyEncouraged</seealso>
    let StronglyEncouraged = Prefixed_Name(spec, "StronglyEncouraged") |> PrefixedName
    /// <summary>
    ///   <para>spec:Variability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#Variability">http://www.w3.org/ns/spec#Variability</seealso>
    let Variability = Prefixed_Name(spec, "Variability") |> PrefixedName
    /// <summary>
    ///   <para>spec:acknowledgements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"acknowledgements"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#acknowledgements">http://www.w3.org/ns/spec#acknowledgements</seealso>
    let acknowledgements = Prefixed_Name(spec, "acknowledgements") |> PrefixedName
    /// <summary>
    ///   <para>spec:advisement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"advisement"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#advisement">http://www.w3.org/ns/spec#advisement</seealso>
    let advisement = Prefixed_Name(spec, "advisement") |> PrefixedName
    /// <summary>
    ///   <para>spec:advisementLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"advisement level"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#advisementLevel">http://www.w3.org/ns/spec#advisementLevel</seealso>
    let advisementLevel = Prefixed_Name(spec, "advisementLevel") |> PrefixedName
    /// <summary>
    ///   <para>spec:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#author">http://www.w3.org/ns/spec#author</seealso>
    let author = Prefixed_Name(spec, "author") |> PrefixedName
    /// <summary>
    ///   <para>spec:basedOnConsensus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"based on consensus"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#basedOnConsensus">http://www.w3.org/ns/spec#basedOnConsensus</seealso>
    let basedOnConsensus = Prefixed_Name(spec, "basedOnConsensus") |> PrefixedName
    /// <summary>
    ///   <para>spec:buildUpon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"build upon"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#buildUpon">http://www.w3.org/ns/spec#buildUpon</seealso>
    let buildUpon = Prefixed_Name(spec, "buildUpon") |> PrefixedName
    /// <summary>
    ///   <para>spec:change</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"change"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#change">http://www.w3.org/ns/spec#change</seealso>
    let change = Prefixed_Name(spec, "change") |> PrefixedName
    /// <summary>
    ///   <para>spec:changeClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"change class"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#changeClass">http://www.w3.org/ns/spec#changeClass</seealso>
    let changeClass = Prefixed_Name(spec, "changeClass") |> PrefixedName
    /// <summary>
    ///   <para>spec:changeSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"change subject"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#changeSubject">http://www.w3.org/ns/spec#changeSubject</seealso>
    let changeSubject = Prefixed_Name(spec, "changeSubject") |> PrefixedName
    /// <summary>
    ///   <para>spec:changelog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"changelog"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#changelog">http://www.w3.org/ns/spec#changelog</seealso>
    let changelog = Prefixed_Name(spec, "changelog") |> PrefixedName
    /// <summary>
    ///   <para>spec:citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#citation">http://www.w3.org/ns/spec#citation</seealso>
    let citation = Prefixed_Name(spec, "citation") |> PrefixedName
    /// <summary>
    ///   <para>spec:classesOfProducts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#classesOfProducts">http://www.w3.org/ns/spec#classesOfProducts</seealso>
    let classesOfProducts = Prefixed_Name(spec, "classesOfProducts") |> PrefixedName

    /// <summary>
    ///   <para>spec:complianceWithOtherSpecifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"compliance with other specifications"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#complianceWithOtherSpecifications">http://www.w3.org/ns/spec#complianceWithOtherSpecifications</seealso>
    let complianceWithOtherSpecifications =
        Prefixed_Name(spec, "complianceWithOtherSpecifications") |> PrefixedName

    /// <summary>
    ///   <para>spec:composedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"composed of"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#composedOf">http://www.w3.org/ns/spec#composedOf</seealso>
    let composedOf = Prefixed_Name(spec, "composedOf") |> PrefixedName
    /// <summary>
    ///   <para>spec:conformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"conformance"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#conformance">http://www.w3.org/ns/spec#conformance</seealso>
    let conformance = Prefixed_Name(spec, "conformance") |> PrefixedName
    /// <summary>
    ///   <para>spec:consideration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"consideration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#consideration">http://www.w3.org/ns/spec#consideration</seealso>
    let consideration = Prefixed_Name(spec, "consideration") |> PrefixedName
    /// <summary>
    ///   <para>spec:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#contributor">http://www.w3.org/ns/spec#contributor</seealso>
    let contributor = Prefixed_Name(spec, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>spec:conventions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"conventions"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#conventions">http://www.w3.org/ns/spec#conventions</seealso>
    let conventions = Prefixed_Name(spec, "conventions") |> PrefixedName
    /// <summary>
    ///   <para>spec:defines</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"defines"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#defines">http://www.w3.org/ns/spec#defines</seealso>
    let defines = Prefixed_Name(spec, "defines") |> PrefixedName
    /// <summary>
    ///   <para>spec:deprecation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#deprecation">http://www.w3.org/ns/spec#deprecation</seealso>
    let deprecation = Prefixed_Name(spec, "deprecation") |> PrefixedName
    /// <summary>
    ///   <para>spec:discretionaryItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#discretionaryItem">http://www.w3.org/ns/spec#discretionaryItem</seealso>
    let discretionaryItem = Prefixed_Name(spec, "discretionaryItem") |> PrefixedName
    /// <summary>
    ///   <para>spec:documentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"document status"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#documentStatus">http://www.w3.org/ns/spec#documentStatus</seealso>
    let documentStatus = Prefixed_Name(spec, "documentStatus") |> PrefixedName
    /// <summary>
    ///   <para>spec:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#editor">http://www.w3.org/ns/spec#editor</seealso>
    let editor = Prefixed_Name(spec, "editor") |> PrefixedName
    /// <summary>
    ///   <para>spec:errorHandling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"error handling"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#errorHandling">http://www.w3.org/ns/spec#errorHandling</seealso>
    let errorHandling = Prefixed_Name(spec, "errorHandling") |> PrefixedName
    /// <summary>
    ///   <para>spec:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"example"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#example">http://www.w3.org/ns/spec#example</seealso>
    let example = Prefixed_Name(spec, "example") |> PrefixedName
    /// <summary>
    ///   <para>spec:exitCriteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"exit criteria"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#exitCriteria">http://www.w3.org/ns/spec#exitCriteria</seealso>
    let exitCriteria = Prefixed_Name(spec, "exitCriteria") |> PrefixedName
    /// <summary>
    ///   <para>spec:extensibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"extensibility"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#extensibility">http://www.w3.org/ns/spec#extensibility</seealso>
    let extensibility = Prefixed_Name(spec, "extensibility") |> PrefixedName
    /// <summary>
    ///   <para>spec:functionalLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"functional level"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#functionalLevel">http://www.w3.org/ns/spec#functionalLevel</seealso>
    let functionalLevel = Prefixed_Name(spec, "functionalLevel") |> PrefixedName
    /// <summary>
    ///   <para>spec:implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#implementation">http://www.w3.org/ns/spec#implementation</seealso>
    let implementation = Prefixed_Name(spec, "implementation") |> PrefixedName

    /// <summary>
    ///   <para>spec:implementationReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"implementation report"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#implementationReport">http://www.w3.org/ns/spec#implementationReport</seealso>
    let implementationReport =
        Prefixed_Name(spec, "implementationReport") |> PrefixedName

    /// <summary>
    ///   <para>spec:intellectualPropertyRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"intellectual property rights"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#intellectualPropertyRights">http://www.w3.org/ns/spec#intellectualPropertyRights</seealso>
    let intellectualPropertyRights =
        Prefixed_Name(spec, "intellectualPropertyRights") |> PrefixedName

    /// <summary>
    ///   <para>spec:issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"issue"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#issue">http://www.w3.org/ns/spec#issue</seealso>
    let issue = Prefixed_Name(spec, "issue") |> PrefixedName
    /// <summary>
    ///   <para>spec:issueTracker</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#issueTracker">http://www.w3.org/ns/spec#issueTracker</seealso>
    let issueTracker = Prefixed_Name(spec, "issueTracker") |> PrefixedName
    /// <summary>
    ///   <para>spec:latestVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#latestVersion">http://www.w3.org/ns/spec#latestVersion</seealso>
    let latestVersion = Prefixed_Name(spec, "latestVersion") |> PrefixedName
    /// <summary>
    ///   <para>spec:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#level">http://www.w3.org/ns/spec#level</seealso>
    let level = Prefixed_Name(spec, "level") |> PrefixedName
    /// <summary>
    ///   <para>spec:module</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"module"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#module">http://www.w3.org/ns/spec#module</seealso>
    let module_ = Prefixed_Name(spec, "module") |> PrefixedName
    /// <summary>
    ///   <para>spec:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"note"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#note">http://www.w3.org/ns/spec#note</seealso>
    let note = Prefixed_Name(spec, "note") |> PrefixedName
    /// <summary>
    ///   <para>spec:operativeProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"operative process"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#operativeProcess">http://www.w3.org/ns/spec#operativeProcess</seealso>
    let operativeProcess = Prefixed_Name(spec, "operativeProcess") |> PrefixedName
    /// <summary>
    ///   <para>spec:previousVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#previousVersion">http://www.w3.org/ns/spec#previousVersion</seealso>
    let previousVersion = Prefixed_Name(spec, "previousVersion") |> PrefixedName
    /// <summary>
    ///   <para>spec:profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"profile"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#profile">http://www.w3.org/ns/spec#profile</seealso>
    let profile = Prefixed_Name(spec, "profile") |> PrefixedName
    /// <summary>
    ///   <para>spec:publicationRules</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"publication rules"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#publicationRules">http://www.w3.org/ns/spec#publicationRules</seealso>
    let publicationRules = Prefixed_Name(spec, "publicationRules") |> PrefixedName
    /// <summary>
    ///   <para>spec:repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#repository">http://www.w3.org/ns/spec#repository</seealso>
    let repository = Prefixed_Name(spec, "repository") |> PrefixedName
    /// <summary>
    ///   <para>spec:requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"requirement"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#requirement">http://www.w3.org/ns/spec#requirement</seealso>
    let requirement = Prefixed_Name(spec, "requirement") |> PrefixedName
    /// <summary>
    ///   <para>spec:requirementLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"requirement level"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#requirementLevel">http://www.w3.org/ns/spec#requirementLevel</seealso>
    let requirementLevel = Prefixed_Name(spec, "requirementLevel") |> PrefixedName

    /// <summary>
    ///   <para>spec:requirementReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"requirement reference"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#requirementReference">http://www.w3.org/ns/spec#requirementReference</seealso>
    let requirementReference =
        Prefixed_Name(spec, "requirementReference") |> PrefixedName

    /// <summary>
    ///   <para>spec:requirementSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"requirement subject"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#requirementSubject">http://www.w3.org/ns/spec#requirementSubject</seealso>
    let requirementSubject = Prefixed_Name(spec, "requirementSubject") |> PrefixedName
    /// <summary>
    ///   <para>spec:reviewProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"review process"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#reviewProcess">http://www.w3.org/ns/spec#reviewProcess</seealso>
    let reviewProcess = Prefixed_Name(spec, "reviewProcess") |> PrefixedName
    /// <summary>
    ///   <para>spec:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"scope"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#scope">http://www.w3.org/ns/spec#scope</seealso>
    let scope = Prefixed_Name(spec, "scope") |> PrefixedName

    /// <summary>
    ///   <para>spec:specificationCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#specificationCategory">http://www.w3.org/ns/spec#specificationCategory</seealso>
    let specificationCategory =
        Prefixed_Name(spec, "specificationCategory") |> PrefixedName

    /// <summary>
    ///   <para>spec:statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"statement"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#statement">http://www.w3.org/ns/spec#statement</seealso>
    let statement = Prefixed_Name(spec, "statement") |> PrefixedName
    /// <summary>
    ///   <para>spec:successCriteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"success criteria"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#successCriteria">http://www.w3.org/ns/spec#successCriteria</seealso>
    let successCriteria = Prefixed_Name(spec, "successCriteria") |> PrefixedName
    /// <summary>
    ///   <para>spec:suitedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"suited for"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#suitedFor">http://www.w3.org/ns/spec#suitedFor</seealso>
    let suitedFor = Prefixed_Name(spec, "suitedFor") |> PrefixedName
    /// <summary>
    ///   <para>spec:terminology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"terminology"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#terminology">http://www.w3.org/ns/spec#terminology</seealso>
    let terminology = Prefixed_Name(spec, "terminology") |> PrefixedName
    /// <summary>
    ///   <para>spec:testCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"test case"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#testCase">http://www.w3.org/ns/spec#testCase</seealso>
    let testCase = Prefixed_Name(spec, "testCase") |> PrefixedName
    /// <summary>
    ///   <para>spec:testScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"test script"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#testScript">http://www.w3.org/ns/spec#testScript</seealso>
    let testScript = Prefixed_Name(spec, "testScript") |> PrefixedName
    /// <summary>
    ///   <para>spec:testSuite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"test suite"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#testSuite">http://www.w3.org/ns/spec#testSuite</seealso>
    let testSuite = Prefixed_Name(spec, "testSuite") |> PrefixedName
    /// <summary>
    ///   <para>spec:thisVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/spec#thisVersion">http://www.w3.org/ns/spec#thisVersion</seealso>
    let thisVersion = Prefixed_Name(spec, "thisVersion") |> PrefixedName
    /// <summary>
    ///   <para>spec:violatesAdvice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"violates advice"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/spec#violatesAdvice">http://www.w3.org/ns/spec#violatesAdvice</seealso>
    let violatesAdvice = Prefixed_Name(spec, "violatesAdvice") |> PrefixedName
