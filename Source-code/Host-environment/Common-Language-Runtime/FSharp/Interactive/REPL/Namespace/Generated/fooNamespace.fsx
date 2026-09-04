#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module foo =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/def/foo#" "foo"
    let _namespaceIri = _prefixId.prefix ""
    let Abaw = _prefixId.prefix "Abaw"
    /// <summary>
    ///   <para>skos:definition : Altitude of the elephant in meters at the moment of data collection.^^xsd:string</para>
    ///   <para>rdfs:label : Altitude^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#Altitude">foo:Altitude</a>
    /// </summary>
    let Altitude = _prefixId.prefix "Altitude"
    /// <summary>
    ///   <para>rdfs:label : Animalia</para>
    ///   <a href="https://w3id.org/def/foo#Animalia">foo:Animalia</a>
    /// </summary>
    let Animalia = _prefixId.prefix "Animalia"
    let Aqeela = _prefixId.prefix "Aqeela"
    let Bikang1 = _prefixId.prefix "Bikang1"
    let Bikang2 = _prefixId.prefix "Bikang2"
    let Binbingan = _prefixId.prefix "Binbingan"
    let CNRatio = _prefixId.prefix "CNRatio"
    let CameraTrap = _prefixId.prefix "CameraTrap"
    /// <summary>
    ///   <para>rdfs:label : Carnivora</para>
    ///   <a href="https://w3id.org/def/foo#Carnivora">foo:Carnivora</a>
    /// </summary>
    let Carnivora = _prefixId.prefix "Carnivora"
    let Chordata = _prefixId.prefix "Chordata"
    let Class = _prefixId.prefix "Class"
    /// <summary>
    ///   <para>skos:definition : Clay content of the soil sample.</para>
    ///   <para>rdfs:label : Clay</para>
    ///   <a href="https://w3id.org/def/foo#Clay">foo:Clay</a>
    /// </summary>
    let Clay = _prefixId.prefix "Clay"
    /// <summary>
    ///   <para>skos:definition : Observation count per data set.^^xsd:string</para>
    ///   <para>rdfs:label : Count</para>
    ///   <a href="https://w3id.org/def/foo#Count">foo:Count</a>
    /// </summary>
    let Count = _prefixId.prefix "Count"
    /// <summary>
    ///   <para>skos:definition : TBC^^xsd:string</para>
    ///   <para>rdfs:label : Cov^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#Cov">foo:Cov</a>
    /// </summary>
    let Cov = _prefixId.prefix "Cov"
    let Dara = _prefixId.prefix "Dara"
    let Date = _prefixId.prefix "Date"
    /// <summary>
    ///   <para>skos:definition : Direction of elephant travel at the moment of data collection.^^xsd:string</para>
    ///   <para>rdfs:label : Direction^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#Direction">foo:Direction</a>
    /// </summary>
    let Direction = _prefixId.prefix "Direction"
    /// <summary>
    ///   <para>skos:definition : Distance (m) travelled from the last to the current data collection point.^^xsd:string</para>
    ///   <para>rdfs:label : Distance</para>
    ///   <a href="https://w3id.org/def/foo#Distance">foo:Distance</a>
    /// </summary>
    let Distance = _prefixId.prefix "Distance"
    /// <summary>
    ///   <para>rdfs:label : Elephantidae</para>
    ///   <a href="https://w3id.org/def/foo#Elephantidae">foo:Elephantidae</a>
    /// </summary>
    let Elephantidae = _prefixId.prefix "Elephantidae"
    let ElephasMaximus = _prefixId.prefix "ElephasMaximus"
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>skos:definition : The thing whose property is being estimated or calculated in the course of an Observation to arrive at a Result, or whose property is being manipulated by an Actuator, or which is being sampled or transformed in the act of Sampling. In the context of FOO, Soil is the FeatureOfInterest. Most of the sensors are used to observe a property (phenomenon) of a location (e.g., the moisture of soil).</para>
    ///   <para>rdfs:label : Feature of Interest</para>
    ///   <a href="https://w3id.org/def/foo#FeatureOfInterest">foo:FeatureOfInterest</a>
    /// </summary>
    let FeatureOfInterest = _prefixId.prefix "FeatureOfInterest"
    /// <summary>
    ///   <para>skos:definition : The GMT date in Sabah, Malaysia, when the GPS collar records its readings.^^xsd:string</para>
    ///   <para>rdfs:label : GMT Date^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#GMTDate">foo:GMTDate</a>
    /// </summary>
    let GMTDate = _prefixId.prefix "GMTDate"
    /// <summary>
    ///   <para>skos:definition : The GMT time in Sabah, Malaysia, when the GPS collar records its readings.^^xsd:string</para>
    ///   <para>rdfs:label : GMT Time^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#GMTTime">foo:GMTTime</a>
    /// </summary>
    let GMTTime = _prefixId.prefix "GMTTime"
    let GPSObservation = _prefixId.prefix "GPSObservation"
    let Genus = _prefixId.prefix "Genus"
    let Guli = _prefixId.prefix "Guli"
    /// <summary>
    ///   <para>skos:definition : Horizontal Dilution of Precision (HDOP), indicating GPS accuracy in latitude and longitude. Lower values indicate better precision.^^xsd:string</para>
    ///   <para>rdfs:label : HDOP^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#HDOP">foo:HDOP</a>
    /// </summary>
    let HDOP = _prefixId.prefix "HDOP"
    /// <summary>
    ///   <para>skos:definition : Soil horizon sampled.</para>
    ///   <para>rdfs:label : Horizon</para>
    ///   <a href="https://w3id.org/def/foo#Horizon">foo:Horizon</a>
    /// </summary>
    let Horizon = _prefixId.prefix "Horizon"
    /// <summary>
    ///   <para>rdfs:label : ID^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#ID">foo:ID</a>
    /// </summary>
    let ID = _prefixId.prefix "ID"
    let Identifier = _prefixId.prefix "Identifier"
    let Image = _prefixId.prefix "Image"
    let ImageID = _prefixId.prefix "ImageID"
    let ImageObservation = _prefixId.prefix "ImageObservation"
    let InorganicP = _prefixId.prefix "InorganicP"
    let Ita = _prefixId.prefix "Ita"
    let Jasmin = _prefixId.prefix "Jasmin"
    let Jasper = _prefixId.prefix "Jasper"
    let Kasih = _prefixId.prefix "Kasih"
    let Kingdom = _prefixId.prefix "Kingdom"
    let Kuma = _prefixId.prefix "Kuma"
    /// <summary>
    ///   <para>skos:definition : Land use of the study plots: Unlogged tropical forest, Logged tropical forest or Oil palm plantation.</para>
    ///   <para>rdfs:label : Land Use</para>
    ///   <a href="https://w3id.org/def/foo#LandUse">foo:LandUse</a>
    /// </summary>
    let LandUse = _prefixId.prefix "LandUse"
    /// <summary>
    ///   <para>skos:definition : Latitudinal coordinate of the elephant at the moment of data collection.^^xsd:string</para>
    ///   <para>rdfs:label : Latitude^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#Latitude">foo:Latitude</a>
    /// </summary>
    let Latitude = _prefixId.prefix "Latitude"
    let LianaDBH_cm = _prefixId.prefix "LianaDBH_cm"
    let Lianas = _prefixId.prefix "Lianas"
    let Liun = _prefixId.prefix "Liun"
    /// <summary>
    ///   <para>skos:definition : The local date in Sabah, Malaysia, when the GPS collar records its readings.^^xsd:string</para>
    ///   <para>rdfs:label : Local Date^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#LocalDate">foo:LocalDate</a>
    /// </summary>
    let LocalDate = _prefixId.prefix "LocalDate"
    /// <summary>
    ///   <para>skos:definition : The local time in Sabah, Malaysia, when the GPS collar records its readings.^^xsd:string</para>
    ///   <para>rdfs:label : Local Time^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#LocalTime">foo:LocalTime</a>
    /// </summary>
    let LocalTime = _prefixId.prefix "LocalTime"
    /// <summary>
    ///   <para>skos:definition : Longitudinal coordinate of the elephant at the moment of data collection.^^xsd:string</para>
    ///   <para>rdfs:label : Longitude^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#Longitude">foo:Longitude</a>
    /// </summary>
    let Longitude = _prefixId.prefix "Longitude"
    let Make = _prefixId.prefix "Make"
    let MalayopythonReticulatus = _prefixId.prefix "MalayopythonReticulatus"
    let Maliau = _prefixId.prefix "Maliau"
    /// <summary>
    ///   <para>rdfs:label : Mammalia</para>
    ///   <a href="https://w3id.org/def/foo#Mammalia">foo:Mammalia</a>
    /// </summary>
    let Mammalia = _prefixId.prefix "Mammalia"
    let ManisJavanica = _prefixId.prefix "ManisJavanica"
    let Merotai = _prefixId.prefix "Merotai"
    let Model = _prefixId.prefix "Model"
    let Nasalislarvatus = _prefixId.prefix "Nasalislarvatus"
    /// <summary>
    ///   <para>skos:definition : An observable quality (property, characteristic) of a FeatureOfInterest. (e.g., Temperature, humidity, presence)</para>
    ///   <para>rdfs:label : Observable Property</para>
    ///   <a href="https://w3id.org/def/foo#ObservableProperty">foo:ObservableProperty</a>
    /// </summary>
    let ObservableProperty = _prefixId.prefix "ObservableProperty"
    /// <summary>
    ///   <para>skos:definition : Act of carrying out an (Observation) Procedure to estimate or calculate a value of a property of a FeatureOfInterest (e.g., Elephant). Observation can be seen as a placeholder that links relevant information together. In our ontology, observation can be considered an ID for each data record.</para>
    ///   <para>rdfs:label : Observation</para>
    ///   <a href="https://w3id.org/def/foo#Observation">foo:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    let Order = _prefixId.prefix "Order"
    let Phylum = _prefixId.prefix "Phylum"
    /// <summary>
    ///   <para>skos:definition : Name of the 1 Ha plot sampled.</para>
    ///   <para>rdfs:label : Plot Name^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#PlotName">foo:PlotName</a>
    /// </summary>
    let PlotName = _prefixId.prefix "PlotName"
    let PlotNo = _prefixId.prefix "PlotNo"
    /// <summary>
    ///   <para>rdfs:label : Proboscidea </para>
    ///   <a href="https://w3id.org/def/foo#Proboscidea">foo:Proboscidea</a>
    /// </summary>
    let Proboscidea = _prefixId.prefix "Proboscidea"
    let Puteri = _prefixId.prefix "Puteri"
    let Putut = _prefixId.prefix "Putut"
    /// <summary>
    ///   <para>rdfs:label : Reptilia</para>
    ///   <a href="https://w3id.org/def/foo#Reptilia">foo:Reptilia</a>
    /// </summary>
    let Reptilia = _prefixId.prefix "Reptilia"
    let Sand = _prefixId.prefix "Sand"
    let Sejati = _prefixId.prefix "Sejati"
    /// <summary>
    ///   <para>skos:definition : Device, agent (including humans), or software (simulation) involved in, or implementing, a Procedure. (e.g., Temperature sensor, humidity sensor, motion sensor). In our model, we have created a unique ID for each sensor based on the platform it is hosted by.</para>
    ///   <para>rdfs:label : Sensor</para>
    ///   <a href="https://w3id.org/def/foo#Sensor">foo:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    let Seri = _prefixId.prefix "Seri"
    /// <summary>
    ///   <para>skos:definition : Silt content of the soil sample.</para>
    ///   <para>rdfs:label : Silt</para>
    ///   <a href="https://w3id.org/def/foo#Silt">foo:Silt</a>
    /// </summary>
    let Silt = _prefixId.prefix "Silt"
    /// <summary>
    ///   <para>skos:definition : Geographical area/site which samples were taken from.</para>
    ///   <para>rdfs:label : Site</para>
    ///   <a href="https://w3id.org/def/foo#Site">foo:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    let SiteName = _prefixId.prefix "SiteName"
    let SitePlotCode = _prefixId.prefix "SitePlotCode"
    let Soil = _prefixId.prefix "Soil"
    let SoilObservation = _prefixId.prefix "SoilObservation"
    /// <summary>
    ///   <para>skos:definition : Measured pH of the soil sample.</para>
    ///   <para>rdfs:label : Soil PH^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#SoilPH">foo:SoilPH</a>
    /// </summary>
    let SoilPH = _prefixId.prefix "SoilPH"
    let SoilSensor = _prefixId.prefix "SoilSensor"
    let Species = _prefixId.prefix "Species"
    /// <summary>
    ///   <para>skos:definition : Speed of the elephant at the moment of data collection.^^xsd:string</para>
    ///   <para>rdfs:label : Speed^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#Speed">foo:Speed</a>
    /// </summary>
    let Speed = _prefixId.prefix "Speed"
    /// <summary>
    ///   <para>rdfs:label : Squamata</para>
    ///   <a href="https://w3id.org/def/foo#Squamata">foo:Squamata</a>
    /// </summary>
    let Squamata = _prefixId.prefix "Squamata"
    /// <summary>
    ///   <para>skos:definition : Number of the subplot sampled within each 1 Ha plot.</para>
    ///   <para>rdfs:label : Sub plot</para>
    ///   <a href="https://w3id.org/def/foo#Subplot">foo:Subplot</a>
    /// </summary>
    let Subplot = _prefixId.prefix "Subplot"
    let SubplotRadius_m = _prefixId.prefix "SubplotRadius_m"
    let TaxonRank = _prefixId.prefix "TaxonRank"
    /// <summary>
    ///   <para>skos:definition : Estimated temperature of the elephant in Celsius at the moment of data collection.^^xsd:string</para>
    ///   <para>rdfs:label : Temperature^^xsd:string</para>
    ///   <a href="https://w3id.org/def/foo#Temperature">foo:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>skos:definition : Total carbon content of the soil sample.</para>
    ///   <para>rdfs:label : Total C</para>
    ///   <a href="https://w3id.org/def/foo#TotalC">foo:TotalC</a>
    /// </summary>
    let TotalC = _prefixId.prefix "TotalC"
    /// <summary>
    ///   <para>skos:definition : Total nitrogen content of the soil sample.</para>
    ///   <para>rdfs:label : Total N</para>
    ///   <a href="https://w3id.org/def/foo#TotalN">foo:TotalN</a>
    /// </summary>
    let TotalN = _prefixId.prefix "TotalN"
    let TotalP = _prefixId.prefix "TotalP"
    let TreeDBH_cm = _prefixId.prefix "TreeDBH_cm"
    let TreeHeight_m = _prefixId.prefix "TreeHeight_m"
    let TreeID = _prefixId.prefix "TreeID"
    let TreeIndividualNo = _prefixId.prefix "TreeIndividualNo"
    let TreeNLianas = _prefixId.prefix "TreeNLianas"
    let TreeNotes = _prefixId.prefix "TreeNotes"
    let TreeObservation = _prefixId.prefix "TreeObservation"
    let Tulid = _prefixId.prefix "Tulid"
    let Tunglap = _prefixId.prefix "Tunglap"
    let Umas2 = _prefixId.prefix "Umas2"
    let ``V2.0`` = _prefixId.prefix "V2.0"
    /// <summary>
    ///   <para>rdfs:label : Viverridae</para>
    ///   <a href="https://w3id.org/def/foo#Viverridae">foo:Viverridae</a>
    /// </summary>
    let Viverridae = _prefixId.prefix "Viverridae"
    /// <summary>
    ///   <para>skos:example : For example, in an Observation of the weight of a person, the FeatureOfInterest is the person and the property is its weight.</para>
    ///   <para>rdfs:label : has Feature Of Interest</para>
    ///   <para>rdfs:comment : A relation between an Observation and the entity whose quality was observed, or between an Actuation and the entity whose property was modified, or between an act of Sampling and the entity that was sampled.</para>
    ///   <para>skos:definition : A relation between an Observation and the entity whose quality was observed, or between an Actuation and the entity whose property was modified, or between an act of Sampling and the entity that was sampled.</para>
    ///   <a href="https://w3id.org/def/foo#hasFeatureOfInterest">foo:hasFeatureOfInterest</a>
    /// </summary>
    let hasFeatureOfInterest = _prefixId.prefix "hasFeatureOfInterest"
    /// <summary>
    ///   <para>skos:definition : A relation between a FeatureOfInterest and an Observation about it, an Actuation acting on it, or an act of Sampling that sampled it.</para>
    ///   <para>rdfs:label : is feature of interest of</para>
    ///   <para>rdfs:comment : A relation between a FeatureOfInterest and an Observation about it, an Actuation acting on it, or an act of Sampling that sampled it.</para>
    ///   <a href="https://w3id.org/def/foo#isFeatureOfInterestOf">foo:isFeatureOfInterestOf</a>
    /// </summary>
    let isFeatureOfInterestOf = _prefixId.prefix "isFeatureOfInterestOf"
    /// <summary>
    ///   <para>skos:definition : Relation between an ObservableProperty and the Sensor able to observe it.</para>
    ///   <para>rdfs:label : is observed by</para>
    ///   <para>rdfs:comment : Relation between an ObservableProperty and the Sensor able to observe it.</para>
    ///   <a href="https://w3id.org/def/foo#isObservedBy">foo:isObservedBy</a>
    /// </summary>
    let isObservedBy = _prefixId.prefix "isObservedBy"
    /// <summary>
    ///   <para>skos:definition : Relation between an Observation and the Sensor which made the Observation.</para>
    ///   <para>rdfs:label : made by sensor</para>
    ///   <para>rdfs:comment : Relation between an Observation and the Sensor which made the Observation.</para>
    ///   <a href="https://w3id.org/def/foo#madeBySensor">foo:madeBySensor</a>
    /// </summary>
    let madeBySensor = _prefixId.prefix "madeBySensor"
    /// <summary>
    ///   <para>skos:definition : Relation between a Sensor and an Observation made by the Sensor.</para>
    ///   <para>rdfs:label : made observation</para>
    ///   <para>rdfs:comment : Relation between a Sensor and an Observation made by the Sensor.</para>
    ///   <a href="https://w3id.org/def/foo#madeObservation">foo:madeObservation</a>
    /// </summary>
    let madeObservation = _prefixId.prefix "madeObservation"
    /// <summary>
    ///   <para>skos:definition : Relation linking an Observation to the property that was observed. The ObservableProperty should be a property of the FeatureOfInterest (linked by hasFeatureOfInterest) of this Observation.</para>
    ///   <para>rdfs:label : observed property</para>
    ///   <para>rdfs:comment : Relation linking an Observation to the property that was observed. The ObservableProperty should be a property of the FeatureOfInterest (linked by hasFeatureOfInterest) of this Observation.</para>
    ///   <a href="https://w3id.org/def/foo#observedProperty">foo:observedProperty</a>
    /// </summary>
    let observedProperty = _prefixId.prefix "observedProperty"
    /// <summary>
    ///   <para>skos:definition : Relation between a Sensor and an ObservableProperty that it is capable of sensing.</para>
    ///   <para>rdfs:label : observes</para>
    ///   <para>rdfs:comment : Relation between a Sensor and an ObservableProperty that it is capable of sensing.</para>
    ///   <a href="https://w3id.org/def/foo#observes">foo:observes</a>
    /// </summary>
    let observes = _prefixId.prefix "observes"
    let resultTime = _prefixId.prefix "resultTime"
