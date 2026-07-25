namespace https.w3id.org.aerOS.continuum.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module aoscon =
    let _namespace_iri = Namespace_Iri aoscon |> NamespaceIRI
    /// <summary>
    ///   <para>aoscon:NetworkPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Network Port</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#NetworkPort">https://w3id.org/aerOS/continuum#NetworkPort</seealso>
    let NetworkPort = Prefixed_Name(aoscon, "NetworkPort") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:ServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Individual, deployable units that together constitute a Service in the aerOS ecosystem, each with a specific role or function.</para>
    /// labels<para>Service Component</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ServiceComponent">https://w3id.org/aerOS/continuum#ServiceComponent</seealso>
    let ServiceComponent = Prefixed_Name(aoscon, "ServiceComponent") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:ServiceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Identifies the services such as a "catalogue".</para>
    /// labels<para>Service Type</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ServiceType">https://w3id.org/aerOS/continuum#ServiceType</seealso>
    let ServiceType = Prefixed_Name(aoscon, "ServiceType") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:InfrastructureElementStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the status of an IE. Possible types are READY, OVERLOAD, UNSECURE, UNTRUSTED.</para>
    /// labels<para>Infrastructure Element Status</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#InfrastructureElementStatus">https://w3id.org/aerOS/continuum#InfrastructureElementStatus</seealso>
    let InfrastructureElementStatus =
        Prefixed_Name(aoscon, "InfrastructureElementStatus") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:OverloadServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#OverloadServiceComponent">https://w3id.org/aerOS/continuum#OverloadServiceComponent</seealso>
    let OverloadServiceComponent =
        Prefixed_Name(aoscon, "OverloadServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:ReadyInfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ReadyInfrastructureElement">https://w3id.org/aerOS/continuum#ReadyInfrastructureElement</seealso>
    let ReadyInfrastructureElement =
        Prefixed_Name(aoscon, "ReadyInfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:RemovingServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#RemovingServiceComponent">https://w3id.org/aerOS/continuum#RemovingServiceComponent</seealso>
    let RemovingServiceComponent =
        Prefixed_Name(aoscon, "RemovingServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:StartingServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#StartingServiceComponent">https://w3id.org/aerOS/continuum#StartingServiceComponent</seealso>
    let StartingServiceComponent =
        Prefixed_Name(aoscon, "StartingServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:UnsecureInfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#UnsecureInfrastructureElement">https://w3id.org/aerOS/continuum#UnsecureInfrastructureElement</seealso>
    let UnsecureInfrastructureElement =
        Prefixed_Name(aoscon, "UnsecureInfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:Windows</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#OperatingSystem</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#Windows">https://w3id.org/aerOS/continuum#Windows</seealso>
    let Windows = Prefixed_Name(aoscon, "Windows") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Person with access to the capabilities of the continuum.</para>
    /// labels<para>User</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#User">https://w3id.org/aerOS/continuum#User</seealso>
    let User = Prefixed_Name(aoscon, "User") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:arm64Architecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#CpuArchitecture</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#arm64Architecture">https://w3id.org/aerOS/continuum#arm64Architecture</seealso>
    let arm64Architecture = Prefixed_Name(aoscon, "arm64Architecture") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:averagePowerConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>average power consumption</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#averagePowerConsumption">https://w3id.org/aerOS/continuum#averagePowerConsumption</seealso>
    let averagePowerConsumption =
        Prefixed_Name(aoscon, "averagePowerConsumption") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:LowLevelOrchestrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This element interprets the Decision Blueprint coming from the HLO and oversees the actual deployment of workloads in the selected IE(s). Being aware of the underlying container management frameworks, is able to convert the allocation order into proper deployment. Several LLOs may live in the same domain.</para>
    /// labels<para>Low Level Orchestrator</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#LowLevelOrchestrator">https://w3id.org/aerOS/continuum#LowLevelOrchestrator</seealso>
    let LowLevelOrchestrator =
        Prefixed_Name(aoscon, "LowLevelOrchestrator") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:currentRamUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>current ram usage</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#currentRamUsage">https://w3id.org/aerOS/continuum#currentRamUsage</seealso>
    let currentRamUsage = Prefixed_Name(aoscon, "currentRamUsage") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:domainStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>domain status</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#domainStatus">https://w3id.org/aerOS/continuum#domainStatus</seealso>
    let domainStatus = Prefixed_Name(aoscon, "domainStatus") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:infrastructureElementRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>infrastructure element requirements</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#infrastructureElementRequirements">https://w3id.org/aerOS/continuum#infrastructureElementRequirements</seealso>
    let infrastructureElementRequirements =
        Prefixed_Name(aoscon, "infrastructureElementRequirements") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>belongs to</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#belongsTo">https://w3id.org/aerOS/continuum#belongsTo</seealso>
    let belongsTo = Prefixed_Name(aoscon, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:cliArgs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>cli args</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#cliArgs">https://w3id.org/aerOS/continuum#cliArgs</seealso>
    let cliArgs = Prefixed_Name(aoscon, "cliArgs") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:cpuArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>cpu architecture</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#cpuArchitecture">https://w3id.org/aerOS/continuum#cpuArchitecture</seealso>
    let cpuArchitecture = Prefixed_Name(aoscon, "cpuArchitecture") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:containerImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>container image</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#containerImage">https://w3id.org/aerOS/continuum#containerImage</seealso>
    let containerImage = Prefixed_Name(aoscon, "containerImage") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:cpuCores</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>cpu cores</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#cpuCores">https://w3id.org/aerOS/continuum#cpuCores</seealso>
    let cpuCores = Prefixed_Name(aoscon, "cpuCores") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:currentPowerConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>current power consumption</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#currentPowerConsumption">https://w3id.org/aerOS/continuum#currentPowerConsumption</seealso>
    let currentPowerConsumption =
        Prefixed_Name(aoscon, "currentPowerConsumption") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>domain</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#domain">https://w3id.org/aerOS/continuum#domain</seealso>
    let domain = Prefixed_Name(aoscon, "domain") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:envVars</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>env vars</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#envVars">https://w3id.org/aerOS/continuum#envVars</seealso>
    let envVars = Prefixed_Name(aoscon, "envVars") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:infrastructureElementStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>infrastructure element status</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#infrastructureElementStatus">https://w3id.org/aerOS/continuum#infrastructureElementStatus</seealso>
    let infrastructureElementStatus =
        Prefixed_Name(aoscon, "infrastructureElementStatus") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:internalIpAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>internal ip address</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#internalIpAddress">https://w3id.org/aerOS/continuum#internalIpAddress</seealso>
    let internalIpAddress = Prefixed_Name(aoscon, "internalIpAddress") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:isPartOfService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is part of service</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#isPartOfService">https://w3id.org/aerOS/continuum#isPartOfService</seealso>
    let isPartOfService = Prefixed_Name(aoscon, "isPartOfService") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>location</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#location">https://w3id.org/aerOS/continuum#location</seealso>
    let location = Prefixed_Name(aoscon, "location") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:operatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>operating system</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#operatingSystem">https://w3id.org/aerOS/continuum#operatingSystem</seealso>
    let operatingSystem = Prefixed_Name(aoscon, "operatingSystem") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>owner</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#owner">https://w3id.org/aerOS/continuum#owner</seealso>
    let owner = Prefixed_Name(aoscon, "owner") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:publicUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>public url</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#publicUrl">https://w3id.org/aerOS/continuum#publicUrl</seealso>
    let publicUrl = Prefixed_Name(aoscon, "publicUrl") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:ramCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ram capacity</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ramCapacity">https://w3id.org/aerOS/continuum#ramCapacity</seealso>
    let ramCapacity = Prefixed_Name(aoscon, "ramCapacity") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:realTimeCapable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>real time capable</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#realTimeCapable">https://w3id.org/aerOS/continuum#realTimeCapable</seealso>
    let realTimeCapable = Prefixed_Name(aoscon, "realTimeCapable") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:requiredCpuUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>required cpu usage</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#requiredCpuUsage">https://w3id.org/aerOS/continuum#requiredCpuUsage</seealso>
    let requiredCpuUsage = Prefixed_Name(aoscon, "requiredCpuUsage") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:serviceComponentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>service component status</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#serviceComponentStatus">https://w3id.org/aerOS/continuum#serviceComponentStatus</seealso>
    let serviceComponentStatus =
        Prefixed_Name(aoscon, "serviceComponentStatus") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:serviceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>service type</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#serviceType">https://w3id.org/aerOS/continuum#serviceType</seealso>
    let serviceType = Prefixed_Name(aoscon, "serviceType") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:webPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>web page</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#webPage">https://w3id.org/aerOS/continuum#webPage</seealso>
    let webPage = Prefixed_Name(aoscon, "webPage") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:withinArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>within area</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#withinArea">https://w3id.org/aerOS/continuum#withinArea</seealso>
    let withinArea = Prefixed_Name(aoscon, "withinArea") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:CloudTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementTier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#CloudTier">https://w3id.org/aerOS/continuum#CloudTier</seealso>
    let CloudTier = Prefixed_Name(aoscon, "CloudTier") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:InfrastructureElementTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the computing continuum tier (cloud, edge, ...) of an IE.</para>
    /// labels<para>Infrastructure Element Tier</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#InfrastructureElementTier">https://w3id.org/aerOS/continuum#InfrastructureElementTier</seealso>
    let InfrastructureElementTier =
        Prefixed_Name(aoscon, "InfrastructureElementTier") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:DockerOrchestration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#OrchestrationType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#DockerOrchestration">https://w3id.org/aerOS/continuum#DockerOrchestration</seealso>
    let DockerOrchestration =
        Prefixed_Name(aoscon, "DockerOrchestration") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:EdgeTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementTier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#EdgeTier">https://w3id.org/aerOS/continuum#EdgeTier</seealso>
    let EdgeTier = Prefixed_Name(aoscon, "EdgeTier") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:FailedServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#FailedServiceComponent">https://w3id.org/aerOS/continuum#FailedServiceComponent</seealso>
    let FailedServiceComponent =
        Prefixed_Name(aoscon, "FailedServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:ServiceComponentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Service Component Status</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ServiceComponentStatus">https://w3id.org/aerOS/continuum#ServiceComponentStatus</seealso>
    let ServiceComponentStatus =
        Prefixed_Name(aoscon, "ServiceComponentStatus") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:FarEdgeTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementTier</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#FarEdgeTier">https://w3id.org/aerOS/continuum#FarEdgeTier</seealso>
    let FarEdgeTier = Prefixed_Name(aoscon, "FarEdgeTier") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:InfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The fundamental building block within aerOS Meta-OS. A physical or virtual computing resource providing the necessary processing power, storage capacity, and network connectivity to support containerised workloads and services.
    ///
    /// Exposes aerOS runtime on top of provided capabilities being thus the minimum execution unit within the IoT-Edge-Cloud continuum."</para>
    /// labels<para>Infrastructure Element</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#InfrastructureElement">https://w3id.org/aerOS/continuum#InfrastructureElement</seealso>
    let InfrastructureElement =
        Prefixed_Name(aoscon, "InfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:InfrastructureElementRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the IE requirements for running a service component.</para>
    /// labels<para>Infrastructure Element Requirements</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#InfrastructureElementRequirements">https://w3id.org/aerOS/continuum#InfrastructureElementRequirements</seealso>
    let InfrastructureElementRequirements =
        Prefixed_Name(aoscon, "InfrastructureElementRequirements") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:IotTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementTier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#IotTier">https://w3id.org/aerOS/continuum#IotTier</seealso>
    let IotTier = Prefixed_Name(aoscon, "IotTier") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>aerOS Continuum Ontology</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#">https://w3id.org/aerOS/continuum#</seealso>
    let _prefix_iri = Prefixed_Name(aoscon, "") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:OrchestrationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Container orchestration technology.</para>
    /// labels<para>Orchestration Type</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#OrchestrationType">https://w3id.org/aerOS/continuum#OrchestrationType</seealso>
    let OrchestrationType = Prefixed_Name(aoscon, "OrchestrationType") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:CpuArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cpu Architecture</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#CpuArchitecture">https://w3id.org/aerOS/continuum#CpuArchitecture</seealso>
    let CpuArchitecture = Prefixed_Name(aoscon, "CpuArchitecture") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:DomainStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the status of a domain. Possible types are Preliminar, Functional, Removed.Represents the status of a domain. Possible types are Preliminar, Functional, Removed.</para>
    /// labels<para>Domain Status</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#DomainStatus">https://w3id.org/aerOS/continuum#DomainStatus</seealso>
    let DomainStatus = Prefixed_Name(aoscon, "DomainStatus") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:orchestrationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>orchestration type</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#orchestrationType">https://w3id.org/aerOS/continuum#orchestrationType</seealso>
    let orchestrationType = Prefixed_Name(aoscon, "orchestrationType") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:portNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>port number</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#portNumber">https://w3id.org/aerOS/continuum#portNumber</seealso>
    let portNumber = Prefixed_Name(aoscon, "portNumber") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:requiredRam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>required ram</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#requiredRam">https://w3id.org/aerOS/continuum#requiredRam</seealso>
    let requiredRam = Prefixed_Name(aoscon, "requiredRam") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:username</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>username</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#username">https://w3id.org/aerOS/continuum#username</seealso>
    let username = Prefixed_Name(aoscon, "username") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:sla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>sla</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#sla">https://w3id.org/aerOS/continuum#sla</seealso>
    let sla = Prefixed_Name(aoscon, "sla") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:x64Architecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#CpuArchitecture</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#x64Architecture">https://w3id.org/aerOS/continuum#x64Architecture</seealso>
    let x64Architecture = Prefixed_Name(aoscon, "x64Architecture") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:ContainerdOrchestration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#OrchestrationType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ContainerdOrchestration">https://w3id.org/aerOS/continuum#ContainerdOrchestration</seealso>
    let ContainerdOrchestration =
        Prefixed_Name(aoscon, "ContainerdOrchestration") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:FinishedServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#FinishedServiceComponent">https://w3id.org/aerOS/continuum#FinishedServiceComponent</seealso>
    let FinishedServiceComponent =
        Prefixed_Name(aoscon, "FinishedServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:FunctionalDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#DomainStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#FunctionalDomain">https://w3id.org/aerOS/continuum#FunctionalDomain</seealso>
    let FunctionalDomain = Prefixed_Name(aoscon, "FunctionalDomain") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:KubernetesOrchestration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#OrchestrationType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#KubernetesOrchestration">https://w3id.org/aerOS/continuum#KubernetesOrchestration</seealso>
    let KubernetesOrchestration =
        Prefixed_Name(aoscon, "KubernetesOrchestration") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:OperatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Operating System</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#OperatingSystem">https://w3id.org/aerOS/continuum#OperatingSystem</seealso>
    let OperatingSystem = Prefixed_Name(aoscon, "OperatingSystem") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:MigratingServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#MigratingServiceComponent">https://w3id.org/aerOS/continuum#MigratingServiceComponent</seealso>
    let MigratingServiceComponent =
        Prefixed_Name(aoscon, "MigratingServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:OpenstackOrchestration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#OrchestrationType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#OpenstackOrchestration">https://w3id.org/aerOS/continuum#OpenstackOrchestration</seealso>
    let OpenstackOrchestration =
        Prefixed_Name(aoscon, "OpenstackOrchestration") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:Linux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#OperatingSystem</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#Linux">https://w3id.org/aerOS/continuum#Linux</seealso>
    let Linux = Prefixed_Name(aoscon, "Linux") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:OverloadInfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#OverloadInfrastructureElement">https://w3id.org/aerOS/continuum#OverloadInfrastructureElement</seealso>
    let OverloadInfrastructureElement =
        Prefixed_Name(aoscon, "OverloadInfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:LocatingServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#LocatingServiceComponent">https://w3id.org/aerOS/continuum#LocatingServiceComponent</seealso>
    let LocatingServiceComponent =
        Prefixed_Name(aoscon, "LocatingServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:PreliminarDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#DomainStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#PreliminarDomain">https://w3id.org/aerOS/continuum#PreliminarDomain</seealso>
    let PreliminarDomain = Prefixed_Name(aoscon, "PreliminarDomain") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:RemovedDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#DomainStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#RemovedDomain">https://w3id.org/aerOS/continuum#RemovedDomain</seealso>
    let RemovedDomain = Prefixed_Name(aoscon, "RemovedDomain") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:RunningServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#RunningServiceComponent">https://w3id.org/aerOS/continuum#RunningServiceComponent</seealso>
    let RunningServiceComponent =
        Prefixed_Name(aoscon, "RunningServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:UntrustedInfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#UntrustedInfrastructureElement">https://w3id.org/aerOS/continuum#UntrustedInfrastructureElement</seealso>
    let UntrustedInfrastructureElement =
        Prefixed_Name(aoscon, "UntrustedInfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:arm32Architecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#CpuArchitecture</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#arm32Architecture">https://w3id.org/aerOS/continuum#arm32Architecture</seealso>
    let arm32Architecture = Prefixed_Name(aoscon, "arm32Architecture") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:availableRam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>available ram</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#availableRam">https://w3id.org/aerOS/continuum#availableRam</seealso>
    let availableRam = Prefixed_Name(aoscon, "availableRam") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of one or more IEs, functionally connected and sharing a common instance of aerOS basic services among them, constituting an administrative domain able to be managed and orchestrated by aerOS Meta-OS and thus be part of the IoT-Edge-Cloud continuum.</para>
    /// labels<para>Domain</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#Domain">https://w3id.org/aerOS/continuum#Domain</seealso>
    let Domain = Prefixed_Name(aoscon, "Domain") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a single instance of an IoT service with a unique identifier. A service is composed by one or some ServiceComponents.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#Service">https://w3id.org/aerOS/continuum#Service</seealso>
    let Service = Prefixed_Name(aoscon, "Service") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:currentCpuUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>current cpu usage</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#currentCpuUsage">https://w3id.org/aerOS/continuum#currentCpuUsage</seealso>
    let currentCpuUsage = Prefixed_Name(aoscon, "currentCpuUsage") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:deployedOnServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>deployed on service component</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#deployedOnServiceComponent">https://w3id.org/aerOS/continuum#deployedOnServiceComponent</seealso>
    let deployedOnServiceComponent =
        Prefixed_Name(aoscon, "deployedOnServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:exposesNetworkPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>exposes network port</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#exposesNetworkPort">https://w3id.org/aerOS/continuum#exposesNetworkPort</seealso>
    let exposesNetworkPort = Prefixed_Name(aoscon, "exposesNetworkPort") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:infrastructureElementTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>infrastructure element tier</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#infrastructureElementTier">https://w3id.org/aerOS/continuum#infrastructureElementTier</seealso>
    let infrastructureElementTier =
        Prefixed_Name(aoscon, "infrastructureElementTier") |> PrefixedName

    /// <summary>
    ///   <para>aoscon:isEntrypoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>is entrypoint</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#isEntrypoint">https://w3id.org/aerOS/continuum#isEntrypoint</seealso>
    let isEntrypoint = Prefixed_Name(aoscon, "isEntrypoint") |> PrefixedName
    /// <summary>
    ///   <para>aoscon:macAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>mac address</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#macAddress">https://w3id.org/aerOS/continuum#macAddress</seealso>
    let macAddress = Prefixed_Name(aoscon, "macAddress") |> PrefixedName
