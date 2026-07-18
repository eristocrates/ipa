namespace http.cookingbigdata.com.linkeddata.ccinstances.hash

open DoxAletheia.Rdf_Vocabulary

module cci =
    let _namespace_name = "http://cookingbigdata.com/linkeddata/ccinstances#"

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccinstances#manuelparra"></see>
    /// </summary>
    let manuelparra =
        Namespaced_IRI.parse _namespace_name "manuelparra" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccinstances#cookingbigdata"></see>
    /// </summary>
    let cookingbigdata =
        Namespaced_IRI.parse _namespace_name "cookingbigdata" |> NamespacedName

    /// <summary>
    /// Instance
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#Instance"></see></summary>
    let Instance = Namespaced_IRI.parse _namespace_name "Instance" |> NamespacedName
    /// <summary>
    /// Instance group code
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName
    /// <summary>
    /// CPU
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu"></see></summary>
    let cpu = Namespaced_IRI.parse _namespace_name "cpu" |> NamespacedName
    /// <summary>
    /// CPU Cache is an area of fast memory located on the processor. It refers to the architecture that allows all cores to dynamically share access to the last level cache.
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_cache"></see></summary>
    let cpu_cache = Namespaced_IRI.parse _namespace_name "cpu_cache" |> NamespacedName
    /// <summary>
    /// Processor Number. For example: i5-8600T
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_code"></see></summary>
    let cpu_code = Namespaced_IRI.parse _namespace_name "cpu_code" |> NamespacedName

    /// <summary>
    /// CPU Thermal Design Power (TDP) represents the average power, in watts, the processor dissipates when operating at Base Frequency with all cores active under an Intel-defined, high-complexity workload
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_consumition"></see></summary>
    let cpu_consumition =
        Namespaced_IRI.parse _namespace_name "cpu_consumition" |> NamespacedName

    /// <summary>
    /// Numer of physical cores. For example: 6
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_cores"></see></summary>
    let cpu_cores = Namespaced_IRI.parse _namespace_name "cpu_cores" |> NamespacedName

    /// <summary>
    /// Processor Base Frequency describes the rate at which the processor's transistors open and close. The processor base frequency is the operating point where TDP is defined. Frequency is measured in gigahertz (GHz), or billion cycles per second.
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_frecuency"></see></summary>
    let cpu_frecuency =
        Namespaced_IRI.parse _namespace_name "cpu_frecuency" |> NamespacedName

    /// <summary>
    /// Max turbo frequency is the maximum single core frequency at which the processor is capable of operating using Intel® Turbo Boost Technology. Frequency is measured in gigahertz (GHz), or billion cycles per second.
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_max_frecuency"></see></summary>
    let cpu_max_frecuency =
        Namespaced_IRI.parse _namespace_name "cpu_max_frecuency" |> NamespacedName

    /// <summary>
    /// Model of CPU. For example: 8th Generation Intel® Core™ i5 Processors
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_model"></see></summary>
    let cpu_model = Namespaced_IRI.parse _namespace_name "cpu_model" |> NamespacedName
    /// <summary>
    /// A bus is a subsystem that transfers data between computer components or between computers. Types include (FSB) (DMI) (Intel I/O) (QPI)
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_spped"></see></summary>
    let cpu_spped = Namespaced_IRI.parse _namespace_name "cpu_spped" |> NamespacedName

    /// <summary>
    /// CPU threads
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_threads"></see></summary>
    let cpu_threads =
        Namespaced_IRI.parse _namespace_name "cpu_threads" |> NamespacedName

    /// <summary>
    /// GPU
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#gpu"></see></summary>
    let gpu = Namespaced_IRI.parse _namespace_name "gpu" |> NamespacedName
    /// <summary>
    /// Specifies that the instance is provided with CPU
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#hasCPU"></see></summary>
    let hasCPU = Namespaced_IRI.parse _namespace_name "hasCPU" |> NamespacedName
    /// <summary>
    /// Specifies that the instance is provided with network
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#hasNetwork"></see></summary>
    let hasNetwork = Namespaced_IRI.parse _namespace_name "hasNetwork" |> NamespacedName
    /// <summary>
    /// Network
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#network"></see></summary>
    let network = Namespaced_IRI.parse _namespace_name "network" |> NamespacedName
    /// <summary>
    /// Specifies that the instance is provided with RAM
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#hasRAM"></see></summary>
    let hasRAM = Namespaced_IRI.parse _namespace_name "hasRAM" |> NamespacedName
    /// <summary>
    /// RAM
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#ram"></see></summary>
    let ram = Namespaced_IRI.parse _namespace_name "ram" |> NamespacedName
    /// <summary>
    /// Specifies that the instance is provided with storage
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#hasStorage"></see></summary>
    let hasStorage = Namespaced_IRI.parse _namespace_name "hasStorage" |> NamespacedName
    /// <summary>
    /// Storage
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#storage"></see></summary>
    let storage = Namespaced_IRI.parse _namespace_name "storage" |> NamespacedName
    /// <summary>
    /// Unique identifier of the instance. It allows to know the name of the instance in a quick way. For instance: t2.medium
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#model"></see></summary>
    let model = Namespaced_IRI.parse _namespace_name "model" |> NamespacedName

    /// <summary>
    /// Network bandwidth in Mbps. For example: 1000 Mbps
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#network_bandwidth"></see></summary>
    let network_bandwidth =
        Namespaced_IRI.parse _namespace_name "network_bandwidth" |> NamespacedName

    /// <summary>
    /// RAM frecuency in MHz. For example: 2300 MHz
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#ram_frecuency"></see></summary>
    let ram_frecuency =
        Namespaced_IRI.parse _namespace_name "ram_frecuency" |> NamespacedName

    /// <summary>
    /// RAM size of the instance. For example: 256 GB
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#ram_size"></see></summary>
    let ram_size = Namespaced_IRI.parse _namespace_name "ram_size" |> NamespacedName
    /// <summary>
    /// RAM Type. For example: DDR3
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#ram_type"></see></summary>
    let ram_type = Namespaced_IRI.parse _namespace_name "ram_type" |> NamespacedName

    /// <summary>
    /// Storage bandwidth in MB/s
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#storage_bandwidth"></see></summary>
    let storage_bandwidth =
        Namespaced_IRI.parse _namespace_name "storage_bandwidth" |> NamespacedName

    /// <summary>
    /// Storage size. For example: 500 GB
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#storage_size"></see></summary>
    let storage_size =
        Namespaced_IRI.parse _namespace_name "storage_size" |> NamespacedName

    /// <summary>
    /// Storage Technology. For instance: SSD/HDD/...
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#storage_technology"></see></summary>
    let storage_technology =
        Namespaced_IRI.parse _namespace_name "storage_technology" |> NamespacedName

    /// <summary>
    /// Name that groups together instances of the same or similar type under a common name; for example: Basic Group
    /// <see href="http://cookingbigdata.com/linkeddata/ccinstances#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
