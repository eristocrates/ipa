#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dot =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/dot#" "dot"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Causation</para>
    ///   <para>rdfs:comment : Represents the causation of a damage.
    /// Should be extended with domain-specific subclasses.</para>
    ///   <a href="https://w3id.org/dot#Causation">dot:Causation</a>
    /// </summary>
    let Causation = _prefixId.prefix "Causation"
    /// <summary>
    ///   <para>rdfs:label : Classified Damage</para>
    ///   <para>rdfs:comment : A damage classification is used to denote the kind of damage. Subclasses of this class are defined in extensions
    /// 			  such as CDO (Concrete Damage Ontology), NSO (the Natural Stone Ontology), etc.</para>
    ///   <a href="https://w3id.org/dot#ClassifiedDamage">dot:ClassifiedDamage</a>
    /// </summary>
    let ClassifiedDamage = _prefixId.prefix "ClassifiedDamage"
    /// <summary>
    ///   <para>rdfs:label : Damage</para>
    ///   <para>rdfs:comment : Damage is the harm to a structure resulting in impairment or loss of function, usefulness or value.
    /// Instead of using dot:Damage, it is recommended to use one subclass of dot:Damage for respectively the damage topology (either dot:DamageArea or dot:DamageElement), the
    /// potential structural impact (either dot:StructuralDamage or dot:Defect) and the damage classification (either dot:UnclassifiedDamage or subclasses of dot:ClassifiedDamage).</para>
    ///   <a href="https://w3id.org/dot#Damage">dot:Damage</a>
    /// </summary>
    let Damage = _prefixId.prefix "Damage"
    /// <summary>
    ///   <para>rdfs:label : Damage Area</para>
    ///   <para>rdfs:comment : Area in a component where damage is located. Holds collection of multiple DamageElements or DamagePatterns. Used to be attached with simplified geometry.</para>
    ///   <a href="https://w3id.org/dot#DamageArea">dot:DamageArea</a>
    /// </summary>
    let DamageArea = _prefixId.prefix "DamageArea"
    /// <summary>
    ///   <para>rdfs:label : Damage Element</para>
    ///   <para>rdfs:comment : Damage that is modeled on a very detailed level and belongs with other adjacent Damage Element instances to a broader damage area or damage pattern</para>
    ///   <a href="https://w3id.org/dot#DamageElement">dot:DamageElement</a>
    /// </summary>
    let DamageElement = _prefixId.prefix "DamageElement"
    /// <summary>
    ///   <para>rdfs:label : Damage Pattern</para>
    ///   <para>rdfs:comment : Defines a group of associated or physically connected instances of DamageElement. Used as class for grouping inside an instance of DamageArea.</para>
    ///   <a href="https://w3id.org/dot#DamagePattern">dot:DamagePattern</a>
    /// </summary>
    let DamagePattern = _prefixId.prefix "DamagePattern"
    /// <summary>
    ///   <para>rdfs:label : Defect</para>
    ///   <para>rdfs:comment : Should be used on nodes that are already classified as dot:DamageArea or dot:DamageElement.
    /// Damage that does not impair the structural integrity of the structure, but can still have influence on the durability, usability and / or value.</para>
    ///   <a href="https://w3id.org/dot#Defect">dot:Defect</a>
    /// </summary>
    let Defect = _prefixId.prefix "Defect"
    /// <summary>
    ///   <para>rdfs:label : Description</para>
    ///   <para>rdfs:comment : Short textual documentation about a Damage or Structure Element. Generally created by the inspecting person.</para>
    ///   <a href="https://w3id.org/dot#Description">dot:Description</a>
    /// </summary>
    let Description = _prefixId.prefix "Description"
    /// <summary>
    ///   <para>rdfs:label : Damage Documentation</para>
    ///   <para>rdfs:comment : Material or data that provides information or evidence about the structure and its components or that serves as a record. Should only be used for damage-related documentation.</para>
    ///   <a href="https://w3id.org/dot#Documentation">dot:Documentation</a>
    /// </summary>
    let Documentation = _prefixId.prefix "Documentation"
    /// <summary>
    ///   <para>rdfs:label : External Resource</para>
    ///   <para>rdfs:comment : Document that is stored in a separate file, referenced by an external path.</para>
    ///   <a href="https://w3id.org/dot#ExternalResource">dot:ExternalResource</a>
    /// </summary>
    let ExternalResource = _prefixId.prefix "ExternalResource"
    /// <summary>
    ///   <para>rdfs:label : Inspection</para>
    ///   <para>rdfs:comment : Careful examination or scrutiny in which an existing construction or a part of it is inspected and detected damages are recorded.
    /// Should be repeated at regular time intervals.</para>
    ///   <a href="https://w3id.org/dot#Inspection">dot:Inspection</a>
    /// </summary>
    let Inspection = _prefixId.prefix "Inspection"
    /// <summary>
    ///   <para>rdfs:label : Inspector</para>
    ///   <para>rdfs:comment : A person who inspects constructions (for damages) or whose task it is to carry out inspections on constructions.</para>
    ///   <a href="https://w3id.org/dot#Inspector">dot:Inspector</a>
    /// </summary>
    let Inspector = _prefixId.prefix "Inspector"
    /// <summary>
    ///   <para>rdfs:label : Structural Damage</para>
    ///   <para>rdfs:comment : Should be used on nodes that are already classified as dot:DamageArea or dot:DamageElement.
    /// Damage that impairs the structural integrity of the structure.</para>
    ///   <a href="https://w3id.org/dot#StructuralDamage">dot:StructuralDamage</a>
    /// </summary>
    let StructuralDamage = _prefixId.prefix "StructuralDamage"
    /// <summary>
    ///   <para>rdfs:label : Unclassified Damage</para>
    ///   <para>rdfs:comment : A dot:Damage instance that is not further classified with domain-specific classes (subclasses of dot:ClassifiedDamage).
    /// This class can be used in cases where the damage classification is unknown.</para>
    ///   <a href="https://w3id.org/dot#UnclassifiedDamage">dot:UnclassifiedDamage</a>
    /// </summary>
    let UnclassifiedDamage = _prefixId.prefix "UnclassifiedDamage"
    /// <summary>
    ///   <para>rdfs:label : adjacent Damage Element</para>
    ///   <para>rdfs:comment : Defines the relationship between two instances of Damage Element that are physically connected with each other.</para>
    ///   <a href="https://w3id.org/dot#adjacentDamageElement">dot:adjacentDamageElement</a>
    /// </summary>
    let adjacentDamageElement = _prefixId.prefix "adjacentDamageElement"
    /// <summary>
    ///   <para>rdfs:label : aggregates Damage Element</para>
    ///   <para>rdfs:comment : A relationship between an instance of Damage Area and its consisting Damage Element instance.</para>
    ///   <a href="https://w3id.org/dot#aggregatesDamageElement">dot:aggregatesDamageElement</a>
    /// </summary>
    let aggregatesDamageElement = _prefixId.prefix "aggregatesDamageElement"
    /// <summary>
    ///   <para>rdfs:label : aggregates Damage Pattern</para>
    ///   <para>rdfs:comment : A relationship between an instance of Damage Area and its consisting Damage Pattern instance.</para>
    ///   <a href="https://w3id.org/dot#aggregatesDamagePattern">dot:aggregatesDamagePattern</a>
    /// </summary>
    let aggregatesDamagePattern = _prefixId.prefix "aggregatesDamagePattern"
    /// <summary>
    ///   <para>rdfs:comment : Relationship between a documented object (damage or component / zone) and the Inspection in which the object has been covered.</para>
    ///   <para>rdfs:label : covered by inspection</para>
    ///   <a href="https://w3id.org/dot#coveredByInspection">dot:coveredByInspection</a>
    /// </summary>
    let coveredByInspection = _prefixId.prefix "coveredByInspection"
    /// <summary>
    ///   <para>rdfs:comment : Relationship between a Documentation and the relevant documented or inspected object (e.g. DamageArea or bot:Element). Should only be used for damage-relevant documentations.</para>
    ///   <para>rdfs:label : covered by documentation</para>
    ///   <a href="https://w3id.org/dot#coveredInDocumentation">dot:coveredInDocumentation</a>
    /// </summary>
    let coveredInDocumentation = _prefixId.prefix "coveredInDocumentation"
    /// <summary>
    ///   <para>rdfs:label : description content</para>
    ///   <para>rdfs:comment : Textual content used for the Description of a Structure Element or Damage.</para>
    ///   <a href="https://w3id.org/dot#descriptionContent">dot:descriptionContent</a>
    /// </summary>
    let descriptionContent = _prefixId.prefix "descriptionContent"
    /// <summary>
    ///   <para>rdfs:label : documentation from inspection</para>
    ///   <para>rdfs:comment : Relationship between a Documentation and the Inspection to which the Documentation refers. Inverse object property of dot:hasDocumentation .</para>
    ///   <a href="https://w3id.org/dot#documentationFromInspection">dot:documentationFromInspection</a>
    /// </summary>
    let documentationFromInspection = _prefixId.prefix "documentationFromInspection"
    /// <summary>
    ///   <para>rdfs:label : file path</para>
    ///   <para>rdfs:comment : Defines the unique location in a file system of an ExternalResource</para>
    ///   <a href="https://w3id.org/dot#filePath">dot:filePath</a>
    /// </summary>
    let filePath = _prefixId.prefix "filePath"
    /// <summary>
    ///   <para>rdfs:label : groups Damage Element</para>
    ///   <para>rdfs:comment : Groups instances of Damage Element that are physically connected in a Damage Pattern.</para>
    ///   <a href="https://w3id.org/dot#groupsDamageElement">dot:groupsDamageElement</a>
    /// </summary>
    let groupsDamageElement = _prefixId.prefix "groupsDamageElement"
    /// <summary>
    ///   <para>rdfs:label : has Causation</para>
    ///   <para>rdfs:comment : Relationship between a Damage and its Causation.</para>
    ///   <a href="https://w3id.org/dot#hasCausation">dot:hasCausation</a>
    /// </summary>
    let hasCausation = _prefixId.prefix "hasCausation"
    /// <summary>
    ///   <para>rdfs:label : has Damage</para>
    ///   <para>rdfs:comment : Defines the relationship between an affected component or structure (e.g. bot:Element) and a Damage.</para>
    ///   <a href="https://w3id.org/dot#hasDamage">dot:hasDamage</a>
    /// </summary>
    let hasDamage = _prefixId.prefix "hasDamage"
    /// <summary>
    ///   <para>rdfs:label : has Damage Area</para>
    ///   <para>rdfs:comment : Defines the relationship between an affected component or structure (e.g. bot:Element) and a Damage Area.</para>
    ///   <a href="https://w3id.org/dot#hasDamageArea">dot:hasDamageArea</a>
    /// </summary>
    let hasDamageArea = _prefixId.prefix "hasDamageArea"
    /// <summary>
    ///   <para>rdfs:label : has Damage Element</para>
    ///   <para>rdfs:comment : Defines the relationship between an affected component or structure (e.g. bot:Element) and a Damage Element.</para>
    ///   <a href="https://w3id.org/dot#hasDamageElement">dot:hasDamageElement</a>
    /// </summary>
    let hasDamageElement = _prefixId.prefix "hasDamageElement"
    /// <summary>
    ///   <para>rdfs:label : has documentation</para>
    ///   <para>rdfs:comment : Relationship between an Inspection and the corresponding Documentation</para>
    ///   <a href="https://w3id.org/dot#hasDocumentation">dot:hasDocumentation</a>
    /// </summary>
    let hasDocumentation = _prefixId.prefix "hasDocumentation"
    /// <summary>
    ///   <para>rdfs:label : has Inspector</para>
    ///   <para>rdfs:comment : Relationship between an Inspector and the Inspection that has been performed by him.</para>
    ///   <a href="https://w3id.org/dot#hasInspector">dot:hasInspector</a>
    /// </summary>
    let hasInspector = _prefixId.prefix "hasInspector"
