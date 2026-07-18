namespace https.spec.edmcouncil.org.fibo.ontology.FND.Utilities.Analytics.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_utl_alx =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/AnnualizedStandardDeviation"></see>
    /// </summary>
    let AnnualizedStandardDeviation =
        Namespaced_IRI.parse _namespace_name "AnnualizedStandardDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StandardDeviation"></see>
    /// </summary>
    let StandardDeviation =
        Namespaced_IRI.parse _namespace_name "StandardDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReferencePeriod"></see>
    /// </summary>
    let hasReferencePeriod =
        Namespaced_IRI.parse _namespace_name "hasReferencePeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/ArithmeticMean"></see>
    /// </summary>
    let ArithmeticMean =
        Namespaced_IRI.parse _namespace_name "ArithmeticMean" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Mean"></see>
    /// </summary>
    let Mean = Namespaced_IRI.parse _namespace_name "Mean" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/AverageAbsoluteDeviation"></see>
    /// </summary>
    let AverageAbsoluteDeviation =
        Namespaced_IRI.parse _namespace_name "AverageAbsoluteDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Dispersion"></see>
    /// </summary>
    let Dispersion = Namespaced_IRI.parse _namespace_name "Dispersion" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Median"></see>
    /// </summary>
    let Median = Namespaced_IRI.parse _namespace_name "Median" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Difference"></see>
    /// </summary>
    let Difference = Namespaced_IRI.parse _namespace_name "Difference" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalMeasure"></see>
    /// </summary>
    let StatisticalMeasure =
        Namespaced_IRI.parse _namespace_name "StatisticalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMinuend"></see>
    /// </summary>
    let hasMinuend = Namespaced_IRI.parse _namespace_name "hasMinuend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasSubtrahend"></see>
    /// </summary>
    let hasSubtrahend =
        Namespaced_IRI.parse _namespace_name "hasSubtrahend" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasObservedValue"></see>
    /// </summary>
    let hasObservedValue =
        Namespaced_IRI.parse _namespace_name "hasObservedValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/FinitePopulation"></see>
    /// </summary>
    let FinitePopulation =
        Namespaced_IRI.parse _namespace_name "FinitePopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Formula"></see>
    /// </summary>
    let Formula = Namespaced_IRI.parse _namespace_name "Formula" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/GeometricMean"></see>
    /// </summary>
    let GeometricMean =
        Namespaced_IRI.parse _namespace_name "GeometricMean" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/KeyPerformanceIndicator"></see>
    /// </summary>
    let KeyPerformanceIndicator =
        Namespaced_IRI.parse _namespace_name "KeyPerformanceIndicator" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/QualifiedMeasure"></see>
    /// </summary>
    let QualifiedMeasure =
        Namespaced_IRI.parse _namespace_name "QualifiedMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasTargetValue"></see>
    /// </summary>
    let hasTargetValue =
        Namespaced_IRI.parse _namespace_name "hasTargetValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/MedianAbsoluteDeviation"></see>
    /// </summary>
    let MedianAbsoluteDeviation =
        Namespaced_IRI.parse _namespace_name "MedianAbsoluteDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/NumericIndexValue"></see>
    /// </summary>
    let NumericIndexValue =
        Namespaced_IRI.parse _namespace_name "NumericIndexValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMeasurementDateTime"></see>
    /// </summary>
    let hasMeasurementDateTime =
        Namespaced_IRI.parse _namespace_name "hasMeasurementDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/isCalculatedViaMethodology"></see>
    /// </summary>
    let isCalculatedViaMethodology =
        Namespaced_IRI.parse _namespace_name "isCalculatedViaMethodology" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/SamplingVariance"></see>
    /// </summary>
    let SamplingVariance =
        Namespaced_IRI.parse _namespace_name "SamplingVariance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Variance"></see>
    /// </summary>
    let Variance = Namespaced_IRI.parse _namespace_name "Variance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/ScopedMeasure"></see>
    /// </summary>
    let ScopedMeasure =
        Namespaced_IRI.parse _namespace_name "ScopedMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasPeriodicity"></see>
    /// </summary>
    let hasPeriodicity =
        Namespaced_IRI.parse _namespace_name "hasPeriodicity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalArea"></see>
    /// </summary>
    let StatisticalArea =
        Namespaced_IRI.parse _namespace_name "StatisticalArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalAreaIdentifier"></see>
    /// </summary>
    let StatisticalAreaIdentifier =
        Namespaced_IRI.parse _namespace_name "StatisticalAreaIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/isEstimate"></see>
    /// </summary>
    let isEstimate = Namespaced_IRI.parse _namespace_name "isEstimate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalPopulation"></see>
    /// </summary>
    let StatisticalPopulation =
        Namespaced_IRI.parse _namespace_name "StatisticalPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalUniverse"></see>
    /// </summary>
    let StatisticalUniverse =
        Namespaced_IRI.parse _namespace_name "StatisticalUniverse" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasPopulationSize"></see>
    /// </summary>
    let hasPopulationSize =
        Namespaced_IRI.parse _namespace_name "hasPopulationSize" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalProgram"></see>
    /// </summary>
    let StatisticalProgram =
        Namespaced_IRI.parse _namespace_name "StatisticalProgram" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasUniverseSize"></see>
    /// </summary>
    let hasUniverseSize =
        Namespaced_IRI.parse _namespace_name "hasUniverseSize" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/WeightingFunction"></see>
    /// </summary>
    let WeightingFunction =
        Namespaced_IRI.parse _namespace_name "WeightingFunction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasFixedComparativeDate"></see>
    /// </summary>
    let hasFixedComparativeDate =
        Namespaced_IRI.parse _namespace_name "hasFixedComparativeDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasFormula"></see>
    /// </summary>
    let hasFormula = Namespaced_IRI.parse _namespace_name "hasFormula" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMeasurementPeriodInMonths"></see>
    /// </summary>
    let hasMeasurementPeriodInMonths =
        Namespaced_IRI.parse _namespace_name "hasMeasurementPeriodInMonths" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasNumberOfEntries"></see>
    /// </summary>
    let hasNumberOfEntries =
        Namespaced_IRI.parse _namespace_name "hasNumberOfEntries" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasRelativeComparativeDate"></see>
    /// </summary>
    let hasRelativeComparativeDate =
        Namespaced_IRI.parse _namespace_name "hasRelativeComparativeDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasRelativeComparativePeriod"></see>
    /// </summary>
    let hasRelativeComparativePeriod =
        Namespaced_IRI.parse _namespace_name "hasRelativeComparativePeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReleaseDate"></see>
    /// </summary>
    let hasReleaseDate =
        Namespaced_IRI.parse _namespace_name "hasReleaseDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReleaseDateTime"></see>
    /// </summary>
    let hasReleaseDateTime =
        Namespaced_IRI.parse _namespace_name "hasReleaseDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasWeight"></see>
    /// </summary>
    let hasWeight = Namespaced_IRI.parse _namespace_name "hasWeight" |> NamespacedName
