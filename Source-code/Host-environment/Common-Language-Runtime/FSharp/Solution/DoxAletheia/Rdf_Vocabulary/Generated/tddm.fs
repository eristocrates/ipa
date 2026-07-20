namespace https.w3id.org.todo.tododm.hash

open DoxAletheia

module tddm =
    let _namespace_name = "https://w3id.org/todo/tododm#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Request that makes the user choose from a set of Actions obtained through inference.
    /// <see href="https://w3id.org/todo/tododm#ActionDisambiguationRequest"></see></summary>
    let ActionDisambiguationRequest = _prefix "ActionDisambiguationRequest"
    /// <summary>
    /// Request the response of which is expected to be limited to "Yes" or "No" (and equivalents).
    ///
    /// Also known as "Polar question" in linguistics.
    /// <see href="https://w3id.org/todo/tododm#YesNoRequest"></see></summary>
    let YesNoRequest = _prefix "YesNoRequest"
    /// <summary>
    /// Response in which the system tells the user that it has several options for an Action.
    /// <see href="https://w3id.org/todo/tododm#ActionOptionsAvailable"></see></summary>
    let ActionOptionsAvailable = _prefix "ActionOptionsAvailable"
    /// <summary>
    /// Establishes the implications of the output of a StepFunction in the Dialogue Manager code.
    /// <see href="https://w3id.org/todo/tododm#implies"></see></summary>
    let implies = _prefix "implies"
    /// <summary>
    /// Response in which the system tells the user that it has several options for a specific element (e.g. WorldElement).
    ///
    /// Note the difference between OptionsAvailableResponse and TooManyAlternativesResponse: the first implies that there is a fair amount of options, whereas the latter implies that the options that are available are too many and it will require the user to be more specific.
    /// <see href="https://w3id.org/todo/tododm#OptionsAvailableResponse"></see></summary>
    let OptionsAvailableResponse = _prefix "OptionsAvailableResponse"
    /// <summary>
    /// Response that the system gives when a command can be associated to more than one action.
    /// <see href="https://w3id.org/todo/tododm#ActionOptionsResponse"></see></summary>
    let ActionOptionsResponse = _prefix "ActionOptionsResponse"
    /// <summary>
    /// Information that the system provides in response to a UserRequest or as a piece of information directed to the user without a prior UserRequest.
    /// <see href="https://w3id.org/todo/tododm#SystemResponse"></see></summary>
    let SystemResponse = _prefix "SystemResponse"

    /// <summary>
    ///   <see href="https://w3id.org/todo/tododm#AlternativeArgumentSuggestionRequest"></see>
    /// </summary>
    let AlternativeArgumentSuggestionRequest =
        _prefix "AlternativeArgumentSuggestionRequest"

    /// <summary>
    /// Request made to reassure the assignation of a value from the KEE to an Argument.
    /// <see href="https://w3id.org/todo/tododm#ArgumentAssignationRequest"></see></summary>
    let ArgumentAssignationRequest = _prefix "ArgumentAssignationRequest"
    /// <summary>
    /// Request that demands a specific characteristic of the argument. This request is used when the argument provided is too broad and the system needs some characteristic that allows determining the specific element the user is refering to.
    ///
    /// For example, the user would require a "piece", and the system includes data for 300 types of pieces.
    /// <see href="https://w3id.org/todo/tododm#ArgumentCharacteristicRequest"></see></summary>
    let ArgumentCharacteristicRequest = _prefix "ArgumentCharacteristicRequest"
    /// <summary>
    /// Request that asks for specific information, other than "Yes" or "No" (and equivalents).
    ///
    /// Also known as "Non polar/Open question" in linguistics.
    /// <see href="https://w3id.org/todo/tododm#ContentRequest"></see></summary>
    let ContentRequest = _prefix "ContentRequest"
    /// <summary>
    /// Request that asks the user for some clarification for the value of an argument when a previously saved value generates too many options.
    /// <see href="https://w3id.org/todo/tododm#ArgumentClarificationRequest"></see></summary>
    let ArgumentClarificationRequest = _prefix "ArgumentClarificationRequest"
    /// <summary>
    /// Response that gives details about an Argument. For example, when the user does not understand what information conveys said Argument.
    /// <see href="https://w3id.org/todo/tododm#ArgumentExplanationResponse"></see></summary>
    let ArgumentExplanationResponse = _prefix "ArgumentExplanationResponse"
    /// <summary>
    /// This would imply an ArgumentRequest.
    /// The system informs the user the Argument value provided is not valid according to what has been modelled in the KB.
    /// <see href="https://w3id.org/todo/tododm#ArgumentNotCompatibleResponse"></see></summary>
    let ArgumentNotCompatibleResponse = _prefix "ArgumentNotCompatibleResponse"
    /// <summary>
    /// Request that requires the user to repeat some information.
    /// <see href="https://w3id.org/todo/tododm#VerifyInfoRequest"></see></summary>
    let VerifyInfoRequest = _prefix "VerifyInfoRequest"
    /// <summary>
    /// Response given when the system has not been able to guess the value of the Argument through its characteristics.
    /// This would imply an ArgumentRequest/ArgumentCharacteristicRequest
    /// <see href="https://w3id.org/todo/tododm#ArgumentNotGuessedResponse"></see></summary>
    let ArgumentNotGuessedResponse = _prefix "ArgumentNotGuessedResponse"
    /// <summary>
    /// Request that demands for the value of an Argument.
    /// <see href="https://w3id.org/todo/tododm#ArgumentRequest"></see></summary>
    let ArgumentRequest = _prefix "ArgumentRequest"
    /// <summary>
    /// Response in which the system tells the user that it has several options for an Argument.
    /// <see href="https://w3id.org/todo/tododm#ArgumentOptionsAvailable"></see></summary>
    let ArgumentOptionsAvailable = _prefix "ArgumentOptionsAvailable"
    /// <summary>
    /// Request made when a value for an Argument can belong to different Arguments. The strategy is asking for each Argument option until the user confirms.
    /// <see href="https://w3id.org/todo/tododm#ArgumentSpecifyRequest"></see></summary>
    let ArgumentSpecifyRequest = _prefix "ArgumentSpecifyRequest"
    /// <summary>
    /// Response that the system gives when an item can be associated to more than one argument.
    /// <see href="https://w3id.org/todo/tododm#ArgumentOptionsResponse"></see></summary>
    let ArgumentOptionsResponse = _prefix "ArgumentOptionsResponse"

    /// <summary>
    /// Request that tries to obtain the value of the argument when it is ambiguous (e.g. "sala" may apply to "sala Ura", "sala Sua", etc.).
    /// <see href="https://w3id.org/todo/tododm#ArgumentValueDisambiguationRequest"></see></summary>
    let ArgumentValueDisambiguationRequest =
        _prefix "ArgumentValueDisambiguationRequest"

    /// <summary>
    /// Response in which the system tells the user that it has several options for an argument value.
    /// <see href="https://w3id.org/todo/tododm#ArgumentValueOptionsAvailable"></see></summary>
    let ArgumentValueOptionsAvailable = _prefix "ArgumentValueOptionsAvailable"
    /// <summary>
    /// Response that the system gives when it cannot associate an action/target to one or more actions.
    /// <see href="https://w3id.org/todo/tododm#CannotResolveActionResponse"></see></summary>
    let CannotResolveActionResponse = _prefix "CannotResolveActionResponse"
    /// <summary>
    /// Request to the user to provide their (initial) command.
    /// <see href="https://w3id.org/todo/tododm#UserCommandRequest"></see></summary>
    let UserCommandRequest = _prefix "UserCommandRequest"
    /// <summary>
    /// Response that informs the user that the command could not be resolved.
    ///
    /// [to be followed by an ArgRequest]
    /// <see href="https://w3id.org/todo/tododm#CannotResolveCommandResponse"></see></summary>
    let CannotResolveCommandResponse = _prefix "CannotResolveCommandResponse"
    /// <summary>
    /// Step Function associated to a ContentRequest.
    /// <see href="https://w3id.org/todo/tododm#ContentRequestStepFunction"></see></summary>
    let ContentRequestStepFunction = _prefix "ContentRequestStepFunction"
    /// <summary>
    /// Establishes the StepFunction corresponding to a SystemRequest or a ProcessStep.
    /// <see href="https://w3id.org/todo/tododm#hasStepFunction"></see></summary>
    let hasStepFunction = _prefix "hasStepFunction"
    /// <summary>
    /// Act in which the system requires user input.
    /// <see href="https://w3id.org/todo/tododm#SystemRequest"></see></summary>
    let SystemRequest = _prefix "SystemRequest"
    /// <summary>
    /// "I think I haven't understood. Can you be more specific?
    /// Reponse given to the user when the UserResponse is a YesNoResponse and the SystemRequest requires a ContentResponse.
    /// <see href="https://w3id.org/todo/tododm#YesNoResponseNotExpected"></see></summary>
    let YesNoResponseNotExpected = _prefix "YesNoResponseNotExpected"
    /// <summary>
    /// Establishes the implications of an incorrect UserResponseType (e.g. when the request requires Yes/No as response and the user provides a ContentResponse).
    /// <see href="https://w3id.org/todo/tododm#incorrectUserResponseTypeImplies"></see></summary>
    let incorrectUserResponseTypeImplies = _prefix "incorrectUserResponseTypeImplies"
    /// <summary>
    /// Establishes the SystemRequest or a ProcessStep corresponding to a StepFunction.
    /// <see href="https://w3id.org/todo/tododm#isStepFunctionOf"></see></summary>
    let isStepFunctionOf = _prefix "isStepFunctionOf"
    /// <summary>
    /// Response that informs the user that the system has not understood the user command.
    /// <see href="https://w3id.org/todo/tododm#NotUnderstoodResponse"></see></summary>
    let NotUnderstoodResponse = _prefix "NotUnderstoodResponse"
    /// <summary>
    /// Establishes the implications when the system does not understand a UserResponse.
    /// <see href="https://w3id.org/todo/tododm#userResponseNotUnderstoodImplies"></see></summary>
    let userResponseNotUnderstoodImplies = _prefix "userResponseNotUnderstoodImplies"
    /// <summary>
    /// Element that is linked to a function in the Dialogue Manager code. This element also determines the implications of the output of said function in the code.
    /// <see href="https://w3id.org/todo/tododm#StepFunction"></see></summary>
    let StepFunction = _prefix "StepFunction"
    /// <summary>
    /// "You only need me to tell me yes or no, please"
    /// Reponse given to the user when the UserResponse is a ContentResponse and the SystemRequest requires a YesNoResponse.
    /// <see href="https://w3id.org/todo/tododm#ContentResponseNotExpected"></see></summary>
    let ContentResponseNotExpected = _prefix "ContentResponseNotExpected"
    /// <summary>
    /// Reponse given to the user when the UserResponse does not correspond with the expected response of the SystemRequest.
    /// <see href="https://w3id.org/todo/tododm#ResponseTypeNotExpectedResponse"></see></summary>
    let ResponseTypeNotExpectedResponse = _prefix "ResponseTypeNotExpectedResponse"
    /// <summary>
    /// Marker that conveys the idea of continuing with the dialogue process.
    /// <see href="https://w3id.org/todo/tododm#Continue"></see></summary>
    let Continue = _prefix "Continue"
    /// <summary>
    /// Elements that correspond to predefined or generic actions in dialogue control.
    /// <see href="https://w3id.org/todo/tododm#DialogueControlMarker"></see></summary>
    let DialogueControlMarker = _prefix "DialogueControlMarker"
    /// <summary>
    /// Unique identification value for individuals.
    /// <see href="https://w3id.org/todo/tododm#IDval"></see></summary>
    let IDval = _prefix "IDval"
    /// <summary>
    /// Response given by the system when the dialogue process has finished (i.e., when the user confirms the action and argument values)
    /// <see href="https://w3id.org/todo/tododm#DialogueFinished"></see></summary>
    let DialogueFinished = _prefix "DialogueFinished"
    /// <summary>
    /// Step in the dialogue process that requires a system interaction with the user (SystemStep).
    /// <see href="https://w3id.org/todo/tododm#DialogueStep"></see></summary>
    let DialogueStep = _prefix "DialogueStep"
    /// <summary>
    /// Step performed by the system in order to request information to the user or simply outputting information.
    /// <see href="https://w3id.org/todo/tododm#SystemStep"></see></summary>
    let SystemStep = _prefix "SystemStep"
    /// <summary>
    /// Establishes the SystemRequest/Response that initiates a DialogueStep.
    /// <see href="https://w3id.org/todo/tododm#initiatedBy"></see></summary>
    let initiatedBy = _prefix "initiatedBy"
    /// <summary>
    /// Sets the order for StepFunctions/DialogueSteps.
    /// <see href="https://w3id.org/todo/tododm#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// Step in the dialogue process that does not require a system interaction with the user (SystemStep).
    /// <see href="https://w3id.org/todo/tododm#ProcessStep"></see></summary>
    let ProcessStep = _prefix "ProcessStep"
    /// <summary>
    /// Marker that establishes that the dialogue must be finished.
    /// <see href="https://w3id.org/todo/tododm#FinishDial"></see></summary>
    let FinishDial = _prefix "FinishDial"
    /// <summary>
    /// Welcome message.
    /// <see href="https://w3id.org/todo/tododm#GreetingResponse"></see></summary>
    let GreetingResponse = _prefix "GreetingResponse"
    /// <summary>
    /// Request that checks which is the Argument/Action that has not been interpreter correctly, after a negative ReassureFeedbackRequest.
    /// <see href="https://w3id.org/todo/tododm#IncorrectArgumentRequest"></see></summary>
    let IncorrectArgumentRequest = _prefix "IncorrectArgumentRequest"
    /// <summary>
    /// Request made when a UserRequest can belong to different Intents. The strategy is asking for each Intent option until the user confirms.
    /// <see href="https://w3id.org/todo/tododm#IntentRequest"></see></summary>
    let IntentRequest = _prefix "IntentRequest"
    /// <summary>
    /// The item {item} is not compatible with any argument for this action.
    /// The system informs the user the Item value provided is not compatible with any action argument, according to what has been modelled in the KB.
    /// <see href="https://w3id.org/todo/tododm#ItemNotCompatibleAnyArgResponse"></see></summary>
    let ItemNotCompatibleAnyArgResponse = _prefix "ItemNotCompatibleAnyArgResponse"
    /// <summary>
    /// Response that is given when, after checking if all the core Arguments have been provided by the user command, there are core Arguments that are missing.
    /// <see href="https://w3id.org/todo/tododm#MissingInformationResponse"></see></summary>
    let MissingInformationResponse = _prefix "MissingInformationResponse"
    /// <summary>
    /// Request that asks the user whether they want to initiate a new dialogue process.
    /// <see href="https://w3id.org/todo/tododm#NewDialogue"></see></summary>
    let NewDialogue = _prefix "NewDialogue"
    /// <summary>
    /// Response that the system displays when it runs out of options. It is intended to continue with a full request of the element that the previous options corresponded to.
    /// <see href="https://w3id.org/todo/tododm#NoMoreOptionsContinueResponse"></see></summary>
    let NoMoreOptionsContinueResponse = _prefix "NoMoreOptionsContinueResponse"
    /// <summary>
    /// Response that the system displays when it runs out of options. It finishes the current Dialogue.
    /// <see href="https://w3id.org/todo/tododm#NoMoreOptionsRestartResponse"></see></summary>
    let NoMoreOptionsRestartResponse = _prefix "NoMoreOptionsRestartResponse"
    /// <summary>
    /// Response that the system returns when the clarification step of the value of an Argument does not return any results.
    /// <see href="https://w3id.org/todo/tododm#NoResultsClarificationResponse"></see></summary>
    let NoResultsClarificationResponse = _prefix "NoResultsClarificationResponse"
    /// <summary>
    /// Request that demands the user to repeat the value of an Argument.
    /// <see href="https://w3id.org/todo/tododm#RepeatArgumentRequest"></see></summary>
    let RepeatArgumentRequest = _prefix "RepeatArgumentRequest"
    /// <summary>
    /// Step Function associated to a ProcessStep.
    /// <see href="https://w3id.org/todo/tododm#ProcessStepStepFunction"></see></summary>
    let ProcessStepStepFunction = _prefix "ProcessStepStepFunction"
    /// <summary>
    /// Request that is sent in order to obtain feedback whether the interpretation obtained is correct or not.
    /// <see href="https://w3id.org/todo/tododm#ReassureFeedbackRequest"></see></summary>
    let ReassureFeedbackRequest = _prefix "ReassureFeedbackRequest"
    /// <summary>
    /// Marker that requires the dialogue to restart.
    /// <see href="https://w3id.org/todo/tododm#Restart"></see></summary>
    let Restart = _prefix "Restart"
    /// <summary>
    /// Marker that returns to the last SystemResponse+Request/SystemRequest performed.
    /// <see href="https://w3id.org/todo/tododm#Return"></see></summary>
    let Return = _prefix "Return"
    /// <summary>
    /// String to be output by the system in order to communicate a SystemRequest/Response to the user.
    /// <see href="https://w3id.org/todo/tododm#outputSentence"></see></summary>
    let outputSentence = _prefix "outputSentence"
    /// <summary>
    /// Response given when the number of possible Actions is too big.
    /// <see href="https://w3id.org/todo/tododm#TooManyActionOptionsResponse"></see></summary>
    let TooManyActionOptionsResponse = _prefix "TooManyActionOptionsResponse"
    /// <summary>
    /// Response given when the alternatives (in general) are too big.
    /// <see href="https://w3id.org/todo/tododm#TooManyAlternativesResponse"></see></summary>
    let TooManyAlternativesResponse = _prefix "TooManyAlternativesResponse"
    /// <summary>
    ///   <see href="https://w3id.org/todo/tododm#TooManyArgumentOptionsResponse"></see>
    /// </summary>
    let TooManyArgumentOptionsResponse = _prefix "TooManyArgumentOptionsResponse"

    /// <summary>
    /// Response given when the number of possible World Elements is too big.
    /// <see href="https://w3id.org/todo/tododm#TooManyWorldElementOptionsResponse"></see></summary>
    let TooManyWorldElementOptionsResponse =
        _prefix "TooManyWorldElementOptionsResponse"

    /// <summary>
    /// Response given by the system to reassure the user that it has understood the request.
    /// <see href="https://w3id.org/todo/tododm#UnderstoodResponse"></see></summary>
    let UnderstoodResponse = _prefix "UnderstoodResponse"

    /// <summary>
    /// Response given when the ArgValue for an Argument provided by the user is not compatible with said Argument.
    /// <see href="https://w3id.org/todo/tododm#ValueNotCompatibleWithArgumentResponse"></see></summary>
    let ValueNotCompatibleWithArgumentResponse =
        _prefix "ValueNotCompatibleWithArgumentResponse"

    /// <summary>
    /// Step Function associated to a YesNoRequest.
    /// <see href="https://w3id.org/todo/tododm#YesNoRequestStepFunction"></see></summary>
    let YesNoRequestStepFunction = _prefix "YesNoRequestStepFunction"
    /// <summary>
    /// Establishes the SystemRequest that requires a given UserResponse type.
    /// <see href="https://w3id.org/todo/tododm#isRequiredBy"></see></summary>
    let isRequiredBy = _prefix "isRequiredBy"
    /// <summary>
    /// Establishes the type of UserResponse required by a SystemRequest.
    /// <see href="https://w3id.org/todo/tododm#requires"></see></summary>
    let requires = _prefix "requires"
    /// <summary>
    /// Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output and the length of the output is smaller than the number of maximum results previously defined.
    /// <see href="https://w3id.org/todo/tododm#lessMaxOptionsImplies"></see></summary>
    let lessMaxOptionsImplies = _prefix "lessMaxOptionsImplies"
    /// <summary>
    /// Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output.
    /// <see href="https://w3id.org/todo/tododm#multipleOptionsImplies"></see></summary>
    let multipleOptionsImplies = _prefix "multipleOptionsImplies"
    /// <summary>
    /// Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output and the length of the output is higher than the number of maximum results previously defined.
    /// <see href="https://w3id.org/todo/tododm#moreMaxOptionsImplies"></see></summary>
    let moreMaxOptionsImplies = _prefix "moreMaxOptionsImplies"
    /// <summary>
    /// Establishes the implications when a StepFunction, in the Dialogue Manager code, returns no results as output.
    /// <see href="https://w3id.org/todo/tododm#noOptionsImplies"></see></summary>
    let noOptionsImplies = _prefix "noOptionsImplies"
    /// <summary>
    /// Establishes the implications of a negative UserResponse.
    /// <see href="https://w3id.org/todo/tododm#noUserResponseTypeImplies"></see></summary>
    let noUserResponseTypeImplies = _prefix "noUserResponseTypeImplies"
    /// <summary>
    /// Establishes the implications when a StepFunction, in the Dialogue Manager code, returns one result as output.
    /// <see href="https://w3id.org/todo/tododm#singleOptionImplies"></see></summary>
    let singleOptionImplies = _prefix "singleOptionImplies"
    /// <summary>
    /// Establishes the implications of a positive UserResponse.
    /// <see href="https://w3id.org/todo/tododm#yesUserResponseTypeImplies"></see></summary>
    let yesUserResponseTypeImplies = _prefix "yesUserResponseTypeImplies"
