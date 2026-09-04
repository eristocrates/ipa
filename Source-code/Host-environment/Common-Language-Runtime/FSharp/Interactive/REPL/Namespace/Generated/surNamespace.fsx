#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sur =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/survey-ontology#" "sur"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Answer^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#Answer">sur:Answer</a>
    /// </summary>
    let Answer = _prefixId.prefix "Answer"
    /// <summary>
    ///   <para>rdfs:label : Checkbox Question^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#CheckboxQuestion">sur:CheckboxQuestion</a>
    /// </summary>
    let CheckboxQuestion = _prefixId.prefix "CheckboxQuestion"
    /// <summary>
    ///   <para>rdfs:label : Closed Answer^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#ClosedAnswer">sur:ClosedAnswer</a>
    /// </summary>
    let ClosedAnswer = _prefixId.prefix "ClosedAnswer"
    /// <summary>
    ///   <para>rdfs:label : Closed Question^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#ClosedQuestion">sur:ClosedQuestion</a>
    /// </summary>
    let ClosedQuestion = _prefixId.prefix "ClosedQuestion"
    /// <summary>
    ///   <para>rdfs:label : Completed Question^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#CompletedQuestion">sur:CompletedQuestion</a>
    /// </summary>
    let CompletedQuestion = _prefixId.prefix "CompletedQuestion"
    /// <summary>
    ///   <para>rdfs:label : Completed Survey^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#CompletedSurvey">sur:CompletedSurvey</a>
    /// </summary>
    let CompletedSurvey = _prefixId.prefix "CompletedSurvey"
    let Dropdown = _prefixId.prefix "Dropdown"
    let Emoji = _prefixId.prefix "Emoji"
    /// <summary>
    ///   <para>rdfs:label : Latent Variable^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#LatentVariable">sur:LatentVariable</a>
    /// </summary>
    let LatentVariable = _prefixId.prefix "LatentVariable"
    /// <summary>
    ///   <para>rdfs:label : Multiple Choice Question^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#MultipleChoiceQuestion">sur:MultipleChoiceQuestion</a>
    /// </summary>
    let MultipleChoiceQuestion = _prefixId.prefix "MultipleChoiceQuestion"
    /// <summary>
    ///   <para>rdfs:label : Multiple Input Question^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#MutipleInputQuestion">sur:MutipleInputQuestion</a>
    /// </summary>
    let MutipleInputQuestion = _prefixId.prefix "MutipleInputQuestion"
    /// <summary>
    ///   <para>rdfs:label : Observable Variable^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#ObservableVariable">sur:ObservableVariable</a>
    /// </summary>
    let ObservableVariable = _prefixId.prefix "ObservableVariable"
    /// <summary>
    ///   <para>rdfs:label : Open Answer^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#OpenAnswer">sur:OpenAnswer</a>
    /// </summary>
    let OpenAnswer = _prefixId.prefix "OpenAnswer"
    /// <summary>
    ///   <para>rdfs:label : Open Question^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#OpenQuestion">sur:OpenQuestion</a>
    /// </summary>
    let OpenQuestion = _prefixId.prefix "OpenQuestion"
    let Option = _prefixId.prefix "Option"
    /// <summary>
    ///   <para>rdfs:label : Participant^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#Participant">sur:Participant</a>
    /// </summary>
    let Participant = _prefixId.prefix "Participant"
    /// <summary>
    ///   <para>rdfs:label : Question^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#Question">sur:Question</a>
    /// </summary>
    let Question = _prefixId.prefix "Question"
    /// <summary>
    ///   <para>rdfs:label : Question Visualization^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#QuestionVisualization">sur:QuestionVisualization</a>
    /// </summary>
    let QuestionVisualization = _prefixId.prefix "QuestionVisualization"
    let Scale = _prefixId.prefix "Scale"
    /// <summary>
    ///   <para>rdfs:label : Single Input Question^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#SingleInputQuestion">sur:SingleInputQuestion</a>
    /// </summary>
    let SingleInputQuestion = _prefixId.prefix "SingleInputQuestion"
    let Slider = _prefixId.prefix "Slider"
    /// <summary>
    ///   <para>rdfs:label : Survey^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#Survey">sur:Survey</a>
    /// </summary>
    let Survey = _prefixId.prefix "Survey"
    /// <summary>
    ///   <para>rdfs:label : Survey Completion Task^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#SurveyCompletionTask">sur:SurveyCompletionTask</a>
    /// </summary>
    let SurveyCompletionTask = _prefixId.prefix "SurveyCompletionTask"
    /// <summary>
    ///   <para>rdfs:label : Survey Dataset^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#SurveyDataSet">sur:SurveyDataSet</a>
    /// </summary>
    let SurveyDataSet = _prefixId.prefix "SurveyDataSet"
    /// <summary>
    ///   <para>rdfs:label : Survey Element^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#SurveyElement">sur:SurveyElement</a>
    /// </summary>
    let SurveyElement = _prefixId.prefix "SurveyElement"
    /// <summary>
    ///   <para>rdfs:label : Survey Procedure^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#SurveyProcedure">sur:SurveyProcedure</a>
    /// </summary>
    let SurveyProcedure = _prefixId.prefix "SurveyProcedure"
    /// <summary>
    ///   <para>rdfs:label : Survey Target^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#SurveyTarget">sur:SurveyTarget</a>
    /// </summary>
    let SurveyTarget = _prefixId.prefix "SurveyTarget"
    /// <summary>
    ///   <para>rdfs:label : Talk^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#Talk">sur:Talk</a>
    /// </summary>
    let Talk = _prefixId.prefix "Talk"
    /// <summary>
    ///   <para>rdfs:label : answered in^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#answeredIn">sur:answeredIn</a>
    /// </summary>
    let answeredIn = _prefixId.prefix "answeredIn"
    /// <summary>
    ///   <para>rdfs:label : completed for^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#completedFor">sur:completedFor</a>
    /// </summary>
    let completedFor = _prefixId.prefix "completedFor"
    /// <summary>
    ///   <para>rdfs:label : completes question^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#completesQuestion">sur:completesQuestion</a>
    /// </summary>
    let completesQuestion = _prefixId.prefix "completesQuestion"
    /// <summary>
    ///   <para>rdfs:label : has answer^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasAnswer">sur:hasAnswer</a>
    /// </summary>
    let hasAnswer = _prefixId.prefix "hasAnswer"
    /// <summary>
    ///   <para>rdfs:label : has answer text^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasAnswerText">sur:hasAnswerText</a>
    /// </summary>
    let hasAnswerText = _prefixId.prefix "hasAnswerText"
    /// <summary>
    ///   <para>rdfs:label : has completion timestamp^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasCompletionTimestamp">sur:hasCompletionTimestamp</a>
    /// </summary>
    let hasCompletionTimestamp = _prefixId.prefix "hasCompletionTimestamp"
    /// <summary>
    ///   <para>rdfs:label : has latent variable^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasLatentVariable">sur:hasLatentVariable</a>
    /// </summary>
    let hasLatentVariable = _prefixId.prefix "hasLatentVariable"
    /// <summary>
    ///   <para>rdfs:label : has link^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasLink">sur:hasLink</a>
    /// </summary>
    let hasLink = _prefixId.prefix "hasLink"
    /// <summary>
    ///   <para>rdfs:label : has observable variable^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasObservableVariable">sur:hasObservableVariable</a>
    /// </summary>
    let hasObservableVariable = _prefixId.prefix "hasObservableVariable"
    /// <summary>
    ///   <para>rdfs:label : has order number^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasOrderNumber">sur:hasOrderNumber</a>
    /// </summary>
    let hasOrderNumber = _prefixId.prefix "hasOrderNumber"
    /// <summary>
    ///   <para>rdfs:label : has points^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasPoints">sur:hasPoints</a>
    /// </summary>
    let hasPoints = _prefixId.prefix "hasPoints"
    /// <summary>
    ///   <para>rdfs:label : has status^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasStatus">sur:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>rdfs:label : has text^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasText">sur:hasText</a>
    /// </summary>
    let hasText = _prefixId.prefix "hasText"
    /// <summary>
    ///   <para>rdfs:label : has title^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasTitle">sur:hasTitle</a>
    /// </summary>
    let hasTitle = _prefixId.prefix "hasTitle"
    /// <summary>
    ///   <para>rdfs:label : has value^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasValue">sur:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : has visualization^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#hasVisualization">sur:hasVisualization</a>
    /// </summary>
    let hasVisualization = _prefixId.prefix "hasVisualization"
    /// <summary>
    ///   <para>rdfs:label : in survey procedure^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#inSurveyProcedure">sur:inSurveyProcedure</a>
    /// </summary>
    let inSurveyProcedure = _prefixId.prefix "inSurveyProcedure"
    /// <summary>
    ///   <para>rdfs:label : leads to^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#leadsTo">sur:leadsTo</a>
    /// </summary>
    let leadsTo = _prefixId.prefix "leadsTo"
    /// <summary>
    ///   <para>rdfs:label : participant id^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#participantId">sur:participantId</a>
    /// </summary>
    let participantId = _prefixId.prefix "participantId"
    /// <summary>
    ///   <para>rdfs:label : session id^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#sessionId">sur:sessionId</a>
    /// </summary>
    let sessionId = _prefixId.prefix "sessionId"
    /// <summary>
    ///   <para>rdfs:label : starts with^^xsd:string</para>
    ///   <a href="https://w3id.org/survey-ontology#startsWith">sur:startsWith</a>
    /// </summary>
    let startsWith = _prefixId.prefix "startsWith"
