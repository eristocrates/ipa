#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lswpm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#" "lswpm"

    let ANN = _prefixId.prefix "ANN"
    let ATT_MAXENT = _prefixId.prefix "ATT_MAXENT"

    /// <summary>
    ///   <para>rdfs:label : artificial neuronal network parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Artificial-Neural-Network_parameters">lswpm:Artificial-Neural-Network_parameters</a>
    /// </summary>
    let Artificial_Neural_Network_parameters =
        _prefixId.prefix "Artificial-Neural-Network_parameters"

    /// <summary>
    ///   <para>rdfs:label : auto features^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#AutoFeatures">lswpm:AutoFeatures</a>
    /// </summary>
    let AutoFeatures = _prefixId.prefix "AutoFeatures"
    let BIOCLIM = _prefixId.prefix "BIOCLIM"
    /// <summary>
    ///   <para>rdfs:label : bioclim parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Bioclim_parameters">lswpm:Bioclim_parameters</a>
    /// </summary>
    let Bioclim_parameters = _prefixId.prefix "Bioclim_parameters"
    /// <summary>
    ///   <para>rdfs:label : c^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#C">lswpm:C</a>
    /// </summary>
    let C = _prefixId.prefix "C"
    let CSMBS = _prefixId.prefix "CSMBS"
    /// <summary>
    ///   <para>rdfs:label : choice^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Choice">lswpm:Choice</a>
    /// </summary>
    let Choice = _prefixId.prefix "Choice"

    /// <summary>
    ///   <para>rdfs:label : climate space model parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Climate-Space-Model_parameters">lswpm:Climate-Space-Model_parameters</a>
    /// </summary>
    let Climate_Space_Model_parameters =
        _prefixId.prefix "Climate-Space-Model_parameters"

    /// <summary>
    ///   <para>rdfs:label : coef0^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Coef0">lswpm:Coef0</a>
    /// </summary>
    let Coef0 = _prefixId.prefix "Coef0"
    /// <summary>
    ///   <para>rdfs:label : comission sample size^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#CommissionSampleSize">lswpm:CommissionSampleSize</a>
    /// </summary>
    let CommissionSampleSize = _prefixId.prefix "CommissionSampleSize"
    /// <summary>
    ///   <para>rdfs:label : comission threshold^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#CommissionThreshold">lswpm:CommissionThreshold</a>
    /// </summary>
    let CommissionThreshold = _prefixId.prefix "CommissionThreshold"
    /// <summary>
    ///   <para>rdfs:label : convergence limit^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#ConvergenceLimit">lswpm:ConvergenceLimit</a>
    /// </summary>
    let ConvergenceLimit = _prefixId.prefix "ConvergenceLimit"
    let DG_GARP = _prefixId.prefix "DG_GARP"
    let DG_GARP_BS = _prefixId.prefix "DG_GARP_BS"
    /// <summary>
    ///   <para>rdfs:label : degree^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Degree">lswpm:Degree</a>
    /// </summary>
    let Degree = _prefixId.prefix "Degree"
    /// <summary>
    ///   <para>rdfs:label : distance type^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#DistanceType">lswpm:DistanceType</a>
    /// </summary>
    let DistanceType = _prefixId.prefix "DistanceType"
    let ENVDIST = _prefixId.prefix "ENVDIST"

    /// <summary>
    ///   <para>rdfs:label : environmental distance parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Environmental-Distance_parameters">lswpm:Environmental-Distance_parameters</a>
    /// </summary>
    let Environmental_Distance_parameters =
        _prefixId.prefix "Environmental-Distance_parameters"

    /// <summary>
    ///   <para>rdfs:label : epoch^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Epoch">lswpm:Epoch</a>
    /// </summary>
    let Epoch = _prefixId.prefix "Epoch"
    let GARP = _prefixId.prefix "GARP"

    /// <summary>
    ///   <para>rdfs:label : garp desktop garp implementation parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#GARP---DesktopGARP-implementation_parameters">lswpm:GARP---DesktopGARP-implementation_parameters</a>
    /// </summary>
    let GARP___DesktopGARP_implementation_parameters =
        _prefixId.prefix "GARP---DesktopGARP-implementation_parameters"

    /// <summary>
    ///   <para>rdfs:label : garp with best subsets desktop garp implementation parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#GARP-with-Best-Subsets---DesktopGARP-implementation_parameters">lswpm:GARP-with-Best-Subsets---DesktopGARP-implementation_parameters</a>
    /// </summary>
    let GARP_with_Best_Subsets___DesktopGARP_implementation_parameters =
        _prefixId.prefix "GARP-with-Best-Subsets---DesktopGARP-implementation_parameters"

    /// <summary>
    ///   <para>rdfs:label : garp with best subsets parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#GARP-with-Best-Subsets_parameters">lswpm:GARP-with-Best-Subsets_parameters</a>
    /// </summary>
    let GARP_with_Best_Subsets_parameters =
        _prefixId.prefix "GARP-with-Best-Subsets_parameters"

    let GARP_BS = _prefixId.prefix "GARP_BS"
    /// <summary>
    ///   <para>rdfs:label : garp parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#GARP_parameters">lswpm:GARP_parameters</a>
    /// </summary>
    let GARP_parameters = _prefixId.prefix "GARP_parameters"
    /// <summary>
    ///   <para>rdfs:label : gamma^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Gamma">lswpm:Gamma</a>
    /// </summary>
    let Gamma = _prefixId.prefix "Gamma"
    /// <summary>
    ///   <para>rdfs:label : hard omission threshold^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#HardOmissionThreshold">lswpm:HardOmissionThreshold</a>
    /// </summary>
    let HardOmissionThreshold = _prefixId.prefix "HardOmissionThreshold"
    /// <summary>
    ///   <para>rdfs:label : hidden layer neurons^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#HiddenLayerNeurons">lswpm:HiddenLayerNeurons</a>
    /// </summary>
    let HiddenLayerNeurons = _prefixId.prefix "HiddenLayerNeurons"
    /// <summary>
    ///   <para>rdfs:label : hinge features^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#HingeFeatures">lswpm:HingeFeatures</a>
    /// </summary>
    let HingeFeatures = _prefixId.prefix "HingeFeatures"

    /// <summary>
    ///   <para>rdfs:label : include presence points in background^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#IncludePresencePointsInBackground">lswpm:IncludePresencePointsInBackground</a>
    /// </summary>
    let IncludePresencePointsInBackground =
        _prefixId.prefix "IncludePresencePointsInBackground"

    /// <summary>
    ///   <para>rdfs:label : kernel type^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#KernelType">lswpm:KernelType</a>
    /// </summary>
    let KernelType = _prefixId.prefix "KernelType"
    /// <summary>
    ///   <para>rdfs:label : learning rate^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#LearningRate">lswpm:LearningRate</a>
    /// </summary>
    let LearningRate = _prefixId.prefix "LearningRate"
    /// <summary>
    ///   <para>rdfs:label : max distance^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#MaxDistance">lswpm:MaxDistance</a>
    /// </summary>
    let MaxDistance = _prefixId.prefix "MaxDistance"
    /// <summary>
    ///   <para>rdfs:label : max generations^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#MaxGenerations">lswpm:MaxGenerations</a>
    /// </summary>
    let MaxGenerations = _prefixId.prefix "MaxGenerations"
    /// <summary>
    ///   <para>rdfs:label : max threads^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#MaxThreads">lswpm:MaxThreads</a>
    /// </summary>
    let MaxThreads = _prefixId.prefix "MaxThreads"

    /// <summary>
    ///   <para>rdfs:label : maximum entropy att implementation parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Maximum-Entropy---ATT-Implementation_parameters">lswpm:Maximum-Entropy---ATT-Implementation_parameters</a>
    /// </summary>
    let Maximum_Entropy___ATT_Implementation_parameters =
        _prefixId.prefix "Maximum-Entropy---ATT-Implementation_parameters"

    /// <summary>
    ///   <para>rdfs:label : maximum entropy openmodeller implementation parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Maximum-Entropy---openModeller-Implementation_parameters">lswpm:Maximum-Entropy---openModeller-Implementation_parameters</a>
    /// </summary>
    let Maximum_Entropy___openModeller_Implementation_parameters =
        _prefixId.prefix "Maximum-Entropy---openModeller-Implementation_parameters"

    /// <summary>
    ///   <para>rdfs:label : min components^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#MinComponents">lswpm:MinComponents</a>
    /// </summary>
    let MinComponents = _prefixId.prefix "MinComponents"
    /// <summary>
    ///   <para>rdfs:label : min samples for hinge^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#MinSamplesForHinge">lswpm:MinSamplesForHinge</a>
    /// </summary>
    let MinSamplesForHinge = _prefixId.prefix "MinSamplesForHinge"
    /// <summary>
    ///   <para>rdfs:label : min samples for product threshold^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#MinSamplesForProductThreshold">lswpm:MinSamplesForProductThreshold</a>
    /// </summary>
    let MinSamplesForProductThreshold = _prefixId.prefix "MinSamplesForProductThreshold"
    /// <summary>
    ///   <para>rdfs:label : min samples for quadratic^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#MinSamplesForQuadratic">lswpm:MinSamplesForQuadratic</a>
    /// </summary>
    let MinSamplesForQuadratic = _prefixId.prefix "MinSamplesForQuadratic"
    /// <summary>
    ///   <para>rdfs:label : minimum error^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#MinimumError">lswpm:MinimumError</a>
    /// </summary>
    let MinimumError = _prefixId.prefix "MinimumError"
    /// <summary>
    ///   <para>rdfs:label : models under omission threshold^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#ModelsUnderOmissionThreshold">lswpm:ModelsUnderOmissionThreshold</a>
    /// </summary>
    let ModelsUnderOmissionThreshold = _prefixId.prefix "ModelsUnderOmissionThreshold"
    /// <summary>
    ///   <para>rdfs:label : momentum^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Momentum">lswpm:Momentum</a>
    /// </summary>
    let Momentum = _prefixId.prefix "Momentum"
    /// <summary>
    ///   <para>rdfs:label : nearest points^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#NearestPoints">lswpm:NearestPoints</a>
    /// </summary>
    let NearestPoints = _prefixId.prefix "NearestPoints"
    /// <summary>
    ///   <para>rdfs:label : nu^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Nu">lswpm:Nu</a>
    /// </summary>
    let Nu = _prefixId.prefix "Nu"
    /// <summary>
    ///   <para>rdfs:label : number of background points^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#NumberOfBackgroundPoints">lswpm:NumberOfBackgroundPoints</a>
    /// </summary>
    let NumberOfBackgroundPoints = _prefixId.prefix "NumberOfBackgroundPoints"
    /// <summary>
    ///   <para>rdfs:label : number of iterations^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#NumberOfIterations">lswpm:NumberOfIterations</a>
    /// </summary>
    let NumberOfIterations = _prefixId.prefix "NumberOfIterations"
    /// <summary>
    ///   <para>rdfs:label : number of pseudoabsences^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#NumberOfPseudoAbsences">lswpm:NumberOfPseudoAbsences</a>
    /// </summary>
    let NumberOfPseudoAbsences = _prefixId.prefix "NumberOfPseudoAbsences"
    let OM_MAXENT = _prefixId.prefix "OM_MAXENT"
    /// <summary>
    ///   <para>rdfs:label : output format^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#OutputFormat">lswpm:OutputFormat</a>
    /// </summary>
    let OutputFormat = _prefixId.prefix "OutputFormat"
    /// <summary>
    ///   <para>rdfs:label : population size^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#PopulationSize">lswpm:PopulationSize</a>
    /// </summary>
    let PopulationSize = _prefixId.prefix "PopulationSize"
    /// <summary>
    ///   <para>rdfs:label : probabilisic output^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#ProbabilisticOutput">lswpm:ProbabilisticOutput</a>
    /// </summary>
    let ProbabilisticOutput = _prefixId.prefix "ProbabilisticOutput"
    /// <summary>
    ///   <para>rdfs:label : product features^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#ProductFeatures">lswpm:ProductFeatures</a>
    /// </summary>
    let ProductFeatures = _prefixId.prefix "ProductFeatures"
    /// <summary>
    ///   <para>rdfs:label : quadratic features^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#QuadraticFeatures">lswpm:QuadraticFeatures</a>
    /// </summary>
    let QuadraticFeatures = _prefixId.prefix "QuadraticFeatures"
    /// <summary>
    ///   <para>rdfs:label : randomisations^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Randomisations">lswpm:Randomisations</a>
    /// </summary>
    let Randomisations = _prefixId.prefix "Randomisations"
    /// <summary>
    ///   <para>rdfs:label : resamples^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Resamples">lswpm:Resamples</a>
    /// </summary>
    let Resamples = _prefixId.prefix "Resamples"
    let SVM = _prefixId.prefix "SVM"
    /// <summary>
    ///   <para>rdfs:label : standard deviation cutoff^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#StandardDeviationCutoff">lswpm:StandardDeviationCutoff</a>
    /// </summary>
    let StandardDeviationCutoff = _prefixId.prefix "StandardDeviationCutoff"
    /// <summary>
    ///   <para>rdfs:label : standard deviations^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#StandardDeviations">lswpm:StandardDeviations</a>
    /// </summary>
    let StandardDeviations = _prefixId.prefix "StandardDeviations"

    /// <summary>
    ///   <para>rdfs:label : support vector machines parameters^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#Support-Vector-Machines_parameters">lswpm:Support-Vector-Machines_parameters</a>
    /// </summary>
    let Support_Vector_Machines_parameters =
        _prefixId.prefix "Support-Vector-Machines_parameters"

    /// <summary>
    ///   <para>rdfs:label : svm type^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#SvmType">lswpm:SvmType</a>
    /// </summary>
    let SvmType = _prefixId.prefix "SvmType"
    /// <summary>
    ///   <para>rdfs:label : terminate tolerance^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#TerminateTolerance">lswpm:TerminateTolerance</a>
    /// </summary>
    let TerminateTolerance = _prefixId.prefix "TerminateTolerance"
    /// <summary>
    ///   <para>rdfs:label : threshold features^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#ThresholdFeatures">lswpm:ThresholdFeatures</a>
    /// </summary>
    let ThresholdFeatures = _prefixId.prefix "ThresholdFeatures"
    /// <summary>
    ///   <para>rdfs:label : total runs^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#TotalRuns">lswpm:TotalRuns</a>
    /// </summary>
    let TotalRuns = _prefixId.prefix "TotalRuns"
    /// <summary>
    ///   <para>rdfs:label : training proportion^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#TrainingProportion">lswpm:TrainingProportion</a>
    /// </summary>
    let TrainingProportion = _prefixId.prefix "TrainingProportion"
    /// <summary>
    ///   <para>rdfs:label : use absences as background^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#UseAbsencesAsBackground">lswpm:UseAbsencesAsBackground</a>
    /// </summary>
    let UseAbsencesAsBackground = _prefixId.prefix "UseAbsencesAsBackground"
    /// <summary>
    ///   <para>rdfs:label : verbose debugging^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#VerboseDebugging">lswpm:VerboseDebugging</a>
    /// </summary>
    let VerboseDebugging = _prefixId.prefix "VerboseDebugging"
    /// <summary>
    ///   <para>rdfs:label : adjust sample radius^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#adjustsampleradius">lswpm:adjustsampleradius</a>
    /// </summary>
    let adjustsampleradius = _prefixId.prefix "adjustsampleradius"
    /// <summary>
    ///   <para>rdfs:label : append to results file^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#appendtoresultsfile">lswpm:appendtoresultsfile</a>
    /// </summary>
    let appendtoresultsfile = _prefixId.prefix "appendtoresultsfile"
    /// <summary>
    ///   <para>rdfs:label : autofeature^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#autofeature">lswpm:autofeature</a>
    /// </summary>
    let autofeature = _prefixId.prefix "autofeature"
    /// <summary>
    ///   <para>rdfs:label : beta categorical^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#beta_categorical">lswpm:beta_categorical</a>
    /// </summary>
    let beta_categorical = _prefixId.prefix "beta_categorical"
    /// <summary>
    ///   <para>rdfs:label : beta hinge^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#beta_hinge">lswpm:beta_hinge</a>
    /// </summary>
    let beta_hinge = _prefixId.prefix "beta_hinge"
    /// <summary>
    ///   <para>rdfs:label : beta lqp^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#beta_lqp">lswpm:beta_lqp</a>
    /// </summary>
    let beta_lqp = _prefixId.prefix "beta_lqp"
    /// <summary>
    ///   <para>rdfs:label : beta threshold^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#beta_threshold">lswpm:beta_threshold</a>
    /// </summary>
    let beta_threshold = _prefixId.prefix "beta_threshold"
    /// <summary>
    ///   <para>rdfs:label : beta multiplier^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#betamultiplier">lswpm:betamultiplier</a>
    /// </summary>
    let betamultiplier = _prefixId.prefix "betamultiplier"
    /// <summary>
    ///   <para>rdfs:label : convergence threshold^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#convergencethreshold">lswpm:convergencethreshold</a>
    /// </summary>
    let convergencethreshold = _prefixId.prefix "convergencethreshold"
    /// <summary>
    ///   <para>rdfs:label : default prevalence^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#defaultprevalence">lswpm:defaultprevalence</a>
    /// </summary>
    let defaultprevalence = _prefixId.prefix "defaultprevalence"
    /// <summary>
    ///   <para>rdfs:label : doclamp^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#doclamp">lswpm:doclamp</a>
    /// </summary>
    let doclamp = _prefixId.prefix "doclamp"
    /// <summary>
    ///   <para>rdfs:label : extra polate^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#extrapolate">lswpm:extrapolate</a>
    /// </summary>
    let extrapolate = _prefixId.prefix "extrapolate"
    /// <summary>
    ///   <para>rdfs:label : fade by clamping^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#fadebyclamping">lswpm:fadebyclamping</a>
    /// </summary>
    let fadebyclamping = _prefixId.prefix "fadebyclamping"
    /// <summary>
    ///   <para>rdfs:label : hinge^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#hinge">lswpm:hinge</a>
    /// </summary>
    let hinge = _prefixId.prefix "hinge"
    /// <summary>
    ///   <para>rdfs:label : hinge threshold^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#hingethreshold">lswpm:hingethreshold</a>
    /// </summary>
    let hingethreshold = _prefixId.prefix "hingethreshold"
    /// <summary>
    ///   <para>rdfs:label : jacknife^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#jackknife">lswpm:jackknife</a>
    /// </summary>
    let jackknife = _prefixId.prefix "jackknife"
    /// <summary>
    ///   <para>rdfs:label : l2lq threshold^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#l2lqthreshold">lswpm:l2lqthreshold</a>
    /// </summary>
    let l2lqthreshold = _prefixId.prefix "l2lqthreshold"
    /// <summary>
    ///   <para>rdfs:label : linear^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#linear">lswpm:linear</a>
    /// </summary>
    let linear = _prefixId.prefix "linear"
    /// <summary>
    ///   <para>rdfs:label : logscale^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#logscale">lswpm:logscale</a>
    /// </summary>
    let logscale = _prefixId.prefix "logscale"
    /// <summary>
    ///   <para>rdfs:label : lq2lqpt threshold^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#lq2lqptthreshold">lswpm:lq2lqptthreshold</a>
    /// </summary>
    let lq2lqptthreshold = _prefixId.prefix "lq2lqptthreshold"
    /// <summary>
    ///   <para>rdfs:label : maximum background^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#maximumbackground">lswpm:maximumbackground</a>
    /// </summary>
    let maximumbackground = _prefixId.prefix "maximumbackground"
    /// <summary>
    ///   <para>rdfs:label : maximum iterations^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#maximumiterations">lswpm:maximumiterations</a>
    /// </summary>
    let maximumiterations = _prefixId.prefix "maximumiterations"
    /// <summary>
    ///   <para>rdfs:label : output grids^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#outputgrids">lswpm:outputgrids</a>
    /// </summary>
    let outputgrids = _prefixId.prefix "outputgrids"
    /// <summary>
    ///   <para>rdfs:label : per species results^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#perspeciesresults">lswpm:perspeciesresults</a>
    /// </summary>
    let perspeciesresults = _prefixId.prefix "perspeciesresults"
    /// <summary>
    ///   <para>rdfs:label : pictures^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#pictures">lswpm:pictures</a>
    /// </summary>
    let pictures = _prefixId.prefix "pictures"
    /// <summary>
    ///   <para>rdfs:label : plots^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#plots">lswpm:plots</a>
    /// </summary>
    let plots = _prefixId.prefix "plots"
    /// <summary>
    ///   <para>rdfs:label : product^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#product">lswpm:product</a>
    /// </summary>
    let product = _prefixId.prefix "product"
    /// <summary>
    ///   <para>rdfs:label : quadratic^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#quadratic">lswpm:quadratic</a>
    /// </summary>
    let quadratic = _prefixId.prefix "quadratic"
    /// <summary>
    ///   <para>rdfs:label : random seed^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#randomseed">lswpm:randomseed</a>
    /// </summary>
    let randomseed = _prefixId.prefix "randomseed"
    /// <summary>
    ///   <para>rdfs:label : random test points^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#randomtestpoints">lswpm:randomtestpoints</a>
    /// </summary>
    let randomtestpoints = _prefixId.prefix "randomtestpoints"
    /// <summary>
    ///   <para>rdfs:label : remove duplicates^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#removeduplicates">lswpm:removeduplicates</a>
    /// </summary>
    let removeduplicates = _prefixId.prefix "removeduplicates"
    /// <summary>
    ///   <para>rdfs:label : replicates^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#replicates">lswpm:replicates</a>
    /// </summary>
    let replicates = _prefixId.prefix "replicates"
    /// <summary>
    ///   <para>rdfs:label : replicate type^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#replicatetype">lswpm:replicatetype</a>
    /// </summary>
    let replicatetype = _prefixId.prefix "replicatetype"
    /// <summary>
    ///   <para>rdfs:label : response curves^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#responsecurves">lswpm:responsecurves</a>
    /// </summary>
    let responsecurves = _prefixId.prefix "responsecurves"
    /// <summary>
    ///   <para>rdfs:label : response curves exponent^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#responsecurvesexponent">lswpm:responsecurvesexponent</a>
    /// </summary>
    let responsecurvesexponent = _prefixId.prefix "responsecurvesexponent"
    /// <summary>
    ///   <para>rdfs:label : threshold^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#threshold">lswpm:threshold</a>
    /// </summary>
    let threshold = _prefixId.prefix "threshold"
    /// <summary>
    ///   <para>rdfs:label : write background predictions^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#writebackgroundpredictions">lswpm:writebackgroundpredictions</a>
    /// </summary>
    let writebackgroundpredictions = _prefixId.prefix "writebackgroundpredictions"
    /// <summary>
    ///   <para>rdfs:label : write clamp grid^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#writeclampgrid">lswpm:writeclampgrid</a>
    /// </summary>
    let writeclampgrid = _prefixId.prefix "writeclampgrid"
    /// <summary>
    ///   <para>rdfs:label : write mess^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#writemess">lswpm:writemess</a>
    /// </summary>
    let writemess = _prefixId.prefix "writemess"
    /// <summary>
    ///   <para>rdfs:label : write plot data^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#writeplotdata">lswpm:writeplotdata</a>
    /// </summary>
    let writeplotdata = _prefixId.prefix "writeplotdata"
