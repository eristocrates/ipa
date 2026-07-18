namespace https.w3id.org.aerOS.continuum.hash

open DoxAletheia.Rdf_Vocabulary

module aeros =
    let _namespace_name = "https://w3id.org/aerOS/continuum#"
    /// <summary>
    /// A set of one or more IEs, functionally connected and sharing a common instance of aerOS basic services among them, constituting an administrative domain able to be managed and orchestrated by aerOS Meta-OS and thus be part of the IoT-Edge-Cloud continuum.
    /// <see href="https://w3id.org/aerOS/continuum#Domain"></see></summary>
    let Domain = Namespaced_IRI.parse _namespace_name "Domain" |> NamespacedName
    /// <summary>
    /// Represents a single instance of an IoT service with a unique identifier. A service is composed by one or some ServiceComponents.
    /// <see href="https://w3id.org/aerOS/continuum#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// Individual, deployable units that together constitute a Service in the aerOS ecosystem, each with a specific role or function.
    /// <see href="https://w3id.org/aerOS/continuum#ServiceComponent"></see></summary>
    let ServiceComponent =
        Namespaced_IRI.parse _namespace_name "ServiceComponent" |> NamespacedName

    /// <summary>
    /// Identifies the services such as a "catalogue".
    /// <see href="https://w3id.org/aerOS/continuum#ServiceType"></see></summary>
    let ServiceType =
        Namespaced_IRI.parse _namespace_name "ServiceType" |> NamespacedName

    /// <summary>
    /// This element interprets the Decision Blueprint coming from the HLO and oversees the actual deployment of workloads in the selected IE(s). Being aware of the underlying container management frameworks, is able to convert the allocation order into proper deployment. Several LLOs may live in the same domain.
    /// <see href="https://w3id.org/aerOS/continuum#LowLevelOrchestrator"></see></summary>
    let LowLevelOrchestrator =
        Namespaced_IRI.parse _namespace_name "LowLevelOrchestrator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#NetworkPort"></see>
    /// </summary>
    let NetworkPort =
        Namespaced_IRI.parse _namespace_name "NetworkPort" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#CloudTier"></see>
    /// </summary>
    let CloudTier = Namespaced_IRI.parse _namespace_name "CloudTier" |> NamespacedName

    /// <summary>
    /// Represents the computing continuum tier (cloud, edge, ...) of an IE.
    /// <see href="https://w3id.org/aerOS/continuum#InfrastructureElementTier"></see></summary>
    let InfrastructureElementTier =
        Namespaced_IRI.parse _namespace_name "InfrastructureElementTier" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#ContainerdOrchestration"></see>
    /// </summary>
    let ContainerdOrchestration =
        Namespaced_IRI.parse _namespace_name "ContainerdOrchestration" |> NamespacedName

    /// <summary>
    /// Container orchestration technology.
    /// <see href="https://w3id.org/aerOS/continuum#OrchestrationType"></see></summary>
    let OrchestrationType =
        Namespaced_IRI.parse _namespace_name "OrchestrationType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#CpuArchitecture"></see>
    /// </summary>
    let CpuArchitecture =
        Namespaced_IRI.parse _namespace_name "CpuArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#DockerOrchestration"></see>
    /// </summary>
    let DockerOrchestration =
        Namespaced_IRI.parse _namespace_name "DockerOrchestration" |> NamespacedName

    /// <summary>
    /// Represents the status of a domain. Possible types are Preliminar, Functional, Removed.Represents the status of a domain. Possible types are Preliminar, Functional, Removed.
    /// <see href="https://w3id.org/aerOS/continuum#DomainStatus"></see></summary>
    let DomainStatus =
        Namespaced_IRI.parse _namespace_name "DomainStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#EdgeTier"></see>
    /// </summary>
    let EdgeTier = Namespaced_IRI.parse _namespace_name "EdgeTier" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#FailedServiceComponent"></see>
    /// </summary>
    let FailedServiceComponent =
        Namespaced_IRI.parse _namespace_name "FailedServiceComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#ServiceComponentStatus"></see>
    /// </summary>
    let ServiceComponentStatus =
        Namespaced_IRI.parse _namespace_name "ServiceComponentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#FarEdgeTier"></see>
    /// </summary>
    let FarEdgeTier =
        Namespaced_IRI.parse _namespace_name "FarEdgeTier" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#FinishedServiceComponent"></see>
    /// </summary>
    let FinishedServiceComponent =
        Namespaced_IRI.parse _namespace_name "FinishedServiceComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#FunctionalDomain"></see>
    /// </summary>
    let FunctionalDomain =
        Namespaced_IRI.parse _namespace_name "FunctionalDomain" |> NamespacedName

    /// <summary>
    /// "The fundamental building block within aerOS Meta-OS. A physical or virtual computing resource providing the necessary processing power, storage capacity, and network connectivity to support containerised workloads and services.
    ///
    /// Exposes aerOS runtime on top of provided capabilities being thus the minimum execution unit within the IoT-Edge-Cloud continuum."
    /// <see href="https://w3id.org/aerOS/continuum#InfrastructureElement"></see></summary>
    let InfrastructureElement =
        Namespaced_IRI.parse _namespace_name "InfrastructureElement" |> NamespacedName

    /// <summary>
    /// Represents the IE requirements for running a service component.
    /// <see href="https://w3id.org/aerOS/continuum#InfrastructureElementRequirements"></see></summary>
    let InfrastructureElementRequirements =
        Namespaced_IRI.parse _namespace_name "InfrastructureElementRequirements" |> NamespacedName

    /// <summary>
    /// Represents the status of an IE. Possible types are READY, OVERLOAD, UNSECURE, UNTRUSTED.
    /// <see href="https://w3id.org/aerOS/continuum#InfrastructureElementStatus"></see></summary>
    let InfrastructureElementStatus =
        Namespaced_IRI.parse _namespace_name "InfrastructureElementStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#IotTier"></see>
    /// </summary>
    let IotTier = Namespaced_IRI.parse _namespace_name "IotTier" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#KubernetesOrchestration"></see>
    /// </summary>
    let KubernetesOrchestration =
        Namespaced_IRI.parse _namespace_name "KubernetesOrchestration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#Linux"></see>
    /// </summary>
    let Linux = Namespaced_IRI.parse _namespace_name "Linux" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#OperatingSystem"></see>
    /// </summary>
    let OperatingSystem =
        Namespaced_IRI.parse _namespace_name "OperatingSystem" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#LocatingServiceComponent"></see>
    /// </summary>
    let LocatingServiceComponent =
        Namespaced_IRI.parse _namespace_name "LocatingServiceComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#MigratingServiceComponent"></see>
    /// </summary>
    let MigratingServiceComponent =
        Namespaced_IRI.parse _namespace_name "MigratingServiceComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#OpenstackOrchestration"></see>
    /// </summary>
    let OpenstackOrchestration =
        Namespaced_IRI.parse _namespace_name "OpenstackOrchestration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#OverloadInfrastructureElement"></see>
    /// </summary>
    let OverloadInfrastructureElement =
        Namespaced_IRI.parse _namespace_name "OverloadInfrastructureElement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#OverloadServiceComponent"></see>
    /// </summary>
    let OverloadServiceComponent =
        Namespaced_IRI.parse _namespace_name "OverloadServiceComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#PreliminarDomain"></see>
    /// </summary>
    let PreliminarDomain =
        Namespaced_IRI.parse _namespace_name "PreliminarDomain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#ReadyInfrastructureElement"></see>
    /// </summary>
    let ReadyInfrastructureElement =
        Namespaced_IRI.parse _namespace_name "ReadyInfrastructureElement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#RemovedDomain"></see>
    /// </summary>
    let RemovedDomain =
        Namespaced_IRI.parse _namespace_name "RemovedDomain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#RemovingServiceComponent"></see>
    /// </summary>
    let RemovingServiceComponent =
        Namespaced_IRI.parse _namespace_name "RemovingServiceComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#RunningServiceComponent"></see>
    /// </summary>
    let RunningServiceComponent =
        Namespaced_IRI.parse _namespace_name "RunningServiceComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#StartingServiceComponent"></see>
    /// </summary>
    let StartingServiceComponent =
        Namespaced_IRI.parse _namespace_name "StartingServiceComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#UnsecureInfrastructureElement"></see>
    /// </summary>
    let UnsecureInfrastructureElement =
        Namespaced_IRI.parse _namespace_name "UnsecureInfrastructureElement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#UntrustedInfrastructureElement"></see>
    /// </summary>
    let UntrustedInfrastructureElement =
        Namespaced_IRI.parse _namespace_name "UntrustedInfrastructureElement" |> NamespacedName

    /// <summary>
    /// Person with access to the capabilities of the continuum.
    /// <see href="https://w3id.org/aerOS/continuum#User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#Windows"></see>
    /// </summary>
    let Windows = Namespaced_IRI.parse _namespace_name "Windows" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#arm32Architecture"></see>
    /// </summary>
    let arm32Architecture =
        Namespaced_IRI.parse _namespace_name "arm32Architecture" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#arm64Architecture"></see>
    /// </summary>
    let arm64Architecture =
        Namespaced_IRI.parse _namespace_name "arm64Architecture" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#availableRam"></see>
    /// </summary>
    let availableRam =
        Namespaced_IRI.parse _namespace_name "availableRam" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#averagePowerConsumption"></see>
    /// </summary>
    let averagePowerConsumption =
        Namespaced_IRI.parse _namespace_name "averagePowerConsumption" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#belongsTo"></see>
    /// </summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#cliArgs"></see>
    /// </summary>
    let cliArgs = Namespaced_IRI.parse _namespace_name "cliArgs" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#containerImage"></see>
    /// </summary>
    let containerImage =
        Namespaced_IRI.parse _namespace_name "containerImage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#cpuArchitecture"></see>
    /// </summary>
    let cpuArchitecture =
        Namespaced_IRI.parse _namespace_name "cpuArchitecture" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#cpuCores"></see>
    /// </summary>
    let cpuCores = Namespaced_IRI.parse _namespace_name "cpuCores" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#currentCpuUsage"></see>
    /// </summary>
    let currentCpuUsage =
        Namespaced_IRI.parse _namespace_name "currentCpuUsage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#currentPowerConsumption"></see>
    /// </summary>
    let currentPowerConsumption =
        Namespaced_IRI.parse _namespace_name "currentPowerConsumption" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#currentRamUsage"></see>
    /// </summary>
    let currentRamUsage =
        Namespaced_IRI.parse _namespace_name "currentRamUsage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#deployedOnServiceComponent"></see>
    /// </summary>
    let deployedOnServiceComponent =
        Namespaced_IRI.parse _namespace_name "deployedOnServiceComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#domain"></see>
    /// </summary>
    let domain = Namespaced_IRI.parse _namespace_name "domain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#domainStatus"></see>
    /// </summary>
    let domainStatus =
        Namespaced_IRI.parse _namespace_name "domainStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#envVars"></see>
    /// </summary>
    let envVars = Namespaced_IRI.parse _namespace_name "envVars" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#exposesNetworkPort"></see>
    /// </summary>
    let exposesNetworkPort =
        Namespaced_IRI.parse _namespace_name "exposesNetworkPort" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#infrastructureElementRequirements"></see>
    /// </summary>
    let infrastructureElementRequirements =
        Namespaced_IRI.parse _namespace_name "infrastructureElementRequirements" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#infrastructureElementStatus"></see>
    /// </summary>
    let infrastructureElementStatus =
        Namespaced_IRI.parse _namespace_name "infrastructureElementStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#infrastructureElementTier"></see>
    /// </summary>
    let infrastructureElementTier =
        Namespaced_IRI.parse _namespace_name "infrastructureElementTier" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#internalIpAddress"></see>
    /// </summary>
    let internalIpAddress =
        Namespaced_IRI.parse _namespace_name "internalIpAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#isEntrypoint"></see>
    /// </summary>
    let isEntrypoint =
        Namespaced_IRI.parse _namespace_name "isEntrypoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#isPartOfService"></see>
    /// </summary>
    let isPartOfService =
        Namespaced_IRI.parse _namespace_name "isPartOfService" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#location"></see>
    /// </summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#macAddress"></see>
    /// </summary>
    let macAddress = Namespaced_IRI.parse _namespace_name "macAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#operatingSystem"></see>
    /// </summary>
    let operatingSystem =
        Namespaced_IRI.parse _namespace_name "operatingSystem" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#orchestrationType"></see>
    /// </summary>
    let orchestrationType =
        Namespaced_IRI.parse _namespace_name "orchestrationType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#portNumber"></see>
    /// </summary>
    let portNumber = Namespaced_IRI.parse _namespace_name "portNumber" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#publicUrl"></see>
    /// </summary>
    let publicUrl = Namespaced_IRI.parse _namespace_name "publicUrl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#ramCapacity"></see>
    /// </summary>
    let ramCapacity =
        Namespaced_IRI.parse _namespace_name "ramCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#realTimeCapable"></see>
    /// </summary>
    let realTimeCapable =
        Namespaced_IRI.parse _namespace_name "realTimeCapable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#requiredCpuUsage"></see>
    /// </summary>
    let requiredCpuUsage =
        Namespaced_IRI.parse _namespace_name "requiredCpuUsage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#requiredRam"></see>
    /// </summary>
    let requiredRam =
        Namespaced_IRI.parse _namespace_name "requiredRam" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#serviceComponentStatus"></see>
    /// </summary>
    let serviceComponentStatus =
        Namespaced_IRI.parse _namespace_name "serviceComponentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#serviceType"></see>
    /// </summary>
    let serviceType =
        Namespaced_IRI.parse _namespace_name "serviceType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#sla"></see>
    /// </summary>
    let sla = Namespaced_IRI.parse _namespace_name "sla" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#username"></see>
    /// </summary>
    let username = Namespaced_IRI.parse _namespace_name "username" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#webPage"></see>
    /// </summary>
    let webPage = Namespaced_IRI.parse _namespace_name "webPage" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#withinArea"></see>
    /// </summary>
    let withinArea = Namespaced_IRI.parse _namespace_name "withinArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#x64Architecture"></see>
    /// </summary>
    let x64Architecture =
        Namespaced_IRI.parse _namespace_name "x64Architecture" |> NamespacedName
