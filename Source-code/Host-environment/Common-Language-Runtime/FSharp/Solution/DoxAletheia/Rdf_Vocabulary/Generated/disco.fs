namespace http.rdf_vocabulary.ddialliance.org.discovery.hash

open DoxAletheia.Rdf_Vocabulary

module disco =
    let _namespace_name = "http://rdf-vocabulary.ddialliance.org/discovery#"

    /// <summary>
    /// The process collecting data is focusing on the analysis of a particular type of subject. If, for example, the adult population of Finland is being studied, the AnalysisUnit would be individuals or persons.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#AnalysisUnit"></see></summary>
    let AnalysisUnit =
        Namespaced_IRI.parse _namespace_name "AnalysisUnit" |> NamespacedName

    /// <summary>
    /// For CategoryStatistics, frequencies, percentages, and weighted percentages can be defined.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#CategoryStatistics"></see></summary>
    let CategoryStatistics =
        Namespaced_IRI.parse _namespace_name "CategoryStatistics" |> NamespacedName

    /// <summary>
    /// SummaryStatistics pointing to variables and CategoryStatistics pointing to categories and codes are both DescriptiveStatistics.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#DescriptiveStatistics"></see></summary>
    let DescriptiveStatistics =
        Namespaced_IRI.parse _namespace_name "DescriptiveStatistics" |> NamespacedName

    /// <summary>
    /// The class DataFile, which is also a dcterms:Dataset, represents all the data files containing the microdata datasets.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#DataFile"></see></summary>
    let DataFile = Namespaced_IRI.parse _namespace_name "DataFile" |> NamespacedName
    /// <summary>
    /// The data for the study are collected by an Instrument. The purpose of an Instrument, i.e. an interview, a questionnaire or another entity used as a means of data collection, is in the case of a survey to record the flow of a questionnaire, its use of questions, and additional component parts. A questionnaire contains a flow of questions.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Instrument"></see></summary>
    let Instrument = Namespaced_IRI.parse _namespace_name "Instrument" |> NamespacedName

    /// <summary>
    /// Each study has a set of logical metadata associated with the processing of data, at the time of collection or later during cleaning, and re-coding. LogicalDataSet represents the microdata dataset.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#LogicalDataSet"></see></summary>
    let LogicalDataSet =
        Namespaced_IRI.parse _namespace_name "LogicalDataSet" |> NamespacedName

    /// <summary>
    /// Mappings betwenn DDI-RDF and DDI-XML
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Mapping"></see></summary>
    let Mapping = Namespaced_IRI.parse _namespace_name "Mapping" |> NamespacedName
    /// <summary>
    /// A Question is designed to get information upon a subject, or sequence of subjects, from a respondent.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Question"></see></summary>
    let Question = Namespaced_IRI.parse _namespace_name "Question" |> NamespacedName

    /// <summary>
    /// A questionnaire contains a flow of questions.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Questionnaire"></see></summary>
    let Questionnaire =
        Namespaced_IRI.parse _namespace_name "Questionnaire" |> NamespacedName

    /// <summary>
    /// RepresentedVariables encompasse study-independent, re-usable parts of variables like occupation classification.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#RepresentedVariable"></see></summary>
    let RepresentedVariable =
        Namespaced_IRI.parse _namespace_name "RepresentedVariable" |> NamespacedName

    /// <summary>
    /// A Study represents the process by which a data set was generated or collected.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Study"></see></summary>
    let Study = Namespaced_IRI.parse _namespace_name "Study" |> NamespacedName
    /// <summary>
    /// In some cases, where data collection is cyclic or on-going, data sets may be released as a StudyGroup, where each cycle or wave of the data collection activity produces one or more data sets. This is typical for longitudinal studies, panel studies, and other types of series (to use the DDI term). In this case, a number of Study objects would be collected into a single StudyGroup.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#StudyGroup"></see></summary>
    let StudyGroup = Namespaced_IRI.parse _namespace_name "StudyGroup" |> NamespacedName

    /// <summary>
    /// For SummaryStatistics, maximum values, minimum values, and standard deviations can be defined.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#SummaryStatistics"></see></summary>
    let SummaryStatistics =
        Namespaced_IRI.parse _namespace_name "SummaryStatistics" |> NamespacedName

    /// <summary>
    /// A Universe is the total membership or population of a defined class of people, objects or events.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Universe"></see></summary>
    let Universe = Namespaced_IRI.parse _namespace_name "Universe" |> NamespacedName
    /// <summary>
    /// Variables provide a definition of the column in a rectangular data file. Variable is a characteristic of a unit being observed. A variable might be the answer of a question, have an administrative source, or be derived from other variables.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#Variable"></see></summary>
    let Variable = Namespaced_IRI.parse _namespace_name "Variable" |> NamespacedName

    /// <summary>
    /// points to the aggregated data set of a microdata data set.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#aggregation"></see></summary>
    let aggregation =
        Namespaced_IRI.parse _namespace_name "aggregation" |> NamespacedName

    /// <summary>
    /// analysis unit of a Study, a StudyGroup, or a Variable.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#analysisUnit"></see></summary>
    let analysisUnit =
        Namespaced_IRI.parse _namespace_name "analysisUnit" |> NamespacedName

    /// <summary>
    /// points to the RepresentedVariable the Variable is based on.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#basedOn"></see></summary>
    let basedOn = Namespaced_IRI.parse _namespace_name "basedOn" |> NamespacedName

    /// <summary>
    /// case quantity of a DataFile.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#caseQuantity"></see></summary>
    let caseQuantity =
        Namespaced_IRI.parse _namespace_name "caseQuantity" |> NamespacedName

    /// <summary>
    /// mode of collection of a Questionnaire
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#collectionMode"></see></summary>
    let collectionMode =
        Namespaced_IRI.parse _namespace_name "collectionMode" |> NamespacedName

    /// <summary>
    /// computation base
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#computationBase"></see></summary>
    let computationBase =
        Namespaced_IRI.parse _namespace_name "computationBase" |> NamespacedName

    /// <summary>
    /// points to the DDI concept of a RepresentedVariable, a Variable, or a Question
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#concept"></see></summary>
    let concept = Namespaced_IRI.parse _namespace_name "concept" |> NamespacedName

    /// <summary>
    /// points to Variable contained in the LogicalDataSet
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#containsVariable"></see></summary>
    let containsVariable =
        Namespaced_IRI.parse _namespace_name "containsVariable" |> NamespacedName

    /// <summary>
    /// context specifies conditions which have to be fulfilled for specific mappings
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#context"></see></summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName

    /// <summary>
    /// cumulative percentage
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#cumulativePercentage"></see></summary>
    let cumulativePercentage =
        Namespaced_IRI.parse _namespace_name "cumulativePercentage" |> NamespacedName

    /// <summary>
    /// points to the DataFile of a Study or a LogicalDataSet.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#dataFile"></see></summary>
    let dataFile = Namespaced_IRI.parse _namespace_name "dataFile" |> NamespacedName
    /// <summary>
    /// points from a Study or a StudyGroup to the original DDI file which is a foaf:Document.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#ddifile"></see></summary>
    let ddifile = Namespaced_IRI.parse _namespace_name "ddifile" |> NamespacedName
    /// <summary>
    /// end date
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#endDate"></see></summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName

    /// <summary>
    /// points from an Instrument to a foaf:Document which is the external documentation of the Instrument.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#externalDocumentation"></see></summary>
    let externalDocumentation =
        Namespaced_IRI.parse _namespace_name "externalDocumentation" |> NamespacedName

    /// <summary>
    /// frequency
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#frequency"></see></summary>
    let frequency = Namespaced_IRI.parse _namespace_name "frequency" |> NamespacedName
    /// <summary>
    /// points from a Study or a StudyGroup to the funding foaf:Agent which is either a foaf:Person or a org:Organization.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#fundedBy"></see></summary>
    let fundedBy = Namespaced_IRI.parse _namespace_name "fundedBy" |> NamespacedName
    /// <summary>
    /// points from a Study to the StudyGroup which contains the Study.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#inGroup"></see></summary>
    let inGroup = Namespaced_IRI.parse _namespace_name "inGroup" |> NamespacedName

    /// <summary>
    /// Indicates the original Variable of an aggregated qb:DataSet.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#inputVariable"></see></summary>
    let inputVariable =
        Namespaced_IRI.parse _namespace_name "inputVariable" |> NamespacedName

    /// <summary>
    /// Indicates the Instrument of a Study or a LogicalDataSet.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#instrument"></see></summary>
    let instrument = Namespaced_IRI.parse _namespace_name "instrument" |> NamespacedName
    /// <summary>
    /// The value true indicates that the dataset can be accessed (usually downloaded) by anyone.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#isPublic"></see></summary>
    let isPublic = Namespaced_IRI.parse _namespace_name "isPublic" |> NamespacedName
    /// <summary>
    /// Indicates if the code (represented by skos:Concept) is valid or missing.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#isValid"></see></summary>
    let isValid = Namespaced_IRI.parse _namespace_name "isValid" |> NamespacedName
    /// <summary>
    /// The general kind of data (e.g. geospatial, register, survey) collected in this study, given either as a skos:Concept, or as a blank node with attached free-text rdfs:label.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#kindOfData"></see></summary>
    let kindOfData = Namespaced_IRI.parse _namespace_name "kindOfData" |> NamespacedName

    /// <summary>
    /// Mapping from and to DDI-C
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#mappingDDI-C"></see></summary>
    let ``mappingDDI-C`` =
        Namespaced_IRI.parse _namespace_name "mappingDDI-C" |> NamespacedName

    /// <summary>
    /// Mapping from and to DDI-L
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#mappingDDI-L"></see></summary>
    let ``mappingDDI-L`` =
        Namespaced_IRI.parse _namespace_name "mappingDDI-L" |> NamespacedName

    /// <summary>
    /// percentage
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#percentage"></see></summary>
    let percentage = Namespaced_IRI.parse _namespace_name "percentage" |> NamespacedName
    /// <summary>
    /// Indicates the LogicalDataSets of a Studies.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#product"></see></summary>
    let product = Namespaced_IRI.parse _namespace_name "product" |> NamespacedName
    /// <summary>
    /// The purpose of a Study of a StudyGroup.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#purpose"></see></summary>
    let purpose = Namespaced_IRI.parse _namespace_name "purpose" |> NamespacedName
    /// <summary>
    /// Indicates the Questions associated to Variables or contained in Questionnaires.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#question"></see></summary>
    let question = Namespaced_IRI.parse _namespace_name "question" |> NamespacedName

    /// <summary>
    /// question text
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#questionText"></see></summary>
    let questionText =
        Namespaced_IRI.parse _namespace_name "questionText" |> NamespacedName

    /// <summary>
    /// RepresentedVariables and Variables can have a Representation whose individuals are either of the class rdfs:Datatype (to represent values) or skos:ConceptScheme (to represent code lists).
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#representation"></see></summary>
    let representation =
        Namespaced_IRI.parse _namespace_name "representation" |> NamespacedName

    /// <summary>
    /// The response domain of questions.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#responseDomain"></see></summary>
    let responseDomain =
        Namespaced_IRI.parse _namespace_name "responseDomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf-vocabulary.ddialliance.org/discovery#Representation"></see>
    /// </summary>
    let Representation =
        Namespaced_IRI.parse _namespace_name "Representation" |> NamespacedName

    /// <summary>
    /// start date
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName

    /// <summary>
    /// Indicates the skos:Concept (representing codes and categories) of a specific CategoryStatistics individual.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsCategory"></see></summary>
    let statisticsCategory =
        Namespaced_IRI.parse _namespace_name "statisticsCategory" |> NamespacedName

    /// <summary>
    /// Indicates the DataFile of a specific DesciptiveStatistics individual.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsDataFile"></see></summary>
    let statisticsDataFile =
        Namespaced_IRI.parse _namespace_name "statisticsDataFile" |> NamespacedName

    /// <summary>
    /// Indicates the Variable of a specific SummaryStatistics individual.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsVariable"></see></summary>
    let statisticsVariable =
        Namespaced_IRI.parse _namespace_name "statisticsVariable" |> NamespacedName

    /// <summary>
    /// The sub-title of a Study of a StudyGroup.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#subtitle"></see></summary>
    let subtitle = Namespaced_IRI.parse _namespace_name "subtitle" |> NamespacedName

    /// <summary>
    /// summary statistics type
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#summaryStatisticsType"></see></summary>
    let summaryStatisticsType =
        Namespaced_IRI.parse _namespace_name "summaryStatisticsType" |> NamespacedName

    /// <summary>
    /// Indicates the Universe(s) of Studies, StudyGrous, RepresentedVariables, Variables, Questions, and LogicalDataSets.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#universe"></see></summary>
    let universe = Namespaced_IRI.parse _namespace_name "universe" |> NamespacedName
    /// <summary>
    /// Indicates the Variable of a Study.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#variable"></see></summary>
    let variable = Namespaced_IRI.parse _namespace_name "variable" |> NamespacedName
    /// <summary>
    /// SummaryStatistics or CategoryStatistics resources may be weighted by a specific Variable.
    /// <see href="http://rdf-vocabulary.ddialliance.org/discovery#weightedBy"></see></summary>
    let weightedBy = Namespaced_IRI.parse _namespace_name "weightedBy" |> NamespacedName
