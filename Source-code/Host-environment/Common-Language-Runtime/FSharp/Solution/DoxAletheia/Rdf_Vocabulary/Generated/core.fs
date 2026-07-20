namespace https.w3id.org.mdo.core.slash

open DoxAletheia

module core =
    let _namespace_name = "https://w3id.org/mdo/core/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mdo/core/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = _prefix "1.0/"
    /// <summary>
    /// A calculated property is a proprty that is a result from a calculation.
    /// <see href="https://w3id.org/mdo/core/CalculatedProperty"></see></summary>
    let CalculatedProperty = _prefix "CalculatedProperty"
    /// <summary>
    /// A property in materials design is data pertaining to at least one material or materials system.
    /// <see href="https://w3id.org/mdo/core/Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// A physical property is an objective property over a physical system. (ie, a property pertains to the physical reality)
    /// <see href="https://w3id.org/mdo/core/PhysicalProperty"></see></summary>
    let PhysicalProperty = _prefix "PhysicalProperty"
    /// <summary>
    /// A calculation is the use of a specific computational method to process structures and/or properties into output structures and/or calculated properties.
    /// <see href="https://w3id.org/mdo/core/Calculation"></see></summary>
    let Calculation = _prefix "Calculation"
    /// <summary>
    /// A structure is the information of the sites and their occupancies in a material or materials system.
    /// <see href="https://w3id.org/mdo/core/Structure"></see></summary>
    let Structure = _prefix "Structure"
    /// <summary>
    /// hasInputStructure represents the relationship between a calculation and the structures it takes as input.
    /// <see href="https://w3id.org/mdo/core/hasInputStructure"></see></summary>
    let hasInputStructure = _prefix "hasInputStructure"
    /// <summary>
    /// hasOutputStructure represents the relationship between a calculation and the structures it outputs.
    /// <see href="https://w3id.org/mdo/core/hasOutputStructure"></see></summary>
    let hasOutputStructure = _prefix "hasOutputStructure"
    /// <summary>
    /// hasInputProperty represents the relationship between a calculation and the properties it takes as input.
    /// <see href="https://w3id.org/mdo/core/hasInputProperty"></see></summary>
    let hasInputProperty = _prefix "hasInputProperty"
    /// <summary>
    /// hasOutputCalculatedProperty represents the relationship between a calculation and the calculated properties it outputs.
    /// <see href="https://w3id.org/mdo/core/hasOutputCalculatedProperty"></see></summary>
    let hasOutputCalculatedProperty = _prefix "hasOutputCalculatedProperty"
    /// <summary>
    /// ID represents that a calculation has the unique ID in a string.
    /// <see href="https://w3id.org/mdo/core/ID"></see></summary>
    let ID = _prefix "ID"
    /// <summary>
    /// PropertyName represents that a property has the name in a string.
    /// <see href="https://w3id.org/mdo/core/PropertyName"></see></summary>
    let PropertyName = _prefix "PropertyName"
    /// <summary>
    /// relatesToMaterial represents the relationship between a structure and the materials it comes from.
    /// <see href="https://w3id.org/mdo/core/relatesToMaterial"></see></summary>
    let relatesToMaterial = _prefix "relatesToMaterial"
    /// <summary>
    /// hasQuantityValue represents the relationship between a property and quantity value it takes.
    /// <see href="https://w3id.org/mdo/core/hasQuantityValue"></see></summary>
    let hasQuantityValue = _prefix "hasQuantityValue"
    /// <summary>
    /// relatesToStructure represents the relationship between a property and the structures it comes from.
    /// <see href="https://w3id.org/mdo/core/relatesToStructure"></see></summary>
    let relatesToStructure = _prefix "relatesToStructure"
