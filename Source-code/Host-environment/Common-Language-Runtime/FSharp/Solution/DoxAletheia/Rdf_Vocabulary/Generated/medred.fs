namespace http.w3id.org.medred.medred.hash

open DoxAletheia.Rdf_Vocabulary

module medred =
    let _namespace_name = "http://w3id.org/medred/medred#"
    /// <summary>
    /// An Instrument represents a data acquisition tool for a medical study, e.g. a questionnaire, survey, assessment, etc.
    /// <see href="http://w3id.org/medred/medred#Instrument"></see></summary>
    let Instrument = Namespaced_IRI.parse _namespace_name "Instrument" |> NamespacedName
    /// <summary>
    /// An Item is a step of an Instrument
    /// <see href="http://w3id.org/medred/medred#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    /// The ChoiceList corresponds to a list of Choice items for a given Question
    /// <see href="http://w3id.org/medred/medred#ChoiceList"></see></summary>
    let ChoiceList = Namespaced_IRI.parse _namespace_name "ChoiceList" |> NamespacedName
    /// <summary>
    /// The ItemList is a list of Item elements
    /// <see href="http://w3id.org/medred/medred#ItemList"></see></summary>
    let ItemList = Namespaced_IRI.parse _namespace_name "ItemList" |> NamespacedName

    /// <summary>
    /// A CaseReportForm is a tool used for a clinical study to collect data from each participating subject
    /// <see href="http://w3id.org/medred/medred#CaseReportForm"></see></summary>
    let CaseReportForm =
        Namespaced_IRI.parse _namespace_name "CaseReportForm" |> NamespacedName

    /// <summary>
    /// Each Choice corresponds to a possible answer to a given Question
    /// <see href="http://w3id.org/medred/medred#Choice"></see></summary>
    let Choice = Namespaced_IRI.parse _namespace_name "Choice" |> NamespacedName
    /// <summary>
    /// A Question is an Instrument item consisting of an inquiry or query to a subject
    /// <see href="http://w3id.org/medred/medred#Question"></see></summary>
    let Question = Namespaced_IRI.parse _namespace_name "Question" |> NamespacedName
    /// <summary>
    /// A relation between an Instrument question, and the list of possible Choice elements
    /// <see href="http://w3id.org/medred/medred#choices"></see></summary>
    let choices = Namespaced_IRI.parse _namespace_name "choices" |> NamespacedName

    /// <summary>
    /// Information corresponds to an instrument item that holds an information for the subject
    /// <see href="http://w3id.org/medred/medred#Information"></see></summary>
    let Information =
        Namespaced_IRI.parse _namespace_name "Information" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#Observation"></see>
    /// </summary>
    let Observation =
        Namespaced_IRI.parse _namespace_name "Observation" |> NamespacedName

    /// <summary>
    /// An Operation is an Instrument item that results of a computation, or generated form other items
    /// <see href="http://w3id.org/medred/medred#Operation"></see></summary>
    let Operation = Namespaced_IRI.parse _namespace_name "Operation" |> NamespacedName

    /// <summary>
    /// A Questionnaire is an Instrument that consists fo different questions made to the subject
    /// <see href="http://w3id.org/medred/medred#Questionnaire"></see></summary>
    let Questionnaire =
        Namespaced_IRI.parse _namespace_name "Questionnaire" |> NamespacedName

    /// <summary>
    /// A Section is an Instrument item that regroups a subset of Items
    /// <see href="http://w3id.org/medred/medred#Section"></see></summary>
    let Section = Namespaced_IRI.parse _namespace_name "Section" |> NamespacedName
    /// <summary>
    /// A Study is a medical research investigation composed of several instruments
    /// <see href="http://w3id.org/medred/medred#Study"></see></summary>
    let Study = Namespaced_IRI.parse _namespace_name "Study" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#calculation"></see>
    /// </summary>
    let calculation =
        Namespaced_IRI.parse _namespace_name "calculation" |> NamespacedName

    /// <summary>
    /// The dataType estalbishes a relationship between a Variable and the datatype of its data item
    /// <see href="http://w3id.org/medred/medred#dataType"></see></summary>
    let dataType = Namespaced_IRI.parse _namespace_name "dataType" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#dataValue"></see>
    /// </summary>
    let dataValue = Namespaced_IRI.parse _namespace_name "dataValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#hasValue"></see>
    /// </summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName
    /// <summary>
    /// The instrument establishes a relationship between a Study and an Instrument
    /// <see href="http://w3id.org/medred/medred#instrument"></see></summary>
    let instrument = Namespaced_IRI.parse _namespace_name "instrument" |> NamespacedName
    /// <summary>
    /// The items property represents a relationship between an Instrument and its constitutent ItemList
    /// <see href="http://w3id.org/medred/medred#items"></see></summary>
    let items = Namespaced_IRI.parse _namespace_name "items" |> NamespacedName

    /// <summary>
    /// It establishes a relationships between an Item and an Instrument
    /// <see href="http://w3id.org/medred/medred#ofInstrument"></see></summary>
    let ofInstrument =
        Namespaced_IRI.parse _namespace_name "ofInstrument" |> NamespacedName

    /// <summary>
    /// It establishes a relationship between an Item and a Section
    /// <see href="http://w3id.org/medred/medred#ofSection"></see></summary>
    let ofSection = Namespaced_IRI.parse _namespace_name "ofSection" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#studyName"></see>
    /// </summary>
    let studyName = Namespaced_IRI.parse _namespace_name "studyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#validationShape"></see>
    /// </summary>
    let validationShape =
        Namespaced_IRI.parse _namespace_name "validationShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/medred/medred#varName"></see>
    /// </summary>
    let varName = Namespaced_IRI.parse _namespace_name "varName" |> NamespacedName
