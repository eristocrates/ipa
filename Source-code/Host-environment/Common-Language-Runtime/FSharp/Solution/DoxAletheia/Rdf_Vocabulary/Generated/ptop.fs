namespace http.www.ontotext.com.proton.protontop.hash

open DoxAletheia.Rdf_Vocabulary

module ptop =
    let _namespace_name = "http://www.ontotext.com/proton/protontop#"
    /// <summary>
    /// Something, which neither happens nor exists, e.g. a number or a chemical compound formula. Those are usually some symbols, invented to refer to general notions.
    /// <see href="http://www.ontotext.com/proton/protontop#Abstract"></see></summary>
    let Abstract = Namespaced_IRI.parse _namespace_name "Abstract" |> NamespacedName
    /// <summary>
    /// Any sort of an entity of interest, usually something existing, happening, or purely abstract. Entities may have several - more than one - names or aliases.
    /// <see href="http://www.ontotext.com/proton/protontop#Entity"></see></summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    /// An Agent is something, which can show (carry out) an independent action, whether consciously or not. Most animals are considered agents, in most contexts; so are most organizations. According to DOLCE 2.0 "objects to which we ascribe intentions, beliefs and desires". In PROTON, Agent also denotes any automatic device and service, including web services and servers.
    /// <see href="http://www.ontotext.com/proton/protontop#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// Objects are entities that could be claimed to exist - in some sense of existence. An object can play a certain role in some happenings. Objects could be substantially real - as the Buckingham Palace or a hardcopy book - or substantially imperceptible - for instance, an electronic document that exists only virtually, one cannot touch it.
    /// <see href="http://www.ontotext.com/proton/protontop#Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName

    /// <summary>
    /// Any instance of a particular notation, used to make the contact with an individual, an organization, or any other object possible.
    /// <see href="http://www.ontotext.com/proton/protontop#ContactInformation"></see></summary>
    let ContactInformation =
        Namespaced_IRI.parse _namespace_name "ContactInformation" |> NamespacedName

    /// <summary>
    /// The information content of any sort of document. The tangible aspects are ignored. It is usually a document in free text with no formal structure or semantics.
    /// <see href="http://www.ontotext.com/proton/protontop#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName

    /// <summary>
    /// InformationResource denotes an information resource with identity, as defined in Dublin Core (DC2003ISO). InformationResource is considered any communication or message that is delivered or produced, taking into account the specific intention of its originator, and also the supposition (and anticipation) for a particular audience or counter-agent in the process of communication (i.e. passive or active feed-back).
    /// <see href="http://www.ontotext.com/proton/protontop#InformationResource"></see></summary>
    let InformationResource =
        Namespaced_IRI.parse _namespace_name "InformationResource" |> NamespacedName

    /// <summary>
    /// A dynamic event, such as "running" or "a concert".
    /// <see href="http://www.ontotext.com/proton/protontop#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// Something that happens. It can be either dynamic - like in "drawing a circle", or static - like in "being a president". In all cases, a happening (an event, a situation, or a time period) has a certain (usually quite concrete) temporal positioning - in the simplest case it is the one, denoted by start and end point in time.
    /// <see href="http://www.ontotext.com/proton/protontop#Happening"></see></summary>
    let Happening = Namespaced_IRI.parse _namespace_name "Happening" |> NamespacedName

    /// <summary>
    /// General concept with well defined (idiomatic) meaning which can have a set of distinct lexical items (surface realizations) associated with it. Examples are: F2F, I18N, P2P, B2B, VIP, ASAP, Semantic Web
    /// <see href="http://www.ontotext.com/proton/protontop#GeneralTerm"></see></summary>
    let GeneralTerm =
        Namespaced_IRI.parse _namespace_name "GeneralTerm" |> NamespacedName

    /// <summary>
    /// A group of agents that is not organized in any way. It could be the group of people in a bus or the shareholders of a company.
    /// <see href="http://www.ontotext.com/proton/protontop#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// A message that is stated or declared; a communication (oral or written), setting forth particulars or facts, etc; "according to his statement he was in London on that day". WordNet 1.7.1
    /// <see href="http://www.ontotext.com/proton/protontop#Statement"></see></summary>
    let Statement = Namespaced_IRI.parse _namespace_name "Statement" |> NamespacedName

    /// <summary>
    /// The situation of a person, holding a job (employment) position within an organization. The sub-classes of this class define a number of different types of positions.
    /// <see href="http://www.ontotext.com/proton/protontop#JobPosition"></see></summary>
    let JobPosition =
        Namespaced_IRI.parse _namespace_name "JobPosition" |> NamespacedName

    /// <summary>
    /// The situation of a person, having a social position like celebrity, nobelty, job position, cleric, out of laws. The sub-classes of this class define different social statuses.
    /// <see href="http://www.ontotext.com/proton/protontop#SocialPosition"></see></summary>
    let SocialPosition =
        Namespaced_IRI.parse _namespace_name "SocialPosition" |> NamespacedName

    /// <summary>
    /// A spoken or written natural language
    /// <see href="http://www.ontotext.com/proton/protontop#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName
    /// <summary>
    /// Usually a geographic location on the earth, however any sort of 3D regions also fit here. The classification is based on the ADL Feature Type Thesaurus version 070203. Additionally, classes from Geonames classification are included. For each specific type, the corresponding NIMA GNS designators (DSG) are given.
    /// <see href="http://www.ontotext.com/proton/protontop#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// Any given number, within the meaning that a number is one of the following: a concept of quantity derived from zero and units; or a numeral (or a string of numerals) used for identification ("she refused to give them her Social Security number"); or a phone number, etc.
    /// <see href="http://www.ontotext.com/proton/protontop#Number"></see></summary>
    let Number = Namespaced_IRI.parse _namespace_name "Number" |> NamespacedName

    /// <summary>
    /// Organization is a group, which is established in such a way that certain known relationships and obligations exist between the members, and/or between the organization and its members, and/or between the organization and the public (individuals or groups). It includes both informal and legally constituted organizations. Organizations can act as agents - to undertake projects, to enter into agreements, to own properties, etc. Most organizations have names. Almost all of them have at least two members.
    /// <see href="http://www.ontotext.com/proton/protontop#Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// A Person is an agent, which is an individual who is a human being (i.e. any living or not alive member of the family Hominidae). Wordnet 2.0.
    /// <see href="http://www.ontotext.com/proton/protontop#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// The general concept of a product model, for example, Ford T. The instances of this class are not specific instances of the product - the latter are just instances. Although product models are rather abstract entities (generally, intangible), this class is defined as a sub-class of Object, because it has a strong temporal extent (it comes to exsitence at some point of time). There could be several information resources associated with a product model (e.g. specifications, brouchures, etc.), but it is not an information resource on its own.
    /// <see href="http://www.ontotext.com/proton/protontop#ProductModel"></see></summary>
    let ProductModel =
        Namespaced_IRI.parse _namespace_name "ProductModel" |> NamespacedName

    /// <summary>
    /// The role of an entity (usually an agent) within/during/affecting (intentionally or not) a particular happening. For instance a project coordinator, or a trial defendant, or even a material object that serves as an evidence in a trial (e.g. a weapon). Usually, we say 'this object is in this role in this happening'.
    /// <see href="http://www.ontotext.com/proton/protontop#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// A static event or situation, like "sitting on a chair" or "holding position". Typically, those are temporarily homogenous, i.e. their nature is not expected/required to change with their duration. As a happening, they used to happen/take place/be true for some periods of time and may or may not have a well-defined space extension.
    /// <see href="http://www.ontotext.com/proton/protontop#Situation"></see></summary>
    let Situation = Namespaced_IRI.parse _namespace_name "Situation" |> NamespacedName
    /// <summary>
    /// Any sort of service, ranging from a scheduled flight or train services to a weather forecast information/web serivce. Many services could be considered agents (usually software services).
    /// <see href="http://www.ontotext.com/proton/protontop#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// This is a general time expression, which refers to a particular period of time, an interval. Repeating periods (like Spring or Christmas) are not time intervals, while specific instances of them (like the Spring of 1944) are. A TimeInterval could collapse, in very special cases, to a time point, however in this case, in contrast to the Abstract time point (referring to some time during the day), it should be bound to a specific date, i.e. to represent a timestamp.
    /// <see href="http://www.ontotext.com/proton/protontop#TimeInterval"></see></summary>
    let TimeInterval =
        Namespaced_IRI.parse _namespace_name "TimeInterval" |> NamespacedName

    /// <summary>
    /// Any sort of a topic or theme, explicitly defined for classification purposes. As long as any other class or entity can play the role of a topic, the instances of this class are only those concepts that are defined to serve as topics. The topic class is the natural top-class for linkage of logically informal taxonomies.
    /// <see href="http://www.ontotext.com/proton/protontop#Topic"></see></summary>
    let Topic = Namespaced_IRI.parse _namespace_name "Topic" |> NamespacedName
    /// <summary>
    /// Indicates that an Agent has full control over an object. This is typically the case of wholly-owned subsidiaries and physicall possession of goods.
    /// <see href="http://www.ontotext.com/proton/protontop#controls"></see></summary>
    let controls = Namespaced_IRI.parse _namespace_name "controls" |> NamespacedName

    /// <summary>
    /// Any sort of partial control an agent has with respect to an object.
    /// <see href="http://www.ontotext.com/proton/protontop#partiallyControls"></see></summary>
    let partiallyControls =
        Namespaced_IRI.parse _namespace_name "partiallyControls" |> NamespacedName

    /// <summary>
    /// A reference to a resource from which the present resource is derived. The present resource may be derived from the Source resource in whole or in part. Recommended best practice is to identify the referenced resource by means of a string or number conforming to a formal identification system. DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#derivedFromSource"></see></summary>
    let derivedFromSource =
        Namespaced_IRI.parse _namespace_name "derivedFromSource" |> NamespacedName

    /// <summary>
    /// A textual description of an entity. Usually a free text in some natural language. As defined in DC2003ISO for InformationResources. In a sense, it is a specializatoin of rdf:comment
    /// <see href="http://www.ontotext.com/proton/protontop#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// An abstract or summary of a document.
    /// <see href="http://www.ontotext.com/proton/protontop#documentAbstract"></see></summary>
    let documentAbstract =
        Namespaced_IRI.parse _namespace_name "documentAbstract" |> NamespacedName

    /// <summary>
    /// The creator (or one of the creators) of a document.
    /// <see href="http://www.ontotext.com/proton/protontop#documentAuthor"></see></summary>
    let documentAuthor =
        Namespaced_IRI.parse _namespace_name "documentAuthor" |> NamespacedName

    /// <summary>
    /// An agent primarily responsible for making the content of a resource. Examples of Creator include a person, an organization, or a service. Typically, the name of the Creator should be used to indicate the agent. (DC2003ISO, Creator)
    /// <see href="http://www.ontotext.com/proton/protontop#hasCreator"></see></summary>
    let hasCreator = Namespaced_IRI.parse _namespace_name "hasCreator" |> NamespacedName

    /// <summary>
    /// A very short sub-title of a document, usually a single sentence
    /// <see href="http://www.ontotext.com/proton/protontop#documentSubTitle"></see></summary>
    let documentSubTitle =
        Namespaced_IRI.parse _namespace_name "documentSubTitle" |> NamespacedName

    /// <summary>
    /// An extremely short (typically, single sentence) description of an entity
    /// <see href="http://www.ontotext.com/proton/protontop#laconicDescription"></see></summary>
    let laconicDescription =
        Namespaced_IRI.parse _namespace_name "laconicDescription" |> NamespacedName

    /// <summary>
    /// A name used for marketing purposes. Usually, it does not correspond to the legal name of the organisation.
    /// <see href="http://www.ontotext.com/proton/protontop#doingBusinessAs"></see></summary>
    let doingBusinessAs =
        Namespaced_IRI.parse _namespace_name "doingBusinessAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontotext.com/proton/protontop#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// the end time point of a happening
    /// <see href="http://www.ontotext.com/proton/protontop#endTime"></see></summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName

    /// <summary>
    /// The place where the organization is established or registered
    /// <see href="http://www.ontotext.com/proton/protontop#establishedIn"></see></summary>
    let establishedIn =
        Namespaced_IRI.parse _namespace_name "establishedIn" |> NamespacedName

    /// <summary>
    /// The relation between an object (also some happenings via their participants) and location where the object is.
    /// <see href="http://www.ontotext.com/proton/protontop#locatedIn"></see></summary>
    let locatedIn = Namespaced_IRI.parse _namespace_name "locatedIn" |> NamespacedName

    /// <summary>
    /// The date when the organization was established or registered
    /// <see href="http://www.ontotext.com/proton/protontop#establishmentDate"></see></summary>
    let establishmentDate =
        Namespaced_IRI.parse _namespace_name "establishmentDate" |> NamespacedName

    /// <summary>
    /// The relation between a person and his/her first name. Usually used to call the person.
    /// <see href="http://www.ontotext.com/proton/protontop#firstName"></see></summary>
    let firstName = Namespaced_IRI.parse _namespace_name "firstName" |> NamespacedName
    /// <summary>
    /// The relation between a person and his/her given name.
    /// <see href="http://www.ontotext.com/proton/protontop#givenName"></see></summary>
    let givenName = Namespaced_IRI.parse _namespace_name "givenName" |> NamespacedName
    /// <summary>
    /// The relation of a parent to his/her child.
    /// <see href="http://www.ontotext.com/proton/protontop#hasChild"></see></summary>
    let hasChild = Namespaced_IRI.parse _namespace_name "hasChild" |> NamespacedName

    /// <summary>
    /// Relation between a person and his/her relatives - mother, father, brother, sister, child, etc.
    /// <see href="http://www.ontotext.com/proton/protontop#hasRelative"></see></summary>
    let hasRelative =
        Namespaced_IRI.parse _namespace_name "hasRelative" |> NamespacedName

    /// <summary>
    /// The information by which a given object can be contacted. Usually an address, telefon number, e-mail address, etc.
    /// <see href="http://www.ontotext.com/proton/protontop#hasContactInfo"></see></summary>
    let hasContactInfo =
        Namespaced_IRI.parse _namespace_name "hasContactInfo" |> NamespacedName

    /// <summary>
    /// An agent responsible for making contributions to the content of a resource. Examples of Contributor include a person, an organization, or a service. DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#hasContributor"></see></summary>
    let hasContributor =
        Namespaced_IRI.parse _namespace_name "hasContributor" |> NamespacedName

    /// <summary>
    /// Typically, Date will be associated with the creation or availability of the resource. Recommended best practice for encoding the date value is defined in a profile of ISO 8601 [W3CDTF] and includes (among others) dates of the form YYYY-MM-DD. For official documents, it could be the date of signature. It can also contain a java timestamp. Usually, time is connected to a happening (event/situation) in which the information resource is a participation entity. These include: creation of the information resource, its modification or other important happening. Very often such happening is in the background knowledge and the modeling of domain task does not require the explicit representation of this happening. If it plays important role in the model domain or for the task, then the user needs to extend the ontology in an appropriate way.
    /// <see href="http://www.ontotext.com/proton/protontop#hasDate"></see></summary>
    let hasDate = Namespaced_IRI.parse _namespace_name "hasDate" |> NamespacedName

    /// <summary>
    /// Relates a particular organization to its employees.
    /// <see href="http://www.ontotext.com/proton/protontop#hasEmployee"></see></summary>
    let hasEmployee =
        Namespaced_IRI.parse _namespace_name "hasEmployee" |> NamespacedName

    /// <summary>
    /// Relates a particular organization to the agents that are its members. This predicate indicates `generic' membership, although there may be specialized kinds of membership in the same organization. Typically, membership eligibility is determined by the organization and accepted with the agent's voluntary affiliation. In many cases Persons that take Positions within Organization are considered members of the organization, although this is no way formally encoded here.
    /// <see href="http://www.ontotext.com/proton/protontop#hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// A general relation between an organization and a person who rules or guides or inspires it in some sense. It may or may not be an employee, may or may not be formal etc. Typically there is a single leader of an organization.
    /// <see href="http://www.ontotext.com/proton/protontop#hasLeader"></see></summary>
    let hasLeader = Namespaced_IRI.parse _namespace_name "hasLeader" |> NamespacedName
    /// <summary>
    /// Relates an entity to its old name or alias that is no longer considered legitimate. For instance, Pekin is one of the old spellings of the name of the Chineese capital Beijing. The same happens to companies when they change their names and to womam when she gets married.
    /// <see href="http://www.ontotext.com/proton/protontop#hasOldName"></see></summary>
    let hasOldName = Namespaced_IRI.parse _namespace_name "hasOldName" |> NamespacedName
    /// <summary>
    /// Relation between a person and his/her mother or father.
    /// <see href="http://www.ontotext.com/proton/protontop#hasParent"></see></summary>
    let hasParent = Namespaced_IRI.parse _namespace_name "hasParent" |> NamespacedName

    /// <summary>
    /// The relation between a happenning and the agent involved in it. Fequently, the participants play some roles in the happening, then the appriate roles have to be introduced.
    /// <see href="http://www.ontotext.com/proton/protontop#hasParticipant"></see></summary>
    let hasParticipant =
        Namespaced_IRI.parse _namespace_name "hasParticipant" |> NamespacedName

    /// <summary>
    /// The relation between a happening and an entity determining it. Such entities can be agents, instruments, materials, places, etc.
    /// <see href="http://www.ontotext.com/proton/protontop#hasParticipatingEntity"></see></summary>
    let hasParticipatingEntity =
        Namespaced_IRI.parse _namespace_name "hasParticipatingEntity" |> NamespacedName

    /// <summary>
    /// The participating entities in a given happening that are agents. Participation is usually via some role.
    /// <see href="http://www.ontotext.com/proton/protontop#involvedIn"></see></summary>
    let involvedIn = Namespaced_IRI.parse _namespace_name "involvedIn" |> NamespacedName

    /// <summary>
    /// The entities related to a given happening. Such entities can be agents, instruments, materials, places, etc.
    /// <see href="http://www.ontotext.com/proton/protontop#involvedEntityIn"></see></summary>
    let involvedEntityIn =
        Namespaced_IRI.parse _namespace_name "involvedEntityIn" |> NamespacedName

    /// <summary>
    /// Relation between a person and his/her job position.
    /// <see href="http://www.ontotext.com/proton/protontop#hasPosition"></see></summary>
    let hasPosition =
        Namespaced_IRI.parse _namespace_name "hasPosition" |> NamespacedName

    /// <summary>
    /// The person holding the position
    /// <see href="http://www.ontotext.com/proton/protontop#holder"></see></summary>
    let holder = Namespaced_IRI.parse _namespace_name "holder" |> NamespacedName
    /// <summary>
    /// Relation between a person and his/her siblings - brother or sister.
    /// <see href="http://www.ontotext.com/proton/protontop#hasSibling"></see></summary>
    let hasSibling = Namespaced_IRI.parse _namespace_name "hasSibling" |> NamespacedName

    /// <summary>
    /// The relation between a person and the social position he has.
    /// <see href="http://www.ontotext.com/proton/protontop#hasSocialPosition"></see></summary>
    let hasSocialPosition =
        Namespaced_IRI.parse _namespace_name "hasSocialPosition" |> NamespacedName

    /// <summary>
    /// The relation between a social position and the person who has it.
    /// <see href="http://www.ontotext.com/proton/protontop#socialPositionHolder"></see></summary>
    let socialPositionHolder =
        Namespaced_IRI.parse _namespace_name "socialPositionHolder" |> NamespacedName

    /// <summary>
    /// Relation between a man and a woman that are married. This property is time constrained by the marriage happening for the two persons. Thus, one could have different spouses in different periods. If this time relation is important for a given domain, it needs to be modelled by the marriage happening.
    /// <see href="http://www.ontotext.com/proton/protontop#hasSpouse"></see></summary>
    let hasSpouse = Namespaced_IRI.parse _namespace_name "hasSpouse" |> NamespacedName
    /// <summary>
    /// The topic of content of a given resource. Comment: Typically, the Subject will be expressed as keywords, key phrases, or classification codes that describe the topic of resource. Recommended best practice is to select a value from a controlled vocabulary or formal classification scheme. (DC2003ISO, Subject)
    /// <see href="http://www.ontotext.com/proton/protontop#hasSubject"></see></summary>
    let hasSubject = Namespaced_IRI.parse _namespace_name "hasSubject" |> NamespacedName

    /// <summary>
    /// Makes possible the modelling of a specific, but rather useful modelling pattern. The semantics is defined with the following axiom: (p,transitiveOver,q) (x,p,y) (y,q,z) =&gt; (x,p,z). Sample usage is: (locatedIn, transitiveOver, subRegionOf) (Ontotext,locatedIn,Bulgaria) (Bulgaria,subRegionOf,Europe) =&gt; (Ontotext,locatedIn,Europe). The intended domain and range of this property are owl:ObjectProperty; those are not formally specified, in order not to get the ontology outside the OWL DL segment.
    /// <see href="http://www.ontotext.com/proton/protontop#transitiveOver"></see></summary>
    let transitiveOver =
        Namespaced_IRI.parse _namespace_name "transitiveOver" |> NamespacedName

    /// <summary>
    /// A relation from less general to more general topic. Defined to be transitive via rule.
    /// <see href="http://www.ontotext.com/proton/protontop#subTopicOf"></see></summary>
    let subTopicOf = Namespaced_IRI.parse _namespace_name "subTopicOf" |> NamespacedName
    /// <summary>
    /// When the holder occupied a given position
    /// <see href="http://www.ontotext.com/proton/protontop#heldFrom"></see></summary>
    let heldFrom = Namespaced_IRI.parse _namespace_name "heldFrom" |> NamespacedName
    /// <summary>
    /// the starting moment of a happening
    /// <see href="http://www.ontotext.com/proton/protontop#startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName
    /// <summary>
    /// When the holder released a given position
    /// <see href="http://www.ontotext.com/proton/protontop#heldTo"></see></summary>
    let heldTo = Namespaced_IRI.parse _namespace_name "heldTo" |> NamespacedName
    /// <summary>
    /// The language of the intellectual content of a resource. Recommended best practice is to use RFC 3066 [RFC3066], which, in conjunction with ISO 639 [ISO639], defines two- and three-letter primary language tags with optional subtags. Examples include “en” or “eng” for English, “akk” for Akkadian, and “en-GB” for English used in the United Kingdom. DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#inLanguage"></see></summary>
    let inLanguage = Namespaced_IRI.parse _namespace_name "inLanguage" |> NamespacedName

    /// <summary>
    /// The extent or scope of resource content. Typically, Coverage will include spatial location (a place name or geographic coordinates), temporal period (a period label, date, or date range), or jurisdiction (such as a named administrative entity). Recommended best practice is to select a value from a controlled vocabulary (for example, the Thesaurus of Geographic Names [TGN]) and to use, where appropriate, named places or time periods in preference to numeric identifiers such as sets of coordinates or date ranges. DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#informationResourceCoverage"></see></summary>
    let informationResourceCoverage =
        Namespaced_IRI.parse _namespace_name "informationResourceCoverage" |> NamespacedName

    /// <summary>
    /// An unambiguous reference to the information resource within a given context. Recommended best practice is to identify the resource by means of a string or number conforming to a formal identification system. Formal identification systems include but are not limited to the Uniform Resource Identifier (URI) (including the Uniform Resource Locator (URL)), the Digital Object Identifier (DOI), and the International Standard Book Number (ISBN). DC2003ISO.
    /// <see href="http://www.ontotext.com/proton/protontop#informationResourceIdentifier"></see></summary>
    let informationResourceIdentifier =
        Namespaced_IRI.parse _namespace_name "informationResourceIdentifier" |> NamespacedName

    /// <summary>
    /// Information about rights held in and over the resource. Typically, Rights will contain a rights management statement for the resource, or reference to a service providing such information. Rights information often encompasses Intellectual Property Rights (IPR), Copyright, and various Property Rights. If the Rights element is absent, no assumptions should be made about any rights held in or over the resource. DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#informationResourceRights"></see></summary>
    let informationResourceRights =
        Namespaced_IRI.parse _namespace_name "informationResourceRights" |> NamespacedName

    /// <summary>
    /// Relates a Person to another one, where the first is the immediate boss or supervisor of the latter. This is a many-to-many relationship, i.e. there can be more than one boss of a person, even contemporally.
    /// <see href="http://www.ontotext.com/proton/protontop#isBossOf"></see></summary>
    let isBossOf = Namespaced_IRI.parse _namespace_name "isBossOf" |> NamespacedName

    /// <summary>
    /// Determines whether a particular Agent is a legal entity. The range should be constrained to Boolean. Agents, for which the value is True, correspond to instances of http://www.cyc.com/2003/04/01/cyc#LegalAgent, which is defined as follows "Each instance of #LegalAgent is an agent who has some status in a particular legal system. At the very least, such an agent is recognized by some legal authority as having some kinds of rights and/or responsibilities as an agent (e.g., #citizens of Germany), ... ". In PROTON, it is modeled as property in order to avoid multiple-inheritance of classes and/or multiple classifications of instances.
    /// <see href="http://www.ontotext.com/proton/protontop#isLegalEntity"></see></summary>
    let isLegalEntity =
        Namespaced_IRI.parse _namespace_name "isLegalEntity" |> NamespacedName

    /// <summary>
    /// The relation between an object and an agent that is the owner of that object.
    /// <see href="http://www.ontotext.com/proton/protontop#isOwnedBy"></see></summary>
    let isOwnedBy = Namespaced_IRI.parse _namespace_name "isOwnedBy" |> NamespacedName
    /// <summary>
    /// The relation between a person and his/her last name. Usually the family name.
    /// <see href="http://www.ontotext.com/proton/protontop#lastName"></see></summary>
    let lastName = Namespaced_IRI.parse _namespace_name "lastName" |> NamespacedName
    /// <summary>
    /// In degrees, minutes, and seconds: no sign or (+) = North; negative sign (-) = South.
    /// <see href="http://www.ontotext.com/proton/protontop#latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    /// In degrees, minutes, and seconds: no sign or (+) = East; negative sign (-) = West.
    /// <see href="http://www.ontotext.com/proton/protontop#longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName
    /// <summary>
    /// This is a label of an entity which is consider to be representative for it. In cases when the entity is presented to someone, usually, this label will be used. In a sense, it is a specializatoin of rdfs:label
    /// <see href="http://www.ontotext.com/proton/protontop#mainLabel"></see></summary>
    let mainLabel = Namespaced_IRI.parse _namespace_name "mainLabel" |> NamespacedName

    /// <summary>
    /// The designator of the entity according to the NIMA GeoNames Server.
    /// <see href="http://www.ontotext.com/proton/protontop#nimaGNSDesignator"></see></summary>
    let nimaGNSDesignator =
        Namespaced_IRI.parse _namespace_name "nimaGNSDesignator" |> NamespacedName

    /// <summary>
    /// The Unique Feature Identifier from the NIMA GNS. A number which uniquely identifies the location.
    /// <see href="http://www.ontotext.com/proton/protontop#nimaGNSUniqueFeatureIndentifier"></see></summary>
    let nimaGNSUniqueFeatureIndentifier =
        Namespaced_IRI.parse _namespace_name "nimaGNSUniqueFeatureIndentifier" |> NamespacedName

    /// <summary>
    /// The estimated number of employees in the organization.
    /// <see href="http://www.ontotext.com/proton/protontop#numberOfEmployees"></see></summary>
    let numberOfEmployees =
        Namespaced_IRI.parse _namespace_name "numberOfEmployees" |> NamespacedName

    /// <summary>
    /// A relation between a service and the agent (usually organisation), who provides it
    /// <see href="http://www.ontotext.com/proton/protontop#operatedBy"></see></summary>
    let operatedBy = Namespaced_IRI.parse _namespace_name "operatedBy" |> NamespacedName
    /// <summary>
    /// An agent fully owns an Object. In many cases this means also full control, unless the agent has transferred the control to another agent.
    /// <see href="http://www.ontotext.com/proton/protontop#owns"></see></summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName

    /// <summary>
    /// Indicates that an Agent has some ownership over an object. It allows wide interpretations from "I have a bike" to "John has shares in Fujitsu".
    /// <see href="http://www.ontotext.com/proton/protontop#partiallyOwns"></see></summary>
    let partiallyOwns =
        Namespaced_IRI.parse _namespace_name "partiallyOwns" |> NamespacedName

    /// <summary>
    /// A relation between two organizations, where one of them is dependent on the other in some sense. This is a transitive relation, i.e. if organization X is a parent organization of Y and the latter is a parent organization of Z, then X is also considered a parent organization of Z. Inverse of subsidiaryOrganizationOf.
    /// <see href="http://www.ontotext.com/proton/protontop#parentOrganizationOf"></see></summary>
    let parentOrganizationOf =
        Namespaced_IRI.parse _namespace_name "parentOrganizationOf" |> NamespacedName

    /// <summary>
    /// Indicates that an organization is in some sense part of another organization. This necessarily requires structural and organizational relations and may or may not indicate ownership. Its reverse, parentOrganizationOf, is a special case of partial control.
    /// <see href="http://www.ontotext.com/proton/protontop#subsidiaryOrganizationOf"></see></summary>
    let subsidiaryOrganizationOf =
        Namespaced_IRI.parse _namespace_name "subsidiaryOrganizationOf" |> NamespacedName

    /// <summary>
    /// The general part-of relation which takes place between a whole and each of its parts. It has a number of specializations.
    /// <see href="http://www.ontotext.com/proton/protontop#partOf"></see></summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    /// The number of citizens of a location.
    /// <see href="http://www.ontotext.com/proton/protontop#populationCount"></see></summary>
    let populationCount =
        Namespaced_IRI.parse _namespace_name "populationCount" |> NamespacedName

    /// <summary>
    /// A relation between a company and its ProductModel
    /// <see href="http://www.ontotext.com/proton/protontop#producedBy"></see></summary>
    let producedBy = Namespaced_IRI.parse _namespace_name "producedBy" |> NamespacedName

    /// <summary>
    /// A relation between an organization and the location in which it is registered.
    /// <see href="http://www.ontotext.com/proton/protontop#registeredIn"></see></summary>
    let registeredIn =
        Namespaced_IRI.parse _namespace_name "registeredIn" |> NamespacedName

    /// <summary>
    /// The physical or digital manifestation of the resource. Typically, Format will include the media-type or dimensions of the resource. Format may be used to identify the software, hardware, or other equipment needed to display or operate the resource. Examples of dimensions include size and duration. Recommended best practice is to select a value from a controlled vocabulary (for example, the list of Internet Media Types [MIME] defining computer media formats). DC2003ISO
    /// <see href="http://www.ontotext.com/proton/protontop#resourceFormat"></see></summary>
    let resourceFormat =
        Namespaced_IRI.parse _namespace_name "resourceFormat" |> NamespacedName

    /// <summary>
    /// The nature or genre of the content of the resource. Type includes terms describing general categories, functions, genres, or aggregation levels for content. Recommended best practice is to select a value from a controlled vocabulary (for example, the DCMI Type Vocabulary [DCT]). To describe the physical or digital manifestation of the resource, use the resourceFormat property. DC2003ISO.
    /// <see href="http://www.ontotext.com/proton/protontop#resourceType"></see></summary>
    let resourceType =
        Namespaced_IRI.parse _namespace_name "resourceType" |> NamespacedName

    /// <summary>
    /// The relation between a role and the entity that 'plays' a role in a given happening.
    /// <see href="http://www.ontotext.com/proton/protontop#roleHolder"></see></summary>
    let roleHolder = Namespaced_IRI.parse _namespace_name "roleHolder" |> NamespacedName
    /// <summary>
    /// Relates a role to a happening, conditioned and affected by the role. Usually, the participants of a happening 'play' one or more roles in it.
    /// <see href="http://www.ontotext.com/proton/protontop#roleIn"></see></summary>
    let roleIn = Namespaced_IRI.parse _namespace_name "roleIn" |> NamespacedName
    /// <summary>
    /// Relates a statement to the agent who made it. In the case of an offer, the agent is the offerer; in case of a contract, those are the parties. In case of written statements, the creator/author and the "stater" could be different agents, due to the fact that one agent my have prepared and/or published a statement on behalf of another.
    /// <see href="http://www.ontotext.com/proton/protontop#statedBy"></see></summary>
    let statedBy = Namespaced_IRI.parse _namespace_name "statedBy" |> NamespacedName

    /// <summary>
    /// Relation between two locations where the first is contained within the other.
    /// <see href="http://www.ontotext.com/proton/protontop#subRegionOf"></see></summary>
    let subRegionOf =
        Namespaced_IRI.parse _namespace_name "subRegionOf" |> NamespacedName

    /// <summary>
    /// The system classes and properties are used to encode system specific information. They, as well as their instances and related information, should usually not be presented to the end-user. In practice, user-interface and visualization modules, can filter such primitives. All system primitives with this property should be marked with string value "T".
    /// <see href="http://www.ontotext.com/proton/protontop#systemPrimitive"></see></summary>
    let systemPrimitive =
        Namespaced_IRI.parse _namespace_name "systemPrimitive" |> NamespacedName

    /// <summary>
    /// A name given to an information resource. Typically, title will be a name by which the resource is formally known. (DC2003ISO, Title there)
    /// <see href="http://www.ontotext.com/proton/protontop#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// The time when a statement is made valid. The happing of making the statement valid is not explicitly represented in Proton. If it is necessary for the task the ontology needs to be extented.
    /// <see href="http://www.ontotext.com/proton/protontop#validFrom"></see></summary>
    let validFrom = Namespaced_IRI.parse _namespace_name "validFrom" |> NamespacedName
    /// <summary>
    /// The time when a statement is made invalid. The happening of making the statement invalid is not explicitly represented in Proton. If it is necessary for the task the ontology should be extented.
    /// <see href="http://www.ontotext.com/proton/protontop#validUntil"></see></summary>
    let validUntil = Namespaced_IRI.parse _namespace_name "validUntil" |> NamespacedName

    /// <summary>
    /// Determines in which organization is the position
    /// <see href="http://www.ontotext.com/proton/protontop#withinOrganization"></see></summary>
    let withinOrganization =
        Namespaced_IRI.parse _namespace_name "withinOrganization" |> NamespacedName
