#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oslc_config =
    let _prefixId = PrefixId.fromNamespaceLabel "http://open-services.net/ns/config#" "oslc_config"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Activity^^xsd:string</para>
    ///   <para>rdfs:comment : An activity is a read-only resource representing a long-running operation, such as recursive baseline or stream creation.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#Activity">oslc_config:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : Baseline^^xsd:string</para>
    ///   <para>rdfs:comment : An immutable configuration with immutable selections of immutable resources, with immutable contributions that are themselves baselines.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#Baseline">oslc_config:Baseline</a>
    /// </summary>
    let Baseline = _prefixId.prefix "Baseline"
    /// <summary>
    ///   <para>rdfs:label : ChangeSet^^xsd:string</para>
    ///   <para>rdfs:comment : A change set configuration represents a set of changes (including additions and removals) to some other configuration.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#ChangeSet">oslc_config:ChangeSet</a>
    /// </summary>
    let ChangeSet = _prefixId.prefix "ChangeSet"
    /// <summary>
    ///   <para>rdfs:label : ChangeSetDelivery^^xsd:string</para>
    ///   <para>rdfs:comment : A resource representing the delivery of a single change set to a single target stream.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#ChangeSetDelivery">oslc_config:ChangeSetDelivery</a>
    /// </summary>
    let ChangeSetDelivery = _prefixId.prefix "ChangeSetDelivery"
    /// <summary>
    ///   <para>rdfs:label : ChangeSetSelections^^xsd:string</para>
    ///   <para>rdfs:comment : A resource listing the version resources selected by a change set configuration.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#ChangeSetSelections">oslc_config:ChangeSetSelections</a>
    /// </summary>
    let ChangeSetSelections = _prefixId.prefix "ChangeSetSelections"
    /// <summary>
    ///   <para>rdfs:label : Component^^xsd:string</para>
    ///   <para>rdfs:comment : A unit of organization consisting of a set of versioned resources. Components are the units of configurability, and form reusable assets or building blocks.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#Component">oslc_config:Component</a>
    /// </summary>
    let Component = _prefixId.prefix "Component"
    /// <summary>
    ///   <para>rdfs:label : Configuration^^xsd:string</para>
    ///   <para>rdfs:comment : A configuration identifies a set of versions of resources in a component. Configurations commonly identify exactly one version of each resource in a component. Configurations can also assemble other configurations into a shared context across multiple components.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#Configuration">oslc_config:Configuration</a>
    /// </summary>
    let Configuration = _prefixId.prefix "Configuration"
    /// <summary>
    ///   <para>rdfs:label : ConfigurationSettings^^xsd:string</para>
    ///   <para>rdfs:comment : Information about settings and preferences for a Configuration Management service.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#ConfigurationSettings">oslc_config:ConfigurationSettings</a>
    /// </summary>
    let ConfigurationSettings = _prefixId.prefix "ConfigurationSettings"
    /// <summary>
    ///   <para>rdfs:label : Contribution^^xsd:string</para>
    ///   <para>rdfs:comment : A contribution represents the contribution of one configuration to another.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#Contribution">oslc_config:Contribution</a>
    /// </summary>
    let Contribution = _prefixId.prefix "Contribution"
    /// <summary>
    ///   <para>rdfs:label : PersonalConfiguration^^xsd:string</para>
    ///   <para>rdfs:comment : A configuration intended for use by a single agent, rather than shared.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#PersonalConfiguration">oslc_config:PersonalConfiguration</a>
    /// </summary>
    let PersonalConfiguration = _prefixId.prefix "PersonalConfiguration"
    /// <summary>
    ///   <para>rdfs:label : Removals^^xsd:string</para>
    ///   <para>rdfs:comment : For a change set, the selections to be removed from an overridden configuration.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#Removals">oslc_config:Removals</a>
    /// </summary>
    let Removals = _prefixId.prefix "Removals"
    /// <summary>
    ///   <para>rdfs:label : RemovalAll^^xsd:string</para>
    ///   <para>rdfs:comment : For a change set, an indicator that all selections in the overriden configuration are to be ignored; all selections are defined by the change set.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#RemoveAll">oslc_config:RemoveAll</a>
    /// </summary>
    let RemoveAll = _prefixId.prefix "RemoveAll"
    /// <summary>
    ///   <para>rdfs:label : Selections^^xsd:string</para>
    ///   <para>rdfs:comment : A resource listing the version resources selected by a configuration.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#Selections">oslc_config:Selections</a>
    /// </summary>
    let Selections = _prefixId.prefix "Selections"
    /// <summary>
    ///   <para>rdfs:label : Stream^^xsd:string</para>
    ///   <para>rdfs:comment : A mutable configuration. Contributions to this configuration can be streams or baselines.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#Stream">oslc_config:Stream</a>
    /// </summary>
    let Stream = _prefixId.prefix "Stream"
    /// <summary>
    ///   <para>rdfs:label : UnboundSelections^^xsd:string</para>
    ///   <para>rdfs:comment : An indicator that a set of selections are as-yet unbound concept resources as opposed to bound version resources.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#UnboundSelections">oslc_config:UnboundSelections</a>
    /// </summary>
    let UnboundSelections = _prefixId.prefix "UnboundSelections"
    /// <summary>
    ///   <para>rdfs:label : VersionResource^^xsd:string</para>
    ///   <para>rdfs:comment : This type is used as a marker for any version resource.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#VersionResource">oslc_config:VersionResource</a>
    /// </summary>
    let VersionResource = _prefixId.prefix "VersionResource"
    /// <summary>
    ///   <para>rdfs:label : acceptedBy^^xsd:string</para>
    ///   <para>rdfs:comment : A type of configuration accepted as a contribution by the subject configuration.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#acceptedBy">oslc_config:acceptedBy</a>
    /// </summary>
    let acceptedBy = _prefixId.prefix "acceptedBy"
    /// <summary>
    ///   <para>rdfs:label : accepts^^xsd:string</para>
    ///   <para>rdfs:comment : A type of configuration acceptable as a contribution to the subject configuration.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#accepts">oslc_config:accepts</a>
    /// </summary>
    let accepts = _prefixId.prefix "accepts"
    /// <summary>
    ///   <para>rdfs:label : baselineOfStream^^xsd:string</para>
    ///   <para>rdfs:comment : The stream from which a baseline was made.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#baselineOfStream">oslc_config:baselineOfStream</a>
    /// </summary>
    let baselineOfStream = _prefixId.prefix "baselineOfStream"
    /// <summary>
    ///   <para>rdfs:label : baselines^^xsd:string</para>
    ///   <para>rdfs:comment : A Linked Data Platform Container for baselines of a stream.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#baselines">oslc_config:baselines</a>
    /// </summary>
    let baselines = _prefixId.prefix "baselines"
    /// <summary>
    ///   <para>rdfs:label : branch^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies a resource as one for a specific branch or variant of the component.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#branch">oslc_config:branch</a>
    /// </summary>
    let branch = _prefixId.prefix "branch"
    /// <summary>
    ///   <para>rdfs:label : committed^^xsd:string</para>
    ///   <para>rdfs:comment : Date and time a resource was committed, or checked in.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#committed">oslc_config:committed</a>
    /// </summary>
    let committed = _prefixId.prefix "committed"
    /// <summary>
    ///   <para>rdfs:label : committer^^xsd:string</para>
    ///   <para>rdfs:comment : The entity that committed or checked in this resource.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#committer">oslc_config:committer</a>
    /// </summary>
    let committer = _prefixId.prefix "committer"
    /// <summary>
    ///   <para>rdfs:label : component^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to a Component resource.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#component">oslc_config:component</a>
    /// </summary>
    let component_ = _prefixId.prefix "component"
    /// <summary>
    ///   <para>rdfs:label : configuration^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to a Configuration resource.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#configuration">oslc_config:configuration</a>
    /// </summary>
    let configuration = _prefixId.prefix "configuration"
    /// <summary>
    ///   <para>rdfs:label : configurationSettings^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to information about settings and preferences for a Configuration Management service.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#configurationSettings">oslc_config:configurationSettings</a>
    /// </summary>
    let configurationSettings = _prefixId.prefix "configurationSettings"
    /// <summary>
    ///   <para>rdfs:label : configurations^^xsd:string</para>
    ///   <para>rdfs:comment : A Linked Data Platform Container for configurations of a component.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#configurations">oslc_config:configurations</a>
    /// </summary>
    let configurations = _prefixId.prefix "configurations"
    /// <summary>
    ///   <para>rdfs:label : contribution^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to a Contribution resource.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#contribution">oslc_config:contribution</a>
    /// </summary>
    let contribution = _prefixId.prefix "contribution"
    /// <summary>
    ///   <para>rdfs:label : contributionOrder^^xsd:string</para>
    ///   <para>rdfs:comment : The ordering value for a contribution.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#contributionOrder">oslc_config:contributionOrder</a>
    /// </summary>
    let contributionOrder = _prefixId.prefix "contributionOrder"
    /// <summary>
    ///   <para>rdfs:label : derivedFrom^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:comment : A resource from which this resource was derived; the use of prov:wasDerivedFrom is preferred.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#derivedFrom">oslc_config:derivedFrom</a>
    /// </summary>
    let derivedFrom = _prefixId.prefix "derivedFrom"
    let globalConfigurationService = _prefixId.prefix "globalConfigurationService"
    /// <summary>
    ///   <para>rdfs:label : mutable^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:comment : A boolean property indicating whether or not a resource is modifiable; replaced by use of Baseline and Stream types.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#mutable">oslc_config:mutable</a>
    /// </summary>
    let mutable_ = _prefixId.prefix "mutable"
    /// <summary>
    ///   <para>rdfs:label : overrides^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to a configuration modified by a change set configuration.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#overrides">oslc_config:overrides</a>
    /// </summary>
    let overrides = _prefixId.prefix "overrides"
    /// <summary>
    ///   <para>rdfs:label : previousBaseline^^xsd:string</para>
    ///   <para>rdfs:comment : For a stream or a baseline, a link to the most recent baseline of the same stream.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#previousBaseline">oslc_config:previousBaseline</a>
    /// </summary>
    let previousBaseline = _prefixId.prefix "previousBaseline"
    /// <summary>
    ///   <para>rdfs:label : progressMessage^^xsd:string</para>
    ///   <para>rdfs:comment : Text describing the progress of an operation.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#progressMessage">oslc_config:progressMessage</a>
    /// </summary>
    let progressMessage = _prefixId.prefix "progressMessage"
    /// <summary>
    ///   <para>rdfs:label : release^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to a resource representing a release.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#release">oslc_config:release</a>
    /// </summary>
    let release = _prefixId.prefix "release"
    /// <summary>
    ///   <para>rdfs:label : selections^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to a Selections resource.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#selections">oslc_config:selections</a>
    /// </summary>
    let selections = _prefixId.prefix "selections"
    /// <summary>
    ///   <para>rdfs:label : selects^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to a selected version resource.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#selects">oslc_config:selects</a>
    /// </summary>
    let selects = _prefixId.prefix "selects"
    /// <summary>
    ///   <para>rdfs:label : sourceConfiguration^^xsd:string</para>
    ///   <para>rdfs:comment : The change set that was delivered. This cannot be modified after creation.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#sourceConfiguration">oslc_config:sourceConfiguration</a>
    /// </summary>
    let sourceConfiguration = _prefixId.prefix "sourceConfiguration"
    /// <summary>
    ///   <para>rdfs:label : sourceVersionResource^^xsd:string</para>
    ///   <para>rdfs:comment : The version resource in the source configuration that is in conflict.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#sourceVersionResource">oslc_config:sourceVersionResource</a>
    /// </summary>
    let sourceVersionResource = _prefixId.prefix "sourceVersionResource"
    /// <summary>
    ///   <para>rdfs:label : streams^^xsd:string</para>
    ///   <para>rdfs:comment : A Linked Data Platform Container for streams created from a baseline.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#streams">oslc_config:streams</a>
    /// </summary>
    let streams = _prefixId.prefix "streams"
    /// <summary>
    ///   <para>rdfs:label : targetStream^^xsd:string</para>
    ///   <para>rdfs:comment : The stream to which the change set was delivered. This cannot be modified after creation.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#targetStream">oslc_config:targetStream</a>
    /// </summary>
    let targetStream = _prefixId.prefix "targetStream"
    /// <summary>
    ///   <para>rdfs:label : targetVersionResource^^xsd:string</para>
    ///   <para>rdfs:comment : The version resource in the target stream that is in conflict.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#targetVersionResource">oslc_config:targetVersionResource</a>
    /// </summary>
    let targetVersionResource = _prefixId.prefix "targetVersionResource"
    /// <summary>
    ///   <para>rdfs:label : versionId^^xsd:string</para>
    ///   <para>rdfs:comment : A human-readable version identifier.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/config#versionId">oslc_config:versionId</a>
    /// </summary>
    let versionId = _prefixId.prefix "versionId"
