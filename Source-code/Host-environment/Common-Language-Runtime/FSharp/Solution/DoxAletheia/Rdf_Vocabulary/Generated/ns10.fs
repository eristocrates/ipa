namespace https.spdx.org.rdf._3._1.terms.Hardware.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns10 =
    let _namespace_iri = Namespace_Iri ns10 |> NamespaceIRI
    /// <summary>
    ///   <para>spdx:Hardware/BulkHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Products or commodities produced as a bulk unit are called bulk products. Commodities are often sold in bulk."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/BulkHardware">https://spdx.org/rdf/3.1/terms/Hardware/BulkHardware</seealso>
    let BulkHardware = Prefixed_Name(ns10, "BulkHardware") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/Dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Dimensions generally refer to measurable extents or attributes that define the size, shape, or scale of an object, system, or concept."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/Dimensions">https://spdx.org/rdf/3.1/terms/Hardware/Dimensions</seealso>
    let Dimensions = Prefixed_Name(ns10, "Dimensions") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/Hardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Class that describes an instance of Hardware."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/Hardware">https://spdx.org/rdf/3.1/terms/Hardware/Hardware</seealso>
    let Hardware = Prefixed_Name(ns10, "Hardware") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/PhysicalHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Class that describes a physical instance of Hardware."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/PhysicalHardware">https://spdx.org/rdf/3.1/terms/Hardware/PhysicalHardware</seealso>
    let PhysicalHardware = Prefixed_Name(ns10, "PhysicalHardware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/ProductSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A product specification (product spec) is a detailed document that outlines the technical, functional, and design requirements of a product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/ProductSpecification">https://spdx.org/rdf/3.1/terms/Hardware/ProductSpecification</seealso>
    let ProductSpecification =
        Prefixed_Name(ns10, "ProductSpecification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/VirtualHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Class that describes an instance of VirtualHardware."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardware">https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardware</seealso>
    let VirtualHardware = Prefixed_Name(ns10, "VirtualHardware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/VirtualHardwareModelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"VirtualHardwareModelType sets the VirtualHardware Model Type."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType">https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType</seealso>
    let VirtualHardwareModelType =
        Prefixed_Name(ns10, "VirtualHardwareModelType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/VirtualHardwareModelType/cycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Hardware/VirtualHardwareModelType</para>
    ///   <para>"Simulation architectures with precise cycle-level accuracy."</para>
    /// labels<para>"cycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/cycle">https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/cycle</seealso>
    let ``VirtualHardwareModelType/cycle`` =
        Prefixed_Name(ns10, "VirtualHardwareModelType/cycle") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/VirtualHardwareModelType/function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Hardware/VirtualHardwareModelType</para>
    ///   <para>"Simulation the function of the hardware."</para>
    /// labels<para>"function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/function">https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/function</seealso>
    let ``VirtualHardwareModelType/function`` =
        Prefixed_Name(ns10, "VirtualHardwareModelType/function") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/VirtualHardwareModelType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Hardware/VirtualHardwareModelType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"All other simulation types."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/other">https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/other</seealso>
    let ``VirtualHardwareModelType/other`` =
        Prefixed_Name(ns10, "VirtualHardwareModelType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/additionalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Additional relevance information."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/additionalInformation">https://spdx.org/rdf/3.1/terms/Hardware/additionalInformation</seealso>
    let additionalInformation =
        Prefixed_Name(ns10, "additionalInformation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/additionalInformationSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It is the authoritative or credible entity, document, or body of knowledge that provides the meaning of an additionalInformation key and/or its values, ensuring accuracy, context, and standardization."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/additionalInformationSpecification">https://spdx.org/rdf/3.1/terms/Hardware/additionalInformationSpecification</seealso>
    let additionalInformationSpecification =
        Prefixed_Name(ns10, "additionalInformationSpecification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/batchNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifier for product production batch."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/batchNumber">https://spdx.org/rdf/3.1/terms/Hardware/batchNumber</seealso>
    let batchNumber = Prefixed_Name(ns10, "batchNumber") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/bulkQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The amount or measure of a bulk product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/bulkQuantity">https://spdx.org/rdf/3.1/terms/Hardware/bulkQuantity</seealso>
    let bulkQuantity = Prefixed_Name(ns10, "bulkQuantity") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The category describes the hardware item in a DefinedType."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/category">https://spdx.org/rdf/3.1/terms/Hardware/category</seealso>
    let category = Prefixed_Name(ns10, "category") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/centerOfMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A point representing the mean position of the matter in a body or system."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/centerOfMass">https://spdx.org/rdf/3.1/terms/Hardware/centerOfMass</seealso>
    let centerOfMass = Prefixed_Name(ns10, "centerOfMass") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information related to hardware dimension."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/dimensions">https://spdx.org/rdf/3.1/terms/Hardware/dimensions</seealso>
    let dimensions = Prefixed_Name(ns10, "dimensions") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/hardwareVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Version identifier for the hardware product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/hardwareVersion">https://spdx.org/rdf/3.1/terms/Hardware/hardwareVersion</seealso>
    let hardwareVersion = Prefixed_Name(ns10, "hardwareVersion") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/hazard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Hazards are potential sources of harm, danger, or adverse effects to people, property, the environment, or systems within or related to a specific piece of hardware."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/hazard">https://spdx.org/rdf/3.1/terms/Hardware/hazard</seealso>
    let hazard = Prefixed_Name(ns10, "hazard") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/itemVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Version identifier for the item."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/itemVersion">https://spdx.org/rdf/3.1/terms/Hardware/itemVersion</seealso>
    let itemVersion = Prefixed_Name(ns10, "itemVersion") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information related to physical hardware."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/mass">https://spdx.org/rdf/3.1/terms/Hardware/mass</seealso>
    let mass = Prefixed_Name(ns10, "mass") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/massOfHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information related to massOfHardware physical hardware."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/massOfHardware">https://spdx.org/rdf/3.1/terms/Hardware/massOfHardware</seealso>
    let massOfHardware = Prefixed_Name(ns10, "massOfHardware") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/partNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Product Part Number as defined by OEM."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/partNumber">https://spdx.org/rdf/3.1/terms/Hardware/partNumber</seealso>
    let partNumber = Prefixed_Name(ns10, "partNumber") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/productAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Agent who is responsible for product branding such as an OEM."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/productAgent">https://spdx.org/rdf/3.1/terms/Hardware/productAgent</seealso>
    let productAgent = Prefixed_Name(ns10, "productAgent") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/releaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Date of product release."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/releaseDate">https://spdx.org/rdf/3.1/terms/Hardware/releaseDate</seealso>
    let releaseDate = Prefixed_Name(ns10, "releaseDate") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/serialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifier for specific product is called a serial number."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/serialNumber">https://spdx.org/rdf/3.1/terms/Hardware/serialNumber</seealso>
    let serialNumber = Prefixed_Name(ns10, "serialNumber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/virtualHardwareModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information related to virtual hardware simulation."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/virtualHardwareModel">https://spdx.org/rdf/3.1/terms/Hardware/virtualHardwareModel</seealso>
    let virtualHardwareModel =
        Prefixed_Name(ns10, "virtualHardwareModel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/xAxisLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information related to hardware dimension."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/xAxisLength">https://spdx.org/rdf/3.1/terms/Hardware/xAxisLength</seealso>
    let xAxisLength = Prefixed_Name(ns10, "xAxisLength") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/yAxisLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information related to hardware dimension."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/yAxisLength">https://spdx.org/rdf/3.1/terms/Hardware/yAxisLength</seealso>
    let yAxisLength = Prefixed_Name(ns10, "yAxisLength") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Hardware/zAxisLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information related to hardware dimension."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/zAxisLength">https://spdx.org/rdf/3.1/terms/Hardware/zAxisLength</seealso>
    let zAxisLength = Prefixed_Name(ns10, "zAxisLength") |> PrefixedName
