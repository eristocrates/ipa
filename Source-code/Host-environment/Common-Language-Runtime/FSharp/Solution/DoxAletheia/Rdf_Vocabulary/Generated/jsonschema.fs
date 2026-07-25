namespace https.www.w3.org._2019.wot.json_schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module jsonschema =
    let _namespace_iri = Namespace_Iri jsonschema |> NamespaceIRI
    /// <summary>
    ///   <para>jsonschema:ArraySchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata describing data of type array. This subclass is indicated by the value &lt;code&gt;array&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#ArraySchema">https://www.w3.org/2019/wot/json-schema#ArraySchema</seealso>
    let ArraySchema = Prefixed_Name(jsonschema, "ArraySchema") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:NullSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata describing data of type &lt;code&gt;null&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;null&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances. This Subclass describes only one acceptable value, namely &lt;code&gt;null&lt;/code&gt;. It can be used as part of a &lt;code&gt;oneOf&lt;/code&gt; declaration, where it is used to indicate, that the data can also be &lt;code&gt;null&lt;/code&gt;.</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#NullSchema">https://www.w3.org/2019/wot/json-schema#NullSchema</seealso>
    let NullSchema = Prefixed_Name(jsonschema, "NullSchema") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:ObjectSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata describing data of type &lt;code&gt;object&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;object&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#ObjectSchema">https://www.w3.org/2019/wot/json-schema#ObjectSchema</seealso>
    let ObjectSchema = Prefixed_Name(jsonschema, "ObjectSchema") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:const</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides a constant value.</para>
    /// labels<para>const</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#const">https://www.w3.org/2019/wot/json-schema#const</seealso>
    let const_ = Prefixed_Name(jsonschema, "const") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:enum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Restricted set of values provided as an array.</para>
    /// labels<para>enum</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#enum">https://www.w3.org/2019/wot/json-schema#enum</seealso>
    let enum = Prefixed_Name(jsonschema, "enum") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:items</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to define the characteristics of an array.</para>
    /// labels<para>items</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#items">https://www.w3.org/2019/wot/json-schema#items</seealso>
    let items = Prefixed_Name(jsonschema, "items") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:maximum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies a maximum numeric value. Only applicable for associated number or integer types.</para>
    /// labels<para>maximum</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#maximum">https://www.w3.org/2019/wot/json-schema#maximum</seealso>
    let maximum = Prefixed_Name(jsonschema, "maximum") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:oneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to ensure that the data is valid against exactly one of the specified schemas in the array.</para>
    /// labels<para>oneOf</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#oneOf">https://www.w3.org/2019/wot/json-schema#oneOf</seealso>
    let oneOf = Prefixed_Name(jsonschema, "oneOf") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data schema nested definitions</para>
    /// labels<para>properties</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#properties">https://www.w3.org/2019/wot/json-schema#properties</seealso>
    let properties = Prefixed_Name(jsonschema, "properties") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:required</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines which members of the object type are mandatory.</para>
    /// labels<para>required</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#required">https://www.w3.org/2019/wot/json-schema#required</seealso>
    let required = Prefixed_Name(jsonschema, "required") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:BooleanSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata describing data of type &lt;code&gt;boolean&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;boolean&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#BooleanSchema">https://www.w3.org/2019/wot/json-schema#BooleanSchema</seealso>
    let BooleanSchema = Prefixed_Name(jsonschema, "BooleanSchema") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:NumberSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata describing data of type &lt;code&gt;number&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;number&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#NumberSchema">https://www.w3.org/2019/wot/json-schema#NumberSchema</seealso>
    let NumberSchema = Prefixed_Name(jsonschema, "NumberSchema") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:allOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to ensure that the data is valid against all of the specified schemas in the array.</para>
    /// labels<para>allOf</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#allOf">https://www.w3.org/2019/wot/json-schema#allOf</seealso>
    let allOf = Prefixed_Name(jsonschema, "allOf") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:minItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the minimum number of items that have to be in the array.</para>
    /// labels<para>minItems</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#minItems">https://www.w3.org/2019/wot/json-schema#minItems</seealso>
    let minItems = Prefixed_Name(jsonschema, "minItems") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:propertyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Used to store the indexing name in the parent object when this schema appears as a property of an object schema.</para>
    /// labels<para>propertyName</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#propertyName">https://www.w3.org/2019/wot/json-schema#propertyName</seealso>
    let propertyName = Prefixed_Name(jsonschema, "propertyName") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Module for data schema specifications, part of the W3C Web of Things (WoT) Thing Description model</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#">https://www.w3.org/2019/wot/json-schema#</seealso>
    let _prefix_iri = Prefixed_Name(jsonschema, "") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:DataSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata that describes the data format used. It can be used for validation.</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#DataSchema">https://www.w3.org/2019/wot/json-schema#DataSchema</seealso>
    let DataSchema = Prefixed_Name(jsonschema, "DataSchema") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:IntegerSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata describing data of type &lt;code&gt;integer&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;integer&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#IntegerSchema">https://www.w3.org/2019/wot/json-schema#IntegerSchema</seealso>
    let IntegerSchema = Prefixed_Name(jsonschema, "IntegerSchema") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:StringSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata describing data of type &lt;code&gt;string&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;string&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#StringSchema">https://www.w3.org/2019/wot/json-schema#StringSchema</seealso>
    let StringSchema = Prefixed_Name(jsonschema, "StringSchema") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:anyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to ensure that the data is valid against any of the specified schemas in the array.</para>
    /// labels<para>anyOf</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#anyOf">https://www.w3.org/2019/wot/json-schema#anyOf</seealso>
    let anyOf = Prefixed_Name(jsonschema, "anyOf") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Can be used to decorate a user interface with information about the data produced by this user interface. a description will provide explanation about the purpose of the instance described by this schema.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#description">https://www.w3.org/2019/wot/json-schema#description</seealso>
    let description = Prefixed_Name(jsonschema, "description") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Allows validation based on a format pattern such as "date-time", "email", "uri", etc.</para>
    /// labels<para>format</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#format">https://www.w3.org/2019/wot/json-schema#format</seealso>
    let format = Prefixed_Name(jsonschema, "format") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:maxItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the maximum number of items that have to be in the array.</para>
    /// labels<para>maxItems</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#maxItems">https://www.w3.org/2019/wot/json-schema#maxItems</seealso>
    let maxItems = Prefixed_Name(jsonschema, "maxItems") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:minimum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies a minimum numeric value. Only applicable for associated number or integer types.</para>
    /// labels<para>minimum</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#minimum">https://www.w3.org/2019/wot/json-schema#minimum</seealso>
    let minimum = Prefixed_Name(jsonschema, "minimum") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:readOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Boolean value that is a hint to indicate whether a property interaction / value is read only (=true) or not (=false)</para>
    /// labels<para>readOnly</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#readOnly">https://www.w3.org/2019/wot/json-schema#readOnly</seealso>
    let readOnly = Prefixed_Name(jsonschema, "readOnly") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Can be used to decorate a user interface with information about the data produced by this user interface. A title will preferably be short.</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#title">https://www.w3.org/2019/wot/json-schema#title</seealso>
    let title = Prefixed_Name(jsonschema, "title") |> PrefixedName
    /// <summary>
    ///   <para>jsonschema:writeOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Boolean value that is a hint to indicate whether a property interaction / value is write only (=true) or not (=false)</para>
    /// labels<para>writeOnly</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/json-schema#writeOnly">https://www.w3.org/2019/wot/json-schema#writeOnly</seealso>
    let writeOnly = Prefixed_Name(jsonschema, "writeOnly") |> PrefixedName
