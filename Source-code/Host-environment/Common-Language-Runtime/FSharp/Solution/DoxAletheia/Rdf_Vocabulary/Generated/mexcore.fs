namespace http.mex.aksw.org.mex_core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mexcore =
    let _namespace_iri = Namespace_Iri mexcore |> NamespaceIRI

    /// <summary>
    ///   <para>mexcore:AdaptativeWebSites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#AdaptativeWebSites">http://mex.aksw.org/mex-core#AdaptativeWebSites</seealso>
    let AdaptativeWebSites =
        Prefixed_Name(mexcore, "AdaptativeWebSites") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:AffectiveComputing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#AffectiveComputing">http://mex.aksw.org/mex-core#AffectiveComputing</seealso>
    let AffectiveComputing =
        Prefixed_Name(mexcore, "AffectiveComputing") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:ApplicationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"describes the context of the experiment, such as NLP, Stock Market Forecast, BioInformatics, Text-Retrieval AND contact informations/publication"</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ApplicationContext">http://mex.aksw.org/mex-core#ApplicationContext</seealso>
    let ApplicationContext =
        Prefixed_Name(mexcore, "ApplicationContext") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:Bioinformatics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Bioinformatics">http://mex.aksw.org/mex-core#Bioinformatics</seealso>
    let Bioinformatics = Prefixed_Name(mexcore, "Bioinformatics") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Bootstrapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Bootstrapping">http://mex.aksw.org/mex-core#Bootstrapping</seealso>
    let Bootstrapping = Prefixed_Name(mexcore, "Bootstrapping") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:BrainMachineInterfaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#BrainMachineInterfaces">http://mex.aksw.org/mex-core#BrainMachineInterfaces</seealso>
    let BrainMachineInterfaces =
        Prefixed_Name(mexcore, "BrainMachineInterfaces") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:Cheminformatics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Cheminformatics">http://mex.aksw.org/mex-core#Cheminformatics</seealso>
    let Cheminformatics = Prefixed_Name(mexcore, "Cheminformatics") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:ClassifyingDNAsequences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ClassifyingDNAsequences">http://mex.aksw.org/mex-core#ClassifyingDNAsequences</seealso>
    let ClassifyingDNAsequences =
        Prefixed_Name(mexcore, "ClassifyingDNAsequences") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:ComputationalAdversiting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ComputationalAdversiting">http://mex.aksw.org/mex-core#ComputationalAdversiting</seealso>
    let ComputationalAdversiting =
        Prefixed_Name(mexcore, "ComputationalAdversiting") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:ComputationalFinance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ComputationalFinance">http://mex.aksw.org/mex-core#ComputationalFinance</seealso>
    let ComputationalFinance =
        Prefixed_Name(mexcore, "ComputationalFinance") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:ComputerVision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ComputerVision">http://mex.aksw.org/mex-core#ComputerVision</seealso>
    let ComputerVision = Prefixed_Name(mexcore, "ComputerVision") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Context">http://mex.aksw.org/mex-core#Context</seealso>
    let Context = Prefixed_Name(mexcore, "Context") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:CrossValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#CrossValidation">http://mex.aksw.org/mex-core#CrossValidation</seealso>
    let CrossValidation = Prefixed_Name(mexcore, "CrossValidation") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Dataset">http://mex.aksw.org/mex-core#Dataset</seealso>
    let Dataset = Prefixed_Name(mexcore, "Dataset") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:DetectingCreditCardFrauds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#DetectingCreditCardFrauds">http://mex.aksw.org/mex-core#DetectingCreditCardFrauds</seealso>
    let DetectingCreditCardFrauds =
        Prefixed_Name(mexcore, "DetectingCreditCardFrauds") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:DomainConceptSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#DomainConceptSpace">http://mex.aksw.org/mex-core#DomainConceptSpace</seealso>
    let DomainConceptSpace =
        Prefixed_Name(mexcore, "DomainConceptSpace") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:Example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Example">http://mex.aksw.org/mex-core#Example</seealso>
    let Example = Prefixed_Name(mexcore, "Example") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:ExampleCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ExampleCollection">http://mex.aksw.org/mex-core#ExampleCollection</seealso>
    let ExampleCollection = Prefixed_Name(mexcore, "ExampleCollection") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Execution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Execution">http://mex.aksw.org/mex-core#Execution</seealso>
    let Execution = Prefixed_Name(mexcore, "Execution") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:ExecutionOverall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ExecutionOverall">http://mex.aksw.org/mex-core#ExecutionOverall</seealso>
    let ExecutionOverall = Prefixed_Name(mexcore, "ExecutionOverall") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:ExecutionSingle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ExecutionSingle">http://mex.aksw.org/mex-core#ExecutionSingle</seealso>
    let ExecutionSingle = Prefixed_Name(mexcore, "ExecutionSingle") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Experiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Experiment">http://mex.aksw.org/mex-core#Experiment</seealso>
    let Experiment = Prefixed_Name(mexcore, "Experiment") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:ExperimentConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ExperimentConfiguration">http://mex.aksw.org/mex-core#ExperimentConfiguration</seealso>
    let ExperimentConfiguration =
        Prefixed_Name(mexcore, "ExperimentConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:FactPrediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#FactPrediction">http://mex.aksw.org/mex-core#FactPrediction</seealso>
    let FactPrediction = Prefixed_Name(mexcore, "FactPrediction") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Feature">http://mex.aksw.org/mex-core#Feature</seealso>
    let Feature = Prefixed_Name(mexcore, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:FeatureCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#FeatureCollection">http://mex.aksw.org/mex-core#FeatureCollection</seealso>
    let FeatureCollection = Prefixed_Name(mexcore, "FeatureCollection") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:GamePlaying</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#GamePlaying">http://mex.aksw.org/mex-core#GamePlaying</seealso>
    let GamePlaying = Prefixed_Name(mexcore, "GamePlaying") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:HardwareConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#HardwareConfiguration">http://mex.aksw.org/mex-core#HardwareConfiguration</seealso>
    let HardwareConfiguration =
        Prefixed_Name(mexcore, "HardwareConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:Holdout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Holdout">http://mex.aksw.org/mex-core#Holdout</seealso>
    let Holdout = Prefixed_Name(mexcore, "Holdout") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:InformationRetrieval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#InformationRetrieval">http://mex.aksw.org/mex-core#InformationRetrieval</seealso>
    let InformationRetrieval =
        Prefixed_Name(mexcore, "InformationRetrieval") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:InternetFraudDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#InternetFraudDetection">http://mex.aksw.org/mex-core#InternetFraudDetection</seealso>
    let InternetFraudDetection =
        Prefixed_Name(mexcore, "InternetFraudDetection") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:LeaveOneOut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#LeaveOneOut">http://mex.aksw.org/mex-core#LeaveOneOut</seealso>
    let LeaveOneOut = Prefixed_Name(mexcore, "LeaveOneOut") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:LinkDiscovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#LinkDiscovery">http://mex.aksw.org/mex-core#LinkDiscovery</seealso>
    let LinkDiscovery = Prefixed_Name(mexcore, "LinkDiscovery") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:MachinePerception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#MachinePerception">http://mex.aksw.org/mex-core#MachinePerception</seealso>
    let MachinePerception = Prefixed_Name(mexcore, "MachinePerception") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:MedicalDiagnosis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#MedicalDiagnosis">http://mex.aksw.org/mex-core#MedicalDiagnosis</seealso>
    let MedicalDiagnosis = Prefixed_Name(mexcore, "MedicalDiagnosis") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Metaheuristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Metaheuristics">http://mex.aksw.org/mex-core#Metaheuristics</seealso>
    let Metaheuristics = Prefixed_Name(mexcore, "Metaheuristics") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Model">http://mex.aksw.org/mex-core#Model</seealso>
    let Model = Prefixed_Name(mexcore, "Model") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:NFoldsCrossValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#NFoldsCrossValidation">http://mex.aksw.org/mex-core#NFoldsCrossValidation</seealso>
    let NFoldsCrossValidation =
        Prefixed_Name(mexcore, "NFoldsCrossValidation") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:NaturalLanguageProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#NaturalLanguageProcessing">http://mex.aksw.org/mex-core#NaturalLanguageProcessing</seealso>
    let NaturalLanguageProcessing =
        Prefixed_Name(mexcore, "NaturalLanguageProcessing") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:ObjectRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ObjectRecognition">http://mex.aksw.org/mex-core#ObjectRecognition</seealso>
    let ObjectRecognition = Prefixed_Name(mexcore, "ObjectRecognition") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Optimization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Optimization">http://mex.aksw.org/mex-core#Optimization</seealso>
    let Optimization = Prefixed_Name(mexcore, "Optimization") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Phase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Phase">http://mex.aksw.org/mex-core#Phase</seealso>
    let Phase = Prefixed_Name(mexcore, "Phase") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:RecomenderSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#RecomenderSystems">http://mex.aksw.org/mex-core#RecomenderSystems</seealso>
    let RecomenderSystems = Prefixed_Name(mexcore, "RecomenderSystems") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Robotics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Robotics">http://mex.aksw.org/mex-core#Robotics</seealso>
    let Robotics = Prefixed_Name(mexcore, "Robotics") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:SamplingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#SamplingMethod">http://mex.aksw.org/mex-core#SamplingMethod</seealso>
    let SamplingMethod = Prefixed_Name(mexcore, "SamplingMethod") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:SearchEngines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#SearchEngines">http://mex.aksw.org/mex-core#SearchEngines</seealso>
    let SearchEngines = Prefixed_Name(mexcore, "SearchEngines") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:SentimentAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#SentimentAnalysis">http://mex.aksw.org/mex-core#SentimentAnalysis</seealso>
    let SentimentAnalysis = Prefixed_Name(mexcore, "SentimentAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:SequenceMining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#SequenceMining">http://mex.aksw.org/mex-core#SequenceMining</seealso>
    let SequenceMining = Prefixed_Name(mexcore, "SequenceMining") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:SlidingCrossValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#SlidingCrossValidation">http://mex.aksw.org/mex-core#SlidingCrossValidation</seealso>
    let SlidingCrossValidation =
        Prefixed_Name(mexcore, "SlidingCrossValidation") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:SoftwareEngineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#SoftwareEngineering">http://mex.aksw.org/mex-core#SoftwareEngineering</seealso>
    let SoftwareEngineering =
        Prefixed_Name(mexcore, "SoftwareEngineering") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:SpeechAndHandwritingRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#SpeechAndHandwritingRecognition">http://mex.aksw.org/mex-core#SpeechAndHandwritingRecognition</seealso>
    let SpeechAndHandwritingRecognition =
        Prefixed_Name(mexcore, "SpeechAndHandwritingRecognition") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:StockMarketAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#StockMarketAnalysis">http://mex.aksw.org/mex-core#StockMarketAnalysis</seealso>
    let StockMarketAnalysis =
        Prefixed_Name(mexcore, "StockMarketAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:StructuralHealthMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#StructuralHealthMonitoring">http://mex.aksw.org/mex-core#StructuralHealthMonitoring</seealso>
    let StructuralHealthMonitoring =
        Prefixed_Name(mexcore, "StructuralHealthMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:SyntacticLanguageProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#SyntacticLanguageProcessing">http://mex.aksw.org/mex-core#SyntacticLanguageProcessing</seealso>
    let SyntacticLanguageProcessing =
        Prefixed_Name(mexcore, "SyntacticLanguageProcessing") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:Test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Test">http://mex.aksw.org/mex-core#Test</seealso>
    let Test = Prefixed_Name(mexcore, "Test") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Training</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Training">http://mex.aksw.org/mex-core#Training</seealso>
    let Training = Prefixed_Name(mexcore, "Training") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:Validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#Validation">http://mex.aksw.org/mex-core#Validation</seealso>
    let Validation = Prefixed_Name(mexcore, "Validation") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:ValuePartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#ValuePartition">http://mex.aksw.org/mex-core#ValuePartition</seealso>
    let ValuePartition = Prefixed_Name(mexcore, "ValuePartition") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:attributeSelectionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#attributeSelectionDescription">http://mex.aksw.org/mex-core#attributeSelectionDescription</seealso>
    let attributeSelectionDescription =
        Prefixed_Name(mexcore, "attributeSelectionDescription") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:cpu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#cpu">http://mex.aksw.org/mex-core#cpu</seealso>
    let cpu = Prefixed_Name(mexcore, "cpu") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:cpuCache</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#cpuCache">http://mex.aksw.org/mex-core#cpuCache</seealso>
    let cpuCache = Prefixed_Name(mexcore, "cpuCache") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:dataNormalizedDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#dataNormalizedDescription">http://mex.aksw.org/mex-core#dataNormalizedDescription</seealso>
    let dataNormalizedDescription =
        Prefixed_Name(mexcore, "dataNormalizedDescription") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:datasetColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#datasetColumn">http://mex.aksw.org/mex-core#datasetColumn</seealso>
    let datasetColumn = Prefixed_Name(mexcore, "datasetColumn") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:datasetRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#datasetRow">http://mex.aksw.org/mex-core#datasetRow</seealso>
    let datasetRow = Prefixed_Name(mexcore, "datasetRow") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:endsAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#endsAt">http://mex.aksw.org/mex-core#endsAt</seealso>
    let endsAt = Prefixed_Name(mexcore, "endsAt") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:endsAtPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#endsAtPosition">http://mex.aksw.org/mex-core#endsAtPosition</seealso>
    let endsAtPosition = Prefixed_Name(mexcore, "endsAtPosition") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:folds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#folds">http://mex.aksw.org/mex-core#folds</seealso>
    let folds = Prefixed_Name(mexcore, "folds") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:hasApplicationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#hasApplicationContext">http://mex.aksw.org/mex-core#hasApplicationContext</seealso>
    let hasApplicationContext =
        Prefixed_Name(mexcore, "hasApplicationContext") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:hasPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#hasPhase">http://mex.aksw.org/mex-core#hasPhase</seealso>
    let hasPhase = Prefixed_Name(mexcore, "hasPhase") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:hasSamplingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#hasSamplingMethod">http://mex.aksw.org/mex-core#hasSamplingMethod</seealso>
    let hasSamplingMethod = Prefixed_Name(mexcore, "hasSamplingMethod") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:hdType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#hdType">http://mex.aksw.org/mex-core#hdType</seealso>
    let hdType = Prefixed_Name(mexcore, "hdType") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:memory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#memory">http://mex.aksw.org/mex-core#memory</seealso>
    let memory = Prefixed_Name(mexcore, "memory") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:noiseRemovedDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#noiseRemovedDescription">http://mex.aksw.org/mex-core#noiseRemovedDescription</seealso>
    let noiseRemovedDescription =
        Prefixed_Name(mexcore, "noiseRemovedDescription") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:numberOfIteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#numberOfIteraction">http://mex.aksw.org/mex-core#numberOfIteraction</seealso>
    let numberOfIteraction =
        Prefixed_Name(mexcore, "numberOfIteraction") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:outliersRemovedDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#outliersRemovedDescription">http://mex.aksw.org/mex-core#outliersRemovedDescription</seealso>
    let outliersRemovedDescription =
        Prefixed_Name(mexcore, "outliersRemovedDescription") |> PrefixedName

    /// <summary>
    ///   <para>mexcore:sequential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#sequential">http://mex.aksw.org/mex-core#sequential</seealso>
    let sequential = Prefixed_Name(mexcore, "sequential") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:startsAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#startsAt">http://mex.aksw.org/mex-core#startsAt</seealso>
    let startsAt = Prefixed_Name(mexcore, "startsAt") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:startsAtPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#startsAtPosition">http://mex.aksw.org/mex-core#startsAtPosition</seealso>
    let startsAtPosition = Prefixed_Name(mexcore, "startsAtPosition") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:targetClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#targetClass">http://mex.aksw.org/mex-core#targetClass</seealso>
    let targetClass = Prefixed_Name(mexcore, "targetClass") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:testSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#testSize">http://mex.aksw.org/mex-core#testSize</seealso>
    let testSize = Prefixed_Name(mexcore, "testSize") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:trainSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#trainSize">http://mex.aksw.org/mex-core#trainSize</seealso>
    let trainSize = Prefixed_Name(mexcore, "trainSize") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:trustyURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#trustyURI">http://mex.aksw.org/mex-core#trustyURI</seealso>
    let trustyURI = Prefixed_Name(mexcore, "trustyURI") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:trustyURIHash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#trustyURIHash">http://mex.aksw.org/mex-core#trustyURIHash</seealso>
    let trustyURIHash = Prefixed_Name(mexcore, "trustyURIHash") |> PrefixedName
    /// <summary>
    ///   <para>mexcore:videoGraphs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-core#videoGraphs">http://mex.aksw.org/mex-core#videoGraphs</seealso>
    let videoGraphs = Prefixed_Name(mexcore, "videoGraphs") |> PrefixedName
