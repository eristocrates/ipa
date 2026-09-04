#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module core =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/mdo/core/" "core"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Calculated Property</para>
    ///   <para>rdfs:comment : A calculated property is a proprty that is a result from a calculation.</para>
    ///   <a href="https://w3id.org/mdo/core/CalculatedProperty">core:CalculatedProperty</a>
    /// </summary>
    let CalculatedProperty = _prefixId.prefix "CalculatedProperty"
    /// <summary>
    ///   <para>rdfs:label : Calculation</para>
    ///   <para>rdfs:comment : A calculation is the use of a specific computational method to process structures and/or properties into output structures and/or calculated properties.</para>
    ///   <a href="https://w3id.org/mdo/core/Calculation">core:Calculation</a>
    /// </summary>
    let Calculation = _prefixId.prefix "Calculation"
    /// <summary>
    ///   <para>rdfs:label : ID</para>
    ///   <para>rdfs:comment : ID represents that a calculation has the unique ID in a string.</para>
    ///   <a href="https://w3id.org/mdo/core/ID">core:ID</a>
    /// </summary>
    let ID = _prefixId.prefix "ID"
    /// <summary>
    ///   <para>rdfs:label : Physical Property</para>
    ///   <para>rdfs:comment : A physical property is an objective property over a physical system. (ie, a property pertains to the physical reality)</para>
    ///   <a href="https://w3id.org/mdo/core/PhysicalProperty">core:PhysicalProperty</a>
    /// </summary>
    let PhysicalProperty = _prefixId.prefix "PhysicalProperty"
    /// <summary>
    ///   <para>rdfs:label : Property</para>
    ///   <para>rdfs:comment : A property in materials design is data pertaining to at least one material or materials system.</para>
    ///   <a href="https://w3id.org/mdo/core/Property">core:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:label : property name</para>
    ///   <para>rdfs:comment : PropertyName represents that a property has the name in a string.</para>
    ///   <a href="https://w3id.org/mdo/core/PropertyName">core:PropertyName</a>
    /// </summary>
    let PropertyName = _prefixId.prefix "PropertyName"
    /// <summary>
    ///   <para>rdfs:label : Structure</para>
    ///   <para>rdfs:comment : A structure is the information of the sites and their occupancies in a material or materials system.</para>
    ///   <a href="https://w3id.org/mdo/core/Structure">core:Structure</a>
    /// </summary>
    let Structure = _prefixId.prefix "Structure"
    /// <summary>
    ///   <para>rdfs:label : has input property</para>
    ///   <para>rdfs:comment : hasInputProperty represents the relationship between a calculation and the properties it takes as input.</para>
    ///   <a href="https://w3id.org/mdo/core/hasInputProperty">core:hasInputProperty</a>
    /// </summary>
    let hasInputProperty = _prefixId.prefix "hasInputProperty"
    /// <summary>
    ///   <para>rdfs:label : has input structure</para>
    ///   <para>rdfs:comment : hasInputStructure represents the relationship between a calculation and the structures it takes as input.</para>
    ///   <a href="https://w3id.org/mdo/core/hasInputStructure">core:hasInputStructure</a>
    /// </summary>
    let hasInputStructure = _prefixId.prefix "hasInputStructure"
    /// <summary>
    ///   <para>rdfs:label : has output calculated property</para>
    ///   <para>rdfs:comment : hasOutputCalculatedProperty represents the relationship between a calculation and the calculated properties it outputs.</para>
    ///   <a href="https://w3id.org/mdo/core/hasOutputCalculatedProperty">core:hasOutputCalculatedProperty</a>
    /// </summary>
    let hasOutputCalculatedProperty = _prefixId.prefix "hasOutputCalculatedProperty"
    /// <summary>
    ///   <para>rdfs:label : has output structure</para>
    ///   <para>rdfs:comment : hasOutputStructure represents the relationship between a calculation and the structures it outputs.</para>
    ///   <a href="https://w3id.org/mdo/core/hasOutputStructure">core:hasOutputStructure</a>
    /// </summary>
    let hasOutputStructure = _prefixId.prefix "hasOutputStructure"
    /// <summary>
    ///   <para>rdfs:label : has quantity value</para>
    ///   <para>rdfs:comment : hasQuantityValue represents the relationship between a property and quantity value it takes.</para>
    ///   <a href="https://w3id.org/mdo/core/hasQuantityValue">core:hasQuantityValue</a>
    /// </summary>
    let hasQuantityValue = _prefixId.prefix "hasQuantityValue"
    /// <summary>
    ///   <para>rdfs:label : relates to material</para>
    ///   <para>rdfs:comment : relatesToMaterial represents the relationship between a structure and the materials it comes from.</para>
    ///   <a href="https://w3id.org/mdo/core/relatesToMaterial">core:relatesToMaterial</a>
    /// </summary>
    let relatesToMaterial = _prefixId.prefix "relatesToMaterial"
    /// <summary>
    ///   <para>rdfs:label : relates to structure</para>
    ///   <para>rdfs:comment : relatesToStructure represents the relationship between a property and the structures it comes from.</para>
    ///   <a href="https://w3id.org/mdo/core/relatesToStructure">core:relatesToStructure</a>
    /// </summary>
    let relatesToStructure = _prefixId.prefix "relatesToStructure"
