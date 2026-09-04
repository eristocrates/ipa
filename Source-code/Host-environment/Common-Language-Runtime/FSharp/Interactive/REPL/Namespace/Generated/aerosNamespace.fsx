#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module aeros =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/aerOS/continuum#" "aeros"

    let _namespaceIri = _prefixId.prefix ""
    let CloudTier = _prefixId.prefix "CloudTier"
    let ContainerdOrchestration = _prefixId.prefix "ContainerdOrchestration"
    /// <summary>
    ///   <para>rdfs:label : Cpu Architecture^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#CpuArchitecture">aeros:CpuArchitecture</a>
    /// </summary>
    let CpuArchitecture = _prefixId.prefix "CpuArchitecture"
    let DockerOrchestration = _prefixId.prefix "DockerOrchestration"
    /// <summary>
    ///   <para>rdfs:label : Domain^^xsd:string</para>
    ///   <para>rdfs:comment : A set of one or more IEs, functionally connected and sharing a common instance of aerOS basic services among them, constituting an administrative domain able to be managed and orchestrated by aerOS Meta-OS and thus be part of the IoT-Edge-Cloud continuum.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#Domain">aeros:Domain</a>
    /// </summary>
    let Domain = _prefixId.prefix "Domain"
    /// <summary>
    ///   <para>rdfs:label : Domain Status^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the status of a domain. Possible types are Preliminar, Functional, Removed.Represents the status of a domain. Possible types are Preliminar, Functional, Removed.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#DomainStatus">aeros:DomainStatus</a>
    /// </summary>
    let DomainStatus = _prefixId.prefix "DomainStatus"
    let EdgeTier = _prefixId.prefix "EdgeTier"
    let FailedServiceComponent = _prefixId.prefix "FailedServiceComponent"
    let FarEdgeTier = _prefixId.prefix "FarEdgeTier"
    let FinishedServiceComponent = _prefixId.prefix "FinishedServiceComponent"
    let FunctionalDomain = _prefixId.prefix "FunctionalDomain"
    /// <summary>
    ///   <para>rdfs:label : Infrastructure Element^^xsd:string</para>
    ///   <para>rdfs:comment : "The fundamental building block within aerOS Meta-OS. A physical or virtual computing resource providing the necessary processing power, storage capacity, and network connectivity to support containerised workloads and services.
    ///
    /// Exposes aerOS runtime on top of provided capabilities being thus the minimum execution unit within the IoT-Edge-Cloud continuum."^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#InfrastructureElement">aeros:InfrastructureElement</a>
    /// </summary>
    let InfrastructureElement = _prefixId.prefix "InfrastructureElement"

    /// <summary>
    ///   <para>rdfs:label : Infrastructure Element Requirements^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the IE requirements for running a service component.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#InfrastructureElementRequirements">aeros:InfrastructureElementRequirements</a>
    /// </summary>
    let InfrastructureElementRequirements =
        _prefixId.prefix "InfrastructureElementRequirements"

    /// <summary>
    ///   <para>rdfs:label : Infrastructure Element Status^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the status of an IE. Possible types are READY, OVERLOAD, UNSECURE, UNTRUSTED.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#InfrastructureElementStatus">aeros:InfrastructureElementStatus</a>
    /// </summary>
    let InfrastructureElementStatus = _prefixId.prefix "InfrastructureElementStatus"
    /// <summary>
    ///   <para>rdfs:label : Infrastructure Element Tier^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the computing continuum tier (cloud, edge, ...) of an IE.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#InfrastructureElementTier">aeros:InfrastructureElementTier</a>
    /// </summary>
    let InfrastructureElementTier = _prefixId.prefix "InfrastructureElementTier"
    let IotTier = _prefixId.prefix "IotTier"
    let KubernetesOrchestration = _prefixId.prefix "KubernetesOrchestration"
    let Linux = _prefixId.prefix "Linux"
    let LocatingServiceComponent = _prefixId.prefix "LocatingServiceComponent"
    /// <summary>
    ///   <para>rdfs:label : Low Level Orchestrator^^xsd:string</para>
    ///   <para>rdfs:comment : This element interprets the Decision Blueprint coming from the HLO and oversees the actual deployment of workloads in the selected IE(s). Being aware of the underlying container management frameworks, is able to convert the allocation order into proper deployment. Several LLOs may live in the same domain.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#LowLevelOrchestrator">aeros:LowLevelOrchestrator</a>
    /// </summary>
    let LowLevelOrchestrator = _prefixId.prefix "LowLevelOrchestrator"
    let MigratingServiceComponent = _prefixId.prefix "MigratingServiceComponent"
    /// <summary>
    ///   <para>rdfs:label : Network Port^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#NetworkPort">aeros:NetworkPort</a>
    /// </summary>
    let NetworkPort = _prefixId.prefix "NetworkPort"
    let OpenstackOrchestration = _prefixId.prefix "OpenstackOrchestration"
    /// <summary>
    ///   <para>rdfs:label : Operating System^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#OperatingSystem">aeros:OperatingSystem</a>
    /// </summary>
    let OperatingSystem = _prefixId.prefix "OperatingSystem"
    /// <summary>
    ///   <para>rdfs:label : Orchestration Type^^xsd:string</para>
    ///   <para>rdfs:comment : Container orchestration technology.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#OrchestrationType">aeros:OrchestrationType</a>
    /// </summary>
    let OrchestrationType = _prefixId.prefix "OrchestrationType"
    let OverloadInfrastructureElement = _prefixId.prefix "OverloadInfrastructureElement"
    let OverloadServiceComponent = _prefixId.prefix "OverloadServiceComponent"
    let PreliminarDomain = _prefixId.prefix "PreliminarDomain"
    let ReadyInfrastructureElement = _prefixId.prefix "ReadyInfrastructureElement"
    let RemovedDomain = _prefixId.prefix "RemovedDomain"
    let RemovingServiceComponent = _prefixId.prefix "RemovingServiceComponent"
    let RunningServiceComponent = _prefixId.prefix "RunningServiceComponent"
    /// <summary>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a single instance of an IoT service with a unique identifier. A service is composed by one or some ServiceComponents.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#Service">aeros:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Service Component^^xsd:string</para>
    ///   <para>rdfs:comment : Individual, deployable units that together constitute a Service in the aerOS ecosystem, each with a specific role or function.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#ServiceComponent">aeros:ServiceComponent</a>
    /// </summary>
    let ServiceComponent = _prefixId.prefix "ServiceComponent"
    /// <summary>
    ///   <para>rdfs:label : Service Component Status^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#ServiceComponentStatus">aeros:ServiceComponentStatus</a>
    /// </summary>
    let ServiceComponentStatus = _prefixId.prefix "ServiceComponentStatus"
    /// <summary>
    ///   <para>rdfs:label : Service Type^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies the services such as a "catalogue".^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#ServiceType">aeros:ServiceType</a>
    /// </summary>
    let ServiceType = _prefixId.prefix "ServiceType"
    let StartingServiceComponent = _prefixId.prefix "StartingServiceComponent"
    let UnsecureInfrastructureElement = _prefixId.prefix "UnsecureInfrastructureElement"

    let UntrustedInfrastructureElement =
        _prefixId.prefix "UntrustedInfrastructureElement"

    /// <summary>
    ///   <para>rdfs:label : User^^xsd:string</para>
    ///   <para>rdfs:comment : Person with access to the capabilities of the continuum.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#User">aeros:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    let Windows = _prefixId.prefix "Windows"
    let arm32Architecture = _prefixId.prefix "arm32Architecture"
    let arm64Architecture = _prefixId.prefix "arm64Architecture"
    /// <summary>
    ///   <para>rdfs:label : available ram^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#availableRam">aeros:availableRam</a>
    /// </summary>
    let availableRam = _prefixId.prefix "availableRam"
    /// <summary>
    ///   <para>rdfs:label : average power consumption^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#averagePowerConsumption">aeros:averagePowerConsumption</a>
    /// </summary>
    let averagePowerConsumption = _prefixId.prefix "averagePowerConsumption"
    /// <summary>
    ///   <para>rdfs:label : belongs to^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#belongsTo">aeros:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>rdfs:label : cli args^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#cliArgs">aeros:cliArgs</a>
    /// </summary>
    let cliArgs = _prefixId.prefix "cliArgs"
    /// <summary>
    ///   <para>rdfs:label : container image^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#containerImage">aeros:containerImage</a>
    /// </summary>
    let containerImage = _prefixId.prefix "containerImage"
    /// <summary>
    ///   <para>rdfs:label : cpu architecture^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#cpuArchitecture">aeros:cpuArchitecture</a>
    /// </summary>
    let cpuArchitecture = _prefixId.prefix "cpuArchitecture"
    /// <summary>
    ///   <para>rdfs:label : cpu cores^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#cpuCores">aeros:cpuCores</a>
    /// </summary>
    let cpuCores = _prefixId.prefix "cpuCores"
    /// <summary>
    ///   <para>rdfs:label : current cpu usage^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#currentCpuUsage">aeros:currentCpuUsage</a>
    /// </summary>
    let currentCpuUsage = _prefixId.prefix "currentCpuUsage"
    /// <summary>
    ///   <para>rdfs:label : current power consumption^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#currentPowerConsumption">aeros:currentPowerConsumption</a>
    /// </summary>
    let currentPowerConsumption = _prefixId.prefix "currentPowerConsumption"
    /// <summary>
    ///   <para>rdfs:label : current ram usage^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#currentRamUsage">aeros:currentRamUsage</a>
    /// </summary>
    let currentRamUsage = _prefixId.prefix "currentRamUsage"
    /// <summary>
    ///   <para>rdfs:label : deployed on service component^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#deployedOnServiceComponent">aeros:deployedOnServiceComponent</a>
    /// </summary>
    let deployedOnServiceComponent = _prefixId.prefix "deployedOnServiceComponent"
    /// <summary>
    ///   <para>rdfs:label : domain^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#domain">aeros:domain</a>
    /// </summary>
    let domain = _prefixId.prefix "domain"
    /// <summary>
    ///   <para>rdfs:label : domain status^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#domainStatus">aeros:domainStatus</a>
    /// </summary>
    let domainStatus = _prefixId.prefix "domainStatus"
    /// <summary>
    ///   <para>rdfs:label : env vars^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#envVars">aeros:envVars</a>
    /// </summary>
    let envVars = _prefixId.prefix "envVars"
    /// <summary>
    ///   <para>rdfs:label : exposes network port^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#exposesNetworkPort">aeros:exposesNetworkPort</a>
    /// </summary>
    let exposesNetworkPort = _prefixId.prefix "exposesNetworkPort"

    /// <summary>
    ///   <para>rdfs:label : infrastructure element requirements^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#infrastructureElementRequirements">aeros:infrastructureElementRequirements</a>
    /// </summary>
    let infrastructureElementRequirements =
        _prefixId.prefix "infrastructureElementRequirements"

    /// <summary>
    ///   <para>rdfs:label : infrastructure element status^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#infrastructureElementStatus">aeros:infrastructureElementStatus</a>
    /// </summary>
    let infrastructureElementStatus = _prefixId.prefix "infrastructureElementStatus"
    /// <summary>
    ///   <para>rdfs:label : infrastructure element tier^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#infrastructureElementTier">aeros:infrastructureElementTier</a>
    /// </summary>
    let infrastructureElementTier = _prefixId.prefix "infrastructureElementTier"
    /// <summary>
    ///   <para>rdfs:label : internal ip address^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#internalIpAddress">aeros:internalIpAddress</a>
    /// </summary>
    let internalIpAddress = _prefixId.prefix "internalIpAddress"
    /// <summary>
    ///   <para>rdfs:label : is entrypoint^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#isEntrypoint">aeros:isEntrypoint</a>
    /// </summary>
    let isEntrypoint = _prefixId.prefix "isEntrypoint"
    /// <summary>
    ///   <para>rdfs:label : is part of service^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#isPartOfService">aeros:isPartOfService</a>
    /// </summary>
    let isPartOfService = _prefixId.prefix "isPartOfService"
    /// <summary>
    ///   <para>rdfs:label : location^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#location">aeros:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : mac address^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#macAddress">aeros:macAddress</a>
    /// </summary>
    let macAddress = _prefixId.prefix "macAddress"
    /// <summary>
    ///   <para>rdfs:label : operating system^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#operatingSystem">aeros:operatingSystem</a>
    /// </summary>
    let operatingSystem = _prefixId.prefix "operatingSystem"
    /// <summary>
    ///   <para>rdfs:label : orchestration type^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#orchestrationType">aeros:orchestrationType</a>
    /// </summary>
    let orchestrationType = _prefixId.prefix "orchestrationType"
    /// <summary>
    ///   <para>rdfs:label : owner^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#owner">aeros:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:label : port number^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#portNumber">aeros:portNumber</a>
    /// </summary>
    let portNumber = _prefixId.prefix "portNumber"
    /// <summary>
    ///   <para>rdfs:label : public url^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#publicUrl">aeros:publicUrl</a>
    /// </summary>
    let publicUrl = _prefixId.prefix "publicUrl"
    /// <summary>
    ///   <para>rdfs:label : ram capacity^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#ramCapacity">aeros:ramCapacity</a>
    /// </summary>
    let ramCapacity = _prefixId.prefix "ramCapacity"
    /// <summary>
    ///   <para>rdfs:label : real time capable^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#realTimeCapable">aeros:realTimeCapable</a>
    /// </summary>
    let realTimeCapable = _prefixId.prefix "realTimeCapable"
    /// <summary>
    ///   <para>rdfs:label : required cpu usage^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#requiredCpuUsage">aeros:requiredCpuUsage</a>
    /// </summary>
    let requiredCpuUsage = _prefixId.prefix "requiredCpuUsage"
    /// <summary>
    ///   <para>rdfs:label : required ram^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#requiredRam">aeros:requiredRam</a>
    /// </summary>
    let requiredRam = _prefixId.prefix "requiredRam"
    /// <summary>
    ///   <para>rdfs:label : service component status^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#serviceComponentStatus">aeros:serviceComponentStatus</a>
    /// </summary>
    let serviceComponentStatus = _prefixId.prefix "serviceComponentStatus"
    /// <summary>
    ///   <para>rdfs:label : service type^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#serviceType">aeros:serviceType</a>
    /// </summary>
    let serviceType = _prefixId.prefix "serviceType"
    /// <summary>
    ///   <para>rdfs:label : sla^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#sla">aeros:sla</a>
    /// </summary>
    let sla = _prefixId.prefix "sla"
    /// <summary>
    ///   <para>rdfs:label : username^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#username">aeros:username</a>
    /// </summary>
    let username = _prefixId.prefix "username"
    /// <summary>
    ///   <para>rdfs:label : web page^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#webPage">aeros:webPage</a>
    /// </summary>
    let webPage = _prefixId.prefix "webPage"
    /// <summary>
    ///   <para>rdfs:label : within area^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/continuum#withinArea">aeros:withinArea</a>
    /// </summary>
    let withinArea = _prefixId.prefix "withinArea"
    let x64Architecture = _prefixId.prefix "x64Architecture"
