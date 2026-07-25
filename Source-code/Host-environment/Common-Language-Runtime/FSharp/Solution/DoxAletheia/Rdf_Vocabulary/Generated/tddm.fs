namespace https.w3id.org.todo.tododm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tddm =
    let _namespace_iri = Namespace_Iri tddm |> NamespaceIRI
    /// <summary>
    ///   <para>tddm:YesNoRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request the response of which is expected to be limited to "Yes" or "No" (and equivalents).
    ///
    /// Also known as "Polar question" in linguistics.</para>
    /// labels<para>YesNoRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#YesNoRequest">https://w3id.org/todo/tododm#YesNoRequest</seealso>
    let YesNoRequest = Prefixed_Name(tddm, "YesNoRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ActionOptionsResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response that the system gives when a command can be associated to more than one action.</para>
    /// labels<para>ActionOptionsResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ActionOptionsResponse">https://w3id.org/todo/tododm#ActionOptionsResponse</seealso>
    let ActionOptionsResponse =
        Prefixed_Name(tddm, "ActionOptionsResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:SystemResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information that the system provides in response to a UserRequest or as a piece of information directed to the user without a prior UserRequest.</para>
    /// labels<para>SystemResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#SystemResponse">https://w3id.org/todo/tododm#SystemResponse</seealso>
    let SystemResponse = Prefixed_Name(tddm, "SystemResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:AlternativeArgumentSuggestionRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that arises when the system has not been able to obtain an argument through an item + complement. The system suggests an alternative that contains the complement in the request.</para>
    /// labels<para>AlternativeArgumentSuggestionRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#AlternativeArgumentSuggestionRequest">https://w3id.org/todo/tododm#AlternativeArgumentSuggestionRequest</seealso>
    let AlternativeArgumentSuggestionRequest =
        Prefixed_Name(tddm, "AlternativeArgumentSuggestionRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentAssignationRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request made to reassure the assignation of a value from the KEE to an Argument.</para>
    /// labels<para>ArgumentAssignationRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentAssignationRequest">https://w3id.org/todo/tododm#ArgumentAssignationRequest</seealso>
    let ArgumentAssignationRequest =
        Prefixed_Name(tddm, "ArgumentAssignationRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentCharacteristicRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that demands a specific characteristic of the argument. This request is used when the argument provided is too broad and the system needs some characteristic that allows determining the specific element the user is refering to.
    ///
    /// For example, the user would require a "piece", and the system includes data for 300 types of pieces.</para>
    /// labels<para>ArgumentCharacteristicRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentCharacteristicRequest">https://w3id.org/todo/tododm#ArgumentCharacteristicRequest</seealso>
    let ArgumentCharacteristicRequest =
        Prefixed_Name(tddm, "ArgumentCharacteristicRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentClarificationRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that asks the user for some clarification for the value of an argument when a previously saved value generates too many options.</para>
    /// labels<para>ArgumentClarificationRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentClarificationRequest">https://w3id.org/todo/tododm#ArgumentClarificationRequest</seealso>
    let ArgumentClarificationRequest =
        Prefixed_Name(tddm, "ArgumentClarificationRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentExplanationResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response that gives details about an Argument. For example, when the user does not understand what information conveys said Argument.</para>
    /// labels<para>ArgumentExplanationResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentExplanationResponse">https://w3id.org/todo/tododm#ArgumentExplanationResponse</seealso>
    let ArgumentExplanationResponse =
        Prefixed_Name(tddm, "ArgumentExplanationResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentNotCompatibleResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This would imply an ArgumentRequest.</para>
    ///   <para>The system informs the user the Argument value provided is not valid according to what has been modelled in the KB.</para>
    /// labels<para>ArgumentNotCompatibleResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentNotCompatibleResponse">https://w3id.org/todo/tododm#ArgumentNotCompatibleResponse</seealso>
    let ArgumentNotCompatibleResponse =
        Prefixed_Name(tddm, "ArgumentNotCompatibleResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentNotGuessedResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This would imply an ArgumentRequest/ArgumentCharacteristicRequest</para>
    ///   <para>Response given when the system has not been able to guess the value of the Argument through its characteristics.</para>
    /// labels<para>ArgumentNotGuessedResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentNotGuessedResponse">https://w3id.org/todo/tododm#ArgumentNotGuessedResponse</seealso>
    let ArgumentNotGuessedResponse =
        Prefixed_Name(tddm, "ArgumentNotGuessedResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:VerifyInfoRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that requires the user to repeat some information.</para>
    /// labels<para>VerifyInfoRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#VerifyInfoRequest">https://w3id.org/todo/tododm#VerifyInfoRequest</seealso>
    let VerifyInfoRequest = Prefixed_Name(tddm, "VerifyInfoRequest") |> PrefixedName
    /// <summary>
    ///   <para>tddm:ArgumentRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that demands for the value of an Argument.</para>
    /// labels<para>ArgumentRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentRequest">https://w3id.org/todo/tododm#ArgumentRequest</seealso>
    let ArgumentRequest = Prefixed_Name(tddm, "ArgumentRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentSpecifyRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request made when a value for an Argument can belong to different Arguments. The strategy is asking for each Argument option until the user confirms.</para>
    /// labels<para>ArgumentSpecifyRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentSpecifyRequest">https://w3id.org/todo/tododm#ArgumentSpecifyRequest</seealso>
    let ArgumentSpecifyRequest =
        Prefixed_Name(tddm, "ArgumentSpecifyRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentOptionsResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response that the system gives when an item can be associated to more than one argument.</para>
    /// labels<para>ArgumentOptionsResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentOptionsResponse">https://w3id.org/todo/tododm#ArgumentOptionsResponse</seealso>
    let ArgumentOptionsResponse =
        Prefixed_Name(tddm, "ArgumentOptionsResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentValueDisambiguationRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that tries to obtain the value of the argument when it is ambiguous (e.g. "sala" may apply to "sala Ura", "sala Sua", etc.).</para>
    /// labels<para>ArgumentValueDisambiguationRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentValueDisambiguationRequest">https://w3id.org/todo/tododm#ArgumentValueDisambiguationRequest</seealso>
    let ArgumentValueDisambiguationRequest =
        Prefixed_Name(tddm, "ArgumentValueDisambiguationRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:lessMaxOptionsImplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output and the length of the output is smaller than the number of maximum results previously defined.</para>
    /// labels<para>lessMaxOptionsImplies</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#lessMaxOptionsImplies">https://w3id.org/todo/tododm#lessMaxOptionsImplies</seealso>
    let lessMaxOptionsImplies =
        Prefixed_Name(tddm, "lessMaxOptionsImplies") |> PrefixedName

    /// <summary>
    ///   <para>tddm:noOptionsImplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the implications when a StepFunction, in the Dialogue Manager code, returns no results as output.</para>
    /// labels<para>noOptionsImplies</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#noOptionsImplies">https://w3id.org/todo/tododm#noOptionsImplies</seealso>
    let noOptionsImplies = Prefixed_Name(tddm, "noOptionsImplies") |> PrefixedName

    /// <summary>
    ///   <para>tddm:noUserResponseTypeImplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the implications of a negative UserResponse.</para>
    /// labels<para>noUserResponseTypeImplies</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#noUserResponseTypeImplies">https://w3id.org/todo/tododm#noUserResponseTypeImplies</seealso>
    let noUserResponseTypeImplies =
        Prefixed_Name(tddm, "noUserResponseTypeImplies") |> PrefixedName

    /// <summary>
    ///   <para>tddm:isRequiredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the SystemRequest that requires a given UserResponse type.</para>
    /// labels<para>isRequiredBy</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#isRequiredBy">https://w3id.org/todo/tododm#isRequiredBy</seealso>
    let isRequiredBy = Prefixed_Name(tddm, "isRequiredBy") |> PrefixedName
    /// <summary>
    ///   <para>tddm:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the type of UserResponse required by a SystemRequest.</para>
    /// labels<para>requires</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#requires">https://w3id.org/todo/tododm#requires</seealso>
    let requires = Prefixed_Name(tddm, "requires") |> PrefixedName

    /// <summary>
    ///   <para>tddm:multipleOptionsImplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output.</para>
    /// labels<para>multipleOptionsImplies</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#multipleOptionsImplies">https://w3id.org/todo/tododm#multipleOptionsImplies</seealso>
    let multipleOptionsImplies =
        Prefixed_Name(tddm, "multipleOptionsImplies") |> PrefixedName

    /// <summary>
    ///   <para>tddm:moreMaxOptionsImplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output and the length of the output is higher than the number of maximum results previously defined.</para>
    /// labels<para>moreMaxOptionsImplies</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#moreMaxOptionsImplies">https://w3id.org/todo/tododm#moreMaxOptionsImplies</seealso>
    let moreMaxOptionsImplies =
        Prefixed_Name(tddm, "moreMaxOptionsImplies") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ActionOptionsAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response in which the system tells the user that it has several options for an Action.</para>
    /// labels<para>ActionOptionsAvailable</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ActionOptionsAvailable">https://w3id.org/todo/tododm#ActionOptionsAvailable</seealso>
    let ActionOptionsAvailable =
        Prefixed_Name(tddm, "ActionOptionsAvailable") |> PrefixedName

    /// <summary>
    ///   <para>tddm:OptionsAvailableResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response in which the system tells the user that it has several options for a specific element (e.g. WorldElement).
    ///
    /// Note the difference between OptionsAvailableResponse and TooManyAlternativesResponse: the first implies that there is a fair amount of options, whereas the latter implies that the options that are available are too many and it will require the user to be more specific.</para>
    /// labels<para>OptionsAvailableResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#OptionsAvailableResponse">https://w3id.org/todo/tododm#OptionsAvailableResponse</seealso>
    let OptionsAvailableResponse =
        Prefixed_Name(tddm, "OptionsAvailableResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ActionDisambiguationRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that makes the user choose from a set of Actions obtained through inference.</para>
    /// labels<para>ActionDisambiguationRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ActionDisambiguationRequest">https://w3id.org/todo/tododm#ActionDisambiguationRequest</seealso>
    let ActionDisambiguationRequest =
        Prefixed_Name(tddm, "ActionDisambiguationRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:implies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the implications of the output of a StepFunction in the Dialogue Manager code.</para>
    /// labels<para>implies</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#implies">https://w3id.org/todo/tododm#implies</seealso>
    let implies = Prefixed_Name(tddm, "implies") |> PrefixedName
    /// <summary>
    ///   <para>tddm:ProcessStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Step in the dialogue process that does not require a system interaction with the user (SystemStep).</para>
    /// labels<para>ProcessStep</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ProcessStep">https://w3id.org/todo/tododm#ProcessStep</seealso>
    let ProcessStep = Prefixed_Name(tddm, "ProcessStep") |> PrefixedName
    /// <summary>
    ///   <para>tddm:GreetingResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Welcome message.</para>
    /// labels<para>GreetingResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#GreetingResponse">https://w3id.org/todo/tododm#GreetingResponse</seealso>
    let GreetingResponse = Prefixed_Name(tddm, "GreetingResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:IncorrectArgumentRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that checks which is the Argument/Action that has not been interpreter correctly, after a negative ReassureFeedbackRequest.</para>
    /// labels<para>IncorrectArgumentRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#IncorrectArgumentRequest">https://w3id.org/todo/tododm#IncorrectArgumentRequest</seealso>
    let IncorrectArgumentRequest =
        Prefixed_Name(tddm, "IncorrectArgumentRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ItemNotCompatibleAnyArgResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The item {item} is not compatible with any argument for this action.</para>
    ///   <para>El item {item} no es compatible con ningún argumento de la acción.</para>
    ///   <para>The system informs the user the Item value provided is not compatible with any action argument, according to what has been modelled in the KB.</para>
    /// labels<para>ItemNotCompatibleAnyArgResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ItemNotCompatibleAnyArgResponse">https://w3id.org/todo/tododm#ItemNotCompatibleAnyArgResponse</seealso>
    let ItemNotCompatibleAnyArgResponse =
        Prefixed_Name(tddm, "ItemNotCompatibleAnyArgResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:MissingInformationResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response that is given when, after checking if all the core Arguments have been provided by the user command, there are core Arguments that are missing.</para>
    /// labels<para>MissingInformationResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#MissingInformationResponse">https://w3id.org/todo/tododm#MissingInformationResponse</seealso>
    let MissingInformationResponse =
        Prefixed_Name(tddm, "MissingInformationResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:initiatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the SystemRequest/Response that initiates a DialogueStep.</para>
    /// labels<para>initiatedBy</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#initiatedBy">https://w3id.org/todo/tododm#initiatedBy</seealso>
    let initiatedBy = Prefixed_Name(tddm, "initiatedBy") |> PrefixedName

    /// <summary>
    ///   <para>tddm:NoMoreOptionsRestartResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response that the system displays when it runs out of options. It finishes the current Dialogue.</para>
    /// labels<para>NoMoreOptionsRestartResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#NoMoreOptionsRestartResponse">https://w3id.org/todo/tododm#NoMoreOptionsRestartResponse</seealso>
    let NoMoreOptionsRestartResponse =
        Prefixed_Name(tddm, "NoMoreOptionsRestartResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:NoResultsClarificationResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response that the system returns when the clarification step of the value of an Argument does not return any results.</para>
    /// labels<para>NoResultsClarificationResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#NoResultsClarificationResponse">https://w3id.org/todo/tododm#NoResultsClarificationResponse</seealso>
    let NoResultsClarificationResponse =
        Prefixed_Name(tddm, "NoResultsClarificationResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:RepeatArgumentRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that demands the user to repeat the value of an Argument.</para>
    /// labels<para>RepeatArgumentRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#RepeatArgumentRequest">https://w3id.org/todo/tododm#RepeatArgumentRequest</seealso>
    let RepeatArgumentRequest =
        Prefixed_Name(tddm, "RepeatArgumentRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ContentRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that asks for specific information, other than "Yes" or "No" (and equivalents).
    ///
    /// Also known as "Non polar/Open question" in linguistics.</para>
    /// labels<para>ContentRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ContentRequest">https://w3id.org/todo/tododm#ContentRequest</seealso>
    let ContentRequest = Prefixed_Name(tddm, "ContentRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentOptionsAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response in which the system tells the user that it has several options for an Argument.</para>
    /// labels<para>ArgumentOptionsAvailable</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentOptionsAvailable">https://w3id.org/todo/tododm#ArgumentOptionsAvailable</seealso>
    let ArgumentOptionsAvailable =
        Prefixed_Name(tddm, "ArgumentOptionsAvailable") |> PrefixedName

    /// <summary>
    ///   <para>tddm:UnderstoodResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response given by the system to reassure the user that it has understood the request.</para>
    /// labels<para>UnderstoodResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#UnderstoodResponse">https://w3id.org/todo/tododm#UnderstoodResponse</seealso>
    let UnderstoodResponse = Prefixed_Name(tddm, "UnderstoodResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ValueNotCompatibleWithArgumentResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response given when the ArgValue for an Argument provided by the user is not compatible with said Argument.</para>
    /// labels<para>ValueNotCompatibleWithArgumentResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ValueNotCompatibleWithArgumentResponse">https://w3id.org/todo/tododm#ValueNotCompatibleWithArgumentResponse</seealso>
    let ValueNotCompatibleWithArgumentResponse =
        Prefixed_Name(tddm, "ValueNotCompatibleWithArgumentResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ProcessStepStepFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Step Function associated to a ProcessStep.</para>
    /// labels<para>ProcessStepStepFunction</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ProcessStepStepFunction">https://w3id.org/todo/tododm#ProcessStepStepFunction</seealso>
    let ProcessStepStepFunction =
        Prefixed_Name(tddm, "ProcessStepStepFunction") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ReassureFeedbackRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that is sent in order to obtain feedback whether the interpretation obtained is correct or not.</para>
    /// labels<para>ReassureFeedbackRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ReassureFeedbackRequest">https://w3id.org/todo/tododm#ReassureFeedbackRequest</seealso>
    let ReassureFeedbackRequest =
        Prefixed_Name(tddm, "ReassureFeedbackRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:Restart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Marker that requires the dialogue to restart.</para>
    /// labels<para>Restart</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#Restart">https://w3id.org/todo/tododm#Restart</seealso>
    let Restart = Prefixed_Name(tddm, "Restart") |> PrefixedName
    /// <summary>
    ///   <para>tddm:Return</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Marker that returns to the last SystemResponse+Request/SystemRequest performed.</para>
    /// labels<para>Return</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#Return">https://w3id.org/todo/tododm#Return</seealso>
    let Return = Prefixed_Name(tddm, "Return") |> PrefixedName
    /// <summary>
    ///   <para>tddm:outputSentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String to be output by the system in order to communicate a SystemRequest/Response to the user.</para>
    /// labels<para>outputSentence</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#outputSentence">https://w3id.org/todo/tododm#outputSentence</seealso>
    let outputSentence = Prefixed_Name(tddm, "outputSentence") |> PrefixedName

    /// <summary>
    ///   <para>tddm:TooManyActionOptionsResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response given when the number of possible Actions is too big.</para>
    /// labels<para>TooManyActionOptionsResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#TooManyActionOptionsResponse">https://w3id.org/todo/tododm#TooManyActionOptionsResponse</seealso>
    let TooManyActionOptionsResponse =
        Prefixed_Name(tddm, "TooManyActionOptionsResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:TooManyAlternativesResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response given when the alternatives (in general) are too big.</para>
    /// labels<para>TooManyAlternativesResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#TooManyAlternativesResponse">https://w3id.org/todo/tododm#TooManyAlternativesResponse</seealso>
    let TooManyAlternativesResponse =
        Prefixed_Name(tddm, "TooManyAlternativesResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:TooManyArgumentOptionsResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>TooManyArgumentOptionsResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#TooManyArgumentOptionsResponse">https://w3id.org/todo/tododm#TooManyArgumentOptionsResponse</seealso>
    let TooManyArgumentOptionsResponse =
        Prefixed_Name(tddm, "TooManyArgumentOptionsResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:TooManyWorldElementOptionsResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response given when the number of possible World Elements is too big.</para>
    /// labels<para>TooManyWorldElementOptionsResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#TooManyWorldElementOptionsResponse">https://w3id.org/todo/tododm#TooManyWorldElementOptionsResponse</seealso>
    let TooManyWorldElementOptionsResponse =
        Prefixed_Name(tddm, "TooManyWorldElementOptionsResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:YesNoRequestStepFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Step Function associated to a YesNoRequest.</para>
    /// labels<para>YesNoRequestStepFunction</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#YesNoRequestStepFunction">https://w3id.org/todo/tododm#YesNoRequestStepFunction</seealso>
    let YesNoRequestStepFunction =
        Prefixed_Name(tddm, "YesNoRequestStepFunction") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ArgumentValueOptionsAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response in which the system tells the user that it has several options for an argument value.</para>
    /// labels<para>ArgumentValueOptionsAvailable</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ArgumentValueOptionsAvailable">https://w3id.org/todo/tododm#ArgumentValueOptionsAvailable</seealso>
    let ArgumentValueOptionsAvailable =
        Prefixed_Name(tddm, "ArgumentValueOptionsAvailable") |> PrefixedName

    /// <summary>
    ///   <para>tddm:CannotResolveActionResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response that the system gives when it cannot associate an action/target to one or more actions.</para>
    /// labels<para>CannotResolveActionResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#CannotResolveActionResponse">https://w3id.org/todo/tododm#CannotResolveActionResponse</seealso>
    let CannotResolveActionResponse =
        Prefixed_Name(tddm, "CannotResolveActionResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:CannotResolveCommandResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response that informs the user that the command could not be resolved.
    ///
    /// [to be followed by an ArgRequest]</para>
    /// labels<para>CannotResolveCommandResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#CannotResolveCommandResponse">https://w3id.org/todo/tododm#CannotResolveCommandResponse</seealso>
    let CannotResolveCommandResponse =
        Prefixed_Name(tddm, "CannotResolveCommandResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:singleOptionImplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the implications when a StepFunction, in the Dialogue Manager code, returns one result as output.</para>
    /// labels<para>singleOptionImplies</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#singleOptionImplies">https://w3id.org/todo/tododm#singleOptionImplies</seealso>
    let singleOptionImplies = Prefixed_Name(tddm, "singleOptionImplies") |> PrefixedName

    /// <summary>
    ///   <para>tddm:yesUserResponseTypeImplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the implications of a positive UserResponse.</para>
    /// labels<para>YesUserResponseImplies</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#yesUserResponseTypeImplies">https://w3id.org/todo/tododm#yesUserResponseTypeImplies</seealso>
    let yesUserResponseTypeImplies =
        Prefixed_Name(tddm, "yesUserResponseTypeImplies") |> PrefixedName

    /// <summary>
    ///   <para>tddm:UserCommandRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request to the user to provide their (initial) command.</para>
    /// labels<para>UserCommandRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#UserCommandRequest">https://w3id.org/todo/tododm#UserCommandRequest</seealso>
    let UserCommandRequest = Prefixed_Name(tddm, "UserCommandRequest") |> PrefixedName
    /// <summary>
    ///   <para>tddm:hasStepFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the StepFunction corresponding to a SystemRequest or a ProcessStep.</para>
    /// labels<para>hasStepFunction</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#hasStepFunction">https://w3id.org/todo/tododm#hasStepFunction</seealso>
    let hasStepFunction = Prefixed_Name(tddm, "hasStepFunction") |> PrefixedName
    /// <summary>
    ///   <para>tddm:SystemRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Act in which the system requires user input.</para>
    /// labels<para>SystemRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#SystemRequest">https://w3id.org/todo/tododm#SystemRequest</seealso>
    let SystemRequest = Prefixed_Name(tddm, "SystemRequest") |> PrefixedName

    /// <summary>
    ///   <para>tddm:YesNoResponseNotExpected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Creo que no te he entendido. ¿Puedes ser un poco más concreto con tu respuesta?"</para>
    ///   <para>"I think I haven't understood. Can you be more specific?</para>
    ///   <para>Reponse given to the user when the UserResponse is a YesNoResponse and the SystemRequest requires a ContentResponse.</para>
    /// labels<para>YesNoResponseNotExpected</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#YesNoResponseNotExpected">https://w3id.org/todo/tododm#YesNoResponseNotExpected</seealso>
    let YesNoResponseNotExpected =
        Prefixed_Name(tddm, "YesNoResponseNotExpected") |> PrefixedName

    /// <summary>
    ///   <para>tddm:incorrectUserResponseTypeImplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the implications of an incorrect UserResponseType (e.g. when the request requires Yes/No as response and the user provides a ContentResponse).</para>
    /// labels<para>incorrectUserResponseTypeImplies</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#incorrectUserResponseTypeImplies">https://w3id.org/todo/tododm#incorrectUserResponseTypeImplies</seealso>
    let incorrectUserResponseTypeImplies =
        Prefixed_Name(tddm, "incorrectUserResponseTypeImplies") |> PrefixedName

    /// <summary>
    ///   <para>tddm:StepFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Element that is linked to a function in the Dialogue Manager code. This element also determines the implications of the output of said function in the code.</para>
    /// labels<para>StepFunction</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#StepFunction">https://w3id.org/todo/tododm#StepFunction</seealso>
    let StepFunction = Prefixed_Name(tddm, "StepFunction") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ContentResponseNotExpected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reponse given to the user when the UserResponse is a ContentResponse and the SystemRequest requires a YesNoResponse.</para>
    ///   <para>"You only need me to tell me yes or no, please"</para>
    ///   <para>"Solo necesito que me digas sí o no, por favor"</para>
    /// labels<para>ContentResponseNotExpected</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ContentResponseNotExpected">https://w3id.org/todo/tododm#ContentResponseNotExpected</seealso>
    let ContentResponseNotExpected =
        Prefixed_Name(tddm, "ContentResponseNotExpected") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ResponseTypeNotExpectedResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reponse given to the user when the UserResponse does not correspond with the expected response of the SystemRequest.</para>
    /// labels<para>ResponseTypeNotExpectedResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ResponseTypeNotExpectedResponse">https://w3id.org/todo/tododm#ResponseTypeNotExpectedResponse</seealso>
    let ResponseTypeNotExpectedResponse =
        Prefixed_Name(tddm, "ResponseTypeNotExpectedResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:DialogueControlMarker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Elements that correspond to predefined or generic actions in dialogue control.</para>
    /// labels<para>DialogueControlMarkers</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#DialogueControlMarker">https://w3id.org/todo/tododm#DialogueControlMarker</seealso>
    let DialogueControlMarker =
        Prefixed_Name(tddm, "DialogueControlMarker") |> PrefixedName

    /// <summary>
    ///   <para>tddm:DialogueFinished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response given by the system when the dialogue process has finished (i.e., when the user confirms the action and argument values)</para>
    /// labels<para>DialogueFinished</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#DialogueFinished">https://w3id.org/todo/tododm#DialogueFinished</seealso>
    let DialogueFinished = Prefixed_Name(tddm, "DialogueFinished") |> PrefixedName
    /// <summary>
    ///   <para>tddm:Continue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Marker that conveys the idea of continuing with the dialogue process.</para>
    /// labels<para>Continue</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#Continue">https://w3id.org/todo/tododm#Continue</seealso>
    let Continue = Prefixed_Name(tddm, "Continue") |> PrefixedName
    /// <summary>
    ///   <para>tddm:IDval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique identification value for individuals.</para>
    /// labels<para>IDval</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#IDval">https://w3id.org/todo/tododm#IDval</seealso>
    let IDval = Prefixed_Name(tddm, "IDval") |> PrefixedName
    /// <summary>
    ///   <para>tddm:DialogueStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Step in the dialogue process that requires a system interaction with the user (SystemStep).</para>
    /// labels<para>DialogueStep</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#DialogueStep">https://w3id.org/todo/tododm#DialogueStep</seealso>
    let DialogueStep = Prefixed_Name(tddm, "DialogueStep") |> PrefixedName
    /// <summary>
    ///   <para>tddm:SystemStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Step performed by the system in order to request information to the user or simply outputting information.</para>
    /// labels<para>SystemStep</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#SystemStep">https://w3id.org/todo/tododm#SystemStep</seealso>
    let SystemStep = Prefixed_Name(tddm, "SystemStep") |> PrefixedName
    /// <summary>
    ///   <para>tddm:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Sets the order for StepFunctions/DialogueSteps.</para>
    /// labels<para>order</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#order">https://w3id.org/todo/tododm#order</seealso>
    let order = Prefixed_Name(tddm, "order") |> PrefixedName
    /// <summary>
    ///   <para>tddm:FinishDial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Marker that establishes that the dialogue must be finished.</para>
    /// labels<para>FinishDial</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#FinishDial">https://w3id.org/todo/tododm#FinishDial</seealso>
    let FinishDial = Prefixed_Name(tddm, "FinishDial") |> PrefixedName
    /// <summary>
    ///   <para>tddm:IntentRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request made when a UserRequest can belong to different Intents. The strategy is asking for each Intent option until the user confirms.</para>
    /// labels<para>IntentRequest</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#IntentRequest">https://w3id.org/todo/tododm#IntentRequest</seealso>
    let IntentRequest = Prefixed_Name(tddm, "IntentRequest") |> PrefixedName
    /// <summary>
    ///   <para>tddm:NewDialogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Request that asks the user whether they want to initiate a new dialogue process.</para>
    /// labels<para>NewDialogue</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#NewDialogue">https://w3id.org/todo/tododm#NewDialogue</seealso>
    let NewDialogue = Prefixed_Name(tddm, "NewDialogue") |> PrefixedName

    /// <summary>
    ///   <para>tddm:NoMoreOptionsContinueResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response that the system displays when it runs out of options. It is intended to continue with a full request of the element that the previous options corresponded to.</para>
    /// labels<para>NoMoreOptionsContinueResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#NoMoreOptionsContinueResponse">https://w3id.org/todo/tododm#NoMoreOptionsContinueResponse</seealso>
    let NoMoreOptionsContinueResponse =
        Prefixed_Name(tddm, "NoMoreOptionsContinueResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:ContentRequestStepFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Step Function associated to a ContentRequest.</para>
    /// labels<para>ContentRequestStepFunction</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#ContentRequestStepFunction">https://w3id.org/todo/tododm#ContentRequestStepFunction</seealso>
    let ContentRequestStepFunction =
        Prefixed_Name(tddm, "ContentRequestStepFunction") |> PrefixedName

    /// <summary>
    ///   <para>tddm:isStepFunctionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the SystemRequest or a ProcessStep corresponding to a StepFunction.</para>
    /// labels<para>isStepFunctionOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#isStepFunctionOf">https://w3id.org/todo/tododm#isStepFunctionOf</seealso>
    let isStepFunctionOf = Prefixed_Name(tddm, "isStepFunctionOf") |> PrefixedName

    /// <summary>
    ///   <para>tddm:NotUnderstoodResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response that informs the user that the system has not understood the user command.</para>
    /// labels<para>NotUnderstoodResponse</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#NotUnderstoodResponse">https://w3id.org/todo/tododm#NotUnderstoodResponse</seealso>
    let NotUnderstoodResponse =
        Prefixed_Name(tddm, "NotUnderstoodResponse") |> PrefixedName

    /// <summary>
    ///   <para>tddm:userResponseNotUnderstoodImplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the implications when the system does not understand a UserResponse.</para>
    /// labels<para>userResponseNotUnderstoodImplies</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododm#userResponseNotUnderstoodImplies">https://w3id.org/todo/tododm#userResponseNotUnderstoodImplies</seealso>
    let userResponseNotUnderstoodImplies =
        Prefixed_Name(tddm, "userResponseNotUnderstoodImplies") |> PrefixedName
