namespace http.open_services.net.ns.config.hash

open DoxAletheia.Rdf_Vocabulary

module config =
    let _namespace_name = "http://open-services.net/ns/config#"
    /// <summary>
    /// An activity is a read-only resource representing a long-running operation, such as recursive baseline or stream creation.
    /// <see href="http://open-services.net/ns/config#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    /// An immutable configuration with immutable selections of immutable resources, with immutable contributions that are themselves baselines.
    /// <see href="http://open-services.net/ns/config#Baseline"></see></summary>
    let Baseline = Namespaced_IRI.parse _namespace_name "Baseline" |> NamespacedName

    /// <summary>
    /// A configuration identifies a set of versions of resources in a component. Configurations commonly identify exactly one version of each resource in a component. Configurations can also assemble other configurations into a shared context across multiple components.
    /// <see href="http://open-services.net/ns/config#Configuration"></see></summary>
    let Configuration =
        Namespaced_IRI.parse _namespace_name "Configuration" |> NamespacedName

    /// <summary>
    /// A change set configuration represents a set of changes (including additions and removals) to some other configuration.
    /// <see href="http://open-services.net/ns/config#ChangeSet"></see></summary>
    let ChangeSet = Namespaced_IRI.parse _namespace_name "ChangeSet" |> NamespacedName

    /// <summary>
    /// A resource representing the delivery of a single change set to a single target stream.
    /// <see href="http://open-services.net/ns/config#ChangeSetDelivery"></see></summary>
    let ChangeSetDelivery =
        Namespaced_IRI.parse _namespace_name "ChangeSetDelivery" |> NamespacedName

    /// <summary>
    /// A resource listing the version resources selected by a change set configuration.
    /// <see href="http://open-services.net/ns/config#ChangeSetSelections"></see></summary>
    let ChangeSetSelections =
        Namespaced_IRI.parse _namespace_name "ChangeSetSelections" |> NamespacedName

    /// <summary>
    /// A resource listing the version resources selected by a configuration.
    /// <see href="http://open-services.net/ns/config#Selections"></see></summary>
    let Selections = Namespaced_IRI.parse _namespace_name "Selections" |> NamespacedName
    /// <summary>
    /// A unit of organization consisting of a set of versioned resources. Components are the units of configurability, and form reusable assets or building blocks.
    /// <see href="http://open-services.net/ns/config#Component"></see></summary>
    let Component = Namespaced_IRI.parse _namespace_name "Component" |> NamespacedName

    /// <summary>
    /// Information about settings and preferences for a Configuration Management service.
    /// <see href="http://open-services.net/ns/config#ConfigurationSettings"></see></summary>
    let ConfigurationSettings =
        Namespaced_IRI.parse _namespace_name "ConfigurationSettings" |> NamespacedName

    /// <summary>
    /// A contribution represents the contribution of one configuration to another.
    /// <see href="http://open-services.net/ns/config#Contribution"></see></summary>
    let Contribution =
        Namespaced_IRI.parse _namespace_name "Contribution" |> NamespacedName

    /// <summary>
    /// A configuration intended for use by a single agent, rather than shared.
    /// <see href="http://open-services.net/ns/config#PersonalConfiguration"></see></summary>
    let PersonalConfiguration =
        Namespaced_IRI.parse _namespace_name "PersonalConfiguration" |> NamespacedName

    /// <summary>
    /// For a change set, the selections to be removed from an overridden configuration.
    /// <see href="http://open-services.net/ns/config#Removals"></see></summary>
    let Removals = Namespaced_IRI.parse _namespace_name "Removals" |> NamespacedName
    /// <summary>
    /// For a change set, an indicator that all selections in the overriden configuration are to be ignored; all selections are defined by the change set.
    /// <see href="http://open-services.net/ns/config#RemoveAll"></see></summary>
    let RemoveAll = Namespaced_IRI.parse _namespace_name "RemoveAll" |> NamespacedName
    /// <summary>
    /// A mutable configuration. Contributions to this configuration can be streams or baselines.
    /// <see href="http://open-services.net/ns/config#Stream"></see></summary>
    let Stream = Namespaced_IRI.parse _namespace_name "Stream" |> NamespacedName

    /// <summary>
    /// An indicator that a set of selections are as-yet unbound concept resources as opposed to bound version resources.
    /// <see href="http://open-services.net/ns/config#UnboundSelections"></see></summary>
    let UnboundSelections =
        Namespaced_IRI.parse _namespace_name "UnboundSelections" |> NamespacedName

    /// <summary>
    /// This type is used as a marker for any version resource.
    /// <see href="http://open-services.net/ns/config#VersionResource"></see></summary>
    let VersionResource =
        Namespaced_IRI.parse _namespace_name "VersionResource" |> NamespacedName

    /// <summary>
    /// A type of configuration accepted as a contribution by the subject configuration.
    /// <see href="http://open-services.net/ns/config#acceptedBy"></see></summary>
    let acceptedBy = Namespaced_IRI.parse _namespace_name "acceptedBy" |> NamespacedName
    /// <summary>
    /// A type of configuration acceptable as a contribution to the subject configuration.
    /// <see href="http://open-services.net/ns/config#accepts"></see></summary>
    let accepts = Namespaced_IRI.parse _namespace_name "accepts" |> NamespacedName

    /// <summary>
    /// The stream from which a baseline was made.
    /// <see href="http://open-services.net/ns/config#baselineOfStream"></see></summary>
    let baselineOfStream =
        Namespaced_IRI.parse _namespace_name "baselineOfStream" |> NamespacedName

    /// <summary>
    /// A Linked Data Platform Container for baselines of a stream.
    /// <see href="http://open-services.net/ns/config#baselines"></see></summary>
    let baselines = Namespaced_IRI.parse _namespace_name "baselines" |> NamespacedName
    /// <summary>
    /// Identifies a resource as one for a specific branch or variant of the component.
    /// <see href="http://open-services.net/ns/config#branch"></see></summary>
    let branch = Namespaced_IRI.parse _namespace_name "branch" |> NamespacedName
    /// <summary>
    /// Date and time a resource was committed, or checked in.
    /// <see href="http://open-services.net/ns/config#committed"></see></summary>
    let committed = Namespaced_IRI.parse _namespace_name "committed" |> NamespacedName
    /// <summary>
    /// The entity that committed or checked in this resource.
    /// <see href="http://open-services.net/ns/config#committer"></see></summary>
    let committer = Namespaced_IRI.parse _namespace_name "committer" |> NamespacedName
    /// <summary>
    /// A reference to a Component resource.
    /// <see href="http://open-services.net/ns/config#component"></see></summary>
    let component_ = Namespaced_IRI.parse _namespace_name "component" |> NamespacedName

    /// <summary>
    /// A reference to a Configuration resource.
    /// <see href="http://open-services.net/ns/config#configuration"></see></summary>
    let configuration =
        Namespaced_IRI.parse _namespace_name "configuration" |> NamespacedName

    /// <summary>
    /// A reference to information about settings and preferences for a Configuration Management service.
    /// <see href="http://open-services.net/ns/config#configurationSettings"></see></summary>
    let configurationSettings =
        Namespaced_IRI.parse _namespace_name "configurationSettings" |> NamespacedName

    /// <summary>
    /// A Linked Data Platform Container for configurations of a component.
    /// <see href="http://open-services.net/ns/config#configurations"></see></summary>
    let configurations =
        Namespaced_IRI.parse _namespace_name "configurations" |> NamespacedName

    /// <summary>
    /// A reference to a Contribution resource.
    /// <see href="http://open-services.net/ns/config#contribution"></see></summary>
    let contribution =
        Namespaced_IRI.parse _namespace_name "contribution" |> NamespacedName

    /// <summary>
    /// The ordering value for a contribution.
    /// <see href="http://open-services.net/ns/config#contributionOrder"></see></summary>
    let contributionOrder =
        Namespaced_IRI.parse _namespace_name "contributionOrder" |> NamespacedName

    /// <summary>
    /// A resource from which this resource was derived; the use of prov:wasDerivedFrom is preferred.
    /// <see href="http://open-services.net/ns/config#derivedFrom"></see></summary>
    let derivedFrom =
        Namespaced_IRI.parse _namespace_name "derivedFrom" |> NamespacedName

    /// <summary>
    /// An oslc:usage value marking a global configuration service.
    /// <see href="http://open-services.net/ns/config#globalConfigurationService"></see></summary>
    let globalConfigurationService =
        Namespaced_IRI.parse _namespace_name "globalConfigurationService" |> NamespacedName

    /// <summary>
    /// A boolean property indicating whether or not a resource is modifiable; replaced by use of Baseline and Stream types.
    /// <see href="http://open-services.net/ns/config#mutable"></see></summary>
    let mutable_ = Namespaced_IRI.parse _namespace_name "mutable" |> NamespacedName
    /// <summary>
    /// A reference to a configuration modified by a change set configuration.
    /// <see href="http://open-services.net/ns/config#overrides"></see></summary>
    let overrides = Namespaced_IRI.parse _namespace_name "overrides" |> NamespacedName

    /// <summary>
    /// For a stream or a baseline, a link to the most recent baseline of the same stream.
    /// <see href="http://open-services.net/ns/config#previousBaseline"></see></summary>
    let previousBaseline =
        Namespaced_IRI.parse _namespace_name "previousBaseline" |> NamespacedName

    /// <summary>
    /// Text describing the progress of an operation.
    /// <see href="http://open-services.net/ns/config#progressMessage"></see></summary>
    let progressMessage =
        Namespaced_IRI.parse _namespace_name "progressMessage" |> NamespacedName

    /// <summary>
    /// A reference to a resource representing a release.
    /// <see href="http://open-services.net/ns/config#release"></see></summary>
    let release = Namespaced_IRI.parse _namespace_name "release" |> NamespacedName
    /// <summary>
    /// A reference to a Selections resource.
    /// <see href="http://open-services.net/ns/config#selections"></see></summary>
    let selections = Namespaced_IRI.parse _namespace_name "selections" |> NamespacedName
    /// <summary>
    /// A reference to a selected version resource.
    /// <see href="http://open-services.net/ns/config#selects"></see></summary>
    let selects = Namespaced_IRI.parse _namespace_name "selects" |> NamespacedName

    /// <summary>
    /// The change set that was delivered. This cannot be modified after creation.
    /// <see href="http://open-services.net/ns/config#sourceConfiguration"></see></summary>
    let sourceConfiguration =
        Namespaced_IRI.parse _namespace_name "sourceConfiguration" |> NamespacedName

    /// <summary>
    /// The version resource in the source configuration that is in conflict.
    /// <see href="http://open-services.net/ns/config#sourceVersionResource"></see></summary>
    let sourceVersionResource =
        Namespaced_IRI.parse _namespace_name "sourceVersionResource" |> NamespacedName

    /// <summary>
    /// A Linked Data Platform Container for streams created from a baseline.
    /// <see href="http://open-services.net/ns/config#streams"></see></summary>
    let streams = Namespaced_IRI.parse _namespace_name "streams" |> NamespacedName

    /// <summary>
    /// The stream to which the change set was delivered. This cannot be modified after creation.
    /// <see href="http://open-services.net/ns/config#targetStream"></see></summary>
    let targetStream =
        Namespaced_IRI.parse _namespace_name "targetStream" |> NamespacedName

    /// <summary>
    /// The version resource in the target stream that is in conflict.
    /// <see href="http://open-services.net/ns/config#targetVersionResource"></see></summary>
    let targetVersionResource =
        Namespaced_IRI.parse _namespace_name "targetVersionResource" |> NamespacedName

    /// <summary>
    /// A human-readable version identifier.
    /// <see href="http://open-services.net/ns/config#versionId"></see></summary>
    let versionId = Namespaced_IRI.parse _namespace_name "versionId" |> NamespacedName
