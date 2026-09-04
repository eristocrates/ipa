#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ceon-actorODP`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/actorODP/" "ceon-actorODP"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Actor^^xsd:string</para>
    ///   <para>rdfs:comment : An agent able to act in the context of a circular value network, e.g. an organisation, person.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/Actor">ceon-actorODP:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>rdfs:label : Capability^^xsd:string</para>
    ///   <para>rdfs:comment : Something that the actor is capable of doing, e.g. perfomring a certain role in a process, based on some properties, such as access to infrastructure, resources and know-how.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/Capability">ceon-actorODP:Capability</a>
    /// </summary>
    let Capability = _prefixId.prefix "Capability"
    /// <summary>
    ///   <para>rdfs:label : Collaboration Participation^^xsd:string</para>
    ///   <para>rdfs:comment : The relation involving the role of a certain actor with respect to a value network or a process in such a network, e.g. an organisation (actor) acting as the recycler (role) in a glass recycling value netowrk (network) at a specific point or period in time. Or an organisation (actor) acting as the dismantler (role) in a dismantling step of a building deconstruction process (process step) at a specific point or period in time.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/CollaborationParticipation">ceon-actorODP:CollaborationParticipation</a>
    /// </summary>
    let CollaborationParticipation = _prefixId.prefix "CollaborationParticipation"
    /// <summary>
    ///   <para>rdfs:label : Infrastructure^^xsd:string</para>
    ///   <para>rdfs:comment : An infrastructure refers to facilities, services, or systems for participations to function.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/Infrastructure">ceon-actorODP:Infrastructure</a>
    /// </summary>
    let Infrastructure = _prefixId.prefix "Infrastructure"
    /// <summary>
    ///   <para>rdfs:label : Participation^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the participation of objects in some situation.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/Participation">ceon-actorODP:Participation</a>
    /// </summary>
    let Participation = _prefixId.prefix "Participation"
    /// <summary>
    ///   <para>rdfs:label : Resource Participation^^xsd:string</para>
    ///   <para>rdfs:comment : The generic relation representing the particpation of a resource in some relation. For example, it can be specialized to represent a reified version of an object or data property.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/ResourceParticipation">ceon-actorODP:ResourceParticipation</a>
    /// </summary>
    let ResourceParticipation = _prefixId.prefix "ResourceParticipation"
    /// <summary>
    ///   <para>rdfs:label : Resource Relation^^xsd:string</para>
    ///   <para>rdfs:comment : The relation involving the role of a certain actor with respect to a certain resource, e.g. an organisation or individual (actor) owning (role) a specific product (resource) at a specific point or period in time.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/ResourceRelation">ceon-actorODP:ResourceRelation</a>
    /// </summary>
    let ResourceRelation = _prefixId.prefix "ResourceRelation"
    /// <summary>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <para>rdfs:comment : A role that an actor can take in a specific context. Applies both to roles in the context of resources, such as owner, manufacturer, reseller etc. of that resource, as well as roles in relation to a circular value network, such as recycler, dismantler, transporter etc., in relation to a material flow.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/Role">ceon-actorODP:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : based on capability^^xsd:string</para>
    ///   <para>rdfs:comment : An actor participates in a collaboration based on that it has some capability that is useful for the collaboration.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/basedOnCapability">ceon-actorODP:basedOnCapability</a>
    /// </summary>
    let basedOnCapability = _prefixId.prefix "basedOnCapability"
    /// <summary>
    ///   <para>rdfs:label : capability of^^xsd:string</para>
    ///   <para>rdfs:comment : Relates to the actor holding the capability.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/capabilityOf">ceon-actorODP:capabilityOf</a>
    /// </summary>
    let capabilityOf = _prefixId.prefix "capabilityOf"
    /// <summary>
    ///   <para>rdfs:label : capability property^^xsd:string</para>
    ///   <para>rdfs:comment : Relates some properties to the capability, such as the parameters of it, or the needed resources.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/capabilityProperty">ceon-actorODP:capabilityProperty</a>
    /// </summary>
    let capabilityProperty = _prefixId.prefix "capabilityProperty"
    /// <summary>
    ///   <para>rdfs:label : participant role^^xsd:string</para>
    ///   <para>rdfs:comment : Holds the value of the role of the participant in this participation relation.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/participantRole">ceon-actorODP:participantRole</a>
    /// </summary>
    let participantRole = _prefixId.prefix "participantRole"
    /// <summary>
    ///   <para>rdfs:label : participating actor^^xsd:string</para>
    ///   <para>rdfs:comment : Holds the value of the actor involved in this participation relation.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/participatingActor">ceon-actorODP:participatingActor</a>
    /// </summary>
    let participatingActor = _prefixId.prefix "participatingActor"
    /// <summary>
    ///   <para>rdfs:label : participating infrastructure^^xsd:string</para>
    ///   <para>rdfs:comment : Holds the value of the infrastructure involved in this participation relation.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/participatingInfrastructure">ceon-actorODP:participatingInfrastructure</a>
    /// </summary>
    let participatingInfrastructure = _prefixId.prefix "participatingInfrastructure"
    /// <summary>
    ///   <para>rdfs:label : participating object^^xsd:string</para>
    ///   <para>rdfs:comment : Participating object in a resource participation. This is part of a resource participation that can be a directional relation, and the participating object is the end point of the relation.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/participatingObject">ceon-actorODP:participatingObject</a>
    /// </summary>
    let participatingObject = _prefixId.prefix "participatingObject"
    /// <summary>
    ///   <para>rdfs:label : participating resource^^xsd:string</para>
    ///   <para>rdfs:comment : The resource that this participation relation relates to, i.e. for which the actor holds the specified role.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/participatingResource">ceon-actorODP:participatingResource</a>
    /// </summary>
    let participatingResource = _prefixId.prefix "participatingResource"
    /// <summary>
    ///   <para>rdfs:label : participating subject^^xsd:string</para>
    ///   <para>rdfs:comment : Participating subject in a resource participation. This is part of a resource participation that can be a directional relation, and the participating subject is the starting point of the relation.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/participatingSubject">ceon-actorODP:participatingSubject</a>
    /// </summary>
    let participatingSubject = _prefixId.prefix "participatingSubject"
    /// <summary>
    ///   <para>rdfs:label : participation end time^^xsd:string</para>
    ///   <para>rdfs:comment : The end of a time interval.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/participationEndTime">ceon-actorODP:participationEndTime</a>
    /// </summary>
    let participationEndTime = _prefixId.prefix "participationEndTime"
    /// <summary>
    ///   <para>rdfs:label : participation in^^xsd:string</para>
    ///   <para>rdfs:comment : The collaboration or process that this participation relates to.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/participationIn">ceon-actorODP:participationIn</a>
    /// </summary>
    let participationIn = _prefixId.prefix "participationIn"
    /// <summary>
    ///   <para>rdfs:label : participation start time^^xsd:string</para>
    ///   <para>rdfs:comment : The start of a time interval.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/participationStartTime">ceon-actorODP:participationStartTime</a>
    /// </summary>
    let participationStartTime = _prefixId.prefix "participationStartTime"
    /// <summary>
    ///   <para>rdfs:label : participation time point^^xsd:string</para>
    ///   <para>rdfs:comment : The point in time when something took place or was valid.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/actorODP/participationTimePoint">ceon-actorODP:participationTimePoint</a>
    /// </summary>
    let participationTimePoint = _prefixId.prefix "participationTimePoint"
