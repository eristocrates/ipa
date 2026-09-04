#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mexperf =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://mex.aksw.org/mex-perf#" "mexperf"

    let ClassificationMeasure = _prefixId.prefix "ClassificationMeasure"
    let ClusteringMeasure = _prefixId.prefix "ClusteringMeasure"
    let ExamplePerformanceMeasure = _prefixId.prefix "ExamplePerformanceMeasure"

    let ExamplePerformanceMeasureCollection =
        _prefixId.prefix "ExamplePerformanceMeasureCollection"

    let ExecutionPerformance = _prefixId.prefix "ExecutionPerformance"
    let L1norm = _prefixId.prefix "L1norm"
    let L2norm = _prefixId.prefix "L2norm"
    let Linfnorm = _prefixId.prefix "Linfnorm"
    let PerformanceMeasure = _prefixId.prefix "PerformanceMeasure"
    let RegressionMeasure = _prefixId.prefix "RegressionMeasure"
    let StatisticalMeasure = _prefixId.prefix "StatisticalMeasure"
    let UserDefinedMeasure = _prefixId.prefix "UserDefinedMeasure"
    let UserDefinedMeasureCollection = _prefixId.prefix "UserDefinedMeasureCollection"
    let accuracy = _prefixId.prefix "accuracy"
    let bonferroniDunn = _prefixId.prefix "bonferroniDunn"
    let chebyschevDistance = _prefixId.prefix "chebyschevDistance"
    let chiSquare = _prefixId.prefix "chiSquare"
    let correlationCoefficient = _prefixId.prefix "correlationCoefficient"
    let cosine = _prefixId.prefix "cosine"
    let costParameter = _prefixId.prefix "costParameter"
    let error = _prefixId.prefix "error"
    let euclideanDistance = _prefixId.prefix "euclideanDistance"
    /// <summary>
    ///   <para>dce:description : F-measure or F-score or F1 score^^xsd:string</para>
    ///   <a href="http://mex.aksw.org/mex-perf#f1Measure">mexperf:f1Measure</a>
    /// </summary>
    let f1Measure = _prefixId.prefix "f1Measure"
    let falseNegative = _prefixId.prefix "falseNegative"
    let falseNegativeRate = _prefixId.prefix "falseNegativeRate"
    let falsePositive = _prefixId.prefix "falsePositive"
    let falsePositiveRate = _prefixId.prefix "falsePositiveRate"
    let folds = _prefixId.prefix "folds"
    let formula = _prefixId.prefix "formula"
    let friedman = _prefixId.prefix "friedman"
    let genSimilarityCoefficient = _prefixId.prefix "genSimilarityCoefficient"
    let hammingDistance = _prefixId.prefix "hammingDistance"
    let kappaStatistics = _prefixId.prefix "kappaStatistics"
    let kernel = _prefixId.prefix "kernel"
    let kolmogorovSmirnov = _prefixId.prefix "kolmogorovSmirnov"
    let manhattanDistance = _prefixId.prefix "manhattanDistance"
    let mean = _prefixId.prefix "mean"
    let meanAbsoluteDeviation = _prefixId.prefix "meanAbsoluteDeviation"
    let meanSquaredError = _prefixId.prefix "meanSquaredError"
    let median = _prefixId.prefix "median"
    let medianAbsoluteDeviation = _prefixId.prefix "medianAbsoluteDeviation"
    let mode = _prefixId.prefix "mode"
    let nemenyi = _prefixId.prefix "nemenyi"
    let pearsonCorrelation = _prefixId.prefix "pearsonCorrelation"
    /// <summary>
    ///   <para>rdfs:label : Pointwise mutual information</para>
    ///   <a href="http://mex.aksw.org/mex-perf#pmi">mexperf:pmi</a>
    /// </summary>
    let pmi = _prefixId.prefix "pmi"
    let precision = _prefixId.prefix "precision"
    let predictedValue = _prefixId.prefix "predictedValue"
    let realValue = _prefixId.prefix "realValue"
    let recall = _prefixId.prefix "recall"
    let relativeAbsoluteError = _prefixId.prefix "relativeAbsoluteError"
    let residual = _prefixId.prefix "residual"
    let roc = _prefixId.prefix "roc"
    let rootMeanSquaredError = _prefixId.prefix "rootMeanSquaredError"
    let rootRelativeSquaredError = _prefixId.prefix "rootRelativeSquaredError"
    let sensitivity = _prefixId.prefix "sensitivity"
    let specificity = _prefixId.prefix "specificity"
    let spmi = _prefixId.prefix "spmi"
    let standardDeviation = _prefixId.prefix "standardDeviation"
    let totalError = _prefixId.prefix "totalError"
    let trueNegative = _prefixId.prefix "trueNegative"
    let trueNegativeRate = _prefixId.prefix "trueNegativeRate"
    let truePositive = _prefixId.prefix "truePositive"
    let truePositiveRate = _prefixId.prefix "truePositiveRate"
    let variance = _prefixId.prefix "variance"
    let wilcoxon = _prefixId.prefix "wilcoxon"
