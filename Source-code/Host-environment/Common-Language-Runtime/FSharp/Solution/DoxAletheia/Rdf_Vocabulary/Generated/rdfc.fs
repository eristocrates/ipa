namespace https.w3id.org.rdf_connect.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdfc =
    let _namespace_iri = Namespace_Iri rdfc |> NamespaceIRI
    /// <summary>
    ///   <para>rdfc:Runner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent responsible for executing processors based on specific implementations.</para>
    /// labels<para>Runner</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#Runner">https://w3id.org/rdf-connect#Runner</seealso>
    let Runner = Prefixed_Name(rdfc, "Runner") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:Processor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A processing unit that performs an action within a pipeline.</para>
    /// labels<para>Processor</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#Processor">https://w3id.org/rdf-connect#Processor</seealso>
    let Processor = Prefixed_Name(rdfc, "Processor") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:Reader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A component that provides input data to a processor.</para>
    /// labels<para>Reader</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#Reader">https://w3id.org/rdf-connect#Reader</seealso>
    let Reader = Prefixed_Name(rdfc, "Reader") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:CommandRunner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A runner that executes processors via shell commands.</para>
    /// labels<para>Command Runner</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#CommandRunner">https://w3id.org/rdf-connect#CommandRunner</seealso>
    let CommandRunner = Prefixed_Name(rdfc, "CommandRunner") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:Pipeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sequence of processors and runners forming a data processing workflow.</para>
    /// labels<para>Pipeline</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#Pipeline">https://w3id.org/rdf-connect#Pipeline</seealso>
    let Pipeline = Prefixed_Name(rdfc, "Pipeline") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The class name of a processor. Applicable for any object-oriented programming language.</para>
    /// labels<para>class</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#class">https://w3id.org/rdf-connect#class</seealso>
    let class_ = Prefixed_Name(rdfc, "class") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:consistsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a pipeline to an execution context (runner and processors) it uses.</para>
    /// labels<para>consists of</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#consistsOf">https://w3id.org/rdf-connect#consistsOf</seealso>
    let consistsOf = Prefixed_Name(rdfc, "consistsOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:implementationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Abstract property that conveys the implementation language of a processor.</para>
    /// labels<para>implementation of</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#implementationOf">https://w3id.org/rdf-connect#implementationOf</seealso>
    let implementationOf = Prefixed_Name(rdfc, "implementationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:jar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Path to the JAR file containing the processor logic of a Java processor.</para>
    /// labels<para>jar</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#jar">https://w3id.org/rdf-connect#jar</seealso>
    let jar = Prefixed_Name(rdfc, "jar") |> PrefixedName

    /// <summary>
    ///   <para>rdfc:javaImplementationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a processor is implemented in Java and is a specialization of implementationOf.</para>
    /// labels<para>Java Implementation Of</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#javaImplementationOf">https://w3id.org/rdf-connect#javaImplementationOf</seealso>
    let javaImplementationOf =
        Prefixed_Name(rdfc, "javaImplementationOf") |> PrefixedName

    /// <summary>
    ///   <para>rdfc:processor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Declares a processor instance used in an execution context, part of a pipeline.</para>
    /// labels<para>processor</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#processor">https://w3id.org/rdf-connect#processor</seealso>
    let processor = Prefixed_Name(rdfc, "processor") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:ExecutionContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Entity that defines an execution context used by a pipeline, which is composed by a runner and a set of processor instances.</para>
    /// labels<para>Execution Context</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#ExecutionContext">https://w3id.org/rdf-connect#ExecutionContext</seealso>
    let ExecutionContext = Prefixed_Name(rdfc, "ExecutionContext") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:Writer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A component that handles output data from a processor.</para>
    /// labels<para>Writer</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#Writer">https://w3id.org/rdf-connect#Writer</seealso>
    let Writer = Prefixed_Name(rdfc, "Writer") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Shell command used by an orchestrator to execute a runner instance.</para>
    /// labels<para>command</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#command">https://w3id.org/rdf-connect#command</seealso>
    let command = Prefixed_Name(rdfc, "command") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:entrypoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The folder location of the main script or module entry point of a JavaScript processor.</para>
    /// labels<para>entrypoint</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#entrypoint">https://w3id.org/rdf-connect#entrypoint</seealso>
    let entrypoint = Prefixed_Name(rdfc, "entrypoint") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:handlesSubjectsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property that defines which type of processors a runner can handle, typically linked to a specific implementation property.</para>
    /// labels<para>handle subjects of</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#handlesSubjectsOf">https://w3id.org/rdf-connect#handlesSubjectsOf</seealso>
    let handlesSubjectsOf = Prefixed_Name(rdfc, "handlesSubjectsOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:file</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The file name containing the processor logic of a JavaScript processor.</para>
    /// labels<para>file</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#file">https://w3id.org/rdf-connect#file</seealso>
    let file = Prefixed_Name(rdfc, "file") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:instantiates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Declares the runner instance used in an execution context.</para>
    /// labels<para>instantiates</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#instantiates">https://w3id.org/rdf-connect#instantiates</seealso>
    let instantiates = Prefixed_Name(rdfc, "instantiates") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:module_path</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The module path of a processor implemented in Python.</para>
    /// labels<para>module path</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#module_path">https://w3id.org/rdf-connect#module_path</seealso>
    let module_path = Prefixed_Name(rdfc, "module_path") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:jsImplementationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a processor is implemented in JavaScript and is a specialization of implementationOf.</para>
    /// labels<para>JavaScript Implementation Of</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#jsImplementationOf">https://w3id.org/rdf-connect#jsImplementationOf</seealso>
    let jsImplementationOf = Prefixed_Name(rdfc, "jsImplementationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfc:pyImplementationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a processor is implemented in Python and is a specialization of implementationOf.</para>
    /// labels<para>Python Implementation Of</para></remarks>
    /// <seealso href="https://w3id.org/rdf-connect#pyImplementationOf">https://w3id.org/rdf-connect#pyImplementationOf</seealso>
    let pyImplementationOf = Prefixed_Name(rdfc, "pyImplementationOf") |> PrefixedName
