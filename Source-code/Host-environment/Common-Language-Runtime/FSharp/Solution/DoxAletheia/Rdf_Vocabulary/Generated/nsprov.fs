namespace http.www.w3.org.ns.prov.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nsprov =
    let _namespace_iri = Namespace_Iri nsprov |> NamespaceIRI
    /// <summary>
    ///   <para>nsprov:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"This document is published by the Provenance Working Group (http://www.w3.org/2011/prov/wiki/Main_Page).
    ///
    /// If you wish to make comments regarding this document, please send them to public-prov-comments@w3.org (subscribe public-prov-comments-request@w3.org, archives http://lists.w3.org/
    /// Archives/Public/public-prov-comments/). All feedback is welcome."</para>
    /// labels<para>"W3C PROVenance Interchange"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#">http://www.w3.org/ns/prov#</seealso>
    let _prefix_iri = Prefixed_Name(nsprov, "") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Accept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Accept"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Accept">http://www.w3.org/ns/prov#Accept</seealso>
    let Accept = Prefixed_Name(nsprov, "Accept") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una actividad ocurre en un periodo de tiempo y actúa con o sobre entidades; puede incluir consumir, procesar, transformar, modificar, mover, usar o generar entidades del grafo"</para>
    ///   <para>"An action or process that occurs over a period of time and acts upon entities."</para>
    ///   <para>"An activity is something that occurs over a period of time and acts upon or with entities; it may include consuming, processing, transforming, modifying, relocating, using, or generating entities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An activity is something that occurs over a period of time and acts upon or with entities; it may include consuming, processing, transforming, modifying, relocating, using, or generating entities."</para>
    ///   <para>"An activity is something that occurs over a period of time and acts upon or with entities; it may include consuming, processing, transforming, modifying, relocating, using, or generating entities"</para>
    /// labels<para>"PROV Activity"</para><para>"Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Activity"</para><para>"PROV Actividad"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Activity">http://www.w3.org/ns/prov#Activity</seealso>
    let Activity = Prefixed_Name(nsprov, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:ActivityInfluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ActivityInfluence provides additional descriptions of an Activity's binary influence upon any other kind of resource. Instances of ActivityInfluence use the prov:activity property to cite the influencing Activity."</para>
    ///   <para>"It is not recommended that the type ActivityInfluence be asserted without also asserting one of its more specific subclasses."</para>
    /// labels<para>"ActivityInfluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#ActivityInfluence">http://www.w3.org/ns/prov#ActivityInfluence</seealso>
    let ActivityInfluence = Prefixed_Name(nsprov, "ActivityInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An agent is something that bears some form of responsibility for an activity taking place, for the existence of an entity, or for another agent's activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An agent is something that bears some form of responsibility for an activity taking place, for the existence of an entity, or for another agent's activity."</para>
    ///   <para>"The agent who tags an ontology entity with a vagueness/non-vagueness description."</para>
    ///   <para>"Something that bears responsibility for an activity taking place, for the existence of an entity, or for another agent's activity."</para>
    /// labels<para>"agent"</para><para>"Agent"</para><para>"Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Agent">http://www.w3.org/ns/prov#Agent</seealso>
    let Agent = Prefixed_Name(nsprov, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:AgentInfluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AgentInfluence provides additional descriptions of an Agent's binary influence upon any other kind of resource. Instances of AgentInfluence use the prov:agent property to cite the influencing Agent."</para>
    ///   <para>"It is not recommended that the type AgentInfluence be asserted without also asserting one of its more specific subclasses."</para>
    /// labels<para>"AgentInfluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#AgentInfluence">http://www.w3.org/ns/prov#AgentInfluence</seealso>
    let AgentInfluence = Prefixed_Name(nsprov, "AgentInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:Association provides additional descriptions about the binary prov:wasAssociatedWith relation from an prov:Activity to some prov:Agent that had some responsiblity for it. For example, :baking prov:wasAssociatedWith :baker; prov:qualifiedAssociation [ a prov:Association; prov:agent :baker; :foo :bar ]."</para>
    ///   <para>"An activity association is an assignment of responsibility to an agent for an activity, indicating that the agent had a role in the activity. It further allows for a plan to be specified, which is the plan intended by the agent to achieve some goals in the context of this activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An instance of prov:Association provides additional descriptions about the binary prov:wasAssociatedWith relation from an prov:Activity to some prov:Agent that had some responsiblity for it. For example, :baking prov:wasAssociatedWith :baker; prov:qualifiedssociation [ a prov:Association; prov:agent :baker; :foo :bar ]."</para>
    /// labels<para>"Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Association">http://www.w3.org/ns/prov#Association</seealso>
    let Association = Prefixed_Name(nsprov, "Association") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Attribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Attribution is the ascribing of an entity to an agent. When an entity e is attributed to agent ag, entity e was generated by some unspecified activity that in turn was associated to agent ag. Thus, this relation is useful when the activity is not known, or irrelevant."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An instance of prov:Attribution provides additional descriptions about the binary prov:wasAttributedTo relation from an prov:Entity to some prov:Agent that had some responsible for it. For example, :cake prov:wasAttributedTo :baker; prov:qualifiedAttribution [ a prov:Attribution; prov:entity :baker; :foo :bar ]."</para>
    /// labels<para>"Attribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Attribution">http://www.w3.org/ns/prov#Attribution</seealso>
    let Attribution = Prefixed_Name(nsprov, "Attribution") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Bundle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Note that there are kinds of bundles (e.g. handwritten letters, audio recordings, etc.) that are not expressed in PROV-O, but can be still be described by PROV-O."</para>
    ///   <para>"A bundle is a named set of provenance descriptions, and is itself an Entity, so allowing provenance of provenance to be expressed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bundle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Bundle">http://www.w3.org/ns/prov#Bundle</seealso>
    let Bundle = Prefixed_Name(nsprov, "Bundle") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Collection">http://www.w3.org/ns/prov#Collection</seealso>
    let Collection = Prefixed_Name(nsprov, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Communication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:Communication provides additional descriptions about the binary prov:wasInformedBy relation from an informed prov:Activity to the prov:Activity that informed it. For example, :you_jumping_off_bridge prov:wasInformedBy :everyone_else_jumping_off_bridge; prov:qualifiedCommunication [ a prov:Communication; prov:activity :everyone_else_jumping_off_bridge; :foo :bar ]."</para>
    /// labels<para>"Communication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Communication">http://www.w3.org/ns/prov#Communication</seealso>
    let Communication = Prefixed_Name(nsprov, "Communication") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Contribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Contribute
    /// "</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Contribute">http://www.w3.org/ns/prov#Contribute</seealso>
    let Contribute = Prefixed_Name(nsprov, "Contribute") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Contributor"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Contributor">http://www.w3.org/ns/prov#Contributor</seealso>
    let Contributor = Prefixed_Name(nsprov, "Contributor") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Copyright"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Copyright">http://www.w3.org/ns/prov#Copyright</seealso>
    let Copyright = Prefixed_Name(nsprov, "Copyright") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Create</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Create"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Create">http://www.w3.org/ns/prov#Create</seealso>
    let Create = Prefixed_Name(nsprov, "Create") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Creator"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Creator">http://www.w3.org/ns/prov#Creator</seealso>
    let Creator = Prefixed_Name(nsprov, "Creator") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Delegation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:Delegation provides additional descriptions about the binary prov:actedOnBehalfOf relation from a performing prov:Agent to some prov:Agent for whom it was performed. For example, :mixing prov:wasAssociatedWith :toddler . :toddler prov:actedOnBehalfOf :mother; prov:qualifiedDelegation [ a prov:Delegation; prov:entity :mother; :foo :bar ]."</para>
    /// labels<para>"Delegation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Delegation">http://www.w3.org/ns/prov#Delegation</seealso>
    let Delegation = Prefixed_Name(nsprov, "Delegation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Derivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:Derivation provides additional descriptions about the binary prov:wasDerivedFrom relation from some derived prov:Entity to another prov:Entity from which it was derived. For example, :chewed_bubble_gum prov:wasDerivedFrom :unwrapped_bubble_gum; prov:qualifiedDerivation [ a prov:Derivation; prov:entity :unwrapped_bubble_gum; :foo :bar ]."</para>
    ///   <para>"The more specific forms of prov:Derivation (i.e., prov:Revision, prov:Quotation, prov:PrimarySource) should be asserted if they apply."</para>
    /// labels<para>"Derivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Derivation">http://www.w3.org/ns/prov#Derivation</seealso>
    let Derivation = Prefixed_Name(nsprov, "Derivation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Dictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This concept allows for the provenance of the dictionary, but also of its constituents to be expressed. Such a notion of dictionary corresponds to a wide variety of concrete data structures, such as a maps or associative arrays."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A given dictionary forms a given structure for its members. A different structure (obtained either by insertion or removal of members) constitutes a different dictionary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dictionary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Dictionary">http://www.w3.org/ns/prov#Dictionary</seealso>
    let Dictionary = Prefixed_Name(nsprov, "Dictionary") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:DirectQueryService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type for a generic provenance query service. Mainly for use in RDF provenance query service descriptions, to facilitate discovery in linked data environments."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ProvenanceService"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#DirectQueryService">http://www.w3.org/ns/prov#DirectQueryService</seealso>
    let DirectQueryService = Prefixed_Name(nsprov, "DirectQueryService") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Emotion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Emotion">http://www.w3.org/ns/prov#Emotion</seealso>
    let Emotion = Prefixed_Name(nsprov, "Emotion") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:EmptyCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EmptyCollection"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#EmptyCollection">http://www.w3.org/ns/prov#EmptyCollection</seealso>
    let EmptyCollection = Prefixed_Name(nsprov, "EmptyCollection") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:EmptyDictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Empty Dictionary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#EmptyDictionary">http://www.w3.org/ns/prov#EmptyDictionary</seealso>
    let EmptyDictionary = Prefixed_Name(nsprov, "EmptyDictionary") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:End</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:End provides additional descriptions about the binary prov:wasEndedBy relation from some ended prov:Activity to an prov:Entity that ended it. For example, :ball_game prov:wasEndedBy :buzzer; prov:qualifiedEnd [ a prov:End; prov:entity :buzzer; :foo :bar; prov:atTime '2012-03-09T08:05:08-05:00'^^xsd:dateTime ]."</para>
    /// labels<para>"End"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#End">http://www.w3.org/ns/prov#End</seealso>
    let End = Prefixed_Name(nsprov, "End") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical, digital, conceptual, or other kind of thing with some fixed aspects."</para>
    ///   <para>"An entity is a physical, digital, conceptual, or other kind of thing with some fixed aspects; entities may be real or imaginary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An entity is a physical, digital, conceptual, or other kind of thing with some fixed aspects; entities may be real or imaginary."</para>
    /// labels<para>"entity"</para><para>"Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Entity"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Entity">http://www.w3.org/ns/prov#Entity</seealso>
    let Entity = Prefixed_Name(nsprov, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:EntityInfluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is not recommended that the type EntityInfluence be asserted without also asserting one of its more specific subclasses."</para>
    ///   <para>"EntityInfluence provides additional descriptions of an Entity's binary influence upon any other kind of resource. Instances of EntityInfluence use the prov:entity property to cite the influencing Entity."</para>
    /// labels<para>"EntityInfluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#EntityInfluence">http://www.w3.org/ns/prov#EntityInfluence</seealso>
    let EntityInfluence = Prefixed_Name(nsprov, "EntityInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Generation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:Generation provides additional descriptions about the binary prov:wasGeneratedBy relation from a generated prov:Entity to the prov:Activity that generated it. For example, :cake prov:wasGeneratedBy :baking; prov:qualifiedGeneration [ a prov:Generation; prov:activity :baking; :foo :bar ]."</para>
    /// labels<para>"Generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Generation">http://www.w3.org/ns/prov#Generation</seealso>
    let Generation = Prefixed_Name(nsprov, "Generation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Influence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Because prov:Influence is a broad relation, its most specific subclasses (e.g. prov:Communication, prov:Delegation, prov:End, prov:Revision, etc.) should be used when applicable."</para>
    ///   <para>"Influence is the capacity of an entity, activity, or agent to have an effect on the character, development, or behavior of another by means of usage, start, end, generation, invalidation, communication, derivation, attribution, association, or delegation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An instance of prov:Influence provides additional descriptions about the binary prov:wasInfluencedBy relation from some influenced Activity, Entity, or Agent to the influencing Activity, Entity, or Agent. For example, :stomach_ache prov:wasInfluencedBy :spoon; prov:qualifiedInfluence [ a prov:Influence; prov:entity :spoon; :foo :bar ] . Because prov:Influence is a broad relation, the more specific relations (Communication, Delegation, End, etc.) should be used when applicable."</para>
    /// labels<para>"Influence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Influence">http://www.w3.org/ns/prov#Influence</seealso>
    let Influence = Prefixed_Name(nsprov, "Influence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Insertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Insertion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Insertion">http://www.w3.org/ns/prov#Insertion</seealso>
    let Insertion = Prefixed_Name(nsprov, "Insertion") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:InstantaneousEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An instantaneous event, or event for short, happens in the world and marks a change in the world, in its activities and in its entities. The term 'event' is commonly used in process algebra with a similar meaning. Events represent communications or interactions; they are assumed to be atomic and instantaneous."</para>
    /// labels<para>"Instantaneous Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"InstantaneousEvent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#InstantaneousEvent">http://www.w3.org/ns/prov#InstantaneousEvent</seealso>
    let InstantaneousEvent = Prefixed_Name(nsprov, "InstantaneousEvent") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Invalidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:Invalidation provides additional descriptions about the binary prov:wasInvalidatedBy relation from an invalidated prov:Entity to the prov:Activity that invalidated it. For example, :uncracked_egg prov:wasInvalidatedBy :baking; prov:qualifiedInvalidation [ a prov:Invalidation; prov:activity :baking; :foo :bar ]."</para>
    /// labels<para>"Invalidation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Invalidation">http://www.w3.org/ns/prov#Invalidation</seealso>
    let Invalidation = Prefixed_Name(nsprov, "Invalidation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:KeyEntityPair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Key-Entity Pair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#KeyEntityPair">http://www.w3.org/ns/prov#KeyEntityPair</seealso>
    let KeyEntityPair = Prefixed_Name(nsprov, "KeyEntityPair") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A location can be an identifiable geographic place (ISO 19112), but it can also be a non-geographic place such as a directory, row, or column. As such, there are numerous ways in which location can be expressed, such as by a coordinate, address, landmark, and so forth."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Location">http://www.w3.org/ns/prov#Location</seealso>
    let Location = Prefixed_Name(nsprov, "Location") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Modify</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Modify"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Modify">http://www.w3.org/ns/prov#Modify</seealso>
    let Modify = Prefixed_Name(nsprov, "Modify") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Organisation">http://www.w3.org/ns/prov#Organisation</seealso>
    let Organisation = Prefixed_Name(nsprov, "Organisation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A social or legal entity such as a company, institution, or association."</para>
    /// labels<para>"Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Organization">http://www.w3.org/ns/prov#Organization</seealso>
    let Organization = Prefixed_Name(nsprov, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Person agents are people."</para>
    /// labels<para>"Person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Person">http://www.w3.org/ns/prov#Person</seealso>
    let Person = Prefixed_Name(nsprov, "Person") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"There exist no prescriptive requirement on the nature of plans, their representation, the actions or steps they consist of, or their intended goals. Since plans may evolve over time, it may become necessary to track their provenance, so plans themselves are entities. Representing the plan explicitly in the provenance can be useful for various tasks: for example, to validate the execution as represented in the provenance record, to manage expectation failures, or to provide explanations."</para>
    /// labels<para>"Plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Plan">http://www.w3.org/ns/prov#Plan</seealso>
    let Plan = Prefixed_Name(nsprov, "Plan") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:PrimarySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:PrimarySource provides additional descriptions about the binary prov:hadPrimarySource relation from some secondary prov:Entity to an earlier, primary prov:Entity. For example, :blog prov:hadPrimarySource :newsArticle; prov:qualifiedPrimarySource [ a prov:PrimarySource; prov:entity :newsArticle; :foo :bar ] ."</para>
    /// labels<para>"PrimarySource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#PrimarySource">http://www.w3.org/ns/prov#PrimarySource</seealso>
    let PrimarySource = Prefixed_Name(nsprov, "PrimarySource") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Publish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Publish"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Publish">http://www.w3.org/ns/prov#Publish</seealso>
    let Publish = Prefixed_Name(nsprov, "Publish") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Publisher"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Publisher">http://www.w3.org/ns/prov#Publisher</seealso>
    let Publisher = Prefixed_Name(nsprov, "Publisher") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Quotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:Quotation provides additional descriptions about the binary prov:wasQuotedFrom relation from some taken prov:Entity from an earlier, larger prov:Entity. For example, :here_is_looking_at_you_kid prov:wasQuotedFrom :casablanca_script; prov:qualifiedQuotation [ a prov:Quotation; prov:entity :casablanca_script; :foo :bar ]."</para>
    /// labels<para>"Quotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Quotation">http://www.w3.org/ns/prov#Quotation</seealso>
    let Quotation = Prefixed_Name(nsprov, "Quotation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Removal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Removal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Removal">http://www.w3.org/ns/prov#Removal</seealso>
    let Removal = Prefixed_Name(nsprov, "Removal") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Replace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Replace"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Replace">http://www.w3.org/ns/prov#Replace</seealso>
    let Replace = Prefixed_Name(nsprov, "Replace") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:Revision provides additional descriptions about the binary prov:wasRevisionOf relation from some newer prov:Entity to an earlier prov:Entity. For example, :draft_2 prov:wasRevisionOf :draft_1; prov:qualifiedRevision [ a prov:Revision; prov:entity :draft_1; :foo :bar ]."</para>
    /// labels<para>"Revision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Revision">http://www.w3.org/ns/prov#Revision</seealso>
    let Revision = Prefixed_Name(nsprov, "Revision") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:RightsAssignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RightsAssignment"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#RightsAssignment">http://www.w3.org/ns/prov#RightsAssignment</seealso>
    let RightsAssignment = Prefixed_Name(nsprov, "RightsAssignment") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:RightsHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RightsHolder"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#RightsHolder">http://www.w3.org/ns/prov#RightsHolder</seealso>
    let RightsHolder = Prefixed_Name(nsprov, "RightsHolder") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A role is the function of an entity or agent with respect to an activity, in the context of a usage, generation, invalidation, association, start, and end."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Role">http://www.w3.org/ns/prov#Role</seealso>
    let Role = Prefixed_Name(nsprov, "Role") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:ServiceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type for a generic provenance query service. Mainly for use in RDF provenance query service descriptions, to facilitate discovery in linked data environments."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceDescription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#ServiceDescription">http://www.w3.org/ns/prov#ServiceDescription</seealso>
    let ServiceDescription = Prefixed_Name(nsprov, "ServiceDescription") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:SoftwareAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Es un software en ejecución que proporciona datos al grafo"</para>
    ///   <para>"A software agent is running software that provides data to the graph"</para>
    ///   <para>"A running software system acting as an agent in provenance descriptions."</para>
    /// labels<para>"Agente de software"</para><para>"Software Agent"</para><para>"SoftwareAgent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#SoftwareAgent">http://www.w3.org/ns/prov#SoftwareAgent</seealso>
    let SoftwareAgent = Prefixed_Name(nsprov, "SoftwareAgent") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Start</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:Start provides additional descriptions about the binary prov:wasStartedBy relation from some started prov:Activity to an prov:Entity that started it. For example, :foot_race prov:wasStartedBy :bang; prov:qualifiedStart [ a prov:Start; prov:entity :bang; :foo :bar; prov:atTime '2012-03-09T08:05:08-05:00'^^xsd:dateTime ] ."</para>
    /// labels<para>"Start"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Start">http://www.w3.org/ns/prov#Start</seealso>
    let Start = Prefixed_Name(nsprov, "Start") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Submit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Submit"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Submit">http://www.w3.org/ns/prov#Submit</seealso>
    let Submit = Prefixed_Name(nsprov, "Submit") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of prov:Usage provides additional descriptions about the binary prov:used relation from some prov:Activity to an prov:Entity that it used. For example, :keynote prov:used :podium; prov:qualifiedUsage [ a prov:Usage; prov:entity :podium; :foo :bar ]."</para>
    /// labels<para>"Usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Usage">http://www.w3.org/ns/prov#Usage</seealso>
    let Usage = Prefixed_Name(nsprov, "Usage") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:actedOnBehalfOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property to express the accountability of an agent towards another agent. The subordinate agent acted on behalf of the responsible agent in an actual activity. "</para>
    /// labels<para>"actedOnBehalfOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#actedOnBehalfOf">http://www.w3.org/ns/prov#actedOnBehalfOf</seealso>
    let actedOnBehalfOf = Prefixed_Name(nsprov, "actedOnBehalfOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#activity">http://www.w3.org/ns/prov#activity</seealso>
    let activity = Prefixed_Name(nsprov, "activity") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:activityOfInfluence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"activityOfInfluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#activityOfInfluence">http://www.w3.org/ns/prov#activityOfInfluence</seealso>
    let activityOfInfluence =
        Prefixed_Name(nsprov, "activityOfInfluence") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The prov:agent property references an prov:Agent which influenced a resource. This property applies to an prov:AgentInfluence, which is given by a subproperty of prov:qualifiedInfluence from the influenced prov:Entity, prov:Activity or prov:Agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#agent">http://www.w3.org/ns/prov#agent</seealso>
    let agent = Prefixed_Name(nsprov, "agent") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:agentOfInfluence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"agentOfInfluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#agentOfInfluence">http://www.w3.org/ns/prov#agentOfInfluence</seealso>
    let agentOfInfluence = Prefixed_Name(nsprov, "agentOfInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:alternateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"alternateOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"prov:alternateOf"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#alternateOf">http://www.w3.org/ns/prov#alternateOf</seealso>
    let alternateOf = Prefixed_Name(nsprov, "alternateOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:aq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#aq">http://www.w3.org/ns/prov#aq</seealso>
    let aq = Prefixed_Name(nsprov, "aq") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:asInBundle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"prov:asInBundle is used to specify which bundle the general entity of a prov:mentionOf property is described.
    ///
    /// When :x prov:mentionOf :y and :y is described in Bundle :b, the triple :x prov:asInBundle :b is also asserted to cite the Bundle in which :y was described."</para>
    /// labels<para>"asInBundle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#asInBundle">http://www.w3.org/ns/prov#asInBundle</seealso>
    let asInBundle = Prefixed_Name(nsprov, "asInBundle") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:atLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Location of any resource."</para>
    ///   <para>"A location can be an identifiable geographic place (ISO 19112), but it can also be a non-geographic place such as a directory, row, or column. As such, there are numerous ways in which location can be expressed, such as by a coordinate, address, landmark, and so forth."</para>
    ///   <para>"This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"atLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"atLocation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#atLocation">http://www.w3.org/ns/prov#atLocation</seealso>
    let atLocation = Prefixed_Name(nsprov, "atLocation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time at which an InstantaneousEvent occurred, in the form of xsd:dateTime."</para>
    /// labels<para>"atTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"at time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#atTime">http://www.w3.org/ns/prov#atTime</seealso>
    let atTime = Prefixed_Name(nsprov, "atTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Classify prov-o terms into three categories, including 'starting-point', 'qualifed', and 'extended'. This classification is used by the prov-o html document to gently introduce prov-o terms to its users. "</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#category">http://www.w3.org/ns/prov#category</seealso>
    let category = Prefixed_Name(nsprov, "category") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Classify prov-o terms into six components according to prov-dm, including 'agents-responsibility', 'alternate', 'annotations', 'collections', 'derivations', and 'entities-activities'. This classification is used so that readers of prov-o specification can find its correspondence with the prov-dm specification."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#component">http://www.w3.org/ns/prov#component</seealso>
    let component_ = Prefixed_Name(nsprov, "component") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:constraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A reference to the principal section of the PROV-CONSTRAINTS document that describes this concept."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#constraints">http://www.w3.org/ns/prov#constraints</seealso>
    let constraints = Prefixed_Name(nsprov, "constraints") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:contributed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Attribution is the ascribing of an entity to an agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contributed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#contributed">http://www.w3.org/ns/prov#contributed</seealso>
    let contributed = Prefixed_Name(nsprov, "contributed") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A definition quoted from PROV-DM or PROV-CONSTRAINTS that describes the concept expressed with this OWL term."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#definition">http://www.w3.org/ns/prov#definition</seealso>
    let definition = Prefixed_Name(nsprov, "definition") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:derivedByInsertionFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"derivedByInsertionFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#derivedByInsertionFrom">http://www.w3.org/ns/prov#derivedByInsertionFrom</seealso>
    let derivedByInsertionFrom =
        Prefixed_Name(nsprov, "derivedByInsertionFrom") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:derivedByRemovalFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"derivedByRemovalFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#derivedByRemovalFrom">http://www.w3.org/ns/prov#derivedByRemovalFrom</seealso>
    let derivedByRemovalFrom =
        Prefixed_Name(nsprov, "derivedByRemovalFrom") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:describesService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relates a generic provenance query service resource (type prov:ServiceDescription) to a specific query service description (e.g. a prov:DirectQueryService or a sd:Service)."</para>
    /// labels<para>"describesService"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#describesService">http://www.w3.org/ns/prov#describesService</seealso>
    let describesService = Prefixed_Name(nsprov, "describesService") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:dictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"dictionary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#dictionary">http://www.w3.org/ns/prov#dictionary</seealso>
    let dictionary = Prefixed_Name(nsprov, "dictionary") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:dm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A reference to the principal section of the PROV-DM document that describes this concept."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#dm">http://www.w3.org/ns/prov#dm</seealso>
    let dm = Prefixed_Name(nsprov, "dm") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:editorialNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A note by the OWL development team about how this term expresses the PROV-DM concept, or how it should be used in context of semantic web or linked data."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#editorialNote">http://www.w3.org/ns/prov#editorialNote</seealso>
    let editorialNote = Prefixed_Name(nsprov, "editorialNote") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:editorsDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"When the prov-o term does not have a definition drawn from prov-dm, and the prov-o editor provides one."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#editorsDefinition">http://www.w3.org/ns/prov#editorsDefinition</seealso>
    let editorsDefinition = Prefixed_Name(nsprov, "editorsDefinition") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:ended</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"ended"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#ended">http://www.w3.org/ns/prov#ended</seealso>
    let ended = Prefixed_Name(nsprov, "ended") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:endedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The number of calories burned associated with the
    /// activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The time at which an activity ended. See also prov:startedAtTime."</para>
    ///   <para>"End is when an activity is deemed to have been ended by an entity, known as trigger. The activity no longer exists after its end. Any usage, generation, or invalidation involving an activity precedes the activity's end. An end may refer to a trigger entity that terminated the activity, or to an activity, known as ender that generated the trigger."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"endedAtTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"ended at time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#endedAtTime">http://www.w3.org/ns/prov#endedAtTime</seealso>
    let endedAtTime = Prefixed_Name(nsprov, "endedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#entity">http://www.w3.org/ns/prov#entity</seealso>
    let entity = Prefixed_Name(nsprov, "entity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:entityOfInfluence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"entityOfInfluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#entityOfInfluence">http://www.w3.org/ns/prov#entityOfInfluence</seealso>
    let entityOfInfluence = Prefixed_Name(nsprov, "entityOfInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:generalizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"An entity that is a generalization of another. E.g., Distribution sort algorithm is a generalization of Bucket sort."</para>
    /// labels<para>"prov:generalizationOf"</para><para>"generalization of"</para><para>"generalizationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#generalizationOf">http://www.w3.org/ns/prov#generalizationOf</seealso>
    let generalizationOf = Prefixed_Name(nsprov, "generalizationOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:generated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an event to the generated data by the same."</para>
    ///   <para>"Explicit redefinition for a reuse in SemTS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Relates an activity to an entity that it generated."</para>
    ///   <para>"Relaciona un evento con los datos generados por el mismo."</para>
    /// labels<para>"generated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Generates"</para><para>"Genera"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#generated">http://www.w3.org/ns/prov#generated</seealso>
    let generated = Prefixed_Name(nsprov, "generated") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:generatedAsDerivation</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"generatedAsDerivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#generatedAsDerivation">http://www.w3.org/ns/prov#generatedAsDerivation</seealso>
    let generatedAsDerivation =
        Prefixed_Name(nsprov, "generatedAsDerivation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:generatedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The time at which an entity was completely created and is available for use."</para>
    ///   <para>"Generation is the completion of production of a new entity by an activity. This entity did not exist before generation and becomes available for usage after this generation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Generation is the completion of production of a new entity by an activity. This entity did not exist before generation and becomes available for usage after this generation."</para>
    /// labels<para>"generated at time"</para><para>"generatedAtTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#generatedAtTime">http://www.w3.org/ns/prov#generatedAtTime</seealso>
    let generatedAtTime = Prefixed_Name(nsprov, "generatedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The _optional_ Activity of an Influence, which used, generated, invalidated, or was the responsibility of some Entity. This property is _not_ used by ActivityInfluence (use prov:activity instead)."</para>
    ///   <para>"This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hadActivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadActivity">http://www.w3.org/ns/prov#hadActivity</seealso>
    let hadActivity = Prefixed_Name(nsprov, "hadActivity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadDelegate</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"hadDelegate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadDelegate">http://www.w3.org/ns/prov#hadDelegate</seealso>
    let hadDelegate = Prefixed_Name(nsprov, "hadDelegate") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadDerivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"inverse property of wasDerivedFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hadDerivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"had derivation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadDerivation">http://www.w3.org/ns/prov#hadDerivation</seealso>
    let hadDerivation = Prefixed_Name(nsprov, "hadDerivation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:hadDictionaryMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hadDictionaryMember"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadDictionaryMember">http://www.w3.org/ns/prov#hadDictionaryMember</seealso>
    let hadDictionaryMember =
        Prefixed_Name(nsprov, "hadDictionaryMember") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:hadGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The _optional_ Generation involved in an Entity's Derivation."</para>
    /// labels<para>"hadGeneration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadGeneration">http://www.w3.org/ns/prov#hadGeneration</seealso>
    let hadGeneration = Prefixed_Name(nsprov, "hadGeneration") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadInfluence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"hadInfluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadInfluence">http://www.w3.org/ns/prov#hadInfluence</seealso>
    let hadInfluence = Prefixed_Name(nsprov, "hadInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hadMember"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"had member"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadMember">http://www.w3.org/ns/prov#hadMember</seealso>
    let hadMember = Prefixed_Name(nsprov, "hadMember") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The _optional_ Plan adopted by an Agent in Association with some Activity. Plan specifications are out of the scope of this specification."</para>
    /// labels<para>"hadPlan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadPlan">http://www.w3.org/ns/prov#hadPlan</seealso>
    let hadPlan = Prefixed_Name(nsprov, "hadPlan") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadPrimarySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A primary source for a topic refers to something produced by some agent with direct experience and knowledge about the topic, at the time of the topic's study, without benefit from hindsight. Because of the directness of primary sources, they 'speak for themselves' in ways that cannot be captured through the filter of secondary sources. As such, it is important for secondary sources to reference those primary sources from which they were derived, so that their reliability can be investigated. A primary source relation is a particular case of derivation of secondary materials from their primary sources. It is recognized that the determination of primary sources can be up to interpretation, and should be done according to conventions accepted within the application's domain."</para>
    /// labels<para>"had primary source"</para><para>"hadPrimarySource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadPrimarySource">http://www.w3.org/ns/prov#hadPrimarySource</seealso>
    let hadPrimarySource = Prefixed_Name(nsprov, "hadPrimarySource") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"had revision"</para><para>"hadRevision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadRevision">http://www.w3.org/ns/prov#hadRevision</seealso>
    let hadRevision = Prefixed_Name(nsprov, "hadRevision") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A role is the function of an entity or agent with respect to an activity, in the context of a usage, generation, invalidation, association, start, and end."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The _optional_ Role that an Entity assumed in the context of an Activity. For example, :baking prov:used :spoon; prov:qualified [ a prov:Usage; prov:entity :spoon; prov:hadRole roles:mixing_implement ]."</para>
    /// labels<para>"hadRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadRole">http://www.w3.org/ns/prov#hadRole</seealso>
    let hadRole = Prefixed_Name(nsprov, "hadRole") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The _optional_ Usage involved in an Entity's Derivation."</para>
    /// labels<para>"hadUsage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadUsage">http://www.w3.org/ns/prov#hadUsage</seealso>
    let hadUsage = Prefixed_Name(nsprov, "hadUsage") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:has_anchor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates anchor URI for a potentially dynamic resource instance."</para>
    /// labels<para>"has_anchor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#has_anchor">http://www.w3.org/ns/prov#has_anchor</seealso>
    let has_anchor = Prefixed_Name(nsprov, "has_anchor") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:has_provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a provenance-URI for a resource; the resource identified by this property presents a provenance record about its subject or anchor resource."</para>
    /// labels<para>"has_provenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#has_provenance">http://www.w3.org/ns/prov#has_provenance</seealso>
    let has_provenance = Prefixed_Name(nsprov, "has_provenance") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:has_query_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a provenance query service that can access provenance related to its subject or anchor resource."</para>
    /// labels<para>"hasProvenanceService"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#has_query_service">http://www.w3.org/ns/prov#has_query_service</seealso>
    let has_query_service = Prefixed_Name(nsprov, "has_query_service") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:influenced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Influence is the capacity of an entity, activity, or agent to have an effect on the character, development, or behavior of another by means of usage, start, end, generation, invalidation, communication, derivation, attribution, association, or delegation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"influenced"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#influenced">http://www.w3.org/ns/prov#influenced</seealso>
    let influenced = Prefixed_Name(nsprov, "influenced") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:influencer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Subproperties of prov:influencer are used to cite the object of an unqualified PROV-O triple whose predicate is a subproperty of prov:wasInfluencedBy (e.g. prov:used, prov:wasGeneratedBy). prov:influencer is used much like rdf:object is used."</para>
    ///   <para>"This property is used as part of the qualified influence pattern. Subclasses of prov:Influence use these subproperties to reference the resource (Entity, Agent, or Activity) whose influence is being qualified."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"influencer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#influencer">http://www.w3.org/ns/prov#influencer</seealso>
    let influencer = Prefixed_Name(nsprov, "influencer") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:informed</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"informed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#informed">http://www.w3.org/ns/prov#informed</seealso>
    let informed = Prefixed_Name(nsprov, "informed") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:insertedKeyEntityPair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"insertedKeyEntityPair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#insertedKeyEntityPair">http://www.w3.org/ns/prov#insertedKeyEntityPair</seealso>
    let insertedKeyEntityPair =
        Prefixed_Name(nsprov, "insertedKeyEntityPair") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:invalidated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"invalidated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#invalidated">http://www.w3.org/ns/prov#invalidated</seealso>
    let invalidated = Prefixed_Name(nsprov, "invalidated") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:invalidatedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Invalidation is the start of the destruction, cessation, or expiry of an existing entity by an activity. The entity is no longer available for use (or further invalidation) after invalidation. Any generation or usage of an entity precedes its invalidation."</para>
    ///   <para>"The time at which an entity was invalidated (i.e., no longer usable)."</para>
    /// labels<para>"invalidated at time"</para><para>"invalidatedAtTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#invalidatedAtTime">http://www.w3.org/ns/prov#invalidatedAtTime</seealso>
    let invalidatedAtTime = Prefixed_Name(nsprov, "invalidatedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:inverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"PROV-O does not define all property inverses. The directionalities defined in PROV-O should be given preference over those not defined. However, if users wish to name the inverse of a PROV-O property, the local name given by prov:inverse should be used."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#inverse">http://www.w3.org/ns/prov#inverse</seealso>
    let inverse = Prefixed_Name(nsprov, "inverse") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:locationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"locationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#locationOf">http://www.w3.org/ns/prov#locationOf</seealso>
    let locationOf = Prefixed_Name(nsprov, "locationOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:mentionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"prov:mentionOf is used to specialize an entity as described in another bundle. It is to be used in conjuction with prov:asInBundle.
    ///
    /// prov:asInBundle is used to cite the Bundle in which the generalization was mentioned."</para>
    /// labels<para>"mentionOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#mentionOf">http://www.w3.org/ns/prov#mentionOf</seealso>
    let mentionOf = Prefixed_Name(nsprov, "mentionOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:n</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A reference to the principal section of the PROV-M document that describes this concept."</para>
    ///   <para>"A reference to the principal section of the PROV-DM document that describes this concept."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#n">http://www.w3.org/ns/prov#n</seealso>
    let n = Prefixed_Name(nsprov, "n") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The position that this OWL term should be listed within documentation. The scope of the documentation (e.g., among all terms, among terms within a prov:category, among properties applying to a particular class, etc.) is unspecified."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#order">http://www.w3.org/ns/prov#order</seealso>
    let order = Prefixed_Name(nsprov, "order") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:pairEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"pairKey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#pairEntity">http://www.w3.org/ns/prov#pairEntity</seealso>
    let pairEntity = Prefixed_Name(nsprov, "pairEntity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:pairKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"pairKey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#pairKey">http://www.w3.org/ns/prov#pairKey</seealso>
    let pairKey = Prefixed_Name(nsprov, "pairKey") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:pingback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a resource to a provenance pingback service that may receive additional provenance links about the resource."</para>
    /// labels<para>"provenance pingback"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#pingback">http://www.w3.org/ns/prov#pingback</seealso>
    let pingback = Prefixed_Name(nsprov, "pingback") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:provenanceUriTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Relates a provenance service to a URI template string for constructing provenance-URIs."</para>
    /// labels<para>"provenanceUriTemplate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#provenanceUriTemplate">http://www.w3.org/ns/prov#provenanceUriTemplate</seealso>
    let provenanceUriTemplate =
        Prefixed_Name(nsprov, "provenanceUriTemplate") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Activity prov:wasAssociatedWith Agent :ag, then it can qualify the Association using prov:qualifiedAssociation [ a prov:Association;  prov:agent :ag; :foo :bar ]."</para>
    ///   <para>"An activity association is an assignment of responsibility to an agent for an activity, indicating that the agent had a role in the activity. It further allows for a plan to be specified, which is the plan intended by the agent to achieve some goals in the context of this activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifiedAssociation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedAssociation">http://www.w3.org/ns/prov#qualifiedAssociation</seealso>
    let qualifiedAssociation =
        Prefixed_Name(nsprov, "qualifiedAssociation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedAssociationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"qualifiedAssociationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedAssociationOf">http://www.w3.org/ns/prov#qualifiedAssociationOf</seealso>
    let qualifiedAssociationOf =
        Prefixed_Name(nsprov, "qualifiedAssociationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Entity prov:wasAttributedTo Agent :ag, then it can qualify how it was influenced using prov:qualifiedAttribution [ a prov:Attribution;  prov:agent :ag; :foo :bar ]."</para>
    ///   <para>"Attribution is the ascribing of an entity to an agent. When an entity e is attributed to agent ag, entity e was generated by some unspecified activity that in turn was associated to agent ag. Thus, this relation is useful when the activity is not known, or irrelevant."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifiedAttribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedAttribution">http://www.w3.org/ns/prov#qualifiedAttribution</seealso>
    let qualifiedAttribution =
        Prefixed_Name(nsprov, "qualifiedAttribution") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedAttributionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"qualifiedAttributionOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedAttributionOf">http://www.w3.org/ns/prov#qualifiedAttributionOf</seealso>
    let qualifiedAttributionOf =
        Prefixed_Name(nsprov, "qualifiedAttributionOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Activity prov:wasInformedBy Activity :a, then it can qualify how it was influenced using prov:qualifiedCommunication [ a prov:Communication;  prov:activity :a; :foo :bar ]."</para>
    /// labels<para>"qualifiedCommunication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedCommunication">http://www.w3.org/ns/prov#qualifiedCommunication</seealso>
    let qualifiedCommunication =
        Prefixed_Name(nsprov, "qualifiedCommunication") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedCommunicationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"qualifiedCommunicationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedCommunicationOf">http://www.w3.org/ns/prov#qualifiedCommunicationOf</seealso>
    let qualifiedCommunicationOf =
        Prefixed_Name(nsprov, "qualifiedCommunicationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedDelegation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Agent prov:actedOnBehalfOf Agent :ag, then it can qualify how with prov:qualifiedResponsibility [ a prov:Responsibility;  prov:agent :ag; :foo :bar ]."</para>
    /// labels<para>"qualifiedDelegation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedDelegation">http://www.w3.org/ns/prov#qualifiedDelegation</seealso>
    let qualifiedDelegation =
        Prefixed_Name(nsprov, "qualifiedDelegation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedDelegationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"qualifiedDelegationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedDelegationOf">http://www.w3.org/ns/prov#qualifiedDelegationOf</seealso>
    let qualifiedDelegationOf =
        Prefixed_Name(nsprov, "qualifiedDelegationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedDerivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Entity prov:wasDerivedFrom Entity :e, then it can qualify how it was derived using prov:qualifiedDerivation [ a prov:Derivation;  prov:entity :e; :foo :bar ]."</para>
    /// labels<para>"qualifiedDerivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedDerivation">http://www.w3.org/ns/prov#qualifiedDerivation</seealso>
    let qualifiedDerivation =
        Prefixed_Name(nsprov, "qualifiedDerivation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedDerivationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"qualifiedDerivationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedDerivationOf">http://www.w3.org/ns/prov#qualifiedDerivationOf</seealso>
    let qualifiedDerivationOf =
        Prefixed_Name(nsprov, "qualifiedDerivationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Activity prov:wasEndedBy Entity :e1, then it can qualify how it was ended using prov:qualifiedEnd [ a prov:End;  prov:entity :e1; :foo :bar ]."</para>
    /// labels<para>"qualifiedEnd"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedEnd">http://www.w3.org/ns/prov#qualifiedEnd</seealso>
    let qualifiedEnd = Prefixed_Name(nsprov, "qualifiedEnd") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedEndOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"qualifiedEndOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedEndOf">http://www.w3.org/ns/prov#qualifiedEndOf</seealso>
    let qualifiedEndOf = Prefixed_Name(nsprov, "qualifiedEndOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property links a subproperty of prov:wasInfluencedBy with the subclass of prov:Influence and the qualifying property that are used to qualify it.
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
    /// Note how the value of the unqualified influence (prov:wasGeneratedBy :activity1) is mirrored as the value of the prov:activity (or prov:entity, or prov:agent) property on the influence class."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedForm">http://www.w3.org/ns/prov#qualifiedForm</seealso>
    let qualifiedForm = Prefixed_Name(nsprov, "qualifiedForm") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Activity prov:generated Entity :e, then it can qualify how it performed the Generation using prov:qualifiedGeneration [ a prov:Generation;  prov:entity :e; :foo :bar ]."</para>
    /// labels<para>"qualifiedGeneration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedGeneration">http://www.w3.org/ns/prov#qualifiedGeneration</seealso>
    let qualifiedGeneration =
        Prefixed_Name(nsprov, "qualifiedGeneration") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedGenerationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"qualifiedGenerationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedGenerationOf">http://www.w3.org/ns/prov#qualifiedGenerationOf</seealso>
    let qualifiedGenerationOf =
        Prefixed_Name(nsprov, "qualifiedGenerationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedInfluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Because prov:qualifiedInfluence is a broad relation, the more specific relations (qualifiedCommunication, qualifiedDelegation, qualifiedEnd, etc.) should be used when applicable."</para>
    ///   <para>"Influence is the capacity of an entity, activity, or agent to have an effect on the character, development, or behavior of another by means of usage, start, end, generation, invalidation, communication, derivation, attribution, association, or delegation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifiedInfluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedInfluence">http://www.w3.org/ns/prov#qualifiedInfluence</seealso>
    let qualifiedInfluence = Prefixed_Name(nsprov, "qualifiedInfluence") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedInfluenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Influence is the capacity of an entity, activity, or agent to have an effect on the character, development, or behavior of another by means of usage, start, end, generation, invalidation, communication, derivation, attribution, association, or delegation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifiedInfluenceOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedInfluenceOf">http://www.w3.org/ns/prov#qualifiedInfluenceOf</seealso>
    let qualifiedInfluenceOf =
        Prefixed_Name(nsprov, "qualifiedInfluenceOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedInsertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"qualifiedInsertion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedInsertion">http://www.w3.org/ns/prov#qualifiedInsertion</seealso>
    let qualifiedInsertion = Prefixed_Name(nsprov, "qualifiedInsertion") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedInvalidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Entity prov:wasInvalidatedBy Activity :a, then it can qualify how it was invalidated using prov:qualifiedInvalidation [ a prov:Invalidation;  prov:activity :a; :foo :bar ]."</para>
    /// labels<para>"qualifiedInvalidation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedInvalidation">http://www.w3.org/ns/prov#qualifiedInvalidation</seealso>
    let qualifiedInvalidation =
        Prefixed_Name(nsprov, "qualifiedInvalidation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedInvalidationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"qualifiedInvalidationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedInvalidationOf">http://www.w3.org/ns/prov#qualifiedInvalidationOf</seealso>
    let qualifiedInvalidationOf =
        Prefixed_Name(nsprov, "qualifiedInvalidationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedPrimarySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Entity prov:hadPrimarySource Entity :e, then it can qualify how using prov:qualifiedPrimarySource [ a prov:PrimarySource; prov:entity :e; :foo :bar ]."</para>
    /// labels<para>"qualifiedPrimarySource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedPrimarySource">http://www.w3.org/ns/prov#qualifiedPrimarySource</seealso>
    let qualifiedPrimarySource =
        Prefixed_Name(nsprov, "qualifiedPrimarySource") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedQuotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Entity prov:wasQuotedFrom Entity :e, then it can qualify how using prov:qualifiedQuotation [ a prov:Quotation;  prov:entity :e; :foo :bar ]."</para>
    /// labels<para>"qualifiedQuotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedQuotation">http://www.w3.org/ns/prov#qualifiedQuotation</seealso>
    let qualifiedQuotation = Prefixed_Name(nsprov, "qualifiedQuotation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedQuotationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"qualifiedQuotationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedQuotationOf">http://www.w3.org/ns/prov#qualifiedQuotationOf</seealso>
    let qualifiedQuotationOf =
        Prefixed_Name(nsprov, "qualifiedQuotationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedRemoval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"qualifiedRemoval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedRemoval">http://www.w3.org/ns/prov#qualifiedRemoval</seealso>
    let qualifiedRemoval = Prefixed_Name(nsprov, "qualifiedRemoval") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Entity prov:wasRevisionOf Entity :e, then it can qualify how it was revised using prov:qualifiedRevision [ a prov:Revision;  prov:entity :e; :foo :bar ]."</para>
    /// labels<para>"qualifiedRevision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedRevision">http://www.w3.org/ns/prov#qualifiedRevision</seealso>
    let qualifiedRevision = Prefixed_Name(nsprov, "qualifiedRevision") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedSourceOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"qualifiedSourceOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedSourceOf">http://www.w3.org/ns/prov#qualifiedSourceOf</seealso>
    let qualifiedSourceOf = Prefixed_Name(nsprov, "qualifiedSourceOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Activity prov:wasStartedBy Entity :e1, then it can qualify how it was started using prov:qualifiedStart [ a prov:Start;  prov:entity :e1; :foo :bar ]."</para>
    /// labels<para>"qualifiedStart"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedStart">http://www.w3.org/ns/prov#qualifiedStart</seealso>
    let qualifiedStart = Prefixed_Name(nsprov, "qualifiedStart") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedStartOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"qualifiedStartOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedStartOf">http://www.w3.org/ns/prov#qualifiedStartOf</seealso>
    let qualifiedStartOf = Prefixed_Name(nsprov, "qualifiedStartOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this Activity prov:used Entity :e, then it can qualify how it used it using prov:qualifiedUsage [ a prov:Usage; prov:entity :e; :foo :bar ]."</para>
    /// labels<para>"qualifiedUsage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedUsage">http://www.w3.org/ns/prov#qualifiedUsage</seealso>
    let qualifiedUsage = Prefixed_Name(nsprov, "qualifiedUsage") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedUsingActivity</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"qualifiedUsingActivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedUsingActivity">http://www.w3.org/ns/prov#qualifiedUsingActivity</seealso>
    let qualifiedUsingActivity =
        Prefixed_Name(nsprov, "qualifiedUsingActivity") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:quotedAs</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"quotedAs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#quotedAs">http://www.w3.org/ns/prov#quotedAs</seealso>
    let quotedAs = Prefixed_Name(nsprov, "quotedAs") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:removedKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"removedKey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#removedKey">http://www.w3.org/ns/prov#removedKey</seealso>
    let removedKey = Prefixed_Name(nsprov, "removedKey") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:revisedEntity</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"revisedEntity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#revisedEntity">http://www.w3.org/ns/prov#revisedEntity</seealso>
    let revisedEntity = Prefixed_Name(nsprov, "revisedEntity") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:sharesDefinitionWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#sharesDefinitionWith">http://www.w3.org/ns/prov#sharesDefinitionWith</seealso>
    let sharesDefinitionWith =
        Prefixed_Name(nsprov, "sharesDefinitionWith") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:specializationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An entity that is a specialization of another shares all aspects of the latter, and additionally presents more specific aspects of the same thing as the latter. In particular, the lifetime of the entity being specialized contains that of any specialization. Examples of aspects include a time period, an abstraction, and a context associated with the entity."</para>
    ///   <para>"An entity that is specialization of (... is a kind of) another entity and shares all aspects of the later including its own specific aspects. E.g., Bucket sort algorithm is a specialization of (a kind of) Distribution sort."</para>
    /// labels<para>"specialization of"</para><para>"prov:specializationOf"</para><para>"specializationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#specializationOf">http://www.w3.org/ns/prov#specializationOf</seealso>
    let specializationOf = Prefixed_Name(nsprov, "specializationOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:started</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"started"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#started">http://www.w3.org/ns/prov#started</seealso>
    let started = Prefixed_Name(nsprov, "started") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:startedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Start is when an activity is deemed to have been started by an entity, known as trigger. The activity did not exist before its start. Any usage, generation, or invalidation involving an activity follows the activity's start. A start may refer to a trigger entity that set off the activity, or to an activity, known as starter, that generated the trigger."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The time at which an activity started. See also prov:endedAtTime."</para>
    ///   <para>"Fecha de inicio del cambio"</para>
    /// labels<para>"started at time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"startedAtTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Fecha de inicio del cambio"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#startedAtTime">http://www.w3.org/ns/prov#startedAtTime</seealso>
    let startedAtTime = Prefixed_Name(nsprov, "startedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:todo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#todo">http://www.w3.org/ns/prov#todo</seealso>
    let todo = Prefixed_Name(nsprov, "todo") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:unqualifiedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Classes and properties used to qualify relationships are annotated with prov:unqualifiedForm to indicate the property used to assert an unqualified provenance relation."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#unqualifiedForm">http://www.w3.org/ns/prov#unqualifiedForm</seealso>
    let unqualifiedForm = Prefixed_Name(nsprov, "unqualifiedForm") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:used</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A prov:Entity that was used by this prov:Activity. For example, :baking prov:used :spoon, :egg, :oven ."</para>
    ///   <para>"Usage is the beginning of utilizing an entity by an activity. Before usage, the activity had not begun to utilize this entity and could not have been affected by the entity."</para>
    ///   <para>"Explicit redefinition for a reuse in SemTS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#used">http://www.w3.org/ns/prov#used</seealso>
    let used = Prefixed_Name(nsprov, "used") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#value">http://www.w3.org/ns/prov#value</seealso>
    let value = Prefixed_Name(nsprov, "value") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:wasActivityOfInfluence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"wasActivityOfInfluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasActivityOfInfluence">http://www.w3.org/ns/prov#wasActivityOfInfluence</seealso>
    let wasActivityOfInfluence =
        Prefixed_Name(nsprov, "wasActivityOfInfluence") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:wasAssociateFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wasAssociateFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasAssociateFor">http://www.w3.org/ns/prov#wasAssociateFor</seealso>
    let wasAssociateFor = Prefixed_Name(nsprov, "wasAssociateFor") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasAssociatedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An activity association is an assignment of responsibility to an agent for an activity, indicating that the agent had a role in the activity. It further allows for a plan to be specified, which is the plan intended by the agent to achieve some goals in the context of this activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"wasAssociatedFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasAssociatedFor">http://www.w3.org/ns/prov#wasAssociatedFor</seealso>
    let wasAssociatedFor = Prefixed_Name(nsprov, "wasAssociatedFor") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A prov:Agent that had some (unspecified) responsibility for an occurrence of a prov:Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An activity association is an assignment of responsibility to an agent for an activity, indicating that the agent had a role in the activity. It further allows for a plan to be specified, which is the plan intended by the agent to achieve some goals in the context of this activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An prov:Agent that had some (unspecified) responsibility for the occurrence of this prov:Activity."</para>
    /// labels<para>"wasAssociatedWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"was associated with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasAssociatedWith">http://www.w3.org/ns/prov#wasAssociatedWith</seealso>
    let wasAssociatedWith = Prefixed_Name(nsprov, "wasAssociatedWith") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasAttributedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Attribution is the ascribing of an entity to an agent."</para>
    ///   <para>"Attribution is the ascribing of an entity to an agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"It links the annotation of an ontological entity with information about its vagueness to the agent who made the annotation itself."</para>
    /// labels<para>"wasAttributedTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"prov:wasAttributedTo"</para><para>"was attributed to"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasAttributedTo">http://www.w3.org/ns/prov#wasAttributedTo</seealso>
    let wasAttributedTo = Prefixed_Name(nsprov, "wasAttributedTo") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A derivation is a transformation of an entity into another, an update of an entity resulting in a new one, or the construction of a new entity based on a pre-existing entity. In the context of the Simulation ontology this property links a Simulation to its source"</para>
    ///   <para>"Entity the experiment was derived from"</para>
    ///   <para>"A derivation is a transformation of an entity into another, an update of an entity resulting in a new one, or the construction of a new entity based on a pre-existing entity."</para>
    ///   <para>"A derivation is a transformation of an entity into another, an update of an entity resulting in a new one, or the construction of a new entity based on a pre-existing entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Explicit redefinition for a reuse in SemTS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The more specific subproperties of prov:wasDerivedFrom (i.e., prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource) should be used when applicable."</para>
    /// labels<para>"was Derived From"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"wasDerivedFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"was derived from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"prov:wasDerivedFrom"</para><para>"was derived from"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasDerivedFrom">http://www.w3.org/ns/prov#wasDerivedFrom</seealso>
    let wasDerivedFrom = Prefixed_Name(nsprov, "wasDerivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasEndedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"End is when an activity is deemed to have ended. An end may refer to an entity, known as trigger, that terminated the activity."</para>
    /// labels<para>"wasEndedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasEndedBy">http://www.w3.org/ns/prov#wasEndedBy</seealso>
    let wasEndedBy = Prefixed_Name(nsprov, "wasEndedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasGeneratedAtTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasGeneratedAtTime">http://www.w3.org/ns/prov#wasGeneratedAtTime</seealso>
    let wasGeneratedAtTime = Prefixed_Name(nsprov, "wasGeneratedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasGeneratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an entity was generated by an activity."</para>
    ///   <para>"Generation is the completion of production of a new entity by an activity. This entity did not exist before generation and becomes available for usage after this generation."</para>
    /// labels<para>"wasGeneratedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"was generated by"</para><para>"was generated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasGeneratedBy">http://www.w3.org/ns/prov#wasGeneratedBy</seealso>
    let wasGeneratedBy = Prefixed_Name(nsprov, "wasGeneratedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasInfluencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Influence is the capacity of an entity, activity, or agent to have an effect on the character, development, or behavior of another by means of usage, start, end, generation, invalidation, communication, derivation, attribution, association, or delegation."</para>
    ///   <para>"Influence is the capacity of an entity, activity, or agent to have an effect on the character, development, or behavior of another by means of usage, start, end, generation, invalidation, communication, derivation, attribution, association, or delegation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Because prov:wasInfluencedBy is a broad relation, its more specific subproperties (e.g. prov:wasInformedBy, prov:actedOnBehalfOf, prov:wasEndedBy, etc.) should be used when applicable."</para>
    ///   <para>"Indicates that one entity, activity, or agent was influenced by another."</para>
    /// labels<para>"prov:wasInfluencedBy"</para><para>"was influenced by"</para><para>"was influence by"</para><para>"wasInfluencedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"was influenced by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasInfluencedBy">http://www.w3.org/ns/prov#wasInfluencedBy</seealso>
    let wasInfluencedBy = Prefixed_Name(nsprov, "wasInfluencedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasInformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An activity a2 is dependent on or informed by another activity a1, by way of some unspecified entity that is generated by a1 and used by a2."</para>
    /// labels<para>"wasInformedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasInformedBy">http://www.w3.org/ns/prov#wasInformedBy</seealso>
    let wasInformedBy = Prefixed_Name(nsprov, "wasInformedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasInvalidatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Invalidation is the start of the destruction, cessation, or expiry of an existing entity by an activity. The entity is no longer available for use (or further invalidation) after invalidation. Any generation or usage of an entity precedes its invalidation."</para>
    /// labels<para>"was invalidated by"</para><para>"wasInvalidatedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasInvalidatedBy">http://www.w3.org/ns/prov#wasInvalidatedBy</seealso>
    let wasInvalidatedBy = Prefixed_Name(nsprov, "wasInvalidatedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wasMemberOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"was member of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasMemberOf">http://www.w3.org/ns/prov#wasMemberOf</seealso>
    let wasMemberOf = Prefixed_Name(nsprov, "wasMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasPlanOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"wasPlanOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasPlanOf">http://www.w3.org/ns/prov#wasPlanOf</seealso>
    let wasPlanOf = Prefixed_Name(nsprov, "wasPlanOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasPrimarySourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wasPrimarySourceOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"was primary source of"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasPrimarySourceOf">http://www.w3.org/ns/prov#wasPrimarySourceOf</seealso>
    let wasPrimarySourceOf = Prefixed_Name(nsprov, "wasPrimarySourceOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasQuotedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An entity is derived from an original entity by copying, or 'quoting', some or all of it."</para>
    /// labels<para>"wasQuotedFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasQuotedFrom">http://www.w3.org/ns/prov#wasQuotedFrom</seealso>
    let wasQuotedFrom = Prefixed_Name(nsprov, "wasQuotedFrom") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasRevisionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A revision is a derivation for which the resulting entity is a revised version of some original. The implication here is that the resulting entity contains substantial content from the original. Revision is a particular case of derivation."</para>
    ///   <para>"A revision is a derivation that revises an entity into a revised version."</para>
    /// labels<para>"prov:wasRevisionOf"</para><para>"was revision of"</para><para>"wasRevisionOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasRevisionOf">http://www.w3.org/ns/prov#wasRevisionOf</seealso>
    let wasRevisionOf = Prefixed_Name(nsprov, "wasRevisionOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasRoleIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A role is the function of an entity or agent with respect to an activity, in the context of a usage, generation, invalidation, association, start, and end."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"wasRoleIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasRoleIn">http://www.w3.org/ns/prov#wasRoleIn</seealso>
    let wasRoleIn = Prefixed_Name(nsprov, "wasRoleIn") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasStartedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Start is when an activity is deemed to have started. A start may refer to an entity, known as trigger, that initiated the activity."</para>
    /// labels<para>"wasStartedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasStartedBy">http://www.w3.org/ns/prov#wasStartedBy</seealso>
    let wasStartedBy = Prefixed_Name(nsprov, "wasStartedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasUsedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"wasUsedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasUsedBy">http://www.w3.org/ns/prov#wasUsedBy</seealso>
    let wasUsedBy = Prefixed_Name(nsprov, "wasUsedBy") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:wasUsedInDerivation</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"wasUsedInDerivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasUsedInDerivation">http://www.w3.org/ns/prov#wasUsedInDerivation</seealso>
    let wasUsedInDerivation =
        Prefixed_Name(nsprov, "wasUsedInDerivation") |> PrefixedName
