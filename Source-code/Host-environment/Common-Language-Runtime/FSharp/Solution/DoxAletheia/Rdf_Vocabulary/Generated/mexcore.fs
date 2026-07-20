namespace http.mex.aksw.org.mex_core.hash

open DoxAletheia

module mexcore =
    let _namespace_name = "http://mex.aksw.org/mex-core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Test"></see>
    /// </summary>
    let Test = _prefix "Test"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Training"></see>
    /// </summary>
    let Training = _prefix "Training"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Validation"></see>
    /// </summary>
    let Validation = _prefix "Validation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#AdaptativeWebSites"></see>
    /// </summary>
    let AdaptativeWebSites = _prefix "AdaptativeWebSites"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Context"></see>
    /// </summary>
    let Context = _prefix "Context"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#AffectiveComputing"></see>
    /// </summary>
    let AffectiveComputing = _prefix "AffectiveComputing"
    /// <summary>
    /// describes the context of the experiment, such as NLP, Stock Market Forecast, BioInformatics, Text-Retrieval AND contact informations/publication
    /// <see href="http://mex.aksw.org/mex-core#ApplicationContext"></see></summary>
    let ApplicationContext = _prefix "ApplicationContext"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#DomainConceptSpace"></see>
    /// </summary>
    let DomainConceptSpace = _prefix "DomainConceptSpace"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Bioinformatics"></see>
    /// </summary>
    let Bioinformatics = _prefix "Bioinformatics"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Bootstrapping"></see>
    /// </summary>
    let Bootstrapping = _prefix "Bootstrapping"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SamplingMethod"></see>
    /// </summary>
    let SamplingMethod = _prefix "SamplingMethod"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#BrainMachineInterfaces"></see>
    /// </summary>
    let BrainMachineInterfaces = _prefix "BrainMachineInterfaces"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Cheminformatics"></see>
    /// </summary>
    let Cheminformatics = _prefix "Cheminformatics"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ClassifyingDNAsequences"></see>
    /// </summary>
    let ClassifyingDNAsequences = _prefix "ClassifyingDNAsequences"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ComputationalAdversiting"></see>
    /// </summary>
    let ComputationalAdversiting = _prefix "ComputationalAdversiting"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ComputationalFinance"></see>
    /// </summary>
    let ComputationalFinance = _prefix "ComputationalFinance"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ComputerVision"></see>
    /// </summary>
    let ComputerVision = _prefix "ComputerVision"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#CrossValidation"></see>
    /// </summary>
    let CrossValidation = _prefix "CrossValidation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Dataset"></see>
    /// </summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#DetectingCreditCardFrauds"></see>
    /// </summary>
    let DetectingCreditCardFrauds = _prefix "DetectingCreditCardFrauds"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ValuePartition"></see>
    /// </summary>
    let ValuePartition = _prefix "ValuePartition"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Example"></see>
    /// </summary>
    let Example = _prefix "Example"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ExampleCollection"></see>
    /// </summary>
    let ExampleCollection = _prefix "ExampleCollection"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Execution"></see>
    /// </summary>
    let Execution = _prefix "Execution"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ExecutionOverall"></see>
    /// </summary>
    let ExecutionOverall = _prefix "ExecutionOverall"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ExecutionSingle"></see>
    /// </summary>
    let ExecutionSingle = _prefix "ExecutionSingle"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Experiment"></see>
    /// </summary>
    let Experiment = _prefix "Experiment"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ExperimentConfiguration"></see>
    /// </summary>
    let ExperimentConfiguration = _prefix "ExperimentConfiguration"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#FactPrediction"></see>
    /// </summary>
    let FactPrediction = _prefix "FactPrediction"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Feature"></see>
    /// </summary>
    let Feature = _prefix "Feature"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#FeatureCollection"></see>
    /// </summary>
    let FeatureCollection = _prefix "FeatureCollection"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#GamePlaying"></see>
    /// </summary>
    let GamePlaying = _prefix "GamePlaying"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#HardwareConfiguration"></see>
    /// </summary>
    let HardwareConfiguration = _prefix "HardwareConfiguration"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Holdout"></see>
    /// </summary>
    let Holdout = _prefix "Holdout"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#InformationRetrieval"></see>
    /// </summary>
    let InformationRetrieval = _prefix "InformationRetrieval"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#InternetFraudDetection"></see>
    /// </summary>
    let InternetFraudDetection = _prefix "InternetFraudDetection"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#LeaveOneOut"></see>
    /// </summary>
    let LeaveOneOut = _prefix "LeaveOneOut"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#LinkDiscovery"></see>
    /// </summary>
    let LinkDiscovery = _prefix "LinkDiscovery"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#MachinePerception"></see>
    /// </summary>
    let MachinePerception = _prefix "MachinePerception"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#MedicalDiagnosis"></see>
    /// </summary>
    let MedicalDiagnosis = _prefix "MedicalDiagnosis"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Metaheuristics"></see>
    /// </summary>
    let Metaheuristics = _prefix "Metaheuristics"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Model"></see>
    /// </summary>
    let Model = _prefix "Model"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#NFoldsCrossValidation"></see>
    /// </summary>
    let NFoldsCrossValidation = _prefix "NFoldsCrossValidation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#NaturalLanguageProcessing"></see>
    /// </summary>
    let NaturalLanguageProcessing = _prefix "NaturalLanguageProcessing"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ObjectRecognition"></see>
    /// </summary>
    let ObjectRecognition = _prefix "ObjectRecognition"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Optimization"></see>
    /// </summary>
    let Optimization = _prefix "Optimization"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Phase"></see>
    /// </summary>
    let Phase = _prefix "Phase"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#RecomenderSystems"></see>
    /// </summary>
    let RecomenderSystems = _prefix "RecomenderSystems"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Robotics"></see>
    /// </summary>
    let Robotics = _prefix "Robotics"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SearchEngines"></see>
    /// </summary>
    let SearchEngines = _prefix "SearchEngines"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SentimentAnalysis"></see>
    /// </summary>
    let SentimentAnalysis = _prefix "SentimentAnalysis"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SequenceMining"></see>
    /// </summary>
    let SequenceMining = _prefix "SequenceMining"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SlidingCrossValidation"></see>
    /// </summary>
    let SlidingCrossValidation = _prefix "SlidingCrossValidation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SoftwareEngineering"></see>
    /// </summary>
    let SoftwareEngineering = _prefix "SoftwareEngineering"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SpeechAndHandwritingRecognition"></see>
    /// </summary>
    let SpeechAndHandwritingRecognition = _prefix "SpeechAndHandwritingRecognition"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#StockMarketAnalysis"></see>
    /// </summary>
    let StockMarketAnalysis = _prefix "StockMarketAnalysis"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#StructuralHealthMonitoring"></see>
    /// </summary>
    let StructuralHealthMonitoring = _prefix "StructuralHealthMonitoring"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SyntacticLanguageProcessing"></see>
    /// </summary>
    let SyntacticLanguageProcessing = _prefix "SyntacticLanguageProcessing"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#attributeSelectionDescription"></see>
    /// </summary>
    let attributeSelectionDescription = _prefix "attributeSelectionDescription"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#cpu"></see>
    /// </summary>
    let cpu = _prefix "cpu"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#cpuCache"></see>
    /// </summary>
    let cpuCache = _prefix "cpuCache"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#dataNormalizedDescription"></see>
    /// </summary>
    let dataNormalizedDescription = _prefix "dataNormalizedDescription"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#datasetColumn"></see>
    /// </summary>
    let datasetColumn = _prefix "datasetColumn"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#datasetRow"></see>
    /// </summary>
    let datasetRow = _prefix "datasetRow"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#endsAt"></see>
    /// </summary>
    let endsAt = _prefix "endsAt"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#endsAtPosition"></see>
    /// </summary>
    let endsAtPosition = _prefix "endsAtPosition"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#folds"></see>
    /// </summary>
    let folds = _prefix "folds"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#hasApplicationContext"></see>
    /// </summary>
    let hasApplicationContext = _prefix "hasApplicationContext"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#hasPhase"></see>
    /// </summary>
    let hasPhase = _prefix "hasPhase"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#hasSamplingMethod"></see>
    /// </summary>
    let hasSamplingMethod = _prefix "hasSamplingMethod"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#hdType"></see>
    /// </summary>
    let hdType = _prefix "hdType"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#memory"></see>
    /// </summary>
    let memory = _prefix "memory"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#noiseRemovedDescription"></see>
    /// </summary>
    let noiseRemovedDescription = _prefix "noiseRemovedDescription"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#numberOfIteraction"></see>
    /// </summary>
    let numberOfIteraction = _prefix "numberOfIteraction"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#outliersRemovedDescription"></see>
    /// </summary>
    let outliersRemovedDescription = _prefix "outliersRemovedDescription"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#sequential"></see>
    /// </summary>
    let sequential = _prefix "sequential"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#startsAt"></see>
    /// </summary>
    let startsAt = _prefix "startsAt"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#startsAtPosition"></see>
    /// </summary>
    let startsAtPosition = _prefix "startsAtPosition"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#targetClass"></see>
    /// </summary>
    let targetClass = _prefix "targetClass"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#testSize"></see>
    /// </summary>
    let testSize = _prefix "testSize"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#trainSize"></see>
    /// </summary>
    let trainSize = _prefix "trainSize"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#trustyURI"></see>
    /// </summary>
    let trustyURI = _prefix "trustyURI"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#trustyURIHash"></see>
    /// </summary>
    let trustyURIHash = _prefix "trustyURIHash"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#videoGraphs"></see>
    /// </summary>
    let videoGraphs = _prefix "videoGraphs"
