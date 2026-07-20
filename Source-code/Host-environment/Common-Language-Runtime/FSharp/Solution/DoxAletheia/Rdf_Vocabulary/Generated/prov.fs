namespace http.www.w3.org.ns.prov.hash

open DoxAletheia

module prov =
    let _namespace_name = "http://www.w3.org/ns/prov#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.
    /// Because prov:wasInfluencedBy is a broad relation, its more specific subproperties (e.g. prov:wasInformedBy, prov:actedOnBehalfOf, prov:wasEndedBy, etc.) should be used when applicable.
    /// <see href="http://www.w3.org/ns/prov#wasInfluencedBy"></see></summary>
    let wasInfluencedBy = _prefix "wasInfluencedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Activity"></see>
    /// </summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Agent"></see>
    /// </summary>
    let Agent = _prefix "Agent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    /// A definition quoted from PROV-DM or PROV-CONSTRAINTS that describes the concept expressed with this OWL term.
    /// <see href="http://www.w3.org/ns/prov#definition"></see></summary>
    let definition = _prefix "definition"
    /// <summary>
    /// A reference to the principal section of the PROV-DM document that describes this concept.
    /// <see href="http://www.w3.org/ns/prov#dm"></see></summary>
    let dm = _prefix "dm"
    /// <summary>
    /// A revision is a derivation that revises an entity into a revised version.
    /// <see href="http://www.w3.org/ns/prov#wasRevisionOf"></see></summary>
    let wasRevisionOf = _prefix "wasRevisionOf"
    /// <summary>
    /// The more specific subproperties of prov:wasDerivedFrom (i.e., prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource) should be used when applicable.
    /// <see href="http://www.w3.org/ns/prov#wasDerivedFrom"></see></summary>
    let wasDerivedFrom = _prefix "wasDerivedFrom"
    /// <summary>
    /// Attribution is the ascribing of an entity to an agent.
    /// <see href="http://www.w3.org/ns/prov#wasAttributedTo"></see></summary>
    let wasAttributedTo = _prefix "wasAttributedTo"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#hadPrimarySource"></see>
    /// </summary>
    let hadPrimarySource = _prefix "hadPrimarySource"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#hadMember"></see>
    /// </summary>
    let hadMember = _prefix "hadMember"
    /// <summary>
    /// An entity is derived from an original entity by copying, or 'quoting', some or all of it.
    /// <see href="http://www.w3.org/ns/prov#wasQuotedFrom"></see></summary>
    let wasQuotedFrom = _prefix "wasQuotedFrom"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#specializationOf"></see>
    /// </summary>
    let specializationOf = _prefix "specializationOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Accept"></see>
    /// </summary>
    let Accept = _prefix "Accept"
    /// <summary>
    /// Classify prov-o terms into three categories, including 'starting-point', 'qualifed', and 'extended'. This classification is used by the prov-o html document to gently introduce prov-o terms to its users.
    /// <see href="http://www.w3.org/ns/prov#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// Classify prov-o terms into six components according to prov-dm, including 'agents-responsibility', 'alternate', 'annotations', 'collections', 'derivations', and 'entities-activities'. This classification is used so that readers of prov-o specification can find its correspondence with the prov-dm specification.
    /// <see href="http://www.w3.org/ns/prov#component"></see></summary>
    let component_ = _prefix "component"
    /// <summary>
    /// A reference to the principal section of the PROV-CONSTRAINTS document that describes this concept.
    /// <see href="http://www.w3.org/ns/prov#constraints"></see></summary>
    let constraints = _prefix "constraints"
    /// <summary>
    /// A reference to the principal section of the PROV-DM document that describes this concept.
    /// A reference to the principal section of the PROV-M document that describes this concept.
    /// <see href="http://www.w3.org/ns/prov#n"></see></summary>
    let n = _prefix "n"
    /// <summary>
    /// It is not recommended that the type ActivityInfluence be asserted without also asserting one of its more specific subclasses.
    /// ActivityInfluence provides additional descriptions of an Activity's binary influence upon any other kind of resource. Instances of ActivityInfluence use the prov:activity property to cite the influencing Activity.
    /// <see href="http://www.w3.org/ns/prov#ActivityInfluence"></see></summary>
    let ActivityInfluence = _prefix "ActivityInfluence"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#activity"></see>
    /// </summary>
    let activity = _prefix "activity"
    /// <summary>
    /// The _optional_ Activity of an Influence, which used, generated, invalidated, or was the responsibility of some Entity. This property is _not_ used by ActivityInfluence (use prov:activity instead).
    /// This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.
    /// <see href="http://www.w3.org/ns/prov#hadActivity"></see></summary>
    let hadActivity = _prefix "hadActivity"
    /// <summary>
    /// An instance of prov:Influence provides additional descriptions about the binary prov:wasInfluencedBy relation from some influenced Activity, Entity, or Agent to the influencing Activity, Entity, or Agent. For example, :stomach_ache prov:wasInfluencedBy :spoon; prov:qualifiedInfluence [ a prov:Influence; prov:entity :spoon; :foo :bar ] . Because prov:Influence is a broad relation, the more specific relations (Communication, Delegation, End, etc.) should be used when applicable.
    /// Because prov:Influence is a broad relation, its most specific subclasses (e.g. prov:Communication, prov:Delegation, prov:End, prov:Revision, etc.) should be used when applicable.
    /// <see href="http://www.w3.org/ns/prov#Influence"></see></summary>
    let Influence = _prefix "Influence"
    /// <summary>
    /// EntityInfluence provides additional descriptions of an Entity's binary influence upon any other kind of resource. Instances of EntityInfluence use the prov:entity property to cite the influencing Entity.
    /// It is not recommended that the type EntityInfluence be asserted without also asserting one of its more specific subclasses.
    /// <see href="http://www.w3.org/ns/prov#EntityInfluence"></see></summary>
    let EntityInfluence = _prefix "EntityInfluence"
    /// <summary>
    /// When the prov-o term does not have a definition drawn from prov-dm, and the prov-o editor provides one.
    /// <see href="http://www.w3.org/ns/prov#editorsDefinition"></see></summary>
    let editorsDefinition = _prefix "editorsDefinition"
    /// <summary>
    /// An instantaneous event, or event for short, happens in the world and marks a change in the world, in its activities and in its entities. The term 'event' is commonly used in process algebra with a similar meaning. Events represent communications or interactions; they are assumed to be atomic and instantaneous.
    /// <see href="http://www.w3.org/ns/prov#InstantaneousEvent"></see></summary>
    let InstantaneousEvent = _prefix "InstantaneousEvent"
    /// <summary>
    /// AgentInfluence provides additional descriptions of an Agent's binary influence upon any other kind of resource. Instances of AgentInfluence use the prov:agent property to cite the influencing Agent.
    /// It is not recommended that the type AgentInfluence be asserted without also asserting one of its more specific subclasses.
    /// <see href="http://www.w3.org/ns/prov#AgentInfluence"></see></summary>
    let AgentInfluence = _prefix "AgentInfluence"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#agent"></see>
    /// </summary>
    let agent = _prefix "agent"
    /// <summary>
    /// An instance of prov:Association provides additional descriptions about the binary prov:wasAssociatedWith relation from an prov:Activity to some prov:Agent that had some responsiblity for it. For example, :baking prov:wasAssociatedWith :baker; prov:qualifiedAssociation [ a prov:Association; prov:agent :baker; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#Association"></see></summary>
    let Association = _prefix "Association"
    /// <summary>
    /// Classes and properties used to qualify relationships are annotated with prov:unqualifiedForm to indicate the property used to assert an unqualified provenance relation.
    /// <see href="http://www.w3.org/ns/prov#unqualifiedForm"></see></summary>
    let unqualifiedForm = _prefix "unqualifiedForm"
    /// <summary>
    /// An prov:Agent that had some (unspecified) responsibility for the occurrence of this prov:Activity.
    /// <see href="http://www.w3.org/ns/prov#wasAssociatedWith"></see></summary>
    let wasAssociatedWith = _prefix "wasAssociatedWith"
    /// <summary>
    /// An instance of prov:Attribution provides additional descriptions about the binary prov:wasAttributedTo relation from an prov:Entity to some prov:Agent that had some responsible for it. For example, :cake prov:wasAttributedTo :baker; prov:qualifiedAttribution [ a prov:Attribution; prov:entity :baker; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#Attribution"></see></summary>
    let Attribution = _prefix "Attribution"
    /// <summary>
    /// Note that there are kinds of bundles (e.g. handwritten letters, audio recordings, etc.) that are not expressed in PROV-O, but can be still be described by PROV-O.
    /// <see href="http://www.w3.org/ns/prov#Bundle"></see></summary>
    let Bundle = _prefix "Bundle"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Collection"></see>
    /// </summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// An instance of prov:Communication provides additional descriptions about the binary prov:wasInformedBy relation from an informed prov:Activity to the prov:Activity that informed it. For example, :you_jumping_off_bridge prov:wasInformedBy :everyone_else_jumping_off_bridge; prov:qualifiedCommunication [ a prov:Communication; prov:activity :everyone_else_jumping_off_bridge; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#Communication"></see></summary>
    let Communication = _prefix "Communication"
    /// <summary>
    /// An activity a2 is dependent on or informed by another activity a1, by way of some unspecified entity that is generated by a1 and used by a2.
    /// <see href="http://www.w3.org/ns/prov#wasInformedBy"></see></summary>
    let wasInformedBy = _prefix "wasInformedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Contribute"></see>
    /// </summary>
    let Contribute = _prefix "Contribute"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Contributor"></see>
    /// </summary>
    let Contributor = _prefix "Contributor"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Role"></see>
    /// </summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Copyright"></see>
    /// </summary>
    let Copyright = _prefix "Copyright"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Create"></see>
    /// </summary>
    let Create = _prefix "Create"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Creator"></see>
    /// </summary>
    let Creator = _prefix "Creator"
    /// <summary>
    /// An instance of prov:Delegation provides additional descriptions about the binary prov:actedOnBehalfOf relation from a performing prov:Agent to some prov:Agent for whom it was performed. For example, :mixing prov:wasAssociatedWith :toddler . :toddler prov:actedOnBehalfOf :mother; prov:qualifiedDelegation [ a prov:Delegation; prov:entity :mother; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#Delegation"></see></summary>
    let Delegation = _prefix "Delegation"
    /// <summary>
    /// An object property to express the accountability of an agent towards another agent. The subordinate agent acted on behalf of the responsible agent in an actual activity.
    /// <see href="http://www.w3.org/ns/prov#actedOnBehalfOf"></see></summary>
    let actedOnBehalfOf = _prefix "actedOnBehalfOf"
    /// <summary>
    /// An instance of prov:Derivation provides additional descriptions about the binary prov:wasDerivedFrom relation from some derived prov:Entity to another prov:Entity from which it was derived. For example, :chewed_bubble_gum prov:wasDerivedFrom :unwrapped_bubble_gum; prov:qualifiedDerivation [ a prov:Derivation; prov:entity :unwrapped_bubble_gum; :foo :bar ].
    /// The more specific forms of prov:Derivation (i.e., prov:Revision, prov:Quotation, prov:PrimarySource) should be asserted if they apply.
    /// <see href="http://www.w3.org/ns/prov#Derivation"></see></summary>
    let Derivation = _prefix "Derivation"
    /// <summary>
    /// This concept allows for the provenance of the dictionary, but also of its constituents to be expressed. Such a notion of dictionary corresponds to a wide variety of concrete data structures, such as a maps or associative arrays.
    /// A given dictionary forms a given structure for its members. A different structure (obtained either by insertion or removal of members) constitutes a different dictionary.
    /// <see href="http://www.w3.org/ns/prov#Dictionary"></see></summary>
    let Dictionary = _prefix "Dictionary"
    /// <summary>
    /// Type for a generic provenance query service. Mainly for use in RDF provenance query service descriptions, to facilitate discovery in linked data environments.
    /// <see href="http://www.w3.org/ns/prov#DirectQueryService"></see></summary>
    let DirectQueryService = _prefix "DirectQueryService"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#SoftwareAgent"></see>
    /// </summary>
    let SoftwareAgent = _prefix "SoftwareAgent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#aq"></see>
    /// </summary>
    let aq = _prefix "aq"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#EmptyCollection"></see>
    /// </summary>
    let EmptyCollection = _prefix "EmptyCollection"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#EmptyDictionary"></see>
    /// </summary>
    let EmptyDictionary = _prefix "EmptyDictionary"
    /// <summary>
    /// An instance of prov:End provides additional descriptions about the binary prov:wasEndedBy relation from some ended prov:Activity to an prov:Entity that ended it. For example, :ball_game prov:wasEndedBy :buzzer; prov:qualifiedEnd [ a prov:End; prov:entity :buzzer; :foo :bar; prov:atTime '2012-03-09T08:05:08-05:00'^^xsd:dateTime ].
    /// <see href="http://www.w3.org/ns/prov#End"></see></summary>
    let End = _prefix "End"
    /// <summary>
    /// End is when an activity is deemed to have ended. An end may refer to an entity, known as trigger, that terminated the activity.
    /// <see href="http://www.w3.org/ns/prov#wasEndedBy"></see></summary>
    let wasEndedBy = _prefix "wasEndedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#entity"></see>
    /// </summary>
    let entity = _prefix "entity"
    /// <summary>
    /// An instance of prov:Generation provides additional descriptions about the binary prov:wasGeneratedBy relation from a generated prov:Entity to the prov:Activity that generated it. For example, :cake prov:wasGeneratedBy :baking; prov:qualifiedGeneration [ a prov:Generation; prov:activity :baking; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#Generation"></see></summary>
    let Generation = _prefix "Generation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#wasGeneratedBy"></see>
    /// </summary>
    let wasGeneratedBy = _prefix "wasGeneratedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Insertion"></see>
    /// </summary>
    let Insertion = _prefix "Insertion"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#insertedKeyEntityPair"></see>
    /// </summary>
    let insertedKeyEntityPair = _prefix "insertedKeyEntityPair"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#dictionary"></see>
    /// </summary>
    let dictionary = _prefix "dictionary"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#derivedByInsertionFrom"></see>
    /// </summary>
    let derivedByInsertionFrom = _prefix "derivedByInsertionFrom"
    /// <summary>
    /// An instance of prov:Invalidation provides additional descriptions about the binary prov:wasInvalidatedBy relation from an invalidated prov:Entity to the prov:Activity that invalidated it. For example, :uncracked_egg prov:wasInvalidatedBy :baking; prov:qualifiedInvalidation [ a prov:Invalidation; prov:activity :baking; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#Invalidation"></see></summary>
    let Invalidation = _prefix "Invalidation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#wasInvalidatedBy"></see>
    /// </summary>
    let wasInvalidatedBy = _prefix "wasInvalidatedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#KeyEntityPair"></see>
    /// </summary>
    let KeyEntityPair = _prefix "KeyEntityPair"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#pairKey"></see>
    /// </summary>
    let pairKey = _prefix "pairKey"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#pairEntity"></see>
    /// </summary>
    let pairEntity = _prefix "pairEntity"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Location"></see>
    /// </summary>
    let Location = _prefix "Location"
    /// <summary>
    /// The Location of any resource.
    /// This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.
    /// <see href="http://www.w3.org/ns/prov#atLocation"></see></summary>
    let atLocation = _prefix "atLocation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Modify"></see>
    /// </summary>
    let Modify = _prefix "Modify"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Organization"></see>
    /// </summary>
    let Organization = _prefix "Organization"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    /// There exist no prescriptive requirement on the nature of plans, their representation, the actions or steps they consist of, or their intended goals. Since plans may evolve over time, it may become necessary to track their provenance, so plans themselves are entities. Representing the plan explicitly in the provenance can be useful for various tasks: for example, to validate the execution as represented in the provenance record, to manage expectation failures, or to provide explanations.
    /// <see href="http://www.w3.org/ns/prov#Plan"></see></summary>
    let Plan = _prefix "Plan"
    /// <summary>
    /// An instance of prov:PrimarySource provides additional descriptions about the binary prov:hadPrimarySource relation from some secondary prov:Entity to an earlier, primary prov:Entity. For example, :blog prov:hadPrimarySource :newsArticle; prov:qualifiedPrimarySource [ a prov:PrimarySource; prov:entity :newsArticle; :foo :bar ] .
    /// <see href="http://www.w3.org/ns/prov#PrimarySource"></see></summary>
    let PrimarySource = _prefix "PrimarySource"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Publish"></see>
    /// </summary>
    let Publish = _prefix "Publish"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Publisher"></see>
    /// </summary>
    let Publisher = _prefix "Publisher"
    /// <summary>
    /// An instance of prov:Quotation provides additional descriptions about the binary prov:wasQuotedFrom relation from some taken prov:Entity from an earlier, larger prov:Entity. For example, :here_is_looking_at_you_kid prov:wasQuotedFrom :casablanca_script; prov:qualifiedQuotation [ a prov:Quotation; prov:entity :casablanca_script; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#Quotation"></see></summary>
    let Quotation = _prefix "Quotation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Removal"></see>
    /// </summary>
    let Removal = _prefix "Removal"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#removedKey"></see>
    /// </summary>
    let removedKey = _prefix "removedKey"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#derivedByRemovalFrom"></see>
    /// </summary>
    let derivedByRemovalFrom = _prefix "derivedByRemovalFrom"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Replace"></see>
    /// </summary>
    let Replace = _prefix "Replace"
    /// <summary>
    /// An instance of prov:Revision provides additional descriptions about the binary prov:wasRevisionOf relation from some newer prov:Entity to an earlier prov:Entity. For example, :draft_2 prov:wasRevisionOf :draft_1; prov:qualifiedRevision [ a prov:Revision; prov:entity :draft_1; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#Revision"></see></summary>
    let Revision = _prefix "Revision"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#RightsAssignment"></see>
    /// </summary>
    let RightsAssignment = _prefix "RightsAssignment"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#RightsHolder"></see>
    /// </summary>
    let RightsHolder = _prefix "RightsHolder"
    /// <summary>
    /// The _optional_ Role that an Entity assumed in the context of an Activity. For example, :baking prov:used :spoon; prov:qualified [ a prov:Usage; prov:entity :spoon; prov:hadRole roles:mixing_implement ].
    /// This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.
    /// <see href="http://www.w3.org/ns/prov#hadRole"></see></summary>
    let hadRole = _prefix "hadRole"
    /// <summary>
    /// Type for a generic provenance query service. Mainly for use in RDF provenance query service descriptions, to facilitate discovery in linked data environments.
    /// <see href="http://www.w3.org/ns/prov#ServiceDescription"></see></summary>
    let ServiceDescription = _prefix "ServiceDescription"
    /// <summary>
    /// An instance of prov:Start provides additional descriptions about the binary prov:wasStartedBy relation from some started prov:Activity to an prov:Entity that started it. For example, :foot_race prov:wasStartedBy :bang; prov:qualifiedStart [ a prov:Start; prov:entity :bang; :foo :bar; prov:atTime '2012-03-09T08:05:08-05:00'^^xsd:dateTime ] .
    /// <see href="http://www.w3.org/ns/prov#Start"></see></summary>
    let Start = _prefix "Start"
    /// <summary>
    /// Start is when an activity is deemed to have started. A start may refer to an entity, known as trigger, that initiated the activity.
    /// <see href="http://www.w3.org/ns/prov#wasStartedBy"></see></summary>
    let wasStartedBy = _prefix "wasStartedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#Submit"></see>
    /// </summary>
    let Submit = _prefix "Submit"
    /// <summary>
    /// An instance of prov:Usage provides additional descriptions about the binary prov:used relation from some prov:Activity to an prov:Entity that it used. For example, :keynote prov:used :podium; prov:qualifiedUsage [ a prov:Usage; prov:entity :podium; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#Usage"></see></summary>
    let Usage = _prefix "Usage"
    /// <summary>
    /// A prov:Entity that was used by this prov:Activity. For example, :baking prov:used :spoon, :egg, :oven .
    /// <see href="http://www.w3.org/ns/prov#used"></see></summary>
    let used = _prefix "used"
    /// <summary>
    /// If this Agent prov:actedOnBehalfOf Agent :ag, then it can qualify how with prov:qualifiedResponsibility [ a prov:Responsibility;  prov:agent :ag; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedDelegation"></see></summary>
    let qualifiedDelegation = _prefix "qualifiedDelegation"
    /// <summary>
    /// PROV-O does not define all property inverses. The directionalities defined in PROV-O should be given preference over those not defined. However, if users wish to name the inverse of a PROV-O property, the local name given by prov:inverse should be used.
    /// <see href="http://www.w3.org/ns/prov#inverse"></see></summary>
    let inverse = _prefix "inverse"
    /// <summary>
    /// This annotation property links a subproperty of prov:wasInfluencedBy with the subclass of prov:Influence and the qualifying property that are used to qualify it.
    ///
    /// Example annotation:
    ///
    ///     prov:wasGeneratedBy prov:qualifiedForm prov:qualifiedGeneration, prov:Generation .
    ///
    /// Then this unqualified assertion:
    ///
    ///     :entity1 prov:wasGeneratedBy :activity1 .
    ///
    /// can be qualified by adding:
    ///
    ///    :entity1 prov:qualifiedGeneration :entity1Gen .
    ///    :entity1Gen
    ///        a prov:Generation, prov:Influence;
    ///        prov:activity :activity1;
    ///        :customValue 1337 .
    ///
    /// Note how the value of the unqualified influence (prov:wasGeneratedBy :activity1) is mirrored as the value of the prov:activity (or prov:entity, or prov:agent) property on the influence class.
    /// <see href="http://www.w3.org/ns/prov#qualifiedForm"></see></summary>
    let qualifiedForm = _prefix "qualifiedForm"
    /// <summary>
    /// Subproperties of prov:influencer are used to cite the object of an unqualified PROV-O triple whose predicate is a subproperty of prov:wasInfluencedBy (e.g. prov:used, prov:wasGeneratedBy). prov:influencer is used much like rdf:object is used.
    /// <see href="http://www.w3.org/ns/prov#influencer"></see></summary>
    let influencer = _prefix "influencer"
    /// <summary>
    /// A note by the OWL development team about how this term expresses the PROV-DM concept, or how it should be used in context of semantic web or linked data.
    /// <see href="http://www.w3.org/ns/prov#editorialNote"></see></summary>
    let editorialNote = _prefix "editorialNote"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#activityOfInfluence"></see>
    /// </summary>
    let activityOfInfluence = _prefix "activityOfInfluence"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#agentOfInfluence"></see>
    /// </summary>
    let agentOfInfluence = _prefix "agentOfInfluence"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#alternateOf"></see>
    /// </summary>
    let alternateOf = _prefix "alternateOf"
    /// <summary>
    /// prov:asInBundle is used to specify which bundle the general entity of a prov:mentionOf property is described.
    ///
    /// When :x prov:mentionOf :y and :y is described in Bundle :b, the triple :x prov:asInBundle :b is also asserted to cite the Bundle in which :y was described.
    /// <see href="http://www.w3.org/ns/prov#asInBundle"></see></summary>
    let asInBundle = _prefix "asInBundle"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#sharesDefinitionWith"></see>
    /// </summary>
    let sharesDefinitionWith = _prefix "sharesDefinitionWith"
    /// <summary>
    /// prov:mentionOf is used to specialize an entity as described in another bundle. It is to be used in conjuction with prov:asInBundle.
    ///
    /// prov:asInBundle is used to cite the Bundle in which the generalization was mentioned.
    /// <see href="http://www.w3.org/ns/prov#mentionOf"></see></summary>
    let mentionOf = _prefix "mentionOf"
    /// <summary>
    /// The time at which an InstantaneousEvent occurred, in the form of xsd:dateTime.
    /// <see href="http://www.w3.org/ns/prov#atTime"></see></summary>
    let atTime = _prefix "atTime"
    /// <summary>
    /// The time at which an entity was invalidated (i.e., no longer usable).
    /// <see href="http://www.w3.org/ns/prov#invalidatedAtTime"></see></summary>
    let invalidatedAtTime = _prefix "invalidatedAtTime"
    /// <summary>
    /// The time at which an activity started. See also prov:endedAtTime.
    /// <see href="http://www.w3.org/ns/prov#startedAtTime"></see></summary>
    let startedAtTime = _prefix "startedAtTime"
    /// <summary>
    /// The time at which an entity was completely created and is available for use.
    /// <see href="http://www.w3.org/ns/prov#generatedAtTime"></see></summary>
    let generatedAtTime = _prefix "generatedAtTime"
    /// <summary>
    /// The time at which an activity ended. See also prov:startedAtTime.
    /// <see href="http://www.w3.org/ns/prov#endedAtTime"></see></summary>
    let endedAtTime = _prefix "endedAtTime"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#contributed"></see>
    /// </summary>
    let contributed = _prefix "contributed"
    /// <summary>
    /// relates a generic provenance query service resource (type prov:ServiceDescription) to a specific query service description (e.g. a prov:DirectQueryService or a sd:Service).
    /// <see href="http://www.w3.org/ns/prov#describesService"></see></summary>
    let describesService = _prefix "describesService"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#ended"></see>
    /// </summary>
    let ended = _prefix "ended"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#entityOfInfluence"></see>
    /// </summary>
    let entityOfInfluence = _prefix "entityOfInfluence"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#generalizationOf"></see>
    /// </summary>
    let generalizationOf = _prefix "generalizationOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#generated"></see>
    /// </summary>
    let generated = _prefix "generated"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#influenced"></see>
    /// </summary>
    let influenced = _prefix "influenced"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#generatedAsDerivation"></see>
    /// </summary>
    let generatedAsDerivation = _prefix "generatedAsDerivation"
    /// <summary>
    /// The _optional_ Generation involved in an Entity's Derivation.
    /// <see href="http://www.w3.org/ns/prov#hadGeneration"></see></summary>
    let hadGeneration = _prefix "hadGeneration"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#hadDelegate"></see>
    /// </summary>
    let hadDelegate = _prefix "hadDelegate"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#hadDerivation"></see>
    /// </summary>
    let hadDerivation = _prefix "hadDerivation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#hadDictionaryMember"></see>
    /// </summary>
    let hadDictionaryMember = _prefix "hadDictionaryMember"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#hadInfluence"></see>
    /// </summary>
    let hadInfluence = _prefix "hadInfluence"
    /// <summary>
    /// The _optional_ Plan adopted by an Agent in Association with some Activity. Plan specifications are out of the scope of this specification.
    /// <see href="http://www.w3.org/ns/prov#hadPlan"></see></summary>
    let hadPlan = _prefix "hadPlan"
    /// <summary>
    /// If this Entity prov:hadPrimarySource Entity :e, then it can qualify how using prov:qualifiedPrimarySource [ a prov:PrimarySource; prov:entity :e; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedPrimarySource"></see></summary>
    let qualifiedPrimarySource = _prefix "qualifiedPrimarySource"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#hadRevision"></see>
    /// </summary>
    let hadRevision = _prefix "hadRevision"
    /// <summary>
    /// The _optional_ Usage involved in an Entity's Derivation.
    /// <see href="http://www.w3.org/ns/prov#hadUsage"></see></summary>
    let hadUsage = _prefix "hadUsage"
    /// <summary>
    /// Indicates anchor URI for a potentially dynamic resource instance.
    /// <see href="http://www.w3.org/ns/prov#has_anchor"></see></summary>
    let has_anchor = _prefix "has_anchor"
    /// <summary>
    /// Indicates a provenance-URI for a resource; the resource identified by this property presents a provenance record about its subject or anchor resource.
    /// <see href="http://www.w3.org/ns/prov#has_provenance"></see></summary>
    let has_provenance = _prefix "has_provenance"
    /// <summary>
    /// Indicates a provenance query service that can access provenance related to its subject or anchor resource.
    /// <see href="http://www.w3.org/ns/prov#has_query_service"></see></summary>
    let has_query_service = _prefix "has_query_service"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#informed"></see>
    /// </summary>
    let informed = _prefix "informed"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#invalidated"></see>
    /// </summary>
    let invalidated = _prefix "invalidated"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#locationOf"></see>
    /// </summary>
    let locationOf = _prefix "locationOf"
    /// <summary>
    /// The position that this OWL term should be listed within documentation. The scope of the documentation (e.g., among all terms, among terms within a prov:category, among properties applying to a particular class, etc.) is unspecified.
    /// <see href="http://www.w3.org/ns/prov#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// Relates a resource to a provenance pingback service that may receive additional provenance links about the resource.
    /// <see href="http://www.w3.org/ns/prov#pingback"></see></summary>
    let pingback = _prefix "pingback"
    /// <summary>
    /// Relates a provenance service to a URI template string for constructing provenance-URIs.
    /// <see href="http://www.w3.org/ns/prov#provenanceUriTemplate"></see></summary>
    let provenanceUriTemplate = _prefix "provenanceUriTemplate"
    /// <summary>
    /// If this Activity prov:wasAssociatedWith Agent :ag, then it can qualify the Association using prov:qualifiedAssociation [ a prov:Association;  prov:agent :ag; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedAssociation"></see></summary>
    let qualifiedAssociation = _prefix "qualifiedAssociation"
    /// <summary>
    /// Because prov:qualifiedInfluence is a broad relation, the more specific relations (qualifiedCommunication, qualifiedDelegation, qualifiedEnd, etc.) should be used when applicable.
    /// <see href="http://www.w3.org/ns/prov#qualifiedInfluence"></see></summary>
    let qualifiedInfluence = _prefix "qualifiedInfluence"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedAssociationOf"></see>
    /// </summary>
    let qualifiedAssociationOf = _prefix "qualifiedAssociationOf"
    /// <summary>
    /// If this Entity prov:wasAttributedTo Agent :ag, then it can qualify how it was influenced using prov:qualifiedAttribution [ a prov:Attribution;  prov:agent :ag; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedAttribution"></see></summary>
    let qualifiedAttribution = _prefix "qualifiedAttribution"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedAttributionOf"></see>
    /// </summary>
    let qualifiedAttributionOf = _prefix "qualifiedAttributionOf"
    /// <summary>
    /// If this Activity prov:wasInformedBy Activity :a, then it can qualify how it was influenced using prov:qualifiedCommunication [ a prov:Communication;  prov:activity :a; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedCommunication"></see></summary>
    let qualifiedCommunication = _prefix "qualifiedCommunication"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedCommunicationOf"></see>
    /// </summary>
    let qualifiedCommunicationOf = _prefix "qualifiedCommunicationOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedDelegationOf"></see>
    /// </summary>
    let qualifiedDelegationOf = _prefix "qualifiedDelegationOf"
    /// <summary>
    /// If this Entity prov:wasDerivedFrom Entity :e, then it can qualify how it was derived using prov:qualifiedDerivation [ a prov:Derivation;  prov:entity :e; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedDerivation"></see></summary>
    let qualifiedDerivation = _prefix "qualifiedDerivation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedDerivationOf"></see>
    /// </summary>
    let qualifiedDerivationOf = _prefix "qualifiedDerivationOf"
    /// <summary>
    /// If this Activity prov:wasEndedBy Entity :e1, then it can qualify how it was ended using prov:qualifiedEnd [ a prov:End;  prov:entity :e1; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedEnd"></see></summary>
    let qualifiedEnd = _prefix "qualifiedEnd"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedEndOf"></see>
    /// </summary>
    let qualifiedEndOf = _prefix "qualifiedEndOf"
    /// <summary>
    /// If this Activity prov:generated Entity :e, then it can qualify how it performed the Generation using prov:qualifiedGeneration [ a prov:Generation;  prov:entity :e; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedGeneration"></see></summary>
    let qualifiedGeneration = _prefix "qualifiedGeneration"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedGenerationOf"></see>
    /// </summary>
    let qualifiedGenerationOf = _prefix "qualifiedGenerationOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedInfluenceOf"></see>
    /// </summary>
    let qualifiedInfluenceOf = _prefix "qualifiedInfluenceOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedInsertion"></see>
    /// </summary>
    let qualifiedInsertion = _prefix "qualifiedInsertion"
    /// <summary>
    /// If this Entity prov:wasInvalidatedBy Activity :a, then it can qualify how it was invalidated using prov:qualifiedInvalidation [ a prov:Invalidation;  prov:activity :a; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedInvalidation"></see></summary>
    let qualifiedInvalidation = _prefix "qualifiedInvalidation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedInvalidationOf"></see>
    /// </summary>
    let qualifiedInvalidationOf = _prefix "qualifiedInvalidationOf"
    /// <summary>
    /// If this Entity prov:wasQuotedFrom Entity :e, then it can qualify how using prov:qualifiedQuotation [ a prov:Quotation;  prov:entity :e; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedQuotation"></see></summary>
    let qualifiedQuotation = _prefix "qualifiedQuotation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedQuotationOf"></see>
    /// </summary>
    let qualifiedQuotationOf = _prefix "qualifiedQuotationOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedRemoval"></see>
    /// </summary>
    let qualifiedRemoval = _prefix "qualifiedRemoval"
    /// <summary>
    /// If this Entity prov:wasRevisionOf Entity :e, then it can qualify how it was revised using prov:qualifiedRevision [ a prov:Revision;  prov:entity :e; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedRevision"></see></summary>
    let qualifiedRevision = _prefix "qualifiedRevision"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedSourceOf"></see>
    /// </summary>
    let qualifiedSourceOf = _prefix "qualifiedSourceOf"
    /// <summary>
    /// If this Activity prov:wasStartedBy Entity :e1, then it can qualify how it was started using prov:qualifiedStart [ a prov:Start;  prov:entity :e1; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedStart"></see></summary>
    let qualifiedStart = _prefix "qualifiedStart"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedStartOf"></see>
    /// </summary>
    let qualifiedStartOf = _prefix "qualifiedStartOf"
    /// <summary>
    /// If this Activity prov:used Entity :e, then it can qualify how it used it using prov:qualifiedUsage [ a prov:Usage; prov:entity :e; :foo :bar ].
    /// <see href="http://www.w3.org/ns/prov#qualifiedUsage"></see></summary>
    let qualifiedUsage = _prefix "qualifiedUsage"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#qualifiedUsingActivity"></see>
    /// </summary>
    let qualifiedUsingActivity = _prefix "qualifiedUsingActivity"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#quotedAs"></see>
    /// </summary>
    let quotedAs = _prefix "quotedAs"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#revisedEntity"></see>
    /// </summary>
    let revisedEntity = _prefix "revisedEntity"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#started"></see>
    /// </summary>
    let started = _prefix "started"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#todo"></see>
    /// </summary>
    let todo = _prefix "todo"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#wasActivityOfInfluence"></see>
    /// </summary>
    let wasActivityOfInfluence = _prefix "wasActivityOfInfluence"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#wasAssociateFor"></see>
    /// </summary>
    let wasAssociateFor = _prefix "wasAssociateFor"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#wasMemberOf"></see>
    /// </summary>
    let wasMemberOf = _prefix "wasMemberOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#wasPlanOf"></see>
    /// </summary>
    let wasPlanOf = _prefix "wasPlanOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#wasPrimarySourceOf"></see>
    /// </summary>
    let wasPrimarySourceOf = _prefix "wasPrimarySourceOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#wasRoleIn"></see>
    /// </summary>
    let wasRoleIn = _prefix "wasRoleIn"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#wasUsedBy"></see>
    /// </summary>
    let wasUsedBy = _prefix "wasUsedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/prov#wasUsedInDerivation"></see>
    /// </summary>
    let wasUsedInDerivation = _prefix "wasUsedInDerivation"
