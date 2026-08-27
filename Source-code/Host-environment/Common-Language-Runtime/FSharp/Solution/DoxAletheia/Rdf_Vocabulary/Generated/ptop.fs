namespace http.www.ontotext.com.proton.protontop.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ptop =
    let _namespace_iri = Namespace_Iri ptop |> NamespaceIRI
    /// <summary>
    ///   <para>onto:proton/protontop#Abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Something, which neither happens nor exists, e.g. a number or a chemical compound formula. Those are usually some symbols, invented to refer to general notions."</para>
    /// labels<para>"Abstract"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Abstract">http://www.ontotext.com/proton/protontop#Abstract</seealso>
    let Abstract = Prefixed_Name(ptop, "Abstract") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Agent is something, which can show (carry out) an independent action, whether consciously or not. Most animals are considered agents, in most contexts; so are most organizations. According to DOLCE 2.0 "objects to which we ascribe intentions, beliefs and desires". In PROTON, Agent also denotes any automatic device and service, including web services and servers."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Agent">http://www.ontotext.com/proton/protontop#Agent</seealso>
    let Agent = Prefixed_Name(ptop, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#ContactInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any instance of a particular notation, used to make the contact with an individual, an organization, or any other object possible."</para>
    /// labels<para>"Contact Information"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#ContactInformation">http://www.ontotext.com/proton/protontop#ContactInformation</seealso>
    let ContactInformation = Prefixed_Name(ptop, "ContactInformation") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The information content of any sort of document. The tangible aspects are ignored. It is usually a document in free text with no formal structure or semantics."</para>
    /// labels<para>"Document"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Document">http://www.ontotext.com/proton/protontop#Document</seealso>
    let Document = Prefixed_Name(ptop, "Document") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sort of an entity of interest, usually something existing, happening, or purely abstract. Entities may have several - more than one - names or aliases."</para>
    /// labels<para>"Entity"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Entity">http://www.ontotext.com/proton/protontop#Entity</seealso>
    let Entity = Prefixed_Name(ptop, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dynamic event, such as "running" or "a concert"."</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Event">http://www.ontotext.com/proton/protontop#Event</seealso>
    let Event = Prefixed_Name(ptop, "Event") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#GeneralTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"General concept with well defined (idiomatic) meaning which can have a set of distinct lexical items (surface realizations) associated with it. Examples are: F2F, I18N, P2P, B2B, VIP, ASAP, Semantic Web"</para>
    /// labels<para>"General Term"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#GeneralTerm">http://www.ontotext.com/proton/protontop#GeneralTerm</seealso>
    let GeneralTerm = Prefixed_Name(ptop, "GeneralTerm") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of agents that is not organized in any way. It could be the group of people in a bus or the shareholders of a company."</para>
    /// labels<para>"Group"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Group">http://www.ontotext.com/proton/protontop#Group</seealso>
    let Group = Prefixed_Name(ptop, "Group") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Happening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Something that happens. It can be either dynamic - like in "drawing a circle", or static - like in "being a president". In all cases, a happening (an event, a situation, or a time period) has a certain (usually quite concrete) temporal positioning - in the simplest case it is the one, denoted by start and end point in time."</para>
    /// labels<para>"Happening"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Happening">http://www.ontotext.com/proton/protontop#Happening</seealso>
    let Happening = Prefixed_Name(ptop, "Happening") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#InformationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InformationResource denotes an information resource with identity, as defined in Dublin Core (DC2003ISO). InformationResource is considered any communication or message that is delivered or produced, taking into account the specific intention of its originator, and also the supposition (and anticipation) for a particular audience or counter-agent in the process of communication (i.e. passive or active feed-back)."</para>
    /// labels<para>"Information Resource"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#InformationResource">http://www.ontotext.com/proton/protontop#InformationResource</seealso>
    let InformationResource = Prefixed_Name(ptop, "InformationResource") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#JobPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The situation of a person, holding a job (employment) position within an organization. The sub-classes of this class define a number of different types of positions."</para>
    /// labels<para>"Job Position"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#JobPosition">http://www.ontotext.com/proton/protontop#JobPosition</seealso>
    let JobPosition = Prefixed_Name(ptop, "JobPosition") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A spoken or written natural language"</para>
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Language">http://www.ontotext.com/proton/protontop#Language</seealso>
    let Language = Prefixed_Name(ptop, "Language") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Usually a geographic location on the earth, however any sort of 3D regions also fit here. The classification is based on the ADL Feature Type Thesaurus version 070203. Additionally, classes from Geonames classification are included. For each specific type, the corresponding NIMA GNS designators (DSG) are given."</para>
    /// labels<para>"Location"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Location">http://www.ontotext.com/proton/protontop#Location</seealso>
    let Location = Prefixed_Name(ptop, "Location") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any given number, within the meaning that a number is one of the following: a concept of quantity derived from zero and units; or a numeral (or a string of numerals) used for identification ("she refused to give them her Social Security number"); or a phone number, etc."</para>
    /// labels<para>"Number"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Number">http://www.ontotext.com/proton/protontop#Number</seealso>
    let Number = Prefixed_Name(ptop, "Number") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Objects are entities that could be claimed to exist - in some sense of existence. An object can play a certain role in some happenings. Objects could be substantially real - as the Buckingham Palace or a hardcopy book - or substantially imperceptible - for instance, an electronic document that exists only virtually, one cannot touch it."</para>
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Object">http://www.ontotext.com/proton/protontop#Object</seealso>
    let Object = Prefixed_Name(ptop, "Object") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Organization is a group, which is established in such a way that certain known relationships and obligations exist between the members, and/or between the organization and its members, and/or between the organization and the public (individuals or groups). It includes both informal and legally constituted organizations. Organizations can act as agents - to undertake projects, to enter into agreements, to own properties, etc. Most organizations have names. Almost all of them have at least two members."</para>
    /// labels<para>"Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Organization">http://www.ontotext.com/proton/protontop#Organization</seealso>
    let Organization = Prefixed_Name(ptop, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Person is an agent, which is an individual who is a human being (i.e. any living or not alive member of the family Hominidae). Wordnet 2.0."</para>
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Person">http://www.ontotext.com/proton/protontop#Person</seealso>
    let Person = Prefixed_Name(ptop, "Person") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#ProductModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The general concept of a product model, for example, Ford T. The instances of this class are not specific instances of the product - the latter are just instances. Although product models are rather abstract entities (generally, intangible), this class is defined as a sub-class of Object, because it has a strong temporal extent (it comes to exsitence at some point of time). There could be several information resources associated with a product model (e.g. specifications, brouchures, etc.), but it is not an information resource on its own."</para>
    /// labels<para>"Product Model"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#ProductModel">http://www.ontotext.com/proton/protontop#ProductModel</seealso>
    let ProductModel = Prefixed_Name(ptop, "ProductModel") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#PropChainRestr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#PropChainRestr">http://www.ontotext.com/proton/protontop#PropChainRestr</seealso>
    let PropChainRestr = Prefixed_Name(ptop, "PropChainRestr") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#PropChainType2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#PropChainType2">http://www.ontotext.com/proton/protontop#PropChainType2</seealso>
    let PropChainType2 = Prefixed_Name(ptop, "PropChainType2") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#PropRestr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#PropRestr">http://www.ontotext.com/proton/protontop#PropRestr</seealso>
    let PropRestr = Prefixed_Name(ptop, "PropRestr") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The role of an entity (usually an agent) within/during/affecting (intentionally or not) a particular happening. For instance a project coordinator, or a trial defendant, or even a material object that serves as an evidence in a trial (e.g. a weapon). Usually, we say 'this object is in this role in this happening'."</para>
    /// labels<para>"Role"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Role">http://www.ontotext.com/proton/protontop#Role</seealso>
    let Role = Prefixed_Name(ptop, "Role") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sort of service, ranging from a scheduled flight or train services to a weather forecast information/web serivce. Many services could be considered agents (usually software services)."</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Service">http://www.ontotext.com/proton/protontop#Service</seealso>
    let Service = Prefixed_Name(ptop, "Service") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A static event or situation, like "sitting on a chair" or "holding position". Typically, those are temporarily homogenous, i.e. their nature is not expected/required to change with their duration. As a happening, they used to happen/take place/be true for some periods of time and may or may not have a well-defined space extension."</para>
    /// labels<para>"Situation"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Situation">http://www.ontotext.com/proton/protontop#Situation</seealso>
    let Situation = Prefixed_Name(ptop, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#SocialPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The situation of a person, having a social position like celebrity, nobelty, job position, cleric, out of laws. The sub-classes of this class define different social statuses."</para>
    /// labels<para>"Social Position"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#SocialPosition">http://www.ontotext.com/proton/protontop#SocialPosition</seealso>
    let SocialPosition = Prefixed_Name(ptop, "SocialPosition") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A message that is stated or declared; a communication (oral or written), setting forth particulars or facts, etc; "according to his statement he was in London on that day". WordNet 1.7.1"</para>
    /// labels<para>"Statement"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Statement">http://www.ontotext.com/proton/protontop#Statement</seealso>
    let Statement = Prefixed_Name(ptop, "Statement") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a general time expression, which refers to a particular period of time, an interval. Repeating periods (like Spring or Christmas) are not time intervals, while specific instances of them (like the Spring of 1944) are. A TimeInterval could collapse, in very special cases, to a time point, however in this case, in contrast to the Abstract time point (referring to some time during the day), it should be bound to a specific date, i.e. to represent a timestamp."</para>
    /// labels<para>"Time Interval"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#TimeInterval">http://www.ontotext.com/proton/protontop#TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(ptop, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sort of a topic or theme, explicitly defined for classification purposes. As long as any other class or entity can play the role of a topic, the instances of this class are only those concepts that are defined to serve as topics. The topic class is the natural top-class for linkage of logically informal taxonomies."</para>
    /// labels<para>"Topic"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#Topic">http://www.ontotext.com/proton/protontop#Topic</seealso>
    let Topic = Prefixed_Name(ptop, "Topic") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#TypeRestr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#TypeRestr">http://www.ontotext.com/proton/protontop#TypeRestr</seealso>
    let TypeRestr = Prefixed_Name(ptop, "TypeRestr") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#conclusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#conclusion">http://www.ontotext.com/proton/protontop#conclusion</seealso>
    let conclusion = Prefixed_Name(ptop, "conclusion") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#controls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an Agent has full control over an object. This is typically the case of wholly-owned subsidiaries and physicall possession of goods."</para>
    /// labels<para>"Controls"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#controls">http://www.ontotext.com/proton/protontop#controls</seealso>
    let controls = Prefixed_Name(ptop, "controls") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#derivedFromSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A reference to a resource from which the present resource is derived. The present resource may be derived from the Source resource in whole or in part. Recommended best practice is to identify the referenced resource by means of a string or number conforming to a formal identification system. DC2003ISO"</para>
    /// labels<para>"Derived from Source"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#derivedFromSource">http://www.ontotext.com/proton/protontop#derivedFromSource</seealso>
    let derivedFromSource = Prefixed_Name(ptop, "derivedFromSource") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A textual description of an entity. Usually a free text in some natural language. As defined in DC2003ISO for InformationResources. In a sense, it is a specializatoin of rdf:comment"</para>
    /// labels<para>"Description"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#description">http://www.ontotext.com/proton/protontop#description</seealso>
    let description = Prefixed_Name(ptop, "description") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#documentAbstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An abstract or summary of a document."</para>
    /// labels<para>"Document Abstract"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#documentAbstract">http://www.ontotext.com/proton/protontop#documentAbstract</seealso>
    let documentAbstract = Prefixed_Name(ptop, "documentAbstract") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#documentAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The creator (or one of the creators) of a document."</para>
    /// labels<para>"Document Author"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#documentAuthor">http://www.ontotext.com/proton/protontop#documentAuthor</seealso>
    let documentAuthor = Prefixed_Name(ptop, "documentAuthor") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#documentSubTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A very short sub-title of a document, usually a single sentence"</para>
    /// labels<para>"Document Subtitle"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#documentSubTitle">http://www.ontotext.com/proton/protontop#documentSubTitle</seealso>
    let documentSubTitle = Prefixed_Name(ptop, "documentSubTitle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#doingBusinessAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A name used for marketing purposes. Usually, it does not correspond to the legal name of the organisation."</para>
    /// labels<para>"Doing Business as"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#doingBusinessAs">http://www.ontotext.com/proton/protontop#doingBusinessAs</seealso>
    let doingBusinessAs = Prefixed_Name(ptop, "doingBusinessAs") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the end time point of a happening"</para>
    /// labels<para>"End Time"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#endTime">http://www.ontotext.com/proton/protontop#endTime</seealso>
    let endTime = Prefixed_Name(ptop, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#establishedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The place where the organization is established or registered"</para>
    /// labels<para>"Established in"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#establishedIn">http://www.ontotext.com/proton/protontop#establishedIn</seealso>
    let establishedIn = Prefixed_Name(ptop, "establishedIn") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#establishmentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date when the organization was established or registered"</para>
    /// labels<para>"Establishment Date"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#establishmentDate">http://www.ontotext.com/proton/protontop#establishmentDate</seealso>
    let establishmentDate = Prefixed_Name(ptop, "establishmentDate") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#firstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The relation between a person and his/her first name. Usually used to call the person."</para>
    /// labels<para>"First Name"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#firstName">http://www.ontotext.com/proton/protontop#firstName</seealso>
    let firstName = Prefixed_Name(ptop, "firstName") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#givenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The relation between a person and his/her given name."</para>
    /// labels<para>"Given Name"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#givenName">http://www.ontotext.com/proton/protontop#givenName</seealso>
    let givenName = Prefixed_Name(ptop, "givenName") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation of a parent to his/her child."</para>
    /// labels<para>"has Child"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasChild">http://www.ontotext.com/proton/protontop#hasChild</seealso>
    let hasChild = Prefixed_Name(ptop, "hasChild") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasContactInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The information by which a given object can be contacted. Usually an address, telefon number, e-mail address, etc."</para>
    /// labels<para>"has Contact Info"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasContactInfo">http://www.ontotext.com/proton/protontop#hasContactInfo</seealso>
    let hasContactInfo = Prefixed_Name(ptop, "hasContactInfo") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasContributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An agent responsible for making contributions to the content of a resource. Examples of Contributor include a person, an organization, or a service. DC2003ISO"</para>
    /// labels<para>"has Contributor"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasContributor">http://www.ontotext.com/proton/protontop#hasContributor</seealso>
    let hasContributor = Prefixed_Name(ptop, "hasContributor") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An agent primarily responsible for making the content of a resource. Examples of Creator include a person, an organization, or a service. Typically, the name of the Creator should be used to indicate the agent. (DC2003ISO, Creator)"</para>
    /// labels<para>"has Creator"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasCreator">http://www.ontotext.com/proton/protontop#hasCreator</seealso>
    let hasCreator = Prefixed_Name(ptop, "hasCreator") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Typically, Date will be associated with the creation or availability of the resource. Recommended best practice for encoding the date value is defined in a profile of ISO 8601 [W3CDTF] and includes (among others) dates of the form YYYY-MM-DD. For official documents, it could be the date of signature. It can also contain a java timestamp. Usually, time is connected to a happening (event/situation) in which the information resource is a participation entity. These include: creation of the information resource, its modification or other important happening. Very often such happening is in the background knowledge and the modeling of domain task does not require the explicit representation of this happening. If it plays important role in the model domain or for the task, then the user needs to extend the ontology in an appropriate way."</para>
    /// labels<para>"has Date"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasDate">http://www.ontotext.com/proton/protontop#hasDate</seealso>
    let hasDate = Prefixed_Name(ptop, "hasDate") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasEmployee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a particular organization to its employees."</para>
    /// labels<para>"has Employee"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasEmployee">http://www.ontotext.com/proton/protontop#hasEmployee</seealso>
    let hasEmployee = Prefixed_Name(ptop, "hasEmployee") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A general relation between an organization and a person who rules or guides or inspires it in some sense. It may or may not be an employee, may or may not be formal etc. Typically there is a single leader of an organization."</para>
    /// labels<para>"has Leader"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasLeader">http://www.ontotext.com/proton/protontop#hasLeader</seealso>
    let hasLeader = Prefixed_Name(ptop, "hasLeader") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a particular organization to the agents that are its members. This predicate indicates `generic' membership, although there may be specialized kinds of membership in the same organization. Typically, membership eligibility is determined by the organization and accepted with the agent's voluntary affiliation. In many cases Persons that take Positions within Organization are considered members of the organization, although this is no way formally encoded here."</para>
    /// labels<para>"has Member"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasMember">http://www.ontotext.com/proton/protontop#hasMember</seealso>
    let hasMember = Prefixed_Name(ptop, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasOldName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Relates an entity to its old name or alias that is no longer considered legitimate. For instance, Pekin is one of the old spellings of the name of the Chineese capital Beijing. The same happens to companies when they change their names and to womam when she gets married."</para>
    /// labels<para>"has Old Name"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasOldName">http://www.ontotext.com/proton/protontop#hasOldName</seealso>
    let hasOldName = Prefixed_Name(ptop, "hasOldName") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a person and his/her mother or father."</para>
    /// labels<para>"has Parent"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasParent">http://www.ontotext.com/proton/protontop#hasParent</seealso>
    let hasParent = Prefixed_Name(ptop, "hasParent") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a happenning and the agent involved in it. Fequently, the participants play some roles in the happening, then the appriate roles have to be introduced."</para>
    /// labels<para>"Participant in a Happening"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasParticipant">http://www.ontotext.com/proton/protontop#hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(ptop, "hasParticipant") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#hasParticipatingEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a happening and an entity determining it. Such entities can be agents, instruments, materials, places, etc."</para>
    /// labels<para>"Entity Participating in a Happening"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasParticipatingEntity">http://www.ontotext.com/proton/protontop#hasParticipatingEntity</seealso>
    let hasParticipatingEntity =
        Prefixed_Name(ptop, "hasParticipatingEntity") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#hasPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a person and his/her job position."</para>
    /// labels<para>"has Position"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasPosition">http://www.ontotext.com/proton/protontop#hasPosition</seealso>
    let hasPosition = Prefixed_Name(ptop, "hasPosition") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasRelative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Relation between a person and his/her relatives - mother, father, brother, sister, child, etc."</para>
    /// labels<para>"has Relative"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasRelative">http://www.ontotext.com/proton/protontop#hasRelative</seealso>
    let hasRelative = Prefixed_Name(ptop, "hasRelative") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasSibling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a person and his/her siblings - brother or sister."</para>
    /// labels<para>"has Sibling"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasSibling">http://www.ontotext.com/proton/protontop#hasSibling</seealso>
    let hasSibling = Prefixed_Name(ptop, "hasSibling") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasSocialPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a person and the social position he has. "</para>
    /// labels<para>"has Social Position"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasSocialPosition">http://www.ontotext.com/proton/protontop#hasSocialPosition</seealso>
    let hasSocialPosition = Prefixed_Name(ptop, "hasSocialPosition") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasSpouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a man and a woman that are married. This property is time constrained by the marriage happening for the two persons. Thus, one could have different spouses in different periods. If this time relation is important for a given domain, it needs to be modelled by the marriage happening."</para>
    /// labels<para>"has Spouse"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasSpouse">http://www.ontotext.com/proton/protontop#hasSpouse</seealso>
    let hasSpouse = Prefixed_Name(ptop, "hasSpouse") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#hasSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The topic of content of a given resource. Comment: Typically, the Subject will be expressed as keywords, key phrases, or classification codes that describe the topic of resource. Recommended best practice is to select a value from a controlled vocabulary or formal classification scheme. (DC2003ISO, Subject)"</para>
    /// labels<para>"has Subject"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#hasSubject">http://www.ontotext.com/proton/protontop#hasSubject</seealso>
    let hasSubject = Prefixed_Name(ptop, "hasSubject") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#heldFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"When the holder occupied a given position"</para>
    /// labels<para>"Held from"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#heldFrom">http://www.ontotext.com/proton/protontop#heldFrom</seealso>
    let heldFrom = Prefixed_Name(ptop, "heldFrom") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#heldTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"When the holder released a given position"</para>
    /// labels<para>"Held to"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#heldTo">http://www.ontotext.com/proton/protontop#heldTo</seealso>
    let heldTo = Prefixed_Name(ptop, "heldTo") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#holder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The person holding the position"</para>
    /// labels<para>"Holder"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#holder">http://www.ontotext.com/proton/protontop#holder</seealso>
    let holder = Prefixed_Name(ptop, "holder") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#inLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The language of the intellectual content of a resource. Recommended best practice is to use RFC 3066 [RFC3066], which, in conjunction with ISO 639 [ISO639], defines two- and three-letter primary language tags with optional subtags. Examples include “en” or “eng” for English, “akk” for Akkadian, and “en-GB” for English used in the United Kingdom. DC2003ISO"</para>
    /// labels<para>"in Language"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#inLanguage">http://www.ontotext.com/proton/protontop#inLanguage</seealso>
    let inLanguage = Prefixed_Name(ptop, "inLanguage") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#informationResourceCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The extent or scope of resource content. Typically, Coverage will include spatial location (a place name or geographic coordinates), temporal period (a period label, date, or date range), or jurisdiction (such as a named administrative entity). Recommended best practice is to select a value from a controlled vocabulary (for example, the Thesaurus of Geographic Names [TGN]) and to use, where appropriate, named places or time periods in preference to numeric identifiers such as sets of coordinates or date ranges. DC2003ISO"</para>
    /// labels<para>"Information Resource Coverage"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#informationResourceCoverage">http://www.ontotext.com/proton/protontop#informationResourceCoverage</seealso>
    let informationResourceCoverage =
        Prefixed_Name(ptop, "informationResourceCoverage") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#informationResourceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An unambiguous reference to the information resource within a given context. Recommended best practice is to identify the resource by means of a string or number conforming to a formal identification system. Formal identification systems include but are not limited to the Uniform Resource Identifier (URI) (including the Uniform Resource Locator (URL)), the Digital Object Identifier (DOI), and the International Standard Book Number (ISBN). DC2003ISO."</para>
    /// labels<para>"Information Resource Identifier"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#informationResourceIdentifier">http://www.ontotext.com/proton/protontop#informationResourceIdentifier</seealso>
    let informationResourceIdentifier =
        Prefixed_Name(ptop, "informationResourceIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#informationResourceRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information about rights held in and over the resource. Typically, Rights will contain a rights management statement for the resource, or reference to a service providing such information. Rights information often encompasses Intellectual Property Rights (IPR), Copyright, and various Property Rights. If the Rights element is absent, no assumptions should be made about any rights held in or over the resource. DC2003ISO"</para>
    /// labels<para>"Information Resource Rights"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#informationResourceRights">http://www.ontotext.com/proton/protontop#informationResourceRights</seealso>
    let informationResourceRights =
        Prefixed_Name(ptop, "informationResourceRights") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#involvedEntityIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The entities related to a given happening. Such entities can be agents, instruments, materials, places, etc."</para>
    /// labels<para>"Entity Involved in"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#involvedEntityIn">http://www.ontotext.com/proton/protontop#involvedEntityIn</seealso>
    let involvedEntityIn = Prefixed_Name(ptop, "involvedEntityIn") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#involvedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The participating entities in a given happening that are agents. Participation is usually via some role."</para>
    /// labels<para>"Involved in"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#involvedIn">http://www.ontotext.com/proton/protontop#involvedIn</seealso>
    let involvedIn = Prefixed_Name(ptop, "involvedIn") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#isBossOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Person to another one, where the first is the immediate boss or supervisor of the latter. This is a many-to-many relationship, i.e. there can be more than one boss of a person, even contemporally."</para>
    /// labels<para>"is Boss of"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#isBossOf">http://www.ontotext.com/proton/protontop#isBossOf</seealso>
    let isBossOf = Prefixed_Name(ptop, "isBossOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#isLegalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Determines whether a particular Agent is a legal entity. The range should be constrained to Boolean. Agents, for which the value is True, correspond to instances of http://www.cyc.com/2003/04/01/cyc#LegalAgent, which is defined as follows "Each instance of #LegalAgent is an agent who has some status in a particular legal system. At the very least, such an agent is recognized by some legal authority as having some kinds of rights and/or responsibilities as an agent (e.g., #citizens of Germany), ... ". In PROTON, it is modeled as property in order to avoid multiple-inheritance of classes and/or multiple classifications of instances."</para>
    /// labels<para>"is Legal Entity"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#isLegalEntity">http://www.ontotext.com/proton/protontop#isLegalEntity</seealso>
    let isLegalEntity = Prefixed_Name(ptop, "isLegalEntity") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#isOwnedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between an object and an agent that is the owner of that object."</para>
    /// labels<para>"is Owned by"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#isOwnedBy">http://www.ontotext.com/proton/protontop#isOwnedBy</seealso>
    let isOwnedBy = Prefixed_Name(ptop, "isOwnedBy") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#laconicDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An extremely short (typically, single sentence) description of an entity"</para>
    /// labels<para>"Laconic Description"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#laconicDescription">http://www.ontotext.com/proton/protontop#laconicDescription</seealso>
    let laconicDescription = Prefixed_Name(ptop, "laconicDescription") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#lastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The relation between a person and his/her last name. Usually the family name."</para>
    /// labels<para>"Last Name"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#lastName">http://www.ontotext.com/proton/protontop#lastName</seealso>
    let lastName = Prefixed_Name(ptop, "lastName") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In degrees, minutes, and seconds: no sign or (+) = North; negative sign (-) = South."</para>
    /// labels<para>"Latitude"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#latitude">http://www.ontotext.com/proton/protontop#latitude</seealso>
    let latitude = Prefixed_Name(ptop, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#locatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between an object (also some happenings via their participants) and location where the object is."</para>
    /// labels<para>"Located in"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#locatedIn">http://www.ontotext.com/proton/protontop#locatedIn</seealso>
    let locatedIn = Prefixed_Name(ptop, "locatedIn") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In degrees, minutes, and seconds: no sign or (+) = East; negative sign (-) = West."</para>
    /// labels<para>"Longitude"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#longitude">http://www.ontotext.com/proton/protontop#longitude</seealso>
    let longitude = Prefixed_Name(ptop, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#mainLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This is a label of an entity which is consider to be representative for it. In cases when the entity is presented to someone, usually, this label will be used. In a sense, it is a specializatoin of rdfs:label"</para>
    /// labels<para>"Main Label"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#mainLabel">http://www.ontotext.com/proton/protontop#mainLabel</seealso>
    let mainLabel = Prefixed_Name(ptop, "mainLabel") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Name of any kind"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#name">http://www.ontotext.com/proton/protontop#name</seealso>
    let name = Prefixed_Name(ptop, "name") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#nimaGNSDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The designator of the entity according to the NIMA GeoNames Server."</para>
    /// labels<para>"NIMA GNS Designator"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#nimaGNSDesignator">http://www.ontotext.com/proton/protontop#nimaGNSDesignator</seealso>
    let nimaGNSDesignator = Prefixed_Name(ptop, "nimaGNSDesignator") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#nimaGNSUniqueFeatureIndentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Unique Feature Identifier from the NIMA GNS. A number which uniquely identifies the location."</para>
    /// labels<para>"NIMA GNS Unique Feature Identifier"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#nimaGNSUniqueFeatureIndentifier">http://www.ontotext.com/proton/protontop#nimaGNSUniqueFeatureIndentifier</seealso>
    let nimaGNSUniqueFeatureIndentifier =
        Prefixed_Name(ptop, "nimaGNSUniqueFeatureIndentifier") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#numberOfEmployees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The estimated number of employees in the organization."</para>
    /// labels<para>"Number of Employees"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#numberOfEmployees">http://www.ontotext.com/proton/protontop#numberOfEmployees</seealso>
    let numberOfEmployees = Prefixed_Name(ptop, "numberOfEmployees") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#operatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a service and the agent (usually organisation), who provides it"</para>
    /// labels<para>"Operated by"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#operatedBy">http://www.ontotext.com/proton/protontop#operatedBy</seealso>
    let operatedBy = Prefixed_Name(ptop, "operatedBy") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An agent fully owns an Object. In many cases this means also full control, unless the agent has transferred the control to another agent."</para>
    /// labels<para>"Owns"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#owns">http://www.ontotext.com/proton/protontop#owns</seealso>
    let owns = Prefixed_Name(ptop, "owns") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#parentOrganizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A relation between two organizations, where one of them is dependent on the other in some sense. This is a transitive relation, i.e. if organization X is a parent organization of Y and the latter is a parent organization of Z, then X is also considered a parent organization of Z. Inverse of subsidiaryOrganizationOf."</para>
    /// labels<para>"Parent Organization of"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#parentOrganizationOf">http://www.ontotext.com/proton/protontop#parentOrganizationOf</seealso>
    let parentOrganizationOf =
        Prefixed_Name(ptop, "parentOrganizationOf") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"The general part-of relation which takes place between a whole and each of its parts. It has a number of specializations."</para>
    /// labels<para>"Part of"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#partOf">http://www.ontotext.com/proton/protontop#partOf</seealso>
    let partOf = Prefixed_Name(ptop, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#partiallyControls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Any sort of partial control an agent has with respect to an object."</para>
    /// labels<para>"Partially Controls"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#partiallyControls">http://www.ontotext.com/proton/protontop#partiallyControls</seealso>
    let partiallyControls = Prefixed_Name(ptop, "partiallyControls") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#partiallyOwns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an Agent has some ownership over an object. It allows wide interpretations from "I have a bike" to "John has shares in Fujitsu"."</para>
    /// labels<para>"Partially Owns"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#partiallyOwns">http://www.ontotext.com/proton/protontop#partiallyOwns</seealso>
    let partiallyOwns = Prefixed_Name(ptop, "partiallyOwns") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#populationCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of citizens of a location."</para>
    /// labels<para>"Population Count"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#populationCount">http://www.ontotext.com/proton/protontop#populationCount</seealso>
    let populationCount = Prefixed_Name(ptop, "populationCount") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#premise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#premise">http://www.ontotext.com/proton/protontop#premise</seealso>
    let premise = Prefixed_Name(ptop, "premise") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#premise1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#premise1">http://www.ontotext.com/proton/protontop#premise1</seealso>
    let premise1 = Prefixed_Name(ptop, "premise1") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#premise2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#premise2">http://www.ontotext.com/proton/protontop#premise2</seealso>
    let premise2 = Prefixed_Name(ptop, "premise2") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#producedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a company and its ProductModel"</para>
    /// labels<para>"Produced by"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#producedBy">http://www.ontotext.com/proton/protontop#producedBy</seealso>
    let producedBy = Prefixed_Name(ptop, "producedBy") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#registeredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an organization and the location in which it is registered."</para>
    /// labels<para>"Registered in"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#registeredIn">http://www.ontotext.com/proton/protontop#registeredIn</seealso>
    let registeredIn = Prefixed_Name(ptop, "registeredIn") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#resourceFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The physical or digital manifestation of the resource. Typically, Format will include the media-type or dimensions of the resource. Format may be used to identify the software, hardware, or other equipment needed to display or operate the resource. Examples of dimensions include size and duration. Recommended best practice is to select a value from a controlled vocabulary (for example, the list of Internet Media Types [MIME] defining computer media formats). DC2003ISO"</para>
    /// labels<para>"Resource Format"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#resourceFormat">http://www.ontotext.com/proton/protontop#resourceFormat</seealso>
    let resourceFormat = Prefixed_Name(ptop, "resourceFormat") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#resourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The nature or genre of the content of the resource. Type includes terms describing general categories, functions, genres, or aggregation levels for content. Recommended best practice is to select a value from a controlled vocabulary (for example, the DCMI Type Vocabulary [DCT]). To describe the physical or digital manifestation of the resource, use the resourceFormat property. DC2003ISO."</para>
    /// labels<para>"Resource Type"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#resourceType">http://www.ontotext.com/proton/protontop#resourceType</seealso>
    let resourceType = Prefixed_Name(ptop, "resourceType") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#restriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#restriction">http://www.ontotext.com/proton/protontop#restriction</seealso>
    let restriction = Prefixed_Name(ptop, "restriction") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#roleHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a role and the entity that 'plays' a role in a given happening."</para>
    /// labels<para>"Role Holder"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#roleHolder">http://www.ontotext.com/proton/protontop#roleHolder</seealso>
    let roleHolder = Prefixed_Name(ptop, "roleHolder") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#roleIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a role to a happening, conditioned and affected by the role. Usually, the participants of a happening 'play' one or more roles in it."</para>
    /// labels<para>"Role in"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#roleIn">http://www.ontotext.com/proton/protontop#roleIn</seealso>
    let roleIn = Prefixed_Name(ptop, "roleIn") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#socialPositionHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a social position and the person who has it. "</para>
    /// labels<para>"Social Position Holder"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#socialPositionHolder">http://www.ontotext.com/proton/protontop#socialPositionHolder</seealso>
    let socialPositionHolder =
        Prefixed_Name(ptop, "socialPositionHolder") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the starting moment of a happening"</para>
    /// labels<para>"Start Time"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#startTime">http://www.ontotext.com/proton/protontop#startTime</seealso>
    let startTime = Prefixed_Name(ptop, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#statedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a statement to the agent who made it. In the case of an offer, the agent is the offerer; in case of a contract, those are the parties. In case of written statements, the creator/author and the "stater" could be different agents, due to the fact that one agent my have prepared and/or published a statement on behalf of another."</para>
    /// labels<para>"Stated by"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#statedBy">http://www.ontotext.com/proton/protontop#statedBy</seealso>
    let statedBy = Prefixed_Name(ptop, "statedBy") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#sub%D0%A0egionOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#sub%D0%A0egionOf">http://www.ontotext.com/proton/protontop#sub%D0%A0egionOf</seealso>
    let ``sub%D0%A0egionOf`` = Prefixed_Name(ptop, "sub%D0%A0egionOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#subRegionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Relation between two locations where the first is contained within the other."</para>
    /// labels<para>"Subregion of"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#subRegionOf">http://www.ontotext.com/proton/protontop#subRegionOf</seealso>
    let subRegionOf = Prefixed_Name(ptop, "subRegionOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#subTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A relation from less general to more general topic. Defined to be transitive via rule."</para>
    /// labels<para>"Subtopic of"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#subTopicOf">http://www.ontotext.com/proton/protontop#subTopicOf</seealso>
    let subTopicOf = Prefixed_Name(ptop, "subTopicOf") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#subsidiaryOrganizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an organization is in some sense part of another organization. This necessarily requires structural and organizational relations and may or may not indicate ownership. Its reverse, parentOrganizationOf, is a special case of partial control."</para>
    /// labels<para>"Subsidiary Organization of"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#subsidiaryOrganizationOf">http://www.ontotext.com/proton/protontop#subsidiaryOrganizationOf</seealso>
    let subsidiaryOrganizationOf =
        Prefixed_Name(ptop, "subsidiaryOrganizationOf") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protontop#systemPrimitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The system classes and properties are used to encode system specific information. They, as well as their instances and related information, should usually not be presented to the end-user. In practice, user-interface and visualization modules, can filter such primitives. All system primitives with this property should be marked with string value "T"."</para>
    /// labels<para>"System Primitive"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#systemPrimitive">http://www.ontotext.com/proton/protontop#systemPrimitive</seealso>
    let systemPrimitive = Prefixed_Name(ptop, "systemPrimitive") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A name given to an information resource. Typically, title will be a name by which the resource is formally known. (DC2003ISO, Title there)"</para>
    /// labels<para>"Title"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#title">http://www.ontotext.com/proton/protontop#title</seealso>
    let title = Prefixed_Name(ptop, "title") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#transitiveOver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Makes possible the modelling of a specific, but rather useful modelling pattern. The semantics is defined with the following axiom: (p,transitiveOver,q) (x,p,y) (y,q,z) =&gt; (x,p,z). Sample usage is: (locatedIn, transitiveOver, subRegionOf) (Ontotext,locatedIn,Bulgaria) (Bulgaria,subRegionOf,Europe) =&gt; (Ontotext,locatedIn,Europe). The intended domain and range of this property are owl:ObjectProperty; those are not formally specified, in order not to get the ontology outside the OWL DL segment."</para>
    /// labels<para>"Transitive over"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#transitiveOver">http://www.ontotext.com/proton/protontop#transitiveOver</seealso>
    let transitiveOver = Prefixed_Name(ptop, "transitiveOver") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#type1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#type1">http://www.ontotext.com/proton/protontop#type1</seealso>
    let type1 = Prefixed_Name(ptop, "type1") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#type2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#type2">http://www.ontotext.com/proton/protontop#type2</seealso>
    let type2 = Prefixed_Name(ptop, "type2") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time when a statement is made valid. The happing of making the statement valid is not explicitly represented in Proton. If it is necessary for the task the ontology needs to be extented."</para>
    /// labels<para>"Valid from"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#validFrom">http://www.ontotext.com/proton/protontop#validFrom</seealso>
    let validFrom = Prefixed_Name(ptop, "validFrom") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#validUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time when a statement is made invalid. The happening of making the statement invalid is not explicitly represented in Proton. If it is necessary for the task the ontology should be extented."</para>
    /// labels<para>"Valid until"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#validUntil">http://www.ontotext.com/proton/protontop#validUntil</seealso>
    let validUntil = Prefixed_Name(ptop, "validUntil") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protontop#withinOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Determines in which organization is the position"</para>
    /// labels<para>"within Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop#withinOrganization">http://www.ontotext.com/proton/protontop#withinOrganization</seealso>
    let withinOrganization = Prefixed_Name(ptop, "withinOrganization") |> PrefixedName
