namespace http.www.linkedmodel.org.schema.dtype.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dtype =
    let _namespace_iri = Namespace_Iri dtype |> NamespaceIRI
    /// <summary>
    ///   <para>dtype:CodeList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Codelist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#CodeList">http://www.linkedmodel.org/schema/dtype#CodeList</seealso>
    let CodeList = Prefixed_Name(dtype, "CodeList") |> PrefixedName
    /// <summary>
    ///   <para>dtype:CompositeCodeList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Composite Code List"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#CompositeCodeList">http://www.linkedmodel.org/schema/dtype#CompositeCodeList</seealso>
    let CompositeCodeList = Prefixed_Name(dtype, "CompositeCodeList") |> PrefixedName
    /// <summary>
    ///   <para>dtype:DerivedCodeList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Derived Code List"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#DerivedCodeList">http://www.linkedmodel.org/schema/dtype#DerivedCodeList</seealso>
    let DerivedCodeList = Prefixed_Name(dtype, "DerivedCodeList") |> PrefixedName
    /// <summary>
    ///   <para>dtype:EnumeratedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DTYPE Enumerated value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#EnumeratedValue">http://www.linkedmodel.org/schema/dtype#EnumeratedValue</seealso>
    let EnumeratedValue = Prefixed_Name(dtype, "EnumeratedValue") |> PrefixedName
    /// <summary>
    ///   <para>dtype:Enumeration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DTYPE Enumeration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#Enumeration">http://www.linkedmodel.org/schema/dtype#Enumeration</seealso>
    let Enumeration = Prefixed_Name(dtype, "Enumeration") |> PrefixedName
    /// <summary>
    ///   <para>dtype:SimpleCodeList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Simple Code List"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#SimpleCodeList">http://www.linkedmodel.org/schema/dtype#SimpleCodeList</seealso>
    let SimpleCodeList = Prefixed_Name(dtype, "SimpleCodeList") |> PrefixedName
    /// <summary>
    ///   <para>dtype:ValueReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Value Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#ValueReference">http://www.linkedmodel.org/schema/dtype#ValueReference</seealso>
    let ValueReference = Prefixed_Name(dtype, "ValueReference") |> PrefixedName
    /// <summary>
    ///   <para>dtype:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#code">http://www.linkedmodel.org/schema/dtype#code</seealso>
    let code = Prefixed_Name(dtype, "code") |> PrefixedName
    /// <summary>
    ///   <para>dtype:compositeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"composite of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#compositeOf">http://www.linkedmodel.org/schema/dtype#compositeOf</seealso>
    let compositeOf = Prefixed_Name(dtype, "compositeOf") |> PrefixedName
    /// <summary>
    ///   <para>dtype:defaultValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"default value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#defaultValue">http://www.linkedmodel.org/schema/dtype#defaultValue</seealso>
    let defaultValue = Prefixed_Name(dtype, "defaultValue") |> PrefixedName
    /// <summary>
    ///   <para>dtype:derivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"derived from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#derivedFrom">http://www.linkedmodel.org/schema/dtype#derivedFrom</seealso>
    let derivedFrom = Prefixed_Name(dtype, "derivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>dtype:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#hasMember">http://www.linkedmodel.org/schema/dtype#hasMember</seealso>
    let hasMember = Prefixed_Name(dtype, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>dtype:isInvalid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is invalid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#isInvalid">http://www.linkedmodel.org/schema/dtype#isInvalid</seealso>
    let isInvalid = Prefixed_Name(dtype, "isInvalid") |> PrefixedName
    /// <summary>
    ///   <para>dtype:literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"literal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#literal">http://www.linkedmodel.org/schema/dtype#literal</seealso>
    let literal = Prefixed_Name(dtype, "literal") |> PrefixedName
    /// <summary>
    ///   <para>dtype:numericUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"numeric union"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#numericUnion">http://www.linkedmodel.org/schema/dtype#numericUnion</seealso>
    let numericUnion = Prefixed_Name(dtype, "numericUnion") |> PrefixedName
    /// <summary>
    ///   <para>dtype:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"order"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#order">http://www.linkedmodel.org/schema/dtype#order</seealso>
    let order = Prefixed_Name(dtype, "order") |> PrefixedName
    /// <summary>
    ///   <para>dtype:orderIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"order index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#orderIndex">http://www.linkedmodel.org/schema/dtype#orderIndex</seealso>
    let orderIndex = Prefixed_Name(dtype, "orderIndex") |> PrefixedName
    /// <summary>
    ///   <para>dtype:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#position">http://www.linkedmodel.org/schema/dtype#position</seealso>
    let position = Prefixed_Name(dtype, "position") |> PrefixedName
    /// <summary>
    ///   <para>dtype:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"refers to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#refersTo">http://www.linkedmodel.org/schema/dtype#refersTo</seealso>
    let refersTo = Prefixed_Name(dtype, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>dtype:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"datatype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#type">http://www.linkedmodel.org/schema/dtype#type</seealso>
    let type_ = Prefixed_Name(dtype, "type") |> PrefixedName
    /// <summary>
    ///   <para>dtype:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/dtype#value">http://www.linkedmodel.org/schema/dtype#value</seealso>
    let value = Prefixed_Name(dtype, "value") |> PrefixedName
