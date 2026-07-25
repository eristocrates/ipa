namespace https.w3id.org.mdo.core.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module core =
    let _namespace_iri = Namespace_Iri core |> NamespaceIRI
    /// <summary>
    ///   <para>core:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This is the core module in Materials Design Ontology.</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mdo/core/">https://w3id.org/mdo/core/</seealso>
    let _prefix_iri = Prefixed_Name(core, "") |> PrefixedName
    /// <summary>
    ///   <para>core:CalculatedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A calculated property is a proprty that is a result from a calculation.</para>
    /// labels<para>Calculated Property</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/CalculatedProperty">https://w3id.org/mdo/core/CalculatedProperty</seealso>
    let CalculatedProperty = Prefixed_Name(core, "CalculatedProperty") |> PrefixedName
    /// <summary>
    ///   <para>core:Structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A structure is the information of the sites and their occupancies in a material or materials system.</para>
    /// labels<para>Structure</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/Structure">https://w3id.org/mdo/core/Structure</seealso>
    let Structure = Prefixed_Name(core, "Structure") |> PrefixedName
    /// <summary>
    ///   <para>core:hasOutputStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasOutputStructure represents the relationship between a calculation and the structures it outputs.</para>
    /// labels<para>has output structure</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/hasOutputStructure">https://w3id.org/mdo/core/hasOutputStructure</seealso>
    let hasOutputStructure = Prefixed_Name(core, "hasOutputStructure") |> PrefixedName
    /// <summary>
    ///   <para>core:hasInputStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasInputStructure represents the relationship between a calculation and the structures it takes as input.</para>
    /// labels<para>has input structure</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/hasInputStructure">https://w3id.org/mdo/core/hasInputStructure</seealso>
    let hasInputStructure = Prefixed_Name(core, "hasInputStructure") |> PrefixedName

    /// <summary>
    ///   <para>core:hasOutputCalculatedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasOutputCalculatedProperty represents the relationship between a calculation and the calculated properties it outputs.</para>
    /// labels<para>has output calculated property</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/hasOutputCalculatedProperty">https://w3id.org/mdo/core/hasOutputCalculatedProperty</seealso>
    let hasOutputCalculatedProperty =
        Prefixed_Name(core, "hasOutputCalculatedProperty") |> PrefixedName

    /// <summary>
    ///   <para>core:PropertyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>PropertyName represents that a property has the name in a string.</para>
    /// labels<para>property name</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/PropertyName">https://w3id.org/mdo/core/PropertyName</seealso>
    let PropertyName = Prefixed_Name(core, "PropertyName") |> PrefixedName
    /// <summary>
    ///   <para>core:relatesToStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>relatesToStructure represents the relationship between a property and the structures it comes from.</para>
    /// labels<para>relates to structure</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/relatesToStructure">https://w3id.org/mdo/core/relatesToStructure</seealso>
    let relatesToStructure = Prefixed_Name(core, "relatesToStructure") |> PrefixedName
    /// <summary>
    ///   <para>core:relatesToMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>relatesToMaterial represents the relationship between a structure and the materials it comes from.</para>
    /// labels<para>relates to material</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/relatesToMaterial">https://w3id.org/mdo/core/relatesToMaterial</seealso>
    let relatesToMaterial = Prefixed_Name(core, "relatesToMaterial") |> PrefixedName
    /// <summary>
    ///   <para>core:1.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/mdo/core/1.0/">https://w3id.org/mdo/core/1.0/</seealso>
    let ``_1.0/`` = Prefixed_Name(core, "1.0/") |> PrefixedName
    /// <summary>
    ///   <para>core:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A property in materials design is data pertaining to at least one material or materials system.</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/Property">https://w3id.org/mdo/core/Property</seealso>
    let Property = Prefixed_Name(core, "Property") |> PrefixedName
    /// <summary>
    ///   <para>core:PhysicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical property is an objective property over a physical system. (ie, a property pertains to the physical reality)</para>
    /// labels<para>Physical Property</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/PhysicalProperty">https://w3id.org/mdo/core/PhysicalProperty</seealso>
    let PhysicalProperty = Prefixed_Name(core, "PhysicalProperty") |> PrefixedName
    /// <summary>
    ///   <para>core:Calculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A calculation is the use of a specific computational method to process structures and/or properties into output structures and/or calculated properties.</para>
    /// labels<para>Calculation</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/Calculation">https://w3id.org/mdo/core/Calculation</seealso>
    let Calculation = Prefixed_Name(core, "Calculation") |> PrefixedName
    /// <summary>
    ///   <para>core:hasInputProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasInputProperty represents the relationship between a calculation and the properties it takes as input.</para>
    /// labels<para>has input property</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/hasInputProperty">https://w3id.org/mdo/core/hasInputProperty</seealso>
    let hasInputProperty = Prefixed_Name(core, "hasInputProperty") |> PrefixedName
    /// <summary>
    ///   <para>core:ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ID represents that a calculation has the unique ID in a string.</para>
    /// labels<para>ID</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/ID">https://w3id.org/mdo/core/ID</seealso>
    let ID = Prefixed_Name(core, "ID") |> PrefixedName
    /// <summary>
    ///   <para>core:hasQuantityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasQuantityValue represents the relationship between a property and quantity value it takes.</para>
    /// labels<para>has quantity value</para></remarks>
    /// <seealso href="https://w3id.org/mdo/core/hasQuantityValue">https://w3id.org/mdo/core/hasQuantityValue</seealso>
    let hasQuantityValue = Prefixed_Name(core, "hasQuantityValue") |> PrefixedName
