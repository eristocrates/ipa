namespace http.open_services.net.ns.config.hash

open DoxAletheia

module config =
    let _namespace_name = "http://open-services.net/ns/config#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An activity is a read-only resource representing a long-running operation, such as recursive baseline or stream creation.
    /// <see href="http://open-services.net/ns/config#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// An immutable configuration with immutable selections of immutable resources, with immutable contributions that are themselves baselines.
    /// <see href="http://open-services.net/ns/config#Baseline"></see></summary>
    let Baseline = _prefix "Baseline"
    /// <summary>
    /// A configuration identifies a set of versions of resources in a component. Configurations commonly identify exactly one version of each resource in a component. Configurations can also assemble other configurations into a shared context across multiple components.
    /// <see href="http://open-services.net/ns/config#Configuration"></see></summary>
    let Configuration = _prefix "Configuration"
    /// <summary>
    /// A change set configuration represents a set of changes (including additions and removals) to some other configuration.
    /// <see href="http://open-services.net/ns/config#ChangeSet"></see></summary>
    let ChangeSet = _prefix "ChangeSet"
    /// <summary>
    /// A resource representing the delivery of a single change set to a single target stream.
    /// <see href="http://open-services.net/ns/config#ChangeSetDelivery"></see></summary>
    let ChangeSetDelivery = _prefix "ChangeSetDelivery"
    /// <summary>
    /// A resource listing the version resources selected by a change set configuration.
    /// <see href="http://open-services.net/ns/config#ChangeSetSelections"></see></summary>
    let ChangeSetSelections = _prefix "ChangeSetSelections"
    /// <summary>
    /// A resource listing the version resources selected by a configuration.
    /// <see href="http://open-services.net/ns/config#Selections"></see></summary>
    let Selections = _prefix "Selections"
    /// <summary>
    /// A unit of organization consisting of a set of versioned resources. Components are the units of configurability, and form reusable assets or building blocks.
    /// <see href="http://open-services.net/ns/config#Component"></see></summary>
    let Component = _prefix "Component"
    /// <summary>
    /// Information about settings and preferences for a Configuration Management service.
    /// <see href="http://open-services.net/ns/config#ConfigurationSettings"></see></summary>
    let ConfigurationSettings = _prefix "ConfigurationSettings"
    /// <summary>
    /// A contribution represents the contribution of one configuration to another.
    /// <see href="http://open-services.net/ns/config#Contribution"></see></summary>
    let Contribution = _prefix "Contribution"
    /// <summary>
    /// A configuration intended for use by a single agent, rather than shared.
    /// <see href="http://open-services.net/ns/config#PersonalConfiguration"></see></summary>
    let PersonalConfiguration = _prefix "PersonalConfiguration"
    /// <summary>
    /// For a change set, the selections to be removed from an overridden configuration.
    /// <see href="http://open-services.net/ns/config#Removals"></see></summary>
    let Removals = _prefix "Removals"
    /// <summary>
    /// For a change set, an indicator that all selections in the overriden configuration are to be ignored; all selections are defined by the change set.
    /// <see href="http://open-services.net/ns/config#RemoveAll"></see></summary>
    let RemoveAll = _prefix "RemoveAll"
    /// <summary>
    /// A mutable configuration. Contributions to this configuration can be streams or baselines.
    /// <see href="http://open-services.net/ns/config#Stream"></see></summary>
    let Stream = _prefix "Stream"
    /// <summary>
    /// An indicator that a set of selections are as-yet unbound concept resources as opposed to bound version resources.
    /// <see href="http://open-services.net/ns/config#UnboundSelections"></see></summary>
    let UnboundSelections = _prefix "UnboundSelections"
    /// <summary>
    /// This type is used as a marker for any version resource.
    /// <see href="http://open-services.net/ns/config#VersionResource"></see></summary>
    let VersionResource = _prefix "VersionResource"
    /// <summary>
    /// A type of configuration accepted as a contribution by the subject configuration.
    /// <see href="http://open-services.net/ns/config#acceptedBy"></see></summary>
    let acceptedBy = _prefix "acceptedBy"
    /// <summary>
    /// A type of configuration acceptable as a contribution to the subject configuration.
    /// <see href="http://open-services.net/ns/config#accepts"></see></summary>
    let accepts = _prefix "accepts"
    /// <summary>
    /// The stream from which a baseline was made.
    /// <see href="http://open-services.net/ns/config#baselineOfStream"></see></summary>
    let baselineOfStream = _prefix "baselineOfStream"
    /// <summary>
    /// A Linked Data Platform Container for baselines of a stream.
    /// <see href="http://open-services.net/ns/config#baselines"></see></summary>
    let baselines = _prefix "baselines"
    /// <summary>
    /// Identifies a resource as one for a specific branch or variant of the component.
    /// <see href="http://open-services.net/ns/config#branch"></see></summary>
    let branch = _prefix "branch"
    /// <summary>
    /// Date and time a resource was committed, or checked in.
    /// <see href="http://open-services.net/ns/config#committed"></see></summary>
    let committed = _prefix "committed"
    /// <summary>
    /// The entity that committed or checked in this resource.
    /// <see href="http://open-services.net/ns/config#committer"></see></summary>
    let committer = _prefix "committer"
    /// <summary>
    /// A reference to a Component resource.
    /// <see href="http://open-services.net/ns/config#component"></see></summary>
    let component_ = _prefix "component"
    /// <summary>
    /// A reference to a Configuration resource.
    /// <see href="http://open-services.net/ns/config#configuration"></see></summary>
    let configuration = _prefix "configuration"
    /// <summary>
    /// A reference to information about settings and preferences for a Configuration Management service.
    /// <see href="http://open-services.net/ns/config#configurationSettings"></see></summary>
    let configurationSettings = _prefix "configurationSettings"
    /// <summary>
    /// A Linked Data Platform Container for configurations of a component.
    /// <see href="http://open-services.net/ns/config#configurations"></see></summary>
    let configurations = _prefix "configurations"
    /// <summary>
    /// A reference to a Contribution resource.
    /// <see href="http://open-services.net/ns/config#contribution"></see></summary>
    let contribution = _prefix "contribution"
    /// <summary>
    /// The ordering value for a contribution.
    /// <see href="http://open-services.net/ns/config#contributionOrder"></see></summary>
    let contributionOrder = _prefix "contributionOrder"
    /// <summary>
    /// A resource from which this resource was derived; the use of prov:wasDerivedFrom is preferred.
    /// <see href="http://open-services.net/ns/config#derivedFrom"></see></summary>
    let derivedFrom = _prefix "derivedFrom"
    /// <summary>
    /// An oslc:usage value marking a global configuration service.
    /// <see href="http://open-services.net/ns/config#globalConfigurationService"></see></summary>
    let globalConfigurationService = _prefix "globalConfigurationService"
    /// <summary>
    /// A boolean property indicating whether or not a resource is modifiable; replaced by use of Baseline and Stream types.
    /// <see href="http://open-services.net/ns/config#mutable"></see></summary>
    let mutable_ = _prefix "mutable"
    /// <summary>
    /// A reference to a configuration modified by a change set configuration.
    /// <see href="http://open-services.net/ns/config#overrides"></see></summary>
    let overrides = _prefix "overrides"
    /// <summary>
    /// For a stream or a baseline, a link to the most recent baseline of the same stream.
    /// <see href="http://open-services.net/ns/config#previousBaseline"></see></summary>
    let previousBaseline = _prefix "previousBaseline"
    /// <summary>
    /// Text describing the progress of an operation.
    /// <see href="http://open-services.net/ns/config#progressMessage"></see></summary>
    let progressMessage = _prefix "progressMessage"
    /// <summary>
    /// A reference to a resource representing a release.
    /// <see href="http://open-services.net/ns/config#release"></see></summary>
    let release = _prefix "release"
    /// <summary>
    /// A reference to a Selections resource.
    /// <see href="http://open-services.net/ns/config#selections"></see></summary>
    let selections = _prefix "selections"
    /// <summary>
    /// A reference to a selected version resource.
    /// <see href="http://open-services.net/ns/config#selects"></see></summary>
    let selects = _prefix "selects"
    /// <summary>
    /// The change set that was delivered. This cannot be modified after creation.
    /// <see href="http://open-services.net/ns/config#sourceConfiguration"></see></summary>
    let sourceConfiguration = _prefix "sourceConfiguration"
    /// <summary>
    /// The version resource in the source configuration that is in conflict.
    /// <see href="http://open-services.net/ns/config#sourceVersionResource"></see></summary>
    let sourceVersionResource = _prefix "sourceVersionResource"
    /// <summary>
    /// A Linked Data Platform Container for streams created from a baseline.
    /// <see href="http://open-services.net/ns/config#streams"></see></summary>
    let streams = _prefix "streams"
    /// <summary>
    /// The stream to which the change set was delivered. This cannot be modified after creation.
    /// <see href="http://open-services.net/ns/config#targetStream"></see></summary>
    let targetStream = _prefix "targetStream"
    /// <summary>
    /// The version resource in the target stream that is in conflict.
    /// <see href="http://open-services.net/ns/config#targetVersionResource"></see></summary>
    let targetVersionResource = _prefix "targetVersionResource"
    /// <summary>
    /// A human-readable version identifier.
    /// <see href="http://open-services.net/ns/config#versionId"></see></summary>
    let versionId = _prefix "versionId"
