#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module veo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://linkeddata.finki.ukim.mk/lod/ontology/veo#" "veo"

    let _namespaceIri = _prefixId.prefix ""
    let Train = _prefixId.prefix "Train"
    let emissionsPerPassenger = _prefixId.prefix "emissionsPerPassenger"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the electric energy consumption of a vehicle measured in Wh/km.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasElectricEnergyConsumtion">veo:hasElectricEnergyConsumtion</a>
    /// </summary>
    let hasElectricEnergyConsumtion = _prefixId.prefix "hasElectricEnergyConsumtion"
    /// <summary>
    ///   <para>rdfs:comment : This property represents emissions reduction measured in g/km that a vehicle has, through the implemented innovative technologies.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasEmissionsReduction">veo:hasEmissionsReduction</a>
    /// </summary>
    let hasEmissionsReduction = _prefixId.prefix "hasEmissionsReduction"
    /// <summary>
    ///   <para>rdfs:comment : This property shows the capacity of the engine of a vehicle measured in cm3^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasEngineCapacity">veo:hasEngineCapacity</a>
    /// </summary>
    let hasEngineCapacity = _prefixId.prefix "hasEngineCapacity"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the fuel mode of a vehicle^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasFuelMode">veo:hasFuelMode</a>
    /// </summary>
    let hasFuelMode = _prefixId.prefix "hasFuelMode"
    /// <summary>
    ///   <para>rdfs:comment : This property represents an innovation technology that a vehicle has implemented.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasInnovativeTechnology">veo:hasInnovativeTechnology</a>
    /// </summary>
    let hasInnovativeTechnology = _prefixId.prefix "hasInnovativeTechnology"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a manufacturer name as in the registry of Member States of the European Environment Agency.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasMSRegManufacturerName">veo:hasMSRegManufacturerName</a>
    /// </summary>
    let hasMSRegManufacturerName = _prefixId.prefix "hasMSRegManufacturerName"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a manufacturer harmonised name.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasManufacturerHarmonisedName">veo:hasManufacturerHarmonisedName</a>
    /// </summary>
    let hasManufacturerHarmonisedName = _prefixId.prefix "hasManufacturerHarmonisedName"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a manufacturers pooling.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasManufacturerPooling">veo:hasManufacturerPooling</a>
    /// </summary>
    let hasManufacturerPooling = _prefixId.prefix "hasManufacturerPooling"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the width of the other steering axle of a vehicle measured in mm.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasOtherAxleWidth">veo:hasOtherAxleWidth</a>
    /// </summary>
    let hasOtherAxleWidth = _prefixId.prefix "hasOtherAxleWidth"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the width of the steering axle of a vehicle measured in mm.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasSteeringAxleWidth">veo:hasSteeringAxleWidth</a>
    /// </summary>
    let hasSteeringAxleWidth = _prefixId.prefix "hasSteeringAxleWidth"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the nubmer of total new registration of a vehicle.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasTotalNewRegistrations">veo:hasTotalNewRegistrations</a>
    /// </summary>
    let hasTotalNewRegistrations = _prefixId.prefix "hasTotalNewRegistrations"
    /// <summary>
    ///   <para>rdfs:comment : This property represents an internal type approval number.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#hasTypeApprovalNumber">veo:hasTypeApprovalNumber</a>
    /// </summary>
    let hasTypeApprovalNumber = _prefixId.prefix "hasTypeApprovalNumber"
    let numberOfPassengers = _prefixId.prefix "numberOfPassengers"
    /// <summary>
    ///   <para>rdfs:comment : This property represents an internal type of vehicle.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#type">veo:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:comment : This property represents an internal variant code.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#variant">veo:variant</a>
    /// </summary>
    let variant = _prefixId.prefix "variant"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a category of the approved vehicle type.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#vehicleTypeApprovedCategory">veo:vehicleTypeApprovedCategory</a>
    /// </summary>
    let vehicleTypeApprovedCategory = _prefixId.prefix "vehicleTypeApprovedCategory"
    /// <summary>
    ///   <para>rdfs:comment : This property represents an internal version code of a vehicle.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/veo#version">veo:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
