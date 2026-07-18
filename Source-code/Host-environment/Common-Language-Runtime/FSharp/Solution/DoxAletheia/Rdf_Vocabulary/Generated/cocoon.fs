namespace https.w3id.org.cocoon.v1._0.hash

open DoxAletheia.Rdf_Vocabulary

module cocoon =
    let _namespace_name = "https://w3id.org/cocoon/v1.0#"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Network"></see>
    /// </summary>
    let Network = Namespaced_IRI.parse _namespace_name "Network" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Storage"></see>
    /// </summary>
    let Storage = Namespaced_IRI.parse _namespace_name "Storage" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#VM"></see>
    /// </summary>
    let VM = Namespaced_IRI.parse _namespace_name "VM" |> NamespacedName

    /// <summary>
    /// Can be used to define a common price spec for multiple cloud service individuals,
    /// i.e. the storage transaction spec has a different price in a different region,
    /// but there is a common transaction price spec for a group of cloud storage offers.
    /// <see href="https://w3id.org/cocoon/v1.0#StorageTransactionsPriceSpecification"></see></summary>
    let StorageTransactionsPriceSpecification =
        Namespaced_IRI.parse _namespace_name "StorageTransactionsPriceSpecification" |> NamespacedName

    /// <summary>
    /// Composition of value, unit, and type of object, i.e., 2 GB of Memory, 10 GB of local storage, 3 TB of network storage.
    /// <see href="https://w3id.org/cocoon/v1.0#QuantityOfThings"></see></summary>
    let QuantityOfThings =
        Namespaced_IRI.parse _namespace_name "QuantityOfThings" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasMaxNumberOfDisk"></see>
    /// </summary>
    let hasMaxNumberOfDisk =
        Namespaced_IRI.parse _namespace_name "hasMaxNumberOfDisk" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#ofObjectType"></see>
    /// </summary>
    let ofObjectType =
        Namespaced_IRI.parse _namespace_name "ofObjectType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#NetworkPriceSpecification"></see>
    /// </summary>
    let NetworkPriceSpecification =
        Namespaced_IRI.parse _namespace_name "NetworkPriceSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#OSPriceSpecification"></see>
    /// </summary>
    let OSPriceSpecification =
        Namespaced_IRI.parse _namespace_name "OSPriceSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Region"></see>
    /// </summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasRegion"></see>
    /// </summary>
    let hasRegion = Namespaced_IRI.parse _namespace_name "hasRegion" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasStorage"></see>
    /// </summary>
    let hasStorage = Namespaced_IRI.parse _namespace_name "hasStorage" |> NamespacedName
    /// <summary>
    /// Software as a Service
    /// <see href="https://w3id.org/cocoon/v1.0#SaaS"></see></summary>
    let SaaS = Namespaced_IRI.parse _namespace_name "SaaS" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasMaxStorageSize"></see>
    /// </summary>
    let hasMaxStorageSize =
        Namespaced_IRI.parse _namespace_name "hasMaxStorageSize" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#inJurisdiction"></see>
    /// </summary>
    let inJurisdiction =
        Namespaced_IRI.parse _namespace_name "inJurisdiction" |> NamespacedName

    /// <summary>
    /// Google Cloud OS price for VM with different number of cores are different.
    /// It is used to describe price for machines with less than or
    /// equal to the specified number of cores.
    /// <see href="https://w3id.org/cocoon/v1.0#forCoresLessEqual"></see></summary>
    let forCoresLessEqual =
        Namespaced_IRI.parse _namespace_name "forCoresLessEqual" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#specialRateType"></see>
    /// </summary>
    let specialRateType =
        Namespaced_IRI.parse _namespace_name "specialRateType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasStorageThroughputMax"></see>
    /// </summary>
    let hasStorageThroughputMax =
        Namespaced_IRI.parse _namespace_name "hasStorageThroughputMax" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Internet"></see>
    /// </summary>
    let Internet = Namespaced_IRI.parse _namespace_name "Internet" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#LoadBalancing"></see>
    /// </summary>
    let LoadBalancing =
        Namespaced_IRI.parse _namespace_name "LoadBalancing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#StaticIP"></see>
    /// </summary>
    let StaticIP = Namespaced_IRI.parse _namespace_name "StaticIP" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasMemory"></see>
    /// </summary>
    let hasMemory = Namespaced_IRI.parse _namespace_name "hasMemory" |> NamespacedName

    /// <summary>
    /// Google Cloud OS price for VM with different number of cores are different.
    /// This is used to describe the price for machines with more than specified
    /// number of cores.
    /// <see href="https://w3id.org/cocoon/v1.0#forCoresMoreThan"></see></summary>
    let forCoresMoreThan =
        Namespaced_IRI.parse _namespace_name "forCoresMoreThan" |> NamespacedName

    /// <summary>
    /// The power or capacity of CPU available for this type of VM.
    /// <see href="https://w3id.org/cocoon/v1.0#hasCPUcapacity"></see></summary>
    let hasCPUcapacity =
        Namespaced_IRI.parse _namespace_name "hasCPUcapacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasStorageIOMax"></see>
    /// </summary>
    let hasStorageIOMax =
        Namespaced_IRI.parse _namespace_name "hasStorageIOMax" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#inPhysicalLocation"></see>
    /// </summary>
    let inPhysicalLocation =
        Namespaced_IRI.parse _namespace_name "inPhysicalLocation" |> NamespacedName

    /// <summary>
    /// For Google Cloud, cores and vCPU referes to the same thing.
    /// <see href="https://w3id.org/cocoon/v1.0#numberOfCores"></see></summary>
    let numberOfCores =
        Namespaced_IRI.parse _namespace_name "numberOfCores" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#canHaveSnapshot"></see>
    /// </summary>
    let canHaveSnapshot =
        Namespaced_IRI.parse _namespace_name "canHaveSnapshot" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasCurrencyValue"></see>
    /// </summary>
    let hasCurrencyValue =
        Namespaced_IRI.parse _namespace_name "hasCurrencyValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#CloudService"></see>
    /// </summary>
    let CloudService =
        Namespaced_IRI.parse _namespace_name "CloudService" |> NamespacedName

    /// <summary>
    /// For Google Cloud, cost of SQL server image is charged on per core basis.
    /// <see href="https://w3id.org/cocoon/v1.0#chargedPerCore"></see></summary>
    let chargedPerCore =
        Namespaced_IRI.parse _namespace_name "chargedPerCore" |> NamespacedName

    /// <summary>
    /// Defines custome units.
    /// <see href="https://w3id.org/cocoon/v1.0#UnitOfMeasure"></see></summary>
    let UnitOfMeasure =
        Namespaced_IRI.parse _namespace_name "UnitOfMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#mirandazhangqian"></see>
    /// </summary>
    let mirandazhangqian =
        Namespaced_IRI.parse _namespace_name "mirandazhangqian" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#10TB"></see>
    /// </summary>
    let _10TB = Namespaced_IRI.parse _namespace_name "10TB" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasUnitOfMeasurement"></see>
    /// </summary>
    let hasUnitOfMeasurement =
        Namespaced_IRI.parse _namespace_name "hasUnitOfMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#GB"></see>
    /// </summary>
    let GB = Namespaced_IRI.parse _namespace_name "GB" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#numericValue"></see>
    /// </summary>
    let numericValue =
        Namespaced_IRI.parse _namespace_name "numericValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#1TB"></see>
    /// </summary>
    let _1TB = Namespaced_IRI.parse _namespace_name "1TB" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#90TB"></see>
    /// </summary>
    let _90TB = Namespaced_IRI.parse _namespace_name "90TB" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasProvider"></see>
    /// </summary>
    let hasProvider =
        Namespaced_IRI.parse _namespace_name "hasProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Service"></see>
    /// </summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Database"></see>
    /// </summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Egress"></see>
    /// </summary>
    let Egress = Namespaced_IRI.parse _namespace_name "Egress" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#TrafficDirection"></see>
    /// </summary>
    let TrafficDirection =
        Namespaced_IRI.parse _namespace_name "TrafficDirection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Ingress"></see>
    /// </summary>
    let Ingress = Namespaced_IRI.parse _namespace_name "Ingress" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#ForwardingRule"></see>
    /// </summary>
    let ForwardingRule =
        Namespaced_IRI.parse _namespace_name "ForwardingRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#GBPerMonth"></see>
    /// </summary>
    let GBPerMonth = Namespaced_IRI.parse _namespace_name "GBPerMonth" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#IOPs"></see>
    /// </summary>
    let IOPs = Namespaced_IRI.parse _namespace_name "IOPs" |> NamespacedName
    /// <summary>
    /// Infrastructure as a Service
    /// <see href="https://w3id.org/cocoon/v1.0#IaaS"></see></summary>
    let IaaS = Namespaced_IRI.parse _namespace_name "IaaS" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasDirection"></see>
    /// </summary>
    let hasDirection =
        Namespaced_IRI.parse _namespace_name "hasDirection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Location"></see>
    /// </summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasDestination"></see>
    /// </summary>
    let hasDestination =
        Namespaced_IRI.parse _namespace_name "hasDestination" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#excludesDestination"></see>
    /// </summary>
    let excludesDestination =
        Namespaced_IRI.parse _namespace_name "excludesDestination" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#LBData"></see>
    /// </summary>
    let LBData = Namespaced_IRI.parse _namespace_name "LBData" |> NamespacedName

    /// <summary>
    /// Storage that is not detachable from VM
    /// <see href="https://w3id.org/cocoon/v1.0#LocalStorage"></see></summary>
    let LocalStorage =
        Namespaced_IRI.parse _namespace_name "LocalStorage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#MBPerSec"></see>
    /// </summary>
    let MBPerSec = Namespaced_IRI.parse _namespace_name "MBPerSec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#forUsageMoreThan"></see>
    /// </summary>
    let forUsageMoreThan =
        Namespaced_IRI.parse _namespace_name "forUsageMoreThan" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#forUsageLessEqual"></see>
    /// </summary>
    let forUsageLessEqual =
        Namespaced_IRI.parse _namespace_name "forUsageLessEqual" |> NamespacedName

    /// <summary>
    /// Storage can exist independent from VM
    /// <see href="https://w3id.org/cocoon/v1.0#NetworkStorage"></see></summary>
    let NetworkStorage =
        Namespaced_IRI.parse _namespace_name "NetworkStorage" |> NamespacedName

    /// <summary>
    /// Platform as a Service, i.e. Google App Engine, Heroku.
    /// <see href="https://w3id.org/cocoon/v1.0#PaaS"></see></summary>
    let PaaS = Namespaced_IRI.parse _namespace_name "PaaS" |> NamespacedName
    /// <summary>
    /// Similar to location, this property specifies the continent.
    /// <see href="https://w3id.org/cocoon/v1.0#continent"></see></summary>
    let continent = Namespaced_IRI.parse _namespace_name "continent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#ServiceLevelAgreement"></see>
    /// </summary>
    let ServiceLevelAgreement =
        Namespaced_IRI.parse _namespace_name "ServiceLevelAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasServiceLevelAgreement"></see>
    /// </summary>
    let hasServiceLevelAgreement =
        Namespaced_IRI.parse _namespace_name "hasServiceLevelAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#inUse"></see>
    /// </summary>
    let inUse = Namespaced_IRI.parse _namespace_name "inUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasStorageSize"></see>
    /// </summary>
    let hasStorageSize =
        Namespaced_IRI.parse _namespace_name "hasStorageSize" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#SystemImage"></see>
    /// </summary>
    let SystemImage =
        Namespaced_IRI.parse _namespace_name "SystemImage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#TB"></see>
    /// </summary>
    let TB = Namespaced_IRI.parse _namespace_name "TB" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Zone"></see>
    /// </summary>
    let Zone = Namespaced_IRI.parse _namespace_name "Zone" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#azure"></see>
    /// </summary>
    let azure = Namespaced_IRI.parse _namespace_name "azure" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#gceu"></see>
    /// </summary>
    let gceu = Namespaced_IRI.parse _namespace_name "gceu" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#gcloud"></see>
    /// </summary>
    let gcloud = Namespaced_IRI.parse _namespace_name "gcloud" |> NamespacedName
