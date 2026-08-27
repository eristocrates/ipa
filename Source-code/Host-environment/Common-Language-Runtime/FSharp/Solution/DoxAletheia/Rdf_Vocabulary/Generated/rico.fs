namespace https.www.ica.org.standards.RiC.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rico =
    let _namespace_iri = Namespace_Iri rico |> NamespaceIRI

    /// <summary>
    ///   <para>rico:AccumulationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Record Resource or Instantiation to at
    ///             least one Agent, when the Agent accumulates it, be it intentionally (collecting it) or
    ///             not (receiving it in the course of its activities)."</para>
    /// labels<para>"Accumulation Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#AccumulationRelation">https://www.ica.org/standards/RiC/ontology#AccumulationRelation</seealso>
    let AccumulationRelation =
        Prefixed_Name(rico, "AccumulationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The doing of something for some human purpose."</para>
    /// labels<para>"Activity"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Activity">https://www.ica.org/standards/RiC/ontology#Activity</seealso>
    let Activity = Prefixed_Name(rico, "Activity") |> PrefixedName

    /// <summary>
    ///   <para>rico:ActivityDocumentationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Record Resource or Instantiation to at
    ///             least one Activity, when the Record Resource or Instantiation results from the
    ///             activity."</para>
    /// labels<para>"Activity Documentation Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ActivityDocumentationRelation">https://www.ica.org/standards/RiC/ontology#ActivityDocumentationRelation</seealso>
    let ActivityDocumentationRelation =
        Prefixed_Name(rico, "ActivityDocumentationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:ActivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of an Activity."</para>
    /// labels<para>"Activity Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ActivityType">https://www.ica.org/standards/RiC/ontology#ActivityType</seealso>
    let ActivityType = Prefixed_Name(rico, "ActivityType") |> PrefixedName
    /// <summary>
    ///   <para>rico:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Person, or Group, or an entity created by a Person or Group
    ///             (Mechanism), or a Position, that acts in the world."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Agent">https://www.ica.org/standards/RiC/ontology#Agent</seealso>
    let Agent = Prefixed_Name(rico, "Agent") |> PrefixedName

    /// <summary>
    ///   <para>rico:AgentControlRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Agent, to at least another Agent, when the
    ///             first one(s) control(s) in a way the activities of the second one(s)."</para>
    /// labels<para>"Agent Control Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#AgentControlRelation">https://www.ica.org/standards/RiC/ontology#AgentControlRelation</seealso>
    let AgentControlRelation =
        Prefixed_Name(rico, "AgentControlRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:AgentHierarchicalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Agent to at least another Agent, when the
    ///             first one is hierarchically superior to the second one."</para>
    /// labels<para>"Agent Hierarchical Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#AgentHierarchicalRelation">https://www.ica.org/standards/RiC/ontology#AgentHierarchicalRelation</seealso>
    let AgentHierarchicalRelation =
        Prefixed_Name(rico, "AgentHierarchicalRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:AgentName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A label, title or term designating an Agent in order to make it
    ///             distinguishable from other similar entities."</para>
    /// labels<para>"Agent Name"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#AgentName">https://www.ica.org/standards/RiC/ontology#AgentName</seealso>
    let AgentName = Prefixed_Name(rico, "AgentName") |> PrefixedName

    /// <summary>
    ///   <para>rico:AgentOriginationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Record Resource or an Instantiation to at
    ///             least one Agent that creates or accumulates the Record Resource, receives it, or sends
    ///             it."</para>
    /// labels<para>"Agent Origination Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#AgentOriginationRelation">https://www.ica.org/standards/RiC/ontology#AgentOriginationRelation</seealso>
    let AgentOriginationRelation =
        Prefixed_Name(rico, "AgentOriginationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:AgentTemporalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Agent, to at least another Agent, that
    ///             succeeds it chronologically for, for instance, fullfilling some functions or performing
    ///             some activities."</para>
    /// labels<para>"Agent Temporal Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#AgentTemporalRelation">https://www.ica.org/standards/RiC/ontology#AgentTemporalRelation</seealso>
    let AgentTemporalRelation =
        Prefixed_Name(rico, "AgentTemporalRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:AgentToAgentRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least two Agents."</para>
    /// labels<para>"Agent Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#AgentToAgentRelation">https://www.ica.org/standards/RiC/ontology#AgentToAgentRelation</seealso>
    let AgentToAgentRelation =
        Prefixed_Name(rico, "AgentToAgentRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:Appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concept of any kind that is used for designating an Entity and
    ///             referring to it."</para>
    /// labels<para>"Appellation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Appellation">https://www.ica.org/standards/RiC/ontology#Appellation</seealso>
    let Appellation = Prefixed_Name(rico, "Appellation") |> PrefixedName
    /// <summary>
    ///   <para>rico:AppellationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The relation between an Appellation and at least one Thing that
    ///             the Appellation designates."</para>
    /// labels<para>"Appellation Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#AppellationRelation">https://www.ica.org/standards/RiC/ontology#AppellationRelation</seealso>
    let AppellationRelation = Prefixed_Name(rico, "AppellationRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:AuthorityRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Agent, and at least one Thing over which
    ///             the Agent has some authority."</para>
    /// labels<para>"Authority Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#AuthorityRelation">https://www.ica.org/standards/RiC/ontology#AuthorityRelation</seealso>
    let AuthorityRelation = Prefixed_Name(rico, "AuthorityRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:AuthorshipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Record to at least one Person, Group or
    ///             Position that is responsible for conceiving and formulating the information contained in
    ///             the Record."</para>
    /// labels<para>"Authorship Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#AuthorshipRelation">https://www.ica.org/standards/RiC/ontology#AuthorshipRelation</seealso>
    let AuthorshipRelation = Prefixed_Name(rico, "AuthorshipRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:CarrierExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The extent of a Record Resource carrier"</para>
    /// labels<para>"Carrier Extent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#CarrierExtent">https://www.ica.org/standards/RiC/ontology#CarrierExtent</seealso>
    let CarrierExtent = Prefixed_Name(rico, "CarrierExtent") |> PrefixedName
    /// <summary>
    ///   <para>rico:CarrierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of physical material in or on which information
    ///             is represented."</para>
    /// labels<para>"Carrier Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#CarrierType">https://www.ica.org/standards/RiC/ontology#CarrierType</seealso>
    let CarrierType = Prefixed_Name(rico, "CarrierType") |> PrefixedName
    /// <summary>
    ///   <para>rico:ChildRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at lest one Person, to at least another Person, when
    ///             the first has child the second one."</para>
    /// labels<para>"Child Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ChildRelation">https://www.ica.org/standards/RiC/ontology#ChildRelation</seealso>
    let ChildRelation = Prefixed_Name(rico, "ChildRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An idea, unit of thought, abstract cultural object or
    ///             category"</para>
    /// labels<para>"Concept"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Concept">https://www.ica.org/standards/RiC/ontology#Concept</seealso>
    let Concept = Prefixed_Name(rico, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>rico:ContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The fundamental form of communication in which a Record is
    ///             expressed and the human sense through which it is intended to be
    ///             perceived."</para>
    /// labels<para>"Content Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ContentType">https://www.ica.org/standards/RiC/ontology#ContentType</seealso>
    let ContentType = Prefixed_Name(rico, "ContentType") |> PrefixedName
    /// <summary>
    ///   <para>rico:Coordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Longitudinal and latitudinal information of a
    ///             Place."</para>
    /// labels<para>"Coordinates"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Coordinates">https://www.ica.org/standards/RiC/ontology#Coordinates</seealso>
    let Coordinates = Prefixed_Name(rico, "Coordinates") |> PrefixedName
    /// <summary>
    ///   <para>rico:CorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organized group of persons that act together as an Agent, and
    ///             that has a recognized legal or social status."</para>
    /// labels<para>"Corporate Body"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#CorporateBody">https://www.ica.org/standards/RiC/ontology#CorporateBody</seealso>
    let CorporateBody = Prefixed_Name(rico, "CorporateBody") |> PrefixedName
    /// <summary>
    ///   <para>rico:CorporateBodyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of a Corporate Body."</para>
    /// labels<para>"Corporate Body Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#CorporateBodyType">https://www.ica.org/standards/RiC/ontology#CorporateBodyType</seealso>
    let CorporateBodyType = Prefixed_Name(rico, "CorporateBodyType") |> PrefixedName

    /// <summary>
    ///   <para>rico:CorrespondenceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least two Persons, when they correspond to each
    ///             other."</para>
    /// labels<para>"Correspondence Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#CorrespondenceRelation">https://www.ica.org/standards/RiC/ontology#CorrespondenceRelation</seealso>
    let CorrespondenceRelation =
        Prefixed_Name(rico, "CorrespondenceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:CreationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Record Resource or Instantiation to at
    ///             least one Agent, when the Agent is either responsible for all or some of the content of
    ///             the Record Resource, or is a contributor to the genesis or production of the
    ///             Instantiation."</para>
    /// labels<para>"Creation Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#CreationRelation">https://www.ica.org/standards/RiC/ontology#CreationRelation</seealso>
    let CreationRelation = Prefixed_Name(rico, "CreationRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Chronological information associated with an entity that
    ///             contributes to its identification and contextualization."</para>
    /// labels<para>"Date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Date">https://www.ica.org/standards/RiC/ontology#Date</seealso>
    let Date = Prefixed_Name(rico, "Date") |> PrefixedName
    /// <summary>
    ///   <para>rico:DateRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Chronological information associated with an entity that
    ///             contributes to its identification and contextualization, that implies or explicitly
    ///             states a start date and end date."</para>
    /// labels<para>"Date Range"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#DateRange">https://www.ica.org/standards/RiC/ontology#DateRange</seealso>
    let DateRange = Prefixed_Name(rico, "DateRange") |> PrefixedName
    /// <summary>
    ///   <para>rico:DateSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Non-contiguous single dates or date ranges."</para>
    /// labels<para>"Date Set"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#DateSet">https://www.ica.org/standards/RiC/ontology#DateSet</seealso>
    let DateSet = Prefixed_Name(rico, "DateSet") |> PrefixedName
    /// <summary>
    ///   <para>rico:DemographicGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of a person according to characteristics such as
    ///             age, gender, education, place of origin, ethnic/cultural identification, religion,
    ///             etc."</para>
    /// labels<para>"Demographic Group"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#DemographicGroup">https://www.ica.org/standards/RiC/ontology#DemographicGroup</seealso>
    let DemographicGroup = Prefixed_Name(rico, "DemographicGroup") |> PrefixedName
    /// <summary>
    ///   <para>rico:DerivationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an Instantiation to at least one Instantiation that is
    ///             derived from it."</para>
    /// labels<para>"Derivation Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#DerivationRelation">https://www.ica.org/standards/RiC/ontology#DerivationRelation</seealso>
    let DerivationRelation = Prefixed_Name(rico, "DerivationRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:DescendanceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Person to at least another Person, when
    ///             the first has/have descendant the second one(s)."</para>
    /// labels<para>"Descendance Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#DescendanceRelation">https://www.ica.org/standards/RiC/ontology#DescendanceRelation</seealso>
    let DescendanceRelation = Prefixed_Name(rico, "DescendanceRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:DocumentaryFormType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of the document with respect to its extrinsic and
    ///             intrinsic elements that together communicate its content, administrative and documentary
    ///             context, and authority"</para>
    /// labels<para>"Documentary Form Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#DocumentaryFormType">https://www.ica.org/standards/RiC/ontology#DocumentaryFormType</seealso>
    let DocumentaryFormType = Prefixed_Name(rico, "DocumentaryFormType") |> PrefixedName
    /// <summary>
    ///   <para>rico:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Something that happens in time and space."</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Event">https://www.ica.org/standards/RiC/ontology#Event</seealso>
    let Event = Prefixed_Name(rico, "Event") |> PrefixedName
    /// <summary>
    ///   <para>rico:EventRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Event to at least one Thing, when the
    ///             first is associated with the existence and lifecycle of the second one."</para>
    /// labels<para>"Event Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#EventRelation">https://www.ica.org/standards/RiC/ontology#EventRelation</seealso>
    let EventRelation = Prefixed_Name(rico, "EventRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:EventType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of an Event."</para>
    /// labels<para>"Event Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#EventType">https://www.ica.org/standards/RiC/ontology#EventType</seealso>
    let EventType = Prefixed_Name(rico, "EventType") |> PrefixedName
    /// <summary>
    ///   <para>rico:Extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Countable characteristics of the content of an entity expressed
    ///             as a quantity."</para>
    /// labels<para>"Extent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Extent">https://www.ica.org/standards/RiC/ontology#Extent</seealso>
    let Extent = Prefixed_Name(rico, "Extent") |> PrefixedName
    /// <summary>
    ///   <para>rico:ExtentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of the extent that is being measured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Extent Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ExtentType">https://www.ica.org/standards/RiC/ontology#ExtentType</seealso>
    let ExtentType = Prefixed_Name(rico, "ExtentType") |> PrefixedName
    /// <summary>
    ///   <para>rico:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Two or more persons related by birth, or through marriage,
    ///             adoption, civil union, or other social conventions that bind them together as a socially
    ///             recognized familial group."</para>
    /// labels<para>"Family"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Family">https://www.ica.org/standards/RiC/ontology#Family</seealso>
    let Family = Prefixed_Name(rico, "Family") |> PrefixedName
    /// <summary>
    ///   <para>rico:FamilyRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least two Persons, when they have some family link,
    ///             i.e. belong to the same family."</para>
    /// labels<para>"Family Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#FamilyRelation">https://www.ica.org/standards/RiC/ontology#FamilyRelation</seealso>
    let FamilyRelation = Prefixed_Name(rico, "FamilyRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:FamilyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of a Family."</para>
    /// labels<para>"Family Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#FamilyType">https://www.ica.org/standards/RiC/ontology#FamilyType</seealso>
    let FamilyType = Prefixed_Name(rico, "FamilyType") |> PrefixedName

    /// <summary>
    ///   <para>rico:FunctionalEquivalenceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least two Instantiations which may be considered as
    ///             equivalent."</para>
    /// labels<para>"Functional Equivalence Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#FunctionalEquivalenceRelation">https://www.ica.org/standards/RiC/ontology#FunctionalEquivalenceRelation</seealso>
    let FunctionalEquivalenceRelation =
        Prefixed_Name(rico, "FunctionalEquivalenceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Two or more Agents that act together as an Agent."</para>
    /// labels<para>"Group"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Group">https://www.ica.org/standards/RiC/ontology#Group</seealso>
    let Group = Prefixed_Name(rico, "Group") |> PrefixedName

    /// <summary>
    ///   <para>rico:GroupSubdivisionRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Group and at least another Group, when the first one
    ///             as the second one(s) among its subdivisions."</para>
    /// labels<para>"Group Subdivision Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#GroupSubdivisionRelation">https://www.ica.org/standards/RiC/ontology#GroupSubdivisionRelation</seealso>
    let GroupSubdivisionRelation =
        Prefixed_Name(rico, "GroupSubdivisionRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A word, number, letter, symbol, or any combination of these used
    ///             to uniquely identify or reference an individual instance of an entity within a specific
    ///             information domain."</para>
    /// labels<para>"Identifier"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Identifier">https://www.ica.org/standards/RiC/ontology#Identifier</seealso>
    let Identifier = Prefixed_Name(rico, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>rico:IdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of an Identifier."</para>
    /// labels<para>"Identifier Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#IdentifierType">https://www.ica.org/standards/RiC/ontology#IdentifierType</seealso>
    let IdentifierType = Prefixed_Name(rico, "IdentifierType") |> PrefixedName
    /// <summary>
    ///   <para>rico:Instantiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The inscription of information made by an Agent on a physical
    ///             carrier in any persistent, recoverable form as a means of communicating information
    ///             through time and space."</para>
    /// labels<para>"Instantiation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Instantiation">https://www.ica.org/standards/RiC/ontology#Instantiation</seealso>
    let Instantiation = Prefixed_Name(rico, "Instantiation") |> PrefixedName
    /// <summary>
    ///   <para>rico:InstantiationExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The extent of an Instantiation."</para>
    /// labels<para>"Instantiation Extent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#InstantiationExtent">https://www.ica.org/standards/RiC/ontology#InstantiationExtent</seealso>
    let InstantiationExtent = Prefixed_Name(rico, "InstantiationExtent") |> PrefixedName

    /// <summary>
    ///   <para>rico:InstantiationToInstantiationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least two instantiations"</para>
    /// labels<para>"Instantiation to Instantiation Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#InstantiationToInstantiationRelation">https://www.ica.org/standards/RiC/ontology#InstantiationToInstantiationRelation</seealso>
    let InstantiationToInstantiationRelation =
        Prefixed_Name(rico, "InstantiationToInstantiationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:IntellectualPropertyRightsRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Agent and one Record Resource or
    ///             Instantiation on which the Agent has some intellectual property rights."</para>
    /// labels<para>"Intellectual Property Rights Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#IntellectualPropertyRightsRelation">https://www.ica.org/standards/RiC/ontology#IntellectualPropertyRightsRelation</seealso>
    let IntellectualPropertyRightsRelation =
        Prefixed_Name(rico, "IntellectualPropertyRightsRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:KnowingOfRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Person to at least another one, when the
    ///             first one has some knowledge of the second one through time or space."</para>
    /// labels<para>"Knowing Of Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#KnowingOfRelation">https://www.ica.org/standards/RiC/ontology#KnowingOfRelation</seealso>
    let KnowingOfRelation = Prefixed_Name(rico, "KnowingOfRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:KnowingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least two Persons that directly know each other
    ///             during their existence. This relation is symmetric."</para>
    /// labels<para>"Knowing Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#KnowingRelation">https://www.ica.org/standards/RiC/ontology#KnowingRelation</seealso>
    let KnowingRelation = Prefixed_Name(rico, "KnowingRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A spoken or written human language represented in the Record or
    ///             Record Part, or used by the Agent."</para>
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Language">https://www.ica.org/standards/RiC/ontology#Language</seealso>
    let Language = Prefixed_Name(rico, "Language") |> PrefixedName
    /// <summary>
    ///   <para>rico:LeadershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Person and at least one Group, when the
    ///             first one leads the second one."</para>
    /// labels<para>"Leadership Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#LeadershipRelation">https://www.ica.org/standards/RiC/ontology#LeadershipRelation</seealso>
    let LeadershipRelation = Prefixed_Name(rico, "LeadershipRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:LegalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A status defined by law."</para>
    /// labels<para>"Legal Status"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#LegalStatus">https://www.ica.org/standards/RiC/ontology#LegalStatus</seealso>
    let LegalStatus = Prefixed_Name(rico, "LegalStatus") |> PrefixedName
    /// <summary>
    ///   <para>rico:ManagementRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Agent, and at least one Record Resource or
    ///             Instantiation that the Agent manages."</para>
    /// labels<para>"Management Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ManagementRelation">https://www.ica.org/standards/RiC/ontology#ManagementRelation</seealso>
    let ManagementRelation = Prefixed_Name(rico, "ManagementRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:Mandate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Delegation of authority by an Agent to another Agent to perform
    ///             an Activity."</para>
    /// labels<para>"Mandate"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Mandate">https://www.ica.org/standards/RiC/ontology#Mandate</seealso>
    let Mandate = Prefixed_Name(rico, "Mandate") |> PrefixedName
    /// <summary>
    ///   <para>rico:MandateRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Mandate, and at least one Agent, when the
    ///             first gives the second one the authority or competencies to act. May also involve one to
    ///             many Activities that the Mandate(s) assign(s) to the Agent(s)."</para>
    /// labels<para>"Mandate Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#MandateRelation">https://www.ica.org/standards/RiC/ontology#MandateRelation</seealso>
    let MandateRelation = Prefixed_Name(rico, "MandateRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:Mechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A process or system created by a Person or Group that performs
    ///             an Activity."</para>
    /// labels<para>"Mechanism"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Mechanism">https://www.ica.org/standards/RiC/ontology#Mechanism</seealso>
    let Mechanism = Prefixed_Name(rico, "Mechanism") |> PrefixedName
    /// <summary>
    ///   <para>rico:MembershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Group and at least one Person, when the first one has
    ///             the second one(s) among its members."</para>
    /// labels<para>"Membership Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#MembershipRelation">https://www.ica.org/standards/RiC/ontology#MembershipRelation</seealso>
    let MembershipRelation = Prefixed_Name(rico, "MembershipRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:MigrationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an Instantiation and at least another Instantiation,
    ///             when the first is migrated into the second one(s)."</para>
    /// labels<para>"Migration Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#MigrationRelation">https://www.ica.org/standards/RiC/ontology#MigrationRelation</seealso>
    let MigrationRelation = Prefixed_Name(rico, "MigrationRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A label, title or term designating the entity in order to make
    ///             it distinguishable from other similar entities."</para>
    /// labels<para>"Name"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Name">https://www.ica.org/standards/RiC/ontology#Name</seealso>
    let Name = Prefixed_Name(rico, "Name") |> PrefixedName
    /// <summary>
    ///   <para>rico:OccupationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of a profession, trade, or craft pursued by a
    ///             person in fulfilment of an Activity."</para>
    /// labels<para>"Occupation Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#OccupationType">https://www.ica.org/standards/RiC/ontology#OccupationType</seealso>
    let OccupationType = Prefixed_Name(rico, "OccupationType") |> PrefixedName
    /// <summary>
    ///   <para>rico:OwnershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Group, Person or Position, and at least a
    ///             Thing that these Agent(s) own(s)."</para>
    /// labels<para>"Ownership Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#OwnershipRelation">https://www.ica.org/standards/RiC/ontology#OwnershipRelation</seealso>
    let OwnershipRelation = Prefixed_Name(rico, "OwnershipRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:PerformanceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Activity to at least one Agent, when the
    ///             first is performed by the second one(s)."</para>
    /// labels<para>"Performance Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#PerformanceRelation">https://www.ica.org/standards/RiC/ontology#PerformanceRelation</seealso>
    let PerformanceRelation = Prefixed_Name(rico, "PerformanceRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A human being with a social identity or persona."</para>
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Person">https://www.ica.org/standards/RiC/ontology#Person</seealso>
    let Person = Prefixed_Name(rico, "Person") |> PrefixedName
    /// <summary>
    ///   <para>rico:PhysicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A delimitation of the physical territory of a
    ///             Place."</para>
    /// labels<para>"Physical Location"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#PhysicalLocation">https://www.ica.org/standards/RiC/ontology#PhysicalLocation</seealso>
    let PhysicalLocation = Prefixed_Name(rico, "PhysicalLocation") |> PrefixedName
    /// <summary>
    ///   <para>rico:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Bounded, named geographic area or region."</para>
    /// labels<para>"Place"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Place">https://www.ica.org/standards/RiC/ontology#Place</seealso>
    let Place = Prefixed_Name(rico, "Place") |> PrefixedName
    /// <summary>
    ///   <para>rico:PlaceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A label, title or term designating a Place in order to make it
    ///             distinguishable from other similar entities."</para>
    /// labels<para>"Place Name"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#PlaceName">https://www.ica.org/standards/RiC/ontology#PlaceName</seealso>
    let PlaceName = Prefixed_Name(rico, "PlaceName") |> PrefixedName
    /// <summary>
    ///   <para>rico:PlaceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Place and at least one Thing, when the first is
    ///             associated with the existence and lifecycle of the second one."</para>
    /// labels<para>"Place Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#PlaceRelation">https://www.ica.org/standards/RiC/ontology#PlaceRelation</seealso>
    let PlaceRelation = Prefixed_Name(rico, "PlaceRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:PlaceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of a Place."</para>
    /// labels<para>"Place Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#PlaceType">https://www.ica.org/standards/RiC/ontology#PlaceType</seealso>
    let PlaceType = Prefixed_Name(rico, "PlaceType") |> PrefixedName
    /// <summary>
    ///   <para>rico:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The functional role of a Person within a Group."</para>
    /// labels<para>"Position"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Position">https://www.ica.org/standards/RiC/ontology#Position</seealso>
    let Position = Prefixed_Name(rico, "Position") |> PrefixedName

    /// <summary>
    ///   <para>rico:PositionHoldingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Person, and at least one Position that the
    ///             Person occupies."</para>
    /// labels<para>"Position Holding Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#PositionHoldingRelation">https://www.ica.org/standards/RiC/ontology#PositionHoldingRelation</seealso>
    let PositionHoldingRelation =
        Prefixed_Name(rico, "PositionHoldingRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:PositionToGroupRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Position, and a Group, when the first
    ///             one(s) exist(s) in/is defined within the second one."</para>
    /// labels<para>"Position to Group Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#PositionToGroupRelation">https://www.ica.org/standards/RiC/ontology#PositionToGroupRelation</seealso>
    let PositionToGroupRelation =
        Prefixed_Name(rico, "PositionToGroupRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:ProductionTechniqueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of the method used in the representation of
    ///             information on the Instantiation."</para>
    /// labels<para>"Production Technique Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ProductionTechniqueType">https://www.ica.org/standards/RiC/ontology#ProductionTechniqueType</seealso>
    let ProductionTechniqueType =
        Prefixed_Name(rico, "ProductionTechniqueType") |> PrefixedName

    /// <summary>
    ///   <para>rico:ProvenanceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the provenance or origin of at least one Record
    ///             Resource or Instantiation, for example the relation between a Record Resource and the
    ///             Agent which created it or the Activity from which it resulted."</para>
    /// labels<para>"Provenance Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ProvenanceRelation">https://www.ica.org/standards/RiC/ontology#ProvenanceRelation</seealso>
    let ProvenanceRelation = Prefixed_Name(rico, "ProvenanceRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:Proxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Proxy represents (stands for) a Record Resource as it exists
    ///             in a specific Record Set."</para>
    /// labels<para>"Proxy"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Proxy">https://www.ica.org/standards/RiC/ontology#Proxy</seealso>
    let Proxy = Prefixed_Name(rico, "Proxy") |> PrefixedName
    /// <summary>
    ///   <para>rico:Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information inscribed at least once by any method on any
    ///             physical carrier in any persistent, recoverable form by an Agent in the course of life
    ///             or work Activity."</para>
    /// labels<para>"Record"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Record">https://www.ica.org/standards/RiC/ontology#Record</seealso>
    let Record = Prefixed_Name(rico, "Record") |> PrefixedName
    /// <summary>
    ///   <para>rico:RecordPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Part of a Record with discrete information content that
    ///             contributes to the Record's physical or intellectual completeness."</para>
    /// labels<para>"Record Part"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RecordPart">https://www.ica.org/standards/RiC/ontology#RecordPart</seealso>
    let RecordPart = Prefixed_Name(rico, "RecordPart") |> PrefixedName
    /// <summary>
    ///   <para>rico:RecordResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Record, Record Set, or Record Part produced or acquired and
    ///             retained by an Agent in the course of Activity."</para>
    /// labels<para>"Record Resource"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RecordResource">https://www.ica.org/standards/RiC/ontology#RecordResource</seealso>
    let RecordResource = Prefixed_Name(rico, "RecordResource") |> PrefixedName

    /// <summary>
    ///   <para>rico:RecordResourceExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The extent of the content of a Record Resource."</para>
    /// labels<para>"Record Resource Extent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RecordResourceExtent">https://www.ica.org/standards/RiC/ontology#RecordResourceExtent</seealso>
    let RecordResourceExtent =
        Prefixed_Name(rico, "RecordResourceExtent") |> PrefixedName

    /// <summary>
    ///   <para>rico:RecordResourceGeneticRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects two to more Record Resources when there is a genetic
    ///             relation between them. Genetic in this sense is as defined by diplomatics, i.e. the
    ///             process by which a Record Resource is developed."</para>
    /// labels<para>"Record Resource Genetic Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RecordResourceGeneticRelation">https://www.ica.org/standards/RiC/ontology#RecordResourceGeneticRelation</seealso>
    let RecordResourceGeneticRelation =
        Prefixed_Name(rico, "RecordResourceGeneticRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:RecordResourceHoldingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Agent, and one or more Record Resource or
    ///             Instantiation that the Agent holds."</para>
    /// labels<para>"Record Resource Holding Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RecordResourceHoldingRelation">https://www.ica.org/standards/RiC/ontology#RecordResourceHoldingRelation</seealso>
    let RecordResourceHoldingRelation =
        Prefixed_Name(rico, "RecordResourceHoldingRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:RecordResourceToInstantiationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource to one or more Instantiations that
    ///             instantiate it."</para>
    /// labels<para>"Record Resource to Instantiation Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RecordResourceToInstantiationRelation">https://www.ica.org/standards/RiC/ontology#RecordResourceToInstantiationRelation</seealso>
    let RecordResourceToInstantiationRelation =
        Prefixed_Name(rico, "RecordResourceToInstantiationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:RecordResourceToRecordResourceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least two Record Resources."</para>
    /// labels<para>"Record Resource to Record Resource Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RecordResourceToRecordResourceRelation">https://www.ica.org/standards/RiC/ontology#RecordResourceToRecordResourceRelation</seealso>
    let RecordResourceToRecordResourceRelation =
        Prefixed_Name(rico, "RecordResourceToRecordResourceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:RecordSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One or more records that are associated by categorization and/or
    ///             physical aggregation by the creator or other Agent."</para>
    /// labels<para>"Record Set"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RecordSet">https://www.ica.org/standards/RiC/ontology#RecordSet</seealso>
    let RecordSet = Prefixed_Name(rico, "RecordSet") |> PrefixedName
    /// <summary>
    ///   <para>rico:RecordSetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A broad categorization of the type of Record Set."</para>
    /// labels<para>"Record Set Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RecordSetType">https://www.ica.org/standards/RiC/ontology#RecordSetType</seealso>
    let RecordSetType = Prefixed_Name(rico, "RecordSetType") |> PrefixedName
    /// <summary>
    ///   <para>rico:RecordState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of the production or reproduction status of a
    ///             Record or Record Part."</para>
    /// labels<para>"Record State"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RecordState">https://www.ica.org/standards/RiC/ontology#RecordState</seealso>
    let RecordState = Prefixed_Name(rico, "RecordState") |> PrefixedName
    /// <summary>
    ///   <para>rico:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The top level relation class. It connects at least two Things.
    ///             An instance of a Relation may have some datatype and object properties : a descriptive
    ///             note (datatype property) like any Thing ; certainty (for 'certain', 'quite probable',
    ///             'uncertain','unknown'); a date (use either the date datatype property or the Date class
    ///             and isAssociatedWithDate object property ; a state (relationState) ; a location (use
    ///             Place class and isAssociatedWithPlace object property) ; a source of information that
    ///             can be used as an evidence for it (use either source datatype property or hasSource
    ///             object property)."</para>
    /// labels<para>"Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Relation">https://www.ica.org/standards/RiC/ontology#Relation</seealso>
    let Relation = Prefixed_Name(rico, "Relation") |> PrefixedName
    /// <summary>
    ///   <para>rico:RepresentationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of the method of recording the content type of a
    ///             Record Resource."</para>
    /// labels<para>"Representation Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RepresentationType">https://www.ica.org/standards/RiC/ontology#RepresentationType</seealso>
    let RepresentationType = Prefixed_Name(rico, "RepresentationType") |> PrefixedName

    /// <summary>
    ///   <para>rico:RiCCMCorrespondingComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"When it exists, specifies the identifier and name of RiC-CM
    ///             component that corresponds to the annotated class or property."</para>
    /// labels<para>"RiC-CM corresponding component"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RiCCMCorrespondingComponent">https://www.ica.org/standards/RiC/ontology#RiCCMCorrespondingComponent</seealso>
    let RiCCMCorrespondingComponent =
        Prefixed_Name(rico, "RiCCMCorrespondingComponent") |> PrefixedName

    /// <summary>
    ///   <para>rico:RoleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The role an agent plays in some context (usually in some
    ///             creation relation). Not to be confused with a position (position of an agent in some
    ///             group). For example, a person who is the head of some corporate body may play the role
    ///             of annotator (of a record) in a creation relation."</para>
    /// labels<para>"Role Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RoleType">https://www.ica.org/standards/RiC/ontology#RoleType</seealso>
    let RoleType = Prefixed_Name(rico, "RoleType") |> PrefixedName
    /// <summary>
    ///   <para>rico:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Conditions that govern the existence or authority of an Agent or the performance of an Activity, or that contribute to the distinct characteristics of things created or managed by an Agent."</para>
    /// labels<para>"Rule"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Rule">https://www.ica.org/standards/RiC/ontology#Rule</seealso>
    let Rule = Prefixed_Name(rico, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>rico:RuleRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Rule to at least one Thing, when it is
    ///             associated with existence and lifecycle of the Thing."</para>
    /// labels<para>"Rule Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RuleRelation">https://www.ica.org/standards/RiC/ontology#RuleRelation</seealso>
    let RuleRelation = Prefixed_Name(rico, "RuleRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:RuleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categorization of a Rule."</para>
    /// labels<para>"Rule Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#RuleType">https://www.ica.org/standards/RiC/ontology#RuleType</seealso>
    let RuleType = Prefixed_Name(rico, "RuleType") |> PrefixedName
    /// <summary>
    ///   <para>rico:SequentialRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Thing to at least one Thing that follows
    ///             it in some sequence."</para>
    /// labels<para>"Sequential Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#SequentialRelation">https://www.ica.org/standards/RiC/ontology#SequentialRelation</seealso>
    let SequentialRelation = Prefixed_Name(rico, "SequentialRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:SiblingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least two Persons, when they are
    ///             siblings."</para>
    /// labels<para>"Sibling Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#SiblingRelation">https://www.ica.org/standards/RiC/ontology#SiblingRelation</seealso>
    let SiblingRelation = Prefixed_Name(rico, "SiblingRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:SingleDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Chronological information associated with an entity that
    ///             contributes to its identification and contextualization, related to a single point in
    ///             time."</para>
    /// labels<para>"Single Date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#SingleDate">https://www.ica.org/standards/RiC/ontology#SingleDate</seealso>
    let SingleDate = Prefixed_Name(rico, "SingleDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:SpouseRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least two Persons, when they are
    ///             spouses."</para>
    /// labels<para>"Spouse Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#SpouseRelation">https://www.ica.org/standards/RiC/ontology#SpouseRelation</seealso>
    let SpouseRelation = Prefixed_Name(rico, "SpouseRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:TeachingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Person to at least another Person, who is
    ///             their student."</para>
    /// labels<para>"Teaching Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#TeachingRelation">https://www.ica.org/standards/RiC/ontology#TeachingRelation</seealso>
    let TeachingRelation = Prefixed_Name(rico, "TeachingRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:TemporalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least one Thing to at least one Thing that follows
    ///             it in chronological order."</para>
    /// labels<para>"Temporal Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#TemporalRelation">https://www.ica.org/standards/RiC/ontology#TemporalRelation</seealso>
    let TemporalRelation = Prefixed_Name(rico, "TemporalRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any idea, material thing, or event within the realm of human
    ///             experience."</para>
    /// labels<para>"Thing"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Thing">https://www.ica.org/standards/RiC/ontology#Thing</seealso>
    let Thing = Prefixed_Name(rico, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>rico:Title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A name that is used for a Record Resource or a
    ///             Rule"</para>
    /// labels<para>"Title"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Title">https://www.ica.org/standards/RiC/ontology#Title</seealso>
    let Title = Prefixed_Name(rico, "Title") |> PrefixedName
    /// <summary>
    ///   <para>rico:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A superclass for any category of some thing. A type
    ///             characterizes an entity."</para>
    /// labels<para>"Type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#Type">https://www.ica.org/standards/RiC/ontology#Type</seealso>
    let Type = Prefixed_Name(rico, "Type") |> PrefixedName
    /// <summary>
    ///   <para>rico:TypeRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a category (a Type) and at least one Thing that belongs
    ///             to this category."</para>
    /// labels<para>"Type Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#TypeRelation">https://www.ica.org/standards/RiC/ontology#TypeRelation</seealso>
    let TypeRelation = Prefixed_Name(rico, "TypeRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:UnitOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A definite magnitude of a quantity, defined and adopted by convention or by
    ///             law, that is used as a standard for measurement of the same kind of quantity. Can be
    ///             spacial units (cm, m), weigt (g, kg), time (s, h), storage (MB, TB) or more informal
    ///             units used in the archival context like number of boxes, pages or words."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unit Of Measurement"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#UnitOfMeasurement">https://www.ica.org/standards/RiC/ontology#UnitOfMeasurement</seealso>
    let UnitOfMeasurement = Prefixed_Name(rico, "UnitOfMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>rico:WholePartRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Thing to at least one constitutive or component part
    ///             of that Thing."</para>
    /// labels<para>"Whole Part Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#WholePartRelation">https://www.ica.org/standards/RiC/ontology#WholePartRelation</seealso>
    let WholePartRelation = Prefixed_Name(rico, "WholePartRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:WorkRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connects at least two Agents that have some type of work
    ///             relation in the course of their activities."</para>
    /// labels<para>"Work Relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#WorkRelation">https://www.ica.org/standards/RiC/ontology#WorkRelation</seealso>
    let WorkRelation = Prefixed_Name(rico, "WorkRelation") |> PrefixedName
    /// <summary>
    ///   <para>rico:accrual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information on the anticipated accession(s) to the Record
    ///             Set."</para>
    /// labels<para>"accrual"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#accrual">https://www.ica.org/standards/RiC/ontology#accrual</seealso>
    let accrual = Prefixed_Name(rico, "accrual") |> PrefixedName
    /// <summary>
    ///   <para>rico:accrualStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information on the status of an Accrual"</para>
    /// labels<para>"accrual status"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#accrualStatus">https://www.ica.org/standards/RiC/ontology#accrualStatus</seealso>
    let accrualStatus = Prefixed_Name(rico, "accrualStatus") |> PrefixedName

    /// <summary>
    ///   <para>rico:accumulationRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an Accumulation Relation to one of the accumulated
    ///             Record Resources or Instantiations"</para>
    /// labels<para>"accumulation relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#accumulationRelationHasSource">https://www.ica.org/standards/RiC/ontology#accumulationRelationHasSource</seealso>
    let accumulationRelationHasSource =
        Prefixed_Name(rico, "accumulationRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:accumulationRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Accumulation Relation to one of the accumulating
    ///             Agents"</para>
    /// labels<para>"accumulation relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#accumulationRelationHasTarget">https://www.ica.org/standards/RiC/ontology#accumulationRelationHasTarget</seealso>
    let accumulationRelationHasTarget =
        Prefixed_Name(rico, "accumulationRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:activityDocumentationRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Activity Documentation Relation to one of the
    ///             resulting Record Resources or Instantiations"</para>
    /// labels<para>"activity documentation relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#activityDocumentationRelationHasSource">https://www.ica.org/standards/RiC/ontology#activityDocumentationRelationHasSource</seealso>
    let activityDocumentationRelationHasSource =
        Prefixed_Name(rico, "activityDocumentationRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:activityDocumentationRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Activity Documentation Relation to one of the
    ///             documented Activities"</para>
    /// labels<para>"activity documentation relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#activityDocumentationRelationHasTarget">https://www.ica.org/standards/RiC/ontology#activityDocumentationRelationHasTarget</seealso>
    let activityDocumentationRelationHasTarget =
        Prefixed_Name(rico, "activityDocumentationRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:activityIsContextOfRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an Activity to an Agent Temporal Relation (when the
    ///             Activity is transferred from an Agent to another one) or a Mandate Relation (the Mandate
    ///             assigns the Activity to the Agent or defines it)."</para>
    /// labels<para>"activity is context of relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#activityIsContextOfRelation">https://www.ica.org/standards/RiC/ontology#activityIsContextOfRelation</seealso>
    let activityIsContextOfRelation =
        Prefixed_Name(rico, "activityIsContextOfRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:activityIsSourceOfPerformanceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Activity that is performed to a Performance
    ///             Relation"</para>
    /// labels<para>"activity is source of performance relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#activityIsSourceOfPerformanceRelation">https://www.ica.org/standards/RiC/ontology#activityIsSourceOfPerformanceRelation</seealso>
    let activityIsSourceOfPerformanceRelation =
        Prefixed_Name(rico, "activityIsSourceOfPerformanceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:activityIsTargetOfActivityDocumentationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Activity to an Activity Documentation
    ///             Relation"</para>
    /// labels<para>"activity is target of activity documentation relation
    ///         "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#activityIsTargetOfActivityDocumentationRelation">https://www.ica.org/standards/RiC/ontology#activityIsTargetOfActivityDocumentationRelation</seealso>
    let activityIsTargetOfActivityDocumentationRelation =
        Prefixed_Name(rico, "activityIsTargetOfActivityDocumentationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:affectsOrAffected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Event to a Thing on which the Event has or had some
    ///             significant impact."</para>
    /// labels<para>"affects or affected"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#affectsOrAffected">https://www.ica.org/standards/RiC/ontology#affectsOrAffected</seealso>
    let affectsOrAffected = Prefixed_Name(rico, "affectsOrAffected") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentControlRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent Control Relation to one of the controlling
    ///             Agents"</para>
    /// labels<para>"agent control relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentControlRelationHasSource">https://www.ica.org/standards/RiC/ontology#agentControlRelationHasSource</seealso>
    let agentControlRelationHasSource =
        Prefixed_Name(rico, "agentControlRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentControlRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent Control Relation to one of the controlled
    ///             Agents"</para>
    /// labels<para>"agent control relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentControlRelationHasTarget">https://www.ica.org/standards/RiC/ontology#agentControlRelationHasTarget</seealso>
    let agentControlRelationHasTarget =
        Prefixed_Name(rico, "agentControlRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentHasWorkRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent to a Work Relation"</para>
    /// labels<para>"agent has work relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentHasWorkRelation">https://www.ica.org/standards/RiC/ontology#agentHasWorkRelation</seealso>
    let agentHasWorkRelation =
        Prefixed_Name(rico, "agentHasWorkRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentHierarchicalRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent Hierarchical Relation to one of the
    ///             hierarchically superior Agents"</para>
    /// labels<para>"agent hierarchical relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentHierarchicalRelationHasSource">https://www.ica.org/standards/RiC/ontology#agentHierarchicalRelationHasSource</seealso>
    let agentHierarchicalRelationHasSource =
        Prefixed_Name(rico, "agentHierarchicalRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentHierarchicalRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent Hierarchical Relation to one of the
    ///             hierarchically inferior Agents"</para>
    /// labels<para>"agent hierarchical relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentHierarchicalRelationHasTarget">https://www.ica.org/standards/RiC/ontology#agentHierarchicalRelationHasTarget</seealso>
    let agentHierarchicalRelationHasTarget =
        Prefixed_Name(rico, "agentHierarchicalRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsConnectedToAgentRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent to an Agent Relation"</para>
    /// labels<para>"agent is connected to agent relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsConnectedToAgentRelation">https://www.ica.org/standards/RiC/ontology#agentIsConnectedToAgentRelation</seealso>
    let agentIsConnectedToAgentRelation =
        Prefixed_Name(rico, "agentIsConnectedToAgentRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsSourceOfAgentControlRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a controlling Agent to an Agent Control
    ///             Relation"</para>
    /// labels<para>"agent is source of agent control relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentControlRelation">https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentControlRelation</seealso>
    let agentIsSourceOfAgentControlRelation =
        Prefixed_Name(rico, "agentIsSourceOfAgentControlRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsSourceOfAgentHierarchicalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a hierarchically superior Agent to an Agent
    ///             Hierarchical Relation"</para>
    /// labels<para>"agent is source of agent hierarchical relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentHierarchicalRelation">https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentHierarchicalRelation</seealso>
    let agentIsSourceOfAgentHierarchicalRelation =
        Prefixed_Name(rico, "agentIsSourceOfAgentHierarchicalRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsSourceOfAgentTemporalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a predecessor Agent to an Agent Temporal
    ///             Relation"</para>
    /// labels<para>"agent is source of agent temporal relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentTemporalRelation">https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentTemporalRelation</seealso>
    let agentIsSourceOfAgentTemporalRelation =
        Prefixed_Name(rico, "agentIsSourceOfAgentTemporalRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsSourceOfAuthorityRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent thas has the authority, to an Authority
    ///             Relation"</para>
    /// labels<para>"agent is source of authority relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAuthorityRelation">https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAuthorityRelation</seealso>
    let agentIsSourceOfAuthorityRelation =
        Prefixed_Name(rico, "agentIsSourceOfAuthorityRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsSourceOfIntellectualPropertyRightsRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent having the intellectual property rights, to an
    ///             Intellectual Property Rights Relation"</para>
    /// labels<para>"agent is source of intellectual property rights relation
    ///         "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfIntellectualPropertyRightsRelation">https://www.ica.org/standards/RiC/ontology#agentIsSourceOfIntellectualPropertyRightsRelation</seealso>
    let agentIsSourceOfIntellectualPropertyRightsRelation =
        Prefixed_Name(rico, "agentIsSourceOfIntellectualPropertyRightsRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsSourceOfManagementRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a manager Agent to a Management Relation"</para>
    /// labels<para>"agent is source of management relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfManagementRelation">https://www.ica.org/standards/RiC/ontology#agentIsSourceOfManagementRelation</seealso>
    let agentIsSourceOfManagementRelation =
        Prefixed_Name(rico, "agentIsSourceOfManagementRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsSourceOfOwnershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an owner Agent to an Ownership Relation"</para>
    /// labels<para>"agent is source of ownership relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfOwnershipRelation">https://www.ica.org/standards/RiC/ontology#agentIsSourceOfOwnershipRelation</seealso>
    let agentIsSourceOfOwnershipRelation =
        Prefixed_Name(rico, "agentIsSourceOfOwnershipRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsSourceOfRecordResourceHoldingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent that holds a Record Resource or Instantiation,
    ///             to a Record Resource Holding Relation"</para>
    /// labels<para>"agent is source of record resource holding relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfRecordResourceHoldingRelation">https://www.ica.org/standards/RiC/ontology#agentIsSourceOfRecordResourceHoldingRelation</seealso>
    let agentIsSourceOfRecordResourceHoldingRelation =
        Prefixed_Name(rico, "agentIsSourceOfRecordResourceHoldingRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsTargetOfAccumulationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects one of the accumulating Agents to an Accumulation
    ///             Relation"</para>
    /// labels<para>"agent is target of accumulation relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAccumulationRelation">https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAccumulationRelation</seealso>
    let agentIsTargetOfAccumulationRelation =
        Prefixed_Name(rico, "agentIsTargetOfAccumulationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsTargetOfAgentControlRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects one of the controlled Agents to an Agent Control
    ///             Relation"</para>
    /// labels<para>"agent is target of agent control relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentControlRelation">https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentControlRelation</seealso>
    let agentIsTargetOfAgentControlRelation =
        Prefixed_Name(rico, "agentIsTargetOfAgentControlRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsTargetOfAgentHierarchicalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects one of the hierarchically inferior Agents to an Agent
    ///             Hierarchical Relation"</para>
    /// labels<para>"agent is target of agent hierarchical relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentHierarchicalRelation">https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentHierarchicalRelation</seealso>
    let agentIsTargetOfAgentHierarchicalRelation =
        Prefixed_Name(rico, "agentIsTargetOfAgentHierarchicalRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsTargetOfAgentOriginationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects one of the Agents that created or accumulated the
    ///             Record resource or Instantiation, to an Agent Origination Relation"</para>
    /// labels<para>"agent is target of agent origination relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentOriginationRelation">https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentOriginationRelation</seealso>
    let agentIsTargetOfAgentOriginationRelation =
        Prefixed_Name(rico, "agentIsTargetOfAgentOriginationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsTargetOfAgentTemporalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a successor Agent to an Agent Temporal
    ///             Relation"</para>
    /// labels<para>"agent is target of agent temporal relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentTemporalRelation">https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentTemporalRelation</seealso>
    let agentIsTargetOfAgentTemporalRelation =
        Prefixed_Name(rico, "agentIsTargetOfAgentTemporalRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsTargetOfAuthorshipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Person, Group or Position to an Authorship
    ///             Relation."</para>
    /// labels<para>"agent is target of authorship relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAuthorshipRelation">https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAuthorshipRelation</seealso>
    let agentIsTargetOfAuthorshipRelation =
        Prefixed_Name(rico, "agentIsTargetOfAuthorshipRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsTargetOfCreationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a creator Agent to a Creation Relation"</para>
    /// labels<para>"agent is target of creation relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfCreationRelation">https://www.ica.org/standards/RiC/ontology#agentIsTargetOfCreationRelation</seealso>
    let agentIsTargetOfCreationRelation =
        Prefixed_Name(rico, "agentIsTargetOfCreationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsTargetOfMandateRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a mandated Agent to a Mandate Relation"</para>
    /// labels<para>"agent is target of mandate relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfMandateRelation">https://www.ica.org/standards/RiC/ontology#agentIsTargetOfMandateRelation</seealso>
    let agentIsTargetOfMandateRelation =
        Prefixed_Name(rico, "agentIsTargetOfMandateRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentIsTargetOfPerformanceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent to a Performance Relation"</para>
    /// labels<para>"agent is target of performance relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfPerformanceRelation">https://www.ica.org/standards/RiC/ontology#agentIsTargetOfPerformanceRelation</seealso>
    let agentIsTargetOfPerformanceRelation =
        Prefixed_Name(rico, "agentIsTargetOfPerformanceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentOrActivityIsTargetOfProvenanceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an Agent or Activity that is the provenance of a Record
    ///             resource or Instantiation, to a Provenance Relation"</para>
    /// labels<para>"agent or activity is target of provenance relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentOrActivityIsTargetOfProvenanceRelation">https://www.ica.org/standards/RiC/ontology#agentOrActivityIsTargetOfProvenanceRelation</seealso>
    let agentOrActivityIsTargetOfProvenanceRelation =
        Prefixed_Name(rico, "agentOrActivityIsTargetOfProvenanceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentOriginationRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an Agent Origination Relation to one of the resulting
    ///             Record Resource or Instantiation"</para>
    /// labels<para>"agent origination relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentOriginationRelationHasSource">https://www.ica.org/standards/RiC/ontology#agentOriginationRelationHasSource</seealso>
    let agentOriginationRelationHasSource =
        Prefixed_Name(rico, "agentOriginationRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentOriginationRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent Origination Relation to one of the creating or
    ///             accumulating Agents"</para>
    /// labels<para>"agent origination relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentOriginationRelationHasTarget">https://www.ica.org/standards/RiC/ontology#agentOriginationRelationHasTarget</seealso>
    let agentOriginationRelationHasTarget =
        Prefixed_Name(rico, "agentOriginationRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent Relation to one of the involved
    ///             Agents"</para>
    /// labels<para>"agent relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentRelationConnects">https://www.ica.org/standards/RiC/ontology#agentRelationConnects</seealso>
    let agentRelationConnects =
        Prefixed_Name(rico, "agentRelationConnects") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentTemporalRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent Temporal Relation to one of the predecessor
    ///             Agents"</para>
    /// labels<para>"agent temporal relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentTemporalRelationHasSource">https://www.ica.org/standards/RiC/ontology#agentTemporalRelationHasSource</seealso>
    let agentTemporalRelationHasSource =
        Prefixed_Name(rico, "agentTemporalRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:agentTemporalRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent Temporal Relation to one of the successor
    ///             Agents"</para>
    /// labels<para>"agent temporal relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#agentTemporalRelationHasTarget">https://www.ica.org/standards/RiC/ontology#agentTemporalRelationHasTarget</seealso>
    let agentTemporalRelationHasTarget =
        Prefixed_Name(rico, "agentTemporalRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:altimetricSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Reference system used for altitude"</para>
    /// labels<para>"altimetric system"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#altimetricSystem">https://www.ica.org/standards/RiC/ontology#altimetricSystem</seealso>
    let altimetricSystem = Prefixed_Name(rico, "altimetricSystem") |> PrefixedName
    /// <summary>
    ///   <para>rico:altitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The height of a Place above a reference level, especially above
    ///             sea level."</para>
    /// labels<para>"altitude"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#altitude">https://www.ica.org/standards/RiC/ontology#altitude</seealso>
    let altitude = Prefixed_Name(rico, "altitude") |> PrefixedName

    /// <summary>
    ///   <para>rico:appellationIsSourceOfAppellationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Appellation to an Appellation
    ///             Relation"</para>
    /// labels<para>"appellation is source of appellation relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#appellationIsSourceOfAppellationRelation">https://www.ica.org/standards/RiC/ontology#appellationIsSourceOfAppellationRelation</seealso>
    let appellationIsSourceOfAppellationRelation =
        Prefixed_Name(rico, "appellationIsSourceOfAppellationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:appellationRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Appellation Relation to the concerned
    ///             Appellation"</para>
    /// labels<para>"appellation relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#appellationRelationHasSource">https://www.ica.org/standards/RiC/ontology#appellationRelationHasSource</seealso>
    let appellationRelationHasSource =
        Prefixed_Name(rico, "appellationRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:appellationRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Appellation Relation to one of the designated
    ///             Things"</para>
    /// labels<para>"appellation relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#appellationRelationHasTarget">https://www.ica.org/standards/RiC/ontology#appellationRelationHasTarget</seealso>
    let appellationRelationHasTarget =
        Prefixed_Name(rico, "appellationRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:asConcernsActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent Temporal Relation or Mandate Relation, to an
    ///             Activity that is, either transferred from an Agent to another one, or assigned by a
    ///             Mandate to an Agent."</para>
    /// labels<para>"as concerns activity "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#asConcernsActivity">https://www.ica.org/standards/RiC/ontology#asConcernsActivity</seealso>
    let asConcernsActivity = Prefixed_Name(rico, "asConcernsActivity") |> PrefixedName
    /// <summary>
    ///   <para>rico:authenticityNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Description of evidences that the Record Resource or
    ///             Instantiation is what it purports to be, was created or sent by the said Agent, at the
    ///             said time and has not been tampered or corrupted."</para>
    /// labels<para>"authenticity note"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#authenticityNote">https://www.ica.org/standards/RiC/ontology#authenticityNote</seealso>
    let authenticityNote = Prefixed_Name(rico, "authenticityNote") |> PrefixedName

    /// <summary>
    ///   <para>rico:authorityRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Authority Relation to an Agent that has the
    ///             authority"</para>
    /// labels<para>"authority relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#authorityRelationHasSource">https://www.ica.org/standards/RiC/ontology#authorityRelationHasSource</seealso>
    let authorityRelationHasSource =
        Prefixed_Name(rico, "authorityRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:authorityRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Authority Relation to a Thing over which the
    ///             Authority is performed"</para>
    /// labels<para>"authority relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#authorityRelationHasTarget">https://www.ica.org/standards/RiC/ontology#authorityRelationHasTarget</seealso>
    let authorityRelationHasTarget =
        Prefixed_Name(rico, "authorityRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:authorizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'authorizes' object property"</para>
    /// labels<para>"authorized by "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#authorizedBy">https://www.ica.org/standards/RiC/ontology#authorizedBy</seealso>
    let authorizedBy = Prefixed_Name(rico, "authorizedBy") |> PrefixedName
    /// <summary>
    ///   <para>rico:authorizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Mandate to the Agent that the Mandate gives the
    ///             authority or competencies to act."</para>
    /// labels<para>"authorizes"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#authorizes">https://www.ica.org/standards/RiC/ontology#authorizes</seealso>
    let authorizes = Prefixed_Name(rico, "authorizes") |> PrefixedName
    /// <summary>
    ///   <para>rico:authorizingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Mandate Relation to an Agent that assigns the
    ///             Mandate."</para>
    /// labels<para>"authorizing agent "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#authorizingAgent">https://www.ica.org/standards/RiC/ontology#authorizingAgent</seealso>
    let authorizingAgent = Prefixed_Name(rico, "authorizingAgent") |> PrefixedName
    /// <summary>
    ///   <para>rico:authorizingMandate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information on a Mandate that authorizes an Agent to perform an
    ///             Activity."</para>
    /// labels<para>"authorizing mandate"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#authorizingMandate">https://www.ica.org/standards/RiC/ontology#authorizingMandate</seealso>
    let authorizingMandate = Prefixed_Name(rico, "authorizingMandate") |> PrefixedName

    /// <summary>
    ///   <para>rico:authorshipRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Authorship Relation to one of the Records involved
    ///             in the relation."</para>
    /// labels<para>"authorship relation has source"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#authorshipRelationHasSource">https://www.ica.org/standards/RiC/ontology#authorshipRelationHasSource</seealso>
    let authorshipRelationHasSource =
        Prefixed_Name(rico, "authorshipRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:authorshipRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an Authorship Relation to one of the author Person,
    ///             Group or Position."</para>
    /// labels<para>"authorship relation has target"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#authorshipRelationHasTarget">https://www.ica.org/standards/RiC/ontology#authorshipRelationHasTarget</seealso>
    let authorshipRelationHasTarget =
        Prefixed_Name(rico, "authorshipRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:beginningDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date at which something began."</para>
    /// labels<para>"beginning date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#beginningDate">https://www.ica.org/standards/RiC/ontology#beginningDate</seealso>
    let beginningDate = Prefixed_Name(rico, "beginningDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:birthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date at which a Person was born."</para>
    /// labels<para>"birth date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#birthDate">https://www.ica.org/standards/RiC/ontology#birthDate</seealso>
    let birthDate = Prefixed_Name(rico, "birthDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used system of reckoning time in which the beginning, length,
    ///             and divisions of a year are defined, sometimes along with multiyear
    ///             cycles."</para>
    /// labels<para>"calendar"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#calendar">https://www.ica.org/standards/RiC/ontology#calendar</seealso>
    let calendar = Prefixed_Name(rico, "calendar") |> PrefixedName
    /// <summary>
    ///   <para>rico:carrierExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of physical units and/or physical dimensions of the
    ///             carrier of a record resource instantiation. Various carriers, depending on specific
    ///             needs, may have more than one relevant dimension. In some cases, indicating the number
    ///             of physical units may be sufficient, while in other case, relevant dimensions should be
    ///             used in order to characterize the carrier."</para>
    /// labels<para>"carrier extent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#carrierExtent">https://www.ica.org/standards/RiC/ontology#carrierExtent</seealso>
    let carrierExtent = Prefixed_Name(rico, "carrierExtent") |> PrefixedName
    /// <summary>
    ///   <para>rico:certainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Qualifies the level of certitude of the accuracy of a Date, an
    ///             Event or a Relation."</para>
    /// labels<para>"certainty"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#certainty">https://www.ica.org/standards/RiC/ontology#certainty</seealso>
    let certainty = Prefixed_Name(rico, "certainty") |> PrefixedName

    /// <summary>
    ///   <para>rico:childRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Child Relation to a parent Person"</para>
    /// labels<para>"child relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#childRelationHasSource">https://www.ica.org/standards/RiC/ontology#childRelationHasSource</seealso>
    let childRelationHasSource =
        Prefixed_Name(rico, "childRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:childRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Child Relation to a child Person"</para>
    /// labels<para>"child relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#childRelationHasTarget">https://www.ica.org/standards/RiC/ontology#childRelationHasTarget</seealso>
    let childRelationHasTarget =
        Prefixed_Name(rico, "childRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A term, number or alphanumeric string that is usually taken from
    ///             an external classification vocabulary or scheme that qualifies the Record
    ///             Resource."</para>
    /// labels<para>"classification"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#classification">https://www.ica.org/standards/RiC/ontology#classification</seealso>
    let classification = Prefixed_Name(rico, "classification") |> PrefixedName
    /// <summary>
    ///   <para>rico:closeTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An annotation property for recording a possible mapping to a
    ///             component in another model or ontology"</para>
    /// labels<para>"close to"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#closeTo">https://www.ica.org/standards/RiC/ontology#closeTo</seealso>
    let closeTo = Prefixed_Name(rico, "closeTo") |> PrefixedName
    /// <summary>
    ///   <para>rico:conditionsOfAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Terms and circumstances affecting the availability of a Record
    ///             Resource for consultation. Such conditions may originate in laws, regulations and
    ///             policies, including those pertaining to privacy and security concerns or restrictions;
    ///             they may concern a specific Instantiation of a Record Resource, for example, conditions
    ///             that require preservation treatment; or they may specify the software or hardware
    ///             necessary to access the Instantiation."</para>
    /// labels<para>"conditions of access"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#conditionsOfAccess">https://www.ica.org/standards/RiC/ontology#conditionsOfAccess</seealso>
    let conditionsOfAccess = Prefixed_Name(rico, "conditionsOfAccess") |> PrefixedName
    /// <summary>
    ///   <para>rico:conditionsOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Terms and circumstances affecting the use of a Record Resource
    ///             after access has been provided. Includes conditions governing reproduction of the Record
    ///             Resource under applicable copyright (intellectual property) and/or property legislation,
    ///             and of the Instantiation, due to conservation status."</para>
    /// labels<para>"conditions of use"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#conditionsOfUse">https://www.ica.org/standards/RiC/ontology#conditionsOfUse</seealso>
    let conditionsOfUse = Prefixed_Name(rico, "conditionsOfUse") |> PrefixedName
    /// <summary>
    ///   <para>rico:containsOrContained</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place to a region that is or was within
    ///             it."</para>
    /// labels<para>"contains or contained"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#containsOrContained">https://www.ica.org/standards/RiC/ontology#containsOrContained</seealso>
    let containsOrContained = Prefixed_Name(rico, "containsOrContained") |> PrefixedName

    /// <summary>
    ///   <para>rico:correspondenceRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Correspondence Relation to one of the Persons
    ///             involved"</para>
    /// labels<para>"correspondence relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#correspondenceRelationConnects">https://www.ica.org/standards/RiC/ontology#correspondenceRelationConnects</seealso>
    let correspondenceRelationConnects =
        Prefixed_Name(rico, "correspondenceRelationConnects") |> PrefixedName

    /// <summary>
    ///   <para>rico:creationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date at which an entity was created."</para>
    /// labels<para>"creation date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#creationDate">https://www.ica.org/standards/RiC/ontology#creationDate</seealso>
    let creationDate = Prefixed_Name(rico, "creationDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:creationRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Creation Relation to one of the created Record
    ///             Resources or Instantiations"</para>
    /// labels<para>"creation relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#creationRelationHasSource">https://www.ica.org/standards/RiC/ontology#creationRelationHasSource</seealso>
    let creationRelationHasSource =
        Prefixed_Name(rico, "creationRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:creationRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Creation Relation to one of the creator
    ///             Agents"</para>
    /// labels<para>"creation relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#creationRelationHasTarget">https://www.ica.org/standards/RiC/ontology#creationRelationHasTarget</seealso>
    let creationRelationHasTarget =
        Prefixed_Name(rico, "creationRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:creationWithRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Creation Relation to the Role Type that the creator
    ///             Agent(s) has in the creation process"</para>
    /// labels<para>"creation with role "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#creationWithRole">https://www.ica.org/standards/RiC/ontology#creationWithRole</seealso>
    let creationWithRole = Prefixed_Name(rico, "creationWithRole") |> PrefixedName
    /// <summary>
    ///   <para>rico:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Chronological information associated with an entity that
    ///             contributes to its identification and contextualization."</para>
    /// labels<para>"date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#date">https://www.ica.org/standards/RiC/ontology#date</seealso>
    let date = Prefixed_Name(rico, "date") |> PrefixedName
    /// <summary>
    ///   <para>rico:dateQualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the precision of a date. It specifies if, and to what
    ///             extent, the value is an estimation."</para>
    /// labels<para>"date qualifier"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#dateQualifier">https://www.ica.org/standards/RiC/ontology#dateQualifier</seealso>
    let dateQualifier = Prefixed_Name(rico, "dateQualifier") |> PrefixedName
    /// <summary>
    ///   <para>rico:dateStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifier of the standard of the Normalized
    ///             date."</para>
    /// labels<para>"date standard"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#dateStandard">https://www.ica.org/standards/RiC/ontology#dateStandard</seealso>
    let dateStandard = Prefixed_Name(rico, "dateStandard") |> PrefixedName
    /// <summary>
    ///   <para>rico:deathDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date at which a Person died."</para>
    /// labels<para>"death date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#deathDate">https://www.ica.org/standards/RiC/ontology#deathDate</seealso>
    let deathDate = Prefixed_Name(rico, "deathDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:deletionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date at which an entity was deleted."</para>
    /// labels<para>"deletion date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#deletionDate">https://www.ica.org/standards/RiC/ontology#deletionDate</seealso>
    let deletionDate = Prefixed_Name(rico, "deletionDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:derivationRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Derivation Relation to the Instantiation from which
    ///             one or more Instantiations is derived."</para>
    /// labels<para>"derivation relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#derivationRelationHasSource">https://www.ica.org/standards/RiC/ontology#derivationRelationHasSource</seealso>
    let derivationRelationHasSource =
        Prefixed_Name(rico, "derivationRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:derivationRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Derivation Relation to one of the derived
    ///             Instantiations"</para>
    /// labels<para>"derivation relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#derivationRelationHasTarget">https://www.ica.org/standards/RiC/ontology#derivationRelationHasTarget</seealso>
    let derivationRelationHasTarget =
        Prefixed_Name(rico, "derivationRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:descendanceRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Descendance Relation to one of the ancestor
    ///             Persons"</para>
    /// labels<para>"descendance relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#descendanceRelationHasSource">https://www.ica.org/standards/RiC/ontology#descendanceRelationHasSource</seealso>
    let descendanceRelationHasSource =
        Prefixed_Name(rico, "descendanceRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:descendanceRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Descendance Relation to one of the descendant
    ///             Persons"</para>
    /// labels<para>"descendance relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#descendanceRelationHasTarget">https://www.ica.org/standards/RiC/ontology#descendanceRelationHasTarget</seealso>
    let descendanceRelationHasTarget =
        Prefixed_Name(rico, "descendanceRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:describesOrDescribed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource to a Thing that it
    ///             describes."</para>
    /// labels<para>"describes or described"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#describesOrDescribed">https://www.ica.org/standards/RiC/ontology#describesOrDescribed</seealso>
    let describesOrDescribed =
        Prefixed_Name(rico, "describesOrDescribed") |> PrefixedName

    /// <summary>
    ///   <para>rico:descriptiveNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Descriptive information about an entity that is not otherwise
    ///             addressed."</para>
    /// labels<para>"descriptive note"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#descriptiveNote">https://www.ica.org/standards/RiC/ontology#descriptiveNote</seealso>
    let descriptiveNote = Prefixed_Name(rico, "descriptiveNote") |> PrefixedName
    /// <summary>
    ///   <para>rico:documentedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'documents' object property."</para>
    /// labels<para>"documented by"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#documentedBy">https://www.ica.org/standards/RiC/ontology#documentedBy</seealso>
    let documentedBy = Prefixed_Name(rico, "documentedBy") |> PrefixedName
    /// <summary>
    ///   <para>rico:documents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource or an Instantiation to the Activity
    ///             that generates the Record Resource or Instantiation."</para>
    /// labels<para>"documents"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#documents">https://www.ica.org/standards/RiC/ontology#documents</seealso>
    let documents = Prefixed_Name(rico, "documents") |> PrefixedName
    /// <summary>
    ///   <para>rico:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date at which something ended."</para>
    /// labels<para>"end date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#endDate">https://www.ica.org/standards/RiC/ontology#endDate</seealso>
    let endDate = Prefixed_Name(rico, "endDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:eventIsSourceOfEventRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Event to an Event Relation"</para>
    /// labels<para>"event is source of event relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#eventIsSourceOfEventRelation">https://www.ica.org/standards/RiC/ontology#eventIsSourceOfEventRelation</seealso>
    let eventIsSourceOfEventRelation =
        Prefixed_Name(rico, "eventIsSourceOfEventRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:eventRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Event Relation to an Event"</para>
    /// labels<para>"event relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#eventRelationHasSource">https://www.ica.org/standards/RiC/ontology#eventRelationHasSource</seealso>
    let eventRelationHasSource =
        Prefixed_Name(rico, "eventRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:eventRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Event Relation to an associated Thing"</para>
    /// labels<para>"event relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#eventRelationHasTarget">https://www.ica.org/standards/RiC/ontology#eventRelationHasTarget</seealso>
    let eventRelationHasTarget =
        Prefixed_Name(rico, "eventRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:existsOrExistedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Position to a Group in which that Position exists or
    ///             existed, or that is defined by that Group�s organizational structure."</para>
    /// labels<para>"exists or existed in"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#existsOrExistedIn">https://www.ica.org/standards/RiC/ontology#existsOrExistedIn</seealso>
    let existsOrExistedIn = Prefixed_Name(rico, "existsOrExistedIn") |> PrefixedName
    /// <summary>
    ///   <para>rico:expressedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Natural language expression of a Date."</para>
    /// labels<para>"expressed date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#expressedDate">https://www.ica.org/standards/RiC/ontology#expressedDate</seealso>
    let expressedDate = Prefixed_Name(rico, "expressedDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:expressesOrExpressed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is or was expressed by' object
    ///             property."</para>
    /// labels<para>"expresses or expressed"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#expressesOrExpressed">https://www.ica.org/standards/RiC/ontology#expressesOrExpressed</seealso>
    let expressesOrExpressed =
        Prefixed_Name(rico, "expressesOrExpressed") |> PrefixedName

    /// <summary>
    ///   <para>rico:familyRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Family Relation to a Person."</para>
    /// labels<para>"family relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#familyRelationConnects">https://www.ica.org/standards/RiC/ontology#familyRelationConnects</seealso>
    let familyRelationConnects =
        Prefixed_Name(rico, "familyRelationConnects") |> PrefixedName

    /// <summary>
    ///   <para>rico:followsInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'precedes in time' object property."</para>
    /// labels<para>"follows in time"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#followsInTime">https://www.ica.org/standards/RiC/ontology#followsInTime</seealso>
    let followsInTime = Prefixed_Name(rico, "followsInTime") |> PrefixedName
    /// <summary>
    ///   <para>rico:followsOrFollowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'precedesOrPreceded' object property."</para>
    /// labels<para>"follows or followed"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#followsOrFollowed">https://www.ica.org/standards/RiC/ontology#followsOrFollowed</seealso>
    let followsOrFollowed = Prefixed_Name(rico, "followsOrFollowed") |> PrefixedName

    /// <summary>
    ///   <para>rico:functionalEquivalenceRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Functional Equivalence Relation to one of the
    ///             functionally equivalent Instantiations."</para>
    /// labels<para>"functional equivalence relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#functionalEquivalenceRelationConnects">https://www.ica.org/standards/RiC/ontology#functionalEquivalenceRelationConnects</seealso>
    let functionalEquivalenceRelationConnects =
        Prefixed_Name(rico, "functionalEquivalenceRelationConnects") |> PrefixedName

    /// <summary>
    ///   <para>rico:geodesicSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Reference system used for geographical
    ///             coordinates."</para>
    /// labels<para>"geodesic system"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#geodesicSystem">https://www.ica.org/standards/RiC/ontology#geodesicSystem</seealso>
    let geodesicSystem = Prefixed_Name(rico, "geodesicSystem") |> PrefixedName

    /// <summary>
    ///   <para>rico:geographicalCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Longitudinal and latitudinal information of a
    ///             Place."</para>
    /// labels<para>"geographical coordinates"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#geographicalCoordinates">https://www.ica.org/standards/RiC/ontology#geographicalCoordinates</seealso>
    let geographicalCoordinates =
        Prefixed_Name(rico, "geographicalCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>rico:groupIsSourceOfGroupSubdivisionRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects the Group that has at least a subdivision, to a Group
    ///             Subdivision Relation"</para>
    /// labels<para>"group is source of group subdivision relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#groupIsSourceOfGroupSubdivisionRelation">https://www.ica.org/standards/RiC/ontology#groupIsSourceOfGroupSubdivisionRelation</seealso>
    let groupIsSourceOfGroupSubdivisionRelation =
        Prefixed_Name(rico, "groupIsSourceOfGroupSubdivisionRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:groupIsSourceOfMembershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects the Group (that has one to many members) to a
    ///             Membership Relation"</para>
    /// labels<para>"group is source of membership relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#groupIsSourceOfMembershipRelation">https://www.ica.org/standards/RiC/ontology#groupIsSourceOfMembershipRelation</seealso>
    let groupIsSourceOfMembershipRelation =
        Prefixed_Name(rico, "groupIsSourceOfMembershipRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:groupIsTargetOfGroupSubdivisionRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Group that is a subdivision, to a Group Subdivision
    ///             Relation"</para>
    /// labels<para>"group is target of group subdivision relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfGroupSubdivisionRelation">https://www.ica.org/standards/RiC/ontology#groupIsTargetOfGroupSubdivisionRelation</seealso>
    let groupIsTargetOfGroupSubdivisionRelation =
        Prefixed_Name(rico, "groupIsTargetOfGroupSubdivisionRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:groupIsTargetOfLeadershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Group (which has a leader) to a Leadership
    ///             Relation"</para>
    /// labels<para>"group is target of leadership relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfLeadershipRelation">https://www.ica.org/standards/RiC/ontology#groupIsTargetOfLeadershipRelation</seealso>
    let groupIsTargetOfLeadershipRelation =
        Prefixed_Name(rico, "groupIsTargetOfLeadershipRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:groupIsTargetOfPositionToGroupRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects the Group (in which a Position exists) to a Position To
    ///             Group Relation"</para>
    /// labels<para>"group is target of position to group relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfPositionToGroupRelation">https://www.ica.org/standards/RiC/ontology#groupIsTargetOfPositionToGroupRelation</seealso>
    let groupIsTargetOfPositionToGroupRelation =
        Prefixed_Name(rico, "groupIsTargetOfPositionToGroupRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:groupSubdivisionRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Group Subdivision Relation to the Group that has
    ///             subdivisions"</para>
    /// labels<para>"group subdivision relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#groupSubdivisionRelationHasSource">https://www.ica.org/standards/RiC/ontology#groupSubdivisionRelationHasSource</seealso>
    let groupSubdivisionRelationHasSource =
        Prefixed_Name(rico, "groupSubdivisionRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:groupSubdivisionRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Group Subdivision Relation to one of the Groups that
    ///             is a subdivision"</para>
    /// labels<para>"group subdivision relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#groupSubdivisionRelationHasTarget">https://www.ica.org/standards/RiC/ontology#groupSubdivisionRelationHasTarget</seealso>
    let groupSubdivisionRelationHasTarget =
        Prefixed_Name(rico, "groupSubdivisionRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasAccumulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource or an Instantiation to the Agent that
    ///             accumulates it, be it intentionally (collecting) or not (receiving in the course of its
    ///             activities)."</para>
    /// labels<para>"has accumulator"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasAccumulator">https://www.ica.org/standards/RiC/ontology#hasAccumulator</seealso>
    let hasAccumulator = Prefixed_Name(rico, "hasAccumulator") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasActivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Activity to an Activity Type that categorizes
    ///             it."</para>
    /// labels<para>"has activity type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasActivityType">https://www.ica.org/standards/RiC/ontology#hasActivityType</seealso>
    let hasActivityType = Prefixed_Name(rico, "hasActivityType") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasAddressee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource or an Instantiation to the Agent that
    ///             it is addressed to."</para>
    /// labels<para>"has addressee"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasAddressee">https://www.ica.org/standards/RiC/ontology#hasAddressee</seealso>
    let hasAddressee = Prefixed_Name(rico, "hasAddressee") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasAncestor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has descendant' object property."</para>
    /// labels<para>"has ancestor"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasAncestor">https://www.ica.org/standards/RiC/ontology#hasAncestor</seealso>
    let hasAncestor = Prefixed_Name(rico, "hasAncestor") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record to the Group, Person or Position that is
    ///             responsible for conceiving and formulating the information contained in the
    ///             Record."</para>
    /// labels<para>"has author"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasAuthor">https://www.ica.org/standards/RiC/ontology#hasAuthor</seealso>
    let hasAuthor = Prefixed_Name(rico, "hasAuthor") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasBeginningDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is beginning date of' object property"</para>
    /// labels<para>"has beginning date "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasBeginningDate">https://www.ica.org/standards/RiC/ontology#hasBeginningDate</seealso>
    let hasBeginningDate = Prefixed_Name(rico, "hasBeginningDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasBirthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is birth date of' object property"</para>
    /// labels<para>"has birth date "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasBirthDate">https://www.ica.org/standards/RiC/ontology#hasBirthDate</seealso>
    let hasBirthDate = Prefixed_Name(rico, "hasBirthDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasCarrierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation to a Carrier Type which categorizes
    ///             its carrier."</para>
    /// labels<para>"has carrier type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasCarrierType">https://www.ica.org/standards/RiC/ontology#hasCarrierType</seealso>
    let hasCarrierType = Prefixed_Name(rico, "hasCarrierType") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to one of their children."</para>
    /// labels<para>"has child"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasChild">https://www.ica.org/standards/RiC/ontology#hasChild</seealso>
    let hasChild = Prefixed_Name(rico, "hasChild") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasCollector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource or an Instantiation to the Agent that
    ///             collects it intentionally (is a collector)."</para>
    /// labels<para>"has collector"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasCollector">https://www.ica.org/standards/RiC/ontology#hasCollector</seealso>
    let hasCollector = Prefixed_Name(rico, "hasCollector") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasContentOfType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record or a Record Part to a Content Type which
    ///             categorizes its content."</para>
    /// labels<para>"has content of type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasContentOfType">https://www.ica.org/standards/RiC/ontology#hasContentOfType</seealso>
    let hasContentOfType = Prefixed_Name(rico, "hasContentOfType") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource to a copy of that Record
    ///             Resource."</para>
    /// labels<para>"has copy "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasCopy">https://www.ica.org/standards/RiC/ontology#hasCopy</seealso>
    let hasCopy = Prefixed_Name(rico, "hasCopy") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource or an Instantiation to an Agent that
    ///             is either responsible for all or some of the content of the Record Resource or is a
    ///             contributor to the genesis or production of an Instantiation."</para>
    /// labels<para>"has creator"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasCreator">https://www.ica.org/standards/RiC/ontology#hasCreator</seealso>
    let hasCreator = Prefixed_Name(rico, "hasCreator") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasDeathDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is death date of' object property"</para>
    /// labels<para>"has death date "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasDeathDate">https://www.ica.org/standards/RiC/ontology#hasDeathDate</seealso>
    let hasDeathDate = Prefixed_Name(rico, "hasDeathDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasDerivedInstantiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation to an Instantiation that is derived
    ///             from it."</para>
    /// labels<para>"has derived instantiation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasDerivedInstantiation">https://www.ica.org/standards/RiC/ontology#hasDerivedInstantiation</seealso>
    let hasDerivedInstantiation =
        Prefixed_Name(rico, "hasDerivedInstantiation") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasDescendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to one of their descendants."</para>
    /// labels<para>"has descendant"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasDescendant">https://www.ica.org/standards/RiC/ontology#hasDescendant</seealso>
    let hasDescendant = Prefixed_Name(rico, "hasDescendant") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasDocumentaryFormType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record or Record Part to its Documentary Form
    ///             Type."</para>
    /// labels<para>"has documentary form type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasDocumentaryFormType">https://www.ica.org/standards/RiC/ontology#hasDocumentaryFormType</seealso>
    let hasDocumentaryFormType =
        Prefixed_Name(rico, "hasDocumentaryFormType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasDraft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inverse of 'is draft of' object property."</para>
    /// labels<para>"has draft "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasDraft">https://www.ica.org/standards/RiC/ontology#hasDraft</seealso>
    let hasDraft = Prefixed_Name(rico, "hasDraft") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is end date of' object property."</para>
    /// labels<para>"has end date "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasEndDate">https://www.ica.org/standards/RiC/ontology#hasEndDate</seealso>
    let hasEndDate = Prefixed_Name(rico, "hasEndDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasEventType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Event to an Event Type which categorizes
    ///             it."</para>
    /// labels<para>"has event type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasEventType">https://www.ica.org/standards/RiC/ontology#hasEventType</seealso>
    let hasEventType = Prefixed_Name(rico, "hasEventType") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource or Instantiation to an Extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has extent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasExtent">https://www.ica.org/standards/RiC/ontology#hasExtent</seealso>
    let hasExtent = Prefixed_Name(rico, "hasExtent") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasExtentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Extent to an Extent Type that categorizes what is being
    ///             measured."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has extent type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasExtentType">https://www.ica.org/standards/RiC/ontology#hasExtentType</seealso>
    let hasExtentType = Prefixed_Name(rico, "hasExtentType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasFamilyAssociationWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Connects two Persons that have some type of family link, i.e.
    ///             belong to the same family. This relation is symmetric."</para>
    /// labels<para>"has family association with"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasFamilyAssociationWith">https://www.ica.org/standards/RiC/ontology#hasFamilyAssociationWith</seealso>
    let hasFamilyAssociationWith =
        Prefixed_Name(rico, "hasFamilyAssociationWith") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasFamilyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Family to a Family Type that categorizes
    ///             it."</para>
    /// labels<para>"has family type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasFamilyType">https://www.ica.org/standards/RiC/ontology#hasFamilyType</seealso>
    let hasFamilyType = Prefixed_Name(rico, "hasFamilyType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasGeneticLinkToRecordResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Connects two Record Resources when there is a genetic link
    ///             between them. Genetic in this sense is as defined by diplomatics, i.e. the process by
    ///             which a Record Resource is developed. This relation is symmetric."</para>
    /// labels<para>"has genetic link to record resource "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasGeneticLinkToRecordResource">https://www.ica.org/standards/RiC/ontology#hasGeneticLinkToRecordResource</seealso>
    let hasGeneticLinkToRecordResource =
        Prefixed_Name(rico, "hasGeneticLinkToRecordResource") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Identifier and an Identifier Type that categorizes
    ///             it."</para>
    /// labels<para>"has identifier type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasIdentifierType">https://www.ica.org/standards/RiC/ontology#hasIdentifierType</seealso>
    let hasIdentifierType = Prefixed_Name(rico, "hasIdentifierType") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasInstantiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource to one of its
    ///             Instantiations."</para>
    /// labels<para>"has instantiation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasInstantiation">https://www.ica.org/standards/RiC/ontology#hasInstantiation</seealso>
    let hasInstantiation = Prefixed_Name(rico, "hasInstantiation") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasModificationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is modification date of' object
    ///             property."</para>
    /// labels<para>"has modification date "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasModificationDate">https://www.ica.org/standards/RiC/ontology#hasModificationDate</seealso>
    let hasModificationDate = Prefixed_Name(rico, "hasModificationDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadAgentName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent and (one of) its present or past Agent
    ///             Name."</para>
    /// labels<para>"has or had agent name"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadAgentName">https://www.ica.org/standards/RiC/ontology#hasOrHadAgentName</seealso>
    let hasOrHadAgentName = Prefixed_Name(rico, "hasOrHadAgentName") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadAllMembersWithCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Category (Type) to which all the
    ///             Records or Record Parts that are or were included in the Record Set
    ///             belong."</para>
    /// labels<para>"has or had all members with category"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithCategory">https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithCategory</seealso>
    let hasOrHadAllMembersWithCategory =
        Prefixed_Name(rico, "hasOrHadAllMembersWithCategory") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadAllMembersWithContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Content Type that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set."</para>
    /// labels<para>"has of had all members with content type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithContentType">https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithContentType</seealso>
    let hasOrHadAllMembersWithContentType =
        Prefixed_Name(rico, "hasOrHadAllMembersWithContentType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadAllMembersWithDocumentaryFormType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Documentary Form Type that
    ///             categorizes all the Records or Record Parts that are or were included in the Record
    ///             Set."</para>
    /// labels<para>"has of had all members with documentary form type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithDocumentaryFormType">https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithDocumentaryFormType</seealso>
    let hasOrHadAllMembersWithDocumentaryFormType =
        Prefixed_Name(rico, "hasOrHadAllMembersWithDocumentaryFormType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadAllMembersWithLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Language used by all the Records or
    ///             Record Parts that are or were included in the Record Set."</para>
    /// labels<para>"has of had all members with language"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithLanguage">https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithLanguage</seealso>
    let hasOrHadAllMembersWithLanguage =
        Prefixed_Name(rico, "hasOrHadAllMembersWithLanguage") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadAllMembersWithLegalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Legal Status that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set."</para>
    /// labels<para>"has of had all members with legal status"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithLegalStatus">https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithLegalStatus</seealso>
    let hasOrHadAllMembersWithLegalStatus =
        Prefixed_Name(rico, "hasOrHadAllMembersWithLegalStatus") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadAllMembersWithRecordState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Record State that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set."</para>
    /// labels<para>"has of had all members with record state"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithRecordState">https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithRecordState</seealso>
    let hasOrHadAllMembersWithRecordState =
        Prefixed_Name(rico, "hasOrHadAllMembersWithRecordState") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadAppellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to an Appellation that is or was used for
    ///             designating it."</para>
    /// labels<para>"has or had appellation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadAppellation">https://www.ica.org/standards/RiC/ontology#hasOrHadAppellation</seealso>
    let hasOrHadAppellation = Prefixed_Name(rico, "hasOrHadAppellation") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadAuthorityOver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent to a Thing the Agent has or had authority
    ///             over."</para>
    /// labels<para>"has or had authority over"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadAuthorityOver">https://www.ica.org/standards/RiC/ontology#hasOrHadAuthorityOver</seealso>
    let hasOrHadAuthorityOver =
        Prefixed_Name(rico, "hasOrHadAuthorityOver") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to a Type that categorizes or categorized
    ///             it."</para>
    /// labels<para>"has or had category"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadCategory">https://www.ica.org/standards/RiC/ontology#hasOrHadCategory</seealso>
    let hasOrHadCategory = Prefixed_Name(rico, "hasOrHadCategory") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation to one of its present or past
    ///             component instantiations."</para>
    /// labels<para>"has or had component"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadComponent">https://www.ica.org/standards/RiC/ontology#hasOrHadComponent</seealso>
    let hasOrHadComponent = Prefixed_Name(rico, "hasOrHadComponent") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record to a Record Part that is or was a component of
    ///             that Record."</para>
    /// labels<para>"has or had constituent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadConstituent">https://www.ica.org/standards/RiC/ontology#hasOrHadConstituent</seealso>
    let hasOrHadConstituent = Prefixed_Name(rico, "hasOrHadConstituent") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is or was controller of' object
    ///             property."</para>
    /// labels<para>"has or had controller"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadController">https://www.ica.org/standards/RiC/ontology#hasOrHadController</seealso>
    let hasOrHadController = Prefixed_Name(rico, "hasOrHadController") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Physical Location to its past or present coordinates
    ///             in a reference system."</para>
    /// labels<para>"has coordinates"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadCoordinates">https://www.ica.org/standards/RiC/ontology#hasOrHadCoordinates</seealso>
    let hasOrHadCoordinates = Prefixed_Name(rico, "hasOrHadCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadCorporateBodyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Corporate Body to a Corporate Body Type which
    ///             categorizes or categorized it."</para>
    /// labels<para>"has or had corporate body type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadCorporateBodyType">https://www.ica.org/standards/RiC/ontology#hasOrHadCorporateBodyType</seealso>
    let hasOrHadCorporateBodyType =
        Prefixed_Name(rico, "hasOrHadCorporateBodyType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadCorrespondent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Connects two Persons that correspond or have corresponded with
    ///             each other. This relation is symmetric."</para>
    /// labels<para>"has or had correspondent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadCorrespondent">https://www.ica.org/standards/RiC/ontology#hasOrHadCorrespondent</seealso>
    let hasOrHadCorrespondent =
        Prefixed_Name(rico, "hasOrHadCorrespondent") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadDemographicGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person or a Group to a Demographic Group to which it
    ///             belongs or belonged."</para>
    /// labels<para>"has or had demographic group"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadDemographicGroup">https://www.ica.org/standards/RiC/ontology#hasOrHadDemographicGroup</seealso>
    let hasOrHadDemographicGroup =
        Prefixed_Name(rico, "hasOrHadDemographicGroup") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is or was holder of' object property."</para>
    /// labels<para>"has or had holder"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadHolder">https://www.ica.org/standards/RiC/ontology#hasOrHadHolder</seealso>
    let hasOrHadHolder = Prefixed_Name(rico, "hasOrHadHolder") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to one of its past or present
    ///             Identifiers."</para>
    /// labels<para>"has or had identifier"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadIdentifier">https://www.ica.org/standards/RiC/ontology#hasOrHadIdentifier</seealso>
    let hasOrHadIdentifier = Prefixed_Name(rico, "hasOrHadIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadIntellectualPropertyRightsHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inverse of 'is or was holder of intellectual property rights of'
    ///             object property."</para>
    /// labels<para>"has or had intellectual property rights holder"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadIntellectualPropertyRightsHolder">https://www.ica.org/standards/RiC/ontology#hasOrHadIntellectualPropertyRightsHolder</seealso>
    let hasOrHadIntellectualPropertyRightsHolder =
        Prefixed_Name(rico, "hasOrHadIntellectualPropertyRightsHolder") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is or was jurisdiction of' object
    ///             property."</para>
    /// labels<para>"has or had jurisdiction"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadJurisdiction">https://www.ica.org/standards/RiC/ontology#hasOrHadJurisdiction</seealso>
    let hasOrHadJurisdiction =
        Prefixed_Name(rico, "hasOrHadJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an Agent or Record Resource to a Language that it uses
    ///             or used."</para>
    /// labels<para>"has or had language"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadLanguage">https://www.ica.org/standards/RiC/ontology#hasOrHadLanguage</seealso>
    let hasOrHadLanguage = Prefixed_Name(rico, "hasOrHadLanguage") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is or was leader of' object property."</para>
    /// labels<para>"has or had leader"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadLeader">https://www.ica.org/standards/RiC/ontology#hasOrHadLeader</seealso>
    let hasOrHadLeader = Prefixed_Name(rico, "hasOrHadLeader") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadLegalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent or Record Resource to a Legal Status which
    ///             categorized or categorizes it."</para>
    /// labels<para>"has or had legal status"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadLegalStatus">https://www.ica.org/standards/RiC/ontology#hasOrHadLegalStatus</seealso>
    let hasOrHadLegalStatus = Prefixed_Name(rico, "hasOrHadLegalStatus") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is or was location of' object
    ///             property."</para>
    /// labels<para>"has or had location"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadLocation">https://www.ica.org/standards/RiC/ontology#hasOrHadLocation</seealso>
    let hasOrHadLocation = Prefixed_Name(rico, "hasOrHadLocation") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadMainSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource to a Thing that is or was its main
    ///             subject."</para>
    /// labels<para>"has or had main subject"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadMainSubject">https://www.ica.org/standards/RiC/ontology#hasOrHadMainSubject</seealso>
    let hasOrHadMainSubject = Prefixed_Name(rico, "hasOrHadMainSubject") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is or was manager of' object
    ///             property."</para>
    /// labels<para>"has or had manager"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadManager">https://www.ica.org/standards/RiC/ontology#hasOrHadManager</seealso>
    let hasOrHadManager = Prefixed_Name(rico, "hasOrHadManager") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Group to a Person that is or was a member of that
    ///             Group."</para>
    /// labels<para>"has or had member"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadMember">https://www.ica.org/standards/RiC/ontology#hasOrHadMember</seealso>
    let hasOrHadMember = Prefixed_Name(rico, "hasOrHadMember") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to one of its past or present
    ///             Names."</para>
    /// labels<para>"has or had name"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadName">https://www.ica.org/standards/RiC/ontology#hasOrHadName</seealso>
    let hasOrHadName = Prefixed_Name(rico, "hasOrHadName") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadOccupationOfType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to an Occupation Type that categorized or
    ///             categorizes his/her occupation (profession, trade or craft)."</para>
    /// labels<para>"has or had occupation of type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadOccupationOfType">https://www.ica.org/standards/RiC/ontology#hasOrHadOccupationOfType</seealso>
    let hasOrHadOccupationOfType =
        Prefixed_Name(rico, "hasOrHadOccupationOfType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is or was owner of' object property."</para>
    /// labels<para>"has or had owner"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadOwner">https://www.ica.org/standards/RiC/ontology#hasOrHadOwner</seealso>
    let hasOrHadOwner = Prefixed_Name(rico, "hasOrHadOwner") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to a constitutive or component part of that
    ///             Thing."</para>
    /// labels<para>"has or had part"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadPart">https://www.ica.org/standards/RiC/ontology#hasOrHadPart</seealso>
    let hasOrHadPart = Prefixed_Name(rico, "hasOrHadPart") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Event to a Thing that is or was actively or
    ///             passively involved in it."</para>
    /// labels<para>"has or had participant"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadParticipant">https://www.ica.org/standards/RiC/ontology#hasOrHadParticipant</seealso>
    let hasOrHadParticipant = Prefixed_Name(rico, "hasOrHadParticipant") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadPhysicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place to one of its past or present Physical
    ///             Location."</para>
    /// labels<para>"has or had physical location"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadPhysicalLocation">https://www.ica.org/standards/RiC/ontology#hasOrHadPhysicalLocation</seealso>
    let hasOrHadPhysicalLocation =
        Prefixed_Name(rico, "hasOrHadPhysicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadPlaceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place to one of its past or present
    ///             names."</para>
    /// labels<para>"has or had place name"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadPlaceName">https://www.ica.org/standards/RiC/ontology#hasOrHadPlaceName</seealso>
    let hasOrHadPlaceName = Prefixed_Name(rico, "hasOrHadPlaceName") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadPlaceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place to a Place Type that categorized or categorizes
    ///             it."</para>
    /// labels<para>"has or had place type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadPlaceType">https://www.ica.org/standards/RiC/ontology#hasOrHadPlaceType</seealso>
    let hasOrHadPlaceType = Prefixed_Name(rico, "hasOrHadPlaceType") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'exists or existed in' object
    ///             property."</para>
    /// labels<para>"has or had position"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadPosition">https://www.ica.org/standards/RiC/ontology#hasOrHadPosition</seealso>
    let hasOrHadPosition = Prefixed_Name(rico, "hasOrHadPosition") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadRuleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Rule to a Rule Type that categorized or categorizes
    ///             it."</para>
    /// labels<para>"has or had rule type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadRuleType">https://www.ica.org/standards/RiC/ontology#hasOrHadRuleType</seealso>
    let hasOrHadRuleType = Prefixed_Name(rico, "hasOrHadRuleType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadSomeMembersWithCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Category (Type) to which some of the
    ///             Records or Record Parts that are or were included in the Record Set
    ///             belong."</para>
    /// labels<para>"has or had some members with category"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithCategory">https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithCategory</seealso>
    let hasOrHadSomeMembersWithCategory =
        Prefixed_Name(rico, "hasOrHadSomeMembersWithCategory") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadSomeMembersWithContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Content Type that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set."</para>
    /// labels<para>"has or had some members with content type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithContentType">https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithContentType</seealso>
    let hasOrHadSomeMembersWithContentType =
        Prefixed_Name(rico, "hasOrHadSomeMembersWithContentType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadSomeMembersWithLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Language used by some of the Records
    ///             or Record Parts that are or were included in the Record Set."</para>
    /// labels<para>"has or had some members with language"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithLanguage">https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithLanguage</seealso>
    let hasOrHadSomeMembersWithLanguage =
        Prefixed_Name(rico, "hasOrHadSomeMembersWithLanguage") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadSomeMembersWithLegalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Legal Status that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set."</para>
    /// labels<para>"has or had some members with legal status"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithLegalStatus">https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithLegalStatus</seealso>
    let hasOrHadSomeMembersWithLegalStatus =
        Prefixed_Name(rico, "hasOrHadSomeMembersWithLegalStatus") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadSomeMembersWithRecordState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Record State that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set."</para>
    /// labels<para>"has or had some members with record state"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithRecordState">https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithRecordState</seealso>
    let hasOrHadSomeMembersWithRecordState =
        Prefixed_Name(rico, "hasOrHadSomeMembersWithRecordState") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadSomeMemberswithDocumentaryFormType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set and a Documentary Form Type that
    ///             categorizes some of the Records or Record Parts that are or were included in the Record
    ///             Set."</para>
    /// labels<para>"has or had some members with documentary form type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMemberswithDocumentaryFormType">https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMemberswithDocumentaryFormType</seealso>
    let hasOrHadSomeMemberswithDocumentaryFormType =
        Prefixed_Name(rico, "hasOrHadSomeMemberswithDocumentaryFormType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadSpouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects two Persons that are or were married. This relation is
    ///             symmetric."</para>
    /// labels<para>"has or had spouse"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSpouse">https://www.ica.org/standards/RiC/ontology#hasOrHadSpouse</seealso>
    let hasOrHadSpouse = Prefixed_Name(rico, "hasOrHadSpouse") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadStudent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had teacher' object property."</para>
    /// labels<para>"has or had student"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadStudent">https://www.ica.org/standards/RiC/ontology#hasOrHadStudent</seealso>
    let hasOrHadStudent = Prefixed_Name(rico, "hasOrHadStudent") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadSubdivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Group to one of its present or past
    ///             subdivisions."</para>
    /// labels<para>"has or had subdivision"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubdivision">https://www.ica.org/standards/RiC/ontology#hasOrHadSubdivision</seealso>
    let hasOrHadSubdivision = Prefixed_Name(rico, "hasOrHadSubdivision") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadSubevent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Event to one of a series of Events that constitute
    ///             the original, broader, past or ongoing Event."</para>
    /// labels<para>"has or had subevent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubevent">https://www.ica.org/standards/RiC/ontology#hasOrHadSubevent</seealso>
    let hasOrHadSubevent = Prefixed_Name(rico, "hasOrHadSubevent") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource to a Thing that is or was its
    ///             subject."</para>
    /// labels<para>"has or had subject"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubject">https://www.ica.org/standards/RiC/ontology#hasOrHadSubject</seealso>
    let hasOrHadSubject = Prefixed_Name(rico, "hasOrHadSubject") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadSubordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent to an Agent that is hierarchically
    ///             inferior."</para>
    /// labels<para>"has or had subordinate"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubordinate">https://www.ica.org/standards/RiC/ontology#hasOrHadSubordinate</seealso>
    let hasOrHadSubordinate = Prefixed_Name(rico, "hasOrHadSubordinate") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadTeacher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to another Person who is or was their
    ///             student."</para>
    /// labels<para>"has or had teacher"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadTeacher">https://www.ica.org/standards/RiC/ontology#hasOrHadTeacher</seealso>
    let hasOrHadTeacher = Prefixed_Name(rico, "hasOrHadTeacher") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasOrHadTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource, Instantiation or Rule to a title
    ///             that is or was used for designating it."</para>
    /// labels<para>"has or had title"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadTitle">https://www.ica.org/standards/RiC/ontology#hasOrHadTitle</seealso>
    let hasOrHadTitle = Prefixed_Name(rico, "hasOrHadTitle") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOrHadWorkRelationWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects two Agents that have or had some type of work relation
    ///             in the course of their activities. This relation is symmetric."</para>
    /// labels<para>"has or had work relation with"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOrHadWorkRelationWith">https://www.ica.org/standards/RiC/ontology#hasOrHadWorkRelationWith</seealso>
    let hasOrHadWorkRelationWith =
        Prefixed_Name(rico, "hasOrHadWorkRelationWith") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasOriginal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inverse of 'is original of' object property."</para>
    /// labels<para>"has original "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasOriginal">https://www.ica.org/standards/RiC/ontology#hasOriginal</seealso>
    let hasOriginal = Prefixed_Name(rico, "hasOriginal") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasProductionTechniqueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation to a Production Technique Type that
    ///             categorizes its production technique."</para>
    /// labels<para>"has production technique type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasProductionTechniqueType">https://www.ica.org/standards/RiC/ontology#hasProductionTechniqueType</seealso>
    let hasProductionTechniqueType =
        Prefixed_Name(rico, "hasProductionTechniqueType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource or an Instantiation to an Agent that
    ///             creates or accumulates the Record Resource, receives it, or sends it."</para>
    /// labels<para>"has provenance "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasProvenance">https://www.ica.org/standards/RiC/ontology#hasProvenance</seealso>
    let hasProvenance = Prefixed_Name(rico, "hasProvenance") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record resource to an Agent who published
    ///             it."</para>
    /// labels<para>"hasPublisher"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasPublisher">https://www.ica.org/standards/RiC/ontology#hasPublisher</seealso>
    let hasPublisher = Prefixed_Name(rico, "hasPublisher") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasReceiver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource or an Instantiation to the Agent that
    ///             receives it in the course of its activities."</para>
    /// labels<para>"has receiver"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasReceiver">https://www.ica.org/standards/RiC/ontology#hasReceiver</seealso>
    let hasReceiver = Prefixed_Name(rico, "hasReceiver") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasRecordSetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set to a Record Set Type that categorizes
    ///             it."</para>
    /// labels<para>"has record set type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasRecordSetType">https://www.ica.org/standards/RiC/ontology#hasRecordSetType</seealso>
    let hasRecordSetType = Prefixed_Name(rico, "hasRecordSetType") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasRecordState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record or Record Part to a Record State that
    ///             categorizes its state."</para>
    /// labels<para>"has record state"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasRecordState">https://www.ica.org/standards/RiC/ontology#hasRecordState</seealso>
    let hasRecordState = Prefixed_Name(rico, "hasRecordState") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasReply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource to a reply, usually in the form of
    ///             correspondence."</para>
    /// labels<para>"has reply"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasReply">https://www.ica.org/standards/RiC/ontology#hasReply</seealso>
    let hasReply = Prefixed_Name(rico, "hasReply") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasRepresentationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation to a Representation Type that
    ///             categorizes its representation type."</para>
    /// labels<para>"has representation type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasRepresentationType">https://www.ica.org/standards/RiC/ontology#hasRepresentationType</seealso>
    let hasRepresentationType =
        Prefixed_Name(rico, "hasRepresentationType") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasSender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource or an Instantiation to the Agent that
    ///             sends it"</para>
    /// labels<para>"has sender "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasSender">https://www.ica.org/standards/RiC/ontology#hasSender</seealso>
    let hasSender = Prefixed_Name(rico, "hasSender") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasSibling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Connects two Persons that are siblings. This relation is
    ///             symmetric."</para>
    /// labels<para>"has sibling"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasSibling">https://www.ica.org/standards/RiC/ontology#hasSibling</seealso>
    let hasSibling = Prefixed_Name(rico, "hasSibling") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource or Relation to a Record Resource or
    ///             Agent that is used as a source of information for identifying or describing
    ///             it."</para>
    /// labels<para>"has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasSource">https://www.ica.org/standards/RiC/ontology#hasSource</seealso>
    let hasSource = Prefixed_Name(rico, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>rico:hasSuccessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent to another Agent that succeeds it
    ///             chronologically."</para>
    /// labels<para>"has successor"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasSuccessor">https://www.ica.org/standards/RiC/ontology#hasSuccessor</seealso>
    let hasSuccessor = Prefixed_Name(rico, "hasSuccessor") |> PrefixedName

    /// <summary>
    ///   <para>rico:hasUnitOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Extent to a Unit Of Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has unit of measurement"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#hasUnitOfMeasurement">https://www.ica.org/standards/RiC/ontology#hasUnitOfMeasurement</seealso>
    let hasUnitOfMeasurement =
        Prefixed_Name(rico, "hasUnitOfMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>rico:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Vertical dimension of an entity."</para>
    /// labels<para>"height"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#height">https://www.ica.org/standards/RiC/ontology#height</seealso>
    let height = Prefixed_Name(rico, "height") |> PrefixedName
    /// <summary>
    ///   <para>rico:history</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Summary of the development of an entity, since its origin until
    ///             present time."</para>
    /// labels<para>"history"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#history">https://www.ica.org/standards/RiC/ontology#history</seealso>
    let history = Prefixed_Name(rico, "history") |> PrefixedName
    /// <summary>
    ///   <para>rico:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A word, number, letter, symbol, or any combination of these used
    ///             to uniquely identify or reference an individual instance of an entity within a specific
    ///             information domain. Includes Global Persistent Identifiers (globally unique and
    ///             persistently resolvable identifier for the entity) and/or Local
    ///             Identifiers."</para>
    /// labels<para>"identifier"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#identifier">https://www.ica.org/standards/RiC/ontology#identifier</seealso>
    let identifier = Prefixed_Name(rico, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>rico:includesOrIncluded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Set to a Record or Record Set it aggregates,
    ///             or aggregated in the past."</para>
    /// labels<para>"includes or included"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#includesOrIncluded">https://www.ica.org/standards/RiC/ontology#includesOrIncluded</seealso>
    let includesOrIncluded = Prefixed_Name(rico, "includesOrIncluded") |> PrefixedName
    /// <summary>
    ///   <para>rico:instantiationExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Countable characteristics of the Instantiation expressed as a
    ///             quantity."</para>
    /// labels<para>"Instantiation extent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#instantiationExtent">https://www.ica.org/standards/RiC/ontology#instantiationExtent</seealso>
    let instantiationExtent = Prefixed_Name(rico, "instantiationExtent") |> PrefixedName

    /// <summary>
    ///   <para>rico:instantiationIsConnectedToFunctionalEquivalenceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation to a Functional Equivalence
    ///             Relation"</para>
    /// labels<para>"instantiation is connected to functional equivalence relation
    ///         "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#instantiationIsConnectedToFunctionalEquivalenceRelation">https://www.ica.org/standards/RiC/ontology#instantiationIsConnectedToFunctionalEquivalenceRelation</seealso>
    let instantiationIsConnectedToFunctionalEquivalenceRelation =
        Prefixed_Name(rico, "instantiationIsConnectedToFunctionalEquivalenceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:instantiationIsConnectedToInstantiationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation to an Instantiation to Instantiation
    ///             Relation."</para>
    /// labels<para>"instantiation is connected to instantiation relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#instantiationIsConnectedToInstantiationRelation">https://www.ica.org/standards/RiC/ontology#instantiationIsConnectedToInstantiationRelation</seealso>
    let instantiationIsConnectedToInstantiationRelation =
        Prefixed_Name(rico, "instantiationIsConnectedToInstantiationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:instantiationIsSourceOfDerivationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation (from which at least one Instantiation
    ///             is derived) to a Derivation Relation."</para>
    /// labels<para>"instantiation is source of derivation relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#instantiationIsSourceOfDerivationRelation">https://www.ica.org/standards/RiC/ontology#instantiationIsSourceOfDerivationRelation</seealso>
    let instantiationIsSourceOfDerivationRelation =
        Prefixed_Name(rico, "instantiationIsSourceOfDerivationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:instantiationIsSourceOfMigrationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation (from which at least one Instantiation
    ///             is migrated) to a Migration Relation."</para>
    /// labels<para>"instantiation is source of migration relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#instantiationIsSourceOfMigrationRelation">https://www.ica.org/standards/RiC/ontology#instantiationIsSourceOfMigrationRelation</seealso>
    let instantiationIsSourceOfMigrationRelation =
        Prefixed_Name(rico, "instantiationIsSourceOfMigrationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:instantiationIsTargetOfDerivationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a derived Instantiation to a Derivation
    ///             Relation."</para>
    /// labels<para>"instantiation is target of derivation relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfDerivationRelation">https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfDerivationRelation</seealso>
    let instantiationIsTargetOfDerivationRelation =
        Prefixed_Name(rico, "instantiationIsTargetOfDerivationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:instantiationIsTargetOfMigrationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation which results from a migration, to a
    ///             Migration Relation."</para>
    /// labels<para>"instantiation is target of migration relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfMigrationRelation">https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfMigrationRelation</seealso>
    let instantiationIsTargetOfMigrationRelation =
        Prefixed_Name(rico, "instantiationIsTargetOfMigrationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:instantiationIsTargetOfRecordResourceToInstantiationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation of a Record Resource to the Record
    ///             Resource to Instantiation Relation."</para>
    /// labels<para>"instantiation is target of record resource to instantiation
    ///             relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfRecordResourceToInstantiationRelation">https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfRecordResourceToInstantiationRelation</seealso>
    let instantiationIsTargetOfRecordResourceToInstantiationRelation =
        Prefixed_Name(rico, "instantiationIsTargetOfRecordResourceToInstantiationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:instantiationStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information about the physical arrangement and composition of an
    ///             Instantiation."</para>
    /// labels<para>"Instantiation structure"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#instantiationStructure">https://www.ica.org/standards/RiC/ontology#instantiationStructure</seealso>
    let instantiationStructure =
        Prefixed_Name(rico, "instantiationStructure") |> PrefixedName

    /// <summary>
    ///   <para>rico:instantiationToInstantiationRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation to Instantiation Relation to one of
    ///             the related Instantiations."</para>
    /// labels<para>"instantiation to instantiation relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#instantiationToInstantiationRelationConnects">https://www.ica.org/standards/RiC/ontology#instantiationToInstantiationRelationConnects</seealso>
    let instantiationToInstantiationRelationConnects =
        Prefixed_Name(rico, "instantiationToInstantiationRelationConnects") |> PrefixedName

    /// <summary>
    ///   <para>rico:integrity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information about the completeness of a Record Resource or
    ///             Instantiation."</para>
    /// labels<para>"integrity"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#integrity">https://www.ica.org/standards/RiC/ontology#integrity</seealso>
    let integrity = Prefixed_Name(rico, "integrity") |> PrefixedName

    /// <summary>
    ///   <para>rico:intellectualPropertyRightsRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an IntellectualPropertyRightsRelation to one of the
    ///             Group, Person or Position that holds the rights."</para>
    /// labels<para>"intellectual property rights relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#intellectualPropertyRightsRelationHasSource">https://www.ica.org/standards/RiC/ontology#intellectualPropertyRightsRelationHasSource</seealso>
    let intellectualPropertyRightsRelationHasSource =
        Prefixed_Name(rico, "intellectualPropertyRightsRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:intellectualPropertyRightsRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an IintellectualPropertyRightsRelation to one of the
    ///             Record Resource or Instantiation on which the rights are held."</para>
    /// labels<para>"intellectual property rights relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#intellectualPropertyRightsRelationHasTarget">https://www.ica.org/standards/RiC/ontology#intellectualPropertyRightsRelationHasTarget</seealso>
    let intellectualPropertyRightsRelationHasTarget =
        Prefixed_Name(rico, "intellectualPropertyRightsRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:isAccumulatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has accumulator' object property."</para>
    /// labels<para>"is accumulator of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isAccumulatorOf">https://www.ica.org/standards/RiC/ontology#isAccumulatorOf</seealso>
    let isAccumulatorOf = Prefixed_Name(rico, "isAccumulatorOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isActivityTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Activity Type to an Activity that it
    ///             categorizes."</para>
    /// labels<para>"is activity type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isActivityTypeOf">https://www.ica.org/standards/RiC/ontology#isActivityTypeOf</seealso>
    let isActivityTypeOf = Prefixed_Name(rico, "isActivityTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isAddresseeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inverse of 'has addressee' object property."</para>
    /// labels<para>"is addressee of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isAddresseeOf">https://www.ica.org/standards/RiC/ontology#isAddresseeOf</seealso>
    let isAddresseeOf = Prefixed_Name(rico, "isAddresseeOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isAgentAssociatedWithAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Connects two Agents. This object property is
    ///             symmetric."</para>
    /// labels<para>"is agent associated with agent "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isAgentAssociatedWithAgent">https://www.ica.org/standards/RiC/ontology#isAgentAssociatedWithAgent</seealso>
    let isAgentAssociatedWithAgent =
        Prefixed_Name(rico, "isAgentAssociatedWithAgent") |> PrefixedName

    /// <summary>
    ///   <para>rico:isAssociatedWithDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is date associated with' object
    ///             property."</para>
    /// labels<para>"is associated with date "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithDate">https://www.ica.org/standards/RiC/ontology#isAssociatedWithDate</seealso>
    let isAssociatedWithDate =
        Prefixed_Name(rico, "isAssociatedWithDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:isAssociatedWithEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is event associated with' object
    ///             property."</para>
    /// labels<para>"is associated with event "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithEvent">https://www.ica.org/standards/RiC/ontology#isAssociatedWithEvent</seealso>
    let isAssociatedWithEvent =
        Prefixed_Name(rico, "isAssociatedWithEvent") |> PrefixedName

    /// <summary>
    ///   <para>rico:isAssociatedWithPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is place associated with' object
    ///             property."</para>
    /// labels<para>"is associated with place "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithPlace">https://www.ica.org/standards/RiC/ontology#isAssociatedWithPlace</seealso>
    let isAssociatedWithPlace =
        Prefixed_Name(rico, "isAssociatedWithPlace") |> PrefixedName

    /// <summary>
    ///   <para>rico:isAssociatedWithRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is rule associated with' object
    ///             property."</para>
    /// labels<para>"is associated with rule "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithRule">https://www.ica.org/standards/RiC/ontology#isAssociatedWithRule</seealso>
    let isAssociatedWithRule =
        Prefixed_Name(rico, "isAssociatedWithRule") |> PrefixedName

    /// <summary>
    ///   <para>rico:isAuthorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inverse of 'has author' object property."</para>
    /// labels<para>"is author of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isAuthorOf">https://www.ica.org/standards/RiC/ontology#isAuthorOf</seealso>
    let isAuthorOf = Prefixed_Name(rico, "isAuthorOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isAuthorizingAgentInMandateRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent that assigns the Mandate, to a Mandate
    ///             Relation."</para>
    /// labels<para>"is authorizing agent in mandate relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isAuthorizingAgentInMandateRelation">https://www.ica.org/standards/RiC/ontology#isAuthorizingAgentInMandateRelation</seealso>
    let isAuthorizingAgentInMandateRelation =
        Prefixed_Name(rico, "isAuthorizingAgentInMandateRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:isBeginningDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Date to a Thing that came into existence on that
    ///             Date."</para>
    /// labels<para>"is beginning date of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isBeginningDateOf">https://www.ica.org/standards/RiC/ontology#isBeginningDateOf</seealso>
    let isBeginningDateOf = Prefixed_Name(rico, "isBeginningDateOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isBirthDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Date to a Person that was born on that
    ///             Date."</para>
    /// labels<para>"is birth date of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isBirthDateOf">https://www.ica.org/standards/RiC/ontology#isBirthDateOf</seealso>
    let isBirthDateOf = Prefixed_Name(rico, "isBirthDateOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isCarrierTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Carrier Type to an Instantiation whose carrier it
    ///             categorizes."</para>
    /// labels<para>"is carrier type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isCarrierTypeOf">https://www.ica.org/standards/RiC/ontology#isCarrierTypeOf</seealso>
    let isCarrierTypeOf = Prefixed_Name(rico, "isCarrierTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isChildOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has child' object property."</para>
    /// labels<para>"is child of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isChildOf">https://www.ica.org/standards/RiC/ontology#isChildOf</seealso>
    let isChildOf = Prefixed_Name(rico, "isChildOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isCollectorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inverse of 'has collector' object property."</para>
    /// labels<para>"is collector of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isCollectorOf">https://www.ica.org/standards/RiC/ontology#isCollectorOf</seealso>
    let isCollectorOf = Prefixed_Name(rico, "isCollectorOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isContentTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Content Type to a Record or Record Part whose content
    ///             it categorizes."</para>
    /// labels<para>"is content type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isContentTypeOf">https://www.ica.org/standards/RiC/ontology#isContentTypeOf</seealso>
    let isContentTypeOf = Prefixed_Name(rico, "isContentTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isCopyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has copy' object property."</para>
    /// labels<para>"is copy of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isCopyOf">https://www.ica.org/standards/RiC/ontology#isCopyOf</seealso>
    let isCopyOf = Prefixed_Name(rico, "isCopyOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isCreatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has creator' object property."</para>
    /// labels<para>"is creator of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isCreatorOf">https://www.ica.org/standards/RiC/ontology#isCreatorOf</seealso>
    let isCreatorOf = Prefixed_Name(rico, "isCreatorOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isDateAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Date to a Thing that the Date is associated with the
    ///             existence and lifecycle of."</para>
    /// labels<para>"is date associated with "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isDateAssociatedWith">https://www.ica.org/standards/RiC/ontology#isDateAssociatedWith</seealso>
    let isDateAssociatedWith =
        Prefixed_Name(rico, "isDateAssociatedWith") |> PrefixedName

    /// <summary>
    ///   <para>rico:isDeathDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Date to a Person who died on that
    ///             Date."</para>
    /// labels<para>"is death date of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isDeathDateOf">https://www.ica.org/standards/RiC/ontology#isDeathDateOf</seealso>
    let isDeathDateOf = Prefixed_Name(rico, "isDeathDateOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isDerivedFromInstantiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has derived instantiation' object
    ///             property."</para>
    /// labels<para>"is derived from instantiation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isDerivedFromInstantiation">https://www.ica.org/standards/RiC/ontology#isDerivedFromInstantiation</seealso>
    let isDerivedFromInstantiation =
        Prefixed_Name(rico, "isDerivedFromInstantiation") |> PrefixedName

    /// <summary>
    ///   <para>rico:isDocumentaryFormTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Documentary Form Type to a Record or Record Part that
    ///             it categorizes."</para>
    /// labels<para>"is documentary form type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isDocumentaryFormTypeOf">https://www.ica.org/standards/RiC/ontology#isDocumentaryFormTypeOf</seealso>
    let isDocumentaryFormTypeOf =
        Prefixed_Name(rico, "isDocumentaryFormTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isDraftOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a draft to the final version of a
    ///             Record."</para>
    /// labels<para>"is draft of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isDraftOf">https://www.ica.org/standards/RiC/ontology#isDraftOf</seealso>
    let isDraftOf = Prefixed_Name(rico, "isDraftOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isEndDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Date to a Thing whose existence ended on that
    ///             Date."</para>
    /// labels<para>"is end date of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isEndDateOf">https://www.ica.org/standards/RiC/ontology#isEndDateOf</seealso>
    let isEndDateOf = Prefixed_Name(rico, "isEndDateOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isEquivalentTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects two Things that are considered
    ///             equivalent."</para>
    /// labels<para>"is equivalent to "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isEquivalentTo">https://www.ica.org/standards/RiC/ontology#isEquivalentTo</seealso>
    let isEquivalentTo = Prefixed_Name(rico, "isEquivalentTo") |> PrefixedName

    /// <summary>
    ///   <para>rico:isEventAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Event to a Thing that is associated with the
    ///             existence and lifecycle of the Event."</para>
    /// labels<para>"is event associated with "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isEventAssociatedWith">https://www.ica.org/standards/RiC/ontology#isEventAssociatedWith</seealso>
    let isEventAssociatedWith =
        Prefixed_Name(rico, "isEventAssociatedWith") |> PrefixedName

    /// <summary>
    ///   <para>rico:isEventTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Event Type to an Event that is
    ///             categorizes."</para>
    /// labels<para>"is event type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isEventTypeOf">https://www.ica.org/standards/RiC/ontology#isEventTypeOf</seealso>
    let isEventTypeOf = Prefixed_Name(rico, "isEventTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isExtentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an Extent to a Record Resource or Instantiation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is extent of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isExtentOf">https://www.ica.org/standards/RiC/ontology#isExtentOf</seealso>
    let isExtentOf = Prefixed_Name(rico, "isExtentOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isExtentTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Extent Type to an Extent that it
    ///             categorizes."</para>
    /// labels<para>"is extent type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isExtentTypeOf">https://www.ica.org/standards/RiC/ontology#isExtentTypeOf</seealso>
    let isExtentTypeOf = Prefixed_Name(rico, "isExtentTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isFamilyTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Family Type to a Family that is
    ///             categorizes."</para>
    /// labels<para>"is family type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isFamilyTypeOf">https://www.ica.org/standards/RiC/ontology#isFamilyTypeOf</seealso>
    let isFamilyTypeOf = Prefixed_Name(rico, "isFamilyTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isFromUseDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Date to an Appellation, when it is the date at which
    ///             the Appellation was first used."</para>
    /// labels<para>"is from use date of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isFromUseDateOf">https://www.ica.org/standards/RiC/ontology#isFromUseDateOf</seealso>
    let isFromUseDateOf = Prefixed_Name(rico, "isFromUseDateOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isFunctionallyEquivalentTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Connects two Instantiations which may be considered as
    ///             equivalent. This relation is symmetric."</para>
    /// labels<para>"is functionally equivalent to"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isFunctionallyEquivalentTo">https://www.ica.org/standards/RiC/ontology#isFunctionallyEquivalentTo</seealso>
    let isFunctionallyEquivalentTo =
        Prefixed_Name(rico, "isFunctionallyEquivalentTo") |> PrefixedName

    /// <summary>
    ///   <para>rico:isIdentifierTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Identifier Type and an Identifier that it
    ///             categorizes."</para>
    /// labels<para>"is identifier type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isIdentifierTypeOf">https://www.ica.org/standards/RiC/ontology#isIdentifierTypeOf</seealso>
    let isIdentifierTypeOf = Prefixed_Name(rico, "isIdentifierTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isInstantiationAssociatedWithInstantiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Connects two Instantiations. This object property is
    ///             symmetric."</para>
    /// labels<para>"is instantiation associated with instantiation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isInstantiationAssociatedWithInstantiation">https://www.ica.org/standards/RiC/ontology#isInstantiationAssociatedWithInstantiation</seealso>
    let isInstantiationAssociatedWithInstantiation =
        Prefixed_Name(rico, "isInstantiationAssociatedWithInstantiation") |> PrefixedName

    /// <summary>
    ///   <para>rico:isInstantiationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has instantiation' object property."</para>
    /// labels<para>"is instantiation of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isInstantiationOf">https://www.ica.org/standards/RiC/ontology#isInstantiationOf</seealso>
    let isInstantiationOf = Prefixed_Name(rico, "isInstantiationOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isLastUpdateDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Date and a Thing that was last modified at this
    ///             Date."</para>
    /// labels<para>"is last update date of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isLastUpdateDateOf">https://www.ica.org/standards/RiC/ontology#isLastUpdateDateOf</seealso>
    let isLastUpdateDateOf = Prefixed_Name(rico, "isLastUpdateDateOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isModificationDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Date to a Thing that was modified on that
    ///             Date."</para>
    /// labels<para>"is modification date of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isModificationDateOf">https://www.ica.org/standards/RiC/ontology#isModificationDateOf</seealso>
    let isModificationDateOf =
        Prefixed_Name(rico, "isModificationDateOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasAdjacentTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Connects two Places that are or were geographically adjacent.
    ///             This is a symmetric object property."</para>
    /// labels<para>"is or was adjacent to"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasAdjacentTo">https://www.ica.org/standards/RiC/ontology#isOrWasAdjacentTo</seealso>
    let isOrWasAdjacentTo = Prefixed_Name(rico, "isOrWasAdjacentTo") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasAffectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'affects or affected' object property."</para>
    /// labels<para>"is or was affected by"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasAffectedBy">https://www.ica.org/standards/RiC/ontology#isOrWasAffectedBy</seealso>
    let isOrWasAffectedBy = Prefixed_Name(rico, "isOrWasAffectedBy") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasAgentNameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent Name to an Agent it designates or
    ///             designated."</para>
    /// labels<para>"is or was agent name of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasAgentNameOf">https://www.ica.org/standards/RiC/ontology#isOrWasAgentNameOf</seealso>
    let isOrWasAgentNameOf = Prefixed_Name(rico, "isOrWasAgentNameOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasAppellationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Appellation to a Thing that it designates or
    ///             designated."</para>
    /// labels<para>"is or was appellation of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasAppellationOf">https://www.ica.org/standards/RiC/ontology#isOrWasAppellationOf</seealso>
    let isOrWasAppellationOf =
        Prefixed_Name(rico, "isOrWasAppellationOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Type (a category) to a Thing that it categorizes or
    ///             categorized."</para>
    /// labels<para>"is or was category of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOf">https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOf</seealso>
    let isOrWasCategoryOf = Prefixed_Name(rico, "isOrWasCategoryOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasCategoryOfAllMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Category (Type) and a Record Set whose all present or
    ///             past Record or Record Part members belong to that Category."</para>
    /// labels<para>"is or was category of all members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOfAllMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOfAllMembersOf</seealso>
    let isOrWasCategoryOfAllMembersOf =
        Prefixed_Name(rico, "isOrWasCategoryOfAllMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasCategoryOfSomeMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Category (Type) and a Record Set whose some present
    ///             or past Record or Record Part members belong to that Category."</para>
    /// labels<para>"is or was category of some members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOfSomeMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOfSomeMembersOf</seealso>
    let isOrWasCategoryOfSomeMembersOf =
        Prefixed_Name(rico, "isOrWasCategoryOfSomeMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had component' object
    ///             property."</para>
    /// labels<para>"is or was component of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasComponentOf">https://www.ica.org/standards/RiC/ontology#isOrWasComponentOf</seealso>
    let isOrWasComponentOf = Prefixed_Name(rico, "isOrWasComponentOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasConstituentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had constituent' object
    ///             property."</para>
    /// labels<para>"is or was constituent of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasConstituentOf">https://www.ica.org/standards/RiC/ontology#isOrWasConstituentOf</seealso>
    let isOrWasConstituentOf =
        Prefixed_Name(rico, "isOrWasConstituentOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasContainedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'contains or contained' object
    ///             property."</para>
    /// labels<para>"is or was contained by"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasContainedBy">https://www.ica.org/standards/RiC/ontology#isOrWasContainedBy</seealso>
    let isOrWasContainedBy = Prefixed_Name(rico, "isOrWasContainedBy") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasContentTypeOfAllMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Content Type and a Record Set whose all past or
    ///             present Record or Record Part members have that Content Type."</para>
    /// labels<para>"is or was content type of all members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasContentTypeOfAllMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasContentTypeOfAllMembersOf</seealso>
    let isOrWasContentTypeOfAllMembersOf =
        Prefixed_Name(rico, "isOrWasContentTypeOfAllMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasContentTypeOfSomeMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Content Type and a Record Set whose some past or
    ///             present Record or Record Part members have that Content Type."</para>
    /// labels<para>"is or was content type of some members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasContentTypeOfSomeMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasContentTypeOfSomeMembersOf</seealso>
    let isOrWasContentTypeOfSomeMembersOf =
        Prefixed_Name(rico, "isOrWasContentTypeOfSomeMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasControllerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent to another Agent it controls or controlled via
    ///             Activities, i.e. controls by function."</para>
    /// labels<para>"is or was controller of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasControllerOf">https://www.ica.org/standards/RiC/ontology#isOrWasControllerOf</seealso>
    let isOrWasControllerOf = Prefixed_Name(rico, "isOrWasControllerOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasCoordinatesOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an instance of Coordinates to a Physical Location it
    ///             locates or located on earth, according to some reference system."</para>
    /// labels<para>"is or was coordinates of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasCoordinatesOf">https://www.ica.org/standards/RiC/ontology#isOrWasCoordinatesOf</seealso>
    let isOrWasCoordinatesOf =
        Prefixed_Name(rico, "isOrWasCoordinatesOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasCorporateBodyTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Corporate Body Type to a Corporate Body that it
    ///             categorizes or categorized."</para>
    /// labels<para>"is or was corporate body type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasCorporateBodyTypeOf">https://www.ica.org/standards/RiC/ontology#isOrWasCorporateBodyTypeOf</seealso>
    let isOrWasCorporateBodyTypeOf =
        Prefixed_Name(rico, "isOrWasCorporateBodyTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasDemographicGroupOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Demographic Group to a Person or Group which belongs
    ///             or belonged to it."</para>
    /// labels<para>"is or was demographic group of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasDemographicGroupOf">https://www.ica.org/standards/RiC/ontology#isOrWasDemographicGroupOf</seealso>
    let isOrWasDemographicGroupOf =
        Prefixed_Name(rico, "isOrWasDemographicGroupOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'describes or described' object
    ///             property."</para>
    /// labels<para>"is or was described by"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasDescribedBy">https://www.ica.org/standards/RiC/ontology#isOrWasDescribedBy</seealso>
    let isOrWasDescribedBy = Prefixed_Name(rico, "isOrWasDescribedBy") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasDocumentaryFormTypeOfAllMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Documentary Form Type and a Record Set whose all past
    ///             or present Record or Record Part members have that Documentary Form Type."</para>
    /// labels<para>"is or was documentary form type of all members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasDocumentaryFormTypeOfAllMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasDocumentaryFormTypeOfAllMembersOf</seealso>
    let isOrWasDocumentaryFormTypeOfAllMembersOf =
        Prefixed_Name(rico, "isOrWasDocumentaryFormTypeOfAllMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasDocumentaryFormTypeOfSomeMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Documentary Form Type and a Record Set whose some
    ///             past or present Record or Record Part members have that Documentary Form
    ///             Type."</para>
    /// labels<para>"is or was documentary form type of some members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasDocumentaryFormTypeOfSomeMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasDocumentaryFormTypeOfSomeMembersOf</seealso>
    let isOrWasDocumentaryFormTypeOfSomeMembersOf =
        Prefixed_Name(rico, "isOrWasDocumentaryFormTypeOfSomeMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasEnforcedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Rule to an Agent that enforces or enforced the
    ///             Rule."</para>
    /// labels<para>"is or was enforced by"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasEnforcedBy">https://www.ica.org/standards/RiC/ontology#isOrWasEnforcedBy</seealso>
    let isOrWasEnforcedBy = Prefixed_Name(rico, "isOrWasEnforcedBy") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasExpressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Rule to a Record Resource that expresses or expressed
    ///             the Rule."</para>
    /// labels<para>"is or was expressed by"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasExpressedBy">https://www.ica.org/standards/RiC/ontology#isOrWasExpressedBy</seealso>
    let isOrWasExpressedBy = Prefixed_Name(rico, "isOrWasExpressedBy") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasHolderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects an Agent to a Record Resource or Instantiation that the
    ///             Agent holds or held."</para>
    /// labels<para>"is or was holder of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasHolderOf">https://www.ica.org/standards/RiC/ontology#isOrWasHolderOf</seealso>
    let isOrWasHolderOf = Prefixed_Name(rico, "isOrWasHolderOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasHolderOfIntellectualPropertyRightsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent to a Record Resource or Instantiation on which
    ///             the Agent has or had some intellectual property rights."</para>
    /// labels<para>"is or was holder of intellectual property rights of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasHolderOfIntellectualPropertyRightsOf">https://www.ica.org/standards/RiC/ontology#isOrWasHolderOfIntellectualPropertyRightsOf</seealso>
    let isOrWasHolderOfIntellectualPropertyRightsOf =
        Prefixed_Name(rico, "isOrWasHolderOfIntellectualPropertyRightsOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasIdentifierOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Identifier to a Thing that it identified or
    ///             identifies."</para>
    /// labels<para>"is or was identifier of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasIdentifierOf">https://www.ica.org/standards/RiC/ontology#isOrWasIdentifierOf</seealso>
    let isOrWasIdentifierOf = Prefixed_Name(rico, "isOrWasIdentifierOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'includes or included' object
    ///             property."</para>
    /// labels<para>"is or was included in"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasIncludedIn">https://www.ica.org/standards/RiC/ontology#isOrWasIncludedIn</seealso>
    let isOrWasIncludedIn = Prefixed_Name(rico, "isOrWasIncludedIn") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasJurisdictionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place to an Agent that has or had jurisdiction over
    ///             the Place."</para>
    /// labels<para>"is or was jurisdiction of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasJurisdictionOf">https://www.ica.org/standards/RiC/ontology#isOrWasJurisdictionOf</seealso>
    let isOrWasJurisdictionOf =
        Prefixed_Name(rico, "isOrWasJurisdictionOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasLanguageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Language to an Agent, Record or Record Part that uses
    ///             or used it."</para>
    /// labels<para>"is or was language of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOf">https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOf</seealso>
    let isOrWasLanguageOf = Prefixed_Name(rico, "isOrWasLanguageOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasLanguageOfAllMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Language and a Record Set whose all present or past
    ///             Record or Record Part members use that Language."</para>
    /// labels<para>"is or was language of all members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOfAllMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOfAllMembersOf</seealso>
    let isOrWasLanguageOfAllMembersOf =
        Prefixed_Name(rico, "isOrWasLanguageOfAllMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasLanguageOfSomeMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Language and a Record Set whose some present or past
    ///             Record or Record Part members use that Language."</para>
    /// labels<para>"is or was language of some members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOfSomeMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOfSomeMembersOf</seealso>
    let isOrWasLanguageOfSomeMembersOf =
        Prefixed_Name(rico, "isOrWasLanguageOfSomeMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasLeaderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to the Group that Person leads or led in the
    ///             past."</para>
    /// labels<para>"is or was leader of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasLeaderOf">https://www.ica.org/standards/RiC/ontology#isOrWasLeaderOf</seealso>
    let isOrWasLeaderOf = Prefixed_Name(rico, "isOrWasLeaderOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasLegalStatusOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Legal Status to an Agent or Record Resource that it
    ///             categorizes."</para>
    /// labels<para>"is or was legal status of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOf">https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOf</seealso>
    let isOrWasLegalStatusOf =
        Prefixed_Name(rico, "isOrWasLegalStatusOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasLegalStatusOfAllMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Legal Status and a Record Set whose all past or
    ///             present Record or Record Part members have that Legal Status."</para>
    /// labels<para>"is or was legal status of all members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOfAllMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOfAllMembersOf</seealso>
    let isOrWasLegalStatusOfAllMembersOf =
        Prefixed_Name(rico, "isOrWasLegalStatusOfAllMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasLegalStatusOfSomeMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Legal Status and a Record Set whose some past or
    ///             present Record or Record Part members have that Legal Status."</para>
    /// labels<para>"is or was legal status of some members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOfSomeMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOfSomeMembersOf</seealso>
    let isOrWasLegalStatusOfSomeMembersOf =
        Prefixed_Name(rico, "isOrWasLegalStatusOfSomeMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place to a Thing that is or was located in the
    ///             Place."</para>
    /// labels<para>"is or was location of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasLocationOf">https://www.ica.org/standards/RiC/ontology#isOrWasLocationOf</seealso>
    let isOrWasLocationOf = Prefixed_Name(rico, "isOrWasLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasMainSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had main subject' object
    ///             property."</para>
    /// labels<para>"is or was main subject of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasMainSubjectOf">https://www.ica.org/standards/RiC/ontology#isOrWasMainSubjectOf</seealso>
    let isOrWasMainSubjectOf =
        Prefixed_Name(rico, "isOrWasMainSubjectOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasManagerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent to a Record Resource or Instantiation that the
    ///             Agent managed or manages."</para>
    /// labels<para>"is or was manager of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasManagerOf">https://www.ica.org/standards/RiC/ontology#isOrWasManagerOf</seealso>
    let isOrWasManagerOf = Prefixed_Name(rico, "isOrWasManagerOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had member' object property."</para>
    /// labels<para>"is or was member of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasMemberOf">https://www.ica.org/standards/RiC/ontology#isOrWasMemberOf</seealso>
    let isOrWasMemberOf = Prefixed_Name(rico, "isOrWasMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasNameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Name to a Thing that it designated or
    ///             designates."</para>
    /// labels<para>"is or was name of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasNameOf">https://www.ica.org/standards/RiC/ontology#isOrWasNameOf</seealso>
    let isOrWasNameOf = Prefixed_Name(rico, "isOrWasNameOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasOccupationTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Occupation Type to a Person whose occupation is or
    ///             was categorized by it."</para>
    /// labels<para>"is or was occupation type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasOccupationTypeOf">https://www.ica.org/standards/RiC/ontology#isOrWasOccupationTypeOf</seealso>
    let isOrWasOccupationTypeOf =
        Prefixed_Name(rico, "isOrWasOccupationTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasOccupiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'occupies or occupied' object
    ///             property."</para>
    /// labels<para>"is or was occupied by"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasOccupiedBy">https://www.ica.org/standards/RiC/ontology#isOrWasOccupiedBy</seealso>
    let isOrWasOccupiedBy = Prefixed_Name(rico, "isOrWasOccupiedBy") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasOwnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Group, Person or Position to a Thing that this Agent
    ///             owns or owned."</para>
    /// labels<para>"is or was owner of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasOwnerOf">https://www.ica.org/standards/RiC/ontology#isOrWasOwnerOf</seealso>
    let isOrWasOwnerOf = Prefixed_Name(rico, "isOrWasOwnerOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had part' relation."</para>
    /// labels<para>"is or was part of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasPartOf">https://www.ica.org/standards/RiC/ontology#isOrWasPartOf</seealso>
    let isOrWasPartOf = Prefixed_Name(rico, "isOrWasPartOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasParticipantIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had participant' object
    ///             property."</para>
    /// labels<para>"is or was participant in"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasParticipantIn">https://www.ica.org/standards/RiC/ontology#isOrWasParticipantIn</seealso>
    let isOrWasParticipantIn =
        Prefixed_Name(rico, "isOrWasParticipantIn") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Activity to an Agent that performed or performs the
    ///             Activity."</para>
    /// labels<para>"is or was performed by"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasPerformedBy">https://www.ica.org/standards/RiC/ontology#isOrWasPerformedBy</seealso>
    let isOrWasPerformedBy = Prefixed_Name(rico, "isOrWasPerformedBy") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasPhysicalLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Physical Location to a Place, when it is or was its
    ///             location."</para>
    /// labels<para>"is or was physical location of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasPhysicalLocationOf">https://www.ica.org/standards/RiC/ontology#isOrWasPhysicalLocationOf</seealso>
    let isOrWasPhysicalLocationOf =
        Prefixed_Name(rico, "isOrWasPhysicalLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasPlaceNameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place Name to a Place that was or is designated by
    ///             it."</para>
    /// labels<para>"is or was place name of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasPlaceNameOf">https://www.ica.org/standards/RiC/ontology#isOrWasPlaceNameOf</seealso>
    let isOrWasPlaceNameOf = Prefixed_Name(rico, "isOrWasPlaceNameOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasPlaceTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place Type to a Place that is or was categorized by
    ///             it."</para>
    /// labels<para>"is or was place type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasPlaceTypeOf">https://www.ica.org/standards/RiC/ontology#isOrWasPlaceTypeOf</seealso>
    let isOrWasPlaceTypeOf = Prefixed_Name(rico, "isOrWasPlaceTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasRecordStateOfAllMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record State and a Record Set whose all past or
    ///             present Record or Record Part members have that Record State."</para>
    /// labels<para>"is or was record state of all members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasRecordStateOfAllMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasRecordStateOfAllMembersOf</seealso>
    let isOrWasRecordStateOfAllMembersOf =
        Prefixed_Name(rico, "isOrWasRecordStateOfAllMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasRecordStateOfSomeMembersOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record State and a Record Set whose some past or
    ///             present Record or Record Part members have that Record State."</para>
    /// labels<para>"is or was record state of some members of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasRecordStateOfSomeMembersOf">https://www.ica.org/standards/RiC/ontology#isOrWasRecordStateOfSomeMembersOf</seealso>
    let isOrWasRecordStateOfSomeMembersOf =
        Prefixed_Name(rico, "isOrWasRecordStateOfSomeMembersOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasRegulatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of the 'regulates or regulated' object
    ///             property."</para>
    /// labels<para>"is or was regulated by"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasRegulatedBy">https://www.ica.org/standards/RiC/ontology#isOrWasRegulatedBy</seealso>
    let isOrWasRegulatedBy = Prefixed_Name(rico, "isOrWasRegulatedBy") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasResponsibleForEnforcing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is or was enforced by' object
    ///             property."</para>
    /// labels<para>"is or was responsible for enforcing"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasResponsibleForEnforcing">https://www.ica.org/standards/RiC/ontology#isOrWasResponsibleForEnforcing</seealso>
    let isOrWasResponsibleForEnforcing =
        Prefixed_Name(rico, "isOrWasResponsibleForEnforcing") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasRuleTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"connects a Rule Type to a Rule that it categorized or
    ///             categorizes."</para>
    /// labels<para>"is or was rule type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasRuleTypeOf">https://www.ica.org/standards/RiC/ontology#isOrWasRuleTypeOf</seealso>
    let isOrWasRuleTypeOf = Prefixed_Name(rico, "isOrWasRuleTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasSubdivisionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had subdivision' object
    ///             property."</para>
    /// labels<para>"is or was subdivision of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasSubdivisionOf">https://www.ica.org/standards/RiC/ontology#isOrWasSubdivisionOf</seealso>
    let isOrWasSubdivisionOf =
        Prefixed_Name(rico, "isOrWasSubdivisionOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasSubeventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had subevent' object property."</para>
    /// labels<para>"is or was subevent of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasSubeventOf">https://www.ica.org/standards/RiC/ontology#isOrWasSubeventOf</seealso>
    let isOrWasSubeventOf = Prefixed_Name(rico, "isOrWasSubeventOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isOrWasSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had subject' object property."</para>
    /// labels<para>"is or was subject of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasSubjectOf">https://www.ica.org/standards/RiC/ontology#isOrWasSubjectOf</seealso>
    let isOrWasSubjectOf = Prefixed_Name(rico, "isOrWasSubjectOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasSubordinateTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had subordinate' object
    ///             property."</para>
    /// labels<para>"is or was subordinate to"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasSubordinateTo">https://www.ica.org/standards/RiC/ontology#isOrWasSubordinateTo</seealso>
    let isOrWasSubordinateTo =
        Prefixed_Name(rico, "isOrWasSubordinateTo") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasTitleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Title to a Record Resource, Instantiation or Rule
    ///             that it designated or designates."</para>
    /// labels<para>"is or was title of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasTitleOf">https://www.ica.org/standards/RiC/ontology#isOrWasTitleOf</seealso>
    let isOrWasTitleOf = Prefixed_Name(rico, "isOrWasTitleOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOrWasUnderAuthorityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has or had authority over' object
    ///             property."</para>
    /// labels<para>"is or was under authority of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOrWasUnderAuthorityOf">https://www.ica.org/standards/RiC/ontology#isOrWasUnderAuthorityOf</seealso>
    let isOrWasUnderAuthorityOf =
        Prefixed_Name(rico, "isOrWasUnderAuthorityOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isOriginalOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects the original version of a Record to a copy or a later
    ///             version."</para>
    /// labels<para>"is original of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isOriginalOf">https://www.ica.org/standards/RiC/ontology#isOriginalOf</seealso>
    let isOriginalOf = Prefixed_Name(rico, "isOriginalOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isPlaceAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place to a Thing that Place is associated with the
    ///             existence and lifecycle of."</para>
    /// labels<para>"is place associated with "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isPlaceAssociatedWith">https://www.ica.org/standards/RiC/ontology#isPlaceAssociatedWith</seealso>
    let isPlaceAssociatedWith =
        Prefixed_Name(rico, "isPlaceAssociatedWith") |> PrefixedName

    /// <summary>
    ///   <para>rico:isProductionTechniqueTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Production Technique Type to an Instantiation whose
    ///             production technique is categorized by it."</para>
    /// labels<para>"is production technique type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isProductionTechniqueTypeOf">https://www.ica.org/standards/RiC/ontology#isProductionTechniqueTypeOf</seealso>
    let isProductionTechniqueTypeOf =
        Prefixed_Name(rico, "isProductionTechniqueTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isProvenanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"inverse of 'has provenance' object property."</para>
    /// labels<para>"is provenance of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isProvenanceOf">https://www.ica.org/standards/RiC/ontology#isProvenanceOf</seealso>
    let isProvenanceOf = Prefixed_Name(rico, "isProvenanceOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isPublisherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Agent to a Record Resource that it
    ///             published."</para>
    /// labels<para>"isPublisherOf"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isPublisherOf">https://www.ica.org/standards/RiC/ontology#isPublisherOf</seealso>
    let isPublisherOf = Prefixed_Name(rico, "isPublisherOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isReceiverOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'received by' object property."</para>
    /// labels<para>"is receiver of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isReceiverOf">https://www.ica.org/standards/RiC/ontology#isReceiverOf</seealso>
    let isReceiverOf = Prefixed_Name(rico, "isReceiverOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isRecordResourceAssociatedWithRecordResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects two Record Resources. This object property is
    ///             symmetric."</para>
    /// labels<para>"is record resource associated with record resource "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isRecordResourceAssociatedWithRecordResource">https://www.ica.org/standards/RiC/ontology#isRecordResourceAssociatedWithRecordResource</seealso>
    let isRecordResourceAssociatedWithRecordResource =
        Prefixed_Name(rico, "isRecordResourceAssociatedWithRecordResource") |> PrefixedName

    /// <summary>
    ///   <para>rico:isRecordSetTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Set Type to a Record Set that it
    ///             categorizes."</para>
    /// labels<para>"is record set type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isRecordSetTypeOf">https://www.ica.org/standards/RiC/ontology#isRecordSetTypeOf</seealso>
    let isRecordSetTypeOf = Prefixed_Name(rico, "isRecordSetTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isRecordStateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record State to a Record or Record Part whose state
    ///             it categorizes."</para>
    /// labels<para>"is record state of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isRecordStateOf">https://www.ica.org/standards/RiC/ontology#isRecordStateOf</seealso>
    let isRecordStateOf = Prefixed_Name(rico, "isRecordStateOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The most generic object property. Connects an Thing to any other
    ///             Thing This is a symmetric object property."</para>
    /// labels<para>"is related to "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isRelatedTo">https://www.ica.org/standards/RiC/ontology#isRelatedTo</seealso>
    let isRelatedTo = Prefixed_Name(rico, "isRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>rico:isReplyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has reply' object property."</para>
    /// labels<para>"is reply to"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isReplyTo">https://www.ica.org/standards/RiC/ontology#isReplyTo</seealso>
    let isReplyTo = Prefixed_Name(rico, "isReplyTo") |> PrefixedName

    /// <summary>
    ///   <para>rico:isRepresentationTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Representation Type to an Instantiation that it
    ///             categorizes."</para>
    /// labels<para>"is representation type of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isRepresentationTypeOf">https://www.ica.org/standards/RiC/ontology#isRepresentationTypeOf</seealso>
    let isRepresentationTypeOf =
        Prefixed_Name(rico, "isRepresentationTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isResponsibleForIssuing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'issued by' object property."</para>
    /// labels<para>"is responsible for issuing "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isResponsibleForIssuing">https://www.ica.org/standards/RiC/ontology#isResponsibleForIssuing</seealso>
    let isResponsibleForIssuing =
        Prefixed_Name(rico, "isResponsibleForIssuing") |> PrefixedName

    /// <summary>
    ///   <para>rico:isRuleAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Rule to a Thing that is associated with the existence
    ///             and lifecycle of the Rule."</para>
    /// labels<para>"is rule associated with "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isRuleAssociatedWith">https://www.ica.org/standards/RiC/ontology#isRuleAssociatedWith</seealso>
    let isRuleAssociatedWith =
        Prefixed_Name(rico, "isRuleAssociatedWith") |> PrefixedName

    /// <summary>
    ///   <para>rico:isSenderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has sender' object property."</para>
    /// labels<para>"is sender of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isSenderOf">https://www.ica.org/standards/RiC/ontology#isSenderOf</seealso>
    let isSenderOf = Prefixed_Name(rico, "isSenderOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isSourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource or an Agent to a Record Resource or
    ///             Relation, when the first is used as a source of information for identifying or
    ///             describing the second one."</para>
    /// labels<para>"is source of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isSourceOf">https://www.ica.org/standards/RiC/ontology#isSourceOf</seealso>
    let isSourceOf = Prefixed_Name(rico, "isSourceOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isSuccessorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has successor' object property."</para>
    /// labels<para>"is successor of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isSuccessorOf">https://www.ica.org/standards/RiC/ontology#isSuccessorOf</seealso>
    let isSuccessorOf = Prefixed_Name(rico, "isSuccessorOf") |> PrefixedName
    /// <summary>
    ///   <para>rico:isToUseDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Date to an Appellation, when it is the date till
    ///             which the Appellation was used."</para>
    /// labels<para>"is to use date of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isToUseDateOf">https://www.ica.org/standards/RiC/ontology#isToUseDateOf</seealso>
    let isToUseDateOf = Prefixed_Name(rico, "isToUseDateOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:isUnitOfMeasurementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'has unit of measurement' object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is unit of measurement of"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#isUnitOfMeasurementOf">https://www.ica.org/standards/RiC/ontology#isUnitOfMeasurementOf</seealso>
    let isUnitOfMeasurementOf =
        Prefixed_Name(rico, "isUnitOfMeasurementOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:issuedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Rule to the Agent that issued or published the
    ///             Rule."</para>
    /// labels<para>"issued by "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#issuedBy">https://www.ica.org/standards/RiC/ontology#issuedBy</seealso>
    let issuedBy = Prefixed_Name(rico, "issuedBy") |> PrefixedName

    /// <summary>
    ///   <para>rico:knowingOfRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Knowing Of Relation to a 'knowing of' Person (a
    ///             Person who has some knowledge of another one.)"</para>
    /// labels<para>"knowing of relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#knowingOfRelationHasSource">https://www.ica.org/standards/RiC/ontology#knowingOfRelationHasSource</seealso>
    let knowingOfRelationHasSource =
        Prefixed_Name(rico, "knowingOfRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:knowingOfRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Knowing Of Relation to a 'known by' Person (a Person
    ///             on which another one has some has some knowledge.)"</para>
    /// labels<para>"knowing of relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#knowingOfRelationHasTarget">https://www.ica.org/standards/RiC/ontology#knowingOfRelationHasTarget</seealso>
    let knowingOfRelationHasTarget =
        Prefixed_Name(rico, "knowingOfRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:knowingRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects Knowing Relation to any known Person
    ///             involved."</para>
    /// labels<para>"knowing relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#knowingRelationConnects">https://www.ica.org/standards/RiC/ontology#knowingRelationConnects</seealso>
    let knowingRelationConnects =
        Prefixed_Name(rico, "knowingRelationConnects") |> PrefixedName

    /// <summary>
    ///   <para>rico:knownBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'knows of' object property."</para>
    /// labels<para>"known by "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#knownBy">https://www.ica.org/standards/RiC/ontology#knownBy</seealso>
    let knownBy = Prefixed_Name(rico, "knownBy") |> PrefixedName
    /// <summary>
    ///   <para>rico:knows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects two Persons that directly know each other during their
    ///             existence. This object property is symmetric."</para>
    /// labels<para>"knows "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#knows">https://www.ica.org/standards/RiC/ontology#knows</seealso>
    let knows = Prefixed_Name(rico, "knows") |> PrefixedName
    /// <summary>
    ///   <para>rico:knowsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to another Person they have some knowledge of
    ///             through time or space."</para>
    /// labels<para>"knows of "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#knowsOf">https://www.ica.org/standards/RiC/ontology#knowsOf</seealso>
    let knowsOf = Prefixed_Name(rico, "knowsOf") |> PrefixedName

    /// <summary>
    ///   <para>rico:lastModificationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date at which an entity was last updated."</para>
    /// labels<para>"last modification date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#lastModificationDate">https://www.ica.org/standards/RiC/ontology#lastModificationDate</seealso>
    let lastModificationDate =
        Prefixed_Name(rico, "lastModificationDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Distance in degrees north or south of the
    ///             equator."</para>
    /// labels<para>"latitude"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#latitude">https://www.ica.org/standards/RiC/ontology#latitude</seealso>
    let latitude = Prefixed_Name(rico, "latitude") |> PrefixedName

    /// <summary>
    ///   <para>rico:leadershipRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Leadership Relation to a Person who is involved as a
    ///             leader."</para>
    /// labels<para>"leadership relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#leadershipRelationHasSource">https://www.ica.org/standards/RiC/ontology#leadershipRelationHasSource</seealso>
    let leadershipRelationHasSource =
        Prefixed_Name(rico, "leadershipRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:leadershipRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Leadership Relation to a lead Group."</para>
    /// labels<para>"leadership relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#leadershipRelationHasTarget">https://www.ica.org/standards/RiC/ontology#leadershipRelationHasTarget</seealso>
    let leadershipRelationHasTarget =
        Prefixed_Name(rico, "leadershipRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:leadershipWithPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Leadership Relation to the Position occupied by the
    ///             leading Person."</para>
    /// labels<para>"leadership with position "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#leadershipWithPosition">https://www.ica.org/standards/RiC/ontology#leadershipWithPosition</seealso>
    let leadershipWithPosition =
        Prefixed_Name(rico, "leadershipWithPosition") |> PrefixedName

    /// <summary>
    ///   <para>rico:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A delimitation of the physical territory of a place. This
    ///             datatype property is used to describe basic human-readable text such as an address, a
    ///             cadastral reference, or less precise information found in a record."</para>
    /// labels<para>"location"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#location">https://www.ica.org/standards/RiC/ontology#location</seealso>
    let location = Prefixed_Name(rico, "location") |> PrefixedName
    /// <summary>
    ///   <para>rico:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Distance in degrees east or west of a prime
    ///             meridian."</para>
    /// labels<para>"longitude"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#longitude">https://www.ica.org/standards/RiC/ontology#longitude</seealso>
    let longitude = Prefixed_Name(rico, "longitude") |> PrefixedName

    /// <summary>
    ///   <para>rico:managementRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Management Relation to an Agent who is involved as a
    ///             manager."</para>
    /// labels<para>"management relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#managementRelationHasSource">https://www.ica.org/standards/RiC/ontology#managementRelationHasSource</seealso>
    let managementRelationHasSource =
        Prefixed_Name(rico, "managementRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:managementRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Management Relation to a Record Resource or
    ///             Instantiation that is involved as a managed thing."</para>
    /// labels<para>"management relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#managementRelationHasTarget">https://www.ica.org/standards/RiC/ontology#managementRelationHasTarget</seealso>
    let managementRelationHasTarget =
        Prefixed_Name(rico, "managementRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:mandateIsSourceOfMandateRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Mandate to a Mandate Relation."</para>
    /// labels<para>"mandate is source of mandate relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#mandateIsSourceOfMandateRelation">https://www.ica.org/standards/RiC/ontology#mandateIsSourceOfMandateRelation</seealso>
    let mandateIsSourceOfMandateRelation =
        Prefixed_Name(rico, "mandateIsSourceOfMandateRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:mandateRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Mandate Relation to a Mandate."</para>
    /// labels<para>"mandate relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#mandateRelationHasSource">https://www.ica.org/standards/RiC/ontology#mandateRelationHasSource</seealso>
    let mandateRelationHasSource =
        Prefixed_Name(rico, "mandateRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:mandateRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Mandate Relation to an Agent who is given the
    ///             authority or competencies to act."</para>
    /// labels<para>"mandate relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#mandateRelationHasTarget">https://www.ica.org/standards/RiC/ontology#mandateRelationHasTarget</seealso>
    let mandateRelationHasTarget =
        Prefixed_Name(rico, "mandateRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The extent, quantity, amount, or degree of an entity, as
    ///             determined by measurement or calculation."</para>
    /// labels<para>"measure"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#measure">https://www.ica.org/standards/RiC/ontology#measure</seealso>
    let measure = Prefixed_Name(rico, "measure") |> PrefixedName

    /// <summary>
    ///   <para>rico:membershipRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Membership Relation to the Group that has
    ///             member(s)."</para>
    /// labels<para>"membership relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#membershipRelationHasSource">https://www.ica.org/standards/RiC/ontology#membershipRelationHasSource</seealso>
    let membershipRelationHasSource =
        Prefixed_Name(rico, "membershipRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:membershipRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Membership Relation to a Person who is involved as a
    ///             member."</para>
    /// labels<para>"membership relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#membershipRelationHasTarget">https://www.ica.org/standards/RiC/ontology#membershipRelationHasTarget</seealso>
    let membershipRelationHasTarget =
        Prefixed_Name(rico, "membershipRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:membershipWithPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Membership Relation to the Position occupied by the
    ///             member Person(s)."</para>
    /// labels<para>"membership with position "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#membershipWithPosition">https://www.ica.org/standards/RiC/ontology#membershipWithPosition</seealso>
    let membershipWithPosition =
        Prefixed_Name(rico, "membershipWithPosition") |> PrefixedName

    /// <summary>
    ///   <para>rico:migratedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'migrated into' object property."</para>
    /// labels<para>"migrated from"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#migratedFrom">https://www.ica.org/standards/RiC/ontology#migratedFrom</seealso>
    let migratedFrom = Prefixed_Name(rico, "migratedFrom") |> PrefixedName
    /// <summary>
    ///   <para>rico:migratedInto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Instantiation to a version it has been migrated
    ///             to."</para>
    /// labels<para>"migrated into"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#migratedInto">https://www.ica.org/standards/RiC/ontology#migratedInto</seealso>
    let migratedInto = Prefixed_Name(rico, "migratedInto") |> PrefixedName

    /// <summary>
    ///   <para>rico:migrationRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Migration Relation to the migrated
    ///             Instantiation."</para>
    /// labels<para>"migration relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#migrationRelationHasSource">https://www.ica.org/standards/RiC/ontology#migrationRelationHasSource</seealso>
    let migrationRelationHasSource =
        Prefixed_Name(rico, "migrationRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:migrationRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Migration Relation to a resulting
    ///             Instantiation."</para>
    /// labels<para>"migration relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#migrationRelationHasTarget">https://www.ica.org/standards/RiC/ontology#migrationRelationHasTarget</seealso>
    let migrationRelationHasTarget =
        Prefixed_Name(rico, "migrationRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:modificationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date of the modification of an entity."</para>
    /// labels<para>"modification date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#modificationDate">https://www.ica.org/standards/RiC/ontology#modificationDate</seealso>
    let modificationDate = Prefixed_Name(rico, "modificationDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A label, title or term designating the entity in order to make
    ///             it distinguishable from other similar entities. For Record Resource or Instantiation,
    ///             the Name is generally assigned by an Agent as most do not have a Name given when
    ///             created."</para>
    /// labels<para>"name"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#name">https://www.ica.org/standards/RiC/ontology#name</seealso>
    let name = Prefixed_Name(rico, "name") |> PrefixedName
    /// <summary>
    ///   <para>rico:normalizedDateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date representation based on a standard, preferably
    ///             machine-readable."</para>
    /// labels<para>"normalized date value"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#normalizedDateValue">https://www.ica.org/standards/RiC/ontology#normalizedDateValue</seealso>
    let normalizedDateValue = Prefixed_Name(rico, "normalizedDateValue") |> PrefixedName
    /// <summary>
    ///   <para>rico:normalizedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Value representation based on a standard, preferably
    ///             machine-readable."</para>
    /// labels<para>"normalized value"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#normalizedValue">https://www.ica.org/standards/RiC/ontology#normalizedValue</seealso>
    let normalizedValue = Prefixed_Name(rico, "normalizedValue") |> PrefixedName
    /// <summary>
    ///   <para>rico:occupiesOrOccupied</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to a Position they occupy or
    ///             occupied."</para>
    /// labels<para>"occupies or occupied"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#occupiesOrOccupied">https://www.ica.org/standards/RiC/ontology#occupiesOrOccupied</seealso>
    let occupiesOrOccupied = Prefixed_Name(rico, "occupiesOrOccupied") |> PrefixedName

    /// <summary>
    ///   <para>rico:overlapsOrOverlapped</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects two Places that geographically overlap or overlapped.
    ///             This object property is symmetric."</para>
    /// labels<para>"overlaps or overlapped"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#overlapsOrOverlapped">https://www.ica.org/standards/RiC/ontology#overlapsOrOverlapped</seealso>
    let overlapsOrOverlapped =
        Prefixed_Name(rico, "overlapsOrOverlapped") |> PrefixedName

    /// <summary>
    ///   <para>rico:ownershipRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Ownership Relation to a Person, Group or Position
    ///             that is involved as an owner."</para>
    /// labels<para>"ownership relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ownershipRelationHasSource">https://www.ica.org/standards/RiC/ontology#ownershipRelationHasSource</seealso>
    let ownershipRelationHasSource =
        Prefixed_Name(rico, "ownershipRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:ownershipRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Ownership Relation to a Thing that is
    ///             owned."</para>
    /// labels<para>"owner ship relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ownershipRelationHasTarget">https://www.ica.org/standards/RiC/ontology#ownershipRelationHasTarget</seealso>
    let ownershipRelationHasTarget =
        Prefixed_Name(rico, "ownershipRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:performanceRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Performance Relation to a performed
    ///             Activity."</para>
    /// labels<para>"performance relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#performanceRelationHasSource">https://www.ica.org/standards/RiC/ontology#performanceRelationHasSource</seealso>
    let performanceRelationHasSource =
        Prefixed_Name(rico, "performanceRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:performanceRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Performance Relation to a performing
    ///             Agent."</para>
    /// labels<para>"performance relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#performanceRelationHasTarget">https://www.ica.org/standards/RiC/ontology#performanceRelationHasTarget</seealso>
    let performanceRelationHasTarget =
        Prefixed_Name(rico, "performanceRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:performsOrPerformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'is or was performed by' object
    ///             property."</para>
    /// labels<para>"performs or performed"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#performsOrPerformed">https://www.ica.org/standards/RiC/ontology#performsOrPerformed</seealso>
    let performsOrPerformed = Prefixed_Name(rico, "performsOrPerformed") |> PrefixedName

    /// <summary>
    ///   <para>rico:personHasCorrespondenceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to a Correspondence Relation."</para>
    /// labels<para>"person has correspondence relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personHasCorrespondenceRelation">https://www.ica.org/standards/RiC/ontology#personHasCorrespondenceRelation</seealso>
    let personHasCorrespondenceRelation =
        Prefixed_Name(rico, "personHasCorrespondenceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personHasFamilyRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to a Family Relation."</para>
    /// labels<para>"person has family relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personHasFamilyRelation">https://www.ica.org/standards/RiC/ontology#personHasFamilyRelation</seealso>
    let personHasFamilyRelation =
        Prefixed_Name(rico, "personHasFamilyRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personHasKnowingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to a Knowing Relation."</para>
    /// labels<para>"person has knowing relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personHasKnowingRelation">https://www.ica.org/standards/RiC/ontology#personHasKnowingRelation</seealso>
    let personHasKnowingRelation =
        Prefixed_Name(rico, "personHasKnowingRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personHasSiblingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to a Sibling Relation."</para>
    /// labels<para>"person has sibling relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personHasSiblingRelation">https://www.ica.org/standards/RiC/ontology#personHasSiblingRelation</seealso>
    let personHasSiblingRelation =
        Prefixed_Name(rico, "personHasSiblingRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personHasSpouseRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person to a Spouse Relation."</para>
    /// labels<para>"person has spouse relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personHasSpouseRelation">https://www.ica.org/standards/RiC/ontology#personHasSpouseRelation</seealso>
    let personHasSpouseRelation =
        Prefixed_Name(rico, "personHasSpouseRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsSourceOfChildRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (as a parent) to a Child
    ///             Relation."</para>
    /// labels<para>"person is source of child relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfChildRelation">https://www.ica.org/standards/RiC/ontology#personIsSourceOfChildRelation</seealso>
    let personIsSourceOfChildRelation =
        Prefixed_Name(rico, "personIsSourceOfChildRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsSourceOfDescendanceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (as an ancestor) to a Descendance
    ///             Relation."</para>
    /// labels<para>"person is source of descendance relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfDescendanceRelation">https://www.ica.org/standards/RiC/ontology#personIsSourceOfDescendanceRelation</seealso>
    let personIsSourceOfDescendanceRelation =
        Prefixed_Name(rico, "personIsSourceOfDescendanceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsSourceOfKnowingOfRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (who has some knowledge of another one) to a
    ///             Knowing Of Relation."</para>
    /// labels<para>"person is source of knowing of relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfKnowingOfRelation">https://www.ica.org/standards/RiC/ontology#personIsSourceOfKnowingOfRelation</seealso>
    let personIsSourceOfKnowingOfRelation =
        Prefixed_Name(rico, "personIsSourceOfKnowingOfRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsSourceOfLeadershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (as a leader) to a Leadership
    ///             Relation."</para>
    /// labels<para>"person is source of leadership relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfLeadershipRelation">https://www.ica.org/standards/RiC/ontology#personIsSourceOfLeadershipRelation</seealso>
    let personIsSourceOfLeadershipRelation =
        Prefixed_Name(rico, "personIsSourceOfLeadershipRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsSourceOfPositionHoldingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (who occupies a Position) to a Position
    ///             Holding Relation."</para>
    /// labels<para>"person is source of position holding relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfPositionHoldingRelation">https://www.ica.org/standards/RiC/ontology#personIsSourceOfPositionHoldingRelation</seealso>
    let personIsSourceOfPositionHoldingRelation =
        Prefixed_Name(rico, "personIsSourceOfPositionHoldingRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsSourceOfTeachingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (as a teacher) to a Teaching
    ///             Relation."</para>
    /// labels<para>"person is source of teaching relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfTeachingRelation">https://www.ica.org/standards/RiC/ontology#personIsSourceOfTeachingRelation</seealso>
    let personIsSourceOfTeachingRelation =
        Prefixed_Name(rico, "personIsSourceOfTeachingRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsTargetOfChildRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (as a child) to a Child
    ///             Relation."</para>
    /// labels<para>"person is target of child relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfChildRelation">https://www.ica.org/standards/RiC/ontology#personIsTargetOfChildRelation</seealso>
    let personIsTargetOfChildRelation =
        Prefixed_Name(rico, "personIsTargetOfChildRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsTargetOfDescendanceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (as a descendant) to a Descendance
    ///             Relation."</para>
    /// labels<para>"person is target of descendance relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfDescendanceRelation">https://www.ica.org/standards/RiC/ontology#personIsTargetOfDescendanceRelation</seealso>
    let personIsTargetOfDescendanceRelation =
        Prefixed_Name(rico, "personIsTargetOfDescendanceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsTargetOfKnowingOfRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (of which another Person has some knowledge)
    ///             to a Knowing Of Relation."</para>
    /// labels<para>"person is target of knowing of relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfKnowingOfRelation">https://www.ica.org/standards/RiC/ontology#personIsTargetOfKnowingOfRelation</seealso>
    let personIsTargetOfKnowingOfRelation =
        Prefixed_Name(rico, "personIsTargetOfKnowingOfRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsTargetOfMembershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (as a member of a Group) to a Membership
    ///             Relation."</para>
    /// labels<para>"person is target of membership relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfMembershipRelation">https://www.ica.org/standards/RiC/ontology#personIsTargetOfMembershipRelation</seealso>
    let personIsTargetOfMembershipRelation =
        Prefixed_Name(rico, "personIsTargetOfMembershipRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:personIsTargetOfTeachingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Person (as a student) to a Teaching
    ///             Relation."</para>
    /// labels<para>"person is target of teaching relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfTeachingRelation">https://www.ica.org/standards/RiC/ontology#personIsTargetOfTeachingRelation</seealso>
    let personIsTargetOfTeachingRelation =
        Prefixed_Name(rico, "personIsTargetOfTeachingRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:physicalCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information about the physical features of the Instantiation.
    ///             Includes information about the physical nature and condition such as conservation
    ///             status."</para>
    /// labels<para>"physical characteristics"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#physicalCharacteristics">https://www.ica.org/standards/RiC/ontology#physicalCharacteristics</seealso>
    let physicalCharacteristics =
        Prefixed_Name(rico, "physicalCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>rico:physicalOrLogicalExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Countable characteristics of the content of an entity expressed
    ///             as a quantity."</para>
    /// labels<para>"physical or logical extent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#physicalOrLogicalExtent">https://www.ica.org/standards/RiC/ontology#physicalOrLogicalExtent</seealso>
    let physicalOrLogicalExtent =
        Prefixed_Name(rico, "physicalOrLogicalExtent") |> PrefixedName

    /// <summary>
    ///   <para>rico:placeIsSourceOfPlaceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place (as associated to a Thing) to a Place
    ///             Relation."</para>
    /// labels<para>"place is source of place relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#placeIsSourceOfPlaceRelation">https://www.ica.org/standards/RiC/ontology#placeIsSourceOfPlaceRelation</seealso>
    let placeIsSourceOfPlaceRelation =
        Prefixed_Name(rico, "placeIsSourceOfPlaceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:placeRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place Relation to the Place concerned."</para>
    /// labels<para>"place relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#placeRelationHasSource">https://www.ica.org/standards/RiC/ontology#placeRelationHasSource</seealso>
    let placeRelationHasSource =
        Prefixed_Name(rico, "placeRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:placeRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Place Relation to a Thing that is associated to the
    ///             Place."</para>
    /// labels<para>"place relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#placeRelationHasTarget">https://www.ica.org/standards/RiC/ontology#placeRelationHasTarget</seealso>
    let placeRelationHasTarget =
        Prefixed_Name(rico, "placeRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:positionHoldingRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Position Holding Relation to a Person (who occupies a
    ///             Position)."</para>
    /// labels<para>"position holding relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#positionHoldingRelationHasSource">https://www.ica.org/standards/RiC/ontology#positionHoldingRelationHasSource</seealso>
    let positionHoldingRelationHasSource =
        Prefixed_Name(rico, "positionHoldingRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:positionHoldingRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Position Holding Relation to a Position (that is
    ///             occupied)."</para>
    /// labels<para>"position holding relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#positionHoldingRelationHasTarget">https://www.ica.org/standards/RiC/ontology#positionHoldingRelationHasTarget</seealso>
    let positionHoldingRelationHasTarget =
        Prefixed_Name(rico, "positionHoldingRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:positionIsContextOfLeadershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Position to a Leadership Relation (the leading Person
    ///             occupies that Position)."</para>
    /// labels<para>"position is context of leadership relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#positionIsContextOfLeadershipRelation">https://www.ica.org/standards/RiC/ontology#positionIsContextOfLeadershipRelation</seealso>
    let positionIsContextOfLeadershipRelation =
        Prefixed_Name(rico, "positionIsContextOfLeadershipRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:positionIsContextOfMembershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Position to a Membership Relation (the member Person
    ///             occupies that Position)."</para>
    /// labels<para>"position is context of membership relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#positionIsContextOfMembershipRelation">https://www.ica.org/standards/RiC/ontology#positionIsContextOfMembershipRelation</seealso>
    let positionIsContextOfMembershipRelation =
        Prefixed_Name(rico, "positionIsContextOfMembershipRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:positionIsSourceOfPositionToGroupRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Position (that exists within a Group) to a Position
    ///             to Group Relation."</para>
    /// labels<para>"position is source of position to group relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#positionIsSourceOfPositionToGroupRelation">https://www.ica.org/standards/RiC/ontology#positionIsSourceOfPositionToGroupRelation</seealso>
    let positionIsSourceOfPositionToGroupRelation =
        Prefixed_Name(rico, "positionIsSourceOfPositionToGroupRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:positionIsTargetOfPositionHoldingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Position (that is occupied by a Person) to a Position
    ///             Holding Relation."</para>
    /// labels<para>"position is target of position holding relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#positionIsTargetOfPositionHoldingRelation">https://www.ica.org/standards/RiC/ontology#positionIsTargetOfPositionHoldingRelation</seealso>
    let positionIsTargetOfPositionHoldingRelation =
        Prefixed_Name(rico, "positionIsTargetOfPositionHoldingRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:positionToGroupRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Position to Group Relation to a Position (that exists
    ///             in a Group)."</para>
    /// labels<para>"position to group relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#positionToGroupRelationHasSource">https://www.ica.org/standards/RiC/ontology#positionToGroupRelationHasSource</seealso>
    let positionToGroupRelationHasSource =
        Prefixed_Name(rico, "positionToGroupRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:positionToGroupRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Position to Group Relation to a Group (in which a
    ///             Position exists)."</para>
    /// labels<para>"position to group relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#positionToGroupRelationHasTarget">https://www.ica.org/standards/RiC/ontology#positionToGroupRelationHasTarget</seealso>
    let positionToGroupRelationHasTarget =
        Prefixed_Name(rico, "positionToGroupRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:precedesInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to a Thing that follows it in chronological
    ///             order."</para>
    /// labels<para>"precedes in time"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#precedesInTime">https://www.ica.org/standards/RiC/ontology#precedesInTime</seealso>
    let precedesInTime = Prefixed_Name(rico, "precedesInTime") |> PrefixedName
    /// <summary>
    ///   <para>rico:precedesOrPreceded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to a Thing that follows or followed it in some
    ///             sequence."</para>
    /// labels<para>"precedes or preceded"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#precedesOrPreceded">https://www.ica.org/standards/RiC/ontology#precedesOrPreceded</seealso>
    let precedesOrPreceded = Prefixed_Name(rico, "precedesOrPreceded") |> PrefixedName
    /// <summary>
    ///   <para>rico:productionTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Method used in the representation of information on the
    ///             Instantiation."</para>
    /// labels<para>"production technique"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#productionTechnique">https://www.ica.org/standards/RiC/ontology#productionTechnique</seealso>
    let productionTechnique = Prefixed_Name(rico, "productionTechnique") |> PrefixedName

    /// <summary>
    ///   <para>rico:provenanceRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Provenance Relation to a Record Resource or
    ///             Instantiation."</para>
    /// labels<para>"provenance relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#provenanceRelationHasSource">https://www.ica.org/standards/RiC/ontology#provenanceRelationHasSource</seealso>
    let provenanceRelationHasSource =
        Prefixed_Name(rico, "provenanceRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:provenanceRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Provenance Relation to an Agent or
    ///             Activity."</para>
    /// labels<para>"provenance relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#provenanceRelationHasTarget">https://www.ica.org/standards/RiC/ontology#provenanceRelationHasTarget</seealso>
    let provenanceRelationHasTarget =
        Prefixed_Name(rico, "provenanceRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:proxyFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Proxy to the Record Resource it stands for in the
    ///             specific context of a Record Set."</para>
    /// labels<para>"proxy for "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#proxyFor">https://www.ica.org/standards/RiC/ontology#proxyFor</seealso>
    let proxyFor = Prefixed_Name(rico, "proxyFor") |> PrefixedName
    /// <summary>
    ///   <para>rico:proxyIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Proxy to the Record Set in which it stands for
    ///             (represents) another Record Resource."</para>
    /// labels<para>"proxy in "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#proxyIn">https://www.ica.org/standards/RiC/ontology#proxyIn</seealso>
    let proxyIn = Prefixed_Name(rico, "proxyIn") |> PrefixedName
    /// <summary>
    ///   <para>rico:publicationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date of the publication of a Record Resource."</para>
    /// labels<para>"publication date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#publicationDate">https://www.ica.org/standards/RiC/ontology#publicationDate</seealso>
    let publicationDate = Prefixed_Name(rico, "publicationDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:qualityOfRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Conditions of an Instantiation that impact the legibility or
    ///             completeness of Record Resource, and thus the viability of its use. Conditions may be
    ///             associated with deficiencies in the processes of Record (re)creation or capture, or the
    ///             deterioration of the Instantiation (e.g. its carrier) causing loss of information of the
    ///             record over time"</para>
    /// labels<para>"quality of representation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#qualityOfRepresentation">https://www.ica.org/standards/RiC/ontology#qualityOfRepresentation</seealso>
    let qualityOfRepresentation =
        Prefixed_Name(rico, "qualityOfRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>rico:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Machine-readable quantity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quantity"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#quantity">https://www.ica.org/standards/RiC/ontology#quantity</seealso>
    let quantity = Prefixed_Name(rico, "quantity") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordIsSourceOfAuthorshipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record and an Authorship Relation."</para>
    /// labels<para>"record is source of authorship relation"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordIsSourceOfAuthorshipRelation">https://www.ica.org/standards/RiC/ontology#recordIsSourceOfAuthorshipRelation</seealso>
    let recordIsSourceOfAuthorshipRelation =
        Prefixed_Name(rico, "recordIsSourceOfAuthorshipRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The quantity of information content as human experienced
    ///             represented in the Record Resource. The method and precision of expressing the quantity
    ///             of information represented in a Record Resource will vary by the kind of Record Resource
    ///             being described as well as by processing economy constraints. For record sets, quantity
    ///             may be expressed as number of records, or, for analogue records in particular, by the
    ///             physical storage dimensions of the Record members. For individual records or record
    ///             parts, quantity may be expressed in more precise terms. Use if you don't use
    ///             RecordResourceExtent class and its properties for handling such
    ///             information."</para>
    /// labels<para>"Record Resource extent"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceExtent">https://www.ica.org/standards/RiC/ontology#recordResourceExtent</seealso>
    let recordResourceExtent =
        Prefixed_Name(rico, "recordResourceExtent") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceGeneticRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource Genetic Relation to one of the
    ///             associated Record Resources."</para>
    /// labels<para>"record resource genetic relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceGeneticRelationConnects">https://www.ica.org/standards/RiC/ontology#recordResourceGeneticRelationConnects</seealso>
    let recordResourceGeneticRelationConnects =
        Prefixed_Name(rico, "recordResourceGeneticRelationConnects") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceHoldingRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource Holding Relation to an Agent (as the
    ///             holder of a Record Resource or Instantiation)."</para>
    /// labels<para>"record resource holding relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceHoldingRelationHasSource">https://www.ica.org/standards/RiC/ontology#recordResourceHoldingRelationHasSource</seealso>
    let recordResourceHoldingRelationHasSource =
        Prefixed_Name(rico, "recordResourceHoldingRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceHoldingRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource Holding Relation to a Record Resource
    ///             or Instantiation (that is held by an Agent)."</para>
    /// labels<para>"record resource holding relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceHoldingRelationHasTarget">https://www.ica.org/standards/RiC/ontology#recordResourceHoldingRelationHasTarget</seealso>
    let recordResourceHoldingRelationHasTarget =
        Prefixed_Name(rico, "recordResourceHoldingRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceIsConnectedToRecordResourceGeneticRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource to a Record Resource Genetic
    ///             Relation."</para>
    /// labels<para>"record resource is connected to record resource genetic relation
    ///         "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceIsConnectedToRecordResourceGeneticRelation">https://www.ica.org/standards/RiC/ontology#recordResourceIsConnectedToRecordResourceGeneticRelation</seealso>
    let recordResourceIsConnectedToRecordResourceGeneticRelation =
        Prefixed_Name(rico, "recordResourceIsConnectedToRecordResourceGeneticRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceIsConnectedToRecordResourceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource to a Record Resource
    ///             Relation."</para>
    /// labels<para>"record resource is connected to record resource relation
    ///         "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceIsConnectedToRecordResourceRelation">https://www.ica.org/standards/RiC/ontology#recordResourceIsConnectedToRecordResourceRelation</seealso>
    let recordResourceIsConnectedToRecordResourceRelation =
        Prefixed_Name(rico, "recordResourceIsConnectedToRecordResourceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceIsSourceOfRecordResourceToInstantiationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource (that was instantiated) to a Record
    ///             Resource To Instantiation Relation"</para>
    /// labels<para>"record resource is source of record resource to instantiation
    ///             relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceIsSourceOfRecordResourceToInstantiationRelation">https://www.ica.org/standards/RiC/ontology#recordResourceIsSourceOfRecordResourceToInstantiationRelation</seealso>
    let recordResourceIsSourceOfRecordResourceToInstantiationRelation =
        Prefixed_Name(rico, "recordResourceIsSourceOfRecordResourceToInstantiationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceOrInstantiationIsSourceOfAccumulationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource or Instantiation (that is
    ///             accumulated) to an Accumulation Relation."</para>
    /// labels<para>"record resource or instantiation is source of accumulation
    ///             relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfAccumulationRelation">https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfAccumulationRelation</seealso>
    let recordResourceOrInstantiationIsSourceOfAccumulationRelation =
        Prefixed_Name(rico, "recordResourceOrInstantiationIsSourceOfAccumulationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource or Instantiation (that documents an
    ///             Activity) to an Activity Documentation Relation."</para>
    /// labels<para>"record resource or instantiation is source of activity
    ///             documentation relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation">https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation</seealso>
    let recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation =
        Prefixed_Name(rico, "recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceOrInstantiationIsSourceOfAgentOriginationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource or Instantiation (that is created,
    ///             sent or accumulated) to an Agent Origination Relation."</para>
    /// labels<para>"record resource or instantiation is source of agent origination
    ///             relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfAgentOriginationRelation">https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfAgentOriginationRelation</seealso>
    let recordResourceOrInstantiationIsSourceOfAgentOriginationRelation =
        Prefixed_Name(rico, "recordResourceOrInstantiationIsSourceOfAgentOriginationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceOrInstantiationIsSourceOfCreationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource or Instantiation (that is created) to
    ///             a Creation Relation."</para>
    /// labels<para>"record resource or instantiation is source of creation relation
    ///         "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfCreationRelation">https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfCreationRelation</seealso>
    let recordResourceOrInstantiationIsSourceOfCreationRelation =
        Prefixed_Name(rico, "recordResourceOrInstantiationIsSourceOfCreationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceOrInstantiationIsSourceOfProvenanceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource or Instantiation (that is created or
    ///             accumulated by an Agent, or documents an Activity) to a Provenance
    ///             Relation."</para>
    /// labels<para>"record resource or instantiation is source of provenance relation
    ///         "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfProvenanceRelation">https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfProvenanceRelation</seealso>
    let recordResourceOrInstantiationIsSourceOfProvenanceRelation =
        Prefixed_Name(rico, "recordResourceOrInstantiationIsSourceOfProvenanceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource or Instantiation (on which some
    ///             intellectual property rights are held) to an Intellectual Property Rights
    ///             Relation."</para>
    /// labels<para>"record resource or instantiation is target of intellectual
    ///             property rights relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation">https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation</seealso>
    let recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation =
        Prefixed_Name(rico, "recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceOrInstantiationIsTargetOfManagementRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource or Instantiation (that is managed by
    ///             an Agent) to a Management Relation."</para>
    /// labels<para>"record resource or instantiation is target of management relation
    ///         "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfManagementRelation">https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfManagementRelation</seealso>
    let recordResourceOrInstantiationIsTargetOfManagementRelation =
        Prefixed_Name(rico, "recordResourceOrInstantiationIsTargetOfManagementRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a Record Resource or Instantiation (that is held by an
    ///             Agent) to a Record Resource Holding Relation."</para>
    /// labels<para>"record resource or instantiation is target of record resource
    ///             holding relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation">https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation</seealso>
    let recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation =
        Prefixed_Name(rico, "recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource relation to one of the related Record
    ///             Resources."</para>
    /// labels<para>"record resource relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceRelationConnects">https://www.ica.org/standards/RiC/ontology#recordResourceRelationConnects</seealso>
    let recordResourceRelationConnects =
        Prefixed_Name(rico, "recordResourceRelationConnects") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information about the intellectual arrangement and composition
    ///             of a Record Resource. For Record and Record Part, it encompasses information about the
    ///             intellectual composition of the record, the presence of record parts and their
    ///             functions. For Record Set, it encompasses information about the methodology or criteria
    ///             used for arranging the Record Set members or Record members within the containing Record
    ///             Set"</para>
    /// labels<para>"Record Resource structure"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceStructure">https://www.ica.org/standards/RiC/ontology#recordResourceStructure</seealso>
    let recordResourceStructure =
        Prefixed_Name(rico, "recordResourceStructure") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceToInstantiationRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource To Instantiation Relation to the
    ///             Record Resource (that was instantiated). "</para>
    /// labels<para>"record resource to instantiation relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceToInstantiationRelationHasSource">https://www.ica.org/standards/RiC/ontology#recordResourceToInstantiationRelationHasSource</seealso>
    let recordResourceToInstantiationRelationHasSource =
        Prefixed_Name(rico, "recordResourceToInstantiationRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:recordResourceToInstantiationRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Record Resource To Instantiation Relation to an
    ///             Instantiation of the involved Record Resource. "</para>
    /// labels<para>"record resource to instantiation relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#recordResourceToInstantiationRelationHasTarget">https://www.ica.org/standards/RiC/ontology#recordResourceToInstantiationRelationHasTarget</seealso>
    let recordResourceToInstantiationRelationHasTarget =
        Prefixed_Name(rico, "recordResourceToInstantiationRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:referenceSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Framework or standard used to represent an
    ///             information."</para>
    /// labels<para>"reference system"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#referenceSystem">https://www.ica.org/standards/RiC/ontology#referenceSystem</seealso>
    let referenceSystem = Prefixed_Name(rico, "referenceSystem") |> PrefixedName

    /// <summary>
    ///   <para>rico:regulatesOrRegulated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Rule to a Thing that it regulates or
    ///             regulated."</para>
    /// labels<para>"regulates or regulated"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#regulatesOrRegulated">https://www.ica.org/standards/RiC/ontology#regulatesOrRegulated</seealso>
    let regulatesOrRegulated =
        Prefixed_Name(rico, "regulatesOrRegulated") |> PrefixedName

    /// <summary>
    ///   <para>rico:relationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an n-ary Relation to any of the Things
    ///             involved."</para>
    /// labels<para>"relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#relationConnects">https://www.ica.org/standards/RiC/ontology#relationConnects</seealso>
    let relationConnects = Prefixed_Name(rico, "relationConnects") |> PrefixedName
    /// <summary>
    ///   <para>rico:relationHasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an n-ary Relation to a Thing that is a secondary,
    ///             contextual entity during the existence of the Relation."</para>
    /// labels<para>"relation has context "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#relationHasContext">https://www.ica.org/standards/RiC/ontology#relationHasContext</seealso>
    let relationHasContext = Prefixed_Name(rico, "relationHasContext") |> PrefixedName
    /// <summary>
    ///   <para>rico:relationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an n-ary Relation to a Thing that is its
    ///             source."</para>
    /// labels<para>"relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#relationHasSource">https://www.ica.org/standards/RiC/ontology#relationHasSource</seealso>
    let relationHasSource = Prefixed_Name(rico, "relationHasSource") |> PrefixedName
    /// <summary>
    ///   <para>rico:relationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an n-ary Relation to a Thing that is its
    ///             target."</para>
    /// labels<para>"relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#relationHasTarget">https://www.ica.org/standards/RiC/ontology#relationHasTarget</seealso>
    let relationHasTarget = Prefixed_Name(rico, "relationHasTarget") |> PrefixedName
    /// <summary>
    ///   <para>rico:relationState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used to qualify the state of a Relation (e. g. present, past,
    ///             ongoing, unknown)."</para>
    /// labels<para>"Relation state"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#relationState">https://www.ica.org/standards/RiC/ontology#relationState</seealso>
    let relationState = Prefixed_Name(rico, "relationState") |> PrefixedName

    /// <summary>
    ///   <para>rico:resultsOrResultedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of 'results or resulted in' object
    ///             property."</para>
    /// labels<para>"results or resulted from"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#resultsOrResultedFrom">https://www.ica.org/standards/RiC/ontology#resultsOrResultedFrom</seealso>
    let resultsOrResultedFrom =
        Prefixed_Name(rico, "resultsOrResultedFrom") |> PrefixedName

    /// <summary>
    ///   <para>rico:resultsOrResultedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Event to a Thing that results or resulted from the
    ///             Event."</para>
    /// labels<para>"results or resulted in"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#resultsOrResultedIn">https://www.ica.org/standards/RiC/ontology#resultsOrResultedIn</seealso>
    let resultsOrResultedIn = Prefixed_Name(rico, "resultsOrResultedIn") |> PrefixedName

    /// <summary>
    ///   <para>rico:roleIsContextOfCreationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Role Type to a Creation Relation (this Role Type
    ///             being the specific role played by the creating Person in the context of this
    ///             Relation)."</para>
    /// labels<para>"role is context of creation relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#roleIsContextOfCreationRelation">https://www.ica.org/standards/RiC/ontology#roleIsContextOfCreationRelation</seealso>
    let roleIsContextOfCreationRelation =
        Prefixed_Name(rico, "roleIsContextOfCreationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:ruleFollowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The rule or conditions that govern the existence or lifecycle of
    ///             a Thing."</para>
    /// labels<para>"rule followed"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ruleFollowed">https://www.ica.org/standards/RiC/ontology#ruleFollowed</seealso>
    let ruleFollowed = Prefixed_Name(rico, "ruleFollowed") |> PrefixedName

    /// <summary>
    ///   <para>rico:ruleIsSourceOfRuleRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Rule to a Rule Relation."</para>
    /// labels<para>"rule is source of rule relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ruleIsSourceOfRuleRelation">https://www.ica.org/standards/RiC/ontology#ruleIsSourceOfRuleRelation</seealso>
    let ruleIsSourceOfRuleRelation =
        Prefixed_Name(rico, "ruleIsSourceOfRuleRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:ruleRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Rule Relation to a Rule."</para>
    /// labels<para>"rule relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ruleRelationHasSource">https://www.ica.org/standards/RiC/ontology#ruleRelationHasSource</seealso>
    let ruleRelationHasSource =
        Prefixed_Name(rico, "ruleRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:ruleRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Rule Relation to a Thing (that is associated to a
    ///             Rule)."</para>
    /// labels<para>"rule relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#ruleRelationHasTarget">https://www.ica.org/standards/RiC/ontology#ruleRelationHasTarget</seealso>
    let ruleRelationHasTarget =
        Prefixed_Name(rico, "ruleRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:scopeAndContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Summary of the scope (such as time periods, geography) and
    ///             content (such as subject matter, administrative processes) of the Record Resource. It
    ///             should highlight the information conveyed in the Record Resource, why it was created,
    ///             received, and/or maintained, and the Agents connected to it. Scope and Content provides
    ///             a more complete summary of the informational content of the Record Resource. It may
    ///             include description of relations with agents, activities, dates and places, or with
    ///             other record resources. It is not to be confused with the History attribute which
    ///             focuses on the origination and subsequence changes to a Record Resource."</para>
    /// labels<para>"scope and content"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#scopeAndContent">https://www.ica.org/standards/RiC/ontology#scopeAndContent</seealso>
    let scopeAndContent = Prefixed_Name(rico, "scopeAndContent") |> PrefixedName

    /// <summary>
    ///   <para>rico:sequentialRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Sequential Relation to a Thing that precedes other
    ///             Thing(s) in the sequence."</para>
    /// labels<para>"sequential relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#sequentialRelationHasSource">https://www.ica.org/standards/RiC/ontology#sequentialRelationHasSource</seealso>
    let sequentialRelationHasSource =
        Prefixed_Name(rico, "sequentialRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:sequentialRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Sequential Relation to a Thing that follows other
    ///             Thing(s) in the sequence."</para>
    /// labels<para>"sequential relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#sequentialRelationHasTarget">https://www.ica.org/standards/RiC/ontology#sequentialRelationHasTarget</seealso>
    let sequentialRelationHasTarget =
        Prefixed_Name(rico, "sequentialRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:siblingRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Sibling Relation to one of the siblings
    ///             involved."</para>
    /// labels<para>"sibling relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#siblingRelationConnects">https://www.ica.org/standards/RiC/ontology#siblingRelationConnects</seealso>
    let siblingRelationConnects =
        Prefixed_Name(rico, "siblingRelationConnects") |> PrefixedName

    /// <summary>
    ///   <para>rico:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Information about a source used to identify or describe an
    ///             entity."</para>
    /// labels<para>"source"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#source">https://www.ica.org/standards/RiC/ontology#source</seealso>
    let source = Prefixed_Name(rico, "source") |> PrefixedName

    /// <summary>
    ///   <para>rico:spouseRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Sibling Relation to one of the spouses
    ///             involved."</para>
    /// labels<para>"spouse relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#spouseRelationConnects">https://www.ica.org/standards/RiC/ontology#spouseRelationConnects</seealso>
    let spouseRelationConnects =
        Prefixed_Name(rico, "spouseRelationConnects") |> PrefixedName

    /// <summary>
    ///   <para>rico:structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Information about the intellectual arrangement and composition
    ///             of a Record Resource or the physical arrangement and composition of an Instantiation.
    ///             For Record and Record Part, it encompasses information about the intellectual
    ///             composition of the record, the presence of record parts and their functions. For Record
    ///             Set, it encompasses information about the methodology or criteria used for arranging the
    ///             Record Set members or Record members within the containing Record Set. For
    ///             Instantiation, it may comprise information about the composition of the physical
    ///             elements of the instantiation"</para>
    /// labels<para>"structure"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#structure">https://www.ica.org/standards/RiC/ontology#structure</seealso>
    let structure = Prefixed_Name(rico, "structure") |> PrefixedName

    /// <summary>
    ///   <para>rico:teachingRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Teaching Relation to a Person (who is a
    ///             teacher)."</para>
    /// labels<para>"teaching relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#teachingRelationHasSource">https://www.ica.org/standards/RiC/ontology#teachingRelationHasSource</seealso>
    let teachingRelationHasSource =
        Prefixed_Name(rico, "teachingRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:teachingRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Teaching Relation to a Person (who is a
    ///             student)."</para>
    /// labels<para>"teaching relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#teachingRelationHasTarget">https://www.ica.org/standards/RiC/ontology#teachingRelationHasTarget</seealso>
    let teachingRelationHasTarget =
        Prefixed_Name(rico, "teachingRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:technicalCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Describes any relevant physical or software feature of any
    ///             device involved in the creation or management of a Record Resource."</para>
    /// labels<para>"technical characteristics"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#technicalCharacteristics">https://www.ica.org/standards/RiC/ontology#technicalCharacteristics</seealso>
    let technicalCharacteristics =
        Prefixed_Name(rico, "technicalCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>rico:temporalRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Temporal Relation to a Thing that precedes other
    ///             Thing(s) in time."</para>
    /// labels<para>"temporal relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#temporalRelationHasSource">https://www.ica.org/standards/RiC/ontology#temporalRelationHasSource</seealso>
    let temporalRelationHasSource =
        Prefixed_Name(rico, "temporalRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:temporalRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Temporal Relation to a Thing that follows other
    ///             Thing(s) in time."</para>
    /// labels<para>"temporal relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#temporalRelationHasTarget">https://www.ica.org/standards/RiC/ontology#temporalRelationHasTarget</seealso>
    let temporalRelationHasTarget =
        Prefixed_Name(rico, "temporalRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:textualValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A textual expression of an Appellation or Date."</para>
    /// labels<para>"textual value"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#textualValue">https://www.ica.org/standards/RiC/ontology#textualValue</seealso>
    let textualValue = Prefixed_Name(rico, "textualValue") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsConnectedToRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to a n-ary Relation."</para>
    /// labels<para>"thing is connected to relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsConnectedToRelation">https://www.ica.org/standards/RiC/ontology#thingIsConnectedToRelation</seealso>
    let thingIsConnectedToRelation =
        Prefixed_Name(rico, "thingIsConnectedToRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsContextOfRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that is a secondary, contextual entity during
    ///             the existence of the Relation) to a n-ary Relation."</para>
    /// labels<para>"thing is context of relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsContextOfRelation">https://www.ica.org/standards/RiC/ontology#thingIsContextOfRelation</seealso>
    let thingIsContextOfRelation =
        Prefixed_Name(rico, "thingIsContextOfRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsSourceOfRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that is the source of a Relation) to a
    ///             Relation."</para>
    /// labels<para>"thing is source of relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfRelation">https://www.ica.org/standards/RiC/ontology#thingIsSourceOfRelation</seealso>
    let thingIsSourceOfRelation =
        Prefixed_Name(rico, "thingIsSourceOfRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsSourceOfSequentialRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to a Sequential Relation, when this Thing
    ///             precedes other Thing(s) in the sequence."</para>
    /// labels<para>"thing is source of sequential relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfSequentialRelation">https://www.ica.org/standards/RiC/ontology#thingIsSourceOfSequentialRelation</seealso>
    let thingIsSourceOfSequentialRelation =
        Prefixed_Name(rico, "thingIsSourceOfSequentialRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsSourceOfTemporalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to a Temporal Relation, when this Thing
    ///             precedes other Thing(s) in time."</para>
    /// labels<para>"thing is source of temporal relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfTemporalRelation">https://www.ica.org/standards/RiC/ontology#thingIsSourceOfTemporalRelation</seealso>
    let thingIsSourceOfTemporalRelation =
        Prefixed_Name(rico, "thingIsSourceOfTemporalRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsSourceOfWholePartRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to a Whole Part Relation, when this Thing has
    ///             Part other Thing(s)."</para>
    /// labels<para>"thing is source of whole part relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfWholePartRelation">https://www.ica.org/standards/RiC/ontology#thingIsSourceOfWholePartRelation</seealso>
    let thingIsSourceOfWholePartRelation =
        Prefixed_Name(rico, "thingIsSourceOfWholePartRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfAppellationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that is designated by an Appellation) to an
    ///             Appellation Relation."</para>
    /// labels<para>"thing is target of appellation relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfAppellationRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfAppellationRelation</seealso>
    let thingIsTargetOfAppellationRelation =
        Prefixed_Name(rico, "thingIsTargetOfAppellationRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfAuthorityRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that is under authority of an Agent) to an
    ///             Authority Relation."</para>
    /// labels<para>"thing is target of authority relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfAuthorityRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfAuthorityRelation</seealso>
    let thingIsTargetOfAuthorityRelation =
        Prefixed_Name(rico, "thingIsTargetOfAuthorityRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfEventRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that is associated with an Event) to an Event
    ///             Relation."</para>
    /// labels<para>"thing is target of event relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfEventRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfEventRelation</seealso>
    let thingIsTargetOfEventRelation =
        Prefixed_Name(rico, "thingIsTargetOfEventRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfOwnershipRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that is owned by a Group, a Person or a
    ///             Position) to an Ownership Relation."</para>
    /// labels<para>"thing is target of ownership relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfOwnershipRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfOwnershipRelation</seealso>
    let thingIsTargetOfOwnershipRelation =
        Prefixed_Name(rico, "thingIsTargetOfOwnershipRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfPlaceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that is associated with a Place) to a Place
    ///             Relation."</para>
    /// labels<para>"thing is target of place relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfPlaceRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfPlaceRelation</seealso>
    let thingIsTargetOfPlaceRelation =
        Prefixed_Name(rico, "thingIsTargetOfPlaceRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to a n-ary Relation."</para>
    /// labels<para>"thing is target of relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfRelation</seealso>
    let thingIsTargetOfRelation =
        Prefixed_Name(rico, "thingIsTargetOfRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfRuleRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that is associated with a Rule) to a Rule
    ///             Relation."</para>
    /// labels<para>"thing is target of rule relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfRuleRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfRuleRelation</seealso>
    let thingIsTargetOfRuleRelation =
        Prefixed_Name(rico, "thingIsTargetOfRuleRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfSequentialRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that follows other Thing(s) in a sequence) to
    ///             a Sequential Relation."</para>
    /// labels<para>"thing is target of sequential relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfSequentialRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfSequentialRelation</seealso>
    let thingIsTargetOfSequentialRelation =
        Prefixed_Name(rico, "thingIsTargetOfSequentialRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfTemporalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that follows other Thing(s) in time) to a
    ///             Temporal Relation."</para>
    /// labels<para>"thing is target of temporal relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfTemporalRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfTemporalRelation</seealso>
    let thingIsTargetOfTemporalRelation =
        Prefixed_Name(rico, "thingIsTargetOfTemporalRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfTypeRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing (that is categorized by a Type) to a Type
    ///             Relation."</para>
    /// labels<para>"thing is target of type relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfTypeRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfTypeRelation</seealso>
    let thingIsTargetOfTypeRelation =
        Prefixed_Name(rico, "thingIsTargetOfTypeRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:thingIsTargetOfWholePartRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to a Whole Part Relation, when this Thing is
    ///             Part of another Thing."</para>
    /// labels<para>"thing is target of whole part relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfWholePartRelation">https://www.ica.org/standards/RiC/ontology#thingIsTargetOfWholePartRelation</seealso>
    let thingIsTargetOfWholePartRelation =
        Prefixed_Name(rico, "thingIsTargetOfWholePartRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An identifying name of a Record Resource, Instantiation or
    ///             Rule."</para>
    /// labels<para>"title"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#title">https://www.ica.org/standards/RiC/ontology#title</seealso>
    let title = Prefixed_Name(rico, "title") |> PrefixedName
    /// <summary>
    ///   <para>rico:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A term used to characterize an entity."</para>
    /// labels<para>"type"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#type">https://www.ica.org/standards/RiC/ontology#type</seealso>
    let type_ = Prefixed_Name(rico, "type") |> PrefixedName

    /// <summary>
    ///   <para>rico:typeIsSourceOfTypeRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Type (a category) to a Type Relation."</para>
    /// labels<para>"type is source of type relation "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#typeIsSourceOfTypeRelation">https://www.ica.org/standards/RiC/ontology#typeIsSourceOfTypeRelation</seealso>
    let typeIsSourceOfTypeRelation =
        Prefixed_Name(rico, "typeIsSourceOfTypeRelation") |> PrefixedName

    /// <summary>
    ///   <para>rico:typeRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Type Relation to the Type (that categorizes the
    ///             involved Thing(s))."</para>
    /// labels<para>"type relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#typeRelationHasSource">https://www.ica.org/standards/RiC/ontology#typeRelationHasSource</seealso>
    let typeRelationHasSource =
        Prefixed_Name(rico, "typeRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:typeRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Type Relation to a Thing (that is categorized by the
    ///             involved Type)."</para>
    /// labels<para>"type relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#typeRelationHasTarget">https://www.ica.org/standards/RiC/ontology#typeRelationHasTarget</seealso>
    let typeRelationHasTarget =
        Prefixed_Name(rico, "typeRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:unitOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A definite magnitude of a quantity, defined and adopted by convention or by
    ///             law, that is used as a standard for measurement of the same kind of quantity. Can be
    ///             spacial units (cm, m), weight (g, kg), time (s, h), storage (MB, TB) or more informal
    ///             units used in the archival context like number of boxes, pages or words."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unit of measurement"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#unitOfMeasurement">https://www.ica.org/standards/RiC/ontology#unitOfMeasurement</seealso>
    let unitOfMeasurement = Prefixed_Name(rico, "unitOfMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>rico:usedFromDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date at which an Appellation was first used."</para>
    /// labels<para>"used from date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#usedFromDate">https://www.ica.org/standards/RiC/ontology#usedFromDate</seealso>
    let usedFromDate = Prefixed_Name(rico, "usedFromDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:usedToDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date until an Appellation was used."</para>
    /// labels<para>"used to date"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#usedToDate">https://www.ica.org/standards/RiC/ontology#usedToDate</seealso>
    let usedToDate = Prefixed_Name(rico, "usedToDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:wasLastUpdatedAtDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Thing to the Date when it was last
    ///             modified."</para>
    /// labels<para>"was last updated at date "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#wasLastUpdatedAtDate">https://www.ica.org/standards/RiC/ontology#wasLastUpdatedAtDate</seealso>
    let wasLastUpdatedAtDate =
        Prefixed_Name(rico, "wasLastUpdatedAtDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:wasUsedFromDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Appellation to the Date from which it was
    ///             used."</para>
    /// labels<para>"was used from date "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#wasUsedFromDate">https://www.ica.org/standards/RiC/ontology#wasUsedFromDate</seealso>
    let wasUsedFromDate = Prefixed_Name(rico, "wasUsedFromDate") |> PrefixedName
    /// <summary>
    ///   <para>rico:wasUsedToDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an Appellation to the Date till when it was
    ///             used."</para>
    /// labels<para>"was used to date "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#wasUsedToDate">https://www.ica.org/standards/RiC/ontology#wasUsedToDate</seealso>
    let wasUsedToDate = Prefixed_Name(rico, "wasUsedToDate") |> PrefixedName

    /// <summary>
    ///   <para>rico:wholePartRelationHasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Whole Part Relation to the Thing that has some
    ///             parts."</para>
    /// labels<para>"whole part relation has source "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#wholePartRelationHasSource">https://www.ica.org/standards/RiC/ontology#wholePartRelationHasSource</seealso>
    let wholePartRelationHasSource =
        Prefixed_Name(rico, "wholePartRelationHasSource") |> PrefixedName

    /// <summary>
    ///   <para>rico:wholePartRelationHasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Whole Part Relation to a Thing that is a
    ///             part."</para>
    /// labels<para>"whole part relation has target "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#wholePartRelationHasTarget">https://www.ica.org/standards/RiC/ontology#wholePartRelationHasTarget</seealso>
    let wholePartRelationHasTarget =
        Prefixed_Name(rico, "wholePartRelationHasTarget") |> PrefixedName

    /// <summary>
    ///   <para>rico:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Horizontal dimension of an entity."</para>
    /// labels<para>"width"</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#width">https://www.ica.org/standards/RiC/ontology#width</seealso>
    let width = Prefixed_Name(rico, "width") |> PrefixedName

    /// <summary>
    ///   <para>rico:workRelationConnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a Work Relation to an Agent."</para>
    /// labels<para>"work relation connects "</para></remarks>
    /// <seealso href="https://www.ica.org/standards/RiC/ontology#workRelationConnects">https://www.ica.org/standards/RiC/ontology#workRelationConnects</seealso>
    let workRelationConnects =
        Prefixed_Name(rico, "workRelationConnects") |> PrefixedName
