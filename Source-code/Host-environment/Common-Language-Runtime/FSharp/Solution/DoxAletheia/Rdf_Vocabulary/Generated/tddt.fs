namespace https.w3id.org.todo.tododt.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tddt =
    let _namespace_iri = Namespace_Iri tddt |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:todo/tododt#ContentUserResponseTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the User Responses performed throughout the dialogue process. These responses provide specific information, as a response for a ContentRequest."</para>
    /// labels<para>"ContentUserResponseTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#ContentUserResponseTrace">https://w3id.org/todo/tododt#ContentUserResponseTrace</seealso>
    let ContentUserResponseTrace =
        Prefixed_Name(tddt, "ContentUserResponseTrace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododt#DialogueProcessTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Element that leaves a record of the dialogues performed throughout the dialogue process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DialogueProcessTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#DialogueProcessTrace">https://w3id.org/todo/tododt#DialogueProcessTrace</seealso>
    let DialogueProcessTrace =
        Prefixed_Name(tddt, "DialogueProcessTrace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododt#DialogueTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the dialogues performed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DialogueTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#DialogueTrace">https://w3id.org/todo/tododt#DialogueTrace</seealso>
    let DialogueTrace = Prefixed_Name(tddt, "DialogueTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#IDval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique identification value for individuals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IDval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#IDval">https://w3id.org/todo/tododt#IDval</seealso>
    let IDval = Prefixed_Name(tddt, "IDval") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#NoUserResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a negative polarity."</para>
    /// labels<para>"NoUserResponse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#NoUserResponse">https://w3id.org/todo/tododt#NoUserResponse</seealso>
    let NoUserResponse = Prefixed_Name(tddt, "NoUserResponse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododt#NullUserResponseTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Response that does not represent a value that can be classified as ContentResponse or YesNoResponse."</para>
    /// labels<para>"NullUserResponseTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#NullUserResponseTrace">https://w3id.org/todo/tododt#NullUserResponseTrace</seealso>
    let NullUserResponseTrace =
        Prefixed_Name(tddt, "NullUserResponseTrace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododt#SecondaryDialogueTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the secondary dialogues performed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SecondaryDialogueTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#SecondaryDialogueTrace">https://w3id.org/todo/tododt#SecondaryDialogueTrace</seealso>
    let SecondaryDialogueTrace =
        Prefixed_Name(tddt, "SecondaryDialogueTrace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododt#SystemRequestTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the SystemRequests performed throughout the dialogue process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SystemRequestTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#SystemRequestTrace">https://w3id.org/todo/tododt#SystemRequestTrace</seealso>
    let SystemRequestTrace = Prefixed_Name(tddt, "SystemRequestTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#SystemResponseTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the SystemResponses performed throughout the dialogue process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SystemResponseTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#SystemResponseTrace">https://w3id.org/todo/tododt#SystemResponseTrace</seealso>
    let SystemResponseTrace = Prefixed_Name(tddt, "SystemResponseTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#SystemStepTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the SystemSteps performed throughout the dialogue process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SystemStepTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#SystemStepTrace">https://w3id.org/todo/tododt#SystemStepTrace</seealso>
    let SystemStepTrace = Prefixed_Name(tddt, "SystemStepTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#UserRequestTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the User Requests performed throughout the dialogue process."</para>
    /// labels<para>"UserRequestTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#UserRequestTrace">https://w3id.org/todo/tododt#UserRequestTrace</seealso>
    let UserRequestTrace = Prefixed_Name(tddt, "UserRequestTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#UserResponseTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the User Responses performed throughout the dialogue process."</para>
    /// labels<para>"UserResponseTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#UserResponseTrace">https://w3id.org/todo/tododt#UserResponseTrace</seealso>
    let UserResponseTrace = Prefixed_Name(tddt, "UserResponseTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#UserStepTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the user steps (requests and responses) performed throughout the dialogue process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UserStepTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#UserStepTrace">https://w3id.org/todo/tododt#UserStepTrace</seealso>
    let UserStepTrace = Prefixed_Name(tddt, "UserStepTrace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododt#YesNoUserResponseTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a positive or negative polarity."</para>
    /// labels<para>"YesNoUserResponseTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#YesNoUserResponseTrace">https://w3id.org/todo/tododt#YesNoUserResponseTrace</seealso>
    let YesNoUserResponseTrace =
        Prefixed_Name(tddt, "YesNoUserResponseTrace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododt#YesUserResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a positive polarity."</para>
    /// labels<para>"YesUserResponse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#YesUserResponse">https://w3id.org/todo/tododt#YesUserResponse</seealso>
    let YesUserResponse = Prefixed_Name(tddt, "YesUserResponse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#currentValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"When asking the user for a specific information, the information currently asked to the user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"currentValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#currentValue">https://w3id.org/todo/tododt#currentValue</seealso>
    let currentValue = Prefixed_Name(tddt, "currentValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sets a timestamp to a DialogueTrace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#dateTime">https://w3id.org/todo/tododt#dateTime</seealso>
    let dateTime = Prefixed_Name(tddt, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#dialStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sets whether a Dialogue/SecondaryDialogue has finished (closed) or not (open)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dialStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#dialStatus">https://w3id.org/todo/tododt#dialStatus</seealso>
    let dialStatus = Prefixed_Name(tddt, "dialStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#dialogueStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used to control which step is performing the current Dialogue."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dialogueStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#dialogueStep">https://w3id.org/todo/tododt#dialogueStep</seealso>
    let dialogueStep = Prefixed_Name(tddt, "dialogueStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#finishDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sets a finish timestamp to a DialogueTrace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"finishDateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#finishDateTime">https://w3id.org/todo/tododt#finishDateTime</seealso>
    let finishDateTime = Prefixed_Name(tddt, "finishDateTime") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododt#hasSecondaryDialogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Establishes the SecondaryDialogue corresponding to a DialogueTrace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSecondaryDialogue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#hasSecondaryDialogue">https://w3id.org/todo/tododt#hasSecondaryDialogue</seealso>
    let hasSecondaryDialogue =
        Prefixed_Name(tddt, "hasSecondaryDialogue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododt#hasSystemRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the SystemRequest corresponding to a SecondaryDialogueTrace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSystemRequest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#hasSystemRequest">https://w3id.org/todo/tododt#hasSystemRequest</seealso>
    let hasSystemRequest = Prefixed_Name(tddt, "hasSystemRequest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#hasSystemResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the SystemResponse corresponding to a SecondaryDialogueTrace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSystemResponse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#hasSystemResponse">https://w3id.org/todo/tododt#hasSystemResponse</seealso>
    let hasSystemResponse = Prefixed_Name(tddt, "hasSystemResponse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#hasUserRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the UserRequest corresponding to a DialogueTrace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasUserRequest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#hasUserRequest">https://w3id.org/todo/tododt#hasUserRequest</seealso>
    let hasUserRequest = Prefixed_Name(tddt, "hasUserRequest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#hasUserResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the UserResponse corresponding to a SecondaryDialogueTrace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasUserResponse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#hasUserResponse">https://w3id.org/todo/tododt#hasUserResponse</seealso>
    let hasUserResponse = Prefixed_Name(tddt, "hasUserResponse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#initDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sets a start timestamp to a DialogueTrace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"initDateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#initDateTime">https://w3id.org/todo/tododt#initDateTime</seealso>
    let initDateTime = Prefixed_Name(tddt, "initDateTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#possibleValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"When asking the user for a specific information, the possible values of that information to be asked to the user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"possibleValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#possibleValue">https://w3id.org/todo/tododt#possibleValue</seealso>
    let possibleValue = Prefixed_Name(tddt, "possibleValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododt#text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"String that corresponds to a transcribed command by an user or the fully constructed outputSentence directed to the user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododt#text">https://w3id.org/todo/tododt#text</seealso>
    let text = Prefixed_Name(tddt, "text") |> PrefixedName
