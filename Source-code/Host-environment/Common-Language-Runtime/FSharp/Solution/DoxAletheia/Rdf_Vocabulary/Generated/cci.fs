namespace http.cookingbigdata.com.linkeddata.ccinstances.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cci =
    let _namespace_iri = Namespace_Iri cci |> NamespaceIRI
    /// <summary>
    ///   <para>cci:manuelparra</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#manuelparra">http://cookingbigdata.com/linkeddata/ccinstances#manuelparra</seealso>
    let manuelparra = Prefixed_Name(cci, "manuelparra") |> PrefixedName
    /// <summary>
    ///   <para>cci:cookingbigdata</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cookingbigdata">http://cookingbigdata.com/linkeddata/ccinstances#cookingbigdata</seealso>
    let cookingbigdata = Prefixed_Name(cci, "cookingbigdata") |> PrefixedName
    /// <summary>
    ///   <para>cci:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Instance group code</para>
    /// labels<para>Short Code</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#code">http://cookingbigdata.com/linkeddata/ccinstances#code</seealso>
    let code = Prefixed_Name(cci, "code") |> PrefixedName
    /// <summary>
    ///   <para>cci:cpu</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>CPU</para>
    /// labels<para>CPU</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cpu">http://cookingbigdata.com/linkeddata/ccinstances#cpu</seealso>
    let cpu = Prefixed_Name(cci, "cpu") |> PrefixedName
    /// <summary>
    ///   <para>cci:cpu_cache</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>CPU Cache is an area of fast memory located on the processor. It refers to the architecture that allows all cores to dynamically share access to the last level cache.</para>
    /// labels<para>CPU Cache</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_cache">http://cookingbigdata.com/linkeddata/ccinstances#cpu_cache</seealso>
    let cpu_cache = Prefixed_Name(cci, "cpu_cache") |> PrefixedName
    /// <summary>
    ///   <para>cci:cpu_cores</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Numer of physical cores. For example: 6</para>
    /// labels<para>CPU cores</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_cores">http://cookingbigdata.com/linkeddata/ccinstances#cpu_cores</seealso>
    let cpu_cores = Prefixed_Name(cci, "cpu_cores") |> PrefixedName
    /// <summary>
    ///   <para>cci:cpu_frecuency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Processor Base Frequency describes the rate at which the processor's transistors open and close. The processor base frequency is the operating point where TDP is defined. Frequency is measured in gigahertz (GHz), or billion cycles per second.</para>
    /// labels<para>CPU Frecuency</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_frecuency">http://cookingbigdata.com/linkeddata/ccinstances#cpu_frecuency</seealso>
    let cpu_frecuency = Prefixed_Name(cci, "cpu_frecuency") |> PrefixedName
    /// <summary>
    ///   <para>cci:cpu_max_frecuency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Max turbo frequency is the maximum single core frequency at which the processor is capable of operating using Intel® Turbo Boost Technology. Frequency is measured in gigahertz (GHz), or billion cycles per second.</para>
    /// labels<para>CPU Max Frecuency</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_max_frecuency">http://cookingbigdata.com/linkeddata/ccinstances#cpu_max_frecuency</seealso>
    let cpu_max_frecuency = Prefixed_Name(cci, "cpu_max_frecuency") |> PrefixedName
    /// <summary>
    ///   <para>cci:cpu_consumition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>CPU Thermal Design Power (TDP) represents the average power, in watts, the processor dissipates when operating at Base Frequency with all cores active under an Intel-defined, high-complexity workload</para>
    /// labels<para>CPU TDP</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_consumition">http://cookingbigdata.com/linkeddata/ccinstances#cpu_consumition</seealso>
    let cpu_consumition = Prefixed_Name(cci, "cpu_consumition") |> PrefixedName
    /// <summary>
    ///   <para>cci:hasNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies that the instance is provided with network</para>
    /// labels<para>Has network</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#hasNetwork">http://cookingbigdata.com/linkeddata/ccinstances#hasNetwork</seealso>
    let hasNetwork = Prefixed_Name(cci, "hasNetwork") |> PrefixedName
    /// <summary>
    ///   <para>cci:cpu_model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Model of CPU. For example: 8th Generation Intel® Core™ i5 Processors</para>
    /// labels<para>CPU Model</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_model">http://cookingbigdata.com/linkeddata/ccinstances#cpu_model</seealso>
    let cpu_model = Prefixed_Name(cci, "cpu_model") |> PrefixedName
    /// <summary>
    ///   <para>cci:cpu_threads</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>CPU threads</para>
    /// labels<para>CPU threads</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_threads">http://cookingbigdata.com/linkeddata/ccinstances#cpu_threads</seealso>
    let cpu_threads = Prefixed_Name(cci, "cpu_threads") |> PrefixedName
    /// <summary>
    ///   <para>cci:cpu_spped</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A bus is a subsystem that transfers data between computer components or between computers. Types include (FSB) (DMI) (Intel I/O) (QPI)</para>
    /// labels<para>CPU bus speed</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_spped">http://cookingbigdata.com/linkeddata/ccinstances#cpu_spped</seealso>
    let cpu_spped = Prefixed_Name(cci, "cpu_spped") |> PrefixedName
    /// <summary>
    ///   <para>cci:gpu</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>GPU</para>
    /// labels<para>GPU</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#gpu">http://cookingbigdata.com/linkeddata/ccinstances#gpu</seealso>
    let gpu = Prefixed_Name(cci, "gpu") |> PrefixedName
    /// <summary>
    ///   <para>cci:hasCPU</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies that the instance is provided with CPU</para>
    /// labels<para>Has CPU</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#hasCPU">http://cookingbigdata.com/linkeddata/ccinstances#hasCPU</seealso>
    let hasCPU = Prefixed_Name(cci, "hasCPU") |> PrefixedName
    /// <summary>
    ///   <para>cci:network</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Network</para>
    /// labels<para>Network</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#network">http://cookingbigdata.com/linkeddata/ccinstances#network</seealso>
    let network = Prefixed_Name(cci, "network") |> PrefixedName
    /// <summary>
    ///   <para>cci:ram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>RAM</para>
    /// labels<para>RAM</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#ram">http://cookingbigdata.com/linkeddata/ccinstances#ram</seealso>
    let ram = Prefixed_Name(cci, "ram") |> PrefixedName
    /// <summary>
    ///   <para>cci:hasRAM</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies that the instance is provided with RAM</para>
    /// labels<para>Has RAM</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#hasRAM">http://cookingbigdata.com/linkeddata/ccinstances#hasRAM</seealso>
    let hasRAM = Prefixed_Name(cci, "hasRAM") |> PrefixedName
    /// <summary>
    ///   <para>cci:storage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Storage</para>
    /// labels<para>Storage</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#storage">http://cookingbigdata.com/linkeddata/ccinstances#storage</seealso>
    let storage = Prefixed_Name(cci, "storage") |> PrefixedName
    /// <summary>
    ///   <para>cci:network_bandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Network bandwidth in Mbps. For example: 1000 Mbps</para>
    /// labels<para>Network bandwidth</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#network_bandwidth">http://cookingbigdata.com/linkeddata/ccinstances#network_bandwidth</seealso>
    let network_bandwidth = Prefixed_Name(cci, "network_bandwidth") |> PrefixedName
    /// <summary>
    ///   <para>cci:hasStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies that the instance is provided with storage</para>
    /// labels<para>Has storage</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#hasStorage">http://cookingbigdata.com/linkeddata/ccinstances#hasStorage</seealso>
    let hasStorage = Prefixed_Name(cci, "hasStorage") |> PrefixedName
    /// <summary>
    ///   <para>cci:model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Unique identifier of the instance. It allows to know the name of the instance in a quick way. For instance: t2.medium</para>
    /// labels<para>Model Code</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#model">http://cookingbigdata.com/linkeddata/ccinstances#model</seealso>
    let model = Prefixed_Name(cci, "model") |> PrefixedName
    /// <summary>
    ///   <para>cci:storage_bandwidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Storage bandwidth in MB/s</para>
    /// labels<para>Storage Bandwidth</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#storage_bandwidth">http://cookingbigdata.com/linkeddata/ccinstances#storage_bandwidth</seealso>
    let storage_bandwidth = Prefixed_Name(cci, "storage_bandwidth") |> PrefixedName
    /// <summary>
    ///   <para>cci:storage_technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Storage Technology. For instance: SSD/HDD/...</para>
    /// labels<para>Storage Technology</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#storage_technology">http://cookingbigdata.com/linkeddata/ccinstances#storage_technology</seealso>
    let storage_technology = Prefixed_Name(cci, "storage_technology") |> PrefixedName
    /// <summary>
    ///   <para>cci:ram_frecuency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>RAM frecuency in MHz. For example: 2300 MHz</para>
    /// labels<para>RAM frecuency</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#ram_frecuency">http://cookingbigdata.com/linkeddata/ccinstances#ram_frecuency</seealso>
    let ram_frecuency = Prefixed_Name(cci, "ram_frecuency") |> PrefixedName
    /// <summary>
    ///   <para>cci:ram_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>RAM Type. For example: DDR3</para>
    /// labels<para>RAM Type</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#ram_type">http://cookingbigdata.com/linkeddata/ccinstances#ram_type</seealso>
    let ram_type = Prefixed_Name(cci, "ram_type") |> PrefixedName
    /// <summary>
    ///   <para>cci:storage_size</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Storage size. For example: 500 GB</para>
    /// labels<para>Storage size</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#storage_size">http://cookingbigdata.com/linkeddata/ccinstances#storage_size</seealso>
    let storage_size = Prefixed_Name(cci, "storage_size") |> PrefixedName
    /// <summary>
    ///   <para>cci:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Name that groups together instances of the same or similar type under a common name; for example: Basic Group</para>
    /// labels<para>Type Code</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#type">http://cookingbigdata.com/linkeddata/ccinstances#type</seealso>
    let type_ = Prefixed_Name(cci, "type") |> PrefixedName
    /// <summary>
    ///   <para>cci:ram_size</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>RAM size of the instance. For example: 256 GB</para>
    /// labels<para>RAM size</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#ram_size">http://cookingbigdata.com/linkeddata/ccinstances#ram_size</seealso>
    let ram_size = Prefixed_Name(cci, "ram_size") |> PrefixedName
    /// <summary>
    ///   <para>cci:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Cloud Instances definition</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#">http://cookingbigdata.com/linkeddata/ccinstances#</seealso>
    let _prefix_iri = Prefixed_Name(cci, "") |> PrefixedName
    /// <summary>
    ///   <para>cci:Instance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Instance</para>
    /// labels<para>Instance</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#Instance">http://cookingbigdata.com/linkeddata/ccinstances#Instance</seealso>
    let Instance = Prefixed_Name(cci, "Instance") |> PrefixedName
    /// <summary>
    ///   <para>cci:cpu_code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Processor Number. For example: i5-8600T</para>
    /// labels<para>CPU ID</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccinstances#cpu_code">http://cookingbigdata.com/linkeddata/ccinstances#cpu_code</seealso>
    let cpu_code = Prefixed_Name(cci, "cpu_code") |> PrefixedName
