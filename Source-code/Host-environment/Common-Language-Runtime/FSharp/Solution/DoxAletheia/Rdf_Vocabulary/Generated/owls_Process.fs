namespace http.www.daml.org.services.owl_s._1._2.Process.owl.hash

open DoxAletheia.Rdf_Vocabulary

module owls_Process =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/Process.owl#"

    /// <summary>
    ///
    ///     Allows the process components (specified as a bag) to be executed in
    ///     some unspecified order but not concurrently. Execution and completion
    ///     of all components is required. The execution of processes in an
    ///     "Any-Order" construct cannot overlap, i.e.atomic processes cannot be
    ///     executed concurrently and composite processes cannot be interleaved.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Any-Order"></see></summary>
    let ``Any-Order`` =
        Namespaced_IRI.parse _namespace_name "Any-Order" |> NamespacedName

    /// <summary>
    ///
    ///     A ControlConstruct can have at most one instance of timeout.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstruct"></see></summary>
    let ControlConstruct =
        Namespaced_IRI.parse _namespace_name "ControlConstruct" |> NamespacedName

    /// <summary>
    ///
    ///     The components propery of selected control construct subclasses holds
    ///     a specific arrangement of subprocesses or control constructs.
    ///     The range is declared at each relevant subclass of ControlConstruct.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#components"></see></summary>
    let components = Namespaced_IRI.parse _namespace_name "components" |> NamespacedName

    /// <summary>
    ///  A multiset of control constructs
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstructBag"></see></summary>
    let ControlConstructBag =
        Namespaced_IRI.parse _namespace_name "ControlConstructBag" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#AtomicProcess"></see>
    /// </summary>
    let AtomicProcess =
        Namespaced_IRI.parse _namespace_name "AtomicProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasClient"></see>
    /// </summary>
    let hasClient = Namespaced_IRI.parse _namespace_name "hasClient" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#TheClient"></see>
    /// </summary>
    let TheClient = Namespaced_IRI.parse _namespace_name "TheClient" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#performedBy"></see>
    /// </summary>
    let performedBy =
        Namespaced_IRI.parse _namespace_name "performedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#TheServer"></see>
    /// </summary>
    let TheServer = Namespaced_IRI.parse _namespace_name "TheServer" |> NamespacedName
    /// <summary>
    ///  The most general class of processes
    ///
    ///     A Process can have at most one name, but names need not be unique.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Process"></see></summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Binding"></see>
    /// </summary>
    let Binding = Namespaced_IRI.parse _namespace_name "Binding" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#toParam"></see>
    /// </summary>
    let toParam = Namespaced_IRI.parse _namespace_name "toParam" |> NamespacedName

    /// <summary>
    ///
    ///     This is the simplest kind of data flow
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueSource"></see></summary>
    let valueSource =
        Namespaced_IRI.parse _namespace_name "valueSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueSpecifier"></see>
    /// </summary>
    let valueSpecifier =
        Namespaced_IRI.parse _namespace_name "valueSpecifier" |> NamespacedName

    /// <summary>
    ///
    ///     valueData is for specifying constant (XML) data to be bound to a parameter.
    ///
    ///     Ideally, the valueData property would also be a subproperty of
    ///     valueSpecifier so that it would be one of the three possible
    ///     properties used to specify a value for a Binding. But as we cannot do
    ///     that, we treat it separately, but note that if it is used, the others
    ///     should not be.
    ///
    ///     For now, its range is any XML datatype.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueData"></see></summary>
    let valueData = Namespaced_IRI.parse _namespace_name "valueData" |> NamespacedName
    /// <summary>
    ///
    ///     Choice calls for the execution of a single control construct from a given bag of control
    ///     constructs (given by the components property).   Any of the given control constructs
    ///     may be chosen for execution.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Choice"></see></summary>
    let Choice = Namespaced_IRI.parse _namespace_name "Choice" |> NamespacedName

    /// <summary>
    ///
    ///     A CompositeProcess must have exactly 1 composedOf property.
    ///
    ///
    ///     A CompositeProcess can have at most one invocable property. Similarly for
    ///     computedInput, computedOutput, computedEffect, and
    ///     computedPrecondition.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#CompositeProcess"></see></summary>
    let CompositeProcess =
        Namespaced_IRI.parse _namespace_name "CompositeProcess" |> NamespacedName

    /// <summary>
    ///
    ///     Invocable is a flag that tells whether the CompositeProcess bottoms
    ///     out in atomic processes.  (If so, it is "invocable".)
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#invocable"></see></summary>
    let invocable = Namespaced_IRI.parse _namespace_name "invocable" |> NamespacedName

    /// <summary>
    ///
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
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedInput"></see></summary>
    let computedInput =
        Namespaced_IRI.parse _namespace_name "computedInput" |> NamespacedName

    /// <summary>
    ///
    ///     A computed output is a single expression that characterizes the
    ///     outputs required by a composite process, and the conditions under
    ///     which they are required.  See comment for computedInput.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedOutput"></see></summary>
    let computedOutput =
        Namespaced_IRI.parse _namespace_name "computedOutput" |> NamespacedName

    /// <summary>
    ///
    ///     A computed effect is a single expression that characterizes the
    ///     effects of a composite process, based on the effects
    ///     of its sub processes. This is not well defined for conditional effects at present.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedEffect"></see></summary>
    let computedEffect =
        Namespaced_IRI.parse _namespace_name "computedEffect" |> NamespacedName

    /// <summary>
    ///
    ///     A computed precondition is a single expression that characterizes the
    ///     preconditions of a composite process, based on the preconditions
    ///     of its sub processes.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedPrecondition"></see></summary>
    let computedPrecondition =
        Namespaced_IRI.parse _namespace_name "computedPrecondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#SimpleProcess"></see>
    /// </summary>
    let SimpleProcess =
        Namespaced_IRI.parse _namespace_name "SimpleProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#composedOf"></see>
    /// </summary>
    let composedOf = Namespaced_IRI.parse _namespace_name "composedOf" |> NamespacedName
    /// <summary>
    ///
    ///     Interval of time allowed for completion of the process component (relative
    ///     to the start of process component execution).
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#timeout"></see></summary>
    let timeout = Namespaced_IRI.parse _namespace_name "timeout" |> NamespacedName

    /// <summary>
    ///
    ///     OWL does not make any distinction between bags and lists.  We redefine
    ///     the ControlConstructList class, rather than use equivalentClass, so as
    ///     to make that distinction.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstructList"></see></summary>
    let ControlConstructList =
        Namespaced_IRI.parse _namespace_name "ControlConstructList" |> NamespacedName

    /// <summary>
    ///
    ///     If-Then-Else Class is a ControlConstruct that consists of a Condition, a
    ///     then and an optional else process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#If-Then-Else"></see></summary>
    let ``If-Then-Else`` =
        Namespaced_IRI.parse _namespace_name "If-Then-Else" |> NamespacedName

    /// <summary>
    ///  The if condition of an if-then-else
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ifCondition"></see></summary>
    let ifCondition =
        Namespaced_IRI.parse _namespace_name "ifCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#then"></see>
    /// </summary>
    let then_ = Namespaced_IRI.parse _namespace_name "then" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#else"></see>
    /// </summary>
    let else_ = Namespaced_IRI.parse _namespace_name "else" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Input"></see>
    /// </summary>
    let Input = Namespaced_IRI.parse _namespace_name "Input" |> NamespacedName
    /// <summary>
    ///
    ///     This is the simplest way to relate parameters to
    ///     SWRL (and DRS) variables.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Output"></see>
    /// </summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName
    /// <summary>
    ///
    ///      A Local parameter is a variable other than an input that is bound
    ///     in a precondition of an Atomic Process for use in a result condition
    ///     or effect expression (or output expression)
    ///
    ///     THEY CANNOT BE USED IN COMPOSITE PROCESSES AT ALL.
    ///     This avoids problems associated with state sharing among
    ///     asynchronously related sub processes.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Local"></see></summary>
    let Local = Namespaced_IRI.parse _namespace_name "Local" |> NamespacedName

    /// <summary>
    ///
    ///     The subClassOf element is redundant, but we keep it because it is
    ///     helpful to some tools
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#InputBinding"></see></summary>
    let InputBinding =
        Namespaced_IRI.parse _namespace_name "InputBinding" |> NamespacedName

    /// <summary>
    ///
    ///     Iterate is an "abstract" class, in the sense that it's not detailed
    ///     enough to be instantiated in a process model.  It's here to serve as
    ///     the common superclass of Repeat-While, Repeat-Until, and potentially
    ///     other specific iteration constructs that might be needed in the
    ///     future.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Iterate"></see></summary>
    let Iterate = Namespaced_IRI.parse _namespace_name "Iterate" |> NamespacedName

    /// <summary>
    ///
    ///     The subClassOf element is redundant, but we keep it because it is
    ///     helpful to some tools
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#OutputBinding"></see></summary>
    let OutputBinding =
        Namespaced_IRI.parse _namespace_name "OutputBinding" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#parameterType"></see>
    /// </summary>
    let parameterType =
        Namespaced_IRI.parse _namespace_name "parameterType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Participant"></see>
    /// </summary>
    let Participant =
        Namespaced_IRI.parse _namespace_name "Participant" |> NamespacedName

    /// <summary>
    ///
    ///     The PERFORM construct is how one references a process in a composite
    ///     process.  This is analogous to a function call in a program body. The
    ///     inputs to the PERFORM are described using the hasDataFrom property.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Perform"></see></summary>
    let Perform = Namespaced_IRI.parse _namespace_name "Perform" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#process"></see>
    /// </summary>
    let process_ = Namespaced_IRI.parse _namespace_name "process" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Produce"></see>
    /// </summary>
    let Produce = Namespaced_IRI.parse _namespace_name "Produce" |> NamespacedName

    /// <summary>
    ///
    ///     The Repeat-Until class specializes the ControlConstruct class where
    ///     the with properties "untilCondition" (range of type Condition) and
    ///     "untilProcess" (range of type Reapeat).  Repeat-Until does the
    ///     operation, tests for the condition, exits if it is true, and otherwise
    ///     loops.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Repeat-Until"></see></summary>
    let ``Repeat-Until`` =
        Namespaced_IRI.parse _namespace_name "Repeat-Until" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#untilCondition"></see>
    /// </summary>
    let untilCondition =
        Namespaced_IRI.parse _namespace_name "untilCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#untilProcess"></see>
    /// </summary>
    let untilProcess =
        Namespaced_IRI.parse _namespace_name "untilProcess" |> NamespacedName

    /// <summary>
    ///
    ///     The Repeat-While class specializes the ControlConstruct class
    ///     where the with properties "whileCondition" (range of type Condition)
    ///     and ``whileProcess'' (range of type Repeat).  Repeat-While tests for
    ///     the condition, exits if it is false and does the operation if the
    ///     condition is true, then loops.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Repeat-While"></see></summary>
    let ``Repeat-While`` =
        Namespaced_IRI.parse _namespace_name "Repeat-While" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#whileCondition"></see>
    /// </summary>
    let whileCondition =
        Namespaced_IRI.parse _namespace_name "whileCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#whileProcess"></see>
    /// </summary>
    let whileProcess =
        Namespaced_IRI.parse _namespace_name "whileProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Result"></see>
    /// </summary>
    let Result = Namespaced_IRI.parse _namespace_name "Result" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ResultVar"></see>
    /// </summary>
    let ResultVar = Namespaced_IRI.parse _namespace_name "ResultVar" |> NamespacedName
    /// <summary>
    ///
    ///     Sequence is defined as having a list of component processes that
    ///     specify the body. The Preconditions, parameters and effects of the
    ///     sequence are not defined in the minimal version.  An obvious extension
    ///     would be to define the effect of the sequence to be the union of the
    ///     effect of the individual members, and the parameters of the sequence
    ///     to be the union of the parameters of individual members. However, some
    ///     implementations may decide to use the last event's effects as the
    ///     effect of the sequence, etc.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Sequence"></see></summary>
    let Sequence = Namespaced_IRI.parse _namespace_name "Sequence" |> NamespacedName
    /// <summary>
    ///
    ///     Here the process consists of concurrent execution of a bunch of
    ///     sub-processes.  No further specification about waiting,
    ///     synchronization, etc. Similar to other ontologies' use of "Concurrent"
    ///     or "Parallel".
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Split"></see></summary>
    let Split = Namespaced_IRI.parse _namespace_name "Split" |> NamespacedName

    /// <summary>
    ///
    ///     Here the process consists of concurrent execution of a bunch of
    ///     sub-processes.  with barrier synchroniztion. With Split and Split and
    ///     Join, we can define processes which have partial synchronization
    ///     (ex. split all and join some subset).
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Split-Join"></see></summary>
    let ``Split-Join`` =
        Namespaced_IRI.parse _namespace_name "Split-Join" |> NamespacedName

    /// <summary>
    ///
    ///     A special-purpose object, used to refer, at runtime, to the execution
    ///     instance of the enclosing composite process definition.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#TheParentPerform"></see></summary>
    let TheParentPerform =
        Namespaced_IRI.parse _namespace_name "TheParentPerform" |> NamespacedName

    /// <summary>
    ///
    ///     A special-purpose object, used to refer, at runtime, to the execution
    ///     instance of the enclosing atomic process definition.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ThisPerform"></see></summary>
    let ThisPerform =
        Namespaced_IRI.parse _namespace_name "ThisPerform" |> NamespacedName

    /// <summary>
    ///
    ///     Within a value form, or when using valueSource, references to
    ///     parameters of other processes require a tuple of (perform-ref,
    ///     param-ref, which we represent with ValueOf
    ///
    ///
    ///     We allow for the possibility that another parameter of the same process is
    ///     referenced, in which case this property is optional (hence maxCard)
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ValueOf"></see></summary>
    let ValueOf = Namespaced_IRI.parse _namespace_name "ValueOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#theVar"></see>
    /// </summary>
    let theVar = Namespaced_IRI.parse _namespace_name "theVar" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#fromProcess"></see>
    /// </summary>
    let fromProcess =
        Namespaced_IRI.parse _namespace_name "fromProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#collapsesTo"></see>
    /// </summary>
    let collapsesTo =
        Namespaced_IRI.parse _namespace_name "collapsesTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#expandsTo"></see>
    /// </summary>
    let expandsTo = Namespaced_IRI.parse _namespace_name "expandsTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasParticipant"></see>
    /// </summary>
    let hasParticipant =
        Namespaced_IRI.parse _namespace_name "hasParticipant" |> NamespacedName

    /// <summary>
    ///
    ///     This property has as range a Binding object, which may either indicate
    ///     constants or values that are derived from the parameters (typically
    ///     outputs) of other performs in the SAME COMPOSITE PROCESS.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasDataFrom"></see></summary>
    let hasDataFrom =
        Namespaced_IRI.parse _namespace_name "hasDataFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasEffect"></see>
    /// </summary>
    let hasEffect = Namespaced_IRI.parse _namespace_name "hasEffect" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasInput"></see>
    /// </summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasParameter"></see>
    /// </summary>
    let hasParameter =
        Namespaced_IRI.parse _namespace_name "hasParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasLocal"></see>
    /// </summary>
    let hasLocal = Namespaced_IRI.parse _namespace_name "hasLocal" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasOutput"></see>
    /// </summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasPrecondition"></see>
    /// </summary>
    let hasPrecondition =
        Namespaced_IRI.parse _namespace_name "hasPrecondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasResult"></see>
    /// </summary>
    let hasResult = Namespaced_IRI.parse _namespace_name "hasResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasResultVar"></see>
    /// </summary>
    let hasResultVar =
        Namespaced_IRI.parse _namespace_name "hasResultVar" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#inCondition"></see>
    /// </summary>
    let inCondition =
        Namespaced_IRI.parse _namespace_name "inCondition" |> NamespacedName

    /// <summary>
    ///
    ///     If an Input parameter has a constant value, or (as in the case of
    ///     Output) is a description in terms of of some other process parameters,
    ///     then supply it here. Note that it must be interpreted after reading it
    ///     as an XMLLiteral.
    ///
    ///     In future, the interpretation of this literal may be extended to allow
    ///     more flexibility, such as functional expressions.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#parameterValue"></see></summary>
    let parameterValue =
        Namespaced_IRI.parse _namespace_name "parameterValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#producedBinding"></see>
    /// </summary>
    let producedBinding =
        Namespaced_IRI.parse _namespace_name "producedBinding" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#realizedBy"></see>
    /// </summary>
    let realizedBy = Namespaced_IRI.parse _namespace_name "realizedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#realizes"></see>
    /// </summary>
    let realizes = Namespaced_IRI.parse _namespace_name "realizes" |> NamespacedName
    /// <summary>
    ///
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
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueForm"></see></summary>
    let valueForm = Namespaced_IRI.parse _namespace_name "valueForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueFunction"></see>
    /// </summary>
    let valueFunction =
        Namespaced_IRI.parse _namespace_name "valueFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueType"></see>
    /// </summary>
    let valueType = Namespaced_IRI.parse _namespace_name "valueType" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#withOutput"></see>
    /// </summary>
    let withOutput = Namespaced_IRI.parse _namespace_name "withOutput" |> NamespacedName
