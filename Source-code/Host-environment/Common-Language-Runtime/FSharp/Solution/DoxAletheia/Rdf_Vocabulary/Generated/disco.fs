namespace http.rdf_vocabulary.ddialliance.org.discovery.hash

open DoxAletheia

module disco =
    let _namespace_name = "http://rdf-vocabulary.ddialliance.org/discovery#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The process collecting data is focusing on the analysis of a particular type of subject. If, for example, the adult population of Finland is being studied, the AnalysisUnit would be individuals or persons.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#AnalysisUnit"></see></summary>
    let AnalysisUnit = _prefix "AnalysisUnit"
    /// <summary>
    /// For CategoryStatistics, frequencies, percentages, and weighted percentages can be defined.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#CategoryStatistics"></see></summary>
    let CategoryStatistics = _prefix "CategoryStatistics"
    /// <summary>
    /// SummaryStatistics pointing to variables and CategoryStatistics pointing to categories and codes are both DescriptiveStatistics.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#DescriptiveStatistics"></see></summary>
    let DescriptiveStatistics = _prefix "DescriptiveStatistics"
    /// <summary>
    /// The class DataFile, which is also a dcterms:Dataset, represents all the data files containing the microdata datasets.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#DataFile"></see></summary>
    let DataFile = _prefix "DataFile"
    /// <summary>
    /// The data for the study are collected by an Instrument. The purpose of an Instrument, i.e. an interview, a questionnaire or another entity used as a means of data collection, is in the case of a survey to record the flow of a questionnaire, its use of questions, and additional component parts. A questionnaire contains a flow of questions.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Instrument"></see></summary>
    let Instrument = _prefix "Instrument"
    /// <summary>
    /// Each study has a set of logical metadata associated with the processing of data, at the time of collection or later during cleaning, and re-coding. LogicalDataSet represents the microdata dataset.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#LogicalDataSet"></see></summary>
    let LogicalDataSet = _prefix "LogicalDataSet"
    /// <summary>
    /// Mappings betwenn DDI-RDF and DDI-XML
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Mapping"></see></summary>
    let Mapping = _prefix "Mapping"
    /// <summary>
    /// A Question is designed to get information upon a subject, or sequence of subjects, from a respondent.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Question"></see></summary>
    let Question = _prefix "Question"
    /// <summary>
    /// A questionnaire contains a flow of questions.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Questionnaire"></see></summary>
    let Questionnaire = _prefix "Questionnaire"
    /// <summary>
    /// RepresentedVariables encompasse study-independent, re-usable parts of variables like occupation classification.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#RepresentedVariable"></see></summary>
    let RepresentedVariable = _prefix "RepresentedVariable"
    /// <summary>
    /// A Study represents the process by which a data set was generated or collected.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Study"></see></summary>
    let Study = _prefix "Study"
    /// <summary>
    /// In some cases, where data collection is cyclic or on-going, data sets may be released as a StudyGroup, where each cycle or wave of the data collection activity produces one or more data sets. This is typical for longitudinal studies, panel studies, and other types of series (to use the DDI term). In this case, a number of Study objects would be collected into a single StudyGroup.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#StudyGroup"></see></summary>
    let StudyGroup = _prefix "StudyGroup"
    /// <summary>
    /// For SummaryStatistics, maximum values, minimum values, and standard deviations can be defined.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#SummaryStatistics"></see></summary>
    let SummaryStatistics = _prefix "SummaryStatistics"
    /// <summary>
    /// A Universe is the total membership or population of a defined class of people, objects or events.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Universe"></see></summary>
    let Universe = _prefix "Universe"
    /// <summary>
    /// Variables provide a definition of the column in a rectangular data file. Variable is a characteristic of a unit being observed. A variable might be the answer of a question, have an administrative source, or be derived from other variables.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Variable"></see></summary>
    let Variable = _prefix "Variable"
    /// <summary>
    /// points to the aggregated data set of a microdata data set.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#aggregation"></see></summary>
    let aggregation = _prefix "aggregation"
    /// <summary>
    /// analysis unit of a Study, a StudyGroup, or a Variable.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#analysisUnit"></see></summary>
    let analysisUnit = _prefix "analysisUnit"
    /// <summary>
    /// points to the RepresentedVariable the Variable is based on.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#basedOn"></see></summary>
    let basedOn = _prefix "basedOn"
    /// <summary>
    /// case quantity of a DataFile.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#caseQuantity"></see></summary>
    let caseQuantity = _prefix "caseQuantity"
    /// <summary>
    /// mode of collection of a Questionnaire
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#collectionMode"></see></summary>
    let collectionMode = _prefix "collectionMode"
    /// <summary>
    /// computation base
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#computationBase"></see></summary>
    let computationBase = _prefix "computationBase"
    /// <summary>
    /// points to the DDI concept of a RepresentedVariable, a Variable, or a Question
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#concept"></see></summary>
    let concept = _prefix "concept"
    /// <summary>
    /// points to Variable contained in the LogicalDataSet
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#containsVariable"></see></summary>
    let containsVariable = _prefix "containsVariable"
    /// <summary>
    /// context specifies conditions which have to be fulfilled for specific mappings
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#context"></see></summary>
    let context = _prefix "context"
    /// <summary>
    /// cumulative percentage
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#cumulativePercentage"></see></summary>
    let cumulativePercentage = _prefix "cumulativePercentage"
    /// <summary>
    /// points to the DataFile of a Study or a LogicalDataSet.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#dataFile"></see></summary>
    let dataFile = _prefix "dataFile"
    /// <summary>
    /// points from a Study or a StudyGroup to the original DDI file which is a foaf:Document.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#ddifile"></see></summary>
    let ddifile = _prefix "ddifile"
    /// <summary>
    /// end date
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// points from an Instrument to a foaf:Document which is the external documentation of the Instrument.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#externalDocumentation"></see></summary>
    let externalDocumentation = _prefix "externalDocumentation"
    /// <summary>
    /// frequency
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#frequency"></see></summary>
    let frequency = _prefix "frequency"
    /// <summary>
    /// points from a Study or a StudyGroup to the funding foaf:Agent which is either a foaf:Person or a org:Organization.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#fundedBy"></see></summary>
    let fundedBy = _prefix "fundedBy"
    /// <summary>
    /// points from a Study to the StudyGroup which contains the Study.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#inGroup"></see></summary>
    let inGroup = _prefix "inGroup"
    /// <summary>
    /// Indicates the original Variable of an aggregated qb:DataSet.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#inputVariable"></see></summary>
    let inputVariable = _prefix "inputVariable"
    /// <summary>
    /// Indicates the Instrument of a Study or a LogicalDataSet.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#instrument"></see></summary>
    let instrument = _prefix "instrument"
    /// <summary>
    /// The value true indicates that the dataset can be accessed (usually downloaded) by anyone.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#isPublic"></see></summary>
    let isPublic = _prefix "isPublic"
    /// <summary>
    /// Indicates if the code (represented by skos:Concept) is valid or missing.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#isValid"></see></summary>
    let isValid = _prefix "isValid"
    /// <summary>
    /// The general kind of data (e.g. geospatial, register, survey) collected in this study, given either as a skos:Concept, or as a blank node with attached free-text rdfs:label.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#kindOfData"></see></summary>
    let kindOfData = _prefix "kindOfData"
    /// <summary>
    /// Mapping from and to DDI-C
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#mappingDDI-C"></see></summary>
    let ``mappingDDI-C`` = _prefix "mappingDDI-C"
    /// <summary>
    /// Mapping from and to DDI-L
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#mappingDDI-L"></see></summary>
    let ``mappingDDI-L`` = _prefix "mappingDDI-L"
    /// <summary>
    /// percentage
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#percentage"></see></summary>
    let percentage = _prefix "percentage"
    /// <summary>
    /// Indicates the LogicalDataSets of a Studies.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#product"></see></summary>
    let product = _prefix "product"
    /// <summary>
    /// The purpose of a Study of a StudyGroup.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#purpose"></see></summary>
    let purpose = _prefix "purpose"
    /// <summary>
    /// Indicates the Questions associated to Variables or contained in Questionnaires.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#question"></see></summary>
    let question = _prefix "question"
    /// <summary>
    /// question text
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#questionText"></see></summary>
    let questionText = _prefix "questionText"
    /// <summary>
    /// RepresentedVariables and Variables can have a Representation whose individuals are either of the class rdfs:Datatype (to represent values) or skos:ConceptScheme (to represent code lists).
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#representation"></see></summary>
    let representation = _prefix "representation"
    /// <summary>
    /// The response domain of questions.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#responseDomain"></see></summary>
    let responseDomain = _prefix "responseDomain"
    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/discovery#Representation"></see>
    /// </summary>
    let Representation = _prefix "Representation"
    /// <summary>
    /// start date
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// Indicates the skos:Concept (representing codes and categories) of a specific CategoryStatistics individual.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsCategory"></see></summary>
    let statisticsCategory = _prefix "statisticsCategory"
    /// <summary>
    /// Indicates the DataFile of a specific DesciptiveStatistics individual.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsDataFile"></see></summary>
    let statisticsDataFile = _prefix "statisticsDataFile"
    /// <summary>
    /// Indicates the Variable of a specific SummaryStatistics individual.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsVariable"></see></summary>
    let statisticsVariable = _prefix "statisticsVariable"
    /// <summary>
    /// The sub-title of a Study of a StudyGroup.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#subtitle"></see></summary>
    let subtitle = _prefix "subtitle"
    /// <summary>
    /// summary statistics type
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#summaryStatisticsType"></see></summary>
    let summaryStatisticsType = _prefix "summaryStatisticsType"
    /// <summary>
    /// Indicates the Universe(s) of Studies, StudyGrous, RepresentedVariables, Variables, Questions, and LogicalDataSets.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#universe"></see></summary>
    let universe = _prefix "universe"
    /// <summary>
    /// Indicates the Variable of a Study.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#variable"></see></summary>
    let variable = _prefix "variable"
    /// <summary>
    /// SummaryStatistics or CategoryStatistics resources may be weighted by a specific Variable.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#weightedBy"></see></summary>
    let weightedBy = _prefix "weightedBy"
