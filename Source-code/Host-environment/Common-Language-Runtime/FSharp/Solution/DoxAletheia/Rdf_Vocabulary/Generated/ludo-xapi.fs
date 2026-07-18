namespace http.ns.inria.fr.ludo.v1.xapi.hash

open DoxAletheia.Rdf_Vocabulary

module ludo_xapi =
    let _namespace_name = "http://ns.inria.fr/ludo/v1/xapi#"
    /// <summary>
    /// A user account on an existing system, such as a private system (LMS or intranet) or a public system (social networking site).
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Account"></see></summary>
    let Account = Namespaced_IRI.parse _namespace_name "Account" |> NamespacedName
    /// <summary>
    /// An Activity is a type of Object making up the “this” in I did “this”; it is something with which an Actor interacted. It can be a unit of instruction, experience, or performance that is to be tracked in meaningful combination with a Verb. Interpretation of Activity is broad, meaning that Activities can even be tangible objects such as a chair (real or virtual). In the statement "Anna tried a cake recipe", the recipe constitutes the Activity in terms of the xAPI statement. Other examples of activities include a book, an e-learning course, a hike or a meeting.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#ActivityDefinition"></see>
    /// </summary>
    let ActivityDefinition =
        Namespaced_IRI.parse _namespace_name "ActivityDefinition" |> NamespacedName

    /// <summary>
    /// The software object that is communicating with the LRS to record information about a learning experience. May be similar to a SCORM package in that it is possible to bundle learning assets with the software object that performs this communication, but an Activity Provider may also be separate from the experience it is reporting about.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#ActivityProvider"></see></summary>
    let ActivityProvider =
        Namespaced_IRI.parse _namespace_name "ActivityProvider" |> NamespacedName

    /// <summary>
    /// An identity or persona of an individual or group tracked using Statements as doing an action (Verb) within an Activity.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName
    /// <summary>
    /// An Agent (an individual) is a persona or system.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// A digital artifact providing evidence of a learning experience.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Attachment"></see></summary>
    let Attachment = Namespaced_IRI.parse _namespace_name "Attachment" |> NamespacedName

    /// <summary>
    /// The concept of verifying the identity of a user or system. Authentication allows interactions between the two "trusted" parties.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Authentication"></see></summary>
    let Authentication =
        Namespaced_IRI.parse _namespace_name "Authentication" |> NamespacedName

    /// <summary>
    /// The affordance of permissions based on a user or system's role; the process of making one user or system "trusted" by another.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Authorization"></see></summary>
    let Authorization =
        Namespaced_IRI.parse _namespace_name "Authorization" |> NamespacedName

    /// <summary>
    /// The maximal path under all Experience API endpoints, including a slash. E.g. an LRS with a statements endpoint of http://example.com/xAPI/statements would have a Base Endpoint of http://example.com/xAPI/"
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#BaseEndpoint"></see></summary>
    let BaseEndpoint =
        Namespaced_IRI.parse _namespace_name "BaseEndpoint" |> NamespacedName

    /// <summary>
    /// An Activity used to categorize the Statement. "Tags” would be a synonym. Category SHOULD be used to indicate a “profile” of xAPI behaviors, as well as other categorizations. For example: Anna attempts a biology exam, and the Statement is tracked using the CMI–5 profile. The Statement’s Activity refers to the exam, and the category is the CMI–5 profile.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Category"></see></summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName
    /// <summary>
    /// Refers to any entity that may interact with an LRS. A Client can be an Activity Provider, reporting tool, an LMS, or another LRS.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Client"></see></summary>
    let Client = Namespaced_IRI.parse _namespace_name "Client" |> NamespacedName

    /// <summary>
    /// A group, usually connected by a common cause, role or purpose, which operates in a common modality.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#CommunityOfPractice"></see></summary>
    let CommunityOfPractice =
        Namespaced_IRI.parse _namespace_name "CommunityOfPractice" |> NamespacedName

    /// <summary>
    /// An optional field that provides a place to add contextual information to a Statement. All properties are optional.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Context"></see></summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#ContextActivity"></see>
    /// </summary>
    let ContextActivity =
        Namespaced_IRI.parse _namespace_name "ContextActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#Extension"></see>
    /// </summary>
    let Extension = Namespaced_IRI.parse _namespace_name "Extension" |> NamespacedName
    /// <summary>
    /// A Group represents a collection of Agents and can be used in most of the same situations an Agent can be used. There are two types of Groups, anonymous and identified.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// an Activity with an indirect relation to the Activity which is the Object of the Statement. For example: a course that is part of a qualification. The course has several classes. The course relates to a class as the parent, the qualification relates to the class as the grouping.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Grouping"></see></summary>
    let Grouping = Namespaced_IRI.parse _namespace_name "Grouping" |> NamespacedName
    /// <summary>
    /// A unique identifier which may be an IRL. In the xAPI, all IRIs should be a full absolute IRIs including a scheme. Relative IRIs should not be used. IRLs should be defined within a domain controlled by the person creating the IRL.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#IRI"></see></summary>
    let IRI = Namespaced_IRI.parse _namespace_name "IRI" |> NamespacedName
    /// <summary>
    /// In the context of this document, an IRL is an IRI that when translated into a URI (per the IRI to URI rules), is a URL. Some communities of practice simply use URL even if they use IRIs, which isn't as technically correct within xAPI.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#IRL"></see></summary>
    let IRL = Namespaced_IRI.parse _namespace_name "IRL" |> NamespacedName
    /// <summary>
    /// Adjective used to describe things which cannot be changed. With some exceptions, Statements in the xAPI are immutable. This ensures that when Statements are shared between LRSs, multiple copies of the Statement remain the same.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Immutable"></see></summary>
    let Immutable = Namespaced_IRI.parse _namespace_name "Immutable" |> NamespacedName

    /// <summary>
    /// Traditional e-learning has included structures for interactions or assessments. As a way to allow these practices and structures to extend Experience API's utility, this specification includes built-in definitions for interactions, which borrows from the SCORM 2004 4th Edition Data Model. These definitions are intended to provide a simple and familiar utility for recording interaction data. These definitions are simple to use, and consequently limited. It is expected that communities of practice requiring richer interactions definitions will do so through the use of extensions to an Activity's type and definition.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#InteractionActivity"></see></summary>
    let InteractionActivity =
        Namespaced_IRI.parse _namespace_name "InteractionActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#InteractionComponent"></see>
    /// </summary>
    let InteractionComponent =
        Namespaced_IRI.parse _namespace_name "InteractionComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#InverseFunctionalIdentifier"></see>
    /// </summary>
    let InverseFunctionalIdentifier =
        Namespaced_IRI.parse _namespace_name "InverseFunctionalIdentifier" |> NamespacedName

    /// <summary>
    /// A software package used to administer one or more courses to one or more learners. An LMS is typically a web-based system that allows learners to authenticate themselves, register for courses, complete courses and take assessments
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#LMS"></see></summary>
    let LMS = Namespaced_IRI.parse _namespace_name "LMS" |> NamespacedName
    /// <summary>
    /// A system that stores learning information. Prior to the xAPI most LRSs were Learning Management Systems (LMSs); however this document uses the term LRS to be clear that a full LMS is not necessary to implement the xAPI. The xAPI is dependent on an LRS to function.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#LRS"></see></summary>
    let LRS = Namespaced_IRI.parse _namespace_name "LRS" |> NamespacedName

    /// <summary>
    /// A language map is a dictionary where the key is a  RFC 5646 Language Tag, and the value is an string in the language specified in the tag. This map should be populated as fully as possible based on the knowledge of the string in question in different languages.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#LanguageMap"></see></summary>
    let LanguageMap =
        Namespaced_IRI.parse _namespace_name "LanguageMap" |> NamespacedName

    /// <summary>
    /// Three levels of obligation with regards to conformance to the xAPI specification. A system that fails to implement a MUST (or a MUST NOT) requirement is non-conformant. Failing to meet a SHOULD requirement is not a violation of conformity, but goes against best practices. MAY indicates an option, to be decided by the developer with no consequences for conformity.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#MSM"></see></summary>
    let MSM = Namespaced_IRI.parse _namespace_name "MSM" |> NamespacedName
    /// <summary>
    /// The Object of a Statement can be an Activity, Agent/Group, Sub-Statement, or Statement Reference. It is the "this" part of the Statement, i.e. "I did this".
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    /// A context Activity that doesn’t fit one of the other fields. For example: Anna studies a textbook for a biology exam. The Statement’s Activity refers to the textbook, and the exam is a context Activity of type “other”.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Other"></see></summary>
    let Other = Namespaced_IRI.parse _namespace_name "Other" |> NamespacedName
    /// <summary>
    /// An Activity with a direct relation to the Activity which is the Object of the Statement. In almost all cases there is only one sensible parent or none, not multiple. For example: a Statement about a quiz question would have the quiz as its parent Activity.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Parent"></see></summary>
    let Parent = Namespaced_IRI.parse _namespace_name "Parent" |> NamespacedName
    /// <summary>
    /// A construct where information about the learner or activity is kept, typically in name/document pairs that have meaning to an instructional system component.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Profile"></see></summary>
    let Profile = Namespaced_IRI.parse _namespace_name "Profile" |> NamespacedName
    /// <summary>
    /// An architecture for designing networked web Services. It relies on HTTP methods and uses current web best practices.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#REST"></see></summary>
    let REST = Namespaced_IRI.parse _namespace_name "REST" |> NamespacedName

    /// <summary>
    /// An instance of a learner experiencing a particular Activity.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Registration"></see></summary>
    let Registration =
        Namespaced_IRI.parse _namespace_name "Registration" |> NamespacedName

    /// <summary>
    /// An optional field that represents a measured outcome related to the Statement in which it is included.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Result"></see></summary>
    let Result = Namespaced_IRI.parse _namespace_name "Result" |> NamespacedName
    /// <summary>
    /// An optional field that represents the outcome of a graded Activity achieved by an Agent.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Score"></see></summary>
    let Score = Namespaced_IRI.parse _namespace_name "Score" |> NamespacedName
    /// <summary>
    /// A software component responsible for one or more aspects of the distributed learning process. An LMS typically combines many services to design a complete learning experience.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#Statement"></see>
    /// </summary>
    let Statement = Namespaced_IRI.parse _namespace_name "Statement" |> NamespacedName
    /// <summary>
    /// The previous name of the API defined in this document, often used in informal references to the Experience API.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#TinCanAPI"></see></summary>
    let TinCanAPI = Namespaced_IRI.parse _namespace_name "TinCanAPI" |> NamespacedName
    /// <summary>
    /// Defines the action being done by the Actor within the Activity within a Statement.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#Verb"></see></summary>
    let Verb = Namespaced_IRI.parse _namespace_name "Verb" |> NamespacedName
    /// <summary>
    /// Account property
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasAccount"></see></summary>
    let hasAccount = Namespaced_IRI.parse _namespace_name "hasAccount" |> NamespacedName

    /// <summary>
    /// The unique id or name used to log in to this account. This is based on FOAF’s accountName.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasAccountName"></see></summary>
    let hasAccountName =
        Namespaced_IRI.parse _namespace_name "hasAccountName" |> NamespacedName

    /// <summary>
    /// A description of the Activity
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionDescription"></see></summary>
    let hasActivityDefinitionDescription =
        Namespaced_IRI.parse _namespace_name "hasActivityDefinitionDescription" |> NamespacedName

    /// <summary>
    /// The human readable visual name of the Activity
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionName"></see></summary>
    let hasActivityDefinitionName =
        Namespaced_IRI.parse _namespace_name "hasActivityDefinitionName" |> NamespacedName

    /// <summary>
    /// The type of Activity.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionType"></see></summary>
    let hasActivityDefinitionType =
        Namespaced_IRI.parse _namespace_name "hasActivityDefinitionType" |> NamespacedName

    /// <summary>
    /// An mandatory Agent or Group Object
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasActor"></see></summary>
    let hasActor = Namespaced_IRI.parse _namespace_name "hasActor" |> NamespacedName

    /// <summary>
    /// Either an Agent or Group of agents
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasActorObjectType"></see></summary>
    let hasActorObjectType =
        Namespaced_IRI.parse _namespace_name "hasActorObjectType" |> NamespacedName

    /// <summary>
    /// Full name of the Agent.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasAgentName"></see></summary>
    let hasAgentName =
        Namespaced_IRI.parse _namespace_name "hasAgentName" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasAttachment"></see>
    /// </summary>
    let hasAttachment =
        Namespaced_IRI.parse _namespace_name "hasAttachment" |> NamespacedName

    /// <summary>
    /// The authority property provides information about whom or what has asserted that this Statement is true.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasAuthority"></see></summary>
    let hasAuthority =
        Namespaced_IRI.parse _namespace_name "hasAuthority" |> NamespacedName

    /// <summary>
    /// Array of interaction components
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasChoice"></see></summary>
    let hasChoice = Namespaced_IRI.parse _namespace_name "hasChoice" |> NamespacedName

    /// <summary>
    /// The content type of the attachment. https://www.ietf.org/rfc/rfc2046.txt?number=2046
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasContentType"></see></summary>
    let hasContentType =
        Namespaced_IRI.parse _namespace_name "hasContentType" |> NamespacedName

    /// <summary>
    /// An optional field that provides a place to add contextual information to a Statement. All properties are optional.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasContext"></see></summary>
    let hasContext = Namespaced_IRI.parse _namespace_name "hasContext" |> NamespacedName

    /// <summary>
    /// A map of types of learning activity context that this Statement is related to.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasContextActivity"></see></summary>
    let hasContextActivity =
        Namespaced_IRI.parse _namespace_name "hasContextActivity" |> NamespacedName

    /// <summary>
    /// Description of the attachment
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasDescription"></see></summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasDisplay"></see>
    /// </summary>
    let hasDisplay = Namespaced_IRI.parse _namespace_name "hasDisplay" |> NamespacedName

    /// <summary>
    /// Period of time over which the Statement occurred. Formatted according to ISO 8601 with a precision of 0.01 seconds
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasDuration"></see></summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    /// A map of other properties as needed.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasExtension"></see></summary>
    let hasExtension =
        Namespaced_IRI.parse _namespace_name "hasExtension" |> NamespacedName

    /// <summary>
    /// Name of the group.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasGroupName"></see></summary>
    let hasGroupName =
        Namespaced_IRI.parse _namespace_name "hasGroupName" |> NamespacedName

    /// <summary>
    /// The canonical home page for the system the account is on. This is based on FOAF’s accountServiceHomePage.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasHomePage"></see></summary>
    let hasHomePage =
        Namespaced_IRI.parse _namespace_name "hasHomePage" |> NamespacedName

    /// <summary>
    /// A UUID (see RFC 4122 for requirements, and the UUID must be in standard string form).
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasID"></see></summary>
    let hasID = Namespaced_IRI.parse _namespace_name "hasID" |> NamespacedName

    /// <summary>
    /// Instructor that the Statement relates to, if not included as the Actor of the Statement.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasInstructor"></see></summary>
    let hasInstructor =
        Namespaced_IRI.parse _namespace_name "hasInstructor" |> NamespacedName

    /// <summary>
    /// A description of the interaction component (for example, the text for a given choice in a multiple-choice interaction)
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionComponentDescription"></see></summary>
    let hasInteractionComponentDescription =
        Namespaced_IRI.parse _namespace_name "hasInteractionComponentDescription" |> NamespacedName

    /// <summary>
    /// A value such as used in practice for "cmi.interactions.n.id" as defined in the SCORM 2004 4th Edition Run-Time Environment
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionComponentID"></see></summary>
    let hasInteractionComponentID =
        Namespaced_IRI.parse _namespace_name "hasInteractionComponentID" |> NamespacedName

    /// <summary>
    /// Corresponds to "cmi.interactions.n.correct_responses.n.pattern" as defined in the SCORM 2004 4th Edition Run-Time Environment, where the final n is the index of the array.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionCorrectResponsesPattern"></see></summary>
    let hasInteractionCorrectResponsesPattern =
        Namespaced_IRI.parse _namespace_name "hasInteractionCorrectResponsesPattern" |> NamespacedName

    /// <summary>
    /// As in "cmi.interactions.n.type" as defined in the SCORM 2004 4th Edition Run-Time Environment.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionType"></see></summary>
    let hasInteractionType =
        Namespaced_IRI.parse _namespace_name "hasInteractionType" |> NamespacedName

    /// <summary>
    /// An Inverse Functional Identifier unique to the Agent.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasInverseFunctionalIdentifier"></see></summary>
    let hasInverseFunctionalIdentifier =
        Namespaced_IRI.parse _namespace_name "hasInverseFunctionalIdentifier" |> NamespacedName

    /// <summary>
    /// Code representing the language in which the experience being recorded in this Statement (mainly) occurred in, if applicable and known. As defined in RFC 5646
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasLanguage"></see></summary>
    let hasLanguage =
        Namespaced_IRI.parse _namespace_name "hasLanguage" |> NamespacedName

    /// <summary>
    /// Language tags are used to help identify languages, whether spoken, written, signed, or otherwise signaled, for the purpose of communication. This includes constructed and artificial languages but excludes languages not intended primarily for human communication, such as programming languages.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasLanguageTag"></see></summary>
    let hasLanguageTag =
        Namespaced_IRI.parse _namespace_name "hasLanguageTag" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasLanguageVerb"></see>
    /// </summary>
    let hasLanguageVerb =
        Namespaced_IRI.parse _namespace_name "hasLanguageVerb" |> NamespacedName

    /// <summary>
    /// The length of the attachment data in octets.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasLength"></see></summary>
    let hasLength = Namespaced_IRI.parse _namespace_name "hasLength" |> NamespacedName
    /// <summary>
    /// Decimal number greater than min (if present). Cf. ‘cmi.score.max’
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasMax"></see></summary>
    let hasMax = Namespaced_IRI.parse _namespace_name "hasMax" |> NamespacedName
    /// <summary>
    /// The required format is "mailto:email address". Only email addresses that have only ever been and will ever be assigned to this Agent, but no others, should be used for this property and mbox_sha1sum.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasMbox"></see></summary>
    let hasMbox = Namespaced_IRI.parse _namespace_name "hasMbox" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasMember"></see>
    /// </summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// Decimal number less than max (if present)
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasMin"></see></summary>
    let hasMin = Namespaced_IRI.parse _namespace_name "hasMin" |> NamespacedName

    /// <summary>
    /// Resolves to a document with human-readable information about the Actiivty, which could include a way to launch the activity.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasMoreInfo"></see></summary>
    let hasMoreInfo =
        Namespaced_IRI.parse _namespace_name "hasMoreInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName
    /// <summary>
    /// Activity, Agent, or another Statement that is the Object of the Statement. Represents the "This" in "I Did This". Note that Objects which are provided as a value for this field should include an "objectType" field. If not specified, the Object is assumed to be an Activity.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasObject"></see></summary>
    let hasObject = Namespaced_IRI.parse _namespace_name "hasObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasObjectDefinition"></see>
    /// </summary>
    let hasObjectDefinition =
        Namespaced_IRI.parse _namespace_name "hasObjectDefinition" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasObjectExtension"></see>
    /// </summary>
    let hasObjectExtension =
        Namespaced_IRI.parse _namespace_name "hasObjectExtension" |> NamespacedName

    /// <summary>
    /// An identifier for a single unique Activity
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasObjectID"></see></summary>
    let hasObjectID =
        Namespaced_IRI.parse _namespace_name "hasObjectID" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasObjectInteration"></see>
    /// </summary>
    let hasObjectInteration =
        Namespaced_IRI.parse _namespace_name "hasObjectInteration" |> NamespacedName

    /// <summary>
    /// Can be an Activity, Agent, Group, Statement or SubStatemen
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasObjectType"></see></summary>
    let hasObjectType =
        Namespaced_IRI.parse _namespace_name "hasObjectType" |> NamespacedName

    /// <summary>
    /// An openID that uniquely identifies the Agent.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasOpenID"></see></summary>
    let hasOpenID = Namespaced_IRI.parse _namespace_name "hasOpenID" |> NamespacedName

    /// <summary>
    /// Platform used in the experience of this learning activity.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasPlatform"></see></summary>
    let hasPlatform =
        Namespaced_IRI.parse _namespace_name "hasPlatform" |> NamespacedName

    /// <summary>
    /// Decimal number between min and max (if present, otherwise unrestricted), inclusive.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasRaw"></see></summary>
    let hasRaw = Namespaced_IRI.parse _namespace_name "hasRaw" |> NamespacedName

    /// <summary>
    /// The registration that the Statement is associated with. UUID
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasRegistration"></see></summary>
    let hasRegistration =
        Namespaced_IRI.parse _namespace_name "hasRegistration" |> NamespacedName

    /// <summary>
    /// A response appropriately formatted for the given Activity.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasResponse"></see></summary>
    let hasResponse =
        Namespaced_IRI.parse _namespace_name "hasResponse" |> NamespacedName

    /// <summary>
    /// An optional field that represents a measured outcome related to the Statement in which it is included.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasResult"></see></summary>
    let hasResult = Namespaced_IRI.parse _namespace_name "hasResult" |> NamespacedName

    /// <summary>
    /// Revision of the learning activity associated with this Statement. Format is free.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasRevision"></see></summary>
    let hasRevision =
        Namespaced_IRI.parse _namespace_name "hasRevision" |> NamespacedName

    /// <summary>
    /// Array of interaction components
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasScale"></see></summary>
    let hasScale = Namespaced_IRI.parse _namespace_name "hasScale" |> NamespacedName
    /// <summary>
    /// Decimal number between –1 and 1, inclusive. Cf. ‘cmi.score.scaled’ in SCORM 2004 4th Edition
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasScaled"></see></summary>
    let hasScaled = Namespaced_IRI.parse _namespace_name "hasScaled" |> NamespacedName
    /// <summary>
    /// The score of the Agent in relation to the success or quality of the experience.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasScore"></see></summary>
    let hasScore = Namespaced_IRI.parse _namespace_name "hasScore" |> NamespacedName
    /// <summary>
    /// The SHA-2 (SHA-256, SHA-384, SHA-512) hash of the attachment data. SHA-224 SHOULD not be used: a minimum key size of 256 bits is recommended.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasSha-2"></see></summary>
    let ``hasSha-2`` = Namespaced_IRI.parse _namespace_name "hasSha-2" |> NamespacedName
    /// <summary>
    /// The SHA1 hash of a mailto IRI (i.e. the value of an mbox property). An LRS MAY include Agents with a matching hash when a request is based on an mbox.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasSha1sum"></see></summary>
    let hasSha1sum = Namespaced_IRI.parse _namespace_name "hasSha1sum" |> NamespacedName
    /// <summary>
    /// Array of interaction components
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasSource"></see></summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName

    /// <summary>
    /// Another Statement, which should be considered as context for this Statement.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasStatement"></see></summary>
    let hasStatement =
        Namespaced_IRI.parse _namespace_name "hasStatement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasStatementID"></see>
    /// </summary>
    let hasStatementID =
        Namespaced_IRI.parse _namespace_name "hasStatementID" |> NamespacedName

    /// <summary>
    /// Array of interaction components
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasStep"></see></summary>
    let hasStep = Namespaced_IRI.parse _namespace_name "hasStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasStoredTime"></see>
    /// </summary>
    let hasStoredTime =
        Namespaced_IRI.parse _namespace_name "hasStoredTime" |> NamespacedName

    /// <summary>
    /// Array of interaction components
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasTarget"></see></summary>
    let hasTarget = Namespaced_IRI.parse _namespace_name "hasTarget" |> NamespacedName
    /// <summary>
    /// Team that this Statement relates to, if not included as the Actor of the Statement.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasTeam"></see></summary>
    let hasTeam = Namespaced_IRI.parse _namespace_name "hasTeam" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi#hasTimeStamp"></see>
    /// </summary>
    let hasTimeStamp =
        Namespaced_IRI.parse _namespace_name "hasTimeStamp" |> NamespacedName

    /// <summary>
    /// An IRL at which the attachment data may be retrieved, or from which it used  to be retrievable.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasUrl"></see></summary>
    let hasUrl = Namespaced_IRI.parse _namespace_name "hasUrl" |> NamespacedName

    /// <summary>
    /// Identifies the usage of this attachment. For example: one expected use case for attachments is to include a "completion certificate". A type IRI corresponding to this usage should be coined, and used with completion certificate attachments.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasUsageType"></see></summary>
    let hasUsageType =
        Namespaced_IRI.parse _namespace_name "hasUsageType" |> NamespacedName

    /// <summary>
    /// Action of the Learner or Team Object. Represents the "Did" in "I Did This".
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasVerb"></see></summary>
    let hasVerb = Namespaced_IRI.parse _namespace_name "hasVerb" |> NamespacedName
    /// <summary>
    /// Corresponds to a Verb definition. Each Verb definition corresponds to the meaning of a Verb, not the word. The IRI should be human-readable and contain the Verb meaning.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasVerbID"></see></summary>
    let hasVerbID = Namespaced_IRI.parse _namespace_name "hasVerbID" |> NamespacedName
    /// <summary>
    /// Version information in Statements helps systems that process data from an LRS get their bearings. Since the Statement data model is guaranteed consistent through all 1.0.x versions, in order to support data flow among such LRSs the LRS is given some flexibility on Statement versions that are accepted.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// Indicates whether or not the Activity was completed.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#isCompleted"></see></summary>
    let isCompleted =
        Namespaced_IRI.parse _namespace_name "isCompleted" |> NamespacedName

    /// <summary>
    /// Indicates whether or not the attempt on the Activity was successful.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#isSuccess"></see></summary>
    let isSuccess = Namespaced_IRI.parse _namespace_name "isSuccess" |> NamespacedName
    /// <summary>
    /// The API defined in this document, the product of "Project Tin Can". A simple, lightweight way for any permitted Actor to store and retrieve extensible learning records, learner and learning experience profiles, regardless of platform.
    /// <see href="http://ns.inria.fr/ludo/v1/xapi#xAPI"></see></summary>
    let xAPI = Namespaced_IRI.parse _namespace_name "xAPI" |> NamespacedName
