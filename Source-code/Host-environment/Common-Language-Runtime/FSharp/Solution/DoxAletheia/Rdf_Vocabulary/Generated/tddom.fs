namespace https.w3id.org.todo.tododom.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tddom =
    let _namespace_iri = Namespace_Iri tddom |> NamespaceIRI
    /// <summary>
    ///   <para>tddom:ActionTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Element that leaves a record of an Action obtained throughout the dialogue process.</para>
    /// labels<para>ActionTrace</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ActionTrace">https://w3id.org/todo/tododom#ActionTrace</seealso>
    let ActionTrace = Prefixed_Name(tddom, "ActionTrace") |> PrefixedName
    /// <summary>
    ///   <para>tddom:IntentTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Element that leaves a record of an Intent obtained throughout the dialogue process.</para>
    /// labels<para>IntentTrace</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#IntentTrace">https://w3id.org/todo/tododom#IntentTrace</seealso>
    let IntentTrace = Prefixed_Name(tddom, "IntentTrace") |> PrefixedName
    /// <summary>
    ///   <para>tddom:LexicalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Word(s) that cover the different variants of a FrameHead or a WorldElement.</para>
    /// labels<para>LexicalUnit</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#LexicalUnit">https://w3id.org/todo/tododom#LexicalUnit</seealso>
    let LexicalUnit = Prefixed_Name(tddom, "LexicalUnit") |> PrefixedName
    /// <summary>
    ///   <para>tddom:ArgumentTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Element that leaves a record of an Argument obtained throughout the dialogue process.</para>
    /// labels<para>ArgumentTrace</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ArgumentTrace">https://w3id.org/todo/tododom#ArgumentTrace</seealso>
    let ArgumentTrace = Prefixed_Name(tddom, "ArgumentTrace") |> PrefixedName
    /// <summary>
    ///   <para>tddom:InfoType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Establishes the TSRI type of a given Action/Parameter.</para>
    /// labels<para>InfoType</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#InfoType">https://w3id.org/todo/tododom#InfoType</seealso>
    let InfoType = Prefixed_Name(tddom, "InfoType") |> PrefixedName
    /// <summary>
    ///   <para>tddom:FrameTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Element that leaves a record of a Frame obtained throughout the dialogue process.</para>
    /// labels<para>FrameTrace</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#FrameTrace">https://w3id.org/todo/tododom#FrameTrace</seealso>
    let FrameTrace = Prefixed_Name(tddom, "FrameTrace") |> PrefixedName
    /// <summary>
    ///   <para>tddom:SkillTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Element that leaves a record of a Skill obtained throughout the dialogue process.</para>
    /// labels<para>SkillTrace</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#SkillTrace">https://w3id.org/todo/tododom#SkillTrace</seealso>
    let SkillTrace = Prefixed_Name(tddom, "SkillTrace") |> PrefixedName
    /// <summary>
    ///   <para>tddom:ActionTSRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Target System Readable Information corresponding to elements of the class Action.</para>
    /// labels<para>ActionTSRI</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ActionTSRI">https://w3id.org/todo/tododom#ActionTSRI</seealso>
    let ActionTSRI = Prefixed_Name(tddom, "ActionTSRI") |> PrefixedName
    /// <summary>
    ///   <para>tddom:Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Element that covers the information to execute an Action that is executable through a command (vs. as a Service).</para>
    /// labels<para>Command</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#Command">https://w3id.org/todo/tododom#Command</seealso>
    let Command = Prefixed_Name(tddom, "Command") |> PrefixedName

    /// <summary>
    ///   <para>tddom:TargetSystemReadableInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Plain language for whole action: Pick plastic container
    ///
    /// SystemReadableInfo for "pick": robAction.Pick
    /// SystemReadableInfo for "plastic container": containerID:235
    ///
    /// SystemReadableInfo for whole action: robAction.Pick(containerID:235)</para>
    ///   <para>Information that is sent to the system to perform an execution or as argument for an execution, in a format that is understandable to the target system.</para>
    /// labels<para>TargetSystemReadableInformation</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#TargetSystemReadableInformation">https://w3id.org/todo/tododom#TargetSystemReadableInformation</seealso>
    let TargetSystemReadableInformation =
        Prefixed_Name(tddom, "TargetSystemReadableInformation") |> PrefixedName

    /// <summary>
    ///   <para>tddom:WorldElementGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Agrupation of WorldElements of similar characteristics.</para>
    /// labels<para>WorldElementGroup</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#WorldElementGroup">https://w3id.org/todo/tododom#WorldElementGroup</seealso>
    let WorldElementGroup = Prefixed_Name(tddom, "WorldElementGroup") |> PrefixedName

    /// <summary>
    ///   <para>tddom:hasPossibleArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between a KeyElementTrace and the possible ArgumentTraces that can be associated to it.</para>
    /// labels<para>hasPossibleArgument</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasPossibleArgument">https://w3id.org/todo/tododom#hasPossibleArgument</seealso>
    let hasPossibleArgument =
        Prefixed_Name(tddom, "hasPossibleArgument") |> PrefixedName

    /// <summary>
    ///   <para>tddom:isTraceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relationship between a Trace and the element it refers to.</para>
    /// labels<para>isTraceOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isTraceOf">https://w3id.org/todo/tododom#isTraceOf</seealso>
    let isTraceOf = Prefixed_Name(tddom, "isTraceOf") |> PrefixedName
    /// <summary>
    ///   <para>tddom:ActionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ActionType</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ActionType">https://w3id.org/todo/tododom#ActionType</seealso>
    let ActionType = Prefixed_Name(tddom, "ActionType") |> PrefixedName
    /// <summary>
    ///   <para>tddom:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>(In a guide robot, with guiding and information functionalities; the TSRI of the destinations are coordinates and the TSRI of the elements to obtain information about are IDs)
    ///
    /// Destination_guideRobot hasTSRI ?x .
    /// ?x hasType coordinate .
    ///
    /// PieceInformation_guideRobot has TSRI ?y .
    /// ?y hasType ID .</para>
    ///   <para>Establishes a relation between an Action/Argument/WorldElement TSRI and its TSRI type.</para>
    /// labels<para>hasType</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasType">https://w3id.org/todo/tododom#hasType</seealso>
    let hasType = Prefixed_Name(tddom, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>tddom:isPossibleActionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an ActionTrace and the KeyElementTrace that it can be possibly associated to.</para>
    /// labels<para>isPossibleActionOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isPossibleActionOf">https://w3id.org/todo/tododom#isPossibleActionOf</seealso>
    let isPossibleActionOf = Prefixed_Name(tddom, "isPossibleActionOf") |> PrefixedName
    /// <summary>
    ///   <para>tddom:isTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Establishes a relation between a TSRI type and the Action/Argument/WorldElement TSRI with said TSRI type.</para>
    ///   <para>(In a guide robot, with guiding and information functionalities; the TSRI of the destinations are coordinates and the TSRI of the elements to obtain information about are IDs)
    ///
    /// Destination_guideRobot hasTSRI ?x .
    /// coordinate isTypeOf ?x .
    ///
    /// PieceInformation_guideRobot has TSRI ?y .
    /// ID isTypeOf ?y .</para>
    /// labels<para>isTypeOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isTypeOf">https://w3id.org/todo/tododom#isTypeOf</seealso>
    let isTypeOf = Prefixed_Name(tddom, "isTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>tddom:isPossibleArgumentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an ArgumentTrace and the KeyElementTrace that it can be possibly associated to.</para>
    /// labels<para>isPossibleArgumentOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isPossibleArgumentOf">https://w3id.org/todo/tododom#isPossibleArgumentOf</seealso>
    let isPossibleArgumentOf =
        Prefixed_Name(tddom, "isPossibleArgumentOf") |> PrefixedName

    /// <summary>
    ///   <para>tddom:hasPossibleValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an ArgumentTrace and the possible WorldElementTraces that can be associated to it.</para>
    /// labels<para>hasPossibleValue</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasPossibleValue">https://w3id.org/todo/tododom#hasPossibleValue</seealso>
    let hasPossibleValue = Prefixed_Name(tddom, "hasPossibleValue") |> PrefixedName
    /// <summary>
    ///   <para>tddom:CommandTSRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Target System Readable Information corresponding to elements of the class Action that require information in a Command format.</para>
    /// labels<para>CommandTSRI</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#CommandTSRI">https://w3id.org/todo/tododom#CommandTSRI</seealso>
    let CommandTSRI = Prefixed_Name(tddom, "CommandTSRI") |> PrefixedName
    /// <summary>
    ///   <para>tddom:hasSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between a TargetSystemReadableInformation element and its specific implementation in the target system (specification).</para>
    /// labels<para>hasSpecification</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasSpecification">https://w3id.org/todo/tododom#hasSpecification</seealso>
    let hasSpecification = Prefixed_Name(tddom, "hasSpecification") |> PrefixedName
    /// <summary>
    ///   <para>tddom:current</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Flag to determine if the KeyElementTrace is the one being processed by the Dialogue Manager.</para>
    /// labels<para>current</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#current">https://w3id.org/todo/tododom#current</seealso>
    let current = Prefixed_Name(tddom, "current") |> PrefixedName
    /// <summary>
    ///   <para>tddom:asked</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Boolean to determine if an element has been asked by the DialogueManager.</para>
    /// labels<para>asked</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#asked">https://w3id.org/todo/tododom#asked</seealso>
    let asked = Prefixed_Name(tddom, "asked") |> PrefixedName
    /// <summary>
    ///   <para>tddom:isLexicalUnitOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between a Lexical Unit and its corresponding FrameHead/WorldElement.</para>
    /// labels<para>isLexicalUnitOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isLexicalUnitOf">https://w3id.org/todo/tododom#isLexicalUnitOf</seealso>
    let isLexicalUnitOf = Prefixed_Name(tddom, "isLexicalUnitOf") |> PrefixedName
    /// <summary>
    ///   <para>tddom:WorldElementTSRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Target System Readable Information corresponding to elements of the class WorldElement.</para>
    /// labels<para>WorldElementTSRI</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#WorldElementTSRI">https://w3id.org/todo/tododom#WorldElementTSRI</seealso>
    let WorldElementTSRI = Prefixed_Name(tddom, "WorldElementTSRI") |> PrefixedName
    /// <summary>
    ///   <para>tddom:ServiceTSRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Target System Readable Information corresponding to elements of the class Action that point to Services.</para>
    /// labels<para>ServiceTSRI</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ServiceTSRI">https://w3id.org/todo/tododom#ServiceTSRI</seealso>
    let ServiceTSRI = Prefixed_Name(tddom, "ServiceTSRI") |> PrefixedName
    /// <summary>
    ///   <para>tddom:ArgumentTSRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Target System Readable Information corresponding to elements of the class Argument.</para>
    /// labels<para>ArgumentTSRI</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ArgumentTSRI">https://w3id.org/todo/tododom#ArgumentTSRI</seealso>
    let ArgumentTSRI = Prefixed_Name(tddom, "ArgumentTSRI") |> PrefixedName
    /// <summary>
    ///   <para>tddom:ParameterType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Establishes the type of parameter of a TSRI.</para>
    /// labels<para>ParameterType</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ParameterType">https://w3id.org/todo/tododom#ParameterType</seealso>
    let ParameterType = Prefixed_Name(tddom, "ParameterType") |> PrefixedName
    /// <summary>
    ///   <para>tddom:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between an ArgumentTrace and its corresponding value (WorldElementTrace).</para>
    /// labels<para>hasValue</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasValue">https://w3id.org/todo/tododom#hasValue</seealso>
    let hasValue = Prefixed_Name(tddom, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>tddom:hasPossibleAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between a KeyElementTrace and the possible ActionTraces that can be associated to it.</para>
    /// labels<para>hasPossibleAction</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasPossibleAction">https://w3id.org/todo/tododom#hasPossibleAction</seealso>
    let hasPossibleAction = Prefixed_Name(tddom, "hasPossibleAction") |> PrefixedName
    /// <summary>
    ///   <para>tddom:KeyElementTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>KeyElementTrace</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#KeyElementTrace">https://w3id.org/todo/tododom#KeyElementTrace</seealso>
    let KeyElementTrace = Prefixed_Name(tddom, "KeyElementTrace") |> PrefixedName
    /// <summary>
    ///   <para>tddom:WorldElementTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>WorldElementTrace</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#WorldElementTrace">https://w3id.org/todo/tododom#WorldElementTrace</seealso>
    let WorldElementTrace = Prefixed_Name(tddom, "WorldElementTrace") |> PrefixedName
    /// <summary>
    ///   <para>tddom:hasGroupMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between a WorldElementGroup and a member of said group.</para>
    /// labels<para>hasGroupMember</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasGroupMember">https://w3id.org/todo/tododom#hasGroupMember</seealso>
    let hasGroupMember = Prefixed_Name(tddom, "hasGroupMember") |> PrefixedName
    /// <summary>
    ///   <para>tddom:isKeyElementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between a KeyElementTrace and the UserRequestTrace/UserResponseTrace it is extracted from.</para>
    /// labels<para>isKeyElementOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isKeyElementOf">https://w3id.org/todo/tododom#isKeyElementOf</seealso>
    let isKeyElementOf = Prefixed_Name(tddom, "isKeyElementOf") |> PrefixedName
    /// <summary>
    ///   <para>tddom:isPossible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between a Trace and the Trace that it can be possibly associated to.</para>
    /// labels<para>isPossible</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isPossible">https://w3id.org/todo/tododom#isPossible</seealso>
    let isPossible = Prefixed_Name(tddom, "isPossible") |> PrefixedName
    /// <summary>
    ///   <para>tddom:val</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Sets the value of a TSRI to be input to the target system.</para>
    /// labels<para>val</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#val">https://w3id.org/todo/tododom#val</seealso>
    let val_ = Prefixed_Name(tddom, "val") |> PrefixedName
    /// <summary>
    ///   <para>tddom:isPossibleValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between a WorldElementTrace and the ArgumentTrace that it can be possibly associated to.</para>
    /// labels<para>isPossibleValueOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isPossibleValueOf">https://w3id.org/todo/tododom#isPossibleValueOf</seealso>
    let isPossibleValueOf = Prefixed_Name(tddom, "isPossibleValueOf") |> PrefixedName

    /// <summary>
    ///   <para>tddom:isApplicableToArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between a WorldElement and the Argument(s) that it can be associated to.</para>
    /// labels<para>isApplicableToArgument</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isApplicableToArgument">https://w3id.org/todo/tododom#isApplicableToArgument</seealso>
    let isApplicableToArgument =
        Prefixed_Name(tddom, "isApplicableToArgument") |> PrefixedName

    /// <summary>
    ///   <para>tddom:appliesToWorld</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between an Argument and the WorldElements that can be associated to it.</para>
    /// labels<para>appliesToWorld</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#appliesToWorld">https://w3id.org/todo/tododom#appliesToWorld</seealso>
    let appliesToWorld = Prefixed_Name(tddom, "appliesToWorld") |> PrefixedName
    /// <summary>
    ///   <para>tddom:hasKeyElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between a UserRequestTrace/UserResponseTrace and the Key Elements (KeyElementTrace) extracted from it.</para>
    /// labels<para>hasKeyElement</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasKeyElement">https://w3id.org/todo/tododom#hasKeyElement</seealso>
    let hasKeyElement = Prefixed_Name(tddom, "hasKeyElement") |> PrefixedName
    /// <summary>
    ///   <para>tddom:hasPossible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between a Trace and the possible Traces that can be associated to it.</para>
    /// labels<para>hasPossible</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasPossible">https://w3id.org/todo/tododom#hasPossible</seealso>
    let hasPossible = Prefixed_Name(tddom, "hasPossible") |> PrefixedName

    /// <summary>
    ///   <para>tddom:isTargetSystemReadableInfoOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between a TargetSystemReadableInfon and the Action/Argument/WorldElement it corresponds to.</para>
    /// labels<para>isTargetSystemReadableInfoOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isTargetSystemReadableInfoOf">https://w3id.org/todo/tododom#isTargetSystemReadableInfoOf</seealso>
    let isTargetSystemReadableInfoOf =
        Prefixed_Name(tddom, "isTargetSystemReadableInfoOf") |> PrefixedName

    /// <summary>
    ///   <para>tddom:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Flag to determine the order of KeyElementTraces.</para>
    /// labels<para>index</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#index">https://w3id.org/todo/tododom#index</seealso>
    let index = Prefixed_Name(tddom, "index") |> PrefixedName

    /// <summary>
    ///   <para>tddom:keyElementsUsedToAssign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Stores the KeyElements that have been used to perform assignation in the Dialogue Manager.</para>
    /// labels<para>keyElementsUsedToAssign</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#keyElementsUsedToAssign">https://w3id.org/todo/tododom#keyElementsUsedToAssign</seealso>
    let keyElementsUsedToAssign =
        Prefixed_Name(tddom, "keyElementsUsedToAssign") |> PrefixedName

    /// <summary>
    ///   <para>tddom:IDval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Unique identification value for individuals.</para>
    /// labels<para>IDval</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#IDval">https://w3id.org/todo/tododom#IDval</seealso>
    let IDval = Prefixed_Name(tddom, "IDval") |> PrefixedName
    /// <summary>
    ///   <para>tddom:isMemberOfGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between a WorldElement and a WorldElementGroup, which is a member of.</para>
    /// labels<para>isMemberOfGroup</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isMemberOfGroup">https://w3id.org/todo/tododom#isMemberOfGroup</seealso>
    let isMemberOfGroup = Prefixed_Name(tddom, "isMemberOfGroup") |> PrefixedName
    /// <summary>
    ///   <para>tddom:hasLexicalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between a FrameHead/WorldElement and one of its corresponding Lexical Units.</para>
    /// labels<para>hasLexicalUnit</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasLexicalUnit">https://w3id.org/todo/tododom#hasLexicalUnit</seealso>
    let hasLexicalUnit = Prefixed_Name(tddom, "hasLexicalUnit") |> PrefixedName

    /// <summary>
    ///   <para>tddom:hasTargetSystemReadableInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between an Action/Argument/WorldElement and its corresponding TargetSystemReadableInfo.</para>
    /// labels<para>hasTargetSystemReadableInfo</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasTargetSystemReadableInfo">https://w3id.org/todo/tododom#hasTargetSystemReadableInfo</seealso>
    let hasTargetSystemReadableInfo =
        Prefixed_Name(tddom, "hasTargetSystemReadableInfo") |> PrefixedName

    /// <summary>
    ///   <para>tddom:implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Sets specific implementation information for a Service.</para>
    /// labels<para>implementation</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#implementation">https://w3id.org/todo/tododom#implementation</seealso>
    let implementation = Prefixed_Name(tddom, "implementation") |> PrefixedName
    /// <summary>
    ///   <para>tddom:hasTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relationship between an element and its Trace.</para>
    /// labels<para>hasTrace</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasTrace">https://w3id.org/todo/tododom#hasTrace</seealso>
    let hasTrace = Prefixed_Name(tddom, "hasTrace") |> PrefixedName

    /// <summary>
    ///   <para>tddom:appliesToWorldElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between an Argument and a WorldElement that can be associated to it.</para>
    /// labels<para>appliesToWorldElement</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#appliesToWorldElement">https://w3id.org/todo/tododom#appliesToWorldElement</seealso>
    let appliesToWorldElement =
        Prefixed_Name(tddom, "appliesToWorldElement") |> PrefixedName

    /// <summary>
    ///   <para>tddom:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Sets the order in which each argument needs to be output to the target system.</para>
    /// labels<para>order</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#order">https://w3id.org/todo/tododom#order</seealso>
    let order = Prefixed_Name(tddom, "order") |> PrefixedName

    /// <summary>
    ///   <para>tddom:appliesToWorldElementGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between an Argument and a WorldElementGroup that can be associated to it.</para>
    /// labels<para>appliesToWorldElementGroup</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#appliesToWorldElementGroup">https://w3id.org/todo/tododom#appliesToWorldElementGroup</seealso>
    let appliesToWorldElementGroup =
        Prefixed_Name(tddom, "appliesToWorldElementGroup") |> PrefixedName
