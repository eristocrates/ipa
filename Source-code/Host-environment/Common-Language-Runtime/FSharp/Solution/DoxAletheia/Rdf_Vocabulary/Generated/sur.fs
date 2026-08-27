namespace https.w3id.org.survey_ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sur =
    let _namespace_iri = Namespace_Iri sur |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:survey-ontology#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"Ontology for surveys based on the Coney data model."</para>
    /// labels<para>"Survey Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#">https://w3id.org/survey-ontology#</seealso>
    let _prefix_iri = Prefixed_Name(sur, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#Answer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Answer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Answer">https://w3id.org/survey-ontology#Answer</seealso>
    let Answer = Prefixed_Name(sur, "Answer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#CheckboxQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Checkbox Question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#CheckboxQuestion">https://w3id.org/survey-ontology#CheckboxQuestion</seealso>
    let CheckboxQuestion = Prefixed_Name(sur, "CheckboxQuestion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#ClosedAnswer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Closed Answer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#ClosedAnswer">https://w3id.org/survey-ontology#ClosedAnswer</seealso>
    let ClosedAnswer = Prefixed_Name(sur, "ClosedAnswer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#ClosedQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Closed Question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#ClosedQuestion">https://w3id.org/survey-ontology#ClosedQuestion</seealso>
    let ClosedQuestion = Prefixed_Name(sur, "ClosedQuestion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#CompletedQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Completed Question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#CompletedQuestion">https://w3id.org/survey-ontology#CompletedQuestion</seealso>
    let CompletedQuestion = Prefixed_Name(sur, "CompletedQuestion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#CompletedSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Completed Survey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#CompletedSurvey">https://w3id.org/survey-ontology#CompletedSurvey</seealso>
    let CompletedSurvey = Prefixed_Name(sur, "CompletedSurvey") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#Dropdown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    ///
    /// labels<para>"Dropdown"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Dropdown">https://w3id.org/survey-ontology#Dropdown</seealso>
    let Dropdown = Prefixed_Name(sur, "Dropdown") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#Emoji</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Emoji"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Emoji">https://w3id.org/survey-ontology#Emoji</seealso>
    let Emoji = Prefixed_Name(sur, "Emoji") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#LatentVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Latent Variable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#LatentVariable">https://w3id.org/survey-ontology#LatentVariable</seealso>
    let LatentVariable = Prefixed_Name(sur, "LatentVariable") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#MultipleChoiceQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multiple Choice Question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#MultipleChoiceQuestion">https://w3id.org/survey-ontology#MultipleChoiceQuestion</seealso>
    let MultipleChoiceQuestion =
        Prefixed_Name(sur, "MultipleChoiceQuestion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#MutipleInputQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multiple Input Question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#MutipleInputQuestion">https://w3id.org/survey-ontology#MutipleInputQuestion</seealso>
    let MutipleInputQuestion =
        Prefixed_Name(sur, "MutipleInputQuestion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#ObservableVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Observable Variable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#ObservableVariable">https://w3id.org/survey-ontology#ObservableVariable</seealso>
    let ObservableVariable = Prefixed_Name(sur, "ObservableVariable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#OpenAnswer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Open Answer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#OpenAnswer">https://w3id.org/survey-ontology#OpenAnswer</seealso>
    let OpenAnswer = Prefixed_Name(sur, "OpenAnswer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#OpenQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Open Question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#OpenQuestion">https://w3id.org/survey-ontology#OpenQuestion</seealso>
    let OpenQuestion = Prefixed_Name(sur, "OpenQuestion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#Option</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Option"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Option">https://w3id.org/survey-ontology#Option</seealso>
    let Option = Prefixed_Name(sur, "Option") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#Participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Participant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Participant">https://w3id.org/survey-ontology#Participant</seealso>
    let Participant = Prefixed_Name(sur, "Participant") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#Question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Question">https://w3id.org/survey-ontology#Question</seealso>
    let Question = Prefixed_Name(sur, "Question") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Question Visualization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#QuestionVisualization">https://w3id.org/survey-ontology#QuestionVisualization</seealso>
    let QuestionVisualization =
        Prefixed_Name(sur, "QuestionVisualization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Scale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Scale">https://w3id.org/survey-ontology#Scale</seealso>
    let Scale = Prefixed_Name(sur, "Scale") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#SingleInputQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Single Input Question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SingleInputQuestion">https://w3id.org/survey-ontology#SingleInputQuestion</seealso>
    let SingleInputQuestion = Prefixed_Name(sur, "SingleInputQuestion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#Slider</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:survey-ontology#QuestionVisualization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Slider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Slider">https://w3id.org/survey-ontology#Slider</seealso>
    let Slider = Prefixed_Name(sur, "Slider") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#Survey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Survey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Survey">https://w3id.org/survey-ontology#Survey</seealso>
    let Survey = Prefixed_Name(sur, "Survey") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#SurveyCompletionTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Survey Completion Task"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SurveyCompletionTask">https://w3id.org/survey-ontology#SurveyCompletionTask</seealso>
    let SurveyCompletionTask =
        Prefixed_Name(sur, "SurveyCompletionTask") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#SurveyDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Survey Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SurveyDataSet">https://w3id.org/survey-ontology#SurveyDataSet</seealso>
    let SurveyDataSet = Prefixed_Name(sur, "SurveyDataSet") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#SurveyElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Survey Element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SurveyElement">https://w3id.org/survey-ontology#SurveyElement</seealso>
    let SurveyElement = Prefixed_Name(sur, "SurveyElement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#SurveyProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Survey Procedure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SurveyProcedure">https://w3id.org/survey-ontology#SurveyProcedure</seealso>
    let SurveyProcedure = Prefixed_Name(sur, "SurveyProcedure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#SurveyTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Survey Target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#SurveyTarget">https://w3id.org/survey-ontology#SurveyTarget</seealso>
    let SurveyTarget = Prefixed_Name(sur, "SurveyTarget") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#Talk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Talk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#Talk">https://w3id.org/survey-ontology#Talk</seealso>
    let Talk = Prefixed_Name(sur, "Talk") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#answeredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"answered in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#answeredIn">https://w3id.org/survey-ontology#answeredIn</seealso>
    let answeredIn = Prefixed_Name(sur, "answeredIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#completedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"completed for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#completedFor">https://w3id.org/survey-ontology#completedFor</seealso>
    let completedFor = Prefixed_Name(sur, "completedFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#completesQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"completes question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#completesQuestion">https://w3id.org/survey-ontology#completesQuestion</seealso>
    let completesQuestion = Prefixed_Name(sur, "completesQuestion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#hasAnswer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has answer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasAnswer">https://w3id.org/survey-ontology#hasAnswer</seealso>
    let hasAnswer = Prefixed_Name(sur, "hasAnswer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#hasAnswerText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has answer text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasAnswerText">https://w3id.org/survey-ontology#hasAnswerText</seealso>
    let hasAnswerText = Prefixed_Name(sur, "hasAnswerText") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#hasCompletionTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has completion timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasCompletionTimestamp">https://w3id.org/survey-ontology#hasCompletionTimestamp</seealso>
    let hasCompletionTimestamp =
        Prefixed_Name(sur, "hasCompletionTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#hasLatentVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has latent variable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasLatentVariable">https://w3id.org/survey-ontology#hasLatentVariable</seealso>
    let hasLatentVariable = Prefixed_Name(sur, "hasLatentVariable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#hasLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasLink">https://w3id.org/survey-ontology#hasLink</seealso>
    let hasLink = Prefixed_Name(sur, "hasLink") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#hasObservableVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has observable variable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasObservableVariable">https://w3id.org/survey-ontology#hasObservableVariable</seealso>
    let hasObservableVariable =
        Prefixed_Name(sur, "hasObservableVariable") |> PrefixedName

    /// <summary>
    ///   <para>w3id:survey-ontology#hasOrderNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has order number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasOrderNumber">https://w3id.org/survey-ontology#hasOrderNumber</seealso>
    let hasOrderNumber = Prefixed_Name(sur, "hasOrderNumber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#hasPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has points"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasPoints">https://w3id.org/survey-ontology#hasPoints</seealso>
    let hasPoints = Prefixed_Name(sur, "hasPoints") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasStatus">https://w3id.org/survey-ontology#hasStatus</seealso>
    let hasStatus = Prefixed_Name(sur, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#hasText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasText">https://w3id.org/survey-ontology#hasText</seealso>
    let hasText = Prefixed_Name(sur, "hasText") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasTitle">https://w3id.org/survey-ontology#hasTitle</seealso>
    let hasTitle = Prefixed_Name(sur, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasValue">https://w3id.org/survey-ontology#hasValue</seealso>
    let hasValue = Prefixed_Name(sur, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#hasVisualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has visualization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#hasVisualization">https://w3id.org/survey-ontology#hasVisualization</seealso>
    let hasVisualization = Prefixed_Name(sur, "hasVisualization") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#inSurveyProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"in survey procedure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#inSurveyProcedure">https://w3id.org/survey-ontology#inSurveyProcedure</seealso>
    let inSurveyProcedure = Prefixed_Name(sur, "inSurveyProcedure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#leadsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"leads to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#leadsTo">https://w3id.org/survey-ontology#leadsTo</seealso>
    let leadsTo = Prefixed_Name(sur, "leadsTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#participantId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"participant id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#participantId">https://w3id.org/survey-ontology#participantId</seealso>
    let participantId = Prefixed_Name(sur, "participantId") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#sessionId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"session id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#sessionId">https://w3id.org/survey-ontology#sessionId</seealso>
    let sessionId = Prefixed_Name(sur, "sessionId") |> PrefixedName
    /// <summary>
    ///   <para>w3id:survey-ontology#startsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"starts with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/survey-ontology#startsWith">https://w3id.org/survey-ontology#startsWith</seealso>
    let startsWith = Prefixed_Name(sur, "startsWith") |> PrefixedName
