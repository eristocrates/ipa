namespace https.w3id.org.survey_ontology.hash

open DoxAletheia.Rdf_Vocabulary

module sur =
    let _namespace_name = "https://w3id.org/survey-ontology#"
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Answer"></see>
    /// </summary>
    let Answer = Namespaced_IRI.parse _namespace_name "Answer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SurveyElement"></see>
    /// </summary>
    let SurveyElement =
        Namespaced_IRI.parse _namespace_name "SurveyElement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Question"></see>
    /// </summary>
    let Question = Namespaced_IRI.parse _namespace_name "Question" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Talk"></see>
    /// </summary>
    let Talk = Namespaced_IRI.parse _namespace_name "Talk" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#CheckboxQuestion"></see>
    /// </summary>
    let CheckboxQuestion =
        Namespaced_IRI.parse _namespace_name "CheckboxQuestion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#ClosedQuestion"></see>
    /// </summary>
    let ClosedQuestion =
        Namespaced_IRI.parse _namespace_name "ClosedQuestion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#ClosedAnswer"></see>
    /// </summary>
    let ClosedAnswer =
        Namespaced_IRI.parse _namespace_name "ClosedAnswer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#CompletedQuestion"></see>
    /// </summary>
    let CompletedQuestion =
        Namespaced_IRI.parse _namespace_name "CompletedQuestion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#CompletedSurvey"></see>
    /// </summary>
    let CompletedSurvey =
        Namespaced_IRI.parse _namespace_name "CompletedSurvey" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Dropdown"></see>
    /// </summary>
    let Dropdown = Namespaced_IRI.parse _namespace_name "Dropdown" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#QuestionVisualization"></see>
    /// </summary>
    let QuestionVisualization =
        Namespaced_IRI.parse _namespace_name "QuestionVisualization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Emoji"></see>
    /// </summary>
    let Emoji = Namespaced_IRI.parse _namespace_name "Emoji" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#LatentVariable"></see>
    /// </summary>
    let LatentVariable =
        Namespaced_IRI.parse _namespace_name "LatentVariable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#MultipleChoiceQuestion"></see>
    /// </summary>
    let MultipleChoiceQuestion =
        Namespaced_IRI.parse _namespace_name "MultipleChoiceQuestion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#MutipleInputQuestion"></see>
    /// </summary>
    let MutipleInputQuestion =
        Namespaced_IRI.parse _namespace_name "MutipleInputQuestion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#OpenQuestion"></see>
    /// </summary>
    let OpenQuestion =
        Namespaced_IRI.parse _namespace_name "OpenQuestion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#ObservableVariable"></see>
    /// </summary>
    let ObservableVariable =
        Namespaced_IRI.parse _namespace_name "ObservableVariable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#OpenAnswer"></see>
    /// </summary>
    let OpenAnswer = Namespaced_IRI.parse _namespace_name "OpenAnswer" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Option"></see>
    /// </summary>
    let Option = Namespaced_IRI.parse _namespace_name "Option" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Participant"></see>
    /// </summary>
    let Participant =
        Namespaced_IRI.parse _namespace_name "Participant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Scale"></see>
    /// </summary>
    let Scale = Namespaced_IRI.parse _namespace_name "Scale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SingleInputQuestion"></see>
    /// </summary>
    let SingleInputQuestion =
        Namespaced_IRI.parse _namespace_name "SingleInputQuestion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Slider"></see>
    /// </summary>
    let Slider = Namespaced_IRI.parse _namespace_name "Slider" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#Survey"></see>
    /// </summary>
    let Survey = Namespaced_IRI.parse _namespace_name "Survey" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SurveyCompletionTask"></see>
    /// </summary>
    let SurveyCompletionTask =
        Namespaced_IRI.parse _namespace_name "SurveyCompletionTask" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SurveyDataSet"></see>
    /// </summary>
    let SurveyDataSet =
        Namespaced_IRI.parse _namespace_name "SurveyDataSet" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SurveyProcedure"></see>
    /// </summary>
    let SurveyProcedure =
        Namespaced_IRI.parse _namespace_name "SurveyProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#SurveyTarget"></see>
    /// </summary>
    let SurveyTarget =
        Namespaced_IRI.parse _namespace_name "SurveyTarget" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#answeredIn"></see>
    /// </summary>
    let answeredIn = Namespaced_IRI.parse _namespace_name "answeredIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#completedFor"></see>
    /// </summary>
    let completedFor =
        Namespaced_IRI.parse _namespace_name "completedFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#completesQuestion"></see>
    /// </summary>
    let completesQuestion =
        Namespaced_IRI.parse _namespace_name "completesQuestion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasAnswer"></see>
    /// </summary>
    let hasAnswer = Namespaced_IRI.parse _namespace_name "hasAnswer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasAnswerText"></see>
    /// </summary>
    let hasAnswerText =
        Namespaced_IRI.parse _namespace_name "hasAnswerText" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasCompletionTimestamp"></see>
    /// </summary>
    let hasCompletionTimestamp =
        Namespaced_IRI.parse _namespace_name "hasCompletionTimestamp" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasLatentVariable"></see>
    /// </summary>
    let hasLatentVariable =
        Namespaced_IRI.parse _namespace_name "hasLatentVariable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasLink"></see>
    /// </summary>
    let hasLink = Namespaced_IRI.parse _namespace_name "hasLink" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasObservableVariable"></see>
    /// </summary>
    let hasObservableVariable =
        Namespaced_IRI.parse _namespace_name "hasObservableVariable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasOrderNumber"></see>
    /// </summary>
    let hasOrderNumber =
        Namespaced_IRI.parse _namespace_name "hasOrderNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasPoints"></see>
    /// </summary>
    let hasPoints = Namespaced_IRI.parse _namespace_name "hasPoints" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasStatus"></see>
    /// </summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasText"></see>
    /// </summary>
    let hasText = Namespaced_IRI.parse _namespace_name "hasText" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasTitle"></see>
    /// </summary>
    let hasTitle = Namespaced_IRI.parse _namespace_name "hasTitle" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasValue"></see>
    /// </summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#hasVisualization"></see>
    /// </summary>
    let hasVisualization =
        Namespaced_IRI.parse _namespace_name "hasVisualization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#inSurveyProcedure"></see>
    /// </summary>
    let inSurveyProcedure =
        Namespaced_IRI.parse _namespace_name "inSurveyProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#leadsTo"></see>
    /// </summary>
    let leadsTo = Namespaced_IRI.parse _namespace_name "leadsTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#participantId"></see>
    /// </summary>
    let participantId =
        Namespaced_IRI.parse _namespace_name "participantId" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#sessionId"></see>
    /// </summary>
    let sessionId = Namespaced_IRI.parse _namespace_name "sessionId" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/survey-ontology#startsWith"></see>
    /// </summary>
    let startsWith = Namespaced_IRI.parse _namespace_name "startsWith" |> NamespacedName
