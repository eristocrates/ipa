namespace https.w3id.org._function.ontology.hash

open DoxAletheia

module fno =
    let _namespace_name = "https://w3id.org/function/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An algorithm is a specified set of instructions, independent of its implementation.
    /// <see href="https://w3id.org/function/ontology#Algorithm"></see></summary>
    let Algorithm = _prefix "Algorithm"
    /// <summary>
    /// An Execution is the connection between a Function and its Parameters and Outputs.
    /// <see href="https://w3id.org/function/ontology#Execution"></see></summary>
    let Execution = _prefix "Execution"
    /// <summary>
    /// A Function is a process that performs a specific task by associating one or more Parameters to an Output
    /// <see href="https://w3id.org/function/ontology#Function"></see></summary>
    let Function = _prefix "Function"
    /// <summary>
    /// An Implementation defines the internal workings of one or more Functions
    /// <see href="https://w3id.org/function/ontology#Implementation"></see></summary>
    let Implementation = _prefix "Implementation"
    /// <summary>
    /// A Mapping links (abstract) Functions and (concrete) Implementations
    /// <see href="https://w3id.org/function/ontology#Mapping"></see></summary>
    let Mapping = _prefix "Mapping"
    /// <summary>
    /// A method mapping unambiguously specifies how the abstract function can be mapped to the implemented method. This can be, e.g., the name of the method
    /// <see href="https://w3id.org/function/ontology#MethodMapping"></see></summary>
    let MethodMapping = _prefix "MethodMapping"
    /// <summary>
    /// An Output is the description of the output value of a Function.
    /// <see href="https://w3id.org/function/ontology#Output"></see></summary>
    let Output = _prefix "Output"
    /// <summary>
    /// A Parameter is the description of the input value of a Function.
    /// <see href="https://w3id.org/function/ontology#Parameter"></see></summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    /// A parameter mapping unambiguously specifies how the abstract parameter can be mapped to the implemented method's argument. For example: Parameter X is mapped to the third argument of the method (a position parameter mapping, common for programming languages), or to property with name Y of the method (a property parameter mapping, common for Web APIs)
    /// <see href="https://w3id.org/function/ontology#ParameterMapping"></see></summary>
    let ParameterMapping = _prefix "ParameterMapping"
    /// <summary>
    /// A Problem is a general issue. Some problems can be solved by executing a certain Function.
    /// <see href="https://w3id.org/function/ontology#Problem"></see></summary>
    let Problem = _prefix "Problem"
    /// <summary>
    /// A return mapping unambiguously specifies how the abstract output can be mapped to the implemented method's return value. For example: the return value of the method, or the thrown error of a the method
    /// <see href="https://w3id.org/function/ontology#ReturnMapping"></see></summary>
    let ReturnMapping = _prefix "ReturnMapping"
    /// <summary>
    /// Connects a function to an execution definition
    /// <see href="https://w3id.org/function/ontology#executes"></see></summary>
    let executes = _prefix "executes"
    /// <summary>
    /// Connects a function description to an ordered list of zero or more parameter descriptions
    /// <see href="https://w3id.org/function/ontology#expects"></see></summary>
    let expects = _prefix "expects"
    /// <summary>
    /// Connects a function to a mapping definition
    /// <see href="https://w3id.org/function/ontology#function"></see></summary>
    let function_ = _prefix "function"
    /// <summary>
    /// Connects an implementation to a mapping definition
    /// <see href="https://w3id.org/function/ontology#implementation"></see></summary>
    let implementation = _prefix "implementation"
    /// <summary>
    /// Connects a function to an algorithm it implements. A function can implement 0..n algorithms.
    /// <see href="https://w3id.org/function/ontology#implements"></see></summary>
    let implements = _prefix "implements"
    /// <summary>
    /// Connects a method mapping to a mapping definition
    /// <see href="https://w3id.org/function/ontology#methodMapping"></see></summary>
    let methodMapping = _prefix "methodMapping"
    /// <summary>
    /// Connects a function or a parameter to its name.
    /// <see href="https://w3id.org/function/ontology#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Defines if a parameteris nullable.
    /// <see href="https://w3id.org/function/ontology#nullable"></see></summary>
    let nullable = _prefix "nullable"
    /// <summary>
    /// Connects a parameter mapping to a mapping definition
    /// <see href="https://w3id.org/function/ontology#parameterMapping"></see></summary>
    let parameterMapping = _prefix "parameterMapping"
    /// <summary>
    /// Connects a parameter description to the predicate used to link executions of this function to their parameter.
    /// <see href="https://w3id.org/function/ontology#predicate"></see></summary>
    let predicate = _prefix "predicate"
    /// <summary>
    /// Defines if a parameter or an output is required.
    /// <see href="https://w3id.org/function/ontology#required"></see></summary>
    let required = _prefix "required"
    /// <summary>
    /// Connects a return mapping to a mapping definition
    /// <see href="https://w3id.org/function/ontology#returnMapping"></see></summary>
    let returnMapping = _prefix "returnMapping"
    /// <summary>
    /// Connects a description of a function to the description of the output
    /// <see href="https://w3id.org/function/ontology#returns"></see></summary>
    let returns = _prefix "returns"
    /// <summary>
    /// Connects a description of a function to the description of a problem it tries to solve.
    /// <see href="https://w3id.org/function/ontology#solves"></see></summary>
    let solves = _prefix "solves"
    /// <summary>
    /// Connects an output or a parameter description to the type of instances of these parameters or outputs.
    /// <see href="https://w3id.org/function/ontology#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// Connects an execution to a mapping definition
    /// <see href="https://w3id.org/function/ontology#uses"></see></summary>
    let uses = _prefix "uses"
