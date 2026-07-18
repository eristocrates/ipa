namespace http.open_services.net.ns.core.trs.hash

open DoxAletheia.Rdf_Vocabulary

module trs =
    let _namespace_name = "http://open-services.net/ns/core/trs#"
    /// <summary>
    /// A Base identifies the initial set of resources in a Tracked Resource Set.
    /// <see href="http://open-services.net/ns/core/trs#Base"></see></summary>
    let Base = Namespaced_IRI.parse _namespace_name "Base" |> NamespacedName
    /// <summary>
    /// A Change Log describes what resources have been created, modified or deleted, and when.
    /// <see href="http://open-services.net/ns/core/trs#ChangeLog"></see></summary>
    let ChangeLog = Namespaced_IRI.parse _namespace_name "ChangeLog" |> NamespacedName
    /// <summary>
    /// Represents a resource creation or modification change event.
    /// <see href="http://open-services.net/ns/core/trs#Creation"></see></summary>
    let Creation = Namespaced_IRI.parse _namespace_name "Creation" |> NamespacedName
    /// <summary>
    /// Represents a resource deletion change event.
    /// <see href="http://open-services.net/ns/core/trs#Deletion"></see></summary>
    let Deletion = Namespaced_IRI.parse _namespace_name "Deletion" |> NamespacedName

    /// <summary>
    /// Represents a resource creation or modification change event.
    /// <see href="http://open-services.net/ns/core/trs#Modification"></see></summary>
    let Modification =
        Namespaced_IRI.parse _namespace_name "Modification" |> NamespacedName

    /// <summary>
    /// A Tracked Resource Set provides a representation of the current state of a Resource Set.
    /// <see href="http://open-services.net/ns/core/trs#TrackedResourceSet"></see></summary>
    let TrackedResourceSet =
        Namespaced_IRI.parse _namespace_name "TrackedResourceSet" |> NamespacedName

    /// <summary>
    /// An enumeration of the Resources in the Resource Set.
    /// <see href="http://open-services.net/ns/core/trs#base"></see></summary>
    let base_ = Namespaced_IRI.parse _namespace_name "base" |> NamespacedName
    /// <summary>
    /// The Change Event entries.
    /// <see href="http://open-services.net/ns/core/trs#change"></see></summary>
    let change = Namespaced_IRI.parse _namespace_name "change" |> NamespacedName
    /// <summary>
    /// A Change Log providing an order series of incremental adjustments to the Resource Set.
    /// <see href="http://open-services.net/ns/core/trs#changeLog"></see></summary>
    let changeLog = Namespaced_IRI.parse _namespace_name "changeLog" |> NamespacedName
    /// <summary>
    /// The Resource that has changed.
    /// <see href="http://open-services.net/ns/core/trs#changed"></see></summary>
    let changed = Namespaced_IRI.parse _namespace_name "changed" |> NamespacedName

    /// <summary>
    /// The most recent Change Log entry that is accounted for in this Base. When rdf:nil, the Base is an enumeration at the start of time.
    /// <see href="http://open-services.net/ns/core/trs#cutoffEvent"></see></summary>
    let cutoffEvent =
        Namespaced_IRI.parse _namespace_name "cutoffEvent" |> NamespacedName

    /// <summary>
    /// The sequence in time of the Change Event.
    /// <see href="http://open-services.net/ns/core/trs#order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName
    /// <summary>
    /// The continuation of the Change Log, containing the next group of chronologically earlier Change Events.
    /// <see href="http://open-services.net/ns/core/trs#previous"></see></summary>
    let previous = Namespaced_IRI.parse _namespace_name "previous" |> NamespacedName

    /// <summary>
    /// A Tracked Resource Set.
    /// <see href="http://open-services.net/ns/core/trs#trackedResourceSet"></see></summary>
    let trackedResourceSet =
        Namespaced_IRI.parse _namespace_name "trackedResourceSet" |> NamespacedName
