namespace https.www.w3.org._2019.wot.json_schema.hash

open DoxAletheia.Rdf_Vocabulary

module jsonschema =
    let _namespace_name = "https://www.w3.org/2019/wot/json-schema#"

    /// <summary>
    /// Metadata describing data of type array. This subclass is indicated by the value &lt;code&gt;array&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#ArraySchema"></see></summary>
    let ArraySchema =
        Namespaced_IRI.parse _namespace_name "ArraySchema" |> NamespacedName

    /// <summary>
    /// Metadata that describes the data format used. It can be used for validation.
    /// <see href="https://www.w3.org/2019/wot/json-schema#DataSchema"></see></summary>
    let DataSchema = Namespaced_IRI.parse _namespace_name "DataSchema" |> NamespacedName

    /// <summary>
    /// Metadata describing data of type &lt;code&gt;boolean&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;boolean&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#BooleanSchema"></see></summary>
    let BooleanSchema =
        Namespaced_IRI.parse _namespace_name "BooleanSchema" |> NamespacedName

    /// <summary>
    /// Metadata describing data of type &lt;code&gt;integer&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;integer&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#IntegerSchema"></see></summary>
    let IntegerSchema =
        Namespaced_IRI.parse _namespace_name "IntegerSchema" |> NamespacedName

    /// <summary>
    /// Metadata describing data of type &lt;code&gt;null&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;null&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances. This Subclass describes only one acceptable value, namely &lt;code&gt;null&lt;/code&gt;. It can be used as part of a &lt;code&gt;oneOf&lt;/code&gt; declaration, where it is used to indicate, that the data can also be &lt;code&gt;null&lt;/code&gt;.
    /// <see href="https://www.w3.org/2019/wot/json-schema#NullSchema"></see></summary>
    let NullSchema = Namespaced_IRI.parse _namespace_name "NullSchema" |> NamespacedName

    /// <summary>
    /// Metadata describing data of type &lt;code&gt;number&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;number&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#NumberSchema"></see></summary>
    let NumberSchema =
        Namespaced_IRI.parse _namespace_name "NumberSchema" |> NamespacedName

    /// <summary>
    /// Metadata describing data of type &lt;code&gt;object&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;object&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#ObjectSchema"></see></summary>
    let ObjectSchema =
        Namespaced_IRI.parse _namespace_name "ObjectSchema" |> NamespacedName

    /// <summary>
    /// Metadata describing data of type &lt;code&gt;string&lt;/code&gt;. This subclass is indicated by the value &lt;code&gt;string&lt;/code&gt; assigned to &lt;code&gt;type&lt;/code&gt; in &lt;code&gt;DataSchema&lt;/code&gt; instances.
    /// <see href="https://www.w3.org/2019/wot/json-schema#StringSchema"></see></summary>
    let StringSchema =
        Namespaced_IRI.parse _namespace_name "StringSchema" |> NamespacedName

    /// <summary>
    /// Used to ensure that the data is valid against all of the specified schemas in the array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#allOf"></see></summary>
    let allOf = Namespaced_IRI.parse _namespace_name "allOf" |> NamespacedName
    /// <summary>
    /// Used to ensure that the data is valid against any of the specified schemas in the array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#anyOf"></see></summary>
    let anyOf = Namespaced_IRI.parse _namespace_name "anyOf" |> NamespacedName
    /// <summary>
    /// Provides a constant value.
    /// <see href="https://www.w3.org/2019/wot/json-schema#const"></see></summary>
    let const_ = Namespaced_IRI.parse _namespace_name "const" |> NamespacedName

    /// <summary>
    /// Can be used to decorate a user interface with information about the data produced by this user interface. a description will provide explanation about the purpose of the instance described by this schema.
    /// <see href="https://www.w3.org/2019/wot/json-schema#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Restricted set of values provided as an array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#enum"></see></summary>
    let enum = Namespaced_IRI.parse _namespace_name "enum" |> NamespacedName
    /// <summary>
    /// Allows validation based on a format pattern such as "date-time", "email", "uri", etc.
    /// <see href="https://www.w3.org/2019/wot/json-schema#format"></see></summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName
    /// <summary>
    /// Used to define the characteristics of an array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#items"></see></summary>
    let items = Namespaced_IRI.parse _namespace_name "items" |> NamespacedName
    /// <summary>
    /// Defines the maximum number of items that have to be in the array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#maxItems"></see></summary>
    let maxItems = Namespaced_IRI.parse _namespace_name "maxItems" |> NamespacedName
    /// <summary>
    /// Specifies a maximum numeric value. Only applicable for associated number or integer types.
    /// <see href="https://www.w3.org/2019/wot/json-schema#maximum"></see></summary>
    let maximum = Namespaced_IRI.parse _namespace_name "maximum" |> NamespacedName
    /// <summary>
    /// Defines the minimum number of items that have to be in the array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#minItems"></see></summary>
    let minItems = Namespaced_IRI.parse _namespace_name "minItems" |> NamespacedName
    /// <summary>
    /// Specifies a minimum numeric value. Only applicable for associated number or integer types.
    /// <see href="https://www.w3.org/2019/wot/json-schema#minimum"></see></summary>
    let minimum = Namespaced_IRI.parse _namespace_name "minimum" |> NamespacedName
    /// <summary>
    /// Used to ensure that the data is valid against exactly one of the specified schemas in the array.
    /// <see href="https://www.w3.org/2019/wot/json-schema#oneOf"></see></summary>
    let oneOf = Namespaced_IRI.parse _namespace_name "oneOf" |> NamespacedName
    /// <summary>
    /// Data schema nested definitions
    /// <see href="https://www.w3.org/2019/wot/json-schema#properties"></see></summary>
    let properties = Namespaced_IRI.parse _namespace_name "properties" |> NamespacedName

    /// <summary>
    /// Used to store the indexing name in the parent object when this schema appears as a property of an object schema.
    /// <see href="https://www.w3.org/2019/wot/json-schema#propertyName"></see></summary>
    let propertyName =
        Namespaced_IRI.parse _namespace_name "propertyName" |> NamespacedName

    /// <summary>
    /// Boolean value that is a hint to indicate whether a property interaction / value is read only (=true) or not (=false)
    /// <see href="https://www.w3.org/2019/wot/json-schema#readOnly"></see></summary>
    let readOnly = Namespaced_IRI.parse _namespace_name "readOnly" |> NamespacedName
    /// <summary>
    /// Defines which members of the object type are mandatory.
    /// <see href="https://www.w3.org/2019/wot/json-schema#required"></see></summary>
    let required = Namespaced_IRI.parse _namespace_name "required" |> NamespacedName
    /// <summary>
    /// Can be used to decorate a user interface with information about the data produced by this user interface. A title will preferably be short.
    /// <see href="https://www.w3.org/2019/wot/json-schema#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// Boolean value that is a hint to indicate whether a property interaction / value is write only (=true) or not (=false)
    /// <see href="https://www.w3.org/2019/wot/json-schema#writeOnly"></see></summary>
    let writeOnly = Namespaced_IRI.parse _namespace_name "writeOnly" |> NamespacedName
