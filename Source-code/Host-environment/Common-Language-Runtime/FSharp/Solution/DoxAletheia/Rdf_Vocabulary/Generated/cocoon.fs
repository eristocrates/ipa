namespace https.w3id.org.cocoon.v1._0.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cocoon =
    let _namespace_iri = Namespace_Iri cocoon |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#10TB</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:cocoon/v1.0#QuantityOfThings</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#10TB">https://w3id.org/cocoon/v1.0#10TB</seealso>
    let _10TB = Prefixed_Name(cocoon, "10TB") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#1TB</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:cocoon/v1.0#QuantityOfThings</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#1TB">https://w3id.org/cocoon/v1.0#1TB</seealso>
    let _1TB = Prefixed_Name(cocoon, "1TB") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#90TB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:cocoon/v1.0#QuantityOfThings</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#90TB">https://w3id.org/cocoon/v1.0#90TB</seealso>
    let _90TB = Prefixed_Name(cocoon, "90TB") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#CloudService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#CloudService">https://w3id.org/cocoon/v1.0#CloudService</seealso>
    let CloudService = Prefixed_Name(cocoon, "CloudService") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#Database">https://w3id.org/cocoon/v1.0#Database</seealso>
    let Database = Prefixed_Name(cocoon, "Database") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#Egress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#Egress">https://w3id.org/cocoon/v1.0#Egress</seealso>
    let Egress = Prefixed_Name(cocoon, "Egress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#ForwardingRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#ForwardingRule">https://w3id.org/cocoon/v1.0#ForwardingRule</seealso>
    let ForwardingRule = Prefixed_Name(cocoon, "ForwardingRule") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#GB</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:cocoon/v1.0#UnitOfMeasure</para>
    ///   <para>&lt;http://qudt.org/schema/qudt#InformationEntropyUnit&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://qudt.org/schema/qudt#DerivedUnit&gt;</para>
    ///
    /// labels<para>"Gigabyte"</para></remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#GB">https://w3id.org/cocoon/v1.0#GB</seealso>
    let GB = Prefixed_Name(cocoon, "GB") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#GBPerMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://qudt.org/schema/qudt#DataRateUnit&gt;</para>
    ///   <para>&lt;http://qudt.org/schema/qudt#DerivedUnit&gt;</para>
    ///   <para>w3id:cocoon/v1.0#UnitOfMeasure</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Gigabyte per Month"</para></remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#GBPerMonth">https://w3id.org/cocoon/v1.0#GBPerMonth</seealso>
    let GBPerMonth = Prefixed_Name(cocoon, "GBPerMonth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#IOPs</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:cocoon/v1.0#UnitOfMeasure</para>
    ///   <para>&lt;http://qudt.org/schema/qudt#DerivedUnit&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://qudt.org/schema/qudt#DataRateUnit&gt;</para>
    ///
    /// labels<para>"Input/output operations per sec"</para></remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#IOPs">https://w3id.org/cocoon/v1.0#IOPs</seealso>
    let IOPs = Prefixed_Name(cocoon, "IOPs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#IaaS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Infrastructure as a Service"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#IaaS">https://w3id.org/cocoon/v1.0#IaaS</seealso>
    let IaaS = Prefixed_Name(cocoon, "IaaS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#Ingress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#Ingress">https://w3id.org/cocoon/v1.0#Ingress</seealso>
    let Ingress = Prefixed_Name(cocoon, "Ingress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#Internet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#Internet">https://w3id.org/cocoon/v1.0#Internet</seealso>
    let Internet = Prefixed_Name(cocoon, "Internet") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#LBData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#LBData">https://w3id.org/cocoon/v1.0#LBData</seealso>
    let LBData = Prefixed_Name(cocoon, "LBData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#LoadBalancing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#LoadBalancing">https://w3id.org/cocoon/v1.0#LoadBalancing</seealso>
    let LoadBalancing = Prefixed_Name(cocoon, "LoadBalancing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#LocalStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Storage that is not detachable from VM"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#LocalStorage">https://w3id.org/cocoon/v1.0#LocalStorage</seealso>
    let LocalStorage = Prefixed_Name(cocoon, "LocalStorage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#Location">https://w3id.org/cocoon/v1.0#Location</seealso>
    let Location = Prefixed_Name(cocoon, "Location") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#MBPerSec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:cocoon/v1.0#UnitOfMeasure</para>
    ///   <para>&lt;http://qudt.org/schema/qudt#DataRateUnit&gt;</para>
    ///   <para>&lt;http://qudt.org/schema/qudt#DerivedUnit&gt;</para>
    ///
    /// labels<para>"MB/second"</para></remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#MBPerSec">https://w3id.org/cocoon/v1.0#MBPerSec</seealso>
    let MBPerSec = Prefixed_Name(cocoon, "MBPerSec") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#Network</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#Network">https://w3id.org/cocoon/v1.0#Network</seealso>
    let Network = Prefixed_Name(cocoon, "Network") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#NetworkPriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#NetworkPriceSpecification">https://w3id.org/cocoon/v1.0#NetworkPriceSpecification</seealso>
    let NetworkPriceSpecification =
        Prefixed_Name(cocoon, "NetworkPriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#NetworkStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Storage can exist independent from VM"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#NetworkStorage">https://w3id.org/cocoon/v1.0#NetworkStorage</seealso>
    let NetworkStorage = Prefixed_Name(cocoon, "NetworkStorage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#OSPriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#OSPriceSpecification">https://w3id.org/cocoon/v1.0#OSPriceSpecification</seealso>
    let OSPriceSpecification =
        Prefixed_Name(cocoon, "OSPriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#PaaS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Platform as a Service, i.e. Google App Engine, Heroku."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#PaaS">https://w3id.org/cocoon/v1.0#PaaS</seealso>
    let PaaS = Prefixed_Name(cocoon, "PaaS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#QuantityOfThings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Composition of value, unit, and type of object, i.e., 2 GB of Memory, 10 GB of local storage, 3 TB of network storage."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#QuantityOfThings">https://w3id.org/cocoon/v1.0#QuantityOfThings</seealso>
    let QuantityOfThings = Prefixed_Name(cocoon, "QuantityOfThings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#Region">https://w3id.org/cocoon/v1.0#Region</seealso>
    let Region = Prefixed_Name(cocoon, "Region") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#SaaS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Software as a Service"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#SaaS">https://w3id.org/cocoon/v1.0#SaaS</seealso>
    let SaaS = Prefixed_Name(cocoon, "SaaS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#Service">https://w3id.org/cocoon/v1.0#Service</seealso>
    let Service = Prefixed_Name(cocoon, "Service") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#ServiceLevelAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#ServiceLevelAgreement">https://w3id.org/cocoon/v1.0#ServiceLevelAgreement</seealso>
    let ServiceLevelAgreement =
        Prefixed_Name(cocoon, "ServiceLevelAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#StaticIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#StaticIP">https://w3id.org/cocoon/v1.0#StaticIP</seealso>
    let StaticIP = Prefixed_Name(cocoon, "StaticIP") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#Storage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#Storage">https://w3id.org/cocoon/v1.0#Storage</seealso>
    let Storage = Prefixed_Name(cocoon, "Storage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#StorageTransactionsPriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Can be used to define a common price spec for multiple cloud service individuals,
    /// i.e. the storage transaction spec has a different price in a different region,
    /// but there is a common transaction price spec for a group of cloud storage offers."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#StorageTransactionsPriceSpecification">https://w3id.org/cocoon/v1.0#StorageTransactionsPriceSpecification</seealso>
    let StorageTransactionsPriceSpecification =
        Prefixed_Name(cocoon, "StorageTransactionsPriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#SystemImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#SystemImage">https://w3id.org/cocoon/v1.0#SystemImage</seealso>
    let SystemImage = Prefixed_Name(cocoon, "SystemImage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#TB</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://qudt.org/schema/qudt#InformationEntropyUnit&gt;</para>
    ///   <para>w3id:cocoon/v1.0#UnitOfMeasure</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://qudt.org/schema/qudt#DerivedUnit&gt;</para>
    ///
    /// labels<para>"Terabyte"</para></remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#TB">https://w3id.org/cocoon/v1.0#TB</seealso>
    let TB = Prefixed_Name(cocoon, "TB") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#TrafficDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#TrafficDirection">https://w3id.org/cocoon/v1.0#TrafficDirection</seealso>
    let TrafficDirection = Prefixed_Name(cocoon, "TrafficDirection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#UnitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines custome units."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#UnitOfMeasure">https://w3id.org/cocoon/v1.0#UnitOfMeasure</seealso>
    let UnitOfMeasure = Prefixed_Name(cocoon, "UnitOfMeasure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#VM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#VM">https://w3id.org/cocoon/v1.0#VM</seealso>
    let VM = Prefixed_Name(cocoon, "VM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#Zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#Zone">https://w3id.org/cocoon/v1.0#Zone</seealso>
    let Zone = Prefixed_Name(cocoon, "Zone") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#azure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gr:BusinessEntity</para>
    ///
    /// labels<para>"Azure"</para></remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#azure">https://w3id.org/cocoon/v1.0#azure</seealso>
    let azure = Prefixed_Name(cocoon, "azure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#canHaveSnapshot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#canHaveSnapshot">https://w3id.org/cocoon/v1.0#canHaveSnapshot</seealso>
    let canHaveSnapshot = Prefixed_Name(cocoon, "canHaveSnapshot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#chargedPerCore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"For Google Cloud, cost of SQL server image is charged on per core basis."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#chargedPerCore">https://w3id.org/cocoon/v1.0#chargedPerCore</seealso>
    let chargedPerCore = Prefixed_Name(cocoon, "chargedPerCore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Similar to location, this property specifies the continent."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#continent">https://w3id.org/cocoon/v1.0#continent</seealso>
    let continent = Prefixed_Name(cocoon, "continent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#excludesDestination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#excludesDestination">https://w3id.org/cocoon/v1.0#excludesDestination</seealso>
    let excludesDestination =
        Prefixed_Name(cocoon, "excludesDestination") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#forCoresLessEqual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Google Cloud OS price for VM with different number of cores are different.
    /// It is used to describe price for machines with less than or
    /// equal to the specified number of cores."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#forCoresLessEqual">https://w3id.org/cocoon/v1.0#forCoresLessEqual</seealso>
    let forCoresLessEqual = Prefixed_Name(cocoon, "forCoresLessEqual") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#forCoresMoreThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Google Cloud OS price for VM with different number of cores are different.
    /// This is used to describe the price for machines with more than specified
    /// number of cores."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#forCoresMoreThan">https://w3id.org/cocoon/v1.0#forCoresMoreThan</seealso>
    let forCoresMoreThan = Prefixed_Name(cocoon, "forCoresMoreThan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#forUsageLessEqual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#forUsageLessEqual">https://w3id.org/cocoon/v1.0#forUsageLessEqual</seealso>
    let forUsageLessEqual = Prefixed_Name(cocoon, "forUsageLessEqual") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#forUsageMoreThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#forUsageMoreThan">https://w3id.org/cocoon/v1.0#forUsageMoreThan</seealso>
    let forUsageMoreThan = Prefixed_Name(cocoon, "forUsageMoreThan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#gceu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:cocoon/v1.0#UnitOfMeasure</para>
    ///
    /// labels<para>"Google Compute Engine Unit"</para></remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#gceu">https://w3id.org/cocoon/v1.0#gceu</seealso>
    let gceu = Prefixed_Name(cocoon, "gceu") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#gcloud</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Gcloud"</para></remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#gcloud">https://w3id.org/cocoon/v1.0#gcloud</seealso>
    let gcloud = Prefixed_Name(cocoon, "gcloud") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasCPUcapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The power or capacity of CPU available for this type of VM."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasCPUcapacity">https://w3id.org/cocoon/v1.0#hasCPUcapacity</seealso>
    let hasCPUcapacity = Prefixed_Name(cocoon, "hasCPUcapacity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasCurrencyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasCurrencyValue">https://w3id.org/cocoon/v1.0#hasCurrencyValue</seealso>
    let hasCurrencyValue = Prefixed_Name(cocoon, "hasCurrencyValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasDestination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasDestination">https://w3id.org/cocoon/v1.0#hasDestination</seealso>
    let hasDestination = Prefixed_Name(cocoon, "hasDestination") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasDirection">https://w3id.org/cocoon/v1.0#hasDirection</seealso>
    let hasDirection = Prefixed_Name(cocoon, "hasDirection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasMaxNumberOfDisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasMaxNumberOfDisk">https://w3id.org/cocoon/v1.0#hasMaxNumberOfDisk</seealso>
    let hasMaxNumberOfDisk = Prefixed_Name(cocoon, "hasMaxNumberOfDisk") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasMaxStorageSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasMaxStorageSize">https://w3id.org/cocoon/v1.0#hasMaxStorageSize</seealso>
    let hasMaxStorageSize = Prefixed_Name(cocoon, "hasMaxStorageSize") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasMemory">https://w3id.org/cocoon/v1.0#hasMemory</seealso>
    let hasMemory = Prefixed_Name(cocoon, "hasMemory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasProvider">https://w3id.org/cocoon/v1.0#hasProvider</seealso>
    let hasProvider = Prefixed_Name(cocoon, "hasProvider") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasRegion">https://w3id.org/cocoon/v1.0#hasRegion</seealso>
    let hasRegion = Prefixed_Name(cocoon, "hasRegion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasServiceLevelAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasServiceLevelAgreement">https://w3id.org/cocoon/v1.0#hasServiceLevelAgreement</seealso>
    let hasServiceLevelAgreement =
        Prefixed_Name(cocoon, "hasServiceLevelAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasStorage">https://w3id.org/cocoon/v1.0#hasStorage</seealso>
    let hasStorage = Prefixed_Name(cocoon, "hasStorage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasStorageIOMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasStorageIOMax">https://w3id.org/cocoon/v1.0#hasStorageIOMax</seealso>
    let hasStorageIOMax = Prefixed_Name(cocoon, "hasStorageIOMax") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasStorageSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasStorageSize">https://w3id.org/cocoon/v1.0#hasStorageSize</seealso>
    let hasStorageSize = Prefixed_Name(cocoon, "hasStorageSize") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasStorageThroughputMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasStorageThroughputMax">https://w3id.org/cocoon/v1.0#hasStorageThroughputMax</seealso>
    let hasStorageThroughputMax =
        Prefixed_Name(cocoon, "hasStorageThroughputMax") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#hasUnitOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#hasUnitOfMeasurement">https://w3id.org/cocoon/v1.0#hasUnitOfMeasurement</seealso>
    let hasUnitOfMeasurement =
        Prefixed_Name(cocoon, "hasUnitOfMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cocoon/v1.0#inJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#inJurisdiction">https://w3id.org/cocoon/v1.0#inJurisdiction</seealso>
    let inJurisdiction = Prefixed_Name(cocoon, "inJurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#inPhysicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#inPhysicalLocation">https://w3id.org/cocoon/v1.0#inPhysicalLocation</seealso>
    let inPhysicalLocation = Prefixed_Name(cocoon, "inPhysicalLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#inUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#inUse">https://w3id.org/cocoon/v1.0#inUse</seealso>
    let inUse = Prefixed_Name(cocoon, "inUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#mirandazhangqian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#mirandazhangqian">https://w3id.org/cocoon/v1.0#mirandazhangqian</seealso>
    let mirandazhangqian = Prefixed_Name(cocoon, "mirandazhangqian") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#numberOfCores</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"For Google Cloud, cores and vCPU referes to the same thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#numberOfCores">https://w3id.org/cocoon/v1.0#numberOfCores</seealso>
    let numberOfCores = Prefixed_Name(cocoon, "numberOfCores") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#numericValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#numericValue">https://w3id.org/cocoon/v1.0#numericValue</seealso>
    let numericValue = Prefixed_Name(cocoon, "numericValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#ofObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#ofObjectType">https://w3id.org/cocoon/v1.0#ofObjectType</seealso>
    let ofObjectType = Prefixed_Name(cocoon, "ofObjectType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cocoon/v1.0#specialRateType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/cocoon/v1.0#specialRateType">https://w3id.org/cocoon/v1.0#specialRateType</seealso>
    let specialRateType = Prefixed_Name(cocoon, "specialRateType") |> PrefixedName
