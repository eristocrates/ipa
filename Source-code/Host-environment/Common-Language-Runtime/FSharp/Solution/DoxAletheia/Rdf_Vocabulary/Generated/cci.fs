namespace http.cookingbigdata.com.linkeddata.ccinstances.hash

open DoxAletheia

module cci =
    let _namespace_name = "http://cookingbigdata.com/linkeddata/ccinstances#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccinstances#manuelparra"></see>
    /// </summary>
    let manuelparra = _prefix "manuelparra"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccinstances#cookingbigdata"></see>
    /// </summary>
    let cookingbigdata = _prefix "cookingbigdata"
    /// <summary>
    /// Instance
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#Instance"></see></summary>
    let Instance = _prefix "Instance"
    /// <summary>
    /// Instance group code
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// CPU
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu"></see></summary>
    let cpu = _prefix "cpu"
    /// <summary>
    /// CPU Cache is an area of fast memory located on the processor. It refers to the architecture that allows all cores to dynamically share access to the last level cache.
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_cache"></see></summary>
    let cpu_cache = _prefix "cpu_cache"
    /// <summary>
    /// Processor Number. For example: i5-8600T
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_code"></see></summary>
    let cpu_code = _prefix "cpu_code"
    /// <summary>
    /// CPU Thermal Design Power (TDP) represents the average power, in watts, the processor dissipates when operating at Base Frequency with all cores active under an Intel-defined, high-complexity workload
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_consumition"></see></summary>
    let cpu_consumition = _prefix "cpu_consumition"
    /// <summary>
    /// Numer of physical cores. For example: 6
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_cores"></see></summary>
    let cpu_cores = _prefix "cpu_cores"
    /// <summary>
    /// Processor Base Frequency describes the rate at which the processor's transistors open and close. The processor base frequency is the operating point where TDP is defined. Frequency is measured in gigahertz (GHz), or billion cycles per second.
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_frecuency"></see></summary>
    let cpu_frecuency = _prefix "cpu_frecuency"
    /// <summary>
    /// Max turbo frequency is the maximum single core frequency at which the processor is capable of operating using Intel® Turbo Boost Technology. Frequency is measured in gigahertz (GHz), or billion cycles per second.
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_max_frecuency"></see></summary>
    let cpu_max_frecuency = _prefix "cpu_max_frecuency"
    /// <summary>
    /// Model of CPU. For example: 8th Generation Intel® Core™ i5 Processors
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_model"></see></summary>
    let cpu_model = _prefix "cpu_model"
    /// <summary>
    /// A bus is a subsystem that transfers data between computer components or between computers. Types include (FSB) (DMI) (Intel I/O) (QPI)
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_spped"></see></summary>
    let cpu_spped = _prefix "cpu_spped"
    /// <summary>
    /// CPU threads
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_threads"></see></summary>
    let cpu_threads = _prefix "cpu_threads"
    /// <summary>
    /// GPU
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#gpu"></see></summary>
    let gpu = _prefix "gpu"
    /// <summary>
    /// Specifies that the instance is provided with CPU
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#hasCPU"></see></summary>
    let hasCPU = _prefix "hasCPU"
    /// <summary>
    /// Specifies that the instance is provided with network
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#hasNetwork"></see></summary>
    let hasNetwork = _prefix "hasNetwork"
    /// <summary>
    /// Network
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#network"></see></summary>
    let network = _prefix "network"
    /// <summary>
    /// Specifies that the instance is provided with RAM
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#hasRAM"></see></summary>
    let hasRAM = _prefix "hasRAM"
    /// <summary>
    /// RAM
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#ram"></see></summary>
    let ram = _prefix "ram"
    /// <summary>
    /// Specifies that the instance is provided with storage
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#hasStorage"></see></summary>
    let hasStorage = _prefix "hasStorage"
    /// <summary>
    /// Storage
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#storage"></see></summary>
    let storage = _prefix "storage"
    /// <summary>
    /// Unique identifier of the instance. It allows to know the name of the instance in a quick way. For instance: t2.medium
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#model"></see></summary>
    let model = _prefix "model"
    /// <summary>
    /// Network bandwidth in Mbps. For example: 1000 Mbps
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#network_bandwidth"></see></summary>
    let network_bandwidth = _prefix "network_bandwidth"
    /// <summary>
    /// RAM frecuency in MHz. For example: 2300 MHz
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#ram_frecuency"></see></summary>
    let ram_frecuency = _prefix "ram_frecuency"
    /// <summary>
    /// RAM size of the instance. For example: 256 GB
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#ram_size"></see></summary>
    let ram_size = _prefix "ram_size"
    /// <summary>
    /// RAM Type. For example: DDR3
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#ram_type"></see></summary>
    let ram_type = _prefix "ram_type"
    /// <summary>
    /// Storage bandwidth in MB/s
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#storage_bandwidth"></see></summary>
    let storage_bandwidth = _prefix "storage_bandwidth"
    /// <summary>
    /// Storage size. For example: 500 GB
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#storage_size"></see></summary>
    let storage_size = _prefix "storage_size"
    /// <summary>
    /// Storage Technology. For instance: SSD/HDD/...
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#storage_technology"></see></summary>
    let storage_technology = _prefix "storage_technology"
    /// <summary>
    /// Name that groups together instances of the same or similar type under a common name; for example: Basic Group
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#type"></see></summary>
    let type_ = _prefix "type"
