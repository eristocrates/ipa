namespace https.w3id.org.cocoon.v1._0.hash

open DoxAletheia

module cocoon =
    let _namespace_name = "https://w3id.org/cocoon/v1.0#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Network"></see>
    /// </summary>
    let Network = _prefix "Network"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Storage"></see>
    /// </summary>
    let Storage = _prefix "Storage"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#VM"></see>
    /// </summary>
    let VM = _prefix "VM"

    /// <summary>
    /// Can be used to define a common price spec for multiple cloud service individuals,
    /// i.e. the storage transaction spec has a different price in a different region,
    /// but there is a common transaction price spec for a group of cloud storage offers.
    /// <see href="https://w3id.org/cocoon/v1.0#StorageTransactionsPriceSpecification"></see></summary>
    let StorageTransactionsPriceSpecification =
        _prefix "StorageTransactionsPriceSpecification"

    /// <summary>
    /// Composition of value, unit, and type of object, i.e., 2 GB of Memory, 10 GB of local storage, 3 TB of network storage.
    /// <see href="https://w3id.org/cocoon/v1.0#QuantityOfThings"></see></summary>
    let QuantityOfThings = _prefix "QuantityOfThings"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasMaxNumberOfDisk"></see>
    /// </summary>
    let hasMaxNumberOfDisk = _prefix "hasMaxNumberOfDisk"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#ofObjectType"></see>
    /// </summary>
    let ofObjectType = _prefix "ofObjectType"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#NetworkPriceSpecification"></see>
    /// </summary>
    let NetworkPriceSpecification = _prefix "NetworkPriceSpecification"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#OSPriceSpecification"></see>
    /// </summary>
    let OSPriceSpecification = _prefix "OSPriceSpecification"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Region"></see>
    /// </summary>
    let Region = _prefix "Region"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasRegion"></see>
    /// </summary>
    let hasRegion = _prefix "hasRegion"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasStorage"></see>
    /// </summary>
    let hasStorage = _prefix "hasStorage"
    /// <summary>
    /// Software as a Service
    /// <see href="https://w3id.org/cocoon/v1.0#SaaS"></see></summary>
    let SaaS = _prefix "SaaS"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasMaxStorageSize"></see>
    /// </summary>
    let hasMaxStorageSize = _prefix "hasMaxStorageSize"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#inJurisdiction"></see>
    /// </summary>
    let inJurisdiction = _prefix "inJurisdiction"
    /// <summary>
    /// Google Cloud OS price for VM with different number of cores are different.
    /// It is used to describe price for machines with less than or
    /// equal to the specified number of cores.
    /// <see href="https://w3id.org/cocoon/v1.0#forCoresLessEqual"></see></summary>
    let forCoresLessEqual = _prefix "forCoresLessEqual"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#specialRateType"></see>
    /// </summary>
    let specialRateType = _prefix "specialRateType"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasStorageThroughputMax"></see>
    /// </summary>
    let hasStorageThroughputMax = _prefix "hasStorageThroughputMax"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Internet"></see>
    /// </summary>
    let Internet = _prefix "Internet"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#LoadBalancing"></see>
    /// </summary>
    let LoadBalancing = _prefix "LoadBalancing"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#StaticIP"></see>
    /// </summary>
    let StaticIP = _prefix "StaticIP"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasMemory"></see>
    /// </summary>
    let hasMemory = _prefix "hasMemory"
    /// <summary>
    /// Google Cloud OS price for VM with different number of cores are different.
    /// This is used to describe the price for machines with more than specified
    /// number of cores.
    /// <see href="https://w3id.org/cocoon/v1.0#forCoresMoreThan"></see></summary>
    let forCoresMoreThan = _prefix "forCoresMoreThan"
    /// <summary>
    /// The power or capacity of CPU available for this type of VM.
    /// <see href="https://w3id.org/cocoon/v1.0#hasCPUcapacity"></see></summary>
    let hasCPUcapacity = _prefix "hasCPUcapacity"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasStorageIOMax"></see>
    /// </summary>
    let hasStorageIOMax = _prefix "hasStorageIOMax"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#inPhysicalLocation"></see>
    /// </summary>
    let inPhysicalLocation = _prefix "inPhysicalLocation"
    /// <summary>
    /// For Google Cloud, cores and vCPU referes to the same thing.
    /// <see href="https://w3id.org/cocoon/v1.0#numberOfCores"></see></summary>
    let numberOfCores = _prefix "numberOfCores"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#canHaveSnapshot"></see>
    /// </summary>
    let canHaveSnapshot = _prefix "canHaveSnapshot"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasCurrencyValue"></see>
    /// </summary>
    let hasCurrencyValue = _prefix "hasCurrencyValue"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#CloudService"></see>
    /// </summary>
    let CloudService = _prefix "CloudService"
    /// <summary>
    /// For Google Cloud, cost of SQL server image is charged on per core basis.
    /// <see href="https://w3id.org/cocoon/v1.0#chargedPerCore"></see></summary>
    let chargedPerCore = _prefix "chargedPerCore"
    /// <summary>
    /// Defines custome units.
    /// <see href="https://w3id.org/cocoon/v1.0#UnitOfMeasure"></see></summary>
    let UnitOfMeasure = _prefix "UnitOfMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#mirandazhangqian"></see>
    /// </summary>
    let mirandazhangqian = _prefix "mirandazhangqian"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#10TB"></see>
    /// </summary>
    let _10TB = _prefix "10TB"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasUnitOfMeasurement"></see>
    /// </summary>
    let hasUnitOfMeasurement = _prefix "hasUnitOfMeasurement"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#GB"></see>
    /// </summary>
    let GB = _prefix "GB"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#numericValue"></see>
    /// </summary>
    let numericValue = _prefix "numericValue"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#1TB"></see>
    /// </summary>
    let _1TB = _prefix "1TB"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#90TB"></see>
    /// </summary>
    let _90TB = _prefix "90TB"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasProvider"></see>
    /// </summary>
    let hasProvider = _prefix "hasProvider"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Service"></see>
    /// </summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Database"></see>
    /// </summary>
    let Database = _prefix "Database"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Egress"></see>
    /// </summary>
    let Egress = _prefix "Egress"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#TrafficDirection"></see>
    /// </summary>
    let TrafficDirection = _prefix "TrafficDirection"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Ingress"></see>
    /// </summary>
    let Ingress = _prefix "Ingress"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#ForwardingRule"></see>
    /// </summary>
    let ForwardingRule = _prefix "ForwardingRule"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#GBPerMonth"></see>
    /// </summary>
    let GBPerMonth = _prefix "GBPerMonth"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#IOPs"></see>
    /// </summary>
    let IOPs = _prefix "IOPs"
    /// <summary>
    /// Infrastructure as a Service
    /// <see href="https://w3id.org/cocoon/v1.0#IaaS"></see></summary>
    let IaaS = _prefix "IaaS"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasDirection"></see>
    /// </summary>
    let hasDirection = _prefix "hasDirection"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Location"></see>
    /// </summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasDestination"></see>
    /// </summary>
    let hasDestination = _prefix "hasDestination"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#excludesDestination"></see>
    /// </summary>
    let excludesDestination = _prefix "excludesDestination"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#LBData"></see>
    /// </summary>
    let LBData = _prefix "LBData"
    /// <summary>
    /// Storage that is not detachable from VM
    /// <see href="https://w3id.org/cocoon/v1.0#LocalStorage"></see></summary>
    let LocalStorage = _prefix "LocalStorage"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#MBPerSec"></see>
    /// </summary>
    let MBPerSec = _prefix "MBPerSec"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#forUsageMoreThan"></see>
    /// </summary>
    let forUsageMoreThan = _prefix "forUsageMoreThan"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#forUsageLessEqual"></see>
    /// </summary>
    let forUsageLessEqual = _prefix "forUsageLessEqual"
    /// <summary>
    /// Storage can exist independent from VM
    /// <see href="https://w3id.org/cocoon/v1.0#NetworkStorage"></see></summary>
    let NetworkStorage = _prefix "NetworkStorage"
    /// <summary>
    /// Platform as a Service, i.e. Google App Engine, Heroku.
    /// <see href="https://w3id.org/cocoon/v1.0#PaaS"></see></summary>
    let PaaS = _prefix "PaaS"
    /// <summary>
    /// Similar to location, this property specifies the continent.
    /// <see href="https://w3id.org/cocoon/v1.0#continent"></see></summary>
    let continent = _prefix "continent"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#ServiceLevelAgreement"></see>
    /// </summary>
    let ServiceLevelAgreement = _prefix "ServiceLevelAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasServiceLevelAgreement"></see>
    /// </summary>
    let hasServiceLevelAgreement = _prefix "hasServiceLevelAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#inUse"></see>
    /// </summary>
    let inUse = _prefix "inUse"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#hasStorageSize"></see>
    /// </summary>
    let hasStorageSize = _prefix "hasStorageSize"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#SystemImage"></see>
    /// </summary>
    let SystemImage = _prefix "SystemImage"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#TB"></see>
    /// </summary>
    let TB = _prefix "TB"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#Zone"></see>
    /// </summary>
    let Zone = _prefix "Zone"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#azure"></see>
    /// </summary>
    let azure = _prefix "azure"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#gceu"></see>
    /// </summary>
    let gceu = _prefix "gceu"
    /// <summary>
    ///   <see href="https://w3id.org/cocoon/v1.0#gcloud"></see>
    /// </summary>
    let gcloud = _prefix "gcloud"
