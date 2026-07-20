namespace https.w3id.org.rdf_connect.hash

open DoxAletheia

module rdfc =
    let _namespace_name = "https://w3id.org/rdf-connect#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A runner that executes processors via shell commands.
    /// <see href="https://w3id.org/rdf-connect#CommandRunner"></see></summary>
    let CommandRunner = _prefix "CommandRunner"
    /// <summary>
    /// An agent responsible for executing processors based on specific implementations.
    /// <see href="https://w3id.org/rdf-connect#Runner"></see></summary>
    let Runner = _prefix "Runner"
    /// <summary>
    /// Entity that defines an execution context used by a pipeline, which is composed by a runner and a set of processor instances.
    /// <see href="https://w3id.org/rdf-connect#ExecutionContext"></see></summary>
    let ExecutionContext = _prefix "ExecutionContext"
    /// <summary>
    /// A sequence of processors and runners forming a data processing workflow.
    /// <see href="https://w3id.org/rdf-connect#Pipeline"></see></summary>
    let Pipeline = _prefix "Pipeline"
    /// <summary>
    /// A processing unit that performs an action within a pipeline.
    /// <see href="https://w3id.org/rdf-connect#Processor"></see></summary>
    let Processor = _prefix "Processor"
    /// <summary>
    /// A component that provides input data to a processor.
    /// <see href="https://w3id.org/rdf-connect#Reader"></see></summary>
    let Reader = _prefix "Reader"
    /// <summary>
    /// A component that handles output data from a processor.
    /// <see href="https://w3id.org/rdf-connect#Writer"></see></summary>
    let Writer = _prefix "Writer"
    /// <summary>
    /// The class name of a processor. Applicable for any object-oriented programming language.
    /// <see href="https://w3id.org/rdf-connect#class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// Shell command used by an orchestrator to execute a runner instance.
    /// <see href="https://w3id.org/rdf-connect#command"></see></summary>
    let command = _prefix "command"
    /// <summary>
    /// Relates a pipeline to an execution context (runner and processors) it uses.
    /// <see href="https://w3id.org/rdf-connect#consistsOf"></see></summary>
    let consistsOf = _prefix "consistsOf"
    /// <summary>
    /// The folder location of the main script or module entry point of a JavaScript processor.
    /// <see href="https://w3id.org/rdf-connect#entrypoint"></see></summary>
    let entrypoint = _prefix "entrypoint"
    /// <summary>
    /// The file name containing the processor logic of a JavaScript processor.
    /// <see href="https://w3id.org/rdf-connect#file"></see></summary>
    let file = _prefix "file"
    /// <summary>
    /// The property that defines which type of processors a runner can handle, typically linked to a specific implementation property.
    /// <see href="https://w3id.org/rdf-connect#handlesSubjectsOf"></see></summary>
    let handlesSubjectsOf = _prefix "handlesSubjectsOf"
    /// <summary>
    /// Abstract property that conveys the implementation language of a processor.
    /// <see href="https://w3id.org/rdf-connect#implementationOf"></see></summary>
    let implementationOf = _prefix "implementationOf"
    /// <summary>
    /// Declares the runner instance used in an execution context.
    /// <see href="https://w3id.org/rdf-connect#instantiates"></see></summary>
    let instantiates = _prefix "instantiates"
    /// <summary>
    /// Path to the JAR file containing the processor logic of a Java processor.
    /// <see href="https://w3id.org/rdf-connect#jar"></see></summary>
    let jar = _prefix "jar"
    /// <summary>
    /// Indicates that a processor is implemented in Java and is a specialization of implementationOf.
    /// <see href="https://w3id.org/rdf-connect#javaImplementationOf"></see></summary>
    let javaImplementationOf = _prefix "javaImplementationOf"
    /// <summary>
    /// Indicates that a processor is implemented in JavaScript and is a specialization of implementationOf.
    /// <see href="https://w3id.org/rdf-connect#jsImplementationOf"></see></summary>
    let jsImplementationOf = _prefix "jsImplementationOf"
    /// <summary>
    /// The module path of a processor implemented in Python.
    /// <see href="https://w3id.org/rdf-connect#module_path"></see></summary>
    let module_path = _prefix "module_path"
    /// <summary>
    /// Declares a processor instance used in an execution context, part of a pipeline.
    /// <see href="https://w3id.org/rdf-connect#processor"></see></summary>
    let processor = _prefix "processor"
    /// <summary>
    /// Indicates that a processor is implemented in Python and is a specialization of implementationOf.
    /// <see href="https://w3id.org/rdf-connect#pyImplementationOf"></see></summary>
    let pyImplementationOf = _prefix "pyImplementationOf"
