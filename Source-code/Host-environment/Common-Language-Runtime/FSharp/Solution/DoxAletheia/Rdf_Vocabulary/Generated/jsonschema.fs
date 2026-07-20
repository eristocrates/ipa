namespace https.www.w3.org._2019.wot.json_schema.hash

open DoxAletheia

module jsonschema =
    let _namespace_name = "https://www.w3.org/2019/wot/json-schema#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Metadata describing data of type array. This subclass is indicated by the value &lt;code&gt;array&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#ArraySchema"></see></summary>
    let ArraySchema = _prefix "ArraySchema"
    /// <summary>
    /// Metadata that describes the data format used. It can be used for validation.
    /// <see href="https://www.w3.org/2019/wot/json-schema#DataSchema"></see></summary>
    let DataSchema = _prefix "DataSchema"
    /// <summary>
    /// Metadata describing data of type &lt;code&gt;boolean&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;boolean&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#BooleanSchema"></see></summary>
    let BooleanSchema = _prefix "BooleanSchema"
    /// <summary>
    /// Metadata describing data of type &lt;code&gt;integer&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;integer&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#IntegerSchema"></see></summary>
    let IntegerSchema = _prefix "IntegerSchema"
    /// <summary>
    /// Metadata describing data of type &lt;code&gt;null&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;null&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances. This Subclass describes only one acceptable value, namely &lt;code&gt;null&lt;/code&gt;. It can be used as part of a &lt;code&gt;oneOf&lt;/code&gt; declaration, where it is used to indicate, that the data can also be &lt;code&gt;null&lt;/code&gt;.
    /// <see href="https://www.w3.org/2019/wot/json-schema#NullSchema"></see></summary>
    let NullSchema = _prefix "NullSchema"
    /// <summary>
    /// Metadata describing data of type &lt;code&gt;number&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;number&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#NumberSchema"></see></summary>
    let NumberSchema = _prefix "NumberSchema"
    /// <summary>
    /// Metadata describing data of type &lt;code&gt;object&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;object&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#ObjectSchema"></see></summary>
    let ObjectSchema = _prefix "ObjectSchema"
    /// <summary>
    /// Metadata describing data of type &lt;code&gt;string&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;string&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#StringSchema"></see></summary>
    let StringSchema = _prefix "StringSchema"
    /// <summary>
    /// Used to ensure that the data is valid against all of the specified schemas in the array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#allOf"></see></summary>
    let allOf = _prefix "allOf"
    /// <summary>
    /// Used to ensure that the data is valid against any of the specified schemas in the array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#anyOf"></see></summary>
    let anyOf = _prefix "anyOf"
    /// <summary>
    /// Provides a constant value.
    /// <see href="https://www.w3.org/2019/wot/json-schema#const"></see></summary>
    let const_ = _prefix "const"
    /// <summary>
    /// Can be used to decorate a user interface with information about the data produced by this user interface. a description will provide explanation about the purpose of the instance described by this schema.
    /// <see href="https://www.w3.org/2019/wot/json-schema#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Restricted set of values provided as an array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#enum"></see></summary>
    let enum = _prefix "enum"
    /// <summary>
    /// Allows validation based on a format pattern such as "date-time", "email", "uri", etc.
    /// <see href="https://www.w3.org/2019/wot/json-schema#format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// Used to define the characteristics of an array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#items"></see></summary>
    let items = _prefix "items"
    /// <summary>
    /// Defines the maximum number of items that have to be in the array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#maxItems"></see></summary>
    let maxItems = _prefix "maxItems"
    /// <summary>
    /// Specifies a maximum numeric value. Only applicable for associated number or integer types.
    /// <see href="https://www.w3.org/2019/wot/json-schema#maximum"></see></summary>
    let maximum = _prefix "maximum"
    /// <summary>
    /// Defines the minimum number of items that have to be in the array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#minItems"></see></summary>
    let minItems = _prefix "minItems"
    /// <summary>
    /// Specifies a minimum numeric value. Only applicable for associated number or integer types.
    /// <see href="https://www.w3.org/2019/wot/json-schema#minimum"></see></summary>
    let minimum = _prefix "minimum"
    /// <summary>
    /// Used to ensure that the data is valid against exactly one of the specified schemas in the array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#oneOf"></see></summary>
    let oneOf = _prefix "oneOf"
    /// <summary>
    /// Data schema nested definitions
    /// <see href="https://www.w3.org/2019/wot/json-schema#properties"></see></summary>
    let properties = _prefix "properties"
    /// <summary>
    /// Used to store the indexing name in the parent object when this schema appears as a property of an object schema.
    /// <see href="https://www.w3.org/2019/wot/json-schema#propertyName"></see></summary>
    let propertyName = _prefix "propertyName"
    /// <summary>
    /// Boolean value that is a hint to indicate whether a property interaction / value is read only (=true) or not (=false)
    /// <see href="https://www.w3.org/2019/wot/json-schema#readOnly"></see></summary>
    let readOnly = _prefix "readOnly"
    /// <summary>
    /// Defines which members of the object type are mandatory.
    /// <see href="https://www.w3.org/2019/wot/json-schema#required"></see></summary>
    let required = _prefix "required"
    /// <summary>
    /// Can be used to decorate a user interface with information about the data produced by this user interface. A title will preferably be short.
    /// <see href="https://www.w3.org/2019/wot/json-schema#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Boolean value that is a hint to indicate whether a property interaction / value is write only (=true) or not (=false)
    /// <see href="https://www.w3.org/2019/wot/json-schema#writeOnly"></see></summary>
    let writeOnly = _prefix "writeOnly"
