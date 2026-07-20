namespace http.linked.earth.ontology.hash

open DoxAletheia

module earth =
    let _namespace_name = "http://linked.earth/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The medium in which the response of a sensor to environmental forcing is recorded (e.g., marine sediments, ice core, lake sediments, speleothems). Sensu Evans et al. (2013)
    /// <see href="http://linked.earth/ontology#Archive"></see></summary>
    let Archive = _prefix "Archive"
    /// <summary>
    /// A simplified description of how the sensor either creates or emplaces the signal into the archive. sensu Evans et al. 2013.
    /// <see href="http://linked.earth/ontology#ArchiveModel"></see></summary>
    let ArchiveModel = _prefix "ArchiveModel"
    /// <summary>
    /// Any system that is at least partially isomorphic to some target system and used to derive information about the structure and/or dynamics of the target system.
    /// <see href="http://linked.earth/ontology#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// Metadata about how the variable was calibrated to reflect an environmental variable
    /// <see href="http://linked.earth/ontology#CalibrationModel"></see></summary>
    let CalibrationModel = _prefix "CalibrationModel"
    /// <summary>
    /// The Data pertaining to chronological information
    /// <see href="http://linked.earth/ontology#ChronData"></see></summary>
    let ChronData = _prefix "ChronData"
    /// <summary>
    /// An aggregation of DataTables and supporting information regarging the paleoenvironmental and/or chronological interpretation
    /// <see href="http://linked.earth/ontology#Data"></see></summary>
    let Data = _prefix "Data"
    /// <summary>
    /// DataTable containing the Chronology Variables
    /// <see href="http://linked.earth/ontology#ChronDataTable"></see></summary>
    let ChronDataTable = _prefix "ChronDataTable"
    /// <summary>
    /// A set of Variables organized in columns
    /// <see href="http://linked.earth/ontology#DataTable"></see></summary>
    let DataTable = _prefix "DataTable"
    /// <summary>
    /// DataTable containig PaleoData Variables
    /// <see href="http://linked.earth/ontology#PaleoDataTable"></see></summary>
    let PaleoDataTable = _prefix "PaleoDataTable"
    /// <summary>
    /// Model used to obtain the chronology
    /// <see href="http://linked.earth/ontology#ChronModel"></see></summary>
    let ChronModel = _prefix "ChronModel"
    /// <summary>
    /// The data and metadata associated with how the chronology information was obtained.
    /// <see href="http://linked.earth/ontology#ChronProxy"></see></summary>
    let ChronProxy = _prefix "ChronProxy"
    /// <summary>
    /// a measured variable used to infer the value of a variable of interest
    /// <see href="http://linked.earth/ontology#Proxy"></see></summary>
    let Proxy = _prefix "Proxy"
    /// <summary>
    /// A suite of metadata that describe how a variable is interpreted to reflect past environmental variability
    /// <see href="http://linked.earth/ontology#ClimateInterpretation"></see></summary>
    let ClimateInterpretation = _prefix "ClimateInterpretation"
    /// <summary>
    /// A suite of metadata that describe how a variable is interpreted to reflect past variability, including environmental variability
    /// <see href="http://linked.earth/ontology#Interpretation"></see></summary>
    let Interpretation = _prefix "Interpretation"
    /// <summary>
    /// Climate observations prior to the instrumental era are necessarily indirect. These observations are made on climate proxies in various geological (e.g. lake or marine sediments, living or fossil coral reefs, cave deposits), glaciological (ice cores or snow pits) or biological (trees) archives. Many types of measurements can be made on each archives, each sensing a different aspect of the environment (sometimes, several aspects at once). A paleoclimate dataset is a set of observations made on an archive.
    /// <see href="http://linked.earth/ontology#ClimateProxy"></see></summary>
    let ClimateProxy = _prefix "ClimateProxy"
    /// <summary>
    /// A structured collection of related information, including - but not limited to - geographical, chronological, and measured or modeled paleoenvironmental data
    /// <see href="http://linked.earth/ontology#Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// Table that contains the probability on the inferred variables
    /// <see href="http://linked.earth/ontology#DistributionTable"></see></summary>
    let DistributionTable = _prefix "DistributionTable"
    /// <summary>
    /// Table containing possible series of age models or proxy variability
    /// <see href="http://linked.earth/ontology#EnsembleTable"></see></summary>
    let EnsembleTable = _prefix "EnsembleTable"
    /// <summary>
    /// A source of funding for the creation of the Dataset
    /// <see href="http://linked.earth/ontology#Funding"></see></summary>
    let Funding = _prefix "Funding"
    /// <summary>
    /// Is the variable inferred from a measured variable?
    /// <see href="http://linked.earth/ontology#InferredVariable"></see></summary>
    let InferredVariable = _prefix "InferredVariable"
    /// <summary>
    /// Quantities which can be measured or inferred independently in an experiment
    /// <see href="http://linked.earth/ontology#Variable"></see></summary>
    let Variable = _prefix "Variable"
    /// <summary>
    /// Is the variable measured with an instrument?
    /// <see href="http://linked.earth/ontology#MeasuredVariable"></see></summary>
    let MeasuredVariable = _prefix "MeasuredVariable"
    /// <summary>
    /// An inorganic senso like.karst system, catchment basin, etc.
    /// <see href="http://linked.earth/ontology#InorganicSensor"></see></summary>
    let InorganicSensor = _prefix "InorganicSensor"
    /// <summary>
    /// The sensor comprises physical, chemical and/or biological components that react to environmental conditions (e.g, foraminifera, coral polyps, cave, catchment basin). sensu Evans et al. (2013)
    /// <see href="http://linked.earth/ontology#Sensor"></see></summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// An organic sensor (e.g., foraminifera, tree, corals...)
    /// <see href="http://linked.earth/ontology#OrganicSensor"></see></summary>
    let OrganicSensor = _prefix "OrganicSensor"
    /// <summary>
    /// A tool or implement used to produce MeasuredVariables
    /// <see href="http://linked.earth/ontology#Instrument"></see></summary>
    let Instrument = _prefix "Instrument"
    /// <summary>
    /// The integration time of the Archive or the Sensor
    /// <see href="http://linked.earth/ontology#IntegrationTime"></see></summary>
    let IntegrationTime = _prefix "IntegrationTime"
    /// <summary>
    /// A formalization of the behavior of the sensor in response to environmental forcing. Sensu Evans et al. 2013.
    /// <see href="http://linked.earth/ontology#SensorModel"></see></summary>
    let SensorModel = _prefix "SensorModel"
    /// <summary>
    /// A suite of metadata that describe how a MeasuredVariable with instance Isotope is interpreted to reflect past variability, including environmental variability
    /// <see href="http://linked.earth/ontology#IsotopeInterpretation"></see></summary>
    let IsotopeInterpretation = _prefix "IsotopeInterpretation"
    /// <summary>
    /// The geographic data and metadata for the dataset
    /// <see href="http://linked.earth/ontology#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// Table that contains the measuredVariables made on the Archive
    /// <see href="http://linked.earth/ontology#MeasurementTable"></see></summary>
    let MeasurementTable = _prefix "MeasurementTable"
    /// <summary>
    /// A publication that has not undergone a formal review process; for instance, a Dataset attached to a dissertation.
    /// <see href="http://linked.earth/ontology#NonPeerReviewedPublication"></see></summary>
    let NonPeerReviewedPublication = _prefix "NonPeerReviewedPublication"
    /// <summary>
    /// A document that serves as reference for a Dataset or its components
    /// <see href="http://linked.earth/ontology#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// A publication that has undergone a formal peer-reviewed process.
    /// <see href="http://linked.earth/ontology#PeerReviewedPublication"></see></summary>
    let PeerReviewedPublication = _prefix "PeerReviewedPublication"
    /// <summary>
    /// The measurements made on the archives, whether chemical (e.g., Mg/Ca, d18O, TEX86, Sr/Ca....), physical (e.g. density, layer thickness) or biological (e.g. species abundance). Evans et al. (2013). Observations are MeasuredVariables
    /// <see href="http://linked.earth/ontology#Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// The simplified representation of the way in which observations are made on the archive. sensu Evans et al. 2013.
    /// <see href="http://linked.earth/ontology#ObservationModel"></see></summary>
    let ObservationModel = _prefix "ObservationModel"
    /// <summary>
    /// The Data pertaining to past environmental variability
    /// <see href="http://linked.earth/ontology#PaleoData"></see></summary>
    let PaleoData = _prefix "PaleoData"
    /// <summary>
    /// Model describing how the measuredVariables are transformed into inferredVariables
    /// <see href="http://linked.earth/ontology#PaleoModel"></see></summary>
    let PaleoModel = _prefix "PaleoModel"
    /// <summary>
    /// A person that has participated directly or indirectly in the authoring or contribution of any resources in  Linked Earth.
    /// <see href="http://linked.earth/ontology#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// In the Evans et al. (2013) framework, this is the combination of sensor, archive and observation models . "A generalized proxy system model encapuslates a simplified representation of prior physical, chemical, biological, and/or geological understanding of the ways in which environmental variation ultimately results in the observations used to retrieve paleoclimatic information."
    /// <see href="http://linked.earth/ontology#ProxySystemModel"></see></summary>
    let ProxySystemModel = _prefix "ProxySystemModel"
    /// <summary>
    /// Refers to the distance (physical or temporal) between each point on the archive. May or May not be related to sampling. Value with units
    /// <see href="http://linked.earth/ontology#Resolution"></see></summary>
    let Resolution = _prefix "Resolution"
    /// <summary>
    /// A script that describes the model, in any programming language (e.g., Excel, Matlab, Python, R)
    /// <see href="http://linked.earth/ontology#SoftwareCode"></see></summary>
    let SoftwareCode = _prefix "SoftwareCode"
    /// <summary>
    ///   <see href="http://linked.earth/ontology#SummaryTable"></see>
    /// </summary>
    let SummaryTable = _prefix "SummaryTable"
    /// <summary>
    /// A state of incomplete knowledge that can result from a lack of information or from disagreement about what is known or  even knowable. Uncertainty may come from many sources, from imprecision in the data to ambigously defined concepts or terminology, or uncertain projections of human bahavior. Uncertainty can be represented by quantitative measures (e.g., probability density function) or by qualitative statement (e.g., reflecting the judgement of a team of experts. Sensu IPCC AR5
    /// <see href="http://linked.earth/ontology#Uncertainty"></see></summary>
    let Uncertainty = _prefix "Uncertainty"
    /// <summary>
    /// A formalization of the way the uncertainty is accounted for
    /// <see href="http://linked.earth/ontology#UncertaintyModel"></see></summary>
    let UncertaintyModel = _prefix "UncertaintyModel"
    /// <summary>
    /// How was the climate or chronological information encoded into the Archive?
    /// <see href="http://linked.earth/ontology#archivedIn"></see></summary>
    let archivedIn = _prefix "archivedIn"
    /// <summary>
    /// Author of the resource
    /// <see href="http://linked.earth/ontology#author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    /// How are the data obtained?
    /// <see href="http://linked.earth/ontology#basedOn"></see></summary>
    let basedOn = _prefix "basedOn"
    /// <summary>
    /// Book in which the publication was published
    /// <see href="http://linked.earth/ontology#book"></see></summary>
    let book = _prefix "book"
    /// <summary>
    /// Property that indicates how the measured variable was calibrated
    /// <see href="http://linked.earth/ontology#calibratedFrom"></see></summary>
    let calibratedFrom = _prefix "calibratedFrom"
    /// <summary>
    /// How was the variable calibrated to represent climate or chronology?
    /// <see href="http://linked.earth/ontology#calibratedWith"></see></summary>
    let calibratedWith = _prefix "calibratedWith"
    /// <summary>
    /// The publication that describes the calibration. The string should follow the model set in the publication class
    /// <see href="http://linked.earth/ontology#calibrationReferences"></see></summary>
    let calibrationReferences = _prefix "calibrationReferences"
    /// <summary>
    /// How was the chron data modeled?
    /// <see href="http://linked.earth/ontology#chronModeledBy"></see></summary>
    let chronModeledBy = _prefix "chronModeledBy"
    /// <summary>
    /// How was the process modeled?
    /// <see href="http://linked.earth/ontology#modeledBy"></see></summary>
    let modeledBy = _prefix "modeledBy"
    /// <summary>
    /// Sentence indicating how a paper should be published
    /// <see href="http://linked.earth/ontology#citation"></see></summary>
    let citation = _prefix "citation"
    /// <summary>
    /// Where was the data in the dataset collected from? Generally, this is the site where the archive was collected.
    /// <see href="http://linked.earth/ontology#collectedFrom"></see></summary>
    let collectedFrom = _prefix "collectedFrom"
    /// <summary>
    /// Contributor of the resource (dataset, publication, etc.)
    /// <see href="http://linked.earth/ontology#contributor"></see></summary>
    let contributor = _prefix "contributor"
    /// <summary>
    /// Date when the dataset was published.
    /// <see href="http://linked.earth/ontology#datasetDate"></see></summary>
    let datasetDate = _prefix "datasetDate"
    /// <summary>
    /// The version of the dataset. It should follow the x.y.z notation where x refers to changes in metadata and data following a publication (for instance, the creation of a new age model using a different code), y refers to changes to the data following a publication (for instance, adding data further back in time without changing the model underlying the interpretation), and z refers to changes not associated with a publication (for instance, typos).
    /// <see href="http://linked.earth/ontology#datasetVersion"></see></summary>
    let datasetVersion = _prefix "datasetVersion"
    /// <summary>
    /// The description of a resource. This property may be used to provide further details on instrument descriptions, uncertainty description,etc.
    /// <see href="http://linked.earth/ontology#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Answers the "of what" question for a Variable.
    /// <see href="http://linked.earth/ontology#detail"></see></summary>
    let detail = _prefix "detail"
    /// <summary>
    /// email of an author or contributor
    /// <see href="http://linked.earth/ontology#email"></see></summary>
    let email = _prefix "email"
    /// <summary>
    /// The mathematical statement used to describe the model.
    /// <see href="http://linked.earth/ontology#equation"></see></summary>
    let equation = _prefix "equation"
    /// <summary>
    /// Property that indicates that a variable or data is found in a distribution table
    /// <see href="http://linked.earth/ontology#foundInDistributionTable"></see></summary>
    let foundInDistributionTable = _prefix "foundInDistributionTable"
    /// <summary>
    /// Property that indicated the table where the described data can be found
    /// <see href="http://linked.earth/ontology#foundInTable"></see></summary>
    let foundInTable = _prefix "foundInTable"
    /// <summary>
    /// Property that indicates that the data or variable described was found in an ensemble table
    /// <see href="http://linked.earth/ontology#foundInEnsembleTable"></see></summary>
    let foundInEnsembleTable = _prefix "foundInEnsembleTable"
    /// <summary>
    /// Property that indicates that a variable was found in a measurement table
    /// <see href="http://linked.earth/ontology#foundInMeasurementTable"></see></summary>
    let foundInMeasurementTable = _prefix "foundInMeasurementTable"
    /// <summary>
    /// Property that indicates that the describer data or variable was found in a summary table
    /// <see href="http://linked.earth/ontology#foundInSummaryTable"></see></summary>
    let foundInSummaryTable = _prefix "foundInSummaryTable"
    /// <summary>
    /// Property that indicated the funding which made the dataset possible
    /// <see href="http://linked.earth/ontology#fundedBy"></see></summary>
    let fundedBy = _prefix "fundedBy"
    /// <summary>
    /// The agency that funded the development of the Dataset
    /// <see href="http://linked.earth/ontology#fundingAgency"></see></summary>
    let fundingAgency = _prefix "fundingAgency"
    /// <summary>
    /// Country which awarded the funding for the dataset
    /// <see href="http://linked.earth/ontology#fundingCountry"></see></summary>
    let fundingCountry = _prefix "fundingCountry"
    /// <summary>
    /// The grant number associated with the development of the Dataset?
    /// <see href="http://linked.earth/ontology#grantNumber"></see></summary>
    let grantNumber = _prefix "grantNumber"
    /// <summary>
    /// What is the mathematical formulation that describes the Model?
    /// <see href="http://linked.earth/ontology#hasCode"></see></summary>
    let hasCode = _prefix "hasCode"
    /// <summary>
    /// As Digital Object Identifier for a given resource. For example: "oi:10.1191/095968301673881493"
    /// <see href="http://linked.earth/ontology#hasDOI"></see></summary>
    let hasDOI = _prefix "hasDOI"
    /// <summary>
    /// The execution command needed to run the script or software
    /// <see href="http://linked.earth/ontology#hasExecutionCommand"></see></summary>
    let hasExecutionCommand = _prefix "hasExecutionCommand"
    /// <summary>
    /// Execution environment of the code
    /// <see href="http://linked.earth/ontology#hasExecutionEnvironment"></see></summary>
    let hasExecutionEnvironment = _prefix "hasExecutionEnvironment"
    /// <summary>
    /// Name of the CSV file containing the data table
    /// <see href="http://linked.earth/ontology#hasFileName"></see></summary>
    let hasFileName = _prefix "hasFileName"
    /// <summary>
    /// ID for a variable in a table
    /// <see href="http://linked.earth/ontology#hasID"></see></summary>
    let hasID = _prefix "hasID"
    /// <summary>
    /// Identifier used commonly to refer to publications.
    /// <see href="http://linked.earth/ontology#hasISBN"></see></summary>
    let hasISBN = _prefix "hasISBN"
    /// <summary>
    /// 8-digit code used to udentify publications
    /// <see href="http://linked.earth/ontology#hasISSN"></see></summary>
    let hasISSN = _prefix "hasISSN"
    /// <summary>
    /// A downloadable link of a resource
    /// <see href="http://linked.earth/ontology#hasLink"></see></summary>
    let hasLink = _prefix "hasLink"
    /// <summary>
    /// Indicates how the missing values are flagged in a dataset
    /// <see href="http://linked.earth/ontology#hasMissingValue"></see></summary>
    let hasMissingValue = _prefix "hasMissingValue"
    /// <summary>
    /// A column of values for the variable. The literal can be in the form of a vector of values (for instance d18O PaleoObservations),  a vector of strings (for instance different paleoArchiveNames),  a matrix or both
    /// <see href="http://linked.earth/ontology#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// What are the components of the ProxySystemModel?
    /// <see href="http://linked.earth/ontology#hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// Describes the importance of the ClimateInterpretation. For instance, d18Ocalcite is influenced by both temperature and d18Osw. If temperature is the dominant influence, then its rank is 1.
    /// <see href="http://linked.earth/ontology#hasRank"></see></summary>
    let hasRank = _prefix "hasRank"
    /// <summary>
    /// What is the Resolution of the Archive?
    /// <see href="http://linked.earth/ontology#hasResolution"></see></summary>
    let hasResolution = _prefix "hasResolution"
    /// <summary>
    /// What is the Uncertainty associated with the Observations, Model, and Calibration?
    /// <see href="http://linked.earth/ontology#hasUncertainty"></see></summary>
    let hasUncertainty = _prefix "hasUncertainty"
    /// <summary>
    /// units in which a resource is measured The resource can be a Variable, an Observation, a Resolution, or an Uncertainty
    /// <see href="http://linked.earth/ontology#hasUnits"></see></summary>
    let hasUnits = _prefix "hasUnits"
    /// <summary>
    /// Pointer to the chron data included in the dataset
    /// <see href="http://linked.earth/ontology#includesChronData"></see></summary>
    let includesChronData = _prefix "includesChronData"
    /// <summary>
    /// What are the paleoenvironmental and chronological Data included in the Dataset?
    /// <see href="http://linked.earth/ontology#includesData"></see></summary>
    let includesData = _prefix "includesData"
    /// <summary>
    /// The paleo data included as part of a dataset
    /// <see href="http://linked.earth/ontology#includesPaleoData"></see></summary>
    let includesPaleoData = _prefix "includesPaleoData"
    /// <summary>
    /// What are the Variables included in the DataTable?
    /// <see href="http://linked.earth/ontology#includesVariable"></see></summary>
    let includesVariable = _prefix "includesVariable"
    /// <summary>
    /// From which measured variable is the current inferred variable obtained?
    /// <see href="http://linked.earth/ontology#inferredFrom"></see></summary>
    let inferredFrom = _prefix "inferredFrom"
    /// <summary>
    /// Describes whether the interpreted environmental variable increases (positive) or decreases (negative) as the paleoDataVariableValue increases. The literal is a string , either "positive" or "negative"
    /// <see href="http://linked.earth/ontology#interpretationDirection"></see></summary>
    let interpretationDirection = _prefix "interpretationDirection"
    /// <summary>
    /// Describes the basis by which the proxy variable is interpreted in terms of climate.
    /// <see href="http://linked.earth/ontology#interpretationReferences"></see></summary>
    let interpretationReferences = _prefix "interpretationReferences"
    /// <summary>
    /// how is the variable interpreted?
    /// <see href="http://linked.earth/ontology#interpretedAs"></see></summary>
    let interpretedAs = _prefix "interpretedAs"
    /// <summary>
    /// Whether the influence on the MeasuredVariable (and therefore the Interpretation) is local or far-field. The literal is a string.
    /// <see href="http://linked.earth/ontology#isLocal"></see></summary>
    let isLocal = _prefix "isLocal"
    /// <summary>
    /// The issue number for the publication
    /// <see href="http://linked.earth/ontology#issue"></see></summary>
    let issue = _prefix "issue"
    /// <summary>
    /// Property that indicated the journal in which the publication has been published
    /// <see href="http://linked.earth/ontology#journal"></see></summary>
    let journal = _prefix "journal"
    /// <summary>
    /// What Instrument was used to obtain the MeasuredVariables and Observations?
    /// <see href="http://linked.earth/ontology#measuredBy"></see></summary>
    let measuredBy = _prefix "measuredBy"
    /// <summary>
    /// On what Archive were the Observations measured on?
    /// <see href="http://linked.earth/ontology#measuredOn"></see></summary>
    let measuredOn = _prefix "measuredOn"
    /// <summary>
    /// Method used to obtain the information from the resource
    /// <see href="http://linked.earth/ontology#method"></see></summary>
    let method = _prefix "method"
    /// <summary>
    /// The publication that describes the model.
    /// <see href="http://linked.earth/ontology#modelReferences"></see></summary>
    let modelReferences = _prefix "modelReferences"
    /// <summary>
    /// Name of the described resource
    /// <see href="http://linked.earth/ontology#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Notes regarding the cells in the DataTable
    /// <see href="http://linked.earth/ontology#notes"></see></summary>
    let notes = _prefix "notes"
    /// <summary>
    /// What Observations were made?
    /// <see href="http://linked.earth/ontology#observedAs"></see></summary>
    let observedAs = _prefix "observedAs"
    /// <summary>
    /// The ORCID number of the Person
    /// <see href="http://linked.earth/ontology#orcidNumber"></see></summary>
    let orcidNumber = _prefix "orcidNumber"
    /// <summary>
    /// The page range for the article.
    /// <see href="http://linked.earth/ontology#pages"></see></summary>
    let pages = _prefix "pages"
    /// <summary>
    /// How was the paleoData modeled?
    /// <see href="http://linked.earth/ontology#paleoModeledBy"></see></summary>
    let paleoModeledBy = _prefix "paleoModeledBy"
    /// <summary>
    /// Who is the PrincipalInvestigator of the Funding grant?
    /// <see href="http://linked.earth/ontology#principalInvestigator"></see></summary>
    let principalInvestigator = _prefix "principalInvestigator"
    /// <summary>
    /// Year when the publication was published. The literal is a numeric value in the format yyyy
    /// <see href="http://linked.earth/ontology#publicationYear"></see></summary>
    let publicationYear = _prefix "publicationYear"
    /// <summary>
    /// Where was the Dataset published? Property that relates a dataset to the publication where it was published.
    /// <see href="http://linked.earth/ontology#publishedIn"></see></summary>
    let publishedIn = _prefix "publishedIn"
    /// <summary>
    /// Relevant summary or preferably quotation from the referenced Publication
    /// <see href="http://linked.earth/ontology#relevantQuote"></see></summary>
    let relevantQuote = _prefix "relevantQuote"
    /// <summary>
    /// fluctuating or restricted according to the season or time of year
    /// <see href="http://linked.earth/ontology#seasonality"></see></summary>
    let seasonality = _prefix "seasonality"
    /// <summary>
    /// How does the proxy system senses the environment?
    /// <see href="http://linked.earth/ontology#sensingWith"></see></summary>
    let sensingWith = _prefix "sensingWith"
    /// <summary>
    /// The Genus of the sensor
    /// <see href="http://linked.earth/ontology#sensorGenus"></see></summary>
    let sensorGenus = _prefix "sensorGenus"
    /// <summary>
    /// The species of the sensor
    /// <see href="http://linked.earth/ontology#sensorSpecies"></see></summary>
    let sensorSpecies = _prefix "sensorSpecies"
    /// <summary>
    /// The standard against which the observations are reported (for instance, VSMOW or VPDB)
    /// <see href="http://linked.earth/ontology#standard"></see></summary>
    let standard = _prefix "standard"
    /// <summary>
    /// Title of a publication
    /// <see href="http://linked.earth/ontology#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Quantile or number of standard deviations along a probability distribution of a Variable.
    /// <see href="http://linked.earth/ontology#uncertaintyLevel"></see></summary>
    let uncertaintyLevel = _prefix "uncertaintyLevel"
    /// <summary>
    /// The volume number in which the publication appeared.
    /// <see href="http://linked.earth/ontology#volume"></see></summary>
    let volume = _prefix "volume"
    /// <summary>
    /// Warnings of the variable or dataset being annotated
    /// <see href="http://linked.earth/ontology#warnings"></see></summary>
    let warnings = _prefix "warnings"
