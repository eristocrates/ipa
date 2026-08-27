namespace https.w3id.org.todo.tododom.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tddom =
    let _namespace_iri = Namespace_Iri tddom |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:todo/tododom#ActionTSRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Target System Readable Information corresponding to elements of the class Action."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ActionTSRI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ActionTSRI">https://w3id.org/todo/tododom#ActionTSRI</seealso>
    let ActionTSRI = Prefixed_Name(tddom, "ActionTSRI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#ActionTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of an Action obtained throughout the dialogue process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ActionTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ActionTrace">https://w3id.org/todo/tododom#ActionTrace</seealso>
    let ActionTrace = Prefixed_Name(tddom, "ActionTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#ActionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ActionType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ActionType">https://w3id.org/todo/tododom#ActionType</seealso>
    let ActionType = Prefixed_Name(tddom, "ActionType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#ArgumentTSRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Target System Readable Information corresponding to elements of the class Argument."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ArgumentTSRI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ArgumentTSRI">https://w3id.org/todo/tododom#ArgumentTSRI</seealso>
    let ArgumentTSRI = Prefixed_Name(tddom, "ArgumentTSRI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#ArgumentTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of an Argument obtained throughout the dialogue process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ArgumentTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ArgumentTrace">https://w3id.org/todo/tododom#ArgumentTrace</seealso>
    let ArgumentTrace = Prefixed_Name(tddom, "ArgumentTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that covers the information to execute an Action that is executable through a command (vs. as a Service)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Command"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#Command">https://w3id.org/todo/tododom#Command</seealso>
    let Command = Prefixed_Name(tddom, "Command") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#CommandTSRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Target System Readable Information corresponding to elements of the class Action that require information in a Command format."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CommandTSRI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#CommandTSRI">https://w3id.org/todo/tododom#CommandTSRI</seealso>
    let CommandTSRI = Prefixed_Name(tddom, "CommandTSRI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#FrameTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of a Frame obtained throughout the dialogue process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FrameTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#FrameTrace">https://w3id.org/todo/tododom#FrameTrace</seealso>
    let FrameTrace = Prefixed_Name(tddom, "FrameTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#IDval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique identification value for individuals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IDval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#IDval">https://w3id.org/todo/tododom#IDval</seealso>
    let IDval = Prefixed_Name(tddom, "IDval") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#InfoType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Establishes the TSRI type of a given Action/Parameter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InfoType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#InfoType">https://w3id.org/todo/tododom#InfoType</seealso>
    let InfoType = Prefixed_Name(tddom, "InfoType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#IntentTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of an Intent obtained throughout the dialogue process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IntentTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#IntentTrace">https://w3id.org/todo/tododom#IntentTrace</seealso>
    let IntentTrace = Prefixed_Name(tddom, "IntentTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#KeyElementTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"KeyElementTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#KeyElementTrace">https://w3id.org/todo/tododom#KeyElementTrace</seealso>
    let KeyElementTrace = Prefixed_Name(tddom, "KeyElementTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#LexicalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Word(s) that cover the different variants of a FrameHead or a WorldElement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LexicalUnit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#LexicalUnit">https://w3id.org/todo/tododom#LexicalUnit</seealso>
    let LexicalUnit = Prefixed_Name(tddom, "LexicalUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#ParameterType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Establishes the type of parameter of a TSRI."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ParameterType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ParameterType">https://w3id.org/todo/tododom#ParameterType</seealso>
    let ParameterType = Prefixed_Name(tddom, "ParameterType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#ServiceTSRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Target System Readable Information corresponding to elements of the class Action that point to Services."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceTSRI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#ServiceTSRI">https://w3id.org/todo/tododom#ServiceTSRI</seealso>
    let ServiceTSRI = Prefixed_Name(tddom, "ServiceTSRI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#SkillTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of a Skill obtained throughout the dialogue process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SkillTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#SkillTrace">https://w3id.org/todo/tododom#SkillTrace</seealso>
    let SkillTrace = Prefixed_Name(tddom, "SkillTrace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#TargetSystemReadableInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Plain language for whole action: Pick plastic container
    ///
    /// SystemReadableInfo for "pick": robAction.Pick
    /// SystemReadableInfo for "plastic container": containerID:235
    ///
    /// SystemReadableInfo for whole action: robAction.Pick(containerID:235)"</para>
    ///   <para>"Information that is sent to the system to perform an execution or as argument for an execution, in a format that is understandable to the target system."</para>
    /// labels<para>"TargetSystemReadableInformation"</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#TargetSystemReadableInformation">https://w3id.org/todo/tododom#TargetSystemReadableInformation</seealso>
    let TargetSystemReadableInformation =
        Prefixed_Name(tddom, "TargetSystemReadableInformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#WorldElementGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Agrupation of WorldElements of similar characteristics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WorldElementGroup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#WorldElementGroup">https://w3id.org/todo/tododom#WorldElementGroup</seealso>
    let WorldElementGroup = Prefixed_Name(tddom, "WorldElementGroup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#WorldElementTSRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Target System Readable Information corresponding to elements of the class WorldElement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WorldElementTSRI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#WorldElementTSRI">https://w3id.org/todo/tododom#WorldElementTSRI</seealso>
    let WorldElementTSRI = Prefixed_Name(tddom, "WorldElementTSRI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#WorldElementTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WorldElementTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#WorldElementTrace">https://w3id.org/todo/tododom#WorldElementTrace</seealso>
    let WorldElementTrace = Prefixed_Name(tddom, "WorldElementTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#appliesToWorld</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between an Argument and the WorldElements that can be associated to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"appliesToWorld"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#appliesToWorld">https://w3id.org/todo/tododom#appliesToWorld</seealso>
    let appliesToWorld = Prefixed_Name(tddom, "appliesToWorld") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#appliesToWorldElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between an Argument and a WorldElement that can be associated to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"appliesToWorldElement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#appliesToWorldElement">https://w3id.org/todo/tododom#appliesToWorldElement</seealso>
    let appliesToWorldElement =
        Prefixed_Name(tddom, "appliesToWorldElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#appliesToWorldElementGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between an Argument and a WorldElementGroup that can be associated to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"appliesToWorldElementGroup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#appliesToWorldElementGroup">https://w3id.org/todo/tododom#appliesToWorldElementGroup</seealso>
    let appliesToWorldElementGroup =
        Prefixed_Name(tddom, "appliesToWorldElementGroup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#asked</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Boolean to determine if an element has been asked by the DialogueManager."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"asked"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#asked">https://w3id.org/todo/tododom#asked</seealso>
    let asked = Prefixed_Name(tddom, "asked") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#current</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Flag to determine if the KeyElementTrace is the one being processed by the Dialogue Manager."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"current"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#current">https://w3id.org/todo/tododom#current</seealso>
    let current = Prefixed_Name(tddom, "current") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#hasGroupMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between a WorldElementGroup and a member of said group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasGroupMember"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasGroupMember">https://w3id.org/todo/tododom#hasGroupMember</seealso>
    let hasGroupMember = Prefixed_Name(tddom, "hasGroupMember") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#hasKeyElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a UserRequestTrace/UserResponseTrace and the Key Elements (KeyElementTrace) extracted from it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasKeyElement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasKeyElement">https://w3id.org/todo/tododom#hasKeyElement</seealso>
    let hasKeyElement = Prefixed_Name(tddom, "hasKeyElement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#hasLexicalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between a FrameHead/WorldElement and one of its corresponding Lexical Units."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasLexicalUnit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasLexicalUnit">https://w3id.org/todo/tododom#hasLexicalUnit</seealso>
    let hasLexicalUnit = Prefixed_Name(tddom, "hasLexicalUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#hasPossible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a Trace and the possible Traces that can be associated to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPossible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasPossible">https://w3id.org/todo/tododom#hasPossible</seealso>
    let hasPossible = Prefixed_Name(tddom, "hasPossible") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#hasPossibleAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a KeyElementTrace and the possible ActionTraces that can be associated to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPossibleAction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasPossibleAction">https://w3id.org/todo/tododom#hasPossibleAction</seealso>
    let hasPossibleAction = Prefixed_Name(tddom, "hasPossibleAction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#hasPossibleArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a KeyElementTrace and the possible ArgumentTraces that can be associated to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPossibleArgument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasPossibleArgument">https://w3id.org/todo/tododom#hasPossibleArgument</seealso>
    let hasPossibleArgument =
        Prefixed_Name(tddom, "hasPossibleArgument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#hasPossibleValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between an ArgumentTrace and the possible WorldElementTraces that can be associated to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPossibleValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasPossibleValue">https://w3id.org/todo/tododom#hasPossibleValue</seealso>
    let hasPossibleValue = Prefixed_Name(tddom, "hasPossibleValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#hasSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a TargetSystemReadableInformation element and its specific implementation in the target system (specification)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSpecification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasSpecification">https://w3id.org/todo/tododom#hasSpecification</seealso>
    let hasSpecification = Prefixed_Name(tddom, "hasSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#hasTargetSystemReadableInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between an Action/Argument/WorldElement and its corresponding TargetSystemReadableInfo."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasTargetSystemReadableInfo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasTargetSystemReadableInfo">https://w3id.org/todo/tododom#hasTargetSystemReadableInfo</seealso>
    let hasTargetSystemReadableInfo =
        Prefixed_Name(tddom, "hasTargetSystemReadableInfo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#hasTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relationship between an element and its Trace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasTrace">https://w3id.org/todo/tododom#hasTrace</seealso>
    let hasTrace = Prefixed_Name(tddom, "hasTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"(In a guide robot, with guiding and information functionalities; the TSRI of the destinations are coordinates and the TSRI of the elements to obtain information about are IDs)
    ///
    /// Destination_guideRobot hasTSRI ?x .
    /// ?x hasType coordinate .
    ///
    /// PieceInformation_guideRobot has TSRI ?y .
    /// ?y hasType ID ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Establishes a relation between an Action/Argument/WorldElement TSRI and its TSRI type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasType">https://w3id.org/todo/tododom#hasType</seealso>
    let hasType = Prefixed_Name(tddom, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between an ArgumentTrace and its corresponding value (WorldElementTrace)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#hasValue">https://w3id.org/todo/tododom#hasValue</seealso>
    let hasValue = Prefixed_Name(tddom, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sets specific implementation information for a Service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implementation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#implementation">https://w3id.org/todo/tododom#implementation</seealso>
    let implementation = Prefixed_Name(tddom, "implementation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Flag to determine the order of KeyElementTraces."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#index">https://w3id.org/todo/tododom#index</seealso>
    let index = Prefixed_Name(tddom, "index") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#isApplicableToArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between a WorldElement and the Argument(s) that it can be associated to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isApplicableToArgument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isApplicableToArgument">https://w3id.org/todo/tododom#isApplicableToArgument</seealso>
    let isApplicableToArgument =
        Prefixed_Name(tddom, "isApplicableToArgument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#isKeyElementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a KeyElementTrace and the UserRequestTrace/UserResponseTrace it is extracted from."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isKeyElementOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isKeyElementOf">https://w3id.org/todo/tododom#isKeyElementOf</seealso>
    let isKeyElementOf = Prefixed_Name(tddom, "isKeyElementOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#isLexicalUnitOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between a Lexical Unit and its corresponding FrameHead/WorldElement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isLexicalUnitOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isLexicalUnitOf">https://w3id.org/todo/tododom#isLexicalUnitOf</seealso>
    let isLexicalUnitOf = Prefixed_Name(tddom, "isLexicalUnitOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#isMemberOfGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between a WorldElement and a WorldElementGroup, which is a member of."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isMemberOfGroup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isMemberOfGroup">https://w3id.org/todo/tododom#isMemberOfGroup</seealso>
    let isMemberOfGroup = Prefixed_Name(tddom, "isMemberOfGroup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#isPossible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a Trace and the Trace that it can be possibly associated to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isPossible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isPossible">https://w3id.org/todo/tododom#isPossible</seealso>
    let isPossible = Prefixed_Name(tddom, "isPossible") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#isPossibleActionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between an ActionTrace and the KeyElementTrace that it can be possibly associated to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isPossibleActionOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isPossibleActionOf">https://w3id.org/todo/tododom#isPossibleActionOf</seealso>
    let isPossibleActionOf = Prefixed_Name(tddom, "isPossibleActionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#isPossibleArgumentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between an ArgumentTrace and the KeyElementTrace that it can be possibly associated to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isPossibleArgumentOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isPossibleArgumentOf">https://w3id.org/todo/tododom#isPossibleArgumentOf</seealso>
    let isPossibleArgumentOf =
        Prefixed_Name(tddom, "isPossibleArgumentOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#isPossibleValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a WorldElementTrace and the ArgumentTrace that it can be possibly associated to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isPossibleValueOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isPossibleValueOf">https://w3id.org/todo/tododom#isPossibleValueOf</seealso>
    let isPossibleValueOf = Prefixed_Name(tddom, "isPossibleValueOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#isTargetSystemReadableInfoOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between a TargetSystemReadableInfon and the Action/Argument/WorldElement it corresponds to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isTargetSystemReadableInfoOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isTargetSystemReadableInfoOf">https://w3id.org/todo/tododom#isTargetSystemReadableInfoOf</seealso>
    let isTargetSystemReadableInfoOf =
        Prefixed_Name(tddom, "isTargetSystemReadableInfoOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#isTraceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relationship between a Trace and the element it refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isTraceOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isTraceOf">https://w3id.org/todo/tododom#isTraceOf</seealso>
    let isTraceOf = Prefixed_Name(tddom, "isTraceOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#isTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"(In a guide robot, with guiding and information functionalities; the TSRI of the destinations are coordinates and the TSRI of the elements to obtain information about are IDs)
    ///
    /// Destination_guideRobot hasTSRI ?x .
    /// coordinate isTypeOf ?x .
    ///
    /// PieceInformation_guideRobot has TSRI ?y .
    /// ID isTypeOf ?y ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Establishes a relation between a TSRI type and the Action/Argument/WorldElement TSRI with said TSRI type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isTypeOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#isTypeOf">https://w3id.org/todo/tododom#isTypeOf</seealso>
    let isTypeOf = Prefixed_Name(tddom, "isTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#keyElementsUsedToAssign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Stores the KeyElements that have been used to perform assignation in the Dialogue Manager."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"keyElementsUsedToAssign"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#keyElementsUsedToAssign">https://w3id.org/todo/tododom#keyElementsUsedToAssign</seealso>
    let keyElementsUsedToAssign =
        Prefixed_Name(tddom, "keyElementsUsedToAssign") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododom#order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sets the order in which each argument needs to be output to the target system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"order"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#order">https://w3id.org/todo/tododom#order</seealso>
    let order = Prefixed_Name(tddom, "order") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododom#val</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sets the value of a TSRI to be input to the target system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"val"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododom#val">https://w3id.org/todo/tododom#val</seealso>
    let val_ = Prefixed_Name(tddom, "val") |> PrefixedName
