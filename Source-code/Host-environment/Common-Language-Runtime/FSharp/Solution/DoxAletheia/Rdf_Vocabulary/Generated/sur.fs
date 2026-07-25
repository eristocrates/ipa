namespace https.w3id.org.survey_ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sur =
    let _namespace_iri = Namespace_Iri sur |> NamespaceIRI
    /// <summary>
    ///   <para>sur:Answer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Answer</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Answer">https://w3id.org/survey-ontology#Answer</seealso>
    let Answer = Prefixed_Name(sur, "Answer") |> PrefixedName
    /// <summary>
    ///   <para>sur:ClosedQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Closed Question</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#ClosedQuestion">https://w3id.org/survey-ontology#ClosedQuestion</seealso>
    let ClosedQuestion = Prefixed_Name(sur, "ClosedQuestion") |> PrefixedName

    /// <summary>
    ///   <para>sur:MutipleInputQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Multiple Input Question</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#MutipleInputQuestion">https://w3id.org/survey-ontology#MutipleInputQuestion</seealso>
    let MutipleInputQuestion =
        Prefixed_Name(sur, "MutipleInputQuestion") |> PrefixedName

    /// <summary>
    ///   <para>sur:OpenAnswer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Open Answer</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#OpenAnswer">https://w3id.org/survey-ontology#OpenAnswer</seealso>
    let OpenAnswer = Prefixed_Name(sur, "OpenAnswer") |> PrefixedName
    /// <summary>
    ///   <para>sur:Slider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    ///
    /// labels<para>Slider</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Slider">https://w3id.org/survey-ontology#Slider</seealso>
    let Slider = Prefixed_Name(sur, "Slider") |> PrefixedName
    /// <summary>
    ///   <para>sur:Question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Question</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Question">https://w3id.org/survey-ontology#Question</seealso>
    let Question = Prefixed_Name(sur, "Question") |> PrefixedName
    /// <summary>
    ///   <para>sur:CompletedQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Completed Question</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#CompletedQuestion">https://w3id.org/survey-ontology#CompletedQuestion</seealso>
    let CompletedQuestion = Prefixed_Name(sur, "CompletedQuestion") |> PrefixedName
    /// <summary>
    ///   <para>sur:Dropdown</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Dropdown</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Dropdown">https://w3id.org/survey-ontology#Dropdown</seealso>
    let Dropdown = Prefixed_Name(sur, "Dropdown") |> PrefixedName

    /// <summary>
    ///   <para>sur:QuestionVisualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Question Visualization</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#QuestionVisualization">https://w3id.org/survey-ontology#QuestionVisualization</seealso>
    let QuestionVisualization =
        Prefixed_Name(sur, "QuestionVisualization") |> PrefixedName

    /// <summary>
    ///   <para>sur:Talk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Talk</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Talk">https://w3id.org/survey-ontology#Talk</seealso>
    let Talk = Prefixed_Name(sur, "Talk") |> PrefixedName
    /// <summary>
    ///   <para>sur:SurveyElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Survey Element</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SurveyElement">https://w3id.org/survey-ontology#SurveyElement</seealso>
    let SurveyElement = Prefixed_Name(sur, "SurveyElement") |> PrefixedName
    /// <summary>
    ///   <para>sur:ClosedAnswer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Closed Answer</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#ClosedAnswer">https://w3id.org/survey-ontology#ClosedAnswer</seealso>
    let ClosedAnswer = Prefixed_Name(sur, "ClosedAnswer") |> PrefixedName
    /// <summary>
    ///   <para>sur:CheckboxQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Checkbox Question</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#CheckboxQuestion">https://w3id.org/survey-ontology#CheckboxQuestion</seealso>
    let CheckboxQuestion = Prefixed_Name(sur, "CheckboxQuestion") |> PrefixedName
    /// <summary>
    ///   <para>sur:CompletedSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Completed Survey</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#CompletedSurvey">https://w3id.org/survey-ontology#CompletedSurvey</seealso>
    let CompletedSurvey = Prefixed_Name(sur, "CompletedSurvey") |> PrefixedName
    /// <summary>
    ///   <para>sur:LatentVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Latent Variable</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#LatentVariable">https://w3id.org/survey-ontology#LatentVariable</seealso>
    let LatentVariable = Prefixed_Name(sur, "LatentVariable") |> PrefixedName
    /// <summary>
    ///   <para>sur:ObservableVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Observable Variable</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#ObservableVariable">https://w3id.org/survey-ontology#ObservableVariable</seealso>
    let ObservableVariable = Prefixed_Name(sur, "ObservableVariable") |> PrefixedName
    /// <summary>
    ///   <para>sur:Emoji</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    ///
    /// labels<para>Emoji</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Emoji">https://w3id.org/survey-ontology#Emoji</seealso>
    let Emoji = Prefixed_Name(sur, "Emoji") |> PrefixedName

    /// <summary>
    ///   <para>sur:MultipleChoiceQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Multiple Choice Question</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#MultipleChoiceQuestion">https://w3id.org/survey-ontology#MultipleChoiceQuestion</seealso>
    let MultipleChoiceQuestion =
        Prefixed_Name(sur, "MultipleChoiceQuestion") |> PrefixedName

    /// <summary>
    ///   <para>sur:OpenQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Open Question</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#OpenQuestion">https://w3id.org/survey-ontology#OpenQuestion</seealso>
    let OpenQuestion = Prefixed_Name(sur, "OpenQuestion") |> PrefixedName
    /// <summary>
    ///   <para>sur:Participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Participant</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Participant">https://w3id.org/survey-ontology#Participant</seealso>
    let Participant = Prefixed_Name(sur, "Participant") |> PrefixedName
    /// <summary>
    ///   <para>sur:Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    ///
    /// labels<para>Scale</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Scale">https://w3id.org/survey-ontology#Scale</seealso>
    let Scale = Prefixed_Name(sur, "Scale") |> PrefixedName
    /// <summary>
    ///   <para>sur:Survey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Survey</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Survey">https://w3id.org/survey-ontology#Survey</seealso>
    let Survey = Prefixed_Name(sur, "Survey") |> PrefixedName
    /// <summary>
    ///   <para>sur:SurveyProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Survey Procedure</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SurveyProcedure">https://w3id.org/survey-ontology#SurveyProcedure</seealso>
    let SurveyProcedure = Prefixed_Name(sur, "SurveyProcedure") |> PrefixedName
    /// <summary>
    ///   <para>sur:answeredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>answered in</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#answeredIn">https://w3id.org/survey-ontology#answeredIn</seealso>
    let answeredIn = Prefixed_Name(sur, "answeredIn") |> PrefixedName
    /// <summary>
    ///   <para>sur:completesQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>completes question</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#completesQuestion">https://w3id.org/survey-ontology#completesQuestion</seealso>
    let completesQuestion = Prefixed_Name(sur, "completesQuestion") |> PrefixedName
    /// <summary>
    ///   <para>sur:hasAnswerText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has answer text</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasAnswerText">https://w3id.org/survey-ontology#hasAnswerText</seealso>
    let hasAnswerText = Prefixed_Name(sur, "hasAnswerText") |> PrefixedName
    /// <summary>
    ///   <para>sur:hasLatentVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has latent variable</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasLatentVariable">https://w3id.org/survey-ontology#hasLatentVariable</seealso>
    let hasLatentVariable = Prefixed_Name(sur, "hasLatentVariable") |> PrefixedName
    /// <summary>
    ///   <para>sur:hasLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has link</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasLink">https://w3id.org/survey-ontology#hasLink</seealso>
    let hasLink = Prefixed_Name(sur, "hasLink") |> PrefixedName

    /// <summary>
    ///   <para>sur:hasObservableVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has observable variable</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasObservableVariable">https://w3id.org/survey-ontology#hasObservableVariable</seealso>
    let hasObservableVariable =
        Prefixed_Name(sur, "hasObservableVariable") |> PrefixedName

    /// <summary>
    ///   <para>sur:hasPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has points</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasPoints">https://w3id.org/survey-ontology#hasPoints</seealso>
    let hasPoints = Prefixed_Name(sur, "hasPoints") |> PrefixedName
    /// <summary>
    ///   <para>sur:hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has status</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasStatus">https://w3id.org/survey-ontology#hasStatus</seealso>
    let hasStatus = Prefixed_Name(sur, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>sur:hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has title</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasTitle">https://w3id.org/survey-ontology#hasTitle</seealso>
    let hasTitle = Prefixed_Name(sur, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>sur:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has value</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasValue">https://w3id.org/survey-ontology#hasValue</seealso>
    let hasValue = Prefixed_Name(sur, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>sur:leadsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>leads to</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#leadsTo">https://w3id.org/survey-ontology#leadsTo</seealso>
    let leadsTo = Prefixed_Name(sur, "leadsTo") |> PrefixedName
    /// <summary>
    ///   <para>sur:participantId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>participant id</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#participantId">https://w3id.org/survey-ontology#participantId</seealso>
    let participantId = Prefixed_Name(sur, "participantId") |> PrefixedName
    /// <summary>
    ///   <para>sur:Option</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    ///
    /// labels<para>Option</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Option">https://w3id.org/survey-ontology#Option</seealso>
    let Option = Prefixed_Name(sur, "Option") |> PrefixedName
    /// <summary>
    ///   <para>sur:SingleInputQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Single Input Question</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SingleInputQuestion">https://w3id.org/survey-ontology#SingleInputQuestion</seealso>
    let SingleInputQuestion = Prefixed_Name(sur, "SingleInputQuestion") |> PrefixedName

    /// <summary>
    ///   <para>sur:SurveyCompletionTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Survey Completion Task</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SurveyCompletionTask">https://w3id.org/survey-ontology#SurveyCompletionTask</seealso>
    let SurveyCompletionTask =
        Prefixed_Name(sur, "SurveyCompletionTask") |> PrefixedName

    /// <summary>
    ///   <para>sur:SurveyDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Survey Dataset</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SurveyDataSet">https://w3id.org/survey-ontology#SurveyDataSet</seealso>
    let SurveyDataSet = Prefixed_Name(sur, "SurveyDataSet") |> PrefixedName
    /// <summary>
    ///   <para>sur:SurveyTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Survey Target</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SurveyTarget">https://w3id.org/survey-ontology#SurveyTarget</seealso>
    let SurveyTarget = Prefixed_Name(sur, "SurveyTarget") |> PrefixedName
    /// <summary>
    ///   <para>sur:completedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>completed for</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#completedFor">https://w3id.org/survey-ontology#completedFor</seealso>
    let completedFor = Prefixed_Name(sur, "completedFor") |> PrefixedName
    /// <summary>
    ///   <para>sur:hasAnswer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has answer</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasAnswer">https://w3id.org/survey-ontology#hasAnswer</seealso>
    let hasAnswer = Prefixed_Name(sur, "hasAnswer") |> PrefixedName

    /// <summary>
    ///   <para>sur:hasCompletionTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has completion timestamp</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasCompletionTimestamp">https://w3id.org/survey-ontology#hasCompletionTimestamp</seealso>
    let hasCompletionTimestamp =
        Prefixed_Name(sur, "hasCompletionTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>sur:hasOrderNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has order number</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasOrderNumber">https://w3id.org/survey-ontology#hasOrderNumber</seealso>
    let hasOrderNumber = Prefixed_Name(sur, "hasOrderNumber") |> PrefixedName
    /// <summary>
    ///   <para>sur:hasText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has text</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasText">https://w3id.org/survey-ontology#hasText</seealso>
    let hasText = Prefixed_Name(sur, "hasText") |> PrefixedName
    /// <summary>
    ///   <para>sur:inSurveyProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>in survey procedure</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#inSurveyProcedure">https://w3id.org/survey-ontology#inSurveyProcedure</seealso>
    let inSurveyProcedure = Prefixed_Name(sur, "inSurveyProcedure") |> PrefixedName
    /// <summary>
    ///   <para>sur:startsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>starts with</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#startsWith">https://w3id.org/survey-ontology#startsWith</seealso>
    let startsWith = Prefixed_Name(sur, "startsWith") |> PrefixedName
    /// <summary>
    ///   <para>sur:sessionId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>session id</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#sessionId">https://w3id.org/survey-ontology#sessionId</seealso>
    let sessionId = Prefixed_Name(sur, "sessionId") |> PrefixedName
    /// <summary>
    ///   <para>sur:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Ontology for surveys based on the Coney data model.</para>
    /// labels<para>Survey Ontology</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#">https://w3id.org/survey-ontology#</seealso>
    let _prefix_iri = Prefixed_Name(sur, "") |> PrefixedName
    /// <summary>
    ///   <para>sur:hasVisualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has visualization</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasVisualization">https://w3id.org/survey-ontology#hasVisualization</seealso>
    let hasVisualization = Prefixed_Name(sur, "hasVisualization") |> PrefixedName
