namespace https.spec.edmcouncil.org.fibo.ontology.FND.Utilities.Analytics.slash

open DoxAletheia

module fibo_fnd_utl_alx =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/AnnualizedStandardDeviation"></see>
    /// </summary>
    let AnnualizedStandardDeviation = _prefix "AnnualizedStandardDeviation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StandardDeviation"></see>
    /// </summary>
    let StandardDeviation = _prefix "StandardDeviation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReferencePeriod"></see>
    /// </summary>
    let hasReferencePeriod = _prefix "hasReferencePeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/ArithmeticMean"></see>
    /// </summary>
    let ArithmeticMean = _prefix "ArithmeticMean"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Mean"></see>
    /// </summary>
    let Mean = _prefix "Mean"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/AverageAbsoluteDeviation"></see>
    /// </summary>
    let AverageAbsoluteDeviation = _prefix "AverageAbsoluteDeviation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Dispersion"></see>
    /// </summary>
    let Dispersion = _prefix "Dispersion"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Median"></see>
    /// </summary>
    let Median = _prefix "Median"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Difference"></see>
    /// </summary>
    let Difference = _prefix "Difference"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalMeasure"></see>
    /// </summary>
    let StatisticalMeasure = _prefix "StatisticalMeasure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMinuend"></see>
    /// </summary>
    let hasMinuend = _prefix "hasMinuend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasSubtrahend"></see>
    /// </summary>
    let hasSubtrahend = _prefix "hasSubtrahend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasObservedValue"></see>
    /// </summary>
    let hasObservedValue = _prefix "hasObservedValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/FinitePopulation"></see>
    /// </summary>
    let FinitePopulation = _prefix "FinitePopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Formula"></see>
    /// </summary>
    let Formula = _prefix "Formula"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/GeometricMean"></see>
    /// </summary>
    let GeometricMean = _prefix "GeometricMean"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/KeyPerformanceIndicator"></see>
    /// </summary>
    let KeyPerformanceIndicator = _prefix "KeyPerformanceIndicator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/QualifiedMeasure"></see>
    /// </summary>
    let QualifiedMeasure = _prefix "QualifiedMeasure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasTargetValue"></see>
    /// </summary>
    let hasTargetValue = _prefix "hasTargetValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/MedianAbsoluteDeviation"></see>
    /// </summary>
    let MedianAbsoluteDeviation = _prefix "MedianAbsoluteDeviation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/NumericIndexValue"></see>
    /// </summary>
    let NumericIndexValue = _prefix "NumericIndexValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMeasurementDateTime"></see>
    /// </summary>
    let hasMeasurementDateTime = _prefix "hasMeasurementDateTime"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/isCalculatedViaMethodology"></see>
    /// </summary>
    let isCalculatedViaMethodology = _prefix "isCalculatedViaMethodology"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/SamplingVariance"></see>
    /// </summary>
    let SamplingVariance = _prefix "SamplingVariance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Variance"></see>
    /// </summary>
    let Variance = _prefix "Variance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/ScopedMeasure"></see>
    /// </summary>
    let ScopedMeasure = _prefix "ScopedMeasure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasPeriodicity"></see>
    /// </summary>
    let hasPeriodicity = _prefix "hasPeriodicity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalArea"></see>
    /// </summary>
    let StatisticalArea = _prefix "StatisticalArea"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalAreaIdentifier"></see>
    /// </summary>
    let StatisticalAreaIdentifier = _prefix "StatisticalAreaIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/isEstimate"></see>
    /// </summary>
    let isEstimate = _prefix "isEstimate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalPopulation"></see>
    /// </summary>
    let StatisticalPopulation = _prefix "StatisticalPopulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalUniverse"></see>
    /// </summary>
    let StatisticalUniverse = _prefix "StatisticalUniverse"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasPopulationSize"></see>
    /// </summary>
    let hasPopulationSize = _prefix "hasPopulationSize"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalProgram"></see>
    /// </summary>
    let StatisticalProgram = _prefix "StatisticalProgram"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasUniverseSize"></see>
    /// </summary>
    let hasUniverseSize = _prefix "hasUniverseSize"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/WeightingFunction"></see>
    /// </summary>
    let WeightingFunction = _prefix "WeightingFunction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasFixedComparativeDate"></see>
    /// </summary>
    let hasFixedComparativeDate = _prefix "hasFixedComparativeDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasFormula"></see>
    /// </summary>
    let hasFormula = _prefix "hasFormula"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMeasurementPeriodInMonths"></see>
    /// </summary>
    let hasMeasurementPeriodInMonths = _prefix "hasMeasurementPeriodInMonths"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasNumberOfEntries"></see>
    /// </summary>
    let hasNumberOfEntries = _prefix "hasNumberOfEntries"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasRelativeComparativeDate"></see>
    /// </summary>
    let hasRelativeComparativeDate = _prefix "hasRelativeComparativeDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasRelativeComparativePeriod"></see>
    /// </summary>
    let hasRelativeComparativePeriod = _prefix "hasRelativeComparativePeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReleaseDate"></see>
    /// </summary>
    let hasReleaseDate = _prefix "hasReleaseDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReleaseDateTime"></see>
    /// </summary>
    let hasReleaseDateTime = _prefix "hasReleaseDateTime"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasWeight"></see>
    /// </summary>
    let hasWeight = _prefix "hasWeight"
