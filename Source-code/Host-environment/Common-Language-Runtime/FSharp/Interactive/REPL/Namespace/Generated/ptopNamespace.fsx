#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ptop =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontotext.com/proton/protontop#" "ptop"

    /// <summary>
    ///   <para>rdfs:label : Abstract</para>
    ///   <para>rdfs:comment : Something, which neither happens nor exists, e.g. a number or a chemical compound formula. Those are usually some symbols, invented to refer to general notions.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Abstract">ptop:Abstract</a>
    /// </summary>
    let Abstract = _prefixId.prefix "Abstract"
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : An Agent is something, which can show (carry out) an independent action, whether consciously or not. Most animals are considered agents, in most contexts; so are most organizations. According to DOLCE 2.0 "objects to which we ascribe intentions, beliefs and desires". In PROTON, Agent also denotes any automatic device and service, including web services and servers.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Agent">ptop:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : Contact Information</para>
    ///   <para>rdfs:comment : Any instance of a particular notation, used to make the contact with an individual, an organization, or any other object possible.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#ContactInformation">ptop:ContactInformation</a>
    /// </summary>
    let ContactInformation = _prefixId.prefix "ContactInformation"
    /// <summary>
    ///   <para>rdfs:label : Document</para>
    ///   <para>rdfs:comment : The information content of any sort of document. The tangible aspects are ignored. It is usually a document in free text with no formal structure or semantics.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Document">ptop:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : Entity</para>
    ///   <para>rdfs:comment : Any sort of an entity of interest, usually something existing, happening, or purely abstract. Entities may have several - more than one - names or aliases.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Entity">ptop:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : A dynamic event, such as "running" or "a concert".</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Event">ptop:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : General Term</para>
    ///   <para>rdfs:comment : General concept with well defined (idiomatic) meaning which can have a set of distinct lexical items (surface realizations) associated with it. Examples are: F2F, I18N, P2P, B2B, VIP, ASAP, Semantic Web</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#GeneralTerm">ptop:GeneralTerm</a>
    /// </summary>
    let GeneralTerm = _prefixId.prefix "GeneralTerm"
    /// <summary>
    ///   <para>rdfs:label : Group</para>
    ///   <para>rdfs:comment : A group of agents that is not organized in any way. It could be the group of people in a bus or the shareholders of a company.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Group">ptop:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : Happening</para>
    ///   <para>rdfs:comment : Something that happens. It can be either dynamic - like in "drawing a circle", or static - like in "being a president". In all cases, a happening (an event, a situation, or a time period) has a certain (usually quite concrete) temporal positioning - in the simplest case it is the one, denoted by start and end point in time.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Happening">ptop:Happening</a>
    /// </summary>
    let Happening = _prefixId.prefix "Happening"
    /// <summary>
    ///   <para>rdfs:label : Information Resource</para>
    ///   <para>rdfs:comment : InformationResource denotes an information resource with identity, as defined in Dublin Core (DC2003ISO). InformationResource is considered any communication or message that is delivered or produced, taking into account the specific intention of its originator, and also the supposition (and anticipation) for a particular audience or counter-agent in the process of communication (i.e. passive or active feed-back).</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#InformationResource">ptop:InformationResource</a>
    /// </summary>
    let InformationResource = _prefixId.prefix "InformationResource"
    /// <summary>
    ///   <para>rdfs:label : Job Position</para>
    ///   <para>rdfs:comment : The situation of a person, holding a job (employment) position within an organization. The sub-classes of this class define a number of different types of positions.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#JobPosition">ptop:JobPosition</a>
    /// </summary>
    let JobPosition = _prefixId.prefix "JobPosition"
    /// <summary>
    ///   <para>rdfs:label : Language</para>
    ///   <para>rdfs:comment : A spoken or written natural language</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Language">ptop:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : Usually a geographic location on the earth, however any sort of 3D regions also fit here. The classification is based on the ADL Feature Type Thesaurus version 070203. Additionally, classes from Geonames classification are included. For each specific type, the corresponding NIMA GNS designators (DSG) are given.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Location">ptop:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : Number</para>
    ///   <para>rdfs:comment : Any given number, within the meaning that a number is one of the following: a concept of quantity derived from zero and units; or a numeral (or a string of numerals) used for identification ("she refused to give them her Social Security number"); or a phone number, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Number">ptop:Number</a>
    /// </summary>
    let Number = _prefixId.prefix "Number"
    /// <summary>
    ///   <para>rdfs:label : Object</para>
    ///   <para>rdfs:comment : Objects are entities that could be claimed to exist - in some sense of existence. An object can play a certain role in some happenings. Objects could be substantially real - as the Buckingham Palace or a hardcopy book - or substantially imperceptible - for instance, an electronic document that exists only virtually, one cannot touch it.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Object">ptop:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:label : Organization</para>
    ///   <para>rdfs:comment : Organization is a group, which is established in such a way that certain known relationships and obligations exist between the members, and/or between the organization and its members, and/or between the organization and the public (individuals or groups). It includes both informal and legally constituted organizations. Organizations can act as agents - to undertake projects, to enter into agreements, to own properties, etc. Most organizations have names. Almost all of them have at least two members.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Organization">ptop:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : A Person is an agent, which is an individual who is a human being (i.e. any living or not alive member of the family Hominidae). Wordnet 2.0.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Person">ptop:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Product Model</para>
    ///   <para>rdfs:comment : The general concept of a product model, for example, Ford T. The instances of this class are not specific instances of the product - the latter are just instances. Although product models are rather abstract entities (generally, intangible), this class is defined as a sub-class of Object, because it has a strong temporal extent (it comes to exsitence at some point of time). There could be several information resources associated with a product model (e.g. specifications, brouchures, etc.), but it is not an information resource on its own.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#ProductModel">ptop:ProductModel</a>
    /// </summary>
    let ProductModel = _prefixId.prefix "ProductModel"
    /// <summary>
    ///   <para>rdfs:label : Role</para>
    ///   <para>rdfs:comment : The role of an entity (usually an agent) within/during/affecting (intentionally or not) a particular happening. For instance a project coordinator, or a trial defendant, or even a material object that serves as an evidence in a trial (e.g. a weapon). Usually, we say 'this object is in this role in this happening'.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Role">ptop:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : Any sort of service, ranging from a scheduled flight or train services to a weather forecast information/web serivce. Many services could be considered agents (usually software services).</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Service">ptop:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Situation</para>
    ///   <para>rdfs:comment : A static event or situation, like "sitting on a chair" or "holding position". Typically, those are temporarily homogenous, i.e. their nature is not expected/required to change with their duration. As a happening, they used to happen/take place/be true for some periods of time and may or may not have a well-defined space extension.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Situation">ptop:Situation</a>
    /// </summary>
    let Situation = _prefixId.prefix "Situation"
    /// <summary>
    ///   <para>rdfs:label : Social Position</para>
    ///   <para>rdfs:comment : The situation of a person, having a social position like celebrity, nobelty, job position, cleric, out of laws. The sub-classes of this class define different social statuses.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#SocialPosition">ptop:SocialPosition</a>
    /// </summary>
    let SocialPosition = _prefixId.prefix "SocialPosition"
    /// <summary>
    ///   <para>rdfs:label : Statement</para>
    ///   <para>rdfs:comment : A message that is stated or declared; a communication (oral or written), setting forth particulars or facts, etc; "according to his statement he was in London on that day". WordNet 1.7.1</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Statement">ptop:Statement</a>
    /// </summary>
    let Statement = _prefixId.prefix "Statement"
    /// <summary>
    ///   <para>rdfs:label : Time Interval</para>
    ///   <para>rdfs:comment : This is a general time expression, which refers to a particular period of time, an interval. Repeating periods (like Spring or Christmas) are not time intervals, while specific instances of them (like the Spring of 1944) are. A TimeInterval could collapse, in very special cases, to a time point, however in this case, in contrast to the Abstract time point (referring to some time during the day), it should be bound to a specific date, i.e. to represent a timestamp.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#TimeInterval">ptop:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    /// <summary>
    ///   <para>rdfs:label : Topic</para>
    ///   <para>rdfs:comment : Any sort of a topic or theme, explicitly defined for classification purposes. As long as any other class or entity can play the role of a topic, the instances of this class are only those concepts that are defined to serve as topics. The topic class is the natural top-class for linkage of logically informal taxonomies.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#Topic">ptop:Topic</a>
    /// </summary>
    let Topic = _prefixId.prefix "Topic"
    /// <summary>
    ///   <para>rdfs:label : Controls</para>
    ///   <para>rdfs:comment : Indicates that an Agent has full control over an object. This is typically the case of wholly-owned subsidiaries and physicall possession of goods.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#controls">ptop:controls</a>
    /// </summary>
    let controls = _prefixId.prefix "controls"
    /// <summary>
    ///   <para>rdfs:label : Derived from Source</para>
    ///   <para>rdfs:comment : A reference to a resource from which the present resource is derived. The present resource may be derived from the Source resource in whole or in part. Recommended best practice is to identify the referenced resource by means of a string or number conforming to a formal identification system. DC2003ISO</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#derivedFromSource">ptop:derivedFromSource</a>
    /// </summary>
    let derivedFromSource = _prefixId.prefix "derivedFromSource"
    /// <summary>
    ///   <para>rdfs:label : Description</para>
    ///   <para>rdfs:comment : A textual description of an entity. Usually a free text in some natural language. As defined in DC2003ISO for InformationResources. In a sense, it is a specializatoin of rdf:comment</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#description">ptop:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : Document Abstract</para>
    ///   <para>rdfs:comment : An abstract or summary of a document.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#documentAbstract">ptop:documentAbstract</a>
    /// </summary>
    let documentAbstract = _prefixId.prefix "documentAbstract"
    /// <summary>
    ///   <para>rdfs:label : Document Author</para>
    ///   <para>rdfs:comment : The creator (or one of the creators) of a document.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#documentAuthor">ptop:documentAuthor</a>
    /// </summary>
    let documentAuthor = _prefixId.prefix "documentAuthor"
    /// <summary>
    ///   <para>rdfs:label : Document Subtitle</para>
    ///   <para>rdfs:comment : A very short sub-title of a document, usually a single sentence</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#documentSubTitle">ptop:documentSubTitle</a>
    /// </summary>
    let documentSubTitle = _prefixId.prefix "documentSubTitle"
    /// <summary>
    ///   <para>rdfs:label : Doing Business as</para>
    ///   <para>rdfs:comment : A name used for marketing purposes. Usually, it does not correspond to the legal name of the organisation.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#doingBusinessAs">ptop:doingBusinessAs</a>
    /// </summary>
    let doingBusinessAs = _prefixId.prefix "doingBusinessAs"
    /// <summary>
    ///   <para>rdfs:label : End Time</para>
    ///   <para>rdfs:comment : the end time point of a happening</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#endTime">ptop:endTime</a>
    /// </summary>
    let endTime = _prefixId.prefix "endTime"
    /// <summary>
    ///   <para>rdfs:label : Established in</para>
    ///   <para>rdfs:comment : The place where the organization is established or registered</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#establishedIn">ptop:establishedIn</a>
    /// </summary>
    let establishedIn = _prefixId.prefix "establishedIn"
    /// <summary>
    ///   <para>rdfs:label : Establishment Date</para>
    ///   <para>rdfs:comment : The date when the organization was established or registered</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#establishmentDate">ptop:establishmentDate</a>
    /// </summary>
    let establishmentDate = _prefixId.prefix "establishmentDate"
    /// <summary>
    ///   <para>rdfs:label : First Name</para>
    ///   <para>rdfs:comment : The relation between a person and his/her first name. Usually used to call the person.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#firstName">ptop:firstName</a>
    /// </summary>
    let firstName = _prefixId.prefix "firstName"
    /// <summary>
    ///   <para>rdfs:label : Given Name</para>
    ///   <para>rdfs:comment : The relation between a person and his/her given name.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#givenName">ptop:givenName</a>
    /// </summary>
    let givenName = _prefixId.prefix "givenName"
    /// <summary>
    ///   <para>rdfs:label : has Child</para>
    ///   <para>rdfs:comment : The relation of a parent to his/her child.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasChild">ptop:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>rdfs:label : has Contact Info</para>
    ///   <para>rdfs:comment : The information by which a given object can be contacted. Usually an address, telefon number, e-mail address, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasContactInfo">ptop:hasContactInfo</a>
    /// </summary>
    let hasContactInfo = _prefixId.prefix "hasContactInfo"
    /// <summary>
    ///   <para>rdfs:label : has Contributor</para>
    ///   <para>rdfs:comment : An agent responsible for making contributions to the content of a resource. Examples of Contributor include a person, an organization, or a service. DC2003ISO</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasContributor">ptop:hasContributor</a>
    /// </summary>
    let hasContributor = _prefixId.prefix "hasContributor"
    /// <summary>
    ///   <para>rdfs:label : has Creator</para>
    ///   <para>rdfs:comment : An agent primarily responsible for making the content of a resource. Examples of Creator include a person, an organization, or a service. Typically, the name of the Creator should be used to indicate the agent. (DC2003ISO, Creator)</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasCreator">ptop:hasCreator</a>
    /// </summary>
    let hasCreator = _prefixId.prefix "hasCreator"
    /// <summary>
    ///   <para>rdfs:label : has Date</para>
    ///   <para>rdfs:comment : Typically, Date will be associated with the creation or availability of the resource. Recommended best practice for encoding the date value is defined in a profile of ISO 8601 [W3CDTF] and includes (among others) dates of the form YYYY-MM-DD. For official documents, it could be the date of signature. It can also contain a java timestamp. Usually, time is connected to a happening (event/situation) in which the information resource is a participation entity. These include: creation of the information resource, its modification or other important happening. Very often such happening is in the background knowledge and the modeling of domain task does not require the explicit representation of this happening. If it plays important role in the model domain or for the task, then the user needs to extend the ontology in an appropriate way.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasDate">ptop:hasDate</a>
    /// </summary>
    let hasDate = _prefixId.prefix "hasDate"
    /// <summary>
    ///   <para>rdfs:label : has Employee</para>
    ///   <para>rdfs:comment : Relates a particular organization to its employees.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasEmployee">ptop:hasEmployee</a>
    /// </summary>
    let hasEmployee = _prefixId.prefix "hasEmployee"
    /// <summary>
    ///   <para>rdfs:label : has Leader</para>
    ///   <para>rdfs:comment : A general relation between an organization and a person who rules or guides or inspires it in some sense. It may or may not be an employee, may or may not be formal etc. Typically there is a single leader of an organization.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasLeader">ptop:hasLeader</a>
    /// </summary>
    let hasLeader = _prefixId.prefix "hasLeader"
    /// <summary>
    ///   <para>rdfs:label : has Member</para>
    ///   <para>rdfs:comment : Relates a particular organization to the agents that are its members. This predicate indicates `generic' membership, although there may be specialized kinds of membership in the same organization. Typically, membership eligibility is determined by the organization and accepted with the agent's voluntary affiliation. In many cases Persons that take Positions within Organization are considered members of the organization, although this is no way formally encoded here.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasMember">ptop:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : has Old Name</para>
    ///   <para>rdfs:comment : Relates an entity to its old name or alias that is no longer considered legitimate. For instance, Pekin is one of the old spellings of the name of the Chineese capital Beijing. The same happens to companies when they change their names and to womam when she gets married.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasOldName">ptop:hasOldName</a>
    /// </summary>
    let hasOldName = _prefixId.prefix "hasOldName"
    /// <summary>
    ///   <para>rdfs:label : has Parent</para>
    ///   <para>rdfs:comment : Relation between a person and his/her mother or father.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasParent">ptop:hasParent</a>
    /// </summary>
    let hasParent = _prefixId.prefix "hasParent"
    /// <summary>
    ///   <para>rdfs:label : Participant in a Happening</para>
    ///   <para>rdfs:comment : The relation between a happenning and the agent involved in it. Fequently, the participants play some roles in the happening, then the appriate roles have to be introduced.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasParticipant">ptop:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>rdfs:label : Entity Participating in a Happening</para>
    ///   <para>rdfs:comment : The relation between a happening and an entity determining it. Such entities can be agents, instruments, materials, places, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasParticipatingEntity">ptop:hasParticipatingEntity</a>
    /// </summary>
    let hasParticipatingEntity = _prefixId.prefix "hasParticipatingEntity"
    /// <summary>
    ///   <para>rdfs:label : has Position</para>
    ///   <para>rdfs:comment : Relation between a person and his/her job position.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasPosition">ptop:hasPosition</a>
    /// </summary>
    let hasPosition = _prefixId.prefix "hasPosition"
    /// <summary>
    ///   <para>rdfs:label : has Relative</para>
    ///   <para>rdfs:comment : Relation between a person and his/her relatives - mother, father, brother, sister, child, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasRelative">ptop:hasRelative</a>
    /// </summary>
    let hasRelative = _prefixId.prefix "hasRelative"
    /// <summary>
    ///   <para>rdfs:label : has Sibling</para>
    ///   <para>rdfs:comment : Relation between a person and his/her siblings - brother or sister.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasSibling">ptop:hasSibling</a>
    /// </summary>
    let hasSibling = _prefixId.prefix "hasSibling"
    /// <summary>
    ///   <para>rdfs:label : has Social Position</para>
    ///   <para>rdfs:comment : The relation between a person and the social position he has. </para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasSocialPosition">ptop:hasSocialPosition</a>
    /// </summary>
    let hasSocialPosition = _prefixId.prefix "hasSocialPosition"
    /// <summary>
    ///   <para>rdfs:label : has Spouse</para>
    ///   <para>rdfs:comment : Relation between a man and a woman that are married. This property is time constrained by the marriage happening for the two persons. Thus, one could have different spouses in different periods. If this time relation is important for a given domain, it needs to be modelled by the marriage happening.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasSpouse">ptop:hasSpouse</a>
    /// </summary>
    let hasSpouse = _prefixId.prefix "hasSpouse"
    /// <summary>
    ///   <para>rdfs:label : has Subject</para>
    ///   <para>rdfs:comment : The topic of content of a given resource. Comment: Typically, the Subject will be expressed as keywords, key phrases, or classification codes that describe the topic of resource. Recommended best practice is to select a value from a controlled vocabulary or formal classification scheme. (DC2003ISO, Subject)</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#hasSubject">ptop:hasSubject</a>
    /// </summary>
    let hasSubject = _prefixId.prefix "hasSubject"
    /// <summary>
    ///   <para>rdfs:label : Held from</para>
    ///   <para>rdfs:comment : When the holder occupied a given position</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#heldFrom">ptop:heldFrom</a>
    /// </summary>
    let heldFrom = _prefixId.prefix "heldFrom"
    /// <summary>
    ///   <para>rdfs:label : Held to</para>
    ///   <para>rdfs:comment : When the holder released a given position</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#heldTo">ptop:heldTo</a>
    /// </summary>
    let heldTo = _prefixId.prefix "heldTo"
    /// <summary>
    ///   <para>rdfs:label : Holder</para>
    ///   <para>rdfs:comment : The person holding the position</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#holder">ptop:holder</a>
    /// </summary>
    let holder = _prefixId.prefix "holder"
    /// <summary>
    ///   <para>rdfs:label : in Language</para>
    ///   <para>rdfs:comment : The language of the intellectual content of a resource. Recommended best practice is to use RFC 3066 [RFC3066], which, in conjunction with ISO 639 [ISO639], defines two- and three-letter primary language tags with optional subtags. Examples include “en” or “eng” for English, “akk” for Akkadian, and “en-GB” for English used in the United Kingdom. DC2003ISO</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#inLanguage">ptop:inLanguage</a>
    /// </summary>
    let inLanguage = _prefixId.prefix "inLanguage"
    /// <summary>
    ///   <para>rdfs:label : Information Resource Coverage</para>
    ///   <para>rdfs:comment : The extent or scope of resource content. Typically, Coverage will include spatial location (a place name or geographic coordinates), temporal period (a period label, date, or date range), or jurisdiction (such as a named administrative entity). Recommended best practice is to select a value from a controlled vocabulary (for example, the Thesaurus of Geographic Names [TGN]) and to use, where appropriate, named places or time periods in preference to numeric identifiers such as sets of coordinates or date ranges. DC2003ISO</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#informationResourceCoverage">ptop:informationResourceCoverage</a>
    /// </summary>
    let informationResourceCoverage = _prefixId.prefix "informationResourceCoverage"
    /// <summary>
    ///   <para>rdfs:label : Information Resource Identifier</para>
    ///   <para>rdfs:comment : An unambiguous reference to the information resource within a given context. Recommended best practice is to identify the resource by means of a string or number conforming to a formal identification system. Formal identification systems include but are not limited to the Uniform Resource Identifier (URI) (including the Uniform Resource Locator (URL)), the Digital Object Identifier (DOI), and the International Standard Book Number (ISBN). DC2003ISO.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#informationResourceIdentifier">ptop:informationResourceIdentifier</a>
    /// </summary>
    let informationResourceIdentifier = _prefixId.prefix "informationResourceIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Information Resource Rights</para>
    ///   <para>rdfs:comment : Information about rights held in and over the resource. Typically, Rights will contain a rights management statement for the resource, or reference to a service providing such information. Rights information often encompasses Intellectual Property Rights (IPR), Copyright, and various Property Rights. If the Rights element is absent, no assumptions should be made about any rights held in or over the resource. DC2003ISO</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#informationResourceRights">ptop:informationResourceRights</a>
    /// </summary>
    let informationResourceRights = _prefixId.prefix "informationResourceRights"
    /// <summary>
    ///   <para>rdfs:label : Entity Involved in</para>
    ///   <para>rdfs:comment : The entities related to a given happening. Such entities can be agents, instruments, materials, places, etc.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#involvedEntityIn">ptop:involvedEntityIn</a>
    /// </summary>
    let involvedEntityIn = _prefixId.prefix "involvedEntityIn"
    /// <summary>
    ///   <para>rdfs:label : Involved in</para>
    ///   <para>rdfs:comment : The participating entities in a given happening that are agents. Participation is usually via some role.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#involvedIn">ptop:involvedIn</a>
    /// </summary>
    let involvedIn = _prefixId.prefix "involvedIn"
    /// <summary>
    ///   <para>rdfs:label : is Boss of</para>
    ///   <para>rdfs:comment : Relates a Person to another one, where the first is the immediate boss or supervisor of the latter. This is a many-to-many relationship, i.e. there can be more than one boss of a person, even contemporally.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#isBossOf">ptop:isBossOf</a>
    /// </summary>
    let isBossOf = _prefixId.prefix "isBossOf"
    /// <summary>
    ///   <para>rdfs:label : is Legal Entity</para>
    ///   <para>rdfs:comment : Determines whether a particular Agent is a legal entity. The range should be constrained to Boolean. Agents, for which the value is True, correspond to instances of http://www.cyc.com/2003/04/01/cyc#LegalAgent, which is defined as follows "Each instance of #LegalAgent is an agent who has some status in a particular legal system. At the very least, such an agent is recognized by some legal authority as having some kinds of rights and/or responsibilities as an agent (e.g., #citizens of Germany), ... ". In PROTON, it is modeled as property in order to avoid multiple-inheritance of classes and/or multiple classifications of instances.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#isLegalEntity">ptop:isLegalEntity</a>
    /// </summary>
    let isLegalEntity = _prefixId.prefix "isLegalEntity"
    /// <summary>
    ///   <para>rdfs:label : is Owned by</para>
    ///   <para>rdfs:comment : The relation between an object and an agent that is the owner of that object.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#isOwnedBy">ptop:isOwnedBy</a>
    /// </summary>
    let isOwnedBy = _prefixId.prefix "isOwnedBy"
    /// <summary>
    ///   <para>rdfs:label : Laconic Description</para>
    ///   <para>rdfs:comment : An extremely short (typically, single sentence) description of an entity</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#laconicDescription">ptop:laconicDescription</a>
    /// </summary>
    let laconicDescription = _prefixId.prefix "laconicDescription"
    /// <summary>
    ///   <para>rdfs:label : Last Name</para>
    ///   <para>rdfs:comment : The relation between a person and his/her last name. Usually the family name.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#lastName">ptop:lastName</a>
    /// </summary>
    let lastName = _prefixId.prefix "lastName"
    /// <summary>
    ///   <para>rdfs:label : Latitude</para>
    ///   <para>rdfs:comment : In degrees, minutes, and seconds: no sign or (+) = North; negative sign (-) = South.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#latitude">ptop:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    /// <summary>
    ///   <para>rdfs:label : Located in</para>
    ///   <para>rdfs:comment : The relation between an object (also some happenings via their participants) and location where the object is.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#locatedIn">ptop:locatedIn</a>
    /// </summary>
    let locatedIn = _prefixId.prefix "locatedIn"
    /// <summary>
    ///   <para>rdfs:label : Longitude</para>
    ///   <para>rdfs:comment : In degrees, minutes, and seconds: no sign or (+) = East; negative sign (-) = West.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#longitude">ptop:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>rdfs:label : Main Label</para>
    ///   <para>rdfs:comment : This is a label of an entity which is consider to be representative for it. In cases when the entity is presented to someone, usually, this label will be used. In a sense, it is a specializatoin of rdfs:label</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#mainLabel">ptop:mainLabel</a>
    /// </summary>
    let mainLabel = _prefixId.prefix "mainLabel"
    /// <summary>
    ///   <para>rdfs:label : Name of any kind</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#name">ptop:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : NIMA GNS Designator</para>
    ///   <para>rdfs:comment : The designator of the entity according to the NIMA GeoNames Server.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#nimaGNSDesignator">ptop:nimaGNSDesignator</a>
    /// </summary>
    let nimaGNSDesignator = _prefixId.prefix "nimaGNSDesignator"

    /// <summary>
    ///   <para>rdfs:label : NIMA GNS Unique Feature Identifier</para>
    ///   <para>rdfs:comment : The Unique Feature Identifier from the NIMA GNS. A number which uniquely identifies the location.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#nimaGNSUniqueFeatureIndentifier">ptop:nimaGNSUniqueFeatureIndentifier</a>
    /// </summary>
    let nimaGNSUniqueFeatureIndentifier =
        _prefixId.prefix "nimaGNSUniqueFeatureIndentifier"

    /// <summary>
    ///   <para>rdfs:label : Number of Employees</para>
    ///   <para>rdfs:comment : The estimated number of employees in the organization.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#numberOfEmployees">ptop:numberOfEmployees</a>
    /// </summary>
    let numberOfEmployees = _prefixId.prefix "numberOfEmployees"
    /// <summary>
    ///   <para>rdfs:label : Operated by</para>
    ///   <para>rdfs:comment : A relation between a service and the agent (usually organisation), who provides it</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#operatedBy">ptop:operatedBy</a>
    /// </summary>
    let operatedBy = _prefixId.prefix "operatedBy"
    /// <summary>
    ///   <para>rdfs:label : Owns</para>
    ///   <para>rdfs:comment : An agent fully owns an Object. In many cases this means also full control, unless the agent has transferred the control to another agent.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#owns">ptop:owns</a>
    /// </summary>
    let owns = _prefixId.prefix "owns"
    /// <summary>
    ///   <para>rdfs:label : Parent Organization of</para>
    ///   <para>rdfs:comment : A relation between two organizations, where one of them is dependent on the other in some sense. This is a transitive relation, i.e. if organization X is a parent organization of Y and the latter is a parent organization of Z, then X is also considered a parent organization of Z. Inverse of subsidiaryOrganizationOf.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#parentOrganizationOf">ptop:parentOrganizationOf</a>
    /// </summary>
    let parentOrganizationOf = _prefixId.prefix "parentOrganizationOf"
    /// <summary>
    ///   <para>rdfs:label : Part of</para>
    ///   <para>rdfs:comment : The general part-of relation which takes place between a whole and each of its parts. It has a number of specializations.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#partOf">ptop:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    /// <summary>
    ///   <para>rdfs:label : Partially Controls</para>
    ///   <para>rdfs:comment : Any sort of partial control an agent has with respect to an object.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#partiallyControls">ptop:partiallyControls</a>
    /// </summary>
    let partiallyControls = _prefixId.prefix "partiallyControls"
    /// <summary>
    ///   <para>rdfs:label : Partially Owns</para>
    ///   <para>rdfs:comment : Indicates that an Agent has some ownership over an object. It allows wide interpretations from "I have a bike" to "John has shares in Fujitsu".</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#partiallyOwns">ptop:partiallyOwns</a>
    /// </summary>
    let partiallyOwns = _prefixId.prefix "partiallyOwns"
    /// <summary>
    ///   <para>rdfs:label : Population Count</para>
    ///   <para>rdfs:comment : The number of citizens of a location.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#populationCount">ptop:populationCount</a>
    /// </summary>
    let populationCount = _prefixId.prefix "populationCount"
    /// <summary>
    ///   <para>rdfs:label : Produced by</para>
    ///   <para>rdfs:comment : A relation between a company and its ProductModel</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#producedBy">ptop:producedBy</a>
    /// </summary>
    let producedBy = _prefixId.prefix "producedBy"
    /// <summary>
    ///   <para>rdfs:label : Registered in</para>
    ///   <para>rdfs:comment : A relation between an organization and the location in which it is registered.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#registeredIn">ptop:registeredIn</a>
    /// </summary>
    let registeredIn = _prefixId.prefix "registeredIn"
    /// <summary>
    ///   <para>rdfs:label : Resource Format</para>
    ///   <para>rdfs:comment : The physical or digital manifestation of the resource. Typically, Format will include the media-type or dimensions of the resource. Format may be used to identify the software, hardware, or other equipment needed to display or operate the resource. Examples of dimensions include size and duration. Recommended best practice is to select a value from a controlled vocabulary (for example, the list of Internet Media Types [MIME] defining computer media formats). DC2003ISO</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#resourceFormat">ptop:resourceFormat</a>
    /// </summary>
    let resourceFormat = _prefixId.prefix "resourceFormat"
    /// <summary>
    ///   <para>rdfs:label : Resource Type</para>
    ///   <para>rdfs:comment : The nature or genre of the content of the resource. Type includes terms describing general categories, functions, genres, or aggregation levels for content. Recommended best practice is to select a value from a controlled vocabulary (for example, the DCMI Type Vocabulary [DCT]). To describe the physical or digital manifestation of the resource, use the resourceFormat property. DC2003ISO.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#resourceType">ptop:resourceType</a>
    /// </summary>
    let resourceType = _prefixId.prefix "resourceType"
    /// <summary>
    ///   <para>rdfs:label : Role Holder</para>
    ///   <para>rdfs:comment : The relation between a role and the entity that 'plays' a role in a given happening.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#roleHolder">ptop:roleHolder</a>
    /// </summary>
    let roleHolder = _prefixId.prefix "roleHolder"
    /// <summary>
    ///   <para>rdfs:label : Role in</para>
    ///   <para>rdfs:comment : Relates a role to a happening, conditioned and affected by the role. Usually, the participants of a happening 'play' one or more roles in it.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#roleIn">ptop:roleIn</a>
    /// </summary>
    let roleIn = _prefixId.prefix "roleIn"
    /// <summary>
    ///   <para>rdfs:label : Social Position Holder</para>
    ///   <para>rdfs:comment : The relation between a social position and the person who has it. </para>
    ///   <a href="http://www.ontotext.com/proton/protontop#socialPositionHolder">ptop:socialPositionHolder</a>
    /// </summary>
    let socialPositionHolder = _prefixId.prefix "socialPositionHolder"
    /// <summary>
    ///   <para>rdfs:label : Start Time</para>
    ///   <para>rdfs:comment : the starting moment of a happening</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#startTime">ptop:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
    /// <summary>
    ///   <para>rdfs:label : Stated by</para>
    ///   <para>rdfs:comment : Relates a statement to the agent who made it. In the case of an offer, the agent is the offerer; in case of a contract, those are the parties. In case of written statements, the creator/author and the "stater" could be different agents, due to the fact that one agent my have prepared and/or published a statement on behalf of another.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#statedBy">ptop:statedBy</a>
    /// </summary>
    let statedBy = _prefixId.prefix "statedBy"
    /// <summary>
    ///   <para>rdfs:label : Subregion of</para>
    ///   <para>rdfs:comment : Relation between two locations where the first is contained within the other.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#subRegionOf">ptop:subRegionOf</a>
    /// </summary>
    let subRegionOf = _prefixId.prefix "subRegionOf"
    /// <summary>
    ///   <para>rdfs:label : Subtopic of</para>
    ///   <para>rdfs:comment : A relation from less general to more general topic. Defined to be transitive via rule.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#subTopicOf">ptop:subTopicOf</a>
    /// </summary>
    let subTopicOf = _prefixId.prefix "subTopicOf"
    /// <summary>
    ///   <para>rdfs:label : Subsidiary Organization of</para>
    ///   <para>rdfs:comment : Indicates that an organization is in some sense part of another organization. This necessarily requires structural and organizational relations and may or may not indicate ownership. Its reverse, parentOrganizationOf, is a special case of partial control.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#subsidiaryOrganizationOf">ptop:subsidiaryOrganizationOf</a>
    /// </summary>
    let subsidiaryOrganizationOf = _prefixId.prefix "subsidiaryOrganizationOf"
    /// <summary>
    ///   <para>rdfs:label : System Primitive</para>
    ///   <para>rdfs:comment : The system classes and properties are used to encode system specific information. They, as well as their instances and related information, should usually not be presented to the end-user. In practice, user-interface and visualization modules, can filter such primitives. All system primitives with this property should be marked with string value "T".</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#systemPrimitive">ptop:systemPrimitive</a>
    /// </summary>
    let systemPrimitive = _prefixId.prefix "systemPrimitive"
    /// <summary>
    ///   <para>rdfs:label : Title</para>
    ///   <para>rdfs:comment : A name given to an information resource. Typically, title will be a name by which the resource is formally known. (DC2003ISO, Title there)</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#title">ptop:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : Transitive over</para>
    ///   <para>rdfs:comment : Makes possible the modelling of a specific, but rather useful modelling pattern. The semantics is defined with the following axiom: (p,transitiveOver,q) (x,p,y) (y,q,z) =&gt; (x,p,z). Sample usage is: (locatedIn, transitiveOver, subRegionOf) (Ontotext,locatedIn,Bulgaria) (Bulgaria,subRegionOf,Europe) =&gt; (Ontotext,locatedIn,Europe). The intended domain and range of this property are owl:ObjectProperty; those are not formally specified, in order not to get the ontology outside the OWL DL segment.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#transitiveOver">ptop:transitiveOver</a>
    /// </summary>
    let transitiveOver = _prefixId.prefix "transitiveOver"
    /// <summary>
    ///   <para>rdfs:label : Valid from</para>
    ///   <para>rdfs:comment : The time when a statement is made valid. The happing of making the statement valid is not explicitly represented in Proton. If it is necessary for the task the ontology needs to be extented.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#validFrom">ptop:validFrom</a>
    /// </summary>
    let validFrom = _prefixId.prefix "validFrom"
    /// <summary>
    ///   <para>rdfs:label : Valid until</para>
    ///   <para>rdfs:comment : The time when a statement is made invalid. The happening of making the statement invalid is not explicitly represented in Proton. If it is necessary for the task the ontology should be extented.</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#validUntil">ptop:validUntil</a>
    /// </summary>
    let validUntil = _prefixId.prefix "validUntil"
    /// <summary>
    ///   <para>rdfs:label : within Organization</para>
    ///   <para>rdfs:comment : Determines in which organization is the position</para>
    ///   <a href="http://www.ontotext.com/proton/protontop#withinOrganization">ptop:withinOrganization</a>
    /// </summary>
    let withinOrganization = _prefixId.prefix "withinOrganization"
