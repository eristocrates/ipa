#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tddm =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododm#" "tddm"
    /// <summary>
    ///   <para>skos:example : [Previous SysResp: "I couldn't resolve the action from your request".]
    /// "Do you want to {ActionTag}?
    ///
    /// "Do you want to {go somewhere}?skos:example : [Previous SysResp: "No he podido resolver la acción a partir de tu petición"]
    ///
    /// "¿Quieres {ActionTag}?
    ///
    /// "¿Quieres {que te lleve a algún sitio}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ActionDisambiguationRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that makes the user choose from a set of Actions obtained through inference.</para>
    ///   <a href="https://w3id.org/todo/tododm#ActionDisambiguationRequest">tddm:ActionDisambiguationRequest</a>
    /// </summary>
    let ActionDisambiguationRequest = _prefixId.prefix "ActionDisambiguationRequest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ActionOptionsAvailable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response in which the system tells the user that it has several options for an Action.</para>
    ///   <a href="https://w3id.org/todo/tododm#ActionOptionsAvailable">tddm:ActionOptionsAvailable</a>
    /// </summary>
    let ActionOptionsAvailable = _prefixId.prefix "ActionOptionsAvailable"
    /// <summary>
    ///   <para>skos:example : Your command can be associated to many actions!skos:example : ¡El comando puede asociarse a varias acciones!</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ActionOptionsResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that the system gives when a command can be associated to more than one action.</para>
    ///   <a href="https://w3id.org/todo/tododm#ActionOptionsResponse">tddm:ActionOptionsResponse</a>
    /// </summary>
    let ActionOptionsResponse = _prefixId.prefix "ActionOptionsResponse"

    /// <summary>
    ///   <para>skos:example : Request: "Llévame a un laboratorio con micrófono".
    ///
    /// "No encuentro ningún/a {Item} con {Complement} como {argumentTag}, pero puedo sugerir {IDval_AlternativeItem}, que sí que tiene. ¿Le llevo ahí?"
    ///
    /// "No encuentro ningún/a {laboratorio} con {micrófono} como {el destino al que quiere que le lleve}, pero puedo sugerir {sala de reunión 1}, que sí que tiene. ¿Le llevo ahí?"skos:example : Request: "Take me to a laboratory with microphone".
    ///
    /// "I cannot find any {Item} with {Complement} as {ArgumentTag}, but I can suggest {IDval_AlternativeItem}, which it does have it. Do you want me to take you there?"
    ///
    /// "I cannot find any {laboratory} with {microphone} as {the destination you want to go}, but I can suggest {meeting room 1}, which it does have it. Do you want me to take you there?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : AlternativeArgumentSuggestionRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that arises when the system has not been able to obtain an argument through an item + complement. The system suggests an alternative that contains the complement in the request.</para>
    ///   <a href="https://w3id.org/todo/tododm#AlternativeArgumentSuggestionRequest">tddm:AlternativeArgumentSuggestionRequest</a>
    /// </summary>
    let AlternativeArgumentSuggestionRequest =
        _prefixId.prefix "AlternativeArgumentSuggestionRequest"

    /// <summary>
    ///   <para>skos:example : "El {Argument} es el {Argument_value}, ¿verdad?"
    ///
    /// "El Destino es el "Auditorio", ¿verdad?"skos:example : The {Argument} is {Argument_value}, isn't it?
    ///
    /// "The Destination is "Auditorium", isn't it?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentAssignationRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request made to reassure the assignation of a value from the KEE to an Argument.</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentAssignationRequest">tddm:ArgumentAssignationRequest</a>
    /// </summary>
    let ArgumentAssignationRequest = _prefixId.prefix "ArgumentAssignationRequest"
    /// <summary>
    ///   <para>skos:example : "Which {characteristic} is {too_broad_argument}?"
    ///
    /// "Which {colour} is (the) {piece}?"skos:example : "¿De qué {characteristic} es {too_broad_argument}?
    ///
    /// "¿De qué {color} es (la) {pieza}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentCharacteristicRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that demands a specific characteristic of the argument. This request is used when the argument provided is too broad and the system needs some characteristic that allows determining the specific element the user is refering to.
    ///
    /// For example, the user would require a "piece", and the system includes data for 300 types of pieces.</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentCharacteristicRequest">tddm:ArgumentCharacteristicRequest</a>
    /// </summary>
    let ArgumentCharacteristicRequest = _prefixId.prefix "ArgumentCharacteristicRequest"
    /// <summary>
    ///   <para>skos:example : "Could you please be more specific with {ArgTag}?"
    ///
    /// "Could you please be more specific with {the destination you want me to take you}?"skos:example : "¿Puedes ser un poco más específico con el {ArgTag}?"
    ///
    /// "¿Puedes ser un poco más específico con el {destino al que quieres que te guíe}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentClarificationRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that asks the user for some clarification for the value of an argument when a previously saved value generates too many options.</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentClarificationRequest">tddm:ArgumentClarificationRequest</a>
    /// </summary>
    let ArgumentClarificationRequest = _prefixId.prefix "ArgumentClarificationRequest"
    /// <summary>
    ///   <para>skos:example : "El {Argument} corresponde a{ArgDescription}"
    ///
    /// "El {Error} corresponde a{l número de error que aparece en la máquina}"skos:example : "The {Argument} corresponds to {ArgDescription}"
    ///
    /// "The {Error} corresponds to {the ID of the error that appears in the machine}"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentExplanationResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that gives details about an Argument. For example, when the user does not understand what information conveys said Argument.</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentExplanationResponse">tddm:ArgumentExplanationResponse</a>
    /// </summary>
    let ArgumentExplanationResponse = _prefixId.prefix "ArgumentExplanationResponse"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : This would imply an ArgumentRequest.rdfs:comment : The system informs the user the Argument value provided is not valid according to what has been modelled in the KB.</para>
    ///   <para>skos:example : "{ArgumentValue} cannot be the {Argument}."
    ///
    /// "{Toilet} cannot be the {Error}."skos:example : "{ArgumentValue} no puede ser {Argument}."
    ///
    /// "{Baño} no puede ser {Error}."</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentNotCompatibleResponse^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentNotCompatibleResponse">tddm:ArgumentNotCompatibleResponse</a>
    /// </summary>
    let ArgumentNotCompatibleResponse = _prefixId.prefix "ArgumentNotCompatibleResponse"
    /// <summary>
    ///   <para>skos:example : "I cannot guess the {Argument} with the information you provided."
    ///
    /// "I cannot guess the {Error} with the information you provided."skos:example : "Con las características que me has dado, no he podido averiguar el {Argument}."
    ///
    /// "Con las características que me has dado, no he podido averiguar el {Error}."</para>
    ///   <para>rdfs:comment : Response given when the system has not been able to guess the value of the Argument through its characteristics.rdfs:comment : This would imply an ArgumentRequest/ArgumentCharacteristicRequest</para>
    ///   <para>rdfs:label : ArgumentNotGuessedResponse^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentNotGuessedResponse">tddm:ArgumentNotGuessedResponse</a>
    /// </summary>
    let ArgumentNotGuessedResponse = _prefixId.prefix "ArgumentNotGuessedResponse"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentOptionsAvailable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response in which the system tells the user that it has several options for an Argument.</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentOptionsAvailable">tddm:ArgumentOptionsAvailable</a>
    /// </summary>
    let ArgumentOptionsAvailable = _prefixId.prefix "ArgumentOptionsAvailable"
    /// <summary>
    ///   <para>skos:example : The item {item} can be associated to many arguments!skos:example : ¡El item {item} puede asociarse a varios argumentos!</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentOptionsResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that the system gives when an item can be associated to more than one argument.</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentOptionsResponse">tddm:ArgumentOptionsResponse</a>
    /// </summary>
    let ArgumentOptionsResponse = _prefixId.prefix "ArgumentOptionsResponse"
    /// <summary>
    ///   <para>skos:example : "Can you tell me the {argument}?
    ///
    /// "Can you tell me the {Destination}?"skos:example : "¿Puedes decirme el {argument}?"
    ///
    /// "¿Puedes decirme el {Destino}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that demands for the value of an Argument.</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentRequest">tddm:ArgumentRequest</a>
    /// </summary>
    let ArgumentRequest = _prefixId.prefix "ArgumentRequest"
    /// <summary>
    ///   <para>skos:example : [Situation: the value "Mesa de reparación" could be Origin or Destination]
    ///
    /// [Previous SysResponse: "¡Lo que me has dicho podría ser varias cosas!"]
    ///
    /// "¿Es {el lugar al que quieres que te lleve}?"
    ///
    /// "¿Es {Argument}?"skos:example : [Situation: the value "Repairing table" could be Origin or Destination]
    ///
    /// [Previous SysResponse: "What you told me could correspond to many elements!"]
    ///
    /// "Is it {the place you want me to take you}?"
    ///
    /// "Is it {Argument}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentSpecifyRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request made when a value for an Argument can belong to different Arguments. The strategy is asking for each Argument option until the user confirms.</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentSpecifyRequest">tddm:ArgumentSpecifyRequest</a>
    /// </summary>
    let ArgumentSpecifyRequest = _prefixId.prefix "ArgumentSpecifyRequest"

    /// <summary>
    ///   <para>skos:example : "Do you want {Action} {ArgumentConnector} {WorldElement}?"
    ///
    /// "Do you want {to go} {to} {Sala Ura}?"skos:example : "¿Quieres {Action} {ArgumentConnector} {WorldElement}?"
    ///
    /// "¿Quieres {que te guíe} {a} {Sala Ura}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentValueDisambiguationRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that tries to obtain the value of the argument when it is ambiguous (e.g. "sala" may apply to "sala Ura", "sala Sua", etc.).</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentValueDisambiguationRequest">tddm:ArgumentValueDisambiguationRequest</a>
    /// </summary>
    let ArgumentValueDisambiguationRequest =
        _prefixId.prefix "ArgumentValueDisambiguationRequest"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentValueOptionsAvailable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response in which the system tells the user that it has several options for an argument value.</para>
    ///   <a href="https://w3id.org/todo/tododm#ArgumentValueOptionsAvailable">tddm:ArgumentValueOptionsAvailable</a>
    /// </summary>
    let ArgumentValueOptionsAvailable = _prefixId.prefix "ArgumentValueOptionsAvailable"
    /// <summary>
    ///   <para>skos:example : I couldn't associate your command to an action. Can you please be more specific?skos:example : No he podido asociar tu comando a una acción. ¿Puedes repetir y ser más específico, por favor?</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : CannotResolveActionResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that the system gives when it cannot associate an action/target to one or more actions.</para>
    ///   <a href="https://w3id.org/todo/tododm#CannotResolveActionResponse">tddm:CannotResolveActionResponse</a>
    /// </summary>
    let CannotResolveActionResponse = _prefixId.prefix "CannotResolveActionResponse"
    /// <summary>
    ///   <para>skos:example : I could not resolve your command.skos:example : No he podido resolver tu petición.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : CannotResolveCommandResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that informs the user that the command could not be resolved.
    ///
    /// [to be followed by an ArgRequest]</para>
    ///   <a href="https://w3id.org/todo/tododm#CannotResolveCommandResponse">tddm:CannotResolveCommandResponse</a>
    /// </summary>
    let CannotResolveCommandResponse = _prefixId.prefix "CannotResolveCommandResponse"
    /// <summary>
    ///   <para>skos:example : Which is the error code?</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ContentRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that asks for specific information, other than "Yes" or "No" (and equivalents).
    ///
    /// Also known as "Non polar/Open question" in linguistics.</para>
    ///   <a href="https://w3id.org/todo/tododm#ContentRequest">tddm:ContentRequest</a>
    /// </summary>
    let ContentRequest = _prefixId.prefix "ContentRequest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ContentRequestStepFunction^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Step Function associated to a ContentRequest.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#ContentRequestStepFunction">tddm:ContentRequestStepFunction</a>
    /// </summary>
    let ContentRequestStepFunction = _prefixId.prefix "ContentRequestStepFunction"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ContentResponseNotExpected^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : "Solo necesito que me digas sí o no, por favor"rdfs:comment : "You only need me to tell me yes or no, please"rdfs:comment : Reponse given to the user when the UserResponse is a ContentResponse and the SystemRequest requires a YesNoResponse.</para>
    ///   <a href="https://w3id.org/todo/tododm#ContentResponseNotExpected">tddm:ContentResponseNotExpected</a>
    /// </summary>
    let ContentResponseNotExpected = _prefixId.prefix "ContentResponseNotExpected"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Continue^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Marker that conveys the idea of continuing with the dialogue process.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#Continue">tddm:Continue</a>
    /// </summary>
    let Continue = _prefixId.prefix "Continue"
    /// <summary>
    ///   <para>skos:example : Continue, restart dialogue^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : DialogueControlMarkers^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Elements that correspond to predefined or generic actions in dialogue control.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#DialogueControlMarker">tddm:DialogueControlMarker</a>
    /// </summary>
    let DialogueControlMarker = _prefixId.prefix "DialogueControlMarker"
    /// <summary>
    ///   <para>skos:example : Done!skos:example : ¡Listo!</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : DialogueFinished^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response given by the system when the dialogue process has finished (i.e., when the user confirms the action and argument values)^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#DialogueFinished">tddm:DialogueFinished</a>
    /// </summary>
    let DialogueFinished = _prefixId.prefix "DialogueFinished"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : DialogueStep^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Step in the dialogue process that requires a system interaction with the user (SystemStep).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#DialogueStep">tddm:DialogueStep</a>
    /// </summary>
    let DialogueStep = _prefixId.prefix "DialogueStep"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : FinishDial^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Marker that establishes that the dialogue must be finished.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#FinishDial">tddm:FinishDial</a>
    /// </summary>
    let FinishDial = _prefixId.prefix "FinishDial"
    /// <summary>
    ///   <para>skos:example : "Hi! I am {SystemName}. I am happy to help you."
    ///
    /// "Hi! I am {Teknibot}. I am happy to help you."skos:example : "¡Hola! Soy {SystemName}. Encantado de ayudarte."
    ///
    /// "¡Hola! Soy {Teknibot}. Encantado de ayudarte."</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : GreetingResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Welcome message.</para>
    ///   <a href="https://w3id.org/todo/tododm#GreetingResponse">tddm:GreetingResponse</a>
    /// </summary>
    let GreetingResponse = _prefixId.prefix "GreetingResponse"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : IDval^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Unique identification value for individuals.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#IDval">tddm:IDval</a>
    /// </summary>
    let IDval = _prefixId.prefix "IDval"
    /// <summary>
    ///   <para>skos:example : "Have I missed the {Argument}?"
    ///
    /// "Have I missed the {Origin}?"skos:example : "¿Me he equivocado con el {Argument}?"
    ///
    /// "¿Me he equivocado con el {Origen}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : IncorrectArgumentRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that checks which is the Argument/Action that has not been interpreter correctly, after a negative ReassureFeedbackRequest.</para>
    ///   <a href="https://w3id.org/todo/tododm#IncorrectArgumentRequest">tddm:IncorrectArgumentRequest</a>
    /// </summary>
    let IncorrectArgumentRequest = _prefixId.prefix "IncorrectArgumentRequest"
    /// <summary>
    ///   <para>skos:example : Situation: the Intent for the Request could be "Information" or "Guiding"
    ///
    /// "So many interpretations! See if you can help me! Do you need {Intent}?"
    /// "Then do you need {Intent}?
    ///
    ///
    /// SYS: "So many interpretations! See if you can help me! Do you need {Information}?"
    ///
    /// USR: "No"
    ///
    /// SYS: "Then do you need {Guiding}?
    ///
    /// USR: "Yes"skos:example : Situation: the intent for the Request could be "Information" or "Guiding"
    ///
    /// "¡Cuántas interpretaciones! ¡A ver si me puedes ayudar! ¿Quieres {Intent}?"
    /// "¿Entonces necesitas {Intent}?
    ///
    /// SYS: "¡Cuántas interpretaciones! ¡A ver si me puedes ayudar! ¿Quieres {que te dé información}?"
    ///
    /// USR: "No"
    ///
    /// SYS: "¿Entonces necesitas {que te lleve}?
    ///
    /// USR: "Sí"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : IntentRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request made when a UserRequest can belong to different Intents. The strategy is asking for each Intent option until the user confirms.</para>
    ///   <a href="https://w3id.org/todo/tododm#IntentRequest">tddm:IntentRequest</a>
    /// </summary>
    let IntentRequest = _prefixId.prefix "IntentRequest"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ItemNotCompatibleAnyArgResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : El item {item} no es compatible con ningún argumento de la acción.rdfs:comment : The item {item} is not compatible with any argument for this action.rdfs:comment : The system informs the user the Item value provided is not compatible with any action argument, according to what has been modelled in the KB.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#ItemNotCompatibleAnyArgResponse">tddm:ItemNotCompatibleAnyArgResponse</a>
    /// </summary>
    let ItemNotCompatibleAnyArgResponse =
        _prefixId.prefix "ItemNotCompatibleAnyArgResponse"

    /// <summary>
    ///   <para>skos:example : Hay información que me falta.skos:example : I still need some more information.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : MissingInformationResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that is given when, after checking if all the core Arguments have been provided by the user command, there are core Arguments that are missing.</para>
    ///   <a href="https://w3id.org/todo/tododm#MissingInformationResponse">tddm:MissingInformationResponse</a>
    /// </summary>
    let MissingInformationResponse = _prefixId.prefix "MissingInformationResponse"
    /// <summary>
    ///   <para>skos:example : Do you need anything else?skos:example : ¿Necesitas algo más?</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : NewDialogue^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that asks the user whether they want to initiate a new dialogue process.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#NewDialogue">tddm:NewDialogue</a>
    /// </summary>
    let NewDialogue = _prefixId.prefix "NewDialogue"
    /// <summary>
    ///   <para>skos:example : I do not have more options to offer you!skos:example : ¡No tengo más opciones que mostrarte!</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : NoMoreOptionsContinueResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that the system displays when it runs out of options. It is intended to continue with a full request of the element that the previous options corresponded to.</para>
    ///   <a href="https://w3id.org/todo/tododm#NoMoreOptionsContinueResponse">tddm:NoMoreOptionsContinueResponse</a>
    /// </summary>
    let NoMoreOptionsContinueResponse = _prefixId.prefix "NoMoreOptionsContinueResponse"
    /// <summary>
    ///   <para>skos:example : I do not have more options to offer you! Can you reformulate your command so I can understand better?skos:example : ¡No tengo más opciones que mostrarte! ¿Puedes reformular tu comando para que te entienda mejor?</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : NoMoreOptionsRestartResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that the system displays when it runs out of options. It finishes the current Dialogue.</para>
    ///   <a href="https://w3id.org/todo/tododm#NoMoreOptionsRestartResponse">tddm:NoMoreOptionsRestartResponse</a>
    /// </summary>
    let NoMoreOptionsRestartResponse = _prefixId.prefix "NoMoreOptionsRestartResponse"

    /// <summary>
    ///   <para>skos:example : I cannot find anything that corresponds to your demand.skos:example : No encuentro ningún elemento que responda a lo que me pides.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : NoResultsClarificationResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that the system returns when the clarification step of the value of an Argument does not return any results.</para>
    ///   <a href="https://w3id.org/todo/tododm#NoResultsClarificationResponse">tddm:NoResultsClarificationResponse</a>
    /// </summary>
    let NoResultsClarificationResponse =
        _prefixId.prefix "NoResultsClarificationResponse"

    /// <summary>
    ///   <para>skos:example : "I am sorry, but I haven't understood. Can you repeat, please?"skos:example : "Lo siento, no te he entendido. ¿Puedes repetir, por favor?</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : NotUnderstoodResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response that informs the user that the system has not understood the user command.</para>
    ///   <a href="https://w3id.org/todo/tododm#NotUnderstoodResponse">tddm:NotUnderstoodResponse</a>
    /// </summary>
    let NotUnderstoodResponse = _prefixId.prefix "NotUnderstoodResponse"
    /// <summary>
    ///   <para>skos:example : "I have many options for your request."skos:example : "Tengo varias opciones para tu comando."
    ///
    /// "¡Lo que me has dicho puede ser varias cosas!"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : OptionsAvailableResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response in which the system tells the user that it has several options for a specific element (e.g. WorldElement).
    ///
    /// Note the difference between OptionsAvailableResponse and TooManyAlternativesResponse: the first implies that there is a fair amount of options, whereas the latter implies that the options that are available are too many and it will require the user to be more specific.</para>
    ///   <a href="https://w3id.org/todo/tododm#OptionsAvailableResponse">tddm:OptionsAvailableResponse</a>
    /// </summary>
    let OptionsAvailableResponse = _prefixId.prefix "OptionsAvailableResponse"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ProcessStep^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Step in the dialogue process that does not require a system interaction with the user (SystemStep).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#ProcessStep">tddm:ProcessStep</a>
    /// </summary>
    let ProcessStep = _prefixId.prefix "ProcessStep"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ProcessStepStepFunction^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Step Function associated to a ProcessStep.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#ProcessStepStepFunction">tddm:ProcessStepStepFunction</a>
    /// </summary>
    let ProcessStepStepFunction = _prefixId.prefix "ProcessStepStepFunction"
    /// <summary>
    ///   <para>skos:example : "Entonces, quieres que {Action} {ArgumentConnector} {Argument}, ¿verdad?"
    ///
    /// "Entonces, quieres que {te lleve} {a} {l baño}, ¿verdad?"skos:example : "So, you want me {Action} {ArgumentConnector} {Argument}, right?"
    ///
    /// "So, you want me {to take you} {to} {the toilet}, right?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ReassureFeedbackRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that is sent in order to obtain feedback whether the interpretation obtained is correct or not.</para>
    ///   <a href="https://w3id.org/todo/tododm#ReassureFeedbackRequest">tddm:ReassureFeedbackRequest</a>
    /// </summary>
    let ReassureFeedbackRequest = _prefixId.prefix "ReassureFeedbackRequest"
    /// <summary>
    ///   <para>skos:example : "Can you repeat the {Argument}?
    ///
    /// "Can you repeat the {Destination}?"skos:example : "¿Puedes repetir el {argument}?"
    ///
    /// "¿Puedes repetir el {Destino}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : RepeatArgumentRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that demands the user to repeat the value of an Argument.</para>
    ///   <a href="https://w3id.org/todo/tododm#RepeatArgumentRequest">tddm:RepeatArgumentRequest</a>
    /// </summary>
    let RepeatArgumentRequest = _prefixId.prefix "RepeatArgumentRequest"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ResponseTypeNotExpectedResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Reponse given to the user when the UserResponse does not correspond with the expected response of the SystemRequest.</para>
    ///   <a href="https://w3id.org/todo/tododm#ResponseTypeNotExpectedResponse">tddm:ResponseTypeNotExpectedResponse</a>
    /// </summary>
    let ResponseTypeNotExpectedResponse =
        _prefixId.prefix "ResponseTypeNotExpectedResponse"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Restart^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Marker that requires the dialogue to restart.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#Restart">tddm:Restart</a>
    /// </summary>
    let Restart = _prefixId.prefix "Restart"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Return^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Marker that returns to the last SystemResponse+Request/SystemRequest performed.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#Return">tddm:Return</a>
    /// </summary>
    let Return = _prefixId.prefix "Return"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : StepFunction^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that is linked to a function in the Dialogue Manager code. This element also determines the implications of the output of said function in the code.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#StepFunction">tddm:StepFunction</a>
    /// </summary>
    let StepFunction = _prefixId.prefix "StepFunction"
    /// <summary>
    ///   <para>skos:example : Ask for missing information, ask for confirmation.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SystemRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Act in which the system requires user input.</para>
    ///   <a href="https://w3id.org/todo/tododm#SystemRequest">tddm:SystemRequest</a>
    /// </summary>
    let SystemRequest = _prefixId.prefix "SystemRequest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SystemResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Information that the system provides in response to a UserRequest or as a piece of information directed to the user without a prior UserRequest.</para>
    ///   <a href="https://w3id.org/todo/tododm#SystemResponse">tddm:SystemResponse</a>
    /// </summary>
    let SystemResponse = _prefixId.prefix "SystemResponse"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : SystemStep^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Step performed by the system in order to request information to the user or simply outputting information.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#SystemStep">tddm:SystemStep</a>
    /// </summary>
    let SystemStep = _prefixId.prefix "SystemStep"
    /// <summary>
    ///   <para>skos:example : Your command can be associated to too many actions! Can you repeat and be more specific, please?skos:example : ¡Tu comando se puede asociar a demasiadas acciones! ¿Puedes repetir y ser un poco más específico, por favor?</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TooManyActionOptionsResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response given when the number of possible Actions is too big.</para>
    ///   <a href="https://w3id.org/todo/tododm#TooManyActionOptionsResponse">tddm:TooManyActionOptionsResponse</a>
    /// </summary>
    let TooManyActionOptionsResponse = _prefixId.prefix "TooManyActionOptionsResponse"
    /// <summary>
    ///   <para>skos:example : "I have too many options taking into account the information you provided to me."
    ///
    /// "I have too many options taking into account the information you provided to me."skos:example : "Tengo demasiadas opciones con la información que me has dado."
    ///
    /// "Tengo demasiadas opciones con la información que me has dado."</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TooManyAlternativesResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response given when the alternatives (in general) are too big.</para>
    ///   <a href="https://w3id.org/todo/tododm#TooManyAlternativesResponse">tddm:TooManyAlternativesResponse</a>
    /// </summary>
    let TooManyAlternativesResponse = _prefixId.prefix "TooManyAlternativesResponse"

    /// <summary>
    ///   <para>skos:example : Response given when the number of possible Arguments is too big.skos:example : Your command can be associated to too many arguments! Can you repeat and be more specific, please?skos:example : ¡Tu comando se puede asociar a demasiados argumentos! ¿Puedes repetir y ser un poco más específico, por favor?</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TooManyArgumentOptionsResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#TooManyArgumentOptionsResponse">tddm:TooManyArgumentOptionsResponse</a>
    /// </summary>
    let TooManyArgumentOptionsResponse =
        _prefixId.prefix "TooManyArgumentOptionsResponse"

    /// <summary>
    ///   <para>skos:example : Your command can be associated to too many elements!skos:example : ¡Tu comando se puede asociar a demasiados elementos!</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : TooManyWorldElementOptionsResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response given when the number of possible World Elements is too big.</para>
    ///   <a href="https://w3id.org/todo/tododm#TooManyWorldElementOptionsResponse">tddm:TooManyWorldElementOptionsResponse</a>
    /// </summary>
    let TooManyWorldElementOptionsResponse =
        _prefixId.prefix "TooManyWorldElementOptionsResponse"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : UnderstoodResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response given by the system to reassure the user that it has understood the request.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#UnderstoodResponse">tddm:UnderstoodResponse</a>
    /// </summary>
    let UnderstoodResponse = _prefixId.prefix "UnderstoodResponse"
    /// <summary>
    ///   <para>skos:example : How can I help you?
    ///
    /// Tell me your command.skos:example : ¿En qué puedo ayudarte?
    ///
    /// Dame tu comando.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : UserCommandRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request to the user to provide their (initial) command.</para>
    ///   <a href="https://w3id.org/todo/tododm#UserCommandRequest">tddm:UserCommandRequest</a>
    /// </summary>
    let UserCommandRequest = _prefixId.prefix "UserCommandRequest"

    /// <summary>
    ///   <para>skos:example : "It cannot be the {Argument}".
    ///
    /// "It cannot be the {destination you want me to take you}".skos:example : "No puede ser {Argument}".
    ///
    /// "No puede ser {el lugar al que quieres que te lleve}".</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ValueNotCompatibleWithArgumentResponse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Response given when the ArgValue for an Argument provided by the user is not compatible with said Argument.</para>
    ///   <a href="https://w3id.org/todo/tododm#ValueNotCompatibleWithArgumentResponse">tddm:ValueNotCompatibleWithArgumentResponse</a>
    /// </summary>
    let ValueNotCompatibleWithArgumentResponse =
        _prefixId.prefix "ValueNotCompatibleWithArgumentResponse"

    /// <summary>
    ///   <para>skos:example : [Previous SysResponse: "This item cannot be {ArgTag}"]
    /// "Can you verify?"
    ///
    /// [Previous SysResponse: "This item cannot be {the destination}"]
    /// "Can you verify?"skos:example : [PreviousSysResponse: "Este elemento no puede ser {ArgTag}"]
    /// "¿Puedes verificarlo?"
    ///
    /// [PreviousSysResponse: "Este elemento no puede ser {el destino}"]
    /// "¿Puedes verificarlo?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : VerifyInfoRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request that requires the user to repeat some information.</para>
    ///   <a href="https://w3id.org/todo/tododm#VerifyInfoRequest">tddm:VerifyInfoRequest</a>
    /// </summary>
    let VerifyInfoRequest = _prefixId.prefix "VerifyInfoRequest"
    /// <summary>
    ///   <para>skos:example : Do you want to go to the laboratory?</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : YesNoRequest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Request the response of which is expected to be limited to "Yes" or "No" (and equivalents).
    ///
    /// Also known as "Polar question" in linguistics.</para>
    ///   <a href="https://w3id.org/todo/tododm#YesNoRequest">tddm:YesNoRequest</a>
    /// </summary>
    let YesNoRequest = _prefixId.prefix "YesNoRequest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : YesNoRequestStepFunction^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Step Function associated to a YesNoRequest.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#YesNoRequestStepFunction">tddm:YesNoRequestStepFunction</a>
    /// </summary>
    let YesNoRequestStepFunction = _prefixId.prefix "YesNoRequestStepFunction"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : YesNoResponseNotExpected^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : "Creo que no te he entendido. ¿Puedes ser un poco más concreto con tu respuesta?"rdfs:comment : "I think I haven't understood. Can you be more specific?rdfs:comment : Reponse given to the user when the UserResponse is a YesNoResponse and the SystemRequest requires a ContentResponse.</para>
    ///   <a href="https://w3id.org/todo/tododm#YesNoResponseNotExpected">tddm:YesNoResponseNotExpected</a>
    /// </summary>
    let YesNoResponseNotExpected = _prefixId.prefix "YesNoResponseNotExpected"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasStepFunction^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the StepFunction corresponding to a SystemRequest or a ProcessStep.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#hasStepFunction">tddm:hasStepFunction</a>
    /// </summary>
    let hasStepFunction = _prefixId.prefix "hasStepFunction"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : implies^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the implications of the output of a StepFunction in the Dialogue Manager code.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#implies">tddm:implies</a>
    /// </summary>
    let implies = _prefixId.prefix "implies"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : incorrectUserResponseTypeImplies^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the implications of an incorrect UserResponseType (e.g. when the request requires Yes/No as response and the user provides a ContentResponse).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#incorrectUserResponseTypeImplies">tddm:incorrectUserResponseTypeImplies</a>
    /// </summary>
    let incorrectUserResponseTypeImplies =
        _prefixId.prefix "incorrectUserResponseTypeImplies"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : initiatedBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the SystemRequest/Response that initiates a DialogueStep.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#initiatedBy">tddm:initiatedBy</a>
    /// </summary>
    let initiatedBy = _prefixId.prefix "initiatedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isRequiredBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the SystemRequest that requires a given UserResponse type.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#isRequiredBy">tddm:isRequiredBy</a>
    /// </summary>
    let isRequiredBy = _prefixId.prefix "isRequiredBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isStepFunctionOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the SystemRequest or a ProcessStep corresponding to a StepFunction.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#isStepFunctionOf">tddm:isStepFunctionOf</a>
    /// </summary>
    let isStepFunctionOf = _prefixId.prefix "isStepFunctionOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : lessMaxOptionsImplies^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output and the length of the output is smaller than the number of maximum results previously defined.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#lessMaxOptionsImplies">tddm:lessMaxOptionsImplies</a>
    /// </summary>
    let lessMaxOptionsImplies = _prefixId.prefix "lessMaxOptionsImplies"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : moreMaxOptionsImplies^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output and the length of the output is higher than the number of maximum results previously defined.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#moreMaxOptionsImplies">tddm:moreMaxOptionsImplies</a>
    /// </summary>
    let moreMaxOptionsImplies = _prefixId.prefix "moreMaxOptionsImplies"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : multipleOptionsImplies^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the implications when a StepFunction, in the Dialogue Manager code, returns more than one result as output.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#multipleOptionsImplies">tddm:multipleOptionsImplies</a>
    /// </summary>
    let multipleOptionsImplies = _prefixId.prefix "multipleOptionsImplies"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : noOptionsImplies^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the implications when a StepFunction, in the Dialogue Manager code, returns no results as output.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#noOptionsImplies">tddm:noOptionsImplies</a>
    /// </summary>
    let noOptionsImplies = _prefixId.prefix "noOptionsImplies"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : noUserResponseTypeImplies^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the implications of a negative UserResponse.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#noUserResponseTypeImplies">tddm:noUserResponseTypeImplies</a>
    /// </summary>
    let noUserResponseTypeImplies = _prefixId.prefix "noUserResponseTypeImplies"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : order^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Sets the order for StepFunctions/DialogueSteps.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#order">tddm:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : outputSentence^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : String to be output by the system in order to communicate a SystemRequest/Response to the user.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#outputSentence">tddm:outputSentence</a>
    /// </summary>
    let outputSentence = _prefixId.prefix "outputSentence"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : requires^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the type of UserResponse required by a SystemRequest.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#requires">tddm:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : singleOptionImplies^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the implications when a StepFunction, in the Dialogue Manager code, returns one result as output.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#singleOptionImplies">tddm:singleOptionImplies</a>
    /// </summary>
    let singleOptionImplies = _prefixId.prefix "singleOptionImplies"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : userResponseNotUnderstoodImplies^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the implications when the system does not understand a UserResponse.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#userResponseNotUnderstoodImplies">tddm:userResponseNotUnderstoodImplies</a>
    /// </summary>
    let userResponseNotUnderstoodImplies =
        _prefixId.prefix "userResponseNotUnderstoodImplies"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : YesUserResponseImplies^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododm#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the implications of a positive UserResponse.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododm#yesUserResponseTypeImplies">tddm:yesUserResponseTypeImplies</a>
    /// </summary>
    let yesUserResponseTypeImplies = _prefixId.prefix "yesUserResponseTypeImplies"
