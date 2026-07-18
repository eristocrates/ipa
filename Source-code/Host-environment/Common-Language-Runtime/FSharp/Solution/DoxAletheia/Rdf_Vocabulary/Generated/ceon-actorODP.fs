namespace http.w3id.org.CEON.ontology.actorODP.slash

open DoxAletheia.Rdf_Vocabulary

module ceon_actorODP =
    let _namespace_name = "http://w3id.org/CEON/ontology/actorODP/"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/actorODP/0.4/"></see>
    /// </summary>
    let ``_0.4/`` = Namespaced_IRI.parse _namespace_name "0.4/" |> NamespacedName
    /// <summary>
    /// An agent able to act in the context of a circular value network, e.g. an organisation, person.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName
    /// <summary>
    /// Something that the actor is capable of doing, e.g. perfomring a certain role in a process, based on some properties, such as access to infrastructure, resources and know-how.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/Capability"></see></summary>
    let Capability = Namespaced_IRI.parse _namespace_name "Capability" |> NamespacedName

    /// <summary>
    /// The relation involving the role of a certain actor with respect to a value network or a process in such a network, e.g. an organisation (actor) acting as the recycler (role) in a glass recycling value netowrk (network) at a specific point or period in time. Or an organisation (actor) acting as the dismantler (role) in a dismantling step of a building deconstruction process (process step) at a specific point or period in time.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/CollaborationParticipation"></see></summary>
    let CollaborationParticipation =
        Namespaced_IRI.parse _namespace_name "CollaborationParticipation" |> NamespacedName

    /// <summary>
    /// Represents the participation of objects in some situation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/Participation"></see></summary>
    let Participation =
        Namespaced_IRI.parse _namespace_name "Participation" |> NamespacedName

    /// <summary>
    /// An infrastructure refers to facilities, services, or systems for participations to function.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/Infrastructure"></see></summary>
    let Infrastructure =
        Namespaced_IRI.parse _namespace_name "Infrastructure" |> NamespacedName

    /// <summary>
    /// The start of a time interval.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participationStartTime"></see></summary>
    let participationStartTime =
        Namespaced_IRI.parse _namespace_name "participationStartTime" |> NamespacedName

    /// <summary>
    /// The point in time when something took place or was valid.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participationTimePoint"></see></summary>
    let participationTimePoint =
        Namespaced_IRI.parse _namespace_name "participationTimePoint" |> NamespacedName

    /// <summary>
    /// The generic relation representing the particpation of a resource in some relation. For example, it can be specialized to represent a reified version of an object or data property.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/ResourceParticipation"></see></summary>
    let ResourceParticipation =
        Namespaced_IRI.parse _namespace_name "ResourceParticipation" |> NamespacedName

    /// <summary>
    /// The relation involving the role of a certain actor with respect to a certain resource, e.g. an organisation or individual (actor) owning (role) a specific product (resource) at a specific point or period in time.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/ResourceRelation"></see></summary>
    let ResourceRelation =
        Namespaced_IRI.parse _namespace_name "ResourceRelation" |> NamespacedName

    /// <summary>
    /// A role that an actor can take in a specific context. Applies both to roles in the context of resources, such as owner, manufacturer, reseller etc. of that resource, as well as roles in relation to a circular value network, such as recycler, dismantler, transporter etc., in relation to a material flow.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    /// An actor participates in a collaboration based on that it has some capability that is useful for the collaboration.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/basedOnCapability"></see></summary>
    let basedOnCapability =
        Namespaced_IRI.parse _namespace_name "basedOnCapability" |> NamespacedName

    /// <summary>
    /// Relates to the actor holding the capability.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/capabilityOf"></see></summary>
    let capabilityOf =
        Namespaced_IRI.parse _namespace_name "capabilityOf" |> NamespacedName

    /// <summary>
    /// Relates some properties to the capability, such as the parameters of it, or the needed resources.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/capabilityProperty"></see></summary>
    let capabilityProperty =
        Namespaced_IRI.parse _namespace_name "capabilityProperty" |> NamespacedName

    /// <summary>
    /// Holds the value of the role of the participant in this participation relation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participantRole"></see></summary>
    let participantRole =
        Namespaced_IRI.parse _namespace_name "participantRole" |> NamespacedName

    /// <summary>
    /// Holds the value of the actor involved in this participation relation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participatingActor"></see></summary>
    let participatingActor =
        Namespaced_IRI.parse _namespace_name "participatingActor" |> NamespacedName

    /// <summary>
    /// Holds the value of the infrastructure involved in this participation relation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participatingInfrastructure"></see></summary>
    let participatingInfrastructure =
        Namespaced_IRI.parse _namespace_name "participatingInfrastructure" |> NamespacedName

    /// <summary>
    /// Participating object in a resource participation. This is part of a resource participation that can be a directional relation, and the participating object is the end point of the relation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participatingObject"></see></summary>
    let participatingObject =
        Namespaced_IRI.parse _namespace_name "participatingObject" |> NamespacedName

    /// <summary>
    /// The resource that this participation relation relates to, i.e. for which the actor holds the specified role.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participatingResource"></see></summary>
    let participatingResource =
        Namespaced_IRI.parse _namespace_name "participatingResource" |> NamespacedName

    /// <summary>
    /// Participating subject in a resource participation. This is part of a resource participation that can be a directional relation, and the participating subject is the starting point of the relation.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participatingSubject"></see></summary>
    let participatingSubject =
        Namespaced_IRI.parse _namespace_name "participatingSubject" |> NamespacedName

    /// <summary>
    /// The end of a time interval.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participationEndTime"></see></summary>
    let participationEndTime =
        Namespaced_IRI.parse _namespace_name "participationEndTime" |> NamespacedName

    /// <summary>
    /// The collaboration or process that this participation relates to.
    /// <see href="http://w3id.org/CEON/ontology/actorODP/participationIn"></see></summary>
    let participationIn =
        Namespaced_IRI.parse _namespace_name "participationIn" |> NamespacedName
