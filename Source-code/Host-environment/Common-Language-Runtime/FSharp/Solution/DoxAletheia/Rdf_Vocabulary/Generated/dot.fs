namespace https.w3id.org.dot.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dot =
    let _namespace_iri = Namespace_Iri dot |> NamespaceIRI

    /// <summary>
    ///   <para>dot:documentationFromInspection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a Documentation and the Inspection to which the Documentation refers. Inverse object property of dot:hasDocumentation .</para>
    /// labels<para>documentation from inspection</para></remarks>
    /// <seealso href="https://w3id.org/dot#documentationFromInspection">https://w3id.org/dot#documentationFromInspection</seealso>
    let documentationFromInspection =
        Prefixed_Name(dot, "documentationFromInspection") |> PrefixedName

    /// <summary>
    ///   <para>dot:coveredInDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a Documentation and the relevant documented or inspected object (e.g. DamageArea or bot:Element). Should only be used for damage-relevant documentations.</para>
    /// labels<para>covered by documentation</para></remarks>
    /// <seealso href="https://w3id.org/dot#coveredInDocumentation">https://w3id.org/dot#coveredInDocumentation</seealso>
    let coveredInDocumentation =
        Prefixed_Name(dot, "coveredInDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>dot:DamagePattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines a group of associated or physically connected instances of DamageElement. Used as class for grouping inside an instance of DamageArea.</para>
    /// labels<para>Damage Pattern</para></remarks>
    /// <seealso href="https://w3id.org/dot#DamagePattern">https://w3id.org/dot#DamagePattern</seealso>
    let DamagePattern = Prefixed_Name(dot, "DamagePattern") |> PrefixedName
    /// <summary>
    ///   <para>dot:DamageElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Damage that is modeled on a very detailed level and belongs with other adjacent Damage Element instances to a broader damage area or damage pattern</para>
    /// labels<para>Damage Element</para></remarks>
    /// <seealso href="https://w3id.org/dot#DamageElement">https://w3id.org/dot#DamageElement</seealso>
    let DamageElement = Prefixed_Name(dot, "DamageElement") |> PrefixedName
    /// <summary>
    ///   <para>dot:Description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Short textual documentation about a Damage or Structure Element. Generally created by the inspecting person.</para>
    /// labels<para>Description</para></remarks>
    /// <seealso href="https://w3id.org/dot#Description">https://w3id.org/dot#Description</seealso>
    let Description = Prefixed_Name(dot, "Description") |> PrefixedName
    /// <summary>
    ///   <para>dot:ExternalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Document that is stored in a separate file, referenced by an external path.</para>
    /// labels<para>External Resource</para></remarks>
    /// <seealso href="https://w3id.org/dot#ExternalResource">https://w3id.org/dot#ExternalResource</seealso>
    let ExternalResource = Prefixed_Name(dot, "ExternalResource") |> PrefixedName
    /// <summary>
    ///   <para>dot:descriptionContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Textual content used for the Description of a Structure Element or Damage.</para>
    /// labels<para>description content</para></remarks>
    /// <seealso href="https://w3id.org/dot#descriptionContent">https://w3id.org/dot#descriptionContent</seealso>
    let descriptionContent = Prefixed_Name(dot, "descriptionContent") |> PrefixedName
    /// <summary>
    ///   <para>dot:filePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the unique location in a file system of an ExternalResource</para>
    /// labels<para>file path</para></remarks>
    /// <seealso href="https://w3id.org/dot#filePath">https://w3id.org/dot#filePath</seealso>
    let filePath = Prefixed_Name(dot, "filePath") |> PrefixedName
    /// <summary>
    ///   <para>dot:hasDamage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the relationship between an affected component or structure (e.g. bot:Element) and a Damage.</para>
    /// labels<para>has Damage</para></remarks>
    /// <seealso href="https://w3id.org/dot#hasDamage">https://w3id.org/dot#hasDamage</seealso>
    let hasDamage = Prefixed_Name(dot, "hasDamage") |> PrefixedName
    /// <summary>
    ///   <para>dot:hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an Inspection and the corresponding Documentation</para>
    /// labels<para>has documentation</para></remarks>
    /// <seealso href="https://w3id.org/dot#hasDocumentation">https://w3id.org/dot#hasDocumentation</seealso>
    let hasDocumentation = Prefixed_Name(dot, "hasDocumentation") |> PrefixedName
    /// <summary>
    ///   <para>dot:hasInspector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an Inspector and the Inspection that has been performed by him.</para>
    /// labels<para>has Inspector</para></remarks>
    /// <seealso href="https://w3id.org/dot#hasInspector">https://w3id.org/dot#hasInspector</seealso>
    let hasInspector = Prefixed_Name(dot, "hasInspector") |> PrefixedName
    /// <summary>
    ///   <para>dot:hasDamageArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the relationship between an affected component or structure (e.g. bot:Element) and a Damage Area.</para>
    /// labels<para>has Damage Area</para></remarks>
    /// <seealso href="https://w3id.org/dot#hasDamageArea">https://w3id.org/dot#hasDamageArea</seealso>
    let hasDamageArea = Prefixed_Name(dot, "hasDamageArea") |> PrefixedName
    /// <summary>
    ///   <para>dot:groupsDamageElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Groups instances of Damage Element that are physically connected in a Damage Pattern.</para>
    /// labels<para>groups Damage Element</para></remarks>
    /// <seealso href="https://w3id.org/dot#groupsDamageElement">https://w3id.org/dot#groupsDamageElement</seealso>
    let groupsDamageElement = Prefixed_Name(dot, "groupsDamageElement") |> PrefixedName

    /// <summary>
    ///   <para>dot:aggregatesDamageElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between an instance of Damage Area and its consisting Damage Element instance.</para>
    /// labels<para>aggregates Damage Element</para></remarks>
    /// <seealso href="https://w3id.org/dot#aggregatesDamageElement">https://w3id.org/dot#aggregatesDamageElement</seealso>
    let aggregatesDamageElement =
        Prefixed_Name(dot, "aggregatesDamageElement") |> PrefixedName

    /// <summary>
    ///   <para>dot:adjacentDamageElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the relationship between two instances of Damage Element that are physically connected with each other.</para>
    /// labels<para>adjacent Damage Element</para></remarks>
    /// <seealso href="https://w3id.org/dot#adjacentDamageElement">https://w3id.org/dot#adjacentDamageElement</seealso>
    let adjacentDamageElement =
        Prefixed_Name(dot, "adjacentDamageElement") |> PrefixedName

    /// <summary>
    ///   <para>dot:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>- Version 0.8:
    /// * completed ontology metadata wrt LOV
    /// * added classes dot:ClassifiedDamage and dot:UnclassifiedDamage (subclasses of dot:Damage)
    /// * made dot:StructuralDamage and dot:Defect subclasses of dot:Damage
    /// </para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dot#">https://w3id.org/dot#</seealso>
    let _prefix_iri = Prefixed_Name(dot, "") |> PrefixedName
    /// <summary>
    ///   <para>dot:Causation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the causation of a damage.
    /// Should be extended with domain-specific subclasses.</para>
    /// labels<para>Causation</para></remarks>
    /// <seealso href="https://w3id.org/dot#Causation">https://w3id.org/dot#Causation</seealso>
    let Causation = Prefixed_Name(dot, "Causation") |> PrefixedName
    /// <summary>
    ///   <para>dot:Damage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Damage is the harm to a structure resulting in impairment or loss of function, usefulness or value.
    /// Instead of using dot:Damage, it is recommended to use one subclass of dot:Damage for respectively the damage topology (either dot:DamageArea or dot:DamageElement), the
    /// potential structural impact (either dot:StructuralDamage or dot:Defect) and the damage classification (either dot:UnclassifiedDamage or subclasses of dot:ClassifiedDamage).</para>
    /// labels<para>Damage</para></remarks>
    /// <seealso href="https://w3id.org/dot#Damage">https://w3id.org/dot#Damage</seealso>
    let Damage = Prefixed_Name(dot, "Damage") |> PrefixedName
    /// <summary>
    ///   <para>dot:UnclassifiedDamage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A dot:Damage instance that is not further classified with domain-specific classes (subclasses of dot:ClassifiedDamage).
    /// This class can be used in cases where the damage classification is unknown.</para>
    /// labels<para>Unclassified Damage</para></remarks>
    /// <seealso href="https://w3id.org/dot#UnclassifiedDamage">https://w3id.org/dot#UnclassifiedDamage</seealso>
    let UnclassifiedDamage = Prefixed_Name(dot, "UnclassifiedDamage") |> PrefixedName
    /// <summary>
    ///   <para>dot:DamageArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Area in a component where damage is located. Holds collection of multiple DamageElements or DamagePatterns. Used to be attached with simplified geometry.</para>
    /// labels<para>Damage Area</para></remarks>
    /// <seealso href="https://w3id.org/dot#DamageArea">https://w3id.org/dot#DamageArea</seealso>
    let DamageArea = Prefixed_Name(dot, "DamageArea") |> PrefixedName
    /// <summary>
    ///   <para>dot:Defect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Should be used on nodes that are already classified as dot:DamageArea or dot:DamageElement.
    /// Damage that does not impair the structural integrity of the structure, but can still have influence on the durability, usability and / or value.</para>
    /// labels<para>Defect</para></remarks>
    /// <seealso href="https://w3id.org/dot#Defect">https://w3id.org/dot#Defect</seealso>
    let Defect = Prefixed_Name(dot, "Defect") |> PrefixedName
    /// <summary>
    ///   <para>dot:StructuralDamage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Should be used on nodes that are already classified as dot:DamageArea or dot:DamageElement.
    /// Damage that impairs the structural integrity of the structure.</para>
    /// labels<para>Structural Damage</para></remarks>
    /// <seealso href="https://w3id.org/dot#StructuralDamage">https://w3id.org/dot#StructuralDamage</seealso>
    let StructuralDamage = Prefixed_Name(dot, "StructuralDamage") |> PrefixedName
    /// <summary>
    ///   <para>dot:Inspection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Careful examination or scrutiny in which an existing construction or a part of it is inspected and detected damages are recorded.
    /// Should be repeated at regular time intervals.</para>
    /// labels<para>Inspection</para></remarks>
    /// <seealso href="https://w3id.org/dot#Inspection">https://w3id.org/dot#Inspection</seealso>
    let Inspection = Prefixed_Name(dot, "Inspection") |> PrefixedName
    /// <summary>
    ///   <para>dot:Inspector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person who inspects constructions (for damages) or whose task it is to carry out inspections on constructions.</para>
    /// labels<para>Inspector</para></remarks>
    /// <seealso href="https://w3id.org/dot#Inspector">https://w3id.org/dot#Inspector</seealso>
    let Inspector = Prefixed_Name(dot, "Inspector") |> PrefixedName
    /// <summary>
    ///   <para>dot:coveredByInspection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a documented object (damage or component / zone) and the Inspection in which the object has been covered.</para>
    /// labels<para>covered by inspection</para></remarks>
    /// <seealso href="https://w3id.org/dot#coveredByInspection">https://w3id.org/dot#coveredByInspection</seealso>
    let coveredByInspection = Prefixed_Name(dot, "coveredByInspection") |> PrefixedName

    /// <summary>
    ///   <para>dot:aggregatesDamagePattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between an instance of Damage Area and its consisting Damage Pattern instance.</para>
    /// labels<para>aggregates Damage Pattern</para></remarks>
    /// <seealso href="https://w3id.org/dot#aggregatesDamagePattern">https://w3id.org/dot#aggregatesDamagePattern</seealso>
    let aggregatesDamagePattern =
        Prefixed_Name(dot, "aggregatesDamagePattern") |> PrefixedName

    /// <summary>
    ///   <para>dot:ClassifiedDamage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A damage classification is used to denote the kind of damage. Subclasses of this class are defined in extensions
    /// 			  such as CDO (Concrete Damage Ontology), NSO (the Natural Stone Ontology), etc.</para>
    /// labels<para>Classified Damage</para></remarks>
    /// <seealso href="https://w3id.org/dot#ClassifiedDamage">https://w3id.org/dot#ClassifiedDamage</seealso>
    let ClassifiedDamage = Prefixed_Name(dot, "ClassifiedDamage") |> PrefixedName
    /// <summary>
    ///   <para>dot:Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Material or data that provides information or evidence about the structure and its components or that serves as a record. Should only be used for damage-related documentation.</para>
    /// labels<para>Damage Documentation</para></remarks>
    /// <seealso href="https://w3id.org/dot#Documentation">https://w3id.org/dot#Documentation</seealso>
    let Documentation = Prefixed_Name(dot, "Documentation") |> PrefixedName
    /// <summary>
    ///   <para>dot:hasCausation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a Damage and its Causation.</para>
    /// labels<para>has Causation</para></remarks>
    /// <seealso href="https://w3id.org/dot#hasCausation">https://w3id.org/dot#hasCausation</seealso>
    let hasCausation = Prefixed_Name(dot, "hasCausation") |> PrefixedName
    /// <summary>
    ///   <para>dot:hasDamageElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the relationship between an affected component or structure (e.g. bot:Element) and a Damage Element.</para>
    /// labels<para>has Damage Element</para></remarks>
    /// <seealso href="https://w3id.org/dot#hasDamageElement">https://w3id.org/dot#hasDamageElement</seealso>
    let hasDamageElement = Prefixed_Name(dot, "hasDamageElement") |> PrefixedName
