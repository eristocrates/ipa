namespace http.w3id.org.CEON.ontology.actorODP.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_actorODP =
    let _namespace_iri = Namespace_Iri ceon_actorODP |> NamespaceIRI

    /// <summary>
    ///   <para>ceon-actorODP:participatingActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Holds the value of the actor involved in this participation relation.</para>
    /// labels<para>participating actor</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/participatingActor">http://w3id.org/CEON/ontology/actorODP/participatingActor</seealso>
    let participatingActor =
        Prefixed_Name(ceon_actorODP, "participatingActor") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:participatingObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Participating object in a resource participation. This is part of a resource participation that can be a directional relation, and the participating object is the end point of the relation.</para>
    /// labels<para>participating object</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/participatingObject">http://w3id.org/CEON/ontology/actorODP/participatingObject</seealso>
    let participatingObject =
        Prefixed_Name(ceon_actorODP, "participatingObject") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:participationStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The start of a time interval.</para>
    /// labels<para>participation start time</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/participationStartTime">http://w3id.org/CEON/ontology/actorODP/participationStartTime</seealso>
    let participationStartTime =
        Prefixed_Name(ceon_actorODP, "participationStartTime") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:ResourceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation involving the role of a certain actor with respect to a certain resource, e.g. an organisation or individual (actor) owning (role) a specific product (resource) at a specific point or period in time.</para>
    /// labels<para>Resource Relation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/ResourceRelation">http://w3id.org/CEON/ontology/actorODP/ResourceRelation</seealso>
    let ResourceRelation =
        Prefixed_Name(ceon_actorODP, "ResourceRelation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:Capability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something that the actor is capable of doing, e.g. perfomring a certain role in a process, based on some properties, such as access to infrastructure, resources and know-how.</para>
    /// labels<para>Capability</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/Capability">http://w3id.org/CEON/ontology/actorODP/Capability</seealso>
    let Capability = Prefixed_Name(ceon_actorODP, "Capability") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actorODP:Participation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the participation of objects in some situation.</para>
    /// labels<para>Participation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/Participation">http://w3id.org/CEON/ontology/actorODP/Participation</seealso>
    let Participation = Prefixed_Name(ceon_actorODP, "Participation") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actorODP:Infrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An infrastructure refers to facilities, services, or systems for participations to function.</para>
    /// labels<para>Infrastructure</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/Infrastructure">http://w3id.org/CEON/ontology/actorODP/Infrastructure</seealso>
    let Infrastructure = Prefixed_Name(ceon_actorODP, "Infrastructure") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:ResourceParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The generic relation representing the particpation of a resource in some relation. For example, it can be specialized to represent a reified version of an object or data property.</para>
    /// labels<para>Resource Participation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/ResourceParticipation">http://w3id.org/CEON/ontology/actorODP/ResourceParticipation</seealso>
    let ResourceParticipation =
        Prefixed_Name(ceon_actorODP, "ResourceParticipation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:basedOnCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An actor participates in a collaboration based on that it has some capability that is useful for the collaboration.</para>
    /// labels<para>based on capability</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/basedOnCapability">http://w3id.org/CEON/ontology/actorODP/basedOnCapability</seealso>
    let basedOnCapability =
        Prefixed_Name(ceon_actorODP, "basedOnCapability") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent able to act in the context of a circular value network, e.g. an organisation, person.</para>
    /// labels<para>Actor</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/Actor">http://w3id.org/CEON/ontology/actorODP/Actor</seealso>
    let Actor = Prefixed_Name(ceon_actorODP, "Actor") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:CollaborationParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relation involving the role of a certain actor with respect to a value network or a process in such a network, e.g. an organisation (actor) acting as the recycler (role) in a glass recycling value netowrk (network) at a specific point or period in time. Or an organisation (actor) acting as the dismantler (role) in a dismantling step of a building deconstruction process (process step) at a specific point or period in time.</para>
    /// labels<para>Collaboration Participation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/CollaborationParticipation">http://w3id.org/CEON/ontology/actorODP/CollaborationParticipation</seealso>
    let CollaborationParticipation =
        Prefixed_Name(ceon_actorODP, "CollaborationParticipation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:participationTimePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The point in time when something took place or was valid.</para>
    /// labels<para>participation time point</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/participationTimePoint">http://w3id.org/CEON/ontology/actorODP/participationTimePoint</seealso>
    let participationTimePoint =
        Prefixed_Name(ceon_actorODP, "participationTimePoint") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role that an actor can take in a specific context. Applies both to roles in the context of resources, such as owner, manufacturer, reseller etc. of that resource, as well as roles in relation to a circular value network, such as recycler, dismantler, transporter etc., in relation to a material flow.</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/Role">http://w3id.org/CEON/ontology/actorODP/Role</seealso>
    let Role = Prefixed_Name(ceon_actorODP, "Role") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actorODP:0.4/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/0.4/">http://w3id.org/CEON/ontology/actorODP/0.4/</seealso>
    let ``_0.4/`` = Prefixed_Name(ceon_actorODP, "0.4/") |> PrefixedName
    /// <summary>
    ///   <para>ceon-actorODP:capabilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates to the actor holding the capability.</para>
    /// labels<para>capability of</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/capabilityOf">http://w3id.org/CEON/ontology/actorODP/capabilityOf</seealso>
    let capabilityOf = Prefixed_Name(ceon_actorODP, "capabilityOf") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:capabilityProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates some properties to the capability, such as the parameters of it, or the needed resources.</para>
    /// labels<para>capability property</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/capabilityProperty">http://w3id.org/CEON/ontology/actorODP/capabilityProperty</seealso>
    let capabilityProperty =
        Prefixed_Name(ceon_actorODP, "capabilityProperty") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:participatingSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Participating subject in a resource participation. This is part of a resource participation that can be a directional relation, and the participating subject is the starting point of the relation.</para>
    /// labels<para>participating subject</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/participatingSubject">http://w3id.org/CEON/ontology/actorODP/participatingSubject</seealso>
    let participatingSubject =
        Prefixed_Name(ceon_actorODP, "participatingSubject") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:participantRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Holds the value of the role of the participant in this participation relation.</para>
    /// labels<para>participant role</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/participantRole">http://w3id.org/CEON/ontology/actorODP/participantRole</seealso>
    let participantRole =
        Prefixed_Name(ceon_actorODP, "participantRole") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:participatingInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Holds the value of the infrastructure involved in this participation relation.</para>
    /// labels<para>participating infrastructure</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/participatingInfrastructure">http://w3id.org/CEON/ontology/actorODP/participatingInfrastructure</seealso>
    let participatingInfrastructure =
        Prefixed_Name(ceon_actorODP, "participatingInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:participatingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The resource that this participation relation relates to, i.e. for which the actor holds the specified role.</para>
    /// labels<para>participating resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/participatingResource">http://w3id.org/CEON/ontology/actorODP/participatingResource</seealso>
    let participatingResource =
        Prefixed_Name(ceon_actorODP, "participatingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:participationEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The end of a time interval.</para>
    /// labels<para>participation end time</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/participationEndTime">http://w3id.org/CEON/ontology/actorODP/participationEndTime</seealso>
    let participationEndTime =
        Prefixed_Name(ceon_actorODP, "participationEndTime") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:participationIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The collaboration or process that this participation relates to.</para>
    /// labels<para>participation in</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/participationIn">http://w3id.org/CEON/ontology/actorODP/participationIn</seealso>
    let participationIn =
        Prefixed_Name(ceon_actorODP, "participationIn") |> PrefixedName

    /// <summary>
    ///   <para>ceon-actorODP:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>A core ODP of the CEON ontology network, defining aspects of the actor concept.</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/actorODP/">http://w3id.org/CEON/ontology/actorODP/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_actorODP, "") |> PrefixedName
