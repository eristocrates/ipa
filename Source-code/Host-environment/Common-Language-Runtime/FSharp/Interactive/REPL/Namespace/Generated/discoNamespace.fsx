#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module disco =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdf-vocabulary.ddialliance.org/discovery#" "disco"

    /// <summary>
    ///   <para>rdfs:comment : The process collecting data is focusing on the analysis of a particular type of subject. If, for example, the adult population of Finland is being studied, the AnalysisUnit would be individuals or persons.</para>
    ///   <para>rdfs:label : Analyseeinheitrdfs:label : Analysis Unit</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#AnalysisUnit">disco:AnalysisUnit</a>
    /// </summary>
    let AnalysisUnit = _prefixId.prefix "AnalysisUnit"
    /// <summary>
    ///   <para>rdfs:comment : For CategoryStatistics, frequencies, percentages, and weighted percentages can be defined.</para>
    ///   <para>rdfs:label : Category statistics</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#CategoryStatistics">disco:CategoryStatistics</a>
    /// </summary>
    let CategoryStatistics = _prefixId.prefix "CategoryStatistics"
    /// <summary>
    ///   <para>rdfs:comment : The class DataFile, which is also a dcterms:Dataset, represents all the data files containing the microdata datasets.</para>
    ///   <para>rdfs:label : Fichier de donnéesrdfs:label : Data file</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#DataFile">disco:DataFile</a>
    /// </summary>
    let DataFile = _prefixId.prefix "DataFile"
    /// <summary>
    ///   <para>rdfs:comment : SummaryStatistics pointing to variables and CategoryStatistics pointing to categories and codes are both DescriptiveStatistics.</para>
    ///   <para>rdfs:label : Statistique descriptiverdfs:label : Descriptive statistics</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#DescriptiveStatistics">disco:DescriptiveStatistics</a>
    /// </summary>
    let DescriptiveStatistics = _prefixId.prefix "DescriptiveStatistics"
    /// <summary>
    ///   <para>rdfs:comment : The data for the study are collected by an Instrument. The purpose of an Instrument, i.e. an interview, a questionnaire or another entity used as a means of data collection, is in the case of a survey to record the flow of a questionnaire, its use of questions, and additional component parts. A questionnaire contains a flow of questions.</para>
    ///   <para>rdfs:label : Instrument de collecterdfs:label : Instrument</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#Instrument">disco:Instrument</a>
    /// </summary>
    let Instrument = _prefixId.prefix "Instrument"
    /// <summary>
    ///   <para>rdfs:comment : Each study has a set of logical metadata associated with the processing of data, at the time of collection or later during cleaning, and re-coding. LogicalDataSet represents the microdata dataset.</para>
    ///   <para>rdfs:label : Ensemble de donnéesrdfs:label : LogicalDataSet</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#LogicalDataSet">disco:LogicalDataSet</a>
    /// </summary>
    let LogicalDataSet = _prefixId.prefix "LogicalDataSet"
    /// <summary>
    ///   <para>rdfs:comment : Mappings betwenn DDI-RDF and DDI-XML</para>
    ///   <para>rdfs:label : Mapping</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#Mapping">disco:Mapping</a>
    /// </summary>
    let Mapping = _prefixId.prefix "Mapping"
    /// <summary>
    ///   <para>rdfs:comment : A Question is designed to get information upon a subject, or sequence of subjects, from a respondent.</para>
    ///   <para>rdfs:label : Questionrdfs:label : Question</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#Question">disco:Question</a>
    /// </summary>
    let Question = _prefixId.prefix "Question"
    /// <summary>
    ///   <para>rdfs:comment : A questionnaire contains a flow of questions. </para>
    ///   <para>rdfs:label : Fragebogenrdfs:label : Questionnaire</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#Questionnaire">disco:Questionnaire</a>
    /// </summary>
    let Questionnaire = _prefixId.prefix "Questionnaire"
    let Representation = _prefixId.prefix "Representation"
    /// <summary>
    ///   <para>rdfs:comment : RepresentedVariables encompasse study-independent, re-usable parts of variables like occupation classification.</para>
    ///   <para>rdfs:label : Élément de donnéerdfs:label : Data element</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#RepresentedVariable">disco:RepresentedVariable</a>
    /// </summary>
    let RepresentedVariable = _prefixId.prefix "RepresentedVariable"
    /// <summary>
    ///   <para>rdfs:comment : A Study represents the process by which a data set was generated or collected.</para>
    ///   <para>rdfs:label : Étuderdfs:label : Study</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#Study">disco:Study</a>
    /// </summary>
    let Study = _prefixId.prefix "Study"
    /// <summary>
    ///   <para>rdfs:comment : In some cases, where data collection is cyclic or on-going, data sets may be released as a StudyGroup, where each cycle or wave of the data collection activity produces one or more data sets. This is typical for longitudinal studies, panel studies, and other types of series (to use the DDI term). In this case, a number of Study objects would be collected into a single StudyGroup.</para>
    ///   <para>rdfs:label : Studiengrupperdfs:label : Study Group</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#StudyGroup">disco:StudyGroup</a>
    /// </summary>
    let StudyGroup = _prefixId.prefix "StudyGroup"
    /// <summary>
    ///   <para>rdfs:comment : For SummaryStatistics, maximum values, minimum values, and standard deviations can be defined.</para>
    ///   <para>rdfs:label : Summary statistics</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#SummaryStatistics">disco:SummaryStatistics</a>
    /// </summary>
    let SummaryStatistics = _prefixId.prefix "SummaryStatistics"
    /// <summary>
    ///   <para>rdfs:comment : A Universe is the total membership or population of a defined class of people, objects or events.</para>
    ///   <para>rdfs:label : Universrdfs:label : Universe</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#Universe">disco:Universe</a>
    /// </summary>
    let Universe = _prefixId.prefix "Universe"
    /// <summary>
    ///   <para>rdfs:comment : Variables provide a definition of the column in a rectangular data file. Variable is a characteristic of a unit being observed. A variable might be the answer of a question, have an administrative source, or be derived from other variables.</para>
    ///   <para>rdfs:label : Variablerdfs:label : Variable</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#Variable">disco:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    /// <summary>
    ///   <para>rdfs:comment : points to the aggregated data set of a microdata data set.</para>
    ///   <para>rdfs:label : aggregation</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#aggregation">disco:aggregation</a>
    /// </summary>
    let aggregation = _prefixId.prefix "aggregation"
    /// <summary>
    ///   <para>rdfs:comment : analysis unit of a Study, a StudyGroup, or a Variable.</para>
    ///   <para>rdfs:label : Analyseeinheitrdfs:label : analysis unit</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#analysisUnit">disco:analysisUnit</a>
    /// </summary>
    let analysisUnit = _prefixId.prefix "analysisUnit"
    /// <summary>
    ///   <para>rdfs:comment : points to the RepresentedVariable the Variable is based on.</para>
    ///   <para>rdfs:label : utilise l'élément de donnéerdfs:label : based on</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#basedOn">disco:basedOn</a>
    /// </summary>
    let basedOn = _prefixId.prefix "basedOn"
    /// <summary>
    ///   <para>rdfs:comment : case quantity of a DataFile.</para>
    ///   <para>rdfs:label : nombre d'observationsrdfs:label : number of cases</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#caseQuantity">disco:caseQuantity</a>
    /// </summary>
    let caseQuantity = _prefixId.prefix "caseQuantity"
    /// <summary>
    ///   <para>rdfs:comment : mode of collection of a Questionnaire</para>
    ///   <para>rdfs:label : Datenerfassungsmodusrdfs:label : collection mode</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#collectionMode">disco:collectionMode</a>
    /// </summary>
    let collectionMode = _prefixId.prefix "collectionMode"
    /// <summary>
    ///   <para>rdfs:comment : computation base</para>
    ///   <para>rdfs:label : pourcentagerdfs:label : computation base</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#computationBase">disco:computationBase</a>
    /// </summary>
    let computationBase = _prefixId.prefix "computationBase"
    /// <summary>
    ///   <para>rdfs:comment : points to the DDI concept of a RepresentedVariable, a Variable, or a Question</para>
    ///   <para>rdfs:label : a pour conceptrdfs:label : concept</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#concept">disco:concept</a>
    /// </summary>
    let concept = _prefixId.prefix "concept"
    /// <summary>
    ///   <para>rdfs:comment : points to Variable contained in the LogicalDataSet</para>
    ///   <para>rdfs:label : contient la variablerdfs:label : contains variable</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#containsVariable">disco:containsVariable</a>
    /// </summary>
    let containsVariable = _prefixId.prefix "containsVariable"
    /// <summary>
    ///   <para>rdfs:comment : context specifies conditions which have to be fulfilled for specific mappings</para>
    ///   <para>rdfs:label : context specifies conditions which have to be fulfilled for specific mappings</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#context">disco:context</a>
    /// </summary>
    let context = _prefixId.prefix "context"
    /// <summary>
    ///   <para>rdfs:comment : cumulative percentage</para>
    ///   <para>rdfs:label : cumulative percentage</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#cumulativePercentage">disco:cumulativePercentage</a>
    /// </summary>
    let cumulativePercentage = _prefixId.prefix "cumulativePercentage"
    /// <summary>
    ///   <para>rdfs:comment : points to the DataFile of a Study or a LogicalDataSet.</para>
    ///   <para>rdfs:label : a pour fichier de donnéesrdfs:label : data file</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#dataFile">disco:dataFile</a>
    /// </summary>
    let dataFile = _prefixId.prefix "dataFile"
    /// <summary>
    ///   <para>rdfs:comment : points from a Study or a StudyGroup to the original DDI file which is a foaf:Document.</para>
    ///   <para>rdfs:label : DDI-Dateirdfs:label : DDI file</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#ddifile">disco:ddifile</a>
    /// </summary>
    let ddifile = _prefixId.prefix "ddifile"
    /// <summary>
    ///   <para>rdfs:comment : end date</para>
    ///   <para>rdfs:label : end date</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#endDate">disco:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:comment : points from an Instrument to a foaf:Document which is the external documentation of the Instrument.</para>
    ///   <para>rdfs:label : externe Dokumentationrdfs:label : external documentation</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#externalDocumentation">disco:externalDocumentation</a>
    /// </summary>
    let externalDocumentation = _prefixId.prefix "externalDocumentation"
    /// <summary>
    ///   <para>rdfs:comment : frequency</para>
    ///   <para>rdfs:label : fréquencerdfs:label : frequency</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#frequency">disco:frequency</a>
    /// </summary>
    let frequency = _prefixId.prefix "frequency"
    /// <summary>
    ///   <para>rdfs:comment : points from a Study or a StudyGroup to the funding foaf:Agent which is either a foaf:Person or a org:Organization.</para>
    ///   <para>rdfs:label : funded by</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#fundedBy">disco:fundedBy</a>
    /// </summary>
    let fundedBy = _prefixId.prefix "fundedBy"
    /// <summary>
    ///   <para>rdfs:comment : points from a Study to the StudyGroup which contains the Study.</para>
    ///   <para>rdfs:label : in group</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#inGroup">disco:inGroup</a>
    /// </summary>
    let inGroup = _prefixId.prefix "inGroup"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the original Variable of an aggregated qb:DataSet.</para>
    ///   <para>rdfs:label : variable en entréerdfs:label : input variable</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#inputVariable">disco:inputVariable</a>
    /// </summary>
    let inputVariable = _prefixId.prefix "inputVariable"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the Instrument of a Study or a LogicalDataSet.</para>
    ///   <para>rdfs:label : a comme instrumentrdfs:label : instrument</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#instrument">disco:instrument</a>
    /// </summary>
    let instrument = _prefixId.prefix "instrument"
    /// <summary>
    ///   <para>rdfs:comment : The value true indicates that the dataset can be accessed (usually downloaded) by anyone.</para>
    ///   <para>rdfs:label : ist öffentlichrdfs:label : is public</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#isPublic">disco:isPublic</a>
    /// </summary>
    let isPublic = _prefixId.prefix "isPublic"
    /// <summary>
    ///   <para>rdfs:comment : Indicates if the code (represented by skos:Concept) is valid or missing.</para>
    ///   <para>rdfs:label : is valid</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#isValid">disco:isValid</a>
    /// </summary>
    let isValid = _prefixId.prefix "isValid"
    /// <summary>
    ///   <para>rdfs:comment : The general kind of data (e.g. geospatial, register, survey) collected in this study, given either as a skos:Concept, or as a blank node with attached free-text rdfs:label.^^xsd:string</para>
    ///   <para>rdfs:label : kind of data</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#kindOfData">disco:kindOfData</a>
    /// </summary>
    let kindOfData = _prefixId.prefix "kindOfData"
    /// <summary>
    ///   <para>rdfs:comment : Mapping from and to DDI-C</para>
    ///   <para>rdfs:label : Mapping from and to DDI-C</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#mappingDDI-C">disco:mappingDDI-C</a>
    /// </summary>
    let mappingDDI_C = _prefixId.prefix "mappingDDI-C"
    /// <summary>
    ///   <para>rdfs:comment : Mapping from and to DDI-L</para>
    ///   <para>rdfs:label : Mapping from and to DDI-L</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#mappingDDI-L">disco:mappingDDI-L</a>
    /// </summary>
    let mappingDDI_L = _prefixId.prefix "mappingDDI-L"
    /// <summary>
    ///   <para>rdfs:comment : percentage</para>
    ///   <para>rdfs:label : pourcentagerdfs:label : percentage</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#percentage">disco:percentage</a>
    /// </summary>
    let percentage = _prefixId.prefix "percentage"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the LogicalDataSets of a Studies.</para>
    ///   <para>rdfs:label : Produktrdfs:label : product</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#product">disco:product</a>
    /// </summary>
    let product = _prefixId.prefix "product"
    /// <summary>
    ///   <para>rdfs:comment : The purpose of a Study of a StudyGroup.</para>
    ///   <para>rdfs:label : Grundrdfs:label : purpose</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#purpose">disco:purpose</a>
    /// </summary>
    let purpose = _prefixId.prefix "purpose"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the Questions associated to Variables or contained in Questionnaires.</para>
    ///   <para>rdfs:label : a comme questionrdfs:label : question</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#question">disco:question</a>
    /// </summary>
    let question = _prefixId.prefix "question"
    /// <summary>
    ///   <para>rdfs:comment : question text</para>
    ///   <para>rdfs:label : Fragetextrdfs:label : question text</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#questionText">disco:questionText</a>
    /// </summary>
    let questionText = _prefixId.prefix "questionText"
    /// <summary>
    ///   <para>rdfs:comment : RepresentedVariables and Variables can have a Representation whose individuals are either of the class rdfs:Datatype (to represent values) or skos:ConceptScheme (to represent code lists).</para>
    ///   <para>rdfs:label : a pour représentationrdfs:label : representation</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#representation">disco:representation</a>
    /// </summary>
    let representation = _prefixId.prefix "representation"
    /// <summary>
    ///   <para>rdfs:comment : The response domain of questions.</para>
    ///   <para>rdfs:label : responseDomain</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#responseDomain">disco:responseDomain</a>
    /// </summary>
    let responseDomain = _prefixId.prefix "responseDomain"
    /// <summary>
    ///   <para>rdfs:comment : start date</para>
    ///   <para>rdfs:label : start date</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#startDate">disco:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the skos:Concept (representing codes and categories) of a specific CategoryStatistics individual.</para>
    ///   <para>rdfs:label : a pour concept statistiquerdfs:label : statistics category</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsCategory">disco:statisticsCategory</a>
    /// </summary>
    let statisticsCategory = _prefixId.prefix "statisticsCategory"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the DataFile of a specific DesciptiveStatistics individual.</para>
    ///   <para>rdfs:label : a pour fichier statistiquerdfs:label : statistics data file</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsDataFile">disco:statisticsDataFile</a>
    /// </summary>
    let statisticsDataFile = _prefixId.prefix "statisticsDataFile"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the Variable of a specific SummaryStatistics individual.</para>
    ///   <para>rdfs:label : a pour variable statistiquerdfs:label : statistics variable</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsVariable">disco:statisticsVariable</a>
    /// </summary>
    let statisticsVariable = _prefixId.prefix "statisticsVariable"
    /// <summary>
    ///   <para>rdfs:comment : The sub-title of a Study of a StudyGroup.</para>
    ///   <para>rdfs:label : Untertitelrdfs:label : subtitle</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#subtitle">disco:subtitle</a>
    /// </summary>
    let subtitle = _prefixId.prefix "subtitle"
    /// <summary>
    ///   <para>rdfs:comment : summary statistics type</para>
    ///   <para>rdfs:label : summary statistics type</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#summaryStatisticsType">disco:summaryStatisticsType</a>
    /// </summary>
    let summaryStatisticsType = _prefixId.prefix "summaryStatisticsType"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the Universe(s) of Studies, StudyGrous, RepresentedVariables, Variables, Questions, and LogicalDataSets.</para>
    ///   <para>rdfs:label : a comme universrdfs:label : universe</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#universe">disco:universe</a>
    /// </summary>
    let universe = _prefixId.prefix "universe"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the Variable of a Study.</para>
    ///   <para>rdfs:label : Variablerdfs:label : variable</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#variable">disco:variable</a>
    /// </summary>
    let variable = _prefixId.prefix "variable"
    /// <summary>
    ///   <para>rdfs:comment : SummaryStatistics or CategoryStatistics resources may be weighted by a specific Variable.</para>
    ///   <para>rdfs:label : rdfs:label : weighted by</para>
    ///   <a href="http://rdf-vocabulary.ddialliance.org/discovery#weightedBy">disco:weightedBy</a>
    /// </summary>
    let weightedBy = _prefixId.prefix "weightedBy"
