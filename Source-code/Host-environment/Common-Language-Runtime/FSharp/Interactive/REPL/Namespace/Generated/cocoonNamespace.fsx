#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cocoon =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/cocoon/v1.0#" "cocoon"
    let _10TB = _prefixId.prefix "10TB"
    let _1TB = _prefixId.prefix "1TB"
    let _90TB = _prefixId.prefix "90TB"
    let CloudService = _prefixId.prefix "CloudService"
    let Database = _prefixId.prefix "Database"
    let Egress = _prefixId.prefix "Egress"
    let ForwardingRule = _prefixId.prefix "ForwardingRule"
    let GB = _prefixId.prefix "GB"
    let GBPerMonth = _prefixId.prefix "GBPerMonth"
    let IOPs = _prefixId.prefix "IOPs"
    /// <summary>
    ///   <para>rdfs:comment : Infrastructure as a Service</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#IaaS">cocoon:IaaS</a>
    /// </summary>
    let IaaS = _prefixId.prefix "IaaS"
    let Ingress = _prefixId.prefix "Ingress"
    let Internet = _prefixId.prefix "Internet"
    let LBData = _prefixId.prefix "LBData"
    let LoadBalancing = _prefixId.prefix "LoadBalancing"
    /// <summary>
    ///   <para>rdfs:comment : Storage that is not detachable from VM</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#LocalStorage">cocoon:LocalStorage</a>
    /// </summary>
    let LocalStorage = _prefixId.prefix "LocalStorage"
    let Location = _prefixId.prefix "Location"
    let MBPerSec = _prefixId.prefix "MBPerSec"
    let Network = _prefixId.prefix "Network"
    let NetworkPriceSpecification = _prefixId.prefix "NetworkPriceSpecification"
    /// <summary>
    ///   <para>rdfs:comment : Storage can exist independent from VM</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#NetworkStorage">cocoon:NetworkStorage</a>
    /// </summary>
    let NetworkStorage = _prefixId.prefix "NetworkStorage"
    let OSPriceSpecification = _prefixId.prefix "OSPriceSpecification"
    /// <summary>
    ///   <para>rdfs:comment : Platform as a Service, i.e. Google App Engine, Heroku.</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#PaaS">cocoon:PaaS</a>
    /// </summary>
    let PaaS = _prefixId.prefix "PaaS"
    /// <summary>
    ///   <para>rdfs:comment : Composition of value, unit, and type of object, i.e., 2 GB of Memory, 10 GB of local storage, 3 TB of network storage.</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#QuantityOfThings">cocoon:QuantityOfThings</a>
    /// </summary>
    let QuantityOfThings = _prefixId.prefix "QuantityOfThings"
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:comment : Software as a Service</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#SaaS">cocoon:SaaS</a>
    /// </summary>
    let SaaS = _prefixId.prefix "SaaS"
    let Service = _prefixId.prefix "Service"
    let ServiceLevelAgreement = _prefixId.prefix "ServiceLevelAgreement"
    let StaticIP = _prefixId.prefix "StaticIP"
    let Storage = _prefixId.prefix "Storage"

    /// <summary>
    ///   <para>rdfs:comment : Can be used to define a common price spec for multiple cloud service individuals,
    /// i.e. the storage transaction spec has a different price in a different region,
    /// but there is a common transaction price spec for a group of cloud storage offers.</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#StorageTransactionsPriceSpecification">cocoon:StorageTransactionsPriceSpecification</a>
    /// </summary>
    let StorageTransactionsPriceSpecification =
        _prefixId.prefix "StorageTransactionsPriceSpecification"

    /// <summary>
    ///   <para>dcterms:description : A system image is a serialized copy of the entire state of a computer system.
    /// System images can be used for backup.^^xsd:string</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#SystemImage">cocoon:SystemImage</a>
    /// </summary>
    let SystemImage = _prefixId.prefix "SystemImage"
    let TB = _prefixId.prefix "TB"
    let TrafficDirection = _prefixId.prefix "TrafficDirection"
    /// <summary>
    ///   <para>rdfs:comment : Defines custome units.</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#UnitOfMeasure">cocoon:UnitOfMeasure</a>
    /// </summary>
    let UnitOfMeasure = _prefixId.prefix "UnitOfMeasure"
    let VM = _prefixId.prefix "VM"
    let Zone = _prefixId.prefix "Zone"
    let azure = _prefixId.prefix "azure"
    let canHaveSnapshot = _prefixId.prefix "canHaveSnapshot"
    /// <summary>
    ///   <para>rdfs:comment : For Google Cloud, cost of SQL server image is charged on per core basis.</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#chargedPerCore">cocoon:chargedPerCore</a>
    /// </summary>
    let chargedPerCore = _prefixId.prefix "chargedPerCore"
    /// <summary>
    ///   <para>rdfs:comment : Similar to location, this property specifies the continent.</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#continent">cocoon:continent</a>
    /// </summary>
    let continent = _prefixId.prefix "continent"
    let excludesDestination = _prefixId.prefix "excludesDestination"
    /// <summary>
    ///   <para>rdfs:comment : Google Cloud OS price for VM with different number of cores are different.
    /// It is used to describe price for machines with less than or
    /// equal to the specified number of cores.</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#forCoresLessEqual">cocoon:forCoresLessEqual</a>
    /// </summary>
    let forCoresLessEqual = _prefixId.prefix "forCoresLessEqual"
    /// <summary>
    ///   <para>rdfs:comment : Google Cloud OS price for VM with different number of cores are different.
    /// This is used to describe the price for machines with more than specified
    /// number of cores.</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#forCoresMoreThan">cocoon:forCoresMoreThan</a>
    /// </summary>
    let forCoresMoreThan = _prefixId.prefix "forCoresMoreThan"
    let forUsageLessEqual = _prefixId.prefix "forUsageLessEqual"
    let forUsageMoreThan = _prefixId.prefix "forUsageMoreThan"
    let gceu = _prefixId.prefix "gceu"
    let gcloud = _prefixId.prefix "gcloud"
    /// <summary>
    ///   <para>rdfs:comment : The power or capacity of CPU available for this type of VM.</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#hasCPUcapacity">cocoon:hasCPUcapacity</a>
    /// </summary>
    let hasCPUcapacity = _prefixId.prefix "hasCPUcapacity"
    let hasCurrencyValue = _prefixId.prefix "hasCurrencyValue"
    let hasDestination = _prefixId.prefix "hasDestination"
    let hasDirection = _prefixId.prefix "hasDirection"
    let hasMaxNumberOfDisk = _prefixId.prefix "hasMaxNumberOfDisk"
    let hasMaxStorageSize = _prefixId.prefix "hasMaxStorageSize"
    let hasMemory = _prefixId.prefix "hasMemory"
    let hasProvider = _prefixId.prefix "hasProvider"
    let hasRegion = _prefixId.prefix "hasRegion"
    let hasServiceLevelAgreement = _prefixId.prefix "hasServiceLevelAgreement"
    let hasStorage = _prefixId.prefix "hasStorage"
    let hasStorageIOMax = _prefixId.prefix "hasStorageIOMax"
    let hasStorageSize = _prefixId.prefix "hasStorageSize"
    let hasStorageThroughputMax = _prefixId.prefix "hasStorageThroughputMax"
    let hasUnitOfMeasurement = _prefixId.prefix "hasUnitOfMeasurement"
    let inJurisdiction = _prefixId.prefix "inJurisdiction"
    let inPhysicalLocation = _prefixId.prefix "inPhysicalLocation"
    let inUse = _prefixId.prefix "inUse"
    let mirandazhangqian = _prefixId.prefix "mirandazhangqian"
    /// <summary>
    ///   <para>rdfs:comment : For Google Cloud, cores and vCPU referes to the same thing.^^xsd:string</para>
    ///   <a href="https://w3id.org/cocoon/v1.0#numberOfCores">cocoon:numberOfCores</a>
    /// </summary>
    let numberOfCores = _prefixId.prefix "numberOfCores"
    let numericValue = _prefixId.prefix "numericValue"
    let ofObjectType = _prefixId.prefix "ofObjectType"
    let specialRateType = _prefixId.prefix "specialRateType"
