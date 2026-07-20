namespace http.mex.aksw.org.mex_perf.hash

open DoxAletheia

module mexperf =
    let _namespace_name = "http://mex.aksw.org/mex-perf#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#ClassificationMeasure"></see>
    /// </summary>
    let ClassificationMeasure = _prefix "ClassificationMeasure"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#PerformanceMeasure"></see>
    /// </summary>
    let PerformanceMeasure = _prefix "PerformanceMeasure"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#ClusteringMeasure"></see>
    /// </summary>
    let ClusteringMeasure = _prefix "ClusteringMeasure"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#ExamplePerformanceMeasure"></see>
    /// </summary>
    let ExamplePerformanceMeasure = _prefix "ExamplePerformanceMeasure"

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#ExamplePerformanceMeasureCollection"></see>
    /// </summary>
    let ExamplePerformanceMeasureCollection =
        _prefix "ExamplePerformanceMeasureCollection"

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#ExecutionPerformance"></see>
    /// </summary>
    let ExecutionPerformance = _prefix "ExecutionPerformance"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#L1norm"></see>
    /// </summary>
    let L1norm = _prefix "L1norm"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#StatisticalMeasure"></see>
    /// </summary>
    let StatisticalMeasure = _prefix "StatisticalMeasure"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#L2norm"></see>
    /// </summary>
    let L2norm = _prefix "L2norm"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#Linfnorm"></see>
    /// </summary>
    let Linfnorm = _prefix "Linfnorm"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#RegressionMeasure"></see>
    /// </summary>
    let RegressionMeasure = _prefix "RegressionMeasure"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#UserDefinedMeasure"></see>
    /// </summary>
    let UserDefinedMeasure = _prefix "UserDefinedMeasure"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#UserDefinedMeasureCollection"></see>
    /// </summary>
    let UserDefinedMeasureCollection = _prefix "UserDefinedMeasureCollection"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#accuracy"></see>
    /// </summary>
    let accuracy = _prefix "accuracy"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#bonferroniDunn"></see>
    /// </summary>
    let bonferroniDunn = _prefix "bonferroniDunn"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#chebyschevDistance"></see>
    /// </summary>
    let chebyschevDistance = _prefix "chebyschevDistance"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#chiSquare"></see>
    /// </summary>
    let chiSquare = _prefix "chiSquare"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#correlationCoefficient"></see>
    /// </summary>
    let correlationCoefficient = _prefix "correlationCoefficient"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#cosine"></see>
    /// </summary>
    let cosine = _prefix "cosine"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#costParameter"></see>
    /// </summary>
    let costParameter = _prefix "costParameter"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#error"></see>
    /// </summary>
    let error = _prefix "error"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#euclideanDistance"></see>
    /// </summary>
    let euclideanDistance = _prefix "euclideanDistance"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#f1Measure"></see>
    /// </summary>
    let f1Measure = _prefix "f1Measure"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#falseNegative"></see>
    /// </summary>
    let falseNegative = _prefix "falseNegative"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#falseNegativeRate"></see>
    /// </summary>
    let falseNegativeRate = _prefix "falseNegativeRate"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#falsePositive"></see>
    /// </summary>
    let falsePositive = _prefix "falsePositive"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#falsePositiveRate"></see>
    /// </summary>
    let falsePositiveRate = _prefix "falsePositiveRate"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#folds"></see>
    /// </summary>
    let folds = _prefix "folds"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#formula"></see>
    /// </summary>
    let formula = _prefix "formula"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#friedman"></see>
    /// </summary>
    let friedman = _prefix "friedman"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#genSimilarityCoefficient"></see>
    /// </summary>
    let genSimilarityCoefficient = _prefix "genSimilarityCoefficient"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#hammingDistance"></see>
    /// </summary>
    let hammingDistance = _prefix "hammingDistance"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#kappaStatistics"></see>
    /// </summary>
    let kappaStatistics = _prefix "kappaStatistics"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#kernel"></see>
    /// </summary>
    let kernel = _prefix "kernel"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#kolmogorovSmirnov"></see>
    /// </summary>
    let kolmogorovSmirnov = _prefix "kolmogorovSmirnov"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#manhattanDistance"></see>
    /// </summary>
    let manhattanDistance = _prefix "manhattanDistance"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#mean"></see>
    /// </summary>
    let mean = _prefix "mean"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#meanAbsoluteDeviation"></see>
    /// </summary>
    let meanAbsoluteDeviation = _prefix "meanAbsoluteDeviation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#meanSquaredError"></see>
    /// </summary>
    let meanSquaredError = _prefix "meanSquaredError"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#median"></see>
    /// </summary>
    let median = _prefix "median"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#medianAbsoluteDeviation"></see>
    /// </summary>
    let medianAbsoluteDeviation = _prefix "medianAbsoluteDeviation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#mode"></see>
    /// </summary>
    let mode = _prefix "mode"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#nemenyi"></see>
    /// </summary>
    let nemenyi = _prefix "nemenyi"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#pearsonCorrelation"></see>
    /// </summary>
    let pearsonCorrelation = _prefix "pearsonCorrelation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#pmi"></see>
    /// </summary>
    let pmi = _prefix "pmi"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#precision"></see>
    /// </summary>
    let precision = _prefix "precision"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#predictedValue"></see>
    /// </summary>
    let predictedValue = _prefix "predictedValue"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#realValue"></see>
    /// </summary>
    let realValue = _prefix "realValue"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#recall"></see>
    /// </summary>
    let recall = _prefix "recall"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#relativeAbsoluteError"></see>
    /// </summary>
    let relativeAbsoluteError = _prefix "relativeAbsoluteError"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#residual"></see>
    /// </summary>
    let residual = _prefix "residual"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#roc"></see>
    /// </summary>
    let roc = _prefix "roc"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#rootMeanSquaredError"></see>
    /// </summary>
    let rootMeanSquaredError = _prefix "rootMeanSquaredError"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#rootRelativeSquaredError"></see>
    /// </summary>
    let rootRelativeSquaredError = _prefix "rootRelativeSquaredError"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#sensitivity"></see>
    /// </summary>
    let sensitivity = _prefix "sensitivity"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#specificity"></see>
    /// </summary>
    let specificity = _prefix "specificity"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#spmi"></see>
    /// </summary>
    let spmi = _prefix "spmi"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#standardDeviation"></see>
    /// </summary>
    let standardDeviation = _prefix "standardDeviation"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#totalError"></see>
    /// </summary>
    let totalError = _prefix "totalError"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#trueNegative"></see>
    /// </summary>
    let trueNegative = _prefix "trueNegative"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#trueNegativeRate"></see>
    /// </summary>
    let trueNegativeRate = _prefix "trueNegativeRate"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#truePositive"></see>
    /// </summary>
    let truePositive = _prefix "truePositive"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#truePositiveRate"></see>
    /// </summary>
    let truePositiveRate = _prefix "truePositiveRate"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#variance"></see>
    /// </summary>
    let variance = _prefix "variance"
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#wilcoxon"></see>
    /// </summary>
    let wilcoxon = _prefix "wilcoxon"
