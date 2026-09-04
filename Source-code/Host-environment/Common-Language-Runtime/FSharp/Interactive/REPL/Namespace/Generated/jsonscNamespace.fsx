#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module jsonsc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.w3.org/2019/wot/json-schema#" "jsonsc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Metadata describing data of type array. This subclass is indicated by the value &lt;code&gt;array&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#ArraySchema">jsonsc:ArraySchema</a>
    /// </summary>
    let ArraySchema = _prefixId.prefix "ArraySchema"
    /// <summary>
    ///   <para>rdfs:comment : Metadata describing data of type &lt;code&gt;boolean&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;boolean&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#BooleanSchema">jsonsc:BooleanSchema</a>
    /// </summary>
    let BooleanSchema = _prefixId.prefix "BooleanSchema"
    /// <summary>
    ///   <para>rdfs:comment : Metadata that describes the data format used. It can be used for validation.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#DataSchema">jsonsc:DataSchema</a>
    /// </summary>
    let DataSchema = _prefixId.prefix "DataSchema"
    /// <summary>
    ///   <para>rdfs:comment : Metadata describing data of type &lt;code&gt;integer&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;integer&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#IntegerSchema">jsonsc:IntegerSchema</a>
    /// </summary>
    let IntegerSchema = _prefixId.prefix "IntegerSchema"
    /// <summary>
    ///   <para>rdfs:comment : Metadata describing data of type &lt;code&gt;null&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;null&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances. This Subclass describes only one acceptable value, namely &lt;code&gt;null&lt;/code&gt;. It can be used as part of a &lt;code&gt;oneOf&lt;/code&gt; declaration, where it is used to indicate, that the data can also be &lt;code&gt;null&lt;/code&gt;.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#NullSchema">jsonsc:NullSchema</a>
    /// </summary>
    let NullSchema = _prefixId.prefix "NullSchema"
    /// <summary>
    ///   <para>rdfs:comment : Metadata describing data of type &lt;code&gt;number&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;number&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#NumberSchema">jsonsc:NumberSchema</a>
    /// </summary>
    let NumberSchema = _prefixId.prefix "NumberSchema"
    /// <summary>
    ///   <para>rdfs:comment : Metadata describing data of type &lt;code&gt;object&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;object&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#ObjectSchema">jsonsc:ObjectSchema</a>
    /// </summary>
    let ObjectSchema = _prefixId.prefix "ObjectSchema"
    /// <summary>
    ///   <para>rdfs:comment : Metadata describing data of type &lt;code&gt;string&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;string&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#StringSchema">jsonsc:StringSchema</a>
    /// </summary>
    let StringSchema = _prefixId.prefix "StringSchema"
    /// <summary>
    ///   <para>rdfs:label : allOf^^xsd:string</para>
    ///   <para>rdfs:comment : Used to ensure that the data is valid against all of the specified schemas in the array.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#allOf">jsonsc:allOf</a>
    /// </summary>
    let allOf = _prefixId.prefix "allOf"
    /// <summary>
    ///   <para>rdfs:label : anyOf^^xsd:string</para>
    ///   <para>rdfs:comment : Used to ensure that the data is valid against any of the specified schemas in the array.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#anyOf">jsonsc:anyOf</a>
    /// </summary>
    let anyOf = _prefixId.prefix "anyOf"
    /// <summary>
    ///   <para>rdfs:label : const^^xsd:string</para>
    ///   <para>rdfs:comment : Provides a constant value.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#const">jsonsc:const</a>
    /// </summary>
    let const_ = _prefixId.prefix "const"
    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <para>rdfs:comment : Can be used to decorate a user interface with information about the data produced by this user interface. a description will provide explanation about the purpose of the instance described by this schema.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#description">jsonsc:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : enum^^xsd:string</para>
    ///   <para>rdfs:comment : Restricted set of values provided as an array.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#enum">jsonsc:enum</a>
    /// </summary>
    let enum = _prefixId.prefix "enum"
    /// <summary>
    ///   <para>rdfs:label : format^^xsd:string</para>
    ///   <para>rdfs:comment : Allows validation based on a format pattern such as "date-time", "email", "uri", etc.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#format">jsonsc:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>rdfs:label : items^^xsd:string</para>
    ///   <para>rdfs:comment : Used to define the characteristics of an array.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#items">jsonsc:items</a>
    /// </summary>
    let items = _prefixId.prefix "items"
    /// <summary>
    ///   <para>rdfs:label : maxItems^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the maximum number of items that have to be in the array.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#maxItems">jsonsc:maxItems</a>
    /// </summary>
    let maxItems = _prefixId.prefix "maxItems"
    /// <summary>
    ///   <para>rdfs:label : maximum^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a maximum numeric value. Only applicable for associated number or integer types.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#maximum">jsonsc:maximum</a>
    /// </summary>
    let maximum = _prefixId.prefix "maximum"
    /// <summary>
    ///   <para>rdfs:label : minItems^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the minimum number of items that have to be in the array.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#minItems">jsonsc:minItems</a>
    /// </summary>
    let minItems = _prefixId.prefix "minItems"
    /// <summary>
    ///   <para>rdfs:label : minimum^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a minimum numeric value. Only applicable for associated number or integer types.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#minimum">jsonsc:minimum</a>
    /// </summary>
    let minimum = _prefixId.prefix "minimum"
    /// <summary>
    ///   <para>rdfs:label : oneOf^^xsd:string</para>
    ///   <para>rdfs:comment : Used to ensure that the data is valid against exactly one of the specified schemas in the array.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#oneOf">jsonsc:oneOf</a>
    /// </summary>
    let oneOf = _prefixId.prefix "oneOf"
    /// <summary>
    ///   <para>rdfs:label : properties^^xsd:string</para>
    ///   <para>rdfs:comment : Data schema nested definitions</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#properties">jsonsc:properties</a>
    /// </summary>
    let properties = _prefixId.prefix "properties"
    /// <summary>
    ///   <para>rdfs:label : propertyName^^xsd:string</para>
    ///   <para>rdfs:comment : Used to store the indexing name in the parent object when this schema appears as a property of an object schema.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#propertyName">jsonsc:propertyName</a>
    /// </summary>
    let propertyName = _prefixId.prefix "propertyName"
    /// <summary>
    ///   <para>rdfs:label : readOnly^^xsd:string</para>
    ///   <para>rdfs:comment : Boolean value that is a hint to indicate whether a property interaction / value is read only (=true) or not (=false)</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#readOnly">jsonsc:readOnly</a>
    /// </summary>
    let readOnly = _prefixId.prefix "readOnly"
    /// <summary>
    ///   <para>rdfs:label : required^^xsd:string</para>
    ///   <para>rdfs:comment : Defines which members of the object type are mandatory.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#required">jsonsc:required</a>
    /// </summary>
    let required = _prefixId.prefix "required"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>rdfs:comment : Can be used to decorate a user interface with information about the data produced by this user interface. A title will preferably be short.</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#title">jsonsc:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : writeOnly^^xsd:string</para>
    ///   <para>rdfs:comment : Boolean value that is a hint to indicate whether a property interaction / value is write only (=true) or not (=false)</para>
    ///   <a href="https://www.w3.org/2019/wot/json-schema#writeOnly">jsonsc:writeOnly</a>
    /// </summary>
    let writeOnly = _prefixId.prefix "writeOnly"
