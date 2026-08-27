namespace http.mex.aksw.org.mex_perf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mexperf =
    let _namespace_iri = Namespace_Iri mexperf |> NamespaceIRI

    /// <summary>
    ///   <para>mexperf:ClassificationMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#ClassificationMeasure">http://mex.aksw.org/mex-perf#ClassificationMeasure</seealso>
    let ClassificationMeasure =
        Prefixed_Name(mexperf, "ClassificationMeasure") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:ClusteringMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#ClusteringMeasure">http://mex.aksw.org/mex-perf#ClusteringMeasure</seealso>
    let ClusteringMeasure = Prefixed_Name(mexperf, "ClusteringMeasure") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:ExamplePerformanceMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#ExamplePerformanceMeasure">http://mex.aksw.org/mex-perf#ExamplePerformanceMeasure</seealso>
    let ExamplePerformanceMeasure =
        Prefixed_Name(mexperf, "ExamplePerformanceMeasure") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:ExamplePerformanceMeasureCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#ExamplePerformanceMeasureCollection">http://mex.aksw.org/mex-perf#ExamplePerformanceMeasureCollection</seealso>
    let ExamplePerformanceMeasureCollection =
        Prefixed_Name(mexperf, "ExamplePerformanceMeasureCollection") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:ExecutionPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#ExecutionPerformance">http://mex.aksw.org/mex-perf#ExecutionPerformance</seealso>
    let ExecutionPerformance =
        Prefixed_Name(mexperf, "ExecutionPerformance") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:L1norm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#L1norm">http://mex.aksw.org/mex-perf#L1norm</seealso>
    let L1norm = Prefixed_Name(mexperf, "L1norm") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:L2norm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#L2norm">http://mex.aksw.org/mex-perf#L2norm</seealso>
    let L2norm = Prefixed_Name(mexperf, "L2norm") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:Linfnorm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#Linfnorm">http://mex.aksw.org/mex-perf#Linfnorm</seealso>
    let Linfnorm = Prefixed_Name(mexperf, "Linfnorm") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:PerformanceMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#PerformanceMeasure">http://mex.aksw.org/mex-perf#PerformanceMeasure</seealso>
    let PerformanceMeasure =
        Prefixed_Name(mexperf, "PerformanceMeasure") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:RegressionMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#RegressionMeasure">http://mex.aksw.org/mex-perf#RegressionMeasure</seealso>
    let RegressionMeasure = Prefixed_Name(mexperf, "RegressionMeasure") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:StatisticalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#StatisticalMeasure">http://mex.aksw.org/mex-perf#StatisticalMeasure</seealso>
    let StatisticalMeasure =
        Prefixed_Name(mexperf, "StatisticalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:UserDefinedMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#UserDefinedMeasure">http://mex.aksw.org/mex-perf#UserDefinedMeasure</seealso>
    let UserDefinedMeasure =
        Prefixed_Name(mexperf, "UserDefinedMeasure") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:UserDefinedMeasureCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#UserDefinedMeasureCollection">http://mex.aksw.org/mex-perf#UserDefinedMeasureCollection</seealso>
    let UserDefinedMeasureCollection =
        Prefixed_Name(mexperf, "UserDefinedMeasureCollection") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#accuracy">http://mex.aksw.org/mex-perf#accuracy</seealso>
    let accuracy = Prefixed_Name(mexperf, "accuracy") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:bonferroniDunn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#bonferroniDunn">http://mex.aksw.org/mex-perf#bonferroniDunn</seealso>
    let bonferroniDunn = Prefixed_Name(mexperf, "bonferroniDunn") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:chebyschevDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#chebyschevDistance">http://mex.aksw.org/mex-perf#chebyschevDistance</seealso>
    let chebyschevDistance =
        Prefixed_Name(mexperf, "chebyschevDistance") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:chiSquare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#chiSquare">http://mex.aksw.org/mex-perf#chiSquare</seealso>
    let chiSquare = Prefixed_Name(mexperf, "chiSquare") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:correlationCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#correlationCoefficient">http://mex.aksw.org/mex-perf#correlationCoefficient</seealso>
    let correlationCoefficient =
        Prefixed_Name(mexperf, "correlationCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:cosine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#cosine">http://mex.aksw.org/mex-perf#cosine</seealso>
    let cosine = Prefixed_Name(mexperf, "cosine") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:costParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#costParameter">http://mex.aksw.org/mex-perf#costParameter</seealso>
    let costParameter = Prefixed_Name(mexperf, "costParameter") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:error</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#error">http://mex.aksw.org/mex-perf#error</seealso>
    let error = Prefixed_Name(mexperf, "error") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:euclideanDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#euclideanDistance">http://mex.aksw.org/mex-perf#euclideanDistance</seealso>
    let euclideanDistance = Prefixed_Name(mexperf, "euclideanDistance") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:f1Measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#f1Measure">http://mex.aksw.org/mex-perf#f1Measure</seealso>
    let f1Measure = Prefixed_Name(mexperf, "f1Measure") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:falseNegative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#falseNegative">http://mex.aksw.org/mex-perf#falseNegative</seealso>
    let falseNegative = Prefixed_Name(mexperf, "falseNegative") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:falseNegativeRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#falseNegativeRate">http://mex.aksw.org/mex-perf#falseNegativeRate</seealso>
    let falseNegativeRate = Prefixed_Name(mexperf, "falseNegativeRate") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:falsePositive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#falsePositive">http://mex.aksw.org/mex-perf#falsePositive</seealso>
    let falsePositive = Prefixed_Name(mexperf, "falsePositive") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:falsePositiveRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#falsePositiveRate">http://mex.aksw.org/mex-perf#falsePositiveRate</seealso>
    let falsePositiveRate = Prefixed_Name(mexperf, "falsePositiveRate") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:folds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#folds">http://mex.aksw.org/mex-perf#folds</seealso>
    let folds = Prefixed_Name(mexperf, "folds") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#formula">http://mex.aksw.org/mex-perf#formula</seealso>
    let formula = Prefixed_Name(mexperf, "formula") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:friedman</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#friedman">http://mex.aksw.org/mex-perf#friedman</seealso>
    let friedman = Prefixed_Name(mexperf, "friedman") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:genSimilarityCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#genSimilarityCoefficient">http://mex.aksw.org/mex-perf#genSimilarityCoefficient</seealso>
    let genSimilarityCoefficient =
        Prefixed_Name(mexperf, "genSimilarityCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:hammingDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#hammingDistance">http://mex.aksw.org/mex-perf#hammingDistance</seealso>
    let hammingDistance = Prefixed_Name(mexperf, "hammingDistance") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:kappaStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#kappaStatistics">http://mex.aksw.org/mex-perf#kappaStatistics</seealso>
    let kappaStatistics = Prefixed_Name(mexperf, "kappaStatistics") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:kernel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#kernel">http://mex.aksw.org/mex-perf#kernel</seealso>
    let kernel = Prefixed_Name(mexperf, "kernel") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:kolmogorovSmirnov</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#kolmogorovSmirnov">http://mex.aksw.org/mex-perf#kolmogorovSmirnov</seealso>
    let kolmogorovSmirnov = Prefixed_Name(mexperf, "kolmogorovSmirnov") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:manhattanDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#manhattanDistance">http://mex.aksw.org/mex-perf#manhattanDistance</seealso>
    let manhattanDistance = Prefixed_Name(mexperf, "manhattanDistance") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:mean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#mean">http://mex.aksw.org/mex-perf#mean</seealso>
    let mean = Prefixed_Name(mexperf, "mean") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:meanAbsoluteDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#meanAbsoluteDeviation">http://mex.aksw.org/mex-perf#meanAbsoluteDeviation</seealso>
    let meanAbsoluteDeviation =
        Prefixed_Name(mexperf, "meanAbsoluteDeviation") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:meanSquaredError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#meanSquaredError">http://mex.aksw.org/mex-perf#meanSquaredError</seealso>
    let meanSquaredError = Prefixed_Name(mexperf, "meanSquaredError") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:median</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#median">http://mex.aksw.org/mex-perf#median</seealso>
    let median = Prefixed_Name(mexperf, "median") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:medianAbsoluteDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#medianAbsoluteDeviation">http://mex.aksw.org/mex-perf#medianAbsoluteDeviation</seealso>
    let medianAbsoluteDeviation =
        Prefixed_Name(mexperf, "medianAbsoluteDeviation") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#mode">http://mex.aksw.org/mex-perf#mode</seealso>
    let mode = Prefixed_Name(mexperf, "mode") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:nemenyi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#nemenyi">http://mex.aksw.org/mex-perf#nemenyi</seealso>
    let nemenyi = Prefixed_Name(mexperf, "nemenyi") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:pearsonCorrelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#pearsonCorrelation">http://mex.aksw.org/mex-perf#pearsonCorrelation</seealso>
    let pearsonCorrelation =
        Prefixed_Name(mexperf, "pearsonCorrelation") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:pmi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Pointwise mutual information"</para></remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#pmi">http://mex.aksw.org/mex-perf#pmi</seealso>
    let pmi = Prefixed_Name(mexperf, "pmi") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:precision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#precision">http://mex.aksw.org/mex-perf#precision</seealso>
    let precision = Prefixed_Name(mexperf, "precision") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:predictedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#predictedValue">http://mex.aksw.org/mex-perf#predictedValue</seealso>
    let predictedValue = Prefixed_Name(mexperf, "predictedValue") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:realValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#realValue">http://mex.aksw.org/mex-perf#realValue</seealso>
    let realValue = Prefixed_Name(mexperf, "realValue") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:recall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#recall">http://mex.aksw.org/mex-perf#recall</seealso>
    let recall = Prefixed_Name(mexperf, "recall") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:relativeAbsoluteError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#relativeAbsoluteError">http://mex.aksw.org/mex-perf#relativeAbsoluteError</seealso>
    let relativeAbsoluteError =
        Prefixed_Name(mexperf, "relativeAbsoluteError") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:residual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#residual">http://mex.aksw.org/mex-perf#residual</seealso>
    let residual = Prefixed_Name(mexperf, "residual") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:roc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#roc">http://mex.aksw.org/mex-perf#roc</seealso>
    let roc = Prefixed_Name(mexperf, "roc") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:rootMeanSquaredError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#rootMeanSquaredError">http://mex.aksw.org/mex-perf#rootMeanSquaredError</seealso>
    let rootMeanSquaredError =
        Prefixed_Name(mexperf, "rootMeanSquaredError") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:rootRelativeSquaredError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#rootRelativeSquaredError">http://mex.aksw.org/mex-perf#rootRelativeSquaredError</seealso>
    let rootRelativeSquaredError =
        Prefixed_Name(mexperf, "rootRelativeSquaredError") |> PrefixedName

    /// <summary>
    ///   <para>mexperf:sensitivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#sensitivity">http://mex.aksw.org/mex-perf#sensitivity</seealso>
    let sensitivity = Prefixed_Name(mexperf, "sensitivity") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:specificity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#specificity">http://mex.aksw.org/mex-perf#specificity</seealso>
    let specificity = Prefixed_Name(mexperf, "specificity") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:spmi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#spmi">http://mex.aksw.org/mex-perf#spmi</seealso>
    let spmi = Prefixed_Name(mexperf, "spmi") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:standardDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#standardDeviation">http://mex.aksw.org/mex-perf#standardDeviation</seealso>
    let standardDeviation = Prefixed_Name(mexperf, "standardDeviation") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:totalError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#totalError">http://mex.aksw.org/mex-perf#totalError</seealso>
    let totalError = Prefixed_Name(mexperf, "totalError") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:trueNegative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#trueNegative">http://mex.aksw.org/mex-perf#trueNegative</seealso>
    let trueNegative = Prefixed_Name(mexperf, "trueNegative") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:trueNegativeRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#trueNegativeRate">http://mex.aksw.org/mex-perf#trueNegativeRate</seealso>
    let trueNegativeRate = Prefixed_Name(mexperf, "trueNegativeRate") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:truePositive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#truePositive">http://mex.aksw.org/mex-perf#truePositive</seealso>
    let truePositive = Prefixed_Name(mexperf, "truePositive") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:truePositiveRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#truePositiveRate">http://mex.aksw.org/mex-perf#truePositiveRate</seealso>
    let truePositiveRate = Prefixed_Name(mexperf, "truePositiveRate") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:variance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#variance">http://mex.aksw.org/mex-perf#variance</seealso>
    let variance = Prefixed_Name(mexperf, "variance") |> PrefixedName
    /// <summary>
    ///   <para>mexperf:wilcoxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://mex.aksw.org/mex-perf#wilcoxon">http://mex.aksw.org/mex-perf#wilcoxon</seealso>
    let wilcoxon = Prefixed_Name(mexperf, "wilcoxon") |> PrefixedName
