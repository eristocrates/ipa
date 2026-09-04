#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module prov =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/prov#" "prov"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>prov:definition : Activity that identifies the acceptance of a resource (e.g., an article in a conference)</para>
    ///   <para>rdfs:label : Accept</para>
    ///   <a href="http://www.w3.org/ns/prov#Accept">prov:Accept</a>
    /// </summary>
    let Accept = _prefixId.prefix "Accept"
    /// <summary>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:definition : An activity is something that occurs over a period of time and acts upon or with entities; it may include consuming, processing, transforming, modifying, relocating, using, or generating entities.^^xsd:string</para>
    ///   <para>rdfs:label : Activity^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-Activity^^xsd:anyURI</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-Activity^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#Activity">prov:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : ActivityInfluence^^xsd:string</para>
    ///   <para>prov:editorsDefinition : ActivitiyInfluence is the capacity of an activity to have an effect on the character, development, or behavior of another by means of generation, invalidation, communication, or other.</para>
    ///   <para>rdfs:comment : It is not recommended that the type ActivityInfluence be asserted without also asserting one of its more specific subclasses.rdfs:comment : ActivityInfluence provides additional descriptions of an Activity's binary influence upon any other kind of resource. Instances of ActivityInfluence use the prov:activity property to cite the influencing Activity.</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#ActivityInfluence">prov:ActivityInfluence</a>
    /// </summary>
    let ActivityInfluence = _prefixId.prefix "ActivityInfluence"
    /// <summary>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-Agent^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-agent^^xsd:anyURI</para>
    ///   <para>prov:definition : An agent is something that bears some form of responsibility for an activity taking place, for the existence of an entity, or for another agent's activity. </para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Agent">prov:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>prov:editorsDefinition : AgentInfluence is the capacity of an agent to have an effect on the character, development, or behavior of another by means of attribution, association, delegation, or other.</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:label : AgentInfluence^^xsd:string</para>
    ///   <para>rdfs:comment : AgentInfluence provides additional descriptions of an Agent's binary influence upon any other kind of resource. Instances of AgentInfluence use the prov:agent property to cite the influencing Agent.rdfs:comment : It is not recommended that the type AgentInfluence be asserted without also asserting one of its more specific subclasses.</para>
    ///   <a href="http://www.w3.org/ns/prov#AgentInfluence">prov:AgentInfluence</a>
    /// </summary>
    let AgentInfluence = _prefixId.prefix "AgentInfluence"
    /// <summary>
    ///   <para>prov:definition : An activity association is an assignment of responsibility to an agent for an activity, indicating that the agent had a role in the activity. It further allows for a plan to be specified, which is the plan intended by the agent to achieve some goals in the context of this activity.</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:label : Association^^xsd:string</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-Association^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-Association^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An instance of prov:Association provides additional descriptions about the binary prov:wasAssociatedWith relation from an prov:Activity to some prov:Agent that had some responsiblity for it. For example, :baking prov:wasAssociatedWith :baker; prov:qualifiedAssociation [ a prov:Association; prov:agent :baker; :foo :bar ].</para>
    ///   <a href="http://www.w3.org/ns/prov#Association">prov:Association</a>
    /// </summary>
    let Association = _prefixId.prefix "Association"
    /// <summary>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-attribution^^xsd:anyURI</para>
    ///   <para>rdfs:label : Attribution^^xsd:string</para>
    ///   <para>rdfs:comment : An instance of prov:Attribution provides additional descriptions about the binary prov:wasAttributedTo relation from an prov:Entity to some prov:Agent that had some responsible for it. For example, :cake prov:wasAttributedTo :baker; prov:qualifiedAttribution [ a prov:Attribution; prov:entity :baker; :foo :bar ].</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-attribution^^xsd:anyURI</para>
    ///   <para>prov:definition : Attribution is the ascribing of an entity to an agent.
    ///
    /// When an entity e is attributed to agent ag, entity e was generated by some unspecified activity that in turn was associated to agent ag. Thus, this relation is useful when the activity is not known, or irrelevant.</para>
    ///   <a href="http://www.w3.org/ns/prov#Attribution">prov:Attribution</a>
    /// </summary>
    let Attribution = _prefixId.prefix "Attribution"
    /// <summary>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-bundle-declaration^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-bundle-entity^^xsd:anyURI</para>
    ///   <para>prov:definition : A bundle is a named set of provenance descriptions, and is itself an Entity, so allowing provenance of provenance to be expressed.</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : Bundle^^xsd:string</para>
    ///   <para>rdfs:comment : Note that there are kinds of bundles (e.g. handwritten letters, audio recordings, etc.) that are not expressed in PROV-O, but can be still be described by PROV-O.</para>
    ///   <a href="http://www.w3.org/ns/prov#Bundle">prov:Bundle</a>
    /// </summary>
    let Bundle = _prefixId.prefix "Bundle"
    /// <summary>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-collection^^xsd:anyURI</para>
    ///   <para>prov:definition : A collection is an entity that provides a structure to some constituents, which are themselves entities. These constituents are said to be member of the collections.</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : Collection^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Collection">prov:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An instance of prov:Communication provides additional descriptions about the binary prov:wasInformedBy relation from an informed prov:Activity to the prov:Activity that informed it. For example, :you_jumping_off_bridge prov:wasInformedBy :everyone_else_jumping_off_bridge; prov:qualifiedCommunication [ a prov:Communication; prov:activity :everyone_else_jumping_off_bridge; :foo :bar ].</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:definition : Communication is the exchange of an entity by two activities, one activity using the entity generated by the other.^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-wasInformedBy^^xsd:anyURI</para>
    ///   <para>rdfs:label : Communication^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-Communication^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#Communication">prov:Communication</a>
    /// </summary>
    let Communication = _prefixId.prefix "Communication"
    /// <summary>
    ///   <para>prov:definition : Activity that identifies any contribution of an agent to a resource. </para>
    ///   <para>rdfs:label : Contribute
    /// </para>
    ///   <a href="http://www.w3.org/ns/prov#Contribute">prov:Contribute</a>
    /// </summary>
    let Contribute = _prefixId.prefix "Contribute"
    /// <summary>
    ///   <para>prov:definition : Role with the function of having responsibility for making contributions to a resource. The Agent assigned to this role is associated with a Modify or Create Activities</para>
    ///   <para>rdfs:label : Contributor</para>
    ///   <a href="http://www.w3.org/ns/prov#Contributor">prov:Contributor</a>
    /// </summary>
    let Contributor = _prefixId.prefix "Contributor"
    /// <summary>
    ///   <para>prov:definition : Activity that identifies the Copyrighting activity associated to a resource.</para>
    ///   <para>rdfs:label : Copyright</para>
    ///   <a href="http://www.w3.org/ns/prov#Copyright">prov:Copyright</a>
    /// </summary>
    let Copyright = _prefixId.prefix "Copyright"
    /// <summary>
    ///   <para>prov:definition : Activity that identifies the creation of a resource</para>
    ///   <para>rdfs:label : Create</para>
    ///   <a href="http://www.w3.org/ns/prov#Create">prov:Create</a>
    /// </summary>
    let Create = _prefixId.prefix "Create"
    /// <summary>
    ///   <para>prov:definition : Role with the function of creating a resource. The Agent assigned to this role is associated with a Create Activity</para>
    ///   <para>rdfs:label : Creator</para>
    ///   <a href="http://www.w3.org/ns/prov#Creator">prov:Creator</a>
    /// </summary>
    let Creator = _prefixId.prefix "Creator"
    /// <summary>
    ///   <para>rdfs:comment : An instance of prov:Delegation provides additional descriptions about the binary prov:actedOnBehalfOf relation from a performing prov:Agent to some prov:Agent for whom it was performed. For example, :mixing prov:wasAssociatedWith :toddler . :toddler prov:actedOnBehalfOf :mother; prov:qualifiedDelegation [ a prov:Delegation; prov:entity :mother; :foo :bar ].</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:definition : Delegation is the assignment of authority and responsibility to an agent (by itself or by another agent) to carry out a specific activity as a delegate or representative, while the agent it acts on behalf of retains some responsibility for the outcome of the delegated work.
    ///
    /// For example, a student acted on behalf of his supervisor, who acted on behalf of the department chair, who acted on behalf of the university; all those agents are responsible in some way for the activity that took place but we do not say explicitly who bears responsibility and to what degree.</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-delegation^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-delegation^^xsd:anyURI</para>
    ///   <para>rdfs:label : Delegation^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Delegation">prov:Delegation</a>
    /// </summary>
    let Delegation = _prefixId.prefix "Delegation"
    /// <summary>
    ///   <para>prov:definition : A derivation is a transformation of an entity into another, an update of an entity resulting in a new one, or the construction of a new entity based on a pre-existing entity.</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:comment : An instance of prov:Derivation provides additional descriptions about the binary prov:wasDerivedFrom relation from some derived prov:Entity to another prov:Entity from which it was derived. For example, :chewed_bubble_gum prov:wasDerivedFrom :unwrapped_bubble_gum; prov:qualifiedDerivation [ a prov:Derivation; prov:entity :unwrapped_bubble_gum; :foo :bar ].rdfs:comment : The more specific forms of prov:Derivation (i.e., prov:Revision, prov:Quotation, prov:PrimarySource) should be asserted if they apply.</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#Derivation-Relation^^xsd:anyURI</para>
    ///   <para>rdfs:label : Derivation^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-Derivation^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#Derivation">prov:Derivation</a>
    /// </summary>
    let Derivation = _prefixId.prefix "Derivation"
    /// <summary>
    ///   <para>rdfs:comment : This concept allows for the provenance of the dictionary, but also of its constituents to be expressed. Such a notion of dictionary corresponds to a wide variety of concrete data structures, such as a maps or associative arrays.^^xsd:stringrdfs:comment : A given dictionary forms a given structure for its members. A different structure (obtained either by insertion or removal of members) constitutes a different dictionary.^^xsd:string</para>
    ///   <para>prov:definition : A dictionary is an entity that provides a structure to some constituents, which are themselves entities. These constituents are said to be member of the dictionary.^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>rdfs:label : Dictionary^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary^^xsd:anyURI</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-conceptual-definition^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#Dictionary">prov:Dictionary</a>
    /// </summary>
    let Dictionary = _prefixId.prefix "Dictionary"
    /// <summary>
    ///   <para>prov:category : access-and-query^^xsd:string</para>
    ///   <para>prov:aq : http://www.w3.org/TR/2013/NOTE-prov-aq-20130430/#provenance-query-service-discovery^^xsd:anyURI</para>
    ///   <para>rdfs:label : ProvenanceService^^xsd:string</para>
    ///   <para>rdfs:comment : Type for a generic provenance query service. Mainly for use in RDF provenance query service descriptions, to facilitate discovery in linked data environments.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#DirectQueryService">prov:DirectQueryService</a>
    /// </summary>
    let DirectQueryService = _prefixId.prefix "DirectQueryService"
    /// <summary>
    ///   <para>prov:definition : An empty collection is a collection without members.</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : EmptyCollection</para>
    ///   <a href="http://www.w3.org/ns/prov#EmptyCollection">prov:EmptyCollection</a>
    /// </summary>
    let EmptyCollection = _prefixId.prefix "EmptyCollection"
    /// <summary>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-conceptual-definition^^xsd:anyURI</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>prov:definition : An empty dictionary (i.e. has no members).^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary^^xsd:anyURI</para>
    ///   <para>rdfs:label : Empty Dictionary^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#EmptyDictionary">prov:EmptyDictionary</a>
    /// </summary>
    let EmptyDictionary = _prefixId.prefix "EmptyDictionary"
    /// <summary>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-End^^xsd:anyURI</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-End^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An instance of prov:End provides additional descriptions about the binary prov:wasEndedBy relation from some ended prov:Activity to an prov:Entity that ended it. For example, :ball_game prov:wasEndedBy :buzzer; prov:qualifiedEnd [ a prov:End; prov:entity :buzzer; :foo :bar; prov:atTime '2012-03-09T08:05:08-05:00'^^xsd:dateTime ].</para>
    ///   <para>rdfs:label : End^^xsd:string</para>
    ///   <para>prov:definition : End is when an activity is deemed to have been ended by an entity, known as trigger. The activity no longer exists after its end. Any usage, generation, or invalidation involving an activity precedes the activity's end. An end may refer to a trigger entity that terminated the activity, or to an activity, known as ender that generated the trigger.</para>
    ///   <a href="http://www.w3.org/ns/prov#End">prov:End</a>
    /// </summary>
    let End = _prefixId.prefix "End"
    /// <summary>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>rdfs:label : Entity^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-entity^^xsd:anyURI</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-Entity^^xsd:anyURI</para>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:definition : An entity is a physical, digital, conceptual, or other kind of thing with some fixed aspects; entities may be real or imaginary. </para>
    ///   <a href="http://www.w3.org/ns/prov#Entity">prov:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>prov:editorsDefinition : EntityInfluence is the capacity of an entity to have an effect on the character, development, or behavior of another by means of usage, start, end, derivation, or other. </para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:label : EntityInfluence^^xsd:string</para>
    ///   <para>rdfs:comment : EntityInfluence provides additional descriptions of an Entity's binary influence upon any other kind of resource. Instances of EntityInfluence use the prov:entity property to cite the influencing Entity.rdfs:comment : It is not recommended that the type EntityInfluence be asserted without also asserting one of its more specific subclasses.</para>
    ///   <a href="http://www.w3.org/ns/prov#EntityInfluence">prov:EntityInfluence</a>
    /// </summary>
    let EntityInfluence = _prefixId.prefix "EntityInfluence"
    /// <summary>
    ///   <para>prov:definition : Generation is the completion of production of a new entity by an activity. This entity did not exist before generation and becomes available for usage after this generation.</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-Generation^^xsd:anyURI</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>rdfs:label : Generation^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-Generation^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An instance of prov:Generation provides additional descriptions about the binary prov:wasGeneratedBy relation from a generated prov:Entity to the prov:Activity that generated it. For example, :cake prov:wasGeneratedBy :baking; prov:qualifiedGeneration [ a prov:Generation; prov:activity :baking; :foo :bar ].</para>
    ///   <a href="http://www.w3.org/ns/prov#Generation">prov:Generation</a>
    /// </summary>
    let Generation = _prefixId.prefix "Generation"
    /// <summary>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>rdfs:label : Influence^^xsd:string</para>
    ///   <para>prov:definition : Influence is the capacity of an entity, activity, or agent to have an effect on the character, development, or behavior of another by means of usage, start, end, generation, invalidation, communication, derivation, attribution, association, or delegation.</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-influence^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An instance of prov:Influence provides additional descriptions about the binary prov:wasInfluencedBy relation from some influenced Activity, Entity, or Agent to the influencing Activity, Entity, or Agent. For example, :stomach_ache prov:wasInfluencedBy :spoon; prov:qualifiedInfluence [ a prov:Influence; prov:entity :spoon; :foo :bar ] . Because prov:Influence is a broad relation, the more specific relations (Communication, Delegation, End, etc.) should be used when applicable.rdfs:comment : Because prov:Influence is a broad relation, its most specific subclasses (e.g. prov:Communication, prov:Delegation, prov:End, prov:Revision, etc.) should be used when applicable.</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-influence^^xsd:anyURI</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Influence">prov:Influence</a>
    /// </summary>
    let Influence = _prefixId.prefix "Influence"
    /// <summary>
    ///   <para>rdfs:label : Insertion^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>prov:definition : Insertion is a derivation that transforms a dictionary into another, by insertion of one or more key-entity pairs.^^xsd:string</para>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-insertion^^xsd:anyURI</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-insertion^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#Insertion">prov:Insertion</a>
    /// </summary>
    let Insertion = _prefixId.prefix "Insertion"
    /// <summary>
    ///   <para>prov:definition : The PROV data model is implicitly based on a notion of instantaneous events (or just events), that mark transitions in the world. Events include generation, usage, or invalidation of entities, as well as starting or ending of activities. This notion of event is not first-class in the data model, but it is useful for explaining its other concepts and its semantics.</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#dfn-event^^xsd:anyURI</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:label : InstantaneousEvent^^xsd:string</para>
    ///   <para>rdfs:comment : An instantaneous event, or event for short, happens in the world and marks a change in the world, in its activities and in its entities. The term 'event' is commonly used in process algebra with a similar meaning. Events represent communications or interactions; they are assumed to be atomic and instantaneous.</para>
    ///   <a href="http://www.w3.org/ns/prov#InstantaneousEvent">prov:InstantaneousEvent</a>
    /// </summary>
    let InstantaneousEvent = _prefixId.prefix "InstantaneousEvent"
    /// <summary>
    ///   <para>rdfs:comment : An instance of prov:Invalidation provides additional descriptions about the binary prov:wasInvalidatedBy relation from an invalidated prov:Entity to the prov:Activity that invalidated it. For example, :uncracked_egg prov:wasInvalidatedBy :baking; prov:qualifiedInvalidation [ a prov:Invalidation; prov:activity :baking; :foo :bar ].</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-Invalidation^^xsd:anyURI</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>rdfs:label : Invalidation^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-Invalidation^^xsd:anyURI</para>
    ///   <para>prov:definition : Invalidation is the start of the destruction, cessation, or expiry of an existing entity by an activity. The entity is no longer available for use (or further invalidation) after invalidation. Any generation or usage of an entity precedes its invalidation.^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Invalidation">prov:Invalidation</a>
    /// </summary>
    let Invalidation = _prefixId.prefix "Invalidation"
    /// <summary>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>rdfs:label : Key-Entity Pair^^xsd:string</para>
    ///   <para>prov:definition : A key-entity pair. Part of a prov:Dictionary through prov:hadDictionaryMember. The key is any RDF Literal, the value is a prov:Entity.^^xsd:string</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-membership^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-membership^^xsd:anyURI</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#KeyEntityPair">prov:KeyEntityPair</a>
    /// </summary>
    let KeyEntityPair = _prefixId.prefix "KeyEntityPair"
    /// <summary>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-attribute^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-attribute-location^^xsd:anyURI</para>
    ///   <para>prov:definition : A location can be an identifiable geographic place (ISO 19112), but it can also be a non-geographic place such as a directory, row, or column. As such, there are numerous ways in which location can be expressed, such as by a coordinate, address, landmark, and so forth.</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Location">prov:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>prov:definition : Activity that identifies the modification of a resource. </para>
    ///   <para>rdfs:label : Modify</para>
    ///   <a href="http://www.w3.org/ns/prov#Modify">prov:Modify</a>
    /// </summary>
    let Modify = _prefixId.prefix "Modify"
    /// <summary>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-types^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-agent^^xsd:anyURI</para>
    ///   <para>prov:definition : An organization is a social or legal institution such as a company, society, etc.^^xsd:string</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : Organization^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Organization">prov:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-types^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-agent^^xsd:anyURI</para>
    ///   <para>prov:definition : Person agents are people.</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Person">prov:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>prov:category : expanded^^xsd:stringprov:category : qualified^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-Association^^xsd:anyURI</para>
    ///   <para>rdfs:comment : There exist no prescriptive requirement on the nature of plans, their representation, the actions or steps they consist of, or their intended goals. Since plans may evolve over time, it may become necessary to track their provenance, so plans themselves are entities. Representing the plan explicitly in the provenance can be useful for various tasks: for example, to validate the execution as represented in the provenance record, to manage expectation failures, or to provide explanations.</para>
    ///   <para>rdfs:label : Plan^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-Association^^xsd:anyURI</para>
    ///   <para>prov:definition : A plan is an entity that represents a set of actions or steps intended by one or more agents to achieve some goals.^^xsd:string</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Plan">prov:Plan</a>
    /// </summary>
    let Plan = _prefixId.prefix "Plan"
    /// <summary>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-primary-source^^xsd:anyURI</para>
    ///   <para>rdfs:label : PrimarySource^^xsd:string</para>
    ///   <para>prov:definition : A primary source for a topic refers to something produced by some agent with direct experience and knowledge about the topic, at the time of the topic's study, without benefit from hindsight.
    ///
    /// Because of the directness of primary sources, they 'speak for themselves' in ways that cannot be captured through the filter of secondary sources. As such, it is important for secondary sources to reference those primary sources from which they were derived, so that their reliability can be investigated.
    ///
    /// A primary source relation is a particular case of derivation of secondary materials from their primary sources. It is recognized that the determination of primary sources can be up to interpretation, and should be done according to conventions accepted within the application's domain.</para>
    ///   <para>rdfs:comment : An instance of prov:PrimarySource provides additional descriptions about the binary prov:hadPrimarySource relation from some secondary prov:Entity to an earlier, primary prov:Entity. For example, :blog prov:hadPrimarySource :newsArticle; prov:qualifiedPrimarySource [ a prov:PrimarySource; prov:entity :newsArticle; :foo :bar ] .</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-original-source^^xsd:anyURI</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#PrimarySource">prov:PrimarySource</a>
    /// </summary>
    let PrimarySource = _prefixId.prefix "PrimarySource"
    /// <summary>
    ///   <para>prov:definition : Activity that identifies the publication of a resource</para>
    ///   <para>rdfs:label : Publish</para>
    ///   <a href="http://www.w3.org/ns/prov#Publish">prov:Publish</a>
    /// </summary>
    let Publish = _prefixId.prefix "Publish"
    /// <summary>
    ///   <para>prov:definition : Role with the function of publishing a resource. The Agent assigned to this role is associated with a Publish Activity</para>
    ///   <para>rdfs:label : Publisher</para>
    ///   <a href="http://www.w3.org/ns/prov#Publisher">prov:Publisher</a>
    /// </summary>
    let Publisher = _prefixId.prefix "Publisher"
    /// <summary>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:definition : A quotation is the repeat of (some or all of) an entity, such as text or image, by someone who may or may not be its original author. Quotation is a particular case of derivation.</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-quotation^^xsd:anyURI</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-quotation^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An instance of prov:Quotation provides additional descriptions about the binary prov:wasQuotedFrom relation from some taken prov:Entity from an earlier, larger prov:Entity. For example, :here_is_looking_at_you_kid prov:wasQuotedFrom :casablanca_script; prov:qualifiedQuotation [ a prov:Quotation; prov:entity :casablanca_script; :foo :bar ].</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>rdfs:label : Quotation^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Quotation">prov:Quotation</a>
    /// </summary>
    let Quotation = _prefixId.prefix "Quotation"
    /// <summary>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>prov:definition : Removal is a derivation that transforms a dictionary into another, by removing one or more key-entity pairs.^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-removal^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-removal^^xsd:anyURI</para>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>rdfs:label : Removal^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Removal">prov:Removal</a>
    /// </summary>
    let Removal = _prefixId.prefix "Removal"
    /// <summary>
    ///   <para>prov:definition : Activity that identifies the replacement of a resource.</para>
    ///   <para>rdfs:label : Replace</para>
    ///   <a href="http://www.w3.org/ns/prov#Replace">prov:Replace</a>
    /// </summary>
    let Replace = _prefixId.prefix "Replace"
    /// <summary>
    ///   <para>rdfs:comment : An instance of prov:Revision provides additional descriptions about the binary prov:wasRevisionOf relation from some newer prov:Entity to an earlier prov:Entity. For example, :draft_2 prov:wasRevisionOf :draft_1; prov:qualifiedRevision [ a prov:Revision; prov:entity :draft_1; :foo :bar ].</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-revision^^xsd:anyURI</para>
    ///   <para>prov:definition : A revision is a derivation for which the resulting entity is a revised version of some original. The implication here is that the resulting entity contains substantial content from the original. Revision is a particular case of derivation.</para>
    ///   <para>rdfs:label : Revision^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-Revision^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#Revision">prov:Revision</a>
    /// </summary>
    let Revision = _prefixId.prefix "Revision"
    /// <summary>
    ///   <para>prov:definition : Activity that identifies the rights assignment of a resource.</para>
    ///   <para>rdfs:label : RightsAssignment</para>
    ///   <a href="http://www.w3.org/ns/prov#RightsAssignment">prov:RightsAssignment</a>
    /// </summary>
    let RightsAssignment = _prefixId.prefix "RightsAssignment"
    /// <summary>
    ///   <para>prov:definition : Role with the function of owning or managing rights over a resource. The Agent assigned to this role is associated with a RightsAssignment Activity</para>
    ///   <para>rdfs:label : RightsHolder</para>
    ///   <a href="http://www.w3.org/ns/prov#RightsHolder">prov:RightsHolder</a>
    /// </summary>
    let RightsHolder = _prefixId.prefix "RightsHolder"
    /// <summary>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-attribute^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-attribute-role^^xsd:anyURI</para>
    ///   <para>prov:definition : A role is the function of an entity or agent with respect to an activity, in the context of a usage, generation, invalidation, association, start, and end.</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#Role">prov:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>prov:category : access-and-query^^xsd:string</para>
    ///   <para>prov:aq : http://www.w3.org/TR/2013/NOTE-prov-aq-20130430/#provenance-query-service-discovery^^xsd:anyURI</para>
    ///   <para>rdfs:label : ServiceDescription^^xsd:string</para>
    ///   <para>rdfs:comment : Type for a generic provenance query service. Mainly for use in RDF provenance query service descriptions, to facilitate discovery in linked data environments.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#ServiceDescription">prov:ServiceDescription</a>
    /// </summary>
    let ServiceDescription = _prefixId.prefix "ServiceDescription"
    /// <summary>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>rdfs:label : SoftwareAgent^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-agent^^xsd:anyURIprov:dm : http://www.w3.org/TR/2012/WD-prov-dm-20120703/prov-dm.html#term-agent^^xsd:anyURI</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-types^^xsd:anyURIprov:n : http://www.w3.org/TR/2012/WD-prov-dm-20120703/prov-n.html#expression-types^^xsd:anyURI</para>
    ///   <para>prov:definition : A software agent is running software.</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#SoftwareAgent">prov:SoftwareAgent</a>
    /// </summary>
    let SoftwareAgent = _prefixId.prefix "SoftwareAgent"
    /// <summary>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>prov:definition : Start is when an activity is deemed to have been started by an entity, known as trigger. The activity did not exist before its start. Any usage, generation, or invalidation involving an activity follows the activity's start. A start may refer to a trigger entity that set off the activity, or to an activity, known as starter, that generated the trigger.</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>rdfs:comment : An instance of prov:Start provides additional descriptions about the binary prov:wasStartedBy relation from some started prov:Activity to an prov:Entity that started it. For example, :foot_race prov:wasStartedBy :bang; prov:qualifiedStart [ a prov:Start; prov:entity :bang; :foo :bar; prov:atTime '2012-03-09T08:05:08-05:00'^^xsd:dateTime ] .</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-Start^^xsd:anyURI</para>
    ///   <para>rdfs:label : Start^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-Start^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#Start">prov:Start</a>
    /// </summary>
    let Start = _prefixId.prefix "Start"
    /// <summary>
    ///   <para>prov:definition : Activity that identifies the issuance (e.g., publication) of a resource. </para>
    ///   <para>rdfs:label : Submit</para>
    ///   <a href="http://www.w3.org/ns/prov#Submit">prov:Submit</a>
    /// </summary>
    let Submit = _prefixId.prefix "Submit"
    /// <summary>
    ///   <para>rdfs:label : Usage^^xsd:string</para>
    ///   <para>rdfs:comment : An instance of prov:Usage provides additional descriptions about the binary prov:used relation from some prov:Activity to an prov:Entity that it used. For example, :keynote prov:used :podium; prov:qualifiedUsage [ a prov:Usage; prov:entity :podium; :foo :bar ].</para>
    ///   <para>prov:definition : Usage is the beginning of utilizing an entity by an activity. Before usage, the activity had not begun to utilize this entity and could not have been affected by the entity.</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-Usage^^xsd:anyURI</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-Usage^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#Usage">prov:Usage</a>
    /// </summary>
    let Usage = _prefixId.prefix "Usage"
    /// <summary>
    ///   <para>rdfs:comment : An object property to express the accountability of an agent towards another agent. The subordinate agent acted on behalf of the responsible agent in an actual activity. </para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>rdfs:label : actedOnBehalfOf^^xsd:string</para>
    ///   <para>prov:inverse : hadDelegate^^xsd:string</para>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#actedOnBehalfOf">prov:actedOnBehalfOf</a>
    /// </summary>
    let actedOnBehalfOf = _prefixId.prefix "actedOnBehalfOf"
    /// <summary>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:inverse : activityOfInfluence^^xsd:string</para>
    ///   <para>prov:editorialNote : This property behaves in spirit like rdf:object; it references the object of a prov:wasInfluencedBy triple.</para>
    ///   <para>prov:editorsDefinition : The prov:activity property references an prov:Activity which influenced a resource. This property applies to an prov:ActivityInfluence, which is given by a subproperty of prov:qualifiedInfluence from the influenced prov:Entity, prov:Activity or prov:Agent.^^xsd:string</para>
    ///   <para>rdfs:label : activity^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#activity">prov:activity</a>
    /// </summary>
    let activity = _prefixId.prefix "activity"
    let activityOfInfluence = _prefixId.prefix "activityOfInfluence"
    /// <summary>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:editorsDefinition : The prov:agent property references an prov:Agent which influenced a resource. This property applies to an prov:AgentInfluence, which is given by a subproperty of prov:qualifiedInfluence from the influenced prov:Entity, prov:Activity or prov:Agent.</para>
    ///   <para>prov:editorialNote : This property behaves in spirit like rdf:object; it references the object of a prov:wasInfluencedBy triple.</para>
    ///   <para>prov:inverse : agentOfInfluence^^xsd:string</para>
    ///   <para>rdfs:label : agent^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#agent">prov:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    let agentOfInfluence = _prefixId.prefix "agentOfInfluence"
    /// <summary>
    ///   <para>prov:inverse : alternateOf^^xsd:string</para>
    ///   <para>prov:component : alternate^^xsd:string</para>
    ///   <para>prov:definition : Two alternate entities present aspects of the same thing. These aspects may be the same or different, and the alternate entities may or may not overlap in time.</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-alternate^^xsd:anyURI</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-alternate^^xsd:anyURI</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : alternateOf^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#alternateOf">prov:alternateOf</a>
    /// </summary>
    let alternateOf = _prefixId.prefix "alternateOf"
    let aq = _prefixId.prefix "aq"
    /// <summary>
    ///   <para>prov:inverse : contextOf^^xsd:string</para>
    ///   <para>rdfs:label : asInBundle^^xsd:string</para>
    ///   <para>rdfs:comment : prov:asInBundle is used to specify which bundle the general entity of a prov:mentionOf property is described.
    ///
    /// When :x prov:mentionOf :y and :y is described in Bundle :b, the triple :x prov:asInBundle :b is also asserted to cite the Bundle in which :y was described.</para>
    ///   <a href="http://www.w3.org/ns/prov#asInBundle">prov:asInBundle</a>
    /// </summary>
    let asInBundle = _prefixId.prefix "asInBundle"
    /// <summary>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:comment : The Location of any resource.rdfs:comment : This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.^^xsd:string</para>
    ///   <para>prov:inverse : locationOf^^xsd:string</para>
    ///   <para>prov:editorialNote : This property is not functional because the many values could be at a variety of granularies (In this building, in this room, in that chair).prov:editorialNote : The naming of prov:atLocation parallels prov:atTime, and is not named prov:hadLocation to avoid conflicting with the convention that prov:had* properties are used on prov:Influence classes.</para>
    ///   <para>rdfs:label : atLocation^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#atLocation">prov:atLocation</a>
    /// </summary>
    let atLocation = _prefixId.prefix "atLocation"
    /// <summary>
    ///   <para>rdfs:label : atTime^^xsd:string</para>
    ///   <para>rdfs:comment : The time at which an InstantaneousEvent occurred, in the form of xsd:dateTime.</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#atTime">prov:atTime</a>
    /// </summary>
    let atTime = _prefixId.prefix "atTime"
    /// <summary>
    ///   <para>rdfs:comment : Classify prov-o terms into three categories, including 'starting-point', 'qualifed', and 'extended'. This classification is used by the prov-o html document to gently introduce prov-o terms to its users. </para>
    ///   <a href="http://www.w3.org/ns/prov#category">prov:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:comment : Classify prov-o terms into six components according to prov-dm, including 'agents-responsibility', 'alternate', 'annotations', 'collections', 'derivations', and 'entities-activities'. This classification is used so that readers of prov-o specification can find its correspondence with the prov-dm specification.</para>
    ///   <a href="http://www.w3.org/ns/prov#component">prov:component</a>
    /// </summary>
    let component_ = _prefixId.prefix "component"
    /// <summary>
    ///   <para>rdfs:comment : A reference to the principal section of the PROV-CONSTRAINTS document that describes this concept.</para>
    ///   <a href="http://www.w3.org/ns/prov#constraints">prov:constraints</a>
    /// </summary>
    let constraints = _prefixId.prefix "constraints"
    let contributed = _prefixId.prefix "contributed"
    /// <summary>
    ///   <para>rdfs:comment : A definition quoted from PROV-DM or PROV-CONSTRAINTS that describes the concept expressed with this OWL term.</para>
    ///   <a href="http://www.w3.org/ns/prov#definition">prov:definition</a>
    /// </summary>
    let definition = _prefixId.prefix "definition"
    /// <summary>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-insertion^^xsd:anyURI</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-insertion^^xsd:anyURI</para>
    ///   <para>prov:definition : The dictionary was derived from the other by insertion. prov:qualifiedInsertion shows details of the insertion, in particular the inserted key-entity pairs.^^xsd:string</para>
    ///   <para>rdfs:label : derivedByInsertionFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#derivedByInsertionFrom">prov:derivedByInsertionFrom</a>
    /// </summary>
    let derivedByInsertionFrom = _prefixId.prefix "derivedByInsertionFrom"
    /// <summary>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:definition : The dictionary was derived from the other by removal. prov:qualifiedRemoval shows details of the removal, in particular the removed key-entity pairs.^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-removal^^xsd:anyURI</para>
    ///   <para>rdfs:label : derivedByRemovalFrom^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-removal^^xsd:anyURI</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#derivedByRemovalFrom">prov:derivedByRemovalFrom</a>
    /// </summary>
    let derivedByRemovalFrom = _prefixId.prefix "derivedByRemovalFrom"
    /// <summary>
    ///   <para>prov:inverse : serviceDescribedBy^^xsd:string</para>
    ///   <para>prov:category : access-and-query^^xsd:string</para>
    ///   <para>prov:aq : http://www.w3.org/TR/2013/NOTE-prov-aq-20130430/rovenance-query-service-description^^xsd:anyURI</para>
    ///   <para>rdfs:label : describesService^^xsd:string</para>
    ///   <para>rdfs:comment : relates a generic provenance query service resource (type prov:ServiceDescription) to a specific query service description (e.g. a prov:DirectQueryService or a sd:Service).</para>
    ///   <a href="http://www.w3.org/ns/prov#describesService">prov:describesService</a>
    /// </summary>
    let describesService = _prefixId.prefix "describesService"
    /// <summary>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-removal^^xsd:anyURIprov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-insertion^^xsd:anyURI</para>
    ///   <para>prov:definition : The property used by a prov:Insertion and prov:Removal to cite the prov:Dictionary that was prov:derivedByInsertionFrom or prov:derivedByRemovalFrom another dictionary.^^xsd:string</para>
    ///   <para>rdfs:label : dictionary^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-removal^^xsd:anyURIprov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-insertion^^xsd:anyURI</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#dictionary">prov:dictionary</a>
    /// </summary>
    let dictionary = _prefixId.prefix "dictionary"
    /// <summary>
    ///   <para>rdfs:comment : A reference to the principal section of the PROV-DM document that describes this concept.</para>
    ///   <a href="http://www.w3.org/ns/prov#dm">prov:dm</a>
    /// </summary>
    let dm = _prefixId.prefix "dm"
    /// <summary>
    ///   <para>rdfs:comment : A note by the OWL development team about how this term expresses the PROV-DM concept, or how it should be used in context of semantic web or linked data.</para>
    ///   <a href="http://www.w3.org/ns/prov#editorialNote">prov:editorialNote</a>
    /// </summary>
    let editorialNote = _prefixId.prefix "editorialNote"
    /// <summary>
    ///   <para>rdfs:comment : When the prov-o term does not have a definition drawn from prov-dm, and the prov-o editor provides one.</para>
    ///   <a href="http://www.w3.org/ns/prov#editorsDefinition">prov:editorsDefinition</a>
    /// </summary>
    let editorsDefinition = _prefixId.prefix "editorsDefinition"
    let ended = _prefixId.prefix "ended"
    /// <summary>
    ///   <para>prov:editorialNote : It is the intent that the property chain holds: (prov:qualifiedEnd o prov:atTime) rdfs:subPropertyOf prov:endedAtTime.</para>
    ///   <para>rdfs:comment : The time at which an activity ended. See also prov:startedAtTime.</para>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>rdfs:label : endedAtTime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#endedAtTime">prov:endedAtTime</a>
    /// </summary>
    let endedAtTime = _prefixId.prefix "endedAtTime"
    /// <summary>
    ///   <para>prov:inverse : entityOfInfluence^^xsd:string</para>
    ///   <para>prov:editorialNote : This property behaves in spirit like rdf:object; it references the object of a prov:wasInfluencedBy triple.</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:editorsDefinition : The prov:entity property references an prov:Entity which influenced a resource. This property applies to an prov:EntityInfluence, which is given by a subproperty of prov:qualifiedInfluence from the influenced prov:Entity, prov:Activity or prov:Agent.^^xsd:string</para>
    ///   <para>rdfs:label : entity^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#entity">prov:entity</a>
    /// </summary>
    let entity = _prefixId.prefix "entity"
    let entityOfInfluence = _prefixId.prefix "entityOfInfluence"
    let generalizationOf = _prefixId.prefix "generalizationOf"
    /// <summary>
    ///   <para>prov:editorialNote : prov:generated is one of few inverse property defined, to allow Activity-oriented assertions in addition to Entity-oriented assertions.</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>prov:inverse : wasGeneratedBy^^xsd:string</para>
    ///   <para>rdfs:label : generated^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#generated">prov:generated</a>
    /// </summary>
    let generated = _prefixId.prefix "generated"
    let generatedAsDerivation = _prefixId.prefix "generatedAsDerivation"
    /// <summary>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>rdfs:comment : The time at which an entity was completely created and is available for use.</para>
    ///   <para>prov:editorialNote : It is the intent that the property chain holds: (prov:qualifiedGeneration o prov:atTime) rdfs:subPropertyOf prov:generatedAtTime.</para>
    ///   <para>rdfs:label : generatedAtTime^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#generatedAtTime">prov:generatedAtTime</a>
    /// </summary>
    let generatedAtTime = _prefixId.prefix "generatedAtTime"
    /// <summary>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:label : hadActivity^^xsd:string</para>
    ///   <para>rdfs:comment : The _optional_ Activity of an Influence, which used, generated, invalidated, or was the responsibility of some Entity. This property is _not_ used by ActivityInfluence (use prov:activity instead).rdfs:comment : This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.^^xsd:string</para>
    ///   <para>prov:inverse : wasActivityOfInfluence^^xsd:string</para>
    ///   <para>prov:editorialNote : The multiple rdfs:domain assertions are intended. One is simpler and works for OWL-RL, the union is more specific but is not recognized by OWL-RL.</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#hadActivity">prov:hadActivity</a>
    /// </summary>
    let hadActivity = _prefixId.prefix "hadActivity"
    let hadDelegate = _prefixId.prefix "hadDelegate"
    let hadDerivation = _prefixId.prefix "hadDerivation"
    /// <summary>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-membership^^xsd:anyURI</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>rdfs:label : hadDictionaryMember^^xsd:string</para>
    ///   <para>prov:definition : Describes the key-entity pair that was member of a prov:Dictionary. A dictionary can have multiple members.^^xsd:string</para>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-membership^^xsd:anyURI</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#hadDictionaryMember">prov:hadDictionaryMember</a>
    /// </summary>
    let hadDictionaryMember = _prefixId.prefix "hadDictionaryMember"
    /// <summary>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:label : hadGeneration^^xsd:string</para>
    ///   <para>prov:inverse : generatedAsDerivation^^xsd:string</para>
    ///   <para>rdfs:comment : The _optional_ Generation involved in an Entity's Derivation.</para>
    ///   <a href="http://www.w3.org/ns/prov#hadGeneration">prov:hadGeneration</a>
    /// </summary>
    let hadGeneration = _prefixId.prefix "hadGeneration"
    let hadInfluence = _prefixId.prefix "hadInfluence"
    /// <summary>
    ///   <para>prov:component : expanded^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : hadMember^^xsd:string</para>
    ///   <para>prov:inverse : wasMemberOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#hadMember">prov:hadMember</a>
    /// </summary>
    let hadMember = _prefixId.prefix "hadMember"
    /// <summary>
    ///   <para>rdfs:comment : The _optional_ Plan adopted by an Agent in Association with some Activity. Plan specifications are out of the scope of this specification.</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:label : hadPlan^^xsd:string</para>
    ///   <para>prov:inverse : wasPlanOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#hadPlan">prov:hadPlan</a>
    /// </summary>
    let hadPlan = _prefixId.prefix "hadPlan"
    /// <summary>
    ///   <para>prov:inverse : wasPrimarySourceOf^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>rdfs:label : hadPrimarySource^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#hadPrimarySource">prov:hadPrimarySource</a>
    /// </summary>
    let hadPrimarySource = _prefixId.prefix "hadPrimarySource"
    let hadRevision = _prefixId.prefix "hadRevision"
    /// <summary>
    ///   <para>prov:editorsDefinition : prov:hadRole references the Role (i.e. the function of an entity with respect to an activity), in the context of an instantaneous usage, generation, association, start, and end.</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:comment : The _optional_ Role that an Entity assumed in the context of an Activity. For example, :baking prov:used :spoon; prov:qualified [ a prov:Usage; prov:entity :spoon; prov:hadRole roles:mixing_implement ].rdfs:comment : This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : hadRole^^xsd:string</para>
    ///   <para>prov:inverse : wasRoleIn^^xsd:string</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#hadRole">prov:hadRole</a>
    /// </summary>
    let hadRole = _prefixId.prefix "hadRole"
    /// <summary>
    ///   <para>prov:inverse : wasUsedInDerivation^^xsd:string</para>
    ///   <para>rdfs:label : hadUsage^^xsd:string</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:comment : The _optional_ Usage involved in an Entity's Derivation.</para>
    ///   <a href="http://www.w3.org/ns/prov#hadUsage">prov:hadUsage</a>
    /// </summary>
    let hadUsage = _prefixId.prefix "hadUsage"
    /// <summary>
    ///   <para>prov:inverse : anchorOf^^xsd:string</para>
    ///   <para>prov:category : access-and-query^^xsd:string</para>
    ///   <para>prov:aq : http://www.w3.org/TR/2013/NOTE-prov-aq-20130430/#resource-represented-as-html^^xsd:anyURI</para>
    ///   <para>rdfs:label : has_anchor^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates anchor URI for a potentially dynamic resource instance.</para>
    ///   <a href="http://www.w3.org/ns/prov#has_anchor">prov:has_anchor</a>
    /// </summary>
    let has_anchor = _prefixId.prefix "has_anchor"
    /// <summary>
    ///   <para>prov:inverse : provenanceOf^^xsd:string</para>
    ///   <para>prov:category : access-and-query^^xsd:string</para>
    ///   <para>prov:aq : http://www.w3.org/TR/2013/NOTE-prov-aq-20130430/#resource-represented-as-html^^xsd:anyURI</para>
    ///   <para>rdfs:label : has_provenance^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a provenance-URI for a resource; the resource identified by this property presents a provenance record about its subject or anchor resource.</para>
    ///   <a href="http://www.w3.org/ns/prov#has_provenance">prov:has_provenance</a>
    /// </summary>
    let has_provenance = _prefixId.prefix "has_provenance"
    /// <summary>
    ///   <para>prov:inverse : provenanceQueryServiceOf^^xsd:string</para>
    ///   <para>prov:category : access-and-query^^xsd:string</para>
    ///   <para>prov:aq : http://www.w3.org/TR/2013/NOTE-prov-aq-20130430/^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasProvenanceService^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a provenance query service that can access provenance related to its subject or anchor resource.</para>
    ///   <a href="http://www.w3.org/ns/prov#has_query_service">prov:has_query_service</a>
    /// </summary>
    let has_query_service = _prefixId.prefix "has_query_service"
    /// <summary>
    ///   <para>prov:inverse : wasInfluencedBy^^xsd:string</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : influenced^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#influenced">prov:influenced</a>
    /// </summary>
    let influenced = _prefixId.prefix "influenced"
    /// <summary>
    ///   <para>rdfs:label : influencer^^xsd:string</para>
    ///   <para>prov:inverse : hadInfluence^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-influence^^xsd:anyURI</para>
    ///   <para>prov:editorsDefinition : This property is used as part of the qualified influence pattern. Subclasses of prov:Influence use these subproperties to reference the resource (Entity, Agent, or Activity) whose influence is being qualified.</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:comment : Subproperties of prov:influencer are used to cite the object of an unqualified PROV-O triple whose predicate is a subproperty of prov:wasInfluencedBy (e.g. prov:used, prov:wasGeneratedBy). prov:influencer is used much like rdf:object is used.</para>
    ///   <para>prov:editorialNote : This property and its subproperties are used in the same way as the rdf:object property, i.e. to reference the object of an unqualified prov:wasInfluencedBy or prov:influenced triple.</para>
    ///   <a href="http://www.w3.org/ns/prov#influencer">prov:influencer</a>
    /// </summary>
    let influencer = _prefixId.prefix "influencer"
    let informed = _prefixId.prefix "informed"
    /// <summary>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-insertion^^xsd:anyURI</para>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-insertion^^xsd:anyURI</para>
    ///   <para>prov:definition : An object property to refer to the prov:KeyEntityPair inserted into a prov:Dictionary.^^xsd:string</para>
    ///   <para>rdfs:label : insertedKeyEntityPair^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#insertedKeyEntityPair">prov:insertedKeyEntityPair</a>
    /// </summary>
    let insertedKeyEntityPair = _prefixId.prefix "insertedKeyEntityPair"
    /// <summary>
    ///   <para>prov:editorialNote : prov:invalidated is one of few inverse property defined, to allow Activity-oriented assertions in addition to Entity-oriented assertions.</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>rdfs:label : invalidated^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>prov:inverse : wasInvalidatedBy^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#invalidated">prov:invalidated</a>
    /// </summary>
    let invalidated = _prefixId.prefix "invalidated"
    /// <summary>
    ///   <para>rdfs:label : invalidatedAtTime^^xsd:string</para>
    ///   <para>rdfs:comment : The time at which an entity was invalidated (i.e., no longer usable).</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:editorialNote : It is the intent that the property chain holds: (prov:qualifiedInvalidation o prov:atTime) rdfs:subPropertyOf prov:invalidatedAtTime.</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#invalidatedAtTime">prov:invalidatedAtTime</a>
    /// </summary>
    let invalidatedAtTime = _prefixId.prefix "invalidatedAtTime"
    /// <summary>
    ///   <para>rdfs:comment : PROV-O does not define all property inverses. The directionalities defined in PROV-O should be given preference over those not defined. However, if users wish to name the inverse of a PROV-O property, the local name given by prov:inverse should be used.</para>
    ///   <a href="http://www.w3.org/ns/prov#inverse">prov:inverse</a>
    /// </summary>
    let inverse = _prefixId.prefix "inverse"
    let locationOf = _prefixId.prefix "locationOf"
    /// <summary>
    ///   <para>prov:inverse : hadMention^^xsd:string</para>
    ///   <para>rdfs:label : mentionOf^^xsd:string</para>
    ///   <para>rdfs:comment : prov:mentionOf is used to specialize an entity as described in another bundle. It is to be used in conjuction with prov:asInBundle.
    ///
    /// prov:asInBundle is used to cite the Bundle in which the generalization was mentioned.</para>
    ///   <a href="http://www.w3.org/ns/prov#mentionOf">prov:mentionOf</a>
    /// </summary>
    let mentionOf = _prefixId.prefix "mentionOf"
    /// <summary>
    ///   <para>rdfs:comment : A reference to the principal section of the PROV-DM document that describes this concept.rdfs:comment : A reference to the principal section of the PROV-M document that describes this concept.</para>
    ///   <a href="http://www.w3.org/ns/prov#n">prov:n</a>
    /// </summary>
    let n = _prefixId.prefix "n"
    /// <summary>
    ///   <para>rdfs:comment : The position that this OWL term should be listed within documentation. The scope of the documentation (e.g., among all terms, among terms within a prov:category, among properties applying to a particular class, etc.) is unspecified.</para>
    ///   <a href="http://www.w3.org/ns/prov#order">prov:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-membership^^xsd:anyURI</para>
    ///   <para>rdfs:label : pairKey^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-membership^^xsd:anyURI</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>prov:definition : The value of a KeyEntityPair.^^xsd:string</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#pairEntity">prov:pairEntity</a>
    /// </summary>
    let pairEntity = _prefixId.prefix "pairEntity"
    /// <summary>
    ///   <para>prov:definition : The key of a KeyEntityPair, which is an element of a prov:Dictionary.^^xsd:string</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-membership^^xsd:anyURI</para>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>rdfs:label : pairKey^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-membership^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#pairKey">prov:pairKey</a>
    /// </summary>
    let pairKey = _prefixId.prefix "pairKey"
    /// <summary>
    ///   <para>prov:category : access-and-query^^xsd:string</para>
    ///   <para>prov:aq : http://www.w3.org/TR/2013/NOTE-prov-aq-20130430/#provenance-pingback^^xsd:anyURI</para>
    ///   <para>rdfs:label : provenance pingback^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a resource to a provenance pingback service that may receive additional provenance links about the resource.</para>
    ///   <a href="http://www.w3.org/ns/prov#pingback">prov:pingback</a>
    /// </summary>
    let pingback = _prefixId.prefix "pingback"
    /// <summary>
    ///   <para>prov:category : access-and-query^^xsd:string</para>
    ///   <para>prov:aq : http://www.w3.org/TR/2013/NOTE-prov-aq-20130430/^^xsd:anyURI</para>
    ///   <para>rdfs:label : provenanceUriTemplate^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a provenance service to a URI template string for constructing provenance-URIs.</para>
    ///   <a href="http://www.w3.org/ns/prov#provenanceUriTemplate">prov:provenanceUriTemplate</a>
    /// </summary>
    let provenanceUriTemplate = _prefixId.prefix "provenanceUriTemplate"
    /// <summary>
    ///   <para>rdfs:comment : If this Activity prov:wasAssociatedWith Agent :ag, then it can qualify the Association using prov:qualifiedAssociation [ a prov:Association;  prov:agent :ag; :foo :bar ].</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedAssociation^^xsd:string</para>
    ///   <para>prov:inverse : qualifiedAssociationOf^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedAssociation">prov:qualifiedAssociation</a>
    /// </summary>
    let qualifiedAssociation = _prefixId.prefix "qualifiedAssociation"
    let qualifiedAssociationOf = _prefixId.prefix "qualifiedAssociationOf"
    /// <summary>
    ///   <para>prov:inverse : qualifiedAttributionOf^^xsd:string</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedAttribution^^xsd:string</para>
    ///   <para>rdfs:comment : If this Entity prov:wasAttributedTo Agent :ag, then it can qualify how it was influenced using prov:qualifiedAttribution [ a prov:Attribution;  prov:agent :ag; :foo :bar ].</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedAttribution">prov:qualifiedAttribution</a>
    /// </summary>
    let qualifiedAttribution = _prefixId.prefix "qualifiedAttribution"
    let qualifiedAttributionOf = _prefixId.prefix "qualifiedAttributionOf"
    /// <summary>
    ///   <para>prov:inverse : qualifiedCommunicationOf^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedCommunication^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>rdfs:comment : If this Activity prov:wasInformedBy Activity :a, then it can qualify how it was influenced using prov:qualifiedCommunication [ a prov:Communication;  prov:activity :a; :foo :bar ].</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedCommunication">prov:qualifiedCommunication</a>
    /// </summary>
    let qualifiedCommunication = _prefixId.prefix "qualifiedCommunication"
    let qualifiedCommunicationOf = _prefixId.prefix "qualifiedCommunicationOf"
    /// <summary>
    ///   <para>rdfs:label : qualifiedDelegation^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>rdfs:comment : If this Agent prov:actedOnBehalfOf Agent :ag, then it can qualify how with prov:qualifiedResponsibility [ a prov:Responsibility;  prov:agent :ag; :foo :bar ].</para>
    ///   <para>prov:inverse : qualifiedDelegationOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedDelegation">prov:qualifiedDelegation</a>
    /// </summary>
    let qualifiedDelegation = _prefixId.prefix "qualifiedDelegation"
    let qualifiedDelegationOf = _prefixId.prefix "qualifiedDelegationOf"
    /// <summary>
    ///   <para>prov:inverse : qualifiedDerivationOf^^xsd:string</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>rdfs:comment : If this Entity prov:wasDerivedFrom Entity :e, then it can qualify how it was derived using prov:qualifiedDerivation [ a prov:Derivation;  prov:entity :e; :foo :bar ].</para>
    ///   <para>rdfs:label : qualifiedDerivation^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedDerivation">prov:qualifiedDerivation</a>
    /// </summary>
    let qualifiedDerivation = _prefixId.prefix "qualifiedDerivation"
    let qualifiedDerivationOf = _prefixId.prefix "qualifiedDerivationOf"
    /// <summary>
    ///   <para>rdfs:label : qualifiedEnd^^xsd:string</para>
    ///   <para>prov:inverse : qualifiedEndOf^^xsd:string</para>
    ///   <para>rdfs:comment : If this Activity prov:wasEndedBy Entity :e1, then it can qualify how it was ended using prov:qualifiedEnd [ a prov:End;  prov:entity :e1; :foo :bar ].</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedEnd">prov:qualifiedEnd</a>
    /// </summary>
    let qualifiedEnd = _prefixId.prefix "qualifiedEnd"
    let qualifiedEndOf = _prefixId.prefix "qualifiedEndOf"
    /// <summary>
    ///   <para>rdfs:comment : This annotation property links a subproperty of prov:wasInfluencedBy with the subclass of prov:Influence and the qualifying property that are used to qualify it.
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
    /// Note how the value of the unqualified influence (prov:wasGeneratedBy :activity1) is mirrored as the value of the prov:activity (or prov:entity, or prov:agent) property on the influence class.</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedForm">prov:qualifiedForm</a>
    /// </summary>
    let qualifiedForm = _prefixId.prefix "qualifiedForm"
    /// <summary>
    ///   <para>rdfs:comment : If this Activity prov:generated Entity :e, then it can qualify how it performed the Generation using prov:qualifiedGeneration [ a prov:Generation;  prov:entity :e; :foo :bar ].</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:inverse : qualifiedGenerationOf^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedGeneration^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedGeneration">prov:qualifiedGeneration</a>
    /// </summary>
    let qualifiedGeneration = _prefixId.prefix "qualifiedGeneration"
    let qualifiedGenerationOf = _prefixId.prefix "qualifiedGenerationOf"
    /// <summary>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>rdfs:comment : Because prov:qualifiedInfluence is a broad relation, the more specific relations (qualifiedCommunication, qualifiedDelegation, qualifiedEnd, etc.) should be used when applicable.</para>
    ///   <para>rdfs:label : qualifiedInfluence^^xsd:string</para>
    ///   <para>prov:inverse : qualifiedInfluenceOf^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedInfluence">prov:qualifiedInfluence</a>
    /// </summary>
    let qualifiedInfluence = _prefixId.prefix "qualifiedInfluence"
    let qualifiedInfluenceOf = _prefixId.prefix "qualifiedInfluenceOf"
    /// <summary>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-insertion^^xsd:anyURI</para>
    ///   <para>prov:definition : The dictionary was derived from the other by insertion. prov:qualifiedInsertion shows details of the insertion, in particular the inserted key-entity pairs.^^xsd:string</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedInsertion^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-insertion^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedInsertion">prov:qualifiedInsertion</a>
    /// </summary>
    let qualifiedInsertion = _prefixId.prefix "qualifiedInsertion"
    /// <summary>
    ///   <para>rdfs:comment : If this Entity prov:wasInvalidatedBy Activity :a, then it can qualify how it was invalidated using prov:qualifiedInvalidation [ a prov:Invalidation;  prov:activity :a; :foo :bar ].</para>
    ///   <para>prov:inverse : qualifiedInvalidationOf^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedInvalidation^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedInvalidation">prov:qualifiedInvalidation</a>
    /// </summary>
    let qualifiedInvalidation = _prefixId.prefix "qualifiedInvalidation"
    let qualifiedInvalidationOf = _prefixId.prefix "qualifiedInvalidationOf"
    /// <summary>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:inverse : qualifiedSourceOf^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:comment : If this Entity prov:hadPrimarySource Entity :e, then it can qualify how using prov:qualifiedPrimarySource [ a prov:PrimarySource; prov:entity :e; :foo :bar ].</para>
    ///   <para>rdfs:label : qualifiedPrimarySource^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedPrimarySource">prov:qualifiedPrimarySource</a>
    /// </summary>
    let qualifiedPrimarySource = _prefixId.prefix "qualifiedPrimarySource"
    /// <summary>
    ///   <para>rdfs:comment : If this Entity prov:wasQuotedFrom Entity :e, then it can qualify how using prov:qualifiedQuotation [ a prov:Quotation;  prov:entity :e; :foo :bar ].</para>
    ///   <para>rdfs:label : qualifiedQuotation^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:inverse : qualifiedQuotationOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedQuotation">prov:qualifiedQuotation</a>
    /// </summary>
    let qualifiedQuotation = _prefixId.prefix "qualifiedQuotation"
    let qualifiedQuotationOf = _prefixId.prefix "qualifiedQuotationOf"
    /// <summary>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-removal^^xsd:anyURI</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>rdfs:label : qualifiedRemoval^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-removal^^xsd:anyURI</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>prov:definition : The dictionary was derived from the other by removal. prov:qualifiedRemoval shows details of the removal, in particular the removed keys.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedRemoval">prov:qualifiedRemoval</a>
    /// </summary>
    let qualifiedRemoval = _prefixId.prefix "qualifiedRemoval"
    /// <summary>
    ///   <para>rdfs:label : qualifiedRevision^^xsd:string</para>
    ///   <para>prov:inverse : revisedEntity^^xsd:string</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:comment : If this Entity prov:wasRevisionOf Entity :e, then it can qualify how it was revised using prov:qualifiedRevision [ a prov:Revision;  prov:entity :e; :foo :bar ].</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedRevision">prov:qualifiedRevision</a>
    /// </summary>
    let qualifiedRevision = _prefixId.prefix "qualifiedRevision"
    let qualifiedSourceOf = _prefixId.prefix "qualifiedSourceOf"
    /// <summary>
    ///   <para>prov:inverse : qualifiedStartOf^^xsd:string</para>
    ///   <para>rdfs:comment : If this Activity prov:wasStartedBy Entity :e1, then it can qualify how it was started using prov:qualifiedStart [ a prov:Start;  prov:entity :e1; :foo :bar ].</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedStart^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedStart">prov:qualifiedStart</a>
    /// </summary>
    let qualifiedStart = _prefixId.prefix "qualifiedStart"
    let qualifiedStartOf = _prefixId.prefix "qualifiedStartOf"
    /// <summary>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>rdfs:comment : If this Activity prov:used Entity :e, then it can qualify how it used it using prov:qualifiedUsage [ a prov:Usage; prov:entity :e; :foo :bar ].</para>
    ///   <para>prov:inverse : qualifiedUsingActivity^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedUsage^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#qualifiedUsage">prov:qualifiedUsage</a>
    /// </summary>
    let qualifiedUsage = _prefixId.prefix "qualifiedUsage"
    let qualifiedUsingActivity = _prefixId.prefix "qualifiedUsingActivity"
    let quotedAs = _prefixId.prefix "quotedAs"
    /// <summary>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#term-dictionary-removal^^xsd:anyURI</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#dictionary-constraints^^xsd:anyURI</para>
    ///   <para>prov:component : collections^^xsd:string</para>
    ///   <para>rdfs:label : removedKey^^xsd:string</para>
    ///   <para>prov:definition : The key removed in a Removal.^^xsd:string</para>
    ///   <para>prov:category : collections^^xsd:string</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/NOTE-prov-dictionary-20130430/#expression-dictionary-removal^^xsd:anyURI</para>
    ///   <a href="http://www.w3.org/ns/prov#removedKey">prov:removedKey</a>
    /// </summary>
    let removedKey = _prefixId.prefix "removedKey"
    let revisedEntity = _prefixId.prefix "revisedEntity"
    let sharesDefinitionWith = _prefixId.prefix "sharesDefinitionWith"
    /// <summary>
    ///   <para>rdfs:label : specializationOf^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-specialization^^xsd:anyURIprov:dm : http://www.w3.org/TR/2012/WD-prov-dm-20120703/prov-dm.html#term-specialization^^xsd:anyURI</para>
    ///   <para>prov:n : http://www.w3.org/TR/2013/REC-prov-n-20130430/#expression-specialization^^xsd:anyURIprov:n : http://www.w3.org/TR/2012/WD-prov-dm-20120703/prov-n.html#expression-specialization^^xsd:anyURI</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>prov:definition : An entity that is a specialization of another shares all aspects of the latter, and additionally presents more specific aspects of the same thing as the latter. In particular, the lifetime of the entity being specialized contains that of any specialization. Examples of aspects include a time period, an abstraction, and a context associated with the entity.</para>
    ///   <para>prov:constraints : http://www.w3.org/TR/2012/WD-prov-dm-20120703/prov-constraints.html#prov-dm-constraints-fig^^xsd:anyURIprov:constraints : http://www.w3.org/TR/2013/REC-prov-constraints-20130430/#prov-dm-constraints-fig^^xsd:anyURI</para>
    ///   <para>prov:inverse : generalizationOf^^xsd:string</para>
    ///   <para>prov:component : alternate^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#specializationOf">prov:specializationOf</a>
    /// </summary>
    let specializationOf = _prefixId.prefix "specializationOf"
    let started = _prefixId.prefix "started"
    /// <summary>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:editorialNote : It is the intent that the property chain holds: (prov:qualifiedStart o prov:atTime) rdfs:subPropertyOf prov:startedAtTime.</para>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>rdfs:label : startedAtTime^^xsd:string</para>
    ///   <para>rdfs:comment : The time at which an activity started. See also prov:endedAtTime.</para>
    ///   <a href="http://www.w3.org/ns/prov#startedAtTime">prov:startedAtTime</a>
    /// </summary>
    let startedAtTime = _prefixId.prefix "startedAtTime"
    let todo = _prefixId.prefix "todo"
    /// <summary>
    ///   <para>rdfs:comment : Classes and properties used to qualify relationships are annotated with prov:unqualifiedForm to indicate the property used to assert an unqualified provenance relation.</para>
    ///   <a href="http://www.w3.org/ns/prov#unqualifiedForm">prov:unqualifiedForm</a>
    /// </summary>
    let unqualifiedForm = _prefixId.prefix "unqualifiedForm"
    /// <summary>
    ///   <para>prov:inverse : wasUsedBy^^xsd:string</para>
    ///   <para>rdfs:label : used^^xsd:string</para>
    ///   <para>rdfs:comment : A prov:Entity that was used by this prov:Activity. For example, :baking prov:used :spoon, :egg, :oven .</para>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#used">prov:used</a>
    /// </summary>
    let used = _prefixId.prefix "used"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <para>prov:dm : http://www.w3.org/TR/2013/REC-prov-dm-20130430/#term-attribute-value^^xsd:anyURI</para>
    ///   <para>prov:definition : Provides a value that is a direct representation of an entity.</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>prov:editorialNote : This property serves the same purpose as rdf:value, but has been reintroduced to avoid some of the definitional ambiguity in the RDF specification (specifically, 'may be used in describing structured values').prov:editorialNote : The editor's definition comes from http://www.w3.org/TR/rdf-primer/#rdfvalue^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#value">prov:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    let wasActivityOfInfluence = _prefixId.prefix "wasActivityOfInfluence"
    let wasAssociateFor = _prefixId.prefix "wasAssociateFor"
    /// <summary>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:inverse : wasAssociateFor^^xsd:string</para>
    ///   <para>rdfs:label : wasAssociatedWith^^xsd:string</para>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>rdfs:comment : An prov:Agent that had some (unspecified) responsibility for the occurrence of this prov:Activity.</para>
    ///   <a href="http://www.w3.org/ns/prov#wasAssociatedWith">prov:wasAssociatedWith</a>
    /// </summary>
    let wasAssociatedWith = _prefixId.prefix "wasAssociatedWith"
    /// <summary>
    ///   <para>prov:inverse : contributed^^xsd:string</para>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>prov:definition : Attribution is the ascribing of an entity to an agent.</para>
    ///   <para>rdfs:label : wasAttributedTo^^xsd:string</para>
    ///   <para>rdfs:comment : Attribution is the ascribing of an entity to an agent.</para>
    ///   <a href="http://www.w3.org/ns/prov#wasAttributedTo">prov:wasAttributedTo</a>
    /// </summary>
    let wasAttributedTo = _prefixId.prefix "wasAttributedTo"
    /// <summary>
    ///   <para>rdfs:comment : The more specific subproperties of prov:wasDerivedFrom (i.e., prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource) should be used when applicable.</para>
    ///   <para>prov:inverse : hadDerivation^^xsd:string</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>prov:definition : A derivation is a transformation of an entity into another, an update of an entity resulting in a new one, or the construction of a new entity based on a pre-existing entity.</para>
    ///   <para>rdfs:label : wasDerivedFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#wasDerivedFrom">prov:wasDerivedFrom</a>
    /// </summary>
    let wasDerivedFrom = _prefixId.prefix "wasDerivedFrom"
    /// <summary>
    ///   <para>prov:inverse : ended^^xsd:string</para>
    ///   <para>rdfs:comment : End is when an activity is deemed to have ended. An end may refer to an entity, known as trigger, that terminated the activity.</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : wasEndedBy^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#wasEndedBy">prov:wasEndedBy</a>
    /// </summary>
    let wasEndedBy = _prefixId.prefix "wasEndedBy"
    /// <summary>
    ///   <para>rdfs:label : wasGeneratedBy^^xsd:string</para>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>prov:inverse : generated^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#wasGeneratedBy">prov:wasGeneratedBy</a>
    /// </summary>
    let wasGeneratedBy = _prefixId.prefix "wasGeneratedBy"
    /// <summary>
    ///   <para>prov:component : agents-responsibility^^xsd:string</para>
    ///   <para>prov:category : qualified^^xsd:string</para>
    ///   <para>rdfs:comment : This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.^^xsd:stringrdfs:comment : Because prov:wasInfluencedBy is a broad relation, its more specific subproperties (e.g. prov:wasInformedBy, prov:actedOnBehalfOf, prov:wasEndedBy, etc.) should be used when applicable.</para>
    ///   <para>rdfs:label : wasInfluencedBy^^xsd:string</para>
    ///   <para>prov:inverse : influenced^^xsd:string</para>
    ///   <para>prov:editorialNote : The sub-properties of prov:wasInfluencedBy can be elaborated in more detail using the Qualification Pattern. For example, the binary relation :baking prov:used :spoon can be qualified by asserting :baking prov:qualifiedUsage [ a prov:Usage; prov:entity :spoon; prov:atLocation :kitchen ] .
    ///
    /// Subproperties of prov:wasInfluencedBy may also be asserted directly without being qualified.
    ///
    /// prov:wasInfluencedBy should not be used without also using one of its subproperties.
    /// </para>
    ///   <a href="http://www.w3.org/ns/prov#wasInfluencedBy">prov:wasInfluencedBy</a>
    /// </summary>
    let wasInfluencedBy = _prefixId.prefix "wasInfluencedBy"
    /// <summary>
    ///   <para>prov:category : starting-point^^xsd:string</para>
    ///   <para>rdfs:comment : An activity a2 is dependent on or informed by another activity a1, by way of some unspecified entity that is generated by a1 and used by a2.</para>
    ///   <para>prov:inverse : informed^^xsd:string</para>
    ///   <para>rdfs:label : wasInformedBy^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#wasInformedBy">prov:wasInformedBy</a>
    /// </summary>
    let wasInformedBy = _prefixId.prefix "wasInformedBy"
    /// <summary>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>prov:inverse : invalidated^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : wasInvalidatedBy^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#wasInvalidatedBy">prov:wasInvalidatedBy</a>
    /// </summary>
    let wasInvalidatedBy = _prefixId.prefix "wasInvalidatedBy"
    let wasMemberOf = _prefixId.prefix "wasMemberOf"
    let wasPlanOf = _prefixId.prefix "wasPlanOf"
    let wasPrimarySourceOf = _prefixId.prefix "wasPrimarySourceOf"
    /// <summary>
    ///   <para>rdfs:label : wasQuotedFrom^^xsd:string</para>
    ///   <para>prov:inverse : quotedAs^^xsd:string</para>
    ///   <para>rdfs:comment : An entity is derived from an original entity by copying, or 'quoting', some or all of it.</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/prov#wasQuotedFrom">prov:wasQuotedFrom</a>
    /// </summary>
    let wasQuotedFrom = _prefixId.prefix "wasQuotedFrom"
    /// <summary>
    ///   <para>prov:inverse : hadRevision^^xsd:string</para>
    ///   <para>prov:component : derivations^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>rdfs:label : wasRevisionOf^^xsd:string</para>
    ///   <para>rdfs:comment : A revision is a derivation that revises an entity into a revised version.</para>
    ///   <a href="http://www.w3.org/ns/prov#wasRevisionOf">prov:wasRevisionOf</a>
    /// </summary>
    let wasRevisionOf = _prefixId.prefix "wasRevisionOf"
    let wasRoleIn = _prefixId.prefix "wasRoleIn"
    /// <summary>
    ///   <para>prov:inverse : started^^xsd:string</para>
    ///   <para>rdfs:label : wasStartedBy^^xsd:string</para>
    ///   <para>prov:category : expanded^^xsd:string</para>
    ///   <para>prov:component : entities-activities^^xsd:string</para>
    ///   <para>rdfs:comment : Start is when an activity is deemed to have started. A start may refer to an entity, known as trigger, that initiated the activity.</para>
    ///   <a href="http://www.w3.org/ns/prov#wasStartedBy">prov:wasStartedBy</a>
    /// </summary>
    let wasStartedBy = _prefixId.prefix "wasStartedBy"
    let wasUsedBy = _prefixId.prefix "wasUsedBy"
    let wasUsedInDerivation = _prefixId.prefix "wasUsedInDerivation"
