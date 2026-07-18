namespace http.mex.aksw.org.mex_perf.hash

open DoxAletheia.Rdf_Vocabulary

module mexperf =
    let _namespace_name = "http://mex.aksw.org/mex-perf#"

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#ClassificationMeasure"></see>
    /// </summary>
    let ClassificationMeasure =
        Namespaced_IRI.parse _namespace_name "ClassificationMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#PerformanceMeasure"></see>
    /// </summary>
    let PerformanceMeasure =
        Namespaced_IRI.parse _namespace_name "PerformanceMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#ClusteringMeasure"></see>
    /// </summary>
    let ClusteringMeasure =
        Namespaced_IRI.parse _namespace_name "ClusteringMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#ExamplePerformanceMeasure"></see>
    /// </summary>
    let ExamplePerformanceMeasure =
        Namespaced_IRI.parse _namespace_name "ExamplePerformanceMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#ExamplePerformanceMeasureCollection"></see>
    /// </summary>
    let ExamplePerformanceMeasureCollection =
        Namespaced_IRI.parse _namespace_name "ExamplePerformanceMeasureCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#ExecutionPerformance"></see>
    /// </summary>
    let ExecutionPerformance =
        Namespaced_IRI.parse _namespace_name "ExecutionPerformance" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#L1norm"></see>
    /// </summary>
    let L1norm = Namespaced_IRI.parse _namespace_name "L1norm" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#StatisticalMeasure"></see>
    /// </summary>
    let StatisticalMeasure =
        Namespaced_IRI.parse _namespace_name "StatisticalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#L2norm"></see>
    /// </summary>
    let L2norm = Namespaced_IRI.parse _namespace_name "L2norm" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#Linfnorm"></see>
    /// </summary>
    let Linfnorm = Namespaced_IRI.parse _namespace_name "Linfnorm" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#RegressionMeasure"></see>
    /// </summary>
    let RegressionMeasure =
        Namespaced_IRI.parse _namespace_name "RegressionMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#UserDefinedMeasure"></see>
    /// </summary>
    let UserDefinedMeasure =
        Namespaced_IRI.parse _namespace_name "UserDefinedMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#UserDefinedMeasureCollection"></see>
    /// </summary>
    let UserDefinedMeasureCollection =
        Namespaced_IRI.parse _namespace_name "UserDefinedMeasureCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#accuracy"></see>
    /// </summary>
    let accuracy = Namespaced_IRI.parse _namespace_name "accuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#bonferroniDunn"></see>
    /// </summary>
    let bonferroniDunn =
        Namespaced_IRI.parse _namespace_name "bonferroniDunn" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#chebyschevDistance"></see>
    /// </summary>
    let chebyschevDistance =
        Namespaced_IRI.parse _namespace_name "chebyschevDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#chiSquare"></see>
    /// </summary>
    let chiSquare = Namespaced_IRI.parse _namespace_name "chiSquare" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#correlationCoefficient"></see>
    /// </summary>
    let correlationCoefficient =
        Namespaced_IRI.parse _namespace_name "correlationCoefficient" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#cosine"></see>
    /// </summary>
    let cosine = Namespaced_IRI.parse _namespace_name "cosine" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#costParameter"></see>
    /// </summary>
    let costParameter =
        Namespaced_IRI.parse _namespace_name "costParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#error"></see>
    /// </summary>
    let error = Namespaced_IRI.parse _namespace_name "error" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#euclideanDistance"></see>
    /// </summary>
    let euclideanDistance =
        Namespaced_IRI.parse _namespace_name "euclideanDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#f1Measure"></see>
    /// </summary>
    let f1Measure = Namespaced_IRI.parse _namespace_name "f1Measure" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#falseNegative"></see>
    /// </summary>
    let falseNegative =
        Namespaced_IRI.parse _namespace_name "falseNegative" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#falseNegativeRate"></see>
    /// </summary>
    let falseNegativeRate =
        Namespaced_IRI.parse _namespace_name "falseNegativeRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#falsePositive"></see>
    /// </summary>
    let falsePositive =
        Namespaced_IRI.parse _namespace_name "falsePositive" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#falsePositiveRate"></see>
    /// </summary>
    let falsePositiveRate =
        Namespaced_IRI.parse _namespace_name "falsePositiveRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#folds"></see>
    /// </summary>
    let folds = Namespaced_IRI.parse _namespace_name "folds" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#formula"></see>
    /// </summary>
    let formula = Namespaced_IRI.parse _namespace_name "formula" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#friedman"></see>
    /// </summary>
    let friedman = Namespaced_IRI.parse _namespace_name "friedman" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#genSimilarityCoefficient"></see>
    /// </summary>
    let genSimilarityCoefficient =
        Namespaced_IRI.parse _namespace_name "genSimilarityCoefficient" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#hammingDistance"></see>
    /// </summary>
    let hammingDistance =
        Namespaced_IRI.parse _namespace_name "hammingDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#kappaStatistics"></see>
    /// </summary>
    let kappaStatistics =
        Namespaced_IRI.parse _namespace_name "kappaStatistics" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#kernel"></see>
    /// </summary>
    let kernel = Namespaced_IRI.parse _namespace_name "kernel" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#kolmogorovSmirnov"></see>
    /// </summary>
    let kolmogorovSmirnov =
        Namespaced_IRI.parse _namespace_name "kolmogorovSmirnov" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#manhattanDistance"></see>
    /// </summary>
    let manhattanDistance =
        Namespaced_IRI.parse _namespace_name "manhattanDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#mean"></see>
    /// </summary>
    let mean = Namespaced_IRI.parse _namespace_name "mean" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#meanAbsoluteDeviation"></see>
    /// </summary>
    let meanAbsoluteDeviation =
        Namespaced_IRI.parse _namespace_name "meanAbsoluteDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#meanSquaredError"></see>
    /// </summary>
    let meanSquaredError =
        Namespaced_IRI.parse _namespace_name "meanSquaredError" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#median"></see>
    /// </summary>
    let median = Namespaced_IRI.parse _namespace_name "median" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#medianAbsoluteDeviation"></see>
    /// </summary>
    let medianAbsoluteDeviation =
        Namespaced_IRI.parse _namespace_name "medianAbsoluteDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#mode"></see>
    /// </summary>
    let mode = Namespaced_IRI.parse _namespace_name "mode" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#nemenyi"></see>
    /// </summary>
    let nemenyi = Namespaced_IRI.parse _namespace_name "nemenyi" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#pearsonCorrelation"></see>
    /// </summary>
    let pearsonCorrelation =
        Namespaced_IRI.parse _namespace_name "pearsonCorrelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#pmi"></see>
    /// </summary>
    let pmi = Namespaced_IRI.parse _namespace_name "pmi" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#precision"></see>
    /// </summary>
    let precision = Namespaced_IRI.parse _namespace_name "precision" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#predictedValue"></see>
    /// </summary>
    let predictedValue =
        Namespaced_IRI.parse _namespace_name "predictedValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#realValue"></see>
    /// </summary>
    let realValue = Namespaced_IRI.parse _namespace_name "realValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#recall"></see>
    /// </summary>
    let recall = Namespaced_IRI.parse _namespace_name "recall" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#relativeAbsoluteError"></see>
    /// </summary>
    let relativeAbsoluteError =
        Namespaced_IRI.parse _namespace_name "relativeAbsoluteError" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#residual"></see>
    /// </summary>
    let residual = Namespaced_IRI.parse _namespace_name "residual" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#roc"></see>
    /// </summary>
    let roc = Namespaced_IRI.parse _namespace_name "roc" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#rootMeanSquaredError"></see>
    /// </summary>
    let rootMeanSquaredError =
        Namespaced_IRI.parse _namespace_name "rootMeanSquaredError" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#rootRelativeSquaredError"></see>
    /// </summary>
    let rootRelativeSquaredError =
        Namespaced_IRI.parse _namespace_name "rootRelativeSquaredError" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#sensitivity"></see>
    /// </summary>
    let sensitivity =
        Namespaced_IRI.parse _namespace_name "sensitivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#specificity"></see>
    /// </summary>
    let specificity =
        Namespaced_IRI.parse _namespace_name "specificity" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#spmi"></see>
    /// </summary>
    let spmi = Namespaced_IRI.parse _namespace_name "spmi" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#standardDeviation"></see>
    /// </summary>
    let standardDeviation =
        Namespaced_IRI.parse _namespace_name "standardDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#totalError"></see>
    /// </summary>
    let totalError = Namespaced_IRI.parse _namespace_name "totalError" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#trueNegative"></see>
    /// </summary>
    let trueNegative =
        Namespaced_IRI.parse _namespace_name "trueNegative" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#trueNegativeRate"></see>
    /// </summary>
    let trueNegativeRate =
        Namespaced_IRI.parse _namespace_name "trueNegativeRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#truePositive"></see>
    /// </summary>
    let truePositive =
        Namespaced_IRI.parse _namespace_name "truePositive" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#truePositiveRate"></see>
    /// </summary>
    let truePositiveRate =
        Namespaced_IRI.parse _namespace_name "truePositiveRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#variance"></see>
    /// </summary>
    let variance = Namespaced_IRI.parse _namespace_name "variance" |> NamespacedName
    /// <summary>
    ///   <see href="http://mex.aksw.org/mex-perf#wilcoxon"></see>
    /// </summary>
    let wilcoxon = Namespaced_IRI.parse _namespace_name "wilcoxon" |> NamespacedName
