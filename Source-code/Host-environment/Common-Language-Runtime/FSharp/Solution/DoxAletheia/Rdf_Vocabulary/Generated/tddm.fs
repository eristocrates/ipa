namespace https.w3id.org.todo.tododm.hash

open DoxAletheia.Rdf_Vocabulary

module tddm =
    let _namespace_name = "https://w3id.org/todo/tododm#"

    /// <summary>
    /// Request that makes the user choose from a set of Actions obtained through inference.
    /// <see href="https://w3id.org/todo/tododm#ActionDisambiguationRequest"></see></summary>
    let ActionDisambiguationRequest =
        Namespaced_IRI.parse _namespace_name "ActionDisambiguationRequest" |> NamespacedName

    /// <summary>
    /// Request the response of which is expected to be limited to "Yes" or "No" (and equivalents).
    ///
    /// Also known as "Polar question" in linguistics.
    /// <see href="https://w3id.org/todo/tododm#YesNoRequest"></see></summary>
    let YesNoRequest =
        Namespaced_IRI.parse _namespace_name "YesNoRequest" |> NamespacedName

    /// <summary>
    /// Response in which the system tells the user that it has several options for an Action.
    /// <see href="https://w3id.org/todo/tododm#ActionOptionsAvailable"></see></summary>
    let ActionOptionsAvailable =
        Namespaced_IRI.parse _namespace_name "ActionOptionsAvailable" |> NamespacedName

    /// <summary>
    /// Establishes the implications of the output of a StepFunction in the Dialogue Manager code.
    /// <see href="https://w3id.org/todo/tododm#implies"></see></summary>
    let implies = Namespaced_IRI.parse _namespace_name "implies" |> NamespacedName

    /// <summary>
    /// Response in which the system tells the user that it has several options for a specific element (e.g. WorldElement).
    ///
    /// Note the difference between OptionsAvailableResponse and TooManyAlternativesResponse: the first implies that there is a fair amount of options, whereas the latter implies that the options that are available are too many and it will require the user to be more specific.
    /// <see href="https://w3id.org/todo/tododm#OptionsAvailableResponse"></see></summary>
    let OptionsAvailableResponse =
        Namespaced_IRI.parse _namespace_name "OptionsAvailableResponse" |> NamespacedName

    /// <summary>
    /// Response that the system gives when a command can be associated to more than one action.
    /// <see href="https://w3id.org/todo/tododm#ActionOptionsResponse"></see></summary>
    let ActionOptionsResponse =
        Namespaced_IRI.parse _namespace_name "ActionOptionsResponse" |> NamespacedName

    /// <summary>
    /// Information that the system provides in response to a UserRequest or as a piece of information directed to the user without a prior UserRequest.
    /// <see href="https://w3id.org/todo/tododm#SystemResponse"></see></summary>
    let SystemResponse =
        Namespaced_IRI.parse _namespace_name "SystemResponse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/todo/tododm#AlternativeArgumentSuggestionRequest"></see>
    /// </summary>
    let AlternativeArgumentSuggestionRequest =
        Namespaced_IRI.parse _namespace_name "AlternativeArgumentSuggestionRequest" |> NamespacedName

    /// <summary>
    /// Request made to reassure the assignation of a value from the KEE to an Argument.
    /// <see href="https://w3id.org/todo/tododm#ArgumentAssignationRequest"></see></summary>
    let ArgumentAssignationRequest =
        Namespaced_IRI.parse _namespace_name "ArgumentAssignationRequest" |> NamespacedName

    /// <summary>
    /// Request that demands a specific characteristic of the argument. This request is used when the argument provided is too broad and the system needs some characteristic that allows determining the specific element the user is refering to.
    ///
    /// For example, the user would require a "piece", and the system includes data for 300 types of pieces.
    /// <see href="https://w3id.org/todo/tododm#ArgumentCharacteristicRequest"></see></summary>
    let ArgumentCharacteristicRequest =
        Namespaced_IRI.parse _namespace_name "ArgumentCharacteristicRequest" |> NamespacedName

    /// <summary>
    /// Request that asks for specific information, other than "Yes" or "No" (and equivalents).
    ///
    /// Also known as "Non polar/Open question" in linguistics.
    /// <see href="https://w3id.org/todo/tododm#ContentRequest"></see></summary>
    let ContentRequest =
        Namespaced_IRI.parse _namespace_name "ContentRequest" |> NamespacedName

    /// <summary>
    /// Request that asks the user for some clarification for the value of an argument when a previously saved value generates too many options.
    /// <see href="https://w3id.org/todo/tododm#ArgumentClarificationRequest"></see></summary>
    let ArgumentClarificationRequest =
        Namespaced_IRI.parse _namespace_name "ArgumentClarificationRequest" |> NamespacedName

    /// <summary>
    /// Response that gives details about an Argument. For example, when the user does not understand what information conveys said Argument.
    /// <see href="https://w3id.org/todo/tododm#ArgumentExplanationResponse"></see></summary>
    let ArgumentExplanationResponse =
        Namespaced_IRI.parse _namespace_name "ArgumentExplanationResponse" |> NamespacedName

    /// <summary>
    /// This would imply an ArgumentRequest.
    /// The system informs the user the Argument value provided is not valid according to what has been modelled in the KB.
    /// <see href="https://w3id.org/todo/tododm#ArgumentNotCompatibleResponse"></see></summary>
    let ArgumentNotCompatibleResponse =
        Namespaced_IRI.parse _namespace_name "ArgumentNotCompatibleResponse" |> NamespacedName

    /// <summary>
    /// Request that requires the user to repeat some information.
    /// <see href="https://w3id.org/todo/tododm#VerifyInfoRequest"></see></summary>
    let VerifyInfoRequest =
        Namespaced_IRI.parse _namespace_name "VerifyInfoRequest" |> NamespacedName

    /// <summary>
    /// Response given when the system has not been able to guess the value of the Argument through its characteristics.
    /// This would imply an ArgumentRequest/ArgumentCharacteristicRequest
    /// <see href="https://w3id.org/todo/tododm#ArgumentNotGuessedResponse"></see></summary>
    let ArgumentNotGuessedResponse =
        Namespaced_IRI.parse _namespace_name "ArgumentNotGuessedResponse" |> NamespacedName

    /// <summary>
    /// Request that demands for the value of an Argument.
    /// <see href="https://w3id.org/todo/tododm#ArgumentRequest"></see></summary>
    let ArgumentRequest =
        Namespaced_IRI.parse _namespace_name "ArgumentRequest" |> NamespacedName

    /// <summary>
    /// Response in which the system tells the user that it has several options for an Argument.
    /// <see href="https://w3id.org/todo/tododm#ArgumentOptionsAvailable"></see></summary>
    let ArgumentOptionsAvailable =
        Namespaced_IRI.parse _namespace_name "ArgumentOptionsAvailable" |> NamespacedName

    /// <summary>
    /// Request made when a value for an Argument can belong to different Arguments. The strategy is asking for each Argument option until the user confirms.
    /// <see href="https://w3id.org/todo/tododm#ArgumentSpecifyRequest"></see></summary>
    let ArgumentSpecifyRequest =
        Namespaced_IRI.parse _namespace_name "ArgumentSpecifyRequest" |> NamespacedName

    /// <summary>
    /// Response that the system gives when an item can be associated to more than one argument.
    /// <see href="https://w3id.org/todo/tododm#ArgumentOptionsResponse"></see></summary>
    let ArgumentOptionsResponse =
        Namespaced_IRI.parse _namespace_name "ArgumentOptionsResponse" |> NamespacedName

    /// <summary>
    /// Request that tries to obtain the value of the argument when it is ambiguous (e.g. "sala" may apply to "sala Ura", "sala Sua", etc.).
    /// <see href="https://w3id.org/todo/tododm#ArgumentValueDisambiguationRequest"></see></summary>
    let ArgumentValueDisambiguationRequest =
        Namespaced_IRI.parse _namespace_name "ArgumentValueDisambiguationRequest" |> NamespacedName

    /// <summary>
    /// Response in which the system tells the user that it has several options for an argument value.
    /// <see href="https://w3id.org/todo/tododm#ArgumentValueOptionsAvailable"></see></summary>
    let ArgumentValueOptionsAvailable =
        Namespaced_IRI.parse _namespace_name "ArgumentValueOptionsAvailable" |> NamespacedName

    /// <summary>
    /// Response that the system gives when it cannot associate an action/target to one or more actions.
    /// <see href="https://w3id.org/todo/tododm#CannotResolveActionResponse"></see></summary>
    let CannotResolveActionResponse =
        Namespaced_IRI.parse _namespace_name "CannotResolveActionResponse" |> NamespacedName

    /// <summary>
    /// Request to the user to provide their (initial) command.
    /// <see href="https://w3id.org/todo/tododm#UserCommandRequest"></see></summary>
    let UserCommandRequest =
        Namespaced_IRI.parse _namespace_name "UserCommandRequest" |> NamespacedName

    /// <summary>
    /// Response that informs the user that the command could not be resolved.
    ///
    /// [to be followed by an ArgRequest]
    /// <see href="https://w3id.org/todo/tododm#CannotResolveCommandResponse"></see></summary>
    let CannotResolveCommandResponse =
        Namespaced_IRI.parse _namespace_name "CannotResolveCommandResponse" |> NamespacedName

    /// <summary>
    /// Step Function associated to a ContentRequest.
    /// <see href="https://w3id.org/todo/tododm#ContentRequestStepFunction"></see></summary>
    let ContentRequestStepFunction =
        Namespaced_IRI.parse _namespace_name "ContentRequestStepFunction" |> NamespacedName

    /// <summary>
    /// Establishes the StepFunction corresponding to a SystemRequest or a ProcessStep.
    /// <see href="https://w3id.org/todo/tododm#hasStepFunction"></see></summary>
    let hasStepFunction =
        Namespaced_IRI.parse _namespace_name "hasStepFunction" |> NamespacedName

    /// <summary>
    /// Act in which the system requires user input.
    /// <see href="https://w3id.org/todo/tododm#SystemRequest"></see></summary>
    let SystemRequest =
        Namespaced_IRI.parse _namespace_name "SystemRequest" |> NamespacedName

    /// <summary>
    /// "I think I haven't understood. Can you be more specific?
    /// Reponse given to the user when the UserResponse is a YesNoResponse and the SystemRequest requires a ContentResponse.
    /// <see href="https://w3id.org/todo/tododm#YesNoResponseNotExpected"></see></summary>
    let YesNoResponseNotExpected =
        Namespaced_IRI.parse _namespace_name "YesNoResponseNotExpected" |> NamespacedName

    /// <summary>
    /// Establishes the implications of an incorrect UserResponseType (e.g. when the request requires Yes/No as response and the user provides a ContentResponse).
    /// <see href="https://w3id.org/todo/tododm#incorrectUserResponseTypeImplies"></see></summary>
    let incorrectUserResponseTypeImplies =
        Namespaced_IRI.parse _namespace_name "incorrectUserResponseTypeImplies" |> NamespacedName

    /// <summary>
    /// Establishes the SystemRequest or a ProcessStep corresponding to a StepFunction.
    /// <see href="https://w3id.org/todo/tododm#isStepFunctionOf"></see></summary>
    let isStepFunctionOf =
        Namespaced_IRI.parse _namespace_name "isStepFunctionOf" |> NamespacedName

    /// <summary>
    /// Response that informs the user that the system has not understood the user command.
    /// <see href="https://w3id.org/todo/tododm#NotUnderstoodResponse"></see></summary>
    let NotUnderstoodResponse =
        Namespaced_IRI.parse _namespace_name "NotUnderstoodResponse" |> NamespacedName

    /// <summary>
    /// Establishes the implications when the system does not understand a UserResponse.
    /// <see href="https://w3id.org/todo/tododm#userResponseNotUnderstoodImplies"></see></summary>
    let userResponseNotUnderstoodImplies =
        Namespaced_IRI.parse _namespace_name "userResponseNotUnderstoodImplies" |> NamespacedName

    /// <summary>
    /// Element that is linked to a function in the Dialogue Manager code. This element also determines the implications of the output of said function in the code.
    /// <see href="https://w3id.org/todo/tododm#StepFunction"></see></summary>
    let StepFunction =
        Namespaced_IRI.parse _namespace_name "StepFunction" |> NamespacedName

    /// <summary>
    /// "You only need me to tell me yes or no, please"
    /// Reponse given to the user when the UserResponse is a ContentResponse and the SystemRequest requires a YesNoResponse.
    /// <see href="https://w3id.org/todo/tododm#ContentResponseNotExpected"></see></summary>
    let ContentResponseNotExpected =
        Namespaced_IRI.parse _namespace_name "ContentResponseNotExpected" |> NamespacedName

    /// <summary>
    /// Reponse given to the user when the UserResponse does not correspond with the expected response of the SystemRequest.
    /// <see href="https://w3id.org/todo/tododm#ResponseTypeNotExpectedResponse"></see></summary>
    let ResponseTypeNotExpectedResponse =
        Namespaced_IRI.parse _namespace_name "ResponseTypeNotExpectedResponse" |> NamespacedName

    /// <summary>
    /// Marker that conveys the idea of continuing with the dialogue process.
    /// <see href="https://w3id.org/todo/tododm#Continue"></see></summary>
    let Continue = Namespaced_IRI.parse _namespace_name "Continue" |> NamespacedName

    /// <summary>
    /// Elements that correspond to predefined or generic actions in dialogue control.
    /// <see href="https://w3id.org/todo/tododm#DialogueControlMarker"></see></summary>
    let DialogueControlMarker =
        Namespaced_IRI.parse _namespace_name "DialogueControlMarker" |> NamespacedName

    /// <summary>
    /// Unique identification value for individuals.
    /// <see href="https://w3id.org/todo/tododm#IDval"></see></summary>
    let IDval = Namespaced_IRI.parse _namespace_name "IDval" |> NamespacedName

    /// <summary>
    /// Response given by the system when the dialogue process has finished (i.e., when the user confirms the action and argument values)
    /// <see href="https://w3id.org/todo/tododm#DialogueFinished"></see></summary>
    let DialogueFinished =
        Namespaced_IRI.parse _namespace_name "DialogueFinished" |> NamespacedName

    /// <summary>
    /// Step in the dialogue process that requires a system interaction with the user (SystemStep).
    /// <see href="https://w3id.org/todo/tododm#DialogueStep"></see></summary>
    let DialogueStep =
        Namespaced_IRI.parse _namespace_name "DialogueStep" |> NamespacedName

    /// <summary>
    /// Step performed by the system in order to request information to the user or simply outputting information.
    /// <see href="https://w3id.org/todo/tododm#SystemStep"></see></summary>
    let SystemStep = Namespaced_IRI.parse _namespace_name "SystemStep" |> NamespacedName

    /// <summary>
    /// Establishes the SystemRequest/Response that initiates a DialogueStep.
    /// <see href="https://w3id.org/todo/tododm#initiatedBy"></see></summary>
    let initiatedBy =
        Namespaced_IRI.parse _namespace_name "initiatedBy" |> NamespacedName

    /// <summary>
    /// Sets the order for StepFunctions/DialogueSteps.
    /// <see href="https://w3id.org/todo/tododm#order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName

    /// <summary>
    /// Step in the dialogue process that does not require a system interaction with the user (SystemStep).
    /// <see href="https://w3id.org/todo/tododm#ProcessStep"></see></summary>
    let ProcessStep =
        Namespaced_IRI.parse _namespace_name "ProcessStep" |> NamespacedName

    /// <summary>
    /// Marker that establishes that the dialogue must be finished.
    /// <see href="https://w3id.org/todo/tododm#FinishDial"></see></summary>
    let FinishDial = Namespaced_IRI.parse _namespace_name "FinishDial" |> NamespacedName

    /// <summary>
    /// Welcome message.
    /// <see href="https://w3id.org/todo/tododm#GreetingResponse"></see></summary>
    let GreetingResponse =
        Namespaced_IRI.parse _namespace_name "GreetingResponse" |> NamespacedName

    /// <summary>
    /// Request that checks which is the Argument/Action that has not been interpreter correctly, after a negative ReassureFeedbackRequest.
    /// <see href="https://w3id.org/todo/tododm#IncorrectArgumentRequest"></see></summary>
    let IncorrectArgumentRequest =
        Namespaced_IRI.parse _namespace_name "IncorrectArgumentRequest" |> NamespacedName

    /// <summary>
    /// Request made when a UserRequest can belong to different Intents. The strategy is asking for each Intent option until the user confirms.
    /// <see href="https://w3id.org/todo/tododm#IntentRequest"></see></summary>
    let IntentRequest =
        Namespaced_IRI.parse _namespace_name "IntentRequest" |> NamespacedName

    /// <summary>
    /// The item {item} is not compatible with any argument for this action.
    /// The system informs the user the Item value provided is not compatible with any action argument, according to what has been modelled in the KB.
    /// <see href="https://w3id.org/todo/tododm#ItemNotCompatibleAnyArgResponse"></see></summary>
    let ItemNotCompatibleAnyArgResponse =
        Namespaced_IRI.parse _namespace_name "ItemNotCompatibleAnyArgResponse" |> NamespacedName

    /// <summary>
    /// Response that is given when, after checking if all the core Arguments have been provided by the user command, there are core Arguments that are missing.
    /// <see href="https://w3id.org/todo/tododm#MissingInformationResponse"></see></summary>
    let MissingInformationResponse =
        Namespaced_IRI.parse _namespace_name "MissingInformationResponse" |> NamespacedName

    /// <summary>
    /// Request that asks the user whether they want to initiate a new dialogue process.
    /// <see href="https://w3id.org/todo/tododm#NewDialogue"></see></summary>
    let NewDialogue =
        Namespaced_IRI.parse _namespace_name "NewDialogue" |> NamespacedName

    /// <summary>
    /// Response that the system displays when it runs out of options. It is intended to continue with a full request of the element that the previous options corresponded to.
    /// <see href="https://w3id.org/todo/tododm#NoMoreOptionsContinueResponse"></see></summary>
    let NoMoreOptionsContinueResponse =
        Namespaced_IRI.parse _namespace_name "NoMoreOptionsContinueResponse" |> NamespacedName

    /// <summary>
    /// Response that the system displays when it runs out of options. It finishes the current Dialogue.
    /// <see href="https://w3id.org/todo/tododm#NoMoreOptionsRestartResponse"></see></summary>
    let NoMoreOptionsRestartResponse =
        Namespaced_IRI.parse _namespace_name "NoMoreOptionsRestartResponse" |> NamespacedName

    /// <summary>
    /// Response that the system returns when the clarification step of the value of an Argument does not return any results.
    /// <see href="https://w3id.org/todo/tododm#NoResultsClarificationResponse"></see></summary>
    let NoResultsClarificationResponse =
        Namespaced_IRI.parse _namespace_name "NoResultsClarificationResponse" |> NamespacedName

    /// <summary>
    /// Request that demands the user to repeat the value of an Argument.
    /// <see href="https://w3id.org/todo/tododm#RepeatArgumentRequest"></see></summary>
    let RepeatArgumentRequest =
        Namespaced_IRI.parse _namespace_name "RepeatArgumentRequest" |> NamespacedName

    /// <summary>
    /// Step Function associated to a ProcessStep.
    /// <see href="https://w3id.org/todo/tododm#ProcessStepStepFunction"></see></summary>
    let ProcessStepStepFunction =
        Namespaced_IRI.parse _namespace_name "ProcessStepStepFunction" |> NamespacedName

    /// <summary>
    /// Request that is sent in order to obtain feedback whether the interpretation obtained is correct or not.
    /// <see href="https://w3id.org/todo/tododm#ReassureFeedbackRequest"></see></summary>
    let ReassureFeedbackRequest =
        Namespaced_IRI.parse _namespace_name "ReassureFeedbackRequest" |> NamespacedName

    /// <summary>
    /// Marker that requires the dialogue to restart.
    /// <see href="https://w3id.org/todo/tododm#Restart"></see></summary>
    let Restart = Namespaced_IRI.parse _namespace_name "Restart" |> NamespacedName
    /// <summary>
    /// Marker that returns to the last SystemResponse+Request/SystemRequest performed.
    /// <see href="https://w3id.org/todo/tododm#Return"></see></summary>
    let Return = Namespaced_IRI.parse _namespace_name "Return" |> NamespacedName

    /// <summary>
    /// String to be output by the system in order to communicate a SystemRequest/Response to the user.
    /// <see href="https://w3id.org/todo/tododm#outputSentence"></see></summary>
    let outputSentence =
        Namespaced_IRI.parse _namespace_name "outputSentence" |> NamespacedName

    /// <summary>
    /// Response given when the number of possible Actions is too big.
    /// <see href="https://w3id.org/todo/tododm#TooManyActionOptionsResponse"></see></summary>
    let TooManyActionOptionsResponse =
        Namespaced_IRI.parse _namespace_name "TooManyActionOptionsResponse" |> NamespacedName

    /// <summary>
    /// Response given when the alternatives (in general) are too big.
    /// <see href="https://w3id.org/todo/tododm#TooManyAlternativesResponse"></see></summary>
    let TooManyAlternativesResponse =
        Namespaced_IRI.parse _namespace_name "TooManyAlternativesResponse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/todo/tododm#TooManyArgumentOptionsResponse"></see>
    /// </summary>
    let TooManyArgumentOptionsResponse =
        Namespaced_IRI.parse _namespace_name "TooManyArgumentOptionsResponse" |> NamespacedName

    /// <summary>
    /// Response given when the number of possible World Elements is too big.
    /// <see href="https://w3id.org/todo/tododm#TooManyWorldElementOptionsResponse"></see></summary>
    let TooManyWorldElementOptionsResponse =
        Namespaced_IRI.parse _namespace_name "TooManyWorldElementOptionsResponse" |> NamespacedName

    /// <summary>
    /// Response given by the system to reassure the user that it has understood the request.
    /// <see href="https://w3id.org/todo/tododm#UnderstoodResponse"></see></summary>
    let UnderstoodResponse =
        Namespaced_IRI.parse _namespace_name "UnderstoodResponse" |> NamespacedName

    /// <summary>
    /// Response given when the ArgValue for an Argument provided by the user is not compatible with said Argument.
    /// <see href="https://w3id.org/todo/tododm#ValueNotCompatibleWithArgumentResponse"></see></summary>
    let ValueNotCompatibleWithArgumentResponse =
        Namespaced_IRI.parse _namespace_name "ValueNotCompatibleWithArgumentResponse" |> NamespacedName

    /// <summary>
    /// Step Function associated to a YesNoRequest.
    /// <see href="https://w3id.org/todo/tododm#YesNoRequestStepFunction"></see></summary>
    let YesNoRequestStepFunction =
        Namespaced_IRI.parse _namespace_name "YesNoRequestStepFunction" |> NamespacedName

    /// <summary>
    /// Establishes the SystemRequest that requires a given UserResponse type.
    /// <see href="https://w3id.org/todo/tododm#isRequiredBy"></see></summary>
    let isRequiredBy =
        Namespaced_IRI.parse _namespace_name "isRequiredBy" |> NamespacedName

    /// <summary>
    /// Establishes the type of UserResponse required by a SystemRequest.
    /// <see href="https://w3id.org/todo/tododm#requires"></see></summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName

    /// <summary>
    /// Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output and the length of the output is smaller than the number of maximum results previously defined.
    /// <see href="https://w3id.org/todo/tododm#lessMaxOptionsImplies"></see></summary>
    let lessMaxOptionsImplies =
        Namespaced_IRI.parse _namespace_name "lessMaxOptionsImplies" |> NamespacedName

    /// <summary>
    /// Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output.
    /// <see href="https://w3id.org/todo/tododm#multipleOptionsImplies"></see></summary>
    let multipleOptionsImplies =
        Namespaced_IRI.parse _namespace_name "multipleOptionsImplies" |> NamespacedName

    /// <summary>
    /// Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output and the length of the output is higher than the number of maximum results previously defined.
    /// <see href="https://w3id.org/todo/tododm#moreMaxOptionsImplies"></see></summary>
    let moreMaxOptionsImplies =
        Namespaced_IRI.parse _namespace_name "moreMaxOptionsImplies" |> NamespacedName

    /// <summary>
    /// Establishes the implications when a StepFunction, in the Dialogue Manager code, returns no results as output.
    /// <see href="https://w3id.org/todo/tododm#noOptionsImplies"></see></summary>
    let noOptionsImplies =
        Namespaced_IRI.parse _namespace_name "noOptionsImplies" |> NamespacedName

    /// <summary>
    /// Establishes the implications of a negative UserResponse.
    /// <see href="https://w3id.org/todo/tododm#noUserResponseTypeImplies"></see></summary>
    let noUserResponseTypeImplies =
        Namespaced_IRI.parse _namespace_name "noUserResponseTypeImplies" |> NamespacedName

    /// <summary>
    /// Establishes the implications when a StepFunction, in the Dialogue Manager code, returns one result as output.
    /// <see href="https://w3id.org/todo/tododm#singleOptionImplies"></see></summary>
    let singleOptionImplies =
        Namespaced_IRI.parse _namespace_name "singleOptionImplies" |> NamespacedName

    /// <summary>
    /// Establishes the implications of a positive UserResponse.
    /// <see href="https://w3id.org/todo/tododm#yesUserResponseTypeImplies"></see></summary>
    let yesUserResponseTypeImplies =
        Namespaced_IRI.parse _namespace_name "yesUserResponseTypeImplies" |> NamespacedName
