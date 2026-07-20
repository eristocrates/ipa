namespace http.w3id.org.medred.medred.hash

open DoxAletheia

module medred =
    let _namespace_name = "http://w3id.org/medred/medred#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An Instrument represents a data acquisition tool for a medical study, e.g. a questionnaire, survey, assessment, etc.
    /// <see href="http://w3id.org/medred/medred#Instrument"></see></summary>
    let Instrument = _prefix "Instrument"
    /// <summary>
    /// An Item is a step of an Instrument
    /// <see href="http://w3id.org/medred/medred#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// The ChoiceList corresponds to a list of Choice items for a given Question
    /// <see href="http://w3id.org/medred/medred#ChoiceList"></see></summary>
    let ChoiceList = _prefix "ChoiceList"
    /// <summary>
    /// The ItemList is a list of Item elements
    /// <see href="http://w3id.org/medred/medred#ItemList"></see></summary>
    let ItemList = _prefix "ItemList"
    /// <summary>
    /// A CaseReportForm is a tool used for a clinical study to collect data from each participating subject
    /// <see href="http://w3id.org/medred/medred#CaseReportForm"></see></summary>
    let CaseReportForm = _prefix "CaseReportForm"
    /// <summary>
    /// Each Choice corresponds to a possible answer to a given Question
    /// <see href="http://w3id.org/medred/medred#Choice"></see></summary>
    let Choice = _prefix "Choice"
    /// <summary>
    /// A Question is an Instrument item consisting of an inquiry or query to a subject
    /// <see href="http://w3id.org/medred/medred#Question"></see></summary>
    let Question = _prefix "Question"
    /// <summary>
    /// A relation between an Instrument question, and the list of possible Choice elements
    /// <see href="http://w3id.org/medred/medred#choices"></see></summary>
    let choices = _prefix "choices"
    /// <summary>
    /// Information corresponds to an instrument item that holds an information for the subject
    /// <see href="http://w3id.org/medred/medred#Information"></see></summary>
    let Information = _prefix "Information"
    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#Observation"></see>
    /// </summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// An Operation is an Instrument item that results of a computation, or generated form other items
    /// <see href="http://w3id.org/medred/medred#Operation"></see></summary>
    let Operation = _prefix "Operation"
    /// <summary>
    /// A Questionnaire is an Instrument that consists fo different questions made to the subject
    /// <see href="http://w3id.org/medred/medred#Questionnaire"></see></summary>
    let Questionnaire = _prefix "Questionnaire"
    /// <summary>
    /// A Section is an Instrument item that regroups a subset of Items
    /// <see href="http://w3id.org/medred/medred#Section"></see></summary>
    let Section = _prefix "Section"
    /// <summary>
    /// A Study is a medical research investigation composed of several instruments
    /// <see href="http://w3id.org/medred/medred#Study"></see></summary>
    let Study = _prefix "Study"
    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#calculation"></see>
    /// </summary>
    let calculation = _prefix "calculation"
    /// <summary>
    /// The dataType estalbishes a relationship between a Variable and the datatype of its data item
    /// <see href="http://w3id.org/medred/medred#dataType"></see></summary>
    let dataType = _prefix "dataType"
    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#dataValue"></see>
    /// </summary>
    let dataValue = _prefix "dataValue"
    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// The instrument establishes a relationship between a Study and an Instrument
    /// <see href="http://w3id.org/medred/medred#instrument"></see></summary>
    let instrument = _prefix "instrument"
    /// <summary>
    /// The items property represents a relationship between an Instrument and its constitutent ItemList
    /// <see href="http://w3id.org/medred/medred#items"></see></summary>
    let items = _prefix "items"
    /// <summary>
    /// It establishes a relationships between an Item and an Instrument
    /// <see href="http://w3id.org/medred/medred#ofInstrument"></see></summary>
    let ofInstrument = _prefix "ofInstrument"
    /// <summary>
    /// It establishes a relationship between an Item and a Section
    /// <see href="http://w3id.org/medred/medred#ofSection"></see></summary>
    let ofSection = _prefix "ofSection"
    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#studyName"></see>
    /// </summary>
    let studyName = _prefix "studyName"
    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#validationShape"></see>
    /// </summary>
    let validationShape = _prefix "validationShape"
    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#varName"></see>
    /// </summary>
    let varName = _prefix "varName"
