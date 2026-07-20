namespace http.www.ontotext.com.proton.protontop.hash

open DoxAletheia

module ptop =
    let _namespace_name = "http://www.ontotext.com/proton/protontop#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Something, which neither happens nor exists, e.g. a number or a chemical compound formula. Those are usually some symbols, invented to refer to general notions.
    /// <see href="http://www.ontotext.com/proton/protontop#Abstract"></see></summary>
    let Abstract = _prefix "Abstract"
    /// <summary>
    /// Any sort of an entity of interest, usually something existing, happening, or purely abstract. Entities may have several - more than one - names or aliases.
    /// <see href="http://www.ontotext.com/proton/protontop#Entity"></see></summary>
    let Entity = _prefix "Entity"
    /// <summary>
    /// An Agent is something, which can show (carry out) an independent action, whether consciously or not. Most animals are considered agents, in most contexts; so are most organizations. According to DOLCE 2.0 "objects to which we ascribe intentions, beliefs and desires". In PROTON, Agent also denotes any automatic device and service, including web services and servers.
    /// <see href="http://www.ontotext.com/proton/protontop#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Objects are entities that could be claimed to exist - in some sense of existence. An object can play a certain role in some happenings. Objects could be substantially real - as the Buckingham Palace or a hardcopy book - or substantially imperceptible - for instance, an electronic document that exists only virtually, one cannot touch it.
    /// <see href="http://www.ontotext.com/proton/protontop#Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// Any instance of a particular notation, used to make the contact with an individual, an organization, or any other object possible.
    /// <see href="http://www.ontotext.com/proton/protontop#ContactInformation"></see></summary>
    let ContactInformation = _prefix "ContactInformation"
    /// <summary>
    /// The information content of any sort of document. The tangible aspects are ignored. It is usually a document in free text with no formal structure or semantics.
    /// <see href="http://www.ontotext.com/proton/protontop#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// InformationResource denotes an information resource with identity, as defined in Dublin Core (DC2003ISO). InformationResource is considered any communication or message that is delivered or produced, taking into account the specific intention of its originator, and also the supposition (and anticipation) for a particular audience or counter-agent in the process of communication (i.e. passive or active feed-back).
    /// <see href="http://www.ontotext.com/proton/protontop#InformationResource"></see></summary>
    let InformationResource = _prefix "InformationResource"
    /// <summary>
    /// A dynamic event, such as "running" or "a concert".
    /// <see href="http://www.ontotext.com/proton/protontop#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// Something that happens. It can be either dynamic - like in "drawing a circle", or static - like in "being a president". In all cases, a happening (an event, a situation, or a time period) has a certain (usually quite concrete) temporal positioning - in the simplest case it is the one, denoted by start and end point in time.
    /// <see href="http://www.ontotext.com/proton/protontop#Happening"></see></summary>
    let Happening = _prefix "Happening"
    /// <summary>
    /// General concept with well defined (idiomatic) meaning which can have a set of distinct lexical items (surface realizations) associated with it. Examples are: F2F, I18N, P2P, B2B, VIP, ASAP, Semantic Web
    /// <see href="http://www.ontotext.com/proton/protontop#GeneralTerm"></see></summary>
    let GeneralTerm = _prefix "GeneralTerm"
    /// <summary>
    /// A group of agents that is not organized in any way. It could be the group of people in a bus or the shareholders of a company.
    /// <see href="http://www.ontotext.com/proton/protontop#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// A message that is stated or declared; a communication (oral or written), setting forth particulars or facts, etc; "according to his statement he was in London on that day". WordNet 1.7.1
    /// <see href="http://www.ontotext.com/proton/protontop#Statement"></see></summary>
    let Statement = _prefix "Statement"
    /// <summary>
    /// The situation of a person, holding a job (employment) position within an organization. The sub-classes of this class define a number of different types of positions.
    /// <see href="http://www.ontotext.com/proton/protontop#JobPosition"></see></summary>
    let JobPosition = _prefix "JobPosition"
    /// <summary>
    /// The situation of a person, having a social position like celebrity, nobelty, job position, cleric, out of laws. The sub-classes of this class define different social statuses.
    /// <see href="http://www.ontotext.com/proton/protontop#SocialPosition"></see></summary>
    let SocialPosition = _prefix "SocialPosition"
    /// <summary>
    /// A spoken or written natural language
    /// <see href="http://www.ontotext.com/proton/protontop#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// Usually a geographic location on the earth, however any sort of 3D regions also fit here. The classification is based on the ADL Feature Type Thesaurus version 070203. Additionally, classes from Geonames classification are included. For each specific type, the corresponding NIMA GNS designators (DSG) are given.
    /// <see href="http://www.ontotext.com/proton/protontop#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// Any given number, within the meaning that a number is one of the following: a concept of quantity derived from zero and units; or a numeral (or a string of numerals) used for identification ("she refused to give them her Social Security number"); or a phone number, etc.
    /// <see href="http://www.ontotext.com/proton/protontop#Number"></see></summary>
    let Number = _prefix "Number"
    /// <summary>
    /// Organization is a group, which is established in such a way that certain known relationships and obligations exist between the members, and/or between the organization and its members, and/or between the organization and the public (individuals or groups). It includes both informal and legally constituted organizations. Organizations can act as agents - to undertake projects, to enter into agreements, to own properties, etc. Most organizations have names. Almost all of them have at least two members.
    /// <see href="http://www.ontotext.com/proton/protontop#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// A Person is an agent, which is an individual who is a human being (i.e. any living or not alive member of the family Hominidae). Wordnet 2.0.
    /// <see href="http://www.ontotext.com/proton/protontop#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// The general concept of a product model, for example, Ford T. The instances of this class are not specific instances of the product - the latter are just instances. Although product models are rather abstract entities (generally, intangible), this class is defined as a sub-class of Object, because it has a strong temporal extent (it comes to exsitence at some point of time). There could be several information resources associated with a product model (e.g. specifications, brouchures, etc.), but it is not an information resource on its own.
    /// <see href="http://www.ontotext.com/proton/protontop#ProductModel"></see></summary>
    let ProductModel = _prefix "ProductModel"
    /// <summary>
    /// The role of an entity (usually an agent) within/during/affecting (intentionally or not) a particular happening. For instance a project coordinator, or a trial defendant, or even a material object that serves as an evidence in a trial (e.g. a weapon). Usually, we say 'this object is in this role in this happening'.
    /// <see href="http://www.ontotext.com/proton/protontop#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// A static event or situation, like "sitting on a chair" or "holding position". Typically, those are temporarily homogenous, i.e. their nature is not expected/required to change with their duration. As a happening, they used to happen/take place/be true for some periods of time and may or may not have a well-defined space extension.
    /// <see href="http://www.ontotext.com/proton/protontop#Situation"></see></summary>
    let Situation = _prefix "Situation"
    /// <summary>
    /// Any sort of service, ranging from a scheduled flight or train services to a weather forecast information/web serivce. Many services could be considered agents (usually software services).
    /// <see href="http://www.ontotext.com/proton/protontop#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// This is a general time expression, which refers to a particular period of time, an interval. Repeating periods (like Spring or Christmas) are not time intervals, while specific instances of them (like the Spring of 1944) are. A TimeInterval could collapse, in very special cases, to a time point, however in this case, in contrast to the Abstract time point (referring to some time during the day), it should be bound to a specific date, i.e. to represent a timestamp.
    /// <see href="http://www.ontotext.com/proton/protontop#TimeInterval"></see></summary>
    let TimeInterval = _prefix "TimeInterval"
    /// <summary>
    /// Any sort of a topic or theme, explicitly defined for classification purposes. As long as any other class or entity can play the role of a topic, the instances of this class are only those concepts that are defined to serve as topics. The topic class is the natural top-class for linkage of logically informal taxonomies.
    /// <see href="http://www.ontotext.com/proton/protontop#Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    /// Indicates that an Agent has full control over an object. This is typically the case of wholly-owned subsidiaries and physicall possession of goods.
    /// <see href="http://www.ontotext.com/proton/protontop#controls"></see></summary>
    let controls = _prefix "controls"
    /// <summary>
    /// Any sort of partial control an agent has with respect to an object.
    /// <see href="http://www.ontotext.com/proton/protontop#partiallyControls"></see></summary>
    let partiallyControls = _prefix "partiallyControls"
    /// <summary>
    /// A reference to a resource from which the present resource is derived. The present resource may be derived from the Source resource in whole or in part. Recommended best practice is to identify the referenced resource by means of a string or number conforming to a formal identification system. DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#derivedFromSource"></see></summary>
    let derivedFromSource = _prefix "derivedFromSource"
    /// <summary>
    /// A textual description of an entity. Usually a free text in some natural language. As defined in DC2003ISO for InformationResources. In a sense, it is a specializatoin of rdf:comment
    /// <see href="http://www.ontotext.com/proton/protontop#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// An abstract or summary of a document.
    /// <see href="http://www.ontotext.com/proton/protontop#documentAbstract"></see></summary>
    let documentAbstract = _prefix "documentAbstract"
    /// <summary>
    /// The creator (or one of the creators) of a document.
    /// <see href="http://www.ontotext.com/proton/protontop#documentAuthor"></see></summary>
    let documentAuthor = _prefix "documentAuthor"
    /// <summary>
    /// An agent primarily responsible for making the content of a resource. Examples of Creator include a person, an organization, or a service. Typically, the name of the Creator should be used to indicate the agent. (DC2003ISO, Creator)
    /// <see href="http://www.ontotext.com/proton/protontop#hasCreator"></see></summary>
    let hasCreator = _prefix "hasCreator"
    /// <summary>
    /// A very short sub-title of a document, usually a single sentence
    /// <see href="http://www.ontotext.com/proton/protontop#documentSubTitle"></see></summary>
    let documentSubTitle = _prefix "documentSubTitle"
    /// <summary>
    /// An extremely short (typically, single sentence) description of an entity
    /// <see href="http://www.ontotext.com/proton/protontop#laconicDescription"></see></summary>
    let laconicDescription = _prefix "laconicDescription"
    /// <summary>
    /// A name used for marketing purposes. Usually, it does not correspond to the legal name of the organisation.
    /// <see href="http://www.ontotext.com/proton/protontop#doingBusinessAs"></see></summary>
    let doingBusinessAs = _prefix "doingBusinessAs"
    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protontop#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    /// the end time point of a happening
    /// <see href="http://www.ontotext.com/proton/protontop#endTime"></see></summary>
    let endTime = _prefix "endTime"
    /// <summary>
    /// The place where the organization is established or registered
    /// <see href="http://www.ontotext.com/proton/protontop#establishedIn"></see></summary>
    let establishedIn = _prefix "establishedIn"
    /// <summary>
    /// The relation between an object (also some happenings via their participants) and location where the object is.
    /// <see href="http://www.ontotext.com/proton/protontop#locatedIn"></see></summary>
    let locatedIn = _prefix "locatedIn"
    /// <summary>
    /// The date when the organization was established or registered
    /// <see href="http://www.ontotext.com/proton/protontop#establishmentDate"></see></summary>
    let establishmentDate = _prefix "establishmentDate"
    /// <summary>
    /// The relation between a person and his/her first name. Usually used to call the person.
    /// <see href="http://www.ontotext.com/proton/protontop#firstName"></see></summary>
    let firstName = _prefix "firstName"
    /// <summary>
    /// The relation between a person and his/her given name.
    /// <see href="http://www.ontotext.com/proton/protontop#givenName"></see></summary>
    let givenName = _prefix "givenName"
    /// <summary>
    /// The relation of a parent to his/her child.
    /// <see href="http://www.ontotext.com/proton/protontop#hasChild"></see></summary>
    let hasChild = _prefix "hasChild"
    /// <summary>
    /// Relation between a person and his/her relatives - mother, father, brother, sister, child, etc.
    /// <see href="http://www.ontotext.com/proton/protontop#hasRelative"></see></summary>
    let hasRelative = _prefix "hasRelative"
    /// <summary>
    /// The information by which a given object can be contacted. Usually an address, telefon number, e-mail address, etc.
    /// <see href="http://www.ontotext.com/proton/protontop#hasContactInfo"></see></summary>
    let hasContactInfo = _prefix "hasContactInfo"
    /// <summary>
    /// An agent responsible for making contributions to the content of a resource. Examples of Contributor include a person, an organization, or a service. DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#hasContributor"></see></summary>
    let hasContributor = _prefix "hasContributor"
    /// <summary>
    /// Typically, Date will be associated with the creation or availability of the resource. Recommended best practice for encoding the date value is defined in a profile of ISO 8601 [W3CDTF] and includes (among others) dates of the form YYYY-MM-DD. For official documents, it could be the date of signature. It can also contain a java timestamp. Usually, time is connected to a happening (event/situation) in which the information resource is a participation entity. These include: creation of the information resource, its modification or other important happening. Very often such happening is in the background knowledge and the modeling of domain task does not require the explicit representation of this happening. If it plays important role in the model domain or for the task, then the user needs to extend the ontology in an appropriate way.
    /// <see href="http://www.ontotext.com/proton/protontop#hasDate"></see></summary>
    let hasDate = _prefix "hasDate"
    /// <summary>
    /// Relates a particular organization to its employees.
    /// <see href="http://www.ontotext.com/proton/protontop#hasEmployee"></see></summary>
    let hasEmployee = _prefix "hasEmployee"
    /// <summary>
    /// Relates a particular organization to the agents that are its members. This predicate indicates `generic' membership, although there may be specialized kinds of membership in the same organization. Typically, membership eligibility is determined by the organization and accepted with the agent's voluntary affiliation. In many cases Persons that take Positions within Organization are considered members of the organization, although this is no way formally encoded here.
    /// <see href="http://www.ontotext.com/proton/protontop#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// A general relation between an organization and a person who rules or guides or inspires it in some sense. It may or may not be an employee, may or may not be formal etc. Typically there is a single leader of an organization.
    /// <see href="http://www.ontotext.com/proton/protontop#hasLeader"></see></summary>
    let hasLeader = _prefix "hasLeader"
    /// <summary>
    /// Relates an entity to its old name or alias that is no longer considered legitimate. For instance, Pekin is one of the old spellings of the name of the Chineese capital Beijing. The same happens to companies when they change their names and to womam when she gets married.
    /// <see href="http://www.ontotext.com/proton/protontop#hasOldName"></see></summary>
    let hasOldName = _prefix "hasOldName"
    /// <summary>
    /// Relation between a person and his/her mother or father.
    /// <see href="http://www.ontotext.com/proton/protontop#hasParent"></see></summary>
    let hasParent = _prefix "hasParent"
    /// <summary>
    /// The relation between a happenning and the agent involved in it. Fequently, the participants play some roles in the happening, then the appriate roles have to be introduced.
    /// <see href="http://www.ontotext.com/proton/protontop#hasParticipant"></see></summary>
    let hasParticipant = _prefix "hasParticipant"
    /// <summary>
    /// The relation between a happening and an entity determining it. Such entities can be agents, instruments, materials, places, etc.
    /// <see href="http://www.ontotext.com/proton/protontop#hasParticipatingEntity"></see></summary>
    let hasParticipatingEntity = _prefix "hasParticipatingEntity"
    /// <summary>
    /// The participating entities in a given happening that are agents. Participation is usually via some role.
    /// <see href="http://www.ontotext.com/proton/protontop#involvedIn"></see></summary>
    let involvedIn = _prefix "involvedIn"
    /// <summary>
    /// The entities related to a given happening. Such entities can be agents, instruments, materials, places, etc.
    /// <see href="http://www.ontotext.com/proton/protontop#involvedEntityIn"></see></summary>
    let involvedEntityIn = _prefix "involvedEntityIn"
    /// <summary>
    /// Relation between a person and his/her job position.
    /// <see href="http://www.ontotext.com/proton/protontop#hasPosition"></see></summary>
    let hasPosition = _prefix "hasPosition"
    /// <summary>
    /// The person holding the position
    /// <see href="http://www.ontotext.com/proton/protontop#holder"></see></summary>
    let holder = _prefix "holder"
    /// <summary>
    /// Relation between a person and his/her siblings - brother or sister.
    /// <see href="http://www.ontotext.com/proton/protontop#hasSibling"></see></summary>
    let hasSibling = _prefix "hasSibling"
    /// <summary>
    /// The relation between a person and the social position he has.
    /// <see href="http://www.ontotext.com/proton/protontop#hasSocialPosition"></see></summary>
    let hasSocialPosition = _prefix "hasSocialPosition"
    /// <summary>
    /// The relation between a social position and the person who has it.
    /// <see href="http://www.ontotext.com/proton/protontop#socialPositionHolder"></see></summary>
    let socialPositionHolder = _prefix "socialPositionHolder"
    /// <summary>
    /// Relation between a man and a woman that are married. This property is time constrained by the marriage happening for the two persons. Thus, one could have different spouses in different periods. If this time relation is important for a given domain, it needs to be modelled by the marriage happening.
    /// <see href="http://www.ontotext.com/proton/protontop#hasSpouse"></see></summary>
    let hasSpouse = _prefix "hasSpouse"
    /// <summary>
    /// The topic of content of a given resource. Comment: Typically, the Subject will be expressed as keywords, key phrases, or classification codes that describe the topic of resource. Recommended best practice is to select a value from a controlled vocabulary or formal classification scheme. (DC2003ISO, Subject)
    /// <see href="http://www.ontotext.com/proton/protontop#hasSubject"></see></summary>
    let hasSubject = _prefix "hasSubject"
    /// <summary>
    /// Makes possible the modelling of a specific, but rather useful modelling pattern. The semantics is defined with the following axiom: (p,transitiveOver,q) (x,p,y) (y,q,z) =&gt; (x,p,z). Sample usage is: (locatedIn, transitiveOver, subRegionOf) (Ontotext,locatedIn,Bulgaria) (Bulgaria,subRegionOf,Europe) =&gt; (Ontotext,locatedIn,Europe). The intended domain and range of this property are owl:ObjectProperty; those are not formally specified, in order not to get the ontology outside the OWL DL segment.
    /// <see href="http://www.ontotext.com/proton/protontop#transitiveOver"></see></summary>
    let transitiveOver = _prefix "transitiveOver"
    /// <summary>
    /// A relation from less general to more general topic. Defined to be transitive via rule.
    /// <see href="http://www.ontotext.com/proton/protontop#subTopicOf"></see></summary>
    let subTopicOf = _prefix "subTopicOf"
    /// <summary>
    /// When the holder occupied a given position
    /// <see href="http://www.ontotext.com/proton/protontop#heldFrom"></see></summary>
    let heldFrom = _prefix "heldFrom"
    /// <summary>
    /// the starting moment of a happening
    /// <see href="http://www.ontotext.com/proton/protontop#startTime"></see></summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// When the holder released a given position
    /// <see href="http://www.ontotext.com/proton/protontop#heldTo"></see></summary>
    let heldTo = _prefix "heldTo"
    /// <summary>
    /// The language of the intellectual content of a resource. Recommended best practice is to use RFC 3066 [RFC3066], which, in conjunction with ISO 639 [ISO639], defines two- and three-letter primary language tags with optional subtags. Examples include “en” or “eng” for English, “akk” for Akkadian, and “en-GB” for English used in the United Kingdom. DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#inLanguage"></see></summary>
    let inLanguage = _prefix "inLanguage"
    /// <summary>
    /// The extent or scope of resource content. Typically, Coverage will include spatial location (a place name or geographic coordinates), temporal period (a period label, date, or date range), or jurisdiction (such as a named administrative entity). Recommended best practice is to select a value from a controlled vocabulary (for example, the Thesaurus of Geographic Names [TGN]) and to use, where appropriate, named places or time periods in preference to numeric identifiers such as sets of coordinates or date ranges. DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#informationResourceCoverage"></see></summary>
    let informationResourceCoverage = _prefix "informationResourceCoverage"
    /// <summary>
    /// An unambiguous reference to the information resource within a given context. Recommended best practice is to identify the resource by means of a string or number conforming to a formal identification system. Formal identification systems include but are not limited to the Uniform Resource Identifier (URI) (including the Uniform Resource Locator (URL)), the Digital Object Identifier (DOI), and the International Standard Book Number (ISBN). DC2003ISO.
    /// <see href="http://www.ontotext.com/proton/protontop#informationResourceIdentifier"></see></summary>
    let informationResourceIdentifier = _prefix "informationResourceIdentifier"
    /// <summary>
    /// Information about rights held in and over the resource. Typically, Rights will contain a rights management statement for the resource, or reference to a service providing such information. Rights information often encompasses Intellectual Property Rights (IPR), Copyright, and various Property Rights. If the Rights element is absent, no assumptions should be made about any rights held in or over the resource. DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#informationResourceRights"></see></summary>
    let informationResourceRights = _prefix "informationResourceRights"
    /// <summary>
    /// Relates a Person to another one, where the first is the immediate boss or supervisor of the latter. This is a many-to-many relationship, i.e. there can be more than one boss of a person, even contemporally.
    /// <see href="http://www.ontotext.com/proton/protontop#isBossOf"></see></summary>
    let isBossOf = _prefix "isBossOf"
    /// <summary>
    /// Determines whether a particular Agent is a legal entity. The range should be constrained to Boolean. Agents, for which the value is True, correspond to instances of http://www.cyc.com/2003/04/01/cyc#LegalAgent, which is defined as follows "Each instance of #LegalAgent is an agent who has some status in a particular legal system. At the very least, such an agent is recognized by some legal authority as having some kinds of rights and/or responsibilities as an agent (e.g., #citizens of Germany), ... ". In PROTON, it is modeled as property in order to avoid multiple-inheritance of classes and/or multiple classifications of instances.
    /// <see href="http://www.ontotext.com/proton/protontop#isLegalEntity"></see></summary>
    let isLegalEntity = _prefix "isLegalEntity"
    /// <summary>
    /// The relation between an object and an agent that is the owner of that object.
    /// <see href="http://www.ontotext.com/proton/protontop#isOwnedBy"></see></summary>
    let isOwnedBy = _prefix "isOwnedBy"
    /// <summary>
    /// The relation between a person and his/her last name. Usually the family name.
    /// <see href="http://www.ontotext.com/proton/protontop#lastName"></see></summary>
    let lastName = _prefix "lastName"
    /// <summary>
    /// In degrees, minutes, and seconds: no sign or (+) = North; negative sign (-) = South.
    /// <see href="http://www.ontotext.com/proton/protontop#latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// In degrees, minutes, and seconds: no sign or (+) = East; negative sign (-) = West.
    /// <see href="http://www.ontotext.com/proton/protontop#longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// This is a label of an entity which is consider to be representative for it. In cases when the entity is presented to someone, usually, this label will be used. In a sense, it is a specializatoin of rdfs:label
    /// <see href="http://www.ontotext.com/proton/protontop#mainLabel"></see></summary>
    let mainLabel = _prefix "mainLabel"
    /// <summary>
    /// The designator of the entity according to the NIMA GeoNames Server.
    /// <see href="http://www.ontotext.com/proton/protontop#nimaGNSDesignator"></see></summary>
    let nimaGNSDesignator = _prefix "nimaGNSDesignator"
    /// <summary>
    /// The Unique Feature Identifier from the NIMA GNS. A number which uniquely identifies the location.
    /// <see href="http://www.ontotext.com/proton/protontop#nimaGNSUniqueFeatureIndentifier"></see></summary>
    let nimaGNSUniqueFeatureIndentifier = _prefix "nimaGNSUniqueFeatureIndentifier"
    /// <summary>
    /// The estimated number of employees in the organization.
    /// <see href="http://www.ontotext.com/proton/protontop#numberOfEmployees"></see></summary>
    let numberOfEmployees = _prefix "numberOfEmployees"
    /// <summary>
    /// A relation between a service and the agent (usually organisation), who provides it
    /// <see href="http://www.ontotext.com/proton/protontop#operatedBy"></see></summary>
    let operatedBy = _prefix "operatedBy"
    /// <summary>
    /// An agent fully owns an Object. In many cases this means also full control, unless the agent has transferred the control to another agent.
    /// <see href="http://www.ontotext.com/proton/protontop#owns"></see></summary>
    let owns = _prefix "owns"
    /// <summary>
    /// Indicates that an Agent has some ownership over an object. It allows wide interpretations from "I have a bike" to "John has shares in Fujitsu".
    /// <see href="http://www.ontotext.com/proton/protontop#partiallyOwns"></see></summary>
    let partiallyOwns = _prefix "partiallyOwns"
    /// <summary>
    /// A relation between two organizations, where one of them is dependent on the other in some sense. This is a transitive relation, i.e. if organization X is a parent organization of Y and the latter is a parent organization of Z, then X is also considered a parent organization of Z. Inverse of subsidiaryOrganizationOf.
    /// <see href="http://www.ontotext.com/proton/protontop#parentOrganizationOf"></see></summary>
    let parentOrganizationOf = _prefix "parentOrganizationOf"
    /// <summary>
    /// Indicates that an organization is in some sense part of another organization. This necessarily requires structural and organizational relations and may or may not indicate ownership. Its reverse, parentOrganizationOf, is a special case of partial control.
    /// <see href="http://www.ontotext.com/proton/protontop#subsidiaryOrganizationOf"></see></summary>
    let subsidiaryOrganizationOf = _prefix "subsidiaryOrganizationOf"
    /// <summary>
    /// The general part-of relation which takes place between a whole and each of its parts. It has a number of specializations.
    /// <see href="http://www.ontotext.com/proton/protontop#partOf"></see></summary>
    let partOf = _prefix "partOf"
    /// <summary>
    /// The number of citizens of a location.
    /// <see href="http://www.ontotext.com/proton/protontop#populationCount"></see></summary>
    let populationCount = _prefix "populationCount"
    /// <summary>
    /// A relation between a company and its ProductModel
    /// <see href="http://www.ontotext.com/proton/protontop#producedBy"></see></summary>
    let producedBy = _prefix "producedBy"
    /// <summary>
    /// A relation between an organization and the location in which it is registered.
    /// <see href="http://www.ontotext.com/proton/protontop#registeredIn"></see></summary>
    let registeredIn = _prefix "registeredIn"
    /// <summary>
    /// The physical or digital manifestation of the resource. Typically, Format will include the media-type or dimensions of the resource. Format may be used to identify the software, hardware, or other equipment needed to display or operate the resource. Examples of dimensions include size and duration. Recommended best practice is to select a value from a controlled vocabulary (for example, the list of Internet Media Types [MIME] defining computer media formats). DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#resourceFormat"></see></summary>
    let resourceFormat = _prefix "resourceFormat"
    /// <summary>
    /// The nature or genre of the content of the resource. Type includes terms describing general categories, functions, genres, or aggregation levels for content. Recommended best practice is to select a value from a controlled vocabulary (for example, the DCMI Type Vocabulary [DCT]). To describe the physical or digital manifestation of the resource, use the resourceFormat property. DC2003ISO.
    /// <see href="http://www.ontotext.com/proton/protontop#resourceType"></see></summary>
    let resourceType = _prefix "resourceType"
    /// <summary>
    /// The relation between a role and the entity that 'plays' a role in a given happening.
    /// <see href="http://www.ontotext.com/proton/protontop#roleHolder"></see></summary>
    let roleHolder = _prefix "roleHolder"
    /// <summary>
    /// Relates a role to a happening, conditioned and affected by the role. Usually, the participants of a happening 'play' one or more roles in it.
    /// <see href="http://www.ontotext.com/proton/protontop#roleIn"></see></summary>
    let roleIn = _prefix "roleIn"
    /// <summary>
    /// Relates a statement to the agent who made it. In the case of an offer, the agent is the offerer; in case of a contract, those are the parties. In case of written statements, the creator/author and the "stater" could be different agents, due to the fact that one agent my have prepared and/or published a statement on behalf of another.
    /// <see href="http://www.ontotext.com/proton/protontop#statedBy"></see></summary>
    let statedBy = _prefix "statedBy"
    /// <summary>
    /// Relation between two locations where the first is contained within the other.
    /// <see href="http://www.ontotext.com/proton/protontop#subRegionOf"></see></summary>
    let subRegionOf = _prefix "subRegionOf"
    /// <summary>
    /// The system classes and properties are used to encode system specific information. They, as well as their instances and related information, should usually not be presented to the end-user. In practice, user-interface and visualization modules, can filter such primitives. All system primitives with this property should be marked with string value "T".
    /// <see href="http://www.ontotext.com/proton/protontop#systemPrimitive"></see></summary>
    let systemPrimitive = _prefix "systemPrimitive"
    /// <summary>
    /// A name given to an information resource. Typically, title will be a name by which the resource is formally known. (DC2003ISO, Title there)
    /// <see href="http://www.ontotext.com/proton/protontop#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// The time when a statement is made valid. The happing of making the statement valid is not explicitly represented in Proton. If it is necessary for the task the ontology needs to be extented.
    /// <see href="http://www.ontotext.com/proton/protontop#validFrom"></see></summary>
    let validFrom = _prefix "validFrom"
    /// <summary>
    /// The time when a statement is made invalid. The happening of making the statement invalid is not explicitly represented in Proton. If it is necessary for the task the ontology should be extented.
    /// <see href="http://www.ontotext.com/proton/protontop#validUntil"></see></summary>
    let validUntil = _prefix "validUntil"
    /// <summary>
    /// Determines in which organization is the position
    /// <see href="http://www.ontotext.com/proton/protontop#withinOrganization"></see></summary>
    let withinOrganization = _prefix "withinOrganization"
