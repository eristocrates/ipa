#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mexalgo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://mex.aksw.org/mex-algo#" "mexalgo"

    let ADTree = _prefixId.prefix "ADTree"
    let AODE = _prefixId.prefix "AODE"
    let AQ = _prefixId.prefix "AQ"
    let AdaBoost = _prefixId.prefix "AdaBoost"
    /// <summary>
    ///   <para>rdfs:label : AdaBoost</para>
    ///   <a href="http://mex.aksw.org/mex-algo#AdaptativeBoost">mexalgo:AdaptativeBoost</a>
    /// </summary>
    let AdaptativeBoost = _prefixId.prefix "AdaptativeBoost"
    let Algorithm = _prefixId.prefix "Algorithm"
    let AlgorithmClass = _prefixId.prefix "AlgorithmClass"
    let AlgorithmParameter = _prefixId.prefix "AlgorithmParameter"
    let AlgorithmParameterCollection = _prefixId.prefix "AlgorithmParameterCollection"
    let AllDisjointClasses = _prefixId.prefix "AllDisjointClasses"
    let ApacheMahout = _prefixId.prefix "ApacheMahout"
    let Apriori = _prefixId.prefix "Apriori"
    /// <summary>
    ///   <para>rdfs:label : ANN</para>
    ///   <a href="http://mex.aksw.org/mex-algo#ArtificialNeuralNetwork">mexalgo:ArtificialNeuralNetwork</a>
    /// </summary>
    let ArtificialNeuralNetwork = _prefixId.prefix "ArtificialNeuralNetwork"
    let Association = _prefixId.prefix "Association"

    /// <summary>
    ///   <para>rdfs:label : ARIMA</para>
    ///   <a href="http://mex.aksw.org/mex-algo#AutoregressiveIntegratedMovingAverage">mexalgo:AutoregressiveIntegratedMovingAverage</a>
    /// </summary>
    let AutoregressiveIntegratedMovingAverage =
        _prefixId.prefix "AutoregressiveIntegratedMovingAverage"

    /// <summary>
    ///   <para>rdfs:label : ARMA</para>
    ///   <a href="http://mex.aksw.org/mex-algo#AutoregressiveMovingAverage">mexalgo:AutoregressiveMovingAverage</a>
    /// </summary>
    let AutoregressiveMovingAverage = _prefixId.prefix "AutoregressiveMovingAverage"

    /// <summary>
    ///   <para>rdfs:label : AODE</para>
    ///   <a href="http://mex.aksw.org/mex-algo#AverageOneDependenceEstimators">mexalgo:AverageOneDependenceEstimators</a>
    /// </summary>
    let AverageOneDependenceEstimators =
        _prefixId.prefix "AverageOneDependenceEstimators"

    let BFTree = _prefixId.prefix "BFTree"
    let BIRCH = _prefixId.prefix "BIRCH"
    /// <summary>
    ///   <para>rdfs:label : NNBP</para>
    ///   <a href="http://mex.aksw.org/mex-algo#BackPropagation">mexalgo:BackPropagation</a>
    /// </summary>
    let BackPropagation = _prefixId.prefix "BackPropagation"
    let Bagging = _prefixId.prefix "Bagging"
    let Baseline = _prefixId.prefix "Baseline"
    let Bayes = _prefixId.prefix "Bayes"
    let BayesTheory = _prefixId.prefix "BayesTheory"
    let BayesTheoryAlgorithms = _prefixId.prefix "BayesTheoryAlgorithms"
    let Boosting = _prefixId.prefix "Boosting"
    let Bootstrap = _prefixId.prefix "Bootstrap"
    let C = _prefixId.prefix "C"
    let C_SVM = _prefixId.prefix "C-SVM"
    let C45 = _prefixId.prefix "C45"
    let CART = _prefixId.prefix "CART"
    let CHAID = _prefixId.prefix "CHAID"
    let CHAMELEON = _prefixId.prefix "CHAMELEON"
    let CLARA = _prefixId.prefix "CLARA"
    let CLARANS = _prefixId.prefix "CLARANS"
    let CPlusPlus = _prefixId.prefix "CPlusPlus"
    let CURE = _prefixId.prefix "CURE"
    let Centura = _prefixId.prefix "Centura"
    let Classification = _prefixId.prefix "Classification"
    let Clustering = _prefixId.prefix "Clustering"
    let CrossValidation = _prefixId.prefix "CrossValidation"
    let DL_Learner = _prefixId.prefix "DL-Learner"
    let DL_Learning = _prefixId.prefix "DL-Learning"
    let DLLearner = _prefixId.prefix "DLLearner"
    let DecisionStump = _prefixId.prefix "DecisionStump"
    let DecisionTrees = _prefixId.prefix "DecisionTrees"
    let DecisionTreesAlgorithms = _prefixId.prefix "DecisionTreesAlgorithms"
    /// <summary>
    ///   <para>rdfs:comment : are typically unsupervised and are used to induce interesting patterns (such as association rules) from unlabeled data. The induced patterns are useful in exploratory data analysis.</para>
    ///   <a href="http://mex.aksw.org/mex-algo#DescriptiveMethod">mexalgo:DescriptiveMethod</a>
    /// </summary>
    let DescriptiveMethod = _prefixId.prefix "DescriptiveMethod"
    let DotNet = _prefixId.prefix "DotNet"
    let ELKI = _prefixId.prefix "ELKI"
    let EViews = _prefixId.prefix "EViews"
    let Encog = _prefixId.prefix "Encog"
    let EnsambleTechnique = _prefixId.prefix "EnsambleTechnique"
    let FAMa = _prefixId.prefix "FAMa"
    let FP = _prefixId.prefix "FP"
    let FP_growth = _prefixId.prefix "FP-growth"
    let ForClassificationProblem = _prefixId.prefix "ForClassificationProblem"
    let GA = _prefixId.prefix "GA"
    let GaussianRBF = _prefixId.prefix "GaussianRBF"
    let GeneticAlgorithm = _prefixId.prefix "GeneticAlgorithm"
    let GeneticAlgorithms = _prefixId.prefix "GeneticAlgorithms"
    let GraphKernel = _prefixId.prefix "GraphKernel"
    let H2O = _prefixId.prefix "H2O"
    let Holdout = _prefixId.prefix "Holdout"
    let HybridAlgorithm = _prefixId.prefix "HybridAlgorithm"
    let IBMMiner = _prefixId.prefix "IBMMiner"
    let ID3 = _prefixId.prefix "ID3"
    let INDUCE = _prefixId.prefix "INDUCE"
    let Implementation = _prefixId.prefix "Implementation"
    /// <summary>
    ///   <para>rdfs:label : ILP</para>
    ///   <a href="http://mex.aksw.org/mex-algo#InductiveLogicProgramming">mexalgo:InductiveLogicProgramming</a>
    /// </summary>
    let InductiveLogicProgramming = _prefixId.prefix "InductiveLogicProgramming"
    let J48 = _prefixId.prefix "J48"
    let J48Graft = _prefixId.prefix "J48Graft"
    let Java = _prefixId.prefix "Java"
    let JavaScript = _prefixId.prefix "JavaScript"
    let Julia = _prefixId.prefix "Julia"
    let K_means = _prefixId.prefix "K-means"
    let KNIME = _prefixId.prefix "KNIME"
    let KXEN = _prefixId.prefix "KXEN"
    let Kmeans = _prefixId.prefix "Kmeans"
    let LADTree = _prefixId.prefix "LADTree"
    let LIONsolver = _prefixId.prefix "LIONsolver"
    let LMT = _prefixId.prefix "LMT"
    /// <summary>
    ///   <para>rdfs:comment : Supervised Learning, Unsupervised Learning, Semi-supervised Learning, Reinforcement Learning, ...</para>
    ///   <a href="http://mex.aksw.org/mex-algo#LearningMethod">mexalgo:LearningMethod</a>
    /// </summary>
    let LearningMethod = _prefixId.prefix "LearningMethod"
    /// <summary>
    ///   <para>rdfs:comment : A ValuePartition that describes only values from Regression, Classification or Clustering. NB Subclasses can themselves be divided up into further partitions.</para>
    ///   <a href="http://mex.aksw.org/mex-algo#LearningProblem">mexalgo:LearningProblem</a>
    /// </summary>
    let LearningProblem = _prefixId.prefix "LearningProblem"
    let LibLinear = _prefixId.prefix "LibLinear"
    let LibSVM = _prefixId.prefix "LibSVM"
    let Library = _prefixId.prefix "Library"
    let Linear = _prefixId.prefix "Linear"
    let LinearRegression = _prefixId.prefix "LinearRegression"
    let Linear_Regression = _prefixId.prefix "Linear_Regression"
    let LogicalRepresentations = _prefixId.prefix "LogicalRepresentations"
    let LogisticRegression = _prefixId.prefix "LogisticRegression"
    let Logistic_Regression = _prefixId.prefix "Logistic_Regression"
    let MARS = _prefixId.prefix "MARS"
    let MLPACK = _prefixId.prefix "MLPACK"
    let Markov = _prefixId.prefix "Markov"
    /// <summary>
    ///   <para>rdfs:label : MOA</para>
    ///   <a href="http://mex.aksw.org/mex-algo#MassiveOnlineAnalysis">mexalgo:MassiveOnlineAnalysis</a>
    /// </summary>
    let MassiveOnlineAnalysis = _prefixId.prefix "MassiveOnlineAnalysis"
    let Mathematica = _prefixId.prefix "Mathematica"
    let Matlab = _prefixId.prefix "Matlab"
    let Metaheuristic = _prefixId.prefix "Metaheuristic"
    /// <summary>
    ///   <para>rdfs:label : AZURE</para>
    ///   <a href="http://mex.aksw.org/mex-algo#MicrosoftAzureMachineLearning">mexalgo:MicrosoftAzureMachineLearning</a>
    /// </summary>
    let MicrosoftAzureMachineLearning = _prefixId.prefix "MicrosoftAzureMachineLearning"
    let Microsoft_SQL_Server = _prefixId.prefix "Microsoft_SQL_Server"

    let MonteCarloMachineLearningLibrary =
        _prefixId.prefix "MonteCarloMachineLearningLibrary"

    let NBTree = _prefixId.prefix "NBTree"
    let NN_BackPropagation = _prefixId.prefix "NN-BackPropagation"
    /// <summary>
    ///   <para>rdfs:comment : In machine learning, naive Bayes classifiers are a family of simple probabilistic classifiers based on applying Bayes' theorem with strong (naive) independence assumptions between the features.
    ///
    /// Naive Bayes has been studied extensively since the 1950s. It was introduced under a different name into the text retrieval community in the early 1960s:488 and remains a popular (baseline) method for text categorization, the problem of judging documents as belonging to one category or the other (such as spam or legitimate, sports or politics, etc.) with word frequencies as the features. With appropriate preprocessing, it is competitive in this domain with more advanced methods including support vector machines.It also finds application in automatic medical diagnosis.
    ///
    /// Naive Bayes classifiers are highly scalable, requiring a number of parameters linear in the number of variables (features/predictors) in a learning problem. Maximum-likelihood training can be done by evaluating a closed-form expression, which takes linear time, rather than by expensive iterative approximation as used for many other types of classifiers.
    ///
    /// In the statistics and computer science literature, Naive Bayes models are known under a variety of names, including simple Bayes and independence Bayes.[4] All these names reference the use of Bayes' theorem in the classifier's decision rule, but naive Bayes is not (necessarily) a Bayesian method Russell and Norvig note that "[naive Bayes] is sometimes called a Bayesian classifier, a somewhat careless usage that has prompted true Bayesians to call it the idiot Bayes model.</para>
    ///   <a href="http://mex.aksw.org/mex-algo#NaiveBayes">mexalgo:NaiveBayes</a>
    /// </summary>
    let NaiveBayes = _prefixId.prefix "NaiveBayes"
    let Naive_Bayes = _prefixId.prefix "Naive_Bayes"
    /// <summary>
    ///   <para>rdfs:comment : The basic information regarding the algorithms used into the experiment</para>
    ///   <a href="http://mex.aksw.org/mex-algo#NamedAlgorithm">mexalgo:NamedAlgorithm</a>
    /// </summary>
    let NamedAlgorithm = _prefixId.prefix "NamedAlgorithm"
    let NamedIndividual = _prefixId.prefix "NamedIndividual"
    let NearestNeigbour = _prefixId.prefix "NearestNeigbour"
    let NearestNeighbour = _prefixId.prefix "NearestNeighbour"
    let Nearest_Neighbour = _prefixId.prefix "Nearest_Neighbour"
    let NeuralNetwork = _prefixId.prefix "NeuralNetwork"
    let NeuroSolutions = _prefixId.prefix "NeuroSolutions"
    let NodeJS = _prefixId.prefix "NodeJS"
    let OPTICS = _prefixId.prefix "OPTICS"
    let Octave = _prefixId.prefix "Octave"
    let OpenCV = _prefixId.prefix "OpenCV"
    let OpenNN = _prefixId.prefix "OpenNN"
    let OracleDataMining = _prefixId.prefix "OracleDataMining"
    let Orange = _prefixId.prefix "Orange"
    let Other = _prefixId.prefix "Other"
    let PHP = _prefixId.prefix "PHP"
    let PathKernel = _prefixId.prefix "PathKernel"
    let Polynomial = _prefixId.prefix "Polynomial"
    /// <summary>
    ///   <para>rdfs:comment : they are used to induce models or theories from class-labeled data</para>
    ///   <a href="http://mex.aksw.org/mex-algo#PredictiveMethod">mexalgo:PredictiveMethod</a>
    /// </summary>
    let PredictiveMethod = _prefixId.prefix "PredictiveMethod"
    let ProbabilisticSoftLogic = _prefixId.prefix "ProbabilisticSoftLogic"
    let Python = _prefixId.prefix "Python"
    let R = _prefixId.prefix "R"
    let R_SVM = _prefixId.prefix "R-SVM"
    let RCASE = _prefixId.prefix "RCASE"
    let REPTree = _prefixId.prefix "REPTree"
    let RandomCrossValidation = _prefixId.prefix "RandomCrossValidation"
    /// <summary>
    ///   <para>rdfs:comment : Random forests are an ensemble learning method for classification, regression and other tasks, that operate by constructing a multitude of decision trees at training time and outputting the class that is the mode of the classes (classification) or mean prediction (regression) of the individual trees. Random forests correct for decision trees' habit of overfitting to their training set.</para>
    ///   <a href="http://mex.aksw.org/mex-algo#RandomForest">mexalgo:RandomForest</a>
    /// </summary>
    let RandomForest = _prefixId.prefix "RandomForest"
    let RapidMiner = _prefixId.prefix "RapidMiner"
    let Regression = _prefixId.prefix "Regression"
    let RegressionAnalysis = _prefixId.prefix "RegressionAnalysis"
    let RegressionFunctions = _prefixId.prefix "RegressionFunctions"
    let Reinforcement = _prefixId.prefix "Reinforcement"
    let Ruby = _prefixId.prefix "Ruby"
    let Rules = _prefixId.prefix "Rules"
    let SAP = _prefixId.prefix "SAP"
    let SAS = _prefixId.prefix "SAS"
    /// <summary>
    ///   <para>rdfs:label : SAS</para>
    ///   <a href="http://mex.aksw.org/mex-algo#SASEnterpriseMiner">mexalgo:SASEnterpriseMiner</a>
    /// </summary>
    let SASEnterpriseMiner = _prefixId.prefix "SASEnterpriseMiner"
    let SPSS = _prefixId.prefix "SPSS"
    let SQLServerAnalysisServices = _prefixId.prefix "SQLServerAnalysisServices"
    /// <summary>
    ///   <para>rdfs:label : STATISTICA</para>
    ///   <a href="http://mex.aksw.org/mex-algo#STATISTICADataMiner">mexalgo:STATISTICADataMiner</a>
    /// </summary>
    let STATISTICADataMiner = _prefixId.prefix "STATISTICADataMiner"
    let SVM = _prefixId.prefix "SVM"
    let SemiSupervised = _prefixId.prefix "SemiSupervised"
    let Shogun = _prefixId.prefix "Shogun"
    let Sigmoid = _prefixId.prefix "Sigmoid"
    let SimpleCart = _prefixId.prefix "SimpleCart"
    let Stata = _prefixId.prefix "Stata"
    let StatisticalApproach = _prefixId.prefix "StatisticalApproach"
    let StringKernel = _prefixId.prefix "StringKernel"
    let Summarization = _prefixId.prefix "Summarization"
    /// <summary>
    ///   <para>rdfs:comment : Supervised learning assumes that trainning examples are classified (labeled by class labels)</para>
    ///   <a href="http://mex.aksw.org/mex-algo#Supervised">mexalgo:Supervised</a>
    /// </summary>
    let Supervised = _prefixId.prefix "Supervised"
    let SupervisedApproach = _prefixId.prefix "SupervisedApproach"
    /// <summary>
    ///   <para>rdfs:label : SVM</para>
    ///   <para>rdfs:comment : In machine learning, support vector machines (SVMs, also support vector networks) are supervised learning models with associated learning algorithms that analyze data and recognize patterns, used for classification and regression analysis. Given a set of training examples, each marked as belonging to one of two categories, an SVM training algorithm builds a model that assigns new examples into one category or the other, making it a non-probabilistic binary linear classifier. An SVM model is a representation of the examples as points in space, mapped so that the examples of the separate categories are divided by a clear gap that is as wide as possible. New examples are then mapped into that same space and predicted to belong to a category based on which side of the gap they fall on.
    ///
    /// In addition to performing linear classification, SVMs can efficiently perform a non-linear classification using what is called the kernel trick, implicitly mapping their inputs into high-dimensional feature spaces.</para>
    ///   <a href="http://mex.aksw.org/mex-algo#SupportVectorMachines">mexalgo:SupportVectorMachines</a>
    /// </summary>
    let SupportVectorMachines = _prefixId.prefix "SupportVectorMachines"
    let SupportVectorNetworks = _prefixId.prefix "SupportVectorNetworks"
    let SymbolicApproach = _prefixId.prefix "SymbolicApproach"
    let Test = _prefixId.prefix "Test"
    let Trainning = _prefixId.prefix "Trainning"
    let TreeKernel = _prefixId.prefix "TreeKernel"
    /// <summary>
    ///   <para>rdfs:comment : Unsupervised learning concerns the analysis of unclassified examples</para>
    ///   <a href="http://mex.aksw.org/mex-algo#Unsupervised">mexalgo:Unsupervised</a>
    /// </summary>
    let Unsupervised = _prefixId.prefix "Unsupervised"
    let UnsupervisedApproach = _prefixId.prefix "UnsupervisedApproach"
    let UserClassifier = _prefixId.prefix "UserClassifier"
    let Validation = _prefixId.prefix "Validation"
    let WEKA = _prefixId.prefix "WEKA"
    let Weka = _prefixId.prefix "Weka"
    let YALE = _prefixId.prefix "YALE"
    let Yooreeka = _prefixId.prefix "Yooreeka"
    let acronym = _prefixId.prefix "acronym"
    let hasAlgorithmConfiguration = _prefixId.prefix "hasAlgorithmConfiguration"

    let hasAlgorithmParameterCollection =
        _prefixId.prefix "hasAlgorithmParameterCollection"

    let hasClass = _prefixId.prefix "hasClass"
    let hasImplementation = _prefixId.prefix "hasImplementation"
    let hasLearningMethod = _prefixId.prefix "hasLearningMethod"
    let hasLearningProblem = _prefixId.prefix "hasLearningProblem"
    let isAlgorithmConfigurationOf = _prefixId.prefix "isAlgorithmConfigurationOf"

    let isAlgorithmParameterCollectionOf =
        _prefixId.prefix "isAlgorithmParameterCollectionOf"

    let isClassOf = _prefixId.prefix "isClassOf"
    let isImplementationOf = _prefixId.prefix "isImplementationOf"
    let isLearningMethodOf = _prefixId.prefix "isLearningMethodOf"
    let isLearningProblemOf = _prefixId.prefix "isLearningProblemOf"
    let k_means = _prefixId.prefix "k-means"
    let mlpy = _prefixId.prefix "mlpy"
    let parametro1 = _prefixId.prefix "parametro1"
    let parametro2 = _prefixId.prefix "parametro2"
    let scikit_learn = _prefixId.prefix "scikit-learn"
