namespace http.www.w3.org.ns.spec.hash

open DoxAletheia

module spec =
    let _namespace_name = "http://www.w3.org/ns/spec#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#API"></see>
    /// </summary>
    let API = _prefix "API"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#AccessibilityConsiderations"></see>
    /// </summary>
    let AccessibilityConsiderations = _prefix "AccessibilityConsiderations"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Considerations"></see>
    /// </summary>
    let Considerations = _prefix "Considerations"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Advisement"></see>
    /// </summary>
    let Advisement = _prefix "Advisement"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#AdvisementLevel"></see>
    /// </summary>
    let AdvisementLevel = _prefix "AdvisementLevel"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Can"></see>
    /// </summary>
    let Can = _prefix "Can"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Cannot"></see>
    /// </summary>
    let Cannot = _prefix "Cannot"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Change"></see>
    /// </summary>
    let Change = _prefix "Change"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Changelog"></see>
    /// </summary>
    let Changelog = _prefix "Changelog"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#ClassesOfProducts"></see>
    /// </summary>
    let ClassesOfProducts = _prefix "ClassesOfProducts"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Content"></see>
    /// </summary>
    let Content = _prefix "Content"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#ProducerOfContent"></see>
    /// </summary>
    let ProducerOfContent = _prefix "ProducerOfContent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Player"></see>
    /// </summary>
    let Player = _prefix "Player"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Consumer"></see>
    /// </summary>
    let Consumer = _prefix "Consumer"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#RespondingAgent"></see>
    /// </summary>
    let RespondingAgent = _prefix "RespondingAgent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Processor"></see>
    /// </summary>
    let Processor = _prefix "Processor"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Module"></see>
    /// </summary>
    let Module = _prefix "Module"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#ProducerOfInstructions"></see>
    /// </summary>
    let ProducerOfInstructions = _prefix "ProducerOfInstructions"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Profile"></see>
    /// </summary>
    let Profile = _prefix "Profile"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SpecificationGuidelines"></see>
    /// </summary>
    let SpecificationGuidelines = _prefix "SpecificationGuidelines"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Client"></see>
    /// </summary>
    let Client = _prefix "Client"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Conformance"></see>
    /// </summary>
    let Conformance = _prefix "Conformance"
    /// <summary>
    /// Functional levels — or in common usage simply levels — are used to group functionality into nested subsets, ranging from minimal or core functionality to full or complete functionally. Level 1 is the minimum or core of the technology. Level 2 includes all of level 1 plus additional functionality. This nesting continues until level n, which consists of the entire technology.
    /// <see href="http://www.w3.org/ns/spec#ConformanceFunctionalLevel"></see></summary>
    let ConformanceFunctionalLevel = _prefix "ConformanceFunctionalLevel"
    /// <summary>
    /// Modules are discrete divisions or functional groupings of the technology and do not necessarily fit in a simple hierarchical structure.
    /// <see href="http://www.w3.org/ns/spec#ConformanceModule"></see></summary>
    let ConformanceModule = _prefix "ConformanceModule"
    /// <summary>
    /// A profile is a subset of the technology that supports a particular functional objective or a subset of a set of technologies defining how they are required to operate together (e.g., XHTML plus MathML plus SVG).
    /// <see href="http://www.w3.org/ns/spec#ConformanceProfile"></see></summary>
    let ConformanceProfile = _prefix "ConformanceProfile"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#ContentData"></see>
    /// </summary>
    let ContentData = _prefix "ContentData"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Could"></see>
    /// </summary>
    let Could = _prefix "Could"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#CouldNot"></see>
    /// </summary>
    let CouldNot = _prefix "CouldNot"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Discouraged"></see>
    /// </summary>
    let Discouraged = _prefix "Discouraged"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Encouraged"></see>
    /// </summary>
    let Encouraged = _prefix "Encouraged"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Extensibility"></see>
    /// </summary>
    let Extensibility = _prefix "Extensibility"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#FoundationOrAbstract"></see>
    /// </summary>
    let FoundationOrAbstract = _prefix "FoundationOrAbstract"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#InternationalizationConsiderations"></see>
    /// </summary>
    let InternationalizationConsiderations =
        _prefix "InternationalizationConsiderations"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#MAY"></see>
    /// </summary>
    let MAY = _prefix "MAY"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#OPTIONAL"></see>
    /// </summary>
    let OPTIONAL = _prefix "OPTIONAL"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#RequirementLevel"></see>
    /// </summary>
    let RequirementLevel = _prefix "RequirementLevel"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#MUST"></see>
    /// </summary>
    let MUST = _prefix "MUST"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#REQUIRED"></see>
    /// </summary>
    let REQUIRED = _prefix "REQUIRED"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SHALL"></see>
    /// </summary>
    let SHALL = _prefix "SHALL"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#MUSTNOT"></see>
    /// </summary>
    let MUSTNOT = _prefix "MUSTNOT"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SHALLNOT"></see>
    /// </summary>
    let SHALLNOT = _prefix "SHALLNOT"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Might"></see>
    /// </summary>
    let Might = _prefix "Might"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#MightNot"></see>
    /// </summary>
    let MightNot = _prefix "MightNot"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#NOTRECOMMENDED"></see>
    /// </summary>
    let NOTRECOMMENDED = _prefix "NOTRECOMMENDED"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SHOULDNOT"></see>
    /// </summary>
    let SHOULDNOT = _prefix "SHOULDNOT"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#NotationSyntax"></see>
    /// </summary>
    let NotationSyntax = _prefix "NotationSyntax"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#PrivacyConsiderations"></see>
    /// </summary>
    let PrivacyConsiderations = _prefix "PrivacyConsiderations"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#ProcessorBehavior"></see>
    /// </summary>
    let ProcessorBehavior = _prefix "ProcessorBehavior"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Protocol"></see>
    /// </summary>
    let Protocol = _prefix "Protocol"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#RECOMMENDED"></see>
    /// </summary>
    let RECOMMENDED = _prefix "RECOMMENDED"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SHOULD"></see>
    /// </summary>
    let SHOULD = _prefix "SHOULD"
    /// <summary>
    /// Registration considerations for collection of values or data at standards organisations, e.g., IANA, W3C.
    /// <see href="http://www.w3.org/ns/spec#RegistrationConsiderations"></see></summary>
    let RegistrationConsiderations = _prefix "RegistrationConsiderations"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Requirement"></see>
    /// </summary>
    let Requirement = _prefix "Requirement"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#RulesForDerivingProfiles"></see>
    /// </summary>
    let RulesForDerivingProfiles = _prefix "RulesForDerivingProfiles"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SecurityConsiderations"></see>
    /// </summary>
    let SecurityConsiderations = _prefix "SecurityConsiderations"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SelfReviewQuestionnaire"></see>
    /// </summary>
    let SelfReviewQuestionnaire = _prefix "SelfReviewQuestionnaire"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SelfReviewQuestionnaireSecurityPrivacy"></see>
    /// </summary>
    let SelfReviewQuestionnaireSecurityPrivacy =
        _prefix "SelfReviewQuestionnaireSecurityPrivacy"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Server"></see>
    /// </summary>
    let Server = _prefix "Server"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SetOfEvents"></see>
    /// </summary>
    let SetOfEvents = _prefix "SetOfEvents"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SetOfGuidelines"></see>
    /// </summary>
    let SetOfGuidelines = _prefix "SetOfGuidelines"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Specification"></see>
    /// </summary>
    let Specification = _prefix "Specification"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#SpecificationCategory"></see>
    /// </summary>
    let SpecificationCategory = _prefix "SpecificationCategory"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#StronglyDiscouraged"></see>
    /// </summary>
    let StronglyDiscouraged = _prefix "StronglyDiscouraged"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#StronglyEncouraged"></see>
    /// </summary>
    let StronglyEncouraged = _prefix "StronglyEncouraged"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#Variability"></see>
    /// </summary>
    let Variability = _prefix "Variability"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#acknowledgements"></see>
    /// </summary>
    let acknowledgements = _prefix "acknowledgements"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#advisement"></see>
    /// </summary>
    let advisement = _prefix "advisement"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#advisementLevel"></see>
    /// </summary>
    let advisementLevel = _prefix "advisementLevel"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#author"></see>
    /// </summary>
    let author = _prefix "author"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#basedOnConsensus"></see>
    /// </summary>
    let basedOnConsensus = _prefix "basedOnConsensus"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#buildUpon"></see>
    /// </summary>
    let buildUpon = _prefix "buildUpon"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#defines"></see>
    /// </summary>
    let defines = _prefix "defines"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#change"></see>
    /// </summary>
    let change = _prefix "change"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#changeClass"></see>
    /// </summary>
    let changeClass = _prefix "changeClass"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#changeSubject"></see>
    /// </summary>
    let changeSubject = _prefix "changeSubject"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#changelog"></see>
    /// </summary>
    let changelog = _prefix "changelog"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#citation"></see>
    /// </summary>
    let citation = _prefix "citation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#classesOfProducts"></see>
    /// </summary>
    let classesOfProducts = _prefix "classesOfProducts"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#complianceWithOtherSpecifications"></see>
    /// </summary>
    let complianceWithOtherSpecifications = _prefix "complianceWithOtherSpecifications"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#composedOf"></see>
    /// </summary>
    let composedOf = _prefix "composedOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#conformance"></see>
    /// </summary>
    let conformance = _prefix "conformance"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#consideration"></see>
    /// </summary>
    let consideration = _prefix "consideration"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#contributor"></see>
    /// </summary>
    let contributor = _prefix "contributor"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#conventions"></see>
    /// </summary>
    let conventions = _prefix "conventions"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#deprecation"></see>
    /// </summary>
    let deprecation = _prefix "deprecation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#discretionaryItem"></see>
    /// </summary>
    let discretionaryItem = _prefix "discretionaryItem"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#documentStatus"></see>
    /// </summary>
    let documentStatus = _prefix "documentStatus"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#editor"></see>
    /// </summary>
    let editor = _prefix "editor"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#errorHandling"></see>
    /// </summary>
    let errorHandling = _prefix "errorHandling"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#example"></see>
    /// </summary>
    let example = _prefix "example"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#exitCriteria"></see>
    /// </summary>
    let exitCriteria = _prefix "exitCriteria"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#extensibility"></see>
    /// </summary>
    let extensibility = _prefix "extensibility"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#functionalLevel"></see>
    /// </summary>
    let functionalLevel = _prefix "functionalLevel"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#implementation"></see>
    /// </summary>
    let implementation = _prefix "implementation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#implementationReport"></see>
    /// </summary>
    let implementationReport = _prefix "implementationReport"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#intellectualPropertyRights"></see>
    /// </summary>
    let intellectualPropertyRights = _prefix "intellectualPropertyRights"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#issue"></see>
    /// </summary>
    let issue = _prefix "issue"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#issueTracker"></see>
    /// </summary>
    let issueTracker = _prefix "issueTracker"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#latestVersion"></see>
    /// </summary>
    let latestVersion = _prefix "latestVersion"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#level"></see>
    /// </summary>
    let level = _prefix "level"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#module"></see>
    /// </summary>
    let module_ = _prefix "module"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#note"></see>
    /// </summary>
    let note = _prefix "note"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#operativeProcess"></see>
    /// </summary>
    let operativeProcess = _prefix "operativeProcess"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#previousVersion"></see>
    /// </summary>
    let previousVersion = _prefix "previousVersion"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#profile"></see>
    /// </summary>
    let profile = _prefix "profile"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#publicationRules"></see>
    /// </summary>
    let publicationRules = _prefix "publicationRules"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#repository"></see>
    /// </summary>
    let repository = _prefix "repository"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#requirement"></see>
    /// </summary>
    let requirement = _prefix "requirement"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#requirementLevel"></see>
    /// </summary>
    let requirementLevel = _prefix "requirementLevel"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#requirementReference"></see>
    /// </summary>
    let requirementReference = _prefix "requirementReference"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#requirementSubject"></see>
    /// </summary>
    let requirementSubject = _prefix "requirementSubject"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#reviewProcess"></see>
    /// </summary>
    let reviewProcess = _prefix "reviewProcess"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#scope"></see>
    /// </summary>
    let scope = _prefix "scope"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#specificationCategory"></see>
    /// </summary>
    let specificationCategory = _prefix "specificationCategory"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#statement"></see>
    /// </summary>
    let statement = _prefix "statement"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#successCriteria"></see>
    /// </summary>
    let successCriteria = _prefix "successCriteria"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#suitedFor"></see>
    /// </summary>
    let suitedFor = _prefix "suitedFor"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#terminology"></see>
    /// </summary>
    let terminology = _prefix "terminology"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#testCase"></see>
    /// </summary>
    let testCase = _prefix "testCase"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#testScript"></see>
    /// </summary>
    let testScript = _prefix "testScript"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#testSuite"></see>
    /// </summary>
    let testSuite = _prefix "testSuite"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#thisVersion"></see>
    /// </summary>
    let thisVersion = _prefix "thisVersion"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/spec#violatesAdvice"></see>
    /// </summary>
    let violatesAdvice = _prefix "violatesAdvice"
