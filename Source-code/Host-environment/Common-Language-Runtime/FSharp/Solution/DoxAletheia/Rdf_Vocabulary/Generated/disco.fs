namespace http.rdf_vocabulary.ddialliance.org.discovery.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module disco =
    let _namespace_iri = Namespace_Iri disco |> NamespaceIRI
    /// <summary>
    ///   <para>disco:CategoryStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>For CategoryStatistics, frequencies, percentages, and weighted percentages can be defined.</para>
    /// labels<para>Category statistics</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#CategoryStatistics">http://rdf-vocabulary.ddialliance.org/discovery#CategoryStatistics</seealso>
    let CategoryStatistics = Prefixed_Name(disco, "CategoryStatistics") |> PrefixedName
    /// <summary>
    ///   <para>disco:LogicalDataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Each study has a set of logical metadata associated with the processing of data, at the time of collection or later during cleaning, and re-coding. LogicalDataSet represents the microdata dataset.</para>
    /// labels<para>Ensemble de données</para><para>LogicalDataSet</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#LogicalDataSet">http://rdf-vocabulary.ddialliance.org/discovery#LogicalDataSet</seealso>
    let LogicalDataSet = Prefixed_Name(disco, "LogicalDataSet") |> PrefixedName
    /// <summary>
    ///   <para>disco:Mapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Mappings betwenn DDI-RDF and DDI-XML</para>
    /// labels<para>Mapping</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#Mapping">http://rdf-vocabulary.ddialliance.org/discovery#Mapping</seealso>
    let Mapping = Prefixed_Name(disco, "Mapping") |> PrefixedName
    /// <summary>
    ///   <para>disco:Question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A Question is designed to get information upon a subject, or sequence of subjects, from a respondent.</para>
    /// labels<para>Question</para><para>Question</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#Question">http://rdf-vocabulary.ddialliance.org/discovery#Question</seealso>
    let Question = Prefixed_Name(disco, "Question") |> PrefixedName
    /// <summary>
    ///   <para>disco:StudyGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>In some cases, where data collection is cyclic or on-going, data sets may be released as a StudyGroup, where each cycle or wave of the data collection activity produces one or more data sets. This is typical for longitudinal studies, panel studies, and other types of series (to use the DDI term). In this case, a number of Study objects would be collected into a single StudyGroup.</para>
    /// labels<para>Studiengruppe</para><para>Study Group</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#StudyGroup">http://rdf-vocabulary.ddialliance.org/discovery#StudyGroup</seealso>
    let StudyGroup = Prefixed_Name(disco, "StudyGroup") |> PrefixedName
    /// <summary>
    ///   <para>disco:questionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>question text</para>
    /// labels<para>question text</para><para>Fragetext</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#questionText">http://rdf-vocabulary.ddialliance.org/discovery#questionText</seealso>
    let questionText = Prefixed_Name(disco, "questionText") |> PrefixedName
    /// <summary>
    ///   <para>disco:AnalysisUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The process collecting data is focusing on the analysis of a particular type of subject. If, for example, the adult population of Finland is being studied, the AnalysisUnit would be individuals or persons.</para>
    /// labels<para>Analyseeinheit</para><para>Analysis Unit</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#AnalysisUnit">http://rdf-vocabulary.ddialliance.org/discovery#AnalysisUnit</seealso>
    let AnalysisUnit = Prefixed_Name(disco, "AnalysisUnit") |> PrefixedName
    /// <summary>
    ///   <para>disco:DataFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The class DataFile, which is also a dcterms:Dataset, represents all the data files containing the microdata datasets.</para>
    /// labels<para>Fichier de données</para><para>Data file</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#DataFile">http://rdf-vocabulary.ddialliance.org/discovery#DataFile</seealso>
    let DataFile = Prefixed_Name(disco, "DataFile") |> PrefixedName
    /// <summary>
    ///   <para>disco:Study</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A Study represents the process by which a data set was generated or collected.</para>
    /// labels<para>Study</para><para>Étude</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#Study">http://rdf-vocabulary.ddialliance.org/discovery#Study</seealso>
    let Study = Prefixed_Name(disco, "Study") |> PrefixedName
    /// <summary>
    ///   <para>disco:fundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>points from a Study or a StudyGroup to the funding foaf:Agent which is either a foaf:Person or a org:Organization.</para>
    /// labels<para>funded by</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#fundedBy">http://rdf-vocabulary.ddialliance.org/discovery#fundedBy</seealso>
    let fundedBy = Prefixed_Name(disco, "fundedBy") |> PrefixedName
    /// <summary>
    ///   <para>disco:inGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>points from a Study to the StudyGroup which contains the Study.</para>
    /// labels<para>in group</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#inGroup">http://rdf-vocabulary.ddialliance.org/discovery#inGroup</seealso>
    let inGroup = Prefixed_Name(disco, "inGroup") |> PrefixedName
    /// <summary>
    ///   <para>disco:instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the Instrument of a Study or a LogicalDataSet.</para>
    /// labels<para>a comme instrument</para><para>instrument</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#instrument">http://rdf-vocabulary.ddialliance.org/discovery#instrument</seealso>
    let instrument = Prefixed_Name(disco, "instrument") |> PrefixedName
    /// <summary>
    ///   <para>disco:kindOfData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The general kind of data (e.g. geospatial, register, survey) collected in this study, given either as a skos:Concept, or as a blank node with attached free-text rdfs:label.</para>
    /// labels<para>kind of data</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#kindOfData">http://rdf-vocabulary.ddialliance.org/discovery#kindOfData</seealso>
    let kindOfData = Prefixed_Name(disco, "kindOfData") |> PrefixedName
    /// <summary>
    ///   <para>disco:Universe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A Universe is the total membership or population of a defined class of people, objects or events.</para>
    /// labels<para>Universe</para><para>Univers</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#Universe">http://rdf-vocabulary.ddialliance.org/discovery#Universe</seealso>
    let Universe = Prefixed_Name(disco, "Universe") |> PrefixedName
    /// <summary>
    ///   <para>disco:Variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Variables provide a definition of the column in a rectangular data file. Variable is a characteristic of a unit being observed. A variable might be the answer of a question, have an administrative source, or be derived from other variables.</para>
    /// labels<para>Variable</para><para>Variable</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#Variable">http://rdf-vocabulary.ddialliance.org/discovery#Variable</seealso>
    let Variable = Prefixed_Name(disco, "Variable") |> PrefixedName
    /// <summary>
    ///   <para>disco:caseQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>case quantity of a DataFile.</para>
    /// labels<para>nombre d'observations</para><para>number of cases</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#caseQuantity">http://rdf-vocabulary.ddialliance.org/discovery#caseQuantity</seealso>
    let caseQuantity = Prefixed_Name(disco, "caseQuantity") |> PrefixedName
    /// <summary>
    ///   <para>disco:computationBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>computation base</para>
    /// labels<para>computation base</para><para>pourcentage</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#computationBase">http://rdf-vocabulary.ddialliance.org/discovery#computationBase</seealso>
    let computationBase = Prefixed_Name(disco, "computationBase") |> PrefixedName
    /// <summary>
    ///   <para>disco:analysisUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>analysis unit of a Study, a StudyGroup, or a Variable.</para>
    /// labels<para>Analyseeinheit</para><para>analysis unit</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#analysisUnit">http://rdf-vocabulary.ddialliance.org/discovery#analysisUnit</seealso>
    let analysisUnit = Prefixed_Name(disco, "analysisUnit") |> PrefixedName
    /// <summary>
    ///   <para>disco:collectionMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>mode of collection of a Questionnaire</para>
    /// labels<para>Datenerfassungsmodus</para><para>collection mode</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#collectionMode">http://rdf-vocabulary.ddialliance.org/discovery#collectionMode</seealso>
    let collectionMode = Prefixed_Name(disco, "collectionMode") |> PrefixedName
    /// <summary>
    ///   <para>disco:containsVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>points to Variable contained in the LogicalDataSet</para>
    /// labels<para>contient la variable</para><para>contains variable</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#containsVariable">http://rdf-vocabulary.ddialliance.org/discovery#containsVariable</seealso>
    let containsVariable = Prefixed_Name(disco, "containsVariable") |> PrefixedName

    /// <summary>
    ///   <para>disco:cumulativePercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>cumulative percentage</para>
    /// labels<para>cumulative percentage</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#cumulativePercentage">http://rdf-vocabulary.ddialliance.org/discovery#cumulativePercentage</seealso>
    let cumulativePercentage =
        Prefixed_Name(disco, "cumulativePercentage") |> PrefixedName

    /// <summary>
    ///   <para>disco:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>end date</para>
    /// labels<para>end date</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#endDate">http://rdf-vocabulary.ddialliance.org/discovery#endDate</seealso>
    let endDate = Prefixed_Name(disco, "endDate") |> PrefixedName

    /// <summary>
    ///   <para>disco:externalDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>points from an Instrument to a foaf:Document which is the external documentation of the Instrument.</para>
    /// labels<para>external documentation</para><para>externe Dokumentation</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#externalDocumentation">http://rdf-vocabulary.ddialliance.org/discovery#externalDocumentation</seealso>
    let externalDocumentation =
        Prefixed_Name(disco, "externalDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>disco:aggregation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>points to the aggregated data set of a microdata data set.</para>
    /// labels<para>aggregation</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#aggregation">http://rdf-vocabulary.ddialliance.org/discovery#aggregation</seealso>
    let aggregation = Prefixed_Name(disco, "aggregation") |> PrefixedName
    /// <summary>
    ///   <para>disco:basedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>points to the RepresentedVariable the Variable is based on.</para>
    /// labels<para>utilise l'élément de donnée</para><para>based on</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#basedOn">http://rdf-vocabulary.ddialliance.org/discovery#basedOn</seealso>
    let basedOn = Prefixed_Name(disco, "basedOn") |> PrefixedName
    /// <summary>
    ///   <para>disco:concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>points to the DDI concept of a RepresentedVariable, a Variable, or a Question</para>
    /// labels<para>a pour concept</para><para>concept</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#concept">http://rdf-vocabulary.ddialliance.org/discovery#concept</seealso>
    let concept = Prefixed_Name(disco, "concept") |> PrefixedName
    /// <summary>
    ///   <para>disco:context</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>context specifies conditions which have to be fulfilled for specific mappings</para>
    /// labels<para>context specifies conditions which have to be fulfilled for specific mappings</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#context">http://rdf-vocabulary.ddialliance.org/discovery#context</seealso>
    let context = Prefixed_Name(disco, "context") |> PrefixedName
    /// <summary>
    ///   <para>disco:dataFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>points to the DataFile of a Study or a LogicalDataSet.</para>
    /// labels<para>a pour fichier de données</para><para>data file</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#dataFile">http://rdf-vocabulary.ddialliance.org/discovery#dataFile</seealso>
    let dataFile = Prefixed_Name(disco, "dataFile") |> PrefixedName
    /// <summary>
    ///   <para>disco:ddifile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>points from a Study or a StudyGroup to the original DDI file which is a foaf:Document.</para>
    /// labels<para>DDI-Datei</para><para>DDI file</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#ddifile">http://rdf-vocabulary.ddialliance.org/discovery#ddifile</seealso>
    let ddifile = Prefixed_Name(disco, "ddifile") |> PrefixedName
    /// <summary>
    ///   <para>disco:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>frequency</para>
    /// labels<para>frequency</para><para>fréquence</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#frequency">http://rdf-vocabulary.ddialliance.org/discovery#frequency</seealso>
    let frequency = Prefixed_Name(disco, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>disco:inputVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the original Variable of an aggregated qb:DataSet.</para>
    /// labels<para>variable en entrée</para><para>input variable</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#inputVariable">http://rdf-vocabulary.ddialliance.org/discovery#inputVariable</seealso>
    let inputVariable = Prefixed_Name(disco, "inputVariable") |> PrefixedName
    /// <summary>
    ///   <para>disco:isPublic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The value true indicates that the dataset can be accessed (usually downloaded) by anyone.</para>
    /// labels<para>ist öffentlich</para><para>is public</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#isPublic">http://rdf-vocabulary.ddialliance.org/discovery#isPublic</seealso>
    let isPublic = Prefixed_Name(disco, "isPublic") |> PrefixedName
    /// <summary>
    ///   <para>disco:isValid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if the code (represented by skos:Concept) is valid or missing.</para>
    /// labels<para>is valid</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#isValid">http://rdf-vocabulary.ddialliance.org/discovery#isValid</seealso>
    let isValid = Prefixed_Name(disco, "isValid") |> PrefixedName
    /// <summary>
    ///   <para>disco:mappingDDI-C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Mapping from and to DDI-C</para>
    /// labels<para>Mapping from and to DDI-C</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#mappingDDI-C">http://rdf-vocabulary.ddialliance.org/discovery#mappingDDI-C</seealso>
    let mappingDDI_C = Prefixed_Name(disco, "mappingDDI-C") |> PrefixedName
    /// <summary>
    ///   <para>disco:mappingDDI-L</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Mapping from and to DDI-L</para>
    /// labels<para>Mapping from and to DDI-L</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#mappingDDI-L">http://rdf-vocabulary.ddialliance.org/discovery#mappingDDI-L</seealso>
    let mappingDDI_L = Prefixed_Name(disco, "mappingDDI-L") |> PrefixedName
    /// <summary>
    ///   <para>disco:product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the LogicalDataSets of a Studies.</para>
    /// labels<para>Produkt</para><para>product</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#product">http://rdf-vocabulary.ddialliance.org/discovery#product</seealso>
    let product = Prefixed_Name(disco, "product") |> PrefixedName
    /// <summary>
    ///   <para>disco:purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The purpose of a Study of a StudyGroup.</para>
    /// labels<para>purpose</para><para>Grund</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#purpose">http://rdf-vocabulary.ddialliance.org/discovery#purpose</seealso>
    let purpose = Prefixed_Name(disco, "purpose") |> PrefixedName
    /// <summary>
    ///   <para>disco:question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the Questions associated to Variables or contained in Questionnaires.</para>
    /// labels<para>a comme question</para><para>question</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#question">http://rdf-vocabulary.ddialliance.org/discovery#question</seealso>
    let question = Prefixed_Name(disco, "question") |> PrefixedName
    /// <summary>
    ///   <para>disco:percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>percentage</para>
    /// labels<para>pourcentage</para><para>percentage</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#percentage">http://rdf-vocabulary.ddialliance.org/discovery#percentage</seealso>
    let percentage = Prefixed_Name(disco, "percentage") |> PrefixedName
    /// <summary>
    ///   <para>disco:representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>RepresentedVariables and Variables can have a Representation whose individuals are either of the class rdfs:Datatype (to represent values) or skos:ConceptScheme (to represent code lists).</para>
    /// labels<para>a pour représentation</para><para>representation</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#representation">http://rdf-vocabulary.ddialliance.org/discovery#representation</seealso>
    let representation = Prefixed_Name(disco, "representation") |> PrefixedName
    /// <summary>
    ///   <para>disco:Representation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#Representation">http://rdf-vocabulary.ddialliance.org/discovery#Representation</seealso>
    let Representation = Prefixed_Name(disco, "Representation") |> PrefixedName
    /// <summary>
    ///   <para>disco:responseDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The response domain of questions.</para>
    /// labels<para>responseDomain</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#responseDomain">http://rdf-vocabulary.ddialliance.org/discovery#responseDomain</seealso>
    let responseDomain = Prefixed_Name(disco, "responseDomain") |> PrefixedName
    /// <summary>
    ///   <para>disco:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>start date</para>
    /// labels<para>start date</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#startDate">http://rdf-vocabulary.ddialliance.org/discovery#startDate</seealso>
    let startDate = Prefixed_Name(disco, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>disco:statisticsCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the skos:Concept (representing codes and categories) of a specific CategoryStatistics individual.</para>
    /// labels<para>a pour concept statistique</para><para>statistics category</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsCategory">http://rdf-vocabulary.ddialliance.org/discovery#statisticsCategory</seealso>
    let statisticsCategory = Prefixed_Name(disco, "statisticsCategory") |> PrefixedName
    /// <summary>
    ///   <para>disco:subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The sub-title of a Study of a StudyGroup.</para>
    /// labels<para>Untertitel</para><para>subtitle</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#subtitle">http://rdf-vocabulary.ddialliance.org/discovery#subtitle</seealso>
    let subtitle = Prefixed_Name(disco, "subtitle") |> PrefixedName

    /// <summary>
    ///   <para>disco:summaryStatisticsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>summary statistics type</para>
    /// labels<para>summary statistics type</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#summaryStatisticsType">http://rdf-vocabulary.ddialliance.org/discovery#summaryStatisticsType</seealso>
    let summaryStatisticsType =
        Prefixed_Name(disco, "summaryStatisticsType") |> PrefixedName

    /// <summary>
    ///   <para>disco:weightedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>SummaryStatistics or CategoryStatistics resources may be weighted by a specific Variable.</para>
    /// labels<para>weighted by</para><para></para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#weightedBy">http://rdf-vocabulary.ddialliance.org/discovery#weightedBy</seealso>
    let weightedBy = Prefixed_Name(disco, "weightedBy") |> PrefixedName

    /// <summary>
    ///   <para>disco:DescriptiveStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>SummaryStatistics pointing to variables and CategoryStatistics pointing to categories and codes are both DescriptiveStatistics.</para>
    /// labels<para>Statistique descriptive</para><para>Descriptive statistics</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#DescriptiveStatistics">http://rdf-vocabulary.ddialliance.org/discovery#DescriptiveStatistics</seealso>
    let DescriptiveStatistics =
        Prefixed_Name(disco, "DescriptiveStatistics") |> PrefixedName

    /// <summary>
    ///   <para>disco:Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The data for the study are collected by an Instrument. The purpose of an Instrument, i.e. an interview, a questionnaire or another entity used as a means of data collection, is in the case of a survey to record the flow of a questionnaire, its use of questions, and additional component parts. A questionnaire contains a flow of questions.</para>
    /// labels<para>Instrument de collecte</para><para>Instrument</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#Instrument">http://rdf-vocabulary.ddialliance.org/discovery#Instrument</seealso>
    let Instrument = Prefixed_Name(disco, "Instrument") |> PrefixedName
    /// <summary>
    ///   <para>disco:Questionnaire</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A questionnaire contains a flow of questions. </para>
    /// labels<para>Questionnaire</para><para>Fragebogen</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#Questionnaire">http://rdf-vocabulary.ddialliance.org/discovery#Questionnaire</seealso>
    let Questionnaire = Prefixed_Name(disco, "Questionnaire") |> PrefixedName

    /// <summary>
    ///   <para>disco:RepresentedVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>RepresentedVariables encompasse study-independent, re-usable parts of variables like occupation classification.</para>
    /// labels<para>Élément de donnée</para><para>Data element</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#RepresentedVariable">http://rdf-vocabulary.ddialliance.org/discovery#RepresentedVariable</seealso>
    let RepresentedVariable =
        Prefixed_Name(disco, "RepresentedVariable") |> PrefixedName

    /// <summary>
    ///   <para>disco:SummaryStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>For SummaryStatistics, maximum values, minimum values, and standard deviations can be defined.</para>
    /// labels<para>Summary statistics</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#SummaryStatistics">http://rdf-vocabulary.ddialliance.org/discovery#SummaryStatistics</seealso>
    let SummaryStatistics = Prefixed_Name(disco, "SummaryStatistics") |> PrefixedName
    /// <summary>
    ///   <para>disco:statisticsDataFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the DataFile of a specific DesciptiveStatistics individual.</para>
    /// labels<para>a pour fichier statistique</para><para>statistics data file</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsDataFile">http://rdf-vocabulary.ddialliance.org/discovery#statisticsDataFile</seealso>
    let statisticsDataFile = Prefixed_Name(disco, "statisticsDataFile") |> PrefixedName
    /// <summary>
    ///   <para>disco:statisticsVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the Variable of a specific SummaryStatistics individual.</para>
    /// labels<para>a pour variable statistique</para><para>statistics variable</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#statisticsVariable">http://rdf-vocabulary.ddialliance.org/discovery#statisticsVariable</seealso>
    let statisticsVariable = Prefixed_Name(disco, "statisticsVariable") |> PrefixedName
    /// <summary>
    ///   <para>disco:universe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the Universe(s) of Studies, StudyGrous, RepresentedVariables, Variables, Questions, and LogicalDataSets.</para>
    /// labels<para>a comme univers</para><para>universe</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#universe">http://rdf-vocabulary.ddialliance.org/discovery#universe</seealso>
    let universe = Prefixed_Name(disco, "universe") |> PrefixedName
    /// <summary>
    ///   <para>disco:variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the Variable of a Study.</para>
    /// labels<para>Variable</para><para>variable</para></remarks>
    /// <seealso href="http://rdf-vocabulary.ddialliance.org/discovery#variable">http://rdf-vocabulary.ddialliance.org/discovery#variable</seealso>
    let variable = Prefixed_Name(disco, "variable") |> PrefixedName
