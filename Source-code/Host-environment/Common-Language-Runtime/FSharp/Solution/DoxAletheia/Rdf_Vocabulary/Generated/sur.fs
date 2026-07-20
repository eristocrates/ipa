namespace https.w3id.org.survey_ontology.hash

open DoxAletheia

module sur =
    let _namespace_name = "https://w3id.org/survey-ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Answer"></see>
    /// </summary>
    let Answer = _prefix "Answer"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SurveyElement"></see>
    /// </summary>
    let SurveyElement = _prefix "SurveyElement"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Question"></see>
    /// </summary>
    let Question = _prefix "Question"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Talk"></see>
    /// </summary>
    let Talk = _prefix "Talk"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#CheckboxQuestion"></see>
    /// </summary>
    let CheckboxQuestion = _prefix "CheckboxQuestion"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#ClosedQuestion"></see>
    /// </summary>
    let ClosedQuestion = _prefix "ClosedQuestion"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#ClosedAnswer"></see>
    /// </summary>
    let ClosedAnswer = _prefix "ClosedAnswer"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#CompletedQuestion"></see>
    /// </summary>
    let CompletedQuestion = _prefix "CompletedQuestion"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#CompletedSurvey"></see>
    /// </summary>
    let CompletedSurvey = _prefix "CompletedSurvey"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Dropdown"></see>
    /// </summary>
    let Dropdown = _prefix "Dropdown"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#QuestionVisualization"></see>
    /// </summary>
    let QuestionVisualization = _prefix "QuestionVisualization"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Emoji"></see>
    /// </summary>
    let Emoji = _prefix "Emoji"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#LatentVariable"></see>
    /// </summary>
    let LatentVariable = _prefix "LatentVariable"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#MultipleChoiceQuestion"></see>
    /// </summary>
    let MultipleChoiceQuestion = _prefix "MultipleChoiceQuestion"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#MutipleInputQuestion"></see>
    /// </summary>
    let MutipleInputQuestion = _prefix "MutipleInputQuestion"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#OpenQuestion"></see>
    /// </summary>
    let OpenQuestion = _prefix "OpenQuestion"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#ObservableVariable"></see>
    /// </summary>
    let ObservableVariable = _prefix "ObservableVariable"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#OpenAnswer"></see>
    /// </summary>
    let OpenAnswer = _prefix "OpenAnswer"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Option"></see>
    /// </summary>
    let Option = _prefix "Option"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Participant"></see>
    /// </summary>
    let Participant = _prefix "Participant"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Scale"></see>
    /// </summary>
    let Scale = _prefix "Scale"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SingleInputQuestion"></see>
    /// </summary>
    let SingleInputQuestion = _prefix "SingleInputQuestion"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Slider"></see>
    /// </summary>
    let Slider = _prefix "Slider"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Survey"></see>
    /// </summary>
    let Survey = _prefix "Survey"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SurveyCompletionTask"></see>
    /// </summary>
    let SurveyCompletionTask = _prefix "SurveyCompletionTask"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SurveyDataSet"></see>
    /// </summary>
    let SurveyDataSet = _prefix "SurveyDataSet"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SurveyProcedure"></see>
    /// </summary>
    let SurveyProcedure = _prefix "SurveyProcedure"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SurveyTarget"></see>
    /// </summary>
    let SurveyTarget = _prefix "SurveyTarget"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#answeredIn"></see>
    /// </summary>
    let answeredIn = _prefix "answeredIn"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#completedFor"></see>
    /// </summary>
    let completedFor = _prefix "completedFor"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#completesQuestion"></see>
    /// </summary>
    let completesQuestion = _prefix "completesQuestion"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasAnswer"></see>
    /// </summary>
    let hasAnswer = _prefix "hasAnswer"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasAnswerText"></see>
    /// </summary>
    let hasAnswerText = _prefix "hasAnswerText"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasCompletionTimestamp"></see>
    /// </summary>
    let hasCompletionTimestamp = _prefix "hasCompletionTimestamp"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasLatentVariable"></see>
    /// </summary>
    let hasLatentVariable = _prefix "hasLatentVariable"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasLink"></see>
    /// </summary>
    let hasLink = _prefix "hasLink"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasObservableVariable"></see>
    /// </summary>
    let hasObservableVariable = _prefix "hasObservableVariable"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasOrderNumber"></see>
    /// </summary>
    let hasOrderNumber = _prefix "hasOrderNumber"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasPoints"></see>
    /// </summary>
    let hasPoints = _prefix "hasPoints"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasStatus"></see>
    /// </summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasText"></see>
    /// </summary>
    let hasText = _prefix "hasText"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasTitle"></see>
    /// </summary>
    let hasTitle = _prefix "hasTitle"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasVisualization"></see>
    /// </summary>
    let hasVisualization = _prefix "hasVisualization"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#inSurveyProcedure"></see>
    /// </summary>
    let inSurveyProcedure = _prefix "inSurveyProcedure"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#leadsTo"></see>
    /// </summary>
    let leadsTo = _prefix "leadsTo"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#participantId"></see>
    /// </summary>
    let participantId = _prefix "participantId"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#sessionId"></see>
    /// </summary>
    let sessionId = _prefix "sessionId"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#startsWith"></see>
    /// </summary>
    let startsWith = _prefix "startsWith"
