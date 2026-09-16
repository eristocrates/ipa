#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rico =
    let _prefixId = PrefixId.fromNamespaceLabel "https://www.ica.org/standards/RiC/ontology#" "rico"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R028 and RiC-R028i
    ///             relations</para>
    ///   <para>rdfs:label : Accumulation Relation</para>
    ///   <para>rdfs:comment : Connects at least one Record Resource or Instantiation to at
    ///             least one Agent, when the Agent accumulates it, be it intentionally (collecting it) or
    ///             not (receiving it in the course of its activities).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#AccumulationRelation">rico:AccumulationRelation</a>
    /// </summary>
    let AccumulationRelation = _prefixId.prefix "AccumulationRelation"
    /// <summary>
    ///   <para>rdfs:label : Activity</para>
    ///   <para>rdfs:comment : The doing of something for some human purpose.</para>
    ///   <para>skos:scopeNote : Activity is a kind of Event. Activity is specifically used to
    ///             designate purposeful human activity. Activity may be understood from two perspectives.
    ///             First it can be understood as leading to an end. The end is the purpose of the Activity,
    ///             or why the Activity is performed. Second, it can be understood in terms of the processes
    ///             that lead to achieving the end, how the end is realized through coordinated actions.
    ///             Purpose and process are complementary understandings of Activity. Together the two
    ///             perspectives address why the Activity is performed, the expected ends or outcomes; and
    ///             how the Activity fulfills the purpose. While activity has an intended end, it also has
    ///             unintended consequences and results, or side-effects. By and large, these may not be the
    ///             focus of the description, but they are, unquestionably, context. |In a corporate or
    ///             government context an Activity may also be called a 'function'. An Activity exists in a
    ///             specific social and cultural context, and within that context is subject to change over
    ///             time. An Activity may be composed of other Activities.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E15 (Activity
    ///             entity)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Activity">rico:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R033 and RiC-R033
    ///             relations</para>
    ///   <para>rdfs:label : Activity Documentation Relation</para>
    ///   <para>rdfs:comment : Connects at least one Record Resource or Instantiation to at
    ///             least one Activity, when the Record Resource or Instantiation results from the
    ///             activity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ActivityDocumentationRelation">rico:ActivityDocumentationRelation</a>
    /// </summary>
    let ActivityDocumentationRelation = _prefixId.prefix "ActivityDocumentationRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A02 (Activity Type
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Can be extended with any number of subclasses, e.g.
    ///             “function/action” and “activity domain”. This allows for a faceted approach that enables
    ///             an Activity to be categorized using a combination of components, general or more
    ///             specific. For example, “monitoring” can be used in combination with “election polls” or
    ///             “water resources”.</para>
    ///   <para>rdfs:label : Activity Type</para>
    ///   <para>rdfs:comment : Categorization of an Activity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ActivityType">rico:ActivityType</a>
    /// </summary>
    let ActivityType = _prefixId.prefix "ActivityType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E07 (Agent
    ///             entity)</para>
    ///   <para>skos:scopeNote : An Agent may have one or more identities; an identity is a
    ///             constellation of properties or relations that together “identify” the Agent. A Person or
    ///             Group commonly has one identity, though each also may have one or more alternative
    ///             identities. Such alternative identities may be shared by more than one Person or Group.
    ///             Alternative identities include but are not limited to pseudonyms, heteronyms, DBA (Doing
    ///             Business As), and trade identities. An alternative identity should not be confused with
    ///             a Position in a Group, for example, presidents, prime ministers, governors, popes,
    ///             royalty, or bishops. Nor should an alternative identity be confused with a variant name
    ///             or identifier of the same identity. Agent also includes entities created by a Person or
    ///             Group that act on behalf of the creating Agent in an autonomous or semi-autonomous
    ///             manner. Examples of a Mechanism include software agents, robots, and space and
    ///             underwater probes that generate data (records) in the course of Activity assigned to and
    ///             in conformance with the instructions given to them by the creating Person or
    ///             Group.</para>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : A Person, or Group, or an entity created by a Person or Group
    ///             (Mechanism), or a Position, that acts in the world.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Agent">rico:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R041 and RiC-R041i
    ///             relations</para>
    ///   <para>rdfs:label : Agent Control Relation</para>
    ///   <para>rdfs:comment : Connects at least one Agent, to at least another Agent, when the
    ///             first one(s) control(s) in a way the activities of the second one(s).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#AgentControlRelation">rico:AgentControlRelation</a>
    /// </summary>
    let AgentControlRelation = _prefixId.prefix "AgentControlRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R045 and RiC-R045i
    ///             relations</para>
    ///   <para>rdfs:label : Agent Hierarchical Relation</para>
    ///   <para>rdfs:comment : Connects at least one Agent to at least another Agent, when the
    ///             first one is hierarchically superior to the second one.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#AgentHierarchicalRelation">rico:AgentHierarchicalRelation</a>
    /// </summary>
    let AgentHierarchicalRelation = _prefixId.prefix "AgentHierarchicalRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of a specialization of
    ///             RiC-A28 (Name attribute)</para>
    ///   <para>rdfs:label : Agent Name</para>
    ///   <para>rdfs:comment : A label, title or term designating an Agent in order to make it
    ///             distinguishable from other similar entities.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#AgentName">rico:AgentName</a>
    /// </summary>
    let AgentName = _prefixId.prefix "AgentName"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R026 and RiC-R026i
    ///             relations</para>
    ///   <para>rdfs:label : Agent Origination Relation</para>
    ///   <para>rdfs:comment : Connects at least one Record Resource or an Instantiation to at
    ///             least one Agent that creates or accumulates the Record Resource, receives it, or sends
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#AgentOriginationRelation">rico:AgentOriginationRelation</a>
    /// </summary>
    let AgentOriginationRelation = _prefixId.prefix "AgentOriginationRelation"
    /// <summary>
    ///   <para>rdfs:label : Agent Temporal Relation</para>
    ///   <para>rdfs:comment : Connects at least one Agent, to at least another Agent, that
    ///             succeeds it chronologically for, for instance, fullfilling some functions or performing
    ///             some activities.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R016 and RiC-016i
    ///             relations</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#AgentTemporalRelation">rico:AgentTemporalRelation</a>
    /// </summary>
    let AgentTemporalRelation = _prefixId.prefix "AgentTemporalRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R044 and RiC-044i
    ///             relations</para>
    ///   <para>rdfs:label : Agent Relation</para>
    ///   <para>rdfs:comment : Connects at least two Agents.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#AgentToAgentRelation">rico:AgentToAgentRelation</a>
    /// </summary>
    let AgentToAgentRelation = _prefixId.prefix "AgentToAgentRelation"
    /// <summary>
    ///   <para>rdfs:label : Appellation</para>
    ///   <para>rdfs:comment : A concept of any kind that is used for designating an Entity and
    ///             referring to it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Appellation">rico:Appellation</a>
    /// </summary>
    let Appellation = _prefixId.prefix "Appellation"
    /// <summary>
    ///   <para>rdfs:label : Appellation Relation</para>
    ///   <para>rdfs:comment : The relation between an Appellation and at least one Thing that
    ///             the Appellation designates.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#AppellationRelation">rico:AppellationRelation</a>
    /// </summary>
    let AppellationRelation = _prefixId.prefix "AppellationRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R036 and RiC-R036i
    ///             relations</para>
    ///   <para>skos:scopeNote : Would probably rarely be used as such (use its
    ///             sub-categories)</para>
    ///   <para>rdfs:label : Authority Relation</para>
    ///   <para>rdfs:comment : Connects at least one Agent, and at least one Thing over which
    ///             the Agent has some authority.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#AuthorityRelation">rico:AuthorityRelation</a>
    /// </summary>
    let AuthorityRelation = _prefixId.prefix "AuthorityRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R079 and RiC-R079i
    ///             relations</para>
    ///   <para>rdfs:label : Authorship Relation</para>
    ///   <para>rdfs:comment : Connects at least one Record to at least one Person, Group or
    ///             Position that is responsible for conceiving and formulating the information contained in
    ///             the Record.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#AuthorshipRelation">rico:AuthorshipRelation</a>
    /// </summary>
    let AuthorshipRelation = _prefixId.prefix "AuthorshipRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-A04 (Carrier Extent)
    ///             attribute</para>
    ///   <para>skos:scopeNote : Countable characteristics of a record resource carrier
    ///             expressed as a quantity.</para>
    ///   <para>rdfs:label : Carrier Extent</para>
    ///   <para>rdfs:comment : The extent of a Record Resource carrier</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#CarrierExtent">rico:CarrierExtent</a>
    /// </summary>
    let CarrierExtent = _prefixId.prefix "CarrierExtent"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A05 (Carrier Type
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Carrier Type information is essential for assessing
    ///             authenticity, conservation needs and the availability, access and use of Record
    ///             Resources. Carrier Type determines the environmental conditions of storage and the
    ///             prerequisites and possible ways to access and use of the records. Should not be confused
    ///             with Content Type, that categorizes a Record Resource, nor with Representation Type that
    ///             categorizes an Instantiation. The Carrier Type depends on the media type that is
    ///             required to access the records and is independent of its content</para>
    ///   <para>rdfs:label : Carrier Type</para>
    ///   <para>rdfs:comment : Categorization of physical material in or on which information
    ///             is represented.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#CarrierType">rico:CarrierType</a>
    /// </summary>
    let CarrierType = _prefixId.prefix "CarrierType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R018 and RiC-R018i
    ///             relations</para>
    ///   <para>rdfs:label : Child Relation</para>
    ///   <para>rdfs:comment : Connects at lest one Person, to at least another Person, when
    ///             the first has child the second one.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ChildRelation">rico:ChildRelation</a>
    /// </summary>
    let ChildRelation = _prefixId.prefix "ChildRelation"
    /// <summary>
    ///   <para>rdfs:label : Concept</para>
    ///   <para>rdfs:comment : An idea, unit of thought, abstract cultural object or
    ///             category</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Concept">rico:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A10 (Content Type
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Should not be confused with Representation Type or Carrier
    ///             Type of a related Instantiation since the form of communication can be independent of
    ///             the representation or carrier, for example, a map (Content Type: cartographic image) can
    ///             be represented as a sketch (Representation Type: graphic) or as a GIS-coded elements
    ///             (Representation Type: computer).</para>
    ///   <para>rdfs:label : Content Type</para>
    ///   <para>rdfs:comment : The fundamental form of communication in which a Record is
    ///             expressed and the human sense through which it is intended to be
    ///             perceived.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ContentType">rico:ContentType</a>
    /// </summary>
    let ContentType = _prefixId.prefix "ContentType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-A11 (Coordinates
    ///             attribute)</para>
    ///   <para>rdfs:label : Coordinates</para>
    ///   <para>rdfs:comment : Longitudinal and latitudinal information of a
    ///             Place.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Coordinates">rico:Coordinates</a>
    /// </summary>
    let Coordinates = _prefixId.prefix "Coordinates"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E11 (Corporate Body
    ///             entity)</para>
    ///   <para>skos:scopeNote : Corporate Body is a kind of Group.</para>
    ///   <para>rdfs:label : Corporate Body</para>
    ///   <para>rdfs:comment : An organized group of persons that act together as an Agent, and
    ///             that has a recognized legal or social status.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#CorporateBody">rico:CorporateBody</a>
    /// </summary>
    let CorporateBody = _prefixId.prefix "CorporateBody"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A12 (Corporate Body Type
    ///             attribute)</para>
    ///   <para>rdfs:label : Corporate Body Type</para>
    ///   <para>rdfs:comment : Categorization of a Corporate Body.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#CorporateBodyType">rico:CorporateBodyType</a>
    /// </summary>
    let CorporateBodyType = _prefixId.prefix "CorporateBodyType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R052 and Ri052i
    ///             relations</para>
    ///   <para>rdfs:label : Correspondence Relation</para>
    ///   <para>rdfs:comment : Connects at least two Persons, when they correspond to each
    ///             other.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#CorrespondenceRelation">rico:CorrespondenceRelation</a>
    /// </summary>
    let CorrespondenceRelation = _prefixId.prefix "CorrespondenceRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R027 and RiC-R027i
    ///             relations</para>
    ///   <para>rdfs:label : Creation Relation</para>
    ///   <para>rdfs:comment : Connects at least one Record Resource or Instantiation to at
    ///             least one Agent, when the Agent is either responsible for all or some of the content of
    ///             the Record Resource, or is a contributor to the genesis or production of the
    ///             Instantiation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#CreationRelation">rico:CreationRelation</a>
    /// </summary>
    let CreationRelation = _prefixId.prefix "CreationRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E18 (Date
    ///             entity)</para>
    ///   <para>skos:scopeNote : Date includes both single dates, a date range, or a set of
    ///             non-contiguous single dates or date ranges. A date may be represented in natural
    ///             language, based on a digital standard, or both. Digital standard dates will typically be
    ///             based on ISO 8601, or Extended Date-Time Format (EDTF).</para>
    ///   <para>rdfs:label : Date</para>
    ///   <para>rdfs:comment : Chronological information associated with an entity that
    ///             contributes to its identification and contextualization.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Date">rico:Date</a>
    /// </summary>
    let Date = _prefixId.prefix "Date"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E20 (Date Range
    ///             entity)</para>
    ///   <para>rdfs:label : Date Range</para>
    ///   <para>rdfs:comment : Chronological information associated with an entity that
    ///             contributes to its identification and contextualization, that implies or explicitly
    ///             states a start date and end date.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#DateRange">rico:DateRange</a>
    /// </summary>
    let DateRange = _prefixId.prefix "DateRange"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E21 (Date Set
    ///             entity)</para>
    ///   <para>skos:scopeNote : Primarily used in the description of Record Sets to describe
    ///             dates of member Records</para>
    ///   <para>rdfs:label : Date Set</para>
    ///   <para>rdfs:comment : Non-contiguous single dates or date ranges.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#DateSet">rico:DateSet</a>
    /// </summary>
    let DateSet = _prefixId.prefix "DateSet"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A15 (Demographic Group
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Can be extended with any number of subclasses, e.g. Age or
    ///             Religion. A demographic group may be defined as a subset of the general population.
    ///             Individuals may belong to several demographic groups</para>
    ///   <para>rdfs:label : Demographic Group</para>
    ///   <para>rdfs:comment : Categorization of a person according to characteristics such as
    ///             age, gender, education, place of origin, ethnic/cultural identification, religion,
    ///             etc.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#DemographicGroup">rico:DemographicGroup</a>
    /// </summary>
    let DemographicGroup = _prefixId.prefix "DemographicGroup"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R014 and RiR014i
    ///             relations</para>
    ///   <para>rdfs:label : Derivation Relation</para>
    ///   <para>rdfs:comment : Connects an Instantiation to at least one Instantiation that is
    ///             derived from it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#DerivationRelation">rico:DerivationRelation</a>
    /// </summary>
    let DerivationRelation = _prefixId.prefix "DerivationRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R017 and RiC-R017i
    ///             relations</para>
    ///   <para>rdfs:label : Descendance Relation</para>
    ///   <para>rdfs:comment : Connects at least one Person to at least another Person, when
    ///             the first has/have descendant the second one(s).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#DescendanceRelation">rico:DescendanceRelation</a>
    /// </summary>
    let DescendanceRelation = _prefixId.prefix "DescendanceRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A17 (Documentary Form Type
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Documentary Form Type plays an important role in determining
    ///             the type of information a Record may comprise, its status of perfection, and its
    ///             authenticity and reliability. Documentary form types exist in a specific social and
    ///             cultural context, and within that context, are subject to change over
    ///             time</para>
    ///   <para>rdfs:label : Documentary Form Type</para>
    ///   <para>rdfs:comment : Categorization of the document with respect to its extrinsic and
    ///             intrinsic elements that together communicate its content, administrative and documentary
    ///             context, and authority</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#DocumentaryFormType">rico:DocumentaryFormType</a>
    /// </summary>
    let DocumentaryFormType = _prefixId.prefix "DocumentaryFormType"
    /// <summary>
    ///   <para>skos:scopeNote : An event may be natural, human, or a combination of natural
    ///             and human. Events have temporal and spatial boundaries. An event may actively involve
    ///             some agent(s) and affect any entity. An event may be discrete, happening at a specific
    ///             moment in time, or may occur over an extended period of time. Events may have events as
    ///             parts, and events may precede or follow one another. Multiple agents may participate in
    ///             the same event, and in different roles. </para>
    ///   <para>rdfs:comment : Something that happens in time and space.</para>
    ///   <para>rico:closeTo : LODE Event class
    ///             (http://linkedevents.org/ontology/#term-Event)</para>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E14 (Event
    ///             entity)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Event">rico:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R057 and RiC-R057i
    ///             relations</para>
    ///   <para>rdfs:label : Event Relation</para>
    ///   <para>rdfs:comment : Connects at least one Event to at least one Thing, when the
    ///             first is associated with the existence and lifecycle of the second one.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#EventRelation">rico:EventRelation</a>
    /// </summary>
    let EventRelation = _prefixId.prefix "EventRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A18 (Event Type
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Events of all kinds can be categorized. Curation event types
    ///             include creation; acquisition; transfer; arrangement; description; digitization, etc.
    ///             Biographical event types include birth, marriage, death, etc.</para>
    ///   <para>rdfs:label : Event Type</para>
    ///   <para>rdfs:comment : Categorization of an Event.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#EventType">rico:EventType</a>
    /// </summary>
    let EventType = _prefixId.prefix "EventType"
    /// <summary>
    ///   <para>skos:scopeNote : Physical or logical extent of a resource</para>
    ///   <para>rdfs:label : Extent</para>
    ///   <para>rdfs:comment : Countable characteristics of the content of an entity expressed
    ///             as a quantity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Extent">rico:Extent</a>
    /// </summary>
    let Extent = _prefixId.prefix "Extent"
    /// <summary>
    ///   <para>rdfs:label : Extent Type</para>
    ///   <para>rdfs:comment : Categorization of the extent that is being measured^^xsd:string</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ExtentType">rico:ExtentType</a>
    /// </summary>
    let ExtentType = _prefixId.prefix "ExtentType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E10 (Family
    ///             entity)</para>
    ///   <para>skos:scopeNote : Family is a kind of Group. “Family” is used here as a general
    ///             term that encompasses a wide variety of familial groups. Other types of familial groups
    ///             include Dynasty, Clan, House, Tribe and others. Though family may be a recognized legal
    ///             group in specific contexts, the term may also be used for groups that are socially
    ///             recognized as families. A family may be a group of persons related either by
    ///             consanguinity or affinity or cohabitation or other social conventions. In some context,
    ///             a Family may be legally recognized as Corporate Body. For example, certain North
    ///             American peoples (tribes) retain self-government rights and have jurisdiction over
    ///             defined tribal lands.</para>
    ///   <para>rdfs:label : Family</para>
    ///   <para>rdfs:comment : Two or more persons related by birth, or through marriage,
    ///             adoption, civil union, or other social conventions that bind them together as a socially
    ///             recognized familial group.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Family">rico:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R047 and RiC-R047i
    ///             relations</para>
    ///   <para>rdfs:label : Family Relation</para>
    ///   <para>rdfs:comment : Connects at least two Persons, when they have some family link,
    ///             i.e. belong to the same family.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#FamilyRelation">rico:FamilyRelation</a>
    /// </summary>
    let FamilyRelation = _prefixId.prefix "FamilyRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A20 (Family Type
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Family Type encompasses a wide variety of familial groups
    ///             related by consanguinity, affinity, cohabitation or other social conventions. </para>
    ///   <para>rdfs:label : Family Type</para>
    ///   <para>rdfs:comment : Categorization of a Family.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#FamilyType">rico:FamilyType</a>
    /// </summary>
    let FamilyType = _prefixId.prefix "FamilyType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R035 and RiC-R035i
    ///             relations</para>
    ///   <para>skos:scopeNote : Use for Instantiations which, from some point of view, in some
    ///             context and for some users at least, may be considered as equivalent. This equivalence
    ///             is usually based upon the fact that the Instantiations have at least the same
    ///             intellectual content (they instantiate the same Record Resource).</para>
    ///   <para>rdfs:label : Functional Equivalence Relation</para>
    ///   <para>rdfs:comment : Connects at least two Instantiations which may be considered as
    ///             equivalent.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#FunctionalEquivalenceRelation">rico:FunctionalEquivalenceRelation</a>
    /// </summary>
    let FunctionalEquivalenceRelation = _prefixId.prefix "FunctionalEquivalenceRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E09 (Group
    ///             Entity)</para>
    ///   <para>rdfs:label : Group</para>
    ///   <para>skos:scopeNote : Group is a kind of Agent. A Group has a socially recognized
    ///             identity. Each member of the Group plays a particular role or roles (that is has a
    ///             particular Position) in the coordinated activity of the Group. Corporate bodies and
    ///             families are kinds of groups, though other kinds of groups are possible. For example,
    ///             the “electorate” -- all of the voters in a given election. Complex, large groups may be
    ///             subdivided into other groups.</para>
    ///   <para>rdfs:comment : Two or more Agents that act together as an Agent.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Group">rico:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R005 and RiC-R005i
    ///             relations</para>
    ///   <para>rdfs:label : Group Subdivision Relation</para>
    ///   <para>rdfs:comment : Connects a Group and at least another Group, when the first one
    ///             as the second one(s) among its subdivisions.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#GroupSubdivisionRelation">rico:GroupSubdivisionRelation</a>
    /// </summary>
    let GroupSubdivisionRelation = _prefixId.prefix "GroupSubdivisionRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-A22 (Identifier
    ///             attribute) (see also the identifier data property)</para>
    ///   <para>rdfs:label : Identifier</para>
    ///   <para>rdfs:comment : A word, number, letter, symbol, or any combination of these used
    ///             to uniquely identify or reference an individual instance of an entity within a specific
    ///             information domain.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Identifier">rico:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>skos:scopeNote : For example, 'old identifier' ; 'ISNI' (for a person or
    ///             corporate body), etc.</para>
    ///   <para>rdfs:label : Identifier Type</para>
    ///   <para>rdfs:comment : Categorization of an Identifier.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#IdentifierType">rico:IdentifierType</a>
    /// </summary>
    let IdentifierType = _prefixId.prefix "IdentifierType"
    /// <summary>
    ///   <para>rdfs:label : Instantiation</para>
    ///   <para>rico:closeTo : PREMIS Representation</para>
    ///   <para>rdfs:comment : The inscription of information made by an Agent on a physical
    ///             carrier in any persistent, recoverable form as a means of communicating information
    ///             through time and space.</para>
    ///   <para>skos:scopeNote : A Record or Record Part must have been instantiated at least
    ///             once, though this instantiation may no longer exist at the moment of description. An
    ///             instantiation might also exist at the moment of description, but be destroyed at a later
    ///             moment in time, when, for example, a derived instantiation might become the only
    ///             remaining instantiation. A Record Set may have an instantiation, which is to say that it
    ///             is not a necessary condition. An Instantiation may be derived from another
    ///             Instantiation. A Record Resource may have many Instantiations simultaneously (for
    ///             instance, a record printed and saved in the same time as DOCX and PDF/A would have 3
    ///             concurrent instantiations) or through time (for example, copy of a record). Depending on
    ///             the context, a new instantiation may be seen as a new or as the same record resource.
    ///             During in the process of re-instantiation something is lost and something is preserved,
    ///             but it is up to the context and the Agent that produces or uses that Instantiation to
    ///             assess whether the two instantiations are functionally equivalent or not. For instance,
    ///             a postcard representing a town map from 1874 (Instantiation 1) is digitized and kept as
    ///             a JPEG file (Instantiation 2). The digital copy may be considered as instantiating the
    ///             "same" Record by an Agent considering the information transmitted by the Record (e.g.,
    ///             the urban landscape displayed), but as a" different" Record by an antiquarian more
    ///             focused on the materiality of the carrier. Successive instantiations may change the
    ///             perceivable boundaries of a Record Resource. For instance, a case file comprising many
    ///             records may be digitized and saved as one single PDF file, which, from management
    ///             perspective, may be treated as one Record. Similarly, a large Record Set (a fonds or a
    ///             series) may be maintained as one database. On the other hand, one record (main document
    ///             and its annexes) may be digitized in separate files and each one may be managed as a
    ///             discrete “physical” item. Instantiations may require mediation to communicate the
    ///             information in the Record Resource. While a traditional Record on paper can simply be
    ///             read by an Agent in order to understand the information, a vinyl recording, a video
    ///             cassette or a digital file needs a device (mediator) to codify or decodify the
    ///             information conveyed. This mediator may imply simple physical components (a turntable
    ///             needle, for example), or a complex gallery of software and hardware elements.
    ///             Instantiations are more than the mere informational content of Record Resource and may
    ///             be the focus of preservation and physical management of records. The use of particular
    ///             document types for records, such as a medieval charter, may have implications for the
    ///             authenticity of the records. Hence, the way a Record Resource is instantiated
    ///             contributes to the contextualizing of the content.record resource is instantiated
    ///             contributes to the contextualizing the content. Distinguishing the message conveyed
    ///             (Record Resource) and its physical representations (Instantiation) allows for the
    ///             efficient management of their descriptions, and preserve information about a Record
    ///             Resource even when no physical representation of it exists or is known to exist anymore.
    ///             The relations between distinct instantiations can then be expressed wherever they
    ///             coexist, and they can be related to the Record Resource they
    ///             instantiate.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E06 (Instantiation
    ///             entity)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Instantiation">rico:Instantiation</a>
    /// </summary>
    let Instantiation = _prefixId.prefix "Instantiation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-A23 (Instantiation
    ///             Extent attribute)</para>
    ///   <para>skos:scopeNote : Countable characteristics of an Instantiation expressed as a
    ///             quantity.</para>
    ///   <para>rdfs:label : Instantiation Extent</para>
    ///   <para>rdfs:comment : The extent of an Instantiation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#InstantiationExtent">rico:InstantiationExtent</a>
    /// </summary>
    let InstantiationExtent = _prefixId.prefix "InstantiationExtent"

    /// <summary>
    ///   <para>rdfs:label : Instantiation to Instantiation Relation</para>
    ///   <para>rdfs:comment : Connects at least two instantiations</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#InstantiationToInstantiationRelation">rico:InstantiationToInstantiationRelation</a>
    /// </summary>
    let InstantiationToInstantiationRelation = _prefixId.prefix "InstantiationToInstantiationRelation"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R040 and RiC-R040i
    ///             relations</para>
    ///   <para>skos:scopeNote : Can be used, when the record resource is a work, for
    ///             specifying the connection between the record resource and its
    ///             author(s).</para>
    ///   <para>rdfs:label : Intellectual Property Rights Relation</para>
    ///   <para>rdfs:comment : Connects at least one Agent and one Record Resource or
    ///             Instantiation on which the Agent has some intellectual property rights.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#IntellectualPropertyRightsRelation">rico:IntellectualPropertyRightsRelation</a>
    /// </summary>
    let IntellectualPropertyRightsRelation = _prefixId.prefix "IntellectualPropertyRightsRelation"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R050 and RiC-R050i
    ///             relationsi</para>
    ///   <para>rdfs:label : Knowing Of Relation</para>
    ///   <para>rdfs:comment : Connects at least one Person to at least another one, when the
    ///             first one has some knowledge of the second one through time or space.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#KnowingOfRelation">rico:KnowingOfRelation</a>
    /// </summary>
    let KnowingOfRelation = _prefixId.prefix "KnowingOfRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Cass implementation of RiC-R051 and RiC—R051i
    ///             relations</para>
    ///   <para>rdfs:label : Knowing Relation</para>
    ///   <para>rdfs:comment : Connects at least two Persons that directly know each other
    ///             during their existence. This relation is symmetric.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#KnowingRelation">rico:KnowingRelation</a>
    /// </summary>
    let KnowingRelation = _prefixId.prefix "KnowingRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A25 (Language
    ///             attribute)</para>
    ///   <para>rdfs:label : Language</para>
    ///   <para>rdfs:comment : A spoken or written human language represented in the Record or
    ///             Record Part, or used by the Agent.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Language">rico:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R042 and RiC-R042i
    ///             relations</para>
    ///   <para>rdfs:label : Leadership Relation</para>
    ///   <para>rdfs:comment : Connects at least one Person and at least one Group, when the
    ///             first one leads the second one.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#LeadershipRelation">rico:LeadershipRelation</a>
    /// </summary>
    let LeadershipRelation = _prefixId.prefix "LeadershipRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A26 (Legal Status
    ///             attribute)</para>
    ///   <para>rdfs:label : Legal Status</para>
    ///   <para>rdfs:comment : A status defined by law.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#LegalStatus">rico:LegalStatus</a>
    /// </summary>
    let LegalStatus = _prefixId.prefix "LegalStatus"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R038 and RiC-R038i
    ///             relations</para>
    ///   <para>rdfs:label : Management Relation</para>
    ///   <para>rdfs:comment : Connects at least one Agent, and at least one Record Resource or
    ///             Instantiation that the Agent manages.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ManagementRelation">rico:ManagementRelation</a>
    /// </summary>
    let ManagementRelation = _prefixId.prefix "ManagementRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E17 (Mandate
    ///             entity)</para>
    ///   <para>skos:scopeNote : Mandate is a kind of Rule. A Mandate confers the authority or
    ///             competencies of Agents to perform a specified Activity. In addition to assigning an
    ///             Activity and delegating authority to perform the Activity to an Agent, a Mandate
    ///             commonly limits the Place (jurisdiction) and Date (time period) within which an Agent
    ///             may perform the Activity (where and when). Mandates exist in a specific social and
    ///             cultural context, and within that context are subject to change over time. While a
    ///             Mandate may be tacit, in whole or part, it may be explicitly expressed in a variety of
    ///             documentary sources (for example, constitutions, legislation, (legal) acts, statutes,
    ///             legal codes, ordinances, charges, charters, or mission statements). The evidence for
    ///             identifying a Mandate may be found in its entirety in one documentary source (for
    ///             example, a law or regulation), or may be found in two or more sources. A Mandate should
    ///             not be confused with the one or more documentary sources that serve as evidence of its
    ///             identity. A documentary source is a Record.</para>
    ///   <para>rdfs:label : Mandate</para>
    ///   <para>rdfs:comment : Delegation of authority by an Agent to another Agent to perform
    ///             an Activity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Mandate">rico:Mandate</a>
    /// </summary>
    let Mandate = _prefixId.prefix "Mandate"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R067 and RiC-R067i
    ///             relations</para>
    ///   <para>rdfs:label : Mandate Relation</para>
    ///   <para>rdfs:comment : Connects at least one Mandate, and at least one Agent, when the
    ///             first gives the second one the authority or competencies to act. May also involve one to
    ///             many Activities that the Mandate(s) assign(s) to the Agent(s).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#MandateRelation">rico:MandateRelation</a>
    /// </summary>
    let MandateRelation = _prefixId.prefix "MandateRelation"
    /// <summary>
    ///   <para>rdfs:label : Mechanism</para>
    ///   <para>skos:scopeNote : Mechanism is a kind of Agent. A Mechanism may have both
    ///             mechanical and software components, or may be exclusively software. A Mechanism acts in
    ///             the world producing physical or social effects, and frequently generates or modifies
    ///             Records.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E13 (Mechanism
    ///             entity)</para>
    ///   <para>rdfs:comment : A process or system created by a Person or Group that performs
    ///             an Activity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Mechanism">rico:Mechanism</a>
    /// </summary>
    let Mechanism = _prefixId.prefix "Mechanism"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R055 and RiC-R055i
    ///             relations</para>
    ///   <para>rdfs:label : Membership Relation</para>
    ///   <para>rdfs:comment : Connects a Group and at least one Person, when the first one has
    ///             the second one(s) among its members.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#MembershipRelation">rico:MembershipRelation</a>
    /// </summary>
    let MembershipRelation = _prefixId.prefix "MembershipRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R015 and RiC-R015i
    ///             relations</para>
    ///   <para>rdfs:label : Migration Relation</para>
    ///   <para>rdfs:comment : Connects an Instantiation and at least another Instantiation,
    ///             when the first is migrated into the second one(s).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#MigrationRelation">rico:MigrationRelation</a>
    /// </summary>
    let MigrationRelation = _prefixId.prefix "MigrationRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-A28 (Name attribute)
    ///             (see also the name data property)</para>
    ///   <para>rdfs:label : Name</para>
    ///   <para>rdfs:comment : A label, title or term designating the entity in order to make
    ///             it distinguishable from other similar entities.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Name">rico:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>rdfs:label : Occupation Type</para>
    ///   <para>skos:scopeNote : Occupation Type should not be confused with Position where,
    ///             for example, an Agent with the Occupation Type “lawyer” holds the Position of “legal
    ///             counsel” in an agency. Occupation Type is related to, but should not be confused with
    ///             the domain or field of Activity (Actvitity Type), such as an archivist who works in the
    ///             domain of archival science. Occupation Type is a kind of Demographic
    ///             Group.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A30 (Occupation Type
    ///             attribute)</para>
    ///   <para>rdfs:comment : Categorization of a profession, trade, or craft pursued by a
    ///             person in fulfilment of an Activity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#OccupationType">rico:OccupationType</a>
    /// </summary>
    let OccupationType = _prefixId.prefix "OccupationType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R037 and RiC-R037i
    ///             relations</para>
    ///   <para>skos:scopeNote : Among other probably more rare use cases for archival
    ///             description, can be used between agents (a person owns a corporate body, a corporate
    ///             body owns a mechanism), or between agents and record resources</para>
    ///   <para>rdfs:label : Ownership Relation</para>
    ///   <para>rdfs:comment : Connects at least one Group, Person or Position, and at least a
    ///             Thing that these Agent(s) own(s).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#OwnershipRelation">rico:OwnershipRelation</a>
    /// </summary>
    let OwnershipRelation = _prefixId.prefix "OwnershipRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R060 and RiC-R060i
    ///             relations</para>
    ///   <para>rdfs:label : Performance Relation</para>
    ///   <para>rdfs:comment : Connects at least one Activity to at least one Agent, when the
    ///             first is performed by the second one(s).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#PerformanceRelation">rico:PerformanceRelation</a>
    /// </summary>
    let PerformanceRelation = _prefixId.prefix "PerformanceRelation"
    /// <summary>
    ///   <para>rdfs:comment : A human being with a social identity or persona.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E08 (Person
    ///             entity)</para>
    ///   <para>rdfs:label : Person</para>
    ///   <para>skos:scopeNote : Person is a kind of Agent. Most commonly, a human being
    ///             (biological person) has a single coeval social identity or persona. In everyday
    ///             discourse, this is the “real person.” Less common though not rare, over the course of a
    ///             lifetime, personae in addition to the coeval (or “original”) persona may be associated
    ///             with the human being. Such “alternative personae” are most often created by the original
    ///             person for specific purposes. Under some circumstances, an alternative persona might
    ///             eclipse or replace the original person (Mark Twain eclipsing Samuel Clemens; John Wayne
    ///             eclipsing Marion Mitchell Morrison), that is, the social (shared) alternative identity
    ///             becomes the predominate identity. Less common is whentwo or more persons collaborate to
    ///             create a shared persona. Persona shared by two or more Persons constitute a kind of
    ///             Group. Within the archival context, the original Person generally will be the focus of
    ///             the description, with alternative personae noted. Exceptionally, an alternative persona
    ///             may displace the coeval persona.s.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Person">rico:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-A27 (Location
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Usually associated to one to many Places, and known during
    ///             some time. A location may be linked to one to many Coordinates.</para>
    ///   <para>rdfs:label : Physical Location</para>
    ///   <para>rdfs:comment : A delimitation of the physical territory of a
    ///             Place.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#PhysicalLocation">rico:PhysicalLocation</a>
    /// </summary>
    let PhysicalLocation = _prefixId.prefix "PhysicalLocation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E22 (Place
    ///             entity)</para>
    ///   <para>skos:scopeNote : A Place may be a jurisdiction, a manmade structure, or a
    ///             natural feature. A manmade structure or natural feature may also be a jurisdiction. A
    ///             Place may be referenced to a Physical Location on the earth, or (if you don't want to
    ///             use the PhysicalLocation class) directly to geographic coordinates. Both jurisdictions
    ///             and natural features are historical entities. A Place thus may have begin and end dates,
    ///             and changing boundaries that result from human or natural events. A Jurisdiction is the
    ///             bounded geographic area within which an Agent has the authority to perform specified
    ///             activities constrained by rules.</para>
    ///   <para>rdfs:label : Place</para>
    ///   <para>rdfs:comment : Bounded, named geographic area or region.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Place">rico:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of a specialization of
    ///             RiC-A28 (Name attribute)</para>
    ///   <para>rdfs:label : Place Name</para>
    ///   <para>rdfs:comment : A label, title or term designating a Place in order to make it
    ///             distinguishable from other similar entities.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#PlaceName">rico:PlaceName</a>
    /// </summary>
    let PlaceName = _prefixId.prefix "PlaceName"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R074 and RiC-R074i
    ///             relations</para>
    ///   <para>rdfs:label : Place Relation</para>
    ///   <para>rdfs:comment : Connects a Place and at least one Thing, when the first is
    ///             associated with the existence and lifecycle of the second one.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#PlaceRelation">rico:PlaceRelation</a>
    /// </summary>
    let PlaceRelation = _prefixId.prefix "PlaceRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A32 (Place Type
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Broadly, a Place may be a member of three broad categories:
    ///             jurisdiction, manmade structure, or a natural feature. Each of these three categories
    ///             can subdivided into narrower categories.</para>
    ///   <para>rdfs:label : Place Type</para>
    ///   <para>rdfs:comment : Categorization of a Place.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#PlaceType">rico:PlaceType</a>
    /// </summary>
    let PlaceType = _prefixId.prefix "PlaceType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E12 (Position
    ///             entity)</para>
    ///   <para>skos:scopeNote : Position is a kind of Agent. Position is the intersection of a
    ///             Person and a Group. Position exists independently of the Person that holds the Position
    ///             within a Group. More than one Person may hold a Position. Position is commonly defined
    ///             in a Mandate, often called a position description or job description. The Mandate may
    ///             specify the work to be performed (Activity) as well as the competencies for performing
    ///             the Activity. A Position is often given a Name. A Position may be tied to a project or
    ///             to a set of tasks and thus have a defined duration. A Position may change over time, as
    ///             the Group that establishes it changes over time. Position is not to be confused with
    ///             Occupation or Activity. Within the records created by a Corporate Body, a Position may
    ///             be used to identify the record sets resulting from activities performed by one or more
    ///             persons holding the Position over time, without necessarily identifying or describing
    ///             the Person or persons, or identifying which records were created by each
    ///             Person.</para>
    ///   <para>rdfs:label : Position</para>
    ///   <para>rdfs:comment : The functional role of a Person within a Group.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Position">rico:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R054 and RiC-R054i
    ///             relations</para>
    ///   <para>rdfs:label : Position Holding Relation</para>
    ///   <para>rdfs:comment : Connects at least one Person, and at least one Position that the
    ///             Person occupies.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#PositionHoldingRelation">rico:PositionHoldingRelation</a>
    /// </summary>
    let PositionHoldingRelation = _prefixId.prefix "PositionHoldingRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R056 and RiC-R056i
    ///             relations</para>
    ///   <para>rdfs:label : Position to Group Relation</para>
    ///   <para>rdfs:comment : Connects at least one Position, and a Group, when the first
    ///             one(s) exist(s) in/is defined within the second one.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#PositionToGroupRelation">rico:PositionToGroupRelation</a>
    /// </summary>
    let PositionToGroupRelation = _prefixId.prefix "PositionToGroupRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-A33 (Production
    ///             Technique attribute)</para>
    ///   <para>rdfs:label : Production Technique Type</para>
    ///   <para>rdfs:comment : Categorization of the method used in the representation of
    ///             information on the Instantiation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ProductionTechniqueType">rico:ProductionTechniqueType</a>
    /// </summary>
    let ProductionTechniqueType = _prefixId.prefix "ProductionTechniqueType"
    /// <summary>
    ///   <para>skos:scopeNote : This relation stands for organic and for functional
    ///             provenance.</para>
    ///   <para>rdfs:label : Provenance Relation</para>
    ///   <para>rdfs:comment : Specifies the provenance or origin of at least one Record
    ///             Resource or Instantiation, for example the relation between a Record Resource and the
    ///             Agent which created it or the Activity from which it resulted.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ProvenanceRelation">rico:ProvenanceRelation</a>
    /// </summary>
    let ProvenanceRelation = _prefixId.prefix "ProvenanceRelation"
    /// <summary>
    ///   <para>rico:closeTo : ORE Proxy (http://www.openarchives.org/ore/terms/Proxy)</para>
    ///   <para>skos:scopeNote : Useful for handling in RDF the sequencing of records or
    ///             records sets in the context of a Record set. A Record Resource has only one Proxy in the
    ///             context of one specific Record Set. It may have many Proxies simultaneously or through
    ///             time.</para>
    ///   <para>rdfs:label : Proxy</para>
    ///   <para>rdfs:comment : A Proxy represents (stands for) a Record Resource as it exists
    ///             in a specific Record Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Proxy">rico:Proxy</a>
    /// </summary>
    let Proxy = _prefixId.prefix "Proxy"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E04 (Record
    ///             entity)</para>
    ///   <para>skos:scopeNote : Record is a kind of Record Resource. A Record must have or
    ///             have had at least one Instantiation. A Record may have more than one Instantiation. A
    ///             re-instantiation of the record may be considered the same record or a new record,
    ///             depending on the context and of the functions that record serves. Such information may
    ///             serve a variety of purposes, though it always documents or is evidence of
    ///             Activity.</para>
    ///   <para>rdfs:label : Record</para>
    ///   <para>rdfs:comment : Information inscribed at least once by any method on any
    ///             physical carrier in any persistent, recoverable form by an Agent in the course of life
    ///             or work Activity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Record">rico:Record</a>
    /// </summary>
    let Record = _prefixId.prefix "Record"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E05 (Record Part
    ///             entity)</para>
    ///   <para>skos:scopeNote : Record Part is a kind of Record Resource. A Record Part may
    ///             itself have Record Parts.</para>
    ///   <para>rdfs:label : Record Part</para>
    ///   <para>rdfs:comment : Part of a Record with discrete information content that
    ///             contributes to the Record's physical or intellectual completeness.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RecordPart">rico:RecordPart</a>
    /// </summary>
    let RecordPart = _prefixId.prefix "RecordPart"
    /// <summary>
    ///   <para>skos:scopeNote : Producing a record resource may imply either its newly
    ///             creation or a reuse of previous existing information by combination, rearrangement,
    ///             selecting, reformatting etc. Records, Record Sets, and Record Parts are all evidence of
    ///             the activities of an Agent. More than one Agent may be involved in the creation of a
    ///             Record Resource. The role of the Agent in creating the Record Resource may take
    ///             different forms, for example, authoring of an individual record, accumulating a set of
    ///             records, or forming a set of records. Though a Record, Record Set, and Record Part,
    ///             under most circumstances, may be easily distinguished from one another, frequently
    ///             identifying the boundary of each and how the “bounded information regions” interrelate,
    ///             may present particular challenges. Documentary Forms provide the rules governing many
    ///             Records, providing criteria for identifying its boundary, and identifying its essential
    ///             Record Parts. Many Records, though, do not have well-established documentary forms,
    ///             particularly electronic records, where it may be difficult to determine whether
    ///             individual elements represented in separate bitstreams are record parts, records, or
    ///             record sets. For example, is a photograph represented independently in a bitstream
    ///             embedded in a text document a Record, or a Record Part ? Or is the same photograph
    ///             attached to an email, maintaining its independent representation, a Record or a Record
    ///             Part? When information is grouped for some purpose, for example, zip or tar “file
    ///             compression” for saving storage space, presents a further challenge. One file comprises
    ///             multiple bitstreams subjected to techniques that remove bits that can be losslessly
    ///             recovered when decompressed. Under what circumstances is such a compressed bitstream a
    ///             Record or a Record Set? Determining when an information object is a Record, Record Part,
    ///             or Record Set is based on perspective and judgement exercised in a particular context.
    ///             In one context, the Agent describing an information object may designate it a Record,
    ///             while another Agent in a different context may designate it a Record Part. Both
    ///             designations are supported by RiC, and the significance of the difference for users of
    ///             the records is ameliorated by the fact that attributes and relations employed in
    ///             describing each of the record entities are shared.</para>
    ///   <para>rdfs:label : Record Resource</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E02 (Record Resource
    ///             entity)</para>
    ///   <para>rdfs:comment : A Record, Record Set, or Record Part produced or acquired and
    ///             retained by an Agent in the course of Activity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RecordResource">rico:RecordResource</a>
    /// </summary>
    let RecordResource = _prefixId.prefix "RecordResource"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-A35 (Record Resource
    ///             extent attribute)</para>
    ///   <para>skos:scopeNote : Countable characteristics of the content of the Record
    ///             Resource expressed as a quantity.</para>
    ///   <para>rdfs:label : Record Resource Extent</para>
    ///   <para>rdfs:comment : The extent of the content of a Record Resource.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RecordResourceExtent">rico:RecordResourceExtent</a>
    /// </summary>
    let RecordResourceExtent = _prefixId.prefix "RecordResourceExtent"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R023 and RiC-023i
    ///             relations</para>
    ///   <para>rdfs:label : Record Resource Genetic Relation</para>
    ///   <para>rdfs:comment : Connects two to more Record Resources when there is a genetic
    ///             relation between them. Genetic in this sense is as defined by diplomatics, i.e. the
    ///             process by which a Record Resource is developed.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RecordResourceGeneticRelation">rico:RecordResourceGeneticRelation</a>
    /// </summary>
    let RecordResourceGeneticRelation = _prefixId.prefix "RecordResourceGeneticRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R039 and RiC-039i
    ///             relations</para>
    ///   <para>rdfs:label : Record Resource Holding Relation</para>
    ///   <para>rdfs:comment : Connects at least one Agent, and one or more Record Resource or
    ///             Instantiation that the Agent holds.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RecordResourceHoldingRelation">rico:RecordResourceHoldingRelation</a>
    /// </summary>
    let RecordResourceHoldingRelation = _prefixId.prefix "RecordResourceHoldingRelation"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R025 and RiC-R025i
    ///             relations</para>
    ///   <para>rdfs:label : Record Resource to Instantiation Relation</para>
    ///   <para>rdfs:comment : Connects a Record Resource to one or more Instantiations that
    ///             instantiate it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RecordResourceToInstantiationRelation">rico:RecordResourceToInstantiationRelation</a>
    /// </summary>
    let RecordResourceToInstantiationRelation = _prefixId.prefix "RecordResourceToInstantiationRelation"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R022 and RiC-022i
    ///             relations</para>
    ///   <para>rdfs:label : Record Resource to Record Resource Relation</para>
    ///   <para>rdfs:comment : Connects at least two Record Resources.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RecordResourceToRecordResourceRelation">rico:RecordResourceToRecordResourceRelation</a>
    /// </summary>
    let RecordResourceToRecordResourceRelation = _prefixId.prefix "RecordResourceToRecordResourceRelation"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E03 (Record Set
    ///             entity)</para>
    ///   <para>skos:scopeNote : Record Set is a kind of Record Resource. The Record members in
    ///             a Record Set may physically reside together, though physical proximity is not essential.
    ///             In a particular context, an Agent (e.g. administrator, records manager, archivist,
    ///             end-user, etc.) may select the Record members of a Record Set based on a shared
    ///             attribute or attributes, or a shared Relation or Relations. The grouping of the Records
    ///             serves a purpose or purposes specific to the context of the Agent. All Record members of
    ///             a Record Set may share the attribute of having been accumulated by the same Agent, or
    ///             all share the same Documentary Form Type and are created over time by the same Activity.
    ///             A Record Set may represent the act of classifying the Records in accordance with a
    ///             formal classification scheme that may be based on Activity, subject, organizational
    ///             structure, or other criteria; an act of archival arrangement (e.g. based on common
    ///             provenance); or some other selection and grouping that fulfils a particular purpose or
    ///             purposes (e.g. a classification that reflects or supports the purposes of a researcher).
    ///             By exception, some Records are brought together based on their not belonging in the
    ///             context of selection to other designated groups: a ‘Miscellaneous’ series, for example.
    ///             A Record Set accumulated by an Agent in the course of life or work Activity should be
    ///             kept in a manner that preserves context and evidential value. Records Sets may also
    ///             contain other Records Sets. Both a Record Set and a Record may simultaneously be a
    ///             member of more than one Record Set, and over the course of its existence, a Record Set
    ///             or Record may be a member of an indeterminate number of Record Sets in an indeterminate
    ///             number of contexts. Record Sets and Records contained within a Record Set may be ordered
    ///             into a sequence based on a common property or relation, or common properties or
    ///             relations (e.g. alphabetical by Agent or related Place name; chronological order by an
    ///             allocated Date); or some other criterion (e.g. an imposed order by
    ///             relevance).</para>
    ///   <para>rdfs:label : Record Set</para>
    ///   <para>rdfs:comment : One or more records that are associated by categorization and/or
    ///             physical aggregation by the creator or other Agent.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RecordSet">rico:RecordSet</a>
    /// </summary>
    let RecordSet = _prefixId.prefix "RecordSet"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A36 (Record Set Type
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Four instances of Record Set Type are included for now in
    ///             RiC-O; they also are instances of skos:Concept and, as such, part of a SKOS vocabulary.
    ///             Record Set Type may also be used to categorize types of Record Set that have not
    ///             traditionally been considered archival, e.g. search result list.</para>
    ///   <para>rdfs:label : Record Set Type</para>
    ///   <para>rdfs:comment : A broad categorization of the type of Record Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RecordSetType">rico:RecordSetType</a>
    /// </summary>
    let RecordSetType = _prefixId.prefix "RecordSetType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A39 (State
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Can in particular refer to a record state of development or
    ///             its status of transmission once finished (draft, original, copy...). Specifying that a
    ///             record resource has state copy usually implies that another record resource existed or
    ///             exists, of which the one described is the copy. In such a case you can also use 'is copy
    ///             of' object property.</para>
    ///   <para>rdfs:label : Record State</para>
    ///   <para>rdfs:comment : Categorization of the production or reproduction status of a
    ///             Record or Record Part.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RecordState">rico:RecordState</a>
    /// </summary>
    let RecordState = _prefixId.prefix "RecordState"
    /// <summary>
    ///   <para>skos:scopeNote : Use when direct, binary object properties are not enough, e.g.
    ///             when you need to record a date, a location or any other descriptive element for a
    ///             relation (till RDF-Star becomes a W3C recommendation and provides a lighter method for
    ///             doing so); or when the relation invloves more than two entities (n-ary relation). It is
    ///             recommended to use the subclasses of the Relation class.</para>
    ///   <para>rdfs:label : Relation</para>
    ///   <para>rdfs:comment : The top level relation class. It connects at least two Things.
    ///             An instance of a Relation may have some datatype and object properties : a descriptive
    ///             note (datatype property) like any Thing ; certainty (for 'certain', 'quite probable',
    ///             'uncertain','unknown'); a date (use either the date datatype property or the Date class
    ///             and isAssociatedWithDate object property ; a state (relationState) ; a location (use
    ///             Place class and isAssociatedWithPlace object property) ; a source of information that
    ///             can be used as an evidence for it (use either source datatype property or hasSource
    ///             object property).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Relation">rico:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A37 (Representation Type
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Representation Type can be unmediated (which allows humans to
    ///             receive the message communicated without an intermediation of a device) and mediated
    ///             (which needs a device to decode the message). A lot of contemporary mediated types are
    ///             digital. Each Representation Type may present specific features: bit rate for audio,
    ///             resolution for digital images, encoding format for video etc. Depending of the type,
    ///             properties may thus be needed to describe their characteristics. Not be confused with
    ///             Content Type or Carrier Type since the form of representation can be independent of the
    ///             communication or carrier.</para>
    ///   <para>rdfs:label : Representation Type</para>
    ///   <para>rdfs:comment : Categorization of the method of recording the content type of a
    ///             Record Resource.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RepresentationType">rico:RepresentationType</a>
    /// </summary>
    let RepresentationType = _prefixId.prefix "RepresentationType"
    /// <summary>
    ///   <para>rdfs:label : RiC-CM corresponding component</para>
    ///   <para>rdfs:comment : When it exists, specifies the identifier and name of RiC-CM
    ///             component that corresponds to the annotated class or property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RiCCMCorrespondingComponent">rico:RiCCMCorrespondingComponent</a>
    /// </summary>
    let RiCCMCorrespondingComponent = _prefixId.prefix "RiCCMCorrespondingComponent"
    /// <summary>
    ///   <para>rdfs:label : Role Type</para>
    ///   <para>rdfs:comment : The role an agent plays in some context (usually in some
    ///             creation relation). Not to be confused with a position (position of an agent in some
    ///             group). For example, a person who is the head of some corporate body may play the role
    ///             of annotator (of a record) in a creation relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RoleType">rico:RoleType</a>
    /// </summary>
    let RoleType = _prefixId.prefix "RoleType"
    /// <summary>
    ///   <para>rdfs:comment : Conditions that govern the existence or authority of an Agent or the performance of an Activity, or that contribute to the distinct characteristics of things created or managed by an Agent.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E16 (Rule
    ///             entity)</para>
    ///   <para>rdfs:label : Rule</para>
    ///   <para>skos:scopeNote : Rule can be related directly to Agent, Activity, or anything created or managed by agents, such as a Record Resource or Instantiation.
    ///             A Rule may be unwritten or written or otherwise documented. Unwritten rules may include though are not limited to the following:  social mores, customs, or community expectations. Written rules may include though are not limited to the following: constitutions, legislation, acts (legal), statutes, legal codes, ordinances, charters, mission statements, regulations, policies, procedures, instructions, codes of conduct or ethics, professional standards, work assignments or work plans.
    ///             The source or sources of some Rules are external to the Agent (for example, expressed in elections, social mores, customs, community expectations, laws, regulations, standards and best practice codes), while others are expressed within the Agent’s immediate context (for example, policies, or written or verbal instructions).
    ///             The evidence for identifying Rules may be found in their entirety in one documentary source (for example, a law or regulation) or may be found in two or more sources.
    ///             Rule should not be confused with the one or more documentary sources that serve as evidence of its identity. A documentary source is a Record.
    ///            </para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Rule">rico:Rule</a>
    /// </summary>
    let Rule = _prefixId.prefix "Rule"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R062 and RiC-R062i
    ///             relations</para>
    ///   <para>rdfs:label : Rule Relation</para>
    ///   <para>rdfs:comment : Connects at least one Rule to at least one Thing, when it is
    ///             associated with existence and lifecycle of the Thing.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RuleRelation">rico:RuleRelation</a>
    /// </summary>
    let RuleRelation = _prefixId.prefix "RuleRelation"
    /// <summary>
    ///   <para>skos:scopeNote : For example, for rules that can be applied to record resources
    ///             : access rule, use rule, etc.</para>
    ///   <para>rdfs:label : Rule Type</para>
    ///   <para>rdfs:comment : Categorization of a Rule.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#RuleType">rico:RuleType</a>
    /// </summary>
    let RuleType = _prefixId.prefix "RuleType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R008 and RiC-R008i
    ///             relations</para>
    ///   <para>rdfs:label : Sequential Relation</para>
    ///   <para>rdfs:comment : Connects at least one Thing to at least one Thing that follows
    ///             it in some sequence.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#SequentialRelation">rico:SequentialRelation</a>
    /// </summary>
    let SequentialRelation = _prefixId.prefix "SequentialRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R048 and048i
    ///             relations RiC-</para>
    ///   <para>rdfs:label : Sibling Relation</para>
    ///   <para>rdfs:comment : Connects at least two Persons, when they are
    ///             siblings.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#SiblingRelation">rico:SiblingRelation</a>
    /// </summary>
    let SiblingRelation = _prefixId.prefix "SiblingRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E19 (SingleDate
    ///             entity)</para>
    ///   <para>rdfs:label : Single Date</para>
    ///   <para>rdfs:comment : Chronological information associated with an entity that
    ///             contributes to its identification and contextualization, related to a single point in
    ///             time.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#SingleDate">rico:SingleDate</a>
    /// </summary>
    let SingleDate = _prefixId.prefix "SingleDate"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R049 and RiC-R049i
    ///             relations</para>
    ///   <para>rdfs:label : Spouse Relation</para>
    ///   <para>rdfs:comment : Connects at least two Persons, when they are
    ///             spouses.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#SpouseRelation">rico:SpouseRelation</a>
    /// </summary>
    let SpouseRelation = _prefixId.prefix "SpouseRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R053 and RiC-R053i
    ///             relation</para>
    ///   <para>rdfs:label : Teaching Relation</para>
    ///   <para>rdfs:comment : Connects at least one Person to at least another Person, who is
    ///             their student.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#TeachingRelation">rico:TeachingRelation</a>
    /// </summary>
    let TeachingRelation = _prefixId.prefix "TeachingRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R009 and RiC-R009i
    ///             relations</para>
    ///   <para>rdfs:label : Temporal Relation</para>
    ///   <para>rdfs:comment : Connects at least one Thing to at least one Thing that follows
    ///             it in chronological order.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#TemporalRelation">rico:TemporalRelation</a>
    /// </summary>
    let TemporalRelation = _prefixId.prefix "TemporalRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-E01 (Thing
    ///             entity)</para>
    ///   <para>skos:scopeNote : Includes all RiC entities as well as any concept, material
    ///             thing, or event that may be the subject of a Record Resource or associated with an
    ///             Activity. Examples of entities not explicitly addressed in RiC includes but is not
    ///             limited to the following: abstract concepts; cultural movements, named periods and
    ///             events; named things, objects and works; legendary, mythical or fictitious figures,
    ///             characters or beings.</para>
    ///   <para>rdfs:label : Thing</para>
    ///   <para>rdfs:comment : Any idea, material thing, or event within the realm of human
    ///             experience.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Thing">rico:Thing</a>
    /// </summary>
    let Thing = _prefixId.prefix "Thing"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of a specialization of
    ///             RiC-A28 (Name attribute)</para>
    ///   <para>rdfs:label : Title</para>
    ///   <para>rdfs:comment : A name that is used for a Record Resource or a
    ///             Rule</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Title">rico:Title</a>
    /// </summary>
    let Title = _prefixId.prefix "Title"
    /// <summary>
    ///   <para>rdfs:label : Type</para>
    ///   <para>rdfs:comment : A superclass for any category of some thing. A type
    ///             characterizes an entity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#Type">rico:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>skos:scopeNote : may be useful at least for some types (e.g. demographic
    ///             group)</para>
    ///   <para>rdfs:label : Type Relation</para>
    ///   <para>rdfs:comment : Connects a category (a Type) and at least one Thing that belongs
    ///             to this category.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#TypeRelation">rico:TypeRelation</a>
    /// </summary>
    let TypeRelation = _prefixId.prefix "TypeRelation"
    /// <summary>
    ///   <para>rdfs:label : Unit Of Measurement</para>
    ///   <para>rdfs:comment : A definite magnitude of a quantity, defined and adopted by convention or by
    ///             law, that is used as a standard for measurement of the same kind of quantity. Can be
    ///             spacial units (cm, m), weigt (g, kg), time (s, h), storage (MB, TB) or more informal
    ///             units used in the archival context like number of boxes, pages or words.^^xsd:string</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#UnitOfMeasurement">rico:UnitOfMeasurement</a>
    /// </summary>
    let UnitOfMeasurement = _prefixId.prefix "UnitOfMeasurement"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R002 and RiC-R002i
    ///             relations</para>
    ///   <para>rdfs:label : Whole Part Relation</para>
    ///   <para>rdfs:comment : Connects a Thing to at least one constitutive or component part
    ///             of that Thing.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#WholePartRelation">rico:WholePartRelation</a>
    /// </summary>
    let WholePartRelation = _prefixId.prefix "WholePartRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Class implementation of RiC-R046 and RiR046i
    ///             relations-</para>
    ///   <para>rdfs:label : Work Relation</para>
    ///   <para>rdfs:comment : Connects at least two Agents that have some type of work
    ///             relation in the course of their activities.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#WorkRelation">rico:WorkRelation</a>
    /// </summary>
    let WorkRelation = _prefixId.prefix "WorkRelation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : corresponds to RiC-A01 (Accrual
    ///             attribute)</para>
    ///   <para>skos:scopeNote : See also accrualStatus</para>
    ///   <para>rdfs:label : accrual</para>
    ///   <para>rdfs:comment : Information on the anticipated accession(s) to the Record
    ///             Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#accrual">rico:accrual</a>
    /// </summary>
    let accrual = _prefixId.prefix "accrual"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : corresponds to RiC-A01 (Accrual
    ///             attribute)</para>
    ///   <para>skos:scopeNote : A text statement or single words such as “Closed” to indicate
    ///             that no additional Record Resource will (or is anticipated to) be added to the Record
    ///             Set; “Open” to indicate that additional records or record sets will (or are expected to)
    ///             be added to the Record Set; or “Unknown” to indicate that this information is not
    ///             available, for example. See also accrual</para>
    ///   <para>rdfs:label : accrual status</para>
    ///   <para>rdfs:comment : Information on the status of an Accrual</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#accrualStatus">rico:accrualStatus</a>
    /// </summary>
    let accrualStatus = _prefixId.prefix "accrualStatus"
    /// <summary>
    ///   <para>rdfs:label : accumulation relation has source </para>
    ///   <para>rdfs:comment : Connects an Accumulation Relation to one of the accumulated
    ///             Record Resources or Instantiations</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#accumulationRelationHasSource">rico:accumulationRelationHasSource</a>
    /// </summary>
    let accumulationRelationHasSource = _prefixId.prefix "accumulationRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : accumulation relation has target </para>
    ///   <para>rdfs:comment : Connects an Accumulation Relation to one of the accumulating
    ///             Agents</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#accumulationRelationHasTarget">rico:accumulationRelationHasTarget</a>
    /// </summary>
    let accumulationRelationHasTarget = _prefixId.prefix "accumulationRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : activity documentation relation has source </para>
    ///   <para>rdfs:comment : Connects an Activity Documentation Relation to one of the
    ///             resulting Record Resources or Instantiations</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#activityDocumentationRelationHasSource">rico:activityDocumentationRelationHasSource</a>
    /// </summary>
    let activityDocumentationRelationHasSource = _prefixId.prefix "activityDocumentationRelationHasSource"

    /// <summary>
    ///   <para>rdfs:label : activity documentation relation has target </para>
    ///   <para>rdfs:comment : Connects an Activity Documentation Relation to one of the
    ///             documented Activities</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#activityDocumentationRelationHasTarget">rico:activityDocumentationRelationHasTarget</a>
    /// </summary>
    let activityDocumentationRelationHasTarget = _prefixId.prefix "activityDocumentationRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : activity is context of relation </para>
    ///   <para>rdfs:comment : Connects an Activity to an Agent Temporal Relation (when the
    ///             Activity is transferred from an Agent to another one) or a Mandate Relation (the Mandate
    ///             assigns the Activity to the Agent or defines it).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#activityIsContextOfRelation">rico:activityIsContextOfRelation</a>
    /// </summary>
    let activityIsContextOfRelation = _prefixId.prefix "activityIsContextOfRelation"

    /// <summary>
    ///   <para>rdfs:label : activity is source of performance relation </para>
    ///   <para>rdfs:comment : Connects an Activity that is performed to a Performance
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#activityIsSourceOfPerformanceRelation">rico:activityIsSourceOfPerformanceRelation</a>
    /// </summary>
    let activityIsSourceOfPerformanceRelation = _prefixId.prefix "activityIsSourceOfPerformanceRelation"

    /// <summary>
    ///   <para>rdfs:label : activity is target of activity documentation relation
    ///         </para>
    ///   <para>rdfs:comment : Connects an Activity to an Activity Documentation
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#activityIsTargetOfActivityDocumentationRelation">rico:activityIsTargetOfActivityDocumentationRelation</a>
    /// </summary>
    let activityIsTargetOfActivityDocumentationRelation = _prefixId.prefix "activityIsTargetOfActivityDocumentationRelation"

    /// <summary>
    ///   <para>rdfs:comment : Connects an Event to a Thing on which the Event has or had some
    ///             significant impact.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R059 ('affects or affected'
    ///             relation)</para>
    ///   <para>rdfs:label : affects or affected</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#affectsOrAffected">rico:affectsOrAffected</a>
    /// </summary>
    let affectsOrAffected = _prefixId.prefix "affectsOrAffected"
    /// <summary>
    ///   <para>rdfs:label : agent control relation has source </para>
    ///   <para>rdfs:comment : Connects an Agent Control Relation to one of the controlling
    ///             Agents</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentControlRelationHasSource">rico:agentControlRelationHasSource</a>
    /// </summary>
    let agentControlRelationHasSource = _prefixId.prefix "agentControlRelationHasSource"
    /// <summary>
    ///   <para>rdfs:comment : Connects an Agent Control Relation to one of the controlled
    ///             Agents</para>
    ///   <para>rico:RiCCMCorrespondingComponent : s</para>
    ///   <para>rdfs:label : agent control relation has target </para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentControlRelationHasTarget">rico:agentControlRelationHasTarget</a>
    /// </summary>
    let agentControlRelationHasTarget = _prefixId.prefix "agentControlRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : agent has work relation </para>
    ///   <para>rdfs:comment : Connects an Agent to a Work Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentHasWorkRelation">rico:agentHasWorkRelation</a>
    /// </summary>
    let agentHasWorkRelation = _prefixId.prefix "agentHasWorkRelation"

    /// <summary>
    ///   <para>rdfs:label : agent hierarchical relation has source </para>
    ///   <para>rdfs:comment : Connects an Agent Hierarchical Relation to one of the
    ///             hierarchically superior Agents</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentHierarchicalRelationHasSource">rico:agentHierarchicalRelationHasSource</a>
    /// </summary>
    let agentHierarchicalRelationHasSource = _prefixId.prefix "agentHierarchicalRelationHasSource"

    /// <summary>
    ///   <para>rdfs:label : agent hierarchical relation has target </para>
    ///   <para>rdfs:comment : Connects an Agent Hierarchical Relation to one of the
    ///             hierarchically inferior Agents</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentHierarchicalRelationHasTarget">rico:agentHierarchicalRelationHasTarget</a>
    /// </summary>
    let agentHierarchicalRelationHasTarget = _prefixId.prefix "agentHierarchicalRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : agent is connected to agent relation </para>
    ///   <para>rdfs:comment : Connects an Agent to an Agent Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsConnectedToAgentRelation">rico:agentIsConnectedToAgentRelation</a>
    /// </summary>
    let agentIsConnectedToAgentRelation = _prefixId.prefix "agentIsConnectedToAgentRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is source of agent control relation </para>
    ///   <para>rdfs:comment : Connects a controlling Agent to an Agent Control
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentControlRelation">rico:agentIsSourceOfAgentControlRelation</a>
    /// </summary>
    let agentIsSourceOfAgentControlRelation = _prefixId.prefix "agentIsSourceOfAgentControlRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is source of agent hierarchical relation </para>
    ///   <para>rdfs:comment : Connects a hierarchically superior Agent to an Agent
    ///             Hierarchical Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentHierarchicalRelation">rico:agentIsSourceOfAgentHierarchicalRelation</a>
    /// </summary>
    let agentIsSourceOfAgentHierarchicalRelation = _prefixId.prefix "agentIsSourceOfAgentHierarchicalRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is source of agent temporal relation </para>
    ///   <para>rdfs:comment : Connects a predecessor Agent to an Agent Temporal
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentTemporalRelation">rico:agentIsSourceOfAgentTemporalRelation</a>
    /// </summary>
    let agentIsSourceOfAgentTemporalRelation = _prefixId.prefix "agentIsSourceOfAgentTemporalRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is source of authority relation </para>
    ///   <para>rdfs:comment : Connects an Agent thas has the authority, to an Authority
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAuthorityRelation">rico:agentIsSourceOfAuthorityRelation</a>
    /// </summary>
    let agentIsSourceOfAuthorityRelation = _prefixId.prefix "agentIsSourceOfAuthorityRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is source of intellectual property rights relation
    ///         </para>
    ///   <para>rdfs:comment : Connects an Agent having the intellectual property rights, to an
    ///             Intellectual Property Rights Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfIntellectualPropertyRightsRelation">rico:agentIsSourceOfIntellectualPropertyRightsRelation</a>
    /// </summary>
    let agentIsSourceOfIntellectualPropertyRightsRelation = _prefixId.prefix "agentIsSourceOfIntellectualPropertyRightsRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is source of management relation </para>
    ///   <para>rdfs:comment : Connects a manager Agent to a Management Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfManagementRelation">rico:agentIsSourceOfManagementRelation</a>
    /// </summary>
    let agentIsSourceOfManagementRelation = _prefixId.prefix "agentIsSourceOfManagementRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is source of ownership relation </para>
    ///   <para>rdfs:comment : Connects an owner Agent to an Ownership Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfOwnershipRelation">rico:agentIsSourceOfOwnershipRelation</a>
    /// </summary>
    let agentIsSourceOfOwnershipRelation = _prefixId.prefix "agentIsSourceOfOwnershipRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is source of record resource holding relation </para>
    ///   <para>rdfs:comment : Connects an Agent that holds a Record Resource or Instantiation,
    ///             to a Record Resource Holding Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfRecordResourceHoldingRelation">rico:agentIsSourceOfRecordResourceHoldingRelation</a>
    /// </summary>
    let agentIsSourceOfRecordResourceHoldingRelation = _prefixId.prefix "agentIsSourceOfRecordResourceHoldingRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is target of accumulation relation </para>
    ///   <para>rdfs:comment : Connects one of the accumulating Agents to an Accumulation
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAccumulationRelation">rico:agentIsTargetOfAccumulationRelation</a>
    /// </summary>
    let agentIsTargetOfAccumulationRelation = _prefixId.prefix "agentIsTargetOfAccumulationRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is target of agent control relation </para>
    ///   <para>rdfs:comment : Connects one of the controlled Agents to an Agent Control
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentControlRelation">rico:agentIsTargetOfAgentControlRelation</a>
    /// </summary>
    let agentIsTargetOfAgentControlRelation = _prefixId.prefix "agentIsTargetOfAgentControlRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is target of agent hierarchical relation </para>
    ///   <para>rdfs:comment : Connects one of the hierarchically inferior Agents to an Agent
    ///             Hierarchical Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentHierarchicalRelation">rico:agentIsTargetOfAgentHierarchicalRelation</a>
    /// </summary>
    let agentIsTargetOfAgentHierarchicalRelation = _prefixId.prefix "agentIsTargetOfAgentHierarchicalRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is target of agent origination relation </para>
    ///   <para>rdfs:comment : Connects one of the Agents that created or accumulated the
    ///             Record resource or Instantiation, to an Agent Origination Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentOriginationRelation">rico:agentIsTargetOfAgentOriginationRelation</a>
    /// </summary>
    let agentIsTargetOfAgentOriginationRelation = _prefixId.prefix "agentIsTargetOfAgentOriginationRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is target of agent temporal relation </para>
    ///   <para>rdfs:comment : Connects a successor Agent to an Agent Temporal
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentTemporalRelation">rico:agentIsTargetOfAgentTemporalRelation</a>
    /// </summary>
    let agentIsTargetOfAgentTemporalRelation = _prefixId.prefix "agentIsTargetOfAgentTemporalRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is target of authorship relation</para>
    ///   <para>rdfs:comment : Connects a Person, Group or Position to an Authorship
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAuthorshipRelation">rico:agentIsTargetOfAuthorshipRelation</a>
    /// </summary>
    let agentIsTargetOfAuthorshipRelation = _prefixId.prefix "agentIsTargetOfAuthorshipRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is target of creation relation </para>
    ///   <para>rdfs:comment : Connects a creator Agent to a Creation Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfCreationRelation">rico:agentIsTargetOfCreationRelation</a>
    /// </summary>
    let agentIsTargetOfCreationRelation = _prefixId.prefix "agentIsTargetOfCreationRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is target of mandate relation </para>
    ///   <para>rdfs:comment : Connects a mandated Agent to a Mandate Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfMandateRelation">rico:agentIsTargetOfMandateRelation</a>
    /// </summary>
    let agentIsTargetOfMandateRelation = _prefixId.prefix "agentIsTargetOfMandateRelation"

    /// <summary>
    ///   <para>rdfs:label : agent is target of performance relation </para>
    ///   <para>rdfs:comment : Connects an Agent to a Performance Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfPerformanceRelation">rico:agentIsTargetOfPerformanceRelation</a>
    /// </summary>
    let agentIsTargetOfPerformanceRelation = _prefixId.prefix "agentIsTargetOfPerformanceRelation"

    /// <summary>
    ///   <para>rdfs:label : agent or activity is target of provenance relation </para>
    ///   <para>rdfs:comment : Connects an Agent or Activity that is the provenance of a Record
    ///             resource or Instantiation, to a Provenance Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentOrActivityIsTargetOfProvenanceRelation">rico:agentOrActivityIsTargetOfProvenanceRelation</a>
    /// </summary>
    let agentOrActivityIsTargetOfProvenanceRelation = _prefixId.prefix "agentOrActivityIsTargetOfProvenanceRelation"

    /// <summary>
    ///   <para>rdfs:label : agent origination relation has source </para>
    ///   <para>rdfs:comment : Connects an Agent Origination Relation to one of the resulting
    ///             Record Resource or Instantiation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentOriginationRelationHasSource">rico:agentOriginationRelationHasSource</a>
    /// </summary>
    let agentOriginationRelationHasSource = _prefixId.prefix "agentOriginationRelationHasSource"

    /// <summary>
    ///   <para>rdfs:label : agent origination relation has target </para>
    ///   <para>rdfs:comment : Connects an Agent Origination Relation to one of the creating or
    ///             accumulating Agents</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentOriginationRelationHasTarget">rico:agentOriginationRelationHasTarget</a>
    /// </summary>
    let agentOriginationRelationHasTarget = _prefixId.prefix "agentOriginationRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : agent relation connects </para>
    ///   <para>rdfs:comment : Connects an Agent Relation to one of the involved
    ///             Agents</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentRelationConnects">rico:agentRelationConnects</a>
    /// </summary>
    let agentRelationConnects = _prefixId.prefix "agentRelationConnects"

    /// <summary>
    ///   <para>rdfs:label : agent temporal relation has source </para>
    ///   <para>rdfs:comment : Connects an Agent Temporal Relation to one of the predecessor
    ///             Agents</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentTemporalRelationHasSource">rico:agentTemporalRelationHasSource</a>
    /// </summary>
    let agentTemporalRelationHasSource = _prefixId.prefix "agentTemporalRelationHasSource"

    /// <summary>
    ///   <para>rdfs:label : agent temporal relation has target </para>
    ///   <para>rdfs:comment : Connects an Agent Temporal Relation to one of the successor
    ///             Agents</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#agentTemporalRelationHasTarget">rico:agentTemporalRelationHasTarget</a>
    /// </summary>
    let agentTemporalRelationHasTarget = _prefixId.prefix "agentTemporalRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : altimetric system</para>
    ///   <para>rdfs:comment : Reference system used for altitude</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#altimetricSystem">rico:altimetricSystem</a>
    /// </summary>
    let altimetricSystem = _prefixId.prefix "altimetricSystem"
    /// <summary>
    ///   <para>skos:scopeNote : Property of the Coordinates class. If you don't use this
    ///             class, use geographicalCoordinates property, a property of Place class.</para>
    ///   <para>rdfs:label : altitude</para>
    ///   <para>rdfs:comment : The height of a Place above a reference level, especially above
    ///             sea level.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#altitude">rico:altitude</a>
    /// </summary>
    let altitude = _prefixId.prefix "altitude"

    /// <summary>
    ///   <para>rdfs:label : appellation is source of appellation relation </para>
    ///   <para>rdfs:comment : Connects an Appellation to an Appellation
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#appellationIsSourceOfAppellationRelation">rico:appellationIsSourceOfAppellationRelation</a>
    /// </summary>
    let appellationIsSourceOfAppellationRelation = _prefixId.prefix "appellationIsSourceOfAppellationRelation"

    /// <summary>
    ///   <para>rdfs:label : appellation relation has source </para>
    ///   <para>rdfs:comment : Connects an Appellation Relation to the concerned
    ///             Appellation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#appellationRelationHasSource">rico:appellationRelationHasSource</a>
    /// </summary>
    let appellationRelationHasSource = _prefixId.prefix "appellationRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : appellation relation has target </para>
    ///   <para>rdfs:comment : Connects an Appellation Relation to one of the designated
    ///             Things</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#appellationRelationHasTarget">rico:appellationRelationHasTarget</a>
    /// </summary>
    let appellationRelationHasTarget = _prefixId.prefix "appellationRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : as concerns activity </para>
    ///   <para>rdfs:comment : Connects an Agent Temporal Relation or Mandate Relation, to an
    ///             Activity that is, either transferred from an Agent to another one, or assigned by a
    ///             Mandate to an Agent.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#asConcernsActivity">rico:asConcernsActivity</a>
    /// </summary>
    let asConcernsActivity = _prefixId.prefix "asConcernsActivity"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A03 (Authenticity Note
    ///             attribute)</para>
    ///   <para>skos:scopeNote : For electronic records, it may include results from automated
    ///             means of checking the validity of signatures and timestamp.</para>
    ///   <para>skos:example : The electronic signature validity cannot by assessed, but the
    ///             content was not modified from the moment of signing.skos:example : The record bears no signature.skos:example : The record is digitally signed by the Notary.skos:example : The record bears signatures and it was preserved.skos:example : The charter is missing the seal of the King.skos:example : The timestamp exists but cannot be verified.skos:example : The whole collection consists of copies of the charters issued
    ///             by Vlad the Impaler.</para>
    ///   <para>rdfs:comment : Description of evidences that the Record Resource or
    ///             Instantiation is what it purports to be, was created or sent by the said Agent, at the
    ///             said time and has not been tampered or corrupted.</para>
    ///   <para>rdfs:label : authenticity note</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#authenticityNote">rico:authenticityNote</a>
    /// </summary>
    let authenticityNote = _prefixId.prefix "authenticityNote"
    /// <summary>
    ///   <para>rdfs:label : authority relation has source </para>
    ///   <para>rdfs:comment : Connects an Authority Relation to an Agent that has the
    ///             authority</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#authorityRelationHasSource">rico:authorityRelationHasSource</a>
    /// </summary>
    let authorityRelationHasSource = _prefixId.prefix "authorityRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : authority relation has target </para>
    ///   <para>rdfs:comment : Connects an Authority Relation to a Thing over which the
    ///             Authority is performed</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#authorityRelationHasTarget">rico:authorityRelationHasTarget</a>
    /// </summary>
    let authorityRelationHasTarget = _prefixId.prefix "authorityRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'authorizes' object property</para>
    ///   <para>rdfs:label : authorized by </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R067i ('authorizedBy'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#authorizedBy">rico:authorizedBy</a>
    /// </summary>
    let authorizedBy = _prefixId.prefix "authorizedBy"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Mandate to the Agent that the Mandate gives the
    ///             authority or competencies to act.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R067 ('authorizes'
    ///             relation)</para>
    ///   <para>rdfs:label : authorizes</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#authorizes">rico:authorizes</a>
    /// </summary>
    let authorizes = _prefixId.prefix "authorizes"
    /// <summary>
    ///   <para>rdfs:label : authorizing agent </para>
    ///   <para>rdfs:comment : Connects a Mandate Relation to an Agent that assigns the
    ///             Mandate.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#authorizingAgent">rico:authorizingAgent</a>
    /// </summary>
    let authorizingAgent = _prefixId.prefix "authorizingAgent"
    /// <summary>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use the Mandate class for handling
    ///             mandates.</para>
    ///   <para>rdfs:label : authorizing mandate</para>
    ///   <para>rdfs:comment : Information on a Mandate that authorizes an Agent to perform an
    ///             Activity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#authorizingMandate">rico:authorizingMandate</a>
    /// </summary>
    let authorizingMandate = _prefixId.prefix "authorizingMandate"
    /// <summary>
    ///   <para>rdfs:label : authorship relation has source</para>
    ///   <para>rdfs:comment : Connects an Authorship Relation to one of the Records involved
    ///             in the relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#authorshipRelationHasSource">rico:authorshipRelationHasSource</a>
    /// </summary>
    let authorshipRelationHasSource = _prefixId.prefix "authorshipRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : authorship relation has target</para>
    ///   <para>rdfs:comment : Connects an Authorship Relation to one of the author Person,
    ///             Group or Position.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#authorshipRelationHasTarget">rico:authorshipRelationHasTarget</a>
    /// </summary>
    let authorshipRelationHasTarget = _prefixId.prefix "authorshipRelationHasTarget"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : beginning date</para>
    ///   <para>rdfs:comment : Date at which something began.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#beginningDate">rico:beginningDate</a>
    /// </summary>
    let beginningDate = _prefixId.prefix "beginningDate"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : birth date</para>
    ///   <para>rdfs:comment : Date at which a Person was born.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#birthDate">rico:birthDate</a>
    /// </summary>
    let birthDate = _prefixId.prefix "birthDate"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Specialization of RiC-A14 (Date Standard
    ///             attribute)</para>
    ///   <para>rdfs:label : calendar</para>
    ///   <para>rdfs:comment : Used system of reckoning time in which the beginning, length,
    ///             and divisions of a year are defined, sometimes along with multiyear
    ///             cycles.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#calendar">rico:calendar</a>
    /// </summary>
    let calendar = _prefixId.prefix "calendar"
    /// <summary>
    ///   <para>skos:example : 2 pieces of parchment, 30 x 50 cm and 32,5 x 49
    ///             cmskos:example : 3GB USB keyskos:example : 1 pageskos:example : 17 x 34.5 cm</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A04 (Carrier Extent
    ///             attribute)</para>
    ///   <para>rdfs:comment : Number of physical units and/or physical dimensions of the
    ///             carrier of a record resource instantiation. Various carriers, depending on specific
    ///             needs, may have more than one relevant dimension. In some cases, indicating the number
    ///             of physical units may be sufficient, while in other case, relevant dimensions should be
    ///             used in order to characterize the carrier.</para>
    ///   <para>skos:scopeNote : For electronic resources, it indicates the size of storage
    ///             capacity (disk, tape, film etc.). Carrier Extent should not be confused with Record
    ///             Resource Extent or Instantiation Extent. For a given Record Resource, the Instantiation
    ///             Extent may vary, based on format, density of information on the carrier, etc. For
    ///             example, 1500 words (Record Resource Extent) may have Instantiation Extent 3kb as a Word
    ///             document and 5kb as a PDF file, and instantiations may be represented on a CD of 700mb
    ///             (Carrier Extent). Use if you don't use CarrierExtent class and its properties for
    ///             handling such information.</para>
    ///   <para>rdfs:label : carrier extent</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#carrierExtent">rico:carrierExtent</a>
    /// </summary>
    let carrierExtent = _prefixId.prefix "carrierExtent"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A06 (Certainty
    ///             attribute)</para>
    ///   <para>rdfs:label : certainty</para>
    ///   <para>rdfs:comment : Qualifies the level of certitude of the accuracy of a Date, an
    ///             Event or a Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#certainty">rico:certainty</a>
    /// </summary>
    let certainty = _prefixId.prefix "certainty"
    /// <summary>
    ///   <para>rdfs:label : child relation has source </para>
    ///   <para>rdfs:comment : Connects a Child Relation to a parent Person</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#childRelationHasSource">rico:childRelationHasSource</a>
    /// </summary>
    let childRelationHasSource = _prefixId.prefix "childRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : child relation has target </para>
    ///   <para>rdfs:comment : Connects a Child Relation to a child Person</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#childRelationHasTarget">rico:childRelationHasTarget</a>
    /// </summary>
    let childRelationHasTarget = _prefixId.prefix "childRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:comment : A term, number or alphanumeric string that is usually taken from
    ///             an external classification vocabulary or scheme that qualifies the Record
    ///             Resource.</para>
    ///   <para>skos:example : human resource managementskos:example : BUD-01-F002 [example of a classification number from a corporate
    ///             file plan]skos:example : financial affairsskos:example : student registrationskos:example : digitized items</para>
    ///   <para>skos:scopeNote : No further statement is made here about the nature of the
    ///             qualifier, nor about the relation it has with the Record Resource or with the management
    ///             of the Record Resource. The value of this property may in turn be used as a criterion
    ///             for identifying the qualified Record Resource as a member of a Record
    ///             Set.</para>
    ///   <para>rdfs:label : classification</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A07 (Classification
    ///             attribute)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#classification">rico:classification</a>
    /// </summary>
    let classification = _prefixId.prefix "classification"
    /// <summary>
    ///   <para>rdfs:label : close to</para>
    ///   <para>rdfs:comment : An annotation property for recording a possible mapping to a
    ///             component in another model or ontology</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#closeTo">rico:closeTo</a>
    /// </summary>
    let closeTo = _prefixId.prefix "closeTo"
    /// <summary>
    ///   <para>rdfs:label : conditions of access</para>
    ///   <para>skos:example : Acceso libre a través de los terminales de
    ///             consultaskos:example : Recognita software, min. version 3.0, is needed in order to open
    ///             the file.skos:example : the Archives cannot provide VHS reader to access the content of
    ///             the tape.skos:example : closed as awaiting conservation treatmentskos:example : closed under data protection legislationskos:example : open</para>
    ///   <para>skos:scopeNote : This property provides information about the accessibility of
    ///             a Record Resource, as well as the physical, technical or legal limitations that exist
    ///             for providing access to it.</para>
    ///   <para>rdfs:comment : Terms and circumstances affecting the availability of a Record
    ///             Resource for consultation. Such conditions may originate in laws, regulations and
    ///             policies, including those pertaining to privacy and security concerns or restrictions;
    ///             they may concern a specific Instantiation of a Record Resource, for example, conditions
    ///             that require preservation treatment; or they may specify the software or hardware
    ///             necessary to access the Instantiation.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A08 (Conditions of Access
    ///             attribute)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#conditionsOfAccess">rico:conditionsOfAccess</a>
    /// </summary>
    let conditionsOfAccess = _prefixId.prefix "conditionsOfAccess"
    /// <summary>
    ///   <para>skos:example : Freely usable without restrictionsskos:example : The permission of the owner of the Record must be obtained
    ///             before use.skos:example : The record cannot be copied using warm light copying machines or
    ///             photographed using flashlight.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A09 (Conditions of Use
    ///             attribute)</para>
    ///   <para>rdfs:label : conditions of use</para>
    ///   <para>rdfs:comment : Terms and circumstances affecting the use of a Record Resource
    ///             after access has been provided. Includes conditions governing reproduction of the Record
    ///             Resource under applicable copyright (intellectual property) and/or property legislation,
    ///             and of the Instantiation, due to conservation status.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#conditionsOfUse">rico:conditionsOfUse</a>
    /// </summary>
    let conditionsOfUse = _prefixId.prefix "conditionsOfUse"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Place to a region that is or was within
    ///             it.</para>
    ///   <para>rdfs:label : contains or contained</para>
    ///   <para>skos:scopeNote : Use for connecting two geographical or administrative
    ///             regions.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R007 ('contains or contained'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#containsOrContained">rico:containsOrContained</a>
    /// </summary>
    let containsOrContained = _prefixId.prefix "containsOrContained"

    /// <summary>
    ///   <para>rdfs:label : correspondence relation connects </para>
    ///   <para>rdfs:comment : Connects a Correspondence Relation to one of the Persons
    ///             involved</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#correspondenceRelationConnects">rico:correspondenceRelationConnects</a>
    /// </summary>
    let correspondenceRelationConnects = _prefixId.prefix "correspondenceRelationConnects"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : creation date</para>
    ///   <para>rdfs:comment : Date at which an entity was created.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#creationDate">rico:creationDate</a>
    /// </summary>
    let creationDate = _prefixId.prefix "creationDate"
    /// <summary>
    ///   <para>rdfs:label : creation relation has source </para>
    ///   <para>rdfs:comment : Connects a Creation Relation to one of the created Record
    ///             Resources or Instantiations</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#creationRelationHasSource">rico:creationRelationHasSource</a>
    /// </summary>
    let creationRelationHasSource = _prefixId.prefix "creationRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : creation relation has target </para>
    ///   <para>rdfs:comment : Connects a Creation Relation to one of the creator
    ///             Agents</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#creationRelationHasTarget">rico:creationRelationHasTarget</a>
    /// </summary>
    let creationRelationHasTarget = _prefixId.prefix "creationRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : creation with role </para>
    ///   <para>rdfs:comment : Connects a Creation Relation to the Role Type that the creator
    ///             Agent(s) has in the creation process</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#creationWithRole">rico:creationWithRole</a>
    /// </summary>
    let creationWithRole = _prefixId.prefix "creationWithRole"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property implementation of RiC-E18 (Date
    ///             entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons, like its subproperties. May be
    ///             deprecated and removed later on. Use only if you don't use Date classes for handling
    ///             dates.</para>
    ///   <para>rdfs:label : date</para>
    ///   <para>rdfs:comment : Chronological information associated with an entity that
    ///             contributes to its identification and contextualization.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#date">rico:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A13 (Date Qualifier
    ///             attribute)</para>
    ///   <para>skos:example : duringskos:example : exactskos:example : circa</para>
    ///   <para>rdfs:comment : Indicates the precision of a date. It specifies if, and to what
    ///             extent, the value is an estimation.</para>
    ///   <para>rdfs:label : date qualifier</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#dateQualifier">rico:dateQualifier</a>
    /// </summary>
    let dateQualifier = _prefixId.prefix "dateQualifier"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A14 (Date Standard
    ///             attribute)</para>
    ///   <para>rdfs:label : date standard</para>
    ///   <para>skos:example : ISO8601skos:example : IETF</para>
    ///   <para>rdfs:comment : Identifier of the standard of the Normalized
    ///             date.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#dateStandard">rico:dateStandard</a>
    /// </summary>
    let dateStandard = _prefixId.prefix "dateStandard"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : death date</para>
    ///   <para>rdfs:comment : Date at which a Person died.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#deathDate">rico:deathDate</a>
    /// </summary>
    let deathDate = _prefixId.prefix "deathDate"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : deletion date</para>
    ///   <para>rdfs:comment : Date at which an entity was deleted.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#deletionDate">rico:deletionDate</a>
    /// </summary>
    let deletionDate = _prefixId.prefix "deletionDate"
    /// <summary>
    ///   <para>rdfs:label : derivation relation has source </para>
    ///   <para>rdfs:comment : Connects a Derivation Relation to the Instantiation from which
    ///             one or more Instantiations is derived.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#derivationRelationHasSource">rico:derivationRelationHasSource</a>
    /// </summary>
    let derivationRelationHasSource = _prefixId.prefix "derivationRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : derivation relation has target </para>
    ///   <para>rdfs:comment : Connects a Derivation Relation to one of the derived
    ///             Instantiations</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#derivationRelationHasTarget">rico:derivationRelationHasTarget</a>
    /// </summary>
    let derivationRelationHasTarget = _prefixId.prefix "derivationRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : descendance relation has source </para>
    ///   <para>rdfs:comment : Connects a Descendance Relation to one of the ancestor
    ///             Persons</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#descendanceRelationHasSource">rico:descendanceRelationHasSource</a>
    /// </summary>
    let descendanceRelationHasSource = _prefixId.prefix "descendanceRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : descendance relation has target </para>
    ///   <para>rdfs:comment : Connects a Descendance Relation to one of the descendant
    ///             Persons</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#descendanceRelationHasTarget">rico:descendanceRelationHasTarget</a>
    /// </summary>
    let descendanceRelationHasTarget = _prefixId.prefix "descendanceRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : describes or described</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R021 (describes or
    ///             described)</para>
    ///   <para>rdfs:comment : Connects a Record Resource to a Thing that it
    ///             describes.</para>
    ///   <para>skos:scopeNote : Can be used, among other situations, for specifying that some
    ///             finding aid (a Record that has Documentary Form Type Finding Aid) describes some Record
    ///             Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#describesOrDescribed">rico:describesOrDescribed</a>
    /// </summary>
    let describesOrDescribed = _prefixId.prefix "describesOrDescribed"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A16 (Descriptive Note
    ///             attribute)</para>
    ///   <para>rdfs:label : descriptive note</para>
    ///   <para>rdfs:comment : Descriptive information about an entity that is not otherwise
    ///             addressed.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#descriptiveNote">rico:descriptiveNote</a>
    /// </summary>
    let descriptiveNote = _prefixId.prefix "descriptiveNote"
    /// <summary>
    ///   <para>rdfs:label : documented by</para>
    ///   <para>rdfs:comment : Inverse of 'documents' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R033i ('documented by'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#documentedBy">rico:documentedBy</a>
    /// </summary>
    let documentedBy = _prefixId.prefix "documentedBy"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Record Resource or an Instantiation to the Activity
    ///             that generates the Record Resource or Instantiation.</para>
    ///   <para>rdfs:label : documents</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R033 ('documents'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#documents">rico:documents</a>
    /// </summary>
    let documents = _prefixId.prefix "documents"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : end date</para>
    ///   <para>rdfs:comment : Date at which something ended.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#endDate">rico:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:label : event is source of event relation </para>
    ///   <para>rdfs:comment : Connects an Event to an Event Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#eventIsSourceOfEventRelation">rico:eventIsSourceOfEventRelation</a>
    /// </summary>
    let eventIsSourceOfEventRelation = _prefixId.prefix "eventIsSourceOfEventRelation"
    /// <summary>
    ///   <para>rdfs:label : event relation has source </para>
    ///   <para>rdfs:comment : Connects an Event Relation to an Event</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#eventRelationHasSource">rico:eventRelationHasSource</a>
    /// </summary>
    let eventRelationHasSource = _prefixId.prefix "eventRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : event relation has target </para>
    ///   <para>rdfs:comment : Connects an Event Relation to an associated Thing</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#eventRelationHasTarget">rico:eventRelationHasTarget</a>
    /// </summary>
    let eventRelationHasTarget = _prefixId.prefix "eventRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : exists or existed in</para>
    ///   <para>rdfs:comment : Connects a Position to a Group in which that Position exists or
    ///             existed, or that is defined by that Group�s organizational structure.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R056 ('exists or existed in'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#existsOrExistedIn">rico:existsOrExistedIn</a>
    /// </summary>
    let existsOrExistedIn = _prefixId.prefix "existsOrExistedIn"
    /// <summary>
    ///   <para>skos:example : 1925-1966skos:example : The Sunday before Christmasskos:example : October 24th, 1999</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A19 (Expressed Date
    ///             attribute)</para>
    ///   <para>rdfs:label : expressed date</para>
    ///   <para>rdfs:comment : Natural language expression of a Date.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#expressedDate">rico:expressedDate</a>
    /// </summary>
    let expressedDate = _prefixId.prefix "expressedDate"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'is or was expressed by' object
    ///             property.</para>
    ///   <para>rdfs:label : expresses or expressed</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R064i ('expresses or expressed'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#expressesOrExpressed">rico:expressesOrExpressed</a>
    /// </summary>
    let expressesOrExpressed = _prefixId.prefix "expressesOrExpressed"
    /// <summary>
    ///   <para>rdfs:label : family relation connects </para>
    ///   <para>rdfs:comment : Connects a Family Relation to a Person.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#familyRelationConnects">rico:familyRelationConnects</a>
    /// </summary>
    let familyRelationConnects = _prefixId.prefix "familyRelationConnects"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'precedes in time' object property.</para>
    ///   <para>rdfs:label : follows in time</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R009i ('follows in time'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#followsInTime">rico:followsInTime</a>
    /// </summary>
    let followsInTime = _prefixId.prefix "followsInTime"
    /// <summary>
    ///   <para>rdfs:label : follows or followed</para>
    ///   <para>rdfs:comment : Inverse of 'precedesOrPreceded' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R008i ('follows or followed'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#followsOrFollowed">rico:followsOrFollowed</a>
    /// </summary>
    let followsOrFollowed = _prefixId.prefix "followsOrFollowed"

    /// <summary>
    ///   <para>rdfs:label : functional equivalence relation connects </para>
    ///   <para>rdfs:comment : Connects a Functional Equivalence Relation to one of the
    ///             functionally equivalent Instantiations.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#functionalEquivalenceRelationConnects">rico:functionalEquivalenceRelationConnects</a>
    /// </summary>
    let functionalEquivalenceRelationConnects = _prefixId.prefix "functionalEquivalenceRelationConnects"

    /// <summary>
    ///   <para>rdfs:label : geodesic system</para>
    ///   <para>rdfs:comment : Reference system used for geographical
    ///             coordinates.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#geodesicSystem">rico:geodesicSystem</a>
    /// </summary>
    let geodesicSystem = _prefixId.prefix "geodesicSystem"
    /// <summary>
    ///   <para>rdfs:label : geographical coordinates</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A11 (Coordinates
    ///             attribute)</para>
    ///   <para>skos:example : Latitude 35.89421911, Longitude 139.94637467skos:example : Latitude 50°40′46,461″N, Longitude 95°48′26,533″W, Height
    ///             123,45m</para>
    ///   <para>rdfs:comment : Longitudinal and latitudinal information of a
    ///             Place.</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use PhysicalLocation and Coordinates classes with Place.
    ///             Coordinates may be based on ISO 6709 Standard representation of geographic point
    ///             location by coordinates.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#geographicalCoordinates">rico:geographicalCoordinates</a>
    /// </summary>
    let geographicalCoordinates = _prefixId.prefix "geographicalCoordinates"

    /// <summary>
    ///   <para>rdfs:label : group is source of group subdivision relation </para>
    ///   <para>rdfs:comment : Connects the Group that has at least a subdivision, to a Group
    ///             Subdivision Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#groupIsSourceOfGroupSubdivisionRelation">rico:groupIsSourceOfGroupSubdivisionRelation</a>
    /// </summary>
    let groupIsSourceOfGroupSubdivisionRelation = _prefixId.prefix "groupIsSourceOfGroupSubdivisionRelation"

    /// <summary>
    ///   <para>rdfs:label : group is source of membership relation </para>
    ///   <para>rdfs:comment : Connects the Group (that has one to many members) to a
    ///             Membership Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#groupIsSourceOfMembershipRelation">rico:groupIsSourceOfMembershipRelation</a>
    /// </summary>
    let groupIsSourceOfMembershipRelation = _prefixId.prefix "groupIsSourceOfMembershipRelation"

    /// <summary>
    ///   <para>rdfs:label : group is target of group subdivision relation </para>
    ///   <para>rdfs:comment : Connects a Group that is a subdivision, to a Group Subdivision
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfGroupSubdivisionRelation">rico:groupIsTargetOfGroupSubdivisionRelation</a>
    /// </summary>
    let groupIsTargetOfGroupSubdivisionRelation = _prefixId.prefix "groupIsTargetOfGroupSubdivisionRelation"

    /// <summary>
    ///   <para>rdfs:label : group is target of leadership relation </para>
    ///   <para>rdfs:comment : Connects a Group (which has a leader) to a Leadership
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfLeadershipRelation">rico:groupIsTargetOfLeadershipRelation</a>
    /// </summary>
    let groupIsTargetOfLeadershipRelation = _prefixId.prefix "groupIsTargetOfLeadershipRelation"

    /// <summary>
    ///   <para>rdfs:label : group is target of position to group relation </para>
    ///   <para>rdfs:comment : Connects the Group (in which a Position exists) to a Position To
    ///             Group Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfPositionToGroupRelation">rico:groupIsTargetOfPositionToGroupRelation</a>
    /// </summary>
    let groupIsTargetOfPositionToGroupRelation = _prefixId.prefix "groupIsTargetOfPositionToGroupRelation"

    /// <summary>
    ///   <para>rdfs:label : group subdivision relation has source </para>
    ///   <para>rdfs:comment : Connects a Group Subdivision Relation to the Group that has
    ///             subdivisions</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#groupSubdivisionRelationHasSource">rico:groupSubdivisionRelationHasSource</a>
    /// </summary>
    let groupSubdivisionRelationHasSource = _prefixId.prefix "groupSubdivisionRelationHasSource"

    /// <summary>
    ///   <para>rdfs:label : group subdivision relation has target </para>
    ///   <para>rdfs:comment : Connects a Group Subdivision Relation to one of the Groups that
    ///             is a subdivision</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#groupSubdivisionRelationHasTarget">rico:groupSubdivisionRelationHasTarget</a>
    /// </summary>
    let groupSubdivisionRelationHasTarget = _prefixId.prefix "groupSubdivisionRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:comment : Connects a Record Resource or an Instantiation to the Agent that
    ///             accumulates it, be it intentionally (collecting) or not (receiving in the course of its
    ///             activities).</para>
    ///   <para>rdfs:label : has accumulator</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R028 ('has accumulator'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasAccumulator">rico:hasAccumulator</a>
    /// </summary>
    let hasAccumulator = _prefixId.prefix "hasAccumulator"
    /// <summary>
    ///   <para>rdfs:label : has activity type</para>
    ///   <para>rdfs:comment : Connects an Activity to an Activity Type that categorizes
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasActivityType">rico:hasActivityType</a>
    /// </summary>
    let hasActivityType = _prefixId.prefix "hasActivityType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R032 ('has addressee'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Record Resource or an Instantiation to the Agent that
    ///             it is addressed to.</para>
    ///   <para>rdfs:label : has addressee</para>
    ///   <para>skos:scopeNote : The identity of the addressee is (usually) evidenced by the
    ///             Record Resource or Instantiation itself.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasAddressee">rico:hasAddressee</a>
    /// </summary>
    let hasAddressee = _prefixId.prefix "hasAddressee"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has descendant' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R017i (has ancestor
    ///             relation)</para>
    ///   <para>rdfs:label : has ancestor</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasAncestor">rico:hasAncestor</a>
    /// </summary>
    let hasAncestor = _prefixId.prefix "hasAncestor"
    /// <summary>
    ///   <para>skos:scopeNote : To be used for any contribution to the content of a Record.
    ///             Includes (of course) the Person, Group or Position in whose name or by whose command the
    ///             content may have been formulated and first instantiated (e.g. the person who signed
    ///             it).</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R079 ('has author'
    ///             relation)</para>
    ///   <para>rdfs:label : has author</para>
    ///   <para>rdfs:comment : Connects a Record to the Group, Person or Position that is
    ///             responsible for conceiving and formulating the information contained in the
    ///             Record.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasAuthor">rico:hasAuthor</a>
    /// </summary>
    let hasAuthor = _prefixId.prefix "hasAuthor"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R069i ('has beginning date'
    ///             relation)</para>
    ///   <para>rdfs:label : has beginning date </para>
    ///   <para>rdfs:comment : Inverse of 'is beginning date of' object property</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasBeginningDate">rico:hasBeginningDate</a>
    /// </summary>
    let hasBeginningDate = _prefixId.prefix "hasBeginningDate"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R070i ('has birth date'
    ///             relation)</para>
    ///   <para>rdfs:label : has birth date </para>
    ///   <para>rdfs:comment : Inverse of 'is birth date of' object property</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasBirthDate">rico:hasBirthDate</a>
    /// </summary>
    let hasBirthDate = _prefixId.prefix "hasBirthDate"
    /// <summary>
    ///   <para>rdfs:label : has carrier type</para>
    ///   <para>rdfs:comment : Connects an Instantiation to a Carrier Type which categorizes
    ///             its carrier.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasCarrierType">rico:hasCarrierType</a>
    /// </summary>
    let hasCarrierType = _prefixId.prefix "hasCarrierType"
    /// <summary>
    ///   <para>rdfs:label : has child</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R018 ('has child'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Person to one of their children.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasChild">rico:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>rdfs:label : has collector</para>
    ///   <para>rdfs:comment : Connects a Record Resource or an Instantiation to the Agent that
    ///             collects it intentionally (is a collector).</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R030 ('has collector'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasCollector">rico:hasCollector</a>
    /// </summary>
    let hasCollector = _prefixId.prefix "hasCollector"
    /// <summary>
    ///   <para>rdfs:label : has content of type</para>
    ///   <para>rdfs:comment : Connects a Record or a Record Part to a Content Type which
    ///             categorizes its content.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasContentOfType">rico:hasContentOfType</a>
    /// </summary>
    let hasContentOfType = _prefixId.prefix "hasContentOfType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R012 ('has copy'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Record Resource to a copy of that Record
    ///             Resource.</para>
    ///   <para>rdfs:label : has copy </para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasCopy">rico:hasCopy</a>
    /// </summary>
    let hasCopy = _prefixId.prefix "hasCopy"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Record Resource or an Instantiation to an Agent that
    ///             is either responsible for all or some of the content of the Record Resource or is a
    ///             contributor to the genesis or production of an Instantiation.</para>
    ///   <para>skos:scopeNote : Covers the definition of author in diplomatics, and any
    ///             contribution to the intellectual content of a Record Resource.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R027 ('has creator'
    ///             relation)</para>
    ///   <para>rdfs:label : has creator</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasCreator">rico:hasCreator</a>
    /// </summary>
    let hasCreator = _prefixId.prefix "hasCreator"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R072i ('has death date'
    ///             relation)</para>
    ///   <para>rdfs:label : has death date </para>
    ///   <para>rdfs:comment : Inverse of 'is death date of' object property</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasDeathDate">rico:hasDeathDate</a>
    /// </summary>
    let hasDeathDate = _prefixId.prefix "hasDeathDate"
    /// <summary>
    ///   <para>rdfs:label : has derived instantiation </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R014 ('has derived instantiation'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects an Instantiation to an Instantiation that is derived
    ///             from it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasDerivedInstantiation">rico:hasDerivedInstantiation</a>
    /// </summary>
    let hasDerivedInstantiation = _prefixId.prefix "hasDerivedInstantiation"
    /// <summary>
    ///   <para>rdfs:label : has descendant</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R017 ('has descendant'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Person to one of their descendants.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasDescendant">rico:hasDescendant</a>
    /// </summary>
    let hasDescendant = _prefixId.prefix "hasDescendant"
    /// <summary>
    ///   <para>rdfs:label : has documentary form type</para>
    ///   <para>rdfs:comment : Connects a Record or Record Part to its Documentary Form
    ///             Type.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasDocumentaryFormType">rico:hasDocumentaryFormType</a>
    /// </summary>
    let hasDocumentaryFormType = _prefixId.prefix "hasDocumentaryFormType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-011i ('has draft'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'is draft of' object property.</para>
    ///   <para>rdfs:label : has draft </para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasDraft">rico:hasDraft</a>
    /// </summary>
    let hasDraft = _prefixId.prefix "hasDraft"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R071i ('has end date'
    ///             relation)</para>
    ///   <para>rdfs:label : has end date </para>
    ///   <para>rdfs:comment : Inverse of 'is end date of' object property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasEndDate">rico:hasEndDate</a>
    /// </summary>
    let hasEndDate = _prefixId.prefix "hasEndDate"
    /// <summary>
    ///   <para>rdfs:label : has event type</para>
    ///   <para>rdfs:comment : Connects an Event to an Event Type which categorizes
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasEventType">rico:hasEventType</a>
    /// </summary>
    let hasEventType = _prefixId.prefix "hasEventType"
    /// <summary>
    ///   <para>rdfs:label : has extent</para>
    ///   <para>rdfs:comment : Connects a Record Resource or Instantiation to an Extent^^xsd:string</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasExtent">rico:hasExtent</a>
    /// </summary>
    let hasExtent = _prefixId.prefix "hasExtent"
    /// <summary>
    ///   <para>rdfs:label : has extent type</para>
    ///   <para>rdfs:comment : Connects an Extent to an Extent Type that categorizes what is being
    ///             measured.^^xsd:string</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasExtentType">rico:hasExtentType</a>
    /// </summary>
    let hasExtentType = _prefixId.prefix "hasExtentType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R047 ('has family association with'
    ///             relation)</para>
    ///   <para>rdfs:label : has family association with</para>
    ///   <para>rdfs:comment : Connects two Persons that have some type of family link, i.e.
    ///             belong to the same family. This relation is symmetric.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasFamilyAssociationWith">rico:hasFamilyAssociationWith</a>
    /// </summary>
    let hasFamilyAssociationWith = _prefixId.prefix "hasFamilyAssociationWith"
    /// <summary>
    ///   <para>rdfs:label : has family type</para>
    ///   <para>rdfs:comment : Connects a Family to a Family Type that categorizes
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasFamilyType">rico:hasFamilyType</a>
    /// </summary>
    let hasFamilyType = _prefixId.prefix "hasFamilyType"

    /// <summary>
    ///   <para>skos:scopeNote : Use to connect two Record Resources only if it is not possible
    ///             to be more accurate and specify a narrower, asymmetric relation, e.g. ‘is original
    ///             of’.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R023 ('has genetic link to record resource'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects two Record Resources when there is a genetic link
    ///             between them. Genetic in this sense is as defined by diplomatics, i.e. the process by
    ///             which a Record Resource is developed. This relation is symmetric.</para>
    ///   <para>rdfs:label : has genetic link to record resource </para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasGeneticLinkToRecordResource">rico:hasGeneticLinkToRecordResource</a>
    /// </summary>
    let hasGeneticLinkToRecordResource = _prefixId.prefix "hasGeneticLinkToRecordResource"

    /// <summary>
    ///   <para>rdfs:label : has identifier type</para>
    ///   <para>rdfs:comment : Connects an Identifier and an Identifier Type that categorizes
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasIdentifierType">rico:hasIdentifierType</a>
    /// </summary>
    let hasIdentifierType = _prefixId.prefix "hasIdentifierType"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Record Resource to one of its
    ///             Instantiations.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R025 ('has instantiation'
    ///             relation)</para>
    ///   <para>rdfs:label : has instantiation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasInstantiation">rico:hasInstantiation</a>
    /// </summary>
    let hasInstantiation = _prefixId.prefix "hasInstantiation"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R073i ('has modification date'
    ///             relation)</para>
    ///   <para>rdfs:label : has modification date </para>
    ///   <para>rdfs:comment : Inverse of 'is modification date of' object
    ///             property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasModificationDate">rico:hasModificationDate</a>
    /// </summary>
    let hasModificationDate = _prefixId.prefix "hasModificationDate"
    /// <summary>
    ///   <para>rdfs:label : has or had agent name</para>
    ///   <para>rdfs:comment : Connects an Agent and (one of) its present or past Agent
    ///             Name.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadAgentName">rico:hasOrHadAgentName</a>
    /// </summary>
    let hasOrHadAgentName = _prefixId.prefix "hasOrHadAgentName"

    /// <summary>
    ///   <para>rdfs:label : has or had all members with category</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Category (Type) to which all the
    ///             Records or Record Parts that are or were included in the Record Set
    ///             belong.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithCategory">rico:hasOrHadAllMembersWithCategory</a>
    /// </summary>
    let hasOrHadAllMembersWithCategory = _prefixId.prefix "hasOrHadAllMembersWithCategory"

    /// <summary>
    ///   <para>rdfs:label : has of had all members with content type</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Content Type that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithContentType">rico:hasOrHadAllMembersWithContentType</a>
    /// </summary>
    let hasOrHadAllMembersWithContentType = _prefixId.prefix "hasOrHadAllMembersWithContentType"

    /// <summary>
    ///   <para>rdfs:label : has of had all members with documentary form type</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Documentary Form Type that
    ///             categorizes all the Records or Record Parts that are or were included in the Record
    ///             Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithDocumentaryFormType">rico:hasOrHadAllMembersWithDocumentaryFormType</a>
    /// </summary>
    let hasOrHadAllMembersWithDocumentaryFormType = _prefixId.prefix "hasOrHadAllMembersWithDocumentaryFormType"

    /// <summary>
    ///   <para>rdfs:label : has of had all members with language</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Language used by all the Records or
    ///             Record Parts that are or were included in the Record Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithLanguage">rico:hasOrHadAllMembersWithLanguage</a>
    /// </summary>
    let hasOrHadAllMembersWithLanguage = _prefixId.prefix "hasOrHadAllMembersWithLanguage"

    /// <summary>
    ///   <para>rdfs:label : has of had all members with legal status</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Legal Status that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithLegalStatus">rico:hasOrHadAllMembersWithLegalStatus</a>
    /// </summary>
    let hasOrHadAllMembersWithLegalStatus = _prefixId.prefix "hasOrHadAllMembersWithLegalStatus"

    /// <summary>
    ///   <para>rdfs:label : has of had all members with record state</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Record State that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithRecordState">rico:hasOrHadAllMembersWithRecordState</a>
    /// </summary>
    let hasOrHadAllMembersWithRecordState = _prefixId.prefix "hasOrHadAllMembersWithRecordState"

    /// <summary>
    ///   <para>rdfs:label : has or had appellation</para>
    ///   <para>rdfs:comment : Connects a Thing to an Appellation that is or was used for
    ///             designating it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadAppellation">rico:hasOrHadAppellation</a>
    /// </summary>
    let hasOrHadAppellation = _prefixId.prefix "hasOrHadAppellation"
    /// <summary>
    ///   <para>rdfs:label : has or had authority over</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R036 ('has or had authority over'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects an Agent to a Thing the Agent has or had authority
    ///             over.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadAuthorityOver">rico:hasOrHadAuthorityOver</a>
    /// </summary>
    let hasOrHadAuthorityOver = _prefixId.prefix "hasOrHadAuthorityOver"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Thing to a Type that categorizes or categorized
    ///             it.</para>
    ///   <para>rdfs:label : has or had category</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadCategory">rico:hasOrHadCategory</a>
    /// </summary>
    let hasOrHadCategory = _prefixId.prefix "hasOrHadCategory"
    /// <summary>
    ///   <para>rdfs:label : has or had component</para>
    ///   <para>rdfs:comment : Connects an Instantiation to one of its present or past
    ///             component instantiations.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R004 ('has or had component'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadComponent">rico:hasOrHadComponent</a>
    /// </summary>
    let hasOrHadComponent = _prefixId.prefix "hasOrHadComponent"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R003 ('has or had constituent'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Record to a Record Part that is or was a component of
    ///             that Record.</para>
    ///   <para>rdfs:label : has or had constituent</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadConstituent">rico:hasOrHadConstituent</a>
    /// </summary>
    let hasOrHadConstituent = _prefixId.prefix "hasOrHadConstituent"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'is or was controller of' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R041i ('has or had controller'
    ///             relation)</para>
    ///   <para>rdfs:label : has or had controller</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadController">rico:hasOrHadController</a>
    /// </summary>
    let hasOrHadController = _prefixId.prefix "hasOrHadController"
    /// <summary>
    ///   <para>rdfs:label : has coordinates</para>
    ///   <para>rdfs:comment : Connects a Physical Location to its past or present coordinates
    ///             in a reference system.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadCoordinates">rico:hasOrHadCoordinates</a>
    /// </summary>
    let hasOrHadCoordinates = _prefixId.prefix "hasOrHadCoordinates"
    /// <summary>
    ///   <para>rdfs:label : has or had corporate body type</para>
    ///   <para>rdfs:comment : Connects a Corporate Body to a Corporate Body Type which
    ///             categorizes or categorized it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadCorporateBodyType">rico:hasOrHadCorporateBodyType</a>
    /// </summary>
    let hasOrHadCorporateBodyType = _prefixId.prefix "hasOrHadCorporateBodyType"
    /// <summary>
    ///   <para>rdfs:comment : Connects two Persons that correspond or have corresponded with
    ///             each other. This relation is symmetric.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R052 ('has or had correspondent'
    ///             relation)</para>
    ///   <para>rdfs:label : has or had correspondent</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadCorrespondent">rico:hasOrHadCorrespondent</a>
    /// </summary>
    let hasOrHadCorrespondent = _prefixId.prefix "hasOrHadCorrespondent"
    /// <summary>
    ///   <para>rdfs:label : has or had demographic group</para>
    ///   <para>rdfs:comment : Connects a Person or a Group to a Demographic Group to which it
    ///             belongs or belonged.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadDemographicGroup">rico:hasOrHadDemographicGroup</a>
    /// </summary>
    let hasOrHadDemographicGroup = _prefixId.prefix "hasOrHadDemographicGroup"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R039i ('has or had holder'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'is or was holder of' object property.</para>
    ///   <para>rdfs:label : has or had holder</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadHolder">rico:hasOrHadHolder</a>
    /// </summary>
    let hasOrHadHolder = _prefixId.prefix "hasOrHadHolder"
    /// <summary>
    ///   <para>rdfs:label : has or had identifier</para>
    ///   <para>rdfs:comment : Connects a Thing to one of its past or present
    ///             Identifiers.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadIdentifier">rico:hasOrHadIdentifier</a>
    /// </summary>
    let hasOrHadIdentifier = _prefixId.prefix "hasOrHadIdentifier"

    /// <summary>
    ///   <para>rdfs:label : has or had intellectual property rights holder</para>
    ///   <para>rdfs:comment : Inverse of 'is or was holder of intellectual property rights of'
    ///             object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R040i ('has or had intellectual property
    ///             rights holder ' relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadIntellectualPropertyRightsHolder">rico:hasOrHadIntellectualPropertyRightsHolder</a>
    /// </summary>
    let hasOrHadIntellectualPropertyRightsHolder = _prefixId.prefix "hasOrHadIntellectualPropertyRightsHolder"

    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'is or was jurisdiction of' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R076i ('has or had jurisdiction'
    ///             relation)</para>
    ///   <para>rdfs:label : has or had jurisdiction</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadJurisdiction">rico:hasOrHadJurisdiction</a>
    /// </summary>
    let hasOrHadJurisdiction = _prefixId.prefix "hasOrHadJurisdiction"
    /// <summary>
    ///   <para>rdfs:label : has or had language</para>
    ///   <para>rdfs:comment : Connects an Agent or Record Resource to a Language that it uses
    ///             or used.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadLanguage">rico:hasOrHadLanguage</a>
    /// </summary>
    let hasOrHadLanguage = _prefixId.prefix "hasOrHadLanguage"
    /// <summary>
    ///   <para>rdfs:label : has or had leader</para>
    ///   <para>rdfs:comment : Inverse of 'is or was leader of' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R042i ('has or had leader'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadLeader">rico:hasOrHadLeader</a>
    /// </summary>
    let hasOrHadLeader = _prefixId.prefix "hasOrHadLeader"
    /// <summary>
    ///   <para>rdfs:label : has or had legal status</para>
    ///   <para>rdfs:comment : Connects an Agent or Record Resource to a Legal Status which
    ///             categorized or categorizes it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadLegalStatus">rico:hasOrHadLegalStatus</a>
    /// </summary>
    let hasOrHadLegalStatus = _prefixId.prefix "hasOrHadLegalStatus"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'is or was location of' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R075i ('has or had location'
    ///             relation)</para>
    ///   <para>rdfs:label : has or had location</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadLocation">rico:hasOrHadLocation</a>
    /// </summary>
    let hasOrHadLocation = _prefixId.prefix "hasOrHadLocation"
    /// <summary>
    ///   <para>rdfs:label : has or had main subject</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R020 ('has or had main subject'
    ///             relation)</para>
    ///   <para>skos:scopeNote : Use for specifying, for example, that a Record Set of type
    ///             personal file has main subject some person, which would help end users to retrieve the
    ///             main archival resources about this person.</para>
    ///   <para>rdfs:comment : Connects a Record Resource to a Thing that is or was its main
    ///             subject.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadMainSubject">rico:hasOrHadMainSubject</a>
    /// </summary>
    let hasOrHadMainSubject = _prefixId.prefix "hasOrHadMainSubject"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'is or was manager of' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R038i ('is or was managed by'
    ///             relation)</para>
    ///   <para>rdfs:label : has or had manager</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadManager">rico:hasOrHadManager</a>
    /// </summary>
    let hasOrHadManager = _prefixId.prefix "hasOrHadManager"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Group to a Person that is or was a member of that
    ///             Group.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R055 ('has or had member'
    ///             relation)</para>
    ///   <para>rdfs:label : has or had member</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadMember">rico:hasOrHadMember</a>
    /// </summary>
    let hasOrHadMember = _prefixId.prefix "hasOrHadMember"
    /// <summary>
    ///   <para>rdfs:label : has or had name</para>
    ///   <para>rdfs:comment : Connects a Thing to one of its past or present
    ///             Names.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadName">rico:hasOrHadName</a>
    /// </summary>
    let hasOrHadName = _prefixId.prefix "hasOrHadName"
    /// <summary>
    ///   <para>rdfs:label : has or had occupation of type</para>
    ///   <para>rdfs:comment : Connects a Person to an Occupation Type that categorized or
    ///             categorizes his/her occupation (profession, trade or craft).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadOccupationOfType">rico:hasOrHadOccupationOfType</a>
    /// </summary>
    let hasOrHadOccupationOfType = _prefixId.prefix "hasOrHadOccupationOfType"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'is or was owner of' object property.</para>
    ///   <para>rdfs:label : has or had owner</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R037i ('has or had owner'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadOwner">rico:hasOrHadOwner</a>
    /// </summary>
    let hasOrHadOwner = _prefixId.prefix "hasOrHadOwner"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Thing to a constitutive or component part of that
    ///             Thing.</para>
    ///   <para>rdfs:label : has or had part</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R002 (has or had part
    ///             relation)</para>
    ///   <para>skos:scopeNote : The end of existence of a whole/part relation may affect the
    ///             integrity or nature of the domain entity</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadPart">rico:hasOrHadPart</a>
    /// </summary>
    let hasOrHadPart = _prefixId.prefix "hasOrHadPart"
    /// <summary>
    ///   <para>rdfs:label : has or had participant</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R058 ('has or had participant'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects an Event to a Thing that is or was actively or
    ///             passively involved in it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadParticipant">rico:hasOrHadParticipant</a>
    /// </summary>
    let hasOrHadParticipant = _prefixId.prefix "hasOrHadParticipant"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Place to one of its past or present Physical
    ///             Location.</para>
    ///   <para>rdfs:label : has or had physical location</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadPhysicalLocation">rico:hasOrHadPhysicalLocation</a>
    /// </summary>
    let hasOrHadPhysicalLocation = _prefixId.prefix "hasOrHadPhysicalLocation"
    /// <summary>
    ///   <para>rdfs:label : has or had place name</para>
    ///   <para>rdfs:comment : Connects a Place to one of its past or present
    ///             names.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadPlaceName">rico:hasOrHadPlaceName</a>
    /// </summary>
    let hasOrHadPlaceName = _prefixId.prefix "hasOrHadPlaceName"
    /// <summary>
    ///   <para>rdfs:label : has or had place type</para>
    ///   <para>rdfs:comment : Connects a Place to a Place Type that categorized or categorizes
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadPlaceType">rico:hasOrHadPlaceType</a>
    /// </summary>
    let hasOrHadPlaceType = _prefixId.prefix "hasOrHadPlaceType"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'exists or existed in' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R056i ('has or had position'
    ///             relation)</para>
    ///   <para>rdfs:label : has or had position</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadPosition">rico:hasOrHadPosition</a>
    /// </summary>
    let hasOrHadPosition = _prefixId.prefix "hasOrHadPosition"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Rule to a Rule Type that categorized or categorizes
    ///             it.</para>
    ///   <para>rdfs:label : has or had rule type</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadRuleType">rico:hasOrHadRuleType</a>
    /// </summary>
    let hasOrHadRuleType = _prefixId.prefix "hasOrHadRuleType"

    /// <summary>
    ///   <para>rdfs:label : has or had some members with category</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Category (Type) to which some of the
    ///             Records or Record Parts that are or were included in the Record Set
    ///             belong.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithCategory">rico:hasOrHadSomeMembersWithCategory</a>
    /// </summary>
    let hasOrHadSomeMembersWithCategory = _prefixId.prefix "hasOrHadSomeMembersWithCategory"

    /// <summary>
    ///   <para>rdfs:label : has or had some members with content type</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Content Type that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithContentType">rico:hasOrHadSomeMembersWithContentType</a>
    /// </summary>
    let hasOrHadSomeMembersWithContentType = _prefixId.prefix "hasOrHadSomeMembersWithContentType"

    /// <summary>
    ///   <para>rdfs:label : has or had some members with language</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Language used by some of the Records
    ///             or Record Parts that are or were included in the Record Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithLanguage">rico:hasOrHadSomeMembersWithLanguage</a>
    /// </summary>
    let hasOrHadSomeMembersWithLanguage = _prefixId.prefix "hasOrHadSomeMembersWithLanguage"

    /// <summary>
    ///   <para>rdfs:label : has or had some members with legal status</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Legal Status that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithLegalStatus">rico:hasOrHadSomeMembersWithLegalStatus</a>
    /// </summary>
    let hasOrHadSomeMembersWithLegalStatus = _prefixId.prefix "hasOrHadSomeMembersWithLegalStatus"

    /// <summary>
    ///   <para>rdfs:label : has or had some members with record state</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Record State that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithRecordState">rico:hasOrHadSomeMembersWithRecordState</a>
    /// </summary>
    let hasOrHadSomeMembersWithRecordState = _prefixId.prefix "hasOrHadSomeMembersWithRecordState"

    /// <summary>
    ///   <para>rdfs:label : has or had some members with documentary form type</para>
    ///   <para>rdfs:comment : Connects a Record Set and a Documentary Form Type that
    ///             categorizes some of the Records or Record Parts that are or were included in the Record
    ///             Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMemberswithDocumentaryFormType">rico:hasOrHadSomeMemberswithDocumentaryFormType</a>
    /// </summary>
    let hasOrHadSomeMemberswithDocumentaryFormType = _prefixId.prefix "hasOrHadSomeMemberswithDocumentaryFormType"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R049 ('has or had spouse'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects two Persons that are or were married. This relation is
    ///             symmetric.</para>
    ///   <para>rdfs:label : has or had spouse</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSpouse">rico:hasOrHadSpouse</a>
    /// </summary>
    let hasOrHadSpouse = _prefixId.prefix "hasOrHadSpouse"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R053i ('has or had student'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'has or had teacher' object property.</para>
    ///   <para>rdfs:label : has or had student</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadStudent">rico:hasOrHadStudent</a>
    /// </summary>
    let hasOrHadStudent = _prefixId.prefix "hasOrHadStudent"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Group to one of its present or past
    ///             subdivisions.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R005 ('has or hadsubdivision'
    ///             relation)</para>
    ///   <para>rdfs:label : has or had subdivision</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubdivision">rico:hasOrHadSubdivision</a>
    /// </summary>
    let hasOrHadSubdivision = _prefixId.prefix "hasOrHadSubdivision"
    /// <summary>
    ///   <para>skos:scopeNote : Since an Activity is a kind of Event, this Relation can also
    ///             be used for Activity.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R006 ('has or had subevent'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects an Event to one of a series of Events that constitute
    ///             the original, broader, past or ongoing Event.</para>
    ///   <para>rdfs:label : has or had subevent</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubevent">rico:hasOrHadSubevent</a>
    /// </summary>
    let hasOrHadSubevent = _prefixId.prefix "hasOrHadSubevent"
    /// <summary>
    ///   <para>rdfs:label : has or had subject</para>
    ///   <para>rdfs:comment : Connects a Record Resource to a Thing that is or was its
    ///             subject.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R019 ('has or had subject'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubject">rico:hasOrHadSubject</a>
    /// </summary>
    let hasOrHadSubject = _prefixId.prefix "hasOrHadSubject"
    /// <summary>
    ///   <para>rdfs:label : has or had subordinate</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R045 ('has or had subordinate '
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects an Agent to an Agent that is hierarchically
    ///             inferior.</para>
    ///   <para>skos:scopeNote : The hierarchical relation can be an authority relation, or a
    ///             whole/part relation between two Groups</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubordinate">rico:hasOrHadSubordinate</a>
    /// </summary>
    let hasOrHadSubordinate = _prefixId.prefix "hasOrHadSubordinate"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R053 ('has or had teacher'
    ///             relation)</para>
    ///   <para>rdfs:label : has or had teacher</para>
    ///   <para>rdfs:comment : Connects a Person to another Person who is or was their
    ///             student.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadTeacher">rico:hasOrHadTeacher</a>
    /// </summary>
    let hasOrHadTeacher = _prefixId.prefix "hasOrHadTeacher"
    /// <summary>
    ///   <para>rdfs:label : has or had title</para>
    ///   <para>rdfs:comment : Connects a Record Resource, Instantiation or Rule to a title
    ///             that is or was used for designating it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadTitle">rico:hasOrHadTitle</a>
    /// </summary>
    let hasOrHadTitle = _prefixId.prefix "hasOrHadTitle"
    /// <summary>
    ///   <para>rdfs:comment : Connects two Agents that have or had some type of work relation
    ///             in the course of their activities. This relation is symmetric.</para>
    ///   <para>rdfs:label : has or had work relation with</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R046 ('has or had work relation with'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOrHadWorkRelationWith">rico:hasOrHadWorkRelationWith</a>
    /// </summary>
    let hasOrHadWorkRelationWith = _prefixId.prefix "hasOrHadWorkRelationWith"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R010i (is original of
    ///             relation)</para>
    ///   <para>rdfs:label : has original </para>
    ///   <para>rdfs:comment : Inverse of 'is original of' object property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasOriginal">rico:hasOriginal</a>
    /// </summary>
    let hasOriginal = _prefixId.prefix "hasOriginal"
    /// <summary>
    ///   <para>rdfs:label : has production technique type</para>
    ///   <para>rdfs:comment : Connects an Instantiation to a Production Technique Type that
    ///             categorizes its production technique.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasProductionTechniqueType">rico:hasProductionTechniqueType</a>
    /// </summary>
    let hasProductionTechniqueType = _prefixId.prefix "hasProductionTechniqueType"
    /// <summary>
    ///   <para>rdfs:label : has provenance </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R026 ('has provenance'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Record Resource or an Instantiation to an Agent that
    ///             creates or accumulates the Record Resource, receives it, or sends it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasProvenance">rico:hasProvenance</a>
    /// </summary>
    let hasProvenance = _prefixId.prefix "hasProvenance"
    /// <summary>
    ///   <para>rdfs:label : hasPublisher</para>
    ///   <para>rdfs:comment : Connects a Record resource to an Agent who published
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasPublisher">rico:hasPublisher</a>
    /// </summary>
    let hasPublisher = _prefixId.prefix "hasPublisher"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R029 ('has receiver'
    ///             relation)</para>
    ///   <para>rdfs:label : has receiver</para>
    ///   <para>rdfs:comment : Connects a Record Resource or an Instantiation to the Agent that
    ///             receives it in the course of its activities.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasReceiver">rico:hasReceiver</a>
    /// </summary>
    let hasReceiver = _prefixId.prefix "hasReceiver"
    /// <summary>
    ///   <para>rdfs:label : has record set type</para>
    ///   <para>rdfs:comment : Connects a Record Set to a Record Set Type that categorizes
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasRecordSetType">rico:hasRecordSetType</a>
    /// </summary>
    let hasRecordSetType = _prefixId.prefix "hasRecordSetType"
    /// <summary>
    ///   <para>rdfs:label : has record state</para>
    ///   <para>rdfs:comment : Connects a Record or Record Part to a Record State that
    ///             categorizes its state.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasRecordState">rico:hasRecordState</a>
    /// </summary>
    let hasRecordState = _prefixId.prefix "hasRecordState"
    /// <summary>
    ///   <para>rdfs:label : has reply</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R013 ('has reply'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Record Resource to a reply, usually in the form of
    ///             correspondence.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasReply">rico:hasReply</a>
    /// </summary>
    let hasReply = _prefixId.prefix "hasReply"
    /// <summary>
    ///   <para>rdfs:label : has representation type</para>
    ///   <para>rdfs:comment : Connects an Instantiation to a Representation Type that
    ///             categorizes its representation type.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasRepresentationType">rico:hasRepresentationType</a>
    /// </summary>
    let hasRepresentationType = _prefixId.prefix "hasRepresentationType"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R031 ('has sender'
    ///             relation)</para>
    ///   <para>rdfs:label : has sender </para>
    ///   <para>rdfs:comment : Connects a Record Resource or an Instantiation to the Agent that
    ///             sends it</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasSender">rico:hasSender</a>
    /// </summary>
    let hasSender = _prefixId.prefix "hasSender"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R048 ('has sibling'
    ///             relation)</para>
    ///   <para>rdfs:label : has sibling</para>
    ///   <para>rdfs:comment : Connects two Persons that are siblings. This relation is
    ///             symmetric.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasSibling">rico:hasSibling</a>
    /// </summary>
    let hasSibling = _prefixId.prefix "hasSibling"
    /// <summary>
    ///   <para>rdfs:label : has source </para>
    ///   <para>rdfs:comment : Connects a Record Resource or Relation to a Record Resource or
    ///             Agent that is used as a source of information for identifying or describing
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasSource">rico:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:label : has successor</para>
    ///   <para>skos:scopeNote : There may be zero to many intermediate Agents , ignored or
    ///             unknown, between the two connected Agents. Can be used when there is a transfer of
    ///             function from the first Agent to the second Agent.</para>
    ///   <para>rdfs:comment : Connects an Agent to another Agent that succeeds it
    ///             chronologically.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RIC-R016 ('has successor'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasSuccessor">rico:hasSuccessor</a>
    /// </summary>
    let hasSuccessor = _prefixId.prefix "hasSuccessor"
    /// <summary>
    ///   <para>rdfs:label : has unit of measurement</para>
    ///   <para>rdfs:comment : Connects an Extent to a Unit Of Measurement^^xsd:string</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#hasUnitOfMeasurement">rico:hasUnitOfMeasurement</a>
    /// </summary>
    let hasUnitOfMeasurement = _prefixId.prefix "hasUnitOfMeasurement"
    /// <summary>
    ///   <para>rdfs:label : height</para>
    ///   <para>rdfs:comment : Vertical dimension of an entity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#height">rico:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A21 (History
    ///             attribute)</para>
    ///   <para>skos:example : Nacido en Barbastro en 1892, donde realizó sus primeros estudios
    ///             con los escolapios. Licenciado en Derecho por la Universidad de Zaragoza, aprobó las
    ///             oposiciones al cuerpo nacional de notarios…(Person)skos:example : The manuscripts are part of the collections of Robert Harley (d
    ///             1724) and Edward Harley (d 1741), 1st and 2nd Earls of Oxford, that were brought by
    ///             Parliament and transferred to the British Museum in 1753. Those materials were then
    ///             separated into this collection and those for Harley Charters and Harley Rolls and became
    ///             part of the collections of the British Library in 1972. (Record Set)skos:example : El primer sorteo de lotería se celebró el 13 de mayo de 1771,
    ///             siendo desarrollado por la Real Lotería General de Nueva España…
    ///             (Activity)</para>
    ///   <para>rdfs:label : history</para>
    ///   <para>skos:scopeNote : History can alternatively be represented by a series of
    ///             related Events.</para>
    ///   <para>rdfs:comment : Summary of the development of an entity, since its origin until
    ///             present time.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#history">rico:history</a>
    /// </summary>
    let history = _prefixId.prefix "history"
    /// <summary>
    ///   <para>skos:example : SNAC ID: 83847206skos:example : ISNI : 0000000073572182skos:example : BUD-01-F002 [example of a classification number from a corporate
    ///             file plan]skos:example : NAS1/A/1.1 [example of local identifier for a
    ///             Record]skos:example : F 1204 [example of a local identifier for a Record Set assigned
    ///             by a repository]skos:example : Ark ID: w6tz44ht</para>
    ///   <para>skos:scopeNote : Use only if you don't use Identifier class for handling
    ///             identifiers. Within a given domain (a closed system), identifiers are used to uniquely
    ///             reference instances of an entity. Identifiers are instruments of control that facilitate
    ///             management of the entities within the domain. The formulation of identifiers commonly is
    ///             based on rules.</para>
    ///   <para>rdfs:label : identifier</para>
    ///   <para>rdfs:comment : A word, number, letter, symbol, or any combination of these used
    ///             to uniquely identify or reference an individual instance of an entity within a specific
    ///             information domain. Includes Global Persistent Identifiers (globally unique and
    ///             persistently resolvable identifier for the entity) and/or Local
    ///             Identifiers.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A22 (Identifier
    ///             attribute)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#identifier">rico:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Record Set to a Record or Record Set it aggregates,
    ///             or aggregated in the past.</para>
    ///   <para>rdfs:label : includes or included</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R024 ('includes or included'
    ///             relation)</para>
    ///   <para>skos:scopeNote : A Record or Record Set can be aggregated in one or many Record
    ///             Sets simultaneously or through time</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#includesOrIncluded">rico:includesOrIncluded</a>
    /// </summary>
    let includesOrIncluded = _prefixId.prefix "includesOrIncluded"
    /// <summary>
    ///   <para>skos:scopeNote : For a given Record Resource, the Instantiation Extent may
    ///             vary, based on format, density of information on the carrier, etc. For example, a file
    ///             of 1500 words (Record Resource Extent) may have Instantiation Extent 3kb as a Word
    ///             document and 5kb as a PDF file, and instantiations may be represented on a CD of 700mb
    ///             (Carrier Extent). Use if you don't use InstantiationExtent class and its properties for
    ///             handling such information.</para>
    ///   <para>skos:example : Size of PDF-file: 1.5 MBskos:example : The book register has 345 written leaves.</para>
    ///   <para>rdfs:comment : Countable characteristics of the Instantiation expressed as a
    ///             quantity.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A23 (Instantiation Extent
    ///             attribute)</para>
    ///   <para>rdfs:label : Instantiation extent</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#instantiationExtent">rico:instantiationExtent</a>
    /// </summary>
    let instantiationExtent = _prefixId.prefix "instantiationExtent"

    /// <summary>
    ///   <para>rdfs:label : instantiation is connected to functional equivalence relation
    ///         </para>
    ///   <para>rdfs:comment : Connects an Instantiation to a Functional Equivalence
    ///             Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#instantiationIsConnectedToFunctionalEquivalenceRelation">rico:instantiationIsConnectedToFunctionalEquivalenceRelation</a>
    /// </summary>
    let instantiationIsConnectedToFunctionalEquivalenceRelation = _prefixId.prefix "instantiationIsConnectedToFunctionalEquivalenceRelation"

    /// <summary>
    ///   <para>rdfs:label : instantiation is connected to instantiation relation </para>
    ///   <para>rdfs:comment : Connects an Instantiation to an Instantiation to Instantiation
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#instantiationIsConnectedToInstantiationRelation">rico:instantiationIsConnectedToInstantiationRelation</a>
    /// </summary>
    let instantiationIsConnectedToInstantiationRelation = _prefixId.prefix "instantiationIsConnectedToInstantiationRelation"

    /// <summary>
    ///   <para>rdfs:label : instantiation is source of derivation relation </para>
    ///   <para>rdfs:comment : Connects an Instantiation (from which at least one Instantiation
    ///             is derived) to a Derivation Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#instantiationIsSourceOfDerivationRelation">rico:instantiationIsSourceOfDerivationRelation</a>
    /// </summary>
    let instantiationIsSourceOfDerivationRelation = _prefixId.prefix "instantiationIsSourceOfDerivationRelation"

    /// <summary>
    ///   <para>rdfs:label : instantiation is source of migration relation </para>
    ///   <para>rdfs:comment : Connects an Instantiation (from which at least one Instantiation
    ///             is migrated) to a Migration Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#instantiationIsSourceOfMigrationRelation">rico:instantiationIsSourceOfMigrationRelation</a>
    /// </summary>
    let instantiationIsSourceOfMigrationRelation = _prefixId.prefix "instantiationIsSourceOfMigrationRelation"

    /// <summary>
    ///   <para>rdfs:label : instantiation is target of derivation relation </para>
    ///   <para>rdfs:comment : Connects a derived Instantiation to a Derivation
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfDerivationRelation">rico:instantiationIsTargetOfDerivationRelation</a>
    /// </summary>
    let instantiationIsTargetOfDerivationRelation = _prefixId.prefix "instantiationIsTargetOfDerivationRelation"

    /// <summary>
    ///   <para>rdfs:label : instantiation is target of migration relation </para>
    ///   <para>rdfs:comment : Connects an Instantiation which results from a migration, to a
    ///             Migration Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfMigrationRelation">rico:instantiationIsTargetOfMigrationRelation</a>
    /// </summary>
    let instantiationIsTargetOfMigrationRelation = _prefixId.prefix "instantiationIsTargetOfMigrationRelation"

    /// <summary>
    ///   <para>rdfs:label : instantiation is target of record resource to instantiation
    ///             relation </para>
    ///   <para>rdfs:comment : Connects an Instantiation of a Record Resource to the Record
    ///             Resource to Instantiation Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfRecordResourceToInstantiationRelation">rico:instantiationIsTargetOfRecordResourceToInstantiationRelation</a>
    /// </summary>
    let instantiationIsTargetOfRecordResourceToInstantiationRelation = _prefixId.prefix "instantiationIsTargetOfRecordResourceToInstantiationRelation"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Specialization of RiC-A40 (Structure
    ///             attribute)</para>
    ///   <para>rdfs:label : Instantiation structure</para>
    ///   <para>rdfs:comment : Information about the physical arrangement and composition of an
    ///             Instantiation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#instantiationStructure">rico:instantiationStructure</a>
    /// </summary>
    let instantiationStructure = _prefixId.prefix "instantiationStructure"

    /// <summary>
    ///   <para>rdfs:label : instantiation to instantiation relation connects </para>
    ///   <para>rdfs:comment : Connects an Instantiation to Instantiation Relation to one of
    ///             the related Instantiations.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#instantiationToInstantiationRelationConnects">rico:instantiationToInstantiationRelationConnects</a>
    /// </summary>
    let instantiationToInstantiationRelationConnects = _prefixId.prefix "instantiationToInstantiationRelationConnects"

    /// <summary>
    ///   <para>rdfs:label : integrity</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A24 (Integrity
    ///             attribute)</para>
    ///   <para>rdfs:comment : Information about the completeness of a Record Resource or
    ///             Instantiation.</para>
    ///   <para>skos:scopeNote : The information about integrity may be generated manually or
    ///             automatically.</para>
    ///   <para>skos:example : The database (DBF) file has the checksum SHA-1:
    ///             99f9d780e441785016dea545b72dad700305535a.skos:example : The book register’s last pages are missing, which affects the
    ///             completeness of the record.skos:example : The charter is missing the seal.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#integrity">rico:integrity</a>
    /// </summary>
    let integrity = _prefixId.prefix "integrity"

    /// <summary>
    ///   <para>rdfs:label : intellectual property rights relation has source </para>
    ///   <para>rdfs:comment : Connects an IntellectualPropertyRightsRelation to one of the
    ///             Group, Person or Position that holds the rights.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#intellectualPropertyRightsRelationHasSource">rico:intellectualPropertyRightsRelationHasSource</a>
    /// </summary>
    let intellectualPropertyRightsRelationHasSource = _prefixId.prefix "intellectualPropertyRightsRelationHasSource"

    /// <summary>
    ///   <para>rdfs:label : intellectual property rights relation has target </para>
    ///   <para>rdfs:comment : Connects an IintellectualPropertyRightsRelation to one of the
    ///             Record Resource or Instantiation on which the rights are held.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#intellectualPropertyRightsRelationHasTarget">rico:intellectualPropertyRightsRelationHasTarget</a>
    /// </summary>
    let intellectualPropertyRightsRelationHasTarget = _prefixId.prefix "intellectualPropertyRightsRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : is accumulator of</para>
    ///   <para>rdfs:comment : Inverse of 'has accumulator' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R028i ('is accumulator of'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isAccumulatorOf">rico:isAccumulatorOf</a>
    /// </summary>
    let isAccumulatorOf = _prefixId.prefix "isAccumulatorOf"
    /// <summary>
    ///   <para>rdfs:label : is activity type of</para>
    ///   <para>rdfs:comment : Connects an Activity Type to an Activity that it
    ///             categorizes.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isActivityTypeOf">rico:isActivityTypeOf</a>
    /// </summary>
    let isActivityTypeOf = _prefixId.prefix "isActivityTypeOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-032i ('is addressee of'
    ///             relation)</para>
    ///   <para>rdfs:label : is addressee of </para>
    ///   <para>rdfs:comment : Inverse of 'has addressee' object property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isAddresseeOf">rico:isAddresseeOf</a>
    /// </summary>
    let isAddresseeOf = _prefixId.prefix "isAddresseeOf"
    /// <summary>
    ///   <para>skos:scopeNote : Use to connect two Agents only if it is not possible to be
    ///             more accurate and use a narrower Agent to Agent relation, e.g. ‘has work relation
    ///             with’.</para>
    ///   <para>rdfs:label : is agent associated with agent </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R044 ('is agent associated with agent'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects two Agents. This object property is
    ///             symmetric.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isAgentAssociatedWithAgent">rico:isAgentAssociatedWithAgent</a>
    /// </summary>
    let isAgentAssociatedWithAgent = _prefixId.prefix "isAgentAssociatedWithAgent"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R068i ('is associated with date'
    ///             relation)</para>
    ///   <para>rdfs:label : is associated with date </para>
    ///   <para>rdfs:comment : Inverse of 'is date associated with' object
    ///             property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithDate">rico:isAssociatedWithDate</a>
    /// </summary>
    let isAssociatedWithDate = _prefixId.prefix "isAssociatedWithDate"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'is event associated with' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R057i ('is associated with event'
    ///             relation)</para>
    ///   <para>rdfs:label : is associated with event </para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithEvent">rico:isAssociatedWithEvent</a>
    /// </summary>
    let isAssociatedWithEvent = _prefixId.prefix "isAssociatedWithEvent"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R074i ('is associated with place'
    ///             relation)</para>
    ///   <para>rdfs:label : is associated with place </para>
    ///   <para>rdfs:comment : Inverse of 'is place associated with' object
    ///             property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithPlace">rico:isAssociatedWithPlace</a>
    /// </summary>
    let isAssociatedWithPlace = _prefixId.prefix "isAssociatedWithPlace"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'is rule associated with' object
    ///             property.</para>
    ///   <para>rdfs:label : is associated with rule </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R062i ('is associated with rule'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithRule">rico:isAssociatedWithRule</a>
    /// </summary>
    let isAssociatedWithRule = _prefixId.prefix "isAssociatedWithRule"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has author' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R079i ('is author of'
    ///             relation)</para>
    ///   <para>rdfs:label : is author of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isAuthorOf">rico:isAuthorOf</a>
    /// </summary>
    let isAuthorOf = _prefixId.prefix "isAuthorOf"

    /// <summary>
    ///   <para>rdfs:label : is authorizing agent in mandate relation </para>
    ///   <para>rdfs:comment : Connects an Agent that assigns the Mandate, to a Mandate
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isAuthorizingAgentInMandateRelation">rico:isAuthorizingAgentInMandateRelation</a>
    /// </summary>
    let isAuthorizingAgentInMandateRelation = _prefixId.prefix "isAuthorizingAgentInMandateRelation"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R069 ('is beginning date of'
    ///             relation)</para>
    ///   <para>rdfs:label : is beginning date of </para>
    ///   <para>rdfs:comment : Connects a Date to a Thing that came into existence on that
    ///             Date.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isBeginningDateOf">rico:isBeginningDateOf</a>
    /// </summary>
    let isBeginningDateOf = _prefixId.prefix "isBeginningDateOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R070 ('is birth date of'
    ///             relation)</para>
    ///   <para>rdfs:label : is birth date of </para>
    ///   <para>rdfs:comment : Connects a Date to a Person that was born on that
    ///             Date.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isBirthDateOf">rico:isBirthDateOf</a>
    /// </summary>
    let isBirthDateOf = _prefixId.prefix "isBirthDateOf"
    /// <summary>
    ///   <para>rdfs:label : is carrier type of</para>
    ///   <para>rdfs:comment : Connects a Carrier Type to an Instantiation whose carrier it
    ///             categorizes.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isCarrierTypeOf">rico:isCarrierTypeOf</a>
    /// </summary>
    let isCarrierTypeOf = _prefixId.prefix "isCarrierTypeOf"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has child' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R018i ('is child of'
    ///             relation)</para>
    ///   <para>rdfs:label : is child of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isChildOf">rico:isChildOf</a>
    /// </summary>
    let isChildOf = _prefixId.prefix "isChildOf"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has collector' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R030i ('is collector of'
    ///             relation)</para>
    ///   <para>rdfs:label : is collector of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isCollectorOf">rico:isCollectorOf</a>
    /// </summary>
    let isCollectorOf = _prefixId.prefix "isCollectorOf"
    /// <summary>
    ///   <para>rdfs:label : is content type of</para>
    ///   <para>rdfs:comment : Connects a Content Type to a Record or Record Part whose content
    ///             it categorizes.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isContentTypeOf">rico:isContentTypeOf</a>
    /// </summary>
    let isContentTypeOf = _prefixId.prefix "isContentTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is copy of</para>
    ///   <para>rdfs:comment : Inverse of 'has copy' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R012i ('is copy of'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isCopyOf">rico:isCopyOf</a>
    /// </summary>
    let isCopyOf = _prefixId.prefix "isCopyOf"
    /// <summary>
    ///   <para>rdfs:label : is creator of</para>
    ///   <para>rdfs:comment : Inverse of 'has creator' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R027i ('is creator of
    ///             'relation')</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isCreatorOf">rico:isCreatorOf</a>
    /// </summary>
    let isCreatorOf = _prefixId.prefix "isCreatorOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R068 ('is date associated with'
    ///             relation)</para>
    ///   <para>rdfs:label : is date associated with </para>
    ///   <para>rdfs:comment : Connects a Date to a Thing that the Date is associated with the
    ///             existence and lifecycle of.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isDateAssociatedWith">rico:isDateAssociatedWith</a>
    /// </summary>
    let isDateAssociatedWith = _prefixId.prefix "isDateAssociatedWith"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R072 ('is death date of'
    ///             relation)</para>
    ///   <para>rdfs:label : is death date of </para>
    ///   <para>rdfs:comment : Connects a Date to a Person who died on that
    ///             Date.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isDeathDateOf">rico:isDeathDateOf</a>
    /// </summary>
    let isDeathDateOf = _prefixId.prefix "isDeathDateOf"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has derived instantiation' object
    ///             property.</para>
    ///   <para>rdfs:label : is derived from instantiation </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R014i ('is derived from instantiation'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isDerivedFromInstantiation">rico:isDerivedFromInstantiation</a>
    /// </summary>
    let isDerivedFromInstantiation = _prefixId.prefix "isDerivedFromInstantiation"
    /// <summary>
    ///   <para>rdfs:label : is documentary form type of</para>
    ///   <para>rdfs:comment : Connects a Documentary Form Type to a Record or Record Part that
    ///             it categorizes.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isDocumentaryFormTypeOf">rico:isDocumentaryFormTypeOf</a>
    /// </summary>
    let isDocumentaryFormTypeOf = _prefixId.prefix "isDocumentaryFormTypeOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R011 (is draft of
    ///             relation)</para>
    ///   <para>rdfs:label : is draft of </para>
    ///   <para>rdfs:comment : Connects a draft to the final version of a
    ///             Record.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isDraftOf">rico:isDraftOf</a>
    /// </summary>
    let isDraftOf = _prefixId.prefix "isDraftOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R071 ('is end date
    ///             of')</para>
    ///   <para>rdfs:label : is end date of </para>
    ///   <para>rdfs:comment : Connects a Date to a Thing whose existence ended on that
    ///             Date.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isEndDateOf">rico:isEndDateOf</a>
    /// </summary>
    let isEndDateOf = _prefixId.prefix "isEndDateOf"
    /// <summary>
    ///   <para>rdfs:label : is equivalent to </para>
    ///   <para>rdfs:comment : Connects two Things that are considered
    ///             equivalent.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isEquivalentTo">rico:isEquivalentTo</a>
    /// </summary>
    let isEquivalentTo = _prefixId.prefix "isEquivalentTo"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R057 ('is event associated with'
    ///             relation)</para>
    ///   <para>rdfs:label : is event associated with </para>
    ///   <para>rdfs:comment : Connects an Event to a Thing that is associated with the
    ///             existence and lifecycle of the Event.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isEventAssociatedWith">rico:isEventAssociatedWith</a>
    /// </summary>
    let isEventAssociatedWith = _prefixId.prefix "isEventAssociatedWith"
    /// <summary>
    ///   <para>rdfs:label : is event type of</para>
    ///   <para>rdfs:comment : Connects an Event Type to an Event that is
    ///             categorizes.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isEventTypeOf">rico:isEventTypeOf</a>
    /// </summary>
    let isEventTypeOf = _prefixId.prefix "isEventTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is extent of</para>
    ///   <para>rdfs:comment : Connects an Extent to a Record Resource or Instantiation^^xsd:string</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isExtentOf">rico:isExtentOf</a>
    /// </summary>
    let isExtentOf = _prefixId.prefix "isExtentOf"
    /// <summary>
    ///   <para>rdfs:comment : Connects an Extent Type to an Extent that it
    ///             categorizes.</para>
    ///   <para>rdfs:label : is extent type of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isExtentTypeOf">rico:isExtentTypeOf</a>
    /// </summary>
    let isExtentTypeOf = _prefixId.prefix "isExtentTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is family type of</para>
    ///   <para>rdfs:comment : Connects a Family Type to a Family that is
    ///             categorizes.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isFamilyTypeOf">rico:isFamilyTypeOf</a>
    /// </summary>
    let isFamilyTypeOf = _prefixId.prefix "isFamilyTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is from use date of </para>
    ///   <para>rdfs:comment : Connects a Date to an Appellation, when it is the date at which
    ///             the Appellation was first used.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isFromUseDateOf">rico:isFromUseDateOf</a>
    /// </summary>
    let isFromUseDateOf = _prefixId.prefix "isFromUseDateOf"
    /// <summary>
    ///   <para>rdfs:label : is functionally equivalent to</para>
    ///   <para>skos:scopeNote : Two Instantiations, from some point of view, may be considered
    ///             as equivalent. This equivalence is usually based upon the fact that the Instantiations
    ///             have at least the same intellectual content (they instantiate the same Record
    ///             Resource).</para>
    ///   <para>rdfs:comment : Connects two Instantiations which may be considered as
    ///             equivalent. This relation is symmetric.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R035 ('is functionally equivalent to'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isFunctionallyEquivalentTo">rico:isFunctionallyEquivalentTo</a>
    /// </summary>
    let isFunctionallyEquivalentTo = _prefixId.prefix "isFunctionallyEquivalentTo"
    /// <summary>
    ///   <para>rdfs:comment : Connects an Identifier Type and an Identifier that it
    ///             categorizes.</para>
    ///   <para>rdfs:label : is identifier type of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isIdentifierTypeOf">rico:isIdentifierTypeOf</a>
    /// </summary>
    let isIdentifierTypeOf = _prefixId.prefix "isIdentifierTypeOf"

    /// <summary>
    ///   <para>rdfs:comment : Connects two Instantiations. This object property is
    ///             symmetric.</para>
    ///   <para>rdfs:label : is instantiation associated with instantiation </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R034 ('is instantiation associated with
    ///             instantiation' relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isInstantiationAssociatedWithInstantiation">rico:isInstantiationAssociatedWithInstantiation</a>
    /// </summary>
    let isInstantiationAssociatedWithInstantiation = _prefixId.prefix "isInstantiationAssociatedWithInstantiation"

    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has instantiation' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R025i ('is instantiation of'
    ///             relation)</para>
    ///   <para>rdfs:label : is instantiation of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isInstantiationOf">rico:isInstantiationOf</a>
    /// </summary>
    let isInstantiationOf = _prefixId.prefix "isInstantiationOf"
    /// <summary>
    ///   <para>rdfs:label : is last update date of </para>
    ///   <para>rdfs:comment : Connects a Date and a Thing that was last modified at this
    ///             Date.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isLastUpdateDateOf">rico:isLastUpdateDateOf</a>
    /// </summary>
    let isLastUpdateDateOf = _prefixId.prefix "isLastUpdateDateOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R073 ('is modification date of'
    ///             relation)</para>
    ///   <para>rdfs:label : is modification date of </para>
    ///   <para>rdfs:comment : Connects a Date to a Thing that was modified on that
    ///             Date.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isModificationDateOf">rico:isModificationDateOf</a>
    /// </summary>
    let isModificationDateOf = _prefixId.prefix "isModificationDateOf"
    /// <summary>
    ///   <para>rdfs:label : is or was adjacent to</para>
    ///   <para>rdfs:comment : Connects two Places that are or were geographically adjacent.
    ///             This is a symmetric object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R077 ('is or was adjacent to'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasAdjacentTo">rico:isOrWasAdjacentTo</a>
    /// </summary>
    let isOrWasAdjacentTo = _prefixId.prefix "isOrWasAdjacentTo"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R059i ('is or was affected by'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'affects or affected' object property.</para>
    ///   <para>rdfs:label : is or was affected by</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasAffectedBy">rico:isOrWasAffectedBy</a>
    /// </summary>
    let isOrWasAffectedBy = _prefixId.prefix "isOrWasAffectedBy"
    /// <summary>
    ///   <para>rdfs:label : is or was agent name of</para>
    ///   <para>rdfs:comment : Connects an Agent Name to an Agent it designates or
    ///             designated.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasAgentNameOf">rico:isOrWasAgentNameOf</a>
    /// </summary>
    let isOrWasAgentNameOf = _prefixId.prefix "isOrWasAgentNameOf"
    /// <summary>
    ///   <para>rdfs:label : is or was appellation of</para>
    ///   <para>rdfs:comment : Connects an Appellation to a Thing that it designates or
    ///             designated.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasAppellationOf">rico:isOrWasAppellationOf</a>
    /// </summary>
    let isOrWasAppellationOf = _prefixId.prefix "isOrWasAppellationOf"
    /// <summary>
    ///   <para>rdfs:label : is or was category of</para>
    ///   <para>rdfs:comment : Connects a Type (a category) to a Thing that it categorizes or
    ///             categorized.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOf">rico:isOrWasCategoryOf</a>
    /// </summary>
    let isOrWasCategoryOf = _prefixId.prefix "isOrWasCategoryOf"
    /// <summary>
    ///   <para>rdfs:label : is or was category of all members of</para>
    ///   <para>rdfs:comment : Connects a Category (Type) and a Record Set whose all present or
    ///             past Record or Record Part members belong to that Category.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOfAllMembersOf">rico:isOrWasCategoryOfAllMembersOf</a>
    /// </summary>
    let isOrWasCategoryOfAllMembersOf = _prefixId.prefix "isOrWasCategoryOfAllMembersOf"

    /// <summary>
    ///   <para>rdfs:label : is or was category of some members of</para>
    ///   <para>rdfs:comment : Connects a Category (Type) and a Record Set whose some present
    ///             or past Record or Record Part members belong to that Category.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOfSomeMembersOf">rico:isOrWasCategoryOfSomeMembersOf</a>
    /// </summary>
    let isOrWasCategoryOfSomeMembersOf = _prefixId.prefix "isOrWasCategoryOfSomeMembersOf"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R004i ('is or was component of'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'has or had component' object
    ///             property.</para>
    ///   <para>rdfs:label : is or was component of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasComponentOf">rico:isOrWasComponentOf</a>
    /// </summary>
    let isOrWasComponentOf = _prefixId.prefix "isOrWasComponentOf"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has or had constituent' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R003i ('is or was constituent of'
    ///             relation)</para>
    ///   <para>rdfs:label : is or was constituent of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasConstituentOf">rico:isOrWasConstituentOf</a>
    /// </summary>
    let isOrWasConstituentOf = _prefixId.prefix "isOrWasConstituentOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R007i ('is or was contained by'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'contains or contained' object
    ///             property.</para>
    ///   <para>rdfs:label : is or was contained by</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasContainedBy">rico:isOrWasContainedBy</a>
    /// </summary>
    let isOrWasContainedBy = _prefixId.prefix "isOrWasContainedBy"

    /// <summary>
    ///   <para>rdfs:label : is or was content type of all members of</para>
    ///   <para>rdfs:comment : Connects a Content Type and a Record Set whose all past or
    ///             present Record or Record Part members have that Content Type.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasContentTypeOfAllMembersOf">rico:isOrWasContentTypeOfAllMembersOf</a>
    /// </summary>
    let isOrWasContentTypeOfAllMembersOf = _prefixId.prefix "isOrWasContentTypeOfAllMembersOf"

    /// <summary>
    ///   <para>rdfs:label : is or was content type of some members of</para>
    ///   <para>rdfs:comment : Connects a Content Type and a Record Set whose some past or
    ///             present Record or Record Part members have that Content Type.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasContentTypeOfSomeMembersOf">rico:isOrWasContentTypeOfSomeMembersOf</a>
    /// </summary>
    let isOrWasContentTypeOfSomeMembersOf = _prefixId.prefix "isOrWasContentTypeOfSomeMembersOf"

    /// <summary>
    ///   <para>rdfs:comment : Connects an Agent to another Agent it controls or controlled via
    ///             Activities, i.e. controls by function.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R041 ('is or was controller of'
    ///             relation)</para>
    ///   <para>rdfs:label : is or was controller of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasControllerOf">rico:isOrWasControllerOf</a>
    /// </summary>
    let isOrWasControllerOf = _prefixId.prefix "isOrWasControllerOf"
    /// <summary>
    ///   <para>rdfs:label : is or was coordinates of</para>
    ///   <para>rdfs:comment : Connects an instance of Coordinates to a Physical Location it
    ///             locates or located on earth, according to some reference system.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasCoordinatesOf">rico:isOrWasCoordinatesOf</a>
    /// </summary>
    let isOrWasCoordinatesOf = _prefixId.prefix "isOrWasCoordinatesOf"
    /// <summary>
    ///   <para>rdfs:label : is or was corporate body type of</para>
    ///   <para>rdfs:comment : Connects a Corporate Body Type to a Corporate Body that it
    ///             categorizes or categorized.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasCorporateBodyTypeOf">rico:isOrWasCorporateBodyTypeOf</a>
    /// </summary>
    let isOrWasCorporateBodyTypeOf = _prefixId.prefix "isOrWasCorporateBodyTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is or was demographic group of</para>
    ///   <para>rdfs:comment : Connects a Demographic Group to a Person or Group which belongs
    ///             or belonged to it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasDemographicGroupOf">rico:isOrWasDemographicGroupOf</a>
    /// </summary>
    let isOrWasDemographicGroupOf = _prefixId.prefix "isOrWasDemographicGroupOf"
    /// <summary>
    ///   <para>rdfs:label : is or was described by</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R021i ('is or was described by'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'describes or described' object
    ///             property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasDescribedBy">rico:isOrWasDescribedBy</a>
    /// </summary>
    let isOrWasDescribedBy = _prefixId.prefix "isOrWasDescribedBy"

    /// <summary>
    ///   <para>rdfs:label : is or was documentary form type of all members of</para>
    ///   <para>rdfs:comment : Connects a Documentary Form Type and a Record Set whose all past
    ///             or present Record or Record Part members have that Documentary Form Type.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasDocumentaryFormTypeOfAllMembersOf">rico:isOrWasDocumentaryFormTypeOfAllMembersOf</a>
    /// </summary>
    let isOrWasDocumentaryFormTypeOfAllMembersOf = _prefixId.prefix "isOrWasDocumentaryFormTypeOfAllMembersOf"

    /// <summary>
    ///   <para>rdfs:label : is or was documentary form type of some members of</para>
    ///   <para>rdfs:comment : Connects a Documentary Form Type and a Record Set whose some
    ///             past or present Record or Record Part members have that Documentary Form
    ///             Type.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasDocumentaryFormTypeOfSomeMembersOf">rico:isOrWasDocumentaryFormTypeOfSomeMembersOf</a>
    /// </summary>
    let isOrWasDocumentaryFormTypeOfSomeMembersOf = _prefixId.prefix "isOrWasDocumentaryFormTypeOfSomeMembersOf"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R066 ('is or was enforced by'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Rule to an Agent that enforces or enforced the
    ///             Rule.</para>
    ///   <para>rdfs:label : is or was enforced by</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasEnforcedBy">rico:isOrWasEnforcedBy</a>
    /// </summary>
    let isOrWasEnforcedBy = _prefixId.prefix "isOrWasEnforcedBy"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Rule to a Record Resource that expresses or expressed
    ///             the Rule.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R064 ('is or was expressed by'
    ///             relation)</para>
    ///   <para>rdfs:label : is or was expressed by</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasExpressedBy">rico:isOrWasExpressedBy</a>
    /// </summary>
    let isOrWasExpressedBy = _prefixId.prefix "isOrWasExpressedBy"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R039 ('is or was holder of'
    ///             relation)</para>
    ///   <para>rdfs:label : is or was holder of</para>
    ///   <para>rdfs:comment : Connects an Agent to a Record Resource or Instantiation that the
    ///             Agent holds or held.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasHolderOf">rico:isOrWasHolderOf</a>
    /// </summary>
    let isOrWasHolderOf = _prefixId.prefix "isOrWasHolderOf"

    /// <summary>
    ///   <para>rdfs:comment : Connects an Agent to a Record Resource or Instantiation on which
    ///             the Agent has or had some intellectual property rights.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R040 ('is or was holder of intellectual
    ///             property rights of' relation)</para>
    ///   <para>rdfs:label : is or was holder of intellectual property rights of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasHolderOfIntellectualPropertyRightsOf">rico:isOrWasHolderOfIntellectualPropertyRightsOf</a>
    /// </summary>
    let isOrWasHolderOfIntellectualPropertyRightsOf = _prefixId.prefix "isOrWasHolderOfIntellectualPropertyRightsOf"

    /// <summary>
    ///   <para>rdfs:label : is or was identifier of</para>
    ///   <para>rdfs:comment : Connects an Identifier to a Thing that it identified or
    ///             identifies.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasIdentifierOf">rico:isOrWasIdentifierOf</a>
    /// </summary>
    let isOrWasIdentifierOf = _prefixId.prefix "isOrWasIdentifierOf"
    /// <summary>
    ///   <para>rdfs:label : is or was included in</para>
    ///   <para>rdfs:comment : Inverse of 'includes or included' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R024i ('is or was included in'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasIncludedIn">rico:isOrWasIncludedIn</a>
    /// </summary>
    let isOrWasIncludedIn = _prefixId.prefix "isOrWasIncludedIn"
    /// <summary>
    ///   <para>rdfs:label : is or was jurisdiction of</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R076 ('is or was jurisdiction of'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Place to an Agent that has or had jurisdiction over
    ///             the Place.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasJurisdictionOf">rico:isOrWasJurisdictionOf</a>
    /// </summary>
    let isOrWasJurisdictionOf = _prefixId.prefix "isOrWasJurisdictionOf"
    /// <summary>
    ///   <para>rdfs:label : is or was language of</para>
    ///   <para>rdfs:comment : Connects a Language to an Agent, Record or Record Part that uses
    ///             or used it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOf">rico:isOrWasLanguageOf</a>
    /// </summary>
    let isOrWasLanguageOf = _prefixId.prefix "isOrWasLanguageOf"
    /// <summary>
    ///   <para>rdfs:label : is or was language of all members of</para>
    ///   <para>rdfs:comment : Connects a Language and a Record Set whose all present or past
    ///             Record or Record Part members use that Language.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOfAllMembersOf">rico:isOrWasLanguageOfAllMembersOf</a>
    /// </summary>
    let isOrWasLanguageOfAllMembersOf = _prefixId.prefix "isOrWasLanguageOfAllMembersOf"

    /// <summary>
    ///   <para>rdfs:label : is or was language of some members of</para>
    ///   <para>rdfs:comment : Connects a Language and a Record Set whose some present or past
    ///             Record or Record Part members use that Language.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOfSomeMembersOf">rico:isOrWasLanguageOfSomeMembersOf</a>
    /// </summary>
    let isOrWasLanguageOfSomeMembersOf = _prefixId.prefix "isOrWasLanguageOfSomeMembersOf"

    /// <summary>
    ///   <para>rdfs:label : is or was leader of</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R042 ('is or was leader of'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Person to the Group that Person leads or led in the
    ///             past.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasLeaderOf">rico:isOrWasLeaderOf</a>
    /// </summary>
    let isOrWasLeaderOf = _prefixId.prefix "isOrWasLeaderOf"
    /// <summary>
    ///   <para>skos:scopeNote : Connects a Legal Status to an Agent, Record or Record Part
    ///             that it categorized or categorizes.</para>
    ///   <para>rdfs:comment : Connects a Legal Status to an Agent or Record Resource that it
    ///             categorizes.</para>
    ///   <para>rdfs:label : is or was legal status of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOf">rico:isOrWasLegalStatusOf</a>
    /// </summary>
    let isOrWasLegalStatusOf = _prefixId.prefix "isOrWasLegalStatusOf"

    /// <summary>
    ///   <para>rdfs:label : is or was legal status of all members of</para>
    ///   <para>rdfs:comment : Connects a Legal Status and a Record Set whose all past or
    ///             present Record or Record Part members have that Legal Status.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOfAllMembersOf">rico:isOrWasLegalStatusOfAllMembersOf</a>
    /// </summary>
    let isOrWasLegalStatusOfAllMembersOf = _prefixId.prefix "isOrWasLegalStatusOfAllMembersOf"

    /// <summary>
    ///   <para>rdfs:label : is or was legal status of some members of</para>
    ///   <para>rdfs:comment : Connects a Legal Status and a Record Set whose some past or
    ///             present Record or Record Part members have that Legal Status.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOfSomeMembersOf">rico:isOrWasLegalStatusOfSomeMembersOf</a>
    /// </summary>
    let isOrWasLegalStatusOfSomeMembersOf = _prefixId.prefix "isOrWasLegalStatusOfSomeMembersOf"

    /// <summary>
    ///   <para>rdfs:comment : Connects a Place to a Thing that is or was located in the
    ///             Place.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R075 ('is or was location of'
    ///             relation)</para>
    ///   <para>rdfs:label : is or was location of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasLocationOf">rico:isOrWasLocationOf</a>
    /// </summary>
    let isOrWasLocationOf = _prefixId.prefix "isOrWasLocationOf"
    /// <summary>
    ///   <para>rdfs:label : is or was main subject of</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R020i (is or was main subject
    ///             of)</para>
    ///   <para>rdfs:comment : Inverse of 'has or had main subject' object
    ///             property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasMainSubjectOf">rico:isOrWasMainSubjectOf</a>
    /// </summary>
    let isOrWasMainSubjectOf = _prefixId.prefix "isOrWasMainSubjectOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R038 ('is or was manager of'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects an Agent to a Record Resource or Instantiation that the
    ///             Agent managed or manages.</para>
    ///   <para>rdfs:label : is or was manager of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasManagerOf">rico:isOrWasManagerOf</a>
    /// </summary>
    let isOrWasManagerOf = _prefixId.prefix "isOrWasManagerOf"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has or had member' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R055i ('is or was member of'
    ///             relation)</para>
    ///   <para>rdfs:label : is or was member of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasMemberOf">rico:isOrWasMemberOf</a>
    /// </summary>
    let isOrWasMemberOf = _prefixId.prefix "isOrWasMemberOf"
    /// <summary>
    ///   <para>rdfs:label : is or was name of</para>
    ///   <para>rdfs:comment : Connects a Name to a Thing that it designated or
    ///             designates.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasNameOf">rico:isOrWasNameOf</a>
    /// </summary>
    let isOrWasNameOf = _prefixId.prefix "isOrWasNameOf"
    /// <summary>
    ///   <para>rdfs:label : is or was occupation type of</para>
    ///   <para>rdfs:comment : Connects an Occupation Type to a Person whose occupation is or
    ///             was categorized by it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasOccupationTypeOf">rico:isOrWasOccupationTypeOf</a>
    /// </summary>
    let isOrWasOccupationTypeOf = _prefixId.prefix "isOrWasOccupationTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is or was occupied by</para>
    ///   <para>rdfs:comment : Inverse of 'occupies or occupied' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R054i ('is or was occupied by'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasOccupiedBy">rico:isOrWasOccupiedBy</a>
    /// </summary>
    let isOrWasOccupiedBy = _prefixId.prefix "isOrWasOccupiedBy"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Group, Person or Position to a Thing that this Agent
    ///             owns or owned.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R037 ('is or was owner of'
    ///             relation)</para>
    ///   <para>rdfs:label : is or was owner of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasOwnerOf">rico:isOrWasOwnerOf</a>
    /// </summary>
    let isOrWasOwnerOf = _prefixId.prefix "isOrWasOwnerOf"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has or had part' relation.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R002i (is or was part of
    ///             relation)</para>
    ///   <para>rdfs:label : is or was part of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasPartOf">rico:isOrWasPartOf</a>
    /// </summary>
    let isOrWasPartOf = _prefixId.prefix "isOrWasPartOf"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has or had participant' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R058i ('is or was participant in'
    ///             relation)</para>
    ///   <para>rdfs:label : is or was participant in</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasParticipantIn">rico:isOrWasParticipantIn</a>
    /// </summary>
    let isOrWasParticipantIn = _prefixId.prefix "isOrWasParticipantIn"
    /// <summary>
    ///   <para>rdfs:label : is or was performed by</para>
    ///   <para>rdfs:comment : Connects an Activity to an Agent that performed or performs the
    ///             Activity.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R060 ('is or was performed by'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasPerformedBy">rico:isOrWasPerformedBy</a>
    /// </summary>
    let isOrWasPerformedBy = _prefixId.prefix "isOrWasPerformedBy"
    /// <summary>
    ///   <para>rdfs:label : is or was physical location of</para>
    ///   <para>rdfs:comment : Connects a Physical Location to a Place, when it is or was its
    ///             location.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasPhysicalLocationOf">rico:isOrWasPhysicalLocationOf</a>
    /// </summary>
    let isOrWasPhysicalLocationOf = _prefixId.prefix "isOrWasPhysicalLocationOf"
    /// <summary>
    ///   <para>rdfs:label : is or was place name of</para>
    ///   <para>rdfs:comment : Connects a Place Name to a Place that was or is designated by
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasPlaceNameOf">rico:isOrWasPlaceNameOf</a>
    /// </summary>
    let isOrWasPlaceNameOf = _prefixId.prefix "isOrWasPlaceNameOf"
    /// <summary>
    ///   <para>rdfs:label : is or was place type of</para>
    ///   <para>rdfs:comment : Connects a Place Type to a Place that is or was categorized by
    ///             it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasPlaceTypeOf">rico:isOrWasPlaceTypeOf</a>
    /// </summary>
    let isOrWasPlaceTypeOf = _prefixId.prefix "isOrWasPlaceTypeOf"

    /// <summary>
    ///   <para>rdfs:label : is or was record state of all members of</para>
    ///   <para>rdfs:comment : Connects a Record State and a Record Set whose all past or
    ///             present Record or Record Part members have that Record State.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasRecordStateOfAllMembersOf">rico:isOrWasRecordStateOfAllMembersOf</a>
    /// </summary>
    let isOrWasRecordStateOfAllMembersOf = _prefixId.prefix "isOrWasRecordStateOfAllMembersOf"

    /// <summary>
    ///   <para>rdfs:label : is or was record state of some members of</para>
    ///   <para>rdfs:comment : Connects a Record State and a Record Set whose some past or
    ///             present Record or Record Part members have that Record State.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasRecordStateOfSomeMembersOf">rico:isOrWasRecordStateOfSomeMembersOf</a>
    /// </summary>
    let isOrWasRecordStateOfSomeMembersOf = _prefixId.prefix "isOrWasRecordStateOfSomeMembersOf"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R063i ('is or was regulated by'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of the 'regulates or regulated' object
    ///             property.</para>
    ///   <para>rdfs:label : is or was regulated by</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasRegulatedBy">rico:isOrWasRegulatedBy</a>
    /// </summary>
    let isOrWasRegulatedBy = _prefixId.prefix "isOrWasRegulatedBy"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R066i ('is or was responsible for enforcing'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'is or was enforced by' object
    ///             property.</para>
    ///   <para>rdfs:label : is or was responsible for enforcing</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasResponsibleForEnforcing">rico:isOrWasResponsibleForEnforcing</a>
    /// </summary>
    let isOrWasResponsibleForEnforcing = _prefixId.prefix "isOrWasResponsibleForEnforcing"

    /// <summary>
    ///   <para>rdfs:label : is or was rule type of</para>
    ///   <para>rdfs:comment : connects a Rule Type to a Rule that it categorized or
    ///             categorizes.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasRuleTypeOf">rico:isOrWasRuleTypeOf</a>
    /// </summary>
    let isOrWasRuleTypeOf = _prefixId.prefix "isOrWasRuleTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is or was subdivision of</para>
    ///   <para>rdfs:comment : Inverse of 'has or had subdivision' object
    ///             property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R005i ('is or was subdivision'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasSubdivisionOf">rico:isOrWasSubdivisionOf</a>
    /// </summary>
    let isOrWasSubdivisionOf = _prefixId.prefix "isOrWasSubdivisionOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R006i ('is or was subevent of'
    ///             relation)</para>
    ///   <para>rdfs:label : is or was subevent of</para>
    ///   <para>rdfs:comment : Inverse of 'has or had subevent' object property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasSubeventOf">rico:isOrWasSubeventOf</a>
    /// </summary>
    let isOrWasSubeventOf = _prefixId.prefix "isOrWasSubeventOf"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'has or had subject' object property.</para>
    ///   <para>rdfs:label : is or was subject of</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RIc-R019i ('is or was subject of'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasSubjectOf">rico:isOrWasSubjectOf</a>
    /// </summary>
    let isOrWasSubjectOf = _prefixId.prefix "isOrWasSubjectOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R045i ('is or was subordinate to'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'has or had subordinate' object
    ///             property.</para>
    ///   <para>rdfs:label : is or was subordinate to</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasSubordinateTo">rico:isOrWasSubordinateTo</a>
    /// </summary>
    let isOrWasSubordinateTo = _prefixId.prefix "isOrWasSubordinateTo"
    /// <summary>
    ///   <para>rdfs:label : is or was title of</para>
    ///   <para>rdfs:comment : Connects a Title to a Record Resource, Instantiation or Rule
    ///             that it designated or designates.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasTitleOf">rico:isOrWasTitleOf</a>
    /// </summary>
    let isOrWasTitleOf = _prefixId.prefix "isOrWasTitleOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R036i ('is or was under authority of'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'has or had authority over' object
    ///             property.</para>
    ///   <para>rdfs:label : is or was under authority of</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOrWasUnderAuthorityOf">rico:isOrWasUnderAuthorityOf</a>
    /// </summary>
    let isOrWasUnderAuthorityOf = _prefixId.prefix "isOrWasUnderAuthorityOf"
    /// <summary>
    ///   <para>rdfs:comment : Connects the original version of a Record to a copy or a later
    ///             version.</para>
    ///   <para>rdfs:label : is original of </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R010 (is original of
    ///             relation)</para>
    ///   <para>skos:scopeNote : There may be zero to many intermediate Records, ignored or
    ///             unknown, between the two connected Records</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isOriginalOf">rico:isOriginalOf</a>
    /// </summary>
    let isOriginalOf = _prefixId.prefix "isOriginalOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R074 ('is place associated with'
    ///             relation)</para>
    ///   <para>rdfs:label : is place associated with </para>
    ///   <para>rdfs:comment : Connects a Place to a Thing that Place is associated with the
    ///             existence and lifecycle of.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isPlaceAssociatedWith">rico:isPlaceAssociatedWith</a>
    /// </summary>
    let isPlaceAssociatedWith = _prefixId.prefix "isPlaceAssociatedWith"
    /// <summary>
    ///   <para>rdfs:label : is production technique type of</para>
    ///   <para>rdfs:comment : Connects a Production Technique Type to an Instantiation whose
    ///             production technique is categorized by it.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isProductionTechniqueTypeOf">rico:isProductionTechniqueTypeOf</a>
    /// </summary>
    let isProductionTechniqueTypeOf = _prefixId.prefix "isProductionTechniqueTypeOf"
    /// <summary>
    ///   <para>rdfs:comment : inverse of 'has provenance' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R026i ('is provenance of'
    ///             relation)</para>
    ///   <para>rdfs:label : is provenance of </para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isProvenanceOf">rico:isProvenanceOf</a>
    /// </summary>
    let isProvenanceOf = _prefixId.prefix "isProvenanceOf"
    /// <summary>
    ///   <para>rdfs:label : isPublisherOf</para>
    ///   <para>rdfs:comment : Connects an Agent to a Record Resource that it
    ///             published.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isPublisherOf">rico:isPublisherOf</a>
    /// </summary>
    let isPublisherOf = _prefixId.prefix "isPublisherOf"
    /// <summary>
    ///   <para>rdfs:label : is receiver of</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R029i ('is receiver of'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'received by' object property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isReceiverOf">rico:isReceiverOf</a>
    /// </summary>
    let isReceiverOf = _prefixId.prefix "isReceiverOf"

    /// <summary>
    ///   <para>rdfs:comment : Connects two Record Resources. This object property is
    ///             symmetric.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R022 ('is record resource associated with
    ///             record resource' relation)</para>
    ///   <para>rdfs:label : is record resource associated with record resource </para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isRecordResourceAssociatedWithRecordResource">rico:isRecordResourceAssociatedWithRecordResource</a>
    /// </summary>
    let isRecordResourceAssociatedWithRecordResource = _prefixId.prefix "isRecordResourceAssociatedWithRecordResource"

    /// <summary>
    ///   <para>rdfs:label : is record set type of</para>
    ///   <para>rdfs:comment : Connects a Record Set Type to a Record Set that it
    ///             categorizes.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isRecordSetTypeOf">rico:isRecordSetTypeOf</a>
    /// </summary>
    let isRecordSetTypeOf = _prefixId.prefix "isRecordSetTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is record state of</para>
    ///   <para>rdfs:comment : Connects a Record State to a Record or Record Part whose state
    ///             it categorizes.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isRecordStateOf">rico:isRecordStateOf</a>
    /// </summary>
    let isRecordStateOf = _prefixId.prefix "isRecordStateOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R001 (is related to
    ///             relation)</para>
    ///   <para>rdfs:label : is related to </para>
    ///   <para>rdfs:comment : The most generic object property. Connects an Thing to any other
    ///             Thing This is a symmetric object property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isRelatedTo">rico:isRelatedTo</a>
    /// </summary>
    let isRelatedTo = _prefixId.prefix "isRelatedTo"
    /// <summary>
    ///   <para>rdfs:label : is reply to</para>
    ///   <para>rdfs:comment : Inverse of 'has reply' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R013i ('is reply to'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isReplyTo">rico:isReplyTo</a>
    /// </summary>
    let isReplyTo = _prefixId.prefix "isReplyTo"
    /// <summary>
    ///   <para>rdfs:label : is representation type of</para>
    ///   <para>rdfs:comment : Connects a Representation Type to an Instantiation that it
    ///             categorizes.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isRepresentationTypeOf">rico:isRepresentationTypeOf</a>
    /// </summary>
    let isRepresentationTypeOf = _prefixId.prefix "isRepresentationTypeOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R065i ('is responsible for issuing'
    ///             relation)</para>
    ///   <para>rdfs:label : is responsible for issuing </para>
    ///   <para>rdfs:comment : Inverse of 'issued by' object property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isResponsibleForIssuing">rico:isResponsibleForIssuing</a>
    /// </summary>
    let isResponsibleForIssuing = _prefixId.prefix "isResponsibleForIssuing"
    /// <summary>
    ///   <para>rdfs:comment : Connects a Rule to a Thing that is associated with the existence
    ///             and lifecycle of the Rule.</para>
    ///   <para>rdfs:label : is rule associated with </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R062 ('is rule associated with'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isRuleAssociatedWith">rico:isRuleAssociatedWith</a>
    /// </summary>
    let isRuleAssociatedWith = _prefixId.prefix "isRuleAssociatedWith"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R031i ('is sender of'
    ///             relation)</para>
    ///   <para>rdfs:label : is sender of </para>
    ///   <para>rdfs:comment : Inverse of 'has sender' object property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isSenderOf">rico:isSenderOf</a>
    /// </summary>
    let isSenderOf = _prefixId.prefix "isSenderOf"
    /// <summary>
    ///   <para>rdfs:label : is source of </para>
    ///   <para>rdfs:comment : Connects a Record Resource or an Agent to a Record Resource or
    ///             Relation, when the first is used as a source of information for identifying or
    ///             describing the second one.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isSourceOf">rico:isSourceOf</a>
    /// </summary>
    let isSourceOf = _prefixId.prefix "isSourceOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R016i (is successor
    ///             of)</para>
    ///   <para>rdfs:label : is successor of</para>
    ///   <para>rdfs:comment : Inverse of 'has successor' object property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isSuccessorOf">rico:isSuccessorOf</a>
    /// </summary>
    let isSuccessorOf = _prefixId.prefix "isSuccessorOf"
    /// <summary>
    ///   <para>rdfs:label : is to use date of </para>
    ///   <para>rdfs:comment : Connects a Date to an Appellation, when it is the date till
    ///             which the Appellation was used.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isToUseDateOf">rico:isToUseDateOf</a>
    /// </summary>
    let isToUseDateOf = _prefixId.prefix "isToUseDateOf"
    /// <summary>
    ///   <para>rdfs:label : is unit of measurement of</para>
    ///   <para>rdfs:comment : Inverse of 'has unit of measurement' object property^^xsd:string</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#isUnitOfMeasurementOf">rico:isUnitOfMeasurementOf</a>
    /// </summary>
    let isUnitOfMeasurementOf = _prefixId.prefix "isUnitOfMeasurementOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R065 ('issued by'
    ///             relation)</para>
    ///   <para>rdfs:label : issued by </para>
    ///   <para>rdfs:comment : Connects a Rule to the Agent that issued or published the
    ///             Rule.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#issuedBy">rico:issuedBy</a>
    /// </summary>
    let issuedBy = _prefixId.prefix "issuedBy"
    /// <summary>
    ///   <para>rdfs:label : knowing of relation has source </para>
    ///   <para>rdfs:comment : Connects a Knowing Of Relation to a 'knowing of' Person (a
    ///             Person who has some knowledge of another one.)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#knowingOfRelationHasSource">rico:knowingOfRelationHasSource</a>
    /// </summary>
    let knowingOfRelationHasSource = _prefixId.prefix "knowingOfRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : knowing of relation has target </para>
    ///   <para>rdfs:comment : Connects a Knowing Of Relation to a 'known by' Person (a Person
    ///             on which another one has some has some knowledge.)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#knowingOfRelationHasTarget">rico:knowingOfRelationHasTarget</a>
    /// </summary>
    let knowingOfRelationHasTarget = _prefixId.prefix "knowingOfRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : knowing relation connects </para>
    ///   <para>rdfs:comment : Connects Knowing Relation to any known Person
    ///             involved.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#knowingRelationConnects">rico:knowingRelationConnects</a>
    /// </summary>
    let knowingRelationConnects = _prefixId.prefix "knowingRelationConnects"
    /// <summary>
    ///   <para>rdfs:label : known by </para>
    ///   <para>rdfs:comment : Inverse of 'knows of' object property.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R050i ('known by'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#knownBy">rico:knownBy</a>
    /// </summary>
    let knownBy = _prefixId.prefix "knownBy"
    /// <summary>
    ///   <para>rdfs:label : knows </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R051 ('knows'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects two Persons that directly know each other during their
    ///             existence. This object property is symmetric.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#knows">rico:knows</a>
    /// </summary>
    let knows = _prefixId.prefix "knows"
    /// <summary>
    ///   <para>rdfs:label : knows of </para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R050 ('knows of'
    ///             relation)</para>
    ///   <para>rdfs:comment : Connects a Person to another Person they have some knowledge of
    ///             through time or space.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#knowsOf">rico:knowsOf</a>
    /// </summary>
    let knowsOf = _prefixId.prefix "knowsOf"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : last modification date</para>
    ///   <para>rdfs:comment : Date at which an entity was last updated.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#lastModificationDate">rico:lastModificationDate</a>
    /// </summary>
    let lastModificationDate = _prefixId.prefix "lastModificationDate"
    /// <summary>
    ///   <para>skos:scopeNote : Property of the Coordinates class. If you don't use this
    ///             class, use geographicalCoordinates property, a property of Place class.</para>
    ///   <para>rdfs:label : latitude</para>
    ///   <para>rdfs:comment : Distance in degrees north or south of the
    ///             equator.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#latitude">rico:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    /// <summary>
    ///   <para>rdfs:label : leadership relation has source </para>
    ///   <para>rdfs:comment : Connects a Leadership Relation to a Person who is involved as a
    ///             leader.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#leadershipRelationHasSource">rico:leadershipRelationHasSource</a>
    /// </summary>
    let leadershipRelationHasSource = _prefixId.prefix "leadershipRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : leadership relation has target </para>
    ///   <para>rdfs:comment : Connects a Leadership Relation to a lead Group.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#leadershipRelationHasTarget">rico:leadershipRelationHasTarget</a>
    /// </summary>
    let leadershipRelationHasTarget = _prefixId.prefix "leadershipRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : leadership with position </para>
    ///   <para>rdfs:comment : Connects a Leadership Relation to the Position occupied by the
    ///             leading Person.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#leadershipWithPosition">rico:leadershipWithPosition</a>
    /// </summary>
    let leadershipWithPosition = _prefixId.prefix "leadershipWithPosition"
    /// <summary>
    ///   <para>rdfs:label : location</para>
    ///   <para>skos:example : « Montreal »skos:example : 25 rue Saint-Denis à Parisskos:example : near the church</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A27 (Location
    ///             attribute)</para>
    ///   <para>rdfs:comment : A delimitation of the physical territory of a place. This
    ///             datatype property is used to describe basic human-readable text such as an address, a
    ///             cadastral reference, or less precise information found in a record.</para>
    ///   <para>skos:scopeNote : Use only if you don't use PhysicalLocation class with Place.
    ///             Use the geographicalCoordinates property, or the Coordinates class, record the
    ///             geographical coordinates of the Place.s</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#location">rico:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>skos:scopeNote : Property of the Coordinates class. If you don't use this
    ///             class, use geographicalCoordinates property, a property of Place class.</para>
    ///   <para>rdfs:label : longitude</para>
    ///   <para>rdfs:comment : Distance in degrees east or west of a prime
    ///             meridian.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#longitude">rico:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>rdfs:label : management relation has source </para>
    ///   <para>rdfs:comment : Connects a Management Relation to an Agent who is involved as a
    ///             manager.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#managementRelationHasSource">rico:managementRelationHasSource</a>
    /// </summary>
    let managementRelationHasSource = _prefixId.prefix "managementRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : management relation has target </para>
    ///   <para>rdfs:comment : Connects a Management Relation to a Record Resource or
    ///             Instantiation that is involved as a managed thing.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#managementRelationHasTarget">rico:managementRelationHasTarget</a>
    /// </summary>
    let managementRelationHasTarget = _prefixId.prefix "managementRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : mandate is source of mandate relation </para>
    ///   <para>rdfs:comment : Connects a Mandate to a Mandate Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#mandateIsSourceOfMandateRelation">rico:mandateIsSourceOfMandateRelation</a>
    /// </summary>
    let mandateIsSourceOfMandateRelation = _prefixId.prefix "mandateIsSourceOfMandateRelation"

    /// <summary>
    ///   <para>rdfs:label : mandate relation has source </para>
    ///   <para>rdfs:comment : Connects a Mandate Relation to a Mandate.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#mandateRelationHasSource">rico:mandateRelationHasSource</a>
    /// </summary>
    let mandateRelationHasSource = _prefixId.prefix "mandateRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : mandate relation has target </para>
    ///   <para>rdfs:comment : Connects a Mandate Relation to an Agent who is given the
    ///             authority or competencies to act.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#mandateRelationHasTarget">rico:mandateRelationHasTarget</a>
    /// </summary>
    let mandateRelationHasTarget = _prefixId.prefix "mandateRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : measure</para>
    ///   <para>rdfs:comment : The extent, quantity, amount, or degree of an entity, as
    ///             determined by measurement or calculation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#measure">rico:measure</a>
    /// </summary>
    let measure = _prefixId.prefix "measure"
    /// <summary>
    ///   <para>rdfs:label : membership relation has source </para>
    ///   <para>rdfs:comment : Connects a Membership Relation to the Group that has
    ///             member(s).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#membershipRelationHasSource">rico:membershipRelationHasSource</a>
    /// </summary>
    let membershipRelationHasSource = _prefixId.prefix "membershipRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : membership relation has target </para>
    ///   <para>rdfs:comment : Connects a Membership Relation to a Person who is involved as a
    ///             member.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#membershipRelationHasTarget">rico:membershipRelationHasTarget</a>
    /// </summary>
    let membershipRelationHasTarget = _prefixId.prefix "membershipRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : membership with position </para>
    ///   <para>rdfs:comment : Connects a Membership Relation to the Position occupied by the
    ///             member Person(s).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#membershipWithPosition">rico:membershipWithPosition</a>
    /// </summary>
    let membershipWithPosition = _prefixId.prefix "membershipWithPosition"
    /// <summary>
    ///   <para>rdfs:comment : Inverse of 'migrated into' object property.</para>
    ///   <para>rdfs:label : migrated from</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R015i ('migrated from'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#migratedFrom">rico:migratedFrom</a>
    /// </summary>
    let migratedFrom = _prefixId.prefix "migratedFrom"
    /// <summary>
    ///   <para>skos:scopeNote : Use for digital instantiations.</para>
    ///   <para>rdfs:comment : Connects an Instantiation to a version it has been migrated
    ///             to.</para>
    ///   <para>rdfs:label : migrated into</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R015 ('migrated into'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#migratedInto">rico:migratedInto</a>
    /// </summary>
    let migratedInto = _prefixId.prefix "migratedInto"
    /// <summary>
    ///   <para>rdfs:label : migration relation has source </para>
    ///   <para>rdfs:comment : Connects a Migration Relation to the migrated
    ///             Instantiation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#migrationRelationHasSource">rico:migrationRelationHasSource</a>
    /// </summary>
    let migrationRelationHasSource = _prefixId.prefix "migrationRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : migration relation has target </para>
    ///   <para>rdfs:comment : Connects a Migration Relation to a resulting
    ///             Instantiation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#migrationRelationHasTarget">rico:migrationRelationHasTarget</a>
    /// </summary>
    let migrationRelationHasTarget = _prefixId.prefix "migrationRelationHasTarget"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : modification date</para>
    ///   <para>rdfs:comment : Date of the modification of an entity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#modificationDate">rico:modificationDate</a>
    /// </summary>
    let modificationDate = _prefixId.prefix "modificationDate"
    /// <summary>
    ///   <para>skos:example : hearing servicesskos:example : 4 March 1842skos:example : Digital copy of the Pomarius archival inventory from
    ///             1575skos:example : fundraising, University of Glasgowskos:example : Papers of the Earls of Liverpoolskos:example : The Letter of Neacsu from Campulung to the Mayor of
    ///             Brasovskos:example : Nelson Mandelaskos:example : Sketch Map of the Qatar Peninsula</para>
    ///   <para>skos:scopeNote : Use only if you don't use Name class for handling
    ///             names.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corrresponds to RiC-A28 (Name
    ///             attribute)</para>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : A label, title or term designating the entity in order to make
    ///             it distinguishable from other similar entities. For Record Resource or Instantiation,
    ///             the Name is generally assigned by an Agent as most do not have a Name given when
    ///             created.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#name">rico:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A29 (Normalized Date
    ///             attribute)</para>
    ///   <para>skos:example : 1948-03-03^^xsd:stringskos:example : 1789/1815^^xsd:string</para>
    ///   <para>rdfs:comment : Date representation based on a standard, preferably
    ///             machine-readable.</para>
    ///   <para>rdfs:label : normalized date value</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#normalizedDateValue">rico:normalizedDateValue</a>
    /// </summary>
    let normalizedDateValue = _prefixId.prefix "normalizedDateValue"
    /// <summary>
    ///   <para>rdfs:label : normalized value</para>
    ///   <para>rdfs:comment : Value representation based on a standard, preferably
    ///             machine-readable.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#normalizedValue">rico:normalizedValue</a>
    /// </summary>
    let normalizedValue = _prefixId.prefix "normalizedValue"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R054 ('occupies or occupied'
    ///             relation)</para>
    ///   <para>rdfs:label : occupies or occupied</para>
    ///   <para>rdfs:comment : Connects a Person to a Position they occupy or
    ///             occupied.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#occupiesOrOccupied">rico:occupiesOrOccupied</a>
    /// </summary>
    let occupiesOrOccupied = _prefixId.prefix "occupiesOrOccupied"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R078 ('overlaps or overlapped'
    ///             relation)</para>
    ///   <para>rdfs:label : overlaps or overlapped</para>
    ///   <para>rdfs:comment : Connects two Places that geographically overlap or overlapped.
    ///             This object property is symmetric.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#overlapsOrOverlapped">rico:overlapsOrOverlapped</a>
    /// </summary>
    let overlapsOrOverlapped = _prefixId.prefix "overlapsOrOverlapped"
    /// <summary>
    ///   <para>rdfs:label : ownership relation has source </para>
    ///   <para>rdfs:comment : Connects an Ownership Relation to a Person, Group or Position
    ///             that is involved as an owner.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ownershipRelationHasSource">rico:ownershipRelationHasSource</a>
    /// </summary>
    let ownershipRelationHasSource = _prefixId.prefix "ownershipRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : owner ship relation has target </para>
    ///   <para>rdfs:comment : Connects an Ownership Relation to a Thing that is
    ///             owned.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ownershipRelationHasTarget">rico:ownershipRelationHasTarget</a>
    /// </summary>
    let ownershipRelationHasTarget = _prefixId.prefix "ownershipRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : performance relation has source </para>
    ///   <para>rdfs:comment : Connects a Performance Relation to a performed
    ///             Activity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#performanceRelationHasSource">rico:performanceRelationHasSource</a>
    /// </summary>
    let performanceRelationHasSource = _prefixId.prefix "performanceRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : performance relation has target </para>
    ///   <para>rdfs:comment : Connects a Performance Relation to a performing
    ///             Agent.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#performanceRelationHasTarget">rico:performanceRelationHasTarget</a>
    /// </summary>
    let performanceRelationHasTarget = _prefixId.prefix "performanceRelationHasTarget"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R060i ('performs or performed'
    ///             relation)</para>
    ///   <para>rdfs:label : performs or performed</para>
    ///   <para>rdfs:comment : Inverse of 'is or was performed by' object
    ///             property.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#performsOrPerformed">rico:performsOrPerformed</a>
    /// </summary>
    let performsOrPerformed = _prefixId.prefix "performsOrPerformed"

    /// <summary>
    ///   <para>rdfs:label : person has correspondence relation </para>
    ///   <para>rdfs:comment : Connects a Person to a Correspondence Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personHasCorrespondenceRelation">rico:personHasCorrespondenceRelation</a>
    /// </summary>
    let personHasCorrespondenceRelation = _prefixId.prefix "personHasCorrespondenceRelation"

    /// <summary>
    ///   <para>rdfs:label : person has family relation </para>
    ///   <para>rdfs:comment : Connects a Person to a Family Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personHasFamilyRelation">rico:personHasFamilyRelation</a>
    /// </summary>
    let personHasFamilyRelation = _prefixId.prefix "personHasFamilyRelation"
    /// <summary>
    ///   <para>rdfs:label : person has knowing relation </para>
    ///   <para>rdfs:comment : Connects a Person to a Knowing Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personHasKnowingRelation">rico:personHasKnowingRelation</a>
    /// </summary>
    let personHasKnowingRelation = _prefixId.prefix "personHasKnowingRelation"
    /// <summary>
    ///   <para>rdfs:label : person has sibling relation </para>
    ///   <para>rdfs:comment : Connects a Person to a Sibling Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personHasSiblingRelation">rico:personHasSiblingRelation</a>
    /// </summary>
    let personHasSiblingRelation = _prefixId.prefix "personHasSiblingRelation"
    /// <summary>
    ///   <para>rdfs:label : person has spouse relation </para>
    ///   <para>rdfs:comment : Connects a Person to a Spouse Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personHasSpouseRelation">rico:personHasSpouseRelation</a>
    /// </summary>
    let personHasSpouseRelation = _prefixId.prefix "personHasSpouseRelation"
    /// <summary>
    ///   <para>rdfs:label : person is source of child relation </para>
    ///   <para>rdfs:comment : Connects a Person (as a parent) to a Child
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfChildRelation">rico:personIsSourceOfChildRelation</a>
    /// </summary>
    let personIsSourceOfChildRelation = _prefixId.prefix "personIsSourceOfChildRelation"

    /// <summary>
    ///   <para>rdfs:label : person is source of descendance relation </para>
    ///   <para>rdfs:comment : Connects a Person (as an ancestor) to a Descendance
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfDescendanceRelation">rico:personIsSourceOfDescendanceRelation</a>
    /// </summary>
    let personIsSourceOfDescendanceRelation = _prefixId.prefix "personIsSourceOfDescendanceRelation"

    /// <summary>
    ///   <para>rdfs:label : person is source of knowing of relation </para>
    ///   <para>rdfs:comment : Connects a Person (who has some knowledge of another one) to a
    ///             Knowing Of Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfKnowingOfRelation">rico:personIsSourceOfKnowingOfRelation</a>
    /// </summary>
    let personIsSourceOfKnowingOfRelation = _prefixId.prefix "personIsSourceOfKnowingOfRelation"

    /// <summary>
    ///   <para>rdfs:label : person is source of leadership relation </para>
    ///   <para>rdfs:comment : Connects a Person (as a leader) to a Leadership
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfLeadershipRelation">rico:personIsSourceOfLeadershipRelation</a>
    /// </summary>
    let personIsSourceOfLeadershipRelation = _prefixId.prefix "personIsSourceOfLeadershipRelation"

    /// <summary>
    ///   <para>rdfs:label : person is source of position holding relation </para>
    ///   <para>rdfs:comment : Connects a Person (who occupies a Position) to a Position
    ///             Holding Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfPositionHoldingRelation">rico:personIsSourceOfPositionHoldingRelation</a>
    /// </summary>
    let personIsSourceOfPositionHoldingRelation = _prefixId.prefix "personIsSourceOfPositionHoldingRelation"

    /// <summary>
    ///   <para>rdfs:label : person is source of teaching relation </para>
    ///   <para>rdfs:comment : Connects a Person (as a teacher) to a Teaching
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfTeachingRelation">rico:personIsSourceOfTeachingRelation</a>
    /// </summary>
    let personIsSourceOfTeachingRelation = _prefixId.prefix "personIsSourceOfTeachingRelation"

    /// <summary>
    ///   <para>rdfs:label : person is target of child relation </para>
    ///   <para>rdfs:comment : Connects a Person (as a child) to a Child
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfChildRelation">rico:personIsTargetOfChildRelation</a>
    /// </summary>
    let personIsTargetOfChildRelation = _prefixId.prefix "personIsTargetOfChildRelation"

    /// <summary>
    ///   <para>rdfs:label : person is target of descendance relation </para>
    ///   <para>rdfs:comment : Connects a Person (as a descendant) to a Descendance
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfDescendanceRelation">rico:personIsTargetOfDescendanceRelation</a>
    /// </summary>
    let personIsTargetOfDescendanceRelation = _prefixId.prefix "personIsTargetOfDescendanceRelation"

    /// <summary>
    ///   <para>rdfs:label : person is target of knowing of relation </para>
    ///   <para>rdfs:comment : Connects a Person (of which another Person has some knowledge)
    ///             to a Knowing Of Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfKnowingOfRelation">rico:personIsTargetOfKnowingOfRelation</a>
    /// </summary>
    let personIsTargetOfKnowingOfRelation = _prefixId.prefix "personIsTargetOfKnowingOfRelation"

    /// <summary>
    ///   <para>rdfs:label : person is target of membership relation </para>
    ///   <para>rdfs:comment : Connects a Person (as a member of a Group) to a Membership
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfMembershipRelation">rico:personIsTargetOfMembershipRelation</a>
    /// </summary>
    let personIsTargetOfMembershipRelation = _prefixId.prefix "personIsTargetOfMembershipRelation"

    /// <summary>
    ///   <para>rdfs:label : person is target of teaching relation </para>
    ///   <para>rdfs:comment : Connects a Person (as a student) to a Teaching
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfTeachingRelation">rico:personIsTargetOfTeachingRelation</a>
    /// </summary>
    let personIsTargetOfTeachingRelation = _prefixId.prefix "personIsTargetOfTeachingRelation"

    /// <summary>
    ///   <para>skos:example : watermarkedskos:example : emulsion flakingskos:example : carrier heavily foxedskos:example : British Library binding</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A31 (Physical Characteristics
    ///             attribute)</para>
    ///   <para>rdfs:comment : Information about the physical features of the Instantiation.
    ///             Includes information about the physical nature and condition such as conservation
    ///             status.</para>
    ///   <para>rdfs:label : physical characteristics</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#physicalCharacteristics">rico:physicalCharacteristics</a>
    /// </summary>
    let physicalCharacteristics = _prefixId.prefix "physicalCharacteristics"
    /// <summary>
    ///   <para>skos:scopeNote : Provided for usability reasons. Use only if you cannot use the
    ///             subproperties (particularly if the same free text is being used in your current metadata
    ///             for describing the record resource, carrier and instantiation extent).</para>
    ///   <para>rdfs:label : physical or logical extent</para>
    ///   <para>rdfs:comment : Countable characteristics of the content of an entity expressed
    ///             as a quantity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#physicalOrLogicalExtent">rico:physicalOrLogicalExtent</a>
    /// </summary>
    let physicalOrLogicalExtent = _prefixId.prefix "physicalOrLogicalExtent"
    /// <summary>
    ///   <para>rdfs:label : place is source of place relation </para>
    ///   <para>rdfs:comment : Connects a Place (as associated to a Thing) to a Place
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#placeIsSourceOfPlaceRelation">rico:placeIsSourceOfPlaceRelation</a>
    /// </summary>
    let placeIsSourceOfPlaceRelation = _prefixId.prefix "placeIsSourceOfPlaceRelation"
    /// <summary>
    ///   <para>rdfs:label : place relation has source </para>
    ///   <para>rdfs:comment : Connects a Place Relation to the Place concerned.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#placeRelationHasSource">rico:placeRelationHasSource</a>
    /// </summary>
    let placeRelationHasSource = _prefixId.prefix "placeRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : place relation has target </para>
    ///   <para>rdfs:comment : Connects a Place Relation to a Thing that is associated to the
    ///             Place.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#placeRelationHasTarget">rico:placeRelationHasTarget</a>
    /// </summary>
    let placeRelationHasTarget = _prefixId.prefix "placeRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : position holding relation has source </para>
    ///   <para>rdfs:comment : Connects a Position Holding Relation to a Person (who occupies a
    ///             Position).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#positionHoldingRelationHasSource">rico:positionHoldingRelationHasSource</a>
    /// </summary>
    let positionHoldingRelationHasSource = _prefixId.prefix "positionHoldingRelationHasSource"

    /// <summary>
    ///   <para>rdfs:label : position holding relation has target </para>
    ///   <para>rdfs:comment : Connects a Position Holding Relation to a Position (that is
    ///             occupied).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#positionHoldingRelationHasTarget">rico:positionHoldingRelationHasTarget</a>
    /// </summary>
    let positionHoldingRelationHasTarget = _prefixId.prefix "positionHoldingRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : position is context of leadership relation </para>
    ///   <para>rdfs:comment : Connects a Position to a Leadership Relation (the leading Person
    ///             occupies that Position).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#positionIsContextOfLeadershipRelation">rico:positionIsContextOfLeadershipRelation</a>
    /// </summary>
    let positionIsContextOfLeadershipRelation = _prefixId.prefix "positionIsContextOfLeadershipRelation"

    /// <summary>
    ///   <para>rdfs:label : position is context of membership relation </para>
    ///   <para>rdfs:comment : Connects a Position to a Membership Relation (the member Person
    ///             occupies that Position).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#positionIsContextOfMembershipRelation">rico:positionIsContextOfMembershipRelation</a>
    /// </summary>
    let positionIsContextOfMembershipRelation = _prefixId.prefix "positionIsContextOfMembershipRelation"

    /// <summary>
    ///   <para>rdfs:label : position is source of position to group relation </para>
    ///   <para>rdfs:comment : Connects a Position (that exists within a Group) to a Position
    ///             to Group Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#positionIsSourceOfPositionToGroupRelation">rico:positionIsSourceOfPositionToGroupRelation</a>
    /// </summary>
    let positionIsSourceOfPositionToGroupRelation = _prefixId.prefix "positionIsSourceOfPositionToGroupRelation"

    /// <summary>
    ///   <para>rdfs:label : position is target of position holding relation </para>
    ///   <para>rdfs:comment : Connects a Position (that is occupied by a Person) to a Position
    ///             Holding Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#positionIsTargetOfPositionHoldingRelation">rico:positionIsTargetOfPositionHoldingRelation</a>
    /// </summary>
    let positionIsTargetOfPositionHoldingRelation = _prefixId.prefix "positionIsTargetOfPositionHoldingRelation"

    /// <summary>
    ///   <para>rdfs:label : position to group relation has source </para>
    ///   <para>rdfs:comment : Connects a Position to Group Relation to a Position (that exists
    ///             in a Group).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#positionToGroupRelationHasSource">rico:positionToGroupRelationHasSource</a>
    /// </summary>
    let positionToGroupRelationHasSource = _prefixId.prefix "positionToGroupRelationHasSource"

    /// <summary>
    ///   <para>rdfs:label : position to group relation has target </para>
    ///   <para>rdfs:comment : Connects a Position to Group Relation to a Group (in which a
    ///             Position exists).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#positionToGroupRelationHasTarget">rico:positionToGroupRelationHasTarget</a>
    /// </summary>
    let positionToGroupRelationHasTarget = _prefixId.prefix "positionToGroupRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : precedes in time</para>
    ///   <para>rdfs:comment : Connects a Thing to a Thing that follows it in chronological
    ///             order.</para>
    ///   <para>skos:scopeNote : There may actually be zero to many intermediate Entities,
    ///             ignored or unknown, in the chronological sequence between the two connected
    ///             Entities.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R009 ('precedes in time'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#precedesInTime">rico:precedesInTime</a>
    /// </summary>
    let precedesInTime = _prefixId.prefix "precedesInTime"
    /// <summary>
    ///   <para>skos:scopeNote : The relation does not specify by itself what criteria are used
    ///             for ordering the sequence. There may actually be zero to many intermediate Entities,
    ///             ignored or unkown, in the sequence between the two connected Things. Can be used, for
    ///             example, for specifying that some Record 'precedes' (has next) some Record within a
    ///             Record Set.</para>
    ///   <para>rdfs:comment : Connects a Thing to a Thing that follows or followed it in some
    ///             sequence.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R008 ('precedes or preceded'
    ///             relation)</para>
    ///   <para>rdfs:label : precedes or preceded</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#precedesOrPreceded">rico:precedesOrPreceded</a>
    /// </summary>
    let precedesOrPreceded = _prefixId.prefix "precedesOrPreceded"
    /// <summary>
    ///   <para>rdfs:label : production technique</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A33 (Production Technique
    ///             attribute)</para>
    ///   <para>skos:example : handwritingskos:example : engravingskos:example : optical recordingskos:example : magnetic recording</para>
    ///   <para>skos:scopeNote : Use only if you have free text or don't have a controlled
    ///             vocabulary for production techniques (in this case, use the ProductionTechniqueType
    ///             class)</para>
    ///   <para>rdfs:comment : Method used in the representation of information on the
    ///             Instantiation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#productionTechnique">rico:productionTechnique</a>
    /// </summary>
    let productionTechnique = _prefixId.prefix "productionTechnique"
    /// <summary>
    ///   <para>rdfs:label : provenance relation has source </para>
    ///   <para>rdfs:comment : Connects a Provenance Relation to a Record Resource or
    ///             Instantiation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#provenanceRelationHasSource">rico:provenanceRelationHasSource</a>
    /// </summary>
    let provenanceRelationHasSource = _prefixId.prefix "provenanceRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : provenance relation has target </para>
    ///   <para>rdfs:comment : Connects a Provenance Relation to an Agent or
    ///             Activity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#provenanceRelationHasTarget">rico:provenanceRelationHasTarget</a>
    /// </summary>
    let provenanceRelationHasTarget = _prefixId.prefix "provenanceRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : proxy for </para>
    ///   <para>rdfs:comment : Connects a Proxy to the Record Resource it stands for in the
    ///             specific context of a Record Set.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#proxyFor">rico:proxyFor</a>
    /// </summary>
    let proxyFor = _prefixId.prefix "proxyFor"
    /// <summary>
    ///   <para>rdfs:label : proxy in </para>
    ///   <para>rdfs:comment : Connects a Proxy to the Record Set in which it stands for
    ///             (represents) another Record Resource.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#proxyIn">rico:proxyIn</a>
    /// </summary>
    let proxyIn = _prefixId.prefix "proxyIn"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : publication date</para>
    ///   <para>rdfs:comment : Date of the publication of a Record Resource.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#publicationDate">rico:publicationDate</a>
    /// </summary>
    let publicationDate = _prefixId.prefix "publicationDate"
    /// <summary>
    ///   <para>skos:example : some loss of text due to rodent damageskos:example : Black and white digitization may have led to loss of some
    ///             information.skos:example : some loss of information due to poor quality of image
    ///             capture</para>
    ///   <para>rdfs:comment : Conditions of an Instantiation that impact the legibility or
    ///             completeness of Record Resource, and thus the viability of its use. Conditions may be
    ///             associated with deficiencies in the processes of Record (re)creation or capture, or the
    ///             deterioration of the Instantiation (e.g. its carrier) causing loss of information of the
    ///             record over time</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A34 (Quality of Representation
    ///             attribute)</para>
    ///   <para>rdfs:label : quality of representation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#qualityOfRepresentation">rico:qualityOfRepresentation</a>
    /// </summary>
    let qualityOfRepresentation = _prefixId.prefix "qualityOfRepresentation"
    /// <summary>
    ///   <para>rdfs:comment : Machine-readable quantity.^^xsd:string</para>
    ///   <para>skos:scopeNote : Use if you use the Extent class and its properties for
    ///             handling an accurate description of the extent of a resource..</para>
    ///   <para>rdfs:label : quantity</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#quantity">rico:quantity</a>
    /// </summary>
    let quantity = _prefixId.prefix "quantity"

    /// <summary>
    ///   <para>rdfs:label : record is source of authorship relation</para>
    ///   <para>rdfs:comment : Connects a Record and an Authorship Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordIsSourceOfAuthorshipRelation">rico:recordIsSourceOfAuthorshipRelation</a>
    /// </summary>
    let recordIsSourceOfAuthorshipRelation = _prefixId.prefix "recordIsSourceOfAuthorshipRelation"

    /// <summary>
    ///   <para>skos:example : 6 photographsskos:example : 2 filmsskos:example : 34 poemsskos:example : 6 mapsskos:example : 2.065.735 charactersskos:example : 1,500 wordsskos:example : 3 minutes and 24 seconds</para>
    ///   <para>skos:scopeNote : The number, size or duration of the information content
    ///             unit(s) remains the same even if the information is instantiated in various carriers.
    ///             For example, a file of 1500 words (Record Resource Extent) may have Instantiation Extent
    ///             3kb as a Word document and 5kb as a PDF file, and instantiations may be represented on a
    ///             CD of 700mb (Carrier Extent). Use if you don't use RecordResourceExtent class and its
    ///             properties for handling such information.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A35 (Record Resource extent
    ///             attribute)</para>
    ///   <para>rdfs:label : Record Resource extent</para>
    ///   <para>rdfs:comment : The quantity of information content as human experienced
    ///             represented in the Record Resource. The method and precision of expressing the quantity
    ///             of information represented in a Record Resource will vary by the kind of Record Resource
    ///             being described as well as by processing economy constraints. For record sets, quantity
    ///             may be expressed as number of records, or, for analogue records in particular, by the
    ///             physical storage dimensions of the Record members. For individual records or record
    ///             parts, quantity may be expressed in more precise terms. Use if you don't use
    ///             RecordResourceExtent class and its properties for handling such
    ///             information.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceExtent">rico:recordResourceExtent</a>
    /// </summary>
    let recordResourceExtent = _prefixId.prefix "recordResourceExtent"

    /// <summary>
    ///   <para>rdfs:label : record resource genetic relation connects </para>
    ///   <para>rdfs:comment : Connects a Record Resource Genetic Relation to one of the
    ///             associated Record Resources.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceGeneticRelationConnects">rico:recordResourceGeneticRelationConnects</a>
    /// </summary>
    let recordResourceGeneticRelationConnects = _prefixId.prefix "recordResourceGeneticRelationConnects"

    /// <summary>
    ///   <para>rdfs:label : record resource holding relation has source </para>
    ///   <para>rdfs:comment : Connects a Record Resource Holding Relation to an Agent (as the
    ///             holder of a Record Resource or Instantiation).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceHoldingRelationHasSource">rico:recordResourceHoldingRelationHasSource</a>
    /// </summary>
    let recordResourceHoldingRelationHasSource = _prefixId.prefix "recordResourceHoldingRelationHasSource"

    /// <summary>
    ///   <para>rdfs:label : record resource holding relation has target </para>
    ///   <para>rdfs:comment : Connects a Record Resource Holding Relation to a Record Resource
    ///             or Instantiation (that is held by an Agent).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceHoldingRelationHasTarget">rico:recordResourceHoldingRelationHasTarget</a>
    /// </summary>
    let recordResourceHoldingRelationHasTarget = _prefixId.prefix "recordResourceHoldingRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : record resource is connected to record resource genetic relation
    ///         </para>
    ///   <para>rdfs:comment : Connects a Record Resource to a Record Resource Genetic
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceIsConnectedToRecordResourceGeneticRelation">rico:recordResourceIsConnectedToRecordResourceGeneticRelation</a>
    /// </summary>
    let recordResourceIsConnectedToRecordResourceGeneticRelation = _prefixId.prefix "recordResourceIsConnectedToRecordResourceGeneticRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource is connected to record resource relation
    ///         </para>
    ///   <para>rdfs:comment : Connects a Record Resource to a Record Resource
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceIsConnectedToRecordResourceRelation">rico:recordResourceIsConnectedToRecordResourceRelation</a>
    /// </summary>
    let recordResourceIsConnectedToRecordResourceRelation = _prefixId.prefix "recordResourceIsConnectedToRecordResourceRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource is source of record resource to instantiation
    ///             relation </para>
    ///   <para>rdfs:comment : Connects a Record Resource (that was instantiated) to a Record
    ///             Resource To Instantiation Relation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceIsSourceOfRecordResourceToInstantiationRelation">rico:recordResourceIsSourceOfRecordResourceToInstantiationRelation</a>
    /// </summary>
    let recordResourceIsSourceOfRecordResourceToInstantiationRelation = _prefixId.prefix "recordResourceIsSourceOfRecordResourceToInstantiationRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource or instantiation is source of accumulation
    ///             relation </para>
    ///   <para>rdfs:comment : Connects a Record Resource or Instantiation (that is
    ///             accumulated) to an Accumulation Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfAccumulationRelation">rico:recordResourceOrInstantiationIsSourceOfAccumulationRelation</a>
    /// </summary>
    let recordResourceOrInstantiationIsSourceOfAccumulationRelation = _prefixId.prefix "recordResourceOrInstantiationIsSourceOfAccumulationRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource or instantiation is source of activity
    ///             documentation relation </para>
    ///   <para>rdfs:comment : Connects a Record Resource or Instantiation (that documents an
    ///             Activity) to an Activity Documentation Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation">rico:recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation</a>
    /// </summary>
    let recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation = _prefixId.prefix "recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource or instantiation is source of agent origination
    ///             relation </para>
    ///   <para>rdfs:comment : Connects a Record Resource or Instantiation (that is created,
    ///             sent or accumulated) to an Agent Origination Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfAgentOriginationRelation">rico:recordResourceOrInstantiationIsSourceOfAgentOriginationRelation</a>
    /// </summary>
    let recordResourceOrInstantiationIsSourceOfAgentOriginationRelation = _prefixId.prefix "recordResourceOrInstantiationIsSourceOfAgentOriginationRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource or instantiation is source of creation relation
    ///         </para>
    ///   <para>rdfs:comment : Connects a Record Resource or Instantiation (that is created) to
    ///             a Creation Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfCreationRelation">rico:recordResourceOrInstantiationIsSourceOfCreationRelation</a>
    /// </summary>
    let recordResourceOrInstantiationIsSourceOfCreationRelation = _prefixId.prefix "recordResourceOrInstantiationIsSourceOfCreationRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource or instantiation is source of provenance relation
    ///         </para>
    ///   <para>rdfs:comment : Connects a Record Resource or Instantiation (that is created or
    ///             accumulated by an Agent, or documents an Activity) to a Provenance
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfProvenanceRelation">rico:recordResourceOrInstantiationIsSourceOfProvenanceRelation</a>
    /// </summary>
    let recordResourceOrInstantiationIsSourceOfProvenanceRelation = _prefixId.prefix "recordResourceOrInstantiationIsSourceOfProvenanceRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource or instantiation is target of intellectual
    ///             property rights relation </para>
    ///   <para>rdfs:comment : Connects a Record Resource or Instantiation (on which some
    ///             intellectual property rights are held) to an Intellectual Property Rights
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation">rico:recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation</a>
    /// </summary>
    let recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation =
        _prefixId.prefix "recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource or instantiation is target of management relation
    ///         </para>
    ///   <para>rdfs:comment : Connects a Record Resource or Instantiation (that is managed by
    ///             an Agent) to a Management Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfManagementRelation">rico:recordResourceOrInstantiationIsTargetOfManagementRelation</a>
    /// </summary>
    let recordResourceOrInstantiationIsTargetOfManagementRelation = _prefixId.prefix "recordResourceOrInstantiationIsTargetOfManagementRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource or instantiation is target of record resource
    ///             holding relation </para>
    ///   <para>rdfs:comment : Connects a Record Resource or Instantiation (that is held by an
    ///             Agent) to a Record Resource Holding Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation">rico:recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation</a>
    /// </summary>
    let recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation = _prefixId.prefix "recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation"

    /// <summary>
    ///   <para>rdfs:label : record resource relation connects </para>
    ///   <para>rdfs:comment : Connects a Record Resource relation to one of the related Record
    ///             Resources.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceRelationConnects">rico:recordResourceRelationConnects</a>
    /// </summary>
    let recordResourceRelationConnects = _prefixId.prefix "recordResourceRelationConnects"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Specialization of RiC-A40 (Structure
    ///             attribute)</para>
    ///   <para>skos:example : The series have the files arranged according to the alphabetical
    ///             order of the places concerned.skos:example : Inside each file, the records are arranged
    ///             chronologically.skos:example : The database has 3 related tables: names, addresses, and
    ///             passport numbers.skos:example : The record has 2 appendixes, comprising a full account of the
    ///             income from car taxes and real estate taxes.</para>
    ///   <para>rdfs:label : Record Resource structure</para>
    ///   <para>rdfs:comment : Information about the intellectual arrangement and composition
    ///             of a Record Resource. For Record and Record Part, it encompasses information about the
    ///             intellectual composition of the record, the presence of record parts and their
    ///             functions. For Record Set, it encompasses information about the methodology or criteria
    ///             used for arranging the Record Set members or Record members within the containing Record
    ///             Set</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceStructure">rico:recordResourceStructure</a>
    /// </summary>
    let recordResourceStructure = _prefixId.prefix "recordResourceStructure"

    /// <summary>
    ///   <para>rdfs:label : record resource to instantiation relation has source </para>
    ///   <para>rdfs:comment : Connects a Record Resource To Instantiation Relation to the
    ///             Record Resource (that was instantiated). </para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceToInstantiationRelationHasSource">rico:recordResourceToInstantiationRelationHasSource</a>
    /// </summary>
    let recordResourceToInstantiationRelationHasSource = _prefixId.prefix "recordResourceToInstantiationRelationHasSource"

    /// <summary>
    ///   <para>rdfs:label : record resource to instantiation relation has target </para>
    ///   <para>rdfs:comment : Connects a Record Resource To Instantiation Relation to an
    ///             Instantiation of the involved Record Resource. </para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#recordResourceToInstantiationRelationHasTarget">rico:recordResourceToInstantiationRelationHasTarget</a>
    /// </summary>
    let recordResourceToInstantiationRelationHasTarget = _prefixId.prefix "recordResourceToInstantiationRelationHasTarget"

    /// <summary>
    ///   <para>rdfs:label : reference system</para>
    ///   <para>rdfs:comment : Framework or standard used to represent an
    ///             information.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#referenceSystem">rico:referenceSystem</a>
    /// </summary>
    let referenceSystem = _prefixId.prefix "referenceSystem"
    /// <summary>
    ///   <para>rdfs:label : regulates or regulated</para>
    ///   <para>rdfs:comment : Connects a Rule to a Thing that it regulates or
    ///             regulated.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R063 ('regulates or regulated'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#regulatesOrRegulated">rico:regulatesOrRegulated</a>
    /// </summary>
    let regulatesOrRegulated = _prefixId.prefix "regulatesOrRegulated"
    /// <summary>
    ///   <para>rdfs:label : relation connects </para>
    ///   <para>rdfs:comment : Connects an n-ary Relation to any of the Things
    ///             involved.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#relationConnects">rico:relationConnects</a>
    /// </summary>
    let relationConnects = _prefixId.prefix "relationConnects"
    /// <summary>
    ///   <para>skos:scopeNote : The secondary entity may be, for instance, a Position or a
    ///             Role Type.</para>
    ///   <para>rdfs:label : relation has context </para>
    ///   <para>rdfs:comment : Connects an n-ary Relation to a Thing that is a secondary,
    ///             contextual entity during the existence of the Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#relationHasContext">rico:relationHasContext</a>
    /// </summary>
    let relationHasContext = _prefixId.prefix "relationHasContext"
    /// <summary>
    ///   <para>rdfs:label : relation has source </para>
    ///   <para>rdfs:comment : Connects an n-ary Relation to a Thing that is its
    ///             source.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#relationHasSource">rico:relationHasSource</a>
    /// </summary>
    let relationHasSource = _prefixId.prefix "relationHasSource"
    /// <summary>
    ///   <para>rdfs:label : relation has target </para>
    ///   <para>rdfs:comment : Connects an n-ary Relation to a Thing that is its
    ///             target.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#relationHasTarget">rico:relationHasTarget</a>
    /// </summary>
    let relationHasTarget = _prefixId.prefix "relationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : Relation state</para>
    ///   <para>rdfs:comment : Used to qualify the state of a Relation (e. g. present, past,
    ///             ongoing, unknown).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#relationState">rico:relationState</a>
    /// </summary>
    let relationState = _prefixId.prefix "relationState"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R061i ('results or resulted from'
    ///             relation)</para>
    ///   <para>rdfs:comment : Inverse of 'results or resulted in' object
    ///             property.</para>
    ///   <para>rdfs:label : results or resulted from</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#resultsOrResultedFrom">rico:resultsOrResultedFrom</a>
    /// </summary>
    let resultsOrResultedFrom = _prefixId.prefix "resultsOrResultedFrom"
    /// <summary>
    ///   <para>rdfs:comment : Connects an Event to a Thing that results or resulted from the
    ///             Event.</para>
    ///   <para>rdfs:label : results or resulted in</para>
    ///   <para>rico:RiCCMCorrespondingComponent : RiC-R061 ('results or resulted in'
    ///             relation)</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#resultsOrResultedIn">rico:resultsOrResultedIn</a>
    /// </summary>
    let resultsOrResultedIn = _prefixId.prefix "resultsOrResultedIn"

    /// <summary>
    ///   <para>rdfs:label : role is context of creation relation </para>
    ///   <para>rdfs:comment : Connects a Role Type to a Creation Relation (this Role Type
    ///             being the specific role played by the creating Person in the context of this
    ///             Relation).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#roleIsContextOfCreationRelation">rico:roleIsContextOfCreationRelation</a>
    /// </summary>
    let roleIsContextOfCreationRelation = _prefixId.prefix "roleIsContextOfCreationRelation"

    /// <summary>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use the Rule class for handling rules.</para>
    ///   <para>rdfs:label : rule followed</para>
    ///   <para>rdfs:comment : The rule or conditions that govern the existence or lifecycle of
    ///             a Thing.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ruleFollowed">rico:ruleFollowed</a>
    /// </summary>
    let ruleFollowed = _prefixId.prefix "ruleFollowed"
    /// <summary>
    ///   <para>rdfs:label : rule is source of rule relation </para>
    ///   <para>rdfs:comment : Connects a Rule to a Rule Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ruleIsSourceOfRuleRelation">rico:ruleIsSourceOfRuleRelation</a>
    /// </summary>
    let ruleIsSourceOfRuleRelation = _prefixId.prefix "ruleIsSourceOfRuleRelation"
    /// <summary>
    ///   <para>rdfs:label : rule relation has source </para>
    ///   <para>rdfs:comment : Connects a Rule Relation to a Rule.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ruleRelationHasSource">rico:ruleRelationHasSource</a>
    /// </summary>
    let ruleRelationHasSource = _prefixId.prefix "ruleRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : rule relation has target </para>
    ///   <para>rdfs:comment : Connects a Rule Relation to a Thing (that is associated to a
    ///             Rule).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#ruleRelationHasTarget">rico:ruleRelationHasTarget</a>
    /// </summary>
    let ruleRelationHasTarget = _prefixId.prefix "ruleRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:comment : Summary of the scope (such as time periods, geography) and
    ///             content (such as subject matter, administrative processes) of the Record Resource. It
    ///             should highlight the information conveyed in the Record Resource, why it was created,
    ///             received, and/or maintained, and the Agents connected to it. Scope and Content provides
    ///             a more complete summary of the informational content of the Record Resource. It may
    ///             include description of relations with agents, activities, dates and places, or with
    ///             other record resources. It is not to be confused with the History attribute which
    ///             focuses on the origination and subsequence changes to a Record Resource.</para>
    ///   <para>rdfs:label : scope and content</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A38 (Scope and Content
    ///             attribute)</para>
    ///   <para>skos:example : Se hace referencia a construcción del Gran Hotel, iniciada en
    ///             1899 bajo el nombre de Casa Celestino. Tras su interrupción en 1902, continuó la obra ya
    ///             con su nombre actual.skos:example : Includes a detailed list of the lands and villages given by the
    ///             King to the Abbey.skos:example : Among the witnesses, the duke of Normandy.skos:example : Letter from Vlad the Impaler (Dracula) to the Council of
    ///             Kronstadt asking them to send military support against the Ottomans, within the
    ///             framework of their alliance treaty.skos:example : The author explains why he does not agree with the decision made
    ///             and adds that it cannot be applied.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#scopeAndContent">rico:scopeAndContent</a>
    /// </summary>
    let scopeAndContent = _prefixId.prefix "scopeAndContent"
    /// <summary>
    ///   <para>rdfs:label : sequential relation has source </para>
    ///   <para>rdfs:comment : Connects a Sequential Relation to a Thing that precedes other
    ///             Thing(s) in the sequence.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#sequentialRelationHasSource">rico:sequentialRelationHasSource</a>
    /// </summary>
    let sequentialRelationHasSource = _prefixId.prefix "sequentialRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : sequential relation has target </para>
    ///   <para>rdfs:comment : Connects a Sequential Relation to a Thing that follows other
    ///             Thing(s) in the sequence.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#sequentialRelationHasTarget">rico:sequentialRelationHasTarget</a>
    /// </summary>
    let sequentialRelationHasTarget = _prefixId.prefix "sequentialRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : sibling relation connects </para>
    ///   <para>rdfs:comment : Connects a Sibling Relation to one of the siblings
    ///             involved.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#siblingRelationConnects">rico:siblingRelationConnects</a>
    /// </summary>
    let siblingRelationConnects = _prefixId.prefix "siblingRelationConnects"
    /// <summary>
    ///   <para>skos:scopeNote : Can be used, in particular, for Records having documentary
    ///             form type Finding Aid or Authority Record, or for Relations. Use only if you don't use
    ///             the hasSource object property.</para>
    ///   <para>rdfs:label : source</para>
    ///   <para>rdfs:comment : Information about a source used to identify or describe an
    ///             entity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#source">rico:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : spouse relation connects </para>
    ///   <para>rdfs:comment : Connects a Sibling Relation to one of the spouses
    ///             involved.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#spouseRelationConnects">rico:spouseRelationConnects</a>
    /// </summary>
    let spouseRelationConnects = _prefixId.prefix "spouseRelationConnects"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A40 (Structure
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Use only if you cannot use the subproperties (particularly if
    ///             the same free text is being used in your current metadata for describing the record
    ///             resource and the instantiation structure).</para>
    ///   <para>rdfs:label : structure</para>
    ///   <para>rdfs:comment : Information about the intellectual arrangement and composition
    ///             of a Record Resource or the physical arrangement and composition of an Instantiation.
    ///             For Record and Record Part, it encompasses information about the intellectual
    ///             composition of the record, the presence of record parts and their functions. For Record
    ///             Set, it encompasses information about the methodology or criteria used for arranging the
    ///             Record Set members or Record members within the containing Record Set. For
    ///             Instantiation, it may comprise information about the composition of the physical
    ///             elements of the instantiation</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#structure">rico:structure</a>
    /// </summary>
    let structure = _prefixId.prefix "structure"
    /// <summary>
    ///   <para>rdfs:label : teaching relation has source </para>
    ///   <para>rdfs:comment : Connects a Teaching Relation to a Person (who is a
    ///             teacher).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#teachingRelationHasSource">rico:teachingRelationHasSource</a>
    /// </summary>
    let teachingRelationHasSource = _prefixId.prefix "teachingRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : teaching relation has target </para>
    ///   <para>rdfs:comment : Connects a Teaching Relation to a Person (who is a
    ///             student).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#teachingRelationHasTarget">rico:teachingRelationHasTarget</a>
    /// </summary>
    let teachingRelationHasTarget = _prefixId.prefix "teachingRelationHasTarget"
    /// <summary>
    ///   <para>skos:scopeNote : Does not include references to the workflow that the Mechanism
    ///             is involved in which is described under the Activity entity. It emphasizes those
    ///             features that provide a better understanding of the impact of the Mechanism on the
    ///             records.</para>
    ///   <para>rdfs:label : technical characteristics</para>
    ///   <para>rdfs:comment : Describes any relevant physical or software feature of any
    ///             device involved in the creation or management of a Record Resource.</para>
    ///   <para>rico:RiCCMCorrespondingComponent : Corresponds to RiC-A41 (Technical Characteristics
    ///             attribute)</para>
    ///   <para>skos:example : Hubble Space Telescope had until 2002 a flawed mirror that
    ///             introduced severe spherical aberration for the images.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#technicalCharacteristics">rico:technicalCharacteristics</a>
    /// </summary>
    let technicalCharacteristics = _prefixId.prefix "technicalCharacteristics"
    /// <summary>
    ///   <para>rdfs:label : temporal relation has source </para>
    ///   <para>rdfs:comment : Connects a Temporal Relation to a Thing that precedes other
    ///             Thing(s) in time.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#temporalRelationHasSource">rico:temporalRelationHasSource</a>
    /// </summary>
    let temporalRelationHasSource = _prefixId.prefix "temporalRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : temporal relation has target </para>
    ///   <para>rdfs:comment : Connects a Temporal Relation to a Thing that follows other
    ///             Thing(s) in time.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#temporalRelationHasTarget">rico:temporalRelationHasTarget</a>
    /// </summary>
    let temporalRelationHasTarget = _prefixId.prefix "temporalRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : textual value</para>
    ///   <para>rdfs:comment : A textual expression of an Appellation or Date.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#textualValue">rico:textualValue</a>
    /// </summary>
    let textualValue = _prefixId.prefix "textualValue"
    /// <summary>
    ///   <para>rdfs:label : thing is connected to relation </para>
    ///   <para>rdfs:comment : Connects a Thing to a n-ary Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsConnectedToRelation">rico:thingIsConnectedToRelation</a>
    /// </summary>
    let thingIsConnectedToRelation = _prefixId.prefix "thingIsConnectedToRelation"
    /// <summary>
    ///   <para>rdfs:label : thing is context of relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that is a secondary, contextual entity during
    ///             the existence of the Relation) to a n-ary Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsContextOfRelation">rico:thingIsContextOfRelation</a>
    /// </summary>
    let thingIsContextOfRelation = _prefixId.prefix "thingIsContextOfRelation"
    /// <summary>
    ///   <para>rdfs:label : thing is source of relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that is the source of a Relation) to a
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfRelation">rico:thingIsSourceOfRelation</a>
    /// </summary>
    let thingIsSourceOfRelation = _prefixId.prefix "thingIsSourceOfRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is source of sequential relation </para>
    ///   <para>rdfs:comment : Connects a Thing to a Sequential Relation, when this Thing
    ///             precedes other Thing(s) in the sequence.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfSequentialRelation">rico:thingIsSourceOfSequentialRelation</a>
    /// </summary>
    let thingIsSourceOfSequentialRelation = _prefixId.prefix "thingIsSourceOfSequentialRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is source of temporal relation </para>
    ///   <para>rdfs:comment : Connects a Thing to a Temporal Relation, when this Thing
    ///             precedes other Thing(s) in time.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfTemporalRelation">rico:thingIsSourceOfTemporalRelation</a>
    /// </summary>
    let thingIsSourceOfTemporalRelation = _prefixId.prefix "thingIsSourceOfTemporalRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is source of whole part relation </para>
    ///   <para>rdfs:comment : Connects a Thing to a Whole Part Relation, when this Thing has
    ///             Part other Thing(s).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfWholePartRelation">rico:thingIsSourceOfWholePartRelation</a>
    /// </summary>
    let thingIsSourceOfWholePartRelation = _prefixId.prefix "thingIsSourceOfWholePartRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is target of appellation relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that is designated by an Appellation) to an
    ///             Appellation Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfAppellationRelation">rico:thingIsTargetOfAppellationRelation</a>
    /// </summary>
    let thingIsTargetOfAppellationRelation = _prefixId.prefix "thingIsTargetOfAppellationRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is target of authority relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that is under authority of an Agent) to an
    ///             Authority Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfAuthorityRelation">rico:thingIsTargetOfAuthorityRelation</a>
    /// </summary>
    let thingIsTargetOfAuthorityRelation = _prefixId.prefix "thingIsTargetOfAuthorityRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is target of event relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that is associated with an Event) to an Event
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfEventRelation">rico:thingIsTargetOfEventRelation</a>
    /// </summary>
    let thingIsTargetOfEventRelation = _prefixId.prefix "thingIsTargetOfEventRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is target of ownership relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that is owned by a Group, a Person or a
    ///             Position) to an Ownership Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfOwnershipRelation">rico:thingIsTargetOfOwnershipRelation</a>
    /// </summary>
    let thingIsTargetOfOwnershipRelation = _prefixId.prefix "thingIsTargetOfOwnershipRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is target of place relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that is associated with a Place) to a Place
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfPlaceRelation">rico:thingIsTargetOfPlaceRelation</a>
    /// </summary>
    let thingIsTargetOfPlaceRelation = _prefixId.prefix "thingIsTargetOfPlaceRelation"
    /// <summary>
    ///   <para>rdfs:label : thing is target of relation </para>
    ///   <para>rdfs:comment : Connects a Thing to a n-ary Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfRelation">rico:thingIsTargetOfRelation</a>
    /// </summary>
    let thingIsTargetOfRelation = _prefixId.prefix "thingIsTargetOfRelation"
    /// <summary>
    ///   <para>rdfs:label : thing is target of rule relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that is associated with a Rule) to a Rule
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfRuleRelation">rico:thingIsTargetOfRuleRelation</a>
    /// </summary>
    let thingIsTargetOfRuleRelation = _prefixId.prefix "thingIsTargetOfRuleRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is target of sequential relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that follows other Thing(s) in a sequence) to
    ///             a Sequential Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfSequentialRelation">rico:thingIsTargetOfSequentialRelation</a>
    /// </summary>
    let thingIsTargetOfSequentialRelation = _prefixId.prefix "thingIsTargetOfSequentialRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is target of temporal relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that follows other Thing(s) in time) to a
    ///             Temporal Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfTemporalRelation">rico:thingIsTargetOfTemporalRelation</a>
    /// </summary>
    let thingIsTargetOfTemporalRelation = _prefixId.prefix "thingIsTargetOfTemporalRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is target of type relation </para>
    ///   <para>rdfs:comment : Connects a Thing (that is categorized by a Type) to a Type
    ///             Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfTypeRelation">rico:thingIsTargetOfTypeRelation</a>
    /// </summary>
    let thingIsTargetOfTypeRelation = _prefixId.prefix "thingIsTargetOfTypeRelation"

    /// <summary>
    ///   <para>rdfs:label : thing is target of whole part relation </para>
    ///   <para>rdfs:comment : Connects a Thing to a Whole Part Relation, when this Thing is
    ///             Part of another Thing.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfWholePartRelation">rico:thingIsTargetOfWholePartRelation</a>
    /// </summary>
    let thingIsTargetOfWholePartRelation = _prefixId.prefix "thingIsTargetOfWholePartRelation"

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Specialization of RiC-A28 (Name
    ///             attribute)</para>
    ///   <para>skos:scopeNote : Use only if you don't use Title class for handling
    ///             titles.</para>
    ///   <para>rdfs:label : title</para>
    ///   <para>rdfs:comment : An identifying name of a Record Resource, Instantiation or
    ///             Rule.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#title">rico:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Type subclasses for handling
    ///             categories.</para>
    ///   <para>rdfs:label : type</para>
    ///   <para>rdfs:comment : A term used to characterize an entity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#type">rico:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:label : type is source of type relation </para>
    ///   <para>rdfs:comment : Connects a Type (a category) to a Type Relation.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#typeIsSourceOfTypeRelation">rico:typeIsSourceOfTypeRelation</a>
    /// </summary>
    let typeIsSourceOfTypeRelation = _prefixId.prefix "typeIsSourceOfTypeRelation"
    /// <summary>
    ///   <para>rdfs:label : type relation has source </para>
    ///   <para>rdfs:comment : Connects a Type Relation to the Type (that categorizes the
    ///             involved Thing(s)).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#typeRelationHasSource">rico:typeRelationHasSource</a>
    /// </summary>
    let typeRelationHasSource = _prefixId.prefix "typeRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : type relation has target </para>
    ///   <para>rdfs:comment : Connects a Type Relation to a Thing (that is categorized by the
    ///             involved Type).</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#typeRelationHasTarget">rico:typeRelationHasTarget</a>
    /// </summary>
    let typeRelationHasTarget = _prefixId.prefix "typeRelationHasTarget"
    /// <summary>
    ///   <para>skos:scopeNote : Use if you do not use the UnitOfMeasurement class for handling
    ///             units of measurement along with Extent.</para>
    ///   <para>rdfs:label : unit of measurement</para>
    ///   <para>rdfs:comment : A definite magnitude of a quantity, defined and adopted by convention or by
    ///             law, that is used as a standard for measurement of the same kind of quantity. Can be
    ///             spacial units (cm, m), weight (g, kg), time (s, h), storage (MB, TB) or more informal
    ///             units used in the archival context like number of boxes, pages or words.^^xsd:string</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#unitOfMeasurement">rico:unitOfMeasurement</a>
    /// </summary>
    let unitOfMeasurement = _prefixId.prefix "unitOfMeasurement"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : used from date</para>
    ///   <para>rdfs:comment : Date at which an Appellation was first used.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#usedFromDate">rico:usedFromDate</a>
    /// </summary>
    let usedFromDate = _prefixId.prefix "usedFromDate"
    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent : Data property specialized implementation of
    ///             RiC-E18 (Date entity)</para>
    ///   <para>skos:scopeNote : Provided for usability reasons. May be deprecated and removed
    ///             later on. Use only if you don't use Date classes for handling dates.</para>
    ///   <para>rdfs:label : used to date</para>
    ///   <para>rdfs:comment : Date until an Appellation was used.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#usedToDate">rico:usedToDate</a>
    /// </summary>
    let usedToDate = _prefixId.prefix "usedToDate"
    /// <summary>
    ///   <para>rdfs:label : was last updated at date </para>
    ///   <para>rdfs:comment : Connects a Thing to the Date when it was last
    ///             modified.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#wasLastUpdatedAtDate">rico:wasLastUpdatedAtDate</a>
    /// </summary>
    let wasLastUpdatedAtDate = _prefixId.prefix "wasLastUpdatedAtDate"
    /// <summary>
    ///   <para>rdfs:label : was used from date </para>
    ///   <para>rdfs:comment : Connects an Appellation to the Date from which it was
    ///             used.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#wasUsedFromDate">rico:wasUsedFromDate</a>
    /// </summary>
    let wasUsedFromDate = _prefixId.prefix "wasUsedFromDate"
    /// <summary>
    ///   <para>rdfs:label : was used to date </para>
    ///   <para>rdfs:comment : Connects an Appellation to the Date till when it was
    ///             used.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#wasUsedToDate">rico:wasUsedToDate</a>
    /// </summary>
    let wasUsedToDate = _prefixId.prefix "wasUsedToDate"
    /// <summary>
    ///   <para>rdfs:label : whole part relation has source </para>
    ///   <para>rdfs:comment : Connects a Whole Part Relation to the Thing that has some
    ///             parts.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#wholePartRelationHasSource">rico:wholePartRelationHasSource</a>
    /// </summary>
    let wholePartRelationHasSource = _prefixId.prefix "wholePartRelationHasSource"
    /// <summary>
    ///   <para>rdfs:label : whole part relation has target </para>
    ///   <para>rdfs:comment : Connects a Whole Part Relation to a Thing that is a
    ///             part.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#wholePartRelationHasTarget">rico:wholePartRelationHasTarget</a>
    /// </summary>
    let wholePartRelationHasTarget = _prefixId.prefix "wholePartRelationHasTarget"
    /// <summary>
    ///   <para>rdfs:label : width</para>
    ///   <para>rdfs:comment : Horizontal dimension of an entity.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#width">rico:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
    /// <summary>
    ///   <para>rdfs:label : work relation connects </para>
    ///   <para>rdfs:comment : Connects a Work Relation to an Agent.</para>
    ///   <a href="https://www.ica.org/standards/RiC/ontology#workRelationConnects">rico:workRelationConnects</a>
    /// </summary>
    let workRelationConnects = _prefixId.prefix "workRelationConnects"
