namespace https.w3id.org.dot.hash

open DoxAletheia.Rdf_Vocabulary

module dot =
    let _namespace_name = "https://w3id.org/dot#"

    /// <summary>
    /// Relationship between a Documentation and the relevant documented or inspected object (e.g. DamageArea or bot:Element). Should only be used for damage-relevant documentations.
    /// <see href="https://w3id.org/dot#coveredInDocumentation"></see></summary>
    let coveredInDocumentation =
        Namespaced_IRI.parse _namespace_name "coveredInDocumentation" |> NamespacedName

    /// <summary>
    /// Relationship between a Documentation and the Inspection to which the Documentation refers. Inverse object property of dot:hasDocumentation .
    /// <see href="https://w3id.org/dot#documentationFromInspection"></see></summary>
    let documentationFromInspection =
        Namespaced_IRI.parse _namespace_name "documentationFromInspection" |> NamespacedName

    /// <summary>
    /// Defines the relationship between an affected component or structure (e.g. bot:Element) and a Damage Area.
    /// <see href="https://w3id.org/dot#hasDamageArea"></see></summary>
    let hasDamageArea =
        Namespaced_IRI.parse _namespace_name "hasDamageArea" |> NamespacedName

    /// <summary>
    /// A relationship between an instance of Damage Area and its consisting Damage Element instance.
    /// <see href="https://w3id.org/dot#aggregatesDamageElement"></see></summary>
    let aggregatesDamageElement =
        Namespaced_IRI.parse _namespace_name "aggregatesDamageElement" |> NamespacedName

    /// <summary>
    /// Groups instances of Damage Element that are physically connected in a Damage Pattern.
    /// <see href="https://w3id.org/dot#groupsDamageElement"></see></summary>
    let groupsDamageElement =
        Namespaced_IRI.parse _namespace_name "groupsDamageElement" |> NamespacedName

    /// <summary>
    /// Defines the relationship between two instances of Damage Element that are physically connected with each other.
    /// <see href="https://w3id.org/dot#adjacentDamageElement"></see></summary>
    let adjacentDamageElement =
        Namespaced_IRI.parse _namespace_name "adjacentDamageElement" |> NamespacedName

    /// <summary>
    /// A relationship between an instance of Damage Area and its consisting Damage Pattern instance.
    /// <see href="https://w3id.org/dot#aggregatesDamagePattern"></see></summary>
    let aggregatesDamagePattern =
        Namespaced_IRI.parse _namespace_name "aggregatesDamagePattern" |> NamespacedName

    /// <summary>
    /// Represents the causation of a damage.
    /// Should be extended with domain-specific subclasses.
    /// <see href="https://w3id.org/dot#Causation"></see></summary>
    let Causation = Namespaced_IRI.parse _namespace_name "Causation" |> NamespacedName

    /// <summary>
    /// A damage classification is used to denote the kind of damage. Subclasses of this class are defined in extensions
    /// 			  such as CDO (Concrete Damage Ontology), NSO (the Natural Stone Ontology), etc.
    /// <see href="https://w3id.org/dot#ClassifiedDamage"></see></summary>
    let ClassifiedDamage =
        Namespaced_IRI.parse _namespace_name "ClassifiedDamage" |> NamespacedName

    /// <summary>
    /// Damage is the harm to a structure resulting in impairment or loss of function, usefulness or value.
    /// Instead of using dot:Damage, it is recommended to use one subclass of dot:Damage for respectively the damage topology (either dot:DamageArea or dot:DamageElement), the
    /// potential structural impact (either dot:StructuralDamage or dot:Defect) and the damage classification (either dot:UnclassifiedDamage or subclasses of dot:ClassifiedDamage).
    /// <see href="https://w3id.org/dot#Damage"></see></summary>
    let Damage = Namespaced_IRI.parse _namespace_name "Damage" |> NamespacedName

    /// <summary>
    /// A dot:Damage instance that is not further classified with domain-specific classes (subclasses of dot:ClassifiedDamage).
    /// This class can be used in cases where the damage classification is unknown.
    /// <see href="https://w3id.org/dot#UnclassifiedDamage"></see></summary>
    let UnclassifiedDamage =
        Namespaced_IRI.parse _namespace_name "UnclassifiedDamage" |> NamespacedName

    /// <summary>
    /// Area in a component where damage is located. Holds collection of multiple DamageElements or DamagePatterns. Used to be attached with simplified geometry.
    /// <see href="https://w3id.org/dot#DamageArea"></see></summary>
    let DamageArea = Namespaced_IRI.parse _namespace_name "DamageArea" |> NamespacedName

    /// <summary>
    /// Defines a group of associated or physically connected instances of DamageElement. Used as class for grouping inside an instance of DamageArea.
    /// <see href="https://w3id.org/dot#DamagePattern"></see></summary>
    let DamagePattern =
        Namespaced_IRI.parse _namespace_name "DamagePattern" |> NamespacedName

    /// <summary>
    /// Damage that is modeled on a very detailed level and belongs with other adjacent Damage Element instances to a broader damage area or damage pattern
    /// <see href="https://w3id.org/dot#DamageElement"></see></summary>
    let DamageElement =
        Namespaced_IRI.parse _namespace_name "DamageElement" |> NamespacedName

    /// <summary>
    /// Should be used on nodes that are already classified as dot:DamageArea or dot:DamageElement.
    /// Damage that does not impair the structural integrity of the structure, but can still have influence on the durability, usability and / or value.
    /// <see href="https://w3id.org/dot#Defect"></see></summary>
    let Defect = Namespaced_IRI.parse _namespace_name "Defect" |> NamespacedName

    /// <summary>
    /// Should be used on nodes that are already classified as dot:DamageArea or dot:DamageElement.
    /// Damage that impairs the structural integrity of the structure.
    /// <see href="https://w3id.org/dot#StructuralDamage"></see></summary>
    let StructuralDamage =
        Namespaced_IRI.parse _namespace_name "StructuralDamage" |> NamespacedName

    /// <summary>
    /// Short textual documentation about a Damage or Structure Element. Generally created by the inspecting person.
    /// <see href="https://w3id.org/dot#Description"></see></summary>
    let Description =
        Namespaced_IRI.parse _namespace_name "Description" |> NamespacedName

    /// <summary>
    /// Material or data that provides information or evidence about the structure and its components or that serves as a record. Should only be used for damage-related documentation.
    /// <see href="https://w3id.org/dot#Documentation"></see></summary>
    let Documentation =
        Namespaced_IRI.parse _namespace_name "Documentation" |> NamespacedName

    /// <summary>
    /// Document that is stored in a separate file, referenced by an external path.
    /// <see href="https://w3id.org/dot#ExternalResource"></see></summary>
    let ExternalResource =
        Namespaced_IRI.parse _namespace_name "ExternalResource" |> NamespacedName

    /// <summary>
    /// Careful examination or scrutiny in which an existing construction or a part of it is inspected and detected damages are recorded.
    /// Should be repeated at regular time intervals.
    /// <see href="https://w3id.org/dot#Inspection"></see></summary>
    let Inspection = Namespaced_IRI.parse _namespace_name "Inspection" |> NamespacedName
    /// <summary>
    /// A person who inspects constructions (for damages) or whose task it is to carry out inspections on constructions.
    /// <see href="https://w3id.org/dot#Inspector"></see></summary>
    let Inspector = Namespaced_IRI.parse _namespace_name "Inspector" |> NamespacedName

    /// <summary>
    /// Relationship between a documented object (damage or component / zone) and the Inspection in which the object has been covered.
    /// <see href="https://w3id.org/dot#coveredByInspection"></see></summary>
    let coveredByInspection =
        Namespaced_IRI.parse _namespace_name "coveredByInspection" |> NamespacedName

    /// <summary>
    /// Textual content used for the Description of a Structure Element or Damage.
    /// <see href="https://w3id.org/dot#descriptionContent"></see></summary>
    let descriptionContent =
        Namespaced_IRI.parse _namespace_name "descriptionContent" |> NamespacedName

    /// <summary>
    /// Defines the unique location in a file system of an ExternalResource
    /// <see href="https://w3id.org/dot#filePath"></see></summary>
    let filePath = Namespaced_IRI.parse _namespace_name "filePath" |> NamespacedName

    /// <summary>
    /// Relationship between a Damage and its Causation.
    /// <see href="https://w3id.org/dot#hasCausation"></see></summary>
    let hasCausation =
        Namespaced_IRI.parse _namespace_name "hasCausation" |> NamespacedName

    /// <summary>
    /// Defines the relationship between an affected component or structure (e.g. bot:Element) and a Damage.
    /// <see href="https://w3id.org/dot#hasDamage"></see></summary>
    let hasDamage = Namespaced_IRI.parse _namespace_name "hasDamage" |> NamespacedName

    /// <summary>
    /// Defines the relationship between an affected component or structure (e.g. bot:Element) and a Damage Element.
    /// <see href="https://w3id.org/dot#hasDamageElement"></see></summary>
    let hasDamageElement =
        Namespaced_IRI.parse _namespace_name "hasDamageElement" |> NamespacedName

    /// <summary>
    /// Relationship between an Inspection and the corresponding Documentation
    /// <see href="https://w3id.org/dot#hasDocumentation"></see></summary>
    let hasDocumentation =
        Namespaced_IRI.parse _namespace_name "hasDocumentation" |> NamespacedName

    /// <summary>
    /// Relationship between an Inspector and the Inspection that has been performed by him.
    /// <see href="https://w3id.org/dot#hasInspector"></see></summary>
    let hasInspector =
        Namespaced_IRI.parse _namespace_name "hasInspector" |> NamespacedName
