namespace http.w3id.org.CEON.ontology.actorODP.slash

open DoxAletheia

module ceon_actorODP =
    let _namespace_name = "http://w3id.org/CEON/ontology/actorODP/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actorODP/0.4/"></see>
    /// </summary>
    let ``_0.4/`` = _prefix "0.4/"
    /// <summary>
    /// An agent able to act in the context of a circular value network, e.g. an organisation, person.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/Actor"></see></summary>
    let Actor = _prefix "Actor"
    /// <summary>
    /// Something that the actor is capable of doing, e.g. perfomring a certain role in a process, based on some properties, such as access to infrastructure, resources and know-how.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/Capability"></see></summary>
    let Capability = _prefix "Capability"
    /// <summary>
    /// The relation involving the role of a certain actor with respect to a value network or a process in such a network, e.g. an organisation (actor) acting as the recycler (role) in a glass recycling value netowrk (network) at a specific point or period in time. Or an organisation (actor) acting as the dismantler (role) in a dismantling step of a building deconstruction process (process step) at a specific point or period in time.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/CollaborationParticipation"></see></summary>
    let CollaborationParticipation = _prefix "CollaborationParticipation"
    /// <summary>
    /// Represents the participation of objects in some situation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/Participation"></see></summary>
    let Participation = _prefix "Participation"
    /// <summary>
    /// An infrastructure refers to facilities, services, or systems for participations to function.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/Infrastructure"></see></summary>
    let Infrastructure = _prefix "Infrastructure"
    /// <summary>
    /// The start of a time interval.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participationStartTime"></see></summary>
    let participationStartTime = _prefix "participationStartTime"
    /// <summary>
    /// The point in time when something took place or was valid.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participationTimePoint"></see></summary>
    let participationTimePoint = _prefix "participationTimePoint"
    /// <summary>
    /// The generic relation representing the particpation of a resource in some relation. For example, it can be specialized to represent a reified version of an object or data property.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/ResourceParticipation"></see></summary>
    let ResourceParticipation = _prefix "ResourceParticipation"
    /// <summary>
    /// The relation involving the role of a certain actor with respect to a certain resource, e.g. an organisation or individual (actor) owning (role) a specific product (resource) at a specific point or period in time.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/ResourceRelation"></see></summary>
    let ResourceRelation = _prefix "ResourceRelation"
    /// <summary>
    /// A role that an actor can take in a specific context. Applies both to roles in the context of resources, such as owner, manufacturer, reseller etc. of that resource, as well as roles in relation to a circular value network, such as recycler, dismantler, transporter etc., in relation to a material flow.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// An actor participates in a collaboration based on that it has some capability that is useful for the collaboration.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/basedOnCapability"></see></summary>
    let basedOnCapability = _prefix "basedOnCapability"
    /// <summary>
    /// Relates to the actor holding the capability.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/capabilityOf"></see></summary>
    let capabilityOf = _prefix "capabilityOf"
    /// <summary>
    /// Relates some properties to the capability, such as the parameters of it, or the needed resources.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/capabilityProperty"></see></summary>
    let capabilityProperty = _prefix "capabilityProperty"
    /// <summary>
    /// Holds the value of the role of the participant in this participation relation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participantRole"></see></summary>
    let participantRole = _prefix "participantRole"
    /// <summary>
    /// Holds the value of the actor involved in this participation relation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participatingActor"></see></summary>
    let participatingActor = _prefix "participatingActor"
    /// <summary>
    /// Holds the value of the infrastructure involved in this participation relation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participatingInfrastructure"></see></summary>
    let participatingInfrastructure = _prefix "participatingInfrastructure"
    /// <summary>
    /// Participating object in a resource participation. This is part of a resource participation that can be a directional relation, and the participating object is the end point of the relation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participatingObject"></see></summary>
    let participatingObject = _prefix "participatingObject"
    /// <summary>
    /// The resource that this participation relation relates to, i.e. for which the actor holds the specified role.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participatingResource"></see></summary>
    let participatingResource = _prefix "participatingResource"
    /// <summary>
    /// Participating subject in a resource participation. This is part of a resource participation that can be a directional relation, and the participating subject is the starting point of the relation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participatingSubject"></see></summary>
    let participatingSubject = _prefix "participatingSubject"
    /// <summary>
    /// The end of a time interval.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participationEndTime"></see></summary>
    let participationEndTime = _prefix "participationEndTime"
    /// <summary>
    /// The collaboration or process that this participation relates to.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participationIn"></see></summary>
    let participationIn = _prefix "participationIn"
