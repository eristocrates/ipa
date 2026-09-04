#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ludo-xapi`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ns.inria.fr/ludo/v1/xapi#" "ludo-xapi"

    /// <summary>
    ///   <para>rdfs:label : Account</para>
    ///   <para>rdfs:comment : A user account on an existing system, such as a private system (LMS or intranet) or a public system (social networking site).</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Account">ludo-xapi:Account</a>
    /// </summary>
    let Account = _prefixId.prefix "Account"
    /// <summary>
    ///   <para>rdfs:label : Activity</para>
    ///   <para>rdfs:comment : An Activity is a type of Object making up the “this” in I did “this”; it is something with which an Actor interacted. It can be a unit of instruction, experience, or performance that is to be tracked in meaningful combination with a Verb. Interpretation of Activity is broad, meaning that Activities can even be tangible objects such as a chair (real or virtual). In the statement "Anna tried a cake recipe", the recipe constitutes the Activity in terms of the xAPI statement. Other examples of activities include a book, an e-learning course, a hike or a meeting.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Activity">ludo-xapi:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : Activity Definition</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#ActivityDefinition">ludo-xapi:ActivityDefinition</a>
    /// </summary>
    let ActivityDefinition = _prefixId.prefix "ActivityDefinition"
    /// <summary>
    ///   <para>rdfs:label : Activity Provider</para>
    ///   <para>rdfs:comment : The software object that is communicating with the LRS to record information about a learning experience. May be similar to a SCORM package in that it is possible to bundle learning assets with the software object that performs this communication, but an Activity Provider may also be separate from the experience it is reporting about.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#ActivityProvider">ludo-xapi:ActivityProvider</a>
    /// </summary>
    let ActivityProvider = _prefixId.prefix "ActivityProvider"
    /// <summary>
    ///   <para>rdfs:label : Actor</para>
    ///   <para>rdfs:comment : An identity or persona of an individual or group tracked using Statements as doing an action (Verb) within an Activity.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Actor">ludo-xapi:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : An Agent (an individual) is a persona or system.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Agent">ludo-xapi:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : Attachment</para>
    ///   <para>rdfs:comment : A digital artifact providing evidence of a learning experience.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Attachment">ludo-xapi:Attachment</a>
    /// </summary>
    let Attachment = _prefixId.prefix "Attachment"
    /// <summary>
    ///   <para>rdfs:label : Authentication</para>
    ///   <para>rdfs:comment : The concept of verifying the identity of a user or system. Authentication allows interactions between the two "trusted" parties.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Authentication">ludo-xapi:Authentication</a>
    /// </summary>
    let Authentication = _prefixId.prefix "Authentication"
    /// <summary>
    ///   <para>rdfs:label : Authorization</para>
    ///   <para>rdfs:comment : The affordance of permissions based on a user or system's role; the process of making one user or system "trusted" by another.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Authorization">ludo-xapi:Authorization</a>
    /// </summary>
    let Authorization = _prefixId.prefix "Authorization"
    /// <summary>
    ///   <para>rdfs:label : Base Endpoint</para>
    ///   <para>rdfs:comment : The maximal path under all Experience API endpoints, including a slash. E.g. an LRS with a statements endpoint of http://example.com/xAPI/statements would have a Base Endpoint of http://example.com/xAPI/"</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#BaseEndpoint">ludo-xapi:BaseEndpoint</a>
    /// </summary>
    let BaseEndpoint = _prefixId.prefix "BaseEndpoint"
    /// <summary>
    ///   <para>rdfs:label : Category</para>
    ///   <para>rdfs:comment : An Activity used to categorize the Statement. "Tags” would be a synonym. Category SHOULD be used to indicate a “profile” of xAPI behaviors, as well as other categorizations. For example: Anna attempts a biology exam, and the Statement is tracked using the CMI–5 profile. The Statement’s Activity refers to the exam, and the category is the CMI–5 profile.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Category">ludo-xapi:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>rdfs:label : Client</para>
    ///   <para>rdfs:comment : Refers to any entity that may interact with an LRS. A Client can be an Activity Provider, reporting tool, an LMS, or another LRS.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Client">ludo-xapi:Client</a>
    /// </summary>
    let Client = _prefixId.prefix "Client"
    /// <summary>
    ///   <para>rdfs:label : Community of Practice</para>
    ///   <para>rdfs:comment : A group, usually connected by a common cause, role or purpose, which operates in a common modality.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#CommunityOfPractice">ludo-xapi:CommunityOfPractice</a>
    /// </summary>
    let CommunityOfPractice = _prefixId.prefix "CommunityOfPractice"
    /// <summary>
    ///   <para>rdfs:label : Context</para>
    ///   <para>rdfs:comment : An optional field that provides a place to add contextual information to a Statement. All properties are optional.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Context">ludo-xapi:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:label : Context Activity</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#ContextActivity">ludo-xapi:ContextActivity</a>
    /// </summary>
    let ContextActivity = _prefixId.prefix "ContextActivity"
    /// <summary>
    ///   <para>rdfs:label : Extension</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Extension">ludo-xapi:Extension</a>
    /// </summary>
    let Extension = _prefixId.prefix "Extension"
    /// <summary>
    ///   <para>rdfs:label : Group</para>
    ///   <para>rdfs:comment : A Group represents a collection of Agents and can be used in most of the same situations an Agent can be used. There are two types of Groups, anonymous and identified.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Group">ludo-xapi:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : Grouping</para>
    ///   <para>rdfs:comment : an Activity with an indirect relation to the Activity which is the Object of the Statement. For example: a course that is part of a qualification. The course has several classes. The course relates to a class as the parent, the qualification relates to the class as the grouping.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Grouping">ludo-xapi:Grouping</a>
    /// </summary>
    let Grouping = _prefixId.prefix "Grouping"
    /// <summary>
    ///   <para>rdfs:label : International Resource Identifier</para>
    ///   <para>rdfs:comment : A unique identifier which may be an IRL. In the xAPI, all IRIs should be a full absolute IRIs including a scheme. Relative IRIs should not be used. IRLs should be defined within a domain controlled by the person creating the IRL.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#IRI">ludo-xapi:IRI</a>
    /// </summary>
    let IRI = _prefixId.prefix "IRI"
    /// <summary>
    ///   <para>rdfs:label : International Resource Locator</para>
    ///   <para>rdfs:comment : In the context of this document, an IRL is an IRI that when translated into a URI (per the IRI to URI rules), is a URL. Some communities of practice simply use URL even if they use IRIs, which isn't as technically correct within xAPI.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#IRL">ludo-xapi:IRL</a>
    /// </summary>
    let IRL = _prefixId.prefix "IRL"
    /// <summary>
    ///   <para>rdfs:label : Immutable</para>
    ///   <para>rdfs:comment : Adjective used to describe things which cannot be changed. With some exceptions, Statements in the xAPI are immutable. This ensures that when Statements are shared between LRSs, multiple copies of the Statement remain the same.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Immutable">ludo-xapi:Immutable</a>
    /// </summary>
    let Immutable = _prefixId.prefix "Immutable"
    /// <summary>
    ///   <para>rdfs:label : Interaction Activity</para>
    ///   <para>rdfs:comment : Traditional e-learning has included structures for interactions or assessments. As a way to allow these practices and structures to extend Experience API's utility, this specification includes built-in definitions for interactions, which borrows from the SCORM 2004 4th Edition Data Model. These definitions are intended to provide a simple and familiar utility for recording interaction data. These definitions are simple to use, and consequently limited. It is expected that communities of practice requiring richer interactions definitions will do so through the use of extensions to an Activity's type and definition.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#InteractionActivity">ludo-xapi:InteractionActivity</a>
    /// </summary>
    let InteractionActivity = _prefixId.prefix "InteractionActivity"
    /// <summary>
    ///   <para>rdfs:label : Interaction Component</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#InteractionComponent">ludo-xapi:InteractionComponent</a>
    /// </summary>
    let InteractionComponent = _prefixId.prefix "InteractionComponent"
    /// <summary>
    ///   <para>rdfs:label : Inverse Functional Identifier</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#InverseFunctionalIdentifier">ludo-xapi:InverseFunctionalIdentifier</a>
    /// </summary>
    let InverseFunctionalIdentifier = _prefixId.prefix "InverseFunctionalIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Learning Management System</para>
    ///   <para>rdfs:comment : A software package used to administer one or more courses to one or more learners. An LMS is typically a web-based system that allows learners to authenticate themselves, register for courses, complete courses and take assessments</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#LMS">ludo-xapi:LMS</a>
    /// </summary>
    let LMS = _prefixId.prefix "LMS"
    /// <summary>
    ///   <para>rdfs:label : Learning Record Store</para>
    ///   <para>rdfs:comment : A system that stores learning information. Prior to the xAPI most LRSs were Learning Management Systems (LMSs); however this document uses the term LRS to be clear that a full LMS is not necessary to implement the xAPI. The xAPI is dependent on an LRS to function.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#LRS">ludo-xapi:LRS</a>
    /// </summary>
    let LRS = _prefixId.prefix "LRS"
    /// <summary>
    ///   <para>rdfs:label : LanguageMap</para>
    ///   <para>rdfs:comment : A language map is a dictionary where the key is a  RFC 5646 Language Tag, and the value is an string in the language specified in the tag. This map should be populated as fully as possible based on the knowledge of the string in question in different languages.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#LanguageMap">ludo-xapi:LanguageMap</a>
    /// </summary>
    let LanguageMap = _prefixId.prefix "LanguageMap"
    /// <summary>
    ///   <para>rdfs:label : MUST / SHOULD / MAY</para>
    ///   <para>rdfs:comment : Three levels of obligation with regards to conformance to the xAPI specification. A system that fails to implement a MUST (or a MUST NOT) requirement is non-conformant. Failing to meet a SHOULD requirement is not a violation of conformity, but goes against best practices. MAY indicates an option, to be decided by the developer with no consequences for conformity.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#MSM">ludo-xapi:MSM</a>
    /// </summary>
    let MSM = _prefixId.prefix "MSM"
    /// <summary>
    ///   <para>rdfs:label : Object</para>
    ///   <para>rdfs:comment : The Object of a Statement can be an Activity, Agent/Group, Sub-Statement, or Statement Reference. It is the "this" part of the Statement, i.e. "I did this".</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Object">ludo-xapi:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:label : Other</para>
    ///   <para>rdfs:comment : A context Activity that doesn’t fit one of the other fields. For example: Anna studies a textbook for a biology exam. The Statement’s Activity refers to the textbook, and the exam is a context Activity of type “other”.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Other">ludo-xapi:Other</a>
    /// </summary>
    let Other = _prefixId.prefix "Other"
    /// <summary>
    ///   <para>rdfs:label : Parent</para>
    ///   <para>rdfs:comment : An Activity with a direct relation to the Activity which is the Object of the Statement. In almost all cases there is only one sensible parent or none, not multiple. For example: a Statement about a quiz question would have the quiz as its parent Activity.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Parent">ludo-xapi:Parent</a>
    /// </summary>
    let Parent = _prefixId.prefix "Parent"
    /// <summary>
    ///   <para>rdfs:label : Profile</para>
    ///   <para>rdfs:comment : A construct where information about the learner or activity is kept, typically in name/document pairs that have meaning to an instructional system component.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Profile">ludo-xapi:Profile</a>
    /// </summary>
    let Profile = _prefixId.prefix "Profile"
    /// <summary>
    ///   <para>rdfs:label : REST</para>
    ///   <para>rdfs:comment : An architecture for designing networked web Services. It relies on HTTP methods and uses current web best practices.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#REST">ludo-xapi:REST</a>
    /// </summary>
    let REST = _prefixId.prefix "REST"
    /// <summary>
    ///   <para>rdfs:label : Registration</para>
    ///   <para>rdfs:comment : An instance of a learner experiencing a particular Activity.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Registration">ludo-xapi:Registration</a>
    /// </summary>
    let Registration = _prefixId.prefix "Registration"
    /// <summary>
    ///   <para>rdfs:label : Result</para>
    ///   <para>rdfs:comment : An optional field that represents a measured outcome related to the Statement in which it is included.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Result">ludo-xapi:Result</a>
    /// </summary>
    let Result = _prefixId.prefix "Result"
    /// <summary>
    ///   <para>rdfs:label : Score</para>
    ///   <para>rdfs:comment : An optional field that represents the outcome of a graded Activity achieved by an Agent.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Score">ludo-xapi:Score</a>
    /// </summary>
    let Score = _prefixId.prefix "Score"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : A software component responsible for one or more aspects of the distributed learning process. An LMS typically combines many services to design a complete learning experience.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Service">ludo-xapi:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    let Statement = _prefixId.prefix "Statement"
    /// <summary>
    ///   <para>rdfs:label : TIN CAN API</para>
    ///   <para>rdfs:comment : The previous name of the API defined in this document, often used in informal references to the Experience API.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#TinCanAPI">ludo-xapi:TinCanAPI</a>
    /// </summary>
    let TinCanAPI = _prefixId.prefix "TinCanAPI"
    /// <summary>
    ///   <para>rdfs:label : Verb</para>
    ///   <para>rdfs:comment : Defines the action being done by the Actor within the Activity within a Statement.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#Verb">ludo-xapi:Verb</a>
    /// </summary>
    let Verb = _prefixId.prefix "Verb"
    /// <summary>
    ///   <para>rdfs:label : Account^^xsd:string</para>
    ///   <para>rdfs:comment : Account property^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasAccount">ludo-xapi:hasAccount</a>
    /// </summary>
    let hasAccount = _prefixId.prefix "hasAccount"
    /// <summary>
    ///   <para>rdfs:label : Account Name</para>
    ///   <para>rdfs:comment : The unique id or name used to log in to this account. This is based on FOAF’s accountName.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasAccountName">ludo-xapi:hasAccountName</a>
    /// </summary>
    let hasAccountName = _prefixId.prefix "hasAccountName"

    /// <summary>
    ///   <para>rdfs:label : Activity Definition Description</para>
    ///   <para>rdfs:comment : A description of the Activity</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionDescription">ludo-xapi:hasActivityDefinitionDescription</a>
    /// </summary>
    let hasActivityDefinitionDescription =
        _prefixId.prefix "hasActivityDefinitionDescription"

    /// <summary>
    ///   <para>rdfs:label : Activity Definition Name</para>
    ///   <para>rdfs:comment : The human readable visual name of the Activity</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionName">ludo-xapi:hasActivityDefinitionName</a>
    /// </summary>
    let hasActivityDefinitionName = _prefixId.prefix "hasActivityDefinitionName"
    /// <summary>
    ///   <para>rdfs:label : Activity Definition Type</para>
    ///   <para>rdfs:comment : The type of Activity.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionType">ludo-xapi:hasActivityDefinitionType</a>
    /// </summary>
    let hasActivityDefinitionType = _prefixId.prefix "hasActivityDefinitionType"
    /// <summary>
    ///   <para>rdfs:label : Actor</para>
    ///   <para>rdfs:comment : An mandatory Agent or Group Object^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasActor">ludo-xapi:hasActor</a>
    /// </summary>
    let hasActor = _prefixId.prefix "hasActor"
    /// <summary>
    ///   <para>rdfs:label : Actor Object Type</para>
    ///   <para>rdfs:comment : Either an Agent or Group of agents</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasActorObjectType">ludo-xapi:hasActorObjectType</a>
    /// </summary>
    let hasActorObjectType = _prefixId.prefix "hasActorObjectType"
    /// <summary>
    ///   <para>rdfs:label : Agent name</para>
    ///   <para>rdfs:comment : Full name of the Agent.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasAgentName">ludo-xapi:hasAgentName</a>
    /// </summary>
    let hasAgentName = _prefixId.prefix "hasAgentName"
    /// <summary>
    ///   <para>rdfs:label : Attachment</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasAttachment">ludo-xapi:hasAttachment</a>
    /// </summary>
    let hasAttachment = _prefixId.prefix "hasAttachment"
    /// <summary>
    ///   <para>rdfs:label : Authority</para>
    ///   <para>rdfs:comment : The authority property provides information about whom or what has asserted that this Statement is true.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasAuthority">ludo-xapi:hasAuthority</a>
    /// </summary>
    let hasAuthority = _prefixId.prefix "hasAuthority"
    /// <summary>
    ///   <para>rdfs:label : Choice</para>
    ///   <para>rdfs:comment : Array of interaction components</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasChoice">ludo-xapi:hasChoice</a>
    /// </summary>
    let hasChoice = _prefixId.prefix "hasChoice"
    /// <summary>
    ///   <para>rdfs:label : Content type</para>
    ///   <para>rdfs:comment : The content type of the attachment. https://www.ietf.org/rfc/rfc2046.txt?number=2046</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasContentType">ludo-xapi:hasContentType</a>
    /// </summary>
    let hasContentType = _prefixId.prefix "hasContentType"
    /// <summary>
    ///   <para>rdfs:label : Context</para>
    ///   <para>rdfs:comment : An optional field that provides a place to add contextual information to a Statement. All properties are optional.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasContext">ludo-xapi:hasContext</a>
    /// </summary>
    let hasContext = _prefixId.prefix "hasContext"
    /// <summary>
    ///   <para>rdfs:label : Context Activity</para>
    ///   <para>rdfs:comment : A map of types of learning activity context that this Statement is related to.^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasContextActivity">ludo-xapi:hasContextActivity</a>
    /// </summary>
    let hasContextActivity = _prefixId.prefix "hasContextActivity"
    /// <summary>
    ///   <para>rdfs:comment : Description of the attachment^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasDescription">ludo-xapi:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    let hasDisplay = _prefixId.prefix "hasDisplay"
    /// <summary>
    ///   <para>rdfs:label : Duration</para>
    ///   <para>rdfs:comment : Period of time over which the Statement occurred. Formatted according to ISO 8601 with a precision of 0.01 seconds</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasDuration">ludo-xapi:hasDuration</a>
    /// </summary>
    let hasDuration = _prefixId.prefix "hasDuration"
    /// <summary>
    ///   <para>rdfs:label : Extension</para>
    ///   <para>rdfs:comment : A map of other properties as needed.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasExtension">ludo-xapi:hasExtension</a>
    /// </summary>
    let hasExtension = _prefixId.prefix "hasExtension"
    /// <summary>
    ///   <para>rdfs:label : Group Name</para>
    ///   <para>rdfs:comment : Name of the group.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasGroupName">ludo-xapi:hasGroupName</a>
    /// </summary>
    let hasGroupName = _prefixId.prefix "hasGroupName"
    /// <summary>
    ///   <para>rdfs:label : Home page</para>
    ///   <para>rdfs:comment : The canonical home page for the system the account is on. This is based on FOAF’s accountServiceHomePage.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasHomePage">ludo-xapi:hasHomePage</a>
    /// </summary>
    let hasHomePage = _prefixId.prefix "hasHomePage"
    /// <summary>
    ///   <para>rdfs:label : ID</para>
    ///   <para>rdfs:comment : A UUID (see RFC 4122 for requirements, and the UUID must be in standard string form).</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasID">ludo-xapi:hasID</a>
    /// </summary>
    let hasID = _prefixId.prefix "hasID"
    /// <summary>
    ///   <para>rdfs:label : Instructor</para>
    ///   <para>rdfs:comment : Instructor that the Statement relates to, if not included as the Actor of the Statement.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasInstructor">ludo-xapi:hasInstructor</a>
    /// </summary>
    let hasInstructor = _prefixId.prefix "hasInstructor"

    /// <summary>
    ///   <para>rdfs:label : Interaction Component Description</para>
    ///   <para>rdfs:comment : A description of the interaction component (for example, the text for a given choice in a multiple-choice interaction)</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionComponentDescription">ludo-xapi:hasInteractionComponentDescription</a>
    /// </summary>
    let hasInteractionComponentDescription =
        _prefixId.prefix "hasInteractionComponentDescription"

    /// <summary>
    ///   <para>rdfs:label : Interaction Component ID</para>
    ///   <para>rdfs:comment : A value such as used in practice for "cmi.interactions.n.id" as defined in the SCORM 2004 4th Edition Run-Time Environment</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionComponentID">ludo-xapi:hasInteractionComponentID</a>
    /// </summary>
    let hasInteractionComponentID = _prefixId.prefix "hasInteractionComponentID"

    /// <summary>
    ///   <para>rdfs:label : Correct Responses Pattern</para>
    ///   <para>rdfs:comment : Corresponds to "cmi.interactions.n.correct_responses.n.pattern" as defined in the SCORM 2004 4th Edition Run-Time Environment, where the final n is the index of the array.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionCorrectResponsesPattern">ludo-xapi:hasInteractionCorrectResponsesPattern</a>
    /// </summary>
    let hasInteractionCorrectResponsesPattern =
        _prefixId.prefix "hasInteractionCorrectResponsesPattern"

    /// <summary>
    ///   <para>rdfs:label : Interaction Type</para>
    ///   <para>rdfs:comment : As in "cmi.interactions.n.type" as defined in the SCORM 2004 4th Edition Run-Time Environment.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionType">ludo-xapi:hasInteractionType</a>
    /// </summary>
    let hasInteractionType = _prefixId.prefix "hasInteractionType"

    /// <summary>
    ///   <para>rdfs:label : Inverse Functional Identifier</para>
    ///   <para>rdfs:comment : An Inverse Functional Identifier unique to the Agent.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasInverseFunctionalIdentifier">ludo-xapi:hasInverseFunctionalIdentifier</a>
    /// </summary>
    let hasInverseFunctionalIdentifier =
        _prefixId.prefix "hasInverseFunctionalIdentifier"

    /// <summary>
    ///   <para>rdfs:label : Language</para>
    ///   <para>rdfs:comment : Code representing the language in which the experience being recorded in this Statement (mainly) occurred in, if applicable and known. As defined in RFC 5646</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasLanguage">ludo-xapi:hasLanguage</a>
    /// </summary>
    let hasLanguage = _prefixId.prefix "hasLanguage"
    /// <summary>
    ///   <para>rdfs:label : Language Tag</para>
    ///   <para>rdfs:comment : Language tags are used to help identify languages, whether spoken, written, signed, or otherwise signaled, for the purpose of communication. This includes constructed and artificial languages but excludes languages not intended primarily for human communication, such as programming languages.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasLanguageTag">ludo-xapi:hasLanguageTag</a>
    /// </summary>
    let hasLanguageTag = _prefixId.prefix "hasLanguageTag"
    /// <summary>
    ///   <para>rdfs:label : Language Verb</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasLanguageVerb">ludo-xapi:hasLanguageVerb</a>
    /// </summary>
    let hasLanguageVerb = _prefixId.prefix "hasLanguageVerb"
    /// <summary>
    ///   <para>rdfs:label : Length</para>
    ///   <para>rdfs:comment : The length of the attachment data in octets.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasLength">ludo-xapi:hasLength</a>
    /// </summary>
    let hasLength = _prefixId.prefix "hasLength"
    /// <summary>
    ///   <para>rdfs:label : Max</para>
    ///   <para>rdfs:comment : Decimal number greater than min (if present). Cf. ‘cmi.score.max’</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasMax">ludo-xapi:hasMax</a>
    /// </summary>
    let hasMax = _prefixId.prefix "hasMax"
    /// <summary>
    ///   <para>rdfs:label : mbox</para>
    ///   <para>rdfs:comment : The required format is "mailto:email address". Only email addresses that have only ever been and will ever be assigned to this Agent, but no others, should be used for this property and mbox_sha1sum.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasMbox">ludo-xapi:hasMbox</a>
    /// </summary>
    let hasMbox = _prefixId.prefix "hasMbox"
    /// <summary>
    ///   <para>rdfs:label : Member</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasMember">ludo-xapi:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : Min</para>
    ///   <para>rdfs:comment : Decimal number less than max (if present)</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasMin">ludo-xapi:hasMin</a>
    /// </summary>
    let hasMin = _prefixId.prefix "hasMin"
    /// <summary>
    ///   <para>rdfs:label : Activity Definition More Info</para>
    ///   <para>rdfs:comment : Resolves to a document with human-readable information about the Actiivty, which could include a way to launch the activity.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasMoreInfo">ludo-xapi:hasMoreInfo</a>
    /// </summary>
    let hasMoreInfo = _prefixId.prefix "hasMoreInfo"
    /// <summary>
    ///   <para>rdfs:label : Name</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasName">ludo-xapi:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : Object</para>
    ///   <para>rdfs:comment : Activity, Agent, or another Statement that is the Object of the Statement. Represents the "This" in "I Did This". Note that Objects which are provided as a value for this field should include an "objectType" field. If not specified, the Object is assumed to be an Activity.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasObject">ludo-xapi:hasObject</a>
    /// </summary>
    let hasObject = _prefixId.prefix "hasObject"
    /// <summary>
    ///   <para>rdfs:label : Object Definition</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasObjectDefinition">ludo-xapi:hasObjectDefinition</a>
    /// </summary>
    let hasObjectDefinition = _prefixId.prefix "hasObjectDefinition"
    /// <summary>
    ///   <para>rdfs:label : Object Extension</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasObjectExtension">ludo-xapi:hasObjectExtension</a>
    /// </summary>
    let hasObjectExtension = _prefixId.prefix "hasObjectExtension"
    /// <summary>
    ///   <para>rdfs:label : Object ID</para>
    ///   <para>rdfs:comment : An identifier for a single unique Activity</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasObjectID">ludo-xapi:hasObjectID</a>
    /// </summary>
    let hasObjectID = _prefixId.prefix "hasObjectID"
    /// <summary>
    ///   <para>rdfs:label : Object Interaction Property</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasObjectInteration">ludo-xapi:hasObjectInteration</a>
    /// </summary>
    let hasObjectInteration = _prefixId.prefix "hasObjectInteration"
    /// <summary>
    ///   <para>rdfs:label : Object Type</para>
    ///   <para>rdfs:comment : Can be an Activity, Agent, Group, Statement or SubStatemen^^xsd:string</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasObjectType">ludo-xapi:hasObjectType</a>
    /// </summary>
    let hasObjectType = _prefixId.prefix "hasObjectType"
    /// <summary>
    ///   <para>rdfs:label : Open ID</para>
    ///   <para>rdfs:comment : An openID that uniquely identifies the Agent.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasOpenID">ludo-xapi:hasOpenID</a>
    /// </summary>
    let hasOpenID = _prefixId.prefix "hasOpenID"
    /// <summary>
    ///   <para>rdfs:label : Platform</para>
    ///   <para>rdfs:comment : Platform used in the experience of this learning activity.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasPlatform">ludo-xapi:hasPlatform</a>
    /// </summary>
    let hasPlatform = _prefixId.prefix "hasPlatform"
    /// <summary>
    ///   <para>rdfs:label : Raw</para>
    ///   <para>rdfs:comment : Decimal number between min and max (if present, otherwise unrestricted), inclusive.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasRaw">ludo-xapi:hasRaw</a>
    /// </summary>
    let hasRaw = _prefixId.prefix "hasRaw"
    /// <summary>
    ///   <para>rdfs:label : Registration</para>
    ///   <para>rdfs:comment : The registration that the Statement is associated with. UUID</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasRegistration">ludo-xapi:hasRegistration</a>
    /// </summary>
    let hasRegistration = _prefixId.prefix "hasRegistration"
    /// <summary>
    ///   <para>rdfs:label : Response</para>
    ///   <para>rdfs:comment : A response appropriately formatted for the given Activity.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasResponse">ludo-xapi:hasResponse</a>
    /// </summary>
    let hasResponse = _prefixId.prefix "hasResponse"
    /// <summary>
    ///   <para>rdfs:label : Result</para>
    ///   <para>rdfs:comment : An optional field that represents a measured outcome related to the Statement in which it is included.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasResult">ludo-xapi:hasResult</a>
    /// </summary>
    let hasResult = _prefixId.prefix "hasResult"
    /// <summary>
    ///   <para>rdfs:label : Revision</para>
    ///   <para>rdfs:comment : Revision of the learning activity associated with this Statement. Format is free.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasRevision">ludo-xapi:hasRevision</a>
    /// </summary>
    let hasRevision = _prefixId.prefix "hasRevision"
    /// <summary>
    ///   <para>rdfs:label : Scale</para>
    ///   <para>rdfs:comment : Array of interaction components</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasScale">ludo-xapi:hasScale</a>
    /// </summary>
    let hasScale = _prefixId.prefix "hasScale"
    /// <summary>
    ///   <para>rdfs:label : Scaled</para>
    ///   <para>rdfs:comment : Decimal number between –1 and 1, inclusive. Cf. ‘cmi.score.scaled’ in SCORM 2004 4th Edition</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasScaled">ludo-xapi:hasScaled</a>
    /// </summary>
    let hasScaled = _prefixId.prefix "hasScaled"
    /// <summary>
    ///   <para>rdfs:label : Score</para>
    ///   <para>rdfs:comment : The score of the Agent in relation to the success or quality of the experience.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasScore">ludo-xapi:hasScore</a>
    /// </summary>
    let hasScore = _prefixId.prefix "hasScore"
    /// <summary>
    ///   <para>rdfs:label : SHA-2</para>
    ///   <para>rdfs:comment : The SHA-2 (SHA-256, SHA-384, SHA-512) hash of the attachment data. SHA-224 SHOULD not be used: a minimum key size of 256 bits is recommended.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasSha-2">ludo-xapi:hasSha-2</a>
    /// </summary>
    let hasSha_2 = _prefixId.prefix "hasSha-2"
    /// <summary>
    ///   <para>rdfs:label : Mbox SHA1</para>
    ///   <para>rdfs:comment : The SHA1 hash of a mailto IRI (i.e. the value of an mbox property). An LRS MAY include Agents with a matching hash when a request is based on an mbox.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasSha1sum">ludo-xapi:hasSha1sum</a>
    /// </summary>
    let hasSha1sum = _prefixId.prefix "hasSha1sum"
    /// <summary>
    ///   <para>rdfs:label : Source</para>
    ///   <para>rdfs:comment : Array of interaction components</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasSource">ludo-xapi:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:label : Statement</para>
    ///   <para>rdfs:comment : Another Statement, which should be considered as context for this Statement.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasStatement">ludo-xapi:hasStatement</a>
    /// </summary>
    let hasStatement = _prefixId.prefix "hasStatement"
    /// <summary>
    ///   <para>rdfs:label : Statement ID</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasStatementID">ludo-xapi:hasStatementID</a>
    /// </summary>
    let hasStatementID = _prefixId.prefix "hasStatementID"
    /// <summary>
    ///   <para>rdfs:label : Step</para>
    ///   <para>rdfs:comment : Array of interaction components</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasStep">ludo-xapi:hasStep</a>
    /// </summary>
    let hasStep = _prefixId.prefix "hasStep"
    /// <summary>
    ///   <para>rdfs:label : Stored time</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasStoredTime">ludo-xapi:hasStoredTime</a>
    /// </summary>
    let hasStoredTime = _prefixId.prefix "hasStoredTime"
    /// <summary>
    ///   <para>rdfs:label : Target</para>
    ///   <para>rdfs:comment : Array of interaction components</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasTarget">ludo-xapi:hasTarget</a>
    /// </summary>
    let hasTarget = _prefixId.prefix "hasTarget"
    /// <summary>
    ///   <para>rdfs:label : Team</para>
    ///   <para>rdfs:comment : Team that this Statement relates to, if not included as the Actor of the Statement.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasTeam">ludo-xapi:hasTeam</a>
    /// </summary>
    let hasTeam = _prefixId.prefix "hasTeam"
    /// <summary>
    ///   <para>rdfs:label : Time stamp</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasTimeStamp">ludo-xapi:hasTimeStamp</a>
    /// </summary>
    let hasTimeStamp = _prefixId.prefix "hasTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : File URL</para>
    ///   <para>rdfs:comment : An IRL at which the attachment data may be retrieved, or from which it used  to be retrievable.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasUrl">ludo-xapi:hasUrl</a>
    /// </summary>
    let hasUrl = _prefixId.prefix "hasUrl"
    /// <summary>
    ///   <para>rdfs:label : Usage Type</para>
    ///   <para>rdfs:comment : Identifies the usage of this attachment. For example: one expected use case for attachments is to include a "completion certificate". A type IRI corresponding to this usage should be coined, and used with completion certificate attachments.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasUsageType">ludo-xapi:hasUsageType</a>
    /// </summary>
    let hasUsageType = _prefixId.prefix "hasUsageType"
    /// <summary>
    ///   <para>rdfs:label : Verb</para>
    ///   <para>rdfs:comment : Action of the Learner or Team Object. Represents the "Did" in "I Did This".</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasVerb">ludo-xapi:hasVerb</a>
    /// </summary>
    let hasVerb = _prefixId.prefix "hasVerb"
    /// <summary>
    ///   <para>rdfs:label : Verb ID</para>
    ///   <para>rdfs:comment : Corresponds to a Verb definition. Each Verb definition corresponds to the meaning of a Verb, not the word. The IRI should be human-readable and contain the Verb meaning.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasVerbID">ludo-xapi:hasVerbID</a>
    /// </summary>
    let hasVerbID = _prefixId.prefix "hasVerbID"
    /// <summary>
    ///   <para>rdfs:label : Version</para>
    ///   <para>rdfs:comment : Version information in Statements helps systems that process data from an LRS get their bearings. Since the Statement data model is guaranteed consistent through all 1.0.x versions, in order to support data flow among such LRSs the LRS is given some flexibility on Statement versions that are accepted.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#hasVersion">ludo-xapi:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : Completion</para>
    ///   <para>rdfs:comment : Indicates whether or not the Activity was completed.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#isCompleted">ludo-xapi:isCompleted</a>
    /// </summary>
    let isCompleted = _prefixId.prefix "isCompleted"
    /// <summary>
    ///   <para>rdfs:label : Success</para>
    ///   <para>rdfs:comment : Indicates whether or not the attempt on the Activity was successful.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#isSuccess">ludo-xapi:isSuccess</a>
    /// </summary>
    let isSuccess = _prefixId.prefix "isSuccess"
    /// <summary>
    ///   <para>rdfs:label : Experience API</para>
    ///   <para>rdfs:comment : The API defined in this document, the product of "Project Tin Can". A simple, lightweight way for any permitted Actor to store and retrieve extensible learning records, learner and learning experience profiles, regardless of platform.</para>
    ///   <a href="http://ns.inria.fr/ludo/v1/xapi#xAPI">ludo-xapi:xAPI</a>
    /// </summary>
    let xAPI = _prefixId.prefix "xAPI"
