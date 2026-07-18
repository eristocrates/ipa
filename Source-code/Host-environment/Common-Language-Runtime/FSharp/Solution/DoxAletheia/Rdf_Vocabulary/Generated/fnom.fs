namespace https.w3id.org._function.vocabulary.mapping.hash

open DoxAletheia.Rdf_Vocabulary

module fnom =
    let _namespace_name = "https://w3id.org/function/vocabulary/mapping#"

    /// <summary>
    /// A constant parameter mapping uses a property string to map a parameter of an fno:Implementation to a constant value
    /// <see href="https://w3id.org/function/vocabulary/mapping#ConstantParameterMapping"></see></summary>
    let ConstantParameterMapping =
        Namespaced_IRI.parse _namespace_name "ConstantParameterMapping" |> NamespacedName

    /// <summary>
    /// A default return mapping links the return value of the method to a fno:Output
    /// <see href="https://w3id.org/function/vocabulary/mapping#DefaultReturnMapping"></see></summary>
    let DefaultReturnMapping =
        Namespaced_IRI.parse _namespace_name "DefaultReturnMapping" |> NamespacedName

    /// <summary>
    /// An exception return mapping links the thrown exception of the method to a fno:Output
    /// <see href="https://w3id.org/function/vocabulary/mapping#ExceptionReturnMapping"></see></summary>
    let ExceptionReturnMapping =
        Namespaced_IRI.parse _namespace_name "ExceptionReturnMapping" |> NamespacedName

    /// <summary>
    /// A position parameter mapping uses a position to map a parameter of an fno:Implementation to an fno:Parameter
    /// <see href="https://w3id.org/function/vocabulary/mapping#PositionParameterMapping"></see></summary>
    let PositionParameterMapping =
        Namespaced_IRI.parse _namespace_name "PositionParameterMapping" |> NamespacedName

    /// <summary>
    /// A property parameter mapping uses a property string to map a parameter of an fno:Implementation to an fno:Parameter
    /// <see href="https://w3id.org/function/vocabulary/mapping#PropertyParameterMapping"></see></summary>
    let PropertyParameterMapping =
        Namespaced_IRI.parse _namespace_name "PropertyParameterMapping" |> NamespacedName

    /// <summary>
    /// A string method mapping uses a string to map a method of an fno:Implementation to an fno:Function
    /// <see href="https://w3id.org/function/vocabulary/mapping#StringMethodMapping"></see></summary>
    let StringMethodMapping =
        Namespaced_IRI.parse _namespace_name "StringMethodMapping" |> NamespacedName

    /// <summary>
    /// Connects an implementation constant to a parameter value.
    /// <see href="https://w3id.org/function/vocabulary/mapping#constantParameterValue"></see></summary>
    let constantParameterValue =
        Namespaced_IRI.parse _namespace_name "constantParameterValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/function/vocabulary/mapping#ParameterMapping"></see>
    /// </summary>
    let ParameterMapping =
        Namespaced_IRI.parse _namespace_name "ParameterMapping" |> NamespacedName

    /// <summary>
    /// Connects a function output to a return mapping.
    /// <see href="https://w3id.org/function/vocabulary/mapping#functionOutput"></see></summary>
    let functionOutput =
        Namespaced_IRI.parse _namespace_name "functionOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/function/vocabulary/mapping#ReturnMapping"></see>
    /// </summary>
    let ReturnMapping =
        Namespaced_IRI.parse _namespace_name "ReturnMapping" |> NamespacedName

    /// <summary>
    /// Connects a function parameter to a parameter mapping.
    /// <see href="https://w3id.org/function/vocabulary/mapping#functionParameter"></see></summary>
    let functionParameter =
        Namespaced_IRI.parse _namespace_name "functionParameter" |> NamespacedName

    /// <summary>
    /// Connects an implementation parameter position to a parameter mapping.
    /// <see href="https://w3id.org/function/vocabulary/mapping#implementationParameterPosition"></see></summary>
    let implementationParameterPosition =
        Namespaced_IRI.parse _namespace_name "implementationParameterPosition" |> NamespacedName

    /// <summary>
    /// Connects an implementation parameter label to a parameter mapping.
    /// <see href="https://w3id.org/function/vocabulary/mapping#implementationProperty"></see></summary>
    let implementationProperty =
        Namespaced_IRI.parse _namespace_name "implementationProperty" |> NamespacedName

    /// <summary>
    /// Connects a method name to a method mapping.
    /// <see href="https://w3id.org/function/vocabulary/mapping#method-name"></see></summary>
    let ``method-name`` =
        Namespaced_IRI.parse _namespace_name "method-name" |> NamespacedName

    /// <summary>
    /// Flag indicating whether the parameter can be repeated.
    /// <see href="https://w3id.org/function/vocabulary/mapping#repeatableParameter"></see></summary>
    let repeatableParameter =
        Namespaced_IRI.parse _namespace_name "repeatableParameter" |> NamespacedName
