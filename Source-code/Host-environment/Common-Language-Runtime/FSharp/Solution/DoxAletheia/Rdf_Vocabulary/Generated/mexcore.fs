namespace http.mex.aksw.org.mex_core.hash

open DoxAletheia.Rdf_Vocabulary

module mexcore =
    let _namespace_name = "http://mex.aksw.org/mex-core#"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Test"></see>
    /// </summary>
    let Test = Namespaced_IRI.parse _namespace_name "Test" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Training"></see>
    /// </summary>
    let Training = Namespaced_IRI.parse _namespace_name "Training" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Validation"></see>
    /// </summary>
    let Validation = Namespaced_IRI.parse _namespace_name "Validation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#AdaptativeWebSites"></see>
    /// </summary>
    let AdaptativeWebSites =
        Namespaced_IRI.parse _namespace_name "AdaptativeWebSites" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Context"></see>
    /// </summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#AffectiveComputing"></see>
    /// </summary>
    let AffectiveComputing =
        Namespaced_IRI.parse _namespace_name "AffectiveComputing" |> NamespacedName

    /// <summary>
    /// describes the context of the experiment, such as NLP, Stock Market Forecast, BioInformatics, Text-Retrieval AND contact informations/publication
    /// <see href="http://mex.aksw.org/mex-core#ApplicationContext"></see></summary>
    let ApplicationContext =
        Namespaced_IRI.parse _namespace_name "ApplicationContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#DomainConceptSpace"></see>
    /// </summary>
    let DomainConceptSpace =
        Namespaced_IRI.parse _namespace_name "DomainConceptSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Bioinformatics"></see>
    /// </summary>
    let Bioinformatics =
        Namespaced_IRI.parse _namespace_name "Bioinformatics" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Bootstrapping"></see>
    /// </summary>
    let Bootstrapping =
        Namespaced_IRI.parse _namespace_name "Bootstrapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SamplingMethod"></see>
    /// </summary>
    let SamplingMethod =
        Namespaced_IRI.parse _namespace_name "SamplingMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#BrainMachineInterfaces"></see>
    /// </summary>
    let BrainMachineInterfaces =
        Namespaced_IRI.parse _namespace_name "BrainMachineInterfaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Cheminformatics"></see>
    /// </summary>
    let Cheminformatics =
        Namespaced_IRI.parse _namespace_name "Cheminformatics" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ClassifyingDNAsequences"></see>
    /// </summary>
    let ClassifyingDNAsequences =
        Namespaced_IRI.parse _namespace_name "ClassifyingDNAsequences" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ComputationalAdversiting"></see>
    /// </summary>
    let ComputationalAdversiting =
        Namespaced_IRI.parse _namespace_name "ComputationalAdversiting" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ComputationalFinance"></see>
    /// </summary>
    let ComputationalFinance =
        Namespaced_IRI.parse _namespace_name "ComputationalFinance" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ComputerVision"></see>
    /// </summary>
    let ComputerVision =
        Namespaced_IRI.parse _namespace_name "ComputerVision" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#CrossValidation"></see>
    /// </summary>
    let CrossValidation =
        Namespaced_IRI.parse _namespace_name "CrossValidation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Dataset"></see>
    /// </summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#DetectingCreditCardFrauds"></see>
    /// </summary>
    let DetectingCreditCardFrauds =
        Namespaced_IRI.parse _namespace_name "DetectingCreditCardFrauds" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ValuePartition"></see>
    /// </summary>
    let ValuePartition =
        Namespaced_IRI.parse _namespace_name "ValuePartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Example"></see>
    /// </summary>
    let Example = Namespaced_IRI.parse _namespace_name "Example" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ExampleCollection"></see>
    /// </summary>
    let ExampleCollection =
        Namespaced_IRI.parse _namespace_name "ExampleCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Execution"></see>
    /// </summary>
    let Execution = Namespaced_IRI.parse _namespace_name "Execution" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ExecutionOverall"></see>
    /// </summary>
    let ExecutionOverall =
        Namespaced_IRI.parse _namespace_name "ExecutionOverall" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ExecutionSingle"></see>
    /// </summary>
    let ExecutionSingle =
        Namespaced_IRI.parse _namespace_name "ExecutionSingle" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Experiment"></see>
    /// </summary>
    let Experiment = Namespaced_IRI.parse _namespace_name "Experiment" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ExperimentConfiguration"></see>
    /// </summary>
    let ExperimentConfiguration =
        Namespaced_IRI.parse _namespace_name "ExperimentConfiguration" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#FactPrediction"></see>
    /// </summary>
    let FactPrediction =
        Namespaced_IRI.parse _namespace_name "FactPrediction" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Feature"></see>
    /// </summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#FeatureCollection"></see>
    /// </summary>
    let FeatureCollection =
        Namespaced_IRI.parse _namespace_name "FeatureCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#GamePlaying"></see>
    /// </summary>
    let GamePlaying =
        Namespaced_IRI.parse _namespace_name "GamePlaying" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#HardwareConfiguration"></see>
    /// </summary>
    let HardwareConfiguration =
        Namespaced_IRI.parse _namespace_name "HardwareConfiguration" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Holdout"></see>
    /// </summary>
    let Holdout = Namespaced_IRI.parse _namespace_name "Holdout" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#InformationRetrieval"></see>
    /// </summary>
    let InformationRetrieval =
        Namespaced_IRI.parse _namespace_name "InformationRetrieval" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#InternetFraudDetection"></see>
    /// </summary>
    let InternetFraudDetection =
        Namespaced_IRI.parse _namespace_name "InternetFraudDetection" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#LeaveOneOut"></see>
    /// </summary>
    let LeaveOneOut =
        Namespaced_IRI.parse _namespace_name "LeaveOneOut" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#LinkDiscovery"></see>
    /// </summary>
    let LinkDiscovery =
        Namespaced_IRI.parse _namespace_name "LinkDiscovery" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#MachinePerception"></see>
    /// </summary>
    let MachinePerception =
        Namespaced_IRI.parse _namespace_name "MachinePerception" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#MedicalDiagnosis"></see>
    /// </summary>
    let MedicalDiagnosis =
        Namespaced_IRI.parse _namespace_name "MedicalDiagnosis" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Metaheuristics"></see>
    /// </summary>
    let Metaheuristics =
        Namespaced_IRI.parse _namespace_name "Metaheuristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Model"></see>
    /// </summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#NFoldsCrossValidation"></see>
    /// </summary>
    let NFoldsCrossValidation =
        Namespaced_IRI.parse _namespace_name "NFoldsCrossValidation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#NaturalLanguageProcessing"></see>
    /// </summary>
    let NaturalLanguageProcessing =
        Namespaced_IRI.parse _namespace_name "NaturalLanguageProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#ObjectRecognition"></see>
    /// </summary>
    let ObjectRecognition =
        Namespaced_IRI.parse _namespace_name "ObjectRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Optimization"></see>
    /// </summary>
    let Optimization =
        Namespaced_IRI.parse _namespace_name "Optimization" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Phase"></see>
    /// </summary>
    let Phase = Namespaced_IRI.parse _namespace_name "Phase" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#RecomenderSystems"></see>
    /// </summary>
    let RecomenderSystems =
        Namespaced_IRI.parse _namespace_name "RecomenderSystems" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#Robotics"></see>
    /// </summary>
    let Robotics = Namespaced_IRI.parse _namespace_name "Robotics" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SearchEngines"></see>
    /// </summary>
    let SearchEngines =
        Namespaced_IRI.parse _namespace_name "SearchEngines" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SentimentAnalysis"></see>
    /// </summary>
    let SentimentAnalysis =
        Namespaced_IRI.parse _namespace_name "SentimentAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SequenceMining"></see>
    /// </summary>
    let SequenceMining =
        Namespaced_IRI.parse _namespace_name "SequenceMining" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SlidingCrossValidation"></see>
    /// </summary>
    let SlidingCrossValidation =
        Namespaced_IRI.parse _namespace_name "SlidingCrossValidation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SoftwareEngineering"></see>
    /// </summary>
    let SoftwareEngineering =
        Namespaced_IRI.parse _namespace_name "SoftwareEngineering" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SpeechAndHandwritingRecognition"></see>
    /// </summary>
    let SpeechAndHandwritingRecognition =
        Namespaced_IRI.parse _namespace_name "SpeechAndHandwritingRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#StockMarketAnalysis"></see>
    /// </summary>
    let StockMarketAnalysis =
        Namespaced_IRI.parse _namespace_name "StockMarketAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#StructuralHealthMonitoring"></see>
    /// </summary>
    let StructuralHealthMonitoring =
        Namespaced_IRI.parse _namespace_name "StructuralHealthMonitoring" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#SyntacticLanguageProcessing"></see>
    /// </summary>
    let SyntacticLanguageProcessing =
        Namespaced_IRI.parse _namespace_name "SyntacticLanguageProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#attributeSelectionDescription"></see>
    /// </summary>
    let attributeSelectionDescription =
        Namespaced_IRI.parse _namespace_name "attributeSelectionDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#cpu"></see>
    /// </summary>
    let cpu = Namespaced_IRI.parse _namespace_name "cpu" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#cpuCache"></see>
    /// </summary>
    let cpuCache = Namespaced_IRI.parse _namespace_name "cpuCache" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#dataNormalizedDescription"></see>
    /// </summary>
    let dataNormalizedDescription =
        Namespaced_IRI.parse _namespace_name "dataNormalizedDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#datasetColumn"></see>
    /// </summary>
    let datasetColumn =
        Namespaced_IRI.parse _namespace_name "datasetColumn" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#datasetRow"></see>
    /// </summary>
    let datasetRow = Namespaced_IRI.parse _namespace_name "datasetRow" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#endsAt"></see>
    /// </summary>
    let endsAt = Namespaced_IRI.parse _namespace_name "endsAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#endsAtPosition"></see>
    /// </summary>
    let endsAtPosition =
        Namespaced_IRI.parse _namespace_name "endsAtPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#folds"></see>
    /// </summary>
    let folds = Namespaced_IRI.parse _namespace_name "folds" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#hasApplicationContext"></see>
    /// </summary>
    let hasApplicationContext =
        Namespaced_IRI.parse _namespace_name "hasApplicationContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#hasPhase"></see>
    /// </summary>
    let hasPhase = Namespaced_IRI.parse _namespace_name "hasPhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#hasSamplingMethod"></see>
    /// </summary>
    let hasSamplingMethod =
        Namespaced_IRI.parse _namespace_name "hasSamplingMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#hdType"></see>
    /// </summary>
    let hdType = Namespaced_IRI.parse _namespace_name "hdType" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#memory"></see>
    /// </summary>
    let memory = Namespaced_IRI.parse _namespace_name "memory" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#noiseRemovedDescription"></see>
    /// </summary>
    let noiseRemovedDescription =
        Namespaced_IRI.parse _namespace_name "noiseRemovedDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#numberOfIteraction"></see>
    /// </summary>
    let numberOfIteraction =
        Namespaced_IRI.parse _namespace_name "numberOfIteraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#outliersRemovedDescription"></see>
    /// </summary>
    let outliersRemovedDescription =
        Namespaced_IRI.parse _namespace_name "outliersRemovedDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#sequential"></see>
    /// </summary>
    let sequential = Namespaced_IRI.parse _namespace_name "sequential" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#startsAt"></see>
    /// </summary>
    let startsAt = Namespaced_IRI.parse _namespace_name "startsAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#startsAtPosition"></see>
    /// </summary>
    let startsAtPosition =
        Namespaced_IRI.parse _namespace_name "startsAtPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#targetClass"></see>
    /// </summary>
    let targetClass =
        Namespaced_IRI.parse _namespace_name "targetClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#testSize"></see>
    /// </summary>
    let testSize = Namespaced_IRI.parse _namespace_name "testSize" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#trainSize"></see>
    /// </summary>
    let trainSize = Namespaced_IRI.parse _namespace_name "trainSize" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#trustyURI"></see>
    /// </summary>
    let trustyURI = Namespaced_IRI.parse _namespace_name "trustyURI" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#trustyURIHash"></see>
    /// </summary>
    let trustyURIHash =
        Namespaced_IRI.parse _namespace_name "trustyURIHash" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-core#videoGraphs"></see>
    /// </summary>
    let videoGraphs =
        Namespaced_IRI.parse _namespace_name "videoGraphs" |> NamespacedName
