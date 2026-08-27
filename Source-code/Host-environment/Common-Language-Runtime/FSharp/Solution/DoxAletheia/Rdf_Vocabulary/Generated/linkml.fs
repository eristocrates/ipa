namespace https.w3id.org.linkml.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module linkml =
    let _namespace_iri = Namespace_Iri linkml |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:linkml/ABSENT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/ABSENT">https://w3id.org/linkml/ABSENT</seealso>
    let ABSENT = Prefixed_Name(linkml, "ABSENT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/AClassDefinition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/AClassDefinition">https://w3id.org/linkml/AClassDefinition</seealso>
    let AClassDefinition = Prefixed_Name(linkml, "AClassDefinition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/AliasPredicateEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/EnumDefinition</para>
    ///
    /// labels<para>"alias_predicate_enum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/AliasPredicateEnum">https://w3id.org/linkml/AliasPredicateEnum</seealso>
    let AliasPredicateEnum = Prefixed_Name(linkml, "AliasPredicateEnum") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/AltDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"alt_description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/AltDescription">https://w3id.org/linkml/AltDescription</seealso>
    let AltDescription = Prefixed_Name(linkml, "AltDescription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Annotatable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"annotatable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Annotatable">https://w3id.org/linkml/Annotatable</seealso>
    let Annotatable = Prefixed_Name(linkml, "Annotatable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"annotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Annotation">https://w3id.org/linkml/Annotation</seealso>
    let Annotation = Prefixed_Name(linkml, "Annotation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/AnonymousClassExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anonymous_class_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/AnonymousClassExpression">https://w3id.org/linkml/AnonymousClassExpression</seealso>
    let AnonymousClassExpression =
        Prefixed_Name(linkml, "AnonymousClassExpression") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/AnonymousEnumExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anonymous_enum_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/AnonymousEnumExpression">https://w3id.org/linkml/AnonymousEnumExpression</seealso>
    let AnonymousEnumExpression =
        Prefixed_Name(linkml, "AnonymousEnumExpression") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/AnonymousExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"anonymous_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/AnonymousExpression">https://w3id.org/linkml/AnonymousExpression</seealso>
    let AnonymousExpression =
        Prefixed_Name(linkml, "AnonymousExpression") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/AnonymousSlotExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"anonymous_slot_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/AnonymousSlotExpression">https://w3id.org/linkml/AnonymousSlotExpression</seealso>
    let AnonymousSlotExpression =
        Prefixed_Name(linkml, "AnonymousSlotExpression") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/AnonymousTypeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anonymous_type_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/AnonymousTypeExpression">https://w3id.org/linkml/AnonymousTypeExpression</seealso>
    let AnonymousTypeExpression =
        Prefixed_Name(linkml, "AnonymousTypeExpression") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/Any</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/Any">https://w3id.org/linkml/Any</seealso>
    let Any = Prefixed_Name(linkml, "Any") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/AnyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AnyValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/AnyValue">https://w3id.org/linkml/AnyValue</seealso>
    let AnyValue = Prefixed_Name(linkml, "AnyValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Anything</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"Anything"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Anything">https://w3id.org/linkml/Anything</seealso>
    let Anything = Prefixed_Name(linkml, "Anything") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ArrayExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"array_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ArrayExpression">https://w3id.org/linkml/ArrayExpression</seealso>
    let ArrayExpression = Prefixed_Name(linkml, "ArrayExpression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/BROAD_SYNONYM</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/BROAD_SYNONYM">https://w3id.org/linkml/BROAD_SYNONYM</seealso>
    let BROAD_SYNONYM = Prefixed_Name(linkml, "BROAD_SYNONYM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/BasicSubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SubsetDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/BasicSubset">https://w3id.org/linkml/BasicSubset</seealso>
    let BasicSubset = Prefixed_Name(linkml, "BasicSubset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Boolean</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/Boolean">https://w3id.org/linkml/Boolean</seealso>
    let Boolean = Prefixed_Name(linkml, "Boolean") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/CODE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/CODE">https://w3id.org/linkml/CODE</seealso>
    let CODE = Prefixed_Name(linkml, "CODE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/CURIE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/CURIE">https://w3id.org/linkml/CURIE</seealso>
    let CURIE = Prefixed_Name(linkml, "CURIE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ClassDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"class_definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ClassDefinition">https://w3id.org/linkml/ClassDefinition</seealso>
    let ClassDefinition = Prefixed_Name(linkml, "ClassDefinition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ClassExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"class_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ClassExpression">https://w3id.org/linkml/ClassExpression</seealso>
    let ClassExpression = Prefixed_Name(linkml, "ClassExpression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ClassLevelRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"class_level_rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ClassLevelRule">https://w3id.org/linkml/ClassLevelRule</seealso>
    let ClassLevelRule = Prefixed_Name(linkml, "ClassLevelRule") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ClassRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"class_rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ClassRule">https://w3id.org/linkml/ClassRule</seealso>
    let ClassRule = Prefixed_Name(linkml, "ClassRule") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/CommonMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"common_metadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/CommonMetadata">https://w3id.org/linkml/CommonMetadata</seealso>
    let CommonMetadata = Prefixed_Name(linkml, "CommonMetadata") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/CounterExample</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/CounterExample">https://w3id.org/linkml/CounterExample</seealso>
    let CounterExample = Prefixed_Name(linkml, "CounterExample") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/DISCOURAGED</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/DISCOURAGED">https://w3id.org/linkml/DISCOURAGED</seealso>
    let DISCOURAGED = Prefixed_Name(linkml, "DISCOURAGED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/DataPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/DataPackage">https://w3id.org/linkml/DataPackage</seealso>
    let DataPackage = Prefixed_Name(linkml, "DataPackage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/DataResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/DataResource">https://w3id.org/linkml/DataResource</seealso>
    let DataResource = Prefixed_Name(linkml, "DataResource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Datetime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/Datetime">https://w3id.org/linkml/Datetime</seealso>
    let Datetime = Prefixed_Name(linkml, "Datetime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Definition">https://w3id.org/linkml/Definition</seealso>
    let Definition = Prefixed_Name(linkml, "Definition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/DimensionExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dimension_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/DimensionExpression">https://w3id.org/linkml/DimensionExpression</seealso>
    let DimensionExpression =
        Prefixed_Name(linkml, "DimensionExpression") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/ERROR</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/ERROR">https://w3id.org/linkml/ERROR</seealso>
    let ERROR = Prefixed_Name(linkml, "ERROR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/EXACT_SYNONYM</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/EXACT_SYNONYM">https://w3id.org/linkml/EXACT_SYNONYM</seealso>
    let EXACT_SYNONYM = Prefixed_Name(linkml, "EXACT_SYNONYM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/EXAMPLE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/EXAMPLE">https://w3id.org/linkml/EXAMPLE</seealso>
    let EXAMPLE = Prefixed_Name(linkml, "EXAMPLE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Element">https://w3id.org/linkml/Element</seealso>
    let Element = Prefixed_Name(linkml, "Element") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/EnumBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"enum_binding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/EnumBinding">https://w3id.org/linkml/EnumBinding</seealso>
    let EnumBinding = Prefixed_Name(linkml, "EnumBinding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/EnumDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"enum_definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/EnumDefinition">https://w3id.org/linkml/EnumDefinition</seealso>
    let EnumDefinition = Prefixed_Name(linkml, "EnumDefinition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/EnumExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"enum_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/EnumExpression">https://w3id.org/linkml/EnumExpression</seealso>
    let EnumExpression = Prefixed_Name(linkml, "EnumExpression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"example"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Example">https://w3id.org/linkml/Example</seealso>
    let Example = Prefixed_Name(linkml, "Example") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Expression">https://w3id.org/linkml/Expression</seealso>
    let Expression = Prefixed_Name(linkml, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Extensible</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"extensible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Extensible">https://w3id.org/linkml/Extensible</seealso>
    let Extensible = Prefixed_Name(linkml, "Extensible") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"extension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Extension">https://w3id.org/linkml/Extension</seealso>
    let Extension = Prefixed_Name(linkml, "Extension") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/ExtraSlotsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"extra_slots_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ExtraSlotsExpression">https://w3id.org/linkml/ExtraSlotsExpression</seealso>
    let ExtraSlotsExpression =
        Prefixed_Name(linkml, "ExtraSlotsExpression") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/FATAL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/FATAL">https://w3id.org/linkml/FATAL</seealso>
    let FATAL = Prefixed_Name(linkml, "FATAL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/FHIR_CODING</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/FHIR_CODING">https://w3id.org/linkml/FHIR_CODING</seealso>
    let FHIR_CODING = Prefixed_Name(linkml, "FHIR_CODING") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/FormatDialect</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/FormatDialect">https://w3id.org/linkml/FormatDialect</seealso>
    let FormatDialect = Prefixed_Name(linkml, "FormatDialect") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/FormatEnum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/FormatEnum">https://w3id.org/linkml/FormatEnum</seealso>
    let FormatEnum = Prefixed_Name(linkml, "FormatEnum") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/INFO</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/INFO">https://w3id.org/linkml/INFO</seealso>
    let INFO = Prefixed_Name(linkml, "INFO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ImportExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"import_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ImportExpression">https://w3id.org/linkml/ImportExpression</seealso>
    let ImportExpression = Prefixed_Name(linkml, "ImportExpression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Information</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/Information">https://w3id.org/linkml/Information</seealso>
    let Information = Prefixed_Name(linkml, "Information") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Integer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/Integer">https://w3id.org/linkml/Integer</seealso>
    let Integer = Prefixed_Name(linkml, "Integer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/JSON</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/JSON">https://w3id.org/linkml/JSON</seealso>
    let JSON = Prefixed_Name(linkml, "JSON") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/JSON-LD</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/JSON-LD">https://w3id.org/linkml/JSON-LD</seealso>
    let JSON_LD = Prefixed_Name(linkml, "JSON-LD") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/LABEL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/LABEL">https://w3id.org/linkml/LABEL</seealso>
    let LABEL = Prefixed_Name(linkml, "LABEL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/LD%20Patch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/LD%20Patch">https://w3id.org/linkml/LD%20Patch</seealso>
    let ``LD%20Patch`` = Prefixed_Name(linkml, "LD%20Patch") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/LocalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"local_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/LocalName">https://w3id.org/linkml/LocalName</seealso>
    let LocalName = Prefixed_Name(linkml, "LocalName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/MatchQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"match_query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/MatchQuery">https://w3id.org/linkml/MatchQuery</seealso>
    let MatchQuery = Prefixed_Name(linkml, "MatchQuery") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/MediaTypeEnum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/MediaTypeEnum">https://w3id.org/linkml/MediaTypeEnum</seealso>
    let MediaTypeEnum = Prefixed_Name(linkml, "MediaTypeEnum") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Microdata</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/Microdata">https://w3id.org/linkml/Microdata</seealso>
    let Microdata = Prefixed_Name(linkml, "Microdata") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/MinimalSubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SubsetDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/MinimalSubset">https://w3id.org/linkml/MinimalSubset</seealso>
    let MinimalSubset = Prefixed_Name(linkml, "MinimalSubset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/N-Quads</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/N-Quads">https://w3id.org/linkml/N-Quads</seealso>
    let N_Quads = Prefixed_Name(linkml, "N-Quads") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/N-Triples</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/N-Triples">https://w3id.org/linkml/N-Triples</seealso>
    let N_Triples = Prefixed_Name(linkml, "N-Triples") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/N3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/N3">https://w3id.org/linkml/N3</seealso>
    let N3 = Prefixed_Name(linkml, "N3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/NARROW_SYNONYM</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/NARROW_SYNONYM">https://w3id.org/linkml/NARROW_SYNONYM</seealso>
    let NARROW_SYNONYM = Prefixed_Name(linkml, "NARROW_SYNONYM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/NODE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/NODE">https://w3id.org/linkml/NODE</seealso>
    let NODE = Prefixed_Name(linkml, "NODE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Ncname</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/Ncname">https://w3id.org/linkml/Ncname</seealso>
    let Ncname = Prefixed_Name(linkml, "Ncname") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/OBJECT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/OBJECT">https://w3id.org/linkml/OBJECT</seealso>
    let OBJECT = Prefixed_Name(linkml, "OBJECT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/OPTIONAL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/OPTIONAL">https://w3id.org/linkml/OPTIONAL</seealso>
    let OPTIONAL = Prefixed_Name(linkml, "OPTIONAL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/OTHER_ROLE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/OTHER_ROLE">https://w3id.org/linkml/OTHER_ROLE</seealso>
    let OTHER_ROLE = Prefixed_Name(linkml, "OTHER_ROLE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/OWL%20Functional%20Syntax</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/OWL%20Functional%20Syntax">https://w3id.org/linkml/OWL%20Functional%20Syntax</seealso>
    let ``OWL%20Functional%20Syntax`` =
        Prefixed_Name(linkml, "OWL%20Functional%20Syntax") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/OWL%20Manchester%20Syntax</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/OWL%20Manchester%20Syntax">https://w3id.org/linkml/OWL%20Manchester%20Syntax</seealso>
    let ``OWL%20Manchester%20Syntax`` =
        Prefixed_Name(linkml, "OWL%20Manchester%20Syntax") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/OWL%20XML%20Serialization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/OWL%20XML%20Serialization">https://w3id.org/linkml/OWL%20XML%20Serialization</seealso>
    let ``OWL%20XML%20Serialization`` =
        Prefixed_Name(linkml, "OWL%20XML%20Serialization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/ObjectOrientedProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SubsetDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/ObjectOrientedProfile">https://w3id.org/linkml/ObjectOrientedProfile</seealso>
    let ObjectOrientedProfile =
        Prefixed_Name(linkml, "ObjectOrientedProfile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/ObligationLevelEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/EnumDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obligation_level_enum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ObligationLevelEnum">https://w3id.org/linkml/ObligationLevelEnum</seealso>
    let ObligationLevelEnum =
        Prefixed_Name(linkml, "ObligationLevelEnum") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/ObligationLevelEnum#DISCOURAGED</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ObligationLevelEnum</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DISCOURAGED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ObligationLevelEnum#DISCOURAGED">https://w3id.org/linkml/ObligationLevelEnum#DISCOURAGED</seealso>
    let ``ObligationLevelEnum#DISCOURAGED`` =
        Prefixed_Name(linkml, "ObligationLevelEnum#DISCOURAGED") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/ObligationLevelEnum#EXAMPLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ObligationLevelEnum</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EXAMPLE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ObligationLevelEnum#EXAMPLE">https://w3id.org/linkml/ObligationLevelEnum#EXAMPLE</seealso>
    let ``ObligationLevelEnum#EXAMPLE`` =
        Prefixed_Name(linkml, "ObligationLevelEnum#EXAMPLE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/ObligationLevelEnum#OPTIONAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ObligationLevelEnum</para>
    ///
    /// labels<para>"OPTIONAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ObligationLevelEnum#OPTIONAL">https://w3id.org/linkml/ObligationLevelEnum#OPTIONAL</seealso>
    let ``ObligationLevelEnum#OPTIONAL`` =
        Prefixed_Name(linkml, "ObligationLevelEnum#OPTIONAL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/ObligationLevelEnum#RECOMMENDED</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ObligationLevelEnum</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RECOMMENDED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ObligationLevelEnum#RECOMMENDED">https://w3id.org/linkml/ObligationLevelEnum#RECOMMENDED</seealso>
    let ``ObligationLevelEnum#RECOMMENDED`` =
        Prefixed_Name(linkml, "ObligationLevelEnum#RECOMMENDED") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/ObligationLevelEnum#REQUIRED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ObligationLevelEnum</para>
    ///
    /// labels<para>"REQUIRED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ObligationLevelEnum#REQUIRED">https://w3id.org/linkml/ObligationLevelEnum#REQUIRED</seealso>
    let ``ObligationLevelEnum#REQUIRED`` =
        Prefixed_Name(linkml, "ObligationLevelEnum#REQUIRED") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/OwlProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SubsetDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/OwlProfile">https://w3id.org/linkml/OwlProfile</seealso>
    let OwlProfile = Prefixed_Name(linkml, "OwlProfile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/POWDER">https://w3id.org/linkml/POWDER</seealso>
    let POWDER = Prefixed_Name(linkml, "POWDER") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/POWDER-S</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/POWDER-S">https://w3id.org/linkml/POWDER-S</seealso>
    let POWDER_S = Prefixed_Name(linkml, "POWDER-S") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/PREDICATE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/PREDICATE">https://w3id.org/linkml/PREDICATE</seealso>
    let PREDICATE = Prefixed_Name(linkml, "PREDICATE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/PRESENT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/PRESENT">https://w3id.org/linkml/PRESENT</seealso>
    let PRESENT = Prefixed_Name(linkml, "PRESENT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/PROV-N</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/PROV-N">https://w3id.org/linkml/PROV-N</seealso>
    let PROV_N = Prefixed_Name(linkml, "PROV-N") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/PROV-XML</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/PROV-XML">https://w3id.org/linkml/PROV-XML</seealso>
    let PROV_XML = Prefixed_Name(linkml, "PROV-XML") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/PathExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"path_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PathExpression">https://w3id.org/linkml/PathExpression</seealso>
    let PathExpression = Prefixed_Name(linkml, "PathExpression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/PatternExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pattern_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PatternExpression">https://w3id.org/linkml/PatternExpression</seealso>
    let PatternExpression = Prefixed_Name(linkml, "PatternExpression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/PermissibleValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"permissible_value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PermissibleValue">https://w3id.org/linkml/PermissibleValue</seealso>
    let PermissibleValue = Prefixed_Name(linkml, "PermissibleValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Prefix">https://w3id.org/linkml/Prefix</seealso>
    let Prefix = Prefixed_Name(linkml, "Prefix") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/PresenceEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/EnumDefinition</para>
    ///
    /// labels<para>"presence_enum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PresenceEnum">https://w3id.org/linkml/PresenceEnum</seealso>
    let PresenceEnum = Prefixed_Name(linkml, "PresenceEnum") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/PresenceEnum#ABSENT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/PresenceEnum</para>
    ///
    /// labels<para>"ABSENT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PresenceEnum#ABSENT">https://w3id.org/linkml/PresenceEnum#ABSENT</seealso>
    let ``PresenceEnum#ABSENT`` =
        Prefixed_Name(linkml, "PresenceEnum#ABSENT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/PresenceEnum#PRESENT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/PresenceEnum</para>
    ///
    /// labels<para>"PRESENT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PresenceEnum#PRESENT">https://w3id.org/linkml/PresenceEnum#PRESENT</seealso>
    let ``PresenceEnum#PRESENT`` =
        Prefixed_Name(linkml, "PresenceEnum#PRESENT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/PresenceEnum#UNCOMMITTED</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/PresenceEnum</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UNCOMMITTED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PresenceEnum#UNCOMMITTED">https://w3id.org/linkml/PresenceEnum#UNCOMMITTED</seealso>
    let ``PresenceEnum#UNCOMMITTED`` =
        Prefixed_Name(linkml, "PresenceEnum#UNCOMMITTED") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/PvFormulaOptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/EnumDefinition</para>
    ///
    /// labels<para>"pv_formula_options"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PvFormulaOptions">https://w3id.org/linkml/PvFormulaOptions</seealso>
    let PvFormulaOptions = Prefixed_Name(linkml, "PvFormulaOptions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/PvFormulaOptions#CODE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/PvFormulaOptions</para>
    ///
    /// labels<para>"CODE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PvFormulaOptions#CODE">https://w3id.org/linkml/PvFormulaOptions#CODE</seealso>
    let ``PvFormulaOptions#CODE`` =
        Prefixed_Name(linkml, "PvFormulaOptions#CODE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/PvFormulaOptions#CURIE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/PvFormulaOptions</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CURIE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PvFormulaOptions#CURIE">https://w3id.org/linkml/PvFormulaOptions#CURIE</seealso>
    let ``PvFormulaOptions#CURIE`` =
        Prefixed_Name(linkml, "PvFormulaOptions#CURIE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/PvFormulaOptions#FHIR_CODING</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/PvFormulaOptions</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FHIR_CODING"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PvFormulaOptions#FHIR_CODING">https://w3id.org/linkml/PvFormulaOptions#FHIR_CODING</seealso>
    let ``PvFormulaOptions#FHIR_CODING`` =
        Prefixed_Name(linkml, "PvFormulaOptions#FHIR_CODING") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/PvFormulaOptions#LABEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/PvFormulaOptions</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LABEL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PvFormulaOptions#LABEL">https://w3id.org/linkml/PvFormulaOptions#LABEL</seealso>
    let ``PvFormulaOptions#LABEL`` =
        Prefixed_Name(linkml, "PvFormulaOptions#LABEL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/PvFormulaOptions#URI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/PvFormulaOptions</para>
    ///
    /// labels<para>"URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/PvFormulaOptions#URI">https://w3id.org/linkml/PvFormulaOptions#URI</seealso>
    let ``PvFormulaOptions#URI`` =
        Prefixed_Name(linkml, "PvFormulaOptions#URI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/RDF/JSON</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/RDF/JSON">https://w3id.org/linkml/RDF/JSON</seealso>
    let ``RDF/JSON`` = Prefixed_Name(linkml, "RDF/JSON") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/RDF/XML</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/RDF/XML">https://w3id.org/linkml/RDF/XML</seealso>
    let ``RDF/XML`` = Prefixed_Name(linkml, "RDF/XML") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/RDFa</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/RDFa">https://w3id.org/linkml/RDFa</seealso>
    let RDFa = Prefixed_Name(linkml, "RDFa") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/RECOMMENDED</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/RECOMMENDED">https://w3id.org/linkml/RECOMMENDED</seealso>
    let RECOMMENDED = Prefixed_Name(linkml, "RECOMMENDED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/RELATED_SYNONYM</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/RELATED_SYNONYM">https://w3id.org/linkml/RELATED_SYNONYM</seealso>
    let RELATED_SYNONYM = Prefixed_Name(linkml, "RELATED_SYNONYM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/REQUIRED</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/REQUIRED">https://w3id.org/linkml/REQUIRED</seealso>
    let REQUIRED = Prefixed_Name(linkml, "REQUIRED") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/RIF%20XML%20Syntax</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/RIF%20XML%20Syntax">https://w3id.org/linkml/RIF%20XML%20Syntax</seealso>
    let ``RIF%20XML%20Syntax`` =
        Prefixed_Name(linkml, "RIF%20XML%20Syntax") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/ReachabilityQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reachability_query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ReachabilityQuery">https://w3id.org/linkml/ReachabilityQuery</seealso>
    let ReachabilityQuery = Prefixed_Name(linkml, "ReachabilityQuery") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/RelationalModelProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SubsetDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/RelationalModelProfile">https://w3id.org/linkml/RelationalModelProfile</seealso>
    let RelationalModelProfile =
        Prefixed_Name(linkml, "RelationalModelProfile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/RelationalRoleEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/EnumDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relational_role_enum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/RelationalRoleEnum">https://w3id.org/linkml/RelationalRoleEnum</seealso>
    let RelationalRoleEnum = Prefixed_Name(linkml, "RelationalRoleEnum") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/RelationalRoleEnum#NODE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/RelationalRoleEnum</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NODE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/RelationalRoleEnum#NODE">https://w3id.org/linkml/RelationalRoleEnum#NODE</seealso>
    let ``RelationalRoleEnum#NODE`` =
        Prefixed_Name(linkml, "RelationalRoleEnum#NODE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/RelationalRoleEnum#OTHER_ROLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/RelationalRoleEnum</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OTHER_ROLE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/RelationalRoleEnum#OTHER_ROLE">https://w3id.org/linkml/RelationalRoleEnum#OTHER_ROLE</seealso>
    let ``RelationalRoleEnum#OTHER_ROLE`` =
        Prefixed_Name(linkml, "RelationalRoleEnum#OTHER_ROLE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/SPARQL%20Results%20in%20CSV</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/SPARQL%20Results%20in%20CSV">https://w3id.org/linkml/SPARQL%20Results%20in%20CSV</seealso>
    let ``SPARQL%20Results%20in%20CSV`` =
        Prefixed_Name(linkml, "SPARQL%20Results%20in%20CSV") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/SPARQL%20Results%20in%20JSON</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/SPARQL%20Results%20in%20JSON">https://w3id.org/linkml/SPARQL%20Results%20in%20JSON</seealso>
    let ``SPARQL%20Results%20in%20JSON`` =
        Prefixed_Name(linkml, "SPARQL%20Results%20in%20JSON") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/SPARQL%20Results%20in%20TSV</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/SPARQL%20Results%20in%20TSV">https://w3id.org/linkml/SPARQL%20Results%20in%20TSV</seealso>
    let ``SPARQL%20Results%20in%20TSV`` =
        Prefixed_Name(linkml, "SPARQL%20Results%20in%20TSV") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/SPARQL%20Results%20in%20XML</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/SPARQL%20Results%20in%20XML">https://w3id.org/linkml/SPARQL%20Results%20in%20XML</seealso>
    let ``SPARQL%20Results%20in%20XML`` =
        Prefixed_Name(linkml, "SPARQL%20Results%20in%20XML") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/SUBJECT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/SUBJECT">https://w3id.org/linkml/SUBJECT</seealso>
    let SUBJECT = Prefixed_Name(linkml, "SUBJECT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/SchemaDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"schema_definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/SchemaDefinition">https://w3id.org/linkml/SchemaDefinition</seealso>
    let SchemaDefinition = Prefixed_Name(linkml, "SchemaDefinition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Setting</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"setting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/Setting">https://w3id.org/linkml/Setting</seealso>
    let Setting = Prefixed_Name(linkml, "Setting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"slot_definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/SlotDefinition">https://w3id.org/linkml/SlotDefinition</seealso>
    let SlotDefinition = Prefixed_Name(linkml, "SlotDefinition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/SlotExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"slot_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/SlotExpression">https://w3id.org/linkml/SlotExpression</seealso>
    let SlotExpression = Prefixed_Name(linkml, "SlotExpression") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/SpecificationSubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SubsetDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/SpecificationSubset">https://w3id.org/linkml/SpecificationSubset</seealso>
    let SpecificationSubset =
        Prefixed_Name(linkml, "SpecificationSubset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/String</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/String">https://w3id.org/linkml/String</seealso>
    let String = Prefixed_Name(linkml, "String") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/StructuredAlias</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structured_alias"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/StructuredAlias">https://w3id.org/linkml/StructuredAlias</seealso>
    let StructuredAlias = Prefixed_Name(linkml, "StructuredAlias") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/SubsetDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"subset_definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/SubsetDefinition">https://w3id.org/linkml/SubsetDefinition</seealso>
    let SubsetDefinition = Prefixed_Name(linkml, "SubsetDefinition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/TestRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/TestRole">https://w3id.org/linkml/TestRole</seealso>
    let TestRole = Prefixed_Name(linkml, "TestRole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/TriG</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/TriG">https://w3id.org/linkml/TriG</seealso>
    let TriG = Prefixed_Name(linkml, "TriG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Turtle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/Turtle">https://w3id.org/linkml/Turtle</seealso>
    let Turtle = Prefixed_Name(linkml, "Turtle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///
    /// labels<para>"type_definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/TypeDefinition">https://w3id.org/linkml/TypeDefinition</seealso>
    let TypeDefinition = Prefixed_Name(linkml, "TypeDefinition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/TypeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"type_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/TypeExpression">https://w3id.org/linkml/TypeExpression</seealso>
    let TypeExpression = Prefixed_Name(linkml, "TypeExpression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/TypeMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"type_mapping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/TypeMapping">https://w3id.org/linkml/TypeMapping</seealso>
    let TypeMapping = Prefixed_Name(linkml, "TypeMapping") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/UNCOMMITTED</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/UNCOMMITTED">https://w3id.org/linkml/UNCOMMITTED</seealso>
    let UNCOMMITTED = Prefixed_Name(linkml, "UNCOMMITTED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/URI</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/URI">https://w3id.org/linkml/URI</seealso>
    let URI = Prefixed_Name(linkml, "URI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/UniqueKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unique_key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/UniqueKey">https://w3id.org/linkml/UniqueKey</seealso>
    let UniqueKey = Prefixed_Name(linkml, "UniqueKey") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/UnitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/AnonymousClassExpression</para>
    ///   <para>w3id:linkml/ClassDefinition</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UnitOfMeasure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/UnitOfMeasure">https://w3id.org/linkml/UnitOfMeasure</seealso>
    let UnitOfMeasure = Prefixed_Name(linkml, "UnitOfMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/UnitOfMeasure_exact_mappings</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/UnitOfMeasure_exact_mappings">https://w3id.org/linkml/UnitOfMeasure_exact_mappings</seealso>
    let UnitOfMeasure_exact_mappings =
        Prefixed_Name(linkml, "UnitOfMeasure_exact_mappings") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/Uri</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/Uri">https://w3id.org/linkml/Uri</seealso>
    let Uri = Prefixed_Name(linkml, "Uri") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/Uriorcurie</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/Uriorcurie">https://w3id.org/linkml/Uriorcurie</seealso>
    let Uriorcurie = Prefixed_Name(linkml, "Uriorcurie") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ValidationReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/ValidationReport">https://w3id.org/linkml/ValidationReport</seealso>
    let ValidationReport = Prefixed_Name(linkml, "ValidationReport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ValidationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/ValidationResult">https://w3id.org/linkml/ValidationResult</seealso>
    let ValidationResult = Prefixed_Name(linkml, "ValidationResult") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/WARNING</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/WARNING">https://w3id.org/linkml/WARNING</seealso>
    let WARNING = Prefixed_Name(linkml, "WARNING") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/YAML</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/YAML">https://w3id.org/linkml/YAML</seealso>
    let YAML = Prefixed_Name(linkml, "YAML") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"abbreviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/abbreviation">https://w3id.org/linkml/abbreviation</seealso>
    let abbreviation = Prefixed_Name(linkml, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"abstract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/abstract">https://w3id.org/linkml/abstract</seealso>
    let abstract_ = Prefixed_Name(linkml, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/alias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"alias"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/alias">https://w3id.org/linkml/alias</seealso>
    let alias = Prefixed_Name(linkml, "alias") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/alias_contexts</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"alias_contexts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/alias_contexts">https://w3id.org/linkml/alias_contexts</seealso>
    let alias_contexts = Prefixed_Name(linkml, "alias_contexts") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/alias_predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"alias_predicate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/alias_predicate">https://w3id.org/linkml/alias_predicate</seealso>
    let alias_predicate = Prefixed_Name(linkml, "alias_predicate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/alias_predicate_enum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/alias_predicate_enum">https://w3id.org/linkml/alias_predicate_enum</seealso>
    let alias_predicate_enum =
        Prefixed_Name(linkml, "alias_predicate_enum") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/aliases</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"aliases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/aliases">https://w3id.org/linkml/aliases</seealso>
    let aliases = Prefixed_Name(linkml, "aliases") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/all_members</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"all_members"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/all_members">https://w3id.org/linkml/all_members</seealso>
    let all_members = Prefixed_Name(linkml, "all_members") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/all_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"all_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/all_of">https://w3id.org/linkml/all_of</seealso>
    let all_of = Prefixed_Name(linkml, "all_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/allowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"allowed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/allowed">https://w3id.org/linkml/allowed</seealso>
    let allowed = Prefixed_Name(linkml, "allowed") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/alt_description_source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"alt_description_source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/alt_description_source">https://w3id.org/linkml/alt_description_source</seealso>
    let alt_description_source =
        Prefixed_Name(linkml, "alt_description_source") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/alt_description_text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"alt_description_text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/alt_description_text">https://w3id.org/linkml/alt_description_text</seealso>
    let alt_description_text =
        Prefixed_Name(linkml, "alt_description_text") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/alt_descriptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"alt_descriptions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/alt_descriptions">https://w3id.org/linkml/alt_descriptions</seealso>
    let alt_descriptions = Prefixed_Name(linkml, "alt_descriptions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/annotations</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SchemaDefinition</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"annotations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/annotations">https://w3id.org/linkml/annotations</seealso>
    let annotations = Prefixed_Name(linkml, "annotations") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/any_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"any_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/any_of">https://w3id.org/linkml/any_of</seealso>
    let any_of = Prefixed_Name(linkml, "any_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/apply_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"apply_to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/apply_to">https://w3id.org/linkml/apply_to</seealso>
    let apply_to = Prefixed_Name(linkml, "apply_to") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/array</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"array"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/array">https://w3id.org/linkml/array</seealso>
    let array = Prefixed_Name(linkml, "array") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/asymmetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"asymmetric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/asymmetric">https://w3id.org/linkml/asymmetric</seealso>
    let asymmetric = Prefixed_Name(linkml, "asymmetric") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/attributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"attributes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/attributes">https://w3id.org/linkml/attributes</seealso>
    let attributes = Prefixed_Name(linkml, "attributes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/base</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"base"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/base">https://w3id.org/linkml/base</seealso>
    let base_ = Prefixed_Name(linkml, "base") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/bidirectional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"bidirectional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/bidirectional">https://w3id.org/linkml/bidirectional</seealso>
    let bidirectional = Prefixed_Name(linkml, "bidirectional") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/bindings</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"bindings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/bindings">https://w3id.org/linkml/bindings</seealso>
    let bindings = Prefixed_Name(linkml, "bindings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/binds_value_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"binds_value_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/binds_value_of">https://w3id.org/linkml/binds_value_of</seealso>
    let binds_value_of = Prefixed_Name(linkml, "binds_value_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/boolean</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/boolean">https://w3id.org/linkml/boolean</seealso>
    let boolean = Prefixed_Name(linkml, "boolean") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/boolean_slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"boolean_slot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/boolean_slot">https://w3id.org/linkml/boolean_slot</seealso>
    let boolean_slot = Prefixed_Name(linkml, "boolean_slot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/broad_mappings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"broad mappings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/broad_mappings">https://w3id.org/linkml/broad_mappings</seealso>
    let broad_mappings = Prefixed_Name(linkml, "broad_mappings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/bytes</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/bytes">https://w3id.org/linkml/bytes</seealso>
    let bytes = Prefixed_Name(linkml, "bytes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/categories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"categories"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/categories">https://w3id.org/linkml/categories</seealso>
    let categories = Prefixed_Name(linkml, "categories") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/children_are_mutually_disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"children_are_mutually_disjoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/children_are_mutually_disjoint">https://w3id.org/linkml/children_are_mutually_disjoint</seealso>
    let children_are_mutually_disjoint =
        Prefixed_Name(linkml, "children_are_mutually_disjoint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_definition_apply_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/class_definition_apply_to">https://w3id.org/linkml/class_definition_apply_to</seealso>
    let class_definition_apply_to =
        Prefixed_Name(linkml, "class_definition_apply_to") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_definition_disjoint_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/class_definition_disjoint_with">https://w3id.org/linkml/class_definition_disjoint_with</seealso>
    let class_definition_disjoint_with =
        Prefixed_Name(linkml, "class_definition_disjoint_with") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_definition_is_a</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/class_definition_is_a">https://w3id.org/linkml/class_definition_is_a</seealso>
    let class_definition_is_a =
        Prefixed_Name(linkml, "class_definition_is_a") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_definition_mixins</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/class_definition_mixins">https://w3id.org/linkml/class_definition_mixins</seealso>
    let class_definition_mixins =
        Prefixed_Name(linkml, "class_definition_mixins") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_definition_rules</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/class_definition_rules">https://w3id.org/linkml/class_definition_rules</seealso>
    let class_definition_rules =
        Prefixed_Name(linkml, "class_definition_rules") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_definition_union_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/class_definition_union_of">https://w3id.org/linkml/class_definition_union_of</seealso>
    let class_definition_union_of =
        Prefixed_Name(linkml, "class_definition_union_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_expression_all_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/class_expression_all_of">https://w3id.org/linkml/class_expression_all_of</seealso>
    let class_expression_all_of =
        Prefixed_Name(linkml, "class_expression_all_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_expression_any_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/class_expression_any_of">https://w3id.org/linkml/class_expression_any_of</seealso>
    let class_expression_any_of =
        Prefixed_Name(linkml, "class_expression_any_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_expression_exactly_one_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/class_expression_exactly_one_of">https://w3id.org/linkml/class_expression_exactly_one_of</seealso>
    let class_expression_exactly_one_of =
        Prefixed_Name(linkml, "class_expression_exactly_one_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_expression_none_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/class_expression_none_of">https://w3id.org/linkml/class_expression_none_of</seealso>
    let class_expression_none_of =
        Prefixed_Name(linkml, "class_expression_none_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/class_uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"class_uri"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/class_uri">https://w3id.org/linkml/class_uri</seealso>
    let class_uri = Prefixed_Name(linkml, "class_uri") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/classes">https://w3id.org/linkml/classes</seealso>
    let classes = Prefixed_Name(linkml, "classes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/classification_rules</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"classification_rules"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/classification_rules">https://w3id.org/linkml/classification_rules</seealso>
    let classification_rules =
        Prefixed_Name(linkml, "classification_rules") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/close_mappings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"close mappings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/close_mappings">https://w3id.org/linkml/close_mappings</seealso>
    let close_mappings = Prefixed_Name(linkml, "close_mappings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/code_set</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"code_set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/code_set">https://w3id.org/linkml/code_set</seealso>
    let code_set = Prefixed_Name(linkml, "code_set") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/code_set_tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"code_set_tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/code_set_tag">https://w3id.org/linkml/code_set_tag</seealso>
    let code_set_tag = Prefixed_Name(linkml, "code_set_tag") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/code_set_version</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"code_set_version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/code_set_version">https://w3id.org/linkml/code_set_version</seealso>
    let code_set_version = Prefixed_Name(linkml, "code_set_version") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/comment_prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/comment_prefix">https://w3id.org/linkml/comment_prefix</seealso>
    let comment_prefix = Prefixed_Name(linkml, "comment_prefix") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/comments</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"comments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/comments">https://w3id.org/linkml/comments</seealso>
    let comments = Prefixed_Name(linkml, "comments") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/compression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/compression">https://w3id.org/linkml/compression</seealso>
    let compression = Prefixed_Name(linkml, "compression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/concepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"concepts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/concepts">https://w3id.org/linkml/concepts</seealso>
    let concepts = Prefixed_Name(linkml, "concepts") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/conforms_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"conforms_to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/conforms_to">https://w3id.org/linkml/conforms_to</seealso>
    let conforms_to = Prefixed_Name(linkml, "conforms_to") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/conforms_to_class</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/conforms_to_class">https://w3id.org/linkml/conforms_to_class</seealso>
    let conforms_to_class = Prefixed_Name(linkml, "conforms_to_class") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/conforms_to_schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/conforms_to_schema">https://w3id.org/linkml/conforms_to_schema</seealso>
    let conforms_to_schema = Prefixed_Name(linkml, "conforms_to_schema") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/consider_nulls_inequal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"consider_nulls_inequal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/consider_nulls_inequal">https://w3id.org/linkml/consider_nulls_inequal</seealso>
    let consider_nulls_inequal =
        Prefixed_Name(linkml, "consider_nulls_inequal") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/contributors</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"contributors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/contributors">https://w3id.org/linkml/contributors</seealso>
    let contributors = Prefixed_Name(linkml, "contributors") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/created_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"created_by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/created_by">https://w3id.org/linkml/created_by</seealso>
    let created_by = Prefixed_Name(linkml, "created_by") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/created_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"created_on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/created_on">https://w3id.org/linkml/created_on</seealso>
    let created_on = Prefixed_Name(linkml, "created_on") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/csv</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/csv">https://w3id.org/linkml/csv</seealso>
    let csv = Prefixed_Name(linkml, "csv") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/curie</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/curie">https://w3id.org/linkml/curie</seealso>
    let curie = Prefixed_Name(linkml, "curie") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/datasets</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SchemaDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/datasets">https://w3id.org/linkml/datasets</seealso>
    let datasets = Prefixed_Name(linkml, "datasets") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/date</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/date">https://w3id.org/linkml/date</seealso>
    let date = Prefixed_Name(linkml, "date") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/date_or_datetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/date_or_datetime">https://w3id.org/linkml/date_or_datetime</seealso>
    let date_or_datetime = Prefixed_Name(linkml, "date_or_datetime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/datetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/datetime">https://w3id.org/linkml/datetime</seealso>
    let datetime = Prefixed_Name(linkml, "datetime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/deactivated</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"deactivated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/deactivated">https://w3id.org/linkml/deactivated</seealso>
    let deactivated = Prefixed_Name(linkml, "deactivated") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/decimal</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/decimal">https://w3id.org/linkml/decimal</seealso>
    let decimal = Prefixed_Name(linkml, "decimal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/default_curi_maps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"default_curi_maps"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/default_curi_maps">https://w3id.org/linkml/default_curi_maps</seealso>
    let default_curi_maps = Prefixed_Name(linkml, "default_curi_maps") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/default_prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"default_prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/default_prefix">https://w3id.org/linkml/default_prefix</seealso>
    let default_prefix = Prefixed_Name(linkml, "default_prefix") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/default_range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"default_range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/default_range">https://w3id.org/linkml/default_range</seealso>
    let default_range = Prefixed_Name(linkml, "default_range") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/defining_slots</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"defining_slots"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/defining_slots">https://w3id.org/linkml/defining_slots</seealso>
    let defining_slots = Prefixed_Name(linkml, "defining_slots") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/definition_uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"definition_uri"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/definition_uri">https://w3id.org/linkml/definition_uri</seealso>
    let definition_uri = Prefixed_Name(linkml, "definition_uri") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/delimiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/delimiter">https://w3id.org/linkml/delimiter</seealso>
    let delimiter = Prefixed_Name(linkml, "delimiter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"deprecated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/deprecated">https://w3id.org/linkml/deprecated</seealso>
    let deprecated = Prefixed_Name(linkml, "deprecated") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/deprecated_element_has_exact_replacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"deprecated element has exact replacement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/deprecated_element_has_exact_replacement">https://w3id.org/linkml/deprecated_element_has_exact_replacement</seealso>
    let deprecated_element_has_exact_replacement =
        Prefixed_Name(linkml, "deprecated_element_has_exact_replacement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/deprecated_element_has_possible_replacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"deprecated element has possible replacement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/deprecated_element_has_possible_replacement">https://w3id.org/linkml/deprecated_element_has_possible_replacement</seealso>
    let deprecated_element_has_possible_replacement =
        Prefixed_Name(linkml, "deprecated_element_has_possible_replacement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/derivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"derivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/derivation">https://w3id.org/linkml/derivation</seealso>
    let derivation = Prefixed_Name(linkml, "derivation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/description</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/description">https://w3id.org/linkml/description</seealso>
    let description = Prefixed_Name(linkml, "description") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/descriptive_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"descriptive_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/descriptive_name">https://w3id.org/linkml/descriptive_name</seealso>
    let descriptive_name = Prefixed_Name(linkml, "descriptive_name") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/designates_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"designates_type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/designates_type">https://w3id.org/linkml/designates_type</seealso>
    let designates_type = Prefixed_Name(linkml, "designates_type") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/dialect</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/dialect">https://w3id.org/linkml/dialect</seealso>
    let dialect = Prefixed_Name(linkml, "dialect") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"dimensions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/dimensions">https://w3id.org/linkml/dimensions</seealso>
    let dimensions = Prefixed_Name(linkml, "dimensions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/disjoint_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"disjoint_with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/disjoint_with">https://w3id.org/linkml/disjoint_with</seealso>
    let disjoint_with = Prefixed_Name(linkml, "disjoint_with") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/docs/specification/05validation/#rules</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/docs/specification/05validation/#rules">https://w3id.org/linkml/docs/specification/05validation/#rules</seealso>
    let ``docs/specification/05validation/#rules`` =
        Prefixed_Name(linkml, "docs/specification/05validation/#rules") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/docs/specification/06mapping/#collection-forms</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/docs/specification/06mapping/#collection-forms">https://w3id.org/linkml/docs/specification/06mapping/#collection-forms</seealso>
    let ``docs/specification/06mapping/#collection_forms`` =
        Prefixed_Name(linkml, "docs/specification/06mapping/#collection-forms") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/domain">https://w3id.org/linkml/domain</seealso>
    let domain = Prefixed_Name(linkml, "domain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/domain_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"domain_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/domain_of">https://w3id.org/linkml/domain_of</seealso>
    let domain_of = Prefixed_Name(linkml, "domain_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/double</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/double">https://w3id.org/linkml/double</seealso>
    let double = Prefixed_Name(linkml, "double") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/double_quote</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/double_quote">https://w3id.org/linkml/double_quote</seealso>
    let double_quote = Prefixed_Name(linkml, "double_quote") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/download_url</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/download_url">https://w3id.org/linkml/download_url</seealso>
    let download_url = Prefixed_Name(linkml, "download_url") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/elseconditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"elseconditions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/elseconditions">https://w3id.org/linkml/elseconditions</seealso>
    let elseconditions = Prefixed_Name(linkml, "elseconditions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/emit_prefixes</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"emit_prefixes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/emit_prefixes">https://w3id.org/linkml/emit_prefixes</seealso>
    let emit_prefixes = Prefixed_Name(linkml, "emit_prefixes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/encoding">https://w3id.org/linkml/encoding</seealso>
    let encoding = Prefixed_Name(linkml, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/enum_binding_range</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/enum_binding_range">https://w3id.org/linkml/enum_binding_range</seealso>
    let enum_binding_range = Prefixed_Name(linkml, "enum_binding_range") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/enum_range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"enum_range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/enum_range">https://w3id.org/linkml/enum_range</seealso>
    let enum_range = Prefixed_Name(linkml, "enum_range") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/enum_uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"enum_uri"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/enum_uri">https://w3id.org/linkml/enum_uri</seealso>
    let enum_uri = Prefixed_Name(linkml, "enum_uri") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/enums</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"enums"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/enums">https://w3id.org/linkml/enums</seealso>
    let enums = Prefixed_Name(linkml, "enums") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/equals_expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"equals_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/equals_expression">https://w3id.org/linkml/equals_expression</seealso>
    let equals_expression = Prefixed_Name(linkml, "equals_expression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/equals_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"equals_number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/equals_number">https://w3id.org/linkml/equals_number</seealso>
    let equals_number = Prefixed_Name(linkml, "equals_number") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/equals_number_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"equals_number_in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/equals_number_in">https://w3id.org/linkml/equals_number_in</seealso>
    let equals_number_in = Prefixed_Name(linkml, "equals_number_in") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/equals_string</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"equals_string"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/equals_string">https://w3id.org/linkml/equals_string</seealso>
    let equals_string = Prefixed_Name(linkml, "equals_string") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/equals_string_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"equals_string_in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/equals_string_in">https://w3id.org/linkml/equals_string_in</seealso>
    let equals_string_in = Prefixed_Name(linkml, "equals_string_in") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/exact_cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"exact_cardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/exact_cardinality">https://w3id.org/linkml/exact_cardinality</seealso>
    let exact_cardinality = Prefixed_Name(linkml, "exact_cardinality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/exact_mappings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"exact mappings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/exact_mappings">https://w3id.org/linkml/exact_mappings</seealso>
    let exact_mappings = Prefixed_Name(linkml, "exact_mappings") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/exact_number_dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"exact_number_dimensions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/exact_number_dimensions">https://w3id.org/linkml/exact_number_dimensions</seealso>
    let exact_number_dimensions =
        Prefixed_Name(linkml, "exact_number_dimensions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/exactly_one_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"exactly_one_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/exactly_one_of">https://w3id.org/linkml/exactly_one_of</seealso>
    let exactly_one_of = Prefixed_Name(linkml, "exactly_one_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/examples</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"examples"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/examples">https://w3id.org/linkml/examples</seealso>
    let examples = Prefixed_Name(linkml, "examples") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/extension_tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"extension_tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/extension_tag">https://w3id.org/linkml/extension_tag</seealso>
    let extension_tag = Prefixed_Name(linkml, "extension_tag") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/extension_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/Annotation</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"extension_value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/extension_value">https://w3id.org/linkml/extension_value</seealso>
    let extension_value = Prefixed_Name(linkml, "extension_value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/extensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SchemaDefinition</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"extensions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/extensions">https://w3id.org/linkml/extensions</seealso>
    let extensions = Prefixed_Name(linkml, "extensions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/extra_slots</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/Example</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"extra_slots"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/extra_slots">https://w3id.org/linkml/extra_slots</seealso>
    let extra_slots = Prefixed_Name(linkml, "extra_slots") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/extra_slots_expression_range_expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/extra_slots_expression_range_expression">https://w3id.org/linkml/extra_slots_expression_range_expression</seealso>
    let extra_slots_expression_range_expression =
        Prefixed_Name(linkml, "extra_slots_expression_range_expression") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/float</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/float">https://w3id.org/linkml/float</seealso>
    let float = Prefixed_Name(linkml, "float") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/followed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"followed_by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/followed_by">https://w3id.org/linkml/followed_by</seealso>
    let followed_by = Prefixed_Name(linkml, "followed_by") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/format</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/format">https://w3id.org/linkml/format</seealso>
    let format = Prefixed_Name(linkml, "format") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/formatDialect__comment_prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/formatDialect__comment_prefix">https://w3id.org/linkml/formatDialect__comment_prefix</seealso>
    let formatDialect__comment_prefix =
        Prefixed_Name(linkml, "formatDialect__comment_prefix") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/formatDialect__delimiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/formatDialect__delimiter">https://w3id.org/linkml/formatDialect__delimiter</seealso>
    let formatDialect__delimiter =
        Prefixed_Name(linkml, "formatDialect__delimiter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/formatDialect__double_quote</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/formatDialect__double_quote">https://w3id.org/linkml/formatDialect__double_quote</seealso>
    let formatDialect__double_quote =
        Prefixed_Name(linkml, "formatDialect__double_quote") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/formatDialect__header</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/formatDialect__header">https://w3id.org/linkml/formatDialect__header</seealso>
    let formatDialect__header =
        Prefixed_Name(linkml, "formatDialect__header") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/formatDialect__quote_char</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/formatDialect__quote_char">https://w3id.org/linkml/formatDialect__quote_char</seealso>
    let formatDialect__quote_char =
        Prefixed_Name(linkml, "formatDialect__quote_char") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/framework_key</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"framework_key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/framework_key">https://w3id.org/linkml/framework_key</seealso>
    let framework_key = Prefixed_Name(linkml, "framework_key") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/from_schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"from_schema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/from_schema">https://w3id.org/linkml/from_schema</seealso>
    let from_schema = Prefixed_Name(linkml, "from_schema") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/generation_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"generation_date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/generation_date">https://w3id.org/linkml/generation_date</seealso>
    let generation_date = Prefixed_Name(linkml, "generation_date") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/has_member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"has_member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/has_member">https://w3id.org/linkml/has_member</seealso>
    let has_member = Prefixed_Name(linkml, "has_member") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/has_quantity_kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has_quantity_kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/has_quantity_kind">https://w3id.org/linkml/has_quantity_kind</seealso>
    let has_quantity_kind = Prefixed_Name(linkml, "has_quantity_kind") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/hash</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/hash">https://w3id.org/linkml/hash</seealso>
    let hash = Prefixed_Name(linkml, "hash") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/header</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/header">https://w3id.org/linkml/header</seealso>
    let header = Prefixed_Name(linkml, "header") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/id</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/id">https://w3id.org/linkml/id</seealso>
    let id = Prefixed_Name(linkml, "id") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/id_prefixes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"id_prefixes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/id_prefixes">https://w3id.org/linkml/id_prefixes</seealso>
    let id_prefixes = Prefixed_Name(linkml, "id_prefixes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/id_prefixes_are_closed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"id_prefixes_are_closed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/id_prefixes_are_closed">https://w3id.org/linkml/id_prefixes_are_closed</seealso>
    let id_prefixes_are_closed =
        Prefixed_Name(linkml, "id_prefixes_are_closed") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/identifier">https://w3id.org/linkml/identifier</seealso>
    let identifier = Prefixed_Name(linkml, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/identifier_pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"identifier_pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/identifier_pattern">https://w3id.org/linkml/identifier_pattern</seealso>
    let identifier_pattern = Prefixed_Name(linkml, "identifier_pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/iec61360code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"iec61360code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/iec61360code">https://w3id.org/linkml/iec61360code</seealso>
    let iec61360code = Prefixed_Name(linkml, "iec61360code") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ifabsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ifabsent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ifabsent">https://w3id.org/linkml/ifabsent</seealso>
    let ifabsent = Prefixed_Name(linkml, "ifabsent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"implements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/implements">https://w3id.org/linkml/implements</seealso>
    let implements = Prefixed_Name(linkml, "implements") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/implicit_prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"implicit_prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/implicit_prefix">https://w3id.org/linkml/implicit_prefix</seealso>
    let implicit_prefix = Prefixed_Name(linkml, "implicit_prefix") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/import_as</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"import_as"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/import_as">https://w3id.org/linkml/import_as</seealso>
    let import_as = Prefixed_Name(linkml, "import_as") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/import_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"import_from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/import_from">https://w3id.org/linkml/import_from</seealso>
    let import_from = Prefixed_Name(linkml, "import_from") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/import_map</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"import_map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/import_map">https://w3id.org/linkml/import_map</seealso>
    let import_map = Prefixed_Name(linkml, "import_map") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/imported_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"imported_from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/imported_from">https://w3id.org/linkml/imported_from</seealso>
    let imported_from = Prefixed_Name(linkml, "imported_from") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/imports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"imports"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/imports">https://w3id.org/linkml/imports</seealso>
    let imports = Prefixed_Name(linkml, "imports") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/in_language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"in_language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/in_language">https://w3id.org/linkml/in_language</seealso>
    let in_language = Prefixed_Name(linkml, "in_language") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/in_subset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"in_subset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/in_subset">https://w3id.org/linkml/in_subset</seealso>
    let in_subset = Prefixed_Name(linkml, "in_subset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/inapplicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"inapplicable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/inapplicable">https://w3id.org/linkml/inapplicable</seealso>
    let inapplicable = Prefixed_Name(linkml, "inapplicable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/inapplicable_slot</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/inapplicable_slot">https://w3id.org/linkml/inapplicable_slot</seealso>
    let inapplicable_slot = Prefixed_Name(linkml, "inapplicable_slot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/include</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"include"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/include">https://w3id.org/linkml/include</seealso>
    let include_ = Prefixed_Name(linkml, "include") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/include_self</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"include_self"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/include_self">https://w3id.org/linkml/include_self</seealso>
    let include_self = Prefixed_Name(linkml, "include_self") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/info</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/info">https://w3id.org/linkml/info</seealso>
    let info = Prefixed_Name(linkml, "info") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/inherited</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"inherited"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/inherited">https://w3id.org/linkml/inherited</seealso>
    let inherited = Prefixed_Name(linkml, "inherited") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/inherits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"inherits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/inherits">https://w3id.org/linkml/inherits</seealso>
    let inherits = Prefixed_Name(linkml, "inherits") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/inlined</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inlined"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/inlined">https://w3id.org/linkml/inlined</seealso>
    let inlined = Prefixed_Name(linkml, "inlined") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/inlined_as_list</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"inlined_as_list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/inlined_as_list">https://w3id.org/linkml/inlined_as_list</seealso>
    let inlined_as_list = Prefixed_Name(linkml, "inlined_as_list") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/inlined_as_simple_dict</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inlined_as_simple_dict"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/inlined_as_simple_dict">https://w3id.org/linkml/inlined_as_simple_dict</seealso>
    let inlined_as_simple_dict =
        Prefixed_Name(linkml, "inlined_as_simple_dict") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/instantiates</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"instantiates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/instantiates">https://w3id.org/linkml/instantiates</seealso>
    let instantiates = Prefixed_Name(linkml, "instantiates") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/integer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/integer">https://w3id.org/linkml/integer</seealso>
    let integer = Prefixed_Name(linkml, "integer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/interpolated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"interpolated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/interpolated">https://w3id.org/linkml/interpolated</seealso>
    let interpolated = Prefixed_Name(linkml, "interpolated") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/inverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inverse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/inverse">https://w3id.org/linkml/inverse</seealso>
    let inverse = Prefixed_Name(linkml, "inverse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/irreflexive</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"irreflexive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/irreflexive">https://w3id.org/linkml/irreflexive</seealso>
    let irreflexive = Prefixed_Name(linkml, "irreflexive") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/is_a</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is_a"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/is_a">https://w3id.org/linkml/is_a</seealso>
    let is_a = Prefixed_Name(linkml, "is_a") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/is_class_field</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is_class_field"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/is_class_field">https://w3id.org/linkml/is_class_field</seealso>
    let is_class_field = Prefixed_Name(linkml, "is_class_field") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/is_direct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"is_direct"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/is_direct">https://w3id.org/linkml/is_direct</seealso>
    let is_direct = Prefixed_Name(linkml, "is_direct") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/is_grouping_slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is_grouping_slot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/is_grouping_slot">https://w3id.org/linkml/is_grouping_slot</seealso>
    let is_grouping_slot = Prefixed_Name(linkml, "is_grouping_slot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/is_usage_slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is_usage_slot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/is_usage_slot">https://w3id.org/linkml/is_usage_slot</seealso>
    let is_usage_slot = Prefixed_Name(linkml, "is_usage_slot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/issued</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/issued">https://w3id.org/linkml/issued</seealso>
    let issued = Prefixed_Name(linkml, "issued") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/jsonpath</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/jsonpath">https://w3id.org/linkml/jsonpath</seealso>
    let jsonpath = Prefixed_Name(linkml, "jsonpath") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/jsonpointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/jsonpointer">https://w3id.org/linkml/jsonpointer</seealso>
    let jsonpointer = Prefixed_Name(linkml, "jsonpointer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/key">https://w3id.org/linkml/key</seealso>
    let key = Prefixed_Name(linkml, "key") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/keywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"keywords"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/keywords">https://w3id.org/linkml/keywords</seealso>
    let keywords = Prefixed_Name(linkml, "keywords") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/language</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/language">https://w3id.org/linkml/language</seealso>
    let language = Prefixed_Name(linkml, "language") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/last_updated_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"last_updated_on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/last_updated_on">https://w3id.org/linkml/last_updated_on</seealso>
    let last_updated_on = Prefixed_Name(linkml, "last_updated_on") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/license</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"license"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/license">https://w3id.org/linkml/license</seealso>
    let license = Prefixed_Name(linkml, "license") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/list_elements_ordered</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"list_elements_ordered"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/list_elements_ordered">https://w3id.org/linkml/list_elements_ordered</seealso>
    let list_elements_ordered =
        Prefixed_Name(linkml, "list_elements_ordered") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/list_elements_unique</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"list_elements_unique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/list_elements_unique">https://w3id.org/linkml/list_elements_unique</seealso>
    let list_elements_unique =
        Prefixed_Name(linkml, "list_elements_unique") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/list_value_specification_constant</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"list_value_specification_constant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/list_value_specification_constant">https://w3id.org/linkml/list_value_specification_constant</seealso>
    let list_value_specification_constant =
        Prefixed_Name(linkml, "list_value_specification_constant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/literal_form</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"literal_form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/literal_form">https://w3id.org/linkml/literal_form</seealso>
    let literal_form = Prefixed_Name(linkml, "literal_form") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/local_name_source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"local_name_source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/local_name_source">https://w3id.org/linkml/local_name_source</seealso>
    let local_name_source = Prefixed_Name(linkml, "local_name_source") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/local_name_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"local_name_value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/local_name_value">https://w3id.org/linkml/local_name_value</seealso>
    let local_name_value = Prefixed_Name(linkml, "local_name_value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/local_names</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"local_names"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/local_names">https://w3id.org/linkml/local_names</seealso>
    let local_names = Prefixed_Name(linkml, "local_names") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/locally_reflexive</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"locally_reflexive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/locally_reflexive">https://w3id.org/linkml/locally_reflexive</seealso>
    let locally_reflexive = Prefixed_Name(linkml, "locally_reflexive") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/mapped_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"mapped_type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/mapped_type">https://w3id.org/linkml/mapped_type</seealso>
    let mapped_type = Prefixed_Name(linkml, "mapped_type") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/mappings</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SchemaDefinition</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"mappings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/mappings">https://w3id.org/linkml/mappings</seealso>
    let mappings = Prefixed_Name(linkml, "mappings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/matches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"matches"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/matches">https://w3id.org/linkml/matches</seealso>
    let matches = Prefixed_Name(linkml, "matches") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/max_count_violation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/max_count_violation">https://w3id.org/linkml/max_count_violation</seealso>
    let max_count_violation =
        Prefixed_Name(linkml, "max_count_violation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/maximum_cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"maximum_cardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/maximum_cardinality">https://w3id.org/linkml/maximum_cardinality</seealso>
    let maximum_cardinality =
        Prefixed_Name(linkml, "maximum_cardinality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/maximum_number_dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/AnonymousSlotExpression</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"maximum_number_dimensions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/maximum_number_dimensions">https://w3id.org/linkml/maximum_number_dimensions</seealso>
    let maximum_number_dimensions =
        Prefixed_Name(linkml, "maximum_number_dimensions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/maximum_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"maximum_value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/maximum_value">https://w3id.org/linkml/maximum_value</seealso>
    let maximum_value = Prefixed_Name(linkml, "maximum_value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/md5</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/md5">https://w3id.org/linkml/md5</seealso>
    let md5 = Prefixed_Name(linkml, "md5") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/meaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"meaning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/meaning">https://w3id.org/linkml/meaning</seealso>
    let meaning = Prefixed_Name(linkml, "meaning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/media_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/Example</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/media_type">https://w3id.org/linkml/media_type</seealso>
    let media_type = Prefixed_Name(linkml, "media_type") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/meta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>w3id:linkml/SchemaDefinition</para>
    ///
    /// labels<para>"meta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/meta">https://w3id.org/linkml/meta</seealso>
    let meta = Prefixed_Name(linkml, "meta") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/metamodel_version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"metamodel_version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/metamodel_version">https://w3id.org/linkml/metamodel_version</seealso>
    let metamodel_version = Prefixed_Name(linkml, "metamodel_version") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/minimum_cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"minimum_cardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/minimum_cardinality">https://w3id.org/linkml/minimum_cardinality</seealso>
    let minimum_cardinality =
        Prefixed_Name(linkml, "minimum_cardinality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/minimum_number_dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"minimum_number_dimensions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/minimum_number_dimensions">https://w3id.org/linkml/minimum_number_dimensions</seealso>
    let minimum_number_dimensions =
        Prefixed_Name(linkml, "minimum_number_dimensions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/minimum_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"minimum_value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/minimum_value">https://w3id.org/linkml/minimum_value</seealso>
    let minimum_value = Prefixed_Name(linkml, "minimum_value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/minus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"minus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/minus">https://w3id.org/linkml/minus</seealso>
    let minus = Prefixed_Name(linkml, "minus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/missing_slot_value</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/missing_slot_value">https://w3id.org/linkml/missing_slot_value</seealso>
    let missing_slot_value = Prefixed_Name(linkml, "missing_slot_value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/mixin</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"mixin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/mixin">https://w3id.org/linkml/mixin</seealso>
    let mixin_ = Prefixed_Name(linkml, "mixin") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/mixins</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"mixins"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/mixins">https://w3id.org/linkml/mixins</seealso>
    let mixins = Prefixed_Name(linkml, "mixins") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/modified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"modified_by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/modified_by">https://w3id.org/linkml/modified_by</seealso>
    let modified_by = Prefixed_Name(linkml, "modified_by") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/multivalued</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"multivalued"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/multivalued">https://w3id.org/linkml/multivalued</seealso>
    let multivalued = Prefixed_Name(linkml, "multivalued") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/name">https://w3id.org/linkml/name</seealso>
    let name = Prefixed_Name(linkml, "name") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/narrow_mappings</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"narrow mappings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/narrow_mappings">https://w3id.org/linkml/narrow_mappings</seealso>
    let narrow_mappings = Prefixed_Name(linkml, "narrow_mappings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ncname</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/ncname">https://w3id.org/linkml/ncname</seealso>
    let ncname = Prefixed_Name(linkml, "ncname") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/node_source</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/node_source">https://w3id.org/linkml/node_source</seealso>
    let node_source = Prefixed_Name(linkml, "node_source") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/nodeidentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/nodeidentifier">https://w3id.org/linkml/nodeidentifier</seealso>
    let nodeidentifier = Prefixed_Name(linkml, "nodeidentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/none_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"none_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/none_of">https://w3id.org/linkml/none_of</seealso>
    let none_of = Prefixed_Name(linkml, "none_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/notes</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"notes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/notes">https://w3id.org/linkml/notes</seealso>
    let notes = Prefixed_Name(linkml, "notes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/object</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/object">https://w3id.org/linkml/object</seealso>
    let object = Prefixed_Name(linkml, "object") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/object_str</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/object_str">https://w3id.org/linkml/object_str</seealso>
    let object_str = Prefixed_Name(linkml, "object_str") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/objectidentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/objectidentifier">https://w3id.org/linkml/objectidentifier</seealso>
    let objectidentifier = Prefixed_Name(linkml, "objectidentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/obligation_level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"obligation_level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/obligation_level">https://w3id.org/linkml/obligation_level</seealso>
    let obligation_level = Prefixed_Name(linkml, "obligation_level") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/obligation_level_enum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/obligation_level_enum">https://w3id.org/linkml/obligation_level_enum</seealso>
    let obligation_level_enum =
        Prefixed_Name(linkml, "obligation_level_enum") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/open_world</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"open_world"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/open_world">https://w3id.org/linkml/open_world</seealso>
    let open_world = Prefixed_Name(linkml, "open_world") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/owned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"owned_by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/owned_by">https://w3id.org/linkml/owned_by</seealso>
    let owned_by = Prefixed_Name(linkml, "owned_by") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/owner">https://w3id.org/linkml/owner</seealso>
    let owner = Prefixed_Name(linkml, "owner") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/page</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/page">https://w3id.org/linkml/page</seealso>
    let page = Prefixed_Name(linkml, "page") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/parsing_error</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/parsing_error">https://w3id.org/linkml/parsing_error</seealso>
    let parsing_error = Prefixed_Name(linkml, "parsing_error") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/partial_match</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"partial_match"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/partial_match">https://w3id.org/linkml/partial_match</seealso>
    let partial_match = Prefixed_Name(linkml, "partial_match") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/path</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/path">https://w3id.org/linkml/path</seealso>
    let path = Prefixed_Name(linkml, "path") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/path_expression_all_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/path_expression_all_of">https://w3id.org/linkml/path_expression_all_of</seealso>
    let path_expression_all_of =
        Prefixed_Name(linkml, "path_expression_all_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/path_expression_any_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/path_expression_any_of">https://w3id.org/linkml/path_expression_any_of</seealso>
    let path_expression_any_of =
        Prefixed_Name(linkml, "path_expression_any_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/path_expression_exactly_one_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/path_expression_exactly_one_of">https://w3id.org/linkml/path_expression_exactly_one_of</seealso>
    let path_expression_exactly_one_of =
        Prefixed_Name(linkml, "path_expression_exactly_one_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/path_expression_followed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/path_expression_followed_by">https://w3id.org/linkml/path_expression_followed_by</seealso>
    let path_expression_followed_by =
        Prefixed_Name(linkml, "path_expression_followed_by") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/path_expression_none_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/path_expression_none_of">https://w3id.org/linkml/path_expression_none_of</seealso>
    let path_expression_none_of =
        Prefixed_Name(linkml, "path_expression_none_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/path_rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"path_rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/path_rule">https://w3id.org/linkml/path_rule</seealso>
    let path_rule = Prefixed_Name(linkml, "path_rule") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/pattern">https://w3id.org/linkml/pattern</seealso>
    let pattern = Prefixed_Name(linkml, "pattern") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/permissible_value_is_a</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/permissible_value_is_a">https://w3id.org/linkml/permissible_value_is_a</seealso>
    let permissible_value_is_a =
        Prefixed_Name(linkml, "permissible_value_is_a") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/permissible_value_mixins</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/permissible_value_mixins">https://w3id.org/linkml/permissible_value_mixins</seealso>
    let permissible_value_mixins =
        Prefixed_Name(linkml, "permissible_value_mixins") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/permissible_values</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"permissible_values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/permissible_values">https://w3id.org/linkml/permissible_values</seealso>
    let permissible_values = Prefixed_Name(linkml, "permissible_values") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/postconditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"postconditions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/postconditions">https://w3id.org/linkml/postconditions</seealso>
    let postconditions = Prefixed_Name(linkml, "postconditions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/preconditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"preconditions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/preconditions">https://w3id.org/linkml/preconditions</seealso>
    let preconditions = Prefixed_Name(linkml, "preconditions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/predicate">https://w3id.org/linkml/predicate</seealso>
    let predicate = Prefixed_Name(linkml, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/prefix_prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"prefix_prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/prefix_prefix">https://w3id.org/linkml/prefix_prefix</seealso>
    let prefix_prefix = Prefixed_Name(linkml, "prefix_prefix") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/prefix_reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"prefix_reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/prefix_reference">https://w3id.org/linkml/prefix_reference</seealso>
    let prefix_reference = Prefixed_Name(linkml, "prefix_reference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/prefixes</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"prefixes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/prefixes">https://w3id.org/linkml/prefixes</seealso>
    let prefixes = Prefixed_Name(linkml, "prefixes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/presence_enum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/presence_enum">https://w3id.org/linkml/presence_enum</seealso>
    let presence_enum = Prefixed_Name(linkml, "presence_enum") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/problem_type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/problem_type">https://w3id.org/linkml/problem_type</seealso>
    let problem_type = Prefixed_Name(linkml, "problem_type") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/profile">https://w3id.org/linkml/profile</seealso>
    let profile = Prefixed_Name(linkml, "profile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/publisher">https://w3id.org/linkml/publisher</seealso>
    let publisher = Prefixed_Name(linkml, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/pv_formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"pv_formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/pv_formula">https://w3id.org/linkml/pv_formula</seealso>
    let pv_formula = Prefixed_Name(linkml, "pv_formula") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/pv_formula_options</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/pv_formula_options">https://w3id.org/linkml/pv_formula_options</seealso>
    let pv_formula_options = Prefixed_Name(linkml, "pv_formula_options") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/quote_char</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/quote_char">https://w3id.org/linkml/quote_char</seealso>
    let quote_char = Prefixed_Name(linkml, "quote_char") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/range">https://w3id.org/linkml/range</seealso>
    let range = Prefixed_Name(linkml, "range") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/range_expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"range_expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/range_expression">https://w3id.org/linkml/range_expression</seealso>
    let range_expression = Prefixed_Name(linkml, "range_expression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"rank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/rank">https://w3id.org/linkml/rank</seealso>
    let rank = Prefixed_Name(linkml, "rank") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/rdf-xml</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/rdf-xml">https://w3id.org/linkml/rdf-xml</seealso>
    let rdf_xml = Prefixed_Name(linkml, "rdf-xml") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/reachable_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"reachable_from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/reachable_from">https://w3id.org/linkml/reachable_from</seealso>
    let reachable_from = Prefixed_Name(linkml, "reachable_from") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/readonly</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"readonly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/readonly">https://w3id.org/linkml/readonly</seealso>
    let readonly = Prefixed_Name(linkml, "readonly") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/recommended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"recommended"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/recommended">https://w3id.org/linkml/recommended</seealso>
    let recommended = Prefixed_Name(linkml, "recommended") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/reflexive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"reflexive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/reflexive">https://w3id.org/linkml/reflexive</seealso>
    let reflexive = Prefixed_Name(linkml, "reflexive") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/reflexive_transitive_form_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"reflexive_transitive_form_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/reflexive_transitive_form_of">https://w3id.org/linkml/reflexive_transitive_form_of</seealso>
    let reflexive_transitive_form_of =
        Prefixed_Name(linkml, "reflexive_transitive_form_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/related_mappings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"related mappings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/related_mappings">https://w3id.org/linkml/related_mappings</seealso>
    let related_mappings = Prefixed_Name(linkml, "related_mappings") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/relational_logical_characteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"relational_logical_characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/relational_logical_characteristic">https://w3id.org/linkml/relational_logical_characteristic</seealso>
    let relational_logical_characteristic =
        Prefixed_Name(linkml, "relational_logical_characteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/relational_role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"relational_role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/relational_role">https://w3id.org/linkml/relational_role</seealso>
    let relational_role = Prefixed_Name(linkml, "relational_role") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/relational_role_enum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/relational_role_enum">https://w3id.org/linkml/relational_role_enum</seealso>
    let relational_role_enum =
        Prefixed_Name(linkml, "relational_role_enum") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/relationship_types</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"relationship_types"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/relationship_types">https://w3id.org/linkml/relationship_types</seealso>
    let relationship_types = Prefixed_Name(linkml, "relationship_types") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/reporting</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SchemaDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/reporting">https://w3id.org/linkml/reporting</seealso>
    let reporting = Prefixed_Name(linkml, "reporting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/repr</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"repr"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/repr">https://w3id.org/linkml/repr</seealso>
    let repr = Prefixed_Name(linkml, "repr") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/represents_relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"represents_relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/represents_relationship">https://w3id.org/linkml/represents_relationship</seealso>
    let represents_relationship =
        Prefixed_Name(linkml, "represents_relationship") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/required</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"required"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/required">https://w3id.org/linkml/required</seealso>
    let required = Prefixed_Name(linkml, "required") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/resources</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/resources">https://w3id.org/linkml/resources</seealso>
    let resources = Prefixed_Name(linkml, "resources") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/results</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/results">https://w3id.org/linkml/results</seealso>
    let results = Prefixed_Name(linkml, "results") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/reversed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"reversed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/reversed">https://w3id.org/linkml/reversed</seealso>
    let reversed = Prefixed_Name(linkml, "reversed") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/role">https://w3id.org/linkml/role</seealso>
    let role = Prefixed_Name(linkml, "role") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/rules</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"rules"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/rules">https://w3id.org/linkml/rules</seealso>
    let rules = Prefixed_Name(linkml, "rules") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/schema_definition_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/schema_definition_name">https://w3id.org/linkml/schema_definition_name</seealso>
    let schema_definition_name =
        Prefixed_Name(linkml, "schema_definition_name") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/see_also</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"see_also"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/see_also">https://w3id.org/linkml/see_also</seealso>
    let see_also = Prefixed_Name(linkml, "see_also") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/setting_key</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"setting_key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/setting_key">https://w3id.org/linkml/setting_key</seealso>
    let setting_key = Prefixed_Name(linkml, "setting_key") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/setting_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"setting_value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/setting_value">https://w3id.org/linkml/setting_value</seealso>
    let setting_value = Prefixed_Name(linkml, "setting_value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/settings</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"settings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/settings">https://w3id.org/linkml/settings</seealso>
    let settings = Prefixed_Name(linkml, "settings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/severity">https://w3id.org/linkml/severity</seealso>
    let severity = Prefixed_Name(linkml, "severity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/severity_options</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/severity_options">https://w3id.org/linkml/severity_options</seealso>
    let severity_options = Prefixed_Name(linkml, "severity_options") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/sha256</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/sha256">https://w3id.org/linkml/sha256</seealso>
    let sha256 = Prefixed_Name(linkml, "sha256") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/shared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"shared"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/shared">https://w3id.org/linkml/shared</seealso>
    let shared = Prefixed_Name(linkml, "shared") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/singular_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"singular_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/singular_name">https://w3id.org/linkml/singular_name</seealso>
    let singular_name = Prefixed_Name(linkml, "singular_name") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/slot_conditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"slot_conditions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/slot_conditions">https://w3id.org/linkml/slot_conditions</seealso>
    let slot_conditions = Prefixed_Name(linkml, "slot_conditions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_definition_apply_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/slot_definition_apply_to">https://w3id.org/linkml/slot_definition_apply_to</seealso>
    let slot_definition_apply_to =
        Prefixed_Name(linkml, "slot_definition_apply_to") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_definition_disjoint_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/slot_definition_disjoint_with">https://w3id.org/linkml/slot_definition_disjoint_with</seealso>
    let slot_definition_disjoint_with =
        Prefixed_Name(linkml, "slot_definition_disjoint_with") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_definition_is_a</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/slot_definition_is_a">https://w3id.org/linkml/slot_definition_is_a</seealso>
    let slot_definition_is_a =
        Prefixed_Name(linkml, "slot_definition_is_a") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_definition_mixins</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/slot_definition_mixins">https://w3id.org/linkml/slot_definition_mixins</seealso>
    let slot_definition_mixins =
        Prefixed_Name(linkml, "slot_definition_mixins") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_definition_union_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/slot_definition_union_of">https://w3id.org/linkml/slot_definition_union_of</seealso>
    let slot_definition_union_of =
        Prefixed_Name(linkml, "slot_definition_union_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_definitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"slot_definitions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/slot_definitions">https://w3id.org/linkml/slot_definitions</seealso>
    let slot_definitions = Prefixed_Name(linkml, "slot_definitions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_expression_all_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/slot_expression_all_of">https://w3id.org/linkml/slot_expression_all_of</seealso>
    let slot_expression_all_of =
        Prefixed_Name(linkml, "slot_expression_all_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_expression_any_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/slot_expression_any_of">https://w3id.org/linkml/slot_expression_any_of</seealso>
    let slot_expression_any_of =
        Prefixed_Name(linkml, "slot_expression_any_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_expression_exactly_one_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/slot_expression_exactly_one_of">https://w3id.org/linkml/slot_expression_exactly_one_of</seealso>
    let slot_expression_exactly_one_of =
        Prefixed_Name(linkml, "slot_expression_exactly_one_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_expression_none_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/slot_expression_none_of">https://w3id.org/linkml/slot_expression_none_of</seealso>
    let slot_expression_none_of =
        Prefixed_Name(linkml, "slot_expression_none_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_group</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/AnonymousClassExpression</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"slot_group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/slot_group">https://w3id.org/linkml/slot_group</seealso>
    let slot_group = Prefixed_Name(linkml, "slot_group") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/slot_names_unique</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"slot_names_unique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/slot_names_unique">https://w3id.org/linkml/slot_names_unique</seealso>
    let slot_names_unique = Prefixed_Name(linkml, "slot_names_unique") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_range_violation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/slot_range_violation">https://w3id.org/linkml/slot_range_violation</seealso>
    let slot_range_violation =
        Prefixed_Name(linkml, "slot_range_violation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/slot_uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"slot_uri"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/slot_uri">https://w3id.org/linkml/slot_uri</seealso>
    let slot_uri = Prefixed_Name(linkml, "slot_uri") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/slot_usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"slot_usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/slot_usage">https://w3id.org/linkml/slot_usage</seealso>
    let slot_usage = Prefixed_Name(linkml, "slot_usage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/slots</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"slots"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/slots">https://w3id.org/linkml/slots</seealso>
    let slots = Prefixed_Name(linkml, "slots") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/source</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/source">https://w3id.org/linkml/source</seealso>
    let source = Prefixed_Name(linkml, "source") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/source_file</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"source_file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/source_file">https://w3id.org/linkml/source_file</seealso>
    let source_file = Prefixed_Name(linkml, "source_file") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/source_file_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"source_file_date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/source_file_date">https://w3id.org/linkml/source_file_date</seealso>
    let source_file_date = Prefixed_Name(linkml, "source_file_date") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/source_file_size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"source_file_size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/source_file_size">https://w3id.org/linkml/source_file_size</seealso>
    let source_file_size = Prefixed_Name(linkml, "source_file_size") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/source_nodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"source_nodes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/source_nodes">https://w3id.org/linkml/source_nodes</seealso>
    let source_nodes = Prefixed_Name(linkml, "source_nodes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/source_ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"source_ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/source_ontology">https://w3id.org/linkml/source_ontology</seealso>
    let source_ontology = Prefixed_Name(linkml, "source_ontology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/sparqlpath</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/sparqlpath">https://w3id.org/linkml/sparqlpath</seealso>
    let sparqlpath = Prefixed_Name(linkml, "sparqlpath") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/status</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/Example</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/status">https://w3id.org/linkml/status</seealso>
    let status = Prefixed_Name(linkml, "status") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/string</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/string">https://w3id.org/linkml/string</seealso>
    let string = Prefixed_Name(linkml, "string") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/string_serialization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"string_serialization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/string_serialization">https://w3id.org/linkml/string_serialization</seealso>
    let string_serialization =
        Prefixed_Name(linkml, "string_serialization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/structured_alias_categories</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>w3id:linkml/Example</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/structured_alias_categories">https://w3id.org/linkml/structured_alias_categories</seealso>
    let structured_alias_categories =
        Prefixed_Name(linkml, "structured_alias_categories") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/structured_aliases</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"structured_aliases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/structured_aliases">https://w3id.org/linkml/structured_aliases</seealso>
    let structured_aliases = Prefixed_Name(linkml, "structured_aliases") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/structured_imports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"structured_imports"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/structured_imports">https://w3id.org/linkml/structured_imports</seealso>
    let structured_imports = Prefixed_Name(linkml, "structured_imports") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/structured_pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"structured_pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/structured_pattern">https://w3id.org/linkml/structured_pattern</seealso>
    let structured_pattern = Prefixed_Name(linkml, "structured_pattern") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/subclass_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"subclass_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/subclass_of">https://w3id.org/linkml/subclass_of</seealso>
    let subclass_of = Prefixed_Name(linkml, "subclass_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/subject">https://w3id.org/linkml/subject</seealso>
    let subject = Prefixed_Name(linkml, "subject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/subproperty_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>w3id:linkml/Example</para>
    ///
    /// labels<para>"subproperty_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/subproperty_of">https://w3id.org/linkml/subproperty_of</seealso>
    let subproperty_of = Prefixed_Name(linkml, "subproperty_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/subsets</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"subsets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/subsets">https://w3id.org/linkml/subsets</seealso>
    let subsets = Prefixed_Name(linkml, "subsets") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/symbol">https://w3id.org/linkml/symbol</seealso>
    let symbol = Prefixed_Name(linkml, "symbol") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/symmetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"symmetric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/symmetric">https://w3id.org/linkml/symmetric</seealso>
    let symmetric = Prefixed_Name(linkml, "symmetric") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/syntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"syntax"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/syntax">https://w3id.org/linkml/syntax</seealso>
    let syntax = Prefixed_Name(linkml, "syntax") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/tag</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/tag">https://w3id.org/linkml/tag</seealso>
    let tag = Prefixed_Name(linkml, "tag") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/test_roles</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/test_roles">https://w3id.org/linkml/test_roles</seealso>
    let test_roles = Prefixed_Name(linkml, "test_roles") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/text">https://w3id.org/linkml/text</seealso>
    let text = Prefixed_Name(linkml, "text") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/themes</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/themes">https://w3id.org/linkml/themes</seealso>
    let themes = Prefixed_Name(linkml, "themes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/time</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/time">https://w3id.org/linkml/time</seealso>
    let time = Prefixed_Name(linkml, "time") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/title">https://w3id.org/linkml/title</seealso>
    let title = Prefixed_Name(linkml, "title") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/todos</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"todos"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/todos">https://w3id.org/linkml/todos</seealso>
    let todos = Prefixed_Name(linkml, "todos") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/transitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"transitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/transitive">https://w3id.org/linkml/transitive</seealso>
    let transitive = Prefixed_Name(linkml, "transitive") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/transitive_form_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"transitive_form_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/transitive_form_of">https://w3id.org/linkml/transitive_form_of</seealso>
    let transitive_form_of = Prefixed_Name(linkml, "transitive_form_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/traverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"traverse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/traverse">https://w3id.org/linkml/traverse</seealso>
    let traverse = Prefixed_Name(linkml, "traverse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/traverse_up</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"traverse_up"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/traverse_up">https://w3id.org/linkml/traverse_up</seealso>
    let traverse_up = Prefixed_Name(linkml, "traverse_up") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/tree_root</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"tree_root"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/tree_root">https://w3id.org/linkml/tree_root</seealso>
    let tree_root = Prefixed_Name(linkml, "tree_root") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/type</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/type">https://w3id.org/linkml/type</seealso>
    let type_ = Prefixed_Name(linkml, "type") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/type_definition_union_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/type_definition_union_of">https://w3id.org/linkml/type_definition_union_of</seealso>
    let type_definition_union_of =
        Prefixed_Name(linkml, "type_definition_union_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/type_expression_all_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/type_expression_all_of">https://w3id.org/linkml/type_expression_all_of</seealso>
    let type_expression_all_of =
        Prefixed_Name(linkml, "type_expression_all_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/type_expression_any_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/type_expression_any_of">https://w3id.org/linkml/type_expression_any_of</seealso>
    let type_expression_any_of =
        Prefixed_Name(linkml, "type_expression_any_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/type_expression_exactly_one_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/type_expression_exactly_one_of">https://w3id.org/linkml/type_expression_exactly_one_of</seealso>
    let type_expression_exactly_one_of =
        Prefixed_Name(linkml, "type_expression_exactly_one_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/type_expression_none_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/type_expression_none_of">https://w3id.org/linkml/type_expression_none_of</seealso>
    let type_expression_none_of =
        Prefixed_Name(linkml, "type_expression_none_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/type_mappings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"type_mappings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/type_mappings">https://w3id.org/linkml/type_mappings</seealso>
    let type_mappings = Prefixed_Name(linkml, "type_mappings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/type_uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"type_uri"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/type_uri">https://w3id.org/linkml/type_uri</seealso>
    let type_uri = Prefixed_Name(linkml, "type_uri") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/typeof</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"typeof"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/typeof">https://w3id.org/linkml/typeof</seealso>
    let typeof = Prefixed_Name(linkml, "typeof") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/types</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>w3id:linkml/SchemaDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"types"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/types">https://w3id.org/linkml/types</seealso>
    let types = Prefixed_Name(linkml, "types") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/ucum_code</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ucum_code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/ucum_code">https://w3id.org/linkml/ucum_code</seealso>
    let ucum_code = Prefixed_Name(linkml, "ucum_code") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/undeclared_slot</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/undeclared_slot">https://w3id.org/linkml/undeclared_slot</seealso>
    let undeclared_slot = Prefixed_Name(linkml, "undeclared_slot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/union_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"union_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/union_of">https://w3id.org/linkml/union_of</seealso>
    let union_of = Prefixed_Name(linkml, "union_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/unique_key_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"unique_key_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/unique_key_name">https://w3id.org/linkml/unique_key_name</seealso>
    let unique_key_name = Prefixed_Name(linkml, "unique_key_name") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/unique_key_slots</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"unique_key_slots"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/unique_key_slots">https://w3id.org/linkml/unique_key_slots</seealso>
    let unique_key_slots = Prefixed_Name(linkml, "unique_key_slots") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/unique_keys</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"unique_keys"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/unique_keys">https://w3id.org/linkml/unique_keys</seealso>
    let unique_keys = Prefixed_Name(linkml, "unique_keys") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/unit">https://w3id.org/linkml/unit</seealso>
    let unit = Prefixed_Name(linkml, "unit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/units</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SchemaDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/units">https://w3id.org/linkml/units</seealso>
    let units = Prefixed_Name(linkml, "units") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/uri">https://w3id.org/linkml/uri</seealso>
    let uri = Prefixed_Name(linkml, "uri") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/uriorcurie</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/uriorcurie">https://w3id.org/linkml/uriorcurie</seealso>
    let uriorcurie = Prefixed_Name(linkml, "uriorcurie") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/usage_slot_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"usage_slot_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/usage_slot_name">https://w3id.org/linkml/usage_slot_name</seealso>
    let usage_slot_name = Prefixed_Name(linkml, "usage_slot_name") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/validationReport__results</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/validationReport__results">https://w3id.org/linkml/validationReport__results</seealso>
    let validationReport__results =
        Prefixed_Name(linkml, "validationReport__results") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/value">https://w3id.org/linkml/value</seealso>
    let value = Prefixed_Name(linkml, "value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/value_description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"value_description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/value_description">https://w3id.org/linkml/value_description</seealso>
    let value_description = Prefixed_Name(linkml, "value_description") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/value_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"value_object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/value_object">https://w3id.org/linkml/value_object</seealso>
    let value_object = Prefixed_Name(linkml, "value_object") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/value_presence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"value_presence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/value_presence">https://w3id.org/linkml/value_presence</seealso>
    let value_presence = Prefixed_Name(linkml, "value_presence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/value_specification_constant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"value_specification_constant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/value_specification_constant">https://w3id.org/linkml/value_specification_constant</seealso>
    let value_specification_constant =
        Prefixed_Name(linkml, "value_specification_constant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:linkml/values_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///
    /// labels<para>"values_from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/values_from">https://w3id.org/linkml/values_from</seealso>
    let values_from = Prefixed_Name(linkml, "values_from") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/version</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/linkml/version">https://w3id.org/linkml/version</seealso>
    let version = Prefixed_Name(linkml, "version") |> PrefixedName
    /// <summary>
    ///   <para>w3id:linkml/was_derived_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/was_derived_from">https://w3id.org/linkml/was_derived_from</seealso>
    let was_derived_from = Prefixed_Name(linkml, "was_derived_from") |> PrefixedName
