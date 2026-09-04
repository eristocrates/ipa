#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdfc =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/rdf-connect#" "rdfc"
    /// <summary>
    ///   <para>rdfs:label : Command Runner</para>
    ///   <para>rdfs:comment : A runner that executes processors via shell commands.</para>
    ///   <a href="https://w3id.org/rdf-connect#CommandRunner">rdfc:CommandRunner</a>
    /// </summary>
    let CommandRunner = _prefixId.prefix "CommandRunner"
    /// <summary>
    ///   <para>rdfs:label : Execution Context</para>
    ///   <para>rdfs:comment : Entity that defines an execution context used by a pipeline, which is composed by a runner and a set of processor instances.</para>
    ///   <a href="https://w3id.org/rdf-connect#ExecutionContext">rdfc:ExecutionContext</a>
    /// </summary>
    let ExecutionContext = _prefixId.prefix "ExecutionContext"
    /// <summary>
    ///   <para>rdfs:label : Pipeline</para>
    ///   <para>rdfs:comment : A sequence of processors and runners forming a data processing workflow.</para>
    ///   <a href="https://w3id.org/rdf-connect#Pipeline">rdfc:Pipeline</a>
    /// </summary>
    let Pipeline = _prefixId.prefix "Pipeline"
    /// <summary>
    ///   <para>rdfs:label : Processor</para>
    ///   <para>rdfs:comment : A processing unit that performs an action within a pipeline.</para>
    ///   <a href="https://w3id.org/rdf-connect#Processor">rdfc:Processor</a>
    /// </summary>
    let Processor = _prefixId.prefix "Processor"
    /// <summary>
    ///   <para>rdfs:label : Reader</para>
    ///   <para>rdfs:comment : A component that provides input data to a processor.</para>
    ///   <a href="https://w3id.org/rdf-connect#Reader">rdfc:Reader</a>
    /// </summary>
    let Reader = _prefixId.prefix "Reader"
    /// <summary>
    ///   <para>rdfs:label : Runner</para>
    ///   <para>rdfs:comment : An agent responsible for executing processors based on specific implementations.</para>
    ///   <a href="https://w3id.org/rdf-connect#Runner">rdfc:Runner</a>
    /// </summary>
    let Runner = _prefixId.prefix "Runner"
    /// <summary>
    ///   <para>rdfs:label : Writer</para>
    ///   <para>rdfs:comment : A component that handles output data from a processor.</para>
    ///   <a href="https://w3id.org/rdf-connect#Writer">rdfc:Writer</a>
    /// </summary>
    let Writer = _prefixId.prefix "Writer"
    /// <summary>
    ///   <para>rdfs:label : class</para>
    ///   <para>rdfs:comment : The class name of a processor. Applicable for any object-oriented programming language.</para>
    ///   <a href="https://w3id.org/rdf-connect#class">rdfc:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:label : command</para>
    ///   <para>rdfs:comment : Shell command used by an orchestrator to execute a runner instance.</para>
    ///   <a href="https://w3id.org/rdf-connect#command">rdfc:command</a>
    /// </summary>
    let command = _prefixId.prefix "command"
    /// <summary>
    ///   <para>rdfs:label : consists of</para>
    ///   <para>rdfs:comment : Relates a pipeline to an execution context (runner and processors) it uses.</para>
    ///   <a href="https://w3id.org/rdf-connect#consistsOf">rdfc:consistsOf</a>
    /// </summary>
    let consistsOf = _prefixId.prefix "consistsOf"
    /// <summary>
    ///   <para>rdfs:label : entrypoint</para>
    ///   <para>rdfs:comment : The folder location of the main script or module entry point of a JavaScript processor.</para>
    ///   <a href="https://w3id.org/rdf-connect#entrypoint">rdfc:entrypoint</a>
    /// </summary>
    let entrypoint = _prefixId.prefix "entrypoint"
    /// <summary>
    ///   <para>rdfs:label : file</para>
    ///   <para>rdfs:comment : The file name containing the processor logic of a JavaScript processor.</para>
    ///   <a href="https://w3id.org/rdf-connect#file">rdfc:file</a>
    /// </summary>
    let file = _prefixId.prefix "file"
    /// <summary>
    ///   <para>rdfs:label : handle subjects of</para>
    ///   <para>rdfs:comment : The property that defines which type of processors a runner can handle, typically linked to a specific implementation property.</para>
    ///   <a href="https://w3id.org/rdf-connect#handlesSubjectsOf">rdfc:handlesSubjectsOf</a>
    /// </summary>
    let handlesSubjectsOf = _prefixId.prefix "handlesSubjectsOf"
    /// <summary>
    ///   <para>rdfs:label : implementation of</para>
    ///   <para>rdfs:comment : Abstract property that conveys the implementation language of a processor.</para>
    ///   <a href="https://w3id.org/rdf-connect#implementationOf">rdfc:implementationOf</a>
    /// </summary>
    let implementationOf = _prefixId.prefix "implementationOf"
    /// <summary>
    ///   <para>rdfs:label : instantiates</para>
    ///   <para>rdfs:comment : Declares the runner instance used in an execution context.</para>
    ///   <a href="https://w3id.org/rdf-connect#instantiates">rdfc:instantiates</a>
    /// </summary>
    let instantiates = _prefixId.prefix "instantiates"
    /// <summary>
    ///   <para>rdfs:label : jar</para>
    ///   <para>rdfs:comment : Path to the JAR file containing the processor logic of a Java processor.</para>
    ///   <a href="https://w3id.org/rdf-connect#jar">rdfc:jar</a>
    /// </summary>
    let jar = _prefixId.prefix "jar"
    /// <summary>
    ///   <para>rdfs:label : Java Implementation Of</para>
    ///   <para>rdfs:comment : Indicates that a processor is implemented in Java and is a specialization of implementationOf.</para>
    ///   <a href="https://w3id.org/rdf-connect#javaImplementationOf">rdfc:javaImplementationOf</a>
    /// </summary>
    let javaImplementationOf = _prefixId.prefix "javaImplementationOf"
    /// <summary>
    ///   <para>rdfs:label : JavaScript Implementation Of</para>
    ///   <para>rdfs:comment : Indicates that a processor is implemented in JavaScript and is a specialization of implementationOf.</para>
    ///   <a href="https://w3id.org/rdf-connect#jsImplementationOf">rdfc:jsImplementationOf</a>
    /// </summary>
    let jsImplementationOf = _prefixId.prefix "jsImplementationOf"
    /// <summary>
    ///   <para>rdfs:label : module path</para>
    ///   <para>rdfs:comment : The module path of a processor implemented in Python.</para>
    ///   <a href="https://w3id.org/rdf-connect#module_path">rdfc:module_path</a>
    /// </summary>
    let module_path = _prefixId.prefix "module_path"
    /// <summary>
    ///   <para>rdfs:label : processor</para>
    ///   <para>rdfs:comment : Declares a processor instance used in an execution context, part of a pipeline.</para>
    ///   <a href="https://w3id.org/rdf-connect#processor">rdfc:processor</a>
    /// </summary>
    let processor = _prefixId.prefix "processor"
    /// <summary>
    ///   <para>rdfs:label : Python Implementation Of</para>
    ///   <para>rdfs:comment : Indicates that a processor is implemented in Python and is a specialization of implementationOf.</para>
    ///   <a href="https://w3id.org/rdf-connect#pyImplementationOf">rdfc:pyImplementationOf</a>
    /// </summary>
    let pyImplementationOf = _prefixId.prefix "pyImplementationOf"
