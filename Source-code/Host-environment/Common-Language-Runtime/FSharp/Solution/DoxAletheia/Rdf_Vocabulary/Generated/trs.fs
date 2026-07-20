namespace http.open_services.net.ns.core.trs.hash

open DoxAletheia

module trs =
    let _namespace_name = "http://open-services.net/ns/core/trs#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Base identifies the initial set of resources in a Tracked Resource Set.
    /// <see href="http://open-services.net/ns/core/trs#Base"></see></summary>
    let Base = _prefix "Base"
    /// <summary>
    /// A Change Log describes what resources have been created, modified or deleted, and when.
    /// <see href="http://open-services.net/ns/core/trs#ChangeLog"></see></summary>
    let ChangeLog = _prefix "ChangeLog"
    /// <summary>
    /// Represents a resource creation or modification change event.
    /// <see href="http://open-services.net/ns/core/trs#Creation"></see></summary>
    let Creation = _prefix "Creation"
    /// <summary>
    /// Represents a resource deletion change event.
    /// <see href="http://open-services.net/ns/core/trs#Deletion"></see></summary>
    let Deletion = _prefix "Deletion"
    /// <summary>
    /// Represents a resource creation or modification change event.
    /// <see href="http://open-services.net/ns/core/trs#Modification"></see></summary>
    let Modification = _prefix "Modification"
    /// <summary>
    /// A Tracked Resource Set provides a representation of the current state of a Resource Set.
    /// <see href="http://open-services.net/ns/core/trs#TrackedResourceSet"></see></summary>
    let TrackedResourceSet = _prefix "TrackedResourceSet"
    /// <summary>
    /// An enumeration of the Resources in the Resource Set.
    /// <see href="http://open-services.net/ns/core/trs#base"></see></summary>
    let base_ = _prefix "base"
    /// <summary>
    /// The Change Event entries.
    /// <see href="http://open-services.net/ns/core/trs#change"></see></summary>
    let change = _prefix "change"
    /// <summary>
    /// A Change Log providing an order series of incremental adjustments to the Resource Set.
    /// <see href="http://open-services.net/ns/core/trs#changeLog"></see></summary>
    let changeLog = _prefix "changeLog"
    /// <summary>
    /// The Resource that has changed.
    /// <see href="http://open-services.net/ns/core/trs#changed"></see></summary>
    let changed = _prefix "changed"
    /// <summary>
    /// The most recent Change Log entry that is accounted for in this Base. When rdf:nil, the Base is an enumeration at the start of time.
    /// <see href="http://open-services.net/ns/core/trs#cutoffEvent"></see></summary>
    let cutoffEvent = _prefix "cutoffEvent"
    /// <summary>
    /// The sequence in time of the Change Event.
    /// <see href="http://open-services.net/ns/core/trs#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// The continuation of the Change Log, containing the next group of chronologically earlier Change Events.
    /// <see href="http://open-services.net/ns/core/trs#previous"></see></summary>
    let previous = _prefix "previous"
    /// <summary>
    /// A Tracked Resource Set.
    /// <see href="http://open-services.net/ns/core/trs#trackedResourceSet"></see></summary>
    let trackedResourceSet = _prefix "trackedResourceSet"
