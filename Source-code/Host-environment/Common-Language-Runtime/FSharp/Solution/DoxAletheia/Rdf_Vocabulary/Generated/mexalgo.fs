namespace http.mex.aksw.org.mex_algo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mexalgo =
    let _namespace_iri = Namespace_Iri mexalgo |> NamespaceIRI
    /// <summary>
    ///   <para>mexalgo:ADTree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#ADTree">http://mex.aksw.org/mex-algo#ADTree</seealso>
    let ADTree = Prefixed_Name(mexalgo, "ADTree") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:AODE</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AODE">http://mex.aksw.org/mex-algo#AODE</seealso>
    let AODE = Prefixed_Name(mexalgo, "AODE") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:AQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AQ">http://mex.aksw.org/mex-algo#AQ</seealso>
    let AQ = Prefixed_Name(mexalgo, "AQ") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:AdaBoost</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AdaBoost">http://mex.aksw.org/mex-algo#AdaBoost</seealso>
    let AdaBoost = Prefixed_Name(mexalgo, "AdaBoost") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:AdaptativeBoost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    ///
    /// labels<para>"AdaBoost"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AdaptativeBoost">http://mex.aksw.org/mex-algo#AdaptativeBoost</seealso>
    let AdaptativeBoost = Prefixed_Name(mexalgo, "AdaptativeBoost") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Algorithm">http://mex.aksw.org/mex-algo#Algorithm</seealso>
    let Algorithm = Prefixed_Name(mexalgo, "Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:AlgorithmClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AlgorithmClass">http://mex.aksw.org/mex-algo#AlgorithmClass</seealso>
    let AlgorithmClass = Prefixed_Name(mexalgo, "AlgorithmClass") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:AlgorithmParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AlgorithmParameter">http://mex.aksw.org/mex-algo#AlgorithmParameter</seealso>
    let AlgorithmParameter =
        Prefixed_Name(mexalgo, "AlgorithmParameter") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:AlgorithmParameterCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AlgorithmParameterCollection">http://mex.aksw.org/mex-algo#AlgorithmParameterCollection</seealso>
    let AlgorithmParameterCollection =
        Prefixed_Name(mexalgo, "AlgorithmParameterCollection") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:AllDisjointClasses</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AllDisjointClasses">http://mex.aksw.org/mex-algo#AllDisjointClasses</seealso>
    let AllDisjointClasses =
        Prefixed_Name(mexalgo, "AllDisjointClasses") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:ApacheMahout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#ApacheMahout">http://mex.aksw.org/mex-algo#ApacheMahout</seealso>
    let ApacheMahout = Prefixed_Name(mexalgo, "ApacheMahout") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Apriori</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Apriori">http://mex.aksw.org/mex-algo#Apriori</seealso>
    let Apriori = Prefixed_Name(mexalgo, "Apriori") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:ArtificialNeuralNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ANN"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#ArtificialNeuralNetwork">http://mex.aksw.org/mex-algo#ArtificialNeuralNetwork</seealso>
    let ArtificialNeuralNetwork =
        Prefixed_Name(mexalgo, "ArtificialNeuralNetwork") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Association">http://mex.aksw.org/mex-algo#Association</seealso>
    let Association = Prefixed_Name(mexalgo, "Association") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:AutoregressiveIntegratedMovingAverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ARIMA"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AutoregressiveIntegratedMovingAverage">http://mex.aksw.org/mex-algo#AutoregressiveIntegratedMovingAverage</seealso>
    let AutoregressiveIntegratedMovingAverage =
        Prefixed_Name(mexalgo, "AutoregressiveIntegratedMovingAverage") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:AutoregressiveMovingAverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ARMA"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AutoregressiveMovingAverage">http://mex.aksw.org/mex-algo#AutoregressiveMovingAverage</seealso>
    let AutoregressiveMovingAverage =
        Prefixed_Name(mexalgo, "AutoregressiveMovingAverage") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:AverageOneDependenceEstimators</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AODE"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#AverageOneDependenceEstimators">http://mex.aksw.org/mex-algo#AverageOneDependenceEstimators</seealso>
    let AverageOneDependenceEstimators =
        Prefixed_Name(mexalgo, "AverageOneDependenceEstimators") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:BFTree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#BFTree">http://mex.aksw.org/mex-algo#BFTree</seealso>
    let BFTree = Prefixed_Name(mexalgo, "BFTree") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:BIRCH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#BIRCH">http://mex.aksw.org/mex-algo#BIRCH</seealso>
    let BIRCH = Prefixed_Name(mexalgo, "BIRCH") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:BackPropagation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    ///
    /// labels<para>"NNBP"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#BackPropagation">http://mex.aksw.org/mex-algo#BackPropagation</seealso>
    let BackPropagation = Prefixed_Name(mexalgo, "BackPropagation") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Bagging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Bagging">http://mex.aksw.org/mex-algo#Bagging</seealso>
    let Bagging = Prefixed_Name(mexalgo, "Bagging") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Baseline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Baseline">http://mex.aksw.org/mex-algo#Baseline</seealso>
    let Baseline = Prefixed_Name(mexalgo, "Baseline") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Bayes</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Bayes">http://mex.aksw.org/mex-algo#Bayes</seealso>
    let Bayes = Prefixed_Name(mexalgo, "Bayes") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:BayesTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#BayesTheory">http://mex.aksw.org/mex-algo#BayesTheory</seealso>
    let BayesTheory = Prefixed_Name(mexalgo, "BayesTheory") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:BayesTheoryAlgorithms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#BayesTheoryAlgorithms">http://mex.aksw.org/mex-algo#BayesTheoryAlgorithms</seealso>
    let BayesTheoryAlgorithms =
        Prefixed_Name(mexalgo, "BayesTheoryAlgorithms") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:Boosting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Boosting">http://mex.aksw.org/mex-algo#Boosting</seealso>
    let Boosting = Prefixed_Name(mexalgo, "Boosting") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Bootstrap</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Bootstrap">http://mex.aksw.org/mex-algo#Bootstrap</seealso>
    let Bootstrap = Prefixed_Name(mexalgo, "Bootstrap") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#C">http://mex.aksw.org/mex-algo#C</seealso>
    let C = Prefixed_Name(mexalgo, "C") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:C-SVM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#C-SVM">http://mex.aksw.org/mex-algo#C-SVM</seealso>
    let C_SVM = Prefixed_Name(mexalgo, "C-SVM") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:C45</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#C45">http://mex.aksw.org/mex-algo#C45</seealso>
    let C45 = Prefixed_Name(mexalgo, "C45") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:CART</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#CART">http://mex.aksw.org/mex-algo#CART</seealso>
    let CART = Prefixed_Name(mexalgo, "CART") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:CHAID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#CHAID">http://mex.aksw.org/mex-algo#CHAID</seealso>
    let CHAID = Prefixed_Name(mexalgo, "CHAID") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:CHAMELEON</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#CHAMELEON">http://mex.aksw.org/mex-algo#CHAMELEON</seealso>
    let CHAMELEON = Prefixed_Name(mexalgo, "CHAMELEON") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:CLARA</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#CLARA">http://mex.aksw.org/mex-algo#CLARA</seealso>
    let CLARA = Prefixed_Name(mexalgo, "CLARA") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:CLARANS</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#CLARANS">http://mex.aksw.org/mex-algo#CLARANS</seealso>
    let CLARANS = Prefixed_Name(mexalgo, "CLARANS") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:CPlusPlus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#CPlusPlus">http://mex.aksw.org/mex-algo#CPlusPlus</seealso>
    let CPlusPlus = Prefixed_Name(mexalgo, "CPlusPlus") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:CURE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#CURE">http://mex.aksw.org/mex-algo#CURE</seealso>
    let CURE = Prefixed_Name(mexalgo, "CURE") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Centura</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Centura">http://mex.aksw.org/mex-algo#Centura</seealso>
    let Centura = Prefixed_Name(mexalgo, "Centura") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Classification">http://mex.aksw.org/mex-algo#Classification</seealso>
    let Classification = Prefixed_Name(mexalgo, "Classification") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Clustering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Clustering">http://mex.aksw.org/mex-algo#Clustering</seealso>
    let Clustering = Prefixed_Name(mexalgo, "Clustering") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:CrossValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#CrossValidation">http://mex.aksw.org/mex-algo#CrossValidation</seealso>
    let CrossValidation = Prefixed_Name(mexalgo, "CrossValidation") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:DL-Learner</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#DL-Learner">http://mex.aksw.org/mex-algo#DL-Learner</seealso>
    let DL_Learner = Prefixed_Name(mexalgo, "DL-Learner") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:DL-Learning</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#DL-Learning">http://mex.aksw.org/mex-algo#DL-Learning</seealso>
    let DL_Learning = Prefixed_Name(mexalgo, "DL-Learning") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:DLLearner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#DLLearner">http://mex.aksw.org/mex-algo#DLLearner</seealso>
    let DLLearner = Prefixed_Name(mexalgo, "DLLearner") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:DecisionStump</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#DecisionStump">http://mex.aksw.org/mex-algo#DecisionStump</seealso>
    let DecisionStump = Prefixed_Name(mexalgo, "DecisionStump") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:DecisionTrees</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#DecisionTrees">http://mex.aksw.org/mex-algo#DecisionTrees</seealso>
    let DecisionTrees = Prefixed_Name(mexalgo, "DecisionTrees") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:DecisionTreesAlgorithms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#DecisionTreesAlgorithms">http://mex.aksw.org/mex-algo#DecisionTreesAlgorithms</seealso>
    let DecisionTreesAlgorithms =
        Prefixed_Name(mexalgo, "DecisionTreesAlgorithms") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:DescriptiveMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"are typically unsupervised and are used to induce interesting patterns (such as association rules) from unlabeled data. The induced patterns are useful in exploratory data analysis."</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#DescriptiveMethod">http://mex.aksw.org/mex-algo#DescriptiveMethod</seealso>
    let DescriptiveMethod = Prefixed_Name(mexalgo, "DescriptiveMethod") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:DotNet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#DotNet">http://mex.aksw.org/mex-algo#DotNet</seealso>
    let DotNet = Prefixed_Name(mexalgo, "DotNet") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:ELKI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#ELKI">http://mex.aksw.org/mex-algo#ELKI</seealso>
    let ELKI = Prefixed_Name(mexalgo, "ELKI") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:EViews</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#EViews">http://mex.aksw.org/mex-algo#EViews</seealso>
    let EViews = Prefixed_Name(mexalgo, "EViews") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Encog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Encog">http://mex.aksw.org/mex-algo#Encog</seealso>
    let Encog = Prefixed_Name(mexalgo, "Encog") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:EnsambleTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#EnsambleTechnique">http://mex.aksw.org/mex-algo#EnsambleTechnique</seealso>
    let EnsambleTechnique = Prefixed_Name(mexalgo, "EnsambleTechnique") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:FAMa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#FAMa">http://mex.aksw.org/mex-algo#FAMa</seealso>
    let FAMa = Prefixed_Name(mexalgo, "FAMa") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:FP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#FP">http://mex.aksw.org/mex-algo#FP</seealso>
    let FP = Prefixed_Name(mexalgo, "FP") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:FP-growth</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#FP-growth">http://mex.aksw.org/mex-algo#FP-growth</seealso>
    let FP_growth = Prefixed_Name(mexalgo, "FP-growth") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:ForClassificationProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#ForClassificationProblem">http://mex.aksw.org/mex-algo#ForClassificationProblem</seealso>
    let ForClassificationProblem =
        Prefixed_Name(mexalgo, "ForClassificationProblem") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:GA</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#GA">http://mex.aksw.org/mex-algo#GA</seealso>
    let GA = Prefixed_Name(mexalgo, "GA") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:GaussianRBF</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#GaussianRBF">http://mex.aksw.org/mex-algo#GaussianRBF</seealso>
    let GaussianRBF = Prefixed_Name(mexalgo, "GaussianRBF") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:GeneticAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#GeneticAlgorithm">http://mex.aksw.org/mex-algo#GeneticAlgorithm</seealso>
    let GeneticAlgorithm = Prefixed_Name(mexalgo, "GeneticAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:GeneticAlgorithms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#GeneticAlgorithms">http://mex.aksw.org/mex-algo#GeneticAlgorithms</seealso>
    let GeneticAlgorithms = Prefixed_Name(mexalgo, "GeneticAlgorithms") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:GraphKernel</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#GraphKernel">http://mex.aksw.org/mex-algo#GraphKernel</seealso>
    let GraphKernel = Prefixed_Name(mexalgo, "GraphKernel") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:H2O</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#H2O">http://mex.aksw.org/mex-algo#H2O</seealso>
    let H2O = Prefixed_Name(mexalgo, "H2O") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Holdout</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Holdout">http://mex.aksw.org/mex-algo#Holdout</seealso>
    let Holdout = Prefixed_Name(mexalgo, "Holdout") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:HybridAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#HybridAlgorithm">http://mex.aksw.org/mex-algo#HybridAlgorithm</seealso>
    let HybridAlgorithm = Prefixed_Name(mexalgo, "HybridAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:IBMMiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#IBMMiner">http://mex.aksw.org/mex-algo#IBMMiner</seealso>
    let IBMMiner = Prefixed_Name(mexalgo, "IBMMiner") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:ID3</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#ID3">http://mex.aksw.org/mex-algo#ID3</seealso>
    let ID3 = Prefixed_Name(mexalgo, "ID3") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:INDUCE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#INDUCE">http://mex.aksw.org/mex-algo#INDUCE</seealso>
    let INDUCE = Prefixed_Name(mexalgo, "INDUCE") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Implementation">http://mex.aksw.org/mex-algo#Implementation</seealso>
    let Implementation = Prefixed_Name(mexalgo, "Implementation") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:InductiveLogicProgramming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ILP"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#InductiveLogicProgramming">http://mex.aksw.org/mex-algo#InductiveLogicProgramming</seealso>
    let InductiveLogicProgramming =
        Prefixed_Name(mexalgo, "InductiveLogicProgramming") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:J48</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#J48">http://mex.aksw.org/mex-algo#J48</seealso>
    let J48 = Prefixed_Name(mexalgo, "J48") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:J48Graft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#J48Graft">http://mex.aksw.org/mex-algo#J48Graft</seealso>
    let J48Graft = Prefixed_Name(mexalgo, "J48Graft") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Java</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Java">http://mex.aksw.org/mex-algo#Java</seealso>
    let Java = Prefixed_Name(mexalgo, "Java") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:JavaScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#JavaScript">http://mex.aksw.org/mex-algo#JavaScript</seealso>
    let JavaScript = Prefixed_Name(mexalgo, "JavaScript") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Julia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Julia">http://mex.aksw.org/mex-algo#Julia</seealso>
    let Julia = Prefixed_Name(mexalgo, "Julia") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:K-means</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#K-means">http://mex.aksw.org/mex-algo#K-means</seealso>
    let K_means = Prefixed_Name(mexalgo, "K-means") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:KNIME</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#KNIME">http://mex.aksw.org/mex-algo#KNIME</seealso>
    let KNIME = Prefixed_Name(mexalgo, "KNIME") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:KXEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#KXEN">http://mex.aksw.org/mex-algo#KXEN</seealso>
    let KXEN = Prefixed_Name(mexalgo, "KXEN") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Kmeans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Kmeans">http://mex.aksw.org/mex-algo#Kmeans</seealso>
    let Kmeans = Prefixed_Name(mexalgo, "Kmeans") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:LADTree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#LADTree">http://mex.aksw.org/mex-algo#LADTree</seealso>
    let LADTree = Prefixed_Name(mexalgo, "LADTree") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:LIONsolver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#LIONsolver">http://mex.aksw.org/mex-algo#LIONsolver</seealso>
    let LIONsolver = Prefixed_Name(mexalgo, "LIONsolver") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:LMT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#LMT">http://mex.aksw.org/mex-algo#LMT</seealso>
    let LMT = Prefixed_Name(mexalgo, "LMT") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:LearningMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Supervised Learning, Unsupervised Learning, Semi-supervised Learning, Reinforcement Learning, ..."</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#LearningMethod">http://mex.aksw.org/mex-algo#LearningMethod</seealso>
    let LearningMethod = Prefixed_Name(mexalgo, "LearningMethod") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:LearningProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ValuePartition that describes only values from Regression, Classification or Clustering. NB Subclasses can themselves be divided up into further partitions."</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#LearningProblem">http://mex.aksw.org/mex-algo#LearningProblem</seealso>
    let LearningProblem = Prefixed_Name(mexalgo, "LearningProblem") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:LibLinear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#LibLinear">http://mex.aksw.org/mex-algo#LibLinear</seealso>
    let LibLinear = Prefixed_Name(mexalgo, "LibLinear") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:LibSVM</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#LibSVM">http://mex.aksw.org/mex-algo#LibSVM</seealso>
    let LibSVM = Prefixed_Name(mexalgo, "LibSVM") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Library">http://mex.aksw.org/mex-algo#Library</seealso>
    let Library = Prefixed_Name(mexalgo, "Library") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Linear</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Linear">http://mex.aksw.org/mex-algo#Linear</seealso>
    let Linear = Prefixed_Name(mexalgo, "Linear") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:LinearRegression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#LinearRegression">http://mex.aksw.org/mex-algo#LinearRegression</seealso>
    let LinearRegression = Prefixed_Name(mexalgo, "LinearRegression") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Linear_Regression</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Linear_Regression">http://mex.aksw.org/mex-algo#Linear_Regression</seealso>
    let Linear_Regression = Prefixed_Name(mexalgo, "Linear_Regression") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:LogicalRepresentations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#LogicalRepresentations">http://mex.aksw.org/mex-algo#LogicalRepresentations</seealso>
    let LogicalRepresentations =
        Prefixed_Name(mexalgo, "LogicalRepresentations") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:LogisticRegression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#LogisticRegression">http://mex.aksw.org/mex-algo#LogisticRegression</seealso>
    let LogisticRegression =
        Prefixed_Name(mexalgo, "LogisticRegression") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:Logistic_Regression</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Logistic_Regression">http://mex.aksw.org/mex-algo#Logistic_Regression</seealso>
    let Logistic_Regression =
        Prefixed_Name(mexalgo, "Logistic_Regression") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:MARS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#MARS">http://mex.aksw.org/mex-algo#MARS</seealso>
    let MARS = Prefixed_Name(mexalgo, "MARS") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:MLPACK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#MLPACK">http://mex.aksw.org/mex-algo#MLPACK</seealso>
    let MLPACK = Prefixed_Name(mexalgo, "MLPACK") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Markov</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Markov">http://mex.aksw.org/mex-algo#Markov</seealso>
    let Markov = Prefixed_Name(mexalgo, "Markov") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:MassiveOnlineAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MOA"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#MassiveOnlineAnalysis">http://mex.aksw.org/mex-algo#MassiveOnlineAnalysis</seealso>
    let MassiveOnlineAnalysis =
        Prefixed_Name(mexalgo, "MassiveOnlineAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:Mathematica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Mathematica">http://mex.aksw.org/mex-algo#Mathematica</seealso>
    let Mathematica = Prefixed_Name(mexalgo, "Mathematica") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Matlab</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Matlab">http://mex.aksw.org/mex-algo#Matlab</seealso>
    let Matlab = Prefixed_Name(mexalgo, "Matlab") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Metaheuristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Metaheuristic">http://mex.aksw.org/mex-algo#Metaheuristic</seealso>
    let Metaheuristic = Prefixed_Name(mexalgo, "Metaheuristic") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:MicrosoftAzureMachineLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AZURE"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#MicrosoftAzureMachineLearning">http://mex.aksw.org/mex-algo#MicrosoftAzureMachineLearning</seealso>
    let MicrosoftAzureMachineLearning =
        Prefixed_Name(mexalgo, "MicrosoftAzureMachineLearning") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:Microsoft_SQL_Server</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Microsoft_SQL_Server">http://mex.aksw.org/mex-algo#Microsoft_SQL_Server</seealso>
    let Microsoft_SQL_Server =
        Prefixed_Name(mexalgo, "Microsoft_SQL_Server") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:MonteCarloMachineLearningLibrary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#MonteCarloMachineLearningLibrary">http://mex.aksw.org/mex-algo#MonteCarloMachineLearningLibrary</seealso>
    let MonteCarloMachineLearningLibrary =
        Prefixed_Name(mexalgo, "MonteCarloMachineLearningLibrary") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:NBTree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#NBTree">http://mex.aksw.org/mex-algo#NBTree</seealso>
    let NBTree = Prefixed_Name(mexalgo, "NBTree") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:NN-BackPropagation</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#NN-BackPropagation">http://mex.aksw.org/mex-algo#NN-BackPropagation</seealso>
    let NN_BackPropagation =
        Prefixed_Name(mexalgo, "NN-BackPropagation") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:NaiveBayes</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"In machine learning, naive Bayes classifiers are a family of simple probabilistic classifiers based on applying Bayes' theorem with strong (naive) independence assumptions between the features.
    ///
    /// Naive Bayes has been studied extensively since the 1950s. It was introduced under a different name into the text retrieval community in the early 1960s:488 and remains a popular (baseline) method for text categorization, the problem of judging documents as belonging to one category or the other (such as spam or legitimate, sports or politics, etc.) with word frequencies as the features. With appropriate preprocessing, it is competitive in this domain with more advanced methods including support vector machines.It also finds application in automatic medical diagnosis.
    ///
    /// Naive Bayes classifiers are highly scalable, requiring a number of parameters linear in the number of variables (features/predictors) in a learning problem. Maximum-likelihood training can be done by evaluating a closed-form expression, which takes linear time, rather than by expensive iterative approximation as used for many other types of classifiers.
    ///
    /// In the statistics and computer science literature, Naive Bayes models are known under a variety of names, including simple Bayes and independence Bayes.[4] All these names reference the use of Bayes' theorem in the classifier's decision rule, but naive Bayes is not (necessarily) a Bayesian method Russell and Norvig note that "[naive Bayes] is sometimes called a Bayesian classifier, a somewhat careless usage that has prompted true Bayesians to call it the idiot Bayes model."</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#NaiveBayes">http://mex.aksw.org/mex-algo#NaiveBayes</seealso>
    let NaiveBayes = Prefixed_Name(mexalgo, "NaiveBayes") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Naive_Bayes</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Naive_Bayes">http://mex.aksw.org/mex-algo#Naive_Bayes</seealso>
    let Naive_Bayes = Prefixed_Name(mexalgo, "Naive_Bayes") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:NamedAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The basic information regarding the algorithms used into the experiment"</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#NamedAlgorithm">http://mex.aksw.org/mex-algo#NamedAlgorithm</seealso>
    let NamedAlgorithm = Prefixed_Name(mexalgo, "NamedAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#NamedIndividual">http://mex.aksw.org/mex-algo#NamedIndividual</seealso>
    let NamedIndividual = Prefixed_Name(mexalgo, "NamedIndividual") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:NearestNeigbour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#NearestNeigbour">http://mex.aksw.org/mex-algo#NearestNeigbour</seealso>
    let NearestNeigbour = Prefixed_Name(mexalgo, "NearestNeigbour") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:NearestNeighbour</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#NearestNeighbour">http://mex.aksw.org/mex-algo#NearestNeighbour</seealso>
    let NearestNeighbour = Prefixed_Name(mexalgo, "NearestNeighbour") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Nearest_Neighbour</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>"k-NN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Nearest_Neighbour">http://mex.aksw.org/mex-algo#Nearest_Neighbour</seealso>
    let Nearest_Neighbour = Prefixed_Name(mexalgo, "Nearest_Neighbour") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:NeuralNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#NeuralNetwork">http://mex.aksw.org/mex-algo#NeuralNetwork</seealso>
    let NeuralNetwork = Prefixed_Name(mexalgo, "NeuralNetwork") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:NeuroSolutions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#NeuroSolutions">http://mex.aksw.org/mex-algo#NeuroSolutions</seealso>
    let NeuroSolutions = Prefixed_Name(mexalgo, "NeuroSolutions") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:NodeJS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#NodeJS">http://mex.aksw.org/mex-algo#NodeJS</seealso>
    let NodeJS = Prefixed_Name(mexalgo, "NodeJS") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:OPTICS</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#OPTICS">http://mex.aksw.org/mex-algo#OPTICS</seealso>
    let OPTICS = Prefixed_Name(mexalgo, "OPTICS") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Octave</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Octave">http://mex.aksw.org/mex-algo#Octave</seealso>
    let Octave = Prefixed_Name(mexalgo, "Octave") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:OpenCV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#OpenCV">http://mex.aksw.org/mex-algo#OpenCV</seealso>
    let OpenCV = Prefixed_Name(mexalgo, "OpenCV") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:OpenNN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#OpenNN">http://mex.aksw.org/mex-algo#OpenNN</seealso>
    let OpenNN = Prefixed_Name(mexalgo, "OpenNN") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:OracleDataMining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#OracleDataMining">http://mex.aksw.org/mex-algo#OracleDataMining</seealso>
    let OracleDataMining = Prefixed_Name(mexalgo, "OracleDataMining") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Orange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Orange">http://mex.aksw.org/mex-algo#Orange</seealso>
    let Orange = Prefixed_Name(mexalgo, "Orange") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Other">http://mex.aksw.org/mex-algo#Other</seealso>
    let Other = Prefixed_Name(mexalgo, "Other") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:PHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#PHP">http://mex.aksw.org/mex-algo#PHP</seealso>
    let PHP = Prefixed_Name(mexalgo, "PHP") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:PathKernel</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#PathKernel">http://mex.aksw.org/mex-algo#PathKernel</seealso>
    let PathKernel = Prefixed_Name(mexalgo, "PathKernel") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Polynomial</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Polynomial">http://mex.aksw.org/mex-algo#Polynomial</seealso>
    let Polynomial = Prefixed_Name(mexalgo, "Polynomial") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:PredictiveMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"they are used to induce models or theories from class-labeled data"</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#PredictiveMethod">http://mex.aksw.org/mex-algo#PredictiveMethod</seealso>
    let PredictiveMethod = Prefixed_Name(mexalgo, "PredictiveMethod") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:ProbabilisticSoftLogic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#ProbabilisticSoftLogic">http://mex.aksw.org/mex-algo#ProbabilisticSoftLogic</seealso>
    let ProbabilisticSoftLogic =
        Prefixed_Name(mexalgo, "ProbabilisticSoftLogic") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:Python</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Python">http://mex.aksw.org/mex-algo#Python</seealso>
    let Python = Prefixed_Name(mexalgo, "Python") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:R</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#R">http://mex.aksw.org/mex-algo#R</seealso>
    let R = Prefixed_Name(mexalgo, "R") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:R-SVM</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#R-SVM">http://mex.aksw.org/mex-algo#R-SVM</seealso>
    let R_SVM = Prefixed_Name(mexalgo, "R-SVM") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:RCASE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#RCASE">http://mex.aksw.org/mex-algo#RCASE</seealso>
    let RCASE = Prefixed_Name(mexalgo, "RCASE") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:REPTree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#REPTree">http://mex.aksw.org/mex-algo#REPTree</seealso>
    let REPTree = Prefixed_Name(mexalgo, "REPTree") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:RandomCrossValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#RandomCrossValidation">http://mex.aksw.org/mex-algo#RandomCrossValidation</seealso>
    let RandomCrossValidation =
        Prefixed_Name(mexalgo, "RandomCrossValidation") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:RandomForest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>"Random forests are an ensemble learning method for classification, regression and other tasks, that operate by constructing a multitude of decision trees at training time and outputting the class that is the mode of the classes (classification) or mean prediction (regression) of the individual trees. Random forests correct for decision trees' habit of overfitting to their training set."</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#RandomForest">http://mex.aksw.org/mex-algo#RandomForest</seealso>
    let RandomForest = Prefixed_Name(mexalgo, "RandomForest") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:RapidMiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#RapidMiner">http://mex.aksw.org/mex-algo#RapidMiner</seealso>
    let RapidMiner = Prefixed_Name(mexalgo, "RapidMiner") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Regression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Regression">http://mex.aksw.org/mex-algo#Regression</seealso>
    let Regression = Prefixed_Name(mexalgo, "Regression") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:RegressionAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#RegressionAnalysis">http://mex.aksw.org/mex-algo#RegressionAnalysis</seealso>
    let RegressionAnalysis =
        Prefixed_Name(mexalgo, "RegressionAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:RegressionFunctions</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#RegressionFunctions">http://mex.aksw.org/mex-algo#RegressionFunctions</seealso>
    let RegressionFunctions =
        Prefixed_Name(mexalgo, "RegressionFunctions") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:Reinforcement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Reinforcement">http://mex.aksw.org/mex-algo#Reinforcement</seealso>
    let Reinforcement = Prefixed_Name(mexalgo, "Reinforcement") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Ruby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Ruby">http://mex.aksw.org/mex-algo#Ruby</seealso>
    let Ruby = Prefixed_Name(mexalgo, "Ruby") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Rules</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Rules">http://mex.aksw.org/mex-algo#Rules</seealso>
    let Rules = Prefixed_Name(mexalgo, "Rules") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:SAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SAP">http://mex.aksw.org/mex-algo#SAP</seealso>
    let SAP = Prefixed_Name(mexalgo, "SAP") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:SAS</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SAS">http://mex.aksw.org/mex-algo#SAS</seealso>
    let SAS = Prefixed_Name(mexalgo, "SAS") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:SASEnterpriseMiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SAS"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SASEnterpriseMiner">http://mex.aksw.org/mex-algo#SASEnterpriseMiner</seealso>
    let SASEnterpriseMiner =
        Prefixed_Name(mexalgo, "SASEnterpriseMiner") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:SPSS</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SPSS">http://mex.aksw.org/mex-algo#SPSS</seealso>
    let SPSS = Prefixed_Name(mexalgo, "SPSS") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:SQLServerAnalysisServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SQLServerAnalysisServices">http://mex.aksw.org/mex-algo#SQLServerAnalysisServices</seealso>
    let SQLServerAnalysisServices =
        Prefixed_Name(mexalgo, "SQLServerAnalysisServices") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:STATISTICADataMiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"STATISTICA"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#STATISTICADataMiner">http://mex.aksw.org/mex-algo#STATISTICADataMiner</seealso>
    let STATISTICADataMiner =
        Prefixed_Name(mexalgo, "STATISTICADataMiner") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:SVM</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SVM">http://mex.aksw.org/mex-algo#SVM</seealso>
    let SVM = Prefixed_Name(mexalgo, "SVM") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:SemiSupervised</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SemiSupervised">http://mex.aksw.org/mex-algo#SemiSupervised</seealso>
    let SemiSupervised = Prefixed_Name(mexalgo, "SemiSupervised") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Shogun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Shogun">http://mex.aksw.org/mex-algo#Shogun</seealso>
    let Shogun = Prefixed_Name(mexalgo, "Shogun") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Sigmoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Sigmoid">http://mex.aksw.org/mex-algo#Sigmoid</seealso>
    let Sigmoid = Prefixed_Name(mexalgo, "Sigmoid") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:SimpleCart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SimpleCart">http://mex.aksw.org/mex-algo#SimpleCart</seealso>
    let SimpleCart = Prefixed_Name(mexalgo, "SimpleCart") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Stata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Stata">http://mex.aksw.org/mex-algo#Stata</seealso>
    let Stata = Prefixed_Name(mexalgo, "Stata") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:StatisticalApproach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#StatisticalApproach">http://mex.aksw.org/mex-algo#StatisticalApproach</seealso>
    let StatisticalApproach =
        Prefixed_Name(mexalgo, "StatisticalApproach") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:StringKernel</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#StringKernel">http://mex.aksw.org/mex-algo#StringKernel</seealso>
    let StringKernel = Prefixed_Name(mexalgo, "StringKernel") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Summarization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Summarization">http://mex.aksw.org/mex-algo#Summarization</seealso>
    let Summarization = Prefixed_Name(mexalgo, "Summarization") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Supervised</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Supervised learning assumes that trainning examples are classified (labeled by class labels)"</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Supervised">http://mex.aksw.org/mex-algo#Supervised</seealso>
    let Supervised = Prefixed_Name(mexalgo, "Supervised") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:SupervisedApproach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SupervisedApproach">http://mex.aksw.org/mex-algo#SupervisedApproach</seealso>
    let SupervisedApproach =
        Prefixed_Name(mexalgo, "SupervisedApproach") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:SupportVectorMachines</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"In machine learning, support vector machines (SVMs, also support vector networks) are supervised learning models with associated learning algorithms that analyze data and recognize patterns, used for classification and regression analysis. Given a set of training examples, each marked as belonging to one of two categories, an SVM training algorithm builds a model that assigns new examples into one category or the other, making it a non-probabilistic binary linear classifier. An SVM model is a representation of the examples as points in space, mapped so that the examples of the separate categories are divided by a clear gap that is as wide as possible. New examples are then mapped into that same space and predicted to belong to a category based on which side of the gap they fall on.
    ///
    /// In addition to performing linear classification, SVMs can efficiently perform a non-linear classification using what is called the kernel trick, implicitly mapping their inputs into high-dimensional feature spaces."</para>
    /// labels<para>"SVM"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SupportVectorMachines">http://mex.aksw.org/mex-algo#SupportVectorMachines</seealso>
    let SupportVectorMachines =
        Prefixed_Name(mexalgo, "SupportVectorMachines") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:SupportVectorNetworks</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SupportVectorNetworks">http://mex.aksw.org/mex-algo#SupportVectorNetworks</seealso>
    let SupportVectorNetworks =
        Prefixed_Name(mexalgo, "SupportVectorNetworks") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:SymbolicApproach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#SymbolicApproach">http://mex.aksw.org/mex-algo#SymbolicApproach</seealso>
    let SymbolicApproach = Prefixed_Name(mexalgo, "SymbolicApproach") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Test</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Test">http://mex.aksw.org/mex-algo#Test</seealso>
    let Test = Prefixed_Name(mexalgo, "Test") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Trainning</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Trainning">http://mex.aksw.org/mex-algo#Trainning</seealso>
    let Trainning = Prefixed_Name(mexalgo, "Trainning") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:TreeKernel</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#TreeKernel">http://mex.aksw.org/mex-algo#TreeKernel</seealso>
    let TreeKernel = Prefixed_Name(mexalgo, "TreeKernel") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Unsupervised</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    ///   <para>"Unsupervised learning concerns the analysis of unclassified examples"</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Unsupervised">http://mex.aksw.org/mex-algo#Unsupervised</seealso>
    let Unsupervised = Prefixed_Name(mexalgo, "Unsupervised") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:UnsupervisedApproach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#UnsupervisedApproach">http://mex.aksw.org/mex-algo#UnsupervisedApproach</seealso>
    let UnsupervisedApproach =
        Prefixed_Name(mexalgo, "UnsupervisedApproach") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:UserClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#UserClassifier">http://mex.aksw.org/mex-algo#UserClassifier</seealso>
    let UserClassifier = Prefixed_Name(mexalgo, "UserClassifier") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Validation">http://mex.aksw.org/mex-algo#Validation</seealso>
    let Validation = Prefixed_Name(mexalgo, "Validation") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:WEKA</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#WEKA">http://mex.aksw.org/mex-algo#WEKA</seealso>
    let WEKA = Prefixed_Name(mexalgo, "WEKA") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Weka</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Weka">http://mex.aksw.org/mex-algo#Weka</seealso>
    let Weka = Prefixed_Name(mexalgo, "Weka") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:YALE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#YALE">http://mex.aksw.org/mex-algo#YALE</seealso>
    let YALE = Prefixed_Name(mexalgo, "YALE") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:Yooreeka</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#Yooreeka">http://mex.aksw.org/mex-algo#Yooreeka</seealso>
    let Yooreeka = Prefixed_Name(mexalgo, "Yooreeka") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#acronym">http://mex.aksw.org/mex-algo#acronym</seealso>
    let acronym = Prefixed_Name(mexalgo, "acronym") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:hasAlgorithmConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#hasAlgorithmConfiguration">http://mex.aksw.org/mex-algo#hasAlgorithmConfiguration</seealso>
    let hasAlgorithmConfiguration =
        Prefixed_Name(mexalgo, "hasAlgorithmConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:hasAlgorithmParameterCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#hasAlgorithmParameterCollection">http://mex.aksw.org/mex-algo#hasAlgorithmParameterCollection</seealso>
    let hasAlgorithmParameterCollection =
        Prefixed_Name(mexalgo, "hasAlgorithmParameterCollection") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:hasClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#hasClass">http://mex.aksw.org/mex-algo#hasClass</seealso>
    let hasClass = Prefixed_Name(mexalgo, "hasClass") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:hasImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#hasImplementation">http://mex.aksw.org/mex-algo#hasImplementation</seealso>
    let hasImplementation = Prefixed_Name(mexalgo, "hasImplementation") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:hasLearningMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#hasLearningMethod">http://mex.aksw.org/mex-algo#hasLearningMethod</seealso>
    let hasLearningMethod = Prefixed_Name(mexalgo, "hasLearningMethod") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:hasLearningProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#hasLearningProblem">http://mex.aksw.org/mex-algo#hasLearningProblem</seealso>
    let hasLearningProblem =
        Prefixed_Name(mexalgo, "hasLearningProblem") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:isAlgorithmConfigurationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#isAlgorithmConfigurationOf">http://mex.aksw.org/mex-algo#isAlgorithmConfigurationOf</seealso>
    let isAlgorithmConfigurationOf =
        Prefixed_Name(mexalgo, "isAlgorithmConfigurationOf") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:isAlgorithmParameterCollectionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#isAlgorithmParameterCollectionOf">http://mex.aksw.org/mex-algo#isAlgorithmParameterCollectionOf</seealso>
    let isAlgorithmParameterCollectionOf =
        Prefixed_Name(mexalgo, "isAlgorithmParameterCollectionOf") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:isClassOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#isClassOf">http://mex.aksw.org/mex-algo#isClassOf</seealso>
    let isClassOf = Prefixed_Name(mexalgo, "isClassOf") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:isImplementationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#isImplementationOf">http://mex.aksw.org/mex-algo#isImplementationOf</seealso>
    let isImplementationOf =
        Prefixed_Name(mexalgo, "isImplementationOf") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:isLearningMethodOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#isLearningMethodOf">http://mex.aksw.org/mex-algo#isLearningMethodOf</seealso>
    let isLearningMethodOf =
        Prefixed_Name(mexalgo, "isLearningMethodOf") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:isLearningProblemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#isLearningProblemOf">http://mex.aksw.org/mex-algo#isLearningProblemOf</seealso>
    let isLearningProblemOf =
        Prefixed_Name(mexalgo, "isLearningProblemOf") |> PrefixedName

    /// <summary>
    ///   <para>mexalgo:k-means</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#k-means">http://mex.aksw.org/mex-algo#k-means</seealso>
    let k_means = Prefixed_Name(mexalgo, "k-means") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:mlpy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#mlpy">http://mex.aksw.org/mex-algo#mlpy</seealso>
    let mlpy = Prefixed_Name(mexalgo, "mlpy") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:parametro1</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#parametro1">http://mex.aksw.org/mex-algo#parametro1</seealso>
    let parametro1 = Prefixed_Name(mexalgo, "parametro1") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:parametro2</para>
    /// </summary>
    /// <remarks>
    ///   <para>mexalgo:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#parametro2">http://mex.aksw.org/mex-algo#parametro2</seealso>
    let parametro2 = Prefixed_Name(mexalgo, "parametro2") |> PrefixedName
    /// <summary>
    ///   <para>mexalgo:scikit-learn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-algo#scikit-learn">http://mex.aksw.org/mex-algo#scikit-learn</seealso>
    let scikit_learn = Prefixed_Name(mexalgo, "scikit-learn") |> PrefixedName
