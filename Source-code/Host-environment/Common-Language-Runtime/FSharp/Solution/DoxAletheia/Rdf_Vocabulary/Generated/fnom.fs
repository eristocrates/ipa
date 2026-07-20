namespace https.w3id.org._function.vocabulary.mapping.hash

open DoxAletheia

module fnom =
    let _namespace_name = "https://w3id.org/function/vocabulary/mapping#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A constant parameter mapping uses a property string to map a parameter of an fno:Implementation to a constant value
    /// <see href="https://w3id.org/function/vocabulary/mapping#ConstantParameterMapping"></see></summary>
    let ConstantParameterMapping = _prefix "ConstantParameterMapping"
    /// <summary>
    /// A default return mapping links the return value of the method to a fno:Output
    /// <see href="https://w3id.org/function/vocabulary/mapping#DefaultReturnMapping"></see></summary>
    let DefaultReturnMapping = _prefix "DefaultReturnMapping"
    /// <summary>
    /// An exception return mapping links the thrown exception of the method to a fno:Output
    /// <see href="https://w3id.org/function/vocabulary/mapping#ExceptionReturnMapping"></see></summary>
    let ExceptionReturnMapping = _prefix "ExceptionReturnMapping"
    /// <summary>
    /// A position parameter mapping uses a position to map a parameter of an fno:Implementation to an fno:Parameter
    /// <see href="https://w3id.org/function/vocabulary/mapping#PositionParameterMapping"></see></summary>
    let PositionParameterMapping = _prefix "PositionParameterMapping"
    /// <summary>
    /// A property parameter mapping uses a property string to map a parameter of an fno:Implementation to an fno:Parameter
    /// <see href="https://w3id.org/function/vocabulary/mapping#PropertyParameterMapping"></see></summary>
    let PropertyParameterMapping = _prefix "PropertyParameterMapping"
    /// <summary>
    /// A string method mapping uses a string to map a method of an fno:Implementation to an fno:Function
    /// <see href="https://w3id.org/function/vocabulary/mapping#StringMethodMapping"></see></summary>
    let StringMethodMapping = _prefix "StringMethodMapping"
    /// <summary>
    /// Connects an implementation constant to a parameter value.
    /// <see href="https://w3id.org/function/vocabulary/mapping#constantParameterValue"></see></summary>
    let constantParameterValue = _prefix "constantParameterValue"
    /// <summary>
    ///   <see href="https://w3id.org/function/vocabulary/mapping#ParameterMapping"></see>
    /// </summary>
    let ParameterMapping = _prefix "ParameterMapping"
    /// <summary>
    /// Connects a function output to a return mapping.
    /// <see href="https://w3id.org/function/vocabulary/mapping#functionOutput"></see></summary>
    let functionOutput = _prefix "functionOutput"
    /// <summary>
    ///   <see href="https://w3id.org/function/vocabulary/mapping#ReturnMapping"></see>
    /// </summary>
    let ReturnMapping = _prefix "ReturnMapping"
    /// <summary>
    /// Connects a function parameter to a parameter mapping.
    /// <see href="https://w3id.org/function/vocabulary/mapping#functionParameter"></see></summary>
    let functionParameter = _prefix "functionParameter"
    /// <summary>
    /// Connects an implementation parameter position to a parameter mapping.
    /// <see href="https://w3id.org/function/vocabulary/mapping#implementationParameterPosition"></see></summary>
    let implementationParameterPosition = _prefix "implementationParameterPosition"
    /// <summary>
    /// Connects an implementation parameter label to a parameter mapping.
    /// <see href="https://w3id.org/function/vocabulary/mapping#implementationProperty"></see></summary>
    let implementationProperty = _prefix "implementationProperty"
    /// <summary>
    /// Connects a method name to a method mapping.
    /// <see href="https://w3id.org/function/vocabulary/mapping#method-name"></see></summary>
    let ``method-name`` = _prefix "method-name"
    /// <summary>
    /// Flag indicating whether the parameter can be repeated.
    /// <see href="https://w3id.org/function/vocabulary/mapping#repeatableParameter"></see></summary>
    let repeatableParameter = _prefix "repeatableParameter"
