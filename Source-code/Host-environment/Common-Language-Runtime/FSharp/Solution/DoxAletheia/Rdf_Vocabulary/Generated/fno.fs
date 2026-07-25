namespace https.w3id.org._function.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fno =
    let _namespace_iri = Namespace_Iri fno |> NamespaceIRI
    /// <summary>
    ///   <para>fno:Mapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Mapping links (abstract) Functions and (concrete) Implementations</para>
    /// labels<para>Mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#Mapping">https://w3id.org/function/ontology#Mapping</seealso>
    let Mapping = Prefixed_Name(fno, "Mapping") |> PrefixedName
    /// <summary>
    ///   <para>fno:Execution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Execution is the connection between a Function and its Parameters and Outputs.</para>
    /// labels<para>Execution</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#Execution">https://w3id.org/function/ontology#Execution</seealso>
    let Execution = Prefixed_Name(fno, "Execution") |> PrefixedName
    /// <summary>
    ///   <para>fno:Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An algorithm is a specified set of instructions, independent of its implementation.</para>
    /// labels<para>Algorithm</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#Algorithm">https://w3id.org/function/ontology#Algorithm</seealso>
    let Algorithm = Prefixed_Name(fno, "Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>fno:Implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Implementation defines the internal workings of one or more Functions</para>
    /// labels<para>Implementation</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#Implementation">https://w3id.org/function/ontology#Implementation</seealso>
    let Implementation = Prefixed_Name(fno, "Implementation") |> PrefixedName
    /// <summary>
    ///   <para>fno:MethodMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A method mapping unambiguously specifies how the abstract function can be mapped to the implemented method. This can be, e.g., the name of the method</para>
    /// labels<para>Method mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#MethodMapping">https://w3id.org/function/ontology#MethodMapping</seealso>
    let MethodMapping = Prefixed_Name(fno, "MethodMapping") |> PrefixedName
    /// <summary>
    ///   <para>fno:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Function is a process that performs a specific task by associating one or more Parameters to an Output</para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#Function">https://w3id.org/function/ontology#Function</seealso>
    let Function = Prefixed_Name(fno, "Function") |> PrefixedName
    /// <summary>
    ///   <para>fno:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Output is the description of the output value of a Function.</para>
    /// labels<para>Output</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#Output">https://w3id.org/function/ontology#Output</seealso>
    let Output = Prefixed_Name(fno, "Output") |> PrefixedName
    /// <summary>
    ///   <para>fno:Problem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Problem is a general issue. Some problems can be solved by executing a certain Function.</para>
    /// labels<para>Problem</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#Problem">https://w3id.org/function/ontology#Problem</seealso>
    let Problem = Prefixed_Name(fno, "Problem") |> PrefixedName
    /// <summary>
    ///   <para>fno:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Parameter is the description of the input value of a Function.</para>
    /// labels<para>Parameter</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#Parameter">https://w3id.org/function/ontology#Parameter</seealso>
    let Parameter = Prefixed_Name(fno, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>fno:ParameterMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A parameter mapping unambiguously specifies how the abstract parameter can be mapped to the implemented method's argument. For example: Parameter X is mapped to the third argument of the method (a position parameter mapping, common for programming languages), or to property with name Y of the method (a property parameter mapping, common for Web APIs)</para>
    /// labels<para>Parameter mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#ParameterMapping">https://w3id.org/function/ontology#ParameterMapping</seealso>
    let ParameterMapping = Prefixed_Name(fno, "ParameterMapping") |> PrefixedName
    /// <summary>
    ///   <para>fno:ReturnMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A return mapping unambiguously specifies how the abstract output can be mapped to the implemented method's return value. For example: the return value of the method, or the thrown error of a the method</para>
    /// labels<para>Return mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#ReturnMapping">https://w3id.org/function/ontology#ReturnMapping</seealso>
    let ReturnMapping = Prefixed_Name(fno, "ReturnMapping") |> PrefixedName
    /// <summary>
    ///   <para>fno:expects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a function description to an ordered list of zero or more parameter descriptions</para>
    /// labels<para>expects</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#expects">https://w3id.org/function/ontology#expects</seealso>
    let expects = Prefixed_Name(fno, "expects") |> PrefixedName
    /// <summary>
    ///   <para>fno:implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects an implementation to a mapping definition</para>
    /// labels<para>implementation</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#implementation">https://w3id.org/function/ontology#implementation</seealso>
    let implementation = Prefixed_Name(fno, "implementation") |> PrefixedName
    /// <summary>
    ///   <para>fno:methodMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a method mapping to a mapping definition</para>
    /// labels<para>method mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#methodMapping">https://w3id.org/function/ontology#methodMapping</seealso>
    let methodMapping = Prefixed_Name(fno, "methodMapping") |> PrefixedName
    /// <summary>
    ///   <para>fno:nullable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines if a parameteris nullable.</para>
    /// labels<para>nullable</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#nullable">https://w3id.org/function/ontology#nullable</seealso>
    let nullable = Prefixed_Name(fno, "nullable") |> PrefixedName
    /// <summary>
    ///   <para>fno:executes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a function to an execution definition</para>
    /// labels<para>executes</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#executes">https://w3id.org/function/ontology#executes</seealso>
    let executes = Prefixed_Name(fno, "executes") |> PrefixedName
    /// <summary>
    ///   <para>fno:function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a function to a mapping definition</para>
    /// labels<para>function</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#function">https://w3id.org/function/ontology#function</seealso>
    let function_ = Prefixed_Name(fno, "function") |> PrefixedName
    /// <summary>
    ///   <para>fno:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a function to an algorithm it implements. A function can implement 0..n algorithms.</para>
    /// labels<para>implements</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#implements">https://w3id.org/function/ontology#implements</seealso>
    let implements = Prefixed_Name(fno, "implements") |> PrefixedName
    /// <summary>
    ///   <para>fno:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Connects a function or a parameter to its name.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#name">https://w3id.org/function/ontology#name</seealso>
    let name = Prefixed_Name(fno, "name") |> PrefixedName
    /// <summary>
    ///   <para>fno:parameterMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a parameter mapping to a mapping definition</para>
    /// labels<para>parameter mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#parameterMapping">https://w3id.org/function/ontology#parameterMapping</seealso>
    let parameterMapping = Prefixed_Name(fno, "parameterMapping") |> PrefixedName
    /// <summary>
    ///   <para>fno:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a parameter description to the predicate used to link executions of this function to their parameter.</para>
    /// labels<para>predicate</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#predicate">https://w3id.org/function/ontology#predicate</seealso>
    let predicate = Prefixed_Name(fno, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>fno:required</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines if a parameter or an output is required.</para>
    /// labels<para>required</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#required">https://w3id.org/function/ontology#required</seealso>
    let required = Prefixed_Name(fno, "required") |> PrefixedName
    /// <summary>
    ///   <para>fno:returnMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a return mapping to a mapping definition</para>
    /// labels<para>return mapping</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#returnMapping">https://w3id.org/function/ontology#returnMapping</seealso>
    let returnMapping = Prefixed_Name(fno, "returnMapping") |> PrefixedName
    /// <summary>
    ///   <para>fno:returns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a description of a function to the description of the output</para>
    /// labels<para>returns</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#returns">https://w3id.org/function/ontology#returns</seealso>
    let returns = Prefixed_Name(fno, "returns") |> PrefixedName
    /// <summary>
    ///   <para>fno:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects an output or a parameter description to the type of instances of these parameters or outputs.</para>
    /// labels<para>type</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#type">https://w3id.org/function/ontology#type</seealso>
    let type_ = Prefixed_Name(fno, "type") |> PrefixedName
    /// <summary>
    ///   <para>fno:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects an execution to a mapping definition</para>
    /// labels<para>uses</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#uses">https://w3id.org/function/ontology#uses</seealso>
    let uses = Prefixed_Name(fno, "uses") |> PrefixedName
    /// <summary>
    ///   <para>fno:solves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a description of a function to the description of a problem it tries to solve.</para>
    /// labels<para>solves</para></remarks>
    /// <seealso href="https://w3id.org/function/ontology#solves">https://w3id.org/function/ontology#solves</seealso>
    let solves = Prefixed_Name(fno, "solves") |> PrefixedName
