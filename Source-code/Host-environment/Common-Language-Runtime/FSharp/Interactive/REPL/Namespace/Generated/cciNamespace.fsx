#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cci =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://cookingbigdata.com/linkeddata/ccinstances#" "cci"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Instance</para>
    ///   <para>rdfs:comment : Instance</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#Instance">cci:Instance</a>
    /// </summary>
    let Instance = _prefixId.prefix "Instance"
    /// <summary>
    ///   <para>rdfs:label : Short Code</para>
    ///   <para>rdfs:comment : Instance group code</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#code">cci:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    let cookingbigdata = _prefixId.prefix "cookingbigdata"
    /// <summary>
    ///   <para>rdfs:label : CPU</para>
    ///   <para>rdfs:comment : CPU</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#cpu">cci:cpu</a>
    /// </summary>
    let cpu = _prefixId.prefix "cpu"
    /// <summary>
    ///   <para>rdfs:label : CPU Cache</para>
    ///   <para>rdfs:comment : CPU Cache is an area of fast memory located on the processor. It refers to the architecture that allows all cores to dynamically share access to the last level cache.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_cache">cci:cpu_cache</a>
    /// </summary>
    let cpu_cache = _prefixId.prefix "cpu_cache"
    /// <summary>
    ///   <para>rdfs:label : CPU ID</para>
    ///   <para>rdfs:comment : Processor Number. For example: i5-8600T</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_code">cci:cpu_code</a>
    /// </summary>
    let cpu_code = _prefixId.prefix "cpu_code"
    /// <summary>
    ///   <para>rdfs:label : CPU TDP</para>
    ///   <para>rdfs:comment : CPU Thermal Design Power (TDP) represents the average power, in watts, the processor dissipates when operating at Base Frequency with all cores active under an Intel-defined, high-complexity workload</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_consumition">cci:cpu_consumition</a>
    /// </summary>
    let cpu_consumition = _prefixId.prefix "cpu_consumition"
    /// <summary>
    ///   <para>rdfs:label : CPU cores</para>
    ///   <para>rdfs:comment : Numer of physical cores. For example: 6</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_cores">cci:cpu_cores</a>
    /// </summary>
    let cpu_cores = _prefixId.prefix "cpu_cores"
    /// <summary>
    ///   <para>rdfs:label : CPU Frecuency</para>
    ///   <para>rdfs:comment : Processor Base Frequency describes the rate at which the processor's transistors open and close. The processor base frequency is the operating point where TDP is defined. Frequency is measured in gigahertz (GHz), or billion cycles per second.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_frecuency">cci:cpu_frecuency</a>
    /// </summary>
    let cpu_frecuency = _prefixId.prefix "cpu_frecuency"
    /// <summary>
    ///   <para>rdfs:label : CPU Max Frecuency</para>
    ///   <para>rdfs:comment : Max turbo frequency is the maximum single core frequency at which the processor is capable of operating using Intel® Turbo Boost Technology. Frequency is measured in gigahertz (GHz), or billion cycles per second.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_max_frecuency">cci:cpu_max_frecuency</a>
    /// </summary>
    let cpu_max_frecuency = _prefixId.prefix "cpu_max_frecuency"
    /// <summary>
    ///   <para>rdfs:label : CPU Model</para>
    ///   <para>rdfs:comment : Model of CPU. For example: 8th Generation Intel® Core™ i5 Processors</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_model">cci:cpu_model</a>
    /// </summary>
    let cpu_model = _prefixId.prefix "cpu_model"
    /// <summary>
    ///   <para>rdfs:label : CPU bus speed</para>
    ///   <para>rdfs:comment : A bus is a subsystem that transfers data between computer components or between computers. Types include (FSB) (DMI) (Intel I/O) (QPI)</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_spped">cci:cpu_spped</a>
    /// </summary>
    let cpu_spped = _prefixId.prefix "cpu_spped"
    /// <summary>
    ///   <para>rdfs:label : CPU threads</para>
    ///   <para>rdfs:comment : CPU threads</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_threads">cci:cpu_threads</a>
    /// </summary>
    let cpu_threads = _prefixId.prefix "cpu_threads"
    /// <summary>
    ///   <para>rdfs:label : GPU</para>
    ///   <para>rdfs:comment : GPU</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#gpu">cci:gpu</a>
    /// </summary>
    let gpu = _prefixId.prefix "gpu"
    /// <summary>
    ///   <para>rdfs:label : Has CPU</para>
    ///   <para>rdfs:comment : Specifies that the instance is provided with CPU</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#hasCPU">cci:hasCPU</a>
    /// </summary>
    let hasCPU = _prefixId.prefix "hasCPU"
    /// <summary>
    ///   <para>rdfs:label : Has network</para>
    ///   <para>rdfs:comment : Specifies that the instance is provided with network</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#hasNetwork">cci:hasNetwork</a>
    /// </summary>
    let hasNetwork = _prefixId.prefix "hasNetwork"
    /// <summary>
    ///   <para>rdfs:label : Has RAM</para>
    ///   <para>rdfs:comment : Specifies that the instance is provided with RAM</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#hasRAM">cci:hasRAM</a>
    /// </summary>
    let hasRAM = _prefixId.prefix "hasRAM"
    /// <summary>
    ///   <para>rdfs:label : Has storage</para>
    ///   <para>rdfs:comment : Specifies that the instance is provided with storage</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#hasStorage">cci:hasStorage</a>
    /// </summary>
    let hasStorage = _prefixId.prefix "hasStorage"
    let manuelparra = _prefixId.prefix "manuelparra"
    /// <summary>
    ///   <para>rdfs:label : Model Code</para>
    ///   <para>rdfs:comment : Unique identifier of the instance. It allows to know the name of the instance in a quick way. For instance: t2.medium</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#model">cci:model</a>
    /// </summary>
    let model = _prefixId.prefix "model"
    /// <summary>
    ///   <para>rdfs:label : Network</para>
    ///   <para>rdfs:comment : Network</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#network">cci:network</a>
    /// </summary>
    let network = _prefixId.prefix "network"
    /// <summary>
    ///   <para>rdfs:label : Network bandwidth</para>
    ///   <para>rdfs:comment : Network bandwidth in Mbps. For example: 1000 Mbps</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#network_bandwidth">cci:network_bandwidth</a>
    /// </summary>
    let network_bandwidth = _prefixId.prefix "network_bandwidth"
    /// <summary>
    ///   <para>rdfs:label : RAM</para>
    ///   <para>rdfs:comment : RAM</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#ram">cci:ram</a>
    /// </summary>
    let ram = _prefixId.prefix "ram"
    /// <summary>
    ///   <para>rdfs:label : RAM frecuency</para>
    ///   <para>rdfs:comment : RAM frecuency in MHz. For example: 2300 MHz</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#ram_frecuency">cci:ram_frecuency</a>
    /// </summary>
    let ram_frecuency = _prefixId.prefix "ram_frecuency"
    /// <summary>
    ///   <para>rdfs:label : RAM size</para>
    ///   <para>rdfs:comment : RAM size of the instance. For example: 256 GB</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#ram_size">cci:ram_size</a>
    /// </summary>
    let ram_size = _prefixId.prefix "ram_size"
    /// <summary>
    ///   <para>rdfs:label : RAM Type</para>
    ///   <para>rdfs:comment : RAM Type. For example: DDR3</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#ram_type">cci:ram_type</a>
    /// </summary>
    let ram_type = _prefixId.prefix "ram_type"
    /// <summary>
    ///   <para>rdfs:label : Storage</para>
    ///   <para>rdfs:comment : Storage</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#storage">cci:storage</a>
    /// </summary>
    let storage = _prefixId.prefix "storage"
    /// <summary>
    ///   <para>rdfs:label : Storage Bandwidth</para>
    ///   <para>rdfs:comment : Storage bandwidth in MB/s</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#storage_bandwidth">cci:storage_bandwidth</a>
    /// </summary>
    let storage_bandwidth = _prefixId.prefix "storage_bandwidth"
    /// <summary>
    ///   <para>rdfs:label : Storage size</para>
    ///   <para>rdfs:comment : Storage size. For example: 500 GB</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#storage_size">cci:storage_size</a>
    /// </summary>
    let storage_size = _prefixId.prefix "storage_size"
    /// <summary>
    ///   <para>rdfs:label : Storage Technology</para>
    ///   <para>rdfs:comment : Storage Technology. For instance: SSD/HDD/...</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#storage_technology">cci:storage_technology</a>
    /// </summary>
    let storage_technology = _prefixId.prefix "storage_technology"
    /// <summary>
    ///   <para>rdfs:label : Type Code</para>
    ///   <para>rdfs:comment : Name that groups together instances of the same or similar type under a common name; for example: Basic Group</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccinstances#type">cci:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
