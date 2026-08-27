namespace https.w3id.org.aerOS.continuum.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module aoscon =
    let _namespace_iri = Namespace_Iri aoscon |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:aerOS/continuum#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"aerOS Continuum Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#">https://w3id.org/aerOS/continuum#</seealso>
    let _prefix_iri = Prefixed_Name(aoscon, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#CloudTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementTier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#CloudTier">https://w3id.org/aerOS/continuum#CloudTier</seealso>
    let CloudTier = Prefixed_Name(aoscon, "CloudTier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#ContainerdOrchestration</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#OrchestrationType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ContainerdOrchestration">https://w3id.org/aerOS/continuum#ContainerdOrchestration</seealso>
    let ContainerdOrchestration =
        Prefixed_Name(aoscon, "ContainerdOrchestration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#CpuArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cpu Architecture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#CpuArchitecture">https://w3id.org/aerOS/continuum#CpuArchitecture</seealso>
    let CpuArchitecture = Prefixed_Name(aoscon, "CpuArchitecture") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#DockerOrchestration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#OrchestrationType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#DockerOrchestration">https://w3id.org/aerOS/continuum#DockerOrchestration</seealso>
    let DockerOrchestration =
        Prefixed_Name(aoscon, "DockerOrchestration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of one or more IEs, functionally connected and sharing a common instance of aerOS basic services among them, constituting an administrative domain able to be managed and orchestrated by aerOS Meta-OS and thus be part of the IoT-Edge-Cloud continuum."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#Domain">https://w3id.org/aerOS/continuum#Domain</seealso>
    let Domain = Prefixed_Name(aoscon, "Domain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#DomainStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the status of a domain. Possible types are Preliminar, Functional, Removed.Represents the status of a domain. Possible types are Preliminar, Functional, Removed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Domain Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#DomainStatus">https://w3id.org/aerOS/continuum#DomainStatus</seealso>
    let DomainStatus = Prefixed_Name(aoscon, "DomainStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#EdgeTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementTier</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#EdgeTier">https://w3id.org/aerOS/continuum#EdgeTier</seealso>
    let EdgeTier = Prefixed_Name(aoscon, "EdgeTier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#FailedServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#FailedServiceComponent">https://w3id.org/aerOS/continuum#FailedServiceComponent</seealso>
    let FailedServiceComponent =
        Prefixed_Name(aoscon, "FailedServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#FarEdgeTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementTier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#FarEdgeTier">https://w3id.org/aerOS/continuum#FarEdgeTier</seealso>
    let FarEdgeTier = Prefixed_Name(aoscon, "FarEdgeTier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#FinishedServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#FinishedServiceComponent">https://w3id.org/aerOS/continuum#FinishedServiceComponent</seealso>
    let FinishedServiceComponent =
        Prefixed_Name(aoscon, "FinishedServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#FunctionalDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#DomainStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#FunctionalDomain">https://w3id.org/aerOS/continuum#FunctionalDomain</seealso>
    let FunctionalDomain = Prefixed_Name(aoscon, "FunctionalDomain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#InfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""The fundamental building block within aerOS Meta-OS. A physical or virtual computing resource providing the necessary processing power, storage capacity, and network connectivity to support containerised workloads and services.
    ///
    /// Exposes aerOS runtime on top of provided capabilities being thus the minimum execution unit within the IoT-Edge-Cloud continuum.""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Infrastructure Element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#InfrastructureElement">https://w3id.org/aerOS/continuum#InfrastructureElement</seealso>
    let InfrastructureElement =
        Prefixed_Name(aoscon, "InfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the IE requirements for running a service component."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Infrastructure Element Requirements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#InfrastructureElementRequirements">https://w3id.org/aerOS/continuum#InfrastructureElementRequirements</seealso>
    let InfrastructureElementRequirements =
        Prefixed_Name(aoscon, "InfrastructureElementRequirements") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the status of an IE. Possible types are READY, OVERLOAD, UNSECURE, UNTRUSTED."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Infrastructure Element Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#InfrastructureElementStatus">https://w3id.org/aerOS/continuum#InfrastructureElementStatus</seealso>
    let InfrastructureElementStatus =
        Prefixed_Name(aoscon, "InfrastructureElementStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the computing continuum tier (cloud, edge, ...) of an IE."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Infrastructure Element Tier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#InfrastructureElementTier">https://w3id.org/aerOS/continuum#InfrastructureElementTier</seealso>
    let InfrastructureElementTier =
        Prefixed_Name(aoscon, "InfrastructureElementTier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#IotTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementTier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#IotTier">https://w3id.org/aerOS/continuum#IotTier</seealso>
    let IotTier = Prefixed_Name(aoscon, "IotTier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#KubernetesOrchestration</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#OrchestrationType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#KubernetesOrchestration">https://w3id.org/aerOS/continuum#KubernetesOrchestration</seealso>
    let KubernetesOrchestration =
        Prefixed_Name(aoscon, "KubernetesOrchestration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#Linux</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#OperatingSystem</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#Linux">https://w3id.org/aerOS/continuum#Linux</seealso>
    let Linux = Prefixed_Name(aoscon, "Linux") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#LocatingServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#LocatingServiceComponent">https://w3id.org/aerOS/continuum#LocatingServiceComponent</seealso>
    let LocatingServiceComponent =
        Prefixed_Name(aoscon, "LocatingServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#LowLevelOrchestrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This element interprets the Decision Blueprint coming from the HLO and oversees the actual deployment of workloads in the selected IE(s). Being aware of the underlying container management frameworks, is able to convert the allocation order into proper deployment. Several LLOs may live in the same domain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Low Level Orchestrator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#LowLevelOrchestrator">https://w3id.org/aerOS/continuum#LowLevelOrchestrator</seealso>
    let LowLevelOrchestrator =
        Prefixed_Name(aoscon, "LowLevelOrchestrator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#MigratingServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#MigratingServiceComponent">https://w3id.org/aerOS/continuum#MigratingServiceComponent</seealso>
    let MigratingServiceComponent =
        Prefixed_Name(aoscon, "MigratingServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#NetworkPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Network Port"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#NetworkPort">https://w3id.org/aerOS/continuum#NetworkPort</seealso>
    let NetworkPort = Prefixed_Name(aoscon, "NetworkPort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#OpenstackOrchestration</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#OrchestrationType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#OpenstackOrchestration">https://w3id.org/aerOS/continuum#OpenstackOrchestration</seealso>
    let OpenstackOrchestration =
        Prefixed_Name(aoscon, "OpenstackOrchestration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#OperatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Operating System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#OperatingSystem">https://w3id.org/aerOS/continuum#OperatingSystem</seealso>
    let OperatingSystem = Prefixed_Name(aoscon, "OperatingSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#OrchestrationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Container orchestration technology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Orchestration Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#OrchestrationType">https://w3id.org/aerOS/continuum#OrchestrationType</seealso>
    let OrchestrationType = Prefixed_Name(aoscon, "OrchestrationType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#OverloadInfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#OverloadInfrastructureElement">https://w3id.org/aerOS/continuum#OverloadInfrastructureElement</seealso>
    let OverloadInfrastructureElement =
        Prefixed_Name(aoscon, "OverloadInfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#OverloadServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#OverloadServiceComponent">https://w3id.org/aerOS/continuum#OverloadServiceComponent</seealso>
    let OverloadServiceComponent =
        Prefixed_Name(aoscon, "OverloadServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#PreliminarDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#DomainStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#PreliminarDomain">https://w3id.org/aerOS/continuum#PreliminarDomain</seealso>
    let PreliminarDomain = Prefixed_Name(aoscon, "PreliminarDomain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#ReadyInfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ReadyInfrastructureElement">https://w3id.org/aerOS/continuum#ReadyInfrastructureElement</seealso>
    let ReadyInfrastructureElement =
        Prefixed_Name(aoscon, "ReadyInfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#RemovedDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#DomainStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#RemovedDomain">https://w3id.org/aerOS/continuum#RemovedDomain</seealso>
    let RemovedDomain = Prefixed_Name(aoscon, "RemovedDomain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#RemovingServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#RemovingServiceComponent">https://w3id.org/aerOS/continuum#RemovingServiceComponent</seealso>
    let RemovingServiceComponent =
        Prefixed_Name(aoscon, "RemovingServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#RunningServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#RunningServiceComponent">https://w3id.org/aerOS/continuum#RunningServiceComponent</seealso>
    let RunningServiceComponent =
        Prefixed_Name(aoscon, "RunningServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a single instance of an IoT service with a unique identifier. A service is composed by one or some ServiceComponents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#Service">https://w3id.org/aerOS/continuum#Service</seealso>
    let Service = Prefixed_Name(aoscon, "Service") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#ServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Individual, deployable units that together constitute a Service in the aerOS ecosystem, each with a specific role or function."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ServiceComponent">https://w3id.org/aerOS/continuum#ServiceComponent</seealso>
    let ServiceComponent = Prefixed_Name(aoscon, "ServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Service Component Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ServiceComponentStatus">https://w3id.org/aerOS/continuum#ServiceComponentStatus</seealso>
    let ServiceComponentStatus =
        Prefixed_Name(aoscon, "ServiceComponentStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#ServiceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Identifies the services such as a "catalogue"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ServiceType">https://w3id.org/aerOS/continuum#ServiceType</seealso>
    let ServiceType = Prefixed_Name(aoscon, "ServiceType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#StartingServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#ServiceComponentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#StartingServiceComponent">https://w3id.org/aerOS/continuum#StartingServiceComponent</seealso>
    let StartingServiceComponent =
        Prefixed_Name(aoscon, "StartingServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#UnsecureInfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#UnsecureInfrastructureElement">https://w3id.org/aerOS/continuum#UnsecureInfrastructureElement</seealso>
    let UnsecureInfrastructureElement =
        Prefixed_Name(aoscon, "UnsecureInfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#UntrustedInfrastructureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#InfrastructureElementStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#UntrustedInfrastructureElement">https://w3id.org/aerOS/continuum#UntrustedInfrastructureElement</seealso>
    let UntrustedInfrastructureElement =
        Prefixed_Name(aoscon, "UntrustedInfrastructureElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Person with access to the capabilities of the continuum."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#User">https://w3id.org/aerOS/continuum#User</seealso>
    let User = Prefixed_Name(aoscon, "User") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#Windows</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#OperatingSystem</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#Windows">https://w3id.org/aerOS/continuum#Windows</seealso>
    let Windows = Prefixed_Name(aoscon, "Windows") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#arm32Architecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#CpuArchitecture</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#arm32Architecture">https://w3id.org/aerOS/continuum#arm32Architecture</seealso>
    let arm32Architecture = Prefixed_Name(aoscon, "arm32Architecture") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#arm64Architecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/continuum#CpuArchitecture</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#arm64Architecture">https://w3id.org/aerOS/continuum#arm64Architecture</seealso>
    let arm64Architecture = Prefixed_Name(aoscon, "arm64Architecture") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#availableRam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"available ram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#availableRam">https://w3id.org/aerOS/continuum#availableRam</seealso>
    let availableRam = Prefixed_Name(aoscon, "availableRam") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#averagePowerConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"average power consumption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#averagePowerConsumption">https://w3id.org/aerOS/continuum#averagePowerConsumption</seealso>
    let averagePowerConsumption =
        Prefixed_Name(aoscon, "averagePowerConsumption") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"belongs to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#belongsTo">https://w3id.org/aerOS/continuum#belongsTo</seealso>
    let belongsTo = Prefixed_Name(aoscon, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#cliArgs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"cli args"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#cliArgs">https://w3id.org/aerOS/continuum#cliArgs</seealso>
    let cliArgs = Prefixed_Name(aoscon, "cliArgs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#containerImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"container image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#containerImage">https://w3id.org/aerOS/continuum#containerImage</seealso>
    let containerImage = Prefixed_Name(aoscon, "containerImage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#cpuArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"cpu architecture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#cpuArchitecture">https://w3id.org/aerOS/continuum#cpuArchitecture</seealso>
    let cpuArchitecture = Prefixed_Name(aoscon, "cpuArchitecture") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#cpuCores</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"cpu cores"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#cpuCores">https://w3id.org/aerOS/continuum#cpuCores</seealso>
    let cpuCores = Prefixed_Name(aoscon, "cpuCores") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#currentCpuUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"current cpu usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#currentCpuUsage">https://w3id.org/aerOS/continuum#currentCpuUsage</seealso>
    let currentCpuUsage = Prefixed_Name(aoscon, "currentCpuUsage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#currentPowerConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"current power consumption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#currentPowerConsumption">https://w3id.org/aerOS/continuum#currentPowerConsumption</seealso>
    let currentPowerConsumption =
        Prefixed_Name(aoscon, "currentPowerConsumption") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#currentRamUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"current ram usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#currentRamUsage">https://w3id.org/aerOS/continuum#currentRamUsage</seealso>
    let currentRamUsage = Prefixed_Name(aoscon, "currentRamUsage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#deployedOnServiceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"deployed on service component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#deployedOnServiceComponent">https://w3id.org/aerOS/continuum#deployedOnServiceComponent</seealso>
    let deployedOnServiceComponent =
        Prefixed_Name(aoscon, "deployedOnServiceComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#domain">https://w3id.org/aerOS/continuum#domain</seealso>
    let domain = Prefixed_Name(aoscon, "domain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#domainStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"domain status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#domainStatus">https://w3id.org/aerOS/continuum#domainStatus</seealso>
    let domainStatus = Prefixed_Name(aoscon, "domainStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#envVars</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"env vars"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#envVars">https://w3id.org/aerOS/continuum#envVars</seealso>
    let envVars = Prefixed_Name(aoscon, "envVars") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#exposesNetworkPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"exposes network port"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#exposesNetworkPort">https://w3id.org/aerOS/continuum#exposesNetworkPort</seealso>
    let exposesNetworkPort = Prefixed_Name(aoscon, "exposesNetworkPort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#infrastructureElementRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"infrastructure element requirements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#infrastructureElementRequirements">https://w3id.org/aerOS/continuum#infrastructureElementRequirements</seealso>
    let infrastructureElementRequirements =
        Prefixed_Name(aoscon, "infrastructureElementRequirements") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#infrastructureElementStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"infrastructure element status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#infrastructureElementStatus">https://w3id.org/aerOS/continuum#infrastructureElementStatus</seealso>
    let infrastructureElementStatus =
        Prefixed_Name(aoscon, "infrastructureElementStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#infrastructureElementTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"infrastructure element tier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#infrastructureElementTier">https://w3id.org/aerOS/continuum#infrastructureElementTier</seealso>
    let infrastructureElementTier =
        Prefixed_Name(aoscon, "infrastructureElementTier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#internalIpAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"internal ip address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#internalIpAddress">https://w3id.org/aerOS/continuum#internalIpAddress</seealso>
    let internalIpAddress = Prefixed_Name(aoscon, "internalIpAddress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#isEntrypoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is entrypoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#isEntrypoint">https://w3id.org/aerOS/continuum#isEntrypoint</seealso>
    let isEntrypoint = Prefixed_Name(aoscon, "isEntrypoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#isPartOfService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is part of service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#isPartOfService">https://w3id.org/aerOS/continuum#isPartOfService</seealso>
    let isPartOfService = Prefixed_Name(aoscon, "isPartOfService") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#location">https://w3id.org/aerOS/continuum#location</seealso>
    let location = Prefixed_Name(aoscon, "location") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#macAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"mac address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#macAddress">https://w3id.org/aerOS/continuum#macAddress</seealso>
    let macAddress = Prefixed_Name(aoscon, "macAddress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#operatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"operating system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#operatingSystem">https://w3id.org/aerOS/continuum#operatingSystem</seealso>
    let operatingSystem = Prefixed_Name(aoscon, "operatingSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#orchestrationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"orchestration type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#orchestrationType">https://w3id.org/aerOS/continuum#orchestrationType</seealso>
    let orchestrationType = Prefixed_Name(aoscon, "orchestrationType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#owner">https://w3id.org/aerOS/continuum#owner</seealso>
    let owner = Prefixed_Name(aoscon, "owner") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#portNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"port number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#portNumber">https://w3id.org/aerOS/continuum#portNumber</seealso>
    let portNumber = Prefixed_Name(aoscon, "portNumber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#publicUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"public url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#publicUrl">https://w3id.org/aerOS/continuum#publicUrl</seealso>
    let publicUrl = Prefixed_Name(aoscon, "publicUrl") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#ramCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ram capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#ramCapacity">https://w3id.org/aerOS/continuum#ramCapacity</seealso>
    let ramCapacity = Prefixed_Name(aoscon, "ramCapacity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#realTimeCapable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"real time capable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#realTimeCapable">https://w3id.org/aerOS/continuum#realTimeCapable</seealso>
    let realTimeCapable = Prefixed_Name(aoscon, "realTimeCapable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#requiredCpuUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"required cpu usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#requiredCpuUsage">https://w3id.org/aerOS/continuum#requiredCpuUsage</seealso>
    let requiredCpuUsage = Prefixed_Name(aoscon, "requiredCpuUsage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#requiredRam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"required ram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#requiredRam">https://w3id.org/aerOS/continuum#requiredRam</seealso>
    let requiredRam = Prefixed_Name(aoscon, "requiredRam") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#serviceComponentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"service component status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#serviceComponentStatus">https://w3id.org/aerOS/continuum#serviceComponentStatus</seealso>
    let serviceComponentStatus =
        Prefixed_Name(aoscon, "serviceComponentStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/continuum#serviceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"service type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#serviceType">https://w3id.org/aerOS/continuum#serviceType</seealso>
    let serviceType = Prefixed_Name(aoscon, "serviceType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#sla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"sla"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#sla">https://w3id.org/aerOS/continuum#sla</seealso>
    let sla = Prefixed_Name(aoscon, "sla") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#username</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"username"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#username">https://w3id.org/aerOS/continuum#username</seealso>
    let username = Prefixed_Name(aoscon, "username") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#webPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"web page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#webPage">https://w3id.org/aerOS/continuum#webPage</seealso>
    let webPage = Prefixed_Name(aoscon, "webPage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#withinArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"within area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#withinArea">https://w3id.org/aerOS/continuum#withinArea</seealso>
    let withinArea = Prefixed_Name(aoscon, "withinArea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/continuum#x64Architecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/continuum#CpuArchitecture</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/aerOS/continuum#x64Architecture">https://w3id.org/aerOS/continuum#x64Architecture</seealso>
    let x64Architecture = Prefixed_Name(aoscon, "x64Architecture") |> PrefixedName
