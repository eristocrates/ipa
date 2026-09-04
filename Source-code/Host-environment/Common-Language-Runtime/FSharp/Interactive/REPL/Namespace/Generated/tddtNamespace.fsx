#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tddt =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododt#" "tddt"
    /// <summary>
    ///   <para>skos:example : Content User Response: The error code is 412.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ContentUserResponseTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the User Responses performed throughout the dialogue process. These responses provide specific information, as a response for a ContentRequest.</para>
    ///   <a href="https://w3id.org/todo/tododt#ContentUserResponseTrace">tddt:ContentUserResponseTrace</a>
    /// </summary>
    let ContentUserResponseTrace = _prefixId.prefix "ContentUserResponseTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the dialogues performed throughout the dialogue process.^^xsd:string</para>
    ///   <para>rdfs:label : DialogueProcessTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#DialogueProcessTrace">tddt:DialogueProcessTrace</a>
    /// </summary>
    let DialogueProcessTrace = _prefixId.prefix "DialogueProcessTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : DialogueTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the dialogues performed.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#DialogueTrace">tddt:DialogueTrace</a>
    /// </summary>
    let DialogueTrace = _prefixId.prefix "DialogueTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : IDval^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododom#^^xsd:string</para>
    ///   <para>rdfs:comment : Unique identification value for individuals.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#IDval">tddt:IDval</a>
    /// </summary>
    let IDval = _prefixId.prefix "IDval"
    /// <summary>
    ///   <para>skos:example : No User Responses: No, Never, Not at all</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : NoUserResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a negative polarity.</para>
    ///   <a href="https://w3id.org/todo/tododt#NoUserResponse">tddt:NoUserResponse</a>
    /// </summary>
    let NoUserResponse = _prefixId.prefix "NoUserResponse"
    /// <summary>
    ///   <para>skos:example : Null User Response: I don't know.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : NullUserResponseTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that does not represent a value that can be classified as ContentResponse or YesNoResponse.</para>
    ///   <a href="https://w3id.org/todo/tododt#NullUserResponseTrace">tddt:NullUserResponseTrace</a>
    /// </summary>
    let NullUserResponseTrace = _prefixId.prefix "NullUserResponseTrace"
    /// <summary>
    ///   <para>rdfs:comment : Element that leaves a record of the secondary dialogues performed.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SecondaryDialogueTrace^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#SecondaryDialogueTrace">tddt:SecondaryDialogueTrace</a>
    /// </summary>
    let SecondaryDialogueTrace = _prefixId.prefix "SecondaryDialogueTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SystemRequestTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the SystemRequests performed throughout the dialogue process.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#SystemRequestTrace">tddt:SystemRequestTrace</a>
    /// </summary>
    let SystemRequestTrace = _prefixId.prefix "SystemRequestTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SystemResponseTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the SystemResponses performed throughout the dialogue process.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#SystemResponseTrace">tddt:SystemResponseTrace</a>
    /// </summary>
    let SystemResponseTrace = _prefixId.prefix "SystemResponseTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SystemStepTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the SystemSteps performed throughout the dialogue process.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#SystemStepTrace">tddt:SystemStepTrace</a>
    /// </summary>
    let SystemStepTrace = _prefixId.prefix "SystemStepTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : UserRequestTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the User Requests performed throughout the dialogue process.</para>
    ///   <a href="https://w3id.org/todo/tododt#UserRequestTrace">tddt:UserRequestTrace</a>
    /// </summary>
    let UserRequestTrace = _prefixId.prefix "UserRequestTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : UserResponseTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the User Responses performed throughout the dialogue process.</para>
    ///   <a href="https://w3id.org/todo/tododt#UserResponseTrace">tddt:UserResponseTrace</a>
    /// </summary>
    let UserResponseTrace = _prefixId.prefix "UserResponseTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : UserStepTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the user steps (requests and responses) performed throughout the dialogue process.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#UserStepTrace">tddt:UserStepTrace</a>
    /// </summary>
    let UserStepTrace = _prefixId.prefix "UserStepTrace"
    /// <summary>
    ///   <para>skos:example : YesNo User Responses:
    ///
    /// - Yes, OK
    ///
    /// - No, Not at all</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : YesNoUserResponseTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a positive or negative polarity.</para>
    ///   <a href="https://w3id.org/todo/tododt#YesNoUserResponseTrace">tddt:YesNoUserResponseTrace</a>
    /// </summary>
    let YesNoUserResponseTrace = _prefixId.prefix "YesNoUserResponseTrace"
    /// <summary>
    ///   <para>skos:example : Yes User Responses: Yes, OK</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : YesUserResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a positive polarity.</para>
    ///   <a href="https://w3id.org/todo/tododt#YesUserResponse">tddt:YesUserResponse</a>
    /// </summary>
    let YesUserResponse = _prefixId.prefix "YesUserResponse"
    /// <summary>
    ///   <para>skos:example : UserReq: "I want to go to the room"
    ///
    /// possibleValue "room1"
    /// possibleValue "room2"
    ///
    /// SystemReq: "Do you want to go to {room1}?" (currentValue: room1); "Do you want to go to {room2}? (currentValue: room2)"skos:example : UserReq: "Quiero ir a la sala"
    ///
    /// possibleValue "sala1"
    /// possibleValue "sala2"
    ///
    /// System Req: "¿Quieres ir a la {sala1}?" (currentValue: sala1); "¿Quieres ir a la {sala2}? (currentValue: sala2)"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : currentValue^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : When asking the user for a specific information, the information currently asked to the user.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#currentValue">tddt:currentValue</a>
    /// </summary>
    let currentValue = _prefixId.prefix "currentValue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dateTime^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Sets a timestamp to a DialogueTrace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#dateTime">tddt:dateTime</a>
    /// </summary>
    let dateTime = _prefixId.prefix "dateTime"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dialStatus^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Sets whether a Dialogue/SecondaryDialogue has finished (closed) or not (open).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#dialStatus">tddt:dialStatus</a>
    /// </summary>
    let dialStatus = _prefixId.prefix "dialStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : dialogueStep^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Used to control which step is performing the current Dialogue.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#dialogueStep">tddt:dialogueStep</a>
    /// </summary>
    let dialogueStep = _prefixId.prefix "dialogueStep"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : finishDateTime^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Sets a finish timestamp to a DialogueTrace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#finishDateTime">tddt:finishDateTime</a>
    /// </summary>
    let finishDateTime = _prefixId.prefix "finishDateTime"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasSecondaryDialogue^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the SecondaryDialogue corresponding to a DialogueTrace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#hasSecondaryDialogue">tddt:hasSecondaryDialogue</a>
    /// </summary>
    let hasSecondaryDialogue = _prefixId.prefix "hasSecondaryDialogue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasSystemRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the SystemRequest corresponding to a SecondaryDialogueTrace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#hasSystemRequest">tddt:hasSystemRequest</a>
    /// </summary>
    let hasSystemRequest = _prefixId.prefix "hasSystemRequest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasSystemResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the SystemResponse corresponding to a SecondaryDialogueTrace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#hasSystemResponse">tddt:hasSystemResponse</a>
    /// </summary>
    let hasSystemResponse = _prefixId.prefix "hasSystemResponse"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasUserRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the UserRequest corresponding to a DialogueTrace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#hasUserRequest">tddt:hasUserRequest</a>
    /// </summary>
    let hasUserRequest = _prefixId.prefix "hasUserRequest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasUserResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the UserResponse corresponding to a SecondaryDialogueTrace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#hasUserResponse">tddt:hasUserResponse</a>
    /// </summary>
    let hasUserResponse = _prefixId.prefix "hasUserResponse"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : initDateTime^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : Sets a start timestamp to a DialogueTrace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#initDateTime">tddt:initDateTime</a>
    /// </summary>
    let initDateTime = _prefixId.prefix "initDateTime"
    /// <summary>
    ///   <para>skos:example : UserReq: "I want to go to the room"
    ///
    /// possibleValue "room1"
    /// possibleValue "room2"
    ///
    /// SystemReq: "Do you want to go to {room1}?"; "Do you want to go to {room2}?"skos:example : UserReq: "Quiero ir a la sala"
    ///
    /// possibleValue "sala1"
    /// possibleValue "sala2"
    ///
    /// System Req: "¿Quieres ir a la {sala1}?"; "¿Quieres ir a la {sala2}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : possibleValue^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : When asking the user for a specific information, the possible values of that information to be asked to the user.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#possibleValue">tddt:possibleValue</a>
    /// </summary>
    let possibleValue = _prefixId.prefix "possibleValue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : text^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododt#^^xsd:string</para>
    ///   <para>rdfs:comment : String that corresponds to a transcribed command by an user or the fully constructed outputSentence directed to the user.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododt#text">tddt:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
