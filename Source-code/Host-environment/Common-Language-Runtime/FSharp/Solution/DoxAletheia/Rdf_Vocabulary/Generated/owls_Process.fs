namespace http.www.daml.org.services.owl_s._1._2.Process.owl.hash

open DoxAletheia

module owls_Process =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/Process.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    ///     Allows the process components (specified as a bag) to be executed in
    ///     some unspecified order but not concurrently. Execution and completion
    ///     of all components is required. The execution of processes in an
    ///     "Any-Order" construct cannot overlap, i.e.atomic processes cannot be
    ///     executed concurrently and composite processes cannot be interleaved.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Any-Order"></see></summary>
    let ``Any-Order`` = _prefix "Any-Order"
    /// <summary>
    ///
    ///     A ControlConstruct can have at most one instance of timeout.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstruct"></see></summary>
    let ControlConstruct = _prefix "ControlConstruct"
    /// <summary>
    ///
    ///     The components propery of selected control construct subclasses holds
    ///     a specific arrangement of subprocesses or control constructs.
    ///     The range is declared at each relevant subclass of ControlConstruct.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#components"></see></summary>
    let components = _prefix "components"
    /// <summary>
    ///  A multiset of control constructs
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstructBag"></see></summary>
    let ControlConstructBag = _prefix "ControlConstructBag"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#AtomicProcess"></see>
    /// </summary>
    let AtomicProcess = _prefix "AtomicProcess"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasClient"></see>
    /// </summary>
    let hasClient = _prefix "hasClient"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#TheClient"></see>
    /// </summary>
    let TheClient = _prefix "TheClient"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#performedBy"></see>
    /// </summary>
    let performedBy = _prefix "performedBy"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#TheServer"></see>
    /// </summary>
    let TheServer = _prefix "TheServer"
    /// <summary>
    ///  The most general class of processes
    ///
    ///     A Process can have at most one name, but names need not be unique.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Process"></see></summary>
    let Process = _prefix "Process"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Binding"></see>
    /// </summary>
    let Binding = _prefix "Binding"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#toParam"></see>
    /// </summary>
    let toParam = _prefix "toParam"
    /// <summary>
    ///
    ///     This is the simplest kind of data flow
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueSource"></see></summary>
    let valueSource = _prefix "valueSource"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueSpecifier"></see>
    /// </summary>
    let valueSpecifier = _prefix "valueSpecifier"
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
    let valueData = _prefix "valueData"
    /// <summary>
    ///
    ///     Choice calls for the execution of a single control construct from a given bag of control
    ///     constructs (given by the components property).   Any of the given control constructs
    ///     may be chosen for execution.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Choice"></see></summary>
    let Choice = _prefix "Choice"
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
    let CompositeProcess = _prefix "CompositeProcess"
    /// <summary>
    ///
    ///     Invocable is a flag that tells whether the CompositeProcess bottoms
    ///     out in atomic processes.  (If so, it is "invocable".)
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#invocable"></see></summary>
    let invocable = _prefix "invocable"
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
    let computedInput = _prefix "computedInput"
    /// <summary>
    ///
    ///     A computed output is a single expression that characterizes the
    ///     outputs required by a composite process, and the conditions under
    ///     which they are required.  See comment for computedInput.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedOutput"></see></summary>
    let computedOutput = _prefix "computedOutput"
    /// <summary>
    ///
    ///     A computed effect is a single expression that characterizes the
    ///     effects of a composite process, based on the effects
    ///     of its sub processes. This is not well defined for conditional effects at present.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedEffect"></see></summary>
    let computedEffect = _prefix "computedEffect"
    /// <summary>
    ///
    ///     A computed precondition is a single expression that characterizes the
    ///     preconditions of a composite process, based on the preconditions
    ///     of its sub processes.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#computedPrecondition"></see></summary>
    let computedPrecondition = _prefix "computedPrecondition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#SimpleProcess"></see>
    /// </summary>
    let SimpleProcess = _prefix "SimpleProcess"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#composedOf"></see>
    /// </summary>
    let composedOf = _prefix "composedOf"
    /// <summary>
    ///
    ///     Interval of time allowed for completion of the process component (relative
    ///     to the start of process component execution).
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#timeout"></see></summary>
    let timeout = _prefix "timeout"
    /// <summary>
    ///
    ///     OWL does not make any distinction between bags and lists.  We redefine
    ///     the ControlConstructList class, rather than use equivalentClass, so as
    ///     to make that distinction.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ControlConstructList"></see></summary>
    let ControlConstructList = _prefix "ControlConstructList"
    /// <summary>
    ///
    ///     If-Then-Else Class is a ControlConstruct that consists of a Condition, a
    ///     then and an optional else process.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#If-Then-Else"></see></summary>
    let ``If-Then-Else`` = _prefix "If-Then-Else"
    /// <summary>
    ///  The if condition of an if-then-else
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ifCondition"></see></summary>
    let ifCondition = _prefix "ifCondition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#then"></see>
    /// </summary>
    let then_ = _prefix "then"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#else"></see>
    /// </summary>
    let else_ = _prefix "else"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Input"></see>
    /// </summary>
    let Input = _prefix "Input"
    /// <summary>
    ///
    ///     This is the simplest way to relate parameters to
    ///     SWRL (and DRS) variables.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Parameter"></see></summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Output"></see>
    /// </summary>
    let Output = _prefix "Output"
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
    let Local = _prefix "Local"
    /// <summary>
    ///
    ///     The subClassOf element is redundant, but we keep it because it is
    ///     helpful to some tools
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#InputBinding"></see></summary>
    let InputBinding = _prefix "InputBinding"
    /// <summary>
    ///
    ///     Iterate is an "abstract" class, in the sense that it's not detailed
    ///     enough to be instantiated in a process model.  It's here to serve as
    ///     the common superclass of Repeat-While, Repeat-Until, and potentially
    ///     other specific iteration constructs that might be needed in the
    ///     future.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Iterate"></see></summary>
    let Iterate = _prefix "Iterate"
    /// <summary>
    ///
    ///     The subClassOf element is redundant, but we keep it because it is
    ///     helpful to some tools
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#OutputBinding"></see></summary>
    let OutputBinding = _prefix "OutputBinding"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#parameterType"></see>
    /// </summary>
    let parameterType = _prefix "parameterType"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Participant"></see>
    /// </summary>
    let Participant = _prefix "Participant"
    /// <summary>
    ///
    ///     The PERFORM construct is how one references a process in a composite
    ///     process.  This is analogous to a function call in a program body. The
    ///     inputs to the PERFORM are described using the hasDataFrom property.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Perform"></see></summary>
    let Perform = _prefix "Perform"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#process"></see>
    /// </summary>
    let process_ = _prefix "process"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Produce"></see>
    /// </summary>
    let Produce = _prefix "Produce"
    /// <summary>
    ///
    ///     The Repeat-Until class specializes the ControlConstruct class where
    ///     the with properties "untilCondition" (range of type Condition) and
    ///     "untilProcess" (range of type Reapeat).  Repeat-Until does the
    ///     operation, tests for the condition, exits if it is true, and otherwise
    ///     loops.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Repeat-Until"></see></summary>
    let ``Repeat-Until`` = _prefix "Repeat-Until"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#untilCondition"></see>
    /// </summary>
    let untilCondition = _prefix "untilCondition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#untilProcess"></see>
    /// </summary>
    let untilProcess = _prefix "untilProcess"
    /// <summary>
    ///
    ///     The Repeat-While class specializes the ControlConstruct class
    ///     where the with properties "whileCondition" (range of type Condition)
    ///     and ``whileProcess'' (range of type Repeat).  Repeat-While tests for
    ///     the condition, exits if it is false and does the operation if the
    ///     condition is true, then loops.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Repeat-While"></see></summary>
    let ``Repeat-While`` = _prefix "Repeat-While"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#whileCondition"></see>
    /// </summary>
    let whileCondition = _prefix "whileCondition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#whileProcess"></see>
    /// </summary>
    let whileProcess = _prefix "whileProcess"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Result"></see>
    /// </summary>
    let Result = _prefix "Result"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ResultVar"></see>
    /// </summary>
    let ResultVar = _prefix "ResultVar"
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
    let Sequence = _prefix "Sequence"
    /// <summary>
    ///
    ///     Here the process consists of concurrent execution of a bunch of
    ///     sub-processes.  No further specification about waiting,
    ///     synchronization, etc. Similar to other ontologies' use of "Concurrent"
    ///     or "Parallel".
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Split"></see></summary>
    let Split = _prefix "Split"
    /// <summary>
    ///
    ///     Here the process consists of concurrent execution of a bunch of
    ///     sub-processes.  with barrier synchroniztion. With Split and Split and
    ///     Join, we can define processes which have partial synchronization
    ///     (ex. split all and join some subset).
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#Split-Join"></see></summary>
    let ``Split-Join`` = _prefix "Split-Join"
    /// <summary>
    ///
    ///     A special-purpose object, used to refer, at runtime, to the execution
    ///     instance of the enclosing composite process definition.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#TheParentPerform"></see></summary>
    let TheParentPerform = _prefix "TheParentPerform"
    /// <summary>
    ///
    ///     A special-purpose object, used to refer, at runtime, to the execution
    ///     instance of the enclosing atomic process definition.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#ThisPerform"></see></summary>
    let ThisPerform = _prefix "ThisPerform"
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
    let ValueOf = _prefix "ValueOf"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#theVar"></see>
    /// </summary>
    let theVar = _prefix "theVar"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#fromProcess"></see>
    /// </summary>
    let fromProcess = _prefix "fromProcess"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#collapsesTo"></see>
    /// </summary>
    let collapsesTo = _prefix "collapsesTo"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#expandsTo"></see>
    /// </summary>
    let expandsTo = _prefix "expandsTo"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasParticipant"></see>
    /// </summary>
    let hasParticipant = _prefix "hasParticipant"
    /// <summary>
    ///
    ///     This property has as range a Binding object, which may either indicate
    ///     constants or values that are derived from the parameters (typically
    ///     outputs) of other performs in the SAME COMPOSITE PROCESS.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasDataFrom"></see></summary>
    let hasDataFrom = _prefix "hasDataFrom"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasEffect"></see>
    /// </summary>
    let hasEffect = _prefix "hasEffect"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasInput"></see>
    /// </summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasParameter"></see>
    /// </summary>
    let hasParameter = _prefix "hasParameter"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasLocal"></see>
    /// </summary>
    let hasLocal = _prefix "hasLocal"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasOutput"></see>
    /// </summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasPrecondition"></see>
    /// </summary>
    let hasPrecondition = _prefix "hasPrecondition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasResult"></see>
    /// </summary>
    let hasResult = _prefix "hasResult"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#hasResultVar"></see>
    /// </summary>
    let hasResultVar = _prefix "hasResultVar"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#inCondition"></see>
    /// </summary>
    let inCondition = _prefix "inCondition"
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
    let parameterValue = _prefix "parameterValue"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#producedBinding"></see>
    /// </summary>
    let producedBinding = _prefix "producedBinding"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#realizedBy"></see>
    /// </summary>
    let realizedBy = _prefix "realizedBy"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#realizes"></see>
    /// </summary>
    let realizes = _prefix "realizes"
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
    let valueForm = _prefix "valueForm"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueFunction"></see>
    /// </summary>
    let valueFunction = _prefix "valueFunction"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#valueType"></see>
    /// </summary>
    let valueType = _prefix "valueType"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Process.owl#withOutput"></see>
    /// </summary>
    let withOutput = _prefix "withOutput"
