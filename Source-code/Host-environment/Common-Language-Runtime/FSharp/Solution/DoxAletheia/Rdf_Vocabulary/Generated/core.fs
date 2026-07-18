namespace https.w3id.org.mdo.core.slash

open DoxAletheia.Rdf_Vocabulary

module core =
    let _namespace_name = "https://w3id.org/mdo/core/"
    /// <summary>
    ///   <see href="https://w3id.org/mdo/core/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = Namespaced_IRI.parse _namespace_name "1.0/" |> NamespacedName

    /// <summary>
    /// A calculated property is a proprty that is a result from a calculation.
    /// <see href="https://w3id.org/mdo/core/CalculatedProperty"></see></summary>
    let CalculatedProperty =
        Namespaced_IRI.parse _namespace_name "CalculatedProperty" |> NamespacedName

    /// <summary>
    /// A property in materials design is data pertaining to at least one material or materials system.
    /// <see href="https://w3id.org/mdo/core/Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName

    /// <summary>
    /// A physical property is an objective property over a physical system. (ie, a property pertains to the physical reality)
    /// <see href="https://w3id.org/mdo/core/PhysicalProperty"></see></summary>
    let PhysicalProperty =
        Namespaced_IRI.parse _namespace_name "PhysicalProperty" |> NamespacedName

    /// <summary>
    /// A calculation is the use of a specific computational method to process structures and/or properties into output structures and/or calculated properties.
    /// <see href="https://w3id.org/mdo/core/Calculation"></see></summary>
    let Calculation =
        Namespaced_IRI.parse _namespace_name "Calculation" |> NamespacedName

    /// <summary>
    /// A structure is the information of the sites and their occupancies in a material or materials system.
    /// <see href="https://w3id.org/mdo/core/Structure"></see></summary>
    let Structure = Namespaced_IRI.parse _namespace_name "Structure" |> NamespacedName

    /// <summary>
    /// hasInputStructure represents the relationship between a calculation and the structures it takes as input.
    /// <see href="https://w3id.org/mdo/core/hasInputStructure"></see></summary>
    let hasInputStructure =
        Namespaced_IRI.parse _namespace_name "hasInputStructure" |> NamespacedName

    /// <summary>
    /// hasOutputStructure represents the relationship between a calculation and the structures it outputs.
    /// <see href="https://w3id.org/mdo/core/hasOutputStructure"></see></summary>
    let hasOutputStructure =
        Namespaced_IRI.parse _namespace_name "hasOutputStructure" |> NamespacedName

    /// <summary>
    /// hasInputProperty represents the relationship between a calculation and the properties it takes as input.
    /// <see href="https://w3id.org/mdo/core/hasInputProperty"></see></summary>
    let hasInputProperty =
        Namespaced_IRI.parse _namespace_name "hasInputProperty" |> NamespacedName

    /// <summary>
    /// hasOutputCalculatedProperty represents the relationship between a calculation and the calculated properties it outputs.
    /// <see href="https://w3id.org/mdo/core/hasOutputCalculatedProperty"></see></summary>
    let hasOutputCalculatedProperty =
        Namespaced_IRI.parse _namespace_name "hasOutputCalculatedProperty" |> NamespacedName

    /// <summary>
    /// ID represents that a calculation has the unique ID in a string.
    /// <see href="https://w3id.org/mdo/core/ID"></see></summary>
    let ID = Namespaced_IRI.parse _namespace_name "ID" |> NamespacedName

    /// <summary>
    /// PropertyName represents that a property has the name in a string.
    /// <see href="https://w3id.org/mdo/core/PropertyName"></see></summary>
    let PropertyName =
        Namespaced_IRI.parse _namespace_name "PropertyName" |> NamespacedName

    /// <summary>
    /// relatesToMaterial represents the relationship between a structure and the materials it comes from.
    /// <see href="https://w3id.org/mdo/core/relatesToMaterial"></see></summary>
    let relatesToMaterial =
        Namespaced_IRI.parse _namespace_name "relatesToMaterial" |> NamespacedName

    /// <summary>
    /// hasQuantityValue represents the relationship between a property and quantity value it takes.
    /// <see href="https://w3id.org/mdo/core/hasQuantityValue"></see></summary>
    let hasQuantityValue =
        Namespaced_IRI.parse _namespace_name "hasQuantityValue" |> NamespacedName

    /// <summary>
    /// relatesToStructure represents the relationship between a property and the structures it comes from.
    /// <see href="https://w3id.org/mdo/core/relatesToStructure"></see></summary>
    let relatesToStructure =
        Namespaced_IRI.parse _namespace_name "relatesToStructure" |> NamespacedName
