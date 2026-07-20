namespace https.w3id.org.todo.tododt.hash

open DoxAletheia

module tddt =
    let _namespace_name = "https://w3id.org/todo/tododt#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the User Responses performed throughout the dialogue process. These responses provide specific information, as a response for a ContentRequest.
    /// <see href="https://w3id.org/todo/tododt#ContentUserResponseTrace"></see></summary>
    let ContentUserResponseTrace = _prefix "ContentUserResponseTrace"
    /// <summary>
    /// Element that leaves a record of the User Responses performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#UserResponseTrace"></see></summary>
    let UserResponseTrace = _prefix "UserResponseTrace"
    /// <summary>
    /// Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a positive or negative polarity.
    /// <see href="https://w3id.org/todo/tododt#YesNoUserResponseTrace"></see></summary>
    let YesNoUserResponseTrace = _prefix "YesNoUserResponseTrace"
    /// <summary>
    /// Unique identification value for individuals.
    /// <see href="https://w3id.org/todo/tododt#IDval"></see></summary>
    let IDval = _prefix "IDval"
    /// <summary>
    /// Element that leaves a record of the dialogues performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#DialogueProcessTrace"></see></summary>
    let DialogueProcessTrace = _prefix "DialogueProcessTrace"
    /// <summary>
    /// Sets a finish timestamp to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#finishDateTime"></see></summary>
    let finishDateTime = _prefix "finishDateTime"
    /// <summary>
    /// Sets a start timestamp to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#initDateTime"></see></summary>
    let initDateTime = _prefix "initDateTime"
    /// <summary>
    /// Sets whether a Dialogue/SecondaryDialogue has finished (closed) or not (open).
    /// <see href="https://w3id.org/todo/tododt#dialStatus"></see></summary>
    let dialStatus = _prefix "dialStatus"
    /// <summary>
    /// Element that leaves a record of the secondary dialogues performed.
    /// <see href="https://w3id.org/todo/tododt#SecondaryDialogueTrace"></see></summary>
    let SecondaryDialogueTrace = _prefix "SecondaryDialogueTrace"
    /// <summary>
    /// Establishes the SecondaryDialogue corresponding to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#hasSecondaryDialogue"></see></summary>
    let hasSecondaryDialogue = _prefix "hasSecondaryDialogue"
    /// <summary>
    /// Element that leaves a record of the dialogues performed.
    /// <see href="https://w3id.org/todo/tododt#DialogueTrace"></see></summary>
    let DialogueTrace = _prefix "DialogueTrace"
    /// <summary>
    /// Element that leaves a record of the User Requests performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#UserRequestTrace"></see></summary>
    let UserRequestTrace = _prefix "UserRequestTrace"
    /// <summary>
    /// Establishes the UserRequest corresponding to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#hasUserRequest"></see></summary>
    let hasUserRequest = _prefix "hasUserRequest"
    /// <summary>
    /// Used to control which step is performing the current Dialogue.
    /// <see href="https://w3id.org/todo/tododt#dialogueStep"></see></summary>
    let dialogueStep = _prefix "dialogueStep"
    /// <summary>
    /// Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a negative polarity.
    /// <see href="https://w3id.org/todo/tododt#NoUserResponse"></see></summary>
    let NoUserResponse = _prefix "NoUserResponse"
    /// <summary>
    /// Response that does not represent a value that can be classified as ContentResponse or YesNoResponse.
    /// <see href="https://w3id.org/todo/tododt#NullUserResponseTrace"></see></summary>
    let NullUserResponseTrace = _prefix "NullUserResponseTrace"
    /// <summary>
    /// Establishes the UserResponse corresponding to a SecondaryDialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#hasUserResponse"></see></summary>
    let hasUserResponse = _prefix "hasUserResponse"
    /// <summary>
    /// Element that leaves a record of the SystemResponses performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#SystemResponseTrace"></see></summary>
    let SystemResponseTrace = _prefix "SystemResponseTrace"
    /// <summary>
    /// Establishes the SystemResponse corresponding to a SecondaryDialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#hasSystemResponse"></see></summary>
    let hasSystemResponse = _prefix "hasSystemResponse"
    /// <summary>
    /// String that corresponds to a transcribed command by an user or the fully constructed outputSentence directed to the user.
    /// <see href="https://w3id.org/todo/tododt#text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// Element that leaves a record of the SystemRequests performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#SystemRequestTrace"></see></summary>
    let SystemRequestTrace = _prefix "SystemRequestTrace"
    /// <summary>
    /// Establishes the SystemRequest corresponding to a SecondaryDialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#hasSystemRequest"></see></summary>
    let hasSystemRequest = _prefix "hasSystemRequest"
    /// <summary>
    /// Element that leaves a record of the SystemSteps performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#SystemStepTrace"></see></summary>
    let SystemStepTrace = _prefix "SystemStepTrace"
    /// <summary>
    /// Element that leaves a record of the user steps (requests and responses) performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#UserStepTrace"></see></summary>
    let UserStepTrace = _prefix "UserStepTrace"
    /// <summary>
    /// Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a positive polarity.
    /// <see href="https://w3id.org/todo/tododt#YesUserResponse"></see></summary>
    let YesUserResponse = _prefix "YesUserResponse"
    /// <summary>
    /// When asking the user for a specific information, the information currently asked to the user.
    /// <see href="https://w3id.org/todo/tododt#currentValue"></see></summary>
    let currentValue = _prefix "currentValue"
    /// <summary>
    /// Sets a timestamp to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#dateTime"></see></summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    /// When asking the user for a specific information, the possible values of that information to be asked to the user.
    /// <see href="https://w3id.org/todo/tododt#possibleValue"></see></summary>
    let possibleValue = _prefix "possibleValue"
