namespace https.w3id.org.sulo.slash

open DoxAletheia.Rdf_Vocabulary

module sulo =
    let _namespace_name = "https://w3id.org/sulo/"
    /// <summary>
    /// A capability is a feature that describes what an entity is able to do, under some set of circumstances.
    /// <see href="https://w3id.org/sulo/Capability"></see></summary>
    let Capability = Namespaced_IRI.parse _namespace_name "Capability" |> NamespacedName

    /// <summary>
    /// an information object is a feature that represents, is about, or encodes some information.
    /// <see href="https://w3id.org/sulo/InformationObject"></see></summary>
    let InformationObject =
        Namespaced_IRI.parse _namespace_name "InformationObject" |> NamespacedName

    /// <summary>
    /// A quality is a feature that is intrinsically associated with its bearer (or its parts).
    /// the color of an apple, the smoothness of skin, the brightness of a star, the speed of an event
    /// <see href="https://w3id.org/sulo/Quality"></see></summary>
    let Quality = Namespaced_IRI.parse _namespace_name "Quality" |> NamespacedName
    /// <summary>
    /// A role is a feature that describes a context-dependent behaviour.
    /// <see href="https://w3id.org/sulo/Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// A feature is any characteristic that stems from the intrisinc structure and/or context
    /// <see href="https://w3id.org/sulo/Feature"></see></summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName
    /// <summary>
    /// Duration is a temporal quantity that represents the extent or (non-negative) amount of time that elapses between two temporal points, typically the start and end of a time interval.
    /// <see href="https://w3id.org/sulo/Duration"></see></summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName
    /// <summary>
    /// has value is the (only) data type attribute to store the values of information objects.
    /// <see href="https://w3id.org/sulo/hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName
    /// <summary>
    /// time is a quantity pertaining to the duration of some interval of time or a particular instant of time (against some frame of reference).
    /// <see href="https://w3id.org/sulo/Time"></see></summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    /// an end time is a time instant at the end of a process/time interval.
    /// <see href="https://w3id.org/sulo/EndTime"></see></summary>
    let EndTime = Namespaced_IRI.parse _namespace_name "EndTime" |> NamespacedName

    /// <summary>
    /// time instant is a quantity of time a particular moment in time.
    /// <see href="https://w3id.org/sulo/TimeInstant"></see></summary>
    let TimeInstant =
        Namespaced_IRI.parse _namespace_name "TimeInstant" |> NamespacedName

    /// <summary>
    /// An object is an entity that maintains its identity through time, and does not have processes as its parts.
    /// <see href="https://w3id.org/sulo/Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    /// a process is a entity that unfolds in time, has temporal parts, and has objects that participate in the process.
    /// <see href="https://w3id.org/sulo/Process"></see></summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName

    /// <summary>
    /// is feature of is a relation between an internal, contextual, or externally attributed characteristic and some Thing.
    /// <see href="https://w3id.org/sulo/isFeatureOf"></see></summary>
    let isFeatureOf =
        Namespaced_IRI.parse _namespace_name "isFeatureOf" |> NamespacedName

    /// <summary>
    /// has part is a transitive, reflexive and antisymmetric relation between a whole and itself or a whole and its part.
    /// <see href="https://w3id.org/sulo/hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    /// A spatial object is an object that occupies space
    /// <see href="https://w3id.org/sulo/SpatialObject"></see></summary>
    let SpatialObject =
        Namespaced_IRI.parse _namespace_name "SpatialObject" |> NamespacedName

    /// <summary>
    /// A quantity is an informational object that contains the magnitude (and unit) of an attribute.
    /// <see href="https://w3id.org/sulo/Quantity"></see></summary>
    let Quantity = Namespaced_IRI.parse _namespace_name "Quantity" |> NamespacedName
    /// <summary>
    /// a unit is a standardized quantity that is used as a reference for a particular quantity.
    /// <see href="https://w3id.org/sulo/Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName
    /// <summary>
    /// A set is an information object for which there may be zero or more items.
    /// <see href="https://w3id.org/sulo/Set"></see></summary>
    let Set = Namespaced_IRI.parse _namespace_name "Set" |> NamespacedName
    /// <summary>
    /// has item is a relation between a collection and an item contained therein.
    /// <see href="https://w3id.org/sulo/hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// a start time is a time instant at the beginning of a process/time interval.
    /// <see href="https://w3id.org/sulo/StartTime"></see></summary>
    let StartTime = Namespaced_IRI.parse _namespace_name "StartTime" |> NamespacedName

    /// <summary>
    /// A time interval is a quantity for a continuous and bounded extent of time, characterized by a start time and an end time.
    /// <see href="https://w3id.org/sulo/TimeInterval"></see></summary>
    let TimeInterval =
        Namespaced_IRI.parse _namespace_name "TimeInterval" |> NamespacedName

    /// <summary>
    /// has direct part is a non-transitive parthood relation that can be used to specify cardinality constraints between a whole and its parts.
    /// <see href="https://w3id.org/sulo/hasDirectPart"></see></summary>
    let hasDirectPart =
        Namespaced_IRI.parse _namespace_name "hasDirectPart" |> NamespacedName

    /// <summary>
    /// a relation between any thing and the time in which it occurs at.
    /// <see href="https://w3id.org/sulo/atTime"></see></summary>
    let atTime = Namespaced_IRI.parse _namespace_name "atTime" |> NamespacedName
    /// <summary>
    /// a relation between a time and an object that occurs within it.
    /// <see href="https://w3id.org/sulo/isTimeOf"></see></summary>
    let isTimeOf = Namespaced_IRI.parse _namespace_name "isTimeOf" |> NamespacedName

    /// <summary>
    /// is direct part is a non-transitive parthood relation that can be used to specify cardinality constraints between a part and its whole.
    /// <see href="https://w3id.org/sulo/isDirectPartOf"></see></summary>
    let isDirectPartOf =
        Namespaced_IRI.parse _namespace_name "isDirectPartOf" |> NamespacedName

    /// <summary>
    /// has feature is a relation between a thing and an internal, contextual, or externally attributed characteristic.
    /// <see href="https://w3id.org/sulo/hasFeature"></see></summary>
    let hasFeature = Namespaced_IRI.parse _namespace_name "hasFeature" |> NamespacedName
    /// <summary>
    /// has item is a relation between an item and the collection in which it contained.
    /// <see href="https://w3id.org/sulo/isItemIn"></see></summary>
    let isItemIn = Namespaced_IRI.parse _namespace_name "isItemIn" |> NamespacedName

    /// <summary>
    /// A is location of B iff the spatialtemporal region occupied by A is the spatialtemporal region occupied by B.
    /// <see href="https://w3id.org/sulo/isLocationOf"></see></summary>
    let isLocationOf =
        Namespaced_IRI.parse _namespace_name "isLocationOf" |> NamespacedName

    /// <summary>
    /// is part of is a transitive, reflexive and antisymmetric relation between a part and itself or a part and a whole.
    /// <see href="https://w3id.org/sulo/isPartOf"></see></summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName

    /// <summary>
    /// has participant is a relation that describes the participation of a (non-process) thing in a process.
    /// <see href="https://w3id.org/sulo/hasParticipant"></see></summary>
    let hasParticipant =
        Namespaced_IRI.parse _namespace_name "hasParticipant" |> NamespacedName

    /// <summary>
    /// is participant in is a relation to relate an object and the process in which it participates.
    /// <see href="https://w3id.org/sulo/isParticipantIn"></see></summary>
    let isParticipantIn =
        Namespaced_IRI.parse _namespace_name "isParticipantIn" |> NamespacedName

    /// <summary>
    /// A is located in B iff the spatialtemporal region occupied by B is the spatialtemporal region occupied by A.
    /// <see href="https://w3id.org/sulo/isLocatedIn"></see></summary>
    let isLocatedIn =
        Namespaced_IRI.parse _namespace_name "isLocatedIn" |> NamespacedName

    /// <summary>
    /// A relation in which one process occurs after to another process.
    /// <see href="https://w3id.org/sulo/isPrecededBy"></see></summary>
    let isPrecededBy =
        Namespaced_IRI.parse _namespace_name "isPrecededBy" |> NamespacedName

    /// <summary>
    /// A relation in which one process occurs prior to another process.
    /// <see href="https://w3id.org/sulo/precedes"></see></summary>
    let precedes = Namespaced_IRI.parse _namespace_name "precedes" |> NamespacedName

    /// <summary>
    /// is referred in is relation between an object that is the subject of an information object.
    /// <see href="https://w3id.org/sulo/isReferredIn"></see></summary>
    let isReferredIn =
        Namespaced_IRI.parse _namespace_name "isReferredIn" |> NamespacedName

    /// <summary>
    /// refers to is a binary relation between an information object and any other object that it mentions, describes, represents, encodes, or otherwise provides information about.
    /// <see href="https://w3id.org/sulo/refersTo"></see></summary>
    let refersTo = Namespaced_IRI.parse _namespace_name "refersTo" |> NamespacedName
    /// <summary>
    /// The Simplified Upper Level Ontology (SULO) is ontology with a minimal set of classes and relations to guide the development of a personal health knowledge graph.
    /// <see href="https://w3id.org/sulo/sulo.ttl"></see></summary>
    let ``sulo.ttl`` = Namespaced_IRI.parse _namespace_name "sulo.ttl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sulo/sulo-0.2.0.ttl"></see>
    /// </summary>
    let ``sulo-0.2.0.ttl`` =
        Namespaced_IRI.parse _namespace_name "sulo-0.2.0.ttl" |> NamespacedName
