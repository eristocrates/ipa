namespace https.w3id.org.aerOS.continuum.hash

open DoxAletheia

module aeros =
    let _namespace_name = "https://w3id.org/aerOS/continuum#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A set of one or more IEs, functionally connected and sharing a common instance of aerOS basic services among them, constituting an administrative domain able to be managed and orchestrated by aerOS Meta-OS and thus be part of the IoT-Edge-Cloud continuum.
    /// <see href="https://w3id.org/aerOS/continuum#Domain"></see></summary>
    let Domain = _prefix "Domain"
    /// <summary>
    /// Represents a single instance of an IoT service with a unique identifier. A service is composed by one or some ServiceComponents.
    /// <see href="https://w3id.org/aerOS/continuum#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// Individual, deployable units that together constitute a Service in the aerOS ecosystem, each with a specific role or function.
    /// <see href="https://w3id.org/aerOS/continuum#ServiceComponent"></see></summary>
    let ServiceComponent = _prefix "ServiceComponent"
    /// <summary>
    /// Identifies the services such as a "catalogue".
    /// <see href="https://w3id.org/aerOS/continuum#ServiceType"></see></summary>
    let ServiceType = _prefix "ServiceType"
    /// <summary>
    /// This element interprets the Decision Blueprint coming from the HLO and oversees the actual deployment of workloads in the selected IE(s). Being aware of the underlying container management frameworks, is able to convert the allocation order into proper deployment. Several LLOs may live in the same domain.
    /// <see href="https://w3id.org/aerOS/continuum#LowLevelOrchestrator"></see></summary>
    let LowLevelOrchestrator = _prefix "LowLevelOrchestrator"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#NetworkPort"></see>
    /// </summary>
    let NetworkPort = _prefix "NetworkPort"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#CloudTier"></see>
    /// </summary>
    let CloudTier = _prefix "CloudTier"
    /// <summary>
    /// Represents the computing continuum tier (cloud, edge, ...) of an IE.
    /// <see href="https://w3id.org/aerOS/continuum#InfrastructureElementTier"></see></summary>
    let InfrastructureElementTier = _prefix "InfrastructureElementTier"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#ContainerdOrchestration"></see>
    /// </summary>
    let ContainerdOrchestration = _prefix "ContainerdOrchestration"
    /// <summary>
    /// Container orchestration technology.
    /// <see href="https://w3id.org/aerOS/continuum#OrchestrationType"></see></summary>
    let OrchestrationType = _prefix "OrchestrationType"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#CpuArchitecture"></see>
    /// </summary>
    let CpuArchitecture = _prefix "CpuArchitecture"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#DockerOrchestration"></see>
    /// </summary>
    let DockerOrchestration = _prefix "DockerOrchestration"
    /// <summary>
    /// Represents the status of a domain. Possible types are Preliminar, Functional, Removed.Represents the status of a domain. Possible types are Preliminar, Functional, Removed.
    /// <see href="https://w3id.org/aerOS/continuum#DomainStatus"></see></summary>
    let DomainStatus = _prefix "DomainStatus"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#EdgeTier"></see>
    /// </summary>
    let EdgeTier = _prefix "EdgeTier"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#FailedServiceComponent"></see>
    /// </summary>
    let FailedServiceComponent = _prefix "FailedServiceComponent"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#ServiceComponentStatus"></see>
    /// </summary>
    let ServiceComponentStatus = _prefix "ServiceComponentStatus"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#FarEdgeTier"></see>
    /// </summary>
    let FarEdgeTier = _prefix "FarEdgeTier"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#FinishedServiceComponent"></see>
    /// </summary>
    let FinishedServiceComponent = _prefix "FinishedServiceComponent"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#FunctionalDomain"></see>
    /// </summary>
    let FunctionalDomain = _prefix "FunctionalDomain"
    /// <summary>
    /// "The fundamental building block within aerOS Meta-OS. A physical or virtual computing resource providing the necessary processing power, storage capacity, and network connectivity to support containerised workloads and services.
    ///
    /// Exposes aerOS runtime on top of provided capabilities being thus the minimum execution unit within the IoT-Edge-Cloud continuum."
    /// <see href="https://w3id.org/aerOS/continuum#InfrastructureElement"></see></summary>
    let InfrastructureElement = _prefix "InfrastructureElement"
    /// <summary>
    /// Represents the IE requirements for running a service component.
    /// <see href="https://w3id.org/aerOS/continuum#InfrastructureElementRequirements"></see></summary>
    let InfrastructureElementRequirements = _prefix "InfrastructureElementRequirements"
    /// <summary>
    /// Represents the status of an IE. Possible types are READY, OVERLOAD, UNSECURE, UNTRUSTED.
    /// <see href="https://w3id.org/aerOS/continuum#InfrastructureElementStatus"></see></summary>
    let InfrastructureElementStatus = _prefix "InfrastructureElementStatus"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#IotTier"></see>
    /// </summary>
    let IotTier = _prefix "IotTier"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#KubernetesOrchestration"></see>
    /// </summary>
    let KubernetesOrchestration = _prefix "KubernetesOrchestration"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#Linux"></see>
    /// </summary>
    let Linux = _prefix "Linux"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#OperatingSystem"></see>
    /// </summary>
    let OperatingSystem = _prefix "OperatingSystem"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#LocatingServiceComponent"></see>
    /// </summary>
    let LocatingServiceComponent = _prefix "LocatingServiceComponent"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#MigratingServiceComponent"></see>
    /// </summary>
    let MigratingServiceComponent = _prefix "MigratingServiceComponent"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#OpenstackOrchestration"></see>
    /// </summary>
    let OpenstackOrchestration = _prefix "OpenstackOrchestration"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#OverloadInfrastructureElement"></see>
    /// </summary>
    let OverloadInfrastructureElement = _prefix "OverloadInfrastructureElement"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#OverloadServiceComponent"></see>
    /// </summary>
    let OverloadServiceComponent = _prefix "OverloadServiceComponent"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#PreliminarDomain"></see>
    /// </summary>
    let PreliminarDomain = _prefix "PreliminarDomain"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#ReadyInfrastructureElement"></see>
    /// </summary>
    let ReadyInfrastructureElement = _prefix "ReadyInfrastructureElement"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#RemovedDomain"></see>
    /// </summary>
    let RemovedDomain = _prefix "RemovedDomain"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#RemovingServiceComponent"></see>
    /// </summary>
    let RemovingServiceComponent = _prefix "RemovingServiceComponent"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#RunningServiceComponent"></see>
    /// </summary>
    let RunningServiceComponent = _prefix "RunningServiceComponent"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#StartingServiceComponent"></see>
    /// </summary>
    let StartingServiceComponent = _prefix "StartingServiceComponent"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#UnsecureInfrastructureElement"></see>
    /// </summary>
    let UnsecureInfrastructureElement = _prefix "UnsecureInfrastructureElement"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#UntrustedInfrastructureElement"></see>
    /// </summary>
    let UntrustedInfrastructureElement = _prefix "UntrustedInfrastructureElement"
    /// <summary>
    /// Person with access to the capabilities of the continuum.
    /// <see href="https://w3id.org/aerOS/continuum#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#Windows"></see>
    /// </summary>
    let Windows = _prefix "Windows"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#arm32Architecture"></see>
    /// </summary>
    let arm32Architecture = _prefix "arm32Architecture"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#arm64Architecture"></see>
    /// </summary>
    let arm64Architecture = _prefix "arm64Architecture"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#availableRam"></see>
    /// </summary>
    let availableRam = _prefix "availableRam"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#averagePowerConsumption"></see>
    /// </summary>
    let averagePowerConsumption = _prefix "averagePowerConsumption"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#belongsTo"></see>
    /// </summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#cliArgs"></see>
    /// </summary>
    let cliArgs = _prefix "cliArgs"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#containerImage"></see>
    /// </summary>
    let containerImage = _prefix "containerImage"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#cpuArchitecture"></see>
    /// </summary>
    let cpuArchitecture = _prefix "cpuArchitecture"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#cpuCores"></see>
    /// </summary>
    let cpuCores = _prefix "cpuCores"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#currentCpuUsage"></see>
    /// </summary>
    let currentCpuUsage = _prefix "currentCpuUsage"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#currentPowerConsumption"></see>
    /// </summary>
    let currentPowerConsumption = _prefix "currentPowerConsumption"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#currentRamUsage"></see>
    /// </summary>
    let currentRamUsage = _prefix "currentRamUsage"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#deployedOnServiceComponent"></see>
    /// </summary>
    let deployedOnServiceComponent = _prefix "deployedOnServiceComponent"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#domain"></see>
    /// </summary>
    let domain = _prefix "domain"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#domainStatus"></see>
    /// </summary>
    let domainStatus = _prefix "domainStatus"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#envVars"></see>
    /// </summary>
    let envVars = _prefix "envVars"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#exposesNetworkPort"></see>
    /// </summary>
    let exposesNetworkPort = _prefix "exposesNetworkPort"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#infrastructureElementRequirements"></see>
    /// </summary>
    let infrastructureElementRequirements = _prefix "infrastructureElementRequirements"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#infrastructureElementStatus"></see>
    /// </summary>
    let infrastructureElementStatus = _prefix "infrastructureElementStatus"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#infrastructureElementTier"></see>
    /// </summary>
    let infrastructureElementTier = _prefix "infrastructureElementTier"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#internalIpAddress"></see>
    /// </summary>
    let internalIpAddress = _prefix "internalIpAddress"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#isEntrypoint"></see>
    /// </summary>
    let isEntrypoint = _prefix "isEntrypoint"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#isPartOfService"></see>
    /// </summary>
    let isPartOfService = _prefix "isPartOfService"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#location"></see>
    /// </summary>
    let location = _prefix "location"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#macAddress"></see>
    /// </summary>
    let macAddress = _prefix "macAddress"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#operatingSystem"></see>
    /// </summary>
    let operatingSystem = _prefix "operatingSystem"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#orchestrationType"></see>
    /// </summary>
    let orchestrationType = _prefix "orchestrationType"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#portNumber"></see>
    /// </summary>
    let portNumber = _prefix "portNumber"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#publicUrl"></see>
    /// </summary>
    let publicUrl = _prefix "publicUrl"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#ramCapacity"></see>
    /// </summary>
    let ramCapacity = _prefix "ramCapacity"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#realTimeCapable"></see>
    /// </summary>
    let realTimeCapable = _prefix "realTimeCapable"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#requiredCpuUsage"></see>
    /// </summary>
    let requiredCpuUsage = _prefix "requiredCpuUsage"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#requiredRam"></see>
    /// </summary>
    let requiredRam = _prefix "requiredRam"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#serviceComponentStatus"></see>
    /// </summary>
    let serviceComponentStatus = _prefix "serviceComponentStatus"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#serviceType"></see>
    /// </summary>
    let serviceType = _prefix "serviceType"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#sla"></see>
    /// </summary>
    let sla = _prefix "sla"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#username"></see>
    /// </summary>
    let username = _prefix "username"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#webPage"></see>
    /// </summary>
    let webPage = _prefix "webPage"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#withinArea"></see>
    /// </summary>
    let withinArea = _prefix "withinArea"
    /// <summary>
    ///   <see href="https://w3id.org/aerOS/continuum#x64Architecture"></see>
    /// </summary>
    let x64Architecture = _prefix "x64Architecture"
