namespace https.w3id.org._function.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module fno =
    let _namespace_name = "https://w3id.org/function/ontology#"
    /// <summary>
    /// An algorithm is a specified set of instructions, independent of its implementation.
    /// <see href="https://w3id.org/function/ontology#Algorithm"></see></summary>
    let Algorithm = Namespaced_IRI.parse _namespace_name "Algorithm" |> NamespacedName
    /// <summary>
    /// An Execution is the connection between a Function and its Parameters and Outputs.
    /// <see href="https://w3id.org/function/ontology#Execution"></see></summary>
    let Execution = Namespaced_IRI.parse _namespace_name "Execution" |> NamespacedName
    /// <summary>
    /// A Function is a process that performs a specific task by associating one or more Parameters to an Output
    /// <see href="https://w3id.org/function/ontology#Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName

    /// <summary>
    /// An Implementation defines the internal workings of one or more Functions
    /// <see href="https://w3id.org/function/ontology#Implementation"></see></summary>
    let Implementation =
        Namespaced_IRI.parse _namespace_name "Implementation" |> NamespacedName

    /// <summary>
    /// A Mapping links (abstract) Functions and (concrete) Implementations
    /// <see href="https://w3id.org/function/ontology#Mapping"></see></summary>
    let Mapping = Namespaced_IRI.parse _namespace_name "Mapping" |> NamespacedName

    /// <summary>
    /// A method mapping unambiguously specifies how the abstract function can be mapped to the implemented method. This can be, e.g., the name of the method
    /// <see href="https://w3id.org/function/ontology#MethodMapping"></see></summary>
    let MethodMapping =
        Namespaced_IRI.parse _namespace_name "MethodMapping" |> NamespacedName

    /// <summary>
    /// An Output is the description of the output value of a Function.
    /// <see href="https://w3id.org/function/ontology#Output"></see></summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName
    /// <summary>
    /// A Parameter is the description of the input value of a Function.
    /// <see href="https://w3id.org/function/ontology#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName

    /// <summary>
    /// A parameter mapping unambiguously specifies how the abstract parameter can be mapped to the implemented method's argument. For example: Parameter X is mapped to the third argument of the method (a position parameter mapping, common for programming languages), or to property with name Y of the method (a property parameter mapping, common for Web APIs)
    /// <see href="https://w3id.org/function/ontology#ParameterMapping"></see></summary>
    let ParameterMapping =
        Namespaced_IRI.parse _namespace_name "ParameterMapping" |> NamespacedName

    /// <summary>
    /// A Problem is a general issue. Some problems can be solved by executing a certain Function.
    /// <see href="https://w3id.org/function/ontology#Problem"></see></summary>
    let Problem = Namespaced_IRI.parse _namespace_name "Problem" |> NamespacedName

    /// <summary>
    /// A return mapping unambiguously specifies how the abstract output can be mapped to the implemented method's return value. For example: the return value of the method, or the thrown error of a the method
    /// <see href="https://w3id.org/function/ontology#ReturnMapping"></see></summary>
    let ReturnMapping =
        Namespaced_IRI.parse _namespace_name "ReturnMapping" |> NamespacedName

    /// <summary>
    /// Connects a function to an execution definition
    /// <see href="https://w3id.org/function/ontology#executes"></see></summary>
    let executes = Namespaced_IRI.parse _namespace_name "executes" |> NamespacedName
    /// <summary>
    /// Connects a function description to an ordered list of zero or more parameter descriptions
    /// <see href="https://w3id.org/function/ontology#expects"></see></summary>
    let expects = Namespaced_IRI.parse _namespace_name "expects" |> NamespacedName
    /// <summary>
    /// Connects a function to a mapping definition
    /// <see href="https://w3id.org/function/ontology#function"></see></summary>
    let function_ = Namespaced_IRI.parse _namespace_name "function" |> NamespacedName

    /// <summary>
    /// Connects an implementation to a mapping definition
    /// <see href="https://w3id.org/function/ontology#implementation"></see></summary>
    let implementation =
        Namespaced_IRI.parse _namespace_name "implementation" |> NamespacedName

    /// <summary>
    /// Connects a function to an algorithm it implements. A function can implement 0..n algorithms.
    /// <see href="https://w3id.org/function/ontology#implements"></see></summary>
    let implements = Namespaced_IRI.parse _namespace_name "implements" |> NamespacedName

    /// <summary>
    /// Connects a method mapping to a mapping definition
    /// <see href="https://w3id.org/function/ontology#methodMapping"></see></summary>
    let methodMapping =
        Namespaced_IRI.parse _namespace_name "methodMapping" |> NamespacedName

    /// <summary>
    /// Connects a function or a parameter to its name.
    /// <see href="https://w3id.org/function/ontology#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Defines if a parameteris nullable.
    /// <see href="https://w3id.org/function/ontology#nullable"></see></summary>
    let nullable = Namespaced_IRI.parse _namespace_name "nullable" |> NamespacedName

    /// <summary>
    /// Connects a parameter mapping to a mapping definition
    /// <see href="https://w3id.org/function/ontology#parameterMapping"></see></summary>
    let parameterMapping =
        Namespaced_IRI.parse _namespace_name "parameterMapping" |> NamespacedName

    /// <summary>
    /// Connects a parameter description to the predicate used to link executions of this function to their parameter.
    /// <see href="https://w3id.org/function/ontology#predicate"></see></summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName
    /// <summary>
    /// Defines if a parameter or an output is required.
    /// <see href="https://w3id.org/function/ontology#required"></see></summary>
    let required = Namespaced_IRI.parse _namespace_name "required" |> NamespacedName

    /// <summary>
    /// Connects a return mapping to a mapping definition
    /// <see href="https://w3id.org/function/ontology#returnMapping"></see></summary>
    let returnMapping =
        Namespaced_IRI.parse _namespace_name "returnMapping" |> NamespacedName

    /// <summary>
    /// Connects a description of a function to the description of the output
    /// <see href="https://w3id.org/function/ontology#returns"></see></summary>
    let returns = Namespaced_IRI.parse _namespace_name "returns" |> NamespacedName
    /// <summary>
    /// Connects a description of a function to the description of a problem it tries to solve.
    /// <see href="https://w3id.org/function/ontology#solves"></see></summary>
    let solves = Namespaced_IRI.parse _namespace_name "solves" |> NamespacedName
    /// <summary>
    /// Connects an output or a parameter description to the type of instances of these parameters or outputs.
    /// <see href="https://w3id.org/function/ontology#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    /// Connects an execution to a mapping definition
    /// <see href="https://w3id.org/function/ontology#uses"></see></summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName
