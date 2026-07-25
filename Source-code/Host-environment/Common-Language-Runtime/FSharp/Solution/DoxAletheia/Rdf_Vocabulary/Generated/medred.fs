namespace http.w3id.org.medred.medred.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module medred =
    let _namespace_iri = Namespace_Iri medred |> NamespaceIRI
    /// <summary>
    ///   <para>medred:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Item is a step of an Instrument</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#Item">http://w3id.org/medred/medred#Item</seealso>
    let Item = Prefixed_Name(medred, "Item") |> PrefixedName
    /// <summary>
    ///   <para>medred:validationShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/medred/medred#validationShape">http://w3id.org/medred/medred#validationShape</seealso>
    let validationShape = Prefixed_Name(medred, "validationShape") |> PrefixedName
    /// <summary>
    ///   <para>medred:Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Section is an Instrument item that regroups a subset of Items</para>
    /// labels<para>Section</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#Section">http://w3id.org/medred/medred#Section</seealso>
    let Section = Prefixed_Name(medred, "Section") |> PrefixedName
    /// <summary>
    ///   <para>medred:dataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The dataType estalbishes a relationship between a Variable and the datatype of its data item</para>
    /// labels<para>dataType</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#dataType">http://w3id.org/medred/medred#dataType</seealso>
    let dataType = Prefixed_Name(medred, "dataType") |> PrefixedName
    /// <summary>
    ///   <para>medred:instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The instrument establishes a relationship between a Study and an Instrument</para>
    /// labels<para>instrument</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#instrument">http://w3id.org/medred/medred#instrument</seealso>
    let instrument = Prefixed_Name(medred, "instrument") |> PrefixedName
    /// <summary>
    ///   <para>medred:ofSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It establishes a relationship between an Item and a Section</para>
    /// labels<para>ofSection</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#ofSection">http://w3id.org/medred/medred#ofSection</seealso>
    let ofSection = Prefixed_Name(medred, "ofSection") |> PrefixedName
    /// <summary>
    ///   <para>medred:varName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>varName</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#varName">http://w3id.org/medred/medred#varName</seealso>
    let varName = Prefixed_Name(medred, "varName") |> PrefixedName
    /// <summary>
    ///   <para>medred:ItemList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ItemList is a list of Item elements</para>
    /// labels<para>ItemList</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#ItemList">http://w3id.org/medred/medred#ItemList</seealso>
    let ItemList = Prefixed_Name(medred, "ItemList") |> PrefixedName
    /// <summary>
    ///   <para>medred:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>Cette ontologie a été conçue pour representer des Instruments pour l'aquisition de données cliniques, dans le contexte du projet MedRed project (https://www.hevs.ch/en/rad-institutes/institute-of-information-systems/projects/medical-research-data-acquisition-platform-14092)</para>
    ///   <para>Esta ontología has sido diseñada para representar Instrumentos de captura de datos clínicos, dentro del contexto del proyecto MedRed (https://www.hevs.ch/en/rad-institutes/institute-of-information-systems/projects/medical-research-data-acquisition-platform-14092)</para>
    ///   <para>This ontology aims to model generic Medical Data Acquisition Instruments, which can be interoperable across different clinical data management systems. The ontology is developed in the context of the MedRed project (https://www.hevs.ch/en/rad-institutes/institute-of-information-systems/projects/medical-research-data-acquisition-platform-14092)</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/medred/medred#">http://w3id.org/medred/medred#</seealso>
    let _prefix_iri = Prefixed_Name(medred, "") |> PrefixedName
    /// <summary>
    ///   <para>medred:Question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Question is an Instrument item consisting of an inquiry or query to a subject</para>
    /// labels<para>Question</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#Question">http://w3id.org/medred/medred#Question</seealso>
    let Question = Prefixed_Name(medred, "Question") |> PrefixedName
    /// <summary>
    ///   <para>medred:Information</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information corresponds to an instrument item that holds an information for the subject</para>
    /// labels<para>Information</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#Information">http://w3id.org/medred/medred#Information</seealso>
    let Information = Prefixed_Name(medred, "Information") |> PrefixedName
    /// <summary>
    ///   <para>medred:Choice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Each Choice corresponds to a possible answer to a given Question</para>
    /// labels<para>Choice</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#Choice">http://w3id.org/medred/medred#Choice</seealso>
    let Choice = Prefixed_Name(medred, "Choice") |> PrefixedName
    /// <summary>
    ///   <para>medred:choices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between an Instrument question, and the list of possible Choice elements</para>
    /// labels<para>choices</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#choices">http://w3id.org/medred/medred#choices</seealso>
    let choices = Prefixed_Name(medred, "choices") |> PrefixedName
    /// <summary>
    ///   <para>medred:CaseReportForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A CaseReportForm is a tool used for a clinical study to collect data from each participating subject</para>
    /// labels<para>CaseReportForm</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#CaseReportForm">http://w3id.org/medred/medred#CaseReportForm</seealso>
    let CaseReportForm = Prefixed_Name(medred, "CaseReportForm") |> PrefixedName
    /// <summary>
    ///   <para>medred:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/medred/medred#Observation">http://w3id.org/medred/medred#Observation</seealso>
    let Observation = Prefixed_Name(medred, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>medred:Questionnaire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Questionnaire is an Instrument that consists fo different questions made to the subject</para>
    /// labels<para>Questionnaire</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#Questionnaire">http://w3id.org/medred/medred#Questionnaire</seealso>
    let Questionnaire = Prefixed_Name(medred, "Questionnaire") |> PrefixedName
    /// <summary>
    ///   <para>medred:Operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Operation is an Instrument item that results of a computation, or generated form other items</para>
    /// labels<para>Operation</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#Operation">http://w3id.org/medred/medred#Operation</seealso>
    let Operation = Prefixed_Name(medred, "Operation") |> PrefixedName
    /// <summary>
    ///   <para>medred:Study</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Study is a medical research investigation composed of several instruments</para>
    /// labels<para>Study</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#Study">http://w3id.org/medred/medred#Study</seealso>
    let Study = Prefixed_Name(medred, "Study") |> PrefixedName
    /// <summary>
    ///   <para>medred:dataValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/medred/medred#dataValue">http://w3id.org/medred/medred#dataValue</seealso>
    let dataValue = Prefixed_Name(medred, "dataValue") |> PrefixedName
    /// <summary>
    ///   <para>medred:items</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The items property represents a relationship between an Instrument and its constitutent ItemList</para>
    /// labels<para>items</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#items">http://w3id.org/medred/medred#items</seealso>
    let items = Prefixed_Name(medred, "items") |> PrefixedName
    /// <summary>
    ///   <para>medred:studyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>studyName</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#studyName">http://w3id.org/medred/medred#studyName</seealso>
    let studyName = Prefixed_Name(medred, "studyName") |> PrefixedName
    /// <summary>
    ///   <para>medred:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/medred/medred#hasValue">http://w3id.org/medred/medred#hasValue</seealso>
    let hasValue = Prefixed_Name(medred, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>medred:ofInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It establishes a relationships between an Item and an Instrument</para>
    /// labels<para>ofInstrument</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#ofInstrument">http://w3id.org/medred/medred#ofInstrument</seealso>
    let ofInstrument = Prefixed_Name(medred, "ofInstrument") |> PrefixedName
    /// <summary>
    ///   <para>medred:calculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>calculation</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#calculation">http://w3id.org/medred/medred#calculation</seealso>
    let calculation = Prefixed_Name(medred, "calculation") |> PrefixedName
    /// <summary>
    ///   <para>medred:Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Instrument represents a data acquisition tool for a medical study, e.g. a questionnaire, survey, assessment, etc.</para>
    /// labels<para>Instrument</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#Instrument">http://w3id.org/medred/medred#Instrument</seealso>
    let Instrument = Prefixed_Name(medred, "Instrument") |> PrefixedName
    /// <summary>
    ///   <para>medred:ChoiceList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ChoiceList corresponds to a list of Choice items for a given Question</para>
    /// labels<para>ChoiceList</para></remarks>
    /// <seealso href="http://w3id.org/medred/medred#ChoiceList">http://w3id.org/medred/medred#ChoiceList</seealso>
    let ChoiceList = Prefixed_Name(medred, "ChoiceList") |> PrefixedName
