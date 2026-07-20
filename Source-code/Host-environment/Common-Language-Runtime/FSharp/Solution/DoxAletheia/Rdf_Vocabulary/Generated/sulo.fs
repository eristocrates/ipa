namespace https.w3id.org.sulo.slash

open DoxAletheia

module sulo =
    let _namespace_name = "https://w3id.org/sulo/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A capability is a feature that describes what an entity is able to do, under some set of circumstances.
    /// <see href="https://w3id.org/sulo/Capability"></see></summary>
    let Capability = _prefix "Capability"
    /// <summary>
    /// an information object is a feature that represents, is about, or encodes some information.
    /// <see href="https://w3id.org/sulo/InformationObject"></see></summary>
    let InformationObject = _prefix "InformationObject"
    /// <summary>
    /// A quality is a feature that is intrinsically associated with its bearer (or its parts).
    /// the color of an apple, the smoothness of skin, the brightness of a star, the speed of an event
    /// <see href="https://w3id.org/sulo/Quality"></see></summary>
    let Quality = _prefix "Quality"
    /// <summary>
    /// A role is a feature that describes a context-dependent behaviour.
    /// <see href="https://w3id.org/sulo/Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// A feature is any characteristic that stems from the intrisinc structure and/or context
    /// <see href="https://w3id.org/sulo/Feature"></see></summary>
    let Feature = _prefix "Feature"
    /// <summary>
    /// Duration is a temporal quantity that represents the extent or (non-negative) amount of time that elapses between two temporal points, typically the start and end of a time interval.
    /// <see href="https://w3id.org/sulo/Duration"></see></summary>
    let Duration = _prefix "Duration"
    /// <summary>
    /// has value is the (only) data type attribute to store the values of information objects.
    /// <see href="https://w3id.org/sulo/hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// time is a quantity pertaining to the duration of some interval of time or a particular instant of time (against some frame of reference).
    /// <see href="https://w3id.org/sulo/Time"></see></summary>
    let Time = _prefix "Time"
    /// <summary>
    /// an end time is a time instant at the end of a process/time interval.
    /// <see href="https://w3id.org/sulo/EndTime"></see></summary>
    let EndTime = _prefix "EndTime"
    /// <summary>
    /// time instant is a quantity of time a particular moment in time.
    /// <see href="https://w3id.org/sulo/TimeInstant"></see></summary>
    let TimeInstant = _prefix "TimeInstant"
    /// <summary>
    /// An object is an entity that maintains its identity through time, and does not have processes as its parts.
    /// <see href="https://w3id.org/sulo/Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// a process is a entity that unfolds in time, has temporal parts, and has objects that participate in the process.
    /// <see href="https://w3id.org/sulo/Process"></see></summary>
    let Process = _prefix "Process"
    /// <summary>
    /// is feature of is a relation between an internal, contextual, or externally attributed characteristic and some Thing.
    /// <see href="https://w3id.org/sulo/isFeatureOf"></see></summary>
    let isFeatureOf = _prefix "isFeatureOf"
    /// <summary>
    /// has part is a transitive, reflexive and antisymmetric relation between a whole and itself or a whole and its part.
    /// <see href="https://w3id.org/sulo/hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// A spatial object is an object that occupies space
    /// <see href="https://w3id.org/sulo/SpatialObject"></see></summary>
    let SpatialObject = _prefix "SpatialObject"
    /// <summary>
    /// A quantity is an informational object that contains the magnitude (and unit) of an attribute.
    /// <see href="https://w3id.org/sulo/Quantity"></see></summary>
    let Quantity = _prefix "Quantity"
    /// <summary>
    /// a unit is a standardized quantity that is used as a reference for a particular quantity.
    /// <see href="https://w3id.org/sulo/Unit"></see></summary>
    let Unit = _prefix "Unit"
    /// <summary>
    /// A set is an information object for which there may be zero or more items.
    /// <see href="https://w3id.org/sulo/Set"></see></summary>
    let Set = _prefix "Set"
    /// <summary>
    /// has item is a relation between a collection and an item contained therein.
    /// <see href="https://w3id.org/sulo/hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// a start time is a time instant at the beginning of a process/time interval.
    /// <see href="https://w3id.org/sulo/StartTime"></see></summary>
    let StartTime = _prefix "StartTime"
    /// <summary>
    /// A time interval is a quantity for a continuous and bounded extent of time, characterized by a start time and an end time.
    /// <see href="https://w3id.org/sulo/TimeInterval"></see></summary>
    let TimeInterval = _prefix "TimeInterval"
    /// <summary>
    /// has direct part is a non-transitive parthood relation that can be used to specify cardinality constraints between a whole and its parts.
    /// <see href="https://w3id.org/sulo/hasDirectPart"></see></summary>
    let hasDirectPart = _prefix "hasDirectPart"
    /// <summary>
    /// a relation between any thing and the time in which it occurs at.
    /// <see href="https://w3id.org/sulo/atTime"></see></summary>
    let atTime = _prefix "atTime"
    /// <summary>
    /// a relation between a time and an object that occurs within it.
    /// <see href="https://w3id.org/sulo/isTimeOf"></see></summary>
    let isTimeOf = _prefix "isTimeOf"
    /// <summary>
    /// is direct part is a non-transitive parthood relation that can be used to specify cardinality constraints between a part and its whole.
    /// <see href="https://w3id.org/sulo/isDirectPartOf"></see></summary>
    let isDirectPartOf = _prefix "isDirectPartOf"
    /// <summary>
    /// has feature is a relation between a thing and an internal, contextual, or externally attributed characteristic.
    /// <see href="https://w3id.org/sulo/hasFeature"></see></summary>
    let hasFeature = _prefix "hasFeature"
    /// <summary>
    /// has item is a relation between an item and the collection in which it contained.
    /// <see href="https://w3id.org/sulo/isItemIn"></see></summary>
    let isItemIn = _prefix "isItemIn"
    /// <summary>
    /// A is location of B iff the spatialtemporal region occupied by A is the spatialtemporal region occupied by B.
    /// <see href="https://w3id.org/sulo/isLocationOf"></see></summary>
    let isLocationOf = _prefix "isLocationOf"
    /// <summary>
    /// is part of is a transitive, reflexive and antisymmetric relation between a part and itself or a part and a whole.
    /// <see href="https://w3id.org/sulo/isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    /// has participant is a relation that describes the participation of a (non-process) thing in a process.
    /// <see href="https://w3id.org/sulo/hasParticipant"></see></summary>
    let hasParticipant = _prefix "hasParticipant"
    /// <summary>
    /// is participant in is a relation to relate an object and the process in which it participates.
    /// <see href="https://w3id.org/sulo/isParticipantIn"></see></summary>
    let isParticipantIn = _prefix "isParticipantIn"
    /// <summary>
    /// A is located in B iff the spatialtemporal region occupied by B is the spatialtemporal region occupied by A.
    /// <see href="https://w3id.org/sulo/isLocatedIn"></see></summary>
    let isLocatedIn = _prefix "isLocatedIn"
    /// <summary>
    /// A relation in which one process occurs after to another process.
    /// <see href="https://w3id.org/sulo/isPrecededBy"></see></summary>
    let isPrecededBy = _prefix "isPrecededBy"
    /// <summary>
    /// A relation in which one process occurs prior to another process.
    /// <see href="https://w3id.org/sulo/precedes"></see></summary>
    let precedes = _prefix "precedes"
    /// <summary>
    /// is referred in is relation between an object that is the subject of an information object.
    /// <see href="https://w3id.org/sulo/isReferredIn"></see></summary>
    let isReferredIn = _prefix "isReferredIn"
    /// <summary>
    /// refers to is a binary relation between an information object and any other object that it mentions, describes, represents, encodes, or otherwise provides information about.
    /// <see href="https://w3id.org/sulo/refersTo"></see></summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    /// The Simplified Upper Level Ontology (SULO) is ontology with a minimal set of classes and relations to guide the development of a personal health knowledge graph.
    /// <see href="https://w3id.org/sulo/sulo.ttl"></see></summary>
    let ``sulo.ttl`` = _prefix "sulo.ttl"
    /// <summary>
    ///   <see href="https://w3id.org/sulo/sulo-0.2.0.ttl"></see>
    /// </summary>
    let ``sulo-0.2.0.ttl`` = _prefix "sulo-0.2.0.ttl"
