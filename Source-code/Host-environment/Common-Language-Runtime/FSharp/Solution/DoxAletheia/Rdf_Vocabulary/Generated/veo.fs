namespace http.linkeddata.finki.ukim.mk.lod.ontology.veo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module veo =
    let _namespace_iri = Namespace_Iri veo |> NamespaceIRI
    /// <summary>
    ///   <para>veo:Train</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#Train">http://linkeddata.finki.ukim.mk/lod/ontology/veo#Train</seealso>
    let Train = Prefixed_Name(veo, "Train") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasEmissionsReduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents emissions reduction measured in g/km that a vehicle has, through the implemented innovative technologies.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasEmissionsReduction">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasEmissionsReduction</seealso>
    let hasEmissionsReduction =
        Prefixed_Name(veo, "hasEmissionsReduction") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasManufacturerHarmonisedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents a manufacturer harmonised name.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasManufacturerHarmonisedName">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasManufacturerHarmonisedName</seealso>
    let hasManufacturerHarmonisedName =
        Prefixed_Name(veo, "hasManufacturerHarmonisedName") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasElectricEnergyConsumtion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the electric energy consumption of a vehicle measured in Wh/km.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasElectricEnergyConsumtion">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasElectricEnergyConsumtion</seealso>
    let hasElectricEnergyConsumtion =
        Prefixed_Name(veo, "hasElectricEnergyConsumtion") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasFuelMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the fuel mode of a vehicle</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasFuelMode">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasFuelMode</seealso>
    let hasFuelMode = Prefixed_Name(veo, "hasFuelMode") |> PrefixedName

    /// <summary>
    ///   <para>veo:emissionsPerPassenger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#emissionsPerPassenger">http://linkeddata.finki.ukim.mk/lod/ontology/veo#emissionsPerPassenger</seealso>
    let emissionsPerPassenger =
        Prefixed_Name(veo, "emissionsPerPassenger") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasEngineCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property shows the capacity of the engine of a vehicle measured in cm3</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasEngineCapacity">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasEngineCapacity</seealso>
    let hasEngineCapacity = Prefixed_Name(veo, "hasEngineCapacity") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasInnovativeTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents an innovation technology that a vehicle has implemented.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasInnovativeTechnology">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasInnovativeTechnology</seealso>
    let hasInnovativeTechnology =
        Prefixed_Name(veo, "hasInnovativeTechnology") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasManufacturerPooling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents a manufacturers pooling.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasManufacturerPooling">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasManufacturerPooling</seealso>
    let hasManufacturerPooling =
        Prefixed_Name(veo, "hasManufacturerPooling") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasMSRegManufacturerName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents a manufacturer name as in the registry of Member States of the European Environment Agency.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasMSRegManufacturerName">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasMSRegManufacturerName</seealso>
    let hasMSRegManufacturerName =
        Prefixed_Name(veo, "hasMSRegManufacturerName") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasSteeringAxleWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the width of the steering axle of a vehicle measured in mm.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasSteeringAxleWidth">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasSteeringAxleWidth</seealso>
    let hasSteeringAxleWidth =
        Prefixed_Name(veo, "hasSteeringAxleWidth") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasTotalNewRegistrations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the nubmer of total new registration of a vehicle.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasTotalNewRegistrations">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasTotalNewRegistrations</seealso>
    let hasTotalNewRegistrations =
        Prefixed_Name(veo, "hasTotalNewRegistrations") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasOtherAxleWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the width of the other steering axle of a vehicle measured in mm.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasOtherAxleWidth">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasOtherAxleWidth</seealso>
    let hasOtherAxleWidth = Prefixed_Name(veo, "hasOtherAxleWidth") |> PrefixedName
    /// <summary>
    ///   <para>veo:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents an internal type of vehicle.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#type">http://linkeddata.finki.ukim.mk/lod/ontology/veo#type</seealso>
    let type_ = Prefixed_Name(veo, "type") |> PrefixedName

    /// <summary>
    ///   <para>veo:hasTypeApprovalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents an internal type approval number.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasTypeApprovalNumber">http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasTypeApprovalNumber</seealso>
    let hasTypeApprovalNumber =
        Prefixed_Name(veo, "hasTypeApprovalNumber") |> PrefixedName

    /// <summary>
    ///   <para>veo:variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents an internal variant code.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#variant">http://linkeddata.finki.ukim.mk/lod/ontology/veo#variant</seealso>
    let variant = Prefixed_Name(veo, "variant") |> PrefixedName

    /// <summary>
    ///   <para>veo:vehicleTypeApprovedCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents a category of the approved vehicle type.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#vehicleTypeApprovedCategory">http://linkeddata.finki.ukim.mk/lod/ontology/veo#vehicleTypeApprovedCategory</seealso>
    let vehicleTypeApprovedCategory =
        Prefixed_Name(veo, "vehicleTypeApprovedCategory") |> PrefixedName

    /// <summary>
    ///   <para>veo:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents an internal version code of a vehicle.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#version">http://linkeddata.finki.ukim.mk/lod/ontology/veo#version</seealso>
    let version = Prefixed_Name(veo, "version") |> PrefixedName
    /// <summary>
    ///   <para>veo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>An ontology for describing vehicles and their emissions.</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#">http://linkeddata.finki.ukim.mk/lod/ontology/veo#</seealso>
    let _prefix_iri = Prefixed_Name(veo, "") |> PrefixedName
    /// <summary>
    ///   <para>veo:numberOfPassengers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#numberOfPassengers">http://linkeddata.finki.ukim.mk/lod/ontology/veo#numberOfPassengers</seealso>
    let numberOfPassengers = Prefixed_Name(veo, "numberOfPassengers") |> PrefixedName
