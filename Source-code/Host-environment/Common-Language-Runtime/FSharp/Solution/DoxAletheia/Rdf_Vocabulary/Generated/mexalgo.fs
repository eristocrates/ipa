namespace http.mex.aksw.org.mex_algo.hash

open DoxAletheia

module mexalgo =
    let _namespace_name = "http://mex.aksw.org/mex-algo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AllDisjointClasses"></see>
    /// </summary>
    let AllDisjointClasses = _prefix "AllDisjointClasses"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#C"></see>
    /// </summary>
    let C = _prefix "C"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DLLearner"></see>
    /// </summary>
    let DLLearner = _prefix "DLLearner"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#FAMa"></see>
    /// </summary>
    let FAMa = _prefix "FAMa"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Java"></see>
    /// </summary>
    let Java = _prefix "Java"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LibLinear"></see>
    /// </summary>
    let LibLinear = _prefix "LibLinear"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LibSVM"></see>
    /// </summary>
    let LibSVM = _prefix "LibSVM"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Matlab"></see>
    /// </summary>
    let Matlab = _prefix "Matlab"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Octave"></see>
    /// </summary>
    let Octave = _prefix "Octave"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Other"></see>
    /// </summary>
    let Other = _prefix "Other"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Python"></see>
    /// </summary>
    let Python = _prefix "Python"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#R"></see>
    /// </summary>
    let R = _prefix "R"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SASEnterpriseMiner"></see>
    /// </summary>
    let SASEnterpriseMiner = _prefix "SASEnterpriseMiner"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SPSS"></see>
    /// </summary>
    let SPSS = _prefix "SPSS"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Weka"></see>
    /// </summary>
    let Weka = _prefix "Weka"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DotNet"></see>
    /// </summary>
    let DotNet = _prefix "DotNet"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Metaheuristic"></see>
    /// </summary>
    let Metaheuristic = _prefix "Metaheuristic"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Association"></see>
    /// </summary>
    let Association = _prefix "Association"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Classification"></see>
    /// </summary>
    let Classification = _prefix "Classification"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Clustering"></see>
    /// </summary>
    let Clustering = _prefix "Clustering"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Regression"></see>
    /// </summary>
    let Regression = _prefix "Regression"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Summarization"></see>
    /// </summary>
    let Summarization = _prefix "Summarization"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Boosting"></see>
    /// </summary>
    let Boosting = _prefix "Boosting"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ArtificialNeuralNetwork"></see>
    /// </summary>
    let ArtificialNeuralNetwork = _prefix "ArtificialNeuralNetwork"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#BayesTheory"></see>
    /// </summary>
    let BayesTheory = _prefix "BayesTheory"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DecisionTrees"></see>
    /// </summary>
    let DecisionTrees = _prefix "DecisionTrees"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#GeneticAlgorithms"></see>
    /// </summary>
    let GeneticAlgorithms = _prefix "GeneticAlgorithms"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#RegressionFunctions"></see>
    /// </summary>
    let RegressionFunctions = _prefix "RegressionFunctions"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SupportVectorNetworks"></see>
    /// </summary>
    let SupportVectorNetworks = _prefix "SupportVectorNetworks"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Reinforcement"></see>
    /// </summary>
    let Reinforcement = _prefix "Reinforcement"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SemiSupervised"></see>
    /// </summary>
    let SemiSupervised = _prefix "SemiSupervised"
    /// <summary>
    /// Supervised learning assumes that trainning examples are classified (labeled by class labels)
    /// <see href="http://mex.aksw.org/mex-algo#Supervised"></see></summary>
    let Supervised = _prefix "Supervised"
    /// <summary>
    /// Unsupervised learning concerns the analysis of unclassified examples
    /// <see href="http://mex.aksw.org/mex-algo#Unsupervised"></see></summary>
    let Unsupervised = _prefix "Unsupervised"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Algorithm"></see>
    /// </summary>
    let Algorithm = _prefix "Algorithm"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AlgorithmParameterCollection"></see>
    /// </summary>
    let AlgorithmParameterCollection = _prefix "AlgorithmParameterCollection"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AlgorithmClass"></see>
    /// </summary>
    let AlgorithmClass = _prefix "AlgorithmClass"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AlgorithmParameter"></see>
    /// </summary>
    let AlgorithmParameter = _prefix "AlgorithmParameter"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Implementation"></see>
    /// </summary>
    let Implementation = _prefix "Implementation"
    /// <summary>
    /// Supervised Learning, Unsupervised Learning, Semi-supervised Learning, Reinforcement Learning, ...
    /// <see href="http://mex.aksw.org/mex-algo#LearningMethod"></see></summary>
    let LearningMethod = _prefix "LearningMethod"
    /// <summary>
    /// A ValuePartition that describes only values from Regression, Classification or Clustering. NB Subclasses can themselves be divided up into further partitions.
    /// <see href="http://mex.aksw.org/mex-algo#LearningProblem"></see></summary>
    let LearningProblem = _prefix "LearningProblem"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ADTree"></see>
    /// </summary>
    let ADTree = _prefix "ADTree"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasClass"></see>
    /// </summary>
    let hasClass = _prefix "hasClass"
    /// <summary>
    /// The basic information regarding the algorithms used into the experiment
    /// <see href="http://mex.aksw.org/mex-algo#NamedAlgorithm"></see></summary>
    let NamedAlgorithm = _prefix "NamedAlgorithm"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AODE"></see>
    /// </summary>
    let AODE = _prefix "AODE"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NamedIndividual"></see>
    /// </summary>
    let NamedIndividual = _prefix "NamedIndividual"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AQ"></see>
    /// </summary>
    let AQ = _prefix "AQ"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Rules"></see>
    /// </summary>
    let Rules = _prefix "Rules"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AdaBoost"></see>
    /// </summary>
    let AdaBoost = _prefix "AdaBoost"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AdaptativeBoost"></see>
    /// </summary>
    let AdaptativeBoost = _prefix "AdaptativeBoost"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasLearningMethod"></see>
    /// </summary>
    let hasLearningMethod = _prefix "hasLearningMethod"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasLearningProblem"></see>
    /// </summary>
    let hasLearningProblem = _prefix "hasLearningProblem"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ApacheMahout"></see>
    /// </summary>
    let ApacheMahout = _prefix "ApacheMahout"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Apriori"></see>
    /// </summary>
    let Apriori = _prefix "Apriori"

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AutoregressiveIntegratedMovingAverage"></see>
    /// </summary>
    let AutoregressiveIntegratedMovingAverage =
        _prefix "AutoregressiveIntegratedMovingAverage"

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AutoregressiveMovingAverage"></see>
    /// </summary>
    let AutoregressiveMovingAverage = _prefix "AutoregressiveMovingAverage"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AverageOneDependenceEstimators"></see>
    /// </summary>
    let AverageOneDependenceEstimators = _prefix "AverageOneDependenceEstimators"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#BFTree"></see>
    /// </summary>
    let BFTree = _prefix "BFTree"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#BIRCH"></see>
    /// </summary>
    let BIRCH = _prefix "BIRCH"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#BackPropagation"></see>
    /// </summary>
    let BackPropagation = _prefix "BackPropagation"
    /// <summary>
    /// Random forests are an ensemble learning method for classification, regression and other tasks, that operate by constructing a multitude of decision trees at training time and outputting the class that is the mode of the classes (classification) or mean prediction (regression) of the individual trees. Random forests correct for decision trees' habit of overfitting to their training set.
    /// <see href="http://mex.aksw.org/mex-algo#RandomForest"></see></summary>
    let RandomForest = _prefix "RandomForest"
    /// <summary>
    /// In machine learning, support vector machines (SVMs, also support vector networks) are supervised learning models with associated learning algorithms that analyze data and recognize patterns, used for classification and regression analysis. Given a set of training examples, each marked as belonging to one of two categories, an SVM training algorithm builds a model that assigns new examples into one category or the other, making it a non-probabilistic binary linear classifier. An SVM model is a representation of the examples as points in space, mapped so that the examples of the separate categories are divided by a clear gap that is as wide as possible. New examples are then mapped into that same space and predicted to belong to a category based on which side of the gap they fall on.
    ///
    /// In addition to performing linear classification, SVMs can efficiently perform a non-linear classification using what is called the kernel trick, implicitly mapping their inputs into high-dimensional feature spaces.
    /// <see href="http://mex.aksw.org/mex-algo#SupportVectorMachines"></see></summary>
    let SupportVectorMachines = _prefix "SupportVectorMachines"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LogisticRegression"></see>
    /// </summary>
    let LogisticRegression = _prefix "LogisticRegression"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#RegressionAnalysis"></see>
    /// </summary>
    let RegressionAnalysis = _prefix "RegressionAnalysis"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Kmeans"></see>
    /// </summary>
    let Kmeans = _prefix "Kmeans"
    /// <summary>
    /// In machine learning, naive Bayes classifiers are a family of simple probabilistic classifiers based on applying Bayes' theorem with strong (naive) independence assumptions between the features.
    ///
    /// Naive Bayes has been studied extensively since the 1950s. It was introduced under a different name into the text retrieval community in the early 1960s:488 and remains a popular (baseline) method for text categorization, the problem of judging documents as belonging to one category or the other (such as spam or legitimate, sports or politics, etc.) with word frequencies as the features. With appropriate preprocessing, it is competitive in this domain with more advanced methods including support vector machines.It also finds application in automatic medical diagnosis.
    ///
    /// Naive Bayes classifiers are highly scalable, requiring a number of parameters linear in the number of variables (features/predictors) in a learning problem. Maximum-likelihood training can be done by evaluating a closed-form expression, which takes linear time, rather than by expensive iterative approximation as used for many other types of classifiers.
    ///
    /// In the statistics and computer science literature, Naive Bayes models are known under a variety of names, including simple Bayes and independence Bayes.[4] All these names reference the use of Bayes' theorem in the classifier's decision rule, but naive Bayes is not (necessarily) a Bayesian method Russell and Norvig note that "[naive Bayes] is sometimes called a Bayesian classifier, a somewhat careless usage that has prompted true Bayesians to call it the idiot Bayes model.
    /// <see href="http://mex.aksw.org/mex-algo#NaiveBayes"></see></summary>
    let NaiveBayes = _prefix "NaiveBayes"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Bagging"></see>
    /// </summary>
    let Bagging = _prefix "Bagging"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Baseline"></see>
    /// </summary>
    let Baseline = _prefix "Baseline"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Bayes"></see>
    /// </summary>
    let Bayes = _prefix "Bayes"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#BayesTheoryAlgorithms"></see>
    /// </summary>
    let BayesTheoryAlgorithms = _prefix "BayesTheoryAlgorithms"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Bootstrap"></see>
    /// </summary>
    let Bootstrap = _prefix "Bootstrap"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Library"></see>
    /// </summary>
    let Library = _prefix "Library"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#C-SVM"></see>
    /// </summary>
    let ``C-SVM`` = _prefix "C-SVM"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#C45"></see>
    /// </summary>
    let C45 = _prefix "C45"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CART"></see>
    /// </summary>
    let CART = _prefix "CART"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CHAID"></see>
    /// </summary>
    let CHAID = _prefix "CHAID"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CHAMELEON"></see>
    /// </summary>
    let CHAMELEON = _prefix "CHAMELEON"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CLARA"></see>
    /// </summary>
    let CLARA = _prefix "CLARA"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CLARANS"></see>
    /// </summary>
    let CLARANS = _prefix "CLARANS"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CPlusPlus"></see>
    /// </summary>
    let CPlusPlus = _prefix "CPlusPlus"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CURE"></see>
    /// </summary>
    let CURE = _prefix "CURE"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Centura"></see>
    /// </summary>
    let Centura = _prefix "Centura"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CrossValidation"></see>
    /// </summary>
    let CrossValidation = _prefix "CrossValidation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DL-Learner"></see>
    /// </summary>
    let ``DL-Learner`` = _prefix "DL-Learner"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DL-Learning"></see>
    /// </summary>
    let ``DL-Learning`` = _prefix "DL-Learning"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DecisionStump"></see>
    /// </summary>
    let DecisionStump = _prefix "DecisionStump"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DecisionTreesAlgorithms"></see>
    /// </summary>
    let DecisionTreesAlgorithms = _prefix "DecisionTreesAlgorithms"
    /// <summary>
    /// are typically unsupervised and are used to induce interesting patterns (such as association rules) from unlabeled data. The induced patterns are useful in exploratory data analysis.
    /// <see href="http://mex.aksw.org/mex-algo#DescriptiveMethod"></see></summary>
    let DescriptiveMethod = _prefix "DescriptiveMethod"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ELKI"></see>
    /// </summary>
    let ELKI = _prefix "ELKI"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#EViews"></see>
    /// </summary>
    let EViews = _prefix "EViews"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Encog"></see>
    /// </summary>
    let Encog = _prefix "Encog"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#EnsambleTechnique"></see>
    /// </summary>
    let EnsambleTechnique = _prefix "EnsambleTechnique"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#FP"></see>
    /// </summary>
    let FP = _prefix "FP"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#FP-growth"></see>
    /// </summary>
    let ``FP-growth`` = _prefix "FP-growth"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ForClassificationProblem"></see>
    /// </summary>
    let ForClassificationProblem = _prefix "ForClassificationProblem"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#GA"></see>
    /// </summary>
    let GA = _prefix "GA"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#GaussianRBF"></see>
    /// </summary>
    let GaussianRBF = _prefix "GaussianRBF"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#GeneticAlgorithm"></see>
    /// </summary>
    let GeneticAlgorithm = _prefix "GeneticAlgorithm"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#GraphKernel"></see>
    /// </summary>
    let GraphKernel = _prefix "GraphKernel"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#H2O"></see>
    /// </summary>
    let H2O = _prefix "H2O"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Holdout"></see>
    /// </summary>
    let Holdout = _prefix "Holdout"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#HybridAlgorithm"></see>
    /// </summary>
    let HybridAlgorithm = _prefix "HybridAlgorithm"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#IBMMiner"></see>
    /// </summary>
    let IBMMiner = _prefix "IBMMiner"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ID3"></see>
    /// </summary>
    let ID3 = _prefix "ID3"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#INDUCE"></see>
    /// </summary>
    let INDUCE = _prefix "INDUCE"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#InductiveLogicProgramming"></see>
    /// </summary>
    let InductiveLogicProgramming = _prefix "InductiveLogicProgramming"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#J48"></see>
    /// </summary>
    let J48 = _prefix "J48"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#J48Graft"></see>
    /// </summary>
    let J48Graft = _prefix "J48Graft"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#JavaScript"></see>
    /// </summary>
    let JavaScript = _prefix "JavaScript"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Julia"></see>
    /// </summary>
    let Julia = _prefix "Julia"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#K-means"></see>
    /// </summary>
    let ``K-means`` = _prefix "K-means"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#KNIME"></see>
    /// </summary>
    let KNIME = _prefix "KNIME"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#KXEN"></see>
    /// </summary>
    let KXEN = _prefix "KXEN"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LADTree"></see>
    /// </summary>
    let LADTree = _prefix "LADTree"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LIONsolver"></see>
    /// </summary>
    let LIONsolver = _prefix "LIONsolver"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LMT"></see>
    /// </summary>
    let LMT = _prefix "LMT"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Linear"></see>
    /// </summary>
    let Linear = _prefix "Linear"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LinearRegression"></see>
    /// </summary>
    let LinearRegression = _prefix "LinearRegression"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Linear_Regression"></see>
    /// </summary>
    let Linear_Regression = _prefix "Linear_Regression"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LogicalRepresentations"></see>
    /// </summary>
    let LogicalRepresentations = _prefix "LogicalRepresentations"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Logistic_Regression"></see>
    /// </summary>
    let Logistic_Regression = _prefix "Logistic_Regression"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#MARS"></see>
    /// </summary>
    let MARS = _prefix "MARS"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#MLPACK"></see>
    /// </summary>
    let MLPACK = _prefix "MLPACK"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Markov"></see>
    /// </summary>
    let Markov = _prefix "Markov"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#MassiveOnlineAnalysis"></see>
    /// </summary>
    let MassiveOnlineAnalysis = _prefix "MassiveOnlineAnalysis"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Mathematica"></see>
    /// </summary>
    let Mathematica = _prefix "Mathematica"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#MicrosoftAzureMachineLearning"></see>
    /// </summary>
    let MicrosoftAzureMachineLearning = _prefix "MicrosoftAzureMachineLearning"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Microsoft_SQL_Server"></see>
    /// </summary>
    let Microsoft_SQL_Server = _prefix "Microsoft_SQL_Server"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#MonteCarloMachineLearningLibrary"></see>
    /// </summary>
    let MonteCarloMachineLearningLibrary = _prefix "MonteCarloMachineLearningLibrary"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NBTree"></see>
    /// </summary>
    let NBTree = _prefix "NBTree"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NN-BackPropagation"></see>
    /// </summary>
    let ``NN-BackPropagation`` = _prefix "NN-BackPropagation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Naive_Bayes"></see>
    /// </summary>
    let Naive_Bayes = _prefix "Naive_Bayes"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NearestNeigbour"></see>
    /// </summary>
    let NearestNeigbour = _prefix "NearestNeigbour"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NearestNeighbour"></see>
    /// </summary>
    let NearestNeighbour = _prefix "NearestNeighbour"
    /// <summary>
    /// k-NN
    /// <see href="http://mex.aksw.org/mex-algo#Nearest_Neighbour"></see></summary>
    let Nearest_Neighbour = _prefix "Nearest_Neighbour"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NeuralNetwork"></see>
    /// </summary>
    let NeuralNetwork = _prefix "NeuralNetwork"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NeuroSolutions"></see>
    /// </summary>
    let NeuroSolutions = _prefix "NeuroSolutions"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NodeJS"></see>
    /// </summary>
    let NodeJS = _prefix "NodeJS"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#OPTICS"></see>
    /// </summary>
    let OPTICS = _prefix "OPTICS"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#OpenCV"></see>
    /// </summary>
    let OpenCV = _prefix "OpenCV"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#OpenNN"></see>
    /// </summary>
    let OpenNN = _prefix "OpenNN"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#OracleDataMining"></see>
    /// </summary>
    let OracleDataMining = _prefix "OracleDataMining"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Orange"></see>
    /// </summary>
    let Orange = _prefix "Orange"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#PHP"></see>
    /// </summary>
    let PHP = _prefix "PHP"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#PathKernel"></see>
    /// </summary>
    let PathKernel = _prefix "PathKernel"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Polynomial"></see>
    /// </summary>
    let Polynomial = _prefix "Polynomial"
    /// <summary>
    /// they are used to induce models or theories from class-labeled data
    /// <see href="http://mex.aksw.org/mex-algo#PredictiveMethod"></see></summary>
    let PredictiveMethod = _prefix "PredictiveMethod"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ProbabilisticSoftLogic"></see>
    /// </summary>
    let ProbabilisticSoftLogic = _prefix "ProbabilisticSoftLogic"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#R-SVM"></see>
    /// </summary>
    let ``R-SVM`` = _prefix "R-SVM"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#RCASE"></see>
    /// </summary>
    let RCASE = _prefix "RCASE"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#REPTree"></see>
    /// </summary>
    let REPTree = _prefix "REPTree"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#RandomCrossValidation"></see>
    /// </summary>
    let RandomCrossValidation = _prefix "RandomCrossValidation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#RapidMiner"></see>
    /// </summary>
    let RapidMiner = _prefix "RapidMiner"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Ruby"></see>
    /// </summary>
    let Ruby = _prefix "Ruby"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SAP"></see>
    /// </summary>
    let SAP = _prefix "SAP"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SAS"></see>
    /// </summary>
    let SAS = _prefix "SAS"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SQLServerAnalysisServices"></see>
    /// </summary>
    let SQLServerAnalysisServices = _prefix "SQLServerAnalysisServices"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#STATISTICADataMiner"></see>
    /// </summary>
    let STATISTICADataMiner = _prefix "STATISTICADataMiner"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SVM"></see>
    /// </summary>
    let SVM = _prefix "SVM"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Shogun"></see>
    /// </summary>
    let Shogun = _prefix "Shogun"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Sigmoid"></see>
    /// </summary>
    let Sigmoid = _prefix "Sigmoid"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SimpleCart"></see>
    /// </summary>
    let SimpleCart = _prefix "SimpleCart"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Stata"></see>
    /// </summary>
    let Stata = _prefix "Stata"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#StatisticalApproach"></see>
    /// </summary>
    let StatisticalApproach = _prefix "StatisticalApproach"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#StringKernel"></see>
    /// </summary>
    let StringKernel = _prefix "StringKernel"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SupervisedApproach"></see>
    /// </summary>
    let SupervisedApproach = _prefix "SupervisedApproach"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SymbolicApproach"></see>
    /// </summary>
    let SymbolicApproach = _prefix "SymbolicApproach"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Test"></see>
    /// </summary>
    let Test = _prefix "Test"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Trainning"></see>
    /// </summary>
    let Trainning = _prefix "Trainning"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#TreeKernel"></see>
    /// </summary>
    let TreeKernel = _prefix "TreeKernel"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#UnsupervisedApproach"></see>
    /// </summary>
    let UnsupervisedApproach = _prefix "UnsupervisedApproach"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#UserClassifier"></see>
    /// </summary>
    let UserClassifier = _prefix "UserClassifier"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Validation"></see>
    /// </summary>
    let Validation = _prefix "Validation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#WEKA"></see>
    /// </summary>
    let WEKA = _prefix "WEKA"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#YALE"></see>
    /// </summary>
    let YALE = _prefix "YALE"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Yooreeka"></see>
    /// </summary>
    let Yooreeka = _prefix "Yooreeka"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#acronym"></see>
    /// </summary>
    let acronym = _prefix "acronym"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasAlgorithmConfiguration"></see>
    /// </summary>
    let hasAlgorithmConfiguration = _prefix "hasAlgorithmConfiguration"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasAlgorithmParameterCollection"></see>
    /// </summary>
    let hasAlgorithmParameterCollection = _prefix "hasAlgorithmParameterCollection"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasImplementation"></see>
    /// </summary>
    let hasImplementation = _prefix "hasImplementation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isAlgorithmConfigurationOf"></see>
    /// </summary>
    let isAlgorithmConfigurationOf = _prefix "isAlgorithmConfigurationOf"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isAlgorithmParameterCollectionOf"></see>
    /// </summary>
    let isAlgorithmParameterCollectionOf = _prefix "isAlgorithmParameterCollectionOf"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isClassOf"></see>
    /// </summary>
    let isClassOf = _prefix "isClassOf"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isImplementationOf"></see>
    /// </summary>
    let isImplementationOf = _prefix "isImplementationOf"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isLearningMethodOf"></see>
    /// </summary>
    let isLearningMethodOf = _prefix "isLearningMethodOf"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isLearningProblemOf"></see>
    /// </summary>
    let isLearningProblemOf = _prefix "isLearningProblemOf"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#k-means"></see>
    /// </summary>
    let ``k-means`` = _prefix "k-means"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#mlpy"></see>
    /// </summary>
    let mlpy = _prefix "mlpy"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#parametro1"></see>
    /// </summary>
    let parametro1 = _prefix "parametro1"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#parametro2"></see>
    /// </summary>
    let parametro2 = _prefix "parametro2"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#scikit-learn"></see>
    /// </summary>
    let ``scikit-learn`` = _prefix "scikit-learn"
