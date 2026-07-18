namespace http.mex.aksw.org.mex_algo.hash

open DoxAletheia.Rdf_Vocabulary

module mexalgo =
    let _namespace_name = "http://mex.aksw.org/mex-algo#"

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AllDisjointClasses"></see>
    /// </summary>
    let AllDisjointClasses =
        Namespaced_IRI.parse _namespace_name "AllDisjointClasses" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#C"></see>
    /// </summary>
    let C = Namespaced_IRI.parse _namespace_name "C" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DLLearner"></see>
    /// </summary>
    let DLLearner = Namespaced_IRI.parse _namespace_name "DLLearner" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#FAMa"></see>
    /// </summary>
    let FAMa = Namespaced_IRI.parse _namespace_name "FAMa" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Java"></see>
    /// </summary>
    let Java = Namespaced_IRI.parse _namespace_name "Java" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LibLinear"></see>
    /// </summary>
    let LibLinear = Namespaced_IRI.parse _namespace_name "LibLinear" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LibSVM"></see>
    /// </summary>
    let LibSVM = Namespaced_IRI.parse _namespace_name "LibSVM" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Matlab"></see>
    /// </summary>
    let Matlab = Namespaced_IRI.parse _namespace_name "Matlab" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Octave"></see>
    /// </summary>
    let Octave = Namespaced_IRI.parse _namespace_name "Octave" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Other"></see>
    /// </summary>
    let Other = Namespaced_IRI.parse _namespace_name "Other" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Python"></see>
    /// </summary>
    let Python = Namespaced_IRI.parse _namespace_name "Python" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#R"></see>
    /// </summary>
    let R = Namespaced_IRI.parse _namespace_name "R" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SASEnterpriseMiner"></see>
    /// </summary>
    let SASEnterpriseMiner =
        Namespaced_IRI.parse _namespace_name "SASEnterpriseMiner" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SPSS"></see>
    /// </summary>
    let SPSS = Namespaced_IRI.parse _namespace_name "SPSS" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Weka"></see>
    /// </summary>
    let Weka = Namespaced_IRI.parse _namespace_name "Weka" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DotNet"></see>
    /// </summary>
    let DotNet = Namespaced_IRI.parse _namespace_name "DotNet" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Metaheuristic"></see>
    /// </summary>
    let Metaheuristic =
        Namespaced_IRI.parse _namespace_name "Metaheuristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Association"></see>
    /// </summary>
    let Association =
        Namespaced_IRI.parse _namespace_name "Association" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Classification"></see>
    /// </summary>
    let Classification =
        Namespaced_IRI.parse _namespace_name "Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Clustering"></see>
    /// </summary>
    let Clustering = Namespaced_IRI.parse _namespace_name "Clustering" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Regression"></see>
    /// </summary>
    let Regression = Namespaced_IRI.parse _namespace_name "Regression" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Summarization"></see>
    /// </summary>
    let Summarization =
        Namespaced_IRI.parse _namespace_name "Summarization" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Boosting"></see>
    /// </summary>
    let Boosting = Namespaced_IRI.parse _namespace_name "Boosting" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ArtificialNeuralNetwork"></see>
    /// </summary>
    let ArtificialNeuralNetwork =
        Namespaced_IRI.parse _namespace_name "ArtificialNeuralNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#BayesTheory"></see>
    /// </summary>
    let BayesTheory =
        Namespaced_IRI.parse _namespace_name "BayesTheory" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DecisionTrees"></see>
    /// </summary>
    let DecisionTrees =
        Namespaced_IRI.parse _namespace_name "DecisionTrees" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#GeneticAlgorithms"></see>
    /// </summary>
    let GeneticAlgorithms =
        Namespaced_IRI.parse _namespace_name "GeneticAlgorithms" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#RegressionFunctions"></see>
    /// </summary>
    let RegressionFunctions =
        Namespaced_IRI.parse _namespace_name "RegressionFunctions" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SupportVectorNetworks"></see>
    /// </summary>
    let SupportVectorNetworks =
        Namespaced_IRI.parse _namespace_name "SupportVectorNetworks" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Reinforcement"></see>
    /// </summary>
    let Reinforcement =
        Namespaced_IRI.parse _namespace_name "Reinforcement" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SemiSupervised"></see>
    /// </summary>
    let SemiSupervised =
        Namespaced_IRI.parse _namespace_name "SemiSupervised" |> NamespacedName

    /// <summary>
    /// Supervised learning assumes that trainning examples are classified (labeled by class labels)
    /// <see href="http://mex.aksw.org/mex-algo#Supervised"></see></summary>
    let Supervised = Namespaced_IRI.parse _namespace_name "Supervised" |> NamespacedName

    /// <summary>
    /// Unsupervised learning concerns the analysis of unclassified examples
    /// <see href="http://mex.aksw.org/mex-algo#Unsupervised"></see></summary>
    let Unsupervised =
        Namespaced_IRI.parse _namespace_name "Unsupervised" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Algorithm"></see>
    /// </summary>
    let Algorithm = Namespaced_IRI.parse _namespace_name "Algorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AlgorithmParameterCollection"></see>
    /// </summary>
    let AlgorithmParameterCollection =
        Namespaced_IRI.parse _namespace_name "AlgorithmParameterCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AlgorithmClass"></see>
    /// </summary>
    let AlgorithmClass =
        Namespaced_IRI.parse _namespace_name "AlgorithmClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AlgorithmParameter"></see>
    /// </summary>
    let AlgorithmParameter =
        Namespaced_IRI.parse _namespace_name "AlgorithmParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Implementation"></see>
    /// </summary>
    let Implementation =
        Namespaced_IRI.parse _namespace_name "Implementation" |> NamespacedName

    /// <summary>
    /// Supervised Learning, Unsupervised Learning, Semi-supervised Learning, Reinforcement Learning, ...
    /// <see href="http://mex.aksw.org/mex-algo#LearningMethod"></see></summary>
    let LearningMethod =
        Namespaced_IRI.parse _namespace_name "LearningMethod" |> NamespacedName

    /// <summary>
    /// A ValuePartition that describes only values from Regression, Classification or Clustering. NB Subclasses can themselves be divided up into further partitions.
    /// <see href="http://mex.aksw.org/mex-algo#LearningProblem"></see></summary>
    let LearningProblem =
        Namespaced_IRI.parse _namespace_name "LearningProblem" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ADTree"></see>
    /// </summary>
    let ADTree = Namespaced_IRI.parse _namespace_name "ADTree" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasClass"></see>
    /// </summary>
    let hasClass = Namespaced_IRI.parse _namespace_name "hasClass" |> NamespacedName

    /// <summary>
    /// The basic information regarding the algorithms used into the experiment
    /// <see href="http://mex.aksw.org/mex-algo#NamedAlgorithm"></see></summary>
    let NamedAlgorithm =
        Namespaced_IRI.parse _namespace_name "NamedAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AODE"></see>
    /// </summary>
    let AODE = Namespaced_IRI.parse _namespace_name "AODE" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NamedIndividual"></see>
    /// </summary>
    let NamedIndividual =
        Namespaced_IRI.parse _namespace_name "NamedIndividual" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AQ"></see>
    /// </summary>
    let AQ = Namespaced_IRI.parse _namespace_name "AQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Rules"></see>
    /// </summary>
    let Rules = Namespaced_IRI.parse _namespace_name "Rules" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AdaBoost"></see>
    /// </summary>
    let AdaBoost = Namespaced_IRI.parse _namespace_name "AdaBoost" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AdaptativeBoost"></see>
    /// </summary>
    let AdaptativeBoost =
        Namespaced_IRI.parse _namespace_name "AdaptativeBoost" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasLearningMethod"></see>
    /// </summary>
    let hasLearningMethod =
        Namespaced_IRI.parse _namespace_name "hasLearningMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasLearningProblem"></see>
    /// </summary>
    let hasLearningProblem =
        Namespaced_IRI.parse _namespace_name "hasLearningProblem" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ApacheMahout"></see>
    /// </summary>
    let ApacheMahout =
        Namespaced_IRI.parse _namespace_name "ApacheMahout" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Apriori"></see>
    /// </summary>
    let Apriori = Namespaced_IRI.parse _namespace_name "Apriori" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AutoregressiveIntegratedMovingAverage"></see>
    /// </summary>
    let AutoregressiveIntegratedMovingAverage =
        Namespaced_IRI.parse _namespace_name "AutoregressiveIntegratedMovingAverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AutoregressiveMovingAverage"></see>
    /// </summary>
    let AutoregressiveMovingAverage =
        Namespaced_IRI.parse _namespace_name "AutoregressiveMovingAverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#AverageOneDependenceEstimators"></see>
    /// </summary>
    let AverageOneDependenceEstimators =
        Namespaced_IRI.parse _namespace_name "AverageOneDependenceEstimators" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#BFTree"></see>
    /// </summary>
    let BFTree = Namespaced_IRI.parse _namespace_name "BFTree" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#BIRCH"></see>
    /// </summary>
    let BIRCH = Namespaced_IRI.parse _namespace_name "BIRCH" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#BackPropagation"></see>
    /// </summary>
    let BackPropagation =
        Namespaced_IRI.parse _namespace_name "BackPropagation" |> NamespacedName

    /// <summary>
    /// Random forests are an ensemble learning method for classification, regression and other tasks, that operate by constructing a multitude of decision trees at training time and outputting the class that is the mode of the classes (classification) or mean prediction (regression) of the individual trees. Random forests correct for decision trees' habit of overfitting to their training set.
    /// <see href="http://mex.aksw.org/mex-algo#RandomForest"></see></summary>
    let RandomForest =
        Namespaced_IRI.parse _namespace_name "RandomForest" |> NamespacedName

    /// <summary>
    /// In machine learning, support vector machines (SVMs, also support vector networks) are supervised learning models with associated learning algorithms that analyze data and recognize patterns, used for classification and regression analysis. Given a set of training examples, each marked as belonging to one of two categories, an SVM training algorithm builds a model that assigns new examples into one category or the other, making it a non-probabilistic binary linear classifier. An SVM model is a representation of the examples as points in space, mapped so that the examples of the separate categories are divided by a clear gap that is as wide as possible. New examples are then mapped into that same space and predicted to belong to a category based on which side of the gap they fall on.
    ///
    /// In addition to performing linear classification, SVMs can efficiently perform a non-linear classification using what is called the kernel trick, implicitly mapping their inputs into high-dimensional feature spaces.
    /// <see href="http://mex.aksw.org/mex-algo#SupportVectorMachines"></see></summary>
    let SupportVectorMachines =
        Namespaced_IRI.parse _namespace_name "SupportVectorMachines" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LogisticRegression"></see>
    /// </summary>
    let LogisticRegression =
        Namespaced_IRI.parse _namespace_name "LogisticRegression" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#RegressionAnalysis"></see>
    /// </summary>
    let RegressionAnalysis =
        Namespaced_IRI.parse _namespace_name "RegressionAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Kmeans"></see>
    /// </summary>
    let Kmeans = Namespaced_IRI.parse _namespace_name "Kmeans" |> NamespacedName
    /// <summary>
    /// In machine learning, naive Bayes classifiers are a family of simple probabilistic classifiers based on applying Bayes' theorem with strong (naive) independence assumptions between the features.
    ///
    /// Naive Bayes has been studied extensively since the 1950s. It was introduced under a different name into the text retrieval community in the early 1960s:488 and remains a popular (baseline) method for text categorization, the problem of judging documents as belonging to one category or the other (such as spam or legitimate, sports or politics, etc.) with word frequencies as the features. With appropriate preprocessing, it is competitive in this domain with more advanced methods including support vector machines.It also finds application in automatic medical diagnosis.
    ///
    /// Naive Bayes classifiers are highly scalable, requiring a number of parameters linear in the number of variables (features/predictors) in a learning problem. Maximum-likelihood training can be done by evaluating a closed-form expression, which takes linear time, rather than by expensive iterative approximation as used for many other types of classifiers.
    ///
    /// In the statistics and computer science literature, Naive Bayes models are known under a variety of names, including simple Bayes and independence Bayes.[4] All these names reference the use of Bayes' theorem in the classifier's decision rule, but naive Bayes is not (necessarily) a Bayesian method Russell and Norvig note that "[naive Bayes] is sometimes called a Bayesian classifier, a somewhat careless usage that has prompted true Bayesians to call it the idiot Bayes model.
    /// <see href="http://mex.aksw.org/mex-algo#NaiveBayes"></see></summary>
    let NaiveBayes = Namespaced_IRI.parse _namespace_name "NaiveBayes" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Bagging"></see>
    /// </summary>
    let Bagging = Namespaced_IRI.parse _namespace_name "Bagging" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Baseline"></see>
    /// </summary>
    let Baseline = Namespaced_IRI.parse _namespace_name "Baseline" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Bayes"></see>
    /// </summary>
    let Bayes = Namespaced_IRI.parse _namespace_name "Bayes" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#BayesTheoryAlgorithms"></see>
    /// </summary>
    let BayesTheoryAlgorithms =
        Namespaced_IRI.parse _namespace_name "BayesTheoryAlgorithms" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Bootstrap"></see>
    /// </summary>
    let Bootstrap = Namespaced_IRI.parse _namespace_name "Bootstrap" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Library"></see>
    /// </summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#C-SVM"></see>
    /// </summary>
    let ``C-SVM`` = Namespaced_IRI.parse _namespace_name "C-SVM" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#C45"></see>
    /// </summary>
    let C45 = Namespaced_IRI.parse _namespace_name "C45" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CART"></see>
    /// </summary>
    let CART = Namespaced_IRI.parse _namespace_name "CART" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CHAID"></see>
    /// </summary>
    let CHAID = Namespaced_IRI.parse _namespace_name "CHAID" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CHAMELEON"></see>
    /// </summary>
    let CHAMELEON = Namespaced_IRI.parse _namespace_name "CHAMELEON" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CLARA"></see>
    /// </summary>
    let CLARA = Namespaced_IRI.parse _namespace_name "CLARA" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CLARANS"></see>
    /// </summary>
    let CLARANS = Namespaced_IRI.parse _namespace_name "CLARANS" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CPlusPlus"></see>
    /// </summary>
    let CPlusPlus = Namespaced_IRI.parse _namespace_name "CPlusPlus" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CURE"></see>
    /// </summary>
    let CURE = Namespaced_IRI.parse _namespace_name "CURE" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Centura"></see>
    /// </summary>
    let Centura = Namespaced_IRI.parse _namespace_name "Centura" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#CrossValidation"></see>
    /// </summary>
    let CrossValidation =
        Namespaced_IRI.parse _namespace_name "CrossValidation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DL-Learner"></see>
    /// </summary>
    let ``DL-Learner`` =
        Namespaced_IRI.parse _namespace_name "DL-Learner" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DL-Learning"></see>
    /// </summary>
    let ``DL-Learning`` =
        Namespaced_IRI.parse _namespace_name "DL-Learning" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DecisionStump"></see>
    /// </summary>
    let DecisionStump =
        Namespaced_IRI.parse _namespace_name "DecisionStump" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#DecisionTreesAlgorithms"></see>
    /// </summary>
    let DecisionTreesAlgorithms =
        Namespaced_IRI.parse _namespace_name "DecisionTreesAlgorithms" |> NamespacedName

    /// <summary>
    /// are typically unsupervised and are used to induce interesting patterns (such as association rules) from unlabeled data. The induced patterns are useful in exploratory data analysis.
    /// <see href="http://mex.aksw.org/mex-algo#DescriptiveMethod"></see></summary>
    let DescriptiveMethod =
        Namespaced_IRI.parse _namespace_name "DescriptiveMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ELKI"></see>
    /// </summary>
    let ELKI = Namespaced_IRI.parse _namespace_name "ELKI" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#EViews"></see>
    /// </summary>
    let EViews = Namespaced_IRI.parse _namespace_name "EViews" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Encog"></see>
    /// </summary>
    let Encog = Namespaced_IRI.parse _namespace_name "Encog" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#EnsambleTechnique"></see>
    /// </summary>
    let EnsambleTechnique =
        Namespaced_IRI.parse _namespace_name "EnsambleTechnique" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#FP"></see>
    /// </summary>
    let FP = Namespaced_IRI.parse _namespace_name "FP" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#FP-growth"></see>
    /// </summary>
    let ``FP-growth`` =
        Namespaced_IRI.parse _namespace_name "FP-growth" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ForClassificationProblem"></see>
    /// </summary>
    let ForClassificationProblem =
        Namespaced_IRI.parse _namespace_name "ForClassificationProblem" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#GA"></see>
    /// </summary>
    let GA = Namespaced_IRI.parse _namespace_name "GA" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#GaussianRBF"></see>
    /// </summary>
    let GaussianRBF =
        Namespaced_IRI.parse _namespace_name "GaussianRBF" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#GeneticAlgorithm"></see>
    /// </summary>
    let GeneticAlgorithm =
        Namespaced_IRI.parse _namespace_name "GeneticAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#GraphKernel"></see>
    /// </summary>
    let GraphKernel =
        Namespaced_IRI.parse _namespace_name "GraphKernel" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#H2O"></see>
    /// </summary>
    let H2O = Namespaced_IRI.parse _namespace_name "H2O" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Holdout"></see>
    /// </summary>
    let Holdout = Namespaced_IRI.parse _namespace_name "Holdout" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#HybridAlgorithm"></see>
    /// </summary>
    let HybridAlgorithm =
        Namespaced_IRI.parse _namespace_name "HybridAlgorithm" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#IBMMiner"></see>
    /// </summary>
    let IBMMiner = Namespaced_IRI.parse _namespace_name "IBMMiner" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ID3"></see>
    /// </summary>
    let ID3 = Namespaced_IRI.parse _namespace_name "ID3" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#INDUCE"></see>
    /// </summary>
    let INDUCE = Namespaced_IRI.parse _namespace_name "INDUCE" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#InductiveLogicProgramming"></see>
    /// </summary>
    let InductiveLogicProgramming =
        Namespaced_IRI.parse _namespace_name "InductiveLogicProgramming" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#J48"></see>
    /// </summary>
    let J48 = Namespaced_IRI.parse _namespace_name "J48" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#J48Graft"></see>
    /// </summary>
    let J48Graft = Namespaced_IRI.parse _namespace_name "J48Graft" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#JavaScript"></see>
    /// </summary>
    let JavaScript = Namespaced_IRI.parse _namespace_name "JavaScript" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Julia"></see>
    /// </summary>
    let Julia = Namespaced_IRI.parse _namespace_name "Julia" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#K-means"></see>
    /// </summary>
    let ``K-means`` = Namespaced_IRI.parse _namespace_name "K-means" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#KNIME"></see>
    /// </summary>
    let KNIME = Namespaced_IRI.parse _namespace_name "KNIME" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#KXEN"></see>
    /// </summary>
    let KXEN = Namespaced_IRI.parse _namespace_name "KXEN" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LADTree"></see>
    /// </summary>
    let LADTree = Namespaced_IRI.parse _namespace_name "LADTree" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LIONsolver"></see>
    /// </summary>
    let LIONsolver = Namespaced_IRI.parse _namespace_name "LIONsolver" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LMT"></see>
    /// </summary>
    let LMT = Namespaced_IRI.parse _namespace_name "LMT" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Linear"></see>
    /// </summary>
    let Linear = Namespaced_IRI.parse _namespace_name "Linear" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LinearRegression"></see>
    /// </summary>
    let LinearRegression =
        Namespaced_IRI.parse _namespace_name "LinearRegression" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Linear_Regression"></see>
    /// </summary>
    let Linear_Regression =
        Namespaced_IRI.parse _namespace_name "Linear_Regression" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#LogicalRepresentations"></see>
    /// </summary>
    let LogicalRepresentations =
        Namespaced_IRI.parse _namespace_name "LogicalRepresentations" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Logistic_Regression"></see>
    /// </summary>
    let Logistic_Regression =
        Namespaced_IRI.parse _namespace_name "Logistic_Regression" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#MARS"></see>
    /// </summary>
    let MARS = Namespaced_IRI.parse _namespace_name "MARS" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#MLPACK"></see>
    /// </summary>
    let MLPACK = Namespaced_IRI.parse _namespace_name "MLPACK" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Markov"></see>
    /// </summary>
    let Markov = Namespaced_IRI.parse _namespace_name "Markov" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#MassiveOnlineAnalysis"></see>
    /// </summary>
    let MassiveOnlineAnalysis =
        Namespaced_IRI.parse _namespace_name "MassiveOnlineAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Mathematica"></see>
    /// </summary>
    let Mathematica =
        Namespaced_IRI.parse _namespace_name "Mathematica" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#MicrosoftAzureMachineLearning"></see>
    /// </summary>
    let MicrosoftAzureMachineLearning =
        Namespaced_IRI.parse _namespace_name "MicrosoftAzureMachineLearning" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Microsoft_SQL_Server"></see>
    /// </summary>
    let Microsoft_SQL_Server =
        Namespaced_IRI.parse _namespace_name "Microsoft_SQL_Server" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#MonteCarloMachineLearningLibrary"></see>
    /// </summary>
    let MonteCarloMachineLearningLibrary =
        Namespaced_IRI.parse _namespace_name "MonteCarloMachineLearningLibrary" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NBTree"></see>
    /// </summary>
    let NBTree = Namespaced_IRI.parse _namespace_name "NBTree" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NN-BackPropagation"></see>
    /// </summary>
    let ``NN-BackPropagation`` =
        Namespaced_IRI.parse _namespace_name "NN-BackPropagation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Naive_Bayes"></see>
    /// </summary>
    let Naive_Bayes =
        Namespaced_IRI.parse _namespace_name "Naive_Bayes" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NearestNeigbour"></see>
    /// </summary>
    let NearestNeigbour =
        Namespaced_IRI.parse _namespace_name "NearestNeigbour" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NearestNeighbour"></see>
    /// </summary>
    let NearestNeighbour =
        Namespaced_IRI.parse _namespace_name "NearestNeighbour" |> NamespacedName

    /// <summary>
    /// k-NN
    /// <see href="http://mex.aksw.org/mex-algo#Nearest_Neighbour"></see></summary>
    let Nearest_Neighbour =
        Namespaced_IRI.parse _namespace_name "Nearest_Neighbour" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NeuralNetwork"></see>
    /// </summary>
    let NeuralNetwork =
        Namespaced_IRI.parse _namespace_name "NeuralNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NeuroSolutions"></see>
    /// </summary>
    let NeuroSolutions =
        Namespaced_IRI.parse _namespace_name "NeuroSolutions" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#NodeJS"></see>
    /// </summary>
    let NodeJS = Namespaced_IRI.parse _namespace_name "NodeJS" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#OPTICS"></see>
    /// </summary>
    let OPTICS = Namespaced_IRI.parse _namespace_name "OPTICS" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#OpenCV"></see>
    /// </summary>
    let OpenCV = Namespaced_IRI.parse _namespace_name "OpenCV" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#OpenNN"></see>
    /// </summary>
    let OpenNN = Namespaced_IRI.parse _namespace_name "OpenNN" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#OracleDataMining"></see>
    /// </summary>
    let OracleDataMining =
        Namespaced_IRI.parse _namespace_name "OracleDataMining" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Orange"></see>
    /// </summary>
    let Orange = Namespaced_IRI.parse _namespace_name "Orange" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#PHP"></see>
    /// </summary>
    let PHP = Namespaced_IRI.parse _namespace_name "PHP" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#PathKernel"></see>
    /// </summary>
    let PathKernel = Namespaced_IRI.parse _namespace_name "PathKernel" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Polynomial"></see>
    /// </summary>
    let Polynomial = Namespaced_IRI.parse _namespace_name "Polynomial" |> NamespacedName

    /// <summary>
    /// they are used to induce models or theories from class-labeled data
    /// <see href="http://mex.aksw.org/mex-algo#PredictiveMethod"></see></summary>
    let PredictiveMethod =
        Namespaced_IRI.parse _namespace_name "PredictiveMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#ProbabilisticSoftLogic"></see>
    /// </summary>
    let ProbabilisticSoftLogic =
        Namespaced_IRI.parse _namespace_name "ProbabilisticSoftLogic" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#R-SVM"></see>
    /// </summary>
    let ``R-SVM`` = Namespaced_IRI.parse _namespace_name "R-SVM" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#RCASE"></see>
    /// </summary>
    let RCASE = Namespaced_IRI.parse _namespace_name "RCASE" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#REPTree"></see>
    /// </summary>
    let REPTree = Namespaced_IRI.parse _namespace_name "REPTree" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#RandomCrossValidation"></see>
    /// </summary>
    let RandomCrossValidation =
        Namespaced_IRI.parse _namespace_name "RandomCrossValidation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#RapidMiner"></see>
    /// </summary>
    let RapidMiner = Namespaced_IRI.parse _namespace_name "RapidMiner" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Ruby"></see>
    /// </summary>
    let Ruby = Namespaced_IRI.parse _namespace_name "Ruby" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SAP"></see>
    /// </summary>
    let SAP = Namespaced_IRI.parse _namespace_name "SAP" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SAS"></see>
    /// </summary>
    let SAS = Namespaced_IRI.parse _namespace_name "SAS" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SQLServerAnalysisServices"></see>
    /// </summary>
    let SQLServerAnalysisServices =
        Namespaced_IRI.parse _namespace_name "SQLServerAnalysisServices" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#STATISTICADataMiner"></see>
    /// </summary>
    let STATISTICADataMiner =
        Namespaced_IRI.parse _namespace_name "STATISTICADataMiner" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SVM"></see>
    /// </summary>
    let SVM = Namespaced_IRI.parse _namespace_name "SVM" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Shogun"></see>
    /// </summary>
    let Shogun = Namespaced_IRI.parse _namespace_name "Shogun" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Sigmoid"></see>
    /// </summary>
    let Sigmoid = Namespaced_IRI.parse _namespace_name "Sigmoid" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SimpleCart"></see>
    /// </summary>
    let SimpleCart = Namespaced_IRI.parse _namespace_name "SimpleCart" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Stata"></see>
    /// </summary>
    let Stata = Namespaced_IRI.parse _namespace_name "Stata" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#StatisticalApproach"></see>
    /// </summary>
    let StatisticalApproach =
        Namespaced_IRI.parse _namespace_name "StatisticalApproach" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#StringKernel"></see>
    /// </summary>
    let StringKernel =
        Namespaced_IRI.parse _namespace_name "StringKernel" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SupervisedApproach"></see>
    /// </summary>
    let SupervisedApproach =
        Namespaced_IRI.parse _namespace_name "SupervisedApproach" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#SymbolicApproach"></see>
    /// </summary>
    let SymbolicApproach =
        Namespaced_IRI.parse _namespace_name "SymbolicApproach" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Test"></see>
    /// </summary>
    let Test = Namespaced_IRI.parse _namespace_name "Test" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Trainning"></see>
    /// </summary>
    let Trainning = Namespaced_IRI.parse _namespace_name "Trainning" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#TreeKernel"></see>
    /// </summary>
    let TreeKernel = Namespaced_IRI.parse _namespace_name "TreeKernel" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#UnsupervisedApproach"></see>
    /// </summary>
    let UnsupervisedApproach =
        Namespaced_IRI.parse _namespace_name "UnsupervisedApproach" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#UserClassifier"></see>
    /// </summary>
    let UserClassifier =
        Namespaced_IRI.parse _namespace_name "UserClassifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Validation"></see>
    /// </summary>
    let Validation = Namespaced_IRI.parse _namespace_name "Validation" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#WEKA"></see>
    /// </summary>
    let WEKA = Namespaced_IRI.parse _namespace_name "WEKA" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#YALE"></see>
    /// </summary>
    let YALE = Namespaced_IRI.parse _namespace_name "YALE" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#Yooreeka"></see>
    /// </summary>
    let Yooreeka = Namespaced_IRI.parse _namespace_name "Yooreeka" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#acronym"></see>
    /// </summary>
    let acronym = Namespaced_IRI.parse _namespace_name "acronym" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasAlgorithmConfiguration"></see>
    /// </summary>
    let hasAlgorithmConfiguration =
        Namespaced_IRI.parse _namespace_name "hasAlgorithmConfiguration" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasAlgorithmParameterCollection"></see>
    /// </summary>
    let hasAlgorithmParameterCollection =
        Namespaced_IRI.parse _namespace_name "hasAlgorithmParameterCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#hasImplementation"></see>
    /// </summary>
    let hasImplementation =
        Namespaced_IRI.parse _namespace_name "hasImplementation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isAlgorithmConfigurationOf"></see>
    /// </summary>
    let isAlgorithmConfigurationOf =
        Namespaced_IRI.parse _namespace_name "isAlgorithmConfigurationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isAlgorithmParameterCollectionOf"></see>
    /// </summary>
    let isAlgorithmParameterCollectionOf =
        Namespaced_IRI.parse _namespace_name "isAlgorithmParameterCollectionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isClassOf"></see>
    /// </summary>
    let isClassOf = Namespaced_IRI.parse _namespace_name "isClassOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isImplementationOf"></see>
    /// </summary>
    let isImplementationOf =
        Namespaced_IRI.parse _namespace_name "isImplementationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isLearningMethodOf"></see>
    /// </summary>
    let isLearningMethodOf =
        Namespaced_IRI.parse _namespace_name "isLearningMethodOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#isLearningProblemOf"></see>
    /// </summary>
    let isLearningProblemOf =
        Namespaced_IRI.parse _namespace_name "isLearningProblemOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#k-means"></see>
    /// </summary>
    let ``k-means`` = Namespaced_IRI.parse _namespace_name "k-means" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#mlpy"></see>
    /// </summary>
    let mlpy = Namespaced_IRI.parse _namespace_name "mlpy" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#parametro1"></see>
    /// </summary>
    let parametro1 = Namespaced_IRI.parse _namespace_name "parametro1" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#parametro2"></see>
    /// </summary>
    let parametro2 = Namespaced_IRI.parse _namespace_name "parametro2" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-algo#scikit-learn"></see>
    /// </summary>
    let ``scikit-learn`` =
        Namespaced_IRI.parse _namespace_name "scikit-learn" |> NamespacedName
