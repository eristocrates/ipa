#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module medred =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/medred/medred#" "medred"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : CaseReportForm</para>
    ///   <para>rdfs:comment : A CaseReportForm is a tool used for a clinical study to collect data from each participating subject</para>
    ///   <a href="http://w3id.org/medred/medred#CaseReportForm">medred:CaseReportForm</a>
    /// </summary>
    let CaseReportForm = _prefixId.prefix "CaseReportForm"
    /// <summary>
    ///   <para>rdfs:label : Choice</para>
    ///   <para>rdfs:comment : Each Choice corresponds to a possible answer to a given Question</para>
    ///   <a href="http://w3id.org/medred/medred#Choice">medred:Choice</a>
    /// </summary>
    let Choice = _prefixId.prefix "Choice"
    /// <summary>
    ///   <para>rdfs:label : ChoiceList</para>
    ///   <para>rdfs:comment : The ChoiceList corresponds to a list of Choice items for a given Question</para>
    ///   <a href="http://w3id.org/medred/medred#ChoiceList">medred:ChoiceList</a>
    /// </summary>
    let ChoiceList = _prefixId.prefix "ChoiceList"
    /// <summary>
    ///   <para>rdfs:label : Information</para>
    ///   <para>rdfs:comment : Information corresponds to an instrument item that holds an information for the subject</para>
    ///   <a href="http://w3id.org/medred/medred#Information">medred:Information</a>
    /// </summary>
    let Information = _prefixId.prefix "Information"
    /// <summary>
    ///   <para>rdfs:label : Instrument</para>
    ///   <para>rdfs:comment : An Instrument represents a data acquisition tool for a medical study, e.g. a questionnaire, survey, assessment, etc.</para>
    ///   <a href="http://w3id.org/medred/medred#Instrument">medred:Instrument</a>
    /// </summary>
    let Instrument = _prefixId.prefix "Instrument"
    /// <summary>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : An Item is a step of an Instrument</para>
    ///   <a href="http://w3id.org/medred/medred#Item">medred:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : ItemList</para>
    ///   <para>rdfs:comment : The ItemList is a list of Item elements</para>
    ///   <a href="http://w3id.org/medred/medred#ItemList">medred:ItemList</a>
    /// </summary>
    let ItemList = _prefixId.prefix "ItemList"
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>rdfs:label : Operation</para>
    ///   <para>rdfs:comment : An Operation is an Instrument item that results of a computation, or generated form other items</para>
    ///   <a href="http://w3id.org/medred/medred#Operation">medred:Operation</a>
    /// </summary>
    let Operation = _prefixId.prefix "Operation"
    /// <summary>
    ///   <para>rdfs:label : Question</para>
    ///   <para>rdfs:comment : A Question is an Instrument item consisting of an inquiry or query to a subject</para>
    ///   <a href="http://w3id.org/medred/medred#Question">medred:Question</a>
    /// </summary>
    let Question = _prefixId.prefix "Question"
    /// <summary>
    ///   <para>rdfs:label : Questionnaire</para>
    ///   <para>rdfs:comment : A Questionnaire is an Instrument that consists fo different questions made to the subject</para>
    ///   <a href="http://w3id.org/medred/medred#Questionnaire">medred:Questionnaire</a>
    /// </summary>
    let Questionnaire = _prefixId.prefix "Questionnaire"
    /// <summary>
    ///   <para>rdfs:label : Section</para>
    ///   <para>rdfs:comment : A Section is an Instrument item that regroups a subset of Items</para>
    ///   <a href="http://w3id.org/medred/medred#Section">medred:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>rdfs:label : Study</para>
    ///   <para>rdfs:comment : A Study is a medical research investigation composed of several instruments</para>
    ///   <a href="http://w3id.org/medred/medred#Study">medred:Study</a>
    /// </summary>
    let Study = _prefixId.prefix "Study"
    /// <summary>
    ///   <para>rdfs:label : calculation</para>
    ///   <a href="http://w3id.org/medred/medred#calculation">medred:calculation</a>
    /// </summary>
    let calculation = _prefixId.prefix "calculation"
    /// <summary>
    ///   <para>rdfs:label : choices</para>
    ///   <para>rdfs:comment : A relation between an Instrument question, and the list of possible Choice elements</para>
    ///   <a href="http://w3id.org/medred/medred#choices">medred:choices</a>
    /// </summary>
    let choices = _prefixId.prefix "choices"
    /// <summary>
    ///   <para>rdfs:label : dataType</para>
    ///   <para>rdfs:comment : The dataType estalbishes a relationship between a Variable and the datatype of its data item</para>
    ///   <a href="http://w3id.org/medred/medred#dataType">medred:dataType</a>
    /// </summary>
    let dataType = _prefixId.prefix "dataType"
    let dataValue = _prefixId.prefix "dataValue"
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : instrument</para>
    ///   <para>rdfs:comment : The instrument establishes a relationship between a Study and an Instrument</para>
    ///   <a href="http://w3id.org/medred/medred#instrument">medred:instrument</a>
    /// </summary>
    let instrument = _prefixId.prefix "instrument"
    /// <summary>
    ///   <para>rdfs:label : items</para>
    ///   <para>rdfs:comment : The items property represents a relationship between an Instrument and its constitutent ItemList</para>
    ///   <a href="http://w3id.org/medred/medred#items">medred:items</a>
    /// </summary>
    let items = _prefixId.prefix "items"
    /// <summary>
    ///   <para>rdfs:label : ofInstrument</para>
    ///   <para>rdfs:comment : It establishes a relationships between an Item and an Instrument</para>
    ///   <a href="http://w3id.org/medred/medred#ofInstrument">medred:ofInstrument</a>
    /// </summary>
    let ofInstrument = _prefixId.prefix "ofInstrument"
    /// <summary>
    ///   <para>rdfs:label : ofSection</para>
    ///   <para>rdfs:comment : It establishes a relationship between an Item and a Section</para>
    ///   <a href="http://w3id.org/medred/medred#ofSection">medred:ofSection</a>
    /// </summary>
    let ofSection = _prefixId.prefix "ofSection"
    /// <summary>
    ///   <para>rdfs:label : studyName</para>
    ///   <a href="http://w3id.org/medred/medred#studyName">medred:studyName</a>
    /// </summary>
    let studyName = _prefixId.prefix "studyName"
    let validationShape = _prefixId.prefix "validationShape"
    /// <summary>
    ///   <para>rdfs:label : varName</para>
    ///   <a href="http://w3id.org/medred/medred#varName">medred:varName</a>
    /// </summary>
    let varName = _prefixId.prefix "varName"
