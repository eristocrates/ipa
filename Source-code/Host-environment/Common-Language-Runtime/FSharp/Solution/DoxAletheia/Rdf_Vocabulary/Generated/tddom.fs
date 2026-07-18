namespace https.w3id.org.todo.tododom.hash

open DoxAletheia.Rdf_Vocabulary

module tddom =
    let _namespace_name = "https://w3id.org/todo/tododom#"

    /// <summary>
    /// Element that leaves a record of an Action obtained throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododom#ActionTrace"></see></summary>
    let ActionTrace =
        Namespaced_IRI.parse _namespace_name "ActionTrace" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of an Argument obtained throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododom#ArgumentTrace"></see></summary>
    let ArgumentTrace =
        Namespaced_IRI.parse _namespace_name "ArgumentTrace" |> NamespacedName

    /// <summary>
    /// Element that covers the information to execute an Action that is executable through a command (vs. as a Service).
    /// <see href="https://w3id.org/todo/tododom#Command"></see></summary>
    let Command = Namespaced_IRI.parse _namespace_name "Command" |> NamespacedName
    /// <summary>
    /// Element that leaves a record of a Frame obtained throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododom#FrameTrace"></see></summary>
    let FrameTrace = Namespaced_IRI.parse _namespace_name "FrameTrace" |> NamespacedName
    /// <summary>
    /// Establishes the TSRI type of a given Action/Parameter.
    /// <see href="https://w3id.org/todo/tododom#InfoType"></see></summary>
    let InfoType = Namespaced_IRI.parse _namespace_name "InfoType" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of an Intent obtained throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododom#IntentTrace"></see></summary>
    let IntentTrace =
        Namespaced_IRI.parse _namespace_name "IntentTrace" |> NamespacedName

    /// <summary>
    /// Word(s) that cover the different variants of a FrameHead or a WorldElement.
    /// <see href="https://w3id.org/todo/tododom#LexicalUnit"></see></summary>
    let LexicalUnit =
        Namespaced_IRI.parse _namespace_name "LexicalUnit" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of a Skill obtained throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododom#SkillTrace"></see></summary>
    let SkillTrace = Namespaced_IRI.parse _namespace_name "SkillTrace" |> NamespacedName

    /// <summary>
    /// Plain language for whole action: Pick plastic container
    ///
    /// SystemReadableInfo for "pick": robAction.Pick
    /// SystemReadableInfo for "plastic container": containerID:235
    ///
    /// SystemReadableInfo for whole action: robAction.Pick(containerID:235)
    /// Information that is sent to the system to perform an execution or as argument for an execution, in a format that is understandable to the target system.
    /// <see href="https://w3id.org/todo/tododom#TargetSystemReadableInformation"></see></summary>
    let TargetSystemReadableInformation =
        Namespaced_IRI.parse _namespace_name "TargetSystemReadableInformation" |> NamespacedName

    /// <summary>
    /// Agrupation of WorldElements of similar characteristics.
    /// <see href="https://w3id.org/todo/tododom#WorldElementGroup"></see></summary>
    let WorldElementGroup =
        Namespaced_IRI.parse _namespace_name "WorldElementGroup" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/todo/tododom#KeyElementTrace"></see>
    /// </summary>
    let KeyElementTrace =
        Namespaced_IRI.parse _namespace_name "KeyElementTrace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/todo/tododom#WorldElementTrace"></see>
    /// </summary>
    let WorldElementTrace =
        Namespaced_IRI.parse _namespace_name "WorldElementTrace" |> NamespacedName

    /// <summary>
    /// Unique identification value for individuals.
    /// <see href="https://w3id.org/todo/tododom#IDval"></see></summary>
    let IDval = Namespaced_IRI.parse _namespace_name "IDval" |> NamespacedName

    /// <summary>
    /// Establishes the relation between a WorldElement and a WorldElementGroup, which is a member of.
    /// <see href="https://w3id.org/todo/tododom#isMemberOfGroup"></see></summary>
    let isMemberOfGroup =
        Namespaced_IRI.parse _namespace_name "isMemberOfGroup" |> NamespacedName

    /// <summary>
    /// Establishes the relation between an Action/Argument/WorldElement and its corresponding TargetSystemReadableInfo.
    /// <see href="https://w3id.org/todo/tododom#hasTargetSystemReadableInfo"></see></summary>
    let hasTargetSystemReadableInfo =
        Namespaced_IRI.parse _namespace_name "hasTargetSystemReadableInfo" |> NamespacedName

    /// <summary>
    /// Establishes the relation between a FrameHead/WorldElement and one of its corresponding Lexical Units.
    /// <see href="https://w3id.org/todo/tododom#hasLexicalUnit"></see></summary>
    let hasLexicalUnit =
        Namespaced_IRI.parse _namespace_name "hasLexicalUnit" |> NamespacedName

    /// <summary>
    /// Sets specific implementation information for a Service.
    /// <see href="https://w3id.org/todo/tododom#implementation"></see></summary>
    let implementation =
        Namespaced_IRI.parse _namespace_name "implementation" |> NamespacedName

    /// <summary>
    /// Establishes the relationship between an element and its Trace.
    /// <see href="https://w3id.org/todo/tododom#hasTrace"></see></summary>
    let hasTrace = Namespaced_IRI.parse _namespace_name "hasTrace" |> NamespacedName
    /// <summary>
    /// Sets the order in which each argument needs to be output to the target system.
    /// <see href="https://w3id.org/todo/tododom#order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName

    /// <summary>
    /// Establishes the relation between an Argument and a WorldElementGroup that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#appliesToWorldElementGroup"></see></summary>
    let appliesToWorldElementGroup =
        Namespaced_IRI.parse _namespace_name "appliesToWorldElementGroup" |> NamespacedName

    /// <summary>
    /// Establishes the relation between an Argument and a WorldElement that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#appliesToWorldElement"></see></summary>
    let appliesToWorldElement =
        Namespaced_IRI.parse _namespace_name "appliesToWorldElement" |> NamespacedName

    /// <summary>
    /// Target System Readable Information corresponding to elements of the class Action.
    /// <see href="https://w3id.org/todo/tododom#ActionTSRI"></see></summary>
    let ActionTSRI = Namespaced_IRI.parse _namespace_name "ActionTSRI" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/todo/tododom#ActionType"></see>
    /// </summary>
    let ActionType = Namespaced_IRI.parse _namespace_name "ActionType" |> NamespacedName
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
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName

    /// <summary>
    /// Establishes a relation between a KeyElementTrace and the possible ArgumentTraces that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#hasPossibleArgument"></see></summary>
    let hasPossibleArgument =
        Namespaced_IRI.parse _namespace_name "hasPossibleArgument" |> NamespacedName

    /// <summary>
    /// Establishes a relation between an ActionTrace and the KeyElementTrace that it can be possibly associated to.
    /// <see href="https://w3id.org/todo/tododom#isPossibleActionOf"></see></summary>
    let isPossibleActionOf =
        Namespaced_IRI.parse _namespace_name "isPossibleActionOf" |> NamespacedName

    /// <summary>
    /// Establishes the relationship between a Trace and the element it refers to.
    /// <see href="https://w3id.org/todo/tododom#isTraceOf"></see></summary>
    let isTraceOf = Namespaced_IRI.parse _namespace_name "isTraceOf" |> NamespacedName
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
    let isTypeOf = Namespaced_IRI.parse _namespace_name "isTypeOf" |> NamespacedName

    /// <summary>
    /// Target System Readable Information corresponding to elements of the class Argument.
    /// <see href="https://w3id.org/todo/tododom#ArgumentTSRI"></see></summary>
    let ArgumentTSRI =
        Namespaced_IRI.parse _namespace_name "ArgumentTSRI" |> NamespacedName

    /// <summary>
    /// Establishes the type of parameter of a TSRI.
    /// <see href="https://w3id.org/todo/tododom#ParameterType"></see></summary>
    let ParameterType =
        Namespaced_IRI.parse _namespace_name "ParameterType" |> NamespacedName

    /// <summary>
    /// Establishes the relation between an ArgumentTrace and its corresponding value (WorldElementTrace).
    /// <see href="https://w3id.org/todo/tododom#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// Establishes a relation between an ArgumentTrace and the KeyElementTrace that it can be possibly associated to.
    /// <see href="https://w3id.org/todo/tododom#isPossibleArgumentOf"></see></summary>
    let isPossibleArgumentOf =
        Namespaced_IRI.parse _namespace_name "isPossibleArgumentOf" |> NamespacedName

    /// <summary>
    /// Establishes a relation between an ArgumentTrace and the possible WorldElementTraces that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#hasPossibleValue"></see></summary>
    let hasPossibleValue =
        Namespaced_IRI.parse _namespace_name "hasPossibleValue" |> NamespacedName

    /// <summary>
    /// Target System Readable Information corresponding to elements of the class Action that require information in a Command format.
    /// <see href="https://w3id.org/todo/tododom#CommandTSRI"></see></summary>
    let CommandTSRI =
        Namespaced_IRI.parse _namespace_name "CommandTSRI" |> NamespacedName

    /// <summary>
    /// Establishes a relation between a TargetSystemReadableInformation element and its specific implementation in the target system (specification).
    /// <see href="https://w3id.org/todo/tododom#hasSpecification"></see></summary>
    let hasSpecification =
        Namespaced_IRI.parse _namespace_name "hasSpecification" |> NamespacedName

    /// <summary>
    /// Flag to determine if the KeyElementTrace is the one being processed by the Dialogue Manager.
    /// <see href="https://w3id.org/todo/tododom#current"></see></summary>
    let current = Namespaced_IRI.parse _namespace_name "current" |> NamespacedName
    /// <summary>
    /// Boolean to determine if an element has been asked by the DialogueManager.
    /// <see href="https://w3id.org/todo/tododom#asked"></see></summary>
    let asked = Namespaced_IRI.parse _namespace_name "asked" |> NamespacedName

    /// <summary>
    /// Establishes a relation between a KeyElementTrace and the possible ActionTraces that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#hasPossibleAction"></see></summary>
    let hasPossibleAction =
        Namespaced_IRI.parse _namespace_name "hasPossibleAction" |> NamespacedName

    /// <summary>
    /// Establishes the relation between a Lexical Unit and its corresponding FrameHead/WorldElement.
    /// <see href="https://w3id.org/todo/tododom#isLexicalUnitOf"></see></summary>
    let isLexicalUnitOf =
        Namespaced_IRI.parse _namespace_name "isLexicalUnitOf" |> NamespacedName

    /// <summary>
    /// Target System Readable Information corresponding to elements of the class WorldElement.
    /// <see href="https://w3id.org/todo/tododom#WorldElementTSRI"></see></summary>
    let WorldElementTSRI =
        Namespaced_IRI.parse _namespace_name "WorldElementTSRI" |> NamespacedName

    /// <summary>
    /// Target System Readable Information corresponding to elements of the class Action that point to Services.
    /// <see href="https://w3id.org/todo/tododom#ServiceTSRI"></see></summary>
    let ServiceTSRI =
        Namespaced_IRI.parse _namespace_name "ServiceTSRI" |> NamespacedName

    /// <summary>
    /// Sets the value of a TSRI to be input to the target system.
    /// <see href="https://w3id.org/todo/tododom#val"></see></summary>
    let val_ = Namespaced_IRI.parse _namespace_name "val" |> NamespacedName

    /// <summary>
    /// Establishes the relation between a WorldElementGroup and a member of said group.
    /// <see href="https://w3id.org/todo/tododom#hasGroupMember"></see></summary>
    let hasGroupMember =
        Namespaced_IRI.parse _namespace_name "hasGroupMember" |> NamespacedName

    /// <summary>
    /// Establishes a relation between a WorldElementTrace and the ArgumentTrace that it can be possibly associated to.
    /// <see href="https://w3id.org/todo/tododom#isPossibleValueOf"></see></summary>
    let isPossibleValueOf =
        Namespaced_IRI.parse _namespace_name "isPossibleValueOf" |> NamespacedName

    /// <summary>
    /// Establishes the relation between an Argument and the WorldElements that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#appliesToWorld"></see></summary>
    let appliesToWorld =
        Namespaced_IRI.parse _namespace_name "appliesToWorld" |> NamespacedName

    /// <summary>
    /// Establishes the relation between a WorldElement and the Argument(s) that it can be associated to.
    /// <see href="https://w3id.org/todo/tododom#isApplicableToArgument"></see></summary>
    let isApplicableToArgument =
        Namespaced_IRI.parse _namespace_name "isApplicableToArgument" |> NamespacedName

    /// <summary>
    /// Establishes a relation between a UserRequestTrace/UserResponseTrace and the Key Elements (KeyElementTrace) extracted from it.
    /// <see href="https://w3id.org/todo/tododom#hasKeyElement"></see></summary>
    let hasKeyElement =
        Namespaced_IRI.parse _namespace_name "hasKeyElement" |> NamespacedName

    /// <summary>
    /// Establishes a relation between a KeyElementTrace and the UserRequestTrace/UserResponseTrace it is extracted from.
    /// <see href="https://w3id.org/todo/tododom#isKeyElementOf"></see></summary>
    let isKeyElementOf =
        Namespaced_IRI.parse _namespace_name "isKeyElementOf" |> NamespacedName

    /// <summary>
    /// Establishes a relation between a Trace and the possible Traces that can be associated to it.
    /// <see href="https://w3id.org/todo/tododom#hasPossible"></see></summary>
    let hasPossible =
        Namespaced_IRI.parse _namespace_name "hasPossible" |> NamespacedName

    /// <summary>
    /// Establishes a relation between a Trace and the Trace that it can be possibly associated to.
    /// <see href="https://w3id.org/todo/tododom#isPossible"></see></summary>
    let isPossible = Namespaced_IRI.parse _namespace_name "isPossible" |> NamespacedName

    /// <summary>
    /// Establishes the relation between a TargetSystemReadableInfon and the Action/Argument/WorldElement it corresponds to.
    /// <see href="https://w3id.org/todo/tododom#isTargetSystemReadableInfoOf"></see></summary>
    let isTargetSystemReadableInfoOf =
        Namespaced_IRI.parse _namespace_name "isTargetSystemReadableInfoOf" |> NamespacedName

    /// <summary>
    /// Flag to determine the order of KeyElementTraces.
    /// <see href="https://w3id.org/todo/tododom#index"></see></summary>
    let index = Namespaced_IRI.parse _namespace_name "index" |> NamespacedName

    /// <summary>
    /// Stores the KeyElements that have been used to perform assignation in the Dialogue Manager.
    /// <see href="https://w3id.org/todo/tododom#keyElementsUsedToAssign"></see></summary>
    let keyElementsUsedToAssign =
        Namespaced_IRI.parse _namespace_name "keyElementsUsedToAssign" |> NamespacedName
