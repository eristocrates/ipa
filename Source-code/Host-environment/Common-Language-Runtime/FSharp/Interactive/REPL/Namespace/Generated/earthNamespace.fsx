#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module earth =
    let _prefixId = PrefixId.fromNamespaceLabel "http://linked.earth/ontology#" "earth"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Archive</para>
    ///   <para>rdfs:comment : The medium in which the response of a sensor to environmental forcing is recorded (e.g., marine sediments, ice core, lake sediments, speleothems). Sensu Evans et al. (2013)</para>
    ///   <a href="http://linked.earth/ontology#Archive">earth:Archive</a>
    /// </summary>
    let Archive = _prefixId.prefix "Archive"
    /// <summary>
    ///   <para>rdfs:label : ArchiveModel</para>
    ///   <para>rdfs:comment : A simplified description of how the sensor either creates or emplaces the signal into the archive. sensu Evans et al. 2013.</para>
    ///   <a href="http://linked.earth/ontology#ArchiveModel">earth:ArchiveModel</a>
    /// </summary>
    let ArchiveModel = _prefixId.prefix "ArchiveModel"
    /// <summary>
    ///   <para>rdfs:label : CalibrationModel</para>
    ///   <para>rdfs:comment : Metadata about how the variable was calibrated to reflect an environmental variable</para>
    ///   <a href="http://linked.earth/ontology#CalibrationModel">earth:CalibrationModel</a>
    /// </summary>
    let CalibrationModel = _prefixId.prefix "CalibrationModel"
    /// <summary>
    ///   <para>rdfs:label : CrhonData</para>
    ///   <para>rdfs:comment : The Data pertaining to chronological information</para>
    ///   <a href="http://linked.earth/ontology#ChronData">earth:ChronData</a>
    /// </summary>
    let ChronData = _prefixId.prefix "ChronData"
    /// <summary>
    ///   <para>rdfs:label : ChronDataTable</para>
    ///   <para>rdfs:comment : DataTable containing the Chronology Variables</para>
    ///   <a href="http://linked.earth/ontology#ChronDataTable">earth:ChronDataTable</a>
    /// </summary>
    let ChronDataTable = _prefixId.prefix "ChronDataTable"
    /// <summary>
    ///   <para>rdfs:label : ChronModel</para>
    ///   <para>rdfs:comment : Model used to obtain the chronology</para>
    ///   <a href="http://linked.earth/ontology#ChronModel">earth:ChronModel</a>
    /// </summary>
    let ChronModel = _prefixId.prefix "ChronModel"
    /// <summary>
    ///   <para>rdfs:label : ChronProxy</para>
    ///   <para>rdfs:comment : The data and metadata associated with how the chronology information was obtained.</para>
    ///   <a href="http://linked.earth/ontology#ChronProxy">earth:ChronProxy</a>
    /// </summary>
    let ChronProxy = _prefixId.prefix "ChronProxy"
    /// <summary>
    ///   <para>rdfs:label : ClimateInterpretation</para>
    ///   <para>rdfs:comment : A suite of metadata that describe how a variable is interpreted to reflect past environmental variability^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#ClimateInterpretation">earth:ClimateInterpretation</a>
    /// </summary>
    let ClimateInterpretation = _prefixId.prefix "ClimateInterpretation"
    /// <summary>
    ///   <para>rdfs:label : ClimateProxy</para>
    ///   <para>rdfs:comment : Climate observations prior to the instrumental era are necessarily indirect. These observations are made on climate proxies in various geological (e.g. lake or marine sediments, living or fossil coral reefs, cave deposits), glaciological (ice cores or snow pits) or biological (trees) archives. Many types of measurements can be made on each archives, each sensing a different aspect of the environment (sometimes, several aspects at once). A paleoclimate dataset is a set of observations made on an archive.</para>
    ///   <a href="http://linked.earth/ontology#ClimateProxy">earth:ClimateProxy</a>
    /// </summary>
    let ClimateProxy = _prefixId.prefix "ClimateProxy"
    /// <summary>
    ///   <para>rdfs:label : Data</para>
    ///   <para>rdfs:comment : An aggregation of DataTables and supporting information regarging the paleoenvironmental and/or chronological interpretation </para>
    ///   <a href="http://linked.earth/ontology#Data">earth:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    /// <summary>
    ///   <para>rdfs:label : DataTable</para>
    ///   <para>rdfs:comment : A set of Variables organized in columns</para>
    ///   <a href="http://linked.earth/ontology#DataTable">earth:DataTable</a>
    /// </summary>
    let DataTable = _prefixId.prefix "DataTable"
    /// <summary>
    ///   <para>rdfs:label : Dataset</para>
    ///   <para>rdfs:comment : A structured collection of related information, including - but not limited to - geographical, chronological, and measured or modeled paleoenvironmental data</para>
    ///   <a href="http://linked.earth/ontology#Dataset">earth:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:label : DistributionTable</para>
    ///   <para>rdfs:comment : Table that contains the probability on the inferred variables</para>
    ///   <a href="http://linked.earth/ontology#DistributionTable">earth:DistributionTable</a>
    /// </summary>
    let DistributionTable = _prefixId.prefix "DistributionTable"
    /// <summary>
    ///   <para>rdfs:label : EnsembleTable</para>
    ///   <para>rdfs:comment : Table containing possible series of age models or proxy variability</para>
    ///   <a href="http://linked.earth/ontology#EnsembleTable">earth:EnsembleTable</a>
    /// </summary>
    let EnsembleTable = _prefixId.prefix "EnsembleTable"
    /// <summary>
    ///   <para>rdfs:label : Funding</para>
    ///   <para>rdfs:comment : A source of funding for the creation of the Dataset</para>
    ///   <a href="http://linked.earth/ontology#Funding">earth:Funding</a>
    /// </summary>
    let Funding = _prefixId.prefix "Funding"
    /// <summary>
    ///   <para>rdfs:label : InferredVariable</para>
    ///   <para>rdfs:comment : Is the variable inferred from a measured variable?</para>
    ///   <a href="http://linked.earth/ontology#InferredVariable">earth:InferredVariable</a>
    /// </summary>
    let InferredVariable = _prefixId.prefix "InferredVariable"
    /// <summary>
    ///   <para>rdfs:label : InorganicSensor</para>
    ///   <para>rdfs:comment : An inorganic senso like.karst system, catchment basin, etc.</para>
    ///   <a href="http://linked.earth/ontology#InorganicSensor">earth:InorganicSensor</a>
    /// </summary>
    let InorganicSensor = _prefixId.prefix "InorganicSensor"
    /// <summary>
    ///   <para>rdfs:label : Instrument</para>
    ///   <para>rdfs:comment : A tool or implement used to produce MeasuredVariables</para>
    ///   <a href="http://linked.earth/ontology#Instrument">earth:Instrument</a>
    /// </summary>
    let Instrument = _prefixId.prefix "Instrument"
    /// <summary>
    ///   <para>rdfs:label : IntegrationTime</para>
    ///   <para>rdfs:comment : The integration time of the Archive or the Sensor^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#IntegrationTime">earth:IntegrationTime</a>
    /// </summary>
    let IntegrationTime = _prefixId.prefix "IntegrationTime"
    /// <summary>
    ///   <para>rdfs:label : Interpretation</para>
    ///   <para>rdfs:comment : A suite of metadata that describe how a variable is interpreted to reflect past variability, including environmental variability</para>
    ///   <a href="http://linked.earth/ontology#Interpretation">earth:Interpretation</a>
    /// </summary>
    let Interpretation = _prefixId.prefix "Interpretation"
    /// <summary>
    ///   <para>rdfs:label : IsotopeInterpretation</para>
    ///   <para>rdfs:comment : A suite of metadata that describe how a MeasuredVariable with instance Isotope is interpreted to reflect past variability, including environmental variability^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#IsotopeInterpretation">earth:IsotopeInterpretation</a>
    /// </summary>
    let IsotopeInterpretation = _prefixId.prefix "IsotopeInterpretation"
    /// <summary>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : The geographic data and metadata for the dataset</para>
    ///   <a href="http://linked.earth/ontology#Location">earth:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : MeasuredVariable</para>
    ///   <para>rdfs:comment : Is the variable measured with an instrument?</para>
    ///   <a href="http://linked.earth/ontology#MeasuredVariable">earth:MeasuredVariable</a>
    /// </summary>
    let MeasuredVariable = _prefixId.prefix "MeasuredVariable"
    /// <summary>
    ///   <para>rdfs:label : MeasurementTable</para>
    ///   <para>rdfs:comment : Table that contains the measuredVariables made on the Archive</para>
    ///   <a href="http://linked.earth/ontology#MeasurementTable">earth:MeasurementTable</a>
    /// </summary>
    let MeasurementTable = _prefixId.prefix "MeasurementTable"
    /// <summary>
    ///   <para>rdfs:label : Model</para>
    ///   <para>rdfs:comment : Any system that is at least partially isomorphic to some target system and used to derive information about the structure and/or dynamics of the target system.</para>
    ///   <a href="http://linked.earth/ontology#Model">earth:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:label : NonPeerReviewedPublication</para>
    ///   <para>rdfs:comment : A publication that has not undergone a formal review process; for instance, a Dataset attached to a dissertation.</para>
    ///   <a href="http://linked.earth/ontology#NonPeerReviewedPublication">earth:NonPeerReviewedPublication</a>
    /// </summary>
    let NonPeerReviewedPublication = _prefixId.prefix "NonPeerReviewedPublication"
    /// <summary>
    ///   <para>rdfs:label : Observation</para>
    ///   <para>rdfs:comment : The measurements made on the archives, whether chemical (e.g., Mg/Ca, d18O, TEX86, Sr/Ca....), physical (e.g. density, layer thickness) or biological (e.g. species abundance). Evans et al. (2013). Observations are MeasuredVariables</para>
    ///   <a href="http://linked.earth/ontology#Observation">earth:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>rdfs:label : ObservationModel</para>
    ///   <para>rdfs:comment : The simplified representation of the way in which observations are made on the archive. sensu Evans et al. 2013.</para>
    ///   <a href="http://linked.earth/ontology#ObservationModel">earth:ObservationModel</a>
    /// </summary>
    let ObservationModel = _prefixId.prefix "ObservationModel"
    /// <summary>
    ///   <para>rdfs:label : OrganicSensor</para>
    ///   <para>rdfs:comment : An organic sensor (e.g., foraminifera, tree, corals...)</para>
    ///   <a href="http://linked.earth/ontology#OrganicSensor">earth:OrganicSensor</a>
    /// </summary>
    let OrganicSensor = _prefixId.prefix "OrganicSensor"
    /// <summary>
    ///   <para>rdfs:label : PaleoData</para>
    ///   <para>rdfs:comment : The Data pertaining to past environmental variability</para>
    ///   <a href="http://linked.earth/ontology#PaleoData">earth:PaleoData</a>
    /// </summary>
    let PaleoData = _prefixId.prefix "PaleoData"
    /// <summary>
    ///   <para>rdfs:label : PaleoDataTable</para>
    ///   <para>rdfs:comment : DataTable containig PaleoData Variables</para>
    ///   <a href="http://linked.earth/ontology#PaleoDataTable">earth:PaleoDataTable</a>
    /// </summary>
    let PaleoDataTable = _prefixId.prefix "PaleoDataTable"
    /// <summary>
    ///   <para>rdfs:label : PaleoModel</para>
    ///   <para>rdfs:comment : Model describing how the measuredVariables are transformed into inferredVariables</para>
    ///   <a href="http://linked.earth/ontology#PaleoModel">earth:PaleoModel</a>
    /// </summary>
    let PaleoModel = _prefixId.prefix "PaleoModel"
    /// <summary>
    ///   <para>rdfs:label : PeerReviewedPublication</para>
    ///   <para>rdfs:comment : A publication that has undergone a formal peer-reviewed process.</para>
    ///   <a href="http://linked.earth/ontology#PeerReviewedPublication">earth:PeerReviewedPublication</a>
    /// </summary>
    let PeerReviewedPublication = _prefixId.prefix "PeerReviewedPublication"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : A person that has participated directly or indirectly in the authoring or contribution of any resources in  Linked Earth.</para>
    ///   <a href="http://linked.earth/ontology#Person">earth:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Proxy</para>
    ///   <para>rdfs:comment : a measured variable used to infer the value of a variable of interest</para>
    ///   <a href="http://linked.earth/ontology#Proxy">earth:Proxy</a>
    /// </summary>
    let Proxy = _prefixId.prefix "Proxy"
    /// <summary>
    ///   <para>rdfs:label : ProxySystemModel</para>
    ///   <para>rdfs:comment : In the Evans et al. (2013) framework, this is the combination of sensor, archive and observation models . "A generalized proxy system model encapuslates a simplified representation of prior physical, chemical, biological, and/or geological understanding of the ways in which environmental variation ultimately results in the observations used to retrieve paleoclimatic information."</para>
    ///   <a href="http://linked.earth/ontology#ProxySystemModel">earth:ProxySystemModel</a>
    /// </summary>
    let ProxySystemModel = _prefixId.prefix "ProxySystemModel"
    /// <summary>
    ///   <para>rdfs:label : Publication</para>
    ///   <para>rdfs:comment : A document that serves as reference for a Dataset or its components</para>
    ///   <a href="http://linked.earth/ontology#Publication">earth:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Resolution</para>
    ///   <para>rdfs:comment : Refers to the distance (physical or temporal) between each point on the archive. May or May not be related to sampling. Value with units</para>
    ///   <a href="http://linked.earth/ontology#Resolution">earth:Resolution</a>
    /// </summary>
    let Resolution = _prefixId.prefix "Resolution"
    /// <summary>
    ///   <para>rdfs:label : Sensor</para>
    ///   <para>rdfs:comment : The sensor comprises physical, chemical and/or biological components that react to environmental conditions (e.g, foraminifera, coral polyps, cave, catchment basin). sensu Evans et al. (2013)</para>
    ///   <a href="http://linked.earth/ontology#Sensor">earth:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : SensorModel</para>
    ///   <para>rdfs:comment : A formalization of the behavior of the sensor in response to environmental forcing. Sensu Evans et al. 2013.</para>
    ///   <a href="http://linked.earth/ontology#SensorModel">earth:SensorModel</a>
    /// </summary>
    let SensorModel = _prefixId.prefix "SensorModel"
    /// <summary>
    ///   <para>rdfs:label : SoftwareCode</para>
    ///   <para>rdfs:comment : A script that describes the model, in any programming language (e.g., Excel, Matlab, Python, R)</para>
    ///   <a href="http://linked.earth/ontology#SoftwareCode">earth:SoftwareCode</a>
    /// </summary>
    let SoftwareCode = _prefixId.prefix "SoftwareCode"
    /// <summary>
    ///   <para>rdfs:label : SummaryTablerdfs:label : Table containing relevant statistics from the ensemble table</para>
    ///   <a href="http://linked.earth/ontology#SummaryTable">earth:SummaryTable</a>
    /// </summary>
    let SummaryTable = _prefixId.prefix "SummaryTable"
    /// <summary>
    ///   <para>rdfs:label : Uncertainty</para>
    ///   <para>rdfs:comment : A state of incomplete knowledge that can result from a lack of information or from disagreement about what is known or  even knowable. Uncertainty may come from many sources, from imprecision in the data to ambigously defined concepts or terminology, or uncertain projections of human bahavior. Uncertainty can be represented by quantitative measures (e.g., probability density function) or by qualitative statement (e.g., reflecting the judgement of a team of experts. Sensu IPCC AR5</para>
    ///   <a href="http://linked.earth/ontology#Uncertainty">earth:Uncertainty</a>
    /// </summary>
    let Uncertainty = _prefixId.prefix "Uncertainty"
    /// <summary>
    ///   <para>rdfs:label : UndertaintyModel</para>
    ///   <para>rdfs:comment : A formalization of the way the uncertainty is accounted for</para>
    ///   <a href="http://linked.earth/ontology#UncertaintyModel">earth:UncertaintyModel</a>
    /// </summary>
    let UncertaintyModel = _prefixId.prefix "UncertaintyModel"
    /// <summary>
    ///   <para>rdfs:label : Variable</para>
    ///   <para>rdfs:comment : Quantities which can be measured or inferred independently in an experiment</para>
    ///   <a href="http://linked.earth/ontology#Variable">earth:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    /// <summary>
    ///   <para>rdfs:label : archivedIn</para>
    ///   <para>rdfs:comment : How was the climate or chronological information encoded into the Archive?</para>
    ///   <a href="http://linked.earth/ontology#archivedIn">earth:archivedIn</a>
    /// </summary>
    let archivedIn = _prefixId.prefix "archivedIn"
    /// <summary>
    ///   <para>rdfs:label : author</para>
    ///   <para>rdfs:comment : Author of the resource</para>
    ///   <a href="http://linked.earth/ontology#author">earth:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>rdfs:label : basedOn</para>
    ///   <para>rdfs:comment : How are the data obtained?</para>
    ///   <a href="http://linked.earth/ontology#basedOn">earth:basedOn</a>
    /// </summary>
    let basedOn = _prefixId.prefix "basedOn"
    /// <summary>
    ///   <para>rdfs:label : book</para>
    ///   <para>rdfs:comment : Book in which the publication was published</para>
    ///   <a href="http://linked.earth/ontology#book">earth:book</a>
    /// </summary>
    let book = _prefixId.prefix "book"
    /// <summary>
    ///   <para>rdfs:label : calibratedFrom</para>
    ///   <para>rdfs:comment : Property that indicates how the measured variable was calibrated</para>
    ///   <a href="http://linked.earth/ontology#calibratedFrom">earth:calibratedFrom</a>
    /// </summary>
    let calibratedFrom = _prefixId.prefix "calibratedFrom"
    /// <summary>
    ///   <para>rdfs:label : calibratedWith</para>
    ///   <para>rdfs:comment : How was the variable calibrated to represent climate or chronology?</para>
    ///   <a href="http://linked.earth/ontology#calibratedWith">earth:calibratedWith</a>
    /// </summary>
    let calibratedWith = _prefixId.prefix "calibratedWith"
    /// <summary>
    ///   <para>rdfs:label : calibrationReferences</para>
    ///   <para>rdfs:comment : The publication that describes the calibration. The string should follow the model set in the publication class</para>
    ///   <a href="http://linked.earth/ontology#calibrationReferences">earth:calibrationReferences</a>
    /// </summary>
    let calibrationReferences = _prefixId.prefix "calibrationReferences"
    /// <summary>
    ///   <para>rdfs:label : chronModeledBy</para>
    ///   <para>rdfs:comment : How was the chron data modeled?</para>
    ///   <a href="http://linked.earth/ontology#chronModeledBy">earth:chronModeledBy</a>
    /// </summary>
    let chronModeledBy = _prefixId.prefix "chronModeledBy"
    /// <summary>
    ///   <para>rdfs:label : citation</para>
    ///   <para>rdfs:comment : Sentence indicating how a paper should be published</para>
    ///   <a href="http://linked.earth/ontology#citation">earth:citation</a>
    /// </summary>
    let citation = _prefixId.prefix "citation"
    /// <summary>
    ///   <para>rdfs:label : collectedFrom</para>
    ///   <para>rdfs:comment : Where was the data in the dataset collected from? Generally, this is the site where the archive was collected. </para>
    ///   <a href="http://linked.earth/ontology#collectedFrom">earth:collectedFrom</a>
    /// </summary>
    let collectedFrom = _prefixId.prefix "collectedFrom"
    /// <summary>
    ///   <para>rdfs:label : contributor</para>
    ///   <para>rdfs:comment : Contributor of the resource (dataset, publication, etc.)</para>
    ///   <a href="http://linked.earth/ontology#contributor">earth:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>rdfs:label : datasetDate</para>
    ///   <para>rdfs:comment : Date when the dataset was published. </para>
    ///   <a href="http://linked.earth/ontology#datasetDate">earth:datasetDate</a>
    /// </summary>
    let datasetDate = _prefixId.prefix "datasetDate"
    /// <summary>
    ///   <para>rdfs:label : datasetVersion</para>
    ///   <para>rdfs:comment : The version of the dataset. It should follow the x.y.z notation where x refers to changes in metadata and data following a publication (for instance, the creation of a new age model using a different code), y refers to changes to the data following a publication (for instance, adding data further back in time without changing the model underlying the interpretation), and z refers to changes not associated with a publication (for instance, typos).</para>
    ///   <a href="http://linked.earth/ontology#datasetVersion">earth:datasetVersion</a>
    /// </summary>
    let datasetVersion = _prefixId.prefix "datasetVersion"
    /// <summary>
    ///   <para>rdfs:label : description</para>
    ///   <para>rdfs:comment : The description of a resource. This property may be used to provide further details on instrument descriptions, uncertainty description,etc.</para>
    ///   <a href="http://linked.earth/ontology#description">earth:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : detail</para>
    ///   <para>rdfs:comment : Answers the "of what" question for a Variable.</para>
    ///   <a href="http://linked.earth/ontology#detail">earth:detail</a>
    /// </summary>
    let detail = _prefixId.prefix "detail"
    /// <summary>
    ///   <para>rdfs:label : email</para>
    ///   <para>rdfs:comment : email of an author or contributor</para>
    ///   <a href="http://linked.earth/ontology#email">earth:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:label : equation</para>
    ///   <para>rdfs:comment : The mathematical statement used to describe the model.</para>
    ///   <a href="http://linked.earth/ontology#equation">earth:equation</a>
    /// </summary>
    let equation = _prefixId.prefix "equation"
    /// <summary>
    ///   <para>rdfs:label : foundInDistributionTable</para>
    ///   <para>rdfs:comment : Property that indicates that a variable or data is found in a distribution table</para>
    ///   <a href="http://linked.earth/ontology#foundInDistributionTable">earth:foundInDistributionTable</a>
    /// </summary>
    let foundInDistributionTable = _prefixId.prefix "foundInDistributionTable"
    /// <summary>
    ///   <para>rdfs:label : foundInEnsembleTable</para>
    ///   <para>rdfs:comment : Property that indicates that the data or variable described was found in an ensemble table</para>
    ///   <a href="http://linked.earth/ontology#foundInEnsembleTable">earth:foundInEnsembleTable</a>
    /// </summary>
    let foundInEnsembleTable = _prefixId.prefix "foundInEnsembleTable"
    /// <summary>
    ///   <para>rdfs:label : foundInMeasurementTable</para>
    ///   <para>rdfs:comment : Property that indicates that a variable was found in a measurement table</para>
    ///   <a href="http://linked.earth/ontology#foundInMeasurementTable">earth:foundInMeasurementTable</a>
    /// </summary>
    let foundInMeasurementTable = _prefixId.prefix "foundInMeasurementTable"
    /// <summary>
    ///   <para>rdfs:label : foundInSummaryTable</para>
    ///   <para>rdfs:comment : Property that indicates that the describer data or variable was found in a summary table</para>
    ///   <a href="http://linked.earth/ontology#foundInSummaryTable">earth:foundInSummaryTable</a>
    /// </summary>
    let foundInSummaryTable = _prefixId.prefix "foundInSummaryTable"
    /// <summary>
    ///   <para>rdfs:label : foundInTable</para>
    ///   <para>rdfs:comment : Property that indicated the table where the described data can be found</para>
    ///   <a href="http://linked.earth/ontology#foundInTable">earth:foundInTable</a>
    /// </summary>
    let foundInTable = _prefixId.prefix "foundInTable"
    /// <summary>
    ///   <para>rdfs:label : fundedBy</para>
    ///   <para>rdfs:comment : Property that indicated the funding which made the dataset possible</para>
    ///   <a href="http://linked.earth/ontology#fundedBy">earth:fundedBy</a>
    /// </summary>
    let fundedBy = _prefixId.prefix "fundedBy"
    /// <summary>
    ///   <para>rdfs:label : fundingAgency</para>
    ///   <para>rdfs:comment : The agency that funded the development of the Dataset</para>
    ///   <a href="http://linked.earth/ontology#fundingAgency">earth:fundingAgency</a>
    /// </summary>
    let fundingAgency = _prefixId.prefix "fundingAgency"
    /// <summary>
    ///   <para>rdfs:label : fundingCountry</para>
    ///   <para>rdfs:comment : Country which awarded the funding for the dataset</para>
    ///   <a href="http://linked.earth/ontology#fundingCountry">earth:fundingCountry</a>
    /// </summary>
    let fundingCountry = _prefixId.prefix "fundingCountry"
    /// <summary>
    ///   <para>rdfs:label : grantNumber</para>
    ///   <para>rdfs:comment : The grant number associated with the development of the Dataset?</para>
    ///   <a href="http://linked.earth/ontology#grantNumber">earth:grantNumber</a>
    /// </summary>
    let grantNumber = _prefixId.prefix "grantNumber"
    /// <summary>
    ///   <para>rdfs:label : hasCode</para>
    ///   <para>rdfs:comment : What is the mathematical formulation that describes the Model?</para>
    ///   <a href="http://linked.earth/ontology#hasCode">earth:hasCode</a>
    /// </summary>
    let hasCode = _prefixId.prefix "hasCode"
    /// <summary>
    ///   <para>rdfs:label : hasDOI</para>
    ///   <para>rdfs:comment : As Digital Object Identifier for a given resource. For example: "oi:10.1191/095968301673881493"</para>
    ///   <a href="http://linked.earth/ontology#hasDOI">earth:hasDOI</a>
    /// </summary>
    let hasDOI = _prefixId.prefix "hasDOI"
    /// <summary>
    ///   <para>rdfs:label : hasExecutionCommand</para>
    ///   <para>rdfs:comment : The execution command needed to run the script or software</para>
    ///   <a href="http://linked.earth/ontology#hasExecutionCommand">earth:hasExecutionCommand</a>
    /// </summary>
    let hasExecutionCommand = _prefixId.prefix "hasExecutionCommand"
    /// <summary>
    ///   <para>rdfs:label : hasExecutionEnvironment</para>
    ///   <para>rdfs:comment : Execution environment of the code</para>
    ///   <a href="http://linked.earth/ontology#hasExecutionEnvironment">earth:hasExecutionEnvironment</a>
    /// </summary>
    let hasExecutionEnvironment = _prefixId.prefix "hasExecutionEnvironment"
    /// <summary>
    ///   <para>rdfs:label : hasFileName</para>
    ///   <para>rdfs:comment : Name of the CSV file containing the data table</para>
    ///   <a href="http://linked.earth/ontology#hasFileName">earth:hasFileName</a>
    /// </summary>
    let hasFileName = _prefixId.prefix "hasFileName"
    /// <summary>
    ///   <para>rdfs:label : hasID</para>
    ///   <para>rdfs:comment : ID for a variable in a table</para>
    ///   <a href="http://linked.earth/ontology#hasID">earth:hasID</a>
    /// </summary>
    let hasID = _prefixId.prefix "hasID"
    /// <summary>
    ///   <para>rdfs:label : hasISBN</para>
    ///   <para>rdfs:comment : Identifier used commonly to refer to publications.</para>
    ///   <a href="http://linked.earth/ontology#hasISBN">earth:hasISBN</a>
    /// </summary>
    let hasISBN = _prefixId.prefix "hasISBN"
    /// <summary>
    ///   <para>rdfs:label : hasISSN</para>
    ///   <para>rdfs:comment : 8-digit code used to udentify publications</para>
    ///   <a href="http://linked.earth/ontology#hasISSN">earth:hasISSN</a>
    /// </summary>
    let hasISSN = _prefixId.prefix "hasISSN"
    /// <summary>
    ///   <para>rdfs:label : hasLink</para>
    ///   <para>rdfs:comment : A downloadable link of a resource</para>
    ///   <a href="http://linked.earth/ontology#hasLink">earth:hasLink</a>
    /// </summary>
    let hasLink = _prefixId.prefix "hasLink"
    /// <summary>
    ///   <para>rdfs:label : hasMissingValue</para>
    ///   <para>rdfs:comment : Indicates how the missing values are flagged in a dataset</para>
    ///   <a href="http://linked.earth/ontology#hasMissingValue">earth:hasMissingValue</a>
    /// </summary>
    let hasMissingValue = _prefixId.prefix "hasMissingValue"
    /// <summary>
    ///   <para>rdfs:label : hasPart</para>
    ///   <para>rdfs:comment : What are the components of the ProxySystemModel?^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#hasPart">earth:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : hasRank</para>
    ///   <para>rdfs:comment : Describes the importance of the ClimateInterpretation. For instance, d18Ocalcite is influenced by both temperature and d18Osw. If temperature is the dominant influence, then its rank is 1.^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#hasRank">earth:hasRank</a>
    /// </summary>
    let hasRank = _prefixId.prefix "hasRank"
    /// <summary>
    ///   <para>rdfs:label : hasResolution</para>
    ///   <para>rdfs:comment : What is the Resolution of the Archive?^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#hasResolution">earth:hasResolution</a>
    /// </summary>
    let hasResolution = _prefixId.prefix "hasResolution"
    /// <summary>
    ///   <para>rdfs:label : hasUncertainty</para>
    ///   <para>rdfs:comment : What is the Uncertainty associated with the Observations, Model, and Calibration?</para>
    ///   <a href="http://linked.earth/ontology#hasUncertainty">earth:hasUncertainty</a>
    /// </summary>
    let hasUncertainty = _prefixId.prefix "hasUncertainty"
    /// <summary>
    ///   <para>rdfs:label : hasUnits</para>
    ///   <para>rdfs:comment : units in which a resource is measured The resource can be a Variable, an Observation, a Resolution, or an Uncertainty</para>
    ///   <a href="http://linked.earth/ontology#hasUnits">earth:hasUnits</a>
    /// </summary>
    let hasUnits = _prefixId.prefix "hasUnits"
    /// <summary>
    ///   <para>rdfs:label : hasValue</para>
    ///   <para>rdfs:comment : A column of values for the variable. The literal can be in the form of a vector of values (for instance d18O PaleoObservations),  a vector of strings (for instance different paleoArchiveNames),  a matrix or both</para>
    ///   <a href="http://linked.earth/ontology#hasValue">earth:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : includesChronData</para>
    ///   <para>rdfs:comment : Pointer to the chron data included in the dataset</para>
    ///   <a href="http://linked.earth/ontology#includesChronData">earth:includesChronData</a>
    /// </summary>
    let includesChronData = _prefixId.prefix "includesChronData"
    /// <summary>
    ///   <para>rdfs:label : includesData</para>
    ///   <para>rdfs:comment : What are the paleoenvironmental and chronological Data included in the Dataset?</para>
    ///   <a href="http://linked.earth/ontology#includesData">earth:includesData</a>
    /// </summary>
    let includesData = _prefixId.prefix "includesData"
    /// <summary>
    ///   <para>rdfs:label : includesPaleoData</para>
    ///   <para>rdfs:comment : The paleo data included as part of a dataset</para>
    ///   <a href="http://linked.earth/ontology#includesPaleoData">earth:includesPaleoData</a>
    /// </summary>
    let includesPaleoData = _prefixId.prefix "includesPaleoData"
    /// <summary>
    ///   <para>rdfs:label : includesVariable</para>
    ///   <para>rdfs:comment : What are the Variables included in the DataTable?</para>
    ///   <a href="http://linked.earth/ontology#includesVariable">earth:includesVariable</a>
    /// </summary>
    let includesVariable = _prefixId.prefix "includesVariable"
    /// <summary>
    ///   <para>rdfs:label : inferredFrom</para>
    ///   <para>rdfs:comment : From which measured variable is the current inferred variable obtained?</para>
    ///   <a href="http://linked.earth/ontology#inferredFrom">earth:inferredFrom</a>
    /// </summary>
    let inferredFrom = _prefixId.prefix "inferredFrom"
    /// <summary>
    ///   <para>rdfs:label : interpretationDirection</para>
    ///   <para>rdfs:comment : Describes whether the interpreted environmental variable increases (positive) or decreases (negative) as the paleoDataVariableValue increases. The literal is a string , either "positive" or "negative"</para>
    ///   <a href="http://linked.earth/ontology#interpretationDirection">earth:interpretationDirection</a>
    /// </summary>
    let interpretationDirection = _prefixId.prefix "interpretationDirection"
    /// <summary>
    ///   <para>rdfs:label : interpretationReferences</para>
    ///   <para>rdfs:comment : Describes the basis by which the proxy variable is interpreted in terms of climate. </para>
    ///   <a href="http://linked.earth/ontology#interpretationReferences">earth:interpretationReferences</a>
    /// </summary>
    let interpretationReferences = _prefixId.prefix "interpretationReferences"
    /// <summary>
    ///   <para>rdfs:label : interpretedAs</para>
    ///   <para>rdfs:comment : how is the variable interpreted?</para>
    ///   <a href="http://linked.earth/ontology#interpretedAs">earth:interpretedAs</a>
    /// </summary>
    let interpretedAs = _prefixId.prefix "interpretedAs"
    /// <summary>
    ///   <para>rdfs:label : isLocal</para>
    ///   <para>rdfs:comment : Whether the influence on the MeasuredVariable (and therefore the Interpretation) is local or far-field. The literal is a string.^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#isLocal">earth:isLocal</a>
    /// </summary>
    let isLocal = _prefixId.prefix "isLocal"
    /// <summary>
    ///   <para>rdfs:label : issue</para>
    ///   <para>rdfs:comment : The issue number for the publication</para>
    ///   <a href="http://linked.earth/ontology#issue">earth:issue</a>
    /// </summary>
    let issue = _prefixId.prefix "issue"
    /// <summary>
    ///   <para>rdfs:label : journal</para>
    ///   <para>rdfs:comment : Property that indicated the journal in which the publication has been published</para>
    ///   <a href="http://linked.earth/ontology#journal">earth:journal</a>
    /// </summary>
    let journal = _prefixId.prefix "journal"
    /// <summary>
    ///   <para>rdfs:label : measuredBy</para>
    ///   <para>rdfs:comment : What Instrument was used to obtain the MeasuredVariables and Observations?</para>
    ///   <a href="http://linked.earth/ontology#measuredBy">earth:measuredBy</a>
    /// </summary>
    let measuredBy = _prefixId.prefix "measuredBy"
    /// <summary>
    ///   <para>rdfs:label : measuredOn</para>
    ///   <para>rdfs:comment : On what Archive were the Observations measured on?</para>
    ///   <a href="http://linked.earth/ontology#measuredOn">earth:measuredOn</a>
    /// </summary>
    let measuredOn = _prefixId.prefix "measuredOn"
    /// <summary>
    ///   <para>rdfs:label : method</para>
    ///   <para>rdfs:comment : Method used to obtain the information from the resource</para>
    ///   <a href="http://linked.earth/ontology#method">earth:method</a>
    /// </summary>
    let method = _prefixId.prefix "method"
    /// <summary>
    ///   <para>rdfs:label : modelReferences</para>
    ///   <para>rdfs:comment : The publication that describes the model. </para>
    ///   <a href="http://linked.earth/ontology#modelReferences">earth:modelReferences</a>
    /// </summary>
    let modelReferences = _prefixId.prefix "modelReferences"
    /// <summary>
    ///   <para>rdfs:label : modeledBy</para>
    ///   <para>rdfs:comment : How was the process modeled?</para>
    ///   <a href="http://linked.earth/ontology#modeledBy">earth:modeledBy</a>
    /// </summary>
    let modeledBy = _prefixId.prefix "modeledBy"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : Name of the described resource</para>
    ///   <a href="http://linked.earth/ontology#name">earth:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : notes</para>
    ///   <para>rdfs:comment : Notes regarding the cells in the DataTable</para>
    ///   <a href="http://linked.earth/ontology#notes">earth:notes</a>
    /// </summary>
    let notes = _prefixId.prefix "notes"
    /// <summary>
    ///   <para>rdfs:label : observedAs</para>
    ///   <para>rdfs:comment : What Observations were made?</para>
    ///   <a href="http://linked.earth/ontology#observedAs">earth:observedAs</a>
    /// </summary>
    let observedAs = _prefixId.prefix "observedAs"
    /// <summary>
    ///   <para>rdfs:label : orcidNumber</para>
    ///   <para>rdfs:comment : The ORCID number of the Person^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#orcidNumber">earth:orcidNumber</a>
    /// </summary>
    let orcidNumber = _prefixId.prefix "orcidNumber"
    /// <summary>
    ///   <para>rdfs:label : pages</para>
    ///   <para>rdfs:comment : The page range for the article.</para>
    ///   <a href="http://linked.earth/ontology#pages">earth:pages</a>
    /// </summary>
    let pages = _prefixId.prefix "pages"
    /// <summary>
    ///   <para>rdfs:label : paleoModeledBy</para>
    ///   <para>rdfs:comment : How was the paleoData modeled?</para>
    ///   <a href="http://linked.earth/ontology#paleoModeledBy">earth:paleoModeledBy</a>
    /// </summary>
    let paleoModeledBy = _prefixId.prefix "paleoModeledBy"
    /// <summary>
    ///   <para>rdfs:label : principalInvestigator</para>
    ///   <para>rdfs:comment : Who is the PrincipalInvestigator of the Funding grant?</para>
    ///   <a href="http://linked.earth/ontology#principalInvestigator">earth:principalInvestigator</a>
    /// </summary>
    let principalInvestigator = _prefixId.prefix "principalInvestigator"
    /// <summary>
    ///   <para>rdfs:label : publicationYear</para>
    ///   <para>rdfs:comment : Year when the publication was published. The literal is a numeric value in the format yyyy</para>
    ///   <a href="http://linked.earth/ontology#publicationYear">earth:publicationYear</a>
    /// </summary>
    let publicationYear = _prefixId.prefix "publicationYear"
    /// <summary>
    ///   <para>rdfs:label : publishedIn</para>
    ///   <para>rdfs:comment : Where was the Dataset published? Property that relates a dataset to the publication where it was published.</para>
    ///   <a href="http://linked.earth/ontology#publishedIn">earth:publishedIn</a>
    /// </summary>
    let publishedIn = _prefixId.prefix "publishedIn"
    /// <summary>
    ///   <para>rdfs:label : relevantQuote</para>
    ///   <para>rdfs:comment : Relevant summary or preferably quotation from the referenced Publication^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#relevantQuote">earth:relevantQuote</a>
    /// </summary>
    let relevantQuote = _prefixId.prefix "relevantQuote"
    /// <summary>
    ///   <para>rdfs:label : seasonality</para>
    ///   <para>rdfs:comment : fluctuating or restricted according to the season or time of year</para>
    ///   <a href="http://linked.earth/ontology#seasonality">earth:seasonality</a>
    /// </summary>
    let seasonality = _prefixId.prefix "seasonality"
    /// <summary>
    ///   <para>rdfs:label : sensingWith</para>
    ///   <para>rdfs:comment : How does the proxy system senses the environment?</para>
    ///   <a href="http://linked.earth/ontology#sensingWith">earth:sensingWith</a>
    /// </summary>
    let sensingWith = _prefixId.prefix "sensingWith"
    /// <summary>
    ///   <para>rdfs:label : sensorGenus</para>
    ///   <para>rdfs:comment : The Genus of the sensor^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#sensorGenus">earth:sensorGenus</a>
    /// </summary>
    let sensorGenus = _prefixId.prefix "sensorGenus"
    /// <summary>
    ///   <para>rdfs:label : sensorSpecies</para>
    ///   <para>rdfs:comment : The species of the sensor^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#sensorSpecies">earth:sensorSpecies</a>
    /// </summary>
    let sensorSpecies = _prefixId.prefix "sensorSpecies"
    /// <summary>
    ///   <para>rdfs:label : standard</para>
    ///   <para>rdfs:comment : The standard against which the observations are reported (for instance, VSMOW or VPDB)</para>
    ///   <a href="http://linked.earth/ontology#standard">earth:standard</a>
    /// </summary>
    let standard = _prefixId.prefix "standard"
    /// <summary>
    ///   <para>rdfs:label : title</para>
    ///   <para>rdfs:comment : Title of a publication</para>
    ///   <a href="http://linked.earth/ontology#title">earth:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : uncertaintyLevel</para>
    ///   <para>rdfs:comment : Quantile or number of standard deviations along a probability distribution of a Variable.^^xsd:string</para>
    ///   <a href="http://linked.earth/ontology#uncertaintyLevel">earth:uncertaintyLevel</a>
    /// </summary>
    let uncertaintyLevel = _prefixId.prefix "uncertaintyLevel"
    /// <summary>
    ///   <para>rdfs:label : volume</para>
    ///   <para>rdfs:comment : The volume number in which the publication appeared.</para>
    ///   <a href="http://linked.earth/ontology#volume">earth:volume</a>
    /// </summary>
    let volume = _prefixId.prefix "volume"
    /// <summary>
    ///   <para>rdfs:label : warnings</para>
    ///   <para>rdfs:comment : Warnings of the variable or dataset being annotated</para>
    ///   <a href="http://linked.earth/ontology#warnings">earth:warnings</a>
    /// </summary>
    let warnings = _prefixId.prefix "warnings"
