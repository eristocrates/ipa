namespace https.w3id.org.todo.tododom.hash

open DoxAletheia

module tddom =
    let _namespace_name = "https://w3id.org/todo/tododom#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Element that leaves a record of an Action obtained throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododom#ActionTrace"></see></summary>
    let ActionTrace = _prefix "ActionTrace"
    /// <summary>
    /// Element that leaves a record of an Argument obtained throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododom#ArgumentTrace"></see></summary>
    let ArgumentTrace = _prefix "ArgumentTrace"
    /// <summary>
    /// Element that covers the information to execute an Action that is executable through a command (vs. as a Service).
    /// <see href="https://w3id.org/todo/tododom#Command"></see></summary>
    let Command = _prefix "Command"
    /// <summary>
    /// Element that leaves a record of a Frame obtained throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododom#FrameTrace"></see></summary>
    let FrameTrace = _prefix "FrameTrace"
    /// <summary>
    /// Establishes the TSRI type of a given Action/Parameter.
    /// <see href="https://w3id.org/todo/tododom#InfoType"></see></summary>
    let InfoType = _prefix "InfoType"
    /// <summary>
    /// Element that leaves a record of an Intent obtained throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododom#IntentTrace"></see></summary>
    let IntentTrace = _prefix "IntentTrace"
    /// <summary>
    /// Word(s) that cover the different variants of a FrameHead or a WorldElement.
    /// <see href="https://w3id.org/todo/tododom#LexicalUnit"></see></summary>
    let LexicalUnit = _prefix "LexicalUnit"
    /// <summary>
    /// Element that leaves a record of a Skill obtained throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododom#SkillTrace"></see></summary>
    let SkillTrace = _prefix "SkillTrace"
    /// <summary>
    /// Plain language for whole action: Pick plastic container
    ///
    /// SystemReadableInfo for "pick": robAction.Pick
    /// SystemReadableInfo for "plastic container": containerID:235
    ///
    /// SystemReadableInfo for whole action: robAction.Pick(containerID:235)
    /// Information that is sent to the system to perform an execution or as argument for an execution, in a format that is understandable to the target system.
    /// <see href="https://w3id.org/todo/tododom#TargetSystemReadableInformation"></see></summary>
    let TargetSystemReadableInformation = _prefix "TargetSystemReadableInformation"
    /// <summary>
    /// Agrupation of WorldElements of similar characteristics.
    /// <see href="https://w3id.org/todo/tododom#WorldElementGroup"></see></summary>
    let WorldElementGroup = _prefix "WorldElementGroup"
    /// <summary>
    ///   <see href="https://w3id.org/todo/tododom#KeyElementTrace"></see>
    /// </summary>
    let KeyElementTrace = _prefix "KeyElementTrace"
    /// <summary>
    ///   <see href="https://w3id.org/todo/tododom#WorldElementTrace"></see>
    /// </summary>
    let WorldElementTrace = _prefix "WorldElementTrace"
    /// <summary>
    /// Unique identification value for individuals.
    /// <see href="https://w3id.org/todo/tododom#IDval"></see></summary>
    let IDval = _prefix "IDval"
    /// <summary>
    /// Establishes the relation between a WorldElement and a WorldElementGroup, which is a member of.
    /// <see href="https://w3id.org/todo/tododom#isMemberOfGroup"></see></summary>
    let isMemberOfGroup = _prefix "isMemberOfGroup"
    /// <summary>
    /// Establishes the relation between an Action/Argument/WorldElement and its corresponding TargetSystemReadableInfo.
    /// <see href="https://w3id.org/todo/tododom#hasTargetSystemReadableInfo"></see></summary>
    let hasTargetSystemReadableInfo = _prefix "hasTargetSystemReadableInfo"
    /// <summary>
    /// Establishes the relation between a FrameHead/WorldElement and one of its corresponding Lexical Units.
    /// <see href="https://w3id.org/todo/tododom#hasLexicalUnit"></see></summary>
    let hasLexicalUnit = _prefix "hasLexicalUnit"
    /// <summary>
    /// Sets specific implementation information for a Service.
    /// <see href="https://w3id.org/todo/tododom#implementation"></see></summary>
    let implementation = _prefix "implementation"
    /// <summary>
    /// Establishes the relationship between an element and its Trace.
    /// <see href="https://w3id.org/todo/tododom#hasTrace"></see></summary>
    let hasTrace = _prefix "hasTrace"
    /// <summary>
    /// Sets the order in which each argument needs to be output to the target system.
    /// <see href="https://w3id.org/todo/tododom#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// Establishes the relation between an Argument and a WorldElementGroup that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#appliesToWorldElementGroup"></see></summary>
    let appliesToWorldElementGroup = _prefix "appliesToWorldElementGroup"
    /// <summary>
    /// Establishes the relation between an Argument and a WorldElement that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#appliesToWorldElement"></see></summary>
    let appliesToWorldElement = _prefix "appliesToWorldElement"
    /// <summary>
    /// Target System Readable Information corresponding to elements of the class Action.
    /// <see href="https://w3id.org/todo/tododom#ActionTSRI"></see></summary>
    let ActionTSRI = _prefix "ActionTSRI"
    /// <summary>
    ///   <see href="https://w3id.org/todo/tododom#ActionType"></see>
    /// </summary>
    let ActionType = _prefix "ActionType"
    /// <summary>
    /// Establishes a relation between an Action/Argument/WorldElement TSRI and its TSRI type.
    /// (In a guide robot, with guiding and information functionalities; the TSRI of the destinations are coordinates and the TSRI of the elements to obtain information about are IDs)
    ///
    /// Destination_guideRobot hasTSRI ?x .
    /// ?x hasType coordinate .
    ///
    /// PieceInformation_guideRobot has TSRI ?y .
    /// ?y hasType ID .
    /// <see href="https://w3id.org/todo/tododom#hasType"></see></summary>
    let hasType = _prefix "hasType"
    /// <summary>
    /// Establishes a relation between a KeyElementTrace and the possible ArgumentTraces that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#hasPossibleArgument"></see></summary>
    let hasPossibleArgument = _prefix "hasPossibleArgument"
    /// <summary>
    /// Establishes a relation between an ActionTrace and the KeyElementTrace that it can be possibly associated to.
    /// <see href="https://w3id.org/todo/tododom#isPossibleActionOf"></see></summary>
    let isPossibleActionOf = _prefix "isPossibleActionOf"
    /// <summary>
    /// Establishes the relationship between a Trace and the element it refers to.
    /// <see href="https://w3id.org/todo/tododom#isTraceOf"></see></summary>
    let isTraceOf = _prefix "isTraceOf"
    /// <summary>
    /// Establishes a relation between a TSRI type and the Action/Argument/WorldElement TSRI with said TSRI type.
    /// (In a guide robot, with guiding and information functionalities; the TSRI of the destinations are coordinates and the TSRI of the elements to obtain information about are IDs)
    ///
    /// Destination_guideRobot hasTSRI ?x .
    /// coordinate isTypeOf ?x .
    ///
    /// PieceInformation_guideRobot has TSRI ?y .
    /// ID isTypeOf ?y .
    /// <see href="https://w3id.org/todo/tododom#isTypeOf"></see></summary>
    let isTypeOf = _prefix "isTypeOf"
    /// <summary>
    /// Target System Readable Information corresponding to elements of the class Argument.
    /// <see href="https://w3id.org/todo/tododom#ArgumentTSRI"></see></summary>
    let ArgumentTSRI = _prefix "ArgumentTSRI"
    /// <summary>
    /// Establishes the type of parameter of a TSRI.
    /// <see href="https://w3id.org/todo/tododom#ParameterType"></see></summary>
    let ParameterType = _prefix "ParameterType"
    /// <summary>
    /// Establishes the relation between an ArgumentTrace and its corresponding value (WorldElementTrace).
    /// <see href="https://w3id.org/todo/tododom#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// Establishes a relation between an ArgumentTrace and the KeyElementTrace that it can be possibly associated to.
    /// <see href="https://w3id.org/todo/tododom#isPossibleArgumentOf"></see></summary>
    let isPossibleArgumentOf = _prefix "isPossibleArgumentOf"
    /// <summary>
    /// Establishes a relation between an ArgumentTrace and the possible WorldElementTraces that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#hasPossibleValue"></see></summary>
    let hasPossibleValue = _prefix "hasPossibleValue"
    /// <summary>
    /// Target System Readable Information corresponding to elements of the class Action that require information in a Command format.
    /// <see href="https://w3id.org/todo/tododom#CommandTSRI"></see></summary>
    let CommandTSRI = _prefix "CommandTSRI"
    /// <summary>
    /// Establishes a relation between a TargetSystemReadableInformation element and its specific implementation in the target system (specification).
    /// <see href="https://w3id.org/todo/tododom#hasSpecification"></see></summary>
    let hasSpecification = _prefix "hasSpecification"
    /// <summary>
    /// Flag to determine if the KeyElementTrace is the one being processed by the Dialogue Manager.
    /// <see href="https://w3id.org/todo/tododom#current"></see></summary>
    let current = _prefix "current"
    /// <summary>
    /// Boolean to determine if an element has been asked by the DialogueManager.
    /// <see href="https://w3id.org/todo/tododom#asked"></see></summary>
    let asked = _prefix "asked"
    /// <summary>
    /// Establishes a relation between a KeyElementTrace and the possible ActionTraces that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#hasPossibleAction"></see></summary>
    let hasPossibleAction = _prefix "hasPossibleAction"
    /// <summary>
    /// Establishes the relation between a Lexical Unit and its corresponding FrameHead/WorldElement.
    /// <see href="https://w3id.org/todo/tododom#isLexicalUnitOf"></see></summary>
    let isLexicalUnitOf = _prefix "isLexicalUnitOf"
    /// <summary>
    /// Target System Readable Information corresponding to elements of the class WorldElement.
    /// <see href="https://w3id.org/todo/tododom#WorldElementTSRI"></see></summary>
    let WorldElementTSRI = _prefix "WorldElementTSRI"
    /// <summary>
    /// Target System Readable Information corresponding to elements of the class Action that point to Services.
    /// <see href="https://w3id.org/todo/tododom#ServiceTSRI"></see></summary>
    let ServiceTSRI = _prefix "ServiceTSRI"
    /// <summary>
    /// Sets the value of a TSRI to be input to the target system.
    /// <see href="https://w3id.org/todo/tododom#val"></see></summary>
    let val_ = _prefix "val"
    /// <summary>
    /// Establishes the relation between a WorldElementGroup and a member of said group.
    /// <see href="https://w3id.org/todo/tododom#hasGroupMember"></see></summary>
    let hasGroupMember = _prefix "hasGroupMember"
    /// <summary>
    /// Establishes a relation between a WorldElementTrace and the ArgumentTrace that it can be possibly associated to.
    /// <see href="https://w3id.org/todo/tododom#isPossibleValueOf"></see></summary>
    let isPossibleValueOf = _prefix "isPossibleValueOf"
    /// <summary>
    /// Establishes the relation between an Argument and the WorldElements that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#appliesToWorld"></see></summary>
    let appliesToWorld = _prefix "appliesToWorld"
    /// <summary>
    /// Establishes the relation between a WorldElement and the Argument(s) that it can be associated to.
    /// <see href="https://w3id.org/todo/tododom#isApplicableToArgument"></see></summary>
    let isApplicableToArgument = _prefix "isApplicableToArgument"
    /// <summary>
    /// Establishes a relation between a UserRequestTrace/UserResponseTrace and the Key Elements (KeyElementTrace) extracted from it.
    /// <see href="https://w3id.org/todo/tododom#hasKeyElement"></see></summary>
    let hasKeyElement = _prefix "hasKeyElement"
    /// <summary>
    /// Establishes a relation between a KeyElementTrace and the UserRequestTrace/UserResponseTrace it is extracted from.
    /// <see href="https://w3id.org/todo/tododom#isKeyElementOf"></see></summary>
    let isKeyElementOf = _prefix "isKeyElementOf"
    /// <summary>
    /// Establishes a relation between a Trace and the possible Traces that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#hasPossible"></see></summary>
    let hasPossible = _prefix "hasPossible"
    /// <summary>
    /// Establishes a relation between a Trace and the Trace that it can be possibly associated to.
    /// <see href="https://w3id.org/todo/tododom#isPossible"></see></summary>
    let isPossible = _prefix "isPossible"
    /// <summary>
    /// Establishes the relation between a TargetSystemReadableInfon and the Action/Argument/WorldElement it corresponds to.
    /// <see href="https://w3id.org/todo/tododom#isTargetSystemReadableInfoOf"></see></summary>
    let isTargetSystemReadableInfoOf = _prefix "isTargetSystemReadableInfoOf"
    /// <summary>
    /// Flag to determine the order of KeyElementTraces.
    /// <see href="https://w3id.org/todo/tododom#index"></see></summary>
    let index = _prefix "index"
    /// <summary>
    /// Stores the KeyElements that have been used to perform assignation in the Dialogue Manager.
    /// <see href="https://w3id.org/todo/tododom#keyElementsUsedToAssign"></see></summary>
    let keyElementsUsedToAssign = _prefix "keyElementsUsedToAssign"
