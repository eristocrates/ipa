namespace http.www.daml.org.services.owl_s._1._2.Process.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owlsProcess =
    let _namespace_iri = Namespace_Iri owlsProcess |> NamespaceIRI
    /// <summary>
    ///   <para>damlProcess:#Any-Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     Allows the process components (specified as a bag) to be executed in
    ///     some unspecified order but not concurrently. Execution and completion
    ///     of all components is required. The execution of processes in an
    ///     "Any-Order" construct cannot overlap, i.e.atomic processes cannot be
    ///     executed concurrently and composite processes cannot be interleaved.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Any-Order">http://www.daml.org/services/owl-s/1.2/Process.owl#Any-Order</seealso>
    let Any_Order = Prefixed_Name(owlsProcess, "Any-Order") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#AtomicProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#AtomicProcess">http://www.daml.org/services/owl-s/1.2/Process.owl#AtomicProcess</seealso>
    let AtomicProcess = Prefixed_Name(owlsProcess, "AtomicProcess") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Binding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Binding">http://www.daml.org/services/owl-s/1.2/Process.owl#Binding</seealso>
    let Binding = Prefixed_Name(owlsProcess, "Binding") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Choice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     Choice calls for the execution of a single control construct from a given bag of control
    ///     constructs (given by the components property).   Any of the given control constructs
    ///     may be chosen for execution.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Choice">http://www.daml.org/services/owl-s/1.2/Process.owl#Choice</seealso>
    let Choice = Prefixed_Name(owlsProcess, "Choice") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#CompositeProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     A CompositeProcess can have at most one invocable property. Similarly for
    ///     computedInput, computedOutput, computedEffect, and
    ///     computedPrecondition.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    ///     A CompositeProcess must have exactly 1 composedOf property.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#CompositeProcess">http://www.daml.org/services/owl-s/1.2/Process.owl#CompositeProcess</seealso>
    let CompositeProcess =
        Prefixed_Name(owlsProcess, "CompositeProcess") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#ConditionalEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" Deprecated as of version 1.1 "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ConditionalEffect">http://www.daml.org/services/owl-s/1.2/Process.owl#ConditionalEffect</seealso>
    let ConditionalEffect =
        Prefixed_Name(owlsProcess, "ConditionalEffect") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#ConditionalOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" Deprecated as of version 1.1 "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ConditionalOutput">http://www.daml.org/services/owl-s/1.2/Process.owl#ConditionalOutput</seealso>
    let ConditionalOutput =
        Prefixed_Name(owlsProcess, "ConditionalOutput") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#ControlConstruct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     A ControlConstruct can have at most one instance of timeout.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstruct">http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstruct</seealso>
    let ControlConstruct =
        Prefixed_Name(owlsProcess, "ControlConstruct") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#ControlConstructBag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" A multiset of control constructs "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstructBag">http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstructBag</seealso>
    let ControlConstructBag =
        Prefixed_Name(owlsProcess, "ControlConstructBag") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#ControlConstructList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     OWL does not make any distinction between bags and lists.  We redefine
    ///     the ControlConstructList class, rather than use equivalentClass, so as
    ///     to make that distinction.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstructList">http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstructList</seealso>
    let ControlConstructList =
        Prefixed_Name(owlsProcess, "ControlConstructList") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#If-Then-Else</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     If-Then-Else Class is a ControlConstruct that consists of a Condition, a
    ///     then and an optional else process.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#If-Then-Else">http://www.daml.org/services/owl-s/1.2/Process.owl#If-Then-Else</seealso>
    let If_Then_Else = Prefixed_Name(owlsProcess, "If-Then-Else") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Input">http://www.daml.org/services/owl-s/1.2/Process.owl#Input</seealso>
    let Input = Prefixed_Name(owlsProcess, "Input") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#InputBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     The subClassOf element is redundant, but we keep it because it is
    ///     helpful to some tools
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#InputBinding">http://www.daml.org/services/owl-s/1.2/Process.owl#InputBinding</seealso>
    let InputBinding = Prefixed_Name(owlsProcess, "InputBinding") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Iterate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     Iterate is an "abstract" class, in the sense that it's not detailed
    ///     enough to be instantiated in a process model.  It's here to serve as
    ///     the common superclass of Repeat-While, Repeat-Until, and potentially
    ///     other specific iteration constructs that might be needed in the
    ///     future.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Iterate">http://www.daml.org/services/owl-s/1.2/Process.owl#Iterate</seealso>
    let Iterate = Prefixed_Name(owlsProcess, "Iterate") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Local</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///      A Local parameter is a variable other than an input that is bound
    ///     in a precondition of an Atomic Process for use in a result condition
    ///     or effect expression (or output expression)
    ///
    ///     THEY CANNOT BE USED IN COMPOSITE PROCESSES AT ALL.
    ///     This avoids problems associated with state sharing among
    ///     asynchronously related sub processes.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Local">http://www.daml.org/services/owl-s/1.2/Process.owl#Local</seealso>
    let Local = Prefixed_Name(owlsProcess, "Local") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Output">http://www.daml.org/services/owl-s/1.2/Process.owl#Output</seealso>
    let Output = Prefixed_Name(owlsProcess, "Output") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#OutputBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     The subClassOf element is redundant, but we keep it because it is
    ///     helpful to some tools
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#OutputBinding">http://www.daml.org/services/owl-s/1.2/Process.owl#OutputBinding</seealso>
    let OutputBinding = Prefixed_Name(owlsProcess, "OutputBinding") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     This is the simplest way to relate parameters to
    ///     SWRL (and DRS) variables.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Parameter">http://www.daml.org/services/owl-s/1.2/Process.owl#Parameter</seealso>
    let Parameter = Prefixed_Name(owlsProcess, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Participant">http://www.daml.org/services/owl-s/1.2/Process.owl#Participant</seealso>
    let Participant = Prefixed_Name(owlsProcess, "Participant") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Perform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     The PERFORM construct is how one references a process in a composite
    ///     process.  This is analogous to a function call in a program body. The
    ///     inputs to the PERFORM are described using the hasDataFrom property.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Perform">http://www.daml.org/services/owl-s/1.2/Process.owl#Perform</seealso>
    let Perform = Prefixed_Name(owlsProcess, "Perform") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     A Process can have at most one name, but names need not be unique.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>" The most general class of processes "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Process">http://www.daml.org/services/owl-s/1.2/Process.owl#Process</seealso>
    let Process = Prefixed_Name(owlsProcess, "Process") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#ProcessComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     Deprecated as of v. 1.1.
    ///     Note: the old concept ProcessComponent is no longer needed. ControlConstruct
    ///     which includes Perform as a subclass should be used anywhere that
    ///     ProcessComponent might have been used (which in the OWL-S 1.0 ontology
    ///     was only in describing the relationship to temporal aspects)
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ProcessComponent">http://www.daml.org/services/owl-s/1.2/Process.owl#ProcessComponent</seealso>
    let ProcessComponent =
        Prefixed_Name(owlsProcess, "ProcessComponent") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#Produce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Produce">http://www.daml.org/services/owl-s/1.2/Process.owl#Produce</seealso>
    let Produce = Prefixed_Name(owlsProcess, "Produce") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Repeat-Until</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     The Repeat-Until class specializes the ControlConstruct class where
    ///     the with properties "untilCondition" (range of type Condition) and
    ///     "untilProcess" (range of type Reapeat).  Repeat-Until does the
    ///     operation, tests for the condition, exits if it is true, and otherwise
    ///     loops.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Repeat-Until">http://www.daml.org/services/owl-s/1.2/Process.owl#Repeat-Until</seealso>
    let Repeat_Until = Prefixed_Name(owlsProcess, "Repeat-Until") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Repeat-While</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     The Repeat-While class specializes the ControlConstruct class
    ///     where the with properties "whileCondition" (range of type Condition)
    ///     and ``whileProcess'' (range of type Repeat).  Repeat-While tests for
    ///     the condition, exits if it is false and does the operation if the
    ///     condition is true, then loops.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Repeat-While">http://www.daml.org/services/owl-s/1.2/Process.owl#Repeat-While</seealso>
    let Repeat_While = Prefixed_Name(owlsProcess, "Repeat-While") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Result">http://www.daml.org/services/owl-s/1.2/Process.owl#Result</seealso>
    let Result = Prefixed_Name(owlsProcess, "Result") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#ResultVar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ResultVar">http://www.daml.org/services/owl-s/1.2/Process.owl#ResultVar</seealso>
    let ResultVar = Prefixed_Name(owlsProcess, "ResultVar") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     Sequence is defined as having a list of component processes that
    ///     specify the body. The Preconditions, parameters and effects of the
    ///     sequence are not defined in the minimal version.  An obvious extension
    ///     would be to define the effect of the sequence to be the union of the
    ///     effect of the individual members, and the parameters of the sequence
    ///     to be the union of the parameters of individual members. However, some
    ///     implementations may decide to use the last event's effects as the
    ///     effect of the sequence, etc.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Sequence">http://www.daml.org/services/owl-s/1.2/Process.owl#Sequence</seealso>
    let Sequence = Prefixed_Name(owlsProcess, "Sequence") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#SimpleProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#SimpleProcess">http://www.daml.org/services/owl-s/1.2/Process.owl#SimpleProcess</seealso>
    let SimpleProcess = Prefixed_Name(owlsProcess, "SimpleProcess") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Split</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     Here the process consists of concurrent execution of a bunch of
    ///     sub-processes.  No further specification about waiting,
    ///     synchronization, etc. Similar to other ontologies' use of "Concurrent"
    ///     or "Parallel".
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Split">http://www.daml.org/services/owl-s/1.2/Process.owl#Split</seealso>
    let Split = Prefixed_Name(owlsProcess, "Split") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Split-Join</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     Here the process consists of concurrent execution of a bunch of
    ///     sub-processes.  with barrier synchroniztion. With Split and Split and
    ///     Join, we can define processes which have partial synchronization
    ///     (ex. split all and join some subset).
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Split-Join">http://www.daml.org/services/owl-s/1.2/Process.owl#Split-Join</seealso>
    let Split_Join = Prefixed_Name(owlsProcess, "Split-Join") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#TheClient</para>
    /// </summary>
    /// <remarks>
    ///   <para>damlProcess:#Participant</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#TheClient">http://www.daml.org/services/owl-s/1.2/Process.owl#TheClient</seealso>
    let TheClient = Prefixed_Name(owlsProcess, "TheClient") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#TheParentPerform</para>
    /// </summary>
    /// <remarks>
    ///   <para>damlProcess:#Perform</para>
    ///   <para>"
    ///     A special-purpose object, used to refer, at runtime, to the execution
    ///     instance of the enclosing composite process definition.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#TheParentPerform">http://www.daml.org/services/owl-s/1.2/Process.owl#TheParentPerform</seealso>
    let TheParentPerform =
        Prefixed_Name(owlsProcess, "TheParentPerform") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#TheServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>damlProcess:#Participant</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#TheServer">http://www.daml.org/services/owl-s/1.2/Process.owl#TheServer</seealso>
    let TheServer = Prefixed_Name(owlsProcess, "TheServer") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#ThisPerform</para>
    /// </summary>
    /// <remarks>
    ///   <para>damlProcess:#Perform</para>
    ///   <para>"
    ///     A special-purpose object, used to refer, at runtime, to the execution
    ///     instance of the enclosing atomic process definition.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ThisPerform">http://www.daml.org/services/owl-s/1.2/Process.owl#ThisPerform</seealso>
    let ThisPerform = Prefixed_Name(owlsProcess, "ThisPerform") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#Unordered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///      Deprecated.  As of version 1.1, renamed to Any-Order.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#Unordered">http://www.daml.org/services/owl-s/1.2/Process.owl#Unordered</seealso>
    let Unordered = Prefixed_Name(owlsProcess, "Unordered") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#ValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     We allow for the possibility that another parameter of the same process is
    ///     referenced, in which case this property is optional (hence maxCard)
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    ///     Within a value form, or when using valueSource, references to
    ///     parameters of other processes require a tuple of (perform-ref,
    ///     param-ref, which we represent with ValueOf
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ValueOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ValueOf">http://www.daml.org/services/owl-s/1.2/Process.owl#ValueOf</seealso>
    let ValueOf = Prefixed_Name(owlsProcess, "ValueOf") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#collapse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is a deprecated usage; collapsesTo is preferred."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#collapse">http://www.daml.org/services/owl-s/1.2/Process.owl#collapse</seealso>
    let collapse = Prefixed_Name(owlsProcess, "collapse") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#collapsesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#collapsesTo">http://www.daml.org/services/owl-s/1.2/Process.owl#collapsesTo</seealso>
    let collapsesTo = Prefixed_Name(owlsProcess, "collapsesTo") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#components</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     The components propery of selected control construct subclasses holds
    ///     a specific arrangement of subprocesses or control constructs.
    ///     The range is declared at each relevant subclass of ControlConstruct.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#components">http://www.daml.org/services/owl-s/1.2/Process.owl#components</seealso>
    let components = Prefixed_Name(owlsProcess, "components") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#composedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#composedOf">http://www.daml.org/services/owl-s/1.2/Process.owl#composedOf</seealso>
    let composedOf = Prefixed_Name(owlsProcess, "composedOf") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#computedEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     A computed effect is a single expression that characterizes the
    ///     effects of a composite process, based on the effects
    ///     of its sub processes. This is not well defined for conditional effects at present.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedEffect">http://www.daml.org/services/owl-s/1.2/Process.owl#computedEffect</seealso>
    let computedEffect = Prefixed_Name(owlsProcess, "computedEffect") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#computedInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     A computed input is a single expression that characterizes the
    ///     inputs required by a composite process, and the conditions under
    ///     which they are required.  This expression may, if needed, tie
    ///     together 2 or more inputs; for example, "either a credit card number,
    ///     or a bank account number must be given", or "if product
    ///     id starts with 'M', no shipping method need be given".
    ///     Additionally, this expression may refer to things other than inputs;
    ///     for example; "if user's credit rating is 'excellent' or better,
    ///     Social Security number is not required", or "if product weight
    ///     is less than 1 lb., no shipping myth did need be given".
    ///
    ///     A "computed" input is so named because it is meant to be computed
    ///     automatically by some tool, by inspecting the makeup of the composite
    ///     process.
    ///
    ///     The language used to represent a computed input is not specified
    ///     here, and will be the subject of future work; hence, the use of Thing
    ///     as range.  It will require expressiveness greater than that of
    ///     OWL.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedInput">http://www.daml.org/services/owl-s/1.2/Process.owl#computedInput</seealso>
    let computedInput = Prefixed_Name(owlsProcess, "computedInput") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#computedOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     A computed output is a single expression that characterizes the
    ///     outputs required by a composite process, and the conditions under
    ///     which they are required.  See comment for computedInput.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedOutput">http://www.daml.org/services/owl-s/1.2/Process.owl#computedOutput</seealso>
    let computedOutput = Prefixed_Name(owlsProcess, "computedOutput") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#computedPrecondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     A computed precondition is a single expression that characterizes the
    ///     preconditions of a composite process, based on the preconditions
    ///     of its sub processes.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedPrecondition">http://www.daml.org/services/owl-s/1.2/Process.owl#computedPrecondition</seealso>
    let computedPrecondition =
        Prefixed_Name(owlsProcess, "computedPrecondition") |> PrefixedName

    /// <summary>
    ///   <para>damlProcess:#else</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#else">http://www.daml.org/services/owl-s/1.2/Process.owl#else</seealso>
    let else_ = Prefixed_Name(owlsProcess, "else") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#expand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is a deprecated usage; expandsTo is preferred."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#expand">http://www.daml.org/services/owl-s/1.2/Process.owl#expand</seealso>
    let expand = Prefixed_Name(owlsProcess, "expand") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#expandsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#expandsTo">http://www.daml.org/services/owl-s/1.2/Process.owl#expandsTo</seealso>
    let expandsTo = Prefixed_Name(owlsProcess, "expandsTo") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#fromProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#fromProcess">http://www.daml.org/services/owl-s/1.2/Process.owl#fromProcess</seealso>
    let fromProcess = Prefixed_Name(owlsProcess, "fromProcess") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasClient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasClient">http://www.daml.org/services/owl-s/1.2/Process.owl#hasClient</seealso>
    let hasClient = Prefixed_Name(owlsProcess, "hasClient") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasDataFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     This property has as range a Binding object, which may either indicate
    ///     constants or values that are derived from the parameters (typically
    ///     outputs) of other performs in the SAME COMPOSITE PROCESS.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasDataFrom">http://www.daml.org/services/owl-s/1.2/Process.owl#hasDataFrom</seealso>
    let hasDataFrom = Prefixed_Name(owlsProcess, "hasDataFrom") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasEffect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasEffect">http://www.daml.org/services/owl-s/1.2/Process.owl#hasEffect</seealso>
    let hasEffect = Prefixed_Name(owlsProcess, "hasEffect") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasInput">http://www.daml.org/services/owl-s/1.2/Process.owl#hasInput</seealso>
    let hasInput = Prefixed_Name(owlsProcess, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasLocal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasLocal">http://www.daml.org/services/owl-s/1.2/Process.owl#hasLocal</seealso>
    let hasLocal = Prefixed_Name(owlsProcess, "hasLocal") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasOutput">http://www.daml.org/services/owl-s/1.2/Process.owl#hasOutput</seealso>
    let hasOutput = Prefixed_Name(owlsProcess, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasParameter">http://www.daml.org/services/owl-s/1.2/Process.owl#hasParameter</seealso>
    let hasParameter = Prefixed_Name(owlsProcess, "hasParameter") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasParticipant">http://www.daml.org/services/owl-s/1.2/Process.owl#hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(owlsProcess, "hasParticipant") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasPrecondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasPrecondition">http://www.daml.org/services/owl-s/1.2/Process.owl#hasPrecondition</seealso>
    let hasPrecondition = Prefixed_Name(owlsProcess, "hasPrecondition") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasResult"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasResult">http://www.daml.org/services/owl-s/1.2/Process.owl#hasResult</seealso>
    let hasResult = Prefixed_Name(owlsProcess, "hasResult") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#hasResultVar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasResultVar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasResultVar">http://www.daml.org/services/owl-s/1.2/Process.owl#hasResultVar</seealso>
    let hasResultVar = Prefixed_Name(owlsProcess, "hasResultVar") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#ifCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>" The if condition of an if-then-else"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#ifCondition">http://www.daml.org/services/owl-s/1.2/Process.owl#ifCondition</seealso>
    let ifCondition = Prefixed_Name(owlsProcess, "ifCondition") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#inCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inCondition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#inCondition">http://www.daml.org/services/owl-s/1.2/Process.owl#inCondition</seealso>
    let inCondition = Prefixed_Name(owlsProcess, "inCondition") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#invocable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///     Invocable is a flag that tells whether the CompositeProcess bottoms
    ///     out in atomic processes.  (If so, it is "invocable".)
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#invocable">http://www.daml.org/services/owl-s/1.2/Process.owl#invocable</seealso>
    let invocable = Prefixed_Name(owlsProcess, "invocable") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#name">http://www.daml.org/services/owl-s/1.2/Process.owl#name</seealso>
    let name = Prefixed_Name(owlsProcess, "name") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#parameterType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#parameterType">http://www.daml.org/services/owl-s/1.2/Process.owl#parameterType</seealso>
    let parameterType = Prefixed_Name(owlsProcess, "parameterType") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#parameterValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///     If an Input parameter has a constant value, or (as in the case of
    ///     Output) is a description in terms of of some other process parameters,
    ///     then supply it here. Note that it must be interpreted after reading it
    ///     as an XMLLiteral.
    ///
    ///     In future, the interpretation of this literal may be extended to allow
    ///     more flexibility, such as functional expressions.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#parameterValue">http://www.daml.org/services/owl-s/1.2/Process.owl#parameterValue</seealso>
    let parameterValue = Prefixed_Name(owlsProcess, "parameterValue") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#performedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#performedBy">http://www.daml.org/services/owl-s/1.2/Process.owl#performedBy</seealso>
    let performedBy = Prefixed_Name(owlsProcess, "performedBy") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#process">http://www.daml.org/services/owl-s/1.2/Process.owl#process</seealso>
    let process_ = Prefixed_Name(owlsProcess, "process") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#producedBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#producedBinding">http://www.daml.org/services/owl-s/1.2/Process.owl#producedBinding</seealso>
    let producedBinding = Prefixed_Name(owlsProcess, "producedBinding") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#realizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#realizedBy">http://www.daml.org/services/owl-s/1.2/Process.owl#realizedBy</seealso>
    let realizedBy = Prefixed_Name(owlsProcess, "realizedBy") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#realizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#realizes">http://www.daml.org/services/owl-s/1.2/Process.owl#realizes</seealso>
    let realizes = Prefixed_Name(owlsProcess, "realizes") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#theVar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#theVar">http://www.daml.org/services/owl-s/1.2/Process.owl#theVar</seealso>
    let theVar = Prefixed_Name(owlsProcess, "theVar") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#then</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#then">http://www.daml.org/services/owl-s/1.2/Process.owl#then</seealso>
    let then_ = Prefixed_Name(owlsProcess, "then") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#timeout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     Interval of time allowed for completion of the process component (relative
    ///     to the start of process component execution).
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#timeout">http://www.daml.org/services/owl-s/1.2/Process.owl#timeout</seealso>
    let timeout = Prefixed_Name(owlsProcess, "timeout") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#toParam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#toParam">http://www.daml.org/services/owl-s/1.2/Process.owl#toParam</seealso>
    let toParam = Prefixed_Name(owlsProcess, "toParam") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#untilCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#untilCondition">http://www.daml.org/services/owl-s/1.2/Process.owl#untilCondition</seealso>
    let untilCondition = Prefixed_Name(owlsProcess, "untilCondition") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#untilProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#untilProcess">http://www.daml.org/services/owl-s/1.2/Process.owl#untilProcess</seealso>
    let untilProcess = Prefixed_Name(owlsProcess, "untilProcess") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#valueData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///     valueData is for specifying constant (XML) data to be bound to a parameter.
    ///
    ///     Ideally, the valueData property would also be a subproperty of
    ///     valueSpecifier so that it would be one of the three possible
    ///     properties used to specify a value for a Binding. But as we cannot do
    ///     that, we treat it separately, but note that if it is used, the others
    ///     should not be.
    ///
    ///     For now, its range is any XML datatype.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"valueData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueData">http://www.daml.org/services/owl-s/1.2/Process.owl#valueData</seealso>
    let valueData = Prefixed_Name(owlsProcess, "valueData") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#valueForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///     valueForm is to be used to specify an pseudo-OWL description that is
    ///     legal OWL except that variables (including process parameters) and
    ///     ValueOf forms can appear as the object of properties where those
    ///     things violate the range of the property. The intent is that this be
    ///     interpreted as a pattern indicating the actual value of the binding
    ///     after the variables have been substituted for.
    ///
    ///     A similar notation is used with valueFunction to indicate the
    ///     application of a locally (to the client) available function to convert
    ///     data (specified by variables or ValueOf) to a correct form.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"valueForm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueForm">http://www.daml.org/services/owl-s/1.2/Process.owl#valueForm</seealso>
    let valueForm = Prefixed_Name(owlsProcess, "valueForm") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#valueFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"valueFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueFunction">http://www.daml.org/services/owl-s/1.2/Process.owl#valueFunction</seealso>
    let valueFunction = Prefixed_Name(owlsProcess, "valueFunction") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#valueSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     This is the simplest kind of data flow
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"valueSource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueSource">http://www.daml.org/services/owl-s/1.2/Process.owl#valueSource</seealso>
    let valueSource = Prefixed_Name(owlsProcess, "valueSource") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#valueSpecifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"valueSpecifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueSpecifier">http://www.daml.org/services/owl-s/1.2/Process.owl#valueSpecifier</seealso>
    let valueSpecifier = Prefixed_Name(owlsProcess, "valueSpecifier") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#valueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"valueType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueType">http://www.daml.org/services/owl-s/1.2/Process.owl#valueType</seealso>
    let valueType = Prefixed_Name(owlsProcess, "valueType") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#whileCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#whileCondition">http://www.daml.org/services/owl-s/1.2/Process.owl#whileCondition</seealso>
    let whileCondition = Prefixed_Name(owlsProcess, "whileCondition") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#whileProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#whileProcess">http://www.daml.org/services/owl-s/1.2/Process.owl#whileProcess</seealso>
    let whileProcess = Prefixed_Name(owlsProcess, "whileProcess") |> PrefixedName
    /// <summary>
    ///   <para>damlProcess:#withOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"withOutput"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl#withOutput">http://www.daml.org/services/owl-s/1.2/Process.owl#withOutput</seealso>
    let withOutput = Prefixed_Name(owlsProcess, "withOutput") |> PrefixedName
