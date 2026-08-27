namespace http.ns.inria.fr.ludo.v1.xapi.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ludo_xapi =
    let _namespace_iri = Namespace_Iri ludo_xapi |> NamespaceIRI
    /// <summary>
    ///   <para>ludo:/v1/xapi#Account</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A user account on an existing system, such as a private system (LMS or intranet) or a public system (social networking site)."</para>
    /// labels<para>"Account"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Account">http://ns.inria.fr/ludo/v1/xapi#Account</seealso>
    let Account = Prefixed_Name(ludo_xapi, "Account") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Activity is a type of Object making up the “this” in I did “this”; it is something with which an Actor interacted. It can be a unit of instruction, experience, or performance that is to be tracked in meaningful combination with a Verb. Interpretation of Activity is broad, meaning that Activities can even be tangible objects such as a chair (real or virtual). In the statement "Anna tried a cake recipe", the recipe constitutes the Activity in terms of the xAPI statement. Other examples of activities include a book, an e-learning course, a hike or a meeting."</para>
    /// labels<para>"Activity"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Activity">http://ns.inria.fr/ludo/v1/xapi#Activity</seealso>
    let Activity = Prefixed_Name(ludo_xapi, "Activity") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#ActivityDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Activity Definition"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#ActivityDefinition">http://ns.inria.fr/ludo/v1/xapi#ActivityDefinition</seealso>
    let ActivityDefinition =
        Prefixed_Name(ludo_xapi, "ActivityDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#ActivityProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The software object that is communicating with the LRS to record information about a learning experience. May be similar to a SCORM package in that it is possible to bundle learning assets with the software object that performs this communication, but an Activity Provider may also be separate from the experience it is reporting about."</para>
    /// labels<para>"Activity Provider"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#ActivityProvider">http://ns.inria.fr/ludo/v1/xapi#ActivityProvider</seealso>
    let ActivityProvider = Prefixed_Name(ludo_xapi, "ActivityProvider") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identity or persona of an individual or group tracked using Statements as doing an action (Verb) within an Activity."</para>
    /// labels<para>"Actor"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Actor">http://ns.inria.fr/ludo/v1/xapi#Actor</seealso>
    let Actor = Prefixed_Name(ludo_xapi, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Agent (an individual) is a persona or system."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Agent">http://ns.inria.fr/ludo/v1/xapi#Agent</seealso>
    let Agent = Prefixed_Name(ludo_xapi, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Attachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A digital artifact providing evidence of a learning experience."</para>
    /// labels<para>"Attachment"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Attachment">http://ns.inria.fr/ludo/v1/xapi#Attachment</seealso>
    let Attachment = Prefixed_Name(ludo_xapi, "Attachment") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Authentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The concept of verifying the identity of a user or system. Authentication allows interactions between the two "trusted" parties."</para>
    /// labels<para>"Authentication"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Authentication">http://ns.inria.fr/ludo/v1/xapi#Authentication</seealso>
    let Authentication = Prefixed_Name(ludo_xapi, "Authentication") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Authorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The affordance of permissions based on a user or system's role; the process of making one user or system "trusted" by another."</para>
    /// labels<para>"Authorization"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Authorization">http://ns.inria.fr/ludo/v1/xapi#Authorization</seealso>
    let Authorization = Prefixed_Name(ludo_xapi, "Authorization") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#BaseEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The maximal path under all Experience API endpoints, including a slash. E.g. an LRS with a statements endpoint of http://example.com/xAPI/statements would have a Base Endpoint of http://example.com/xAPI/""</para>
    /// labels<para>"Base Endpoint"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#BaseEndpoint">http://ns.inria.fr/ludo/v1/xapi#BaseEndpoint</seealso>
    let BaseEndpoint = Prefixed_Name(ludo_xapi, "BaseEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Activity used to categorize the Statement. "Tags” would be a synonym. Category SHOULD be used to indicate a “profile” of xAPI behaviors, as well as other categorizations. For example: Anna attempts a biology exam, and the Statement is tracked using the CMI–5 profile. The Statement’s Activity refers to the exam, and the category is the CMI–5 profile."</para>
    /// labels<para>"Category"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Category">http://ns.inria.fr/ludo/v1/xapi#Category</seealso>
    let Category = Prefixed_Name(ludo_xapi, "Category") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Client</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to any entity that may interact with an LRS. A Client can be an Activity Provider, reporting tool, an LMS, or another LRS."</para>
    /// labels<para>"Client"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Client">http://ns.inria.fr/ludo/v1/xapi#Client</seealso>
    let Client = Prefixed_Name(ludo_xapi, "Client") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#CommunityOfPractice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group, usually connected by a common cause, role or purpose, which operates in a common modality."</para>
    /// labels<para>"Community of Practice"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#CommunityOfPractice">http://ns.inria.fr/ludo/v1/xapi#CommunityOfPractice</seealso>
    let CommunityOfPractice =
        Prefixed_Name(ludo_xapi, "CommunityOfPractice") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An optional field that provides a place to add contextual information to a Statement. All properties are optional."</para>
    /// labels<para>"Context"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Context">http://ns.inria.fr/ludo/v1/xapi#Context</seealso>
    let Context = Prefixed_Name(ludo_xapi, "Context") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#ContextActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Context Activity"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#ContextActivity">http://ns.inria.fr/ludo/v1/xapi#ContextActivity</seealso>
    let ContextActivity = Prefixed_Name(ludo_xapi, "ContextActivity") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Extension"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Extension">http://ns.inria.fr/ludo/v1/xapi#Extension</seealso>
    let Extension = Prefixed_Name(ludo_xapi, "Extension") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Group represents a collection of Agents and can be used in most of the same situations an Agent can be used. There are two types of Groups, anonymous and identified."</para>
    /// labels<para>"Group"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Group">http://ns.inria.fr/ludo/v1/xapi#Group</seealso>
    let Group = Prefixed_Name(ludo_xapi, "Group") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Grouping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"an Activity with an indirect relation to the Activity which is the Object of the Statement. For example: a course that is part of a qualification. The course has several classes. The course relates to a class as the parent, the qualification relates to the class as the grouping."</para>
    /// labels<para>"Grouping"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Grouping">http://ns.inria.fr/ludo/v1/xapi#Grouping</seealso>
    let Grouping = Prefixed_Name(ludo_xapi, "Grouping") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#IRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unique identifier which may be an IRL. In the xAPI, all IRIs should be a full absolute IRIs including a scheme. Relative IRIs should not be used. IRLs should be defined within a domain controlled by the person creating the IRL."</para>
    /// labels<para>"International Resource Identifier"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#IRI">http://ns.inria.fr/ludo/v1/xapi#IRI</seealso>
    let IRI = Prefixed_Name(ludo_xapi, "IRI") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#IRL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In the context of this document, an IRL is an IRI that when translated into a URI (per the IRI to URI rules), is a URL. Some communities of practice simply use URL even if they use IRIs, which isn't as technically correct within xAPI."</para>
    /// labels<para>"International Resource Locator"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#IRL">http://ns.inria.fr/ludo/v1/xapi#IRL</seealso>
    let IRL = Prefixed_Name(ludo_xapi, "IRL") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Immutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Adjective used to describe things which cannot be changed. With some exceptions, Statements in the xAPI are immutable. This ensures that when Statements are shared between LRSs, multiple copies of the Statement remain the same."</para>
    /// labels<para>"Immutable"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Immutable">http://ns.inria.fr/ludo/v1/xapi#Immutable</seealso>
    let Immutable = Prefixed_Name(ludo_xapi, "Immutable") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#InteractionActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Traditional e-learning has included structures for interactions or assessments. As a way to allow these practices and structures to extend Experience API's utility, this specification includes built-in definitions for interactions, which borrows from the SCORM 2004 4th Edition Data Model. These definitions are intended to provide a simple and familiar utility for recording interaction data. These definitions are simple to use, and consequently limited. It is expected that communities of practice requiring richer interactions definitions will do so through the use of extensions to an Activity's type and definition."</para>
    /// labels<para>"Interaction Activity"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#InteractionActivity">http://ns.inria.fr/ludo/v1/xapi#InteractionActivity</seealso>
    let InteractionActivity =
        Prefixed_Name(ludo_xapi, "InteractionActivity") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#InteractionComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Interaction Component"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#InteractionComponent">http://ns.inria.fr/ludo/v1/xapi#InteractionComponent</seealso>
    let InteractionComponent =
        Prefixed_Name(ludo_xapi, "InteractionComponent") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#InverseFunctionalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Inverse Functional Identifier"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#InverseFunctionalIdentifier">http://ns.inria.fr/ludo/v1/xapi#InverseFunctionalIdentifier</seealso>
    let InverseFunctionalIdentifier =
        Prefixed_Name(ludo_xapi, "InverseFunctionalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#LMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software package used to administer one or more courses to one or more learners. An LMS is typically a web-based system that allows learners to authenticate themselves, register for courses, complete courses and take assessments"</para>
    /// labels<para>"Learning Management System"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#LMS">http://ns.inria.fr/ludo/v1/xapi#LMS</seealso>
    let LMS = Prefixed_Name(ludo_xapi, "LMS") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#LRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A system that stores learning information. Prior to the xAPI most LRSs were Learning Management Systems (LMSs); however this document uses the term LRS to be clear that a full LMS is not necessary to implement the xAPI. The xAPI is dependent on an LRS to function."</para>
    /// labels<para>"Learning Record Store"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#LRS">http://ns.inria.fr/ludo/v1/xapi#LRS</seealso>
    let LRS = Prefixed_Name(ludo_xapi, "LRS") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#LanguageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A language map is a dictionary where the key is a  RFC 5646 Language Tag, and the value is an string in the language specified in the tag. This map should be populated as fully as possible based on the knowledge of the string in question in different languages."</para>
    /// labels<para>"LanguageMap"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#LanguageMap">http://ns.inria.fr/ludo/v1/xapi#LanguageMap</seealso>
    let LanguageMap = Prefixed_Name(ludo_xapi, "LanguageMap") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#MSM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Three levels of obligation with regards to conformance to the xAPI specification. A system that fails to implement a MUST (or a MUST NOT) requirement is non-conformant. Failing to meet a SHOULD requirement is not a violation of conformity, but goes against best practices. MAY indicates an option, to be decided by the developer with no consequences for conformity."</para>
    /// labels<para>"MUST / SHOULD / MAY"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#MSM">http://ns.inria.fr/ludo/v1/xapi#MSM</seealso>
    let MSM = Prefixed_Name(ludo_xapi, "MSM") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Object of a Statement can be an Activity, Agent/Group, Sub-Statement, or Statement Reference. It is the "this" part of the Statement, i.e. "I did this"."</para>
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Object">http://ns.inria.fr/ludo/v1/xapi#Object</seealso>
    let Object = Prefixed_Name(ludo_xapi, "Object") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A context Activity that doesn’t fit one of the other fields. For example: Anna studies a textbook for a biology exam. The Statement’s Activity refers to the textbook, and the exam is a context Activity of type “other”."</para>
    /// labels<para>"Other"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Other">http://ns.inria.fr/ludo/v1/xapi#Other</seealso>
    let Other = Prefixed_Name(ludo_xapi, "Other") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Activity with a direct relation to the Activity which is the Object of the Statement. In almost all cases there is only one sensible parent or none, not multiple. For example: a Statement about a quiz question would have the quiz as its parent Activity."</para>
    /// labels<para>"Parent"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Parent">http://ns.inria.fr/ludo/v1/xapi#Parent</seealso>
    let Parent = Prefixed_Name(ludo_xapi, "Parent") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A construct where information about the learner or activity is kept, typically in name/document pairs that have meaning to an instructional system component."</para>
    /// labels<para>"Profile"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Profile">http://ns.inria.fr/ludo/v1/xapi#Profile</seealso>
    let Profile = Prefixed_Name(ludo_xapi, "Profile") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#REST</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An architecture for designing networked web Services. It relies on HTTP methods and uses current web best practices."</para>
    /// labels<para>"REST"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#REST">http://ns.inria.fr/ludo/v1/xapi#REST</seealso>
    let REST = Prefixed_Name(ludo_xapi, "REST") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Registration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of a learner experiencing a particular Activity."</para>
    /// labels<para>"Registration"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Registration">http://ns.inria.fr/ludo/v1/xapi#Registration</seealso>
    let Registration = Prefixed_Name(ludo_xapi, "Registration") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An optional field that represents a measured outcome related to the Statement in which it is included."</para>
    /// labels<para>"Result"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Result">http://ns.inria.fr/ludo/v1/xapi#Result</seealso>
    let Result = Prefixed_Name(ludo_xapi, "Result") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An optional field that represents the outcome of a graded Activity achieved by an Agent."</para>
    /// labels<para>"Score"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Score">http://ns.inria.fr/ludo/v1/xapi#Score</seealso>
    let Score = Prefixed_Name(ludo_xapi, "Score") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software component responsible for one or more aspects of the distributed learning process. An LMS typically combines many services to design a complete learning experience."</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Service">http://ns.inria.fr/ludo/v1/xapi#Service</seealso>
    let Service = Prefixed_Name(ludo_xapi, "Service") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Statement">http://ns.inria.fr/ludo/v1/xapi#Statement</seealso>
    let Statement = Prefixed_Name(ludo_xapi, "Statement") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#TinCanAPI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The previous name of the API defined in this document, often used in informal references to the Experience API."</para>
    /// labels<para>"TIN CAN API"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#TinCanAPI">http://ns.inria.fr/ludo/v1/xapi#TinCanAPI</seealso>
    let TinCanAPI = Prefixed_Name(ludo_xapi, "TinCanAPI") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#Verb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines the action being done by the Actor within the Activity within a Statement."</para>
    /// labels<para>"Verb"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#Verb">http://ns.inria.fr/ludo/v1/xapi#Verb</seealso>
    let Verb = Prefixed_Name(ludo_xapi, "Verb") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Account property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasAccount">http://ns.inria.fr/ludo/v1/xapi#hasAccount</seealso>
    let hasAccount = Prefixed_Name(ludo_xapi, "hasAccount") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasAccountName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The unique id or name used to log in to this account. This is based on FOAF’s accountName."</para>
    /// labels<para>"Account Name"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasAccountName">http://ns.inria.fr/ludo/v1/xapi#hasAccountName</seealso>
    let hasAccountName = Prefixed_Name(ludo_xapi, "hasAccountName") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasActivityDefinitionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A description of the Activity"</para>
    /// labels<para>"Activity Definition Description"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionDescription">http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionDescription</seealso>
    let hasActivityDefinitionDescription =
        Prefixed_Name(ludo_xapi, "hasActivityDefinitionDescription") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasActivityDefinitionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The human readable visual name of the Activity"</para>
    /// labels<para>"Activity Definition Name"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionName">http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionName</seealso>
    let hasActivityDefinitionName =
        Prefixed_Name(ludo_xapi, "hasActivityDefinitionName") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasActivityDefinitionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The type of Activity."</para>
    /// labels<para>"Activity Definition Type"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionType">http://ns.inria.fr/ludo/v1/xapi#hasActivityDefinitionType</seealso>
    let hasActivityDefinitionType =
        Prefixed_Name(ludo_xapi, "hasActivityDefinitionType") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An mandatory Agent or Group Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Actor"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasActor">http://ns.inria.fr/ludo/v1/xapi#hasActor</seealso>
    let hasActor = Prefixed_Name(ludo_xapi, "hasActor") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasActorObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Either an Agent or Group of agents"</para>
    /// labels<para>"Actor Object Type"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasActorObjectType">http://ns.inria.fr/ludo/v1/xapi#hasActorObjectType</seealso>
    let hasActorObjectType =
        Prefixed_Name(ludo_xapi, "hasActorObjectType") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasAgentName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Full name of the Agent."</para>
    /// labels<para>"Agent name"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasAgentName">http://ns.inria.fr/ludo/v1/xapi#hasAgentName</seealso>
    let hasAgentName = Prefixed_Name(ludo_xapi, "hasAgentName") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasAttachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Attachment"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasAttachment">http://ns.inria.fr/ludo/v1/xapi#hasAttachment</seealso>
    let hasAttachment = Prefixed_Name(ludo_xapi, "hasAttachment") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The authority property provides information about whom or what has asserted that this Statement is true."</para>
    /// labels<para>"Authority"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasAuthority">http://ns.inria.fr/ludo/v1/xapi#hasAuthority</seealso>
    let hasAuthority = Prefixed_Name(ludo_xapi, "hasAuthority") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasChoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Array of interaction components"</para>
    /// labels<para>"Choice"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasChoice">http://ns.inria.fr/ludo/v1/xapi#hasChoice</seealso>
    let hasChoice = Prefixed_Name(ludo_xapi, "hasChoice") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The content type of the attachment. https://www.ietf.org/rfc/rfc2046.txt?number=2046"</para>
    /// labels<para>"Content type"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasContentType">http://ns.inria.fr/ludo/v1/xapi#hasContentType</seealso>
    let hasContentType = Prefixed_Name(ludo_xapi, "hasContentType") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An optional field that provides a place to add contextual information to a Statement. All properties are optional."</para>
    /// labels<para>"Context"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasContext">http://ns.inria.fr/ludo/v1/xapi#hasContext</seealso>
    let hasContext = Prefixed_Name(ludo_xapi, "hasContext") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasContextActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A map of types of learning activity context that this Statement is related to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Context Activity"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasContextActivity">http://ns.inria.fr/ludo/v1/xapi#hasContextActivity</seealso>
    let hasContextActivity =
        Prefixed_Name(ludo_xapi, "hasContextActivity") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Description of the attachment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasDescription">http://ns.inria.fr/ludo/v1/xapi#hasDescription</seealso>
    let hasDescription = Prefixed_Name(ludo_xapi, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasDisplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasDisplay">http://ns.inria.fr/ludo/v1/xapi#hasDisplay</seealso>
    let hasDisplay = Prefixed_Name(ludo_xapi, "hasDisplay") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Period of time over which the Statement occurred. Formatted according to ISO 8601 with a precision of 0.01 seconds"</para>
    /// labels<para>"Duration"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasDuration">http://ns.inria.fr/ludo/v1/xapi#hasDuration</seealso>
    let hasDuration = Prefixed_Name(ludo_xapi, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A map of other properties as needed."</para>
    /// labels<para>"Extension"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasExtension">http://ns.inria.fr/ludo/v1/xapi#hasExtension</seealso>
    let hasExtension = Prefixed_Name(ludo_xapi, "hasExtension") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasGroupName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of the group."</para>
    /// labels<para>"Group Name"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasGroupName">http://ns.inria.fr/ludo/v1/xapi#hasGroupName</seealso>
    let hasGroupName = Prefixed_Name(ludo_xapi, "hasGroupName") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasHomePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The canonical home page for the system the account is on. This is based on FOAF’s accountServiceHomePage."</para>
    /// labels<para>"Home page"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasHomePage">http://ns.inria.fr/ludo/v1/xapi#hasHomePage</seealso>
    let hasHomePage = Prefixed_Name(ludo_xapi, "hasHomePage") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A UUID (see RFC 4122 for requirements, and the UUID must be in standard string form)."</para>
    /// labels<para>"ID"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasID">http://ns.inria.fr/ludo/v1/xapi#hasID</seealso>
    let hasID = Prefixed_Name(ludo_xapi, "hasID") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasInstructor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Instructor that the Statement relates to, if not included as the Actor of the Statement."</para>
    /// labels<para>"Instructor"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasInstructor">http://ns.inria.fr/ludo/v1/xapi#hasInstructor</seealso>
    let hasInstructor = Prefixed_Name(ludo_xapi, "hasInstructor") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasInteractionComponentDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A description of the interaction component (for example, the text for a given choice in a multiple-choice interaction)"</para>
    /// labels<para>"Interaction Component Description"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionComponentDescription">http://ns.inria.fr/ludo/v1/xapi#hasInteractionComponentDescription</seealso>
    let hasInteractionComponentDescription =
        Prefixed_Name(ludo_xapi, "hasInteractionComponentDescription") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasInteractionComponentID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A value such as used in practice for "cmi.interactions.n.id" as defined in the SCORM 2004 4th Edition Run-Time Environment"</para>
    /// labels<para>"Interaction Component ID"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionComponentID">http://ns.inria.fr/ludo/v1/xapi#hasInteractionComponentID</seealso>
    let hasInteractionComponentID =
        Prefixed_Name(ludo_xapi, "hasInteractionComponentID") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasInteractionCorrectResponsesPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Corresponds to "cmi.interactions.n.correct_responses.n.pattern" as defined in the SCORM 2004 4th Edition Run-Time Environment, where the final n is the index of the array."</para>
    /// labels<para>"Correct Responses Pattern"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionCorrectResponsesPattern">http://ns.inria.fr/ludo/v1/xapi#hasInteractionCorrectResponsesPattern</seealso>
    let hasInteractionCorrectResponsesPattern =
        Prefixed_Name(ludo_xapi, "hasInteractionCorrectResponsesPattern") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasInteractionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"As in "cmi.interactions.n.type" as defined in the SCORM 2004 4th Edition Run-Time Environment."</para>
    /// labels<para>"Interaction Type"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasInteractionType">http://ns.inria.fr/ludo/v1/xapi#hasInteractionType</seealso>
    let hasInteractionType =
        Prefixed_Name(ludo_xapi, "hasInteractionType") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasInverseFunctionalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Inverse Functional Identifier unique to the Agent."</para>
    /// labels<para>"Inverse Functional Identifier"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasInverseFunctionalIdentifier">http://ns.inria.fr/ludo/v1/xapi#hasInverseFunctionalIdentifier</seealso>
    let hasInverseFunctionalIdentifier =
        Prefixed_Name(ludo_xapi, "hasInverseFunctionalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Code representing the language in which the experience being recorded in this Statement (mainly) occurred in, if applicable and known. As defined in RFC 5646"</para>
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasLanguage">http://ns.inria.fr/ludo/v1/xapi#hasLanguage</seealso>
    let hasLanguage = Prefixed_Name(ludo_xapi, "hasLanguage") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasLanguageTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Language tags are used to help identify languages, whether spoken, written, signed, or otherwise signaled, for the purpose of communication. This includes constructed and artificial languages but excludes languages not intended primarily for human communication, such as programming languages."</para>
    /// labels<para>"Language Tag"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasLanguageTag">http://ns.inria.fr/ludo/v1/xapi#hasLanguageTag</seealso>
    let hasLanguageTag = Prefixed_Name(ludo_xapi, "hasLanguageTag") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasLanguageVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Language Verb"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasLanguageVerb">http://ns.inria.fr/ludo/v1/xapi#hasLanguageVerb</seealso>
    let hasLanguageVerb = Prefixed_Name(ludo_xapi, "hasLanguageVerb") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The length of the attachment data in octets."</para>
    /// labels<para>"Length"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasLength">http://ns.inria.fr/ludo/v1/xapi#hasLength</seealso>
    let hasLength = Prefixed_Name(ludo_xapi, "hasLength") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Decimal number greater than min (if present). Cf. ‘cmi.score.max’"</para>
    /// labels<para>"Max"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasMax">http://ns.inria.fr/ludo/v1/xapi#hasMax</seealso>
    let hasMax = Prefixed_Name(ludo_xapi, "hasMax") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasMbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The required format is "mailto:email address". Only email addresses that have only ever been and will ever be assigned to this Agent, but no others, should be used for this property and mbox_sha1sum."</para>
    /// labels<para>"mbox"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasMbox">http://ns.inria.fr/ludo/v1/xapi#hasMbox</seealso>
    let hasMbox = Prefixed_Name(ludo_xapi, "hasMbox") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Member"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasMember">http://ns.inria.fr/ludo/v1/xapi#hasMember</seealso>
    let hasMember = Prefixed_Name(ludo_xapi, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Decimal number less than max (if present)"</para>
    /// labels<para>"Min"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasMin">http://ns.inria.fr/ludo/v1/xapi#hasMin</seealso>
    let hasMin = Prefixed_Name(ludo_xapi, "hasMin") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasMoreInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Resolves to a document with human-readable information about the Actiivty, which could include a way to launch the activity."</para>
    /// labels<para>"Activity Definition More Info"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasMoreInfo">http://ns.inria.fr/ludo/v1/xapi#hasMoreInfo</seealso>
    let hasMoreInfo = Prefixed_Name(ludo_xapi, "hasMoreInfo") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Name"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasName">http://ns.inria.fr/ludo/v1/xapi#hasName</seealso>
    let hasName = Prefixed_Name(ludo_xapi, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Activity, Agent, or another Statement that is the Object of the Statement. Represents the "This" in "I Did This". Note that Objects which are provided as a value for this field should include an "objectType" field. If not specified, the Object is assumed to be an Activity."</para>
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasObject">http://ns.inria.fr/ludo/v1/xapi#hasObject</seealso>
    let hasObject = Prefixed_Name(ludo_xapi, "hasObject") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasObjectDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Object Definition"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasObjectDefinition">http://ns.inria.fr/ludo/v1/xapi#hasObjectDefinition</seealso>
    let hasObjectDefinition =
        Prefixed_Name(ludo_xapi, "hasObjectDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasObjectExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Object Extension"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasObjectExtension">http://ns.inria.fr/ludo/v1/xapi#hasObjectExtension</seealso>
    let hasObjectExtension =
        Prefixed_Name(ludo_xapi, "hasObjectExtension") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasObjectID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An identifier for a single unique Activity"</para>
    /// labels<para>"Object ID"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasObjectID">http://ns.inria.fr/ludo/v1/xapi#hasObjectID</seealso>
    let hasObjectID = Prefixed_Name(ludo_xapi, "hasObjectID") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasObjectInteration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Object Interaction Property"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasObjectInteration">http://ns.inria.fr/ludo/v1/xapi#hasObjectInteration</seealso>
    let hasObjectInteration =
        Prefixed_Name(ludo_xapi, "hasObjectInteration") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/xapi#hasObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Can be an Activity, Agent, Group, Statement or SubStatemen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Object Type"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasObjectType">http://ns.inria.fr/ludo/v1/xapi#hasObjectType</seealso>
    let hasObjectType = Prefixed_Name(ludo_xapi, "hasObjectType") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasOpenID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An openID that uniquely identifies the Agent."</para>
    /// labels<para>"Open ID"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasOpenID">http://ns.inria.fr/ludo/v1/xapi#hasOpenID</seealso>
    let hasOpenID = Prefixed_Name(ludo_xapi, "hasOpenID") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Platform used in the experience of this learning activity."</para>
    /// labels<para>"Platform"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasPlatform">http://ns.inria.fr/ludo/v1/xapi#hasPlatform</seealso>
    let hasPlatform = Prefixed_Name(ludo_xapi, "hasPlatform") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasRaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Decimal number between min and max (if present, otherwise unrestricted), inclusive."</para>
    /// labels<para>"Raw"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasRaw">http://ns.inria.fr/ludo/v1/xapi#hasRaw</seealso>
    let hasRaw = Prefixed_Name(ludo_xapi, "hasRaw") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The registration that the Statement is associated with. UUID"</para>
    /// labels<para>"Registration"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasRegistration">http://ns.inria.fr/ludo/v1/xapi#hasRegistration</seealso>
    let hasRegistration = Prefixed_Name(ludo_xapi, "hasRegistration") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A response appropriately formatted for the given Activity."</para>
    /// labels<para>"Response"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasResponse">http://ns.inria.fr/ludo/v1/xapi#hasResponse</seealso>
    let hasResponse = Prefixed_Name(ludo_xapi, "hasResponse") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An optional field that represents a measured outcome related to the Statement in which it is included."</para>
    /// labels<para>"Result"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasResult">http://ns.inria.fr/ludo/v1/xapi#hasResult</seealso>
    let hasResult = Prefixed_Name(ludo_xapi, "hasResult") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Revision of the learning activity associated with this Statement. Format is free."</para>
    /// labels<para>"Revision"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasRevision">http://ns.inria.fr/ludo/v1/xapi#hasRevision</seealso>
    let hasRevision = Prefixed_Name(ludo_xapi, "hasRevision") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Array of interaction components"</para>
    /// labels<para>"Scale"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasScale">http://ns.inria.fr/ludo/v1/xapi#hasScale</seealso>
    let hasScale = Prefixed_Name(ludo_xapi, "hasScale") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasScaled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Decimal number between –1 and 1, inclusive. Cf. ‘cmi.score.scaled’ in SCORM 2004 4th Edition"</para>
    /// labels<para>"Scaled"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasScaled">http://ns.inria.fr/ludo/v1/xapi#hasScaled</seealso>
    let hasScaled = Prefixed_Name(ludo_xapi, "hasScaled") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The score of the Agent in relation to the success or quality of the experience."</para>
    /// labels<para>"Score"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasScore">http://ns.inria.fr/ludo/v1/xapi#hasScore</seealso>
    let hasScore = Prefixed_Name(ludo_xapi, "hasScore") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasSha-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The SHA-2 (SHA-256, SHA-384, SHA-512) hash of the attachment data. SHA-224 SHOULD not be used: a minimum key size of 256 bits is recommended."</para>
    /// labels<para>"SHA-2"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasSha-2">http://ns.inria.fr/ludo/v1/xapi#hasSha-2</seealso>
    let hasSha_2 = Prefixed_Name(ludo_xapi, "hasSha-2") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasSha1sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The SHA1 hash of a mailto IRI (i.e. the value of an mbox property). An LRS MAY include Agents with a matching hash when a request is based on an mbox."</para>
    /// labels<para>"Mbox SHA1"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasSha1sum">http://ns.inria.fr/ludo/v1/xapi#hasSha1sum</seealso>
    let hasSha1sum = Prefixed_Name(ludo_xapi, "hasSha1sum") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Array of interaction components"</para>
    /// labels<para>"Source"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasSource">http://ns.inria.fr/ludo/v1/xapi#hasSource</seealso>
    let hasSource = Prefixed_Name(ludo_xapi, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Another Statement, which should be considered as context for this Statement."</para>
    /// labels<para>"Statement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasStatement">http://ns.inria.fr/ludo/v1/xapi#hasStatement</seealso>
    let hasStatement = Prefixed_Name(ludo_xapi, "hasStatement") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasStatementID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Statement ID"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasStatementID">http://ns.inria.fr/ludo/v1/xapi#hasStatementID</seealso>
    let hasStatementID = Prefixed_Name(ludo_xapi, "hasStatementID") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Array of interaction components"</para>
    /// labels<para>"Step"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasStep">http://ns.inria.fr/ludo/v1/xapi#hasStep</seealso>
    let hasStep = Prefixed_Name(ludo_xapi, "hasStep") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasStoredTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Stored time"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasStoredTime">http://ns.inria.fr/ludo/v1/xapi#hasStoredTime</seealso>
    let hasStoredTime = Prefixed_Name(ludo_xapi, "hasStoredTime") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Array of interaction components"</para>
    /// labels<para>"Target"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasTarget">http://ns.inria.fr/ludo/v1/xapi#hasTarget</seealso>
    let hasTarget = Prefixed_Name(ludo_xapi, "hasTarget") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Team that this Statement relates to, if not included as the Actor of the Statement."</para>
    /// labels<para>"Team"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasTeam">http://ns.inria.fr/ludo/v1/xapi#hasTeam</seealso>
    let hasTeam = Prefixed_Name(ludo_xapi, "hasTeam") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Time stamp"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasTimeStamp">http://ns.inria.fr/ludo/v1/xapi#hasTimeStamp</seealso>
    let hasTimeStamp = Prefixed_Name(ludo_xapi, "hasTimeStamp") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An IRL at which the attachment data may be retrieved, or from which it used  to be retrievable."</para>
    /// labels<para>"File URL"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasUrl">http://ns.inria.fr/ludo/v1/xapi#hasUrl</seealso>
    let hasUrl = Prefixed_Name(ludo_xapi, "hasUrl") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasUsageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the usage of this attachment. For example: one expected use case for attachments is to include a "completion certificate". A type IRI corresponding to this usage should be coined, and used with completion certificate attachments."</para>
    /// labels<para>"Usage Type"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasUsageType">http://ns.inria.fr/ludo/v1/xapi#hasUsageType</seealso>
    let hasUsageType = Prefixed_Name(ludo_xapi, "hasUsageType") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Action of the Learner or Team Object. Represents the "Did" in "I Did This"."</para>
    /// labels<para>"Verb"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasVerb">http://ns.inria.fr/ludo/v1/xapi#hasVerb</seealso>
    let hasVerb = Prefixed_Name(ludo_xapi, "hasVerb") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasVerbID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Corresponds to a Verb definition. Each Verb definition corresponds to the meaning of a Verb, not the word. The IRI should be human-readable and contain the Verb meaning."</para>
    /// labels<para>"Verb ID"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasVerbID">http://ns.inria.fr/ludo/v1/xapi#hasVerbID</seealso>
    let hasVerbID = Prefixed_Name(ludo_xapi, "hasVerbID") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Version information in Statements helps systems that process data from an LRS get their bearings. Since the Statement data model is guaranteed consistent through all 1.0.x versions, in order to support data flow among such LRSs the LRS is given some flexibility on Statement versions that are accepted."</para>
    /// labels<para>"Version"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#hasVersion">http://ns.inria.fr/ludo/v1/xapi#hasVersion</seealso>
    let hasVersion = Prefixed_Name(ludo_xapi, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#isCompleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether or not the Activity was completed."</para>
    /// labels<para>"Completion"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#isCompleted">http://ns.inria.fr/ludo/v1/xapi#isCompleted</seealso>
    let isCompleted = Prefixed_Name(ludo_xapi, "isCompleted") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#isSuccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether or not the attempt on the Activity was successful."</para>
    /// labels<para>"Success"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#isSuccess">http://ns.inria.fr/ludo/v1/xapi#isSuccess</seealso>
    let isSuccess = Prefixed_Name(ludo_xapi, "isSuccess") |> PrefixedName
    /// <summary>
    ///   <para>ludo:/v1/xapi#xAPI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The API defined in this document, the product of "Project Tin Can". A simple, lightweight way for any permitted Actor to store and retrieve extensible learning records, learner and learning experience profiles, regardless of platform."</para>
    /// labels<para>"Experience API"</para></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi#xAPI">http://ns.inria.fr/ludo/v1/xapi#xAPI</seealso>
    let xAPI = Prefixed_Name(ludo_xapi, "xAPI") |> PrefixedName
