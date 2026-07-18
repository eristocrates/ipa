namespace http.www.w3.org.ns.spec.hash

open DoxAletheia.Rdf_Vocabulary

module spec =
    let _namespace_name = "http://www.w3.org/ns/spec#"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#API"></see>
    /// </summary>
    let API = Namespaced_IRI.parse _namespace_name "API" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#AccessibilityConsiderations"></see>
    /// </summary>
    let AccessibilityConsiderations =
        Namespaced_IRI.parse _namespace_name "AccessibilityConsiderations" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Considerations"></see>
    /// </summary>
    let Considerations =
        Namespaced_IRI.parse _namespace_name "Considerations" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Advisement"></see>
    /// </summary>
    let Advisement = Namespaced_IRI.parse _namespace_name "Advisement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#AdvisementLevel"></see>
    /// </summary>
    let AdvisementLevel =
        Namespaced_IRI.parse _namespace_name "AdvisementLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Can"></see>
    /// </summary>
    let Can = Namespaced_IRI.parse _namespace_name "Can" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Cannot"></see>
    /// </summary>
    let Cannot = Namespaced_IRI.parse _namespace_name "Cannot" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Change"></see>
    /// </summary>
    let Change = Namespaced_IRI.parse _namespace_name "Change" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Changelog"></see>
    /// </summary>
    let Changelog = Namespaced_IRI.parse _namespace_name "Changelog" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#ClassesOfProducts"></see>
    /// </summary>
    let ClassesOfProducts =
        Namespaced_IRI.parse _namespace_name "ClassesOfProducts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Content"></see>
    /// </summary>
    let Content = Namespaced_IRI.parse _namespace_name "Content" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#ProducerOfContent"></see>
    /// </summary>
    let ProducerOfContent =
        Namespaced_IRI.parse _namespace_name "ProducerOfContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Player"></see>
    /// </summary>
    let Player = Namespaced_IRI.parse _namespace_name "Player" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Consumer"></see>
    /// </summary>
    let Consumer = Namespaced_IRI.parse _namespace_name "Consumer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#RespondingAgent"></see>
    /// </summary>
    let RespondingAgent =
        Namespaced_IRI.parse _namespace_name "RespondingAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Processor"></see>
    /// </summary>
    let Processor = Namespaced_IRI.parse _namespace_name "Processor" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Module"></see>
    /// </summary>
    let Module = Namespaced_IRI.parse _namespace_name "Module" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#ProducerOfInstructions"></see>
    /// </summary>
    let ProducerOfInstructions =
        Namespaced_IRI.parse _namespace_name "ProducerOfInstructions" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Profile"></see>
    /// </summary>
    let Profile = Namespaced_IRI.parse _namespace_name "Profile" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SpecificationGuidelines"></see>
    /// </summary>
    let SpecificationGuidelines =
        Namespaced_IRI.parse _namespace_name "SpecificationGuidelines" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Client"></see>
    /// </summary>
    let Client = Namespaced_IRI.parse _namespace_name "Client" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Conformance"></see>
    /// </summary>
    let Conformance =
        Namespaced_IRI.parse _namespace_name "Conformance" |> NamespacedName

    /// <summary>
    /// Functional levels — or in common usage simply levels — are used to group functionality into nested subsets, ranging from minimal or core functionality to full or complete functionally. Level 1 is the minimum or core of the technology. Level 2 includes all of level 1 plus additional functionality. This nesting continues until level n, which consists of the entire technology.
    /// <see href="http://www.w3.org/ns/spec#ConformanceFunctionalLevel"></see></summary>
    let ConformanceFunctionalLevel =
        Namespaced_IRI.parse _namespace_name "ConformanceFunctionalLevel" |> NamespacedName

    /// <summary>
    /// Modules are discrete divisions or functional groupings of the technology and do not necessarily fit in a simple hierarchical structure.
    /// <see href="http://www.w3.org/ns/spec#ConformanceModule"></see></summary>
    let ConformanceModule =
        Namespaced_IRI.parse _namespace_name "ConformanceModule" |> NamespacedName

    /// <summary>
    /// A profile is a subset of the technology that supports a particular functional objective or a subset of a set of technologies defining how they are required to operate together (e.g., XHTML plus MathML plus SVG).
    /// <see href="http://www.w3.org/ns/spec#ConformanceProfile"></see></summary>
    let ConformanceProfile =
        Namespaced_IRI.parse _namespace_name "ConformanceProfile" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#ContentData"></see>
    /// </summary>
    let ContentData =
        Namespaced_IRI.parse _namespace_name "ContentData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Could"></see>
    /// </summary>
    let Could = Namespaced_IRI.parse _namespace_name "Could" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#CouldNot"></see>
    /// </summary>
    let CouldNot = Namespaced_IRI.parse _namespace_name "CouldNot" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Discouraged"></see>
    /// </summary>
    let Discouraged =
        Namespaced_IRI.parse _namespace_name "Discouraged" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Encouraged"></see>
    /// </summary>
    let Encouraged = Namespaced_IRI.parse _namespace_name "Encouraged" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Extensibility"></see>
    /// </summary>
    let Extensibility =
        Namespaced_IRI.parse _namespace_name "Extensibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#FoundationOrAbstract"></see>
    /// </summary>
    let FoundationOrAbstract =
        Namespaced_IRI.parse _namespace_name "FoundationOrAbstract" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#InternationalizationConsiderations"></see>
    /// </summary>
    let InternationalizationConsiderations =
        Namespaced_IRI.parse _namespace_name "InternationalizationConsiderations" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#MAY"></see>
    /// </summary>
    let MAY = Namespaced_IRI.parse _namespace_name "MAY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#OPTIONAL"></see>
    /// </summary>
    let OPTIONAL = Namespaced_IRI.parse _namespace_name "OPTIONAL" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#RequirementLevel"></see>
    /// </summary>
    let RequirementLevel =
        Namespaced_IRI.parse _namespace_name "RequirementLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#MUST"></see>
    /// </summary>
    let MUST = Namespaced_IRI.parse _namespace_name "MUST" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#REQUIRED"></see>
    /// </summary>
    let REQUIRED = Namespaced_IRI.parse _namespace_name "REQUIRED" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SHALL"></see>
    /// </summary>
    let SHALL = Namespaced_IRI.parse _namespace_name "SHALL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#MUSTNOT"></see>
    /// </summary>
    let MUSTNOT = Namespaced_IRI.parse _namespace_name "MUSTNOT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SHALLNOT"></see>
    /// </summary>
    let SHALLNOT = Namespaced_IRI.parse _namespace_name "SHALLNOT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Might"></see>
    /// </summary>
    let Might = Namespaced_IRI.parse _namespace_name "Might" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#MightNot"></see>
    /// </summary>
    let MightNot = Namespaced_IRI.parse _namespace_name "MightNot" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#NOTRECOMMENDED"></see>
    /// </summary>
    let NOTRECOMMENDED =
        Namespaced_IRI.parse _namespace_name "NOTRECOMMENDED" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SHOULDNOT"></see>
    /// </summary>
    let SHOULDNOT = Namespaced_IRI.parse _namespace_name "SHOULDNOT" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#NotationSyntax"></see>
    /// </summary>
    let NotationSyntax =
        Namespaced_IRI.parse _namespace_name "NotationSyntax" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#PrivacyConsiderations"></see>
    /// </summary>
    let PrivacyConsiderations =
        Namespaced_IRI.parse _namespace_name "PrivacyConsiderations" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#ProcessorBehavior"></see>
    /// </summary>
    let ProcessorBehavior =
        Namespaced_IRI.parse _namespace_name "ProcessorBehavior" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Protocol"></see>
    /// </summary>
    let Protocol = Namespaced_IRI.parse _namespace_name "Protocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#RECOMMENDED"></see>
    /// </summary>
    let RECOMMENDED =
        Namespaced_IRI.parse _namespace_name "RECOMMENDED" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SHOULD"></see>
    /// </summary>
    let SHOULD = Namespaced_IRI.parse _namespace_name "SHOULD" |> NamespacedName

    /// <summary>
    /// Registration considerations for collection of values or data at standards organisations, e.g., IANA, W3C.
    /// <see href="http://www.w3.org/ns/spec#RegistrationConsiderations"></see></summary>
    let RegistrationConsiderations =
        Namespaced_IRI.parse _namespace_name "RegistrationConsiderations" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Requirement"></see>
    /// </summary>
    let Requirement =
        Namespaced_IRI.parse _namespace_name "Requirement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#RulesForDerivingProfiles"></see>
    /// </summary>
    let RulesForDerivingProfiles =
        Namespaced_IRI.parse _namespace_name "RulesForDerivingProfiles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SecurityConsiderations"></see>
    /// </summary>
    let SecurityConsiderations =
        Namespaced_IRI.parse _namespace_name "SecurityConsiderations" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SelfReviewQuestionnaire"></see>
    /// </summary>
    let SelfReviewQuestionnaire =
        Namespaced_IRI.parse _namespace_name "SelfReviewQuestionnaire" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SelfReviewQuestionnaireSecurityPrivacy"></see>
    /// </summary>
    let SelfReviewQuestionnaireSecurityPrivacy =
        Namespaced_IRI.parse _namespace_name "SelfReviewQuestionnaireSecurityPrivacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Server"></see>
    /// </summary>
    let Server = Namespaced_IRI.parse _namespace_name "Server" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SetOfEvents"></see>
    /// </summary>
    let SetOfEvents =
        Namespaced_IRI.parse _namespace_name "SetOfEvents" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SetOfGuidelines"></see>
    /// </summary>
    let SetOfGuidelines =
        Namespaced_IRI.parse _namespace_name "SetOfGuidelines" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Specification"></see>
    /// </summary>
    let Specification =
        Namespaced_IRI.parse _namespace_name "Specification" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SpecificationCategory"></see>
    /// </summary>
    let SpecificationCategory =
        Namespaced_IRI.parse _namespace_name "SpecificationCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#StronglyDiscouraged"></see>
    /// </summary>
    let StronglyDiscouraged =
        Namespaced_IRI.parse _namespace_name "StronglyDiscouraged" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#StronglyEncouraged"></see>
    /// </summary>
    let StronglyEncouraged =
        Namespaced_IRI.parse _namespace_name "StronglyEncouraged" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Variability"></see>
    /// </summary>
    let Variability =
        Namespaced_IRI.parse _namespace_name "Variability" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#acknowledgements"></see>
    /// </summary>
    let acknowledgements =
        Namespaced_IRI.parse _namespace_name "acknowledgements" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#advisement"></see>
    /// </summary>
    let advisement = Namespaced_IRI.parse _namespace_name "advisement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#advisementLevel"></see>
    /// </summary>
    let advisementLevel =
        Namespaced_IRI.parse _namespace_name "advisementLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#author"></see>
    /// </summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#basedOnConsensus"></see>
    /// </summary>
    let basedOnConsensus =
        Namespaced_IRI.parse _namespace_name "basedOnConsensus" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#buildUpon"></see>
    /// </summary>
    let buildUpon = Namespaced_IRI.parse _namespace_name "buildUpon" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#defines"></see>
    /// </summary>
    let defines = Namespaced_IRI.parse _namespace_name "defines" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#change"></see>
    /// </summary>
    let change = Namespaced_IRI.parse _namespace_name "change" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#changeClass"></see>
    /// </summary>
    let changeClass =
        Namespaced_IRI.parse _namespace_name "changeClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#changeSubject"></see>
    /// </summary>
    let changeSubject =
        Namespaced_IRI.parse _namespace_name "changeSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#changelog"></see>
    /// </summary>
    let changelog = Namespaced_IRI.parse _namespace_name "changelog" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#citation"></see>
    /// </summary>
    let citation = Namespaced_IRI.parse _namespace_name "citation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#classesOfProducts"></see>
    /// </summary>
    let classesOfProducts =
        Namespaced_IRI.parse _namespace_name "classesOfProducts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#complianceWithOtherSpecifications"></see>
    /// </summary>
    let complianceWithOtherSpecifications =
        Namespaced_IRI.parse _namespace_name "complianceWithOtherSpecifications" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#composedOf"></see>
    /// </summary>
    let composedOf = Namespaced_IRI.parse _namespace_name "composedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#conformance"></see>
    /// </summary>
    let conformance =
        Namespaced_IRI.parse _namespace_name "conformance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#consideration"></see>
    /// </summary>
    let consideration =
        Namespaced_IRI.parse _namespace_name "consideration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#contributor"></see>
    /// </summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#conventions"></see>
    /// </summary>
    let conventions =
        Namespaced_IRI.parse _namespace_name "conventions" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#deprecation"></see>
    /// </summary>
    let deprecation =
        Namespaced_IRI.parse _namespace_name "deprecation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#discretionaryItem"></see>
    /// </summary>
    let discretionaryItem =
        Namespaced_IRI.parse _namespace_name "discretionaryItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#documentStatus"></see>
    /// </summary>
    let documentStatus =
        Namespaced_IRI.parse _namespace_name "documentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#editor"></see>
    /// </summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#errorHandling"></see>
    /// </summary>
    let errorHandling =
        Namespaced_IRI.parse _namespace_name "errorHandling" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#example"></see>
    /// </summary>
    let example = Namespaced_IRI.parse _namespace_name "example" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#exitCriteria"></see>
    /// </summary>
    let exitCriteria =
        Namespaced_IRI.parse _namespace_name "exitCriteria" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#extensibility"></see>
    /// </summary>
    let extensibility =
        Namespaced_IRI.parse _namespace_name "extensibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#functionalLevel"></see>
    /// </summary>
    let functionalLevel =
        Namespaced_IRI.parse _namespace_name "functionalLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#implementation"></see>
    /// </summary>
    let implementation =
        Namespaced_IRI.parse _namespace_name "implementation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#implementationReport"></see>
    /// </summary>
    let implementationReport =
        Namespaced_IRI.parse _namespace_name "implementationReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#intellectualPropertyRights"></see>
    /// </summary>
    let intellectualPropertyRights =
        Namespaced_IRI.parse _namespace_name "intellectualPropertyRights" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#issue"></see>
    /// </summary>
    let issue = Namespaced_IRI.parse _namespace_name "issue" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#issueTracker"></see>
    /// </summary>
    let issueTracker =
        Namespaced_IRI.parse _namespace_name "issueTracker" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#latestVersion"></see>
    /// </summary>
    let latestVersion =
        Namespaced_IRI.parse _namespace_name "latestVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#level"></see>
    /// </summary>
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#module"></see>
    /// </summary>
    let module_ = Namespaced_IRI.parse _namespace_name "module" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#note"></see>
    /// </summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#operativeProcess"></see>
    /// </summary>
    let operativeProcess =
        Namespaced_IRI.parse _namespace_name "operativeProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#previousVersion"></see>
    /// </summary>
    let previousVersion =
        Namespaced_IRI.parse _namespace_name "previousVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#profile"></see>
    /// </summary>
    let profile = Namespaced_IRI.parse _namespace_name "profile" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#publicationRules"></see>
    /// </summary>
    let publicationRules =
        Namespaced_IRI.parse _namespace_name "publicationRules" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#repository"></see>
    /// </summary>
    let repository = Namespaced_IRI.parse _namespace_name "repository" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#requirement"></see>
    /// </summary>
    let requirement =
        Namespaced_IRI.parse _namespace_name "requirement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#requirementLevel"></see>
    /// </summary>
    let requirementLevel =
        Namespaced_IRI.parse _namespace_name "requirementLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#requirementReference"></see>
    /// </summary>
    let requirementReference =
        Namespaced_IRI.parse _namespace_name "requirementReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#requirementSubject"></see>
    /// </summary>
    let requirementSubject =
        Namespaced_IRI.parse _namespace_name "requirementSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#reviewProcess"></see>
    /// </summary>
    let reviewProcess =
        Namespaced_IRI.parse _namespace_name "reviewProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#scope"></see>
    /// </summary>
    let scope = Namespaced_IRI.parse _namespace_name "scope" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#specificationCategory"></see>
    /// </summary>
    let specificationCategory =
        Namespaced_IRI.parse _namespace_name "specificationCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#statement"></see>
    /// </summary>
    let statement = Namespaced_IRI.parse _namespace_name "statement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#successCriteria"></see>
    /// </summary>
    let successCriteria =
        Namespaced_IRI.parse _namespace_name "successCriteria" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#suitedFor"></see>
    /// </summary>
    let suitedFor = Namespaced_IRI.parse _namespace_name "suitedFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#terminology"></see>
    /// </summary>
    let terminology =
        Namespaced_IRI.parse _namespace_name "terminology" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#testCase"></see>
    /// </summary>
    let testCase = Namespaced_IRI.parse _namespace_name "testCase" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#testScript"></see>
    /// </summary>
    let testScript = Namespaced_IRI.parse _namespace_name "testScript" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#testSuite"></see>
    /// </summary>
    let testSuite = Namespaced_IRI.parse _namespace_name "testSuite" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#thisVersion"></see>
    /// </summary>
    let thisVersion =
        Namespaced_IRI.parse _namespace_name "thisVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#violatesAdvice"></see>
    /// </summary>
    let violatesAdvice =
        Namespaced_IRI.parse _namespace_name "violatesAdvice" |> NamespacedName
