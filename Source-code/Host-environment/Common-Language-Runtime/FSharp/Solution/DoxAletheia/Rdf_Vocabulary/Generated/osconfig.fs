namespace http.open_services.net.ns.config.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module osconfig =
    let _namespace_iri = Namespace_Iri osconfig |> NamespaceIRI
    /// <summary>
    ///   <para>osconfig:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An activity is a read-only resource representing a long-running operation, such as recursive baseline or stream creation.</para>
    /// labels<para>Activity</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#Activity">http://open-services.net/ns/config#Activity</seealso>
    let Activity = Prefixed_Name(osconfig, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:Configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A configuration identifies a set of versions of resources in a component. Configurations commonly identify exactly one version of each resource in a component. Configurations can also assemble other configurations into a shared context across multiple components.</para>
    /// labels<para>Configuration</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#Configuration">http://open-services.net/ns/config#Configuration</seealso>
    let Configuration = Prefixed_Name(osconfig, "Configuration") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:ChangeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A change set configuration represents a set of changes (including additions and removals) to some other configuration.</para>
    /// labels<para>ChangeSet</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#ChangeSet">http://open-services.net/ns/config#ChangeSet</seealso>
    let ChangeSet = Prefixed_Name(osconfig, "ChangeSet") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:Selections</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource listing the version resources selected by a configuration.</para>
    /// labels<para>Selections</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#Selections">http://open-services.net/ns/config#Selections</seealso>
    let Selections = Prefixed_Name(osconfig, "Selections") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A unit of organization consisting of a set of versioned resources. Components are the units of configurability, and form reusable assets or building blocks.</para>
    /// labels<para>Component</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#Component">http://open-services.net/ns/config#Component</seealso>
    let Component = Prefixed_Name(osconfig, "Component") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:Contribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A contribution represents the contribution of one configuration to another.</para>
    /// labels<para>Contribution</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#Contribution">http://open-services.net/ns/config#Contribution</seealso>
    let Contribution = Prefixed_Name(osconfig, "Contribution") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:Removals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>For a change set, the selections to be removed from an overridden configuration.</para>
    /// labels<para>Removals</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#Removals">http://open-services.net/ns/config#Removals</seealso>
    let Removals = Prefixed_Name(osconfig, "Removals") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:UnboundSelections</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An indicator that a set of selections are as-yet unbound concept resources as opposed to bound version resources.</para>
    /// labels<para>UnboundSelections</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#UnboundSelections">http://open-services.net/ns/config#UnboundSelections</seealso>
    let UnboundSelections = Prefixed_Name(osconfig, "UnboundSelections") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:VersionResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This type is used as a marker for any version resource.</para>
    /// labels<para>VersionResource</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#VersionResource">http://open-services.net/ns/config#VersionResource</seealso>
    let VersionResource = Prefixed_Name(osconfig, "VersionResource") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:accepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A type of configuration acceptable as a contribution to the subject configuration.</para>
    /// labels<para>accepts</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#accepts">http://open-services.net/ns/config#accepts</seealso>
    let accepts = Prefixed_Name(osconfig, "accepts") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:branch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifies a resource as one for a specific branch or variant of the component.</para>
    /// labels<para>branch</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#branch">http://open-services.net/ns/config#branch</seealso>
    let branch = Prefixed_Name(osconfig, "branch") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:committer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The entity that committed or checked in this resource.</para>
    /// labels<para>committer</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#committer">http://open-services.net/ns/config#committer</seealso>
    let committer = Prefixed_Name(osconfig, "committer") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:configurationSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A reference to information about settings and preferences for a Configuration Management service.</para>
    /// labels<para>configurationSettings</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#configurationSettings">http://open-services.net/ns/config#configurationSettings</seealso>
    let configurationSettings =
        Prefixed_Name(osconfig, "configurationSettings") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:configurations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Linked Data Platform Container for configurations of a component.</para>
    /// labels<para>configurations</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#configurations">http://open-services.net/ns/config#configurations</seealso>
    let configurations = Prefixed_Name(osconfig, "configurations") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:derivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource from which this resource was derived; the use of prov:wasDerivedFrom is preferred.</para>
    /// labels<para>derivedFrom</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#derivedFrom">http://open-services.net/ns/config#derivedFrom</seealso>
    let derivedFrom = Prefixed_Name(osconfig, "derivedFrom") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:globalConfigurationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>An oslc:usage value marking a global configuration service.</para>
    /// labels<para>globalConfigurationService</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#globalConfigurationService">http://open-services.net/ns/config#globalConfigurationService</seealso>
    let globalConfigurationService =
        Prefixed_Name(osconfig, "globalConfigurationService") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:overrides</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A reference to a configuration modified by a change set configuration.</para>
    /// labels<para>overrides</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#overrides">http://open-services.net/ns/config#overrides</seealso>
    let overrides = Prefixed_Name(osconfig, "overrides") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:previousBaseline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>For a stream or a baseline, a link to the most recent baseline of the same stream.</para>
    /// labels<para>previousBaseline</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#previousBaseline">http://open-services.net/ns/config#previousBaseline</seealso>
    let previousBaseline = Prefixed_Name(osconfig, "previousBaseline") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:progressMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Text describing the progress of an operation.</para>
    /// labels<para>progressMessage</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#progressMessage">http://open-services.net/ns/config#progressMessage</seealso>
    let progressMessage = Prefixed_Name(osconfig, "progressMessage") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:sourceConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The change set that was delivered. This cannot be modified after creation.</para>
    /// labels<para>sourceConfiguration</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#sourceConfiguration">http://open-services.net/ns/config#sourceConfiguration</seealso>
    let sourceConfiguration =
        Prefixed_Name(osconfig, "sourceConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:sourceVersionResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The version resource in the source configuration that is in conflict.</para>
    /// labels<para>sourceVersionResource</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#sourceVersionResource">http://open-services.net/ns/config#sourceVersionResource</seealso>
    let sourceVersionResource =
        Prefixed_Name(osconfig, "sourceVersionResource") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:versionId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A human-readable version identifier.</para>
    /// labels<para>versionId</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#versionId">http://open-services.net/ns/config#versionId</seealso>
    let versionId = Prefixed_Name(osconfig, "versionId") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:ChangeSetSelections</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource listing the version resources selected by a change set configuration.</para>
    /// labels<para>ChangeSetSelections</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#ChangeSetSelections">http://open-services.net/ns/config#ChangeSetSelections</seealso>
    let ChangeSetSelections =
        Prefixed_Name(osconfig, "ChangeSetSelections") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:Stream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A mutable configuration. Contributions to this configuration can be streams or baselines.</para>
    /// labels<para>Stream</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#Stream">http://open-services.net/ns/config#Stream</seealso>
    let Stream = Prefixed_Name(osconfig, "Stream") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:baselines</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Linked Data Platform Container for baselines of a stream.</para>
    /// labels<para>baselines</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#baselines">http://open-services.net/ns/config#baselines</seealso>
    let baselines = Prefixed_Name(osconfig, "baselines") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:committed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date and time a resource was committed, or checked in.</para>
    /// labels<para>committed</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#committed">http://open-services.net/ns/config#committed</seealso>
    let committed = Prefixed_Name(osconfig, "committed") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A reference to a Component resource.</para>
    /// labels<para>component</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#component">http://open-services.net/ns/config#component</seealso>
    let component_ = Prefixed_Name(osconfig, "component") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:mutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A boolean property indicating whether or not a resource is modifiable; replaced by use of Baseline and Stream types.</para>
    /// labels<para>mutable</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#mutable">http://open-services.net/ns/config#mutable</seealso>
    let mutable_ = Prefixed_Name(osconfig, "mutable") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:selections</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A reference to a Selections resource.</para>
    /// labels<para>selections</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#selections">http://open-services.net/ns/config#selections</seealso>
    let selections = Prefixed_Name(osconfig, "selections") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:streams</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Linked Data Platform Container for streams created from a baseline.</para>
    /// labels<para>streams</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#streams">http://open-services.net/ns/config#streams</seealso>
    let streams = Prefixed_Name(osconfig, "streams") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:targetStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The stream to which the change set was delivered. This cannot be modified after creation.</para>
    /// labels<para>targetStream</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#targetStream">http://open-services.net/ns/config#targetStream</seealso>
    let targetStream = Prefixed_Name(osconfig, "targetStream") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:ConfigurationSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Information about settings and preferences for a Configuration Management service.</para>
    /// labels<para>ConfigurationSettings</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#ConfigurationSettings">http://open-services.net/ns/config#ConfigurationSettings</seealso>
    let ConfigurationSettings =
        Prefixed_Name(osconfig, "ConfigurationSettings") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:RemoveAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>For a change set, an indicator that all selections in the overriden configuration are to be ignored; all selections are defined by the change set.</para>
    /// labels<para>RemovalAll</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#RemoveAll">http://open-services.net/ns/config#RemoveAll</seealso>
    let RemoveAll = Prefixed_Name(osconfig, "RemoveAll") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:selects</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A reference to a selected version resource.</para>
    /// labels<para>selects</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#selects">http://open-services.net/ns/config#selects</seealso>
    let selects = Prefixed_Name(osconfig, "selects") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:PersonalConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A configuration intended for use by a single agent, rather than shared.</para>
    /// labels<para>PersonalConfiguration</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#PersonalConfiguration">http://open-services.net/ns/config#PersonalConfiguration</seealso>
    let PersonalConfiguration =
        Prefixed_Name(osconfig, "PersonalConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:acceptedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A type of configuration accepted as a contribution by the subject configuration.</para>
    /// labels<para>acceptedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#acceptedBy">http://open-services.net/ns/config#acceptedBy</seealso>
    let acceptedBy = Prefixed_Name(osconfig, "acceptedBy") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:baselineOfStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The stream from which a baseline was made.</para>
    /// labels<para>baselineOfStream</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#baselineOfStream">http://open-services.net/ns/config#baselineOfStream</seealso>
    let baselineOfStream = Prefixed_Name(osconfig, "baselineOfStream") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A reference to a Configuration resource.</para>
    /// labels<para>configuration</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#configuration">http://open-services.net/ns/config#configuration</seealso>
    let configuration = Prefixed_Name(osconfig, "configuration") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:contribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A reference to a Contribution resource.</para>
    /// labels<para>contribution</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#contribution">http://open-services.net/ns/config#contribution</seealso>
    let contribution = Prefixed_Name(osconfig, "contribution") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:contributionOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ordering value for a contribution.</para>
    /// labels<para>contributionOrder</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#contributionOrder">http://open-services.net/ns/config#contributionOrder</seealso>
    let contributionOrder = Prefixed_Name(osconfig, "contributionOrder") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>OSLC Configuration Management vocabulary</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#">http://open-services.net/ns/config#</seealso>
    let _prefix_iri = Prefixed_Name(osconfig, "") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:Baseline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An immutable configuration with immutable selections of immutable resources, with immutable contributions that are themselves baselines.</para>
    /// labels<para>Baseline</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#Baseline">http://open-services.net/ns/config#Baseline</seealso>
    let Baseline = Prefixed_Name(osconfig, "Baseline") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:ChangeSetDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource representing the delivery of a single change set to a single target stream.</para>
    /// labels<para>ChangeSetDelivery</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#ChangeSetDelivery">http://open-services.net/ns/config#ChangeSetDelivery</seealso>
    let ChangeSetDelivery = Prefixed_Name(osconfig, "ChangeSetDelivery") |> PrefixedName
    /// <summary>
    ///   <para>osconfig:release</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A reference to a resource representing a release.</para>
    /// labels<para>release</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#release">http://open-services.net/ns/config#release</seealso>
    let release = Prefixed_Name(osconfig, "release") |> PrefixedName

    /// <summary>
    ///   <para>osconfig:targetVersionResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The version resource in the target stream that is in conflict.</para>
    /// labels<para>targetVersionResource</para></remarks>
    /// <seealso href="http://open-services.net/ns/config#targetVersionResource">http://open-services.net/ns/config#targetVersionResource</seealso>
    let targetVersionResource =
        Prefixed_Name(osconfig, "targetVersionResource") |> PrefixedName
