namespace https.w3id.org.con_tax.hash

open DoxAletheia.Rdf_Vocabulary

module contax =
    let _namespace_name = "https://w3id.org/con-tax#"

    /// <summary>
    /// An object that forms, formed or has the potential to form a part of a construction. Use a more specific subclass from a dedicated taxonomy such as BEO/FURN/MEP based on IFC or AAT-ARCH/AAT-FURN/AAT-MEP based on the Getty AAT concepts related to constructions.
    /// <see href="https://w3id.org/con-tax#ConstructionComponent"></see></summary>
    let ConstructionComponent =
        Namespaced_IRI.parse _namespace_name "ConstructionComponent" |> NamespacedName

    /// <summary>
    /// A construction component that forms, formed or has the potential to form a part of another construction component. It can be distinguished from other types of construction components since they are, in normal situations, no individual components. An example are the steps and railings as sub components of a stairs component. Use a more specific subclass from a dedicated taxonomy such as BEO based on IFC or AAT-ARCH based on the Getty AAT concepts related to constructions.
    /// <see href="https://w3id.org/con-tax#ConstructionSubComponent"></see></summary>
    let ConstructionSubComponent =
        Namespaced_IRI.parse _namespace_name "ConstructionSubComponent" |> NamespacedName

    /// <summary>
    /// Annotation property to store references to the known (external) taxonomies for root classes, properties or SKOS concepts defined or mentioned in ConTax. The URI of each taxonomy is the object of this property.
    /// <see href="https://w3id.org/con-tax#isRootOfTaxonomy"></see></summary>
    let isRootOfTaxonomy =
        Namespaced_IRI.parse _namespace_name "isRootOfTaxonomy" |> NamespacedName

    /// <summary>
    /// A material of which a construction component is made. It excludes subcomponents of larger construction components, e.g. a brick in a wall (see contax:ConstructionSubComponent).
    /// <see href="https://w3id.org/con-tax#Material"></see></summary>
    let Material = Namespaced_IRI.parse _namespace_name "Material" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/con-tax#PropertyContext"></see>
    /// </summary>
    let PropertyContext =
        Namespaced_IRI.parse _namespace_name "PropertyContext" |> NamespacedName

    /// <summary>
    /// Property to connect a gvp:GuideTerm instance to a class that is part of the main taxonomy hierarchy. The guide term represents a grouping of terms to provide alternative means for finding classes (object of this property) besides the main taxonomy hierarchy.
    /// <see href="https://w3id.org/con-tax#containsConcept"></see></summary>
    let containsConcept =
        Namespaced_IRI.parse _namespace_name "containsConcept" |> NamespacedName

    /// <summary>
    /// Property to connect a class that is based on a concept from the Getty AAT to a gvp:GuideTerm, i.e. an individual node that represents a grouping of terms to provide alternative means for finding classes besides the main taxonomy hierarchy. The guide term specializes a more general class from the taxonomy.
    /// <see href="https://w3id.org/con-tax#containsGuideTerm"></see></summary>
    let containsGuideTerm =
        Namespaced_IRI.parse _namespace_name "containsGuideTerm" |> NamespacedName

    /// <summary>
    /// An annotation property to connect a property definition to a class that is either in the domain of this property (instance property) or is a potential subject (or superclass of a potential subject) of this property (type property).
    /// <see href="https://w3id.org/con-tax#domainOrSubjectIncludes"></see></summary>
    let domainOrSubjectIncludes =
        Namespaced_IRI.parse _namespace_name "domainOrSubjectIncludes" |> NamespacedName

    /// <summary>
    /// A relation to connect an object to the first intermediate node of a level 2 or 3 property when using approach 4 or 5 for assigning the property name.
    /// <see href="https://w3id.org/con-tax#hasProperty"></see></summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/con-tax#hasPropertyContext"></see>
    /// </summary>
    let hasPropertyContext =
        Namespaced_IRI.parse _namespace_name "hasPropertyContext" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/con-tax#isDerivedFromProperty"></see>
    /// </summary>
    let isDerivedFromProperty =
        Namespaced_IRI.parse _namespace_name "isDerivedFromProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/con-tax#isDerivedFromPropertyState"></see>
    /// </summary>
    let isDerivedFromPropertyState =
        Namespaced_IRI.parse _namespace_name "isDerivedFromPropertyState" |> NamespacedName

    /// <summary>
    /// An annotation property used in taxonomies of damage types to connect a damage type class (subclass of dot:ClassifiedDamage) to a reparation task (subclass of cto:RepairTask).
    /// <see href="https://w3id.org/con-tax#potentialInterventionType"></see></summary>
    let potentialInterventionType =
        Namespaced_IRI.parse _namespace_name "potentialInterventionType" |> NamespacedName

    /// <summary>
    /// An annotation property used in taxonomies of construction components to connect a construction component type such as a stairs that can consists of smaller sub components such as railings and steps.
    /// <see href="https://w3id.org/con-tax#potentialSubComponent"></see></summary>
    let potentialSubComponent =
        Namespaced_IRI.parse _namespace_name "potentialSubComponent" |> NamespacedName

    /// <summary>
    /// A relation to connect the first intermediate node of a level 2 or 3 property to its actual property name
    /// <see href="https://w3id.org/con-tax#propertyName"></see></summary>
    let propertyName =
        Namespaced_IRI.parse _namespace_name "propertyName" |> NamespacedName

    /// <summary>
    /// A root property for taxonomies of datatype properties. Subproperties should be defined from this base property to specify the type of property. Via this root property and its counterpart for object properties (contax:property_OP), it is possible to retrieve all properties of construction components, spatial zones, damages, etc. excluding the linking relations that form the construction topology, damage topology, etc.
    /// <see href="https://w3id.org/con-tax#property_DP"></see></summary>
    let property_DP =
        Namespaced_IRI.parse _namespace_name "property_DP" |> NamespacedName

    /// <summary>
    /// A root property for taxonomies of object properties. Subproperties should be defined from this base property to specify the type of property. Via this root property and its counterpart for datatype properties (contax:property_DP), it is possible to retrieve all properties of construction components, spatial zones, damages, etc. excluding the linking relations that form the construction topology, damage topology, etc.
    /// <see href="https://w3id.org/con-tax#property_OP"></see></summary>
    let property_OP =
        Namespaced_IRI.parse _namespace_name "property_OP" |> NamespacedName

    /// <summary>
    /// An annotation property to connect a property definition to a class or datatype that is either in the range of this property (instance property) or is a potential object (or superclass of a potential object) of this property (type property). It can also refer to a skos:Concept node that represents a node in a SKOS taxonomy; this node and all its descendants (skos:narrower or inverse skos:broader) can be used as an object of the property (instance or type property). In the case of properties level 2 or 3, this property refers to the range or object for the generic schema:value property of the entire property pattern.
    /// <see href="https://w3id.org/con-tax#rangeOrObjectIncludes"></see></summary>
    let rangeOrObjectIncludes =
        Namespaced_IRI.parse _namespace_name "rangeOrObjectIncludes" |> NamespacedName
