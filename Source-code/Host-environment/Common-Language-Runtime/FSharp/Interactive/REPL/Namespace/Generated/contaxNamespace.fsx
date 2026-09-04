#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module contax =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/con-tax#" "contax"
    /// <summary>
    ///   <para>rdfs:comment : An object that forms, formed or has the potential to form a part of a construction. Use a more specific subclass from a dedicated taxonomy such as BEO/FURN/MEP based on IFC or AAT-ARCH/AAT-FURN/AAT-MEP based on the Getty AAT concepts related to constructions.</para>
    ///   <para>rdfs:label : construction component</para>
    ///   <a href="https://w3id.org/con-tax#ConstructionComponent">contax:ConstructionComponent</a>
    /// </summary>
    let ConstructionComponent = _prefixId.prefix "ConstructionComponent"
    /// <summary>
    ///   <para>rdfs:label : construction sub component</para>
    ///   <para>rdfs:comment : A construction component that forms, formed or has the potential to form a part of another construction component. It can be distinguished from other types of construction components since they are, in normal situations, no individual components. An example are the steps and railings as sub components of a stairs component. Use a more specific subclass from a dedicated taxonomy such as BEO based on IFC or AAT-ARCH based on the Getty AAT concepts related to constructions.</para>
    ///   <a href="https://w3id.org/con-tax#ConstructionSubComponent">contax:ConstructionSubComponent</a>
    /// </summary>
    let ConstructionSubComponent = _prefixId.prefix "ConstructionSubComponent"
    /// <summary>
    ///   <para>rdfs:label : building material</para>
    ///   <para>rdfs:comment : A material of which a construction component is made. It excludes subcomponents of larger construction components, e.g. a brick in a wall (see contax:ConstructionSubComponent).</para>
    ///   <a href="https://w3id.org/con-tax#Material">contax:Material</a>
    /// </summary>
    let Material = _prefixId.prefix "Material"
    /// <summary>
    ///   <para>rdfs:label : property context (grouping) </para>
    ///   <a href="https://w3id.org/con-tax#PropertyContext">contax:PropertyContext</a>
    /// </summary>
    let PropertyContext = _prefixId.prefix "PropertyContext"
    /// <summary>
    ///   <para>rdfs:label : contains concept</para>
    ///   <para>rdfs:comment : Property to connect a gvp:GuideTerm instance to a class that is part of the main taxonomy hierarchy. The guide term represents a grouping of terms to provide alternative means for finding classes (object of this property) besides the main taxonomy hierarchy.</para>
    ///   <a href="https://w3id.org/con-tax#containsConcept">contax:containsConcept</a>
    /// </summary>
    let containsConcept = _prefixId.prefix "containsConcept"
    /// <summary>
    ///   <para>rdfs:label : contains guide term </para>
    ///   <para>rdfs:comment : Property to connect a class that is based on a concept from the Getty AAT to a gvp:GuideTerm, i.e. an individual node that represents a grouping of terms to provide alternative means for finding classes besides the main taxonomy hierarchy. The guide term specializes a more general class from the taxonomy.</para>
    ///   <a href="https://w3id.org/con-tax#containsGuideTerm">contax:containsGuideTerm</a>
    /// </summary>
    let containsGuideTerm = _prefixId.prefix "containsGuideTerm"
    /// <summary>
    ///   <para>rdfs:label : domain or subject includes</para>
    ///   <para>rdfs:comment : An annotation property to connect a property definition to a class that is either in the domain of this property (instance property) or is a potential subject (or superclass of a potential subject) of this property (type property).</para>
    ///   <a href="https://w3id.org/con-tax#domainOrSubjectIncludes">contax:domainOrSubjectIncludes</a>
    /// </summary>
    let domainOrSubjectIncludes = _prefixId.prefix "domainOrSubjectIncludes"
    /// <summary>
    ///   <para>rdfs:label : has property</para>
    ///   <para>rdfs:comment : A relation to connect an object to the first intermediate node of a level 2 or 3 property when using approach 4 or 5 for assigning the property name.</para>
    ///   <a href="https://w3id.org/con-tax#hasProperty">contax:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
    /// <summary>
    ///   <para>rdfs:label : has property context (grouping)</para>
    ///   <a href="https://w3id.org/con-tax#hasPropertyContext">contax:hasPropertyContext</a>
    /// </summary>
    let hasPropertyContext = _prefixId.prefix "hasPropertyContext"
    /// <summary>
    ///   <para>rdfs:label : is derived from property </para>
    ///   <a href="https://w3id.org/con-tax#isDerivedFromProperty">contax:isDerivedFromProperty</a>
    /// </summary>
    let isDerivedFromProperty = _prefixId.prefix "isDerivedFromProperty"
    /// <summary>
    ///   <para>rdfs:label : is derived from property state</para>
    ///   <a href="https://w3id.org/con-tax#isDerivedFromPropertyState">contax:isDerivedFromPropertyState</a>
    /// </summary>
    let isDerivedFromPropertyState = _prefixId.prefix "isDerivedFromPropertyState"
    /// <summary>
    ///   <para>rdfs:comment : Annotation property to store references to the known (external) taxonomies for root classes, properties or SKOS concepts defined or mentioned in ConTax. The URI of each taxonomy is the object of this property.</para>
    ///   <para>rdfs:label : root of taxonomy</para>
    ///   <a href="https://w3id.org/con-tax#isRootOfTaxonomy">contax:isRootOfTaxonomy</a>
    /// </summary>
    let isRootOfTaxonomy = _prefixId.prefix "isRootOfTaxonomy"
    /// <summary>
    ///   <para>rdfs:label : potential intervention type</para>
    ///   <para>rdfs:comment : An annotation property used in taxonomies of damage types to connect a damage type class (subclass of dot:ClassifiedDamage) to a reparation task (subclass of cto:RepairTask).</para>
    ///   <a href="https://w3id.org/con-tax#potentialInterventionType">contax:potentialInterventionType</a>
    /// </summary>
    let potentialInterventionType = _prefixId.prefix "potentialInterventionType"
    /// <summary>
    ///   <para>rdfs:label : potential sub component</para>
    ///   <para>rdfs:comment : An annotation property used in taxonomies of construction components to connect a construction component type such as a stairs that can consists of smaller sub components such as railings and steps.</para>
    ///   <a href="https://w3id.org/con-tax#potentialSubComponent">contax:potentialSubComponent</a>
    /// </summary>
    let potentialSubComponent = _prefixId.prefix "potentialSubComponent"
    /// <summary>
    ///   <para>rdfs:label : property name </para>
    ///   <para>rdfs:comment : A relation to connect the first intermediate node of a level 2 or 3 property to its actual property name</para>
    ///   <a href="https://w3id.org/con-tax#propertyName">contax:propertyName</a>
    /// </summary>
    let propertyName = _prefixId.prefix "propertyName"
    /// <summary>
    ///   <para>rdfs:label : property (datatype) </para>
    ///   <para>rdfs:comment : A root property for taxonomies of datatype properties. Subproperties should be defined from this base property to specify the type of property. Via this root property and its counterpart for object properties (contax:property_OP), it is possible to retrieve all properties of construction components, spatial zones, damages, etc. excluding the linking relations that form the construction topology, damage topology, etc.</para>
    ///   <a href="https://w3id.org/con-tax#property_DP">contax:property_DP</a>
    /// </summary>
    let property_DP = _prefixId.prefix "property_DP"
    /// <summary>
    ///   <para>rdfs:label : property (object) </para>
    ///   <para>rdfs:comment : A root property for taxonomies of object properties. Subproperties should be defined from this base property to specify the type of property. Via this root property and its counterpart for datatype properties (contax:property_DP), it is possible to retrieve all properties of construction components, spatial zones, damages, etc. excluding the linking relations that form the construction topology, damage topology, etc.</para>
    ///   <a href="https://w3id.org/con-tax#property_OP">contax:property_OP</a>
    /// </summary>
    let property_OP = _prefixId.prefix "property_OP"
    /// <summary>
    ///   <para>rdfs:label : range or object includes</para>
    ///   <para>rdfs:comment : An annotation property to connect a property definition to a class or datatype that is either in the range of this property (instance property) or is a potential object (or superclass of a potential object) of this property (type property). It can also refer to a skos:Concept node that represents a node in a SKOS taxonomy; this node and all its descendants (skos:narrower or inverse skos:broader) can be used as an object of the property (instance or type property). In the case of properties level 2 or 3, this property refers to the range or object for the generic schema:value property of the entire property pattern.</para>
    ///   <a href="https://w3id.org/con-tax#rangeOrObjectIncludes">contax:rangeOrObjectIncludes</a>
    /// </summary>
    let rangeOrObjectIncludes = _prefixId.prefix "rangeOrObjectIncludes"
