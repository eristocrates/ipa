#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tddom =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododom#" "tddom"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ActionTSRI^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Target System Readable Information corresponding to elements of the class Action.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#ActionTSRI">tddom:ActionTSRI</a>
    /// </summary>
    let ActionTSRI = _prefixId.prefix "ActionTSRI"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:label : ActionTrace^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of an Action obtained throughout the dialogue process.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#ActionTrace">tddom:ActionTrace</a>
    /// </summary>
    let ActionTrace = _prefixId.prefix "ActionTrace"
    /// <summary>
    ///   <para>skos:example : Establishes the TSRI type of an Action.^^xsd:stringskos:example : Action: obtain_information -&gt; it is directed towards API REST service
    /// The TSRI for obtain_information has an ActionType "service".^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ActionType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#ActionType">tddom:ActionType</a>
    /// </summary>
    let ActionType = _prefixId.prefix "ActionType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentTSRI^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Target System Readable Information corresponding to elements of the class Argument.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#ArgumentTSRI">tddom:ArgumentTSRI</a>
    /// </summary>
    let ArgumentTSRI = _prefixId.prefix "ArgumentTSRI"
    /// <summary>
    ///   <para>rdfs:label : ArgumentTrace^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of an Argument obtained throughout the dialogue process.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#ArgumentTrace">tddom:ArgumentTrace</a>
    /// </summary>
    let ArgumentTrace = _prefixId.prefix "ArgumentTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Command^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that covers the information to execute an Action that is executable through a command (vs. as a Service).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#Command">tddom:Command</a>
    /// </summary>
    let Command = _prefixId.prefix "Command"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : CommandTSRI^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Target System Readable Information corresponding to elements of the class Action that require information in a Command format.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#CommandTSRI">tddom:CommandTSRI</a>
    /// </summary>
    let CommandTSRI = _prefixId.prefix "CommandTSRI"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : FrameTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of a Frame obtained throughout the dialogue process.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#FrameTrace">tddom:FrameTrace</a>
    /// </summary>
    let FrameTrace = _prefixId.prefix "FrameTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : IDval^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Unique identification value for individuals.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#IDval">tddom:IDval</a>
    /// </summary>
    let IDval = _prefixId.prefix "IDval"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : InfoType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the TSRI type of a given Action/Parameter.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#InfoType">tddom:InfoType</a>
    /// </summary>
    let InfoType = _prefixId.prefix "InfoType"
    /// <summary>
    ///   <para>rdfs:label : IntentTrace^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of an Intent obtained throughout the dialogue process.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#IntentTrace">tddom:IntentTrace</a>
    /// </summary>
    let IntentTrace = _prefixId.prefix "IntentTrace"
    /// <summary>
    ///   <para>rdfs:label : KeyElementTrace^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:stringrdfs:isDefinedBy : Element that leaves a record of a key element obtained from a user input.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#KeyElementTrace">tddom:KeyElementTrace</a>
    /// </summary>
    let KeyElementTrace = _prefixId.prefix "KeyElementTrace"
    /// <summary>
    ///   <para>skos:example : FrameHead: go
    /// LexUnits (in Spanish): ir.V, desplazarse.V^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : LexicalUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Word(s) that cover the different variants of a FrameHead or a WorldElement.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#LexicalUnit">tddom:LexicalUnit</a>
    /// </summary>
    let LexicalUnit = _prefixId.prefix "LexicalUnit"
    /// <summary>
    ///   <para>skos:example : "baño" hasTSRI "coords_baño"
    /// "baño" hasTSRI "ID_baño"
    ///
    /// "coords_baño" is of ParameterType "coordinate"
    /// "ID_baño" is of ParameterType "ID"^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ParameterType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the type of parameter of a TSRI.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#ParameterType">tddom:ParameterType</a>
    /// </summary>
    let ParameterType = _prefixId.prefix "ParameterType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ServiceTSRI^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Target System Readable Information corresponding to elements of the class Action that point to Services.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#ServiceTSRI">tddom:ServiceTSRI</a>
    /// </summary>
    let ServiceTSRI = _prefixId.prefix "ServiceTSRI"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SkillTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of a Skill obtained throughout the dialogue process.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#SkillTrace">tddom:SkillTrace</a>
    /// </summary>
    let SkillTrace = _prefixId.prefix "SkillTrace"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TargetSystemReadableInformation</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Plain language for whole action: Pick plastic container
    ///
    /// SystemReadableInfo for "pick": robAction.Pick
    /// SystemReadableInfo for "plastic container": containerID:235
    ///
    /// SystemReadableInfo for whole action: robAction.Pick(containerID:235)rdfs:comment : Information that is sent to the system to perform an execution or as argument for an execution, in a format that is understandable to the target system.</para>
    ///   <a href="https://w3id.org/todo/tododom#TargetSystemReadableInformation">tddom:TargetSystemReadableInformation</a>
    /// </summary>
    let TargetSystemReadableInformation =
        _prefixId.prefix "TargetSystemReadableInformation"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : WorldElementGroup^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Agrupation of WorldElements of similar characteristics.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#WorldElementGroup">tddom:WorldElementGroup</a>
    /// </summary>
    let WorldElementGroup = _prefixId.prefix "WorldElementGroup"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : WorldElementTSRI^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Target System Readable Information corresponding to elements of the class WorldElement.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#WorldElementTSRI">tddom:WorldElementTSRI</a>
    /// </summary>
    let WorldElementTSRI = _prefixId.prefix "WorldElementTSRI"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : WorldElementTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:stringrdfs:isDefinedBy : Element that leaves a record of a world element.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#WorldElementTrace">tddom:WorldElementTrace</a>
    /// </summary>
    let WorldElementTrace = _prefixId.prefix "WorldElementTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : appliesToWorld^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between an Argument and the WorldElements that can be associated to it.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#appliesToWorld">tddom:appliesToWorld</a>
    /// </summary>
    let appliesToWorld = _prefixId.prefix "appliesToWorld"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : appliesToWorldElement^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between an Argument and a WorldElement that can be associated to it.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#appliesToWorldElement">tddom:appliesToWorldElement</a>
    /// </summary>
    let appliesToWorldElement = _prefixId.prefix "appliesToWorldElement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : appliesToWorldElementGroup^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between an Argument and a WorldElementGroup that can be associated to it.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#appliesToWorldElementGroup">tddom:appliesToWorldElementGroup</a>
    /// </summary>
    let appliesToWorldElementGroup = _prefixId.prefix "appliesToWorldElementGroup"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : asked^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Boolean to determine if an element has been asked by the DialogueManager.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#asked">tddom:asked</a>
    /// </summary>
    let asked = _prefixId.prefix "asked"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : current^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Flag to determine if the KeyElementTrace is the one being processed by the Dialogue Manager.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#current">tddom:current</a>
    /// </summary>
    let current = _prefixId.prefix "current"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasGroupMember^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between a WorldElementGroup and a member of said group.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasGroupMember">tddom:hasGroupMember</a>
    /// </summary>
    let hasGroupMember = _prefixId.prefix "hasGroupMember"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasKeyElement^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a UserRequestTrace/UserResponseTrace and the Key Elements (KeyElementTrace) extracted from it.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasKeyElement">tddom:hasKeyElement</a>
    /// </summary>
    let hasKeyElement = _prefixId.prefix "hasKeyElement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasLexicalUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between a FrameHead/WorldElement and one of its corresponding Lexical Units.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasLexicalUnit">tddom:hasLexicalUnit</a>
    /// </summary>
    let hasLexicalUnit = _prefixId.prefix "hasLexicalUnit"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPossible^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a Trace and the possible Traces that can be associated to it.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasPossible">tddom:hasPossible</a>
    /// </summary>
    let hasPossible = _prefixId.prefix "hasPossible"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPossibleAction^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a KeyElementTrace and the possible ActionTraces that can be associated to it.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasPossibleAction">tddom:hasPossibleAction</a>
    /// </summary>
    let hasPossibleAction = _prefixId.prefix "hasPossibleAction"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPossibleArgument^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a KeyElementTrace and the possible ArgumentTraces that can be associated to it.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasPossibleArgument">tddom:hasPossibleArgument</a>
    /// </summary>
    let hasPossibleArgument = _prefixId.prefix "hasPossibleArgument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasPossibleValue^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an ArgumentTrace and the possible WorldElementTraces that can be associated to it.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasPossibleValue">tddom:hasPossibleValue</a>
    /// </summary>
    let hasPossibleValue = _prefixId.prefix "hasPossibleValue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasSpecification^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a TargetSystemReadableInformation element and its specific implementation in the target system (specification).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasSpecification">tddom:hasSpecification</a>
    /// </summary>
    let hasSpecification = _prefixId.prefix "hasSpecification"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTargetSystemReadableInfo^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between an Action/Argument/WorldElement and its corresponding TargetSystemReadableInfo.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasTargetSystemReadableInfo">tddom:hasTargetSystemReadableInfo</a>
    /// </summary>
    let hasTargetSystemReadableInfo = _prefixId.prefix "hasTargetSystemReadableInfo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relationship between an element and its Trace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasTrace">tddom:hasTrace</a>
    /// </summary>
    let hasTrace = _prefixId.prefix "hasTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an Action/Argument/WorldElement TSRI and its TSRI type.^^xsd:stringrdfs:comment : (In a guide robot, with guiding and information functionalities; the TSRI of the destinations are coordinates and the TSRI of the elements to obtain information about are IDs)
    ///
    /// Destination_guideRobot hasTSRI ?x .
    /// ?x hasType coordinate .
    ///
    /// PieceInformation_guideRobot has TSRI ?y .
    /// ?y hasType ID .^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasType">tddom:hasType</a>
    /// </summary>
    let hasType = _prefixId.prefix "hasType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasValue^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between an ArgumentTrace and its corresponding value (WorldElementTrace).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#hasValue">tddom:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : implementation^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Sets specific implementation information for a Service.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#implementation">tddom:implementation</a>
    /// </summary>
    let implementation = _prefixId.prefix "implementation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : index^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Flag to determine the order of KeyElementTraces.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#index">tddom:index</a>
    /// </summary>
    let index = _prefixId.prefix "index"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isApplicableToArgument^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between a WorldElement and the Argument(s) that it can be associated to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isApplicableToArgument">tddom:isApplicableToArgument</a>
    /// </summary>
    let isApplicableToArgument = _prefixId.prefix "isApplicableToArgument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isKeyElementOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a KeyElementTrace and the UserRequestTrace/UserResponseTrace it is extracted from.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isKeyElementOf">tddom:isKeyElementOf</a>
    /// </summary>
    let isKeyElementOf = _prefixId.prefix "isKeyElementOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isLexicalUnitOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between a Lexical Unit and its corresponding FrameHead/WorldElement.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isLexicalUnitOf">tddom:isLexicalUnitOf</a>
    /// </summary>
    let isLexicalUnitOf = _prefixId.prefix "isLexicalUnitOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isMemberOfGroup^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between a WorldElement and a WorldElementGroup, which is a member of.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isMemberOfGroup">tddom:isMemberOfGroup</a>
    /// </summary>
    let isMemberOfGroup = _prefixId.prefix "isMemberOfGroup"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isPossible^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a Trace and the Trace that it can be possibly associated to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isPossible">tddom:isPossible</a>
    /// </summary>
    let isPossible = _prefixId.prefix "isPossible"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isPossibleActionOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an ActionTrace and the KeyElementTrace that it can be possibly associated to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isPossibleActionOf">tddom:isPossibleActionOf</a>
    /// </summary>
    let isPossibleActionOf = _prefixId.prefix "isPossibleActionOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isPossibleArgumentOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an ArgumentTrace and the KeyElementTrace that it can be possibly associated to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isPossibleArgumentOf">tddom:isPossibleArgumentOf</a>
    /// </summary>
    let isPossibleArgumentOf = _prefixId.prefix "isPossibleArgumentOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isPossibleValueOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a WorldElementTrace and the ArgumentTrace that it can be possibly associated to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isPossibleValueOf">tddom:isPossibleValueOf</a>
    /// </summary>
    let isPossibleValueOf = _prefixId.prefix "isPossibleValueOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isTargetSystemReadableInfoOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between a TargetSystemReadableInfon and the Action/Argument/WorldElement it corresponds to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isTargetSystemReadableInfoOf">tddom:isTargetSystemReadableInfoOf</a>
    /// </summary>
    let isTargetSystemReadableInfoOf = _prefixId.prefix "isTargetSystemReadableInfoOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isTraceOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relationship between a Trace and the element it refers to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isTraceOf">tddom:isTraceOf</a>
    /// </summary>
    let isTraceOf = _prefixId.prefix "isTraceOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isTypeOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a TSRI type and the Action/Argument/WorldElement TSRI with said TSRI type.^^xsd:stringrdfs:comment : (In a guide robot, with guiding and information functionalities; the TSRI of the destinations are coordinates and the TSRI of the elements to obtain information about are IDs)
    ///
    /// Destination_guideRobot hasTSRI ?x .
    /// coordinate isTypeOf ?x .
    ///
    /// PieceInformation_guideRobot has TSRI ?y .
    /// ID isTypeOf ?y .^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#isTypeOf">tddom:isTypeOf</a>
    /// </summary>
    let isTypeOf = _prefixId.prefix "isTypeOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : keyElementsUsedToAssign^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Stores the KeyElements that have been used to perform assignation in the Dialogue Manager.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#keyElementsUsedToAssign">tddom:keyElementsUsedToAssign</a>
    /// </summary>
    let keyElementsUsedToAssign = _prefixId.prefix "keyElementsUsedToAssign"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : order^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Sets the order in which each argument needs to be output to the target system.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#order">tddom:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : val^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Sets the value of a TSRI to be input to the target system.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododom#val">tddom:val</a>
    /// </summary>
    let val_ = _prefixId.prefix "val"
