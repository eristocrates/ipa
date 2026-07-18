namespace https.w3id.org.todo.tododt.hash

open DoxAletheia.Rdf_Vocabulary

module tddt =
    let _namespace_name = "https://w3id.org/todo/tododt#"

    /// <summary>
    /// Element that leaves a record of the User Responses performed throughout the dialogue process. These responses provide specific information, as a response for a ContentRequest.
    /// <see href="https://w3id.org/todo/tododt#ContentUserResponseTrace"></see></summary>
    let ContentUserResponseTrace =
        Namespaced_IRI.parse _namespace_name "ContentUserResponseTrace" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the User Responses performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#UserResponseTrace"></see></summary>
    let UserResponseTrace =
        Namespaced_IRI.parse _namespace_name "UserResponseTrace" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a positive or negative polarity.
    /// <see href="https://w3id.org/todo/tododt#YesNoUserResponseTrace"></see></summary>
    let YesNoUserResponseTrace =
        Namespaced_IRI.parse _namespace_name "YesNoUserResponseTrace" |> NamespacedName

    /// <summary>
    /// Unique identification value for individuals.
    /// <see href="https://w3id.org/todo/tododt#IDval"></see></summary>
    let IDval = Namespaced_IRI.parse _namespace_name "IDval" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the dialogues performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#DialogueProcessTrace"></see></summary>
    let DialogueProcessTrace =
        Namespaced_IRI.parse _namespace_name "DialogueProcessTrace" |> NamespacedName

    /// <summary>
    /// Sets a finish timestamp to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#finishDateTime"></see></summary>
    let finishDateTime =
        Namespaced_IRI.parse _namespace_name "finishDateTime" |> NamespacedName

    /// <summary>
    /// Sets a start timestamp to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#initDateTime"></see></summary>
    let initDateTime =
        Namespaced_IRI.parse _namespace_name "initDateTime" |> NamespacedName

    /// <summary>
    /// Sets whether a Dialogue/SecondaryDialogue has finished (closed) or not (open).
    /// <see href="https://w3id.org/todo/tododt#dialStatus"></see></summary>
    let dialStatus = Namespaced_IRI.parse _namespace_name "dialStatus" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the secondary dialogues performed.
    /// <see href="https://w3id.org/todo/tododt#SecondaryDialogueTrace"></see></summary>
    let SecondaryDialogueTrace =
        Namespaced_IRI.parse _namespace_name "SecondaryDialogueTrace" |> NamespacedName

    /// <summary>
    /// Establishes the SecondaryDialogue corresponding to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#hasSecondaryDialogue"></see></summary>
    let hasSecondaryDialogue =
        Namespaced_IRI.parse _namespace_name "hasSecondaryDialogue" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the dialogues performed.
    /// <see href="https://w3id.org/todo/tododt#DialogueTrace"></see></summary>
    let DialogueTrace =
        Namespaced_IRI.parse _namespace_name "DialogueTrace" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the User Requests performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#UserRequestTrace"></see></summary>
    let UserRequestTrace =
        Namespaced_IRI.parse _namespace_name "UserRequestTrace" |> NamespacedName

    /// <summary>
    /// Establishes the UserRequest corresponding to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#hasUserRequest"></see></summary>
    let hasUserRequest =
        Namespaced_IRI.parse _namespace_name "hasUserRequest" |> NamespacedName

    /// <summary>
    /// Used to control which step is performing the current Dialogue.
    /// <see href="https://w3id.org/todo/tododt#dialogueStep"></see></summary>
    let dialogueStep =
        Namespaced_IRI.parse _namespace_name "dialogueStep" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a negative polarity.
    /// <see href="https://w3id.org/todo/tododt#NoUserResponse"></see></summary>
    let NoUserResponse =
        Namespaced_IRI.parse _namespace_name "NoUserResponse" |> NamespacedName

    /// <summary>
    /// Response that does not represent a value that can be classified as ContentResponse or YesNoResponse.
    /// <see href="https://w3id.org/todo/tododt#NullUserResponseTrace"></see></summary>
    let NullUserResponseTrace =
        Namespaced_IRI.parse _namespace_name "NullUserResponseTrace" |> NamespacedName

    /// <summary>
    /// Establishes the UserResponse corresponding to a SecondaryDialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#hasUserResponse"></see></summary>
    let hasUserResponse =
        Namespaced_IRI.parse _namespace_name "hasUserResponse" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the SystemResponses performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#SystemResponseTrace"></see></summary>
    let SystemResponseTrace =
        Namespaced_IRI.parse _namespace_name "SystemResponseTrace" |> NamespacedName

    /// <summary>
    /// Establishes the SystemResponse corresponding to a SecondaryDialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#hasSystemResponse"></see></summary>
    let hasSystemResponse =
        Namespaced_IRI.parse _namespace_name "hasSystemResponse" |> NamespacedName

    /// <summary>
    /// String that corresponds to a transcribed command by an user or the fully constructed outputSentence directed to the user.
    /// <see href="https://w3id.org/todo/tododt#text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the SystemRequests performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#SystemRequestTrace"></see></summary>
    let SystemRequestTrace =
        Namespaced_IRI.parse _namespace_name "SystemRequestTrace" |> NamespacedName

    /// <summary>
    /// Establishes the SystemRequest corresponding to a SecondaryDialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#hasSystemRequest"></see></summary>
    let hasSystemRequest =
        Namespaced_IRI.parse _namespace_name "hasSystemRequest" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the SystemSteps performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#SystemStepTrace"></see></summary>
    let SystemStepTrace =
        Namespaced_IRI.parse _namespace_name "SystemStepTrace" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the user steps (requests and responses) performed throughout the dialogue process.
    /// <see href="https://w3id.org/todo/tododt#UserStepTrace"></see></summary>
    let UserStepTrace =
        Namespaced_IRI.parse _namespace_name "UserStepTrace" |> NamespacedName

    /// <summary>
    /// Element that leaves a record of the User Responses performed throughout the dialogue process. These responses correspond to a positive polarity.
    /// <see href="https://w3id.org/todo/tododt#YesUserResponse"></see></summary>
    let YesUserResponse =
        Namespaced_IRI.parse _namespace_name "YesUserResponse" |> NamespacedName

    /// <summary>
    /// When asking the user for a specific information, the information currently asked to the user.
    /// <see href="https://w3id.org/todo/tododt#currentValue"></see></summary>
    let currentValue =
        Namespaced_IRI.parse _namespace_name "currentValue" |> NamespacedName

    /// <summary>
    /// Sets a timestamp to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododt#dateTime"></see></summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName

    /// <summary>
    /// When asking the user for a specific information, the possible values of that information to be asked to the user.
    /// <see href="https://w3id.org/todo/tododt#possibleValue"></see></summary>
    let possibleValue =
        Namespaced_IRI.parse _namespace_name "possibleValue" |> NamespacedName
