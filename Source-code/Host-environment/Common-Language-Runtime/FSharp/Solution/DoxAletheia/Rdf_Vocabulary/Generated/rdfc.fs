namespace https.w3id.org.rdf_connect.hash

open DoxAletheia.Rdf_Vocabulary

module rdfc =
    let _namespace_name = "https://w3id.org/rdf-connect#"

    /// <summary>
    /// A runner that executes processors via shell commands.
    /// <see href="https://w3id.org/rdf-connect#CommandRunner"></see></summary>
    let CommandRunner =
        Namespaced_IRI.parse _namespace_name "CommandRunner" |> NamespacedName

    /// <summary>
    /// An agent responsible for executing processors based on specific implementations.
    /// <see href="https://w3id.org/rdf-connect#Runner"></see></summary>
    let Runner = Namespaced_IRI.parse _namespace_name "Runner" |> NamespacedName

    /// <summary>
    /// Entity that defines an execution context used by a pipeline, which is composed by a runner and a set of processor instances.
    /// <see href="https://w3id.org/rdf-connect#ExecutionContext"></see></summary>
    let ExecutionContext =
        Namespaced_IRI.parse _namespace_name "ExecutionContext" |> NamespacedName

    /// <summary>
    /// A sequence of processors and runners forming a data processing workflow.
    /// <see href="https://w3id.org/rdf-connect#Pipeline"></see></summary>
    let Pipeline = Namespaced_IRI.parse _namespace_name "Pipeline" |> NamespacedName
    /// <summary>
    /// A processing unit that performs an action within a pipeline.
    /// <see href="https://w3id.org/rdf-connect#Processor"></see></summary>
    let Processor = Namespaced_IRI.parse _namespace_name "Processor" |> NamespacedName
    /// <summary>
    /// A component that provides input data to a processor.
    /// <see href="https://w3id.org/rdf-connect#Reader"></see></summary>
    let Reader = Namespaced_IRI.parse _namespace_name "Reader" |> NamespacedName
    /// <summary>
    /// A component that handles output data from a processor.
    /// <see href="https://w3id.org/rdf-connect#Writer"></see></summary>
    let Writer = Namespaced_IRI.parse _namespace_name "Writer" |> NamespacedName
    /// <summary>
    /// The class name of a processor. Applicable for any object-oriented programming language.
    /// <see href="https://w3id.org/rdf-connect#class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    /// Shell command used by an orchestrator to execute a runner instance.
    /// <see href="https://w3id.org/rdf-connect#command"></see></summary>
    let command = Namespaced_IRI.parse _namespace_name "command" |> NamespacedName
    /// <summary>
    /// Relates a pipeline to an execution context (runner and processors) it uses.
    /// <see href="https://w3id.org/rdf-connect#consistsOf"></see></summary>
    let consistsOf = Namespaced_IRI.parse _namespace_name "consistsOf" |> NamespacedName
    /// <summary>
    /// The folder location of the main script or module entry point of a JavaScript processor.
    /// <see href="https://w3id.org/rdf-connect#entrypoint"></see></summary>
    let entrypoint = Namespaced_IRI.parse _namespace_name "entrypoint" |> NamespacedName
    /// <summary>
    /// The file name containing the processor logic of a JavaScript processor.
    /// <see href="https://w3id.org/rdf-connect#file"></see></summary>
    let file = Namespaced_IRI.parse _namespace_name "file" |> NamespacedName

    /// <summary>
    /// The property that defines which type of processors a runner can handle, typically linked to a specific implementation property.
    /// <see href="https://w3id.org/rdf-connect#handlesSubjectsOf"></see></summary>
    let handlesSubjectsOf =
        Namespaced_IRI.parse _namespace_name "handlesSubjectsOf" |> NamespacedName

    /// <summary>
    /// Abstract property that conveys the implementation language of a processor.
    /// <see href="https://w3id.org/rdf-connect#implementationOf"></see></summary>
    let implementationOf =
        Namespaced_IRI.parse _namespace_name "implementationOf" |> NamespacedName

    /// <summary>
    /// Declares the runner instance used in an execution context.
    /// <see href="https://w3id.org/rdf-connect#instantiates"></see></summary>
    let instantiates =
        Namespaced_IRI.parse _namespace_name "instantiates" |> NamespacedName

    /// <summary>
    /// Path to the JAR file containing the processor logic of a Java processor.
    /// <see href="https://w3id.org/rdf-connect#jar"></see></summary>
    let jar = Namespaced_IRI.parse _namespace_name "jar" |> NamespacedName

    /// <summary>
    /// Indicates that a processor is implemented in Java and is a specialization of implementationOf.
    /// <see href="https://w3id.org/rdf-connect#javaImplementationOf"></see></summary>
    let javaImplementationOf =
        Namespaced_IRI.parse _namespace_name "javaImplementationOf" |> NamespacedName

    /// <summary>
    /// Indicates that a processor is implemented in JavaScript and is a specialization of implementationOf.
    /// <see href="https://w3id.org/rdf-connect#jsImplementationOf"></see></summary>
    let jsImplementationOf =
        Namespaced_IRI.parse _namespace_name "jsImplementationOf" |> NamespacedName

    /// <summary>
    /// The module path of a processor implemented in Python.
    /// <see href="https://w3id.org/rdf-connect#module_path"></see></summary>
    let module_path =
        Namespaced_IRI.parse _namespace_name "module_path" |> NamespacedName

    /// <summary>
    /// Declares a processor instance used in an execution context, part of a pipeline.
    /// <see href="https://w3id.org/rdf-connect#processor"></see></summary>
    let processor = Namespaced_IRI.parse _namespace_name "processor" |> NamespacedName

    /// <summary>
    /// Indicates that a processor is implemented in Python and is a specialization of implementationOf.
    /// <see href="https://w3id.org/rdf-connect#pyImplementationOf"></see></summary>
    let pyImplementationOf =
        Namespaced_IRI.parse _namespace_name "pyImplementationOf" |> NamespacedName
