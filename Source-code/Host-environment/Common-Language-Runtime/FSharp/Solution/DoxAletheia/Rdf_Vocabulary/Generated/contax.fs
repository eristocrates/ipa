namespace https.w3id.org.con_tax.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module contax =
    let _namespace_iri = Namespace_Iri contax |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:con-tax#ConstructionComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object that forms, formed or has the potential to form a part of a construction. Use a more specific subclass from a dedicated taxonomy such as BEO/FURN/MEP based on IFC or AAT-ARCH/AAT-FURN/AAT-MEP based on the Getty AAT concepts related to constructions."</para>
    /// labels<para>"construction component"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#ConstructionComponent">https://w3id.org/con-tax#ConstructionComponent</seealso>
    let ConstructionComponent =
        Prefixed_Name(contax, "ConstructionComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#ConstructionSubComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A construction component that forms, formed or has the potential to form a part of another construction component. It can be distinguished from other types of construction components since they are, in normal situations, no individual components. An example are the steps and railings as sub components of a stairs component. Use a more specific subclass from a dedicated taxonomy such as BEO based on IFC or AAT-ARCH based on the Getty AAT concepts related to constructions."</para>
    /// labels<para>"construction sub component"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#ConstructionSubComponent">https://w3id.org/con-tax#ConstructionSubComponent</seealso>
    let ConstructionSubComponent =
        Prefixed_Name(contax, "ConstructionSubComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A material of which a construction component is made. It excludes subcomponents of larger construction components, e.g. a brick in a wall (see contax:ConstructionSubComponent)."</para>
    /// labels<para>"building material"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#Material">https://w3id.org/con-tax#Material</seealso>
    let Material = Prefixed_Name(contax, "Material") |> PrefixedName
    /// <summary>
    ///   <para>w3id:con-tax#PropertyContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"property context (grouping) "</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#PropertyContext">https://w3id.org/con-tax#PropertyContext</seealso>
    let PropertyContext = Prefixed_Name(contax, "PropertyContext") |> PrefixedName
    /// <summary>
    ///   <para>w3id:con-tax#containsConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Property to connect a gvp:GuideTerm instance to a class that is part of the main taxonomy hierarchy. The guide term represents a grouping of terms to provide alternative means for finding classes (object of this property) besides the main taxonomy hierarchy."</para>
    /// labels<para>"contains concept"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#containsConcept">https://w3id.org/con-tax#containsConcept</seealso>
    let containsConcept = Prefixed_Name(contax, "containsConcept") |> PrefixedName
    /// <summary>
    ///   <para>w3id:con-tax#containsGuideTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Property to connect a class that is based on a concept from the Getty AAT to a gvp:GuideTerm, i.e. an individual node that represents a grouping of terms to provide alternative means for finding classes besides the main taxonomy hierarchy. The guide term specializes a more general class from the taxonomy."</para>
    /// labels<para>"contains guide term "</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#containsGuideTerm">https://w3id.org/con-tax#containsGuideTerm</seealso>
    let containsGuideTerm = Prefixed_Name(contax, "containsGuideTerm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#domainOrSubjectIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An annotation property to connect a property definition to a class that is either in the domain of this property (instance property) or is a potential subject (or superclass of a potential subject) of this property (type property)."</para>
    /// labels<para>"domain or subject includes"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#domainOrSubjectIncludes">https://w3id.org/con-tax#domainOrSubjectIncludes</seealso>
    let domainOrSubjectIncludes =
        Prefixed_Name(contax, "domainOrSubjectIncludes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation to connect an object to the first intermediate node of a level 2 or 3 property when using approach 4 or 5 for assigning the property name."</para>
    /// labels<para>"has property"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#hasProperty">https://w3id.org/con-tax#hasProperty</seealso>
    let hasProperty = Prefixed_Name(contax, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:con-tax#hasPropertyContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has property context (grouping)"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#hasPropertyContext">https://w3id.org/con-tax#hasPropertyContext</seealso>
    let hasPropertyContext = Prefixed_Name(contax, "hasPropertyContext") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#isDerivedFromProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is derived from property "</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#isDerivedFromProperty">https://w3id.org/con-tax#isDerivedFromProperty</seealso>
    let isDerivedFromProperty =
        Prefixed_Name(contax, "isDerivedFromProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#isDerivedFromPropertyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is derived from property state"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#isDerivedFromPropertyState">https://w3id.org/con-tax#isDerivedFromPropertyState</seealso>
    let isDerivedFromPropertyState =
        Prefixed_Name(contax, "isDerivedFromPropertyState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#isRootOfTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Annotation property to store references to the known (external) taxonomies for root classes, properties or SKOS concepts defined or mentioned in ConTax. The URI of each taxonomy is the object of this property."</para>
    /// labels<para>"root of taxonomy"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#isRootOfTaxonomy">https://w3id.org/con-tax#isRootOfTaxonomy</seealso>
    let isRootOfTaxonomy = Prefixed_Name(contax, "isRootOfTaxonomy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#potentialInterventionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An annotation property used in taxonomies of damage types to connect a damage type class (subclass of dot:ClassifiedDamage) to a reparation task (subclass of cto:RepairTask)."</para>
    /// labels<para>"potential intervention type"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#potentialInterventionType">https://w3id.org/con-tax#potentialInterventionType</seealso>
    let potentialInterventionType =
        Prefixed_Name(contax, "potentialInterventionType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#potentialSubComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An annotation property used in taxonomies of construction components to connect a construction component type such as a stairs that can consists of smaller sub components such as railings and steps."</para>
    /// labels<para>"potential sub component"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#potentialSubComponent">https://w3id.org/con-tax#potentialSubComponent</seealso>
    let potentialSubComponent =
        Prefixed_Name(contax, "potentialSubComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#propertyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation to connect the first intermediate node of a level 2 or 3 property to its actual property name"</para>
    /// labels<para>"property name "</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#propertyName">https://w3id.org/con-tax#propertyName</seealso>
    let propertyName = Prefixed_Name(contax, "propertyName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:con-tax#property_DP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A root property for taxonomies of datatype properties. Subproperties should be defined from this base property to specify the type of property. Via this root property and its counterpart for object properties (contax:property_OP), it is possible to retrieve all properties of construction components, spatial zones, damages, etc. excluding the linking relations that form the construction topology, damage topology, etc."</para>
    /// labels<para>"property (datatype) "</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#property_DP">https://w3id.org/con-tax#property_DP</seealso>
    let property_DP = Prefixed_Name(contax, "property_DP") |> PrefixedName
    /// <summary>
    ///   <para>w3id:con-tax#property_OP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A root property for taxonomies of object properties. Subproperties should be defined from this base property to specify the type of property. Via this root property and its counterpart for datatype properties (contax:property_DP), it is possible to retrieve all properties of construction components, spatial zones, damages, etc. excluding the linking relations that form the construction topology, damage topology, etc."</para>
    /// labels<para>"property (object) "</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#property_OP">https://w3id.org/con-tax#property_OP</seealso>
    let property_OP = Prefixed_Name(contax, "property_OP") |> PrefixedName

    /// <summary>
    ///   <para>w3id:con-tax#rangeOrObjectIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An annotation property to connect a property definition to a class or datatype that is either in the range of this property (instance property) or is a potential object (or superclass of a potential object) of this property (type property). It can also refer to a skos:Concept node that represents a node in a SKOS taxonomy; this node and all its descendants (skos:narrower or inverse skos:broader) can be used as an object of the property (instance or type property). In the case of properties level 2 or 3, this property refers to the range or object for the generic schema:value property of the entire property pattern."</para>
    /// labels<para>"range or object includes"</para></remarks>
    /// <seealso href="https://w3id.org/con-tax#rangeOrObjectIncludes">https://w3id.org/con-tax#rangeOrObjectIncludes</seealso>
    let rangeOrObjectIncludes =
        Prefixed_Name(contax, "rangeOrObjectIncludes") |> PrefixedName
